Partial Class PrintStatusDataSet
    Partial Class PrintStatusDataTable

        Private Sub PrintStatusDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.GoldSillColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
