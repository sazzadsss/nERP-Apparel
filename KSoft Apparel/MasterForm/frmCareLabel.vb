Public Class frmCareLabel

    Private Sub CareLabelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CareLabelBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CareLabelBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CareLabelDataSet)

    End Sub

    Private Sub frmCareLabel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CareLabelDataSet.CareLabel' table. You can move, or remove it, as needed.
        Me.CareLabelTableAdapter.Fill(Me.CareLabelDataSet.CareLabel)


        If CheckUserRights("Care Label").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            CareLabelBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Care Label").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            CareLabelBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub
End Class