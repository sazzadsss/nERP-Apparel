Public Class frmShipmentComents

    Private Sub DelayShipmentCommentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelayShipmentCommentsBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.DelayShipmentCommentsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DelayShipmentCommentsDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

  
    Private Sub frmShipmentComents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderPOLookupNewTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupNew)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)


        If CheckUserRights("Shipment Comments").CanEdit = False Then

            DelayShipmentCommentsBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged, GridLookUpEdit1.Closed


        If OrderLookupBindingSource.Position > -1 Then

            'Dim row As OrderLookupDataSet.OrderLookupRow
            'row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)
            Dim OrderId As Integer = GridLookUpEdit1.EditValue

            Me.OrderPOTableAdapter.FillByOrderId(Me.OrderPOLookupDataSet.OrderP0Lookup, OrderId)
            Me.DelayShipmentCommentsTableAdapter.FillByOrderId(Me.DelayShipmentCommentsDataSet.DelayShipmentComments, OrderId)

        End If
        

    End Sub

    Private Sub GridLookUpEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit2.EditValueChanged, GridLookUpEdit2.Closed

        If OrderP0LookupBindingSource.Position > -1 Then

            'Dim row As OrderPOLookupDataSet.OrderP0LookupRow
            'row = CType(CType(Me.OrderP0LookupBindingSource.Current, DataRowView).Row, OrderPOLookupDataSet.OrderP0LookupRow)
            Dim OrderDetailsId As Integer = GridLookUpEdit2.EditValue

            Me.DelayShipmentCommentsTableAdapter.Fill(Me.DelayShipmentCommentsDataSet.DelayShipmentComments, OrderDetailsId)
            If DelayShipmentCommentsBindingSource.Position = -1 Then
                Me.DelayShipmentCommentsDataSet.DelayShipmentComments.OrderDetailsIdColumn.DefaultValue = OrderDetailsId
                Me.DelayShipmentCommentsBindingSource.AddNew()
            End If
        End If

      
    End Sub

    Private Sub DelayShipmentCommentsDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DelayShipmentCommentsDataGridView.DataError
        On Error Resume Next
    End Sub
End Class