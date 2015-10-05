<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTanaOrosiWarning
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
        Me.bt終了 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bt在庫更新 = New System.Windows.Forms.Button()
        Me.bt棚卸差異リスト発行 = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.rb在庫更新 = New System.Windows.Forms.RadioButton()
        Me.rb棚卸差異リスト発行 = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt終了
        '
        Me.bt終了.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt終了.Location = New System.Drawing.Point(651, 8)
        Me.bt終了.Name = "bt終了"
        Me.bt終了.Size = New System.Drawing.Size(141, 31)
        Me.bt終了.TabIndex = 144
        Me.bt終了.Text = "戻る(F12)"
        Me.bt終了.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.bt終了)
        Me.Panel2.Location = New System.Drawing.Point(-9, 375)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 52)
        Me.Panel2.TabIndex = 135
        '
        'bt在庫更新
        '
        Me.bt在庫更新.Font = New System.Drawing.Font("ＭＳ ゴシック", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt在庫更新.Location = New System.Drawing.Point(406, 250)
        Me.bt在庫更新.Name = "bt在庫更新"
        Me.bt在庫更新.Size = New System.Drawing.Size(351, 77)
        Me.bt在庫更新.TabIndex = 360
        Me.bt在庫更新.Text = "在庫更新"
        Me.bt在庫更新.UseVisualStyleBackColor = True
        '
        'bt棚卸差異リスト発行
        '
        Me.bt棚卸差異リスト発行.Font = New System.Drawing.Font("ＭＳ ゴシック", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.bt棚卸差異リスト発行.Location = New System.Drawing.Point(39, 250)
        Me.bt棚卸差異リスト発行.Name = "bt棚卸差異リスト発行"
        Me.bt棚卸差異リスト発行.Size = New System.Drawing.Size(351, 77)
        Me.bt棚卸差異リスト発行.TabIndex = 359
        Me.bt棚卸差異リスト発行.Text = "棚卸差異リスト発行"
        Me.bt棚卸差異リスト発行.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rb在庫更新)
        Me.GroupBox8.Controls.Add(Me.rb棚卸差異リスト発行)
        Me.GroupBox8.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(39, 143)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(718, 82)
        Me.GroupBox8.TabIndex = 358
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "確認"
        '
        'rb在庫更新
        '
        Me.rb在庫更新.AutoSize = True
        Me.rb在庫更新.Location = New System.Drawing.Point(47, 50)
        Me.rb在庫更新.Name = "rb在庫更新"
        Me.rb在庫更新.Size = New System.Drawing.Size(261, 20)
        Me.rb在庫更新.TabIndex = 1
        Me.rb在庫更新.Text = "既に差異リストにて確認済みです。"
        Me.rb在庫更新.UseVisualStyleBackColor = True
        '
        'rb棚卸差異リスト発行
        '
        Me.rb棚卸差異リスト発行.AutoSize = True
        Me.rb棚卸差異リスト発行.Checked = True
        Me.rb棚卸差異リスト発行.Location = New System.Drawing.Point(47, 18)
        Me.rb棚卸差異リスト発行.Name = "rb棚卸差異リスト発行"
        Me.rb棚卸差異リスト発行.Size = New System.Drawing.Size(229, 20)
        Me.rb棚卸差異リスト発行.TabIndex = 0
        Me.rb棚卸差異リスト発行.TabStop = True
        Me.rb棚卸差異リスト発行.Text = "棚卸差異リストを発行します。"
        Me.rb棚卸差異リスト発行.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("ＭＳ ゴシック", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(32, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(758, 74)
        Me.Label18.TabIndex = 361
        Me.Label18.Text = "棚卸結果に差異が発生しています。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "棚卸差異リストにて再度確認して下さい。"
        '
        '棚卸警告
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 425)
        Me.Controls.Add(Me.bt在庫更新)
        Me.Controls.Add(Me.bt棚卸差異リスト発行)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Name = "棚卸警告"
        Me.Text = "棚卸警告"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt終了 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bt在庫更新 As System.Windows.Forms.Button
    Friend WithEvents bt棚卸差異リスト発行 As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rb在庫更新 As System.Windows.Forms.RadioButton
    Friend WithEvents rb棚卸差異リスト発行 As System.Windows.Forms.RadioButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
