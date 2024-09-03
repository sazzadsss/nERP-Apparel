<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostCosting
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BudgetVSActualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BudgetVsActualDataSet = New KSoft_Apparel.BudgetVsActualDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFirstExDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colABYarnCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAYarnCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colABKnittingCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAKnittingCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colABDyeingCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADyeingCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colABCM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colABAOPCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colABPrintCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colABEmbCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colABMiscCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colABTrimCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAAOPCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAPrintCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAEmbCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAMiscCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colATrimCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colABCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BudgetVSActualTableAdapter = New KSoft_Apparel.BudgetVsActualDataSetTableAdapters.BudgetVSActualTableAdapter()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BudgetVSActualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BudgetVsActualDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BudgetVSActualBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1779, 814)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BudgetVSActualBindingSource
        '
        Me.BudgetVSActualBindingSource.DataMember = "BudgetVSActual"
        Me.BudgetVSActualBindingSource.DataSource = Me.BudgetVsActualDataSet
        '
        'BudgetVsActualDataSet
        '
        Me.BudgetVsActualDataSet.DataSetName = "BudgetVsActualDataSet"
        Me.BudgetVsActualDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 49
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderQuantity, Me.colFirstExDate, Me.colProgramNo, Me.colABYarnCost, Me.colAYarnCost, Me.colABKnittingCost, Me.colAKnittingCost, Me.colABDyeingCost, Me.colADyeingCost, Me.colABCM, Me.colACM, Me.colABAOPCost, Me.colAAOPCost, Me.colABPrintCost, Me.colABEmbCost, Me.colAEmbCost, Me.colABTrimCost, Me.colATrimCost, Me.colABMiscCost, Me.colAMiscCost, Me.colAPrintCost, Me.colABCost, Me.colACost, Me.colIsComplete, Me.colBuyerName, Me.colStyleName})
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colStyleName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colOrderQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colOrderQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.MinWidth = 27
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 4
        Me.colOrderQuantity.Width = 100
        '
        'colFirstExDate
        '
        Me.colFirstExDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFirstExDate.AppearanceCell.Options.UseBackColor = True
        Me.colFirstExDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colFirstExDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFirstExDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFirstExDate.FieldName = "FirstExDate"
        Me.colFirstExDate.MinWidth = 27
        Me.colFirstExDate.Name = "colFirstExDate"
        Me.colFirstExDate.Visible = True
        Me.colFirstExDate.VisibleIndex = 5
        Me.colFirstExDate.Width = 100
        '
        'colProgramNo
        '
        Me.colProgramNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colProgramNo.AppearanceCell.Options.UseBackColor = True
        Me.colProgramNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colProgramNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProgramNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.MinWidth = 27
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 1
        Me.colProgramNo.Width = 100
        '
        'colABYarnCost
        '
        Me.colABYarnCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colABYarnCost.AppearanceCell.Options.UseBackColor = True
        Me.colABYarnCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colABYarnCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colABYarnCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colABYarnCost.DisplayFormat.FormatString = "n2"
        Me.colABYarnCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colABYarnCost.FieldName = "ABYarnCost"
        Me.colABYarnCost.MinWidth = 27
        Me.colABYarnCost.Name = "colABYarnCost"
        Me.colABYarnCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABYarnCost", "{0:n2}")})
        Me.colABYarnCost.Visible = True
        Me.colABYarnCost.VisibleIndex = 6
        Me.colABYarnCost.Width = 100
        '
        'colAYarnCost
        '
        Me.colAYarnCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAYarnCost.AppearanceCell.Options.UseBackColor = True
        Me.colAYarnCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colAYarnCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAYarnCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAYarnCost.DisplayFormat.FormatString = "n2"
        Me.colAYarnCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAYarnCost.FieldName = "AYarnCost"
        Me.colAYarnCost.MinWidth = 27
        Me.colAYarnCost.Name = "colAYarnCost"
        Me.colAYarnCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AYarnCost", "{0:n2}")})
        Me.colAYarnCost.Visible = True
        Me.colAYarnCost.VisibleIndex = 7
        Me.colAYarnCost.Width = 100
        '
        'colABKnittingCost
        '
        Me.colABKnittingCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colABKnittingCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colABKnittingCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colABKnittingCost.DisplayFormat.FormatString = "n2"
        Me.colABKnittingCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colABKnittingCost.FieldName = "ABKnittingCost"
        Me.colABKnittingCost.MinWidth = 27
        Me.colABKnittingCost.Name = "colABKnittingCost"
        Me.colABKnittingCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABKnittingCost", "{0:n2}")})
        Me.colABKnittingCost.Visible = True
        Me.colABKnittingCost.VisibleIndex = 8
        Me.colABKnittingCost.Width = 100
        '
        'colAKnittingCost
        '
        Me.colAKnittingCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colAKnittingCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAKnittingCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAKnittingCost.DisplayFormat.FormatString = "n2"
        Me.colAKnittingCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAKnittingCost.FieldName = "AKnittingCost"
        Me.colAKnittingCost.MinWidth = 27
        Me.colAKnittingCost.Name = "colAKnittingCost"
        Me.colAKnittingCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AKnittingCost", "{0:n2}")})
        Me.colAKnittingCost.Visible = True
        Me.colAKnittingCost.VisibleIndex = 9
        Me.colAKnittingCost.Width = 100
        '
        'colABDyeingCost
        '
        Me.colABDyeingCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colABDyeingCost.AppearanceCell.Options.UseBackColor = True
        Me.colABDyeingCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colABDyeingCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colABDyeingCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colABDyeingCost.DisplayFormat.FormatString = "n2"
        Me.colABDyeingCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colABDyeingCost.FieldName = "ABDyeingCost"
        Me.colABDyeingCost.MinWidth = 27
        Me.colABDyeingCost.Name = "colABDyeingCost"
        Me.colABDyeingCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABDyeingCost", "{0:n2}")})
        Me.colABDyeingCost.Visible = True
        Me.colABDyeingCost.VisibleIndex = 10
        Me.colABDyeingCost.Width = 100
        '
        'colADyeingCost
        '
        Me.colADyeingCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colADyeingCost.AppearanceCell.Options.UseBackColor = True
        Me.colADyeingCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colADyeingCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colADyeingCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colADyeingCost.DisplayFormat.FormatString = "n2"
        Me.colADyeingCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colADyeingCost.FieldName = "ADyeingCost"
        Me.colADyeingCost.MinWidth = 27
        Me.colADyeingCost.Name = "colADyeingCost"
        Me.colADyeingCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ADyeingCost", "{0:n2}")})
        Me.colADyeingCost.Visible = True
        Me.colADyeingCost.VisibleIndex = 11
        Me.colADyeingCost.Width = 100
        '
        'colABCM
        '
        Me.colABCM.AppearanceHeader.Options.UseTextOptions = True
        Me.colABCM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colABCM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colABCM.DisplayFormat.FormatString = "n2"
        Me.colABCM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colABCM.FieldName = "ABCM"
        Me.colABCM.MinWidth = 27
        Me.colABCM.Name = "colABCM"
        Me.colABCM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABCM", "{0:n2}")})
        Me.colABCM.Visible = True
        Me.colABCM.VisibleIndex = 22
        Me.colABCM.Width = 100
        '
        'colACM
        '
        Me.colACM.AppearanceHeader.Options.UseTextOptions = True
        Me.colACM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colACM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colACM.DisplayFormat.FormatString = "n2"
        Me.colACM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colACM.FieldName = "ACM"
        Me.colACM.MinWidth = 27
        Me.colACM.Name = "colACM"
        Me.colACM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ACM", "{0:n2}")})
        Me.colACM.Visible = True
        Me.colACM.VisibleIndex = 23
        Me.colACM.Width = 100
        '
        'colABAOPCost
        '
        Me.colABAOPCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colABAOPCost.AppearanceCell.Options.UseBackColor = True
        Me.colABAOPCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colABAOPCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colABAOPCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colABAOPCost.DisplayFormat.FormatString = "n2"
        Me.colABAOPCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colABAOPCost.FieldName = "ABAOPCost"
        Me.colABAOPCost.MinWidth = 27
        Me.colABAOPCost.Name = "colABAOPCost"
        Me.colABAOPCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABAOPCost", "{0:n2}")})
        Me.colABAOPCost.Visible = True
        Me.colABAOPCost.VisibleIndex = 12
        Me.colABAOPCost.Width = 100
        '
        'colABPrintCost
        '
        Me.colABPrintCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colABPrintCost.AppearanceCell.Options.UseBackColor = True
        Me.colABPrintCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colABPrintCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colABPrintCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colABPrintCost.DisplayFormat.FormatString = "n2"
        Me.colABPrintCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colABPrintCost.FieldName = "ABPrintCost"
        Me.colABPrintCost.MinWidth = 27
        Me.colABPrintCost.Name = "colABPrintCost"
        Me.colABPrintCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABPrintCost", "{0:n2}")})
        Me.colABPrintCost.Visible = True
        Me.colABPrintCost.VisibleIndex = 14
        Me.colABPrintCost.Width = 100
        '
        'colABEmbCost
        '
        Me.colABEmbCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colABEmbCost.AppearanceCell.Options.UseBackColor = True
        Me.colABEmbCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colABEmbCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colABEmbCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colABEmbCost.DisplayFormat.FormatString = "n2"
        Me.colABEmbCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colABEmbCost.FieldName = "ABEmbCost"
        Me.colABEmbCost.MinWidth = 27
        Me.colABEmbCost.Name = "colABEmbCost"
        Me.colABEmbCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABEmbCost", "{0:n2}")})
        Me.colABEmbCost.Visible = True
        Me.colABEmbCost.VisibleIndex = 16
        Me.colABEmbCost.Width = 100
        '
        'colABMiscCost
        '
        Me.colABMiscCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colABMiscCost.AppearanceCell.Options.UseBackColor = True
        Me.colABMiscCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colABMiscCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colABMiscCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colABMiscCost.DisplayFormat.FormatString = "n2"
        Me.colABMiscCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colABMiscCost.FieldName = "ABMiscCost"
        Me.colABMiscCost.MinWidth = 27
        Me.colABMiscCost.Name = "colABMiscCost"
        Me.colABMiscCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABMiscCost", "{0:n2}")})
        Me.colABMiscCost.Visible = True
        Me.colABMiscCost.VisibleIndex = 20
        Me.colABMiscCost.Width = 100
        '
        'colABTrimCost
        '
        Me.colABTrimCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colABTrimCost.AppearanceCell.Options.UseBackColor = True
        Me.colABTrimCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colABTrimCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colABTrimCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colABTrimCost.DisplayFormat.FormatString = "n2"
        Me.colABTrimCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colABTrimCost.FieldName = "ABTrimCost"
        Me.colABTrimCost.MinWidth = 27
        Me.colABTrimCost.Name = "colABTrimCost"
        Me.colABTrimCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABTrimCost", "{0:n2}")})
        Me.colABTrimCost.Visible = True
        Me.colABTrimCost.VisibleIndex = 18
        Me.colABTrimCost.Width = 100
        '
        'colAAOPCost
        '
        Me.colAAOPCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAAOPCost.AppearanceCell.Options.UseBackColor = True
        Me.colAAOPCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colAAOPCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAAOPCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAAOPCost.DisplayFormat.FormatString = "n2"
        Me.colAAOPCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAAOPCost.FieldName = "AAOPCost"
        Me.colAAOPCost.MinWidth = 27
        Me.colAAOPCost.Name = "colAAOPCost"
        Me.colAAOPCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AAOPCost", "{0:n2}")})
        Me.colAAOPCost.Visible = True
        Me.colAAOPCost.VisibleIndex = 13
        Me.colAAOPCost.Width = 100
        '
        'colAPrintCost
        '
        Me.colAPrintCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colAPrintCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAPrintCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAPrintCost.DisplayFormat.FormatString = "n2"
        Me.colAPrintCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAPrintCost.FieldName = "APrintCost"
        Me.colAPrintCost.MinWidth = 27
        Me.colAPrintCost.Name = "colAPrintCost"
        Me.colAPrintCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "APrintCost", "{0:n2}")})
        Me.colAPrintCost.Visible = True
        Me.colAPrintCost.VisibleIndex = 15
        Me.colAPrintCost.Width = 100
        '
        'colAEmbCost
        '
        Me.colAEmbCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAEmbCost.AppearanceCell.Options.UseBackColor = True
        Me.colAEmbCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colAEmbCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAEmbCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAEmbCost.DisplayFormat.FormatString = "n2"
        Me.colAEmbCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAEmbCost.FieldName = "AEmbCost"
        Me.colAEmbCost.MinWidth = 27
        Me.colAEmbCost.Name = "colAEmbCost"
        Me.colAEmbCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AEmbCost", "{0:n2}")})
        Me.colAEmbCost.Visible = True
        Me.colAEmbCost.VisibleIndex = 17
        Me.colAEmbCost.Width = 100
        '
        'colAMiscCost
        '
        Me.colAMiscCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colAMiscCost.AppearanceCell.Options.UseBackColor = True
        Me.colAMiscCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colAMiscCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAMiscCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAMiscCost.DisplayFormat.FormatString = "n2"
        Me.colAMiscCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAMiscCost.FieldName = "AMiscCost"
        Me.colAMiscCost.MinWidth = 27
        Me.colAMiscCost.Name = "colAMiscCost"
        Me.colAMiscCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AMiscCost", "{0:n2}")})
        Me.colAMiscCost.Visible = True
        Me.colAMiscCost.VisibleIndex = 21
        Me.colAMiscCost.Width = 100
        '
        'colATrimCost
        '
        Me.colATrimCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colATrimCost.AppearanceCell.Options.UseBackColor = True
        Me.colATrimCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colATrimCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colATrimCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colATrimCost.DisplayFormat.FormatString = "n2"
        Me.colATrimCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colATrimCost.FieldName = "ATrimCost"
        Me.colATrimCost.MinWidth = 27
        Me.colATrimCost.Name = "colATrimCost"
        Me.colATrimCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ATrimCost", "{0:n2}")})
        Me.colATrimCost.Visible = True
        Me.colATrimCost.VisibleIndex = 19
        Me.colATrimCost.Width = 100
        '
        'colABCost
        '
        Me.colABCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colABCost.AppearanceCell.Options.UseBackColor = True
        Me.colABCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colABCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colABCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colABCost.DisplayFormat.FormatString = "n2"
        Me.colABCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colABCost.FieldName = "ABCost"
        Me.colABCost.MinWidth = 27
        Me.colABCost.Name = "colABCost"
        Me.colABCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ABCost", "{0:n2}")})
        Me.colABCost.Visible = True
        Me.colABCost.VisibleIndex = 24
        Me.colABCost.Width = 100
        '
        'colACost
        '
        Me.colACost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colACost.AppearanceCell.Options.UseBackColor = True
        Me.colACost.DisplayFormat.FormatString = "n2"
        Me.colACost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colACost.FieldName = "ACost"
        Me.colACost.MinWidth = 27
        Me.colACost.Name = "colACost"
        Me.colACost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ACost", "{0:n2}")})
        Me.colACost.Visible = True
        Me.colACost.VisibleIndex = 25
        Me.colACost.Width = 100
        '
        'colIsComplete
        '
        Me.colIsComplete.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsComplete.AppearanceCell.Options.UseBackColor = True
        Me.colIsComplete.FieldName = "IsComplete"
        Me.colIsComplete.MinWidth = 25
        Me.colIsComplete.Name = "colIsComplete"
        Me.colIsComplete.Visible = True
        Me.colIsComplete.VisibleIndex = 0
        Me.colIsComplete.Width = 94
        '
        'colBuyerName
        '
        Me.colBuyerName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colBuyerName.AppearanceCell.Options.UseBackColor = True
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.MinWidth = 25
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 2
        Me.colBuyerName.Width = 94
        '
        'BudgetVSActualTableAdapter
        '
        Me.BudgetVSActualTableAdapter.ClearBeforeFill = True
        '
        'colStyleName
        '
        Me.colStyleName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colStyleName.AppearanceCell.Options.UseBackColor = True
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.MinWidth = 25
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 3
        Me.colStyleName.Width = 94
        '
        'frmPostCosting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1779, 814)
        Me.Controls.Add(Me.GridControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPostCosting"
        Me.Text = "Post Costing/Budget"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BudgetVSActualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BudgetVsActualDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BudgetVsActualDataSet As BudgetVsActualDataSet
    Friend WithEvents BudgetVSActualBindingSource As BindingSource
    Friend WithEvents BudgetVSActualTableAdapter As BudgetVsActualDataSetTableAdapters.BudgetVSActualTableAdapter
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFirstExDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colABYarnCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAYarnCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colABKnittingCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAKnittingCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colABDyeingCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADyeingCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colABCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colABAOPCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colABPrintCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colABEmbCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colABMiscCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colABTrimCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAAOPCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPrintCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAEmbCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAMiscCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colATrimCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colABCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
End Class
