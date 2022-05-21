Public Class editarhorariovb
    Dim Hor As New dsRegistroEyRTableAdapters.HorarioTableAdapter
    Dim tblhor As New dsRegistroEyR.HorarioDataTable


    Private Sub editarhorariovb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim idhor As Integer = CInt(Txtidhorario.Text.Trim)
            'Dim descripcion As String = Texdescripcionedit.Text.Trim
            'Dim horaentrada As TimeSpan = TimeSpan.Parse(txthoradeentradaedit.Text)
            'Dim horasalida As TimeSpan = TimeSpan.Parse(txtshoradealidaedit.Text)
            Hor.GetDataBy2(idhor)
            Txtdescripcion.Text = Hor.GetDataBy2(idhor).Rows(0).Item(1)
            Texdescripcionedit.Text = Hor.GetDataBy2(idhor).Rows(0).Item(1)
            txtentrada.Text = (Hor.GetDataBy2(idhor).Rows(0).Item(2)).ToString
            txthoradeentradaedit.Text = Hor.GetDataBy2(idhor).Rows(0).Item(2).ToString
            Txtsalida.Text = Hor.GetDataBy2(idhor).Rows(0).Item(3).ToString
            txtshoradealidaedit.Text = Hor.GetDataBy2(idhor).Rows(0).Item(3).ToString

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response
        response = MsgBox("Desea modificar este valor del Departamento?", MsgBoxStyle.OkCancel, "Guardar")
        If response = vbOK Then
            If String.IsNullOrEmpty(Texdescripcionedit.Text) Then
                MsgBox("No puede quedar vacia la descripcion", MsgBoxStyle.Critical, "ERROR")
                Texdescripcionedit.Focus()
            End If

            Try
                Dim idhor As Integer = CInt(Txtidhorario.Text.Trim)
                Dim descripcion As String = Texdescripcionedit.Text.Trim
                Dim horaentrada As String = txthoradeentradaedit.Text.Trim
                Dim horasalida As String = txtshoradealidaedit.Text.Trim
                ' Dim horaentrada As TimeSpan = TimeSpan.Parse(txthoradeentradaedit.Text)
                'Dim horasalida As TimeSpan = TimeSpan.Parse(txtshoradealidaedit.Text)

                Hor.ActualizarRegistro(descripcion, horaentrada, horasalida, idhor)

                MsgBox("Se Ha guardado con exito", MsgBoxStyle.Information, "Departamento editado")
                limpiarcampos(Me)




            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If


    End Sub


    Private Sub Txtidhorario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtidhorario.KeyPress
        solonumeros(e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                Dim idhor As Integer = CInt(Txtidhorario.Text.Trim)
                Hor.EliminarRegistro(idhor)
                resp = (MsgBox("Se ha eliminado el registro con exito", vbExclamation, "Eliminado"))
                limpiarcampos(Me)


            End If
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class