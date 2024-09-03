Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmDailyFinishingReport
    Dim filterstring As String = ""
    Private _FinishingDate As Date
    Dim SDate As Date
    Dim SDate2 As Date
    Private _BranchId As Integer
    Private _MIS As Boolean

    Public Property [FinishingDate]() As Date
        Get
            Return _FinishingDate
        End Get
        Set(ByVal Value As Date)
            _FinishingDate = Value
        End Set
    End Property

    Public Property [BranchId]() As Integer

        Get
            Return _BranchId
        End Get
        Set(ByVal Value As Integer)
            _BranchId = Value
        End Set

    End Property

    Public Property [MIS]() As Boolean

        Get
            Return _MIS
        End Get
        Set(ByVal Value As Boolean)
            _MIS = Value
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
    Private Sub ShowButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        SDate = Me.FinishingDateTimePicker.Text
        SDate2 = Me.FinishingDateTimePicker2.Text
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        filterstring = "{FinishingProduction.FinishingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00) and {Branch.BranchId} = " & BranchComboBox.SelectedValue

        If TotalDay = 0 Then
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyFinishingReportNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        Else
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishingReport_DateRangeNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If



    End Sub

    Private Sub frmDailyFinishingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)
        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)


        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        If Me.MIS = False Then
            On Error Resume Next
            Dim index As Integer = Me.BranchBindingSource.Find("BranchId", Me.BranchId)
            Me.BranchBindingSource.Position = index

            FinishingDateTimePicker.Value = Me.FinishingDate 'From Custom Property
            FinishingDateTimePicker2.Value = Me.FinishingDate

            filterstring = "{FinishingProduction.FinishingDate} = DateTime (" & FinishingDateTimePicker.Value.Year & "," & FinishingDateTimePicker.Value.Month & "," & FinishingDateTimePicker.Value.Day & ", 00, 00, 00) and{Branch.BranchId} = " & BranchComboBox.SelectedValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyFinishingReportNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If
        Me.BranchComboBox.SelectedValue = 23

        If Me.OID > 0 Then
            filterstring = "{vOrder.OrderId} = " & Me.OID
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyFinishingReportProgramWiseNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        filterstring = "{vOrder.OrderId} = " & ProgramNoGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyFinishingReportProgramWiseNew
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub AllBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllBranch.Click

        SDate = Me.FinishingDateTimePicker.Text
        SDate2 = Me.FinishingDateTimePicker2.Text

        'Multiful branch in (ET3,ET4,ET5,SAMPLE,QAL,Sub Con) 

        Dim s As String = ""
        Dim s1 As String = ""

        s = MultipleProgramTextBox.Text

        s1 = s.Replace(", ", "','") 'You should use one space after first comma
        s1 = Trim(s1)
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)



        filterstring = "{FinishingProduction.FinishingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) And {Branch.BranchCode} like ['" & s1 & "']"


        If TotalDay = 0 Then
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyFinishingReportNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        Else

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishingReport_DateRangeNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If




    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Me.MultipleProgramTextBox.Text = String.Empty Then
            Me.MultipleProgramTextBox.Text = Me.BranchComboBox.Text
        Else
            Me.MultipleProgramTextBox.Text = Me.MultipleProgramTextBox.Text & ", " & Me.BranchComboBox.Text
        End If
    End Sub

    Private Sub BuyerButton_Click(sender As Object, e As EventArgs) Handles BuyerButton.Click

        SDate = Me.FinishingDateTimePicker.Text
        SDate2 = Me.FinishingDateTimePicker2.Text
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        filterstring = "{FinishingProduction.FinishingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00) and {vOrder.BuyerId} = " & BuyerGridLookUpEdit.EditValue

        If TotalDay = 0 Then
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyFinishingReportNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        Else
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishingReport_DateRangeNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If

    End Sub

    Private Sub StyleButton_Click(sender As Object, e As EventArgs) Handles StyleButton.Click

        SDate = Me.FinishingDateTimePicker.Text
        SDate2 = Me.FinishingDateTimePicker2.Text
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)


        filterstring = "{FinishingProduction.FinishingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00) and {vOrder.StyleId} = " & Me.StyleGridLookUpEdit.EditValue


        If TotalDay = 0 Then
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyFinishingReportNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        Else
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishingReport_DateRangeNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If


    End Sub

    Private Sub ShowAllButtong_Click(sender As Object, e As EventArgs) Handles ShowAllButtong.Click

        SDate = Me.FinishingDateTimePicker.Text
        SDate2 = Me.FinishingDateTimePicker2.Text
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)
        filterstring = "{FinishingProduction.FinishingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00)"

        If TotalDay = 0 Then
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyFinishingReportNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        Else
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishingReport_DateRangeNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        filterstring = "{vOrder.OrderId} = " & ProgramNoGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishingReport_DateRangeNew
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ShowButton3_Click(sender As Object, e As EventArgs) Handles ShowButton3.Click

        filterstring = "{FinishingProduction.OrderDetailsId} = " & GridLookUpEdit1.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishingReport_POWise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
End Class