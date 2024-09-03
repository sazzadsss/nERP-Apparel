Public Class frmPicture
    Private _StyleId As Integer

    Private _Style As Integer
    Public Property StyleId() As Integer
        Get
            Return _Style
        End Get
        Set(ByVal value As Integer)
            _Style = value
        End Set
    End Property
    Private Sub frmPicture_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.StyleTableAdapter.FillByStyleId(Me.StyleDataSet.Style, Me.StyleId)

    End Sub
End Class