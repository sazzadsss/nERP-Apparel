Public Class frmPreCostingPrint
    Private _CID As Integer
    Public Property CID() As Integer
        Get
            Return _CID
        End Get
        Set(ByVal value As Integer)
            _CID = value
        End Set
    End Property
    Private Sub frmPreCostingPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PreCostingNoLookupTableAdapter.Fill(Me.PreCostingNoLookupDataSet.PreCostingNoLookup)

        If Me.CID > 0 Then

            PrecostingGridLookUpEdit.EditValue = Me.CID
            Dim filterstring As String = "{PreCostingMain.PreCostingId} =" & PrecostingGridLookUpEdit.EditValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PreCostingNewA4
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
            'PdfViewer1.CloseDocument()
            'My.Computer.FileSystem.DeleteFile("E:\" & "CostSheet" & ".pdf")
            'ShowReportExport(MyReport, filterstring, "CostSheet")
            'PdfViewer1.LoadDocument("E:\" & "CostSheet" & ".pdf")

        End If


    End Sub


    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click, Button1.Click

        Dim filterstring As String = "{PreCostingMain.PreCostingId} =" & PrecostingGridLookUpEdit.EditValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PreCostingNew
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        'PdfViewer1.CloseDocument()
        'My.Computer.FileSystem.DeleteFile("E: \" & "CostSheet" & ".pdf")
        'ShowReportExport(MyReport, filterstring, "CostSheet")
        'PdfViewer1.LoadDocument("E:\" & "CostSheet" & ".pdf")


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filterstring As String = "{PreCostingMain.PreCostingId} =" & PrecostingGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BudgetVsActualProgramwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filterstring As String = "{PreCostingMain.PreCostingId} =" & PrecostingGridLookUpEdit.EditValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PreCostingNewA4
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        'PdfViewer1.CloseDocument()
        'My.Computer.FileSystem.DeleteFile("E: \" & "CostSheet" & ".pdf")
        'ShowReportExport(MyReport, filterstring, "CostSheet")
        'PdfViewer1.LoadDocument("E:\" & "CostSheet" & ".pdf")
    End Sub
End Class