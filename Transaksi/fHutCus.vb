Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Public Class fHutCus
   Dim nmTbl As String
   Dim SibukLoad As Boolean = True
   Dim LoadAwal As Boolean = True

   Sub Tampil(ByVal Tbl As String)
      nmTbl = Tbl
      If vMdi = True Then Me.Show() Else Me.Show(Bnl_First)
   End Sub

   Private Sub fHarta_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
      SibukLoad = False
      If LoadAwal = False Then Exit Sub
      LoadAwal = False
      TglBlnLaluDanTglNow(tglA, tglB)
      CkAll.Checked = GetSetting(Application.ProductName & Me.Name.ToString & nmTbl, "CkAll.Checked", "Checked", CkAll.Checked)
      KonekLagi(G.Row, G.Col)
      CallDefSearch()
   End Sub
   Private Sub fHarta_Shown(sender As Object, e As EventArgs) Handles Me.Shown
      hapudToolstrip_NganggurDefault()
   End Sub
   Sub hapudToolstrip_NganggurDefault()
      With pg
         .SelectedObject = pg.Item : .Item.Clear()

         Dim j As Integer
         For j = 0 To .ToolStrip.Items.Count - 1
            'If .ToolStrip.Items(j).Name.ToString.Contains("strp_") = False Or
            '      .ToolStrip.Items(j).AccessibleRole = AccessibleRole.CheckButton Or
            '      .ToolStrip.Items(j).Text = "" Or
            If .ToolStrip.Items(j).Tag <> "proses" Then .ToolStrip.Items(j).Visible = False
         Next
      End With
      'CheckButton
   End Sub

   Private Sub fHarta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
      SetPosisiForm(Me, nmTbl)
   End Sub

   Private Sub fHarta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
      If e.KeyCode = Keys.F5 Then BtnOkClick()
   End Sub

   Private Sub fHarta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      GetPosisiForm(Me, nmTbl)
      Me.Text = IIf(nmTbl = "Kas", "Saldo Kas", "Saldo Piutang")
   End Sub

   Private Sub BtnOkClick() Handles BtnOk.Click
      KonekLagi(G.Row, G.Col)
   End Sub

   Sub KonekLagi(Optional RowA As Long = 0, Optional ColA As Long = 0)
      Loadx(lLoading, "Konek ...")
      If KonekConn() = True Then
         G.Tag = "sibuk" : G.Redraw = False

         Dim Db As String : Dim Kr As String
         '  Me.Enabled = False

         Db = IIf(nmTbl = "Piutang", "Piutang", "Hutang")
         Kr = "Bayar"


         If Not CkAll.Checked Then
            GetRecGrid(G, "Saldo" & nmTbl & "'" & tSrch.Tag & "', '" & Format(tglA.Value, "MM/dd/yy hh:mm") & "','" & Format(tglB.Value, "MM/dd/yy hh:mm") & "'")
         Else
            GetRecGrid(G, "Saldo" & nmTbl & "'" & tSrch.Tag & "', '1977-01-22','" & Format(Now, "MM/dd/yy hh:mm") & "'")
         End If

         Dim Tmsk As Double = SumG(G, Db)
         Dim Tklr As Double = SumG(G, Kr)
         Dim Sldo As Double = 0
         If G.Rows > 1 Then Sldo = G(G.Rows - 1, G.Cols - 1)
         gBawah.Text = G.Rows - 1 & " Record                                       " & Db & ":  " & FrMny(Tmsk) & "       " & Kr & ":  " & FrMny(Tklr) & "       Saldo:  " & FrMny(Sldo) & "     "

         Lsaldo.Text = "Saldo " & IIf(nmTbl = "Kas", "  K A S", IIf(Sldo > 0, "  P I U T A N G", "  H U T A N G")) & ":   " & IIf(nmTbl = "Kas", FrMny(Sldo), FrMny(Math.Abs(Sldo)))
         Lsaldo.ForeColor = IIf(Sldo > 0, IIf(nmTbl = "Kas", Color.Green, Color.Blue), Color.Red)

         'If Not SibukLoad Then GetGrd(G, Me, nmTbl)
         If RowA <= G.Rows - 1 Then G.Row = RowA
         If ColA <= G.Cols - 1 Then G.Col = ColA

         G.Tag = ""

         gColFormat(G)
         GetGrd(G, Me, nmTbl)
         Me.Enabled = True
      Else
         MsgBox("not konek")
         Me.Dispose()
      End If
      G.Redraw = True
      Loadx(lLoading, , False)
   End Sub






   Private Sub G_AfterResizeColumn(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles G.AfterResizeColumn
      SetGrd(G, Me, nmTbl)
   End Sub

   Private Sub G_MouseDown(sender As Object, e As MouseEventArgs)
      If e.Button = Windows.Forms.MouseButtons.Right Then
         Dim fP 'As New FpopUp
         fP.Tampil(Me, sender, nmTbl, Control.MousePosition)
      Else
         If (G.MouseRow = -1 Or G.MouseCol = -1) Then GeserForm(Me)
      End If
   End Sub

   Private Sub gBawah_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTembel.MouseDown, PnlAtas.MouseDown, Lsaldo.MouseDown, Lperiode.MouseDown, gBawah.MouseDown
      GeserForm(Me)
   End Sub






#Region "PENCARIAN================="

   Sub CallDefSearch() ' dipanggil di form Activate
      tSrch.Tag = GetSetting(Application.ProductName & Me.Name.ToString & nmTbl, "ContextMenu", "tSrch.Tag", tSrch.Tag)
      Dim TlpC As String = ""
      TlpC = "Untuk Mengganti Kolom Pencarain '" & tSrch.Tag & "'," & vbCrLf
      TlpC = TlpC & "Silahkan klik, kemudian pilih"
      TlTip(lSearch, TlpC)
      lSearch.Text = "Cari: '" & tSrch.Tag & "'"
      'tSrch.Properties.NullValuePrompt = "Cari '" & tSrch.Tag & "'"
   End Sub

   Private Sub lSearch_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lSearch.LinkClicked
      ContextMenu1.Items.Clear()

      Dim kol As Integer = Val(tSrch.Tag)
      Dim mnDef As New MenuItem

      For i As Byte = 1 To G.Cols - 1
         If G.get_ColKey(i) = tSrch.Tag Then
            mnDef.Text = G.get_ColKey(i)
            mnDef.Checked = True
            mnDef.Visible = True
            mnDef.DefaultItem = True

            ContextMenu1.Items.Add("=>" & mnDef.Text & "<=")
         Else
            ContextMenu1.Items.Add(G.get_ColKey(i))
         End If
      Next i
      ContextMenu1.Show(lSearch, New Point(lSearch.Left - 222, lSearch.Top))
   End Sub

   Private Sub ContextMenu1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenu1.ItemClicked
      tSrch.Tag = e.ClickedItem.ToString
      Dim kol As Integer = Val(tSrch.Tag)
      tSrch.Tag = tSrch.Tag.ToString.Replace("=>", "")
      tSrch.Tag = tSrch.Tag.ToString.Replace("<=", "")
      lSearch.Text = "Cari: '" & G(0, tSrch.Tag) & "'"
      SaveSetting(Application.ProductName & Me.Name.ToString & nmTbl, "ContextMenu", "tSrch.Tag", tSrch.Tag)
      'tSrch.Properties.NullValuePrompt = "Cari '" & tSrch.Tag & "'"
   End Sub

   Private Sub tSrch_TextChanged(sender As Object, e As EventArgs) Handles tSrch.TextChanged
      'MsnCari(G, tSrch)
   End Sub
#End Region




   Private Sub CkAll_CheckedChanged(sender As Object, e As EventArgs) Handles CkAll.CheckedChanged
      If SibukLoad Then Exit Sub
      PnlTgl.Visible = Not CkAll.Checked
      If Not CkAll.Checked Then
         Lperiode.Text = "Periode: " : tglA.Focus()
      Else
         Lperiode.Text = "Tampil Semua Data       [dari awal sd akhir]" : BtnOk.Focus()
      End If
      SaveSetting(Application.ProductName & Me.Name.ToString & nmTbl, "CkAll.Checked", "Checked", CkAll.Checked)

      BtnOk.Focus()
      Application.DoEvents()
      BtnOk.PerformClick()
   End Sub


   Private Sub G_DoubleClick(sender As Object, e As EventArgs)
      If G.MouseRow = 0 Then Exit Sub
      'bt_Click(sender, e)
   End Sub

   Sub Proses(ByVal prs As String)
      Dim Fe ' As New Fedit
      Dim gH As New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic

      If prs = "Add" Then
         If Fe.Tampil(G, gH, Me, prs, nmTbl) = Windows.Forms.DialogResult.OK Then
            Dim sQ As String = "update " & nmTbl & " set "
            Dim Jdl As String = "Insert Into " & nmTbl & "(" & vbCrLf
            Dim Isi As String = "values (" & vbCrLf

            For i As Byte = 1 To gH.Rows - 1
               Jdl = Jdl & gH(i, 1) & IIf(i < gH.Rows - 1, ",", "") & vbCrLf

               'If G.Cols(i).DataType.ToString = "System.String" Then
               '   Isi = Isi & "'" & tt(gH(i, 2)) & "'" & IIf(i < gH.Rows - 1, ",", "") & vbCrLf
               'Else
               '   Isi = Isi & Val(gH(i, 2)) & IIf(i < gH.Rows - 1, ",", "") & vbCrLf
               'End If
            Next

            Jdl = Jdl & ")"
            Isi = Isi & ")"
            sQ = Jdl & " " & vbCrLf & Isi

            SetProc(sQ) : KonekLagi(G.Row, G.Col)
         End If

      End If
      If prs = "Edit" Then
         If Fe.Tampil(G, gH, Me, prs, nmTbl) = Windows.Forms.DialogResult.OK Then
            Dim sQ As String = "update " & nmTbl & " set "
            For i As Byte = 1 To gH.Rows - 1
               'If G.Cols(i).DataType.ToString = "System.String" Then
               '   sQ = sQ & gH(i, 1) & "='" & tt(gH(i, 2)) & "',"
               'Else
               '   sQ = sQ & gH(i, 1) & "=" & Val(gH(i, 2)) & ","
               'End If
               sQ = sQ & vbCrLf
            Next
            sQ = sQ.Substring(0, sQ.Length - vbCrLf.ToString.Length - 1) & vbCrLf
            sQ = sQ & " where id ='" & G(G.Row, 1) & "' "    'G.Cell(flexcpData, i, 2) 
            SetProc(sQ) : KonekLagi(G.Row, G.Col)
         End If
      End If

      If prs = "Del" Then
         If Fe.Tampil(G, gH, Me, prs, nmTbl) = Windows.Forms.DialogResult.OK Then
            Dim sQ As String = "delete " & nmTbl & " "
            sQ = sQ & " where id ='" & G(G.Row, 1) & "' "  'gH.get_TextMatrix(1, 2) 
            SetProc(sQ) : KonekLagi(G.Row, G.Col)
         End If
      End If
   End Sub



   Private Sub pg_SelectedGridItemChanged(sender As Object, e As SelectedGridItemChangedEventArgs) Handles pg.SelectedGridItemChanged
      'Dim tp As Object = e.NewSelection.Value.GetType
      'If tp.Name.ToString.Contains("DateTime") = True Then
      '   pg.SelectedObjects.SetValue("d", e.NewSelection.Value)
      'End If
   End Sub
   Private Sub G_RowColChange(sender As Object, e As EventArgs) Handles G.RowColChange
      If G.Row <= 0 Then Exit Sub
      If IsNothing(G(G.Row, 0)) = True Then Exit Sub
      With pg
         .SelectedObject = pg.Item : .Item.Clear()
         Dim vlu As Object
         For i As Integer = 0 To G.Cols - 1

            vlu = G(G.Row, i)

            Dim tp As String = G.get_ColDataType(i).Name.ToString
            Debug.Print(vlu.GetType.Name.ToString)
            '     If tp = "DateTime" Then vlu = Format(vlu, "dd MMM yy")
            'If tp = "Decimal" Then vlu = vlu.ToString("dd MMM yy")
            'If tp="DateTime"
            'If tp="String"

            .Item.Add(G.get_ColKey(i).ToString(), vlu,
                          IIf(i = 0, True, False),
                          "", 'kategori
                          G.get_ColKey(i).ToString.Replace("_", " ")) 'description

            'If tp = "DateTime" Then pg.ItemSet.Item(i).

            'Dim tp As String = .Item.GetProperties.GetType.Name.ToString


            'If Add_Edit_Del = "Add" Then
            '   .Item.Item(i).Value = IIf(IsNumeric(G(G.Row, i)), Nothing, "")
            'End If

         Next

         .Refresh()


      End With
   End Sub




   Private Sub pctExpand_Click(sender As Object, e As EventArgs) Handles pctExpand.Click
      Dim rrimg As Image
      rrimg = pctExpand.BackgroundImage
      pctExpand.BackgroundImage = pctExpand.ErrorImage
      pctExpand.ErrorImage = rrimg
      spl_Utama.Panel1Collapsed = Not spl_Utama.Panel1Collapsed
      If spl_Utama.Panel1Collapsed = True Then
         pctExpand.Left = spl_Utama.Left
      Else
         pctExpand.Left = spl_Utama.Left + spl_Utama.Panel1.Width - pctExpand.Width
      End If
      'spl_Utama.Panel1.Width = IIf(spl_Utama.Panel1.Width > pctExpand.Width, pctExpand.Width, 150)
   End Sub

   Private Sub spl_Utama_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles spl_Utama.SplitterMoved
      If spl_Utama.Panel1Collapsed = True Then
         pctExpand.Left = spl_Utama.Left
      Else
         pctExpand.Left = spl_Utama.Left + spl_Utama.Panel1.Width - pctExpand.Width
      End If
   End Sub


   Private Sub CmdSupCus_Click(sender As Object, e As EventArgs) Handles CmdSupCus.Click
      Dim HslIdX As String = ""
      Dim HslNmX As String = ""
      Dim Sq As String = "Select * from " & IIf(UCase(nmTbl) = "PIUTANG", "tCustomer", "tSuplier")
      Dim Fp As New fCusSup : Dim Fd As New fHarta
      If Fp.Tampil(Me, nmTbl, Sq, HslIdX, HslNmX) = Windows.Forms.DialogResult.OK Then
         tSrch.Tag = HslIdX
         tSrch.Text = HslNmX
         BtnOkClick()
      End If
   End Sub
End Class