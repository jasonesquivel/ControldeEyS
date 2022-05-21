Public Class Frmvistaprevia
    Private Sub Frmvistaprevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        agregarempleado.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        editarempleado.Show()

    End Sub
    Private Sub Frmvistaprevia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        editarempleado.Close()
        agregarempleado.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class