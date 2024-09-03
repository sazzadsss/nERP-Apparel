Public Class frmSampleOrder_srf
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

    Private Sub frmSampleOrder_srf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.PrgNo <> String.Empty Then
            filterstring = "{SampleRequestFinal.RequestNo}= '" & Me.PrgNo & "'"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Sample_Fabric_Booking
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If
    End Sub
End Class