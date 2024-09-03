Public Class frmMachineRequireBySewingPlanning
    Dim SDate As Date
    Dim SDate2 As Date
    Dim filterstring As String

    Private Sub frmMachineRequireBySewingPlanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        SDate = Me.FinishingDateTimePicker.Text
        SDate2 = Me.FinishingDateTimePicker2.Text
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)
        filterstring = "{PlanningReport.AppointmentDates} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MachineRequireBySewingPlanning
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub
End Class