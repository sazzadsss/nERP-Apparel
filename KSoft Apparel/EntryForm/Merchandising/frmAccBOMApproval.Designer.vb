<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccBOMApproval
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ShowAllButton = New System.Windows.Forms.Button()
        Me.ShowApprovedButton = New System.Windows.Forms.Button()
        Me.PendingButton = New System.Windows.Forms.Button()
        Me.AccBOMApprovalGridControl = New DevExpress.XtraGrid.GridControl()
        Me.AccBOMApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccBOMApprovalDataSet = New KSoft_Apparel.AccBOMApprovalDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBookingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesBookingId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SelectSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ShowDetailsButton = New System.Windows.Forms.Button()
        Me.AccessoresBookingDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.AccessoresBookingDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesBookingNewDataSet = New KSoft_Apparel.AccessoriesBookingNewDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsumption = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsumptionUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBookingUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBookingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Apparel.ItemListDataSet()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colConsumptionForPcs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWastagePercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSLNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSizeId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataSet = New KSoft_Apparel.SizeDataSet()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinationId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DestinationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DestinationDataSet = New KSoft_Apparel.DestinationDataSet()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestinationId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinationCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinationName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPackType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsApproved1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccessoriesId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemStyle2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ApprovedButton = New System.Windows.Forms.Button()
        Me.AccBOMApprovalTableAdapter = New KSoft_Apparel.AccBOMApprovalDataSetTableAdapters.AccBOMApprovalTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.AccBOMApprovalDataSetTableAdapters.TableAdapterManager()
        Me.AccessoresBookingDetailsTableAdapter = New KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoresBookingDetailsTableAdapter()
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListDataSetTableAdapters.ItemListTableAdapter()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter()
        Me.SizeLookupTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeLookupTableAdapter()
        Me.DestinationTableAdapter = New KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AccBOMApprovalGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMApprovalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoresBookingDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoresBookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesBookingNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShowAllButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShowApprovedButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PendingButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccBOMApprovalGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SelectSimpleButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ShowDetailsButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AccessoresBookingDetailsGridControl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ApprovedButton)
        Me.SplitContainer1.Size = New System.Drawing.Size(1289, 642)
        Me.SplitContainer1.SplitterDistance = 271
        Me.SplitContainer1.TabIndex = 0
        '
        'ShowAllButton
        '
        Me.ShowAllButton.Location = New System.Drawing.Point(214, 9)
        Me.ShowAllButton.Name = "ShowAllButton"
        Me.ShowAllButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowAllButton.TabIndex = 2
        Me.ShowAllButton.Text = "Show All"
        Me.ShowAllButton.UseVisualStyleBackColor = True
        '
        'ShowApprovedButton
        '
        Me.ShowApprovedButton.Location = New System.Drawing.Point(113, 9)
        Me.ShowApprovedButton.Name = "ShowApprovedButton"
        Me.ShowApprovedButton.Size = New System.Drawing.Size(95, 23)
        Me.ShowApprovedButton.TabIndex = 1
        Me.ShowApprovedButton.Text = "Show Approved"
        Me.ShowApprovedButton.UseVisualStyleBackColor = True
        '
        'PendingButton
        '
        Me.PendingButton.Location = New System.Drawing.Point(12, 9)
        Me.PendingButton.Name = "PendingButton"
        Me.PendingButton.Size = New System.Drawing.Size(95, 23)
        Me.PendingButton.TabIndex = 1
        Me.PendingButton.Text = "Show Pending"
        Me.PendingButton.UseVisualStyleBackColor = True
        '
        'AccBOMApprovalGridControl
        '
        Me.AccBOMApprovalGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccBOMApprovalGridControl.DataSource = Me.AccBOMApprovalBindingSource
        Me.AccBOMApprovalGridControl.Location = New System.Drawing.Point(0, 38)
        Me.AccBOMApprovalGridControl.MainView = Me.GridView1
        Me.AccBOMApprovalGridControl.Name = "AccBOMApprovalGridControl"
        Me.AccBOMApprovalGridControl.Size = New System.Drawing.Size(1289, 233)
        Me.AccBOMApprovalGridControl.TabIndex = 0
        Me.AccBOMApprovalGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AccBOMApprovalBindingSource
        '
        Me.AccBOMApprovalBindingSource.DataMember = "AccBOMApproval"
        Me.AccBOMApprovalBindingSource.DataSource = Me.AccBOMApprovalDataSet
        '
        'AccBOMApprovalDataSet
        '
        Me.AccBOMApprovalDataSet.DataSetName = "AccBOMApprovalDataSet"
        Me.AccBOMApprovalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBookingDate, Me.colAmendmentNo, Me.colAmendmentDate, Me.colRemarks, Me.colProgramNo, Me.colBuyer, Me.colStyleNo, Me.colFullComplete, Me.colAccessoriesBookingId1})
        Me.GridView1.GridControl = Me.AccBOMApprovalGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colBookingDate
        '
        Me.colBookingDate.FieldName = "BookingDate"
        Me.colBookingDate.Name = "colBookingDate"
        Me.colBookingDate.OptionsColumn.AllowEdit = False
        Me.colBookingDate.Visible = True
        Me.colBookingDate.VisibleIndex = 5
        Me.colBookingDate.Width = 132
        '
        'colAmendmentNo
        '
        Me.colAmendmentNo.FieldName = "AmendmentNo"
        Me.colAmendmentNo.Name = "colAmendmentNo"
        Me.colAmendmentNo.OptionsColumn.AllowEdit = False
        Me.colAmendmentNo.Visible = True
        Me.colAmendmentNo.VisibleIndex = 3
        Me.colAmendmentNo.Width = 100
        '
        'colAmendmentDate
        '
        Me.colAmendmentDate.FieldName = "AmendmentDate"
        Me.colAmendmentDate.Name = "colAmendmentDate"
        Me.colAmendmentDate.OptionsColumn.AllowEdit = False
        Me.colAmendmentDate.Visible = True
        Me.colAmendmentDate.VisibleIndex = 4
        Me.colAmendmentDate.Width = 134
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.OptionsColumn.AllowEdit = False
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 7
        Me.colRemarks.Width = 518
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsColumn.AllowEdit = False
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        Me.colProgramNo.Width = 115
        '
        'colBuyer
        '
        Me.colBuyer.FieldName = "Buyer"
        Me.colBuyer.Name = "colBuyer"
        Me.colBuyer.OptionsColumn.AllowEdit = False
        Me.colBuyer.Visible = True
        Me.colBuyer.VisibleIndex = 1
        '
        'colStyleNo
        '
        Me.colStyleNo.FieldName = "StyleNo"
        Me.colStyleNo.Name = "colStyleNo"
        Me.colStyleNo.OptionsColumn.AllowEdit = False
        Me.colStyleNo.Visible = True
        Me.colStyleNo.VisibleIndex = 2
        '
        'colFullComplete
        '
        Me.colFullComplete.FieldName = "FullComplete"
        Me.colFullComplete.Name = "colFullComplete"
        Me.colFullComplete.OptionsColumn.AllowEdit = False
        Me.colFullComplete.Visible = True
        Me.colFullComplete.VisibleIndex = 6
        '
        'colAccessoriesBookingId1
        '
        Me.colAccessoriesBookingId1.FieldName = "AccessoriesBookingId"
        Me.colAccessoriesBookingId1.Name = "colAccessoriesBookingId1"
        Me.colAccessoriesBookingId1.OptionsColumn.AllowEdit = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(765, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Show Details [All]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SelectSimpleButton
        '
        Me.SelectSimpleButton.Location = New System.Drawing.Point(12, 5)
        Me.SelectSimpleButton.Name = "SelectSimpleButton"
        Me.SelectSimpleButton.Size = New System.Drawing.Size(81, 40)
        Me.SelectSimpleButton.TabIndex = 61
        Me.SelectSimpleButton.Text = "&Select All"
        '
        'ShowDetailsButton
        '
        Me.ShowDetailsButton.Location = New System.Drawing.Point(929, 5)
        Me.ShowDetailsButton.Name = "ShowDetailsButton"
        Me.ShowDetailsButton.Size = New System.Drawing.Size(170, 40)
        Me.ShowDetailsButton.TabIndex = 4
        Me.ShowDetailsButton.Text = "Show Details [ Completed ]"
        Me.ShowDetailsButton.UseVisualStyleBackColor = True
        '
        'AccessoresBookingDetailsGridControl
        '
        Me.AccessoresBookingDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessoresBookingDetailsGridControl.DataSource = Me.AccessoresBookingDetailsBindingSource
        Me.AccessoresBookingDetailsGridControl.Location = New System.Drawing.Point(0, 49)
        Me.AccessoresBookingDetailsGridControl.MainView = Me.GridView2
        Me.AccessoresBookingDetailsGridControl.Name = "AccessoresBookingDetailsGridControl"
        Me.AccessoresBookingDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemGridLookUpEdit4, Me.RepositoryItemGridLookUpEdit5, Me.RepositoryItemGridLookUpEdit6, Me.RepositoryItemGridLookUpEdit7, Me.RepositoryItemGridLookUpEdit8})
        Me.AccessoresBookingDetailsGridControl.Size = New System.Drawing.Size(1289, 318)
        Me.AccessoresBookingDetailsGridControl.TabIndex = 60
        Me.AccessoresBookingDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView11})
        '
        'AccessoresBookingDetailsBindingSource
        '
        Me.AccessoresBookingDetailsBindingSource.DataMember = "AccessoresBookingDetails"
        Me.AccessoresBookingDetailsBindingSource.DataSource = Me.AccessoriesBookingNewDataSet
        '
        'AccessoriesBookingNewDataSet
        '
        Me.AccessoriesBookingNewDataSet.DataSetName = "AccessoriesBookingNewDataSet"
        Me.AccessoriesBookingNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.ColumnPanelRowHeight = 40
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorId, Me.colConsumption, Me.colConsumptionUnitId, Me.colBookingUnitId, Me.colBookingQuantity, Me.GridColumn3, Me.GridColumn2, Me.colConsumptionForPcs, Me.colWastagePercentage, Me.colSLNo, Me.colTotalPrice, Me.colSizeId1, Me.colDestinationId, Me.colPackType, Me.GridColumn5, Me.colIsSelected, Me.colUnitPrice1, Me.colIsApproved1, Me.colIsComplete})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(1082, 111, 216, 318)
        Me.GridView2.GridControl = Me.AccessoresBookingDetailsGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsDetail.AllowZoomDetail = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsDetail.SmartDetailExpand = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowDetailButtons = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorId
        '
        Me.colFabricColorId.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricColorId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricColorId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricColorId.Caption = "Color"
        Me.colFabricColorId.ColumnEdit = Me.RepositoryItemGridLookUpEdit4
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.OptionsColumn.AllowEdit = False
        Me.colFabricColorId.OptionsColumn.ReadOnly = True
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 4
        Me.colFabricColorId.Width = 133
        '
        'RepositoryItemGridLookUpEdit4
        '
        Me.RepositoryItemGridLookUpEdit4.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit4.DataSource = Me.FabricColorBindingSource
        Me.RepositoryItemGridLookUpEdit4.DisplayMember = "FabricColorName"
        Me.RepositoryItemGridLookUpEdit4.Name = "RepositoryItemGridLookUpEdit4"
        Me.RepositoryItemGridLookUpEdit4.NullText = "[Null]"
        Me.RepositoryItemGridLookUpEdit4.PopupView = Me.GridView3
        Me.RepositoryItemGridLookUpEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit4.ValueMember = "FabricColorId"
        '
        'FabricColorBindingSource
        '
        Me.FabricColorBindingSource.DataMember = "FabricColor"
        Me.FabricColorBindingSource.DataSource = Me.FabricColorDataSet
        '
        'FabricColorDataSet
        '
        Me.FabricColorDataSet.DataSetName = "FabricColorDataSet"
        Me.FabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        '
        'colConsumption
        '
        Me.colConsumption.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colConsumption.AppearanceCell.Options.UseBackColor = True
        Me.colConsumption.AppearanceHeader.Options.UseTextOptions = True
        Me.colConsumption.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConsumption.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConsumption.Caption = "Con"
        Me.colConsumption.FieldName = "Consumption"
        Me.colConsumption.Name = "colConsumption"
        Me.colConsumption.OptionsColumn.AllowEdit = False
        Me.colConsumption.OptionsColumn.ReadOnly = True
        Me.colConsumption.Visible = True
        Me.colConsumption.VisibleIndex = 10
        Me.colConsumption.Width = 47
        '
        'colConsumptionUnitId
        '
        Me.colConsumptionUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colConsumptionUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConsumptionUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConsumptionUnitId.Caption = "Con Unit"
        Me.colConsumptionUnitId.ColumnEdit = Me.RepositoryItemGridLookUpEdit7
        Me.colConsumptionUnitId.FieldName = "ConsumptionUnitId"
        Me.colConsumptionUnitId.Name = "colConsumptionUnitId"
        Me.colConsumptionUnitId.OptionsColumn.AllowEdit = False
        Me.colConsumptionUnitId.OptionsColumn.ReadOnly = True
        Me.colConsumptionUnitId.Visible = True
        Me.colConsumptionUnitId.VisibleIndex = 11
        Me.colConsumptionUnitId.Width = 57
        '
        'RepositoryItemGridLookUpEdit7
        '
        Me.RepositoryItemGridLookUpEdit7.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit7.DataSource = Me.UnitBindingSource
        Me.RepositoryItemGridLookUpEdit7.DisplayMember = "UnitCode"
        Me.RepositoryItemGridLookUpEdit7.Name = "RepositoryItemGridLookUpEdit7"
        Me.RepositoryItemGridLookUpEdit7.NullText = "[Null]"
        Me.RepositoryItemGridLookUpEdit7.PopupView = Me.GridView4
        Me.RepositoryItemGridLookUpEdit7.ValueMember = "UnitId"
        '
        'UnitBindingSource
        '
        Me.UnitBindingSource.DataMember = "Unit"
        Me.UnitBindingSource.DataSource = Me.UnitDataSet
        '
        'UnitDataSet
        '
        Me.UnitDataSet.DataSetName = "UnitDataSet"
        Me.UnitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId1, Me.colUnitCode, Me.colUnitName})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colUnitId1
        '
        Me.colUnitId1.FieldName = "UnitId"
        Me.colUnitId1.Name = "colUnitId1"
        Me.colUnitId1.OptionsColumn.ReadOnly = True
        '
        'colUnitCode
        '
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Visible = True
        Me.colUnitCode.VisibleIndex = 0
        '
        'colUnitName
        '
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        '
        'colBookingUnitId
        '
        Me.colBookingUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colBookingUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBookingUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBookingUnitId.Caption = "Booking Unit"
        Me.colBookingUnitId.ColumnEdit = Me.RepositoryItemGridLookUpEdit8
        Me.colBookingUnitId.FieldName = "BookingUnitId"
        Me.colBookingUnitId.Name = "colBookingUnitId"
        Me.colBookingUnitId.OptionsColumn.AllowEdit = False
        Me.colBookingUnitId.OptionsColumn.ReadOnly = True
        Me.colBookingUnitId.Visible = True
        Me.colBookingUnitId.VisibleIndex = 6
        Me.colBookingUnitId.Width = 58
        '
        'RepositoryItemGridLookUpEdit8
        '
        Me.RepositoryItemGridLookUpEdit8.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit8.DataSource = Me.UnitBindingSource
        Me.RepositoryItemGridLookUpEdit8.DisplayMember = "UnitCode"
        Me.RepositoryItemGridLookUpEdit8.Name = "RepositoryItemGridLookUpEdit8"
        Me.RepositoryItemGridLookUpEdit8.NullText = ""
        Me.RepositoryItemGridLookUpEdit8.PopupView = Me.GridView5
        Me.RepositoryItemGridLookUpEdit8.ValueMember = "UnitId"
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId2, Me.colUnitCode1, Me.colUnitName1})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colUnitId2
        '
        Me.colUnitId2.FieldName = "UnitId"
        Me.colUnitId2.Name = "colUnitId2"
        Me.colUnitId2.OptionsColumn.ReadOnly = True
        '
        'colUnitCode1
        '
        Me.colUnitCode1.FieldName = "UnitCode"
        Me.colUnitCode1.Name = "colUnitCode1"
        Me.colUnitCode1.Visible = True
        Me.colUnitCode1.VisibleIndex = 0
        '
        'colUnitName1
        '
        Me.colUnitName1.FieldName = "UnitName"
        Me.colUnitName1.Name = "colUnitName1"
        '
        'colBookingQuantity
        '
        Me.colBookingQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colBookingQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBookingQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBookingQuantity.FieldName = "BookingQuantity"
        Me.colBookingQuantity.Name = "colBookingQuantity"
        Me.colBookingQuantity.OptionsColumn.AllowEdit = False
        Me.colBookingQuantity.OptionsColumn.ReadOnly = True
        Me.colBookingQuantity.Visible = True
        Me.colBookingQuantity.VisibleIndex = 14
        Me.colBookingQuantity.Width = 90
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn3.FieldName = "Remarks"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 17
        Me.GridColumn3.Width = 104
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn2.Caption = "Item Name"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.GridColumn2.FieldName = "ItemId"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "AccessoriesId", "")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 192
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.ItemListBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "ItemName"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = "[Null]"
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.GridView7
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "ItemId"
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView7
        '
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colConsumptionForPcs
        '
        Me.colConsumptionForPcs.AppearanceHeader.Options.UseTextOptions = True
        Me.colConsumptionForPcs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConsumptionForPcs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConsumptionForPcs.Caption = "Pcs/Con"
        Me.colConsumptionForPcs.FieldName = "ConsumptionForPcs"
        Me.colConsumptionForPcs.Name = "colConsumptionForPcs"
        Me.colConsumptionForPcs.OptionsColumn.AllowEdit = False
        Me.colConsumptionForPcs.OptionsColumn.ReadOnly = True
        Me.colConsumptionForPcs.Visible = True
        Me.colConsumptionForPcs.VisibleIndex = 12
        Me.colConsumptionForPcs.Width = 80
        '
        'colWastagePercentage
        '
        Me.colWastagePercentage.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colWastagePercentage.AppearanceCell.Options.UseBackColor = True
        Me.colWastagePercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colWastagePercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWastagePercentage.Caption = "W%"
        Me.colWastagePercentage.FieldName = "WastagePercentage"
        Me.colWastagePercentage.Name = "colWastagePercentage"
        Me.colWastagePercentage.OptionsColumn.AllowEdit = False
        Me.colWastagePercentage.OptionsColumn.ReadOnly = True
        Me.colWastagePercentage.Visible = True
        Me.colWastagePercentage.VisibleIndex = 13
        Me.colWastagePercentage.Width = 49
        '
        'colSLNo
        '
        Me.colSLNo.FieldName = "SLNo"
        Me.colSLNo.Name = "colSLNo"
        Me.colSLNo.Width = 58
        '
        'colTotalPrice
        '
        Me.colTotalPrice.FieldName = "TotalPrice"
        Me.colTotalPrice.Name = "colTotalPrice"
        Me.colTotalPrice.OptionsColumn.AllowEdit = False
        Me.colTotalPrice.OptionsColumn.ReadOnly = True
        Me.colTotalPrice.Visible = True
        Me.colTotalPrice.VisibleIndex = 16
        '
        'colSizeId1
        '
        Me.colSizeId1.AppearanceCell.Options.UseTextOptions = True
        Me.colSizeId1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSizeId1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSizeId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colSizeId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSizeId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSizeId1.Caption = "Size"
        Me.colSizeId1.ColumnEdit = Me.RepositoryItemGridLookUpEdit5
        Me.colSizeId1.FieldName = "SizeId"
        Me.colSizeId1.Name = "colSizeId1"
        Me.colSizeId1.OptionsColumn.AllowEdit = False
        Me.colSizeId1.OptionsColumn.ReadOnly = True
        Me.colSizeId1.Visible = True
        Me.colSizeId1.VisibleIndex = 5
        Me.colSizeId1.Width = 66
        '
        'RepositoryItemGridLookUpEdit5
        '
        Me.RepositoryItemGridLookUpEdit5.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit5.DataSource = Me.SizeLookupBindingSource
        Me.RepositoryItemGridLookUpEdit5.DisplayMember = "SizeCode"
        Me.RepositoryItemGridLookUpEdit5.Name = "RepositoryItemGridLookUpEdit5"
        Me.RepositoryItemGridLookUpEdit5.NullText = ""
        Me.RepositoryItemGridLookUpEdit5.PopupView = Me.GridView9
        Me.RepositoryItemGridLookUpEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit5.ValueMember = "SizeId"
        '
        'SizeLookupBindingSource
        '
        Me.SizeLookupBindingSource.DataMember = "SizeLookup"
        Me.SizeLookupBindingSource.DataSource = Me.SizeDataSet
        '
        'SizeDataSet
        '
        Me.SizeDataSet.DataSetName = "SizeDataSet"
        Me.SizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'colDestinationId
        '
        Me.colDestinationId.Caption = "Destination"
        Me.colDestinationId.ColumnEdit = Me.RepositoryItemGridLookUpEdit6
        Me.colDestinationId.FieldName = "DestinationId"
        Me.colDestinationId.Name = "colDestinationId"
        Me.colDestinationId.OptionsColumn.AllowEdit = False
        Me.colDestinationId.OptionsColumn.ReadOnly = True
        Me.colDestinationId.Visible = True
        Me.colDestinationId.VisibleIndex = 8
        Me.colDestinationId.Width = 84
        '
        'RepositoryItemGridLookUpEdit6
        '
        Me.RepositoryItemGridLookUpEdit6.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit6.DataSource = Me.DestinationBindingSource
        Me.RepositoryItemGridLookUpEdit6.DisplayMember = "DestinationCode"
        Me.RepositoryItemGridLookUpEdit6.Name = "RepositoryItemGridLookUpEdit6"
        Me.RepositoryItemGridLookUpEdit6.NullText = ""
        Me.RepositoryItemGridLookUpEdit6.PopupView = Me.GridView10
        Me.RepositoryItemGridLookUpEdit6.ValueMember = "DestinationId"
        '
        'DestinationBindingSource
        '
        Me.DestinationBindingSource.DataMember = "Destination"
        Me.DestinationBindingSource.DataSource = Me.DestinationDataSet
        '
        'DestinationDataSet
        '
        Me.DestinationDataSet.DataSetName = "DestinationDataSet"
        Me.DestinationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDestinationId1, Me.colDestinationCode, Me.colDestinationName})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colDestinationId1
        '
        Me.colDestinationId1.FieldName = "DestinationId"
        Me.colDestinationId1.Name = "colDestinationId1"
        Me.colDestinationId1.OptionsColumn.ReadOnly = True
        '
        'colDestinationCode
        '
        Me.colDestinationCode.FieldName = "DestinationCode"
        Me.colDestinationCode.Name = "colDestinationCode"
        Me.colDestinationCode.Visible = True
        Me.colDestinationCode.VisibleIndex = 0
        '
        'colDestinationName
        '
        Me.colDestinationName.FieldName = "DestinationName"
        Me.colDestinationName.Name = "colDestinationName"
        '
        'colPackType
        '
        Me.colPackType.FieldName = "PackType"
        Me.colPackType.Name = "colPackType"
        Me.colPackType.OptionsColumn.AllowEdit = False
        Me.colPackType.OptionsColumn.ReadOnly = True
        Me.colPackType.Visible = True
        Me.colPackType.VisibleIndex = 7
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn5.FieldName = "OrderQuantity"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 9
        Me.GridColumn5.Width = 65
        '
        'colIsSelected
        '
        Me.colIsSelected.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colIsSelected.AppearanceCell.Options.UseBackColor = True
        Me.colIsSelected.FieldName = "IsSelected"
        Me.colIsSelected.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colIsSelected.Name = "colIsSelected"
        Me.colIsSelected.Visible = True
        Me.colIsSelected.VisibleIndex = 0
        '
        'colUnitPrice1
        '
        Me.colUnitPrice1.FieldName = "UnitPrice"
        Me.colUnitPrice1.Name = "colUnitPrice1"
        Me.colUnitPrice1.OptionsColumn.AllowEdit = False
        Me.colUnitPrice1.OptionsColumn.ReadOnly = True
        Me.colUnitPrice1.Visible = True
        Me.colUnitPrice1.VisibleIndex = 15
        '
        'colIsApproved1
        '
        Me.colIsApproved1.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colIsApproved1.AppearanceCell.Options.UseBackColor = True
        Me.colIsApproved1.FieldName = "IsApproved"
        Me.colIsApproved1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colIsApproved1.Name = "colIsApproved1"
        Me.colIsApproved1.Visible = True
        Me.colIsApproved1.VisibleIndex = 2
        '
        'colIsComplete
        '
        Me.colIsComplete.FieldName = "IsComplete"
        Me.colIsComplete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colIsComplete.Name = "colIsComplete"
        Me.colIsComplete.OptionsColumn.ReadOnly = True
        Me.colIsComplete.Visible = True
        Me.colIsComplete.VisibleIndex = 1
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "SupplierCode"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.PopupView = Me.GridView6
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "SupplierId"
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId3, Me.colSupplierName1, Me.colAdd11, Me.colAdd21, Me.colContactPerson1, Me.colContactNo1, Me.colSupplierType1, Me.colSupplierCode1, Me.colCity1, Me.colCountry1})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId3
        '
        Me.colSupplierId3.FieldName = "SupplierId"
        Me.colSupplierId3.Name = "colSupplierId3"
        Me.colSupplierId3.OptionsColumn.ReadOnly = True
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
        '
        'colAdd11
        '
        Me.colAdd11.FieldName = "Add1"
        Me.colAdd11.Name = "colAdd11"
        '
        'colAdd21
        '
        Me.colAdd21.FieldName = "Add2"
        Me.colAdd21.Name = "colAdd21"
        '
        'colContactPerson1
        '
        Me.colContactPerson1.FieldName = "ContactPerson"
        Me.colContactPerson1.Name = "colContactPerson1"
        '
        'colContactNo1
        '
        Me.colContactNo1.FieldName = "ContactNo"
        Me.colContactNo1.Name = "colContactNo1"
        '
        'colSupplierType1
        '
        Me.colSupplierType1.FieldName = "SupplierType"
        Me.colSupplierType1.Name = "colSupplierType1"
        '
        'colSupplierCode1
        '
        Me.colSupplierCode1.FieldName = "SupplierCode"
        Me.colSupplierCode1.Name = "colSupplierCode1"
        Me.colSupplierCode1.Visible = True
        Me.colSupplierCode1.VisibleIndex = 0
        '
        'colCity1
        '
        Me.colCity1.FieldName = "City"
        Me.colCity1.Name = "colCity1"
        '
        'colCountry1
        '
        Me.colCountry1.FieldName = "Country"
        Me.colCountry1.Name = "colCountry1"
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "ItemStyle"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = "[Null]"
        Me.RepositoryItemGridLookUpEdit3.PopupView = Me.GridView8
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "AccessoriesId"
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccessoriesId2, Me.colAccessoriesName1, Me.colItemStyle2, Me.colItemDetails1})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colAccessoriesId2
        '
        Me.colAccessoriesId2.FieldName = "AccessoriesId"
        Me.colAccessoriesId2.Name = "colAccessoriesId2"
        Me.colAccessoriesId2.OptionsColumn.ReadOnly = True
        '
        'colAccessoriesName1
        '
        Me.colAccessoriesName1.FieldName = "AccessoriesName"
        Me.colAccessoriesName1.Name = "colAccessoriesName1"
        '
        'colItemStyle2
        '
        Me.colItemStyle2.FieldName = "ItemStyle"
        Me.colItemStyle2.Name = "colItemStyle2"
        Me.colItemStyle2.OptionsColumn.ReadOnly = True
        Me.colItemStyle2.Visible = True
        Me.colItemStyle2.VisibleIndex = 0
        '
        'colItemDetails1
        '
        Me.colItemDetails1.FieldName = "ItemDetails"
        Me.colItemDetails1.Name = "colItemDetails1"
        Me.colItemDetails1.OptionsColumn.ReadOnly = True
        '
        'GridView11
        '
        Me.GridView11.GridControl = Me.AccessoresBookingDetailsGridControl
        Me.GridView11.Name = "GridView11"
        '
        'ApprovedButton
        '
        Me.ApprovedButton.Location = New System.Drawing.Point(1131, 5)
        Me.ApprovedButton.Name = "ApprovedButton"
        Me.ApprovedButton.Size = New System.Drawing.Size(133, 40)
        Me.ApprovedButton.TabIndex = 3
        Me.ApprovedButton.Text = "Approved"
        Me.ApprovedButton.UseVisualStyleBackColor = True
        '
        'AccBOMApprovalTableAdapter
        '
        Me.AccBOMApprovalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.AccBOMApprovalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AccessoresBookingDetailsTableAdapter
        '
        Me.AccessoresBookingDetailsTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'SizeBindingSource
        '
        Me.SizeBindingSource.DataMember = "Size"
        Me.SizeBindingSource.DataSource = Me.SizeDataSet
        '
        'SizeTableAdapter
        '
        Me.SizeTableAdapter.ClearBeforeFill = True
        '
        'SizeLookupTableAdapter
        '
        Me.SizeLookupTableAdapter.ClearBeforeFill = True
        '
        'DestinationTableAdapter
        '
        Me.DestinationTableAdapter.ClearBeforeFill = True
        '
        'frmAccBOMApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 642)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmAccBOMApproval"
        Me.Text = "Acc BOM Approval"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AccBOMApprovalGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMApprovalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoresBookingDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoresBookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesBookingNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AccBOMApprovalDataSet As KSoft_Apparel.AccBOMApprovalDataSet
    Friend WithEvents AccBOMApprovalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccBOMApprovalTableAdapter As KSoft_Apparel.AccBOMApprovalDataSetTableAdapters.AccBOMApprovalTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.AccBOMApprovalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccBOMApprovalGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBookingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ApprovedButton As System.Windows.Forms.Button
    Friend WithEvents ShowAllButton As System.Windows.Forms.Button
    Friend WithEvents PendingButton As System.Windows.Forms.Button
    Friend WithEvents AccessoresBookingDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesBookingNewDataSet As KSoft_Apparel.AccessoriesBookingNewDataSet
    Friend WithEvents AccessoresBookingDetailsTableAdapter As KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoresBookingDetailsTableAdapter
    Friend WithEvents AccessoresBookingDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsumption As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsumptionUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBookingUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBookingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccessoriesId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemStyle2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsumptionForPcs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWastagePercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSLNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDestinationId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPackType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ShowDetailsButton As System.Windows.Forms.Button
    Friend WithEvents colIsApproved1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesBookingId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListDataSet As KSoft_Apparel.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents SizeDataSet As KSoft_Apparel.SizeDataSet
    Friend WithEvents SizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeTableAdapter As KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter
    Friend WithEvents SizeLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeLookupTableAdapter As KSoft_Apparel.SizeDataSetTableAdapters.SizeLookupTableAdapter
    Friend WithEvents DestinationDataSet As KSoft_Apparel.DestinationDataSet
    Friend WithEvents DestinationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DestinationTableAdapter As KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter
    Friend WithEvents SelectSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShowApprovedButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents colIsComplete As DevExpress.XtraGrid.Columns.GridColumn
End Class
