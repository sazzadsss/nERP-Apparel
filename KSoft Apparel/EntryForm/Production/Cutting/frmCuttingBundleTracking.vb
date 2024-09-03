Public Class frmCuttingBundleTracking

    Private Sub CuttingBundleTrackingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingBundleTrackingBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.CuttingBundleTrackingBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CuttingBundleTrackingDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
      

    End Sub

    Private Sub frmCuttingBundleTracking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.LineTableAdapter.Fill(Me.LineDataSet.Line)
        Me.CuttingBundleTrackingTableAdapter.Fill(Me.CuttingBundleTrackingDataSet.CuttingBundleTracking)


        If CheckUserRights("Cutting Bundle Information").CanEdit = False Then

            AddButton.Enabled = False
            CuttingBundleTrackingBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Cutting Bundle Information").CanDelete = False Then
            AddButton.Enabled = True
            CuttingBundleTrackingBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged
        Me.LineTableAdapter.FillByBranchId(Me.LineDataSet.Line, BranchComboBox.SelectedValue)
    End Sub

    Private Sub ShowBundleStatusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowBundleStatusButton.Click

        If Me.CuttingBundleTrackingBindingSource.Position > -1 Then

            Dim row As CuttingBundleTrackingDataSet.CuttingBundleTrackingRow
            row = CType(CType(Me.CuttingBundleTrackingBindingSource.Current, DataRowView).Row, CuttingBundleTrackingDataSet.CuttingBundleTrackingRow)

            Me.CuttingBundleSummeryTableAdapter.Fill(Me.CuttingBundleSummerDataSet.CuttingBundleSummery, row.BundleNo)

        End If
        

    End Sub


    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        Me.CuttingBundleTrackingDataSet.CuttingBundleTracking.CuttingBundleTrackingDateColumn.DefaultValue = DateTimePicker1.Text
        Me.CuttingBundleTrackingDataSet.CuttingBundleTracking.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue

        '================
        Me.CuttingBundleTrackingDataSet.CuttingBundleTracking.IssuedBranchIdColumn.DefaultValue = IssuedBranchIdGridLookUpEdit.EditValue
        Me.CuttingBundleTrackingDataSet.CuttingBundleTracking.IssuedLineIdColumn.DefaultValue = IssuedLineIdGridLookUpEdit.EditValue
        Me.CuttingBundleTrackingDataSet.CuttingBundleTracking.BundleNoColumn.DefaultValue = CuttingNoTextBox.Text & "B" & Val(BundleNoTextBox.Text)

        '================

        Me.CuttingBundleSummeryTableAdapter.Fill(Me.CuttingBundleSummerDataSet.CuttingBundleSummery, CuttingNoTextBox.Text & "B" & Val(BundleNoTextBox.Text))


        If Me.CuttingBundleSummeryBindingSource.Position > -1 Then
            Me.CuttingBundleTrackingBindingSource.AddNew()
        Else
            MessageBox.Show("Bundle is not available", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub IssuedBranchIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssuedBranchIdGridLookUpEdit.EditValueChanged
        On Error Resume Next
        Me.LineTableAdapter.FillByBranchId(Me.LineDataSet.Line, IssuedBranchIdGridLookUpEdit.EditValue)
    End Sub

    Private Sub ShowByBranchAndDateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByBranchAndDateButton.Click

        Me.CuttingBundleTrackingDataSet.CuttingBundleTracking.CuttingBundleTrackingDateColumn.DefaultValue = DateTimePicker1.Text
        Me.CuttingBundleTrackingDataSet.CuttingBundleTracking.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue


        Me.CuttingBundleTrackingTableAdapter.FillByProdDateAndBranch(Me.CuttingBundleTrackingDataSet.CuttingBundleTracking, DateTimePicker1.Text, BranchComboBox.SelectedValue)

    End Sub
End Class