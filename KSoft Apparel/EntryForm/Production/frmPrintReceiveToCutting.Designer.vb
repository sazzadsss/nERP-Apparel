<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintReceiveToCutting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintReceiveToCutting))
        Me.PrintReceiveToCuttingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.PrintReceiveToCuttingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintReceiveDataSet = New KSoft_Apparel.PrintReceiveDataSet
        Me.PrintReceiveToCuttingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PrintReceiveToCuttingDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintReceiveDetailsToCuttingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintReceiveDetailsToCuttingDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintReceiveToCuttingTableAdapter = New KSoft_Apparel.PrintReceiveDataSetTableAdapters.PrintReceiveToCuttingTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.PrintReceiveDataSetTableAdapters.TableAdapterManager
        Me.PrintReceiveDetailsToCuttingTableAdapter = New KSoft_Apparel.PrintReceiveDataSetTableAdapters.PrintReceiveDetailsToCuttingTableAdapter
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label4 = New System.Windows.Forms.Label
        Me.OrderNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsMultiPart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.FabricColorComboBox = New System.Windows.Forms.ComboBox
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet
        Me.MultipartLabel = New System.Windows.Forms.Label
        Me.MultipartComboBox = New System.Windows.Forms.ComboBox
        Me.TwinPackfilteredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TwinPackLookupDataSet = New KSoft_Apparel.TwinPackLookupDataSet
        Me.NewButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.BranchComboBox = New System.Windows.Forms.ComboBox
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet
        Me.Label3 = New System.Windows.Forms.Label
        Me.CuttingDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
        Me.TwinPackfilteredTableAdapter = New KSoft_Apparel.TwinPackLookupDataSetTableAdapters.TwinPackfilteredTableAdapter
        CType(Me.PrintReceiveToCuttingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrintReceiveToCuttingBindingNavigator.SuspendLayout()
        CType(Me.PrintReceiveToCuttingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintReceiveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintReceiveToCuttingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintReceiveDetailsToCuttingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintReceiveDetailsToCuttingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwinPackfilteredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwinPackLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintReceiveToCuttingBindingNavigator
        '
        Me.PrintReceiveToCuttingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PrintReceiveToCuttingBindingNavigator.BindingSource = Me.PrintReceiveToCuttingBindingSource
        Me.PrintReceiveToCuttingBindingNavigator.CountItem = Nothing
        Me.PrintReceiveToCuttingBindingNavigator.DeleteItem = Nothing
        Me.PrintReceiveToCuttingBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PrintReceiveToCuttingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.PrintReceiveToCuttingBindingNavigatorSaveItem})
        Me.PrintReceiveToCuttingBindingNavigator.Location = New System.Drawing.Point(747, 17)
        Me.PrintReceiveToCuttingBindingNavigator.MoveFirstItem = Nothing
        Me.PrintReceiveToCuttingBindingNavigator.MoveLastItem = Nothing
        Me.PrintReceiveToCuttingBindingNavigator.MoveNextItem = Nothing
        Me.PrintReceiveToCuttingBindingNavigator.MovePreviousItem = Nothing
        Me.PrintReceiveToCuttingBindingNavigator.Name = "PrintReceiveToCuttingBindingNavigator"
        Me.PrintReceiveToCuttingBindingNavigator.PositionItem = Nothing
        Me.PrintReceiveToCuttingBindingNavigator.Size = New System.Drawing.Size(113, 25)
        Me.PrintReceiveToCuttingBindingNavigator.TabIndex = 0
        Me.PrintReceiveToCuttingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'PrintReceiveToCuttingBindingSource
        '
        Me.PrintReceiveToCuttingBindingSource.DataMember = "PrintReceiveToCutting"
        Me.PrintReceiveToCuttingBindingSource.DataSource = Me.PrintReceiveDataSet
        '
        'PrintReceiveDataSet
        '
        Me.PrintReceiveDataSet.DataSetName = "PrintReceiveDataSet"
        Me.PrintReceiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintReceiveToCuttingBindingNavigatorSaveItem
        '
        Me.PrintReceiveToCuttingBindingNavigatorSaveItem.Image = CType(resources.GetObject("PrintReceiveToCuttingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PrintReceiveToCuttingBindingNavigatorSaveItem.Name = "PrintReceiveToCuttingBindingNavigatorSaveItem"
        Me.PrintReceiveToCuttingBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.PrintReceiveToCuttingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintReceiveToCuttingDataGridView
        '
        Me.PrintReceiveToCuttingDataGridView.AutoGenerateColumns = False
        Me.PrintReceiveToCuttingDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PrintReceiveToCuttingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrintReceiveToCuttingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.PrintReceiveToCuttingDataGridView.DataSource = Me.PrintReceiveToCuttingBindingSource
        Me.PrintReceiveToCuttingDataGridView.Location = New System.Drawing.Point(12, 97)
        Me.PrintReceiveToCuttingDataGridView.Name = "PrintReceiveToCuttingDataGridView"
        Me.PrintReceiveToCuttingDataGridView.Size = New System.Drawing.Size(849, 154)
        Me.PrintReceiveToCuttingDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PrintReceiveDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PrintReceiveDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ChallanNo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ChallanNo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "OrderId"
        Me.DataGridViewTextBoxColumn3.HeaderText = "OrderId"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FabricColorId"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FabricColorId"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CuttingNo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CuttingNo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'PrintReceiveDetailsToCuttingBindingSource
        '
        Me.PrintReceiveDetailsToCuttingBindingSource.DataMember = "FK_PrintReceiveDetailsToCutting_PrintReceiveToCutting"
        Me.PrintReceiveDetailsToCuttingBindingSource.DataSource = Me.PrintReceiveToCuttingBindingSource
        '
        'PrintReceiveDetailsToCuttingDataGridView
        '
        Me.PrintReceiveDetailsToCuttingDataGridView.AutoGenerateColumns = False
        Me.PrintReceiveDetailsToCuttingDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrintReceiveDetailsToCuttingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrintReceiveDetailsToCuttingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.PrintReceiveDetailsToCuttingDataGridView.DataSource = Me.PrintReceiveDetailsToCuttingBindingSource
        Me.PrintReceiveDetailsToCuttingDataGridView.Location = New System.Drawing.Point(12, 280)
        Me.PrintReceiveDetailsToCuttingDataGridView.Name = "PrintReceiveDetailsToCuttingDataGridView"
        Me.PrintReceiveDetailsToCuttingDataGridView.Size = New System.Drawing.Size(849, 183)
        Me.PrintReceiveDetailsToCuttingDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SizeId"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PrintPartId"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Panel"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ReceiveQuantity"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Receive Quantity"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'PrintReceiveToCuttingTableAdapter
        '
        Me.PrintReceiveToCuttingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PrintReceiveDetailsToCuttingTableAdapter = Me.PrintReceiveDetailsToCuttingTableAdapter
        Me.TableAdapterManager.PrintReceiveToCuttingTableAdapter = Me.PrintReceiveToCuttingTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PrintReceiveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintReceiveDetailsToCuttingTableAdapter
        '
        Me.PrintReceiveDetailsToCuttingTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel2.Controls.Add(Me.OrderNoGridLookUpEdit)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.FabricColorComboBox)
        Me.FlowLayoutPanel2.Controls.Add(Me.MultipartLabel)
        Me.FlowLayoutPanel2.Controls.Add(Me.MultipartComboBox)
        Me.FlowLayoutPanel2.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(12, 48)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(849, 32)
        Me.FlowLayoutPanel2.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Program No"
        '
        'OrderNoGridLookUpEdit
        '
        Me.OrderNoGridLookUpEdit.Location = New System.Drawing.Point(72, 5)
        Me.OrderNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.OrderNoGridLookUpEdit.Name = "OrderNoGridLookUpEdit"
        Me.OrderNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.OrderNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.OrderNoGridLookUpEdit.Size = New System.Drawing.Size(118, 20)
        Me.OrderNoGridLookUpEdit.TabIndex = 11
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
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colProgramNo, Me.colIsPrint, Me.colUserId, Me.colIsMultiPart})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.ReadOnly = True
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        Me.colIsPrint.Visible = True
        Me.colIsPrint.VisibleIndex = 1
        '
        'colUserId
        '
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        '
        'colIsMultiPart
        '
        Me.colIsMultiPart.FieldName = "IsMultiPart"
        Me.colIsMultiPart.Name = "colIsMultiPart"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 9, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Color"
        '
        'FabricColorComboBox
        '
        Me.FabricColorComboBox.DataSource = Me.FabricColorBindingSource
        Me.FabricColorComboBox.DisplayMember = "FabricColorName"
        Me.FabricColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FabricColorComboBox.FormattingEnabled = True
        Me.FabricColorComboBox.Location = New System.Drawing.Point(242, 5)
        Me.FabricColorComboBox.Margin = New System.Windows.Forms.Padding(5, 5, 3, 3)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(142, 21)
        Me.FabricColorComboBox.TabIndex = 1
        Me.FabricColorComboBox.ValueMember = "FabricColorId"
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
        'MultipartLabel
        '
        Me.MultipartLabel.AutoSize = True
        Me.MultipartLabel.Location = New System.Drawing.Point(392, 9)
        Me.MultipartLabel.Margin = New System.Windows.Forms.Padding(5, 9, 3, 0)
        Me.MultipartLabel.Name = "MultipartLabel"
        Me.MultipartLabel.Size = New System.Drawing.Size(47, 13)
        Me.MultipartLabel.TabIndex = 6
        Me.MultipartLabel.Text = "Multipart"
        '
        'MultipartComboBox
        '
        Me.MultipartComboBox.DataSource = Me.TwinPackfilteredBindingSource
        Me.MultipartComboBox.DisplayMember = "Details"
        Me.MultipartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MultipartComboBox.FormattingEnabled = True
        Me.MultipartComboBox.Location = New System.Drawing.Point(445, 5)
        Me.MultipartComboBox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.MultipartComboBox.Name = "MultipartComboBox"
        Me.MultipartComboBox.Size = New System.Drawing.Size(140, 21)
        Me.MultipartComboBox.TabIndex = 2
        Me.MultipartComboBox.ValueMember = "TwinPackId"
        '
        'TwinPackfilteredBindingSource
        '
        Me.TwinPackfilteredBindingSource.DataMember = "TwinPackfiltered"
        Me.TwinPackfilteredBindingSource.DataSource = Me.TwinPackLookupDataSet
        '
        'TwinPackLookupDataSet
        '
        Me.TwinPackLookupDataSet.DataSetName = "TwinPackLookupDataSet"
        Me.TwinPackLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NewButton
        '
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        'Me.NewButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Add_icon
        Me.NewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton.Location = New System.Drawing.Point(596, 3)
        Me.NewButton.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(100, 24)
        Me.NewButton.TabIndex = 3
        Me.NewButton.Text = "&Add [ F3 ]"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Branch"
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(248, 21)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(108, 21)
        Me.BranchComboBox.TabIndex = 12
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
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cutting Date"
        '
        'CuttingDateTimePicker
        '
        Me.CuttingDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.CuttingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CuttingDateTimePicker.Location = New System.Drawing.Point(88, 22)
        Me.CuttingDateTimePicker.Name = "CuttingDateTimePicker"
        Me.CuttingDateTimePicker.Size = New System.Drawing.Size(93, 20)
        Me.CuttingDateTimePicker.TabIndex = 11
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'TwinPackfilteredTableAdapter
        '
        Me.TwinPackfilteredTableAdapter.ClearBeforeFill = True
        '
        'frmPrintReceiveToCutting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 485)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CuttingDateTimePicker)
        Me.Controls.Add(Me.PrintReceiveDetailsToCuttingDataGridView)
        Me.Controls.Add(Me.PrintReceiveToCuttingDataGridView)
        Me.Controls.Add(Me.PrintReceiveToCuttingBindingNavigator)
        Me.Name = "frmPrintReceiveToCutting"
        Me.Text = "Print Receive to Cutting"
        CType(Me.PrintReceiveToCuttingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrintReceiveToCuttingBindingNavigator.ResumeLayout(False)
        Me.PrintReceiveToCuttingBindingNavigator.PerformLayout()
        CType(Me.PrintReceiveToCuttingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintReceiveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintReceiveToCuttingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintReceiveDetailsToCuttingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintReceiveDetailsToCuttingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.OrderNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwinPackfilteredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwinPackLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintReceiveDataSet As KSoft_Apparel.PrintReceiveDataSet
    Friend WithEvents PrintReceiveToCuttingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintReceiveToCuttingTableAdapter As KSoft_Apparel.PrintReceiveDataSetTableAdapters.PrintReceiveToCuttingTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PrintReceiveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrintReceiveToCuttingBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintReceiveToCuttingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintReceiveToCuttingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PrintReceiveDetailsToCuttingTableAdapter As KSoft_Apparel.PrintReceiveDataSetTableAdapters.PrintReceiveDetailsToCuttingTableAdapter
    Friend WithEvents PrintReceiveDetailsToCuttingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintReceiveDetailsToCuttingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OrderNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMultiPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FabricColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MultipartLabel As System.Windows.Forms.Label
    Friend WithEvents MultipartComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CuttingDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents TwinPackfilteredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TwinPackLookupDataSet As KSoft_Apparel.TwinPackLookupDataSet
    Friend WithEvents TwinPackfilteredTableAdapter As KSoft_Apparel.TwinPackLookupDataSetTableAdapters.TwinPackfilteredTableAdapter
End Class
