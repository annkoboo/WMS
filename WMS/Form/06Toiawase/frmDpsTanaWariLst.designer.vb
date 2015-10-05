<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDpsTanaWariLst
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDPS = New System.Windows.Forms.DataGridView()
        Me.colゾーン = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col総棚数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col割付棚数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col出荷回数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt表示 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvMeisai = New System.Windows.Forms.DataGridView()
        Me.col棚No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col出荷回数2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMeisai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDPS
        '
        Me.dgvDPS.AllowUserToAddRows = False
        Me.dgvDPS.AllowUserToDeleteRows = False
        Me.dgvDPS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDPS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDPS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDPS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colゾーン, Me.col総棚数, Me.col割付棚数, Me.Col出荷回数})
        Me.dgvDPS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvDPS.Location = New System.Drawing.Point(96, 123)
        Me.dgvDPS.MultiSelect = False
        Me.dgvDPS.Name = "dgvDPS"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDPS.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDPS.RowHeadersVisible = False
        Me.dgvDPS.RowHeadersWidth = 20
        Me.dgvDPS.RowTemplate.Height = 21
        Me.dgvDPS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDPS.Size = New System.Drawing.Size(402, 495)
        Me.dgvDPS.TabIndex = 269
        '
        'colゾーン
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colゾーン.DefaultCellStyle = DataGridViewCellStyle2
        Me.colゾーン.FillWeight = 50.0!
        Me.colゾーン.HeaderText = "ゾーン"
        Me.colゾーン.Name = "colゾーン"
        Me.colゾーン.ReadOnly = True
        '
        'col総棚数
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col総棚数.DefaultCellStyle = DataGridViewCellStyle3
        Me.col総棚数.FillWeight = 60.0!
        Me.col総棚数.HeaderText = "総棚数"
        Me.col総棚数.Name = "col総棚数"
        Me.col総棚数.ReadOnly = True
        '
        'col割付棚数
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col割付棚数.DefaultCellStyle = DataGridViewCellStyle4
        Me.col割付棚数.FillWeight = 60.0!
        Me.col割付棚数.HeaderText = "割付棚数"
        Me.col割付棚数.Name = "col割付棚数"
        Me.col割付棚数.ReadOnly = True
        '
        'Col出荷回数
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col出荷回数.DefaultCellStyle = DataGridViewCellStyle5
        Me.Col出荷回数.FillWeight = 60.0!
        Me.Col出荷回数.HeaderText = "出荷回数"
        Me.Col出荷回数.Name = "Col出荷回数"
        Me.Col出荷回数.ReadOnly = True
        '
        'bt表示
        '
        Me.bt表示.Location = New System.Drawing.Point(551, 64)
        Me.bt表示.Name = "bt表示"
        Me.bt表示.Size = New System.Drawing.Size(101, 25)
        Me.bt表示.TabIndex = 275
        Me.bt表示.Text = "表示(F5)"
        Me.bt表示.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(504, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 12)
        Me.Label1.TabIndex = 401
        Me.Label1.Text = "ヶ月"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(469, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(29, 22)
        Me.TextBox3.TabIndex = 400
        Me.TextBox3.Text = "Z9"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(377, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 12)
        Me.Label10.TabIndex = 399
        Me.Label10.Text = "表示月数"
        '
        'dgvMeisai
        '
        Me.dgvMeisai.AllowUserToAddRows = False
        Me.dgvMeisai.AllowUserToDeleteRows = False
        Me.dgvMeisai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMeisai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMeisai.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvMeisai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMeisai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col棚No, Me.col出荷回数2})
        Me.dgvMeisai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvMeisai.Location = New System.Drawing.Point(551, 123)
        Me.dgvMeisai.MultiSelect = False
        Me.dgvMeisai.Name = "dgvMeisai"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMeisai.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvMeisai.RowHeadersVisible = False
        Me.dgvMeisai.RowHeadersWidth = 20
        Me.dgvMeisai.RowTemplate.Height = 21
        Me.dgvMeisai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMeisai.Size = New System.Drawing.Size(239, 495)
        Me.dgvMeisai.TabIndex = 402
        '
        'col棚No
        '
        Me.col棚No.HeaderText = "棚No"
        Me.col棚No.Name = "col棚No"
        Me.col棚No.ReadOnly = True
        '
        'col出荷回数2
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col出荷回数2.DefaultCellStyle = DataGridViewCellStyle8
        Me.col出荷回数2.FillWeight = 78.95775!
        Me.col出荷回数2.HeaderText = "出荷回数"
        Me.col出荷回数2.Name = "col出荷回数2"
        Me.col出荷回数2.ReadOnly = True
        '
        'DPS棚割状況一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.dgvMeisai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.bt表示)
        Me.Controls.Add(Me.dgvDPS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "DPS棚割状況一覧"
        Me.Text = "DPS棚割状況一覧"
        Me.Controls.SetChildIndex(Me.dgvDPS, 0)
        Me.Controls.SetChildIndex(Me.bt表示, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TextBox3, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.dgvMeisai, 0)
        CType(Me.dgvDPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMeisai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDPS As System.Windows.Forms.DataGridView
    Friend WithEvents bt表示 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvMeisai As System.Windows.Forms.DataGridView
    Friend WithEvents col棚No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col出荷回数2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colゾーン As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col総棚数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col割付棚数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col出荷回数 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
