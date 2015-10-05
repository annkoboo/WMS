<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMJiyu
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
        Me.dgvFindJiyu = New System.Windows.Forms.DataGridView()
        Me.colJiyuCd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJiyuNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDosaKbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colZaimuKbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpEtyZaimuKbn = New System.Windows.Forms.GroupBox()
        Me.rdoEtyZaimuKbnSinai = New System.Windows.Forms.RadioButton()
        Me.rdoEtyZaimuKbnSuru = New System.Windows.Forms.RadioButton()
        Me.grpEtyDosaKbn = New System.Windows.Forms.GroupBox()
        Me.rdoEtyDosaKbnShuko = New System.Windows.Forms.RadioButton()
        Me.rdoEtyDosaKbnNyuko = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEtyJiyuNm = New System.Windows.Forms.TextBox()
        Me.txtEtyJiyuCd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFindJiyuCd = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvFindJiyu,System.ComponentModel.ISupportInitialize).BeginInit
        Me.grpEtyZaimuKbn.SuspendLayout
        Me.grpEtyDosaKbn.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.SuspendLayout
        '
        'dgvFindJiyu
        '
        Me.dgvFindJiyu.AllowUserToAddRows = false
        Me.dgvFindJiyu.AllowUserToDeleteRows = false
        Me.dgvFindJiyu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvFindJiyu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFindJiyu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFindJiyu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFindJiyu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colJiyuCd, Me.colJiyuNm, Me.colDosaKbn, Me.colZaimuKbn})
        Me.dgvFindJiyu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvFindJiyu.Location = New System.Drawing.Point(188, 88)
        Me.dgvFindJiyu.MultiSelect = false
        Me.dgvFindJiyu.Name = "dgvFindJiyu"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFindJiyu.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFindJiyu.RowHeadersVisible = false
        Me.dgvFindJiyu.RowHeadersWidth = 20
        Me.dgvFindJiyu.RowTemplate.Height = 21
        Me.dgvFindJiyu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFindJiyu.Size = New System.Drawing.Size(492, 312)
        Me.dgvFindJiyu.TabIndex = 2
        '
        'colJiyuCd
        '
        Me.colJiyuCd.FillWeight = 90.0!
        Me.colJiyuCd.HeaderText = "事由コード"
        Me.colJiyuCd.Name = "colJiyuCd"
        Me.colJiyuCd.ReadOnly = True
        '
        'colJiyuNm
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.colJiyuNm.DefaultCellStyle = DataGridViewCellStyle2
        Me.colJiyuNm.FillWeight = 200.0!
        Me.colJiyuNm.HeaderText = "事由名称"
        Me.colJiyuNm.Name = "colJiyuNm"
        Me.colJiyuNm.ReadOnly = True
        '
        'colDosaKbn
        '
        Me.colDosaKbn.FillWeight = 90.0!
        Me.colDosaKbn.HeaderText = "入出庫区分"
        Me.colDosaKbn.Name = "colDosaKbn"
        Me.colDosaKbn.ReadOnly = True
        '
        'colZaimuKbn
        '
        Me.colZaimuKbn.HeaderText = "財務区分"
        Me.colZaimuKbn.Name = "colZaimuKbn"
        Me.colZaimuKbn.ReadOnly = True
        '
        'grpEtyZaimuKbn
        '
        Me.grpEtyZaimuKbn.Controls.Add(Me.rdoEtyZaimuKbnSinai)
        Me.grpEtyZaimuKbn.Controls.Add(Me.rdoEtyZaimuKbnSuru)
        Me.grpEtyZaimuKbn.Location = New System.Drawing.Point(119, 119)
        Me.grpEtyZaimuKbn.Name = "grpEtyZaimuKbn"
        Me.grpEtyZaimuKbn.Size = New System.Drawing.Size(174, 40)
        Me.grpEtyZaimuKbn.TabIndex = 4
        Me.grpEtyZaimuKbn.TabStop = False
        '
        'rdoEtyZaimuKbnSinai
        '
        Me.rdoEtyZaimuKbnSinai.AutoSize = True
        Me.rdoEtyZaimuKbnSinai.Location = New System.Drawing.Point(90, 15)
        Me.rdoEtyZaimuKbnSinai.Name = "rdoEtyZaimuKbnSinai"
        Me.rdoEtyZaimuKbnSinai.Size = New System.Drawing.Size(76, 16)
        Me.rdoEtyZaimuKbnSinai.TabIndex = 1
        Me.rdoEtyZaimuKbnSinai.Text = "関与しない"
        Me.rdoEtyZaimuKbnSinai.UseVisualStyleBackColor = True
        '
        'rdoEtyZaimuKbnSuru
        '
        Me.rdoEtyZaimuKbnSuru.AutoSize = True
        Me.rdoEtyZaimuKbnSuru.Checked = True
        Me.rdoEtyZaimuKbnSuru.Location = New System.Drawing.Point(10, 15)
        Me.rdoEtyZaimuKbnSuru.Name = "rdoEtyZaimuKbnSuru"
        Me.rdoEtyZaimuKbnSuru.Size = New System.Drawing.Size(66, 16)
        Me.rdoEtyZaimuKbnSuru.TabIndex = 0
        Me.rdoEtyZaimuKbnSuru.TabStop = True
        Me.rdoEtyZaimuKbnSuru.Text = "関与する"
        Me.rdoEtyZaimuKbnSuru.UseVisualStyleBackColor = True
        '
        'grpEtyDosaKbn
        '
        Me.grpEtyDosaKbn.Controls.Add(Me.rdoEtyDosaKbnShuko)
        Me.grpEtyDosaKbn.Controls.Add(Me.rdoEtyDosaKbnNyuko)
        Me.grpEtyDosaKbn.Location = New System.Drawing.Point(119, 73)
        Me.grpEtyDosaKbn.Name = "grpEtyDosaKbn"
        Me.grpEtyDosaKbn.Size = New System.Drawing.Size(174, 40)
        Me.grpEtyDosaKbn.TabIndex = 3
        Me.grpEtyDosaKbn.TabStop = False
        '
        'rdoEtyDosaKbnShuko
        '
        Me.rdoEtyDosaKbnShuko.AutoSize = True
        Me.rdoEtyDosaKbnShuko.Location = New System.Drawing.Point(90, 15)
        Me.rdoEtyDosaKbnShuko.Name = "rdoEtyDosaKbnShuko"
        Me.rdoEtyDosaKbnShuko.Size = New System.Drawing.Size(47, 16)
        Me.rdoEtyDosaKbnShuko.TabIndex = 1
        Me.rdoEtyDosaKbnShuko.Text = "出庫"
        Me.rdoEtyDosaKbnShuko.UseVisualStyleBackColor = True
        '
        'rdoEtyDosaKbnNyuko
        '
        Me.rdoEtyDosaKbnNyuko.AutoSize = True
        Me.rdoEtyDosaKbnNyuko.Checked = True
        Me.rdoEtyDosaKbnNyuko.Location = New System.Drawing.Point(10, 15)
        Me.rdoEtyDosaKbnNyuko.Name = "rdoEtyDosaKbnNyuko"
        Me.rdoEtyDosaKbnNyuko.Size = New System.Drawing.Size(47, 16)
        Me.rdoEtyDosaKbnNyuko.TabIndex = 0
        Me.rdoEtyDosaKbnNyuko.TabStop = True
        Me.rdoEtyDosaKbnNyuko.Text = "入庫"
        Me.rdoEtyDosaKbnNyuko.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 12)
        Me.Label2.TabIndex = 416
        Me.Label2.Text = "事由名称"
        '
        'txtEtyJiyuNm
        '
        Me.txtEtyJiyuNm.BackColor = System.Drawing.SystemColors.Control
        Me.txtEtyJiyuNm.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtEtyJiyuNm.Location = New System.Drawing.Point(119, 48)
        Me.txtEtyJiyuNm.MaxLength = 15
        Me.txtEtyJiyuNm.Name = "txtEtyJiyuNm"
        Me.txtEtyJiyuNm.Size = New System.Drawing.Size(207, 19)
        Me.txtEtyJiyuNm.TabIndex = 2
        '
        'txtEtyJiyuCd
        '
        Me.txtEtyJiyuCd.BackColor = System.Drawing.Color.White
        Me.txtEtyJiyuCd.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtEtyJiyuCd.Location = New System.Drawing.Point(119, 23)
        Me.txtEtyJiyuCd.MaxLength = 2
        Me.txtEtyJiyuCd.Name = "txtEtyJiyuCd"
        Me.txtEtyJiyuCd.Size = New System.Drawing.Size(24, 19)
        Me.txtEtyJiyuCd.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 12)
        Me.Label3.TabIndex = 412
        Me.Label3.Text = "事由コード"
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 12)
        Me.Label15.TabIndex = 329
        Me.Label15.Text = "財務区分"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 12)
        Me.Label11.TabIndex = 329
        Me.Label11.Text = "入出庫区分"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 12)
        Me.Label1.TabIndex = 407
        Me.Label1.Text = "事由コード"
        '
        'txtFindJiyuCd
        '
        Me.txtFindJiyuCd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFindJiyuCd.BackColor = System.Drawing.Color.White
        Me.txtFindJiyuCd.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtFindJiyuCd.Location = New System.Drawing.Point(283, 48)
        Me.txtFindJiyuCd.Name = "txtFindJiyuCd"
        Me.txtFindJiyuCd.Size = New System.Drawing.Size(24, 19)
        Me.txtFindJiyuCd.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grpEtyZaimuKbn)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.grpEtyDosaKbn)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtEtyJiyuNm)
        Me.GroupBox3.Controls.Add(Me.txtEtyJiyuCd)
        Me.GroupBox3.Location = New System.Drawing.Point(188, 415)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(492, 168)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "入力"
        '
        'frmMJiyu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = true
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtFindJiyuCd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvFindJiyu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = true
        Me.MinimizeBox = true
        Me.Name = "frmMJiyu"
        Me.Text = "事由マスタメンテナンス"
        Me.Controls.SetChildIndex(Me.dgvFindJiyu, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtFindJiyuCd, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        CType(Me.dgvFindJiyu,System.ComponentModel.ISupportInitialize).EndInit
        Me.grpEtyZaimuKbn.ResumeLayout(false)
        Me.grpEtyZaimuKbn.PerformLayout
        Me.grpEtyDosaKbn.ResumeLayout(false)
        Me.grpEtyDosaKbn.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents dgvFindJiyu As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFindJiyuCd As System.Windows.Forms.TextBox
    Friend WithEvents txtEtyJiyuNm As System.Windows.Forms.TextBox
    Friend WithEvents txtEtyJiyuCd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpEtyZaimuKbn As System.Windows.Forms.GroupBox
    Friend WithEvents rdoEtyZaimuKbnSinai As System.Windows.Forms.RadioButton
    Friend WithEvents rdoEtyZaimuKbnSuru As System.Windows.Forms.RadioButton
    Friend WithEvents grpEtyDosaKbn As System.Windows.Forms.GroupBox
    Friend WithEvents rdoEtyDosaKbnShuko As System.Windows.Forms.RadioButton
    Friend WithEvents rdoEtyDosaKbnNyuko As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents colJiyuCd As DataGridViewTextBoxColumn
    Friend WithEvents colJiyuNm As DataGridViewTextBoxColumn
    Friend WithEvents colDosaKbn As DataGridViewTextBoxColumn
    Friend WithEvents colZaimuKbn As DataGridViewTextBoxColumn
End Class
