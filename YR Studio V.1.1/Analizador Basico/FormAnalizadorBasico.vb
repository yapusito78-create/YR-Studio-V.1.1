Public Class FormAnalizadorBasico

    Private ReadOnly Analizador As New AnalizadorBasico()


    Private Sub FormAnalizadorBasico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler Analizador.Progreso,
            AddressOf ActualizarProgreso

    End Sub



    Private Sub btnAnalizar_Click(sender As Object, e As EventArgs) Handles btnAnalizar.Click

        Dim resultado As String

        resultado = Analizador.Analizar(txtRuta.Text)

        lblResultado.Text = resultado

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