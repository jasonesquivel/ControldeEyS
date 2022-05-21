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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.ReportViewer1.RefreshReport()
        emp.Fill(tblemp)
        Verme(tblemp, "DataSet1", "c:\Reportes\RptEmpleados.rdlc")
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LogIn.Close()
    End Sub





    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim response
        response = MsgBox("¿Esta seguro que desea cerrar sesion?
   si presiona ok cerrara sesion",
                     MsgBoxStyle.OkCancel, "Advertencia")
        If response = vbOK Then
            LogIn.Show()
            Me.Hide()
        End If

    End Sub



    Private Sub ReporteDeCaegoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCaegoToolStripMenuItem.Click
        pues.Fill(tblpues)
        VerReporte(tblpues, "DataSet1", "c:\Reportes\rptCargos.rdlc")

    End Sub





    Private Sub ReporteDeDepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeDepartamentosToolStripMenuItem.Click
        ' verdepartamento.Show()
        ' Me.Hide()
        depa.Fill(tbldep)
        VerReporte(tbldep, "DataSet1", "c:\Reportes\rptdepartamentos.rdlc")

    End Sub



    Private Sub EditarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarEmpleadoToolStripMenuItem.Click
        FrmEmpleados.Show()
        Me.Hide()
    End Sub

    Private Sub EditarDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarDepartamentoToolStripMenuItem.Click
        FrmDepartamentos.Show()
        Me.Hide()
    End Sub

    Private Sub EditarCargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarCargoToolStripMenuItem.Click
        Frmvistapreviacargos.Show()
        Me.Hide()
    End Sub

    Private Sub HorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorarioToolStripMenuItem.Click
        FrmHorarios.Show()
        Me.Hide()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)
        emp.Fill(tblemp)
        Verme(tblemp, "DataSet1", "c:\Reportes\RptEmpleados.rdlc")
        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub Verme(ByVal tbl As DataTable, ByVal nombreDs As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDs, tbl)
            With Me
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.Refresh()

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al mostrar reporte")
        End Try

    End Sub


    Private Sub ReporteDeHorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeHorariosToolStripMenuItem.Click
        Hor.Fill(tblhor)
        VerReporte(tblhor, "DataSet1", "c:\Reportes\rptHorario.rdlc")
    End Sub

    Private Sub ReporteDeAsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeAsistenciaToolStripMenuItem.Click
        emp.Fill(tblemp)
        VerReporte(tblemp, "DataSet1", "c:\Reportes\RptEmpleados.rdlc")
    End Sub
End Class
