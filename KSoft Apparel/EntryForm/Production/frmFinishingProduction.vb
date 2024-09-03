Imports System.Data.SqlClient
Imports System.Data
Public Class frmFinishingProduction



    Private Sub frmFinishingProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SewingDeliveryChallanLookupTableAdapter.Fill(Me.SewingDeliveryChallanLookupDataSet.SewingDeliveryChallanLookup)
        Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)
        Me.ShipmentDetailsTableAdapter.Fill(Me.FinishingProductionDataSet.ShipmentDetails)
        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)
        Me.FinishingHourlSizewiseProductionTableAdapter.Fill(Me.FinishingProductionDataSet.FinishingHourlSizewiseProduction)
        Me.FinishingHourlyProductionTableAdapter.Fill(Me.FinishingProductionDataSet.FinishingHourlyProduction)

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Me.OrderPOLookupNewTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupNew)


        'Me.OrderPOTableAdapter.FillByProgramNo(Me.OrderPOLookupDataSet.OrderP0Lookup, ProgramNoGridLookUpEdit.Text)

        'Geting FOB Percentage From Parameter Table
        'Me.FinishingProductionDataSet.FinishingProduction.FFPColumn.DefaultValue = ReadData("Select NumberValue From Parameter Where PrameterId=13", cnn)
        'Me.FinishingProductionDataSet.FinishingProduction.CFPColumn.DefaultValue = ReadData("Select NumberValue From Parameter Where PrameterId=14", cnn)
        'FillFinishingProduction()



        Me.FinishingProductionDataSet.FinishingProduction.IsShipmentColumn.DefaultValue = False
        Me.FinishingProductionDataSet.FinishingProduction.IronQuantityColumn.DefaultValue = 0
        Me.FinishingProductionDataSet.FinishingProduction.HangtagColumn.DefaultValue = 0
        Me.FinishingProductionDataSet.FinishingProduction.ShippedByColumn.DefaultValue = "Sea"

        If CheckUserRights("Finishing Production").CanEdit = False Then

            AddNewButton.Enabled = False
            SaveButton.Enabled = False
        End If

    End Sub

    


   

    'Private Sub ProgramNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoComboBox.SelectedIndexChanged
    '    Me.FinishingProductionDataSet.FinishingProduction.OrderDetailsIdColumn.DefaultValue = POandColorComboBox.SelectedValue
    '    Me.OrderPOTableAdapter.FillByOrderId(Me.OrderPOLookupDataSet.OrderP0Lookup, ProgramNoComboBox.SelectedValue)
    'End Sub

    Private Sub FillFinishingProduction()

        Me.FinishingProductionTableAdapter.FillByBranchAndDate(Me.FinishingProductionDataSet.FinishingProduction, DateTimePicker1.Text, BranchComboBox.SelectedValue, False)

        Me.FinishingProductionDataSet.FinishingProduction.FinishingDateColumn.DefaultValue = DateTimePicker1.Text
        Me.FinishingProductionDataSet.FinishingProduction.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue
        Me.FinishingProductionDataSet.FinishingProduction.OrderDetailsIdColumn.DefaultValue = POandColorComboBox.SelectedValue


    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        FillFinishingProduction()
        RefreshSummery()


    End Sub

    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged

        FillFinishingProduction()
        RefreshSummery()

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        If SaveButton.Text = "&Edit" Then

            If UserId = 1 Then
                DataGridViewTextBoxColumn4.ReadOnly = False
            End If

            SaveButton.Text = "&Save"

            If Me.FinishingProductionBindingSource.Position > -1 Then

                Dim row As FinishingProductionDataSet.FinishingProductionRow
                row = CType(CType(Me.FinishingProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingProductionRow)

                Me.FinishingProductionTableAdapter.FillByFinishingId(Me.FinishingProductionDataSet.FinishingProduction, row.FinishingId)

            End If

        Else

            SaveButton.Text = "&Edit"

            Try

                Me.Validate()
                Me.FinishingProductionBindingSource.EndEdit()
                Me.FinishingHourlyProductionBindingSource.EndEdit()
                Me.FinishingHourlSizewiseProductionBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.FinishingProductionDataSet)

                FillFinishingProduction()

                DataGridViewTextBoxColumn4.ReadOnly = True

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If


    End Sub

    Private Sub RefreshSummery()


        'Go through all row  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        For index As Integer = 1 To FinishingProductionBindingSource.Count


            If FinishingProductionBindingSource.Position + 1 < FinishingProductionBindingSource.Count Then

                FinishingProductionBindingSource.MoveNext()

                ' Otherwise, move back to the first item.
            Else

                FinishingProductionBindingSource.MoveFirst()

            End If


        Next

        FinishingProductionBindingSource.MoveLast()

        'Summery for Grand Total >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Dim vInput As Decimal = 0
        Dim vPoly As Decimal = 0
        Dim vHangTag As Decimal = 0
        Dim vCarton As Decimal = 0
        Dim vShipment As Decimal = 0
        Dim vShipmentCarton As Decimal = 0
       
        InputLabel.Text = 0
        PolyLabel.Text = 0
        HangTagLabel.Text = 0
        CartonLabel.Text = 0
        ShippmentLabel.Text = 0
        ShipmentCartonLabel.Text = 0




        For Each dr As DataRowView In FinishingProductionBindingSource.List

            If IsDBNull(dr!InputQuantity) = False Then
                vInput = vInput + dr!InputQuantity
            End If
            InputLabel.Text = vInput

            If IsDBNull(dr!PolyQuantity) = False Then
                vPoly = vPoly + dr!PolyQuantity

            End If
            PolyLabel.Text = vPoly


            If IsDBNull(dr!HangTag) = False Then
                vHangTag = vHangTag + dr!HangTag

            End If
            HangTagLabel.Text = vHangTag

            If IsDBNull(dr!CartonQuantity) = False Then
                vCarton = vCarton + dr!CartonQuantity
            End If
            CartonLabel.Text = vCarton

            If IsDBNull(dr!ShippmentQuantity) = False Then
                vShipment = vShipment + dr!ShippmentQuantity
            End If

            ShippmentLabel.Text = vShipment


            If IsDBNull(dr!ShippmentCartonQuantity) = False Then
                vShipmentCarton = vShipmentCarton + dr!ShippmentCartonQuantity
            End If

            ShipmentCartonLabel.Text = vShipmentCarton



        Next



    End Sub
    Private Sub CalculateSummery()

        'Calculate Summery >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        If FinishingProductionBindingSource.Position > -1 Then

            On Error Resume Next

            Dim row As FinishingProductionDataSet.FinishingProductionRow
            row = CType(CType(Me.FinishingProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingProductionRow)


            Dim connection As New SqlConnection(cnn)

            connection.Open()

            'If row.IsLineIdNull = False Then

            Dim cmd As SqlCommand = New SqlCommand("Select Sum(ISNULL(InputQuantity,0))As TTLInput,Sum(ISNULL(PolyQuantity,0)) As TTLPoly,Sum(ISNULL(CartonQuantity,0)) As TTLCarton,Sum(ISNULL(ShippmentQuantity,0)) as TTLShippment,Sum(ISNULL(ShippmentCartonQuantity,0)) as TTLShippmentCarton,Sum(ISNULL(IronQuantity,0)) As TTLIron , Sum(ISNULL(HangTag,0)) As HangTag From FinishingProduction where OrderDetailsId=" & row.OrderDetailsId & "and BranchId=" & BranchComboBox.SelectedValue & " and FinishingDate <'" & DateTimePicker1.Text & "'", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            reader.Read()


            If reader.IsDBNull(0) Then
                row.TInput = row.InputQuantity
            Else
                row.TInput = reader.GetDecimal(0) + CDec(row.InputQuantity)
            End If

            If reader.IsDBNull(1) Then
                row.TPoly = row.PolyQuantity
            Else
                row.TPoly = reader.GetDecimal(1) + CDec(row.PolyQuantity)
            End If

            If reader.IsDBNull(2) Then
                row.TCarton = row.CartonQuantity
            Else
                row.TCarton = reader.GetDecimal(2) + CDec(row.CartonQuantity)
            End If

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

            If reader.IsDBNull(5) Then
                row.TIronQuantity = row.IronQuantity
            Else
                row.TIronQuantity = reader.GetInt32(5) + CDec(row.IronQuantity)
            End If

            If reader.IsDBNull(6) Then
                row.THangtag = row.Hangtag
            Else
                row.THangtag = reader.GetInt32(6) + CDec(row.Hangtag)
            End If

        End If


    End Sub

    Private Sub FinishingProductionBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FinishingProductionBindingSource.PositionChanged, FinishingProductionBindingSource.CurrentChanged

        If FinishingProductionBindingSource.Position > -1 Then
            Dim row As FinishingProductionDataSet.FinishingProductionRow
            row = CType(CType(Me.FinishingProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingProductionRow)

            Me.FinishingInputTableAdapter.Fill(Me.FinishingProductionDataSet.FinishingInput, row.FinishingId)
            Dim OID As Integer = ReadIntegerData("Select OrderId From OrderDetails Where OrderDetailsId=" & row.OrderDetailsId, cnn)
            Me.SizeLookupTableAdapter.Fill(Me.SizeLookupDataSet.SizeLookup, OID)
            CalculateSummery()

        End If

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



        CalculateSummery()



    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        With frmDailyFinishingReport
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .FinishingDate = DateTimePicker1.Text
            .BranchId = BranchComboBox.SelectedValue
            .MIS = False
            .Show()
        End With

    End Sub


    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged, ProgramNoGridLookUpEdit.Closed

        If OrderLookupBindingSource.Position > -1 Then

            Me.OrderPOTableAdapter.FillByOrderId(Me.OrderPOLookupDataSet.OrderP0Lookup, ProgramNoGridLookUpEdit.EditValue)

        End If

    End Sub

    Private Sub AddNewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewButton.Click
        Try

            Me.FinishingProductionDataSet.FinishingProduction.OrderDetailsIdColumn.DefaultValue = POandColorComboBox.SelectedValue

            Me.FinishingProductionDataSet.FinishingProduction.FinishingDateColumn.DefaultValue = DateTimePicker1.Text
            Me.FinishingProductionDataSet.FinishingProduction.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue
            Me.FinishingProductionDataSet.FinishingProduction.OrderDetailsIdColumn.DefaultValue = POandColorComboBox.SelectedValue


            Me.FinishingProductionBindingSource.AddNew()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub POandColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POandColorComboBox.SelectedIndexChanged

        On Error Resume Next
        OrderQuantityLabel.Text = "Order Quantity : " & ReadIntegerData("Select Sum(OrderQuantity) From vOrder Where OrderDetailsId=" & POandColorComboBox.SelectedValue, cnn)

    End Sub
    Private Sub Save()

        Me.Validate()
        Me.FinishingProductionBindingSource.EndEdit()
        Me.FinishingHourlyProductionBindingSource.EndEdit()
        Me.FinishingHourlSizewiseProductionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinishingProductionDataSet)

    End Sub
  
    Private Sub FinishingHourlyProductionDataGridView_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingHourlyProductionDataGridView.Enter

        Save()

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub GetSizeLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GetSizeLinkLabel.LinkClicked

        'Getting Size List

        If Me.FinishingHourlSizewiseProductionBindingSource.Position > -1 Then
            Exit Sub
        Else

            If Me.FinishingHourlyProductionBindingSource.Position = -1 Then
                Me.FinishingHourlyProductionBindingSource.AddNew()
            End If

            Try
                Me.Validate()
                Me.FinishingProductionBindingSource.EndEdit()
                Me.FinishingHourlyProductionBindingSource.EndEdit()
                Me.FinishingHourlSizewiseProductionBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.FinishingProductionDataSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

        Dim row As FinishingProductionDataSet.FinishingProductionRow
        row = CType(CType(Me.FinishingProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingProductionRow)

        Using connection As New SqlConnection(cnn)

            Dim querystring As String = "Select SizeId From OrderSizeDetails Where OrderDetailsId=" & row.OrderDetailsId.ToString()
            Dim command As New SqlCommand(querystring, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            Dim row1 As FinishingProductionDataSet.FinishingHourlyProductionRow
            row1 = CType(CType(Me.FinishingHourlyProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingHourlyProductionRow)

            While reader.Read()

                Dim newRow As FinishingProductionDataSet.FinishingHourlSizewiseProductionRow = Me.FinishingProductionDataSet.FinishingHourlSizewiseProduction.NewRow()
                newRow.FinishingHourlyId = row1.FinishingHourlyId
                newRow.SizeId = reader("SizeId").ToString
                newRow.Remarks = "-"
                Me.FinishingProductionDataSet.FinishingHourlSizewiseProduction.Rows.Add(newRow)

            End While


        End Using


    End Sub

  
    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        RefreshSummery()

        If Me.FinishingProductionBindingSource.Position > -1 Then
            Me.FinishingProductionBindingSource.MoveLast()
        End If

        MessageBox.Show("Calculated Successfully")
        Me.ProgramNoGridLookUpEdit.Focus()

    End Sub

    Private Sub FinishingHourlSizewiseProductionBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingHourlSizewiseProductionBindingSource.CurrentChanged

       
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


        For Each drv As DataRowView In Me.FinishingHourlSizewiseProductionBindingSource.List

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

        Dim row As FinishingProductionDataSet.FinishingHourlyProductionRow
        row = CType(CType(Me.FinishingHourlyProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingHourlyProductionRow)

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


        Dim row3 As FinishingProductionDataSet.FinishingProductionRow
        row3 = CType(CType(Me.FinishingProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingProductionRow)

        row3.Hangtag = row.HT

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CalculteSizeQuantity()
    End Sub

    Private Sub GetSizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetSizeButton.Click

        If FinishingProductionBindingSource.Position = -1 Then
            Exit Sub
        End If

        If ShipmentDetailsBindingSource.Position > -1 Then
            Exit Sub
        End If

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

    Private Sub OrderQuantityLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderQuantityLabel.Click

    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged
        On Error Resume Next

        If Me.OrderPOLookupAllBindingSource.Position > -1 Then

            Dim OID As Integer = ReadIntegerData("Select OrderId From OrderDetails Where OrderDetailsId=" & GridLookUpEdit1.EditValue, cnn)
            ProgramNoGridLookUpEdit.EditValue = OID
            POandColorComboBox.SelectedValue = GridLookUpEdit1.EditValue

            OrderQuantityLabel.Text = "Order Quantity : " & ReadIntegerData("Select Sum(OrderQuantity) From vOrder Where OrderDetailsId=" & POandColorComboBox.SelectedValue, cnn)

        End If
    End Sub

    Private Sub FinishingProductionDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles FinishingProductionDataGridView.DataError
        On Error Resume Next

    End Sub

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs)

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Me.FinishingProductionTableAdapter.FillByChallanNo(Me.FinishingProductionDataSet.FinishingProduction, ChallanLookupGridLookUpEdit.EditValue)

        If Me.FinishingProductionBindingSource.Position = -1 Then

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("GetDataFromSewingChallan", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ChallanNo", ChallanLookupGridLookUpEdit.Text)

                cmd.ExecuteNonQuery()

            End Using

            Me.FinishingProductionTableAdapter.FillByChallanNo(Me.FinishingProductionDataSet.FinishingProduction, ChallanLookupGridLookUpEdit.EditValue)

            Dim row As FinishingProductionDataSet.FinishingProductionRow
            row = CType(CType(Me.FinishingProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingProductionRow)

            Me.FinishingInputTableAdapter.Fill(Me.FinishingProductionDataSet.FinishingInput, row.FinishingId)

        Else

            MessageBox.Show("Already Received the Challan")
        End If
    End Sub
End Class

