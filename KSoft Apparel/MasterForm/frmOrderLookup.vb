Imports System.Windows.Forms

Public Class frmOrderLookup

    Private _OrderId As Integer
    Public Property OrderId() As Integer
        Get
            Return _OrderId
        End Get
        Set(ByVal value As Integer)
            _OrderId = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click



        Dim row As OrderLookupDataSet.OrderLookupRow
        row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

        Me.OrderId = row.OrderId

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    

    Private Sub frmOrderLookup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged

        On Error Resume Next
        Me.OrderLookupTableAdapter.FillByProgramNoContain(Me.OrderLookupDataSet.OrderLookup, SearchTextBox.Text.ToString)

    End Sub

    Private Sub OrderLookupDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles OrderLookupDataGridView.RowHeaderMouseDoubleClick

        Dim row As OrderLookupDataSet.OrderLookupRow
        row = CType(CType(Me.OrderLookupBindingSource.Current, DataRowView).Row, OrderLookupDataSet.OrderLookupRow)

        Me.OrderId = row.OrderId

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub
End Class
