<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivitiesGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivitiesGroup))
        Me.ActivitiesGroupDataSet = New KSoft_Apparel.ActivitiesGroupDataSet()
        Me.ActivitiesGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesGroupTableAdapter = New KSoft_Apparel.ActivitiesGroupDataSetTableAdapters.ActivitiesGroupTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.ActivitiesGroupDataSetTableAdapters.TableAdapterManager()
        Me.ActivitiesGroupBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ActivitiesGroupBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ActivitiesGroupGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActivitiesGroupId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivitiesGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivitiesGroupFor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ActivitiesGroupForComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colMaximumDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMinimumDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsEmbroidery = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsAll = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLeadTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSpecial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSublimation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.ActivitiesGroupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesGroupBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActivitiesGroupBindingNavigator.SuspendLayout()
        CType(Me.ActivitiesGroupGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesGroupForComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActivitiesGroupDataSet
        '
        Me.ActivitiesGroupDataSet.DataSetName = "ActivitiesGroupDataSet"
        Me.ActivitiesGroupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivitiesGroupBindingSource
        '
        Me.ActivitiesGroupBindingSource.DataMember = "ActivitiesGroup"
        Me.ActivitiesGroupBindingSource.DataSource = Me.ActivitiesGroupDataSet
        '
        'ActivitiesGroupTableAdapter
        '
        Me.ActivitiesGroupTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivitiesGroupTableAdapter = Me.ActivitiesGroupTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ActivitiesGroupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ActivitiesGroupBindingNavigator
        '
        Me.ActivitiesGroupBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ActivitiesGroupBindingNavigator.BindingSource = Me.ActivitiesGroupBindingSource
        Me.ActivitiesGroupBindingNavigator.CountItem = Nothing
        Me.ActivitiesGroupBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ActivitiesGroupBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ActivitiesGroupBindingNavigatorSaveItem})
        Me.ActivitiesGroupBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ActivitiesGroupBindingNavigator.MoveFirstItem = Nothing
        Me.ActivitiesGroupBindingNavigator.MoveLastItem = Nothing
        Me.ActivitiesGroupBindingNavigator.MoveNextItem = Nothing
        Me.ActivitiesGroupBindingNavigator.MovePreviousItem = Nothing
        Me.ActivitiesGroupBindingNavigator.Name = "ActivitiesGroupBindingNavigator"
        Me.ActivitiesGroupBindingNavigator.PositionItem = Nothing
        Me.ActivitiesGroupBindingNavigator.Size = New System.Drawing.Size(1208, 25)
        Me.ActivitiesGroupBindingNavigator.TabIndex = 0
        Me.ActivitiesGroupBindingNavigator.Text = "BindingNavigator1"
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
        'ActivitiesGroupBindingNavigatorSaveItem
        '
        Me.ActivitiesGroupBindingNavigatorSaveItem.Image = CType(resources.GetObject("ActivitiesGroupBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ActivitiesGroupBindingNavigatorSaveItem.Name = "ActivitiesGroupBindingNavigatorSaveItem"
        Me.ActivitiesGroupBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.ActivitiesGroupBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ActivitiesGroupGridControl
        '
        Me.ActivitiesGroupGridControl.DataSource = Me.ActivitiesGroupBindingSource
        Me.ActivitiesGroupGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActivitiesGroupGridControl.Location = New System.Drawing.Point(0, 25)
        Me.ActivitiesGroupGridControl.MainView = Me.GridView1
        Me.ActivitiesGroupGridControl.Name = "ActivitiesGroupGridControl"
        Me.ActivitiesGroupGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ActivitiesGroupForComboBox, Me.BuyerGridLookUpEdit})
        Me.ActivitiesGroupGridControl.Size = New System.Drawing.Size(1208, 419)
        Me.ActivitiesGroupGridControl.TabIndex = 2
        Me.ActivitiesGroupGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesGroupId, Me.colActivitiesGroup, Me.colBuyerId, Me.colActivitiesGroupFor, Me.colMaximumDay, Me.colMinimumDay, Me.colIsEmbroidery, Me.colIsPrint, Me.colIsAll, Me.colLeadTime, Me.colIsSequence, Me.colIsSpecial, Me.colIsSublimation})
        Me.GridView1.GridControl = Me.ActivitiesGroupGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colActivitiesGroupId
        '
        Me.colActivitiesGroupId.FieldName = "ActivitiesGroupId"
        Me.colActivitiesGroupId.Name = "colActivitiesGroupId"
        Me.colActivitiesGroupId.OptionsColumn.ReadOnly = True
        Me.colActivitiesGroupId.Width = 165
        '
        'colActivitiesGroup
        '
        Me.colActivitiesGroup.FieldName = "ActivitiesGroup"
        Me.colActivitiesGroup.Name = "colActivitiesGroup"
        Me.colActivitiesGroup.Visible = True
        Me.colActivitiesGroup.VisibleIndex = 0
        Me.colActivitiesGroup.Width = 225
        '
        'colBuyerId
        '
        Me.colBuyerId.Caption = "Buyer"
        Me.colBuyerId.ColumnEdit = Me.BuyerGridLookUpEdit
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.Visible = True
        Me.colBuyerId.VisibleIndex = 1
        Me.colBuyerId.Width = 93
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.AutoHeight = False
        Me.BuyerGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.DisplayMember = "BuyerName"
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.NullText = ""
        Me.BuyerGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerGridLookUpEdit.ValueMember = "BuyerId"
        Me.BuyerGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerCode1, Me.colBuyerName1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBuyerCode1
        '
        Me.colBuyerCode1.FieldName = "BuyerCode"
        Me.colBuyerCode1.Name = "colBuyerCode1"
        Me.colBuyerCode1.Visible = True
        Me.colBuyerCode1.VisibleIndex = 0
        '
        'colBuyerName1
        '
        Me.colBuyerName1.FieldName = "BuyerName"
        Me.colBuyerName1.Name = "colBuyerName1"
        Me.colBuyerName1.Visible = True
        Me.colBuyerName1.VisibleIndex = 1
        '
        'colActivitiesGroupFor
        '
        Me.colActivitiesGroupFor.ColumnEdit = Me.ActivitiesGroupForComboBox
        Me.colActivitiesGroupFor.FieldName = "ActivitiesGroupFor"
        Me.colActivitiesGroupFor.Name = "colActivitiesGroupFor"
        Me.colActivitiesGroupFor.Visible = True
        Me.colActivitiesGroupFor.VisibleIndex = 2
        Me.colActivitiesGroupFor.Width = 129
        '
        'ActivitiesGroupForComboBox
        '
        Me.ActivitiesGroupForComboBox.AutoHeight = False
        Me.ActivitiesGroupForComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActivitiesGroupForComboBox.Items.AddRange(New Object() {"Development", "Apparel", "Fabric"})
        Me.ActivitiesGroupForComboBox.Name = "ActivitiesGroupForComboBox"
        '
        'colMaximumDay
        '
        Me.colMaximumDay.FieldName = "MaximumDay"
        Me.colMaximumDay.Name = "colMaximumDay"
        Me.colMaximumDay.Visible = True
        Me.colMaximumDay.VisibleIndex = 3
        Me.colMaximumDay.Width = 105
        '
        'colMinimumDay
        '
        Me.colMinimumDay.FieldName = "MinimumDay"
        Me.colMinimumDay.Name = "colMinimumDay"
        Me.colMinimumDay.Visible = True
        Me.colMinimumDay.VisibleIndex = 5
        Me.colMinimumDay.Width = 103
        '
        'colIsEmbroidery
        '
        Me.colIsEmbroidery.FieldName = "IsEmbroidery"
        Me.colIsEmbroidery.Name = "colIsEmbroidery"
        Me.colIsEmbroidery.Visible = True
        Me.colIsEmbroidery.VisibleIndex = 10
        Me.colIsEmbroidery.Width = 78
        '
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        Me.colIsPrint.Visible = True
        Me.colIsPrint.VisibleIndex = 8
        Me.colIsPrint.Width = 63
        '
        'colIsAll
        '
        Me.colIsAll.FieldName = "IsAll"
        Me.colIsAll.Name = "colIsAll"
        Me.colIsAll.Visible = True
        Me.colIsAll.VisibleIndex = 6
        Me.colIsAll.Width = 55
        '
        'colLeadTime
        '
        Me.colLeadTime.AppearanceHeader.Options.UseTextOptions = True
        Me.colLeadTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLeadTime.FieldName = "LeadTime"
        Me.colLeadTime.Name = "colLeadTime"
        Me.colLeadTime.Visible = True
        Me.colLeadTime.VisibleIndex = 4
        Me.colLeadTime.Width = 88
        '
        'colIsSequence
        '
        Me.colIsSequence.FieldName = "IsSequence"
        Me.colIsSequence.Name = "colIsSequence"
        Me.colIsSequence.Visible = True
        Me.colIsSequence.VisibleIndex = 11
        Me.colIsSequence.Width = 77
        '
        'colIsSpecial
        '
        Me.colIsSpecial.Caption = "Is Foreign Yarn"
        Me.colIsSpecial.FieldName = "IsSpecialYarn"
        Me.colIsSpecial.Name = "colIsSpecial"
        Me.colIsSpecial.Visible = True
        Me.colIsSpecial.VisibleIndex = 7
        Me.colIsSpecial.Width = 85
        '
        'colIsSublimation
        '
        Me.colIsSublimation.FieldName = "IsSublimation"
        Me.colIsSublimation.Name = "colIsSublimation"
        Me.colIsSublimation.Visible = True
        Me.colIsSublimation.VisibleIndex = 9
        Me.colIsSublimation.Width = 89
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'colBuyerCode
        '
        Me.colBuyerCode.FieldName = "BuyerCode"
        Me.colBuyerCode.Name = "colBuyerCode"
        Me.colBuyerCode.Visible = True
        Me.colBuyerCode.VisibleIndex = 0
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 1
        '
        'frmActivitiesGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 444)
        Me.Controls.Add(Me.ActivitiesGroupGridControl)
        Me.Controls.Add(Me.ActivitiesGroupBindingNavigator)
        Me.Name = "frmActivitiesGroup"
        Me.Text = "Activities Group"
        CType(Me.ActivitiesGroupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesGroupBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActivitiesGroupBindingNavigator.ResumeLayout(False)
        Me.ActivitiesGroupBindingNavigator.PerformLayout()
        CType(Me.ActivitiesGroupGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesGroupForComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ActivitiesGroupDataSet As KSoft_Apparel.ActivitiesGroupDataSet
    Friend WithEvents ActivitiesGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesGroupTableAdapter As KSoft_Apparel.ActivitiesGroupDataSetTableAdapters.ActivitiesGroupTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ActivitiesGroupDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActivitiesGroupBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ActivitiesGroupBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ActivitiesGroupGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActivitiesGroupId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivitiesGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivitiesGroupFor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActivitiesGroupForComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaximumDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinimumDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsEmbroidery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsAll As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLeadTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSequence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSpecial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSublimation As DevExpress.XtraGrid.Columns.GridColumn
End Class
