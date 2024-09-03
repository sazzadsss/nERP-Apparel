Public Class frmShipmentbyExDate

    Private Sub frmShipmentbyExDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.VOrderTableAdapter.Fill(Me.VOrderDataSet.vOrder)

    End Sub

    Private Sub ExportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click


        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Order Details Print-" & Today
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        'Show the Save dialog and if the user clicks the Save button,
        'save the file
        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            Try

                PivotGridControl1.ExportToXls(objSaveFileDialog.FileName)
                'MessageBox.Show("Exported to ""C:\Order Booking.xls"" Successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try



        End If

        'Clean up
        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing


       
    End Sub
End Class