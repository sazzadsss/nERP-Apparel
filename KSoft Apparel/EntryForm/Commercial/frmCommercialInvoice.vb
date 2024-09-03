Imports System.Data.SqlClient
Public Class frmCommercialInvoice
    Private Addflag As Boolean = False
    Private CID As Integer
    Private Sub CommercialInvoiceBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommercialInvoiceBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CommercialInvoiceMainBindingSource.EndEdit()
            'Me.CommercialInvoiceBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CommercialInvoiceDataSet)

            If Addflag = True Then
                Me.CommercialInvoiceLookUpTableAdapter.Fill(Me.CommercialInvoiceLookUpDataSet.CommercialInvoiceLookUp)
                Dim row As CommercialInvoiceDataSet.CommercialInvoiceMainRow
                row = CType(CType(Me.CommercialInvoiceMainBindingSource.Current, DataRowView).Row, CommercialInvoiceDataSet.CommercialInvoiceMainRow)

                Me.InvoiceNoGridLookUpEdit.EditValue = row.CommercialInvoiceMainId
            End If

            Addflag = False
        Catch ex As Exception
            MessageBox.Show(ex.Message )
        End Try
       

    End Sub

    Private Sub frmCommercialInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.MasterOrderLookUpTableAdapter.Fill(Me.MasterOrderLookUpDataSet.MasterOrderLookUp)
        Me.CommercialInvoiceBreakDownTableAdapter.Fill(Me.CommercialInvoiceDataSet.CommercialInvoiceBreakDown)
        Me.MasterLCLookupTableAdapter.Fill(Me.MasterLCDataSet.MasterLCLookup)
        Me.CommercialInvoiceLookUpTableAdapter.Fill(Me.CommercialInvoiceLookUpDataSet.CommercialInvoiceLookUp)
        Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)
        Me.CommercialInvoiceTableAdapter.Fill(Me.CommercialInvoiceDataSet.CommercialInvoice)

        If CheckUserRights("Commercial Invoice").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
            CommercialInvoiceBindingNavigatorSaveItem.Enabled = False

        ElseIf CheckUserRights("Commercial Invoice").CanDelete = False Then

            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False
            CommercialInvoiceBindingNavigatorSaveItem.Enabled = True

        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.CommercialInvoiceDataSet.CommercialInvoice.InputDateColumn.DefaultValue = Today()
        Addflag = True
    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        Me.CommercialInvoiceMainTableAdapter.FillByCommercialInvoiceMainId(Me.CommercialInvoiceDataSet.CommercialInvoiceMain, InvoiceNoGridLookUpEdit.EditValue)
        'Me.CommercialInvoiceTableAdapter.FillByCommercialInvoiceMainId(Me.CommercialInvoiceDataSet.CommercialInvoice, InvoiceNoGridLookUpEdit.EditValue)
        CID = InvoiceNoGridLookUpEdit.EditValue
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        frmCommercialInvoicePrint.CIID = Me.InvoiceNoGridLookUpEdit.EditValue
        ShowForm(frmCommercialInvoicePrint)
    End Sub

    Private Sub GetDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetDataButton.Click

        Dim connection As New SqlConnection(cnn)

        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select * From CommercialInvoiceMain Where CommercialInvoiceMainId = " & InvoiceNoGridLookUpEdit.EditValue, connection)
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()


        While reader.Read

            On Error Resume Next

            CommercialInvoiceDateDateTimePicker.Text = reader("CommercialInvoiceDate")
            RemarksTextBox.Text = reader("Remarks").ToString()
            ConsigneeMemoEdit.EditValue = reader("Consignee").ToString()
            ShipperMemoEdit.EditValue = reader("Shipper").ToString()
            AccountMemoEdit.EditValue = reader("Account").ToString()
            NotifyMemoEdit.EditValue = reader("Notify").ToString()
            ExpNoTextBox.Text = reader("ExpNo").ToString()
            ExpDateDateTimePicker.Text = reader("ExpDate")
            ExportCountNoTextBox.Text = reader("ExportCountNo").ToString()
            ExportCountDateDateTimePicker.Text = reader("ExportCountDate").ToString
            ShippingMarksFrontMemoEdit.EditValue = reader("ShippingMarksFront").ToString()
            ShippingMarksSideMemoEdit.EditValue = reader("ShippingMarksSide").ToString()
            BillNoTextBox.Text = reader("BillNo").ToString()
            BillDateDateTimePicker.Text = reader("BillDate").ToString()
            ERCNoTextBox.Text = reader("ERCNo").ToString()
            ERCDateDateTimePicker.Text = reader("ERCDate").ToString()
            SupplierRefNoTextBox.Text = reader("SupplierRefNo").ToString()
            TotalNetWeightTextBox.Text = reader("TotalNetWeight").ToString()
            TotalGrossWeightTextBox.Text = reader("TotalGrossWeight").ToString()
            CartonMeasurementTextBox.Text = reader("CartonMeasurement").ToString()
            PrecarriageByTextBox.Text = reader("PrecarriageBy").ToString()
            ContainerNoTextBox.Text = reader("ContainerNo").ToString()
            ShipmentByComboBox.Text = reader("ShipmentBy").ToString()
            ShipmentFromTextBox.Text = reader("ShipmentFrom").ToString()
            ShipmentToTextBox.Text = reader("ShipmentTo").ToString()
            HSCodeTextBox.Text = reader("HSCode").ToString()     

        End While

        reader.Close()
        connection.Close()
    End Sub

End Class