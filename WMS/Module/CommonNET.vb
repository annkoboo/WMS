Imports Oracle.DataAccess.Client
Imports System.Reflection.MethodInfo

Module CommonNET

    '**************************
    '　データベース処理Module
    '**************************

    Public Const cBackPath = ".\BackUpFile\"   'バックアップ用Pass
    Public Const cLogPath = ".\Log\"           '制御系ログ用Pass
    Public Const cErrPath = ".\ErrorLog\"     'エラー系ログ用Pass
    Public Const cLogName = "GamenLog"
    Public Const cSqlLogName = "SQL_LOG"  'SQLログ用ファイル名

    Public DbAcc As New ACCESS

    Public OraDB As New ACCESS.Oracle_Access 'Oracleデータベース（全画面共通）

    Public clsDgvSelect As New ClassDataGrid.DgvSelectRow

    Public Frm As New ClassForm             'フォーム関連のクラス

    Public Cd As New ClassCode              'コード体系のクラス

    ''Public SqlDB As New ACCESS.Sql_Access        'SQL_SERVERデータベース

    ''Public ptUser As CommonAdd.typTantou 'ユーザ情報格納用
    ''Public ptJisya As CommonAdd.typUser  'ユーザ自社情報格納用

    Public Const cShowMsg As Short = 0  '例外メッセージ表示フラグ　0:メッセージ表示　1:めっせーじ非表示

#Region "オラクル用"

    Public OraConnectCHECK = New Oracle.DataAccess.Client.OracleConnection

    '******************************************************************************************************************************
    ' オラクル用のOPENする前のオラクルが立ち上がっているかのチェック
    '返値trueでOK、falseでまだ立ち上がっていない。
    ' While(OraCHECK = False)
    ' End While
    ' のような使用方法をして下さい。その後オラクルopenを行ってください。
    '******************************************************************************************************************************
    Public Function OraCHECK() As Boolean
        Try
            OraConnectCHECK.ConnectionString = "user id=" & DbAcc.sUser & ";data source=" & DbAcc.sService & ";password=" & DbAcc.sPassword
            Call OraConnectCHECK.Open()
            OraCHECK = True
            Call OraConnectCHECK.Close()
        Catch ex As Oracle.DataAccess.Client.OracleException
            OraCHECK = False
        Catch ex As Exception

        End Try

    End Function


    '******************************************************************************************************************************
    ' オラクル用のエラーメッセージ用関数　ついでにLOGも作成します。
    ' オラクルエラーを拾う場所に入れる
    ' Pr_Name    : プログラム及び処理関数の名前
    ' shErrNo : エラーｺｰﾄﾞ
    ' sErrMsg :エラーメッセージ
    ' sSQL : ＳＱＬ文　使用してないときは入れない
    ' shMsgFlg：0：メッセージ表示　1：メッセージ非表示（ログのみ出力）
    '******************************************************************************************************************************
    Public Sub OraErrSub(ByVal Pr_Name As String, ByVal iErrNo As Integer, ByVal sErrMsg As String, ByVal oraEx As OracleException, ByVal sSQL As String, Optional ByVal shMsgFlg As Short = 0)
        Dim sErrWk As String
        Dim iRtn As Short

        sErrWk = "エラー発生！ [" & Pr_Name & "]" & vbCrLf & vbCrLf & "Error Code = [ " & Format(iErrNo, "0") & " ]" & vbCrLf & "Error 内容 = [ " & sErrMsg & " ]" & vbCrLf & "SQL文　内容 = [ " & sSQL & " ]" & vbCrLf & vbCrLf

        If shMsgFlg = 0 Then
            iRtn = MsgBox(sErrWk, MsgBoxStyle.OkOnly + MsgBoxStyle.Question)
        End If

        '20060928追加
        sErrMsg = sErrMsg & vbCrLf & "[StackTrace]" & oraEx.StackTrace

        Call OraErrLog(Pr_Name, iErrNo, sErrMsg, sSQL)
    End Sub


    '******************************************************************************************************************************
    ' オラクルエラー系のログ書き込み用関数（１ヶ月サイクルでの上書き更新）file名は　Err02.txt　等になります。
    ' cErrpath : LOGの直上のフォルダー名まで入力　
    '******************************************************************************************************************************
    Public Sub OraErrLog(ByVal Pr_Name As String, ByVal shErrNo As Short, ByVal sErrMsg As String, ByVal sSQL As String)
        'オラクルｴﾗｰ用ログ
        Dim sPass As String
        sPass = cErrPath & "Err" & Format(Now, "dd") & ".txt"
        If Dir(sPass, FileAttribute.Normal) = "" Then
            FileOpen(1, sPass, OpenMode.Output, OpenAccess.Write)
            WriteLine(1, Format(Now, "yyyy/MM/dd HH:mm:ss") & " " & "オラクルエラー発生！ [" & Pr_Name & "]" & vbCrLf & "                     " & "Error Code = [ " & Format(shErrNo, "0") & " ]" & vbCrLf & "                     " & "Error 内容 = [ " & sErrMsg & " ]" & vbCrLf & "                     " & "SQL文　内容 = [ " & sSQL & " ]")
            FileClose(1)
        Else
            FileOpen(1, sPass, OpenMode.Append, OpenAccess.Write)
            WriteLine(1, Format(Now, "yyyy/MM/dd HH:mm:ss") & " " & "オラクルエラー発生！ [" & Pr_Name & "]" & vbCrLf & "                     " & "Error Code = [ " & Format(shErrNo, "0") & " ]" & vbCrLf & "                     " & "Error 内容 = [ " & sErrMsg & " ]" & vbCrLf & "                     " & "SQL文　内容 = [ " & sSQL & " ]")
            FileClose(1)
        End If
    End Sub
#End Region


#Region "その他(ログ,スリープ etc)"
    '******************************************************************************************************************************
    ' .Net用のエラーメッセージ用関数　ついでにLOGも作成します。
    ' 全てのエラーを拾う場所に入れる
    ' Pr_Name    : プログラム及び処理関数の名前
    ' shErrNo : エラーｺｰﾄﾞ
    ' bEND : 常にfalseで
    ' iMsgFlg : 常に０で
    '******************************************************************************************************************************
    Public Sub vbErrSub(ByVal Pr_Name As String, ByVal shErrNo As Integer, ByVal Ex As Exception, Optional ByRef bEND As Boolean = False, Optional ByVal iMsgFlg As Short = 0)
        'エラー処理
        '(引数) Pr_Name[IN]:エラーが発生したプログラム/ルーチン名
        '       bEND[OUT]:強制終了チェックで使用
        '       iMsgBox[IN]:メッセージボックス表示有無 0=なし 1=あり
        '(戻り値) true=Resume処理 false=Resume Next処理

        Dim sErrWk As String
        Dim sDatWk As String
        Dim bRtn As Boolean
        Dim ExitFlg As Boolean
        Dim iRtn As Short

        '--エラー内容表示処理

        On Error Resume Next

        Select Case shErrNo
            Case 70, 3006, 3008, 3009, 3189, 3212, 3261, 3262
                '--- Dual Open Error
                'Call Sleep(150)
                ExitFlg = True
            Case 3260
                '--- Open出来ているのに更新できない場合は再度処理を行う(Accessで発生することがあるらしい)
                Call Sleep(5000)
                ExitFlg = True
                '        Case 440 'トランザクションはすでに処理中です
                '            '---COMMITTRANSしてRESUME
                '            OraSS.CommitTrans
                '            vbErrSub = True
                '            ExitFlg = True
            Case Else
                If iMsgFlg = 0 Then
                    sErrWk = "エラー発生！ [" & Pr_Name & "]" & vbCrLf & vbCrLf & "Error Code = [ " & Format(shErrNo, "0") & " ]" & vbCrLf & "Error 内容 = [ " & ErrorToString(shErrNo) & " ]" & vbCrLf & vbCrLf
                    sErrWk &= "[StackTrace]" & Ex.StackTrace & " "
                    iRtn = MsgBox(sErrWk, MsgBoxStyle.OkOnly + MsgBoxStyle.Question)
                Else
                    iRtn = MsgBoxResult.No
                End If

                If iRtn = MsgBoxResult.Yes Then
                    '--- Resume
                Else
                    '--- Resume Next

                    '端末機が存在するシステムでサーバとの接続が切れたときは終了する
                    '75=ﾊﾟｽ名が無効です。76=ﾊﾟｽが見つかりません
                    If shErrNo = 75 Or shErrNo = 76 Then
                        bEND = True
                    End If

                End If
                ExitFlg = False
        End Select

        If ExitFlg Then
        Else
            sDatWk = Pr_Name
            sDatWk = sDatWk & "[" & "VB Error "
            sDatWk = sDatWk & Format(shErrNo, "@@@@") & "]"
            sDatWk = sDatWk & ErrorToString(shErrNo)

            '20060928追加
            sDatWk = sDatWk & vbCrLf & "[StackTrace]" & Ex.StackTrace

        End If
        Call NetErrLog(Pr_Name, shErrNo)

    End Sub


    '******************************************************************************************************************************
    ' .Net用のエラーLOG作成用関数　
    ' 全てのエラーを拾う場所に入れる
    ' Pr_Name    : プログラム及び処理関数の名前
    ' shErrNo : エラーｺｰﾄﾞ
    ' bEND : 常にfalseで
    ' iMsgFlg : 常に０で
    '******************************************************************************************************************************
    Public Sub vbErrLog(ByVal Pr_Name As String, ByVal shErrNo As Integer, ByVal sERRMESEGE As String)
        'エラー処理
        '(引数) Pr_Name[IN]:エラーが発生したプログラム/ルーチン名
        '       bEND[OUT]:強制終了チェックで使用
        '       iMsgBox[IN]:メッセージボックス表示有無 0=なし 1=あり
        '(戻り値) true=Resume処理 false=Resume Next処理

        Dim sErrWk As String
        Dim sDatWk As String
        Dim bRtn As Boolean
        Dim ExitFlg As Boolean
        Dim iRtn As Short

        '--エラー内容表示処理

        On Error Resume Next

        Select Case shErrNo
            Case 70, 3006, 3008, 3009, 3189, 3212, 3261, 3262
                '--- Dual Open Error
                'Call Sleep(150)
                ExitFlg = True
            Case 3260
                '--- Open出来ているのに更新できない場合は再度処理を行う(Accessで発生することがあるらしい)
                Call Sleep(5000)
                ExitFlg = True
                '        Case 440 'トランザクションはすでに処理中です
                '            '---COMMITTRANSしてRESUME
                '            OraSS.CommitTrans
                '            vbErrSub = True
                '            ExitFlg = True
            Case Else
                sErrWk = "エラー発生！ [" & Pr_Name & "]" & vbCrLf & vbCrLf & "Error Code = [ " & Format(shErrNo, "0") & " ]" & vbCrLf & "Error 内容 = [ " & sERRMESEGE & " ]" & vbCrLf & vbCrLf
                'iRtn = MsgBox(sErrWk, MsgBoxStyle.OKOnly + MsgBoxStyle.Question)
                'If iRtn = MsgBoxResult.Yes Then
                '    '--- Resume
                'Else
                '    '--- Resume Next
                'End If
                'ExitFlg = False
        End Select

        If ExitFlg Then
        Else
            sDatWk = Pr_Name
            sDatWk = sDatWk & "[" & "VB Error "
            sDatWk = sDatWk & Format(shErrNo, "@@@@") & "]"
            sDatWk = sDatWk & ErrorToString(shErrNo)
        End If
        Call NetErrLog(Pr_Name, shErrNo)
    End Sub

    ''******************************************************************************************************************************
    '' クリスタルレポートエラーメッセージ用関数　ついでにLOGも作成します。
    '' 全てのエラーを拾う場所に入れる
    '' Pr_Name    : プログラム及び処理関数の名前
    '' shErrNo : エラーｺｰﾄﾞ
    '' bEND : 常にfalseで
    '' iMsgFlg : 常に０で
    ''******************************************************************************************************************************
    'Public Sub CrystalErrSub(ByVal Pr_Name As String, ByVal Ex As CrystalDecisions.CrystalReports.Engine.EngineException, ByVal sComment As String, Optional ByVal iMsgFlg As Short = 0)
    '    'エラー処理
    '    '(引数) Pr_Name[IN]:エラーが発生したプログラム/ルーチン名
    '    '       bEND[OUT]:強制終了チェックで使用
    '    '       iMsgBox[IN]:メッセージボックス表示有無 0=なし 1=あり
    '    '(戻り値) true=Resume処理 false=Resume Next処理

    '    Dim sErrWk As String
    '    Dim sDatWk As String
    '    Dim bRtn As Boolean
    '    Dim iRtn As Short

    '    '--エラー内容表示処理

    '    On Error Resume Next


    '    If iMsgFlg = 0 Then
    '        sErrWk = "エラー発生！ [" & Pr_Name & "]" & vbCrLf & vbCrLf & "Error Code = [ " & Ex.ErrorID & " ]" & vbCrLf & "Error 内容 = [ " & ErrorToString(Ex.ErrorID) & " ]" & vbCrLf & vbCrLf
    '        sErrWk &= "[StackTrace]" & Ex.StackTrace & " "
    '        iRtn = MsgBox(sErrWk, MsgBoxStyle.OkOnly + MsgBoxStyle.Question)
    '    End If


    '    sDatWk = ""
    '    sDatWk &= "[" & Ex.ErrorID & "]" & vbLf
    '    sDatWk &= Space(20) & Ex.Message & vbLf
    '    sDatWk &= Space(20) & "[StackTrace]" & Ex.StackTrace
    '    sDatWk &= Space(20) & "[" & sComment & "]"


    '    Call CrystalErrLog(Pr_Name, sDatWk)

    'End Sub

    ''******************************************************************************************************************************
    '' エラー系のログ書き込み用関数（１ヶ月サイクルでの上書き更新）file名は　Err02.txt　等になります。
    '' cErrpath : LOGの直上のフォルダー名まで入力　
    ''******************************************************************************************************************************
    'Public Sub CrystalErrLog(ByVal Pr_Name As String, ByVal sMsg As String)
    '    '通常エラー用ログ
    '    Dim sPass As String
    '    Dim iFileNo As Integer

    '    iFileNo = FreeFile()

    '    sPass = cErrPath & "Err" & Format(Now, "dd") & ".txt"
    '    If Dir(sPass, FileAttribute.Normal) = "" Then
    '        FileOpen(iFileNo, sPass, OpenMode.Output, OpenAccess.Write)
    '        WriteLine(iFileNo, Format(Now, "yyyy/MM/dd HH:mm:ss") & " " & "エラー発生！ [" & Pr_Name & "]" & vbCrLf & sMsg)
    '        FileClose(iFileNo)
    '    Else
    '        FileOpen(iFileNo, sPass, OpenMode.Append, OpenAccess.Write)
    '        WriteLine(iFileNo, Format(Now, "yyyy/MM/dd HH:mm:ss") & " " & "エラー発生！ [" & Pr_Name & "]" & vbCrLf & sMsg)
    '        FileClose(iFileNo)
    '    End If
    'End Sub


    '******************************************************************************************************************************
    ' Sleep関数
    ' t : プログラムをとめる秒数ミリセコンド
    ' Doeventsを使っているので完全に止まっているわけではありません。止まっている間は常に制御をWINDOWSに返しています。
    '******************************************************************************************************************************
    Public Sub Sleep(ByVal t As Short)
        'Sleep関数です
        Dim n As Date
        Try
            n = Now
            System.Threading.Thread.Sleep(t)

        Catch ex As Exception
            Call vbErrSub("Sleep", Err.Number, ex, False, 0)
            FileClose(1)
        End Try

    End Sub

    '******************************************************************************************************************************
    ' ログの初期化関数（下記のログ書込みの関数を使ったらシステム起動時この関数を呼び出して初期化を行う）
    ' これを使わないとLOGファイルがものすごい量になります。
    '******************************************************************************************************************************
    Public Sub Log_Boot()
        Dim FILE As System.IO.File
        Dim Path As System.IO.Path
        Dim sFilePass As String
        Try

            'フォルダチェック(無ければ作成)
            If Dir(cLogPath, FileAttribute.Directory) = "" Then
                'ログパス
                System.IO.Directory.CreateDirectory(cLogPath)
            End If

            If Dir(cErrPath, FileAttribute.Directory) = "" Then
                'エラーログパス
                System.IO.Directory.CreateDirectory(cErrPath)
            End If

            '通信ログの初期化
            While (Dir(cLogPath & "*" & Format(DateAdd(DateInterval.Day, 1, Now), "dd") & ".txt", FileAttribute.Normal) <> "")
                sFilePass = Dir(cLogPath & "*" & Format(DateAdd(DateInterval.Day, 1, Now), "dd") & ".txt", FileAttribute.Normal)
                FILE.Delete(cLogPath & sFilePass)
            End While
            'エラーログの初期化
            While (Dir(cErrPath & "*" & Format(DateAdd(DateInterval.Day, 1, Now), "dd") & ".txt", FileAttribute.Normal) <> "")
                sFilePass = Dir(cErrPath & "*" & Format(DateAdd(DateInterval.Day, 1, Now), "dd") & ".txt", FileAttribute.Normal)
                FILE.Delete(cErrPath & sFilePass)
            End While
        Catch ex As Exception
            Call vbErrSub("Log_Boot", Err.Number, ex, False, 0)
        End Try
    End Sub


    '******************************************************************************************************************************
    ' 制御系のログ書き込み用関数（１ヶ月サイクルでの上書き更新）file名は　KANSI02.txt　等になります。
    ' cLogPath : LOGの直上のフォルダー名まで入力　
    ' sNAME    : 制御プログラム名
    ' sCOMENT  : 動作、及び処理名を入れる（入庫、ﾄﾗｯｷﾝｸﾞファイル更新など）
    ' sLog     : 具体的な処理内容を入れる　
    '******************************************************************************************************************************
    Public Sub LOGWRITE(ByVal sNAME As String, ByVal sCOMENT As String, ByVal sLog As String)
        Dim iFileNo As Integer = Nothing

        Try
            iFileNo = FreeFile()

            If sNAME = cSqlLogName Then
                sNAME &= "_" & Format(Now, "yyMMddHHmm") & "_"
            End If

            '制御系のログ
            If Dir(cLogPath & sNAME & Format(Now, "dd") & ".txt", FileAttribute.Normal) = "" Then
                'FileOpen(1, cLogPath & sNAME & Format(Now, "dd") & ".txt", OpenMode.Output, OpenAccess.Write)
                'WriteLine(1, Format(Now, "yyyy/MM/dd HH:mm:ss") & "  " & sCOMENT & " : " & sLog)
                'FileClose(1)
                FileOpen(iFileNo, cLogPath & sNAME & Format(Now, "dd") & ".txt", OpenMode.Output, OpenAccess.Write)
                WriteLine(iFileNo, Format(Now, "yyyy/MM/dd HH:mm:ss") & "  " & sCOMENT & " : " & sLog)
                FileClose(iFileNo)
            Else
                'FileOpen(1, cLogPath & sNAME & Format(Now, "dd") & ".txt", OpenMode.Append, OpenAccess.Write)
                'WriteLine(1, Format(Now, "yyyy/MM/dd HH:mm:ss") & "  " & sCOMENT & " : " & sLog)
                'FileClose(1)
                FileOpen(iFileNo, cLogPath & sNAME & Format(Now, "dd") & ".txt", OpenMode.Append, OpenAccess.Write)
                WriteLine(iFileNo, Format(Now, "yyyy/MM/dd HH:mm:ss") & "  " & sCOMENT & " : " & sLog)
                FileClose(iFileNo)
            End If

        Catch ex As Exception
            Call vbErrSub("LOGWRITE", Err.Number, ex, False, 1)

            If IsNothing(iFileNo) = False Then
                FileClose(iFileNo)
            End If

        End Try

    End Sub


    '******************************************************************************************************************************
    ' エラー系のログ書き込み用関数（１ヶ月サイクルでの上書き更新）file名は　Err02.txt　等になります。
    ' cErrpath : LOGの直上のフォルダー名まで入力　
    '******************************************************************************************************************************
    Public Sub NetErrLog(ByVal Pr_Name As String, ByVal shErrNo As Short)
        '通常エラー用ログ
        Dim sPass As String
        sPass = cErrPath & "Err" & Format(Now, "dd") & ".txt"
        If Dir(sPass, FileAttribute.Normal) = "" Then
            FileOpen(1, sPass, OpenMode.Output, OpenAccess.Write)
            WriteLine(1, Format(Now, "yyyy/MM/dd HH:mm:ss") & " " & "エラー発生！ [" & Pr_Name & "]" & vbCrLf & vbCrLf & "                     " & "Error Code = [ " & Format(shErrNo, "0") & " ]" & vbCrLf & "                     " & "Error 内容 = [ " & ErrorToString(shErrNo) & " ]")
            FileClose(1)
        Else
            FileOpen(1, sPass, OpenMode.Append, OpenAccess.Write)
            WriteLine(1, Format(Now, "yyyy/MM/dd HH:mm:ss") & " " & "エラー発生！ [" & Pr_Name & "]" & vbCrLf & vbCrLf & "                     " & "Error Code = [ " & Format(shErrNo, "0") & " ]" & vbCrLf & "                     " & "Error 内容 = [ " & ErrorToString(shErrNo) & " ]")
            FileClose(1)
        End If
    End Sub

    '******************************************************************************************************************************
    ' 全半角チェック最大Byte数を当てはめて、最大Byte数をオバーすると後ろから切り捨てて返値で返す 
    ' イベントはLostFocus時
    ' sTEXT    : チェックしたい文字列
    ' shMAXLEN : 入力最大文字数(MaxLength)
    '******************************************************************************************************************************
    Public Function 全半角チェック(ByVal sTEXT As String, ByVal shMAXLEN As Short) As String
        Dim shByte As Short
        Dim iLoop As Short
        Dim iLen As Short
        Dim sWK As String

        Try
            shByte = 0
            iLen = Len(sTEXT)
            For iLoop = 1 To iLen Step 1
                shByte = shByte + System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(Mid(sTEXT, iLoop, 1))
                sWK = sWK & Mid$(sTEXT, iLoop, 1)
                If shByte > shMAXLEN - 1 Then
                    If shByte > shMAXLEN Then
                        sWK = Mid$(sWK, 1, Len(sWK) - 1)
                        Exit For
                    End If
                End If
            Next
            全半角チェック = sWK
        Catch ex As Exception
            Call vbErrSub("全半角チェック", Err.Number, ex, False, 0)
        End Try
    End Function

    '******************************************************************************************************************************
    ' 全半角チェック最大Byte数を当てはめて、最大Byte数をオーバーすると後ろから切り捨てて返値で返す 
    ' イベントはLostFocus時
    ' sTEXT    : チェックしたい文字列
    ' shLength : 入力最大文字数(MaxLength)
    '******************************************************************************************************************************
    Public Function BYTE数チェック(ByVal sTEXT As String) As Integer
        Dim shByte As Integer
        Dim iLoop As Integer
        Dim iLen As Integer
        Dim sWK As String

        Try
            shByte = 0
            ''iLen = Len(sTEXT)
            ''For iLoop = 1 To iLen Step 1
            ''    shByte = shByte + System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(Mid(sTEXT, iLoop, 1))
            ''Next
            shByte = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(sTEXT)

        Catch ex As Exception
            Call vbErrSub("[" & GetCurrentMethod.Name & "]", Err.Number, ex, , cShowMsg)
            shByte = 0
        Finally
            BYTE数チェック = shByte
        End Try
    End Function

    '******************************************************************************************************************************
    ' MidB
    ' 開始文字列が最大文字数分抜き出す
    ' sTEXT    : チェックしたい文字列
    ' iMAXLEN : 入力最大文字数(MaxLength)
    ' iStartLen:入力開始文字数
    '******************************************************************************************************************************
    Public Function MidB(ByVal sTEXT As String, Optional ByVal iStartLen As Integer = 1, Optional ByVal iMAXLEN As Integer = 99999) As String
        Dim iByte As Integer = 0
        Dim iLoop As Integer = 0
        Dim iLen As Integer = 0
        Dim sWK As String = ""

        Dim iTotalByte As Integer

        Try
            iByte = 0
            iTotalByte = 0
            iLen = Len(sTEXT)

            For iLoop = 1 To iLen Step 1
                iTotalByte = iTotalByte + System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(Mid(sTEXT, iLoop, 1))

                If iTotalByte >= iStartLen Then
                    iByte = iByte + System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(Mid(sTEXT, iLoop, 1))
                    sWK = sWK & Mid$(sTEXT, iLoop, 1)
                    If iByte > iMAXLEN - 1 Then
                        If iByte > iMAXLEN Then
                            sWK = Mid$(sWK, 1, Len(sWK) - 1)
                            Exit For
                        End If
                    End If
                End If

            Next
            MidB = sWK
        Catch ex As Exception
            Call vbErrSub("[" & GetCurrentMethod.Name & "]", Err.Number, ex, , cShowMsg)
        End Try
    End Function

    '===================================================
    ' 16進数を2進数に変換(sVal: 変換する16進数[string]) 
    '===================================================
    Public Function Hex2Dec(ByVal sVal As String) As String
        Try
            Select Case sVal
                Case "0" : Hex2Dec = "0000"
                Case "1" : Hex2Dec = "0001"
                Case "2" : Hex2Dec = "0010"
                Case "3" : Hex2Dec = "0011"
                Case "4" : Hex2Dec = "0100"
                Case "5" : Hex2Dec = "0101"
                Case "6" : Hex2Dec = "0110"
                Case "7" : Hex2Dec = "0111"
                Case "8" : Hex2Dec = "1000"
                Case "9" : Hex2Dec = "1001"
                Case "A" : Hex2Dec = "1010"
                Case "B" : Hex2Dec = "1011"
                Case "C" : Hex2Dec = "1100"
                Case "D" : Hex2Dec = "1101"
                Case "E" : Hex2Dec = "1110"
                Case "F" : Hex2Dec = "1111"
                Case Else : Hex2Dec = ""
            End Select

        Catch ex As Exception
            Call vbErrSub("SimulatorModule" & "-<Hex2Dec>", Err.Number, ex, False)
        End Try
    End Function

    '==================================================
    ' 2進数を16進数に変換(sVal: 変換する2進数[string]) 
    '==================================================
    Public Function Dec2Hex(ByVal sVal As String) As String
        Try
            Select Case sVal
                Case "0000" : Dec2Hex = "0"
                Case "0001" : Dec2Hex = "1"
                Case "0010" : Dec2Hex = "2"
                Case "0011" : Dec2Hex = "3"
                Case "0100" : Dec2Hex = "4"
                Case "0101" : Dec2Hex = "5"
                Case "0110" : Dec2Hex = "6"
                Case "0111" : Dec2Hex = "7"
                Case "1000" : Dec2Hex = "8"
                Case "1001" : Dec2Hex = "9"
                Case "1010" : Dec2Hex = "A"
                Case "1011" : Dec2Hex = "B"
                Case "1100" : Dec2Hex = "C"
                Case "1101" : Dec2Hex = "D"
                Case "1110" : Dec2Hex = "E"
                Case "1111" : Dec2Hex = "F"
                Case Else : Dec2Hex = ""
            End Select

        Catch ex As Exception
            Call vbErrSub("SimulatorModule" & "-<Dec2Hex>", Err.Number, ex, False)
        End Try
    End Function
#End Region

End Module
