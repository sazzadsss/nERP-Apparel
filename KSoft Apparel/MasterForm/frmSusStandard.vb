Public Class frmSusStandard
    Private Sub SusStandardMstBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SusStandardMstBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.SusStandardMstBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SusStandardDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub frmSusStandard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SusStandardMstTableAdapter.Fill(Me.SusStandardDataSet.SusStandardMst)

    End Sub
End Class