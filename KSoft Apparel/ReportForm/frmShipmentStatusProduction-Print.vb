
Public Class frmDelayShipmentStatusComments
    Dim filterstring As String = ""
    Private Sub frmDelayShipmentStatusComments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.BranchComboBox.SelectedValue = 3
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.DateTimePicker1.Text = Today()
        Me.DateTimePicker2.Text = Today()
    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim FDate As Date = Me.DateTimePicker1.Text
        Dim TDate As Date = Me.DateTimePicker2.Text
        ExecuteQuery("Update parameter Set NumberValue=" & OnTimeNumericUpDown.Value & "Where PrameterId=4", cnn)

        filterstring = "{@IsShipment} = 1.00 AND {ShipmentStatusSummerywithBranch.FinishingDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentStatus_Production
        MyReport.SetParameterValue("CheckBuyer", "Date")
        MyReport.SetParameterValue("FromDate", FDate.Date)
        MyReport.SetParameterValue("ToDate", TDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


    Private Sub ShowBuyerButton_Click(sender As Object, e As EventArgs) Handles ShowBuyerButton.Click
        Dim FDate As Date = Me.DateTimePicker1.Text
        Dim TDate As Date = Me.DateTimePicker2.Text
        Dim CheckBuyer As String = ""

        'If ByDateCheckBox.Checked Then
        filterstring = "{vOrder.BuyerCode} = '" & ComboBox2.Text & "' And{@IsShipment} = 1.00 AND not {vOrder.Discontinue} AND {ShipmentStatusSummerywithBranch.FinishingDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"
        CheckBuyer = "Date"
        'Else
        '    filterstring = "{vOrder.BuyerCode} = '" & ComboBox2.Text & "'And{@IsShipment} = 1.00 AND not {vOrder.Discontinue}"
        'End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentStatus_Production
        MyReport.SetParameterValue("CheckBuyer", CheckBuyer)
        MyReport.SetParameterValue("FromDate", FDate.Date)
        MyReport.SetParameterValue("ToDate", TDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ProgramAllocationButton_Click(sender As Object, e As EventArgs) Handles ProgramAllocationButton.Click

        filterstring = "{vOrder.OrderId} = " & ProgramNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentStatus_Productionbyprogram
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub AllBranch_Click(sender As Object, e As EventArgs) Handles AllBranch.Click

        SDate = Me.DateTimePicker1.Text
        SDate2 = Me.DateTimePicker2.Text

        Dim s As String = ""
        Dim s1 As String = ""

        s = MultipleProgramTextBox.Text

        s1 = s.Replace(", ", "','") 'You should use one space after first comma
        s1 = Trim(s1)




        filterstring = "{@IsShipment} = 1.00 AND {ShipmentStatusSummerywithBranch.FinishingDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  AND {Branch.BranchCode} like ['" & s1 & "']"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentStatus_Production
        MyReport.SetParameterValue("CheckBuyer", "Date")
        MyReport.SetParameterValue("FromDate", DateTimePicker1.Text)
        MyReport.SetParameterValue("ToDate", DateTimePicker2.Text)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)



    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        If Me.MultipleProgramTextBox.Text = String.Empty Then
            Me.MultipleProgramTextBox.Text = Me.BranchComboBox.Text
        Else
            Me.MultipleProgramTextBox.Text = Me.MultipleProgramTextBox.Text & ", " & Me.BranchComboBox.Text
        End If

    End Sub

    Private Sub ShowByBranchButton_Click(sender As Object, e As EventArgs) Handles ShowByBranchButton.Click

        Dim FDate As Date = Me.DateTimePicker1.Text
        Dim TDate As Date = Me.DateTimePicker2.Text
        ExecuteQuery("Update parameter Set NumberValue=" & OnTimeNumericUpDown.Value & "Where PrameterId=4", cnn)

        filterstring = "{@IsShipment} = 1.00 AND {ShipmentStatusSummerywithBranch.FinishingDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  AND {Branch.BranchId} = " & BranchComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentStatus_Production
        MyReport.SetParameterValue("CheckBuyer", "Date")
        MyReport.SetParameterValue("FromDate", FDate.Date)
        MyReport.SetParameterValue("ToDate", TDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
End Class