Imports System.IO
Public NotInheritable Class Spls


    Private Sub Spls_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


      Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        Copyright.Text = My.Application.Info.Copyright
    End Sub

   Private Sub Spls_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
      If e.Shift And e.Control And (e.KeyCode = Keys.F12 Or e.KeyCode = Keys.Space) And Ada_F12 = False Then Ada_F12 = True
      If e.KeyCode = Keys.Escape And Me.Tag = "about" Then Me.Dispose()
   End Sub


   Private Sub Spls_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If Me.Tag = "about" Then Me.Dispose()
    End Sub

    Private Sub Spls_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown,
            l_Nm_app_this.MouseDown,
            Copyright.MouseDown, Version.MouseDown

        If Me.Tag = "about" Then GeserForm(Me)
    End Sub
End Class
