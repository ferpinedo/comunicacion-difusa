Public Class frmActInconsistencia
    Public inconsistencia As Integer
    Dim randomNumber As Random = New Random()

    Private Sub BtnMuyRapido_Click(sender As Object, e As EventArgs) Handles BtnMuyRapido.Click
        If inconsistencia = 0 Then
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

    Private Sub BtnFrio_Click(sender As Object, e As EventArgs) Handles BtnFrio.Click
        If inconsistencia = 1 Then
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

    Private Sub BtnMuyLleno_Click(sender As Object, e As EventArgs) Handles BtnMuyLleno.Click
        If inconsistencia = 2 Then
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

    Private Sub BtnMuyCaliente1_Click(sender As Object, e As EventArgs) Handles BtnMuyCaliente1.Click
        If inconsistencia = 3 Then
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

    Private Sub BtnLento_Click(sender As Object, e As EventArgs) Handles BtnLento.Click
        If inconsistencia = 4 Then
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

    Private Sub BtnVacio_Click(sender As Object, e As EventArgs) Handles BtnVacio.Click
        If inconsistencia = 5 Then
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

    Private Sub BtnMuyLento_Click(sender As Object, e As EventArgs) Handles BtnMuyLento.Click
        If inconsistencia = 6 Then
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

    Private Sub BtnMuyFrio_Click(sender As Object, e As EventArgs) Handles BtnMuyFrio.Click
        If inconsistencia = 7 Then
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

    Private Sub BtnNoVacio_Click(sender As Object, e As EventArgs) Handles BtnNoVacio.Click
        If inconsistencia = 8 Then
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

    Private Sub BtnNoRapido_Click(sender As Object, e As EventArgs) Handles BtnNoRapido.Click
        If inconsistencia = 9 Then
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

    Private Sub BtnTibio_Click(sender As Object, e As EventArgs) Handles BtnTibio.Click
        If inconsistencia = 10 Then
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

    Private Sub BtnLleno_Click(sender As Object, e As EventArgs) Handles BtnLleno.Click
        If inconsistencia = 11 Then
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

    Private Sub BtnRapido_Click(sender As Object, e As EventArgs) Handles BtnRapido.Click
        If inconsistencia = 12 Then
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

    Private Sub BtnMuyCaliente_Click(sender As Object, e As EventArgs) Handles BtnMuyCaliente.Click
        If inconsistencia = 13 Then
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

    Private Sub BtnMedioLleno_Click(sender As Object, e As EventArgs) Handles BtnMedioLleno.Click
        If inconsistencia = 14 Then
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

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Dim incons As Integer = randomNumber.Next(1, 15)
        Select Case incons
            Case 1
                AxWindowsMediaPlayer1.URL = "Audios/MuyRapido.wav"
                inconsistencia = 0
            Case 2
                AxWindowsMediaPlayer1.URL = "Audios/Frio.wav"
                inconsistencia = 1
            Case 3
                AxWindowsMediaPlayer1.URL = "Audios/MuyLleno.wav"
                inconsistencia = 2
            Case 4
                AxWindowsMediaPlayer1.URL = "Audios/MuyCaliente1.wav"
                inconsistencia = 3
            Case 5
                AxWindowsMediaPlayer1.URL = "Audios/Lento.wav"
                inconsistencia = 4
            Case 6
                AxWindowsMediaPlayer1.URL = "Audios/Vacio.wav"
                inconsistencia = 5
            Case 7
                AxWindowsMediaPlayer1.URL = "Audios/MuyLento.wav"
                inconsistencia = 6
            Case 8
                AxWindowsMediaPlayer1.URL = "Audios/MuyFrio.wav"
                inconsistencia = 7
            Case 9
                AxWindowsMediaPlayer1.URL = "Audios/NoVacio.wav"
                inconsistencia = 8
            Case 10
                AxWindowsMediaPlayer1.URL = "Audios/NoRapido.wav"
                inconsistencia = 9
            Case 11
                AxWindowsMediaPlayer1.URL = "Audios/Tibio.wav"
                inconsistencia = 10
            Case 12
                AxWindowsMediaPlayer1.URL = "Audios/Lleno.wav"
                inconsistencia = 11
            Case 13
                AxWindowsMediaPlayer1.URL = "Audios/Rapido.wav"
                inconsistencia = 12
            Case 14
                AxWindowsMediaPlayer1.URL = "Audios/MuyCaliente.wav"
                inconsistencia = 13
            Case 15
                AxWindowsMediaPlayer1.URL = "Audios/MedioLleno.wav"
                inconsistencia = 14
        End Select
    End Sub

    Private Sub BtnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles BtnMenuPrincipal.Click
        Me.Close()
        Dim frmSegundo As New Form9()
        frmSegundo.Show()
    End Sub

    Private Sub BtnInstruc_Click(sender As Object, e As EventArgs) Handles BtnInstruc.Click
        AxWindowsMediaPlayer1.URL = "Audios/Relaciona.wav"
    End Sub
End Class