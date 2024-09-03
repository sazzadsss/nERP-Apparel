Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmOrderStatusReport
    Dim filterstring As String = ""
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        'filterstring = "{CuttingProdSum_OrderBalance.TTLCutting} >= 0.00"
        'ShowOrderStatus()

    End Sub
   

    

   

   

    Private Sub ShowByLPDButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByLPDButton.Click

        If FinishingRadioButton.Checked Then

            filterstring = "{vFinishingProduction.LastFinishingDate} = DateTime (" & LPDDateTimePicker.Value.Year & "," & LPDDateTimePicker.Value.Month & "," & LPDDateTimePicker.Value.Day & ",00, 00, 00)AND not {vOrder.Discontinue}"

        ElseIf SewingRadioButton.Checked Then

            filterstring = "{SewingProdSum_OrderBalance.LSD} = DateTime (" & LPDDateTimePicker.Value.Year & "," & LPDDateTimePicker.Value.Month & "," & LPDDateTimePicker.Value.Day & ",00, 00, 00)AND not {vOrder.Discontinue}"

        ElseIf CuttingRadioButton.Checked Then

            filterstring = "{CuttingProdSum_OrderBalance.LCD} = DateTime (" & LPDDateTimePicker.Value.Year & "," & LPDDateTimePicker.Value.Month & "," & LPDDateTimePicker.Value.Day & ",00, 00, 00)AND not {vOrder.Discontinue}"


        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        filterstring = "{CuttingProdSum_OrderBalance.TTLCutting} >= 0.00 AND not {vOrder.Discontinue}"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatus_OrderWise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
    

    

    Private Sub CheckedComboBoxEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedComboBoxEdit1.EditValueChanged

        If CheckedComboBoxEdit1.Properties.Items.Count <> 0 Then

            Dim s As String = ""
            Dim s1 As String = ""

            s = CheckedComboBoxEdit1.Text

            s1 = s.Replace(", ", "','") 'You should use one space after first comma
            s1 = Trim(s1)

            'Me.PlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"
            'Me.SewingPlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"

            'MessageBox.Show(s1)

            filterstring = "{vOrder.ProgramNo} like ['" & s1 & "']"

           

            If ShowDetailsCheckBox.Checked Then
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
                ShowReport(MyReport, filterstring, CrystalReportViewer1)
            Else
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatus_OrderWise
                ShowReport(MyReport, filterstring, CrystalReportViewer1)
            End If



        End If
        'End If
    End Sub

    Private Sub FinishingRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishingRadioButton.CheckedChanged
        LPDDateTimePicker.Text = ReadDateData("Select Max(FinishingDate) as LastFinishingDate From FinishingProduction", cnn)
    End Sub

    Private Sub SewingRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SewingRadioButton.CheckedChanged
        LPDDateTimePicker.Text = ReadDateData("Select Max(SewingDate) as LastSewingDate From SewingProduction", cnn)
    End Sub

    Private Sub CuttingRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingRadioButton.CheckedChanged
        LPDDateTimePicker.Text = ReadDateData("Select Max(CuttingDate) as LastCuttingDate From CuttingProduction", cnn)
    End Sub



#Region "Background Process"
    ' Start the long process.
    Private Sub btnStartProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartProcess.Click
        ' Get ready.
        PrgLongProcess.Visible = True

        btnStartProcess.Enabled = False
        btnCancel.Enabled = True
        PrgLongProcess.Value = 0

        ProgressLabel.Text = "Please wait, while Loading..."
        'filterstring = "{Order.ProgramNo} = '" & Trim(frmMain.ProgramNoTextBox.Text.ToString) & "'"


        ' Start the worker.

        bgrLongProcess.WorkerReportsProgress = True
        bgrLongProcess.WorkerSupportsCancellation = True
        bgrLongProcess.RunWorkerAsync()

    End Sub

    ' Cancel the long process.
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        bgrLongProcess.CancelAsync()

    End Sub

    ' Display the progress.
    Private Sub bgrLongProcess_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgrLongProcess.ProgressChanged
        PrgLongProcess.Value = e.ProgressPercentage
    End Sub

    ' The worker is done.
    Private Sub bgrLongProcess_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgrLongProcess.RunWorkerCompleted

        btnStartProcess.Enabled = True
        btnCancel.Enabled = False
        PrgLongProcess.Visible = False
        ProgressLabel.Text = ""

        'CrystalReportViewer1.ReportSource = MyReport
        'CrystalReportViewer1.SelectionFormula = filterstring '"{ItemList.ItemId}=" & ItemListComboBox.SelectedValue
        'CrystalReportViewer1.RefreshReport()

        'If OrderLookupBindingSource.Position > -1 Then

        '    For Each dr In OrderLookupBindingSource.List
        '        CheckedComboBoxEdit1.Properties.Items.Add(dr!ProgramNo)
        '    Next

        'End If

        ShowDetailsCheckBox.Checked = False



    End Sub

    Private Sub bgrLongProcess_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgrLongProcess.DoWork

        If bgrLongProcess.CancellationPending Then Exit Sub
        bgrLongProcess.ReportProgress(e.Result)

        'ShowReport(MyReport, filterstring)

        'Me.StyleTableAdapter.Fill(Me.StyleDataSet.Style)
        'Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

    End Sub


#End Region

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'If OrderLookupBindingSource.Position > -1 Then

        '    For Each dr In OrderLookupBindingSource.List
        '        CheckedComboBoxEdit1.Properties.Items.Add(dr!ProgramNo)
        '    Next

        'End If

    End Sub

    Private Sub ProgramNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoTextBox.TextChanged
        On Error Resume Next
        Me.OrderLookupTableAdapter.FillByProgramNoContain(Me.OrderLookupDataSet.OrderLookup, ProgramNoTextBox.Text)
    End Sub

    Private Sub ProgramNoListBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgramNoListBox.Click

        filterstring = "{vOrder.ProgramNo} ='" & ProgramNoListBox.Text & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Me.OrderPOTableAdapter.FillByProgramNo(Me.OrderPOLookupDataSet.OrderP0Lookup, ProgramNoListBox.Text)
        Me.StyleLookupTableAdapter.FillByOrderId(Me.StyleLookupDataSet.StyleLookup, ProgramNoListBox.SelectedValue)

    End Sub

    

    

    Private Sub frmOrderStatusReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        Me.StyleNameMstTableAdapter.Fill(Me.StyleDataSet.StyleNameMst)

        'Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)

    End Sub

    Private Sub StyleListBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StyleListBox.Click

        On Error Resume Next

        Dim SNId As Integer = ReadIntegerData("Select StyleNameId From Style Where StyleName='" & StyleListBox.Text & "'", cnn)
        Me.StyleNameMstTableAdapter.FillByStyleNameId(Me.StyleDataSet.StyleNameMst, SNId)


        filterstring = "{vOrder.StyleName} ='" & StyleListBox.Text & "' AND not {vOrder.Discontinue}"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

   
    Private Sub StyleTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleTextBox.TextChanged

        On Error Resume Next

        Me.StyleLookupTableAdapter.FillByNameContain(Me.StyleLookupDataSet.StyleLookup, StyleTextBox.Text)
        

    End Sub

 
    

    Private Sub POTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POTextBox.TextChanged
        On Error Resume Next

        Me.OrderPOTableAdapter.FillByPOContain(Me.OrderPOLookupDataSet.OrderP0Lookup, POTextBox.Text)
    End Sub

    Private Sub POListBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles POListBox.Click

        filterstring = "{vOrder.OrderId} =" & POListBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub POListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POListBox.SelectedIndexChanged

    End Sub

    Private Sub ShowMultipleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMultipleButton.Click

        If MultipleProgramTextBox2.Text <> String.Empty Then

            Dim s As String = ""
            Dim s1 As String = ""

            s = MultipleProgramTextBox2.Text

            s1 = s.Replace(", ", "','") 'You should use one space after first comma
            s1 = Trim(s1)

            'Me.PlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"
            'Me.SewingPlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"

            'MessageBox.Show(s1)

            filterstring = "{vOrder.ProgramNo} like ['" & s1 & "']"



            If ShowDetailsCheckBox.Checked Then
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
                ShowReport(MyReport, filterstring, CrystalReportViewer1)
            Else
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatus_OrderWise
                ShowReport(MyReport, filterstring, CrystalReportViewer1)
            End If



        End If
        'End If
    End Sub

    Private Sub MultipleProgramTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultipleProgramTextBox.TextChanged
        On Error Resume Next
        Me.OrderLookupTableAdapter.FillByProgramNoContain(Me.OrderLookupDataSet.OrderLookup, MultipleProgramTextBox.Text)
    End Sub

    Private Sub MultipleProgramListBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MultipleProgramListBox.DoubleClick

        If Me.MultipleProgramTextBox2.Text = String.Empty Then
            Me.MultipleProgramTextBox2.Text = Me.MultipleProgramListBox.Text
        Else
            Me.MultipleProgramTextBox2.Text = Me.MultipleProgramTextBox2.Text & ", " & Me.MultipleProgramListBox.Text
        End If

    End Sub

   
    Private Sub MultipleProgramListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultipleProgramListBox.SelectedIndexChanged

    End Sub

    Private Sub ProgramNoListBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProgramNoListBox2.Click

        Dim FDate As Date = DateTimePicker3.Text
        Dim TDate As Date = DateTimePicker4.Text

        If ProgramNoCheckBox.Checked Then
            filterstring = "{vOrder.ProgramNo} = '" & ProgramNoListBox2.Text & "' and {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00)"
        Else
            filterstring = "{vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00)"
        End If

        '"vOrder.ProgramNo='" & ProgramNoListBox2.Text & "' And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    

    Private Sub ProgramNoTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoTextBox2.TextChanged

        On Error Resume Next
        Me.OrderLookupTableAdapter.FillByProgramNoContain(Me.OrderLookupDataSet.OrderLookup, ProgramNoTextBox2.Text)

    End Sub

    
    Private Sub ProgramNoListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoListBox2.SelectedIndexChanged

    End Sub

    Private Sub StyleNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleNameTextBox.TextChanged
        On Error Resume Next

        Me.StyleNameMstTableAdapter.FillByStyleName(Me.StyleDataSet.StyleNameMst, StyleNameTextBox.Text)

    End Sub

    Private Sub StyleListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleListBox.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click

        On Error Resume Next

        filterstring = "{Style.StyleNameId} =" & ListBox1.SelectedValue & " AND not {vOrder.Discontinue}"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

   
    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim FDate As Date = DateTimePicker3.Text
        Dim TDate As Date = DateTimePicker4.Text

        If BuyerCheckBox.Checked Then
            filterstring = "not {vOrder.Discontinue} And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00) And ISNULL({StylewiseTarget.TotalTargetQuantity})=True And {vOrder.BuyerId}=" & BuyerComboBox.SelectedValue
        Else
            filterstring = "not {vOrder.Discontinue} And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00) And ISNULL({StylewiseTarget.TotalTargetQuantity})=True"
        End If

       

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Layout_Pending_Style
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim FDate As Date = DateTimePicker3.Text
        Dim TDate As Date = DateTimePicker4.Text


        filterstring = "not {vOrder.Discontinue} And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Picture_Pending_Style
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ProgramNoTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ProgramNoTextBox.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.Handled = True

            filterstring = "{vOrder.ProgramNo} ='" & ProgramNoListBox.Text & "'"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Me.OrderPOTableAdapter.FillByProgramNo(Me.OrderPOLookupDataSet.OrderP0Lookup, ProgramNoListBox.Text)
            Me.StyleLookupTableAdapter.FillByOrderId(Me.StyleLookupDataSet.StyleLookup, ProgramNoListBox.SelectedValue)

        End If

    End Sub


    Private Sub StyleTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles StyleTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True

            On Error Resume Next

            filterstring = "{vOrder.StyleName} ='" & StyleListBox.Text & "' AND not {vOrder.Discontinue}"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
            ShowReport(MyReport, filterstring, CrystalReportViewer1)


        End If

    End Sub

    Private Sub POTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles POTextBox.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.Handled = True

            filterstring = "{vOrder.OrderId} =" & POListBox.SelectedValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderStatusDetails
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub

    

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim FDate As Date = DateTimePicker3.Text
        Dim TDate As Date = DateTimePicker4.Text

        If BuyerCheckBox.Checked Then
            filterstring = "not {vOrder.Discontinue} And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00) And ISNULL({StylewiseTarget.TotalTargetQuantity})=False And {vOrder.BuyerId}=" & BuyerComboBox.SelectedValue

        Else
            filterstring = "not {vOrder.Discontinue} And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00) And ISNULL({StylewiseTarget.TotalTargetQuantity})=False"

        End If
        

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Layout_Complete_Style
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim FDate As Date = DateTimePicker3.Text
        Dim TDate As Date = DateTimePicker4.Text


        filterstring = "not {vOrder.Discontinue} And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00) "

        If DetailsCheckBox.Checked Then
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New POCountByOrderRangeDetails
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        Else
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New POCountByOrderRange
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If
        
    End Sub

    Private Sub DetailsCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsCheckBox.CheckedChanged
        If DetailsCheckBox.Checked Then
            StyleCountButton.Enabled = False
        Else
            StyleCountButton.Enabled = True
        End If
    End Sub

    Private Sub StyleCountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleCountButton.Click
        Dim FDate As Date = DateTimePicker3.Text
        Dim TDate As Date = DateTimePicker4.Text


        filterstring = "not {vOrder.Discontinue} And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00) "

       
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StyleCountByOrderRange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub
End Class