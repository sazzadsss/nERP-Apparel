Partial Class ItemListDataSet
    Partial Class ItemListDataTable

        Private Sub ItemListDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            
            'If (e.Column.ColumnName = Me.DepartmentIdColumn.ColumnName) Then
            '    DepartmentIdColumn.DefaultValue = DepartmentId
            'End If
        End Sub

    End Class

    Private Sub ItemListDataSet_Initialized(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Initialized
        'DepartmentIdColumn.DefaultValue = DepartmentId
    End Sub
End Class
