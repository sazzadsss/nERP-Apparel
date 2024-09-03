<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSizewiseProductionReport
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
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.SizewiseProductionReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizewiseProductionDataSet = New KSoft_Apparel.SizewiseProductionDataSet()
        Me.SizewiseProductionReportTableAdapter = New KSoft_Apparel.SizewiseProductionDataSetTableAdapters.SizewiseProductionReportTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCuttingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCuttingBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmbQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmbBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishingInputQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishingInputBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPolyQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPolyBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvgCuttingPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSewingOutputQuanty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSewingOutputQuantityBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSewingInput = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSewingInputBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSlNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizewiseProductionReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizewiseProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExportButton
        '
        Me.ExportButton.Location = New System.Drawing.Point(494, 9)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportButton.TabIndex = 13
        Me.ExportButton.Text = "Export"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.EditValue = ""
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(159, 11)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(253, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 12
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.EnforceConstraints = False
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Program_Style_Buyer :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(418, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'SizewiseProductionReportBindingSource
        '
        Me.SizewiseProductionReportBindingSource.DataMember = "SizewiseProductionReport"
        Me.SizewiseProductionReportBindingSource.DataSource = Me.SizewiseProductionDataSet
        '
        'SizewiseProductionDataSet
        '
        Me.SizewiseProductionDataSet.DataSetName = "SizewiseProductionDataSet"
        Me.SizewiseProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SizewiseProductionReportTableAdapter
        '
        Me.SizewiseProductionReportTableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.SizewiseProductionReportBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(2, 38)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1336, 597)
        Me.GridControl1.TabIndex = 14
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 60
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCuttingQuantity, Me.colCuttingBalance, Me.colPrintQuantity, Me.colPrintBalance, Me.colEmbQuantity, Me.colEmbBalance, Me.colInputQuantity, Me.colInputBalance, Me.colFinishingInputQuantity, Me.colFinishingInputBalance, Me.colPolyQuantity, Me.colPolyBalance, Me.colProgramNo, Me.colSize, Me.colColor, Me.colOrderQuantity, Me.colAvgCuttingPercentage, Me.colActualOrderQuantity, Me.colSewingOutputQuanty, Me.colSewingOutputQuantityBalance, Me.colSewingInput, Me.colSewingInputBalance, Me.colPO, Me.colShipmentBalance, Me.colShipmentQuantity, Me.colSlNo})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ActualOrderQuantity", Me.colActualOrderQuantity, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "CuttingBalance", Me.colCuttingBalance, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CuttingQuantity", Me.colCuttingQuantity, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "EmbBalance", Me.colEmbBalance, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EmbQuantity", Me.colEmbQuantity, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "FinishingInputBalance", Me.colFinishingInputBalance, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FinishingInputQuantity", Me.colFinishingInputQuantity, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "InputBalance", Me.colInputBalance, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InputQuantity", Me.colInputQuantity, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "PolyBalance", Me.colPolyBalance, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PolyQuantity", Me.colPolyQuantity, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "PrintBalance", Me.colPrintBalance, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrintQuantity", Me.colPrintQuantity, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SewingInput", Me.colSewingInput, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "SewingInputBalance", Me.colSewingInputBalance, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SewingOutputQuanty", Me.colSewingOutputQuanty, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "SewingOutputQuantityBalance", Me.colSewingOutputQuantityBalance, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShipmentQuantity", Me.colShipmentQuantity, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "ShipmentBalance", Me.colShipmentBalance, "{0:0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQuantity", Me.colOrderQuantity, "{0:0}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colColor, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSlNo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCuttingQuantity
        '
        Me.colCuttingQuantity.Caption = "Cutting Qty"
        Me.colCuttingQuantity.DisplayFormat.FormatString = "n0"
        Me.colCuttingQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCuttingQuantity.FieldName = "CuttingQuantity"
        Me.colCuttingQuantity.Name = "colCuttingQuantity"
        Me.colCuttingQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CuttingQuantity", "{0:0}")})
        Me.colCuttingQuantity.Visible = True
        Me.colCuttingQuantity.VisibleIndex = 6
        Me.colCuttingQuantity.Width = 45
        '
        'colCuttingBalance
        '
        Me.colCuttingBalance.Caption = "Cutting Qty Bal"
        Me.colCuttingBalance.DisplayFormat.FormatString = "n0"
        Me.colCuttingBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCuttingBalance.FieldName = "CuttingBalance"
        Me.colCuttingBalance.Name = "colCuttingBalance"
        Me.colCuttingBalance.Visible = True
        Me.colCuttingBalance.VisibleIndex = 7
        Me.colCuttingBalance.Width = 44
        '
        'colPrintQuantity
        '
        Me.colPrintQuantity.Caption = "Print Qty"
        Me.colPrintQuantity.DisplayFormat.FormatString = "n0"
        Me.colPrintQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrintQuantity.FieldName = "PrintQuantity"
        Me.colPrintQuantity.Name = "colPrintQuantity"
        Me.colPrintQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrintQuantity", "{0:0}")})
        Me.colPrintQuantity.Visible = True
        Me.colPrintQuantity.VisibleIndex = 8
        Me.colPrintQuantity.Width = 48
        '
        'colPrintBalance
        '
        Me.colPrintBalance.Caption = "Print Qty Bal"
        Me.colPrintBalance.DisplayFormat.FormatString = "n0"
        Me.colPrintBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrintBalance.FieldName = "PrintBalance"
        Me.colPrintBalance.Name = "colPrintBalance"
        Me.colPrintBalance.Visible = True
        Me.colPrintBalance.VisibleIndex = 9
        Me.colPrintBalance.Width = 45
        '
        'colEmbQuantity
        '
        Me.colEmbQuantity.Caption = "Emb Qty"
        Me.colEmbQuantity.DisplayFormat.FormatString = "n0"
        Me.colEmbQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEmbQuantity.FieldName = "EmbQuantity"
        Me.colEmbQuantity.Name = "colEmbQuantity"
        Me.colEmbQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EmbQuantity", "{0:0}")})
        Me.colEmbQuantity.Visible = True
        Me.colEmbQuantity.VisibleIndex = 10
        Me.colEmbQuantity.Width = 45
        '
        'colEmbBalance
        '
        Me.colEmbBalance.Caption = "Emb Qty Bal"
        Me.colEmbBalance.DisplayFormat.FormatString = "n0"
        Me.colEmbBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEmbBalance.FieldName = "EmbBalance"
        Me.colEmbBalance.Name = "colEmbBalance"
        Me.colEmbBalance.Visible = True
        Me.colEmbBalance.VisibleIndex = 11
        Me.colEmbBalance.Width = 37
        '
        'colInputQuantity
        '
        Me.colInputQuantity.Caption = "Cutting Input Qty"
        Me.colInputQuantity.DisplayFormat.FormatString = "n0"
        Me.colInputQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInputQuantity.FieldName = "InputQuantity"
        Me.colInputQuantity.Name = "colInputQuantity"
        Me.colInputQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InputQuantity", "{0:0}")})
        Me.colInputQuantity.Visible = True
        Me.colInputQuantity.VisibleIndex = 12
        Me.colInputQuantity.Width = 50
        '
        'colInputBalance
        '
        Me.colInputBalance.Caption = "Cutting Input Qty Bal"
        Me.colInputBalance.DisplayFormat.FormatString = "n0"
        Me.colInputBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInputBalance.FieldName = "InputBalance"
        Me.colInputBalance.Name = "colInputBalance"
        Me.colInputBalance.Visible = True
        Me.colInputBalance.VisibleIndex = 13
        Me.colInputBalance.Width = 50
        '
        'colFinishingInputQuantity
        '
        Me.colFinishingInputQuantity.Caption = "Finishing Input Qty"
        Me.colFinishingInputQuantity.DisplayFormat.FormatString = "n0"
        Me.colFinishingInputQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFinishingInputQuantity.FieldName = "FinishingInputQuantity"
        Me.colFinishingInputQuantity.Name = "colFinishingInputQuantity"
        Me.colFinishingInputQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FinishingInputQuantity", "{0:0}")})
        Me.colFinishingInputQuantity.Visible = True
        Me.colFinishingInputQuantity.VisibleIndex = 18
        Me.colFinishingInputQuantity.Width = 56
        '
        'colFinishingInputBalance
        '
        Me.colFinishingInputBalance.Caption = "Finishing Input Qty Bal"
        Me.colFinishingInputBalance.DisplayFormat.FormatString = "n0"
        Me.colFinishingInputBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFinishingInputBalance.FieldName = "FinishingInputBalance"
        Me.colFinishingInputBalance.Name = "colFinishingInputBalance"
        Me.colFinishingInputBalance.Visible = True
        Me.colFinishingInputBalance.VisibleIndex = 19
        Me.colFinishingInputBalance.Width = 49
        '
        'colPolyQuantity
        '
        Me.colPolyQuantity.Caption = "Finishing Hangtag Qty"
        Me.colPolyQuantity.DisplayFormat.FormatString = "n0"
        Me.colPolyQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPolyQuantity.FieldName = "PolyQuantity"
        Me.colPolyQuantity.Name = "colPolyQuantity"
        Me.colPolyQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PolyQuantity", "{0:0}")})
        Me.colPolyQuantity.Visible = True
        Me.colPolyQuantity.VisibleIndex = 20
        Me.colPolyQuantity.Width = 50
        '
        'colPolyBalance
        '
        Me.colPolyBalance.Caption = "Finishing Hangtag Qty Bal"
        Me.colPolyBalance.DisplayFormat.FormatString = "n0"
        Me.colPolyBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPolyBalance.FieldName = "PolyBalance"
        Me.colPolyBalance.Name = "colPolyBalance"
        Me.colPolyBalance.Visible = True
        Me.colPolyBalance.VisibleIndex = 21
        Me.colPolyBalance.Width = 50
        '
        'colProgramNo
        '
        Me.colProgramNo.Caption = "Program No"
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        Me.colProgramNo.Width = 69
        '
        'colSize
        '
        Me.colSize.Caption = "Size"
        Me.colSize.FieldName = "Size"
        Me.colSize.Name = "colSize"
        Me.colSize.Visible = True
        Me.colSize.VisibleIndex = 1
        Me.colSize.Width = 51
        '
        'colColor
        '
        Me.colColor.Caption = "Color"
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 2
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.Caption = "Order Qty with C%"
        Me.colOrderQuantity.DisplayFormat.FormatString = "n0"
        Me.colOrderQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQuantity", "{0:0}")})
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 5
        Me.colOrderQuantity.Width = 55
        '
        'colAvgCuttingPercentage
        '
        Me.colAvgCuttingPercentage.Caption = "Avg C%"
        Me.colAvgCuttingPercentage.DisplayFormat.FormatString = "0.0"
        Me.colAvgCuttingPercentage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAvgCuttingPercentage.FieldName = "AvgCuttingPercentage"
        Me.colAvgCuttingPercentage.Name = "colAvgCuttingPercentage"
        Me.colAvgCuttingPercentage.Visible = True
        Me.colAvgCuttingPercentage.VisibleIndex = 4
        Me.colAvgCuttingPercentage.Width = 28
        '
        'colActualOrderQuantity
        '
        Me.colActualOrderQuantity.Caption = "Order Qty"
        Me.colActualOrderQuantity.DisplayFormat.FormatString = "n0"
        Me.colActualOrderQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colActualOrderQuantity.FieldName = "ActualOrderQuantity"
        Me.colActualOrderQuantity.Name = "colActualOrderQuantity"
        Me.colActualOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ActualOrderQuantity", "{0:0}")})
        Me.colActualOrderQuantity.Visible = True
        Me.colActualOrderQuantity.VisibleIndex = 3
        Me.colActualOrderQuantity.Width = 61
        '
        'colSewingOutputQuanty
        '
        Me.colSewingOutputQuanty.Caption = "Sewing Output Qty"
        Me.colSewingOutputQuanty.DisplayFormat.FormatString = "n0"
        Me.colSewingOutputQuanty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSewingOutputQuanty.FieldName = "SewingOutputQuanty"
        Me.colSewingOutputQuanty.Name = "colSewingOutputQuanty"
        Me.colSewingOutputQuanty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SewingOutputQuanty", "{0:0}")})
        Me.colSewingOutputQuanty.Visible = True
        Me.colSewingOutputQuanty.VisibleIndex = 16
        Me.colSewingOutputQuanty.Width = 57
        '
        'colSewingOutputQuantityBalance
        '
        Me.colSewingOutputQuantityBalance.Caption = "Sewing Output Qty Bal"
        Me.colSewingOutputQuantityBalance.DisplayFormat.FormatString = "n0"
        Me.colSewingOutputQuantityBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSewingOutputQuantityBalance.FieldName = "SewingOutputQuantityBalance"
        Me.colSewingOutputQuantityBalance.Name = "colSewingOutputQuantityBalance"
        Me.colSewingOutputQuantityBalance.Visible = True
        Me.colSewingOutputQuantityBalance.VisibleIndex = 17
        Me.colSewingOutputQuantityBalance.Width = 50
        '
        'colSewingInput
        '
        Me.colSewingInput.Caption = "Sewing Input Qty"
        Me.colSewingInput.DisplayFormat.FormatString = "n0"
        Me.colSewingInput.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSewingInput.FieldName = "SewingInput"
        Me.colSewingInput.Name = "colSewingInput"
        Me.colSewingInput.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SewingInput", "{0:0}")})
        Me.colSewingInput.Visible = True
        Me.colSewingInput.VisibleIndex = 14
        Me.colSewingInput.Width = 60
        '
        'colSewingInputBalance
        '
        Me.colSewingInputBalance.Caption = "Sewing Input Qty Bal"
        Me.colSewingInputBalance.DisplayFormat.FormatString = "n0"
        Me.colSewingInputBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSewingInputBalance.FieldName = "SewingInputBalance"
        Me.colSewingInputBalance.Name = "colSewingInputBalance"
        Me.colSewingInputBalance.Visible = True
        Me.colSewingInputBalance.VisibleIndex = 15
        Me.colSewingInputBalance.Width = 61
        '
        'colPO
        '
        Me.colPO.Caption = "PO"
        Me.colPO.FieldName = "PO"
        Me.colPO.Name = "colPO"
        Me.colPO.Visible = True
        Me.colPO.VisibleIndex = 2
        Me.colPO.Width = 127
        '
        'colShipmentBalance
        '
        Me.colShipmentBalance.Caption = "Shipment Qty Bal"
        Me.colShipmentBalance.DisplayFormat.FormatString = "n0"
        Me.colShipmentBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colShipmentBalance.FieldName = "ShipmentBalance"
        Me.colShipmentBalance.Name = "colShipmentBalance"
        Me.colShipmentBalance.Visible = True
        Me.colShipmentBalance.VisibleIndex = 23
        Me.colShipmentBalance.Width = 52
        '
        'colShipmentQuantity
        '
        Me.colShipmentQuantity.Caption = "Shipment Qty"
        Me.colShipmentQuantity.DisplayFormat.FormatString = "n0"
        Me.colShipmentQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colShipmentQuantity.FieldName = "ShipmentQuantity"
        Me.colShipmentQuantity.Name = "colShipmentQuantity"
        Me.colShipmentQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShipmentQuantity", "{0:0}")})
        Me.colShipmentQuantity.Visible = True
        Me.colShipmentQuantity.VisibleIndex = 22
        Me.colShipmentQuantity.Width = 78
        '
        'colSlNo
        '
        Me.colSlNo.FieldName = "SlNo"
        Me.colSlNo.Name = "colSlNo"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmSizewiseProductionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 636)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmSizewiseProductionReport"
        Me.Text = "Sizewise Production Report"
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizewiseProductionReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizewiseProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExportButton As Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents SizewiseProductionReportBindingSource As BindingSource
    Friend WithEvents SizewiseProductionDataSet As SizewiseProductionDataSet
    Friend WithEvents SizewiseProductionReportTableAdapter As SizewiseProductionDataSetTableAdapters.SizewiseProductionReportTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCuttingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuttingBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmbQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmbBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishingInputQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishingInputBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPolyQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPolyBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents colAvgCuttingPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingOutputQuanty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingOutputQuantityBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingInput As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingInputBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSlNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
