Imports System.Data.SqlClient


Public Class TelaInicial
    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        Dispose()
        FormLogin.Show()
    End Sub

End Class