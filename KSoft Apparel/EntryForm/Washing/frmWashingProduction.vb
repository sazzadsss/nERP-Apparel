Public Class frmWashingProduction

    Private Sub WashingProductionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WashingProductionBindingNavigatorSaveItem.Click
        Try

            Me.Validate()
            Me.WashingProductionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.WashingProductionDataSet)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
        

    End Sub

    Private Sub frmWashingProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WashingRequestDetailsLookupDataSet.WashingRequestDetailsLookupAll' table. You can move, or remove it, as needed.
        Me.WashingRequestDetailsLookupAllTableAdapter.Fill(Me.WashingRequestDetailsLookupDataSet.WashingRequestDetailsLookupAll)
        Me.WashingRequestLookUpTableAdapter.Fill(Me.WashingRequestDataSet.WashingRequestLookUp)
        Me.WashingProductionTableAdapter.Fill(Me.WashingProductionDataSet.WashingProduction, ProductionDateTimePicker.Text)

    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WRIDGridLookUpEdit.EditValueChanged

        On Error Resume Next
        Me.WashingRequestDetailsLookupTableAdapter.Fill(Me.WashingRequestDetailsLookupDataSet.WashingRequestDetailsLookup, WRIDGridLookUpEdit.EditValue)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WashingProductionTableAdapter.FillByWRDID(Me.WashingProductionDataSet.WashingProduction, WRDIDGridLookUpEdit.EditValue)
        Me.WashingBatchTableAdapter.FillByWRDID(Me.WashingBatchDataSet.WashingBatch, WRDIDGridLookUpEdit.EditValue)
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Dim newRow = CType(Me.WashingProductionDataSet.WashingProduction.NewRow(), WashingProductionDataSet.WashingProductionRow)
        newRow.WashingRequestDetailsId = WRDIDGridLookUpEdit.EditValue
        newRow.WashingBatchId = GridLookUpEdit3.EditValue
        newRow.WashingProductionDate = ReadDateData("Select GetDate()", cnn)
        newRow.InputQuantityKg = 0
        newRow.InputQuantityPc = 0
        newRow.WashQuantityKg = 0
        newRow.WashQuantityPc = 0
        newRow.RejectQuantityKg = 0
        newRow.RejectQuantityPc = 0
        newRow.DeliveryQuantityKg = 0
        newRow.DeliveryQuantityPc = 0
        Me.WashingProductionDataSet.WashingProduction.Rows.Add(newRow)

    End Sub

    Private Sub ShowByWRButton_Click(sender As Object, e As EventArgs) Handles ShowByWRButton.Click
        Me.WashingProductionTableAdapter.FillByWRID(Me.WashingProductionDataSet.WashingProduction, WRIDGridLookUpEdit.EditValue)
    End Sub

    Private Sub ShowByDateButton_Click(sender As Object, e As EventArgs) Handles ShowByDateButton.Click

        Me.WashingProductionTableAdapter.Fill(Me.WashingProductionDataSet.WashingProduction, ProductionDateTimePicker.Value.Date)
    End Sub


End Class