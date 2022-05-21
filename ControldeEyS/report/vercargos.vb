Public Class vercargos
    Private Sub vercargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()

    End Sub
    Private Sub vercargos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class