Public Class frmSewingTransfer



    Private Sub frmSewingTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.SewingLayoutTableAdapter.Fill(Me.SewingLayoutLookupDataSet.SewingLayout)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

    End Sub

    Private Sub PgNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PgNoGridLookUpEdit.EditValueChanged
        Me.OrderPOTableAdapter.FillByOrderId(Me.OrderPOLookupDataSet.OrderP0Lookup, Me.PgNoGridLookUpEdit.EditValue)
    End Sub

    Private Sub PgNo1GridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PgNo1GridLookUpEdit.EditValueChanged
        Me.OrderP0Lookup1TableAdapter.FillByOrderId(Me.OrderPOLookupDataSet.OrderP0Lookup1, Me.PgNo1GridLookUpEdit.EditValue)
    End Sub

    Private Sub FromOrderDetailsIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromOrderDetailsIdGridLookUpEdit.EditValueChanged

        Me.SewingProductionTableAdapter.FillByOrderDetailsId(Me.SewingProductionDataSet.SewingProduction, Me.FromOrderDetailsIdGridLookUpEdit.EditValue)

        For Each drv As DataRowView In Me.SewingProductionBindingSource.List

            drv!IsChecked = True

        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            'Dim TTLOutputQuantity As Integer = ReadData("Select SUM(OutputQuantity) From SewingProduction Where OrderDetailsId=" & ToPOGridLookUpEdit.EditValue, cnn)

            'Dim TTLOrderQuantity As Integer = ReadData("Select SUM(OrderQuantity) From OrderSizeDetails Where OrderDetailsId=" & ToPOGridLookUpEdit.EditValue, cnn)

            'If TTLOrderQuantity < TTLOutputQuantity * 1.05 Then

            If ToOrderDetailsIdGridLookUpEdit.Text = String.Empty Then

                MessageBox.Show("Select PO No Where you want to transfer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ToOrderDetailsIdGridLookUpEdit.Focus()

                Exit Sub

            End If


            For Each drv As DataRowView In Me.SewingProductionBindingSource.List

                'MessageBox.Show(drv!IsChecked.ToString())

                If drv!IsChecked = True Then

                    ExecuteQuery("Update SewingProduction Set OrderDetailsId = " & ToOrderDetailsIdGridLookUpEdit.EditValue & "Where SewingId=" & drv!SewingId, cnn)

                End If

            Next

            Me.SewingProductionTableAdapter.FillByOrderDetailsId(Me.SewingProductionDataSet.SewingProduction, Me.FromOrderDetailsIdGridLookUpEdit.EditValue)
            MessageBox.Show("Transferred Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class