Imports C1.Win.C1FlexGrid
Module mText
   Function tt(ByVal Oj As Object) As String
      If IsNothing(Oj) = True Then
         Oj = ""
      ElseIf String.IsNullOrEmpty(Oj.ToString) Then
         Oj = ""
      End If
      Oj = Replace(Oj, "'", "`")
      Return Oj
   End Function

   Function CrtNowId() As String
        Dim CrId As String = DateTime.Now.ToString("yyMMddhhmmss") & Left(Rnd(1).ToString, 6)
      Debug.Print(CrId)
      Return CrId
   End Function

   Sub MsnCari(ByRef Gx As C1FlexGrid, ByRef tC As Object)
      If tC.Text = CChar(ChrW(Keys.Escape)) Then
         tC.Text = String.Empty
      End If

      Try
         Dim source1 As New BindingSource() : source1.DataSource = Gx.DataSource
         Dim tf As String = IIf(tC.Text = "",
                              "",
                              IIf(Gx.Cols.Count > 0,
                                  IIf(Gx.Cols(tC.Tag).DataType.ToString = "System.String",
                                      tC.Tag & " like '*" & tC.Text & "*'",
                                      tC.Tag & " = " & Val(tC.Text) & ""), ""))
         source1.Filter = tf
         Gx.Refresh()
      Catch ex As Exception
         ' MsgBox(ex.Message)
      End Try
   End Sub

   Function FrMny(ByVal t As String) As Object
      If t Is Nothing Then t = ""
      If t = "" Then t = "0"
      t = FormatCurrency(t, 0, TriState.False, TriState.False, TriState.UseDefault) '.Replace("$", "")
      Return t.Replace("$", "")
   End Function
   Function noMny(ByVal t As Object) As String
      If t Is Nothing Then t = ""
      t = t.ToString.Replace(",", "")
      t = t.ToString.Replace(".", "")
      If t = "" Then t = 0
      Return t
   End Function


   Sub BlokObj(ByRef TextBox1 As Object)
      Dim position As Integer = TextBox1.Text.Length
      TextBox1.Select(0, position)
   End Sub


   Sub Num(ByRef e As KeyPressEventArgs)
      If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
   End Sub

   Sub TlTip(ByRef obj As Object, Optional ket As String = "")
      Dim TulTip As New System.Windows.Forms.ToolTip
      TulTip = Bnl_First.tlp
      TulTip.SetToolTip(obj, ket)
   End Sub

   Function CrText(ByVal t As String, ByVal tCr As String, ByVal ygKe As Integer) As String
      Dim separators() As String = {"" & tCr & ""} ', ".", "!", "?", ";", ":", " "}

      If t <> Nothing And (t Like "*" & tCr & "*") Then
         Dim words() As String = t.Split(separators, StringSplitOptions.RemoveEmptyEntries)
         Try
            Return words(ygKe)
         Catch
            Return "none"
         End Try
      Else
         Return ""
      End If

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
    
    Function tSt(ByVal t As Char, ByVal kali As Integer) As String
        Dim Rtt As String = ""
        For i As Integer = 0 To kali
            Rtt &= t
        Next
        Return Rtt
    End Function
End Module
