Public Class frmHighScore
    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub
    Public Sub doScore()
        If playerScore < 1 Then
            lblMessage.Text = "Sorry your Score was not goog enough"
        Else
            lblMessage.Text = "Congratulations your score will be added to the hall of fame"

            lstHighScore.Items.Add(playerName & vbTab & playerScore)

        End If

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub lstHighScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHighScore.SelectedIndexChanged

    End Sub
End Class