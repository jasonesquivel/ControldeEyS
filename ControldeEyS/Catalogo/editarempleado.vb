Public Class editarempleado
    Dim emp As New dsRegistroEyRTableAdapters.EmpleadoTableAdapter
    Dim empv As New dsRegistroEyRTableAdapters.DataTable1TableAdapter
    Dim tblemp As New dsRegistroEyR.EmpleadoDataTable
    Dim pues As New dsRegistroEyRTableAdapters.PuestoTableAdapter
    Dim tblpues As New dsRegistroEyR.PuestoDataTable
    Dim Hor As New dsRegistroEyRTableAdapters.HorarioTableAdapter
    Dim tblhor As New dsRegistroEyR.HorarioDataTable
    Private Sub editarempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pues.Fill(tblpues)
        ComboBox2.DataSource = pues.GetData
        ComboBox2.DisplayMember = "nombre"
        ComboBox2.ValueMember = "idpuesto"
        Hor.Fill(tblhor)
        ComboBox1.DataSource = Hor.GetData
        ComboBox1.DisplayMember = "descripcionhorario"
        ComboBox1.ValueMember = "idhorario"

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response
        response = MsgBox("Desea modificar este valor del Cargo?", MsgBoxStyle.OkCancel, "Guardar")
        If response = vbOK Then
            If String.IsNullOrEmpty(txtnombreedit.Text) Then
                MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
                txtnombre.Focus()
            End If

            Try
                Dim nombre As String = txtnombreedit.Text.Trim
                Dim apellido As String = txtapellidoedit.Text.Trim
                Dim direccion As String = txtdireccionedit.Text.Trim
                Dim telefono As String = txttelefonoedit.Text.Trim
                Dim emailper As String = txtemailperedit.Text.Trim
                Dim emaillab As String = txtemaillabedit.Text.Trim
                Dim idhorario As String = ComboBox1.SelectedValue
                Dim idpuesto As String = ComboBox2.SelectedValue
                Dim idemp As Integer = CInt(Txtidemp.Text.Trim)
                emp.ActualizarRegistro(nombre, apellido, direccion, telefono, emailper, emaillab, idhorario, idpuesto, idemp)

                MsgBox("Se Ha guardado con exito", MsgBoxStyle.Information, "Departamento editado")
                limpiarcampos(Me)






            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response
        response = MsgBox("Si no ha Presionado el boton guardar se saldra sin guardar",
                     MsgBoxStyle.OkCancel, "Advertencia")
        If response = vbOK Then
            Me.Close()    ' Perform some action.
        End If
    End Sub


    Public Sub solonumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True




        End If

    End Sub

    Private Sub Txtidemp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtidemp.KeyPress
        solonumeros(e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Try
            Dim idemp As Integer = CInt(Txtidemp.Text.Trim)
            emp.BuscarporID(idemp)
            txtnombre.Text = emp.BuscarporID(idemp).Rows(0).Item(1)
            txtnombreedit.Text = emp.BuscarporID(idemp).Rows(0).Item(1)
            txtapellido.Text = emp.BuscarporID(idemp).Rows(0).Item(2)
            txtapellidoedit.Text = emp.BuscarporID(idemp).Rows(0).Item(2)
            txtdireccion.Text = emp.BuscarporID(idemp).Rows(0).Item(3)
            txtdireccionedit.Text = emp.BuscarporID(idemp).Rows(0).Item(3)
            txttelefono.Text = emp.BuscarporID(idemp).Rows(0).Item(4)
            txttelefonoedit.Text = emp.BuscarporID(idemp).Rows(0).Item(4)
            txtemailper.Text = emp.BuscarporID(idemp).Rows(0).Item(5)
            txtemailperedit.Text = emp.BuscarporID(idemp).Rows(0).Item(5)
            txtemaillab.Text = emp.BuscarporID(idemp).Rows(0).Item(6)
            txtemaillabedit.Text = emp.BuscarporID(idemp).Rows(0).Item(6)
            txtidhorario.Text = emp.BuscarporID(idemp).Rows(0).Item(7)
            ComboBox1.Text = emp.BuscarporID(idemp).Rows(0).Item(9)
            txtidpuesto.Text = emp.BuscarporID(idemp).Rows(0).Item(8)
            ComboBox2.Text = emp.BuscarporID(idemp).Rows(0).Item(10)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


    Private Sub txttelefonoedit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefonoedit.KeyPress
        solonumeros(e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?, se eliminaran todos los datos que estaban dentro", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                Dim idemp As Integer = CInt(Txtidemp.Text.Trim)
                emp.EliminarRegistro(idemp)
                resp = (MsgBox("Se ha eliminado el registro con exito", vbExclamation, "Eliminado"))
                limpiarcampos(Me)


            End If
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Txtidemp_TextChanged(sender As Object, e As EventArgs) Handles Txtidemp.TextChanged
        Try
            Dim idemp As Integer = CInt(Txtidemp.Text.Trim)
            emp.BuscarporID(idemp)
            txtnombre.Text = emp.BuscarporID(idemp).Rows(0).Item(1)
            txtnombreedit.Text = emp.BuscarporID(idemp).Rows(0).Item(1)
            txtapellido.Text = emp.BuscarporID(idemp).Rows(0).Item(2)
            txtapellidoedit.Text = emp.BuscarporID(idemp).Rows(0).Item(2)
            txtdireccion.Text = emp.BuscarporID(idemp).Rows(0).Item(3)
            txtdireccionedit.Text = emp.BuscarporID(idemp).Rows(0).Item(3)
            txttelefono.Text = emp.BuscarporID(idemp).Rows(0).Item(4)
            txttelefonoedit.Text = emp.BuscarporID(idemp).Rows(0).Item(4)
            txtemailper.Text = emp.BuscarporID(idemp).Rows(0).Item(5)
            txtemailperedit.Text = emp.BuscarporID(idemp).Rows(0).Item(5)
            txtemaillab.Text = emp.BuscarporID(idemp).Rows(0).Item(6)
            txtemaillabedit.Text = emp.BuscarporID(idemp).Rows(0).Item(6)
            txtidhorario.Text = emp.BuscarporID(idemp).Rows(0).Item(9)
            ComboBox1.Text = emp.BuscarporID(idemp).Rows(0).Item(9)
            txtidpuesto.Text = emp.BuscarporID(idemp).Rows(0).Item(10)
            ComboBox2.Text = emp.BuscarporID(idemp).Rows(0).Item(10)
        Catch ex As Exception

        End Try
    End Sub
End Class