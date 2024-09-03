Public Class frmPrint_mrf
    Private _OID As Integer
    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property
    Dim filterstring As String = ""


    Private Sub FrmPrint_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{Order.OrderId} = " & Me.OID

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyPrintProductionReport_ProgramWise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class