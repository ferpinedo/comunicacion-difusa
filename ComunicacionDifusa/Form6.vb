Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homofonas\botar.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/botar.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homofonas\votar.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/votar.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form7.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class