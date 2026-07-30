Imports Analizador_Basico
Imports Analizador_Profundo
Imports Administrador_Archivos

Public Class Router

    Private ReadOnly AnalizadorBasico As New AnalizadorBasico()
    Private ReadOnly AnalizadorProfundo As New AnalizadorProfundo()
    Private ReadOnly Administrador As New AdministradorArchivos()
    Private ReadOnly AnalizadorIntermedio As New AnalizadorIntermedio()


    Public ReadOnly Mensajes As New List(Of String)


    Private ReadOnly Tareas As New Dictionary(Of String, String)


    Public Event Progreso(actual As Integer)



    Public Sub New()

        AddHandler AnalizadorBasico.Progreso,
            AddressOf ActualizarProgreso

        AddHandler AnalizadorIntermedio.Progreso,
            AddressOf ActualizarProgreso

        AddHandler AnalizadorProfundo.Progreso,
            AddressOf ActualizarProgreso


        Tareas.Add("Analizador Básico", "AnalizadorBasico")
        Tareas.Add("Analizador Intermedio", "AnalizadorIntermedio")
        Tareas.Add("Analizador Profundo", "AnalizadorProfundo")
        Tareas.Add("Biblioteca", "Biblioteca")
        Tareas.Add("Playlist", "Playlist")
        Tareas.Add("Administrador Archivos", "AdministradorArchivos")

    End Sub



    Private Sub ActualizarProgreso(valor As Integer)

        RaiseEvent Progreso(valor)

    End Sub




    Public Function ObtenerTareas() As List(Of String)

        Return Tareas.Keys.ToList()

    End Function




    Public Function Ejecutar(tarea As String, ruta As String) As String


        Mensajes.Clear()


        Mensajes.Add("Router recibió: " & tarea)
        Mensajes.Add("Archivo: " & ruta)



        RaiseEvent Progreso(0)



        If Not Tareas.ContainsKey(tarea) Then

            Mensajes.Add("Error: tarea no encontrada")

            Return "Error: tarea no encontrada"

        End If



        Dim modulo As String = Tareas(tarea)


        Mensajes.Add("Módulo seleccionado: " & modulo)



        Select Case modulo


            Case "AdministradorArchivos"

                Mensajes.Add("Entrando a caja Administrador Archivos")


                Dim resultado =
                    Administrador.Validar(ruta)


                Mensajes.Add("Administrador Archivos finalizado")


                RaiseEvent Progreso(100)


                Return resultado




            Case "AnalizadorBasico"


                Mensajes.Add("Ejecutando Analizador Básico")


                Dim resultado =
                    AnalizadorBasico.Analizar(ruta)


                Mensajes.Add("Proceso terminado")


                Return resultado




            Case "AnalizadorIntermedio"


                Mensajes.Add("Ejecutando Analizador Intermedio")


                Dim resultado =
                    AnalizadorIntermedio.Analizar(ruta)


                Mensajes.Add("Analizador Intermedio finalizado")


                Return resultado




            Case "AnalizadorProfundo"


                Mensajes.Add("Entrando a caja Analizador Profundo")


                Dim resultado =
                    AnalizadorProfundo.Analizar(ruta)


                Mensajes.Add("Analizador Profundo finalizado")


                Return resultado




            Case "Biblioteca"

                Mensajes.Add("Ejecutando Biblioteca")

                RaiseEvent Progreso(100)

                Return "Biblioteca ejecutada"




            Case "Playlist"

                Mensajes.Add("Ejecutando Playlist")

                RaiseEvent Progreso(100)

                Return "Playlist ejecutada"




            Case Else

                Return "Módulo no implementado"



        End Select


    End Function


End Class