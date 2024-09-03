Public Class frmOtherPrintCosting

    Private _pRecipeId As Integer
    Public Property pRecipeId() As Integer
        Get
            Return _pRecipeId
        End Get
        Set(ByVal value As Integer)
            _pRecipeId = value
        End Set
    End Property

    Private Sub OthersPrintCostBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OthersPrintCostBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.OthersPrintCostBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OthersPrintCostDataSet)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
       
    End Sub

    Private Sub frmOtherPrintCosting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, PrintStoreId)
        Me.OthersPrintCostTableAdapter.FillByRecipeId(Me.OthersPrintCostDataSet.OthersPrintCost, Me.pRecipeId)

        Me.OthersPrintCostDataSet.OthersPrintCost.RecipeIdColumn.DefaultValue = Me.pRecipeId

    End Sub

    
    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        If e.Column.Caption = "Item" Then

            If Me.OthersPrintCostBindingSource.Position > -1 Then

                Dim row As OthersPrintCostDataSet.OthersPrintCostRow
                row = CType(CType(Me.OthersPrintCostBindingSource.Current, DataRowView).Row, OthersPrintCostDataSet.OthersPrintCostRow)

                row.UnitId = ReadIntegerData("Select UnitId From ItemList Where ItemId=" & row.ItemId, cnn)
                row.UnitPrice = ReadData("Select CurrentPrice From ItemList Where ItemId=" & row.ItemId, cnn)

            End If

        ElseIf e.Column.Caption = "Quantity" Then

            If Me.OthersPrintCostBindingSource.Position > -1 Then

                Dim row As OthersPrintCostDataSet.OthersPrintCostRow
                row = CType(CType(Me.OthersPrintCostBindingSource.Current, DataRowView).Row, OthersPrintCostDataSet.OthersPrintCostRow)

                If e.Value >= 0 Then
                    row.TotalCost = row.UnitPrice * e.Value
                End If


            End If

        End If

    End Sub
End Class