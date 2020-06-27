
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO

'Imports System.Web.Script.Serialization
Imports CrystalDecisions.CrystalReports.Engine

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Imports DevExpress.XtraReports.UI
Module mKonek_Oledb
    Dim SqlCon As New SqlConnection
    Public cnn_Svr As New OleDb.OleDbConnection

   Function KonekConn(Optional TampilMsgError As Boolean = True) As Boolean
      If Bnl_First.Visible Then
         Bnl_First.Lconnect_1.Text = Prf.aServer & ", Try Connect ..."
         Bnl_First.LconnectAwal.Text = Prf.aServer & ", Try Connect ..."
         Bnl_First.LconnectAwal.Visible = True
      End If

      Dim connstring As String = "Provider=SQLOLEDB.1;Data Source=" & Prf.aServer & ";" _
                                   & "Persist Security Info=False;User ID=" & Prf.bLogin & ";" _
                                   & "Password=" & Prf.cPassword & ";Initial Catalog=Bnl"

      cnn_Svr.Close()
      Try
         cnn_Svr = New OleDb.OleDbConnection(connstring) : cnn_Svr.Open()
         If Bnl_First.Visible Then
            Bnl_First.Lconnect_1.Tag = Prf.aServer & "[Bnl]"
            Bnl_First.LconnectAwal.Visible = False
            Bnl_First.Lconnect_1.Text = Prf.aServer & "Connect ..."
         End If
         Return True
      Catch ex As Exception
         If Bnl_First.Visible Then Bnl_First.Lconnect_1.Text = Prf.aServer & "DisConnect !!"
         If TampilMsgError Then MsgBox(ex.Message) : Return False
      End Try
   End Function





   Function GetProc(ByVal Prc As String, Optional while_row As Boolean = False) As String
      GetProc = ""
      If KonekConn(False) = True Then
         Dim cmd As New OleDb.OleDbCommand

         cmd.CommandType = CommandType.StoredProcedure
         cmd = New OleDb.OleDbCommand(Prc, cnn_Svr)
         ' Dim dt As New Data.DataTable
         Dim dreader As System.Data.OleDb.OleDbDataReader
         Try : dreader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
         Catch ex As Exception : Return "error" : End Try

         Dim s As String = ""
         If dreader.HasRows = True Then

            If while_row Then
               Do While dreader.Read()
                  If s = "" Then
                     s &= dreader(0).ToString()
                  Else
                     s &= "|" & dreader(0).ToString()
                  End If
               Loop
            Else
               dreader.Read() : s &= dreader(0).ToString()
            End If
         End If
         GetProc = s.Trim

         cmd.Dispose()
         ' dt.Dispose()
         dreader.Close()
      End If
   End Function


   Function SetProc(ByVal Prc As String, Optional tmpilEror As Boolean = False) As Integer
        Dim Rtn As Integer = 0
        If Prc = "" Then Return 0
        'tmpilEror = True
        If KonekConn() = True Then
            Dim cmd As New OleDb.OleDbCommand

            cmd.CommandType = CommandType.StoredProcedure
            cmd = New OleDb.OleDbCommand(Prc, cnn_Svr)
            Try
                cmd.ExecuteNonQuery()
                Rtn = 0
            Catch
                If tmpilEror Then MsgBox(Err.Description)
                Rtn = Err.Number
            End Try
            cmd.Dispose()
            Return Rtn
        End If
    End Function



    Sub GetRecGrid(ByRef Grd As Object, ByVal qs As String, Optional ByRef jSon As String = "")
        If jSon <> "" Then
            Console.WriteLine(jSon)
            '   Grd.datasource = DeserializeDataTable(jSon)
        Else
            If KonekConn() = True Then
                Dim cmd As New OleDb.OleDbCommand
                Dim dt As New Data.DataTable

                cmd.CommandType = CommandType.TableDirect
                cmd = New OleDb.OleDbCommand(qs, cnn_Svr)
                dt = New Data.DataTable
                Try
                    dt.Load(cmd.ExecuteReader)
                    Grd.tag = "sibuk"
                    Grd.DataSource = dt
                    Grd.tag = ""
                Catch ex As Exception
                    MsgBox(ex.ToString() & "Error")
                End Try

                cmd.Dispose()
                dt = Nothing
            End If
        End If
    End Sub
    Function GetDt(ByVal qs As String) As Data.DataTable
        If KonekConn() = True Then
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New Data.DataTable

            cmd.CommandType = CommandType.TableDirect
            cmd = New OleDb.OleDbCommand(qs, cnn_Svr)
            dt = New Data.DataTable
            Try
                dt.Load(cmd.ExecuteReader)
                Return dt
            Catch ex As Exception
                MsgBox(ex.ToString() & "Error")
            End Try

            cmd.Dispose()
            dt = Nothing
            Return Nothing
        End If
    End Function
    Sub GetRec(ByRef Rec As Object, ByVal qs As String)
        If KonekConn() = True Then
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New Data.DataTable

            cmd.CommandType = CommandType.TableDirect
            cmd = New OleDb.OleDbCommand(qs, cnn_Svr)
            dt = New Data.DataTable
            Try
                dt.Load(cmd.ExecuteReader)
                Rec = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            cmd.Dispose()
            'dt.Dispose()
        End If
    End Sub

    Sub GetRecCombo(ByRef Cmb As ComboBox, dsply As String, ByVal qs As String)
        If KonekConn() = True Then
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New Data.DataTable

            cmd.CommandType = CommandType.TableDirect
            cmd = New OleDb.OleDbCommand(qs, cnn_Svr)
            dt = New Data.DataTable
            Try
                dt.Load(cmd.ExecuteReader)
                Cmb.DataSource = dt
                Cmb.DisplayMember = dsply
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            cmd.Dispose()
            'dt.Dispose()
        End If
    End Sub


   Sub GetRecRpt(ByRef Grd As ReportDocument, ByVal Qs As String)
      If KonekConn() = True Then
         Dim cmd As New OleDb.OleDbCommand
         Dim dt As New Data.DataTable

         cmd.CommandType = CommandType.TableDirect
         cmd = New OleDb.OleDbCommand(Qs, cnn_Svr)
         dt = New Data.DataTable
         Try
            dt.Load(cmd.ExecuteReader)
            Grd.SetDataSource(dt)
         Catch ex As Exception
            Debug.Print("")
         End Try

         cmd.Dispose()
         'dt.Dispose()
      End If
   End Sub

   Sub GetRecDev(ByRef Cmb As Object, ByVal qs As String)
      If KonekConn() = True Then
         Dim cmd As New OleDb.OleDbCommand
         Dim dt As New Data.DataTable

         cmd.CommandType = CommandType.TableDirect
         cmd = New OleDb.OleDbCommand(qs, cnn_Svr)
         dt = New Data.DataTable
         Try
            dt.Load(cmd.ExecuteReader)
            Cmb.DataSource = dt
            Cmb.DataAdapter = dt
            '     Cmb.DataMember = dsply
         Catch ex As Exception
            MsgBox(ex.Message)
         End Try

         '      cmd.Dispose()
         'dt.Dispose()
      End If
   End Sub
End Module
