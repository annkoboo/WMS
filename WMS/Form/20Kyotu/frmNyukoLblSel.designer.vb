<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNyukoLblSel
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt終了 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.bt選択 = New System.Windows.Forms.Button()
        Me.dgvShohin = New System.Windows.Forms.DataGridView()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt共通商品コード = New System.Windows.Forms.Button()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.col入庫ラベルNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col賞味期限 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colロット = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col入荷日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col初回入荷日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col品質区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col荷主区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col品名略称 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col規格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvShohin, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.TabIndex = 6
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(634, 59)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 25)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "再表示(F5)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'bt選択
        '
        Me.bt選択.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt選択.Location = New System.Drawing.Point(588, 462)
        Me.bt選択.Name = "bt選択"
        Me.bt選択.Size = New System.Drawing.Size(141, 31)
        Me.bt選択.TabIndex = 5
        Me.bt選択.Text = "選択(F8)"
        Me.bt選択.UseVisualStyleBackColor = True
        '
        'dgvShohin
        '
        Me.dgvShohin.AllowUserToAddRows = False
        Me.dgvShohin.AllowUserToDeleteRows = False
        Me.dgvShohin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvShohin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvShohin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShohin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col入庫ラベルNo, Me.col商品コード, Me.Col賞味期限, Me.Colロット, Me.Col入荷日, Me.Col初回入荷日, Me.Col品質区分, Me.Col荷主区分, Me.col品名略称, Me.col商品名, Me.col規格})
        Me.dgvShohin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvShohin.Location = New System.Drawing.Point(9, 87)
        Me.dgvShohin.MultiSelect = False
        Me.dgvShohin.Name = "dgvShohin"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvShohin.RowHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvShohin.RowHeadersVisible = False
        Me.dgvShohin.RowHeadersWidth = 20
        Me.dgvShohin.RowTemplate.Height = 21
        Me.dgvShohin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShohin.Size = New System.Drawing.Size(766, 364)
        Me.dgvShohin.TabIndex = 4
        '
        'TextBox19
        '
        Me.TextBox19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox19.BackColor = System.Drawing.Color.White
        Me.TextBox19.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(114, 36)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(108, 19)
        Me.TextBox19.TabIndex = 0
        Me.TextBox19.Text = "1234567890123456"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(114, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 19)
        Me.TextBox1.TabIndex = 147
        Me.TextBox1.Text = "1234567"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 12)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "入庫ラベルNo"
        '
        'bt共通商品コード
        '
        Me.bt共通商品コード.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt共通商品コード.Location = New System.Drawing.Point(9, 33)
        Me.bt共通商品コード.Name = "bt共通商品コード"
        Me.bt共通商品コード.Size = New System.Drawing.Size(100, 25)
        Me.bt共通商品コード.TabIndex = 349
        Me.bt共通商品コード.Text = "共通商品コード"
        Me.bt共通商品コード.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox12.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(488, 61)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(136, 19)
        Me.TextBox12.TabIndex = 353
        Me.TextBox12.Text = "規格規格規格規格規格"
        '
        'TextBox13
        '
        Me.TextBox13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox13.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(114, 61)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(371, 19)
        Me.TextBox13.TabIndex = 352
        Me.TextBox13.Text = "商品名商品名商品名商品名商品名商品名商品名商品名商品名商品名"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(228, 38)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 16)
        Me.CheckBox1.TabIndex = 354
        Me.CheckBox1.Text = "JAN検索"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'col入庫ラベルNo
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col入庫ラベルNo.DefaultCellStyle = DataGridViewCellStyle13
        Me.col入庫ラベルNo.FillWeight = 88.32487!
        Me.col入庫ラベルNo.HeaderText = "入庫ﾗﾍﾞﾙNo"
        Me.col入庫ラベルNo.Name = "col入庫ラベルNo"
        Me.col入庫ラベルNo.ReadOnly = True
        Me.col入庫ラベルNo.Width = 90
        '
        'col商品コード
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品コード.DefaultCellStyle = DataGridViewCellStyle14
        Me.col商品コード.FillWeight = 139.8103!
        Me.col商品コード.HeaderText = "共通商品ｺｰﾄﾞ"
        Me.col商品コード.Name = "col商品コード"
        Me.col商品コード.ReadOnly = True
        Me.col商品コード.Width = 120
        '
        'Col賞味期限
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col賞味期限.DefaultCellStyle = DataGridViewCellStyle15
        Me.Col賞味期限.HeaderText = "賞味期限"
        Me.Col賞味期限.Name = "Col賞味期限"
        Me.Col賞味期限.ReadOnly = True
        Me.Col賞味期限.Width = 80
        '
        'Colロット
        '
        Me.Colロット.HeaderText = "ﾛｯﾄNo"
        Me.Colロット.Name = "Colロット"
        Me.Colロット.ReadOnly = True
        Me.Colロット.Width = 70
        '
        'Col入荷日
        '
        Me.Col入荷日.HeaderText = "入荷日"
        Me.Col入荷日.Name = "Col入荷日"
        Me.Col入荷日.ReadOnly = True
        Me.Col入荷日.Width = 80
        '
        'Col初回入荷日
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col初回入荷日.DefaultCellStyle = DataGridViewCellStyle16
        Me.Col初回入荷日.HeaderText = "初回入荷日"
        Me.Col初回入荷日.Name = "Col初回入荷日"
        Me.Col初回入荷日.ReadOnly = True
        '
        'Col品質区分
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col品質区分.DefaultCellStyle = DataGridViewCellStyle17
        Me.Col品質区分.HeaderText = "品質区分"
        Me.Col品質区分.Name = "Col品質区分"
        Me.Col品質区分.ReadOnly = True
        Me.Col品質区分.Width = 80
        '
        'Col荷主区分
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col荷主区分.DefaultCellStyle = DataGridViewCellStyle18
        Me.Col荷主区分.HeaderText = "荷主区分"
        Me.Col荷主区分.Name = "Col荷主区分"
        Me.Col荷主区分.ReadOnly = True
        Me.Col荷主区分.Width = 80
        '
        'col品名略称
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col品名略称.DefaultCellStyle = DataGridViewCellStyle19
        Me.col品名略称.FillWeight = 55.68113!
        Me.col品名略称.HeaderText = "品名略称"
        Me.col品名略称.Name = "col品名略称"
        Me.col品名略称.ReadOnly = True
        Me.col品名略称.Width = 160
        '
        'col商品名
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品名.DefaultCellStyle = DataGridViewCellStyle20
        Me.col商品名.FillWeight = 102.6621!
        Me.col商品名.HeaderText = "商品名"
        Me.col商品名.Name = "col商品名"
        Me.col商品名.ReadOnly = True
        Me.col商品名.Width = 300
        '
        'col規格
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col規格.DefaultCellStyle = DataGridViewCellStyle21
        Me.col規格.FillWeight = 101.0384!
        Me.col規格.HeaderText = "規格"
        Me.col規格.Name = "col規格"
        Me.col規格.ReadOnly = True
        Me.col規格.Width = 150
        '
        '入庫ラベルデータ一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.bt共通商品コード)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bt選択)
        Me.Controls.Add(Me.dgvShohin)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "入庫ラベルデータ一覧"
        Me.Text = "入庫ラベルデータ一覧"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvShohin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bt終了 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents bt選択 As System.Windows.Forms.Button
    Friend WithEvents dgvShohin As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt共通商品コード As System.Windows.Forms.Button
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents col入庫ラベルNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col賞味期限 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colロット As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col入荷日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col初回入荷日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col品質区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col荷主区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col品名略称 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col規格 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
