<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gameplayForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gameplayForm))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        plane = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        RoadMover = New Timer(components)
        RightSide = New Timer(components)
        LeftSide = New Timer(components)
        RaceMover1 = New Timer(components)
        RaceMover2 = New Timer(components)
        RaceMover3 = New Timer(components)
        Label3 = New Label()
        Button1 = New Button()
        race2 = New PictureBox()
        race1 = New PictureBox()
        race3 = New PictureBox()
        RaceMover4 = New Timer(components)
        RaceMover5 = New Timer(components)
        race4 = New PictureBox()
        race5 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        EXITToolStripMenuItem = New ToolStripMenuItem()
        BACKToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(plane, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(race2, ComponentModel.ISupportInitialize).BeginInit()
        CType(race1, ComponentModel.ISupportInitialize).BeginInit()
        CType(race3, ComponentModel.ISupportInitialize).BeginInit()
        CType(race4, ComponentModel.ISupportInitialize).BeginInit()
        CType(race5, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.awan
        PictureBox1.Location = New Point(22, 49)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.awan
        PictureBox2.Location = New Point(143, 146)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(125, 95)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.awan
        PictureBox3.Location = New Point(-24, 229)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(69, 55)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.awan
        PictureBox4.Location = New Point(511, 120)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(234, 178)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.awan
        PictureBox5.Location = New Point(227, 503)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(162, 120)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.awan
        PictureBox6.Location = New Point(0, 348)
        PictureBox6.Margin = New Padding(3, 2, 3, 2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(145, 110)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
        ' 
        ' plane
        ' 
        plane.Image = My.Resources.Resources.pesawat_kita
        plane.Location = New Point(313, 503)
        plane.Margin = New Padding(3, 2, 3, 2)
        plane.Name = "plane"
        plane.Size = New Size(50, 53)
        plane.SizeMode = PictureBoxSizeMode.Zoom
        plane.TabIndex = 6
        plane.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.awan
        PictureBox7.Location = New Point(340, 329)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(165, 119)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 10
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.awan
        PictureBox8.Location = New Point(287, 11)
        PictureBox8.Margin = New Padding(3, 2, 3, 2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(137, 95)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 11
        PictureBox8.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label1.Location = New Point(0, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 36)
        Label1.TabIndex = 12
        Label1.Text = "SCORE : 0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gill Sans Ultra Bold Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label2.Location = New Point(591, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 36)
        Label2.TabIndex = 13
        Label2.Text = "SPEED 0"
        ' 
        ' RoadMover
        ' 
        RoadMover.Enabled = True
        RoadMover.Interval = 10
        ' 
        ' RightSide
        ' 
        RightSide.Enabled = True
        RightSide.Interval = 10
        ' 
        ' LeftSide
        ' 
        LeftSide.Enabled = True
        LeftSide.Interval = 10
        ' 
        ' RaceMover1
        ' 
        RaceMover1.Enabled = True
        RaceMover1.Interval = 10
        ' 
        ' RaceMover2
        ' 
        RaceMover2.Enabled = True
        RaceMover2.Interval = 10
        ' 
        ' RaceMover3
        ' 
        RaceMover3.Enabled = True
        RaceMover3.Interval = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("News706 BT", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(185, 263)
        Label3.Name = "Label3"
        Label3.Size = New Size(334, 56)
        Label3.TabIndex = 14
        Label3.Text = "GAME OVER"
        Label3.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightGray
        Button1.Font = New Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(259, 329)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 52)
        Button1.TabIndex = 15
        Button1.Text = "RESTART"
        Button1.UseVisualStyleBackColor = False
        Button1.Visible = False
        ' 
        ' race2
        ' 
        race2.BackColor = Color.Transparent
        race2.Image = CType(resources.GetObject("race2.Image"), Image)
        race2.Location = New Point(122, 90)
        race2.Margin = New Padding(3, 2, 3, 2)
        race2.Name = "race2"
        race2.Size = New Size(80, 194)
        race2.SizeMode = PictureBoxSizeMode.CenterImage
        race2.TabIndex = 16
        race2.TabStop = False
        ' 
        ' race1
        ' 
        race1.BackColor = Color.Transparent
        race1.Image = CType(resources.GetObject("race1.Image"), Image)
        race1.Location = New Point(474, 339)
        race1.Margin = New Padding(3, 2, 3, 2)
        race1.Name = "race1"
        race1.Size = New Size(76, 199)
        race1.SizeMode = PictureBoxSizeMode.CenterImage
        race1.TabIndex = 17
        race1.TabStop = False
        ' 
        ' race3
        ' 
        race3.BackColor = Color.Transparent
        race3.Image = CType(resources.GetObject("race3.Image"), Image)
        race3.Location = New Point(44, 388)
        race3.Margin = New Padding(3, 2, 3, 2)
        race3.Name = "race3"
        race3.Size = New Size(84, 195)
        race3.SizeMode = PictureBoxSizeMode.CenterImage
        race3.TabIndex = 18
        race3.TabStop = False
        ' 
        ' RaceMover4
        ' 
        RaceMover4.Enabled = True
        RaceMover4.Interval = 10
        ' 
        ' RaceMover5
        ' 
        RaceMover5.Enabled = True
        RaceMover5.Interval = 10
        ' 
        ' race4
        ' 
        race4.BackColor = Color.Transparent
        race4.Image = CType(resources.GetObject("race4.Image"), Image)
        race4.Location = New Point(383, -71)
        race4.Margin = New Padding(3, 2, 3, 2)
        race4.Name = "race4"
        race4.Size = New Size(76, 199)
        race4.SizeMode = PictureBoxSizeMode.CenterImage
        race4.TabIndex = 22
        race4.TabStop = False
        ' 
        ' race5
        ' 
        race5.BackColor = Color.Transparent
        race5.Image = CType(resources.GetObject("race5.Image"), Image)
        race5.Location = New Point(651, 207)
        race5.Margin = New Padding(3, 2, 3, 2)
        race5.Name = "race5"
        race5.Size = New Size(76, 199)
        race5.SizeMode = PictureBoxSizeMode.CenterImage
        race5.TabIndex = 23
        race5.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Black
        MenuStrip1.Font = New Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
        MenuStrip1.Items.AddRange(New ToolStripItem() {EXITToolStripMenuItem, BACKToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(701, 27)
        MenuStrip1.TabIndex = 24
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EXITToolStripMenuItem
        ' 
        EXITToolStripMenuItem.BackColor = Color.Black
        EXITToolStripMenuItem.ForeColor = Color.White
        EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        EXITToolStripMenuItem.Size = New Size(60, 23)
        EXITToolStripMenuItem.Text = "EXIT"
        ' 
        ' BACKToolStripMenuItem
        ' 
        BACKToolStripMenuItem.ForeColor = Color.White
        BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        BACKToolStripMenuItem.Size = New Size(67, 23)
        BACKToolStripMenuItem.Text = "BACK"
        ' 
        ' gameplayForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(701, 643)
        Controls.Add(MenuStrip1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(plane)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(race5)
        Controls.Add(race4)
        Controls.Add(race2)
        Controls.Add(race3)
        Controls.Add(race1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        KeyPreview = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "gameplayForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AEROPLANE GLITCH"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(plane, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(race2, ComponentModel.ISupportInitialize).EndInit()
        CType(race1, ComponentModel.ISupportInitialize).EndInit()
        CType(race3, ComponentModel.ISupportInitialize).EndInit()
        CType(race4, ComponentModel.ISupportInitialize).EndInit()
        CType(race5, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents plane As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RoadMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents RaceMover1 As Timer
    Friend WithEvents RaceMover2 As Timer
    Friend WithEvents RaceMover3 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents race2 As PictureBox
    Friend WithEvents race1 As PictureBox
    Friend WithEvents race3 As PictureBox
    Friend WithEvents RaceMover4 As Timer
    Friend WithEvents race4 As PictureBox
    Friend WithEvents race5 As PictureBox
    Friend WithEvents RaceMover5 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label

End Class
