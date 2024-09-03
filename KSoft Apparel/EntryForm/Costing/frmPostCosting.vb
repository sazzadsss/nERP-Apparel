Public Class frmPostCosting
    Private Sub frmPostCosting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BudgetVSActualTableAdapter.Fill(Me.BudgetVsActualDataSet.BudgetVSActual)

    End Sub
End Class