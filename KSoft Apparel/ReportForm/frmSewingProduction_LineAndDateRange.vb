Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmSewingProduction_LineAndDateRange
    Dim filterstring As String = ""
    Private Sub frmSewingProduction_LineAndDateRange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateTimePicker.Text = StartMonth
        ToDateTimePicker.Text = EndMonth


        Me.LineTableAdapter.FillByPlanning(Me.LineDataSet.Line)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim SDate As Date = Me.FromDateTimePicker.Text
        Dim FDate As Date = Me.ToDateTimePicker.Text

        filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 23, 59, 59)AND {SewingProduction.LineId} = " & Me.ComboBox1.SelectedValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailySewingReportPOWise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SDate As Date = Me.FromDateTimePicker.Text
        Dim FDate As Date = Me.ToDateTimePicker.Text

        filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 23, 59, 59)AND {SewingProduction.LineId} = " & Me.ComboBox1.SelectedValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailySewingLineStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SDate As Date = Me.FromDateTimePicker.Text
        Dim FDate As Date = Me.ToDateTimePicker.Text

        filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 23, 59, 59)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailySewingLineStatus
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class