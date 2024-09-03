Imports System.Data
Imports System.Data.SqlClient

Public Class frmPrintingMachineStoppage

    Private Sub frmPrintingMachineStoppage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PrintMachineStoppageReasonTableAdapter.Fill(Me.PrintMachineStoppageReasonDataSet.PrintMachineStoppageReason)

        Me.PrintMachineStoppageDetailsTableAdapter.Fill(Me.PrintingMachineStoppageDataSet.PrintMachineStoppageDetails)

        Me.PrintMachineStoppageTableAdapter.Fill(Me.PrintingMachineStoppageDataSet.PrintMachineStoppage)


        DateTimePicker1.Focus()

        '==============

        'Dim connection As New SqlConnection(cnn)
        'connection.Open()

        'Dim cmd As SqlCommand = New SqlCommand("Select Distinct Resason From DyeingMachineStoppageDetails", connection)
        'Dim reader As SqlDataReader = cmd.ExecuteReader()
        'Dim list As New AutoCompleteStringCollection

        'While reader.Read

        '    If reader.IsDBNull(0) = False Then

        '        list.Add(reader.Item("Resason"))

        '    End If

        'End While

        'reader.Close()


        'ResasonTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'ResasonTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        'ResasonTextBox.AutoCompleteCustomSource = list

        'connection.Close()


        ''========================

        Me.PrintMachineStoppageTableAdapter.FillByStoppageDate(Me.PrintingMachineStoppageDataSet.PrintMachineStoppage, DateTimePicker1.Text)


        If PrintMachineStoppageBindingSource.Position = -1 Then


            Dim connection As New SqlConnection(cnn)
            connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("Select Line From Line Where BranchId=(Select BranchId From Branch Where BranchCode='PRNT')", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()


            While reader.Read()

                Dim newRow As PrintingMachineStoppageDataSet.PrintMachineStoppageRow = Me.PrintingMachineStoppageDataSet.PrintMachineStoppage.NewRow()

                newRow.MachineNo = reader("Line").ToString
                newRow.StoppageDate = Me.DateTimePicker1.Text
                newRow.TotalStopage = 0
                newRow.TotalStopage_String = "0"
                Me.PrintingMachineStoppageDataSet.PrintMachineStoppage.Rows.Add(newRow)


            End While


            reader.Close()
            connection.Close()


        End If
        '=====================================

    End Sub



    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        If PrintMachineStoppageBindingSource.Position > -1 Then

            Dim rowcnt As Integer = Me.PrintMachineStoppageDataGridView.RowCount()
            Me.PrintingMachineStoppageDataSet.PrintMachineStoppageDetails.SlNoColumn.DefaultValue = rowcnt + 1

            Me.PrintMachineStoppageBindingSource.AddNew()

            FromTimeDateEdit.Focus()


        End If
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        'If ToTimeDateEdit.Text <> String.Empty And FromTimeDateEdit.Text <> String.Empty Then

        '    Dim TTLHour As Decimal = FormatNumber(ToTimeDateEdit.DateTime.Subtract(FromTimeDateEdit.DateTime).TotalHours, 2)

        '    Me.TotalsSpinEdit.Text = FormatNumber(TTLHour, 2)
        '    Me.Total_StringTextEdit.Text = DecToTime(TTLHour)

        'End If


        Me.Validate()
        Me.PrintMachineStoppageBindingSource.EndEdit()
        Me.PrintMachineStoppageDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrintingMachineStoppageDataSet)


        CalculateSummary()



        Me.Validate()
        Me.PrintMachineStoppageBindingSource.EndEdit()
        Me.PrintMachineStoppageBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrintingMachineStoppageDataSet)

        MessageBox.Show("Saved Succesfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        AddButton.Focus()

    End Sub

    Private Sub PrintMachineStoppageDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PrintMachineStoppageDataGridView.CellClick
        Me.PrintMachineStoppageDataGridView.CurrentRow.Selected = True
    End Sub

    Private Sub PrintMachineStoppageDetailsDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PrintMachineStoppageDetailsDataGridView.CellClick
        Me.PrintMachineStoppageDataGridView.CurrentRow.Selected = True
    End Sub


    Sub CalculateSummary()
        '=====
        Dim TTLHour As Decimal = 0
        Dim TTLLoss As Decimal = 0
        If PrintMachineStoppageDetailsBindingSource.Position > -1 Then



            For Each drv As DataRowView In PrintMachineStoppageDetailsBindingSource.List
                If DBNull.Value.Equals(TTLHour) = True Then
                    TTLHour = TTLHour + 0
                    TTLLoss = TTLLoss + 0

                Else
                    If DBNull.Value.Equals(drv!StoppageReasonId) = False Then

                        Dim IsLoss As Boolean = ReadBooleanData("Select IsLoss From PrintMachineStoppageReason Where StoppageReasonId = " & drv!StoppageReasonId, cnn)

                        If IsLoss = True Then
                            TTLLoss = TTLLoss + drv!Totals
                        Else

                            TTLHour = TTLHour + drv!Totals
                        End If

                    End If
                End If

            Next

            GTLabel.Text = DecToTime(TTLHour)
            LossHourLabel.Text = DecToTime(TTLLoss)

        End If

        '======
        If PrintMachineStoppageBindingSource.Position > -1 Then


            Dim row As PrintingMachineStoppageDataSet.PrintMachineStoppageRow
            row = CType(CType(Me.PrintMachineStoppageBindingSource.Current, DataRowView).Row, PrintingMachineStoppageDataSet.PrintMachineStoppageRow)

            row.TotalStopage = TTLHour
            row.TotalStopage_String = DecToTime(TTLHour)
            row.LossHour = TTLLoss
            row.LossHour_String = DecToTime(TTLLoss)
            row.Efficiency = FormatNumber((24 - TTLHour) / 24, 2)


            Dim TTLHour2 As Decimal = 0
            Dim TTLLoss2 As Decimal = 0

            For Each drv As DataRowView In PrintMachineStoppageBindingSource.List


                TTLHour2 = TTLHour2 + drv!TotalStopage
                If DBNull.Value.Equals(drv!LossHour) = False Then
                    TTLLoss2 = TTLLoss2 + drv!LossHour
                End If

            Next

            TTLHourLabel2.Text = DecToTime(TTLHour2)

            Dim Eff As Decimal = FormatNumber(((24 * 14) - TTLLoss2 - TTLHour2) / ((24 * 14) - TTLLoss2) * 100, 2)

            EfficiencyLabel.Text = Eff.ToString & "%"


        End If




    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        Me.PrintMachineStoppageTableAdapter.FillByStoppageDate(Me.PrintingMachineStoppageDataSet.PrintMachineStoppage, DateTimePicker1.Text)

        If PrintMachineStoppageBindingSource.Position = -1 Then


            Dim MCNO(1) As String

            MCNO(0) = "M1"
            MCNO(1) = "M2"

            For i As Integer = 0 To 1

                Dim newRow As PrintingMachineStoppageDataSet.PrintMachineStoppageRow = Me.PrintingMachineStoppageDataSet.PrintMachineStoppage.NewRow()

                newRow.MachineNo = MCNO(i).ToString
                newRow.StoppageDate = Me.DateTimePicker1.Text
                newRow.TotalStopage = 0
                newRow.TotalStopage_String = "0"

                Me.PrintingMachineStoppageDataSet.PrintMachineStoppage.Rows.Add(newRow)


            Next


        End If

    End Sub
End Class