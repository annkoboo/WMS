<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicSagyo
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvPick_M = New System.Windows.Forms.DataGridView()
        Me.col行No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col棚No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col規格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予約区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col出荷指示数量 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col明細メモ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvPick = New System.Windows.Forms.DataGridView()
        Me.col選択 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col出荷指示No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col設定者 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col出荷先名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col受注ﾒﾓ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvPick_M, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.dgvPick_M)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 386)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(992, 207)
        Me.GroupBox4.TabIndex = 267
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "明細"
        '
        'dgvPick_M
        '
        Me.dgvPick_M.AllowUserToAddRows = False
        Me.dgvPick_M.AllowUserToDeleteRows = False
        Me.dgvPick_M.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPick_M.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPick_M.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPick_M.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col行No, Me.col棚No, Me.col商品コード, Me.col商品, Me.col規格, Me.col予約区分, Me.col出荷指示数量, Me.col明細メモ})
        Me.dgvPick_M.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvPick_M.Location = New System.Drawing.Point(2, 18)
        Me.dgvPick_M.MultiSelect = False
        Me.dgvPick_M.Name = "dgvPick_M"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPick_M.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPick_M.RowHeadersVisible = False
        Me.dgvPick_M.RowHeadersWidth = 20
        Me.dgvPick_M.RowTemplate.Height = 21
        Me.dgvPick_M.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPick_M.Size = New System.Drawing.Size(984, 183)
        Me.dgvPick_M.TabIndex = 242
        '
        'col行No
        '
        Me.col行No.FillWeight = 41.86621!
        Me.col行No.HeaderText = "行No"
        Me.col行No.Name = "col行No"
        Me.col行No.ReadOnly = True
        Me.col行No.Width = 60
        '
        'col棚No
        '
        Me.col棚No.FillWeight = 37.56345!
        Me.col棚No.HeaderText = "棚No"
        Me.col棚No.Name = "col棚No"
        Me.col棚No.ReadOnly = True
        '
        'col商品コード
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品コード.DefaultCellStyle = DataGridViewCellStyle2
        Me.col商品コード.FillWeight = 100.5945!
        Me.col商品コード.HeaderText = "共通商品ｺｰﾄﾞ"
        Me.col商品コード.Name = "col商品コード"
        Me.col商品コード.ReadOnly = True
        Me.col商品コード.Width = 120
        '
        'col商品
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品.DefaultCellStyle = DataGridViewCellStyle3
        Me.col商品.FillWeight = 106.9059!
        Me.col商品.HeaderText = "商品名"
        Me.col商品.Name = "col商品"
        Me.col商品.ReadOnly = True
        Me.col商品.Width = 300
        '
        'col規格
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col規格.DefaultCellStyle = DataGridViewCellStyle4
        Me.col規格.FillWeight = 80.17946!
        Me.col規格.HeaderText = "規格"
        Me.col規格.Name = "col規格"
        Me.col規格.ReadOnly = True
        Me.col規格.Width = 120
        '
        'col予約区分
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col予約区分.DefaultCellStyle = DataGridViewCellStyle5
        Me.col予約区分.FillWeight = 105.6256!
        Me.col予約区分.HeaderText = "予約区分"
        Me.col予約区分.Name = "col予約区分"
        Me.col予約区分.ReadOnly = True
        Me.col予約区分.Width = 120
        '
        'col出荷指示数量
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col出荷指示数量.DefaultCellStyle = DataGridViewCellStyle6
        Me.col出荷指示数量.FillWeight = 133.6324!
        Me.col出荷指示数量.HeaderText = "出荷指示数量"
        Me.col出荷指示数量.Name = "col出荷指示数量"
        Me.col出荷指示数量.ReadOnly = True
        Me.col出荷指示数量.Width = 120
        '
        'col明細メモ
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col明細メモ.DefaultCellStyle = DataGridViewCellStyle7
        Me.col明細メモ.FillWeight = 133.6324!
        Me.col明細メモ.HeaderText = "明細ﾒﾓ"
        Me.col明細メモ.Name = "col明細メモ"
        Me.col明細メモ.ReadOnly = True
        Me.col明細メモ.Width = 300
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(113, 52)
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
        Me.Label12.Location = New System.Drawing.Point(25, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 12)
        Me.Label12.TabIndex = 265
        Me.Label12.Text = "出荷指示No"
        '
        'dgvPick
        '
        Me.dgvPick.AllowUserToAddRows = False
        Me.dgvPick.AllowUserToDeleteRows = False
        Me.dgvPick.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPick.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPick.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col選択, Me.col出荷指示No, Me.col設定者, Me.col出荷先名, Me.col受注ﾒﾓ})
        Me.dgvPick.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvPick.Location = New System.Drawing.Point(12, 86)
        Me.dgvPick.MultiSelect = False
        Me.dgvPick.Name = "dgvPick"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPick.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvPick.RowHeadersVisible = False
        Me.dgvPick.RowHeadersWidth = 20
        Me.dgvPick.RowTemplate.Height = 21
        Me.dgvPick.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPick.Size = New System.Drawing.Size(986, 253)
        Me.dgvPick.TabIndex = 263
        '
        'col選択
        '
        Me.col選択.FillWeight = 28.91023!
        Me.col選択.HeaderText = ""
        Me.col選択.Name = "col選択"
        Me.col選択.Width = 55
        '
        'col出荷指示No
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col出荷指示No.DefaultCellStyle = DataGridViewCellStyle10
        Me.col出荷指示No.FillWeight = 102.9755!
        Me.col出荷指示No.HeaderText = "出荷指示No"
        Me.col出荷指示No.Name = "col出荷指示No"
        Me.col出荷指示No.ReadOnly = True
        Me.col出荷指示No.Width = 140
        '
        'col設定者
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col設定者.DefaultCellStyle = DataGridViewCellStyle11
        Me.col設定者.HeaderText = "設定者"
        Me.col設定者.Name = "col設定者"
        '
        'col出荷先名
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.col出荷先名.DefaultCellStyle = DataGridViewCellStyle12
        Me.col出荷先名.FillWeight = 128.7194!
        Me.col出荷先名.HeaderText = "出荷先名"
        Me.col出荷先名.Name = "col出荷先名"
        Me.col出荷先名.ReadOnly = True
        Me.col出荷先名.Width = 200
        '
        'col受注ﾒﾓ
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col受注ﾒﾓ.DefaultCellStyle = DataGridViewCellStyle13
        Me.col受注ﾒﾓ.FillWeight = 102.9755!
        Me.col受注ﾒﾓ.HeaderText = "受注ﾒﾓ"
        Me.col受注ﾒﾓ.Name = "col受注ﾒﾓ"
        Me.col受注ﾒﾓ.ReadOnly = True
        Me.col受注ﾒﾓ.Width = 600
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(876, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 31)
        Me.Button1.TabIndex = 268
        Me.Button1.Text = "設定(F2)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(236, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 31)
        Me.Button2.TabIndex = 270
        Me.Button2.Text = "全選択(F8)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(102, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 31)
        Me.Button3.TabIndex = 269
        Me.Button3.Text = "全解除"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ピッキング作業
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvPick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "ピッキング作業"
        Me.Text = "ピッキング作業"
        Me.Controls.SetChildIndex(Me.dgvPick, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.TextBox8, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Button3, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvPick_M, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPick_M As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgvPick As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents col行No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col棚No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col規格 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col予約区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col出荷指示数量 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col明細メモ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col選択 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents col出荷指示No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col設定者 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col出荷先名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col受注ﾒﾓ As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
