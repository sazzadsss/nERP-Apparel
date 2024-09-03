Public Class frmGarmentsPart

    
    Private Sub GarmentsPartBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GarmentsPartBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GarmentsPartBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GarmentsPartDataSet)

    End Sub

    Private Sub frmGarmentsPart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.GarmentsPartTableAdapter.Fill(Me.GarmentsPartDataSet.GarmentsPart)

        If CheckUserRights("Garments Part").CanEdit = False Then

            GarmentsPartBindingNavigatorSaveItem.Enabled = False

        End If
    End Sub
End Class