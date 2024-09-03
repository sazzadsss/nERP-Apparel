Public Class frmEmailSMSUserList
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim filterstring As String = ""

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MailSMSUsersList
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class