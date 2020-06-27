Public Class Transaksi
   Dim nmTbl As String = ""
   Dim SibukLoad As Boolean = True
   Dim Rawl As Integer

   Sub Tampil(ByVal Tbl As String)
      nmTbl = Tbl
      If vMdi = True Then Me.Show() Else Me.Show(Bnl_First)

      KonekLagi()

      Try
         Debug.Print(G(G.Row, "Ref"))
      Catch ex As Exception
         Exit Sub
      End Try
      TampilDetail(G(G.Row, "Ref"))

      If UCase(nmTbl) = "TBELI" Then
         lHeader.Text = "P E M B E L I A N"
         splUtama.Tag = "P E M B E L I A N"

         lCodeCS.Text = "Suplier Code :"
         lNamaCS.Text = "Suplier Name :"
         pnl_Cap_Data.BackgroundImage = Bnl_First.trs_Pembelian.Image
         pnl_Cap_Data.BackColor = Color.DarkGreen
         lHeader.BackColor = Color.DarkGreen

         G.Styles.Highlight.BackColor = Color.DarkGreen
         G.Styles.Fixed.BackColor = Color.Yellow

      Else
         lHeader.Text = "P E N J U A L A N"
         splUtama.Tag = "P E N J U A L A N"

         lCodeCS.Text = "Customer Code :"
         lNamaCS.Text = "Customer Name :"
         pnl_Cap_Data.BackgroundImage = Bnl_First.trs_Penjualan.Image
         pnl_Cap_Data.BackColor = Color.DarkRed
         lHeader.BackColor = Color.DarkRed

         G.Styles.Highlight.BackColor = Color.DarkRed
         G.Styles.Fixed.BackColor = Color.Pink
      End If
      ' Transaksi_Resize()

   End Sub

   Sub KonekLagi(Optional RowA As Long = 0, Optional ColA As Long = 0)
      SplUtama.Text = "Loading ..." : Application.DoEvents()
      If KonekConn() = True Then
         G.Tag = "sibuk"

         G.Redraw = False
         Dim SqJson As String = ""
         SqJson = SqJson & ",dbo.FlattenedJSON( "
         'SqJson = SqJson & "(SELECT top 20 Ref,idBarang,NamaBarang,Jumlah,Harga "
         SqJson = SqJson & "(SELECT top 20 * "
         SqJson = SqJson & "FROM " & IIf(UCase(nmTbl) = "TBELI", "tPembelian", "tPenjualan") & " AS p "
         SqJson = SqJson & "WHERE p.Ref = tB.ref "
         SqJson = SqJson & "FOR XML path, root) "
         SqJson = SqJson & ")  as JsonDetil "

         Dim sqDanJson As String = "select * " & SqJson & " from " & nmTbl & " as Tb  order By tanggal desc"
         Console.WriteLine(sqDanJson)

         GetRecGrid(G, sqDanJson)
         GetGrd(G, Me, nmTbl)
         If RowA <= G.Rows.Count - 1 Then G.Row = RowA
         If ColA <= G.Cols.Count - 1 Then G.Col = ColA
         If RowA = 99999 Then G.Row = G.Rows.Count - 1

         gColFormat(G)

         G.Tag = ""
      Else
         MsgBox("not konek")
         Me.Dispose()
      End If
      G.Redraw = True
      'lJudul.Text = splUtama.Tag : Application.DoEvents()
   End Sub


   Sub Proses(ByVal prs As String)
      Dim Fe ' As New fEditHtrans
      If prs = "Add" And G.Row = -1 Then G.Row = 0
      If Fe.Tampil(prs, G, nmTbl, Me) = Windows.Forms.DialogResult.OK Then
         'Dim RowA As Long = IIf(prs = "Add", 99999, G.Row) 'awal sebelum record new ada di awal
         Dim RowA As Long = IIf(prs = "Add", 1, G.Row) ' ini record NEW di letakkan di awal

         KonekLagi(RowA, G.Col)
         TampilHeader()
         TampilDetail(G(G.Row, "Ref"))
      End If
   End Sub

   Private Sub G_GotFocus(sender As Object, e As EventArgs) Handles G.GotFocus
      If G.Row <= 0 Then Exit Sub
      If tRef.Text = G(G.Row, "Ref").ToString Then Exit Sub
      Dim RowRef As Integer = G.FindRow(tRef, 1, G.Cols("Ref").Index, True)
      Application.DoEvents()
      G.Row = RowRef
      'If UCase(nmTbl) = "TBELI" Then
      '   G.Styles.Highlight.BackColor = Color.DarkGreen
      '   G.Styles.Fixed.BackColor = Color.Yellow
      'Else
      '   G.Styles.Highlight.BackColor = Color.DarkRed
      '   G.Styles.Fixed.BackColor = Color.Pink
      'End If
   End Sub
   Private Sub G_LostFocus(sender As Object, e As EventArgs) Handles G.LostFocus
      If G.Row <= 0 Then Exit Sub
      Dim xr As Long = G.FindRow(tRef.Text, 0, G.Cols("ref").Index, True)
      If xr >= -1 Then G.Row = xr

      'If UCase(nmTbl) = "TBELI" Then
      '   G.Styles.Highlight.BackColor = Color.DarkGreen
      '   G.Styles.Fixed.BackColor = Color.Yellow
      'Else
      '   G.Styles.Highlight.BackColor = Color.DarkRed
      '   G.Styles.Fixed.BackColor = Color.Pink
      'End If
   End Sub
   Private Sub G_DoubleClick(sender As Object, e As EventArgs) Handles G.DoubleClick
      If G.Row <= 0 Then Exit Sub
      If G.Tag <> "sibuk" Then
         Console.WriteLine(G(G.Row, "JsonDetil"))
         Gd.Redraw = C1.Win.C1FlexGrid.Classic.RedrawSettings.flexRDNone
         TampilHeader()
         TampilDetail(G(G.Row, "Ref"))
         Gd.Redraw = C1.Win.C1FlexGrid.Classic.RedrawSettings.flexRDDirect
      End If
      'Proses("Edit")


      Dim i As Integer
      With G
         Dim NewStyle1 As C1.Win.C1FlexGrid.CellStyle

         For i = 0 To .Cols.Count - 1
            NewStyle1 = .Styles.Add("NewStyle1")
            NewStyle1.BackColor = System.Drawing.Color.White
            .SetCellStyle(Rawl, i, NewStyle1)
         Next i


         Dim NewStyle2 As C1.Win.C1FlexGrid.CellStyle

         For i = 0 To .Cols.Count - 1
            NewStyle2 = .Styles.Add("NewStyle2")
            If nmTbl = "tJual" Then
               NewStyle2.BackColor = System.Drawing.Color.FromArgb(255, 255, 109, 0)
            Else
               NewStyle2.BackColor = System.Drawing.Color.FromArgb(255, 34, 200, 30)
            End If

            .SetCellStyle(.Row, i, NewStyle2)
         Next i
         Rawl = .Row

      End With
   End Sub

   Sub TampilHeader()
      If G.Row <= 0 Then Exit Sub
      tRef.Text = G(G.Row, "Ref")
      Debug.Print(G(G.Row, "Tanggal"))
      dtTanggal.Value = G(G.Row, "Tanggal")
      If UCase(nmTbl) = "TBELI" Then
         tKodeCS.Text = G(G.Row, "IdSuplier").ToString
         tNamaCS.Text = G(G.Row, "NamaSuplier").ToString
         tHutPiu.Text = FrMny(G(G.Row, "Hutang").ToString)
         tHutPiu.Tag = G(G.Row, "Hutang")
      Else
         tKodeCS.Text = G(G.Row, "IdCustomer")
         tNamaCS.Text = G(G.Row, "NamaCustomer")
         tHutPiu.Text = FrMny(G(G.Row, "Piutang"))
         tHutPiu.Tag = G(G.Row, "Piutang")
      End If
      tTunai.Text = FrMny(G(G.Row, "Tunai"))
      tTunai.Tag = G(G.Row, "Tunai")

      CmdBayar.BackColor = Color.WhiteSmoke
      CmdBayar.ForeColor = Color.LightGray
      'CmdBayar.Enabled = False

      SetLtransport()
   End Sub

   Sub SetLtransport()
      Ltransport.Tag = GetProc("tTransportToolTip '" & tRef.Text & "'")

      Dim Ltoolt As String = Replace(Ltransport.Tag.ToString, Chr(13) + Chr(10), "")
      Ltoolt = "Transport: " & FrMny(CrText(Ltoolt, "Total: ", 1))

      If Ltransport.Tag = "" Then
         Ltransport.Text = "Transport: 0"
      Else
         Ltransport.Text = Ltoolt
      End If

   End Sub
   Private Sub Ltransport_MouseEnter(sender As Object, e As EventArgs) Handles Ltransport.MouseEnter
      Ltransport.Tag = GetProc("tTransportToolTip '" & tRef.Text & "'")

      Dim separators() As String = {"" & Chr(13) + Chr(10) & ""}
      Dim ket As String = Ltransport.Tag
      Dim words() As String = ket.Split(separators, StringSplitOptions.None)
      ket = ""
      For i As Integer = 1 To words.Count - 1
         If IsNumeric(CrText(words(i), ":", 1)) Then
            ket = ket & CrText(words(i), ":", 0) & ": " & FrMny(CrText(words(i), ":", 1)) & vbCrLf
         Else
            ket = ket & words(i) & vbCrLf
         End If
      Next

      TlTip(Ltransport, ket)
   End Sub
   Private Sub Ggg_AfterResizeColumn(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles G.AfterResizeColumn, GhutPiu.AfterResizeColumn
      SetGrd(sender, Me, nmTbl)
   End Sub

   Private Sub SplUtama_MouseDown(sender As Object, e As MouseEventArgs)
      If e.Y < 40 Then GeserForm(Me)
   End Sub









   Private Sub Transaksi_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
      If e.KeyCode = Keys.N AndAlso e.Modifiers = Keys.Control AndAlso e.Modifiers = Keys.Shift Then Proses("Add") : Exit Sub
      If e.KeyCode = Keys.E AndAlso e.Modifiers = Keys.Control AndAlso e.Modifiers = Keys.Shift Then Proses("Edit") : Exit Sub
      If e.KeyCode = Keys.Delete AndAlso e.Modifiers = Keys.Control AndAlso e.Modifiers = Keys.Shift Then Proses("Del") : Exit Sub

      If e.KeyCode = Keys.N AndAlso e.Modifiers = Keys.Control Then ProsesDtl("Add") : Exit Sub
      If e.KeyCode = Keys.E AndAlso e.Modifiers = Keys.Control Then ProsesDtl("Edit") : Exit Sub
      If e.KeyCode = Keys.Delete AndAlso e.Modifiers = Keys.Control Then ProsesDtl("Del") : Exit Sub
   End Sub

   Sub set_ForMe(Optional ngeset As Boolean = True)
      If ngeset Then
         SetPosisiForm(Me, "Trans" & nmTbl)
         SaveSetting("s_Bnl", Me.Name & nmTbl, "splUtama.SplitterDistance", splUtama.SplitterDistance)
         SaveSetting("s_Bnl", Me.Name & nmTbl, "spl_Detil.SplitterDistance", spl_Detil.SplitterDistance)
         SaveSetting("s_Bnl", Me.Name & nmTbl, "spl_AtasKnn.SplitterDistance", spl_AtasKnn.SplitterDistance)
      Else
         GetPosisiForm(Me, "Trans" & nmTbl)
         splUtama.SplitterDistance = GetSetting("s_Bnl", Me.Name & nmTbl, "splUtama.SplitterDistance", splUtama.SplitterDistance)
         spl_Detil.SplitterDistance = GetSetting("s_Bnl", Me.Name & nmTbl, "spl_Detil.SplitterDistance", spl_Detil.SplitterDistance)
         spl_AtasKnn.SplitterDistance = GetSetting("s_Bnl", Me.Name & nmTbl, "spl_AtasKnn.SplitterDistance", spl_AtasKnn.SplitterDistance)
      End If
   End Sub
   Private Sub Transaksi_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
      set_ForMe()
   End Sub
   Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles Me.Load
      set_ForMe(False)
   End Sub

   Private Sub splUtama_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles splUtama.SplitterMoved
      pnl_Cap_Data.Left = splUtama.SplitterDistance : lHeader.Left = pnl_Cap_Data.Left + pnl_Cap_Data.Width
   End Sub

   Sub TampilDetail(ByVal Nref As String, Optional RowA As Long = 0, Optional ColA As Long = 0)
      SplUtama.Text = "Loading ..." : Application.DoEvents()
      Dim sBeliJual As String = IIf(UCase(nmTbl) = "TBELI", "tPembelian", "tPenjualan")

      If KonekConn() = True Then
         Dim jSon As String = ""

         If G.Row > 1 Then If Trim(G(G.Row, G.Cols.Count - 1)) <> "" Then jSon = G(G.Row, G.Cols.Count - 1)

         GetRecGrid(Gd, "select * from " & sBeliJual & " where ref ='" & Nref & "' ", jSon)
         GetGrd(Gd, Me, nmTbl)

         For i As Integer = 1 To Gd.Cols - 1
            If Gd.get_ColDataType(i).ToString = "System.String" Then
               Gd.set_ColFormat(i, "")
               Gd.set_ColAlignment(i, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            ElseIf Gd.get_ColDataType(i).ToString = "System.DateTime" Then
               Gd.set_ColFormat(i, "dd MMM yy")
               Gd.set_ColAlignment(i, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignLeftCenter)
            Else
               Gd.set_ColFormat(i, "###,###")
               Gd.set_ColAlignment(i, C1.Win.C1FlexGrid.Classic.AlignmentSettings.flexAlignRightCenter)
            End If
         Next i
      Else
         MsgBox("not konek")
         Me.Dispose()
      End If

      lTotal_RP.Text = ""
      gTotal.Tag = 0
      If Gd.Rows > 1 Then
         gTotal.Tag = Gd.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, Gd.get_ColIndex("Total"), Gd.Rows - 1, Gd.get_ColIndex("Total"))
         lTotal_RP.Text = "Total:   Rp. " & FrMny(gTotal.Tag)
      End If
      If RowA < Gd.Rows - 1 Then Gd.Row = RowA
      Gd.Col = ColA

      tHutPiu.Text = Val(gTotal.Tag) - Val(noMny(tTunai.Text))
      tTunai_TextChanged()

      lTunai.Text = IIf(Val(noMny(tTunai.Text)) = 0, "Belum" & vbCrLf & "Bayar", "Sudah" & vbCrLf & "Bayar")
      CmdBayar.Text = IIf(Val(noMny(tTunai.Text)) > 0, "Edit" & vbCrLf & "Bayar", "Bayar" & vbCrLf & "Sekarang")


      '==========HUTANG LAMA=================
      Dim Sq As String = "select * from " & IIf(UCase(nmTbl) = "TBELI", "vHutang", "vPiutang") & " where " & IIf(UCase(nmTbl) = "TBELI", "IdSuplier", "IdCustomer") & " ='" & tKodeCS.Text & "' and id<> '" & tRef.Text & "' "
      Sq = Sq & "and tanggal <=  '" & G(G.Row, "Tanggal") & "'  "
      '(date BETWEEN '2017-04-19' AND NOW(date)
      GetRecGrid(GhutPiu, Sq)
      GetGrd(GhutPiu, Me, nmTbl)
      gColFormat(GhutPiu)


      Dim cHutPIu As String = IIf(UCase(nmTbl) = "TBELI", "Hutang", "Piutang")

      If GhutPiu.Rows > 1 Then
         tTang.Tag = GhutPiu.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, GhutPiu.get_ColIndex(cHutPIu), GhutPiu.Rows - 1, GhutPiu.get_ColIndex(cHutPIu))
         tTang.Text = FrMny(Val(tTang.Tag))
         tTangBayar.Tag = GhutPiu.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, GhutPiu.get_ColIndex("Bayar"), GhutPiu.Rows - 1, GhutPiu.get_ColIndex("Bayar"))
         tTangBayar.Text = FrMny(Val(tTangBayar.Tag))
         If tHutPiu.Tag Is Nothing Then tHutPiu.Tag = 0
         gTang.Tag = Val(tHutPiu.Tag.ToString) + (Val(tTang.Tag) - Val(tTangBayar.Tag))

         gTang.Text = "Tanggungan= " & IIf(tTang.Text = "", "0", tTang.Text) & "       " &
                      "Sdh Bayar= " & IIf(tTangBayar.Text = "", "0", tTangBayar.Text) & "       " &
                      "Sld Tanggungan= " & FrMny(Val(tTang.Tag) - Val(tTangBayar.Tag))

         tTang.Visible = False
         tTangBayar.Visible = False

         HitungHutPIU()
         spl_Detil.Panel2Collapsed = False
      Else
         spl_Detil.Panel2Collapsed = True
         gTang.Text = "Tanggungan= 0    " & "Sdh Bayar= 0    " & "Saldo Tanggungan= 0"
      End If
      '==========HUTANG LAMA=================

      SplUtama.Text = SplUtama.Tag : Application.DoEvents()
   End Sub

   Sub HitungHutPIU()
      Dim ttHutPiu As Double = Val(noMny(tHutPiu.Text)) + Val(noMny(tTang.Text))
      Dim ttlBayar As Double '= noMny(tTangBayar.Text) + noMny(tTangAngsur.Text)

      gTang.Tag = ttHutPiu - ttlBayar
      tTangHarus.Tag = Val(noMny(tTang.Text)) + Val(noMny(tHutPiu.Text))
      tTangHarus.Text = FrMny(tTangHarus.Tag)
   End Sub


   Private Sub Gd_DoubleClick(sender As Object, e As EventArgs) Handles Gd.DoubleClick
      If Gd.MouseRow <= 0 Then Exit Sub
      ProsesDtl("Edit")
   End Sub



   Sub ProsesDtl(ByVal prs As String)
      Dim Fe 'As New Fedit
      Dim gH As New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
      Dim sBeliJual As String = IIf(UCase(nmTbl) = "TBELI", "PembelianSave", "PenjualanSave")
      Dim sQ As String = ""

      If prs = "Add" Or prs = "Edit" Then
         If Fe.TampilCls(G, Gd, gH, Me, prs) = Windows.Forms.DialogResult.OK Then
            Dim IdNya As String = IIf(prs = "Add", CrtNowId(), Gd(Gd.Row, 0))
            sQ = sBeliJual & " '" & IdNya & "', " & vbCrLf

            Dim IsTt As String
            Dim IsGh As String
            For i As Byte = 1 To gH.Rows - 1
               IsTt = tt(gH(i, 2))
               IsGh = gH(i, 1).ToString.ToUpper

               If IsGh = "REF" Then sQ = sQ & "         '" & IsTt & "', " & vbCrLf
               If IsGh = "TANGGAL" Then sQ = sQ & "     '" & IsTt & "', " & vbCrLf

               If "IDSUPLIER IDCUSTOMER" Like "*" & IsGh & "*" Then sQ = sQ & "   '" & IsTt & "', " & vbCrLf
               If "NAMASUPLIER NAMACUSTOMER" Like "*" & IsGh & "*" Then sQ = sQ & " '" & IsTt & "', " & vbCrLf

               If IsGh = "IDBARANG" Then sQ = sQ & "    '" & IsTt & "', " & vbCrLf
               If IsGh = "NAMABARANG" Then sQ = sQ & "  '" & IsTt & "', " & vbCrLf
               If IsGh = "GRADE" Then sQ = sQ & "       '" & IsTt & "', " & vbCrLf
               If IsGh = "HARGA" Then sQ = sQ & "        " & Val(IsTt) & " , " & vbCrLf
               If IsGh = "JUMLAH" Then sQ = sQ & "       " & Val(IsTt) & " , " & vbCrLf
               If IsGh = "TOTAL" Then sQ = sQ & "        " & Val(IsTt) & "   " & vbCrLf

               If sBeliJual = "PenjualanSave" Then
                  If IsGh = "PACKKEY" Then sQ = sQ & ", " & Val(IsTt) & "   " & vbCrLf
               End If
            Next

            SetProc(sQ)
         End If
      End If

      If prs = "Del" Then
         Dim GrowA As Integer = Gd.Row
         If Fe.TampilCls(G, Gd, gH, Me, prs) = Windows.Forms.DialogResult.OK Then
            Gd.Row = GrowA
            sQ = "delete " & IIf(UCase(nmTbl) = "TBELI", "tPembelian", "tPenjualan") & " "
            sQ = sQ & " where id ='" & Gd(Gd.Row, 0) & "' "
            SetProc(sQ)
         End If
      End If

      KonekLagi(G.Row, G.Col)
      TampilDetail(G(G.Row, "Ref"), Gd.Row, Gd.Col)
   End Sub





   Private Sub Transaksi_Shown(sender As Object, e As EventArgs) Handles Me.Shown
      If G.Rows.Count > 1 Then G.Row = 1
   End Sub

   Private Sub tRef_MouseDown(sender As Object, e As MouseEventArgs) Handles tRef.MouseDown
      If e.Button = Windows.Forms.MouseButtons.Right Then
         If MsgBox("Apakahan 'Ref: " & tRef.Text & "' Akan di ganti?", vbOKCancel) = MsgBoxResult.Cancel Then Exit Sub
balik:
         Dim Inp As String = InputBox("Masukkan Referensi Pengganti", , tRef.Text)
         If Inp = tRef.Text Or Inp = "" Then Exit Sub
         Dim Gtp As String = GetProc("select top 1 ref from tbeli where upper(ref)='" & UCase(Inp) & "'")
         If Gtp <> "" Then
            MsgBox("Ref='" & UCase(Inp) & "' Sudah ada" & vbCrLf & "Ketik Referensi yang lain")
            GoTo balik
         End If

         Dim Tpen As String = IIf(UCase(nmTbl) = "TBELI", "tPembelian", "tPenjualan")
         SetProc("Update " & nmTbl & " set ref='" & Inp & "' where ref ='" & tRef.Text & "'")
         SetProc("Update " & Tpen & " set ref='" & Inp & "' where ref ='" & tRef.Text & "'")

         Dim RefA As String = tRef.Text

         KonekLagi(G.Row, G.Col)
         Dim RowRef As Integer = G.FindRow(Inp, 1, G.Cols("Ref").Index, True)
         G.Row = RowRef
         TampilHeader()
         TampilDetail(G(G.Row, "Ref"), Gd.Row, Gd.Col)
      End If
   End Sub

   Private Sub GdanGd_MouseDown(sender As Object, e As MouseEventArgs) Handles _
      G.MouseDown, Gd.MouseDown, GhutPiu.MouseDown
      'If e.Button = Windows.Forms.MouseButtons.Right Then Dim fP As New FpopUp : fP.Tampil(Me, sender, nmTbl, Control.MousePosition) : Exit Sub

      If (sender.MouseRow = -1 Or sender.MouseCol = -1) Then GeserForm(Me)
   End Sub


#Region "Textbox tTunai"
   'Private Sub tTunai_KeyDown(sender As Object, e As KeyEventArgs) Handles tTunai.KeyDown
   '   'If e.KeyCode = Keys.Return Then CmdBayar.PerformClick()
   '   'If e.KeyCode = Keys.Escape Then TampilHeader()
   'End Sub

   'Private Sub tTunai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tTunai.KeyPress
   '   'If e.KeyChar = Chr(Keys.Escape) Or e.KeyChar = Chr(Keys.Return) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Space) Then Exit Sub
   '   'SendKeys.Send(e.KeyChar)
   '   'e.KeyChar = ""
   '   'CmdBayar.PerformClick()

   'End Sub
   'Private Sub tTunai_KeyUp(sender As Object, e As KeyEventArgs) Handles tTunai.KeyUp
   '   'tHutPiu.Text = Val(gTotal.Tag) - Val(noMny(tTunai.Text))
   '   'tTunai_TextChanged()

   '   'If Val(noMny(tTunai.Text)) = 0 Then
   '   '   lTunai.Text = "Belum" & vbCrLf & "Bayar"
   '   'Else
   '   '   lTunai.Text = "Bayar Tunai"
   '   'End If
   'End Sub

   'Private Sub tTunaiHutPiu_Leave(sender As Object, e As EventArgs) Handles tTunai.Leave
   '   tTunai.Text = FrMny(tTunai.Text)
   'End Sub
#End Region


   Private Sub tTunai_TextChanged() Handles tTunai.TextChanged
      If noMny(tTunai.Text) <> Val(noMny(tTunai.Tag)) Or noMny(tHutPiu.Text) <> Val(noMny(tHutPiu.Tag)) Then
         CmdBayar.BackColor = Color.Cyan
         CmdBayar.ForeColor = Color.Black
         'CmdBayar.Enabled = True
      Else
         CmdBayar.BackColor = Color.WhiteSmoke
         CmdBayar.ForeColor = Color.LightGray
         'CmdBayar.Enabled = False
      End If

      tHutPiu.Text = FrMny(tHutPiu.Text)
   End Sub

   Private Sub CmdBayar_Click(sender As Object, e As EventArgs) Handles CmdBayar.Click
      If G.Row = -1 Then Exit Sub
      fPrint_Bayar.Tampil(G(G.Row, "Ref"))
      Exit Sub
      Dim Fby As New fBayar
      If Fby.Tampil(tTunai.Text, nmTbl, Gd, Me, gTotal.Tag, tTunai.Tag, Val(tTang.Tag) - Val(tTangBayar.Tag)) = Windows.Forms.DialogResult.OK Then
         Dim HutPiu As String = IIf(UCase(nmTbl) = "TBELI", "Hutang", "Piutang")
         SetProc("Update " & nmTbl & " set Tunai= " & noMny(tTunai.Text) & ", " & HutPiu & "= " & noMny(tHutPiu.Text) & "  where ref ='" & tRef.Text & "'")

         Dim RefA As String = tRef.Text

         KonekLagi(G.Row, G.Col)
         Dim RowRef As Integer = G.FindRow(RefA, 1, G.Cols("Ref").Index, True)
         G.Row = RowRef
         TampilHeader()
         TampilDetail(G(G.Row, "Ref"), Gd.Row, Gd.Col)
      End If
   End Sub

   Private Sub obj_MouseDown(sender As Object, e As MouseEventArgs) Handles _
      Me.MouseDown, splUtama.Panel1.MouseDown, splUtama.Panel2.MouseDown, lJudul.MouseDown,
      pnl_Crud_detil.MouseDown, lrincian.MouseDown, pnl_Cap_Data.MouseDown, lHeader.MouseDown,
      lHistory.MouseDown, spl_Bawah.Panel2.MouseDown, gTang.MouseDown, lref.MouseDown,
      ldate.MouseDown, lCodeCS.MouseDown, lNamaCS.MouseDown, tKodeCS.MouseDown,
      tNamaCS.MouseDown, tRef.MouseDown, pnl_Crud_Master.MouseDown,
      spl_AtasKnn.Panel1.MouseDown, spl_AtasKnn.Panel2.MouseDown,
      lTotal_RP.MouseDown, lTunai.MouseDown, lTotalharusBayar.MouseDown,
      LhutPiu.MouseDown, tTunai.MouseDown, tHutPiu.MouseDown, gTotal.Panel1.MouseDown

      GeserForm(Me)
   End Sub

   Private Sub Ltransport_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Ltransport.LinkClicked
      Dim Fd 'As New fTransport
      Fd.Tampil(tRef.Text)
      Do While Fd.Visible
         Application.DoEvents()
      Loop
      SetLtransport()
   End Sub

   Private Sub tSblmBayarAngsur_KeyPress(sender As Object, e As KeyPressEventArgs)
      Num(e)
   End Sub
   Private Sub btMax_Click(sender As Object, e As EventArgs) Handles btMax.Click
      Me.WindowState = IIf(Me.WindowState = FormWindowState.Normal, FormWindowState.Maximized, FormWindowState.Normal)
   End Sub
   Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
      Me.Dispose()
   End Sub



   Private Sub Gd_AfterResizeColumn(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles Gd.AfterResizeColumn
      SetGrd(Gd, Me, nmTbl)
   End Sub
   Private Sub G_MouseDown(sender As Object, e As MouseEventArgs) Handles _
      G.MouseDown, Gd.MouseDown, GhutPiu.MouseDown
      MosDownGrid(Me, sender, nmTbl, sender, e)
   End Sub

   Private Sub G_Click(sender As Object, e As EventArgs) Handles G.Click

   End Sub
End Class