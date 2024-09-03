Imports System.Data.SqlClient
Imports System.Data
Imports DevExpress.XtraGrid.Columns

Public Class frmShipment

    Private Sub frmShipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CommercialInvoiceLookupByCIIDTableAdapter.Fill(Me.CommercialInvoiceLookUpDataSet.CommercialInvoiceLookupByCIID)
        Me.DeliveryChallanLookUpTableAdapter.Fill(Me.DeliveryChallanLookUpDataSet.DeliveryChallanLookUp)
        Me.CommercialInvoiceTableAdapter.Fill(Me.CommercialInvoiceDataSet.CommercialInvoice)
        Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.ShipmentDetailsTableAdapter.Fill(Me.FinishingProductionDataSet.ShipmentDetails)
        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.BranchComboBox.SelectedValue = 3
        Me.OrderPOLookupNewTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupNew)
        Me.FinishingProductionDataSet.FinishingProduction.IsShipmentColumn.DefaultValue = True
        GetExportDeliveryChallan(ExportDepartmentId)

        If CheckUserRights("Shipment").CanEdit = False Then

            AddNewButton.Enabled = False
            SaveButton.Enabled = False
        End If


    End Sub
    Private Sub GetExportDeliveryChallan(ByVal DptId As Integer)
        Me.DeliveryChallanLookUpTableAdapter.FillByDepartmentId(Me.DeliveryChallanLookUpDataSet.DeliveryChallanLookUp, DptId)

        With ChallanNoGridLookUpEdit
            .Properties.DataSource = DeliveryChallanLookUpBindingSource
            .Properties.DisplayMember = "ChallanNo"
            .Properties.ValueMember = "DeliveryId"
        End With

        Dim col1 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanNo")
        col1.VisibleIndex = 0
        col1.Caption = "Challan No"

        Dim col2 As GridColumn = ChallanNoGridLookUpEdit.Properties.View.Columns.AddField("ChallanDate")
        col2.VisibleIndex = 1
        col2.Caption = "Challan Date"
        ChallanNoGridLookUpEdit.Properties.View.BestFitColumns()
        ChallanNoGridLookUpEdit.Properties.PopupFormWidth = 300
    End Sub
    Private Sub FillFinishingProduction()
        On Error Resume Next

        Me.FinishingProductionTableAdapter.FillByBranchAndDate(Me.FinishingProductionDataSet.FinishingProduction, DateTimePicker2.Text, BranchComboBox.SelectedValue, True)
        Me.FinishingProductionBindingSource.ResetBindings(True)
        Me.FinishingProductionDataSet.FinishingProduction.FinishingDateColumn.DefaultValue = DateTimePicker2.Text
        Me.FinishingProductionDataSet.FinishingProduction.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue
        Me.FinishingProductionDataSet.FinishingProduction.OrderDetailsIdColumn.DefaultValue = POandColorComboBox.SelectedValue


    End Sub



    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged

        FillFinishingProduction()
        'RefreshSummery()

    End Sub
    Private Sub Save()
        Try
            Me.Validate()
            Me.FinishingProductionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FinishingProductionDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim indx As Integer = 0
        indx = Me.FinishingProductionBindingSource.Position
        Save()

        RefreshSummery()

        Save()

        Me.FinishingProductionBindingSource.Position = indx



    End Sub

    Private Sub RefreshSummery()


        'Go through all row  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        FinishingProductionBindingSource.MoveFirst()


        For index As Integer = 1 To FinishingProductionBindingSource.Count

            If FinishingProductionBindingSource.Position + 1 <= FinishingProductionBindingSource.Count Then

                CalculateSummery()
                FinishingProductionBindingSource.MoveNext()

                ' Otherwise, move back to the first item.
                'Else

                '    FinishingProductionBindingSource.MoveFirst()

            End If

        Next

        'FinishingProductionBindingSource.MoveLast()

        'Summery for Grand Total >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Dim vInput As Decimal = 0
        Dim vPoly As Decimal = 0
        Dim vCarton As Decimal = 0
        Dim vShipment As Decimal = 0
        Dim vShipmentCarton As Decimal = 0

        'InputLabel.Text = 0
        PolyLabel2.Text = 0
        'CartonLabel.Text = 0
        ShipmentLabel2.Text = 0
        ShipmentCartonLabel2.Text = 0



        For Each dr As DataRowView In FinishingProductionBindingSource.List

            If IsDBNull(dr!InputQuantity) = False Then
                vInput = vInput + dr!InputQuantity
            End If
            'InputLabel.Text = vInput

            If IsDBNull(dr!PolyQuantity) = False Then
                vPoly = vPoly + dr!PolyQuantity

            End If
            PolyLabel2.Text = vPoly

            If IsDBNull(dr!CartonQuantity) = False Then
                vCarton = vCarton + dr!CartonQuantity
            End If
            'CartonLabel.Text = vCarton

            If IsDBNull(dr!ShippmentQuantity) = False Then
                vShipment = vShipment + dr!ShippmentQuantity
            End If

            ShipmentLabel2.Text = vShipment


            If IsDBNull(dr!ShippmentCartonQuantity) = False Then
                vShipmentCarton = vShipmentCarton + dr!ShippmentCartonQuantity
            End If

            ShipmentCartonLabel2.Text = vShipmentCarton

          
        Next



    End Sub
    Private Sub CalculateSummery()

        'Calculate Summery >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        If FinishingProductionBindingSource.Position > -1 Then

            Dim row As FinishingProductionDataSet.FinishingProductionRow
            row = CType(CType(Me.FinishingProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingProductionRow)

            Dim connection As New SqlConnection(cnn)

            connection.Open()

            'If row.IsLineIdNull = False Then

            Dim cmd As SqlCommand = New SqlCommand("Select ISNULL(Sum(ISNULL(InputQuantity,0)),0) As TTLInput,ISNULL(Sum(ISNULL(PolyQuantity,0)),0) As TTLPoly,ISNULL(Sum(ISNULL(CartonQuantity,0)),0) As TTLCarton,ISNULL(Sum(ISNULL(ShippmentQuantity,0)),0) as TTLShippment,ISNULL(Sum(ShippmentCartonQuantity),0) as TTLShippmentCarton,(Select Top 1 ISNULL(OrderQuantity,0) From vOrder Where vOrder.OrderDetailsId=" & row.OrderDetailsId & ") AS OrderQuantity  From FinishingProduction where OrderDetailsId=" & row.OrderDetailsId & "and BranchId=" & BranchComboBox.SelectedValue & " And FinishingDate <'" & DateTimePicker2.Text & "'", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            reader.Read()


            row.TInput = reader("TTLInput")
            row.TPoly = reader("TTLPoly")
            row.TCarton = reader("TTLCarton")
            row.TShipmentBalance = reader("OrderQuantity") - reader("TTLShippment")


            If reader.IsDBNull(3) Then
                row.TShippment = row.ShippmentQuantity
            Else
                row.TShippment = reader.GetDecimal(3) + CDec(row.ShippmentQuantity)
            End If

            If reader.IsDBNull(4) Then
                row.TShippmentCarton = row.ShippmentCartonQuantity
            Else
                row.TShippmentCarton = reader.GetDecimal(4) + CDec(row.ShippmentCartonQuantity)
            End If

        End If


    End Sub

    Private Sub FinishingProductionBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FinishingProductionBindingSource.PositionChanged, FinishingProductionBindingSource.CurrentChanged

        'If FinishingProductionBindingSource.Position > -1 Then
        '    CalculateSummery()
        '    RefreshSummery()
        'End If

    End Sub


    'Private Sub ProgramNoComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    '    Me.OrderPOTableAdapter.FillByOrderId(Me.OrderPOLookupDataSet.OrderP0Lookup, ProgramNoGridLookUpEdit.Text)

    'End Sub

    Private Sub FinishingProductionDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FinishingProductionDataGridView.CellEndEdit
        'On Error Resume Next
        'If Me.FinishingProductionBindingSource.Position > -1 Then

        '    If FinishingProductionDataGridView.Columns(FinishingProductionDataGridView.CurrentCell.ColumnIndex).HeaderText = "Poly Quantity" Then


        '        Dim row As FinishingProductionDataSet.FinishingProductionRow
        '        row = CType(CType(Me.FinishingProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingProductionRow)


        '        Dim TTLFinInput As Integer = ReadData("Select Sum(InputQuantity)From FinishingProduction Where OrderDetailsId=" & row.OrderDetailsId, cnn)
        '        Dim TTLPoly As Integer = ReadData("Select Sum(PolyQuantity)From FinishingProduction Where OrderDetailsId=" & row.OrderDetailsId, cnn) + FinishingProductionDataGridView.CurrentCell.Value

        '        If TTLPoly > TTLFinInput Then

        '            MessageBox.Show("Excess Poly From Finishing Input doesn't allow.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            FinishingProductionDataGridView.CurrentCell.Value = 0
        '            Exit Sub

        '        End If

        '    ElseIf FinishingProductionDataGridView.Columns(FinishingProductionDataGridView.CurrentCell.ColumnIndex).HeaderText = "Input Quantity" Then
        '        Dim row As FinishingProductionDataSet.FinishingProductionRow
        '        row = CType(CType(Me.FinishingProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingProductionRow)


        '        Dim TTLSewingOutput As Integer = ReadData("Select Sum(OutputQuantity)From SewingProduction Where OrderDetailsId=" & row.OrderDetailsId, cnn)
        '        Dim TTLFinInput As Integer = ReadData("Select Sum(InputQuantity)From FinishingProduction Where OrderDetailsId=" & row.OrderDetailsId, cnn) + FinishingProductionDataGridView.CurrentCell.Value

        '        If TTLFinInput > TTLSewingOutput Then

        '            MessageBox.Show("Excess Input From Sewing Output doesn't allow.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            FinishingProductionDataGridView.CurrentCell.Value = 0
        '            Exit Sub

        '        End If

        '    End If

        'End If



        'CalculateSummery()



    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        With frmShipmentReport
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .Show()
        End With

    End Sub


    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged, ProgramNoGridLookUpEdit.Closed

        If OrderLookupBindingSource.Position > -1 Then

            Me.OrderPOTableAdapter.FillByProgramNo(Me.OrderPOLookupDataSet.OrderP0Lookup, ProgramNoGridLookUpEdit.Text)

        End If

    End Sub

    Private Sub AddNewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewButton.Click

        Try

            With Me.FinishingProductionDataSet.FinishingProduction

                .OrderDetailsIdColumn.DefaultValue = POandColorComboBox.SelectedValue
                .FinishingDateColumn.DefaultValue = DateTimePicker2.Text
                .BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue
                .OrderDetailsIdColumn.DefaultValue = POandColorComboBox.SelectedValue
                .ChallanNoColumn.DefaultValue = ChallanNoGridLookUpEdit.EditValue
                .ChallanDateColumn.DefaultValue = ChallanDateTimePicker.Text
                .VichleNoColumn.DefaultValue = VehicleTextBox.Text
                .LogNoColumn.DefaultValue = LogNoTextBox.Text
                .CommercialInvoieIdColumn.DefaultValue = ComInvGridLookUpEdit.EditValue


            End With


            Me.FinishingProductionBindingSource.AddNew()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub POandColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POandColorComboBox.SelectedIndexChanged

        On Error Resume Next
        OrderQuantityLabel.Text = "Order Quantity : " & ReadIntegerData("Select Sum(OrderQuantity) From vOrder Where OrderDetailsId=" & POandColorComboBox.SelectedValue, cnn)

    End Sub


    
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click

        RefreshSummery()


        Me.ProgramNoGridLookUpEdit.Focus()

        If Me.FinishingProductionBindingSource.Position > -1 Then
            Me.FinishingProductionBindingSource.MoveLast()
        End If

        MessageBox.Show("Calculated Successfully")

    End Sub

    Private Sub FinishingHourlSizewiseProductionBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    

    
    Private Sub GetSizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetSizeButton.Click

        If FinishingProductionBindingSource.Position = -1 Then
            Exit Sub
        End If

        If ShipmentDetailsBindingSource.Position > -1 Then
            Exit Sub
        End If

        Save()

        Dim row As FinishingProductionDataSet.FinishingProductionRow
        row = CType(CType(Me.FinishingProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingProductionRow)

        Using connection As New SqlConnection(cnn)

            Dim querystring As String = "Select SizeId,OrderQuantity From OrderSizeDetails Where OrderDetailsId=" & row.OrderDetailsId.ToString()
            Dim command As New SqlCommand(querystring, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()

                Dim newRow As FinishingProductionDataSet.ShipmentDetailsRow = Me.FinishingProductionDataSet.ShipmentDetails.NewRow()
                newRow.FinishingId = row.FinishingId
                newRow.SizeId = reader("SizeId").ToString
                newRow.ShipmentQuantity = 0
                newRow.OrderQuantity = reader("OrderQuantity")
                newRow.ShipmentQuantity = reader("OrderQuantity")
                Me.FinishingProductionDataSet.ShipmentDetails.Rows.Add(newRow)

            End While

            reader.Close()

        End Using

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Me.FinishingProductionDataSet.FinishingProduction.FinishingDateColumn.DefaultValue = DateTimePicker2.Text
        FillFinishingProduction()
        'RefreshSummery()


    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged
        On Error Resume Next


        If Me.OrderPOLookupAllBindingSource.Position > -1 Then

            Dim OID As Integer = ReadIntegerData("Select OrderId From OrderDetails Where OrderDetailsId=" & GridLookUpEdit1.EditValue, cnn)
            ProgramNoGridLookUpEdit.EditValue = OID
            POandColorComboBox.SelectedValue = GridLookUpEdit1.EditValue

            OrderQuantityLabel.Text = "Order Quantity : " & ReadIntegerData("Select Sum(OrderQuantity) From vOrder Where OrderDetailsId=" & POandColorComboBox.SelectedValue, cnn)
            'Me.CommercialInvoiceTableAdapter.FillByOrderDetailsId(Me.CommercialInvoiceDataSet.CommercialInvoice, GridLookUpEdit1.EditValue)
            Me.CommercialInvoiceLookupByPOTableAdapter.Fill(Me.CommercialInvoiceLookUpDataSet.CommercialInvoiceLookupByPO, GridLookUpEdit1.EditValue)
        End If

    End Sub

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs)

    End Sub

    Private Sub ChallanNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChallanNoGridLookUpEdit.EditValueChanged, ChallanNoGridLookUpEdit.Closed
        Dim connection As New SqlConnection(cnn)

        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select TOP (1) ChallanDate,VehicleNo,LockNo From GeneralGatePass Where ChallanNo='" & ChallanNoGridLookUpEdit.Text & "'", connection)
        Dim OrderDetailsId As Integer = ReadIntegerData("Select OrderDetailsId from DeliveryDetails Where DeliveryId = '" & ChallanNoGridLookUpEdit.EditValue & "'", cnn)
        ' Dim ComInvNo As String = ReadStringData("Select CommercialInvoiceNo from CommercialInvoiceMain Where CommercialInvoiceMainId = (select CommercialInvoiceMainId from CommercialInvoice Where OrderDetailsId = '" & OrderDetailsId & "')", cnn)
        'ComInvGridLookUpEdit.EditValue = ComInvNo

        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
            On Error Resume Next
        While reader.Read
            ChallanDateTimePicker.Value = reader("ChallanDate")
            VehicleTextBox.Text = reader("VehicleNo").ToString()
            LogNoTextBox.Text = reader("LockNo").ToString()
        End While

            reader.Close()
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select * From DeliveryDetails Where DeliveryId = " & ChallanNoGridLookUpEdit.EditValue, connection)
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()

        While reader.Read()

            Dim newRow As FinishingProductionDataSet.FinishingProductionRow = Me.FinishingProductionDataSet.FinishingProduction.NewRow()

            On Error Resume Next
            newRow.ChallanNo = ChallanNoGridLookUpEdit.Text
            newRow.BranchId = BranchComboBox.SelectedValue
            newRow.ChallanDate = ChallanDateTimePicker.Value
            newRow.VichleNo = VehicleTextBox.Text
            newRow.LogNo = LogNoTextBox.Text
            newRow.FinishingDate = DateTimePicker2.Text
            newRow.CommercialInvoieId = reader("CommercialInvoiceId").ToString() 'ReadIntegerData("Select Top (1) CommercialInvoiceId From DeliveryDetails Where OrderDetailsId=" & reader("OrderDetailsId").ToString(), cnn)
            newRow.SupplierId = ReadIntegerData("Select SupplierId from Delivery where DeliveryId = " & ChallanNoGridLookUpEdit.EditValue, cnn)
            newRow.OrderDetailsId = reader("OrderDetailsId").ToString()
            newRow.ShippmentQuantity = reader("DeliveryQuantity").ToString()
            newRow.ShippmentCartonQuantity = reader("NoOfCarton").ToString()
            newRow.Remarks = reader("Remarks").ToString()
            newRow.ShippedBy = ReadStringData("Select ShippedBy from Delivery where DeliveryId = " & ChallanNoGridLookUpEdit.EditValue, cnn)



            Me.FinishingProductionDataSet.FinishingProduction.Rows.Add(newRow)



        End While

        reader.Close()
        connection.Close()

    End Sub

    Private Sub FinishingProductionDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles FinishingProductionDataGridView.DataError
        On Error Resume Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FillFinishingProduction()
    End Sub
End Class