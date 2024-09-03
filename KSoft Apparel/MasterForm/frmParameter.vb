Public Class frmParameter

    Private Sub ParameterBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParameterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ParameterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ParameterDataSet)

    End Sub

    Private Sub frmParameter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ParameterTableAdapter.Fill(Me.ParameterDataSet.Parameter)

    End Sub
End Class