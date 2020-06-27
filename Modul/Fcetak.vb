Module Fcetak
   Dim brs_papersize As Integer
   Dim PgSetting As New Printing.PageSettings
   Dim defPrinter As String 'menampung nama default Printer di comp
   Dim ctk_rpt As New System.Drawing.Printing.PrintDocument

   Public Function paper_size(ByRef nm_form As String) As Integer
      If nm_form = "faktur" Then
         For i = 0 To ctk_rpt.PrinterSettings.PaperSizes.Count - 1
            If ctk_rpt.PrinterSettings.PaperSizes(i).PaperName = "faktur" Then
               brs_papersize = CInt(ctk_rpt.PrinterSettings.PaperSizes(i).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(ctk_rpt.PrinterSettings.PaperSizes(i)))
               paper_size = brs_papersize
               Exit For
            End If
         Next
      End If
      Return paper_size
   End Function
End Module
