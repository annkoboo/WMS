<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTuhanKenpin02
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
        Me.dgvkenpin2 = New System.Windows.Forms.DataGridView()
        Me.col用紙 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col送り状区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col枚数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col検品状態 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colバーコード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bt再検品 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bt強制完了 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvkenpin2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvkenpin2
        '
        Me.dgvkenpin2.AllowUserToAddRows = False
        Me.dgvkenpin2.AllowUserToDeleteRows = False
        Me.dgvkenpin2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvkenpin2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvkenpin2.ColumnHeadersHeight = 40
        Me.dgvkenpin2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvkenpin2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col用紙, Me.col送り状区分, Me.col枚数, Me.col検品状態, Me.colバーコード})
        Me.dgvkenpin2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvkenpin2.Location = New System.Drawing.Point(195, 309)
        Me.dgvkenpin2.MultiSelect = False
        Me.dgvkenpin2.Name = "dgvkenpin2"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvkenpin2.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvkenpin2.RowHeadersVisible = False
        Me.dgvkenpin2.RowHeadersWidth = 40
        Me.dgvkenpin2.RowTemplate.Height = 21
        Me.dgvkenpin2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvkenpin2.Size = New System.Drawing.Size(504, 297)
        Me.dgvkenpin2.TabIndex = 146
        '
        'col用紙
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.col用紙.DefaultCellStyle = DataGridViewCellStyle2
        Me.col用紙.FillWeight = 179.6954!
        Me.col用紙.HeaderText = "用紙"
        Me.col用紙.Name = "col用紙"
        Me.col用紙.ReadOnly = True
        Me.col用紙.Width = 160
        '
        'col送り状区分
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col送り状区分.DefaultCellStyle = DataGridViewCellStyle3
        Me.col送り状区分.HeaderText = "送り状区分"
        Me.col送り状区分.Name = "col送り状区分"
        '
        'col枚数
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col枚数.DefaultCellStyle = DataGridViewCellStyle4
        Me.col枚数.HeaderText = "枚数"
        Me.col枚数.Name = "col枚数"
        Me.col枚数.Width = 60
        '
        'col検品状態
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col検品状態.DefaultCellStyle = DataGridViewCellStyle5
        Me.col検品状態.HeaderText = "検品状態"
        Me.col検品状態.Name = "col検品状態"
        Me.col検品状態.Width = 80
        '
        'colバーコード
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colバーコード.DefaultCellStyle = DataGridViewCellStyle6
        Me.colバーコード.HeaderText = "バーコード"
        Me.colバーコード.Name = "colバーコード"
        '
        'bt再検品
        '
        Me.bt再検品.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt再検品.Location = New System.Drawing.Point(577, 243)
        Me.bt再検品.Name = "bt再検品"
        Me.bt再検品.Size = New System.Drawing.Size(198, 44)
        Me.bt再検品.TabIndex = 152
        Me.bt再検品.Text = "再検品(F3)"
        Me.bt再検品.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(6, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(997, 55)
        Me.Panel2.TabIndex = 207
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 33)
        Me.Label1.TabIndex = 208
        Me.Label1.Text = "出荷指示No:1234567890"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(847, 33)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "合併帳票の納品伝票Noバーコードをスキャンしてください"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(373, 175)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(236, 39)
        Me.TextBox1.TabIndex = 211
        Me.TextBox1.Text = "1234567890123"
        '
        'bt強制完了
        '
        Me.bt強制完了.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt強制完了.Location = New System.Drawing.Point(792, 243)
        Me.bt強制完了.Name = "bt強制完了"
        Me.bt強制完了.Size = New System.Drawing.Size(206, 44)
        Me.bt強制完了.TabIndex = 217
        Me.bt強制完了.Text = "強制完了(F4)"
        Me.bt強制完了.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(383, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(607, 33)
        Me.Label2.TabIndex = 209
        Me.Label2.Text = "出荷先:出荷先名称出荷先名称出荷先名称"
        '
        '通販エリア検品2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.bt強制完了)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.bt再検品)
        Me.Controls.Add(Me.dgvkenpin2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "通販エリア検品2"
        Me.Text = "通販エリア検品"
        Me.Controls.SetChildIndex(Me.dgvkenpin2, 0)
        Me.Controls.SetChildIndex(Me.bt再検品, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.bt強制完了, 0)
        CType(Me.dgvkenpin2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvkenpin2 As System.Windows.Forms.DataGridView
    Friend WithEvents bt再検品 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents bt強制完了 As System.Windows.Forms.Button
    Friend WithEvents col用紙 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col送り状区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col枚数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col検品状態 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colバーコード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
