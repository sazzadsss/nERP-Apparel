Public Class frmSewingPlanningBalanceReport
    Dim filtestring As String = String.Empty
    Private Sub frmSewingPlanningBalanceReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SusStandardMstTableAdapter.Fill(Me.SusStandardDataSet.SusStandardMst)
        Me.FabricMaterialTypeTableAdapter.Fill(Me.FabricMaterialTypeDataSet.FabricMaterialType)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.UserLookupTableAdapter.Fill(Me.UserLookupDataSet.UserLookup)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If BuyerCheckBox.Checked Then
            filterstring = "{Order.IsRunning} And Not {Order.IsAdvance} And Not {Order.Discontinue} And {Buyer.BuyerCode} = '" & Me.BuyerComboBox.Text & "'"
        Else
            filterstring = "{Order.IsRunning} And Not {Order.IsAdvance} And Not {Order.Discontinue}"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SweingPlanningBalanceReport
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