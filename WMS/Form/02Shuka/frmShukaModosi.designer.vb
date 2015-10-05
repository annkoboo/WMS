<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShukaModosi
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvSyuModosi = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.col棚No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品名称 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col賞味期限 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colロットNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colケース数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colバラ数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col総数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col出荷数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colケース入数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col共通商品コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col規格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予約区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvSyuModosi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(113, 49)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(78, 19)
        Me.TextBox8.TabIndex = 266
        Me.TextBox8.Text = "1234567890"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 12)
        Me.Label12.TabIndex = 265
        Me.Label12.Text = "出荷指示No"
        '
        'dgvSyuModosi
        '
        Me.dgvSyuModosi.AllowUserToAddRows = False
        Me.dgvSyuModosi.AllowUserToDeleteRows = False
        Me.dgvSyuModosi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSyuModosi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvSyuModosi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSyuModosi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col棚No, Me.col商品名称, Me.col賞味期限, Me.colロットNo, Me.colケース数, Me.colバラ数, Me.col総数, Me.col出荷数, Me.colケース入数, Me.col共通商品コード, Me.col規格, Me.col予約区分})
        Me.dgvSyuModosi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSyuModosi.Location = New System.Drawing.Point(6, 77)
        Me.dgvSyuModosi.MultiSelect = False
        Me.dgvSyuModosi.Name = "dgvSyuModosi"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle28.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSyuModosi.RowHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvSyuModosi.RowHeadersVisible = False
        Me.dgvSyuModosi.RowHeadersWidth = 20
        Me.dgvSyuModosi.RowTemplate.Height = 21
        Me.dgvSyuModosi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSyuModosi.Size = New System.Drawing.Size(997, 493)
        Me.dgvSyuModosi.TabIndex = 263
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.Location = New System.Drawing.Point(876, 583)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 31)
        Me.Button1.TabIndex = 268
        Me.Button1.Text = "設定(F2)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'col棚No
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col棚No.DefaultCellStyle = DataGridViewCellStyle16
        Me.col棚No.FillWeight = 93.93889!
        Me.col棚No.HeaderText = "棚No"
        Me.col棚No.Name = "col棚No"
        Me.col棚No.ReadOnly = True
        Me.col棚No.Width = 80
        '
        'col商品名称
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品名称.DefaultCellStyle = DataGridViewCellStyle17
        Me.col商品名称.FillWeight = 162.6876!
        Me.col商品名称.HeaderText = "商品名称"
        Me.col商品名称.Name = "col商品名称"
        Me.col商品名称.ReadOnly = True
        Me.col商品名称.Width = 300
        '
        'col賞味期限
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col賞味期限.DefaultCellStyle = DataGridViewCellStyle18
        Me.col賞味期限.FillWeight = 92.43747!
        Me.col賞味期限.HeaderText = "賞味期限"
        Me.col賞味期限.Name = "col賞味期限"
        Me.col賞味期限.ReadOnly = True
        Me.col賞味期限.Width = 80
        '
        'colロットNo
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.colロットNo.DefaultCellStyle = DataGridViewCellStyle19
        Me.colロットNo.FillWeight = 86.5058!
        Me.colロットNo.HeaderText = "ﾛｯﾄNo"
        Me.colロットNo.Name = "colロットNo"
        Me.colロットNo.ReadOnly = True
        Me.colロットNo.Width = 70
        '
        'colケース数
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colケース数.DefaultCellStyle = DataGridViewCellStyle20
        Me.colケース数.FillWeight = 56.79125!
        Me.colケース数.HeaderText = "ｹｰｽ数"
        Me.colケース数.Name = "colケース数"
        Me.colケース数.Width = 60
        '
        'colバラ数
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colバラ数.DefaultCellStyle = DataGridViewCellStyle21
        Me.colバラ数.FillWeight = 53.063!
        Me.colバラ数.HeaderText = "ﾊﾞﾗ数"
        Me.colバラ数.Name = "colバラ数"
        Me.colバラ数.Width = 80
        '
        'col総数
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col総数.DefaultCellStyle = DataGridViewCellStyle22
        Me.col総数.FillWeight = 94.34591!
        Me.col総数.HeaderText = "総数"
        Me.col総数.Name = "col総数"
        Me.col総数.ReadOnly = True
        Me.col総数.Width = 80
        '
        'col出荷数
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col出荷数.DefaultCellStyle = DataGridViewCellStyle23
        Me.col出荷数.FillWeight = 89.84956!
        Me.col出荷数.HeaderText = "出荷数"
        Me.col出荷数.Name = "col出荷数"
        Me.col出荷数.ReadOnly = True
        Me.col出荷数.Width = 80
        '
        'colケース入数
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colケース入数.DefaultCellStyle = DataGridViewCellStyle24
        Me.colケース入数.FillWeight = 85.03551!
        Me.colケース入数.HeaderText = "ｹｰｽ入数"
        Me.colケース入数.Name = "colケース入数"
        Me.colケース入数.ReadOnly = True
        Me.colケース入数.Width = 80
        '
        'col共通商品コード
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col共通商品コード.DefaultCellStyle = DataGridViewCellStyle25
        Me.col共通商品コード.FillWeight = 157.9867!
        Me.col共通商品コード.HeaderText = "共通商品ｺｰﾄﾞ"
        Me.col共通商品コード.Name = "col共通商品コード"
        Me.col共通商品コード.ReadOnly = True
        Me.col共通商品コード.Width = 120
        '
        'col規格
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col規格.DefaultCellStyle = DataGridViewCellStyle26
        Me.col規格.FillWeight = 157.9867!
        Me.col規格.HeaderText = "規格"
        Me.col規格.Name = "col規格"
        Me.col規格.ReadOnly = True
        Me.col規格.Width = 120
        '
        'col予約区分
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col予約区分.DefaultCellStyle = DataGridViewCellStyle27
        Me.col予約区分.FillWeight = 60.46141!
        Me.col予約区分.HeaderText = "予約区分"
        Me.col予約区分.Name = "col予約区分"
        Me.col予約区分.ReadOnly = True
        Me.col予約区分.Width = 80
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(291, 49)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(194, 19)
        Me.TextBox5.TabIndex = 332
        Me.TextBox5.Text = "出荷先名称出荷先名称出荷先名称"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 12)
        Me.Label1.TabIndex = 333
        Me.Label1.Text = "出荷先名称"
        '
        '出荷戻し作業
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvSyuModosi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "出荷戻し作業"
        Me.Text = "出荷戻し作業"
        Me.Controls.SetChildIndex(Me.dgvSyuModosi, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.TextBox8, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.TextBox5, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.dgvSyuModosi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgvSyuModosi As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents col棚No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品名称 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col賞味期限 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colロットNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colケース数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colバラ数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col総数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col出荷数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colケース入数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col共通商品コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col規格 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col予約区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
