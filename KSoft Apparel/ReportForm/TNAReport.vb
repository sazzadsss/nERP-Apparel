Imports DevExpress.XtraSplashScreen
Public Class TNAReport
    Private Sub ReGenLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ReGenLinkLabel.LinkClicked
        LastUpdateLabel.Text = "Generating,please wait...."
        ShowRunningButton.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ExecuteQuery("EXEC GenTempMOrAndProdStatusPrg", cnn)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        LastUpdateLabel.Text = ReadDateData("Select LastGenerateOn From LastGenerateOn Where TaskName='TempMasterOrderAndProductionStatusPrg'", cnn)
        ShowRunningButton.Enabled = True


        SplashScreenManager.CloseForm(False)
    End Sub


    Private Sub ShowRunningButton_Click(sender As Object, e As EventArgs) Handles ShowRunningButton.Click

        Me.ProductonReportTableAdapter.Fill(Me.ProductionReportDataSet.ProductonReport)
        Me.TNAReportTableAdapter.Fill(Me.TNAReportDataSet.TNAReport)

    End Sub
End Class