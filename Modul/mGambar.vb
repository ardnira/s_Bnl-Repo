Imports System.Data.SqlClient
Imports System.IO

Module mGambar
    Sub simpanGambar(ByRef Gx As Object)
        If Gx.Image Is Nothing Then MsgBox("Maaf,Gambar Masih Kosong....", MsgBoxStyle.Critical, "Warning") : Exit Sub

        Dim Sqx As String = IIf(GetProc("select top 1 namaperusahaan from tprofile") = "",
                                         "Insert Into tProfile(Logo) Values (@Logo)",
                                         "update tProfile set Logo=@Logo")

        If Not KonekConn() Or Gx.Tag = "" Then Exit Sub

        Dim bytes As Byte() = File.ReadAllBytes(Gx.Tag.ToString)

        Dim constr As String = "Data Source=" & Prf.aServer & ";Initial Catalog=bnl;Integrated Security=true"
        Using conn As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand(Sqx, conn)
                cmd.Parameters.AddWithValue("@Logo", bytes)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
    End Sub

    Sub TampilGambar(ByRef Gx As Object)
        If KonekConn() = True Then
            'Dim cmd As New SqlCommand("select top 1 logo from tProfile", conC)
            Dim cmd As New OleDb.OleDbCommand("select top 1 logo from tProfile", cnn_Svr)
            Try
                Gx.Image = Image.FromStream(New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte())))
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Module
