Public Class frmTestReportevb
    Private Sub frmTestReportevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadosFinancieros.TestAbrir(Me, "")
        WindowState = Windows.Forms.FormWindowState.Maximized
    End Sub
End Class