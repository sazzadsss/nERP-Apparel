Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmDayWiseProduction
    Dim filterstring As String = ""

    Private _BranchId As Integer
    Public Property BranchId() As Integer
        Get
            Return _BranchId
        End Get
        Set(ByVal value As Integer)
            _BranchId = value
        End Set
    End Property

    Private _FromDate As Date
    Public Property FromDate() As Date
        Get
            Return _FromDate
        End Get
        Set(ByVal value As Date)
            _FromDate = value
        End Set
    End Property

    Private _ToDate As Date
    Public Property ToDate() As Date
        Get
            Return _ToDate
        End Get
        Set(ByVal value As Date)
            _ToDate = value
        End Set
    End Property

    Private _MIS As Boolean
    Public Property MIS() As Boolean
        Get
            Return _MIS
        End Get
        Set(ByVal value As Boolean)
            _MIS = value
        End Set
    End Property


    Private Sub frmDayWiseProduction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateTimePicker.Value = StartMonth
        ToDateTimePicker.Value = EndMonth

        If Me.MIS = False Then

            FromDateTimePicker.Text = FromDate
            ToDateTimePicker.Text = ToDate

            Dim BranchIndex As Integer
            BranchIndex = Me.BranchBindingSource.Find("BranchId", BranchId)
            Me.BranchBindingSource.Position = BranchIndex

        End If

        filterstring = "{DailyProductionSummery.ProductionDay} in DateTime (" & FromDateTimePicker.Value.Year & "," & FromDateTimePicker.Value.Month & "," & FromDateTimePicker.Value.Day & ", 00, 00, 00) to DateTime (" & ToDateTimePicker.Value.Year & "," & ToDateTimePicker.Value.Month & "," & ToDateTimePicker.Value.Day & ", 00, 00, 00) and {DailyProductionSummery.BranchId} =" & BranchComboBox.SelectedValue
        
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DayWiseProductionReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub
   

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        filterstring = "{DailyProductionSummery.ProductionDay} in DateTime (" & FromDateTimePicker.Value.Year & "," & FromDateTimePicker.Value.Month & "," & FromDateTimePicker.Value.Day & ", 00, 00, 00) to DateTime (" & ToDateTimePicker.Value.Year & "," & ToDateTimePicker.Value.Month & "," & ToDateTimePicker.Value.Day & ", 00, 00, 00) and {DailyProductionSummery.BranchId} =" & BranchComboBox.SelectedValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DayWiseProductionReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    
    Private Sub ShowAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllButton.Click

        filterstring = "{DailyProductionSummery.ProductionDay} in DateTime (" & FromDateTimePicker.Value.Year & "," & FromDateTimePicker.Value.Month & "," & FromDateTimePicker.Value.Day & ", 00, 00, 00) to DateTime (" & ToDateTimePicker.Value.Year & "," & ToDateTimePicker.Value.Month & "," & ToDateTimePicker.Value.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DayWiseProductionReport_AllBranch
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub SummeryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummeryButton.Click, Button1.Click

        filterstring = "{DailyProductionSummery.ProductionDay} in DateTime (" & FromDateTimePicker.Value.Year & "," & FromDateTimePicker.Value.Month & "," & FromDateTimePicker.Value.Day & ", 00, 00, 00) to DateTime (" & ToDateTimePicker.Value.Year & "," & ToDateTimePicker.Value.Month & "," & ToDateTimePicker.Value.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DayWiseProductionReport_Summery
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub
End Class