Public Class frmSampleSummeryReport
    Private Sub AllPendingButton_Click(sender As Object, e As EventArgs) Handles AllPendingButton.Click
        'filterString = "{SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.IsComplete} = False"
        'Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleProgramStatus 'SampleUpdate
        'ShowReport(MyReport, filterString, CrystalReportViewer1)
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        filterString = "{SampleRequestFinal.RequestDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = False"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleSummeryReport
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub

    Private Sub BuyerButton_Click(sender As Object, e As EventArgs) Handles BuyerButton.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        filterString = "{SampleRequestFinal.RequestDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.BuyerId}=" & BuyerGridLookUpEdit.EditValue
        'filterString = "{SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.BuyerId}=" & BuyerGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleSummeryReport
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub

    Private Sub SampleTypeButton_Click(sender As Object, e As EventArgs) Handles SampleTypeButton.Click
        Dim FDate As Date = FromDateTimePicker.Text
        Dim TDate As Date = ToDateTimePicker.Text
        filterString = "{SampleRequestFinal.RequestDate} in DateTime(" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ",00,00,00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 23, 59, 59) And {SampleRequestFinal.IsComplete} = False And {SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.DevTypeId}=" & DevTypeIdGridLookUpEdit.EditValue
        'filterString = "{SampleRequestFinal.SampleUpdate} And {SampleRequestFinal.StyleId} =" & StyleGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SampleSummeryReport
        ShowReport(MyReport, filterString, CrystalReportViewer1)
    End Sub

    Private Sub frmSampleSummeryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.DevTypeMstTableAdapter.Fill(Me.DevTypeDataSet.DevTypeMst)
    End Sub
End Class