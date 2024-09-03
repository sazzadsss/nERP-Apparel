Public Class frmDailyProductionTargetList


    Private Sub ShowAllButtong_Click(sender As Object, e As EventArgs) Handles ShowAllButtong.Click

        filterstring = "{ProductionTarget.ProductionDate} in DateTime (" & FromDateTimePicker.Value.Year & "," & FromDateTimePicker.Value.Month & "," & FromDateTimePicker.Value.Day & ", 00, 00, 00) to DateTime (" & ToDateTimePicker.Value.Year & "," & ToDateTimePicker.Value.Month & "," & ToDateTimePicker.Value.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyProductionTargetList
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmDailyProductionTargetList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class