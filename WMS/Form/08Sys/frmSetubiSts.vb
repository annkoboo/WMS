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


Public Class frmSetubiSts
    Private bVisible As Boolean = False

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

            ShowData(1, 99)
            ShowData(2, 99)

            Timer1.Enabled = True

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

        Dim frmEdit1 As New frmLogon
        Dim frmEdit2 As New frmDPMUserLst
        Dim frmEdit3 As New frmSetubiConn
        Dim frmEdit4 As New frmHyojikiTest

        Try

            For intCnt = 1 To 12
                btnEnb(intCnt) = btnFXX(intCnt).Enabled
                btnFXX(intCnt).Enabled = False
            Next intCnt

            Select Case iIndex
                Case 1
                    'F1 作業開始
                    frmEdit1.ShowDialog()
                Case 2
                    'F2 一斉起動
                    frmEdit1.ShowDialog()
                Case 3
                Case 4
                    'F4 接続/切離
                    frmEdit3.ShowDialog()
                Case 5
                Case 6
                Case 7
                    'F7 一斉停止
                    frmEdit1.ShowDialog()
                Case 8
                    'F8 作業終了
                    frmEdit1.ShowDialog()
                Case 9
                    'F9 DPS作業者登録
                    frmEdit2.ShowDialog()
                Case 10
                    'F10 表示器テスト
                    frmEdit4.ShowDialog()
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

            'InitCommon()
            If TabControl1.SelectedIndex = 0 Then
                '共通項目初期化
                Call InitCommon_Tab0()

            ElseIf TabControl1.SelectedIndex = 1 Then
                '共通項目初期化
                Call InitCommon_Tab1()
            ElseIf TabControl1.SelectedIndex = 2 Then
                '共通項目初期化
                Call InitCommon_Tab2()
            End If

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub


    '_/ 搬送設備_ｸﾘｯｸ
    Private Sub Click_Hansou(sender As Object, e As EventArgs)
        Dim sLbl_Name As Label
        Dim frmEdit_Ijyou As New frmErr

        Try
            sLbl_Name = CType(sender, Label)

            Select Case sLbl_Name.Name
                Case "lbl_ST1101"
                    ShowData(1, 2)
                Case "lbl_ST1201"
                    ShowData(1, 3)
                Case "lbl_ST1302"
                    ShowData(1, 1)
                Case "lbl_ST2201"
                    ShowData(1, 0)
                Case "lbl_CRN011", "lbl_STATE_011"
                    ShowData(1, 1)
                Case "lbl_CRN021", "lbl_STATE_021"
                    ShowData(1, 2)
                Case "lbl_DPS1001"
                    ShowData(2, 1)
                Case "lbl_ST2301"
                    '異常箇所ｸﾘｯｸ時
                    frmEdit_Ijyou.ShowDialog()
                Case Else
                    ShowData(1, 99)
                    ShowData(2, 99)
            End Select

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

            Select Case TabControl1.SelectedIndex
                Case 0 '自動倉庫
                    btnFXX(1).Text = "作業開始"
                    btnFXX(2).Text = "一斉起動"
                    btnFXX(3).Text = ""
                    btnFXX(4).Text = "接続/切離"

                    btnFXX(5).Text = "ﾌﾞｻﾞｰﾘｾｯﾄ"
                    btnFXX(6).Text = ""
                    btnFXX(7).Text = "一斉停止"
                    btnFXX(8).Text = "作業終了"

                    btnFXX(9).Text = ""
                    btnFXX(10).Text = ""
                    btnFXX(11).Text = ""
                    btnFXX(12).Text = "戻る"

                    '使用許可(初期)
                    btnFXX(1).Enabled = True
                    btnFXX(2).Enabled = True
                    btnFXX(3).Enabled = False
                    btnFXX(4).Enabled = True

                    btnFXX(5).Enabled = True
                    btnFXX(6).Enabled = False
                    btnFXX(7).Enabled = True
                    btnFXX(8).Enabled = True

                    btnFXX(9).Enabled = False
                    btnFXX(10).Enabled = False
                    btnFXX(11).Enabled = False
                    btnFXX(12).Enabled = True
                Case 1 'DPS
                    btnFXX(1).Text = "作業開始"
                    btnFXX(2).Text = "一斉起動"
                    btnFXX(3).Text = ""
                    btnFXX(4).Text = "接続/切離"

                    btnFXX(5).Text = "ﾌﾞｻﾞｰﾘｾｯﾄ"
                    btnFXX(6).Text = ""
                    btnFXX(7).Text = "一斉停止"
                    btnFXX(8).Text = "作業終了"

                    btnFXX(9).Text = "DPS作業者登録"
                    btnFXX(10).Text = "表示器" & vbCrLf & "テスト"
                    btnFXX(11).Text = ""
                    btnFXX(12).Text = "戻る"

                    '使用許可(初期)
                    btnFXX(1).Enabled = True
                    btnFXX(2).Enabled = True
                    btnFXX(3).Enabled = False
                    btnFXX(4).Enabled = True

                    btnFXX(5).Enabled = True
                    btnFXX(6).Enabled = False
                    btnFXX(7).Enabled = True
                    btnFXX(8).Enabled = True

                    btnFXX(9).Enabled = True
                    btnFXX(10).Enabled = True
                    btnFXX(11).Enabled = True
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

            lblTitle.Text = "稼働状態モニター"




            'システム状態表示_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
            '仕様書画面用ダミー表示_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
            Me.Label_SYSTEM_STATUS.Text = "作業開始中"
            Me.Label_SYSTEM_STATUS.ForeColor = Color.Lime
            Me.Label_JOUI_STATUS.Text = "切断中"
            Me.Label_JOUI_STATUS.ForeColor = Color.Red
            Me.Label_RMC01_STATUS.Text = "接続中"
            Me.Label_RMC01_STATUS.ForeColor = Color.Lime
            Me.Label_RMC02_STATUS.Text = "接続中"
            Me.Label_RMC02_STATUS.ForeColor = Color.Lime
            Me.Label_RMC03_STATUS.Text = "接続中"
            Me.Label_RMC03_STATUS.ForeColor = Color.Lime
            Me.Label_SAC01_STATUS.Text = "接続中"
            Me.Label_SAC01_STATUS.ForeColor = Color.Lime
            Me.Label_DPSMODE_STATUS.Text = "テストモード"
            Me.Label_DPSMODE_STATUS.ForeColor = Color.Orange
            Me.Label_DPS01_STATUS.Text = "接続中"
            Me.Label_DPS01_STATUS.ForeColor = Color.Lime
            Me.Label_DPS02_STATUS.Text = "切断中"
            Me.Label_DPS02_STATUS.ForeColor = Color.Red

            '_/ ﾗﾍﾞﾙ_ｸﾘｯｸ
            AddHandler lbl_ST1101.Click, AddressOf Click_Hansou
            AddHandler lbl_ST1201.Click, AddressOf Click_Hansou
            AddHandler lbl_ST1301.Click, AddressOf Click_Hansou
            AddHandler lbl_ST1102.Click, AddressOf Click_Hansou
            AddHandler lbl_ST1202.Click, AddressOf Click_Hansou
            AddHandler lbl_ST1302.Click, AddressOf Click_Hansou
            AddHandler lbl_ST2101.Click, AddressOf Click_Hansou
            AddHandler lbl_ST2201.Click, AddressOf Click_Hansou
            AddHandler lbl_ST2301.Click, AddressOf Click_Hansou
            AddHandler lbl_ST2102.Click, AddressOf Click_Hansou
            AddHandler lbl_ST2202.Click, AddressOf Click_Hansou
            AddHandler lbl_ST2302.Click, AddressOf Click_Hansou
            AddHandler lbl_ST3101.Click, AddressOf Click_Hansou
            AddHandler lbl_ST3201.Click, AddressOf Click_Hansou
            AddHandler lbl_ST3301.Click, AddressOf Click_Hansou
            AddHandler lbl_CRN011.Click, AddressOf Click_Hansou
            AddHandler lbl_STATE_011.Click, AddressOf Click_Hansou
            AddHandler lbl_CRN021.Click, AddressOf Click_Hansou
            AddHandler lbl_STATE_021.Click, AddressOf Click_Hansou
            AddHandler lbl_CRN031.Click, AddressOf Click_Hansou
            AddHandler lbl_STATE_031.Click, AddressOf Click_Hansou
            AddHandler lbl_DPS1001.Click, AddressOf Click_Hansou
            AddHandler lbl_DPS1002.Click, AddressOf Click_Hansou
            AddHandler lbl_DPS1003.Click, AddressOf Click_Hansou
            AddHandler lbl_DPS1004.Click, AddressOf Click_Hansou
            AddHandler lbl_DPS1005.Click, AddressOf Click_Hansou
            AddHandler lbl_DPS1006.Click, AddressOf Click_Hansou
            '_/ 搬送中
            Me.lbl_STATE_011.Text = "作業[出庫]　棚[02-06-05] → ST[1101]"
            Me.lbl_STATE_011.BackColor = Color.Yellow
            Me.lbl_STATE_021.Text = "作業[入庫]　ST[2201] → 棚[03-02-06]"
            Me.lbl_STATE_021.BackColor = Color.Yellow

            Me.lbl_ST1101.Text = Me.lbl_ST1101.Text & vbCrLf & " 　[入庫]　 "
            Me.lbl_ST1102.Text = Me.lbl_ST1102.Text & vbCrLf & " 　[出庫]　 "
            Me.lbl_ST1201.Text = Me.lbl_ST1201.Text & vbCrLf & "[空容器入庫]"
            Me.lbl_ST1202.Text = Me.lbl_ST1202.Text & vbCrLf & "[空容器出庫]"
            Me.lbl_ST1301.Text = Me.lbl_ST1301.Text & vbCrLf & " 　[出庫]　 "
            Me.lbl_ST1302.Text = Me.lbl_ST1302.Text & vbCrLf & " 　[入庫]　 "
            Me.lbl_ST2101.Text = Me.lbl_ST2101.Text & vbCrLf & "[空容器入庫]　 "
            Me.lbl_ST2102.Text = Me.lbl_ST2102.Text & vbCrLf & " 　[出庫]　 "
            Me.lbl_ST2201.Text = Me.lbl_ST2201.Text & vbCrLf & " 　[入庫]　 "
            Me.lbl_ST2202.Text = Me.lbl_ST2202.Text & vbCrLf & " 　[出庫]　 "
            Me.lbl_ST2301.Text = Me.lbl_ST2301.Text & vbCrLf & "[空容器出庫]　 "
            Me.lbl_ST2302.Text = Me.lbl_ST2302.Text & vbCrLf & " 　[入庫]　 "
            Me.lbl_ST3101.Text = Me.lbl_ST3101.Text & vbCrLf & " 　[入庫]　 "
            Me.lbl_ST3201.Text = Me.lbl_ST3201.Text & vbCrLf & "[空容器入庫]"
            Me.lbl_ST3301.Text = Me.lbl_ST3301.Text & vbCrLf & "[空容器出庫]"


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
            btnFXX(1).Text = "作業開始"
            btnFXX(2).Text = "一斉起動"
            btnFXX(3).Text = ""
            btnFXX(4).Text = "接続/切離"

            btnFXX(5).Text = "ﾌﾞｻﾞｰﾘｾｯﾄ"
            btnFXX(6).Text = ""
            btnFXX(7).Text = "一斉停止"
            btnFXX(8).Text = "作業終了"

            btnFXX(9).Text = ""
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = True
            btnFXX(2).Enabled = True
            btnFXX(3).Enabled = False
            btnFXX(4).Enabled = True

            btnFXX(5).Enabled = True
            btnFXX(6).Enabled = False
            btnFXX(7).Enabled = True
            btnFXX(8).Enabled = True

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
            btnFXX(1).Text = "作業開始"
            btnFXX(2).Text = "一斉起動"
            btnFXX(3).Text = ""
            btnFXX(4).Text = "接続/切離"

            btnFXX(5).Text = "ﾌﾞｻﾞｰﾘｾｯﾄ"
            btnFXX(6).Text = ""
            btnFXX(7).Text = "一斉停止"
            btnFXX(8).Text = "作業終了"

            btnFXX(9).Text = "DPS作業者登録"
            btnFXX(10).Text = "表示器" & vbCrLf & "テスト"
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = True
            btnFXX(2).Enabled = True
            btnFXX(3).Enabled = False
            btnFXX(4).Enabled = True

            btnFXX(5).Enabled = True
            btnFXX(6).Enabled = False
            btnFXX(7).Enabled = True
            btnFXX(8).Enabled = True

            btnFXX(9).Enabled = True
            btnFXX(10).Enabled = True
            btnFXX(11).Enabled = True
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

    '標準フォームのオブジェクト設定_タブ1
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

            btnFXX(5).Text = "ﾌﾞｻﾞｰﾘｾｯﾄ"
            btnFXX(6).Text = "ｼｽﾃﾑﾘｾｯﾄ"
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
    Private Sub ShowData(ByVal idata_kbn As Integer, ByVal idata_cnt As Integer)
        Dim sSql As String = ""

        Dim drRow() As DataRow = Nothing

        Dim iloop As Integer = 0
        Dim iRow As Integer = 0

        Try


            If idata_kbn = 1 Then
                'システム稼動設定
                dgvAWS.Rows.Clear()

                If idata_cnt = 99 Then
                    GoTo skip1
                End If

                For iloop = 0 To idata_cnt
                    iRow = dgvAWS.Rows.Add()

                    dgvAWS(0, iRow).Value = "123456"             '容器番号
                    dgvAWS(1, iRow).Value = "XXXXXXXXXXXXXXXX"   '商品コード
                    dgvAWS(2, iRow).Value = "YYYY/MM/DD"         '賞味期限
                    dgvAWS(3, iRow).Value = "XXXXXXXXXX"         'ロットNo
                    dgvAWS(4, iRow).Value = "YYYY/MM/DD"         '初回入荷日
                    dgvAWS(5, iRow).Value = "その他"             '荷主区分
                    dgvAWS(6, iRow).Value = "未検査品"           '品質管理区分
                    dgvAWS(7, iRow).Value = "1234567890.99"      '在庫数
                    dgvAWS(8, iRow).Value = "1234567890"         '搬送ID
                    dgvAWS(9, iRow).Value = "設定者設定"         '設定者
                Next
            End If
skip1:
            If idata_kbn = 2 Then
                'ステーション切離設定
                dgvDPS.Rows.Clear()

                If idata_cnt = 99 Then
                    GoTo skip2
                End If

                For iloop = 0 To idata_cnt
                    iRow = dgvDPS.Rows.Add()

                    dgvDPS(0, iRow).Value = "123456"             '容器番号
                    dgvDPS(1, iRow).Value = "XXXXXXXXXX"         '出荷指示No
                    dgvDPS(2, iRow).Value = "XXXXXXXXXXXXXXXX"   '商品コード
                    dgvDPS(3, iRow).Value = "YYYY/MM/DD"         '賞味期限
                    dgvDPS(4, iRow).Value = "XXXXXXXXXX"         'ロットNo
                    dgvDPS(5, iRow).Value = "YYYY/MM/DD"         '初回入荷日
                    dgvDPS(6, iRow).Value = "その他"             '荷主区分
                    dgvDPS(7, iRow).Value = "未検査品"           '品質管理区分
                    dgvDPS(8, iRow).Value = "1234567890.99"      '在庫数
                    dgvDPS(9, iRow).Value = "1234567890"         '搬送ID
                    dgvDPS(10, iRow).Value = "設定者設定"         '設定者

                Next
            End If
skip2:
            dgvSystem.Rows.Clear()
            For iloop = 0 To 9
                iRow = dgvSystem.Rows.Add()

                dgvSystem(0, iRow).Value = "2015/09/01 12:00:00"             '発生日時
                dgvSystem(1, iRow).Value = "9999"         '異常コード
                dgvSystem(2, iRow).Value = "異常名称異常名称異常名称異常名称異常名称異常名称異常名称異常"         '異常名称
                dgvSystem(3, iRow).Value = "異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容異常内容"   '異常内容
               

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

#Region "Timer"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Timer1.Enabled = False

            'ラベル点滅のサンプル表示用
            If bVisible = True Then
                Me.lbl_ST1101_H.Visible = False
                Me.lbl_ST1201_H.Visible = False
                Me.lbl_ST1302_H.Visible = False
                Me.lbl_ST2201_H.Visible = False
                bVisible = False
            Else
                Me.lbl_ST1101_H.Visible = True
                Me.lbl_ST1201_H.Visible = True
                Me.lbl_ST1302_H.Visible = True
                Me.lbl_ST2201_H.Visible = True
                bVisible = True
            End If

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        Finally
            Timer1.Enabled = True

        End Try
    End Sub

#End Region

End Class
