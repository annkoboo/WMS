Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Reflection.MethodInfo
Imports WMS.clsCommon.Library
Imports WMS.CommonModule
Imports Microsoft.VisualBasic


Public Class frmHojuMotoSet

#Region "イベント"
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'フォーム_Load
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub 補充元選択設定_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.MaximumSize = New System.Drawing.Size(1500, 1500)
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
            dgvSyu_HojyuMoto.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvSyu_HojyuMoto.Rows.Add()


                dgvSyu_HojyuMoto(0, iRow).Value = False       'DPS
                dgvSyu_HojyuMoto(1, iRow).Value = True '自動
                
                dgvSyu_HojyuMoto(2, iRow).Value = "1234567890123456"      '商品コード
                dgvSyu_HojyuMoto(3, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvSyu_HojyuMoto(4, iRow).Value = "2015/06/30"       '最終出荷賞味期限
                dgvSyu_HojyuMoto(5, iRow).Value = "12,345,678.99"       '在庫数
                dgvSyu_HojyuMoto(6, iRow).Value = "12,345,678.99"       '出荷指示数量
                dgvSyu_HojyuMoto(7, iRow).Value = "12,345,678.99"       '不足数量
            Next

            'DPS
            dgvDPS.RowCount = 0

            For iloop = 0 To 2
                iRow = dgvDPS.Rows.Add()

                dgvDPS(0, iRow).Value = "22-11-11-11" '棚
                dgvDPS(1, iRow).Value = "2015/06/30" '賞味期限
                dgvDPS(2, iRow).Value = "12,345,678.99"   '在庫数
                dgvDPS(3, iRow).Value = "12,345,678.99"   '出荷指示数
                dgvDPS(4, iRow).Value = "1234567890123456"       '商品ｺｰﾄﾞ
                dgvDPS(5, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"        '商品名
            Next

            'バックヤード
            dgvJidou.RowCount = 0

            For iloop = 0 To 2
                iRow = dgvJidou.Rows.Add()

                dgvJidou(0, iRow).Value = "11-11-11-11" '棚
                dgvJidou(1, iRow).Value = "2015/06/30" '賞味期限
                dgvJidou(2, iRow).Value = "12,345,678.99"   '在庫数
                dgvJidou(3, iRow).Value = "12,345,678.99"   '出荷指示数
                dgvJidou(4, iRow).Value = "1234567890123456"       '商品ｺｰﾄﾞ
                dgvJidou(5, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"        '商品名
            Next

        Catch oraErr As Oracle.DataAccess.Client.OracleException
            Call OraErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSql)
        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

        Finally


        End Try
    End Sub

    
End Class
