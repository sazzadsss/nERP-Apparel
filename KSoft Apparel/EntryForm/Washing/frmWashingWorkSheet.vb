Imports System.Data.SqlClient

Public Class frmWashingWorkSheet
    Private AddFlag As Boolean = False
    Private OrderId As Integer
    Private Sub WashingRequestBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WashingRequestBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.WashingRequestBindingSource.EndEdit()
            Me.WashingRequestDetailsBindingSource.EndEdit()
            Me.WashingRequestSizeDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.WashingRequestDataSet)

            MsgBox("successfully Saved")

            If AddFlag = True Then
                Dim row As WashingRequestDataSet.WashingRequestRow
                row = CType(CType(Me.WashingRequestBindingSource.Current, DataRowView).Row, WashingRequestDataSet.WashingRequestRow)
                WashingRequestNoLookUpEdit.EditValue = row.WashingRequestId
            End If

            Me.WashingRequestLookUpTableAdapter.Fill(Me.WashingRequestDataSet.WashingRequestLookUp)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Save()

        Try
            Me.Validate()
            Me.WashingRequestBindingSource.EndEdit()
            Me.WashingRequestDetailsBindingSource.EndEdit()
            Me.WashingRequestSizeDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.WashingRequestDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmWashingWorkSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WashingRequestLookUpTableAdapter.Fill(Me.WashingRequestDataSet.WashingRequestLookUp)
        Me.StyleLookupTableAdapter.Fill(Me.StyleLookupDataSet.StyleLookup)
        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)
        Me.WashTypeMstTableAdapter.Fill(Me.WashTypeDataSet.WashTypeMst)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.WashingRequestSizeDetailsTableAdapter.Fill(Me.WashingRequestDataSet.WashingRequestSizeDetails)
        Me.WashingRequestDetailsTableAdapter.Fill(Me.WashingRequestDataSet.WashingRequestDetails)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

        WashingRequestBindingSource.AddNew()
        Dim ABC As String = Now.Year.ToString.Substring(2) & "W"
        Dim XYZ As Integer = ReadIntData("Select Max(Cast(REVERSE(SUBSTRING(REVERSE(WashingRequestNo),0,CHARINDEX('W',REVERSE(WashingRequestNo))))AS Integer)) From WashingRequest  Where WashingRequestNo Like '" & ABC & "%'", cnn)
        Dim NewOrder As String = Now.Year.ToString.Substring(2) & "W" & (XYZ + 1).ToString("00000")
        WashingRequestNoTextEdit.Text = NewOrder
        WashingRequestDateDateEdit.EditValue = Today

    End Sub

    Private Sub ShowToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripButton.Click
        Me.WashingRequestTableAdapter.FillByRequestId(Me.WashingRequestDataSet.WashingRequest, WashingRequestNoLookUpEdit.EditValue)
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click

        frmWashingWorkSheetReport.WWSID = WashingRequestNoLookUpEdit.EditValue
        ShowForm(frmWashingWorkSheetReport)

    End Sub

    Private Sub GetColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetColorButton.Click
        GetOrderDetailsByColor()
    End Sub

    Private Sub GetOrderDetailsByColor()

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim sqlstring As String = "Select FabricColorId,TotalOrderQuantity From OrderSummery_Colorwise Where ProgramNo='" & ProgramNoTextEdit.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read


            'On Error Resume Next
           
            Dim row As WashingRequestDataSet.WashingRequestRow
            row = CType(CType(Me.WashingRequestBindingSource.Current, DataRowView).Row, WashingRequestDataSet.WashingRequestRow)

            Dim newRow As WashingRequestDataSet.WashingRequestDetailsRow = Me.WashingRequestDataSet.WashingRequestDetails.NewRow()

            newRow.WashingRequestId = row.WashingRequestId
            newRow.FabricColorId = reader("FabricColorId").ToString()
            newRow.FabricColorName = ReadStringData("Select FabricColorName From FabricColor Where FabricColorId=" & reader("FabricColorId").ToString(), cnn)
            newRow.OrderQuantity = reader("TotalOrderQuantity").ToString()
            newRow.Remarks = "-"

            Me.WashingRequestDataSet.WashingRequestDetails.Rows.Add(newRow)


        End While

        reader.Close()

        connection.Close()

    End Sub

    Private Sub GetSizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetSizeButton.Click

        If Me.WashingRequestSizeDetailsBindingSource.Position = -1 Then

            For Each drv2 As DataRowView In WashingRequestDetailsBindingSource.List
                OrderSizeDetails(drv2!FabricColorId, drv2!WashingRequestDetailsId)
            Next

            'Save
        End If


    End Sub

    Private Sub OrderSizeDetails(ByVal vFabricColorId As Integer, ByVal vWashingRequestDetailsId As Integer)

        Dim connection As New SqlConnection(cnn)

        connection.Open()

        Dim sqlstring As String = "Select SizeId,TTLOrderQuantity From OrderQuantitySummery_ColorAndSize Where ProgramNo='" & ProgramNoTextEdit.Text & "' And FabricColorId=" & vFabricColorId
        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection


        Dim row As WashingRequestDataSet.WashingRequestDetailsRow
        row = CType(CType(Me.WashingRequestDetailsBindingSource.Current, DataRowView).Row, WashingRequestDataSet.WashingRequestDetailsRow)


        While reader.Read


            On Error Resume Next

            'If reader.IsDBNull(0) = False Then

            'Dim newRow As PrintOrderNewDataSet.PrintOrderSizeDetailsRow = Me.PrintOrderNewDataSet.PrintOrderSizeDetails.NewRow()
            'newRow.PrintOrderId = vPrintOrderId
            'newRow.SizeId = reader("Sizeid")
            'newRow.OrderQuantity = reader("TTLOrderQuantity")
            'Me.PrintOrderNewDataSet.PrintOrderSizeDetails.Rows.Add(newRow)

            'End If

            Dim newRow As WashingRequestDataSet.WashingRequestSizeDetailsRow = Me.WashingRequestDataSet.WashingRequestSizeDetails.NewRow()

            newRow.WashingRequestDetailsId = vWashingRequestDetailsId
            newRow.SizeId = reader("SizeId").ToString()
            newRow.OrderQuantity = CType(reader("TTLOrderQuantity").ToString(), Integer)

            Me.WashingRequestDataSet.WashingRequestSizeDetails.Rows.Add(newRow)


        End While

        reader.Close()

        connection.Close()

    End Sub

    Private Sub ProgramNoLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ProgramNoLinkLabel.LinkClicked

        ShowMaster(frmWashingProgramLookup)

        If frmWashingProgramLookup.DialogResult = System.Windows.Forms.DialogResult.OK Then

            OrderId = frmWashingProgramLookup.OID

            ProgramNoTextEdit.Text = ReadStringData("Select ProgramNo from [Order] Where OrderId =" & OrderId, cnn)
            StyleIdGridLookUpEdit.EditValue = ReadIntegerData("Select StyleId from [Order] Where OrderId=" & OrderId, cnn)
            BuyerIdGridLookUpEdit.EditValue = ReadIntegerData("Select BuyerId from [Order] Where OrderId=" & OrderId, cnn)
            WashTypeIdGridLookUpEdit.EditValue = ReadIntData("Select WashTypeId from [Order] Where OrderId=" & OrderId, cnn)


        End If
        


    End Sub

    Private Sub StyleIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleIdGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles UnitPriceTextEdit.EditValueChanged

    End Sub
End Class