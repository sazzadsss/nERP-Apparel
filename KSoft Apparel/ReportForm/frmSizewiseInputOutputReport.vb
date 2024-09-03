Public Class frmSizewiseInputOutputReport
    Private Sub frmSizewiseInputOutputReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LineTableAdapter.Fill(Me.LineDataSet.Line)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.OrderFabricColorTableAdapter.Fill(Me.OrderFabricColorDataSet.OrderFabricColor, OrderNoGridLookUpEdit.EditValue)
    End Sub

    Private Sub ShowByProgramButton_Click(sender As Object, e As EventArgs) Handles ShowByProgramButton.Click
        Dim filterstring As String = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseSewingOutpurtSummeryReport1
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        filterstring = "{vOrder.OrderId} = " & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Finishing_OutputSummery1
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{Order.OrderId} =" & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingReportSummery_ProgramWise_WithSize
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filterstring As String = "{Order.OrderId} = " & OrderNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LinewiseInputReport_Summery1
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class