Public Class PlanningOrder
    Private _ProgramNo As String = String.Empty
    Private _Color As String = String.Empty
    Private _Style As String = String.Empty

    Public Sub New()
    End Sub

    Public Property ProgramNo() As String
        Get
            Return _ProgramNo
        End Get
        Set(ByVal value As String)
            _ProgramNo = value
        End Set
    End Property

    Public Property Color() As String
        Get
            Return _Color
        End Get
        Set(ByVal value As String)
            _Color = value
        End Set
    End Property

    Public Property Style() As String
        Get
            Return _Style
        End Get
        Set(ByVal value As String)
            _Style = value
        End Set
    End Property

End Class
