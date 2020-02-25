Public Class frmActAmbiHomonimas
    Public homonimas As Integer
    Dim randomNumber As Random = New Random()

    Private Sub frmActAmbiHomonimas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSierra1_Click(sender As Object, e As EventArgs) Handles BtnSierra1.Click
        If homonimas = 0 Then
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

    Private Sub BtnComa1_Click(sender As Object, e As EventArgs) Handles BtnComa1.Click
        If homonimas = 1 Then
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

    Private Sub BtnBaya_Click(sender As Object, e As EventArgs) Handles BtnBaya.Click
        If homonimas = 2 Then
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

    Private Sub BtnCaza_Click(sender As Object, e As EventArgs) Handles BtnCaza.Click
        If homonimas = 3 Then
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

    Private Sub BtnAs1_Click(sender As Object, e As EventArgs) Handles BtnAs1.Click
        If homonimas = 4 Then
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

    Private Sub BtnCierra_Click(sender As Object, e As EventArgs) Handles BtnCierra.Click
        If homonimas = 5 Then
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

    Private Sub BtnCasa1_Click(sender As Object, e As EventArgs) Handles BtnCasa1.Click
        If homonimas = 6 Then
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

    Private Sub BtnHaz_Click(sender As Object, e As EventArgs) Handles BtnHaz.Click
        If homonimas = 7 Then
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

    Private Sub BtnComa2_Click(sender As Object, e As EventArgs) Handles BtnComa2.Click
        If homonimas = 8 Then
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

    Private Sub BtnVaya_Click(sender As Object, e As EventArgs) Handles BtnVaya.Click
        If homonimas = 9 Then
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

    Private Sub BtnAs2_Click(sender As Object, e As EventArgs) Handles BtnAs2.Click
        If homonimas = 10 Then
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

    Private Sub BtnSierra2_Click(sender As Object, e As EventArgs) Handles BtnSierra2.Click
        If homonimas = 11 Then
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

    Private Sub BtnComa3_Click(sender As Object, e As EventArgs) Handles BtnComa3.Click
        If homonimas = 12 Then
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

    Private Sub BtnCasa2_Click(sender As Object, e As EventArgs) Handles BtnCasa2.Click
        If homonimas = 13 Then
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

    Private Sub BtnValla_Click(sender As Object, e As EventArgs) Handles BtnValla.Click
        If homonimas = 14 Then
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
        Dim homon As Integer = randomNumber.Next(1, 15)
        Select Case homon
            Case 1
                AxWindowsMediaPlayer1.URL = "Audios/Sierra1.wav"
                homonimas = 0
            Case 2
                AxWindowsMediaPlayer1.URL = "Audios/Coma2.wav"
                homonimas = 1
            Case 3
                AxWindowsMediaPlayer1.URL = "Audios/Baya.wav"
                homonimas = 2
            Case 4
                AxWindowsMediaPlayer1.URL = "Audios/Caza.wav"
                homonimas = 3
            Case 5
                AxWindowsMediaPlayer1.URL = "Audios/As1.wav"
                homonimas = 4
            Case 6
                AxWindowsMediaPlayer1.URL = "Audios/Cierra.wav"
                homonimas = 5
            Case 7
                AxWindowsMediaPlayer1.URL = "Audios/Casa1.wav"
                homonimas = 6
            Case 8
                AxWindowsMediaPlayer1.URL = "Audios/Haz.wav"
                homonimas = 7
            Case 9
                AxWindowsMediaPlayer1.URL = "Audios/Coma1.wav"
                homonimas = 8
            Case 10
                AxWindowsMediaPlayer1.URL = "Audios/Vaya.wav"
                homonimas = 9
            Case 11
                AxWindowsMediaPlayer1.URL = "Audios/As2.wav"
                homonimas = 10
            Case 12
                AxWindowsMediaPlayer1.URL = "Audios/Sierra2.wav"
                homonimas = 11
            Case 13
                AxWindowsMediaPlayer1.URL = "Audios/Coma3.wav"
                homonimas = 12
            Case 14
                AxWindowsMediaPlayer1.URL = "Audios/Casa2.wav"
                homonimas = 13
            Case 15
                AxWindowsMediaPlayer1.URL = "Audios/Valla1.wav"
                homonimas = 14
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