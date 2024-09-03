Public Class frmGGatePassPrint
    Private _FRID As Integer
    Public Property FRID() As Integer
        Get
            Return _FRID
        End Get
        Set(ByVal value As Integer)
            _FRID = value
        End Set
    End Property

    Private Sub frmGGatePassPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GGatePassLookupTableAdapter.Fill(Me.GGatePassLookupDataSet.GGatePassLookup, DepartmentId)
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim filterstring As String = "{GeneralGatePass.GeneralGatePassId} = " & Me.FRID

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GeneralGatePass
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        Dim filterstring As String = "{GeneralGatePass.GeneralGatePassId} = " & Me.FRID

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GeneralGatePass
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged
        Me.FRID = GridLookUpEdit1.EditValue
    End Sub
End Class