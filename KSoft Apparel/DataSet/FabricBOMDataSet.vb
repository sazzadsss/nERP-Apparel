

Partial Public Class FabricBOMDataSet
    Partial Class FabricBOMDetailsDataTable

        Private Sub FabricBOMDetailsDataTable_FabricBOMDetailsRowChanging(ByVal sender As System.Object, ByVal e As FabricBOMDetailsRowChangeEvent) Handles Me.FabricBOMDetailsRowChanging

        End Sub

        Private Sub FabricBOMDetailsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging

            'If (e.Column.ColumnName = Me.DyeingPricePerUnitColumn.ColumnName) Then

            '    If CType(e.ProposedValue, Short) <= 0 Then
            '        e.Row.SetColumnError(e.Column, "Quantity must be greater than 0")
            '    Else
            '        e.Row.SetColumnError(e.Column, "")
            '    End If

            'ElseIf (e.Column.ColumnName = Me.KnittingPricePerUnitColumn.ColumnName) Then

            '    If CType(e.ProposedValue, Short) <= 0 Then
            '        e.Row.SetColumnError(e.Column, "Quantity must be greater than 0")
            '    Else
            '        e.Row.SetColumnError(e.Column, "")
            '    End If

            'End If

        End Sub

    End Class

End Class
