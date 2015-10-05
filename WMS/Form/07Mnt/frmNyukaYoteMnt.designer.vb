<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNyukaYoteMnt
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvNyuka = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnKyotuHinCd = New System.Windows.Forms.Button()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.colLoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKyotuHinCd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHinNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKanrenKaishaCd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKikaku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSyomiYmd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLotNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colZaikoSuu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNyuYmd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHinKanriKbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNinusiKbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colZaikoYoyakuKbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvNyuka,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'dgvNyuka
        '
        Me.dgvNyuka.AllowUserToAddRows = false
        Me.dgvNyuka.AllowUserToDeleteRows = false
        Me.dgvNyuka.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNyuka.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNyuka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNyuka.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLoc, Me.colKyotuHinCd, Me.colHinNm, Me.colKanrenKaishaCd, Me.colKikaku, Me.colSyomiYmd, Me.colLotNo, Me.colZaikoSuu, Me.colNyuYmd, Me.colHinKanriKbn, Me.colNinusiKbn, Me.colZaikoYoyakuKbn})
        Me.dgvNyuka.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvNyuka.Location = New System.Drawing.Point(9, 73)
        Me.dgvNyuka.MultiSelect = false
        Me.dgvNyuka.Name = "dgvNyuka"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNyuka.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvNyuka.RowHeadersVisible = false
        Me.dgvNyuka.RowHeadersWidth = 20
        Me.dgvNyuka.RowTemplate.Height = 21
        Me.dgvNyuka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNyuka.Size = New System.Drawing.Size(997, 385)
        Me.dgvNyuka.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 12)
        Me.Label2.TabIndex = 325
        Me.Label2.Text = "入荷予定日"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox6.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox6.Location = New System.Drawing.Point(363, 97)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = true
        Me.TextBox6.Size = New System.Drawing.Size(136, 19)
        Me.TextBox6.TabIndex = 415
        Me.TextBox6.TabStop = false
        Me.TextBox6.Text = "あいうえおかきくけこ"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox5.Location = New System.Drawing.Point(120, 97)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = true
        Me.TextBox5.Size = New System.Drawing.Size(136, 19)
        Me.TextBox5.TabIndex = 414
        Me.TextBox5.TabStop = false
        Me.TextBox5.Text = "あいうえおかきくけこ"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox3.Location = New System.Drawing.Point(204, 38)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = true
        Me.TextBox3.Size = New System.Drawing.Size(205, 19)
        Me.TextBox3.TabIndex = 413
        Me.TextBox3.TabStop = false
        Me.TextBox3.Text = "あいうえおかきくけこさしすせそ"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(120, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(78, 19)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "999999"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 12)
        Me.Label3.TabIndex = 412
        Me.Label3.Text = "入荷先コード"
        '
        'TextBox23
        '
        Me.TextBox23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox23.BackColor = System.Drawing.Color.White
        Me.TextBox23.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox23.Location = New System.Drawing.Point(120, 126)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(90, 19)
        Me.TextBox23.TabIndex = 4
        Me.TextBox23.Text = "12,3456,78.99"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = true
        Me.Label15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 129)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 12)
        Me.Label15.TabIndex = 329
        Me.Label15.Text = "入荷予定数"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label12.Location = New System.Drawing.Point(313, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 12)
        Me.Label12.TabIndex = 342
        Me.Label12.Text = "備考２"
        '
        'TextBox14
        '
        Me.TextBox14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox14.BackColor = System.Drawing.Color.White
        Me.TextBox14.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox14.Location = New System.Drawing.Point(120, 12)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(78, 19)
        Me.TextBox14.TabIndex = 0
        Me.TextBox14.Text = "2015/06/30"
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 12)
        Me.Label9.TabIndex = 333
        Me.Label9.Text = "入荷予定日"
        '
        'btnKyotuHinCd
        '
        Me.btnKyotuHinCd.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnKyotuHinCd.Location = New System.Drawing.Point(9, 64)
        Me.btnKyotuHinCd.Name = "btnKyotuHinCd"
        Me.btnKyotuHinCd.Size = New System.Drawing.Size(100, 25)
        Me.btnKyotuHinCd.TabIndex = 2
        Me.btnKyotuHinCd.Text = "共通商品コード"
        Me.btnKyotuHinCd.UseVisualStyleBackColor = true
        '
        'TextBox13
        '
        Me.TextBox13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox13.BackColor = System.Drawing.Color.White
        Me.TextBox13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox13.Location = New System.Drawing.Point(120, 67)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(108, 19)
        Me.TextBox13.TabIndex = 3
        Me.TextBox13.Text = "1234567890123456"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 12)
        Me.Label11.TabIndex = 329
        Me.Label11.Text = "備考１"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 12)
        Me.Label1.TabIndex = 407
        Me.Label1.Text = "入荷先コード"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label7.Location = New System.Drawing.Point(429, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 12)
        Me.Label7.TabIndex = 408
        Me.Label7.Text = "入荷予定No"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox2.Location = New System.Drawing.Point(331, 47)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(78, 19)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "999999"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox4.Location = New System.Drawing.Point(508, 48)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(78, 19)
        Me.TextBox4.TabIndex = 2
        Me.TextBox4.Text = "99999999"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 46)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 19)
        Me.DateTimePicker1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox20)
        Me.GroupBox1.Controls.Add(Me.TextBox21)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.btnKyotuHinCd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TextBox23)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 464)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(983, 154)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "入力"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = true
        Me.CheckBox1.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(781, 69)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 16)
        Me.CheckBox1.TabIndex = 504
        Me.CheckBox1.Text = "JAN検索"
        Me.CheckBox1.UseVisualStyleBackColor = true
        '
        'TextBox20
        '
        Me.TextBox20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox20.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox20.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox20.Location = New System.Drawing.Point(611, 67)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = true
        Me.TextBox20.Size = New System.Drawing.Size(159, 19)
        Me.TextBox20.TabIndex = 417
        Me.TextBox20.TabStop = false
        Me.TextBox20.Text = "規格規格規格規格規格規格"
        '
        'TextBox21
        '
        Me.TextBox21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox21.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox21.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox21.Location = New System.Drawing.Point(234, 67)
        Me.TextBox21.MaxLength = 60
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ReadOnly = true
        Me.TextBox21.Size = New System.Drawing.Size(371, 19)
        Me.TextBox21.TabIndex = 416
        Me.TextBox21.TabStop = false
        Me.TextBox21.Text = "商品名商品名商品名商品名商品名商品名商品名商品名商品名商品名"
        '
        'colLoc
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLoc.DefaultCellStyle = DataGridViewCellStyle2
        Me.colLoc.HeaderText = "棚No"
        Me.colLoc.Name = "colLoc"
        Me.colLoc.ReadOnly = true
        Me.colLoc.Width = 80
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
        'colSyomiYmd
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.colSyomiYmd.DefaultCellStyle = DataGridViewCellStyle6
        Me.colSyomiYmd.FillWeight = 52.46462!
        Me.colSyomiYmd.HeaderText = "賞味期限"
        Me.colSyomiYmd.Name = "colSyomiYmd"
        Me.colSyomiYmd.ReadOnly = true
        Me.colSyomiYmd.Width = 80
        '
        'colLotNo
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colLotNo.DefaultCellStyle = DataGridViewCellStyle7
        Me.colLotNo.FillWeight = 136.9782!
        Me.colLotNo.HeaderText = "ﾛｯﾄNo"
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.ReadOnly = true
        Me.colLotNo.Width = 70
        '
        'colZaikoSuu
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colZaikoSuu.DefaultCellStyle = DataGridViewCellStyle8
        Me.colZaikoSuu.FillWeight = 78.95775!
        Me.colZaikoSuu.HeaderText = "在庫数"
        Me.colZaikoSuu.Name = "colZaikoSuu"
        Me.colZaikoSuu.ReadOnly = true
        '
        'colNyuYmd
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNyuYmd.DefaultCellStyle = DataGridViewCellStyle9
        Me.colNyuYmd.HeaderText = "入荷日"
        Me.colNyuYmd.Name = "colNyuYmd"
        Me.colNyuYmd.ReadOnly = true
        Me.colNyuYmd.Width = 80
        '
        'colHinKanriKbn
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colHinKanriKbn.DefaultCellStyle = DataGridViewCellStyle10
        Me.colHinKanriKbn.FillWeight = 45!
        Me.colHinKanriKbn.HeaderText = "品質区分"
        Me.colHinKanriKbn.Name = "colHinKanriKbn"
        Me.colHinKanriKbn.ReadOnly = true
        Me.colHinKanriKbn.Width = 80
        '
        'colNinusiKbn
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNinusiKbn.DefaultCellStyle = DataGridViewCellStyle11
        Me.colNinusiKbn.FillWeight = 43.38193!
        Me.colNinusiKbn.HeaderText = "荷主区分"
        Me.colNinusiKbn.Name = "colNinusiKbn"
        Me.colNinusiKbn.ReadOnly = true
        Me.colNinusiKbn.Width = 80
        '
        'colZaikoYoyakuKbn
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colZaikoYoyakuKbn.DefaultCellStyle = DataGridViewCellStyle12
        Me.colZaikoYoyakuKbn.FillWeight = 80!
        Me.colZaikoYoyakuKbn.HeaderText = "予約区分"
        Me.colZaikoYoyakuKbn.Name = "colZaikoYoyakuKbn"
        Me.colZaikoYoyakuKbn.ReadOnly = true
        Me.colZaikoYoyakuKbn.Width = 80
        '
        'frmNyukaYoteMnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = true
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvNyuka)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = true
        Me.MinimizeBox = true
        Me.Name = "frmNyukaYoteMnt"
        Me.Text = "入荷予定データメンテナンス"
        Me.Controls.SetChildIndex(Me.dgvNyuka, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.TextBox4, 0)
        Me.Controls.SetChildIndex(Me.DateTimePicker1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        CType(Me.dgvNyuka,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents dgvNyuka As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnKyotuHinCd As System.Windows.Forms.Button
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents colLoc As DataGridViewTextBoxColumn
    Friend WithEvents colKyotuHinCd As DataGridViewTextBoxColumn
    Friend WithEvents colHinNm As DataGridViewTextBoxColumn
    Friend WithEvents colKanrenKaishaCd As DataGridViewTextBoxColumn
    Friend WithEvents colKikaku As DataGridViewTextBoxColumn
    Friend WithEvents colSyomiYmd As DataGridViewTextBoxColumn
    Friend WithEvents colLotNo As DataGridViewTextBoxColumn
    Friend WithEvents colZaikoSuu As DataGridViewTextBoxColumn
    Friend WithEvents colNyuYmd As DataGridViewTextBoxColumn
    Friend WithEvents colHinKanriKbn As DataGridViewTextBoxColumn
    Friend WithEvents colNinusiKbn As DataGridViewTextBoxColumn
    Friend WithEvents colZaikoYoyakuKbn As DataGridViewTextBoxColumn
End Class
