Public Class FormPrincipal
    Private Sub btnAnalizadorBasico_Click(sender As Object, e As EventArgs) Handles btnAnalizadorBasico.Click
        FormAnalizadorBasico.Show()
    End Sub

    Private Sub btRouter_Click(sender As Object, e As EventArgs) Handles btRouter.Click
        FormRouter.Show()
    End Sub

    Private Sub btAnalizadorCompleto_Click(sender As Object, e As EventArgs) Handles btAnalizadorCompleto.Click
        FormAnalizadorProfundo.Show()
    End Sub

    Private Sub btnAdministradorArchivos_Click(sender As Object, e As EventArgs) Handles btnAdministradorArchivos.Click
        FormAdministradorArchivos.Show()
    End Sub

    Private Sub btnAnalizadorIntermedio_Click(sender As Object, e As EventArgs) Handles btnAnalizadorIntermedio.Click
        FormAnalizadorIntermedio.Show()
    End Sub
End Class