Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Public Class fData
    Public nmTbl As String = ""
    Dim SibukLoad As Boolean = True


   Sub Tampil(tbl As Object, fd As Form)
      nmTbl = tbl.name.ToString.Replace("smData_", "t")
      If InStr("tBarangtCustomertSupliertUser", nmTbl) > 0 Then
         pnl_Cap_Data.BackgroundImage = tbl.Image

         'If nmTbl.Contains("Barang") Then pnl_Cap_Data.BackgroundImage = Bnl_First.btListBarang.Image
         'If nmTbl.Contains("Suplier") Then pnl_Cap_Data.BackgroundImage = Bnl_First.btListSuplier.Image
         'If nmTbl.Contains("Customer") Then pnl_Cap_Data.BackgroundImage = Bnl_First.btListCustomer.Image
         'If nmTbl.Contains("User") Then pnl_Cap_Data.BackgroundImage = tbl.Image
      Else 'jika PIUTANG/HUTANG
         '    nmTbl = IIf(UCase(tbl) = "PIUTANG", "tCustomer", "tSuplier")
      End If

      Ljudul.Text = "Browse:  " & nmTbl.ToString.Substring(1)
      Dim adakah_table As String = GetProc("select top 1 * from " & nmTbl.ToString)
      If adakah_table = "error" Then
         MsgBox("Data: " & nmTbl.ToString.Substring(1) & " Tidak ada")
         Exit Sub
      End If
      fd.Show()
      fd.WindowState = FormWindowState.Normal
   End Sub

   Private Sub fData_Load(sender As Object, e As EventArgs) Handles Me.Load
      GetPosisiForm(Me, nmTbl)
   End Sub
   Private Sub fData_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim HdKey As String = Application.ProductName & nmTbl.ToString
        If SibukLoad = False Then Exit Sub
        Spl.SplitterDistance = TkeyGet(HdKey & "Spl.SplitterDistance", Spl.SplitterDistance)
        KonekLagi()
        'CallDefSearch()
        'tSrch.Focus()
        SibukLoad = False

        TampilKeDetil()
    End Sub
    Private Sub fData_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim HdKey As String = Application.ProductName & nmTbl.ToString
        SetPosisiForm(Me, nmTbl)
        TkeySet(HdKey & "Spl.SplitterDistance", Spl.SplitterDistance)
    End Sub
    Sub KonekLagi(Optional RowA As Long = 1, Optional ColA As Long = 1)
        Loadx(lLoading, "Konek ...")
        If KonekConn() = True Then
            G.Tag = "sibuk" : G.Redraw = False
         Dim nmFields As String '= bnl_first.Field_KolumS(100)
         'If bnl_first.RJ_nmTbl.ToUpper Like "*BANGUNAN*" Then
         '       nmFields = nmFields.ToUpper.Replace(",FOTO", "")
         '   Else 'jika TJALAN
         nmFields = "*"
         '  End If
         GetRecGrid(G, "select " & nmFields & " from " & nmTbl) : GetGrd(G, Me, nmTbl)
            G.FrozenCols = 0
            Console.WriteLine(G.Rows)
            If RowA <= G.Rows - 1 Then G.Row = RowA
            If ColA <= G.Cols - 1 Then G.Col = ColA

            lCount.Text = G.Rows - 1 & " Siswa"
            gColFormat(G)

            G.Tag = ""
        Else
            MsgBox("not konek")
            Me.Dispose()
        End If

        G.Redraw = True
        Loadx(lLoading, , False)
    End Sub


   Sub TampilKeDetil() Handles G.RowColChange
      If SibukLoad Then Exit Sub
      If G.Tag = "sibuk" Then Exit Sub

      gE.ShowCellLabels = True
      Try : gE.Clear() : gE.Rows = G.Cols : Catch : End Try

      If G.Row = -1 Then Exit Sub
      For i As Integer = 0 To G.Cols - 1
         gE(i, 0) = G(0, i) 'judul
         gE(i, 1) = G(G.Row, i) 'isi
      Next
      G.set_ColAlignment(1, Classic.AlignmentSettings.flexAlignLeftCenter)
      lCount.Text = G.Row & " dari: " & FrMny(G.Rows - 1) & " " & nmTbl.Substring(1)
      'GetPosisiObj(gnSdw)

      Dim lbrCap As Integer = TkeyGet(Me.Name & "gE.ColWidth(0)", gE.get_ColWidth(0))
      Dim lbrIsi As Integer = TkeyGet(Me.Name & "gE.ColWidth(1)", gE.get_ColWidth(1))

      gE.set_ColWidth(0, lbrCap)
      gE.set_ColWidth(1, lbrIsi)
   End Sub
   Private Function GetImageFromByteArray(picData As Byte()) As Image
        If (picData) Is Nothing Then Return Nothing

        Dim bmData As Integer = If((picData(0) = 21 AndAlso picData(1) = 28), 78, 0)
        Dim img As Image = Nothing
        Try
            Dim ms As New System.IO.MemoryStream(picData, bmData, picData.Length - bmData)
            img = Image.FromStream(ms)
        Catch
        End Try
        Return img
    End Function
    Sub Loadx(ByRef lLoading As Label, Optional Ket As String = "", Optional Tampil As Boolean = True)
        If Tampil Then
            lLoading.Visible = True
            lLoading.Text = Ket
            Application.DoEvents()
        Else
            lLoading.Visible = False
        End If
    End Sub
    Private Sub btMax_Click(sender As Object, e As EventArgs) Handles btMax.Click
        Me.WindowState = IIf(Me.WindowState = FormWindowState.Normal, FormWindowState.Maximized, FormWindowState.Normal)
    End Sub
    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Me.Dispose()
    End Sub

   Private Sub fData_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        Me.MouseDown, Ljudul.MouseDown, Panel1.MouseDown, pnl_Cap_Data.MouseDown,
        l_detil.MouseDown, pnlCari.MouseDown, pnl_proses.MouseDown

      If (e.X > Me.Width - 22) And (e.Y > Me.Height - 22) Then
      Else : GeserForm(Me)
      End If
   End Sub

   Private Sub fData_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Exit Sub
        Static lpos As Point

        If e.Button = MouseButtons.Left Then ' resize form (but no less than 10x10 pixels)
            Dim newWidth As Integer = Math.Max(10, Me.Width + (e.X - lpos.X))
            Dim newHeight As Integer = Math.Max(10, Me.Height + (e.Y - lpos.Y))
            lpos = e.Location
            Me.Size = New Size(newWidth, newHeight)
            Application.DoEvents()
        Else
            lpos = e.Location
        End If
    End Sub

    Private Sub bt_Colapse_Click(sender As Object, e As EventArgs) Handles bt_Colapse.Click
        Spl.Panel1Collapsed = Not Spl.Panel1Collapsed
    End Sub




    Private Sub G_AfterResizeColumn(sender As Object, e As RowColEventArgs) Handles G.AfterResizeColumn
        SetGrd(G, Me, nmTbl)
    End Sub



    Private Sub G_MouseDown(sender As Object, e As MouseEventArgs) Handles G.MouseDown
      MosDownGrid(Me, G, nmTbl, sender, e)
   End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sender.backcolor = Color.OrangeRed

      Dim fSc As New fDaftarSearch
      Dim nId As String = fSc.Tampil(Me, G, nmTbl, "Id")

      If nId <> "" Then
         Dim Row_ID As Integer = G.FindRow(nId, 0, G.get_ColIndex("ID"), False, False)
         If Row_ID > 0 Then
                G.Redraw = Classic.RedrawSettings.flexRDNone
                G.Row = Row_ID : Application.DoEvents() ': Threading.Thread.Sleep(500)
                G.TopRow = G.Row
                G.Focus()
                G.Redraw = Classic.RedrawSettings.flexRDDirect
            End If
        Else
        End If
        sender.BackColor = Color.Cornsilk
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt_Print.Click
      'G.PrintGrid("stnd", PrintGridFlags.ShowPreviewDialog)
      'fNgeprint.Tampil(G, Me)
   End Sub

    Private Sub gE_MouseMove(sender As Object, e As MouseEventArgs) Handles gE.MouseMove
        If SibukLoad Then Exit Sub
        gE.FixedRows = IIf(e.Y < gE.get_RowHeight(0), 1, 0)
        gE.ShowCellLabels = IIf(e.Y < gE.get_RowHeight(0), False, True)
    End Sub
    Private Sub gE_AfterResizeColumn(sender As Object, e As RowColEventArgs) Handles gE.AfterResizeColumn
        TkeySet(Me.Name & "gE.ColWidth(0)", gE.get_ColWidth(0))
        TkeySet(Me.Name & "gE.ColWidth(1)", gE.get_ColWidth(1))
    End Sub

    Private Sub G_DoubleClick(sender As Object, e As EventArgs) Handles G.DoubleClick
        If G.MouseRow = 0 Then Exit Sub
        bt_Edit.PerformClick()
    End Sub

   Private Sub bt_Click(sender As Object, e As EventArgs) Handles _
      bt_Add.Click, bt_Edit.Click, bt_Del.Click
      Dim fu As New fUpdate : Dim jAry As New JArray

      Dim Add_Edit_Del As String = sender.name.ToString.Replace("bt_", "")

      If fu.Tampil(Me, G, sender.name.ToString.Replace("bt_", "")) = DialogResult.OK Then
         Dim jarr As Linq.JArray = Linq.JArray.Parse(fu.Tag.ToString)

         Dim nkol As String
         If jarr.ToString() = "[]" Then Exit Sub
         Dim JKol As Integer = G.Cols - 1

         If Add_Edit_Del = "Add" Then
            Dim fLd As String : Dim vLu As String
            fLd = "" : vLu = ""
            For i As Integer = 1 To JKol
               nkol = jarr.Item(i)
               fLd += IIf(i = 1, CrText(nkol, "=", 0), ", " & CrText(nkol, "=", 0))
               vLu += IIf(i = 1, CrText(nkol, "=", 1), ", " & CrText(nkol, "=", 1))
            Next i
            Dim sq As String = "Insert into " & nmTbl & " (" & fLd & ") values (" & vLu & ") "
            Console.WriteLine(sq)
            SetProc(sq)
         ElseIf Add_Edit_Del = "Edit" Then
            Dim sq As String = "update " & nmTbl & " set "
            For i As Integer = 0 To JKol
               nkol = jarr.Item(i)
               sq += IIf(i = 0, jarr.Item(0).ToString, ", " & jarr.Item(i).ToString)
            Next i
            sq += " where " & jarr.Item(0).ToString
            Console.WriteLine(sq)
            SetProc(sq)
         ElseIf Add_Edit_Del = "Del" Then
            If MsgBox("Apakah benar akan di hapus ?", vbOKCancel) = vbCancel Then Exit Sub
            Dim sq As String = "Delete " & nmTbl & " "
            sq += " where " & jarr.Item(0).ToString
            Console.WriteLine(sq)
            SetProc(sq)
         End If

         KonekLagi(G.Row, G.Col)
         TampilKeDetil()
      Else
         '     MsgBox("Cancel")
      End If
   End Sub

   Private Sub G_Click(sender As Object, e As EventArgs) Handles G.Click

   End Sub

   Private Sub gE_Click(sender As Object, e As EventArgs) Handles gE.Click

   End Sub
End Class