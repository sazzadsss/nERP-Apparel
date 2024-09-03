Public Class frmSewingTableQC

    Private Sub frmSewingTableQC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SewingTableQCDetailsTableAdapter.Fill(Me.SewingTableQCDataSet.SewingTableQCDetails)

        Me.LineTableAdapter.Fill(Me.LineDataSet.Line)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.QCCheckListTableAdapter.Fill(Me.QCCheckListDataSet.QCCheckList)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Me.SewingTableQCDataSet.SewingTableQC.QCDateColumn.DefaultValue = QCDateTimePicker.Text
        Me.SewingTableQCDataSet.SewingTableQC.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue

        Me.LineTableAdapter.FillByBranchId(Me.LineDataSet.Line, Me.BranchComboBox.SelectedValue)


    End Sub

    Private Sub SewingTableQCBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingTableQCBindingNavigatorSaveItem.Click, Button1.Click

        Me.Validate()
        Me.SewingTableQCBindingSource.EndEdit()
        Me.SewingTableQCDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingTableQCDataSet)

    End Sub


    Private Sub LoadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadButton.Click
        On Error Resume Next
        Me.Validate()
        Me.SewingTableQCBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingTableQCDataSet)

        Me.QCCheckListTableAdapter.FillByGarmentType(QCCheckListDataSet.QCCheckList, "Sewing", GarmentTypeComboBox.Text.ToString())

        If SewingTableQCDetailsBindingSource.Position = -1 Then


            For Each dr As DataRowView In QCCheckListBindingSource.List


                Dim row As SewingTableQCDataSet.SewingTableQCRow
                row = CType(CType(Me.SewingTableQCBindingSource.Current, DataRowView).Row, SewingTableQCDataSet.SewingTableQCRow)


                Dim newRow As SewingTableQCDataSet.SewingTableQCDetailsRow = Me.SewingTableQCDataSet.SewingTableQCDetails.NewRow()



                newRow.SewingTableQCId = row.SewingTableQCId
                newRow.QCCheckListId = dr!QCCheckListId

                If dr!Name = "Fabric" Then

                    newRow.Quantity = ReadData("Select Sum(FabricRejectQuantity) From SewingRejection Where SewingId IN (Select SewingId From SewingProduction Where OrderId=" & row.OrderId & "And SewingDate=" & row.QCDate & "And LineId=" & row.LineId & ")", cnn)

                ElseIf dr!Name = "Sewing" Then

                    newRow.Quantity = ReadData("Select Sum(SewingRejectQuantity) From SewingRejection Where SewingId IN (Select SewingId From SewingProduction Where OrderId=" & row.OrderId & "And SewingDate=" & row.QCDate & "And LineId=" & row.LineId & ")", cnn)

                ElseIf dr!Name = "Cutter" Then

                    newRow.Quantity = ReadData("Select Sum(CutterRejectQuantity) From SewingRejection Where SewingId IN (Select SewingId From SewingProduction Where OrderId=" & row.OrderId & "And SewingDate=" & row.QCDate & "And LineId=" & row.LineId & ")", cnn)

                Else

                    newRow.Quantity = 0

                End If


                Me.SewingTableQCDataSet.SewingTableQCDetails.Rows.Add(newRow)

            Next


        End If

    End Sub

    Private Sub QCDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QCDateTimePicker.ValueChanged

        Me.SewingTableQCTableAdapter.FillByDateAndBarch(Me.SewingTableQCDataSet.SewingTableQC, QCDateTimePicker.Text, BranchComboBox.SelectedValue)
        Me.SewingTableQCDataSet.SewingTableQC.QCDateColumn.DefaultValue = QCDateTimePicker.Text

    End Sub

    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged

        Me.SewingTableQCTableAdapter.FillByDateAndBarch(Me.SewingTableQCDataSet.SewingTableQC, QCDateTimePicker.Text, BranchComboBox.SelectedValue)
        Me.SewingTableQCDataSet.SewingTableQC.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue

        Me.LineTableAdapter.FillByBranchId(Me.LineDataSet.Line, Me.BranchComboBox.SelectedValue)

    End Sub


    Private Sub SewingTableQCBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingTableQCBindingSource.PositionChanged, SewingTableQCBindingSource.CurrentChanged

        'Calculating Total
        If SewingTableQCBindingSource.Position > -1 Then

            Dim row1 As SewingTableQCDataSet.SewingTableQCRow
            row1 = CType(CType(Me.SewingTableQCBindingSource.Current, DataRowView).Row, SewingTableQCDataSet.SewingTableQCRow)

            Dim AlterQuantity As Integer = ReadIntData("Select Sum(Quantity) from SewingTableQCDetails Where SewingTableQCID=" & row1.SewingTableQCId & " AND QCChecklistId in (Select QCChecklistId From QCChecklist Where Category='Alter' and Department='Sewing')", cnn)
            Dim SpotQuantity As Integer = ReadIntData("Select Sum(Quantity) from SewingTableQCDetails Where SewingTableQCID=" & row1.SewingTableQCId & " AND QCChecklistId in (Select QCChecklistId From QCChecklist Where Category='Spot n Shade' and Department='Sewing')", cnn)
            Dim RejectQuantity As Integer = ReadIntData("Select Sum(Quantity) from SewingTableQCDetails Where SewingTableQCID=" & row1.SewingTableQCId & " AND QCChecklistId in (Select QCChecklistId From QCChecklist Where Category='Reject' and Department='Sewing')", cnn)

            AlterLabel.Text = AlterQuantity
            SpotLabel.Text = SpotQuantity
            RejectLabel.Text = RejectQuantity

        End If

    End Sub


    Private Sub SewingTableQCDetailsDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SewingTableQCDetailsDataGridView.CellClick

        SewingTableQCDataGridView.CurrentRow.Selected = True
        SewingTableQCDetailsDataGridView.CurrentRow.Selected = True

    End Sub

    Private Sub SewingTableQCDetailsBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingTableQCDetailsBindingSource.CurrentChanged, SewingTableQCDetailsBindingSource.PositionChanged
        'Calculating Total
        On Error Resume Next
        If SewingTableQCDetailsBindingSource.Position > -1 Then


            Dim AlterQuantity As Integer = 0
            Dim SpotQuantity As Integer = 0
            Dim RejectQuantity As Integer = 0

            For Each dr As DataRowView In SewingTableQCDetailsBindingSource.List


                Dim Categroy As String = ReadStringData("Select Distinct Category from QCCheckList Where QCCheckListId=" & dr!QCCheckListId, cnn).ToString


                Select Case Categroy


                    Case "Alter"

                        AlterQuantity = AlterQuantity + dr!Quantity
                        AlterLabel.Text = AlterQuantity

                    Case "Spot n Shade"

                        SpotQuantity = SpotQuantity + dr!Quantity
                        SpotLabel.Text = SpotQuantity

                    Case "Reject"

                        RejectQuantity = RejectQuantity + dr!Quantity
                        RejectLabel.Text = RejectQuantity


                    Case Else

                        AlterQuantity = AlterQuantity
                        SpotQuantity = SpotQuantity
                        RejectQuantity = RejectQuantity

                End Select




            Next


        End If
    End Sub

    Private Sub GetRejectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetRejectionButton.Click
        If Me.SewingTableQCBindingSource.Position = -1 Then
            MessageBox.Show("No Data")
            Exit Sub
        End If
        Dim row As SewingTableQCDataSet.SewingTableQCRow
        row = CType(CType(Me.SewingTableQCBindingSource.Current, DataRowView).Row, SewingTableQCDataSet.SewingTableQCRow)

        For Each dr As DataRowView In SewingTableQCDetailsBindingSource.List



            If dr!QCChecklistId = 1 Then

                dr!Quantity = ReadIntData("Select Sum(FabricRejectQuantity) From SewingRejection Where SewingId IN (Select SewingId From SewingProduction Where OrderId=" & row.OrderId & "And SewingDate='" & row.QCDate & "' And LineId=" & row.LineId & ")", cnn)

            ElseIf dr!QCChecklistId = 2 Then

                dr!Quantity = ReadIntData("Select Sum(SewingRejectQuantity) From SewingRejection Where SewingId IN (Select SewingId From SewingProduction Where OrderId=" & row.OrderId & "And SewingDate='" & row.QCDate & "' And LineId=" & row.LineId & ")", cnn)

            ElseIf dr!QCChecklistId = 3 Then

                dr!Quantity = ReadIntData("Select Sum(CutterRejectQuantity) From SewingRejection Where SewingId IN (Select SewingId From SewingProduction Where OrderId=" & row.OrderId & "And SewingDate='" & row.QCDate & "' And LineId=" & row.LineId & ")", cnn)
            End If

        Next

    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged

        On Error Resume Next
        ' Me.SewingTableQCDetailsBindingSource.Filter = "QCCheckListId in (Select QCCheckListId From QCCheckList Where Name like '%" & SearchTextBox.Text.ToString & "%')"

        Me.SewingTableQCDetailsTableAdapter.FillByNameContain(Me.SewingTableQCDataSet.SewingTableQCDetails, SearchTextBox.Text.ToString)

    End Sub

   
    
    Private Sub SewingTableQCDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SewingTableQCDataGridView.KeyDown

        If e.KeyData = Keys.F10 Then

            If SewingTableQCDataGridView.Columns(SewingTableQCDataGridView.CurrentCell.ColumnIndex).HeaderText = "Program No" Then

                ShowMaster(frmOrderLookup)

                If frmOrderLookup.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    Me.SewingTableQCDataGridView.CurrentCell.Value = frmOrderLookup.OrderId

                End If

            End If

        End If
    End Sub
End Class