Public Class frmFinishingRejection

    Private Sub frmFinishingRejection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoGridLookUpEdit.Text)


        FillFinishingRejection()


        If CheckUserRights("Finishing Rejection").CanEdit = False Then

            AddNewButton.Enabled = False
            SaveButton.Enabled = False
        End If

    End Sub


    Private Sub FillFinishingRejection()

        Me.FinishingRejectionTableAdapter.FillByBranchAndDate(Me.FinishingProductionDataSet.FinishingRejection, BranchComboBox.SelectedValue, DateTimePicker1.Text)

        Me.FinishingProductionDataSet.FinishingRejection.FinishingRejectDateColumn.DefaultValue = DateTimePicker1.Text
        Me.FinishingProductionDataSet.FinishingRejection.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue
        Me.FinishingProductionDataSet.FinishingRejection.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue

        Dim myorderid As Integer = ReadIntegerData("Select Distinct OrderId From [Order] Where ProgramNo='" & ProgramNoGridLookUpEdit.Text & "'", cnn)

        Me.FinishingProductionDataSet.FinishingRejection.OrderIdColumn.DefaultValue = myorderid



    End Sub

   


    Private Sub FabricColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.SelectedIndexChanged
        Me.FinishingProductionDataSet.FinishingRejection.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue
    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        Me.FinishingProductionDataSet.FinishingRejection.FinishingRejectDateColumn.DefaultValue = DateTimePicker1.Text
        FillFinishingRejection()



    End Sub

    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged

        Me.FinishingProductionDataSet.FinishingRejection.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue
        FillFinishingRejection()

    End Sub

   

    'Private Sub ProgramNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoComboBox.SelectedIndexChanged, ProgramNoComboBox.TextChanged

   
    'End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Me.Validate()
        Me.FinishingRejectionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinishingProductionDataSet)

        ProgramNoGridLookUpEdit.Focus()



    End Sub

    Private Sub RefreshSummery()

        For Each dr As DataRowView In FinishingRejectionBindingSource.List

            Dim vFabric As Decimal = 0
            Dim vPrint As Decimal = 0
            Dim vSewing As Decimal = 0
            Dim vCutter As Decimal = 0

           
            vPrint = vPrint + dr!PrintRejectQuantity
            PrintLabel.Text = vPrint


           
            vFabric = vFabric + dr!FabricRejectQuantity
            FabricLabel.Text = vFabric


            vSewing = vSewing + dr!SewingRejectQuantity
            SewingLabel.Text = vSewing



            vCutter = vCutter + dr!CutterRejectQuantity
            CutterLabel.Text = vCutter


        Next


    End Sub

    Private Sub FinishingRejectionBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FinishingRejectionBindingSource.PositionChanged, FinishingRejectionBindingSource.CurrentChanged


        Dim vFabric As Decimal = 0
        Dim vPrint As Decimal = 0
        Dim vSewing As Decimal = 0
        Dim vCutter As Decimal = 0


        For Each dr As DataRowView In FinishingRejectionBindingSource.List

            If IsDBNull(dr!PrintRejectQuantity) = False Then
                vPrint = vPrint + dr!PrintRejectQuantity
            End If
            PrintLabel.Text = vPrint


            If IsDBNull(dr!PrintRejectQuantity) = False Then
                vFabric = vFabric + dr!FabricRejectQuantity
            End If

            FabricLabel.Text = vFabric

            If IsDBNull(dr!SewingRejectQuantity) = False Then
                vSewing = vSewing + dr!SewingRejectQuantity
            End If

            SewingLabel.Text = vSewing

            If IsDBNull(dr!cutterRejectQuantity) = False Then
                vCutter = vCutter + dr!CutterRejectQuantity

            End If
            CutterLabel.Text = vCutter

            TTLRJCTLABEL.Text = Val(PrintLabel.Text) + Val(FabricLabel.Text) + Val(SewingLabel.Text) + Val(CutterLabel.Text)

        Next


    End Sub

    
    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged, ProgramNoGridLookUpEdit.Closed

        Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoGridLookUpEdit.Text)
        Me.FinishingProductionDataSet.FinishingRejection.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue

        Dim myorderid As Integer = ReadIntegerData("Select Distinct OrderId From [Order] Where ProgramNo='" & ProgramNoGridLookUpEdit.Text & "'", cnn)

        Me.FinishingProductionDataSet.FinishingRejection.OrderIdColumn.DefaultValue = myorderid


    End Sub


    Private Sub AddNewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewButton.Click

        Me.FinishingProductionDataSet.FinishingRejection.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue

        On Error Resume Next
        Me.FinishingRejectionBindingSource.AddNew()

    End Sub
End Class