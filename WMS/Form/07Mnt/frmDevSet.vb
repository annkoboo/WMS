﻿'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
'_/変更履歴
'_/
'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Reflection.MethodInfo
Imports WMS.clsCommon.Library
Imports WMS.CommonModule
Imports Microsoft.VisualBasic


Public Class frmDevSet


#Region "イベント-フォーム-"
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sMsg As String = ""
        Try




            '共通項目初期化
            Call InitCommon()


            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.MaximumSize = New System.Drawing.Size(1500, 1500)

            '仮データセット
            Call ShowData()

            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.MaximumSize = New System.Drawing.Size(1500, 1500)

            'タブコントロールの描画モードをオーナードローに変更
            TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
            'TabControl2.DrawMode = TabDrawMode.OwnerDrawFixed
            'TabControl3.DrawMode = TabDrawMode.OwnerDrawFixed

        Catch ex As Exception
            Call vbErrSub(MyBase.GetType.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, CShort(Err.Number), ex)
        End Try
    End Sub



#End Region

#Region "イベント"
    ''コマンドボタンクリック
    Protected Overridable Sub btnFun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iIndex As Integer = Mid(CType(sender, System.Windows.Forms.Button).Name, Len(CType(sender, System.Windows.Forms.Button).Name) - 1, 2)

        Dim btnFXX() As System.Windows.Forms.Button = {Nothing, btnF01, btnF02, btnF03, btnF04, btnF05, btnF06, btnF07, btnF08, btnF09, btnF10, btnF11, btnF12}
        Dim intCnt As Integer

        Try

            For intCnt = 1 To 12
                btnEnb(intCnt) = btnFXX(intCnt).Enabled
                btnFXX(intCnt).Enabled = False
            Next intCnt

            Select Case iIndex
                Case 1
                Case 2
                    'F2 設定
                Case 3
                Case 4
                Case 5
                    'F5 表示
                Case 6
                    'F6 取消
                Case 7
                Case 8
                Case 9
                Case 10
                Case 11
                Case 12
                    'F12 戻る

                    Me.Close()
                    Me.Dispose()
            End Select

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        Finally
            For intCnt = 1 To 12
                btnFXX(intCnt).Enabled = btnEnb(intCnt)
            Next intCnt
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'データグリッドクリック
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'Private Sub dgvYotei_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvYotei.CellClick
    '    Try
    '        If e.RowIndex = -1 Then Exit Try

    '        clsDgvSelect.SelSingle(Me.dgvYotei, e.RowIndex, Color.Aquamarine)

    '    Catch ex As Exception
    '        Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

    '    End Try
    'End Sub


    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'bt表示_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub btnHyoji_Click(sender As Object, e As EventArgs)
        Try

            '在庫一覧表示

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

#End Region


#Region "関数"
    '標準フォームのオブジェクト設定
    Private Sub InitCommon()
        Dim iLoop As Integer
        Dim btnFXX() As System.Windows.Forms.Button = {Nothing, _
                                                        btnF01, _
                                                        btnF02, _
                                                        btnF03, _
                                                        btnF04, _
                                                        btnF05, _
                                                        btnF06, _
                                                        btnF07, _
                                                        btnF08, _
                                                        btnF09, _
                                                        btnF10, _
                                                        btnF11, _
                                                        btnF12}
        Try
            'ファンクションボタン_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
            '表示ﾃｷｽﾄ
            btnFXX(1).Text = ""
            btnFXX(2).Text = "登録"
            btnFXX(3).Text = ""
            btnFXX(4).Text = "削除"

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = "入力ｸﾘｱ"
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""

            btnFXX(9).Text = ""
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = False
            btnFXX(2).Enabled = True
            btnFXX(3).Enabled = False
            btnFXX(4).Enabled = True

            btnFXX(5).Enabled = True
            btnFXX(6).Enabled = True
            btnFXX(7).Enabled = False
            btnFXX(8).Enabled = False

            btnFXX(9).Enabled = False
            btnFXX(10).Enabled = False
            btnFXX(11).Enabled = False
            btnFXX(12).Enabled = True

            '表示ﾃｷｽﾄ空白は使用許可＝False
            For iLoop = 1 To UBound(btnFXX) Step 1
                If btnFXX(iLoop).Text.Length <= 0 Then
                    btnFXX(iLoop).Enabled = False
                End If
            Next

            'イベント割付
            For i As Integer = 1 To 12
                AddHandler btnFXX(i).Click, AddressOf btnFun_Click
            Next

            '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

            ''列固定
            'dgvYotei.Columns(3).Frozen = True

            ''バックカラー初期化
            'dgvYotei.DefaultCellStyle.BackColor = Color.White
            'dgvYotei.DefaultCellStyle.SelectionBackColor = Color.White
            'dgvYotei.DefaultCellStyle.ForeColor = Color.Black
            'dgvYotei.DefaultCellStyle.SelectionForeColor = Color.Black

            lblTitle.Text = "端末メンテナンス"

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub



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

            'HTプリンタ定義
            dgvHT_Printer.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvHT_Printer.Rows.Add()

                dgvHT_Printer(0, iRow).Value = "99"                       '設定No
                dgvHT_Printer(1, iRow).Value = "あいうえおかきくけこ"     'プリンタ用途
                dgvHT_Printer(2, iRow).Value = "あいうえおかきくけこ"     'リスト出力
                dgvHT_Printer(3, iRow).Value = "あいうえおかきくけこ"     'ラベルプリンタ
                'dgvHT_Printer(4, iRow).Value = "あいうえおかきくけこ"     '携帯プリンタ

            Next


            'HTメンテナンス（端末）
            dgvHT_Ment.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvHT_Ment.Rows.Add()

                dgvHT_Ment(0, iRow).Value = "99"                             '端末No
                dgvHT_Ment(1, iRow).Value = "あいうえおかきくけこさしすせそ" '端末名称
                dgvHT_Ment(2, iRow).Value = "あいうえおかきくけこ"           'プリンタ用途

            Next

            'メンテナンス（プリンタ用途）
            dgvHT_PrinterYouto.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvHT_PrinterYouto.Rows.Add()

                dgvHT_PrinterYouto(0, iRow).Value = "あいうえおかきくけこ"   'プリンタ用途

            Next

            'PCプリンタ定義
            dgvPC_Printer.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvPC_Printer.Rows.Add()

                dgvPC_Printer(0, iRow).Value = "PC-XXXXXXXXXX"            '端末名
                dgvPC_Printer(1, iRow).Value = "あいうえおかきくけこ"     'OSユーザー名
                dgvPC_Printer(2, iRow).Value = "あいうえおかきくけこ"     'レーザープリンタ名
                dgvPC_Printer(3, iRow).Value = "あいうえおかきくけこ"     'ラベルプリンタ

            Next


        Catch oraErr As Oracle.DataAccess.Client.OracleException
            Call OraErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSql)
        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

        Finally


        End Try
    End Sub

    'タブ描画
    Private Sub TabControl1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        '変数定義
        Dim backBrush As SolidBrush
        Dim foreBrush As SolidBrush

        '選択中のタブを判定
        If TabControl1.SelectedIndex = e.Index Then
            backBrush = New SolidBrush(Color.Navy)
            foreBrush = New SolidBrush(Color.White)
        Else
            backBrush = New SolidBrush(SystemColors.Control)
            foreBrush = New SolidBrush(Color.Black)
        End If

        '背景色塗潰し
        e.Graphics.FillRectangle(backBrush, e.Bounds)

        '表示文字列描画
        Dim format As StringFormat = New StringFormat()
        Dim rect As RectangleF = New RectangleF(e.Bounds.X, e.Bounds.Y + 6, e.Bounds.Width, e.Bounds.Height)
        format.Alignment = StringAlignment.Center
        e.Graphics.DrawString(TabControl1.TabPages(e.Index).Text, TabControl1.Font, foreBrush, rect, format)
    End Sub

    'タブ描画
    'Private Sub TabControl2_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
    '    '変数定義
    '    Dim backBrush As SolidBrush
    '    Dim foreBrush As SolidBrush

    '    '選択中のタブを判定
    '    If TabControl2.SelectedIndex = e.Index Then
    '        backBrush = New SolidBrush(Color.Navy)
    '        foreBrush = New SolidBrush(Color.White)
    '    Else
    '        backBrush = New SolidBrush(SystemColors.Control)
    '        foreBrush = New SolidBrush(Color.Black)
    '    End If

    '    '背景色塗潰し
    '    e.Graphics.FillRectangle(backBrush, e.Bounds)

    '    '表示文字列描画
    '    Dim format As StringFormat = New StringFormat()
    '    Dim rect As RectangleF = New RectangleF(e.Bounds.X, e.Bounds.Y + 6, e.Bounds.Width, e.Bounds.Height)
    '    format.Alignment = StringAlignment.Center
    '    e.Graphics.DrawString(TabControl2.TabPages(e.Index).Text, TabControl2.Font, foreBrush, rect, format)
    'End Sub

    'タブ描画
    'Private Sub TabControl3_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
    '    '変数定義
    '    Dim backBrush As SolidBrush
    '    Dim foreBrush As SolidBrush

    '    '選択中のタブを判定
    '    If TabControl3.SelectedIndex = e.Index Then
    '        backBrush = New SolidBrush(Color.Navy)
    '        foreBrush = New SolidBrush(Color.White)
    '    Else
    '        backBrush = New SolidBrush(SystemColors.Control)
    '        foreBrush = New SolidBrush(Color.Black)
    '    End If

    '    '背景色塗潰し
    '    e.Graphics.FillRectangle(backBrush, e.Bounds)

    '    '表示文字列描画
    '    Dim format As StringFormat = New StringFormat()
    '    Dim rect As RectangleF = New RectangleF(e.Bounds.X, e.Bounds.Y + 6, e.Bounds.Width, e.Bounds.Height)
    '    format.Alignment = StringAlignment.Center
    '    e.Graphics.DrawString(TabControl3.TabPages(e.Index).Text, TabControl3.Font, foreBrush, rect, format)
    'End Sub

#End Region


End Class
