Public Class LogIn

    Private user As String = "admin"
    Public pw As String = "123"

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        evaluaruser()



    End Sub


    Sub evaluaruser()
        If (Txtusuario.Text.Equals(user) And Txtcontraseña.Text.Equals(pw)) Then
            Me.Hide()
            Form1.Show()

            Txtusuario.Text = ""
            Txtcontraseña.Text = ""

        ElseIf MessageBox.Show("Contraseña o usuario equivocado", "Error en contraseña") Then
            Txtcontraseña.Text = ""

        End If

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
End Class