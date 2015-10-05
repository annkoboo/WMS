Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Reflection.MethodInfo
Imports WMS.clsCommon.Library
Imports WMS.CommonModule
Imports Microsoft.VisualBasic


Public Class frmSetubiConn

#Region "イベント"
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'フォーム_Load
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub 接続切離し設定_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sName As String = ""

        Try
            cmbSYSINFO.Items.Clear()
            For iLoop = 0 To 20
                sName = ""

                Select Case iLoop
                    Case 0
                        sName = "CS1号機"
                    Case 1
                        sName = "CS2号機"
                    Case 2
                        sName = "FS1号機"
                    Case 3
                        sName = "CS1号機 1F入出庫ST_1101"
                    Case 4
                        sName = "CS1号機 1F入出庫ST_1102"
                    Case 5
                        sName = "CS1号機 2F入出庫ST_1201"
                    Case 6
                        sName = "CS1号機 2F入出庫ST_1202"
                    Case 7
                        sName = "CS1号機 3F入出庫ST_1301"
                    Case 8
                        sName = "CS1号機 3F入出庫ST_1302"
                    Case 9
                        sName = "CS2号機 1F入出庫ST_2101"
                    Case 10
                        sName = "CS2号機 1F入出庫ST_2102"
                    Case 11
                        sName = "CS2号機 2F入出庫ST_2201"
                    Case 12
                        sName = "CS2号機 2F入出庫ST_2202"
                    Case 13
                        sName = "CS2号機 3F入出庫ST_2301"
                    Case 14
                        sName = "CS2号機 3F入出庫ST_2302"
                    Case 15
                        sName = "FS1号機 1F入出庫ST_3101"
                    Case 16
                        sName = "FS1号機 2F入出庫ST_3201"
                    Case 17
                        sName = "FS1号機 3F入出庫ST_3301"
                    Case 18
                        sName = "DPSライン01"
                    Case 19
                        sName = "DPSライン02"
                    Case 20
                        sName = "SAC01"

                End Select

                If sName <> "" Then
                    cmbSYSINFO.Items.Add(sName)

                End If
            Next

            dgv_State1.DefaultCellStyle.SelectionBackColor = dgv_State1.DefaultCellStyle.BackColor
            dgv_State1.DefaultCellStyle.SelectionForeColor = dgv_State1.DefaultCellStyle.ForeColor
            dgv_State2.DefaultCellStyle.SelectionBackColor = dgv_State2.DefaultCellStyle.BackColor
            dgv_State2.DefaultCellStyle.SelectionForeColor = dgv_State2.DefaultCellStyle.ForeColor

            '_/ ﾗｼﾞｵﾎﾞﾀﾝ
            rdbStart.Enabled = False
            rdbEnd.Enabled = False
            rdbStart.Checked = True
            rdbEnd.Checked = False

            Call ShowData()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '終了ボタン_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt終了_Click(sender As Object, e As EventArgs) Handles bt終了.Click
        Me.Close()
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '設定ボタン_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub bt設定_Click(sender As Object, e As EventArgs) Handles bt設定.Click
        Me.Close()
    End Sub

#End Region

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
        Dim sName As String = ""

        Try
            dgv_State1.RowCount = 0

            For iloop = 0 To 10
                sName = ""
                Select Case iloop

                    Case 0
                        sName = "CS1号機"
                    Case 1
                        sName = "CS2号機"
                    Case 2
                        sName = "FS1号機"
                    Case 3
                        sName = "CS1号機 1F入出庫ST_1101"
                    Case 4
                        sName = "CS1号機 1F入出庫ST_1102"
                    Case 5
                        sName = "CS1号機 2F入出庫ST_1201"
                    Case 6
                        sName = "CS1号機 2F入出庫ST_1202"
                    Case 7
                        sName = "CS1号機 3F入出庫ST_1301"
                    Case 8
                        sName = "CS1号機 3F入出庫ST_1302"
                    Case 9
                        sName = "CS2号機 1F入出庫ST_2101"
                    Case 10
                        sName = "CS2号機 1F入出庫ST_2102"
                End Select

                iRow = dgv_State1.Rows.Add()

                dgv_State1(0, iRow).Value = sName
                If iloop = 5 Then
                    dgv_State1(1, iRow).Value = "切断中"
                    dgv_State1(1, iRow).Style.BackColor = Color.White
                    dgv_State1(0, iRow).Style.SelectionBackColor = Color.White
                    dgv_State1(1, iRow).Style.SelectionBackColor = Color.White
                Else
                    dgv_State1(1, iRow).Value = "接続中"
                    dgv_State1(1, iRow).Style.BackColor = Color.LimeGreen
                    dgv_State1(0, iRow).Style.SelectionBackColor = Color.White
                    dgv_State1(1, iRow).Style.SelectionBackColor = Color.LimeGreen
                End If

            Next


            dgv_State2.RowCount = 0

            For iloop = 0 To 9
                sName = ""
                Select Case iloop

                    Case 0
                        sName = "CS2号機 2F入出庫ST_2201"
                    Case 1
                        sName = "CS2号機 2F入出庫ST_2202"
                    Case 2
                        sName = "CS2号機 3F入出庫ST_2301"
                    Case 3
                        sName = "CS2号機 3F入出庫ST_2302"
                    Case 4
                        sName = "FS1号機 1F入出庫ST_3101"
                    Case 5
                        sName = "FS1号機 2F入出庫ST_3201"
                    Case 6
                        sName = "FS1号機 3F入出庫ST_3301"
                    Case 7
                        sName = "DPSライン01"
                    Case 8
                        sName = "DPSライン02"
                    Case 9
                        sName = "SAC01"

                End Select

                iRow = dgv_State2.Rows.Add()

                dgv_State2(0, iRow).Value = sName
                If iloop = 8 Then
                    dgv_State2(1, iRow).Value = "切断中"
                    dgv_State2(1, iRow).Style.BackColor = Color.White
                    dgv_State2(0, iRow).Style.SelectionBackColor = Color.White
                    dgv_State2(1, iRow).Style.SelectionBackColor = Color.White
                Else
                    dgv_State2(1, iRow).Value = "接続中"
                    dgv_State2(1, iRow).Style.BackColor = Color.LimeGreen
                    dgv_State2(0, iRow).Style.SelectionBackColor = Color.White
                    dgv_State2(1, iRow).Style.SelectionBackColor = Color.LimeGreen
                End If

            Next

        Catch oraErr As Oracle.DataAccess.Client.OracleException
            Call OraErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSql)
        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

        Finally


        End Try
    End Sub

    'セルクリック
    Private Sub dgv_State1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_State1.CellClick
        Dim iIdx As Integer = 0

        Try
            If e.RowIndex < 0 Then Exit Try

            iIdx = e.RowIndex

            cmbSYSINFO.SelectedIndex = iIdx

        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
        End Try
    End Sub
    Private Sub dgv_State2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_State2.CellClick
        Dim iIdx As Integer = 0

        Try
            If e.RowIndex < 0 Then Exit Try

            iIdx = e.RowIndex + 11

            cmbSYSINFO.SelectedIndex = iIdx

        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
        End Try
    End Sub

    '_/ ｺﾝﾎﾞﾎﾞｯｸｽ選択 
    Private Sub cmbSYSINFO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSYSINFO.SelectedIndexChanged
        Dim cmb As ComboBox = CType(sender, ComboBox)
        Dim iNum As Integer = 0
        Dim sProc As String = ""
        Try

            '_/ ｺﾝﾎﾞﾎﾞｯｸｽ選択No
            iNum = cmb.SelectedIndex
            If iNum > 10 Then
                iNum = iNum - 11
                If iNum < 0 Or iNum > cmb.MaxDropDownItems Or dgv_State2.RowCount <= 0 Then
                    sProc = ""
                Else
                    '_/ DataGridView 状態取得
                    sProc = (dgv_State2(1, iNum).Value).ToString
                End If
            Else
                If iNum < 0 Or iNum > cmb.MaxDropDownItems Or dgv_State1.RowCount <= 0 Then
                    sProc = ""
                Else
                    '_/ DataGridView 状態取得
                    sProc = (dgv_State1(1, iNum).Value).ToString
                End If
            End If
       
            Select Case sProc
                Case "接続中"
                    rdbStart.Enabled = False
                    rdbEnd.Enabled = True
                    rdbStart.Checked = False
                    rdbEnd.Checked = True

                    lblState.Text = "接続中"
                    lblState.BackColor = Color.LimeGreen

                Case "切断中"
                    rdbStart.Enabled = True
                    rdbEnd.Enabled = False
                    rdbStart.Checked = True
                    rdbEnd.Checked = False

                    lblState.Text = "切離中"
                    lblState.BackColor = Color.White

                Case Else
                    rdbStart.Enabled = False
                    rdbEnd.Enabled = False
                    rdbStart.Checked = True
                    rdbEnd.Checked = False

            End Select

        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)
        Finally

        End Try
    End Sub

End Class
