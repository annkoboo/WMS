Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Reflection.MethodInfo
Imports WMS.clsCommon.Library
Imports WMS.CommonModule
Imports Microsoft.VisualBasic
Imports Oracle.DataAccess.Client


Public Class frmLogon

#Region "イベント"
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'フォーム_Load
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub ログオン_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Call ShowData()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '終了ボタン_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtUserCd_LostFocus(sender As Object, e As EventArgs) Handles txtUserCd.LostFocus
        Try
            '作業者名を表示
            Me.txtUserNm.Text = fncGetUserNm()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '設定ボタン_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub btnAuth_Click(sender As Object, e As EventArgs) Handles btnAuth.Click
        Try
            '砂時計にする
            Frm.WaitCursorAndDisable(Me)

            '入力内容のチェック
            If fncChkEty() = "NG" Then
                Exit Sub
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        Finally
            '砂時計を解除
            Frm.ArrowAndEnable(Me)

        End Try
    End Sub

#End Region


    ''' <summary>
    ''' 作業者名の取得
    ''' </summary>
    ''' <returns>作業者名</returns>
    Public Function fncGetUserNm() As String
        'SQL作成
        Dim Sql As String = ""
        Sql += "select USER_NAME "
        Sql += "from M_USER "
        Sql += "where USER_CODE = " & OraDB.Num(Me.txtUserCd.Text)
        Debug.Print(Sql)

        'SQL実行
        Dim OraReader As OracleDataReader
        OraReader = OraDB.Read(Sql)

        'SELECTしたデータを取得
        Dim UserNm As String = ""
        While OraReader.Read
            UserNm = OraReader("USER_NAME")
            Exit While  '1件しかないはずなので抜ける
        End While

        '件数を返す
        OraReader.Close()
        Return UserNm

    End Function

    ''' <summary>
    ''' 入力内容のチェック
    ''' </summary>
    ''' <returns>"OK"、"NG"</returns>
    Private Function fncChkEty() As String
        Try
            Dim Msg As String = ""

            '作業者コード
            If Not Char.IsNumber(Me.txtUserCd.Text) Then
                Msg = "［作業者コード］には数字を入力してください。"
                MessageBox.Show(Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Frm.ArrowAndEnable(Me)
                Me.txtUserCd.Focus()
                Return "NG"
            End If

            'パスワード
            If Not Char.IsNumber(Me.txtPassWord.Text) Then
                Msg = "［パスワード］を入力してください。"
                MessageBox.Show(Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Frm.ArrowAndEnable(Me)
                Me.txtPassWord.Focus()
                Return "NG"
            End If

            'ログオン認証
            If fncAuth() = "NG" Then
                Msg = "［作業者コード］または［パスワード］が正しくありません。"
                MessageBox.Show(Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Frm.ArrowAndEnable(Me)
                Me.txtPassWord.Focus()
                Return "NG"
            End If

            '入力内容OK
            Return "OK"

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
            Return "NG"

        End Try
    End Function

    ''' <summary>
    ''' ログイン認証
    ''' </summary>
    ''' <returns>"OK"、"NG"</returns>
    Public Function fncAuth() As String
        'SQL作成
        Dim Sql As String = ""
        Sql += "select * "
        Sql += "from M_USER "
        Sql += "where USER_CODE = " & OraDB.Num(Me.txtUserCd.Text)
        Sql += "and   PASSWORD = " & OraDB.Str(Me.txtPassWord.Text)
        Debug.Print(Sql)

        'SQL実行
        Dim OraReader As OracleDataReader
        OraReader = OraDB.Read(Sql)

        'SELECTしたデータを取得
        Dim Ret As String = ""
        If OraReader.Read() = True Then
            Logon_UserCd = OraReader("USER_CODE")
            Logon_UserAccLvl = OraReader("ACCESS_LVL")
            Ret = "OK"
        Else
            Logon_UserCd = 0
            Logon_UserAccLvl = 0
            Ret = "NG"
        End If

        '件数を返す
        OraReader.Close()
        Return Ret

    End Function

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '関　数:ShowData
    '処　理:検索表示処理
    '引　数:
    '作成日
    '作成者:
    '備　考:
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub ShowData()
        Dim sSql As String = ""

        Dim drRow() As DataRow = Nothing

        Dim iloop As Integer = 0
        Dim iRow As Integer = 0

        Try
            'dgvShohin.RowCount = 0

            'For iloop = 0 To 9
            '    iRow = dgvShohin.Rows.Add()


            '    dgvShohin(0, iRow).Value = "1234567890123456"       '商品コード
            '    dgvShohin(1, iRow).Value = "商品名あいうえおかきくけこさしす"     '商品名
            '    dgvShohin(2, iRow).Value = "規格あいうえおかきく"   '規格
            '    dgvShohin(3, iRow).Value = "1234567890123456"       'AMS商品コード
            '    dgvShohin(4, iRow).Value = "123456"       '得意先コード
            '    dgvShohin(5, iRow).Value = "得意先名あいうえおかきくけこさしすせそ"       '得意先名


            'Next


        Catch oraErr As Oracle.DataAccess.Client.OracleException
            Call OraErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSql)
        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

        Finally


        End Try
    End Sub

End Class
