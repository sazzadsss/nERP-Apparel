Public Class frmGMTBrand

    Private Sub frmGMTBrand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
        Me.GMTBrandTableAdapter.Fill(Me.GMTBrandDataSet.GMTBrand)

        If CheckUserRights("Garments Brand").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            BindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Garments Brand").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GMTBrandBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GMTBrandDataSet)
    End Sub
End Class