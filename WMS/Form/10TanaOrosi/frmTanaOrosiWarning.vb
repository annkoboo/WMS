Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Reflection.MethodInfo
Imports WMS.clsCommon.Library
Imports WMS.CommonModule
Imports Microsoft.VisualBasic


Public Class frmTanaOrosiWarning

#Region "イベント"
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'フォーム_Load
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub 棚卸警告_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '発行ボタン_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt発行_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '共通商品コード一覧_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt共通商品コード一覧_Click(sender As Object, e As EventArgs)
        Dim frmEdit As New frmHinSel
        Try

            '共通商品コード一覧呼び出し
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ラジオボタン チェンジ
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles rb棚卸差異リスト発行.CheckedChanged
        Try

            bt棚卸差異リスト発行.Enabled = rb棚卸差異リスト発行.Checked

            bt在庫更新.Enabled = rb在庫更新.Checked

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        Finally


        End Try
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
    'Private Sub ShowData()
    '    Dim sSql As String = ""

    '    Dim drRow() As DataRow = Nothing

    '    Dim iloop As Integer = 0
    '    Dim iRow As Integer = 0

    '    Try
    '        dgvMeisai.RowCount = 0

    '        For iloop = 0 To 9
    '            iRow = dgvMeisai.Rows.Add()


    '            dgvMeisai(0, iRow).Value = False            'ﾁｪｯｸ
    '            dgvMeisai(1, iRow).Value = "9999"           'ステーションNo
    '            dgvMeisai(2, iRow).Value = "あいうえおかきくけこ"     'ステーションNo名称
    '            dgvMeisai(3, iRow).Value = "あいうえお"      '入出庫モード
    '            dgvMeisai(4, iRow).Value = "あいうえお"      '状態

    '        Next


    '    Catch oraErr As Oracle.DataAccess.Client.OracleException
    '        Call OraErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSql)
    '    Catch ex As Exception
    '        Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

    '    Finally


    '    End Try
    'End Sub


End Class
