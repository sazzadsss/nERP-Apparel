Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmDailySewingReport
    Dim SDate As Date
    Dim SDate2 As Date
    Dim filterstring As String
    Private _MIS As Boolean
    Private _SewingDate As Date
    Private _BranchId As Integer
    Public Property [MIS]() As Boolean

        Get
            Return _MIS
        End Get
        Set(ByVal Value As Boolean)
            _MIS = Value
        End Set

    End Property

    Public Property [SewingDate]() As Date

        Get
            Return _SewingDate
        End Get
        Set(ByVal Value As Date)
            _SewingDate = Value
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
    Private _OID As Integer
    Public Property OID() As Integer
        Get
            Return _OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property
    Private Sub frmDailySewingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OrderPOLookupAllTableAdapter.Fill(Me.OrderPOLookupNewDataSet.OrderPOLookupAll)
        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.StyleTableAdapter.Fill(Me.StyleLookupDataSet.Style)

        Me.OrderLookupTableAdapter.Fill(Me.OrderLookupDataSet.OrderLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        If Me.MIS = False Then
            On Error Resume Next
            Me.SewingDateTimePicker.Value = Me.SewingDate

            Dim BranchIndex As Integer
            BranchIndex = Me.BranchBindingSource.Find("BranchId", Me.BranchId)
            Me.BranchBindingSource.Position = BranchIndex

            SDate = Me.SewingDateTimePicker.Text
            filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ", 23, 59, 59)AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailySewingReportPOWise
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If
        If Me.OID > 0 Then
            filterstring = "{Order.OrderId} =" & OID

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramAllocationReport2
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        End If

    End Sub

    

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        SDate = Me.SewingDateTimePicker.Text
        SDate2 = Me.SewingDateTimePicker2.Text
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)AND {Branch.BranchId} = " & Me.BranchComboBox.SelectedValue


        'Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingReport_DateRangeWithValue
        'ShowReport(MyReport, filterstring, CrystalReportViewer1)


        If TotalDay = 0 Then

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailySewingReportPOWise
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingReport_DateRange
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If




    End Sub

    Private Sub ShowbyProgramButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowbyProgramButton.Click

        filterstring = "{Order.OrderId} =" & ProgramNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramAllocationReport2
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        filterstring = "{Order.OrderId} = " & ProgramNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramAllocationReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

   


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SDate = Me.SewingDateTimePicker.Text
        SDate2 = Me.SewingDateTimePicker2.Text
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        filterstring = "{SewingTargetAndAverageByDate.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)AND {SewingTargetAndAverageByDate.BranchId} = " & Me.BranchComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingTargetAndAverageReport
            ShowReport(MyReport, filterstring, CrystalReportViewer1)



    End Sub

    Private Sub BuyerButton_Click(sender As Object, e As EventArgs) Handles BuyerButton.Click

        SDate = Me.SewingDateTimePicker.Text
        SDate2 = Me.SewingDateTimePicker2.Text
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)AND {Order.BuyerId} = " & Me.BuyerGridLookUpEdit.EditValue


        'Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingReport_DateRangeWithValue
        'ShowReport(MyReport, filterstring, CrystalReportViewer1)


        If TotalDay = 0 Then

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailySewingReportPOWise
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingReport_DateRange
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Me.MultipleProgramTextBox.Text = String.Empty Then
            Me.MultipleProgramTextBox.Text = Me.BranchComboBox.Text
        Else
            Me.MultipleProgramTextBox.Text = Me.MultipleProgramTextBox.Text & ", " & Me.BranchComboBox.Text
        End If
    End Sub

    Private Sub AllBranch_Click(sender As Object, e As EventArgs) Handles AllBranch.Click

        SDate = Me.SewingDateTimePicker.Text
        SDate2 = Me.SewingDateTimePicker2.Text

        'Multiful branch in (ET3,ET4,ET5,SAMPLE,QAL,Sub Con) 

        Dim s As String = ""
        Dim s1 As String = ""

        s = MultipleProgramTextBox.Text

        s1 = s.Replace(", ", "','") 'You should use one space after first comma
        s1 = Trim(s1)
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) And {Branch.BranchCode} like ['" & s1 & "']"


        If TotalDay = 0 Then

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailySewingReportPOWise
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingReport_DateRange
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If


    End Sub

    Private Sub StyleButton_Click(sender As Object, e As EventArgs) Handles StyleButton.Click
        SDate = Me.SewingDateTimePicker.Text
        SDate2 = Me.SewingDateTimePicker2.Text
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)AND {Order.StyleId} = " & Me.StyleGridLookUpEdit.EditValue


        'Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingReport_DateRangeWithValue
        'ShowReport(MyReport, filterstring, CrystalReportViewer1)


        If TotalDay = 0 Then

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailySewingReportPOWise
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingReport_DateRange
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub

    Private Sub ShowAllButtong_Click(sender As Object, e As EventArgs) Handles ShowAllButtong.Click

        SDate = Me.SewingDateTimePicker.Text
        SDate2 = Me.SewingDateTimePicker2.Text
        Dim TotalDay As Integer = DateDiff(DateInterval.Day, SDate, SDate2)

        If TotalDay = 0 Then

            filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00)"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailySewingReportProgramWise
            ShowReport(MyReport, filterstring, CrystalReportViewer1)
        Else

            filterstring = "{SewingProduction.SewingDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00)"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingReport_DateRange
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        filterstring = "{Order.OrderId} =" & ProgramNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingReport_DateRange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ShowButton3_Click(sender As Object, e As EventArgs) Handles ShowButton3.Click
        filterstring = "{SewingProduction.OrderDetailsId} = " & GridLookUpEdit1.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SewingProductionReportPOWise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class