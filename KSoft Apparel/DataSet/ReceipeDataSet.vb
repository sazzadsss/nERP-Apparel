Partial Class ReceipeDataSet
    Partial Class RecipeColorDataTable

        Private Sub RecipeColorDataTable_RecipeColorRowChanging(ByVal sender As System.Object, ByVal e As RecipeColorRowChangeEvent) Handles Me.RecipeColorRowChanging

        End Sub

    End Class

    Partial Class RecipeItemDataTable

        Private Sub RecipeItemDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging


        End Sub

    End Class

End Class

Namespace ReceipeDataSetTableAdapters
    
    Partial Public Class RecipeItemTableAdapter
    End Class
End Namespace
