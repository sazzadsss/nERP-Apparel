Public Class frmDyeline_srf
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property
    Private Sub frmDyeline_srf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class