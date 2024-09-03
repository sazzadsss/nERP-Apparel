Public Class frmGeneral

    Private Sub SupplierBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SupplierBindingSource.EndEdit()
        Me.SupplierTypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SupplierDataSet)

    End Sub

    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SupplierTypeTableAdapter.Fill(Me.SupplierDataSet.SupplierType)
        Me.SupplierAddressTableAdapter.Fill(Me.SupplierDataSet.SupplierAddress)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)

        If CheckUserRights("General").CanEdit = False Then

            AddNewToolStripButton.Enabled = False
            SupplierBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub

    
    
    Private Sub AddNewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripButton.Click
        Me.SupplierBindingSource.AddNew()
    End Sub
End Class