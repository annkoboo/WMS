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


Public Class frmYokiHimozuke


#Region "イベント-フォーム-"
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sMsg As String = ""
        Try




            '共通項目初期化
            Call InitCommon()


            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.MaximumSize = New System.Drawing.Size(2000, 2000)

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
                    'F1 戻る
                    Me.Close()
                    Me.Dispose()

                Case 2
                Case 3
                Case 4
                Case 5
                Case 6
                Case 7
                Case 8
                Case 9
                    'F9 入力クリア

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

            Else
                '共通項目初期化
                Call InitCommon_Tab1()
            End If
            

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

    ''_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    ''TabPage2_Click
    ''_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    '    Try
    '        '共通項目初期化
    '        Call InitCommon_Tab2()

    '    Catch ex As Exception
    '        Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
    '    End Try
    'End Sub


    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '入庫ラベル一覧_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt入庫ラベル一覧_Click(sender As Object, e As EventArgs) Handles bt入庫ラベル.Click
        Dim frmEdit As New frmNyukoLblSel
        Try

            '共通商品コード一覧呼び出し
            frmEdit.ShowDialog()

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
            btnFXX(2).Text = "設定"
            btnFXX(3).Text = ""
            btnFXX(4).Text = ""

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = "入力クリア"
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
            btnFXX(4).Enabled = False

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

            lblTitle.Text = "容器紐付け設定"

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub



    '標準フォームのオブジェクト設定_タブ0
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
            btnFXX(2).Text = "設定"
            btnFXX(3).Text = ""
            btnFXX(4).Text = ""

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = "入力クリア"
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
            btnFXX(4).Enabled = False

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
            btnFXX(2).Text = "設定"
            btnFXX(3).Text = "入力"
            btnFXX(4).Text = "削除"

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = "入力クリア"
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""

            btnFXX(9).Text = ""
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = False
            btnFXX(2).Enabled = True
            btnFXX(3).Enabled = True
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
            '容器紐付け
            dgvYoukiSet.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvYoukiSet.Rows.Add()


                dgvYoukiSet(0, iRow).Value = "1234567"       '入庫ラベルNo
                dgvYoukiSet(1, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvYoukiSet(2, iRow).Value = "12,345,678.99"       '総数
                dgvYoukiSet(3, iRow).Value = "2015/06/30"   '賞味期限
                dgvYoukiSet(4, iRow).Value = "1234567890"       'ロットNo
                dgvYoukiSet(5, iRow).Value = "2015/05/01"   '入荷日
                dgvYoukiSet(6, iRow).Value = "2015/05/01"   '初回入荷日
                dgvYoukiSet(7, iRow).Value = "未検査品"       '品質区分
                dgvYoukiSet(8, iRow).Value = "その他"       '荷主区分
                dgvYoukiSet(9, iRow).Value = "1234567890123456"       '共通商品コード
                dgvYoukiSet(10, iRow).Value = "備考備考あいうえおかきくけこさしすせそたちつてとなにぬねのは"     '備考
                dgvYoukiSet(11, iRow).Value = "規格あいうえおかきくけこ"   '規格
                dgvYoukiSet(12, iRow).Value = "123,456.99"       'ケース入数
                dgvYoukiSet(13, iRow).Value = "1,234"       'ケース数
                dgvYoukiSet(14, iRow).Value = "12,345,678.99"       'バラ数


            Next

            '解除
            dgvYoukiCansel.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvYoukiCansel.Rows.Add()

                dgvYoukiCansel(0, iRow).Value = True       '選択
                dgvYoukiCansel(1, iRow).Value = "1234567"       '入庫ラベルNo
                dgvYoukiCansel(2, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvYoukiCansel(3, iRow).Value = "12,345,678.99"       '総数
                dgvYoukiCansel(4, iRow).Value = "2015/06/30"   '賞味期限
                dgvYoukiCansel(5, iRow).Value = "1234567890"       'ロットNo
                dgvYoukiCansel(6, iRow).Value = "2015/05/01"   '入荷日
                dgvYoukiCansel(7, iRow).Value = "2015/05/01"   '初回入荷日
                dgvYoukiCansel(8, iRow).Value = "未検査品"       '品質区分
                dgvYoukiCansel(9, iRow).Value = "その他"       '荷主区分
                dgvYoukiCansel(10, iRow).Value = "1234567890123456"       '共通商品コード
                dgvYoukiCansel(11, iRow).Value = "備考備考あいうえおかきくけこさしすせそたちつてとなにぬねのは"     '備考
                dgvYoukiCansel(12, iRow).Value = "規格あいうえおかきくけこ"   '規格
                dgvYoukiCansel(13, iRow).Value = "123,456.99"       'ケース入数
                dgvYoukiCansel(14, iRow).Value = "1,234"       'ケース数
                dgvYoukiCansel(15, iRow).Value = "12,345,678.99"       'バラ数


            Next

            For iloop = 0 To 9
                iRow = dgvyoukiNo.Rows.Add()

                dgvyoukiNo(0, iRow).Value = "123456"       '入庫ラベルNo

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




#End Region


End Class
