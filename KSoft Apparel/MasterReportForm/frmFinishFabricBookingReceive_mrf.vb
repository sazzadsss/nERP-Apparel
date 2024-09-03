Public Class frmFinishFabricBookingReceive_mrf
    Dim filterString As String = ""
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property

    Private Sub FrmKnittingProduction_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterString = "{FinishFabricBooking.ProgramNo} = '" & Me.PrgNo & "'"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricBookingReceive
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub
End Class