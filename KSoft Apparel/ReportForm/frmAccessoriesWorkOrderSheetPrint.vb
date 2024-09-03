Public Class frmAccessoriesWorkOrderSheetPrint
    Dim filterstring As String = ""
    Private _AWSId As Integer

    Public Property AWSId() As Integer
        Get
            Return _AWSId
        End Get
        Set(ByVal value As Integer)
            _AWSId = value
        End Set
    End Property

    Private Sub frmAccessoriesWorkOrderSheetPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.AWSProgramLookupTableAdapter.Fill(Me.AWSLookupDataSet.AWSProgramLookup)

        Me.AWSLookupTableAdapter.Fill(Me.AWSLookupDataSet.AWSLookup)

        If Me.AWSId > 0 Then

            AWSNoLookUpEdit.EditValue = Me.AWSId

            filterstring = "{AccessoriesWorkOrderSheet.AWSId} =" & Me.AWSNoLookUpEdit.EditValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AWSReport
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

       


    End Sub

    Private Sub AWSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AWSButton.Click

        filterstring = "{AccessoriesWorkOrderSheet.AWSId} =" & Me.AWSNoLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AWSReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        filterstring = "{AccessoriesWorkOrderSheet.AWSId} =" & Me.AWSNoLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AWS_NLCareLable1
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        Dim SFDate As Date = Me.FromProgramDateTimePicker.Text
        Dim STDate As Date = Me.ToProgramDateTimePicker.Text
        filterstring = "{AccessoriesWorkOrderSheet.AWSDate} in DateTime(" & SFDate.Year & "," & SFDate.Month & "," & SFDate.Day & ",00,00,00) to DateTime (" & STDate.Year & "," & STDate.Month & "," & STDate.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AWSDateWiseReport
        MyReport.SetParameterValue("FromDate", SFDate.Date)
        MyReport.SetParameterValue("ToDate", STDate.Date)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub AWSProgramLookupGridControl_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AWSProgramLookupGridControl.DoubleClick
        Dim row As AWSLookupDataSet.AWSProgramLookupRow
        row = CType(CType(Me.AWSProgramLookupBindingSource.Current, DataRowView).Row, AWSLookupDataSet.AWSProgramLookupRow)

        filterstring = "{AccessoriesWorkOrderSheet.AWSId} =" & row.AWSId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AWSReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{AccessoriesWorkOrderSheet.AWSId} =" & Me.AWSNoLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New AWSReport1
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class