Public Class frmShipmentComplete_mrf
    Private _OrderId As Integer
    Public Property OrderId() As Integer
        Get
            Return _OrderId
        End Get
        Set(ByVal value As Integer)
            _OrderId = value
        End Set
    End Property
    Dim filtestring As String = String.Empty


    Private Sub FrmShipmentComplete_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{Order.OrderId} = " & Me.OrderId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ShipmentCompletedbyProgramList
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class