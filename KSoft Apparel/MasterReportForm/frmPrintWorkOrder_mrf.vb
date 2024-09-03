Public Class frmPrintWorkOrder_mrf
    Private _OID As Integer
    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property


    Private Sub FrmPrintWorkOrder_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{PrintOrderNew.OrderId} = " & Me.OID

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PrintWorkOrderProgramwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class