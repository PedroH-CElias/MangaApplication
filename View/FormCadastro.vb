Imports System.Data.SqlClient

Public Class FormCadastro
    Private Sub Cadastro_Click(sender As Object, e As EventArgs) Handles Cadastro.Click
        If ValidarForm() Then
            CadastrarUsuario()
        End If
    End Sub

    Private Function ValidarForm() As Boolean
        Dim result As Boolean
        If TextUsuario.Text = "" Then
            MsgBox("Campo vazio! Informe seu e-mail!")
            TextUsuario.Focus()
            result = False
        ElseIf TextSenha.Text = "" Then
            MsgBox("Campo vazio! Informe sua senha!")
            TextSenha.Focus()
            result = False
        ElseIf TextSenha.TextLength < 4 Then
            MsgBox("Senha pequena! A senha deve ter no mínimo 4 caracteres!")
            TextSenha.Focus()
            result = False
        Else
            result = True
        End If

        Return result
    End Function

    Private Sub CadastrarUsuario()
        Try
            Using cn = New SqlConnection(strCon)
                cn.Open()

                Dim sql = "INSERT INTO Usuario
                                (email, senha)
                           VALUES 
                                (@email, @senha)"

                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@email", TextUsuario.Text)
                    cmd.Parameters.AddWithValue("@senha", TextSenha.Text)
                    cmd.ExecuteNonQuery()

                End Using

            End Using
            MsgBox("Cadastro Realizado com sucesso!")
            Dispose()
            FormLogin.ShowDialog()
        Catch ex As Exception
            MsgBox("Cadastro Inconcluído! " & vbNewLine, ex.Message)
        End Try
    End Sub

    Private Sub Voltar_Click(sender As Object, e As EventArgs) Handles Voltar.Click
        Dispose()
        FormLogin.ShowDialog()
    End Sub
End Class