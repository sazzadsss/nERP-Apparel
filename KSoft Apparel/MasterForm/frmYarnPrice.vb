Public Class frmYarnPrice

    Private Sub ItemListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Validate()
        'Me.ItemListBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.ItemListDataSet)

    End Sub

    Private Sub frmYarnPrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, 8)

    End Sub

    
End Class