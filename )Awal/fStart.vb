
Imports System.IO
Imports System.Collections
Public Class fStart
    Dim Lanjutkan As Boolean = False
   Dim sdhLoad As Boolean = False


   Private Sub fStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Height = 33 : Me.Width = 200
      Threading.Thread.Sleep(1000)

      sdhLoad = True
   End Sub
   Private Sub fStart_Shown(sender As Object, e As EventArgs) Handles Me.Shown
      If CekStart() = True Then Lanjutkan = True
      Do While Lanjutkan = False
         Application.DoEvents()
         Me.Height = 150 : Me.Width = 450
      Loop
      Do While Ada_F12 = True
         Application.DoEvents()
         Me.Height = 150 : Me.Width = 450
         Me.Text = "Set Server ..."
      Loop

      Bnl_First.Show()
      Me.Hide()
   End Sub

   Function CekStart(Optional tmplError As Boolean = False) As Boolean
      Me.Text = "Load Server ..." : Application.DoEvents()
      Prf.aServer = GetSetting("bnl_first", "vServer", "Text", Prf.aServer)
      Prf.bLogin = GetSetting("bnl_first", "vLogin", "Text", Prf.bLogin)
      Prf.cPassword = GetSetting("bnl_first", "vPassword", "Text", Prf.cPassword)
      tServer.Text = Prf.aServer
      tLogin.Text = Prf.bLogin
      tPassword.Text = Prf.cPassword
      Application.DoEvents()

      Dim rslt As Boolean = KonekConn(False)
      If rslt = False Then
         Me.Text = "Server Gagal !!! " : Application.DoEvents()
         If tmplError Then MsgBox("Server tidak di temukan")
      Else
         Me.Text = "Set Server ..." : Application.DoEvents()
      End If
      Return rslt
   End Function
   Private Sub btApply_Click(sender As Object, e As EventArgs) Handles btApply.Click
      SaveSetting("bnl_first", "vServer", "Text", tServer.Text)
      SaveSetting("bnl_first", "vLogin", "Text", tLogin.Text)
      SaveSetting("bnl_first", "vPassword", "Text", tPassword.Text)

      If CekStart(True) = False Then Exit Sub

      Application.DoEvents()
      Threading.Thread.Sleep(200)
      Application.DoEvents()

      tmr_f12.Stop()
      Ada_F12 = False
      Lanjutkan = True
   End Sub
   Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        End
    End Sub
    Private Sub fStart_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Not e.Control And e.KeyCode = Keys.F12 Then
            btApply_Click(sender, e)
        End If
    End Sub

    Private Sub tmr_f12_Tick(sender As Object, e As EventArgs) Handles tmr_f12.Tick
        l_f12.Text = Ada_F12
    End Sub


End Class