Public Class frmWashingBatch

    Private Sub WashingBatchBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WashingBatchBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.WashingBatchBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.WashingBatchDataSet)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
        
    End Sub

    Private Sub frmWashingBatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WashingRequestLookUpTableAdapter.Fill(Me.WashingRequestDataSet.WashingRequestLookUp)

    End Sub

   

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WRIDGridLookUpEdit.EditValueChanged
        On Error Resume Next
        Me.WashingRequestDetailsLookupTableAdapter.Fill(Me.WashingRequestDetailsLookupDataSet.WashingRequestDetailsLookup, WRIDGridLookUpEdit.EditValue)
        Me.WashingBatchTableAdapter.FillByWashingRequestId(Me.WashingBatchDataSet.WashingBatch, WRIDGridLookUpEdit.EditValue)

    End Sub

    Private Sub AddBatchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBatchButton.Click

        Dim i As Integer = 0

        Dim MaxBatchNo As String = ReadIntData("Select ISNULL(Max(Cast(REVERSE(SUBSTRING(REVERSE(WashingBatchNo),0,CHARINDEX('-',REVERSE(WashingBatchNo))))AS Integer)),0) From WashingBatch Where WashingBatchNo like '" & Now.Year.ToString.Substring(2) & "%'", cnn).ToString()

        Do Until i = Val(NoOfBatchNumericUpDown.Value)
            i = i + 1
            Dim newRow As WashingBatchDataSet.WashingBatchRow = Me.WashingBatchDataSet.WashingBatch.NewRow()

            newRow.WashingBatchNo = Now.Year.ToString.Substring(2) & "-" & MaxBatchNo.Replace(MaxBatchNo, (Val(MaxBatchNo) + i).ToString(""))
            newRow.BatchQuantity = Val(BatchQuantityTextBox.Text)
            newRow.BatchQuantityPc = Val(TextBox1.Text)
            newRow.WashingRequestDetailsId = WRDIDGridLookUpEdit.EditValue
            newRow.WashingBatchDate = ReadDateData("Select GetDate()", cnn)

            newRow.Remarks = "-"

            Me.WashingBatchDataSet.WashingBatch.Rows.Add(newRow)


        Loop


    End Sub

    Private Sub ShowByWashingRequestButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByWashingRequestButton.Click

        On Error Resume Next
        Me.WashingRequestDetailsLookupTableAdapter.Fill(Me.WashingRequestDetailsLookupDataSet.WashingRequestDetailsLookup, WRIDGridLookUpEdit.EditValue)
        Me.WashingBatchTableAdapter.FillByWashingRequestId(Me.WashingBatchDataSet.WashingBatch, WRIDGridLookUpEdit.EditValue)

    End Sub

    Private Sub RefreshSummery()


        Dim InputQuantityKg As Decimal = ReadData("Select Sum(InputQuantityKg) From WashingProduction Where WashingRequestDetailsId=" & Me.WRDIDGridLookUpEdit.EditValue, cnn)
        Dim AlreadyBatchKg As Decimal = ReadData("Select Sum(BatchQuantity) From WashingBatch Where WashingRequestDetailsId=" & Me.WRDIDGridLookUpEdit.EditValue, cnn)
        Dim BalanceQuantityKg As Decimal = InputQuantityKg - AlreadyBatchKg

        Dim InputQuantityPc As Decimal = ReadData("Select Sum(InputQuantityPc) From WashingProduction Where WashingRequestDetailsId=" & Me.WRDIDGridLookUpEdit.EditValue, cnn)
        Dim AlreadyBatchPc As Decimal = ReadIntData("Select Sum(BatchQuantityPc) From WashingBatch Where WashingRequestDetailsId=" & Me.WRDIDGridLookUpEdit.EditValue, cnn)
        Dim BalanceQuantityPc As Decimal = InputQuantityPc - AlreadyBatchPc


        InputQtyLabel.Text = InputQuantityKg
        AlreadyBatchLabel.Text = AlreadyBatchKg
        Label8.Text = BalanceQuantityKg

        InputQtyPcsLabel.Text = InputQuantityPc
        AlreadBatchQtyPcsLabel.Text = AlreadyBatchPc
        BalanceQtyPcsLabel.Text = BalanceQuantityPc



    End Sub

    Private Sub ShowByWashingRequestDetailsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByWashingRequestDetailsButton.Click
        Me.WashingBatchTableAdapter.FillByWRDID(Me.WashingBatchDataSet.WashingBatch, WRDIDGridLookUpEdit.EditValue)
    End Sub

    Private Sub RefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        RefreshSummery()
    End Sub
End Class