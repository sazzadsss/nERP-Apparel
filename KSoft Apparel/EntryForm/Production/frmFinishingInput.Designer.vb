<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinishingInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinishingInput))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FinishingInputDataSet = New KSoft_Apparel.FinishingInputDataSet()
        Me.FinishingInputBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishingInputTableAdapter = New KSoft_Apparel.FinishingInputDataSetTableAdapters.FinishingInputTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.FinishingInputDataSetTableAdapters.TableAdapterManager()
        Me.FinishingInputBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.FinishingInputBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FinishingInputDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeLookupDataSet = New KSoft_Apparel.SizeLookupDataSet()
        Me.OrderQuantityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputQuantityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTLInputQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeLookupTableAdapter = New KSoft_Apparel.SizeLookupDataSetTableAdapters.SizeLookupTableAdapter()
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
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.OrderColorPOLookupDataSet = New KSoft_Apparel.OrderColorPOLookupDataSet()
        Me.OrderColorPOLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderColorPOLookupTableAdapter = New KSoft_Apparel.OrderColorPOLookupDataSetTableAdapters.OrderColorPOLookupTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Apparel.OrderColorPOLookupDataSetTableAdapters.TableAdapterManager()
        Me.OrderColorPOLookupDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SIZELABEL = New System.Windows.Forms.Label()
        Me.TTLINPUTQUANTITYLABEL = New System.Windows.Forms.Label()
        CType(Me.FinishingInputDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingInputBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingInputBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FinishingInputBindingNavigator.SuspendLayout()
        CType(Me.FinishingInputDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderColorPOLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderColorPOLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderColorPOLookupDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FinishingInputDataSet
        '
        Me.FinishingInputDataSet.DataSetName = "FinishingInputDataSet"
        Me.FinishingInputDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishingInputBindingSource
        '
        Me.FinishingInputBindingSource.DataMember = "FinishingInput"
        Me.FinishingInputBindingSource.DataSource = Me.FinishingInputDataSet
        '
        'FinishingInputTableAdapter
        '
        Me.FinishingInputTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishingInputTableAdapter = Me.FinishingInputTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FinishingInputDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FinishingInputBindingNavigator
        '
        Me.FinishingInputBindingNavigator.AddNewItem = Nothing
        Me.FinishingInputBindingNavigator.BindingSource = Me.FinishingInputBindingSource
        Me.FinishingInputBindingNavigator.CountItem = Nothing
        Me.FinishingInputBindingNavigator.DeleteItem = Nothing
        Me.FinishingInputBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinishingInputBindingNavigatorSaveItem, Me.PrintToolStripButton})
        Me.FinishingInputBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FinishingInputBindingNavigator.MoveFirstItem = Nothing
        Me.FinishingInputBindingNavigator.MoveLastItem = Nothing
        Me.FinishingInputBindingNavigator.MoveNextItem = Nothing
        Me.FinishingInputBindingNavigator.MovePreviousItem = Nothing
        Me.FinishingInputBindingNavigator.Name = "FinishingInputBindingNavigator"
        Me.FinishingInputBindingNavigator.PositionItem = Nothing
        Me.FinishingInputBindingNavigator.Size = New System.Drawing.Size(674, 25)
        Me.FinishingInputBindingNavigator.TabIndex = 0
        Me.FinishingInputBindingNavigator.Text = "BindingNavigator1"
        '
        'FinishingInputBindingNavigatorSaveItem
        '
        Me.FinishingInputBindingNavigatorSaveItem.Image = CType(resources.GetObject("FinishingInputBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FinishingInputBindingNavigatorSaveItem.Name = "FinishingInputBindingNavigatorSaveItem"
        Me.FinishingInputBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.FinishingInputBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Print
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(52, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'FinishingInputDataGridView
        '
        Me.FinishingInputDataGridView.AllowUserToAddRows = False
        Me.FinishingInputDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinishingInputDataGridView.AutoGenerateColumns = False
        Me.FinishingInputDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FinishingInputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FinishingInputDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.OrderQuantityColumn, Me.InputQuantityColumn, Me.TTLInputQuantity, Me.BalanceQuantity, Me.Remarks})
        Me.FinishingInputDataGridView.DataSource = Me.FinishingInputBindingSource
        Me.FinishingInputDataGridView.Location = New System.Drawing.Point(22, 297)
        Me.FinishingInputDataGridView.Name = "FinishingInputDataGridView"
        Me.FinishingInputDataGridView.Size = New System.Drawing.Size(603, 189)
        Me.FinishingInputDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SizeId"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.SizeLookupBindingSource
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.DisplayMember = "SizeCode"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn5.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "SizeId"
        '
        'SizeLookupBindingSource
        '
        Me.SizeLookupBindingSource.DataMember = "SizeLookup"
        Me.SizeLookupBindingSource.DataSource = Me.SizeLookupDataSet
        '
        'SizeLookupDataSet
        '
        Me.SizeLookupDataSet.DataSetName = "SizeLookupDataSet"
        Me.SizeLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderQuantityColumn
        '
        Me.OrderQuantityColumn.DataPropertyName = "OrderQuantity"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.OrderQuantityColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.OrderQuantityColumn.HeaderText = "Order Quantity"
        Me.OrderQuantityColumn.Name = "OrderQuantityColumn"
        Me.OrderQuantityColumn.ReadOnly = True
        Me.OrderQuantityColumn.Width = 75
        '
        'InputQuantityColumn
        '
        Me.InputQuantityColumn.DataPropertyName = "InputQuantity"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.InputQuantityColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.InputQuantityColumn.HeaderText = "Input Quantity"
        Me.InputQuantityColumn.Name = "InputQuantityColumn"
        Me.InputQuantityColumn.Width = 75
        '
        'TTLInputQuantity
        '
        Me.TTLInputQuantity.DataPropertyName = "TTLInputQuantity"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TTLInputQuantity.DefaultCellStyle = DataGridViewCellStyle4
        Me.TTLInputQuantity.HeaderText = "TTL Input Quantity"
        Me.TTLInputQuantity.Name = "TTLInputQuantity"
        Me.TTLInputQuantity.ReadOnly = True
        '
        'BalanceQuantity
        '
        Me.BalanceQuantity.DataPropertyName = "BalanceQuantity"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BalanceQuantity.DefaultCellStyle = DataGridViewCellStyle5
        Me.BalanceQuantity.HeaderText = "Balance Quantity"
        Me.BalanceQuantity.Name = "BalanceQuantity"
        Me.BalanceQuantity.ReadOnly = True
        Me.BalanceQuantity.Width = 75
        '
        'Remarks
        '
        Me.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        '
        'SizeLookupTableAdapter
        '
        Me.SizeLookupTableAdapter.ClearBeforeFill = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(109, 67)
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
        Me.ProgramNoGridLookUpEdit.TabIndex = 15
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
        Me.FabricColorComboBox.Location = New System.Drawing.Point(294, 66)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(138, 21)
        Me.FabricColorComboBox.TabIndex = 16
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
        Me.Label5.Location = New System.Drawing.Point(244, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Branch"
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(294, 38)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(138, 21)
        Me.BranchComboBox.TabIndex = 14
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
        Me.Label3.Location = New System.Drawing.Point(23, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Program No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Finishing Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(244, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Color"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(109, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(115, 20)
        Me.DateTimePicker1.TabIndex = 13
        Me.DateTimePicker1.TabStop = False
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
        'OrderColorPOLookupDataSet
        '
        Me.OrderColorPOLookupDataSet.DataSetName = "OrderColorPOLookupDataSet"
        Me.OrderColorPOLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderColorPOLookupBindingSource
        '
        Me.OrderColorPOLookupBindingSource.DataMember = "OrderColorPOLookup"
        Me.OrderColorPOLookupBindingSource.DataSource = Me.OrderColorPOLookupDataSet
        '
        'OrderColorPOLookupTableAdapter
        '
        Me.OrderColorPOLookupTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.OrderColorPOLookupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrderColorPOLookupDataGridView
        '
        Me.OrderColorPOLookupDataGridView.AllowUserToAddRows = False
        Me.OrderColorPOLookupDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderColorPOLookupDataGridView.AutoGenerateColumns = False
        Me.OrderColorPOLookupDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.OrderColorPOLookupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderColorPOLookupDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.OrderQuantity, Me.InputQuantity, Me.Balance})
        Me.OrderColorPOLookupDataGridView.DataSource = Me.OrderColorPOLookupBindingSource
        Me.OrderColorPOLookupDataGridView.Location = New System.Drawing.Point(22, 106)
        Me.OrderColorPOLookupDataGridView.Name = "OrderColorPOLookupDataGridView"
        Me.OrderColorPOLookupDataGridView.ReadOnly = True
        Me.OrderColorPOLookupDataGridView.Size = New System.Drawing.Size(603, 185)
        Me.OrderColorPOLookupDataGridView.TabIndex = 20
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
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(631, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 45)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(151, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 14)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "ONDATE TOTAL :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 497)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 14)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "SIZE :"
        '
        'SIZELABEL
        '
        Me.SIZELABEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SIZELABEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SIZELABEL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIZELABEL.Location = New System.Drawing.Point(75, 494)
        Me.SIZELABEL.Name = "SIZELABEL"
        Me.SIZELABEL.Size = New System.Drawing.Size(64, 20)
        Me.SIZELABEL.TabIndex = 25
        Me.SIZELABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TTLINPUTQUANTITYLABEL
        '
        Me.TTLINPUTQUANTITYLABEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TTLINPUTQUANTITYLABEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLINPUTQUANTITYLABEL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTLINPUTQUANTITYLABEL.Location = New System.Drawing.Point(245, 494)
        Me.TTLINPUTQUANTITYLABEL.Name = "TTLINPUTQUANTITYLABEL"
        Me.TTLINPUTQUANTITYLABEL.Size = New System.Drawing.Size(64, 22)
        Me.TTLINPUTQUANTITYLABEL.TabIndex = 24
        Me.TTLINPUTQUANTITYLABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmFinishingInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 532)
        Me.Controls.Add(Me.SIZELABEL)
        Me.Controls.Add(Me.TTLINPUTQUANTITYLABEL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OrderColorPOLookupDataGridView)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.FabricColorComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.FinishingInputDataGridView)
        Me.Controls.Add(Me.FinishingInputBindingNavigator)
        Me.Name = "frmFinishingInput"
        Me.Text = "Finishing Input"
        CType(Me.FinishingInputDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingInputBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingInputBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FinishingInputBindingNavigator.ResumeLayout(False)
        Me.FinishingInputBindingNavigator.PerformLayout()
        CType(Me.FinishingInputDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderColorPOLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderColorPOLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderColorPOLookupDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FinishingInputDataSet As KSoft_Apparel.FinishingInputDataSet
    Friend WithEvents FinishingInputBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishingInputTableAdapter As KSoft_Apparel.FinishingInputDataSetTableAdapters.FinishingInputTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FinishingInputDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FinishingInputBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents FinishingInputBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FinishingInputDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SizeLookupDataSet As KSoft_Apparel.SizeLookupDataSet
    Friend WithEvents SizeLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeLookupTableAdapter As KSoft_Apparel.SizeLookupDataSetTableAdapters.SizeLookupTableAdapter
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderColorPOLookupDataSet As KSoft_Apparel.OrderColorPOLookupDataSet
    Friend WithEvents OrderColorPOLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderColorPOLookupTableAdapter As KSoft_Apparel.OrderColorPOLookupDataSetTableAdapters.OrderColorPOLookupTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.OrderColorPOLookupDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderColorPOLookupDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InputQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SIZELABEL As System.Windows.Forms.Label
    Friend WithEvents TTLINPUTQUANTITYLABEL As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents OrderQuantityColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InputQuantityColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TTLInputQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
End Class
