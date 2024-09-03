<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBonusTopSheetGenerator
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
        Dim BonusTopSheetNameLabel As System.Windows.Forms.Label
        Dim LayoutIdLabel As System.Windows.Forms.Label
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PolygonGradientFillOptions1 As DevExpress.XtraCharts.PolygonGradientFillOptions = New DevExpress.XtraCharts.PolygonGradientFillOptions()
        Dim PointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Me.colLossHour = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSewingDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BonusTopSheetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BonusDataSet = New KSoft_Apparel.BonusDataSet()
        Me.BonusTopSheetTableAdapter = New KSoft_Apparel.BonusDataSetTableAdapters.BonusTopSheetTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.BonusDataSetTableAdapters.TableAdapterManager()
        Me.SewingLayoutBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingLayoutLookupDataSet = New KSoft_Apparel.SewingLayoutLookupDataSet()
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineDataSet = New KSoft_Apparel.LineDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalProductionLabel = New System.Windows.Forms.Label()
        Me.TotalHourLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TargetPCLabel = New System.Windows.Forms.Label()
        Me.AvgProdPerHourLabel = New System.Windows.Forms.Label()
        Me.LayoutIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SewingLayoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingLayoutDataSet = New KSoft_Apparel.SewingLayoutDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLayoutId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSMV_Machine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSMV_Manual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHelper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTargetsPerHour = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLayoutDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBonusTargetQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddTargetPerHour = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBonusTargets = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalTargetQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSewingLayoutNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPcsPerBundle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLayoutTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CalculateProductionButton = New System.Windows.Forms.Button()
        Me.AchievementPercentage = New System.Windows.Forms.Label()
        Me.AchievementPCLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BOThrsGTLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.APMT100PLabel = New System.Windows.Forms.Label()
        Me.BOThrsLTEQLabel = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TotalBonusHourLabel = New System.Windows.Forms.Label()
        Me.SewingLayoutTableAdapter = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingLayoutTableAdapter()
        Me.BonusGenerationDataSet = New KSoft_Apparel.BonusGenerationDataSet()
        Me.SewingAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingAttendanceTableAdapter = New KSoft_Apparel.BonusGenerationDataSetTableAdapters.SewingAttendanceTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Apparel.BonusGenerationDataSetTableAdapters.TableAdapterManager()
        Me.SewingProductionTableAdapter = New KSoft_Apparel.BonusGenerationDataSetTableAdapters.SewingProductionTableAdapter()
        Me.SewingProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingLayoutTableAdapter1 = New KSoft_Apparel.SewingLayoutLookupDataSetTableAdapters.SewingLayoutTableAdapter()
        Me.HelperLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OperatorLabel = New System.Windows.Forms.Label()
        Me.TargetLabel = New System.Windows.Forms.Label()
        Me.BonusTargetLabel = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LayoutIdGridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.LayoutIdGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BonusTopSheetNameTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GeneralCheckBox = New System.Windows.Forms.CheckBox()
        Me.RecalculateButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colBonusId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProductionMonthId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ProductionMonthItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ProductionMonthBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionMonthDataSet = New KSoft_Apparel.ProductionMonthDataSet()
        Me.colLayoutId1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colUserId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLineId1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.LineLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colProductionQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTTLHour = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colGeneral_Operator = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGeneral_Helper = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGeneral_WH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGeneral = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colFirstOT_Operator = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstOT_Helper = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstOT_WH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFirstOT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colSecondOT_Operator = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSecondOT_Helper = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSecondOT_WH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSecondOT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colThird_Operator = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colThird_Helper = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colThird_WH = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colThird_OT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.ProductionMonthTableAdapter = New KSoft_Apparel.ProductionMonthDataSetTableAdapters.ProductionMonthTableAdapter()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LayoutEfficiencyLabel = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ProductionMonthComboBox = New System.Windows.Forms.ComboBox()
        Me.BonusTopSheetNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BonusTopSheetNameLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBonusTopSheetName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BonusTopSheetNameLookupTableAdapter = New KSoft_Apparel.BonusDataSetTableAdapters.BonusTopSheetNameLookupTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DoubleLayoutCheckBox = New System.Windows.Forms.CheckBox()
        Me.LayoutIdGridLookUpEdit3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SewingLayoutBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLayoutId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSMV_Machine1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSMV_Manual1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachineQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHelper1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTargetsPerHour1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLayoutDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBonusTargetQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddTargetPerHour1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBonusTargets1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalTargetQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSewingLayoutNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPcsPerBundle1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLayoutTime1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreSewingLayoutNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMCCost = New DevExpress.XtraGrid.Columns.GridColumn()
        BonusTopSheetNameLabel = New System.Windows.Forms.Label()
        LayoutIdLabel = New System.Windows.Forms.Label()
        CType(Me.BonusTopSheetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonusGenerationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LayoutIdGridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutIdGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionMonthItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionMonthBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionMonthDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonusTopSheetNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonusTopSheetNameLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.LayoutIdGridLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BonusTopSheetNameLabel
        '
        BonusTopSheetNameLabel.AutoSize = True
        BonusTopSheetNameLabel.Location = New System.Drawing.Point(14, 21)
        BonusTopSheetNameLabel.Name = "BonusTopSheetNameLabel"
        BonusTopSheetNameLabel.Size = New System.Drawing.Size(110, 13)
        BonusTopSheetNameLabel.TabIndex = 40
        BonusTopSheetNameLabel.Text = "Bonus Top Sheet No:"
        '
        'LayoutIdLabel
        '
        LayoutIdLabel.AutoSize = True
        LayoutIdLabel.Location = New System.Drawing.Point(14, 83)
        LayoutIdLabel.Name = "LayoutIdLabel"
        LayoutIdLabel.Size = New System.Drawing.Size(59, 13)
        LayoutIdLabel.TabIndex = 41
        LayoutIdLabel.Text = "Layout No:"
        '
        'colLossHour
        '
        Me.colLossHour.AppearanceHeader.Options.UseTextOptions = True
        Me.colLossHour.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLossHour.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLossHour.FieldName = "LossHour"
        Me.colLossHour.Name = "colLossHour"
        Me.colLossHour.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colLossHour.Visible = True
        Me.colLossHour.Width = 77
        '
        'colSewingDate
        '
        Me.colSewingDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSewingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSewingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSewingDate.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.colSewingDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSewingDate.FieldName = "SewingDate"
        Me.colSewingDate.Name = "colSewingDate"
        Me.colSewingDate.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colSewingDate.Visible = True
        Me.colSewingDate.Width = 95
        '
        'BonusTopSheetBindingSource
        '
        Me.BonusTopSheetBindingSource.DataMember = "BonusTopSheet"
        Me.BonusTopSheetBindingSource.DataSource = Me.BonusDataSet
        '
        'BonusDataSet
        '
        Me.BonusDataSet.DataSetName = "BonusDataSet"
        Me.BonusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BonusTopSheetTableAdapter
        '
        Me.BonusTopSheetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BonusTopSheetTableAdapter = Me.BonusTopSheetTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.BonusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingLayoutBindingSource1
        '
        Me.SewingLayoutBindingSource1.DataMember = "SewingLayout"
        Me.SewingLayoutBindingSource1.DataSource = Me.SewingLayoutLookupDataSet
        '
        'SewingLayoutLookupDataSet
        '
        Me.SewingLayoutLookupDataSet.DataSetName = "SewingLayoutLookupDataSet"
        Me.SewingLayoutLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineBindingSource
        '
        Me.LineBindingSource.DataMember = "Line"
        Me.LineBindingSource.DataSource = Me.LineDataSet
        '
        'LineDataSet
        '
        Me.LineDataSet.DataSetName = "LineDataSet"
        Me.LineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 372)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Hour"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Production"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalProductionLabel
        '
        Me.TotalProductionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalProductionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TotalProductionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalProductionLabel.Location = New System.Drawing.Point(124, 372)
        Me.TotalProductionLabel.Name = "TotalProductionLabel"
        Me.TotalProductionLabel.Size = New System.Drawing.Size(74, 23)
        Me.TotalProductionLabel.TabIndex = 5
        Me.TotalProductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalHourLabel
        '
        Me.TotalHourLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalHourLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TotalHourLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalHourLabel.Location = New System.Drawing.Point(379, 372)
        Me.TotalHourLabel.Name = "TotalHourLabel"
        Me.TotalHourLabel.Size = New System.Drawing.Size(70, 23)
        Me.TotalHourLabel.TabIndex = 4
        Me.TotalHourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(13, 406)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Target (PCs)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(455, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Avg. Prd/hr"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TargetPCLabel
        '
        Me.TargetPCLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TargetPCLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TargetPCLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TargetPCLabel.Location = New System.Drawing.Point(124, 406)
        Me.TargetPCLabel.Name = "TargetPCLabel"
        Me.TargetPCLabel.Size = New System.Drawing.Size(75, 23)
        Me.TargetPCLabel.TabIndex = 9
        Me.TargetPCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AvgProdPerHourLabel
        '
        Me.AvgProdPerHourLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AvgProdPerHourLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AvgProdPerHourLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AvgProdPerHourLabel.Location = New System.Drawing.Point(621, 372)
        Me.AvgProdPerHourLabel.Name = "AvgProdPerHourLabel"
        Me.AvgProdPerHourLabel.Size = New System.Drawing.Size(74, 23)
        Me.AvgProdPerHourLabel.TabIndex = 8
        Me.AvgProdPerHourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LayoutIdGridLookUpEdit
        '
        Me.LayoutIdGridLookUpEdit.Location = New System.Drawing.Point(566, 7)
        Me.LayoutIdGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.LayoutIdGridLookUpEdit.Name = "LayoutIdGridLookUpEdit"
        Me.LayoutIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LayoutIdGridLookUpEdit.Properties.DataSource = Me.SewingLayoutBindingSource
        Me.LayoutIdGridLookUpEdit.Properties.DisplayMember = "SewingLayoutNo"
        Me.LayoutIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.LayoutIdGridLookUpEdit.Properties.NullText = "[Type Layout No]"
        Me.LayoutIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LayoutIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LayoutIdGridLookUpEdit.Properties.ValueMember = "LayoutId"
        Me.LayoutIdGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.LayoutIdGridLookUpEdit.Size = New System.Drawing.Size(113, 20)
        Me.LayoutIdGridLookUpEdit.TabIndex = 10
        '
        'SewingLayoutBindingSource
        '
        Me.SewingLayoutBindingSource.DataMember = "SewingLayout"
        Me.SewingLayoutBindingSource.DataSource = Me.SewingLayoutDataSet
        '
        'SewingLayoutDataSet
        '
        Me.SewingLayoutDataSet.DataSetName = "SewingLayoutDataSet"
        Me.SewingLayoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLayoutId, Me.colLineId, Me.colTotalSMV_Machine, Me.colTotalSMV_Manual, Me.colMachineQuantity, Me.colHelper, Me.colTargetsPerHour, Me.colRemarks, Me.colOrderId, Me.colStyleId, Me.colLayoutDate, Me.colOrderQuantity, Me.colBonusTargetQuantity, Me.colAddTargetPerHour, Me.colAmendmentNo, Me.colBonusTargets, Me.colTotalTargetQuantity, Me.colSewingLayoutNo, Me.colPcsPerBundle, Me.colLayoutTime})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colLayoutId
        '
        Me.colLayoutId.FieldName = "LayoutId"
        Me.colLayoutId.Name = "colLayoutId"
        Me.colLayoutId.OptionsColumn.ReadOnly = True
        '
        'colLineId
        '
        Me.colLineId.FieldName = "LineId"
        Me.colLineId.Name = "colLineId"
        '
        'colTotalSMV_Machine
        '
        Me.colTotalSMV_Machine.FieldName = "TotalSMV_Machine"
        Me.colTotalSMV_Machine.Name = "colTotalSMV_Machine"
        '
        'colTotalSMV_Manual
        '
        Me.colTotalSMV_Manual.FieldName = "TotalSMV_Manual"
        Me.colTotalSMV_Manual.Name = "colTotalSMV_Manual"
        '
        'colMachineQuantity
        '
        Me.colMachineQuantity.FieldName = "MachineQuantity"
        Me.colMachineQuantity.Name = "colMachineQuantity"
        '
        'colHelper
        '
        Me.colHelper.FieldName = "Helper"
        Me.colHelper.Name = "colHelper"
        '
        'colTargetsPerHour
        '
        Me.colTargetsPerHour.FieldName = "TargetsPerHour"
        Me.colTargetsPerHour.Name = "colTargetsPerHour"
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        '
        'colStyleId
        '
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        '
        'colLayoutDate
        '
        Me.colLayoutDate.FieldName = "LayoutDate"
        Me.colLayoutDate.Name = "colLayoutDate"
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        '
        'colBonusTargetQuantity
        '
        Me.colBonusTargetQuantity.FieldName = "BonusTargetQuantity"
        Me.colBonusTargetQuantity.Name = "colBonusTargetQuantity"
        '
        'colAddTargetPerHour
        '
        Me.colAddTargetPerHour.FieldName = "AddTargetPerHour"
        Me.colAddTargetPerHour.Name = "colAddTargetPerHour"
        '
        'colAmendmentNo
        '
        Me.colAmendmentNo.FieldName = "AmendmentNo"
        Me.colAmendmentNo.Name = "colAmendmentNo"
        '
        'colBonusTargets
        '
        Me.colBonusTargets.FieldName = "BonusTargets"
        Me.colBonusTargets.Name = "colBonusTargets"
        '
        'colTotalTargetQuantity
        '
        Me.colTotalTargetQuantity.FieldName = "TotalTargetQuantity"
        Me.colTotalTargetQuantity.Name = "colTotalTargetQuantity"
        '
        'colSewingLayoutNo
        '
        Me.colSewingLayoutNo.FieldName = "SewingLayoutNo"
        Me.colSewingLayoutNo.Name = "colSewingLayoutNo"
        Me.colSewingLayoutNo.Visible = True
        Me.colSewingLayoutNo.VisibleIndex = 0
        '
        'colPcsPerBundle
        '
        Me.colPcsPerBundle.FieldName = "PcsPerBundle"
        Me.colPcsPerBundle.Name = "colPcsPerBundle"
        '
        'colLayoutTime
        '
        Me.colLayoutTime.FieldName = "LayoutTime"
        Me.colLayoutTime.Name = "colLayoutTime"
        '
        'CalculateProductionButton
        '
        Me.CalculateProductionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CalculateProductionButton.Location = New System.Drawing.Point(836, 3)
        Me.CalculateProductionButton.Name = "CalculateProductionButton"
        Me.CalculateProductionButton.Size = New System.Drawing.Size(64, 28)
        Me.CalculateProductionButton.TabIndex = 11
        Me.CalculateProductionButton.Text = "Calculate"
        Me.CalculateProductionButton.UseVisualStyleBackColor = True
        '
        'AchievementPercentage
        '
        Me.AchievementPercentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AchievementPercentage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AchievementPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AchievementPercentage.Location = New System.Drawing.Point(379, 406)
        Me.AchievementPercentage.Name = "AchievementPercentage"
        Me.AchievementPercentage.Size = New System.Drawing.Size(70, 23)
        Me.AchievementPercentage.TabIndex = 15
        Me.AchievementPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AchievementPCLabel
        '
        Me.AchievementPCLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AchievementPCLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AchievementPCLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AchievementPCLabel.Location = New System.Drawing.Point(124, 434)
        Me.AchievementPCLabel.Name = "AchievementPCLabel"
        Me.AchievementPCLabel.Size = New System.Drawing.Size(75, 23)
        Me.AchievementPCLabel.TabIndex = 14
        Me.AchievementPCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(205, 406)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 23)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Achievement(%)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(13, 434)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 23)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Achievement(PCs)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BOThrsGTLabel
        '
        Me.BOThrsGTLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BOThrsGTLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BOThrsGTLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BOThrsGTLabel.Location = New System.Drawing.Point(621, 434)
        Me.BOThrsGTLabel.Name = "BOThrsGTLabel"
        Me.BOThrsGTLabel.Size = New System.Drawing.Size(75, 23)
        Me.BOThrsGTLabel.TabIndex = 19
        Me.BOThrsGTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(455, 406)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 23)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Bonus OT hrs for 100% or Less"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(455, 434)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(160, 23)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Bonus OT hrs More than 100%"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(204, 434)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(169, 23)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Achievment(%) >100%"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'APMT100PLabel
        '
        Me.APMT100PLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.APMT100PLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.APMT100PLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.APMT100PLabel.Location = New System.Drawing.Point(379, 434)
        Me.APMT100PLabel.Name = "APMT100PLabel"
        Me.APMT100PLabel.Size = New System.Drawing.Size(70, 23)
        Me.APMT100PLabel.TabIndex = 20
        Me.APMT100PLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BOThrsLTEQLabel
        '
        Me.BOThrsLTEQLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BOThrsLTEQLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BOThrsLTEQLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BOThrsLTEQLabel.Location = New System.Drawing.Point(621, 406)
        Me.BOThrsLTEQLabel.Name = "BOThrsLTEQLabel"
        Me.BOThrsLTEQLabel.Size = New System.Drawing.Size(75, 23)
        Me.BOThrsLTEQLabel.TabIndex = 21
        Me.BOThrsLTEQLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(701, 372)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(162, 23)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Total Bonus OT(Hour)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalBonusHourLabel
        '
        Me.TotalBonusHourLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TotalBonusHourLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TotalBonusHourLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalBonusHourLabel.Location = New System.Drawing.Point(869, 372)
        Me.TotalBonusHourLabel.Name = "TotalBonusHourLabel"
        Me.TotalBonusHourLabel.Size = New System.Drawing.Size(75, 23)
        Me.TotalBonusHourLabel.TabIndex = 23
        Me.TotalBonusHourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SewingLayoutTableAdapter
        '
        Me.SewingLayoutTableAdapter.ClearBeforeFill = True
        '
        'BonusGenerationDataSet
        '
        Me.BonusGenerationDataSet.DataSetName = "BonusGenerationDataSet"
        Me.BonusGenerationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingAttendanceBindingSource
        '
        Me.SewingAttendanceBindingSource.DataMember = "SewingAttendance"
        Me.SewingAttendanceBindingSource.DataSource = Me.BonusGenerationDataSet
        '
        'SewingAttendanceTableAdapter
        '
        Me.SewingAttendanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.SewingAttendanceTableAdapter = Me.SewingAttendanceTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.BonusGenerationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingProductionTableAdapter
        '
        Me.SewingProductionTableAdapter.ClearBeforeFill = True
        '
        'SewingProductionBindingSource
        '
        Me.SewingProductionBindingSource.DataMember = "SewingProduction"
        Me.SewingProductionBindingSource.DataSource = Me.BonusGenerationDataSet
        '
        'SewingLayoutTableAdapter1
        '
        Me.SewingLayoutTableAdapter1.ClearBeforeFill = True
        '
        'HelperLabel
        '
        Me.HelperLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelperLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HelperLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.HelperLabel.Location = New System.Drawing.Point(464, 112)
        Me.HelperLabel.Name = "HelperLabel"
        Me.HelperLabel.Size = New System.Drawing.Size(41, 23)
        Me.HelperLabel.TabIndex = 35
        Me.HelperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(404, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 23)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "HELPER"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OperatorLabel
        '
        Me.OperatorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OperatorLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OperatorLabel.Location = New System.Drawing.Point(357, 112)
        Me.OperatorLabel.Name = "OperatorLabel"
        Me.OperatorLabel.Size = New System.Drawing.Size(41, 23)
        Me.OperatorLabel.TabIndex = 33
        Me.OperatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TargetLabel
        '
        Me.TargetLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TargetLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TargetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TargetLabel.Location = New System.Drawing.Point(416, 46)
        Me.TargetLabel.Name = "TargetLabel"
        Me.TargetLabel.Size = New System.Drawing.Size(89, 23)
        Me.TargetLabel.TabIndex = 32
        Me.TargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BonusTargetLabel
        '
        Me.BonusTargetLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BonusTargetLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BonusTargetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BonusTargetLabel.Location = New System.Drawing.Point(416, 74)
        Me.BonusTargetLabel.Name = "BonusTargetLabel"
        Me.BonusTargetLabel.Size = New System.Drawing.Size(89, 23)
        Me.BonusTargetLabel.TabIndex = 31
        Me.BonusTargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Location = New System.Drawing.Point(275, 112)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 23)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "OPERATOR"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label25.Location = New System.Drawing.Point(275, 74)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(135, 23)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "BONUS TARGET/HR"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.Location = New System.Drawing.Point(275, 46)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(135, 23)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "TARGET/HR"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(LayoutIdLabel)
        Me.GroupBox1.Controls.Add(Me.LayoutIdGridLookUpEdit1)
        Me.GroupBox1.Controls.Add(BonusTopSheetNameLabel)
        Me.GroupBox1.Controls.Add(Me.BonusTopSheetNameTextBox)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.GeneralCheckBox)
        Me.GroupBox1.Controls.Add(Me.HelperLabel)
        Me.GroupBox1.Controls.Add(Me.OperatorLabel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.TargetLabel)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.BonusTargetLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 146)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Layout"
        '
        'LayoutIdGridLookUpEdit1
        '
        Me.LayoutIdGridLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BonusTopSheetBindingSource, "LayoutId", True))
        Me.LayoutIdGridLookUpEdit1.Location = New System.Drawing.Point(136, 76)
        Me.LayoutIdGridLookUpEdit1.Name = "LayoutIdGridLookUpEdit1"
        Me.LayoutIdGridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LayoutIdGridLookUpEdit1.Properties.DataSource = Me.SewingLayoutBindingSource1
        Me.LayoutIdGridLookUpEdit1.Properties.DisplayMember = "SewingLayoutNo"
        Me.LayoutIdGridLookUpEdit1.Properties.NullText = ""
        Me.LayoutIdGridLookUpEdit1.Properties.ReadOnly = True
        Me.LayoutIdGridLookUpEdit1.Properties.ValueMember = "LayoutId"
        Me.LayoutIdGridLookUpEdit1.Properties.View = Me.LayoutIdGridLookUpEdit1View
        Me.LayoutIdGridLookUpEdit1.Size = New System.Drawing.Size(130, 20)
        Me.LayoutIdGridLookUpEdit1.TabIndex = 42
        '
        'LayoutIdGridLookUpEdit1View
        '
        Me.LayoutIdGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.LayoutIdGridLookUpEdit1View.Name = "LayoutIdGridLookUpEdit1View"
        Me.LayoutIdGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.LayoutIdGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'BonusTopSheetNameTextBox
        '
        Me.BonusTopSheetNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BonusTopSheetNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BonusTopSheetBindingSource, "BonusTopSheetName", True))
        Me.BonusTopSheetNameTextBox.Location = New System.Drawing.Point(17, 46)
        Me.BonusTopSheetNameTextBox.Name = "BonusTopSheetNameTextBox"
        Me.BonusTopSheetNameTextBox.ReadOnly = True
        Me.BonusTopSheetNameTextBox.Size = New System.Drawing.Size(249, 20)
        Me.BonusTopSheetNameTextBox.TabIndex = 41
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(418, 17)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "OLD Method"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GeneralCheckBox
        '
        Me.GeneralCheckBox.AutoSize = True
        Me.GeneralCheckBox.Location = New System.Drawing.Point(19, 112)
        Me.GeneralCheckBox.Name = "GeneralCheckBox"
        Me.GeneralCheckBox.Size = New System.Drawing.Size(171, 17)
        Me.GeneralCheckBox.TabIndex = 12
        Me.GeneralCheckBox.Text = "Apply General Hour Equivalent"
        Me.GeneralCheckBox.UseVisualStyleBackColor = True
        '
        'RecalculateButton
        '
        Me.RecalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RecalculateButton.Location = New System.Drawing.Point(906, 3)
        Me.RecalculateButton.Name = "RecalculateButton"
        Me.RecalculateButton.Size = New System.Drawing.Size(75, 28)
        Me.RecalculateButton.TabIndex = 38
        Me.RecalculateButton.Text = "&Re-calculate"
        Me.RecalculateButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrintButton.Location = New System.Drawing.Point(393, 3)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(43, 28)
        Me.PrintButton.TabIndex = 37
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Location = New System.Drawing.Point(442, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(40, 28)
        Me.SaveButton.TabIndex = 36
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.BonusTopSheetBindingSource
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl1.Location = New System.Drawing.Point(10, 200)
        Me.GridControl1.MainView = Me.BandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LineLookUpEdit, Me.ProductionMonthItemLookUpEdit, Me.RepositoryItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1115, 159)
        Me.GridControl1.TabIndex = 37
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2, Me.GridBand3, Me.GridBand4, Me.GridBand5})
        Me.BandedGridView1.ColumnPanelRowHeight = 30
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colBonusId, Me.colLayoutId1, Me.colSewingDate, Me.colProductionQuantity, Me.colGeneral, Me.colFirstOT, Me.colSecondOT, Me.colRemarks1, Me.colUserId, Me.colModifiedDate, Me.colTTLHour, Me.colLineId1, Me.colLossHour, Me.colGeneral_Operator, Me.colGeneral_Helper, Me.colFirstOT_Operator, Me.colFirstOT_Helper, Me.colSecondOT_Operator, Me.colSecondOT_Helper, Me.colFirstOT_WH, Me.colSecondOT_WH, Me.colGeneral_WH, Me.colThird_Helper, Me.colThird_Operator, Me.colThird_OT, Me.colThird_WH, Me.colProductionMonthId})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.colLossHour
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition1.Value2 = "0"
        StyleFormatCondition2.Column = Me.colSewingDate
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = New Date(2011, 7, 11, 15, 54, 13, 0)
        Me.BandedGridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.BandedGridView1.GridControl = Me.GridControl1
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ShowFooter = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Main Information"
        Me.GridBand1.Columns.Add(Me.colBonusId)
        Me.GridBand1.Columns.Add(Me.colProductionMonthId)
        Me.GridBand1.Columns.Add(Me.colLayoutId1)
        Me.GridBand1.Columns.Add(Me.colSewingDate)
        Me.GridBand1.Columns.Add(Me.colUserId)
        Me.GridBand1.Columns.Add(Me.colModifiedDate)
        Me.GridBand1.Columns.Add(Me.colLineId1)
        Me.GridBand1.Columns.Add(Me.colProductionQuantity)
        Me.GridBand1.Columns.Add(Me.colLossHour)
        Me.GridBand1.Columns.Add(Me.colTTLHour)
        Me.GridBand1.Columns.Add(Me.colRemarks1)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 731
        '
        'colBonusId
        '
        Me.colBonusId.AppearanceHeader.Options.UseTextOptions = True
        Me.colBonusId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBonusId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBonusId.FieldName = "BonusId"
        Me.colBonusId.Name = "colBonusId"
        '
        'colProductionMonthId
        '
        Me.colProductionMonthId.AppearanceCell.Options.UseTextOptions = True
        Me.colProductionMonthId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProductionMonthId.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProductionMonthId.Caption = "Prod Month"
        Me.colProductionMonthId.ColumnEdit = Me.ProductionMonthItemLookUpEdit
        Me.colProductionMonthId.FieldName = "ProductionMonthId"
        Me.colProductionMonthId.Name = "colProductionMonthId"
        Me.colProductionMonthId.Visible = True
        Me.colProductionMonthId.Width = 80
        '
        'ProductionMonthItemLookUpEdit
        '
        Me.ProductionMonthItemLookUpEdit.AutoHeight = False
        Me.ProductionMonthItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductionMonthItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductionMonthId", "Production Month Id", 120, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductionMonth", "Production Month", 94, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductionYear", "Production Year", 86, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remarks", "Remarks", 51, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductionMonthName", "Production Month Name", 124, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ProductionMonthItemLookUpEdit.DataSource = Me.ProductionMonthBindingSource
        Me.ProductionMonthItemLookUpEdit.DisplayMember = "ProductionMonthName"
        Me.ProductionMonthItemLookUpEdit.Name = "ProductionMonthItemLookUpEdit"
        Me.ProductionMonthItemLookUpEdit.NullText = ""
        Me.ProductionMonthItemLookUpEdit.ValueMember = "ProductionMonthId"
        '
        'ProductionMonthBindingSource
        '
        Me.ProductionMonthBindingSource.DataMember = "ProductionMonth"
        Me.ProductionMonthBindingSource.DataSource = Me.ProductionMonthDataSet
        '
        'ProductionMonthDataSet
        '
        Me.ProductionMonthDataSet.DataSetName = "ProductionMonthDataSet"
        Me.ProductionMonthDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colLayoutId1
        '
        Me.colLayoutId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colLayoutId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLayoutId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLayoutId1.Caption = "Layout No"
        Me.colLayoutId1.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colLayoutId1.FieldName = "LayoutId"
        Me.colLayoutId1.Name = "colLayoutId1"
        Me.colLayoutId1.Visible = True
        Me.colLayoutId1.Width = 106
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LayoutId", "Layout Id", 69, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SewingLayoutNo", "Sewing Layout No", 96, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.SewingLayoutBindingSource1
        Me.RepositoryItemLookUpEdit1.DisplayMember = "SewingLayoutNo"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "LayoutId"
        '
        'colUserId
        '
        Me.colUserId.AppearanceHeader.Options.UseTextOptions = True
        Me.colUserId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUserId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        '
        'colModifiedDate
        '
        Me.colModifiedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colModifiedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModifiedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        '
        'colLineId1
        '
        Me.colLineId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colLineId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLineId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLineId1.Caption = "Line"
        Me.colLineId1.ColumnEdit = Me.LineLookUpEdit
        Me.colLineId1.FieldName = "LineId"
        Me.colLineId1.Name = "colLineId1"
        Me.colLineId1.OptionsColumn.ReadOnly = True
        Me.colLineId1.Visible = True
        Me.colLineId1.Width = 72
        '
        'LineLookUpEdit
        '
        Me.LineLookUpEdit.AutoHeight = False
        Me.LineLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LineLookUpEdit.DataSource = Me.LineBindingSource
        Me.LineLookUpEdit.DisplayMember = "Line"
        Me.LineLookUpEdit.Name = "LineLookUpEdit"
        Me.LineLookUpEdit.NullText = ""
        Me.LineLookUpEdit.ValueMember = "LineId"
        '
        'colProductionQuantity
        '
        Me.colProductionQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colProductionQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProductionQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProductionQuantity.FieldName = "ProductionQuantity"
        Me.colProductionQuantity.Name = "colProductionQuantity"
        Me.colProductionQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colProductionQuantity.Visible = True
        Me.colProductionQuantity.Width = 77
        '
        'colTTLHour
        '
        Me.colTTLHour.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colTTLHour.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colTTLHour.AppearanceCell.BorderColor = System.Drawing.Color.Red
        Me.colTTLHour.AppearanceCell.Options.UseBackColor = True
        Me.colTTLHour.AppearanceCell.Options.UseBorderColor = True
        Me.colTTLHour.AppearanceHeader.Options.UseTextOptions = True
        Me.colTTLHour.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTTLHour.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTTLHour.FieldName = "TTLHour"
        Me.colTTLHour.Name = "colTTLHour"
        Me.colTTLHour.OptionsColumn.ReadOnly = True
        Me.colTTLHour.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTTLHour.Visible = True
        Me.colTTLHour.Width = 77
        '
        'colRemarks1
        '
        Me.colRemarks1.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.Width = 147
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "General"
        Me.GridBand2.Columns.Add(Me.colGeneral_Operator)
        Me.GridBand2.Columns.Add(Me.colGeneral_Helper)
        Me.GridBand2.Columns.Add(Me.colGeneral_WH)
        Me.GridBand2.Columns.Add(Me.colGeneral)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.VisibleIndex = 1
        Me.GridBand2.Width = 236
        '
        'colGeneral_Operator
        '
        Me.colGeneral_Operator.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colGeneral_Operator.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colGeneral_Operator.AppearanceCell.Options.UseBackColor = True
        Me.colGeneral_Operator.AppearanceHeader.Options.UseTextOptions = True
        Me.colGeneral_Operator.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGeneral_Operator.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGeneral_Operator.Caption = "Operator"
        Me.colGeneral_Operator.FieldName = "General_Operator"
        Me.colGeneral_Operator.Name = "colGeneral_Operator"
        Me.colGeneral_Operator.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colGeneral_Operator.Visible = True
        Me.colGeneral_Operator.Width = 67
        '
        'colGeneral_Helper
        '
        Me.colGeneral_Helper.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colGeneral_Helper.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colGeneral_Helper.AppearanceCell.Options.UseBackColor = True
        Me.colGeneral_Helper.AppearanceHeader.Options.UseTextOptions = True
        Me.colGeneral_Helper.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGeneral_Helper.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGeneral_Helper.Caption = "Helper"
        Me.colGeneral_Helper.FieldName = "General_Helper"
        Me.colGeneral_Helper.Name = "colGeneral_Helper"
        Me.colGeneral_Helper.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colGeneral_Helper.Visible = True
        Me.colGeneral_Helper.Width = 60
        '
        'colGeneral_WH
        '
        Me.colGeneral_WH.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colGeneral_WH.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colGeneral_WH.AppearanceCell.Options.UseBackColor = True
        Me.colGeneral_WH.Caption = "GWH"
        Me.colGeneral_WH.FieldName = "General_WH"
        Me.colGeneral_WH.Name = "colGeneral_WH"
        Me.colGeneral_WH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colGeneral_WH.Visible = True
        Me.colGeneral_WH.Width = 51
        '
        'colGeneral
        '
        Me.colGeneral.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colGeneral.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colGeneral.AppearanceCell.Options.UseBackColor = True
        Me.colGeneral.AppearanceHeader.Options.UseTextOptions = True
        Me.colGeneral.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGeneral.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGeneral.Caption = "Hour"
        Me.colGeneral.FieldName = "General"
        Me.colGeneral.Name = "colGeneral"
        Me.colGeneral.OptionsColumn.AllowEdit = False
        Me.colGeneral.OptionsColumn.ReadOnly = True
        Me.colGeneral.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colGeneral.Visible = True
        Me.colGeneral.Width = 58
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "First OT"
        Me.GridBand3.Columns.Add(Me.colFirstOT_Operator)
        Me.GridBand3.Columns.Add(Me.colFirstOT_Helper)
        Me.GridBand3.Columns.Add(Me.colFirstOT_WH)
        Me.GridBand3.Columns.Add(Me.colFirstOT)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.VisibleIndex = 2
        Me.GridBand3.Width = 227
        '
        'colFirstOT_Operator
        '
        Me.colFirstOT_Operator.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colFirstOT_Operator.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFirstOT_Operator.AppearanceCell.Options.UseBackColor = True
        Me.colFirstOT_Operator.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstOT_Operator.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstOT_Operator.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstOT_Operator.Caption = "Operator"
        Me.colFirstOT_Operator.FieldName = "FirstOT_Operator"
        Me.colFirstOT_Operator.Name = "colFirstOT_Operator"
        Me.colFirstOT_Operator.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFirstOT_Operator.Visible = True
        Me.colFirstOT_Operator.Width = 64
        '
        'colFirstOT_Helper
        '
        Me.colFirstOT_Helper.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colFirstOT_Helper.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFirstOT_Helper.AppearanceCell.Options.UseBackColor = True
        Me.colFirstOT_Helper.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstOT_Helper.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstOT_Helper.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstOT_Helper.Caption = "Helper"
        Me.colFirstOT_Helper.FieldName = "FirstOT_Helper"
        Me.colFirstOT_Helper.Name = "colFirstOT_Helper"
        Me.colFirstOT_Helper.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFirstOT_Helper.Visible = True
        Me.colFirstOT_Helper.Width = 55
        '
        'colFirstOT_WH
        '
        Me.colFirstOT_WH.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colFirstOT_WH.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFirstOT_WH.AppearanceCell.Options.UseBackColor = True
        Me.colFirstOT_WH.Caption = "FWH"
        Me.colFirstOT_WH.FieldName = "FirstOT_WH"
        Me.colFirstOT_WH.Name = "colFirstOT_WH"
        Me.colFirstOT_WH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFirstOT_WH.Visible = True
        Me.colFirstOT_WH.Width = 49
        '
        'colFirstOT
        '
        Me.colFirstOT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colFirstOT.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFirstOT.AppearanceCell.Options.UseBackColor = True
        Me.colFirstOT.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstOT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstOT.Caption = "Hour"
        Me.colFirstOT.FieldName = "FirstOT"
        Me.colFirstOT.Name = "colFirstOT"
        Me.colFirstOT.OptionsColumn.AllowEdit = False
        Me.colFirstOT.OptionsColumn.ReadOnly = True
        Me.colFirstOT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFirstOT.Visible = True
        Me.colFirstOT.Width = 59
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "Second OT"
        Me.GridBand4.Columns.Add(Me.colSecondOT_Operator)
        Me.GridBand4.Columns.Add(Me.colSecondOT_Helper)
        Me.GridBand4.Columns.Add(Me.colSecondOT_WH)
        Me.GridBand4.Columns.Add(Me.colSecondOT)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.VisibleIndex = 3
        Me.GridBand4.Width = 224
        '
        'colSecondOT_Operator
        '
        Me.colSecondOT_Operator.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colSecondOT_Operator.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSecondOT_Operator.AppearanceCell.Options.UseBackColor = True
        Me.colSecondOT_Operator.AppearanceHeader.Options.UseTextOptions = True
        Me.colSecondOT_Operator.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSecondOT_Operator.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSecondOT_Operator.Caption = "Operator"
        Me.colSecondOT_Operator.FieldName = "SecondOT_Operator"
        Me.colSecondOT_Operator.Name = "colSecondOT_Operator"
        Me.colSecondOT_Operator.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colSecondOT_Operator.Visible = True
        Me.colSecondOT_Operator.Width = 69
        '
        'colSecondOT_Helper
        '
        Me.colSecondOT_Helper.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colSecondOT_Helper.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSecondOT_Helper.AppearanceCell.Options.UseBackColor = True
        Me.colSecondOT_Helper.AppearanceHeader.Options.UseTextOptions = True
        Me.colSecondOT_Helper.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSecondOT_Helper.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSecondOT_Helper.Caption = "Helper"
        Me.colSecondOT_Helper.FieldName = "SecondOT_Helper"
        Me.colSecondOT_Helper.Name = "colSecondOT_Helper"
        Me.colSecondOT_Helper.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colSecondOT_Helper.Visible = True
        Me.colSecondOT_Helper.Width = 57
        '
        'colSecondOT_WH
        '
        Me.colSecondOT_WH.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colSecondOT_WH.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSecondOT_WH.AppearanceCell.Options.UseBackColor = True
        Me.colSecondOT_WH.Caption = "SWH"
        Me.colSecondOT_WH.FieldName = "SecondOT_WH"
        Me.colSecondOT_WH.Name = "colSecondOT_WH"
        Me.colSecondOT_WH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colSecondOT_WH.Visible = True
        Me.colSecondOT_WH.Width = 52
        '
        'colSecondOT
        '
        Me.colSecondOT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colSecondOT.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSecondOT.AppearanceCell.Options.UseBackColor = True
        Me.colSecondOT.AppearanceHeader.Options.UseTextOptions = True
        Me.colSecondOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSecondOT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSecondOT.Caption = "Hour"
        Me.colSecondOT.FieldName = "SecondOT"
        Me.colSecondOT.Name = "colSecondOT"
        Me.colSecondOT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colSecondOT.Visible = True
        Me.colSecondOT.Width = 46
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "Third OT"
        Me.GridBand5.Columns.Add(Me.colThird_Operator)
        Me.GridBand5.Columns.Add(Me.colThird_Helper)
        Me.GridBand5.Columns.Add(Me.colThird_WH)
        Me.GridBand5.Columns.Add(Me.colThird_OT)
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.VisibleIndex = 4
        Me.GridBand5.Width = 211
        '
        'colThird_Operator
        '
        Me.colThird_Operator.Caption = "Operator"
        Me.colThird_Operator.FieldName = "Third_Operator"
        Me.colThird_Operator.Name = "colThird_Operator"
        Me.colThird_Operator.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colThird_Operator.Visible = True
        Me.colThird_Operator.Width = 65
        '
        'colThird_Helper
        '
        Me.colThird_Helper.Caption = "Helper"
        Me.colThird_Helper.FieldName = "Third_Helper"
        Me.colThird_Helper.Name = "colThird_Helper"
        Me.colThird_Helper.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colThird_Helper.Visible = True
        Me.colThird_Helper.Width = 51
        '
        'colThird_WH
        '
        Me.colThird_WH.Caption = "TWH"
        Me.colThird_WH.FieldName = "Third_WH"
        Me.colThird_WH.Name = "colThird_WH"
        Me.colThird_WH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colThird_WH.Visible = True
        Me.colThird_WH.Width = 45
        '
        'colThird_OT
        '
        Me.colThird_OT.Caption = "Hours"
        Me.colThird_OT.FieldName = "Third_OT"
        Me.colThird_OT.Name = "colThird_OT"
        Me.colThird_OT.OptionsColumn.AllowEdit = False
        Me.colThird_OT.OptionsColumn.ReadOnly = True
        Me.colThird_OT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colThird_OT.Visible = True
        Me.colThird_OT.Width = 50
        '
        'ChartControl1
        '
        Me.ChartControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartControl1.DataAdapter = Me.ProductionMonthTableAdapter
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.DataSource = Me.ProductionMonthDataSet.ProductionMonth
        XyDiagram1.AxisX.Label.TextPattern = "{A:dd-MM}"
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl1.Location = New System.Drawing.Point(546, 54)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "SewingDate"
        Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series1.DataSource = Me.BonusTopSheetBindingSource
        PointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Label = PointSeriesLabel1
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.Name = "Series 1"
        Series1.ValueDataMembersSerializable = "ProdPerHour"
        LineSeriesView1.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView1.LineMarkerOptions.BorderVisible = False
        LineSeriesView1.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
        PolygonGradientFillOptions1.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        PolygonGradientFillOptions1.GradientMode = DevExpress.XtraCharts.PolygonGradientMode.BottomToTop
        LineSeriesView1.LineMarkerOptions.FillStyle.Options = PolygonGradientFillOptions1
        LineSeriesView1.LineMarkerOptions.Size = 7
        LineSeriesView1.LineStyle.Thickness = 1
        LineSeriesView1.Shadow.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        LineSeriesView1.Shadow.Size = 5
        Series1.View = LineSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        PointSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.SeriesTemplate.Label = PointSeriesLabel2
        Me.ChartControl1.SeriesTemplate.View = LineSeriesView2
        Me.ChartControl1.Size = New System.Drawing.Size(579, 140)
        Me.ChartControl1.TabIndex = 38
        '
        'ProductionMonthTableAdapter
        '
        Me.ProductionMonthTableAdapter.ClearBeforeFill = True
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.ForeColor = System.Drawing.Color.Red
        Me.MessageLabel.Location = New System.Drawing.Point(720, 416)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(0, 13)
        Me.MessageLabel.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(701, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 23)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Layout Efficiency"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LayoutEfficiencyLabel
        '
        Me.LayoutEfficiencyLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LayoutEfficiencyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LayoutEfficiencyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LayoutEfficiencyLabel.Location = New System.Drawing.Point(869, 406)
        Me.LayoutEfficiencyLabel.Name = "LayoutEfficiencyLabel"
        Me.LayoutEfficiencyLabel.Size = New System.Drawing.Size(75, 23)
        Me.LayoutEfficiencyLabel.TabIndex = 42
        Me.LayoutEfficiencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Location = New System.Drawing.Point(869, 434)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 43
        Me.AddButton.Text = "&Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ProductionMonthComboBox
        '
        Me.ProductionMonthComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProductionMonthComboBox.DataSource = Me.ProductionMonthBindingSource
        Me.ProductionMonthComboBox.DisplayMember = "ProductionMonthName"
        Me.ProductionMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProductionMonthComboBox.FormattingEnabled = True
        Me.ProductionMonthComboBox.Location = New System.Drawing.Point(702, 436)
        Me.ProductionMonthComboBox.Name = "ProductionMonthComboBox"
        Me.ProductionMonthComboBox.Size = New System.Drawing.Size(159, 21)
        Me.ProductionMonthComboBox.TabIndex = 44
        Me.ProductionMonthComboBox.ValueMember = "ProductionMonthId"
        '
        'BonusTopSheetNoGridLookUpEdit
        '
        Me.BonusTopSheetNoGridLookUpEdit.Location = New System.Drawing.Point(180, 7)
        Me.BonusTopSheetNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.BonusTopSheetNoGridLookUpEdit.Name = "BonusTopSheetNoGridLookUpEdit"
        Me.BonusTopSheetNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BonusTopSheetNoGridLookUpEdit.Properties.DataSource = Me.BonusTopSheetNameLookupBindingSource
        Me.BonusTopSheetNoGridLookUpEdit.Properties.DisplayMember = "BonusTopSheetName"
        Me.BonusTopSheetNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BonusTopSheetNoGridLookUpEdit.Properties.NullText = "[Type Bonus Sheet Name]"
        Me.BonusTopSheetNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BonusTopSheetNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BonusTopSheetNoGridLookUpEdit.Properties.ValueMember = "BonusTopSheetName"
        Me.BonusTopSheetNoGridLookUpEdit.Properties.View = Me.GridView1
        Me.BonusTopSheetNoGridLookUpEdit.Size = New System.Drawing.Size(155, 20)
        Me.BonusTopSheetNoGridLookUpEdit.TabIndex = 45
        '
        'BonusTopSheetNameLookupBindingSource
        '
        Me.BonusTopSheetNameLookupBindingSource.DataMember = "BonusTopSheetNameLookup"
        Me.BonusTopSheetNameLookupBindingSource.DataSource = Me.BonusDataSet
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBonusTopSheetName})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colBonusTopSheetName
        '
        Me.colBonusTopSheetName.FieldName = "BonusTopSheetName"
        Me.colBonusTopSheetName.Name = "colBonusTopSheetName"
        Me.colBonusTopSheetName.Visible = True
        Me.colBonusTopSheetName.VisibleIndex = 0
        '
        'BonusTopSheetNameLookupTableAdapter
        '
        Me.BonusTopSheetNameLookupTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(10, 9, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Bonus Top Sheet No"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel1.Controls.Add(Me.BonusTopSheetNoGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrintButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.SaveButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.LayoutIdGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.DoubleLayoutCheckBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.LayoutIdGridLookUpEdit3)
        Me.FlowLayoutPanel1.Controls.Add(Me.CalculateProductionButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RecalculateButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1137, 33)
        Me.FlowLayoutPanel1.TabIndex = 48
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Location = New System.Drawing.Point(3, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(51, 28)
        Me.DeleteButton.TabIndex = 51
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.Location = New System.Drawing.Point(341, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(46, 28)
        Me.ShowButton.TabIndex = 47
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(488, 10)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Select Layout"
        '
        'DoubleLayoutCheckBox
        '
        Me.DoubleLayoutCheckBox.AutoSize = True
        Me.DoubleLayoutCheckBox.Location = New System.Drawing.Point(685, 9)
        Me.DoubleLayoutCheckBox.Margin = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.DoubleLayoutCheckBox.Name = "DoubleLayoutCheckBox"
        Me.DoubleLayoutCheckBox.Size = New System.Drawing.Size(32, 17)
        Me.DoubleLayoutCheckBox.TabIndex = 50
        Me.DoubleLayoutCheckBox.Text = "+"
        Me.DoubleLayoutCheckBox.UseVisualStyleBackColor = True
        '
        'LayoutIdGridLookUpEdit3
        '
        Me.LayoutIdGridLookUpEdit3.Location = New System.Drawing.Point(723, 7)
        Me.LayoutIdGridLookUpEdit3.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.LayoutIdGridLookUpEdit3.Name = "LayoutIdGridLookUpEdit3"
        Me.LayoutIdGridLookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LayoutIdGridLookUpEdit3.Properties.DataSource = Me.SewingLayoutBindingSource2
        Me.LayoutIdGridLookUpEdit3.Properties.DisplayMember = "SewingLayoutNo"
        Me.LayoutIdGridLookUpEdit3.Properties.ImmediatePopup = True
        Me.LayoutIdGridLookUpEdit3.Properties.NullText = "[Type Layout No]"
        Me.LayoutIdGridLookUpEdit3.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.LayoutIdGridLookUpEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LayoutIdGridLookUpEdit3.Properties.ValueMember = "LayoutId"
        Me.LayoutIdGridLookUpEdit3.Properties.View = Me.GridView2
        Me.LayoutIdGridLookUpEdit3.Size = New System.Drawing.Size(107, 20)
        Me.LayoutIdGridLookUpEdit3.TabIndex = 48
        '
        'SewingLayoutBindingSource2
        '
        Me.SewingLayoutBindingSource2.DataMember = "SewingLayout"
        Me.SewingLayoutBindingSource2.DataSource = Me.SewingLayoutDataSet
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLayoutId2, Me.colLineId2, Me.colTotalSMV_Machine1, Me.colTotalSMV_Manual1, Me.colMachineQuantity1, Me.colHelper1, Me.colTargetsPerHour1, Me.colRemarks2, Me.colOrderId1, Me.colStyleId1, Me.colLayoutDate1, Me.colOrderQuantity1, Me.colBonusTargetQuantity1, Me.colAddTargetPerHour1, Me.colAmendmentNo1, Me.colBonusTargets1, Me.colTotalTargetQuantity1, Me.colSewingLayoutNo1, Me.colPcsPerBundle1, Me.colLayoutTime1, Me.colPart, Me.colPreSewingLayoutNo, Me.colMCCost})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colLayoutId2
        '
        Me.colLayoutId2.FieldName = "LayoutId"
        Me.colLayoutId2.Name = "colLayoutId2"
        Me.colLayoutId2.OptionsColumn.ReadOnly = True
        '
        'colLineId2
        '
        Me.colLineId2.FieldName = "LineId"
        Me.colLineId2.Name = "colLineId2"
        '
        'colTotalSMV_Machine1
        '
        Me.colTotalSMV_Machine1.FieldName = "TotalSMV_Machine"
        Me.colTotalSMV_Machine1.Name = "colTotalSMV_Machine1"
        '
        'colTotalSMV_Manual1
        '
        Me.colTotalSMV_Manual1.FieldName = "TotalSMV_Manual"
        Me.colTotalSMV_Manual1.Name = "colTotalSMV_Manual1"
        '
        'colMachineQuantity1
        '
        Me.colMachineQuantity1.FieldName = "MachineQuantity"
        Me.colMachineQuantity1.Name = "colMachineQuantity1"
        '
        'colHelper1
        '
        Me.colHelper1.FieldName = "Helper"
        Me.colHelper1.Name = "colHelper1"
        '
        'colTargetsPerHour1
        '
        Me.colTargetsPerHour1.FieldName = "TargetsPerHour"
        Me.colTargetsPerHour1.Name = "colTargetsPerHour1"
        '
        'colRemarks2
        '
        Me.colRemarks2.FieldName = "Remarks"
        Me.colRemarks2.Name = "colRemarks2"
        '
        'colOrderId1
        '
        Me.colOrderId1.FieldName = "OrderId"
        Me.colOrderId1.Name = "colOrderId1"
        '
        'colStyleId1
        '
        Me.colStyleId1.FieldName = "StyleId"
        Me.colStyleId1.Name = "colStyleId1"
        '
        'colLayoutDate1
        '
        Me.colLayoutDate1.FieldName = "LayoutDate"
        Me.colLayoutDate1.Name = "colLayoutDate1"
        '
        'colOrderQuantity1
        '
        Me.colOrderQuantity1.FieldName = "OrderQuantity"
        Me.colOrderQuantity1.Name = "colOrderQuantity1"
        '
        'colBonusTargetQuantity1
        '
        Me.colBonusTargetQuantity1.FieldName = "BonusTargetQuantity"
        Me.colBonusTargetQuantity1.Name = "colBonusTargetQuantity1"
        '
        'colAddTargetPerHour1
        '
        Me.colAddTargetPerHour1.FieldName = "AddTargetPerHour"
        Me.colAddTargetPerHour1.Name = "colAddTargetPerHour1"
        '
        'colAmendmentNo1
        '
        Me.colAmendmentNo1.FieldName = "AmendmentNo"
        Me.colAmendmentNo1.Name = "colAmendmentNo1"
        '
        'colBonusTargets1
        '
        Me.colBonusTargets1.FieldName = "BonusTargets"
        Me.colBonusTargets1.Name = "colBonusTargets1"
        '
        'colTotalTargetQuantity1
        '
        Me.colTotalTargetQuantity1.FieldName = "TotalTargetQuantity"
        Me.colTotalTargetQuantity1.Name = "colTotalTargetQuantity1"
        '
        'colSewingLayoutNo1
        '
        Me.colSewingLayoutNo1.FieldName = "SewingLayoutNo"
        Me.colSewingLayoutNo1.Name = "colSewingLayoutNo1"
        Me.colSewingLayoutNo1.Visible = True
        Me.colSewingLayoutNo1.VisibleIndex = 0
        '
        'colPcsPerBundle1
        '
        Me.colPcsPerBundle1.FieldName = "PcsPerBundle"
        Me.colPcsPerBundle1.Name = "colPcsPerBundle1"
        '
        'colLayoutTime1
        '
        Me.colLayoutTime1.FieldName = "LayoutTime"
        Me.colLayoutTime1.Name = "colLayoutTime1"
        '
        'colPart
        '
        Me.colPart.FieldName = "Part"
        Me.colPart.Name = "colPart"
        '
        'colPreSewingLayoutNo
        '
        Me.colPreSewingLayoutNo.FieldName = "PreSewingLayoutNo"
        Me.colPreSewingLayoutNo.Name = "colPreSewingLayoutNo"
        '
        'colMCCost
        '
        Me.colMCCost.FieldName = "MCCost"
        Me.colMCCost.Name = "colMCCost"
        '
        'frmBonusTopSheetGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 476)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ProductionMonthComboBox)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.LayoutEfficiencyLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.ChartControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TotalBonusHourLabel)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BOThrsLTEQLabel)
        Me.Controls.Add(Me.APMT100PLabel)
        Me.Controls.Add(Me.BOThrsGTLabel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.AchievementPercentage)
        Me.Controls.Add(Me.AchievementPCLabel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TargetPCLabel)
        Me.Controls.Add(Me.AvgProdPerHourLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TotalProductionLabel)
        Me.Controls.Add(Me.TotalHourLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBonusTopSheetGenerator"
        Me.Text = "Bonus Top Sheet Generator"
        CType(Me.BonusTopSheetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonusGenerationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LayoutIdGridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutIdGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionMonthItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionMonthBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionMonthDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonusTopSheetNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonusTopSheetNameLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.LayoutIdGridLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BonusDataSet As KSoft_Apparel.BonusDataSet
    Friend WithEvents BonusTopSheetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BonusTopSheetTableAdapter As KSoft_Apparel.BonusDataSetTableAdapters.BonusTopSheetTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.BonusDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TotalProductionLabel As System.Windows.Forms.Label
    Friend WithEvents TotalHourLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TargetPCLabel As System.Windows.Forms.Label
    Friend WithEvents AvgProdPerHourLabel As System.Windows.Forms.Label
    Friend WithEvents LayoutIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CalculateProductionButton As System.Windows.Forms.Button
    Friend WithEvents AchievementPercentage As System.Windows.Forms.Label
    Friend WithEvents AchievementPCLabel As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BOThrsGTLabel As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents APMT100PLabel As System.Windows.Forms.Label
    Friend WithEvents BOThrsLTEQLabel As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TotalBonusHourLabel As System.Windows.Forms.Label
    Friend WithEvents SewingLayoutDataSet As KSoft_Apparel.SewingLayoutDataSet
    Friend WithEvents SewingLayoutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingLayoutTableAdapter As KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingLayoutTableAdapter
    Friend WithEvents colLayoutId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSMV_Machine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSMV_Manual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHelper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTargetsPerHour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLayoutDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBonusTargetQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddTargetPerHour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBonusTargets As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalTargetQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingLayoutNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPcsPerBundle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLayoutTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BonusGenerationDataSet As KSoft_Apparel.BonusGenerationDataSet
    Friend WithEvents SewingAttendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingAttendanceTableAdapter As KSoft_Apparel.BonusGenerationDataSetTableAdapters.SewingAttendanceTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.BonusGenerationDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingProductionTableAdapter As KSoft_Apparel.BonusGenerationDataSetTableAdapters.SewingProductionTableAdapter
    Friend WithEvents SewingProductionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingLayoutLookupDataSet As KSoft_Apparel.SewingLayoutLookupDataSet
    Friend WithEvents SewingLayoutBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SewingLayoutTableAdapter1 As KSoft_Apparel.SewingLayoutLookupDataSetTableAdapters.SewingLayoutTableAdapter
    Friend WithEvents HelperLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OperatorLabel As System.Windows.Forms.Label
    Friend WithEvents TargetLabel As System.Windows.Forms.Label
    Friend WithEvents BonusTargetLabel As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
    Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents GeneralCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colBonusId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLayoutId1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSewingDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProductionQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGeneral As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstOT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSecondOT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTLHour As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLineId1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLossHour As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGeneral_Operator As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGeneral_Helper As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstOT_Operator As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFirstOT_Helper As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSecondOT_Operator As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSecondOT_Helper As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents LineLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFirstOT_WH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSecondOT_WH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGeneral_WH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colThird_Operator As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colThird_Helper As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colThird_WH As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colThird_OT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents RecalculateButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LayoutEfficiencyLabel As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents ProductionMonthTableAdapter As KSoft_Apparel.ProductionMonthDataSetTableAdapters.ProductionMonthTableAdapter
    Friend WithEvents ProductionMonthDataSet As KSoft_Apparel.ProductionMonthDataSet
    Friend WithEvents ProductionMonthComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductionMonthBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colProductionMonthId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ProductionMonthItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BonusTopSheetNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LayoutIdGridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents LayoutIdGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BonusTopSheetNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BonusTopSheetNameLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BonusTopSheetNameLookupTableAdapter As KSoft_Apparel.BonusDataSetTableAdapters.BonusTopSheetNameLookupTableAdapter
    Friend WithEvents colBonusTopSheetName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents LayoutIdGridLookUpEdit3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DoubleLayoutCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SewingLayoutBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents colLayoutId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSMV_Machine1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSMV_Manual1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHelper1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTargetsPerHour1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLayoutDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBonusTargetQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddTargetPerHour1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBonusTargets1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalTargetQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingLayoutNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPcsPerBundle1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLayoutTime1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreSewingLayoutNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMCCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
End Class
