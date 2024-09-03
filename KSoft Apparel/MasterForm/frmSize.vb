Public Class frmSize

    Private Sub SizeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SizeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SizeDataSet)

    End Sub

    Private Sub frmSize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)

        If CheckUserRights("Size").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            SizeBindingNavigatorSaveItem.Enabled = False

        End If

    End Sub
End Class