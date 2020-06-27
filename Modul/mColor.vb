Module mColor
   Public pLc1 As New Label
   Public pLc2 As New Label
   Public pLc3 As New Label
   Public pLc4 As New Label

   Public Function RGBToLong(Red As Integer, Green As Integer, Blue As Integer)
      RGBToLong = RGB(Red, Green, Blue)
   End Function

   Function wrn(ke As Integer) As Object
      If ke = 1 Then Return pLc1.BackColor
      If ke = 2 Then Return pLc2.BackColor
      If ke = 3 Then Return pLc3.BackColor
      If ke = 4 Then Return pLc4.BackColor
   End Function

End Module
