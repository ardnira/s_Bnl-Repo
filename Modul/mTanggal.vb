Module mTanggal
   Sub TglBlnLaluDanTglNow(ByRef tG1 As DateTimePicker, ByRef tG2 As DateTimePicker)
      tG2.Value = Today

      If Now.Month = 1 Then
         tG1.Value = New DateTime(Now.Year - 1, 12, 1)
      Else
         If Now.Day = 1 Then
            tG1.Value = New DateTime(Now.Year, Now.Month - 1, 1)
         Else
            Dim tglAkr As Date
            Dim NowD As Int16
            tglAkr = DateSerial(Now.Year, Now.Month, 0)
            NowD = Now.Day
            If Now.Day > tglAkr.Day Then NowD = tglAkr.Day
            tG1.Value = New DateTime(Now.Year, Now.Month - 1, NowD)
         End If
      End If
   End Sub

   Sub JadikanAwalJamDanAkhirJam(ByRef tglA As DateTimePicker, ByRef tglB As DateTimePicker)
      tglA.Value = New DateTime(tglA.Value.Year, tglA.Value.Month, tglA.Value.Day, 0, 0, 0)
      tglB.Value = New DateTime(tglB.Value.Year, tglB.Value.Month, tglB.Value.Day, 23, 59, 0)
   End Sub
End Module
