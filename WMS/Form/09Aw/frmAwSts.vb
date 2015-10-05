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


Public Class frmAwSts


#Region "イベント-フォーム-"
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sMsg As String = ""
        Try

            '共通項目初期化
            Call InitCommon()


            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.MaximumSize = New System.Drawing.Size(1500, 1500)


            '表示
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
                Case 4
                Case 5
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
    Private Sub bt共通商品コード一覧_Click(sender As Object, e As EventArgs)
        Dim frmEdit As New frmHinSel
        Try

            '共通商品コード一覧呼び出し
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '補充作業DGVダブルクリック
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub dgvHoju_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCS1_Left_Hoju.CellDoubleClick, _
                                                                                                  dgvCS1_Right_Hoju.CellDoubleClick, _
                                                                                                  dgvCS2_Left_Hoju.CellDoubleClick, _
                                                                                                  dgvCS2_Right_Hoju.CellDoubleClick, _
                                                                                                  dgvFS1_Hoju.CellDoubleClick
        Dim frmEdit As New frmAwHoju
        Try

            'ヘッダ行は処理を抜ける
            If e.RowIndex < 0 Then
                Exit Try
            End If

            '補充作業表示画面呼び出し
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '移動作業ボタンクリック
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt移動作業_Click(sender As Object, e As EventArgs) Handles btCS1_Left移動作業.Click, _
                                                                                   btCS1_Right移動作業.Click, _
                                                                                   btCS2_Left移動作業.Click, _
                                                                                   btCS2_Right移動作業.Click, _
                                                                                   btFS1_移動作業.Click
        Dim frmEdit As New frmAwIdo
        Try

            '移動作業表示画面呼び出し()
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
        End Try
    End Sub


    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '計画外出庫作業DGVダブルクリック
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub dgvSyuko_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCS1_Left_Syuko.CellDoubleClick, _
                                                                                                  dgvCS1_Right_Syuko.CellDoubleClick, _
                                                                                                  dgvCS2_Left_Syuko.CellDoubleClick, _
                                                                                                  dgvCS2_Right_Syuko.CellDoubleClick, _
                                                                                                  dgvFS1_Syuko.CellDoubleClick
        Dim frmEdit As New frmAwKeikakuGaiShuko
        Try

            'ヘッダ行は処理を抜ける
            If e.RowIndex < 0 Then
                Exit Try
            End If

            '補充作業表示画面呼び出し
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
        End Try
    End Sub


    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '移動作業ボタンクリック
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt棚卸作業_Click(sender As Object, e As EventArgs) Handles btCS1_Left棚卸作業.Click, _
                                                                                   btCS1_Right棚卸作業.Click, _
                                                                                   btCS2_Left棚卸作業.Click, _
                                                                                   btCS2_Right棚卸作業.Click, _
                                                                                   btFS1_棚卸作業.Click
        Dim frmEdit As New frmAwTanaOrosi
        Try

            '移動作業表示画面呼び出し()
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
        End Try
    End Sub


    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '積増入庫作業ボタンクリック
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt積増入庫作業_Click(sender As Object, e As EventArgs) Handles btCS1_Left積増入庫作業.Click, _
                                                                                   btCS1_Right積増入庫作業.Click, _
                                                                                   btCS2_Left積増入庫作業.Click, _
                                                                                   btCS2_Right積増入庫作業.Click, _
                                                                                   btFS1_積増入庫作業.Click
        Dim frmEdit As New frmAwTumiMasiNyuko
        Try

            '移動作業表示画面呼び出し()
            frmEdit.ShowDialog()

        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
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
            btnFXX(3).Text = ""
            btnFXX(4).Text = ""

            btnFXX(5).Text = ""
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

            btnFXX(5).Enabled = False
            btnFXX(6).Enabled = False
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

            lblTitle.Text = "自動倉庫作業表示"

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

            '＝＝　CS1　＝＝＝＝＝＝＝

            'CS1 補充作業【左】
            dgvCS1_Left_Hoju.Rows.Clear()

            For iloop = 0 To 5
                iRow = dgvCS1_Left_Hoju.Rows.Add()
                dgvCS1_Left_Hoju(0, iRow).Value = "11-11-11-11"       '補充先エリア
            Next

            'CS1 補充作業【右】
            dgvCS1_Right_Hoju.Rows.Clear()

            For iloop = 0 To 5
                iRow = dgvCS1_Right_Hoju.Rows.Add()
                dgvCS1_Right_Hoju(0, iRow).Value = "22-22-22-22"       '補充先エリア
            Next

            'CS1 計画外出庫作業【左】
            dgvCS1_Left_Syuko.Rows.Clear()

            For iloop = 0 To 5
                iRow = dgvCS1_Left_Syuko.Rows.Add()
                dgvCS1_Left_Syuko(0, iRow).Value = "1234567890"       '出荷指示No
            Next

            'CS1 計画外出庫作業【右】
            dgvCS1_Right_Syuko.Rows.Clear()

            For iloop = 0 To 5
                iRow = dgvCS1_Right_Syuko.Rows.Add()
                dgvCS1_Right_Syuko(0, iRow).Value = "1234567890"       '出荷指示No
            Next


            '＝＝　CS2　＝＝＝＝＝＝＝

            'CS2 補充作業【左】
            dgvCS2_Left_Hoju.Rows.Clear()

            For iloop = 0 To 5
                iRow = dgvCS2_Left_Hoju.Rows.Add()
                dgvCS2_Left_Hoju(0, iRow).Value = "33-33-33-33"       '補充先エリア
            Next

            'CS2 補充作業【右】
            dgvCS2_Right_Hoju.Rows.Clear()

            For iloop = 0 To 5
                iRow = dgvCS2_Right_Hoju.Rows.Add()
                dgvCS2_Right_Hoju(0, iRow).Value = "44-44-44-44"       '補充先エリア
            Next

            'CS2 計画外出庫作業【左】
            dgvCS2_Left_Syuko.Rows.Clear()

            For iloop = 0 To 5
                iRow = dgvCS2_Left_Syuko.Rows.Add()
                dgvCS2_Left_Syuko(0, iRow).Value = "1234567890"       '出荷指示No
            Next

            'CS2 計画外出庫作業【右】
            dgvCS2_Right_Syuko.Rows.Clear()

            For iloop = 0 To 5
                iRow = dgvCS2_Right_Syuko.Rows.Add()
                dgvCS2_Right_Syuko(0, iRow).Value = "1234567890"       '出荷指示No
            Next


            '＝＝　FS1　＝＝＝＝＝＝＝

            'FS1 補充作業【左】
            dgvFS1_Hoju.Rows.Clear()

            For iloop = 0 To 5
                iRow = dgvFS1_Hoju.Rows.Add()
                dgvFS1_Hoju(0, iRow).Value = "55-55-55-55"       '補充先エリア
            Next


            'FS1 計画外出庫作業【左】
            dgvFS1_Syuko.Rows.Clear()

            For iloop = 0 To 5
                iRow = dgvFS1_Syuko.Rows.Add()
                dgvFS1_Syuko(0, iRow).Value = "1234567890"       '出荷指示No
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
