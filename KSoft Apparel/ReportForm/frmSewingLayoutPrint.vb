Public Class frmSewingLayoutPrint
    Dim filterstring As String = ""

    Private _SewingLayoutId As Integer
    Public Property SewingLayoutId() As Integer
        Get
            Return _SewingLayoutId
        End Get
        Set(ByVal value As Integer)
            _SewingLayoutId = value
        End Set
    End Property
    Private _MIS As Boolean
    Public Property MIS() As Boolean
        Get
            Return _MIS
        End Get
        Set(ByVal value As Boolean)
            _MIS = value
        End Set
    End Property
    Private Sub FrmSewingLayoutPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SewingLayoutTableAdapter.Fill(Me.SewingLayoutDataSet.SewingLayout)

        If Me.MIS = False Then

            Dim index As Integer = Me.SewingLayoutBindingSource.Find("LayoutId", Me.SewingLayoutId)
            Me.SewingLayoutBindingSource.Position = index

            filterstring = "{SewingLayout.LayoutId}=" & Me.SewingLayoutId

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingLayout
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub
End Class