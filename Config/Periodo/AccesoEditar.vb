Public Class AccesoEditar
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtKey.TextChanged

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Hide()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtKey.Text = "nice" Then
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.No
        End If
        Hide()
    End Sub
End Class