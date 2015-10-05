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


Public Class frmIdoKanryo


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
                    'F1 補充作業リスト出力
                    Dim frmEdit As New frmIdoLstPrt
                    frmEdit.ShowDialog()

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

            ElseIf TabControl1.SelectedIndex = 1 Then
                '共通項目初期化
                Call InitCommon_Tab1()
            Else
            End If
            

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '共通商品コード一覧_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt共通商品コード一覧1_Click(sender As Object, e As EventArgs)
        Dim frmEdit As New frmHinSel
        Try

            '共通商品コード一覧呼び出し
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '共通商品コード一覧_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt共通商品コード一覧2_Click(sender As Object, e As EventArgs) Handles bt共通商品コード一覧2.Click
        Dim frmEdit As New frmHinSel
        Try

            '共通商品コード一覧呼び出し
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '共通商品コード一覧_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt共通商品コード一覧3_Click(sender As Object, e As EventArgs) Handles bt共通商品コード一覧3.Click
        Dim frmEdit As New frmHinSel
        Try

            '共通商品コード一覧呼び出し
            frmEdit.ShowDialog()

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
            btnFXX(1).Text = "移動作業リスト発行"
            btnFXX(2).Text = "設定"
            btnFXX(3).Text = "入力"
            btnFXX(4).Text = ""

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = "入力クリア"
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""

            btnFXX(9).Text = "削除"
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = True
            btnFXX(2).Enabled = True
            btnFXX(3).Enabled = True
            btnFXX(4).Enabled = False

            btnFXX(5).Enabled = True
            btnFXX(6).Enabled = True
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

            lblTitle.Text = "移動完了設定"

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
           '表示ﾃｷｽﾄ
            btnFXX(1).Text = "移動作業リスト発行"
            btnFXX(2).Text = "設定"
            btnFXX(3).Text = "入力"
            btnFXX(4).Text = ""

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = "入力クリア"
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""

            btnFXX(9).Text = "削除"
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = True
            btnFXX(2).Enabled = True
            btnFXX(3).Enabled = True
            btnFXX(4).Enabled = False

            btnFXX(5).Enabled = True
            btnFXX(6).Enabled = True
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
            btnFXX(1).Text = "移動作業リスト発行"
            btnFXX(2).Text = "設定"
            btnFXX(3).Text = "入力"
            btnFXX(4).Text = ""

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = "入力クリア"
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""

            btnFXX(9).Text = "削除"
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = True
            btnFXX(2).Enabled = True
            btnFXX(3).Enabled = True
            btnFXX(4).Enabled = False

            btnFXX(5).Enabled = True
            btnFXX(6).Enabled = True
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

            '移動元【上】
            dgvIdoFrom_Top.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvIdoFrom_Top.Rows.Add()
                dgvIdoFrom_Top(0, iRow).Value = "11-11-11-11"       '移動元棚No
                dgvIdoFrom_Top(1, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名

                dgvIdoFrom_Top(2, iRow).Value = "2015/06/30"     '賞味期限
                dgvIdoFrom_Top(3, iRow).Value = "1234567890"     'ﾛｯﾄNo
                dgvIdoFrom_Top(4, iRow).Value = "2015/06/30"     '入荷日
                dgvIdoFrom_Top(5, iRow).Value = "2015/06/30"     '初回入荷日
                dgvIdoFrom_Top(6, iRow).Value = "12345678.99"     '在庫数
                dgvIdoFrom_Top(7, iRow).Value = "その他"     '予約区分
                dgvIdoFrom_Top(8, iRow).Value = "1234567890123456"       '共通商品コード
                dgvIdoFrom_Top(9, iRow).Value = "規格あいうえおかきくけこ"   '規格
                dgvIdoFrom_Top(10, iRow).Value = "1234567890123456"       '関連会社コード
                dgvIdoFrom_Top(11, iRow).Value = "備考あいうえおかきくけこさしすせそたちつてとなにぬねのはひふ"     '備考
                dgvIdoFrom_Top(12, iRow).Value = "予約理由あいうえおかきくけこさしすせそたちつてとなにぬねのは"     '予約理由


            Next

            '移動元【下】
            dgvIdoFrom_Btm.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvIdoFrom_Btm.Rows.Add()
                dgvIdoFrom_Btm(0, iRow).Value = "11-11-11-11"       '移動元棚No
                dgvIdoFrom_Btm(1, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvIdoFrom_Btm(2, iRow).Value = "1234456.99"      'ｹｰｽ入数
                dgvIdoFrom_Btm(3, iRow).Value = "1234"            'ｹｰｽ数
                dgvIdoFrom_Btm(4, iRow).Value = "12345678.99"     'ﾊﾞﾗ数
                dgvIdoFrom_Btm(5, iRow).Value = "12345678.99"     '総数
                dgvIdoFrom_Btm(6, iRow).Value = "2015/06/30"     '賞味期限
                dgvIdoFrom_Btm(7, iRow).Value = "1234567890"     'ﾛｯﾄNo
                dgvIdoFrom_Btm(8, iRow).Value = "2015/06/30"     '入荷日
                dgvIdoFrom_Btm(9, iRow).Value = "2015/06/30"     '初回入荷日
                dgvIdoFrom_Btm(10, iRow).Value = "その他"     '予約区分
                dgvIdoFrom_Btm(11, iRow).Value = "1234567890123456"       '共通商品コード
                dgvIdoFrom_Btm(12, iRow).Value = "規格あいうえおかきくけこ"   '規格
            Next

            '移動先【上】
            dgvIdoTo_Top.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvIdoTo_Top.Rows.Add()
                dgvIdoTo_Top(0, iRow).Value = "11-11-11-11"       '移動元棚No
                dgvIdoTo_Top(1, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvIdoTo_Top(2, iRow).Value = "2015/06/30"     '賞味期限
                dgvIdoTo_Top(3, iRow).Value = "1234567890"     'ﾛｯﾄNo
                dgvIdoTo_Top(4, iRow).Value = "2015/06/30"     '入荷日
                dgvIdoTo_Top(5, iRow).Value = "2015/06/30"     '初回入荷日
                dgvIdoTo_Top(6, iRow).Value = "12345678.99"     '総数
                dgvIdoTo_Top(7, iRow).Value = "1234"            'ｹｰｽ数
                dgvIdoTo_Top(8, iRow).Value = "12345678.99"     'ﾊﾞﾗ数
                dgvIdoTo_Top(9, iRow).Value = "1234456.99"      'ｹｰｽ入数
                dgvIdoTo_Top(10, iRow).Value = "その他"     '予約区分
                dgvIdoTo_Top(11, iRow).Value = "1234567890123456"       '共通商品コード
                dgvIdoTo_Top(12, iRow).Value = "規格あいうえおかきくけこ"   '規格
            Next

            '移動先【下】
            dgvIdoTo_Btm.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvIdoTo_Btm.Rows.Add()
                dgvIdoTo_Btm(0, iRow).Value = "11-11-11-11"       '移動元棚No
                dgvIdoTo_Btm(1, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvIdoTo_Btm(2, iRow).Value = "1234456.99"      'ｹｰｽ入数
                dgvIdoTo_Btm(3, iRow).Value = "1234"            'ｹｰｽ数
                dgvIdoTo_Btm(4, iRow).Value = "12345678.99"     'ﾊﾞﾗ数
                dgvIdoTo_Btm(5, iRow).Value = "12345678.99"     '総数
                dgvIdoTo_Btm(6, iRow).Value = "2015/06/30"     '賞味期限
                dgvIdoTo_Btm(7, iRow).Value = "1234567890"     'ﾛｯﾄNo
                dgvIdoTo_Btm(8, iRow).Value = "2015/06/30"     '入荷日
                dgvIdoTo_Btm(9, iRow).Value = "2015/06/30"     '入荷日
                dgvIdoTo_Btm(10, iRow).Value = "その他"     '予約区分
                dgvIdoTo_Btm(11, iRow).Value = "99-99-99-99"       '移動先棚No
                dgvIdoTo_Btm(12, iRow).Value = "1234567890123456"       '共通商品コード
                dgvIdoTo_Btm(13, iRow).Value = "規格あいうえおかきくけこ"   '規格

            Next

            dgvZaiko.RowCount = 0
            For iloop = 0 To 9
                iRow = dgvZaiko.Rows.Add()

                dgvZaiko(0, iRow).Value = "AFC本社"       '格納元倉庫
                dgvZaiko(1, iRow).Value = "99999"       '台車No
                dgvZaiko(2, iRow).Value = "1234567890123456"      '共通商品コード
                dgvZaiko(3, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvZaiko(4, iRow).Value = "2015/06/30"   '賞味期限
                dgvZaiko(5, iRow).Value = "1234567890"       'ロットNo
                dgvZaiko(6, iRow).Value = "2015/07/01"   '入荷日
                dgvZaiko(7, iRow).Value = "2015/07/01"   '初回入荷日
                dgvZaiko(8, iRow).Value = "12,345,678.99"       '移動数
                dgvZaiko(9, iRow).Value = "移動元作業者"       '移動元作業者
                dgvZaiko(10, iRow).Value = "備考備考備考備考備考備考備考備考備考備考備考備考備考備考備考"     '備考
            Next

            dgvZaiko_In.RowCount = 0
            For iloop = 0 To 9
                iRow = dgvZaiko_In.Rows.Add()

                dgvZaiko_In(0, iRow).Value = "AFC本社"       '移動元倉庫
                dgvZaiko_In(1, iRow).Value = "外部倉庫"       '移動先倉庫
                dgvZaiko_In(2, iRow).Value = "99999"       '台車No
                dgvZaiko_In(3, iRow).Value = "1234567890123456"      '共通商品コード
                dgvZaiko_In(4, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvZaiko_In(5, iRow).Value = "1,234"       '移動ｹｰｽ数
                dgvZaiko_In(6, iRow).Value = "12,345,678.99"       '移動ﾊﾞﾗ数
                dgvZaiko_In(7, iRow).Value = "2015/06/30"   '賞味期限
                dgvZaiko_In(8, iRow).Value = "1234567890"       'ロットNo
                dgvZaiko_In(9, iRow).Value = "2015/07/01"   '入荷日
                dgvZaiko_In(10, iRow).Value = "2015/07/01"   '初回入荷日
                dgvZaiko_In(11, iRow).Value = "12,345,678.99"       '移動数
                dgvZaiko_In(12, iRow).Value = "移動元作業者"       '移動元作業者
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
