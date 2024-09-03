<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivitiesList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActivitiesList))
        Me.ActivitiesListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ActivitiesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesListDataSet = New KSoft_Apparel.ActivitiesListDataSet()
        Me.ActivitiesListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.ActivitiesListTableAdapter = New KSoft_Apparel.ActivitiesListDataSetTableAdapters.ActivitiesListTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.ActivitiesListDataSetTableAdapters.TableAdapterManager()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.ActivitiesListGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActivitiesListId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAAsign_UserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForReporting = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        CType(Me.ActivitiesListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActivitiesListBindingNavigator.SuspendLayout()
        CType(Me.ActivitiesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActivitiesListBindingNavigator
        '
        Me.ActivitiesListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ActivitiesListBindingNavigator.BindingSource = Me.ActivitiesListBindingSource
        Me.ActivitiesListBindingNavigator.CountItem = Nothing
        Me.ActivitiesListBindingNavigator.DeleteItem = Nothing
        Me.ActivitiesListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ActivitiesListBindingNavigatorSaveItem})
        Me.ActivitiesListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ActivitiesListBindingNavigator.MoveFirstItem = Nothing
        Me.ActivitiesListBindingNavigator.MoveLastItem = Nothing
        Me.ActivitiesListBindingNavigator.MoveNextItem = Nothing
        Me.ActivitiesListBindingNavigator.MovePreviousItem = Nothing
        Me.ActivitiesListBindingNavigator.Name = "ActivitiesListBindingNavigator"
        Me.ActivitiesListBindingNavigator.PositionItem = Nothing
        Me.ActivitiesListBindingNavigator.Size = New System.Drawing.Size(742, 25)
        Me.ActivitiesListBindingNavigator.TabIndex = 0
        Me.ActivitiesListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'ActivitiesListBindingSource
        '
        Me.ActivitiesListBindingSource.DataMember = "ActivitiesList"
        Me.ActivitiesListBindingSource.DataSource = Me.ActivitiesListDataSet
        '
        'ActivitiesListDataSet
        '
        Me.ActivitiesListDataSet.DataSetName = "ActivitiesListDataSet"
        Me.ActivitiesListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivitiesListBindingNavigatorSaveItem
        '
        Me.ActivitiesListBindingNavigatorSaveItem.Image = CType(resources.GetObject("ActivitiesListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ActivitiesListBindingNavigatorSaveItem.Name = "ActivitiesListBindingNavigatorSaveItem"
        Me.ActivitiesListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.ActivitiesListBindingNavigatorSaveItem.Text = "Save Data"
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
        'ActivitiesListTableAdapter
        '
        Me.ActivitiesListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivitiesListTableAdapter = Me.ActivitiesListTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ActivitiesListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'ActivitiesListGridControl
        '
        Me.ActivitiesListGridControl.DataSource = Me.ActivitiesListBindingSource
        Me.ActivitiesListGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActivitiesListGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ActivitiesListGridControl.MainView = Me.GridView1
        Me.ActivitiesListGridControl.Name = "ActivitiesListGridControl"
        Me.ActivitiesListGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.UserLookupGridLookUpEdit, Me.RepositoryItemComboBox1})
        Me.ActivitiesListGridControl.Size = New System.Drawing.Size(742, 388)
        Me.ActivitiesListGridControl.TabIndex = 1
        Me.ActivitiesListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesListId, Me.colDescription, Me.colRemarks, Me.colAAsign_UserId, Me.colForReporting})
        Me.GridView1.GridControl = Me.ActivitiesListGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colActivitiesListId
        '
        Me.colActivitiesListId.FieldName = "ActivitiesListId"
        Me.colActivitiesListId.Name = "colActivitiesListId"
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 0
        Me.colDescription.Width = 287
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 3
        Me.colRemarks.Width = 192
        '
        'colAAsign_UserId
        '
        Me.colAAsign_UserId.Caption = "Asigned For"
        Me.colAAsign_UserId.ColumnEdit = Me.UserLookupGridLookUpEdit
        Me.colAAsign_UserId.FieldName = "AAsign_UserId"
        Me.colAAsign_UserId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colAAsign_UserId.Name = "colAAsign_UserId"
        Me.colAAsign_UserId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colAAsign_UserId.Visible = True
        Me.colAAsign_UserId.VisibleIndex = 2
        Me.colAAsign_UserId.Width = 137
        '
        'UserLookupGridLookUpEdit
        '
        Me.UserLookupGridLookUpEdit.AutoHeight = False
        Me.UserLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserLookupGridLookUpEdit.DataSource = Me.UserLookupBindingSource
        Me.UserLookupGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UserLookupGridLookUpEdit.Name = "UserLookupGridLookUpEdit"
        Me.UserLookupGridLookUpEdit.NullText = ""
        Me.UserLookupGridLookUpEdit.ValueMember = "USER_ID"
        Me.UserLookupGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME1, Me.colDepartment1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME1
        '
        Me.colUSER_NAME1.FieldName = "USER_NAME"
        Me.colUSER_NAME1.Name = "colUSER_NAME1"
        Me.colUSER_NAME1.Visible = True
        Me.colUSER_NAME1.VisibleIndex = 1
        '
        'colDepartment1
        '
        Me.colDepartment1.FieldName = "Department"
        Me.colDepartment1.Name = "colDepartment1"
        Me.colDepartment1.Visible = True
        Me.colDepartment1.VisibleIndex = 0
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
        'colForReporting
        '
        Me.colForReporting.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colForReporting.FieldName = "ForReporting"
        Me.colForReporting.Name = "colForReporting"
        Me.colForReporting.Visible = True
        Me.colForReporting.VisibleIndex = 1
        Me.colForReporting.Width = 108
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Yarn Inhouse", "Fabric Delivery", "Cutting", "Embroidery", "Accessories", "Sewing", "Finishing", "Inspection", "Shipment", "Printing"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'ActivitiesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 413)
        Me.Controls.Add(Me.ActivitiesListGridControl)
        Me.Controls.Add(Me.ActivitiesListBindingNavigator)
        Me.Name = "ActivitiesList"
        Me.Text = "Activities List"
        CType(Me.ActivitiesListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActivitiesListBindingNavigator.ResumeLayout(False)
        Me.ActivitiesListBindingNavigator.PerformLayout()
        CType(Me.ActivitiesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ActivitiesListDataSet As KSoft_Apparel.ActivitiesListDataSet
    Friend WithEvents ActivitiesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesListTableAdapter As KSoft_Apparel.ActivitiesListDataSetTableAdapters.ActivitiesListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ActivitiesListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActivitiesListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ActivitiesListBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserLookupDataSet As KSoft_Apparel.UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserLookupTableAdapter As KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents ActivitiesListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActivitiesListId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAAsign_UserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForReporting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
