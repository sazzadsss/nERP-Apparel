<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SewingInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SewingInput))
        Me.OrderColorPOLookupTableAdapter = New KSoft_Apparel.OrderColorPOLookupDataSetTableAdapters.OrderColorPOLookupTableAdapter()
        Me.OrderColorPOLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderColorPOLookupDataSet = New KSoft_Apparel.OrderColorPOLookupDataSet()
        Me.OrderColorPOLookupDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricColorComboBox = New System.Windows.Forms.ComboBox()
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BranchComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SizeLookupDataSet = New KSoft_Apparel.SizeLookupDataSet()
        Me.SizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeLookupTableAdapter = New KSoft_Apparel.SizeLookupDataSetTableAdapters.SizeLookupTableAdapter()
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.SewingInputDataSet = New KSoft_Apparel.SewingInputDataSet()
        Me.SewingInputBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingInputTableAdapter = New KSoft_Apparel.SewingInputDataSetTableAdapters.SewingInputTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SewingInputDataSetTableAdapters.TableAdapterManager()
        Me.SewingInputGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInputQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalanceQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLInputQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.FinishingInputBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SewingInputBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SIZELABEL = New System.Windows.Forms.Label()
        Me.TTLINPUTQUANTITYLABEL = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.OrderColorPOLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderColorPOLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderColorPOLookupDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingInputDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingInputBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingInputGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingInputBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FinishingInputBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrderColorPOLookupTableAdapter
        '
        Me.OrderColorPOLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderColorPOLookupBindingSource
        '
        Me.OrderColorPOLookupBindingSource.DataMember = "OrderColorPOLookup"
        Me.OrderColorPOLookupBindingSource.DataSource = Me.OrderColorPOLookupDataSet
        '
        'OrderColorPOLookupDataSet
        '
        Me.OrderColorPOLookupDataSet.DataSetName = "OrderColorPOLookupDataSet"
        Me.OrderColorPOLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderColorPOLookupDataGridView
        '
        Me.OrderColorPOLookupDataGridView.AllowUserToAddRows = False
        Me.OrderColorPOLookupDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderColorPOLookupDataGridView.AutoGenerateColumns = False
        Me.OrderColorPOLookupDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.OrderColorPOLookupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderColorPOLookupDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.OrderQuantity, Me.InputQuantity, Me.Balance})
        Me.OrderColorPOLookupDataGridView.DataSource = Me.OrderColorPOLookupBindingSource
        Me.OrderColorPOLookupDataGridView.Location = New System.Drawing.Point(10, 105)
        Me.OrderColorPOLookupDataGridView.Name = "OrderColorPOLookupDataGridView"
        Me.OrderColorPOLookupDataGridView.ReadOnly = True
        Me.OrderColorPOLookupDataGridView.Size = New System.Drawing.Size(772, 185)
        Me.OrderColorPOLookupDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EX"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EX"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'OrderQuantity
        '
        Me.OrderQuantity.DataPropertyName = "OrderQuantity"
        Me.OrderQuantity.HeaderText = "Order Quantity"
        Me.OrderQuantity.Name = "OrderQuantity"
        Me.OrderQuantity.ReadOnly = True
        Me.OrderQuantity.Width = 75
        '
        'InputQuantity
        '
        Me.InputQuantity.DataPropertyName = "InputQuantity"
        Me.InputQuantity.HeaderText = "Input Quantity"
        Me.InputQuantity.Name = "InputQuantity"
        Me.InputQuantity.ReadOnly = True
        Me.InputQuantity.Width = 75
        '
        'Balance
        '
        Me.Balance.DataPropertyName = "Balance"
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(120, 64)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(115, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 23
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.EnforceConstraints = False
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'FabricColorComboBox
        '
        Me.FabricColorComboBox.DataSource = Me.OrderFabricColorBindingSource
        Me.FabricColorComboBox.DisplayMember = "FabricColorName"
        Me.FabricColorComboBox.FormattingEnabled = True
        Me.FabricColorComboBox.Location = New System.Drawing.Point(305, 63)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(138, 21)
        Me.FabricColorComboBox.TabIndex = 24
        Me.FabricColorComboBox.ValueMember = "FabricColorId"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Branch"
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(305, 35)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(138, 21)
        Me.BranchComboBox.TabIndex = 22
        Me.BranchComboBox.TabStop = False
        Me.BranchComboBox.ValueMember = "BranchId"
        '
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.BranchDataSet
        '
        'BranchDataSet
        '
        Me.BranchDataSet.DataSetName = "BranchDataSet"
        Me.BranchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Program No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Sewing Input Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Color"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(120, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(115, 20)
        Me.DateTimePicker1.TabIndex = 21
        Me.DateTimePicker1.TabStop = False
        '
        'SizeLookupDataSet
        '
        Me.SizeLookupDataSet.DataSetName = "SizeLookupDataSet"
        Me.SizeLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SizeLookupBindingSource
        '
        Me.SizeLookupBindingSource.DataMember = "SizeLookup"
        Me.SizeLookupBindingSource.DataSource = Me.SizeLookupDataSet
        '
        'SizeLookupTableAdapter
        '
        Me.SizeLookupTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'InsertButton
        '
        Me.InsertButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InsertButton.Location = New System.Drawing.Point(788, 165)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(28, 45)
        Me.InsertButton.TabIndex = 30
        Me.InsertButton.Text = ">"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'SewingInputDataSet
        '
        Me.SewingInputDataSet.DataSetName = "SewingInputDataSet"
        Me.SewingInputDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingInputBindingSource
        '
        Me.SewingInputBindingSource.DataMember = "SewingInput"
        Me.SewingInputBindingSource.DataSource = Me.SewingInputDataSet
        '
        'SewingInputTableAdapter
        '
        Me.SewingInputTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SewingInputTableAdapter = Me.SewingInputTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingInputDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingInputGridControl
        '
        Me.SewingInputGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingInputGridControl.DataSource = Me.SewingInputBindingSource
        Me.SewingInputGridControl.Location = New System.Drawing.Point(10, 314)
        Me.SewingInputGridControl.MainView = Me.GridView1
        Me.SewingInputGridControl.Name = "SewingInputGridControl"
        Me.SewingInputGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeGridLookUpEdit})
        Me.SewingInputGridControl.Size = New System.Drawing.Size(772, 194)
        Me.SewingInputGridControl.TabIndex = 30
        Me.SewingInputGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeId, Me.colInputQuantity, Me.colRemarks, Me.colOrderQuantity, Me.colBalanceQuantity, Me.colTTLInputQuantity})
        Me.GridView1.GridControl = Me.SewingInputGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colSizeId
        '
        Me.colSizeId.Caption = "Size"
        Me.colSizeId.ColumnEdit = Me.SizeGridLookUpEdit
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        Me.colSizeId.Visible = True
        Me.colSizeId.VisibleIndex = 0
        '
        'colInputQuantity
        '
        Me.colInputQuantity.FieldName = "InputQuantity"
        Me.colInputQuantity.Name = "colInputQuantity"
        Me.colInputQuantity.Visible = True
        Me.colInputQuantity.VisibleIndex = 1
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 2
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 3
        '
        'colBalanceQuantity
        '
        Me.colBalanceQuantity.FieldName = "BalanceQuantity"
        Me.colBalanceQuantity.Name = "colBalanceQuantity"
        Me.colBalanceQuantity.Visible = True
        Me.colBalanceQuantity.VisibleIndex = 4
        '
        'colTTLInputQuantity
        '
        Me.colTTLInputQuantity.FieldName = "TTLInputQuantity"
        Me.colTTLInputQuantity.Name = "colTTLInputQuantity"
        Me.colTTLInputQuantity.Visible = True
        Me.colTTLInputQuantity.VisibleIndex = 5
        '
        'SizeGridLookUpEdit
        '
        Me.SizeGridLookUpEdit.AutoHeight = False
        Me.SizeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeGridLookUpEdit.DataSource = Me.SizeLookupBindingSource
        Me.SizeGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeGridLookUpEdit.Name = "SizeGridLookUpEdit"
        Me.SizeGridLookUpEdit.ValueMember = "SizeId"
        Me.SizeGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'FinishingInputBindingNavigator
        '
        Me.FinishingInputBindingNavigator.AddNewItem = Nothing
        Me.FinishingInputBindingNavigator.BindingSource = Me.SewingInputBindingSource
        Me.FinishingInputBindingNavigator.CountItem = Nothing
        Me.FinishingInputBindingNavigator.DeleteItem = Nothing
        Me.FinishingInputBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SewingInputBindingNavigatorSaveItem, Me.PrintToolStripButton})
        Me.FinishingInputBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FinishingInputBindingNavigator.MoveFirstItem = Nothing
        Me.FinishingInputBindingNavigator.MoveLastItem = Nothing
        Me.FinishingInputBindingNavigator.MoveNextItem = Nothing
        Me.FinishingInputBindingNavigator.MovePreviousItem = Nothing
        Me.FinishingInputBindingNavigator.Name = "FinishingInputBindingNavigator"
        Me.FinishingInputBindingNavigator.PositionItem = Nothing
        Me.FinishingInputBindingNavigator.Size = New System.Drawing.Size(828, 25)
        Me.FinishingInputBindingNavigator.TabIndex = 31
        Me.FinishingInputBindingNavigator.Text = "BindingNavigator1"
        '
        'SewingInputBindingNavigatorSaveItem
        '
        Me.SewingInputBindingNavigatorSaveItem.Image = CType(resources.GetObject("SewingInputBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SewingInputBindingNavigatorSaveItem.Name = "SewingInputBindingNavigatorSaveItem"
        Me.SewingInputBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SewingInputBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Print
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(52, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'SIZELABEL
        '
        Me.SIZELABEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SIZELABEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SIZELABEL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIZELABEL.Location = New System.Drawing.Point(66, 526)
        Me.SIZELABEL.Name = "SIZELABEL"
        Me.SIZELABEL.Size = New System.Drawing.Size(64, 20)
        Me.SIZELABEL.TabIndex = 35
        Me.SIZELABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TTLINPUTQUANTITYLABEL
        '
        Me.TTLINPUTQUANTITYLABEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TTLINPUTQUANTITYLABEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLINPUTQUANTITYLABEL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTLINPUTQUANTITYLABEL.Location = New System.Drawing.Point(236, 526)
        Me.TTLINPUTQUANTITYLABEL.Name = "TTLINPUTQUANTITYLABEL"
        Me.TTLINPUTQUANTITYLABEL.Size = New System.Drawing.Size(64, 22)
        Me.TTLINPUTQUANTITYLABEL.TabIndex = 34
        Me.TTLINPUTQUANTITYLABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 529)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 14)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "SIZE :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(142, 530)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 14)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "ONDATE TOTAL :"
        '
        'SewingInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 555)
        Me.Controls.Add(Me.SIZELABEL)
        Me.Controls.Add(Me.TTLINPUTQUANTITYLABEL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FinishingInputBindingNavigator)
        Me.Controls.Add(Me.SewingInputGridControl)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.OrderColorPOLookupDataGridView)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.FabricColorComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "SewingInput"
        Me.Text = "Sewing Input"
        CType(Me.OrderColorPOLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderColorPOLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderColorPOLookupDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingInputDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingInputBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingInputGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingInputBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FinishingInputBindingNavigator.ResumeLayout(False)
        Me.FinishingInputBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrderColorPOLookupTableAdapter As OrderColorPOLookupDataSetTableAdapters.OrderColorPOLookupTableAdapter
    Friend WithEvents OrderColorPOLookupBindingSource As BindingSource
    Friend WithEvents OrderColorPOLookupDataSet As OrderColorPOLookupDataSet
    Friend WithEvents OrderColorPOLookupDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents OrderQuantity As DataGridViewTextBoxColumn
    Friend WithEvents InputQuantity As DataGridViewTextBoxColumn
    Friend WithEvents Balance As DataGridViewTextBoxColumn
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricColorComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BranchComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents SizeLookupDataSet As SizeLookupDataSet
    Friend WithEvents SizeLookupBindingSource As BindingSource
    Friend WithEvents SizeLookupTableAdapter As SizeLookupDataSetTableAdapters.SizeLookupTableAdapter
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents OrderFabricColorBindingSource As BindingSource
    Friend WithEvents OrderFabricColorDataSet As OrderFabricColorDataSet
    Friend WithEvents BranchBindingSource As BindingSource
    Friend WithEvents BranchDataSet As BranchDataSet
    Friend WithEvents BranchTableAdapter As BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents OrderFabricColorTableAdapter As OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents InsertButton As Button
    Friend WithEvents SewingInputDataSet As SewingInputDataSet
    Friend WithEvents SewingInputBindingSource As BindingSource
    Friend WithEvents SewingInputTableAdapter As SewingInputDataSetTableAdapters.SewingInputTableAdapter
    Friend WithEvents TableAdapterManager As SewingInputDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingInputGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colInputQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalanceQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLInputQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FinishingInputBindingNavigator As BindingNavigator
    Friend WithEvents SewingInputBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents SIZELABEL As Label
    Friend WithEvents TTLINPUTQUANTITYLABEL As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
End Class
