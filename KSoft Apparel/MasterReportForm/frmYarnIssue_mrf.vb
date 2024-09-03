Public Class frmYarnIssue_mrf
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property


    Private Sub FrmYarnIssue_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.PrgNo <> String.Empty Then

            Dim filterstring As String = "{FinishFabricBooking.ProgramNo} = '" & Me.PrgNo & "'"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramwiseYarnIssueReport_WithAllocate
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If
    End Sub
End Class