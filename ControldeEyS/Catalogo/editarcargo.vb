Public Class editarcargo
    Dim pues As New dsRegistroEyRTableAdapters.PuestoTableAdapter
    Dim tblpues As New dsRegistroEyR.PuestoDataTable
    Dim depa As New dsRegistroEyRTableAdapters.DepartamentoTableAdapter
    Dim tbldepa As New dsRegistroEyR.DepartamentoDataTable
    Private Sub editarcargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        depa.Fill(tbldepa)
        ComboBox1.DataSource = depa.GetData
        ComboBox1.DisplayMember = "nombredep"
        ComboBox1.ValueMember = "iddepartamento"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response
        response = MsgBox("Desea modificar este valor del Cargo?", MsgBoxStyle.OkCancel, "Guardar")
        If response = vbOK Then
            If String.IsNullOrEmpty(txtnombrecargoedit.Text) Then
                MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
                txtnombrecargoedit.Focus()
            End If

            Try
                Dim nombre As String = txtnombrecargoedit.Text.Trim
                Dim descripcion As String = Texdescripcionedit.Text.Trim
                Dim iddep As String = ComboBox1.SelectedValue
                Dim idcar As Integer = CInt(Txtidcargo.Text.Trim)
                pues.ActualizarRegistro(nombre, descripcion, iddep, idcar)

                MsgBox("Se Ha guardado con exito", MsgBoxStyle.Information, "Departamento editado")
                limpiarcampos(Me)






            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response
        response = MsgBox("Si presiona Ok usted se saldra sin guardar",
                     MsgBoxStyle.OkCancel, "Advertencia")
        If response = vbOK Then
            Me.Close()    ' Perform some action.
        End If
    End Sub

    Private Sub Txtid_TextChanged(sender As Object, e As EventArgs) Handles Txtidcargo.TextChanged

    End Sub

    Private Sub Txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtidcargo.KeyPress

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



    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim idpues As Integer = CInt(Txtidcargo.Text.Trim)
            pues.BuscarPorId(idpues)
            Txtcargo.Text = pues.BuscarPorId(idpues).Rows(0).Item(1)
            txtnombrecargoedit.Text = pues.BuscarPorId(idpues).Rows(0).Item(1)
            txtiddepartamento.Text = pues.BuscarPorId(idpues).Rows(0).Item(3)
            ComboBox1.Text = pues.BuscarPorId(idpues).Rows(0).Item(4)
            Txtdescrpcion.Text = pues.BuscarPorId(idpues).Rows(0).Item(2)
            Texdescripcionedit.Text = pues.BuscarPorId(idpues).Rows(0).Item(2)

        Catch ex As Exception
            MsgBox("no existe ningun departamento con ese ID", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                Dim idpues As Integer = CInt(Txtidcargo.Text.Trim)
                pues.EliminarRegistro(idpues)
                resp = (MsgBox("Se ha eliminado el registro con exito", vbExclamation, "Eliminado"))
                limpiarcampos(Me)


            End If
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

End Class