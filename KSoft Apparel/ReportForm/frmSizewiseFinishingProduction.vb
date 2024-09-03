Public Class frmSizewiseFinishingProduction

    Private Sub frmSizewiseFinishingProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

    End Sub

  
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Me.SpSizewiseFinishingProd2TableAdapter.Fill(Me.SpSizewiseFinishingProd2DataSet.spSizewiseFinishingProd2, GridLookUpEdit1.EditValue)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.SizewiseFinishingPrd1TableAdapter.Fill(Me.SizewiseFinishingProdDataSet.SizewiseFinishingPrd1, GridLookUpEdit2.EditValue)
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Me.SizewiseFinishingPrd2TableAdapter.Fill(Me.SizewiseFinishingProdDataSet.SizewiseFinishingPrd2, GridLookUpEdit3.EditValue)
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Me.SizewiseFinishingPrd3TableAdapter.Fill(Me.SizewiseFinishingProdDataSet.SizewiseFinishingPrd3, GridLookUpEdit4.EditValue)
    End Sub

    Private Sub ECSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECSimpleButton.Click
        If ECSimpleButton.Text = "Expand" Then
            SplitContainer1.Panel2Collapsed = True
            SplitContainer2.Panel2Collapsed = True
            ECSimpleButton.Text = "Compact"
        Else
            SplitContainer1.Panel2Collapsed = False
            SplitContainer2.Panel2Collapsed = False
            ECSimpleButton.Text = "Expand"
        End If
    End Sub
End Class