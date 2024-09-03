Public Class frmPMList

    Private Sub PMListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PMListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PMListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PMListDataSet)

    End Sub

    Private Sub frmPMList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PMListTableAdapter.Fill(Me.PMListDataSet.PMList)


        If CheckUserRights("PM List").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            PMListBindingNavigatorSaveItem.Enabled = False

        End If
    End Sub
End Class