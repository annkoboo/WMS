Option Explicit On 
Option Strict On

Imports WMS.clsCommon.Library

Module CommonBas

    Public Logon_UserCd As Integer = 0
    Public Logon_UserAccLvl As Integer = 0

    '**********************************************************************************************
    '*                                                                                            *
    '*  Sub Main()                                                                                *
    '*                                                                                            *
    '**********************************************************************************************
#Region " Sub Main() "

    Sub Main()
        Dim App As New clsApplication.ApplicationEvents

        Try

            App.Start()

        Catch ex As Exception
            Call vbErrSub("Sub Main", CShort(Err.Number), ex)
        End Try
    End Sub

#End Region

End Module
