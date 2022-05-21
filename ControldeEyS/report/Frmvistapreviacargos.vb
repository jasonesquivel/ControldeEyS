Public Class Frmvistapreviacargos

    Dim pues As New dsRegistroEyRTableAdapters.PuestoTableAdapter
    Dim tblpues As New dsRegistroEyR.PuestoDataTable

    Private Sub Frmvistapreviacargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarGrid()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pues.Fill(tblpues)
        VerReporte(tblpues, "DataSet1", "c:\Reportes\rptCargos.rdlc")

    End Sub

    Sub llenarGrid()
        dgv.DataSource = pues.GetDataBy11
        dgv.Refresh()

        GroupBox1.Text = "Registros guardados: " & dgv.Rows.Count.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        editarcargo.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        agregarcargo.Show()

    End Sub

    Private Sub Frmvistapreviacargos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        agregarcargo.Close()
        editarcargo.Close()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        llenarGrid()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class