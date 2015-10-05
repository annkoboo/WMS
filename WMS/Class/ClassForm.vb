Imports Oracle.DataAccess.Client
Public Class ClassForm
    ''' <summary>
    ''' マウスカーソルを砂時計、画面をDisableにする
    ''' </summary>
    ''' <param name="target">ターゲットの画面</param>
    Public Sub WaitCursorAndDisable(ByRef target As Form)
        target.Cursor = Cursors.WaitCursor
        target.Enabled = False
        target.Refresh()
    End Sub

    ''' <summary>
    ''' マウスカーソルをノーマル、画面をEnableにする
    ''' </summary>
    ''' <param name="target"></param>
    Public Sub ArrowAndEnable(ByRef target As Form)
        target.Cursor = Cursors.Arrow
        target.Enabled = True
        target.Refresh()
    End Sub

    ''' <summary>
    ''' 画面のアクセス権を取得する
    ''' </summary>
    ''' <param name="FrmNm">ターゲットのフォーム名</param>
    ''' <returns>9段階のアクセス権の配列</returns>
    Public Function GetOpeAuth(ByRef FrmNm As String) As String()
        'SQL作成
        Dim Sql As String = ""
        Sql += "select A.* "
        Sql += "from M_GAMEN_ID G "
        Sql += "left join M_ACCESS_CONTROL A on A.GAMEN_ID = G.GAMEN_ID "
        Sql += "where G.SYS_KBN = " & OraDB.Num(ClassCode.SYSKBN_GAMEN)
        Sql += "and G.SECURITY_KBN = " & OraDB.Num(ClassCode.SECURITYKBN_ARI)
        Sql += "and G.PG_NAME = " & OraDB.Str(FrmNm)
        Debug.Print(Sql)

        'SQL実行
        Dim OraReader As OracleDataReader
        OraReader = OraDB.Read(Sql)

        'SELECTしたデータを取得
        Dim Arr() As String     '操作権限マスタに該当の画面がないときは、空の配列を返す
        If OraReader.Read() = True Then
            ReDim Arr(8)        '9段階のアクセス権を配列にする
            Arr(0) = OraReader("LVL1_KBN")
            Arr(1) = OraReader("LVL2_KBN")
            Arr(2) = OraReader("LVL3_KBN")
            Arr(3) = OraReader("LVL4_KBN")
            Arr(4) = OraReader("LVL5_KBN")
            Arr(5) = OraReader("LVL6_KBN")
            Arr(6) = OraReader("LVL7_KBN")
            Arr(7) = OraReader("LVL8_KBN")
            Arr(8) = OraReader("LVL9_KBN")
        Else
            'データを取得できなかった時は、ArrをNothingのまま返す（ターゲットフォームにはアクセス権の設定がない誰でも操作OKの画面とする）
        End If

        'アクセス権を返す
        OraReader.Close()
        Return Arr
    End Function

    'fncShowMsgの
    Public Enum MsgType
        GuideMsg = 0
        WarningMsg
        ErrorMsg
    End Enum

    Public Sub fncShowMsg(ByVal MsgTyp As MsgType, ByVal MsgStr As String)





    End Sub

    Public Sub fncShowMsgDatLock()
        Dim Msg As String = "このデータは他の方が編集中ですので修正できません。"
        MessageBox.Show(Msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class
