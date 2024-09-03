Public Class frmFabricMatrialType
    Private Sub FabricMaterialTypeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FabricMaterialTypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FabricMaterialTypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FabricMaterialTypeDataSet)

    End Sub

    Private Sub frmFabricMatrialType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FabricMaterialTypeDataSet.FabricMaterialType' table. You can move, or remove it, as needed.
        Me.FabricMaterialTypeTableAdapter.Fill(Me.FabricMaterialTypeDataSet.FabricMaterialType)

    End Sub
End Class