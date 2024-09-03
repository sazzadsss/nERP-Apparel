Imports System.Data.SqlClient
Imports System.Data
Imports DevExpress.XtraSplashScreen

Public Class frmSewingProduction
    Dim HourSerial As Integer
    Dim LastHourSerial As Integer
    Dim LHS As Boolean
    Dim CHP As Integer = 0 'Current Hour Production
    Private _ByUserFlag As Boolean
    Public Property ByUserFlag() As Boolean
        Get
            Return _ByUserFlag
        End Get
        Set(ByVal value As Boolean)
            _ByUserFlag = value
        End Set
    End Property
    Dim chkInput As Boolean = False

    Private Sub SewingProductionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.SewingProductionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingProductionDataSet)

    End Sub





    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        SewingProductionDataSet.SewingProduction.SewingDateColumn.DefaultValue = DateTimePicker1.Text
        Me.LineTableAdapter.FillByBranchId(Me.LineDataSet.Line, BranchComboBox.SelectedValue)
        If ByUserFlag = False Then
            Me.SewingProductionTableAdapter.FillByDateWise(Me.SewingProductionDataSet.SewingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text)
        Else
            Me.SewingProductionTableAdapter.FillByDateAndBranchAndUserId(Me.SewingProductionDataSet.SewingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text, UserId)
        End If


        RefreshSummery()
        On Error Resume Next
        TTLHourlyOutput.Text = ReadData("Select Sum(H1+H2+H3+H4+H5+H6+H7+H8+H9+H10+H11+H12+HX) as TTLOutput From vSewingHourlyProduction Where SewingDate='" & DateTimePicker1.Text & "' and BranchId=" & BranchComboBox.SelectedValue, cnn)

    End Sub

    Private Sub SewingProductionDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SewingProductionDataGridView.CellClick

        'On Error Resume Next
        'Me.SewingProductionDataGridView.CurrentRow.Selected = True

        'If Me.SewingProductionBindingSource.Position > -1 Then

        '    Dim row As SewingProductionDataSet.SewingProductionRow
        '    row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

        '    Me.OrderPOLookupNewTableAdapter.FillByOrderAndColor(Me.OrderPOLookupNewDataSet.OrderPOLookupNew, row.FabricColorId, row.OrderId)

        '    'MessageBox.Show(row.OrderId & " And " & row.FabricColorId)

        '    UpdatePOStatus()

        'End If


    End Sub



    'Private Sub ProgramNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoComboBox.SelectedIndexChanged

    '    On Error Resume Next

    '    Dim row As OrderLookupDataSet.OrderLookupRow
    '    row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

    '    'Me.SizeLookupTableAdapter.Fill(Me.SizeLookupDataSet.SizeLookup, ProgramNoComboBox.SelectedValue)
    '    Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoComboBox.SelectedValue)

    '    If row.IsIsMultiPartNull = False Then

    '        If row.IsMultiPart = True Then

    '            MultipartComboBox.Visible = True
    '            MultipartLabel.Visible = True
    '            'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = True

    '        Else

    '            MultipartComboBox.Visible = False
    '            MultipartLabel.Visible = False
    '            'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False

    '        End If

    '    Else

    '        MultipartComboBox.Visible = False
    '        MultipartLabel.Visible = False

    '    End If

    '    ''Default Value

    '    Me.SewingProductionDataSet.SewingProduction.OrderIdColumn.DefaultValue = ProgramNoComboBox.SelectedValue
    '    Me.SewingProductionDataSet.SewingProduction.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue
    '    Me.SewingProductionDataSet.SewingProduction.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue



    'End Sub


    Private Sub SewingHourlyProductionBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles SewingHourlyProductionBindingSource.AddingNew

        Me.SewingProductionDataSet.SewingHourlyProduction.ProductionHourColumn.DefaultValue = SewingHourlyProductionDataGridView.RowCount 'CInt(row1.ProdctionHour) + 1

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
        If UL <> 1 Then
            GoTo Line2
        Else
            GoTo Line1
        End If

Line2:
        If Me.SewingProductionBindingSource.Position > -1 Then

            Dim row As SewingProductionDataSet.SewingProductionRow
            row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

            Dim chkSewingDel As Integer = ReadIntData("Select Count(SewingId) From SewingDeliveryDetails Where SewingId=" & row.SewingId, cnn)

            If chkSewingDel > 0 Then
                MessageBox.Show("Not Saved,It is used in Sewing Delivery Challan")
                Exit Sub
            End If

        End If


        If chkInput = True Then

            MessageBox.Show("Not Saved. Output Quantity is greater than Sewing/Cutting Input Quantity")
            Exit Sub

        End If
Line1:

        If SaveButton.Text = "&Edit" Then

            SaveButton.Text = "&Update"
            If UL = 1 Then
                Me.SewingHourlySizewiseProductionDataGridView.Enabled = True
            End If
            Dim row As SewingProductionDataSet.SewingProductionRow
            row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)
            Me.SewingProductionTableAdapter.FillBySewingId(Me.SewingProductionDataSet.SewingProduction, row.SewingId)

        Else



            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)

            Try

                Me.Validate()
                Me.SewingProductionBindingSource.EndEdit()
                Me.SewingHourlyProductionBindingSource.EndEdit()
                Me.SewingHourlySizewiseProductionBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SewingProductionDataSet)

                Me.ProgramNoGridLookUpEdit.Focus()

                TTLHourlyOutput.Text = ReadData("Select Sum(H1+H2+H3+H4+H5+H6+H7+H8+H9+H10+H11+H12+HX) From vSewingHourlyProduction Where SewingDate='" & DateTimePicker1.Text & "' and BranchId=" & BranchComboBox.SelectedValue, cnn)

                RefreshSummery()
                CalTTLWH()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


            If ByUserFlag = False Then
                Me.SewingProductionTableAdapter.FillByDateWise(Me.SewingProductionDataSet.SewingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text)
            Else
                Me.SewingProductionTableAdapter.FillByDateAndBranchAndUserId(Me.SewingProductionDataSet.SewingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text, UserId)
            End If
            SaveButton.Text = "&Edit"

            SplashScreenManager.CloseForm(False)

        End If

    End Sub




    Private Sub SewingProductionDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SewingProductionDataGridView.CellEndEdit

        CalculateSummery()

    End Sub

    'Private Sub FabricColorComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.LostFocus

    '    Me.TwinPackfilteredTableAdapter.Fill(Me.TwinPackLookupDataSet.TwinPackfiltered, ProgramNoComboBox.SelectedValue, FabricColorComboBox.SelectedValue)

    '    Me.SewingProductionDataSet.SewingProduction.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue


    '    'If EntryModeCheckBox.Checked = True Then

    '    '    Me.SewingProductionBindingSource.AddNew()

    '    'Else

    '    '    Dim index As Integer = Me.SewingProductionBindingSource.Find("OrderId", ProgramNoComboBox.SelectedValue)
    '    '    Me.SewingProductionBindingSource.Position = index

    '    'End If


    'End Sub

    Private Sub FabricColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.SelectedIndexChanged

        On Error Resume Next

        Me.SewingProductionDataSet.SewingProduction.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue

        Me.TwinPackfilteredTableAdapter.Fill(Me.TwinPackLookupDataSet.TwinPackfiltered, ProgramNoGridLookUpEdit.EditValue, FabricColorComboBox.SelectedValue)
        Me.OrderPOLookupNewTableAdapter.FillByOrderAndColor(Me.OrderPOLookupNewDataSet.OrderPOLookupNew, FabricColorComboBox.SelectedValue, ProgramNoGridLookUpEdit.EditValue)

        UpdatePOStatus()

    End Sub



    Private Sub SewingProductionBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles SewingProductionBindingSource.AddingNew


        If OrderFabricColorBindingSource.Position > -1 Then
            Me.SewingProductionDataSet.SewingProduction.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue
        End If


    End Sub


    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged
        On Error Resume Next
        If ByUserFlag = False Then
            Me.SewingProductionTableAdapter.FillByDateWise(Me.SewingProductionDataSet.SewingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text)
        Else
            Me.SewingProductionTableAdapter.FillByDateAndBranchAndUserId(Me.SewingProductionDataSet.SewingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text, UserId)
        End If
        Me.LineTableAdapter.FillByBranchId(Me.LineDataSet.Line, BranchComboBox.SelectedValue)
        Me.CuttingDeliveryChallanLookupTableAdapter.FillByBranchAndDateAndSewing(Me.CuttingDeliveryChallanLookupDataSet.CuttingDeliveryChallanLookup, DateTimePicker1.Text, BranchComboBox.SelectedValue)
        Me.SewingProductionDataSet.SewingProduction.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue


        RefreshSummery()
        TTLHourlyOutput.Text = ReadData("Select Sum(H1+H2+H3+H4+H5+H6+H7+H8+H9+H10+H11+H12+HX) From vSewingHourlyProduction Where SewingDate='" & DateTimePicker1.Text & "' and BranchId=" & BranchComboBox.SelectedValue, cnn)

    End Sub

    Private Sub BranchCheckBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BranchCheckBox.Click

        DateCheckBox.Checked = False

    End Sub

    Private Sub DateCheckBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateCheckBox.Click

        BranchCheckBox.Checked = False

    End Sub


    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        RefreshSummery()
        With frmDailySewingReport
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .SewingDate = Me.DateTimePicker1.Text
            .BranchId = Me.BranchComboBox.SelectedValue
            .MIS = False
            .Show()
        End With

    End Sub

    'Private Sub ProgramNoComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgramNoComboBox.TextChanged

    '    On Error Resume Next
    '    Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoComboBox.SelectedValue)


    'End Sub


    Private Sub RefreshSummery()



        'Go through all row  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        For index As Integer = 1 To SewingProductionBindingSource.Count


            If SewingProductionBindingSource.Position + 1 < SewingProductionBindingSource.Count Then

                SewingProductionBindingSource.MoveNext()

                ' Otherwise, move back to the first item.
            Else

                SewingProductionBindingSource.MoveFirst()

            End If


        Next


        'Summery for Grand Total >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Dim vMMInput As Decimal = 0
        Dim vMMOutput As Decimal = 0
        Dim vInput As Decimal = 0
        Dim vOutput As Decimal = 0
        Dim vReject As Decimal = 0
        Dim vInputBalance As Decimal = 0


        MMInputLabel.Text = 0
        MMOutputLabel.Text = 0
        InputLabel.Text = 0
        OutputLabel.Text = 0
        RejectLabel.Text = 0



        For Each dr As DataRowView In SewingProductionBindingSource.List
            If dr!Countable = True Then
                If IsDBNull(dr!MMInput) = False Then
                    vMMInput = vMMInput + dr!MMInput
                    MMInputLabel.Text = vMMInput
                Else
                    vMMInput = 0
                    MMInputLabel.Text = 0
                End If


                If IsDBNull(dr!MMOutput) = False Then
                    vMMOutput = vMMOutput + dr!MMOutput
                    MMOutputLabel.Text = vMMOutput
                Else
                    vMMOutput = 0
                    MMOutputLabel.Text = 0
                End If


                If IsDBNull(dr!InputQuantity) = False Then

                    vInput = vInput + dr!InputQuantity
                    InputLabel.Text = vInput

                Else

                    vInput = 0
                    InputLabel.Text = 0

                End If


                If IsDBNull(dr!OutputQuantity) = False Then


                    vOutput = vOutput + dr!OutputQuantity
                    OutputLabel.Text = vOutput


                Else

                    vOutput = 0
                    OutputLabel.Text = 0

                End If


                If IsDBNull(dr!RejectQuantity) = False Then
                    vReject = vReject + dr!RejectQuantity
                    RejectLabel.Text = vReject
                Else
                    vReject = 0
                    RejectLabel.Text = 0
                End If
            End If
        Next

        InputBalanceLabel.Text = CInt(InputLabel.Text) - CInt(OutputLabel.Text)
        InputDiffLabel.Text = CInt(MMInputLabel.Text) - CInt(InputLabel.Text)
        OutputDiffLabel.Text = CInt(MMOutputLabel.Text) - CInt(OutputLabel.Text)

    End Sub

    Private Sub CalculateSummery()

        On Error Resume Next
        'Calculate Summery >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        If SewingProductionBindingSource.Position > -1 Then


            Dim row As SewingProductionDataSet.SewingProductionRow
            row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

            If row.Countable = True Then


                Dim connection As New SqlConnection(cnn)
                connection.Open()

                If row.IsLineIdNull = False Then

                    Dim cmd As SqlCommand = New SqlCommand("Select Sum(InputQuantity)As TTLInput,Sum(OutputQuantity) As TTLOutput,Sum(RejectQuantity) As TTLReject From SewingProduction where OrderId=" & row.OrderId & " And FabricColorId=" & row.FabricColorId & " And LineId=" & row.LineId & "and BranchId=" & BranchComboBox.SelectedValue & " and SewingId<>" & row.SewingId & " And SewingDate<='" & DateTimePicker1.Text & "'", connection)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    reader.Read()


                    If reader.IsDBNull(0) Then
                        row.TInput = row.InputQuantity
                    Else
                        row.TInput = reader.GetDecimal(0) + CDec(row.InputQuantity)
                    End If

                    If SewingHourlyProductionBindingSource.Position > -1 Then

                        Dim row2 As SewingProductionDataSet.SewingHourlyProductionRow
                        row2 = CType(CType(Me.SewingHourlyProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingHourlyProductionRow)

                        If row2.IsHTNull = False Then
                            row.OutputQuantity = row2.HT

                            'row.WorkingHour = ReadData("Select TTLHour From SewingProductionHourCount Where SewingId=" & row.SewingId, cnn)

                        End If


                    End If

                    If reader.IsDBNull(1) Then
                        row.TOutput = row.OutputQuantity
                    Else
                        row.TOutput = reader.GetDecimal(1) + CDec(row.OutputQuantity)
                    End If

                    If reader.IsDBNull(2) Then
                        row.TReject = row.RejectQuantity
                    Else
                        row.TReject = reader.GetDecimal(2) + CDec(row.RejectQuantity)
                    End If


                End If

            End If



        End If

    End Sub

    Private Sub SewingProductionBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SewingProductionBindingSource.PositionChanged

        On Error Resume Next
        If Me.SewingProductionBindingSource.Position > -1 Then

            Dim row As SewingProductionDataSet.SewingProductionRow
            row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

            'Me.SewingHourlyProductionTableAdapter.Fill(Me.SewingProductionDataSet.SewingHourlyProduction, row.SewingId)
            'Me.SewingHourlySizewiseProductionTableAdapter.Fill(Me.SewingProductionDataSet.SewingHourlySizewiseProduction, row.SewingId)
            'Me.SewingSizewiseInputTableAdapter.Fill(Me.SewingProductionDataSet.SewingSizewiseInput, row.SewingId)

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)



            Dim SDCount As Integer = ReadIntData("Select Count(SewingId) From SewingDeliveryDetails Where SewingId=" & row.SewingId, cnn)

            If SDCount = 0 OrElse UL = 1 Then
                Me.SewingHourlyProductionDataGridView.Enabled = True
                Me.SewingHourlySizewiseProductionDataGridView.Enabled = True

            Else
                Me.SewingHourlyProductionDataGridView.Enabled = False
                Me.SewingHourlySizewiseProductionDataGridView.Enabled = False
            End If


            'CalculateSummery()

        End If


    End Sub



    Private Sub SewingHourlyProductionBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SewingHourlyProductionBindingSource.PositionChanged, SewingHourlyProductionBindingSource.CurrentChanged, SewingHourlyProductionBindingSource.CurrentItemChanged

        Dim TTLHourlyOutputQuantity As Integer = 0
        'TTLHourOutputQuantityLabel.Text = 0
        If SewingHourlyProductionBindingSource.Position > -1 Then

            For Each dr As DataRowView In SewingHourlyProductionBindingSource.List

                TTLHourlyOutputQuantity = TTLHourlyOutputQuantity + dr!Quantity
                'TTLHourOutputQuantityLabel.Text = TTLHourlyOutputQuantity

            Next


        End If

        If SewingProductionBindingSource.Position > -1 Then

            Dim row As SewingProductionDataSet.SewingProductionRow
            row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)


            If Me.SewingHourlyProductionBindingSource.Position > -1 Then
                Dim row1 As SewingProductionDataSet.SewingHourlyProductionRow
                row1 = CType(CType(Me.SewingHourlyProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingHourlyProductionRow)

                If row1.IsHTNull = False Then
                    row.OutputQuantity = row1.HT
                    'row.WorkingHour = ReadData("Select TTLHour From SewingProductionHourCount Where SewingId=" & row.SewingId, cnn)
                End If


            End If

        End If


    End Sub



    Private Sub MISPrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MISPrintButton.Click
        With frmEfficiencyReport
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub SewingHourlyProductionDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles SewingHourlyProductionDataGridView.CellValidating

        '' Validate the Print Color entry by disallowing empty strings.

        'If SewingHourlyProductionDataGridView.Columns(e.ColumnIndex).Index = 13 Then

        '    Dim row As SewingProductionDataSet.SewingProductionRow
        '    row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

        '    Dim row2 As SewingProductionDataSet.SewingHourlyProductionRow
        '    row2 = CType(CType(Me.SewingHourlyProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingHourlyProductionRow)

        '    If row.OutputQuantity <> Val(row2.H1) + Val(row2.H2) + Val(row2.H3) + Val(row2.H4) + Val(row2.H5) + Val(row2.H6) + Val(row2.H7) + Val(row2.H8) + Val(row2.H8) + Val(row2.H9) + Val(row2.H10) + Val(row2.H11) + Val(row2.H12) + Val(row2.HX) Then
        '        MessageBox.Show("Quantity doesn't match with Sewing Production", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    End If

        'End If
    End Sub

    Private Sub SewingHourlyProductionDataGridView_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SewingHourlyProductionDataGridView.Enter

        'On Error Resume Next

        'Me.Validate()
        'Me.SewingProductionBindingSource.EndEdit()
        ''Me.SewingHourlyProductionBindingSource.EndEdit()
        ''Me.SewingRejectionBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.SewingProductionDataSet)

    End Sub

    Private Sub SewingHourlyProductionDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SewingHourlyProductionDataGridView.KeyDown

        If e.KeyCode = Keys.Return Then
            Dim cur_cell As DataGridViewCell =
                SewingHourlyProductionDataGridView.CurrentCell
            Dim col As Integer = cur_cell.ColumnIndex
            col = (col + 1) Mod SewingHourlyProductionDataGridView.Columns.Count
            cur_cell = SewingHourlyProductionDataGridView.CurrentRow.Cells(col)
            SewingHourlyProductionDataGridView.CurrentCell = cur_cell

            e.Handled = True


        End If

    End Sub

    Private Sub SewingRejectionDataGridView_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SewingRejectionDataGridView.Enter

        Me.Validate()
        Me.SewingProductionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingProductionDataSet)

    End Sub


    Private Sub SewingProductionDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SewingProductionDataGridView.KeyDown


        If e.KeyCode = Keys.F10 Then


            If SewingProductionDataGridView.Columns(SewingProductionDataGridView.CurrentCell.ColumnIndex).HeaderText = "Layout No" Then


                Dim row As SewingProductionDataSet.SewingProductionRow
                row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

                frmSewingLayoutNoSearch.SewingProduction = True
                frmSewingLayoutNoSearch.OrderId = row.OrderId

                ShowMaster(frmSewingLayoutNoSearch)


                If frmSewingLayoutNoSearch.DialogResult = System.Windows.Forms.DialogResult.OK Then

                    Me.SewingLayoutTableAdapter.Fill(Me.SewingLayoutDataSet.SewingLayout)
                    row.SewingLayoutId = frmSewingLayoutNoSearch.SewinglayoutId
                    row.Target = ReadData("Select TotalTargetQuantity from SewingLayout Where LayoutId=" & frmSewingLayoutNoSearch.SewinglayoutId, cnn) * 10 ' 10 Hours target

                    If ReadBooleanData("Select BonusTargets From SewingLayout Where LayoutId=" & frmSewingLayoutNoSearch.SewinglayoutId, cnn) = True Then

                        row.BonusTarget = ReadData("Select BonusTargetQuantity from SewingLayout Where LayoutId=" & frmSewingLayoutNoSearch.SewinglayoutId, cnn) * 10

                    Else

                        row.BonusTarget = 0

                    End If

                End If
            End If

        End If


    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click


        Me.SewingProductionBindingSource.AddNew()
        Me.SewingProductionDataGridView.Focus()

    End Sub

    Private Sub MultipartComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MultipartComboBox.LostFocus
        Me.SewingProductionDataSet.SewingProduction.TwinPackIdColumn.DefaultValue = MultipartComboBox.SelectedValue
    End Sub

    Private Sub MultipartComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultipartComboBox.SelectedIndexChanged
        Me.SewingProductionDataSet.SewingProduction.TwinPackIdColumn.DefaultValue = MultipartComboBox.SelectedValue
    End Sub

    Private Sub frmSewingProduction_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F3 Then

            Me.SewingProductionBindingSource.AddNew()
            Me.SewingProductionDataGridView.Focus()

        End If

    End Sub


    Private Sub MultipartCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultipartCheckBox.CheckedChanged

        If MultipartCheckBox.Checked = True Then
            Me.SewingProductionDataGridView.Columns("TwinPackId").Visible = True
        Else
            Me.SewingProductionDataGridView.Columns("TwinPackId").Visible = False
        End If

    End Sub

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged, ProgramNoGridLookUpEdit.Closed
        On Error Resume Next
        If OrderLookupBindingSource.Position > -1 Then


            Dim OrderId As Integer = ReadIntegerData("Select OrderId From [Order] Where OrderId= " & ProgramNoGridLookUpEdit.EditValue, cnn)
            Dim IsPrint As Boolean = ReadBooleanData("Select IsPrint From [Order] Where OrderId= " & ProgramNoGridLookUpEdit.EditValue, cnn)
            Dim IsIsMultiPartNull As Boolean = ReadBooleanData("Select IsPrint From [Order] Where OrderId= " & ProgramNoGridLookUpEdit.EditValue, cnn)


            Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, OrderId)


            If IsIsMultiPartNull = False Then


                If IsIsMultiPartNull = True Then

                    MultipartComboBox.Visible = True
                    MultipartLabel.Visible = True
                    'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = True

                Else

                    MultipartComboBox.Visible = False
                    MultipartLabel.Visible = False
                    'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False

                End If

            Else

                MultipartComboBox.Visible = False
                MultipartLabel.Visible = False
                'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False

            End If




            Me.SewingProductionDataSet.SewingProduction.OrderIdColumn.DefaultValue = OrderId
            Me.SewingProductionDataSet.SewingProduction.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue
            Me.SewingProductionDataSet.SewingProduction.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue


        End If
    End Sub

    Private Sub ProgramNoGridLookUpEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.TextChanged

        On Error Resume Next

        Dim OrderId As Integer = ReadIntegerData("Select OrderId From [Order] Where OrderId=" & ProgramNoGridLookUpEdit.EditValue, cnn)
        Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, OrderId)

    End Sub



    Private Sub UpdatePOStatus()



        For Each drv As DataRowView In Me.OrderPOLookupNewBindingSource.List

            drv!OrderQuantity = ReadIntegerData("Select OrderQuantity From vOrder Where OrderDetailsId=" & drv!OrderDetailsId, cnn)
            drv!SewingQuantity = ReadData("Select Sum(OutputQuantity) as TTLOUTPUT From SewingProduction Where OrderDetailsId=" & drv!OrderDetailsId, cnn)
            drv!InputQuantity = ReadData("Select Sum(InputQuantity) As TTLInput From SewingProduction Where OrderDetailsId=" & drv!OrderDetailsId, cnn)

            If drv!SewingQuantity > drv!OrderQuantity Then
                drv!ExcessQuantity = drv!SewingQuantity - drv!OrderQuantity
                If drv!OrderQuantity > 0 Then
                    drv!ExcessQuantityPercentage = (drv!ExcessQuantity / drv!OrderQuantity) * 100
                Else
                    drv!ExcessQuantityPercentage = 0
                End If

            Else
                drv!ExcessQuantity = 0
                drv!ExcessQuantityPercentage = 0
            End If

            Highlight()

        Next



    End Sub

    Private Sub OrderPOLookupNewDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles OrderPOLookupNewDataGridView.RowHeaderMouseDoubleClick

        If Me.SewingProductionBindingSource.Position > -1 Then

            Dim row As SewingProductionDataSet.SewingProductionRow
            row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

            If Me.OrderPOLookupNewBindingSource.Position > -1 Then

                Dim row1 As OrderPOLookupNewDataSet.OrderPOLookupNewRow
                row1 = CType(CType(Me.OrderPOLookupNewBindingSource.Current, DataRowView).Row, OrderPOLookupNewDataSet.OrderPOLookupNewRow)

                row.OrderDetailsId = row1.OrderDetailsId

            End If

        End If

    End Sub

    Private Sub SewingProductionDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SewingProductionDataGridView.RowHeaderMouseDoubleClick




    End Sub

    Private Sub SewingHourlyProductionDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SewingHourlyProductionDataGridView.CellEndEdit

        If Me.OrderPOLookupNewBindingSource.Position > -1 Then

            Dim row As SewingProductionDataSet.SewingProductionRow
            row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

            For Each drv As DataRowView In OrderPOLookupNewBindingSource.List

                If row.IsOrderDetailsIdNull = False Then

                    If drv!OrderDetailsId = row.OrderDetailsId Then

                        If DBNull.Value.Equals(Me.SewingHourlyProductionDataGridView.CurrentCell.Value) = False Then
                            drv!SewingQuantity = drv!SewingQuantity + SewingHourlyProductionDataGridView.CurrentCell.Value - CHP 'CHP will deduct the previous value
                        End If

                    End If

                End If

            Next

            Highlight()

        End If



    End Sub




    Private Sub frmSewingProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SewingProductionDataSet.SewingSizewiseInput' table. You can move, or remove it, as needed.




        Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)

        'Me.OrderPOLookupNewTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupNew)

        Me.TwinPackLookupTableAdapter.Fill(Me.TwinPackLookupDataSet.TwinPackLookup)

        Me.SewingLayoutTableAdapter.Fill(Me.SewingLayoutDataSet.SewingLayout)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.LineTableAdapter.FillByBranchId(Me.LineDataSet.Line, BranchComboBox.SelectedValue)

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.SewingRejectionTableAdapter.Fill(Me.SewingProductionDataSet.SewingRejection)
        Me.SizeLookupTableAdapter.FillByAll(Me.SizeLookupDataSet.SizeLookup)

        If ByUserFlag = False Then
            Me.SewingProductionTableAdapter.FillByDateWise(Me.SewingProductionDataSet.SewingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text)
            If CheckUserRights("Sewing Production").CanEdit = False Then

                AddButton.Enabled = False
                SaveButton.Enabled = False
                AddtoSProdButton.Enabled = False
                EditToSProdButton.Enabled = False

            End If
        Else
            Me.SewingProductionTableAdapter.FillByDateAndBranchAndUserId(Me.SewingProductionDataSet.SewingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text, UserId)

            If CheckUserRights("Sewing Production Userwise").CanEdit = False Then

                AddButton.Enabled = False
                SaveButton.Enabled = False
                AddtoSProdButton.Enabled = False
                EditToSProdButton.Enabled = False

            End If
        End If

        Me.SewingProductionDataSet.SewingProduction.SewingDateColumn.DefaultValue = DateTimePicker1.Text
        ' Me.SewingProductionDataSet.SewingProduction.SFPColumn.DefaultValue = ReadData("Select NumberValue From Parameter Where PrameterId=12", cnn)
        Me.MultipartComboBox.Visible = False
        Me.MultipartLabel.Visible = False

    End Sub


    Private Sub Highlight()

        'Dim MaxValue As Decimal = 0

        For Each dr As DataGridViewRow In OrderPOLookupNewDataGridView.Rows

            'If dr.Cells(5).Value = BottleNeck Then
            dr.DefaultCellStyle.BackColor = Color.White
            'End If

            If DBNull.Value.Equals(dr.Cells("SewingQuantity").Value) = False Then
                Dim SQTY As Integer = Math.Round(dr.Cells("SewingQuantity").Value, 0)
                Dim OQTY As Integer = Math.Round(dr.Cells("OrderQuantity").Value, 0)

                If SQTY > OQTY * 1.05 Then
                    dr.DefaultCellStyle.BackColor = Color.Red
                ElseIf SQTY > OQTY And SQTY < OQTY * 1.05 Then
                    dr.DefaultCellStyle.BackColor = Color.Yellow
                Else
                    dr.DefaultCellStyle.BackColor = Color.White
                End If
            End If

        Next

        'For Each dr As DataGridViewRow In SewingLayoutDataGridView.Rows

        '    If DBNull.Value.Equals(dr.Cells("AveragePerMachine").Value) = False Then
        '        If Math.Round(dr.Cells("AveragePerMachine").Value, 0) = MaxValue Then
        '            dr.DefaultCellStyle.BackColor = Color.Gold
        '        End If
        '    End If

        'Next


    End Sub

    Private Sub SewingHourlyProductionDataGridView_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles SewingHourlyProductionDataGridView.CellBeginEdit
        On Error Resume Next

        CHP = Me.SewingHourlyProductionDataGridView.CurrentCell.Value
    End Sub



    Private Sub AddtoSProdButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddtoSProdButton.Click

        If Me.OrderPOLookupNewBindingSource.Position > -1 Then

            Dim row As OrderPOLookupNewDataSet.OrderPOLookupNewRow
            row = CType(CType(Me.OrderPOLookupNewBindingSource.Current, DataRowView).Row, OrderPOLookupNewDataSet.OrderPOLookupNewRow)

            With Me.SewingProductionDataSet.SewingProduction

                .SewingDateColumn.DefaultValue = Me.DateTimePicker1.Value.Date
                .OrderIdColumn.DefaultValue = row.OrderId
                .FabricColorIdColumn.DefaultValue = row.FabricColorId
                .BranchIdColumn.DefaultValue = Me.BranchComboBox.SelectedValue
                .OrderDetailsIdColumn.DefaultValue = row.OrderDetailsId

            End With

            Me.SewingProductionBindingSource.AddNew()
            SaveButton.Text = "&Update"
        End If

    End Sub

    Private Sub EditToSProdButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToSProdButton.Click

        If Me.SewingProductionBindingSource.Position > -1 Then

            Dim row As SewingProductionDataSet.SewingProductionRow
            row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)


            Dim SDCount As Integer = ReadIntData("Select Count(SewingId) From SewingDeliveryDetails Where SewingId=" & row.SewingId, cnn)

            If SDCount = 0 Then
                If Me.OrderPOLookupNewBindingSource.Position > -1 Then

                    Dim row1 As OrderPOLookupNewDataSet.OrderPOLookupNewRow
                    row1 = CType(CType(Me.OrderPOLookupNewBindingSource.Current, DataRowView).Row, OrderPOLookupNewDataSet.OrderPOLookupNewRow)

                    row.OrderDetailsId = row1.OrderDetailsId
                    row.FabricColorId = row1.FabricColorId
                    row.OrderId = row1.OrderId


                End If
            Else
                MessageBox.Show("Not Allowed to edit , Already Sewing Delivery has been created.")
            End If

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked


        'Try

        'Me.Validate()
        'Me.SewingProductionBindingSource.EndEdit()
        'Me.SewingHourlyProductionBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.SewingProductionDataSet)


        'TTLHourlyOutput.Text = ReadData("Select Sum(H1+H2+H3+H4+H5+H6+H7+H8+H9+H10+H11+H12+HX) From vSewingHourlyProduction Where SewingDate='" & DateTimePicker1.Text & "' and BranchId=" & BranchComboBox.SelectedValue, cnn)

        'RefreshSummery()

        If Me.SewingHourlyProductionBindingSource.Position = -1 Then
            Me.SewingHourlyProductionBindingSource.AddNew()
        End If


        'Catch ex As Exception
        '    MessageBox.Show("Not Saved", "Not Saved", MessageBoxButtons.OK)
        'End Try


    End Sub

    Private Sub ReloadSLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadSLButton.Click

        'On Error Resume Next


        If Me.SewingProductionBindingSource.Position > -1 Then

            Me.SewingProductionDataGridView.CurrentRow.Selected = True

            Dim row As SewingProductionDataSet.SewingProductionRow
            row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

            'Me.SewingProductionTableAdapter.FillBySewingId(Me.SewingProductionDataSet.SewingProduction, row.SewingId)
            'Me.SewingProductionDataGridView.CurrentRow.Selected = True
            '
            Me.SewingHourlyProductionTableAdapter.Fill(Me.SewingProductionDataSet.SewingHourlyProduction, row.SewingId)
            Me.SewingHourlySizewiseProductionTableAdapter.Fill(Me.SewingProductionDataSet.SewingHourlySizewiseProduction, row.SewingId)
            Me.SewingSizewiseInputTableAdapter.Fill(Me.SewingProductionDataSet.SewingSizewiseInput, row.SewingId)

            Me.OrderPOLookupNewTableAdapter.FillByOrderAndColor(Me.OrderPOLookupNewDataSet.OrderPOLookupNew, row.FabricColorId, row.OrderId)

            'MessageBox.Show(row.OrderId & " And " & row.FabricColorId)

            UpdatePOStatus()

        End If
    End Sub

    'Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged
    '    'On Error Resume Next


    '    'If Me.OrderPOLookupAllBindingSource.Position > -1 Then

    '    '    Dim OID As Integer = ReadIntegerData("Select OrderId From OrderDetails Where OrderDetailsId=" & GridLookUpEdit1.EditValue, cnn)
    '    '    Dim FID As Integer = ReadIntegerData("Select FabricColorId From OrderDetails Where OrderDetailsId=" & GridLookUpEdit1.EditValue, cnn)
    '    '    ProgramNoGridLookUpEdit.EditValue = OID
    '    '    FabricColorComboBox.SelectedValue = FID

    '    '    'OrderQuantityLabel.Text = "Order Quantity : " & ReadIntegerData("Select Sum(OrderQuantity) From vOrder Where OrderDetailsId=" & POandColorComboBox.SelectedValue, cnn)

    '    'End If
    'End Sub

    Private Sub SewingProductionDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles SewingProductionDataGridView.DataError
        On Error Resume Next

    End Sub

    Private Sub GetSizeLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GetSizeLinkLabel.LinkClicked
        'Getting Size List

        If Me.SewingHourlySizewiseProductionBindingSource.Position > -1 Then
            Exit Sub
        Else

            If Me.SewingHourlyProductionBindingSource.Position = -1 Then
                Me.SewingHourlyProductionBindingSource.AddNew()
            End If

            Try
                Me.Validate()
                Me.SewingProductionBindingSource.EndEdit()
                Me.SewingHourlyProductionBindingSource.EndEdit()
                Me.SewingHourlySizewiseProductionBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SewingProductionDataSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Dim row As SewingProductionDataSet.SewingProductionRow
            row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

            Using connection As New SqlConnection(cnn)

                Dim querystring As String = "Select SizeId From OrderSizeDetails Where OrderDetailsId=" & row.OrderDetailsId.ToString()
                Dim command As New SqlCommand(querystring, connection)
                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                Dim row1 As SewingProductionDataSet.SewingHourlyProductionRow
                row1 = CType(CType(Me.SewingHourlyProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingHourlyProductionRow)

                While reader.Read()

                    Dim newRow As SewingProductionDataSet.SewingHourlySizewiseProductionRow = Me.SewingProductionDataSet.SewingHourlySizewiseProduction.NewRow()
                    newRow.SewingHourlyId = row1.SewingHourlyId
                    newRow.SizeId = reader("SizeId").ToString
                    newRow.Remarks = "-"
                    Me.SewingProductionDataSet.SewingHourlySizewiseProduction.Rows.Add(newRow)

                End While


            End Using

        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        CalculteSizeQuantity()
    End Sub
    Private Sub CalculteSizeQuantity()

        Dim vH1 As Integer = 0
        Dim vH2 As Integer = 0
        Dim vH3 As Integer = 0
        Dim vH4 As Integer = 0
        Dim vH5 As Integer = 0
        Dim vH6 As Integer = 0
        Dim vH7 As Integer = 0
        Dim vH8 As Integer = 0
        Dim vH9 As Integer = 0
        Dim vH10 As Integer = 0
        Dim vH11 As Integer = 0
        Dim vH12 As Integer = 0
        Dim vHX As Integer = 0


        For Each drv As DataRowView In Me.SewingHourlySizewiseProductionBindingSource.List

            vH1 = vH1 + drv!H1
            vH2 = vH2 + drv!H2
            vH3 = vH3 + drv!H3
            vH4 = vH4 + drv!H4
            vH5 = vH5 + drv!H5
            vH6 = vH6 + drv!H6
            vH7 = vH7 + drv!H7
            vH8 = vH8 + drv!H8
            vH9 = vH9 + drv!H9
            vH10 = vH10 + drv!H10
            vH11 = vH11 + drv!H11
            vH12 = vH12 + drv!H12
            vHX = vHX + drv!HX

        Next



        Dim row3 As SewingProductionDataSet.SewingProductionRow
        row3 = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)


        Dim TTLOutputQuantity As Integer = 0
        Dim TTLInputQuantity As Integer = 0
        Dim TTLCuttingInput As Integer = 0
        Dim TTLCurrentOutput As Integer = 0

        TTLOutputQuantity = ReadData("Select Sum(OutputQuantity) From SewingProduction Where SewingId<>" & row3.SewingId & " And OrderDetailsId=" & row3.OrderDetailsId, cnn)
        TTLInputQuantity = ReadData("Select Sum(InputQuantity) From SewingProduction Where OrderDetailsId=" & row3.OrderDetailsId, cnn)
        TTLCuttingInput = ReadData("Select Sum(InputQuantity) From [dbo].[CuttingDeliverySummeryPOAndSize] Where OrderDetailsId=" & row3.OrderDetailsId & "And ChallanFor=1", cnn)

        'Debug.Print("Cutting" & row3.OrderDetailsId.ToString() & "::" & TTLCuttingInput.ToString())
        'Debug.Print("Sewing" & row3.OrderDetailsId.ToString() & "::" & TTLInputQuantity.ToString())


        TTLCurrentOutput = vH1 + vH2 + vH3 + vH4 + vH5 + vH6 + vH7 + vH8 + vH9 + vH10 + vH11 + vH12 + vHX


        If TTLCuttingInput < TTLOutputQuantity + TTLCurrentOutput AndAlso UserId <> 1 Then

            MessageBox.Show("Not Allowed, Output Quantity is greater than Cutting Input Quantity.")
            chkInput = True
            Exit Sub

        ElseIf TTLInputQuantity < TTLOutputQuantity + TTLCurrentOutput AndAlso UserId <> 1 Then

            MessageBox.Show("Not Allowed, Output Quantity is greater than Sewing Input Quantity.")
            chkInput = True
            Exit Sub

        Else
            row3.OutputQuantity = TTLCurrentOutput
            chkInput = False
        End If


        Dim row As SewingProductionDataSet.SewingHourlyProductionRow
        row = CType(CType(Me.SewingHourlyProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingHourlyProductionRow)

        row.H1 = vH1
        row.H2 = vH2
        row.H3 = vH3
        row.H4 = vH4
        row.H5 = vH5
        row.H6 = vH6
        row.H7 = vH7
        row.H8 = vH8
        row.H9 = vH9
        row.H10 = vH10
        row.H11 = vH11
        row.H12 = vH12
        row.HX = vHX


    End Sub

    Private Sub GetInputButton_Click(sender As Object, e As EventArgs) Handles GetInputButton.Click

        If Me.SewingProductionBindingSource.Position > -1 Then
            Dim row As SewingProductionDataSet.SewingProductionRow
            row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

            row.InputQuantity = ReadData("Select SUM(InputQuantity) From CuttingInputQuantityODIDAndDate Where ChallanFor=1 And LineId=" & row.LineId & "And ChallanDate='" & DateTimePicker1.Text & "' And OrderDetailsId=" & row.OrderDetailsId, cnn)

            Debug.Print("LineId=" & row.LineId)
            Debug.Print("LineId=" & row.OrderDetailsId)

        End If


    End Sub

    Private Sub GetDataButton_Click(sender As Object, e As EventArgs) Handles GetDataButton.Click

        Me.SewingProductionTableAdapter.FillByChallanNo(Me.SewingProductionDataSet.SewingProduction, ChallanNoGridLookUpEdit.EditValue)

        If Me.SewingProductionBindingSource.Position = -1 Then

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("GetDataFromCuttingChallan", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ChallanNo", ChallanNoGridLookUpEdit.Text)

                cmd.ExecuteNonQuery()

            End Using

            Me.SewingProductionTableAdapter.FillByChallanNo(Me.SewingProductionDataSet.SewingProduction, ChallanNoGridLookUpEdit.EditValue)


        Else
            MessageBox.Show("Already Received the Challan")
        End If

    End Sub

    Private Sub ChallanNoGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ChallanNoGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub CalTTLWH()

        If Me.SewingProductionBindingSource.Position = -1 Then
            Exit Sub
        End If
        Dim row As SewingProductionDataSet.SewingProductionRow
        row = CType(CType(Me.SewingProductionBindingSource.Current, DataRowView).Row, SewingProductionDataSet.SewingProductionRow)

        Dim H1 As Integer = ReadIntData(" Select 'H1'=CASE WHEN Sum(H1) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H2 As Integer = ReadIntData(" Select 'H2'=CASE WHEN Sum(H2) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H3 As Integer = ReadIntData(" Select 'H3'=CASE WHEN Sum(H3) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H4 As Integer = ReadIntData(" Select 'H4'=CASE WHEN Sum(H4) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H5 As Integer = ReadIntData(" Select 'H5'=CASE WHEN Sum(H5) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H6 As Integer = ReadIntData(" Select 'H6'=CASE WHEN Sum(H6) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H7 As Integer = ReadIntData(" Select 'H7'=CASE WHEN Sum(H7) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H8 As Integer = ReadIntData(" Select 'H8'=CASE WHEN Sum(H8) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H9 As Integer = ReadIntData(" Select 'H9'=CASE WHEN Sum(H9) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H10 As Integer = ReadIntData(" Select 'H10'=CASE WHEN Sum(H10) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H11 As Integer = ReadIntData(" Select 'H11'=CASE WHEN Sum(H11) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H12 As Integer = ReadIntData(" Select 'H12'=CASE WHEN Sum(H12) >  0 THEN 1 ELSE 0 END From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)
        Dim H13 As Integer = ReadIntData(" Select CAST(ISNULL(HXHour,0) AS INT) From SewingHourlyProduction Where SewingId =" & row.SewingId, cnn)

        Dim TTLHours As Integer = 0
        TTLHours = H1 + H2 + H3 + H4 + H5 + H6 + H7 + H8 + H9 + H10 + H11 + H12 + H13

        row.WorkingHour = TTLHours


    End Sub

    Private Sub SewingHourlyProductionDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles SewingHourlyProductionDataGridView.DataError
        On Error Resume Next
    End Sub

    Private Sub SewingHourlySizewiseProductionDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles SewingHourlySizewiseProductionDataGridView.DataError
        On Error Resume Next
    End Sub

End Class