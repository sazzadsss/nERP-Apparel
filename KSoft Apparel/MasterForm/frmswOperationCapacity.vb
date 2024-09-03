Public Class frmswOperationCapacity

    Private Sub SwOperationCapacityBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwOperationCapacityBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SwOperationCapacityBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SwOperationCapacityDataSet)

    End Sub

    Private Sub frmswOperationCapacity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SwOperationCapacityTableAdapter.Fill(Me.SwOperationCapacityDataSet.swOperationCapacity)

    End Sub
End Class