Imports System.Data.SqlClient

Public Class frmSewingDelivery
    Public addflag As Boolean

    Private Sub Save()

        Me.Validate()
        Me.SewingDeliveryBindingSource.EndEdit()
        Me.SewingDeliveryDetailsBindingSource.EndEdit()
        Me.SewingDeliverySizeDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SewingDeliveryDataSet)
        'addflag = False
    End Sub

    Private Sub frmSewingDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.OrderPOLookupNewTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupNew)
        Me.LineTableAdapter.FillBySection(Me.LineDataSet.Line, "Sewing")
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.SupplierLookupTableAdapter.Fill(Me.SupplierDataSet.SupplierLookup)
        Me.SewingDeliveryChallanLookupTableAdapter.Fill(Me.SewingDeliveryChallanLookupDataSet.SewingDeliveryChallanLookup)

    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click

        Me.SewingDeliveryBindingSource.AddNew()
        Dim ABC As String = Now.Year.ToString.Substring(2) & "SDC"
        Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0, CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From SewingDelivery Where ChallanNo Like '" & ABC & "%'", cnn)

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
                MessageBox.Show("Not allowed to print a already printed challan")
                Exit Sub
            Else
                GoTo Line1
            End If
        End If

Line1:

        If EditButton.Text = "&Update" Then

            Dim row As SewingDeliveryDataSet.SewingDeliveryRow
            row = CType(CType(Me.SewingDeliveryBindingSource.Current, DataRowView).Row, SewingDeliveryDataSet.SewingDeliveryRow)

            Save()

            EditButton.Text = "&Edit"
            NewButton.Enabled = True

            If addflag = True Then


                Dim ABC As String = Now.Year.ToString.Substring(2) & "SDC"
                Dim XYZ As String = ReadIntData("Select MAX(CAST(REVERSE(SUBSTRING(REVERSE(ChallanNo),0, CHARINDEX('C',REVERSE(ChallanNo)))) AS INT))  From SewingDelivery Where ChallanNo Like '" & ABC & "%'", cnn)

                Me.ChallanNoTextEdit.Text = Now.Year.ToString.Substring(2) & "SDC" & (Val(XYZ) + 1).ToString()
                'Me.ChallanDateDateEdit.Text = Today()

                Me.SewingDeliveryChallanLookupTableAdapter.Fill(Me.SewingDeliveryChallanLookupDataSet.SewingDeliveryChallanLookup)

                Me.ChallanLookupGridLookUpEdit.EditValue = row.SewingDeliveryId

                addflag = False
                'OrderIdGridLookUpEdit.Enabled = False



            End If


            If addflag = False Then

                If Me.SewingDeliveryDetailsBindingSource.Position = -1 Then
                    GetPO()
                End If

            End If

            Save()

            MessageBox.Show("Saved Successfully")

        Else

            EditButton.Text = "&Update"

        End If

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click


        Me.SewingDeliveryTableAdapter.Fill(Me.SewingDeliveryDataSet.SewingDelivery, ChallanLookupGridLookUpEdit.EditValue)
        Me.SewingDeliveryDetailsTableAdapter.Fill(Me.SewingDeliveryDataSet.SewingDeliveryDetails, ChallanLookupGridLookUpEdit.EditValue)
        Me.SewingDeliverySizeDetailsTableAdapter.Fill(Me.SewingDeliveryDataSet.SewingDeliverySizeDetails, ChallanLookupGridLookUpEdit.EditValue)


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

        If Me.SewingDeliveryDetailsBindingSource.Position = -1 Then
            'DeleteCuttingInput(Me.ChallanNoTextEdit.Text)
            SewingDeliveryBindingSource.RemoveCurrent()
            EditButton.Text = "Edit"
            Me.Validate()
            Me.SewingDeliveryBindingSource.EndEdit()
            Me.SewingDeliveryDetailsBindingSource.EndEdit()
            Me.SewingDeliverySizeDetailsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SewingDeliveryDataSet)
            MessageBox.Show("Delete Successfully")
        Else
            MessageBox.Show("Delete Details then try again.")
        End If

    End Sub

    Private Sub GetPO()

        On Error Resume Next

        Dim row As SewingDeliveryDataSet.SewingDeliveryRow
        row = CType(CType(Me.SewingDeliveryBindingSource.Current, DataRowView).Row, SewingDeliveryDataSet.SewingDeliveryRow)


        Using connection As New SqlConnection(cnn)

            Dim querystring As String = "Select SewingId,OrderDetailsId,OutputQuantity From SewingProduction Where SewingId not in (Select SewingId From SewingDeliveryDetails) And  OrderId=" & OrderIdGridLookUpEdit.EditValue & "And LineId=" & Me.LineIdGridLookUpEdit.EditValue & "And SewingDate='" & ChallanDateDateEdit.DateTime.Date & "'"
            Dim command As New SqlCommand(querystring, connection)

            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()

                If reader("OutputQuantity") > 0 Then

                    Dim newRow As SewingDeliveryDataSet.SewingDeliveryDetailsRow = Me.SewingDeliveryDataSet.SewingDeliveryDetails.NewRow()

                    newRow.SewingDeliveryId = row.SewingDeliveryId
                    newRow.OrderDetailsId = reader("OrderDetailsId").ToString
                    newRow.DeliveryQuantity = reader("OutputQuantity")
                    newRow.SewingId = reader("SewingId")

                    Me.SewingDeliveryDataSet.SewingDeliveryDetails.Rows.Add(newRow)

                End If

            End While

            reader.Close()

        End Using


    End Sub

    Private Sub OrderIdGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles OrderIdGridLookUpEdit.EditValueChanged
        On Error Resume Next

        Me.OrderPOLookupNewTableAdapter.FillByOrderId(Me.OrderPOLookupNewDataSet.OrderPOLookupNew, Me.OrderIdGridLookUpEdit.EditValue)
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        frmSewingDeliveryChallanPrint.SDID = Me.ChallanLookupGridLookUpEdit.EditValue
        ShowForm(frmSewingDeliveryChallanPrint)
    End Sub

    Private Sub CancelEntryButton_Click(sender As Object, e As EventArgs) Handles CancelEntryButton.Click
        If NewButton.Enabled = False Then
            NewButton.Enabled = True
            EditButton.Text = "&Edit"
            Me.SewingDeliveryTableAdapter.Fill(Me.SewingDeliveryDataSet.SewingDelivery, -1)
        End If
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click

    End Sub
End Class