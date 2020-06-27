Module mForm


    Private Declare Function SendMessageW Lib "User32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    Private Declare Sub ReleaseCapture Lib "User32.dll" () 'Releases the mouse capture from a window in the current thread and restores normal mouse input processing. 
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1 ' the window message [look it up ;) ]
    Private Const HT_CAPTION As Integer = 2 ' Hit_Test: title bar (Caption)

    Sub GeserForm(ByVal Frm As Form)
        Frm.Cursor = Cursors.NoMove2D
        ReleaseCapture() 'Release mouse capture/restore normal mouse input processing
        SendMessageW(Frm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0) ' move this form (Me.hWnd)
        Frm.Cursor = Cursors.Default
        SetPosisiForm(Frm)
    End Sub

    Sub GeserObj(ByVal Obj As Object)
        ' Obj.Cursor = Cursors.NoMove2D
        ReleaseCapture() 'Release mouse capture/restore normal mouse input processing
        SendMessageW(Obj.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0) ' move this form (Me.hWnd)
        'Obj.Cursor = Cursors.Default
    End Sub

   Sub SetPosisiForm(ByVal frm As Form, Optional ket As String = "")
      If frm.WindowState = FormWindowState.Maximized Then Exit Sub 'frm.WindowState = FormWindowState.Normal : Application.DoEvents()
      SaveSetting(frm.Name & ket, "posisi", "frm.Left", frm.Left)
      SaveSetting(frm.Name & ket, "posisi", "frm.Top", frm.Top)
      SaveSetting(frm.Name & ket, "posisi", "frm.Width", frm.Width)
      SaveSetting(frm.Name & ket, "posisi", "frm.Height", frm.Height)
   End Sub

    Sub GetPosisiForm(ByVal frm As Form, Optional ket As String = "")
        Dim L, T, W, H As Integer
        L = GetSetting(frm.Name & ket, "posisi", "frm.Left", frm.Left)
        T = GetSetting(frm.Name & ket, "posisi", "frm.Top", frm.Top)
        W = GetSetting(frm.Name & ket, "posisi", "frm.Width", frm.Width)
        H = GetSetting(frm.Name & ket, "posisi", "frm.Height", frm.Height)

        frm.Left = L
        frm.Top = T
        frm.Width = W
        frm.Height = H
   End Sub

   Function GetIconFromBitmap(ByVal FileName As Bitmap) As Icon
      Using Bmp As New Bitmap(FileName)
         Return Icon.FromHandle(Bmp.GetHicon)
      End Using
   End Function

End Module
