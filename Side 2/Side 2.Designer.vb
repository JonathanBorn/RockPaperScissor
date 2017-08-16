<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RockPaperScissor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RockPaperScissor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cpuScoreLabel = New System.Windows.Forms.Label()
        Me.playerScoreLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.scissorButton = New System.Windows.Forms.Button()
        Me.paperButton = New System.Windows.Forms.Button()
        Me.rockButton = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cpuScoreLabel)
        Me.Panel1.Controls.Add(Me.playerScoreLabel)
        Me.Panel1.Controls.Add(Me.nameLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 73)
        Me.Panel1.TabIndex = 0
        '
        'cpuScoreLabel
        '
        Me.cpuScoreLabel.AutoSize = True
        Me.cpuScoreLabel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpuScoreLabel.Location = New System.Drawing.Point(326, 40)
        Me.cpuScoreLabel.Name = "cpuScoreLabel"
        Me.cpuScoreLabel.Size = New System.Drawing.Size(64, 18)
        Me.cpuScoreLabel.TabIndex = 2
        Me.cpuScoreLabel.Text = "CPU: 0"
        '
        'playerScoreLabel
        '
        Me.playerScoreLabel.AutoSize = True
        Me.playerScoreLabel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerScoreLabel.Location = New System.Drawing.Point(3, 40)
        Me.playerScoreLabel.Name = "playerScoreLabel"
        Me.playerScoreLabel.Size = New System.Drawing.Size(81, 18)
        Me.playerScoreLabel.TabIndex = 1
        Me.playerScoreLabel.Text = "Player: 0"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(84, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(232, 25)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Rock Paper Scissor"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox)
        Me.Panel2.Controls.Add(Me.scissorButton)
        Me.Panel2.Controls.Add(Me.paperButton)
        Me.Panel2.Controls.Add(Me.rockButton)
        Me.Panel2.Location = New System.Drawing.Point(12, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 268)
        Me.Panel2.TabIndex = 1
        '
        'scissorButton
        '
        Me.scissorButton.Image = CType(resources.GetObject("scissorButton.Image"), System.Drawing.Image)
        Me.scissorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.scissorButton.Location = New System.Drawing.Point(329, 0)
        Me.scissorButton.Name = "scissorButton"
        Me.scissorButton.Size = New System.Drawing.Size(75, 114)
        Me.scissorButton.TabIndex = 2
        Me.scissorButton.UseVisualStyleBackColor = True
        '
        'paperButton
        '
        Me.paperButton.Image = CType(resources.GetObject("paperButton.Image"), System.Drawing.Image)
        Me.paperButton.Location = New System.Drawing.Point(161, 0)
        Me.paperButton.Name = "paperButton"
        Me.paperButton.Size = New System.Drawing.Size(98, 114)
        Me.paperButton.TabIndex = 1
        Me.paperButton.UseVisualStyleBackColor = True
        '
        'rockButton
        '
        Me.rockButton.Image = CType(resources.GetObject("rockButton.Image"), System.Drawing.Image)
        Me.rockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rockButton.Location = New System.Drawing.Point(0, 0)
        Me.rockButton.Name = "rockButton"
        Me.rockButton.Size = New System.Drawing.Size(84, 114)
        Me.rockButton.TabIndex = 0
        Me.rockButton.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(148, 152)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(126, 113)
        Me.PictureBox.TabIndex = 3
        Me.PictureBox.TabStop = False
        '
        'RockPaperScissor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 371)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RockPaperScissor"
        Me.Text = "Rock Paper Scissor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cpuScoreLabel As Label
    Friend WithEvents playerScoreLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents scissorButton As Button
    Friend WithEvents paperButton As Button
    Friend WithEvents rockButton As Button
    Friend WithEvents PictureBox As PictureBox
End Class
