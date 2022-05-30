Public Class Rptcorrecciones
    Dim corr As New dsRegistroEyRTableAdapters.CorreccionhorarioTableAdapter
    Dim br As New dsRegistroEyRTableAdapters.buscarporidTableAdapter

    Dim tblcorre As New dsRegistroEyR.CorreccionhorarioDataTable


    Private Sub Rptcorrecciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()

    End Sub

    Private Sub Rptcorrecciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
    End Sub

    Sub llenarGrid()
        dgv.DataSource = corr.GetData
        dgv.Refresh()
        dgv.Columns().Item(7).Visible = False

        GroupBox1.Text = "Registros guardados: " & dgv.Rows.Count.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim dato As String = Txtdato.Text
            dgv.DataSource = corr.buscarporfecha(dato)

            dgv.Refresh()

            GroupBox1.Text = "Registros encontrados: " & dgv.Rows.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        llenarGrid()
    End Sub

    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        Try
            Dim fila As Integer = dgv.CurrentRow.Index
            txtidreg.Text = dgv.Item(7, fila).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtidreg_TextChanged(sender As Object, e As EventArgs) Handles txtidreg.TextChanged
        Try
            Dim idreg As Integer = CInt(txtidreg.Text.Trim)
            br.buscarporid(idreg)
            txtentrada.Text = br.buscarporid(idreg).Rows(0).Item(0)
            txtsalida.Text = br.buscarporid(idreg).Rows(0).Item(1)


        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            'MsgBox("tiene que inicializar el empleado para poder registrar la asistencia", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response
        response = MsgBox("Desea modificar este valor del Departamento?", MsgBoxStyle.OkCancel, "Guardar")
        If response = vbOK Then


            Try
                Dim entrada As String = txtentrada.Text.Trim
                Dim salida As String = txtsalida.Text.Trim
                Dim id As Integer = CInt(txtidreg.Text.Trim)
                br.UpdateQuery(entrada, salida, id)

                MsgBox("Se Ha guardado con exito", MsgBoxStyle.Information, "Departamento editado")
                limpiarcampos(Me)




            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class