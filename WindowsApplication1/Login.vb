Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.Menu.Show()
        My.Forms.Login.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.Login.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
