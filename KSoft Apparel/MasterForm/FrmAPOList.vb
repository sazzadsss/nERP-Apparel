Imports System.Windows.Forms

Public Class FrmAPOList

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CuttingAPOListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingAPOListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CuttingAPOListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CuttingAPOListDataSet)

    End Sub

    Private Sub FrmAPOList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CuttingAPOListTableAdapter.Fill(Me.CuttingAPOListDataSet.CuttingAPOList)
        If CheckUserRights("APO List").CanEdit = False Then

            CuttingAPOListBindingNavigatorSaveItem.Enabled = False

        End If
    End Sub
End Class
