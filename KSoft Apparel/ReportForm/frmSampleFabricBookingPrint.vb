Public Class frmSampleFabricBookingPrint
    Private _BookingNo As String
    Public Property BookingNo() As String
        Get
            Return _BookingNo
        End Get
        Set(ByVal value As String)
            _BookingNo = value
        End Set
    End Property
    Dim filterstring As String = String.Empty

    Private Sub frmSampleFabricBookingPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SampleFabricBookingLookupTableAdapter.Fill(Me.SampleFabricBookingLookupDataSet.SampleFabricBookingLookup)

        If Me.BookingNo <> String.Empty Then
            filterstring = "{SampleFabricBooking.BookingNo} ='" & BookingNo.ToString & "'"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Sample_Fabric_Booking
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        filterstring = "{SampleFabricBooking.BookingNo} ='" & GridLookUpEdit1.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Sample_Fabric_Booking
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub
End Class