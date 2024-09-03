Public Class frmWashingWorkSheetReport
    Private _WWSID As Integer
    Public Property WWSID() As Integer
        Get
            Return _WWSID
        End Get
        Set(ByVal value As Integer)
            _WWSID = value
        End Set
    End Property
    Private Sub frmWashingWorkSheetReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WashingRequestLookUpTableAdapter.Fill(Me.WashingRequestDataSet.WashingRequestLookUp)

        WashingRequestNoLookUpEdit.EditValue = WWSID

        Dim filterstring As String = "{WashingRequest.WashingRequestId}=" & WWSID
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New WashingWorkSheet
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim filterstring As String = "{WashingRequest.WashingRequestId}=" & WashingRequestNoLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New WashingWorkSheet
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
End Class