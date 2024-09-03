Imports System.Data.SqlClient

Public Class frmEmbroideryProduction

    Private Sub EmbProductionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub frmEmbroideryProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SizeTableAdapter.Fill(Me.SizeDataSet.Size)
        Me.EmbMachineTableAdapter.Fill(Me.EmbMachineDataSet.EmbMachine)
        Me.EmbOrderDetailsLookupAllTableAdapter.Fill(Me.EmbOrderDetailsLookupDataSet.EmbOrderDetailsLookupAll)
        Me.EmbOrderDetailsLookupTableAdapter.Fill(Me.EmbOrderDetailsLookupDataSet.EmbOrderDetailsLookup)
        Me.EmbOrderLookupTableAdapter.Fill(Me.EmbOrderLookupDataSet.EmbOrderLookup)
        Me.ShiftTableAdapter.Fill(Me.ShiftDataSet.Shift)
        Me.CuttingDeliveryChallanLookupTableAdapter.FillByChallanFor(Me.CuttingDeliveryChallanLookupDataSet.CuttingDeliveryChallanLookup, "Embroidery")

        If CheckUserRights("Embroidery Production").CanEdit = False Then

            AddButton.Enabled = False
            SaveButton.Enabled = False

        ElseIf CheckUserRights("Embroidery Production").CanDelete = False Then

            AddButton.Enabled = True
            SaveButton.Enabled = True
        End If


    End Sub

    Private Sub EmbOrderNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbOrderNoGridLookUpEdit.EditValueChanged
        On Error Resume Next
        Me.EmbOrderDetailsLookupTableAdapter.FillByEmbOrderId(Me.EmbOrderDetailsLookupDataSet.EmbOrderDetailsLookup, EmbOrderNoGridLookUpEdit.EditValue)
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        Dim newRow As EmbProductionDataSet.EmbProductionRow = Me.EmbProductionDataSet.EmbProduction.NewRow()
        newRow.EmbOrderDetailsId = EmbOrderDetailsGridLookUpEdit.EditValue
        newRow.EmbProductionDate = DateEdit1.DateTime.Date
        newRow.ShiftId = Shift2GridLookUpEdit.EditValue
        Me.EmbProductionDataSet.EmbProduction.Rows.Add(newRow)

    End Sub
    Private Sub Save()
        Try
            Me.Validate()
            Me.EmbProductionBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.EmbProductionDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MessageBox.Show("Saved Successfully")
        End Try

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
        If UL <> 1 Then
            GoTo Line2
        Else
            GoTo Line1
        End If

Line2:
        If Me.EmbProductionBindingSource.Position > -1 Then

            Dim row As EmbProductionDataSet.EmbProductionRow
            row = CType(CType(Me.EmbProductionBindingSource.Current, DataRowView).Row, EmbProductionDataSet.EmbProductionRow)

            Dim chkPrintDel As Integer = ReadIntData("Select Count(EmbProductionId) From EmbDeliveryDetails Where EmbProductionId=" & row.EmbProductionId, cnn)

            If chkPrintDel > 0 Then
                MessageBox.Show("Not Saved,It is used in Print Delivery Challan")
                Exit Sub
            End If

        End If


        'If chkInput = True Then

        '    MessageBox.Show("Not Saved. Output Quantity is greater than Sewing/Cutting Input Quantity")
        '    Exit Sub

        'End If
Line1:

        Save()
    End Sub

    Private Sub DateEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateEdit1.EditValueChanged
        On Error Resume Next

        Me.EmbProductionTableAdapter.FillByDate(Me.EmbProductionDataSet.EmbProduction, DateEdit1.DateTime.Date)
    End Sub

    Private Sub Shift2GridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shift2GridLookUpEdit.EditValueChanged
        On Error Resume Next

        Me.EmbProductionTableAdapter.FillDateAndShift(Me.EmbProductionDataSet.EmbProduction, DateEdit1.DateTime.Date, Shift2GridLookUpEdit.EditValue)
    End Sub

    Private Sub GetSizeLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GetSizeLinkLabel.LinkClicked

        'Getting Size List

        If Me.EmbSizewiseHourlyProductionBindingSource.Position > -1 Then
            Exit Sub
        Else

            'If Me.EmbSizewiseHourlyProductionBindingSource.Position = -1 Then
            '    Me.EmbSizewiseHourlyProductionBindingSource.AddNew()
            'End If

            Try
                Me.Validate()
                Me.EmbProductionBindingSource.EndEdit()
                Me.EmbSizewiseHourlyProductionBindingSource.EndEdit()

                Me.TableAdapterManager.UpdateAll(Me.EmbProductionDataSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Dim row As EmbProductionDataSet.EmbProductionRow
            row = CType(CType(Me.EmbProductionBindingSource.Current, DataRowView).Row, EmbProductionDataSet.EmbProductionRow)

            Using connection As New SqlConnection(cnn)

                Dim querystring As String = "Select Distinct SizeId From EmbOrderSizeDetails Where SizeId is NOT NULL And EmbOrderDetailsId=" & row.EmbOrderDetailsId.ToString()
                Dim command As New SqlCommand(querystring, connection)
                command.Connection.Open()
                command.ExecuteNonQuery()

                Dim reader As SqlDataReader = command.ExecuteReader()

                Dim row1 As EmbProductionDataSet.EmbProductionRow
                row1 = CType(CType(Me.EmbProductionBindingSource.Current, DataRowView).Row, EmbProductionDataSet.EmbProductionRow)

                While reader.Read()

                    Dim newRow As EmbProductionDataSet.EmbSizewiseHourlyProductionRow = Me.EmbProductionDataSet.EmbSizewiseHourlyProduction.NewRow()
                    newRow.EmbProductionId = row1.EmbProductionId
                    newRow.SizeId = reader("SizeId").ToString
                    newRow.Remarks = "-"
                    Debug.Print(reader("SizeId").ToString & vbNewLine)
                    Me.EmbProductionDataSet.EmbSizewiseHourlyProduction.Rows.Add(newRow)

                End While


            End Using

        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        CalculteSizeQuantity()
    End Sub
    Private Sub CalculteSizeQuantity()

        Dim vH1 As Integer = 0
        Dim vH2 As Integer = 0
        Dim vH3 As Integer = 0
        Dim vH4 As Integer = 0
        Dim vH5 As Integer = 0
        Dim vH6 As Integer = 0
        Dim vH7 As Integer = 0
        Dim vH8 As Integer = 0
        Dim vH9 As Integer = 0
        Dim vH10 As Integer = 0
        Dim vH11 As Integer = 0
        Dim vH12 As Integer = 0
        'Dim vHX As Integer = 0


        For Each drv As DataRowView In Me.EmbSizewiseHourlyProductionBindingSource.List

            vH1 = vH1 + drv!H1
            vH2 = vH2 + drv!H2
            vH3 = vH3 + drv!H3
            vH4 = vH4 + drv!H4
            vH5 = vH5 + drv!H5
            vH6 = vH6 + drv!H6
            vH7 = vH7 + drv!H7
            vH8 = vH8 + drv!H8
            vH9 = vH9 + drv!H9
            vH10 = vH10 + drv!H10
            vH11 = vH11 + drv!H11
            vH12 = vH12 + drv!H12
            'vHX = vHX + drv!HX

        Next


        Dim row3 As EmbProductionDataSet.EmbProductionRow
        row3 = CType(CType(Me.EmbProductionBindingSource.Current, DataRowView).Row, EmbProductionDataSet.EmbProductionRow)

        Dim row As EmbProductionDataSet.EmbSizewiseHourlyProductionRow
        row = CType(CType(Me.EmbSizewiseHourlyProductionBindingSource.Current, DataRowView).Row, EmbProductionDataSet.EmbSizewiseHourlyProductionRow)


        row3.CheckedQuantity = vH1 + vH2 + vH3 + vH4 + vH5 + vH6 + vH7 + vH8 + vH9 + vH10 + vH11 + vH12

    End Sub

    Private Sub GetDataButton_Click(sender As Object, e As EventArgs) Handles GetDataButton.Click

        Me.EmbProductionTableAdapter.FillByChallanNo(Me.EmbProductionDataSet.EmbProduction, ChallanNoGridLookUpEdit.EditValue)

        If Me.EmbProductionBindingSource.Position = -1 Then

            Using Connection As New SqlConnection(cnn)

                Connection.Open()

                Dim cmd As SqlCommand = New SqlCommand("GetEmbProdReceivedFromCDED", Connection)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ChallanNo", ChallanNoGridLookUpEdit.Text)

                cmd.ExecuteNonQuery()

            End Using

            Me.EmbProductionTableAdapter.FillByChallanNo(Me.EmbProductionDataSet.EmbProduction, ChallanNoGridLookUpEdit.EditValue)


        Else
            MessageBox.Show("Already Received the Challan")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ShwButton.Click

        Me.EmbProductionTableAdapter.FillByDate(Me.EmbProductionDataSet.EmbProduction, DateEdit1.DateTime.Date)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.EmbProductionBindingSource.Position > -1 Then
            Dim row As EmbProductionDataSet.EmbProductionRow
            row = CType(CType(Me.EmbProductionBindingSource.Current, DataRowView).Row, EmbProductionDataSet.EmbProductionRow)
            Me.EmbProdSizewiseInputTableAdapter.Fill(Me.EmbProductionDataSet.EmbProdSizewiseInput, row.EmbProductionId)

        End If

    End Sub

    Private Sub EmbProductionBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles EmbProductionBindingSource.PositionChanged

        If Me.EmbProductionBindingSource.Position > -1 Then

            Dim row As EmbProductionDataSet.EmbProductionRow
            row = CType(CType(Me.EmbProductionBindingSource.Current, DataRowView).Row, EmbProductionDataSet.EmbProductionRow)
            Me.EmbProdSizewiseInputTableAdapter.Fill(Me.EmbProductionDataSet.EmbProdSizewiseInput, row.EmbProductionId)
            Me.EmbSizewiseHourlyProductionTableAdapter.Fill(Me.EmbProductionDataSet.EmbSizewiseHourlyProduction, row.EmbProductionId)

        End If

    End Sub

    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click
        Me.EmbProductionTableAdapter.FillByEODID(Me.EmbProductionDataSet.EmbProduction, Me.EmbOrderDetailsGridLookUpEdit.EditValue)
        If Me.EmbProductionBindingSource.Position > -1 Then

            Dim row As EmbProductionDataSet.EmbProductionRow
            row = CType(CType(Me.EmbProductionBindingSource.Current, DataRowView).Row, EmbProductionDataSet.EmbProductionRow)
            Me.EmbProdSizewiseInputTableAdapter.Fill(Me.EmbProductionDataSet.EmbProdSizewiseInput, row.EmbProductionId)
            Me.EmbSizewiseHourlyProductionTableAdapter.Fill(Me.EmbProductionDataSet.EmbSizewiseHourlyProduction, row.EmbProductionId)

        End If
    End Sub
End Class