Public Class frmShipmentReport

    Private Sub frmShipmentReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DeliveryChallanLookUpTableAdapter.Fill(Me.DeliveryChallanLookUpDataSet.DeliveryChallanLookUp)

        Me.CommercialInvoiceLookUpTableAdapter.Fill(Me.CommercialInvoiceLookUpDataSet.CommercialInvoiceLookUp)
        Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
    End Sub

    Private Sub ShowButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton3.Click

        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{ShipmentWithChallan.OrderDetailsId} = " & GridLookUpEdit1.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentReportWithChallan
        MyReport.SetParameterValue("ShowFormat", "Program")
        MyReport.SetParameterValue("FromDate", FDate.Date)
        MyReport.SetParameterValue("ToDate", TDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton2.Click

        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{ShipmentWithChallan.ShipmentDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) AND not {ShipmentWithChallan.Discontinue}"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentReportWithChallan_ShipmentDate
        MyReport.SetParameterValue("ShowFormat", "Date")
        MyReport.SetParameterValue("FromDate", FDate.Date)
        MyReport.SetParameterValue("ToDate", TDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{ShipmentWithChallan.ChallanDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) AND not {ShipmentWithChallan.Discontinue}"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentReportWithChallan
        MyReport.SetParameterValue("ShowFormat", "Date")
        MyReport.SetParameterValue("FromDate", FDate.Date)
        MyReport.SetParameterValue("ToDate", TDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


    Private Sub CommercialShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommercialShowButton.Click
        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{ShipmentWithChallan.CommercialInvoiceNo} = '" & CommercialInvoiceLookUpEdit.Text & "'"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentReportWithChallan
        MyReport.SetParameterValue("ShowFormat", "Program")
        MyReport.SetParameterValue("FromDate", FDate.Date)
        MyReport.SetParameterValue("ToDate", TDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ChallanShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChallanShowButton.Click
        Dim FDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{ShipmentWithChallan.ChallanNo} = '" & ChallanNoGridLookUpEdit.Text & "'"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentReportWithChallan
        MyReport.SetParameterValue("ShowFormat", "Program")
        MyReport.SetParameterValue("FromDate", FDate.Date)
        MyReport.SetParameterValue("ToDate", TDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ProgramAllocationButton_Click(sender As Object, e As EventArgs) Handles ProgramAllocationButton.Click


        Dim filterstring As String = "{ShipmentWithChallan.ProgramNo} ='" & ProgramNoGridLookUpEdit.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentReportWithChallanbyprogram
        MyReport.SetParameterValue("ShowFormat", "Program")

        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
End Class