Public Class Form1
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

        If score > 10 And score < 30 Then
            speed = 5
        End If
        If score > 30 And score < 50 Then
            speed = 6
        End If
        If score > 50 And score < 60 Then
            speed = 7
        End If
        If score > 100 Then
            speed = 9
        End If

        Label2.Text = "speed " & speed
        If (car.Bounds.IntersectsWith(race1.Bounds)) Then
            endgame()
        End If
        If (car.Bounds.IntersectsWith(race2.Bounds)) Then
            endgame()
        End If
        If (car.Bounds.IntersectsWith(race3.Bounds)) Then
            endgame()
        End If
    End Sub

    Private Sub endgame()
        Button1.Visible = True
        Label1.Visible = True
        Label3.Visible = True
        RacerMover1.Stop()
        RaceMover2.Stop()
        RaceMover3.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
    End Sub

    Private Sub form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Right Then
            RightSide.Start()
        End If
        If e.KeyCode = Keys.Left Then
            LeftSide.Start()
        End If
    End Sub

    Private Sub RightSide_Tick(sender As Object, e As EventArgs) Handles RightSide.Tick
        If (car.Location.X < 591) Then
            car.Left += 5
        End If
    End Sub

    Private Sub LeftSide_Tick(sender As Object, e As EventArgs) Handles LeftSide.Tick
        If (car.Location.X > 0) Then
            car.Left -= 5
        End If
    End Sub
    Private Sub form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        RightSide.Stop()
        LeftSide.Stop()
    End Sub

    Private Sub RacerMover1_Tick(sender As Object, e As EventArgs) Handles RacerMover1.Tick
        race1.Top += speed / 1
        If race1.Top >= Me.Height Then
            score += 1
            Label1.Text = "score :" & score

            race1.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + race1.Height)
            race1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 551
        End If


    End Sub

    Private Sub RaceMover2_Tick(sender As Object, e As EventArgs) Handles RaceMover2.Tick
        race2.Top += speed / 2
        If race2.Top >= Me.Height Then
            score += 1
            Label1.Text = "score : " & score

            race2.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + race2.Height)
            race2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 354
        End If
    End Sub

    Private Sub RaceMover3_Tick(sender As Object, e As EventArgs) Handles RaceMover3.Tick
        race3.Top += speed * 2 / 3
        If race3.Top >= Me.Height Then
            score += 1
            Label1.Text = "score : " & score

            race3.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + race3.Height)
            race3.Left = CInt(Math.Ceiling(Rnd() * 50)) + 25
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)

    End Sub

    Private Sub race2_Click(sender As Object, e As EventArgs) Handles race2.Click

    End Sub

    Private Sub race3_Click(sender As Object, e As EventArgs) Handles race3.Click

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub race5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub USERNAMEToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SCOREBOARDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SCOREBOARDToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub car_Click(sender As Object, e As EventArgs) Handles car.Click

    End Sub
End Class
