Public Class DT
    Private Sub DT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTDataset.Defensive_Tackles' table. You can move, or remove it, as needed.
        Me.Defensive_TacklesTableAdapter.Fill(Me.DTDataset.Defensive_Tackles)
        'TODO: This line of code loads data into the 'DTDataset.Defensive_Tackles' table. You can move, or remove it, as needed.
    End Sub
End Class