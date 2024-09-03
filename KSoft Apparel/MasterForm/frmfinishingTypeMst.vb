Public Class frmfinishingTypeMst 

    Private Sub FabricFinishingTypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricFinishingTypeBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.FabricFinishingTypeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FabricFinishingTypeDataSet)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
       

    End Sub

    Private Sub frmfinishingTypeMst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FabricFinishingTypeTableAdapter.Fill(Me.FabricFinishingTypeDataSet.FabricFinishingType)

        If CheckUserRights("Finishing Type").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            FabricFinishingTypeBindingNavigatorSaveItem.Enabled = False
        End If

    End Sub
End Class