Imports System.Reflection.MethodInfo

Public Class C02Popup
    Inherits System.Windows.Forms.Form

#Region " Windows フォーム デザイナで生成されたコード "

    Public Sub New()
        MyBase.New()

        ' この呼び出しは Windows フォーム デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後に初期化を追加します。

    End Sub

    ' Form は、コンポーネント一覧に後処理を実行するために dispose をオーバーライドします。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    ' メモ : 以下のプロシージャは、Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使って変更してください。  
    ' コード エディタを使って変更しないでください。
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblF12 As System.Windows.Forms.Label
    Friend WithEvents btnF12 As System.Windows.Forms.Button
    Friend WithEvents lblF11 As System.Windows.Forms.Label
    Friend WithEvents btnF11 As System.Windows.Forms.Button
    Friend WithEvents lblF10 As System.Windows.Forms.Label
    Friend WithEvents btnF10 As System.Windows.Forms.Button
    Friend WithEvents lblF09 As System.Windows.Forms.Label
    Friend WithEvents btnF09 As System.Windows.Forms.Button
    Friend WithEvents lblF04 As System.Windows.Forms.Label
    Friend WithEvents btnF04 As System.Windows.Forms.Button
    Friend WithEvents lblF03 As System.Windows.Forms.Label
    Friend WithEvents btnF03 As System.Windows.Forms.Button
    Friend WithEvents lblF02 As System.Windows.Forms.Label
    Friend WithEvents btnF02 As System.Windows.Forms.Button
    Friend WithEvents lblF01 As System.Windows.Forms.Label
    Friend WithEvents btnF01 As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents stbInfo As System.Windows.Forms.StatusBar
    Friend WithEvents sbpInfo As System.Windows.Forms.StatusBarPanel
    Friend WithEvents sbpProgress As System.Windows.Forms.StatusBarPanel
    Friend WithEvents btnDummy As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblF12 = New System.Windows.Forms.Label()
        Me.btnF12 = New System.Windows.Forms.Button()
        Me.lblF11 = New System.Windows.Forms.Label()
        Me.btnF11 = New System.Windows.Forms.Button()
        Me.lblF10 = New System.Windows.Forms.Label()
        Me.btnF10 = New System.Windows.Forms.Button()
        Me.lblF09 = New System.Windows.Forms.Label()
        Me.btnF09 = New System.Windows.Forms.Button()
        Me.lblF04 = New System.Windows.Forms.Label()
        Me.btnF04 = New System.Windows.Forms.Button()
        Me.lblF03 = New System.Windows.Forms.Label()
        Me.btnF03 = New System.Windows.Forms.Button()
        Me.lblF02 = New System.Windows.Forms.Label()
        Me.btnF02 = New System.Windows.Forms.Button()
        Me.lblF01 = New System.Windows.Forms.Label()
        Me.btnF01 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnDummy = New System.Windows.Forms.Button()
        Me.stbInfo = New System.Windows.Forms.StatusBar()
        Me.sbpInfo = New System.Windows.Forms.StatusBarPanel()
        Me.sbpProgress = New System.Windows.Forms.StatusBarPanel()
        Me.Panel1.SuspendLayout()
        CType(Me.sbpInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblF12)
        Me.Panel1.Controls.Add(Me.btnF12)
        Me.Panel1.Controls.Add(Me.lblF11)
        Me.Panel1.Controls.Add(Me.btnF11)
        Me.Panel1.Controls.Add(Me.lblF10)
        Me.Panel1.Controls.Add(Me.btnF10)
        Me.Panel1.Controls.Add(Me.lblF09)
        Me.Panel1.Controls.Add(Me.btnF09)
        Me.Panel1.Controls.Add(Me.lblF04)
        Me.Panel1.Controls.Add(Me.btnF04)
        Me.Panel1.Controls.Add(Me.lblF03)
        Me.Panel1.Controls.Add(Me.btnF03)
        Me.Panel1.Controls.Add(Me.lblF02)
        Me.Panel1.Controls.Add(Me.btnF02)
        Me.Panel1.Controls.Add(Me.lblF01)
        Me.Panel1.Controls.Add(Me.btnF01)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(8, 456)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 88)
        Me.Panel1.TabIndex = 10
        '
        'lblF12
        '
        Me.lblF12.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblF12.Location = New System.Drawing.Point(671, 56)
        Me.lblF12.Name = "lblF12"
        Me.lblF12.Size = New System.Drawing.Size(93, 24)
        Me.lblF12.TabIndex = 23
        Me.lblF12.Text = "F12"
        Me.lblF12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF12
        '
        Me.btnF12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF12.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF12.Location = New System.Drawing.Point(671, 8)
        Me.btnF12.Name = "btnF12"
        Me.btnF12.Size = New System.Drawing.Size(93, 48)
        Me.btnF12.TabIndex = 22
        Me.btnF12.Text = "Button12"
        '
        'lblF11
        '
        Me.lblF11.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblF11.Location = New System.Drawing.Point(578, 56)
        Me.lblF11.Name = "lblF11"
        Me.lblF11.Size = New System.Drawing.Size(93, 24)
        Me.lblF11.TabIndex = 21
        Me.lblF11.Text = "F11"
        Me.lblF11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF11
        '
        Me.btnF11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF11.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF11.Location = New System.Drawing.Point(578, 8)
        Me.btnF11.Name = "btnF11"
        Me.btnF11.Size = New System.Drawing.Size(93, 48)
        Me.btnF11.TabIndex = 20
        Me.btnF11.Text = "Button11"
        '
        'lblF10
        '
        Me.lblF10.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblF10.Location = New System.Drawing.Point(491, 56)
        Me.lblF10.Name = "lblF10"
        Me.lblF10.Size = New System.Drawing.Size(87, 24)
        Me.lblF10.TabIndex = 19
        Me.lblF10.Text = "F10"
        Me.lblF10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF10
        '
        Me.btnF10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF10.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF10.Location = New System.Drawing.Point(485, 8)
        Me.btnF10.Name = "btnF10"
        Me.btnF10.Size = New System.Drawing.Size(93, 48)
        Me.btnF10.TabIndex = 18
        Me.btnF10.Text = "Button10"
        '
        'lblF09
        '
        Me.lblF09.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblF09.Location = New System.Drawing.Point(392, 56)
        Me.lblF09.Name = "lblF09"
        Me.lblF09.Size = New System.Drawing.Size(93, 24)
        Me.lblF09.TabIndex = 17
        Me.lblF09.Text = "F9"
        Me.lblF09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF09
        '
        Me.btnF09.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF09.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF09.Location = New System.Drawing.Point(392, 8)
        Me.btnF09.Name = "btnF09"
        Me.btnF09.Size = New System.Drawing.Size(93, 48)
        Me.btnF09.TabIndex = 16
        Me.btnF09.Text = "Button9"
        '
        'lblF04
        '
        Me.lblF04.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblF04.Location = New System.Drawing.Point(289, 56)
        Me.lblF04.Name = "lblF04"
        Me.lblF04.Size = New System.Drawing.Size(93, 24)
        Me.lblF04.TabIndex = 7
        Me.lblF04.Text = "F4"
        Me.lblF04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF04
        '
        Me.btnF04.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF04.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF04.Location = New System.Drawing.Point(289, 8)
        Me.btnF04.Name = "btnF04"
        Me.btnF04.Size = New System.Drawing.Size(93, 48)
        Me.btnF04.TabIndex = 6
        Me.btnF04.Text = "Button4"
        '
        'lblF03
        '
        Me.lblF03.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblF03.Location = New System.Drawing.Point(191, 56)
        Me.lblF03.Name = "lblF03"
        Me.lblF03.Size = New System.Drawing.Size(97, 24)
        Me.lblF03.TabIndex = 5
        Me.lblF03.Text = "F3"
        Me.lblF03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF03
        '
        Me.btnF03.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF03.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF03.Location = New System.Drawing.Point(195, 8)
        Me.btnF03.Name = "btnF03"
        Me.btnF03.Size = New System.Drawing.Size(93, 48)
        Me.btnF03.TabIndex = 4
        Me.btnF03.Text = "Button3"
        '
        'lblF02
        '
        Me.lblF02.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblF02.Location = New System.Drawing.Point(97, 56)
        Me.lblF02.Name = "lblF02"
        Me.lblF02.Size = New System.Drawing.Size(97, 24)
        Me.lblF02.TabIndex = 3
        Me.lblF02.Text = "F2"
        Me.lblF02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF02
        '
        Me.btnF02.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF02.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF02.Location = New System.Drawing.Point(101, 8)
        Me.btnF02.Name = "btnF02"
        Me.btnF02.Size = New System.Drawing.Size(93, 48)
        Me.btnF02.TabIndex = 2
        Me.btnF02.Text = "Button2"
        '
        'lblF01
        '
        Me.lblF01.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblF01.Location = New System.Drawing.Point(8, 56)
        Me.lblF01.Name = "lblF01"
        Me.lblF01.Size = New System.Drawing.Size(93, 24)
        Me.lblF01.TabIndex = 1
        Me.lblF01.Text = "F1"
        Me.lblF01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF01
        '
        Me.btnF01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF01.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF01.Location = New System.Drawing.Point(8, 8)
        Me.btnF01.Name = "btnF01"
        Me.btnF01.Size = New System.Drawing.Size(93, 48)
        Me.btnF01.TabIndex = 0
        Me.btnF01.Text = "Button1"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTitle.Font = New System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(772, 32)
        Me.lblTitle.TabIndex = 100
        Me.lblTitle.Text = "タイトルを表示"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDummy
        '
        Me.btnDummy.Enabled = False
        Me.btnDummy.Location = New System.Drawing.Point(-64, 0)
        Me.btnDummy.Name = "btnDummy"
        Me.btnDummy.Size = New System.Drawing.Size(75, 23)
        Me.btnDummy.TabIndex = 5
        Me.btnDummy.TabStop = False
        Me.btnDummy.Visible = False
        '
        'stbInfo
        '
        Me.stbInfo.Font = New System.Drawing.Font("ＭＳ ゴシック", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.stbInfo.Location = New System.Drawing.Point(0, 551)
        Me.stbInfo.Name = "stbInfo"
        Me.stbInfo.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.sbpInfo, Me.sbpProgress})
        Me.stbInfo.ShowPanels = True
        Me.stbInfo.Size = New System.Drawing.Size(792, 22)
        Me.stbInfo.TabIndex = 101
        '
        'sbpInfo
        '
        Me.sbpInfo.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.sbpInfo.Name = "sbpInfo"
        Me.sbpInfo.Width = 676
        '
        'sbpProgress
        '
        Me.sbpProgress.Name = "sbpProgress"
        '
        'C02ポップアップフォーム
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.stbInfo)
        Me.Controls.Add(Me.btnDummy)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "C02ポップアップフォーム"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "在庫管理システム"
        Me.Panel1.ResumeLayout(False)
        CType(Me.sbpInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpProgress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region




#Region " 変数宣言部 "
    Public btnEnb(12) As Boolean

#End Region

#Region "プロパティ"
    Protected Overrides ReadOnly Property CreateParams() As  _
     System.Windows.Forms.CreateParams
        Get
            Const CS_NOCLOSE As Integer = &H200
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE

            Return cp
        End Get
    End Property
#End Region
  

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '＜関 数 名＞   :BtnFxxSetEnable
    '＜機能概要＞   :ファンクションボタン使用可否設定
    '＜引　　数＞   :bF01～bF12
    '＜返 却 値＞   :
    '＜作 成 日＞   :2006.10.11
    '＜作 成 者＞   :k.msr
    '＜修正履歴＞   :
    '＜備　　考＞   :
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Public Sub BtnFxxSetEnable(Optional ByVal bF01 As Boolean = False, Optional ByVal bF02 As Boolean = False, Optional ByVal bF03 As Boolean = False, Optional ByVal bF04 As Boolean = False, Optional ByVal bF09 As Boolean = False, Optional ByVal bF10 As Boolean = False, Optional ByVal bF11 As Boolean = False, Optional ByVal bF12 As Boolean = False)
        Try

            Panel1.Enabled = True

            If btnF01.Text.Length <= 0 Then
                btnF01.Enabled = False
            Else
                btnF01.Enabled = bF01
            End If

            If btnF02.Text.Length <= 0 Then
                btnF02.Enabled = False
            Else
                btnF02.Enabled = bF02
            End If

            If btnF03.Text.Length <= 0 Then
                btnF03.Enabled = False
            Else
                btnF03.Enabled = bF03
            End If

            If btnF04.Text.Length <= 0 Then
                btnF04.Enabled = False
            Else
                btnF04.Enabled = bF04
            End If



            If btnF09.Text.Length <= 0 Then
                btnF09.Enabled = False
            Else
                btnF09.Enabled = bF09
            End If

            If btnF10.Text.Length <= 0 Then
                btnF10.Enabled = False
            Else
                btnF10.Enabled = bF10
            End If

            If btnF11.Text.Length <= 0 Then
                btnF11.Enabled = False
            Else
                btnF11.Enabled = bF11
            End If

            If btnF12.Text.Length <= 0 Then
                btnF12.Enabled = False
            Else
                btnF12.Enabled = bF12
            End If

        Catch ex As Exception
            vbErrSub(Me.Name & "<BtnFxxSetEnable>", Err.Number, ex, False, 0) '@@
        End Try
    End Sub



    'ファンクションキー
    Private Sub C02ポップアップフォーム_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F1
                    If btnF01.Enabled Then
                        e.Handled = True
                        btnF01.Focus()
                        btnF01.PerformClick()
                    End If

                Case Keys.F2
                    If btnF02.Enabled Then
                        e.Handled = True
                        btnF02.Focus()
                        btnF02.PerformClick()
                    End If

                Case Keys.F3
                    If btnF03.Enabled Then
                        e.Handled = True
                        btnF03.Focus()
                        btnF03.PerformClick()
                    End If

                Case Keys.F4
                    If btnF04.Enabled Then
                        e.Handled = True
                        btnF04.Focus()
                        btnF04.PerformClick()
                    End If



                Case Keys.F9
                    If btnF09.Enabled Then
                        e.Handled = True
                        btnF09.Focus()
                        btnF09.PerformClick()
                    End If

                Case Keys.F10
                    If btnF10.Enabled Then
                        e.Handled = True
                        btnF10.Focus()
                        btnF10.PerformClick()
                    End If

                Case Keys.F11
                    If btnF11.Enabled Then
                        e.Handled = True
                        btnF11.Focus()
                        btnF11.PerformClick()
                    End If

                Case Keys.F12
                    If btnF12.Enabled Then
                        e.Handled = True
                        btnF12.Focus()
                        btnF12.PerformClick()
                    End If


            End Select
        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub


    Private Sub C02ポップアップフォーム_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'パネルを表示する_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
            stbInfo.ShowPanels = True

            'DateTimePanelの作成
            Dim dtp1 As New DateTimePanel
            '年月日を表示する
            dtp1.Format = "d"
            'StatusBar1に追加する
            stbInfo.Panels.Add(dtp1)

            'もう一つ作成する
            Dim dtp2 As New DateTimePanel
            '時間を表示する
            dtp2.Format = "t"
            'StatusBar1に追加する
            stbInfo.Panels.Add(dtp2)
            '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

            '設定ファイルから基本情報取得項目を追加

            '最大化ボタン
            Me.MaximizeBox = True
            '最小化ボタン
            Me.MinimizeBox = True
            'ボタン表示
            Me.ControlBox = True
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            '通常(???)サイズで表示
            Me.WindowState = FormWindowState.Normal


            'DBオープン
            'If OraDB.DB_Open = False Then
            '    OraDB.Open()
            'End If


        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try

    End Sub

#Region "時間表示クラス"
    Public Class DateTimePanel
        Inherits StatusBarPanel

        Private _timer As Timer
        ''' <summary>
        ''' タイマー
        ''' </summary>
        Public Property Timer() As Timer
            Get
                Return _timer
            End Get
            Set(ByVal Value As Timer)
                _timer = Value
            End Set
        End Property

        Private _format As String
        ''' <summary>
        ''' 日時のフォーマット
        ''' </summary>

        Public Property Format() As String
            Get
                Return _format
            End Get
            Set(ByVal Value As String)
                _format = Value
            End Set
        End Property

        Public Sub New()
            '幅を内容に合わせる
            Me.AutoSize = StatusBarPanelAutoSize.Contents
            '初期化
            _format = "t"
            _timer = New Timer
            _timer.Interval = 100
            'Tickイベントハンドラの追加
            AddHandler _timer.Tick, AddressOf _timer_Tick
            _timer.Enabled = True
        End Sub

        Private Sub _timer_Tick(ByVal sender As Object, _
                ByVal e As EventArgs)
            'Textを変更する
            Dim txt As String = DateTime.Now.ToString(_format)
            If Me.Text <> txt Then
                Me.Text = txt
            End If
        End Sub
    End Class
#End Region


End Class
