Public Class frmBankAccount

    Private Sub BankAccountBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankAccountBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BankAccountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankAccountDataSet)

    End Sub

    Private Sub frmBankAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BankAccountTableAdapter.Fill(Me.BankAccountDataSet.BankAccount)


        If CheckUserRights("Bank Account").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            BankAccountBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Bank Account").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            BankAccountBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If


    End Sub
End Class