Public Class frmSizewiseProductionReport
    Private Sub frmSizewiseProductionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SizewiseProductionReportTableAdapter.Fill(Me.SizewiseProductionDataSet.SizewiseProductionReport, ProgramNoGridLookUpEdit.EditValue)
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        'Declare a SaveFileDialog object
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Running Program List"
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"
        End With

        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try

                GridControl1.ExportToXls(objSaveFileDialog.FileName)


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        objSaveFileDialog.Dispose()
        objSaveFileDialog = Nothing
    End Sub
End Class