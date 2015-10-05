Option Explicit On 
Option Strict On

Imports WMS.clsCommon.Library

Namespace clsApplication
    Public Class ApplicationEvents

        Inherits System.Windows.Forms.ApplicationContext

        Public Shared oLibrary As clsCommon.Library

        '**********************************************************************************************
        '*                                                                                            *
        '*  New - コンストラクタ                                                                      *
        '*                                                                                            *
        '**********************************************************************************************
#Region " New - コンストラクタ "

        Public Sub New()

            MyBase.New()
            oLibrary = New clsCommon.Library

        End Sub
#End Region


        '**********************************************************************************************
        '*                                                                                            *
        '*  Start - アプリケーション開始                                                              *
        '*                                                                                            *
        '**********************************************************************************************
#Region " Start - アプリケーション開始 "

        Public Sub Start()
            Dim fMainFORM As New frmMenu


            ''インスタンスの二重起動防止
            'If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
            '    MsgBox(GetMsg("D990"))
            '    Application.Exit()
            '    Exit Sub
            'End If

            ''アプリケーション設定用ファイルの読込
            'If ConnectInfoXML.ReadFile Then
            '    ConnectInfoXML.XMLRead(AppSettings)
            'Else
            '    ConnectInfoXML.XMLWrite(AppSettings)
            'End If

            fMainFORM.ShowDialog()

        End Sub
#End Region


        '**********************************************************************************************
        '*                                                                                            *
        '*  Finalize - 終了時の処理(オーバーライド)                                                   *
        '*                                                                                            *
        '**********************************************************************************************
#Region " Finalize - 終了時の処理(オーバーライド) "

        Protected Overrides Sub Finalize()

            AppSettings = Nothing

            MyBase.Finalize()

        End Sub
#End Region

    End Class

End Namespace
