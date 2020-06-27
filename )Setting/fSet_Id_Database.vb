Public Class fSet_Id_Database
    Dim tag_res As String
    Dim SdhLoad As Boolean = False
    Dim nm_tbl As String
    Sub Tampil(ByRef obj As Object, def_Net As String)
        If obj.name.ToString.ToUpper Like "*JALAN*" Then
            nm_tbl = "tJalan"
            key_jalan_Net = def_Net
        Else
            nm_tbl = "tBangunan"
            key_bangunan_Net = def_Net
        End If
        If Me.ShowDialog() = DialogResult.OK Then
            obj.tag = tag_res
            obj.text = "Id Map: " & vbCrLf & obj.tag.ToString

            SetProc("update tlink_vb6 set key_" & nm_tbl.Substring(1) & "_Net='" & tag_res & "'  ")

        End If
    End Sub
    Private Sub cmd_Apply_Click(sender As Object, e As EventArgs) Handles cmd_Apply.Click
        Me.DialogResult = DialogResult.OK
        SdhLoad = False
        Me.Dispose()
    End Sub
    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        SdhLoad = False
        Me.Dispose()
    End Sub
    Private Sub fSet_Id_Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetPosisiForm(Me)
        BukaGrid()
        SdhLoad = True

        Dim i As Integer = G.FindRow(IIf(nm_tbl = "tJalan", key_jalan_Net, key_bangunan_Net), 0, 0)
        If i > -1 Then G.Row = i : G_RowColChange(sender, e)
    End Sub
    Sub BukaGrid()
        Dim qs As String = "SELECT COLUMN_NAME as " & nm_tbl & " " &
                           "FROM INFORMATION_SCHEMA.COLUMNS " &
                           "WHERE TABLE_NAME = '" & nm_tbl & "' " &
                           "ORDER BY ORDINAL_POSITION "

        GetRecGrid(G, qs)
    End Sub
    Private Sub fSet_Id_Database_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        Me.MouseDown, pnl.MouseDown
        GeserForm(Me)
    End Sub

    Private Sub fSet_Id_Database_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        SetPosisiForm(Me)
        Me.Dispose()
    End Sub

    Private Sub G_DoubleClick(sender As Object, e As EventArgs) Handles G.DoubleClick
        l_idPilih.Text = G(G.Row, 0)
        cmd_Apply_Click(sender, e)
    End Sub


    Private Sub G_RowColChange(sender As Object, e As EventArgs) Handles G.RowColChange
        If Not SdhLoad Then Exit Sub
        tag_res = G(G.Row, 0)
        l_idPilih.Text = tag_res
    End Sub

    Private Sub pnl_Click(sender As Object, e As EventArgs) Handles pnl.Click

    End Sub
End Class