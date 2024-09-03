Public Class frmFabricBooking_mrf

    Private _FabricBOMId As Integer
    Public Property FabricBOMId() As Integer
        Get
            Return _FabricBOMId
        End Get
        Set(ByVal value As Integer)
            _FabricBOMId = value
        End Set
    End Property

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


    Private Sub FrmFabricBooking_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.OID >> 0 Then

            Me.FabricBOMId = ReadIntegerData("Select FabricBOMId From FabricBOM Where OrderId=" & Me.OID, cnn)
            Dim PgNo As String = ReadStringData("Select ProgramNo From [Order] Where OrderId=" & Me.OID, cnn)
            'Dim ProgAndAmnd As String =  'ProgramGridLookUpEdit.Text.Substring(0, ProgramGridLookUpEdit.Text.IndexOf(":")).Trim()
            filterstring = "{FabricBOM.FabricBOMId} =" & Me.FabricBOMId.ToString()

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FabricConsumptionFinal
            MyReport.SetParameterValue("PType", "Report")
            MyReport.SetParameterValue("PrintCount", PrintCount(PgNo, True))
            ShowReport(MyReport, filterstring, CrystalReportViewer1)


        End If
    End Sub
End Class