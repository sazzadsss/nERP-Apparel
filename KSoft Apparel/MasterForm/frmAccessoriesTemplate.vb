Public Class frmAccessoriesTemplate

    Private Sub AccessoriesTemplateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesTemplateBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.AccessoriesTemplateBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.AccessoriesTemplateDataSet)
            If Me.BuyerComboBox.SelectedValue > -1 Then
                Me.AccessoriesCategoryLookupTableAdapter.Fill(Me.AccessoriesCategoryLookupDataSet.AccessoriesCategoryLookup, BuyerComboBox.SelectedValue)
            End If
        Catch ex As Exception


        End Try



    End Sub

    Private Sub frmStyleTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Me.ItemStyleTableAdapter.Fill(Me.ItemStyleDataSet.ItemStyle)
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, Val(My.Settings.AccDepartmentId))
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.AccessoriesTemplateDataSet.AccessoriesTemplate.BuyerIdColumn.DefaultValue = BuyerComboBox.SelectedValue

    End Sub

    Private Sub BuyerComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyerComboBox.SelectedIndexChanged

        Me.AccessoriesCategoryLookupTableAdapter.Fill(Me.AccessoriesCategoryLookupDataSet.AccessoriesCategoryLookup, BuyerComboBox.SelectedValue)
        Me.AccessoriesTemplateDataSet.AccessoriesTemplate.BuyerIdColumn.DefaultValue = BuyerComboBox.SelectedValue

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Me.AccessoriesTemplateTableAdapter.Fill(Me.AccessoriesTemplateDataSet.AccessoriesTemplate, BuyerComboBox.SelectedValue, CategoryComboBox.SelectedValue)

    End Sub
End Class