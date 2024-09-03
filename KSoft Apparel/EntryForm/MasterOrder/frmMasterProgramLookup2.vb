Public Class frmMasterProgramLookup2
    Private _PrgNo As String
    Public Property PrgNo() As String
        Get
            Return _PrgNo
        End Get
        Set(ByVal value As String)
            _PrgNo = value
        End Set
    End Property
    Private Sub frmMasterProgramLookup2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MasterOrderLookUpDataSet.MasterOrderLookUp' table. You can move, or remove it, as needed.
        Me.MasterOrderLookUpTableAdapter.Fill(Me.MasterOrderLookUpDataSet.MasterOrderLookUp)

    End Sub

    Private Sub MasterOrderLookUpGridControl_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MasterOrderLookUpGridControl.MouseDoubleClick

        If Me.MasterOrderLookUpBindingSource.Position > -1 Then

            Dim row As MasterOrderLookUpDataSet.MasterOrderLookUpRow
            row = CType(CType(Me.MasterOrderLookUpBindingSource.Current, DataRowView).Row, MasterOrderLookUpDataSet.MasterOrderLookUpRow)

            frmOrderReceived.MPrgNo = row.MasterProgramNo
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

        End If

    End Sub
End Class