Imports Microsoft.Reporting.WinForms

Public Class Form1

    Dim depa As New dsRegistroEyRTableAdapters.DepartamentoTableAdapter
    Dim tbldep As New dsRegistroEyR.DepartamentoDataTable
    Dim pues As New dsRegistroEyRTableAdapters.PuestoTableAdapter
    Dim tblpues As New dsRegistroEyR.PuestoDataTable
    Dim emp As New dsRegistroEyRTableAdapters.EmpleadoTableAdapter
    Dim tblemp As New dsRegistroEyR.EmpleadoDataTable
    Dim Hor As New dsRegistroEyRTableAdapters.HorarioTableAdapter
    Dim tblhor As New dsRegistroEyR.HorarioDataTable
    Dim empas As New dsRegistroEyRTableAdapters.DataTable4TableAdapter
    Dim regis As New dsRegistroEyRTableAdapters.RegistroEntradaYsalidaTableAdapter
    Dim tblreg As New dsRegistroEyR.RegistroEntradaYsalidaDataTable

    Dim newpues As New dsRegistroEyRTableAdapters.RptCargosTableAdapter
    Dim newtblpues As New dsRegistroEyR.RptCargosDataTable

    Dim newemp As New dsRegistroEyRTableAdapters.RptEmpleadosTableAdapter
    Dim newtblemp As New dsRegistroEyR.RptEmpleadosDataTable



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarGrid()


    End Sub
    Sub llenarGrid()
        Try


            DataGridView1.DataSource = empas.GetData
            DataGridView1.Refresh()

            Panel3.Text = "Registros guardados: " & DataGridView1.Rows.Count.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub





    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim response
        response = MsgBox("¿Esta seguro que desea cerrar sesion?
   si presiona ok cerrara sesion",
                     MsgBoxStyle.OkCancel, "Advertencia")
        If response = vbOK Then

            LogIn.Show()
            Me.Close()

        End If

    End Sub



    Private Sub ReporteDeCaegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCaegoToolStripMenuItem.Click
        newpues.Fill(newtblpues)
        VerReporte(newtblpues, "DataSet1", "c:\Reportes\NewRptCargos.rdlc")

    End Sub





    Private Sub ReporteDeDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeDepartamentosToolStripMenuItem.Click
        ' verdepartamento.Show()
        ' Me.Hide()
        depa.Fill(tbldep)
        VerReporte(tbldep, "DataSet1", "c:\Reportes\rptdepartamentos.rdlc")

    End Sub



    Private Sub EditarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarEmpleadoToolStripMenuItem.Click
        FrmEmpleados.Show()
        Me.Close()
    End Sub

    Private Sub EditarDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarDepartamentoToolStripMenuItem.Click
        FrmDepartamentos.Show()
        Me.Close()
    End Sub

    Private Sub EditarCargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarCargoToolStripMenuItem.Click
        Frmvistapreviacargos.Show()
        Me.Close()
    End Sub

    Private Sub HorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorarioToolStripMenuItem.Click
        FrmHorarios.Show()
        Me.Close()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub




    Private Sub ReporteDeHorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeHorariosToolStripMenuItem.Click
        Hor.Fill(tblhor)
        VerReporte(tblhor, "DataSet1", "c:\Reportes\rptHorario.rdlc")
    End Sub

    Private Sub ReporteDeAsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeAsistenciaToolStripMenuItem.Click
        newemp.Fill(newtblemp)
        VerReporte(newtblemp, "DataSet1", "c:\Reportes\NewRptEmpleados.rdlc")
    End Sub

    Private Sub ReportesDeEntradaYSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesDeEntradaYSalidaToolStripMenuItem.Click
        Try


            regis.Fill(tblreg)
            VerReporte(tblreg, "DataSet1", "c:\Reportes\RegistroEntradaYsalida.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Rptcorrecciones.Show()
        Me.Close()

    End Sub

    Private Sub CrearUsuariosAdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearUsuariosAdministradorToolStripMenuItem.Click
        crearlogin.Show()

    End Sub

    Private Sub VerRegistroDeCuentasCreadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerRegistroDeCuentasCreadasToolStripMenuItem.Click
        frmregistrodecuentas.Show()


    End Sub
End Class
