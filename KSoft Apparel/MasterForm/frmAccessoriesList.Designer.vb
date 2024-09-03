<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessoriesList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccessoriesList))
        Me.ItemListDataSet = New KSoft_Apparel.ItemListDataSet
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListDataSetTableAdapters.ItemListTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.ItemListDataSetTableAdapters.TableAdapterManager
        Me.ItemListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ItemListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ItemListGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOriginId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBrandId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCategoryId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSubCategoryId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQuantityPerPacket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPreviousPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCurrentPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReorderLabel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExpireLabel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserLabel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colModifiedOn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPipelineQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPipeLineDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDollarPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccBuyerId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccItemStyleId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccItemStyle = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemListBindingNavigator.SuspendLayout()
        CType(Me.ItemListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ItemListLookupTableAdapter = Nothing
        Me.TableAdapterManager.ItemListTableAdapter = Me.ItemListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ItemListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ItemListBindingNavigator
        '
        Me.ItemListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ItemListBindingNavigator.BindingSource = Me.ItemListBindingSource
        Me.ItemListBindingNavigator.CountItem = Nothing
        Me.ItemListBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ItemListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ItemListBindingNavigatorSaveItem})
        Me.ItemListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ItemListBindingNavigator.MoveFirstItem = Nothing
        Me.ItemListBindingNavigator.MoveLastItem = Nothing
        Me.ItemListBindingNavigator.MoveNextItem = Nothing
        Me.ItemListBindingNavigator.MovePreviousItem = Nothing
        Me.ItemListBindingNavigator.Name = "ItemListBindingNavigator"
        Me.ItemListBindingNavigator.PositionItem = Nothing
        Me.ItemListBindingNavigator.Size = New System.Drawing.Size(1073, 25)
        Me.ItemListBindingNavigator.TabIndex = 0
        Me.ItemListBindingNavigator.Text = "BindingNavigator1"
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
        'ItemListBindingNavigatorSaveItem
        '
        Me.ItemListBindingNavigatorSaveItem.Image = CType(resources.GetObject("ItemListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ItemListBindingNavigatorSaveItem.Name = "ItemListBindingNavigatorSaveItem"
        Me.ItemListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.ItemListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ItemListGridControl
        '
        Me.ItemListGridControl.DataSource = Me.ItemListBindingSource
        Me.ItemListGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemListGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ItemListGridControl.MainView = Me.GridView1
        Me.ItemListGridControl.Name = "ItemListGridControl"
        Me.ItemListGridControl.Size = New System.Drawing.Size(1073, 563)
        Me.ItemListGridControl.TabIndex = 1
        Me.ItemListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colItemName, Me.colItemDescription, Me.colOriginId, Me.colBrandId, Me.colCategoryId, Me.colSubCategoryId, Me.colUnitId, Me.colQuantityPerPacket, Me.colPreviousPrice, Me.colCurrentPrice, Me.colDepartmentId, Me.colReorderLabel, Me.colExpireLabel, Me.colUserLabel, Me.colDiscontinue, Me.colUserId, Me.colModifiedOn, Me.colPipelineQuantity, Me.colPipeLineDate, Me.colDollarPrice, Me.colAccItemName, Me.colAccBuyerId, Me.colAccItemStyleId, Me.colAccItemStyle})
        Me.GridView1.GridControl = Me.ItemListGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSubCategoryId, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colItemId
        '
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsColumn.ReadOnly = True
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 2
        Me.colItemName.Width = 225
        '
        'colItemDescription
        '
        Me.colItemDescription.FieldName = "ItemDescription"
        Me.colItemDescription.Name = "colItemDescription"
        '
        'colOriginId
        '
        Me.colOriginId.FieldName = "OriginId"
        Me.colOriginId.Name = "colOriginId"
        '
        'colBrandId
        '
        Me.colBrandId.FieldName = "BrandId"
        Me.colBrandId.Name = "colBrandId"
        '
        'colCategoryId
        '
        Me.colCategoryId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCategoryId.AppearanceCell.Options.UseBackColor = True
        Me.colCategoryId.FieldName = "CategoryId"
        Me.colCategoryId.Name = "colCategoryId"
        Me.colCategoryId.Visible = True
        Me.colCategoryId.VisibleIndex = 0
        Me.colCategoryId.Width = 132
        '
        'colSubCategoryId
        '
        Me.colSubCategoryId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSubCategoryId.AppearanceCell.Options.UseBackColor = True
        Me.colSubCategoryId.FieldName = "SubCategoryId"
        Me.colSubCategoryId.Name = "colSubCategoryId"
        Me.colSubCategoryId.Visible = True
        Me.colSubCategoryId.VisibleIndex = 1
        Me.colSubCategoryId.Width = 113
        '
        'colUnitId
        '
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 6
        '
        'colQuantityPerPacket
        '
        Me.colQuantityPerPacket.FieldName = "QuantityPerPacket"
        Me.colQuantityPerPacket.Name = "colQuantityPerPacket"
        Me.colQuantityPerPacket.Width = 127
        '
        'colPreviousPrice
        '
        Me.colPreviousPrice.FieldName = "PreviousPrice"
        Me.colPreviousPrice.Name = "colPreviousPrice"
        Me.colPreviousPrice.Width = 94
        '
        'colCurrentPrice
        '
        Me.colCurrentPrice.FieldName = "CurrentPrice"
        Me.colCurrentPrice.Name = "colCurrentPrice"
        Me.colCurrentPrice.Visible = True
        Me.colCurrentPrice.VisibleIndex = 7
        Me.colCurrentPrice.Width = 100
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        Me.colDepartmentId.Width = 99
        '
        'colReorderLabel
        '
        Me.colReorderLabel.FieldName = "ReorderLabel"
        Me.colReorderLabel.Name = "colReorderLabel"
        '
        'colExpireLabel
        '
        Me.colExpireLabel.FieldName = "ExpireLabel"
        Me.colExpireLabel.Name = "colExpireLabel"
        '
        'colUserLabel
        '
        Me.colUserLabel.FieldName = "UserLabel"
        Me.colUserLabel.Name = "colUserLabel"
        '
        'colDiscontinue
        '
        Me.colDiscontinue.FieldName = "Discontinue"
        Me.colDiscontinue.Name = "colDiscontinue"
        Me.colDiscontinue.Visible = True
        Me.colDiscontinue.VisibleIndex = 8
        '
        'colUserId
        '
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        '
        'colModifiedOn
        '
        Me.colModifiedOn.FieldName = "ModifiedOn"
        Me.colModifiedOn.Name = "colModifiedOn"
        '
        'colPipelineQuantity
        '
        Me.colPipelineQuantity.FieldName = "PipelineQuantity"
        Me.colPipelineQuantity.Name = "colPipelineQuantity"
        '
        'colPipeLineDate
        '
        Me.colPipeLineDate.FieldName = "PipeLineDate"
        Me.colPipeLineDate.Name = "colPipeLineDate"
        '
        'colDollarPrice
        '
        Me.colDollarPrice.FieldName = "DollarPrice"
        Me.colDollarPrice.Name = "colDollarPrice"
        '
        'colAccItemName
        '
        Me.colAccItemName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colAccItemName.AppearanceCell.Options.UseBackColor = True
        Me.colAccItemName.FieldName = "AccItemName"
        Me.colAccItemName.Name = "colAccItemName"
        Me.colAccItemName.Visible = True
        Me.colAccItemName.VisibleIndex = 3
        Me.colAccItemName.Width = 97
        '
        'colAccBuyerId
        '
        Me.colAccBuyerId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colAccBuyerId.AppearanceCell.Options.UseBackColor = True
        Me.colAccBuyerId.FieldName = "AccBuyerId"
        Me.colAccBuyerId.Name = "colAccBuyerId"
        Me.colAccBuyerId.Visible = True
        Me.colAccBuyerId.VisibleIndex = 5
        Me.colAccBuyerId.Width = 111
        '
        'colAccItemStyleId
        '
        Me.colAccItemStyleId.FieldName = "AccItemStyleId"
        Me.colAccItemStyleId.Name = "colAccItemStyleId"
        '
        'colAccItemStyle
        '
        Me.colAccItemStyle.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colAccItemStyle.AppearanceCell.Options.UseBackColor = True
        Me.colAccItemStyle.FieldName = "AccItemStyle"
        Me.colAccItemStyle.Name = "colAccItemStyle"
        Me.colAccItemStyle.Visible = True
        Me.colAccItemStyle.VisibleIndex = 4
        Me.colAccItemStyle.Width = 124
        '
        'frmAccessoriesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 588)
        Me.Controls.Add(Me.ItemListGridControl)
        Me.Controls.Add(Me.ItemListBindingNavigator)
        Me.Name = "frmAccessoriesList"
        Me.Text = "Accessories List"
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemListBindingNavigator.ResumeLayout(False)
        Me.ItemListBindingNavigator.PerformLayout()
        CType(Me.ItemListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemListDataSet As KSoft_Apparel.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ItemListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItemListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItemListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubCategoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantityPerPacket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreviousPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReorderLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpireLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPipelineQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPipeLineDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDollarPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccItemStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccItemStyle As DevExpress.XtraGrid.Columns.GridColumn
End Class
