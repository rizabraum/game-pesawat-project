Public Class startForm

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        gameplayForm.Show()
        Me.Hide()
        Musik.PlayMusik()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Musik.PlayMusik()
    End Sub

End Class
