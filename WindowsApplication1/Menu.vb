Public Class Menu
    Dim chicken() As Boolean = {False, False, False, False, False}
    Dim total As Integer = 0
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).Name = "Quantity"
        DataGridView1.Columns(1).Name = "Product Name"
        DataGridView1.Columns(2).Name = "Unit Price"
        DataGridView1.Columns(3).Name = "Amount"
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim myValue As Object
        myValue = InputBox("test", "yawa", 1)
        Label2.Text = myValue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adder(0, InputBox("pilaman", "gadi", 0))
    End Sub
    Private Sub adder(product As Integer, quantity As Integer)
        Select Case product
            Case 1
                adder("Drumstick", quantity, 45, chicken(product))
            Case 2
                adder("Wings", quantity, 35, chicken(product))
            Case 3
                adder("Thighs", quantity, 50, chicken(product))
            Case 4
                adder("Rice", quantity, 10, chicken(product))
            Case 0
                adder("Breast", quantity, 55, chicken(product))
        End Select
        chicken(product) = True
        DataGridView1.ClearSelection()
        total = 0
        For Each tester As DataGridViewRow In DataGridView1.Rows
            Dim s As String = tester.Cells.Item("Amount").Value
            s = s.Substring(1, s.Length - 1)
            total += CInt(s)
        Next
        Label2.Text = "P" + CStr(total)
    End Sub

    Private Sub adder(name As String, q As Integer, p As Integer, c As Boolean)
        Dim counter As Integer
        If c Then
            For Each tester As DataGridViewRow In DataGridView1.Rows
                If (tester.Cells.Item("Product Name").Value.Equals(name)) Then
                    DataGridView1.Rows(counter).Cells("Quantity").Value = CStr(q)
                    DataGridView1.Rows(counter).Cells("Amount").Value = "P" + CStr(q * p)
                Else
                    counter += 1
                End If
            Next
        Else
            DataGridView1.Rows.Add({q, name, "P" + CStr(p), "P" + CStr(p * q)})
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        adder(1, InputBox("How much will you order?", "Order Amount", 0))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        adder(3, InputBox("How much will you order?", "Order Amount", 0))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        adder(4, InputBox("How much will you order?", "Order Amount", 0))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        adder(2, InputBox("How much will you order?", "Order Amount", 0))
    End Sub
End Class