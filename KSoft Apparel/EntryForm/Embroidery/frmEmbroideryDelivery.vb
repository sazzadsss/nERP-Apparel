Imports System.Data.SqlClient

Public Class frmEmbroideryDelivery
    Public addflag As Boolean


    Private Sub frmEmbroideryDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SizeDataSet.Size' table. You can move, or remove it, as needed.
        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)
        'TODO: This line of code loads data into the 'EmbOrderDetailsLookupDataSet.EmbOrderDetailsLookup' table. You can move, or remove it, as needed.
        Me.EmbOrderDetailsLookupTableAdapter.Fill(Me.EmbOrderDetailsLookupDataSet.EmbOrderDetailsLookup)
        Me.EmbOrderLookupTableAdapter.Fill(Me.EmbOrderLookupDataSet.EmbOrderLookup)
        Me.EmbDeliveryChallanLookupTableAdapter.Fill(Me.EmbDeliveryChallanLookupDataSet.EmbDeliveryChallanLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.LineTableAdapter.FillBySection(Me.LineDataSet.Line, "Embroidery")
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.SupplierLookupTableAdapter.Fill(Me.SupplierDataSet.SupplierLookup)


    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click

        Me.EmbDeliveryBindingSource.AddNew()
        Dim ABC As String = Now.Year.ToString.Substring(2) & "EMDC"
        Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0, CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From EmbDelivery Where ChallanNo Like '" & ABC & "%'", cnn)

        Me.ChallanNoTextEdit.Text = "TBA" 'Now.Year.ToString.Substring(2) & "SDC" & (Val(XYZ) + 1).ToString()
        Me.ChallanDateDateEdit.Text = Today()

        'Me.OrderIdGridLookUpEdit.Enabled = True

        addflag = True
        NewButton.Enabled = False
        EditButton.Enabled = True
        EditButton.Text = "&Update"
        CancelEntryButton.Enabled = True

    End Sub
    Public Sub GetEmbDeliveryInEmb(ByVal ChallanNo As String)

        Using Connection As New SqlConnection(cnn)

            Connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("GetEmbDeliveryInEmd", Connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ChallanNo", ChallanNo)

            cmd.ExecuteNonQuery()

        End Using

    End Sub
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

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

        If EditButton.Text = "&Update" Then
            Save()
            Dim row As EmbDeliveryDataSet.EmbDeliveryRow
            row = CType(CType(Me.EmbDeliveryBindingSource.Current, DataRowView).Row, EmbDeliveryDataSet.EmbDeliveryRow)

            EditButton.Text = "&Edit"
            NewButton.Enabled = True

            If addflag = True Then


                Dim ABC As String = Now.Year.ToString.Substring(2) & "EMBDC"
                Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0, CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From EmbDelivery Where ChallanNo Like '" & ABC & "%'", cnn)

                Me.ChallanNoTextEdit.Text = Now.Year.ToString.Substring(2) & "EMBDC" & (Val(XYZ) + 1).ToString()
                'Me.ChallanDateDateEdit.Text = Today()

                Me.EmbDeliveryChallanLookupTableAdapter.Fill(Me.EmbDeliveryChallanLookupDataSet.EmbDeliveryChallanLookup)

                Me.ChallanLookupGridLookUpEdit.EditValue = row.EmbDeliveryId

                addflag = False
                'OrderIdGridLookUpEdit.Enabled = False



            End If
            Save()

            If addflag = False Then

                If Me.EmbDeliveryDetailsBindingSource.Position = -1 Then
                    GetEmbOutput()
                End If

            End If

            Summery()
            Save()
            GetEmbDeliveryInEmb(Me.ChallanNoTextEdit.Text)

            MessageBox.Show("Saved Successfully")

        Else

            EditButton.Text = "&Update"

        End If

    End Sub
    Private Sub Save()

        Me.Validate()
        Me.EmbDeliveryBindingSource.EndEdit()
        Me.EmbDeliveryDetailsBindingSource.EndEdit()
        Me.EmbDeliverySizeDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmbDeliveryDataSet)

    End Sub
    Private Sub Summery()

        If Me.EmbDeliveryDetailsBindingSource.Position > -1 Then

            Dim i As Integer = 0
            Me.EmbDeliveryDetailsBindingSource.MoveFirst()

            Do While i <= Me.EmbDeliveryDetailsBindingSource.Count - 1

                Dim row1 As EmbDeliveryDataSet.EmbDeliveryDetailsRow
                row1 = CType(CType(Me.EmbDeliveryDetailsBindingSource.Current, DataRowView).Row, EmbDeliveryDataSet.EmbDeliveryDetailsRow)

                row1.DeliveryQuantity = 0
                For Each drv As DataRowView In Me.EmbDeliverySizeDetailsBindingSource.List
                    row1.DeliveryQuantity = row1.DeliveryQuantity + drv!DeliveryQuantity
                Next

                i = i + 1

                Me.EmbDeliveryDetailsBindingSource.MoveNext()
            Loop

        End If

    End Sub
    Private Sub GetEmbOutput()

        On Error Resume Next

        Dim row As EmbDeliveryDataSet.EmbDeliveryRow
        row = CType(CType(Me.EmbDeliveryBindingSource.Current, DataRowView).Row, EmbDeliveryDataSet.EmbDeliveryRow)


        Using connection As New SqlConnection(cnn)

            Dim querystring As String = "Select EmbProductionId,EmbOrderDetailsId,CheckedQuantity From EmbProduction Where EmbOrderDetailsId in (Select EmbOrderDetailsId From EmbOrderDetails Where EmbOrderId=(" & OrderIdGridLookUpEdit.EditValue & " )) And  EmbProductionDate='" & ProductionDateEdit.DateTime.Date & "'"
            Dim command As New SqlCommand(querystring, connection)

            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()

                If reader("CheckedQuantity") > 0 Then

                    Dim newRow As EmbDeliveryDataSet.EmbDeliveryDetailsRow = Me.EmbDeliveryDataSet.EmbDeliveryDetails.NewRow()

                    newRow.EmbDeliveryId = row.EmbDeliveryId
                    newRow.EmbOrderDetailsId = reader("EmbOrderDetailsId").ToString
                    newRow.DeliveryQuantity = reader("CheckedQuantity")
                    newRow.EmbProductionId = reader("EmbProductionId")

                    Me.EmbDeliveryDataSet.EmbDeliveryDetails.Rows.Add(newRow)

                End If

            End While

            reader.Close()

            Save()

        End Using


        Me.EmbDeliveryDetailsTableAdapter.Fill(Me.EmbDeliveryDataSet.EmbDeliveryDetails, ChallanLookupGridLookUpEdit.EditValue)

        Dim i As Integer = 0
        Me.EmbDeliveryDetailsBindingSource.MoveFirst()

        Do While i <= Me.EmbDeliveryDetailsBindingSource.Count - 1

            Dim row1 As EmbDeliveryDataSet.EmbDeliveryDetailsRow
            row1 = CType(CType(Me.EmbDeliveryDetailsBindingSource.Current, DataRowView).Row, EmbDeliveryDataSet.EmbDeliveryDetailsRow)

            Using connection As New SqlConnection(cnn)
                Dim command As New SqlCommand("Select SizeId,TTLCheckedQuantity From EmbProductionSummerySizewise Where EmbProductionId=" & row1.EmbProductionId, connection)
                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.HasRows Then

                    Do While reader.Read()

                        Dim TTLDelQty As Integer = ReadIntData("Select Sum(DeliveryQuantity) AS TTLCheckedQuantity From EmbDeliverySummerySizewiseAndEProdID Where SizeId=" & reader("SizeId") & "And EmbProductionId=" & row1.EmbProductionId, cnn)

                        If (reader("TTLCheckedQuantity") - TTLDelQty) > 0 Then

                            Dim newRow = CType(Me.EmbDeliveryDataSet.EmbDeliverySizeDetails.NewRow(), EmbDeliveryDataSet.EmbDeliverySizeDetailsRow)

                            newRow.EmbDeliveryDetailsId = row1.EmbDeliveryDetailsId
                            newRow.SizeId = reader("SizeId")
                            newRow.DeliveryQuantity = reader("TTLCheckedQuantity") - TTLDelQty

                            Me.EmbDeliveryDataSet.EmbDeliverySizeDetails.Rows.Add(newRow)

                        End If



                    Loop

                End If

                reader.Close()



            End Using
            i = i + 1

            Me.EmbDeliveryDetailsBindingSource.MoveNext()
        Loop

        Save()

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

        If Me.EmbDeliveryDetailsBindingSource.Position = -1 Then
            'DeleteCuttingInput(Me.ChallanNoTextEdit.Text)
            EmbDeliveryBindingSource.RemoveCurrent()
            EditButton.Text = "Edit"
            Me.Validate()
            Me.EmbDeliveryBindingSource.EndEdit()
            Me.EmbDeliveryDetailsBindingSource.EndEdit()
            Me.EmbDeliverySizeDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.EmbDeliveryDataSet)
            MessageBox.Show("Delete Successfully")
        Else
            MessageBox.Show("Delete Details then try again.")
        End If

    End Sub

    Private Sub CancelEntryButton_Click(sender As Object, e As EventArgs) Handles CancelEntryButton.Click
        If NewButton.Enabled = False Then

            NewButton.Enabled = True
            EditButton.Text = "&Edit"
            Me.EmbDeliveryTableAdapter.Fill(Me.EmbDeliveryDataSet.EmbDelivery, -1)

        End If
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        frmEmbroideryDeliveryChallanPrint.EMBDID = Me.ChallanLookupGridLookUpEdit.EditValue
        ShowForm(frmEmbroideryDeliveryChallanPrint)
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click

        Me.EmbDeliveryTableAdapter.Fill(Me.EmbDeliveryDataSet.EmbDelivery, ChallanLookupGridLookUpEdit.EditValue)
        Me.EmbDeliveryDetailsTableAdapter.Fill(Me.EmbDeliveryDataSet.EmbDeliveryDetails, ChallanLookupGridLookUpEdit.EditValue)
        Me.EmbDeliverySizeDetailsTableAdapter.Fill(Me.EmbDeliveryDataSet.EmbDeliverySizeDetails, ChallanLookupGridLookUpEdit.EditValue)
        Me.EmbOrderDetailsLookupByEDIDTableAdapter.Fill(Me.EmbOrderDetailsLookupDataSet.EmbOrderDetailsLookupByEDID, ChallanLookupGridLookUpEdit.EditValue)

    End Sub

    Private Sub OrderIdGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles OrderIdGridLookUpEdit.EditValueChanged

        On Error Resume Next
        Me.EmbOrderDetailsLookupTableAdapter.Fill(Me.EmbOrderDetailsLookupDataSet.EmbOrderDetailsLookup)
        Me.SizeLookupTableAdapter.Fill(Me.SizeLookupDataSet.SizeLookup, OrderIdGridLookUpEdit.EditValue)

    End Sub

    Private Sub GetButton_Click(sender As Object, e As EventArgs) Handles GetButton.Click

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

            'If Me.EmbDeliveryDetailsBindingSource.Position = -1 Then
            GetEmbOutput()
            'End If
            Me.EmbOrderDetailsLookupByEDIDTableAdapter.Fill(Me.EmbOrderDetailsLookupDataSet.EmbOrderDetailsLookupByEDID, ChallanLookupGridLookUpEdit.EditValue)
        End If

        Summery()
        Save()


    End Sub
End Class