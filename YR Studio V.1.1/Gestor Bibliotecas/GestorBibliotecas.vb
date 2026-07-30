Imports System.IO
Imports System.Text.Json

Public Class GestorBibliotecas


    Private ReadOnly ArchivoTemporal As String =
        "BibliotecaTemporal.json"


    Private ReadOnly ArchivoDefinitivo As String =
        "BibliotecaYR.json"



    Public Function GuardarBasico(datos As Object) As Boolean

        Try

            Dim json As String =
                JsonSerializer.Serialize(datos,
                New JsonSerializerOptions With {
                    .WriteIndented = True
                })


            File.WriteAllText(ArchivoTemporal, json)


            Return True


        Catch ex As Exception

            Return False

        End Try


    End Function




    Public Function ActualizarIntermedio(datos As Object) As Boolean

        Try

            Dim jsonActual As Object = Nothing


            If File.Exists(ArchivoTemporal) Then

                Dim contenido As String =
                    File.ReadAllText(ArchivoTemporal)


                jsonActual =
                    JsonSerializer.Deserialize(Of Object)(contenido)

            End If



            File.WriteAllText(
                ArchivoTemporal,
                JsonSerializer.Serialize(datos,
                New JsonSerializerOptions With {
                    .WriteIndented = True
                }))


            Return True


        Catch ex As Exception

            Return False

        End Try


    End Function




    Public Function FinalizarProfundo(datos As Object) As Boolean

        Try


            Dim json As String =
                JsonSerializer.Serialize(datos,
                New JsonSerializerOptions With {
                    .WriteIndented = True
                })


            File.WriteAllText(
                ArchivoDefinitivo,
                json)



            If File.Exists(ArchivoTemporal) Then

                File.Delete(ArchivoTemporal)

            End If



            Return True


        Catch ex As Exception

            Return False

        End Try


    End Function




    Public Function ExisteTemporal() As Boolean

        Return File.Exists(ArchivoTemporal)

    End Function



    Public Function ExisteDefinitiva() As Boolean

        Return File.Exists(ArchivoDefinitivo)

    End Function



End Class