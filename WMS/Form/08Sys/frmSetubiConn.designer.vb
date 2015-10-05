<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetubiConn
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.rdbEnd = New System.Windows.Forms.RadioButton()
        Me.rdbStart = New System.Windows.Forms.RadioButton()
        Me.cmbSYSINFO = New System.Windows.Forms.ComboBox()
        Me.dgv_State1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt設定 = New System.Windows.Forms.Button()
        Me.bt終了 = New System.Windows.Forms.Button()
        Me.dgv_State2 = New System.Windows.Forms.DataGridView()
        Me.lblState = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_State1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_State2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbEnd
        '
        Me.rdbEnd.AutoSize = True
        Me.rdbEnd.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdbEnd.Location = New System.Drawing.Point(503, 19)
        Me.rdbEnd.Name = "rdbEnd"
        Me.rdbEnd.Size = New System.Drawing.Size(79, 23)
        Me.rdbEnd.TabIndex = 513
        Me.rdbEnd.Text = "切離し"
        Me.rdbEnd.UseVisualStyleBackColor = True
        '
        'rdbStart
        '
        Me.rdbStart.AutoSize = True
        Me.rdbStart.Checked = True
        Me.rdbStart.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.rdbStart.Location = New System.Drawing.Point(416, 19)
        Me.rdbStart.Name = "rdbStart"
        Me.rdbStart.Size = New System.Drawing.Size(65, 23)
        Me.rdbStart.TabIndex = 512
        Me.rdbStart.TabStop = True
        Me.rdbStart.Text = "接続"
        Me.rdbStart.UseVisualStyleBackColor = True
        '
        'cmbSYSINFO
        '
        Me.cmbSYSINFO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSYSINFO.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbSYSINFO.FormattingEnabled = True
        Me.cmbSYSINFO.Items.AddRange(New Object() {"第一ｸﾚｰﾝ制御盤", "1Fｱｲﾙｺﾝﾍﾞｱ制御盤", "3Fｱｲﾙｺﾝﾍﾞｱ制御盤", "3F_BC品ｺﾝﾍﾞｱ制御盤", "第一1F_EN盤(EN11)", "第一2F_EN盤(EN12)", "第二3F_EN盤(EN22)", "第二ｸﾚｰﾝ地上設定盤", "SLｶｰﾄｺﾝﾄﾛｰﾗ"})
        Me.cmbSYSINFO.Location = New System.Drawing.Point(18, 16)
        Me.cmbSYSINFO.MaxDropDownItems = 20
        Me.cmbSYSINFO.Name = "cmbSYSINFO"
        Me.cmbSYSINFO.Size = New System.Drawing.Size(375, 29)
        Me.cmbSYSINFO.TabIndex = 511
        '
        'dgv_State1
        '
        Me.dgv_State1.AllowUserToAddRows = False
        Me.dgv_State1.AllowUserToDeleteRows = False
        Me.dgv_State1.AllowUserToResizeColumns = False
        Me.dgv_State1.AllowUserToResizeRows = False
        Me.dgv_State1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_State1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_State1.Location = New System.Drawing.Point(18, 60)
        Me.dgv_State1.Name = "dgv_State1"
        Me.dgv_State1.ReadOnly = True
        Me.dgv_State1.RowHeadersVisible = False
        Me.dgv_State1.RowHeadersWidth = 4
        Me.dgv_State1.RowTemplate.Height = 21
        Me.dgv_State1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_State1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_State1.Size = New System.Drawing.Size(375, 256)
        Me.dgv_State1.TabIndex = 510
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.bt設定)
        Me.Panel2.Controls.Add(Me.bt終了)
        Me.Panel2.Location = New System.Drawing.Point(-1, 325)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 52)
        Me.Panel2.TabIndex = 514
        '
        'bt設定
        '
        Me.bt設定.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt設定.Location = New System.Drawing.Point(22, 10)
        Me.bt設定.Name = "bt設定"
        Me.bt設定.Size = New System.Drawing.Size(141, 31)
        Me.bt設定.TabIndex = 1
        Me.bt設定.Text = "設定(F2)"
        Me.bt設定.UseVisualStyleBackColor = True
        '
        'bt終了
        '
        Me.bt終了.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt終了.Location = New System.Drawing.Point(630, 10)
        Me.bt終了.Name = "bt終了"
        Me.bt終了.Size = New System.Drawing.Size(141, 31)
        Me.bt終了.TabIndex = 0
        Me.bt終了.Text = "戻る(F12)"
        Me.bt終了.UseVisualStyleBackColor = True
        '
        'dgv_State2
        '
        Me.dgv_State2.AllowUserToAddRows = False
        Me.dgv_State2.AllowUserToDeleteRows = False
        Me.dgv_State2.AllowUserToResizeColumns = False
        Me.dgv_State2.AllowUserToResizeRows = False
        Me.dgv_State2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_State2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgv_State2.Location = New System.Drawing.Point(401, 60)
        Me.dgv_State2.Name = "dgv_State2"
        Me.dgv_State2.ReadOnly = True
        Me.dgv_State2.RowHeadersVisible = False
        Me.dgv_State2.RowHeadersWidth = 4
        Me.dgv_State2.RowTemplate.Height = 21
        Me.dgv_State2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_State2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_State2.Size = New System.Drawing.Size(375, 235)
        Me.dgv_State2.TabIndex = 515
        '
        'lblState
        '
        Me.lblState.BackColor = System.Drawing.Color.White
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblState.Font = New System.Drawing.Font("ＭＳ ゴシック", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblState.Location = New System.Drawing.Point(631, 14)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(141, 32)
        Me.lblState.TabIndex = 516
        Me.lblState.Text = "切離中"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Column1
        '
        Me.Column1.HeaderText = "設備名称"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 270
        '
        'Column2
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "状態"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "InfoCD"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "設備名称"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 270
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "状態"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "InfoCD"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        '接続切離し設定
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 389)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.dgv_State2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.rdbEnd)
        Me.Controls.Add(Me.rdbStart)
        Me.Controls.Add(Me.cmbSYSINFO)
        Me.Controls.Add(Me.dgv_State1)
        Me.KeyPreview = True
        Me.Name = "接続切離し設定"
        Me.Text = "接続切離し設定"
        CType(Me.dgv_State1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_State2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbEnd As System.Windows.Forms.RadioButton
    Friend WithEvents rdbStart As System.Windows.Forms.RadioButton
    Friend WithEvents cmbSYSINFO As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_State1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bt設定 As System.Windows.Forms.Button
    Friend WithEvents bt終了 As System.Windows.Forms.Button
    Friend WithEvents dgv_State2 As System.Windows.Forms.DataGridView
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
