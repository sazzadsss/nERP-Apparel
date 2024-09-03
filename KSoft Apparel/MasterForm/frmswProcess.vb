Public Class frmswProcess

    Private Sub SwProcessBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwProcessBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SwProcessBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SwProcessDataSet)

    End Sub

    Private Sub frmswProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SwProcessTableAdapter.Fill(Me.SwProcessDataSet.swProcess)

    End Sub
End Class