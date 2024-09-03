Public Class frmFabric

    Private Sub FabricBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FabricBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FabricDataSet)

    End Sub

    Private Sub frmFabric_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.FabricTableAdapter.FillbyOrderId(Me.FabricDataSet.Fabric, )

    End Sub
End Class