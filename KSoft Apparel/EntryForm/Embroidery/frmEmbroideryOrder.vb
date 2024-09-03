Imports System.Data.SqlClient

Public Class frmEmbroideryOrder
    Private EODID As Integer
    Dim AddFlag As Boolean = False
    Private _IsOutSide As Boolean
    Public Property IsOutSide() As Boolean
        Get
            Return _IsOutSide
        End Get
        Set(ByVal value As Boolean)
            _IsOutSide = value
        End Set
    End Property


    Private Sub EmbOrderBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Save()

    End Sub

    Private Sub Save()

        Try

            Me.Validate()
            Me.EmbOrderBindingSource.EndEdit()
            Me.EmbOrderDetailsBindingSource.EndEdit()
            Me.EmbOrderSizeDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.EmbOrderDataSet)

            If AddFlag = True Then

                If IsOutSide = False Then
                    Me.EmbOrderLookupTableAdapter.FillByDivAsign(Me.EmbOrderLookupDataSet.EmbOrderLookup, UserId)
                Else
                    Me.EmbOrderLookupTableAdapter.FillByOutSide(Me.EmbOrderLookupDataSet.EmbOrderLookup)
                End If


                Dim row As EmbOrderDataSet.EmbOrderRow
                row = CType(CType(Me.EmbOrderBindingSource.Current, DataRowView).Row, EmbOrderDataSet.EmbOrderRow)

                EmbOrderLookupGridLookUpEdit.EditValue = row.EmbOrderId

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub frmEmbroideryOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.EmbroideryRemarksTableAdapter.Fill(Me.EmbOrderDataSet.EmbroideryRemarks)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

        Me.PrintPartTableAdapter.Fill(Me.PrintPartDataSet.PrintPart)
        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)
        Me.ProgramNoLookupEmbTableAdapter.Fill(Me.ProgramLookupEmbDataSet.ProgramNoLookupEmb)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.EmbOrderSizeDetailsTableAdapter.Fill(Me.EmbOrderDataSet.EmbOrderSizeDetails)
        Me.EmbOrderDetailsTableAdapter.Fill(Me.EmbOrderDataSet.EmbOrderDetails)
        Me.EmbOrderTableAdapter.Fill(Me.EmbOrderDataSet.EmbOrder, EmbOrderLookupGridLookUpEdit.EditValue)
        Me.EmbOrderDataSet.EmbOrder.SupplierIdColumn.DefaultValue = 10004

        If Me.IsOutSide = False Then

            ProgramNoTextEdit.Enabled = False
            StyleNoTextEdit.Enabled = False
            BuyerTextEdit.Enabled = False
            'Me.EmbOrderLookupTableAdapter.FillByDivAsign(Me.EmbOrderLookupDataSet.EmbOrderLookup, UserId)
            Me.EmbOrderLookupTableAdapter.Fill(Me.EmbOrderLookupDataSet.EmbOrderLookup)

            If CheckUserRights("Embroidery Work Order[In-house]").CanEdit = False Then

                NewButton.Enabled = False
                DeleteButton.Enabled = False
                EditButton.Enabled = False

            ElseIf CheckUserRights("Embroidery Work Order[In-house]").CanDelete = False Then

                NewButton.Enabled = True
                DeleteButton.Enabled = False
                EditButton.Enabled = True

            End If




        ElseIf Me.IsOutSide = True Then

            ProgramNoTextEdit.Enabled = True
            StyleNoTextEdit.Enabled = True
            BuyerTextEdit.Enabled = True
            Me.EmbOrderLookupTableAdapter.FillByOutSide(Me.EmbOrderLookupDataSet.EmbOrderLookup)

            If CheckUserRights("Embroidery Work Order[Out-Side]").CanEdit = False Then

                NewButton.Enabled = False
                DeleteButton.Enabled = False
                EditButton.Enabled = False

            ElseIf CheckUserRights("Embroidery Work Order[Out-Side]").CanDelete = False Then

                NewButton.Enabled = True
                DeleteButton.Enabled = False
                EditButton.Enabled = True

            End If


        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetColorButton.Click

        If EmbOrderBindingSource.Position > -1 Then

            Dim row As EmbOrderDataSet.EmbOrderRow
            row = CType(CType(Me.EmbOrderBindingSource.Current, DataRowView).Row, EmbOrderDataSet.EmbOrderRow)

            OrderDetailsByColor(OrderIdGridLookUpEdit.EditValue, PrintPartComboBox.SelectedValue, row.EmbOrderId)

            Save()


        End If

    End Sub

    Private Sub OrderDetailsByColor(ByVal vOrderId As Integer, ByVal vPrintPartId As Integer, ByVal EmbOrID As Integer)

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim sqlstring As String = "Select FabricColorId,TotalOrderQuantity From OrderSummery_Colorwise Where OrderId=" & vOrderId
        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read

            'If reader.IsDBNull(0) = False Then

            On Error Resume Next

            Dim newRow As EmbOrderDataSet.EmbOrderDetailsRow = Me.EmbOrderDataSet.EmbOrderDetails.NewRow()

            newRow.FabricColorId = reader("FabricColorId").ToString
            newRow.PrintPartId = vPrintPartId
            newRow.EmbOrderQuantity = reader("TotalOrderQuantity")
            newRow.EmbType = EmbTypeComboBox.Text
            newRow.EmbOrderId = EmbOrID
            newRow.PricePerDzn = UnitPriceSpinEdit.Value

            Me.EmbOrderDataSet.EmbOrderDetails.Rows.Add(newRow)

            'End If

        End While

        reader.Close()

        connection.Close()

    End Sub


    Private Sub GetSizeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetSizeButton.Click

        If Me.EmbOrderSizeDetailsBindingSource.Position = -1 Then

            For Each drv2 As DataRowView In EmbOrderDetailsBindingSource.List
                OrderSizeDetails(OrderIdGridLookUpEdit.EditValue, drv2!FabricColorId, drv2!EmbOrderDetailsId)
            Next

            Save()

        End If

    End Sub

    Private Sub OrderSizeDetails(ByVal vOrderId As Integer, ByVal vFabricColorId As Integer, ByVal EmbOrderDetailsID As Integer)

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim sqlstring As String = "Select SizeId,TTLOrderQuantity From OrderQuantitySummery_ColorAndSize Where OrderId=" & vOrderId & "And FabricColorId=" & vFabricColorId
        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read

            'If reader.IsDBNull(0) = False Then
            On Error Resume Next
            Dim newRow As EmbOrderDataSet.EmbOrderSizeDetailsRow = Me.EmbOrderDataSet.EmbOrderSizeDetails.NewRow()
            newRow.EmbOrderDetailsId = EmbOrderDetailsID
            newRow.SizeId = reader("Sizeid")
            newRow.EmbOrderQuantity = reader("TTLOrderQuantity")
            Me.EmbOrderDataSet.EmbOrderSizeDetails.Rows.Add(newRow)

            'End If
        End While

        reader.Close()

        connection.Close()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        With frmEmbOrderPrint

            Dim row As EmbOrderDataSet.EmbOrderRow
            row = CType(CType(Me.EmbOrderBindingSource.Current, DataRowView).Row, EmbOrderDataSet.EmbOrderRow)

            .EMBId = row.EmbOrderId
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .Show()


        End With

    End Sub




    Private Sub GetPrgNoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetPrgNoButton.Click

        On Error Resume Next

        Dim PrgNo As String = ReadStringData("Select ProgramNo From [Order] Where OrderId=" & Me.OrderIdGridLookUpEdit.EditValue, cnn)
        Dim StyleNo As String = ReadStringData("Select StyleName From [Style] Where StyleId=(Select StyleId From [Order] Where OrderId=" & Me.OrderIdGridLookUpEdit.EditValue & ")", cnn)
        Dim Buyer As String = ReadStringData("Select BuyerName From [Buyer] Where BuyerId=(Select BuyerId From [Order] Where OrderId=" & Me.OrderIdGridLookUpEdit.EditValue & ")", cnn)

        ProgramNoTextEdit.Text = PrgNo
        StyleNoTextEdit.Text = StyleNo
        BuyerTextEdit.Text = Buyer


    End Sub

    Private Sub CopyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyButton.Click

        If Me.EmbOrderDetailsBindingSource.Position > -1 Then

            Dim row As EmbOrderDataSet.EmbOrderDetailsRow
            row = CType(CType(Me.EmbOrderDetailsBindingSource.Current, DataRowView).Row, EmbOrderDataSet.EmbOrderDetailsRow)

            EODID = row.EmbOrderDetailsId

        End If

    End Sub

    Private Sub PasteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteButton.Click

        On Error Resume Next

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim sqlstring As String = "Select SizeId,EmbOrderQuantity From EmbOrderSizeDetails Where EmbOrderDetailsId=" & EODID
        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        Dim row As EmbOrderDataSet.EmbOrderDetailsRow
        row = CType(CType(Me.EmbOrderDetailsBindingSource.Current, DataRowView).Row, EmbOrderDataSet.EmbOrderDetailsRow)



        While reader.Read

            'If reader.IsDBNull(0) = False Then
            'On Error Resume Next

            Dim newRow As EmbOrderDataSet.EmbOrderSizeDetailsRow = Me.EmbOrderDataSet.EmbOrderSizeDetails.NewRow()

            newRow.EmbOrderDetailsId = row.EmbOrderDetailsId
            newRow.SizeId = reader("Sizeid")
            newRow.EmbOrderQuantity = reader("EmbOrderQuantity")

            Me.EmbOrderDataSet.EmbOrderSizeDetails.Rows.Add(newRow)

            'End If

        End While

        reader.Close()

        connection.Close()


    End Sub

    Private Sub EmbroideryRemarksGridControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbroideryRemarksGridControl.Click

    End Sub

    Private Sub OrderIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderIdGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub EmbOrderSizeDetailsGridControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbOrderSizeDetailsGridControl.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.EmbOrderTableAdapter.Fill(Me.EmbOrderDataSet.EmbOrder, EmbOrderLookupGridLookUpEdit.EditValue)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        With frmEmbOrderPrint

            Dim row As EmbOrderDataSet.EmbOrderRow
            row = CType(CType(Me.EmbOrderBindingSource.Current, DataRowView).Row, EmbOrderDataSet.EmbOrderRow)

            .EMBId = row.EmbOrderId
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .Show()


        End With
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click

        If EditButton.Text = "&Edit" Then

            Me.NewButton.Enabled = False
            Me.DeleteButton.Enabled = False
            Me.EditButton.Text = "&Update"

            AddFlag = True

            Me.EmbOrderBindingSource.AddNew()

            Dim DT As Date = ReadDateData("Select GetDate()", cnn)
            Dim EmbOrNo As String = ""
            Dim ABC As String = DT.Year.ToString.Substring(2) & "EMB"
            Dim XYZ As Integer = ReadIntData("Select Max(CAST(REVERSE(SUBSTRING(REVERSE(EmbOrderNo),0,CHARINDEX('B',REVERSE(EmbOrderNo)))) AS Integer)) From EmbOrder Where EmbOrderNo Like '" & ABC & "%'", cnn)

            EmbOrNo = DT.Year.ToString.Substring(2) & "EMB" & (Val(XYZ) + 1).ToString()

            Me.EMBOrderNoTextEdit.Text = EmbOrNo


        Else
            MessageBox.Show("Your one update task is pending. Please,update first.")
        End If






    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click



        If Me.EditButton.Text = "&Update" Then

            If AddFlag = True Then

                Dim DT As Date = ReadDateData("Select GetDate()", cnn)
                Dim EmbOrNo As String = ""
                Dim ABC As String = DT.Year.ToString.Substring(2) & "EMB"
                Dim XYZ As Integer = ReadIntData("Select Max(CAST(REVERSE(SUBSTRING(REVERSE(EmbOrderNo),0,CHARINDEX('B',REVERSE(EmbOrderNo)))) AS Integer)) From EmbOrder Where EmbOrderNo Like '" & ABC & "%'", cnn)

                EmbOrNo = DT.Year.ToString.Substring(2) & "EMB" & (Val(XYZ) + 1).ToString()

                Me.EMBOrderNoTextEdit.Text = EmbOrNo

            End If

            Save()

            Me.EditButton.Text = "&Edit"
            Me.NewButton.Enabled = True
            Me.DeleteButton.Enabled = True

        Else

            Me.EditButton.Text = "&Update"
            Me.NewButton.Enabled = False
            Me.DeleteButton.Enabled = False

        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If EmbOrderDetailsBindingSource.Position = -1 AndAlso EmbOrderBindingSource.Position > -1 Then
            Me.EmbroideryRemarksBindingSource.RemoveCurrent()
        Else
            MessageBox.Show("Sorry, Not Possible.")
        End If

    End Sub

    Private Sub CancelEntryButton_Click(sender As Object, e As EventArgs) Handles CancelEntryButton.Click

    End Sub

End Class