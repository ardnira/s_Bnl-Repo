Imports C1.Win.C1FlexGrid.Classic
Imports C1.Win.C1FlexGrid.Classic.CellPropertySettings
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module mGrid
   Sub Klone(g1 As C1FlexGridClassic, g2 As C1FlexGridClassic)
      g1.Rows = g2.Rows
      g1.Cols = g2.Cols
      g1.Cell(flexcpText, 0, 0, g1.Rows - 1, g1.Cols - 1) = g2.Cell(flexcpText, 0, 0, g2.Rows - 1, g2.Cols - 1)
   End Sub

   Function SumG(ByVal g As C1.Win.C1FlexGrid.C1FlexGrid, ByVal Kol As String) As Double
      If g.Rows.Count <= 1 Then Return -1 : Exit Function
      Dim KolKe As Integer = IIf(IsNumeric(Kol), Val(Kol), g.Cols(Kol).Index)

      If g.Cols(KolKe).Index = -1 Then Return -1 : Exit Function
      Return g.Aggregate(C1.Win.C1FlexGrid.AggregateEnum.Sum, 1, g.Cols(Kol).Index, g.Rows.Count - 1, g.Cols(Kol).Index)
   End Function
    Sub SetGrd(ByVal G As Object, ByVal Frm As Form, Optional Ket As String = "")
        Dim HdKey As String = Application.ProductName & Frm.Name.ToString & G.Name & Ket
         
        Dim jAry As New JArray

        If G.ToString = "C1.Win.C1FlexGrid.C1FlexGrid" Then
            For i As Integer = 0 To G.cols.count - 1
                jAry.Add(IIf(G.cols(i).width > G.width, G.width / 2, G.cols(i).width))
            Next i
        Else
            For i As Integer = 0 To G.Cols - 1
                jAry.Add(IIf(G.get_ColWidth(i) > G.width, G.width / 2, G.get_ColWidth(i)))
            Next i
        End If

        TkeySet(HdKey & "lebarKol", jAry.ToString)
        Console.WriteLine(jAry.ToString)
    End Sub



    Sub GetGrd(ByRef G As Object, ByVal Frm As Form, Optional Ket As String = "")
        Dim ttlW As Integer = 0
        Dim HdKey As String = Application.ProductName & Frm.Name.ToString & G.Name & Ket
        Dim tKy As String = TkeyGet(HdKey & "lebarKol")
        If tKy = "" Then tKy = "[0]"

        Dim jarr As Linq.JArray = Linq.JArray.Parse(tKy)
        Dim Lkol As Integer = 0

        If G.ToString = "C1.Win.C1FlexGrid.C1FlexGrid" Then
            For i As Integer = 0 To G.Cols.Count - 1
                If i > jarr.Count - 1 Then Exit For
                If Not (tKy = "[0]" Or tKy = Nothing) Then Lkol = jarr.Item(i)
                G.cols(i).width = Lkol
                ttlW = ttlW + Lkol
                If G.Cols(i).Width <= 1 Then G.Cols(i).Visible = False
            Next i

            If ttlW < 10 Then
                For i As Integer = 0 To G.Cols.Count - 1
                    G.cols(i).width = 10
                    G.Cols(i).Visible = True
                Next i
            End If
        Else

            For i As Integer = 0 To G.Cols - 1
                If i > jarr.Count - 1 Then Exit For
                If Not (tKy = "[0]" Or tKy = Nothing) Then Lkol = jarr.Item(i)
                G.set_ColWidth(i, Lkol)
                ttlW = ttlW + Lkol
                If G.get_ColWidth(i) <= 1 Then G.set_ColHidden(i, True)
            Next i

            If ttlW < 10 Then
                For i As Integer = 0 To G.Cols - 1
                    G.set_ColWidth(i, 10)
                    G.set_ColHidden(i, False)
                Next i
            End If
        End If

   End Sub
    
    Function ColIdx(ByVal g As C1FlexGridClassic, ByVal Jdl As String) As Integer
        For i As Integer = 0 To g.Cols - 1
            If UCase(g.get_TextMatrix(0, i)) = UCase(Jdl) Then
                Return i
                Exit Function
            End If
        Next
        Return 0
    End Function

    Sub gColFormat(Gx As C1.Win.C1FlexGrid.C1FlexGrid)
      For i As Integer = 1 To Gx.Cols.Count - 1
         If Gx(0, 1) = "" Then Exit Sub
         If Gx.Cols(i).DataType.ToString = "System.String" Then
            Gx.Cols(i).Format = ""
            Gx.Cols(i).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
         ElseIf Gx.Cols(i).DataType.ToString = "System.DateTime" Then
            Gx.Cols(i).Format = "dd MMM yy"
            Gx.Cols(i).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
         Else
            Gx.Cols(i).Format = "###,###"
            Gx.Cols(i).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter
         End If
      Next i
   End Sub

   Sub TkeySet(ByVal Prp As String, ByVal Isi As String)
      SetProc("PrpTableSet 'tKey', '" & Prp & "','" & Isi & "' ")
   End Sub
   Function TkeyGet(ByVal Prp As String, Optional IsiDefault As String = "") As String
      Dim IsiX As String
      IsiX = GetProc("PrpTableGet 'tKey', '" & Prp & "' ")
      Return IIf(IsiX = "", IsiDefault, IsiX)
   End Function







   Sub MosDownGrid(frm As Form, g As Object, NmTbl As String, sender As Object, e As MouseEventArgs) 'mouse down dan Klak popUp grid
      Dim Mr, Mc As Integer
      Mr = g.MouseRow : Mc = g.MouseCol
      If e.Button = MouseButtons.Right Then
         '   Dim fP As New PupGrid : fP.Tampil(frm, sender, NmTbl, Control.MousePosition)
      Else
         If Not (Mr = -1 Or Mc = -1) Then
            ' Console.WriteLine(g(Mr, Mc))
            If IsDBNull(g(Mr, Mc)) Then GeserForm(frm)
            'GeserForm(frm)
         Else
            If Mr = -1 Or Mc = -1 Then GeserForm(frm) : Exit Sub
            If Not ((e.X > g.Width - 20) Or (e.Y > g.Height - 20)) And Mr > 0 Then GeserForm(frm)
         End If
      End If
   End Sub




   Function ifnull_Str(g As Object) As Object
      Return IIf(IsDBNull(g), "", g)
   End Function




#Region "Ganti judul Colom Grid"
   Sub SetGrdJudul(ByVal G As Object, ByVal Frm As Form, Optional Ket As String = "")
        Dim HdKey As String = Application.ProductName & Frm.Name.ToString & G.Name & Ket
        Dim jAry As New JArray

        Dim JKol As Integer = IIf(G.ToString = "C1.Win.C1FlexGrid.C1FlexGrid", G.Cols.Count - 1, G.Cols - 1)
        For i As Integer = 0 To G.cols.count - 1
            jAry.Add(G(0, i).ToString)
        Next i
      
        TkeySet(HdKey & "NamaKol", jAry.ToString)
   End Sub



   Sub GetGrdJudul(ByRef G As Object, ByVal Frm As Form, Optional Ket As String = "")
      Dim ttlW As Integer = 0
        Dim HdKey As String = Application.ProductName & Frm.Name.ToString & G.Name & Ket
        Dim tKy As String = TkeyGet(HdKey & "NamaKol")
        If tKy = "" Then tKy = "[]"

        Dim jarr As Linq.JArray = Linq.JArray.Parse(tKy)
        Dim nkol As String = ""

      Dim JKol As Integer = 0
      If G.ToString = "C1.Win.C1FlexGrid.C1FlexGrid" Then
         JKol = G.cols.count - 1
      Else
         JKol = G.cols - 1
      End If

        For i As Integer = 0 To JKol
         If Not (tKy = "[]" Or tKy = "[0]" Or tKy = Nothing) Then nkol = jarr.Item(i)
            G(0, i) = nkol
        Next i
    End Sub
#End Region

End Module
