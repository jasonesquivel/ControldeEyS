Public Class verempleado
    Private Sub verempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub verempleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub
End Class