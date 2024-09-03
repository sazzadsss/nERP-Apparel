Public Class frmBatch_mrf
    Private _prProgramNo As String
    Public Property prProgramNo() As String
        Get
            Return _prProgramNo
        End Get
        Set(ByVal value As String)
            _prProgramNo = value
        End Set
    End Property


    Private Sub FrmBatch_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{BatchInformation.ProgramNo}='" & Me.prProgramNo & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BatchReportByProgram
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class