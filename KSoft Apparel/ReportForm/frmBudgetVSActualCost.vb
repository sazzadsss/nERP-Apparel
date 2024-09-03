Public Class frmBudgetVSActualCost
    Private Sub frmBudgetVSActualCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PreCostingNoLookupTableAdapter.Fill(Me.PreCostingNoLookupDataSet.PreCostingNoLookup)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filterstring = "{Order.IsRunning} And Not {Order.Discontinue}"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BudgetVsActual
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim filterstring As String = "{PreCostingMain.PreCostingId} =" & PrecostingGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BudgetVsActualProgramwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{PreCostingMain.IsComplete}"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BudgetVsActual
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        filterstring = "{PreCostingMain.IsApproved}"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BudgetVsActual
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        filterstring = "{PreCostingMain.IsCancel}"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BudgetVsActual
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class