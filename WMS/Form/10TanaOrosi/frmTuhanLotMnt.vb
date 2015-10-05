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


Public Class frmTuhanLotMnt


#Region "イベント-フォーム-"
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sMsg As String = ""
        Try

            '共通項目初期化
            Call InitCommon()


            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.MaximumSize = New System.Drawing.Size(1500, 1500)


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

        Try

            For intCnt = 1 To 12
                btnEnb(intCnt) = btnFXX(intCnt).Enabled
                btnFXX(intCnt).Enabled = False
            Next intCnt

            Select Case iIndex
                Case 1
                Case 2
                Case 3
                    'F3 棚範囲入力
                Case 4
                    'F4 棚削除
                Case 5
                Case 6
                Case 7
                Case 8
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
    'bt調査確定_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt調査確定_Click(sender As Object, e As EventArgs) Handles bt調査確定.Click
        Dim frmEdit As New frmZaiSaiWarning
        Try

            '調査確定警告呼び出し
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
            btnFXX(2).Text = ""
            btnFXX(3).Text = "棚範囲入力"
            btnFXX(4).Text = "棚削除"

            btnFXX(5).Text = ""
            btnFXX(6).Text = ""
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""

            btnFXX(9).Text = ""
            btnFXX(10).Text = "次へ"
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = False
            btnFXX(2).Enabled = False
            btnFXX(3).Enabled = True
            btnFXX(4).Enabled = True

            btnFXX(5).Enabled = False
            btnFXX(6).Enabled = False
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

            lblTitle.Text = "通販ロット調整作業"

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

                Case 0 '【ロット調査】
                    '表示ﾃｷｽﾄ
                    btnFXX(1).Text = ""
                    btnFXX(2).Text = ""
                    btnFXX(3).Text = "棚範囲入力"
                    btnFXX(4).Text = "棚削除"

                    btnFXX(5).Text = ""
                    btnFXX(6).Text = ""
                    btnFXX(7).Text = ""
                    btnFXX(8).Text = ""

                    btnFXX(9).Text = ""
                    btnFXX(10).Text = "次へ"
                    btnFXX(11).Text = ""
                    btnFXX(12).Text = "戻る"

                    '使用許可(初期)
                    btnFXX(1).Enabled = False
                    btnFXX(2).Enabled = False
                    btnFXX(3).Enabled = True
                    btnFXX(4).Enabled = True

                    btnFXX(5).Enabled = False
                    btnFXX(6).Enabled = False
                    btnFXX(7).Enabled = False
                    btnFXX(8).Enabled = False

                    btnFXX(9).Enabled = False
                    btnFXX(10).Enabled = True
                    btnFXX(11).Enabled = False
                    btnFXX(12).Enabled = True
                Case 1 '【調査確定】
                    '表示ﾃｷｽﾄ
                    btnFXX(1).Text = ""
                    btnFXX(2).Text = ""
                    btnFXX(3).Text = ""
                    btnFXX(4).Text = ""

                    btnFXX(5).Text = "表示"
                    btnFXX(6).Text = ""
                    btnFXX(7).Text = ""
                    btnFXX(8).Text = ""

                    btnFXX(9).Text = "前へ"
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
                Case 2 '【DPS均等化】
                    '表示ﾃｷｽﾄ
                    btnFXX(1).Text = "DPS均等化作業リスト発行"
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
                    btnFXX(1).Enabled = True
                    btnFXX(2).Enabled = False
                    btnFXX(3).Enabled = False
                    btnFXX(4).Enabled = False

                    btnFXX(5).Enabled = True
                    btnFXX(6).Enabled = False
                    btnFXX(7).Enabled = False
                    btnFXX(8).Enabled = False

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

            'ロット調査【棚】
            dgvTsuhanTana.Rows.Clear()

            For iloop = 0 To 9
                iRow = dgvTsuhanTana.Rows.Add()

                dgvTsuhanTana(0, iRow).Value = "11-11-11-11"  '開始棚No
                dgvTsuhanTana(1, iRow).Value = "～"           '～
                dgvTsuhanTana(2, iRow).Value = "99-99-99-99"  '終了棚No

            Next

            '調査確定【棚】
            dgvTsuhanKakutei.Rows.Clear()

            For iloop = 0 To 9
                iRow = dgvTsuhanKakutei.Rows.Add()

                dgvTsuhanKakutei(0, iRow).Value = "11-11-11-11"       '棚No
                dgvTsuhanKakutei(1, iRow).Value = "1234567890123456"       '共通商品コード
                dgvTsuhanKakutei(2, iRow).Value = "商品名あいうえおかきくけこさしす"     '商品名
                dgvTsuhanKakutei(3, iRow).Value = "規格あいうえおかきく"   '規格

                dgvTsuhanKakutei(4, iRow).Value = "12345678.99"     '在庫数
                dgvTsuhanKakutei(5, iRow).Value = "12345678.99"     '調査総数

            Next

            'DPS均等化【ﾗｲﾝ】
            dgvDSPKintou.Rows.Clear()

            For iloop = 0 To 9
                iRow = dgvDSPKintou.Rows.Add()

                dgvDSPKintou(0, iRow).Value = "11-11-11-11"       'ﾗｲﾝ1棚No
                dgvDSPKintou(1, iRow).Value = "11-11-11-11"       'ﾗｲﾝ2棚No
                dgvDSPKintou(2, iRow).Value = "1234567890123456"       '共通商品コード
                dgvDSPKintou(3, iRow).Value = "商品名あいうえおかきくけこさしす"     '商品名
                dgvDSPKintou(4, iRow).Value = "規格あいうえおかきく"   '規格

                dgvDSPKintou(5, iRow).Value = "12345678.99"     '移動必要数

            Next

        Catch oraErr As Oracle.DataAccess.Client.OracleException
            Call OraErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSql)
        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

        Finally


        End Try
    End Sub


#End Region

End Class
