Public Class FormAnalizadorProfundo


    Private ReadOnly Analizador As New AnalizadorProfundo()



    Private Sub FormAnalizadorProfundo_Load(sender As Object,
                                             e As EventArgs) Handles MyBase.Load

        AddHandler Analizador.Progreso,
            AddressOf ActualizarProgreso

    End Sub



    Private Async Sub btnAnalizar_Click(sender As Object,
                                        e As EventArgs) Handles btnAnalizar.Click


        btnAnalizar.Enabled = False

        lblResultado.Text = "Analizando..."


        Dim resultado As String =
            Await Task.Run(Function()

                               Return Analizador.Analizar(txtRuta.Text)

                           End Function)



        lblResultado.Text = resultado


        btnAnalizar.Enabled = True


    End Sub




    Private Sub ActualizarProgreso(valor As Integer)


        If InvokeRequired Then

            Invoke(Sub()
                       ActualizarProgreso(valor)
                   End Sub)

            Return

        End If



        ProgressBar1.Value = valor

        lblProgreso.Text = valor & "%"



    End Sub



End Class