Public Class frmLearningCurve

    Private Sub SewingLearningCurveBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingLearningCurveBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SewingLearningCurveBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)

    End Sub

    Private Sub frmLearningCurve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SewingAllocateQuantityMasterDataSet.SewingAllocateQuantityMaster' table. You can move, or remove it, as needed.
        Me.SewingAllocateQuantityMasterTableAdapter.Fill(Me.SewingAllocateQuantityMasterDataSet.SewingAllocateQuantityMaster)
        Me.SewingLearningCurveTableAdapter.Fill(Me.SewingLayoutDataSet.SewingLearningCurve)

        If CheckUserRights("Learning Curve").CanEdit = False Then

            SewingLearningCurveBindingNavigatorSaveItem.Enabled = False
        End If
    End Sub
End Class