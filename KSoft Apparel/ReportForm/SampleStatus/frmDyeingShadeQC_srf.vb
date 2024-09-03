Public Class frmDyeingShadeQC_srf
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property
    Private Sub frmDyeingShadeQC_srf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        filterstring = "{FinishFabricBooking.ProgramNo} = '" & Me.PrgNo & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DyeingShadeQCReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class