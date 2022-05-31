Public Class frmregistrodecuentas

    Dim registrod As New dsRegistroEyRTableAdapters.RegistrodecuentascreadasTableAdapter
    Dim tblregistrod As New dsRegistroEyR.RegistrodecuentascreadasDataTable
    Private Sub frmregistrodecuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
    End Sub
    Sub llenarGrid()


        dgv.DataSource = registrod.GetData
        dgv.Refresh()
        'ocultar columna
        dgv.Columns().Item(4).Visible = False

        GroupBox1.Text = "Registros guardados: " & dgv.Rows.Count.ToString
    End Sub
End Class