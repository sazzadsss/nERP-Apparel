Public Class frmMonthlyRejectionReport

    Private Sub DepartmentComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentComboBox.SelectedIndexChanged

        Dim dprtmnt As String = Me.DepartmentComboBox.Text
        Dim filterstring As String = ""


        Select Case dprtmnt

            Case "Cutting"

                filterstring = "{CuttingProduction.CuttingDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  AND {CuttingProduction.BranchId} = " & BranchComboBox.SelectedValue

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthlyCuttingRejectionReport
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Case "Sewing"

                filterstring = "{SewingProduction.SewingDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  AND {SewingProduction.BranchId} = " & BranchComboBox.SelectedValue

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthlySewingRejectionReport
                ShowReport(MyReport, filterstring, CrystalReportViewer1)


            Case "Finishing"

                filterstring = "{FinishingProduction_ColorWise.FinishingDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  AND {FinishingProduction_ColorWise.BranchId} = " & BranchComboBox.SelectedValue

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthlyFinisingRejectionReport
                ShowReport(MyReport, filterstring, CrystalReportViewer1)


        End Select





    End Sub

    Private Sub frmMonthlyRejectionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

    End Sub
End Class