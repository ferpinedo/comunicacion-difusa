Public Class Form13
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homografas\Vela1.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/Vela1.wav"
        AxWindowsMediaPlayer1.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homografas\Vela2.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/Vela2.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form12.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form14.Show()
    End Sub
End Class