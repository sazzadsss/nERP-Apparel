<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWashingProduction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWashingProduction))
        Me.WashingProductionDataSet = New KSoft_Apparel.WashingProductionDataSet()
        Me.WashingProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashingProductionTableAdapter = New KSoft_Apparel.WashingProductionDataSetTableAdapters.WashingProductionTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.WashingProductionDataSetTableAdapters.TableAdapterManager()
        Me.WashingProductionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.WashingProductionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WashingProductionGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashingProductionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWashingProductionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWashingRequestDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.WashingRequestDetailsLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashingRequestDetailsLookupDataSet = New KSoft_Apparel.WashingRequestDetailsLookupDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashingBatchId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.WashingBatchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashingBatchDataSet = New KSoft_Apparel.WashingBatchDataSet()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashingBatchNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputQuantityKg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputQuantityPc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWashQuantityKg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWashQuantityPc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRejectQuantityKg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRejectQuantityPc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryQuantityPc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryQuantityKg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WRDIDGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WRIDGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.WashingRequestLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashingRequestDataSet = New KSoft_Apparel.WashingRequestDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.GridLookUpEdit3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashingBatchNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WashingRequestLookUpTableAdapter = New KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestLookUpTableAdapter()
        Me.WashingRequestDetailsLookupTableAdapter = New KSoft_Apparel.WashingRequestDetailsLookupDataSetTableAdapters.WashingRequestDetailsLookupTableAdapter()
        Me.ShowByDateButton = New System.Windows.Forms.Button()
        Me.ShowByWRButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.WashingBatchTableAdapter = New KSoft_Apparel.WashingBatchDataSetTableAdapters.WashingBatchTableAdapter()
        Me.WashingRequestDetailsLookupAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashingRequestDetailsLookupAllTableAdapter = New KSoft_Apparel.WashingRequestDetailsLookupDataSetTableAdapters.WashingRequestDetailsLookupAllTableAdapter()
        Me.colDetails2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.WashingProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingProductionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WashingProductionBindingNavigator.SuspendLayout()
        CType(Me.WashingProductionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDetailsLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDetailsLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingBatchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingBatchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WRDIDGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WRIDGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashingRequestDetailsLookupAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WashingProductionDataSet
        '
        Me.WashingProductionDataSet.DataSetName = "WashingProductionDataSet"
        Me.WashingProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WashingProductionBindingSource
        '
        Me.WashingProductionBindingSource.DataMember = "WashingProduction"
        Me.WashingProductionBindingSource.DataSource = Me.WashingProductionDataSet
        '
        'WashingProductionTableAdapter
        '
        Me.WashingProductionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.WashingProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WashingProductionTableAdapter = Me.WashingProductionTableAdapter
        '
        'WashingProductionBindingNavigator
        '
        Me.WashingProductionBindingNavigator.AddNewItem = Nothing
        Me.WashingProductionBindingNavigator.BindingSource = Me.WashingProductionBindingSource
        Me.WashingProductionBindingNavigator.CountItem = Nothing
        Me.WashingProductionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WashingProductionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorDeleteItem, Me.WashingProductionBindingNavigatorSaveItem})
        Me.WashingProductionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WashingProductionBindingNavigator.MoveFirstItem = Nothing
        Me.WashingProductionBindingNavigator.MoveLastItem = Nothing
        Me.WashingProductionBindingNavigator.MoveNextItem = Nothing
        Me.WashingProductionBindingNavigator.MovePreviousItem = Nothing
        Me.WashingProductionBindingNavigator.Name = "WashingProductionBindingNavigator"
        Me.WashingProductionBindingNavigator.PositionItem = Nothing
        Me.WashingProductionBindingNavigator.Size = New System.Drawing.Size(1284, 25)
        Me.WashingProductionBindingNavigator.TabIndex = 0
        Me.WashingProductionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'WashingProductionBindingNavigatorSaveItem
        '
        Me.WashingProductionBindingNavigatorSaveItem.Image = CType(resources.GetObject("WashingProductionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WashingProductionBindingNavigatorSaveItem.Name = "WashingProductionBindingNavigatorSaveItem"
        Me.WashingProductionBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.WashingProductionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WashingProductionGridControl
        '
        Me.WashingProductionGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WashingProductionGridControl.DataSource = Me.WashingProductionBindingSource
        Me.WashingProductionGridControl.Location = New System.Drawing.Point(0, 101)
        Me.WashingProductionGridControl.MainView = Me.GridView1
        Me.WashingProductionGridControl.Name = "WashingProductionGridControl"
        Me.WashingProductionGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2})
        Me.WashingProductionGridControl.Size = New System.Drawing.Size(1284, 499)
        Me.WashingProductionGridControl.TabIndex = 1
        Me.WashingProductionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashingProductionId, Me.colWashingProductionDate, Me.colWashingRequestDetailsId, Me.colWashingBatchId, Me.colInputQuantityKg, Me.colInputQuantityPc, Me.colWashQuantityKg, Me.colWashQuantityPc, Me.colRejectQuantityKg, Me.colRejectQuantityPc, Me.colDeliveryQuantityPc, Me.colDeliveryQuantityKg, Me.colRemarks})
        Me.GridView1.GridControl = Me.WashingProductionGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colWashingProductionId
        '
        Me.colWashingProductionId.FieldName = "WashingProductionId"
        Me.colWashingProductionId.Name = "colWashingProductionId"
        Me.colWashingProductionId.OptionsColumn.ReadOnly = True
        Me.colWashingProductionId.Width = 111
        '
        'colWashingProductionDate
        '
        Me.colWashingProductionDate.FieldName = "WashingProductionDate"
        Me.colWashingProductionDate.Name = "colWashingProductionDate"
        Me.colWashingProductionDate.OptionsColumn.AllowEdit = False
        Me.colWashingProductionDate.OptionsColumn.ReadOnly = True
        Me.colWashingProductionDate.Visible = True
        Me.colWashingProductionDate.VisibleIndex = 0
        Me.colWashingProductionDate.Width = 141
        '
        'colWashingRequestDetailsId
        '
        Me.colWashingRequestDetailsId.Caption = "Washing Request Details"
        Me.colWashingRequestDetailsId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colWashingRequestDetailsId.FieldName = "WashingRequestDetailsId"
        Me.colWashingRequestDetailsId.Name = "colWashingRequestDetailsId"
        Me.colWashingRequestDetailsId.OptionsColumn.AllowEdit = False
        Me.colWashingRequestDetailsId.OptionsColumn.ReadOnly = True
        Me.colWashingRequestDetailsId.Visible = True
        Me.colWashingRequestDetailsId.VisibleIndex = 1
        Me.colWashingRequestDetailsId.Width = 235
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.WashingRequestDetailsLookupAllBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "Details"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "WashingRequestDetailsId"
        '
        'WashingRequestDetailsLookupBindingSource
        '
        Me.WashingRequestDetailsLookupBindingSource.DataMember = "WashingRequestDetailsLookup"
        Me.WashingRequestDetailsLookupBindingSource.DataSource = Me.WashingRequestDetailsLookupDataSet
        '
        'WashingRequestDetailsLookupDataSet
        '
        Me.WashingRequestDetailsLookupDataSet.DataSetName = "WashingRequestDetailsLookupDataSet"
        Me.WashingRequestDetailsLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails2})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colWashingBatchId
        '
        Me.colWashingBatchId.Caption = "Batch No"
        Me.colWashingBatchId.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colWashingBatchId.FieldName = "WashingBatchId"
        Me.colWashingBatchId.Name = "colWashingBatchId"
        Me.colWashingBatchId.OptionsColumn.AllowEdit = False
        Me.colWashingBatchId.OptionsColumn.ReadOnly = True
        Me.colWashingBatchId.Visible = True
        Me.colWashingBatchId.VisibleIndex = 2
        Me.colWashingBatchId.Width = 122
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.WashingBatchBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "WashingBatchNo"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "WashingBatchId"
        '
        'WashingBatchBindingSource
        '
        Me.WashingBatchBindingSource.DataMember = "WashingBatch"
        Me.WashingBatchBindingSource.DataSource = Me.WashingBatchDataSet
        '
        'WashingBatchDataSet
        '
        Me.WashingBatchDataSet.DataSetName = "WashingBatchDataSet"
        Me.WashingBatchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashingBatchNo1})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colWashingBatchNo1
        '
        Me.colWashingBatchNo1.FieldName = "WashingBatchNo"
        Me.colWashingBatchNo1.Name = "colWashingBatchNo1"
        Me.colWashingBatchNo1.Visible = True
        Me.colWashingBatchNo1.VisibleIndex = 0
        '
        'colInputQuantityKg
        '
        Me.colInputQuantityKg.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colInputQuantityKg.AppearanceCell.Options.UseBackColor = True
        Me.colInputQuantityKg.FieldName = "InputQuantityKg"
        Me.colInputQuantityKg.Name = "colInputQuantityKg"
        Me.colInputQuantityKg.Visible = True
        Me.colInputQuantityKg.VisibleIndex = 3
        Me.colInputQuantityKg.Width = 108
        '
        'colInputQuantityPc
        '
        Me.colInputQuantityPc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colInputQuantityPc.AppearanceCell.Options.UseBackColor = True
        Me.colInputQuantityPc.FieldName = "InputQuantityPc"
        Me.colInputQuantityPc.Name = "colInputQuantityPc"
        Me.colInputQuantityPc.Visible = True
        Me.colInputQuantityPc.VisibleIndex = 4
        Me.colInputQuantityPc.Width = 107
        '
        'colWashQuantityKg
        '
        Me.colWashQuantityKg.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colWashQuantityKg.AppearanceCell.Options.UseBackColor = True
        Me.colWashQuantityKg.FieldName = "WashQuantityKg"
        Me.colWashQuantityKg.Name = "colWashQuantityKg"
        Me.colWashQuantityKg.Visible = True
        Me.colWashQuantityKg.VisibleIndex = 5
        Me.colWashQuantityKg.Width = 108
        '
        'colWashQuantityPc
        '
        Me.colWashQuantityPc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colWashQuantityPc.AppearanceCell.Options.UseBackColor = True
        Me.colWashQuantityPc.FieldName = "WashQuantityPc"
        Me.colWashQuantityPc.Name = "colWashQuantityPc"
        Me.colWashQuantityPc.Visible = True
        Me.colWashQuantityPc.VisibleIndex = 6
        Me.colWashQuantityPc.Width = 107
        '
        'colRejectQuantityKg
        '
        Me.colRejectQuantityKg.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colRejectQuantityKg.AppearanceCell.Options.UseBackColor = True
        Me.colRejectQuantityKg.FieldName = "RejectQuantityKg"
        Me.colRejectQuantityKg.Name = "colRejectQuantityKg"
        Me.colRejectQuantityKg.Visible = True
        Me.colRejectQuantityKg.VisibleIndex = 7
        Me.colRejectQuantityKg.Width = 108
        '
        'colRejectQuantityPc
        '
        Me.colRejectQuantityPc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colRejectQuantityPc.AppearanceCell.Options.UseBackColor = True
        Me.colRejectQuantityPc.FieldName = "RejectQuantityPc"
        Me.colRejectQuantityPc.Name = "colRejectQuantityPc"
        Me.colRejectQuantityPc.Visible = True
        Me.colRejectQuantityPc.VisibleIndex = 8
        Me.colRejectQuantityPc.Width = 108
        '
        'colDeliveryQuantityPc
        '
        Me.colDeliveryQuantityPc.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDeliveryQuantityPc.AppearanceCell.Options.UseBackColor = True
        Me.colDeliveryQuantityPc.FieldName = "DeliveryQuantityPc"
        Me.colDeliveryQuantityPc.Name = "colDeliveryQuantityPc"
        Me.colDeliveryQuantityPc.Visible = True
        Me.colDeliveryQuantityPc.VisibleIndex = 10
        Me.colDeliveryQuantityPc.Width = 127
        '
        'colDeliveryQuantityKg
        '
        Me.colDeliveryQuantityKg.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDeliveryQuantityKg.AppearanceCell.Options.UseBackColor = True
        Me.colDeliveryQuantityKg.FieldName = "DeliveryQuantityKg"
        Me.colDeliveryQuantityKg.Name = "colDeliveryQuantityKg"
        Me.colDeliveryQuantityKg.Visible = True
        Me.colDeliveryQuantityKg.VisibleIndex = 9
        Me.colDeliveryQuantityKg.Width = 119
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 11
        Me.colRemarks.Width = 133
        '
        'WRDIDGridLookUpEdit
        '
        Me.WRDIDGridLookUpEdit.Location = New System.Drawing.Point(571, 64)
        Me.WRDIDGridLookUpEdit.Name = "WRDIDGridLookUpEdit"
        Me.WRDIDGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WRDIDGridLookUpEdit.Properties.DataSource = Me.WashingRequestDetailsLookupBindingSource
        Me.WRDIDGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.WRDIDGridLookUpEdit.Properties.NullText = ""
        Me.WRDIDGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.WRDIDGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit2View
        Me.WRDIDGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.WRDIDGridLookUpEdit.Properties.ValueMember = "WashingRequestDetailsId"
        Me.WRDIDGridLookUpEdit.Size = New System.Drawing.Size(357, 20)
        Me.WRDIDGridLookUpEdit.TabIndex = 15
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(440, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Washing Request Details"
        '
        'WRIDGridLookUpEdit
        '
        Me.WRIDGridLookUpEdit.Location = New System.Drawing.Point(142, 64)
        Me.WRIDGridLookUpEdit.Name = "WRIDGridLookUpEdit"
        Me.WRIDGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WRIDGridLookUpEdit.Properties.DataSource = Me.WashingRequestLookUpBindingSource
        Me.WRIDGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.WRIDGridLookUpEdit.Properties.ImmediatePopup = True
        Me.WRIDGridLookUpEdit.Properties.NullText = ""
        Me.WRIDGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.WRIDGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.WRIDGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.WRIDGridLookUpEdit.Properties.ValueMember = "WashingRequestId"
        Me.WRIDGridLookUpEdit.Size = New System.Drawing.Size(238, 20)
        Me.WRIDGridLookUpEdit.TabIndex = 13
        '
        'WashingRequestLookUpBindingSource
        '
        Me.WashingRequestLookUpBindingSource.DataMember = "WashingRequestLookUp"
        Me.WashingRequestLookUpBindingSource.DataSource = Me.WashingRequestDataSet
        '
        'WashingRequestDataSet
        '
        Me.WashingRequestDataSet.DataSetName = "WashingRequestDataSet"
        Me.WashingRequestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label1.Location = New System.Drawing.Point(18, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Washing Request No"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(1209, 60)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(63, 23)
        Me.AddButton.TabIndex = 17
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'GridLookUpEdit3
        '
        Me.GridLookUpEdit3.Location = New System.Drawing.Point(1052, 63)
        Me.GridLookUpEdit3.Name = "GridLookUpEdit3"
        Me.GridLookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit3.Properties.DataSource = Me.WashingBatchBindingSource
        Me.GridLookUpEdit3.Properties.DisplayMember = "WashingBatchNo"
        Me.GridLookUpEdit3.Properties.NullText = ""
        Me.GridLookUpEdit3.Properties.PopupView = Me.GridView2
        Me.GridLookUpEdit3.Properties.ValueMember = "WashingBatchId"
        Me.GridLookUpEdit3.Size = New System.Drawing.Size(150, 20)
        Me.GridLookUpEdit3.TabIndex = 18
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashingBatchNo})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colWashingBatchNo
        '
        Me.colWashingBatchNo.FieldName = "WashingBatchNo"
        Me.colWashingBatchNo.Name = "colWashingBatchNo"
        Me.colWashingBatchNo.Visible = True
        Me.colWashingBatchNo.VisibleIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(988, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Batch No :"
        '
        'ProductionDateTimePicker
        '
        Me.ProductionDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ProductionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ProductionDateTimePicker.Location = New System.Drawing.Point(142, 33)
        Me.ProductionDateTimePicker.Name = "ProductionDateTimePicker"
        Me.ProductionDateTimePicker.Size = New System.Drawing.Size(105, 20)
        Me.ProductionDateTimePicker.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Production Date"
        '
        'WashingRequestLookUpTableAdapter
        '
        Me.WashingRequestLookUpTableAdapter.ClearBeforeFill = True
        '
        'WashingRequestDetailsLookupTableAdapter
        '
        Me.WashingRequestDetailsLookupTableAdapter.ClearBeforeFill = True
        '
        'ShowByDateButton
        '
        Me.ShowByDateButton.Location = New System.Drawing.Point(253, 31)
        Me.ShowByDateButton.Name = "ShowByDateButton"
        Me.ShowByDateButton.Size = New System.Drawing.Size(127, 23)
        Me.ShowByDateButton.TabIndex = 22
        Me.ShowByDateButton.Text = "Show by Date"
        Me.ShowByDateButton.UseVisualStyleBackColor = True
        '
        'ShowByWRButton
        '
        Me.ShowByWRButton.Location = New System.Drawing.Point(386, 62)
        Me.ShowByWRButton.Name = "ShowByWRButton"
        Me.ShowByWRButton.Size = New System.Drawing.Size(48, 23)
        Me.ShowByWRButton.TabIndex = 23
        Me.ShowByWRButton.Text = "&Show"
        Me.ShowByWRButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(934, 62)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "&Show"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'WashingBatchTableAdapter
        '
        Me.WashingBatchTableAdapter.ClearBeforeFill = True
        '
        'WashingRequestDetailsLookupAllBindingSource
        '
        Me.WashingRequestDetailsLookupAllBindingSource.DataMember = "WashingRequestDetailsLookupAll"
        Me.WashingRequestDetailsLookupAllBindingSource.DataSource = Me.WashingRequestDetailsLookupDataSet
        '
        'WashingRequestDetailsLookupAllTableAdapter
        '
        Me.WashingRequestDetailsLookupAllTableAdapter.ClearBeforeFill = True
        '
        'colDetails2
        '
        Me.colDetails2.FieldName = "Details"
        Me.colDetails2.Name = "colDetails2"
        Me.colDetails2.Visible = True
        Me.colDetails2.VisibleIndex = 0
        '
        'frmWashingProduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 600)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ShowByWRButton)
        Me.Controls.Add(Me.ShowByDateButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProductionDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GridLookUpEdit3)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WRDIDGridLookUpEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WRIDGridLookUpEdit)
        Me.Controls.Add(Me.WashingProductionGridControl)
        Me.Controls.Add(Me.WashingProductionBindingNavigator)
        Me.Name = "frmWashingProduction"
        Me.Text = "Washing Production"
        CType(Me.WashingProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingProductionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WashingProductionBindingNavigator.ResumeLayout(False)
        Me.WashingProductionBindingNavigator.PerformLayout()
        CType(Me.WashingProductionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDetailsLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDetailsLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingBatchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingBatchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WRDIDGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WRIDGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashingRequestDetailsLookupAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WashingProductionDataSet As KSoft_Apparel.WashingProductionDataSet
    Friend WithEvents WashingProductionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashingProductionTableAdapter As KSoft_Apparel.WashingProductionDataSetTableAdapters.WashingProductionTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.WashingProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WashingProductionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WashingProductionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WashingProductionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWashingProductionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashingProductionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashingRequestDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashingBatchId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputQuantityKg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInputQuantityPc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashQuantityKg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashQuantityPc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRejectQuantityKg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRejectQuantityPc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryQuantityPc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryQuantityKg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WRDIDGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WRIDGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents GridLookUpEdit3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProductionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WashingRequestDataSet As KSoft_Apparel.WashingRequestDataSet
    Friend WithEvents WashingRequestLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashingRequestLookUpTableAdapter As KSoft_Apparel.WashingRequestDataSetTableAdapters.WashingRequestLookUpTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WashingRequestDetailsLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashingRequestDetailsLookupDataSet As KSoft_Apparel.WashingRequestDetailsLookupDataSet
    Friend WithEvents WashingRequestDetailsLookupTableAdapter As KSoft_Apparel.WashingRequestDetailsLookupDataSetTableAdapters.WashingRequestDetailsLookupTableAdapter
    Friend WithEvents ShowByDateButton As System.Windows.Forms.Button
    Friend WithEvents ShowByWRButton As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents WashingBatchDataSet As WashingBatchDataSet
    Friend WithEvents WashingBatchBindingSource As BindingSource
    Friend WithEvents WashingBatchTableAdapter As WashingBatchDataSetTableAdapters.WashingBatchTableAdapter
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashingBatchNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWashingBatchNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WashingRequestDetailsLookupAllBindingSource As BindingSource
    Friend WithEvents WashingRequestDetailsLookupAllTableAdapter As WashingRequestDetailsLookupDataSetTableAdapters.WashingRequestDetailsLookupAllTableAdapter
    Friend WithEvents colDetails2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
