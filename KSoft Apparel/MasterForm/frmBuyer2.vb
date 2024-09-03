Public Class frmBuyer2

    Private Sub Buyer2BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buyer2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Buyer2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Buyer2DataSet)

    End Sub

    Private Sub frmBuyer2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.Buyer2TableAdapter.Fill(Me.Buyer2DataSet.Buyer2)


        If CheckUserRights("Buyer2").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            Buyer2BindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Buyer2").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            Buyer2BindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If


    End Sub
End Class