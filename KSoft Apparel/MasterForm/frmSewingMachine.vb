Public Class frmSewingMachine

    Private Sub SewingMachineBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingMachineBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SewingMachineBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)

    End Sub

    Private Sub frmSewingMachine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SewingMachineTableAdapter.Fill(Me.SewingLayoutDataSet.SewingMachine)


        If CheckUserRights("Sewing Machine").CanEdit = False Then

            SewingMachineBindingNavigatorSaveItem.Enabled = False
        End If
    End Sub
End Class