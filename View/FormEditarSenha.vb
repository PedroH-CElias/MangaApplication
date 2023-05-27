Public Class FormEditarSenha
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Salvar_Click(sender As Object, e As EventArgs) Handles Salvar.Click
        MsgBox("Senha alterada com sucesso!")
        Dispose()
        FormLogin.ShowDialog()

    End Sub

    Private Sub Voltar_Click(sender As Object, e As EventArgs) Handles Voltar.Click
        Dispose()
        FormLogin.ShowDialog()
    End Sub
End Class