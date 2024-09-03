Public Class frmGSM

    Private Sub GSMBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GSMBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GSMBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GSMDataSet)

    End Sub

    Private Sub frmGSM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.GSMTableAdapter.Fill(Me.GSMDataSet.GSM)

        If CheckUserRights("GSM").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            GSMBindingNavigatorSaveItem.Enabled = False

        End If
    End Sub
End Class