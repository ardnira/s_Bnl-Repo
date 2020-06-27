Imports C1.Win.C1FlexGrid.Classic

Public Class fCreate_Db_Malang
    Dim oDlg As OpenFileDialog = New OpenFileDialog()
    Private Sub Cmd_LoadXls_Click(sender As Object, e As EventArgs) Handles Cmd_LoadXls.Click
        Using oDlg
            Dim fXls As String = "Excel Files (*.xls) |*.xls"
            Dim fXlX As String = "Excel Files (*.xlsx) |*.xlsx"
            Dim fAll As String = "All files (*.*) |*.*"
            oDlg.Filter = fXlX & "|" & fXls & "|" & fAll
            oDlg.Title = "Save File Monev"
            If oDlg.InitialDirectory = "" Then
                oDlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop '"C:\"
            Else
                oDlg.InitialDirectory = GetFolder(oDlg.FileName)
            End If
            oDlg.FilterIndex = 1

            oDlg.RestoreDirectory = True

            If oDlg.ShowDialog() = DialogResult.Cancel Then Exit Sub
            Lexcell.Tag = oDlg.FileName : Lexcell.Text = "Load Excel ..." : Me.UseWaitCursor = True
            TabControl1.TabPages.Clear() : TabControl1.Visible = True
            Application.DoEvents()
            Dim sheets As String() = G_xls.LoadExcelSheetNames(oDlg.FileName)

            pgr.Visible = True : pgr.Maximum = sheets.Count : pgr.Value = 0
            For Each sheetName As String In sheets
                pgr.Value += 1
                If IsNumeric(CrText(sheetName, ".", 0)) Then
                    Lexcell.Text = sheetName & " ..."
                    Application.DoEvents()
                    Dim flx As New C1FlexGridClassic
                    flx.Name = "sht_" & CrText(sheetName, ".", 0)
                    flx.Dock = DockStyle.Fill
                    flx.FixedCols = 1
                    flx.FixedRows = 0
                    flx.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
                    'flx.GridLinesFixed = GridStyleSettings.flexGridFlatHorz
                    'flx.GridColorFixed = Color.Gray

                    '     flx.Cols = 60
                    flx.LoadExcel(oDlg.FileName, sheetName)
                    '      flx.Cols = 60
                    Application.DoEvents()
                    flx.set_RowHeight(10, 100)
                    flx.set_TextMatrix(10, 0, "No. Ruas")
                    flx.set_Cell(CellPropertySettings.flexcpBackColor, 10, 0, 10, flx.Cols - 1, Color.YellowGreen)
                    Dim page As TabPage = New TabPage
                    TabControl1.TabPages.Add(page)
                    page.Text = sheetName
                    page.Controls.Add(flx)
                    TabControl1.SelectedTab = page


                End If

                Application.DoEvents()
            Next

            TabControl1.Visible = True
        End Using
        Lexcell.Text = Lexcell.Tag
        pgr.Visible = False : Me.UseWaitCursor = False
    End Sub

    Private Sub fCreate_Db_Malang_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim alm_xls_Acuan As String = GetFolder(Application.ExecutablePath) & "\MalangTabel_Acuan.xls"
        G_xls.LoadExcel(alm_xls_Acuan)
    End Sub


    Private Sub Bt_CreateDt_Click(sender As Object, e As EventArgs) Handles Bt_CreateDt.Click
        Lexcell.Text = ""
        Dim nm_COl As String
        Dim sq As String = "Create table tJalan ( "
        sq += " Id_X UNIQUEIDENTIFIER CONSTRAINT New_PK_test PRIMARY KEY DEFAULT NewId() "

        For i As Integer = 0 To G_xls.Cols - 1
            nm_COl = G_xls(G_xls.Row, i)
            If IsNothing(nm_COl) Then Exit For
            nm_COl = nm_COl.Replace(".", "_")
            nm_COl = nm_COl.Replace("(", "_")
            nm_COl = nm_COl.Replace(")", "")
            nm_COl = nm_COl.Replace(" + ", "_")

            nm_COl = nm_COl.Replace("/", "_")
            nm_COl = nm_COl.Replace("/", "_")
            nm_COl = nm_COl.Replace("(%)", "Prsn")
            nm_COl = nm_COl.Replace("%", "Prsn")
            nm_COl = nm_COl.Replace("- ", "")
            nm_COl = nm_COl.Replace(" ", "_")
            nm_COl = nm_COl.Replace("__", "_")
            nm_COl = nm_COl.Replace("-", "_")

            If nm_COl.ToUpper = "NAMA_PANGKAL_RUAS" Then Exit For
            Lexcell.Text += vbCrLf & nm_COl

            sq += ", " & nm_COl & " varchar(200)"

        Next


        sq += ")"
        SetProc(sq)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To TabControl1.TabCount - 1
            TabControl1.SelectedIndex = i
            Application.DoEvents()
            Threading.Thread.Sleep(10)
            BtSaveDb_Click(sender, e)
            Threading.Thread.Sleep(10)
        Next
    End Sub
    Private Sub BtSaveDb_Click(sender As Object, e As EventArgs) Handles BtSaveDb.Click
        Dim fX As New C1FlexGridClassic
        Dim slc_idx As Integer = TabControl1.SelectedIndex
        fX = TabControl1.TabPages(slc_idx).Controls.Item(0)

        Dim brsA As Integer = Row_Awal(fX)
        Dim kolA As Integer = Col_Akhir(fX)
        fX.Cols = kolA + 1

        Dim nkol As String
        Dim ikol As String
        Dim fLd As String : Dim vLu As String

        GetRecGrid(G_xls, "select * from tJalan where 1=2")
        G_xls.Redraw = RedrawSettings.flexRDDirect
        G_xls.Refresh()
        For i As Integer = brsA + 1 To fX.Rows - 1
            fLd = "" : vLu = ""
            For k As Integer = 1 To fX.Cols - 1
                nkol = G_xls(0, k)

                Try : ikol = iObj(fX(i, k))
                Catch : ikol = "" : End Try

                nkol = " " & nkol & " "
                If IsNumeric(ikol) Then
                    ikol = "'" & ikol & "'"
                Else
                    ikol = "'" & ikol & "'"
                End If
                'fLd += IIf(i = 1, CrText(nkol, "=", 0), ", " & CrText(nkol, "=", 0))
                fLd += IIf(k = 1, nkol, ", " & nkol)
                vLu += IIf(k = 1, ikol, ", " & ikol)
            Next
            Dim sq As String = "Insert into tJalan (" & fLd & ") values (" & vLu & ") "
            Lexcell.Text = vLu
            Application.DoEvents()
            SetProc(sq)

        Next i

    End Sub

    Function Col_Akhir(fl As C1FlexGridClassic) As Integer
        Dim BRS As Integer = Row_Awal(fl)
        If BRS = -1 Then Return -1
        For i = 0 To 60
            If iObj(fl(BRS - 1, i)).ToString.ToUpper Like "*KOORDINAT Y TITIK AKHIR RUAS*" Then
                Return i
            End If
        Next
        Return fl.Cols - 1
    End Function
    Function Row_Awal(fl As C1FlexGridClassic) As Integer
        For i = 0 To 20
            For j = 0 To 20
                If iObj(fl(i, j)).ToString.ToUpper Like "*NAMA RUAS*" Then
                    Return i + 1
                End If
            Next
        Next
        Return -1
    End Function
    Function iObj(obj As Object) As Object
        Return IIf(IsNothing(obj), "", obj)
    End Function

    Private Sub fCreate_Db_Malang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class