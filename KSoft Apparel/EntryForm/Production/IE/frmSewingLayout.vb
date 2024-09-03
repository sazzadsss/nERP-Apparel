Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class frmSewingLayout

    Dim FACTOR As Double
    WithEvents Evaluator1 As Evaluator
    Dim myStyleId As Integer
    Dim PType As String = "Machine"
    Dim MaxLayoutId As Integer
    Dim rowIndex As Integer
    Private _TotalSMV As Decimal
    Public Property TotalSMV() As Decimal
        Get
            Return _TotalSMV
        End Get
        Set(ByVal value As Decimal)
            _TotalSMV = value
        End Set
    End Property

    Private Sub frmSewingLayout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.StyleLookupTableAdapter.Fill(Me.StyleDataSet.StyleLookup)
        Me.UserTableAdapter.Fill(Me.UserDataSet.User)
        Me.SewingProcessLookupTableAdapter.Fill(Me.SewingProcessLookupDataSet.SewingProcessLookup)
        Me.SewingCategoryTableAdapter.Fill(Me.SewingLayoutDataSet.SewingCategory)
        Me.SewingMachineTableAdapter.Fill(Me.SewingLayoutDataSet.SewingMachine)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        'Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)
        Me.LineTableAdapter.Fill(Me.LineDataSet.Line)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Evaluator1 = New Evaluator

        If CheckUserRights("Sewing Layout").CanEdit = False Then
            SaveButton.Enabled = False
        End If


    End Sub

    Private Sub CloseFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseFormButton.Click

        Me.Close()

    End Sub
    Private Sub UpdateSMVandMC()

        Using Connection As New SqlConnection(cnn)

            Connection.Open()

            ' Create the command with the sproc name and add the parameter required'
            Dim cmd As SqlCommand = New SqlCommand("UpdateStyleSMVAndMC", Connection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@StyleId", StyleLookupGridLookUpEdit.EditValue)

            cmd.ExecuteNonQuery()

        End Using

    End Sub
    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Try

            If SewingLayoutBindingSource.Position > -1 Then

                Dim row As SewingLayoutDataSet.SewingLayoutRow
                row = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)
                row.Modified_By = UserId
                row.Modified_On = Now()

            End If

            Me.Validate()
            Me.SewingLayoutBindingSource.EndEdit()
            Me.SewingSMVBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)



            'StyleLookupGridLookUpEdit.Focus()

            Dim SMVMachine As Decimal = 0
            Dim SMVManual As Decimal = 0



            SMVMachine = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & myStyleId & "and Process_Type='Machine' and AmendmentNo=" & Val(AmendmentNoComboBox.Text), cnn)
            SMVManual = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & myStyleId & "and Process_Type='Manual' and AmendmentNo=" & Val(AmendmentNoComboBox.Text), cnn)

            SMVMachineLabel.Text = FormatNumber(SMVMachine, 2)
            SMVManualLabel.Text = FormatNumber(SMVManual, 2)

            SMVTotalLabel.Text = FormatNumber(SMVMachine + SMVManual, 2)

            Dim MaxAmendmentNo As Integer = ReadIntegerData("Select Max(AmendmentNo) From SewingSMV where StyleId=" & myStyleId, cnn)
            AmendmentNoComboBox.SelectedIndex = MaxAmendmentNo

            UpdateSMVandMC()

            If SewingLayoutBindingSource.Position > -1 Then
                Highlight()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try





    End Sub

    Private Sub LoadLayout()

        myStyleId = StyleLookupGridLookUpEdit.EditValue

        Me.SewingLayoutDataSet.SewingLayout.StyleIdColumn.DefaultValue = myStyleId
        'Me.OrderTableAdapter.Fill(Me.StyleOrderDataSet.Order, myStyleId)
        Me.OrderLookupBySubStyleTableAdapter.FillByStyleId(Me.OrderLookupDataSet.OrderLookupBySubStyle, myStyleId)

        Dim MaxAmendmentNo As Integer = ReadIntegerData("Select Max(AmendmentNo) From SewingSMV where StyleId=" & myStyleId, cnn)
        AmendmentNoComboBox.SelectedIndex = MaxAmendmentNo


        Try

            'Me.SewingProcessTableAdapter.FillByProcessType(Me.SewingLayoutDataSet.SewingProcess, PType)
            'Me.SewingSMVTableAdapter.FillByStyleId(Me.SewingLayoutDataSet.SewingSMV, myStyleId, PType, MaxAmendmentNo)
            Me.SewingSMVTableAdapter.FillBy(Me.SewingLayoutDataSet.SewingSMV, myStyleId, MaxAmendmentNo)
            Me.SewingProcessTableAdapter.Fill(Me.SewingLayoutDataSet.SewingProcess)
            Me.SewingLayoutTableAdapter.FillByStyleId(Me.SewingLayoutDataSet.SewingLayout, myStyleId)

        Catch ex As System.Exception

            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

        Dim SMVMachine As Decimal = 0
        Dim SMVManual As Decimal = 0


        SMVMachine = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & myStyleId & "and Process_Type='Machine'and AmendmentNo=" & Val(AmendmentNoComboBox.Text), cnn)
        SMVManual = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & myStyleId & "and Process_Type='Manual'and AmendmentNo=" & Val(AmendmentNoComboBox.Text), cnn)

        SMVMachineLabel.Text = FormatNumber(SMVMachine, 2)
        SMVManualLabel.Text = FormatNumber(SMVManual, 2)
        SMVTotalLabel.Text = FormatNumber(SMVMachine + SMVManual, 2)

        If SewingLayoutBindingSource.Position > -1 Then
            Highlight()
        End If

    End Sub



    Private Sub SewingLayoutDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SewingLayoutDataGridView.CellClick
        Me.SewingLayoutDataGridView.CurrentRow.Selected = True

    End Sub

    Private Sub SewingLayoutDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SewingLayoutDataGridView.CellDoubleClick

        'If SewingLayoutDataGridView.Columns(Me.SewingLayoutDataGridView.CurrentCell.ColumnIndex).HeaderText = "Targets [PerHour]" Then
        '    If Me.SewingLayoutDataGridView.CurrentRow.Cells(6).Value.ToString <> String.Empty Then
        '        Me.SewingLayoutDataGridView.CurrentCell.Value = Me.SewingLayoutDataGridView.CurrentRow.Cells(6).Value * FACTOR
        '    Else
        '        Me.SewingLayoutDataGridView.CurrentCell.Value = 0
        '    End If

        'End If

    End Sub

    Private Sub SewingLayoutBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles SewingLayoutBindingSource.AddingNew

        If SewingLayoutDataGridView.RowCount > 0 Then

            Dim SMV_MACHINE As Double
            Dim SMV_MANUAL As Double
            Dim MAXTARGET As Double
            Dim MAXMACHINE As Double

            SMV_MACHINE = ReadData("Select ISNULL(Max(TotalSMV_Machine),0) from SewingLayout Where StyleId=" & myStyleId, cnn)
            Me.SewingLayoutDataSet.SewingLayout.TotalSMV_MachineColumn.DefaultValue = SMV_MACHINE

            SMV_MANUAL = ReadData("Select ISNULL(Max(TotalSMV_Manual),0) from SewingLayout Where StyleId=" & myStyleId, cnn)
            Me.SewingLayoutDataSet.SewingLayout.TotalSMV_ManualColumn.DefaultValue = SMV_MANUAL

            MAXTARGET = ReadData("Select ISNULL(Max(TargetsPerHour),0) from SewingLayout Where StyleId=" & myStyleId, cnn)
            MAXMACHINE = ReadData("Select ISNULL(Max(MACHINEQUANTITY),0) from SewingLayout Where StyleId=" & myStyleId, cnn)

            FACTOR = MAXTARGET / MAXMACHINE

        End If



    End Sub

    Private Sub OrderBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderBindingSource.PositionChanged


    End Sub

    Private Sub OrderDataGridView_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles OrderDataGridView.RowHeaderMouseDoubleClick

        If OrderLookupBySubStyleBindingSource.Position > -1 Then



            Dim row As OrderLookupDataSet.OrderLookupBySubStyleRow
            row = CType(CType(Me.OrderLookupBySubStyleBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupBySubStyleRow)

            MaxLayoutId = ReadIntegerData("Select Max(LayoutId) From SewingLayout Where StyleId=" & row.StyleId, cnn)

            Me.SewingLayoutDataSet.SewingLayout.Created_ByColumn.DefaultValue = UserId
            Me.SewingLayoutDataSet.SewingLayout.Created_OnColumn.DefaultValue = Now()
            Me.SewingLayoutDataSet.SewingLayout.OrderIdColumn.DefaultValue = row.OrderId
            Me.SewingLayoutDataSet.SewingLayout.SewingLayoutNoColumn.DefaultValue = ReadStringData("Select ProgramNo From [Order] Where OrderId=" & row.OrderId, cnn) & "/" & (SewingLayoutDataGridView.RowCount + 1)
            Me.SewingLayoutDataSet.SewingLayout.LayoutDateColumn.DefaultValue = Today()
            Me.SewingLayoutDataSet.SewingLayout.MCCostColumn.DefaultValue = ReadData("Select NumberValue From Parameter Where PrameterId=2", cnn)
            Me.SewingLayoutDataSet.SewingLayout.AmendmentNoColumn.DefaultValue = Val(AmendmentNoComboBox.Text)



            SewingLayoutBindingSource.AddNew()

            Try
                Me.Validate()
                Me.SewingLayoutBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If



        If SewingLayoutDataGridView.RowCount > 1 Then


            Dim row As StyleDataSet.StyleRow
            row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleDataSet.StyleRow)

            Me.SewingBreakDownCopyTableAdapter.Fill(Me.SewingLayoutDataSet.SewingBreakDownCopy, MaxLayoutId)


            Dim row1 As SewingLayoutDataSet.SewingLayoutRow
            row1 = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)

            Dim PreAmndNo As Integer = ReadIntegerData("Select AmendmentNo From SewingLayout Where LayoutId=" & MaxLayoutId, cnn)

            If PreAmndNo = row1.AmendmentNo Then

                For Each dr As DataRowView In SewingBreakDownCopyBindingSource.List

                    Dim NewRow As SewingLayoutDataSet.SewingBreakDownRow = Me.SewingLayoutDataSet.SewingBreakDown.NewRow()

                    NewRow.SewingLayoutId = row1.LayoutId
                    NewRow.SewingSMVId = dr!SewingSMVId
                    NewRow.WorkStationQuantity = dr!WorkStationQuantity
                    NewRow.SMV = dr!SMV
                    NewRow.SMV_PerMachine = dr!SMV_PerMachine
                    NewRow.TackTime = dr!TackTime
                    NewRow.LOWER_LEVEL = dr!Lower_Level
                    NewRow.UPPER_LEVEL = dr!Upper_Level
                    NewRow.SLNo = dr!SLNo
                    NewRow.Process_Type = dr!Process_Type
                    NewRow.LayoutTime = 0


                    Me.SewingLayoutDataSet.SewingBreakDown.Rows.Add(NewRow)

                Next

            End If

            Try
                Me.Validate()
                Me.SewingLayoutBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End If


    End Sub


    Private Sub SewingSMVDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SewingSMVDataGridView.CellEndEdit

        Dim Manual As Boolean = ReadBooleanData("Select IsManual from SewingProcess Where SewingProcessId =" & frmSewingProcess.SewingProcessId, cnn)


        If Me.SewingProcessBindingSource.Position > -1 Then

            If SewingSMVDataGridView.Columns(SewingSMVDataGridView.CurrentCell.ColumnIndex).HeaderText = "Process" Then 'Or SewingSMVDataGridView.Columns(SewingSMVDataGridView.CurrentCell.ColumnIndex).HeaderText = "Category" Then

                Dim row As SewingLayoutDataSet.SewingProcessRow
                row = CType(CType(Me.SewingProcessBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingProcessRow)

                'Dim SMIndex As Integer
                'SMIndex = SewingMachineBindingSource.Find("SewingMachineId", row.SewingMachineId)
                'SewingMachineBindingSource.Position = SMIndex

                'SewingSMVDataGridView.CurrentRow.Cells("MC").Value = row.SewingMachineId


                'SewingSMVDataGridView.CurrentRow.Cells("SecIn").Value = row2.SecIN


                Dim row1 As SewingLayoutDataSet.SewingSMVRow
                row1 = CType(CType(Me.SewingSMVBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingSMVRow)

                row1.SewingMachineId = ReadIntegerData("Select SewingMachineId From SewingProcess Where SewingProcessId=" & row1.SewingProcessId, cnn)
                row1.Process_Type = ReadIntegerData("Select Process_Type From SewingProcess Where SewingProcessId=" & row1.SewingProcessId, cnn)
                'Dim row2 As SewingLayoutDataSet.SewingMachineRow
                'row2 = CType(CType(Me.SewingMachineBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingMachineRow)

                row1.SecIn = ReadData("Select SecIn From sewingMachine Where SewingMachineId=" & row1.SewingMachineId, cnn)

                'MsgBox(row2.SecIN)
                'MsgBox(row3.CategoryPercentage)
                'row1.SecIn = row2.SecIN * row3.CategoryPercentage
                'row1.SMV = row1.SecIn * row1.LengthTotal

            End If





            If SewingSMVDataGridView.Columns(SewingSMVDataGridView.CurrentCell.ColumnIndex).HeaderText = "Length Details" Then

                Dim row4 As SewingLayoutDataSet.SewingSMVRow
                row4 = CType(CType(Me.SewingSMVBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingSMVRow)


                If IsDBNull(row4.LengthDetails) = False Then

                    Try

                        Dim res As String = Evaluator1.Eval(row4.LengthDetails).ToString
                        row4.LengthTotal = CType(res, Decimal)

                    Catch ex As Exception

                        MsgBox(ex.Message)

                    End Try



                End If

            End If

            If SewingSMVDataGridView.Columns(SewingSMVDataGridView.CurrentCell.ColumnIndex).HeaderText = "Category" Then



                Dim row4 As SewingLayoutDataSet.SewingSMVRow
                row4 = CType(CType(Me.SewingSMVBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingSMVRow)

                Dim row3 As SewingLayoutDataSet.SewingCategoryRow
                row3 = CType(CType(Me.SewingCategoryBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingCategoryRow)


                Dim MachineSecIn As Decimal = ReadData("Select ISNULL(SecIn,0) From sewingMachine Where SewingMachineId=" & row4.SewingMachineId, cnn)

                row4.SecIn = MachineSecIn * ReadData("Select ISNULL(CategoryPercentage,1) From SewingCategory Where SewingCategoryId=" & row4.SewingCategoryId, cnn)
                row4.SecIn = RoundToValue(row4.SecIn, 0.1, True)

                '==============

                'Dim decimalNumber As Double = row4.SecIn

                'Dim fixnumber As Decimal
                'fixnumber = Math.Round(decimalNumber, 2)
                ''making sure 10.0 will not become 11                
                'If (fixnumber + 0.1) <> decimalNumber + 0.1 Then
                '    fixnumber = fixnumber + 0.1
                'End If
                'row4.SecIn = fixnumber



                '=============



                'If PType = "Machine" Then

                'If Manual = False Then
                '    row4.TTLSecond = RoundToValue(row4.SecIn * row4.LengthTotal, 1, True)
                'End If


                'If row4.TTLSecond < 9 Then
                '        row4.TTLSecond = 9
                '    End If

                '    row4.SMV = row4.TTLSecond / 60
                '    row4.AMS = row4.SMV / 0.85

                '    If row4.SMV = 0 Then

                '        Exit Sub
                '    End If

                '    row4.Capacity = Math.Round(60 / row4.SMV)
                'End If

                If row4.SMV = 0 Then
                        Exit Sub
                    End If

                    row4.Capacity = Math.Round(60 / row4.SMV)

                    'End If

                End If

        End If


    End Sub

    'Private Sub SewingSMVDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SewingSMVDataGridView.CellEnter


    '    If SewingSMVDataGridView.Columns(SewingSMVDataGridView.CurrentCell.ColumnIndex).HeaderText = "Capacity" Then
    '        Dim row4 As SewingLayoutDataSet.SewingSMVRow
    '        row4 = CType(CType(Me.SewingSMVBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingSMVRow)


    '        If PType = "Machine" Then
    '            row4.TTLSecond = (row4.SecIn * row4.LengthTotal)

    '            If row4.TTLSecond < 9 Then
    '                row4.TTLSecond = 9
    '            End If

    '            row4.SMV = row4.TTLSecond / 60
    '            row4.AMS = row4.SMV / 0.85

    '            If row4.SMV = 0 Then

    '                Exit Sub
    '            End If

    '            row4.Capacity = Math.Round(60 / row4.SMV)
    '        End If

    '        If row4.SMV = 0 Then

    '            Exit Sub
    '        End If

    '        row4.Capacity = Math.Round(60 / row4.SMV)
    '    End If

    'End Sub

    Private Sub SewingSMVBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles SewingSMVBindingSource.AddingNew



        SewingLayoutDataSet.SewingSMV.StyleIdColumn.DefaultValue = myStyleId
        SewingLayoutDataSet.SewingSMV.CapacityPercentageColumn.DefaultValue = Me.CapacityPercentageNumericUpDown.Value
        SewingLayoutDataSet.SewingSMV.Process_TypeColumn.DefaultValue = PType
        SewingLayoutDataSet.SewingSMV.SlNoColumn.DefaultValue = SewingSMVDataGridView.RowCount

        If Me.AmendmentNoComboBox.Text = String.Empty Then
            Me.SewingLayoutDataSet.SewingSMV.AmendmentNoColumn.DefaultValue = 0
            Me.SewingLayoutDataSet.SewingLayout.AmendmentNoColumn.DefaultValue = 0
        Else
            Me.SewingLayoutDataSet.SewingSMV.AmendmentNoColumn.DefaultValue = Val(AmendmentNoComboBox.Text)
            Me.SewingLayoutDataSet.SewingLayout.AmendmentNoColumn.DefaultValue = Val(AmendmentNoComboBox.Text)
        End If

        SewingLayoutDataSet.SewingSMV.AmendmentDateColumn.DefaultValue = Today()



    End Sub



    Private Sub MachineRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MachineRadioButton.CheckedChanged, ManualRadioButton.CheckedChanged, AmendmentNoComboBox.SelectedIndexChanged

        If StyleBindingSource.Position > -1 Then


            If MachineRadioButton.Checked = True Then
                PType = "Machine"
            ElseIf ManualRadioButton.Checked = True Then
                PType = "Manual"
            Else
                PType = "All"
            End If

            Dim MaxAmendmentNo As Integer = 0

            MaxAmendmentNo = Val(Me.AmendmentNoComboBox.Text)
            Me.SewingLayoutDataSet.SewingLayout.AmendmentNoColumn.DefaultValue = MaxAmendmentNo
            Me.SewingLayoutDataSet.SewingSMV.AmendmentNoColumn.DefaultValue = MaxAmendmentNo

            'If AmendmentNoComboBox.Focused Then

            '    MaxAmendmentNo = Me.AmendmentNoComboBox.SelectedIndex
            '    Me.SewingLayoutDataSet.SewingLayout.AmendmentNoColumn.DefaultValue = MaxAmendmentNo
            '    Me.SewingLayoutDataSet.SewingSMV.AmendmentNoColumn.DefaultValue = MaxAmendmentNo


            'Else

            '    MaxAmendmentNo = ReadIntegerData("Select Max(AmendmentNo) From SewingSMV where StyleId=" & row.StyleId & " and Process_Type='" & PType & "'", cnn)
            '    AmendmentNoComboBox.SelectedIndex = MaxAmendmentNo
            '    Me.SewingLayoutDataSet.SewingLayout.AmendmentNoColumn.DefaultValue = MaxAmendmentNo
            '    Me.SewingLayoutDataSet.SewingSMV.AmendmentNoColumn.DefaultValue = MaxAmendmentNo

            'End If

            If Me.PType = "All" Then
                Me.SewingSMVTableAdapter.FillBy(Me.SewingLayoutDataSet.SewingSMV, myStyleId, MaxAmendmentNo)
                Me.SewingProcessTableAdapter.Fill(Me.SewingLayoutDataSet.SewingProcess)
            Else
                Me.SewingSMVTableAdapter.FillByStyleId(Me.SewingLayoutDataSet.SewingSMV, myStyleId, PType, MaxAmendmentNo)
                Me.SewingProcessTableAdapter.FillByProcessType(Me.SewingLayoutDataSet.SewingProcess, PType)
            End If




            Dim SMVMachine As Decimal = 0
            Dim SMVManual As Decimal = 0


            SMVMachine = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & myStyleId & "and Process_Type='Machine'and AmendmentNo=" & Val(AmendmentNoComboBox.Text), cnn)
            SMVManual = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & myStyleId & "and Process_Type='Manual'and AmendmentNo=" & Val(AmendmentNoComboBox.Text), cnn)

            SMVMachineLabel.Text = SMVMachine
            SMVManualLabel.Text = SMVManual
            SMVTotalLabel.Text = FormatNumber(SMVMachine + SMVManual, 2)



        End If

    End Sub

    Private Sub TargetCalculatorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TargetCalculatorButton.Click

        Try
            Me.Validate()
            Me.SewingLayoutBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'MachineRadioButton.Checked = True



        If Me.SewingLayoutBindingSource.Position > -1 Then

            '======================




            Dim row3 As SewingLayoutDataSet.SewingLayoutRow
            row3 = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)


            Me.SewingLayoutDataGridView.CurrentRow.Cells("TotalSMV_Machine").Value = FormatNumber(ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & myStyleId & " and Process_Type='Machine' and AmendmentNo=" & row3.AmendmentNo, cnn), 2)
            Me.SewingLayoutDataGridView.CurrentRow.Cells("TotalSMV_Manual").Value = FormatNumber(ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & myStyleId & " and Process_Type='Manual'and AmendmentNo=" & row3.AmendmentNo, cnn), 2)
            Me.SewingLayoutDataGridView.CurrentRow.Cells("MachineQuantity").Value = ReadData("Select Sum(WorkStationQuantity) from SewingBreakDown Where SewingLayoutId=" & row3.LayoutId & "AND Process_Type='Machine'", cnn)



            Try
                Me.Validate()
                Me.SewingLayoutBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            '========================




            Dim row1 As SewingLayoutDataSet.SewingLayoutRow
            row1 = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)

            If row1.IsOrderQuantityNull Then

                MessageBox.Show("Allocation Quantity is require", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf row1.IsMachineQuantityNull Then

                MessageBox.Show("Machine Quantity is require", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                frmSewingTargetAllocation.SewingLayoutId = row1.LayoutId
                frmSewingTargetAllocation.AllocatingQuantity = row1.OrderQuantity
                frmSewingTargetAllocation.SewingSMV = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & myStyleId & " And AmendmentNo=" & row3.AmendmentNo, cnn)

                If row1.MachineQuantity > 0 Then
                    frmSewingTargetAllocation.MachineQuantity = row1.MachineQuantity
                Else
                    MessageBox.Show("Machine Quantity should be greater than 0")
                    Exit Sub

                End If



                'Dim AdditionalQuantity As Integer = 0
                ShowMaster(frmSewingTargetAllocation)

            End If


            If frmSewingTargetAllocation.DialogResult = System.Windows.Forms.DialogResult.OK Then
                'Get Value from dialog

                Dim TotalProduction As Decimal = 0
                Dim DayCount As Integer = 0
                Dim AllocationLayoutTime As Integer = 0


                Dim row As StyleDataSet.StyleRow
                row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleDataSet.StyleRow)


                Dim row2 As SewingLayoutDataSet.SewingLayoutRow
                row2 = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)


                'Me.SewingLayoutDataGridView.CurrentRow.Cells("TotalSMV_Machine").Value = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & row.StyleId & " and Process_Type='Machine' and AmendmentNo=" & row2.AmendmentNo, cnn)
                'Me.SewingLayoutDataGridView.CurrentRow.Cells("TotalSMV_Manual").Value = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & row.StyleId & " and Process_Type='Manual'and AmendmentNo=" & row2.AmendmentNo, cnn)
                'Me.SewingLayoutDataGridView.CurrentRow.Cells("MachineQuantity").Value = ReadIntegerData("Select Sum(WorkStationQuantity) from SewingBreakDown Where SewingLayoutId=" & row2.LayoutId, cnn)

                TotalProduction = ReadData("Select Sum(NormalQuantity) from SewingTargetAllocation Where SewingLayoutId=" & row2.LayoutId, cnn)
                DayCount = ReadIntData("Select Count(DaySerial) from SewingTargetAllocation Where SewingLayoutId=" & row2.LayoutId, cnn)
                AllocationLayoutTime = ReadIntData("Select Max(LayoutTime) from SewingTargetAllocation Where SewingLayoutId=" & row2.LayoutId, cnn)

                If DayCount > 0 Then
                    Me.SewingLayoutDataGridView.CurrentRow.Cells("TargetsPerHour").Value = CInt(TotalProduction / (DayCount * 10 + AllocationLayoutTime))
                    Me.SewingLayoutDataGridView.CurrentRow.Cells("TotalTargetQuantity").Value = CInt(TotalProduction / (DayCount * 10 + AllocationLayoutTime))

                    Me.SewingLayoutDataGridView.CurrentRow.Cells("BonusTargetQuantity").Value = CInt((TotalProduction / DayCount) / 10) * 1.2
                    'Me.SewingLayoutDataGridView.CurrentRow.Cells("AddTargetPerHour").Value = 0
                End If



            End If



        End If


    End Sub


    Private Sub MachineAllocationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MachineAllocationButton.Click

        Try
            Me.Validate()
            Me.SewingLayoutBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SewingLayoutDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        If SewingLayoutBindingSource.Position > -1 Then


            Dim row As SewingLayoutDataSet.SewingLayoutRow
            row = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)

            Me.SewingLayoutDataGridView.CurrentRow.Cells("TotalSMV_Machine").Value = FormatNumber(ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & row.StyleId & " and Process_Type='Machine' and AmendmentNo=" & row.AmendmentNo, cnn), 2)
            Me.SewingLayoutDataGridView.CurrentRow.Cells("TotalSMV_Manual").Value = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & row.StyleId & " and Process_Type='Manual'and AmendmentNo=" & row.AmendmentNo, cnn)



            frmSewingBreakDown.SewingLayoutId = row.LayoutId
            frmSewingBreakDown.StyleId = row.StyleId
            frmSewingBreakDown.AmendmentNo = row.AmendmentNo

            If MachineRadioButton.Checked = True Then
                PType = "Machine"
            ElseIf ManualRadioButton.Checked = True Then
                PType = "Manual"
            Else
                PType = "All"
            End If


            frmSewingBreakDown.PType = PType


            If row.IsTotalSMV_MachineNull = False Or row.TotalSMV_Machine <> 0 Or row.IsPcsPerBundleNull = False Then

                frmSewingBreakDown.MachineSMV = row.TotalSMV_Machine

                frmSewingBreakDown.PcsInBundle = row.PcsPerBundle

                With frmSewingBreakDown
                    .WindowState = FormWindowState.Normal
                    .ShowDialog()
                End With


            End If

            'Get Value from dialog


            If frmSewingBreakDown.DialogResult = System.Windows.Forms.DialogResult.OK Then

                Me.SewingLayoutDataGridView.CurrentRow.Cells("TotalSMV_Machine").Value = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & row.StyleId & " and Process_Type='Machine' and AmendmentNo=" & row.AmendmentNo, cnn)
                Me.SewingLayoutDataGridView.CurrentRow.Cells("TotalSMV_Manual").Value = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & row.StyleId & " and Process_Type='Manual'and AmendmentNo=" & row.AmendmentNo, cnn)
                Me.SewingLayoutDataGridView.CurrentRow.Cells("MachineQuantity").Value = ReadData("Select Sum(WorkStationQuantity) from SewingBreakDown Where SewingLayoutId=" & row.LayoutId & "and Process_Type='Machine'", cnn)
                Me.SewingLayoutDataGridView.CurrentRow.Cells("Helper").Value = ReadData("Select Sum(WorkStationQuantity) from SewingBreakDown Where SewingLayoutId=" & row.LayoutId & "and Process_Type='Manual'", cnn)
                Me.SewingLayoutDataGridView.CurrentRow.Cells("LayoutTime").Value = frmSewingBreakDown.TotaLayoutTime

            End If



        End If

    End Sub

    Private Sub SewingLayoutDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SewingLayoutDataGridView.CellEndEdit

        If SewingLayoutDataGridView.Columns(SewingLayoutDataGridView.CurrentCell.ColumnIndex).HeaderText = "Targets [PerHour]" Then

            Me.SewingLayoutDataGridView.CurrentRow.Cells("TotalTargetQuantity").Value = Me.SewingLayoutDataGridView.CurrentRow.Cells("TargetsPerHour").Value + Me.SewingLayoutDataGridView.CurrentRow.Cells("AddTargetPerHour").Value
            Me.SewingLayoutDataGridView.CurrentRow.Cells("BonusTargetQuantity").Value = (Me.SewingLayoutDataGridView.CurrentRow.Cells("TargetsPerHour").Value + Me.SewingLayoutDataGridView.CurrentRow.Cells("AddTargetPerHour").Value) * 1.2

        End If

        If SewingLayoutDataGridView.Columns(SewingLayoutDataGridView.CurrentCell.ColumnIndex).HeaderText = "Additional Quantity" Then

            Me.SewingLayoutDataGridView.CurrentRow.Cells("TotalTargetQuantity").Value = Me.SewingLayoutDataGridView.CurrentRow.Cells("TargetsPerHour").Value + Me.SewingLayoutDataGridView.CurrentRow.Cells("AddTargetPerHour").Value
            Me.SewingLayoutDataGridView.CurrentRow.Cells("BonusTargetQuantity").Value = (Me.SewingLayoutDataGridView.CurrentRow.Cells("TargetsPerHour").Value + Me.SewingLayoutDataGridView.CurrentRow.Cells("AddTargetPerHour").Value) * 1.2

        End If

        If SewingLayoutDataGridView.Columns(SewingLayoutDataGridView.CurrentCell.ColumnIndex).HeaderText = "Planning No" Then
            Me.SewingLayoutDataGridView.CurrentRow.Cells("OrderQuantity").Value = ReadData("Select PlanningQuantity From Appointments Where AppointmentId=" & Me.SewingLayoutDataGridView.CurrentRow.Cells("AppointmentId").Value, cnn)
        End If

    End Sub

    Private Sub WithoutOrderLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles WithoutOrderLinkLabel.LinkClicked



        SewingLayoutDataSet.SewingLayout.LayoutDateColumn.DefaultValue = Today()
        SewingLayoutDataSet.SewingLayout.OrderIdColumn.DefaultValue = DBNull.Value
        SewingLayoutDataSet.SewingLayout.SewingLayoutNoColumn.DefaultValue = StyleLookupGridLookUpEdit.Text & "/" & (SewingLayoutDataGridView.RowCount + 1)
        SewingLayoutBindingSource.AddNew()


    End Sub


    Private Sub SewingLayoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingLayoutButton.Click

        Dim row As SewingLayoutDataSet.SewingLayoutRow
        row = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)

        frmSewingLayoutDetails.SewingLayoutId = row.LayoutId
        ShowMaster(frmSewingLayoutDetails)
        SewingSMVTableAdapter.FillBy(Me.SewingLayoutDataSet.SewingSMV, row.StyleId, Val(AmendmentNoComboBox.Text))

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        Try
            Dim row As SewingLayoutDataSet.SewingLayoutRow
            row = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)


            With frmSewingLayoutPrint
                .SewingLayoutId = row.LayoutId
                .MIS = False
                .MdiParent = frmMain
                .WindowState = FormWindowState.Maximized
                .Show()
            End With


        Catch ex As Exception

        End Try
    End Sub

    Private Sub SewingSMVDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SewingSMVDataGridView.CellContentClick

    End Sub


    Private Sub CopyLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CopyLinkLabel.LinkClicked



        Me.SewingSMVCopyTableAdapter.Fill(Me.SewingLayoutDataSet.SewingSMVCopy, myStyleId, Val(AmendmentNoComboBox.Text))






    End Sub

    Private Sub PasteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PasteLinkLabel.LinkClicked
        On Error Resume Next


        If SewingSMVBindingSource.Position = -1 Then
            For Each drv As DataRowView In SewingSMVCopyBindingSource.List

                Dim newRow As SewingLayoutDataSet.SewingSMVRow = Me.SewingLayoutDataSet.SewingSMV.NewRow()

                'newRow.SewingSMVId = drv!SewingSMVId
                newRow.StyleId = myStyleId
                newRow.SlNo = drv!SlNo
                newRow.Part = Nothing
                newRow.SewingProcessId = drv!SewingProcessId
                newRow.SewingMachineId = drv!SewingMachineId
                newRow.Capacity = drv!Capacity
                newRow.LengthDetails = drv!LengthDetails
                newRow.LengthTotal = drv!LengthTotal
                newRow.SecIn = drv!SecIn
                newRow.TTLSecond = drv!TTLSecond
                newRow.SMV = drv!SMV
                newRow.AMS = Nothing
                newRow.MAIN_LABEL_ACT = Nothing
                newRow.MAIN_LEBEL_THAI = Nothing
                newRow.MAIN_LEBEL_UNK = Nothing
                newRow.SewingCategoryId = drv!SewingCategoryId
                newRow.Process_Type = drv!Process_Type
                newRow.AmendmentNo = Val(AmendmentNoComboBox.Text)
                newRow.AmendmentDate = Today()
                newRow.CapacityPercentage = drv!CapacityPercentage


                Me.SewingLayoutDataSet.SewingSMV.Rows.Add(newRow)

            Next

            Me.SewingSMVDataGridView.Sort(SewingSMVDataGridView.Columns(0), ListSortDirection.Ascending)

            'Me.SewingSMVTableAdapter.FillByStyleId(Me.SewingLayoutDataSet.SewingSMV, myStyleId, PType, Val(AmendmentNoComboBox.Text))

        End If

    End Sub

    Private Sub SewingSMVDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles SewingSMVDataGridView.DataError

        On Error Resume Next

    End Sub

    Private Sub SewingSMVDataGridView_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SewingSMVDataGridView.Enter



        If AmendmentNoComboBox.Text <> String.Empty Then

            Dim cnt As Integer = ReadIntData("Select Count(*) From SewingLayout Where StyleId=" & myStyleId & "AND AmendmentNo=" & Val(AmendmentNoComboBox.Text), cnn)

            If cnt > 0 Then
                Me.SewingSMVDataGridView.ReadOnly = True
            Else
                Me.SewingSMVDataGridView.ReadOnly = False
            End If
        Else
            Me.SewingSMVDataGridView.ReadOnly = False

        End If

    End Sub





    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        If SewingLayoutBindingSource.Position > -1 Then

            If MessageBox.Show("Data will delete permanently!!! " & vbCrLf & "Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Dim row As SewingLayoutDataSet.SewingLayoutRow
                row = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)

                ExecuteQuery("Delete SewingBreakDown where SewingLayoutId=" & row.LayoutId, cnn)
                ExecuteQuery("Delete SewingTargetAllocation where SewingLayoutId=" & row.LayoutId, cnn)
                ExecuteQuery("Delete SewingLayoutDetails where SewingLayoutId=" & row.LayoutId, cnn)
                ExecuteQuery("Delete SewingLayout Where LayoutId=" & row.LayoutId, cnn)

                Me.SewingLayoutTableAdapter.FillByStyleId(Me.SewingLayoutDataSet.SewingLayout, row.StyleId)

            Else

                Exit Sub

            End If

        End If


    End Sub

    Private Sub SewingSMVDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SewingSMVDataGridView.KeyDown
        If e.KeyCode = Keys.F10 Then

            If SewingSMVDataGridView.Columns(SewingSMVDataGridView.CurrentCell.ColumnIndex).HeaderText = "Process" Then

                frmSewingProcess.StartPosition = FormStartPosition.CenterParent
                frmSewingProcess.ShowDialog()

                If frmSewingProcess.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    Me.SewingProcessTableAdapter.Fill(Me.SewingLayoutDataSet.SewingProcess)
                    Me.SewingSMVDataGridView.CurrentCell.Value = frmSewingProcess.SewingProcessId
                    Me.SewingSMVDataGridView.CurrentRow.Cells(SewingSMVDataGridView.CurrentCell.ColumnIndex + 1).Value = frmSewingProcess.SewingMachineId
                    Me.SewingSMVDataGridView.CurrentRow.Cells(SewingSMVDataGridView.CurrentCell.ColumnIndex + 2).Value = ReadStringData("Select ProcessType From SewingProcess Where SewingProcessId =" & frmSewingProcess.SewingProcessId, cnn)
                    Dim Manual As Boolean = ReadBooleanData("Select IsManual from SewingProcess Where SewingProcessId =" & frmSewingProcess.SewingProcessId, cnn)

                    If Manual = True Then
                        Me.SewingSMVDataGridView.CurrentRow.Cells(SewingSMVDataGridView.CurrentCell.ColumnIndex + 6).Value = ReadData("Select ISNULL(SMV_SEC,0) from SewingProcess Where SewingProcessId =" & frmSewingProcess.SewingProcessId, cnn)
                    End If

                End If

            End If

        End If
    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
    '    Try
    '        Me.SewingMachineProcessListTableAdapter.Fill(Me.SewingMachineProcessListDataSet.SewingMachineProcessList, New System.Nullable(Of Long)(CType(StyleIdToolStripTextBox.Text, Long)), ProcessTypeToolStripTextBox.Text, New System.Nullable(Of Long)(CType(AmendmentNoToolStripTextBox.Text, Long)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        'On Error Resume Next
        Dim row As StyleDataSet.StyleRow
        row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleDataSet.StyleRow)

        Dim row1 As SewingLayoutDataSet.SewingSMVRow
        row1 = CType(CType(Me.SewingSMVBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingSMVRow)


        Me.SewingMachineProcessListTableAdapter.Fill(Me.SewingMachineProcessListDataSet.SewingMachineProcessList, StyleLookupGridLookUpEdit.EditValue, "Machine", row1.AmendmentNo)


    End Sub


    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
    '    Try
    '        Me.SewingBreakDownCopyTableAdapter.Fill(Me.SewingLayoutDataSet.SewingBreakDownCopy, New System.Nullable(Of Long)(CType(SewingLayoutIdToolStripTextBox.Text, Long)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub SewingMachineProcessListDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles SewingMachineProcessListDataGridView.DataError
        On Error Resume Next
    End Sub


    Private Sub OrderDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles OrderDataGridView.DataError
        On Error Resume Next
    End Sub

    Private Sub ExportXLSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportXLSButton.Click

        'Dim xlApp As Excel.Application
        'Dim xlWorkBook As Excel.Workbook
        'Dim xlWorkSheet As Excel.Worksheet
        'Dim misValue As Object = System.Reflection.Missing.Value
        'Dim xlRange As Excel.Range

        'Dim i As Integer
        'Dim j As Integer

        'xlApp = New Excel.ApplicationClass
        'xlWorkBook = xlApp.Workbooks.Add(misValue)
        'xlWorkSheet = xlWorkBook.Sheets("sheet1")

        'With xlWorkSheet
        '    'insert column names
        '    For j = 0 To SewingSMVDataGridView.Columns.Count - 1
        '        .Cells(1, j + 1).value = SewingSMVDataGridView.Columns(j).HeaderText.ToString

        '        xlRange = xlWorkSheet.Range("A1", misValue)
        '        xlRange = xlRange.Resize(1, j + 1)

        '        With xlRange

        '            '.FormulaR1C1 = "MARK LIST"
        '            .Font.Bold = True
        '            .BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)

        '        End With

        '    Next
        '    ''insert the actual data
        '    '.Range("A2").Copy()

        '    For i = 0 To SewingSMVDataGridView.RowCount - 2
        '        For j = 0 To SewingSMVDataGridView.ColumnCount - 1

        '            xlWorkSheet.Cells(i + 2, j + 1) = SewingSMVDataGridView(j, i).FormattedValue.ToString

        '            'xlRange = xlWorkSheet.Range("A" & j + 1, "N" & i + 1)
        '            xlRange = xlWorkSheet.Range("A1", misValue)
        '            xlRange = xlRange.Resize(i + 2, j + 1)

        '            With xlRange

        '                '.FormulaR1C1 = "MARK LIST"
        '                .BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic)

        '            End With


        '        Next
        '    Next



        'End With


        'xlWorkSheet.SaveAs("E:\vbexcel.xlsx")
        'xlWorkBook.Close()
        'xlApp.Quit()

        'releaseObject(xlApp)
        'releaseObject(xlWorkBook)
        'releaseObject(xlWorkSheet)

        'MsgBox("You can find the file E:\vbexcel.xlsx")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged, ProgramNoGridLookUpEdit.Closed
        On Error Resume Next
        StyleLookupGridLookUpEdit.EditValue = ReadIntegerData("Select Top 1 StyleId From [OrderDetails] Where OrderId=" & Me.ProgramNoGridLookUpEdit.EditValue, cnn)
    End Sub

    Private Sub Highlight()

        Dim MaxValue As Decimal = 0

        For Each dr As DataGridViewRow In SewingLayoutDataGridView.Rows

            'If dr.Cells(5).Value = BottleNeck Then
            dr.DefaultCellStyle.BackColor = Color.White
            'End If

            If DBNull.Value.Equals(dr.Cells("AveragePerMachine").Value) = False Then
                If Math.Round(dr.Cells("AveragePerMachine").Value, 0) > MaxValue Then
                    MaxValue = Math.Round(dr.Cells("AveragePerMachine").Value, 0)
                End If
            End If

        Next

        For Each dr As DataGridViewRow In SewingLayoutDataGridView.Rows

            If DBNull.Value.Equals(dr.Cells("AveragePerMachine").Value) = False Then
                If Math.Round(dr.Cells("AveragePerMachine").Value, 0) = MaxValue Then
                    dr.DefaultCellStyle.BackColor = Color.Gold
                End If
            End If

        Next


    End Sub


    Private Sub LoadLayoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadLayoutButton.Click
        LoadLayout()
        StyleTableAdapter.FillByStyleId(Me.StyleDataSet.Style, StyleLookupGridLookUpEdit.EditValue)
    End Sub


    Private Sub ApplyCapPerLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ApplyCapPerLinkLabel.LinkClicked

        If SewingSMVBindingSource.Position > -1 Then

            Dim row As SewingLayoutDataSet.SewingSMVRow
            row = CType(CType(Me.SewingSMVBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingSMVRow)
            row.CapacityPercentage = CapacityPercentageNumericUpDown.Value


        End If

    End Sub

    Private Sub AllRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AllRadioButton.CheckedChanged
        If StyleBindingSource.Position > -1 Then


            If MachineRadioButton.Checked = True Then
                PType = "Machine"
            ElseIf ManualRadioButton.Checked = True Then
                PType = "Manual"
            Else
                PType = "All"
            End If

            Dim MaxAmendmentNo As Integer = 0

            MaxAmendmentNo = Val(Me.AmendmentNoComboBox.Text)
            Me.SewingLayoutDataSet.SewingLayout.AmendmentNoColumn.DefaultValue = MaxAmendmentNo
            Me.SewingLayoutDataSet.SewingSMV.AmendmentNoColumn.DefaultValue = MaxAmendmentNo

            'If AmendmentNoComboBox.Focused Then

            '    MaxAmendmentNo = Me.AmendmentNoComboBox.SelectedIndex
            '    Me.SewingLayoutDataSet.SewingLayout.AmendmentNoColumn.DefaultValue = MaxAmendmentNo
            '    Me.SewingLayoutDataSet.SewingSMV.AmendmentNoColumn.DefaultValue = MaxAmendmentNo


            'Else

            '    MaxAmendmentNo = ReadIntegerData("Select Max(AmendmentNo) From SewingSMV where StyleId=" & row.StyleId & " and Process_Type='" & PType & "'", cnn)
            '    AmendmentNoComboBox.SelectedIndex = MaxAmendmentNo
            '    Me.SewingLayoutDataSet.SewingLayout.AmendmentNoColumn.DefaultValue = MaxAmendmentNo
            '    Me.SewingLayoutDataSet.SewingSMV.AmendmentNoColumn.DefaultValue = MaxAmendmentNo

            'End If



            Me.SewingSMVTableAdapter.FillBy(Me.SewingLayoutDataSet.SewingSMV, myStyleId, MaxAmendmentNo)
            Me.SewingProcessTableAdapter.Fill(Me.SewingLayoutDataSet.SewingProcess)


            Dim SMVMachine As Decimal = 0
            Dim SMVManual As Decimal = 0


            SMVMachine = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & myStyleId & "and Process_Type='Machine'and AmendmentNo=" & Val(AmendmentNoComboBox.Text), cnn)
            SMVManual = ReadData("Select Sum(SMV) from SewingSMV Where StyleId=" & myStyleId & "and Process_Type='Manual'and AmendmentNo=" & Val(AmendmentNoComboBox.Text), cnn)

            SMVMachineLabel.Text = SMVMachine
            SMVManualLabel.Text = SMVManual
            SMVTotalLabel.Text = FormatNumber(SMVMachine + SMVManual, 2)



        End If

    End Sub

    Private Sub UpButton_Click(sender As Object, e As EventArgs) Handles UpButton.Click

        rowIndex = SewingSMVDataGridView.SelectedCells(0).OwningRow.Index

        If rowIndex <= 0 Then Exit Sub

        Dim row1 As DataGridViewRow = SewingSMVDataGridView.Rows(rowIndex)
        Dim row2 As DataGridViewRow = SewingSMVDataGridView.Rows(rowIndex - 1)

        Dim val1 As Integer = row1.Cells(0).Value
        Dim val2 As Integer = row2.Cells(0).Value

        row1.Cells(0).Value = val2
        row2.Cells(0).Value = val1

        SewingSMVDataGridView.Rows(rowIndex - 1).Selected = True
        SewingSMVDataGridView.Rows(rowIndex).Selected = False

        Me.SewingSMVDataGridView.Sort(SewingSMVDataGridView.Columns(0), ListSortDirection.Ascending)
        Me.SewingSMVBindingSource.Position = rowIndex - 1

        Me.SLNumericUpDown.Value = 1

    End Sub

    Private Sub DownButton_Click(sender As Object, e As EventArgs) Handles DownButton.Click

        rowIndex = SewingSMVDataGridView.SelectedCells(0).OwningRow.Index

        If rowIndex >= Me.SewingSMVBindingSource.Count() Then Exit Sub

        Dim row1 As DataGridViewRow = SewingSMVDataGridView.Rows(rowIndex)
        Dim row2 As DataGridViewRow = SewingSMVDataGridView.Rows(rowIndex + 1)

        Dim val1 As Integer = row1.Cells(0).Value
        Dim val2 As Integer = row2.Cells(0).Value

        row1.Cells(0).Value = val2
        row2.Cells(0).Value = val1

        SewingSMVDataGridView.Rows(rowIndex + 1).Selected = True
        SewingSMVDataGridView.Rows(rowIndex).Selected = False

        Me.SewingSMVDataGridView.Sort(SewingSMVDataGridView.Columns(0), ListSortDirection.Ascending)
        Me.SewingSMVBindingSource.Position = rowIndex + 1
        Me.SLNumericUpDown.Value = 1

    End Sub

    Private Sub SplitContainer3_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer3.Panel2.Paint

    End Sub

    Private Sub RegenerateSLButton_Click(sender As Object, e As EventArgs) Handles RegenerateSLButton.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to regenerate ?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim i = 0

            For Each drv As DataRowView In Me.SewingSMVBindingSource.List


                i = i + 1
                drv!SLNo = i


            Next
        End If


    End Sub

    Private Sub SetSLButton_Click(sender As Object, e As EventArgs) Handles SetSLButton.Click

        rowIndex = SewingSMVDataGridView.SelectedCells(0).OwningRow.Index

        Dim row1 As DataGridViewRow = SewingSMVDataGridView.Rows(rowIndex)
        row1.Cells(0).Value = SLNumericUpDown.Value - 1
        row1.Selected = True

        Me.SewingSMVDataGridView.Sort(SewingSMVDataGridView.Columns(0), ListSortDirection.Ascending)

        Dim i = 0

        For Each drv As DataRowView In Me.SewingSMVBindingSource.List
            i = i + 1
            drv!SLNo = i
        Next

        Dim row2 As DataGridViewRow = SewingSMVDataGridView.Rows(SLNumericUpDown.Value - 1)
        row2.Selected = True
        row1.Selected = False
        SLNumericUpDown.Value = 1
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Dim i = 0

        For Each drv As DataRowView In Me.SewingSMVBindingSource.List

            i = i + 1
            If drv!SMV > 0 Then
                drv!Capacity = FormatNumber(60 / drv!SMV, 0)
            End If

        Next
    End Sub

    Private Sub StyleLookupGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles StyleLookupGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim row As SewingLayoutDataSet.SewingLayoutRow
            row = CType(CType(Me.SewingLayoutBindingSource.Current, DataRowView).Row, SewingLayoutDataSet.SewingLayoutRow)


            With frmSewingLayoutTopSheet
                .SewingLayoutId = row.LayoutId
                .MIS = False
                .MdiParent = frmMain
                .WindowState = FormWindowState.Maximized
                .Show()
            End With


        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class