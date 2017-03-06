Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        My.Forms.Login.Show()
        Me.Close()
    End Sub
End Class