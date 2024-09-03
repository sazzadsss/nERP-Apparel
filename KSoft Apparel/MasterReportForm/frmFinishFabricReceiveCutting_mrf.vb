Public Class frmFinishFabricReceiveCutting_mrf
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


    Private Sub FrmFinishFabricReceiveCutting_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{FinishFabricReceiveIssue.IsGMTStore} AND {FinishFabricReceiveIssue.ReceiveQuantity} > 0.00 and {FinishFabricBooking.ProgramNo} = '" & Me.PrgNo & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FabricReceivedReport_Programwise_Apparel
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class