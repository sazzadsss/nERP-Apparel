Partial Class OrderPOLookupNewDataSet
    Partial Class OrderPOLookupNewDataTable

        Private Sub OrderPOLookupNewDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DestinationCodeColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace OrderPOLookupNewDataSetTableAdapters
    
    Partial Public Class OrderPOLookupNewTableAdapter
    End Class
End Namespace
