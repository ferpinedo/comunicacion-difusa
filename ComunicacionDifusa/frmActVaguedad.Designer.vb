<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActVaguedad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActVaguedad))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnMenuPrincipal = New System.Windows.Forms.Button()
        Me.BtnDelante = New System.Windows.Forms.Button()
        Me.BtnPequeño = New System.Windows.Forms.Button()
        Me.BtnLejos = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnArriba = New System.Windows.Forms.Button()
        Me.BtnAbrir = New System.Windows.Forms.Button()
        Me.BtnAbajo = New System.Windows.Forms.Button()
        Me.BtnDetras = New System.Windows.Forms.Button()
        Me.BtnGrande = New System.Windows.Forms.Button()
        Me.BtnCercas = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Actividad Vaguedad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(537, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 14)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Instrucciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnMenuPrincipal
        '
        Me.BtnMenuPrincipal.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.boton
        Me.BtnMenuPrincipal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMenuPrincipal.ForeColor = System.Drawing.Color.White
        Me.BtnMenuPrincipal.Location = New System.Drawing.Point(12, 349)
        Me.BtnMenuPrincipal.Name = "BtnMenuPrincipal"
        Me.BtnMenuPrincipal.Size = New System.Drawing.Size(106, 55)
        Me.BtnMenuPrincipal.TabIndex = 32
        Me.BtnMenuPrincipal.Text = "  Menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "prinicipal"
        Me.BtnMenuPrincipal.UseVisualStyleBackColor = True
        '
        'BtnDelante
        '
        Me.BtnDelante.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.Delante
        Me.BtnDelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDelante.Location = New System.Drawing.Point(47, 72)
        Me.BtnDelante.Name = "BtnDelante"
        Me.BtnDelante.Size = New System.Drawing.Size(94, 78)
        Me.BtnDelante.TabIndex = 33
        Me.BtnDelante.UseVisualStyleBackColor = True
        '
        'BtnPequeño
        '
        Me.BtnPequeño.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.Pequeño
        Me.BtnPequeño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPequeño.Location = New System.Drawing.Point(159, 72)
        Me.BtnPequeño.Name = "BtnPequeño"
        Me.BtnPequeño.Size = New System.Drawing.Size(94, 78)
        Me.BtnPequeño.TabIndex = 34
        Me.BtnPequeño.UseVisualStyleBackColor = True
        '
        'BtnLejos
        '
        Me.BtnLejos.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.Lejos
        Me.BtnLejos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLejos.Location = New System.Drawing.Point(270, 72)
        Me.BtnLejos.Name = "BtnLejos"
        Me.BtnLejos.Size = New System.Drawing.Size(94, 78)
        Me.BtnLejos.TabIndex = 35
        Me.BtnLejos.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.cerrar
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCerrar.Location = New System.Drawing.Point(380, 72)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(94, 78)
        Me.BtnCerrar.TabIndex = 36
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnArriba
        '
        Me.BtnArriba.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.Arriba
        Me.BtnArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnArriba.Location = New System.Drawing.Point(490, 72)
        Me.BtnArriba.Name = "BtnArriba"
        Me.BtnArriba.Size = New System.Drawing.Size(94, 78)
        Me.BtnArriba.TabIndex = 37
        Me.BtnArriba.UseVisualStyleBackColor = True
        '
        'BtnAbrir
        '
        Me.BtnAbrir.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.abrir
        Me.BtnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbrir.Location = New System.Drawing.Point(47, 165)
        Me.BtnAbrir.Name = "BtnAbrir"
        Me.BtnAbrir.Size = New System.Drawing.Size(94, 78)
        Me.BtnAbrir.TabIndex = 38
        Me.BtnAbrir.UseVisualStyleBackColor = True
        '
        'BtnAbajo
        '
        Me.BtnAbajo.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.Abajo
        Me.BtnAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAbajo.Location = New System.Drawing.Point(159, 165)
        Me.BtnAbajo.Name = "BtnAbajo"
        Me.BtnAbajo.Size = New System.Drawing.Size(94, 78)
        Me.BtnAbajo.TabIndex = 39
        Me.BtnAbajo.UseVisualStyleBackColor = True
        '
        'BtnDetras
        '
        Me.BtnDetras.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.Detras
        Me.BtnDetras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDetras.Location = New System.Drawing.Point(270, 165)
        Me.BtnDetras.Name = "BtnDetras"
        Me.BtnDetras.Size = New System.Drawing.Size(94, 78)
        Me.BtnDetras.TabIndex = 40
        Me.BtnDetras.UseVisualStyleBackColor = True
        '
        'BtnGrande
        '
        Me.BtnGrande.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.Grande
        Me.BtnGrande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGrande.Location = New System.Drawing.Point(380, 165)
        Me.BtnGrande.Name = "BtnGrande"
        Me.BtnGrande.Size = New System.Drawing.Size(94, 78)
        Me.BtnGrande.TabIndex = 41
        Me.BtnGrande.UseVisualStyleBackColor = True
        '
        'BtnCercas
        '
        Me.BtnCercas.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.cerca
        Me.BtnCercas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCercas.Location = New System.Drawing.Point(490, 165)
        Me.BtnCercas.Name = "BtnCercas"
        Me.BtnCercas.Size = New System.Drawing.Size(94, 78)
        Me.BtnCercas.TabIndex = 42
        Me.BtnCercas.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.boton
        Me.BtnSiguiente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.White
        Me.BtnSiguiente.Location = New System.Drawing.Point(159, 259)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(96, 27)
        Me.BtnSiguiente.TabIndex = 43
        Me.BtnSiguiente.Text = "Siguiente"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(377, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 42)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Escuchar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  nuevo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(221, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 23)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Calificacion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(475, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "de 100%"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.BackColor = System.Drawing.Color.Transparent
        Me.lblNumero.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNumero.Location = New System.Drawing.Point(385, 324)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(69, 23)
        Me.lblNumero.TabIndex = 47
        Me.lblNumero.Text = "0.0%"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(439, 267)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(35, 34)
        Me.AxWindowsMediaPlayer1.TabIndex = 48
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.audio
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(567, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 42)
        Me.Button1.TabIndex = 49
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmActVaguedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(645, 416)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnCercas)
        Me.Controls.Add(Me.BtnGrande)
        Me.Controls.Add(Me.BtnDetras)
        Me.Controls.Add(Me.BtnAbajo)
        Me.Controls.Add(Me.BtnAbrir)
        Me.Controls.Add(Me.BtnArriba)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnLejos)
        Me.Controls.Add(Me.BtnPequeño)
        Me.Controls.Add(Me.BtnDelante)
        Me.Controls.Add(Me.BtnMenuPrincipal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmActVaguedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmActVaguedad"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnMenuPrincipal As Button
    Friend WithEvents BtnDelante As Button
    Friend WithEvents BtnPequeño As Button
    Friend WithEvents BtnLejos As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnArriba As Button
    Friend WithEvents BtnAbrir As Button
    Friend WithEvents BtnAbajo As Button
    Friend WithEvents BtnDetras As Button
    Friend WithEvents BtnGrande As Button
    Friend WithEvents BtnCercas As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button1 As Button
End Class
