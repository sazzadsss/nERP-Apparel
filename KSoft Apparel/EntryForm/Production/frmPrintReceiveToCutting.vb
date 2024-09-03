Public Class frmPrintReceiveToCutting

    Private Sub PrintReceiveToCuttingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReceiveToCuttingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PrintReceiveToCuttingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrintReceiveDataSet)

    End Sub

    Private Sub frmPrintReceiveToCutting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FabricColorTableAdapter.Fill(Me.FabricColorDataSet.FabricColor)

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Me.PrintReceiveDetailsToCuttingTableAdapter.Fill(Me.PrintReceiveDataSet.PrintReceiveDetailsToCutting)

        Me.PrintReceiveToCuttingTableAdapter.Fill(Me.PrintReceiveDataSet.PrintReceiveToCutting)

    End Sub

    Private Sub CuttingDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuttingDateTimePicker.ValueChanged

    End Sub
End Class