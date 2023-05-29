Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FormCadastro
    Private Sub Cadastro_Click(sender As Object, e As EventArgs) Handles Cadastro.Click
        If ValidarForm() Then
            CadastrarUsuario()
        End If
    End Sub

    Private Function ValidarForm() As Boolean
        Dim result As Boolean
        If ValidarEmailExistente() = True Then
            MsgBox("Email ja cadastrado!")
            TextUsuario.Focus()
            result = False
        ElseIf ValidarEmail(TextUsuario.Text) = False Then
            MsgBox("Email invalido! Fora do padrao")
            TextUsuario.Focus()
            result = False
        ElseIf TextUsuario.Text = "" Then
            MsgBox("Campo vazio! Informe seu e-mail!")
            TextUsuario.Focus()
            result = False
        ElseIf TextSenha.Text = "" Then
            MsgBox("Campo vazio! Informe sua senha!")
            TextSenha.Focus()
            result = False
        ElseIf TextNome.Text = "" Then
            MsgBox("Campo vazio! Informe seu nome!")
            TextNome.Focus()
            result = False
        ElseIf MaskedCPF.Text = "" Then
            MsgBox("Campo vazio! Informe seu CPF!")
            MaskedCPF.Focus()
            result = False
        ElseIf TextIdade.Text = "" Then
            MsgBox("Campo vazio! Informe sua idade!")
            TextIdade.Focus()
            result = False
        ElseIf TextProfissao.Text = "" Then
            MsgBox("Campo vazio! Informe sua profissao!")
            TextProfissao.Focus()
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
                                (email, senha, cpf, nome, idade, profissao)
                           VALUES 
                                (@email, @senha, @cpf, @nome, @idade, @profissao)"

                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@email", TextUsuario.Text)
                    cmd.Parameters.AddWithValue("@senha", TextSenha.Text)
                    cmd.Parameters.AddWithValue("@cpf", MaskedCPF.Text)
                    cmd.Parameters.AddWithValue("@nome", TextNome.Text)
                    cmd.Parameters.AddWithValue("@idade", TextIdade.Text)
                    cmd.Parameters.AddWithValue("@profissao", TextProfissao.Text)
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

    Private Function ValidarEmailExistente()

        Dim sql = "SELECT COUNT(*) FROM Usuario WHERE email=@Email "
        Dim result As Boolean
        Try
            Using cn = New SqlConnection(strCon)
                cn.Open()

                Using cmd = New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@Email", TextUsuario.Text)

                    Dim cont As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If cont > 0 Then
                        result = True
                    Else
                        result = False
                    End If

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha!")
            result = True
        End Try

        Return result
    End Function

    Public Function ValidarEmail(email As String) As Boolean
        Dim padrao As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(padrao)
        Dim match As Match = regex.Match(email)
        Return match.Success
    End Function

    Private Sub Voltar_Click(sender As Object, e As EventArgs) Handles Voltar.Click
        Dispose()
        FormLogin.ShowDialog()
    End Sub

    Private Sub MostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles MostrarSenha.CheckedChanged

        If MostrarSenha.Checked Then
            TextSenha.PasswordChar = ""
        Else
            TextSenha.PasswordChar = "*"
        End If

    End Sub


End Class