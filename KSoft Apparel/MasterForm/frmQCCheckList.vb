Public Class frmQCCheckList

   
   
    Private Sub QCCheckListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QCCheckListBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.QCCheckListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QCCheckListDataSet)

    End Sub

    Private Sub frmQCCheckList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.QCCheckListTableAdapter.Fill(Me.QCCheckListDataSet.QCCheckList)

        If CheckUserRights("QC Check List").CanEdit = False Then

            QCCheckListBindingNavigatorSaveItem.Enabled = False
       End If

    End Sub

End Class