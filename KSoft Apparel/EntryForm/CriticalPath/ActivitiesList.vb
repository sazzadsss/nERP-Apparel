Public Class ActivitiesList

    Private Sub ActivitiesListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivitiesListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ActivitiesListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ActivitiesListDataSet)

    End Sub

    Private Sub ActivitiesList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)
        Me.ActivitiesListTableAdapter.Fill(Me.ActivitiesListDataSet.ActivitiesList)

        If CheckUserRights("Activities List").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            ActivitiesListBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub
End Class