Public Class frmPreCostingOpenValueless5
    Dim filterString As String = ""

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text


        If ApprovedRadioButton.Checked Then
            filterString = "{PreCostingMain.Profit} <= " & Me.StockNumericUpDown.Value & " And {PreCostingMain.PreCostingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00) And {PreCostingMain.IsApproved}"
        Else
            filterString = "{PreCostingMain.Profit} <= " & Me.StockNumericUpDown.Value & " And {PreCostingMain.PreCostingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00) And {PreCostingMain.IsComplete}"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PreCostingList
        ShowReport(MyReport, filterString, CrystalReportViewer1)

    End Sub

    Private Sub FrmPreCostingOpenValueless5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text

        filterString = "{PreCostingMain.PreCostingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PreCostingList
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub

    Private Sub BuyerButton_Click(sender As Object, e As EventArgs) Handles BuyerButton.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text

        filterString = "{PreCostingMain.PreCostingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00) And {Buyer.BuyerId} = " & BuyerGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New PreCostingList
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub
End Class