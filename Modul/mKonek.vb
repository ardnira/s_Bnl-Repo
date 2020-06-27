Imports System.Data.OleDb
Imports ADODB
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module mKonek
   Public Prf As New cProfile
   Public Conn As New OleDb.OleDbConnection
   Public conC As New SqlConnection

   Public vMdi As Boolean
   Public SedangNgeset As Boolean

   Sub GetcProfile()
      Try
         Prf.dNamaUsaha = GetProc("select top 1 NamaPerusahaan from tProfile") ' GetSetting("bnl_first", "vNamaUsaha", "Text", tNamaUsaha.Text)
         Prf.eAlamat = GetProc("select top 1 Alamat from tProfile") 'GetSetting("bnl_first", "vAlamat", "Text", tAlamat.Text)
         Prf.fKontak = GetProc("select top 1 Kontak from tProfile") 'GetSetting("bnl_first", "vKontak", "Text", tKontak.Text)
         Prf.gEmail = GetProc("select top 1 Email from tProfile") 'GetSetting("bnl_first", "vEmail", "Text", tEmail.Text)
      Catch ex As Exception
         'fStart.ShowDialog()
      End Try
   End Sub


   Public Function DeserializeDataTable(json As String) As DataTable
        'If Left(Trim(json), 1) <> "[" Then json = "[" & json & "]"
        Dim dt As DataTable
        Try
            dt = TryCast(JsonConvert.DeserializeObject(json, (GetType(DataTable))), DataTable)
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function




End Module
