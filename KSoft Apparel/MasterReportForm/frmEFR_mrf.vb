Public Class frmEFR_mrf
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property


    Private Sub FrmEFR_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filterstring As String = "{ExcessFabricRequest.FinishFabricBookingId}=" & ReadIntegerData("Select FinishFabricBookingId From FinishFabricBooking Where ProgramNo='" & Me.PrgNo & "'", cnn)
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ExcessFabricRequestPrintbyProgram
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class