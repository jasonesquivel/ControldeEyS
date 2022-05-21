Public Class editardep
    Dim depa As New dsRegistroEyRTableAdapters.DepartamentoTableAdapter
    Dim tbldep As New dsRegistroEyR.DepartamentoDataTable


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim response
        response = MsgBox("Desea modificar este valor del Departamento?", MsgBoxStyle.OkCancel, "Guardar")
        If response = vbOK Then
            If String.IsNullOrEmpty(txtnombreedit.Text) Then
                MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
                txtnombreedit.Focus()
            End If

            Try
                Dim nombre As String = txtnombreedit.Text.Trim
                Dim descripcion As String = Texdescripcionedit.Text.Trim
                Dim iddep As Integer = CInt(Txtiddep.Text.Trim)
                depa.ActualizarRegistro(nombre, descripcion, iddep)

                MsgBox("Se Ha guardado con exito", MsgBoxStyle.Information, "Departamento editado")
                limpiarcampos(Me)




            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If

    End Sub

    Private Sub Txtiddep_TextChanged(sender As Object, e As EventArgs) Handles Txtiddep.TextChanged

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

    Private Sub Txtiddep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtiddep.KeyPress
        solonumeros(e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim iddep As Integer = CInt(Txtiddep.Text.Trim)
            Dim nombredepa As String = txtnombre.Text.Trim
            Dim descrpiciondepa As String = Txtdescripcion.Text.Trim
            depa.BuscarPorId(iddep)
            txtnombre.Text = depa.BuscarPorId(iddep).Rows(0).Item(1)
            txtnombreedit.Text = depa.BuscarPorId(iddep).Rows(0).Item(1)
            Txtdescripcion.Text = depa.BuscarPorId(iddep).Rows(0).Item(2)
            Texdescripcionedit.Text = depa.BuscarPorId(iddep).Rows(0).Item(2)

        Catch ex As Exception
            MsgBox("no existe ningun departamento con ese ID", MsgBoxStyle.Critical, "Error")
        End Try





    End Sub

    Private Sub editardep_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub editardep_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmDepartamentos.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                Dim iddep As Integer = CInt(Txtiddep.Text.Trim)
                depa.EliminarRegistro(iddep)
                resp = (MsgBox("Se ha eliminado el registro con exito", vbExclamation, "Eliminado"))
                limpiarcampos(Me)


            End If
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class