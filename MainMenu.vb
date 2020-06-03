Public Class MainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles QBButton.Click
        Dim QB As New QuarterBacks()
        QB.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        Dim aboutFrm As New AboutTheCreator()
        aboutFrm.Show()
    End Sub

    Private Sub WorksCitedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorksCitedToolStripMenuItem.Click
        Dim worksFrm As New WorksCited()
        worksFrm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RBButton.Click
        Dim RBForm As New RBForm()
        RBForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DTButton.Click
        Dim DTForm As New DT()
        DTForm.Show()
    End Sub

    Private Sub WRButton_Click(sender As Object, e As EventArgs) Handles WRButton.Click
        Dim WRForm As New WRForm()
        WRForm.Show()
    End Sub

    Private Sub DBButton_Click(sender As Object, e As EventArgs) Handles DBButton.Click
        Dim DBForm As New DBForm()
        DBForm.Show()
    End Sub

    Private Sub LBButton_Click(sender As Object, e As EventArgs) Handles LBButton.Click
        Dim LBForm As New LBForm()
        LBForm.Show()
    End Sub
End Class
