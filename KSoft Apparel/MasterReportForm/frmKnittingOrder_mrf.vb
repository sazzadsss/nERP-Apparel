Public Class frmKnittingOrder_mrf
    Dim filterstring As String = ""
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property

    Private Sub FrmKnittingOrder_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{FinishFabricBooking.ProgramNo} = '" & Me.PrgNo & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New KnittingWorkOrderProgramwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class