Public Class frmWashingProductionReport

    Dim filterstring As String
    Private Sub frmWashingProductionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
    End Sub

    Private Sub ShowButton2_Click(sender As Object, e As EventArgs) Handles ShowButton2.Click
        filterstring = "{WashingRequest.ProgramNo} = '" & GridLookUpEdit1.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New WashingProductionReport_ProgramWise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ShowByDateButton_Click(sender As Object, e As EventArgs) Handles ShowByDateButton.Click
        Dim SDate As Date = Me.FromDateTimePicker.Text
        Dim SDate2 As Date = Me.ToDateTimePicker.Text
        Dim filterstring As String = "{WashingProduction.WashingProductionDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New WashingProductionReport_ProgramWise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class