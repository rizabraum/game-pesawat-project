Public Class gameplayForm
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0

    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        MoveRoad()
        AdjustSpeed()
        Label2.Text = "Speed: " & speed
        If CheckCollision() Then
            StopMusik()
            EndGame()
        End If
    End Sub

    Private Sub MoveRoad()
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
    End Sub

    Private Sub AdjustSpeed()
        Select Case score
            Case > 100
                speed = 9
            Case > 50
                speed = 7
            Case > 30
                speed = 6
            Case > 10
                speed = 5
            Case Else
                speed = 3
        End Select
    End Sub

    Private Function CheckCollision() As Boolean
        Return plane.Bounds.IntersectsWith(race1.Bounds) OrElse
               plane.Bounds.IntersectsWith(race2.Bounds) OrElse
               plane.Bounds.IntersectsWith(race3.Bounds) OrElse
               plane.Bounds.IntersectsWith(race4.Bounds) OrElse
               plane.Bounds.IntersectsWith(race5.Bounds)
    End Function

    Private Sub EndGame()
        Button1.Visible = True
        Label1.Visible = True
        Label3.Visible = True
        RaceMover1.Stop()
        RaceMover2.Stop()
        RaceMover3.Stop()
        RaceMover4.Stop()
        RaceMover5.Stop()
        RoadMover.Stop()
    End Sub

    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeGame()
    End Sub

    Private Sub InitializeGame()

        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
        Button1.Visible = False
        Label1.Visible = True
        Label3.Visible = False
        Label1.Text = "Score: 0"

        RaceMover1.Start()
        RaceMover2.Start()
        RaceMover3.Start()
        RaceMover4.Start()
        RaceMover5.Start()
        RoadMover.Start()
    End Sub

    Private Sub gameplayForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            RightSide.Start()
        ElseIf e.KeyCode = Keys.Left Then
            LeftSide.Start()
        End If
    End Sub

    Private Sub RightSide_Tick(sender As Object, e As EventArgs) Handles RightSide.Tick
        If plane.Location.X < 650 Then
            plane.Left += 10
        End If
    End Sub

    Private Sub LeftSide_Tick(sender As Object, e As EventArgs) Handles LeftSide.Tick
        If plane.Location.X > 0 Then
            plane.Left -= 10
        End If
    End Sub

    Private Sub gameplayForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightSide.Stop()
        LeftSide.Stop()
    End Sub

    Private Sub RaceMover1_Tick(sender As Object, e As EventArgs) Handles RaceMover1.Tick
        MoveRacer(race1, 1)
    End Sub

    Private Sub RaceMover2_Tick(sender As Object, e As EventArgs) Handles RaceMover2.Tick
        MoveRacer(race2, 1.5)
    End Sub

    Private Sub RaceMover3_Tick(sender As Object, e As EventArgs) Handles RaceMover3.Tick
        MoveRacer(race3, 1.75)
    End Sub

    Private Sub RaceMover4_Tick(sender As Object, e As EventArgs) Handles RaceMover4.Tick
        MoveRacer(race4, 2)
    End Sub

    Private Sub RaceMover5_Tick(sender As Object, e As EventArgs) Handles RaceMover5.Tick
        MoveRacer(race5, 2.25)
    End Sub

    Private Sub MoveRacer(racer As PictureBox, speedMultiplier As Double)
        racer.Top += speed * speedMultiplier
        If racer.Top >= Me.Height Then
            score += 1
            Label1.Text = "Score: " & score
            racer.Top = -CInt(Math.Ceiling(Rnd() * 200)) - racer.Height
            racer.Left = CInt(Math.Ceiling(Rnd() * (Me.ClientSize.Width - racer.Width)))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score = 0
        restartMusik()
        Me.Controls.Clear()
        InitializeComponent()
        Form1_load(sender, e)
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        score = 0
        Me.Controls.Clear()
        restartMusik()
        InitializeComponent()
        Form1_load(sender, e)

        startForm.Show()
        Me.Hide()
    End Sub

End Class