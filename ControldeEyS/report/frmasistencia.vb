Public Class frmasistencia


    Dim empv As New dsRegistroEyRTableAdapters.DataTable2TableAdapter
    Dim empu As New dsRegistroEyRTableAdapters.DataTable3TableAdapter

    Dim regis As New dsRegistroEyRTableAdapters.RegistrodeEyRTableAdapter

    Dim regist As New dsRegistroEyRTableAdapters.RegistrodeEyR1TableAdapter
    Sub llenarGrid()
        dgvRegistros.DataSource = empv.Buscarporid(0)
        dgvRegistros.Refresh()

        dgvRegistros.Columns(1).HeaderText = "Nombre"
        dgvRegistros.Columns(2).HeaderText = "Apellido"
        dgvRegistros.Columns(3).HeaderText = "Departamento"
        dgvRegistros.Columns(4).HeaderText = "Entrada Asignada"
        dgvRegistros.Columns(5).HeaderText = "Salida Asignada"


        dgvRegistros.Columns().Item(0).Visible = False

        GroupBox1.Text = "Registros guardados: " & dgvRegistros.Rows.Count.ToString
    End Sub


    Private Sub frmasistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
    End Sub

    Private Sub dgvRegistros_DoubleClick(sender As Object, e As EventArgs) Handles dgvRegistros.DoubleClick
        Try
            Dim fila As Integer = dgvRegistros.CurrentRow.Index
            txtidemp.Text = dgvRegistros.Item(0, fila).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub txtidemp_TextChanged(sender As Object, e As EventArgs) Handles txtidemp.TextChanged
        txtmarcaentrada.Text = DateTime.Now
        txtmarcasalida.Text = DateTime.Now
        Try
            Dim idemp As Integer = CInt(txtidemp.Text.Trim)
            empu.Buscarporid(idemp)
            txtidregistro.Text = empu.Buscarporid(idemp)
        Catch ex As Exception
            limpiarcampos(Me)
            'MsgBox("tiene que inicializar el empleado para poder registrar la asistencia", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub frmasistencia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        LogIn.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fecha As String = Format(Now, "dd/MM/yyyy")
        Dim tabla As New dsRegistroEyR.RegistrodeEyR1DataTable

        Try

            Dim dato As Integer = Txtdato.Text
            regist.Fill(tabla, dato, fecha)
            If tabla.Rows.Count > 0 Then
                Button2.Enabled = False
            Else
                Button2.Enabled = True
            End If
            dgvRegistros.DataSource = empv.Buscarporid(dato)

            dgvRegistros.Refresh()

            GroupBox1.Text = "Registros encontrados: " & dgvRegistros.Rows.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        llenarGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim nomarca As String
        nomarca = "no marcado"
        Try
            Dim horaentrada As String = txtmarcaentrada.Text.Trim
            Dim idemp As Integer = CInt(txtidemp.Text.Trim)

            regis.insertarregistro(horaentrada, nomarca, idemp)
            MsgBox("Se ha guardado con exito", MsgBoxStyle.Information, "Guardado")
            limpiarcampos(Me)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim idere As Integer = CInt(txtidregistro.Text.Trim)
            Dim horasalida As String = txtmarcasalida.Text.Trim
            regis.ActualizarRegistro(horasalida, idere)

            MsgBox("Se Ha guardado con exito", MsgBoxStyle.Information, "Departamento editado")
            limpiarcampos(Me)






        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        
    End Sub

    Private Sub Txtdato_TextChanged(sender As Object, e As EventArgs) Handles Txtdato.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class