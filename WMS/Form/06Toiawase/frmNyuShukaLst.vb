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


Public Class frmNyuShukaLst


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

            'タブコントロールの描画モードをオーナードローに変更
            TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed

            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.MaximumSize = New System.Drawing.Size(1500, 1500)

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
        Dim frmEdit As New frmNyuShukaLstPrt

        Try

            For intCnt = 1 To 12
                btnEnb(intCnt) = btnFXX(intCnt).Enabled
                btnFXX(intCnt).Enabled = False
            Next intCnt

            Select Case iIndex
                Case 1
                    ''F1 入出荷実績リスト印刷

                    ''共通商品コード一覧呼び出し
                    'frmEdit.ShowDialog()

                Case 2
                Case 3
                Case 4
                Case 5
                    'F5 表示
                Case 6
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
    '共通商品コード一覧_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt共通商品コード一覧_Click(sender As Object, e As EventArgs) Handles bt共通商品コード一覧.Click
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
    Private Sub bt表示_Click(sender As Object, e As EventArgs)
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
            btnFXX(1).Text = "入出荷実績リスト発行"
            btnFXX(2).Text = ""
            btnFXX(3).Text = ""
            btnFXX(4).Text = ""

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = "入力クリア"
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""

            btnFXX(9).Text = "CSV出力"
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = True
            btnFXX(2).Enabled = False
            btnFXX(3).Enabled = False
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

            lblTitle.Text = "入出荷実績問合せ"

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
            dgvZaiko.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvZaiko.Rows.Add()

                dgvZaiko(0, iRow).Value = "2015/05/01 23:59:59"       '日時
                dgvZaiko(1, iRow).Value = "出庫"     '入出荷区分
                dgvZaiko(2, iRow).Value = "計画"     '作業内容
                dgvZaiko(3, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvZaiko(4, iRow).Value = "○"       '予約区分
                dgvZaiko(5, iRow).Value = "2015/06/30"   '賞味期限
                dgvZaiko(6, iRow).Value = "1234567890"       'ロットNo
                dgvZaiko(7, iRow).Value = "2015/06/30"   '初回入荷日
                dgvZaiko(8, iRow).Value = "12,345,678.99"       '入荷数
                dgvZaiko(9, iRow).Value = "12,345,678.99"       '出荷数
                dgvZaiko(10, iRow).Value = "AFC本社"       '格納倉庫
                dgvZaiko(11, iRow).Value = "11-11-11-11"       '棚No
                dgvZaiko(12, iRow).Value = "1234567890"   '予定指示No
                dgvZaiko(13, iRow).Value = "1234567890"   '製造指図No
                dgvZaiko(14, iRow).Value = "1234567890123456"      '共通商品コード
                dgvZaiko(15, iRow).Value = "1234567890123"   '入出荷先コード
                dgvZaiko(16, iRow).Value = "あいうえおかきくけこさしすせそ"     '入出荷先名
                dgvZaiko(17, iRow).Value = "未検査品"       '品質区分
                dgvZaiko(18, iRow).Value = "その他"       '荷主区分
                dgvZaiko(19, iRow).Value = "作業者名作業"      '入荷設定者
                dgvZaiko(20, iRow).Value = "作業者名作業"      '入荷完了者
                dgvZaiko(21, iRow).Value = "作業者名作業"      '出荷設定者
                dgvZaiko(22, iRow).Value = "作業者名作業"      'ピック作業者
                dgvZaiko(23, iRow).Value = "作業者名作業"      '検品作業者
                dgvZaiko(24, iRow).Value = "作業者名作業"      '荷合せ作業者
                dgvZaiko(25, iRow).Value = "1234567890123456"      '関連会社コード
                dgvZaiko(26, iRow).Value = "規格あいおうえおかきくけこ"   '規格
                dgvZaiko(27, iRow).Value = "99"   '事由ｺｰﾄﾞ
                dgvZaiko(28, iRow).Value = "事由名称事由名称事由名称事由名"   '事由名称
            Next


            dgvHojyuIdo.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvHojyuIdo.Rows.Add()

                dgvHojyuIdo(0, iRow).Value = "2015/05/01 23:59:59"       '日時
                dgvHojyuIdo(1, iRow).Value = "補充"     '入出荷区分
                dgvHojyuIdo(2, iRow).Value = "商品名あいうえおかきくけこさしすせそたちつてとなにぬねのはひ"     '商品名
                dgvHojyuIdo(3, iRow).Value = "○"       '予約区分
                dgvHojyuIdo(4, iRow).Value = "2015/06/30"   '賞味期限
                dgvHojyuIdo(5, iRow).Value = "1234567890"       'ロットNo
                dgvHojyuIdo(6, iRow).Value = "2015/06/30"   '初回入荷日
                dgvHojyuIdo(7, iRow).Value = "12,345,678.99"       '補充移動数
                dgvHojyuIdo(8, iRow).Value = "11-11-11-11"       '作業元棚No
                dgvHojyuIdo(9, iRow).Value = "22-11-11-11"   '作業先棚No
                dgvHojyuIdo(10, iRow).Value = "1234567890"   '製造指図No
                dgvHojyuIdo(11, iRow).Value = "1234567890123456"      '共通商品コード
                dgvHojyuIdo(12, iRow).Value = "未検査品"       '品質区分
                dgvHojyuIdo(13, iRow).Value = "その他"       '荷主区分
                dgvHojyuIdo(14, iRow).Value = "作業者名作業"      '設定者
                dgvHojyuIdo(15, iRow).Value = "作業者名作業"      '元作業者
                dgvHojyuIdo(16, iRow).Value = "作業者名作業"      '先作業者
                dgvHojyuIdo(17, iRow).Value = "1234567890123456"      '関連会社コード
                dgvHojyuIdo(18, iRow).Value = "規格あいおうえおかきくけこ"   '規格
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
