Public Class frmDyeingType

    Private Sub DyeingTypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DyeingTypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DyeingTypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DyeingTypeDataSet)

    End Sub

    Private Sub frmDyeingType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DyeingTypeTableAdapter.Fill(Me.DyeingTypeDataSet.DyeingType)

        If CheckUserRights("Dyeing Type").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            DyeingTypeBindingNavigatorSaveItem.Enabled = False

        End If

    End Sub
End Class