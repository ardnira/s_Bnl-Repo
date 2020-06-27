Public Class FpopUp
   Dim Frm As Form
   Dim nmTbl As String = ""
   Dim Gdt As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
   Dim GdtNeo As C1.Win.C1FlexGrid.C1FlexGrid
   Dim NewPos As New Point

   Dim NewStyle0 As C1.Win.C1FlexGrid.CellStyle
   Dim NewStyle1 As C1.Win.C1FlexGrid.CellStyle
   Dim NewStyle2 As C1.Win.C1FlexGrid.CellStyle
   Dim NewStyle3 As C1.Win.C1FlexGrid.CellStyle
   Dim gNeo As Boolean = False

   Sub Tampil(ByVal Fr As Form, ByRef Gg As Object, ByVal Ntbl As String, ByVal PosPoint As Point)

      If Gg.MouseCol = -1 Or Gg.MouseRow <> 0 Then Exit Sub
      If G.ToString = "C1.Win.C1FlexGrid.C1FlexGrid" Then
         gNeo = True : GdtNeo = Gg
      Else
         Gdt = Gg
      End If

      nmTbl = Ntbl
      Frm = Fr

      NewStyle0 = G.Styles.Add("NewStyle0")
      NewStyle1 = G.Styles.Add("NewStyle1")
      NewStyle2 = G.Styles.Add("NewStyle2")
      NewStyle3 = G.Styles.Add("NewStyle3")

      NewStyle0.ForeColor = System.Drawing.Color.White
      NewStyle1.ForeColor = System.Drawing.Color.LightGray
      NewStyle2.ForeColor = System.Drawing.Color.Indigo
      NewStyle3.ForeColor = System.Drawing.Color.CadetBlue

      NewPos = PosPoint
      Me.Text = "Set Grid: '" & Gg.Name & "' " & Ntbl
      Me.Show(Fr)
   End Sub
    

   Private Sub FpopUp_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
      If e.KeyCode = Keys.Return Then CmdApply.PerformClick() : Exit Sub
      If e.KeyCode = Keys.Escape Then CmdCancel.PerformClick()
   End Sub
   Private Sub FpopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Location = NewPos
      G.Dock = DockStyle.None
      If gNeo = True Then GdNeo() Else GClsic()

      G.Cols(0).Width = 20
      G.Cols(1).Width = 100
      G.Width = 120
      Me.Width = G.Width + 33

      G.Dock = DockStyle.Fill
   End Sub

   Sub GClsic()
      G.Clear() : G.Rows.Count = Gdt.Cols

      For i As Integer = 0 To Gdt.Cols - 1
         G.SetCellStyle(i, 0, NewStyle0)

         G(i, 1) = Gdt(0, i).ToString
         If Gdt.get_ColWidth(i) < 5 Or Gdt.get_ColIsVisible(i) = False Then
            G.SetCellStyle(i, 1, NewStyle1) : G(i, 0) = ""
         Else
            G.SetCellStyle(i, 1, NewStyle2) : G(i, 0) = "."
         End If
      Next
      G.Row = Gdt.MouseCol
   End Sub
   Sub GdNeo()
      G.Clear() : G.Rows.Count = GdtNeo.Cols.Count

      For i As Integer = 0 To GdtNeo.Cols.Count - 1
         G.SetCellStyle(i, 0, NewStyle0)

         G(i, 1) = GdtNeo(0, i)
         If GdtNeo.Cols(i).Width < 5 Or GdtNeo.Cols(i).Visible = False Then
            G.SetCellStyle(i, 1, NewStyle1) : G(i, 0) = ""
         Else
            G.SetCellStyle(i, 1, NewStyle2) : G(i, 0) = "."
         End If
      Next
      G.Row = GdtNeo.MouseCol
   End Sub

   Private Sub G_DoubleClick(sender As Object, e As EventArgs) Handles G.DoubleClick
      If G(G.Row, 0) = "" Then
         G.SetCellStyle(G.Row, 1, NewStyle3) : G(G.Row, 0) = ".."
      ElseIf G(G.Row, 0) = ".." Then
         G.SetCellStyle(G.Row, 1, NewStyle1) : G(G.Row, 0) = ""
      ElseIf G(G.Row, 0) = "." Then
         G.SetCellStyle(G.Row, 1, NewStyle1) : G(G.Row, 0) = "..."
      ElseIf G(G.Row, 0) = "..." Then
         G.SetCellStyle(G.Row, 1, NewStyle2) : G(G.Row, 0) = "."
      End If
   End Sub

   Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
      Me.Dispose()
   End Sub

   Private Sub CmdApply_Click(sender As Object, e As EventArgs) Handles CmdApply.Click
      If gNeo = True Then
         For i As Integer = 0 To G.Rows.Count - 1
            If G(i, 0) = "." Or G(i, 0) = ".." Then
               If GdtNeo.Cols(i).Width < 10 Then GdtNeo.Cols(i).Width = 100
               GdtNeo.Cols(i).Visible = True
            Else
               GdtNeo.Cols(i).Width = 0
               GdtNeo.Cols(i).Visible = False
            End If
         Next
         SetGrd(GdtNeo, Frm, nmTbl)

      Else

         For i As Integer = 0 To G.Rows.Count - 1
            If G(i, 0) = "." Or G(i, 0) = ".." Then
               If Gdt.get_ColWidth(i) < 10 Then Gdt.set_ColWidth(i, 100)
               Gdt.set_ColHidden(i, False)
            Else
               Gdt.set_ColWidth(i, 0)
               Gdt.set_ColHidden(i, True)
            End If
         Next
         SetGrd(Gdt, Frm, nmTbl)

      End If

      Me.Dispose()
   End Sub
     

   Private Sub FpopUp_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, PnlBwh.MouseDown
      GeserForm(Me)
   End Sub

   Private Sub FpopUp_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
      Frm.Focus()
      Me.Dispose()
   End Sub

   Private Sub G_MouseDown(sender As Object, e As MouseEventArgs) Handles G.MouseDown
      If Not (G.MouseRow = -1 Or G.MouseCol = -1) Then Exit Sub
      GeserForm(Me)
   End Sub

   Public Overloads Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
      Dim sColor As Color = Color.Black     ' FromArgb(50, 153, 153, 153)
      Dim gp As Graphics = e.Graphics

      Dim b As New SolidBrush(sColor)
      Dim p As New Pen(b, 3)

      gp.DrawLine(p, 0, 0 + (Me.Height - 3), 0 + (Me.Width - 3), 0 + (Me.Height - 3))
      gp.DrawLine(p, 0 + (Me.Width - 3), 0, 0 + (Me.Width - 3), 0 + (Me.Height - 3))
   End Sub
   Public Sub New()
      ' This call is required by the designer.
      InitializeComponent()
      AddHandler MyBase.Paint, AddressOf OnPaint

      ' Add any initialization after the InitializeComponent() call.

   End Sub
End Class