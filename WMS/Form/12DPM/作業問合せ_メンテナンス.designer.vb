<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 作業問合せ_メンテナンス
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.dgvZone = New System.Windows.Forms.DataGridView()
        Me.ColゾーンNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col容器番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col出荷指示No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col作業残棚数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgvTana = New System.Windows.Forms.DataGridView()
        Me.Col棚No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col商品名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col規格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col状態 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col出荷指示数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.dgvZone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 12)
        Me.Label2.TabIndex = 354
        Me.Label2.Text = "ゾーンNo"
        '
        'TextBox16
        '
        Me.TextBox16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox16.BackColor = System.Drawing.Color.White
        Me.TextBox16.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(95, 89)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(32, 23)
        Me.TextBox16.TabIndex = 4
        Me.TextBox16.Text = "99"
        '
        'TextBox17
        '
        Me.TextBox17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox17.BackColor = System.Drawing.Color.White
        Me.TextBox17.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(95, 118)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(61, 23)
        Me.TextBox17.TabIndex = 5
        Me.TextBox17.Text = "999999"
        '
        'dgvZone
        '
        Me.dgvZone.AllowUserToAddRows = False
        Me.dgvZone.AllowUserToDeleteRows = False
        Me.dgvZone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvZone.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvZone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvZone.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColゾーンNo, Me.Col容器番号, Me.Col出荷指示No, Me.Col作業残棚数})
        Me.dgvZone.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvZone.Location = New System.Drawing.Point(6, 176)
        Me.dgvZone.MultiSelect = False
        Me.dgvZone.Name = "dgvZone"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvZone.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvZone.RowHeadersVisible = False
        Me.dgvZone.RowHeadersWidth = 20
        Me.dgvZone.RowTemplate.Height = 21
        Me.dgvZone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZone.Size = New System.Drawing.Size(380, 432)
        Me.dgvZone.TabIndex = 0
        '
        'ColゾーンNo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ColゾーンNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColゾーンNo.HeaderText = "ゾーンNo"
        Me.ColゾーンNo.Name = "ColゾーンNo"
        Me.ColゾーンNo.ReadOnly = True
        Me.ColゾーンNo.Width = 80
        '
        'Col容器番号
        '
        Me.Col容器番号.FillWeight = 80.0!
        Me.Col容器番号.HeaderText = "容器番号"
        Me.Col容器番号.Name = "Col容器番号"
        Me.Col容器番号.Width = 80
        '
        'Col出荷指示No
        '
        Me.Col出荷指示No.HeaderText = "出荷指示No"
        Me.Col出荷指示No.Name = "Col出荷指示No"
        Me.Col出荷指示No.ReadOnly = True
        Me.Col出荷指示No.Width = 101
        '
        'Col作業残棚数
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col作業残棚数.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col作業残棚数.HeaderText = "作業残棚数"
        Me.Col作業残棚数.Name = "Col作業残棚数"
        Me.Col作業残棚数.ReadOnly = True
        Me.Col作業残棚数.Width = 101
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(18, 125)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 12)
        Me.Label18.TabIndex = 420
        Me.Label18.Text = "容器番号"
        '
        'dgvTana
        '
        Me.dgvTana.AllowUserToAddRows = False
        Me.dgvTana.AllowUserToDeleteRows = False
        Me.dgvTana.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTana.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTana.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col棚No, Me.Col商品名, Me.Col規格, Me.Col状態, Me.Col出荷指示数})
        Me.dgvTana.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvTana.Location = New System.Drawing.Point(408, 176)
        Me.dgvTana.MultiSelect = False
        Me.dgvTana.Name = "dgvTana"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTana.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvTana.RowHeadersVisible = False
        Me.dgvTana.RowHeadersWidth = 20
        Me.dgvTana.RowTemplate.Height = 21
        Me.dgvTana.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTana.Size = New System.Drawing.Size(595, 432)
        Me.dgvTana.TabIndex = 7
        '
        'Col棚No
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Col棚No.DefaultCellStyle = DataGridViewCellStyle6
        Me.Col棚No.FillWeight = 80.0!
        Me.Col棚No.HeaderText = "棚No"
        Me.Col棚No.Name = "Col棚No"
        Me.Col棚No.ReadOnly = True
        Me.Col棚No.Width = 80
        '
        'Col商品名
        '
        Me.Col商品名.FillWeight = 150.0!
        Me.Col商品名.HeaderText = "商品名"
        Me.Col商品名.Name = "Col商品名"
        Me.Col商品名.ReadOnly = True
        Me.Col商品名.Width = 300
        '
        'Col規格
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col規格.DefaultCellStyle = DataGridViewCellStyle7
        Me.Col規格.FillWeight = 80.0!
        Me.Col規格.HeaderText = "規格"
        Me.Col規格.Name = "Col規格"
        Me.Col規格.ReadOnly = True
        Me.Col規格.Width = 120
        '
        'Col状態
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col状態.DefaultCellStyle = DataGridViewCellStyle8
        Me.Col状態.FillWeight = 80.0!
        Me.Col状態.HeaderText = "状態"
        Me.Col状態.Name = "Col状態"
        Me.Col状態.ReadOnly = True
        Me.Col状態.Width = 60
        '
        'Col出荷指示数
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col出荷指示数.DefaultCellStyle = DataGridViewCellStyle9
        Me.Col出荷指示数.FillWeight = 80.0!
        Me.Col出荷指示数.HeaderText = "出荷指示数"
        Me.Col出荷指示数.Name = "Col出荷指示数"
        Me.Col出荷指示数.ReadOnly = True
        Me.Col出荷指示数.Width = 101
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 12)
        Me.Label3.TabIndex = 423
        Me.Label3.Text = "ラインNo"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(94, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(44, 24)
        Me.ComboBox1.TabIndex = 424
        Me.ComboBox1.Text = "9"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 12)
        Me.Label4.TabIndex = 426
        Me.Label4.Text = "出荷指示No"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(95, 147)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(95, 23)
        Me.TextBox2.TabIndex = 425
        Me.TextBox2.Text = "9999999999"
        '
        '作業問合せ_メンテナンス
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvTana)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dgvZone)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "作業問合せ_メンテナンス"
        Me.Text = "作業問合せ_メンテナンス"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TextBox16, 0)
        Me.Controls.SetChildIndex(Me.TextBox17, 0)
        Me.Controls.SetChildIndex(Me.dgvZone, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.dgvTana, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.dgvZone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents dgvZone As System.Windows.Forms.DataGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dgvTana As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Col棚No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col商品名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col規格 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col状態 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col出荷指示数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColゾーンNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col容器番号 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col出荷指示No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col作業残棚数 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
