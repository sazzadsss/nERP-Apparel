Public Class frmFinishingReportProgramWise
    Dim filterstring As String = ""
    Public PgNo As Integer

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        filterstring = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseSewingOutpurtReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmFinishingReportProgramWise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        filterstring = "{vOrder.OrderId} = " & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Finishing_Output
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        filterstring = "{vOrder.OrderId} = " & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Finishing_OutputSummery
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filterstring As String = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseSewingOutpurtSummeryReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class