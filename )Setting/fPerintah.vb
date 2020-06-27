Imports System.ComponentModel

Public Class fPerintah
    Public Key_Net As String = ""
    Sub Tampil()
        Me.Width = 300 : Me.Height = 150
        Ck_Pin.Checked = True
    End Sub
    Sub Cmd_ToChild(cmdX As String)
        SetProc("update tLink_Vb6 set fparent='" & cmdX & "' ")
    End Sub
    Sub Ubah_data(sender As Object)
        RJ_First.pnl_Cap_Data.Tag = sender.name.ToString

        RJ_First.RJ_nmTbl = "t" & sender.name.ToString.Substring(8)
        RJ_First.btSearch.Text = "  Srch " & RJ_First.RJ_nmTbl & " [F3]"

        RJ_First.lJudul_Data_Rj.Text = sender.name.ToString.Substring(3)
        If sender.name.ToString = "bt_Data_Bangunan" Then
            RJ_First.G.DataSource = RJ_First.G_bng.DataSource
        Else
            RJ_First.G.DataSource = RJ_First.G_jln.DataSource
        End If
        GetGrd(RJ_First.G, RJ_First, RJ_First.RJ_nmTbl)
        RJ_First.G.Refresh()
        RJ_First.lData_Map.Text = "Link Map: " & sender.name.ToString.Substring(3)

        If RJ_First.RJ_nmTbl.ToUpper Like "*JALAN*" Then
            RJ_First.P_tunjuk.Location = New Point((RJ_First.bt_Data_Jalan.Location.X + RJ_First.bt_Data_Jalan.Width) - RJ_First.P_tunjuk.Width - 10, RJ_First.pnl_Cap_Data.Height - 5)
        Else
            RJ_First.P_tunjuk.Location = New Point((RJ_First.bt_Data_Bangunan.Location.X + RJ_First.bt_Data_Bangunan.Width) - RJ_First.P_tunjuk.Width - 10, RJ_First.pnl_Cap_Data.Height - 5)
        End If
    End Sub
    Private Sub tGetPerintah_TextChanged(sender As Object, e As EventArgs) Handles tGetPerintah.TextChanged
        Dim cmdX As String = tGetPerintah.Text : If cmdX = "sudah" Then Exit Sub

        cmdX = cmdX.Replace("`", "'")
        '----baru_update_untuk_report'
        If cmdX Like "baru_update_untuk_report|*" Then
            RJ_First.Set_Menu_report_Probolinggo()
            SetProc("update tLink_Vb6 set fChild='sudah' ") 'jika sudah di laksanakan, mk CIELD di SUDAH
            Exit Sub
        End If

        '----perintah dari CLIENT---
        If cmdX Like "CARINET_BANGUNAN|*" Then
            If Not (RJ_First.pnl_Cap_Data.Tag.ToString = "bt_Data_Bangunan") Then
                Ubah_data(RJ_First.bt_Data_Bangunan)
                'Threading.Thread.Sleep(100)
            End If
            Dim Ky_Bng As String = GetProc("select Key_Bangunan_Net from tLink_Vb6")
            Dim nBang As Integer = Val(cmdX.Replace("CARINET_BANGUNAN|", ""))
            Dim ColKe As Integer = RJ_First.G.get_ColIndex(Ky_Bng)
            If ColKe > 0 Then
                Dim nRow As Integer = RJ_First.G.FindRow(nBang, 0, ColKe)
                If nRow = -1 Then nRow = RJ_First.G.FindRow(FrMny(nBang), 0, ColKe)
                If nRow > -1 Then
                    RJ_First.G.Row = nRow
                    RJ_First.TampilKeDetil()
                    SetProc("update tLink_Vb6 set fChild='sudah' ") 'jika sudah di laksanakan, mk Parent di SUDAH
                End If
            End If
            Exit Sub
        End If
        If cmdX Like "CARINET_JALAN|*" Then
            If Not (RJ_First.pnl_Cap_Data.Tag.ToString = "bt_Data_Jalan") Then
                Ubah_data(RJ_First.bt_Data_Jalan)
                'Threading.Thread.Sleep(100)
            End If

            Dim Ky_Jln As String = GetProc("select Key_Jalan_Net from tLink_Vb6")
            Dim nRuas As Integer = Val(cmdX.Replace("CARINET_JALAN|", ""))
            Dim ColKe As Integer = RJ_First.G.get_ColIndex(Ky_Jln)
            If ColKe > 0 Then
                Dim nRow As Integer = RJ_First.G.FindRow(nRuas, 0, ColKe)
                If nRow = -1 Then nRow = RJ_First.G.FindRow(FrMny(nRuas), 0, ColKe)
                If nRow > -1 Then
                    RJ_First.G.Row = nRow
                    RJ_First.TampilKeDetil()
                    SetProc("update tLink_Vb6 set fChild='sudah' ") 'jika sudah di laksanakan, mk Parent di SUDAH
                End If
            End If
            Exit Sub
        End If
        '----perintah dari CLIENT---

    End Sub
    Private Sub fPerintah_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tInterval.Value = TkeyGet(Me.Name & tInterval.Name, tInterval.Value)
        Me.Width = 1 : Me.Height = 1
        Tmr.Start()
    End Sub

    Private Sub fPerintah_Activated() Handles Me.Activated
        Me.Width = 300 : Me.Height = 150
    End Sub
    Private Sub fPerintah_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If Ck_Pin.Checked = True Then Exit Sub
        Me.Width = 1 : Me.Height = 1
    End Sub
    Private Sub fPerintah_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        TkeySet(Me.Name & tInterval.Name, tInterval.Value)
    End Sub
    Private Sub tSetPerintah_TextChanged(sender As Object, e As EventArgs) Handles tSetPerintah.TextChanged
        SetProc("update tLink_Vb6 set fParent='" & tSetPerintah.Text & "' ")
    End Sub
    Private Sub Tmr_Tick(sender As Object, e As EventArgs) Handles Tmr.Tick
        If Val(Tmr.Tag) > 0 Then
            Tmr.Tag = Val(Tmr.Tag) - 1
            Me.Size = New Point(333, 155)
        Else
            Tmr.Tag = 0
            If Ck_Pin.Checked = False Then Me.Size = New Point(0, 0)
        End If

        If SedangClose = True Then Tmr.Stop() : Exit Sub
        klp.BackColor = IIf(klp.BackColor = Color.White, Color.Red, Color.White)
        Application.DoEvents()
        tGetPerintah.Text = GetProc("select top 1 fChild from tLink_Vb6")

        Dim Key_Jalan As String = GetProc("select key_jalan_Net + ' | '+ key_jalan_Vb6 from tLink_Vb6")
        L_id.Tag = Key_Jalan
        L_id.Text = "Id Map: " & Key_Jalan
    End Sub


    Private Sub tInterval_TextChanged(sender As Object, e As EventArgs) Handles tInterval.TextChanged
        Tmr.Stop()
        Try : Tmr.Interval = tInterval.Value
        Catch : End Try
        tInterval.Value = Tmr.Interval
        Tmr.Start()
    End Sub

    Private Sub fPerintah_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        Me.MouseDown, Label1.MouseDown, Label2.MouseDown, klp.MouseDown
        fPerintah_Activated()
        GeserForm(Me)
    End Sub

    Private Sub fPerintah_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Tmr.Tag = 10
    End Sub

    Private Sub fPerintah_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class