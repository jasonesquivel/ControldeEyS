Public Class FrmHorarios
    Dim Hor As New dsRegistroEyRTableAdapters.HorarioTableAdapter
    Dim tblhor As New dsRegistroEyR.HorarioDataTable

    Private Sub FrmHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()

    End Sub
    Sub llenarGrid()
        dgv.DataSource = Hor.GetData
        dgv.Refresh()
        dgv.Columns().Item(0).Visible = False
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        editarhorariovb.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        llenarGrid()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        Dim id As Integer
        Dim fila As Integer = dgv.CurrentRow.Index
        id = dgv.Item(0, fila).Value
        editarhorariovb.Txtidhorario.Text = id

        editarhorariovb.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim dato As String = Txtdato.Text
            dgv.DataSource = Hor.Buscarhorario(dato)

            dgv.Refresh()

            GroupBox1.Text = "Registros encontrados: " & dgv.Rows.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Txtdato_TextChanged(sender As Object, e As EventArgs) Handles Txtdato.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class