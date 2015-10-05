<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrosiKenpin04
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt強制完了 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvkenpin4 = New System.Windows.Forms.DataGridView()
        Me.colエリア区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品ｺｰﾄﾞ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col欠品数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予定検品数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col実績検品数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvkenpin4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(6, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(997, 55)
        Me.Panel2.TabIndex = 207
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 29)
        Me.Label2.TabIndex = 212
        Me.Label2.Text = "検品結果："
        '
        'bt強制完了
        '
        Me.bt強制完了.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt強制完了.Location = New System.Drawing.Point(11, 553)
        Me.bt強制完了.Name = "bt強制完了"
        Me.bt強制完了.Size = New System.Drawing.Size(226, 44)
        Me.bt強制完了.TabIndex = 216
        Me.bt強制完了.Text = "不足リスト再発行(F1)"
        Me.bt強制完了.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(55, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(900, 58)
        Me.Panel3.TabIndex = 217
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Red
        Me.Label10.Font = New System.Drawing.Font("ＭＳ ゴシック", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(413, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 37)
        Me.Label10.TabIndex = 222
        Me.Label10.Text = "欠品発生"
        '
        'dgvkenpin4
        '
        Me.dgvkenpin4.AllowUserToAddRows = False
        Me.dgvkenpin4.AllowUserToDeleteRows = False
        Me.dgvkenpin4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvkenpin4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvkenpin4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkenpin4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colエリア区分, Me.col商品ｺｰﾄﾞ, Me.col欠品数, Me.col予定検品数, Me.col実績検品数, Me.col商品名})
        Me.dgvkenpin4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvkenpin4.Location = New System.Drawing.Point(7, 165)
        Me.dgvkenpin4.MultiSelect = False
        Me.dgvkenpin4.Name = "dgvkenpin4"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvkenpin4.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvkenpin4.RowHeadersVisible = False
        Me.dgvkenpin4.RowHeadersWidth = 20
        Me.dgvkenpin4.RowTemplate.Height = 21
        Me.dgvkenpin4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvkenpin4.Size = New System.Drawing.Size(996, 348)
        Me.dgvkenpin4.TabIndex = 233
        '
        'colエリア区分
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colエリア区分.DefaultCellStyle = DataGridViewCellStyle10
        Me.colエリア区分.FillWeight = 65.67375!
        Me.colエリア区分.HeaderText = "ｴﾘｱ区分"
        Me.colエリア区分.Name = "colエリア区分"
        Me.colエリア区分.ReadOnly = True
        Me.colエリア区分.Width = 170
        '
        'col商品ｺｰﾄﾞ
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品ｺｰﾄﾞ.DefaultCellStyle = DataGridViewCellStyle11
        Me.col商品ｺｰﾄﾞ.FillWeight = 166.454!
        Me.col商品ｺｰﾄﾞ.HeaderText = "共通商品ｺｰﾄﾞ"
        Me.col商品ｺｰﾄﾞ.Name = "col商品ｺｰﾄﾞ"
        Me.col商品ｺｰﾄﾞ.Width = 140
        '
        'col欠品数
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col欠品数.DefaultCellStyle = DataGridViewCellStyle12
        Me.col欠品数.FillWeight = 63.39286!
        Me.col欠品数.HeaderText = "欠品数"
        Me.col欠品数.Name = "col欠品数"
        Me.col欠品数.ReadOnly = True
        Me.col欠品数.Width = 120
        '
        'col予定検品数
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col予定検品数.DefaultCellStyle = DataGridViewCellStyle13
        Me.col予定検品数.FillWeight = 61.88326!
        Me.col予定検品数.HeaderText = "予定検品数"
        Me.col予定検品数.Name = "col予定検品数"
        Me.col予定検品数.ReadOnly = True
        Me.col予定検品数.Width = 120
        '
        'col実績検品数
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col実績検品数.DefaultCellStyle = DataGridViewCellStyle14
        Me.col実績検品数.FillWeight = 76.14212!
        Me.col実績検品数.HeaderText = "実績検品数"
        Me.col実績検品数.Name = "col実績検品数"
        Me.col実績検品数.ReadOnly = True
        Me.col実績検品数.Width = 120
        '
        'col商品名
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品名.DefaultCellStyle = DataGridViewCellStyle15
        Me.col商品名.FillWeight = 166.454!
        Me.col商品名.HeaderText = "商品名"
        Me.col商品名.Name = "col商品名"
        Me.col商品名.ReadOnly = True
        Me.col商品名.Width = 300
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(782, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 44)
        Me.Button1.TabIndex = 235
        Me.Button1.Text = "次検品へ(F2)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("ＭＳ ゴシック", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(383, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(607, 33)
        Me.Label12.TabIndex = 213
        Me.Label12.Text = "出荷先:出荷先名称出荷先名称出荷先名称"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 33)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "出荷指示No:1234567890"
        '
        '卸エリア検品4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt強制完了)
        Me.Controls.Add(Me.dgvkenpin4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "卸エリア検品4"
        Me.Text = "卸エリア検品"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.dgvkenpin4, 0)
        Me.Controls.SetChildIndex(Me.bt強制完了, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvkenpin4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt強制完了 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvkenpin4 As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents colエリア区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品ｺｰﾄﾞ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col欠品数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col予定検品数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col実績検品数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
