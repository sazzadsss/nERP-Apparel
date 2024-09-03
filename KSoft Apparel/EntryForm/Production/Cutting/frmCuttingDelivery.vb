Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCuttingDelivery
    Dim Addflag As Boolean = False


    Dim CInput As Integer = 0
    Private Sub CuttingDeliveryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub frmCuttingDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.CuttingDeliveryChallanLookupTableAdapter.Fill(Me.CuttingDeliveryChallanLookupDataSet.CuttingDeliveryChallanLookup)

        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.LineTableAdapter.Fill(Me.LineDataSet.Line)

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Me.CuttingDeliveryDataSet.CuttingDelivery.ChallanForColumn.DefaultValue = 1

        With ChallanForLookupEdit.Properties

            .DataSource = GetChallanForTable()
            .DisplayMember = "Details"
            .ValueMember = "ChallanFor"
            .ForceInitialize() ' Force it to initialize
            .PopulateColumns() ' Force the lookupedit to populate
            .Columns("ChallanFor").Visible = False

        End With


        If CheckUserRights("Cutting Delivery").CanEdit = False Then

            NewButton.Enabled = False
            DeleteButton.Enabled = False
            EditButton.Enabled = False
            CancelEntryButton.Enabled = False
            DelCNButton.Enabled = False

        ElseIf CheckUserRights("Cutting Delivery").CanDelete = False Then

            NewButton.Enabled = True
            DeleteButton.Enabled = False
            EditButton.Enabled = True
            CancelEntryButton.Enabled = True
            DelCNButton.Enabled = False

        End If

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Try

            Me.CuttingDeliveryTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDelivery, CType(ChallanLookupGridLookUpEdit.EditValue, Long))
            Me.CuttingDeliveryDetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryDetails, CType(ChallanLookupGridLookUpEdit.EditValue, Long))
            Me.CuttingDeliveryPODetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryPODetails, CType(ChallanLookupGridLookUpEdit.EditValue, Long))
            Me.CuttingDeliveryCNDetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryCNDetails, CType(ChallanLookupGridLookUpEdit.EditValue, Long))

            If ChallanForLookupEdit.Text = "Embroidery" Then
                Me.CuttingDeliveryEmbDetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryEmbDetails, ChallanLookupGridLookUpEdit.EditValue)
            ElseIf ChallanForLookupEdit.Text = "Printing" Then
                Me.CuttingDeliveryPrintDetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryPrintDetails, ChallanLookupGridLookUpEdit.EditValue)
            End If

            RefreshSummery()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Save()
        Try

            Dim row As CuttingDeliveryDataSet.CuttingDeliveryRow
            row = CType(CType(Me.CuttingDeliveryBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryRow)

            If row.IsOrderIdNull = True Then
                MessageBox.Show("Program is Missing")
                Exit Sub
            ElseIf row.IsSupplierIdNull = True Then
                MessageBox.Show("Supplier is Missing")
                Exit Sub
            ElseIf row.IsBranchIdNull = True Then
                MessageBox.Show("Branch is Missing")
                Exit Sub
            ElseIf row.IsChallanDateNull = True Then
                MessageBox.Show("Challan Date is Missing")
                Exit Sub
            End If

            Me.Validate()
            Me.CuttingDeliveryBindingSource.EndEdit()
            Me.CuttingDeliveryDetailsBindingSource.EndEdit()
            Me.CuttingDeliveryPODetailsBindingSource.EndEdit()
            Me.CuttingDeliveryCNDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CuttingDeliveryDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        If PrintCount(Me.ChallanNoTextEdit.Text, True) > 0 Then

                Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
                If UL <> 1 Then
                    MessageBox.Show("Not allowed to edit a already printed challan")
                    Exit Sub
                Else
                    GoTo Line1
                End If

            End If

Line1:
        Try
            If EditButton.Text = "&Update" Then

                Dim row As CuttingDeliveryDataSet.CuttingDeliveryRow
                row = CType(CType(Me.CuttingDeliveryBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryRow)

                Save()

                EditButton.Text = "&Edit"
                NewButton.Enabled = True

                If Addflag = True Then

                    Me.CuttingDeliveryChallanLookupTableAdapter.Fill(Me.CuttingDeliveryChallanLookupDataSet.CuttingDeliveryChallanLookup)

                    Me.ChallanLookupGridLookUpEdit.EditValue = row.CuttingDeliveryId
                    Addflag = False
                    If UserId <> 1 Then
                        OrderIdGridLookUpEdit.Enabled = False
                        ChallanForLookupEdit.Enabled = False
                    End If


                End If


                Me.OrderColorPOLookupTableAdapter.FillByOID(Me.OrderColorPOLookupDataSet.OrderColorPOLookup, OrderIdGridLookUpEdit.EditValue)

                If Me.CuttingDeliveryDetailsBindingSource.Position > -1 Then

                    '
                    Me.CuttingDeliveryPODetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryPODetails, CType(ChallanLookupGridLookUpEdit.EditValue, Long))
                    SplitInPOQty()
                    RefreshSummery()
                    RefreshSummery()
                    AdjAdditionalQty()


                    Dim row1 As CuttingDeliveryDataSet.CuttingDeliveryDetailsRow
                    row1 = CType(CType(Me.CuttingDeliveryDetailsBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryDetailsRow)

                    Dim LID As Integer = -1
                    If row1.IsLineIdNull = True Then
                        LID = -1
                    Else
                        LID = row1.LineId
                    End If

                    UpdateCuttingInput(row.OrderId, row1.FabricColorId, row.ChallanNo, row.ChallanDate, row.BranchId, LID, row.SupplierId, row.CuttingDeliveryId, row.ChallanFor)






                Else

                    DeleteCuttingInput(row.ChallanNo)



                End If

                Save()

                MessageBox.Show("Saved Successfully")

            Else

                EditButton.Text = "&Update"
                If UserId = 1 Then
                    OrderIdGridLookUpEdit.Enabled = True
                    EmbOrderGridLookUpEdit.Enabled = True
                    PrintOrderGridLookUpEdit.Enabled = True
                Else
                    OrderIdGridLookUpEdit.Enabled = False
                    EmbOrderGridLookUpEdit.Enabled = False
                    PrintOrderGridLookUpEdit.Enabled = False
                End If

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If Me.CuttingDeliveryDetailsBindingSource.Position = -1 Then
            DeleteCuttingInput(Me.ChallanNoTextEdit.Text)
            CuttingDeliveryBindingSource.RemoveCurrent()
            EditButton.Text = "Edit"
            Me.Validate()
            Me.CuttingDeliveryBindingSource.EndEdit()
            Me.CuttingDeliveryDetailsBindingSource.EndEdit()
            Me.CuttingDeliveryPODetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CuttingDeliveryDataSet)

        Else
            MessageBox.Show("Delete Details then try again.")
        End If
    End Sub



    Private Sub OrderIdGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles OrderIdGridLookUpEdit.EditValueChanged
        On Error Resume Next

        Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, OrderIdGridLookUpEdit.EditValue)
        Me.SizeLookupTableAdapter.Fill(Me.SizeLookupDataSet.SizeLookup, OrderIdGridLookUpEdit.EditValue)
        Me.OrderColorPOLookupTableAdapter.FillByOID(Me.OrderColorPOLookupDataSet.OrderColorPOLookup, OrderIdGridLookUpEdit.EditValue)
        Me.PrintOrderNewLookupTableAdapter.FillByOrderId(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup, OrderIdGridLookUpEdit.EditValue)
        Me.EmbOrderLookupTableAdapter.FillByOrderId(Me.EmbOrderLookupDataSet.EmbOrderLookup, OrderIdGridLookUpEdit.EditValue)


        If ChallanForLookupEdit.Text = "Embroidery" And Addflag = True Then

            Dim EMBOrderId As Integer = ReadIntegerData("Select Top 1 EmbOrderId From EmbOrder Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
            EmbOrderGridLookUpEdit.EditValue = EMBOrderId
            If UserId = 1 Then
                EmbOrderGridLookUpEdit.Enabled = True
            Else
                EmbOrderGridLookUpEdit.Enabled = False
            End If

        ElseIf ChallanForLookupEdit.Text = "Printing" And Addflag = True Then

            Dim PrintOrderId As Integer = ReadIntegerData("Select Top 1 PrintOrderNewId From PrintOrderNew Where OrderId=" & OrderIdGridLookUpEdit.EditValue, cnn)
            PrintOrderGridLookUpEdit.EditValue = PrintOrderId
            If UserId = 1 Then
                PrintOrderGridLookUpEdit.Enabled = True
            Else
                PrintOrderGridLookUpEdit.Enabled = False
            End If

        End If

    End Sub

    Private Sub FabricColorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FabricColorComboBox.SelectedIndexChanged
        On Error Resume Next

        'Me.OrderColorPOLookupTableAdapter.FillBy(Me.OrderColorPOLookupDataSet.OrderColorPOLookup, FabricColorComboBox.SelectedValue, OrderIdGridLookUpEdit.EditValue)
        Me.CuttingNoLookupTableAdapter.Fill(Me.CuttingNoLookupDataSet.CuttingNoLookup, OrderIdGridLookUpEdit.EditValue, FabricColorComboBox.SelectedValue)
        'CalculatePOQuantity()
    End Sub

    Private Sub BranchIdTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles BranchIdTextEdit.EditValueChanged
        On Error Resume Next
        Me.LineTableAdapter.FillByBranchId(Me.LineDataSet.Line, BranchIdTextEdit.EditValue)
    End Sub
    Private Sub GetCuttingDeliveryEmbDetails(ByVal CuttingDeliveryDetailsId As Integer, ByVal FabricColorId As Integer, ByVal SizeId As Integer, ByVal EmbOrderId As Integer)

        Dim cnt As Int16 = ReadIntData("Select Count(*) From CuttingDeliveryEmbDetails Where CuttingDeliveryDetailsId=" & CuttingDeliveryDetailsId, cnn)
        If cnt = 0 Then
            Using Connection As New SqlConnection(cnn)

                Connection.Open()




                Dim cmd As SqlCommand = New SqlCommand("GetCuttingDeliveryEmbDetails", Connection)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@CuttingDeliveryDetailsId", CuttingDeliveryDetailsId)
                cmd.Parameters.AddWithValue("@FabricColorid", FabricColorId)
                cmd.Parameters.AddWithValue("@SizeId", SizeId)
                cmd.Parameters.AddWithValue("@EmbOrderId", EmbOrderId)


                cmd.ExecuteNonQuery()

            End Using

        End If


    End Sub

    Private Sub GetCuttingDeliveryPrintDetails(ByVal CuttingDeliveryDetailsId As Integer, ByVal FabricColorId As Integer, ByVal SizeId As Integer, ByVal PrintOrderNewId As Integer)

        Dim cnt As Int16 = ReadIntData("Select Count(*) From CuttingDeliveryPrintDetails Where CuttingDeliveryDetailsId=" & CuttingDeliveryDetailsId, cnn)
        If cnt = 0 Then
            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("GetCuttingDeliveryPrintDetails", Connection)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@CuttingDeliveryDetailsId", CuttingDeliveryDetailsId)
                cmd.Parameters.AddWithValue("@FabricColorid", FabricColorId)
                cmd.Parameters.AddWithValue("@SizeId", SizeId)
                cmd.Parameters.AddWithValue("@PrintOrderNewId", PrintOrderNewId)


                cmd.ExecuteNonQuery()

            End Using

        End If


    End Sub




    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click

        If Me.CuttingDeliveryDetailsBindingSource.Position > -1 Then
            Exit Sub
        End If

        If Me.CuttingDeliveryBindingSource.Position > -1 Then

            Dim row As CuttingDeliveryDataSet.CuttingDeliveryRow
            row = CType(CType(Me.CuttingDeliveryBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryRow)

            If FabricColorComboBox.SelectedValue = -1 Then
                MessageBox.Show("Select Color")
                Exit Sub
            ElseIf LineGridLookUpEdit.EditValue = -1 Then
                MessageBox.Show("Select Line")
                Exit Sub
            ElseIf ChallanForLookupEdit.EditValue = -1 Then
                MessageBox.Show("Select Challan For")
                Exit Sub
            End If



            Using connection As New SqlConnection(cnn)

                Dim command As New SqlCommand("Select ISNULL(SizeId,-1) AS SizeId,TTLOrderQuantity From [dbo].[OrderQuantitySummery_ColorAndSizeWithCP] 
                                                Where  OrderId=" & row.OrderId & " And FabricColorId=" & FabricColorComboBox.SelectedValue, connection)

                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()

                    Dim newRow = CType(Me.CuttingDeliveryDataSet.CuttingDeliveryDetails.NewRow(), CuttingDeliveryDataSet.CuttingDeliveryDetailsRow)
                    newRow.CuttingDeliveryId = row.CuttingDeliveryId
                    newRow.FabricColorId = Me.FabricColorComboBox.SelectedValue
                    newRow.InputQuantity = 0

                    newRow.SizeId = reader("SizeId")
                    newRow.OrderQuantity = reader("TTLOrderQuantity")
                    newRow.CuttingQuantity = ReadData("Select CuttingQuantity From CuttingQuantitySummerySizewise 
                                             Where SizeId=" & reader("SizeId") & " And OrderId = " & row.OrderId & " And FabricColorId = " & FabricColorComboBox.SelectedValue, cnn)
                    Dim TTLInputQuantity As Integer = ReadIntData("Select Sum(InputQuantity) As TTLQuantity From CuttingDeliveryDetails 
                                             Where FabricColorId = " & FabricColorComboBox.SelectedValue & "And SizeId=" & reader("SizeId") & " And CuttingDeliveryId in (Select CuttingDeliveryId From CuttingDelivery Where ChallanFor=" & Me.ChallanForLookupEdit.EditValue & "And OrderId=" & row.OrderId & ")", cnn)
                    'Debug.Print("*********************************")
                    'Debug.Print("FCID :" & FabricColorComboBox.SelectedValue)
                    'Debug.Print("SID :" & reader("SizeId"))
                    'Debug.Print("OrderId :" & row.OrderId)
                    'Debug.Print("*********************************")
                    Dim TTLInputQuantity2 As Integer = 0 'ReadData("Select SUM(InputQuantity) As InputQuantity From CuttingInputSummeryColorAndSizewiseAndWoUniID Where SizeId=" & reader("SizeId") & " And OrderId = " & row.OrderId & " And FabricColorId = " & FabricColorComboBox.SelectedValue, cnn)
                    TTLInputQuantity = TTLInputQuantity + TTLInputQuantity2

                    newRow.InputBalance = newRow.CuttingQuantity - TTLInputQuantity
                    newRow.LineId = Me.LineGridLookUpEdit.EditValue
                    Me.CuttingDeliveryDataSet.CuttingDeliveryDetails.Rows.Add(newRow)

                End While

                reader.Close()

            End Using

            For Each drv As DataRowView In CuttingDeliveryDetailsBindingSource.List

                If drv!InputBalance < 0 Then
                    drv!InputQuantity = drv!InputQuantity + drv!InputBalance
                End If

                'If ChallanForLookupEdit.Text = "Embroidery" Then
                '    GetCuttingDeliveryEmbDetails(drv!CuttingDeliveryDetailsId, drv!FabricColorId, drv!SizeId, EmbOrderGridLookUpEdit.EditValue)
                'End If

            Next



            'CopyButton.Enabled = True

        End If


    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click


        Me.CuttingDeliveryBindingSource.AddNew()
        Dim ABC As String = Now.Year.ToString.Substring(2) & "CDC"
        Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0, CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From CuttingDelivery Where ChallanNo Like '" & ABC & "%'", cnn)

        Me.ChallanNoTextEdit.Text = Now.Year.ToString.Substring(2) & "CDC" & (Val(XYZ) + 1).ToString()
        Me.ChallanDateDateEdit.Text = Today()

        Me.OrderIdGridLookUpEdit.Enabled = True
        Me.ChallanForLookupEdit.Enabled = True



        Addflag = True
        NewButton.Enabled = False
        EditButton.Text = "&Update"




    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click


        Me.CuttingDeliveryChallanLookupTableAdapter.Fill(Me.CuttingDeliveryChallanLookupDataSet.CuttingDeliveryChallanLookup)
        Me.OrderColorPOLookupTableAdapter.FillByOID(Me.OrderColorPOLookupDataSet.OrderColorPOLookup, OrderIdGridLookUpEdit.EditValue)

        If Me.CuttingDeliveryDetailsBindingSource.Position > -1 Then

            '
            'Me.CuttingDeliveryPODetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryPODetails, CType(ChallanLookupGridLookUpEdit.EditValue, Long))
            RefreshSummery()
            RefreshSummery()
            SplitInPOQty()

        Else

            Dim row As CuttingDeliveryDataSet.CuttingDeliveryRow
            row = CType(CType(Me.CuttingDeliveryBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryRow)

            DeleteCuttingInput(row.ChallanNo)

        End If

        'RefreshSummery()

    End Sub

    Private Sub RefreshSummery()

        Save()

        If CuttingDeliveryDetailsBindingSource.Position > -1 Then

            Dim row As CuttingDeliveryDataSet.CuttingDeliveryRow
            row = CType(CType(Me.CuttingDeliveryBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryRow)

            For Each drv As DataRowView In CuttingDeliveryDetailsBindingSource.List

                Dim OrderQuantity As Integer = ReadData("Select TTLOrderQuantity From [dbo].[OrderQuantitySummery_ColorAndSizeWithCP] Where  SizeId=" & drv!SizeId & "And OrderId=" & row.OrderId & " And FabricColorId=" & drv!FabricColorId, cnn)
                Dim TTLInputQuantity As Integer = ReadIntData("Select Sum(InputQuantity) As TTLQuantity From CuttingDeliveryDetails Where SizeId=" & drv!SizeId & " And CuttingDeliveryId  in (Select CuttingDeliveryId From CuttingDelivery Where ChallanFor=" & row.ChallanFor & " And OrderId=" & row.OrderId & ") And FabricColorId = " & drv!FabricColorId, cnn)
                Dim TTLInputQuantity2 As Integer = 0 'ReadData("Select SUM(InputQuantity) As InputQuantity From CuttingInputSummeryColorAndSizewiseAndWoUniID Where SizeId=" & drv!SizeId & " And OrderId = " & row.OrderId & " And FabricColorId = " & FabricColorComboBox.SelectedValue, cnn)
                Debug.Print("TTL Input 1 : " & TTLInputQuantity.ToString())
                Debug.Print("TTL Input 2 : " & TTLInputQuantity2.ToString())
                TTLInputQuantity = TTLInputQuantity + TTLInputQuantity2
                drv!OrderQuantity = OrderQuantity
                drv!CuttingQuantity = ReadData("Select CuttingQuantity From CuttingQuantitySummerySizewise Where SizeId=" & drv!SizeId & " And OrderId = " & row.OrderId & " And FabricColorId = " & drv!FabricColorId, cnn)
                drv!InputBalance = drv!CuttingQuantity - TTLInputQuantity

            Next


            For Each drv As DataRowView In CuttingDeliveryDetailsBindingSource.List

                If drv!InputBalance < 0 Then
                    drv!InputQuantity = drv!InputQuantity + drv!InputBalance
                End If
            Next


        End If

        'If CuttingDeliveryPODetailsBindingSource.Position > -1 Then

        '    Dim TTLInput As Integer = 0
        '    Dim row As CuttingDeliveryDataSet.CuttingDeliveryDetailsRow
        '    row = CType(CType(Me.CuttingDeliveryDetailsBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryDetailsRow)

        '    Dim row1 As CuttingDeliveryDataSet.CuttingDeliveryRow
        '    row1 = CType(CType(Me.CuttingDeliveryBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryRow)

        '    For Each drv As DataRowView In CuttingDeliveryPODetailsBindingSource.List

        '        Dim OrderQuantity As Integer = ReadIntData("Select OrderQuantity From OrderQuantity_OIDAndODIDAndCIDAndSIDWithCP Where  SizeId=" & row.SizeId & "And OrderDetailsId=" & drv!OrderDetailsId, cnn)
        '        Dim TTLInputQuantity As Integer = ReadData("Select Sum(InputQuantity) As TTLInputQuantity From CuttingDeliverySummeryPOAndSize Where ChallanFor=" & ChallanForLookupEdit.EditValue & " And SizeId=" & row.SizeId & "And  OrderDetailsId=" & drv!OrderDetailsId, cnn)

        '        drv!OrderQuantity = OrderQuantity
        '        drv!InputBalance = OrderQuantity - TTLInputQuantity
        '        TTLInput = TTLInput + drv!InputQuantity

        '    Next

        '    'row.InputQuantity = TTLInput
        '    'row.InputBalance = row.OrderQuantity - row.InputQuantity





        'End If



    End Sub

    Private Sub SplitInPOQty()

        Dim i As Integer = 0
        Dim j As Integer = Me.CuttingDeliveryPODetailsBindingSource.Count - 1

        Me.CuttingDeliveryDetailsBindingSource.MoveFirst()


        Do While i <= Me.CuttingDeliveryDetailsBindingSource.Count - 1


            'On Error Resume Next

            Do While Me.CuttingDeliveryPODetailsBindingSource.Count > 0
                Me.CuttingDeliveryPODetailsBindingSource.RemoveCurrent()
                j = j + 1
            Loop

            Save()


            If Me.CuttingDeliveryPODetailsBindingSource.Position = -1 Then

                Dim TTLPOInputQuantity As Integer = 0
                Dim TTLPOInputBalance As Integer = 0
                Dim TTLClrInput As Integer = 0
                Dim TTLClrInputBal As Integer = 0

                Dim row As CuttingDeliveryDataSet.CuttingDeliveryRow
                row = CType(CType(Me.CuttingDeliveryBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryRow)

                Dim row1 As CuttingDeliveryDataSet.CuttingDeliveryDetailsRow
                row1 = CType(CType(Me.CuttingDeliveryDetailsBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryDetailsRow)


                Using connection As New SqlConnection(cnn)

                    Dim command As New SqlCommand("Select OrderDetailsId,ISNULL(OrderQuantity,0) AS OrderQuantity From OrderQuantity_OIDAndODIDAndCIDAndSIDWithCP Where  SizeId =" & row1.SizeId & "And OrderId=" & row.OrderId & " And FabricColorId=" & row1.FabricColorId, connection)

                    command.Connection.Open()
                    command.ExecuteNonQuery()
                    Dim TTLColorInputQuantity As Integer = row1.InputQuantity

                    Dim reader As SqlDataReader = command.ExecuteReader()

                    While reader.Read()

                        TTLPOInputQuantity = 0
                        TTLPOInputBalance = 0

                        If row1.InputQuantity > 0 Then

                            Dim newRow = CType(Me.CuttingDeliveryDataSet.CuttingDeliveryPODetails.NewRow(), CuttingDeliveryDataSet.CuttingDeliveryPODetailsRow)

                            newRow.CuttingDeliveryDetailsId = row1.CuttingDeliveryDetailsId
                            newRow.OrderDetailsId = reader("OrderDetailsId")
                            If reader("OrderQuantity") > 0 Then
                                newRow.OrderQuantity = reader("OrderQuantity")
                            Else
                                newRow.OrderQuantity = 0
                            End If



                            TTLPOInputQuantity = ReadData("Select Sum(InputQuantity) As TTLInputQuantity From CuttingDeliverySummeryPOAndSize Where ChallanFor=" & Me.ChallanForLookupEdit.EditValue & " And SizeId=" & row1.SizeId & "And  OrderDetailsId=" & reader("OrderDetailsId"), cnn)
                            TTLPOInputBalance = CType(reader("OrderQuantity"), Int32) - CType(TTLPOInputQuantity, Int32)


                            If TTLColorInputQuantity >= TTLPOInputBalance AndAlso TTLColorInputQuantity > 0 AndAlso TTLPOInputBalance > 0 Then

                                newRow.InputQuantity = CType(TTLPOInputBalance, Integer)
                                TTLClrInput = TTLClrInput + CType(TTLPOInputBalance, Integer)
                                TTLColorInputQuantity = CType(TTLColorInputQuantity, Integer) - CType(TTLPOInputBalance, Integer)
                                newRow.InputBalance = 0



                            ElseIf TTLColorInputQuantity < TTLPOInputBalance AndAlso TTLColorInputQuantity > 0 Then

                                newRow.InputQuantity = TTLColorInputQuantity
                                TTLClrInput = TTLClrInput + TTLColorInputQuantity
                                TTLColorInputQuantity = TTLColorInputQuantity - TTLColorInputQuantity

                                newRow.InputBalance = TTLPOInputBalance - TTLColorInputQuantity



                            Else

                                newRow.InputQuantity = 0
                                newRow.InputBalance = 0

                            End If


                            'If newRow.InputQuantity > 0 Then

                            Me.CuttingDeliveryDataSet.CuttingDeliveryPODetails.Rows.Add(newRow)

                            'End If



                        End If

                    End While

                    reader.Close()

                End Using


                'If Me.CuttingDeliveryPODetailsBindingSource.Position > -1 Then
                '    row1.InputQuantity = TTLClrInput
                'End If



            End If

            Me.CuttingDeliveryDetailsBindingSource.MoveNext()

            i = i + 1

        Loop

        Save()

    End Sub


    Private Sub CuttingDeliveryDetailsBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles CuttingDeliveryDetailsBindingSource.PositionChanged
        On Error Resume Next
        ' Me.OrderColorPOLookupTableAdapter.FillBy(Me.OrderColorPOLookupDataSet.OrderColorPOLookup, row1.FabricColorId, row.OrderId)
        'RefreshSummery()

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        frmCuttingDeliveryChallanPrint.CDID = Me.ChallanLookupGridLookUpEdit.EditValue
        ShowForm(frmCuttingDeliveryChallanPrint)
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked
        Try

            Me.CuttingDeliveryPODetailsBindingSource.RemoveCurrent()

            Me.Validate()
            Me.CuttingDeliveryBindingSource.EndEdit()
            Me.CuttingDeliveryDetailsBindingSource.EndEdit()
            Me.CuttingDeliveryPODetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CuttingDeliveryDataSet)


            'RefreshSummery()

        Catch ex As Exception

        End Try


    End Sub

    'Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
    '    If CuttingDeliveryDetailsBindingSource.Position > -1 Then

    '        Dim row As CuttingDeliveryDataSet.CuttingDeliveryRow
    '        row = CType(CType(Me.CuttingDeliveryBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryRow)

    '        For Each drv As DataRowView In CuttingDeliveryDetailsBindingSource.List

    '            If drv!InputQuantity = 0 Then
    '                drv!InputQuantity = drv!InputBalance
    '                drv!InputBalance = 0
    '            End If

    '        Next
    '        CopyButton.Enabled = False
    '    End If
    'End Sub

    Public Sub UpdateCuttingInput(ByVal OrderId As Integer, ByVal FabricColorId As Integer, ByVal ChallanNo As String, ByVal ChallanDate As Date, ByVal BranchId As Integer, ByVal LineId As Integer, ByVal SupplierId As Integer, ByVal CuttingDeliveryId As Integer, ByVal ChallanFor As Integer)


        Using Connection As New SqlConnection(cnn)

            Connection.Open()


            Dim cmd As SqlCommand = New SqlCommand("UpdateCuttingInput", Connection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@OrderId", OrderId)
            cmd.Parameters.AddWithValue("@FabricColorid", FabricColorId)
            cmd.Parameters.AddWithValue("@ChallanNo", ChallanNo)
            cmd.Parameters.AddWithValue("@ChallanFor", ChallanFor)
            cmd.Parameters.AddWithValue("@BranchId", BranchId)
            cmd.Parameters.AddWithValue("@ChallanDate", ChallanDate)
            cmd.Parameters.AddWithValue("@SupplierId", SupplierId)
            cmd.Parameters.AddWithValue("@LineId", LineId)
            cmd.Parameters.AddWithValue("@CuttingDeliveryId", CuttingDeliveryId)

            cmd.ExecuteNonQuery()



        End Using

    End Sub

    Public Sub DeleteCuttingInput(ByVal ChallanNo As String)


        Using Connection As New SqlConnection(cnn)

            Connection.Open()


            Dim cmd As SqlCommand = New SqlCommand("DeleteCuttingInput", Connection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@ChallanNo", ChallanNo)
            'cmd.Parameters.AddWithValue("@ChallanDate", ChallanDate)

            cmd.ExecuteNonQuery()



        End Using

    End Sub



    Public Sub UpdateSewingInCuttingProdNew(ByVal OrderId As Integer, ByVal FabricColorId As Integer, ByVal ChallanNo As String, ByVal ChallanDate As Date, ByVal BranchId As Integer, ByVal LineId As Integer, ByVal SupplierId As Integer, ByVal CuttingDeliveryId As Integer, ByVal ChallanFor As Integer)


        Using Connection As New SqlConnection(cnn)

            Connection.Open()


            Dim cmd As SqlCommand = New SqlCommand("UpdateCuttingInput", Connection)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@OrderId", OrderId)
            cmd.Parameters.AddWithValue("@FabricColorid", FabricColorId)
            cmd.Parameters.AddWithValue("@ChallanNo", ChallanNo)
            cmd.Parameters.AddWithValue("@ChallanFor", ChallanFor)
            cmd.Parameters.AddWithValue("@BranchId", BranchId)
            cmd.Parameters.AddWithValue("@ChallanDate", ChallanDate)
            cmd.Parameters.AddWithValue("@SupplierId", SupplierId)
            cmd.Parameters.AddWithValue("@LineId", LineId)
            cmd.Parameters.AddWithValue("@CuttingDeliveryId", CuttingDeliveryId)

            cmd.ExecuteNonQuery()



        End Using

    End Sub


    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        'On Error Resume Next
        'If Me.CuttingDeliveryDetailsBindingSource.Position > -1 Then

        '    Dim row As CuttingDeliveryDataSet.CuttingDeliveryDetailsRow
        '    row = CType(CType(Me.CuttingDeliveryDetailsBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryDetailsRow)

        '    If row.InputQuantity > row.InputBalance AndAlso row.InputBalance > 0 AndAlso row.IsInputBalanceNull = False Then
        '        row.InputQuantity = row.InputBalance
        '    End If

        'End If

        'If e.Column.Caption = "Input Quantity" Then

        '    Dim view As GridView = TryCast(sender, GridView)
        '    Dim Input As Integer = view.GetRowCellValue(e.RowHandle, colInputQuantity)
        '    Dim InputBal As Integer = view.GetRowCellValue(e.RowHandle, colInputBalance)
        '    'If InputBal < 0 Then
        '    '    view.SetRowCellValue(e.RowHandle, colInputQuantity, Input + InputBal)
        '    'End If

        'End If



        'If e.Column.Caption = "Fabric Finishing Type" Then

        '    'On Error Resume Next
        '    'Dim row As PreCostingDataSet.PreCostingFabricFinishingRow
        '    'row = CType(CType(Me.PreCostingFabricFinishingBindingSource.Current, DataRowView).Row, PreCostingDataSet.PreCostingFabricFinishingRow)

        '    Dim view As GridView = TryCast(sender, GridView)
        '    Dim cellValue = view.GetRowCellValue(e.RowHandle, colFabricFinishingTypeId)
        '    view.SetRowCellValue(e.RowHandle, colPricePerKg, ReadData("Select Price From FabricFinishingType Where FabricFinishingTypeId=" & cellValue, cnn))


        'End If

    End Sub

    Private Sub ChallanForLookupEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ChallanForLookupEdit.EditValueChanged
        On Error Resume Next

        Me.BranchTableAdapter.FillByBranchName(Me.BranchDataSet.Branch, ChallanForLookupEdit.Text)

        If Me.ChallanForLookupEdit.EditValue = 2 Then
            BranchIdTextEdit.EditValue = ReadIntegerData("Select BranchId From Branch Where BranchName='Printing'", cnn)
            colInputQuantity.OptionsColumn.AllowEdit = False
            colInputQuantity.OptionsColumn.ReadOnly = True
            Me.PrintOrderLookupTableAdapter.FillPrintOrderNewId(Me.PrintProductionDataSet.PrintOrderLookup, PrintOrderGridLookUpEdit.EditValue)
            Me.PrintOrderNewLookupTableAdapter.Fill(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)
        ElseIf Me.ChallanForLookupEdit.EditValue = 3 Then
            BranchIdTextEdit.EditValue = ReadIntegerData("Select BranchId From Branch Where BranchName='Embroidery'", cnn)
            colInputQuantity.OptionsColumn.AllowEdit = False
            colInputQuantity.OptionsColumn.ReadOnly = True
            Me.EmbOrderLookupTableAdapter.Fill(Me.EmbOrderLookupDataSet.EmbOrderLookup)
            Me.EmbOrderDetailsLookupTableAdapter.FillByEmbOrderId(Me.EmbOrderDetailsLookupDataSet.EmbOrderDetailsLookup, EmbOrderGridLookUpEdit.EditValue)
        Else
            colInputQuantity.OptionsColumn.AllowEdit = True
            colInputQuantity.OptionsColumn.ReadOnly = False
        End If

    End Sub

    Private Sub GetDataByCuttingNo(ByVal CN As String)

        If Me.CuttingDeliveryDetailsBindingSource.Position > -1 Then

            Dim row As CuttingDeliveryDataSet.CuttingDeliveryRow
            row = CType(CType(Me.CuttingDeliveryBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryRow)

            Dim row1 As CuttingDeliveryDataSet.CuttingDeliveryDetailsRow
            row1 = CType(CType(Me.CuttingDeliveryDetailsBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryDetailsRow)



            Using connection As New SqlConnection(cnn)

                Dim command As New SqlCommand("Select ISNULL(SUM(CuttingQuantity),0) As TTLCuttingQuantity From CuttingProductionNewDetails 
                                               Where SizeId=" & row1.SizeId & " And CuttingProductionNewId  in ( Select CuttingProductionNewId From CuttingProductionNew Where OrderId=" & row.OrderId & " And FabricColorId=" & row1.FabricColorId & " And CuttingNo='" & CN & "')", connection)


                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()

                    Dim newRow = CType(Me.CuttingDeliveryDataSet.CuttingDeliveryCNDetails.NewRow(), CuttingDeliveryDataSet.CuttingDeliveryCNDetailsRow)
                    newRow.CuttingDeliveryDetailsId = row1.CuttingDeliveryDetailsId
                    newRow.CuttingNo = CuttingNoGridLookUpEdit.EditValue
                    newRow.InputQuantity = reader("TTLCuttingQuantity")
                    Me.CuttingDeliveryDataSet.CuttingDeliveryCNDetails.Rows.Add(newRow)

                End While

                reader.Close()

            End Using
            'CopyButton.Enabled = True


        End If



        If Me.CuttingDeliveryCNDetailsBindingSource.Position > -1 Then

            Dim InputQuantity As Integer = 0

            Dim row1 As CuttingDeliveryDataSet.CuttingDeliveryDetailsRow
            row1 = CType(CType(Me.CuttingDeliveryDetailsBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryDetailsRow)

            For Each drv As DataRowView In Me.CuttingDeliveryCNDetailsBindingSource.List
                InputQuantity = InputQuantity + drv!InputQuantity
            Next

            row1.InputQuantity = InputQuantity

        End If

    End Sub

    Private Sub InsertCNButton_Click(sender As Object, e As EventArgs) Handles InsertCNButton.Click
        Dim CNFlag As Integer = ReadIntData("Select Count(*) From CuttingNoLookupByChallanFor Where ChallanFor='" & ChallanForLookupEdit.Text & "' And OrderId=" & OrderIdGridLookUpEdit.EditValue & "And FabricColorId=" & FabricColorComboBox.SelectedValue & "And CuttingNo='" & CuttingNoGridLookUpEdit.Text & "'", cnn)

        Dim i As Integer = 0

        Me.CuttingDeliveryDetailsBindingSource.MoveFirst()

        Do While i <= Me.CuttingDeliveryDetailsBindingSource.Count - 1

            Dim row As CuttingDeliveryDataSet.CuttingDeliveryDetailsRow
            row = CType(CType(Me.CuttingDeliveryDetailsBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryDetailsRow)

            If row.FabricColorId = Me.FabricColorComboBox.SelectedValue And CNFlag = 0 Then

                GetDataByCuttingNo(CuttingNoGridLookUpEdit.EditValue)

            End If

            Me.CuttingDeliveryDetailsBindingSource.MoveNext()
            i = i + 1

        Loop

        Me.CuttingDeliveryDetailsBindingSource.MoveFirst()

        '=======================================
        Dim row1 As CuttingDeliveryDataSet.CuttingDeliveryRow
        row1 = CType(CType(Me.CuttingDeliveryBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryRow)
        If Me.CuttingDeliveryDetailsBindingSource.Position > -1 Then


            '
            Me.CuttingDeliveryPODetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryPODetails, CType(ChallanLookupGridLookUpEdit.EditValue, Long))
            SplitInPOQty()
            RefreshSummery()
            RefreshSummery()
            AdjAdditionalQty()


            Dim row As CuttingDeliveryDataSet.CuttingDeliveryDetailsRow
            row = CType(CType(Me.CuttingDeliveryDetailsBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryDetailsRow)

            Dim LID As Integer = -1
            If row.IsLineIdNull = True Then
                LID = -1
            Else
                LID = row.LineId
            End If

            UpdateCuttingInput(row1.OrderId, row.FabricColorId, row1.ChallanNo, row1.ChallanDate, row1.BranchId, LID, row1.SupplierId, row1.CuttingDeliveryId, row1.ChallanFor)

        Else

            DeleteCuttingInput(row1.ChallanNo)

        End If


        '===================


        Try

            Me.Validate()
            Me.CuttingDeliveryBindingSource.EndEdit()
            Me.CuttingDeliveryDetailsBindingSource.EndEdit()
            Me.CuttingDeliveryPODetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CuttingDeliveryDataSet)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub CuttingNoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DelCNButton_Click(sender As Object, e As EventArgs) Handles DelCNButton.Click

        If Me.CuttingDeliveryCNDetailsBindingSource.Position > -1 Then


            Dim TTLInput As Integer = 0

            Dim row As CuttingDeliveryDataSet.CuttingDeliveryDetailsRow
            row = CType(CType(Me.CuttingDeliveryDetailsBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryDetailsRow)

            Me.CuttingDeliveryCNDetailsBindingSource.RemoveCurrent()

            For Each drv As DataRowView In Me.CuttingDeliveryCNDetailsBindingSource.List
                TTLInput = TTLInput + drv!InputQuantity
            Next

            row.InputQuantity = TTLInput


        End If


    End Sub

    Private Sub AdjAdditionalQty()

        Dim i As Integer = 0


        Me.CuttingDeliveryDetailsBindingSource.MoveFirst()


        Do While i <= Me.CuttingDeliveryDetailsBindingSource.Count - 1
            Dim TTLInput As Integer = 0
            Dim TTLInput2 As Integer = 0
            If Me.CuttingDeliveryPODetailsBindingSource.Position > -1 Then

                Dim row As CuttingDeliveryDataSet.CuttingDeliveryRow
                row = CType(CType(Me.CuttingDeliveryBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryRow)

                Dim row1 As CuttingDeliveryDataSet.CuttingDeliveryDetailsRow
                row1 = CType(CType(Me.CuttingDeliveryDetailsBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryDetailsRow)

                Dim row2 As CuttingDeliveryDataSet.CuttingDeliveryPODetailsRow
                row2 = CType(CType(Me.CuttingDeliveryPODetailsBindingSource.Current, DataRowView).Row, CuttingDeliveryDataSet.CuttingDeliveryPODetailsRow)


                'Dim MaxODID As Integer = ReadIntegerData("SELECT Top 1 OrderDetailsId FROM OrderDetails Where OrderId=" & row.OrderId & "And FabricColorId=" & row1.FabricColorId & " ORDER BY EX DESC", cnn)


                For Each drv As DataRowView In Me.CuttingDeliveryPODetailsBindingSource.List
                    TTLInput = TTLInput + drv!InputQuantity
                Next


                '                For Each drv As DataRowView In Me.CuttingDeliveryPODetailsBindingSource.List

                '                    If TTLInput = 0 Then
                '                        drv!InputQuantity = row1.InputQuantity
                '                        GoTo Line1
                '                    End If
                '                Next
                'Line1:

                'Debug.Print("Color wise Input:" & row1.InputQuantity)
                'Debug.Print("POWise wise Input:" & TTLInput)

                If TTLInput < row1.InputQuantity Then
                    row2.InputQuantity = row2.InputQuantity + (row1.InputQuantity - TTLInput)
                End If

            End If

            Me.CuttingDeliveryDetailsBindingSource.MoveNext()

            i = i + 1

        Loop

        Save()

    End Sub

    Private Sub EmbOrderGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles EmbOrderGridLookUpEdit.EditValueChanged

        On Error Resume Next

        If ChallanForLookupEdit.Text = "Embroidery" Then
            Me.EmbOrderDetailsLookupTableAdapter.FillByEmbOrderId(Me.EmbOrderDetailsLookupDataSet.EmbOrderDetailsLookup, CType(EmbOrderGridLookUpEdit.EditValue, Long))
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.CuttingDeliveryEmbDetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryEmbDetails, ChallanLookupGridLookUpEdit.EditValue)

        If Me.CuttingDeliveryEmbDetailsBindingSource.Position = -1 Then
            For Each drv As DataRowView In CuttingDeliveryDetailsBindingSource.List

                If ChallanForLookupEdit.Text = "Embroidery" AndAlso drv!CuttingDeliveryDetailsId > -1 Then
                    GetCuttingDeliveryEmbDetails(drv!CuttingDeliveryDetailsId, drv!FabricColorId, drv!SizeId, EmbOrderGridLookUpEdit.EditValue)
                End If

            Next
        End If

        Me.CuttingDeliveryEmbDetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryEmbDetails, ChallanLookupGridLookUpEdit.EditValue)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.CuttingDeliveryPrintDetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryPrintDetails, ChallanLookupGridLookUpEdit.EditValue)


        For Each drv As DataRowView In CuttingDeliveryDetailsBindingSource.List

            If ChallanForLookupEdit.Text = "Printing" AndAlso drv!CuttingDeliveryDetailsId > -1 Then
                GetCuttingDeliveryPrintDetails(drv!CuttingDeliveryDetailsId, drv!FabricColorId, drv!SizeId, PrintOrderGridLookUpEdit.EditValue)
            End If

        Next

        Me.CuttingDeliveryPrintDetailsTableAdapter.Fill(Me.CuttingDeliveryDataSet.CuttingDeliveryPrintDetails, ChallanLookupGridLookUpEdit.EditValue)

    End Sub

    Private Sub PrintOrderGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles PrintOrderGridLookUpEdit.EditValueChanged
        On Error Resume Next

        If ChallanForLookupEdit.Text = "Printing" Then
            Me.PrintOrderLookupTableAdapter.FillPrintOrderNewId(Me.PrintProductionDataSet.PrintOrderLookup, CType(PrintOrderGridLookUpEdit.EditValue, Long))
        End If
    End Sub

    Private Sub CuttingNoGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles CuttingNoGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub CuttingDeliveryPrintDetailsGridControl_Click(sender As Object, e As EventArgs) Handles CuttingDeliveryPrintDetailsGridControl.Click

    End Sub
End Class