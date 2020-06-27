Module mStart

   Public Me_Path_And_Name As String

   Public Ada_F12 As Boolean = False
   Public AppNm As String = Application.ProductName.ToString

   Public Svr_Alamat As String
   Public Svr_Port As String
   Public Svr_Database As String
   Public Svr_User As String
   Public Svr_Password As String

   Public Kecep_Load_vb6 As Double

   Public Loc_Alamat As String
   Public Loc_Port As String
   Public Loc_Database As String
   Public Loc_User As String
   Public Loc_Password As String


   Public AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory()
   ' Public AlmDeviceIni As String = "C:\Program Files (x86)\EasyLink SDK\Device.ini"


   Public SedangClose As Boolean = False


End Module
