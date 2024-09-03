Public Class frmFRProcess

    Private Sub FRProcessBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FRProcessBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FRProcessBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FRProcessDataSet)

    End Sub

    Private Sub frmFRProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FRProcessTableAdapter.Fill(Me.FRProcessDataSet.FRProcess)
        If CheckUserRights("FRProcess").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            FRProcessBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
        ElseIf CheckUserRights("FRProcess").CanDelete = False Then

            BindingNavigatorAddNewItem.Enabled = True
            FRProcessBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub
    Private Sub GetProcess()

    End Sub

End Class