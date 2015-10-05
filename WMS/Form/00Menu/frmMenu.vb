'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
'_/変更履歴
'_/
'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/



'共通関数
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Reflection.MethodInfo
Imports System.Configuration
Imports WMS.clsCommon.Library
Imports WMS.CommonModule
Imports Microsoft.VisualBasic

Public Class frmMenu
    Inherits C01Standard

    ''Private Declare Auto Function GetPrivateProfileString Lib "kernel32.dll" _
    ''Alias "GetPrivateProfileString" ( _
    ''<MarshalAs(UnmanagedType.LPTStr)> ByVal lpApplicationName As String, _
    ''<MarshalAs(UnmanagedType.LPTStr)> ByVal lpKeyName As String, _
    ''<MarshalAs(UnmanagedType.LPTStr)> ByVal lpDefault As String, _
    ''<MarshalAs(UnmanagedType.LPTStr)> ByVal lpReturnedString As StringBuilder, _
    ''ByVal nSize As UInt32, _
    ''<MarshalAs(UnmanagedType.LPTStr)> ByVal lpFileName As String) As UInt32

    ''Private Const BUFF_LEN As Integer = 256 '256文字
    ''Private Const IniFileName As String = "D:\WACS\FUJI_FOOD.INI"

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
    Friend WithEvents btnS02 As System.Windows.Forms.Button
    Friend WithEvents btnS03 As System.Windows.Forms.Button
    Friend WithEvents btnS04 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnS05 As System.Windows.Forms.Button
    Friend WithEvents btnS06 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents optNyukaMenu As System.Windows.Forms.RadioButton
    Friend WithEvents optSyukkaMenu As System.Windows.Forms.RadioButton
    Friend WithEvents optMenteMenu As System.Windows.Forms.RadioButton
    Friend WithEvents btnS01 As System.Windows.Forms.Button
    Friend WithEvents btnS09 As System.Windows.Forms.Button
    Friend WithEvents btnS08 As System.Windows.Forms.Button
    Friend WithEvents btnS07 As System.Windows.Forms.Button
    Friend WithEvents optIdouMenu As System.Windows.Forms.RadioButton
    Friend WithEvents optToiMenu As System.Windows.Forms.RadioButton
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnS13 As System.Windows.Forms.Button
    Friend WithEvents btnS12 As System.Windows.Forms.Button
    Friend WithEvents btnS11 As System.Windows.Forms.Button
    Friend WithEvents btnS10 As System.Windows.Forms.Button
    Friend WithEvents btnS17 As System.Windows.Forms.Button
    Friend WithEvents btnS16 As System.Windows.Forms.Button
    Friend WithEvents btnS14 As System.Windows.Forms.Button
    Friend WithEvents btnS15 As System.Windows.Forms.Button
    Friend WithEvents optHojyuMenu As System.Windows.Forms.RadioButton
    Friend WithEvents btnS20 As System.Windows.Forms.Button
    Friend WithEvents btnS19 As System.Windows.Forms.Button
    Friend WithEvents btnS18 As System.Windows.Forms.Button
    Friend WithEvents optKenpinMenu As System.Windows.Forms.RadioButton
    Friend WithEvents optTanaOrosiMenu As System.Windows.Forms.RadioButton
    Friend WithEvents optDpmMenu As System.Windows.Forms.RadioButton
    Friend WithEvents optSokoMenu As System.Windows.Forms.RadioButton
    Friend WithEvents optSysMenu As System.Windows.Forms.RadioButton


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnS06 = New System.Windows.Forms.Button()
        Me.btnS05 = New System.Windows.Forms.Button()
        Me.btnS04 = New System.Windows.Forms.Button()
        Me.btnS03 = New System.Windows.Forms.Button()
        Me.btnS02 = New System.Windows.Forms.Button()
        Me.btnS01 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.optTanaOrosiMenu = New System.Windows.Forms.RadioButton()
        Me.optDpmMenu = New System.Windows.Forms.RadioButton()
        Me.optSokoMenu = New System.Windows.Forms.RadioButton()
        Me.optSysMenu = New System.Windows.Forms.RadioButton()
        Me.optKenpinMenu = New System.Windows.Forms.RadioButton()
        Me.btnS20 = New System.Windows.Forms.Button()
        Me.btnS19 = New System.Windows.Forms.Button()
        Me.btnS18 = New System.Windows.Forms.Button()
        Me.optHojyuMenu = New System.Windows.Forms.RadioButton()
        Me.btnS17 = New System.Windows.Forms.Button()
        Me.btnS16 = New System.Windows.Forms.Button()
        Me.btnS14 = New System.Windows.Forms.Button()
        Me.btnS15 = New System.Windows.Forms.Button()
        Me.btnS13 = New System.Windows.Forms.Button()
        Me.btnS12 = New System.Windows.Forms.Button()
        Me.btnS11 = New System.Windows.Forms.Button()
        Me.btnS10 = New System.Windows.Forms.Button()
        Me.btnS09 = New System.Windows.Forms.Button()
        Me.optToiMenu = New System.Windows.Forms.RadioButton()
        Me.btnS08 = New System.Windows.Forms.Button()
        Me.btnS07 = New System.Windows.Forms.Button()
        Me.optMenteMenu = New System.Windows.Forms.RadioButton()
        Me.optIdouMenu = New System.Windows.Forms.RadioButton()
        Me.optSyukkaMenu = New System.Windows.Forms.RadioButton()
        Me.optNyukaMenu = New System.Windows.Forms.RadioButton()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'btnS06
        '
        Me.btnS06.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS06.Location = New System.Drawing.Point(270, 113)
        Me.btnS06.Name = "btnS06"
        Me.btnS06.Size = New System.Drawing.Size(230, 56)
        Me.btnS06.TabIndex = 13
        Me.btnS06.Text = "05.出庫開始"
        Me.btnS06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS05
        '
        Me.btnS05.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS05.Location = New System.Drawing.Point(20, 433)
        Me.btnS05.Name = "btnS05"
        Me.btnS05.Size = New System.Drawing.Size(230, 56)
        Me.btnS05.TabIndex = 11
        Me.btnS05.Text = "05.出庫開始"
        Me.btnS05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS04
        '
        Me.btnS04.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS04.Location = New System.Drawing.Point(20, 353)
        Me.btnS04.Name = "btnS04"
        Me.btnS04.Size = New System.Drawing.Size(230, 56)
        Me.btnS04.TabIndex = 10
        Me.btnS04.Text = "05.出庫開始"
        Me.btnS04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS03
        '
        Me.btnS03.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS03.Location = New System.Drawing.Point(20, 273)
        Me.btnS03.Name = "btnS03"
        Me.btnS03.Size = New System.Drawing.Size(230, 56)
        Me.btnS03.TabIndex = 9
        Me.btnS03.Text = "05.出庫開始"
        Me.btnS03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS02
        '
        Me.btnS02.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS02.Location = New System.Drawing.Point(20, 193)
        Me.btnS02.Name = "btnS02"
        Me.btnS02.Size = New System.Drawing.Size(230, 56)
        Me.btnS02.TabIndex = 8
        Me.btnS02.Text = "05.出庫開始"
        Me.btnS02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS01
        '
        Me.btnS01.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS01.Location = New System.Drawing.Point(20, 113)
        Me.btnS01.Name = "btnS01"
        Me.btnS01.Size = New System.Drawing.Size(230, 56)
        Me.btnS01.TabIndex = 7
        Me.btnS01.Text = "04.出荷予定確認"
        Me.btnS01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(280, 544)
        Me.ProgressBar1.Maximum = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(440, 23)
        Me.ProgressBar1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.optTanaOrosiMenu)
        Me.Panel2.Controls.Add(Me.optDpmMenu)
        Me.Panel2.Controls.Add(Me.optSokoMenu)
        Me.Panel2.Controls.Add(Me.optSysMenu)
        Me.Panel2.Controls.Add(Me.optKenpinMenu)
        Me.Panel2.Controls.Add(Me.btnS20)
        Me.Panel2.Controls.Add(Me.btnS19)
        Me.Panel2.Controls.Add(Me.btnS18)
        Me.Panel2.Controls.Add(Me.optHojyuMenu)
        Me.Panel2.Controls.Add(Me.btnS17)
        Me.Panel2.Controls.Add(Me.btnS16)
        Me.Panel2.Controls.Add(Me.btnS14)
        Me.Panel2.Controls.Add(Me.btnS15)
        Me.Panel2.Controls.Add(Me.btnS13)
        Me.Panel2.Controls.Add(Me.btnS12)
        Me.Panel2.Controls.Add(Me.btnS11)
        Me.Panel2.Controls.Add(Me.btnS10)
        Me.Panel2.Controls.Add(Me.btnS09)
        Me.Panel2.Controls.Add(Me.optToiMenu)
        Me.Panel2.Controls.Add(Me.btnS08)
        Me.Panel2.Controls.Add(Me.btnS07)
        Me.Panel2.Controls.Add(Me.optMenteMenu)
        Me.Panel2.Controls.Add(Me.optIdouMenu)
        Me.Panel2.Controls.Add(Me.optSyukkaMenu)
        Me.Panel2.Controls.Add(Me.optNyukaMenu)
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.btnS04)
        Me.Panel2.Controls.Add(Me.btnS01)
        Me.Panel2.Controls.Add(Me.btnS02)
        Me.Panel2.Controls.Add(Me.btnS03)
        Me.Panel2.Controls.Add(Me.btnS05)
        Me.Panel2.Controls.Add(Me.btnS06)
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1016, 584)
        Me.Panel2.TabIndex = 18
        '
        'optTanaOrosiMenu
        '
        Me.optTanaOrosiMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.optTanaOrosiMenu.Appearance = System.Windows.Forms.Appearance.Button
        Me.optTanaOrosiMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.optTanaOrosiMenu.Location = New System.Drawing.Point(301, 53)
        Me.optTanaOrosiMenu.Name = "optTanaOrosiMenu"
        Me.optTanaOrosiMenu.Size = New System.Drawing.Size(140, 40)
        Me.optTanaOrosiMenu.TabIndex = 40
        Me.optTanaOrosiMenu.Text = "10：棚卸"
        Me.optTanaOrosiMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optDpmMenu
        '
        Me.optDpmMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.optDpmMenu.Appearance = System.Windows.Forms.Appearance.Button
        Me.optDpmMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.optDpmMenu.Location = New System.Drawing.Point(442, 53)
        Me.optDpmMenu.Name = "optDpmMenu"
        Me.optDpmMenu.Size = New System.Drawing.Size(140, 40)
        Me.optDpmMenu.TabIndex = 36
        Me.optDpmMenu.Text = "11:DPM"
        Me.optDpmMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optSokoMenu
        '
        Me.optSokoMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.optSokoMenu.Appearance = System.Windows.Forms.Appearance.Button
        Me.optSokoMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.optSokoMenu.Location = New System.Drawing.Point(160, 53)
        Me.optSokoMenu.Name = "optSokoMenu"
        Me.optSokoMenu.Size = New System.Drawing.Size(140, 40)
        Me.optSokoMenu.TabIndex = 35
        Me.optSokoMenu.Text = "9:自動倉庫"
        Me.optSokoMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optSysMenu
        '
        Me.optSysMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.optSysMenu.Appearance = System.Windows.Forms.Appearance.Button
        Me.optSysMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.optSysMenu.Location = New System.Drawing.Point(20, 53)
        Me.optSysMenu.Name = "optSysMenu"
        Me.optSysMenu.Size = New System.Drawing.Size(140, 40)
        Me.optSysMenu.TabIndex = 34
        Me.optSysMenu.Text = "8:システム"
        Me.optSysMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optKenpinMenu
        '
        Me.optKenpinMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.optKenpinMenu.Appearance = System.Windows.Forms.Appearance.Button
        Me.optKenpinMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.optKenpinMenu.Location = New System.Drawing.Point(301, 6)
        Me.optKenpinMenu.Name = "optKenpinMenu"
        Me.optKenpinMenu.Size = New System.Drawing.Size(140, 40)
        Me.optKenpinMenu.TabIndex = 33
        Me.optKenpinMenu.Text = "3：検品"
        Me.optKenpinMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnS20
        '
        Me.btnS20.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS20.Location = New System.Drawing.Point(773, 433)
        Me.btnS20.Name = "btnS20"
        Me.btnS20.Size = New System.Drawing.Size(230, 56)
        Me.btnS20.TabIndex = 32
        Me.btnS20.Text = "05.出庫開始"
        Me.btnS20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS19
        '
        Me.btnS19.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS19.Location = New System.Drawing.Point(773, 353)
        Me.btnS19.Name = "btnS19"
        Me.btnS19.Size = New System.Drawing.Size(230, 56)
        Me.btnS19.TabIndex = 30
        Me.btnS19.Text = "05.出庫開始"
        Me.btnS19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS18
        '
        Me.btnS18.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS18.Location = New System.Drawing.Point(773, 273)
        Me.btnS18.Name = "btnS18"
        Me.btnS18.Size = New System.Drawing.Size(230, 56)
        Me.btnS18.TabIndex = 29
        Me.btnS18.Text = "05.出庫開始"
        Me.btnS18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optHojyuMenu
        '
        Me.optHojyuMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.optHojyuMenu.Appearance = System.Windows.Forms.Appearance.Button
        Me.optHojyuMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.optHojyuMenu.Location = New System.Drawing.Point(442, 6)
        Me.optHojyuMenu.Name = "optHojyuMenu"
        Me.optHojyuMenu.Size = New System.Drawing.Size(140, 40)
        Me.optHojyuMenu.TabIndex = 28
        Me.optHojyuMenu.Text = "4:補充"
        Me.optHojyuMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnS17
        '
        Me.btnS17.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS17.Location = New System.Drawing.Point(773, 193)
        Me.btnS17.Name = "btnS17"
        Me.btnS17.Size = New System.Drawing.Size(230, 56)
        Me.btnS17.TabIndex = 27
        Me.btnS17.Text = "05.出庫開始"
        Me.btnS17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS16
        '
        Me.btnS16.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS16.Location = New System.Drawing.Point(773, 113)
        Me.btnS16.Name = "btnS16"
        Me.btnS16.Size = New System.Drawing.Size(230, 56)
        Me.btnS16.TabIndex = 26
        Me.btnS16.Text = "05.出庫開始"
        Me.btnS16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS14
        '
        Me.btnS14.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS14.Location = New System.Drawing.Point(522, 353)
        Me.btnS14.Name = "btnS14"
        Me.btnS14.Size = New System.Drawing.Size(230, 56)
        Me.btnS14.TabIndex = 23
        Me.btnS14.Text = "05.出庫開始"
        Me.btnS14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS15
        '
        Me.btnS15.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS15.Location = New System.Drawing.Point(522, 433)
        Me.btnS15.Name = "btnS15"
        Me.btnS15.Size = New System.Drawing.Size(230, 56)
        Me.btnS15.TabIndex = 24
        Me.btnS15.Text = "05.出庫開始"
        Me.btnS15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS13
        '
        Me.btnS13.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS13.Location = New System.Drawing.Point(522, 273)
        Me.btnS13.Name = "btnS13"
        Me.btnS13.Size = New System.Drawing.Size(230, 56)
        Me.btnS13.TabIndex = 22
        Me.btnS13.Text = "05.出庫開始"
        Me.btnS13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS12
        '
        Me.btnS12.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS12.Location = New System.Drawing.Point(522, 193)
        Me.btnS12.Name = "btnS12"
        Me.btnS12.Size = New System.Drawing.Size(230, 56)
        Me.btnS12.TabIndex = 21
        Me.btnS12.Text = "05.出庫開始"
        Me.btnS12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS11
        '
        Me.btnS11.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS11.Location = New System.Drawing.Point(522, 113)
        Me.btnS11.Name = "btnS11"
        Me.btnS11.Size = New System.Drawing.Size(230, 56)
        Me.btnS11.TabIndex = 20
        Me.btnS11.Text = "05.出庫開始"
        Me.btnS11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS10
        '
        Me.btnS10.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS10.Location = New System.Drawing.Point(270, 433)
        Me.btnS10.Name = "btnS10"
        Me.btnS10.Size = New System.Drawing.Size(230, 56)
        Me.btnS10.TabIndex = 18
        Me.btnS10.Text = "05.出庫開始"
        Me.btnS10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS09
        '
        Me.btnS09.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS09.Location = New System.Drawing.Point(270, 353)
        Me.btnS09.Name = "btnS09"
        Me.btnS09.Size = New System.Drawing.Size(230, 56)
        Me.btnS09.TabIndex = 16
        Me.btnS09.Text = "05.出庫開始"
        Me.btnS09.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optToiMenu
        '
        Me.optToiMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.optToiMenu.Appearance = System.Windows.Forms.Appearance.Button
        Me.optToiMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.optToiMenu.Location = New System.Drawing.Point(724, 6)
        Me.optToiMenu.Name = "optToiMenu"
        Me.optToiMenu.Size = New System.Drawing.Size(140, 40)
        Me.optToiMenu.TabIndex = 5
        Me.optToiMenu.Text = "6:問合せ"
        Me.optToiMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnS08
        '
        Me.btnS08.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS08.Location = New System.Drawing.Point(270, 273)
        Me.btnS08.Name = "btnS08"
        Me.btnS08.Size = New System.Drawing.Size(230, 56)
        Me.btnS08.TabIndex = 15
        Me.btnS08.Text = "05.出庫開始"
        Me.btnS08.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnS07
        '
        Me.btnS07.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnS07.Location = New System.Drawing.Point(270, 193)
        Me.btnS07.Name = "btnS07"
        Me.btnS07.Size = New System.Drawing.Size(230, 56)
        Me.btnS07.TabIndex = 14
        Me.btnS07.Text = "05.出庫開始"
        Me.btnS07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optMenteMenu
        '
        Me.optMenteMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.optMenteMenu.Appearance = System.Windows.Forms.Appearance.Button
        Me.optMenteMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.optMenteMenu.Location = New System.Drawing.Point(865, 6)
        Me.optMenteMenu.Name = "optMenteMenu"
        Me.optMenteMenu.Size = New System.Drawing.Size(140, 40)
        Me.optMenteMenu.TabIndex = 6
        Me.optMenteMenu.Text = "7:ﾒﾝﾃﾅﾝｽ"
        Me.optMenteMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optIdouMenu
        '
        Me.optIdouMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.optIdouMenu.Appearance = System.Windows.Forms.Appearance.Button
        Me.optIdouMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.optIdouMenu.Location = New System.Drawing.Point(583, 6)
        Me.optIdouMenu.Name = "optIdouMenu"
        Me.optIdouMenu.Size = New System.Drawing.Size(140, 40)
        Me.optIdouMenu.TabIndex = 4
        Me.optIdouMenu.Text = "5:移動"
        Me.optIdouMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optSyukkaMenu
        '
        Me.optSyukkaMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.optSyukkaMenu.Appearance = System.Windows.Forms.Appearance.Button
        Me.optSyukkaMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.optSyukkaMenu.Location = New System.Drawing.Point(160, 6)
        Me.optSyukkaMenu.Name = "optSyukkaMenu"
        Me.optSyukkaMenu.Size = New System.Drawing.Size(140, 40)
        Me.optSyukkaMenu.TabIndex = 1
        Me.optSyukkaMenu.Text = "2:出荷"
        Me.optSyukkaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optNyukaMenu
        '
        Me.optNyukaMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.optNyukaMenu.Appearance = System.Windows.Forms.Appearance.Button
        Me.optNyukaMenu.Font = New System.Drawing.Font("ＭＳ ゴシック", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.optNyukaMenu.Location = New System.Drawing.Point(19, 6)
        Me.optNyukaMenu.Name = "optNyukaMenu"
        Me.optNyukaMenu.Size = New System.Drawing.Size(140, 40)
        Me.optNyukaMenu.TabIndex = 0
        Me.optNyukaMenu.Text = "1:入荷入庫"
        Me.optNyukaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = true
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"),System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = false
        '
        'frmMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.ControlBox = true
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = true
        Me.MinimizeBox = true
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "自動倉庫管理システム"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

#End Region

#Region "宣言"
    Public btnForm() As Button

    'オプションボタン配列(入荷,出荷,問合せ,帳票,メンテ,システム)
    Private OptMenu() As RadioButton



#End Region

#Region "バージョン"

    Private Const cVersion As String = "1.0.0"


#End Region

#Region "CONST"
    Private Const cINI_System As String = "SYSTEM"
    Private Const cINI_Key As String = "TAN_NAME"
    Private Const cIniKey_Host As String = "HOST_NAME"
    Private Const cIniKey_HulftPath As String = "HULFT_PATH"
    Private Const cIniKey_BackPath As String = "BACK_PATH"
    Private Const cIniKey_SendPath As String = "SEND_PATH"
    Private Const cIniKey_RecvPath As String = "RECV_PATH"
    '号機
    Private Const cinikey_Gouki As String = "GOUKI"
    'プリントフラグ
    Private Const cinikey_Print_Flg As String = "PRINT_FLG"
    'システム使用フラグ
    Private Const cinikey_System_Flg As String = "SYSTEM_FLG"
    '在庫修正使用フラグ
    Private Const cinikey_Zaimod_Flg As String = "ZAIMOD_FLG"
    '拠点
    Private Const cinikey_BaseCode As String = "BASE_CODE"
    'ラベル出力プリンタ
    Private Const cinikey_LabelPrinter As String = "LABEL_PRINTER" '<A221>ラベル出力プリンタ@@090922[apt]k.msr

    Private Const cinikey_SyukkoGrpNo As String = "SYUKO_GROUP" '<A368>出庫グループ@@120413[apt]k.msr

    Private Const cINI_SysDefault As String = "000"

    Private Const cHolidayCheckFrom As Short = 2 '休日設定チェック開始期間(月)
    Private Const cHolidayCheckTo As Short = 3  '休日設定ﾁｪｯｸ終了期間(月)

#End Region

#Region "イベント-フォーム-"
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sMsg As String = ""

        Try
            '砂時計にする
            Frm.WaitCursorAndDisable(Me)

            'プログレスバーとメッセージを表示
            Me.ProgressBar1.Style = ProgressBarStyle.Marquee
            Me.ProgressBar1.MarqueeAnimationSpeed = 10
            Me.ProgressBar1.Visible = True
            Me.pStatusMsg = "プログラムを起動中。しばらくお待ちください．．．"

            'タスクバーに表示
            Me.ShowInTaskbar = True

            'Call Log_Boot()

            '共通項目初期化
            Call InitCommon()

            'フォームボタン初期化
            Call Init_btnFrom()

            'プログレスバー非表示
            'ProgressBar1.Visible = False

            '初期値で入荷メニュー表示
            Call Show_ButtonName(1)
            OptMenu(1).Checked = True

            'メッセージ表示
            'pStatusMsg = "9999:[HH:mm]XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"

        Catch ex As Exception
            'Call vbErrSub(MyBase.GetType.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, CShort(Err.Number), ex)
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

            '砂時計を解除
            Frm.ArrowAndEnable(Me)

        Finally
        End Try
    End Sub
    Private Sub frmMENU_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            'DBの接続文字列に使用するパラメータをApp.configから取得・設定
            DbAcc.sUser = ConfigurationManager.AppSettings("DB_CONN_USERID").ToString
            DbAcc.sPassword = ConfigurationManager.AppSettings("DB_CONN_PASSWORD").ToString
            DbAcc.sService = ConfigurationManager.AppSettings("DB_CONN_DATASOURCE").ToString

            'DB接続
            If OraDB.DB_Open = False Then
                OraDB.Open()
            End If

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        Finally
            'プログレスバーとメッセージを消す
            Me.ProgressBar1.Visible = False
            Me.pStatusMsg = ""

            '砂時計を解除
            Frm.ArrowAndEnable(Me)

        End Try
    End Sub

    Private Sub Form_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim shFormId As Short = 0

        Try
            If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(Keys.Escape) Then Exit Try

            Select Case e.KeyChar
            Case "1"
                OptMenu(1).Focus()
                OptMenu(1).PerformClick()

            Case "2"
                OptMenu(2).Focus()
                OptMenu(2).PerformClick()

            Case "3"
                OptMenu(3).Focus()
                OptMenu(3).PerformClick()

            Case "4"
                OptMenu(4).Focus()
                OptMenu(4).PerformClick()

            Case "5"
                OptMenu(5).Focus()
                OptMenu(5).PerformClick()

            Case "6"
                OptMenu(6).Focus()
                OptMenu(6).PerformClick()

            Case "7"
                OptMenu(7).Focus()
                OptMenu(7).PerformClick()

            Case "8"
                OptMenu(8).Focus()
                OptMenu(8).PerformClick()

            Case "9"
                OptMenu(9).Focus()
                OptMenu(9).PerformClick()

            Case "10"
                OptMenu(10).Focus()
                OptMenu(10).PerformClick()

            Case "11"
                OptMenu(11).Focus()
                OptMenu(11).PerformClick()

            'Case "12"
            '    OptMenu(12).Focus()
            '    OptMenu(12).PerformClick()

            Case Chr(Keys.Escape)
                Call Show_ButtonName()

            Case Else
                Exit Try

            End Select

        Catch ex As Exception
            Call vbErrSub(MyBase.GetType.Name & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, CShort(Err.Number), ex)

        End Try
    End Sub
#End Region

#Region "イベント-その他-"
    'ファンクションボタンのクリック
    Protected Overridable Sub btnFun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iIndex As Integer = Mid(CType(sender, System.Windows.Forms.Button).Name, Len(CType(sender, System.Windows.Forms.Button).Name) - 1, 2)
        Dim btnFXX() As System.Windows.Forms.Button = {Nothing, btnF01, btnF02, btnF03, btnF04, btnF05, btnF06, btnF07, btnF08, btnF09, btnF10, btnF11, btnF12}
        Dim intCnt As Integer

        Try
            For intCnt = 1 To 12
                btnEnb(intCnt) = btnFXX(intCnt).Enabled
                btnFXX(intCnt).Enabled = False
            Next intCnt

            Select Case iIndex
            Case 1
            Case 2
            Case 3
            Case 4
            Case 5
            Case 6
            Case 7
            Case 8
            Case 9
            Case 10
            Case 11
            Case 12
                #If DEBUG Then
                    Application.Exit()
                #Else
                    If MsgBox("自動倉庫管理システムを終了します。" & vbCrLf & "よろしいですか？", msgQYN + MsgBoxStyle.DefaultButton2, msgTitle) = MsgBoxResult.Yes Then
                        Application.Exit()
                    End If
                #End If

            Case Else
            End Select

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        Finally
            For intCnt = 1 To 12
                btnFXX(intCnt).Enabled = btnEnb(intCnt)
            Next intCnt
        End Try
    End Sub

    '業務ボタンクリック
    Protected Overridable Sub btnForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iIndex As Integer = 0
        Dim btnTarget As Button = Nothing
        Dim shLoop As Short = 0
        Dim shID As Short = 0

        Try
            btnTarget = CType(sender, Button)

            'ボタンNo取得
            For shLoop = 1 To UBound(btnForm)
                If btnForm(shLoop).Name = btnTarget.Name Then
                    iIndex = CInt(shLoop)
                    Exit For
                End If

            Next

            '作業ID取得
            For shLoop = 1 To UBound(OptMenu)
                If OptMenu(shLoop).Checked = True Then
                    shID = shLoop
                    Exit For
                End If
            Next

            '押されたボタンに該当する画面を表示
            If shID >= 1 And iIndex >= 1 Then
                Call Show_Form(iIndex, shID)
            End If

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        End Try
    End Sub

    'メニューボタンのクリック
    Private Sub OptMenu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim OptTarget As RadioButton
        Dim shCheckId As Short = 99

        Try
            OptTarget = CType(sender, RadioButton)

            If OptTarget.Checked = True Then

                Select Case OptTarget.Name
                Case optNyukaMenu.Name
                    '入荷メニュー
                    shCheckId = 1

                Case optSyukkaMenu.Name
                    '出荷メニュー
                    shCheckId = 2

                Case optKenpinMenu.Name
                    '検品メニュー
                    shCheckId = 3

                Case optHojyuMenu.Name
                    '補充メニュー
                    shCheckId = 4

                Case optIdouMenu.Name
                    '移動メニュー
                    shCheckId = 5

                Case optToiMenu.Name
                    '問合せメニュー
                    shCheckId = 6

                Case optMenteMenu.Name
                    'メンテメニュー
                    shCheckId = 7

                Case optSysMenu.Name
                    'ｼｽﾃﾑメニュー
                    shCheckId = 8

                Case optSokoMenu.Name
                    '自動倉庫メニュー
                    shCheckId = 9

                Case optTanaOrosiMenu.Name
                    '棚卸メニュー
                    shCheckId = 10

                'Case optAnalyzeMenu.Name
                '    '分析メニュー
                '    shCheckId = 11

                Case optDpmMenu.Name
                    'DPMメニュー
                    shCheckId = 11

                Case Else
                    Exit Try

                End Select

                'メニューに応じた業務ボタンに切り替える
                Call Show_ButtonName(shCheckId)

            End If

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)

        End Try
    End Sub

    Private Sub Optmenu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim OptTarget As RadioButton

        Try
            OptTarget = CType(sender, RadioButton)
            OptTarget.Checked = True

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub


#End Region

#Region "関数"
    '標準フォームのオブジェクト設定
    Private Sub InitCommon()
        Dim iLoop As Integer
        Dim btnFXX() As System.Windows.Forms.Button = {Nothing, _
                                                    btnF01, _
                                                    btnF02, _
                                                    btnF03, _
                                                    btnF04, _
                                                    btnF05, _
                                                    btnF06, _
                                                    btnF07, _
                                                    btnF08, _
                                                    btnF09, _
                                                    btnF10, _
                                                    btnF11, _
                                                    btnF12}
        Try
            'ファンクションボタン_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
            '表示ﾃｷｽﾄ
            btnFXX(1).Text = ""
            btnFXX(2).Text = ""
            btnFXX(3).Text = ""
            btnFXX(4).Text = ""
            btnFXX(5).Text = ""
            btnFXX(6).Text = ""
            btnFXX(7).Text = ""
            btnFXX(8).Text = ""
            btnFXX(9).Text = ""
            btnFXX(10).Text = ""
            btnFXX(11).Text = ""
            btnFXX(12).Text = "終了"

            '使用許可(初期)
            btnFXX(1).Enabled = False
            btnFXX(2).Enabled = False
            btnFXX(3).Enabled = False
            btnFXX(4).Enabled = False
            btnFXX(5).Enabled = False
            btnFXX(6).Enabled = False
            btnFXX(7).Enabled = False
            btnFXX(8).Enabled = False
            btnFXX(9).Enabled = False
            btnFXX(10).Enabled = False
            btnFXX(11).Enabled = False
            btnFXX(12).Enabled = True

            '表示ﾃｷｽﾄ空白は使用許可＝False
            For iLoop = 1 To UBound(btnFXX) Step 1
                If btnFXX(iLoop).Text.Length <= 0 Then
                    btnFXX(iLoop).Enabled = False
                End If
            Next

            'イベント割付
            For i As Integer = 1 To 12
                AddHandler btnFXX(i).Click, AddressOf btnFun_Click
            Next

            '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/


            'タイトル_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
            lblTitle.Text = "自動倉庫管理システム メインメニュー"
            '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

            Me.Text &= " Ver." & cVersion

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub

    '画面遷移ボタン設定
    Private Sub Init_btnFrom()

        Dim iLoop As Integer = 0

        Try
            '画面遷移ボタン
            ReDim btnForm(20)
            btnForm(1) = Me.btnS01
            btnForm(2) = Me.btnS02
            btnForm(3) = Me.btnS03
            btnForm(4) = Me.btnS04
            btnForm(5) = Me.btnS05
            btnForm(6) = Me.btnS06
            btnForm(7) = Me.btnS07
            btnForm(8) = Me.btnS08
            btnForm(9) = Me.btnS09
            btnForm(10) = Me.btnS10
            btnForm(11) = Me.btnS11
            btnForm(12) = Me.btnS12
            btnForm(13) = Me.btnS13
            btnForm(14) = Me.btnS14
            btnForm(15) = Me.btnS15
            btnForm(16) = Me.btnS16
            btnForm(17) = Me.btnS17
            btnForm(18) = Me.btnS18
            btnForm(19) = Me.btnS19
            btnForm(20) = Me.btnS20
            
            'btnForm(24) = Me.btnS24

            '表示ﾃｷｽﾄ変更
            For iLoop = 1 To UBound(btnForm) Step 1
                btnForm(iLoop).Text = ""
            Next

            ReDim OptMenu(11)
            OptMenu(1) = Me.optNyukaMenu
            OptMenu(2) = Me.optSyukkaMenu
            OptMenu(3) = Me.optKenpinMenu
            OptMenu(4) = Me.optHojyuMenu
            OptMenu(5) = Me.optIdouMenu
            OptMenu(6) = Me.optToiMenu
            OptMenu(7) = Me.optMenteMenu
            OptMenu(8) = Me.optSysMenu
            OptMenu(9) = Me.optSokoMenu
            OptMenu(10) = Me.optTanaOrosiMenu
            'OptMenu(11) = Me.optAnalyzeMenu
            OptMenu(11) = Me.optDpmMenu



            'イベント割付
            'フォームボタン
            For iLoop = 1 To UBound(btnForm)
                AddHandler btnForm(iLoop).Click, AddressOf btnForm_Click
            Next

            'オプションボタン
            For iLoop = 1 To UBound(OptMenu) Step 1
                AddHandler OptMenu(iLoop).CheckedChanged, AddressOf OptMenu_CheckedChanged
                AddHandler OptMenu(iLoop).GotFocus, AddressOf Optmenu_GotFocus
            Next

        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try
    End Sub

    '画面遷移
    Private Sub Show_Form(ByVal iNo As Integer, ByVal shID As Short)
        Dim frmForm As C01Standard = Nothing

FormMove:


        '画面タイトル取得
        If iNo.ToString.Length = 1 Then
            strGetTitle = SearchName(Microsoft.VisualBasic.Right(Format(iNo, "00"), 1), shID)  '(1,1の値を共通関数に投げる)
        ElseIf iNo.ToString.Length = 2 Then
            strGetTitle = SearchName(Microsoft.VisualBasic.Right(Format(iNo, "00"), 2), shID)  '(1,1の値を共通関数に投げる)
        End If

        Try
            'ログオンダイアログ（仮）
            'If shID = 4 Then
            '現時点都度ログインは不便なので画面の少ない補充メニュー時のみ表示
            'Dim frmLogOn As New frmLogon
            'If frmLogOn.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            '    Exit Try
            'End If
            'End If


            Select Case shID
                Case 1 '入庫系
                    Select Case iNo
                        Case 1
                            frmForm = New frmNyukaUkeKeikaku
                        Case 2
                            frmForm = New frmNyukaUkeKeikakuGai
                        Case 3
                            frmForm = New frmNyukoLblRePrt
                        Case 4
                            frmForm = New frmYokiHimozuke
                        Case 5
                            frmForm = New frmNyukoKanryo
                        Case 6
                            frmForm = New frmTumiMasiNyuko
                        Case 7
                            frmForm = New frmKaraYokiNyuko
                        Case Else
                            Exit Try
                    End Select

                Case 2  '出庫系
                    Select Case iNo
                        Case 1
                            frmForm = New frmShukaStart
                        Case 2
                            frmForm = New frmPicSagyo
                        Case 3
                            frmForm = New frmKeikakuGaiShuka_HinCd
                        Case 4
                            frmForm = New frmKeikakuGaiShuka_Toiawase
                        Case 5
                            frmForm = New frmZaiYoyaku
                        Case 6
                            frmForm = New frmShukaStop
                        Case 7
                            frmForm = New frmShukaModosi
                        Case Else
                            Exit Try
                    End Select

                Case 3  '検品
                    Select Case iNo
                        Case 1
                            frmForm = New frmTuhanKenpin01
                        Case 2
                            frmForm = New frmOrosiKenpin01
                        Case Else
                            Exit Try
                    End Select

                Case 4  '補充
                    Select Case iNo
                        Case 1
                            frmForm = New frmTujoHoju
                        Case 2
                            frmForm = New frmHojuKanryo
                        Case Else
                            Exit Try
                    End Select


                Case 5  '移動系

                    Select Case iNo
                        Case 1
                            frmForm = New frmAwIdoShuko
                        Case 2
                            frmForm = New frmIdoKanryo
                        'Case 3
                        '    frmForm = New 倉庫間移動設定
                        'Case 4
                        '    frmForm = New 生産ライン名称マスタ
                        'Case 5
                        '    frmForm = New 積付パターンマスタ
                        'Case 6
                        '    frmForm = New 出荷倉庫マスタ
                        'Case 7
                        '    frmForm = New 設備エラーメッセージマスタ
                        'Case 8
                        '    frmForm = New 作業者マスタ
                        'Case 9
                        '    frmForm = New 作業理由コメントマスタ
                        'Case 10
                        '    frmForm = New 帳票出力部数マスタ
                        'Case 11
                        '    frmForm = New 棚指定禁止棚設定
                        'Case 12
                        '    frmForm = New 実績送信
                        'Case 13
                        '    frmForm = New ロケーションメンテナンス
                        Case Else
                            Exit Try
                    End Select

                Case 6 '問合せ
                    Select Case iNo
                        Case 1
                            frmForm = New frmZaiLst
                        Case 2
                            frmForm = New frmKakunoSts
                        Case 3
                            frmForm = New frmHachuLotSuLst
                        Case 4
                            frmForm = New frmShukaSijiNoLst
                        Case 5
                            frmForm = New frmNyukaSts
                        Case 6
                            frmForm = New frmShukaSts
                        Case 7
                            frmForm = New frmHojuSts
                        Case 8
                            frmForm = New frmIdoSts
                        Case 9
                            frmForm = New frmShukaKigenLst
                        'Case 10
                        '    frmForm = New デッドストック一覧
                        Case 10
                            frmForm = New frmChokiTairyuLst
                        Case 11
                            frmForm = New frmDpsTanaWariLst
                        Case 12
                            frmForm = New frmShukaTuiseki
                        Case 13
                            frmForm = New frmNyuShukaLst
                        Case 14
                            frmForm = New frmOkurijoLst
                        'Case 10
                        '    '    frmForm = New frmM60
                        Case Else
                            Exit Try
                    End Select

                Case 7  'メンテナンス
                    Select Case iNo
                        Case 1
                            frmForm = New frmZaiMnt
                        Case 2
                            frmForm = New frmNinusiKbn
                        Case 3
                            frmForm = New frmMHinKanKbn
                        Case 4
                            frmForm = New frmTrackingMnt
                        Case 5
                            frmForm = New frmNyukaYoteMnt
                        Case 6
                            frmForm = New frmShukaYoteMnt
                        Case 7
                            frmForm = New frmMHin
                        Case 8
                            frmForm = New frmMUser
                        Case 9
                            frmForm = New frmHostIFSet
                        Case 10
                            frmForm = New frmMTanaWari
                        Case 11
                            frmForm = New frmMJiyu
                        Case 12
                            frmForm = New frmMJiyuDef
                        Case 13
                            frmForm = New frmMAccCtl
                        Case 14
                            frmForm = New frmDevSet
                        Case 15
                            frmForm = New frmMArea
                        Case 16
                            frmForm = New frmMShukaSbt
                        Case 17
                            frmForm = New frmMTokuis
                        Case 18
                            frmForm = New frmMUnso
                        Case 19
                            frmForm = New frmMSoko
                        Case 20
                            frmForm = New frmMTani
                        Case Else
                            Exit Try
                    End Select

                Case 8  'システム
                    Select Case iNo
                        Case 1
                            frmForm = New frmSetubiSts
                        Case 2
                            frmForm = New frmBatDD
                        Case 3
                            frmForm = New frmSysSet
                        Case Else
                            Exit Try
                    End Select

                Case 9  '自動倉庫
                    Select Case iNo
                        Case 1
                            frmForm = New frmAwSts
                        Case 2
                            frmForm = New frmNyuShukoMode
                        Case 3
                            frmForm = New frmAwTonyu
                        Case 4
                            frmForm = New frmAwOpe
                        Case Else
                            Exit Try
                    End Select

                Case 10  '棚卸
                    Select Case iNo
                        Case 1
                            frmForm = New frmTanaOrosiOpe
                        Case 2
                            frmForm = New frmTanaOrosiKekkaMnt
                        Case 3
                            frmForm = New frmTuhanLotMnt

                        Case Else
                            Exit Try
                    End Select

                'Case 11  '分析
                '    Select Case iNo
                '        Case 1
                '            frmForm = New 商品分析
                '        Case 2
                '            frmForm = New 作業者詳細分析
                '        Case 3
                '            frmForm = New 作業分析
                '        Case Else
                '            Exit Try
                '    End Select

                Case 11  'DPM
                    Select Case iNo
                        Case 1
                            frmForm = New frmDPMUserLst
                        Case 2
                            frmForm = New frmHyojikiTest
                        'Case 2
                        '    frmForm = New 作業問合せ_メンテナンス
                        'Case 3
                        '    frmForm = New 出荷指示No強制完了
                        'Case 4
                        '    frmForm = New 表示器テスト
                        'Case 5
                        '    frmForm = New 通信ログ問合せ
                        Case Else
                            Exit Try
                    End Select

                Case Else
                    Exit Try
            End Select

            If frmForm Is Nothing = False Then
                '[ログオン]画面の表示
                Dim frmLogOn As New frmLogon
                If frmLogOn.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                    Exit Try
                End If

                '表示しようとしている画面のアクセス権を取得する（アクセス権限1～9の配列で返ってくる）
                Dim ArrLvl() As String
                ArrLvl = Frm.GetOpeAuth(frmForm.Name)

                'アクセス権をチェックする
                '配列で返ってきていない場合は、その画面に対するアクセス権の設定がないものとして、誰でも操作OKとする
                Dim Auth As Boolean = False
                If IsArray(ArrLvl) Then
                    'ログオンしたユーザーに、表示しようとしている画面のアクセス権限があるかチェック
                    If ArrLvl(Logon_UserAccLvl - 1) = ClassCode.LVLKBN_OK Then
                        Auth = True
                    Else
                        Auth = False
                    End If
                Else
                    Auth = True
                End If

                'アクセス権がOKなら表示する
                If Auth = True Then
                    frmForm.pTitle = strGetTitle
                    frmForm.MinimumSize = New System.Drawing.Size(1024, 768)
                    frmForm.MaximumSize = New System.Drawing.Size(1024, 768)
                    frmForm.StartPosition = FormStartPosition.CenterScreen
                    frmForm.ShowDialog()
                    Me.Activate()
                Else
                    Dim Msg As String = ""
                    Msg = "この画面の操作権限がありません。"
                    MessageBox.Show(Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                Exit Try
            End If

            If frmForm.pMoveID <> 0 Then
                shID = frmForm.pMoveID
                iNo = frmForm.pMoveNo
                frmForm.Dispose()
                GoTo FormMove
            End If


        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        Finally
            If frmForm Is Nothing = False Then
                frmForm.Dispose()
            End If
            strGetTitle = ""
        End Try
    End Sub


    'フォーム名切り替え
    Private Sub Show_ButtonName(Optional ByVal iGrpId As Integer = 9)

        Dim shLoop As Short = 0

        Try
            Select Case iGrpId



                Case 1
                    For shLoop = 1 To UBound(btnForm) Step 1
                        If strNyukaForm(shLoop).Trim <> "" Then
                            btnForm(shLoop).Text = IIf(strNyukaForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strNyukaForm(shLoop), "")

                        Else
                            btnForm(shLoop).Text = ""

                        End If
                    Next

                Case 2
                    For shLoop = 1 To UBound(btnForm) Step 1
                        If strSyukkaForm(shLoop).Trim <> "" Then
                            btnForm(shLoop).Text = IIf(strSyukkaForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strSyukkaForm(shLoop), "")

                        Else
                            btnForm(shLoop).Text = ""

                        End If

                    Next

                Case 3
                    For shLoop = 1 To UBound(btnForm) Step 1
                        If strKenpinForm(shLoop).Trim <> "" Then
                            btnForm(shLoop).Text = IIf(strKenpinForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strKenpinForm(shLoop), "")

                        Else
                            btnForm(shLoop).Text = ""

                        End If
                    Next

                Case 4
                    For shLoop = 1 To UBound(btnForm) Step 1
                        If strHojyuForm(shLoop).Trim <> "" Then
                            btnForm(shLoop).Text = IIf(strHojyuForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strHojyuForm(shLoop), "")

                        Else
                            btnForm(shLoop).Text = ""

                        End If

                    Next



                Case 5
                    For shLoop = 1 To UBound(btnForm) Step 1
                        If strIdouForm(shLoop).Trim <> "" Then
                            btnForm(shLoop).Text = IIf(strIdouForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strIdouForm(shLoop), "")

                        Else
                            btnForm(shLoop).Text = ""

                        End If

                    Next

                Case 6
                    For shLoop = 1 To UBound(btnForm) Step 1
                        If strToiForm(shLoop).Trim <> "" Then
                            btnForm(shLoop).Text = IIf(strToiForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strToiForm(shLoop), "")

                        Else
                            btnForm(shLoop).Text = ""

                        End If

                    Next

                Case 7
                    For shLoop = 1 To UBound(btnForm) Step 1
                        If strMenteForm(shLoop).Trim <> "" Then
                            btnForm(shLoop).Text = IIf(strMenteForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strMenteForm(shLoop), "")

                        Else
                            btnForm(shLoop).Text = ""

                        End If


                    Next

                Case 8
                    For shLoop = 1 To UBound(btnForm) Step 1
                        If strSysForm(shLoop).Trim <> "" Then
                            btnForm(shLoop).Text = IIf(strSysForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strSysForm(shLoop), "")

                        Else
                            btnForm(shLoop).Text = ""

                        End If


                    Next

                Case 9
                    For shLoop = 1 To UBound(btnForm) Step 1
                        If strSokoForm(shLoop).Trim <> "" Then
                            btnForm(shLoop).Text = IIf(strSokoForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strSokoForm(shLoop), "")

                        Else
                            btnForm(shLoop).Text = ""

                        End If


                    Next

                Case 10
                    For shLoop = 1 To UBound(btnForm) Step 1
                        If strTanaOrosiForm(shLoop).Trim <> "" Then
                            btnForm(shLoop).Text = IIf(strTanaOrosiForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strTanaOrosiForm(shLoop), "")

                        Else
                            btnForm(shLoop).Text = ""

                        End If


                    Next

                    'Case 11
                    '    For shLoop = 1 To UBound(btnForm) Step 1
                    '        If strAnalyzeForm(shLoop).Trim <> "" Then
                    '            btnForm(shLoop).Text = IIf(strAnalyzeForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strAnalyzeForm(shLoop), "")

                    '        Else
                    '            btnForm(shLoop).Text = ""

                    '        End If


                    '    Next

                Case 11
                    For shLoop = 1 To UBound(btnForm) Step 1
                        If strDpmForm(shLoop).Trim <> "" Then
                            btnForm(shLoop).Text = IIf(strDpmForm(shLoop).Length > 0, Format(shLoop, "00") & "." & strDpmForm(shLoop), "")

                        Else
                            btnForm(shLoop).Text = ""

                        End If


                    Next

                Case Else
                    For shLoop = 1 To UBound(btnForm) Step 1
                        btnForm(shLoop).Text = ""

                    Next

                    For shLoop = 1 To UBound(OptMenu) Step 1
                        'チェック初期化
                        OptMenu(shLoop).Checked = False
                    Next

            End Select


            For shLoop = 1 To UBound(btnForm) Step 1

                'タイトル無しのボタンは使用不可
                If btnForm(shLoop).Text.Length = 0 Then

                    btnForm(shLoop).Enabled = False
                Else

                    btnForm(shLoop).Enabled = True
                End If
            Next


        Catch ex As Exception
            Call vbErrSub(Me.Name & "[" & GetCurrentMethod.Name & "]", Err.Number, ex)
        End Try

    End Sub

#End Region
End Class
