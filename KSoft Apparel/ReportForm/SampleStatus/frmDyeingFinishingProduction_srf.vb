Public Class frmDyeingFinishingProduction_srf
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property
    Private Sub frmDyeingFinishingProduction_srf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterstring = "{BatchInformation.ProgramNo} ='" & Me.PrgNo & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyDyeingFinishingReportbyProgram
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class