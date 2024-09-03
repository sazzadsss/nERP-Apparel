Public Class frmActivitiesGroup

    Private Sub ActivitiesGroupBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivitiesGroupBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ActivitiesGroupBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ActivitiesGroupDataSet)

    End Sub

   
    Private Sub frmActivitiesGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.ActivitiesGroupTableAdapter.Fill(Me.ActivitiesGroupDataSet.ActivitiesGroup)

        If CheckUserRights("Activities Group").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
            ActivitiesGroupBindingNavigatorSaveItem.Enabled = False

        ElseIf CheckUserRights("Activities Group").CanDelete = False Then

            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False
            ActivitiesGroupBindingNavigatorSaveItem.Enabled = True

        End If

    End Sub
End Class