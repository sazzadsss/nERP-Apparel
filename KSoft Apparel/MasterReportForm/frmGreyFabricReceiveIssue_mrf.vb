Public Class frmGreyFabricReceiveIssue_mrf
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property
    Dim filterstring As String = String.Empty

    Private Sub FrmGreyFabricReceiveIssue_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filterstring As String = "{GreyFabricStoreStatus.ProgramNo} ='" & Me.PrgNo & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GreigeFabricStoreStatus_CompactbyProgram
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class