Public Class frmWashType

    Private Sub WashTypeMstBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WashTypeMstBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WashTypeMstBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WashTypeDataSet)

    End Sub

    Private Sub frmWashType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WashTypeMstTableAdapter.Fill(Me.WashTypeDataSet.WashTypeMst)

        If CheckUserRights("Wash Type").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            WashTypeMstBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub
End Class