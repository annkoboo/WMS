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


Public Class frmOkurijoLst


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
                    Dim frmEdit As New frmShukaModosiLstPrt
                    frmEdit.ShowDialog()

                Case 2
                Case 3
                Case 4
                Case 5
                Case 6
                Case 7
                Case 8
                Case 9
                    'CSV
                    Dim fdCSV As New SaveFileDialog
                    Dim csvFileName As String = String.Empty  'CSVファイルの名前

                    '保存先選択ダイアログ設定
                    fdCSV.Filter = "CSVファイル(*.csv)|*.csv|全てのファイル(*.*)|*.*" 'ファイルの種類コンボ
                    fdCSV.FilterIndex = 0            'ファイルの種類の初期選択(CSVを選択)
                    'fdCSV.InitialDirectory = "D:\"   '初期表示パス
                    fdCSV.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)   '初期表示パス
                    fdCSV.Title = "保存先を選択してください。"
                    fdCSV.FileName = "送り状Noデータ_" & System.DateTime.Now.ToString("yyyyMMddHHmmss")

                    If fdCSV.ShowDialog = Windows.Forms.DialogResult.OK Then
                        csvFileName = fdCSV.FileName
                    Else
                        
                    End If

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


#End Region


#Region "関数"
    '標準フォームのオブジェクト設定_タブ0
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
            btnFXX(2).Text = "登録"
            btnFXX(3).Text = ""
            btnFXX(4).Text = "削除"

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = "入力クリア"
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""

            btnFXX(9).Text = "CSV出力"
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "戻る"

            '使用許可(初期)
            btnFXX(1).Enabled = False
            btnFXX(2).Enabled = True
            btnFXX(3).Enabled = False
            btnFXX(4).Enabled = True

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

            lblTitle.Text = "送り状No問合せ"

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
            dgvOkuri.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvOkuri.Rows.Add()

                dgvOkuri(0, iRow).Value = "1234567"     '運送会社ｺｰﾄﾞ
                dgvOkuri(1, iRow).Value = "運送会社名運送会社名"     '運送会社名
                dgvOkuri(2, iRow).Value = "123456789012"     '送り状No
                dgvOkuri(3, iRow).Value = "備考備考備考備考備考"     '備考
                dgvOkuri(4, iRow).Value = "12,345"     '個口数

            Next

            dgvSyuNo.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvSyuNo.Rows.Add()

                dgvSyuNo(0, iRow).Value = "2015/06/30"     '出荷指示日
                dgvSyuNo(1, iRow).Value = "1234567890"     '出荷指示No
                dgvSyuNo(2, iRow).Value = "1234567890123"     '出荷先コード
                dgvSyuNo(3, iRow).Value = "出荷先名称出荷先名称出荷先名称"     '出荷先名称
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
