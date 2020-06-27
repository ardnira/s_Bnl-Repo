Imports System.Drawing.Printing
Public Class fBayar
   Dim nmTbl As String
   Dim ByrReturn As Double
   Const Cm As Integer = 567 / 15
   Dim SibukLoad As Boolean = True

   Function Tampil(ByRef HasilByr As Object, ByVal Tbl As String, ByVal G As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic, ByVal fm As Form, _
              Optional ByVal TlBiaya As Double = 0, Optional ByVal TlBayar As Double = 0, Optional ByVal TlTngLama As Double = 0) As DialogResult
      nmTbl = Tbl
      Klone(Gd, G)
      For i As Int16 = 1 To Gd.Rows - 1
         Gd.set_TextMatrix(i, G.get_ColIndex("Idbarang"), i)
      Next

      Dim CustSup As String
      CustSup = IIf(nmTbl = "tJual", "Customer", "Suplier")
      lCust.Text = G(1, G.get_ColIndex("Id" & CustSup)) & "   " & G(1, G.get_ColIndex("Nama" & CustSup))
      LkasirDate.Text = "Lukman, " & Format(Now, "dd MMM yyyy")
      LkasirDate.Tag = Format(Now, "dd MMM yyyy")
      Lref.Tag = G(1, G.get_ColIndex("Ref"))
      Lref.Text = "Ref: " & Lref.Tag

      GetGrd(Gd, Me, nmTbl)
      GetGrdJudul(Gd, Me)

      TtlBiaya.Tag = TlBiaya
      TngLama.Tag = TlTngLama
      tTunai.Tag = TlBayar
      ThrsByr.Tag = TlBiaya + TlTngLama

      TtlBiaya.Text = FrMny(TlBiaya)
      TngLama.Text = FrMny(TlTngLama)
      tTunai.Text = FrMny(TlBayar)
      ThrsByr.Text = FrMny(ThrsByr.Tag)

      srtNama.Text = lCust.Text

      Tampil = Me.ShowDialog(fm)
      If Me.DialogResult = Windows.Forms.DialogResult.OK Then
         HasilByr = ByrReturn
      End If

   End Function

   Private Sub fBayar_Load(sender As Object, e As EventArgs) Handles Me.Load
      Me.Width = Gd.Left + Gd.Width + Gd.Left + 10
   End Sub
   Private Sub fBayar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
      tTunai.Focus()

      If SibukLoad = False Then Exit Sub
      SibukLoad = False

      Loadx(lLoading, "Konek ...")
      tTunaiKeyUp()
      GetcProfile()
      lNamaUsaha.Text = Prf.dNamaUsaha
      lAlamat.Text = Prf.eAlamat
      lEmail.Text = Prf.gEmail
      lKontak.Text = Prf.fKontak
      TampilGambar(pLogo)

      If tTunai.Text <> "" Then CmdBayar.Text = "Update"
      Loadx(lLoading, , False)
   End Sub

   Private Sub fBayar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
      If BtnSuratJalan.Text = "< Srt Jalan" Then
         If e.KeyCode = Keys.Escape Then BtnSuratJalan.PerformClick()
         Exit Sub
      End If
      If e.KeyCode = Keys.Return Then CmdBayar.PerformClick()
      If e.KeyCode = Keys.Escape Then CmdCancel.PerformClick()
   End Sub


   Private Sub tTunai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tTunai.KeyPress
      Num(e)
   End Sub
   Private Sub tTunaiKeyUp() Handles tTunai.KeyUp
      TngNext.Tag = Val(ThrsByr.Tag) - Val(noMny(tTunai.Text))
      TngNext.Text = FrMny(TngNext.Tag)
      If (TngNext.Tag) < 0 Then
         lTangBaru.Text = "Kembali"
         lTangBaru.ForeColor = Color.Green
         TngNext.Text = FrMny(System.Math.Abs(Val(TngNext.Tag)))
      Else
         If (TngNext.Tag) = 0 Then
            lTangBaru.Text = "LUNAS"
         Else
            lTangBaru.Text = "Tnggungan Baru"
            lTangBaru.ForeColor = Color.Red
         End If
      End If

   End Sub




   Private Sub Gd_AfterResizeColumn(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles Gd.AfterResizeColumn
      SetGrd(Gd, Me, nmTbl)
      tTunai.Focus()
   End Sub

   Private Sub Gd_DoubleClick(sender As Object, e As EventArgs) Handles Gd.DoubleClick
      Dim Mr As Integer = Gd.MouseRow
      Dim Mc As Integer = Gd.MouseCol

      If Mr = 0 Then
         Dim newjudul As String = InputBox("Masukkan Judul Baru", "Ubah Judul", Gd(0, Mc))
         If newjudul <> "" Then Gd(0, Mc) = newjudul : SetGrdJudul(Gd, Me)

      End If
   End Sub

   Private Sub Gd_MouseDown(sender As Object, e As MouseEventArgs) Handles Gd.MouseDown
      If e.Button = Windows.Forms.MouseButtons.Right Then Dim fP As New FpopUp : fP.Tampil(Me, sender, nmTbl, Control.MousePosition) : Exit Sub

      If (sender.MouseRow <> 0) Then GeserForm(Me)
   End Sub

   Private Sub TextGotFocus(sender As Object, e As EventArgs) Handles _
      TtlBiaya.GotFocus, TtlBiaya.GotFocus, TngLama.GotFocus, ThrsByr.GotFocus, TngNext.GotFocus
      tTunai.Focus()
   End Sub


   Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
      Me.Dispose()
   End Sub





#Region "NGEPRINT ======================"
   Private Sub CmdBayar_Click(sender As Object, e As EventArgs) Handles CmdBayar.Click
      Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
      gProses.Visible = False
      pnlBayar.Dock = DockStyle.Right
      tTunai.Text = FrMny(tTunai.Text)
      tTunai.BorderStyle = BorderStyle.None
      Application.DoEvents()


      PrintStruk.DefaultPageSettings.PaperSize = New PaperSize("bnlStruk", 10.5 * Cm, 14.5 * Cm)
      PrintStruk.Print()
      Me.DialogResult = Windows.Forms.DialogResult.OK

      ByrReturn = noMny(tTunai.Text)
      Me.Dispose()
   End Sub
   Private Sub PrintStruk_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintStruk.PrintPage
      Dim tinggi As Integer = 2
      e.Graphics.DrawImage(pLogo.Image, pLogo.Location.X, pLogo.Location.Y, pLogo.Width, pLogo.Height)

      E_DrwLabel(e, lNamaUsaha, tinggi)
      E_DrwLabel(e, lAlamat, tinggi)
      E_DrwLabel(e, lEmail, tinggi)
      E_DrwLabel(e, lKontak, tinggi)

      E_DrwLabel(e, lCust, tinggi) : E_DrwLabel(e, LkasirDate, tinggi)
      E_DrwLabel(e, lGaris, tinggi)

      'judul=================
      E_DrwLabel(e, Lref, tinggi)
      tinggi = Gd.Top - 9 : Gd.Row = 0
      e.Graphics.DrawString(tSt("-", 100), New Drawing.Font("arial", 8, FontStyle.Bold), Brushes.Black, 2, tinggi)
      IsiGridRow(e, 0, Gd.Top + Gd.CellTop)
      'judul=================
      tinggi += 17 : e.Graphics.DrawString(tSt("-", 100), New Drawing.Font("arial", 8, FontStyle.Regular), Brushes.Black, 2, tinggi)

      'Detil=================
      For i As Integer = 1 To Gd.Rows - 1
         Gd.Row = i : IsiGridRow(e, i, Gd.Top + Gd.CellTop)
      Next
      'Detil=================
      tinggi = lll.Top + (lll.Height / 2) : e.Graphics.DrawString(tSt("-", 100), New Drawing.Font("arial", 8, FontStyle.Regular), Brushes.Black, 2, tinggi)

      'Footer=================
      tinggi += 10 : E_DrwLabel(e, lTotalBiaya, tinggi, tinggi) : setTttKanan(TtlBiaya) : E_DrwLabel(e, lll, tinggi, tinggi)     'total biaya
      tinggi += 15 : E_DrwLabel(e, lTanggunganLama, tinggi, tinggi) : setTttKanan(TngLama) : E_DrwLabel(e, lll, tinggi, tinggi)  'tanggungan lama
      tinggi += 10 : e.Graphics.DrawString("-------------------- +", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, lTanggunganLama.Left, tinggi) 'garis label total
      tinggi += 10 : setTttKanan(ThrsByr) : E_DrwLabel(e, lll, tinggi, tinggi)                                                   'harus bayar

      tinggi += 10 : e.Graphics.DrawString(tSt("-", 100), New Drawing.Font("arial", 8, FontStyle.Regular), Brushes.Black, 2, tinggi)

      tinggi += 10 : e.Graphics.DrawString("Tunai      : " & tTunai.Text, New Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, 2, tinggi)
      tinggi += 15 : e.Graphics.DrawString("Tngg. Baru : " & TngNext.Text, New Drawing.Font("Courier New", 9, FontStyle.Regular), Brushes.Black, 2, tinggi)
      'Footer=================

      tinggi += 20 : e.Graphics.DrawString("Terima Kasih ****** ", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 2, tinggi)
   End Sub
   Sub IsiGridRow(e As PrintPageEventArgs, ByVal brs As Integer, ByRef y As Single)
      For i As Integer = 0 To Gd.Cols - 1
         If Gd.get_ColWidth(i) > 10 Then

            lll_ke_Grid(brs, i)
            E_DrwLabel(e, lll, y)
         End If
      Next
   End Sub
   Sub E_DrwLabel(e As PrintPageEventArgs, ByVal tX As Label, ByRef TinggiDef As Integer, Optional YdiUbah As Integer = 0)
      Dim TinggiY As Integer = IIf(YdiUbah > 0, YdiUbah, tX.Location.Y)
      TinggiDef = TinggiY
      e.Graphics.DrawString(tX.Text, New Drawing.Font(tX.Font.Name, tX.Font.Size, FontStyle.Regular), Brushes.Black, tX.Location.X, TinggiY)
   End Sub

   Sub lll_ke_Grid(ByVal Row As Integer, ByVal Col As Integer)
      Gd.Row = Row : Gd.Col = Col
      Dim PosX As Integer = Gd.Location.X + Gd.CellLeft
      Dim PosY As Integer = Gd.Location.Y + Gd.CellTop
      Dim PosLbr As Integer = Gd.get_ColWidth(Col)
      Dim PosKnn As Integer = PosX + PosLbr

      lll.Text = Gd(Row, Col) : lll.Font = Gd.Font
      lll.AutoSize = False : lll.Width = PosLbr : lll.Location = New Point(PosX, PosY) : Application.DoEvents()

      Try
         If IsNumeric(lll.Text.Substring(0, 1)) Then
            lll.TextAlign = ContentAlignment.TopRight : lll.AutoSize = True : Application.DoEvents()
         Else
            lll.TextAlign = ContentAlignment.MiddleLeft
         End If

      Catch
         lll.TextAlign = ContentAlignment.MiddleLeft
      End Try


      lll.Location = New Point(PosKnn - lll.Width, PosY)
   End Sub



   Sub setLllKanan(ByVal Lbl As Label)
      lll.Font = Lbl.Font
      lll.AutoSize = False : Application.DoEvents()
      lll.Text = Lbl.Text
      lll.TextAlign = ContentAlignment.MiddleRight
      lll.Width = Lbl.Width : Application.DoEvents()
      lll.Location = New Point(Lbl.Location)
      Dim Lknn As Integer = lll.Location.X + lll.Width
      lll.AutoSize = True : Application.DoEvents()
      lll.Location = New Point(Lknn - lll.Width, lll.Location.Y)
   End Sub
   Sub setTttKanan(ByVal Lbl As TextBox)
      lll.Font = Lbl.Font
      lll.AutoSize = False : Application.DoEvents()
      lll.Text = Lbl.Text
      lll.TextAlign = ContentAlignment.MiddleRight
      lll.Width = Lbl.Width : Application.DoEvents()
      lll.Location = New Point(Lbl.Location)
      Dim Lknn As Integer = lll.Location.X + lll.Width
      lll.AutoSize = True : Application.DoEvents()
      lll.Location = New Point(Lknn - lll.Width, lll.Location.Y)
   End Sub
#End Region ' "NGEPRINT ======================"








   Private Sub BtnSuratJalan_Click(sender As Object, e As EventArgs) Handles BtnSuratJalan.Click
      If Me.Width <= Gd.Left + Gd.Width + Gd.Left + 10 Then
         Me.Width = gSuratJalan.Left + gSuratJalan.Width + 30
         BtnSuratJalan.Text = "< Srt Jalan"
         PnlBawah.Visible = False
      Else
         BtnCancelSrtJ_Click()
      End If
   End Sub


   Private Sub BtnCancelSrtJ_Click() Handles BtnCancelSrtJ.Click
      Me.Width = Gd.Left + Gd.Width + Gd.Left + 10
      BtnSuratJalan.Text = "Srt Jalan >"
      PnlBawah.Visible = True
   End Sub


   Private Sub BtnSrtJ_Click(sender As Object, e As EventArgs) Handles BtnSrtJ.Click
      Dim Isi As String = "Insert Into tSuratJalan  " & vbCrLf & "values (dbo.newIdSrtJ(), " & vbCrLf

      Isi = Isi & "'" & Lref.Tag & "', "
      Isi = Isi & "'" & dtTanggal.Value & "', "
      Isi = Isi & "'" & srtNama.Text & "', "
      Isi = Isi & "'" & srtTelp.Text & "', "
      Isi = Isi & "'" & srtAlamat.Text & "', "
      Isi = Isi & "'" & srtKet.Text & "'  "
      Isi = Isi & ") "
      SetProc(Isi)

      PrintSrtJ.DefaultPageSettings.PaperSize = New PaperSize("bnlStruk", 25 * Cm, 14.5 * Cm)
      PrintSrtJ.Print()
   End Sub

#Region "Ngeprint Surat Jalan"
   Private Sub PrintSrtJ_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintSrtJ.PrintPage
      Dim tinggi As Integer = 2
      e.Graphics.DrawImage(pLogo.Image, pLogo.Location.X, pLogo.Location.Y, pLogo.Width, pLogo.Height)

      E_DrwLabel(e, lNamaUsaha, tinggi)
      E_DrwLabel(e, lAlamat, tinggi)
      e.Graphics.DrawString("SURAT JALAN", New Drawing.Font("calibri", 22, FontStyle.Bold), Brushes.Black, 500, lAlamat.Top)
      E_DrwLabel(e, lEmail, tinggi)
      E_DrwLabel(e, lKontak, tinggi)

      e.Graphics.DrawString(LkasirDate.Tag, New Drawing.Font("Calibri", 8, FontStyle.Regular), Brushes.Black, 666, 85)

      tinggi = 85 : e.Graphics.DrawString("Kepada Yth.", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, lNamaUsaha.Left, tinggi)
      tinggi += 13 : e.Graphics.DrawString("Nama: " & lCust.Text, New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, lNamaUsaha.Left, tinggi)
      tinggi += 13 : e.Graphics.DrawString("Telp: ", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, lNamaUsaha.Left, tinggi)
      tinggi += 13 : e.Graphics.DrawString("Alamat: ", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, lNamaUsaha.Left, tinggi)
      e.Graphics.DrawString(Lref.Text, New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 666, tinggi)

      e.Graphics.DrawLine(Pens.Black, lNamaUsaha.Left, pLogo.Top + pLogo.Height, 780, pLogo.Top + pLogo.Height)
      e.Graphics.DrawLine(Pens.Black, lNamaUsaha.Left, pLogo.Top + pLogo.Height + 3, 780, pLogo.Top + pLogo.Height + 3)


      Dim R = New Rectangle(2, 140, 780, 200)
      e.Graphics.DrawRectangle(Pens.Black, R)
      e.Graphics.DrawString("Keterangan", New Drawing.Font("Calibri", 8, FontStyle.Regular), Brushes.Black, 300, 142)
      e.Graphics.DrawLine(Pens.Black, 2, 160, 780, 160) ' horizontal judul tabel

      e.Graphics.DrawLine(Pens.Black, 293, 140, 293, 340) 'vertikal kotak atas


      Dim R2 = New Rectangle(2, 345, 780, 60)
      e.Graphics.DrawRectangle(Pens.Black, R2)
      e.Graphics.DrawLine(Pens.Black, 293, 345, 293, 405) 'vertikal kotak bawah

      IsiGridSrt(e, 0, Gd.Top + Gd.CellTop)
      'Detil=================
      Gd.Redraw = C1.Win.C1FlexGrid.Classic.RedrawSettings.flexRDNone

      For i As Integer = 1 To Gd.Rows - 1
         Gd.Row = i : IsiGridSrt(e, i, Gd.Top + Gd.CellTop)
      Next
      'Detil=================

      'Keterangan=================
      tinggi = Gd.Top + 40
      For i As Integer = 0 To 17
         If i > srtKet.Lines.Count - 1 Then Exit For
         tinggi += 10 : e.Graphics.DrawString(srtKet.Lines(i).ToString, New Drawing.Font("Calibri", 8, FontStyle.Regular), Brushes.Black, 300, tinggi)
      Next
      'Keterangan=================

      tinggi = 347 : e.Graphics.DrawString("Catatan: ", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 5, tinggi)
      tinggi = 348 : e.Graphics.DrawString("Perhatian: ", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 300, tinggi)
      tinggi += 13 : e.Graphics.DrawString("1. Surat Jalan Ini Merupakan Bukti Resmi Penerimaan Barang ", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 300, tinggi)
      tinggi += 13 : e.Graphics.DrawString("2. Surat Jalan Ini Bukan Bukti Penjualan", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 300, tinggi)
      tinggi += 13 : e.Graphics.DrawString("3. Surat Jalan Ini Akan Di Lengkapi Invoice Sebagai Bukti Penjulan", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 300, tinggi)

      tinggi += 20 : e.Graphics.DrawString("BARANG SUDAH DI TERIMA DALAM KEADAAN BAIK DAN CUKUP oleh:", New Drawing.Font("Courier New", 8, FontStyle.Italic), Brushes.Black, 2, tinggi)
      tinggi += 10 : e.Graphics.DrawString("(tanda tangan dan cap (stempel) perusahaan)", New Drawing.Font("Courier New", 8, FontStyle.Italic), Brushes.Black, 2, tinggi)

      tinggi += 30 : e.Graphics.DrawString(" Tanda Tangan Sipenerima ", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 130, tinggi)
      e.Graphics.DrawString("     Hormat Kami    ", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 555, tinggi)

      tinggi += 40 : e.Graphics.DrawString("__________________________", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 130, tinggi)
      e.Graphics.DrawString("______________________", New Drawing.Font("Courier New", 8, FontStyle.Regular), Brushes.Black, 555, tinggi)

   End Sub

   Sub IsiGridSrt(e As PrintPageEventArgs, ByVal brs As Integer, ByRef y As Single)
      For i As Integer = 0 To Gd.Cols - 1
         If Gd.get_ColWidth(i) > 10 Then
            If Trim(Gd(0, i)) = "NamaBarang" Or Trim(Gd(0, i)) = "Jml" Then
               lll_ke_Grid(brs, i)

               lll.Top = lll.Top + 35
               E_DrwLabel(e, lll, y)
            End If
         End If
      Next
   End Sub
#End Region
    

End Class