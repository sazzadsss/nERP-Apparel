Partial Class PreCostingNoLookupDataSet
    Partial Public Class PreCostingNoLookupDataTable
        Private Sub PreCostingNoLookupDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.BuyerNameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
