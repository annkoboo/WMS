<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeadStockLst
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSyuKigen = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Col共通商品コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col商品名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col規格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col未出荷期間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col総在庫数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col自動倉庫在庫数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col平置倉庫在庫数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSyuKigen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvSyuKigen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col共通商品コード, Me.Col商品名, Me.Col規格, Me.col未出荷期間, Me.Col総在庫数, Me.Col自動倉庫在庫数, Me.Col平置倉庫在庫数})
        Me.dgvSyuKigen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSyuKigen.Location = New System.Drawing.Point(6, 91)
        Me.dgvSyuKigen.MultiSelect = False
        Me.dgvSyuKigen.Name = "dgvSyuKigen"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSyuKigen.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSyuKigen.RowHeadersVisible = False
        Me.dgvSyuKigen.RowHeadersWidth = 20
        Me.dgvSyuKigen.RowTemplate.Height = 21
        Me.dgvSyuKigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSyuKigen.Size = New System.Drawing.Size(980, 527)
        Me.dgvSyuKigen.TabIndex = 334
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(51, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 12)
        Me.Label10.TabIndex = 330
        Me.Label10.Text = "未出荷期間"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(143, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(29, 22)
        Me.TextBox3.TabIndex = 397
        Me.TextBox3.Text = "Z9"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 12)
        Me.Label1.TabIndex = 398
        Me.Label1.Text = "ヶ月"
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
        'Col規格
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Col規格.DefaultCellStyle = DataGridViewCellStyle2
        Me.Col規格.FillWeight = 50.0!
        Me.Col規格.HeaderText = "規格"
        Me.Col規格.Name = "Col規格"
        Me.Col規格.ReadOnly = True
        Me.Col規格.Width = 130
        '
        'col未出荷期間
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col未出荷期間.DefaultCellStyle = DataGridViewCellStyle3
        Me.col未出荷期間.FillWeight = 40.0!
        Me.col未出荷期間.HeaderText = "未出荷期間"
        Me.col未出荷期間.Name = "col未出荷期間"
        Me.col未出荷期間.ReadOnly = True
        Me.col未出荷期間.Width = 90
        '
        'Col総在庫数
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col総在庫数.DefaultCellStyle = DataGridViewCellStyle4
        Me.Col総在庫数.FillWeight = 40.20141!
        Me.Col総在庫数.HeaderText = "総在庫数"
        Me.Col総在庫数.Name = "Col総在庫数"
        Me.Col総在庫数.ReadOnly = True
        Me.Col総在庫数.Width = 90
        '
        'Col自動倉庫在庫数
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col自動倉庫在庫数.DefaultCellStyle = DataGridViewCellStyle5
        Me.Col自動倉庫在庫数.HeaderText = "自動倉庫在庫数"
        Me.Col自動倉庫在庫数.Name = "Col自動倉庫在庫数"
        Me.Col自動倉庫在庫数.ReadOnly = True
        Me.Col自動倉庫在庫数.Width = 120
        '
        'Col平置倉庫在庫数
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col平置倉庫在庫数.DefaultCellStyle = DataGridViewCellStyle6
        Me.Col平置倉庫在庫数.HeaderText = "平置倉庫在庫数"
        Me.Col平置倉庫在庫数.Name = "Col平置倉庫在庫数"
        Me.Col平置倉庫在庫数.ReadOnly = True
        Me.Col平置倉庫在庫数.Width = 120
        '
        'デッドストック一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.dgvSyuKigen)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "デッドストック一覧"
        Me.Text = "デッドストック一覧"
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.dgvSyuKigen, 0)
        Me.Controls.SetChildIndex(Me.TextBox3, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.dgvSyuKigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSyuKigen As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Col共通商品コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col商品名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col規格 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col未出荷期間 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col総在庫数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col自動倉庫在庫数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col平置倉庫在庫数 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
