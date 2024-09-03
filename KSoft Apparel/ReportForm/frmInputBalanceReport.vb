Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmInputBalanceReport
    Dim filterstring As String = "'"

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        filterstring = ""

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New INPUT_BALANCE
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
    

End Class