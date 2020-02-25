<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Inconsistencia = New System.Windows.Forms.Button()
        Me.Vaguedad = New System.Windows.Forms.Button()
        Me.Ambiguedad = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Inconsistencia
        '
        Me.Inconsistencia.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.boton
        Me.Inconsistencia.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inconsistencia.ForeColor = System.Drawing.SystemColors.Control
        Me.Inconsistencia.Location = New System.Drawing.Point(520, 103)
        Me.Inconsistencia.Name = "Inconsistencia"
        Me.Inconsistencia.Size = New System.Drawing.Size(151, 155)
        Me.Inconsistencia.TabIndex = 3
        Me.Inconsistencia.Text = "Inconsistencia"
        Me.Inconsistencia.UseVisualStyleBackColor = True
        '
        'Vaguedad
        '
        Me.Vaguedad.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.boton
        Me.Vaguedad.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vaguedad.ForeColor = System.Drawing.SystemColors.Control
        Me.Vaguedad.Location = New System.Drawing.Point(300, 103)
        Me.Vaguedad.Name = "Vaguedad"
        Me.Vaguedad.Size = New System.Drawing.Size(151, 155)
        Me.Vaguedad.TabIndex = 2
        Me.Vaguedad.Text = "Vaguedad"
        Me.Vaguedad.UseVisualStyleBackColor = True
        '
        'Ambiguedad
        '
        Me.Ambiguedad.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.boton
        Me.Ambiguedad.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ambiguedad.ForeColor = System.Drawing.SystemColors.Control
        Me.Ambiguedad.Location = New System.Drawing.Point(83, 103)
        Me.Ambiguedad.Name = "Ambiguedad"
        Me.Ambiguedad.Size = New System.Drawing.Size(151, 155)
        Me.Ambiguedad.TabIndex = 1
        Me.Ambiguedad.Text = "Ambigüedad"
        Me.Ambiguedad.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.boton
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(635, 341)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 45)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.audio
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(131, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 45)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.audio
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(353, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 45)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.audio
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.Control
        Me.Button4.Location = New System.Drawing.Point(571, 264)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 45)
        Me.Button4.TabIndex = 9
        Me.Button4.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(80, 28)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(10, 10)
        Me.AxWindowsMediaPlayer1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "MENU"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ComunicacionDifusa.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(760, 398)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Inconsistencia)
        Me.Controls.Add(Me.Vaguedad)
        Me.Controls.Add(Me.Ambiguedad)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambiguedad As Button
    Friend WithEvents Vaguedad As Button
    Friend WithEvents Inconsistencia As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label1 As Label
End Class
