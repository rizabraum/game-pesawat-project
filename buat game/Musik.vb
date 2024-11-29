Module Musik
    Private player As New System.Media.SoundPlayer(My.Resources.musik)

    Public Sub PlayMusik()
        player.PlayLooping()
    End Sub

    Public Sub restartMusik()
        player.Stop()
        player.PlayLooping()
    End Sub

    Public Sub StopMusik()
        player.Stop()
    End Sub

End Module