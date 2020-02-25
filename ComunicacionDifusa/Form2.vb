Public Class Sintactica
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    'Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'AxWindowsMediaPlayer1.URL = "RECURSOS/Casa1.wav"
    'AxWindowsMediaPlayer1.Visible = False
    'End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homofonas\vello.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/vello.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' My.Computer.Audio.Play("C:\Users\user\Documents\TALL DE INV\Comunicacion Difusa\AMBIGUEDAD\homofonas\Bello1.wav", AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = "Audios/Bello1.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Sintactica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class