﻿Imports System.Data.SqlClient

Public Class FormLogin

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        RealizarLogin()
    End Sub

    Private Sub LinkLabelCadastro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelCadastro.LinkClicked
        Dispose()
        FormCadastro.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dispose()
        FormEditarSenha.ShowDialog()
    End Sub

    Private Sub Fechar_Click(sender As Object, e As EventArgs) Handles Fechar.Click
        Application.Exit()
    End Sub

    Private Sub RealizarLogin()
        Dim AcessoPermitido As Boolean

        Try
            Using cn = New SqlConnection(strCon)
                cn.Open()
                Dim sql = "SELECT email, senha FROM Usuario WHERE email=@Email AND senha=@Senha"

                Using cmd = New SqlCommand(sql, cn)

                        cmd.Parameters.AddWithValue("@Email", TextUsuario.Text)
                        cmd.Parameters.AddWithValue("@Senha", TextSenha.Text)

                        Using dr = cmd.ExecuteReader()
                            If dr.HasRows Then
                                If dr.Read() Then
                                    If dr("senha") = TextSenha.Text And dr("email") = TextUsuario.Text Then
                                        AcessoPermitido = True
                                    End If
                                End If
                            End If
                        End Using
                    End Using
                End Using
        Catch ex As Exception
            MsgBox("Falha ao conectar!")
        End Try

        If AcessoPermitido Then
            TelaPrincipal.ShowDialog()
            Me.Close()
        Else
            MsgBox("Usuario ou senha inválidos!", TextUsuario.Focus())
        End If
    End Sub

    Private Sub MostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles MostrarSenha.CheckedChanged

        If MostrarSenha.Checked Then
            TextSenha.PasswordChar = ""
        Else
            TextSenha.PasswordChar = "*"
        End If
    End Sub
End Class
