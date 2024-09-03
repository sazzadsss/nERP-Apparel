<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraSchedulerReport1
    Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TimeScaleYear1 As DevExpress.XtraScheduler.TimeScaleYear = New DevExpress.XtraScheduler.TimeScaleYear
        Dim TimeScaleQuarter1 As DevExpress.XtraScheduler.TimeScaleQuarter = New DevExpress.XtraScheduler.TimeScaleQuarter
        Dim TimeScaleMonth1 As DevExpress.XtraScheduler.TimeScaleMonth = New DevExpress.XtraScheduler.TimeScaleMonth
        Dim TimeScaleWeek1 As DevExpress.XtraScheduler.TimeScaleWeek = New DevExpress.XtraScheduler.TimeScaleWeek
        Dim TimeScaleDay1 As DevExpress.XtraScheduler.TimeScaleDay = New DevExpress.XtraScheduler.TimeScaleDay
        Dim TimeScaleHour1 As DevExpress.XtraScheduler.TimeScaleHour = New DevExpress.XtraScheduler.TimeScaleHour
        Dim TimeScaleFixedInterval1 As DevExpress.XtraScheduler.TimeScaleFixedInterval = New DevExpress.XtraScheduler.TimeScaleFixedInterval
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.VerticalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders
        Me.TimelineCells1 = New DevExpress.XtraScheduler.Reporting.TimelineCells
        Me.ReportTimelineView1 = New DevExpress.XtraScheduler.Reporting.ReportTimelineView
        Me.ReportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView
        Me.TimelineScaleHeaders1 = New DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders
        Me.SchedulerControlPrintAdapter1 = New DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle
        CType(Me.ReportTimelineView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDayView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerControlPrintAdapter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.BorderWidth = 1
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.VerticalResourceHeaders1, Me.TimelineScaleHeaders1, Me.TimelineCells1})
        Me.Detail.Height = 665
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.Detail.StylePriority.UseBorderWidth = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'VerticalResourceHeaders1
        '
        Me.VerticalResourceHeaders1.Location = New System.Drawing.Point(8, 50)
        Me.VerticalResourceHeaders1.Name = "VerticalResourceHeaders1"
        Me.VerticalResourceHeaders1.Size = New System.Drawing.Size(25, 608)
        Me.VerticalResourceHeaders1.TimeCells = Me.TimelineCells1
        Me.VerticalResourceHeaders1.View = Me.ReportDayView1
        '
        'TimelineCells1
        '
        Me.TimelineCells1.Location = New System.Drawing.Point(33, 50)
        Me.TimelineCells1.Name = "TimelineCells1"
        Me.TimelineCells1.Size = New System.Drawing.Size(1325, 608)
        Me.TimelineCells1.View = Me.ReportTimelineView1
        '
        'ReportTimelineView1
        '
        TimeScaleQuarter1.Enabled = False
        TimeScaleWeek1.Enabled = False
        TimeScaleDay1.DisplayFormat = "dd"
        TimeScaleDay1.Width = 30
        TimeScaleHour1.Enabled = False
        TimeScaleFixedInterval1.Enabled = False
        Me.ReportTimelineView1.Scales.Add(TimeScaleYear1)
        Me.ReportTimelineView1.Scales.Add(TimeScaleQuarter1)
        Me.ReportTimelineView1.Scales.Add(TimeScaleMonth1)
        Me.ReportTimelineView1.Scales.Add(TimeScaleWeek1)
        Me.ReportTimelineView1.Scales.Add(TimeScaleDay1)
        Me.ReportTimelineView1.Scales.Add(TimeScaleHour1)
        Me.ReportTimelineView1.Scales.Add(TimeScaleFixedInterval1)
        Me.ReportTimelineView1.VisibleIntervalCount = 31
        Me.ReportTimelineView1.VisibleResourceCount = 10
        '
        'ReportDayView1
        '
        Me.ReportDayView1.VisibleDayCount = 33
        Me.ReportDayView1.VisibleResourceCount = 10
        '
        'TimelineScaleHeaders1
        '
        Me.TimelineScaleHeaders1.BookmarkParent = Me.TimelineCells1
        Me.TimelineScaleHeaders1.Location = New System.Drawing.Point(33, 0)
        Me.TimelineScaleHeaders1.Name = "TimelineScaleHeaders1"
        Me.TimelineScaleHeaders1.Size = New System.Drawing.Size(1325, 50)
        Me.TimelineScaleHeaders1.View = Me.ReportTimelineView1
        '
        'SchedulerControlPrintAdapter1
        '
        Me.SchedulerControlPrintAdapter1.TimeInterval.Duration = System.TimeSpan.Parse("734654.00:00:00")
        Me.SchedulerControlPrintAdapter1.TimeInterval.Start = New Date(CType(0, Long))
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        '
        'XtraSchedulerReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(21, 21, 50, 21)
        Me.Name = "XtraSchedulerReport1"
        Me.PageHeight = 850
        Me.PageWidth = 1400
        Me.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PrinterName = "Fax"
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "9.1"
        Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.ReportTimelineView1, Me.ReportDayView1})
        CType(Me.ReportTimelineView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDayView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerControlPrintAdapter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportDayView1 As DevExpress.XtraScheduler.Reporting.ReportDayView
    Friend WithEvents VerticalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders
    Friend WithEvents TimelineScaleHeaders1 As DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders
    Friend WithEvents ReportTimelineView1 As DevExpress.XtraScheduler.Reporting.ReportTimelineView
    Friend WithEvents TimelineCells1 As DevExpress.XtraScheduler.Reporting.TimelineCells
    Friend WithEvents SchedulerControlPrintAdapter1 As DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
End Class
