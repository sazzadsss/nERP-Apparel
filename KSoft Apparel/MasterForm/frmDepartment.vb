Public Class frmDepartment

    Private Sub DepartmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DepartmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DepartmentDataSet)

    End Sub

    Private Sub frmDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class