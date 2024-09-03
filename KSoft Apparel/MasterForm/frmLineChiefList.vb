Public Class frmLineChiefList

    Private Sub LineChiefListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineChiefListBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.LineChiefListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LineCheifDataSet)

    End Sub

    Private Sub frmLineChiefList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.LineChiefListTableAdapter.Fill(Me.LineCheifDataSet.LineChiefList)


        If CheckUserRights("Line Chief List").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            LineChiefListBindingNavigatorSaveItem.Enabled = False
        End If
    End Sub

    Private Sub LineChiefListDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles LineChiefListDataGridView.DataError
        On Error Resume Next
    End Sub
End Class