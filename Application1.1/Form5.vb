Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.emp' table. You can move, or remove it, as needed.
        Me.EmpTableAdapter.Fill(Me.DatabaseDataSet.emp)

    End Sub
End Class