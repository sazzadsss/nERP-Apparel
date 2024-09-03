Public Class frmCuttingReportPOWise
    Private Sub frmDailyCuttingReportPOWise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
    End Sub

    Private Sub ProgramAllocationButton_Click(sender As Object, e As EventArgs) Handles ProgramAllocationButton.Click
        filterstring = "{Order.OrderId} =" & ProgramNoGridLookUpEdit.EditValue

        If SizeCheckBox.Checked = True Then

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingProductionPOWiseReportCrossTab
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingProductionPOWiseReportShowAllCuttingDataEntry
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If BuyerCheckBox.Checked Then
            filterstring = "{Order.IsRunning} And Not {Order.IsAdvance} And Not {Order.Discontinue} And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.IsRunning} And Not {Order.IsAdvance} And Not {Order.Discontinue}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingProductionPOWiseReportShowAllCuttingDataEntry
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If BuyerCheckBox.Checked Then
            filterstring = "{Order.IsRunning} And Not {Order.IsAdvance} And Not {Order.Discontinue} And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.IsRunning} And Not {Order.IsAdvance} And Not {Order.Discontinue}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingProductionPOWiseReportShow_OnlyPOwiseDataEntry
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub BuyerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BuyerCheckBox.CheckedChanged
        If BuyerCheckBox.Checked Then
            BuyerComboBox.Enabled = True
        Else
            BuyerComboBox.Enabled = False
        End If
    End Sub
End Class