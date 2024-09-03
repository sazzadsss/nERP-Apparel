Public Class frmDailyProductionSummery

    Private Sub DailyProductionSummeryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyProductionSummeryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DailyProductionSummeryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DailyProductionSummeryDataSet)

    End Sub

    Private Sub frmDailyProductionSummery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Me.DailyProductionSummeryTableAdapter.Fill(Me.DailyProductionSummeryDataSet.DailyProductionSummery)



        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateTimePicker.Value = StartMonth
        ToDateTimePicker.Value = EndMonth

        Me.DailyProductionSummeryDataSet.DailyProductionSummery.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue

        Try
            Me.DailyProductionSummeryTableAdapter.FillByDateAndBranch(Me.DailyProductionSummeryDataSet.DailyProductionSummery, New System.Nullable(Of Date)(CType(FromDateTimePicker.Text, Date)), New System.Nullable(Of Date)(CType(ToDateTimePicker.Text, Date)), New System.Nullable(Of Long)(CType(BranchComboBox.SelectedValue, Long)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        'Start -------- Check and Set user rights

        If CheckUserRights("Daily Production Summery").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            DailyProductionSummeryBindingNavigatorSaveItem.Enabled = False

        End If

        'End ------- Check and Set user rights


    End Sub

    
    Private Sub GenerateToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateToolStripButton.Click


        For index As Integer = 1 To DailyProductionSummeryBindingSource.Count

            Dim row As DailyProductionSummeryDataSet.DailyProductionSummeryRow
            row = CType(CType(Me.DailyProductionSummeryBindingSource.Current, DataRowView).Row, DailyProductionSummeryDataSet.DailyProductionSummeryRow)
            DateTimePicker1.Text = row.ProductionDay

            row.CuttingQuantity = ReadData("Select Sum(CuttingQuantity) as CuttingQuantity From CuttingProduction Where CuttingDate='" & DateTimePicker1.Text & "' and BranchId=" & row.BranchId, cnn)
            row.CuttingReject = ReadData("Select Sum(RejectQuantity) as RejectQuantity From CuttingProduction Where CuttingDate='" & DateTimePicker1.Text & "' and BranchId=" & row.BranchId, cnn)
            row.CuttingReplace = ReadData("Select Sum(ReplaceQuantity) as ReplaceQuantity From CuttingProduction Where CuttingDate='" & DateTimePicker1.Text & "' and BranchId=" & row.BranchId, cnn)
            row.SewingTarget = ReadData("Select Sum(MMOutput) as SewingTarget From SewingProduction Where SewingDate='" & DateTimePicker1.Text & "' and BranchId=" & row.BranchId, cnn)
            row.SewingQuantity = ReadData("Select Sum(OutputQuantity) as SewingQuantity From SewingProduction Where SewingDate='" & DateTimePicker1.Text & "' and BranchId=" & row.BranchId, cnn)
            row.SewingReject = ReadData("Select Sum(RejectQuantity) as RejectQuantity From SewingProduction Where SewingDate='" & DateTimePicker1.Text & "' and BranchId=" & row.BranchId, cnn)
            row.FinishingQuantity = ReadData("Select Sum(PolyQuantity) as FinishingQuantity From FinishingProduction Where FinishingDate='" & DateTimePicker1.Text & "' and BranchId=" & row.BranchId, cnn)
            row.FinishingReject = ReadData("Select Sum(PrintRejectQuantity+FabricRejectQuantity+SewingRejectQuantity+CutterRejectQuantity) as FinishingReject From FinishingRejection Where FinishingRejectDate='" & DateTimePicker1.Text & "' and BranchId=" & row.BranchId, cnn)



            If DailyProductionSummeryBindingSource.Position + 1 < DailyProductionSummeryBindingSource.Count Then
                DailyProductionSummeryBindingSource.MoveNext()
            Else
                DailyProductionSummeryBindingSource.MoveFirst()
            End If


        Next

    End Sub

    
    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged

        Me.DailyProductionSummeryDataSet.DailyProductionSummery.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue

        Try
            Me.DailyProductionSummeryTableAdapter.FillByDateAndBranch(Me.DailyProductionSummeryDataSet.DailyProductionSummery, New System.Nullable(Of Date)(CType(FromDateTimePicker.Text, Date)), New System.Nullable(Of Date)(CType(ToDateTimePicker.Text, Date)), New System.Nullable(Of Long)(CType(BranchComboBox.SelectedValue, Long)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DailyProductionSummeryBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles DailyProductionSummeryBindingSource.AddingNew


        If DailyProductionSummeryBindingSource.Position > -1 Then

            Dim DefaultProductionDay As Date = DateSerial(Year(Today), Month(Today), DailyProductionSummeryDataGridView.CurrentRow.Index + 1)
            Me.DailyProductionSummeryDataSet.DailyProductionSummery.ProductionDayColumn.DefaultValue = DefaultProductionDay

        Else

            Me.DailyProductionSummeryDataSet.DailyProductionSummery.ProductionDayColumn.DefaultValue = FromDateTimePicker.Text

        End If

    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        With frmDayWiseProduction
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .FromDate = Me.FromDateTimePicker.Text
            .ToDate = Me.ToDateTimePicker.Text
            .Show()

        End With
    End Sub
End Class