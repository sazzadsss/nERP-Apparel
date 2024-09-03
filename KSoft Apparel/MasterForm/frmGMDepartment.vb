Public Class frmGMDepartment

    Private Sub GMDepartmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GMDepartmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GMDepartmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GMDepartmentDataSet)

    End Sub

    Private Sub frmGMDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        Me.GMDepartmentTableAdapter.Fill(Me.GMDepartmentDataSet.GMDepartment)

    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click
        Me.GMDepartmentTableAdapter.FillByContain(Me.GMDepartmentDataSet.GMDepartment, ToolStripTextBox1.Text)

    End Sub
End Class