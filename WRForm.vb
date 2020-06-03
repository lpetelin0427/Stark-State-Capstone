Public Class WRForm
    Private Sub WRForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WRDataset.Wide_Receivers' table. You can move, or remove it, as needed.
        Me.Wide_ReceiversTableAdapter.Fill(Me.WRDataset.Wide_Receivers)

    End Sub
End Class