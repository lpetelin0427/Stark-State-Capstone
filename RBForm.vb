Public Class RBForm
    Private Sub RBForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TopCollegeProspectsDataSet.Runningbacks' table. You can move, or remove it, as needed.
        Me.RunningbacksTableAdapter.Fill(Me.TopCollegeProspectsDataSet.Runningbacks)

    End Sub
End Class