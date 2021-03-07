Public Class adminpanel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dialog1.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        changecaptions.Show()
    End Sub

    Private Sub adminpanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.destructivemodeenabled = "Yes" Then
            Button3.Text = "Disable destructive mode (bit bugged)"
        Else
            Button3.Text = "Enable destructive mode (bit bugged)"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If My.Settings.destructivemodeenabled = "Yes" Then
            My.Settings.destructivemodeenabled = "No"
            Form9.Show()
        Else
            Dialog2.Show()
        End If
    End Sub
End Class