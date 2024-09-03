Public Class frmFloorIncharge

    Private Sub FloorInchargeListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FloorInchargeListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FloorInchargeListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FloorInchargeDataSet)

    End Sub

    Private Sub frmFloorIncharge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FloorInchargeListTableAdapter.Fill(Me.FloorInchargeDataSet.FloorInchargeList)

        If CheckUserRights("Floor Incharge").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            FloorInchargeListBindingNavigatorSaveItem.Enabled = False
        End If
    End Sub
End Class