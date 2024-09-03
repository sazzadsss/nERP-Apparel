Public Class frmCuttingJobCard
    Dim filterstring As String = ""

    Private Sub frmCuttingJobCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

    End Sub

    Private Sub OrderNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderNoGridLookUpEdit.EditValueChanged, OrderNoGridLookUpEdit.Closed

       

        Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, OrderNoGridLookUpEdit.Text)



    End Sub

    Private Sub FabricColorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FabricColorComboBox.SelectedIndexChanged

        Dim row As OrderLookupDataSet.OrderLookupRow
        row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

        Me.CuttingNoLookupTableAdapter.Fill(Me.CuttingNoLookupDataSet.CuttingNoLookup, row.OrderId, FabricColorComboBox.SelectedValue)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        '{Order.ProgramNo} = "1085" and {CuttingProductionNewView.CuttingNo} = 1
        '{Order.ProgramNo} = "1085" and {CuttingProductionNewView.CuttingNo} = 1 and {CuttingProductionNewView.FabricColorId} = 43.00

        filterstring = "{Order.ProgramNo} = '" & OrderNoGridLookUpEdit.Text & "' and {CuttingProductionNewView.CuttingNo} = " & Me.CuttingNoComboBox.SelectedValue & "and {CuttingProductionNewView.FabricColorId} = " & FabricColorComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Cutting_Job_Card
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class