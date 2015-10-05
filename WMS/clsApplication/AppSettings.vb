Option Explicit On 
Option Strict On

Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Namespace clsApplication

    '**********************************************************************************************
    '*                                                                                            *
    '*  Settings 上位通信の設定用                                                         *
    '*                                                                                            *
    '**********************************************************************************************
#Region " Public Class Settings "
    Public Class Settings


        ''AS/400 → WACS
        Private mstrAS400_User As String
        Private mstrAS400_PassWord As String
        Private mstrAS400_IPAddress As String
        Private mstrAS400_Directory As String

        ''WACS → AS/400
        Private mstrWACS_User As String
        Private mstrWACS_PassWord As String
        Private mstrWACS_IPAddress As String
        Private mstrWACS_Directory As String

        ''待機時間
        Private mintWaitSeconds As Integer
        Private mintWaitMinutes As Integer

        ''通信タイプ A:Ascii, I:Binary, B:SHIFT JIS KANJI
        Private mstrConnectType As String

        ''AS/400 → WACS
        ''ユーザー名
        Public Property AS400_User() As String
            Get
                Return mstrAS400_User
            End Get
            Set(ByVal Value As String)
                mstrAS400_User = Value
            End Set
        End Property

        ''AS/400 → WACS
        ''パスワード
        Public Property AS400_Password() As String
            Get
                Return mstrAS400_PassWord
            End Get
            Set(ByVal Value As String)
                mstrAS400_PassWord = Value
            End Set
        End Property

        ''AS/400 → WACS
        ''IPアドレス
        Public Property AS400_IPAddress() As String
            Get
                Return mstrAS400_IPAddress
            End Get
            Set(ByVal Value As String)
                mstrAS400_IPAddress = Value
            End Set
        End Property

        ''AS/400 → WACS
        ''ディレクトリ名
        Public Property AS400_Directory() As String
            Get
                Return mstrAS400_Directory
            End Get
            Set(ByVal Value As String)
                mstrAS400_Directory = Value
            End Set
        End Property

        ''WACS → AS/400
        ''ユーザー名
        Public Property WACS_User() As String
            Get
                Return mstrWACS_User
            End Get
            Set(ByVal Value As String)
                mstrWACS_User = Value
            End Set
        End Property

        ''WACS → AS/400
        ''パスワード
        Public Property WACS_Password() As String
            Get
                Return mstrWACS_PassWord
            End Get
            Set(ByVal Value As String)
                mstrWACS_PassWord = Value
            End Set
        End Property

        ''WACS → AS/400
        ''IPアドレス
        Public Property WACS_IPAddress() As String
            Get
                Return mstrWACS_IPAddress
            End Get
            Set(ByVal Value As String)
                mstrWACS_IPAddress = Value
            End Set
        End Property

        ''WACS → AS/400
        ''ディレクトリ名
        Public Property WACS_Directory() As String
            Get
                Return mstrWACS_Directory
            End Get
            Set(ByVal Value As String)
                mstrWACS_Directory = Value
            End Set
        End Property

        ''待ち時間(秒)
        Public Property WaitSeconds() As Integer
            Get
                Return mintWaitSeconds
            End Get
            Set(ByVal Value As Integer)
                mintWaitSeconds = Value
            End Set
        End Property

        ''待ち時間(分)
        Public Property WaitMinutes() As Integer
            Get
                Return mintWaitMinutes
            End Get
            Set(ByVal Value As Integer)
                mintWaitMinutes = Value
            End Set
        End Property

        ''通信タイプ
        Public Property ConnectType() As String
            Get
                Return mstrConnectType
            End Get
            Set(ByVal Value As String)
                mstrConnectType = Value
            End Set
        End Property

        Public Sub New()

            ''AS/400 → WACS
            mstrAS400_User = ""
            mstrAS400_PassWord = ""
            mstrAS400_IPAddress = ""
            mstrAS400_Directory = ""

            ''WACS → AS/400
            mstrWACS_User = ""
            mstrWACS_PassWord = ""
            mstrWACS_IPAddress = ""
            mstrWACS_Directory = ""

            ''待機時間
            mintWaitSeconds = 30
            mintWaitMinutes = 5

            ''通信タイプ
            mstrConnectType = "A"
        End Sub

    End Class
#End Region


    '**********************************************************************************************
    '*                                                                                            *
    '*  AppXML 上位通信の設定用XML操作                                                    *
    '*                                                                                            *
    '**********************************************************************************************
#Region " Public Class ConnectInfoXML "
    Public Class ConnectInfoXML

        Public Const FileName As String = "\ConnectInfo.config"

        ''設定ファイルの有無
        Public Shared ReadOnly Property ReadFile() As Boolean
            Get
                Return Dir(Application.StartupPath & FileName).Length > 0
            End Get
        End Property

        ''アプリケーションの設定用XMLファイル読込
        Public Shared Sub XMLRead(ByRef appSettings As Settings)

            ''XMLファイルから読み込む
            Dim Serializer As New Serialization.XmlSerializer(GetType(Settings))
            Dim XMLFile As New FileStream(Application.StartupPath & FileName, FileMode.Open)
            Dim SReader As New StreamReader(XMLFile, New UTF8Encoding)

            ''XMLファイルから読み込み、逆シリアル化する
            appSettings = CType(Serializer.Deserialize(SReader), Settings)

            XMLFile.Close()

        End Sub

        ''アプリケーションの設定用XMLファイル書込
        Public Shared Sub XMLWrite(ByVal appSettings As Settings)

            ''XMLファイルに書き込む
            Dim Serializer As New Serialization.XmlSerializer(GetType(Settings))
            Dim XMLFile As New FileStream(Application.StartupPath & FileName, FileMode.Create)
            Dim SWriter As New StreamWriter(XMLFile, New UTF8Encoding)

            'シリアル化し、XMLファイルに保存する
            Serializer.Serialize(SWriter, appSettings)

            XMLFile.Close()

        End Sub
    End Class
#End Region

End Namespace
