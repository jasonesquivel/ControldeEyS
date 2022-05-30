
Public Class agregarcargo

    Dim pues As New dsRegistroEyRTableAdapters.PuestoTableAdapter
    Dim tblpues As New dsRegistroEyR.PuestoDataTable
    Dim depa As New dsRegistroEyRTableAdapters.DepartamentoTableAdapter
    Dim tbldepa As New dsRegistroEyR.DepartamentoDataTable

    Private Sub Frmcargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        depa.Fill(tbldepa)
        ComboBox1.DataSource = depa.GetData
        ComboBox1.DisplayMember = "nombredep"
        ComboBox1.ValueMember = "iddepartamento"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response
        response = MsgBox("Si no ha Presionado el boton guardar se saldra sin guardar",
                     MsgBoxStyle.OkCancel, "Advertencia")
        If response = vbOK Then
            Me.Close()    ' Perform some action.
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (String.IsNullOrEmpty(Txtnombrecargoagregar.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            Txtnombrecargoagregar.Focus()
            Exit Sub
        End If
        Try

            Dim nombre As String = Txtnombrecargoagregar.Text.Trim
            Dim descripcion As String = Txtdescripcionagregar.Text.Trim
            Dim iddepartamento As Integer = ComboBox1.SelectedValue
            pues.insertarconid(nombre, descripcion, iddepartamento)
            MsgBox("Se ha guardado con exito", MsgBoxStyle.Information, "Guardado")
            limpiarcampos(Me)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try





    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Txtidcargoagregar.TextChanged

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

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

    Private Sub Txtidcargoagregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtidcargoagregar.KeyPress
        solonumeros(e)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
