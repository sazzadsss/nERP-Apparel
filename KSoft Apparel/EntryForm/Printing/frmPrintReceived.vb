Public Class frmPrintReceived

    Private Sub PrintingReceivedBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintingReceivedBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PrintingReceivedBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrintReceivedDataSet)

    End Sub

    Private Sub frmPrintReceived_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.UserTableAdapter.Fill(Me.UserDataSet.User)

        Me.PrintingReceivedDetailsTableAdapter.Fill(Me.PrintReceivedDataSet.PrintingReceivedDetails)

        Me.PrintingReceivedTableAdapter.Fill(Me.PrintReceivedDataSet.PrintingReceived)

    End Sub
End Class