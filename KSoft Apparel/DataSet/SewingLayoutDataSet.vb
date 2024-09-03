

Partial Public Class SewingLayoutDataSet
    Partial Class SewingBreakDownDataTable

        Private Sub SewingBreakDownDataTable_SewingBreakDownRowChanging(ByVal sender As System.Object, ByVal e As SewingBreakDownRowChangeEvent) Handles Me.SewingBreakDownRowChanging

        End Sub

        Private Sub SewingBreakDownDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SMVColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class SewingSMVDataTable

        Private Sub SewingSMVDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TTLSecondColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class SewingLayoutDataTable

        Private Sub SewingLayoutDataTable_SewingLayoutRowChanging(ByVal sender As System.Object, ByVal e As SewingLayoutRowChangeEvent) Handles Me.SewingLayoutRowChanging

        End Sub

        Private Sub SewingLayoutDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.BonusTargetsColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace SewingLayoutDataSetTableAdapters
    
    Partial Class SewingProcessTableAdapter

    End Class

    Partial Public Class SewingSMVViewTableAdapter
    End Class
End Namespace
