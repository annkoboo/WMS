''' <summary>
''' 区分や種別などのコード体系のクラス
''' </summary>
Public Class ClassCode
    '*********************************************************************
    'メンバ定義
    '*********************************************************************
    'コード名
    Public Enum CdNm
        SysKbn = 0      'システム区分
        SecurityKbn     'セキュリティ区分
        NyuShuKbn       '入出庫区分
        ZaimuKbn        '財務区分
        LvlKbn          '画面の使用区分
    End Enum

    'システム区分
    Public Const SYSKBN_GAMEN = "1"
    Public Const SYSKBN_HT = "2"
    Public SYSKBN(,) As String = {
        {SYSKBN_GAMEN, SYSKBN_HT},
        {"PC", "ハンディ"}
    }

    'セキュリティ区分
    Public Const SECURITYKBN_NASI = "0"
    Public Const SECURITYKBN_ARI = "1"
    Public SECURITYKBN(,) As String = {
        {SECURITYKBN_NASI, SECURITYKBN_ARI},
        {"ログイン画面表示なし", "ログイン画面表示あり"}
    }

    '入出庫区分
    Public Const NYUSHUKBN_NYUKO = "1"
    Public Const NYUSHUKBN_SHUKO = "2"
    Public DOSAKBN(,) As String = {
        {NYUSHUKBN_NYUKO, NYUSHUKBN_SHUKO},
        {"入庫", "出庫"}
    }

    '財務区分
    Public Const ZAIMUKBN_KANYOSURU = "1"
    Public Const ZAIMUKBN_KANYOSINAI = "2"
    Public ZAIMUKBN(,) As String = {
        {ZAIMUKBN_KANYOSURU, ZAIMUKBN_KANYOSINAI},
        {"関与する", "関与しない"}
    }

    '画面の使用区分
    Public Const LVLKBN_NG = 0
    Public Const LVLKBN_OK = 1
    Public LVLKBN(,) As String = {
        {LVLKBN_NG, LVLKBN_OK},
        {"使用不可", "使用可"}
    }

    '*********************************************************************
    'コンストラクタ定義
    '*********************************************************************
    Public Sub New()
    End Sub

    '*********************************************************************
    'ファンクション定義
    '*********************************************************************
    ''' <summary>コードの意味を取得する</summary>
    ''' <param name="Nm">コード名</param>
    ''' <param name="Cd">コード</param>
    ''' <returns>コードの意味</returns>
    ''' <remarks></remarks>
    Public Function GetMeaning(ByVal Nm As CdNm, ByVal Cd As String) As String
        Dim Arr(,) As String = SetCdArray(Nm)

        '配列から目的のコードを探し、コードに対する意味を返す
        For i As Integer = 0 To (Arr.Length / 2) - 1 Step 1
            If Arr(0, i) = Cd Then
                Return Arr(1, i)
            End If
        Next

        Return ""
    End Function

    ''' <summary>意味からコードを取得する</summary>
    ''' <param name="Nm">コード名</param>
    ''' <param name="Meaning">コードの意味</param>
    ''' <returns>コード</returns>
    ''' <remarks></remarks>
    Public Function GetCd(ByVal Nm As CdNm, ByVal Meaning As String) As String
        Dim Arr(,) As String = SetCdArray(Nm)

        '配列から目的の意味を探し、対応するコードを返す
        For i As Integer = 0 To (Arr.Length / 2) - 1 Step 1
            If Arr(1, i) = Meaning Then
                Return Arr(0, i)
            End If
        Next

        Return ""
    End Function

    ''' <summary>コードの2次元配列を作成する</summary>
    ''' <param name="Nm">コード名</param>
    ''' <returns>コードの2次元配列</returns>
    ''' <remarks></remarks>
    Public Function SetCdArray(ByVal Nm As CdNm) As String(,)
        Dim Arr(,) As String = {{""}, {""}}

        'コード名に該当する配列をコピー
        Select Case Nm
            Case CdNm.NyuShuKbn
                Arr = DOSAKBN.Clone
            Case CdNm.ZaimuKbn
                Arr = ZAIMUKBN.Clone
            Case CdNm.LvlKbn
                Arr = LVLKBN.Clone
        End Select

        Return Arr
    End Function

End Class
