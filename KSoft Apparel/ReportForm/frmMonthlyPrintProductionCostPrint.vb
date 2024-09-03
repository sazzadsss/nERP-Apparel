Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmMonthlyPrintProductionCostPrint

    Dim filterstring As String = ""

    Private Sub frmMonthlyPrintProductionCostPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.ProductionMonthTableAdapter.Fill(Me.ProductionMonthDataSet.ProductionMonth)

    End Sub

   

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        If Me.ProductionMonthBindingSource.Position > -1 Then


            Dim row As ProductionMonthDataSet.ProductionMonthRow
            row = CType(CType(Me.ProductionMonthBindingSource.Current, DataRowView).Row, ProductionMonthDataSet.ProductionMonthRow)




            If SampleCheckBox.Checked = True Then

                filterstring = "{Recipe.Development} And {Recipe.ProductionMonthId} =" & GridLookUpEdit1.EditValue

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Monthly_Chemical_Cost_Report
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Else

                filterstring = "Not {Recipe.Development} And {Recipe.ProductionMonthId} =" & GridLookUpEdit1.EditValue
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Monthly_Chemical_Cost_Report
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            End If


        End If
        
    End Sub

    Private Sub ShowByProgramButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByProgramButton.Click

        Dim row As OrderLookupDataSet.OrderLookupRow
        row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

        filterstring = "{Recipe.OrderId} =" & GridLookUpEdit2.EditValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Monthly_Chemical_Cost_Report
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub StyleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StyleButton.Click

        Dim row As StyleLookupDataSet.StyleRow
        row = CType(CType(Me.StyleBindingSource.Current, DataRowView).Row, StyleLookupDataSet.StyleRow)

        filterstring = "{Recipe.StyleId} =" & StyleGridLookUpEdit.EditValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Monthly_Chemical_Cost_Report
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowExposeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowExposeButton.Click


      
        Dim row As ProductionMonthDataSet.ProductionMonthRow
        row = CType(CType(Me.ProductionMonthBindingSource.Current, DataRowView).Row, ProductionMonthDataSet.ProductionMonthRow)


        filterstring = "{ProductionMonth.ProductionMonthId} =" & row.ProductionMonthId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PrintingExposeCostingReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub GridLookUpEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles GridLookUpEdit2.EditValueChanged

        On Error Resume Next
        StyleGridLookUpEdit.EditValue = ReadIntegerData("Select StyleId From [Order] Where OrderId=" & GridLookUpEdit2.EditValue, cnn)

    End Sub
End Class