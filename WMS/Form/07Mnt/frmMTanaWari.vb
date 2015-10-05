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


Public Class frmMTanaWari


#Region "イベント-フォーム-"
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sMsg As String = ""
        Try




            '共通項目初期化
            Call InitCommon(True)


            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.MaximumSize = New System.Drawing.Size(1500, 1500)

            '仮データセット
            Call ShowData()

            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.MaximumSize = New System.Drawing.Size(1500, 1500)

            'タブコントロールの描画モードをオーナードローに変更
            tbcTanaWari.DrawMode = TabDrawMode.OwnerDrawFixed

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
        Dim frmEdit As New frmMTanaWariLstPrt

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
                    'F3 自動割付
                Case 4
                Case 5
                    'F5 表示
                Case 6
                    'F6 取消
                Case 7
                    'F7 入力
                Case 8
                    'F8 全選択
                Case 9
                Case 10
                    'F10 棚割付一覧リスト発行
                    frmEdit.ShowDialog()
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
    '共通商品コード一覧_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub btnKyotuHinCd_Click(sender As Object, e As EventArgs) Handles btnKyotuHinCd1.Click, btnKyotuHinCd2.Click, btnKyotuHinCd3.Click
        Dim frmEdit As New frmHinSel
        Try

            '共通商品コード一覧呼び出し
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

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

    'カレントタブが選択されたら
    'Private Sub tbcTanaWari_TabIndexChanged(sender As Object, e As EventArgs) Handles tbcTanaWari.TabIndexChanged

    '    'グリッド検索
    '    ShowData()

    '    'ファンクションボタン
    '    InitCommon()

    'End Sub

    Private Sub tbcTanaWari_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tbcTanaWari.Selecting

        'グリッド検索
        ShowData()

        'ファンクションボタン
        InitCommon()

    End Sub



#End Region


#Region "関数"
    '標準フォームのオブジェクト設定
    Private Sub InitCommon(Optional ByVal bInit As Boolean = False)
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


            '現在ページに合わせてグリッド表示
            Select Case tbcTanaWari.SelectedIndex

                Case 0
                    '【設定】Page
                    'ファンクションボタン_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
                    '表示ﾃｷｽﾄ
                    btnFXX(1).Text = ""
                    btnFXX(2).Text = "設定"
                    btnFXX(3).Text = "自動割付"
                    btnFXX(4).Text = ""

                    btnFXX(5).Text = "表示"
                    btnFXX(6).Text = "入力ｸﾘｱ"
                    btnFXX(7).Text = "入力"
                    btnFXX(8).Text = "選択"

                    btnFXX(9).Text = ""
                    btnFXX(10).Text = "棚割付一覧リスト発行"
                    btnFXX(11).Text = ""
                    btnFXX(12).Text = "戻る"

                    '使用許可(初期)
                    btnFXX(1).Enabled = False
                    btnFXX(2).Enabled = True
                    btnFXX(3).Enabled = True
                    btnFXX(4).Enabled = False

                    btnFXX(5).Enabled = True
                    btnFXX(6).Enabled = True
                    btnFXX(7).Enabled = True
                    btnFXX(8).Enabled = True

                    btnFXX(9).Enabled = False
                    btnFXX(10).Enabled = True
                    btnFXX(11).Enabled = False
                    btnFXX(12).Enabled = True
                Case 1
                    '【解除】Page
                    'ファンクションボタン_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
                    '表示ﾃｷｽﾄ
                    btnFXX(1).Text = ""
                    btnFXX(2).Text = "設定"
                    btnFXX(3).Text = ""
                    btnFXX(4).Text = ""

                    btnFXX(5).Text = "表示"
                    btnFXX(6).Text = "入力ｸﾘｱ"
                    btnFXX(7).Text = ""
                    btnFXX(8).Text = "全選択"

                    btnFXX(9).Text = ""
                    btnFXX(10).Text = "棚割付一覧リスト発行"
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
                    btnFXX(8).Enabled = True

                    btnFXX(9).Enabled = False
                    btnFXX(10).Enabled = True
                    btnFXX(11).Enabled = False
                    btnFXX(12).Enabled = True
                Case 2
                    '【変更】Page
                    'ファンクションボタン_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
                    '表示ﾃｷｽﾄ
                    btnFXX(1).Text = ""
                    btnFXX(2).Text = "設定"
                    btnFXX(3).Text = "入力"
                    btnFXX(4).Text = "削除"

                    btnFXX(5).Text = ""
                    btnFXX(6).Text = "入力ｸﾘｱ"
                    btnFXX(7).Text = ""
                    btnFXX(8).Text = ""

                    btnFXX(9).Text = ""
                    btnFXX(10).Text = "棚割付一覧リスト発行"
                    btnFXX(11).Text = ""
                    btnFXX(12).Text = "戻る"

                    '使用許可(初期)
                    btnFXX(1).Enabled = False
                    btnFXX(2).Enabled = True
                    btnFXX(3).Enabled = True
                    btnFXX(4).Enabled = True

                    btnFXX(5).Enabled = False
                    btnFXX(6).Enabled = True
                    btnFXX(7).Enabled = False
                    btnFXX(8).Enabled = False

                    btnFXX(9).Enabled = False
                    btnFXX(10).Enabled = True
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

            'イベント割付
            For i As Integer = 1 To 12
                'イベント割り当ての重複回避
                If bInit Then AddHandler btnFXX(i).Click, AddressOf btnFun_Click
            Next

            '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

            ''列固定
            'dgvYotei.Columns(3).Frozen = True

            ''バックカラー初期化
            'dgvYotei.DefaultCellStyle.BackColor = Color.White
            'dgvYotei.DefaultCellStyle.SelectionBackColor = Color.White
            'dgvYotei.DefaultCellStyle.ForeColor = Color.Black
            'dgvYotei.DefaultCellStyle.SelectionForeColor = Color.Black

            lblTitle.Text = "棚割付メンテナンス"

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

            If tbcTanaWari.SelectedIndex = 0 Then


            End If

            '現在ページに合わせてグリッド表示
            Select Case tbcTanaWari.SelectedIndex

                Case 0
                    '【設定】Page

                    '自動倉庫
                    dgvAuto.Rows.Clear()

                    For iloop = 0 To 9
                        iRow = dgvAuto.Rows.Add()

                        dgvAuto(0, iRow).Value = "11-11-11-11"      '開始棚No
                        dgvAuto(1, iRow).Value = "99-99-99-99"      '終了棚No

                    Next

                    '分析
                    dgvBunseki.Rows.Clear()

                    For iloop = 0 To 9
                        iRow = dgvBunseki.Rows.Add()

                        dgvBunseki(0, iRow).Value = False                '選択
                        dgvBunseki(1, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ" '商品名
                        dgvBunseki(2, iRow).Value = "規格あいうえおかきくけこ"           '規格
                        dgvBunseki(3, iRow).Value = "99-99-99-99"      '未割付棚No（入力可）
                        dgvBunseki(4, iRow).Value = "99-99-99-99"      '割付棚No
                        dgvBunseki(5, iRow).Value = "1234567890123456" '共通商品コード

                    Next

                Case 1
                    '【解除】Page

                    '
                    dgvKaijo.Rows.Clear()

                    For iloop = 0 To 9
                        iRow = dgvKaijo.Rows.Add()

                        dgvKaijo(0, iRow).Value = False                '選択
                        dgvKaijo(1, iRow).Value = "99-99-99-99"      '割付棚No
                        dgvKaijo(2, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ" '商品名
                        dgvKaijo(3, iRow).Value = "規格あいうえおかきくけこ"           '規格
                        dgvKaijo(4, iRow).Value = "1234567890123456" '共通商品コード

                    Next

                Case 2
                    '【変更】Page

                    'DGV左上
                    dgvHenkou_1.Rows.Clear()

                    For iloop = 0 To 9
                        iRow = dgvHenkou_1.Rows.Add()

                        dgvHenkou_1(0, iRow).Value = "99-99-99-99"      '割付棚No
                        dgvHenkou_1(1, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ" '商品名
                        dgvHenkou_1(2, iRow).Value = "12,345,678.99"    '在庫数

                        dgvHenkou_1(3, iRow).Value = "1234567890123456" '共通商品コード
                        dgvHenkou_1(4, iRow).Value = "規格あいうえおかきくけこ"           '規格

                    Next

                    'DGV右上
                    dgvHenkou_2.Rows.Clear()

                    For iloop = 0 To 9
                        iRow = dgvHenkou_2.Rows.Add()

                        dgvHenkou_2(0, iRow).Value = "99-99-99-99"      '割付棚No
                        dgvHenkou_2(1, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ" '商品名
                        dgvHenkou_2(2, iRow).Value = "12,345,678.99"    '在庫数

                        dgvHenkou_2(3, iRow).Value = "1234567890123456" '共通商品コード
                        dgvHenkou_2(4, iRow).Value = "規格あいうえおかきくけこ"           '規格

                    Next

                    'DGV下
                    dgvHenkou_3.Rows.Clear()

                    For iloop = 0 To 9
                        iRow = dgvHenkou_3.Rows.Add()

                        dgvHenkou_3(0, iRow).Value = "99-99-99-99"      '移動元棚No
                        dgvHenkou_3(1, iRow).Value = "商品名あいうえおかきくけこさしす" '移動元商品名
                        dgvHenkou_3(2, iRow).Value = "あいおうえおかきくけこ"           '移動元規格

                        dgvHenkou_3(3, iRow).Value = "99-99-99-99"      '移動先棚No
                        dgvHenkou_3(4, iRow).Value = "商品名あいうえおかきくけこさしす" '移動先商品名
                        dgvHenkou_3(5, iRow).Value = "あいおうえおかきくけこ"           '移動先規格

                    Next
                Case Else
            End Select


        Catch oraErr As Oracle.DataAccess.Client.OracleException
            Call OraErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSql)
        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

        Finally


        End Try
    End Sub

    'タブ描画
    Private Sub TabControl1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles tbcTanaWari.DrawItem
        '変数定義
        Dim backBrush As SolidBrush
        Dim foreBrush As SolidBrush

        '選択中のタブを判定
        If tbcTanaWari.SelectedIndex = e.Index Then
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
        e.Graphics.DrawString(tbcTanaWari.TabPages(e.Index).Text, tbcTanaWari.Font, foreBrush, rect, format)
    End Sub

#End Region

End Class
