<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtherPrintCosting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOtherPrintCosting))
        Me.OthersPrintCostDataSet = New KSoft_Apparel.OthersPrintCostDataSet
        Me.OthersPrintCostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OthersPrintCostTableAdapter = New KSoft_Apparel.OthersPrintCostDataSetTableAdapters.OthersPrintCostTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.OthersPrintCostDataSetTableAdapters.TableAdapterManager
        Me.OthersPrintCostBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.OthersPrintCostBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.OthersPrintCostGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOtherPrintCostId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRecipeId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Apparel.ItemListLookupDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colUnitId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
        CType(Me.OthersPrintCostDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OthersPrintCostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OthersPrintCostBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OthersPrintCostBindingNavigator.SuspendLayout()
        CType(Me.OthersPrintCostGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OthersPrintCostDataSet
        '
        Me.OthersPrintCostDataSet.DataSetName = "OthersPrintCostDataSet"
        Me.OthersPrintCostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OthersPrintCostBindingSource
        '
        Me.OthersPrintCostBindingSource.DataMember = "OthersPrintCost"
        Me.OthersPrintCostBindingSource.DataSource = Me.OthersPrintCostDataSet
        '
        'OthersPrintCostTableAdapter
        '
        Me.OthersPrintCostTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OthersPrintCostTableAdapter = Me.OthersPrintCostTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.OthersPrintCostDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OthersPrintCostBindingNavigator
        '
        Me.OthersPrintCostBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OthersPrintCostBindingNavigator.BindingSource = Me.OthersPrintCostBindingSource
        Me.OthersPrintCostBindingNavigator.CountItem = Nothing
        Me.OthersPrintCostBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OthersPrintCostBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorDeleteItem, Me.BindingNavigatorAddNewItem, Me.OthersPrintCostBindingNavigatorSaveItem})
        Me.OthersPrintCostBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OthersPrintCostBindingNavigator.MoveFirstItem = Nothing
        Me.OthersPrintCostBindingNavigator.MoveLastItem = Nothing
        Me.OthersPrintCostBindingNavigator.MoveNextItem = Nothing
        Me.OthersPrintCostBindingNavigator.MovePreviousItem = Nothing
        Me.OthersPrintCostBindingNavigator.Name = "OthersPrintCostBindingNavigator"
        Me.OthersPrintCostBindingNavigator.PositionItem = Nothing
        Me.OthersPrintCostBindingNavigator.Size = New System.Drawing.Size(786, 25)
        Me.OthersPrintCostBindingNavigator.TabIndex = 0
        Me.OthersPrintCostBindingNavigator.Text = "BindingNavigator1"
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
        'OthersPrintCostBindingNavigatorSaveItem
        '
        Me.OthersPrintCostBindingNavigatorSaveItem.Image = CType(resources.GetObject("OthersPrintCostBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OthersPrintCostBindingNavigatorSaveItem.Name = "OthersPrintCostBindingNavigatorSaveItem"
        Me.OthersPrintCostBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.OthersPrintCostBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OthersPrintCostGridControl
        '
        Me.OthersPrintCostGridControl.DataSource = Me.OthersPrintCostBindingSource
        Me.OthersPrintCostGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OthersPrintCostGridControl.Location = New System.Drawing.Point(0, 25)
        Me.OthersPrintCostGridControl.MainView = Me.GridView1
        Me.OthersPrintCostGridControl.Name = "OthersPrintCostGridControl"
        Me.OthersPrintCostGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2})
        Me.OthersPrintCostGridControl.Size = New System.Drawing.Size(786, 300)
        Me.OthersPrintCostGridControl.TabIndex = 1
        Me.OthersPrintCostGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOtherPrintCostId, Me.colRecipeId, Me.colItemId, Me.colUnitId, Me.colUnitPrice, Me.colQuantity, Me.colTotalCost})
        Me.GridView1.GridControl = Me.OthersPrintCostGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colOtherPrintCostId
        '
        Me.colOtherPrintCostId.FieldName = "OtherPrintCostId"
        Me.colOtherPrintCostId.Name = "colOtherPrintCostId"
        Me.colOtherPrintCostId.OptionsColumn.ReadOnly = True
        Me.colOtherPrintCostId.Width = 128
        '
        'colRecipeId
        '
        Me.colRecipeId.Caption = "Recipe"
        Me.colRecipeId.FieldName = "RecipeId"
        Me.colRecipeId.Name = "colRecipeId"
        Me.colRecipeId.Width = 132
        '
        'colItemId
        '
        Me.colItemId.Caption = "Item"
        Me.colItemId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 225
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.ItemListBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "ItemName"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "ItemId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
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
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId1, Me.colItemName, Me.colDepartmentId})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        'colUnitId
        '
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 1
        Me.colUnitId.Width = 60
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.UnitBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "UnitCode"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "UnitId"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
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
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId1, Me.colUnitCode, Me.colUnitName})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
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
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 1
        '
        'colUnitPrice
        '
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 2
        '
        'colQuantity
        '
        Me.colQuantity.Caption = "Quantity"
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 3
        '
        'colTotalCost
        '
        Me.colTotalCost.Caption = "Total Cost (TK)"
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.Visible = True
        Me.colTotalCost.VisibleIndex = 4
        Me.colTotalCost.Width = 330
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'frmOtherPrintCosting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 325)
        Me.Controls.Add(Me.OthersPrintCostGridControl)
        Me.Controls.Add(Me.OthersPrintCostBindingNavigator)
        Me.Name = "frmOtherPrintCosting"
        Me.Text = "Others Print Costing"
        CType(Me.OthersPrintCostDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OthersPrintCostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OthersPrintCostBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OthersPrintCostBindingNavigator.ResumeLayout(False)
        Me.OthersPrintCostBindingNavigator.PerformLayout()
        CType(Me.OthersPrintCostGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OthersPrintCostDataSet As KSoft_Apparel.OthersPrintCostDataSet
    Friend WithEvents OthersPrintCostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OthersPrintCostTableAdapter As KSoft_Apparel.OthersPrintCostDataSetTableAdapters.OthersPrintCostTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.OthersPrintCostDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OthersPrintCostBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OthersPrintCostBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OthersPrintCostGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOtherPrintCostId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecipeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Apparel.ItemListLookupDataSet
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents colUnitId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
End Class
