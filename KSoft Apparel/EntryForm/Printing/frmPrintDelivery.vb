Imports System.Data.SqlClient


Public Class frmPrintDelivery
    Public addflag As Boolean
    Private Sub frmPrintDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.PrintOrderNewLookupTableAdapter.Fill(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)

        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)

        'Me.PrintOrderNewLookupTableAdapter.Fill(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)
        Me.PrintingDeliveryChallanLookupTableAdapter.Fill(Me.PrintingDeliveryChallanLookupDataSet.PrintingDeliveryChallanLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.LineTableAdapter.FillBySection(Me.LineDataSet.Line, "Printing")
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.SupplierLookupTableAdapter.Fill(Me.SupplierDataSet.SupplierLookup)
        Me.PrintingDeliveryChallanLookupTableAdapter.Fill(Me.PrintingDeliveryChallanLookupDataSet.PrintingDeliveryChallanLookup)

    End Sub

    Private Sub PrintingDeliveryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

        Try
            Me.Validate()
            Me.PrintingDeliveryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrintingDeliveryDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Sub GetPrintDeliveryInPrint(ByVal ChallanNo As String)

        Using Connection As New SqlConnection(cnn)

            Connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("GetPrintDeliveryInPrint", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ChallanNo", ChallanNo)

            cmd.ExecuteNonQuery()

        End Using

    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click

        Me.PrintingDeliveryBindingSource.AddNew()
        'Dim ABC As String = Now.Year.ToString.Substring(2) & "PDC"
        'Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0, CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From PrintingDelivery Where ChallanNo Like '" & ABC & "%'", cnn)

        Me.ChallanNoTextEdit.Text = "TBA" 'Now.Year.ToString.Substring(2) & "SDC" & (Val(XYZ) + 1).ToString()
        Me.ChallanDateDateEdit.Text = Today()

        'Me.OrderIdGridLookUpEdit.Enabled = True

        addflag = True
        NewButton.Enabled = False
        EditButton.Enabled = True
        EditButton.Text = "&Update"
        CancelEntryButton.Enabled = True

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

        If EditButton.Text = "&Update" Then

            Dim row As PrintingDeliveryDataSet.PrintingDeliveryRow
            row = CType(CType(Me.PrintingDeliveryBindingSource.Current, DataRowView).Row, PrintingDeliveryDataSet.PrintingDeliveryRow)

            Save()

            EditButton.Text = "&Edit"
            NewButton.Enabled = True

            If addflag = True Then


                Dim ABC As String = Now.Year.ToString.Substring(2) & "PDC"
                Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0, CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From PrintingDelivery Where ChallanNo Like '" & ABC & "%'", cnn)

                Me.ChallanNoTextEdit.Text = Now.Year.ToString.Substring(2) & "PDC" & (Val(XYZ) + 1).ToString()
                'Me.ChallanDateDateEdit.Text = Today()

                Me.PrintingDeliveryChallanLookupTableAdapter.Fill(Me.PrintingDeliveryChallanLookupDataSet.PrintingDeliveryChallanLookup)

                Me.ChallanLookupGridLookUpEdit.EditValue = row.PrintingDeliveryId

                addflag = False
                'OrderIdGridLookUpEdit.Enabled = False



            End If


            'If addflag = False Then

            '    If Me.PrintingDeliveryDetailsBindingSource.Position = -1 Then
            '        GetPrintOutput()
            '    End If
            'End If
            Summery()
            Save()
            GetPrintDeliveryInPrint(Me.ChallanNoTextEdit.Text)

            MessageBox.Show("Saved Successfully")

        Else

            EditButton.Text = "&Update"

        End If

    End Sub
    Private Sub Save()



        Me.Validate()
        Me.PrintingDeliveryBindingSource.EndEdit()
        Me.PrintingDeliveryDetailsBindingSource.EndEdit()
        Me.PrintingDeliverySizeDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrintingDeliveryDataSet)

    End Sub
    Private Sub Summery()
        If Me.PrintingDeliveryDetailsBindingSource.Position > -1 Then

            Dim i As Integer = 0
            Me.PrintingDeliveryDetailsBindingSource.MoveFirst()

            Do While i <= Me.PrintingDeliveryDetailsBindingSource.Count - 1

                Dim row1 As PrintingDeliveryDataSet.PrintingDeliveryDetailsRow
                row1 = CType(CType(Me.PrintingDeliveryDetailsBindingSource.Current, DataRowView).Row, PrintingDeliveryDataSet.PrintingDeliveryDetailsRow)

                row1.DeliveryQuantity = 0
                For Each drv As DataRowView In Me.PrintingDeliverySizeDetailsBindingSource.List
                    row1.DeliveryQuantity = row1.DeliveryQuantity + drv!DeliveryQuantity
                Next

                i = i + 1

                Me.PrintingDeliveryDetailsBindingSource.MoveNext()
            Loop

        End If

    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        If PrintCount(Me.ChallanNoTextEdit.Text, True) > 0 Then
            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed challan")
                Exit Sub
            Else
                GoTo Line1
            End If
        End If

Line1:

        If Me.PrintingDeliveryDetailsBindingSource.Position = -1 Then
            'DeleteCuttingInput(Me.ChallanNoTextEdit.Text)
            PrintingDeliveryBindingSource.RemoveCurrent()
            EditButton.Text = "Edit"
            Me.Validate()
            Me.PrintingDeliveryBindingSource.EndEdit()
            Me.PrintingDeliveryDetailsBindingSource.EndEdit()
            Me.PrintingDeliverySizeDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PrintingDeliveryDataSet)
            MessageBox.Show("Delete Successfully")
        Else
            MessageBox.Show("Delete Details then try again.")
        End If


    End Sub

    Private Sub CancelEntryButton_Click(sender As Object, e As EventArgs) Handles CancelEntryButton.Click

        If NewButton.Enabled = False Then

            NewButton.Enabled = True
            EditButton.Text = "&Edit"
            Me.PrintingDeliveryTableAdapter.Fill(Me.PrintingDeliveryDataSet.PrintingDelivery, -1)

        End If

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

        frmPrintingDeliveryChallanPrint.PDID = Me.ChallanLookupGridLookUpEdit.EditValue
        ShowForm(frmPrintingDeliveryChallanPrint)

    End Sub

    Private Sub GetPrintOutput(ByVal ProdDate As Date)

        Try

            Dim row As PrintingDeliveryDataSet.PrintingDeliveryRow
            row = CType(CType(Me.PrintingDeliveryBindingSource.Current, DataRowView).Row, PrintingDeliveryDataSet.PrintingDeliveryRow)


            Using connection As New SqlConnection(cnn)

                Dim querystring As String = "Select PrintProductionId,PrintOrderId,PrintProductionId,GMPrintQuantity From PrintProduction Where PrintOrderId in (SELECT PrintOrderId FROM PrintOrder WHERE PrintOrderDetailsId in (Select PrintOrderDetailsId From PrintOrderDetails Where PrintOrderNewId=" & Me.OrderIdGridLookUpEdit.EditValue & ")) And PrintProductionDate='" & ProdDate & "'"
                Dim command As New SqlCommand(querystring, connection)

                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()


                    If reader("GMPrintQuantity") > 0 Then

                        Dim newRow As PrintingDeliveryDataSet.PrintingDeliveryDetailsRow = Me.PrintingDeliveryDataSet.PrintingDeliveryDetails.NewRow()

                        newRow.PrintingDeliveryId = row.PrintingDeliveryId
                        newRow.PrintOrderid = reader("PrintOrderId").ToString
                        newRow.DeliveryQuantity = reader("GMPrintQuantity")
                        newRow.PrintProductionId = reader("PrintProductionId")

                        Me.PrintingDeliveryDataSet.PrintingDeliveryDetails.Rows.Add(newRow)

                    End If

                End While

                reader.Close()

            End Using

            Save()

            Me.PrintingDeliveryDetailsTableAdapter.Fill(Me.PrintingDeliveryDataSet.PrintingDeliveryDetails, ChallanLookupGridLookUpEdit.EditValue)

            Dim i As Integer = 0
            Me.PrintingDeliveryDetailsBindingSource.MoveFirst()

            Do While i <= Me.PrintingDeliveryDetailsBindingSource.Count - 1

                Dim row1 As PrintingDeliveryDataSet.PrintingDeliveryDetailsRow
                row1 = CType(CType(Me.PrintingDeliveryDetailsBindingSource.Current, DataRowView).Row, PrintingDeliveryDataSet.PrintingDeliveryDetailsRow)

                Using connection As New SqlConnection(cnn)
                    Dim command As New SqlCommand("Select SizeId,TTLPrintQuantity From PrintProductionSummerySizewise Where PrintProductionId=" & row1.PrintProductionId, connection)
                    command.Connection.Open()
                    command.ExecuteNonQuery()

                    Dim reader As SqlDataReader = command.ExecuteReader()

                    If reader.HasRows Then
                        row1.DeliveryQuantity = 0
                        Do While reader.Read()

                            Dim TTLDelQty As Integer = ReadIntData("Select Sum(DeliveryQuantity) From PrintDeliverySummerySizewiseAndPProdID Where SizeId=" & reader("SizeId") & "And PrintProductionId=" & row1.PrintProductionId, cnn)

                            If (reader("TTLPrintQuantity") - TTLDelQty) > 0 Then

                                Dim newRow = CType(Me.PrintingDeliveryDataSet.PrintingDeliverySizeDetails.NewRow(), PrintingDeliveryDataSet.PrintingDeliverySizeDetailsRow)
                                newRow.PrintingDeliveryDetailsId = row1.PrintingDeliveryDetailsId
                                newRow.SizeId = reader("SizeId")
                                newRow.DeliveryQuantity = reader("TTLPrintQuantity") - TTLDelQty
                                row1.DeliveryQuantity = row1.DeliveryQuantity + newRow.DeliveryQuantity
                                Me.PrintingDeliveryDataSet.PrintingDeliverySizeDetails.Rows.Add(newRow)

                            End If

                        Loop

                    End If

                    reader.Close()



                End Using
                i = i + 1

                Me.PrintingDeliveryDetailsBindingSource.MoveNext()
            Loop

            Save()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click

        Me.PrintingDeliveryTableAdapter.Fill(Me.PrintingDeliveryDataSet.PrintingDelivery, ChallanLookupGridLookUpEdit.EditValue)
        Me.PrintingDeliveryDetailsTableAdapter.Fill(Me.PrintingDeliveryDataSet.PrintingDeliveryDetails, ChallanLookupGridLookUpEdit.EditValue)
        Me.PrintingDeliverySizeDetailsTableAdapter.Fill(Me.PrintingDeliveryDataSet.PrintingDeliverySizeDetails, ChallanLookupGridLookUpEdit.EditValue)
        Me.PrintOrderLookupNewTableAdapter.Fill(Me.PrintProductionDataSet.PrintOrderLookupNew, ChallanLookupGridLookUpEdit.EditValue)

    End Sub

    Private Sub OrderIdGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles OrderIdGridLookUpEdit.EditValueChanged
        'On Error Resume Next
        'Dim OID As Integer = ReadIntegerData("Select OrderId From PrintOrderNew Where PrintOrderNewId=" & OrderIdGridLookUpEdit.EditValue, cnn)
        ''If OID > 0 Then
        ''    Me.SizeLookupTableAdapter.Fill(Me.SizeLookupDataSet.SizeLookup, OID)
        ''Else
        ''    Me.SizeLookupTableAdapter.FillByAll(Me.SizeLookupDataSet.SizeLookup)
        ''End If

        'Me.PrintOrderLookupTableAdapter.FillPrintOrderNewId(Me.PrintProductionDataSet.PrintOrderLookup, OrderIdGridLookUpEdit.EditValue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GetButton.Click

        If PrintCount(Me.ChallanNoTextEdit.Text, True) > 0 Then

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed challan")
                Exit Sub
            Else
                GoTo Line1
            End If

        End If

Line1:

        If addflag = False Then

            'If Me.PrintingDeliveryDetailsBindingSource.Position = -1 Then
            GetPrintOutput(ProductionDateEdit.DateTime.Date)
            Me.PrintOrderLookupNewTableAdapter.Fill(Me.PrintProductionDataSet.PrintOrderLookupNew, ChallanLookupGridLookUpEdit.EditValue)
            'End If
        End If
        Summery()
        Save()
    End Sub

    Private Sub ChallanLookupGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ChallanLookupGridLookUpEdit.EditValueChanged

    End Sub
End Class