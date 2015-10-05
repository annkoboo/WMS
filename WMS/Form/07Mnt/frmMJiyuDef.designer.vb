<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMJiyuDef
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvJiyuu = New System.Windows.Forms.DataGridView()
        Me.Col事象 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col事由コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col事由名称 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt事由コード = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvJiyuu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvJiyuu
        '
        Me.dgvJiyuu.AllowUserToAddRows = False
        Me.dgvJiyuu.AllowUserToDeleteRows = False
        Me.dgvJiyuu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvJiyuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvJiyuu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvJiyuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJiyuu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col事象, Me.Col事由コード, Me.col事由名称})
        Me.dgvJiyuu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvJiyuu.Location = New System.Drawing.Point(47, 65)
        Me.dgvJiyuu.MultiSelect = False
        Me.dgvJiyuu.Name = "dgvJiyuu"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvJiyuu.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvJiyuu.RowHeadersVisible = False
        Me.dgvJiyuu.RowHeadersWidth = 20
        Me.dgvJiyuu.RowTemplate.Height = 21
        Me.dgvJiyuu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJiyuu.Size = New System.Drawing.Size(535, 312)
        Me.dgvJiyuu.TabIndex = 269
        '
        'Col事象
        '
        Me.Col事象.FillWeight = 250.0!
        Me.Col事象.HeaderText = "事象"
        Me.Col事象.Name = "Col事象"
        Me.Col事象.ReadOnly = True
        '
        'Col事由コード
        '
        Me.Col事由コード.HeaderText = "事由コード"
        Me.Col事由コード.Name = "Col事由コード"
        Me.Col事由コード.ReadOnly = True
        '
        'col事由名称
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.col事由名称.DefaultCellStyle = DataGridViewCellStyle2
        Me.col事由名称.FillWeight = 200.0!
        Me.col事由名称.HeaderText = "事由名称"
        Me.col事由名称.Name = "col事由名称"
        Me.col事由名称.ReadOnly = True
        '
        'bt事由コード
        '
        Me.bt事由コード.Location = New System.Drawing.Point(6, 30)
        Me.bt事由コード.Name = "bt事由コード"
        Me.bt事由コード.Size = New System.Drawing.Size(101, 25)
        Me.bt事由コード.TabIndex = 330
        Me.bt事由コード.Text = "事由コード"
        Me.bt事由コード.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(146, 33)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(207, 19)
        Me.TextBox3.TabIndex = 413
        Me.TextBox3.Text = "事由名称事由名称事由名称事由名"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(113, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(24, 19)
        Me.TextBox1.TabIndex = 411
        Me.TextBox1.Text = "99"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt事由コード)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 399)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 161)
        Me.GroupBox1.TabIndex = 330
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "入力"
        '
        '事由デフォルトメンテナンス
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvJiyuu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "事由デフォルトメンテナンス"
        Me.Text = "事由デフォルトメンテナンス"
        Me.Controls.SetChildIndex(Me.dgvJiyuu, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        CType(Me.dgvJiyuu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvJiyuu As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Col事象 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col事由コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col事由名称 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bt事由コード As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
