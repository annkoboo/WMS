<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHachuLotSuLst
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
        Me.dgvHachuLot = New System.Windows.Forms.DataGridView()
        Me.col商品名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col規格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col在庫数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col通販安全在庫数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col卸安全在庫数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col発注ロット単位 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col発注ロット数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col共通商品コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvHachuLot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHachuLot
        '
        Me.dgvHachuLot.AllowUserToAddRows = False
        Me.dgvHachuLot.AllowUserToDeleteRows = False
        Me.dgvHachuLot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHachuLot.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHachuLot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHachuLot.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col商品名, Me.col規格, Me.col在庫数, Me.col通販安全在庫数, Me.Col卸安全在庫数, Me.col発注ロット単位, Me.Col発注ロット数, Me.Col共通商品コード})
        Me.dgvHachuLot.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvHachuLot.Location = New System.Drawing.Point(9, 75)
        Me.dgvHachuLot.MultiSelect = False
        Me.dgvHachuLot.Name = "dgvHachuLot"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHachuLot.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvHachuLot.RowHeadersVisible = False
        Me.dgvHachuLot.RowHeadersWidth = 20
        Me.dgvHachuLot.RowTemplate.Height = 21
        Me.dgvHachuLot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHachuLot.Size = New System.Drawing.Size(994, 543)
        Me.dgvHachuLot.TabIndex = 269
        '
        'col商品名
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品名.DefaultCellStyle = DataGridViewCellStyle2
        Me.col商品名.FillWeight = 160.0!
        Me.col商品名.HeaderText = "商品名"
        Me.col商品名.Name = "col商品名"
        Me.col商品名.ReadOnly = True
        Me.col商品名.Width = 300
        '
        'col規格
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col規格.DefaultCellStyle = DataGridViewCellStyle3
        Me.col規格.FillWeight = 120.0!
        Me.col規格.HeaderText = "規格"
        Me.col規格.Name = "col規格"
        Me.col規格.ReadOnly = True
        Me.col規格.Width = 130
        '
        'col在庫数
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col在庫数.DefaultCellStyle = DataGridViewCellStyle4
        Me.col在庫数.FillWeight = 80.0!
        Me.col在庫数.HeaderText = "在庫数"
        Me.col在庫数.Name = "col在庫数"
        Me.col在庫数.ReadOnly = True
        '
        'col通販安全在庫数
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col通販安全在庫数.DefaultCellStyle = DataGridViewCellStyle5
        Me.col通販安全在庫数.FillWeight = 80.0!
        Me.col通販安全在庫数.HeaderText = "通販安全在庫数"
        Me.col通販安全在庫数.Name = "col通販安全在庫数"
        Me.col通販安全在庫数.ReadOnly = True
        Me.col通販安全在庫数.Width = 120
        '
        'Col卸安全在庫数
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col卸安全在庫数.DefaultCellStyle = DataGridViewCellStyle6
        Me.Col卸安全在庫数.FillWeight = 80.0!
        Me.Col卸安全在庫数.HeaderText = "卸安全在庫数"
        Me.Col卸安全在庫数.Name = "Col卸安全在庫数"
        Me.Col卸安全在庫数.ReadOnly = True
        Me.Col卸安全在庫数.Width = 120
        '
        'col発注ロット単位
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col発注ロット単位.DefaultCellStyle = DataGridViewCellStyle7
        Me.col発注ロット単位.FillWeight = 80.0!
        Me.col発注ロット単位.HeaderText = "発注ﾛｯﾄ単位"
        Me.col発注ロット単位.Name = "col発注ロット単位"
        Me.col発注ロット単位.ReadOnly = True
        '
        'Col発注ロット数
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col発注ロット数.DefaultCellStyle = DataGridViewCellStyle8
        Me.Col発注ロット数.FillWeight = 80.0!
        Me.Col発注ロット数.HeaderText = "発注ロット数"
        Me.Col発注ロット数.Name = "Col発注ロット数"
        Me.Col発注ロット数.ReadOnly = True
        '
        'Col共通商品コード
        '
        Me.Col共通商品コード.HeaderText = "共通商品コード"
        Me.Col共通商品コード.Name = "Col共通商品コード"
        Me.Col共通商品コード.ReadOnly = True
        Me.Col共通商品コード.Width = 150
        '
        '発注ロット数問合せ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.dgvHachuLot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "発注ロット数問合せ"
        Me.Text = "発注ロット数問合せ"
        Me.Controls.SetChildIndex(Me.dgvHachuLot, 0)
        CType(Me.dgvHachuLot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvHachuLot As System.Windows.Forms.DataGridView
    Friend WithEvents col商品名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col規格 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col在庫数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col通販安全在庫数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col卸安全在庫数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col発注ロット単位 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col発注ロット数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col共通商品コード As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
