'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
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


Public Class frmKakunoSts


#Region "イベント-フォーム-"
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sMsg As String = ""
        Try




            '共通項目初期化
            Call InitCommon()


            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.MaximumSize = New System.Drawing.Size(1500, 1500)

            'タブコントロールの描画モードをオーナードローに変更
            TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed

            '仮データセット
            Call ShowData()


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
                Case 3
                Case 4
                Case 5
                Case 6
                Case 7
                Case 8
                    '詳細
                    frmTanaZai.ShowDialog()
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
    'TabControl1_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Selecting

        Try

            If TabControl1.SelectedIndex = 0 Then
                '共通項目初期化
                Call InitCommon_Tab0()

            ElseIf TabControl1.SelectedIndex = 1 Then
                '共通項目初期化
                Call InitCommon_Tab1()
            Else
                '共通項目初期化
                Call InitCommon_Tab2()
            End If
            

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '棚卸状況
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub RadioButton10_Click(sender As Object, e As EventArgs) Handles RadioButton10.Click

        Try
            Label54.Visible = True
            Label53.Visible = True
            Label57.Visible = True
            Label58.Visible = True
            Label56.Visible = True
            Label55.Visible = True

            Label1.Visible = False
            Label9.Visible = False
            Label2.Visible = False
            Label10.Visible = False
            Label3.Visible = False
            Label11.Visible = False
            Label4.Visible = False
            Label22.Visible = False
            Label5.Visible = False
            Label24.Visible = False
            Label6.Visible = False
            Label26.Visible = False
            Label37.Visible = False
            Label29.Visible = False

            dgvTana.Item(30, 1).Style.BackColor = Color.Red
            dgvTana.Item(30, 2).Style.BackColor = Color.Red
            dgvTana.Item(30, 3).Style.BackColor = Color.FromArgb(128, 255, 255)
            dgvTana.Item(30, 4).Style.BackColor = Color.FromArgb(128, 255, 255)

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '棚卸状況
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub RadioButton9_Click(sender As Object, e As EventArgs) Handles RadioButton9.Click

        Try
            Label54.Visible = False
            Label53.Visible = False
            Label57.Visible = False
            Label58.Visible = False
            Label56.Visible = False
            Label55.Visible = False

            Label1.Visible = True
            Label9.Visible = True
            Label2.Visible = True
            Label10.Visible = True
            Label3.Visible = True
            Label11.Visible = True
            Label4.Visible = True
            Label22.Visible = True
            Label5.Visible = True
            Label24.Visible = True
            Label6.Visible = True
            Label26.Visible = True
            Label37.Visible = True
            Label29.Visible = True

            dgvTana.Item(30, 1).Style.BackColor = Color.White
            dgvTana.Item(30, 2).Style.BackColor = Color.White
            dgvTana.Item(30, 3).Style.BackColor = Color.White
            dgvTana.Item(30, 4).Style.BackColor = Color.White

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

#End Region


#Region "関数"
    '標準フォームのオブジェクト設定_タブ1
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
            btnFXX(2).Text = ""
            btnFXX(3).Text = ""
            btnFXX(4).Text = ""

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = ""
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""

            btnFXX(9).Text = ""
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = False
            btnFXX(2).Enabled = False
            btnFXX(3).Enabled = False
            btnFXX(4).Enabled = False

            btnFXX(5).Enabled = True
            btnFXX(6).Enabled = False
            btnFXX(7).Enabled = False
            btnFXX(8).Enabled = False

            btnFXX(9).Enabled = True
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

            lblTitle.Text = "格納状況問合せ"

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub


    '標準フォームのオブジェクト設定_タブ1
    Private Sub InitCommon_Tab0()
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
            btnFXX(2).Text = ""
            btnFXX(3).Text = ""
            btnFXX(4).Text = ""

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = ""
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""

            btnFXX(9).Text = ""
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = False
            btnFXX(2).Enabled = False
            btnFXX(3).Enabled = False
            btnFXX(4).Enabled = False

            btnFXX(5).Enabled = True
            btnFXX(6).Enabled = False
            btnFXX(7).Enabled = False
            btnFXX(8).Enabled = False

            btnFXX(9).Enabled = True
            btnFXX(10).Enabled = False
            btnFXX(11).Enabled = False
            btnFXX(12).Enabled = True

            '表示ﾃｷｽﾄ空白は使用許可＝False
            For iLoop = 1 To UBound(btnFXX) Step 1
                If btnFXX(iLoop).Text.Length <= 0 Then
                    btnFXX(iLoop).Enabled = False
                End If
            Next

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub

    '標準フォームのオブジェクト設定_タブ2
    Private Sub InitCommon_Tab1()
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
            btnFXX(2).Text = ""
            btnFXX(3).Text = ""
            btnFXX(4).Text = ""

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = ""
            btnFXX(7).Text = ""
            btnFXX(8).Text = "詳細"

            btnFXX(9).Text = ""
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = False
            btnFXX(2).Enabled = False
            btnFXX(3).Enabled = False
            btnFXX(4).Enabled = False

            btnFXX(5).Enabled = True
            btnFXX(6).Enabled = False
            btnFXX(7).Enabled = False
            btnFXX(8).Enabled = True

            btnFXX(9).Enabled = True
            btnFXX(10).Enabled = False
            btnFXX(11).Enabled = False
            btnFXX(12).Enabled = True

            '表示ﾃｷｽﾄ空白は使用許可＝False
            For iLoop = 1 To UBound(btnFXX) Step 1
                If btnFXX(iLoop).Text.Length <= 0 Then
                    btnFXX(iLoop).Enabled = False
                End If
            Next

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub

    '標準フォームのオブジェクト設定_タブ3
    Private Sub InitCommon_Tab2()
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
            btnFXX(2).Text = ""
            btnFXX(3).Text = ""
            btnFXX(4).Text = ""

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = ""
            btnFXX(7).Text = ""
            btnFXX(8).Text = "詳細"

            btnFXX(9).Text = ""
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = False
            btnFXX(2).Enabled = False
            btnFXX(3).Enabled = False
            btnFXX(4).Enabled = False

            btnFXX(5).Enabled = True
            btnFXX(6).Enabled = False
            btnFXX(7).Enabled = False
            btnFXX(8).Enabled = True

            btnFXX(9).Enabled = True
            btnFXX(10).Enabled = False
            btnFXX(11).Enabled = False
            btnFXX(12).Enabled = True

            '表示ﾃｷｽﾄ空白は使用許可＝False
            For iLoop = 1 To UBound(btnFXX) Step 1
                If btnFXX(iLoop).Text.Length <= 0 Then
                    btnFXX(iLoop).Enabled = False
                End If
            Next

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

            ''自動倉庫
            For iloop = 0 To 24
                iRow = dgvTana.Rows.Add()

                'dgvTana.Rows(iloop).HeaderCell.Value = (25 - iloop).ToString

                dgvTana(0, iRow).Value = (25 - iloop).ToString         'ヘッダの代わり（仮）
                dgvTana(0, iRow).Style.BackColor = Color.Silver
                dgvTana(1, iRow).Value = ""         '1連目
                dgvTana(2, iRow).Value = ""         '2連目
                dgvTana(3, iRow).Value = ""         '3連目
                dgvTana(4, iRow).Value = ""         '
                dgvTana(5, iRow).Value = ""         '5連目
                dgvTana(6, iRow).Value = ""         '
                dgvTana(7, iRow).Value = ""         '
                dgvTana(8, iRow).Value = ""         '
                dgvTana(9, iRow).Value = ""         '
                dgvTana(10, iRow).Value = ""        '10連目
                'dgvTana(10, iRow).ToolTipText = "共通商品コード：1234567890123456" & vbCrLf & _
                '                                "商品名：商品名あいうえおかきくけこさしす" & vbCrLf & _
                '                                "賞味期限：YYYY/MM/DD、ﾛｯﾄNo：1234567890、在庫数：12,345,678.99" & vbCrLf & _
                '                                "賞味期限：YYYY/MM/DD、ﾛｯﾄNo：1234567890、在庫数：12,345,678.99" & vbCrLf & _
                '                                "予約元部署：部署名あいうえお"
                dgvTana(11, iRow).Value = ""        '
                dgvTana(12, iRow).Value = ""        '
                dgvTana(13, iRow).Value = ""        '
                dgvTana(14, iRow).Value = ""        '
                dgvTana(15, iRow).Value = ""        '15連目
                dgvTana(16, iRow).Value = ""        '
                dgvTana(17, iRow).Value = ""        '
                dgvTana(18, iRow).Value = ""        '
                dgvTana(19, iRow).Value = ""        '
                dgvTana(20, iRow).Value = ""        '20連目
                dgvTana(21, iRow).Value = ""        '
                dgvTana(22, iRow).Value = ""        '
                dgvTana(23, iRow).Value = ""        '
                dgvTana(24, iRow).Value = ""        '
                dgvTana(25, iRow).Value = ""        '25連目
                dgvTana(26, iRow).Value = ""        '
                dgvTana(27, iRow).Value = ""        '
                dgvTana(28, iRow).Value = ""        '
                dgvTana(29, iRow).Value = ""        '
                dgvTana(30, iRow).Value = ""        '30連目
                dgvTana(31, iRow).Value = ""        '
                dgvTana(32, iRow).Value = ""        '
                dgvTana(33, iRow).Value = ""        '
                dgvTana(34, iRow).Value = ""        '

            Next


            ''DPS_ライン１_棚状況
            For iloop = 0 To 1
                iRow = dgvDpsLine1.Rows.Add()

                dgvDpsLine1.Rows(iloop).HeaderCell.Value = (2 - iloop).ToString

                dgvDpsLine1(0, iRow).Value = ""         '1段目
                dgvDpsLine1(1, iRow).Value = ""         '2段目
                'dgvDpsLine1(1, iRow).ToolTipText = "共通商品コード：1234567890123456" & vbCrLf & _
                '                                   "商品名：商品名あいうえおかきくけこさしす" & vbCrLf & _
                '                                   "賞味期限：YYYY/MM/DD、ﾛｯﾄNo：1234567890、在庫数：12,345,678.99" & vbCrLf & _
                '                                   "賞味期限：YYYY/MM/DD、ﾛｯﾄNo：1234567890、在庫数：12,345,678.99" & vbCrLf & _
                '                                   "予約元部署：部署名あいうえお"

                dgvDpsLine1(2, iRow).Value = ""         '3段目

                dgvDpsLine1.Item(1, iRow).Style.BackColor = Color.FromArgb(128, 255, 255)
                dgvDpsLine1(1, iRow).Value = "100"
                dgvDpsLine1.Item(3, iRow).Style.BackColor = Color.FromArgb(0, 192, 0)
                dgvDpsLine1(3, iRow).Value = "1000"
            Next

            dgvDpsLine1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvDpsLine1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ''DPS_ライン１_明細
            For iloop = 0 To 9
                iRow = dgvDpsLine1Meisai.Rows.Add()

                dgvDpsLine1Meisai(0, iRow).Value = "2015/06/30"     '賞味期限
                dgvDpsLine1Meisai(1, iRow).Value = "1234567890"     'ロットNo
                dgvDpsLine1Meisai(2, iRow).Value = "12,345,678.99"  '在庫数

            Next


            ''DPS_ライン２_棚状況
            For iloop = 0 To 2
                iRow = dgvDpsLine2.Rows.Add()

                dgvDpsLine2.Rows(iloop).HeaderCell.Value = (3 - iloop).ToString

                dgvDpsLine2(0, iRow).Value = ""         '1段目
                dgvDpsLine2(1, iRow).Value = ""         '2段目
                'dgvDpsLine2(1, iRow).ToolTipText = "共通商品コード：1234567890123456" & vbCrLf & _
                '                                   "商品名：商品名あいうえおかきくけこさしす" & vbCrLf & _
                '                                   "賞味期限：YYYY/MM/DD、ﾛｯﾄNo：1234567890、在庫数：12,345,678.99" & vbCrLf & _
                '                                   "賞味期限：YYYY/MM/DD、ﾛｯﾄNo：1234567890、在庫数：12,345,678.99" & vbCrLf & _
                '                                   "予約元部署：部署名あいうえお"
                dgvDpsLine2(2, iRow).Value = ""         '3段目

            Next

            ''DPS_ライン２_明細
            For iloop = 0 To 9
                iRow = dgvDpsLine2Meisai.Rows.Add()

                dgvDpsLine2Meisai(0, iRow).Value = "2015/06/30"     '賞味期限
                dgvDpsLine2Meisai(1, iRow).Value = "1234567890"     'ロットNo
                dgvDpsLine2Meisai(2, iRow).Value = "12,345,678.99"  '在庫数

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

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'bt詳細_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt詳細_Click(sender As Object, e As EventArgs) Handles dgvTana.CellDoubleClick, dgvDpsLine1.CellDoubleClick, dgvDpsLine2.CellDoubleClick
        Dim frmEdit As New frmTanaZai
        Try

            '棚在庫詳細一覧呼び出し
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub


#End Region

End Class
