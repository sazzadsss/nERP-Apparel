Imports System.Data.SqlClient

Public Class frmPrintOrderNew
    Dim AddFlag As Boolean = False
    Dim DelFlag As Boolean = False
    Private _IsGMT As Boolean
    Public Property IsGMT() As Boolean
        Get
            Return _IsGMT
        End Get
        Set(ByVal value As Boolean)
            _IsGMT = value
        End Set
    End Property


    Private Sub Save()

        Try

            'If ProgramNoTextBox.Text = String.Empty Then
            '    ErrorProvider1.SetError(OrderIdGridLookUpEdit, "Program No Require")
            '    Exit Sub
            'End If

            Me.Validate()
            Me.PrintOrderNewBindingSource.EndEdit()
            Me.PrintOrderDetailsBindingSource.EndEdit()
            Me.PrintOrderSizeDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrintOrderNewDataSet)



            If AddFlag = True Then

                If Me.IsGMT = True Then
                    'Me.PrintOrderNewLookupTableAdapter.FillByDivAsign(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup, UserId)
                    Me.PrintOrderNewLookupTableAdapter.Fill(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)
                Else
                    Me.PrintOrderNewLookupTableAdapter.FillByOutSide(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)
                End If


                Dim row As PrintOrderNewDataSet.PrintOrderNewRow
                row = CType(CType(Me.PrintOrderNewBindingSource.Current, DataRowView).Row, PrintOrderNewDataSet.PrintOrderNewRow)

                PrintOrderNewLookupGridLookUpEdit.EditValue = row.PrintOrderNewId

            End If

            If DelFlag = True Then
                If Me.IsGMT = True Then
                    'Me.PrintOrderNewLookupTableAdapter.FillByDivAsign(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup, UserId)
                    Me.PrintOrderNewLookupTableAdapter.FillByDivAsign(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup, UserId)
                Else
                    Me.PrintOrderNewLookupTableAdapter.FillByOutSide(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)
                End If

            End If

            AddFlag = False
            DelFlag = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmPrintOrderNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)
        Me.PrintOrderNewRemarksTableAdapter.Fill(Me.PrintOrderNewDataSet.PrintOrderNewRemarks)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)

        If Me.IsGMT = True Then
            Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
            'Me.PrintOrderNewLookupTableAdapter.FillByDivAsign(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup, UserId)
            Me.PrintOrderNewLookupTableAdapter.Fill(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)
        Else
            Me.PrintOrderNewLookupTableAdapter.FillByOutSide(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)
        End If

        If UserId = 1 Then
            Me.PrintOrderNewLookupTableAdapter.Fill(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)
        End If

        Me.StyleLookupTableAdapter.Fill(Me.StyleLookupDataSet.StyleLookup)
        'Me.SizeLookupTableAdapter.FillByAll(Me.SizeLookupDataSet.SizeLookup)
        Me.PrintTypeTableAdapter.Fill(Me.PrintTypeDataSet.PrintType)
        Me.PrintPartTableAdapter.Fill(Me.PrintPartDataSet.PrintPart)
        'Me.OrderLookupTableAdapter.FillByPrint(Me.OrderLookupDataSet.OrderLookup)


        Me.PrintOrderSizeDetailsTableAdapter.Fill(Me.PrintOrderNewDataSet.PrintOrderSizeDetails)
        Me.PrintOrderTableAdapter.Fill(Me.PrintOrderNewDataSet.PrintOrder)
        Me.PrintOrderDetailsTableAdapter.Fill(Me.PrintOrderNewDataSet.PrintOrderDetails)
        'Me.PrintOrderNewTableAdapter.FillByGMT(Me.PrintOrderNewDataSet.PrintOrderNew, Me.IsGMT)

        Me.PrintOrderNewDataSet.PrintOrderNew.IsGMTColumn.DefaultValue = Me.IsGMT
        Me.PrintOrderNewDataSet.PrintOrderNew.SupplierIdColumn.DefaultValue = 10004


        If Me.IsGMT Then

            OrderIdGridLookUpEdit.Enabled = True
            StyleIdGridLookUpEdit.Enabled = False
            ProgramNoTextBox.Enabled = False
            StyleNameTextBox.Enabled = False

            If CheckUserRights("Print Order Garments").CanEdit = False Then

                NewButton.Enabled = False
                EditButton.Enabled = False
                DeleteButton.Enabled = False
                GetColorButton.Enabled = False
                GetSizeButton.Enabled = False

            ElseIf CheckUserRights("Print Order Garments").CanDelete = False Then
                NewButton.Enabled = True
                EditButton.Enabled = True
                GetColorButton.Enabled = True
                GetSizeButton.Enabled = True
                DeleteButton.Enabled = False

            End If

        Else

            OrderIdGridLookUpEdit.Enabled = False
            StyleIdGridLookUpEdit.Enabled = False
            ProgramNoTextBox.Enabled = True
            StyleNameTextBox.Enabled = True

            If CheckUserRights("Print Order Printing").CanEdit = False Then

                NewButton.Enabled = False
                EditButton.Enabled = False
                DeleteButton.Enabled = False
                GetColorButton.Enabled = False
                GetSizeButton.Enabled = False

            ElseIf CheckUserRights("Print Order Printing").CanDelete = False Then

                NewButton.Enabled = True
                EditButton.Enabled = True
                GetColorButton.Enabled = True
                GetSizeButton.Enabled = True
                DeleteButton.Enabled = False

            End If

        End If

        Me.SplitContainer1.SplitterDistance = 350




    End Sub


    Private Sub OrderIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderIdGridLookUpEdit.EditValueChanged, PrintOrderNewLookupGridLookUpEdit.EditValueChanged

        On Error Resume Next
        If Me.IsGMT = True Then

            Me.ProgramNoTextBox.Text = Me.OrderIdGridLookUpEdit.Text
            Me.StyleIdGridLookUpEdit.EditValue = ReadIntegerData("Select StyleId From [Order] Where OrderId=" & Me.OrderIdGridLookUpEdit.EditValue, cnn)

        End If
        
    End Sub

    Private Sub StyleIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleIdGridLookUpEdit.EditValueChanged
        Me.StyleNameTextBox.Text = Me.StyleIdGridLookUpEdit.Text
    End Sub

    Private Sub PrintOrderBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles PrintOrderBindingSource.AddingNew

        If Me.PrintOrderDetailsBindingSource.Position > -1 Then

            Dim row As PrintOrderNewDataSet.PrintOrderDetailsRow
            row = CType(CType(Me.PrintOrderDetailsBindingSource.Current, DataRowView).Row, PrintOrderNewDataSet.PrintOrderDetailsRow)

            With Me.PrintOrderNewDataSet.PrintOrder

                .ProgramNoColumn.DefaultValue = ProgramNoTextBox.Text
                .PrintPartIdColumn.DefaultValue = row.PrintPartId
                .PrintTypeIdColumn.DefaultValue = row.PrintTypeId
                .PrintOrderDateColumn.DefaultValue = PrintOrderDateDateTimePicker.Text
                '.StyleIdColumn.DefaultValue = StyleIdGridLookUpEdit.EditValue
                '.MainPartColumn.DefaultValue =


                If row.IsPrintColorQuantityNull Then
                    .PrintColorQuantityColumn.DefaultValue = 0
                Else
                    .PrintColorQuantityColumn.DefaultValue = row.PrintColorQuantity

                End If

                If Me.IsGMT Then
                    .OrderIdColumn.DefaultValue = ReadIntegerData("Select OrderId From [Order] Where ProgramNo='" & Me.ProgramNoTextBox.Text & "'", cnn)
                End If


            End With

        End If


    End Sub

    Private Sub CanlcelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub GetDataToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub
    Private Sub OrderDetailsByColor(ByVal vOrderId As Integer, ByVal vPrintPartId As Integer, ByVal vPrintTypeId As Integer, ByVal vPrintOrderDetailsId As Integer)

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim sqlstring As String = "Select FabricColorId,TotalOrderQuantity From OrderSummery_Colorwise Where OrderId=" & vOrderId
        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read

            'If reader.IsDBNull(0) = False Then
            On Error Resume Next
            Dim newRow As PrintOrderNewDataSet.PrintOrderRow = Me.PrintOrderNewDataSet.PrintOrder.NewRow()
            newRow.OrderId = OrderIdGridLookUpEdit.EditValue
            newRow.FabricColorId = reader("FabricColorId").ToString
            newRow.PrintPartId = vPrintPartId
            newRow.PrintTypeId = vPrintTypeId
            newRow.FabricColorName = ReadStringData("Select FabricColorName From FabricColor Where FabricColorId=" & reader("FabricColorId").ToString, cnn)
            newRow.ProgramNo = ReadStringData("Select ProgramNo From [Order] Where OrderId=" & vOrderId.ToString(), cnn)
            newRow.PrintOrderQuantity = reader("TotalOrderQuantity")
            'newRow.StyleId = StyleIdGridLookUpEdit.EditValue
            newRow.PrintOrderDate = PrintOrderDateDateTimePicker.Text
            'newRow.PrintOrderExDate =
            newRow.PrintOrderDetailsId = vPrintOrderDetailsId

            Me.PrintOrderNewDataSet.PrintOrder.Rows.Add(newRow)

            'End If
        End While
        reader.Close()

        connection.Close()

    End Sub


    Private Sub OrderSizeDetails(ByVal vOrderId As Integer, ByVal vFabricColorId As Integer, ByVal vPrintOrderId As Integer)

        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim sqlstring As String = "Select SizeId,TTLOrderQuantity From OrderQuantitySummery_ColorAndSize Where OrderId=" & vOrderId & "And FabricColorId=" & vFabricColorId
        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read

            'If reader.IsDBNull(0) = False Then
            On Error Resume Next
            Dim newRow As PrintOrderNewDataSet.PrintOrderSizeDetailsRow = Me.PrintOrderNewDataSet.PrintOrderSizeDetails.NewRow()
            newRow.PrintOrderId = vPrintOrderId
            newRow.SizeId = reader("Sizeid")
            newRow.OrderQuantity = reader("TTLOrderQuantity")
            Me.PrintOrderNewDataSet.PrintOrderSizeDetails.Rows.Add(newRow)

            'End If
        End While
        reader.Close()

        connection.Close()

    End Sub



    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetColorButton.Click

        If PrintOrderBindingSource.Position = -1 Then

            For Each drv As DataRowView In PrintOrderDetailsBindingSource.List

                OrderDetailsByColor(OrderIdGridLookUpEdit.EditValue, drv!PrintPartId, drv!PrintTypeId, drv!PrintOrderDetailsId)

            Next

            Save()

        End If

    End Sub

    Private Sub GetSizeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub


    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetSizeButton.Click


        If Me.PrintOrderSizeDetailsBindingSource.Position = -1 Then

            For Each drv2 As DataRowView In PrintOrderBindingSource.List
                OrderSizeDetails(drv2!OrderId, drv2!FabricColorId, drv2!PrintOrderId)
            Next

            Save()


        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        With frmPrintOrderPrint
            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .PWId = PrintOrderNewLookupGridLookUpEdit.EditValue
            .Show()
        End With

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        If Me.EditButton.Text = "&Update" Then

            If AddFlag = True Then
                Dim DT As Date = ReadDateData("Select GetDate()", cnn)
                Dim PrtOrNo As String = ""
                Dim ABC As String = DT.Year.ToString.Substring(2) & "PRT"
                'Max(CAST(REVERSE(SUBSTRING(REVERSE(EmbOrderNo),0,CHARINDEX('E',REVERSE(EmbOrderNo)))) AS Integer))
                Dim XYZ As Integer = ReadIntData("Select Max(CAST(REVERSE(SUBSTRING(REVERSE(PrintOrderNo),0,CHARINDEX('T',REVERSE(PrintOrderNo)))) AS Integer)) From PrintOrderNew Where PrintOrderNo Like '" & ABC & "%'", cnn)

                PrtOrNo = DT.Year.ToString.Substring(2) & "PRT" & (Val(XYZ) + 1).ToString("")

                Me.PrintOrderNoTextBox.Text = PrtOrNo
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

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click



        If EditButton.Text = "&Edit" Then

            Me.NewButton.Enabled = False
            Me.EditButton.Text = "&Update"


            Me.PrintOrderNewBindingSource.AddNew()
            'Dim MaxPW As Integer = ReadIntData("Select Max(Convert(int,Right(PrintOrderNo,LEN(PrintOrderNo)-2))) From PrintOrderNew ", cnn)
            'Dim NewPW As String = "PW" & (Val(MaxPW) + 1).ToString
            'PrintOrderNoTextBox.Text = NewPW



            Me.IsGMTCheckBox.Checked = Me.IsGMT

            AddFlag = True


        Else
            MessageBox.Show("You have to update first.")
        End If


    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        If EditButton.Text = "&Edit" Then

            Me.NewButton.Enabled = False
            Me.EditButton.Text = "&Update"
            Me.DeleteButton.Enabled = False
            If PrintOrderDetailsBindingSource.Position = -1 Then
                Me.PrintOrderNewBindingSource.RemoveCurrent()
                DelFlag = True
            Else
                MessageBox.Show("Not Done , Please, remove Details...")
            End If


        Else

            MessageBox.Show("You have to update first.")

        End If

    End Sub

    Private Sub ShowButton_Click_1(sender As Object, e As EventArgs) Handles ShowButton.Click
        Me.PrintOrderNewTableAdapter.FillByPWId(Me.PrintOrderNewDataSet.PrintOrderNew, PrintOrderNewLookupGridLookUpEdit.EditValue)
    End Sub
End Class