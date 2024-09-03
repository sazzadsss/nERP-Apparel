Public Class frmSewingTargetList

    Private Sub frmSewingTargetList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub ExporttoXLSLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ExporttoXLSLinkLabel.LinkClicked
        Try

            StylewiseTargetGridControl.ExportToXls("c:\Sewing_Target_List.xls")
            MessageBox.Show("Exported to ""C:\Sewing_Target_List.xls"" Successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Me.StylewiseTargetTableAdapter.Fill(Me.StylewiseSewingTargetDataSet.StylewiseTarget)
    End Sub
End Class