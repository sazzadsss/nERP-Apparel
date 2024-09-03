Imports System.Data.SqlClient
Imports System.Data

Public Class frmCuttingProduction



    Private Sub frmCuttingProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TwinPackLookupTableAdapter.Fill(Me.TwinPackLookupDataSet.TwinPackLookup)
        Me.CuttingRejectionTableAdapter.Fill(Me.CuttingProductionDataSet.CuttingRejection)
        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Me.CuttingProductionTableAdapter.FillByDateWise(Me.CuttingProductionDataSet.CuttingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text)
        Me.CuttingProductionDataSet.CuttingProduction.CuttingDateColumn.DefaultValue = DateTimePicker1.Text
        Me.CuttingProductionDataSet.CuttingProduction.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue

        'For Getting ParameterValue

        'Me.CuttingProductionDataSet.CuttingProduction.CFPColumn.DefaultValue = ReadData("Select NumberValue From Parameter Where PrameterId=11", cnn)

        RefreshSummery()

        'Start -------- Check and Set user rights

        If CheckUserRights("Cutting Production").CanEdit = False Then

            NewButton.Enabled = False
            SaveButton.Enabled = False

        End If

        'End ------- Check and Set user rights
        ' Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False
        'Me.CuttingProductionDataGridView.Columns("GarmentsPartColor").Visible = False

        HideCheckBox.Checked = True

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        Me.Validate()
        Me.CuttingProductionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CuttingProductionDataSet)


        RefreshSummery()

        'Me.ProgramNoComboBox2.Focus()
        'ExecuteQuery("Update CuttingProduction Set IsCuttingClose=1 Where IsCuttingClose is Null", cnn)

    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        Me.CuttingProductionDataSet.CuttingProduction.CuttingDateColumn.DefaultValue = DateTimePicker1.Text
        Me.CuttingProductionTableAdapter.FillByDateWise(Me.CuttingProductionDataSet.CuttingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text)

        'RefreshSummery()

        If CuttingProductionBindingSource.Position = -1 Then
            GetDataLinkLabel.Enabled = True
        Else
            GetDataLinkLabel.Enabled = False
        End If

        Me.CuttingProductionDataGridView.Columns(0).ReadOnly = True


    End Sub

    Private Sub BranchComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchComboBox.SelectedIndexChanged

        Me.CuttingProductionDataSet.CuttingProduction.BranchIdColumn.DefaultValue = BranchComboBox.SelectedValue
        Me.CuttingProductionTableAdapter.FillByDateWise(Me.CuttingProductionDataSet.CuttingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text)

        ' RefreshSummery()

        If CuttingProductionBindingSource.Position = -1 Then
            GetDataLinkLabel.Enabled = True
        Else
            GetDataLinkLabel.Enabled = False
        End If

        Me.CuttingProductionDataGridView.Columns(0).ReadOnly = True

    End Sub

    Private Sub FabricColorComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.LostFocus
        On Error Resume Next
        'If BranchCheckBox.Checked = True Then

        '    If CuttingProductionBindingSource.Position > -1 Then
        '        Dim Index As Integer
        '        Index = CuttingProductionBindingSource.Find("CuttingDate", DateTimePicker1.Text)
        '        CuttingProductionBindingSource.Position = Index
        '        CuttingProductionDataGridView.CurrentRow.Selected = True

        '    End If

        'End If

        'CuttingProductionBindingSource.AddNew()

        If OrderLookupBindingSource.Position > -1 Then

            Dim row As OrderLookupDataSet.OrderLookupRow
            row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

            Me.TwinPackfilteredTableAdapter.Fill(Me.TwinPackLookupDataSet.TwinPackfiltered, row.OrderId, FabricColorComboBox.SelectedValue)

        End If

    End Sub

    Private Sub ColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.SelectedIndexChanged


        'If OrderFabricColorBindingSource.Position > -1 Then

        '    If BranchCheckBox.Checked = True Then
        '        CuttingProductionTableAdapter.FillByBranchWise(Me.CuttingProductionDataSet.CuttingProduction, ProgramNoComboBox.SelectedValue, FabricColorComboBox.SelectedValue, BranchComboBox.SelectedValue)
        '    Else
        '        CuttingProductionTableAdapter.FillByOrderIdAndFabricColorId(Me.CuttingProductionDataSet.CuttingProduction, ProgramNoComboBox.SelectedValue, FabricColorComboBox.SelectedValue)
        '    End If

        Dim row As OrderLookupDataSet.OrderLookupRow
        row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)


        Me.TwinPackfilteredTableAdapter.Fill(Me.TwinPackLookupDataSet.TwinPackfiltered, row.OrderId, FabricColorComboBox.SelectedValue)
        Me.CuttingProductionDataSet.CuttingProduction.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue

        'End If

        Me.CuttingProductionDataSet.CuttingProduction.ConsumptionColumn.DefaultValue = 0

    End Sub




    Private Sub CuttingProductionBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles CuttingProductionBindingSource.AddingNew

        If OrderFabricColorBindingSource.Position > -1 Then

            Me.CuttingProductionDataSet.CuttingProduction.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue

        End If


        'If CuttingProductionDataGridView.RowCount > 1 Then

        '    Me.CuttingProductionDataSet.CuttingProduction.ConsumptionColumn.DefaultValue = CuttingProductionDataGridView.Rows(0).Cells(4).Value

        'End If

    End Sub



    Private Sub CuttingProductionDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CuttingProductionDataGridView.CellClick

        Me.CuttingProductionDataGridView.CurrentRow.Selected = True

    End Sub


    Private Sub RefreshSummery()


        'Go through all row  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        For index As Integer = 1 To CuttingProductionBindingSource.Count


            If CuttingProductionBindingSource.Position + 1 < CuttingProductionBindingSource.Count Then

                CuttingProductionBindingSource.MoveNext()
                CalculateSummery()
                ' Otherwise, move back to the first item.
            Else

                CuttingProductionBindingSource.MoveFirst()
                CalculateSummery()
            End If


        Next


        'Summery for Grand Total >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        Dim vCutting As Decimal = 0
        Dim vQC As Decimal = 0
        Dim vPrintReceive As Decimal = 0
        Dim vPrintSend As Decimal = 0
        Dim vInput As Decimal = 0
        Dim vReplace As Decimal = 0
        Dim vReject As Decimal = 0


        CuttingLabel.Text = 0
        QCPassLabel.Text = 0
        InputLabel.Text = 0
        ReplaceLabel.Text = 0
        RejectLabel.Text = 0



        For Each dr As DataRowView In CuttingProductionBindingSource.List

            If IsDBNull(dr!CuttingQuantity) = False Then
                vCutting = vCutting + dr!CuttingQuantity
                CuttingLabel.Text = vCutting
            Else
                vCutting = 0
                CuttingLabel.Text = 0
            End If


            If IsDBNull(dr!QCQuantity) = False Then
                vQC = vQC + dr!QCQuantity
                QCPassLabel.Text = vQC
            Else
                vQC = 0
                QCPassLabel.Text = 0
            End If


            If IsDBNull(dr!InputQuantity) = False Then
                vInput = vInput + dr!InputQuantity
                InputLabel.Text = vInput
            Else
                vInput = 0
                InputLabel.Text = 0
            End If


            'If IsDBNull(dr!PrintReceiveQuanity) = False Then
            '    vPrintReceive = vPrintReceive + dr!PrintReceiveQuantity
            '    'OutputLabel.Text = vOutput
            'Else
            '    vPrintReceive = 0
            '    'OutputLabel.Text = 0
            'End If


            If IsDBNull(dr!RejectQuantity) = False Then
                vReject = vReject + dr!RejectQuantity
                RejectLabel.Text = vReject
            Else
                vReject = 0
                RejectLabel.Text = 0
            End If

            If IsDBNull(dr!ReplaceQuantity) = False Then
                vReplace = vReplace + dr!ReplaceQuantity
                ReplaceLabel.Text = vReplace
            Else
                vReplace = 0
                ReplaceLabel.Text = 0
            End If

        Next

        'InputBalanceLabel.Text = CInt(InputLabel.Text) - CInt(OutputLabel.Text)
        'InputDiffLabel.Text = CInt(MMInputLabel.Text) - CInt(InputLabel.Text)
        'OutputDiffLabel.Text = CInt(MMOutputLabel.Text) - CInt(OutputLabel.Text)

    End Sub
    Private Sub CalculateSummery()

        'Calculate Summery >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        If CuttingProductionBindingSource.Position > -1 Then


            Dim row As CuttingProductionDataSet.CuttingProductionRow
            row = CType(CType(Me.CuttingProductionBindingSource.Current, DataRowView).Row, CuttingProductionDataSet.CuttingProductionRow)


            Dim connection As New SqlConnection(cnn)

            connection.Open()

            'If row.IsLineIdNull = False Then

            Dim cmd As SqlCommand = New SqlCommand("Select Sum(CuttingQuantity)As TTLCutting,Sum(QCQuantity) As TTLQC,Sum(PrintReceiveQuantity) As TTLPrintReceive,Sum(PrintSendQuantity) as TTLPrintSend,Sum(InputQuantity) as TTLInput , Sum(ReplaceQuantity) as TTLReplace,Sum(RejectQuantity) as TTLReject From CuttingProduction where OrderId=" & row.OrderId & "and FabricColorId=" & row.FabricColorId & "and BranchId=" & row.BranchId & " and CuttingDate<'" & row.CuttingDate & "'", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            reader.Read()


            If reader.IsDBNull(0) Then
                row.TCutting = row.CuttingQuantity
            Else
                row.TCutting = reader.GetDecimal(0) + CDec(row.CuttingQuantity)
            End If

            If reader.IsDBNull(1) Then
                row.TQC = row.QCQuantity
            Else
                row.TQC = reader.GetDecimal(1) + CDec(row.QCQuantity)
            End If

            If reader.IsDBNull(2) Then
                row.TPrintReceive = row.PrintReceiveQuantity
            Else
                row.TPrintReceive = reader.GetDecimal(2) + CDec(row.PrintReceiveQuantity)
            End If

            If reader.IsDBNull(3) Then
                row.TPrintSend = row.PrintSendQuantity
            Else
                row.TPrintSend = reader.GetDecimal(3) + CDec(row.PrintSendQuantity)
            End If

            If reader.IsDBNull(4) Then
                row.TInput = row.InputQuantity
            Else
                row.TInput = reader.GetDecimal(4) + CDec(row.InputQuantity)
            End If

            If reader.IsDBNull(5) Then
                row.TReplace = row.ReplaceQuantity
            Else
                row.TReplace = reader.GetDecimal(5) + CDec(row.ReplaceQuantity)
            End If

            If reader.IsDBNull(6) Then
                row.TReject = row.RejectQuantity
            Else
                row.TReject = reader.GetDecimal(6) + CDec(row.RejectQuantity)
            End If


            'End If



        End If

    End Sub


    Private Sub CuttingProductionBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CuttingProductionBindingSource.PositionChanged, CuttingProductionBindingSource.CurrentChanged

        'CalculateSummery()

    End Sub

    'Private Sub ProgramNoComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    '    Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoComboBox2.SelectedValue)
    '    Me.CuttingProductionDataSet.CuttingProduction.OrderIdColumn.DefaultValue = ProgramNoComboBox2.SelectedValue

    'End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        With frmDailyCuttingReport

            .MdiParent = frmMain
            .WindowState = FormWindowState.Maximized
            .MIS = False
            .CuttingDate = Me.DateTimePicker1.Text
            .BranchId = Me.BranchComboBox.SelectedValue
            .Show()

        End With

    End Sub

    Private Sub CuttingProductionDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CuttingProductionDataGridView.CellEndEdit

        'CalculateSummery()

    End Sub

    
   
   



    Private Sub frmCuttingProduction_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyData = Keys.F3 Then

            Me.CuttingProductionBindingSource.AddNew()

        End If

    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        Me.CuttingProductionBindingSource.AddNew()

    End Sub

    Private Sub MultipartComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MultipartComboBox.LostFocus

        Me.CuttingProductionDataSet.CuttingProduction.TwinPackIdColumn.DefaultValue = MultipartComboBox.SelectedValue

    End Sub

    
   

    Private Sub MultipartComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultipartComboBox.SelectedIndexChanged

        Me.CuttingProductionDataSet.CuttingProduction.TwinPackIdColumn.DefaultValue = MultipartComboBox.SelectedValue

    End Sub

    Private Sub HideCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideCheckBox.CheckedChanged

        If HideCheckBox.Checked = True Then
            Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = True
        Else
            Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False
        End If

    End Sub

    

    'Private Sub ProgramNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoComboBox.SelectedIndexChanged

    '    If OrderLookupBindingSource.Position > -1 Then


    '        Dim row As OrderLookupDataSet.OrderLookupRow
    '        row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

    '        Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoComboBox.Text)

    '        If row.IsIsMultiPartNull = False Then


    '            If row.IsMultiPart = True Then

    '                MultipartComboBox.Visible = True
    '                MultipartLabel.Visible = True
    '                'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = True

    '            Else

    '                MultipartComboBox.Visible = False
    '                MultipartLabel.Visible = False
    '                'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False

    '            End If

    '        Else

    '            MultipartComboBox.Visible = False
    '            MultipartLabel.Visible = False
    '            'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False

    '        End If




    '        Me.CuttingProductionDataSet.CuttingProduction.OrderIdColumn.DefaultValue = row.OrderId
    '        Me.CuttingProductionDataSet.CuttingProduction.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue



    '    End If

    'End Sub

    
    
    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged, ProgramNoGridLookUpEdit.Closed

        If OrderLookupBindingSource.Position > -1 Then


            'Dim OrderId As Integer = ReadIntegerData("Select OrderId From [Order] Where ProgramNo='" & ProgramNoGridLookUpEdit.Text & "'", cnn)


            Dim row As OrderLookupDataSet.OrderLookupRow
            row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)


            Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoGridLookUpEdit.EditValue)

            If row.IsIsMultiPartNull = False Then


                If row.IsMultiPart = True Then

                    MultipartComboBox.Visible = True
                    MultipartLabel.Visible = True
                    'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = True

                Else

                    MultipartComboBox.Visible = False
                    MultipartLabel.Visible = False
                    'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False

                End If

            Else

                MultipartComboBox.Visible = False
                MultipartLabel.Visible = False
                'Me.CuttingProductionDataGridView.Columns("TwinPackId").Visible = False

            End If




            Me.CuttingProductionDataSet.CuttingProduction.OrderIdColumn.DefaultValue = ProgramNoGridLookUpEdit.EditValue
            Me.CuttingProductionDataSet.CuttingProduction.FabricColorIdColumn.DefaultValue = FabricColorComboBox.SelectedValue



        End If

    End Sub

    Private Sub ProgramNoGridLookUpEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.TextChanged

        On Error Resume Next

        'Dim OrderId As Integer = ReadIntegerData("Select OrderId From [Order] Where ProgramNo='" & ProgramNoGridLookUpEdit.Text & "'", cnn)
        Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, ProgramNoGridLookUpEdit.EditValue)

    End Sub


    Private Sub GetData()
        Try
            Dim connection As New SqlConnection(cnn)

            connection.Open()

            Dim cmd As SqlCommand = New SqlCommand("Select CuttingDate,OrderId,BranchId,FabricColorId,PrintPartId,TwinPackId,CuttingQuantity,QCPassed,InputQuantity,Rejection,Replaced,PrintSend,PrintReceived From CuttingSummery_ForDailyReport  where BranchId=" & BranchComboBox.SelectedValue & " and CuttingDate = '" & DateTimePicker1.Text & "'", connection)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            'reader.Read()


            While reader.Read()


                Dim vCuttingDate As Date = reader.GetDateTime(0)
                Dim vOrderId As Integer = reader.GetInt64(1)
                Dim vBranchId As Integer = reader.GetInt64(2)
                Dim vFabricColorId As Integer = reader.GetInt64(3)
                Dim vPrintPartId As Integer

                Dim LastPrintReceive As Integer = ReadData("Select Max(PrintReceiveQuantity) as TTLPrintReceived From CuttingProduction Group By OrderId,FabricColorId,BranchId Having FabricColorId=" & reader("FabricColorId") & " And OrderId= " & reader("OrderId") & "And BranchId=" & reader("BranchId"), cnn)
                Dim vPrintReceive As Integer = Val(reader("PrintReceived")) + Val(LastPrintReceive)

                Dim LastPrintSend As Integer = ReadData("Select Max(PrintSendQuantity) as TTLPrintReceived From CuttingProduction Group By OrderId,FabricColorId,BranchId Having FabricColorId=" & reader("FabricColorId") & " And OrderId= " & reader("OrderId") & "And BranchId=" & reader("BranchId"), cnn)
                Dim vPrintSend As Integer = Val(reader("PrintSend")) + Val(LastPrintSend)


                If reader.IsDBNull(4) Then
                    vPrintPartId = Nothing
                Else
                    vPrintPartId = reader.GetInt64(4)
                End If


                Dim vTwinPackId As Integer
                Dim vNullValue As Object = DBNull.Value

                'Try
                '    vTwinPackId = reader.GetInt64(4)
                'Catch
                '    vTwinPackId = vNullValue
                'End Try

                If reader.IsDBNull(5) Then
                    vTwinPackId = Nothing
                Else
                    vTwinPackId = reader.GetInt64(5)
                End If

                'On Error Resume Next


                Dim vCuttingQuantity As Integer = reader.GetDecimal(6)
                Dim vQCPassed As Integer = reader.GetDecimal(7)
                Dim vInputQuantity As Integer = reader.GetDecimal(8)
                Dim vRejection As Integer = reader.GetDecimal(9)
                Dim vReplaced As Integer = reader.GetDecimal(10)


                CuttingProductionTableAdapter.InsertQuery(vCuttingDate, vOrderId, vFabricColorId, 0, vCuttingQuantity, vQCPassed, 0, 0, vInputQuantity, vReplaced, vRejection, vBranchId, 0, 0, vPrintReceive, vPrintSend, 0, 0, 0, "-", "-", "-", vTwinPackId)
                'MessageBox.Show(reader.GetInt64(1).ToString)


            End While

            reader.Close()
            connection.Close()
            MessageBox.Show("Data Loaded Successfully", "Generation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        


    End Sub



  
    Private Sub GetDataLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GetDataLinkLabel.LinkClicked

        If CuttingProductionBindingSource.Position = -1 Then

            GetData()

        End If


    End Sub

    Private Sub CuttingProductionDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles CuttingProductionDataGridView.DataError
        On Error Resume Next

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        If BranchBindingSource.Position > -1 Then
            Dim row As BranchDataSet.BranchRow
            row = CType(CType(Me.BranchBindingSource.Current, DataRowView).Row, BranchDataSet.BranchRow)

            With frmCuttingRunningProgram
                .vBranchId = row.BranchId
                .WindowState = FormWindowState.Normal
                .ShowDialog()

            End With
           
        End If
        

    End Sub

    Private Sub CuttingProductionDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles CuttingProductionDataGridView.RowHeaderMouseDoubleClick

        'Dim row As CuttingProductionDataSet.CuttingProductionRow
        'row = CType(CType(Me.CuttingProductionBindingSource.Current, DataRowView).Row, CuttingProductionDataSet.CuttingProductionRow)

        'Dim CloseValue As Integer

        'If row.IsCuttingClose = True Then
        '    CloseValue = 0
        'Else
        '    CloseValue = 1
        'End If

        'ExecuteQuery("Update CuttingProduction Set IsCuttingClose=" & CloseValue & " Where OrderId=" & row.OrderId & "And FabricColorId=" & row.FabricColorId & "And BranchId=" & row.BranchId, cnn)

        'Me.CuttingProductionTableAdapter.FillByDateWise(Me.CuttingProductionDataSet.CuttingProduction, BranchComboBox.SelectedValue, DateTimePicker1.Text)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.CuttingProductionTableAdapter.FillByOrderIdAndFabricColorId(Me.CuttingProductionDataSet.CuttingProduction, ProgramNoGridLookUpEdit.EditValue, FabricColorComboBox.SelectedValue)
        Me.CuttingProductionDataGridView.Columns(0).ReadOnly = False
    End Sub
End Class