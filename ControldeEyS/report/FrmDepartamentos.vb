

Public Class FrmDepartamentos

    Dim depa As New dsRegistroEyRTableAdapters.DepartamentoTableAdapter
    Dim tbldep As New dsRegistroEyR.DepartamentoDataTable
    Dim iddepartamento As Integer
    Dim estado As Boolean

    Private Sub rpydepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        depa.Fill(tbldep)
        VerReporte(tbldep, "DataSet1", "c:\Reportes\rptdepartamentos.rdlc")
    End Sub
    Sub llenarGrid()
        dgv.DataSource = depa.GetData
        dgv.Refresh()
        'ocultar columna
        'DgvRegistros.Columns().Item().Visible = False
        GroupBox1.Text = "Registros guardados: " & dgv.Rows.Count.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        agregardepartamento.Show()
        llenarGrid()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        editardep.Show()

        llenarGrid()


    End Sub
    Private Sub rptdepartamentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        agregardepartamento.Close()
        editardep.Close()
        Form1.Show()

    End Sub





    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        llenarGrid()
    End Sub
End Class