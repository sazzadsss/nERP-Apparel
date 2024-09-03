Public Class frmItemLookup

    Private Sub frmItemLookup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, PrintStoreId)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Me.ItemListBindingSource.Position > -1 Then
            Dim row As ItemListLookupDataSet.ItemListRow
            row = CType(CType(Me.ItemListBindingSource.Current, DataRowView).Row, ItemListLookupDataSet.ItemListRow)

            frmRecipe.Item_ID = row.ItemId

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If

    End Sub
End Class