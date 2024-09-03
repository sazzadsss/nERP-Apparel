Public Class frmUnitConversion

    Private Sub UnitConversionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitConversionBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.UnitConversionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UnitConversionDataSet)

    End Sub

    Private Sub frmUnitConversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.UnitConversionTableAdapter.Fill(Me.UnitConversionDataSet.UnitConversion)

        If CheckUserRights("Unit Conversion").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            UnitConversionBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub

    Private Sub UnitConversionDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles UnitConversionDataGridView.DataError
        On Error Resume Next
    End Sub
End Class