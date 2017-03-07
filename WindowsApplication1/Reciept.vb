Public Class Reciept
    Public amountT As Integer
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Forms.Menu.Button7_Click(sender, e)
        My.Forms.Menu.Show()
        Close()
    End Sub
    Private Sub Reciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DataGridView1.ColumnCount = 4
        'DataGridView1.Columns(0).Name = "Quantity"
        'DataGridView1.Columns(1).Name = "Product Name"
        'DataGridView1.Columns(2).Name = "Unit Price"
        'DataGridView1.Columns(3).Name = "Amount"
        'For Each row As DataGridViewRow In My.Forms.Menu.x
        '    Dim text As String
        '    For Each cell As DataGridViewCell In row.Cells
        '        DataGridView1.Cells(cell.ColumnIndex).Value = cell.Value
        '    Next cell
        'Next
        'For Each row As DataGridViewRow In My.Forms.Menu.x
        '    DataGridView1.Rows.Add(row)
        'Next

        Dim sourceGrid As DataGridView = My.Forms.Menu.DataGridView1
        Dim targetRows = New List(Of DataGridViewRow)
        For Each sourceRow As DataGridViewRow In sourceGrid.Rows
            If (Not sourceRow.IsNewRow) Then
                Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)
                For Each cell As DataGridViewCell In sourceRow.Cells
                    targetRow.Cells(cell.ColumnIndex).Value = cell.Value
                Next
                targetRows.Add(targetRow)
            End If
        Next
        DataGridView1.Columns.Clear()
        For Each column As DataGridViewColumn In sourceGrid.Columns
            DataGridView1.Columns.Add(CType(column.Clone(), DataGridViewColumn))
        Next
        DataGridView1.Rows.AddRange(targetRows.ToArray())

        Label2.Text = My.Forms.Menu.Label2.Text
        Label4.Text = "P" + CStr(amountT)
        Dim value As Integer = CInt(Label2.Text.Substring(1, Label2.Text.Length - 1))
        Label6.Text = "P" + CStr(amountT - value)
    End Sub
End Class