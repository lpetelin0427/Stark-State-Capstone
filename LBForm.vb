Public Class LBForm
    Private Sub LBForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LBDataset.Linebackers' table. You can move, or remove it, as needed.
        Me.LinebackersTableAdapter.Fill(Me.LBDataset.Linebackers)

    End Sub
End Class