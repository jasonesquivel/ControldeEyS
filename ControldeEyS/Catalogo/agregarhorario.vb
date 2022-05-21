Public Class agregarhorario
    Dim Hor As New dsRegistroEyRTableAdapters.HorarioTableAdapter
    Dim tblhor As New dsRegistroEyR.HorarioDataTable

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response
        response = MsgBox("Si presiona Ok usted se saldra sin guardar",
                     MsgBoxStyle.OkCancel, "Advertencia")
        If response = vbOK Then
            Me.Close()    ' Perform some action.
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrEmpty(Texdescripcionagregar.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            Texdescripcionagregar.Focus()
            Exit Sub
        End If
        Try
            Dim idHorario As Integer = CInt(txtiddepagregar.Text.Trim)
            Dim horadeentrada As String = txthoradeentradaedit.Text.Trim
            Dim horadesalida As String = txthoradesalida.Text.Trim
            Dim descripcion As String = Texdescripcionagregar.Text.Trim
            Hor.InsertarconId(idHorario, descripcion, horadeentrada.ToString, horadesalida.ToString)
            MsgBox("Se ha guardado con exito", MsgBoxStyle.Information, "Guardado")
            limpiarcampos(Me)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class