<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrderAndProductionStatusChart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Me.OrderAndProductionChartStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderAndProductionStatusDataSet = New KSoft_Apparel.OrderAndProductionStatusDataSet()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.OrderAndProductionDateStatusTableAdapter = New KSoft_Apparel.OrderAndProductionStatusDataSetTableAdapters.OrderAndProductionDateStatusTableAdapter()
        Me.OrderAndProductionChartStatusTableAdapter = New KSoft_Apparel.OrderAndProductionStatusDataSetTableAdapters.OrderAndProductionChartStatusTableAdapter()
        Me.OrderAndProductionDateStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New KSoft_Apparel.OrderAndProductionStatusDataSetTableAdapters.TableAdapterManager()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.OrderInfocategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowBuyerName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowProgramNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowStyleName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowOrderReceiveDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFirstEx = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowLastEx = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.BookingInfocategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowFabricBookingDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowYarnBookingDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowYarnRequisitionDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAccessoriesBookingDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.SampleInfocategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowSampleSendDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCommentsReceiveDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.FabProdInfocategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowKnittingProductioinStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKnittingProductionEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDyeingProductionStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDyeingProductionEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.GMTProdInfocategory = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowCuttingStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCuttingEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSewingStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSewingEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFinishingStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFinishingEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFullCompleteDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        CType(Me.OrderAndProductionChartStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderAndProductionStatusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderAndProductionDateStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderAndProductionChartStatusBindingSource
        '
        Me.OrderAndProductionChartStatusBindingSource.DataMember = "OrderAndProductionChartStatus"
        Me.OrderAndProductionChartStatusBindingSource.DataSource = Me.OrderAndProductionStatusDataSet
        '
        'OrderAndProductionStatusDataSet
        '
        Me.OrderAndProductionStatusDataSet.DataSetName = "OrderAndProductionStatusDataSet"
        Me.OrderAndProductionStatusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChartControl1
        '
        Me.ChartControl1.AutoLayout = False
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.DataSource = Me.OrderAndProductionStatusDataSet.OrderAndProductionStatus
        XyDiagram1.AxisX.Label.Angle = 20
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.EnableAxisXScrolling = True
        XyDiagram1.PaneDistance = 50
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "Column"
        Series1.ColorDataMember = "value"
        Series1.DataSource = Me.OrderAndProductionChartStatusBindingSource
        SideBySideBarSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
        SideBySideBarSeriesLabel1.LineStyle.LineJoin = System.Drawing.Drawing2D.LineJoin.MiterClipped
        SideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        SideBySideBarSeriesLabel1.Shadow.Visible = True
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.LegendName = "Default Legend"
        Series1.Name = "OrderAndProduction"
        Series1.ValueDataMembersSerializable = "value"
        SideBySideBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.View = SideBySideBarSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl1.Size = New System.Drawing.Size(650, 559)
        Me.ChartControl1.TabIndex = 0
        '
        'OrderAndProductionDateStatusTableAdapter
        '
        Me.OrderAndProductionDateStatusTableAdapter.ClearBeforeFill = True
        '
        'OrderAndProductionChartStatusTableAdapter
        '
        Me.OrderAndProductionChartStatusTableAdapter.ClearBeforeFill = True
        '
        'OrderAndProductionDateStatusBindingSource
        '
        Me.OrderAndProductionDateStatusBindingSource.DataMember = "OrderAndProductionDateStatus"
        Me.OrderAndProductionDateStatusBindingSource.DataSource = Me.OrderAndProductionStatusDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.OrderAndProductionStatusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.OrderAndProductionStatusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ChartControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.VGridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(983, 559)
        Me.SplitContainerControl1.SplitterPosition = 328
        Me.SplitContainerControl1.TabIndex = 7
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'VGridControl1
        '
        Me.VGridControl1.Appearance.Category.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VGridControl1.Appearance.Category.BorderColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VGridControl1.Appearance.Category.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.VGridControl1.Appearance.Category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.Category.Options.UseBackColor = True
        Me.VGridControl1.Appearance.Category.Options.UseBorderColor = True
        Me.VGridControl1.Appearance.Category.Options.UseFont = True
        Me.VGridControl1.Appearance.Category.Options.UseForeColor = True
        Me.VGridControl1.Appearance.CategoryExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.VGridControl1.Appearance.CategoryExpandButton.Options.UseBackColor = True
        Me.VGridControl1.Appearance.DisabledRecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRecordValue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRecordValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRecordValue.Options.UseBackColor = True
        Me.VGridControl1.Appearance.DisabledRecordValue.Options.UseBorderColor = True
        Me.VGridControl1.Appearance.DisabledRecordValue.Options.UseForeColor = True
        Me.VGridControl1.Appearance.DisabledRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.DisabledRow.Options.UseBackColor = True
        Me.VGridControl1.Appearance.DisabledRow.Options.UseBorderColor = True
        Me.VGridControl1.Appearance.DisabledRow.Options.UseForeColor = True
        Me.VGridControl1.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.VGridControl1.Appearance.Empty.ForeColor = System.Drawing.Color.Black
        Me.VGridControl1.Appearance.Empty.Options.UseBackColor = True
        Me.VGridControl1.Appearance.Empty.Options.UseForeColor = True
        Me.VGridControl1.Appearance.ExpandButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VGridControl1.Appearance.ExpandButton.ForeColor = System.Drawing.Color.White
        Me.VGridControl1.Appearance.ExpandButton.Options.UseBackColor = True
        Me.VGridControl1.Appearance.ExpandButton.Options.UseForeColor = True
        Me.VGridControl1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.VGridControl1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGridControl1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGridControl1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VGridControl1.Appearance.HorzLine.Options.UseBackColor = True
        Me.VGridControl1.Appearance.ReadOnlyRecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.ReadOnlyRecordValue.BackColor2 = System.Drawing.Color.White
        Me.VGridControl1.Appearance.ReadOnlyRecordValue.Options.UseBackColor = True
        Me.VGridControl1.Appearance.RecordValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.VGridControl1.Appearance.RecordValue.ForeColor = System.Drawing.Color.Black
        Me.VGridControl1.Appearance.RecordValue.Options.UseBackColor = True
        Me.VGridControl1.Appearance.RecordValue.Options.UseForeColor = True
        Me.VGridControl1.Appearance.RowHeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.VGridControl1.Appearance.RowHeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VGridControl1.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.VGridControl1.Appearance.RowHeaderPanel.Options.UseBackColor = True
        Me.VGridControl1.Appearance.RowHeaderPanel.Options.UseBorderColor = True
        Me.VGridControl1.Appearance.RowHeaderPanel.Options.UseForeColor = True
        Me.VGridControl1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VGridControl1.Appearance.VertLine.Options.UseBackColor = True
        Me.VGridControl1.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.VGridControl1.DataSource = Me.OrderAndProductionDateStatusBindingSource
        Me.VGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.RowHeaderWidth = 202
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.OrderInfocategory, Me.BookingInfocategory, Me.SampleInfocategory, Me.FabProdInfocategory, Me.GMTProdInfocategory})
        Me.VGridControl1.Size = New System.Drawing.Size(328, 559)
        Me.VGridControl1.TabIndex = 0
        '
        'OrderInfocategory
        '
        Me.OrderInfocategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowBuyerName, Me.rowProgramNo, Me.rowStyleName, Me.rowOrderReceiveDate, Me.rowFirstEx, Me.rowLastEx})
        Me.OrderInfocategory.Name = "OrderInfocategory"
        Me.OrderInfocategory.Properties.Caption = "Order Info"
        '
        'rowBuyerName
        '
        Me.rowBuyerName.Name = "rowBuyerName"
        Me.rowBuyerName.Properties.Caption = "Buyer"
        Me.rowBuyerName.Properties.FieldName = "BuyerName"
        '
        'rowProgramNo
        '
        Me.rowProgramNo.Name = "rowProgramNo"
        Me.rowProgramNo.Properties.Caption = "Program No"
        Me.rowProgramNo.Properties.FieldName = "ProgramNo"
        '
        'rowStyleName
        '
        Me.rowStyleName.Name = "rowStyleName"
        Me.rowStyleName.Properties.Caption = "Style"
        Me.rowStyleName.Properties.FieldName = "StyleName"
        '
        'rowOrderReceiveDate
        '
        Me.rowOrderReceiveDate.Name = "rowOrderReceiveDate"
        Me.rowOrderReceiveDate.Properties.Caption = "Order Receive Date"
        Me.rowOrderReceiveDate.Properties.FieldName = "OrderReceiveDate"
        '
        'rowFirstEx
        '
        Me.rowFirstEx.Name = "rowFirstEx"
        Me.rowFirstEx.Properties.Caption = "First Shipment Date"
        Me.rowFirstEx.Properties.FieldName = "FirstEx"
        '
        'rowLastEx
        '
        Me.rowLastEx.Name = "rowLastEx"
        Me.rowLastEx.Properties.Caption = "Last Shipment Date"
        Me.rowLastEx.Properties.FieldName = "LastEx"
        '
        'BookingInfocategory
        '
        Me.BookingInfocategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowFabricBookingDate, Me.rowYarnBookingDate, Me.rowYarnRequisitionDate, Me.rowAccessoriesBookingDate})
        Me.BookingInfocategory.Name = "BookingInfocategory"
        Me.BookingInfocategory.Properties.Caption = "Booking Info"
        '
        'rowFabricBookingDate
        '
        Me.rowFabricBookingDate.Name = "rowFabricBookingDate"
        Me.rowFabricBookingDate.Properties.Caption = "Fabric Booking Date"
        Me.rowFabricBookingDate.Properties.FieldName = "FabricBookingDate"
        '
        'rowYarnBookingDate
        '
        Me.rowYarnBookingDate.Appearance.ForeColor = System.Drawing.Color.White
        Me.rowYarnBookingDate.Name = "rowYarnBookingDate"
        Me.rowYarnBookingDate.Properties.Caption = "Yarn Booking Date"
        Me.rowYarnBookingDate.Properties.FieldName = "YarnBookingDate"
        Me.rowYarnBookingDate.Properties.ReadOnly = False
        '
        'rowYarnRequisitionDate
        '
        Me.rowYarnRequisitionDate.Height = 18
        Me.rowYarnRequisitionDate.Name = "rowYarnRequisitionDate"
        Me.rowYarnRequisitionDate.Properties.Caption = "Yarn Requisition Date"
        Me.rowYarnRequisitionDate.Properties.FieldName = "YarnRequisitionDate"
        '
        'rowAccessoriesBookingDate
        '
        Me.rowAccessoriesBookingDate.Name = "rowAccessoriesBookingDate"
        Me.rowAccessoriesBookingDate.Properties.Caption = "Accessories Booking Date"
        Me.rowAccessoriesBookingDate.Properties.FieldName = "AccessoriesBookingDate"
        '
        'SampleInfocategory
        '
        Me.SampleInfocategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSampleSendDate, Me.rowCommentsReceiveDate})
        Me.SampleInfocategory.Name = "SampleInfocategory"
        Me.SampleInfocategory.Properties.Caption = "Sample Info"
        '
        'rowSampleSendDate
        '
        Me.rowSampleSendDate.Name = "rowSampleSendDate"
        Me.rowSampleSendDate.Properties.Caption = "P.P Sample Send Date"
        Me.rowSampleSendDate.Properties.FieldName = "SampleSendDate"
        '
        'rowCommentsReceiveDate
        '
        Me.rowCommentsReceiveDate.Name = "rowCommentsReceiveDate"
        Me.rowCommentsReceiveDate.Properties.Caption = "P.P Comments Receive Date"
        Me.rowCommentsReceiveDate.Properties.FieldName = "CommentsReceiveDate"
        '
        'FabProdInfocategory
        '
        Me.FabProdInfocategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowKnittingProductioinStartDate, Me.rowKnittingProductionEndDate, Me.rowDyeingProductionStartDate, Me.rowDyeingProductionEndDate})
        Me.FabProdInfocategory.Name = "FabProdInfocategory"
        Me.FabProdInfocategory.Properties.Caption = "Fabric Production Info"
        '
        'rowKnittingProductioinStartDate
        '
        Me.rowKnittingProductioinStartDate.Name = "rowKnittingProductioinStartDate"
        Me.rowKnittingProductioinStartDate.Properties.Caption = "Knitting Productioin Start Date"
        Me.rowKnittingProductioinStartDate.Properties.FieldName = "KnittingProductioinStartDate"
        Me.rowKnittingProductioinStartDate.Properties.ReadOnly = False
        '
        'rowKnittingProductionEndDate
        '
        Me.rowKnittingProductionEndDate.Name = "rowKnittingProductionEndDate"
        Me.rowKnittingProductionEndDate.Properties.Caption = "Knitting Production End Date"
        Me.rowKnittingProductionEndDate.Properties.FieldName = "KnittingProductionEndDate"
        Me.rowKnittingProductionEndDate.Properties.ReadOnly = False
        '
        'rowDyeingProductionStartDate
        '
        Me.rowDyeingProductionStartDate.Name = "rowDyeingProductionStartDate"
        Me.rowDyeingProductionStartDate.Properties.Caption = "Dyeing Production Start Date"
        Me.rowDyeingProductionStartDate.Properties.FieldName = "DyeingProductionStartDate"
        Me.rowDyeingProductionStartDate.Properties.ReadOnly = False
        '
        'rowDyeingProductionEndDate
        '
        Me.rowDyeingProductionEndDate.Name = "rowDyeingProductionEndDate"
        Me.rowDyeingProductionEndDate.Properties.Caption = "Dyeing Production End Date"
        Me.rowDyeingProductionEndDate.Properties.FieldName = "DyeingProductionEndDate"
        Me.rowDyeingProductionEndDate.Properties.ReadOnly = False
        '
        'GMTProdInfocategory
        '
        Me.GMTProdInfocategory.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowCuttingStartDate, Me.rowCuttingEndDate, Me.rowSewingStartDate, Me.rowSewingEndDate, Me.rowFinishingStartDate, Me.rowFinishingEndDate, Me.rowFullCompleteDate})
        Me.GMTProdInfocategory.Name = "GMTProdInfocategory"
        Me.GMTProdInfocategory.Properties.Caption = "Garments Production Info"
        '
        'rowCuttingStartDate
        '
        Me.rowCuttingStartDate.Name = "rowCuttingStartDate"
        Me.rowCuttingStartDate.Properties.Caption = "Fabric Cutting Start Date"
        Me.rowCuttingStartDate.Properties.FieldName = "CuttingStartDate"
        '
        'rowCuttingEndDate
        '
        Me.rowCuttingEndDate.Name = "rowCuttingEndDate"
        Me.rowCuttingEndDate.Properties.Caption = "Fabric Cutting End Date"
        Me.rowCuttingEndDate.Properties.FieldName = "CuttingEndDate"
        '
        'rowSewingStartDate
        '
        Me.rowSewingStartDate.Name = "rowSewingStartDate"
        Me.rowSewingStartDate.Properties.Caption = "Sewing Production Start Date"
        Me.rowSewingStartDate.Properties.FieldName = "SewingStartDate"
        '
        'rowSewingEndDate
        '
        Me.rowSewingEndDate.Height = 18
        Me.rowSewingEndDate.Name = "rowSewingEndDate"
        Me.rowSewingEndDate.Properties.Caption = "Sewing Production End Date"
        Me.rowSewingEndDate.Properties.FieldName = "SewingEndDate"
        '
        'rowFinishingStartDate
        '
        Me.rowFinishingStartDate.Name = "rowFinishingStartDate"
        Me.rowFinishingStartDate.Properties.Caption = "Finishing Production Start Date"
        Me.rowFinishingStartDate.Properties.FieldName = "FinishingStartDate"
        '
        'rowFinishingEndDate
        '
        Me.rowFinishingEndDate.Name = "rowFinishingEndDate"
        Me.rowFinishingEndDate.Properties.Caption = "Finishing Production End Date"
        Me.rowFinishingEndDate.Properties.FieldName = "FinishingEndDate"
        '
        'rowFullCompleteDate
        '
        Me.rowFullCompleteDate.Name = "rowFullCompleteDate"
        Me.rowFullCompleteDate.Properties.Caption = "Full Complete Date"
        Me.rowFullCompleteDate.Properties.FieldName = "FullCompleteDate"
        '
        'frmOrderAndProductionStatusChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(983, 559)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmOrderAndProductionStatusChart"
        Me.Text = "Order Informaion Graph"
        CType(Me.OrderAndProductionChartStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderAndProductionStatusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderAndProductionDateStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents OrderAndProductionStatusDataSet As OrderAndProductionStatusDataSet
    Friend WithEvents OrderAndProductionChartStatusTableAdapter As OrderAndProductionStatusDataSetTableAdapters.OrderAndProductionChartStatusTableAdapter
    Friend WithEvents OrderAndProductionChartStatusBindingSource As BindingSource
    Friend WithEvents OrderAndProductionDateStatusTableAdapter As OrderAndProductionStatusDataSetTableAdapters.OrderAndProductionDateStatusTableAdapter
    Friend WithEvents OrderAndProductionDateStatusBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As OrderAndProductionStatusDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents OrderInfocategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowBuyerName As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowProgramNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowStyleName As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowOrderReceiveDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFirstEx As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowLastEx As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents BookingInfocategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowFabricBookingDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowYarnRequisitionDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAccessoriesBookingDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents SampleInfocategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowSampleSendDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCommentsReceiveDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents FabProdInfocategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowKnittingProductioinStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKnittingProductionEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDyeingProductionStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDyeingProductionEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents GMTProdInfocategory As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowCuttingStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowCuttingEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSewingStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSewingEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFinishingEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFullCompleteDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFinishingStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowYarnBookingDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
End Class
