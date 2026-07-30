Public Class AdministradorArchivos


    Public Function Validar(ruta As String) As String

        If String.IsNullOrWhiteSpace(ruta) Then
            Return "Error: Ruta vacía"
        End If


        If Not IO.File.Exists(ruta) Then
            Return "Error: Archivo no encontrado"
        End If


        Dim info As New IO.FileInfo(ruta)


        Return "Archivo válido: " & vbCrLf &
               "Nombre: " & info.Name & vbCrLf &
               "Tamaño: " & info.Length & " bytes"

    End Function


End Class