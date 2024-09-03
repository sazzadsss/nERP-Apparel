Public Class frmWorkingHour

    Private Sub WorkingHourBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkingHourBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WorkingHourBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WorkingHourDataSet)

    End Sub

    Private Sub frmWorkingHour_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Me.ShiftTableAdapter.Fill(Me.ShiftDataSet.Shift)

        Me.WorkingHourTableAdapter.Fill(Me.WorkingHourDataSet.WorkingHour)


        If CheckUserRights("Working Hour").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            WorkingHourBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Working Hour").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            WorkingHourBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub
End Class