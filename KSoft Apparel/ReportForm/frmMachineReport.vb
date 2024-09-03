Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmMachineReport
    Dim filterstring As String = ""

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim FDate As Date = CType(Me.FromDateTimePicker.Text.ToString, Date)
        Dim TDate As Date = CType(Me.ToDateTimePicker.Text.ToString, Date)

        filterstring = "{Branch.BranchId} = " & BranchComboBox.SelectedValue & " and {SewingAttendance.AttendanceDate} in DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Monthly_Machine_Report
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub frmMachineReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateTimePicker.Value = StartMonth
        ToDateTimePicker.Value = EndMonth

    End Sub

    Private Sub WithoutLineRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithoutLineRadioButton.CheckedChanged

        Dim FDate As Date = CType(Me.FromDateTimePicker.Text.ToString, Date)
        Dim TDate As Date = CType(Me.ToDateTimePicker.Text.ToString, Date)

        filterstring = "{Branch.BranchId} = " & CType(BranchComboBox.SelectedValue.ToString, Long) & " and {SewingAttendance.AttendanceDate} in DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Monthly_Machine_Report_Without_Line
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub AllSummeryRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllSummeryRadioButton.CheckedChanged

        Dim FDate As Date = CType(Me.FromDateTimePicker.Text.ToString, Date)
        Dim TDate As Date = CType(Me.ToDateTimePicker.Text.ToString, Date)

        filterstring = "{SewingAttendance.AttendanceDate} in DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Monthly_Machine_Report_Without_Line
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
End Class