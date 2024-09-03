<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComposition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComposition))
        Me.CompositionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet
        Me.CompositionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.AddNewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.SearchToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.CompositionDataGridView = New System.Windows.Forms.DataGridView
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsLycra = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Discontinue = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.CompositionDataSetTableAdapters.TableAdapterManager
        Me.CompositionDetailsTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionDetailsTableAdapter
        Me.CompositionDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDetailsGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCompositionDetailsId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompositionId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Apparel.ItemListDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPercentage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ItemListLookupTableAdapter = New KSoft_Apparel.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
        CType(Me.CompositionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompositionBindingNavigator.SuspendLayout()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompositionBindingNavigator
        '
        Me.CompositionBindingNavigator.AddNewItem = Nothing
        Me.CompositionBindingNavigator.BindingSource = Me.CompositionBindingSource
        Me.CompositionBindingNavigator.CountItem = Nothing
        Me.CompositionBindingNavigator.DeleteItem = Nothing
        Me.CompositionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompositionBindingNavigatorSaveItem, Me.AddNewToolStripButton, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.SearchToolStripTextBox})
        Me.CompositionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CompositionBindingNavigator.MoveFirstItem = Nothing
        Me.CompositionBindingNavigator.MoveLastItem = Nothing
        Me.CompositionBindingNavigator.MoveNextItem = Nothing
        Me.CompositionBindingNavigator.MovePreviousItem = Nothing
        Me.CompositionBindingNavigator.Name = "CompositionBindingNavigator"
        Me.CompositionBindingNavigator.PositionItem = Nothing
        Me.CompositionBindingNavigator.Size = New System.Drawing.Size(525, 25)
        Me.CompositionBindingNavigator.TabIndex = 0
        Me.CompositionBindingNavigator.Text = "BindingNavigator1"
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
        'CompositionBindingNavigatorSaveItem
        '
        Me.CompositionBindingNavigatorSaveItem.Image = CType(resources.GetObject("CompositionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CompositionBindingNavigatorSaveItem.Name = "CompositionBindingNavigatorSaveItem"
        Me.CompositionBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.CompositionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AddNewToolStripButton
        '
        Me.AddNewToolStripButton.Image = CType(resources.GetObject("AddNewToolStripButton.Image"), System.Drawing.Image)
        Me.AddNewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddNewToolStripButton.Name = "AddNewToolStripButton"
        Me.AddNewToolStripButton.Size = New System.Drawing.Size(76, 22)
        Me.AddNewToolStripButton.Text = "Add New"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton1.Text = "Show All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripLabel1.Text = "Search ( Like)"
        '
        'SearchToolStripTextBox
        '
        Me.SearchToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SearchToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchToolStripTextBox.Name = "SearchToolStripTextBox"
        Me.SearchToolStripTextBox.Size = New System.Drawing.Size(200, 25)
        '
        'CompositionDataGridView
        '
        Me.CompositionDataGridView.AllowUserToAddRows = False
        Me.CompositionDataGridView.AutoGenerateColumns = False
        Me.CompositionDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CompositionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CompositionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.DataGridViewTextBoxColumn2, Me.IsLycra, Me.Discontinue})
        Me.CompositionDataGridView.DataSource = Me.CompositionBindingSource
        Me.CompositionDataGridView.Location = New System.Drawing.Point(4, 25)
        Me.CompositionDataGridView.Name = "CompositionDataGridView"
        Me.CompositionDataGridView.Size = New System.Drawing.Size(517, 213)
        Me.CompositionDataGridView.TabIndex = 1
        '
        'Code
        '
        Me.Code.DataPropertyName = "Code"
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Composition"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Composition"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'IsLycra
        '
        Me.IsLycra.DataPropertyName = "IsLycra"
        Me.IsLycra.HeaderText = "IsLycra"
        Me.IsLycra.Name = "IsLycra"
        '
        'Discontinue
        '
        Me.Discontinue.DataPropertyName = "Discontinue"
        Me.Discontinue.HeaderText = "Discontinue"
        Me.Discontinue.Name = "Discontinue"
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompositionDetailsTableAdapter = Me.CompositionDetailsTableAdapter
        Me.TableAdapterManager.CompositionTableAdapter = Me.CompositionTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CompositionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CompositionDetailsTableAdapter
        '
        Me.CompositionDetailsTableAdapter.ClearBeforeFill = True
        '
        'CompositionDetailsBindingSource
        '
        Me.CompositionDetailsBindingSource.DataMember = "Composition_CompositionDetails"
        Me.CompositionDetailsBindingSource.DataSource = Me.CompositionBindingSource
        '
        'CompositionDetailsGridControl
        '
        Me.CompositionDetailsGridControl.DataSource = Me.CompositionDetailsBindingSource
        Me.CompositionDetailsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.CompositionDetailsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.CompositionDetailsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.CompositionDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.CompositionDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.CompositionDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.CompositionDetailsGridControl.Location = New System.Drawing.Point(6, 244)
        Me.CompositionDetailsGridControl.LookAndFeel.SkinName = "Money Twins"
        Me.CompositionDetailsGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CompositionDetailsGridControl.MainView = Me.GridView1
        Me.CompositionDetailsGridControl.Name = "CompositionDetailsGridControl"
        Me.CompositionDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemGridLookUpEdit})
        Me.CompositionDetailsGridControl.Size = New System.Drawing.Size(515, 132)
        Me.CompositionDetailsGridControl.TabIndex = 2
        Me.CompositionDetailsGridControl.UseEmbeddedNavigator = True
        Me.CompositionDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompositionDetailsId, Me.colCompositionId, Me.colItemId, Me.colPercentage})
        Me.GridView1.GridControl = Me.CompositionDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCompositionDetailsId
        '
        Me.colCompositionDetailsId.FieldName = "CompositionDetailsId"
        Me.colCompositionDetailsId.Name = "colCompositionDetailsId"
        Me.colCompositionDetailsId.OptionsColumn.ReadOnly = True
        '
        'colCompositionId
        '
        Me.colCompositionId.FieldName = "CompositionId"
        Me.colCompositionId.Name = "colCompositionId"
        '
        'colItemId
        '
        Me.colItemId.Caption = "Item Name"
        Me.colItemId.ColumnEdit = Me.ItemGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 375
        '
        'ItemGridLookUpEdit
        '
        Me.ItemGridLookUpEdit.AutoHeight = False
        Me.ItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemGridLookUpEdit.DataSource = Me.ItemListLookupBindingSource
        Me.ItemGridLookUpEdit.DisplayMember = "ItemName"
        Me.ItemGridLookUpEdit.Name = "ItemGridLookUpEdit"
        Me.ItemGridLookUpEdit.NullText = ""
        Me.ItemGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemGridLookUpEdit.ValueMember = "ItemId"
        Me.ItemGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId1, Me.colItemName, Me.colDepartmentId, Me.GridColumn1})
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
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID-Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'colPercentage
        '
        Me.colPercentage.Caption = "Percentage (%)"
        Me.colPercentage.FieldName = "Percentage"
        Me.colPercentage.Name = "colPercentage"
        Me.colPercentage.Visible = True
        Me.colPercentage.VisibleIndex = 1
        Me.colPercentage.Width = 119
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'frmComposition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 378)
        Me.Controls.Add(Me.CompositionDetailsGridControl)
        Me.Controls.Add(Me.CompositionDataGridView)
        Me.Controls.Add(Me.CompositionBindingNavigator)
        Me.Name = "frmComposition"
        Me.Text = "Composition"
        CType(Me.CompositionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompositionBindingNavigator.ResumeLayout(False)
        Me.CompositionBindingNavigator.PerformLayout()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CompositionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CompositionBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CompositionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CompositionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddNewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SearchToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CompositionDetailsTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionDetailsTableAdapter
    Friend WithEvents CompositionDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCompositionDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompositionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDataSet As KSoft_Apparel.ItemListDataSet
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Apparel.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsLycra As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Discontinue As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
