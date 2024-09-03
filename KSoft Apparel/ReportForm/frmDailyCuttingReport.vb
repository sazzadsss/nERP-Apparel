Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmDailyCuttingReport

    Dim SDate As Date
    Dim SDate2 As Date
    Dim filterstring As String

    Private _BranchId As Integer
    Private _CuttingDate As Date
    Private _MIS As Boolean


    Public Property BranchId() As Integer
        Get
            Return _BranchId
        End Get
        Set(ByVal value As Integer)
            _BranchId = value
        End Set
    End Property

    Public Property CuttingDate() As Date
        Get
            Return _CuttingDate
        End Get
        Set(ByVal value As Date)
            _CuttingDate = value
        End Set
    End Property

    Public Property MIS() As Boolean
        Get
            Return _MIS
        End Get
        Set(ByVal value As Boolean)
            _MIS = value
        End Set
    End Property
    Private _OID As Integer
    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property
    Private Sub frmDailyCuttingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        If Me.MIS = False Then
            On Error Resume Next
            Me.CuttingDateTimePicker.Text = Me.CuttingDate

            Dim BranchIndex As Integer
            BranchIndex = Me.BranchBindingSource.Find("BranchId", Me.BranchId)

            Me.BranchBindingSource.Position = BranchIndex

            SDate = Me.CuttingDateTimePicker.Text

            filterstring = "{CuttingProduction.CuttingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ", 23, 59, 59)AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyCuttingReport
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If


        If Me.OID > 0 Then

            filterstring = "{Order.OrderId} =" & Me.OID

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramAllocationCuttingNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

        If UserId = "1" Then
            Checklavel.Visible = True
        Else
            Checklavel.Visible = False
        End If

        Me.BranchComboBox.SelectedValue = 5

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click


        SDate = Me.CuttingDateTimePicker.Text
        SDate2 = Me.CuttingDateTimePicker2.Text

        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        filterstring = "{CuttingProduction.CuttingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue

        '---------------------
        'UserId waise Report Show (FOB), Imrul Kaesh, 13-06-2013
        'If Checklavel.Checked = True Then

        '    If TotalDay = 0 Then

        '        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyCuttingReportnew
        '        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '    Else

        '        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingReport_DateRangeWithValue
        '        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '    End If

        'Else

        If TotalDay = 0 Then

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyCuttingReportnew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingReport_DateRangeNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If


    End Sub

    Private Sub ProgramAllocationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramAllocationButton.Click

        filterstring = "{Order.OrderId} =" & ProgramNoGridLookUpEdit.EditValue

        If SizeCheckBox.Checked = True Then

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingReportSummery_ProgramWise_WithSize
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramAllocationCuttingNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If
        

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BuyerButton_Click(sender As Object, e As EventArgs) Handles BuyerButton.Click
        SDate = Me.CuttingDateTimePicker.Text
        SDate2 = Me.CuttingDateTimePicker2.Text

        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        filterstring = "{CuttingProduction.CuttingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Order.BuyerId} = " & Me.BuyerGridLookUpEdit.EditValue

        If TotalDay = 0 Then

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyCuttingReportnew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingReport_DateRangeNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If
    End Sub

    Private Sub StyleButton_Click(sender As Object, e As EventArgs) Handles StyleButton.Click

        filterstring = "{Order.StyleId} = " & Me.StyleGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramAllocationCuttingNew
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowAllButtong_Click(sender As Object, e As EventArgs) Handles ShowAllButtong.Click

        SDate = Me.CuttingDateTimePicker.Text
        SDate2 = Me.CuttingDateTimePicker2.Text

        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        filterstring = "{CuttingSummery_ForDailyReport.CuttingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue

        '---------------------
        'UserId waise Report Show (FOB), Imrul Kaesh, 13-06-2013
        'If Checklavel.Checked = True Then

        '    If TotalDay = 0 Then

        '        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyCuttingReportnew
        '        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '    Else

        '        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingReport_DateRangeWithValue
        '        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '    End If

        'Else

        If TotalDay = 0 Then

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyCuttingReportnew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingReport_DateRangeNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub

    Private Sub BranchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BranchComboBox.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filterstring = "{Order.OrderId} =" & ProgramNoGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CuttingReport_DateRangeNew
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub SizeCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SizeCheckBox.CheckedChanged

    End Sub
End Class