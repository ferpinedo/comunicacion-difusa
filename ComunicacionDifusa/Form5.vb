Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        form6.show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homofonas\cocer1.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/cocer1.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homofonas\coser.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/cocer2.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub
End Class