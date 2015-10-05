Public Class ClassDataGrid

    '行選択
    Public Class DgvSelectRow

        '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
        '_/   関数名      ：[DgvSelectRow.]SelSingle
        '_/   概  要      ：データグリッドバックカラー変更関数(単一選択)
        '_/   引  数      ：dgvTarget     >> 対象データグリッド(参照渡し)
        '_/               ：iRow     >> 変更基準行№
        '_/               ：cColor   >> 変更時カラー
        '_/   戻り値      ：なし
        '_/   作成日      ：2013/03/22
        '_/   更新日      ：
        '_/   作成者      ：[apt]k.msr
        '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
        Public Sub SelSingle(ByRef dgvTarget As DataGridView, ByVal iRow As Integer, ByVal cColor As Color)

            Dim iRowIndex As Integer = 0
            Try

        
            dgvTarget.SuspendLayout() '描画停止



                If dgvTarget.Rows(iRow).DefaultCellStyle.BackColor.ToArgb <> cColor.ToArgb Then
                    '未選択を選択

                    '全行のバックカラー変更
                    For iRowIndex = 0 To dgvTarget.RowCount - 1
                        dgvTarget.Rows(iRowIndex).DefaultCellStyle.BackColor = Color.White
                        dgvTarget.Rows(iRowIndex).DefaultCellStyle.SelectionBackColor = Color.White

                    Next
                  
                    '選択行のバックカラー変更
                    dgvTarget.Rows(iRow).DefaultCellStyle.BackColor = cColor
                    dgvTarget.Rows(iRow).DefaultCellStyle.SelectionBackColor = cColor

                Else
                    '選択行を選択

                    '選択行のバックカラーを変更
                    dgvTarget.Rows(iRow).DefaultCellStyle.BackColor = Color.White
                    dgvTarget.Rows(iRow).DefaultCellStyle.SelectionBackColor = Color.White

                End If


            Catch ex As Exception
                Call vbErrSub("ClassDataGrid" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

            Finally
                dgvTarget.ResumeLayout() '描画開始

            End Try

           
        End Sub

        '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
        '_/   関数名      ：[DgvSelectRow.]SelPlural
        '_/   概  要      ：ｽﾌﾟﾚｯﾄﾞ選択行バックカラー変更関数(複数選択)
        '_/   引  数      ：oSPR     >> ｽﾌﾟﾚｯﾄﾞｼｰﾄ(参照渡し)
        '_/               ：iRow     >> 変更基準行№
        '_/               ：cColor   >> 変更時カラー
        '_/   戻り値      ：なし
        '_/   作成日      ：2006/02/16
        '_/   更新日      ：
        '_/   作成者      ：[n-apt]k.msr
        '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
        Public Sub SelPlural(ByRef dgvTarget As DataGridView, ByVal iRow As Integer, ByVal cColor As Color)
            Try

          
                dgvTarget.SuspendLayout() '描画停止
             
                If dgvTarget.Rows(iRow).DefaultCellStyle.BackColor.ToArgb <> cColor.ToArgb Then
                    '選択行カラー設定
                    dgvTarget.Rows(iRow).DefaultCellStyle.BackColor = cColor
                    dgvTarget.Rows(iRow).DefaultCellStyle.SelectionBackColor = cColor

                Else
                    '選択行カラー初期化
                    dgvTarget.Rows(iRow).DefaultCellStyle.BackColor = Color.White
                    dgvTarget.Rows(iRow).DefaultCellStyle.SelectionBackColor = Color.White

                End If



            Catch ex As Exception
                Call vbErrSub("ClassDataGrid" & Space(1) & System.Reflection.MethodInfo.GetCurrentMethod.Name, Err.Number, ex, False, 0)

            Finally
                dgvTarget.ResumeLayout() '描画開始

            End Try
        End Sub

    End Class


End Class
