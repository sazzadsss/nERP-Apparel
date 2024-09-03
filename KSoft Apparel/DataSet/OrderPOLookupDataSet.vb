Partial Class OrderPOLookupDataSet
    Partial Class OrderP0LookupDataTable

        Private Sub OrderP0LookupDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.POandColorColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
