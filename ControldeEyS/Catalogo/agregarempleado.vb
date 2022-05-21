Public Class agregarempleado
    Dim emp As New dsRegistroEyRTableAdapters.EmpleadoTableAdapter
    Dim empv As New dsRegistroEyRTableAdapters.DataTable1TableAdapter
    Dim tblemp As New dsRegistroEyR.EmpleadoDataTable
    Dim pues As New dsRegistroEyRTableAdapters.PuestoTableAdapter
    Dim tblpues As New dsRegistroEyR.PuestoDataTable
    Dim Hor As New dsRegistroEyRTableAdapters.HorarioTableAdapter
    Dim tblhor As New dsRegistroEyR.HorarioDataTable

    Private Sub agregarempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pues.Fill(tblpues)
        ComboBox2.DataSource = pues.GetData
        ComboBox2.DisplayMember = "nombre"
        ComboBox2.ValueMember = "idpuesto"
        Hor.Fill(tblhor)
        ComboBox1.DataSource = Hor.GetData
        ComboBox1.DisplayMember = "descripcionhorario"
        ComboBox1.ValueMember = "idhorario"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response
        response = MsgBox("Si presiona Ok usted se saldra sin guardar",
                     MsgBoxStyle.OkCancel, "Advertencia")
        If response = vbOK Then
            Me.Close()    ' Perform some action.
        End If
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrEmpty(txtnombreagregar.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtnombreagregar.Focus()
            Exit Sub
        End If
        Try
            Dim nombre As String = txtnombreagregar.Text.Trim
            Dim apellido As String = txtapellidoagregar.Text.Trim
            Dim direccion As String = txtdireccion.Text.Trim
            Dim telefono As String = txttelefono.Text.Trim
            Dim emailper As String = txtemailper.Text.Trim
            Dim emaillab As String = txtemailper.Text.Trim
            Dim idhorario As String = ComboBox1.SelectedValue
            Dim idpuesto As String = ComboBox2.SelectedValue
            Dim idemp As Integer = CInt(txtidagregar.Text.Trim)
            emp.insertarid(idemp, nombre, apellido, direccion, telefono, emailper, emaillab, idhorario, idpuesto)

            MsgBox("Se Ha guardado con exito", MsgBoxStyle.Information, "Departamento editado")
            limpiarcampos(Me)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


    End Sub

    Private Sub txtidagregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidagregar.KeyPress
        solonumeros(e)
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

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
        solonumeros(e)
    End Sub
End Class