Public Class frmMasterOrder_mrf
    Private _MOID As Integer
    Public Property MOID() As Integer
        Get
            Return _MOID
        End Get
        Set(ByVal value As Integer)
            _MOID = value
        End Set
    End Property
    Dim filterstring As String = ""


    Private Sub FrmMasterOrder_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{MasterOrder.MasterOrderId} =" & Me.MOID
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterOrderPrint
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class