Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPrintHourlyProductionGraph

    Dim filterstring As String = ""

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim SDate As Date = Me.DateTimePicker1.Text

        filterstring = "{PrintHourlyProductionSummery_Details.PrintProductionDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New HourlyPrintProduction
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub
End Class