Imports Oracle.DataAccess.Client
Imports System.Configuration

Public Class ACCESS 'DB関係アクセス用のクラス

    'Public Const sUser As String = ""       'ユーザ名
    'Public Const sPassword As String = ""   'パスワード
    'Public Const sService As String = ""    '接続サービス
    'Public Const sCatalog As String = "WACS-Lite"   'SqlServer用 ﾃｰﾌﾞﾙスペースみたいなもの?

    '定数ではなく変数にして、アプリ起動時にApp.configから取得・設定する
    Public sUser As String = ""       'ユーザ名
    Public sPassword As String = ""   'パスワード
    Public sService As String = ""    '接続サービス

#Region "オラクルDB用"
    'オラクルDBのアクセス用(Oracle10g.ver)
    Public Class Oracle_Access
        Private OraConnect = New Oracle.DataAccess.Client.OracleConnection
        Private OraCommand = New Oracle.DataAccess.Client.OracleCommand
        Private Trans As Oracle.DataAccess.Client.OracleTransaction
        Private mblnTrans As Boolean = False 'ﾄﾗﾝｻﾞｸｼｮﾝﾌﾟﾛﾊﾟﾃｨ
        Private mblnDbOpen As Boolean = False 'オラクルオープンﾌﾟﾛﾊﾟﾃｨ

        'ﾌﾟﾛﾊﾟﾃｨ_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
        ''トランザクションがかかっているかどうか
        Public ReadOnly Property Transaction() As Boolean
            Get
                Return mblnTrans
            End Get
        End Property

        ''パラメータ
        Public ReadOnly Property Parameters(ByVal ParaName As String) As OracleParameter
            Get
                Return OraCommand.Parameters(ParaName)
            End Get
        End Property

        ''DBオープン
        Public ReadOnly Property DB_Open() As Boolean
            Get
                Return mblnDbOpen
            End Get
        End Property

        Public Sub Open()
            Try
                OraConnect.ConnectionString = "user id=" & DbAcc.sUser & ";data source=" & DbAcc.sService & ";password= " & DbAcc.sPassword
                OraConnect.Open()
                OraCommand.Connection = OraConnect

                mblnDbOpen = True

            Catch OraErr As Oracle.DataAccess.Client.OracleException
                Call OraErrSub("ACCESS.Oracle_Access.Open", OraErr.Number, OraErr.Message, OraErr, "")
                Try
                    OraConnect.Close()
                    mblnDbOpen = False
                Catch ex As Exception
                End Try

            Catch ex As Exception
                Call vbErrSub("ACCESS.Oracle_Access.Open", Err.Number, ex, False, 0)
                Try
                    OraConnect.Close()
                    mblnDbOpen = False
                Catch
                End Try

            Finally
            End Try
        End Sub
        Public Sub Close()
            OraConnect.Close()
            mblnDbOpen = False
        End Sub
        Public Function Read(ByVal sSQL As String, Optional ByVal bLog As Boolean = False) As Oracle.DataAccess.Client.OracleDataReader

            Try
                '<AXX>ログを残すように変更@@091130[apt]k.msr
                If bLog = True Then
                    Call LOGWRITE(cSqlLogName, "SQL[READ:START]", "------------------------------------------")
                    Call LOGWRITE(cSqlLogName, "SQL", vbLf & sSQL)
                End If

                OraCommand.CommandText = sSQL
                Read = OraCommand.ExecuteReader

            Catch OraErr As Oracle.DataAccess.Client.OracleException
                If OraErr.Number = 54 Then
                    '54はデータがロックされているので、このSELECTの実行元でメッセージを表示する
                Else
                    Call OraErrSub("ACCESS.Oracle_Access.Read", OraErr.Number, OraErr.Message, OraErr, sSQL)
                End If
                Throw OraErr

            Catch ex As Exception
                Call vbErrSub("ACCESS.Oracle_Access.Read", Err.Number, ex, False, 0)
                Try
                    Read.Close()
                    OraCommand.CommandText = sSQL
                    Read = OraCommand.ExecuteReader

                    Throw ex
                Catch ex2 As Exception
                    Throw ex2
                End Try

            Finally
                '<AXX>ログを残すように変更@@091130[apt]k.msr
                If bLog = True Then
                    Call LOGWRITE(cSqlLogName, "SQL[READ:END]", "------------------------------------------" & vbLf)
                End If

            End Try
        End Function

        Public Function Excute(ByVal sSQL As String, Optional ByVal bLog As Boolean = False) As Long
            Try
                '<AXX>ログを残すように変更@@091130[apt]k.msr
                If bLog = True Then
                    Call LOGWRITE(cSqlLogName, "SQL[EXCUTE:START]", "------------------------------------------")
                    Call LOGWRITE(cSqlLogName, "SQL", vbLf & sSQL)
                End If

                OraCommand.CommandText = sSQL
                Excute = OraCommand.ExecuteNonQuery

            Catch OraErr As Oracle.DataAccess.Client.OracleException
                Call OraErrSub("ACCESS.Oracle_Access.Excute", OraErr.Number, OraErr.Message, OraErr, sSQL)
                Throw OraErr

            Catch ex As Exception
                Call vbErrSub("ACCESS.Oracle_Access.Excute", Err.Number, ex, False, 0)
                Throw ex

            Finally
                '<AXX>ログを残すように変更@@091130[apt]k.msr
                If bLog = True Then
                    Call LOGWRITE(cSqlLogName, "SQL[EXCUTE:END]", "------------------------------------------" & vbLf)
                End If

            End Try
        End Function

        'DS戸沢
        'Public Sub BiginTrans()
        Public Sub BeginTrans()
            Try
                Trans = OraConnect.BeginTransaction
                mblnTrans = True    'DS戸沢

            Catch OraErr As Oracle.DataAccess.Client.OracleException
                Call OraErrSub("ACCESS.Oracle_Access.Excute", OraErr.Number, OraErr.Message, OraErr, "")
                Trans.Rollback()
            Catch ex As Exception
                Call vbErrSub("ACCESS.Oracle_Access.Excute", Err.Number, ex, False, 0)
                Trans.Rollback()
            End Try
        End Sub
        Public Sub Commit()
            Try
                Trans.Commit()
                mblnTrans = False   'DS戸沢
            Catch OraErr As Oracle.DataAccess.Client.OracleException
                Call OraErrSub("ACCESS.Oracle_Access.Excute", OraErr.Number, OraErr.Message, OraErr, "")
            Catch ex As Exception
                Call vbErrSub("ACCESS.Oracle_Access.Excute", Err.Number, ex, False, 0)
            End Try
        End Sub
        Public Sub RollBack()
            Try
                Trans.Rollback()
                mblnTrans = False   'DS戸沢
            Catch OraErr As Oracle.DataAccess.Client.OracleException
                Call OraErrSub("ACCESS.Oracle_Access.Excute", OraErr.Number, OraErr.Message, OraErr, "")
            Catch ex As Exception
                Call vbErrSub("ACCESS.Oracle_Access.Excute", Err.Number, ex, False, 0)
            End Try
        End Sub

        ''パラメータの設定
        Public Sub ParamSet(ByVal ParamName As String, _
                            Optional ByVal OraType As OracleDbType = OracleDbType.Varchar2, _
                            Optional ByVal Size As Integer = 255, _
                            Optional ByVal OraOutIn As ParameterDirection = ParameterDirection.InputOutput, _
                            Optional ByVal Array As Boolean = False, _
                            Optional ByVal ArraySize As Integer = 255, _
                            Optional ByVal Value As Object = "")
            Dim iLoop As Integer = 0
            Dim iSize() As Integer
            Dim oraParaState() As Oracle.DataAccess.Client.OracleParameterStatus

            Try


                'パラメータの設定
                OraCommand.Parameters.Add(New OracleParameter(ParamName, OraType, OraOutIn))


                'OUTPUTならNULLを代入
                If OraOutIn = ParameterDirection.Output Or OraOutIn = ParameterDirection.ReturnValue Then
                    OraCommand.Parameters(ParamName).Value = DBNull.Value
                Else
                    OraCommand.Parameters(ParamName).Value = Value
                End If


                '配列以外でない、かつ文字型の場合サイズ設定
                If Array = False And (OraType = OracleDbType.Varchar2 Or OraType = OracleDbType.Char) Then
                    OraCommand.Parameters(ParamName).Size = Size
                End If

                ''配列の場合
                If Array Then
                    OraCommand.Parameters(ParamName).CollectionType = OracleCollectionType.PLSQLAssociativeArray
                    OraCommand.Parameters(ParamName).Size = ArraySize

                    '文字型データ（Verchar2,Etc)の場合ｱｲﾃﾑ毎にサイズを指定
                    If OraType = OracleDbType.Varchar2 Or OraType = OracleDbType.Char Then

                        'サイズを配列に格納
                        ReDim iSize(ArraySize - 1)
                        For iLoop = 0 To ArraySize - 1 Step 1
                            iSize(iLoop) = Size
                        Next

                        'ｱｲﾃﾑ毎のサイズを格納
                        OraCommand.Parameters(ParamName).ArrayBindSize = iSize

                    End If

                    'InputならBindStatus設定
                    ''If OraOutIn = ParameterDirection.Input Then
                    ''    ReDim oraParaState(ArraySize - 1)
                    ''    ''For iLoop = 0 To ArraySize - 1 Step 1
                    ''    ''    oraParaState(iLoop) = OracleParameterStatus.Success
                    ''    ''Next
                    ''    ''OraCommand.Parameters(ParamName).ArrayBindStatus = oraParaState
                    ''End If
                End If





            Catch oraErr As Oracle.DataAccess.Client.OracleException
                Call OraErrSub("ParamSet", oraErr.Number, oraErr.Message, oraErr, cShowMsg)
                Throw oraErr

            Catch ex As Exception
                Call vbErrSub("ParamSet", Err.Number, ex, False, cShowMsg)
                Throw ex
            End Try

        End Sub

        ''パラメータのクリア
        Public Sub ParamClear()
            OraCommand.Parameters.Clear()
        End Sub

        ''' <summary>
        ''' オラクルの文字リテラルに整形
        ''' </summary>
        ''' <param name="Val">整形する値</param>
        ''' <param name="Comma">お尻にカンマを付けるかどうか。INSERTのVALUESなどに使用する</param>
        ''' <returns>整形した文字列</returns>
        Public Function Str(ByVal Val As String, Optional ByVal Comma As Boolean = False) As String
            Dim sStr As String = ""

            If Val = "" Then
                sStr = "''"
            Else
                sStr = "'" & Val.Replace("'", "''") & "'"
            End If

            If Comma = False Then
                sStr += " "
            Else
                sStr += ", "
            End If

            Return sStr
        End Function

        Public Function Num(ByVal Val As String, Optional ByVal Comma As Boolean = False) As String
            Dim sStr As String = ""

            If Val = "" Then
                sStr = "0"
            Else
                sStr = Integer.Parse(Val.Trim(" "))
            End If

            If Comma = False Then
                sStr += " "
            Else
                sStr += ", "
            End If

            Return sStr
        End Function
    End Class
#End Region



#Region "MS-ACCESS用"
    ''''''マイクロソフトACCESSのアクセス用
    '''''Public Class MSACCESS_Access
    '''''    Public OleConnect As New OleDb.OleDbConnection
    '''''    Public OleCommand As New OleDb.OleDbCommand
    '''''    Public sPath As String
    '''''    Public Property フルパス() As Short
    '''''        Get
    '''''            Return sPath
    '''''        End Get
    '''''        Set(ByVal Value As Short)
    '''''            sPath = Value
    '''''        End Set
    '''''    End Property

    '''''    Public Sub Open()
    '''''        Try
    '''''            OleConnect.ConnectionString = sPath
    '''''            OleConnect.Open()
    '''''            OleCommand.Connection = OleConnect
    '''''        Catch
    '''''            Call vbErrSub("ACCESS.MSACCESS_Access.Open", Err.Number, False, 0)
    '''''        End Try
    '''''    End Sub
    '''''    Public Sub Close()
    '''''        OleConnect.Close()
    '''''    End Sub
    '''''    Public Function Read(ByVal sSQL As String) As OleDb.OleDbDataReader
    '''''        Try
    '''''            OleCommand.CommandText = sSQL
    '''''            Read = OleCommand.ExecuteReader
    '''''        Catch
    '''''            Call vbErrSub("ACCESS.MSACCESS_Access.Read", Err.Number, False, 0)
    '''''            Read.Close()
    '''''            Try
    '''''            Catch ex As Exception
    '''''            End Try
    '''''        End Try
    '''''    End Function

    '''''    Public Function Excute(ByVal sSQL As String) As Short
    '''''        Try
    '''''            OleCommand.CommandText = sSQL
    '''''            Excute = OleCommand.ExecuteNonQuery
    '''''        Catch
    '''''            Call vbErrSub("ACCESS.MSACCESS_Access.Excute", Err.Number, False, 0)
    '''''        End Try
    '''''    End Function

    '''''    Public Function 退避(ByVal ExpPath As String)

    '''''    End Function
    '''''End Class
#End Region

#Region "SQL-SERVER用"
#End Region

#Region "File"
    'ファイルのアクセス用
    Public Class File_Access

        Public sPath As String
        Public shCol As String
        Public tType As System.ValueType

        Public Property フルパス() As String
            Get
                Return sPath
            End Get
            Set(ByVal Value As String)
                sPath = Value
            End Set
        End Property

        Public Property 構造体() As System.ValueType
            Get
                Return tType
            End Get
            Set(ByVal Value As System.ValueType)
                tType = Value
            End Set
        End Property

        Public Sub Write_Output(ByVal sWord As String)
            Try
                FileOpen(1, sPath, OpenMode.Output, OpenAccess.Write)
                WriteLine(1, sPath)
                FileClose(1)
            Catch ex As Exception
                Call vbErrSub("ACCESS.File_Access.Write_Output", Err.Number, ex, False, 0)
            End Try

        End Sub
        Public Sub Write_Append(ByVal sWord As String)
            Try
                FileOpen(1, sPath, OpenMode.Append, OpenAccess.Write)
                WriteLine(1, sPath)
                FileClose(1)
            Catch ex As Exception
                Call vbErrSub("ACCESS.File_Access.Write_Append", Err.Number, ex, False, 0)
            End Try

        End Sub
        Public Sub Open(ByVal FileNo As Short, ByVal Mode As Microsoft.VisualBasic.OpenMode, ByVal iLength As Integer)
            Try
                FileOpen(FileNo, sPath, Mode, OpenAccess.Read, , iLength)
            Catch ex As Exception
                Call vbErrSub("ACCESS.File_Access.Random_Open", Err.Number, ex, False, 0)
            End Try
        End Sub
        Public Sub Close(ByVal FileNo As Short)
            Try
                FileClose(FileNo)
            Catch ex As Exception
                Call vbErrSub("ACCESS.File_Access.Random_Close", Err.Number, ex, False, 0)
            End Try

        End Sub
        Public Sub Write_Random(ByVal FileNo As Short, ByVal shWriteRoW As Short)
            Try
                FilePut(FileNo, tType, shWriteRoW)
            Catch ex As Exception
                Call vbErrSub("ACCESS.File_Access.Write_Random", Err.Number, ex, False, 0)
            End Try

        End Sub
        Public Function Read(ByVal fileNo As Short, Optional ByVal shReadRoW As Short = Nothing) As System.ValueType
            Try
                FileGet(fileNo, tType, shReadRoW)
                Read = tType
            Catch ex As Exception
                Call vbErrSub("ACCESS.File_Access.Read_Random", Err.Number, ex, False, 0)
            End Try

        End Function
    End Class
#End Region


End Class
