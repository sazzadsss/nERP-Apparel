Public Class frmProgramStyleCancel
    Private Sub frmProgramStyleCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text
    End Sub

    Private Sub CencelShowButton_Click(sender As Object, e As EventArgs) Handles CencelShowButton.Click
        Dim SFDate As Date = Me.FromDateTimePicker.Text
        Dim STDate As Date = Me.ToDateTimePicker.Text

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentInformation

        MyReport.SetParameterValue("FromDate", SFDate.Date)
        MyReport.SetParameterValue("ToDate", STDate.Date)

        filterstring = "{vOrder.EX} in {?FromDate} to {?ToDate} and {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 AND {vOrder.Discontinue}"         '" {ShipmentStatusSummerywithBranch.FinishingDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue & " AND {ShipmentStatusSummerywithBranch.TTLShippment} > 0.00 "
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class