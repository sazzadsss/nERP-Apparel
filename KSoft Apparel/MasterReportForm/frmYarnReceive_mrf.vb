Public Class frmYarnReceive_mrf
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub FrmYarnReceive_mrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class