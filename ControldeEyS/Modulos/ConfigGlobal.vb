Imports Microsoft.Reporting.WinForms

Module ConfigGlobal

    Sub VerReporte(ByVal tbl As DataTable, ByVal nombreDs As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDs, tbl)
            With Imprimir
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al mostrar reporte")
        End Try

    End Sub
    Sub limpiarcampos(ByVal formulario As Form)
        Dim text As Object
        For Each text In formulario.Controls
            If TypeOf text Is TextBox Then
                Dim txttemp As TextBox = CType(text, TextBox)

                txttemp.Text = ""


            End If
        Next

    End Sub
    Sub solonumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then

            e.Handled = False


        Else
            e.Handled = True




        End If

    End Sub
End Module
