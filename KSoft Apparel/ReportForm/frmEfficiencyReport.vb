Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmEfficiencyReport
    Dim filterstring As String = ""

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

       

    End Sub

    
    Private Sub frmEfficiencyReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.LineTableAdapter.Fill(Me.LineDataSet.Line)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim SDate As Date = SewingDateTimePicker.Text

        filterstring = "{SewingProduction.SewingDate} = DateTime (" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ", 00, 00, 00) and{Branch.BranchId} = " & BranchComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MIS_Report_Final
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowByLineButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByLineButton.Click
        '{Line.Line} = "OB2-L2" and {SewingProduction.SewingDate} in DateTime (2013, 12, 01, 00, 00, 00) to DateTime (2013, 12, 30, 00, 00, 00)

        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text


        filterstring = "{SewingProduction.SewingDate} in DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00) and {Line.LineId} = " & LineComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MIS_Report_Final__Daywise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub FactorywiseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactorywiseButton.Click
        Dim SDate As Date = SewingDateTimePicker.Text

        filterstring = "{SewingProduction.SewingDate} = DateTime (" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MIS_Report_Final__AllLine
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filterstring = "{Order.OrderId} = " & ProgramNoGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MIS_Report_Final__AllLine_Programwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SDate As Date = SewingDateTimePicker.Text

        filterstring = "{SewingProduction.SewingDate} = DateTime (" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MIS_Report_Final__AllLineSummery
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class