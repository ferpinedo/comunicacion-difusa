Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homofonas\ola.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/ola.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homofonas\hola.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/hola.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Show()
    End Sub
End Class