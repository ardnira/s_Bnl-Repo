Imports System.ComponentModel

Imports System.IO
Imports System.Collections

Public Class fServer
    Dim thm() As String = {"Guna", "Alizarin", "Carrot", "SunFlower", "Amethyst", "FeterRiver", "Emerald", "GreenSea",
                             "Turquoise", "WetAsphalt", "Red", "Pink", "Indigo", "Blue", "LightBlue", "Cyan", "Purple",
                             "DeepPurple", "Teal", "Green", "LightGreen", "Lime", "Yellow", "Ember", "Orange",
                             "DeepOrange"}

    Dim tmpil_awal_saja As Boolean = False
    Sub TampilAwal_saja()
        Me.FormBorderStyle = FormBorderStyle.None
        grp.Visible = False : btServer.Visible = False : btCancel.Visible = False
        tmpil_awal_saja = True
        Me.Show()
    End Sub
    Private Sub FServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      'If tmpil_awal_saja = True Then
      '    Me.Size = New Point(2, 2) : Exit Sub
      'End If

      Me.FormBorderStyle = FormBorderStyle.Sizable
        GetPosisiForm(Me)
        Me.Location = New Point(11, 11)
        Me.Size = New Point(533, 266) : Exit Sub
    End Sub
    Private Sub FServer_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Get_Server_Dan_Local()

      If Bnl_First.Lconnect_1.Text <> "Try Connect 1 ...   " Then

      End If
      Setgrid_Guna()
   End Sub

   Private Sub BtServer_Click(sender As Object, e As EventArgs) Handles btServer.Click
      Set_Server_Dan_Local()
      Bnl_First.TryKonek_DuaDatabase()
      Me.Dispose()
   End Sub






   Sub Get_Server_Dan_Local()
      Svr_Alamat = "LocalHost"
      Svr_Database = "bnl"
      Svr_User = "sa"
      Svr_Password = "indraari"

      Svr_Alamat = GetSetting(AppNm, "setServer", "Svr_Alamat", Svr_Alamat)
      Svr_User = GetSetting(AppNm, "setServer", "Svr_User", Svr_User)
      Svr_Password = GetSetting(AppNm, "setServer", "Svr_Password", Svr_Password)

      tServer_Alamat.Text = Svr_Alamat
      tServer_Database.Text = Svr_Database
      tServer_User.Text = Svr_User
      tServer_Password.Text = Svr_Password
   End Sub

   Public Sub Set_Server_Dan_Local()
      Svr_Alamat = tServer_Alamat.Text
      Svr_Database = tServer_Database.Text
      Svr_User = tServer_User.Text
      Svr_Password = tServer_Password.Text

      SaveSetting(AppNm, "setServer", "Svr_Alamat", Svr_Alamat)
      SaveSetting(AppNm, "setServer", "Svr_Database", Svr_Database)
      SaveSetting(AppNm, "setServer", "Svr_User", Svr_User)
      SaveSetting(AppNm, "setServer", "Svr_Password", Svr_Password)
   End Sub

   Private Sub BtCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
      Me.Dispose()
   End Sub

   Private Sub FServer_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, grp.MouseDown
      GeserForm(Me)
   End Sub

   Private Sub FServer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
      If tmpil_awal_saja = True Then Exit Sub
      SetPosisiForm(Me)
   End Sub



   Sub Setgrid_Guna()
      gn.Rows.Add() : gn.Rows.Add() : Lst.Items.Clear()

      For Each Vlu As String In thm : Console.WriteLine(Vlu) : Lst.Items.Add(Vlu) : Next

      'Dim wrn_ke As Integer = Val(GetINI("net_set_theme", "warna_ke", Path.GetDirectoryName(Vb6_Path_And_Name) & "\MapMain.ini"))
      'MsgBox(wrn_ke)
      ' Lst.SelectedIndex = wrn_ke
   End Sub
   Private Sub Lst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst.SelectedIndexChanged
      gn.Theme = Lst.SelectedIndex
      ' Me.Text = gn.ThemeStyle.ToString

      lc1.BackColor = gn.ThemeStyle.HeaderStyle.BackColor
      lc2.BackColor = gn.ThemeStyle.RowsStyle.SelectionBackColor
      lc3.BackColor = gn.ThemeStyle.AlternatingRowsStyle.BackColor
      lc4.BackColor = gn.ThemeStyle.RowsStyle.BackColor

      pLc1.BackColor = lc1.BackColor
      pLc2.BackColor = lc2.BackColor
      pLc3.BackColor = lc3.BackColor
      pLc4.BackColor = lc4.BackColor

      Me.BackColor = lc1.BackColor

      Lthm.Text = Lst.SelectedIndex
      'SetINI("net_set_theme", "warna_ke", Lthm.Text, Path.GetDirectoryName(Vb6_Path_And_Name) & "\MapMain.ini")

      Save_wrn_toVb6(lc1, 1)
      Save_wrn_toVb6(lc2, 2)
      Save_wrn_toVb6(lc3, 3)
      Save_wrn_toVb6(lc4, 4)

      ' Bnl_First.Set_Theme()
   End Sub
   Sub Save_wrn_toVb6(obj As Object, yg_ke As Integer)
        Dim rgbToLng = RGBToLong(obj.BackColor.R, obj.BackColor.G, obj.BackColor.B)
      'SetINI("net_set_theme", "warna_vb6_" & yg_ke.ToString, rgbToLng, Path.GetDirectoryName(Vb6_Path_And_Name) & "\MapMain.ini")
   End Sub

End Class