Public Class FormRouter

    Private ReadOnly _router As New Router()


    Private Sub FormRouter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler _router.Progreso,
            AddressOf ActualizarProgreso


        lvMensajes.View = View.Details
        lvMensajes.FullRowSelect = True
        lvMensajes.GridLines = True


        If lvMensajes.Columns.Count = 0 Then
            lvMensajes.Columns.Add("Mensaje", 400)
        End If



        cmbTarea.Items.Clear()


        For Each tarea As String In _router.ObtenerTareas()

            cmbTarea.Items.Add(tarea)

        Next



        If cmbTarea.Items.Count > 0 Then

            cmbTarea.SelectedIndex = 0

        End If


    End Sub



    Private Async Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        btnEnviar.Enabled = False

        lblResultado.Text = "Procesando..."


        Dim tarea As String = cmbTarea.Text
        Dim ruta As String = txtRuta.Text



        Dim resultado As String =
        Await Task.Run(Function()

                           Return _router.Ejecutar(tarea, ruta)

                       End Function)



        lblResultado.Text = resultado



        lvMensajes.Items.Clear()


        For Each mensaje As String In _router.Mensajes

            Dim item As New ListViewItem(mensaje)

            lvMensajes.Items.Add(item)

        Next



        btnEnviar.Enabled = True


    End Sub


    Private Sub ActualizarProgreso(valor As Integer)


        If InvokeRequired Then

            Invoke(Sub()

                       ActualizarProgreso(valor)

                   End Sub)

            Return

        End If



        If valor >= 0 AndAlso valor <= 100 Then

            ProgressBar1.Value = valor

        End If


        lblProgreso.Text = valor & "%"


    End Sub



    Private Sub btnCopiarMensajes_Click(sender As Object, e As EventArgs) Handles btnCopiarMensajes.Click


        Dim texto As New Text.StringBuilder



        For Each item As ListViewItem In lvMensajes.Items

            texto.AppendLine(item.Text)

        Next



        Clipboard.SetText(texto.ToString)


    End Sub


End Class