<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessoriesTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccessoriesTemplate))
        Me.AccessoriesTemplateDataSet = New KSoft_Apparel.AccessoriesTemplateDataSet()
        Me.AccessoriesTemplateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesTemplateTableAdapter = New KSoft_Apparel.AccessoriesTemplateDataSetTableAdapters.AccessoriesTemplateTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.AccessoriesTemplateDataSetTableAdapters.TableAdapterManager()
        Me.AccessoriesTemplateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.AccessoriesTemplateBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AccessoriesTemplateGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsCosting = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPackType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.colWastagePercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemNameGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Apparel.ItemListLookupDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemStyleLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ItemStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemStyleDataSet = New KSoft_Apparel.ItemStyleDataSet()
        Me.colTemplateCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ConGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.ItemStyleTableAdapter = New KSoft_Apparel.ItemStyleDataSetTableAdapters.ItemStyleTableAdapter()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.AccessoriesCategoryLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesCategoryLookupDataSet = New KSoft_Apparel.AccessoriesCategoryLookupDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AccessoriesCategoryLookupTableAdapter = New KSoft_Apparel.AccessoriesCategoryLookupDataSetTableAdapters.AccessoriesCategoryLookupTableAdapter()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsumption = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForGMTQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostPerDzn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.AccessoriesTemplateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesTemplateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesTemplateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccessoriesTemplateBindingNavigator.SuspendLayout()
        CType(Me.AccessoriesTemplateGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesCategoryLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccessoriesTemplateDataSet
        '
        Me.AccessoriesTemplateDataSet.DataSetName = "AccessoriesTemplateDataSet"
        Me.AccessoriesTemplateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccessoriesTemplateBindingSource
        '
        Me.AccessoriesTemplateBindingSource.DataMember = "AccessoriesTemplate"
        Me.AccessoriesTemplateBindingSource.DataSource = Me.AccessoriesTemplateDataSet
        '
        'AccessoriesTemplateTableAdapter
        '
        Me.AccessoriesTemplateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessoriesTemplateTableAdapter = Me.AccessoriesTemplateTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.AccessoriesTemplateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AccessoriesTemplateBindingNavigator
        '
        Me.AccessoriesTemplateBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AccessoriesTemplateBindingNavigator.BindingSource = Me.AccessoriesTemplateBindingSource
        Me.AccessoriesTemplateBindingNavigator.CountItem = Nothing
        Me.AccessoriesTemplateBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AccessoriesTemplateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AccessoriesTemplateBindingNavigatorSaveItem})
        Me.AccessoriesTemplateBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AccessoriesTemplateBindingNavigator.MoveFirstItem = Nothing
        Me.AccessoriesTemplateBindingNavigator.MoveLastItem = Nothing
        Me.AccessoriesTemplateBindingNavigator.MoveNextItem = Nothing
        Me.AccessoriesTemplateBindingNavigator.MovePreviousItem = Nothing
        Me.AccessoriesTemplateBindingNavigator.Name = "AccessoriesTemplateBindingNavigator"
        Me.AccessoriesTemplateBindingNavigator.PositionItem = Nothing
        Me.AccessoriesTemplateBindingNavigator.Size = New System.Drawing.Size(913, 25)
        Me.AccessoriesTemplateBindingNavigator.TabIndex = 0
        Me.AccessoriesTemplateBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'AccessoriesTemplateBindingNavigatorSaveItem
        '
        Me.AccessoriesTemplateBindingNavigatorSaveItem.Image = CType(resources.GetObject("AccessoriesTemplateBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AccessoriesTemplateBindingNavigatorSaveItem.Name = "AccessoriesTemplateBindingNavigatorSaveItem"
        Me.AccessoriesTemplateBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.AccessoriesTemplateBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AccessoriesTemplateGridControl
        '
        Me.AccessoriesTemplateGridControl.DataSource = Me.AccessoriesTemplateBindingSource
        Me.AccessoriesTemplateGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccessoriesTemplateGridControl.Location = New System.Drawing.Point(0, 25)
        Me.AccessoriesTemplateGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.AccessoriesTemplateGridControl.MainView = Me.GridView1
        Me.AccessoriesTemplateGridControl.Name = "AccessoriesTemplateGridControl"
        Me.AccessoriesTemplateGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemStyleLookUpEdit, Me.SupplierLookUpEdit, Me.UnitLookUpEdit, Me.ItemNameGridLookUpEdit, Me.ConGridLookUpEdit})
        Me.AccessoriesTemplateGridControl.Size = New System.Drawing.Size(913, 439)
        Me.AccessoriesTemplateGridControl.TabIndex = 1
        Me.AccessoriesTemplateGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRemarks, Me.colIsCosting, Me.colPackType, Me.colSupplierId, Me.colWastagePercentage, Me.colUnitId, Me.colItemId, Me.colItemStyleId, Me.colTemplateCategory, Me.colUnitPrice, Me.colConUnitId, Me.colConsumption, Me.colForGMTQty, Me.colCostPerDzn})
        Me.GridView1.GridControl = Me.AccessoriesTemplateGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colRemarks
        '
        Me.colRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 8
        Me.colRemarks.Width = 400
        '
        'colIsCosting
        '
        Me.colIsCosting.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsCosting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsCosting.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsCosting.Caption = "Exclude From Costing"
        Me.colIsCosting.FieldName = "IsCosting"
        Me.colIsCosting.Name = "colIsCosting"
        Me.colIsCosting.Width = 112
        '
        'colPackType
        '
        Me.colPackType.AppearanceHeader.Options.UseTextOptions = True
        Me.colPackType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPackType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPackType.FieldName = "PackType"
        Me.colPackType.Name = "colPackType"
        '
        'colSupplierId
        '
        Me.colSupplierId.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierId.Caption = "Supplier"
        Me.colSupplierId.ColumnEdit = Me.SupplierLookUpEdit
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colSupplierId.Width = 92
        '
        'SupplierLookUpEdit
        '
        Me.SupplierLookUpEdit.AutoHeight = False
        Me.SupplierLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "Supplier Name", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierCode", "Supplier Code", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SupplierLookUpEdit.DataSource = Me.SupplierBindingSource
        Me.SupplierLookUpEdit.DisplayMember = "SupplierCode"
        Me.SupplierLookUpEdit.Name = "SupplierLookUpEdit"
        Me.SupplierLookUpEdit.PopupFormMinSize = New System.Drawing.Size(200, 0)
        Me.SupplierLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.SupplierLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierLookUpEdit.ValueMember = "SupplierId"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colWastagePercentage
        '
        Me.colWastagePercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colWastagePercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWastagePercentage.Caption = "W%"
        Me.colWastagePercentage.FieldName = "WastagePercentage"
        Me.colWastagePercentage.Name = "colWastagePercentage"
        Me.colWastagePercentage.Visible = True
        Me.colWastagePercentage.VisibleIndex = 4
        Me.colWastagePercentage.Width = 45
        '
        'colUnitId
        '
        Me.colUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitId.Caption = "Booking Unit"
        Me.colUnitId.ColumnEdit = Me.UnitLookUpEdit
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 7
        Me.colUnitId.Width = 49
        '
        'UnitLookUpEdit
        '
        Me.UnitLookUpEdit.AutoHeight = False
        Me.UnitLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitCode", "Unit Code", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "Unit Name", 59, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.UnitLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitLookUpEdit.DisplayMember = "UnitCode"
        Me.UnitLookUpEdit.Name = "UnitLookUpEdit"
        Me.UnitLookUpEdit.NullText = ""
        Me.UnitLookUpEdit.PopupFormMinSize = New System.Drawing.Size(150, 0)
        Me.UnitLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.UnitLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UnitLookUpEdit.ValueMember = "UnitId"
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
        'colItemId
        '
        Me.colItemId.Caption = "Item Name"
        Me.colItemId.ColumnEdit = Me.ItemNameGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 1
        Me.colItemId.Width = 236
        '
        'ItemNameGridLookUpEdit
        '
        Me.ItemNameGridLookUpEdit.AutoHeight = False
        Me.ItemNameGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemNameGridLookUpEdit.DataSource = Me.ItemListBindingSource
        Me.ItemNameGridLookUpEdit.DisplayMember = "ItemName"
        Me.ItemNameGridLookUpEdit.Name = "ItemNameGridLookUpEdit"
        Me.ItemNameGridLookUpEdit.NullText = ""
        Me.ItemNameGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemNameGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemNameGridLookUpEdit.ValueMember = "ItemId"
        Me.ItemNameGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListLookupDataSet
        '
        'ItemListLookupDataSet
        '
        Me.ItemListLookupDataSet.DataSetName = "ItemListLookupDataSet"
        Me.ItemListLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'colItemStyleId
        '
        Me.colItemStyleId.Caption = "Item Style"
        Me.colItemStyleId.ColumnEdit = Me.ItemStyleLookUpEdit
        Me.colItemStyleId.FieldName = "ItemStyleId"
        Me.colItemStyleId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colItemStyleId.Name = "colItemStyleId"
        Me.colItemStyleId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colItemStyleId.Width = 123
        '
        'ItemStyleLookUpEdit
        '
        Me.ItemStyleLookUpEdit.AutoHeight = False
        Me.ItemStyleLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemStyleLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemStyle", "Item Style", 59, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ItemStyleLookUpEdit.DataSource = Me.ItemStyleBindingSource
        Me.ItemStyleLookUpEdit.DisplayMember = "ItemStyle"
        Me.ItemStyleLookUpEdit.Name = "ItemStyleLookUpEdit"
        Me.ItemStyleLookUpEdit.NullText = ""
        Me.ItemStyleLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.ItemStyleLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemStyleLookUpEdit.ValueMember = "ItemStyleId"
        '
        'ItemStyleBindingSource
        '
        Me.ItemStyleBindingSource.DataMember = "ItemStyle"
        Me.ItemStyleBindingSource.DataSource = Me.ItemStyleDataSet
        '
        'ItemStyleDataSet
        '
        Me.ItemStyleDataSet.DataSetName = "ItemStyleDataSet"
        Me.ItemStyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colTemplateCategory
        '
        Me.colTemplateCategory.Caption = "Template Category"
        Me.colTemplateCategory.FieldName = "TemplateCategory"
        Me.colTemplateCategory.Name = "colTemplateCategory"
        Me.colTemplateCategory.Visible = True
        Me.colTemplateCategory.VisibleIndex = 0
        Me.colTemplateCategory.Width = 88
        '
        'colUnitPrice
        '
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 6
        Me.colUnitPrice.Width = 46
        '
        'colConUnitId
        '
        Me.colConUnitId.Caption = "Con Unit"
        Me.colConUnitId.ColumnEdit = Me.ConGridLookUpEdit
        Me.colConUnitId.FieldName = "ConUnitId"
        Me.colConUnitId.Name = "colConUnitId"
        Me.colConUnitId.Visible = True
        Me.colConUnitId.VisibleIndex = 3
        Me.colConUnitId.Width = 47
        '
        'ConGridLookUpEdit
        '
        Me.ConGridLookUpEdit.AutoHeight = False
        Me.ConGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ConGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.ConGridLookUpEdit.DisplayMember = "UnitCode"
        Me.ConGridLookUpEdit.Name = "ConGridLookUpEdit"
        Me.ConGridLookUpEdit.NullText = ""
        Me.ConGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ConGridLookUpEdit.ValueMember = "UnitId"
        Me.ConGridLookUpEdit.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitCode1, Me.colUnitName})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'BuyerComboBox
        '
        Me.BuyerComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerComboBox.DisplayMember = "BuyerName"
        Me.BuyerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BuyerComboBox.FormattingEnabled = True
        Me.BuyerComboBox.Location = New System.Drawing.Point(295, 2)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(134, 21)
        Me.BuyerComboBox.TabIndex = 2
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buyer"
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'ItemStyleTableAdapter
        '
        Me.ItemStyleTableAdapter.ClearBeforeFill = True
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataSource = Me.AccessoriesCategoryLookupBindingSource
        Me.CategoryComboBox.DisplayMember = "TemplateCategory"
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(488, 2)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(142, 21)
        Me.CategoryComboBox.TabIndex = 4
        Me.CategoryComboBox.ValueMember = "TemplateCategory"
        '
        'AccessoriesCategoryLookupBindingSource
        '
        Me.AccessoriesCategoryLookupBindingSource.DataMember = "AccessoriesCategoryLookup"
        Me.AccessoriesCategoryLookupBindingSource.DataSource = Me.AccessoriesCategoryLookupDataSet
        '
        'AccessoriesCategoryLookupDataSet
        '
        Me.AccessoriesCategoryLookupDataSet.DataSetName = "AccessoriesCategoryLookupDataSet"
        Me.AccessoriesCategoryLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(433, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Category"
        '
        'AccessoriesCategoryLookupTableAdapter
        '
        Me.AccessoriesCategoryLookupTableAdapter.ClearBeforeFill = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(636, 1)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 6
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'colUnitCode
        '
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Visible = True
        Me.colUnitCode.VisibleIndex = 0
        '
        'colConsumption
        '
        Me.colConsumption.FieldName = "Consumption"
        Me.colConsumption.Name = "colConsumption"
        Me.colConsumption.Visible = True
        Me.colConsumption.VisibleIndex = 2
        '
        'colForGMTQty
        '
        Me.colForGMTQty.FieldName = "ForGMTQty"
        Me.colForGMTQty.Name = "colForGMTQty"
        Me.colForGMTQty.Visible = True
        Me.colForGMTQty.VisibleIndex = 5
        '
        'colCostPerDzn
        '
        Me.colCostPerDzn.FieldName = "CostPerDzn"
        Me.colCostPerDzn.Name = "colCostPerDzn"
        '
        'colUnitCode1
        '
        Me.colUnitCode1.FieldName = "UnitCode"
        Me.colUnitCode1.Name = "colUnitCode1"
        Me.colUnitCode1.Visible = True
        Me.colUnitCode1.VisibleIndex = 0
        '
        'colUnitName
        '
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 1
        '
        'frmAccessoriesTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 464)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BuyerComboBox)
        Me.Controls.Add(Me.AccessoriesTemplateGridControl)
        Me.Controls.Add(Me.AccessoriesTemplateBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAccessoriesTemplate"
        Me.Text = "Accessories Template"
        CType(Me.AccessoriesTemplateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesTemplateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesTemplateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccessoriesTemplateBindingNavigator.ResumeLayout(False)
        Me.AccessoriesTemplateBindingNavigator.PerformLayout()
        CType(Me.AccessoriesTemplateGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesCategoryLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccessoriesTemplateDataSet As KSoft_Apparel.AccessoriesTemplateDataSet
    Friend WithEvents AccessoriesTemplateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesTemplateTableAdapter As KSoft_Apparel.AccessoriesTemplateDataSetTableAdapters.AccessoriesTemplateTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.AccessoriesTemplateDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccessoriesTemplateBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccessoriesTemplateBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccessoriesTemplateGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemStyleLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colIsCosting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPackType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWastagePercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemNameGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Apparel.ItemListLookupDataSet
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemStyleDataSet As KSoft_Apparel.ItemStyleDataSet
    Friend WithEvents ItemStyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemStyleTableAdapter As KSoft_Apparel.ItemStyleDataSetTableAdapters.ItemStyleTableAdapter
    Friend WithEvents colTemplateCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AccessoriesCategoryLookupDataSet As KSoft_Apparel.AccessoriesCategoryLookupDataSet
    Friend WithEvents AccessoriesCategoryLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesCategoryLookupTableAdapter As KSoft_Apparel.AccessoriesCategoryLookupDataSetTableAdapters.AccessoriesCategoryLookupTableAdapter
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ConGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsumption As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForGMTQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostPerDzn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
End Class
