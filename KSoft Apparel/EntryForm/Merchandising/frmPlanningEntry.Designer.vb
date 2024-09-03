<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanningEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanningEntry))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.PlanningNewDataSet = New KSoft_Apparel.PlanningNewDataSet
        Me.PlanningBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanningTableAdapter = New KSoft_Apparel.PlanningNewDataSetTableAdapters.PlanningTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.PlanningNewDataSetTableAdapters.TableAdapterManager
        Me.PlanningBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.PlanningBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PlanningGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPlanId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colLine = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineDataSet = New KSoft_Apparel.LineDataSet
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colPlanningFromDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPlanningToDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPlanningQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.EditModeCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PlanningNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanningBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanningBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlanningBindingNavigator.SuspendLayout()
        CType(Me.PlanningGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditModeCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(564, 375)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'PlanningNewDataSet
        '
        Me.PlanningNewDataSet.DataSetName = "PlanningNewDataSet"
        Me.PlanningNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlanningBindingSource
        '
        Me.PlanningBindingSource.DataMember = "Planning"
        Me.PlanningBindingSource.DataSource = Me.PlanningNewDataSet
        '
        'PlanningTableAdapter
        '
        Me.PlanningTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PlanningTableAdapter = Me.PlanningTableAdapter
        Me.TableAdapterManager.SewingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PlanningNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PlanningBindingNavigator
        '
        Me.PlanningBindingNavigator.AddNewItem = Nothing
        Me.PlanningBindingNavigator.BindingSource = Me.PlanningBindingSource
        Me.PlanningBindingNavigator.CountItem = Nothing
        Me.PlanningBindingNavigator.DeleteItem = Nothing
        Me.PlanningBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanningBindingNavigatorSaveItem})
        Me.PlanningBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PlanningBindingNavigator.MoveFirstItem = Nothing
        Me.PlanningBindingNavigator.MoveLastItem = Nothing
        Me.PlanningBindingNavigator.MoveNextItem = Nothing
        Me.PlanningBindingNavigator.MovePreviousItem = Nothing
        Me.PlanningBindingNavigator.Name = "PlanningBindingNavigator"
        Me.PlanningBindingNavigator.PositionItem = Nothing
        Me.PlanningBindingNavigator.Size = New System.Drawing.Size(728, 25)
        Me.PlanningBindingNavigator.TabIndex = 0
        Me.PlanningBindingNavigator.Text = "BindingNavigator1"
        '
        'PlanningBindingNavigatorSaveItem
        '
        Me.PlanningBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlanningBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlanningBindingNavigatorSaveItem.Name = "PlanningBindingNavigatorSaveItem"
        Me.PlanningBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.PlanningBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PlanningGridControl
        '
        Me.PlanningGridControl.DataSource = Me.PlanningBindingSource
        Me.PlanningGridControl.Location = New System.Drawing.Point(12, 79)
        Me.PlanningGridControl.LookAndFeel.SkinName = "Black"
        Me.PlanningGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PlanningGridControl.MainView = Me.GridView1
        Me.PlanningGridControl.Name = "PlanningGridControl"
        Me.PlanningGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3})
        Me.PlanningGridControl.Size = New System.Drawing.Size(698, 290)
        Me.PlanningGridControl.TabIndex = 3
        Me.PlanningGridControl.UseEmbeddedNavigator = True
        Me.PlanningGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPlanId, Me.colProgramNo, Me.colFabricColorId, Me.colLine, Me.colPlanningFromDate, Me.colPlanningToDate, Me.colPlanningQuantity})
        Me.GridView1.GridControl = Me.PlanningGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colPlanId
        '
        Me.colPlanId.Caption = "PlanningId"
        Me.colPlanId.FieldName = "PlanId"
        Me.colPlanId.Name = "colPlanId"
        Me.colPlanId.OptionsColumn.ReadOnly = True
        Me.colPlanId.Visible = True
        Me.colPlanId.VisibleIndex = 0
        Me.colPlanId.Width = 77
        '
        'colProgramNo
        '
        Me.colProgramNo.ColumnEdit = Me.RepositoryItemGridLookUpEdit3
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 1
        Me.colProgramNo.Width = 89
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.OrderLookupBindingSource
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "ProgramNo"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "OrderId"
        Me.RepositoryItemGridLookUpEdit3.View = Me.RepositoryItemGridLookUpEdit3View
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
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorId
        '
        Me.colFabricColorId.Caption = "Color"
        Me.colFabricColorId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.OptionsColumn.ReadOnly = True
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 2
        Me.colFabricColorId.Width = 106
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.FabricColorBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "FabricColorName"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "FabricColorId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'FabricColorBindingSource
        '
        Me.FabricColorBindingSource.DataMember = "FabricColor"
        Me.FabricColorBindingSource.DataSource = Me.FabricColorDataSet
        '
        'FabricColorDataSet
        '
        Me.FabricColorDataSet.DataSetName = "FabricColorDataSet"
        Me.FabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colLine
        '
        Me.colLine.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colLine.FieldName = "Line"
        Me.colLine.Name = "colLine"
        Me.colLine.Visible = True
        Me.colLine.VisibleIndex = 3
        Me.colLine.Width = 74
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.LineBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "Line"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "LineId"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'LineBindingSource
        '
        Me.LineBindingSource.DataMember = "Line"
        Me.LineBindingSource.DataSource = Me.LineDataSet
        '
        'LineDataSet
        '
        Me.LineDataSet.DataSetName = "LineDataSet"
        Me.LineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colPlanningFromDate
        '
        Me.colPlanningFromDate.FieldName = "PlanningFromDate"
        Me.colPlanningFromDate.Name = "colPlanningFromDate"
        Me.colPlanningFromDate.Visible = True
        Me.colPlanningFromDate.VisibleIndex = 4
        Me.colPlanningFromDate.Width = 100
        '
        'colPlanningToDate
        '
        Me.colPlanningToDate.FieldName = "PlanningToDate"
        Me.colPlanningToDate.Name = "colPlanningToDate"
        Me.colPlanningToDate.Visible = True
        Me.colPlanningToDate.VisibleIndex = 5
        Me.colPlanningToDate.Width = 100
        '
        'colPlanningQuantity
        '
        Me.colPlanningQuantity.FieldName = "PlanningQuantity"
        Me.colPlanningQuantity.Name = "colPlanningQuantity"
        Me.colPlanningQuantity.Visible = True
        Me.colPlanningQuantity.VisibleIndex = 6
        Me.colPlanningQuantity.Width = 113
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.Visible = True
        Me.colOrderId.VisibleIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ProgramNo"
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(264, 53)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.OrderFabricColorBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "FabricColorName"
        Me.GridLookUpEdit2.Properties.NullText = "[Select Color]"
        Me.GridLookUpEdit2.Properties.ValueMember = "FabricColorId"
        Me.GridLookUpEdit2.Properties.View = Me.GridLookUpEdit2View
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(174, 20)
        Me.GridLookUpEdit2.TabIndex = 2
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
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Color"
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(80, 53)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.OrderLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.NullText = "[Select Order]"
        Me.GridLookUpEdit1.Properties.ValueMember = "OrderId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(141, 20)
        Me.GridLookUpEdit1.TabIndex = 1
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'EditModeCheckEdit
        '
        Me.EditModeCheckEdit.Location = New System.Drawing.Point(456, 53)
        Me.EditModeCheckEdit.Name = "EditModeCheckEdit"
        Me.EditModeCheckEdit.Properties.Caption = "Edit Mode"
        Me.EditModeCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.EditModeCheckEdit.TabIndex = 7
        '
        'frmPlanningEntry
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(728, 416)
        Me.Controls.Add(Me.EditModeCheckEdit)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GridLookUpEdit2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlanningGridControl)
        Me.Controls.Add(Me.PlanningBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPlanningEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Planning Entry"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PlanningNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanningBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanningBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlanningBindingNavigator.ResumeLayout(False)
        Me.PlanningBindingNavigator.PerformLayout()
        CType(Me.PlanningGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditModeCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PlanningNewDataSet As KSoft_Apparel.PlanningNewDataSet
    Friend WithEvents PlanningBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanningTableAdapter As KSoft_Apparel.PlanningNewDataSetTableAdapters.PlanningTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PlanningNewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlanningBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents PlanningBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PlanningGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanningFromDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanningToDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanningQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
    Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EditModeCheckEdit As DevExpress.XtraEditors.CheckEdit

End Class
