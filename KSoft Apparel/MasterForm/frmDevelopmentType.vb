Public Class frmDevelopmentType

    Private Sub DevTypeMstBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevTypeMstBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DevTypeMstBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DevTypeDataSet)

    End Sub

    Private Sub frmDevelopmentType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DevTypeMstTableAdapter.Fill(Me.DevTypeDataSet.DevTypeMst)
        If CheckUserRights("Development Type").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            DevTypeMstBindingNavigatorSaveItem.Enabled = False


        End If
    End Sub
End Class