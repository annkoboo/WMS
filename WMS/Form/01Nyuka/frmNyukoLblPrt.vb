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


Public Class frmNyukoLblPrt





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

            btnFXX(5).Text = ""
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

            btnFXX(5).Enabled = False
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

            lblTitle.Text = "入庫ラベル発行"

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
            'dgvYotei.RowCount = 0

            'For iloop = 0 To 9
            '    iRow = dgvYotei.Rows.Add()


            '    dgvYotei(1, iRow).Value = "未"       '状態
            '    dgvYotei(2, iRow).Value = "123"     '生産ライン
            '    dgvYotei(3, iRow).Value = "12345"   '荷主ｺｰﾄﾞ
            '    dgvYotei(4, iRow).Value = "123456"       '品名ｺｰﾄﾞ
            '    dgvYotei(5, iRow).Value = "あいうえおかきくけこさしすせそ"       '品名
            '    dgvYotei(6, iRow).Value = "12:あいう"       '製品区分
            '    dgvYotei(7, iRow).Value = "123456789012"       'ﾛｯﾄNo
            '    dgvYotei(8, iRow).Value = "12,345"       '予定数量
            '    dgvYotei(9, iRow).Value = "12,345"       '実績数量
            '    dgvYotei(10, iRow).Value = "1234"       'ﾊﾟﾚﾀｲｻﾞNo
            '    dgvYotei(11, iRow).Value = "第一"       '倉庫
            '    dgvYotei(12, iRow).Value = "12:34"       '開始時間
            '    dgvYotei(13, iRow).Value = "12:34"       '終了時間
            '    dgvYotei(14, iRow).Value = "12:あいうえおかきくけこ"       '受払内容


            'Next


        Catch oraErr As Oracle.DataAccess.Client.OracleException
            Call OraErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSql)
        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

        Finally


        End Try
    End Sub


#End Region


#Region "イベント-フォーム-"
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sMsg As String = ""
        Try




            '共通項目初期化
            Call InitCommon()


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
                    'F12 実行

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

#End Region


End Class