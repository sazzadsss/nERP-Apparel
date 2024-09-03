Partial Class FinishingProductionDataSet
    Partial Class FinishingHourlyProductionDataTable

        Private Sub FinishingHourlyProductionDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.H6Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace FinishingProductionDataSetTableAdapters
    
    Partial Public Class FinishingRejectionTableAdapter
    End Class
End Namespace

Namespace FinishingProductionDataSetTableAdapters
    
    Partial Public Class FinishingProductionTableAdapter
    End Class
End Namespace
