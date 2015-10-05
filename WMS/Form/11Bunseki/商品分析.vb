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


Public Class 商品分析


#Region "イベント-フォーム-"
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sMsg As String = ""
        Try

            '共通項目初期化
            Call InitCommon(True)


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
        Dim frmEdit As New 商品分析リスト発行

        Try

            For intCnt = 1 To 12
                btnEnb(intCnt) = btnFXX(intCnt).Enabled
                btnFXX(intCnt).Enabled = False
            Next intCnt

            Select Case iIndex
                Case 1
                    '分析リスト発行画面呼び出し
                    frmEdit.ShowDialog()

                Case 2
                    'F2 設定

                Case 3
                Case 4
                Case 5
                    'F5 再表示

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

    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        Try

            InitCommon()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub


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


#End Region


#Region "関数"
    '標準フォームのオブジェクト設定
    Private Sub InitCommon(Optional ByVal bE As Boolean = False)
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

            Select Case TabControl1.SelectedIndex
                Case 0 'システム稼動設定
                    btnFXX(1).Text = ""
                    btnFXX(2).Text = "設定"
                    btnFXX(3).Text = ""
                    btnFXX(4).Text = ""

                    btnFXX(5).Text = "再表示"
                    btnFXX(6).Text = ""
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
                    btnFXX(6).Enabled = False
                    btnFXX(7).Enabled = False
                    btnFXX(8).Enabled = False

                    btnFXX(9).Enabled = False
                    btnFXX(10).Enabled = False
                    btnFXX(11).Enabled = False
                    btnFXX(12).Enabled = True
                Case 1 'ステーション初期設定
                    btnFXX(1).Text = "分析リスト発行"
                    btnFXX(2).Text = "設定"
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
                    btnFXX(2).Enabled = True
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

            If bE Then
                'イベント割付
                For i As Integer = 1 To 12
                    AddHandler btnFXX(i).Click, AddressOf btnFun_Click
                Next
            End If


            '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

            ''列固定
            'dgvYotei.Columns(3).Frozen = True

            ''バックカラー初期化
            'dgvYotei.DefaultCellStyle.BackColor = Color.White
            'dgvYotei.DefaultCellStyle.SelectionBackColor = Color.White
            'dgvYotei.DefaultCellStyle.ForeColor = Color.Black
            'dgvYotei.DefaultCellStyle.SelectionForeColor = Color.Black

            lblTitle.Text = "商品分析"

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

            'ＡＢＣ分析
            dgvSt.Rows.Clear()

            For iloop = 0 To 9
                iRow = dgvSt.Rows.Add()

                dgvSt(0, iRow).Value = "商品名称あいうえおかきくけこさしすせそたちつてとなにぬねのは"     '商品名
                dgvSt(1, iRow).Value = "規格あいうえおかきくけこ"   '規格
                dgvSt(2, iRow).Value = "ZZZ,ZZ9"        '出荷実績数
                dgvSt(3, iRow).Value = "あいうえお"     '分析値
                dgvSt(4, iRow).Value = "ZZZ,ZZ9"        '前回出荷実績数
                dgvSt(5, iRow).Value = "あいうえお"     '前回分析値
                dgvSt(6, iRow).Value = "あいうえお"     '変動
                dgvSt(7, iRow).Value = "あいうえお"     '割付棚No
                dgvSt(8, iRow).Value = "1234567890123456"     '共通商品コード

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
