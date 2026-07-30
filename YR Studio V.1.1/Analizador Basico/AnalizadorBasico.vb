Imports TagLib

Public Class AnalizadorBasico

    Public Event Progreso(actual As Integer)


    Public Function Analizar(ruta As String) As String

        If String.IsNullOrWhiteSpace(ruta) Then
            Return "Error: Ruta vacía"
        End If


        If Not IO.File.Exists(ruta) Then
            Return "Error: Archivo no encontrado"
        End If


        RaiseEvent Progreso(0)


        Dim resultado As New Text.StringBuilder()

        Dim info As New IO.FileInfo(ruta)


        resultado.AppendLine("=== ANALISIS BASICO ===")
        resultado.AppendLine()


        RaiseEvent Progreso(25)


        resultado.AppendLine("Archivo: " &
                             info.Name)


        resultado.AppendLine("Formato: " &
                             info.Extension)


        resultado.AppendLine("Tamaño: " &
                             Math.Round(info.Length / 1024 / 1024, 2) &
                             " MB")


        resultado.AppendLine("Fecha creación: " &
                             info.CreationTime)


        resultado.AppendLine("Última modificación: " &
                             info.LastWriteTime)



        RaiseEvent Progreso(50)



        Using archivoAudio As TagLib.File =
            TagLib.File.Create(ruta)


            Dim propiedades =
                archivoAudio.Properties



            resultado.AppendLine()

            resultado.AppendLine("=== DATOS DE AUDIO ===")



            resultado.AppendLine("Duración: " &
                                 propiedades.Duration.ToString())


            resultado.AppendLine("Bitrate: " &
                                 propiedades.AudioBitrate &
                                 " kbps")


            resultado.AppendLine("Frecuencia: " &
                                 propiedades.AudioSampleRate &
                                 " Hz")


            resultado.AppendLine("Canales: " &
                                 propiedades.AudioChannels)



            RaiseEvent Progreso(75)



            resultado.AppendLine()


            If archivoAudio.Tag.Performers.Length > 0 Then

                resultado.AppendLine("Artista: " &
                                     archivoAudio.Tag.Performers(0))

            End If



            If Not String.IsNullOrWhiteSpace(
                archivoAudio.Tag.Title) Then

                resultado.AppendLine("Título: " &
                                     archivoAudio.Tag.Title)

            End If



            If Not String.IsNullOrWhiteSpace(
                archivoAudio.Tag.Album) Then

                resultado.AppendLine("Álbum: " &
                                     archivoAudio.Tag.Album)

            End If



        End Using



        RaiseEvent Progreso(100)



        Return resultado.ToString()


    End Function


End Class