Public Class frmProgramLookuByStyle
    Private _SID As Integer
    Public Property SID() As Integer
        Get
            Return _SID
        End Get
        Set(ByVal value As Integer)
            _SID = value
        End Set
    End Property

    Private Sub frmProgramLookuByStyle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.SID > 0 Then
            Me.OrderLookupByStyleTableAdapter.FillByStyleIdAndBudgetPending(Me.OrderLookupDataSet.OrderLookupByStyle, SID)
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        If OrderLookupByStyleBindingSource.Position > -1 Then

            Dim row As OrderLookupDataSet.OrderLookupByStyleRow
            row = CType(CType(Me.OrderLookupByStyleBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupByStyleRow)
            frmPreCosting.OID = row.OrderId

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

    End Sub
End Class