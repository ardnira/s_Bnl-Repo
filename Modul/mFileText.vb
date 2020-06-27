Module mFileText
   Function NmFileNya(ByVal ALamatFile As String) As String
      Return My.Computer.FileSystem.GetFileInfo(ALamatFile).Name()
   End Function
   Function NmFolderNya(ByVal ALamatFile As String) As String
      Return My.Computer.FileSystem.GetFileInfo(ALamatFile).DirectoryName
   End Function
   Sub CopyFileRplace(ByVal flDari As String, ByVal flTujuan As String)
      My.Computer.FileSystem.CopyFile(flDari, flTujuan, True)
   End Sub
End Module
