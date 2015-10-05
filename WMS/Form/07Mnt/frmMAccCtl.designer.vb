<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMAccCtl
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvJiyuu = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.colGamenNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLvl1Kbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLvl2Kbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLvl3Kbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLvl4Kbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLvl5Kbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLvl6Kbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLvl7Kbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLvl8Kbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLvl9Kbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvJiyuu,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox3.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'dgvJiyuu
        '
        Me.dgvJiyuu.AllowUserToAddRows = false
        Me.dgvJiyuu.AllowUserToDeleteRows = false
        Me.dgvJiyuu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvJiyuu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvJiyuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJiyuu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colGamenNm, Me.colLvl1Kbn, Me.colLvl2Kbn, Me.colLvl3Kbn, Me.colLvl4Kbn, Me.colLvl5Kbn, Me.colLvl6Kbn, Me.colLvl7Kbn, Me.colLvl8Kbn, Me.colLvl9Kbn})
        Me.dgvJiyuu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvJiyuu.Location = New System.Drawing.Point(96, 88)
        Me.dgvJiyuu.MultiSelect = false
        Me.dgvJiyuu.Name = "dgvJiyuu"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvJiyuu.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvJiyuu.RowHeadersVisible = false
        Me.dgvJiyuu.RowHeadersWidth = 20
        Me.dgvJiyuu.RowTemplate.Height = 21
        Me.dgvJiyuu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJiyuu.Size = New System.Drawing.Size(816, 392)
        Me.dgvJiyuu.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 12)
        Me.Label2.TabIndex = 416
        Me.Label2.Text = "アクセス権"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.TextBox3.Location = New System.Drawing.Point(82, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = true
        Me.TextBox3.Size = New System.Drawing.Size(207, 19)
        Me.TextBox3.TabIndex = 413
        Me.TextBox3.TabStop = false
        Me.TextBox3.Text = "あいうえおかきくけこさしすせそ"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 12)
        Me.Label3.TabIndex = 412
        Me.Label3.Text = "画面名称"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 12)
        Me.Label1.TabIndex = 407
        Me.Label1.Text = "画面名称"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(116, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 20)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "画面アクセスメンテナンス"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.CheckBox4)
        Me.GroupBox3.Controls.Add(Me.CheckBox10)
        Me.GroupBox3.Controls.Add(Me.CheckBox11)
        Me.GroupBox3.Controls.Add(Me.CheckBox12)
        Me.GroupBox3.Controls.Add(Me.CheckBox13)
        Me.GroupBox3.Controls.Add(Me.CheckBox14)
        Me.GroupBox3.Location = New System.Drawing.Point(82, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(511, 60)
        Me.GroupBox3.TabIndex = 417
        Me.GroupBox3.TabStop = false
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = true
        Me.CheckBox1.Checked = true
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(326, 37)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(57, 16)
        Me.CheckBox1.TabIndex = 319
        Me.CheckBox1.Text = "予備4"
        Me.CheckBox1.UseVisualStyleBackColor = true
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = true
        Me.CheckBox2.Checked = true
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(211, 37)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(57, 16)
        Me.CheckBox2.TabIndex = 318
        Me.CheckBox2.Text = "予備3"
        Me.CheckBox2.UseVisualStyleBackColor = true
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = true
        Me.CheckBox3.Checked = true
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(113, 38)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(57, 16)
        Me.CheckBox3.TabIndex = 317
        Me.CheckBox3.Text = "予備2"
        Me.CheckBox3.UseVisualStyleBackColor = true
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = true
        Me.CheckBox4.Checked = true
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(11, 38)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(57, 16)
        Me.CheckBox4.TabIndex = 316
        Me.CheckBox4.Text = "予備1"
        Me.CheckBox4.UseVisualStyleBackColor = true
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = true
        Me.CheckBox10.Checked = true
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.CheckBox10.Location = New System.Drawing.Point(434, 13)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(50, 16)
        Me.CheckBox10.TabIndex = 315
        Me.CheckBox10.Text = "物流"
        Me.CheckBox10.UseVisualStyleBackColor = true
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = true
        Me.CheckBox11.Checked = true
        Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox11.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.CheckBox11.Location = New System.Drawing.Point(326, 13)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(63, 16)
        Me.CheckBox11.TabIndex = 314
        Me.CheckBox11.Text = "他部署"
        Me.CheckBox11.UseVisualStyleBackColor = true
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = true
        Me.CheckBox12.Checked = true
        Me.CheckBox12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox12.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.CheckBox12.Location = New System.Drawing.Point(211, 13)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(75, 16)
        Me.CheckBox12.TabIndex = 313
        Me.CheckBox12.Text = "オペレータ"
        Me.CheckBox12.UseVisualStyleBackColor = true
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = true
        Me.CheckBox13.Checked = true
        Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox13.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.CheckBox13.Location = New System.Drawing.Point(113, 14)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(64, 16)
        Me.CheckBox13.TabIndex = 312
        Me.CheckBox13.Text = "リーダー"
        Me.CheckBox13.UseVisualStyleBackColor = true
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = true
        Me.CheckBox14.Checked = true
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox14.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.CheckBox14.Location = New System.Drawing.Point(11, 14)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(63, 16)
        Me.CheckBox14.TabIndex = 311
        Me.CheckBox14.Text = "管理者"
        Me.CheckBox14.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 486)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 120)
        Me.GroupBox1.TabIndex = 418
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "入力"
        '
        'colGamenNm
        '
        Me.colGamenNm.HeaderText = "画面名称"
        Me.colGamenNm.Name = "colGamenNm"
        Me.colGamenNm.ReadOnly = true
        Me.colGamenNm.Width = 250
        '
        'colLvl1Kbn
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLvl1Kbn.DefaultCellStyle = DataGridViewCellStyle2
        Me.colLvl1Kbn.FillWeight = 40!
        Me.colLvl1Kbn.HeaderText = "管理者"
        Me.colLvl1Kbn.Name = "colLvl1Kbn"
        Me.colLvl1Kbn.ReadOnly = true
        Me.colLvl1Kbn.Width = 65
        '
        'colLvl2Kbn
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLvl2Kbn.DefaultCellStyle = DataGridViewCellStyle3
        Me.colLvl2Kbn.HeaderText = "ﾘｰﾀﾞｰ"
        Me.colLvl2Kbn.Name = "colLvl2Kbn"
        Me.colLvl2Kbn.Width = 60
        '
        'colLvl3Kbn
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLvl3Kbn.DefaultCellStyle = DataGridViewCellStyle4
        Me.colLvl3Kbn.HeaderText = "ｵﾍﾟﾚｰﾀ"
        Me.colLvl3Kbn.Name = "colLvl3Kbn"
        Me.colLvl3Kbn.Width = 60
        '
        'colLvl4Kbn
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLvl4Kbn.DefaultCellStyle = DataGridViewCellStyle5
        Me.colLvl4Kbn.HeaderText = "他部署"
        Me.colLvl4Kbn.Name = "colLvl4Kbn"
        Me.colLvl4Kbn.Width = 65
        '
        'colLvl5Kbn
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLvl5Kbn.DefaultCellStyle = DataGridViewCellStyle6
        Me.colLvl5Kbn.HeaderText = "物流"
        Me.colLvl5Kbn.Name = "colLvl5Kbn"
        Me.colLvl5Kbn.Width = 60
        '
        'colLvl6Kbn
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLvl6Kbn.DefaultCellStyle = DataGridViewCellStyle7
        Me.colLvl6Kbn.HeaderText = "予備1"
        Me.colLvl6Kbn.Name = "colLvl6Kbn"
        Me.colLvl6Kbn.Width = 60
        '
        'colLvl7Kbn
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLvl7Kbn.DefaultCellStyle = DataGridViewCellStyle8
        Me.colLvl7Kbn.HeaderText = "予備2"
        Me.colLvl7Kbn.Name = "colLvl7Kbn"
        Me.colLvl7Kbn.Width = 60
        '
        'colLvl8Kbn
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLvl8Kbn.DefaultCellStyle = DataGridViewCellStyle9
        Me.colLvl8Kbn.HeaderText = "予備3"
        Me.colLvl8Kbn.Name = "colLvl8Kbn"
        Me.colLvl8Kbn.Width = 60
        '
        'colLvl9Kbn
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLvl9Kbn.DefaultCellStyle = DataGridViewCellStyle10
        Me.colLvl9Kbn.HeaderText = "予備4"
        Me.colLvl9Kbn.Name = "colLvl9Kbn"
        Me.colLvl9Kbn.Width = 60
        '
        'frmMAccCtl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = true
        Me.Controls.Add(Me.dgvJiyuu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = true
        Me.MinimizeBox = true
        Me.Name = "frmMAccCtl"
        Me.Text = "画面アクセスメンテナンス"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.dgvJiyuu, 0)
        CType(Me.dgvJiyuu,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents dgvJiyuu As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents colGamenNm As DataGridViewTextBoxColumn
    Friend WithEvents colLvl1Kbn As DataGridViewTextBoxColumn
    Friend WithEvents colLvl2Kbn As DataGridViewTextBoxColumn
    Friend WithEvents colLvl3Kbn As DataGridViewTextBoxColumn
    Friend WithEvents colLvl4Kbn As DataGridViewTextBoxColumn
    Friend WithEvents colLvl5Kbn As DataGridViewTextBoxColumn
    Friend WithEvents colLvl6Kbn As DataGridViewTextBoxColumn
    Friend WithEvents colLvl7Kbn As DataGridViewTextBoxColumn
    Friend WithEvents colLvl8Kbn As DataGridViewTextBoxColumn
    Friend WithEvents colLvl9Kbn As DataGridViewTextBoxColumn
End Class
