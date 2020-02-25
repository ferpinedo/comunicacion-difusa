<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActInconsistencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActInconsistencia))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnMenuPrincipal = New System.Windows.Forms.Button()
        Me.BtnMuyRapido = New System.Windows.Forms.Button()
        Me.BtnFrio = New System.Windows.Forms.Button()
        Me.BtnMuyLleno = New System.Windows.Forms.Button()
        Me.BtnMuyCaliente1 = New System.Windows.Forms.Button()
        Me.BtnLento = New System.Windows.Forms.Button()
        Me.BtnVacio = New System.Windows.Forms.Button()
        Me.BtnMuyLento = New System.Windows.Forms.Button()
        Me.BtnMuyFrio = New System.Windows.Forms.Button()
        Me.BtnNoVacio = New System.Windows.Forms.Button()
        Me.BtnNoRapido = New System.Windows.Forms.Button()
        Me.BtnTibio = New System.Windows.Forms.Button()
        Me.BtnLleno = New System.Windows.Forms.Button()
        Me.BtnRapido = New System.Windows.Forms.Button()
        Me.BtnMuyCaliente = New System.Windows.Forms.Button()
        Me.BtnMedioLleno = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.BtnInstruc = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Actividad Inconsistencia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(548, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 14)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Instrucciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnMenuPrincipal
        '
        Me.BtnMenuPrincipal.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.boton
        Me.BtnMenuPrincipal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenuPrincipal.ForeColor = System.Drawing.Color.White
        Me.BtnMenuPrincipal.Location = New System.Drawing.Point(12, 477)
        Me.BtnMenuPrincipal.Name = "BtnMenuPrincipal"
        Me.BtnMenuPrincipal.Size = New System.Drawing.Size(106, 55)
        Me.BtnMenuPrincipal.TabIndex = 42
        Me.BtnMenuPrincipal.Text = "  Menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "prinicipal"
        Me.BtnMenuPrincipal.UseVisualStyleBackColor = True
        '
        'BtnMuyRapido
        '
        Me.BtnMuyRapido.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.MuyRapido
        Me.BtnMuyRapido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMuyRapido.Location = New System.Drawing.Point(45, 91)
        Me.BtnMuyRapido.Name = "BtnMuyRapido"
        Me.BtnMuyRapido.Size = New System.Drawing.Size(98, 93)
        Me.BtnMuyRapido.TabIndex = 43
        Me.BtnMuyRapido.UseVisualStyleBackColor = True
        '
        'BtnFrio
        '
        Me.BtnFrio.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.frio
        Me.BtnFrio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFrio.Location = New System.Drawing.Point(160, 91)
        Me.BtnFrio.Name = "BtnFrio"
        Me.BtnFrio.Size = New System.Drawing.Size(98, 93)
        Me.BtnFrio.TabIndex = 44
        Me.BtnFrio.UseVisualStyleBackColor = True
        '
        'BtnMuyLleno
        '
        Me.BtnMuyLleno.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.MuyLleno
        Me.BtnMuyLleno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMuyLleno.Location = New System.Drawing.Point(278, 91)
        Me.BtnMuyLleno.Name = "BtnMuyLleno"
        Me.BtnMuyLleno.Size = New System.Drawing.Size(98, 93)
        Me.BtnMuyLleno.TabIndex = 45
        Me.BtnMuyLleno.UseVisualStyleBackColor = True
        '
        'BtnMuyCaliente1
        '
        Me.BtnMuyCaliente1.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.MuyCaliente1
        Me.BtnMuyCaliente1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMuyCaliente1.Location = New System.Drawing.Point(392, 91)
        Me.BtnMuyCaliente1.Name = "BtnMuyCaliente1"
        Me.BtnMuyCaliente1.Size = New System.Drawing.Size(98, 93)
        Me.BtnMuyCaliente1.TabIndex = 46
        Me.BtnMuyCaliente1.UseVisualStyleBackColor = True
        '
        'BtnLento
        '
        Me.BtnLento.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.lento
        Me.BtnLento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLento.Location = New System.Drawing.Point(509, 91)
        Me.BtnLento.Name = "BtnLento"
        Me.BtnLento.Size = New System.Drawing.Size(98, 93)
        Me.BtnLento.TabIndex = 47
        Me.BtnLento.UseVisualStyleBackColor = True
        '
        'BtnVacio
        '
        Me.BtnVacio.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.vacio
        Me.BtnVacio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVacio.Location = New System.Drawing.Point(45, 200)
        Me.BtnVacio.Name = "BtnVacio"
        Me.BtnVacio.Size = New System.Drawing.Size(98, 93)
        Me.BtnVacio.TabIndex = 48
        Me.BtnVacio.UseVisualStyleBackColor = True
        '
        'BtnMuyLento
        '
        Me.BtnMuyLento.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.MuyLento
        Me.BtnMuyLento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMuyLento.Location = New System.Drawing.Point(160, 200)
        Me.BtnMuyLento.Name = "BtnMuyLento"
        Me.BtnMuyLento.Size = New System.Drawing.Size(98, 93)
        Me.BtnMuyLento.TabIndex = 49
        Me.BtnMuyLento.UseVisualStyleBackColor = True
        '
        'BtnMuyFrio
        '
        Me.BtnMuyFrio.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.MuyFrio
        Me.BtnMuyFrio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMuyFrio.Location = New System.Drawing.Point(278, 200)
        Me.BtnMuyFrio.Name = "BtnMuyFrio"
        Me.BtnMuyFrio.Size = New System.Drawing.Size(98, 93)
        Me.BtnMuyFrio.TabIndex = 50
        Me.BtnMuyFrio.UseVisualStyleBackColor = True
        '
        'BtnNoVacio
        '
        Me.BtnNoVacio.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.NoVacio
        Me.BtnNoVacio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNoVacio.Location = New System.Drawing.Point(392, 200)
        Me.BtnNoVacio.Name = "BtnNoVacio"
        Me.BtnNoVacio.Size = New System.Drawing.Size(98, 93)
        Me.BtnNoVacio.TabIndex = 51
        Me.BtnNoVacio.UseVisualStyleBackColor = True
        '
        'BtnNoRapido
        '
        Me.BtnNoRapido.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.NoRapido
        Me.BtnNoRapido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNoRapido.Location = New System.Drawing.Point(509, 200)
        Me.BtnNoRapido.Name = "BtnNoRapido"
        Me.BtnNoRapido.Size = New System.Drawing.Size(98, 93)
        Me.BtnNoRapido.TabIndex = 52
        Me.BtnNoRapido.UseVisualStyleBackColor = True
        '
        'BtnTibio
        '
        Me.BtnTibio.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.tibio
        Me.BtnTibio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTibio.Location = New System.Drawing.Point(45, 308)
        Me.BtnTibio.Name = "BtnTibio"
        Me.BtnTibio.Size = New System.Drawing.Size(98, 93)
        Me.BtnTibio.TabIndex = 53
        Me.BtnTibio.UseVisualStyleBackColor = True
        '
        'BtnLleno
        '
        Me.BtnLleno.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.Lleno
        Me.BtnLleno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLleno.Location = New System.Drawing.Point(160, 308)
        Me.BtnLleno.Name = "BtnLleno"
        Me.BtnLleno.Size = New System.Drawing.Size(98, 93)
        Me.BtnLleno.TabIndex = 54
        Me.BtnLleno.UseVisualStyleBackColor = True
        '
        'BtnRapido
        '
        Me.BtnRapido.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.Rapido
        Me.BtnRapido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRapido.Location = New System.Drawing.Point(278, 308)
        Me.BtnRapido.Name = "BtnRapido"
        Me.BtnRapido.Size = New System.Drawing.Size(98, 93)
        Me.BtnRapido.TabIndex = 55
        Me.BtnRapido.UseVisualStyleBackColor = True
        '
        'BtnMuyCaliente
        '
        Me.BtnMuyCaliente.BackColor = System.Drawing.Color.White
        Me.BtnMuyCaliente.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.MuyCaliente
        Me.BtnMuyCaliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMuyCaliente.Location = New System.Drawing.Point(391, 308)
        Me.BtnMuyCaliente.Name = "BtnMuyCaliente"
        Me.BtnMuyCaliente.Size = New System.Drawing.Size(98, 93)
        Me.BtnMuyCaliente.TabIndex = 56
        Me.BtnMuyCaliente.UseVisualStyleBackColor = False
        '
        'BtnMedioLleno
        '
        Me.BtnMedioLleno.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.MedioLleno
        Me.BtnMedioLleno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMedioLleno.Location = New System.Drawing.Point(509, 308)
        Me.BtnMedioLleno.Name = "BtnMedioLleno"
        Me.BtnMedioLleno.Size = New System.Drawing.Size(98, 93)
        Me.BtnMedioLleno.TabIndex = 57
        Me.BtnMedioLleno.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.boton
        Me.BtnSiguiente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.White
        Me.BtnSiguiente.Location = New System.Drawing.Point(162, 419)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(96, 27)
        Me.BtnSiguiente.TabIndex = 58
        Me.BtnSiguiente.Text = "Siguiente"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(388, 419)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 42)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Escuchar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  nuevo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(233, 477)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 23)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Calificacion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(498, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "de 100%"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BackColor = System.Drawing.Color.Transparent
        Me.lblNumero.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNumero.Location = New System.Drawing.Point(397, 477)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(69, 23)
        Me.lblNumero.TabIndex = 62
        Me.lblNumero.Text = "0.0%"
        '
        'BtnInstruc
        '
        Me.BtnInstruc.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.audio
        Me.BtnInstruc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInstruc.Location = New System.Drawing.Point(577, 26)
        Me.BtnInstruc.Name = "BtnInstruc"
        Me.BtnInstruc.Size = New System.Drawing.Size(44, 41)
        Me.BtnInstruc.TabIndex = 63
        Me.BtnInstruc.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(453, 430)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(36, 31)
        Me.AxWindowsMediaPlayer1.TabIndex = 64
        '
        'frmActInconsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(656, 544)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.BtnInstruc)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnMedioLleno)
        Me.Controls.Add(Me.BtnMuyCaliente)
        Me.Controls.Add(Me.BtnRapido)
        Me.Controls.Add(Me.BtnLleno)
        Me.Controls.Add(Me.BtnTibio)
        Me.Controls.Add(Me.BtnNoRapido)
        Me.Controls.Add(Me.BtnNoVacio)
        Me.Controls.Add(Me.BtnMuyFrio)
        Me.Controls.Add(Me.BtnMuyLento)
        Me.Controls.Add(Me.BtnVacio)
        Me.Controls.Add(Me.BtnLento)
        Me.Controls.Add(Me.BtnMuyCaliente1)
        Me.Controls.Add(Me.BtnMuyLleno)
        Me.Controls.Add(Me.BtnFrio)
        Me.Controls.Add(Me.BtnMuyRapido)
        Me.Controls.Add(Me.BtnMenuPrincipal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmActInconsistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmActInconsistencia"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnMenuPrincipal As Button
    Friend WithEvents BtnMuyRapido As Button
    Friend WithEvents BtnFrio As Button
    Friend WithEvents BtnMuyLleno As Button
    Friend WithEvents BtnMuyCaliente1 As Button
    Friend WithEvents BtnLento As Button
    Friend WithEvents BtnVacio As Button
    Friend WithEvents BtnMuyLento As Button
    Friend WithEvents BtnMuyFrio As Button
    Friend WithEvents BtnNoVacio As Button
    Friend WithEvents BtnNoRapido As Button
    Friend WithEvents BtnTibio As Button
    Friend WithEvents BtnLleno As Button
    Friend WithEvents BtnRapido As Button
    Friend WithEvents BtnMuyCaliente As Button
    Friend WithEvents BtnMedioLleno As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents BtnInstruc As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
