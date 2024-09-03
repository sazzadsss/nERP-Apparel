Public Class frmSewingLayoutList
















    Private Sub FrmSewingLayoutList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim FDate As Date = DateTimePicker3.Text
        Dim TDate As Date = DateTimePicker4.Text

        If BuyerCheckBox.Checked Then
            filterstring = "not {vOrder.Discontinue} And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00) And ISNULL({StylewiseTarget.TotalTargetQuantity})=False And {vOrder.BuyerId}=" & BuyerComboBox.SelectedValue

        Else
            filterstring = "not {vOrder.Discontinue} And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00) And ISNULL({StylewiseTarget.TotalTargetQuantity})=False"

        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Layout_Complete_Style
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim FDate As Date = DateTimePicker3.Text
        Dim TDate As Date = DateTimePicker4.Text

        If BuyerCheckBox.Checked Then
            filterstring = "not {vOrder.Discontinue} And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00) And ISNULL({StylewiseTarget.TotalTargetQuantity})=True And {vOrder.BuyerId}=" & BuyerComboBox.SelectedValue
        Else
            filterstring = "not {vOrder.Discontinue} And {vOrder.EX} in DateTime (" & FDate.Year & ", " & FDate.Month & ", " & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & ", " & TDate.Month & ", " & TDate.Day & ", 00, 00, 00) And ISNULL({StylewiseTarget.TotalTargetQuantity})=True"
        End If



        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Layout_Pending_Style
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

End Class