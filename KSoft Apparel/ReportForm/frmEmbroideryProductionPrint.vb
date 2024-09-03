Public Class frmEmbroideryProductionPrint
    Dim filterstring As String = ""
    Private Sub ShowByDateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByDateButton.Click

        Dim SDate As Date
        Dim SDate2 As Date

        SDate = Me.CuttingDateTimePicker.Text
        SDate2 = Me.CuttingDateTimePicker2.Text

        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        If BuyerCheckBox.Checked = True Then
            filterstring = "{Buyer.BuyerName} = '" & BuyerComboBox.Text & "' And {EmbProduction.EmbProductionDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        Else
            filterstring = "{EmbProduction.EmbProductionDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EmbProductionReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub frmEmbroideryProductionPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.EmbOrderLookupTableAdapter.Fill(Me.EmbOrderLookupDataSet.EmbOrderLookup)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)

    End Sub


    Private Sub SummeryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click
        Dim SDate As Date
        Dim SDate2 As Date

        SDate = Me.CuttingDateTimePicker.Text
        SDate2 = Me.CuttingDateTimePicker2.Text

        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        If BuyerCheckBox.Checked = True Then
            filterstring = "{Buyer.BuyerName} = '" & BuyerComboBox.Text & "' And {EmbProduction.EmbProductionDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        Else
            filterstring = "{EmbProduction.EmbProductionDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EmbProductionReport_Compact
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


    Private Sub SampleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SampleRadioButton.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{EmbOrder.EmbOrderId} = " & OrderIdGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EmbProductionReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim row As DataRowView = TryCast(OrderIdGridLookUpEdit.Properties.GetRowByKeyValue(OrderIdGridLookUpEdit.EditValue), DataRowView)
        Dim prgno As String = row.Item("ProgramNo")

        filterstring = "{EmbOrder.ProgramNo} = '" & prgno & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EmbProductionReport_Programwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ShowByPrintOrderButton_Click(sender As Object, e As EventArgs) Handles ShowByPrintOrderButton.Click
        Dim row As DataRowView = TryCast(OrderIdGridLookUpEdit.Properties.GetRowByKeyValue(OrderIdGridLookUpEdit.EditValue), DataRowView)
        Dim prgno As String = row.Item("ProgramNo")

        filterstring = "{EmbOrder.ProgramNo} = '" & prgno & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New EmbProductionReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class