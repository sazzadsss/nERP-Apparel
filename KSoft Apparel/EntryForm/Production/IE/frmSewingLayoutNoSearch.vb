Public Class frmSewingLayoutNoSearch

    Private _OrderId As Integer
    Public Property OrderId() As Integer
        Get
            Return _OrderId
        End Get
        Set(ByVal value As Integer)
            _OrderId = value
        End Set
    End Property

    Private _SewinglayoutId As Integer
    Public Property SewinglayoutId() As Integer
        Get
            Return _SewinglayoutId
        End Get
        Set(ByVal value As Integer)
            _SewinglayoutId = value
        End Set
    End Property

    Private _SewingProduction As Boolean
    Public Property SewingProduction() As Boolean
        Get
            Return _SewingProduction
        End Get
        Set(ByVal value As Boolean)
            _SewingProduction = value
        End Set
    End Property

    Private _SewingDate As Date
    Public Property SewingDate() As Date
        Get
            Return _SewingDate
        End Get
        Set(ByVal value As Date)
            _SewingDate = value
        End Set
    End Property

    Private _LineId As Integer
    Public Property LineId() As Integer
        Get
            Return _LineId
        End Get
        Set(ByVal value As Integer)
            _LineId = value
        End Set
    End Property


    Private Sub frmSewingLayoutNoSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Me.SewingProduction = True Then
            Me.SewingLayoutTableAdapter.FillByOrderId(Me.SewingLayoutDataSet.SewingLayout, OrderId)
        Else
            Me.SewingLayoutTableAdapter.FillBySewingDateAndLine(Me.SewingLayoutDataSet.SewingLayout, Me.LineId, Me.SewingDate)
        End If


    End Sub

    Private Sub ListBox1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick

        If Me.SewingLayoutBindingSource.Position > -1 Then

            Me.DialogResult = System.Windows.Forms.DialogResult.OK

        End If

        Me.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        If Me.SewingLayoutBindingSource.Position > -1 Then

            Me.SewinglayoutId = Me.ListBox1.SelectedValue

        End If

    End Sub
End Class