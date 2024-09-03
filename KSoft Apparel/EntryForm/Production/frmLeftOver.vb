Public Class frmLeftOver

    Private Sub LeftOverBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftOverBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.LeftOverBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LeftOverDataSet)

    End Sub

    Private Sub frmLeftOver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

    End Sub

    Private Sub OrderNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderNoGridLookUpEdit.EditValueChanged

        Try
            Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, OrderNoGridLookUpEdit.EditValue)
            Me.OrderReconcilationTableAdapter.Fill(Me.OrderReconcilationDataSet.OrderReconcilation, New System.Nullable(Of Long)(CType(OrderNoGridLookUpEdit.EditValue, Long)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub FabricColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.SelectedIndexChanged

        With Me.LeftOverDataSet.LeftOver
            .OrderIdColumn.DefaultValue = Me.OrderNoGridLookUpEdit.EditValue
            .FabricColorIdColumn.DefaultValue = Me.FabricColorComboBox.SelectedValue
        End With

        Me.LeftOverTableAdapter.FillByOrderAndColor(Me.LeftOverDataSet.LeftOver, Me.OrderNoGridLookUpEdit.EditValue, FabricColorComboBox.SelectedValue)

    End Sub

   
    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class