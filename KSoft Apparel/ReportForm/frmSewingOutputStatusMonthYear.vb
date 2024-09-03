Public Class frmSewingOutputStatusMonthYear
    Private Sub SewingButton_Click(sender As Object, e As EventArgs) Handles SewingButton.Click
        filterstring = "{SewingSummeryByOrderId.Yr} in " & ComboBox1.Text & " to " & ComboBox2.Text

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthwiseSewingOutput
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub frmSewingOutputStatusMonthYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

    End Sub
End Class