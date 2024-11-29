<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startForm))
        Label1 = New Label()
        startButton = New Button()
        MenuStrip1 = New MenuStrip()
        EXITToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Stencil", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(138, 266)
        Label1.Name = "Label1"
        Label1.Size = New Size(447, 44)
        Label1.TabIndex = 0
        Label1.Text = "PRESS SPACE TO BEGIN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' startButton
        ' 
        startButton.BackColor = SystemColors.ActiveBorder
        startButton.Font = New Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        startButton.ForeColor = Color.Black
        startButton.Location = New Point(221, 319)
        startButton.Name = "startButton"
        startButton.Size = New Size(280, 62)
        startButton.TabIndex = 1
        startButton.Text = "START GAME"
        startButton.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaptionText
        MenuStrip1.Items.AddRange(New ToolStripItem() {EXITToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(701, 30)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EXITToolStripMenuItem
        ' 
        EXITToolStripMenuItem.BackColor = Color.Black
        EXITToolStripMenuItem.Font = New Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EXITToolStripMenuItem.ForeColor = Color.White
        EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        EXITToolStripMenuItem.Size = New Size(68, 26)
        EXITToolStripMenuItem.Text = "EXIT"
        ' 
        ' startForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(701, 643)
        Controls.Add(startButton)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        Name = "startForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AEROPLANE GLITCH"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents startButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
End Class
