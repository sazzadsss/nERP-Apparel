Public Class frmSample_mrf

    Private _BookingNo As String
    Public Property BookingNo() As String
        Get
            Return _BookingNo
        End Get
        Set(ByVal value As String)
            _BookingNo = value
        End Set
    End Property
    Dim filterstring As String = ""


    Private Sub FrmSample_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{SampleFabricBooking.BookingNo} ='" & Me.BookingNo & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Sample_Fabric_Booking
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class