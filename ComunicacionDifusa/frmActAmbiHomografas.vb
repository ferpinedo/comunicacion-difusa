Public Class frmActAmbiHomografas
    Public homografas As Integer
    Dim randomNumber As Random = New Random()

    Private Sub frmActAmbiguedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnVino1_Click(sender As Object, e As EventArgs) Handles BtnVino1.Click
        If homografas = 0 Then
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

    Private Sub BtnVela2_Click(sender As Object, e As EventArgs) Handles BtnVela2.Click
        If homografas = 1 Then
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

    Private Sub BtnPesa2_Click(sender As Object, e As EventArgs) Handles BtnPesa2.Click
        If homografas = 2 Then
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

    Private Sub BtnBarro1_Click(sender As Object, e As EventArgs) Handles BtnBarro1.Click
        If homografas = 3 Then
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

    Private Sub BtnPesa1_Click(sender As Object, e As EventArgs) Handles BtnPesa1.Click
        If homografas = 4 Then
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

    Private Sub BtnPluma1_Click(sender As Object, e As EventArgs) Handles BtnPluma1.Click
        If homografas = 5 Then
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

    Private Sub BtnBarro2_Click(sender As Object, e As EventArgs) Handles BtnBarro2.Click
        If homografas = 6 Then
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

    Private Sub BtnVela1_Click(sender As Object, e As EventArgs) Handles BtnVela1.Click
        If homografas = 7 Then
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

    Private Sub BtnPluma2_Click(sender As Object, e As EventArgs) Handles BtnPluma2.Click
        If homografas = 8 Then
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

    Private Sub BtnVino2_Click(sender As Object, e As EventArgs) Handles BtnVino2.Click
        If homografas = 9 Then
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
        Dim homog As Integer = randomNumber.Next(1, 10)
        Select Case homog
            Case 1
                AxWindowsMediaPlayer1.URL = "Audios/Vino1.wav"
                homografas = 0
            Case 2
                AxWindowsMediaPlayer1.URL = "Audios/Vela2.wav"
                homografas = 1
            Case 3
                AxWindowsMediaPlayer1.URL = "Audios/Pesa2.wav"
                homografas = 2
            Case 4
                AxWindowsMediaPlayer1.URL = "Audios/Barro1.wav"
                homografas = 3
            Case 5
                AxWindowsMediaPlayer1.URL = "Audios/Pesa1.wav"
                homografas = 4
            Case 6
                AxWindowsMediaPlayer1.URL = "Audios/Pluma1.wav"
                homografas = 5
            Case 7
                AxWindowsMediaPlayer1.URL = "Audios/Barro2.wav"
                homografas = 6
            Case 8
                AxWindowsMediaPlayer1.URL = "Audios/Vela1.wav"
                homografas = 7
            Case 9
                AxWindowsMediaPlayer1.URL = "Audios/Pluma2.wav"
                homografas = 8
            Case 10
                AxWindowsMediaPlayer1.URL = "Audios/Vino2.wav"
                homografas = 9
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