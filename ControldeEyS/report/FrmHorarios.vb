Public Class FrmHorarios
    Dim Hor As New dsRegistroEyRTableAdapters.HorarioTableAdapter
    Dim tblhor As New dsRegistroEyR.HorarioDataTable
    Private Sub FrmHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()

    End Sub
    Sub llenarGrid()
        dgv.DataSource = Hor.GetData
        dgv.Refresh()

        GroupBox1.Text = "Registros guardados: " & dgv.Rows.Count.ToString
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Hor.Fill(tblhor)
        VerReporte(tblhor, "DataSet1", "c:\Reportes\rptHorario.rdlc")
    End Sub
    Private Sub FrmHorario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        editarempleado.Close()
        agregarempleado.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        agregarhorario.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        editarhorariovb.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        llenarGrid()
    End Sub
End Class