
Imports C1.Win.C1FlexGrid

Public Class Bnl_First


   Private Sub First_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      fServer.TampilAwal_saja()
      Me.Text = Prf.dNamaUsaha
      Application.DoEvents()
      l_Akses.Text = ""
      GetcProfile()
      create_menu_Report()
   End Sub
   Private Sub First_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
      Spls.Dispose()
      fServer.Dispose()
      TryKonek_DuaDatabase()
      lAldir.Text = AppPath & Application.ProductName.ToString & ".exe"
      l_Proc.Focus()
      btListBarang_Click(btListBarang, e)
      Application.DoEvents()
      l_Proc.Text = "BeNLa System"
   End Sub

   Private Sub BtMin_Click(sender As Object, e As EventArgs) Handles btMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtMax_Click(sender As Object, e As EventArgs) Handles btMax.Click
        Me.WindowState = IIf(Me.WindowState = FormWindowState.Maximized, FormWindowState.Normal, FormWindowState.Maximized)
        btMax.Image = IIf(Me.WindowState = FormWindowState.Maximized, img_list.Images.Item(1), img_list.Images.Item(0))
        btPeriode.Focus()
    End Sub





   Sub TryKonek_DuaDatabase()
        Lconnect_1.ForeColor = Color.Red
        Lconnect_2.ForeColor = Color.Red

        Lconnect_1.Text = "Try Connect 1 ...   "
        Lconnect_2.Text = "Try Connect 2 ...   "
        Application.DoEvents()

      If KonekConn(False) = False Then
         Application.DoEvents()
         Lconnect_1.Text = "Disconnect" : Lconnect_1.ForeColor = Color.Red
      Else
         Lconnect_1.Text = Lconnect_1.Tag.ToString & "  Connect...     "
         Lconnect_1.ForeColor = Color.DarkOrange
      End If
   End Sub







    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

   Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
      If l_Akses.Text.ToUpper = "FULL" Or l_Akses.Text Like "*SetServer*" Then
         'fServer.Show()
      Else
         MsgBox("Anda Tidak Berhak, Silahkan Login Admin", vbCritical) : Exit Sub
      End If
   End Sub

   Private Sub mDt_Data_Click(sender As Object, e As EventArgs) Handles _
      smData_Barang.Click, smData_Suplier.Click, smData_Customer.Click, smData_User.Click
      Dim fd As New fData
      fd.Tampil(sender, fd)
   End Sub


   Private Sub Pnl_Atas_MouseDown(sender As Object, e As MouseEventArgs) Handles _
          Pnl_Atas.MouseDown, Pnl_Pojok_Atas.MouseDown, l_Proc.MouseDown
      GeserForm(Me)
   End Sub
   Private Sub spl_kiri_DoubleClick(sender As Object, e As EventArgs) Handles _
             Pnl_Atas.DoubleClick, Pnl_Pojok_Atas.DoubleClick
      BtMax_Click(sender, e)
   End Sub

   Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tsVersion.Click
      MsgBox("SPR, Versi " & tsVersion.Text)
   End Sub

   Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
      Me.Dispose()
   End Sub

   Private Sub First_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
      '  FullKeyDown(e)
      'If e.Control And e.KeyCode = Keys.X Then End
      If e.Control And e.KeyCode = Keys.F12 Then
         lAldir.Visible = Not lAldir.Visible
         If lAldir.Visible Then
            Clipboard.SetText(lAldir.Text)
         Else
            Clipboard.Clear()
         End If
      End If
   End Sub

   Private Sub btUtama_Click(sender As Object, e As EventArgs) Handles btUtama.Click
      Static lbr_def As Integer = IIf(lbr_def = 0, spl_kiri.Width, lbr_def)
      spl_kiri.Width = IIf(lbr_def = spl_kiri.Width, btUtama.Width, lbr_def)
   End Sub


   Public Sub bt_Data_Click(sender As Object, e As EventArgs)
      pnl_Cap_Data.Tag = sender.name.ToString

      Loadx(lLoading, pnl_Cap_Data.Tag & ", Konek ...")
      If sender.enabled = True Then
         Dim adakah_table As String = GetProc("select top 1 * from " & "t" & sender.name.ToString.Substring(8))
         If adakah_table = "error" Then
            If sender.enabled = True Then MsgBox("Under Construction")
            sender.enabled = False : Exit Sub
         End If
      End If

      '   lData_Map.Text = "Link Map: " & sender.name.ToString.Substring(3)
      ' lData_Map.Focus()
   End Sub

   Sub Loadx(ByRef lLoading As Label, Optional Ket As String = "", Optional Tampil As Boolean = True)
      If Tampil Then
         lLoading.Visible = True
         lLoading.Text = Ket
         Application.DoEvents()
      Else
         lLoading.Visible = False
      End If
   End Sub

   Public G_jln As New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
   Public G_bng As New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

   Function Field_KolumS(jml_Kol As Integer) As String
      Dim nmColumn As String = "SELECT * FROM ( SELECT TOP 99999  COLUMN_NAME  FROM INFORMATION_SCHEMA.COLUMNS  WHERE TABLE_NAME = ' '  "
      nmColumn += " AND ORDINAL_POSITION < " & jml_Kol & "  "
      nmColumn += " ORDER BY ORDINAL_POSITION ASC "
      nmColumn += " ) AS tempT  "
      nmColumn = GetProc(nmColumn).ToString().Replace("|", ",")
      Return nmColumn
   End Function



   Private Sub G_AfterResizeColumn(sender As Object, e As RowColEventArgs)
      SetGrd(sender, Me)
   End Sub




   Private Sub G_MouseLeave(sender As Object, e As EventArgs)
      G.ForeColorFixed = Color.White
   End Sub

   Private Sub G_MouseEnter(sender As Object, e As EventArgs)
      G.ForeColorFixed = Color.White
   End Sub


   'Private Sub l_Proc_MouseHover(sender As Object, e As EventArgs) Handles l_Proc.MouseHover
   '    l_Proc.ForeColor = Color.DarkGray
   'End Sub

   'Private Sub l_Proc_MouseLeave(sender As Object, e As EventArgs) Handles l_Proc.MouseLeave
   '    l_Proc.ForeColor = Color.Yellow
   'End Sub



   Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked
      ' Console.WriteLine(e.ClickedItem.Name)
      ' Console.WriteLine(sender.ToString)
      'If e.ClickedItem.Name = "tsReport" Then Exit Sub
   End Sub

   Private Sub tsReport_Click(sender As Object, e As EventArgs)
      Console.WriteLine(e.ToString)
      Console.WriteLine(sender.ToString)
   End Sub



   Sub create_menu_Report()
      tsReport.DropDownItems.Clear()
      tsReport.DropDownItems.Add("Data Jalan") ': tsReport.DropDownItems.Item(tsReport.DropDownItems.Count - 1).Enabled = False
      tsReport.DropDownItems.Add("Dd1 To Excel") : tsReport.DropDownItems.Item(tsReport.DropDownItems.Count - 1).Enabled = False
      tsReport.DropDownItems.Add(New ToolStripSeparator)
      tsReport.DropDownItems.Add("Dd1")
      smData_Rumah.Enabled = True
      smKondisi_Rumah.Enabled = True
   End Sub

   Sub Set_Menu_report_Probolinggo()
      tsReport.DropDownItems.Clear()
      tsReport.DropDownItems.Add("Set Kriteria Kumuh")

      Dim Dt As New Data.DataTable
      Dt = GetDt("Select * from tKriteria_Kumuh where not(isi_komponen is null or isi_komponen='') ")
      If IsNothing(Dt) Then Exit Sub
      For Each row As DataRow In Dt.Rows
         'Console.WriteLine(row.Field(Of Integer)(0))
         tsReport.DropDownItems.Add("  >" & row.Field(Of String)(1))
         tsReport.DropDownItems.Item(tsReport.DropDownItems.Count - 1).Tag = row.Field(Of String)("Isi_Komponen")
      Next
      tsReport.DropDownItems.Add(New ToolStripSeparator)
      tsReport.DropDownItems.Add("Data Jalan")
      tsReport.DropDownItems.Add("Data Bangunan")
      tsReport.DropDownItems.Add(New ToolStripSeparator)
      tsReport.DropDownItems.Add("Dd1")
      smData_Rumah.Enabled = True
      smKondisi_Rumah.Enabled = True
   End Sub
   Private Sub tsReport_Click_1(sender As Object, e As EventArgs) Handles tsReport.Click
      'If Nm_app_this.ToUpper Like "*PROBOLINGGO*" Then '<- DI GANTI PROBOLINGGO
      '    Application.DoEvents()
      '    Set_Menu_report_Probolinggo()
      'End If
   End Sub
   Private Sub tsKonfigurasi_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsData.DropDownItemClicked
      Select Case e.ClickedItem.Text
         Case "Set Kriteria Kumuh"
         Case "Data Jalan"
         Case "Data Bangunan"
      End Select
   End Sub
   Private Sub tsReport_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsReport.DropDownItemClicked
      Select Case e.ClickedItem.Text
         Case "Set Kriteria Kumuh"
            If l_Akses.Text.ToUpper = "FULL" Or l_Akses.Text Like "*SetKriteria*" Then
               SetProc("update tLink_Vb6 set fParent='panggil_filter_lanjutan'") : Exit Sub
            Else
               MsgBox("Anda Tidak Berhak, Silahkan Login Admin", vbCritical) : Exit Sub
            End If
         Case "Data Jalan" ' fReport_Jalan.Show(Me)
         Case "Data Bangunan" ' fReport_Rumah.Show()
         Case "Dd1"
            Dim Fd 'As New fDd1_toExcel

            Fd.TopMost = True
            Fd.TopLevel = True
            Fd.Show()
         Case "Data s" : MsgBox("dgsdfgf")
      End Select

   End Sub

   Private Sub tsHelp_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsHelp.DropDownItemClicked
      Select Case e.ClickedItem.Text
         Case "Help"  'fHelp.Show()
         Case "About" : Dim fSplsh As New Spls : fSplsh.Tag = "about" : fSplsh.Show()
         Case "Data s" : MsgBox("dgsdfgf")
      End Select
   End Sub



   Private Sub btPeriode_Click(sender As Object, e As EventArgs) Handles btPeriode.Click
      fLogin.Tampil()
   End Sub

   Private Sub mBackupRestore_Click(sender As Object, e As EventArgs) Handles mBackupRestore.Click
      If l_Akses.Text.ToUpper = "FULL" Or l_Akses.Text Like "*BackUpRestore*" Then
         '
      Else
         MsgBox("Anda Tidak Berhak, Silahkan Login Admin", vbCritical) : Exit Sub
      End If
   End Sub


   Private Sub l_LogOff_Click(sender As Object, e As EventArgs) Handles l_LogOff.Click
      btPeriode.Text = "Publik"
      l_Akses.Text = ""
   End Sub

   Private Sub btPeriode_TextChanged(sender As Object, e As EventArgs) Handles btPeriode.TextChanged
      l_LogOff.Visible = (btPeriode.Text <> "Publik")
   End Sub

   Private Sub pctExpand_Click(sender As Object, e As EventArgs) Handles pctExpand.Click
      Dim rrimg As Image
      rrimg = pctExpand.BackgroundImage
      pctExpand.BackgroundImage = pctExpand.ErrorImage
      pctExpand.ErrorImage = rrimg
      'spl_kiri.Width = IIf(spl_kiri.Width > 37, 37, 150)
   End Sub

   Private Sub btListBarang_Click(sender As Object, e As EventArgs) Handles btListBarang.Click, btListSuplier.Click, btListCustomer.Click
      Dim nmTable As String = sender.name.ToString.Replace("btList", "")

      If G(0, 1) = nmTable Then 'berarti double klik
         'smData_Barang.Click, smData_Suplier.Click, smData_Customer.Click, smData_User.Click
         If nmTable.Contains("Barang") Then mDt_Data_Click(smData_Barang, e)
         If nmTable.Contains("Customer") Then mDt_Data_Click(smData_Customer, e)
         If nmTable.Contains("Suplier") Then mDt_Data_Click(smData_Suplier, e)
         Exit Sub
      End If

      GetRecGrid(G, "select id, Nama" & nmTable & " From t" & nmTable & "")
      G.set_RowHeight(0, 40)

      Dim fn As Font = New Font(Font.FontFamily, 14)
      G.set_Cell(Classic.CellPropertySettings.flexcpFont, 0, 1, fn)
      G.set_ColWidth(0, 30) : G.set_ColWidth(1, G.Width - 45)
      lCount.Text = G.Rows - 1 & " " & nmTable
      G(0, 0) = "" : G(0, 1) = nmTable
      pnl_Cap_Data.BackgroundImage = sender.Image

      dot.Location = New Point(dot.Location.X, sender.location.y + 8) : dot.Tag = nmTable
   End Sub


   Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
      Dim fSc As New fDaftarSearch
      Dim nId As String = fSc.Tampil(Me, G, "t" & G(0, 1).ToString(), "Id")

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
   End Sub

   Private Sub Bnl_First_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
      fStart.Dispose()
   End Sub

   Private Sub trs_SaldoKas_Click(sender As Object, e As EventArgs) Handles trs_SaldoKas.Click, trs_HutPiu.Click ', trs_HutCust.Click
      Dim Fd As New fHarta
      If vMdi = True Then Fd.MdiParent = Me
      'SetIconBigSmall(Fd, e)
      Fd.Tampil(sender.tag.ToString())
   End Sub
   Private Sub trs_HutCust_Click(sender As Object, e As EventArgs) Handles trs_HutCust.Click
      Dim Fd As New fHutCus
      If vMdi = True Then Fd.MdiParent = Me
      'SetIconBigSmall(Fd, e)
      Fd.Tampil(sender.tag.ToString())
   End Sub

   Private Sub tstsMenu_DropDownOpening(sender As Object, e As EventArgs) Handles _
     tsVersion.DropDownOpening, tsFile.DropDownOpening, tsData.DropDownOpening, tsTransaksi.DropDownOpening, tsReport.DropDownOpening
      sender.ForeColor = Color.Red
      sender.font = New Font(tsFile.Font.Name, tsFile.Font.Size, FontStyle.Bold)
   End Sub

   Private Sub tstsMenu_DropDownClosed(sender As Object, e As EventArgs) Handles _
     tsVersion.DropDownClosed, tsFile.DropDownClosed, tsData.DropDownClosed, tsTransaksi.DropDownClosed, tsReport.DropDownClosed
      sender.ForeColor = Color.White
      sender.font = New Font(tsFile.Font.Name, tsFile.Font.Size, FontStyle.Regular)
   End Sub

   Private Sub tsMenu_MouseHover(sender As Object, e As EventArgs) Handles _
     tsVersion.MouseHover, tsFile.MouseHover, tsData.MouseHover, tsTransaksi.MouseHover, tsTransaksi.MouseHover, tsReport.MouseHover, tsHelp.MouseHover
      sender.ForeColor = Color.RosyBrown
      sender.font = New Font(tsFile.Font.Name, tsFile.Font.Size, FontStyle.Bold)
   End Sub
   Private Sub tstsMenu_MouseLeave(sender As Object, e As EventArgs) Handles _
     tsVersion.MouseLeave, tsFile.MouseLeave, tsData.MouseLeave, tsTransaksi.MouseLeave, tsTransaksi.MouseLeave, tsReport.MouseLeave, tsHelp.MouseLeave
      sender.ForeColor = Color.White
      sender.font = New Font(tsFile.Font.Name, tsFile.Font.Size, FontStyle.Regular)
   End Sub

   Private Sub G_DoubleClick(sender As Object, e As EventArgs) Handles G.DoubleClick
      btSearch_Click(sender, e)
   End Sub

   Private Sub trs_Pembelian_Click(sender As Object, e As EventArgs) Handles trs_Pembelian.Click
      Dim Fd As New Transaksi
      '   If vMdi = True Then Fd.MdiParent = Me
      '   SetIconBigSmall(Fd, e)
      Fd.Tampil("tBeli")
   End Sub
   Private Sub trs_Penjualan_Click(sender As Object, e As EventArgs) Handles trs_Penjualan.Click
      Dim Fd As New Transaksi
      '   If vMdi = True Then Fd.MdiParent = Me
      'SetIconBigSmall(Fd, e)
      Fd.Tampil("tJual")
   End Sub

   Private Sub btList_MouseHover(sender As Object, e As EventArgs) Handles _
      btListSuplier.MouseHover, btListBarang.MouseHover, btListCustomer.MouseHover
      Dim nmTable As String = sender.name.ToString.Replace("btList", "")
      If dot.Tag <> nmTable Then Exit Sub
      dot.BackColor = btListSuplier.FlatAppearance.MouseOverBackColor
   End Sub
   Private Sub btList_Mouselost(sender As Object, e As EventArgs) Handles _
      btListSuplier.MouseLeave, btListBarang.MouseLeave, btListCustomer.MouseLeave
      Dim nmTable As String = sender.name.ToString.Replace("btList", "")
      If dot.Tag <> nmTable Then Exit Sub
      dot.BackColor = sender.backcolor
   End Sub

   Private Sub btSearch_MouseEnter(sender As Object, e As EventArgs) Handles btSearch.MouseEnter
      Dim data_apa As String = G(0, 1).ToString()
      tlp.SetToolTip(btSearch, "Data " & data_apa)
   End Sub

   Private Sub btListPembelian_Click(sender As Object, e As EventArgs) Handles btListPembelian.Click
      trs_Pembelian.PerformClick()
   End Sub
   Private Sub btListPenjualan_Click(sender As Object, e As EventArgs) Handles btListPenjualan.Click
      trs_Penjualan.PerformClick()
   End Sub
   Private Sub btListKas_Click(sender As Object, e As EventArgs) Handles btListKas.Click
      trs_SaldoKas.PerformClick()
   End Sub

   Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      fPrint_Bayar.Show()
      ' fd_Form.Show()
   End Sub

   'trs_SaldoKas.Click, trs_HutPiu.Click
End Class
