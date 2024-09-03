Public Class frmCuttingPOSizeWiseInputReport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filterstring = "{CuttingDeliveryPODetails.InputQuantity} > 0.00 And {CuttingDelivery.ChallanFor} = 1 And {vOrder.OrderId} =" & ProgramNoGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingPO_SizeWiseInputReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub frmCuttingPOSizeWiseInputReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)
    End Sub

    Private Sub ShowButton3_Click(sender As Object, e As EventArgs) Handles ShowButton3.Click
        filterstring = "{CuttingDeliveryPODetails.InputQuantity} > 0.00 And {CuttingDelivery.ChallanFor} = 1 And {vOrder.OrderDetailsId} =" & GridLookUpEdit1.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingPO_SizeWiseInputReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{CuttingDeliveryPODetails.InputQuantity} > 0.00 And {CuttingDelivery.ChallanFor} = 2 And {vOrder.OrderId} =" & ProgramNoGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingPO_SizeWiseInputReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        filterstring = "{CuttingDeliveryPODetails.InputQuantity} > 0.00 And {CuttingDelivery.ChallanFor} = 3 And {vOrder.OrderId} =" & ProgramNoGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingPO_SizeWiseInputReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        filterstring = "{CuttingDeliveryPODetails.InputQuantity} > 0.00 And {CuttingDelivery.ChallanFor} = 2 And {vOrder.OrderDetailsId} =" & GridLookUpEdit1.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingPO_SizeWiseInputReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        filterstring = "{CuttingDeliveryPODetails.InputQuantity} > 0.00 And {CuttingDelivery.ChallanFor} = 3 And {vOrder.OrderDetailsId} =" & GridLookUpEdit1.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingPO_SizeWiseInputReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class