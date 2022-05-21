Public Class FrmEmpleados
    Dim emp As New dsRegistroEyRTableAdapters.EmpleadoTableAdapter
    Dim empv As New dsRegistroEyRTableAdapters.DataTable1TableAdapter
    Dim tblemp As New dsRegistroEyR.EmpleadoDataTable
    Private Sub Frmvistaprevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarGrid()


    End Sub

    Sub llenarGrid()
        dgv.DataSource = empv.GetData
        dgv.Refresh()

        GroupBox1.Text = "Registros guardados: " & dgv.Rows.Count.ToString
    End Sub


    Private Sub Frmvistaprevia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        editarempleado.Close()
        agregarempleado.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        agregarempleado.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        editarempleado.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        emp.Fill(tblemp)
        VerReporte(tblemp, "DataSet1", "c:\Reportes\RptEmpleados.rdlc")
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        llenarGrid()
    End Sub
End Class