Imports NAudio.Wave
Imports System.Security.Cryptography

Public Class AnalizadorProfundo

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


        Dim rms As Double = 0
        Dim pico As Double = 0
        Dim cantidad As Long = 0


        Using lector As New AudioFileReader(ruta)

            Dim buffer(4095) As Single

            Dim canales As Integer =
                lector.WaveFormat.Channels


            While True

                Dim leidas =
                    lector.Read(buffer, 0, buffer.Length)


                If leidas = 0 Then Exit While


                For i As Integer = 0 To leidas - 1 Step canales

                    Dim nivel As Double = 0


                    For c As Integer = 0 To canales - 1

                        If i + c < leidas Then

                            Dim muestra =
                                Math.Abs(buffer(i + c))


                            nivel = Math.Max(nivel, muestra)


                            rms += muestra * muestra


                            If muestra > pico Then
                                pico = muestra
                            End If


                            cantidad += 1

                        End If

                    Next


                Next


            End While


        End Using


        RaiseEvent Progreso(50)


        If cantidad > 0 Then

            rms = Math.Sqrt(
                rms / cantidad)

        End If



        Dim lufs As Double =
            CalcularLUFS(rms)


        Dim dinamica As Double =
            CalcularRangoDinamico(
                pico,
                rms)



        RaiseEvent Progreso(75)


        Dim huella As String =
            CalcularHash(ruta)


        RaiseEvent Progreso(100)



        resultado.AppendLine("=== ANALISIS PROFUNDO ===")
        resultado.AppendLine()

        resultado.AppendLine("RMS: " &
                             Math.Round(rms, 4))


        resultado.AppendLine("Pico máximo: " &
                             Math.Round(pico, 4))


        resultado.AppendLine("LUFS: " &
                             Math.Round(lufs, 2))


        resultado.AppendLine("Rango dinámico: " &
                             Math.Round(dinamica, 2) &
                             " dB")


        resultado.AppendLine()

        resultado.AppendLine("Huella: " &
                             huella)


        Return resultado.ToString()


    End Function



    Private Function CalcularLUFS(rms As Double) As Double

        If rms <= 0 Then
            Return -100
        End If


        Return 20 * Math.Log10(rms)

    End Function



    Private Function CalcularRangoDinamico(
        pico As Double,
        rms As Double) As Double


        If rms <= 0 Then
            Return 0
        End If


        Return 20 *
            Math.Log10(pico / rms)


    End Function



    Private Function CalcularHash(
        ruta As String) As String


        Using md5 As MD5 =
            MD5.Create()


            Using stream As IO.FileStream =
                IO.File.OpenRead(ruta)


                Dim hash =
                    md5.ComputeHash(stream)


                Return BitConverter.ToString(hash).
                    Replace("-", "")


            End Using


        End Using


    End Function


End Class
