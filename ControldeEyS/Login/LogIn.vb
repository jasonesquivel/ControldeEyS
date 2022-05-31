Public Class LogIn

    Private user As String = "admin"
    Public pw As String = "123"
    Dim log As New dsRegistroEyRTableAdapters.LogInTableAdapter

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        evaluaruser()





    End Sub



    Sub evaluaruser()
        Try

            Dim usuario As String = Txtusuario.Text.Trim
            Dim contra As String = Txtcontraseña.Text.Trim
            If log.inicio(usuario, contra) > 0 Then
                Me.Hide()
                Form1.Show()
                Txtusuario.Text = ""
                Txtcontraseña.Text = ""
            ElseIf MessageBox.Show("Contraseña o usuario equivocado", "Error en contraseña") Then
                Txtcontraseña.Text = ""
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub



    Private Sub Txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtusuario.KeyPress
        If (Asc(e.KeyChar) = 13) Then
            Txtcontraseña.Focus()
        End If
    End Sub

    Private Sub Txtcontraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcontraseña.KeyPress
        If (Asc(e.KeyChar) = 13) Then

            evaluaruser()
        End If
    End Sub
    Private Sub logIn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Txtcontraseña_TextChanged(sender As Object, e As EventArgs) Handles Txtcontraseña.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

        frmasistencia.Show()

    End Sub
End Class