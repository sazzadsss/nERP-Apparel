Public Class frmOrderColorUpdate

   

    Private Sub frmOrderColorUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        ShowMaster(frmFabricColor)

        If frmFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then

            Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
            Dim indx As Integer = Me.FabricColorBindingSource.Find("FabricColorId", frmFabricColor.FabricColorId)
            Me.FabricColorBindingSource.Position = indx


        End If

    End Sub

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged, ProgramNoGridLookUpEdit.Closed

        Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoGridLookUpEdit.Text)

    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click

        Dim OrdId As Integer = ProgramNoGridLookUpEdit.EditValue


        'ExecuteQuery("Update Fabric Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And OrderId=" & OrdId, cnn)
        ExecuteQuery("Update OrderDetails Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And OrderId=" & OrdId, cnn)
        ExecuteQuery("Update PrintOrder Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And OrderId=" & OrdId, cnn)
        ExecuteQuery("Update SewingProduction Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And OrderId=" & OrdId, cnn)
        ExecuteQuery("Update CuttingProduction Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And OrderId=" & OrdId, cnn)
        ExecuteQuery("Update FinishingRejection Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And OrderId=" & OrdId, cnn)
        ExecuteQuery("Update CuttingProductionNew Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And OrderId=" & OrdId, cnn)
        ExecuteQuery("Update Planning Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And OrderId=" & OrdId, cnn)
        ExecuteQuery("Update CuttingProductionDetails Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And OrderId=" & OrdId, cnn)
        ExecuteQuery("Update CuttingCutPanelRejection Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And OrderId=" & OrdId, cnn)
        ExecuteQuery("Update OrderCuttingPercentage Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And OrderId=" & OrdId, cnn)
        'ExecuteQuery("Update FabricBOMDetails Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And FabricBOMId=(Select FabricBOMId From FabricBOM Where OrderId=" & OrdId & ")", cnn)
        'ExecuteQuery("Update FabricForSize Set FabricColorId=" & Me.PresentColorComboBox.SelectedValue & " Where FabricColorId=" & PreviousColorComboBox.SelectedValue & "And FabricId in (Select FabricId From Fabric Where OrderId=" & OrdId & ")", cnn)


        MessageBox.Show("Updated Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)


        'DyeingProductionNew()
        'YarnBooking()
        'CuttingProduction()
        'Planning()
        'AppointmentDetails()
        'Sewing()
        'CuttingProduction_Test()
        'AmendmentDetails_FabricBOM()
        'AmendmentDetails_Order()
        'CuttingProductionDetails()
        'SewingProduction()
        'FabricColor()
        'OrderReconciliation()
        'Recipe()
        'FabricBOMDetails()
        'SampleRequestFinalDetails()
        'PrintReceiveToCutting()
        'cmpFabric()
        'PrintOrder()
        'OrderGarmentsPart()
        'cmpFabricBOMDetails()
        'TwinPackDetails()
        'CuttingProductionNew()
        'CuttingCutPanelRejection()
        'OrderDetails()
        'Fabric()

    End Sub

End Class