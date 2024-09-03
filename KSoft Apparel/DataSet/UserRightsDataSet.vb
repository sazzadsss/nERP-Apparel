Partial Class UserRightsDataSet
    Partial Class UserRightsDataTable

        Private Sub UserRightsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CAN_DELETEColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
