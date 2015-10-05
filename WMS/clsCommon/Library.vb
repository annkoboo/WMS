Option Explicit On 
Option Strict On

Imports Oracle.DataAccess.Client
Imports System.IO
Imports System.Xml
Imports WMS.clsApplication

Namespace clsCommon

    Public Class Library

#Region " 変数宣言部 "

        Public Shared AppSettings As Settings

        Public Shared NullDateString As String = "    /  /  "
        Public Shared NullLocString As String = " -  -  - "
        Private Const SHIFT_JIS As String = "Shift_JIS"
        Private Shared zSQL As New System.Text.StringBuilder

#End Region


        '**********************************************************************************************
        '*                                                                                            *
        '*  New - コンストラクタ                                                                      *
        '*                                                                                            *
        '**********************************************************************************************
#Region " New - コンストラクタ "

        Public Sub New()

            AppSettings = New Settings

        End Sub
#End Region




        '**********************************************************************************************
        '*                                                                                            *
        '*  FUNCTION                                                                                  *
        '*                                                                                            *
        '**********************************************************************************************
#Region " FUNCTION "

        '********************************************
        '   文字列のByte数を返す
        '   strText : 対象文字列
        '********************************************
        Public Shared Function LenByte(ByVal strText As String) As Double

            LenByte = System.Text.Encoding.GetEncoding(SHIFT_JIS).GetByteCount(strText)

        End Function

        '********************************************
        '   文字列をByte数で制御
        '   strText : 対象文字列
        '   intByte : 最大バイト数
        '********************************************
        Public Shared Function ChkByte(ByVal strText As String, ByVal intByte As Integer) As String
            Dim intCnt As Integer
            Dim intLen As Integer = strText.Length
            Dim intWk As Integer = 0
            Dim strWK As String

            For intCnt = intLen To 1 Step -1
                strWK = Mid$(strText, 1, intCnt)
                intWk = System.Text.Encoding.GetEncoding(SHIFT_JIS).GetByteCount(strWK)
                If intWk <= intByte Then
                    Exit For
                End If
            Next intCnt
            ChkByte = strWK

        End Function

        '********************************************
        '   文字列が全て半角数値
        '   strText : 対象文字列
        '********************************************
        Public Shared Function chkCode(ByVal strText As String, Optional ByVal blnNumber As Boolean = False) As Boolean
            Dim intCnt As Integer
            Dim intStart As Integer = 0

            chkCode = False

            If strText.Length > 0 Then
                If strText.Substring(0, 1) = "-" AndAlso blnNumber Then
                    intStart = 1
                End If

                For intCnt = intStart To strText.Length - 1
                    If strText.Substring(intCnt, 1) <> "0" AndAlso _
                        strText.Substring(intCnt, 1) <> "1" AndAlso _
                        strText.Substring(intCnt, 1) <> "2" AndAlso _
                        strText.Substring(intCnt, 1) <> "3" AndAlso _
                        strText.Substring(intCnt, 1) <> "4" AndAlso _
                        strText.Substring(intCnt, 1) <> "5" AndAlso _
                        strText.Substring(intCnt, 1) <> "6" AndAlso _
                        strText.Substring(intCnt, 1) <> "7" AndAlso _
                        strText.Substring(intCnt, 1) <> "8" AndAlso _
                        strText.Substring(intCnt, 1) <> "9" Then
                        Exit Function
                    End If
                Next intCnt
            End If

            chkCode = True

        End Function

        '********************************************
        '   文字列が全て半角数値
        '   strText : 対象文字列
        '********************************************
        Public Shared Function LengthFill(ByVal strText As String, ByVal intMax As Integer) As String
            Dim strZero As String

            LengthFill = vbNullString

            If strText.Length > 0 Then
                strZero = Space(intMax).Replace(Space(1), "0") & strText
                strZero = strZero.Substring(Len(strZero) - intMax, intMax)
                LengthFill = strZero
            End If

        End Function

        '********************************************
        '   数値型の場合はそのまま、そうでなければNullValueを返す。
        '   objTemp : 対象
        '********************************************
        Public Shared Function NVL(ByVal objTemp As Object, Optional ByVal NullValue As Double = 0) As Double

            NVL = NullValue

            If IsNumeric(objTemp) Then
                NVL = CDbl(objTemp)
            End If

        End Function

        '********************************************
        '   [']を['']にして返す!
        '   strValue : 対象
        '********************************************
        ''[']を['']にして返す!
        Public Shared Function SQLStr(ByVal strValue As String) As String

            If Len(strValue) <= 0 Then Exit Function
            SQLStr = strValue.Replace("'", "''")

        End Function


        '**************************************************************************
        '***    機能：CommonMessage.resxからメッセージ文字列の取得
        '***    引数：ParaName:String
        '***    戻値：メッセージ
        '**************************************************************************
        Public Shared Function GetMsg(ByVal strName As String) As String
            Dim objRM As New Resources.ResourceManager(GetType(WMS.CommonBas).Namespace & ".CommonMsg", Reflection.Assembly.GetExecutingAssembly)
            'Dim objCI As Globalization.CultureInfo = Threading.Thread.CurrentThread.CurrentCulture

            Try

                '文字列を取得
                GetMsg = objRM.GetString(strName) & vbNullString ', objCI)

            Catch ex As Exception
                Call vbErrSub("GetMsg", CShort(Err.Number), ex)
            Finally
                objRM = Nothing
            End Try
        End Function


        ' Select文の最初の項目を文字型で返す
        Public Shared Function FirstField(ByVal OraDB As ACCESS.Oracle_Access, ByVal SQL As String) As String
            Dim oraDR As OracleDataReader

            FirstField = ""

            oraDR = OraDB.Read(SQL)

            If oraDR.Read Then
                FirstField = oraDR.GetValue(0).ToString
            End If

            oraDR.Close()

        End Function


        ' 在庫更新用プロシージャ
        Public Shared Function ZaikoSql(ByVal pZONE As String, ByVal pRETSU As String, ByVal pREN As String, ByVal pDAN As String, ByVal pUNIT_NO As String, ByVal pHIN_CD As String, ByVal pLOT_NO As String, ByVal pSYOMIKIGEN As String, ByVal pKENSA_KBN As String, ByVal pZAI_KBN As String, ByVal pZAI_SUU As Decimal, ByVal pRIYU_KBN As String, ByVal pTana As Boolean, Optional ByVal blnLabel As Boolean = True) As String

            ZaikoSql = vbNullString

            zSQL.Remove(0, zSQL.Length)

            zSQL.Append("DECLARE" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("    /* カーソル変数の型定義 */" & vbLf)
            zSQL.Append("    TYPE tc$CURSOR    IS REF CURSOR; " & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("    /* カーソル変数自体の定義 */" & vbLf)
            zSQL.Append("    c$Zaiko           tc$CURSOR;" & vbLf)
            If blnLabel Then
                zSQL.Append("    c$Lbl             tc$CURSOR;" & vbLf)
            End If
            zSQL.Append("    c$MST             tc$CURSOR;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("    newZ              ZAIKO_TBL%ROWTYPE;" & vbLf)
            zSQL.Append("    oldZ              ZAIKO_TBL%ROWTYPE;" & vbLf)
            If blnLabel Then
                zSQL.Append("    lblT              LABEL_TBL%ROWTYPE;" & vbLf)
                zSQL.Append("    t$PALLET_KBN      LABEL_TBL.PALLET_KBN%TYPE;" & vbLf)
                zSQL.Append("    t$ZAI_SUU         LABEL_TBL.ZAI_SUU%TYPE;" & vbLf)
            End If
            zSQL.Append("" & vbLf)
            zSQL.Append("    t$TANA_KBN        TANA_TBL.TANA_KBN%TYPE;" & vbLf)
            zSQL.Append("    t$YOYAKU_KBN      TANA_TBL.YOYAKU_KBN%TYPE;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("    t$NYUSYU_KBN      JISSEKI_TBL.NYUSYU_KBN%TYPE;" & vbLf)
            zSQL.Append("    t$HIN_NAME        HIN_MST.HIN_NAME%TYPE;" & vbLf)
            zSQL.Append("    t$IRI_SUU         HIN_MST.IRI_SUU%TYPE;" & vbLf)
            zSQL.Append("    t$TSUMI_SUU       HIN_MST.TSUMI_SUU%TYPE;" & vbLf)
            zSQL.Append("    t$RIYU_KBN        RIYU_MST.RIYU_KBN%TYPE;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("BEGIN" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("    newZ.ZONE         := '" & SQLStr(pZONE) & "';" & vbLf)
            zSQL.Append("    newZ.RETSU        := '" & SQLStr(pRETSU) & "';" & vbLf)
            zSQL.Append("    newZ.REN          := '" & SQLStr(pREN) & "';" & vbLf)
            zSQL.Append("    newZ.DAN          := '" & SQLStr(pDAN) & "';" & vbLf)
            zSQL.Append("    newZ.UNIT_NO      := '" & SQLStr(pUNIT_NO) & "';" & vbLf)
            zSQL.Append("    newZ.HIN_CD       := '" & SQLStr(pHIN_CD) & "';" & vbLf)
            zSQL.Append("    newZ.LOT_NO       := '" & SQLStr(pLOT_NO) & "';" & vbLf)
            zSQL.Append("    newZ.SYOMIKIGEN   := '" & SQLStr(pSYOMIKIGEN) & "';" & vbLf)
            zSQL.Append("    newZ.KENSA_KBN    := '" & SQLStr(pKENSA_KBN) & "';" & vbLf)
            zSQL.Append("    newZ.ZAI_KBN      := '" & SQLStr(pZAI_KBN) & "';" & vbLf)
            zSQL.Append("    newZ.ZAI_SUU      := " & pZAI_SUU & ";" & vbLf)
            zSQL.Append("--    newZ.NYUKO_DATE := TO_DATE();" & vbLf)
            zSQL.Append("    t$RIYU_KBN        := '" & SQLStr(pRIYU_KBN) & "';" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("    :p$RET := '0';" & vbLf)
            zSQL.Append("    :p$MSG := NULL;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("--  ** 在庫データを開く ***********************************" & vbLf)
            zSQL.Append("    OPEN c$Zaiko FOR" & vbLf)
            zSQL.Append("    SELECT * FROM ZAIKO_TBL" & vbLf)
            zSQL.Append("    WHERE ZONE = newZ.ZONE" & vbLf)
            zSQL.Append("    AND   RETSU = newZ.RETSU" & vbLf)
            zSQL.Append("    AND   REN = newZ.REN" & vbLf)
            zSQL.Append("    AND   DAN   = newZ.DAN" & vbLf)
            zSQL.Append("    AND   UNIT_NO   = newZ.UNIT_NO" & vbLf)
            zSQL.Append("    FOR UPDATE NOWAIT;" & vbLf)
            zSQL.Append("    FETCH c$Zaiko INTO oldZ;" & vbLf)
            zSQL.Append("    CLOSE c$Zaiko;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("" & vbLf)
            If blnLabel Then
                zSQL.Append("--  ** ラベルテーブルを開く *******************************" & vbLf)
                zSQL.Append("    OPEN c$Lbl FOR" & vbLf)
                zSQL.Append("    SELECT * FROM LABEL_TBL" & vbLf)
                zSQL.Append("    WHERE LABEL_KBN = '1'" & vbLf)
                zSQL.Append("    AND   TANA_NO = newZ.ZONE || newZ.RETSU || newZ.REN || newZ.DAN" & vbLf)
                zSQL.Append("    AND   UNIT_NO   = newZ.UNIT_NO" & vbLf)
                zSQL.Append("    FOR UPDATE NOWAIT;" & vbLf)
                zSQL.Append("    FETCH c$Lbl INTO lblT;" & vbLf)
                zSQL.Append("    CLOSE c$Lbl;" & vbLf)
                zSQL.Append("" & vbLf)
                zSQL.Append("" & vbLf)
            End If
            zSQL.Append("--  ** 棚テーブルを開く ***********************************" & vbLf)
            zSQL.Append("    OPEN c$MST FOR" & vbLf)
            zSQL.Append("    SELECT " & vbLf)
            zSQL.Append("        TANA_KBN,YOYAKU_KBN" & vbLf)
            zSQL.Append("    FROM " & vbLf)
            zSQL.Append("        TANA_TBL" & vbLf)
            zSQL.Append("    WHERE ZONE = newZ.ZONE" & vbLf)
            zSQL.Append("    AND   RETSU = newZ.RETSU" & vbLf)
            zSQL.Append("    AND   REN = newZ.REN" & vbLf)
            zSQL.Append("    AND   DAN   = newZ.DAN" & vbLf)
            zSQL.Append("    FOR UPDATE NOWAIT;" & vbLf)
            zSQL.Append("    FETCH c$MST INTO t$TANA_KBN,t$YOYAKU_KBN;" & vbLf)
            zSQL.Append("    IF c$MST%NOTFOUND THEN" & vbLf)
            zSQL.Append("        CLOSE c$MST;" & vbLf)
            zSQL.Append("        :p$RET := '9';" & vbLf)
            zSQL.Append("        :p$MSG := '棚がありません。';" & vbLf)
            zSQL.Append("        RETURN;" & vbLf)
            zSQL.Append("    END IF;" & vbLf)
            zSQL.Append("    CLOSE c$MST;" & vbLf)
            zSQL.Append("" & vbLf)
            If Not blnLabel Then
                zSQL.Append("    IF NVL(t$TANA_KBN,' ') = '1' THEN" & vbLf)
                zSQL.Append("        :p$RET := '9';" & vbLf)
                zSQL.Append("        :p$MSG := '禁止棚です。';" & vbLf)
                zSQL.Append("        RETURN;" & vbLf)
                zSQL.Append("    END IF;" & vbLf)
                zSQL.Append("" & vbLf)
            End If
            If Not pTana Then
                zSQL.Append("    IF NVL(t$YOYAKU_KBN,' ') = '1' THEN" & vbLf)
                zSQL.Append("        :p$RET := '9';" & vbLf)
                zSQL.Append("        :p$MSG := '棚卸予約済です。';" & vbLf)
                zSQL.Append("        RETURN;" & vbLf)
                zSQL.Append("    END IF;" & vbLf)
                zSQL.Append("" & vbLf)
            End If
            zSQL.Append("" & vbLf)
            zSQL.Append("--  ** 品名マスタを開く ***********************************" & vbLf)
            zSQL.Append("    OPEN c$MST FOR" & vbLf)
            zSQL.Append("    SELECT " & vbLf)
            zSQL.Append("        HIN_NAME,IRI_SUU,TSUMI_SUU" & vbLf)
            zSQL.Append("    FROM " & vbLf)
            zSQL.Append("        HIN_MST" & vbLf)
            zSQL.Append("    WHERE HIN_CD = newZ.HIN_CD;" & vbLf)
            zSQL.Append("    FETCH c$MST INTO t$HIN_NAME,t$IRI_SUU,t$TSUMI_SUU;" & vbLf)
            zSQL.Append("    CLOSE c$MST;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("    t$IRI_SUU := NVL(t$IRI_SUU,0);" & vbLf)
            zSQL.Append("    t$TSUMI_SUU := NVL(t$TSUMI_SUU,0);" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("--  ** ユニットNO発番 *************************************" & vbLf)
            zSQL.Append("    IF newZ.UNIT_NO IS NULL THEN" & vbLf)
            zSQL.Append("        SELECT " & vbLf)
            zSQL.Append("            TO_CHAR(SYSDATE,'YYYYMMDD') || TO_CHAR(NVL((SELECT TO_NUMBER(MAX(SUBSTR(UNIT_NO,9,5))) FROM LABEL_TBL WHERE LABEL_KBN = '1' AND UNIT_NO LIKE TO_CHAR(SYSDATE,'YYYYMMDD')||'%'),0)+1,'FM00000') " & vbLf)
            zSQL.Append("        INTO newZ.UNIT_NO " & vbLf)
            zSQL.Append("        FROM DUAL; " & vbLf)
            zSQL.Append("    END IF;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("--  ** 在庫とラベルの更新 *********************************" & vbLf)
            zSQL.Append("    IF newZ.ZAI_SUU = 0 THEN" & vbLf)
            zSQL.Append("        IF oldZ.ZONE IS NOT NULL THEN" & vbLf)
            zSQL.Append("            DELETE FROM ZAIKO_TBL" & vbLf)
            zSQL.Append("            WHERE ZONE    = oldZ.ZONE" & vbLf)
            zSQL.Append("            AND   RETSU   = oldZ.RETSU" & vbLf)
            zSQL.Append("            AND   REN     = oldZ.REN" & vbLf)
            zSQL.Append("            AND   DAN     = oldZ.DAN" & vbLf)
            zSQL.Append("            AND   UNIT_NO = oldZ.UNIT_NO;" & vbLf)
            zSQL.Append("" & vbLf)
            If blnLabel Then
                zSQL.Append("" & vbLf)
                zSQL.Append("            DELETE FROM LABEL_TBL" & vbLf)
                zSQL.Append("            WHERE LABEL_KBN = '1'" & vbLf)
                zSQL.Append("            AND   TANA_NO = oldZ.ZONE || oldZ.RETSU || oldZ.REN || oldZ.DAN" & vbLf)
                zSQL.Append("            AND   UNIT_NO   = oldZ.UNIT_NO;" & vbLf)
            End If
            zSQL.Append("        END IF;" & vbLf)
            zSQL.Append("    ELSE" & vbLf)
            zSQL.Append("        IF oldZ.ZONE IS NULL THEN" & vbLf)
            zSQL.Append("            INSERT INTO ZAIKO_TBL " & vbLf)
            zSQL.Append("            (" & vbLf)
            zSQL.Append("                ZONE,    RETSU,    REN,    DAN,UNIT_NO," & vbLf)
            zSQL.Append("                HIN_CD,    LOT_NO,    SYOMIKIGEN," & vbLf)
            zSQL.Append("                KENSA_KBN,    ZAI_KBN," & vbLf)
            zSQL.Append("                ZAI_SUU,    NYUKO_DATE" & vbLf)
            zSQL.Append("            ) VALUES (" & vbLf)
            zSQL.Append("                newZ.ZONE,    newZ.RETSU,    newZ.REN,    newZ.DAN,    newZ.UNIT_NO," & vbLf)
            zSQL.Append("                newZ.HIN_CD,    newZ.LOT_NO,    newZ.SYOMIKIGEN," & vbLf)
            zSQL.Append("                newZ.KENSA_KBN,    newZ.ZAI_KBN," & vbLf)
            zSQL.Append("                newZ.ZAI_SUU,    SYSDATE" & vbLf)
            zSQL.Append("            );" & vbLf)
            zSQL.Append("" & vbLf)
            If blnLabel Then
                zSQL.Append("" & vbLf)
                zSQL.Append("            IF NVL(t$IRI_SUU,0) = 0 THEN" & vbLf)
                zSQL.Append("                t$ZAI_SUU := newZ.ZAI_SUU;" & vbLf)
                zSQL.Append("            ELSE" & vbLf)
                zSQL.Append("                t$ZAI_SUU := TRUNC(newZ.ZAI_SUU / t$IRI_SUU);" & vbLf)
                zSQL.Append("            END IF;" & vbLf)
                zSQL.Append("" & vbLf)
                zSQL.Append("            IF t$TSUMI_SUU = t$ZAI_SUU THEN" & vbLf)
                zSQL.Append("                t$PALLET_KBN := '1';" & vbLf)
                zSQL.Append("            ELSE" & vbLf)
                zSQL.Append("                t$PALLET_KBN := '2';" & vbLf)
                zSQL.Append("            END IF;" & vbLf)
                zSQL.Append("" & vbLf)
                zSQL.Append("            INSERT INTO LABEL_TBL " & vbLf)
                zSQL.Append("            (" & vbLf)
                zSQL.Append("                LABEL_KBN,    TANA_NO,    UNIT_NO," & vbLf)
                zSQL.Append("                N_DENPYO_NO,    RECORD_NO,    SENPO_NO,    N_YOTEI_DATE," & vbLf)
                zSQL.Append("                HIN_CD,    HIN_NAME,    LOT_NO," & vbLf)
                zSQL.Append("                SYOMIKIGEN,    KENSA_KBN,    ZAI_SUU," & vbLf)
                zSQL.Append("                PALLET_KBN,    PRINT_KBN," & vbLf)
                zSQL.Append("                PRINT_DATE,    PRINT_SUU," & vbLf)
                zSQL.Append("                RE_PRINT,      NYUKO_KBN" & vbLf)
                zSQL.Append("            ) VALUES (" & vbLf)
                zSQL.Append("                '1',    newZ.ZONE || newZ.RETSU || newZ.REN || newZ.DAN,    newZ.UNIT_NO," & vbLf)
                zSQL.Append("                NULL,    NULL,    NULL,    TO_CHAR(SYSDATE,'YYYYMMDD')," & vbLf)
                zSQL.Append("                newZ.HIN_CD,    t$HIN_NAME,    newZ.LOT_NO," & vbLf)
                zSQL.Append("                newZ.SYOMIKIGEN,    newZ.KENSA_KBN,    TRUNC(newZ.ZAI_SUU / DECODE(NVL(t$IRI_SUU,0),0,1,t$IRI_SUU))," & vbLf)
                zSQL.Append("                t$PALLET_KBN,    '0'," & vbLf)
                zSQL.Append("                NULL,    0," & vbLf)
                zSQL.Append("                '1',    '1'" & vbLf)
                zSQL.Append("            );" & vbLf)
            End If
            zSQL.Append("        ELSE" & vbLf)
            zSQL.Append("            UPDATE ZAIKO_TBL SET" & vbLf)
            zSQL.Append("                HIN_CD = newZ.HIN_CD," & vbLf)
            zSQL.Append("                LOT_NO = newZ.LOT_NO," & vbLf)
            zSQL.Append("                SYOMIKIGEN = newZ.SYOMIKIGEN," & vbLf)
            zSQL.Append("                KENSA_KBN = newZ.KENSA_KBN," & vbLf)
            zSQL.Append("                ZAI_KBN = newZ.ZAI_KBN," & vbLf)
            zSQL.Append("                ZAI_SUU = newZ.ZAI_SUU" & vbLf)
            zSQL.Append("            WHERE ZONE    = oldZ.ZONE" & vbLf)
            zSQL.Append("            AND   RETSU   = oldZ.RETSU" & vbLf)
            zSQL.Append("            AND   REN     = oldZ.REN" & vbLf)
            zSQL.Append("            AND   DAN     = oldZ.DAN" & vbLf)
            zSQL.Append("            AND   UNIT_NO = oldZ.UNIT_NO;" & vbLf)
            If blnLabel Then
                zSQL.Append("" & vbLf)
                zSQL.Append("            IF NVL(newZ.HIN_CD,' ')     <> NVL(oldZ.HIN_CD,' ') OR" & vbLf)
                zSQL.Append("               NVL(newZ.LOT_NO,' ')     <> NVL(oldZ.LOT_NO,' ') OR" & vbLf)
                zSQL.Append("               NVL(newZ.SYOMIKIGEN,' ') <> NVL(oldZ.SYOMIKIGEN,' ') OR" & vbLf)
                zSQL.Append("               newZ.ZAI_SUU             <> NVL(oldZ.ZAI_SUU,0) THEN" & vbLf)
                zSQL.Append("" & vbLf)
                zSQL.Append("                IF NVL(t$IRI_SUU,0) = 0 THEN" & vbLf)
                zSQL.Append("                    t$ZAI_SUU := newZ.ZAI_SUU;" & vbLf)
                zSQL.Append("                ELSE" & vbLf)
                zSQL.Append("                    t$ZAI_SUU := TRUNC(newZ.ZAI_SUU / t$IRI_SUU);" & vbLf)
                zSQL.Append("                END IF;" & vbLf)
                zSQL.Append("" & vbLf)
                zSQL.Append("                IF t$TSUMI_SUU = t$ZAI_SUU THEN" & vbLf)
                zSQL.Append("                    t$PALLET_KBN := '1';" & vbLf)
                zSQL.Append("                ELSE" & vbLf)
                zSQL.Append("                    t$PALLET_KBN := '2';" & vbLf)
                zSQL.Append("                END IF;" & vbLf)
                zSQL.Append("" & vbLf)
                zSQL.Append("                UPDATE LABEL_TBL SET" & vbLf)
                zSQL.Append("                    HIN_CD     = newZ.HIN_CD," & vbLf)
                zSQL.Append("                    HIN_NAME   = t$HIN_NAME," & vbLf)
                zSQL.Append("                    LOT_NO     = newZ.LOT_NO," & vbLf)
                zSQL.Append("                    SYOMIKIGEN = newZ.SYOMIKIGEN," & vbLf)
                zSQL.Append("                    KENSA_KBN  = newZ.KENSA_KBN," & vbLf)
                zSQL.Append("                    ZAI_SUU    = TRUNC(newZ.ZAI_SUU / DECODE(NVL(t$IRI_SUU,0),0,1,t$IRI_SUU))," & vbLf)
                zSQL.Append("                    PALLET_KBN = t$PALLET_KBN " & vbLf)
                zSQL.Append("                WHERE LABEL_KBN = '1'" & vbLf)
                zSQL.Append("                AND   TANA_NO   = newZ.ZONE || newZ.RETSU || newZ.REN || newZ.DAN" & vbLf)
                zSQL.Append("                AND   UNIT_NO   = newZ.UNIT_NO;" & vbLf)
                zSQL.Append("            END IF;" & vbLf)
            End If
            zSQL.Append("        END IF;" & vbLf)
            zSQL.Append("    END IF;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("--  ** 棚テーブルの更新 ***********************************" & vbLf)
            zSQL.Append("    UPDATE TANA_TBL SET" & vbLf)
            zSQL.Append("        KON_SUU = NVL(" & vbLf)
            zSQL.Append("                     (SELECT COUNT(*) FROM " & vbLf)
            zSQL.Append("                         (SELECT DISTINCT HIN_CD,LOT_NO FROM ZAIKO_TBL" & vbLf)
            zSQL.Append("                         WHERE ZONE    = newZ.ZONE" & vbLf)
            zSQL.Append("                         AND   RETSU   = newZ.RETSU" & vbLf)
            zSQL.Append("                         AND   REN     = newZ.REN" & vbLf)
            zSQL.Append("                         AND   DAN     = newZ.DAN))" & vbLf)
            zSQL.Append("                     ,0)" & vbLf)
            zSQL.Append("    WHERE ZONE    = newZ.ZONE" & vbLf)
            zSQL.Append("    AND   RETSU   = newZ.RETSU" & vbLf)
            zSQL.Append("    AND   REN     = newZ.REN" & vbLf)
            zSQL.Append("    AND   DAN     = newZ.DAN;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("--  ** 実績テーブルの追加 *********************************" & vbLf)
            zSQL.Append("    IF newZ.ZAI_SUU <> NVL(oldZ.ZAI_SUU,0) THEN" & vbLf)
            zSQL.Append("        IF newZ.ZAI_SUU > NVL(oldZ.ZAI_SUU,0) THEN" & vbLf)
            zSQL.Append("            t$NYUSYU_KBN := '1';" & vbLf)
            zSQL.Append("        ELSE" & vbLf)
            zSQL.Append("            t$NYUSYU_KBN := '2';" & vbLf)
            zSQL.Append("        END IF;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("        INSERT INTO JISSEKI_TBL " & vbLf)
            zSQL.Append("        (" & vbLf)
            zSQL.Append("            SAG_DATE,    NYUSYU_KBN," & vbLf)
            zSQL.Append("            RENBAN," & vbLf)
            zSQL.Append("            RIYU_KBN," & vbLf)
            zSQL.Append("            ZONE,    RETSU,    REN,    DAN," & vbLf)
            zSQL.Append("            HIN_CD,    HIN_NAME,    ZAI_KBN,    LOT_NO," & vbLf)
            zSQL.Append("            IRI_SUU,    UNIT_NO,    SYOMIKIGEN," & vbLf)
            zSQL.Append("            SAG_SUU,    BEFORE_SUU,    AFTER_SUU" & vbLf)
            zSQL.Append("        ) VALUES (" & vbLf)
            zSQL.Append("            SYSDATE,    t$NYUSYU_KBN," & vbLf)
            zSQL.Append("            NVL((SELECT MAX(RENBAN) FROM JISSEKI_TBL WHERE SAG_DATE = SYSDATE AND NYUSYU_KBN = t$NYUSYU_KBN),0) + 1," & vbLf)
            zSQL.Append("            t$RIYU_KBN," & vbLf)
            zSQL.Append("            newZ.ZONE,    newZ.RETSU,    newZ.REN,    newZ.DAN," & vbLf)
            zSQL.Append("            newZ.HIN_CD,    t$HIN_NAME,    newZ.ZAI_KBN,    newZ.LOT_NO," & vbLf)
            zSQL.Append("            t$IRI_SUU,    newZ.UNIT_NO,    newZ.SYOMIKIGEN," & vbLf)
            zSQL.Append("            ABS(NVL(oldZ.ZAI_SUU,0) - newZ.ZAI_SUU),    NVL(oldZ.ZAI_SUU,0),    newZ.ZAI_SUU" & vbLf)
            zSQL.Append("        );" & vbLf)
            zSQL.Append("    END IF;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("EXCEPTION" & vbLf)
            zSQL.Append("    WHEN OTHERS THEN" & vbLf)
            zSQL.Append("        :p$RET := '9';" & vbLf)
            zSQL.Append("        :p$MSG := SUBSTRB(SQLERRM,1,255);" & vbLf)
            zSQL.Append("        RAISE;" & vbLf)
            zSQL.Append("" & vbLf)
            zSQL.Append("END;" & vbLf)

            ZaikoSql = zSQL.ToString

        End Function
#End Region

    End Class
End Namespace
