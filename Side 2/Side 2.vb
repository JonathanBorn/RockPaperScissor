Public Class RockPaperScissor
    Shared playerScore As Integer = CInt(0)
    Shared cpuScore As Integer = CInt(0)
    Shared rock As Integer = 1
    Shared paper As Integer = 2
    Shared scissor As Integer = 3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles rockButton.Click
        Dim cpu As Integer = CInt(Math.Ceiling(Rnd() * 3))
        Dim playerScoreText As String = CStr(playerScoreLabel.Text)
        Dim cpuScoreText As String = CStr(cpuScoreLabel.Text)

        If cpu = rock Then
            PictureBox.Image = Image.FromFile("C:\Users\cameron.boutilier\Desktop\Side 2\rock.jpg")
            MessageBox.Show("Tie!", "Tie", MessageBoxButtons.OK)
        ElseIf cpu = paper Then
            PictureBox.Image = Image.FromFile("C:\Users\cameron.boutilier\Desktop\Side 2\paper.jpg")
            cpuScore = cpuScore + 1
            cpuScoreText = "CPU: " + CStr(cpuScore)
            cpuScoreLabel.Text = cpuScoreText
        ElseIf cpu = scissor Then
            PictureBox.Image = Image.FromFile("C:\Users\cameron.boutilier\Desktop\Side 2\scissors.jpg")
            playerScore = playerScore + 1
            playerScoreText = "Player: " + CStr(playerScore)
            playerScoreLabel.Text = playerScoreText
        End If
    End Sub

    Private Sub paperButton_Click(sender As Object, e As EventArgs) Handles paperButton.Click
        Dim cpu As Integer = CInt(Math.Ceiling(Rnd() * 3))
        Dim playerScoreText As String = CStr(playerScoreLabel.Text)
        Dim cpuScoreText As String = CStr(cpuScoreLabel.Text)

        If cpu = rock Then
            PictureBox.Image = Image.FromFile("C:\Users\cameron.boutilier\Desktop\Side 2\rock.jpg")
            playerScore = playerScore + 1
            playerScoreText = "Player: " + CStr(playerScore)
            playerScoreLabel.Text = playerScoreText
        ElseIf cpu = paper Then
            PictureBox.Image = Image.FromFile("C:\Users\cameron.boutilier\Desktop\Side 2\paper.jpg")
            MessageBox.Show("Tie!", "Tie", MessageBoxButtons.OK)
        ElseIf cpu = scissor Then
            PictureBox.Image = Image.FromFile("C:\Users\cameron.boutilier\Desktop\Side 2\scissors.jpg")
            cpuScore = cpuScore + 1
            cpuScoreText = "CPU: " + CStr(cpuScore)
            cpuScoreLabel.Text = cpuScoreText
        End If
    End Sub

    Private Sub scissorButton_Click(sender As Object, e As EventArgs) Handles scissorButton.Click
        Dim cpu As Integer = CInt(Math.Ceiling(Rnd() * 3))
        Dim playerScoreText As String = CStr(playerScoreLabel.Text)
        Dim cpuScoreText As String = CStr(cpuScoreLabel.Text)

        If cpu = rock Then
            PictureBox.Image = Image.FromFile("C:\Users\cameron.boutilier\Desktop\Side 2\rock.jpg")
            cpuScore = cpuScore + 1
            cpuScoreText = "CPU: " + CStr(cpuScore)
            cpuScoreLabel.Text = cpuScoreText
        ElseIf cpu = paper Then
            PictureBox.Image = Image.FromFile("C:\Users\cameron.boutilier\Desktop\Side 2\paper.jpg")
            playerScore = playerScore + 1
            playerScoreText = "Player: " + CStr(playerScore)
            playerScoreLabel.Text = playerScoreText
            PictureBox.Image = Image.FromFile("C:\Users\cameron.boutilier\Desktop\Side 2\scissors.jpg")
        ElseIf cpu = scissor Then
            MessageBox.Show("Tie!", "Tie", MessageBoxButtons.OK)
        End If
    End Sub
End Class
