Public Class frmMasterOrderSampleLookUp
  
    Private Sub frmMasterOrderSampleLookUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MasterOrderSampleRequestLookUpTableAdapter.FillByRequestNo(Me.MasterOrderSampleLookUpDataSet.MasterOrderSampleRequestLookUp)

    End Sub

    Private Sub MasterOrderSampleRequestLookUpDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MasterOrderSampleRequestLookUpDataGridView.RowHeaderMouseDoubleClick
        If Me.MasterOrderSampleRequestLookUpBindingSource.Position > -1 Then

            Dim row As MasterOrderSampleLookUpDataSet.MasterOrderSampleRequestLookUpRow
            row = CType(CType(Me.MasterOrderSampleRequestLookUpBindingSource.Current, DataRowView).Row, MasterOrderSampleLookUpDataSet.MasterOrderSampleRequestLookUpRow)

            frmSampleOrder.SampleReqNo = row.SampleRequestNo
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

        End If
    End Sub
End Class