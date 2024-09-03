Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmDailyPrintProductionReport
    Dim filterstring As String = ""

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim SDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, TDate)


        If BuyerCheckBox.Checked = True Then
            filterstring = "{Buyer.BuyerId}=" & BuyerComboBox.SelectedValue & "AND {PrintProduction.PrintProductionDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        Else
            filterstring = "{PrintProduction.PrintProductionDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyPrintProductionReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmDailyPrintProductionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PrintOrderNewLookupTableAdapter.Fill(Me.PrintOrderNewLookupDataSet.PrintOrderNewLookup)

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

    End Sub


    Private Sub ProdHourButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdHourButton.Click

        Dim SDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text

        filterstring = "{PrintProduction.PrintProductionDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PrintProductionHourReport

        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostCostingButton.Click

        Dim row As DataRowView = TryCast(OrderIdGridLookUpEdit.Properties.GetRowByKeyValue(OrderIdGridLookUpEdit.EditValue), DataRowView)
        Dim prgno As String = row.Item("ProgramNo")

        filterstring = "{Order.ProgramNo} = '" & prgno & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PrintProductionHourReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub



    Private Sub SummeryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummeryButton.Click

        Dim SDate As Date = Me.FromDateTimePicker.Text
        Dim TDate As Date = Me.ToDateTimePicker.Text


        If BuyerCheckBox.Checked = True Then
            filterstring = "{Buyer.BuyerId}=" & BuyerComboBox.SelectedValue & "AND {PrintProduction.PrintProductionDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        Else
            filterstring = "{PrintProduction.PrintProductionDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59)"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PrintProduction_DateRange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)



    End Sub

    Private Sub ShowByPrintOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByPrintOrderButton.Click
        Dim row As DataRowView = TryCast(OrderIdGridLookUpEdit.Properties.GetRowByKeyValue(OrderIdGridLookUpEdit.EditValue), DataRowView)
        Dim prgno As String = row.Item("ProgramNo")

        filterstring = "{PrintOrderNew.ProgramNo} = '" & prgno & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyPrintProductionReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim row As DataRowView = TryCast(OrderIdGridLookUpEdit.Properties.GetRowByKeyValue(OrderIdGridLookUpEdit.EditValue), DataRowView)
        Dim prgno As String = row.Item("ProgramNo")

        filterstring = "{PrintOrderNew.ProgramNo} = '" & prgno & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyPrintProductionReport_ProgramWise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{PrintOrderNew.PrintOrderNewId} = " & OrderIdGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyPrintProductionReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class