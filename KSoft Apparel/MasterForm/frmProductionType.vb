Public Class frmProductionType
    Private Sub ProductionTypeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductionTypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductionTypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionTypeDataSet)

    End Sub

    Private Sub frmProductionType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)

        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)

        Me.ProductionTypeTableAdapter.Fill(Me.ProductionTypeDataSet.ProductionType)

    End Sub
End Class