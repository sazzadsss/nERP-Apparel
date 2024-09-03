<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionTarget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionTarget))
        Me.ProductionTargetDataSet = New KSoft_Apparel.ProductionTargetDataSet()
        Me.ProductionTargetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionTargetTableAdapter = New KSoft_Apparel.ProductionTargetDataSetTableAdapters.ProductionTargetTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.ProductionTargetDataSetTableAdapters.TableAdapterManager()
        Me.ProductionTargetBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductionTargetBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductionTargetGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductionTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ProductionTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionTypeDataSet = New KSoft_Apparel.ProductionTypeDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductionType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTargetQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductionDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ProductionTypeTableAdapter = New KSoft_Apparel.ProductionTypeDataSetTableAdapters.ProductionTypeTableAdapter()
        CType(Me.ProductionTargetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionTargetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionTargetBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductionTargetBindingNavigator.SuspendLayout()
        CType(Me.ProductionTargetGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductionTargetDataSet
        '
        Me.ProductionTargetDataSet.DataSetName = "ProductionTargetDataSet"
        Me.ProductionTargetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductionTargetBindingSource
        '
        Me.ProductionTargetBindingSource.DataMember = "ProductionTarget"
        Me.ProductionTargetBindingSource.DataSource = Me.ProductionTargetDataSet
        '
        'ProductionTargetTableAdapter
        '
        Me.ProductionTargetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductionTargetTableAdapter = Me.ProductionTargetTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ProductionTargetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductionTargetBindingNavigator
        '
        Me.ProductionTargetBindingNavigator.AddNewItem = Nothing
        Me.ProductionTargetBindingNavigator.BindingSource = Me.ProductionTargetBindingSource
        Me.ProductionTargetBindingNavigator.CountItem = Nothing
        Me.ProductionTargetBindingNavigator.DeleteItem = Nothing
        Me.ProductionTargetBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BindingNavigatorAddNewItem, Me.ProductionTargetBindingNavigatorSaveItem})
        Me.ProductionTargetBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductionTargetBindingNavigator.MoveFirstItem = Nothing
        Me.ProductionTargetBindingNavigator.MoveLastItem = Nothing
        Me.ProductionTargetBindingNavigator.MoveNextItem = Nothing
        Me.ProductionTargetBindingNavigator.MovePreviousItem = Nothing
        Me.ProductionTargetBindingNavigator.Name = "ProductionTargetBindingNavigator"
        Me.ProductionTargetBindingNavigator.PositionItem = Nothing
        Me.ProductionTargetBindingNavigator.Size = New System.Drawing.Size(584, 25)
        Me.ProductionTargetBindingNavigator.TabIndex = 0
        Me.ProductionTargetBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel1.Text = "Production Date"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Margin = New System.Windows.Forms.Padding(150, 1, 0, 2)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'ProductionTargetBindingNavigatorSaveItem
        '
        Me.ProductionTargetBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductionTargetBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductionTargetBindingNavigatorSaveItem.Name = "ProductionTargetBindingNavigatorSaveItem"
        Me.ProductionTargetBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.ProductionTargetBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductionTargetGridControl
        '
        Me.ProductionTargetGridControl.DataSource = Me.ProductionTargetBindingSource
        Me.ProductionTargetGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductionTargetGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ProductionTargetGridControl.MainView = Me.GridView1
        Me.ProductionTargetGridControl.Name = "ProductionTargetGridControl"
        Me.ProductionTargetGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProductionTypeGridLookUpEdit})
        Me.ProductionTargetGridControl.Size = New System.Drawing.Size(584, 456)
        Me.ProductionTargetGridControl.TabIndex = 1
        Me.ProductionTargetGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductionDate, Me.colProductionTypeId, Me.colTargetQuantity})
        Me.GridView1.GridControl = Me.ProductionTargetGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colProductionDate
        '
        Me.colProductionDate.FieldName = "ProductionDate"
        Me.colProductionDate.Name = "colProductionDate"
        Me.colProductionDate.OptionsColumn.AllowEdit = False
        Me.colProductionDate.OptionsColumn.ReadOnly = True
        Me.colProductionDate.Visible = True
        Me.colProductionDate.VisibleIndex = 0
        Me.colProductionDate.Width = 116
        '
        'colProductionTypeId
        '
        Me.colProductionTypeId.Caption = "Production Type"
        Me.colProductionTypeId.ColumnEdit = Me.ProductionTypeGridLookUpEdit
        Me.colProductionTypeId.FieldName = "ProductionTypeId"
        Me.colProductionTypeId.Name = "colProductionTypeId"
        Me.colProductionTypeId.OptionsColumn.AllowEdit = False
        Me.colProductionTypeId.OptionsColumn.ReadOnly = True
        Me.colProductionTypeId.Visible = True
        Me.colProductionTypeId.VisibleIndex = 1
        Me.colProductionTypeId.Width = 223
        '
        'ProductionTypeGridLookUpEdit
        '
        Me.ProductionTypeGridLookUpEdit.AutoHeight = False
        Me.ProductionTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductionTypeGridLookUpEdit.DataSource = Me.ProductionTypeBindingSource
        Me.ProductionTypeGridLookUpEdit.DisplayMember = "ProductionType"
        Me.ProductionTypeGridLookUpEdit.Name = "ProductionTypeGridLookUpEdit"
        Me.ProductionTypeGridLookUpEdit.ValueMember = "ProductionTypeId"
        Me.ProductionTypeGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'ProductionTypeBindingSource
        '
        Me.ProductionTypeBindingSource.DataMember = "ProductionType"
        Me.ProductionTypeBindingSource.DataSource = Me.ProductionTypeDataSet
        '
        'ProductionTypeDataSet
        '
        Me.ProductionTypeDataSet.DataSetName = "ProductionTypeDataSet"
        Me.ProductionTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductionType})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProductionType
        '
        Me.colProductionType.FieldName = "ProductionType"
        Me.colProductionType.Name = "colProductionType"
        Me.colProductionType.Visible = True
        Me.colProductionType.VisibleIndex = 0
        '
        'colTargetQuantity
        '
        Me.colTargetQuantity.FieldName = "TargetQuantity"
        Me.colTargetQuantity.Name = "colTargetQuantity"
        Me.colTargetQuantity.Visible = True
        Me.colTargetQuantity.VisibleIndex = 2
        Me.colTargetQuantity.Width = 227
        '
        'ProductionDateEdit
        '
        Me.ProductionDateEdit.EditValue = Nothing
        Me.ProductionDateEdit.Location = New System.Drawing.Point(116, 2)
        Me.ProductionDateEdit.Name = "ProductionDateEdit"
        Me.ProductionDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductionDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductionDateEdit.Size = New System.Drawing.Size(128, 20)
        Me.ProductionDateEdit.TabIndex = 2
        '
        'ProductionTypeTableAdapter
        '
        Me.ProductionTypeTableAdapter.ClearBeforeFill = True
        '
        'frmProductionTarget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 481)
        Me.Controls.Add(Me.ProductionDateEdit)
        Me.Controls.Add(Me.ProductionTargetGridControl)
        Me.Controls.Add(Me.ProductionTargetBindingNavigator)
        Me.Name = "frmProductionTarget"
        Me.Text = "Production Target"
        CType(Me.ProductionTargetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionTargetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionTargetBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductionTargetBindingNavigator.ResumeLayout(False)
        Me.ProductionTargetBindingNavigator.PerformLayout()
        CType(Me.ProductionTargetGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionTargetDataSet As ProductionTargetDataSet
    Friend WithEvents ProductionTargetBindingSource As BindingSource
    Friend WithEvents ProductionTargetTableAdapter As ProductionTargetDataSetTableAdapters.ProductionTargetTableAdapter
    Friend WithEvents TableAdapterManager As ProductionTargetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductionTargetBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents ProductionTargetBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductionTargetGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ProductionDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colProductionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductionTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTargetQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductionTypeDataSet As ProductionTypeDataSet
    Friend WithEvents ProductionTypeBindingSource As BindingSource
    Friend WithEvents ProductionTypeTableAdapter As ProductionTypeDataSetTableAdapters.ProductionTypeTableAdapter
    Friend WithEvents colProductionType As DevExpress.XtraGrid.Columns.GridColumn
End Class
