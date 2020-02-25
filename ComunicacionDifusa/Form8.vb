Public Class Form8
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homofonas\Asia.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/Asia.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homofonas\Hacia.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/Hacia.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmActAmbiguedad.Show()
    End Sub
End Class