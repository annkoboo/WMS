
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Reflection.MethodInfo


Public Class C01Standard

    Inherits System.Windows.Forms.Form

#Region "ﾌﾟﾛﾊﾟﾃｨ"

    '画面タイトル
    Public Property pTitle()
        Set(ByVal Value)
            sTitleTxt = Value
            lblTitle.Text = "＊＊　" & CType(Value, String) & "　＊＊"
        End Set
        Get
            Return sTitleTxt
        End Get
    End Property

    'ステータスメッセージ
    Public Property pStatusMsg() As String
        Set(ByVal Value As String)
            sbpInfo.Text = Value
        End Set
        Get
            Return sbpInfo.Text.ToString
        End Get
    End Property

    Protected Overrides ReadOnly Property CreateParams() As _
        System.Windows.Forms.CreateParams
        Get
            Const CS_NOCLOSE As Integer = &H200
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE

            Return cp
        End Get
    End Property

    '移動画面No
    Public Property pMoveNo As Integer
        Set(ByVal Value As Integer)
            iMoveNo = Value
        End Set

        Get
            Return iMoveNo
        End Get

    End Property

    '移動画面ID
    Public Property pMoveID As Short
        Set(ByVal Value As Short)
            shMoveID = Value
        End Set

        Get
            Return shMoveID
        End Get

    End Property


#End Region

#Region " 変数宣言部 "

    Public mSB As New System.Text.StringBuilder
    Public mSQL As String

    Public btnEnb(12) As Boolean

    Public Declare Auto Function GetPrivateProfileString Lib "kernel32.dll" _
    Alias "GetPrivateProfileString" ( _
    <MarshalAs(UnmanagedType.LPTStr)> ByVal lpApplicationName As String, _
    <MarshalAs(UnmanagedType.LPTStr)> ByVal lpKeyName As String, _
    <MarshalAs(UnmanagedType.LPTStr)> ByVal lpDefault As String, _
    <MarshalAs(UnmanagedType.LPTStr)> ByVal lpReturnedString As StringBuilder, _
    ByVal nSize As UInt32, _
    <MarshalAs(UnmanagedType.LPTStr)> ByVal lpFileName As String) As UInt32

    Public Const BUFF_LEN As Integer = 256 '256文字
    Public Const IniFileName As String = ".\SYSTEM.INI"

    '初期設定ファイル
    Private Const cINI_System As String = "SYSTEM"
    '画面調整フラグ
    Private Const cinikey_Disp_Flg As String = "DISP_FLG"
    '画面調整
    Private ini_Disp As String

    Private iMoveNo As Integer = 0
    Private shMoveID As Short = 0

    Private sTitleTxt As String = ""

#End Region

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
    Friend WithEvents lblF08 As System.Windows.Forms.Label
    Friend WithEvents btnF08 As System.Windows.Forms.Button
    Friend WithEvents lblF07 As System.Windows.Forms.Label
    Friend WithEvents btnF07 As System.Windows.Forms.Button
    Friend WithEvents lblF06 As System.Windows.Forms.Label
    Friend WithEvents btnF06 As System.Windows.Forms.Button
    Friend WithEvents lblF05 As System.Windows.Forms.Label
    Friend WithEvents btnF05 As System.Windows.Forms.Button
    Friend WithEvents lblF04 As System.Windows.Forms.Label
    Friend WithEvents btnF04 As System.Windows.Forms.Button
    Friend WithEvents lblF03 As System.Windows.Forms.Label
    Friend WithEvents btnF03 As System.Windows.Forms.Button
    Friend WithEvents lblF02 As System.Windows.Forms.Label
    Friend WithEvents btnF02 As System.Windows.Forms.Button
    Friend WithEvents lblF01 As System.Windows.Forms.Label
    Friend WithEvents btnF01 As System.Windows.Forms.Button
    Friend WithEvents stbInfo As System.Windows.Forms.StatusBar
    Friend WithEvents sbpInfo As System.Windows.Forms.StatusBarPanel
    Friend WithEvents sbpProgress As System.Windows.Forms.StatusBarPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
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
        Me.lblF08 = New System.Windows.Forms.Label()
        Me.btnF08 = New System.Windows.Forms.Button()
        Me.lblF07 = New System.Windows.Forms.Label()
        Me.btnF07 = New System.Windows.Forms.Button()
        Me.lblF06 = New System.Windows.Forms.Label()
        Me.btnF06 = New System.Windows.Forms.Button()
        Me.lblF05 = New System.Windows.Forms.Label()
        Me.btnF05 = New System.Windows.Forms.Button()
        Me.lblF04 = New System.Windows.Forms.Label()
        Me.btnF04 = New System.Windows.Forms.Button()
        Me.lblF03 = New System.Windows.Forms.Label()
        Me.btnF03 = New System.Windows.Forms.Button()
        Me.lblF02 = New System.Windows.Forms.Label()
        Me.btnF02 = New System.Windows.Forms.Button()
        Me.lblF01 = New System.Windows.Forms.Label()
        Me.btnF01 = New System.Windows.Forms.Button()
        Me.stbInfo = New System.Windows.Forms.StatusBar()
        Me.sbpInfo = New System.Windows.Forms.StatusBarPanel()
        Me.sbpProgress = New System.Windows.Forms.StatusBarPanel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout
        CType(Me.sbpInfo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.sbpProgress,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
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
        Me.Panel1.Controls.Add(Me.lblF08)
        Me.Panel1.Controls.Add(Me.btnF08)
        Me.Panel1.Controls.Add(Me.lblF07)
        Me.Panel1.Controls.Add(Me.btnF07)
        Me.Panel1.Controls.Add(Me.lblF06)
        Me.Panel1.Controls.Add(Me.btnF06)
        Me.Panel1.Controls.Add(Me.lblF05)
        Me.Panel1.Controls.Add(Me.btnF05)
        Me.Panel1.Controls.Add(Me.lblF04)
        Me.Panel1.Controls.Add(Me.btnF04)
        Me.Panel1.Controls.Add(Me.lblF03)
        Me.Panel1.Controls.Add(Me.btnF03)
        Me.Panel1.Controls.Add(Me.lblF02)
        Me.Panel1.Controls.Add(Me.btnF02)
        Me.Panel1.Controls.Add(Me.lblF01)
        Me.Panel1.Controls.Add(Me.btnF01)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(6, 624)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 82)
        Me.Panel1.TabIndex = 101
        '
        'lblF12
        '
        Me.lblF12.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF12.Location = New System.Drawing.Point(904, 56)
        Me.lblF12.Name = "lblF12"
        Me.lblF12.Size = New System.Drawing.Size(80, 24)
        Me.lblF12.TabIndex = 23
        Me.lblF12.Text = "F12"
        Me.lblF12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF12
        '
        Me.btnF12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF12.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF12.Location = New System.Drawing.Point(904, 8)
        Me.btnF12.Name = "btnF12"
        Me.btnF12.Size = New System.Drawing.Size(80, 48)
        Me.btnF12.TabIndex = 22
        Me.btnF12.Text = "Button12"
        '
        'lblF11
        '
        Me.lblF11.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF11.Location = New System.Drawing.Point(824, 56)
        Me.lblF11.Name = "lblF11"
        Me.lblF11.Size = New System.Drawing.Size(80, 24)
        Me.lblF11.TabIndex = 21
        Me.lblF11.Text = "F11"
        Me.lblF11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF11
        '
        Me.btnF11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF11.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF11.Location = New System.Drawing.Point(824, 8)
        Me.btnF11.Name = "btnF11"
        Me.btnF11.Size = New System.Drawing.Size(80, 48)
        Me.btnF11.TabIndex = 20
        Me.btnF11.Text = "Button11"
        '
        'lblF10
        '
        Me.lblF10.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF10.Location = New System.Drawing.Point(744, 56)
        Me.lblF10.Name = "lblF10"
        Me.lblF10.Size = New System.Drawing.Size(80, 24)
        Me.lblF10.TabIndex = 19
        Me.lblF10.Text = "F10"
        Me.lblF10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF10
        '
        Me.btnF10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF10.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF10.Location = New System.Drawing.Point(744, 8)
        Me.btnF10.Name = "btnF10"
        Me.btnF10.Size = New System.Drawing.Size(80, 48)
        Me.btnF10.TabIndex = 18
        Me.btnF10.Text = "Button10"
        '
        'lblF09
        '
        Me.lblF09.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF09.Location = New System.Drawing.Point(664, 56)
        Me.lblF09.Name = "lblF09"
        Me.lblF09.Size = New System.Drawing.Size(80, 24)
        Me.lblF09.TabIndex = 17
        Me.lblF09.Text = "F9"
        Me.lblF09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF09
        '
        Me.btnF09.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF09.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF09.Location = New System.Drawing.Point(664, 8)
        Me.btnF09.Name = "btnF09"
        Me.btnF09.Size = New System.Drawing.Size(80, 48)
        Me.btnF09.TabIndex = 16
        Me.btnF09.Text = "Button9"
        '
        'lblF08
        '
        Me.lblF08.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF08.Location = New System.Drawing.Point(576, 56)
        Me.lblF08.Name = "lblF08"
        Me.lblF08.Size = New System.Drawing.Size(80, 24)
        Me.lblF08.TabIndex = 15
        Me.lblF08.Text = "F8"
        Me.lblF08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF08
        '
        Me.btnF08.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF08.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF08.Location = New System.Drawing.Point(576, 8)
        Me.btnF08.Name = "btnF08"
        Me.btnF08.Size = New System.Drawing.Size(80, 48)
        Me.btnF08.TabIndex = 14
        Me.btnF08.Text = "Button8"
        '
        'lblF07
        '
        Me.lblF07.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF07.Location = New System.Drawing.Point(496, 56)
        Me.lblF07.Name = "lblF07"
        Me.lblF07.Size = New System.Drawing.Size(80, 24)
        Me.lblF07.TabIndex = 13
        Me.lblF07.Text = "F7"
        Me.lblF07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF07
        '
        Me.btnF07.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF07.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF07.Location = New System.Drawing.Point(496, 8)
        Me.btnF07.Name = "btnF07"
        Me.btnF07.Size = New System.Drawing.Size(80, 48)
        Me.btnF07.TabIndex = 12
        Me.btnF07.Text = "Button7"
        '
        'lblF06
        '
        Me.lblF06.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF06.Location = New System.Drawing.Point(416, 56)
        Me.lblF06.Name = "lblF06"
        Me.lblF06.Size = New System.Drawing.Size(80, 24)
        Me.lblF06.TabIndex = 11
        Me.lblF06.Text = "F6"
        Me.lblF06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF06
        '
        Me.btnF06.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF06.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF06.Location = New System.Drawing.Point(416, 8)
        Me.btnF06.Name = "btnF06"
        Me.btnF06.Size = New System.Drawing.Size(80, 48)
        Me.btnF06.TabIndex = 10
        Me.btnF06.Text = "Button6"
        '
        'lblF05
        '
        Me.lblF05.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF05.Location = New System.Drawing.Point(336, 56)
        Me.lblF05.Name = "lblF05"
        Me.lblF05.Size = New System.Drawing.Size(80, 24)
        Me.lblF05.TabIndex = 9
        Me.lblF05.Text = "F5"
        Me.lblF05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF05
        '
        Me.btnF05.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF05.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF05.Location = New System.Drawing.Point(336, 8)
        Me.btnF05.Name = "btnF05"
        Me.btnF05.Size = New System.Drawing.Size(80, 48)
        Me.btnF05.TabIndex = 8
        Me.btnF05.Text = "Button5"
        '
        'lblF04
        '
        Me.lblF04.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF04.Location = New System.Drawing.Point(248, 56)
        Me.lblF04.Name = "lblF04"
        Me.lblF04.Size = New System.Drawing.Size(80, 24)
        Me.lblF04.TabIndex = 7
        Me.lblF04.Text = "F4"
        Me.lblF04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF04
        '
        Me.btnF04.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF04.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF04.Location = New System.Drawing.Point(248, 8)
        Me.btnF04.Name = "btnF04"
        Me.btnF04.Size = New System.Drawing.Size(80, 48)
        Me.btnF04.TabIndex = 6
        Me.btnF04.Text = "Button4"
        '
        'lblF03
        '
        Me.lblF03.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF03.Location = New System.Drawing.Point(168, 56)
        Me.lblF03.Name = "lblF03"
        Me.lblF03.Size = New System.Drawing.Size(80, 24)
        Me.lblF03.TabIndex = 5
        Me.lblF03.Text = "F3"
        Me.lblF03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF03
        '
        Me.btnF03.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF03.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF03.Location = New System.Drawing.Point(168, 8)
        Me.btnF03.Name = "btnF03"
        Me.btnF03.Size = New System.Drawing.Size(80, 48)
        Me.btnF03.TabIndex = 4
        Me.btnF03.Text = "Button3"
        '
        'lblF02
        '
        Me.lblF02.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF02.Location = New System.Drawing.Point(88, 56)
        Me.lblF02.Name = "lblF02"
        Me.lblF02.Size = New System.Drawing.Size(80, 24)
        Me.lblF02.TabIndex = 3
        Me.lblF02.Text = "F2"
        Me.lblF02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF02
        '
        Me.btnF02.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF02.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF02.Location = New System.Drawing.Point(88, 8)
        Me.btnF02.Name = "btnF02"
        Me.btnF02.Size = New System.Drawing.Size(80, 48)
        Me.btnF02.TabIndex = 2
        Me.btnF02.Text = "Button2"
        '
        'lblF01
        '
        Me.lblF01.Font = New System.Drawing.Font("MS UI Gothic", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblF01.Location = New System.Drawing.Point(8, 56)
        Me.lblF01.Name = "lblF01"
        Me.lblF01.Size = New System.Drawing.Size(80, 24)
        Me.lblF01.TabIndex = 1
        Me.lblF01.Text = "F1"
        Me.lblF01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnF01
        '
        Me.btnF01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF01.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnF01.Location = New System.Drawing.Point(8, 8)
        Me.btnF01.Name = "btnF01"
        Me.btnF01.Size = New System.Drawing.Size(80, 48)
        Me.btnF01.TabIndex = 0
        Me.btnF01.Text = "Button1"
        '
        'stbInfo
        '
        Me.stbInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.stbInfo.Dock = System.Windows.Forms.DockStyle.None
        Me.stbInfo.Font = New System.Drawing.Font("ＭＳ ゴシック", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.stbInfo.Location = New System.Drawing.Point(0, 705)
        Me.stbInfo.Name = "stbInfo"
        Me.stbInfo.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.sbpInfo, Me.sbpProgress})
        Me.stbInfo.ShowPanels = true
        Me.stbInfo.Size = New System.Drawing.Size(1016, 28)
        Me.stbInfo.TabIndex = 2
        '
        'sbpInfo
        '
        Me.sbpInfo.Name = "sbpInfo"
        Me.sbpInfo.Width = 620
        '
        'sbpProgress
        '
        Me.sbpProgress.Name = "sbpProgress"
        Me.sbpProgress.Width = 45
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(995, 32)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "タイトルを表示"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C01Standard
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.ControlBox = false
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.stbInfo)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "C01Standard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "在庫管理システム"
        Me.Panel1.ResumeLayout(false)
        CType(Me.sbpInfo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.sbpProgress,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

#End Region

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

#Region "フォームイベント"

    Private Sub C01標準フォーム_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            ini_Disp = IniCls.ReadString(cINI_System, cinikey_Disp_Flg, "1")
            If ini_Disp = "1" Then
                '最大化ボタン
                Me.MaximizeBox = True
                '最小化ボタン
                Me.MinimizeBox = True
                'ボタン表示
                Me.ControlBox = True
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
                '通常(???)サイズで表示
                Me.WindowState = FormWindowState.Normal
            Else
                'ウィンドウを最大化
                Me.WindowState = FormWindowState.Maximized
            End If

            'DBオープン
            'If OraDB.DB_Open = False Then
            '    OraDB.Open()
            'End If

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try



    End Sub
    'フォーム閉じる
    Private Sub C01標準フォーム_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub


    'ファンクションキー
    Private Sub C01標準フォーム_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

                Case Keys.F5
                    If btnF05.Enabled Then
                        e.Handled = True
                        btnF05.Focus()
                        btnF05.PerformClick()
                    End If

                Case Keys.F6
                    If btnF06.Enabled Then
                        e.Handled = True
                        btnF06.Focus()
                        btnF06.PerformClick()
                    End If

                Case Keys.F7
                    If btnF07.Enabled Then
                        e.Handled = True
                        btnF07.Focus()
                        btnF07.PerformClick()
                    End If

                Case Keys.F8
                    If btnF08.Enabled Then
                        e.Handled = True
                        btnF08.Focus()
                        btnF08.PerformClick()
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
#End Region

#Region "関数"
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
    Public Sub BtnFxxSetEnable(Optional ByVal bF01 As Boolean = False, Optional ByVal bF02 As Boolean = False, Optional ByVal bF03 As Boolean = False, Optional ByVal bF04 As Boolean = False, Optional ByVal bF05 As Boolean = False, Optional ByVal bF06 As Boolean = False, Optional ByVal bF07 As Boolean = False, Optional ByVal bF08 As Boolean = False, Optional ByVal bF09 As Boolean = False, Optional ByVal bF10 As Boolean = False, Optional ByVal bF11 As Boolean = False, Optional ByVal bF12 As Boolean = False)
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

            If btnF05.Text.Length <= 0 Then
                btnF05.Enabled = False
            Else
                btnF05.Enabled = bF05
            End If

            If btnF06.Text.Length <= 0 Then
                btnF06.Enabled = False
            Else
                btnF06.Enabled = bF06
            End If

            If btnF07.Text.Length <= 0 Then
                btnF07.Enabled = False
            Else
                btnF07.Enabled = bF07
            End If

            If btnF08.Text.Length <= 0 Then
                btnF08.Enabled = False
            Else
                btnF08.Enabled = bF08
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
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub


    '実行
    Public Function Server_Check() As Boolean

        Dim sServerName As String
        Dim strCPU As String
        Dim sb As StringBuilder = New StringBuilder(BUFF_LEN)

        Try

            ''Iniファイルよりサーバー名取得
            GetPrivateProfileString("SERVER_NAME", "NAME", "Server", sb, Convert.ToUInt32(sb.Capacity), IniFileName)
            sServerName = sb.ToString

            ''自PC名取得
            strCPU = SystemInformation.ComputerName

            If sServerName <> strCPU Then
                Return False
            End If

            Return True

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
            Return False
        End Try

    End Function
#End Region


   
End Class
