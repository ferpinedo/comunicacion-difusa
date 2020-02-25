Public Class frmActAmbiguedad
    Public homofonas As Integer
    Dim randomNumber As Random = New Random()

    Private Sub frmActAmbiguedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_botar_Click(sender As Object, e As EventArgs) Handles Btn_botar.Click
        If homofonas = 0 Then
            Dim frmSegundo As New frmMuyBien()
            frmSegundo.Show()
            aciertos = aciertos + 1
            BtnSiguiente.Enabled = True
        Else
            Dim frmTercero As New frmIntentaloDeNuevo
            frmTercero.show()
            errores = errores + 1
            BtnSiguiente.Enabled = False
        End If
        lblNumero.Text = Porcentaje(aciertos, aciertos + errores)
    End Sub

    Private Sub Btn_asia_Click(sender As Object, e As EventArgs) Handles Btn_asia.Click
        If homofonas = 1 Then
            Dim frmSegundo As New frmMuyBien()
            frmSegundo.Show()
            aciertos = aciertos + 1
            BtnSiguiente.Enabled = True
        Else
            Dim frmTercero As New frmIntentaloDeNuevo
            frmTercero.Show()
            errores = errores + 1
            BtnSiguiente.Enabled = False
        End If
        lblNumero.Text = Porcentaje(aciertos, aciertos + errores)
    End Sub

    Private Sub Btn_vello_Click(sender As Object, e As EventArgs) Handles Btn_vello.Click
        If homofonas = 2 Then
            Dim frmSegundo As New frmMuyBien()
            frmSegundo.Show()
            aciertos = aciertos + 1
            BtnSiguiente.Enabled = True
        Else
            Dim frmTercero As New frmIntentaloDeNuevo
            frmTercero.Show()
            errores = errores + 1
            BtnSiguiente.Enabled = False
        End If
        lblNumero.Text = Porcentaje(aciertos, aciertos + errores)
    End Sub

    Private Sub Btn_coser_Click(sender As Object, e As EventArgs) Handles Btn_coser.Click
        If homofonas = 3 Then
            Dim frmSegundo As New frmMuyBien()
            frmSegundo.Show()
            aciertos = aciertos + 1
            BtnSiguiente.Enabled = True
        Else
            Dim frmTercero As New frmIntentaloDeNuevo
            frmTercero.Show()
            errores = errores + 1
            BtnSiguiente.Enabled = False
        End If
        lblNumero.Text = Porcentaje(aciertos, aciertos + errores)
    End Sub

    Private Sub Btn_hacia_Click(sender As Object, e As EventArgs) Handles Btn_hacia.Click
        If homofonas = 4 Then
            Dim frmSegundo As New frmMuyBien()
            frmSegundo.Show()
            aciertos = aciertos + 1
            BtnSiguiente.Enabled = True
        Else
            Dim frmTercero As New frmIntentaloDeNuevo
            frmTercero.Show()
            errores = errores + 1
            BtnSiguiente.Enabled = False
        End If
        lblNumero.Text = Porcentaje(aciertos, aciertos + errores)

    End Sub

    Private Sub Btn_bello_Click(sender As Object, e As EventArgs) Handles Btn_bello.Click
        If homofonas = 5 Then
            Dim frmSegundo As New frmMuyBien()
            frmSegundo.Show()
            aciertos = aciertos + 1
            BtnSiguiente.Enabled = True
        Else
            Dim frmTercero As New frmIntentaloDeNuevo
            frmTercero.Show()
            errores = errores + 1
            BtnSiguiente.Enabled = False
        End If
        lblNumero.Text = Porcentaje(aciertos, aciertos + errores)
    End Sub

    Private Sub Btn_cocer_Click(sender As Object, e As EventArgs) Handles Btn_cocer.Click
        If homofonas = 6 Then
            Dim frmSegundo As New frmMuyBien()
            frmSegundo.Show()
            aciertos = aciertos + 1
            BtnSiguiente.Enabled = True
        Else
            Dim frmTercero As New frmIntentaloDeNuevo
            frmTercero.Show()
            errores = errores + 1
            BtnSiguiente.Enabled = False
        End If
        lblNumero.Text = Porcentaje(aciertos, aciertos + errores)
    End Sub

    Private Sub Btn_votar_Click(sender As Object, e As EventArgs) Handles Btn_votar.Click
        If homofonas = 7 Then
            Dim frmSegundo As New frmMuyBien()
            frmSegundo.Show()
            aciertos = aciertos + 1
            BtnSiguiente.Enabled = True
        Else
            Dim frmTercero As New frmIntentaloDeNuevo
            frmTercero.Show()
            errores = errores + 1
            BtnSiguiente.Enabled = False
        End If
        lblNumero.Text = Porcentaje(aciertos, aciertos + errores)
    End Sub

    Private Sub Btn_ola_Click(sender As Object, e As EventArgs) Handles Btn_ola.Click
        If homofonas = 8 Then
            Dim frmSegundo As New frmMuyBien()
            frmSegundo.Show()
            aciertos = aciertos + 1
            BtnSiguiente.Enabled = True
        Else
            Dim frmTercero As New frmIntentaloDeNuevo
            frmTercero.Show()
            errores = errores + 1
            BtnSiguiente.Enabled = False
        End If
        lblNumero.Text = Porcentaje(aciertos, aciertos + errores)
    End Sub

    Private Sub Btn_hola_Click(sender As Object, e As EventArgs) Handles Btn_hola.Click
        If homofonas = 9 Then
            Dim frmSegundo As New frmMuyBien()
            frmSegundo.Show()
            aciertos = aciertos + 1
            BtnSiguiente.Enabled = True
        Else
            Dim frmTercero As New frmIntentaloDeNuevo
            frmTercero.Show()
            errores = errores + 1
            BtnSiguiente.Enabled = False
        End If
        lblNumero.Text = Porcentaje(aciertos, aciertos + errores)
    End Sub

    Private Sub BtnSiguiente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSiguiente.Click
        Dim homof As Integer = randomNumber.Next(1, 10)
        Select Case homof
            Case 1
                AxWindowsMediaPlayer1.URL = "Audios/botar.wav"
                homofonas = 0
            Case 2
                AxWindowsMediaPlayer1.URL = "Audios/Asia.wav"
                homofonas = 1
            Case 3
                AxWindowsMediaPlayer1.URL = "Audios/vello.wav"
                homofonas = 2
            Case 4
                AxWindowsMediaPlayer1.URL = "Audios/cocer2.wav"
                homofonas = 3
            Case 5
                AxWindowsMediaPlayer1.URL = "Audios/Hacia.wav"
                homofonas = 4
            Case 6
                AxWindowsMediaPlayer1.URL = "Audios/Bello1.wav"
                homofonas = 5
            Case 7
                AxWindowsMediaPlayer1.URL = "Audios/cocer1.wav"
                homofonas = 6
            Case 8
                AxWindowsMediaPlayer1.URL = "Audios/votar.wav"
                homofonas = 7
            Case 9
                AxWindowsMediaPlayer1.URL = "Audios/ola.wav"
                homofonas = 8
            Case 10
                AxWindowsMediaPlayer1.URL = "Audios/hola.wav"
                homofonas = 9
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.URL = "Audios/Relaciona.wav"
    End Sub

    Private Sub BtnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles BtnMenuPrincipal.Click
        Me.Close()
        Dim frmSegundo As New Form9()
        frmSegundo.Show()
    End Sub

End Class