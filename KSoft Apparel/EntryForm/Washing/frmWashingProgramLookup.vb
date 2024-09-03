Public Class frmWashingProgramLookup

    Public OID As Integer

    Private Sub frmProgramNoLookUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Me.OrderLookupTableAdapter.FillByIsWash(Me.OrderLookupDataSet.OrderLookup, True)

    End Sub

    Private Sub OrderLookupGridControl_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles OrderLookupGridControl.MouseDoubleClick
        Dim row As OrderLookupDataSet.OrderLookupRow
        row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

        OID = row.OrderId

        Me.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub
End Class