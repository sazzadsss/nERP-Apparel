

Public Class frmDaywiseProductionSummery
    Dim filterstring As String = ""
    Private Sub frmDaywiseProductionSummery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

    End Sub

    Private Sub SectionComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionComboBox.SelectedIndexChanged

        Dim ProdSection As String = Me.SectionComboBox.Text.ToString


        Select Case ProdSection

            Case "Cutting"

                filterstring = "{CuttingProduction.CuttingDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  and {Branch.BranchId} = " & BranchComboBox.SelectedValue

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Daywise_Cutting_Production_Summery
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Case "Sewing"

                filterstring = "{SewingProduction.SewingDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  and {Branch.BranchId} = " & BranchComboBox.SelectedValue

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Daywise_Sewing_Production_Summery
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Case "Finishing"

                filterstring = "{FinishingProduction.FinishingDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)  and {Branch.BranchId} = " & BranchComboBox.SelectedValue

                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Daywise_Finishing_Production_Summery
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Case Else

        End Select



    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        filterstring = ""

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DatewiseProductionStatus
        MyReport.SetParameterValue("@FromDate", DateTimePicker1.Text)
        MyReport.SetParameterValue("@ToDate", DateTimePicker2.Text)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub
End Class