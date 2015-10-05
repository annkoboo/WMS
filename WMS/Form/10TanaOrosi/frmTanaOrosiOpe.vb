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


Public Class frmTanaOrosiOpe


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

            ShowData()

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
        Dim frmEdit As New frmTanaOrosiLstPrt

        Dim frmEdit2 As New frmTanaOrosiZanLst

        Try

            For intCnt = 1 To 12
                btnEnb(intCnt) = btnFXX(intCnt).Enabled
                btnFXX(intCnt).Enabled = False
            Next intCnt

            Select Case iIndex
                Case 1
                    'F1 棚卸リスト発行
                    frmEdit.ShowDialog()
                Case 2
                Case 3
                    'F3 棚範囲入力
                Case 4
                    'F4 棚削除
                Case 5
                    'F5 商品入力
                Case 6
                    'F6 商品削除
                Case 7
                Case 8
                    'F8 残作業一覧
                    If Me.TabControl1.SelectedIndex = 3 Then
                        frmEdit2.ShowDialog()
                    End If
                Case 9
                    'F9 前へ

                    If Me.TabControl1.SelectedIndex > 0 Then
                        Me.TabControl1.SelectedIndex -= 1
                    End If

                Case 10
                    'F10 次へ

                    If Me.TabControl1.SelectedIndex < Me.TabControl1.TabPages.Count Then
                        Me.TabControl1.SelectedIndex += 1
                    End If

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

            'ファンクション再設定
            InitCommon_1()
        End Try
    End Sub


    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '共通商品コード一覧_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt共通商品コード一覧1_Click(sender As Object, e As EventArgs) Handles bt共通商品コード1.Click, bt共通商品コード2.Click
        Dim frmEdit As New frmHinSel
        Try

            '共通商品コード一覧呼び出し
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub


    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'タブコントロール クリック
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        Try

            InitCommon_1()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub


    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ラジオボタン チェンジ
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs)
    '    Try

    '        bt棚卸差異リスト発行.Enabled = rb棚卸差異リスト発行.Checked

    '        bt在庫更新.Enabled = rb在庫更新.Checked

    '    Catch ex As Exception
    '        Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
    '    Finally
    '        'ファンクションボタン制御
    '        InitCommon_1()
    '    End Try
    'End Sub


    '棚卸確定ボタン
    Private Sub bt棚卸確定_Click(sender As Object, e As EventArgs) Handles bt棚卸確定.Click
        Dim frmEdit As New frmTanaOrosiWarning
        Try

            ''棚卸警告画面
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
            btnFXX(1).Text = "棚卸リスト発行"
            btnFXX(2).Text = ""
            btnFXX(3).Text = "棚範囲入力"
            btnFXX(4).Text = "棚削除"

            btnFXX(5).Text = "商品入力"
            btnFXX(6).Text = "商品削除"
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""

            btnFXX(9).Text = ""
            btnFXX(10).Text = "次へ"
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = True
            btnFXX(2).Enabled = False
            btnFXX(3).Enabled = True
            btnFXX(4).Enabled = True

            btnFXX(5).Enabled = True
            btnFXX(6).Enabled = True
            btnFXX(7).Enabled = False
            btnFXX(8).Enabled = False
          
            btnFXX(9).Enabled = False
            btnFXX(10).Enabled = True
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

            lblTitle.Text = "棚卸開始・終了設定"

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub


    '標準フォームのオブジェクト設定
    Private Sub InitCommon_1()
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

            Select Case TabControl1.SelectedIndex

                Case 0 '【対象平置在庫】
                    '表示ﾃｷｽﾄ
                    btnFXX(1).Text = "棚卸リスト発行"
                    btnFXX(2).Text = ""
                    btnFXX(3).Text = "棚範囲入力"
                    btnFXX(4).Text = "棚削除"

                    btnFXX(5).Text = "商品入力"
                    btnFXX(6).Text = "商品削除"
                    btnFXX(7).Text = ""
                    btnFXX(8).Text = ""

                    btnFXX(9).Text = ""
                    btnFXX(10).Text = "次へ"
                    btnFXX(11).Text = ""
                    btnFXX(12).Text = "戻る"

                    '使用許可(初期)
                    btnFXX(1).Enabled = True
                    btnFXX(2).Enabled = False
                    btnFXX(3).Enabled = True
                    btnFXX(4).Enabled = True

                    btnFXX(5).Enabled = True
                    btnFXX(6).Enabled = True
                    btnFXX(7).Enabled = False
                    btnFXX(8).Enabled = False

                    btnFXX(9).Enabled = False
                    btnFXX(10).Enabled = True
                    btnFXX(11).Enabled = False
                    btnFXX(12).Enabled = True
                Case 1 '【対象自動倉庫在庫】
                    '表示ﾃｷｽﾄ
                    btnFXX(1).Text = "棚卸リスト発行"
                    btnFXX(2).Text = ""
                    btnFXX(3).Text = "棚範囲入力"
                    btnFXX(4).Text = "棚削除"

                    btnFXX(5).Text = "商品入力"
                    btnFXX(6).Text = "商品削除"
                    btnFXX(7).Text = ""
                    btnFXX(8).Text = ""

                    btnFXX(9).Text = "前へ"
                    btnFXX(10).Text = "次へ"
                    btnFXX(11).Text = ""
                    btnFXX(12).Text = "戻る"

                    '使用許可(初期)
                    btnFXX(1).Enabled = True
                    btnFXX(2).Enabled = False
                    btnFXX(3).Enabled = True
                    btnFXX(4).Enabled = True

                    btnFXX(5).Enabled = True
                    btnFXX(6).Enabled = True
                    btnFXX(7).Enabled = False
                    btnFXX(8).Enabled = False

                    btnFXX(9).Enabled = True
                    btnFXX(10).Enabled = True
                    btnFXX(11).Enabled = False
                    btnFXX(12).Enabled = True
                Case 2 '【棚卸開始】
                    '表示ﾃｷｽﾄ
                    btnFXX(1).Text = "棚卸リスト発行"
                    btnFXX(2).Text = ""
                    btnFXX(3).Text = ""
                    btnFXX(4).Text = ""

                    btnFXX(5).Text = ""
                    btnFXX(6).Text = ""
                    btnFXX(7).Text = ""
                    btnFXX(8).Text = ""

                    btnFXX(9).Text = "前へ"
                    btnFXX(10).Text = ""
                    btnFXX(11).Text = ""
                    btnFXX(12).Text = "戻る"

                    '使用許可(初期)
                    btnFXX(1).Enabled = True
                    btnFXX(2).Enabled = False
                    btnFXX(3).Enabled = False
                    btnFXX(4).Enabled = False

                    btnFXX(5).Enabled = False
                    btnFXX(6).Enabled = False
                    btnFXX(7).Enabled = False
                    btnFXX(8).Enabled = False

                    btnFXX(9).Enabled = True
                    btnFXX(10).Enabled = False
                    btnFXX(11).Enabled = False
                    btnFXX(12).Enabled = True
                Case 3 '【棚卸確定】
                    '表示ﾃｷｽﾄ
                    btnFXX(1).Text = "棚卸リスト発行"
                    btnFXX(2).Text = ""
                    btnFXX(3).Text = ""
                    btnFXX(4).Text = "棚卸取消"

                    btnFXX(5).Text = "表示"
                    btnFXX(6).Text = ""
                    btnFXX(7).Text = ""
                    btnFXX(8).Text = "残作業一覧"

                    btnFXX(9).Text = ""
                    btnFXX(10).Text = ""
                    btnFXX(11).Text = ""
                    btnFXX(12).Text = "戻る"

                    '使用許可(初期)
                    btnFXX(1).Enabled = True
                    btnFXX(2).Enabled = False
                    btnFXX(3).Enabled = False
                    btnFXX(4).Enabled = True

                    btnFXX(5).Enabled = True
                    btnFXX(6).Enabled = False
                    btnFXX(7).Enabled = False
                    btnFXX(8).Enabled = True

                    btnFXX(9).Enabled = False
                    btnFXX(10).Enabled = False
                    btnFXX(11).Enabled = False
                    btnFXX(12).Enabled = True
                    'Case 4 '棚卸確定警告
                    '    '表示ﾃｷｽﾄ
                    '    btnFXX(1).Text = "棚卸差異リスト発行"
                    '    btnFXX(2).Text = ""
                    '    btnFXX(3).Text = ""
                    '    btnFXX(4).Text = ""

                    '    btnFXX(5).Text = ""
                    '    btnFXX(6).Text = ""
                    '    btnFXX(7).Text = "在庫更新"
                    '    btnFXX(8).Text = ""

                    '    btnFXX(9).Text = ""
                    '    btnFXX(10).Text = ""
                    '    btnFXX(11).Text = ""
                    '    btnFXX(12).Text = "戻る"

                    '    '使用許可(初期)
                    '    btnFXX(1).Enabled = rb棚卸差異リスト発行.Checked
                    '    btnFXX(2).Enabled = False
                    '    btnFXX(3).Enabled = False
                    '    btnFXX(4).Enabled = False

                    '    btnFXX(5).Enabled = False
                    '    btnFXX(6).Enabled = False
                    '    btnFXX(7).Enabled = rb在庫更新.Checked
                    '    btnFXX(8).Enabled = False

                    '    btnFXX(9).Enabled = False
                    '    btnFXX(10).Enabled = False
                    '    btnFXX(11).Enabled = False
                    '    btnFXX(12).Enabled = True

                Case 4 '自動倉庫差異出庫
                    '表示ﾃｷｽﾄ
                    btnFXX(1).Text = ""
                    btnFXX(2).Text = "設定"
                    btnFXX(3).Text = ""
                    btnFXX(4).Text = ""

                    btnFXX(5).Text = "表示"
                    btnFXX(6).Text = ""
                    btnFXX(7).Text = ""
                    btnFXX(8).Text = "全選択/" & vbCrLf & "解除"

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
                    btnFXX(6).Enabled = False
                    btnFXX(7).Enabled = False
                    btnFXX(8).Enabled = True

                    btnFXX(9).Enabled = False
                    btnFXX(10).Enabled = False
                    btnFXX(11).Enabled = False
                    btnFXX(12).Enabled = True
                Case Else
            End Select


            '表示ﾃｷｽﾄ空白は使用許可＝False
            For iLoop = 1 To UBound(btnFXX) Step 1
                If btnFXX(iLoop).Text.Length <= 0 Then
                    btnFXX(iLoop).Enabled = False
                End If
            Next

            '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

            ''列固定
            'dgvYotei.Columns(3).Frozen = True

            ''バックカラー初期化
            'dgvYotei.DefaultCellStyle.BackColor = Color.White
            'dgvYotei.DefaultCellStyle.SelectionBackColor = Color.White
            'dgvYotei.DefaultCellStyle.ForeColor = Color.Black
            'dgvYotei.DefaultCellStyle.SelectionForeColor = Color.Black


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

            '対象平置き在庫【棚】
            dgvHiraokiTana.Rows.Clear()

            For iloop = 0 To 9
                iRow = dgvHiraokiTana.Rows.Add()

                dgvHiraokiTana(0, iRow).Value = "11-11-11-11"  '開始棚No
                dgvHiraokiTana(1, iRow).Value = "～"           '～
                dgvHiraokiTana(2, iRow).Value = "99-99-99-99"  '終了棚No

            Next

            '対象平置き在庫【商品】
            dgvHiraokiHin.Rows.Clear()

            For iloop = 0 To 9
                iRow = dgvHiraokiHin.Rows.Add()

                dgvHiraokiHin(0, iRow).Value = "1234567890123456"  '共通商品コード
                dgvHiraokiHin(1, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"           '商品名
                dgvHiraokiHin(2, iRow).Value = "規格あいうえおかきくけこ"  '規格

            Next


            '対象自動倉庫在庫【棚】
            dgvAutoTana.Rows.Clear()

            For iloop = 0 To 9
                iRow = dgvAutoTana.Rows.Add()

                dgvAutoTana(0, iRow).Value = "11-11-11-11"  '開始棚No
                dgvAutoTana(1, iRow).Value = "～"           '～
                dgvAutoTana(2, iRow).Value = "99-99-99-99"  '終了棚No

            Next

            '対象自動倉庫在庫【商品】
            dgvAutoHin.Rows.Clear()

            For iloop = 0 To 9
                iRow = dgvAutoHin.Rows.Add()

                dgvAutoHin(0, iRow).Value = "1234567890123456"  '共通商品コード
                dgvAutoHin(1, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"           '商品名
                dgvAutoHin(2, iRow).Value = "規格あいうえおかきくけこ"  '規格

            Next

            '棚卸確定
            dgvKakutei.Rows.Clear()

            For iloop = 0 To 9
                iRow = dgvKakutei.Rows.Add()

                dgvKakutei(0, iRow).Value = "11-11-11-11"       '棚No
                dgvKakutei(1, iRow).Value = "1234567890123456"       '共通商品コード
                dgvKakutei(2, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvKakutei(3, iRow).Value = "規格あいうえおかきくけこ"   '規格

                dgvKakutei(4, iRow).Value = "2015/06/30"     '賞味期限
                dgvKakutei(5, iRow).Value = "1234567890"     'ﾛｯﾄNo
                dgvKakutei(6, iRow).Value = "2015/06/30"     '初回入荷日
                dgvKakutei(7, iRow).Value = "12345678.99"     '在庫数

                dgvKakutei(8, iRow).Value = "未検査品"     '品質区分
                dgvKakutei(9, iRow).Value = "その他"     '荷主区分

            Next

            '自動倉庫差異出庫
            dgvAutoSyuko.Rows.Clear()

            For iloop = 0 To 9
                iRow = dgvAutoSyuko.Rows.Add()

                dgvAutoSyuko(0, iRow).Value = False               '選択
                dgvAutoSyuko(1, iRow).Value = "11-11-11-11"       '棚No
                dgvAutoSyuko(2, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvAutoSyuko(3, iRow).Value = "規格あいうえおかきくけこ"   '規格

                dgvAutoSyuko(4, iRow).Value = "12345678.99"     '在庫数
                dgvAutoSyuko(5, iRow).Value = "12345678.99"     '棚卸数

                dgvAutoSyuko(6, iRow).Value = "2015/06/30"     '賞味期限
                dgvAutoSyuko(7, iRow).Value = "1234567890"     'ﾛｯﾄNo

                dgvAutoSyuko(8, iRow).Value = "2015/06/30"     '入荷日
                dgvAutoSyuko(9, iRow).Value = "2015/06/30"     '初回入荷日

                dgvAutoSyuko(10, iRow).Value = "未検査品"     '品質区分
                dgvAutoSyuko(11, iRow).Value = "その他"     '荷主区分
                dgvAutoSyuko(12, iRow).Value = "1234567890123456"       '共通商品コード

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
