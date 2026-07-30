Imports NAudio.Wave

Public Class AnalizadorIntermedio

    Public Event Progreso(actual As Integer)


    Public Function Analizar(ruta As String) As String

        If String.IsNullOrWhiteSpace(ruta) Then
            Return "Error: Ruta vacía"
        End If


        If Not IO.File.Exists(ruta) Then
            Return "Error: Archivo no encontrado"
        End If


        RaiseEvent Progreso(0)


        Const Umbral As Single = 0.01F


        Dim inicio As TimeSpan = TimeSpan.Zero
        Dim fin As TimeSpan = TimeSpan.Zero
        Dim duracion As TimeSpan


        Dim hayL As Boolean = False
        Dim hayR As Boolean = False


        Dim primerFrame As Long = -1
        Dim ultimoFrame As Long = 0


        Dim canales As Integer
        Dim sampleRate As Integer



        Using lector As New AudioFileReader(ruta)

            duracion = lector.TotalTime

            canales = lector.WaveFormat.Channels
            sampleRate = lector.WaveFormat.SampleRate


            Dim buffer(4095) As Single


            Dim frameActual As Long = 0



            While True


                Dim leidas =
                    lector.Read(buffer, 0, buffer.Length)


                If leidas = 0 Then Exit While



                For i As Integer = 0 To leidas - 1 Step canales


                    Dim muestraL As Single = 0
                    Dim muestraR As Single = 0



                    If i < leidas Then
                        muestraL = buffer(i)
                    End If



                    If canales > 1 AndAlso i + 1 < leidas Then
                        muestraR = buffer(i + 1)
                    Else
                        muestraR = muestraL
                    End If



                    If Math.Abs(muestraL) > Umbral Then
                        hayL = True
                    End If



                    If Math.Abs(muestraR) > Umbral Then
                        hayR = True
                    End If



                    Dim nivel As Single =
                        Math.Max(Math.Abs(muestraL),
                                 Math.Abs(muestraR))



                    If nivel > Umbral Then


                        If primerFrame = -1 Then
                            primerFrame = frameActual
                        End If


                        ultimoFrame = frameActual


                    End If



                    frameActual += 1


                Next


                If frameActual Mod 50000 = 0 Then

                    Dim porcentaje As Integer =
                        CInt((frameActual /
                        (duracion.TotalSeconds *
                        sampleRate)) * 100)


                    If porcentaje > 95 Then
                        porcentaje = 95
                    End If


                    RaiseEvent Progreso(porcentaje)

                End If


            End While


        End Using



        RaiseEvent Progreso(100)



        If primerFrame >= 0 Then

            inicio =
                TimeSpan.FromSeconds(
                    primerFrame / sampleRate)


            fin =
                TimeSpan.FromSeconds(
                    ultimoFrame / sampleRate)

        End If



        Dim silencioInicial As TimeSpan =
            inicio


        Dim silencioFinal As TimeSpan =
            duracion - fin



        Dim duracionEfectiva As TimeSpan =
            fin - inicio



        Dim condicion As String



        If canales = 1 Then

            condicion = "Mono"


        ElseIf hayL AndAlso hayR Then

            condicion = "Estéreo"


        ElseIf hayL OrElse hayR Then

            condicion = "Mono detectado (L+R)"


        Else

            condicion = "Silencio"

        End If



        Dim sb As New Text.StringBuilder



        sb.AppendLine("=== ANALISIS INTERMEDIO ===")
        sb.AppendLine()


        sb.AppendLine("Condición audio: " &
                      condicion)


        sb.AppendLine("Canales: " &
                      canales)


        sb.AppendLine()


        sb.AppendLine("Duración total: " &
                      duracion.ToString("hh\:mm\:ss"))


        sb.AppendLine("Silencio inicial: " &
                      silencioInicial.ToString("hh\:mm\:ss"))


        sb.AppendLine("Silencio final: " &
                      silencioFinal.ToString("hh\:mm\:ss"))


        sb.AppendLine()


        sb.AppendLine("Inicio efectivo: " &
                      inicio.ToString("hh\:mm\:ss"))


        sb.AppendLine("Final efectivo: " &
                      fin.ToString("hh\:mm\:ss"))


        sb.AppendLine("Duración efectiva: " &
                      duracionEfectiva.ToString("hh\:mm\:ss"))



        Return sb.ToString()


    End Function


End Class