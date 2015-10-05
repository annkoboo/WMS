<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTanaOrosiZanLst
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt終了 = New System.Windows.Forms.Button()
        Me.dgvMeisai = New System.Windows.Forms.DataGridView()
        Me.colエリア = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col対象件数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col未確認件数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMeisai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.bt終了)
        Me.Panel2.Location = New System.Drawing.Point(-9, 378)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 52)
        Me.Panel2.TabIndex = 135
        '
        'bt終了
        '
        Me.bt終了.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt終了.Location = New System.Drawing.Point(251, 14)
        Me.bt終了.Name = "bt終了"
        Me.bt終了.Size = New System.Drawing.Size(141, 31)
        Me.bt終了.TabIndex = 144
        Me.bt終了.Text = "戻る(F12)"
        Me.bt終了.UseVisualStyleBackColor = True
        '
        'dgvMeisai
        '
        Me.dgvMeisai.AllowUserToAddRows = False
        Me.dgvMeisai.AllowUserToDeleteRows = False
        Me.dgvMeisai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMeisai.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMeisai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMeisai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colエリア, Me.Col対象件数, Me.Col未確認件数})
        Me.dgvMeisai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvMeisai.Location = New System.Drawing.Point(19, 19)
        Me.dgvMeisai.MultiSelect = False
        Me.dgvMeisai.Name = "dgvMeisai"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMeisai.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMeisai.RowHeadersVisible = False
        Me.dgvMeisai.RowHeadersWidth = 20
        Me.dgvMeisai.RowTemplate.Height = 21
        Me.dgvMeisai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMeisai.Size = New System.Drawing.Size(366, 347)
        Me.dgvMeisai.TabIndex = 414
        '
        'colエリア
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colエリア.DefaultCellStyle = DataGridViewCellStyle2
        Me.colエリア.HeaderText = "エリア"
        Me.colエリア.Name = "colエリア"
        Me.colエリア.ReadOnly = True
        Me.colエリア.Width = 140
        '
        'Col対象件数
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col対象件数.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col対象件数.HeaderText = "対象件数"
        Me.Col対象件数.Name = "Col対象件数"
        Me.Col対象件数.ReadOnly = True
        '
        'Col未確認件数
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Col未確認件数.DefaultCellStyle = DataGridViewCellStyle4
        Me.Col未確認件数.HeaderText = "未確認件数"
        Me.Col未確認件数.Name = "Col未確認件数"
        Me.Col未確認件数.ReadOnly = True
        '
        '棚卸残作業一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 428)
        Me.Controls.Add(Me.dgvMeisai)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "棚卸残作業一覧"
        Me.Text = "棚卸残作業一覧"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvMeisai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bt終了 As System.Windows.Forms.Button
    Friend WithEvents dgvMeisai As System.Windows.Forms.DataGridView
    Friend WithEvents colエリア As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col対象件数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col未確認件数 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
