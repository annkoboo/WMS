Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Reflection.MethodInfo
Imports WMS.clsCommon.Library
Imports WMS.CommonModule
Imports Microsoft.VisualBasic


Public Class frmTuhanKenpin10Key

#Region "イベント"
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'フォーム_Load
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub 通販エリア検品_10キー_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'Call ShowData()

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
