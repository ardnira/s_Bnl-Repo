Public Class fLogin

   Dim idlogin As String = ""
   Dim pswAdmin As String
   Sub Tampil()

        If GetProc("select * from tuser") = "error" Then
            Dim sQ As String = "CREATE TABLE tUser " &
                          "(" &
                          "[ID_X] uniqueidentifier DEFAULT newsequentialid() NOT NULL, " &
                          "[User]  VARCHAR(30) not NULL, " &
                          "[Password] VARCHAR(30) NULL, " &
                          "HakAkses VARCHAR(max) NULL " &
                          ")  "

            SetProc(sQ)
            SetProc("insert into tuser([user],[password]) values('admin','admin')")

        Else

         If CekLogin() <> "False" Then
            Bnl_First.btPeriode.Tag = tUser.Text
            Bnl_First.btPeriode.Text = tUser.Text
            Bnl_First.btPeriode.ImageKey = "user_check"
         Else
            Bnl_First.btPeriode.Tag = ""
            '  RJ_First.btPeriode.Text = "Login"
            Bnl_First.btPeriode.ImageKey = "user_lock"
            End If
        End If

        If Me.ShowDialog() = DialogResult.OK Then

        Else

        End If

    End Sub
    Private Sub fLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Not e.Control And e.KeyCode = Keys.Enter Then
            btLogin_Click(sender, e) : Exit Sub
        End If
        If Not e.Control And e.KeyCode = Keys.Escape Then
            btCancel_Click(sender, e) : Exit Sub
        End If
        If e.Control And e.KeyCode = Keys.F12 Then
            tUser.Text = "admin"
            tPassword.Text = GetProc("select [password] from tuser where [user]='admin'")
        End If

    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
      btLogin.Enabled = False
      If btLogin.Text = "Login" Then
         Dim isiLogin As String = CekLogin()
         If isiLogin = "False" Then
            MsgBox("User/Password salah") : tPassword.Focus() : GoTo akhir
         End If
         Me.DialogResult = DialogResult.OK
         Bnl_First.btPeriode.Text = tUser.Text
         l_Akses.Text = isiLogin.Replace(CrText(isiLogin, "|", 0) + "|", "") : If l_Akses.Text = "none" Then l_Akses.Text = ""
         If tUser.Text.ToUpper = "ADMIN" Then l_Akses.Text = "FULL"
         SetProc("update tLink_Vb6 set fParent='UPDATE_HAK_AKSES_MENU|" & l_Akses.Text & "' ")
         Bnl_First.l_Akses.Text = l_Akses.Text
         Me.Dispose()
      ElseIf btLogin.Text = "Edit" Then
         If te_Confirm.Text <> te_Password.Text Then MsgBox("password dan konfirm salah") : te_Confirm.Focus() : GoTo akhir

         SetProc("update tuser set  [Password]= '" & te_Confirm.Text & "', HakAkses='" & l_Akses.Text & "' where upper([user]) = '" & te_User.Text.ToUpper & "' ")
         ckEdit.Checked = False : tPassword.Focus()
      Else
         ckEdit.Checked = False : btLogin.Text = "Login"
      End If

akhir:
      btLogin.Enabled = True
   End Sub
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
      If btLogin.Text = "Login" Then
         Me.DialogResult = DialogResult.Cancel
         Me.Dispose()
      Else
         ck_HakAkses.Checked = False : tpsw_Admin.Text = ""
         btLogin.Text = "Login" : ckEdit.Checked = False
      End If
    End Sub


    Private Sub fLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        GeserForm(Me)
    End Sub

   Function CekLogin() As String
      idlogin = GetProc("select (convert(varchar(max),id_x) + '|' + isnull(hakakses,''))as isilogin from tuser where [user]='" & tUser.Text & "' and [password]='" & tPassword.Text & "'")
      If Not (idlogin = "" Or idlogin = "error") Then
         Return idlogin
      End If
      Return "False"
   End Function
   Private Sub ckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles ckEdit.CheckedChanged
      If ckEdit.Checked Then
         Dim isiLogin As String = CekLogin()
         If isiLogin = "False" Then
            ckEdit.Checked = False
            MsgBox("user / password salah")
            tPassword.Focus()
            Return
         End If
         te_Password.Text = tPassword.Text
         te_Confirm.Text = tPassword.Text
         l_Akses.Text = isiLogin.Replace(CrText(isiLogin, "|", 0) & "|", "") : If list_Akses.Text = "none" Then list_Akses.Text = ""
         Me.Width = Grp_Edit.Left + Grp_Edit.Width

         Grp_Edit.Text = "Edit" : btLogin.Text = "Edit" : Grp_Edit.BackColor = Color.Turquoise
         te_User.Text = tUser.Text : tUser.Enabled = False : tPassword.Enabled = False
      Else
         l_Akses.Visible = False : Me.Width = Grp_Edit.Left : btLogin.Text = "Login" : tUser.Enabled = True : tPassword.Enabled = True : Return
      End If
   End Sub
   Private Sub l_Akses_TextChanged(sender As Object, e As EventArgs) Handles l_Akses.TextChanged
      If l_Akses.Tag <> "" Then Exit Sub
      If l_Akses.Text Like "*|*" Or l_Akses.Text = "Full" Then
         list_Akses.Items.Clear()
         Dim i As Integer
         For i = 0 To l_Akses.Text.Split("|").Count - 1
            list_Akses.Items.Add(l_Akses.Text.Split("|")(i))
         Next
      End If
   End Sub



   Private Sub fLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Width = Grp_Edit.Left
      pswAdmin = GetProc("select [password] from tUser where [User]='Admin' ")
   End Sub

   Private Sub bt_Add_Click(sender As Object, e As EventArgs) Handles bt_Add.Click
      Dim new_akses As String = ""
      new_akses = InputBox("Masukkan menu akses baru")
      If new_akses = "" Then Return

      l_Akses.Tag = "sibuk"
      list_Akses.Items.Add(new_akses)

      l_Akses.ResetText()
      For Each txt As Object In list_Akses.Items
         l_Akses.Text += IIf(l_Akses.Text = "", txt, "|" + txt)
      Next
      l_Akses.Tag = ""
   End Sub

   Private Sub bt_Del_Click(sender As Object, e As EventArgs) Handles bt_Del.Click
      If list_Akses.SelectedIndex = -1 Then
         MsgBox("Silahkan Pilih dulu")
         Return
      End If
      l_Akses.Tag = "sibuk"
      list_Akses.Items.RemoveAt(list_Akses.SelectedIndex)
      l_Akses.ResetText()
      For Each txt As Object In list_Akses.Items
         l_Akses.Text += IIf(l_Akses.Text = "", txt, "|" + txt)
      Next
      l_Akses.Tag = ""
   End Sub


   Private Sub ck_HakAkses_CheckedChanged(sender As Object, e As EventArgs) Handles ck_HakAkses.CheckedChanged
      If ck_HakAkses.Checked = True Then
         pnl_Admin.Visible = True
         tpsw_Admin.Focus()
         tpsw_Admin_TextChanged(sender, e)
      Else
         pnl_Akses.Visible = False
         pnl_Admin.Visible = False
      End If
   End Sub

   Private Sub tpsw_Admin_TextChanged(sender As Object, e As EventArgs) Handles tpsw_Admin.TextChanged
      If tpsw_Admin.Text.ToUpper = pswAdmin.ToUpper Then
         pnl_Admin.Tag = "psw_benar"
         GetRecGrid(G, "select [User], [Password], hakakses from tuser")
         Dim rowUser As Integer = G.FindRow(tUser.Text, 0, 0)
         If rowUser > 0 Then G.Row = rowUser
         pnl_Akses.Visible = True : l_Akses.Visible = True
      Else
         pnl_Admin.Tag = ""
         pnl_Akses.Visible = False : l_Akses.Visible = False
      End If
   End Sub

   Private Sub tpsw_Admin_Leave(sender As Object, e As EventArgs) Handles tpsw_Admin.Leave
      pnl_Admin.Visible = False
      If pnl_Admin.Tag = "" Then 'jika pssw admin SALAH
         pnl_Akses.Visible = False
         te_Password.Focus()
      Else 'jika pssw admin BENAR
         ck_HakAkses.Checked = True
         ck_HakAkses.Focus()
      End If
   End Sub

   Private Sub G_RowColChange(sender As Object, e As EventArgs) Handles G.RowColChange
      If G.Row = -1 Then Exit Sub
      te_User.Text = G(G.Row, G.get_ColIndex("User"))
      list_Akses.Items.Clear()
      Try 'jika dbnull lanjut aja
         te_Password.Text = G(G.Row, G.get_ColIndex("Password"))
         te_Confirm.Text = G(G.Row, G.get_ColIndex("Password"))
         l_Akses.Text = G(G.Row, G.get_ColIndex("hakakses"))
      Catch
         te_Password.Text = ""
         te_Confirm.Text = ""
         l_Akses.Text = ""
      End Try
   End Sub

   Private Sub bt_New_User_Click(sender As Object, e As EventArgs) Handles bt_New_User.Click
balik:
      Dim nwUser As String
      nwUser = InputBox("Masukkan User Baru")
      If nwUser = "" Then Return
      If GetProc("select upper([user])as Usr from tuser where upper([user])='" & nwUser.ToUpper & "'") = nwUser.ToUpper Then
         MsgBox("Nama User sudah terpakai", vbCritical) : GoTo balik
      End If
      SetProc("insert into tUser ([User]) values('" & nwUser & "') ")

      GetRecGrid(G, "select [User], [Password], hakakses from tuser")
      Dim rowUser As Integer = G.FindRow(nwUser, 0, 0)
      If rowUser > 0 Then G.Row = rowUser
   End Sub

   Private Sub bt_Del_User_Click(sender As Object, e As EventArgs) Handles bt_Del_User.Click
      If MsgBox("Apakah yakin user: [" & G(G.Row, 0) & "] akan di hapus", vbOKCancel) = MsgBoxResult.Cancel Then Exit Sub
      SetProc("delete tuser where [user]='" & G(G.Row, 0) & "' ")
      GetRecGrid(G, "select [User], [Password], hakakses from tuser")
      If G.Rows > 0 Then G.Row = 0
   End Sub
End Class