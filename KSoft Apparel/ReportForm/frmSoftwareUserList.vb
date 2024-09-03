Public Class frmSoftwareUserList

    Private Sub frmSoftwareUserList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        Dim filterstring As String = ""

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SoftwareUserList
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
End Class