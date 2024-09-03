Partial Class OrderNewDataSet
    Partial Class OrderPictureDataTable

        Private Sub OrderPictureDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.OrderPictureIdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class OrderDataTable

        Private Sub OrderDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.OrderIdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
