Imports System.Data.SqlClient

Public Class frmPrintProduction
    Dim fltrDate As Boolean = False
    Dim chkInput As Boolean = False
    Private Sub frmPrintProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PrintProductionDataSet.PrintProdSizewiseInput' table. You can move, or remove it, as needed.


        Me.PrintHourlySizewiseProductionTableAdapter.Fill(Me.PrintProductionDataSet.PrintHourlySizewiseProduction)
        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)
        Me.PrintHourlySizewiseProductionTableAdapter.Fill(Me.PrintProductionDataSet.PrintHourlySizewiseProduction)
        Me.PrintOrderViewTableAdapter.Fill(Me.PrintProductionDataSet.PrintOrderView)
        Me.PrintAllOrderLookupTableAdapter.Fill(Me.PrintAllOrderDataSet.PrintAllOrderLookup)
        Me.PrintOrderLookupTableAdapter.FillPrintOrderNewId(Me.PrintProductionDataSet.PrintOrderLookup, PrintOrderNewLookupGridLookUpEdit.EditValue)
        Me.LineTableAdapter.FillByBranchId(Me.LineDataSet.Line, PrintBranchId)
        Me.ShiftTableAdapter.Fill(Me.ShiftDataSet.Shift)
        Me.PrintHourlyProductionTableAdapter.Fill(Me.PrintProductionDataSet.PrintHourlyProduction)
        Me.PrintProductionTableAdapter.FillByProductionDate(Me.PrintProductionDataSet.PrintProduction, PrintProductionDateTimePicker.Text)
        Me.PrintOrderNewLookupTableAdapter.Fill(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)
        Me.CuttingDeliveryChallanLookupTableAdapter.FillByChallanFor(Me.CuttingDeliveryChallanLookupDataSet.CuttingDeliveryChallanLookup, "Printing")

        'Previous Day
        Dim offset As Integer = -1
        Dim PreviousDate As Date
        PreviousDate = DateTime.Today.AddDays(offset)
        Me.PrintProductionDateTimePicker.Text = Today() 'PreviousDate


        'Start -------- Check and Set user rights

        Dim CANEDIT As Boolean
        Dim MENUID As Integer = ReadIntegerData("Select Distinct MENU_ID From Menu Where Menu_Name='Print Production'", cnn)
        CANEDIT = ReadBooleanData("Select CAN_EDIT From UserRights Where User_Id=" & UserId & " and Menu_Id=" & MENUID, cnn)

        If CANEDIT = False Then

            SaveButton.Enabled = False
            PrintProductionDataGridView.ReadOnly = True
            PrintHourlyProductionDataGridView.ReadOnly = True

        End If

        'End ------- Check and Set user rights
        'On Error Resume Next

        Dim CPHM As Decimal = ReadData("Select NumberValue From Parameter Where PrameterName='Cost Per Hour For Print Machine'", cnn)
        Dim CPHT As Decimal = ReadData("Select NumberValue From Parameter Where PrameterName='Cost Per Hour For Print Table'", cnn)

        Me.PrintProductionDataSet.PrintHourlyProduction.CPH_MachineColumn.DefaultValue = CPHM
        Me.PrintProductionDataSet.PrintHourlyProduction.CPH_TableColumn.DefaultValue = CPHT


    End Sub


    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
        If UL <> 1 Then
            GoTo Line2
        Else
            GoTo Line1
        End If

Line2:
        If Me.PrintProductionBindingSource.Position > -1 Then

            Dim row As PrintProductionDataSet.PrintProductionRow
            row = CType(CType(Me.PrintProductionBindingSource.Current, DataRowView).Row, PrintProductionDataSet.PrintProductionRow)

            Dim chkPrintDel As Integer = ReadIntData("Select Count(PrintProductionId) From PrintingDeliveryDetails Where PrintProductionId=" & row.PrintProductionId, cnn)

            If chkPrintDel > 0 Then
                MessageBox.Show("Not Saved,It is used in Print Delivery Challan")
                Exit Sub
            End If

        End If


        'If chkInput = True Then

        '    MessageBox.Show("Not Saved. Output Quantity is greater than Sewing/Cutting Input Quantity")
        '    Exit Sub

        'End If
Line1:
        Try
            Me.Validate()
            Me.PrintProductionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrintProductionDataSet)


            'Update Total

            For index As Integer = 1 To PrintProductionBindingSource.Count

                Dim row As PrintProductionDataSet.PrintProductionRow
                row = CType(CType(Me.PrintProductionBindingSource.Current, DataRowView).Row, PrintProductionDataSet.PrintProductionRow)
                PrintProductionDateTimePicker.Text = row.PrintProductionDate

                row.TTLReceive = ReadData("Select Sum(GMReceiveQuantity) as TTLREceive From PrintProduction Where PrintProductionDate<='" & PrintProductionDateTimePicker.Text & "' And PrintOrderId=" & row.PrintOrderId, cnn)
                row.TTLPrint = ReadData("Select Sum(GMPrintQuantity) as TTLPrint From PrintProduction Where PrintProductionDate<='" & PrintProductionDateTimePicker.Text & "' And PrintOrderId=" & row.PrintOrderId, cnn)
                row.TTLReject = ReadData("Select Sum(GMRejectQuantity) as TTLReject From PrintProduction Where PrintProductionDate<='" & PrintProductionDateTimePicker.Text & "' And PrintOrderId=" & row.PrintOrderId, cnn)
                row.TTLDelivery = ReadData("Select Sum(GMDeliveryQuantity) as TTLDelivery From PrintProduction Where PrintProductionDate<='" & PrintProductionDateTimePicker.Text & "' And PrintOrderId=" & row.PrintOrderId, cnn)

                If PrintHourlyProductionBindingSource.Position > -1 Then
                    row.GMPrintQuantity = ReadData("Select ISNULL(Sum(H1+H2+H3+H4+H5+H6+H7+H8+H9+H10+H11+H12),0) as GMPrintQuantity From PrintHourlyProduction Where PrintProductionId=" & row.PrintProductionId, cnn)

                    If fltrDate = True Then
                        GrandTTLHourlyPrintLabel.Text = ReadData("Select ISNULL(Sum(H1+H2+H3+H4+H5+H6+H7+H8+H9+H10+H11+H12),0) as GMPrintQuantity From PrintHourlyProduction Where PrintProductionId In ( Select PrintProductionId From PrintProduction where PrintProductionDate='" & PrintProductionDateTimePicker.Text & "')", cnn)
                    Else
                        If ColorComboBox.SelectedValue > 0 Then
                            GrandTTLHourlyPrintLabel.Text = ReadData("Select ISNULL(Sum(H1+H2+H3+H4+H5+H6+H7+H8+H9+H10+H11+H12),0) as GMPrintQuantity From PrintHourlyProduction Where PrintProductionId In ( Select PrintProductionId From PrintProduction where PrintOrderId=" & ColorComboBox.SelectedValue & ")", cnn)
                        End If
                    End If

                End If

                If PrintProductionBindingSource.Position + 1 < PrintProductionBindingSource.Count Then
                    PrintProductionBindingSource.MoveNext()
                Else
                    PrintProductionBindingSource.MoveFirst()
                End If


            Next

            '=========================

            Me.Validate()
            Me.PrintProductionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrintProductionDataSet)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        PrintOrderNewLookupGridLookUpEdit.Focus()


    End Sub

    'Private Sub ProgramNoComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    '    If e.KeyData = Keys.F10 Then

    '        frmPrintOrder.PrgNo = Me.ProgramNoComboBox.Text
    '        frmPrintOrder.ShowDialog()

    '        If frmPrintOrder.DialogResult = System.Windows.Forms.DialogResult.OK Then
    '            Me.PrintOrderViewTableAdapter.Fill(Me.PrintProductionDataSet.PrintOrderView)
    '            Me.PrintAllOrderLookupTableAdapter.Fill(Me.PrintAllOrderDataSet.PrintAllOrderLookup)

    '            Dim Orderindex As Integer
    '            Orderindex = Me.PrintAllOrderLookupBindingSource.Find("ProgramNo2", ProgramNoComboBox.Text)
    '            Me.PrintAllOrderLookupBindingSource.Position = Orderindex


    '            'Me.PrintOrderLookupTableAdapter.Fill(Me.PrintProductionDataSet.PrintOrderLookup, ProgramNoComboBox.SelectedValue)

    '            'Dim PrintOrderindex As Integer
    '            'PrintOrderindex = Me.PrintOrderLookupBindingSource.Find("PrintOrderId", PrintOrderId)
    '            'Me.PrintOrderLookupBindingSource.Position = PrintOrderindex


    '        End If


    '    End If

    'End Sub

    'Private Sub ProgramNoComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)



    '    Me.PrintOrderLookupTableAdapter.FillByProgramNo(Me.PrintProductionDataSet.PrintOrderLookup, ProgramNoComboBox.Text)


    '    'If PrintOrderLookupBindingSource.Position = -1 Then


    '    '    frmPrintOrder.pProgramNo = Me.ProgramNoComboBox.Text
    '    '    frmPrintOrder.ShowDialog()

    '    '    If frmPrintOrder.DialogResult = System.Windows.Forms.DialogResult.OK Then

    '    '        Me.PrintOrderViewTableAdapter.Fill(Me.PrintProductionDataSet.PrintOrderView)
    '    '        Me.PrintAllOrderLookupTableAdapter.Fill(Me.PrintAllOrderDataSet.PrintAllOrderLookup)
    '    '        Dim Orderindex As Integer
    '    '        Orderindex = Me.PrintAllOrderLookupBindingSource.Find("OrderId", OrderId)
    '    '        Me.PrintAllOrderLookupBindingSource.Position = Orderindex

    '    '    End If

    '    'End If

    'End Sub


    'Private Sub ProgramNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.PrintOrderLookupTableAdapter.FillByProgramNo(Me.PrintProductionDataSet.PrintOrderLookup, ProgramNoComboBox.Text)
    'End Sub

    Private Sub PrintProductionBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles PrintProductionBindingSource.AddingNew

        Me.PrintProductionDataSet.PrintProduction.PrintOrderIdColumn.DefaultValue = ColorComboBox.SelectedValue
        Me.PrintProductionDataSet.PrintProduction.PrintProductionDateColumn.DefaultValue = PrintProductionDateTimePicker.Text

    End Sub

    Private Sub PrintProductionDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintProductionDateTimePicker.ValueChanged


    End Sub

    Private Sub PrintProductionBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintProductionBindingSource.PositionChanged, PrintProductionBindingSource.CurrentChanged, PrintProductionBindingSource.CurrentItemChanged

        Dim TTLReceive As Integer = 0
        Dim TTLPrint As Integer = 0
        Dim TTLReject As Integer = 0
        Dim TTLDelivery As Integer = 0

        TTLReceiveLabel.Text = 0
        TTLPrintLabel.Text = 0
        TTLRejectLabel.Text = 0
        TTLDeliveryLabel.Text = 0






        For Each dr As DataRowView In PrintProductionBindingSource


            If IsDBNull(dr!GMReceiveQuantity) = False Then
                TTLReceive = TTLReceive + dr!GMReceiveQuantity
            Else
                TTLReceive = TTLReceive + 0
            End If

            If IsDBNull(dr!GMPrintQuantity) = False Then
                TTLPrint = TTLPrint + dr!GMPrintQuantity
            Else
                TTLPrint = TTLPrint + 0
            End If

            If IsDBNull(dr!GMRejectQuantity) = False Then
                TTLReject = TTLReject + dr!GMRejectQuantity
            Else
                TTLReject = TTLReject + 0
            End If

            If IsDBNull(dr!GMDeliveryQuantity) = False Then
                TTLDelivery = TTLDelivery + dr!GMDeliveryQuantity
            Else
                TTLDelivery = TTLDelivery + 0
            End If



        Next


        TTLReceiveLabel.Text = TTLReceive
        TTLPrintLabel.Text = TTLPrint
        TTLRejectLabel.Text = TTLReject
        TTLDeliveryLabel.Text = TTLDelivery




    End Sub

    'Private Sub ColorComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColorComboBox.LostFocus

    '    On Error Resume Next

    '    If PrintOrderLookupBindingSource.Position > -1 Then

    '        Me.PrintProductionBindingSource.AddNew()

    '    End If

    '    End If

    'End Sub


    Private Sub PrintHourlyProductionBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintHourlyProductionBindingSource.PositionChanged, PrintHourlyProductionBindingSource.CurrentChanged, PrintHourlyProductionBindingSource.CurrentItemChanged

        Dim TTLHOURLYPRINT As Integer = 0


        For Each dr As DataRowView In PrintHourlyProductionBindingSource.List


            If IsDBNull(dr!HT) = False Then
                TTLHOURLYPRINT = TTLHOURLYPRINT + dr!HT
            Else
                TTLHOURLYPRINT = TTLHOURLYPRINT + 0
            End If

        Next



        TTLHOURLYPRINTLABEL.Text = TTLHOURLYPRINT

    End Sub



    Private Sub PrintHourlyProductionDataGridView_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintHourlyProductionDataGridView.Enter
        Me.Validate()
        Me.PrintProductionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrintProductionDataSet)

    End Sub

    Private Sub PrintProductionDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PrintProductionDataGridView.KeyDown

        'If e.KeyData = Keys.F12 Then

        '    Dim Index As Integer = Me.PrintProductionBindingSource.Find("PrintOrderId", Me.ColorComboBox.SelectedValue)
        '    Me.PrintProductionBindingSource.Position = Index


        'End If

        If e.KeyCode = Keys.Insert Then

            If PrintProductionDataGridView.Columns(PrintProductionDataGridView.CurrentCell.ColumnIndex).HeaderText = "TODAY REJECT" Then
                frmCalculator.ShowDialog()
            End If

        End If

    End Sub




    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click

        Me.PrintProductionTableAdapter.FillByProductionDate(Me.PrintProductionDataSet.PrintProduction, PrintProductionDateTimePicker.Text)
        GrandTTLHourlyPrintLabel.Text = ReadData("Select ISNULL(Sum(H1+H2+H3+H4+H5+H6+H7+H8+H9+H10+H11+H12),0) as GMPrintQuantity From PrintHourlyProduction Where PrintProductionId In ( Select PrintProductionId From PrintProduction where PrintProductionDate='" & PrintProductionDateTimePicker.Text & "')", cnn)

    End Sub

    Private Sub filterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterButton.Click
        fltrDate = False
        Label6.Text = "Print Production [ Filtered by Item ]"
        Me.PrintProductionTableAdapter.FillByPrintOrderId(Me.PrintProductionDataSet.PrintProduction, ColorComboBox.SelectedValue)
        GrandTTLHourlyPrintLabel.Text = ReadData("Select ISNULL(Sum(H1+H2+H3+H4+H5+H6+H7+H8+H9+H10+H11+H12),0) as GMPrintQuantity From PrintHourlyProduction Where PrintProductionId In ( Select PrintProductionId From PrintProduction where PrintOrderId=" & ColorComboBox.SelectedValue & ")", cnn)

    End Sub

    Private Sub DateFilterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateFilterButton.Click
        fltrDate = True
        Label6.Text = "Print Production [ Filtered by Date ]"
        Me.PrintProductionTableAdapter.FillByProductionDate(Me.PrintProductionDataSet.PrintProduction, PrintProductionDateTimePicker.Text)
        GrandTTLHourlyPrintLabel.Text = ReadData("Select ISNULL(Sum(H1+H2+H3+H4+H5+H6+H7+H8+H9+H10+H11+H12),0) as GMPrintQuantity From PrintHourlyProduction Where PrintProductionId In ( Select PrintProductionId From PrintProduction where PrintProductionDate='" & PrintProductionDateTimePicker.Text & "')", cnn)

    End Sub



    Private Sub ColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorComboBox.SelectedIndexChanged

    End Sub

    Private Sub PrintOrderNewLookupGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintOrderNewLookupGridLookUpEdit.EditValueChanged
        Me.PrintOrderLookupTableAdapter.FillPrintOrderNewId(Me.PrintProductionDataSet.PrintOrderLookup, PrintOrderNewLookupGridLookUpEdit.EditValue)
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        If PrintOrderLookupBindingSource.Position > -1 Then

            Me.PrintProductionBindingSource.AddNew()

        End If

    End Sub

    Private Sub PrintProductionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PrintProductionDataGridView.CellContentClick

    End Sub

    Private Sub GetSizeLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GetSizeLinkLabel.LinkClicked
        'Getting Size List

        If Me.PrintHourlySizewiseProductionBindingSource.Position > -1 Then
            Exit Sub
        Else

            If Me.PrintHourlyProductionBindingSource.Position = -1 Then
                Me.PrintHourlyProductionBindingSource.AddNew()
            End If

            Try
                Me.Validate()
                Me.PrintProductionBindingSource.EndEdit()
                Me.PrintHourlyProductionBindingSource.EndEdit()
                Me.PrintHourlySizewiseProductionBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.PrintProductionDataSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Dim row As PrintProductionDataSet.PrintProductionRow
            row = CType(CType(Me.PrintProductionBindingSource.Current, DataRowView).Row, PrintProductionDataSet.PrintProductionRow)

            Using connection As New SqlConnection(cnn)

                Dim querystring As String = "Select Distinct SizeId From PrintOrderSizeDetails Where PrintOrderId=" & row.PrintOrderId.ToString()
                Dim command As New SqlCommand(querystring, connection)
                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                Dim row1 As PrintProductionDataSet.PrintHourlyProductionRow
                row1 = CType(CType(Me.PrintHourlyProductionBindingSource.Current, DataRowView).Row, PrintProductionDataSet.PrintHourlyProductionRow)

                While reader.Read()

                    Dim newRow As PrintProductionDataSet.PrintHourlySizewiseProductionRow = Me.PrintProductionDataSet.PrintHourlySizewiseProduction.NewRow()
                    newRow.PrintHourlyProductionId = row1.PrintHourlyProductionId
                    newRow.SizeId = reader("SizeId").ToString
                    newRow.Remarks = "-"
                    Me.PrintProductionDataSet.PrintHourlySizewiseProduction.Rows.Add(newRow)

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


        For Each drv As DataRowView In Me.PrintHourlySizewiseProductionBindingSource.List

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
            'vHX = vHX + drv!HX

        Next

        Dim row As PrintProductionDataSet.PrintHourlyProductionRow
        row = CType(CType(Me.PrintHourlyProductionBindingSource.Current, DataRowView).Row, PrintProductionDataSet.PrintHourlyProductionRow)

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
        'row.HX = vHX


        Dim row3 As PrintProductionDataSet.PrintProductionRow
        row3 = CType(CType(Me.PrintProductionBindingSource.Current, DataRowView).Row, PrintProductionDataSet.PrintProductionRow)

        row3.GMPrintQuantity = row.HT


    End Sub

    Private Sub GetDataButton_Click(sender As Object, e As EventArgs) Handles GetDataButton.Click
        Me.PrintProductionTableAdapter.FillByChallanNo(Me.PrintProductionDataSet.PrintProduction, ChallanNoGridLookUpEdit.EditValue)

        If Me.PrintProductionBindingSource.Position = -1 Then

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("GetPrintProdReceivedFromCDPD", Connection)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ChallanNo", ChallanNoGridLookUpEdit.Text)

                cmd.ExecuteNonQuery()

            End Using

            Me.PrintProductionTableAdapter.FillByChallanNo(Me.PrintProductionDataSet.PrintProduction, ChallanNoGridLookUpEdit.EditValue)


        Else
            MessageBox.Show("Already Received the Challan")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.PrintProductionBindingSource.Position > -1 Then
            Dim row As PrintProductionDataSet.PrintProductionRow
            row = CType(CType(Me.PrintProductionBindingSource.Current, DataRowView).Row, PrintProductionDataSet.PrintProductionRow)
            Me.PrintProdSizewiseInputTableAdapter.Fill(Me.PrintProductionDataSet.PrintProdSizewiseInput, row.PrintProductionId)

        End If
    End Sub
End Class