<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetubiPause
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
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvMeisai = New System.Windows.Forms.DataGridView()
        Me.ColChkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colSetubiNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSetubiNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStmodeKbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSetubiSts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout
        Me.GroupBox3.SuspendLayout
        CType(Me.dgvMeisai,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnEnd)
        Me.Panel2.Location = New System.Drawing.Point(-9, 423)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 52)
        Me.Panel2.TabIndex = 135
        '
        'bt終了
        '
        Me.btnEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnEnd.Location = New System.Drawing.Point(432, 8)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(141, 31)
        Me.btnEnd.TabIndex = 144
        Me.btnEnd.Text = "戻る(F12)"
        Me.btnEnd.UseVisualStyleBackColor = true
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton9)
        Me.GroupBox3.Controls.Add(Me.RadioButton10)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(246, 40)
        Me.GroupBox3.TabIndex = 239
        Me.GroupBox3.TabStop = false
        '
        'RadioButton9
        '
        Me.RadioButton9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.RadioButton9.AutoSize = true
        Me.RadioButton9.Location = New System.Drawing.Point(119, 15)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(100, 16)
        Me.RadioButton9.TabIndex = 1
        Me.RadioButton9.Text = "指定ステーション"
        Me.RadioButton9.UseVisualStyleBackColor = true
        '
        'RadioButton10
        '
        Me.RadioButton10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.RadioButton10.AutoSize = true
        Me.RadioButton10.Checked = true
        Me.RadioButton10.Location = New System.Drawing.Point(10, 15)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(88, 16)
        Me.RadioButton10.TabIndex = 0
        Me.RadioButton10.TabStop = true
        Me.RadioButton10.Text = "全ステーション"
        Me.RadioButton10.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(336, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 25)
        Me.Button1.TabIndex = 408
        Me.Button1.Text = "中断(F2)"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(462, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 25)
        Me.Button2.TabIndex = 409
        Me.Button2.Text = "運転(F3)"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'dgvMeisai
        '
        Me.dgvMeisai.AllowUserToAddRows = false
        Me.dgvMeisai.AllowUserToDeleteRows = false
        Me.dgvMeisai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMeisai.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMeisai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMeisai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColChkSelect, Me.colSetubiNo, Me.colSetubiNm, Me.colStmodeKbn, Me.colSetubiSts})
        Me.dgvMeisai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvMeisai.Location = New System.Drawing.Point(12, 58)
        Me.dgvMeisai.MultiSelect = false
        Me.dgvMeisai.Name = "dgvMeisai"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMeisai.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMeisai.RowHeadersVisible = false
        Me.dgvMeisai.RowHeadersWidth = 20
        Me.dgvMeisai.RowTemplate.Height = 21
        Me.dgvMeisai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMeisai.Size = New System.Drawing.Size(550, 304)
        Me.dgvMeisai.TabIndex = 414
        '
        'ColChkSelect
        '
        Me.ColChkSelect.FillWeight = 30!
        Me.ColChkSelect.HeaderText = ""
        Me.ColChkSelect.Name = "ColChkSelect"
        Me.ColChkSelect.Width = 60
        '
        'colSetubiNo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.colSetubiNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.colSetubiNo.FillWeight = 80!
        Me.colSetubiNo.HeaderText = "ｽﾃｰｼｮﾝNo"
        Me.colSetubiNo.Name = "colSetubiNo"
        Me.colSetubiNo.ReadOnly = true
        '
        'colSetubiNm
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSetubiNm.DefaultCellStyle = DataGridViewCellStyle3
        Me.colSetubiNm.HeaderText = "ｽﾃｰｼｮﾝ名称"
        Me.colSetubiNm.Name = "colSetubiNm"
        Me.colSetubiNm.ReadOnly = true
        Me.colSetubiNm.Width = 140
        '
        'colStmodeKbn
        '
        Me.colStmodeKbn.HeaderText = "入出庫モード"
        Me.colStmodeKbn.Name = "colStmodeKbn"
        Me.colStmodeKbn.ReadOnly = true
        Me.colStmodeKbn.Width = 140
        '
        'colSetubiSts
        '
        Me.colSetubiSts.HeaderText = "状態"
        Me.colSetubiSts.Name = "colSetubiSts"
        Me.colSetubiSts.ReadOnly = true
        '
        'frmSetubiPause
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 473)
        Me.Controls.Add(Me.dgvMeisai)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = true
        Me.Name = "frmSetubiPause"
        Me.Text = "設備運転中断設定"
        Me.Panel2.ResumeLayout(false)
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        CType(Me.dgvMeisai,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgvMeisai As System.Windows.Forms.DataGridView
    Friend WithEvents ColChkSelect As DataGridViewCheckBoxColumn
    Friend WithEvents colSetubiNo As DataGridViewTextBoxColumn
    Friend WithEvents colSetubiNm As DataGridViewTextBoxColumn
    Friend WithEvents colStmodeKbn As DataGridViewTextBoxColumn
    Friend WithEvents colSetubiSts As DataGridViewTextBoxColumn
End Class
