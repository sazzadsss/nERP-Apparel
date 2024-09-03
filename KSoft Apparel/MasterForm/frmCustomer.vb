Public Class frmCustomer

    Private Sub CustomerListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomerListDataSet)

    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CustomerListTableAdapter.Fill(Me.CustomerListDataSet.CustomerList)
        If CheckUserRights("Daily Production Summery").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            CustomerListBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub
End Class