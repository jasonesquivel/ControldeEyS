Partial Class dsRegistroEyR
    Partial Public Class RegistroEntradaYsalidaDataTable
        Private Sub RegistroEntradaYsalidaDataTable_RegistroEntradaYsalidaRowChanging(sender As Object, e As RegistroEntradaYsalidaRowChangeEvent) Handles Me.RegistroEntradaYsalidaRowChanging

        End Sub

    End Class

    Partial Public Class DataTable4DataTable
        Private Sub DataTable4DataTable_DataTable4RowChanging(sender As Object, e As DataTable4RowChangeEvent) Handles Me.DataTable4RowChanging

        End Sub



    End Class

    Partial Public Class DataTable31DataTable

    End Class

    Partial Public Class RegistrodeEyRDataTable
        Private Sub RegistrodeEyRDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.horademarcaColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class DataTable3DataTable
        Private Sub DataTable3DataTable_DataTable3RowChanging(sender As Object, e As DataTable3RowChangeEvent) Handles Me.DataTable3RowChanging

        End Sub

    End Class

    Partial Public Class EmpleadoDataTable


    End Class
End Class

Namespace dsRegistroEyRTableAdapters
    Partial Public Class RegistrodeEyRTableAdapter
    End Class

    Partial Public Class HorarioTableAdapter
    End Class

    Partial Public Class PuestoTableAdapter
    End Class

    Partial Public Class DepartamentoTableAdapter
    End Class

    Partial Public Class EmpleadoTableAdapter
    End Class
End Namespace
