Public Class agregardepartamento
    Dim depa As New dsRegistroEyRTableAdapters.DepartamentoTableAdapter
    Dim tbldep As New dsRegistroEyR.DepartamentoDataTable

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response
        response = MsgBox("Si presiona Ok usted se saldra sin guardar",
                     MsgBoxStyle.OkCancel, "Advertencia")
        If response = vbOK Then
            Me.Close()    ' Perform some action.
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (String.IsNullOrEmpty(txtnombredepagregar.Text)) Then
            MsgBox("No puede qudar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txtnombredepagregar.Focus()
            Exit Sub
        End If
        Try
            Dim iddepartamento As Integer = CInt(txtiddepagregar.Text.Trim)
            Dim nombre As String = txtnombredepagregar.Text.Trim
            Dim descripcion As String = Texdescripcionagregar.Text.Trim
            depa.insertarconid(nombre, descripcion, iddepartamento)
            MsgBox("Se ha guardado con exito", MsgBoxStyle.Information, "Guardado")
            limpiarcampos(Me)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try




    End Sub

    Private Sub txtiddepagregar_TextChanged(sender As Object, e As EventArgs) Handles txtiddepagregar.TextChanged

    End Sub

    Private Sub txtiddepagregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtiddepagregar.KeyPress
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
End Class