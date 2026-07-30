Public Class FormAdministradorArchivos

    Private ReadOnly Administrador As New AdministradorArchivos()


    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click

        Dim resultado As String

        resultado = Administrador.Validar(txtRuta.Text)

        lblResultado.Text = resultado

    End Sub


End Class