Public Class frmMiscCost
    Private Sub MiscCostBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MiscCostBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MiscCostBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiscCostDataSet)

    End Sub

    Private Sub frmMiscCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ProgramNoWithStyleBuyerLookUpTableAdapter.Fill(Me.ProgramNoWtihStyleBuyerLookUpDataSet.ProgramNoWithStyleBuyerLookUp)


    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click

        Me.MiscCostTableAdapter.FillByOrderId(Me.MiscCostDataSet.MiscCost, Me.GridLookUpEdit1.EditValue)
        Me.MiscCostDataSet.MiscCost.OrderIdColumn.DefaultValue = Me.GridLookUpEdit1.EditValue

    End Sub
End Class