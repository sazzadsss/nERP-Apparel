<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionType))
        Me.ProductionTypeDataSet = New KSoft_Apparel.ProductionTypeDataSet()
        Me.ProductionTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionTypeTableAdapter = New KSoft_Apparel.ProductionTypeDataSetTableAdapters.ProductionTypeTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.ProductionTypeDataSetTableAdapters.TableAdapterManager()
        Me.ProductionTypeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ProductionTypeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductionTypeGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductionType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTargetQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        CType(Me.ProductionTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionTypeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductionTypeBindingNavigator.SuspendLayout()
        CType(Me.ProductionTypeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductionTypeDataSet
        '
        Me.ProductionTypeDataSet.DataSetName = "ProductionTypeDataSet"
        Me.ProductionTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductionTypeBindingSource
        '
        Me.ProductionTypeBindingSource.DataMember = "ProductionType"
        Me.ProductionTypeBindingSource.DataSource = Me.ProductionTypeDataSet
        '
        'ProductionTypeTableAdapter
        '
        Me.ProductionTypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductionTypeTableAdapter = Me.ProductionTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ProductionTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductionTypeBindingNavigator
        '
        Me.ProductionTypeBindingNavigator.AddNewItem = Nothing
        Me.ProductionTypeBindingNavigator.BindingSource = Me.ProductionTypeBindingSource
        Me.ProductionTypeBindingNavigator.CountItem = Nothing
        Me.ProductionTypeBindingNavigator.DeleteItem = Nothing
        Me.ProductionTypeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductionTypeBindingNavigatorSaveItem})
        Me.ProductionTypeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductionTypeBindingNavigator.MoveFirstItem = Nothing
        Me.ProductionTypeBindingNavigator.MoveLastItem = Nothing
        Me.ProductionTypeBindingNavigator.MoveNextItem = Nothing
        Me.ProductionTypeBindingNavigator.MovePreviousItem = Nothing
        Me.ProductionTypeBindingNavigator.Name = "ProductionTypeBindingNavigator"
        Me.ProductionTypeBindingNavigator.PositionItem = Nothing
        Me.ProductionTypeBindingNavigator.Size = New System.Drawing.Size(785, 25)
        Me.ProductionTypeBindingNavigator.TabIndex = 0
        Me.ProductionTypeBindingNavigator.Text = "BindingNavigator1"
        '
        'ProductionTypeBindingNavigatorSaveItem
        '
        Me.ProductionTypeBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductionTypeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductionTypeBindingNavigatorSaveItem.Name = "ProductionTypeBindingNavigatorSaveItem"
        Me.ProductionTypeBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.ProductionTypeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductionTypeGridControl
        '
        Me.ProductionTypeGridControl.DataSource = Me.ProductionTypeBindingSource
        Me.ProductionTypeGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductionTypeGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ProductionTypeGridControl.MainView = Me.GridView1
        Me.ProductionTypeGridControl.Name = "ProductionTypeGridControl"
        Me.ProductionTypeGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.UnitGridLookUpEdit, Me.UserGridLookUpEdit})
        Me.ProductionTypeGridControl.Size = New System.Drawing.Size(785, 460)
        Me.ProductionTypeGridControl.TabIndex = 1
        Me.ProductionTypeGridControl.UseEmbeddedNavigator = True
        Me.ProductionTypeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductionType, Me.colTargetQuantity, Me.colUnitId, Me.colUserId})
        Me.GridView1.GridControl = Me.ProductionTypeGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colProductionType
        '
        Me.colProductionType.FieldName = "ProductionType"
        Me.colProductionType.Name = "colProductionType"
        Me.colProductionType.Visible = True
        Me.colProductionType.VisibleIndex = 0
        Me.colProductionType.Width = 276
        '
        'colTargetQuantity
        '
        Me.colTargetQuantity.FieldName = "TargetQuantity"
        Me.colTargetQuantity.Name = "colTargetQuantity"
        Me.colTargetQuantity.Visible = True
        Me.colTargetQuantity.VisibleIndex = 1
        '
        'colUnitId
        '
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.UnitGridLookUpEdit
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 2
        Me.colUnitId.Width = 162
        '
        'UnitGridLookUpEdit
        '
        Me.UnitGridLookUpEdit.AutoHeight = False
        Me.UnitGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitGridLookUpEdit.DisplayMember = "UnitName"
        Me.UnitGridLookUpEdit.ImmediatePopup = True
        Me.UnitGridLookUpEdit.Name = "UnitGridLookUpEdit"
        Me.UnitGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UnitGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.UnitGridLookUpEdit.ValueMember = "UnitId"
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitCode, Me.colUnitName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        'colUserId
        '
        Me.colUserId.Caption = "User"
        Me.colUserId.ColumnEdit = Me.UserGridLookUpEdit
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        Me.colUserId.Visible = True
        Me.colUserId.VisibleIndex = 3
        Me.colUserId.Width = 167
        '
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.AutoHeight = False
        Me.UserGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.DataSource = Me.UserLookupBindingSource
        Me.UserGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.ImmediatePopup = True
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UserGridLookUpEdit.PopupView = Me.GridView2
        Me.UserGridLookUpEdit.ValueMember = "USER_ID"
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
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME, Me.colDepartment})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'colDepartment
        '
        Me.colDepartment.FieldName = "Department"
        Me.colDepartment.Name = "colDepartment"
        Me.colDepartment.Visible = True
        Me.colDepartment.VisibleIndex = 1
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'frmProductionType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 485)
        Me.Controls.Add(Me.ProductionTypeGridControl)
        Me.Controls.Add(Me.ProductionTypeBindingNavigator)
        Me.Name = "frmProductionType"
        Me.Text = "Production Type"
        CType(Me.ProductionTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionTypeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductionTypeBindingNavigator.ResumeLayout(False)
        Me.ProductionTypeBindingNavigator.PerformLayout()
        CType(Me.ProductionTypeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionTypeDataSet As ProductionTypeDataSet
    Friend WithEvents ProductionTypeBindingSource As BindingSource
    Friend WithEvents ProductionTypeTableAdapter As ProductionTypeDataSetTableAdapters.ProductionTypeTableAdapter
    Friend WithEvents TableAdapterManager As ProductionTypeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductionTypeBindingNavigator As BindingNavigator
    Friend WithEvents ProductionTypeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductionTypeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProductionType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTargetQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitDataSet As UnitDataSet
    Friend WithEvents UnitBindingSource As BindingSource
    Friend WithEvents UnitTableAdapter As UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserLookupDataSet As UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As BindingSource
    Friend WithEvents UserLookupTableAdapter As UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
End Class
