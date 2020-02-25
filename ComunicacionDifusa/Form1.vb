Public Class Form1
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Form2.Show()
    'End Sub

    Private Sub Inexactitud_Click(sender As Object, e As EventArgs) Handles Ambiguedad.Click
        Form9.Show()
    End Sub

    Private Sub Vaguedad_Click(sender As Object, e As EventArgs) Handles Vaguedad.Click
        Form3.Show()
    End Sub

    Private Sub Inconsistencia_Click(sender As Object, e As EventArgs) Handles Inconsistencia.Click
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LoginForm1.Show()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        'Me.Close()
        'Dim frmSegundo As New LoginForm1()
        'frmSegundo.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.URL = "Audios/Ambigüedad.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.URL = "Audios/Vaguedad.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.URL = "Audios/Inconsistencia.wav"
        AxWindowsMediaPlayer1.Visible = False
    End Sub
End Class
