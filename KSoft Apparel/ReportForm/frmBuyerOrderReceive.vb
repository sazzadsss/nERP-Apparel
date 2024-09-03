Public Class frmBuyerOrderReceive
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        filterstring = "Not {OrderBookingMaster.IsAdvance} And {OrderBookingMaster.OrderReceiveDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingReceive
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmBuyerOrderReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
    End Sub

    Private Sub BuyerButton_Click(sender As Object, e As EventArgs) Handles BuyerButton.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        filterstring = "Not {OrderBookingMaster.IsAdvance} And {OrderBookingMaster.OrderReceiveDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) and {Buyer.BuyerId} = " & BuyerGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingReceive
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        filterstring = "{OrderBookingMaster.IsAdvance} And {OrderBookingMaster.OrderReceiveDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingReceive
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text

        filterstring = "{OrderBookingMaster.IsAdvance} And {OrderBookingMaster.OrderReceiveDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) and {Buyer.BuyerId} = " & BuyerGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New OrderBookingReceive
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class