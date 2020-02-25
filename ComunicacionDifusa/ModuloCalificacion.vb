Module ModuloCalificacion
    Public aciertos
    Public errores
    Function Porcentaje(ByVal Exitos, ByVal Intentos) As String
        Dim calificacion As Double
        calificacion = Exitos / Intentos
        Porcentaje = Format(calificacion, "0.0%")
    End Function
End Module
