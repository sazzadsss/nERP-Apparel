<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderBookingMaster_Export
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim PieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
        Dim PieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim SeriesTitle1 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
        Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.OrderBookingMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderBookingMasterDataSet = New KSoft_Apparel.OrderBookingMasterDataSet()
        Me.fieldEX = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBuyerCode = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOrderQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProgramNo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStyleName = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOrderReceiveDate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPrintDetails = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.OrderBookingMasterTableAdapter = New KSoft_Apparel.OrderBookingMasterDataSetTableAdapters.OrderBookingMasterTableAdapter()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBookingMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBookingMasterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fieldYear
        '
        Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldYear.AreaIndex = 0
        Me.fieldYear.Caption = "Year"
        Me.fieldYear.FieldName = "Year"
        Me.fieldYear.Name = "fieldYear"
        '
        'fieldMonth
        '
        Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldMonth.AreaIndex = 1
        Me.fieldMonth.Caption = "Month"
        Me.fieldMonth.CellFormat.FormatString = "MMM"
        Me.fieldMonth.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldMonth.FieldName = "Month"
        Me.fieldMonth.Name = "fieldMonth"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Appearance.HeaderArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PivotGridControl1.Appearance.HeaderArea.Options.UseBackColor = True
        Me.PivotGridControl1.Appearance.HeaderGroupLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PivotGridControl1.Appearance.HeaderGroupLine.ForeColor = System.Drawing.Color.Black
        Me.PivotGridControl1.Appearance.HeaderGroupLine.Options.UseBackColor = True
        Me.PivotGridControl1.Appearance.HeaderGroupLine.Options.UseForeColor = True
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.DataSource = Me.OrderBookingMasterBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldEX, Me.fieldYear, Me.fieldMonth, Me.fieldBuyerCode, Me.fieldOrderQuantity, Me.fieldProgramNo, Me.fieldStyleName, Me.fieldOrderReceiveDate, Me.fieldPrintDetails})
        PivotGridGroup1.Fields.Add(Me.fieldYear)
        PivotGridGroup1.Fields.Add(Me.fieldMonth)
        PivotGridGroup1.Hierarchy = Nothing
        PivotGridGroup1.ShowNewValues = True
        Me.PivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.LookAndFeel.UseWindowsXPTheme = True
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsPrint.MergeRowFieldValues = False
        Me.PivotGridControl1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.PivotGridControl1.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.Size = New System.Drawing.Size(937, 156)
        Me.PivotGridControl1.TabIndex = 0
        '
        'OrderBookingMasterBindingSource
        '
        Me.OrderBookingMasterBindingSource.DataMember = "OrderBookingMaster"
        Me.OrderBookingMasterBindingSource.DataSource = Me.OrderBookingMasterDataSet
        '
        'OrderBookingMasterDataSet
        '
        Me.OrderBookingMasterDataSet.DataSetName = "OrderBookingMasterDataSet"
        Me.OrderBookingMasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldEX
        '
        Me.fieldEX.AreaIndex = 4
        Me.fieldEX.Caption = "EX"
        Me.fieldEX.CellFormat.FormatString = "dd-MMM-yy"
        Me.fieldEX.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldEX.FieldName = "EX"
        Me.fieldEX.Name = "fieldEX"
        Me.fieldEX.Options.ShowTotals = False
        Me.fieldEX.ValueFormat.FormatString = """dd-MMM-yy'"
        Me.fieldEX.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldBuyerCode
        '
        Me.fieldBuyerCode.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBuyerCode.AreaIndex = 0
        Me.fieldBuyerCode.Caption = "Buyer Code"
        Me.fieldBuyerCode.FieldName = "BuyerCode"
        Me.fieldBuyerCode.Name = "fieldBuyerCode"
        '
        'fieldOrderQuantity
        '
        Me.fieldOrderQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldOrderQuantity.AreaIndex = 0
        Me.fieldOrderQuantity.Caption = "Order Quantity"
        Me.fieldOrderQuantity.FieldName = "OrderQuantity"
        Me.fieldOrderQuantity.Name = "fieldOrderQuantity"
        '
        'fieldProgramNo
        '
        Me.fieldProgramNo.AreaIndex = 1
        Me.fieldProgramNo.Caption = "Program No"
        Me.fieldProgramNo.FieldName = "ProgramNo"
        Me.fieldProgramNo.Name = "fieldProgramNo"
        '
        'fieldStyleName
        '
        Me.fieldStyleName.AreaIndex = 3
        Me.fieldStyleName.Caption = "Style Name"
        Me.fieldStyleName.FieldName = "StyleName"
        Me.fieldStyleName.Name = "fieldStyleName"
        '
        'fieldOrderReceiveDate
        '
        Me.fieldOrderReceiveDate.AreaIndex = 2
        Me.fieldOrderReceiveDate.Caption = "Order Receive Date"
        Me.fieldOrderReceiveDate.CellFormat.FormatString = "dd-MMM-yy"
        Me.fieldOrderReceiveDate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldOrderReceiveDate.FieldName = "OrderReceiveDate"
        Me.fieldOrderReceiveDate.Name = "fieldOrderReceiveDate"
        '
        'fieldPrintDetails
        '
        Me.fieldPrintDetails.AreaIndex = 0
        Me.fieldPrintDetails.FieldName = "PrintDetails"
        Me.fieldPrintDetails.Name = "fieldPrintDetails"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(3, 3)
        Me.SimpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(107, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "E&xport"
        '
        'OrderBookingMasterTableAdapter
        '
        Me.OrderBookingMasterTableAdapter.ClearBeforeFill = True
        '
        'ChartControl1
        '
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.DataSource = Me.PivotGridControl1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.MaxHorizontalPercentage = 30.0R
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesDataMember = "Series"
        PieSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Label = PieSeriesLabel1
        Series1.Name = "Series 1"
        Series1.View = PieSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
        Me.ChartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        PieSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesLabel2.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
        PieSeriesLabel2.TextPattern = "{A}: {VP:P0}"
        Me.ChartControl1.SeriesTemplate.Label = PieSeriesLabel2
        Me.ChartControl1.SeriesTemplate.LegendTextPattern = "{A}"
        Me.ChartControl1.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
        Me.ChartControl1.SeriesTemplate.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
        PieSeriesView2.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {SeriesTitle1})
        Me.ChartControl1.SeriesTemplate.View = PieSeriesView2
        Me.ChartControl1.Size = New System.Drawing.Size(937, 268)
        Me.ChartControl1.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PivotGridControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChartControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(937, 428)
        Me.SplitContainer1.SplitterDistance = 156
        Me.SplitContainer1.TabIndex = 3
        '
        'frmOrderBookingMaster_Export
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 463)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "frmOrderBookingMaster_Export"
        Me.Text = "Order Booking Master Export"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBookingMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBookingMasterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents OrderBookingMasterDataSet As KSoft_Apparel.OrderBookingMasterDataSet
    Friend WithEvents OrderBookingMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderBookingMasterTableAdapter As KSoft_Apparel.OrderBookingMasterDataSetTableAdapters.OrderBookingMasterTableAdapter
    Friend WithEvents fieldEX As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYear As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMonth As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBuyerCode As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderQuantity As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProgramNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStyleName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderReceiveDate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fieldPrintDetails As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
