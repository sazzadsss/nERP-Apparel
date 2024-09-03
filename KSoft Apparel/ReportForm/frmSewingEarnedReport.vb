Public Class frmSewingEarnedReport
    Dim SDate As Date
    Dim SDate2 As Date
    Dim filterstring As String = ""
    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        SDate = Me.SewingDateTimePicker.Text
        SDate2 = Me.SewingDateTimePicker2.Text
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)


        If CheckBox1.Checked = False Then
            filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue
        Else
            filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue & "AND {@CMPriceMissing} = 0.00"
        End If


        If DetailsCheckBox.Checked = False Then

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EARNED_REPORT_SUMMERY
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EARNED_REPORT_DETAILS
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If


    End Sub

    Private Sub ShowbyProgramButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowbyProgramButton.Click

        filterstring = "{Order.ProgramNo} ='" & ProgramNoGridLookUpEdit.Text & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EARNED_REPORT_PROGRAMWISE
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmSewingEarnedReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
    End Sub
End Class