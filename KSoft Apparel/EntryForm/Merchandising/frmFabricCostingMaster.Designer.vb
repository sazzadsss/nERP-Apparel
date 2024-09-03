<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFabricCostingMaster
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFabricCostingMaster))
        Me.FabricCostingMasterDataSet = New KSoft_Apparel.FabricCostingMasterDataSet
        Me.FabricCostingMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricCostingMasterTableAdapter = New KSoft_Apparel.FabricCostingMasterDataSetTableAdapters.FabricCostingMasterTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.FabricCostingMasterDataSetTableAdapters.TableAdapterManager
        Me.FabricCostingMasterDetailsTableAdapter = New KSoft_Apparel.FabricCostingMasterDataSetTableAdapters.FabricCostingMasterDetailsTableAdapter
        Me.FabricCostingMasterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.FabricCostingMasterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FabricCostingMasterGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFabricCostingMasterId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKnittingTypeId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FabricTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKnittingTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKnittingType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKnittingTypeCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompositionId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CompositionGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCompositionId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colComposition = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiscontinue1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKnittingPrice_kg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYarnPrice_kg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDyeingPrice_kg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAOPPrice_Kg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDyeingType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DyeingTypeItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colGSMId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GSMLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFromGSM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colToGSM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FabricCostingMasterDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricCostingMasterDetailsGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFabricCostingMasterDetailsId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFabricCostingMasterId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemListGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Apparel.ItemListDataSet
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsagesPercentage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
        Me.ItemListLookupTableAdapter = New KSoft_Apparel.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
        CType(Me.FabricCostingMasterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricCostingMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricCostingMasterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FabricCostingMasterBindingNavigator.SuspendLayout()
        CType(Me.FabricCostingMasterGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricCostingMasterDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricCostingMasterDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FabricCostingMasterDataSet
        '
        Me.FabricCostingMasterDataSet.DataSetName = "FabricCostingMasterDataSet"
        Me.FabricCostingMasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricCostingMasterBindingSource
        '
        Me.FabricCostingMasterBindingSource.DataMember = "FabricCostingMaster"
        Me.FabricCostingMasterBindingSource.DataSource = Me.FabricCostingMasterDataSet
        '
        'FabricCostingMasterTableAdapter
        '
        Me.FabricCostingMasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FabricCostingMasterDetailsTableAdapter = Me.FabricCostingMasterDetailsTableAdapter
        Me.TableAdapterManager.FabricCostingMasterTableAdapter = Me.FabricCostingMasterTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FabricCostingMasterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FabricCostingMasterDetailsTableAdapter
        '
        Me.FabricCostingMasterDetailsTableAdapter.ClearBeforeFill = True
        '
        'FabricCostingMasterBindingNavigator
        '
        Me.FabricCostingMasterBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FabricCostingMasterBindingNavigator.BindingSource = Me.FabricCostingMasterBindingSource
        Me.FabricCostingMasterBindingNavigator.CountItem = Nothing
        Me.FabricCostingMasterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FabricCostingMasterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FabricCostingMasterBindingNavigatorSaveItem})
        Me.FabricCostingMasterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FabricCostingMasterBindingNavigator.MoveFirstItem = Nothing
        Me.FabricCostingMasterBindingNavigator.MoveLastItem = Nothing
        Me.FabricCostingMasterBindingNavigator.MoveNextItem = Nothing
        Me.FabricCostingMasterBindingNavigator.MovePreviousItem = Nothing
        Me.FabricCostingMasterBindingNavigator.Name = "FabricCostingMasterBindingNavigator"
        Me.FabricCostingMasterBindingNavigator.PositionItem = Nothing
        Me.FabricCostingMasterBindingNavigator.Size = New System.Drawing.Size(892, 25)
        Me.FabricCostingMasterBindingNavigator.TabIndex = 0
        Me.FabricCostingMasterBindingNavigator.Text = "BindingNavigator1"
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
        'FabricCostingMasterBindingNavigatorSaveItem
        '
        Me.FabricCostingMasterBindingNavigatorSaveItem.Image = CType(resources.GetObject("FabricCostingMasterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FabricCostingMasterBindingNavigatorSaveItem.Name = "FabricCostingMasterBindingNavigatorSaveItem"
        Me.FabricCostingMasterBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.FabricCostingMasterBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FabricCostingMasterGridControl
        '
        Me.FabricCostingMasterGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FabricCostingMasterGridControl.DataSource = Me.FabricCostingMasterBindingSource
        Me.FabricCostingMasterGridControl.Location = New System.Drawing.Point(0, 43)
        Me.FabricCostingMasterGridControl.MainView = Me.GridView1
        Me.FabricCostingMasterGridControl.Name = "FabricCostingMasterGridControl"
        Me.FabricCostingMasterGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.FabricTypeGridLookUpEdit, Me.CompositionGridLookUpEdit, Me.DyeingTypeItemLookUpEdit, Me.GSMLookUpEdit})
        Me.FabricCostingMasterGridControl.Size = New System.Drawing.Size(891, 204)
        Me.FabricCostingMasterGridControl.TabIndex = 1
        Me.FabricCostingMasterGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricCostingMasterId, Me.colKnittingTypeId, Me.colCompositionId, Me.colKnittingPrice_kg, Me.colYarnPrice_kg, Me.colDyeingPrice_kg, Me.colAOPPrice_Kg, Me.colRemarks, Me.colDyeingType, Me.colGSMId, Me.colFromGSM, Me.colToGSM})
        Me.GridView1.GridControl = Me.FabricCostingMasterGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFabricCostingMasterId
        '
        Me.colFabricCostingMasterId.FieldName = "FabricCostingMasterId"
        Me.colFabricCostingMasterId.Name = "colFabricCostingMasterId"
        Me.colFabricCostingMasterId.OptionsColumn.ReadOnly = True
        Me.colFabricCostingMasterId.Width = 143
        '
        'colKnittingTypeId
        '
        Me.colKnittingTypeId.Caption = "Fabric Type"
        Me.colKnittingTypeId.ColumnEdit = Me.FabricTypeGridLookUpEdit
        Me.colKnittingTypeId.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId.Name = "colKnittingTypeId"
        Me.colKnittingTypeId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colKnittingTypeId.Visible = True
        Me.colKnittingTypeId.VisibleIndex = 0
        Me.colKnittingTypeId.Width = 141
        '
        'FabricTypeGridLookUpEdit
        '
        Me.FabricTypeGridLookUpEdit.AutoHeight = False
        Me.FabricTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricTypeGridLookUpEdit.DataSource = Me.KnittingTypeBindingSource
        Me.FabricTypeGridLookUpEdit.DisplayMember = "KnittingType"
        Me.FabricTypeGridLookUpEdit.ImmediatePopup = True
        Me.FabricTypeGridLookUpEdit.Name = "FabricTypeGridLookUpEdit"
        Me.FabricTypeGridLookUpEdit.NullText = ""
        Me.FabricTypeGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FabricTypeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricTypeGridLookUpEdit.ValueMember = "KnittingTypeId"
        Me.FabricTypeGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'KnittingTypeBindingSource
        '
        Me.KnittingTypeBindingSource.DataMember = "KnittingType"
        Me.KnittingTypeBindingSource.DataSource = Me.KnittingTypeDataSet
        '
        'KnittingTypeDataSet
        '
        Me.KnittingTypeDataSet.DataSetName = "KnittingTypeDataSet"
        Me.KnittingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingTypeId1, Me.colKnittingType, Me.colDiscontinue, Me.colKnittingTypeCode})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colKnittingTypeId1
        '
        Me.colKnittingTypeId1.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId1.Name = "colKnittingTypeId1"
        Me.colKnittingTypeId1.OptionsColumn.ReadOnly = True
        '
        'colKnittingType
        '
        Me.colKnittingType.FieldName = "KnittingType"
        Me.colKnittingType.Name = "colKnittingType"
        Me.colKnittingType.Visible = True
        Me.colKnittingType.VisibleIndex = 0
        '
        'colDiscontinue
        '
        Me.colDiscontinue.FieldName = "Discontinue"
        Me.colDiscontinue.Name = "colDiscontinue"
        '
        'colKnittingTypeCode
        '
        Me.colKnittingTypeCode.FieldName = "KnittingTypeCode"
        Me.colKnittingTypeCode.Name = "colKnittingTypeCode"
        '
        'colCompositionId
        '
        Me.colCompositionId.Caption = "Composition"
        Me.colCompositionId.ColumnEdit = Me.CompositionGridLookUpEdit
        Me.colCompositionId.FieldName = "CompositionId"
        Me.colCompositionId.Name = "colCompositionId"
        Me.colCompositionId.Visible = True
        Me.colCompositionId.VisibleIndex = 1
        Me.colCompositionId.Width = 160
        '
        'CompositionGridLookUpEdit
        '
        Me.CompositionGridLookUpEdit.AutoHeight = False
        Me.CompositionGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompositionGridLookUpEdit.DataSource = Me.CompositionBindingSource
        Me.CompositionGridLookUpEdit.DisplayMember = "Composition"
        Me.CompositionGridLookUpEdit.ImmediatePopup = True
        Me.CompositionGridLookUpEdit.Name = "CompositionGridLookUpEdit"
        Me.CompositionGridLookUpEdit.NullText = ""
        Me.CompositionGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CompositionGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CompositionGridLookUpEdit.ValueMember = "CompositionId"
        Me.CompositionGridLookUpEdit.View = Me.GridView3
        '
        'CompositionBindingSource
        '
        Me.CompositionBindingSource.DataMember = "Composition"
        Me.CompositionBindingSource.DataSource = Me.CompositionDataSet
        '
        'CompositionDataSet
        '
        Me.CompositionDataSet.DataSetName = "CompositionDataSet"
        Me.CompositionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompositionId1, Me.colComposition, Me.colDiscontinue1, Me.colCode})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colCompositionId1
        '
        Me.colCompositionId1.FieldName = "CompositionId"
        Me.colCompositionId1.Name = "colCompositionId1"
        '
        'colComposition
        '
        Me.colComposition.FieldName = "Composition"
        Me.colComposition.Name = "colComposition"
        Me.colComposition.Visible = True
        Me.colComposition.VisibleIndex = 0
        '
        'colDiscontinue1
        '
        Me.colDiscontinue1.FieldName = "Discontinue"
        Me.colDiscontinue1.Name = "colDiscontinue1"
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        '
        'colKnittingPrice_kg
        '
        Me.colKnittingPrice_kg.FieldName = "KnittingPrice_kg"
        Me.colKnittingPrice_kg.Name = "colKnittingPrice_kg"
        Me.colKnittingPrice_kg.Visible = True
        Me.colKnittingPrice_kg.VisibleIndex = 5
        Me.colKnittingPrice_kg.Width = 106
        '
        'colYarnPrice_kg
        '
        Me.colYarnPrice_kg.FieldName = "YarnPrice_kg"
        Me.colYarnPrice_kg.Name = "colYarnPrice_kg"
        Me.colYarnPrice_kg.Visible = True
        Me.colYarnPrice_kg.VisibleIndex = 4
        Me.colYarnPrice_kg.Width = 94
        '
        'colDyeingPrice_kg
        '
        Me.colDyeingPrice_kg.FieldName = "DyeingPrice_kg"
        Me.colDyeingPrice_kg.Name = "colDyeingPrice_kg"
        Me.colDyeingPrice_kg.Width = 91
        '
        'colAOPPrice_Kg
        '
        Me.colAOPPrice_Kg.FieldName = "AOPPrice_Kg"
        Me.colAOPPrice_Kg.Name = "colAOPPrice_Kg"
        Me.colAOPPrice_Kg.Visible = True
        Me.colAOPPrice_Kg.VisibleIndex = 6
        Me.colAOPPrice_Kg.Width = 91
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 7
        Me.colRemarks.Width = 134
        '
        'colDyeingType
        '
        Me.colDyeingType.ColumnEdit = Me.DyeingTypeItemLookUpEdit
        Me.colDyeingType.FieldName = "DyeingType"
        Me.colDyeingType.Name = "colDyeingType"
        Me.colDyeingType.Width = 87
        '
        'DyeingTypeItemLookUpEdit
        '
        Me.DyeingTypeItemLookUpEdit.AutoHeight = False
        Me.DyeingTypeItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DyeingTypeItemLookUpEdit.Name = "DyeingTypeItemLookUpEdit"
        Me.DyeingTypeItemLookUpEdit.NullText = ""
        '
        'colGSMId
        '
        Me.colGSMId.Caption = "GSM"
        Me.colGSMId.ColumnEdit = Me.GSMLookUpEdit
        Me.colGSMId.FieldName = "GSMId"
        Me.colGSMId.Name = "colGSMId"
        '
        'GSMLookUpEdit
        '
        Me.GSMLookUpEdit.AutoHeight = False
        Me.GSMLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GSMLookUpEdit.Name = "GSMLookUpEdit"
        Me.GSMLookUpEdit.NullText = ""
        '
        'colFromGSM
        '
        Me.colFromGSM.FieldName = "FromGSM"
        Me.colFromGSM.Name = "colFromGSM"
        Me.colFromGSM.Visible = True
        Me.colFromGSM.VisibleIndex = 2
        Me.colFromGSM.Width = 55
        '
        'colToGSM
        '
        Me.colToGSM.FieldName = "ToGSM"
        Me.colToGSM.Name = "colToGSM"
        Me.colToGSM.Visible = True
        Me.colToGSM.VisibleIndex = 3
        Me.colToGSM.Width = 45
        '
        'FabricCostingMasterDetailsBindingSource
        '
        Me.FabricCostingMasterDetailsBindingSource.DataMember = "FK_FabricCostingMasterDetails_FabricCostingMaster"
        Me.FabricCostingMasterDetailsBindingSource.DataSource = Me.FabricCostingMasterBindingSource
        '
        'FabricCostingMasterDetailsGridControl
        '
        Me.FabricCostingMasterDetailsGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FabricCostingMasterDetailsGridControl.DataSource = Me.FabricCostingMasterDetailsBindingSource
        Me.FabricCostingMasterDetailsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.FabricCostingMasterDetailsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.FabricCostingMasterDetailsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.FabricCostingMasterDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.FabricCostingMasterDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.FabricCostingMasterDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.FabricCostingMasterDetailsGridControl.Location = New System.Drawing.Point(0, 264)
        Me.FabricCostingMasterDetailsGridControl.MainView = Me.GridView2
        Me.FabricCostingMasterDetailsGridControl.Name = "FabricCostingMasterDetailsGridControl"
        Me.FabricCostingMasterDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemListGridLookUpEdit})
        Me.FabricCostingMasterDetailsGridControl.Size = New System.Drawing.Size(891, 233)
        Me.FabricCostingMasterDetailsGridControl.TabIndex = 2
        Me.FabricCostingMasterDetailsGridControl.UseEmbeddedNavigator = True
        Me.FabricCostingMasterDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView2.ColumnPanelRowHeight = 40
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricCostingMasterDetailsId, Me.colFabricCostingMasterId1, Me.colItemId, Me.colUsagesPercentage, Me.colRemarks1})
        Me.GridView2.GridControl = Me.FabricCostingMasterDetailsGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFabricCostingMasterDetailsId
        '
        Me.colFabricCostingMasterDetailsId.FieldName = "FabricCostingMasterDetailsId"
        Me.colFabricCostingMasterDetailsId.Name = "colFabricCostingMasterDetailsId"
        Me.colFabricCostingMasterDetailsId.OptionsColumn.ReadOnly = True
        '
        'colFabricCostingMasterId1
        '
        Me.colFabricCostingMasterId1.FieldName = "FabricCostingMasterId"
        Me.colFabricCostingMasterId1.Name = "colFabricCostingMasterId1"
        '
        'colItemId
        '
        Me.colItemId.Caption = "Yarn Name"
        Me.colItemId.ColumnEdit = Me.ItemListGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 346
        '
        'ItemListGridLookUpEdit
        '
        Me.ItemListGridLookUpEdit.AutoHeight = False
        Me.ItemListGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemListGridLookUpEdit.DataSource = Me.ItemListLookupBindingSource
        Me.ItemListGridLookUpEdit.DisplayMember = "ItemName"
        Me.ItemListGridLookUpEdit.ImmediatePopup = True
        Me.ItemListGridLookUpEdit.Name = "ItemListGridLookUpEdit"
        Me.ItemListGridLookUpEdit.NullText = ""
        Me.ItemListGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemListGridLookUpEdit.ValueMember = "ItemId"
        Me.ItemListGridLookUpEdit.View = Me.GridView4
        '
        'ItemListLookupBindingSource
        '
        Me.ItemListLookupBindingSource.DataMember = "ItemListLookup"
        Me.ItemListLookupBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId1, Me.colItemName, Me.colDepartmentId, Me.GridColumn1})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colItemId1
        '
        Me.colItemId1.FieldName = "ItemId"
        Me.colItemId1.Name = "colItemId1"
        Me.colItemId1.OptionsColumn.ReadOnly = True
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID-Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'colUsagesPercentage
        '
        Me.colUsagesPercentage.FieldName = "UsagesPercentage"
        Me.colUsagesPercentage.Name = "colUsagesPercentage"
        Me.colUsagesPercentage.Visible = True
        Me.colUsagesPercentage.VisibleIndex = 1
        Me.colUsagesPercentage.Width = 135
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 2
        Me.colRemarks1.Width = 478
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'frmFabricCostingMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 500)
        Me.Controls.Add(Me.FabricCostingMasterDetailsGridControl)
        Me.Controls.Add(Me.FabricCostingMasterGridControl)
        Me.Controls.Add(Me.FabricCostingMasterBindingNavigator)
        Me.Name = "frmFabricCostingMaster"
        Me.Text = "Fabric Costing Master"
        CType(Me.FabricCostingMasterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricCostingMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricCostingMasterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FabricCostingMasterBindingNavigator.ResumeLayout(False)
        Me.FabricCostingMasterBindingNavigator.PerformLayout()
        CType(Me.FabricCostingMasterGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricCostingMasterDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricCostingMasterDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FabricCostingMasterDataSet As KSoft_Apparel.FabricCostingMasterDataSet
    Friend WithEvents FabricCostingMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricCostingMasterTableAdapter As KSoft_Apparel.FabricCostingMasterDataSetTableAdapters.FabricCostingMasterTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FabricCostingMasterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FabricCostingMasterBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FabricCostingMasterBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FabricCostingMasterGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricCostingMasterId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompositionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingPrice_kg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnPrice_kg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDyeingPrice_kg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAOPPrice_Kg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricCostingMasterDetailsTableAdapter As KSoft_Apparel.FabricCostingMasterDataSetTableAdapters.FabricCostingMasterDetailsTableAdapter
    Friend WithEvents FabricCostingMasterDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricCostingMasterDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricCostingMasterDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricCostingMasterId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsagesPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents CompositionGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents ItemListGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDataSet As KSoft_Apparel.ItemListDataSet
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Apparel.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents colKnittingTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompositionId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDyeingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DyeingTypeItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colGSMId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSMLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFromGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToGSM As DevExpress.XtraGrid.Columns.GridColumn
End Class
