'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
'_/変更履歴
'_/<A205>拠点を定数可,090728,[apt]sby
'_/<A209>タイトルテキストを拠点毎に分ける,090920,[apt]k.msr
'_/<A221>ラベル出力プリンタを追加,09/09/22,[apt]k.msr
'_/<A224>工場コードを拠点別に初期値を表示,09/09/23,[apt]k.msr
'_/<A255>棚状況モニタ詳細で選択拠点以外の在庫が表示されるため修正,09/10/14,[apt]k.msr
'_/<A268>メンテンナンスと設定系画面で倉庫コードを手入力時に自拠点以外の棟を表示しないようにする。,09/10/21,[apt]k.msr
'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

'共通関数
Imports WMS.clsCommon.Library
Imports System.Text
Imports System.Reflection.MethodInfo

Module CommonModule

#Region "修正内容"

    '**********************************************************************************************
    '
    '共通関数修正箇所内容
    '
    '<A> 2007/05/17  MINESHIMA
    '    Add_ArrayMune　棟テーブルデータ取得関数のSELECT文にORDER句を追加
    '
    '
    '
    '
    '
    '
    '**********************************************************************************************

#End Region

#Region "メッセージボックス定数"
    'ﾒｯｾｰｼﾞﾎﾞｯｸｽｽﾀｲﾙ_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

    '問合せ+YESNO
    Public msgQYN As MsgBoxStyle = MsgBoxStyle.Question + MsgBoxStyle.YesNo
    '注意+OK
    Public msgEO As MsgBoxStyle = MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly
    '情報+OK
    Public msgIO As MsgBoxStyle = MsgBoxStyle.Information + MsgBoxStyle.OKOnly
    'タイトル
    Public msgTitle As String = "在庫管理システム"

    'メッセージ内容
    Public Const cMsgErr As String = "エラー発生"

#End Region

    '071003@@追加
#Region "セル選択用定数"

    Public Const cSelectCell As String = "SelectCell"

#End Region

#Region "各種イベント共通処理"

    Public Sub Textbox_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Try
            Select Case Asc(e.KeyChar)
                Case Asc("0") To Asc("9")
                Case Asc("A") To Asc("Z")
                Case Keys.Back
                Case Keys.Tab
                    'Case Keys.IMEModeChange = False
                Case Else
                    e.Handled = True
            End Select

        Catch ex As Exception
            vbErrSub("[Textbox_Keypress]", Err.Number, ex)
        End Try
    End Sub

    'テキストボックスフォーカス取得@@090923[apt]k.msr
    Public Sub Textbox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txtTarget As TextBox
        Try
            txtTarget = sender

            txtTarget.SelectionStart = 0
            txtTarget.SelectionLength = txtTarget.MaxLength

        Catch ex As Exception
            vbErrSub("[Textbox_GotFocus]", Err.Number, ex)
        End Try

    End Sub
   
    'スプレッドキープレス
  
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/



    'チェックボックス 選択イベント
    Public Sub Checkbox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try


            '選択時色変更
            If sender.Checked = True Then
                sender.BackColor = Color.MediumAquamarine
            Else
                sender.BackColor = SystemColors.Control
            End If
        Catch ex As Exception
            vbErrSub("[Checkbox_CheckedChanged]", Err.Number, ex)
        End Try
    End Sub

    'チェックボックス 選択イベント
    Public Sub RadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            '選択時色変更
            If sender.Checked = True Then
                sender.BackColor = Color.MediumAquamarine
            Else
                sender.BackColor = SystemColors.Control
            End If
        Catch ex As Exception
            vbErrSub("[RadioButton_CheckedChanged]", Err.Number, ex)
        End Try
    End Sub

#End Region

    '**********************************************************************************************
    '*                                                                                            *
    '*  PROPERTY                                                                                  *
    '*                                                                                            *
    '**********************************************************************************************



#Region "共通変数"

    '各画面名保存用変数_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

  

    '入庫系
    Public strNyukaForm() As String = {"", "入荷受付(計画)", "入荷受付(計画外)", "入庫ラベル再発行", "容器紐付け設定", "入庫完了設定", "積増入庫設定", "空容器入庫設定", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnNyukaEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}

    '出庫系
    Public strSyukkaForm() As String = {"", "出荷開始設定", "ピッキング作業", "計画外出荷設定　　　　　　(商品コード指定)", "計画外出荷設定　　　　　　(問合せ出荷)", "在庫予約設定", "出荷止め設定", "出荷戻し作業", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnSyukkoEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}
    '検品
    Public strKenpinForm() As String = {"", "通販エリア検品作業", "卸エリア検品作業", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnKenpinEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}
    '補充
    Public strHojyuForm() As String = {"", "通常補充起動/停止設定", "補充完了設定", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnHojyuEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}
    '移動
    Public strIdouForm() As String = {"", "自動倉庫移動出庫設定", "移動完了設定", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnIdouEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}

    '問合せ
    Public strToiForm() As String = {"", "在庫問合せ", "格納状況問合せ", "発注ロット数問合せ", "出荷指示No問合せ", "入荷・入庫進捗問合せ", "出荷進捗", "補充進捗", "移動進捗", "出荷期限問合せ", "長期滞留品在庫問合せ", "DPS棚割状況一覧", "出荷追跡問合せ", "入出荷実績問合せ", "送り状No問合せ", "", "", "", "", "", "", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnToiEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}

    'メンテナンス
    Public strMenteForm() As String = {"", "在庫ﾒﾝﾃﾅﾝｽ", "荷主区分ﾒﾝﾃﾅﾝｽ", "品質管理区分ﾒﾝﾃﾅﾝｽ", "搬送ﾃﾞｰﾀﾒﾝﾃﾅﾝｽ", "入荷予定ﾃﾞｰﾀﾒﾝﾃﾅﾝｽ", "出荷予定ﾃﾞｰﾀﾒﾝﾃﾅﾝｽ", "商品ﾏｽﾀﾒﾝﾃﾅﾝｽ", "作業者ﾏｽﾀﾒﾝﾃﾅﾝｽ", "ホスト送受信ﾒﾝﾃﾅﾝｽ", "棚割付ﾒﾝﾃﾅﾝｽ", "事由ﾏｽﾀﾒﾝﾃﾅﾝｽ", "事由ﾃﾞﾌｫﾙﾄﾒﾝﾃﾅﾝｽ", "画面ｱｸｾｽﾒﾝﾃﾅﾝｽ", "端末ﾒﾝﾃﾅﾝｽ", "ｴﾘｱﾏｽﾀﾒﾝﾃﾅﾝｽ", "出荷種別ﾏｽﾀﾒﾝﾃﾅﾝｽ", "得意先ﾏｽﾀﾒﾝﾃﾅﾝｽ", "運送会社ﾏｽﾀﾒﾝﾃﾅﾝｽ", "格納倉庫ﾏｽﾀﾒﾝﾃﾅﾝｽ", "単位ﾏｽﾀﾒﾝﾃﾅﾝｽ", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnMenteEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}

    'システム
    Public strSysForm() As String = {"", "稼働状態モニター", "日次更新処理", "システム定義設定", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnSysEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}
    '自動倉庫
    Public strSokoForm() As String = {"", "作業表示", "入出庫モード変更設定", "自動倉庫投入設定", "自動倉庫起動設定", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnSokoEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}
    '棚卸
    Public strTanaOrosiForm() As String = {"", "棚卸開始/終了設定", "棚卸結果入力", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnTanaOrosiEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}
    '分析
    Public strAnalyzeForm() As String = {"", "商品分析", "作業者詳細分析", "作業分析", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnAnalyzeEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}
    'DPM
    Public strDpmForm() As String = {"", "DPS作業者登録", "表示器テスト", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    '<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public blnDpmEnable() As Boolean = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}


    ''画面No
    'Public sNo() As String

    ''画面名
    'Public sNm() As String

    '画面名表示有無'<A209>設定ファイルに画面使用有無追加@@090830[apt]k.msr
    Public bFrmEnable() As Boolean


    '**************************************
    '構造体は使わない　コメント kawagoe6/11

    ''構造体(棟コード)
    'Public SetMune() As CmbMune

    ''構造体(ゾーン)
    'Public SetZone() As CmbZone

    ''構造体(棟グループ)
    'Public SetGroup() As CmbGroup
    '**************************************

    ''棟グループ
    'Public sCmbGroup() As String

    ''倉庫コード
    'Public sCmbSouko() As String

    ''棟コード
    'Public sCmbMune() As String

    ''ゾーン
    'Public sCmbZone() As String

    'ラベルに渡す画面名
    Public strGetTitle As String



    'INIファイル保存場所
    Public cSysINI As String = ".\SYSTEM.ini"

    'INIファイルデータ取得用
    Public IniCls As New CIniFile

  
  
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

#End Region



#Region "ＣＳＶ出力"

    '//////////////////////////////////////////////////////////
    '関　数:OutputCSV
    '処　理:SPREADのデータをCSVに出力
    '引　数:SPR         → SPREAD名(大概sprData)
    '　　　 sFormName   → 保存する時のファイル名
    '戻り値:0   成功
    '       1   失敗
    '       2   キャンセル
    '作成日:2007/03/09
    '作成者:YAMANE
    '//////////////////////////////////////////////////////////
    'Public Function OutputCSV(ByVal SPR As FarPoint.Win.Spread.FpSpread, ByVal sFormName As String) As Short
    '    Dim sPath As String

    '    Try
    '        OutputCSV = 1

    '        'SaveFileDialogクラスのインスタンスを作成
    '        Dim sfd As New SaveFileDialog

    '        With sfd
    '            .FileName = sFormName & "_" & Format(Now, "yyMMdd") & ".csv"    'ファイル名の指定(画面名＋YYMMDD.csv)
    '            .InitialDirectory = "D:\"                                       '保存場所の指定
    '            .Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*"  '表示選択肢の指定
    '            .FilterIndex = 1                                                '初期選択肢は[CSV]
    '            .Title = "名前を付けて保存"                                     'タイトルの設定
    '            .RestoreDirectory = True                                        'ディレクトリの復元
    '            .OverwritePrompt = True                                         '同名のファイルが存在する場合は警告(デフォルトでTrue)
    '            .CheckPathExists = True                                         '存在しないパスが指定された場合は警告(デフォルトでTrue)

    '            'ダイアログ表示
    '            If .ShowDialog() = DialogResult.OK Then
    '                sPath = .FileName                                           'OKなら選択されたファイル名を表示
    '                If Mid$(sPath, sPath.Length - 3) <> ".csv" Then             '.csv形式でなければ拡張子を追加
    '                    sPath &= ".csv"
    '                End If
    '            Else
    '                OutputCSV = 2
    '                Exit Try
    '            End If
    '        End With

    '        Dim ms As New System.IO.MemoryStream

    '        'SPREADのデータをカンマ区切りの書式でメモリ上に保存
    '        SPR.Sheets(0).SaveTextFile(ms, False, FarPoint.Win.Spread.Model.IncludeHeaders.ColumnHeadersCustomOnly, ControlChars.NewLine, ",", Chr(34))
    '        ms.Seek(0, IO.SeekOrigin.Begin)

    '        'データをUTF-8で読込
    '        Dim sr As New System.IO.StreamReader(ms, System.Text.Encoding.GetEncoding(932))

    '        Try '出力先のファイルを作成
    '            Dim fs As New System.IO.FileStream(sPath, IO.FileMode.Create)

    '            'Shift_JISにエンコード
    '            Dim sw As New System.IO.StreamWriter(fs, System.Text.Encoding.GetEncoding(932))

    '            sw.Write(sr.ReadToEnd.Replace(" ", ""), Chr(13) + Chr(10))
    '            sr.Close()
    '            ms.Close()
    '            sw.Flush()
    '            sw.Close()
    '            fs.Close()

    '        Catch ex As Exception
    '            MsgBox(GetMsg("A342"), msgEO, msgTitle)
    '            OutputCSV = 2
    '            Exit Function
    '        End Try

    '        OutputCSV = 0

    '    Catch ex As Exception
    '        vbErrSub(OutputCSV & "<OutputCSV>", Err.Number, ex, False, 0)
    '    End Try

    '    Return OutputCSV

    'End Function

#End Region

#Region "画面名検索"

    '//////////////////////////////////////////////////////////
    '関　数:SearchName
    '処　理:IDから名前を検索
    '引　数:iNo     → 画面No
    '　　　:shID    → 画面ID
    '作成日:2007/03/09
    '作成者:YAMANE
    '//////////////////////////////////////////////////////////
    Public Function SearchName(ByVal iNo As Integer, ByVal shID As Integer) As String
        Dim sTitleDta As String = Nothing

        Dim strNm As String = ""             '戻り値（画面名）
     

        Try

            Select Case shID
                Case 1 '入荷
                    strNm = strNyukaForm(iNo)
                Case 2 '出荷
                    strNm = strSyukkaForm(iNo)

                Case 3 '検品
                    strNm = strKenpinForm(iNo)

                Case 4  '補充
                    strNm = strHojyuForm(iNo)
              
                Case 5  '移動
                    strNm = strIdouForm(iNo)
                Case 6  '問合せ
                    strNm = strToiForm(iNo)
                Case 7  'メンテナンス
                    strNm = strMenteForm(iNo)
                Case 8  'システム
                    strNm = strSysForm(iNo)
                Case 9  '自動倉庫
                    strNm = strSokoForm(iNo)
                Case 10  '棚卸
                    strNm = strTanaOrosiForm(iNo)
                Case 11  'DPM
                    strNm = strDpmForm(iNo)
                Case Else
            End Select

            

        Catch ex As Exception
            Call vbErrSub("CommonModule" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
        Finally
            SearchName = strNm
        End Try



    End Function

#End Region

#Region "構造体"

    'Public Structure CmbGroup
    '    Public sMune As String
    '    Public sGroup As String
    'End Structure

    'Public Structure CmbMune
    '    Public sSoukoCd As String
    '    Public sMune As String
    '    Public sGroup As String
    'End Structure

    'Public Structure CmbZone
    '    Public sSoukoCd As String
    '    Public sMune As String
    '    Public sZone As String
    'End Structure

    Public Structure strN18_1
        Public sSoukoCd As String
        Public sRidgeCd As String
        Public sZone As String
        Public sLocation As String
        Public sSheetNo As String
        Public sHanbaiCd As String
        Public sHinban As String
        Public sZaikoNum As Integer
        Public sVolume As String
        '2007/07/13  ｵｰﾀﾞｰNoを追加
        Public sORDER_No As String
    End Structure

    '071024@@追加｢n-apt｣k.msr
    Public Structure strS24_1
        Public sSoukoCd As String
        Public sRidgeCd As String
        Public sZone As String
        Public sRetsu As String
        Public sRen As String
        Public sDan As String
        Public sLocation As String
        Public sSheetNo As String
        Public sHanbaiCd As String
        Public sHinban As String
        Public sZaikoNum As Integer
        Public sVolume As String
        Public sORDER_NO As String
        Public sPalletNo As String
    End Structure

    '<A368>出庫グループコンボ用@@120413[apt]k.msr
    Public Structure strSyukkoGrp
        Public sSyukkoGrpNo As String
        Public sSyukkoGrpName As String
    End Structure

#End Region



#Region "コンボボックス値設定"

    ''//////////////////////////////////////////////////////////
    ''関　数:Add_ArrayGroup
    ''処　理:配列に棟データを格納
    ''戻り値:Add_CmbGroup → 棟グループデータ
    ''作成日:2007/03/15
    ''作成者:YAMANE

    ''このSQL取得データが重複するから使わないように kawagoe6/10
    ''//////////////////////////////////////////////////////////
    'Public Function Add_ArrayGroup()
    '    Dim sSQL As String
    '    Dim OraDR As Oracle.DataAccess.Client.OracleDataReader

    '    Dim iLoop As Integer = 0

    '    Try
    '        sSQL = ""
    '        sSQL = sSQL & "SELECT DISTINCT " & vbCrLf
    '        sSQL = sSQL & "    RIDGE_GROUP, " & vbCrLf
    '        sSQL = sSQL & "    RIDGE_CODE " & vbCrLf
    '        sSQL = sSQL & "FROM " & vbCrLf
    '        sSQL = sSQL & "    M_RIDGE " & vbCrLf
    '        sSQL = sSQL & "GROUP BY " & vbCrLf
    '        sSQL = sSQL & "    RIDGE_CODE, " & vbCrLf
    '        sSQL = sSQL & "    RIDGE_GROUP " & vbCrLf
    '        sSQL = sSQL & "ORDER BY " & vbCrLf
    '        sSQL = sSQL & "    RIDGE_GROUP, RIDGE_CODE " & vbCrLf
    '        OraDR = OraDB.Read(sSQL)

    '        While OraDR.Read()
    '            ReDim Preserve SetGroup(iLoop)
    '            SetGroup(iLoop).sGroup = OraDR.GetValue(0)
    '            SetGroup(iLoop).sMune = OraDR.GetValue(1)
    '            iLoop += 1
    '        End While

    '    Catch oraErr As Oracle.DataAccess.Client.OracleException
    '        OraErrSub("" & "<Add_ArrayGroup>", oraErr.Number, oraErr.Message, oraErr, sSQL)
    '    Catch ex As Exception
    '        vbErrSub("" & "<Add_ArrayGroup>", Err.Number, ex, False, 0)
    '    End Try

    '    Return SetGroup

    'End Function


    ''//////////////////////////////////////////////////////////
    ''関　数:Add_ArrayMune
    ''処　理:配列に棟データを格納
    ''戻り値:Add_CmbMune → 棟データ
    ''作成日:2007/03/15
    ''作成者:YAMANE

    ''このSQL取得データが重複するから使わないように kawagoe6/10
    ''//////////////////////////////////////////////////////////
    'Public Function Add_ArrayMune()
    '    Dim sSQL As String
    '    Dim OraDR As Oracle.DataAccess.Client.OracleDataReader

    '    Dim iLoop As Integer = 0

    '    Try
    '        sSQL = ""
    '        sSQL = sSQL & "SELECT " & vbLf
    '        sSQL = sSQL & "     RIDGE_CODE, " & vbLf
    '        sSQL = sSQL & "     SOUKO_CODE, " & vbLf
    '        sSQL = sSQL & "     RIDGE_GROUP " & vbLf
    '        sSQL = sSQL & "FROM " & vbLf
    '        sSQL = sSQL & "     M_RIDGE " & vbLf

    '        '<A>ORDER句を追加　倉庫コード・棟を昇順に表示する。
    '        sSQL &= "ORDER BY SOUKO_CODE,RIDGE_CODE"

    '        OraDR = OraDB.Read(sSQL)

    '        While OraDR.Read()
    '            ReDim Preserve SetMune(iLoop)
    '            SetMune(iLoop).sMune = OraDR.GetValue(0)
    '            SetMune(iLoop).sSoukoCd = OraDR.GetValue(1)
    '            SetMune(iLoop).sGroup = OraDR.GetValue(2)
    '            iLoop += 1
    '        End While

    '    Catch oraErr As Oracle.DataAccess.Client.OracleException
    '        OraErrSub("" & "<Add_ArrayMune>", oraErr.Number, oraErr.Message, oraErr, sSQL)
    '    Catch ex As Exception
    '        vbErrSub("" & "<Add_ArrayMune>", Err.Number, ex, False, 0)
    '    End Try

    '    Return SetMune

    'End Function



    ''//////////////////////////////////////////////////////////
    ''関　数:Add_ArrayZone
    ''処　理:配列にゾーンデータを格納
    ''戻り値:Add_CmbZone → ゾーンデータ
    ''作成日:2007/03/15
    ''作成者:YAMANE

    ''このSQL取得データが重複するから使わないように kawagoe6/10
    ''//////////////////////////////////////////////////////////
    'Public Function Add_ArrayZone()
    '    Dim sSQL As String
    '    Dim OraDR As Oracle.DataAccess.Client.OracleDataReader

    '    Dim iLoop As Integer = 0

    '    Try
    '        sSQL = ""
    '        sSQL = sSQL & "SELECT " & vbLf
    '        sSQL = sSQL & "     SOUKO_CODE, " & vbLf
    '        sSQL = sSQL & "     RIDGE_CODE, " & vbLf
    '        sSQL = sSQL & "     ZONE_SYUBETSU, " & vbLf
    '        sSQL = sSQL & "     TANA_CODE " & vbLf
    '        sSQL = sSQL & "FROM " & vbLf
    '        sSQL = sSQL & "     M_ZONE " & vbLf
    '        sSQL = sSQL & "ORDER BY " & vbLf
    '        sSQL = sSQL & "     ZONE_SYUBETSU, TANA_CODE " & vbLf
    '        OraDR = OraDB.Read(sSQL)

    '        While OraDR.Read()
    '            ReDim Preserve SetZone(iLoop)
    '            SetZone(iLoop).sSoukoCd = OraDR.GetValue(0)
    '            SetZone(iLoop).sMune = OraDR.GetValue(1)
    '            SetZone(iLoop).sZone = OraDR.GetValue(2) & OraDR.GetValue(3)
    '            iLoop += 1
    '        End While
    '        OraDR.Close()

    '    Catch oraErr As Oracle.DataAccess.Client.OracleException
    '        OraErrSub("" & "<Add_ArrayZone>", oraErr.Number, oraErr.Message, oraErr, sSQL)
    '    Catch ex As Exception
    '        vbErrSub("" & "<Add_ArrayZone>", Err.Number, ex, False, 0)
    '    End Try

    '    Return SetZone

    'End Function


    '//////////////////////////////////////////////////////////
    '関　数:Set_CmbMune
    '処　理:選択された倉庫コードに該当する棟コードを表示
    '引　数:sSoukoCd:選択された倉庫コード
    '       CmbName:選択したコンボボックスの名称
    '       sMyBase:表示拠点コード'<A268>追加@@091021[apt]k.msr
    '作成日:2007/03/15
    '作成者:YAMANE
    '備　考:'<A268>表示拠点を追加@@091021[apt]k.msr
    '//////////////////////////////////////////////////////////
    Public Function Set_CmbMune(ByVal sSoukoCd As String, ByRef CmbName As ComboBox, ByVal sMyBase As String)
        'Dim iLoop As Integer = 0
        Dim sSQL As String
        Dim OraDR As Oracle.DataAccess.Client.OracleDataReader

        Try
            CmbName.Items.Clear()
            CmbName.Items.Add(" ")


            If Len(sSoukoCd) = 0 Then Exit Function
            '追加 kawagoe6/10
            sSQL = ""
            sSQL &= vbLf & " Select DISTINCT"
            sSQL &= vbLf & "      R.RIDGE_CODE"
            sSQL &= vbLf & " FROM M_RIDGE R "
            sSQL &= vbLf & "     ,M_SOUKO S "
            'sSQL &= vbLf & "     ,M_ZONE  Z "
            sSQL &= vbLf & " WHERE  S.SOUKO_CODE = R.SOUKO_CODE"
            'sSQL &= vbLf & " AND R.SOUKO_CODE = Z.SOUKO_CODE"
            'sSQL &= vbLf & " AND R.RIDGE_CODE = Z.RIDGE_CODE "

            '<A268>表示拠点が指定されていたら条件追加
            If sMyBase <> "" Then
                sSQL &= vbLf & " AND S.BASE_CODE ='" & sMyBase & "'"
            End If

            sSQL &= vbLf & " AND R.SOUKO_CODE = '" & SQLStr(sSoukoCd) & "'"
            sSQL &= vbLf & "ORDER BY R.RIDGE_CODE " & vbLf
            OraDR = OraDB.Read(sSQL)
            While OraDR.Read()
                CmbName.Items.Add(OraDR("RIDGE_CODE").ToString)
            End While
            OraDR.Close()

            'For iLoop = 0 To UBound(SetMune)
            '    If SetMune(iLoop).sSoukoCd = sSoukoCd Then
            '        CmbName.Items.Add(SetMune(iLoop).sMune)
            '    End If
            'Next
        Catch oraErr As Oracle.DataAccess.Client.OracleException
            OraDR.Close()
            Call OraErrSub("CommonModule" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSQL)
        Catch ex As Exception
            Call vbErrSub("CommonModule" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
        End Try
    End Function

    '//////////////////////////////////////////////////////////
    '関　数:Set_CmbGroup
    '処　理:選択された棟グループに該当する棟コードを表示
    '引　数:sSoukoCd:選択された倉庫コード
    '       CmbName:選択したコンボボックスの名称
    '作成日:2007/03/23
    '作成者:YAMANE
    '//////////////////////////////////////////////////////////
    'Public Function Set_CmbGroup(ByVal sGroupCd As String, ByRef CmbName As ComboBox)
    Public Function Set_CmbGroup(ByVal sBaseCode As String, ByVal sGroupCd As String, ByRef CmbName As ComboBox)
        'Dim iLoop As Integer = 0
        Dim sSQL As String
        Dim OraDR As Oracle.DataAccess.Client.OracleDataReader

        Try
            CmbName.Items.Clear()
            CmbName.Items.Add(" ")

            If Len(sGroupCd) = 0 Then Exit Function
            '追加 kawagoe6/10
            sSQL = ""
            sSQL &= vbLf & " Select DISTINCT"
            sSQL &= vbLf & "      RIDGE_CODE"
            sSQL &= vbLf & " FROM M_RIDGE  "
            sSQL &= vbLf & " WHERE  RIDGE_GROUP = '" & SQLStr(sGroupCd) & "'"
            sSQL &= vbLf & " AND SOUKO_CODE IN ( SELECT SOUKO_CODE FROM M_SOUKO WHERE BASE_CODE = '" & sBaseCode & "') " '<A355>拠点の判断を追加@@110622[apt]k.msr
            sSQL &= vbLf & "ORDER BY RIDGE_CODE " & vbLf
            OraDR = OraDB.Read(sSQL)
            While OraDR.Read()
                CmbName.Items.Add(OraDR("RIDGE_CODE").ToString)
            End While
            OraDR.Close()


            'For iLoop = 0 To UBound(SetGroup)
            '    If SetGroup(iLoop).sGroup = sGroupCd Then
            '        CmbName.Items.Add(SetGroup(iLoop).sMune)
            '    End If
            'Next
        Catch oraErr As Oracle.DataAccess.Client.OracleException
            OraDR.Close()
            Call OraErrSub("Set_CmbGroup" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSQL)
        Catch ex As Exception
            Call vbErrSub("Set_CmbGroup" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
        End Try
    End Function

    '//////////////////////////////////////////////////////////
    '関　数:Set_CmbZone
    '処　理:選択された棟に該当するゾーンを表示
    '引　数:sSoukoCd:選択された倉庫コード
    '       CmbName:選択したコンボボックスの名称
    '       sMyBase:表示拠点'<A286>追加@@091021[apt]k.msr
    '       bNonAuto:自動倉庫を含むならtrue　含まないならfalse
    '作成日:2007/03/15
    '作成者:YAMANE
    '//////////////////////////////////////////////////////////
    Public Function Set_CmbZone(ByVal sSoukoCd As String, _
                                ByVal sMuneCd As String, _
                                ByRef CmbName As ComboBox, _
                                ByVal sMyBase As String, _
                                Optional ByVal bAuto As Boolean = True)
        Dim iLoop As Integer = 0
        Dim sSQL As String
        Dim OraDR As Oracle.DataAccess.Client.OracleDataReader
        Try


            CmbName.Items.Clear()
            CmbName.Items.Add(" ")


            If Len(sSoukoCd) = 0 Then Exit Function
            '追加 kawagoe6/10
            sSQL = ""
            sSQL &= vbLf & " Select DISTINCT"
            sSQL &= vbLf & "      Z.ZONE_SYUBETSU || Z.TANA_CODE AS ZONE_CODE"
            sSQL &= vbLf & " FROM M_RIDGE R "
            sSQL &= vbLf & "     ,M_SOUKO S "
            sSQL &= vbLf & "     ,M_ZONE  Z "
            sSQL &= vbLf & " WHERE  S.SOUKO_CODE = R.SOUKO_CODE"
            sSQL &= vbLf & " AND R.SOUKO_CODE = Z.SOUKO_CODE"
            sSQL &= vbLf & " AND R.RIDGE_CODE = Z.RIDGE_CODE "

            '<A268>表示拠点が指定されていたら条件追加
            If sMyBase <> "" Then
                sSQL &= vbLf & " AND S.BASE_CODE ='" & sMyBase & "'"
            End If

            sSQL &= vbLf & " AND Z.SOUKO_CODE = '" & SQLStr(sSoukoCd) & "'"
            sSQL &= vbLf & " AND Z.RIDGE_CODE = '" & SQLStr(sMuneCd) & "'"
            If bAuto = False Then
                sSQL &= vbLf & " AND Z.SOUKO_CODE||Z.RIDGE_CODE <> '02030'"
            End If
            sSQL &= vbLf & "ORDER BY ZONE_CODE " & vbLf
            OraDR = OraDB.Read(sSQL)
            While OraDR.Read()
                CmbName.Items.Add(OraDR("ZONE_CODE").ToString)
            End While
            OraDR.Close()

            'For iLoop = 0 To UBound(SetZone)
            '    If SetZone(iLoop).sSoukoCd = sSoukoCd And SetZone(iLoop).sMune = sMuneCd Then
            '        CmbName.Items.Add(SetZone(iLoop).sZone)
            '    End If
            'Next

        Catch oraErr As Oracle.DataAccess.Client.OracleException
            OraDR.Close()
            Call OraErrSub("Set_CmbZone" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSQL)
        Catch ex As Exception
            Call vbErrSub("Set_CmbZone" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
        End Try
    End Function


#End Region

 

#Region "Iniファイルクラス"

    Public Class CIniFile
        Declare Function GetPrivateProfileString Lib "KERNEL32.DLL" Alias "GetPrivateProfileStringA" ( _
         ByVal lpAppName As String, _
         ByVal lpKeyName As String, ByVal lpDefault As String, _
         ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, _
         ByVal lpFileName As String) As Integer

        Declare Function GetPrivateProfileStringByByteArray Lib "KERNEL32.DLL" Alias "GetPrivateProfileStringA" ( _
         ByVal lpAppName As String, _
         ByVal lpKeyName As String, ByVal lpDefault As String, _
         ByVal lpReturnedString As Byte(), ByVal nSize As Integer, _
         ByVal lpFileName As String) As Integer

        Declare Function GetPrivateProfileInt Lib "KERNEL32.DLL" Alias "GetPrivateProfileIntA" ( _
         ByVal lpAppName As String, _
         ByVal lpKeyName As String, ByVal nDefault As Integer, _
         ByVal lpFileName As String) As Integer

        Declare Function WritePrivateProfileString Lib "KERNEL32.DLL" Alias "WritePrivateProfileStringA" ( _
         ByVal lpAppName As String, _
         ByVal lpKeyName As String, _
         ByVal lpString As String, _
         ByVal lpFileName As String) As Integer


        'Public Sub New(ByVal sIniPath As String)
        '    m_sIniPath = sIniPath

        'End Sub


        'Public Property IniPath() As String
        '    Get
        '        Return m_sIniPath
        '    End Get

        '    Set(ByVal Value As String)
        '        m_sIniPath = Value
        '    End Set

        'End Property


        ''文字列を読み出す
        Public Function ReadString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String) As String
            Dim sb As StringBuilder = New StringBuilder(1024)
            GetPrivateProfileString(lpAppName, lpKeyName, lpDefault, sb, sb.Capacity, cSysINI)
            ReadString = sb.ToString()

        End Function

        ''整数値を読み出す
        Public Function ReadInteger(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal nDefault As Integer) As Integer
            Dim resultValue As Integer = GetPrivateProfileInt(lpAppName, lpKeyName, nDefault, cSysINI)
            ReadInteger = resultValue

        End Function

        ''文字列を書き出す
        Public Function WriteString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String) As Integer
            WriteString = WritePrivateProfileString(lpAppName, lpKeyName, lpDefault, cSysINI)

        End Function

    End Class
#End Region

#Region "ロケーション編集"

    '**************************************************************
    'ロケーションにスペース入力可能なったので、'_'をスペースに変更
    'する処理を追加する。
    'すべてスペースの場合は、'000000'に変更する。
    '**************************************************************
    Public Function Roke_Awase(ByVal Send_Roke As String) As String

        Roke_Awase = IIf(Send_Roke = "", "000000", Replace(Replace(SQLStr(Send_Roke), "-", ""), "_", " "))
        Roke_Awase = IIf(Roke_Awase = "      ", "000000", Roke_Awase)

        Return Roke_Awase

    End Function

#End Region

#Region "プリントスクリーン用クラス"

    'Public Sub PrintForm(ByVal frm As Form)
    '    'フォームのイメージを取得する
    '    CaptureScreen(frm)
    '    'フォームのイメージを印刷する
    '    Dim PrintDocument1 As New System.Drawing.Printing.PrintDocument
    '    AddHandler PrintDocument1.PrintPage, _
    '        AddressOf PrintDocument1_PrintPage
    '    PrintDocument1.DefaultPageSettings.Landscape = True
    '    PrintDocument1.Print()
    'End Sub

    '<System.Runtime.InteropServices.DllImport("gdi32.dll")> _
    'Private Function BitBlt(ByVal hdcDest As IntPtr, _
    '    ByVal nXDest As Integer, ByVal nYDest As Integer, _
    '    ByVal nWidth As Integer, ByVal nHeight As Integer, _
    '    ByVal hdcSrc As IntPtr, _
    '    ByVal nXSrc As Integer, ByVal nYSrc As Integer, _
    '    ByVal dwRop As Integer) As Boolean
    'End Function

    ''フォームのイメージを保存する変数
    'Private memoryImage As Bitmap

    ''フォームのイメージを取得する
    'Private Sub CaptureScreen(ByVal frm As Form)
    '    Dim mygraphics As Graphics = frm.CreateGraphics()
    '    Dim s As Size = frm.Size
    '    memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
    '    Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
    '    Dim dc1 As IntPtr = mygraphics.GetHdc()
    '    Dim dc2 As IntPtr = memoryGraphics.GetHdc()
    '    BitBlt(dc2, 0, 0, _
    '        frm.ClientRectangle.Width, frm.ClientRectangle.Height, _
    '        dc1, 0, 0, 13369376)
    '    mygraphics.ReleaseHdc(dc1)
    '    memoryGraphics.ReleaseHdc(dc2)
    'End Sub

    ''PrintDocument1のPrintPageイベントハンドラ
    'Private Sub PrintDocument1_PrintPage(ByVal sender As Object, _
    '        ByVal e As System.Drawing.Printing.PrintPageEventArgs)
    '    e.Graphics.DrawImage(memoryImage, 0, 0)
    'End Sub

#End Region

#Region "バーコード関係"

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '関　数:CheckDigit_M43
    '処　理:モジュラス43チェックデジット評価
    '引　数:sData
    '戻り値:Boolean(結果 True/False)
    '作成日:2009/09/18
    '作成者:[apt]k.msr
    '更新日:
    '備　考:<A218>新規作成@@0909018[apt]k.msr
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Public Function CheckDigitM43(ByVal sData As String) As Boolean

        'モジュラス43用 文字列を一文字ずつ数値変換
        Dim sCharNo() = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G" _
                        , "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X" _
                        , "Y", "Z", "-", ".", " ", "$", "/", "+", "%"}

        Dim iLoopChar As Integer = 0 '数値変換配列ループ用
        Dim iLoop As Integer = 0


        Dim sCharStr As String = "" '1文字ずつ処理
        Dim sDataString As String = "" 'チェックデジット抜いた文字列
        Dim sDataDigit As String = "" '文字列内のチェックデジット
        Dim iSumCharNo As Integer = 0 '変換した数値の合計

        Dim iMod43 As Integer = 0 '合計を43で割った余り

        Dim bRet As Boolean = False
        Try

            If sData.Length < 2 Then
                '2文字以下なら抜ける
                Exit Try
            End If

            sDataString = Mid(sData, 1, sData.Length - 1)
            sDataDigit = Mid(sData, sData.Length, 1)


            For iLoop = 1 To sDataString.Length Step 1
                '1文字取得
                sCharStr = Mid(sDataString, iLoop, 1)

                For iLoopChar = 0 To UBound(sCharNo) Step 1
                    If sCharStr = sCharNo(iLoopChar) Then
                        '変換した数値を合計
                        iSumCharNo += iLoopChar
                        Exit For
                    End If
                Next

            Next

            '数値の合計を43で割って余りを出す
            iMod43 = iSumCharNo Mod 43

            'チェックデジットが同じか
            If sDataDigit = sCharNo(iMod43) Then
                bRet = True
            End If


        Catch ex As Exception
            Call vbErrSub("CheckDigitM43" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

        Finally


            CheckDigitM43 = bRet
        End Try


    End Function

#End Region


#Region "リストボックスクラス"

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '関　数:ListWrite
    '処　理:リストボックス書き込み
    '引　数:lstTarget = 書込み対象リストボックス
    '　　　:sCOMENT = 動作、及び処理名を入れる（入庫、ﾄﾗｯｷﾝｸﾞファイル更新など）
    '　　　:sLOG = 具体的な処理内容を入れる　
    '戻り値:なし
    '作成日:2007/04/10
    '作成者:k.msr
    '更新日:
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Public Sub ListWrite(ByRef lstTarget As ListBox, ByVal sCOMENT As String, ByVal sLOG As String)
        Try
            '50行まで残す
            If lstTarget.Items.Count >= 500 Then
                lstTarget.Items.RemoveAt(lstTarget.Items.Count - 1)

            End If
            lstTarget.Items.Insert(0, Format(Now, "HH:mm:ss") & " " & sCOMENT & ":" & sLOG)
            Application.DoEvents()

            'ログ各着込み
            Call LOGWRITE(cLogName, sCOMENT, sLOG)


        Catch ex As Exception
            Call vbErrSub("[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub
#End Region

#Region "その他"
#End Region

#Region "未使用"


    '#Region "コンボボックス値セット"

    '    ''//////////////////////////////////////////////////////////
    '    ''関　数:InputSoukoCd
    '    ''処　理:cmbSoukoCdに値を返す
    '    ''戻り値:sSoukoCd → 倉庫コード
    '    ''作成日:2007/03/13
    '    ''作成者:YAMANE
    '    ''//////////////////////////////////////////////////////////
    '    'Public Function InputSoukoCd() As String()
    '    '    Dim sSQL As String
    '    '    Dim OraDR As Oracle.DataAccess.Client.OracleDataReader

    '    '    Dim sSoukoCd() As String
    '    '    Dim iCnt As Integer = 0

    '    '    Try
    '    '        sSQL = ""
    '    '        sSQL = sSQL & "SELECT " & vbLf
    '    '        sSQL = sSQL & "     SOUKO_CODE " & vbLf
    '    '        sSQL = sSQL & "FROM " & vbLf
    '    '        sSQL = sSQL & "     M_SOUKO " & vbLf

    '    '        OraDR = OraDB.Read(sSQL)
    '    '        While OraDR.Read()
    '    '            ReDim Preserve sSoukoCd(iCnt)
    '    '            sSoukoCd(iCnt) = OraDR.GetValue(0).ToString
    '    '            iCnt += 1
    '    '        End While
    '    '        OraDR.Close()

    '    '    Catch oraErr As Oracle.DataAccess.Client.OracleException
    '    '        Call OraErrSub("InputSoukoCd" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSQL)
    '    '    Catch ex As Exception
    '    '        Call vbErrSub("InputSoukoCd" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
    '    '    End Try

    '    '    Return sSoukoCd

    '    'End Function

    '    ''//////////////////////////////////////////////////////////
    '    ''関　数:InputMuneCd
    '    ''処　理:cmbMuneに値を返す
    '    ''戻り値:sMune → 棟コード
    '    ''作成日:2007/03/13
    '    ''作成者:YAMANE
    '    ''//////////////////////////////////////////////////////////
    '    'Public Function InputMuneCd() As String()
    '    '    Dim sSQL As String
    '    '    Dim OraDR As Oracle.DataAccess.Client.OracleDataReader

    '    '    Dim sMuneCd() As String
    '    '    Dim iCnt As Integer = 0

    '    '    Try
    '    '        'コメント kawagoe6/10
    '    '        'sSQL = ""
    '    '        'sSQL = sSQL & "SELECT " & vbLf
    '    '        'sSQL = sSQL & "     RIDGE_CODE " & vbLf
    '    '        'sSQL = sSQL & "FROM " & vbLf
    '    '        'sSQL = sSQL & "     M_RIDGE " & vbLf

    '    '        sSQL = ""
    '    '        sSQL &= vbLf & " Select DISTINCT"
    '    '        sSQL &= vbLf & "      R.RIDGE_CODE"
    '    '        sSQL &= vbLf & " FROM M_RIDGE R "
    '    '        sSQL &= vbLf & "     ,M_SOUKO S "
    '    '        sSQL &= vbLf & "     ,M_ZONE  Z "
    '    '        sSQL &= vbLf & " WHERE  S.SOUKO_CODE = R.SOUKO_CODE"
    '    '        sSQL &= vbLf & " AND R.SOUKO_CODE = Z.SOUKO_CODE"
    '    '        sSQL &= vbLf & " AND R.RIDGE_CODE = Z.RIDGE_CODE "
    '    '        sSQL &= vbLf & "ORDER BY R.RIDGE_CODE " & vbLf

    '    '        OraDR = OraDB.Read(sSQL)

    '    '        While OraDR.Read()
    '    '            ReDim Preserve sMuneCd(iCnt)
    '    '            sMuneCd(iCnt) = OraDR.GetValue(0).ToString
    '    '            iCnt += 1
    '    '        End While
    '    '        OraDR.Close()

    '    '    Catch oraErr As Oracle.DataAccess.Client.OracleException
    '    '        Call OraErrSub("InputMuneCd" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSQL)
    '    '    Catch ex As Exception
    '    '        Call vbErrSub("InputMuneCd" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
    '    '    End Try

    '    '    Return sMuneCd

    '    'End Function

    '    ''//////////////////////////////////////////////////////////
    '    ''関　数:InputMuneCd
    '    ''処　理:cmbZoneに値を返す
    '    ''戻り値:sZone → ゾーン
    '    ''作成日:2007/03/13
    '    ''作成者:YAMANE
    '    ''//////////////////////////////////////////////////////////
    '    'Public Function InputZone() As String()
    '    '    Dim sSQL As String
    '    '    Dim OraDR As Oracle.DataAccess.Client.OracleDataReader

    '    '    Dim sZone() As String
    '    '    Dim iCnt As Integer = 0
    '    '    Dim strZone As String

    '    '    Try
    '    '        'sSQL = ""
    '    '        'sSQL = sSQL & "SELECT " & vbLf
    '    '        'sSQL = sSQL & "     ZONE_SYUBETSU, " & vbLf
    '    '        'sSQL = sSQL & "     TANA_CODE " & vbLf
    '    '        'sSQL = sSQL & "FROM " & vbLf
    '    '        'sSQL = sSQL & "     M_ZONE " & vbLf

    '    '        '修正 kawagoe6/11
    '    '        sSQL = ""
    '    '        sSQL &= vbLf & " Select DISTINCT"
    '    '        sSQL &= vbLf & "      Z.ZONE_SYUBETSU , Z.TANA_CODE"
    '    '        sSQL &= vbLf & " FROM M_RIDGE R "
    '    '        sSQL &= vbLf & "     ,M_SOUKO S "
    '    '        sSQL &= vbLf & "     ,M_ZONE  Z "
    '    '        sSQL &= vbLf & " WHERE  S.SOUKO_CODE = R.SOUKO_CODE"
    '    '        sSQL &= vbLf & " AND R.SOUKO_CODE = Z.SOUKO_CODE"
    '    '        sSQL &= vbLf & " AND R.RIDGE_CODE = Z.RIDGE_CODE "
    '    '        sSQL &= vbLf & "ORDER BY Z.ZONE_SYUBETSU , Z.TANA_CODE " & vbLf
    '    '        OraDR = OraDB.Read(sSQL)
    '    '        While OraDR.Read
    '    '            strZone = OraDR.GetValue(0).ToString & OraDR.GetValue(1).ToString '値を結合
    '    '            ReDim Preserve sZone(iCnt)
    '    '            sZone(iCnt) = strZone
    '    '            iCnt += 1
    '    '        End While
    '    '        OraDR.Close()

    '    '    Catch oraErr As Oracle.DataAccess.Client.OracleException
    '    '        Call OraErrSub("InputZone" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSQL)
    '    '    Catch ex As Exception
    '    '        Call vbErrSub("InputZone" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
    '    '    End Try

    '    '    Return sZone

    '    'End Function




    '#End Region
#End Region


End Module
