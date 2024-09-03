Imports System.Data.SqlClient

Public Class frmActivitiesTemplate
    Dim CopiedATId As Integer = 0
    Private Sub ActivitiesTemplateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivitiesTemplateBindingNavigatorSaveItem.Click

        Save()


    End Sub
    Private Sub Save()
        Try
            Me.Validate()
            Me.ActivitiesTemplateBindingSource.EndEdit()
            Me.ActivitiesTemplateDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ActivitiesTemplateDataSet)

            Me.ActivitiesTemplateLookupTableAdapter.Fill(Me.ActivitiesTemplateLookupDataSet.ActivitiesTemplateLookup, GridLookUpEdit1.EditValue)

            If Me.ActivitiesTemplateBindingSource.Position > -1 Then
                TTLDayRequireTextBox.Text = ReadData("Select Max(ES) From ActivitiesTemplate Where Slack=0 And ActivitiesGroupId=" & Me.GridLookUpEdit1.EditValue, cnn)
                'Dim row As ActivitiesTemplateDataSet.ActivitiesTemplateRow
                'row = CType(CType(Me.ActivitiesTemplateBindingSource.Current, DataRowView).Row, ActivitiesTemplateDataSet.ActivitiesTemplateRow)
                'Me.ActivitiesSuccessorsTableAdapter.Fill(Me.ActivitiesTemplateDataSet.ActivitiesSuccessors, row.ActivitiesTemplateId)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmActivitiesTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)
        Me.ActivitiesGroupTableAdapter.Fill(Me.ActivitiesGroupDataSet.ActivitiesGroup)
        Me.UserTableAdapter.Fill(Me.UserDataSet.User)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.ActivitiesListTableAdapter.Fill(Me.ActivitiesListDataSet.ActivitiesList)
        Me.ActivitiesTemplateDetailsTableAdapter.Fill(Me.ActivitiesTemplateDataSet.ActivitiesTemplateDetails)

        If CheckUserRights("Activities Template").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
            ActivitiesTemplateBindingNavigatorSaveItem.Enabled = False

        ElseIf CheckUserRights("Activities Template").CanDelete = False Then

            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False
            ActivitiesTemplateBindingNavigatorSaveItem.Enabled = True

        End If

    End Sub



    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        On Error Resume Next


        If ActivitiesTemplateBindingSource.Position > -1 Then

            Dim row As ActivitiesTemplateDataSet.ActivitiesTemplateRow
            row = CType(CType(Me.ActivitiesTemplateBindingSource.Current, DataRowView).Row, ActivitiesTemplateDataSet.ActivitiesTemplateRow)

            If row.IsOptimisticTimeNull Then
                row.OptimisticTime = 0
            ElseIf row.IsPessimisticTimeNull Then
                row.PessimisticTime = 0
            ElseIf row.IsMostLiklyTimeNull Then
                row.MostLiklyTime = 0
            End If


            If e.Column.Caption = "Optimistic Time" Then

                If e.Value > 0 AndAlso row.MostLiklyTime > 0 AndAlso row.PessimisticTime > 0 Then

                    If BetaRadioButton.Checked Then
                        row.Duration = (e.Value + 4 * row.MostLiklyTime + row.PessimisticTime) / 6
                        row.Method = "Beta"
                    Else
                        row.Duration = (e.Value + row.MostLiklyTime + row.PessimisticTime) / 3
                        row.Method = "Triangle"
                    End If

                End If

            ElseIf e.Column.Caption = "Most Likely Time" Then

                If row.OptimisticTime > 0 AndAlso e.Value > 0 AndAlso row.PessimisticTime > 0 Then

                    If BetaRadioButton.Checked Then
                        row.Duration = (row.OptimisticTime + 4 * e.Value + row.PessimisticTime) / 6
                        row.Method = "Beta"
                    Else
                        row.Duration = (e.Value + row.MostLiklyTime + row.PessimisticTime) / 3
                        row.Method = "Triangle"
                    End If



                End If

            ElseIf e.Column.Caption = "Pessimistic Time" Then

                If row.OptimisticTime > 0 AndAlso row.MostLiklyTime > 0 AndAlso e.Value > 0 Then

                    If BetaRadioButton.Checked Then
                        row.Duration = (row.OptimisticTime + 4 * row.MostLiklyTime + e.Value) / 6
                        row.Method = "Beta"
                    Else
                        row.Duration = (row.OptimisticTime + row.MostLiklyTime + e.Value) / 3
                        row.Method = "Triangle"
                    End If


                End If

            ElseIf e.Column.Caption = "Activities" Then

                row.AAsign_UserId = ReadIntegerData("Select AAsign_UserId From ActivitiesList Where ActivitiesListId=" & row.ActivitiesListId, cnn)

            End If

        End If

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Me.ActivitiesTemplateLookupTableAdapter.Fill(Me.ActivitiesTemplateLookupDataSet.ActivitiesTemplateLookup, GridLookUpEdit1.EditValue)
        Me.ActivitiesTemplateTableAdapter.FillByActivitiesGroup(Me.ActivitiesTemplateDataSet.ActivitiesTemplate, Me.GridLookUpEdit1.EditValue)
        Me.ActivitiesTemplateDataSet.ActivitiesTemplate.ActivitiesGroupIdColumn.DefaultValue = Me.GridLookUpEdit1.EditValue

    End Sub

    Private Sub CalculateLeftDayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateEarlyButton.Click

        CalculateEarly()
        CalculateLatest()
        ExecuteQuery("Update ActivitiesGroup Set LeadTime=" & Val(TTLDayRequireTextBox.Text) & " Where ActivitiesGroupId=" & GridLookUpEdit1.EditValue, cnn)

    End Sub
    Private Sub CalculateBLatest()


        'Dim i As Integer = 0

        'Do While i <= Me.ActivitiesTemplateBindingSource.Count
        '    Me.ActivitiesTemplateBindingSource.Position = i
        '    i = i + 1


        'Loop


        For Each drv As DataRowView In Me.ActivitiesTemplateBindingSource.List
            Dim Start_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Order Received'", cnn)
            Dim End_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Shipment'", cnn)

            If drv!ActivitiesListId = Start_AID Then

                drv!LS = drv!ES
                drv!LF = drv!EF

            ElseIf drv!ActivitiesListId = End_AID Then

                Dim MaxEF As Decimal = ReadData("Select Max(EF) From ActivitiesTemplate Where ActivitiesGroupId=" & Me.GridLookUpEdit1.EditValue & " And ActivitiesTemplateId in ( Select Predecessors From ActivitiesTemplateDetails Where ActivitiesTemplateId=" & drv!ActivitiesTemplateId & ")", cnn)

                drv!ES = MaxEF + 1
                drv!EF = drv!ES
                drv!LS = drv!ES
                drv!LF = drv!EF

            Else

                Dim MaxLF As Decimal = ReadData("Select Max(LF) From ActivitiesTemplate Where ActivitiesGroupId=" & Me.GridLookUpEdit1.EditValue & " And ActivitiesTemplateId in ( Select Predecessors From ActivitiesTemplateDetails Where ActivitiesTemplateId=" & drv!ActivitiesTemplateId & ")", cnn)
                'MessageBox.Show(drv!SL & "::" & MaxEF.ToString())
                'If MaxEF = 0 Then
                '    drv!ES = MaxEF
                '    drv!EF = drv!ES + drv!Duration
                'Else
                drv!LS = MaxLF + 1
                drv!LF = drv!ES + drv!Duration
                'End If

            End If
            Save()
        Next


    End Sub

    Private Sub CalculateEarly()


        'Dim i As Integer = 0

        'Do While i <= Me.ActivitiesTemplateBindingSource.Count
        '    Me.ActivitiesTemplateBindingSource.Position = i
        '    i = i + 1


        'Loop

        For Each drv As DataRowView In Me.ActivitiesTemplateBindingSource.List
            drv!ES = 1
            drv!EF = 1
            drv!LS = 1
            drv!LF = 1
        Next
        For Each drv As DataRowView In Me.ActivitiesTemplateBindingSource.List
            Dim MaxEF As Decimal = 0
            Dim Start_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Order Received'", cnn)
            Dim End_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Shipment'", cnn)

            If drv!ActivitiesListId = Start_AID Then

                drv!ES = 1
                drv!EF = 1
                drv!LS = 1
                drv!LF = 1

            ElseIf drv!ActivitiesListId = End_AID Then

                MaxEF = ReadData("Select Max(EF) From ActivitiesTemplate Where ActivitiesGroupId=" & Me.GridLookUpEdit1.EditValue & " And ActivitiesTemplateId in ( Select Predecessors From ActivitiesTemplateDetails Where ActivitiesTemplateId=" & drv!ActivitiesTemplateId & ")", cnn)

                drv!ES = MaxEF + 1
                drv!EF = drv!ES
                drv!LS = drv!ES
                drv!LF = drv!EF

            Else

                Dim LeftDay As Integer = ReadIntData("Select LeftDay From ActivitiesTemplate Where ActivitiesGroupId=" & Me.GridLookUpEdit1.EditValue & " And ActivitiesTemplateId=" & drv!ActivitiesTemplateId, cnn)

                If LeftDay = 0 Then

                    MaxEF = ReadData("Select Max(EF) From ActivitiesTemplate Where ActivitiesGroupId=" & Me.GridLookUpEdit1.EditValue & " And ActivitiesTemplateId in ( Select Predecessors From ActivitiesTemplateDetails Where ActivitiesTemplateId=" & drv!ActivitiesTemplateId & ")", cnn)

                    drv!ES = MaxEF + 1
                    drv!EF = drv!ES + drv!Duration - 1


                ElseIf LeftDay > 0 Then

                    Dim MaxES As Decimal = ReadData("Select Max(ES) From ActivitiesTemplate Where ActivitiesGroupId=" & Me.GridLookUpEdit1.EditValue & " And ActivitiesTemplateId in ( Select Predecessors From ActivitiesTemplateDetails Where ActivitiesTemplateId=" & drv!ActivitiesTemplateId & ")", cnn)

                    drv!ES = MaxES + LeftDay
                    drv!EF = drv!ES + drv!Duration - 1


                End If


            End If
            Save()
        Next


    End Sub

    Private Sub CalculateBEarly()

        On Error Resume Next
        Dim BDay As Integer = 0
        Dim i As Integer = Me.ActivitiesTemplateBindingSource.Count

        Do While i <= Me.ActivitiesTemplateBindingSource.Count And i >= 0
            Me.ActivitiesTemplateBindingSource.Position = i
            i = i - 1

            Dim row As ActivitiesTemplateDataSet.ActivitiesTemplateRow
            row = CType(CType(Me.ActivitiesTemplateBindingSource.Current, DataRowView).Row, ActivitiesTemplateDataSet.ActivitiesTemplateRow)

            Dim Start_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Order Received'", cnn)
            Dim End_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Shipment'", cnn)

            If row.ActivitiesListId = End_AID Then

                row.LS = 0
                row.LF = 0
                row.ES = 0
                row.EF = 0

                'ElseIf row.ActivitiesListId = Start_AID Then

                '    row.LS = row.ES
                '    row.LF = row.EF

            Else

                Dim MinEF As Decimal = ReadData("Select Min(ES) From ActivitiesTemplate Where  ActivitiesGroupId=" & GridLookUpEdit1.EditValue & " And ActivitiesTemplateId in ( Select ActivitiesTemplateId From ActivitiesTemplateDetails Where Predecessors =" & row.ActivitiesTemplateId & ")", cnn)
                'MessageBox.Show(i.ToString & "::" & MinLF.ToString())
                'If MinLF > 0 Then
                row.EF = MinEF - 1
                row.ES = row.EF - row.Duration + 1
                row.Slack = row.LF - row.EF


                'End If




            End If

            Save()

        Loop



    End Sub

    Private Sub CalculateLatest()

        On Error Resume Next
        Dim BDay As Integer = 0
        Dim i As Integer = Me.ActivitiesTemplateBindingSource.Count

        Do While i <= Me.ActivitiesTemplateBindingSource.Count And i >= 0
            Me.ActivitiesTemplateBindingSource.Position = i
            i = i - 1

            Dim row As ActivitiesTemplateDataSet.ActivitiesTemplateRow
            row = CType(CType(Me.ActivitiesTemplateBindingSource.Current, DataRowView).Row, ActivitiesTemplateDataSet.ActivitiesTemplateRow)

            Dim Start_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Order Received'", cnn)
            Dim End_AID As Integer = ReadIntegerData("Select ActivitiesListId From ActivitiesList Where Description='Shipment'", cnn)

            If row.ActivitiesListId = End_AID Then

                row.LS = row.ES
                row.LF = row.EF
                BDay = row.EF

            ElseIf row.ActivitiesListId = Start_AID Then

                row.LS = row.ES
                row.LF = row.LF
                row.BDay = BDay - row.EF


            Else

                Dim MinLF As Decimal = ReadData("Select Min(LS) From ActivitiesTemplate Where  ActivitiesGroupId=" & GridLookUpEdit1.EditValue & " And ActivitiesTemplateId in ( Select ActivitiesTemplateId From ActivitiesTemplateDetails Where Predecessors =" & row.ActivitiesTemplateId & ")", cnn)
                'MessageBox.Show(i.ToString & "::" & MinLF.ToString())
                If MinLF > 0 Then
                    row.LF = MinLF - 1
                    row.LS = row.LF - row.Duration + 1
                    row.Slack = row.LF - row.EF
                    row.BDay = BDay - row.EF

                End If

            End If

            Save()

        Loop



    End Sub



    Private Sub PasteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteButton.Click

        If Me.ActivitiesTemplateBindingSource.Position > -1 Then
            Exit Sub
        End If

        Using connection As New SqlConnection(cnn)

            Dim command As New SqlCommand("Select ActivitiesTemplateId,SL,ActivitiesListId,Duration,ES,EF,LS,LF,Slack,AAsign_UserId,DependentTask,LeftDay From ActivitiesTemplate Where ActivitiesGroupId=" & CopiedATId & "ORDER BY SL ASC", connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()

                Dim newRow As ActivitiesTemplateDataSet.ActivitiesTemplateRow = Me.ActivitiesTemplateDataSet.ActivitiesTemplate.NewRow()
                newRow.ActivitiesGroupId = GridLookUpEdit1.EditValue
                newRow.SL = reader("SL")
                newRow.ActivitiesListId = reader("ActivitiesListId")
                newRow.Duration = reader("Duration")
                newRow.ES = reader("ES")
                newRow.EF = reader("EF")
                newRow.LS = reader("LS")
                newRow.LF = reader("LF")
                newRow.DependentTask = reader("DependentTask")
                newRow.Slack = reader("Slack")
                newRow.AAsign_UserId = reader("AAsign_UserId")
                newRow.LeftDay = reader("LeftDay")
                newRow.CopiedActivitiesTemplateId = reader("ActivitiesTemplateId")
                Me.ActivitiesTemplateDataSet.ActivitiesTemplate.Rows.Add(newRow)

            End While

            reader.Close()

        End Using

        Save()


        For Each drv As DataRowView In Me.ActivitiesTemplateBindingSource.List

            Using connection As New SqlConnection(cnn)

                Dim command As New SqlCommand("Select ActivitiesTemplateId,Predecessors From ActivitiesTemplateDetails Where ActivitiesTemplateId=" & drv!CopiedActivitiesTemplateId, connection)
                'MessageBox.Show(drv!CopiedActivitiesTemplateId.ToString())
                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()

                    Dim newRow1 As ActivitiesTemplateDataSet.ActivitiesTemplateDetailsRow = Me.ActivitiesTemplateDataSet.ActivitiesTemplateDetails.NewRow()

                    newRow1.ActivitiesTemplateId = drv!ActivitiesTemplateId
                    If DBNull.Value.Equals(reader("Predecessors")) = False Then
                        newRow1.Predecessors = ReadIntegerData("Select ActivitiesTemplateId From ActivitiesTemplate Where CopiedActivitiesTemplateId=" & reader("Predecessors") & " And ActivitiesGroupId=" & GridLookUpEdit1.EditValue, cnn)

                    End If


                    Me.ActivitiesTemplateDataSet.ActivitiesTemplateDetails.Rows.Add(newRow1)

                End While

                reader.Close()

            End Using

        Next
        Save()
        Me.ActivitiesTemplateLookupTableAdapter.Fill(Me.ActivitiesTemplateLookupDataSet.ActivitiesTemplateLookup, GridLookUpEdit1.EditValue)
        PasteButton.Enabled = False


    End Sub

    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click
        CopiedATId = GridLookUpEdit1.EditValue
        MessageBox.Show(CopiedATId)
        PasteButton.Enabled = True

    End Sub

    Private Sub ActivitiesTemplateBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivitiesTemplateBindingSource.PositionChanged

        On Error Resume Next
        Dim row As ActivitiesTemplateDataSet.ActivitiesTemplateRow
        row = CType(CType(Me.ActivitiesTemplateBindingSource.Current, DataRowView).Row, ActivitiesTemplateDataSet.ActivitiesTemplateRow)

        Me.ActivitiesSuccessorsTableAdapter.Fill(Me.ActivitiesTemplateDataSet.ActivitiesSuccessors, row.ActivitiesTemplateId)

    End Sub

    Private Sub UpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpButton.Click

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = GridView1

        view.GridControl.Focus()

        Dim index As Integer = view.FocusedRowHandle

        If index <= 0 Then Exit Sub



        Dim row1 As DataRow = view.GetDataRow(index)

        Dim row2 As DataRow = view.GetDataRow((index - 1))

        Dim val1 As Object = row1("SL")

        Dim val2 As Object = row2("SL")

        row1("SL") = val2

        row2("SL") = val1

        view.FocusedRowHandle = index - 1

    End Sub

    Private Sub ActivitiesTemplateBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles ActivitiesTemplateBindingSource.AddingNew
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = GridView1
        view.GridControl.Focus()
        Dim index As Integer = view.FocusedRowHandle
        Me.ActivitiesTemplateDataSet.ActivitiesTemplate.SLColumn.DefaultValue = view.DataRowCount + 1
    End Sub

    Private Sub DownButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownButton.Click

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = GridView1
        view.GridControl.Focus()

        Dim index As Integer = view.FocusedRowHandle
        If index >= view.DataRowCount - 1 Then Exit Sub

        Dim row1 As DataRow = view.GetDataRow(index)

        Dim row2 As DataRow = view.GetDataRow((index + 1))

        Dim val1 As Object = row1("SL")

        Dim val2 As Object = row2("SL")

        row1("SL") = val2

        row2("SL") = val1

        view.FocusedRowHandle = index + 1

    End Sub

    Private Sub ShowSuccessorsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowSuccessorsButton.Click

        On Error Resume Next
        Dim row As ActivitiesTemplateDataSet.ActivitiesTemplateRow
        row = CType(CType(Me.ActivitiesTemplateBindingSource.Current, DataRowView).Row, ActivitiesTemplateDataSet.ActivitiesTemplateRow)

        Me.ActivitiesSuccessorsTableAdapter.Fill(Me.ActivitiesTemplateDataSet.ActivitiesSuccessors, row.ActivitiesTemplateId)

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = GridLookUpEdit1.Text
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try

                ActivitiesTemplateGridControl.ExportToXls(objSaveFileDialog.FileName)


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing
    End Sub
End Class