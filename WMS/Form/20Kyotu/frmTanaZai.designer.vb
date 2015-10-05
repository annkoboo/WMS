<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTanaZai
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt終了 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvTana_Zaiko = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.col商品コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col総数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col賞味期限 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colロットNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col入荷日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col初回入荷日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予約区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colデータ作成日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col規格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col品質区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col荷主区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTana_Zaiko, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.bt終了)
        Me.Panel2.Location = New System.Drawing.Point(-9, 511)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(794, 52)
        Me.Panel2.TabIndex = 1
        '
        'bt終了
        '
        Me.bt終了.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt終了.Location = New System.Drawing.Point(640, 8)
        Me.bt終了.Name = "bt終了"
        Me.bt終了.Size = New System.Drawing.Size(141, 31)
        Me.bt終了.TabIndex = 0
        Me.bt終了.Text = "戻る(F12)"
        Me.bt終了.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 12)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "容器番号"
        '
        'dgvTana_Zaiko
        '
        Me.dgvTana_Zaiko.AllowUserToAddRows = False
        Me.dgvTana_Zaiko.AllowUserToDeleteRows = False
        Me.dgvTana_Zaiko.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTana_Zaiko.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTana_Zaiko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTana_Zaiko.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col商品コード, Me.col商品名, Me.Col総数, Me.col賞味期限, Me.colロットNo, Me.col入荷日, Me.col初回入荷日, Me.col予約区分, Me.colデータ作成日, Me.col備考, Me.col規格, Me.col品質区分, Me.col荷主区分})
        Me.dgvTana_Zaiko.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvTana_Zaiko.Location = New System.Drawing.Point(9, 53)
        Me.dgvTana_Zaiko.MultiSelect = False
        Me.dgvTana_Zaiko.Name = "dgvTana_Zaiko"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTana_Zaiko.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvTana_Zaiko.RowHeadersVisible = False
        Me.dgvTana_Zaiko.RowHeadersWidth = 20
        Me.dgvTana_Zaiko.RowTemplate.Height = 21
        Me.dgvTana_Zaiko.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTana_Zaiko.Size = New System.Drawing.Size(766, 452)
        Me.dgvTana_Zaiko.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(312, 17)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(57, 19)
        Me.TextBox2.TabIndex = 211
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "123456"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 12)
        Me.Label8.TabIndex = 267
        Me.Label8.Text = "棚No."
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(175, 16)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(26, 20)
        Me.TextBox9.TabIndex = 266
        Me.TextBox9.TabStop = False
        Me.TextBox9.Text = "11"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.Location = New System.Drawing.Point(167, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(12, 12)
        Me.Label19.TabIndex = 265
        Me.Label19.Text = "-"
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox11.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(141, 16)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(26, 20)
        Me.TextBox11.TabIndex = 264
        Me.TextBox11.TabStop = False
        Me.TextBox11.Text = "11"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.Location = New System.Drawing.Point(131, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(12, 12)
        Me.Label18.TabIndex = 263
        Me.Label18.Text = "-"
        '
        'TextBox15
        '
        Me.TextBox15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox15.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(104, 16)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(26, 20)
        Me.TextBox15.TabIndex = 262
        Me.TextBox15.TabStop = False
        Me.TextBox15.Text = "11"
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.Location = New System.Drawing.Point(94, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(12, 12)
        Me.Label17.TabIndex = 261
        Me.Label17.Text = "-"
        '
        'TextBox16
        '
        Me.TextBox16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox16.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox16.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(68, 16)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ReadOnly = True
        Me.TextBox16.Size = New System.Drawing.Size(26, 20)
        Me.TextBox16.TabIndex = 260
        Me.TextBox16.TabStop = False
        Me.TextBox16.Text = "11"
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'col商品コード
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品コード.DefaultCellStyle = DataGridViewCellStyle2
        Me.col商品コード.FillWeight = 153.4592!
        Me.col商品コード.HeaderText = "共通商品ｺｰﾄﾞ"
        Me.col商品コード.Name = "col商品コード"
        Me.col商品コード.ReadOnly = True
        Me.col商品コード.Width = 105
        '
        'col商品名
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品名.DefaultCellStyle = DataGridViewCellStyle3
        Me.col商品名.FillWeight = 71.47603!
        Me.col商品名.HeaderText = "商品名"
        Me.col商品名.Name = "col商品名"
        Me.col商品名.ReadOnly = True
        Me.col商品名.Width = 300
        '
        'Col総数
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col総数.DefaultCellStyle = DataGridViewCellStyle4
        Me.Col総数.HeaderText = "総数"
        Me.Col総数.Name = "Col総数"
        Me.Col総数.ReadOnly = True
        '
        'col賞味期限
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col賞味期限.DefaultCellStyle = DataGridViewCellStyle5
        Me.col賞味期限.FillWeight = 42.88562!
        Me.col賞味期限.HeaderText = "賞味期限"
        Me.col賞味期限.Name = "col賞味期限"
        Me.col賞味期限.ReadOnly = True
        Me.col賞味期限.Width = 80
        '
        'colロットNo
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colロットNo.DefaultCellStyle = DataGridViewCellStyle6
        Me.colロットNo.FillWeight = 54.26753!
        Me.colロットNo.HeaderText = "ﾛｯﾄNo"
        Me.colロットNo.Name = "colロットNo"
        Me.colロットNo.ReadOnly = True
        Me.colロットNo.Width = 70
        '
        'col入荷日
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col入荷日.DefaultCellStyle = DataGridViewCellStyle7
        Me.col入荷日.FillWeight = 71.47603!
        Me.col入荷日.HeaderText = "入荷日"
        Me.col入荷日.Name = "col入荷日"
        Me.col入荷日.ReadOnly = True
        Me.col入荷日.Width = 80
        '
        'col初回入荷日
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col初回入荷日.DefaultCellStyle = DataGridViewCellStyle8
        Me.col初回入荷日.FillWeight = 90.44588!
        Me.col初回入荷日.HeaderText = "初回入荷日"
        Me.col初回入荷日.Name = "col初回入荷日"
        Me.col初回入荷日.Width = 90
        '
        'col予約区分
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col予約区分.DefaultCellStyle = DataGridViewCellStyle9
        Me.col予約区分.FillWeight = 90.44588!
        Me.col予約区分.HeaderText = "予約区分"
        Me.col予約区分.Name = "col予約区分"
        Me.col予約区分.Width = 60
        '
        'colデータ作成日
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colデータ作成日.DefaultCellStyle = DataGridViewCellStyle10
        Me.colデータ作成日.FillWeight = 90.44588!
        Me.colデータ作成日.HeaderText = "ﾃﾞｰﾀ作成日"
        Me.colデータ作成日.Name = "colデータ作成日"
        Me.colデータ作成日.ReadOnly = True
        Me.colデータ作成日.Width = 80
        '
        'col備考
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col備考.DefaultCellStyle = DataGridViewCellStyle11
        Me.col備考.HeaderText = "備考"
        Me.col備考.Name = "col備考"
        Me.col備考.Width = 300
        '
        'col規格
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col規格.DefaultCellStyle = DataGridViewCellStyle12
        Me.col規格.FillWeight = 71.47603!
        Me.col規格.HeaderText = "規格"
        Me.col規格.Name = "col規格"
        Me.col規格.ReadOnly = True
        Me.col規格.Width = 120
        '
        'col品質区分
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col品質区分.DefaultCellStyle = DataGridViewCellStyle13
        Me.col品質区分.FillWeight = 90.44588!
        Me.col品質区分.HeaderText = "品質区分"
        Me.col品質区分.Name = "col品質区分"
        Me.col品質区分.Width = 60
        '
        'col荷主区分
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col荷主区分.DefaultCellStyle = DataGridViewCellStyle14
        Me.col荷主区分.FillWeight = 90.44588!
        Me.col荷主区分.HeaderText = "荷主区分"
        Me.col荷主区分.Name = "col荷主区分"
        Me.col荷主区分.Width = 60
        '
        '棚在庫詳細
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvTana_Zaiko)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "棚在庫詳細"
        Me.Text = "棚在庫詳細"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvTana_Zaiko, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bt終了 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvTana_Zaiko As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents col商品コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col総数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col賞味期限 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colロットNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col入荷日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col初回入荷日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col予約区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colデータ作成日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col備考 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col規格 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col品質区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col荷主区分 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
