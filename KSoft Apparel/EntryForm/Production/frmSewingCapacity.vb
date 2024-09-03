Public Class frmSewingCapacity

    Private Sub SewingCapacityBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingCapacityBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SewingCapacityBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingCapacityDataSet)

    End Sub

    Private Sub SewingCapacity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SewingCapacityTableAdapter.Fill(Me.SewingCapacityDataSet.SewingCapacity)


        If CheckUserRights("Sewing Catacity").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            SewingCapacityBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Sewing Catacity").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            SewingCapacityBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub
End Class