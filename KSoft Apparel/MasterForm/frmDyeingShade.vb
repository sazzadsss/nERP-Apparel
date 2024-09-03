Public Class frmDyeingShade

    Private Sub DyeingShadeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DyeingShadeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DyeingShadeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DyeingShadeDataSet)

    End Sub

    Private Sub frmDyeingShade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DyeingShadeTableAdapter.Fill(Me.DyeingShadeDataSet.DyeingShade)

        If CheckUserRights("Dyeing Shade").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            DyeingShadeBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Dyeing Shade").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            DyeingShadeBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If
    End Sub
End Class