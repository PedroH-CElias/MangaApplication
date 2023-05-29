Imports System.Data.SqlClient


Public Class FormEditarSenha

    Private Sub Salvar_Click(sender As Object, e As EventArgs) Handles Salvar.Click
        If ValidarForm() Then
            SalvarNovaSenha()
            MsgBox("Senha alterada com sucesso!")
            Dispose()
            FormLogin.ShowDialog()
        End If
    End Sub

    Private Sub Voltar_Click(sender As Object, e As EventArgs) Handles Voltar.Click
        Dispose()
        FormLogin.ShowDialog()
    End Sub

    Private Sub SalvarNovaSenha()
        Dim sql = ("UPDATE Usuario SET senha=@Senha WHERE email=@Email")

        Try
            Using cn = New SqlConnection(strCon)
                cn.Open()

                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@Email", TextUsuario.Text)
                    cmd.Parameters.AddWithValue("@Senha", TextNovaSenha.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha!")
        End Try
    End Sub


    Private Function ValidarForm() As Boolean
        Dim result As Boolean

        If Not ValidarSenhaAtual() Then
            MsgBox("Senha atual inválida!")
            TextSenhaAtual.Focus()
            result = False
        ElseIf TextNovaSenha.Text = "" Then
            MsgBox("Campo vazio! Informe sua nova senha!")
            TextNovaSenha.Focus()
            result = False
        ElseIf TextConfirmarSenha.Text = "" Then
            MsgBox("Campo vazio! Confirme sua senha!")
            TextConfirmarSenha.Focus()
            result = False
        ElseIf TextNovaSenha.TextLength < 4 Then
            MsgBox("Senha pequena! A senha deve ter no mínimo 4 caracteres!")
            TextNovaSenha.Focus()
            result = False
        ElseIf TextNovaSenha.Text <> TextConfirmarSenha.Text Then
            MsgBox("As senhas não coincidem!")
            TextNovaSenha.Focus()
            result = False
        Else
            result = True
        End If

        Return result
    End Function

    Private Function ValidarSenhaAtual()
        Dim sql = "SELECT senha FROM Usuario WHERE email=@email"
        Dim result As Boolean

        Try
            Using cn = New SqlConnection(strCon)
                cn.Open()

                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@Email", textUsuario.Text)

                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If TextSenhaAtual.Text = dr("senha") Then
                                    result = True
                                Else
                                    result = False
                                End If
                            End If
                        End If

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha!")
            result = False
        End Try

        Return result
    End Function

    Private Sub MostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles MostrarSenha.CheckedChanged
        If MostrarSenha.Checked Then
            TextSenhaAtual.PasswordChar = ""
            TextNovaSenha.PasswordChar = ""
            TextConfirmarSenha.PasswordChar = ""
        Else
            TextSenhaAtual.PasswordChar = "*"
            TextNovaSenha.PasswordChar = "*"
            TextConfirmarSenha.PasswordChar = "*"
        End If
    End Sub
End Class