Public Class Frmvistapreviacargos

    Dim pues As New dsRegistroEyRTableAdapters.PuestoTableAdapter
    Dim tblpues As New dsRegistroEyR.PuestoDataTable

    Dim newpues As New dsRegistroEyRTableAdapters.RptCargosTableAdapter
    Dim newtblpues As New dsRegistroEyR.RptCargosDataTable

    Private Sub Frmvistapreviacargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarGrid()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        newpues.Fill(newtblpues)
        VerReporte(newtblpues, "DataSet1", "c:\Reportes\NewRptCargos.rdlc")

    End Sub

    Sub llenarGrid()
        dgv.DataSource = pues.GetDataBy11
        dgv.Refresh()
        dgv.Columns().Item(0).Visible = False
        dgv.Columns().Item(3).Visible = False

        GroupBox1.Text = "Registros guardados: " & dgv.Rows.Count.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
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





    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        Dim id As Integer
        Dim fila As Integer = dgv.CurrentRow.Index
        id = dgv.Item(0, fila).Value
        editarcargo.Txtidcargo.Text = id
        editarcargo.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim dato As String = Txtdato.Text
            dgv.DataSource = pues.Buscarpornombre(dato)

            dgv.Refresh()

            GroupBox1.Text = "Registros encontrados: " & dgv.Rows.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class