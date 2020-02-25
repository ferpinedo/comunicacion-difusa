Public Class frmActVaguedad
    Public vaguedad As Integer
    Dim randomNumber As Random = New Random()

    Private Sub frmActVaguedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnDelante_Click(sender As Object, e As EventArgs) Handles BtnDelante.Click
        If vaguedad = 0 Then
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

    Private Sub BtnPequeño_Click(sender As Object, e As EventArgs) Handles BtnPequeño.Click
        If vaguedad = 1 Then
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

    Private Sub BtnLejos_Click(sender As Object, e As EventArgs) Handles BtnLejos.Click
        If vaguedad = 2 Then
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

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        If vaguedad = 3 Then
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

    Private Sub BtnArriba_Click(sender As Object, e As EventArgs) Handles BtnArriba.Click
        If vaguedad = 4 Then
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

    Private Sub BtnAbrir_Click(sender As Object, e As EventArgs) Handles BtnAbrir.Click
        If vaguedad = 5 Then
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

    Private Sub BtnAbajo_Click(sender As Object, e As EventArgs) Handles BtnAbajo.Click
        If vaguedad = 6 Then
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

    Private Sub BtnDetras_Click(sender As Object, e As EventArgs) Handles BtnDetras.Click
        If vaguedad = 7 Then
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

    Private Sub BtnGrande_Click(sender As Object, e As EventArgs) Handles BtnGrande.Click
        If vaguedad = 8 Then
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

    Private Sub BtnCercas_Click(sender As Object, e As EventArgs) Handles BtnCercas.Click
        If vaguedad = 9 Then
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
        Dim vague As Integer = randomNumber.Next(1, 10)
        Select Case vague
            Case 1
                AxWindowsMediaPlayer1.URL = "Audios/Adelante.wav"
                vaguedad = 0
            Case 2
                AxWindowsMediaPlayer1.URL = "Audios/Pequeño.wav"
                vaguedad = 1
            Case 3
                AxWindowsMediaPlayer1.URL = "Audios/Lejos.wav"
                vaguedad = 2
            Case 4
                AxWindowsMediaPlayer1.URL = "Audios/Cerrar.wav"
                vaguedad = 3
            Case 5
                AxWindowsMediaPlayer1.URL = "Audios/Arriba.wav"
                vaguedad = 4
            Case 6
                AxWindowsMediaPlayer1.URL = "Audios/Abrir.wav"
                vaguedad = 5
            Case 7
                AxWindowsMediaPlayer1.URL = "Audios/Abajo.wav"
                vaguedad = 6
            Case 8
                AxWindowsMediaPlayer1.URL = "Audios/Atras.wav"
                vaguedad = 7
            Case 9
                AxWindowsMediaPlayer1.URL = "Audios/Grande.wav"
                vaguedad = 8
            Case 10
                AxWindowsMediaPlayer1.URL = "Audios/Cerca.wav"
                vaguedad = 9
        End Select
    End Sub

    Private Sub BtnMenuPrincipal_Click(sender As Object, e As EventArgs) Handles BtnMenuPrincipal.Click
        Me.Close()
        Dim frmSegundo As New Form9()
        frmSegundo.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.URL = "Audios/Relaciona.wav"
    End Sub
End Class