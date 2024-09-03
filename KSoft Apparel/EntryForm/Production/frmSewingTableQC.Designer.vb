<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingTableQC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSewingTableQC))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SewingTableQCBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.SewingTableQCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingTableQCDataSet = New KSoft_Apparel.SewingTableQCDataSet()
        Me.SewingTableQCBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineDataSet = New KSoft_Apparel.LineDataSet()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.QCCheckListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QCCheckListDataSet = New KSoft_Apparel.QCCheckListDataSet()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.QCCheckListTableAdapter = New KSoft_Apparel.QCCheckListDataSetTableAdapters.QCCheckListTableAdapter()
        Me.SewingTableQCTableAdapter = New KSoft_Apparel.SewingTableQCDataSetTableAdapters.SewingTableQCTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SewingTableQCDataSetTableAdapters.TableAdapterManager()
        Me.SewingTableQCDetailsTableAdapter = New KSoft_Apparel.SewingTableQCDataSetTableAdapters.SewingTableQCDetailsTableAdapter()
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
        Me.BranchComboBox = New System.Windows.Forms.ComboBox()
        Me.QCDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.SewingTableQCDataGridView = New System.Windows.Forms.DataGridView()
        Me.QCDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LineId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SewingTableQCDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingTableQCDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AlterLabel = New System.Windows.Forms.Label()
        Me.SpotLabel = New System.Windows.Forms.Label()
        Me.RejectLabel = New System.Windows.Forms.Label()
        Me.GetRejectionButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GarmentTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.SewingTableQCBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SewingTableQCBindingNavigator.SuspendLayout()
        CType(Me.SewingTableQCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingTableQCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QCCheckListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QCCheckListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingTableQCDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingTableQCDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingTableQCDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SewingTableQCBindingNavigator
        '
        Me.SewingTableQCBindingNavigator.AddNewItem = Nothing
        Me.SewingTableQCBindingNavigator.BindingSource = Me.SewingTableQCBindingSource
        Me.SewingTableQCBindingNavigator.CountItem = Nothing
        Me.SewingTableQCBindingNavigator.DeleteItem = Nothing
        Me.SewingTableQCBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SewingTableQCBindingNavigatorSaveItem})
        Me.SewingTableQCBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SewingTableQCBindingNavigator.MoveFirstItem = Nothing
        Me.SewingTableQCBindingNavigator.MoveLastItem = Nothing
        Me.SewingTableQCBindingNavigator.MoveNextItem = Nothing
        Me.SewingTableQCBindingNavigator.MovePreviousItem = Nothing
        Me.SewingTableQCBindingNavigator.Name = "SewingTableQCBindingNavigator"
        Me.SewingTableQCBindingNavigator.PositionItem = Nothing
        Me.SewingTableQCBindingNavigator.Size = New System.Drawing.Size(992, 25)
        Me.SewingTableQCBindingNavigator.TabIndex = 0
        Me.SewingTableQCBindingNavigator.Text = "BindingNavigator1"
        '
        'SewingTableQCBindingSource
        '
        Me.SewingTableQCBindingSource.DataMember = "SewingTableQC"
        Me.SewingTableQCBindingSource.DataSource = Me.SewingTableQCDataSet
        '
        'SewingTableQCDataSet
        '
        Me.SewingTableQCDataSet.DataSetName = "SewingTableQCDataSet"
        Me.SewingTableQCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingTableQCBindingNavigatorSaveItem
        '
        Me.SewingTableQCBindingNavigatorSaveItem.Image = CType(resources.GetObject("SewingTableQCBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SewingTableQCBindingNavigatorSaveItem.Name = "SewingTableQCBindingNavigatorSaveItem"
        Me.SewingTableQCBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.SewingTableQCBindingNavigatorSaveItem.Text = "Save Data"
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
        'QCCheckListBindingSource
        '
        Me.QCCheckListBindingSource.DataMember = "QCCheckList"
        Me.QCCheckListBindingSource.DataSource = Me.QCCheckListDataSet
        '
        'QCCheckListDataSet
        '
        Me.QCCheckListDataSet.DataSetName = "QCCheckListDataSet"
        Me.QCCheckListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'QCCheckListTableAdapter
        '
        Me.QCCheckListTableAdapter.ClearBeforeFill = True
        '
        'SewingTableQCTableAdapter
        '
        Me.SewingTableQCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SewingTableQCDetailsTableAdapter = Me.SewingTableQCDetailsTableAdapter
        Me.TableAdapterManager.SewingTableQCTableAdapter = Me.SewingTableQCTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingTableQCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingTableQCDetailsTableAdapter
        '
        Me.SewingTableQCDetailsTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(217, 38)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BranchComboBox.TabIndex = 1
        Me.BranchComboBox.ValueMember = "BranchId"
        '
        'QCDateTimePicker
        '
        Me.QCDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.QCDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.QCDateTimePicker.Location = New System.Drawing.Point(65, 39)
        Me.QCDateTimePicker.Name = "QCDateTimePicker"
        Me.QCDateTimePicker.Size = New System.Drawing.Size(90, 20)
        Me.QCDateTimePicker.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "QC Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Branch"
        '
        'LoadButton
        '
        Me.LoadButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadButton.Location = New System.Drawing.Point(674, 97)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(135, 23)
        Me.LoadButton.TabIndex = 8
        Me.LoadButton.Text = "Load Check List"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'SewingTableQCDataGridView
        '
        Me.SewingTableQCDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingTableQCDataGridView.AutoGenerateColumns = False
        Me.SewingTableQCDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SewingTableQCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SewingTableQCDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QCDate, Me.BranchId, Me.LineId, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Remarks})
        Me.SewingTableQCDataGridView.DataSource = Me.SewingTableQCBindingSource
        Me.SewingTableQCDataGridView.Location = New System.Drawing.Point(12, 70)
        Me.SewingTableQCDataGridView.Name = "SewingTableQCDataGridView"
        Me.SewingTableQCDataGridView.Size = New System.Drawing.Size(656, 346)
        Me.SewingTableQCDataGridView.TabIndex = 1
        '
        'QCDate
        '
        Me.QCDate.DataPropertyName = "QCDate"
        DataGridViewCellStyle5.Format = "dd-MMM-yy"
        Me.QCDate.DefaultCellStyle = DataGridViewCellStyle5
        Me.QCDate.HeaderText = "QCDate"
        Me.QCDate.Name = "QCDate"
        Me.QCDate.Width = 80
        '
        'BranchId
        '
        Me.BranchId.DataPropertyName = "BranchId"
        Me.BranchId.DataSource = Me.BranchBindingSource
        Me.BranchId.DisplayMember = "BranchCode"
        Me.BranchId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.BranchId.HeaderText = "Branch"
        Me.BranchId.Name = "BranchId"
        Me.BranchId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BranchId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BranchId.ValueMember = "BranchId"
        Me.BranchId.Width = 50
        '
        'LineId
        '
        Me.LineId.DataPropertyName = "LineId"
        Me.LineId.DataSource = Me.LineBindingSource
        Me.LineId.DisplayMember = "Line"
        Me.LineId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.LineId.HeaderText = "Line"
        Me.LineId.Name = "LineId"
        Me.LineId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LineId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.LineId.ValueMember = "LineId"
        Me.LineId.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OrderId"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.OrderLookupBindingSource
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Yellow
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.DisplayMember = "ProgramNo"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "Program No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "OrderId"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CheckQuantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Check Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "OKQuantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "OK Quantity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ALTEROKQuantity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ALTER OK Quantity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Width = 200
        '
        'SewingTableQCDetailsBindingSource
        '
        Me.SewingTableQCDetailsBindingSource.DataMember = "FK_SewingTableQCDetails_SewingTableQC"
        Me.SewingTableQCDetailsBindingSource.DataSource = Me.SewingTableQCBindingSource
        '
        'SewingTableQCDetailsDataGridView
        '
        Me.SewingTableQCDetailsDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingTableQCDetailsDataGridView.AutoGenerateColumns = False
        Me.SewingTableQCDetailsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SewingTableQCDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SewingTableQCDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameColumn, Me.DataGridViewTextBoxColumn8})
        Me.SewingTableQCDetailsDataGridView.DataSource = Me.SewingTableQCDetailsBindingSource
        Me.SewingTableQCDetailsDataGridView.Location = New System.Drawing.Point(674, 159)
        Me.SewingTableQCDetailsDataGridView.Name = "SewingTableQCDetailsDataGridView"
        Me.SewingTableQCDetailsDataGridView.Size = New System.Drawing.Size(297, 258)
        Me.SewingTableQCDetailsDataGridView.TabIndex = 11
        '
        'NameColumn
        '
        Me.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameColumn.DataPropertyName = "QCCheckListId"
        Me.NameColumn.DataSource = Me.QCCheckListBindingSource
        Me.NameColumn.DisplayMember = "Name"
        Me.NameColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.NameColumn.HeaderText = "Check Item"
        Me.NameColumn.Name = "NameColumn"
        Me.NameColumn.ReadOnly = True
        Me.NameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.NameColumn.ValueMember = "QCCheckListId"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(815, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Alter"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(815, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Spot n Shade"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(815, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Reject"
        '
        'AlterLabel
        '
        Me.AlterLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AlterLabel.Location = New System.Drawing.Point(893, 70)
        Me.AlterLabel.Name = "AlterLabel"
        Me.AlterLabel.Size = New System.Drawing.Size(78, 16)
        Me.AlterLabel.TabIndex = 15
        '
        'SpotLabel
        '
        Me.SpotLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpotLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SpotLabel.Location = New System.Drawing.Point(893, 88)
        Me.SpotLabel.Name = "SpotLabel"
        Me.SpotLabel.Size = New System.Drawing.Size(78, 16)
        Me.SpotLabel.TabIndex = 16
        '
        'RejectLabel
        '
        Me.RejectLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RejectLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RejectLabel.Location = New System.Drawing.Point(893, 106)
        Me.RejectLabel.Name = "RejectLabel"
        Me.RejectLabel.Size = New System.Drawing.Size(78, 16)
        Me.RejectLabel.TabIndex = 17
        '
        'GetRejectionButton
        '
        Me.GetRejectionButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GetRejectionButton.Location = New System.Drawing.Point(530, 36)
        Me.GetRejectionButton.Name = "GetRejectionButton"
        Me.GetRejectionButton.Size = New System.Drawing.Size(135, 23)
        Me.GetRejectionButton.TabIndex = 18
        Me.GetRejectionButton.Text = "Get Rejection"
        Me.GetRejectionButton.UseVisualStyleBackColor = True
        Me.GetRejectionButton.Visible = False
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(674, 133)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(213, 20)
        Me.SearchTextBox.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(893, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 21)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GarmentTypeComboBox
        '
        Me.GarmentTypeComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GarmentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GarmentTypeComboBox.FormattingEnabled = True
        Me.GarmentTypeComboBox.Items.AddRange(New Object() {"T-Shirt", "Pant", "Jacket", "Polo-Shirt"})
        Me.GarmentTypeComboBox.Location = New System.Drawing.Point(674, 70)
        Me.GarmentTypeComboBox.Name = "GarmentTypeComboBox"
        Me.GarmentTypeComboBox.Size = New System.Drawing.Size(135, 21)
        Me.GarmentTypeComboBox.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(671, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Garment Type"
        '
        'frmSewingTableQC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 437)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GarmentTypeComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.GetRejectionButton)
        Me.Controls.Add(Me.RejectLabel)
        Me.Controls.Add(Me.SpotLabel)
        Me.Controls.Add(Me.AlterLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SewingTableQCDetailsDataGridView)
        Me.Controls.Add(Me.SewingTableQCDataGridView)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.SewingTableQCBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QCDateTimePicker)
        Me.Name = "frmSewingTableQC"
        Me.Text = "Sewing Table QC"
        CType(Me.SewingTableQCBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SewingTableQCBindingNavigator.ResumeLayout(False)
        Me.SewingTableQCBindingNavigator.PerformLayout()
        CType(Me.SewingTableQCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingTableQCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QCCheckListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QCCheckListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingTableQCDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingTableQCDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingTableQCDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SewingTableQCDataSet As KSoft_Apparel.SewingTableQCDataSet
    Friend WithEvents SewingTableQCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingTableQCTableAdapter As KSoft_Apparel.SewingTableQCDataSetTableAdapters.SewingTableQCTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SewingTableQCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingTableQCBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents SewingTableQCBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents QCCheckListDataSet As KSoft_Apparel.QCCheckListDataSet
    Friend WithEvents QCCheckListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QCCheckListTableAdapter As KSoft_Apparel.QCCheckListDataSetTableAdapters.QCCheckListTableAdapter
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
    Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QCDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents SewingTableQCDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SewingTableQCDetailsTableAdapter As KSoft_Apparel.SewingTableQCDataSetTableAdapters.SewingTableQCDetailsTableAdapter
    Friend WithEvents SewingTableQCDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingTableQCDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AlterLabel As System.Windows.Forms.Label
    Friend WithEvents SpotLabel As System.Windows.Forms.Label
    Friend WithEvents RejectLabel As System.Windows.Forms.Label
    Friend WithEvents GetRejectionButton As System.Windows.Forms.Button
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents QCDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents LineId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GarmentTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
