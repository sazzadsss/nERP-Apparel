Public Class frmFinishingDefect

    Private Sub FinishingDefectBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingDefectBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.FinishingDefectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinishingDefectDataSet)

    End Sub

    Private Sub frmFinishingSpot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Me.QCCheckListTableAdapter.FillByDepartment(Me.QCCheckListDataSet.QCCheckList, "FINISHING")
        Me.FinishingDefectDetailsTableAdapter.Fill(Me.FinishingDefectDataSet.FinishingDefectDetails)
        'Me.FinishingDefectTableAdapter.FillByBranchAndDate(Me.FinishingDefectDataSet.FinishingDefect,)


        Me.FinishingDefectDataSet.FinishingDefect.FinishingDefectDateColumn.DefaultValue = DefectDateTimePicker.Text
        Me.FinishingDefectDataSet.FinishingDefect.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue


        If CheckUserRights("Finishing Defect").CanEdit = False Then

            FinishingDefectBindingNavigatorSaveItem.Enabled = False


        End If

    End Sub

    
    Private Sub DefectDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefectDateTimePicker.ValueChanged


        Me.FinishingDefectTableAdapter.FillByBranchAndDate(Me.FinishingDefectDataSet.FinishingDefect, DefectDateTimePicker.Text, BranchComboBox.SelectedValue)
        Me.FinishingDefectDataSet.FinishingDefect.FinishingDefectDateColumn.DefaultValue = DefectDateTimePicker.Text


    End Sub

    Private Sub LoadDefectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadDefectButton.Click

        Me.Validate()
        Me.FinishingDefectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinishingDefectDataSet)

        If FinishingDefectBindingSource.Position > -1 Then


            If FinishingDefectDetailsBindingSource.Position = -1 Then


                For Each dr As DataRowView In QCCheckListBindingSource.List


                    Dim row As FinishingDefectDataSet.FinishingDefectRow
                    row = CType(CType(Me.FinishingDefectBindingSource.Current, DataRowView).Row, FinishingDefectDataSet.FinishingDefectRow)


                    Dim newRow As FinishingDefectDataSet.FinishingDefectDetailsRow = Me.FinishingDefectDataSet.FinishingDefectDetails.NewRow()



                    newRow.FinishingDefectId = row.FinishingDefectId
                    newRow.QCCheckListId = dr!QCCheckListId
                    newRow.DefectQuantity = 0


                    'If dr!Name = "Fabric" Then

                    '    newRow.Quantity = ReadData("Select Sum(FabricRejectQuantity) From SewingRejection Where SewingId IN (Select SewingId From SewingProduction Where OrderId=" & row.OrderId & "And SewingDate=" & row.QCDate & "And LineId=" & row.LineId & ")", cnn)

                    'ElseIf dr!Name = "Sewing" Then

                    '    newRow.Quantity = ReadData("Select Sum(SewingRejectQuantity) From SewingRejection Where SewingId IN (Select SewingId From SewingProduction Where OrderId=" & row.OrderId & "And SewingDate=" & row.QCDate & "And LineId=" & row.LineId & ")", cnn)

                    'ElseIf dr!Name = "Cutter" Then

                    '    newRow.Quantity = ReadData("Select Sum(CutterRejectQuantity) From SewingRejection Where SewingId IN (Select SewingId From SewingProduction Where OrderId=" & row.OrderId & "And SewingDate=" & row.QCDate & "And LineId=" & row.LineId & ")", cnn)

                    'Else

                    '    newRow.Quantity = 0

                    'End If


                    Me.FinishingDefectDataSet.FinishingDefectDetails.Rows.Add(newRow)

                Next


            End If
        End If

    End Sub

   
    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged

        Me.FinishingDefectTableAdapter.FillByBranchAndDate(Me.FinishingDefectDataSet.FinishingDefect, DefectDateTimePicker.Text, BranchComboBox.SelectedValue)
        Me.FinishingDefectDataSet.FinishingDefect.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue

    End Sub
End Class