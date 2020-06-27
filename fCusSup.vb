Imports System.Windows.Forms
Public Class fCusSup
   Dim HslIdX As String
   Dim HslNmX As String

   Dim ObjNempel As Object
   Dim nmTbl As String
   Dim Sq As String = ""

   Function Tampil(ByVal ObjNem As Object, ByVal nmTblx As String, ByVal Sqq As String, Optional ByRef HslId As String = "", Optional ByRef HslNm As String = "") As DialogResult
      ObjNempel = ObjNem : Sq = Sqq
      If nmTblx = "Barang" Then
         nmTbl = nmTblx
      Else
         nmTbl = IIf(UCase(nmTblx) = "PIUTANG", "Customer", "Suplier")
      End If


      Tampil = Me.ShowDialog()
      If Gb.Tag.ToString = "sukses" Then
         Tampil = Windows.Forms.DialogResult.OK
         HslId = HslIdX
         HslNm = HslNmX
      End If
   End Function

   Private Sub fList_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
      SetPosisiForm(Me, "CusSup" & nmTbl)
   End Sub
   Private Sub Flist_Load(sender As Object, e As EventArgs) Handles Me.Load
      If nmTbl = "Barang" Then
         GetPosisiForm(Me, nmTbl)
      Else
         GetPosisiForm(Me, "CusSup" & nmTbl)
      End If

      'Dim Poind As New Point(ObjNempel.Left, ObjNempel.Top)
      'If First.Ribbon.Minimized Then
      '   Me.Left = Poind.X + 450
      '   Me.Top = Poind.Y + 120
      'Else
      '   Me.Left = Poind.X + 450
      '   Me.Top = Poind.Y + 210
      'End If

      KonekData()
      tSrch.Focus()
   End Sub
   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
      berHasil()
   End Sub
   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Gb.Tag = "cancel"
      Me.Dispose()
   End Sub
   Sub KonekData(Optional RowA As Long = 0, Optional ColA As Long = 0)
      If KonekConn() = True Then
         Gb.Tag = "sibuk"
         GetRecGrid(Gb, Sq)
         GetGrd(Gb, Me, "CusSup" & nmTbl)
         If RowA <= Gb.Rows - 1 Then Gb.Row = RowA
         If ColA <= Gb.Cols - 1 Then Gb.Col = ColA
         'Gb.Cols(0).Visible = False
         'Gb.Cols(1).Visible = False

         gColFormat(Gb)

         Gb.Tag = ""
      Else
         MsgBox("not konek")
         Me.Dispose()
      End If
   End Sub

   Private Sub tSrch_TextChanged() Handles tSrch.TextChanged
      If Gb.Tag Is Nothing Then Exit Sub
      If Gb.Tag = "Shown" Or Gb.Tag = "cancel" Then Exit Sub
      tSrch.Tag = "Nama" & nmTbl
      '  Gb.Redraw = False
      MsnCari(Gb, tSrch)
      ' GetGrd(Gb, Me, "CusSup" & nmTbl)
      ' Gb.Redraw = True
   End Sub

   Private Sub Gb_AfterResizeColumn(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles Gb.AfterResizeColumn
      SetGrd(Gb, Me, "CusSup" & nmTbl)
   End Sub

   Private Sub Gb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Gb.KeyPress
      tSrch.Focus()
      SendKeys.Send(e.KeyChar)
   End Sub


   Private Sub Gb_GotFocus(sender As Object, e As EventArgs) Handles Gb.GotFocus
      Try
         ' Debug.Print(Gb.Cols("Nama" & nmTbl).Index)
      Catch
         Exit Sub
      End Try
      Gb.Col = Gb.get_ColIndex("Nama" & nmTbl)
      If Gb.Rows > 1 And Gb.Row = 0 Then Gb.Row = 1
   End Sub




   Private Sub berHasil()
      Gb.Tag = "sukses"
      HslIdX = Gb(Gb.Row, "id")
      Try
         HslNmX = Gb(Gb.Row, "Nama" & nmTbl)
      Catch
         Exit Sub
      End Try
      Me.Dispose()
   End Sub

   Private Sub tSrch_KeyDown(sender As Object, e As KeyEventArgs) Handles tSrch.KeyDown, Gb.KeyDown
      If e.KeyCode = Keys.Return Then berHasil() : Exit Sub
      If e.KeyCode = Keys.Escape Then
         If tSrch.Text = "" Then Gb.Tag = "cancel" : Me.Dispose() : Exit Sub
         tSrch.Text = ""
      End If

      If e.KeyCode = Keys.Down Then
         tSrch.Text = ""
         Gb.Focus()
      End If
      If e.KeyCode = Keys.Up Then
         If Gb.Row = 1 Then tSrch.Focus()
      End If
   End Sub

   Private Sub Gb_DoubleClick(sender As Object, e As EventArgs) Handles Gb.DoubleClick
      berHasil()
   End Sub


   Private Sub FlstBarang_MouseDown(sender As Object, e As MouseEventArgs) Handles _
      Me.MouseDown, Panel2.MouseDown, PnlProses.MouseDown
      GeserForm(Me)
   End Sub


   Private Sub Gb_MouseDown(sender As Object, e As MouseEventArgs) Handles Gb.MouseDown
      If e.Button = Windows.Forms.MouseButtons.Right Then
         'Dim fP As New FpopUp
         'fP.Tampil(Me, sender, "CusSup" & nmTbl, Control.MousePosition)
      Else
         If (Gb.MouseRow < 0 Or Gb.MouseCol = -1) Then GeserForm(Me)
      End If

   End Sub



End Class