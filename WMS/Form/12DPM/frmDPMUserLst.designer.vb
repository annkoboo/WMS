<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDPMUserLst
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
        Me.dgvWork = New System.Windows.Forms.DataGridView()
        Me.ColラインNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColゾーンNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col作業者コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col作業者名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvWork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvWork
        '
        Me.dgvWork.AllowUserToAddRows = False
        Me.dgvWork.AllowUserToDeleteRows = False
        Me.dgvWork.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvWork.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWork.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColラインNo, Me.ColゾーンNo, Me.Col作業者コード, Me.Col作業者名})
        Me.dgvWork.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvWork.Location = New System.Drawing.Point(33, 38)
        Me.dgvWork.MultiSelect = False
        Me.dgvWork.Name = "dgvWork"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvWork.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvWork.RowHeadersVisible = False
        Me.dgvWork.RowHeadersWidth = 20
        Me.dgvWork.RowTemplate.Height = 21
        Me.dgvWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvWork.Size = New System.Drawing.Size(573, 393)
        Me.dgvWork.TabIndex = 0
        '
        'ColラインNo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ColラインNo.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColラインNo.HeaderText = "ラインNo"
        Me.ColラインNo.Name = "ColラインNo"
        Me.ColラインNo.ReadOnly = True
        '
        'ColゾーンNo
        '
        Me.ColゾーンNo.HeaderText = "ゾーンNo"
        Me.ColゾーンNo.Name = "ColゾーンNo"
        Me.ColゾーンNo.ReadOnly = True
        '
        'Col作業者コード
        '
        Me.Col作業者コード.HeaderText = "作業者コード"
        Me.Col作業者コード.Name = "Col作業者コード"
        Me.Col作業者コード.ReadOnly = True
        '
        'Col作業者名
        '
        Me.Col作業者名.HeaderText = "作業者名"
        Me.Col作業者名.Name = "Col作業者名"
        Me.Col作業者名.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvWork)
        Me.GroupBox1.Location = New System.Drawing.Point(113, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(719, 471)
        Me.GroupBox1.TabIndex = 320
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "作業状況"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.Font = New System.Drawing.Font("ＭＳ ゴシック", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(326, 573)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(127, 28)
        Me.TextBox2.TabIndex = 344
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "あいうえお"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 576)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 21)
        Me.Label2.TabIndex = 345
        Me.Label2.Text = "システム状態"
        '
        'ピッキング作業_中断
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "ピッキング作業_中断"
        Me.Text = "DPS作業者登録"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        CType(Me.dgvWork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvWork As System.Windows.Forms.DataGridView
    Friend WithEvents ColラインNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColゾーンNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col作業者コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col作業者名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
