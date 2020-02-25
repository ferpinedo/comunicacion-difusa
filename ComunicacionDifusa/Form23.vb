Public Class Form23
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.URL = "Audios/Adelante.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.URL = "Audios/Atras.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form22.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmActVaguedad.Show()
    End Sub

    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class