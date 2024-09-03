Public Class frmFabricReceivedReport
    Dim filterstring As String = String.Empty

    Private Sub ProgramAllocationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramAllocationButton.Click

        filterstring = "not {FinishFabricReceiveIssue.IsGMTStore} AND {FinishFabricReceiveIssue.IssueQuantity} > 0.00 and {FinishFabricBooking.ProgramNo} = '" & Me.ProgramNoGridLookUpEdit.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FabricReceivedReport_Programwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmFabricReceivedReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        'filterstring = "{FinishFabricReceiveIssue.IsGMTStore} AND {FinishFabricReceiveIssue.ReceiveQuantity} > 0.00 and {FinishFabricBooking.ProgramNo} = '" & Me.ProgramNoGridLookUpEdit.EditValue & "'"
        filterstring = "{FinishFabricReceiveIssue.IsGMTStore} AND {FinishFabricBooking.ProgramNo} = '" & Me.ProgramNoGridLookUpEdit.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FabricReceivedReport_Programwise_Apparel
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        filterstring = "{FinishFabricReceiveIssue.IsGMTStore} AND {FinishFabricBooking.ProgramNo} = '" & Me.ProgramNoGridLookUpEdit.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricReceiveIssueRollTracking_Programwise_Apparel
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class