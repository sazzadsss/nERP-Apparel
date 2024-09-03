

Partial Public Class MasterOrderDataSet
    Partial Public Class MasterOrderDataTable
        Private Sub MasterOrderDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.LCNoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
