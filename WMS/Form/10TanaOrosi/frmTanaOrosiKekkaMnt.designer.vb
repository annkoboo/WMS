<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTanaOrosiKekkaMnt
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvZaiko = New System.Windows.Forms.DataGridView()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Col棚No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col在庫数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colケース入数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colケース数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colバラ数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col総数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col賞味期限 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colロットNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col入荷日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col品質区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col荷主区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col予約区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col関連会社コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col規格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvZaiko, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvZaiko
        '
        Me.dgvZaiko.AllowUserToAddRows = False
        Me.dgvZaiko.AllowUserToDeleteRows = False
        Me.dgvZaiko.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvZaiko.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvZaiko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvZaiko.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col棚No, Me.col商品名, Me.col在庫数, Me.Colケース入数, Me.colケース数, Me.Colバラ数, Me.Col総数, Me.col賞味期限, Me.colロットNo, Me.col入荷日, Me.Column1, Me.col品質区分, Me.col荷主区分, Me.Col予約区分, Me.col商品コード, Me.Col関連会社コード, Me.col規格})
        Me.dgvZaiko.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvZaiko.Location = New System.Drawing.Point(6, 90)
        Me.dgvZaiko.MultiSelect = False
        Me.dgvZaiko.Name = "dgvZaiko"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvZaiko.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvZaiko.RowHeadersVisible = False
        Me.dgvZaiko.RowHeadersWidth = 20
        Me.dgvZaiko.RowTemplate.Height = 21
        Me.dgvZaiko.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZaiko.Size = New System.Drawing.Size(997, 521)
        Me.dgvZaiko.TabIndex = 1
        '
        'TextBox19
        '
        Me.TextBox19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox19.BackColor = System.Drawing.Color.White
        Me.TextBox19.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(126, 55)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(50, 19)
        Me.TextBox19.TabIndex = 0
        Me.TextBox19.Text = "99-99"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 12)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "エリア-バンク"
        '
        'Col棚No
        '
        Me.Col棚No.HeaderText = "棚No"
        Me.Col棚No.Name = "Col棚No"
        Me.Col棚No.ReadOnly = True
        Me.Col棚No.Width = 80
        '
        'col商品名
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品名.DefaultCellStyle = DataGridViewCellStyle2
        Me.col商品名.FillWeight = 156.5466!
        Me.col商品名.HeaderText = "商品名"
        Me.col商品名.Name = "col商品名"
        Me.col商品名.ReadOnly = True
        Me.col商品名.Width = 300
        '
        'col在庫数
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col在庫数.DefaultCellStyle = DataGridViewCellStyle3
        Me.col在庫数.FillWeight = 78.95775!
        Me.col在庫数.HeaderText = "在庫数"
        Me.col在庫数.Name = "col在庫数"
        Me.col在庫数.ReadOnly = True
        Me.col在庫数.Width = 80
        '
        'Colケース入数
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Colケース入数.DefaultCellStyle = DataGridViewCellStyle4
        Me.Colケース入数.HeaderText = "ｹｰｽ入数"
        Me.Colケース入数.Name = "Colケース入数"
        Me.Colケース入数.ReadOnly = True
        Me.Colケース入数.Width = 80
        '
        'colケース数
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colケース数.DefaultCellStyle = DataGridViewCellStyle5
        Me.colケース数.HeaderText = "ｹｰｽ数"
        Me.colケース数.Name = "colケース数"
        Me.colケース数.Width = 80
        '
        'Colバラ数
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Colバラ数.DefaultCellStyle = DataGridViewCellStyle6
        Me.Colバラ数.HeaderText = "ﾊﾞﾗ数"
        Me.Colバラ数.Name = "Colバラ数"
        Me.Colバラ数.Width = 80
        '
        'Col総数
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col総数.DefaultCellStyle = DataGridViewCellStyle7
        Me.Col総数.HeaderText = "総数"
        Me.Col総数.Name = "Col総数"
        Me.Col総数.ReadOnly = True
        Me.Col総数.Width = 80
        '
        'col賞味期限
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.col賞味期限.DefaultCellStyle = DataGridViewCellStyle8
        Me.col賞味期限.FillWeight = 52.46462!
        Me.col賞味期限.HeaderText = "賞味期限"
        Me.col賞味期限.Name = "col賞味期限"
        Me.col賞味期限.ReadOnly = True
        Me.col賞味期限.Width = 80
        '
        'colロットNo
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colロットNo.DefaultCellStyle = DataGridViewCellStyle9
        Me.colロットNo.FillWeight = 136.9782!
        Me.colロットNo.HeaderText = "ﾛｯﾄNo"
        Me.colロットNo.Name = "colロットNo"
        Me.colロットNo.ReadOnly = True
        Me.colロットNo.Width = 80
        '
        'col入荷日
        '
        Me.col入荷日.HeaderText = "入荷日"
        Me.col入荷日.Name = "col入荷日"
        Me.col入荷日.ReadOnly = True
        Me.col入荷日.Width = 70
        '
        'Column1
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column1.HeaderText = "初回入荷日"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 90
        '
        'col品質区分
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col品質区分.DefaultCellStyle = DataGridViewCellStyle11
        Me.col品質区分.FillWeight = 49.09086!
        Me.col品質区分.HeaderText = "品質区分"
        Me.col品質区分.Name = "col品質区分"
        Me.col品質区分.ReadOnly = True
        Me.col品質区分.Width = 80
        '
        'col荷主区分
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col荷主区分.DefaultCellStyle = DataGridViewCellStyle12
        Me.col荷主区分.FillWeight = 43.38193!
        Me.col荷主区分.HeaderText = "荷主区分"
        Me.col荷主区分.Name = "col荷主区分"
        Me.col荷主区分.ReadOnly = True
        Me.col荷主区分.Width = 80
        '
        'Col予約区分
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col予約区分.DefaultCellStyle = DataGridViewCellStyle13
        Me.Col予約区分.HeaderText = "予約区分"
        Me.Col予約区分.Name = "Col予約区分"
        Me.Col予約区分.ReadOnly = True
        Me.Col予約区分.Width = 80
        '
        'col商品コード
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.col商品コード.DefaultCellStyle = DataGridViewCellStyle14
        Me.col商品コード.FillWeight = 134.3357!
        Me.col商品コード.HeaderText = "共通商品ｺｰﾄﾞ"
        Me.col商品コード.Name = "col商品コード"
        Me.col商品コード.ReadOnly = True
        Me.col商品コード.Width = 120
        '
        'Col関連会社コード
        '
        Me.Col関連会社コード.HeaderText = "関連会社コード"
        Me.Col関連会社コード.Name = "Col関連会社コード"
        Me.Col関連会社コード.ReadOnly = True
        Me.Col関連会社コード.Width = 120
        '
        'col規格
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col規格.DefaultCellStyle = DataGridViewCellStyle15
        Me.col規格.FillWeight = 37.27981!
        Me.col規格.HeaderText = "規格"
        Me.col規格.Name = "col規格"
        Me.col規格.ReadOnly = True
        Me.col規格.Width = 120
        '
        '棚卸結果入力
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvZaiko)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "棚卸結果入力"
        Me.Text = "棚卸結果入力"
        Me.Controls.SetChildIndex(Me.dgvZaiko, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TextBox19, 0)
        CType(Me.dgvZaiko, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvZaiko As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Col棚No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col在庫数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colケース入数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colケース数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colバラ数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col総数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col賞味期限 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colロットNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col入荷日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col品質区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col荷主区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col予約区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col関連会社コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col規格 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
