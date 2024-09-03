<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiscCost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMiscCost))
        Me.MiscCostDataSet = New KSoft_Apparel.MiscCostDataSet()
        Me.MiscCostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiscCostTableAdapter = New KSoft_Apparel.MiscCostDataSetTableAdapters.MiscCostTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.MiscCostDataSetTableAdapters.TableAdapterManager()
        Me.MiscCostBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.MiscCostBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MiscCostGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.OrderLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ProgramNoWithStyleBuyerLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgramNoWtihStyleBuyerLookUpDataSet = New KSoft_Apparel.ProgramNoWtihStyleBuyerLookUpDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCostName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgramNoWithStyleBuyerLookUpTableAdapter = New KSoft_Apparel.ProgramNoWtihStyleBuyerLookUpDataSetTableAdapters.ProgramNoWithStyleBuyerLookUpTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.MiscCostDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscCostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscCostBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MiscCostBindingNavigator.SuspendLayout()
        CType(Me.MiscCostGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoWithStyleBuyerLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoWtihStyleBuyerLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MiscCostDataSet
        '
        Me.MiscCostDataSet.DataSetName = "MiscCostDataSet"
        Me.MiscCostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MiscCostBindingSource
        '
        Me.MiscCostBindingSource.DataMember = "MiscCost"
        Me.MiscCostBindingSource.DataSource = Me.MiscCostDataSet
        '
        'MiscCostTableAdapter
        '
        Me.MiscCostTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MiscCostTableAdapter = Me.MiscCostTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.MiscCostDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MiscCostBindingNavigator
        '
        Me.MiscCostBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MiscCostBindingNavigator.BindingSource = Me.MiscCostBindingSource
        Me.MiscCostBindingNavigator.CountItem = Nothing
        Me.MiscCostBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MiscCostBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MiscCostBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MiscCostBindingNavigatorSaveItem})
        Me.MiscCostBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MiscCostBindingNavigator.MoveFirstItem = Nothing
        Me.MiscCostBindingNavigator.MoveLastItem = Nothing
        Me.MiscCostBindingNavigator.MoveNextItem = Nothing
        Me.MiscCostBindingNavigator.MovePreviousItem = Nothing
        Me.MiscCostBindingNavigator.Name = "MiscCostBindingNavigator"
        Me.MiscCostBindingNavigator.PositionItem = Nothing
        Me.MiscCostBindingNavigator.Size = New System.Drawing.Size(1264, 27)
        Me.MiscCostBindingNavigator.TabIndex = 0
        Me.MiscCostBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(92, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(77, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MiscCostBindingNavigatorSaveItem
        '
        Me.MiscCostBindingNavigatorSaveItem.Image = CType(resources.GetObject("MiscCostBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MiscCostBindingNavigatorSaveItem.Name = "MiscCostBindingNavigatorSaveItem"
        Me.MiscCostBindingNavigatorSaveItem.Size = New System.Drawing.Size(100, 24)
        Me.MiscCostBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MiscCostGridControl
        '
        Me.MiscCostGridControl.DataSource = Me.MiscCostBindingSource
        Me.MiscCostGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MiscCostGridControl.Location = New System.Drawing.Point(0, 27)
        Me.MiscCostGridControl.MainView = Me.GridView1
        Me.MiscCostGridControl.Name = "MiscCostGridControl"
        Me.MiscCostGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.OrderLookupGridLookUpEdit})
        Me.MiscCostGridControl.Size = New System.Drawing.Size(1264, 605)
        Me.MiscCostGridControl.TabIndex = 1
        Me.MiscCostGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCostName, Me.colCostAmount})
        Me.GridView1.GridControl = Me.MiscCostGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'OrderLookupGridLookUpEdit
        '
        Me.OrderLookupGridLookUpEdit.AutoHeight = False
        Me.OrderLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderLookupGridLookUpEdit.DataSource = Me.ProgramNoWithStyleBuyerLookUpBindingSource
        Me.OrderLookupGridLookUpEdit.DisplayMember = "Details"
        Me.OrderLookupGridLookUpEdit.Name = "OrderLookupGridLookUpEdit"
        Me.OrderLookupGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderLookupGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.OrderLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderLookupGridLookUpEdit.ValueMember = "OrderId"
        '
        'ProgramNoWithStyleBuyerLookUpBindingSource
        '
        Me.ProgramNoWithStyleBuyerLookUpBindingSource.DataMember = "ProgramNoWithStyleBuyerLookUp"
        Me.ProgramNoWithStyleBuyerLookUpBindingSource.DataSource = Me.ProgramNoWtihStyleBuyerLookUpDataSet
        '
        'ProgramNoWtihStyleBuyerLookUpDataSet
        '
        Me.ProgramNoWtihStyleBuyerLookUpDataSet.DataSetName = "ProgramNoWtihStyleBuyerLookUpDataSet"
        Me.ProgramNoWtihStyleBuyerLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colCostName
        '
        Me.colCostName.FieldName = "CostName"
        Me.colCostName.MinWidth = 25
        Me.colCostName.Name = "colCostName"
        Me.colCostName.Visible = True
        Me.colCostName.VisibleIndex = 0
        Me.colCostName.Width = 311
        '
        'colCostAmount
        '
        Me.colCostAmount.FieldName = "CostAmount"
        Me.colCostAmount.MinWidth = 25
        Me.colCostAmount.Name = "colCostAmount"
        Me.colCostAmount.Visible = True
        Me.colCostAmount.VisibleIndex = 1
        Me.colCostAmount.Width = 342
        '
        'ProgramNoWithStyleBuyerLookUpTableAdapter
        '
        Me.ProgramNoWithStyleBuyerLookUpTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 15, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 21)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Filter By Program No :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.EditValue = "[Select your Program]"
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(528, 1)
        Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(4, 9, 4, 4)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.ProgramNoWithStyleBuyerLookUpBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "Details"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "Select your Program"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Properties.Tag = "NR"
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "OrderId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(335, 22)
        Me.GridLookUpEdit1.TabIndex = 49
        Me.GridLookUpEdit1.Tag = "NR"
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(871, -1)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(4, 7, 4, 4)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(100, 28)
        Me.ShowButton.TabIndex = 50
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'frmMiscCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 632)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.MiscCostGridControl)
        Me.Controls.Add(Me.MiscCostBindingNavigator)
        Me.Name = "frmMiscCost"
        Me.Text = "Misc Cost"
        CType(Me.MiscCostDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscCostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscCostBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MiscCostBindingNavigator.ResumeLayout(False)
        Me.MiscCostBindingNavigator.PerformLayout()
        CType(Me.MiscCostGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoWithStyleBuyerLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoWtihStyleBuyerLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MiscCostDataSet As MiscCostDataSet
    Friend WithEvents MiscCostBindingSource As BindingSource
    Friend WithEvents MiscCostTableAdapter As MiscCostDataSetTableAdapters.MiscCostTableAdapter
    Friend WithEvents TableAdapterManager As MiscCostDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MiscCostBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents MiscCostBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MiscCostGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCostName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgramNoWtihStyleBuyerLookUpDataSet As ProgramNoWtihStyleBuyerLookUpDataSet
    Friend WithEvents ProgramNoWithStyleBuyerLookUpBindingSource As BindingSource
    Friend WithEvents ProgramNoWithStyleBuyerLookUpTableAdapter As ProgramNoWtihStyleBuyerLookUpDataSetTableAdapters.ProgramNoWithStyleBuyerLookUpTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowButton As Button
End Class
