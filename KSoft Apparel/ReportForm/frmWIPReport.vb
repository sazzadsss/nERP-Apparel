Public Class frmWIPReport

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        Dim filterstring As String = ""

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New WIP_Report

        MyReport.SetParameterValue("@FromDate", "")
        MyReport.SetParameterValue("@ToDate", "")
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmWIPReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class