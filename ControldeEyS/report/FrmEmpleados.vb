Public Class FrmEmpleados
    Dim emp As New dsRegistroEyRTableAdapters.EmpleadoTableAdapter
    Dim empv As New dsRegistroEyRTableAdapters.DataTable1TableAdapter
    Dim tblemp As New dsRegistroEyR.EmpleadoDataTable


    Dim newemp As New dsRegistroEyRTableAdapters.RptEmpleadosTableAdapter
    Dim newtblemp As New dsRegistroEyR.RptEmpleadosDataTable


    Private Sub Frmvistaprevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarGrid()


    End Sub

    Sub llenarGrid()
        dgv.DataSource = empv.GetData

        dgv.Refresh()
        dgv.Columns().Item(0).Visible = False
        dgv.Columns(1).HeaderText = "Nombre"
        dgv.Columns(2).HeaderText = "Apellido"
        dgv.Columns(3).HeaderText = "Email Laboral"
        dgv.Columns(4).HeaderText = "Horario"
        dgv.Columns(5).HeaderText = "Cargo"
        dgv.Columns(6).HeaderText = "Departamento"



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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        editarempleado.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        newemp.Fill(newtblemp)
        VerReporte(newtblemp, "DataSet1", "c:\Reportes\NewRptEmpleados.rdlc")
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        llenarGrid()
    End Sub



    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick

        Dim id As Integer
        Dim fila As Integer = dgv.CurrentRow.Index
        id = dgv.Item(0, fila).Value
        editarempleado.id = id

        editarempleado.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim dato As String = Txtdato.Text
            dgv.DataSource = empv.Buscarpornombre(dato)

            dgv.Refresh()

            GroupBox1.Text = "Registros encontrados: " & dgv.Rows.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class