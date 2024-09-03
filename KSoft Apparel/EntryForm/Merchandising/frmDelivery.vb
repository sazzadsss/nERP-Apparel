Imports System.Data.SqlClient
Imports KSoft_Apparel.cValue
Public Class frmDelivery
    Dim Addflag As Boolean = False

    Private Sub BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSaveItem.Click

        If PrintCount(Me.ChallanNoTextBox.Text, True) > 0 Then
            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to save a already printed challan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If
        End If
Line1:
        Try
            Me.Validate()
            Me.DeliveryBindingSource.EndEdit()
            Me.DeliveryDetailsBindingSource1.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DeliveryDataSet)

            Dim row As DeliveryDataSet.DeliveryRow
            row = CType(CType(Me.DeliveryBindingSource.Current, DataRowView).Row, DeliveryDataSet.DeliveryRow)


            If Addflag = True Then
                Me.DeliveryChallanLookUpTableAdapter.Fill(Me.DeliveryChallanLookUpDataSet.DeliveryChallanLookUp)
                Me.ChallanNoGridLookUpEdit.EditValue = row.DeliveryId
            End If

            Addflag = False

            DelSummmery()


            Me.Validate()
            Me.DeliveryBindingSource.EndEdit()
            Me.DeliveryDetailsBindingSource1.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DeliveryDataSet)

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("InsertShipmentInfoFromDelChallan", Connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ChallanNo", row.ChallanNo)
                cmd.ExecuteNonQuery()

            End Using

            For Each drv As DataRowView In Me.DeliveryDetailsBindingSource1.List
                UpdatePOClose(drv!OrderDetailsId)
            Next

            MessageBox.Show("Saved Successfully.")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub UpdatePOClose(ByVal ODID As Integer)
        Using Connection As New SqlConnection(cnn)

            Connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("UpdatePOClose", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ODID", ODID)
            cmd.ExecuteNonQuery()

        End Using
    End Sub
    Private Sub Save()

        If PrintCount(Me.ChallanNoTextBox.Text, True) > 0 Then

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to save a already printed challan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If

        End If
Line1:
        Try


            Me.Validate()
            Me.DeliveryBindingSource.EndEdit()
            Me.DeliveryDetailsBindingSource1.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DeliveryDataSet)


            If Addflag = True Then

                Me.DeliveryChallanLookUpTableAdapter.Fill(Me.DeliveryChallanLookUpDataSet.DeliveryChallanLookUp)
                Dim row As DeliveryDataSet.DeliveryRow
                row = CType(CType(Me.DeliveryBindingSource.Current, DataRowView).Row, DeliveryDataSet.DeliveryRow)
                Me.ChallanNoGridLookUpEdit.EditValue = row.DeliveryId

            End If


            Addflag = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DeliveryDataSet.DeliverySizeDetails' table. You can move, or remove it, as needed.
        Me.DeliverySizeDetailsTableAdapter.Fill(Me.DeliveryDataSet.DeliverySizeDetails)

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Me.CommercialInvoiceLookupByCIIDTableAdapter.Fill(Me.CommercialInvoiceLookUpDataSet.CommercialInvoiceLookupByCIID)

        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)
        Me.DeliveryDetailsTableAdapter.Fill(Me.DeliveryDataSet.DeliveryDetails)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.DeliveryChallanLookUpTableAdapter.FillByDepartmentId(Me.DeliveryChallanLookUpDataSet.DeliveryChallanLookUp, ExportDepartmentId)
        Me.DeliveryDataSet.Delivery.DepartmentIdColumn.DefaultValue = ExportDepartmentId
        Me.DeliveryDataSet.Delivery.DollarValueColumn.DefaultValue = ReadData("Select NumberValue From Parameter Where PrameterName='Dollar'", cnn)

        If CheckUserRights("Shipment Delivery Challan").CanEdit = False Then

            SaveButton.Enabled = False
            DeleteButton.Enabled = False
            BindingNavigatorAddNewItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
            BindingNavigatorSaveItem.Enabled = False

        ElseIf CheckUserRights("Shipment Delivery Challan").CanDelete = False Then

            SaveButton.Enabled = True
            DeleteButton.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub


    Private Sub BindingNavigatorAddNewItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        Me.DeliveryBindingSource.AddNew()
        Dim ABC As String = Now.Year.ToString.Substring(2) & "EDC"
        Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0,CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From Delivery Where ChallanNo Like '" & ABC & "%'", cnn)

        Me.ChallanNoTextBox.Text = Now.Year.ToString.Substring(2) & "EDC" & (Val(XYZ) + 1).ToString()
        Me.ChallanDateDateTimePicker.Text = Today()

        Addflag = True
    End Sub


    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        Me.DeliveryTableAdapter.FillByDepartmentId(Me.DeliveryDataSet.Delivery, Me.ChallanNoGridLookUpEdit.EditValue)
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        frmShipmentDeliveryChallanPrint.SDID = Me.ChallanNoGridLookUpEdit.EditValue
        ShowForm(frmShipmentDeliveryChallanPrint)
    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged
        On Error Resume Next

        If Me.OrderPOLookupAllBindingSource.Position > -1 Then
            Me.CommercialInvoiceLookupByPOTableAdapter.Fill(Me.CommercialInvoiceLookUpDataSet.CommercialInvoiceLookupByPO, GridLookUpEdit1.EditValue)
        End If
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        If Me.DeliveryBindingSource.Position > -1 Then

            Dim row As DeliveryDataSet.DeliveryRow
            row = CType(CType(Me.DeliveryBindingSource.Current, DataRowView).Row, DeliveryDataSet.DeliveryRow)
            Dim newRow As DeliveryDataSet.DeliveryDetailsRow = Me.DeliveryDataSet.DeliveryDetails.NewRow()

            newRow.DeliveryId = row.DeliveryId
            newRow.OrderDetailsId = GridLookUpEdit1.EditValue
            newRow.DestinationCode = DestinationCodeTextBox.Text
            newRow.CommercialInvoiceId = ComInvGridLookUpEdit.EditValue
            newRow.NoOfCarton = CartonQTYTextBox.Text
            newRow.DeliveryQuantity = PieceQTYTextBox.Text
            newRow.UnitId = UnitIdGridLookUpEdit.EditValue
            newRow.Remarks = RemarksDetailsTextBox.Text


            Me.DeliveryDataSet.DeliveryDetails.Rows.Add(newRow)

        End If


    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        DeliveryDetailsBindingSource1.RemoveCurrent()
    End Sub

    Private Sub GetSizeButton_Click(sender As Object, e As EventArgs) Handles GetSizeButton.Click


        If Me.DeliveryBindingSource.Position = -1 Then
            Exit Sub
        End If

        If Me.DeliveryDetailsBindingSource1.Position = -1 Then
            Exit Sub
        End If

        If Me.DeliverySizeDetailsBindingSource.Position > -1 Then
            Exit Sub
        End If

        'Save()

        Dim row As DeliveryDataSet.DeliveryDetailsRow
        row = CType(CType(Me.DeliveryDetailsBindingSource1.Current, DataRowView).Row, DeliveryDataSet.DeliveryDetailsRow)

        Using connection As New SqlConnection(cnn)

            Dim querystring As String = "Select SizeId,OrderQuantity From OrderSizeDetails Where OrderDetailsId=" & row.OrderDetailsId.ToString()
            Dim command As New SqlCommand(querystring, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()

                Dim newRow As DeliveryDataSet.DeliverySizeDetailsRow = Me.DeliveryDataSet.DeliverySizeDetails.NewRow()

                newRow.DeliveryDetailsId = row.DeliveryDetailsId
                newRow.SizeId = reader("SizeId").ToString
                newRow.DeliveryQuantity = reader("OrderQuantity")
                newRow.OrderQuantity = reader("OrderQuantity")

                Me.DeliveryDataSet.DeliverySizeDetails.Rows.Add(newRow)

            End While

            reader.Close()

        End Using


    End Sub

    Private Sub DeliveryDetailsBindingSource1_PositionChanged(sender As Object, e As EventArgs) Handles DeliveryDetailsBindingSource1.PositionChanged

        On Error Resume Next

        Dim row As DeliveryDataSet.DeliveryDetailsRow
        row = CType(CType(Me.DeliveryDetailsBindingSource1.Current, DataRowView).Row, DeliveryDataSet.DeliveryDetailsRow)

        Dim OID As Integer = ReadIntegerData("Select OrderId From OrderDetails Where OrderDetailsId=" & row.OrderDetailsId, cnn)

        Me.SizeLookupTableAdapter.Fill(Me.SizeLookupDataSet.SizeLookup, OID)

        row.DeliveryQuantity = 0

        For Each drv2 As DataRowView In DeliverySizeDetailsBindingSource.List
            row.DeliveryQuantity = row.DeliveryQuantity + drv2!DeliveryQuantity
        Next

    End Sub

    Private Sub DelSummmery()


        For index As Integer = 0 To DeliveryDetailsBindingSource1.Count - 1


            If DeliveryDetailsBindingSource1.Position < DeliveryDetailsBindingSource1.Count - 1 Then

                DeliveryDetailsBindingSource1.MoveNext()


                ' Otherwise, move back to the first item.
            Else

                DeliveryDetailsBindingSource1.MoveFirst()

                Dim row As DeliveryDataSet.DeliveryDetailsRow
                row = CType(CType(Me.DeliveryDetailsBindingSource1.Current, DataRowView).Row, DeliveryDataSet.DeliveryDetailsRow)

                row.DeliveryQuantity = 0

                For Each drv2 As DataRowView In DeliverySizeDetailsBindingSource.List
                    row.DeliveryQuantity = row.DeliveryQuantity + drv2!DeliveryQuantity
                Next

            End If


        Next



    End Sub

    Private Sub DeliverySizeDetailsGridControl_Click(sender As Object, e As EventArgs) Handles DeliverySizeDetailsGridControl.Click

    End Sub
End Class