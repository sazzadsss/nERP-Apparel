<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterOrderStatus
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.MasterOrderStatusGridControl = New DevExpress.XtraGrid.GridControl()
        Me.MasterOrderStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterOrderStatusDataSet = New KSoft_Apparel.MasterOrderStatusDataSet()
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colIsCuttingRunning = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colMerchandiser = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colBuyerCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colOrderReceiveDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMinEx = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMaxEx = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCon = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStyle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGarmentDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAOP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colEmbroidery = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrint = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colWash = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFabrication = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colOrderQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colFabricRequire = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastDayFabricReceived = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFabricReceived = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFabricReceiveBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFabricExcessReceive = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colLastDayCutting = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalCutting = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCuttingPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCuttingBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colExcessCutting = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastDayPrintSend = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalPrintSend = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastDayPrintReceive = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalPrintReceive = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrintReceiveBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrintSupplier = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastDayInput = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalInput = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colInputPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colInputBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStockInHand = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colLastDaySewing = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSewingQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSewingPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSewingBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPolyQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCartonQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colShipmentQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colShipmentCartonQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colLastDayEmbReceived = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalEmbReceived = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLastDayEmdSend = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTotalEmbSend = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.MasterOrderStatusTableAdapter = New KSoft_Apparel.MasterOrderStatusDataSetTableAdapters.MasterOrderStatusTableAdapter()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.AsignedForGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowByMerchandiserButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowByBuyerButton = New System.Windows.Forms.Button()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.AllButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.LoadingLabel = New System.Windows.Forms.Label()
        Me.RunningButton = New System.Windows.Forms.Button()
        Me.SaveLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.colProgramAndStyle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        CType(Me.MasterOrderStatusGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderStatusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignedForGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MasterOrderStatusGridControl
        '
        Me.MasterOrderStatusGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MasterOrderStatusGridControl.DataSource = Me.MasterOrderStatusBindingSource
        Me.MasterOrderStatusGridControl.Location = New System.Drawing.Point(2, 33)
        Me.MasterOrderStatusGridControl.MainView = Me.BandedGridView1
        Me.MasterOrderStatusGridControl.Name = "MasterOrderStatusGridControl"
        Me.MasterOrderStatusGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.MasterOrderStatusGridControl.Size = New System.Drawing.Size(1243, 609)
        Me.MasterOrderStatusGridControl.TabIndex = 1
        Me.MasterOrderStatusGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'MasterOrderStatusBindingSource
        '
        Me.MasterOrderStatusBindingSource.DataMember = "MasterOrderStatus"
        Me.MasterOrderStatusBindingSource.DataSource = Me.MasterOrderStatusDataSet
        '
        'MasterOrderStatusDataSet
        '
        Me.MasterOrderStatusDataSet.DataSetName = "MasterOrderStatusDataSet"
        Me.MasterOrderStatusDataSet.EnforceConstraints = False
        Me.MasterOrderStatusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2, Me.GridBand3, Me.GridBand4, Me.GridBand5, Me.GridBand6, Me.GridBand7})
        Me.BandedGridView1.ColumnPanelRowHeight = 40
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colProgramNo, Me.colBuyerCode, Me.colOrderReceiveDate, Me.colMinEx, Me.colMaxEx, Me.colPO, Me.colCon, Me.colStyle, Me.colGarmentDescription, Me.colFabrication, Me.colColor, Me.colOrderQty, Me.colFabricRequire, Me.colFabricReceived, Me.colFabricReceiveBalance, Me.colTotalCutting, Me.colCuttingPercentage, Me.colCuttingBalance, Me.colTotalPrintSend, Me.colTotalPrintReceive, Me.colPrintReceiveBalance, Me.colTotalInput, Me.colInputPercentage, Me.colInputBalance, Me.colMerchandiser, Me.colPolyQuantity, Me.colCartonQuantity, Me.colSewingBalance, Me.colSewingPercentage, Me.colSewingQuantity, Me.colShipmentCartonQuantity, Me.colShipmentQuantity, Me.colAOP, Me.colPrint, Me.colEmbroidery, Me.colWash, Me.colLastDayCutting, Me.colLastDayFabricReceived, Me.colLastDayPrintReceive, Me.colLastDaySewing, Me.colExcessCutting, Me.colFabricExcessReceive, Me.colLastDayInput, Me.colLastDayPrintSend, Me.colPrintSupplier, Me.colStockInHand, Me.colLastDayEmbReceived, Me.colLastDayEmdSend, Me.colTotalEmbReceived, Me.colTotalEmbSend, Me.colIsCuttingRunning, Me.colProgramAndStyle})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = True
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = True
        Me.BandedGridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.BandedGridView1.GridControl = Me.MasterOrderStatusGridControl
        Me.BandedGridView1.GroupCount = 1
        Me.BandedGridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQty", Me.colOrderQty, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FabricRequire", Me.colFabricRequire, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FabricReceived", Me.colFabricReceived, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCutting", Me.colTotalCutting, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrintSend", Me.colTotalPrintSend, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrintReceive", Me.colTotalPrintReceive, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalInput", Me.colTotalInput, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SewingQuantity", Me.colSewingQuantity, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PolyQuantity", Me.colPolyQuantity, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SewingQuantity", Me.colSewingQuantity, "")})
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.BandedGridView1.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.BandedGridView1.OptionsPrint.AutoWidth = False
        Me.BandedGridView1.OptionsPrint.PrintFilterInfo = True
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.BandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView1.OptionsView.ShowFooter = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        Me.BandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colProgramNo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Order Information"
        Me.GridBand1.Columns.Add(Me.colIsCuttingRunning)
        Me.GridBand1.Columns.Add(Me.colMerchandiser)
        Me.GridBand1.Columns.Add(Me.colProgramNo)
        Me.GridBand1.Columns.Add(Me.colBuyerCode)
        Me.GridBand1.Columns.Add(Me.colOrderReceiveDate)
        Me.GridBand1.Columns.Add(Me.colMinEx)
        Me.GridBand1.Columns.Add(Me.colMaxEx)
        Me.GridBand1.Columns.Add(Me.colPO)
        Me.GridBand1.Columns.Add(Me.colCon)
        Me.GridBand1.Columns.Add(Me.colStyle)
        Me.GridBand1.Columns.Add(Me.colGarmentDescription)
        Me.GridBand1.Columns.Add(Me.colAOP)
        Me.GridBand1.Columns.Add(Me.colEmbroidery)
        Me.GridBand1.Columns.Add(Me.colPrint)
        Me.GridBand1.Columns.Add(Me.colWash)
        Me.GridBand1.Columns.Add(Me.colFabrication)
        Me.GridBand1.Columns.Add(Me.colColor)
        Me.GridBand1.Columns.Add(Me.colOrderQty)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 1209
        '
        'colIsCuttingRunning
        '
        Me.colIsCuttingRunning.Caption = "Cutting WIP"
        Me.colIsCuttingRunning.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.colIsCuttingRunning.FieldName = "IsCuttingRunning"
        Me.colIsCuttingRunning.Name = "colIsCuttingRunning"
        Me.colIsCuttingRunning.Visible = True
        Me.colIsCuttingRunning.Width = 76
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'colMerchandiser
        '
        Me.colMerchandiser.AppearanceHeader.Options.UseTextOptions = True
        Me.colMerchandiser.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMerchandiser.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMerchandiser.FieldName = "Merchandiser"
        Me.colMerchandiser.Name = "colMerchandiser"
        Me.colMerchandiser.Visible = True
        Me.colMerchandiser.Width = 97
        '
        'colProgramNo
        '
        Me.colProgramNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colProgramNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProgramNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colProgramNo.Visible = True
        '
        'colBuyerCode
        '
        Me.colBuyerCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colBuyerCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBuyerCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBuyerCode.Caption = "Buyer"
        Me.colBuyerCode.FieldName = "BuyerCode"
        Me.colBuyerCode.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colBuyerCode.Name = "colBuyerCode"
        Me.colBuyerCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colBuyerCode.Visible = True
        Me.colBuyerCode.Width = 59
        '
        'colOrderReceiveDate
        '
        Me.colOrderReceiveDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderReceiveDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderReceiveDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderReceiveDate.Caption = "Received Date"
        Me.colOrderReceiveDate.FieldName = "OrderReceiveDate"
        Me.colOrderReceiveDate.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colOrderReceiveDate.Name = "colOrderReceiveDate"
        Me.colOrderReceiveDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colOrderReceiveDate.Visible = True
        '
        'colMinEx
        '
        Me.colMinEx.AppearanceHeader.Options.UseTextOptions = True
        Me.colMinEx.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMinEx.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMinEx.FieldName = "MinEx"
        Me.colMinEx.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colMinEx.Name = "colMinEx"
        Me.colMinEx.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colMinEx.Visible = True
        Me.colMinEx.Width = 65
        '
        'colMaxEx
        '
        Me.colMaxEx.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaxEx.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaxEx.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMaxEx.FieldName = "MaxEx"
        Me.colMaxEx.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colMaxEx.Name = "colMaxEx"
        Me.colMaxEx.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colMaxEx.Visible = True
        Me.colMaxEx.Width = 66
        '
        'colPO
        '
        Me.colPO.AppearanceHeader.Options.UseTextOptions = True
        Me.colPO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPO.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPO.FieldName = "PO"
        Me.colPO.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colPO.Name = "colPO"
        Me.colPO.OptionsColumn.ReadOnly = True
        Me.colPO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colPO.Visible = True
        Me.colPO.Width = 84
        '
        'colCon
        '
        Me.colCon.AppearanceHeader.Options.UseTextOptions = True
        Me.colCon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCon.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCon.FieldName = "Con"
        Me.colCon.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colCon.Name = "colCon"
        Me.colCon.OptionsColumn.ReadOnly = True
        Me.colCon.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCon.Visible = True
        Me.colCon.Width = 56
        '
        'colStyle
        '
        Me.colStyle.AppearanceHeader.Options.UseTextOptions = True
        Me.colStyle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStyle.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyle.FieldName = "Style"
        Me.colStyle.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colStyle.Name = "colStyle"
        Me.colStyle.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colStyle.Visible = True
        Me.colStyle.Width = 103
        '
        'colGarmentDescription
        '
        Me.colGarmentDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colGarmentDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGarmentDescription.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGarmentDescription.Caption = "Item"
        Me.colGarmentDescription.FieldName = "GarmentDescription"
        Me.colGarmentDescription.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colGarmentDescription.Name = "colGarmentDescription"
        Me.colGarmentDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colGarmentDescription.Visible = True
        '
        'colAOP
        '
        Me.colAOP.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colAOP.AppearanceCell.Options.UseBackColor = True
        Me.colAOP.AppearanceCell.Options.UseTextOptions = True
        Me.colAOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAOP.AppearanceHeader.Options.UseTextOptions = True
        Me.colAOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAOP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAOP.FieldName = "AOP"
        Me.colAOP.Name = "colAOP"
        Me.colAOP.Visible = True
        Me.colAOP.Width = 33
        '
        'colEmbroidery
        '
        Me.colEmbroidery.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colEmbroidery.AppearanceCell.Options.UseBackColor = True
        Me.colEmbroidery.AppearanceCell.Options.UseTextOptions = True
        Me.colEmbroidery.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmbroidery.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmbroidery.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmbroidery.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEmbroidery.Caption = "EMB"
        Me.colEmbroidery.FieldName = "EMB"
        Me.colEmbroidery.Name = "colEmbroidery"
        Me.colEmbroidery.Visible = True
        Me.colEmbroidery.Width = 37
        '
        'colPrint
        '
        Me.colPrint.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colPrint.AppearanceCell.Options.UseBackColor = True
        Me.colPrint.AppearanceCell.Options.UseTextOptions = True
        Me.colPrint.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrint.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrint.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrint.FieldName = "Print"
        Me.colPrint.Name = "colPrint"
        Me.colPrint.Visible = True
        Me.colPrint.Width = 37
        '
        'colWash
        '
        Me.colWash.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colWash.AppearanceCell.Options.UseBackColor = True
        Me.colWash.AppearanceCell.Options.UseTextOptions = True
        Me.colWash.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWash.AppearanceHeader.Options.UseTextOptions = True
        Me.colWash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWash.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWash.FieldName = "Wash"
        Me.colWash.Name = "colWash"
        Me.colWash.Visible = True
        Me.colWash.Width = 39
        '
        'colFabrication
        '
        Me.colFabrication.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabrication.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabrication.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabrication.FieldName = "Fabrication"
        Me.colFabrication.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colFabrication.Name = "colFabrication"
        Me.colFabrication.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFabrication.Visible = True
        Me.colFabrication.Width = 82
        '
        'colColor
        '
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colColor.FieldName = "Color"
        Me.colColor.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colColor.Name = "colColor"
        Me.colColor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colColor.Visible = True
        '
        'colOrderQty
        '
        Me.colOrderQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderQty.FieldName = "OrderQty"
        Me.colOrderQty.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colOrderQty.Name = "colOrderQty"
        Me.colOrderQty.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colOrderQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colOrderQty.Visible = True
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "Fabric"
        Me.gridBand2.Columns.Add(Me.colFabricRequire)
        Me.gridBand2.Columns.Add(Me.colLastDayFabricReceived)
        Me.gridBand2.Columns.Add(Me.colFabricReceived)
        Me.gridBand2.Columns.Add(Me.colFabricReceiveBalance)
        Me.gridBand2.Columns.Add(Me.colFabricExcessReceive)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 1
        Me.gridBand2.Width = 346
        '
        'colFabricRequire
        '
        Me.colFabricRequire.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFabricRequire.AppearanceCell.Options.UseBackColor = True
        Me.colFabricRequire.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricRequire.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricRequire.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricRequire.FieldName = "FabricRequire"
        Me.colFabricRequire.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colFabricRequire.Name = "colFabricRequire"
        Me.colFabricRequire.OptionsColumn.ReadOnly = True
        Me.colFabricRequire.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFabricRequire.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFabricRequire.Visible = True
        Me.colFabricRequire.Width = 52
        '
        'colLastDayFabricReceived
        '
        Me.colLastDayFabricReceived.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastDayFabricReceived.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastDayFabricReceived.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastDayFabricReceived.Caption = "Today Fabric Received"
        Me.colLastDayFabricReceived.FieldName = "LastDayFabricReceived"
        Me.colLastDayFabricReceived.Name = "colLastDayFabricReceived"
        Me.colLastDayFabricReceived.Visible = True
        '
        'colFabricReceived
        '
        Me.colFabricReceived.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFabricReceived.AppearanceCell.Options.UseBackColor = True
        Me.colFabricReceived.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricReceived.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricReceived.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricReceived.FieldName = "FabricReceived"
        Me.colFabricReceived.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colFabricReceived.Name = "colFabricReceived"
        Me.colFabricReceived.OptionsColumn.ReadOnly = True
        Me.colFabricReceived.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFabricReceived.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFabricReceived.Visible = True
        Me.colFabricReceived.Width = 65
        '
        'colFabricReceiveBalance
        '
        Me.colFabricReceiveBalance.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFabricReceiveBalance.AppearanceCell.Options.UseBackColor = True
        Me.colFabricReceiveBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricReceiveBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricReceiveBalance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricReceiveBalance.FieldName = "FabricReceiveBalance"
        Me.colFabricReceiveBalance.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colFabricReceiveBalance.Name = "colFabricReceiveBalance"
        Me.colFabricReceiveBalance.OptionsColumn.ReadOnly = True
        Me.colFabricReceiveBalance.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFabricReceiveBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFabricReceiveBalance.Visible = True
        Me.colFabricReceiveBalance.Width = 79
        '
        'colFabricExcessReceive
        '
        Me.colFabricExcessReceive.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricExcessReceive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricExcessReceive.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricExcessReceive.FieldName = "FabricExcessReceive"
        Me.colFabricExcessReceive.Name = "colFabricExcessReceive"
        Me.colFabricExcessReceive.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFabricExcessReceive.Visible = True
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "Cutting"
        Me.GridBand3.Columns.Add(Me.colLastDayCutting)
        Me.GridBand3.Columns.Add(Me.colTotalCutting)
        Me.GridBand3.Columns.Add(Me.colCuttingPercentage)
        Me.GridBand3.Columns.Add(Me.colCuttingBalance)
        Me.GridBand3.Columns.Add(Me.colExcessCutting)
        Me.GridBand3.Columns.Add(Me.colLastDayPrintSend)
        Me.GridBand3.Columns.Add(Me.colTotalPrintSend)
        Me.GridBand3.Columns.Add(Me.colLastDayPrintReceive)
        Me.GridBand3.Columns.Add(Me.colTotalPrintReceive)
        Me.GridBand3.Columns.Add(Me.colPrintReceiveBalance)
        Me.GridBand3.Columns.Add(Me.colPrintSupplier)
        Me.GridBand3.Columns.Add(Me.colLastDayInput)
        Me.GridBand3.Columns.Add(Me.colTotalInput)
        Me.GridBand3.Columns.Add(Me.colInputPercentage)
        Me.GridBand3.Columns.Add(Me.colInputBalance)
        Me.GridBand3.Columns.Add(Me.colStockInHand)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.VisibleIndex = 2
        Me.GridBand3.Width = 1213
        '
        'colLastDayCutting
        '
        Me.colLastDayCutting.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastDayCutting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastDayCutting.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastDayCutting.Caption = "Today Cutting"
        Me.colLastDayCutting.FieldName = "LastDayCutting"
        Me.colLastDayCutting.Name = "colLastDayCutting"
        Me.colLastDayCutting.Visible = True
        '
        'colTotalCutting
        '
        Me.colTotalCutting.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colTotalCutting.AppearanceCell.Options.UseBackColor = True
        Me.colTotalCutting.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalCutting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalCutting.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalCutting.FieldName = "TotalCutting"
        Me.colTotalCutting.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colTotalCutting.Name = "colTotalCutting"
        Me.colTotalCutting.OptionsColumn.ReadOnly = True
        Me.colTotalCutting.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTotalCutting.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTotalCutting.Visible = True
        Me.colTotalCutting.Width = 59
        '
        'colCuttingPercentage
        '
        Me.colCuttingPercentage.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCuttingPercentage.AppearanceCell.Options.UseBackColor = True
        Me.colCuttingPercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colCuttingPercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCuttingPercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCuttingPercentage.DisplayFormat.FormatString = "n0"
        Me.colCuttingPercentage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colCuttingPercentage.FieldName = "CuttingPercentage"
        Me.colCuttingPercentage.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colCuttingPercentage.Name = "colCuttingPercentage"
        Me.colCuttingPercentage.OptionsColumn.ReadOnly = True
        Me.colCuttingPercentage.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCuttingPercentage.Visible = True
        '
        'colCuttingBalance
        '
        Me.colCuttingBalance.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCuttingBalance.AppearanceCell.Options.UseBackColor = True
        Me.colCuttingBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colCuttingBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCuttingBalance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCuttingBalance.FieldName = "CuttingBalance"
        Me.colCuttingBalance.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colCuttingBalance.Name = "colCuttingBalance"
        Me.colCuttingBalance.OptionsColumn.ReadOnly = True
        Me.colCuttingBalance.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCuttingBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colCuttingBalance.Visible = True
        '
        'colExcessCutting
        '
        Me.colExcessCutting.AppearanceHeader.Options.UseTextOptions = True
        Me.colExcessCutting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExcessCutting.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExcessCutting.FieldName = "ExcessCutting"
        Me.colExcessCutting.Name = "colExcessCutting"
        Me.colExcessCutting.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colExcessCutting.Visible = True
        Me.colExcessCutting.Width = 93
        '
        'colLastDayPrintSend
        '
        Me.colLastDayPrintSend.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastDayPrintSend.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastDayPrintSend.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastDayPrintSend.FieldName = "LastDayPrintSend"
        Me.colLastDayPrintSend.Name = "colLastDayPrintSend"
        Me.colLastDayPrintSend.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colLastDayPrintSend.Visible = True
        Me.colLastDayPrintSend.Width = 65
        '
        'colTotalPrintSend
        '
        Me.colTotalPrintSend.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTotalPrintSend.AppearanceCell.Options.UseBackColor = True
        Me.colTotalPrintSend.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalPrintSend.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalPrintSend.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalPrintSend.FieldName = "TotalPrintSend"
        Me.colTotalPrintSend.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colTotalPrintSend.Name = "colTotalPrintSend"
        Me.colTotalPrintSend.OptionsColumn.ReadOnly = True
        Me.colTotalPrintSend.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTotalPrintSend.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTotalPrintSend.Visible = True
        Me.colTotalPrintSend.Width = 71
        '
        'colLastDayPrintReceive
        '
        Me.colLastDayPrintReceive.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastDayPrintReceive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastDayPrintReceive.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastDayPrintReceive.Caption = "Today Print Received"
        Me.colLastDayPrintReceive.FieldName = "LastDayPrintReceive"
        Me.colLastDayPrintReceive.Name = "colLastDayPrintReceive"
        Me.colLastDayPrintReceive.Visible = True
        Me.colLastDayPrintReceive.Width = 99
        '
        'colTotalPrintReceive
        '
        Me.colTotalPrintReceive.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTotalPrintReceive.AppearanceCell.Options.UseBackColor = True
        Me.colTotalPrintReceive.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalPrintReceive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalPrintReceive.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalPrintReceive.FieldName = "TotalPrintReceive"
        Me.colTotalPrintReceive.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colTotalPrintReceive.Name = "colTotalPrintReceive"
        Me.colTotalPrintReceive.OptionsColumn.ReadOnly = True
        Me.colTotalPrintReceive.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTotalPrintReceive.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTotalPrintReceive.Visible = True
        '
        'colPrintReceiveBalance
        '
        Me.colPrintReceiveBalance.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colPrintReceiveBalance.AppearanceCell.Options.UseBackColor = True
        Me.colPrintReceiveBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrintReceiveBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrintReceiveBalance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrintReceiveBalance.FieldName = "PrintReceiveBalance"
        Me.colPrintReceiveBalance.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colPrintReceiveBalance.Name = "colPrintReceiveBalance"
        Me.colPrintReceiveBalance.OptionsColumn.ReadOnly = True
        Me.colPrintReceiveBalance.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colPrintReceiveBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPrintReceiveBalance.Visible = True
        '
        'colPrintSupplier
        '
        Me.colPrintSupplier.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrintSupplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrintSupplier.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrintSupplier.FieldName = "PrintSupplier"
        Me.colPrintSupplier.Name = "colPrintSupplier"
        Me.colPrintSupplier.Visible = True
        '
        'colLastDayInput
        '
        Me.colLastDayInput.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastDayInput.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastDayInput.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastDayInput.FieldName = "LastDayInput"
        Me.colLastDayInput.Name = "colLastDayInput"
        Me.colLastDayInput.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colLastDayInput.Visible = True
        Me.colLastDayInput.Width = 76
        '
        'colTotalInput
        '
        Me.colTotalInput.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colTotalInput.AppearanceCell.Options.UseBackColor = True
        Me.colTotalInput.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalInput.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalInput.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalInput.FieldName = "TotalInput"
        Me.colTotalInput.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colTotalInput.Name = "colTotalInput"
        Me.colTotalInput.OptionsColumn.ReadOnly = True
        Me.colTotalInput.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colTotalInput.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTotalInput.Visible = True
        '
        'colInputPercentage
        '
        Me.colInputPercentage.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colInputPercentage.AppearanceCell.Options.UseBackColor = True
        Me.colInputPercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colInputPercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInputPercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInputPercentage.DisplayFormat.FormatString = "n0"
        Me.colInputPercentage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colInputPercentage.FieldName = "InputPercentage"
        Me.colInputPercentage.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colInputPercentage.Name = "colInputPercentage"
        Me.colInputPercentage.OptionsColumn.ReadOnly = True
        Me.colInputPercentage.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colInputPercentage.Visible = True
        '
        'colInputBalance
        '
        Me.colInputBalance.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colInputBalance.AppearanceCell.Options.UseBackColor = True
        Me.colInputBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colInputBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colInputBalance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colInputBalance.FieldName = "InputBalance"
        Me.colInputBalance.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colInputBalance.Name = "colInputBalance"
        Me.colInputBalance.OptionsColumn.ReadOnly = True
        Me.colInputBalance.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colInputBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colInputBalance.Visible = True
        '
        'colStockInHand
        '
        Me.colStockInHand.FieldName = "StockInHand"
        Me.colStockInHand.Name = "colStockInHand"
        Me.colStockInHand.Visible = True
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "Sewing"
        Me.GridBand4.Columns.Add(Me.colLastDaySewing)
        Me.GridBand4.Columns.Add(Me.colSewingQuantity)
        Me.GridBand4.Columns.Add(Me.colSewingPercentage)
        Me.GridBand4.Columns.Add(Me.colSewingBalance)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.VisibleIndex = 3
        Me.GridBand4.Width = 256
        '
        'colLastDaySewing
        '
        Me.colLastDaySewing.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastDaySewing.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastDaySewing.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastDaySewing.Caption = "Today Sewing"
        Me.colLastDaySewing.FieldName = "LastDaySewing"
        Me.colLastDaySewing.Name = "colLastDaySewing"
        Me.colLastDaySewing.Visible = True
        Me.colLastDaySewing.Width = 51
        '
        'colSewingQuantity
        '
        Me.colSewingQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSewingQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colSewingQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colSewingQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSewingQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSewingQuantity.FieldName = "SewingQuantity"
        Me.colSewingQuantity.Name = "colSewingQuantity"
        Me.colSewingQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colSewingQuantity.Visible = True
        Me.colSewingQuantity.Width = 61
        '
        'colSewingPercentage
        '
        Me.colSewingPercentage.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSewingPercentage.AppearanceCell.Options.UseBackColor = True
        Me.colSewingPercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colSewingPercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSewingPercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSewingPercentage.FieldName = "SewingPercentage"
        Me.colSewingPercentage.Name = "colSewingPercentage"
        Me.colSewingPercentage.Visible = True
        Me.colSewingPercentage.Width = 69
        '
        'colSewingBalance
        '
        Me.colSewingBalance.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSewingBalance.AppearanceCell.Options.UseBackColor = True
        Me.colSewingBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colSewingBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSewingBalance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSewingBalance.FieldName = "SewingBalance"
        Me.colSewingBalance.Name = "colSewingBalance"
        Me.colSewingBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colSewingBalance.Visible = True
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "Finishing"
        Me.GridBand5.Columns.Add(Me.colPolyQuantity)
        Me.GridBand5.Columns.Add(Me.colCartonQuantity)
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.VisibleIndex = 4
        Me.GridBand5.Width = 150
        '
        'colPolyQuantity
        '
        Me.colPolyQuantity.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.colPolyQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colPolyQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colPolyQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPolyQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPolyQuantity.FieldName = "PolyQuantity"
        Me.colPolyQuantity.Name = "colPolyQuantity"
        Me.colPolyQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPolyQuantity.Visible = True
        '
        'colCartonQuantity
        '
        Me.colCartonQuantity.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.colCartonQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colCartonQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colCartonQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCartonQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCartonQuantity.FieldName = "CartonQuantity"
        Me.colCartonQuantity.Name = "colCartonQuantity"
        Me.colCartonQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colCartonQuantity.Visible = True
        '
        'GridBand6
        '
        Me.GridBand6.Caption = "Shipment"
        Me.GridBand6.Columns.Add(Me.colShipmentQuantity)
        Me.GridBand6.Columns.Add(Me.colShipmentCartonQuantity)
        Me.GridBand6.Name = "GridBand6"
        Me.GridBand6.VisibleIndex = 5
        Me.GridBand6.Width = 150
        '
        'colShipmentQuantity
        '
        Me.colShipmentQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colShipmentQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colShipmentQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colShipmentQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colShipmentQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colShipmentQuantity.FieldName = "ShipmentQuantity"
        Me.colShipmentQuantity.Name = "colShipmentQuantity"
        Me.colShipmentQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colShipmentQuantity.Visible = True
        '
        'colShipmentCartonQuantity
        '
        Me.colShipmentCartonQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colShipmentCartonQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colShipmentCartonQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colShipmentCartonQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colShipmentCartonQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colShipmentCartonQuantity.FieldName = "ShipmentCartonQuantity"
        Me.colShipmentCartonQuantity.Name = "colShipmentCartonQuantity"
        Me.colShipmentCartonQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colShipmentCartonQuantity.Visible = True
        '
        'GridBand7
        '
        Me.GridBand7.Caption = "Embroidery"
        Me.GridBand7.Columns.Add(Me.colLastDayEmbReceived)
        Me.GridBand7.Columns.Add(Me.colTotalEmbReceived)
        Me.GridBand7.Columns.Add(Me.colLastDayEmdSend)
        Me.GridBand7.Columns.Add(Me.colTotalEmbSend)
        Me.GridBand7.Name = "GridBand7"
        Me.GridBand7.VisibleIndex = 6
        Me.GridBand7.Width = 320
        '
        'colLastDayEmbReceived
        '
        Me.colLastDayEmbReceived.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastDayEmbReceived.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastDayEmbReceived.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastDayEmbReceived.FieldName = "LastDayEmbReceived"
        Me.colLastDayEmbReceived.Name = "colLastDayEmbReceived"
        Me.colLastDayEmbReceived.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colLastDayEmbReceived.Visible = True
        Me.colLastDayEmbReceived.Width = 82
        '
        'colTotalEmbReceived
        '
        Me.colTotalEmbReceived.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalEmbReceived.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalEmbReceived.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalEmbReceived.FieldName = "TotalEmbReceived"
        Me.colTotalEmbReceived.Name = "colTotalEmbReceived"
        Me.colTotalEmbReceived.Visible = True
        Me.colTotalEmbReceived.Width = 78
        '
        'colLastDayEmdSend
        '
        Me.colLastDayEmdSend.AppearanceHeader.Options.UseTextOptions = True
        Me.colLastDayEmdSend.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLastDayEmdSend.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLastDayEmdSend.FieldName = "LastDayEmdSend"
        Me.colLastDayEmdSend.Name = "colLastDayEmdSend"
        Me.colLastDayEmdSend.Visible = True
        Me.colLastDayEmdSend.Width = 83
        '
        'colTotalEmbSend
        '
        Me.colTotalEmbSend.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalEmbSend.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalEmbSend.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalEmbSend.FieldName = "TotalEmbSend"
        Me.colTotalEmbSend.Name = "colTotalEmbSend"
        Me.colTotalEmbSend.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTotalEmbSend.Visible = True
        Me.colTotalEmbSend.Width = 77
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'MasterOrderStatusTableAdapter
        '
        Me.MasterOrderStatusTableAdapter.ClearBeforeFill = True
        '
        'ExportButton
        '
        Me.ExportButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExportButton.Location = New System.Drawing.Point(1156, 4)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(76, 23)
        Me.ExportButton.TabIndex = 2
        Me.ExportButton.Text = "Mail Me"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'AsignedForGridLookUpEdit
        '
        Me.AsignedForGridLookUpEdit.EditValue = ""
        Me.AsignedForGridLookUpEdit.Location = New System.Drawing.Point(113, 6)
        Me.AsignedForGridLookUpEdit.Name = "AsignedForGridLookUpEdit"
        Me.AsignedForGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AsignedForGridLookUpEdit.Properties.DataSource = Me.UserLookupBindingSource
        Me.AsignedForGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.AsignedForGridLookUpEdit.Properties.ImmediatePopup = True
        Me.AsignedForGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AsignedForGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AsignedForGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.AsignedForGridLookUpEdit.Properties.View = Me.GridView3
        Me.AsignedForGridLookUpEdit.Size = New System.Drawing.Size(105, 20)
        Me.AsignedForGridLookUpEdit.TabIndex = 55
        '
        'UserLookupBindingSource
        '
        Me.UserLookupBindingSource.DataMember = "UserLookup"
        Me.UserLookupBindingSource.DataSource = Me.UserLookupDataSet
        '
        'UserLookupDataSet
        '
        Me.UserLookupDataSet.DataSetName = "UserLookupDataSet"
        Me.UserLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME2, Me.colDepartment})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME2
        '
        Me.colUSER_NAME2.Caption = "User"
        Me.colUSER_NAME2.FieldName = "USER_NAME"
        Me.colUSER_NAME2.Name = "colUSER_NAME2"
        Me.colUSER_NAME2.Visible = True
        Me.colUSER_NAME2.VisibleIndex = 0
        '
        'colDepartment
        '
        Me.colDepartment.FieldName = "Department"
        Me.colDepartment.Name = "colDepartment"
        Me.colDepartment.Visible = True
        Me.colDepartment.VisibleIndex = 1
        '
        'ShowByMerchandiserButton
        '
        Me.ShowByMerchandiserButton.Location = New System.Drawing.Point(222, 6)
        Me.ShowByMerchandiserButton.Name = "ShowByMerchandiserButton"
        Me.ShowByMerchandiserButton.Size = New System.Drawing.Size(59, 22)
        Me.ShowByMerchandiserButton.TabIndex = 54
        Me.ShowByMerchandiserButton.Text = "Show"
        Me.ShowByMerchandiserButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "By Merchandiser"
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'BuyerComboBox
        '
        Me.BuyerComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerComboBox.DisplayMember = "BuyerCode"
        Me.BuyerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BuyerComboBox.FormattingEnabled = True
        Me.BuyerComboBox.Location = New System.Drawing.Point(362, 6)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(129, 21)
        Me.BuyerComboBox.TabIndex = 57
        Me.BuyerComboBox.ValueMember = "BuyerId"
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "By Buyer"
        '
        'ShowByBuyerButton
        '
        Me.ShowByBuyerButton.Location = New System.Drawing.Point(497, 6)
        Me.ShowByBuyerButton.Name = "ShowByBuyerButton"
        Me.ShowByBuyerButton.Size = New System.Drawing.Size(58, 22)
        Me.ShowByBuyerButton.TabIndex = 54
        Me.ShowByBuyerButton.Text = "Show"
        Me.ShowByBuyerButton.UseVisualStyleBackColor = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'AllButton
        '
        Me.AllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllButton.Location = New System.Drawing.Point(1083, 4)
        Me.AllButton.Name = "AllButton"
        Me.AllButton.Size = New System.Drawing.Size(67, 22)
        Me.AllButton.TabIndex = 59
        Me.AllButton.Text = "Show All"
        Me.AllButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(575, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Program No :: Style No"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(696, 6)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(164, 20)
        Me.SearchTextBox.TabIndex = 61
        '
        'LoadingLabel
        '
        Me.LoadingLabel.AutoSize = True
        Me.LoadingLabel.Location = New System.Drawing.Point(866, 11)
        Me.LoadingLabel.Name = "LoadingLabel"
        Me.LoadingLabel.Size = New System.Drawing.Size(16, 13)
        Me.LoadingLabel.TabIndex = 62
        Me.LoadingLabel.Text = "..."
        '
        'RunningButton
        '
        Me.RunningButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RunningButton.Location = New System.Drawing.Point(1002, 4)
        Me.RunningButton.Name = "RunningButton"
        Me.RunningButton.Size = New System.Drawing.Size(75, 23)
        Me.RunningButton.TabIndex = 63
        Me.RunningButton.Text = "Cutting WIP"
        Me.RunningButton.UseVisualStyleBackColor = True
        '
        'SaveLinkLabel
        '
        Me.SaveLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaveLinkLabel.AutoSize = True
        Me.SaveLinkLabel.Location = New System.Drawing.Point(12, 647)
        Me.SaveLinkLabel.Name = "SaveLinkLabel"
        Me.SaveLinkLabel.Size = New System.Drawing.Size(32, 13)
        Me.SaveLinkLabel.TabIndex = 64
        Me.SaveLinkLabel.TabStop = True
        Me.SaveLinkLabel.Text = "Save"
        '
        'colProgramAndStyle
        '
        Me.colProgramAndStyle.FieldName = "ProgramAndStyle"
        Me.colProgramAndStyle.Name = "colProgramAndStyle"
        Me.colProgramAndStyle.Visible = True
        '
        'frmMasterOrderStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 665)
        Me.Controls.Add(Me.SaveLinkLabel)
        Me.Controls.Add(Me.RunningButton)
        Me.Controls.Add(Me.LoadingLabel)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AllButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BuyerComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AsignedForGridLookUpEdit)
        Me.Controls.Add(Me.ShowByBuyerButton)
        Me.Controls.Add(Me.ShowByMerchandiserButton)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.MasterOrderStatusGridControl)
        Me.Name = "frmMasterOrderStatus"
        Me.Text = "Master Order Status"
        CType(Me.MasterOrderStatusGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderStatusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignedForGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MasterOrderStatusGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterOrderStatusDataSet As KSoft_Apparel.MasterOrderStatusDataSet
    Friend WithEvents MasterOrderStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterOrderStatusTableAdapter As KSoft_Apparel.MasterOrderStatusDataSetTableAdapters.MasterOrderStatusTableAdapter
    Friend WithEvents ExportButton As System.Windows.Forms.Button
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colOrderReceiveDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMinEx As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMaxEx As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCon As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStyle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGarmentDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabrication As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colOrderQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricRequire As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricReceived As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricReceiveBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalCutting As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCuttingPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCuttingBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalPrintSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalPrintReceive As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrintReceiveBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalInput As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInputPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInputBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents AsignedForGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUSER_NAME2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowByMerchandiserButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserLookupDataSet As KSoft_Apparel.UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserLookupTableAdapter As KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents BuyerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowByBuyerButton As System.Windows.Forms.Button
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents AllButton As System.Windows.Forms.Button
    Friend WithEvents colMerchandiser As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPolyQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCartonQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSewingBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSewingPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSewingQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colShipmentCartonQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colShipmentQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAOP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEmbroidery As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrint As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWash As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastDayFabricReceived As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastDayCutting As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastDayPrintReceive As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastDaySewing As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colFabricExcessReceive As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExcessCutting As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastDayPrintSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrintSupplier As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastDayInput As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LoadingLabel As System.Windows.Forms.Label
    Friend WithEvents RunningButton As System.Windows.Forms.Button
    Friend WithEvents SaveLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents colStockInHand As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastDayEmbReceived As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLastDayEmdSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalEmbReceived As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTotalEmbSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colIsCuttingRunning As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colProgramAndStyle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
