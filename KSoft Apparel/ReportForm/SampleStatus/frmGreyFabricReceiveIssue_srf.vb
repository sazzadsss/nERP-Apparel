Public Class frmGreyFabricReceiveIssue_srf
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property
    Private Sub frmGreyFabricReceiveIssue_srf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.PrgNo <> String.Empty Then

            filterstring = "{FinishFabricBooking.ProgramNo} = '" & Me.PrgNo & "'"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New GreigeFabricStoreStatusDatewise2_Details
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If
    End Sub
End Class