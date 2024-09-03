Public Class frmItemLocation

    Private Sub ItemLocationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemLocationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ItemLocationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ItemLocationDataSet)

    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.ItemLocationTableAdapter.Fill(Me.ItemLocationDataSet.ItemLocation, New System.Nullable(Of Long)(CType(DepartmentIdToolStripTextBox.Text, Long)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub frmItemLocation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ItemLocationTableAdapter.Fill(Me.ItemLocationDataSet.ItemLocation, DepartmentId)
        Me.ItemLocationDataSet.ItemLocation.DepartmentIdColumn.DefaultValue = DepartmentId
    End Sub

    
End Class