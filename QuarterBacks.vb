Public Class QuarterBacks
    Private Sub QuarterBacks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.QuarterbacksTableAdapter1.Fill(Me.QBDataset.Quarterbacks)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

End Class