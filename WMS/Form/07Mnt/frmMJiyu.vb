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
Imports Oracle.DataAccess.Client


Public Class frmMJiyu

    ''' <summary>
    ''' グリッドの列インデックス
    ''' </summary>
    Enum colJiyu
        JiyuCd = 0
        JiyuNm
        NyuShuKbn
        ZaimuKbn
    End Enum

#Region "イベント-フォーム-"
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sMsg As String = ""

        Try
            '砂時計にする
            Frm.WaitCursorAndDisable(Me)

            '共通項目初期化
            Call InitCommon()
            Me.StartPosition = FormStartPosition.CenterScreen

            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.MinimumSize = New System.Drawing.Size(100, 100)
            Me.MaximumSize = New System.Drawing.Size(1500, 1500)

            ''仮データセット
            'Call ShowDemoData()

            'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            'Me.MinimumSize = New System.Drawing.Size(100, 100)
            'Me.MaximumSize = New System.Drawing.Size(1500, 1500)

        Catch ex As Exception
            Call vbErrSub(MyBase.GetType.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, CShort(Err.Number), ex)

            '砂時計を解除
            Frm.ArrowAndEnable(Me)

        End Try
    End Sub

    Private Sub frmMJiyu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            'グリッドの表示
            fncShowDgvFindJiyu()

            '新規登録モードにする
            fncSetAddMode()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        Finally
            '砂時計を解除
            Frm.ArrowAndEnable(Me)

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
                Case 2  'F2 登録
                    '入力内容の保存
                    fncSave()

                Case 3
                Case 4  'F4 削除
                    fncErase()

                Case 5  'F5 表示
                    'グリッドの表示
                    If fncShowDgvFindJiyu() = "OK" Then
                        '新規登録モードにする
                        fncSetAddMode()
                    End If

                Case 6  'F6 入力ｸﾘｱ
                    '新規登録モードにする
                    fncSetAddMode()

                Case 7
                Case 8
                Case 9
                Case 10
                Case 11
                Case 12 'F12 戻る
                    '既にロックしている行があるかもしれないので、一旦ロールバックしてからクリックした行を新たにロックする
                    OraDB.BeginTrans()
                    OraDB.RollBack()
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

    ''' <summary>
    ''' グリッドのクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvFindJiyu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFindJiyu.CellClick
        Try
            'データ行以外のクリックなら抜ける
            If e.RowIndex < 0 Or e.RowIndex > (Me.dgvFindJiyu.RowCount - 1) Then
                Exit Sub
            End If

            'クリックした行のデータを、入力エリアに表示する
            fncShowModify(e.RowIndex)

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

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
    'bt表示_Click
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'Private Sub bt表示_Click(sender As Object, e As EventArgs)
    '    Try
    '        '在庫一覧表示
    '    Catch ex As Exception
    '        Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex, False, cShowMsg)
    '    End Try
    'End Sub

#End Region

#Region "関数"
    ''' <summary>
    ''' グリッドの表示
    ''' </summary>
    ''' <returns>"OK"、"NG"</returns>
    Private Function fncShowDgvFindJiyu(Optional ByVal JiyuCd As String = "") As String
        Try
            '砂時計にする
            Frm.WaitCursorAndDisable(Me)

            '検索条件のチェック
            Dim Msg As String = ""
            If Me.txtFindJiyuCd.Text <> "" Then
                If Not Char.IsNumber(Me.txtFindJiyuCd.Text) Then
                    Msg = "［事由コード］には数字を入力してください。"
                    MessageBox.Show(Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Frm.ArrowAndEnable(Me)
                    Me.txtFindJiyuCd.Focus()
                    Return "NG"
                End If
            End If

            'グリッドをクリア
            dgvFindJiyu.RowCount = 0

            'SQL作成
            Dim Sql As String = ""
            Sql += "select * "
            Sql += "from M_JIYU "
            If Me.txtFindJiyuCd.Text <> "" Then
                Sql += "where JIYU_CODE = " & OraDB.Num(Me.txtFindJiyuCd.Text)
            End If
            Sql += "order by JIYU_CODE "
            Debug.Print(Sql)

            'SQL実行
            Dim OraReader As OracleDataReader
            OraReader = OraDB.Read(Sql)

            'SELECTしたデータを取得
            Dim iRow As Integer = 0
            Dim iActive As Integer = -1
            While OraReader.Read
                '1行追加
                iRow = Me.dgvFindJiyu.Rows.Add()

                'データを表示
                Me.dgvFindJiyu(colJiyu.JiyuCd, iRow).Value = OraReader("JIYU_CODE")
                Me.dgvFindJiyu(colJiyu.JiyuNm, iRow).Value = OraReader("JIYU_NAME")
                Me.dgvFindJiyu(colJiyu.NyuShuKbn, iRow).Value = Cd.GetMeaning(ClassCode.CdNm.NyuShuKbn, OraReader("NYUSYU_KBN"))
                Me.dgvFindJiyu(colJiyu.ZaimuKbn, iRow).Value = Cd.GetMeaning(ClassCode.CdNm.ZaimuKbn, OraReader("ZAIMU_KBN"))

                '選択データの指定がある時は、その行を記憶する
                If JiyuCd <> "" Then
                    If OraReader("JIYU_CODE") = JiyuCd Then
                        iActive = iRow
                    End If
                End If
            End While

            '行を選択状態にする
            If iActive > -1 Then
                '該当の行を選択状態にする
                Me.dgvFindJiyu.CurrentCell = Me.dgvFindJiyu(0, iActive)

            Else
                '選択行をなくす
                Me.dgvFindJiyu.CurrentCell = Nothing

            End If

            'クローズして終わる
            OraReader.Close()
            Return "OK"

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
            Return "NG"

        Finally
            '砂時計を解除
            Frm.ArrowAndEnable(Me)

        End Try
    End Function

    ''' <summary>
    ''' 新規登録モードにする
    ''' </summary>
    Private Sub fncSetAddMode()
        Try
            '既にロックしている行があるかもしれないので、一旦ロールバックしてからクリックした行を新たにロックする
            OraDB.BeginTrans()
            OraDB.RollBack()

            'デフォルトを設定
            Me.txtEtyJiyuCd.Text = ""
            Me.txtEtyJiyuNm.Text = ""
            Me.rdoEtyDosaKbnNyuko.Checked = True
            Me.rdoEtyZaimuKbnSuru.Checked = True
            Me.dgvFindJiyu.CurrentCell = Nothing    '選択行をなくす

            'プライマリキーを入力可にする
            Me.txtEtyJiyuCd.ReadOnly = False
            Me.txtEtyJiyuCd.Focus()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        End Try
    End Sub

    ''' <summary>
    ''' グリッドでクリックした行のデータを、入力エリアに表示する
    ''' </summary>
    ''' <param name="iClickRow">クリックした行のインデックス</param>
    Private Sub fncShowModify(ByVal iClickRow As Integer)
        Try
            '既にロックしている行があるかもしれないので、一旦ロールバックしてからクリックした行を新たにロックする
            OraDB.BeginTrans()
            OraDB.RollBack()

            '修正データの取得とロック
            Dim OraReader As OracleDataReader
            Dim Ret = fncLockModifyDat(OraReader, Me.dgvFindJiyu(colJiyu.JiyuCd, iClickRow).Value)

            '修正データを取得できたら表示、できなければ新規登録モードにする
            If Ret = "OK" Then
                '修正データを入力エリアに表示
                If OraReader.Read() = True Then
                    Me.txtEtyJiyuCd.Text = OraReader("JIYU_CODE")
                    Me.txtEtyJiyuNm.Text = OraReader("JIYU_NAME")

                    Select Case OraReader("NYUSYU_KBN")
                        Case ClassCode.NYUSHUKBN_NYUKO
                            Me.rdoEtyDosaKbnNyuko.Checked = True
                        Case ClassCode.NYUSHUKBN_SHUKO
                            Me.rdoEtyDosaKbnShuko.Checked = True
                    End Select

                    Select Case OraReader("ZAIMU_KBN")
                        Case ClassCode.ZAIMUKBN_KANYOSURU
                            Me.rdoEtyZaimuKbnSuru.Checked = True
                        Case ClassCode.ZAIMUKBN_KANYOSINAI
                            Me.rdoEtyZaimuKbnSinai.Checked = True
                    End Select
                End If

                'プライマリキーは修正不可にする
                Me.txtEtyJiyuCd.ReadOnly = True

            Else
                '新規登録モードにする
                fncSetAddMode()

            End If

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        End Try
    End Sub

    ''' <summary>
    ''' 修正データの取得とロック
    ''' </summary>
    ''' <param name="OraReader">SELECTしたデータのOracleDataReader</param>
    ''' <param name="JiyuCd">SELECTの条件</param>
    ''' <returns></returns>
    Private Function fncLockModifyDat(ByRef OraReader As OracleDataReader, ByVal JiyuCd As String) As String
        Try
            'SQL作成
            Dim Sql As String = ""
            Sql += "select * "
            Sql += "from M_JIYU "
            Sql += "where JIYU_CODE = " & OraDB.Num(JiyuCd)
            Sql += "for update of JIYU_CODE nowait"
            Debug.Print(Sql)

            'SQL実行
            OraReader = OraDB.Read(Sql)
            Return "OK"

        Catch OraErr As OracleException When OraErr.Number = 54
            '54はデータがロックされているので、ワーニングメッセージを表示する
            Frm.fncShowMsgDatLock()
            Return "NG"

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
            Return "NG"

        End Try
    End Function

    ''' <summary>
    ''' 入力内容を保存する
    ''' </summary>
    Private Sub fncSave()
        Try
            '砂時計にする
            Frm.WaitCursorAndDisable(Me)

            '入力内容のチェック
            If fncChkEty() = "NG" Then
                Exit Sub
            End If

            'データを保存する
            'グリッドで選択行がなければ「新規登録」、あれば「修正／削除」
            If Me.dgvFindJiyu.SelectedRows.Count <= 0 Then
                'データを登録
                fncInsMJiyu()
                'グリッドの表示
                fncShowDgvFindJiyu(Me.txtEtyJiyuCd.Text)
                '登録したデータを、修正モードにしてロックする
                fncShowModify(Me.dgvFindJiyu.CurrentCell.RowIndex)

            ElseIf Me.dgvFindJiyu.SelectedRows.Count > 0 Then
                'データを更新
                fncUpdMJiyu()
                'グリッドの表示
                fncShowDgvFindJiyu(Me.txtEtyJiyuCd.Text)

            End If


        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        Finally
            '砂時計を解除
            Frm.ArrowAndEnable(Me)

        End Try
    End Sub

    ''' <summary>
    ''' 入力内容のチェック
    ''' </summary>
    ''' <returns>"OK"、"NG"</returns>
    Private Function fncChkEty() As String
        Try
            Dim Msg As String = ""

            '事由コード
            If Not Char.IsNumber(Me.txtEtyJiyuCd.Text) Then
                Msg = "［事由コード］には数字を入力してください。"
                MessageBox.Show(Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Frm.ArrowAndEnable(Me)
                Me.txtEtyJiyuCd.Focus()
                Return "NG"
            End If

            'グリッドで選択行がない時は「新規登録」なので、事由コードの重複チェック
            If Me.dgvFindJiyu.SelectedRows.Count <= 0 Then
                If fncSelJiyuCdCnt() > 0 Then
                    Msg = "［事由コード］＝" & Me.txtEtyJiyuCd.Text & " は既に登録されています。"
                    MessageBox.Show(Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Frm.ArrowAndEnable(Me)
                    Me.txtEtyJiyuCd.Focus()
                    Return "NG"
                End If
            End If

            '事由名称
            If Me.txtEtyJiyuNm.Text.Trim(" ").Trim("　").Length <= 0 Then
                Msg = "［事由名称］を入力してください。"
                MessageBox.Show(Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Frm.ArrowAndEnable(Me)
                Me.txtEtyJiyuNm.Focus()
                Return "NG"
            End If

            '入力内容OK
            Return "OK"

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
            Return "NG"

        End Try
    End Function

    ''' <summary>
    ''' 入力された事由コードが既に登録されているか件数を取得する
    ''' </summary>
    ''' <returns>件数</returns>
    Private Function fncSelJiyuCdCnt() As Integer
        Try
            'SQL作成
            Dim Sql As String = ""
            Sql += "select count(*) as Cnt "
            Sql += "from M_JIYU "
            Sql += "where JIYU_CODE = " & OraDB.Num(Me.txtEtyJiyuCd.Text)
            Debug.Print(Sql)

            'SQL実行
            Dim OraReader As OracleDataReader
            OraReader = OraDB.Read(Sql)

            'SELECTしたデータを取得
            Dim Cnt As Integer = 0
            While OraReader.Read
                Cnt = OraReader("Cnt")
                Exit While  'カウントなので1件で抜ける
            End While

            '件数を返す
            OraReader.Close()
            Return Cnt

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        End Try
    End Function

    ''' <summary>
    ''' 事由マスタデータの挿入
    ''' </summary>
    Private Sub fncInsMJiyu()
        Try
            'トランザクション
            OraDB.BeginTrans()

            'SQL作成
            Dim Sql As String = ""
            Sql += "insert into M_JIYU ("
            Sql += "JIYU_CODE, "
            Sql += "JIYU_NAME, "
            Sql += "NYUSYU_KBN, "
            Sql += "ZAIMU_KBN "
            Sql += ") "

            Sql += "values ("
            Sql += OraDB.Num(Me.txtEtyJiyuCd.Text, True)
            Sql += OraDB.Str(Me.txtEtyJiyuNm.Text, True)
            Sql += OraDB.Str(IIf(Me.rdoEtyDosaKbnNyuko.Checked, ClassCode.NYUSHUKBN_NYUKO, ClassCode.NYUSHUKBN_SHUKO), True)
            Sql += OraDB.Str(IIf(Me.rdoEtyZaimuKbnSuru.Checked, ClassCode.ZAIMUKBN_KANYOSURU, ClassCode.ZAIMUKBN_KANYOSINAI))
            Sql += ") "

            Debug.Print(Sql)

            'SQL実行
            OraDB.Excute(Sql)

            'コミット
            OraDB.Commit()

        Catch ex As Exception
            'ロールバック
            OraDB.RollBack()
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        End Try
    End Sub

    ''' <summary>
    ''' 事由マスタデータの更新
    ''' </summary>
    Private Sub fncUpdMJiyu()
        Try
            'トランザクション
            OraDB.BeginTrans()

            'SQL作成
            Dim Sql As String = ""
            Sql += "update M_JIYU set "
            Sql += "JIYU_NAME = " & OraDB.Str(Me.txtEtyJiyuNm.Text, True)
            Sql += "NYUSYU_KBN = " & OraDB.Str(IIf(Me.rdoEtyDosaKbnNyuko.Checked, ClassCode.NYUSHUKBN_NYUKO, ClassCode.NYUSHUKBN_SHUKO), True)
            Sql += "ZAIMU_KBN = " & OraDB.Str(IIf(Me.rdoEtyZaimuKbnSuru.Checked, ClassCode.ZAIMUKBN_KANYOSURU, ClassCode.ZAIMUKBN_KANYOSINAI))

            Sql += "where JIYU_CODE = " & OraDB.Num(Me.txtEtyJiyuCd.Text)

            Debug.Print(Sql)

            'SQL実行
            OraDB.Excute(Sql)

            'コミット
            OraDB.Commit()

        Catch ex As Exception
            'ロールバック
            OraDB.RollBack()
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        End Try
    End Sub

    ''' <summary>
    ''' 選択データを削除する
    ''' </summary>
    Private Sub fncErase()
        Try
            '砂時計にする
            Frm.WaitCursorAndDisable(Me)

            'グリッドで選択行がない時は、削除はエラー
            Dim Msg As String = ""
            If Me.dgvFindJiyu.SelectedRows.Count <= 0 Then
                Msg = "削除するデータを選択してください。"
                MessageBox.Show(Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Frm.ArrowAndEnable(Me)
            End If

            '確認メッセージ
            Msg = "選択中のデータを削除します。" & vbCrLf
            Msg += "よろしいですか？"
            If MessageBox.Show(Msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If

            'データを削除
            fncDelMJiyu()

            'グリッドの表示
            fncShowDgvFindJiyu()

            '新規登録モードにする
            fncSetAddMode()

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        Finally
            '砂時計を解除
            Frm.ArrowAndEnable(Me)

        End Try
    End Sub

    ''' <summary>
    ''' 事由マスタデータの削除
    ''' </summary>
    Private Sub fncDelMJiyu()
        Try
            'トランザクション
            OraDB.BeginTrans()

            'SQL作成
            Dim Sql As String = ""
            Sql += "delete from M_JIYU "
            Sql += "where JIYU_CODE = " & OraDB.Num(Me.txtEtyJiyuCd.Text)

            Debug.Print(Sql)

            'SQL実行
            OraDB.Excute(Sql)

            'コミット
            OraDB.Commit()

        Catch ex As Exception
            'ロールバック
            OraDB.RollBack()
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        End Try
    End Sub

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
            btnFXX(2).Text = "登録"
            btnFXX(3).Text = ""
            btnFXX(4).Text = "削除"

            btnFXX(5).Text = "表示"
            btnFXX(6).Text = "入力ｸﾘｱ"
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
            btnFXX(4).Enabled = True

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

            lblTitle.Text = "事由マスタメンテナンス"

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '関　数:ShowDemoData
    '処　理:検索表示処理
    '引　数:
    '作成日
    '作成者:
    '備　考:
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub ShowDemoData()
        Dim sSql As String = ""

        Dim drRow() As DataRow = Nothing

        Dim iloop As Integer = 0
        Dim iRow As Integer = 0

        Try
            dgvFindJiyu.RowCount = 0

            For iloop = 0 To 9
                iRow = dgvFindJiyu.Rows.Add()

                dgvFindJiyu(0, iRow).Value = "99"                              '事由コード
                dgvFindJiyu(1, iRow).Value = "あいうえおかきくけこさしすせそ"  '事由名称
                dgvFindJiyu(2, iRow).Value = "入庫"                            '入出庫区分｛入庫、出庫｝
                dgvFindJiyu(3, iRow).Value = "関与する"                        '財務区分｛関与する、関与しない｝

            Next


        Catch oraErr As Oracle.DataAccess.Client.OracleException
            Call OraErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, oraErr.Number, oraErr.Message, oraErr, sSql)
        Catch ex As Exception
            Call vbErrSub(Me.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

        Finally


        End Try
    End Sub

    'タブ描画
    'Private Sub TabControl1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
    '    '変数定義
    '    Dim backBrush As SolidBrush
    '    Dim foreBrush As SolidBrush

    '    '選択中のタブを判定
    '    If TabControl1.SelectedIndex = e.Index Then
    '        backBrush = New SolidBrush(Color.Navy)
    '        foreBrush = New SolidBrush(Color.White)
    '    Else
    '        backBrush = New SolidBrush(SystemColors.Control)
    '        foreBrush = New SolidBrush(Color.Black)
    '    End If

    '    '背景色塗潰し
    '    e.Graphics.FillRectangle(backBrush, e.Bounds)

    '    '表示文字列描画
    '    Dim format As StringFormat = New StringFormat()
    '    Dim rect As RectangleF = New RectangleF(e.Bounds.X, e.Bounds.Y + 6, e.Bounds.Width, e.Bounds.Height)
    '    format.Alignment = StringAlignment.Center
    '    e.Graphics.DrawString(TabControl1.TabPages(e.Index).Text, TabControl1.Font, foreBrush, rect, format)
    'End Sub

#End Region


End Class
