<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCutPanelRejection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCutPanelRejection))
        Me.CutPanelRejectionDataSet = New KSoft_Apparel.CutPanelRejectionDataSet
        Me.CuttingCutPanelRejectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingCutPanelRejectionTableAdapter = New KSoft_Apparel.CutPanelRejectionDataSetTableAdapters.CuttingCutPanelRejectionTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.CutPanelRejectionDataSetTableAdapters.TableAdapterManager
        Me.CuttingCutPanelRejectionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.CuttingCutPanelRejectionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.CuttingCutPanelRejectionGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCutPanelRejectionId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.OrderGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FabricColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCuttingNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRejectionType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colRejectionQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRejectionCategory = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RejectionCategoryComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.RejectionTypeGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RejectionTypeLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
        Me.Label4 = New System.Windows.Forms.Label
        Me.OrderNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsMultiPart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.FabricColorComboBox = New System.Windows.Forms.ComboBox
        CType(Me.CutPanelRejectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingCutPanelRejectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingCutPanelRejectionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuttingCutPanelRejectionBindingNavigator.SuspendLayout()
        CType(Me.CuttingCutPanelRejectionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejectionCategoryComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejectionTypeGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RejectionTypeLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CutPanelRejectionDataSet
        '
        Me.CutPanelRejectionDataSet.DataSetName = "CutPanelRejectionDataSet"
        Me.CutPanelRejectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuttingCutPanelRejectionBindingSource
        '
        Me.CuttingCutPanelRejectionBindingSource.DataMember = "CuttingCutPanelRejection"
        Me.CuttingCutPanelRejectionBindingSource.DataSource = Me.CutPanelRejectionDataSet
        '
        'CuttingCutPanelRejectionTableAdapter
        '
        Me.CuttingCutPanelRejectionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuttingCutPanelRejectionTableAdapter = Me.CuttingCutPanelRejectionTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CutPanelRejectionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CuttingCutPanelRejectionBindingNavigator
        '
        Me.CuttingCutPanelRejectionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CuttingCutPanelRejectionBindingNavigator.BindingSource = Me.CuttingCutPanelRejectionBindingSource
        Me.CuttingCutPanelRejectionBindingNavigator.CountItem = Nothing
        Me.CuttingCutPanelRejectionBindingNavigator.DeleteItem = Nothing
        Me.CuttingCutPanelRejectionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.CuttingCutPanelRejectionBindingNavigatorSaveItem})
        Me.CuttingCutPanelRejectionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CuttingCutPanelRejectionBindingNavigator.MoveFirstItem = Nothing
        Me.CuttingCutPanelRejectionBindingNavigator.MoveLastItem = Nothing
        Me.CuttingCutPanelRejectionBindingNavigator.MoveNextItem = Nothing
        Me.CuttingCutPanelRejectionBindingNavigator.MovePreviousItem = Nothing
        Me.CuttingCutPanelRejectionBindingNavigator.Name = "CuttingCutPanelRejectionBindingNavigator"
        Me.CuttingCutPanelRejectionBindingNavigator.PositionItem = Nothing
        Me.CuttingCutPanelRejectionBindingNavigator.Size = New System.Drawing.Size(802, 25)
        Me.CuttingCutPanelRejectionBindingNavigator.TabIndex = 4
        Me.CuttingCutPanelRejectionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(97, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new (F3)"
        '
        'CuttingCutPanelRejectionBindingNavigatorSaveItem
        '
        Me.CuttingCutPanelRejectionBindingNavigatorSaveItem.Image = CType(resources.GetObject("CuttingCutPanelRejectionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CuttingCutPanelRejectionBindingNavigatorSaveItem.Name = "CuttingCutPanelRejectionBindingNavigatorSaveItem"
        Me.CuttingCutPanelRejectionBindingNavigatorSaveItem.Size = New System.Drawing.Size(107, 22)
        Me.CuttingCutPanelRejectionBindingNavigatorSaveItem.Text = "Save Data {F12)"
        '
        'CuttingCutPanelRejectionGridControl
        '
        Me.CuttingCutPanelRejectionGridControl.DataSource = Me.CuttingCutPanelRejectionBindingSource
        Me.CuttingCutPanelRejectionGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CuttingCutPanelRejectionGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.CuttingCutPanelRejectionGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.CuttingCutPanelRejectionGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.CuttingCutPanelRejectionGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.CuttingCutPanelRejectionGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.CuttingCutPanelRejectionGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.CuttingCutPanelRejectionGridControl.Location = New System.Drawing.Point(0, 25)
        Me.CuttingCutPanelRejectionGridControl.MainView = Me.GridView1
        Me.CuttingCutPanelRejectionGridControl.Name = "CuttingCutPanelRejectionGridControl"
        Me.CuttingCutPanelRejectionGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.OrderGridLookUpEdit, Me.FabricColorGridLookUpEdit, Me.RejectionTypeGridLookUpEdit1, Me.RejectionTypeLookUpEdit, Me.RepositoryItemComboBox1, Me.RejectionCategoryComboBox})
        Me.CuttingCutPanelRejectionGridControl.Size = New System.Drawing.Size(802, 451)
        Me.CuttingCutPanelRejectionGridControl.TabIndex = 2
        Me.CuttingCutPanelRejectionGridControl.UseEmbeddedNavigator = True
        Me.CuttingCutPanelRejectionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCutPanelRejectionId, Me.colOrderId, Me.colFabricColorId, Me.colCuttingNo, Me.colRejectionType, Me.colRejectionQuantity, Me.colRejectionCategory})
        Me.GridView1.GridControl = Me.CuttingCutPanelRejectionGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCutPanelRejectionId
        '
        Me.colCutPanelRejectionId.FieldName = "CutPanelRejectionId"
        Me.colCutPanelRejectionId.Name = "colCutPanelRejectionId"
        Me.colCutPanelRejectionId.OptionsColumn.ReadOnly = True
        '
        'colOrderId
        '
        Me.colOrderId.Caption = "Program No"
        Me.colOrderId.ColumnEdit = Me.OrderGridLookUpEdit
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.AllowEdit = False
        Me.colOrderId.OptionsColumn.ReadOnly = True
        Me.colOrderId.Visible = True
        Me.colOrderId.VisibleIndex = 0
        Me.colOrderId.Width = 96
        '
        'OrderGridLookUpEdit
        '
        Me.OrderGridLookUpEdit.AutoHeight = False
        Me.OrderGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderGridLookUpEdit.DataSource = Me.OrderLookupBindingSource
        Me.OrderGridLookUpEdit.DisplayMember = "ProgramNo"
        Me.OrderGridLookUpEdit.Name = "OrderGridLookUpEdit"
        Me.OrderGridLookUpEdit.NullText = ""
        Me.OrderGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderGridLookUpEdit.ValueMember = "OrderId"
        Me.OrderGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorId
        '
        Me.colFabricColorId.Caption = "Color"
        Me.colFabricColorId.ColumnEdit = Me.FabricColorGridLookUpEdit
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.OptionsColumn.AllowEdit = False
        Me.colFabricColorId.OptionsColumn.ReadOnly = True
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 1
        Me.colFabricColorId.Width = 178
        '
        'FabricColorGridLookUpEdit
        '
        Me.FabricColorGridLookUpEdit.AutoHeight = False
        Me.FabricColorGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricColorGridLookUpEdit.DataSource = Me.OrderFabricColorBindingSource
        Me.FabricColorGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.FabricColorGridLookUpEdit.Name = "FabricColorGridLookUpEdit"
        Me.FabricColorGridLookUpEdit.ValueMember = "FabricColorId"
        Me.FabricColorGridLookUpEdit.View = Me.GridView3
        '
        'OrderFabricColorBindingSource
        '
        Me.OrderFabricColorBindingSource.DataMember = "OrderFabricColor"
        Me.OrderFabricColorBindingSource.DataSource = Me.OrderFabricColorDataSet
        '
        'OrderFabricColorDataSet
        '
        Me.OrderFabricColorDataSet.DataSetName = "OrderFabricColorDataSet"
        Me.OrderFabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colCuttingNo
        '
        Me.colCuttingNo.FieldName = "CuttingNo"
        Me.colCuttingNo.Name = "colCuttingNo"
        Me.colCuttingNo.Visible = True
        Me.colCuttingNo.VisibleIndex = 2
        Me.colCuttingNo.Width = 91
        '
        'colRejectionType
        '
        Me.colRejectionType.Caption = "Rejection Type"
        Me.colRejectionType.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colRejectionType.FieldName = "RejectionType"
        Me.colRejectionType.Name = "colRejectionType"
        Me.colRejectionType.Visible = True
        Me.colRejectionType.VisibleIndex = 3
        Me.colRejectionType.Width = 207
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.RepositoryItemComboBox1.ImmediatePopup = True
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"PIN HOLE/ KNT. HOLE/NDL MARK [KNITTING]", "FOREIGN YARN /CONTRA [KNITTING]", "YARN LYCRA/MISSING [KNITTING]", "SLAB/LOOP/KNOT [KNITTING]", "OTHERS [KNITTING]", "GSM HOLE/ROOL JOINT [DYEING]", "DYE/CHEM SPOT [DYEING]", "LINE/CRASE/DIA MARK [DYEING]", "UNEVEN DIA [DYEING]", "OTHERS [DYEING]", "WRONG SHAPE [CUTTING]", "MARKER PROBLEM [CAD]", "PRINT [RPINT]", "", ""})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.PopupSizeable = True
        '
        'colRejectionQuantity
        '
        Me.colRejectionQuantity.FieldName = "RejectionQuantity"
        Me.colRejectionQuantity.Name = "colRejectionQuantity"
        Me.colRejectionQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colRejectionQuantity.Visible = True
        Me.colRejectionQuantity.VisibleIndex = 5
        Me.colRejectionQuantity.Width = 105
        '
        'colRejectionCategory
        '
        Me.colRejectionCategory.ColumnEdit = Me.RejectionCategoryComboBox
        Me.colRejectionCategory.FieldName = "RejectionCategory"
        Me.colRejectionCategory.Name = "colRejectionCategory"
        Me.colRejectionCategory.Visible = True
        Me.colRejectionCategory.VisibleIndex = 4
        Me.colRejectionCategory.Width = 104
        '
        'RejectionCategoryComboBox
        '
        Me.RejectionCategoryComboBox.AutoHeight = False
        Me.RejectionCategoryComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RejectionCategoryComboBox.Items.AddRange(New Object() {"Knitting", "Dyeing", "Cutting", "Printing"})
        Me.RejectionCategoryComboBox.Name = "RejectionCategoryComboBox"
        '
        'RejectionTypeGridLookUpEdit1
        '
        Me.RejectionTypeGridLookUpEdit1.AutoHeight = False
        Me.RejectionTypeGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RejectionTypeGridLookUpEdit1.Name = "RejectionTypeGridLookUpEdit1"
        Me.RejectionTypeGridLookUpEdit1.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'RejectionTypeLookUpEdit
        '
        Me.RejectionTypeLookUpEdit.AutoHeight = False
        Me.RejectionTypeLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RejectionTypeLookUpEdit.Name = "RejectionTypeLookUpEdit"
        Me.RejectionTypeLookUpEdit.NullText = ""
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.CuttingCutPanelRejectionGridControl
        Me.GridView2.Name = "GridView2"
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 8, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Program No"
        '
        'OrderNoGridLookUpEdit
        '
        Me.OrderNoGridLookUpEdit.Location = New System.Drawing.Point(317, 2)
        Me.OrderNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.OrderNoGridLookUpEdit.Name = "OrderNoGridLookUpEdit"
        Me.OrderNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.OrderNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderNoGridLookUpEdit.Properties.NullText = ""
        Me.OrderNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.OrderNoGridLookUpEdit.Size = New System.Drawing.Size(118, 20)
        Me.OrderNoGridLookUpEdit.TabIndex = 0
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colProgramNo, Me.colIsPrint, Me.colUserId, Me.colIsMultiPart})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "OrderId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        Me.colIsPrint.Visible = True
        Me.colIsPrint.VisibleIndex = 1
        '
        'colUserId
        '
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        '
        'colIsMultiPart
        '
        Me.colIsMultiPart.FieldName = "IsMultiPart"
        Me.colIsMultiPart.Name = "colIsMultiPart"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(442, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 9, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Color"
        '
        'FabricColorComboBox
        '
        Me.FabricColorComboBox.DataSource = Me.OrderFabricColorBindingSource
        Me.FabricColorComboBox.DisplayMember = "FabricColorName"
        Me.FabricColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FabricColorComboBox.FormattingEnabled = True
        Me.FabricColorComboBox.Location = New System.Drawing.Point(481, 2)
        Me.FabricColorComboBox.Margin = New System.Windows.Forms.Padding(5, 5, 3, 3)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(173, 21)
        Me.FabricColorComboBox.TabIndex = 1
        Me.FabricColorComboBox.ValueMember = "FabricColorId"
        '
        'frmCutPanelRejection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 476)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FabricColorComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.OrderNoGridLookUpEdit)
        Me.Controls.Add(Me.CuttingCutPanelRejectionGridControl)
        Me.Controls.Add(Me.CuttingCutPanelRejectionBindingNavigator)
        Me.KeyPreview = True
        Me.Name = "frmCutPanelRejection"
        Me.Text = "Cut Panel Rejection"
        CType(Me.CutPanelRejectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingCutPanelRejectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingCutPanelRejectionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuttingCutPanelRejectionBindingNavigator.ResumeLayout(False)
        Me.CuttingCutPanelRejectionBindingNavigator.PerformLayout()
        CType(Me.CuttingCutPanelRejectionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejectionCategoryComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejectionTypeGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RejectionTypeLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CutPanelRejectionDataSet As KSoft_Apparel.CutPanelRejectionDataSet
    Friend WithEvents CuttingCutPanelRejectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuttingCutPanelRejectionTableAdapter As KSoft_Apparel.CutPanelRejectionDataSetTableAdapters.CuttingCutPanelRejectionTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CutPanelRejectionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CuttingCutPanelRejectionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CuttingCutPanelRejectionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CuttingCutPanelRejectionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCutPanelRejectionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuttingNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRejectionType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRejectionQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents FabricColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents RejectionTypeLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RejectionTypeGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OrderNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMultiPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FabricColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colRejectionCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RejectionCategoryComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
