Public Class DBForm
    Private Sub DBForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataset.Defensive_Backs' table. You can move, or remove it, as needed.
        Me.Defensive_BacksTableAdapter.Fill(Me.DBDataset.Defensive_Backs)

    End Sub
End Class