Public Class Form9
    Private Sub Ambiguedad_Click(sender As Object, e As EventArgs) Handles Ambiguedad.Click
        Sintactica.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
        'Me.Close()
        'Dim frmSegundo As New Form1()
        'frmSegundo.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\Homófonas.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/Homófonas.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\Homografas.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/Homografas.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\Homonimas.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/Homonimas.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form10.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form15.Show()
    End Sub
End Class