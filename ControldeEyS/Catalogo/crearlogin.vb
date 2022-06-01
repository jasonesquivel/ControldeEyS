Public Class crearlogin
    Dim log As New dsRegistroEyRTableAdapters.LogInTableAdapter
    Private Sub crearlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrEmpty(txtnombreusuario.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            txrragregarcontraseña.Focus()
            Exit Sub
        End If

        If (txtcontraseña.Text = txrragregarcontraseña.Text) Then
            Try

                Dim usuario As String = txtnombreusuario.Text.Trim
                Dim contraseña As String = txtcontraseña.Text.Trim
                log.insertar(usuario, contraseña)
                asignarlogin.Show()
                MsgBox("Asigne el login a un empleado", MsgBoxStyle.Information, "Guardado")
                limpiarcampos(Me)
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else

            MsgBox("los contraseñas son diferentes", MsgBoxStyle.Critical, "Error")
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
End Class