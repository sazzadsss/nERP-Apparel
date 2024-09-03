Public Class frmShipmentSummeryRepot1
    Private Sub frmShipmentSummeryRepot1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateTimePicker.Value = StartMonth
        ToDateTimePicker.Value = EndMonth

        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

    End Sub

    Private Sub ShowYearlyButton_Click(sender As Object, e As EventArgs) Handles ShowYearlyButton.Click
        filterstring = "{MonthWiseShipment.Yr} in " & ComboBox1.Text & " to " & ComboBox2.Text

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseShipmentSummeryReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub SummeryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click

        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformation_BranchAndBuyer
        MyReport.SetParameterValue("FromDate", FDate.Date)
        MyReport.SetParameterValue("ToDate", TDate.Date)

        filterstring = "{ShipmentStatusSummerywithBranch.FinishingDate} In {?FromDate} To {?ToDate} And {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 And Not {vOrder.Discontinue}"         '" {ShipmentStatusSummerywithBranch.FinishingDate} In DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) To DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)And {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue & " And {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 "
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SFDate As Date = Me.FromDateTimePicker.Text
        Dim STDate As Date = Me.ToDateTimePicker.Text

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformationBuyerwise

        MyReport.SetParameterValue("FromDate", SFDate.Date)
        MyReport.SetParameterValue("ToDate", STDate.Date)

        filterstring = "{ShipmentStatusSummerywithBranch.FinishingDate} In {?FromDate} To {?ToDate} And {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 And Not {vOrder.Discontinue}"         '" {ShipmentStatusSummerywithBranch.FinishingDate} In DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) To DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)And {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue & " And {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 "
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


End Class