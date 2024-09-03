Public Class SewingCategory

    Private Sub SewingCategoryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingCategoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SewingCategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)

    End Sub

    Private Sub SewingCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SewingCategoryTableAdapter.Fill(Me.SewingLayoutDataSet.SewingCategory)

        If CheckUserRights("Sewing Category").CanEdit = False Then

            SewingCategoryBindingNavigatorSaveItem.Enabled = False
        End If
    End Sub
End Class