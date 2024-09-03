Public Class frmEmbMachineList

    Private Sub EmbMachineBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbMachineBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmbMachineBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmbMachineDataSet)

    End Sub

    Private Sub frmEmbMachineList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EmbMachineTableAdapter.Fill(Me.EmbMachineDataSet.EmbMachine)

        If CheckUserRights("Embroidery Machine List").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
            EmbMachineBindingNavigatorSaveItem.Enabled = False

        ElseIf CheckUserRights("Embroidery Machine List").CanDelete = False Then

            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False
            EmbMachineBindingNavigatorSaveItem.Enabled = True
        End If

    End Sub
End Class