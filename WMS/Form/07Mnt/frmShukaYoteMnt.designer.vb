<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShukaYoteMnt
    'Inherits System.Windows.Forms.Form
    Inherits WMS.C01Standard


    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSyuka = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.colSyuSijiNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNonyuCd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNonyuNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGyoNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKyotuHinCd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHinNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKanrenKaishaCd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKikaku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colZaikoYoyakuKbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSyuPlanSuu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJucyuMemo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMeisaiMemo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSyuka,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox4.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBox5.SuspendLayout
        Me.GroupBox6.SuspendLayout
        Me.SuspendLayout
        '
        'dgvSyuka
        '
        Me.dgvSyuka.AllowUserToAddRows = false
        Me.dgvSyuka.AllowUserToDeleteRows = false
        Me.dgvSyuka.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSyuka.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSyuka.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSyuSijiNo, Me.colNonyuCd, Me.colNonyuNm, Me.colGyoNo, Me.colKyotuHinCd, Me.colHinNm, Me.colKanrenKaishaCd, Me.colKikaku, Me.colZaikoYoyakuKbn, Me.colSyuPlanSuu, Me.colJucyuMemo, Me.colMeisaiMemo})
        Me.dgvSyuka.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSyuka.Location = New System.Drawing.Point(9, 108)
        Me.dgvSyuka.MultiSelect = false
        Me.dgvSyuka.Name = "dgvSyuka"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSyuka.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSyuka.RowHeadersVisible = false
        Me.dgvSyuka.RowHeadersWidth = 20
        Me.dgvSyuka.RowTemplate.Height = 21
        Me.dgvSyuka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSyuka.Size = New System.Drawing.Size(997, 199)
        Me.dgvSyuka.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 12)
        Me.Label2.TabIndex = 325
        Me.Label2.Text = "出荷指示日"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox5.Location = New System.Drawing.Point(119, 278)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(391, 19)
        Me.TextBox5.TabIndex = 12
        Me.TextBox5.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほ"
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 281)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 12)
        Me.Label14.TabIndex = 434
        Me.Label14.Text = "明細メモ"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label13.Location = New System.Drawing.Point(351, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 12)
        Me.Label13.TabIndex = 432
        Me.Label13.Text = "同一ロット区分"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton9)
        Me.GroupBox4.Controls.Add(Me.RadioButton10)
        Me.GroupBox4.Location = New System.Drawing.Point(454, 211)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(203, 40)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = false
        '
        'RadioButton9
        '
        Me.RadioButton9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.RadioButton9.AutoSize = true
        Me.RadioButton9.Checked = true
        Me.RadioButton9.Location = New System.Drawing.Point(9, 15)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton9.TabIndex = 0
        Me.RadioButton9.TabStop = true
        Me.RadioButton9.Text = "有効"
        Me.RadioButton9.UseVisualStyleBackColor = true
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = true
        Me.RadioButton10.Location = New System.Drawing.Point(99, 15)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton10.TabIndex = 1
        Me.RadioButton10.Text = "無効"
        Me.RadioButton10.UseVisualStyleBackColor = true
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 12)
        Me.Label12.TabIndex = 430
        Me.Label12.Text = "同一賞味期限区分"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Controls.Add(Me.RadioButton8)
        Me.GroupBox3.Location = New System.Drawing.Point(119, 211)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 40)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = false
        '
        'RadioButton5
        '
        Me.RadioButton5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.RadioButton5.AutoSize = true
        Me.RadioButton5.Checked = true
        Me.RadioButton5.Location = New System.Drawing.Point(9, 15)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton5.TabIndex = 0
        Me.RadioButton5.TabStop = true
        Me.RadioButton5.Text = "有効"
        Me.RadioButton5.UseVisualStyleBackColor = true
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = true
        Me.RadioButton8.Location = New System.Drawing.Point(99, 15)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton8.TabIndex = 1
        Me.RadioButton8.Text = "無効"
        Me.RadioButton8.UseVisualStyleBackColor = true
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 12)
        Me.Label11.TabIndex = 428
        Me.Label11.Text = "予約区分"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Location = New System.Drawing.Point(119, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 40)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = false
        '
        'RadioButton6
        '
        Me.RadioButton6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.RadioButton6.AutoSize = true
        Me.RadioButton6.Checked = true
        Me.RadioButton6.Location = New System.Drawing.Point(9, 15)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(66, 16)
        Me.RadioButton6.TabIndex = 0
        Me.RadioButton6.TabStop = true
        Me.RadioButton6.Text = "予約なし"
        Me.RadioButton6.UseVisualStyleBackColor = true
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = true
        Me.RadioButton7.Location = New System.Drawing.Point(99, 15)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(65, 16)
        Me.RadioButton7.TabIndex = 1
        Me.RadioButton7.Text = "予約あり"
        Me.RadioButton7.UseVisualStyleBackColor = true
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox11.Location = New System.Drawing.Point(119, 126)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(538, 19)
        Me.TextBox11.TabIndex = 5
        Me.TextBox11.Text = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゐゆゑよらりる"
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 12)
        Me.Label10.TabIndex = 426
        Me.Label10.Text = "受注メモ"
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox10.Location = New System.Drawing.Point(280, 101)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(40, 19)
        Me.TextBox10.TabIndex = 4
        Me.TextBox10.Text = "999"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label8.Location = New System.Drawing.Point(236, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 12)
        Me.Label8.TabIndex = 424
        Me.Label8.Text = "行No"
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox9.Location = New System.Drawing.Point(119, 101)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(78, 19)
        Me.TextBox9.TabIndex = 3
        Me.TextBox9.Text = "1234567890"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 12)
        Me.Label6.TabIndex = 422
        Me.Label6.Text = "出荷指示No"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 12)
        Me.Label5.TabIndex = 420
        Me.Label5.Text = "出荷指示区分"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Location = New System.Drawing.Point(119, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = true
        Me.RadioButton2.Location = New System.Drawing.Point(130, 15)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(83, 16)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "通販（委託）"
        Me.RadioButton2.UseVisualStyleBackColor = true
        '
        'RadioButton3
        '
        Me.RadioButton3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.RadioButton3.AutoSize = true
        Me.RadioButton3.Checked = true
        Me.RadioButton3.Location = New System.Drawing.Point(9, 15)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.TabStop = true
        Me.RadioButton3.Text = "通販"
        Me.RadioButton3.UseVisualStyleBackColor = true
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = true
        Me.RadioButton4.Location = New System.Drawing.Point(72, 15)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(35, 16)
        Me.RadioButton4.TabIndex = 1
        Me.RadioButton4.Text = "卸"
        Me.RadioButton4.UseVisualStyleBackColor = true
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox3.Location = New System.Drawing.Point(233, 76)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = true
        Me.TextBox3.Size = New System.Drawing.Size(205, 19)
        Me.TextBox3.TabIndex = 413
        Me.TextBox3.TabStop = false
        Me.TextBox3.Text = "出荷先名出荷先名出荷先名出荷先"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(119, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(107, 19)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "1234567890123"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 12)
        Me.Label3.TabIndex = 412
        Me.Label3.Text = "出荷先コード"
        '
        'TextBox23
        '
        Me.TextBox23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox23.BackColor = System.Drawing.Color.White
        Me.TextBox23.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox23.Location = New System.Drawing.Point(119, 254)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(90, 19)
        Me.TextBox23.TabIndex = 11
        Me.TextBox23.Text = "12,3456,78.99"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = true
        Me.Label15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 257)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 12)
        Me.Label15.TabIndex = 329
        Me.Label15.Text = "出荷指示数"
        '
        'TextBox14
        '
        Me.TextBox14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox14.BackColor = System.Drawing.Color.White
        Me.TextBox14.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox14.Location = New System.Drawing.Point(119, 51)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(78, 19)
        Me.TextBox14.TabIndex = 1
        Me.TextBox14.Text = "2015/06/30"
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 12)
        Me.Label9.TabIndex = 333
        Me.Label9.Text = "出荷指示日"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Button3.Location = New System.Drawing.Point(8, 146)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 25)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "共通商品コード"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'TextBox13
        '
        Me.TextBox13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox13.BackColor = System.Drawing.Color.White
        Me.TextBox13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox13.Location = New System.Drawing.Point(119, 149)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(108, 19)
        Me.TextBox13.TabIndex = 7
        Me.TextBox13.Text = "1234567890123456"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label1.Location = New System.Drawing.Point(515, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 12)
        Me.Label1.TabIndex = 407
        Me.Label1.Text = "納品書No"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label7.Location = New System.Drawing.Point(320, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 12)
        Me.Label7.TabIndex = 408
        Me.Label7.Text = "出荷指示No"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox2.Location = New System.Drawing.Point(579, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(78, 19)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "1234567890"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox4.Location = New System.Drawing.Point(397, 82)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(78, 19)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = "1234567890"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(159, 82)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 19)
        Me.DateTimePicker1.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton1)
        Me.GroupBox5.Controls.Add(Me.RadioButton12)
        Me.GroupBox5.Controls.Add(Me.RadioButton13)
        Me.GroupBox5.Location = New System.Drawing.Point(159, 40)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(234, 40)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = false
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = true
        Me.RadioButton1.Location = New System.Drawing.Point(130, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(83, 16)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.Text = "通販（委託）"
        Me.RadioButton1.UseVisualStyleBackColor = true
        '
        'RadioButton12
        '
        Me.RadioButton12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.RadioButton12.AutoSize = true
        Me.RadioButton12.Checked = true
        Me.RadioButton12.Location = New System.Drawing.Point(9, 15)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton12.TabIndex = 6
        Me.RadioButton12.TabStop = true
        Me.RadioButton12.Text = "通販"
        Me.RadioButton12.UseVisualStyleBackColor = true
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = true
        Me.RadioButton13.Location = New System.Drawing.Point(72, 15)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(35, 16)
        Me.RadioButton13.TabIndex = 5
        Me.RadioButton13.Text = "卸"
        Me.RadioButton13.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 12)
        Me.Label4.TabIndex = 418
        Me.Label4.Text = "出荷指示区分"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CheckBox1)
        Me.GroupBox6.Controls.Add(Me.TextBox20)
        Me.GroupBox6.Controls.Add(Me.TextBox21)
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.GroupBox4)
        Me.GroupBox6.Controls.Add(Me.TextBox13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.GroupBox3)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.TextBox14)
        Me.GroupBox6.Controls.Add(Me.GroupBox2)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.TextBox11)
        Me.GroupBox6.Controls.Add(Me.TextBox23)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.TextBox10)
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.TextBox3)
        Me.GroupBox6.Controls.Add(Me.TextBox9)
        Me.GroupBox6.Controls.Add(Me.GroupBox1)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 313)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(983, 305)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = false
        Me.GroupBox6.Text = "入力"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = true
        Me.CheckBox1.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(785, 151)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 16)
        Me.CheckBox1.TabIndex = 437
        Me.CheckBox1.Text = "JAN検索"
        Me.CheckBox1.UseVisualStyleBackColor = true
        '
        'TextBox20
        '
        Me.TextBox20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox20.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox20.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox20.Location = New System.Drawing.Point(610, 149)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = true
        Me.TextBox20.Size = New System.Drawing.Size(159, 19)
        Me.TextBox20.TabIndex = 436
        Me.TextBox20.TabStop = false
        Me.TextBox20.Text = "規格規格規格規格規格規格"
        '
        'TextBox21
        '
        Me.TextBox21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox21.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox21.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox21.Location = New System.Drawing.Point(233, 149)
        Me.TextBox21.MaxLength = 60
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ReadOnly = true
        Me.TextBox21.Size = New System.Drawing.Size(371, 19)
        Me.TextBox21.TabIndex = 435
        Me.TextBox21.TabStop = false
        Me.TextBox21.Text = "商品名商品名商品名商品名商品名商品名商品名商品名商品名商品名"
        '
        'colSyuSijiNo
        '
        Me.colSyuSijiNo.HeaderText = "出荷指示No"
        Me.colSyuSijiNo.Name = "colSyuSijiNo"
        Me.colSyuSijiNo.ReadOnly = true
        '
        'colNonyuCd
        '
        Me.colNonyuCd.HeaderText = "出荷先ｺｰﾄﾞ"
        Me.colNonyuCd.Name = "colNonyuCd"
        Me.colNonyuCd.ReadOnly = true
        '
        'colNonyuNm
        '
        Me.colNonyuNm.HeaderText = "出荷先名称"
        Me.colNonyuNm.Name = "colNonyuNm"
        Me.colNonyuNm.ReadOnly = true
        Me.colNonyuNm.Width = 160
        '
        'colGyoNo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colGyoNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.colGyoNo.FillWeight = 43.38193!
        Me.colGyoNo.HeaderText = "行No"
        Me.colGyoNo.Name = "colGyoNo"
        Me.colGyoNo.ReadOnly = true
        Me.colGyoNo.Width = 40
        '
        'colKyotuHinCd
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.colKyotuHinCd.DefaultCellStyle = DataGridViewCellStyle3
        Me.colKyotuHinCd.FillWeight = 134.3357!
        Me.colKyotuHinCd.HeaderText = "共通商品ｺｰﾄﾞ"
        Me.colKyotuHinCd.Name = "colKyotuHinCd"
        Me.colKyotuHinCd.ReadOnly = true
        Me.colKyotuHinCd.Width = 110
        '
        'colHinNm
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colHinNm.DefaultCellStyle = DataGridViewCellStyle4
        Me.colHinNm.FillWeight = 156.5466!
        Me.colHinNm.HeaderText = "商品名"
        Me.colHinNm.Name = "colHinNm"
        Me.colHinNm.ReadOnly = true
        Me.colHinNm.Width = 160
        '
        'colKanrenKaishaCd
        '
        Me.colKanrenKaishaCd.HeaderText = "関連会社ｺｰﾄﾞ"
        Me.colKanrenKaishaCd.Name = "colKanrenKaishaCd"
        Me.colKanrenKaishaCd.ReadOnly = true
        Me.colKanrenKaishaCd.Width = 110
        '
        'colKikaku
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colKikaku.DefaultCellStyle = DataGridViewCellStyle5
        Me.colKikaku.FillWeight = 37.27981!
        Me.colKikaku.HeaderText = "規格"
        Me.colKikaku.Name = "colKikaku"
        Me.colKikaku.ReadOnly = true
        Me.colKikaku.Width = 120
        '
        'colZaikoYoyakuKbn
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colZaikoYoyakuKbn.DefaultCellStyle = DataGridViewCellStyle6
        Me.colZaikoYoyakuKbn.FillWeight = 80!
        Me.colZaikoYoyakuKbn.HeaderText = "予約区分"
        Me.colZaikoYoyakuKbn.Name = "colZaikoYoyakuKbn"
        Me.colZaikoYoyakuKbn.ReadOnly = true
        Me.colZaikoYoyakuKbn.Width = 80
        '
        'colSyuPlanSuu
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSyuPlanSuu.DefaultCellStyle = DataGridViewCellStyle7
        Me.colSyuPlanSuu.FillWeight = 78.95775!
        Me.colSyuPlanSuu.HeaderText = "出荷指示数量"
        Me.colSyuPlanSuu.Name = "colSyuPlanSuu"
        Me.colSyuPlanSuu.ReadOnly = true
        Me.colSyuPlanSuu.Width = 120
        '
        'colJucyuMemo
        '
        Me.colJucyuMemo.HeaderText = "受注メモ"
        Me.colJucyuMemo.Name = "colJucyuMemo"
        Me.colJucyuMemo.ReadOnly = true
        Me.colJucyuMemo.Width = 600
        '
        'colMeisaiMemo
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colMeisaiMemo.DefaultCellStyle = DataGridViewCellStyle8
        Me.colMeisaiMemo.FillWeight = 45!
        Me.colMeisaiMemo.HeaderText = "明細メモ"
        Me.colMeisaiMemo.Name = "colMeisaiMemo"
        Me.colMeisaiMemo.ReadOnly = true
        Me.colMeisaiMemo.Width = 300
        '
        'frmShukaYoteMnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = true
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvSyuka)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = true
        Me.MinimizeBox = true
        Me.Name = "frmShukaYoteMnt"
        Me.Text = "出荷予定データメンテナンス"
        Me.Controls.SetChildIndex(Me.dgvSyuka, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.TextBox4, 0)
        Me.Controls.SetChildIndex(Me.DateTimePicker1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox5, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox6, 0)
        CType(Me.dgvSyuka,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox5.ResumeLayout(false)
        Me.GroupBox5.PerformLayout
        Me.GroupBox6.ResumeLayout(false)
        Me.GroupBox6.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents dgvSyuka As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton13 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents colSyuSijiNo As DataGridViewTextBoxColumn
    Friend WithEvents colNonyuCd As DataGridViewTextBoxColumn
    Friend WithEvents colNonyuNm As DataGridViewTextBoxColumn
    Friend WithEvents colGyoNo As DataGridViewTextBoxColumn
    Friend WithEvents colKyotuHinCd As DataGridViewTextBoxColumn
    Friend WithEvents colHinNm As DataGridViewTextBoxColumn
    Friend WithEvents colKanrenKaishaCd As DataGridViewTextBoxColumn
    Friend WithEvents colKikaku As DataGridViewTextBoxColumn
    Friend WithEvents colZaikoYoyakuKbn As DataGridViewTextBoxColumn
    Friend WithEvents colSyuPlanSuu As DataGridViewTextBoxColumn
    Friend WithEvents colJucyuMemo As DataGridViewTextBoxColumn
    Friend WithEvents colMeisaiMemo As DataGridViewTextBoxColumn
End Class
