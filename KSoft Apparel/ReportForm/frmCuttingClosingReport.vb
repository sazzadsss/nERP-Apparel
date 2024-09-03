Public Class frmCuttingClosingReport

    Private Sub ProgramAllocationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramAllocationButton.Click

        Dim filterstring As String = "{Order.ProgramNo} = '" & Me.ProgramNoGridLookUpEdit.Text & "' and {FabricColor.FabricColorName} = '" & ColorGridLookUpEdit.Text & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Cutting_Closing_Report

        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub


    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged

        Me.OrderFabricColorTableAdapter.FillByProgramNo(Me.OrderFabricColorDataSet.OrderFabricColor, Me.ProgramNoGridLookUpEdit.Text)

    End Sub

    Private Sub frmCuttingClosingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

    End Sub
End Class