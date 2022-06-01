Public Class asignarlogin
    Dim asiglog As New dsRegistroEyRTableAdapters.AsignarloginTableAdapter
    Dim log As New dsRegistroEyRTableAdapters.pruebaTableAdapter
    Dim tblasiglog As New dsRegistroEyR.AsignarloginDataTable
    Dim emplog As New dsRegistroEyRTableAdapters.EmpleadologinTableAdapter
    Dim lg As New dsRegistroEyRTableAdapters.LogInTableAdapter
    Private Sub asignarlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        txtidlog.Text = log.GetData().Rows(0).Item(0)
    End Sub
    Sub llenarGrid()


        dgv.DataSource = asiglog.buscartalentohumano
        dgv.Refresh()
        'ocultar columna
        dgv.Columns().Item(4).Visible = False
        dgv.Columns(0).HeaderText = "Nombre"
        dgv.Columns(1).HeaderText = "Apellido"
        dgv.Columns(2).HeaderText = "Departamento"
        dgv.Columns(3).HeaderText = "Nombre de usuario"

        GroupBox1.Text = "Registros guardados: " & dgv.Rows.Count.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim dato As String = Txtdato.Text
            dgv.DataSource = asiglog.buscar(dato)

            dgv.Refresh()

            GroupBox1.Text = "Registros encontrados: " & dgv.Rows.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        llenarGrid()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        Try
            Dim fila As Integer = dgv.CurrentRow.Index
            txtidemp.Text = dgv.Item(4, fila).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtidemp_TextChanged(sender As Object, e As EventArgs) Handles txtidemp.TextChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim empleado As Integer = CInt(txtidemp.Text.Trim)
            Dim logo As Integer = CInt(txtidlog.Text.Trim)
            emplog.insertarregistro(logo, empleado)
            MsgBox("Se ha guardado con exito", MsgBoxStyle.Information, "Guardado")
            limpiarcampos(Me)

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resp As VariantType
        resp = (MsgBox("Desea salir sin guardar?", vbQuestion + vbYesNo, "Eliminar"))
        If (resp = vbYes) Then
            Dim id As Integer = CInt(txtidlog.Text.Trim)
            lg.DeleteQuery(id)
            resp = (MsgBox("Se ha cancelado con exito", vbExclamation, "Eliminado"))
            limpiarcampos(Me)
            Me.Close()
            crearlogin.Close()
        End If


    End Sub

    Private Sub asignarlogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try


            Dim id As Integer = CInt(txtidlog.Text.Trim)
            lg.DeleteQuery(id)


            crearlogin.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class