Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Reflection.MethodInfo
Imports WMS.clsCommon.Library
Imports WMS.CommonModule
Imports Microsoft.VisualBasic


Public Class frmTanaZai

#Region "イベント"
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'フォーム_Load
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub 棚在庫詳細_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Call ShowData()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '終了ボタン_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt終了_Click(sender As Object, e As EventArgs) Handles bt終了.Click
        Me.Close()
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '終了ボタン_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt選択_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

#End Region

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
            dgvTana_Zaiko.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvTana_Zaiko.Rows.Add()


                dgvTana_Zaiko(0, iRow).Value = "1234567890123456"       '商品コード
                dgvTana_Zaiko(1, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvTana_Zaiko(2, iRow).Value = "12,345,678.99"     '総数
                dgvTana_Zaiko(3, iRow).Value = "2015/06/30"        '賞味期限
                dgvTana_Zaiko(4, iRow).Value = "1234567890"        'ﾛｯﾄNo
                dgvTana_Zaiko(5, iRow).Value = "2015/05/01"        '入荷日
                dgvTana_Zaiko(6, iRow).Value = "2015/05/01"        '初回入荷日
                dgvTana_Zaiko(7, iRow).Value = "その他"           '予約区分
                dgvTana_Zaiko(8, iRow).Value = "2015/05/01"       'データ作成日
                dgvTana_Zaiko(9, iRow).Value = "備考備考あいうえおかきくけこさしすせそたちつてとなにぬねのは"     '備考
                dgvTana_Zaiko(10, iRow).Value = "規格あいうえおかきくけこ"   '規格
                dgvTana_Zaiko(11, iRow).Value = "未検査品"       '品質区分
                dgvTana_Zaiko(12, iRow).Value = "その他"         '荷主区分

            Next

        Catch oraErr As Oracle.DataAccess.Client.OracleException
            Call OraErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSql)
        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

        Finally


        End Try
    End Sub

    
End Class
