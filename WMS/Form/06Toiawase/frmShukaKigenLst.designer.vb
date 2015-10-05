<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShukaKigenLst
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
        Me.dgvSyuKigen = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.bt共通商品コード一覧 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.col出荷期限 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col共通商品コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col商品名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col格納倉庫 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col棚No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予約区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col数量 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col賞味期限 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColﾛｯﾄNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col入荷日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col初回入荷日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予約理由 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col規格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSyuKigen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSyuKigen
        '
        Me.dgvSyuKigen.AllowUserToAddRows = False
        Me.dgvSyuKigen.AllowUserToDeleteRows = False
        Me.dgvSyuKigen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSyuKigen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSyuKigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSyuKigen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col出荷期限, Me.Col共通商品コード, Me.Col商品名, Me.col格納倉庫, Me.Col棚No, Me.col予約区分, Me.Col数量, Me.Col賞味期限, Me.ColﾛｯﾄNo, Me.Col入荷日, Me.col初回入荷日, Me.col備考, Me.col予約理由, Me.Col規格})
        Me.dgvSyuKigen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSyuKigen.Location = New System.Drawing.Point(6, 136)
        Me.dgvSyuKigen.MultiSelect = False
        Me.dgvSyuKigen.Name = "dgvSyuKigen"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSyuKigen.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSyuKigen.RowHeadersVisible = False
        Me.dgvSyuKigen.RowHeadersWidth = 20
        Me.dgvSyuKigen.RowTemplate.Height = 21
        Me.dgvSyuKigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSyuKigen.Size = New System.Drawing.Size(980, 482)
        Me.dgvSyuKigen.TabIndex = 334
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(51, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 12)
        Me.Label10.TabIndex = 330
        Me.Label10.Text = "期限区分"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(173, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(108, 19)
        Me.TextBox2.TabIndex = 371
        Me.TextBox2.Text = "1234567890123456"
        '
        'bt共通商品コード一覧
        '
        Me.bt共通商品コード一覧.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt共通商品コード一覧.Location = New System.Drawing.Point(41, 78)
        Me.bt共通商品コード一覧.Name = "bt共通商品コード一覧"
        Me.bt共通商品コード一覧.Size = New System.Drawing.Size(100, 25)
        Me.bt共通商品コード一覧.TabIndex = 370
        Me.bt共通商品コード一覧.Text = "共通商品コード"
        Me.bt共通商品コード一覧.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(552, 106)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(156, 19)
        Me.TextBox4.TabIndex = 400
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "規格規格規格規格規格規格"
        '
        'TextBox20
        '
        Me.TextBox20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox20.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox20.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(173, 106)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = True
        Me.TextBox20.Size = New System.Drawing.Size(373, 19)
        Me.TextBox20.TabIndex = 399
        Me.TextBox20.TabStop = False
        Me.TextBox20.Text = "商品名商品名商品名商品名商品名商品名商品名商品名商品名商品名"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton12)
        Me.GroupBox4.Controls.Add(Me.RadioButton13)
        Me.GroupBox4.Location = New System.Drawing.Point(287, 74)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(174, 26)
        Me.GroupBox4.TabIndex = 401
        Me.GroupBox4.TabStop = False
        '
        'RadioButton12
        '
        Me.RadioButton12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(90, 9)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton12.TabIndex = 1
        Me.RadioButton12.Text = "前方一致"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Checked = True
        Me.RadioButton13.Location = New System.Drawing.Point(10, 9)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton13.TabIndex = 0
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "完全一致"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(253, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 12)
        Me.Label3.TabIndex = 406
        Me.Label3.Text = "に出荷期限切れ"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(173, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(78, 19)
        Me.TextBox1.TabIndex = 407
        Me.TextBox1.Text = "YYYY/MM/DD"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(475, 84)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 16)
        Me.CheckBox1.TabIndex = 408
        Me.CheckBox1.Text = "JAN検索"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'col出荷期限
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col出荷期限.DefaultCellStyle = DataGridViewCellStyle2
        Me.col出荷期限.FillWeight = 40.0!
        Me.col出荷期限.HeaderText = "出荷期限"
        Me.col出荷期限.Name = "col出荷期限"
        Me.col出荷期限.ReadOnly = True
        '
        'Col共通商品コード
        '
        Me.Col共通商品コード.FillWeight = 60.0!
        Me.Col共通商品コード.HeaderText = "共通商品コード"
        Me.Col共通商品コード.Name = "Col共通商品コード"
        Me.Col共通商品コード.ReadOnly = True
        Me.Col共通商品コード.Width = 120
        '
        'Col商品名
        '
        Me.Col商品名.FillWeight = 80.0!
        Me.Col商品名.HeaderText = "商品名"
        Me.Col商品名.Name = "Col商品名"
        Me.Col商品名.ReadOnly = True
        Me.Col商品名.Width = 300
        '
        'col格納倉庫
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col格納倉庫.DefaultCellStyle = DataGridViewCellStyle3
        Me.col格納倉庫.HeaderText = "格納倉庫"
        Me.col格納倉庫.Name = "col格納倉庫"
        '
        'Col棚No
        '
        Me.Col棚No.FillWeight = 60.0!
        Me.Col棚No.HeaderText = "棚No"
        Me.Col棚No.Name = "Col棚No"
        Me.Col棚No.ReadOnly = True
        '
        'col予約区分
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col予約区分.DefaultCellStyle = DataGridViewCellStyle4
        Me.col予約区分.HeaderText = "予約区分"
        Me.col予約区分.Name = "col予約区分"
        Me.col予約区分.Width = 80
        '
        'Col数量
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col数量.DefaultCellStyle = DataGridViewCellStyle5
        Me.Col数量.FillWeight = 40.20141!
        Me.Col数量.HeaderText = "数量"
        Me.Col数量.Name = "Col数量"
        Me.Col数量.ReadOnly = True
        Me.Col数量.Width = 90
        '
        'Col賞味期限
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col賞味期限.DefaultCellStyle = DataGridViewCellStyle6
        Me.Col賞味期限.HeaderText = "賞味期限"
        Me.Col賞味期限.Name = "Col賞味期限"
        Me.Col賞味期限.ReadOnly = True
        Me.Col賞味期限.Width = 90
        '
        'ColﾛｯﾄNo
        '
        Me.ColﾛｯﾄNo.HeaderText = "ﾛｯﾄNo"
        Me.ColﾛｯﾄNo.Name = "ColﾛｯﾄNo"
        Me.ColﾛｯﾄNo.ReadOnly = True
        Me.ColﾛｯﾄNo.Width = 80
        '
        'Col入荷日
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col入荷日.DefaultCellStyle = DataGridViewCellStyle7
        Me.Col入荷日.HeaderText = "入荷日"
        Me.Col入荷日.Name = "Col入荷日"
        Me.Col入荷日.ReadOnly = True
        Me.Col入荷日.Width = 80
        '
        'col初回入荷日
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col初回入荷日.DefaultCellStyle = DataGridViewCellStyle8
        Me.col初回入荷日.HeaderText = "初回入荷日"
        Me.col初回入荷日.Name = "col初回入荷日"
        '
        'col備考
        '
        Me.col備考.HeaderText = "備考"
        Me.col備考.Name = "col備考"
        Me.col備考.Width = 300
        '
        'col予約理由
        '
        Me.col予約理由.HeaderText = "予約理由"
        Me.col予約理由.Name = "col予約理由"
        Me.col予約理由.Width = 300
        '
        'Col規格
        '
        Me.Col規格.FillWeight = 50.0!
        Me.Col規格.HeaderText = "規格"
        Me.Col規格.Name = "Col規格"
        Me.Col規格.ReadOnly = True
        Me.Col規格.Width = 120
        '
        '出荷期限問合せ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.bt共通商品コード一覧)
        Me.Controls.Add(Me.dgvSyuKigen)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "出荷期限問合せ"
        Me.Text = "出荷期限問合せ"
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.dgvSyuKigen, 0)
        Me.Controls.SetChildIndex(Me.bt共通商品コード一覧, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.TextBox20, 0)
        Me.Controls.SetChildIndex(Me.TextBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        CType(Me.dgvSyuKigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSyuKigen As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents bt共通商品コード一覧 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton13 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents col出荷期限 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col共通商品コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col商品名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col格納倉庫 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col棚No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col予約区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col数量 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col賞味期限 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColﾛｯﾄNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col入荷日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col初回入荷日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col備考 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col予約理由 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col規格 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
