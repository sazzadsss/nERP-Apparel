Public Class frmChallanCheckedList
    Dim SDate As Date
    Dim SDate2 As Date

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        Dim filterstring As String = "{PrintCount.CheckedOn} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ChallanVerifySystem
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

End Class