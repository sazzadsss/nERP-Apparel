Public Class frmAccessoriesList

    Private Sub ItemListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemListBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ItemListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ItemListDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub frmAccessoriesList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, My.Settings.AccDepartmentId)

    End Sub
End Class