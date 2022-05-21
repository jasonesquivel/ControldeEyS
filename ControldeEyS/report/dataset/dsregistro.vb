Partial Class dsregistro
    Partial Public Class dtdepartamentosDataTable
        Private Sub dtdepartamentosDataTable_dtdepartamentosRowChanging(sender As Object, e As dtdepartamentosRowChangeEvent) Handles Me.dtdepartamentosRowChanging

        End Sub

        Private Sub dtdepartamentosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.idColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class dtcargoDataTable
        Private Sub dtcargoDataTable_dtcargoRowChanging(sender As Object, e As dtcargoRowChangeEvent) Handles Me.dtcargoRowChanging

        End Sub

        Private Sub dtcargoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.idColumn.ColumnName) Then
                'Add user code here

            End If


        End Sub

    End Class



    Partial Public Class dtempleadosDataTable
        Private Sub dtempleadosDataTable_dtempleadosRowChanging(sender As Object, e As dtempleadosRowChangeEvent) Handles Me.dtempleadosRowChanging

        End Sub

        Private Sub dtempleadosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.apellidoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
