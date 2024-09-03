Imports System.Data.SqlClient

Public Class frmFabricBooking_Sample
    Dim Revisedflag As Boolean = False


    Private Sub SampleFabricBookingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click

        If IsReceivedCheckBox.Checked = True Then
            MessageBox.Show("Not allowed to edit because already received by Fabric Department " & vbNewLine & "Please, Use amendment to edit.")
            Exit Sub
        End If

        If EditToolStripButton.Text = "Edit" Then

            If Me.SampleFabricBookingBindingSource.Position = -1 Then
                Exit Sub
            End If
            If IsReceivedCheckBox.Checked = False Then

                Dim row As SampleFabricBookingDataSet.SampleFabricBookingRow
                row = CType(CType(Me.SampleFabricBookingBindingSource.Current, DataRowView).Row, SampleFabricBookingDataSet.SampleFabricBookingRow)

                'row.FabricBookingDate = Now()


            End If

            EditToolStripButton.Text = "Update"
            EditToolStripButton.Image = KSoft_Apparel.My.Resources.Resources.Save

        ElseIf EditToolStripButton.Text = "Update" Then

            If CauseOfRevisedTextEdit.Text = String.Empty AndAlso RevisedNoNumericUpDown.Value > 0 Then
                MessageBox.Show("Please, mention the cause of revised.")
                Exit Sub
            End If

            If CType(RevisedDateDateTimePicker.Text, Date) > CType(FabricRequireDateDateTimePicker.Text, Date) AndAlso RevisedNoNumericUpDown.Value > 0 Then
                MessageBox.Show("Require date should not less than Revised Date.")
                Exit Sub
            End If

            Save()



            If SampleFabricBindingSource.Position = -1 Then

                Dim connection As New SqlConnection(cnn)
                connection.Open()

                Dim sqlstring As String = "Select * From SampleRequestFinalDetails Where SampleRequestId=" & SampleRequestIdGridLookUpEdit.EditValue
                Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
                Dim reader As SqlDataReader = cmd.ExecuteReader()


                While reader.Read()

                    Dim newRow As SampleFabricBookingDataSet.SampleFabricRow = Me.SampleFabricBookingDataSet.SampleFabric.NewRow()
                    'On Error Resume Next
                    newRow.SampleRequestId = reader("SampleRequestId")
                    newRow.KnittingTypeId = reader("KnittingTypeId")
                    newRow.CompositionId = reader("CompositionId")
                    newRow.FGSM = reader("GSM")
                    newRow.FabricColorName = ReadStringData("Select FabricColorName From FabricColor Where FabricColorId=" & reader("FabricColorId"), cnn)
                    If IsDBNull(reader("ELD")) = False Then
                        newRow.ELD = reader("ELD")
                    End If

                    newRow.IsFabricAvailable = reader("IsFabricAvailable")
                    'newRow.MainFabric = True
                    If IsDBNull(reader("Remarks")) = False Then
                        newRow.Remarks = reader("Remarks")
                    End If

                    Me.SampleFabricBookingDataSet.SampleFabric.Rows.Add(newRow)

                End While




                reader.Close()
                connection.Close()
                'Me.SampleFabricTableAdapter.Fill(Me.SampleFabricBookingDataSet.SampleFabric, SampleRequestIdGridLookUpEdit.EditValue)

            End If
            Me.SampleFabricTableAdapter.Fill(Me.SampleFabricBookingDataSet.SampleFabric, SampleRequestIdGridLookUpEdit.EditValue)

            EditToolStripButton.Text = "Edit"
            EditToolStripButton.Image = KSoft_Apparel.My.Resources.Resources.Edit
            BindingNavigatorAddNewItem.Enabled = True
            SampleRequestIdGridLookUpEdit.Properties.ReadOnly = True


        End If

    End Sub
    Private Sub Save()

        Try

            If IsReceivedCheckBox.Checked = False Then

                Me.Validate()
                Me.SampleFabricBookingBindingSource.EndEdit()
                Me.SampleFabricBindingSource.EndEdit()
                Me.SampleFabricBookingRevisedHistoryBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SampleFabricBookingDataSet)

                Me.SampleRequestIdGridLookUpEdit.Properties.ReadOnly = True

            Else
                MessageBox.Show("Already received by Fabric Department.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub frmFabricBooking_Sample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

        Me.SFBLookupByDivUserTableAdapter.Fill(Me.SampleFabricBookingLookupDataSet.SFBLookupByDivUser, UserId)
        Me.SRLookupByDivUserTableAdapter.Fill(Me.SampleRequestLookupDataSet.SRLookupByDivUser, UserId)
        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)
        Me.YarnAllocationSampleTableAdapter.Fill(Me.SampleFabricBookingDataSet.YarnAllocationSample)

        Me.SampleFabricBookingRevisedHistoryTableAdapter.Fill(Me.SampleFabricBookingDataSet.SampleFabricBookingRevisedHistory)
        Me.SampleRequestNoLookupTableAdapter.Fill(Me.SampleRequestDataSet.SampleRequestNoLookup)
        Me.SampleFabricBookingLookupTableAdapter.Fill(Me.SampleFabricBookingLookupDataSet.SampleFabricBookingLookup)
        Me.SampleFabricBookingDataSet.SampleFabricBooking.UserIdColumn.DefaultValue = UserId
        Me.SampleFabricBookingDataSet.SampleFabricBooking.ModifiedOnColumn.DefaultValue = Now()
        Me.CompositionTableAdapter.FillByContinueItem(Me.CompositionDataSet.Composition)
        Me.KnittingTypeTableAdapter.FillByContinueItem(Me.KnittingTypeDataSet.KnittingType)
        Me.GarmentsPartTableAdapter.Fill(Me.GarmentsPartDataSet.GarmentsPart)
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, YarnStoreId)

    End Sub




    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click

        If SampleFabricBookingBindingSource.Position > -1 Then

            Dim row As SampleFabricBookingDataSet.SampleFabricBookingRow
            row = CType(CType(Me.SampleFabricBookingBindingSource.Current, DataRowView).Row, SampleFabricBookingDataSet.SampleFabricBookingRow)

            With frmSampleFabricBookingPrint

                .BookingNo = row.BookingNo
                .MdiParent = frmMain
                .WindowState = FormWindowState.Maximized
                .Show()

            End With

            Me.Close()


        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        'With Me.SampleFabricBookingDataSet.SampleFabricBooking
        '    .FabricBookingDateColumn.DefaultValue = Now()
        '    .RevisedNoColumn.DefaultValue = 0
        'End With
        'Me.SampleFabricBookingBindingSource.AddNew()

        'Dim DT As Date = ReadDateData("Select GetDate()", cnn)
        'Dim NewOrder As String = ""
        'Dim ABC As String = "SFB" & DT.Year.ToString.Substring(2)
        'Dim XYZ As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(BookingNo),0,CHARINDEX('-',REVERSE(BookingNo))))) From SampleFabricBooking Where BookingNo Like '" & ABC & "%'", cnn)

        'NewOrder = "SFB" & DT.Year.ToString.Substring(2) & "-" & (Val(XYZ) + 1).ToString("0000")
        'Me.BookingNoTextBox.Text = NewOrder
        If BindingNavigatorAddNewItem.Text = "Add" Then
            SampleRequestIdGridLookUpEdit.Properties.ReadOnly = False

            With Me.SampleFabricBookingDataSet.SampleFabricBooking
                .FabricBookingDateColumn.DefaultValue = Now()
                .RevisedNoColumn.DefaultValue = 0
                .CompletedOnColumn.DefaultValue = Now()
            End With

            Me.SampleFabricBookingBindingSource.AddNew()
            Me.SampleRequestIdGridLookUpEdit.Properties.ReadOnly = False
            Me.SampleRequestIdGridLookUpEdit.Focus()
            'Dim DT As Date = ReadDateData("Select GetDate()", cnn)
            'Dim NewOrder As String = ""
            'Dim ABC As String = "SFB" & DT.Year.ToString.Substring(2)
            'Dim XYZ As String = ReadStringData("Select Max(REVERSE(SUBSTRING(REVERSE(BookingNo),0,CHARINDEX('-',REVERSE(BookingNo))))) From SampleFabricBooking Where BookingNo Like '" & ABC & "%'", cnn)

            'NewOrder = "SFB" & DT.Year.ToString.Substring(2) & "-" & (Val(XYZ) + 1).ToString("0000")
            'Me.BookingNoTextBox.Text = NewOrder
            BindingNavigatorAddNewItem.Enabled = False
            EditToolStripButton.Text = "Update"
            EditToolStripButton.Enabled = True
            EditToolStripButton.Image = KSoft_Apparel.My.Resources.Resources.Save
            Me.SampleFabricBookingDataSet.SampleFabricBooking.CompletedOnColumn.DefaultValue = ReadDateData("Select GetDate()", cnn)
            BindingNavigatorAddNewItem.Enabled = False

        End If
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        If Me.SampleFabricBookingBindingSource.Position = -1 Then
            Exit Sub
        End If
        If e.Column.Caption = "Is Complete" Then

            Dim row As SampleFabricBookingDataSet.SampleFabricBookingRow
            row = CType(CType(Me.SampleFabricBookingBindingSource.Current, DataRowView).Row, SampleFabricBookingDataSet.SampleFabricBookingRow)

            row.FabricBookingDate = Now()

        End If

    End Sub

    Function FDStatus() As Boolean

        Dim FD As Boolean = False

        Dim FFBCount As Integer = ReadIntData("Select COUNT(ProgramNo) From FinishFabricBooking Where IsDevelopment =1 and ProgramNo='" & BookingNoTextBox.Text & "' And AmendmentNo=" & RevisedNoNumericUpDown.Value, cnn)

        If FFBCount = 1 Then
            FD = True
        Else
            FD = False
        End If

        Return FD

    End Function

    Private Sub BookingNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingNoTextBox.TextChanged

        IsReceivedCheckBox.Checked = FDStatus()

        'If IsReceivedCheckBox.Checked = False Then
        '    SampleFabricBookingBindingNavigatorSaveItem.Enabled = True
        'Else
        '    SampleFabricBookingBindingNavigatorSaveItem.Enabled = False
        'End If

    End Sub

    Private Sub IsCompleteCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsCompleteCheckBox.CheckedChanged


        If RevisedNoNumericUpDown.Value = 0 Then
            Me.FabricBookingDateDateTimePicker.Text = ReadDateData("Select GetDate()", cnn)
        Else
            Me.RevisedDateDateTimePicker.Text = ReadDateData("Select GetDate()", cnn)
        End If

        CompletedByGridLookUpEdit.EditValue = UserId

    End Sub

    Private Sub RevisedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevisedButton.Click

        Revisedflag = True

        If Me.RevisedNoNumericUpDown.Value > 0 Then

            Dim newRow As SampleFabricBookingDataSet.SampleFabricBookingRevisedHistoryRow = Me.SampleFabricBookingDataSet.SampleFabricBookingRevisedHistory.NewRow()

            Dim row As SampleFabricBookingDataSet.SampleFabricBookingRow
            row = CType(CType(Me.SampleFabricBookingBindingSource.Current, DataRowView).Row, SampleFabricBookingDataSet.SampleFabricBookingRow)

            newRow.SampleFabricBookingId = row.SampleFabricBookingId
            newRow.RevisedNo = RevisedNoNumericUpDown.Value
            newRow.RevisedDate = RevisedDateDateTimePicker.Text
            newRow.CasuseOfRevised = CauseOfRevisedTextEdit.Text

            Me.SampleFabricBookingDataSet.SampleFabricBookingRevisedHistory.Rows.Add(newRow)


            Me.RevisedNoNumericUpDown.Value = RevisedNoNumericUpDown.Value + 1
            Me.RevisedDateDateTimePicker.Text = Now()


        Else

            Me.RevisedNoNumericUpDown.Value = RevisedNoNumericUpDown.Value + 1
            Me.RevisedDateDateTimePicker.Text = Now()
            IsReceivedCheckBox.Checked = False


        End If

        IsCompleteCheckBox.Checked = False
        IsCompleteCheckBox.Enabled = True
        IsReceivedCheckBox.Checked = False

        EditToolStripButton.Enabled = True
        Revisedflag = False

    End Sub

    Private Sub IsReceivedCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IsReceivedCheckBox.CheckedChanged

        If Revisedflag = False Then

            If IsReceivedCheckBox.Checked = False Then
                EditToolStripButton.Enabled = True
                IsCompleteCheckBox.Enabled = True
                'SampleFabricGridControl.Enabled = True
                'YarnAllocationSampleGridControl.Enabled = True
            Else
                EditToolStripButton.Enabled = False
                IsCompleteCheckBox.Enabled = False
                'SampleFabricGridControl.Enabled = False
                'YarnAllocationSampleGridControl.Enabled = False

            End If

        End If



    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        Me.SampleFabricBookingTableAdapter.FillBySampleFabricBookingId(Me.SampleFabricBookingDataSet.SampleFabricBooking, Me.GridLookUpEdit1.EditValue)
        Me.SampleFabricTableAdapter.Fill(Me.SampleFabricBookingDataSet.SampleFabric, SampleRequestIdGridLookUpEdit.EditValue)
    End Sub

    Private Sub SampleFabricGridControl_Click(sender As Object, e As EventArgs) Handles SampleFabricGridControl.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        If Me.SampleFabricBindingSource.Position = -1 Then
            If Me.BindingNavigatorDeleteItem.Text = "Delete" Then
                Me.SampleFabricBookingBindingSource.RemoveCurrent()
                Me.BindingNavigatorDeleteItem.Text = "Update"
            Else
                Save()
                Me.SFBLookupByDivUserTableAdapter.Fill(Me.SampleFabricBookingLookupDataSet.SFBLookupByDivUser, UserId)
                Me.BindingNavigatorDeleteItem.Text = "Delete"

            End If
        End If

    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles GridLookUpEdit1.EditValueChanged

    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click

        BindingNavigatorAddNewItem.Enabled = True
        EditToolStripButton.Enabled = False
        EditToolStripButton.Text = "Edit"
        BindingNavigatorDeleteItem.Text = "Delete"
        SampleFabricBookingBindingSource.ResetBindings(True)

    End Sub

    Private Sub CopyFabricButton_Click(sender As Object, e As EventArgs) Handles CopyFabricButton.Click

        If Me.SampleFabricBindingSource.Position > -1 Then

            Dim row As SampleFabricBookingDataSet.SampleFabricRow
            row = CType(CType(Me.SampleFabricBindingSource.Current, DataRowView).Row, SampleFabricBookingDataSet.SampleFabricRow)


            Dim newRow As SampleFabricBookingDataSet.SampleFabricRow = Me.SampleFabricBookingDataSet.SampleFabric.NewRow()

            On Error Resume Next

            newRow.SampleRequestId = row.SampleRequestId
            newRow.FabricColorName = row.FabricColorName
            newRow.ELD = row.ELD
            newRow.GarmentsPartId = row.GarmentsPartId
            newRow.KnittingTypeId = row.KnittingTypeId
            newRow.CompositionId = row.CompositionId
            newRow.FGSM = row.FGSM
            newRow.Dia = row.Dia
            newRow.DiaType = row.DiaType
            newRow.FinishUnit = row.FinishUnit
            newRow.BookingQuantity = row.BookingQuantity
            newRow.Remarks = row.Remarks
            If row.IsSPNoteNull = True Then
                newRow.SPNote = "-"
            Else
                newRow.SPNote = row.SPNote
            End If

            'newRow.IsDelivered = row.IsDelivered
            'newRow.DeliveredDate = row.DeliveredDate
            'newRow.Priority = row.Priority
            'newRow.PrintSend = row.PrintSend
            'newRow.PrintReceived = row.PrintReceived
            'newRow.Status = row.Status
            'newRow.IsImportant = row.IsImportant
            'newRow.MainFabric = row.MainFabric
            newRow.GreyPercentage = row.GreyPercentage
            newRow.GreyQuantity = row.GreyQuantity
            newRow.Length = row.Length
            newRow.KgPerUnit = row.KgPerUnit
            newRow.Consumption = row.Consumption
            newRow.DUnit = row.DUnit


            Me.SampleFabricBookingDataSet.SampleFabric.Rows.Add(newRow)


        End If

    End Sub

    Private Sub frmFabricBooking_Sample_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F11 Then

            If SampleFabricGridControl.IsFocused Then

                If SampleFabricGridView.FocusedColumn.AbsoluteIndex = colFabricColorName.AbsoluteIndex Then

                    frmFabricColor.ShowDialog()

                    If frmFabricColor.DialogResult = System.Windows.Forms.DialogResult.OK Then

                        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

                        Dim row As SampleFabricBookingDataSet.SampleFabricRow
                        row = CType(CType(Me.SampleFabricBindingSource.Current, DataRowView).Row, SampleFabricBookingDataSet.SampleFabricRow)

                        row.FabricColorName = ReadStringData("Select FabricColorName From FabricColor Where FabricColorId=" & frmFabricColor.FabricColorId, cnn)

                        SampleFabricBindingSource.ResetBindings(True)

                    End If


                End If


            End If

        End If
    End Sub

    Private Sub SampleFabricGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles SampleFabricGridView.CellValueChanged

        If e.Column.Caption = "Grey Percentage" OrElse e.Column.Caption = "Booking Quantity" Then
            Dim row As SampleFabricBookingDataSet.SampleFabricRow
            row = CType(CType(Me.SampleFabricBindingSource.Current, DataRowView).Row, SampleFabricBookingDataSet.SampleFabricRow)

            If row.GreyPercentage >= 0 And row.BookingQuantity > 0 Then
                row.GreyQuantity = row.BookingQuantity * (1 + row.GreyPercentage / 100)
                SampleFabricBindingSource.ResetBindings(True)
            End If

        End If

    End Sub

    Private Sub SampleRequestIdGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles SampleRequestIdGridLookUpEdit.EditValueChanged

        On Error Resume Next
        BookingNoTextBox.Text = ReadStringData("Select RequestNo From SampleRequestFinal Where SampleRequestId=" & SampleRequestIdGridLookUpEdit.EditValue, cnn)

    End Sub
End Class