Public Class frmPreCostingNewUser
    Private _CID As Integer
    Public Property CID() As Integer
        Get
            Return _CID
        End Get
        Set(ByVal value As Integer)
            _CID = value
        End Set
    End Property
    Private Sub FrmPreCostingNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PreCostingNoLookupTableAdapter.FillByLatest(Me.PreCostingNoLookupDataSet.PreCostingNoLookup)

        If Me.CID > 0 Then

            PrecostingGridLookUpEdit.EditValue = Me.CID
            Dim filterstring As String = "{PreCostingMain.PreCostingId} =" & PrecostingGridLookUpEdit.EditValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PreCostingNewGeneral
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
            'PdfViewer1.CloseDocument()
            'My.Computer.FileSystem.DeleteFile("E:\" & "CostSheet" & ".pdf")
            'ShowReportExport(MyReport, filterstring, "CostSheet")
            'PdfViewer1.LoadDocument("E:\" & "CostSheet" & ".pdf")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filterstring As String = "{PreCostingMain.PreCostingId} =" & PrecostingGridLookUpEdit.EditValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PreCostingNewGeneral
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        'PdfViewer1.CloseDocument()
        'My.Computer.FileSystem.DeleteFile("E: \" & "CostSheet" & ".pdf")
        'ShowReportExport(MyReport, filterstring, "CostSheet")
        'PdfViewer1.LoadDocument("E:\" & "CostSheet" & ".pdf")
    End Sub

    Private Sub ShowAmnd_Click(sender As Object, e As EventArgs) Handles ShowAmnd.Click
        Dim filterstring As String = "{PreCostingMain.PreCostingId} =" & AmndLookupGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PreCostingNewGeneral
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub PrecostingGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles PrecostingGridLookUpEdit.EditValueChanged
        On Error Resume Next
        Dim OID As Integer = ReadIntegerData("Select OrderId From PreCostingMain Where PreCostingId=" & PrecostingGridLookUpEdit.EditValue, cnn)
        PreCostingAmndLookupTableAdapter.Fill(Me.PreCostingNoLookupDataSet1.PreCostingAmndLookup, OID)
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class