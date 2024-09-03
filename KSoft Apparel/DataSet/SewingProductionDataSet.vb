

Partial Public Class SewingProductionDataSet
    Partial Class SewingHourlyProductionDataTable

        Private Sub SewingHourlyProductionDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.H5Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace SewingProductionDataSetTableAdapters
    
    Partial Public Class SewingProductionTableAdapter
    End Class
End Namespace
