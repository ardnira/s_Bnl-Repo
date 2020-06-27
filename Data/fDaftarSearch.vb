Public Class fDaftarSearch
   Dim nmTbl As String
   Dim fldKunci As String
   Function Tampil(ownerForm As Form, ByVal Gx As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic, nTbl As String, fldKey As String, Optional Per As Boolean = True) As String
      nmTbl = nTbl
      If IsNothing(nmTbl) Then Exit Function
      l_Cari.Text = "Cari Data: '" & nTbl.Substring(1) & "'"
      fldKunci = fldKey
      Application.DoEvents()

      If InStr("tBarangtCustomertSuplier", nTbl) > 0 Then
         nmTbl = nTbl
         If nmTbl.Contains("Barang") Then pnl_Cap_Data.BackgroundImage = Bnl_First.btListBarang.Image
         If nmTbl.Contains("Suplier") Then pnl_Cap_Data.BackgroundImage = Bnl_First.btListSuplier.Image
         If nmTbl.Contains("Customer") Then pnl_Cap_Data.BackgroundImage = Bnl_First.btListCustomer.Image
      Else 'jika PIUTANG/HUTANG
         nmTbl = IIf(UCase(nTbl) = "PIUTANG", "tCustomer", "tSuplier")
      End If

      Dim nmColumn As String = "SELECT * FROM ( SELECT TOP 99999  COLUMN_NAME  FROM INFORMATION_SCHEMA.COLUMNS  WHERE TABLE_NAME = '" & nmTbl & "'  "
      nmColumn += " AND ORDINAL_POSITION < 10  "
      nmColumn += " ORDER BY ORDINAL_POSITION ASC "
      nmColumn += " ) AS tempT  "
      nmColumn = GetProc(nmColumn, True).ToString().Replace("|", ",")

      GetRecGrid(G, "Select " & nmColumn & " from " & nmTbl)
      GetGrd(G, Me, nmTbl)
      Application.DoEvents()
      CallDefSearch()
      lCount.Text = G.Rows - 1 & " " & nTbl.Substring(1)
      Gx.Col = Gx.get_ColIndex(fldKey) : Gx.Focus()
      Tampil = IIf(Me.ShowDialog(ownerForm) = DialogResult.OK, Me.Tag, "")
   End Function
   Private Sub fDaftarSearch_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
      SetPosisiForm(Me, nmTbl)
   End Sub

   Private Sub fDaftarSearch_Load(sender As Object, e As EventArgs) Handles Me.Load
      GetPosisiForm(Me, nmTbl)

   End Sub
   Private Sub fDaftarSearch_Shown(sender As Object, e As EventArgs) Handles Me.Shown
      tSrch.Focus()
   End Sub
   Private Sub CmdApply_Click(sender As Object, e As EventArgs) Handles CmdApply.Click
      Me.Tag = G.get_TextMatrix(G.Row, G.get_ColIndex(fldKunci))
      Me.DialogResult = DialogResult.OK
      Me.Dispose()
   End Sub

   Private Sub fDaftarSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
      If e.KeyCode = Keys.Return Then CmdApply.PerformClick()
   End Sub
   Private Sub G_AfterResizeColumn(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles G.AfterResizeColumn
      SetGrd(G, Me, nmTbl)
   End Sub


#Region "PENCARIAN================="
   Private Sub G_KeyPress(sender As Object, e As KeyPressEventArgs) Handles G.KeyPress
      tSrch.Focus()
      L_Tips.ResetText()
      SendKeys.Send(e.KeyChar)
      If tSrch.Text = "" Then L_Tips.Text = "Cari '" & tSrch.Tag & "'"
   End Sub
   Sub CallDefSearch() ' dipanggil di form Activate
      tSrch.Tag = GetSetting(Application.ProductName & Me.Name.ToString & nmTbl, "ContextMenu", "tSrch.Tag", tSrch.Tag)
      Dim TlpC As String = ""
      TlpC = "Untuk Mengganti Kolom Pencarian '" & tSrch.Tag & "'," & vbCrLf
      TlpC = TlpC & "Silahkan klik, kemudian pilih"
      TlTip(lSearch, TlpC)
      lSearch.Text = "Cari: '" & tSrch.Tag & "'"
      L_Tips.Text = "Cari '" & tSrch.Tag & "'"
   End Sub

   Private Sub lSearch_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lSearch.LinkClicked
      ContextMenu1.Items.Clear()

      For i As Byte = 1 To G.Cols - 1
         Dim sbMenu As New ToolStripMenuItem(G.get_ColKey(i))
         Dim fntBl As Integer = IIf(G.get_ColKey(i) = tSrch.Tag, FontStyle.Bold, FontStyle.Regular)
         Dim fntSz As Integer = IIf(G.get_ColKey(i) = tSrch.Tag, 12, 9)

         sbMenu.Font = New Font("Courier New", fntSz, FontStyle.Bold)
         sbMenu.ForeColor = IIf(G.get_ColKey(i) = tSrch.Tag, Color.Crimson, Color.DimGray)
         sbMenu.Checked = IIf(G.get_ColKey(i) = tSrch.Tag, True, False)
         ContextMenu1.Items.Add(sbMenu)
      Next i
      ContextMenu1.Show(sender, New Point(sender.Left - 222, sender.Top))
   End Sub

   Private Sub ContextMenu1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenu1.ItemClicked
      tSrch.Tag = e.ClickedItem.ToString
      Dim kol As Integer = Val(tSrch.Tag)

      lSearch.Text = "Cari: '" & G(0, tSrch.Tag) & "'"
      SaveSetting(Application.ProductName & Me.Name.ToString & nmTbl, "ContextMenu", "tSrch.Tag", tSrch.Tag)
      L_Tips.Text = "Cari '" & tSrch.Tag & "'"
   End Sub

   Private Sub tSrch_KeyDown(sender As Object, e As KeyEventArgs) Handles tSrch.KeyDown
      If e.KeyCode = Keys.Return Then CmdApply.PerformClick() : Exit Sub
      If e.KeyCode = Keys.Escape And tSrch.Text = "" Then CmdCancel.PerformClick() : Exit Sub
      If e.KeyCode = Keys.Escape And tSrch.Text <> "" Then tSrch.Text = "" : Exit Sub

      G.Col = G.get_ColIndex(tSrch.Tag)
      If e.KeyCode = Keys.Down And G.Rows > 1 Then G.Row += 1 : G.Focus()
      If e.KeyCode = Keys.Up And G.Row > 1 Then G.Row -= 1 : G.Focus()
   End Sub
   Private Sub tSrch_TextChanged(sender As Object, e As EventArgs) Handles tSrch.TextChanged
      MsnCari(G, tSrch)
      lCount.Text = G.Rows - 1 & " " & nmTbl.Substring(1)
      L_Tips.ResetText()
      If tSrch.Text = "" Then L_Tips.Text = "Cari '" & tSrch.Tag & "'"
   End Sub
#End Region

   Private Sub G_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles G.MouseDoubleClick
      If e.Location.Y <= G.get_RowHeight(0) Then Exit Sub
      CmdApply.PerformClick()
   End Sub


   Private Sub G_MouseDown(sender As Object, e As MouseEventArgs) Handles G.MouseDown
      MosDownGrid(Me, G, nmTbl, sender, e)
   End Sub

   Private Sub fDaftarSearch_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        Me.MouseDown, pnlCari.MouseDown, l_Cari.MouseDown,
        lF3.MouseDown, pnlBawah.MouseDown, lCount.MouseDown
      GeserForm(Me)
   End Sub

   Private Sub L_Tips_Click(sender As Object, e As EventArgs) Handles L_Tips.Click
      L_Tips.Visible = False
      tSrch.Focus()
   End Sub
   Private Sub tSrch_Leave(sender As Object, e As EventArgs) Handles tSrch.Leave
      L_Tips.Visible = True
   End Sub

End Class