<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChokiTairyuLst
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvZaiko = New System.Windows.Forms.DataGridView()
        Me.col格納倉庫 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col棚No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col商品名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col予約区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col賞味期限 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colロットNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col入荷日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col初回入荷日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col最終出荷日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col在庫数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col品質区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col荷主区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col予約理由 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colデータ作成日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col関連会社コード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col規格 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvZaiko, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvZaiko
        '
        Me.dgvZaiko.AllowUserToAddRows = False
        Me.dgvZaiko.AllowUserToDeleteRows = False
        Me.dgvZaiko.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvZaiko.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvZaiko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvZaiko.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col格納倉庫, Me.Col棚No, Me.col商品コード, Me.col商品名, Me.Col予約区分, Me.col賞味期限, Me.colロットNo, Me.col入荷日, Me.col初回入荷日, Me.Col最終出荷日, Me.col在庫数, Me.col品質区分, Me.col荷主区分, Me.col備考, Me.col予約理由, Me.Colデータ作成日, Me.Col関連会社コード, Me.col規格})
        Me.dgvZaiko.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvZaiko.Location = New System.Drawing.Point(6, 134)
        Me.dgvZaiko.MultiSelect = False
        Me.dgvZaiko.Name = "dgvZaiko"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvZaiko.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvZaiko.RowHeadersVisible = False
        Me.dgvZaiko.RowHeadersWidth = 20
        Me.dgvZaiko.RowTemplate.Height = 21
        Me.dgvZaiko.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvZaiko.Size = New System.Drawing.Size(997, 484)
        Me.dgvZaiko.TabIndex = 269
        '
        'col格納倉庫
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col格納倉庫.DefaultCellStyle = DataGridViewCellStyle2
        Me.col格納倉庫.HeaderText = "格納倉庫"
        Me.col格納倉庫.Name = "col格納倉庫"
        '
        'Col棚No
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col棚No.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col棚No.HeaderText = "棚No"
        Me.Col棚No.Name = "Col棚No"
        Me.Col棚No.ReadOnly = True
        Me.Col棚No.Width = 90
        '
        'col商品コード
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.col商品コード.DefaultCellStyle = DataGridViewCellStyle4
        Me.col商品コード.FillWeight = 134.3357!
        Me.col商品コード.HeaderText = "共通商品ｺｰﾄﾞ"
        Me.col商品コード.Name = "col商品コード"
        Me.col商品コード.ReadOnly = True
        Me.col商品コード.Width = 120
        '
        'col商品名
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col商品名.DefaultCellStyle = DataGridViewCellStyle5
        Me.col商品名.FillWeight = 156.5466!
        Me.col商品名.HeaderText = "商品名"
        Me.col商品名.Name = "col商品名"
        Me.col商品名.ReadOnly = True
        Me.col商品名.Width = 300
        '
        'Col予約区分
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col予約区分.DefaultCellStyle = DataGridViewCellStyle6
        Me.Col予約区分.HeaderText = "予約区分"
        Me.Col予約区分.Name = "Col予約区分"
        Me.Col予約区分.ReadOnly = True
        Me.Col予約区分.Width = 80
        '
        'col賞味期限
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col賞味期限.DefaultCellStyle = DataGridViewCellStyle7
        Me.col賞味期限.FillWeight = 52.46462!
        Me.col賞味期限.HeaderText = "賞味期限"
        Me.col賞味期限.Name = "col賞味期限"
        Me.col賞味期限.ReadOnly = True
        Me.col賞味期限.Width = 90
        '
        'colロットNo
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colロットNo.DefaultCellStyle = DataGridViewCellStyle8
        Me.colロットNo.FillWeight = 136.9782!
        Me.colロットNo.HeaderText = "ﾛｯﾄNo"
        Me.colロットNo.Name = "colロットNo"
        Me.colロットNo.ReadOnly = True
        Me.colロットNo.Width = 80
        '
        'col入荷日
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col入荷日.DefaultCellStyle = DataGridViewCellStyle9
        Me.col入荷日.HeaderText = "入荷日"
        Me.col入荷日.Name = "col入荷日"
        Me.col入荷日.ReadOnly = True
        Me.col入荷日.Width = 80
        '
        'col初回入荷日
        '
        Me.col初回入荷日.HeaderText = "初回入荷日"
        Me.col初回入荷日.Name = "col初回入荷日"
        '
        'Col最終出荷日
        '
        Me.Col最終出荷日.HeaderText = "最終出荷日"
        Me.Col最終出荷日.Name = "Col最終出荷日"
        '
        'col在庫数
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col在庫数.DefaultCellStyle = DataGridViewCellStyle10
        Me.col在庫数.FillWeight = 78.95775!
        Me.col在庫数.HeaderText = "在庫数"
        Me.col在庫数.Name = "col在庫数"
        Me.col在庫数.ReadOnly = True
        Me.col在庫数.Width = 90
        '
        'col品質区分
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col品質区分.DefaultCellStyle = DataGridViewCellStyle11
        Me.col品質区分.FillWeight = 49.09086!
        Me.col品質区分.HeaderText = "品質区分"
        Me.col品質区分.Name = "col品質区分"
        Me.col品質区分.ReadOnly = True
        Me.col品質区分.Width = 80
        '
        'col荷主区分
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col荷主区分.DefaultCellStyle = DataGridViewCellStyle12
        Me.col荷主区分.FillWeight = 43.38193!
        Me.col荷主区分.HeaderText = "荷主区分"
        Me.col荷主区分.Name = "col荷主区分"
        Me.col荷主区分.ReadOnly = True
        Me.col荷主区分.Width = 80
        '
        'col備考
        '
        Me.col備考.HeaderText = "備考"
        Me.col備考.Name = "col備考"
        Me.col備考.Width = 300
        '
        'col予約理由
        '
        Me.col予約理由.HeaderText = "予約理由"
        Me.col予約理由.Name = "col予約理由"
        Me.col予約理由.Width = 300
        '
        'Colデータ作成日
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Colデータ作成日.DefaultCellStyle = DataGridViewCellStyle13
        Me.Colデータ作成日.HeaderText = "ﾃﾞｰﾀ作成日"
        Me.Colデータ作成日.Name = "Colデータ作成日"
        Me.Colデータ作成日.ReadOnly = True
        Me.Colデータ作成日.Width = 90
        '
        'Col関連会社コード
        '
        Me.Col関連会社コード.HeaderText = "関連会社ｺｰﾄﾞ"
        Me.Col関連会社コード.Name = "Col関連会社コード"
        Me.Col関連会社コード.ReadOnly = True
        Me.Col関連会社コード.Width = 120
        '
        'col規格
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col規格.DefaultCellStyle = DataGridViewCellStyle14
        Me.col規格.FillWeight = 37.27981!
        Me.col規格.HeaderText = "規格"
        Me.col規格.Name = "col規格"
        Me.col規格.ReadOnly = True
        Me.col規格.Width = 130
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 12)
        Me.Label1.TabIndex = 401
        Me.Label1.Text = "ヶ月"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(241, 106)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(29, 22)
        Me.TextBox3.TabIndex = 400
        Me.TextBox3.Text = "Z9"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(149, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 12)
        Me.Label10.TabIndex = 399
        Me.Label10.Text = "滞留期間"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 12)
        Me.Label2.TabIndex = 402
        Me.Label2.Text = "エリア"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"バックヤード", "通販C品ピッキングエリア", "通販DPSピッキングエリア", "通販集約品ピッキングエリア", "卸通常品ピッキングエリア", "卸集約品ピッキングエリア"})
        Me.ComboBox1.Location = New System.Drawing.Point(241, 77)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 20)
        Me.ComboBox1.TabIndex = 403
        Me.ComboBox1.Text = "全て"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(561, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 12)
        Me.Label3.TabIndex = 406
        Me.Label3.Text = "ヶ月"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(526, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(29, 22)
        Me.TextBox1.TabIndex = 405
        Me.TextBox1.Text = "Z9"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 12)
        Me.Label4.TabIndex = 404
        Me.Label4.Text = "未出荷期間"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"XX：あいうえお", "01：AFC本社"})
        Me.ComboBox2.Location = New System.Drawing.Point(241, 47)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(104, 20)
        Me.ComboBox2.TabIndex = 1050
        Me.ComboBox2.Text = "XX：あいうえお"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(149, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 12)
        Me.Label5.TabIndex = 1049
        Me.Label5.Text = "格納倉庫"
        '
        '長期滞留品在庫問合せ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = True
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgvZaiko)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "長期滞留品在庫問合せ"
        Me.Text = "長期滞留品在庫問合せ"
        Me.Controls.SetChildIndex(Me.dgvZaiko, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TextBox3, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.ComboBox2, 0)
        CType(Me.dgvZaiko, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvZaiko As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents col格納倉庫 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col棚No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col商品名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col予約区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col賞味期限 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colロットNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col入荷日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col初回入荷日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col最終出荷日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col在庫数 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col品質区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col荷主区分 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col備考 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col予約理由 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colデータ作成日 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col関連会社コード As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col規格 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
