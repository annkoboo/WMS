<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShukasSel
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt終了 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bt選択 = New System.Windows.Forms.Button()
        Me.dgvSyu_Siji = New System.Windows.Forms.DataGridView()
        Me.col出荷先コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col出荷先名称 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvSyu_Siji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.bt終了)
        Me.Panel2.Location = New System.Drawing.Point(-9, 496)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(882, 67)
        Me.Panel2.TabIndex = 135
        '
        'bt終了
        '
        Me.bt終了.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt終了.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt終了.Location = New System.Drawing.Point(726, 10)
        Me.bt終了.Name = "bt終了"
        Me.bt終了.Size = New System.Drawing.Size(141, 44)
        Me.bt終了.TabIndex = 144
        Me.bt終了.Text = "戻る(F12)"
        Me.bt終了.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 27)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "出荷先コード"
        '
        'bt選択
        '
        Me.bt選択.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt選択.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt選択.Location = New System.Drawing.Point(703, 443)
        Me.bt選択.Name = "bt選択"
        Me.bt選択.Size = New System.Drawing.Size(141, 38)
        Me.bt選択.TabIndex = 144
        Me.bt選択.Text = "選択(F8)"
        Me.bt選択.UseVisualStyleBackColor = True
        '
        'dgvSyu_Siji
        '
        Me.dgvSyu_Siji.AllowUserToAddRows = False
        Me.dgvSyu_Siji.AllowUserToDeleteRows = False
        Me.dgvSyu_Siji.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSyu_Siji.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSyu_Siji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSyu_Siji.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col出荷先コード, Me.col出荷先名称})
        Me.dgvSyu_Siji.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSyu_Siji.Location = New System.Drawing.Point(9, 66)
        Me.dgvSyu_Siji.MultiSelect = False
        Me.dgvSyu_Siji.Name = "dgvSyu_Siji"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSyu_Siji.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSyu_Siji.RowHeadersVisible = False
        Me.dgvSyu_Siji.RowHeadersWidth = 20
        Me.dgvSyu_Siji.RowTemplate.Height = 21
        Me.dgvSyu_Siji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSyu_Siji.Size = New System.Drawing.Size(854, 358)
        Me.dgvSyu_Siji.TabIndex = 145
        '
        'col出荷先コード
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("ＭＳ ゴシック", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.col出荷先コード.DefaultCellStyle = DataGridViewCellStyle2
        Me.col出荷先コード.HeaderText = "出荷先コード"
        Me.col出荷先コード.Name = "col出荷先コード"
        Me.col出荷先コード.ReadOnly = True
        Me.col出荷先コード.Width = 200
        '
        'col出荷先名称
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("ＭＳ ゴシック", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.col出荷先名称.DefaultCellStyle = DataGridViewCellStyle3
        Me.col出荷先名称.HeaderText = "出荷先名称"
        Me.col出荷先名称.Name = "col出荷先名称"
        Me.col出荷先名称.ReadOnly = True
        Me.col出荷先名称.Width = 380
        '
        'TextBox19
        '
        Me.TextBox19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox19.BackColor = System.Drawing.Color.White
        Me.TextBox19.Font = New System.Drawing.Font("ＭＳ ゴシック", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(198, 16)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(205, 34)
        Me.TextBox19.TabIndex = 209
        Me.TextBox19.Text = "1234567890123"
        '
        '出荷先一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 561)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bt選択)
        Me.Controls.Add(Me.dgvSyu_Siji)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "出荷先一覧"
        Me.Text = "出荷先一覧"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvSyu_Siji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bt終了 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt選択 As System.Windows.Forms.Button
    Friend WithEvents dgvSyu_Siji As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents col出荷先コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col出荷先名称 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
