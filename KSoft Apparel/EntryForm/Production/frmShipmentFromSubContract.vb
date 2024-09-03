Imports System.Data
Imports System.Data.SqlClient

Public Class frmShipmentFromSubContract

    Private Sub frmShipmentFromSubContract_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Me.OrderPOLookupNewTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupNew)
        Me.OrderPOTableAdapter.FillByOrderId(Me.OrderPOLookupDataSet.OrderP0Lookup, ProgramNoComboBox.SelectedValue)


        FillFinishingProduction()

        'If BranchBindingSource.Position > -1 Then

        '    Dim Indx As Integer = Me.BranchBindingSource.Find("BranchId", 14)
        '    Me.BranchBindingSource.Position = Indx

        'End If
        Me.FinishingProductionDataSet.FinishingProduction.IsShipmentColumn.DefaultValue = False


    End Sub
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


        'Summery for Grand Total >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Dim vInput As Decimal = 0
        Dim vPoly As Decimal = 0
        Dim vCarton As Decimal = 0
        Dim vShipment As Decimal = 0
        Dim vShipmentCarton As Decimal = 0

        InputLabel.Text = 0
        PolyLabel.Text = 0
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

    Private Sub ProgramNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoComboBox.SelectedIndexChanged

        Me.FinishingProductionDataSet.FinishingProduction.OrderDetailsIdColumn.DefaultValue = POandColorComboBox.SelectedValue
        Me.OrderPOTableAdapter.FillByOrderId(Me.OrderPOLookupDataSet.OrderP0Lookup, ProgramNoComboBox.SelectedValue)

    End Sub

    Private Sub POandColorComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles POandColorComboBox.LostFocus

        Try

            Me.FinishingProductionDataSet.FinishingProduction.OrderDetailsIdColumn.DefaultValue = POandColorComboBox.SelectedValue
            Me.FinishingProductionBindingSource.AddNew()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub POandColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POandColorComboBox.SelectedIndexChanged

        Me.FinishingProductionDataSet.FinishingProduction.OrderDetailsIdColumn.DefaultValue = POandColorComboBox.SelectedValue

        'On Error Resume Next
        OrderQuantityLabel.Text = "Order Quantity :" & ReadIntegerData("Select OrderQuantity From vOrder where OrderDetailsId = " & Val(POandColorComboBox.SelectedValue), cnn)

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        RefreshSummery()

        Me.Validate()
        Me.FinishingProductionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinishingProductionDataSet)

        Me.ProgramNoComboBox.Focus()

    End Sub

    Private Sub FinishingProductionDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FinishingProductionDataGridView.CellEndEdit
        CalculateSummery()
    End Sub
    Private Sub CalculateSummery()

        'Calculate Summery >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        If FinishingProductionBindingSource.Position > -1 Then


            Dim row As FinishingProductionDataSet.FinishingProductionRow
            row = CType(CType(Me.FinishingProductionBindingSource.Current, DataRowView).Row, FinishingProductionDataSet.FinishingProductionRow)


            Dim connection As New SqlConnection(cnn)

            connection.Open()

            'If row.IsLineIdNull = False Then

            Dim cmd As SqlCommand = New SqlCommand("Select Sum(InputQuantity)As TTLInput,Sum(PolyQuantity) As TTLPoly,Sum(CartonQuantity) As TTLCarton,Sum(ShippmentQuantity) as TTLShippment,Sum(ShippmentCartonQuantity) as TTLShippmentCarton From FinishingProduction where OrderDetailsId=" & row.OrderDetailsId & "and BranchId=" & BranchComboBox.SelectedValue & " and FinishingDate<'" & DateTimePicker1.Text & "'", connection)
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

        End If


    End Sub

    Private Sub FinishingProductionBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FinishingProductionBindingSource.PositionChanged, FinishingProductionBindingSource.CurrentChanged
        CalculateSummery()
    End Sub
End Class