<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintOrder
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.PrintProductionDataSet = New KSoft_Apparel.PrintProductionDataSet
        Me.PrintOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintOrderTableAdapter = New KSoft_Apparel.PrintProductionDataSetTableAdapters.PrintOrderTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.PrintProductionDataSetTableAdapters.TableAdapterManager
        Me.PrintOrderDataGridView = New System.Windows.Forms.DataGridView
        Me.ProgramNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FabricColorName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StyleId = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.PrintPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintPartDataSet = New KSoft_Apparel.PrintPartDataSet
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.PrintTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintTypeDataSet = New KSoft_Apparel.PrintTypeDataSet
        Me.PrintColorQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintOrderQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MainPart = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.ProgramNoComboBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.PrintTypeTableAdapter = New KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter
        Me.PrintPartTableAdapter = New KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter
        Me.SaveButton = New System.Windows.Forms.Button
        Me.ProgramNoTextBox = New System.Windows.Forms.TextBox
        Me.FabricColorTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.InHouseRadioButton = New System.Windows.Forms.RadioButton
        Me.OutSideRadioButton = New System.Windows.Forms.RadioButton
        Me.FabricColorComboBox = New System.Windows.Forms.ComboBox
        Me.StyleTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter
        CType(Me.PrintProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintProductionDataSet
        '
        Me.PrintProductionDataSet.DataSetName = "PrintProductionDataSet"
        Me.PrintProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintOrderBindingSource
        '
        Me.PrintOrderBindingSource.DataMember = "PrintOrder"
        Me.PrintOrderBindingSource.DataSource = Me.PrintProductionDataSet
        '
        'PrintOrderTableAdapter
        '
        Me.PrintOrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PrintHourlyProductionTableAdapter = Nothing
        Me.TableAdapterManager.PrintHourlyQCTableAdapter = Nothing
        Me.TableAdapterManager.PrintOrderTableAdapter = Me.PrintOrderTableAdapter
        Me.TableAdapterManager.PrintProductionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PrintProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintOrderDataGridView
        '
        Me.PrintOrderDataGridView.AllowUserToAddRows = False
        Me.PrintOrderDataGridView.AllowUserToDeleteRows = False
        Me.PrintOrderDataGridView.AutoGenerateColumns = False
        Me.PrintOrderDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PrintOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrintOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProgramNo, Me.FabricColorName, Me.StyleId, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn5, Me.PrintColorQuantity, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.PrintOrderQuantity, Me.MainPart, Me.DataGridViewTextBoxColumn7})
        Me.PrintOrderDataGridView.DataSource = Me.PrintOrderBindingSource
        Me.PrintOrderDataGridView.Location = New System.Drawing.Point(0, 39)
        Me.PrintOrderDataGridView.Name = "PrintOrderDataGridView"
        Me.PrintOrderDataGridView.ReadOnly = True
        Me.PrintOrderDataGridView.Size = New System.Drawing.Size(824, 333)
        Me.PrintOrderDataGridView.TabIndex = 72
        '
        'ProgramNo
        '
        Me.ProgramNo.DataPropertyName = "ProgramNo"
        Me.ProgramNo.HeaderText = "Program No"
        Me.ProgramNo.Name = "ProgramNo"
        Me.ProgramNo.ReadOnly = True
        '
        'FabricColorName
        '
        Me.FabricColorName.DataPropertyName = "FabricColorName"
        Me.FabricColorName.HeaderText = "Fabric Color "
        Me.FabricColorName.Name = "FabricColorName"
        Me.FabricColorName.ReadOnly = True
        '
        'StyleId
        '
        Me.StyleId.DataPropertyName = "StyleId"
        Me.StyleId.DataSource = Me.StyleBindingSource
        Me.StyleId.DisplayMember = "StyleName"
        Me.StyleId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.StyleId.HeaderText = "Style"
        Me.StyleId.Name = "StyleId"
        Me.StyleId.ReadOnly = True
        Me.StyleId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StyleId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.StyleId.ValueMember = "StyleId"
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleDataSet
        '
        'StyleDataSet
        '
        Me.StyleDataSet.DataSetName = "StyleDataSet"
        Me.StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PrintPartId"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.PrintPartBindingSource
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn8.DisplayMember = "PartName"
        Me.DataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn8.HeaderText = "Print Part"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "PrintPartId"
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'PrintPartBindingSource
        '
        Me.PrintPartBindingSource.DataMember = "PrintPart"
        Me.PrintPartBindingSource.DataSource = Me.PrintPartDataSet
        '
        'PrintPartDataSet
        '
        Me.PrintPartDataSet.DataSetName = "PrintPartDataSet"
        Me.PrintPartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PrintTypeId"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.PrintTypeBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "PrintTypeName"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn5.HeaderText = "Print Type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "PrintTypeId"
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'PrintTypeBindingSource
        '
        Me.PrintTypeBindingSource.DataMember = "PrintType"
        Me.PrintTypeBindingSource.DataSource = Me.PrintTypeDataSet
        '
        'PrintTypeDataSet
        '
        Me.PrintTypeDataSet.DataSetName = "PrintTypeDataSet"
        Me.PrintTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintColorQuantity
        '
        Me.PrintColorQuantity.DataPropertyName = "PrintColorQuantity"
        Me.PrintColorQuantity.HeaderText = "Print Color"
        Me.PrintColorQuantity.Name = "PrintColorQuantity"
        Me.PrintColorQuantity.ReadOnly = True
        Me.PrintColorQuantity.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PrintOrderDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Print Order Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PrintOrderExDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Print Ex. Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'PrintOrderQuantity
        '
        Me.PrintOrderQuantity.DataPropertyName = "PrintOrderQuantity"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PrintOrderQuantity.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrintOrderQuantity.HeaderText = "PrintOrderQuantity"
        Me.PrintOrderQuantity.Name = "PrintOrderQuantity"
        Me.PrintOrderQuantity.ReadOnly = True
        '
        'MainPart
        '
        Me.MainPart.DataPropertyName = "MainPart"
        Me.MainPart.HeaderText = "Main Print"
        Me.MainPart.Name = "MainPart"
        Me.MainPart.ReadOnly = True
        Me.MainPart.Width = 40
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 166
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
        'ProgramNoComboBox
        '
        Me.ProgramNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProgramNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProgramNoComboBox.BackColor = System.Drawing.Color.White
        Me.ProgramNoComboBox.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoComboBox.DisplayMember = "ProgramNo"
        Me.ProgramNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ProgramNoComboBox.FormattingEnabled = True
        Me.ProgramNoComboBox.Location = New System.Drawing.Point(323, 13)
        Me.ProgramNoComboBox.Name = "ProgramNoComboBox"
        Me.ProgramNoComboBox.Size = New System.Drawing.Size(108, 21)
        Me.ProgramNoComboBox.TabIndex = 0
        Me.ProgramNoComboBox.ValueMember = "OrderId"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Program No"
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'PrintTypeTableAdapter
        '
        Me.PrintTypeTableAdapter.ClearBeforeFill = True
        '
        'PrintPartTableAdapter
        '
        Me.PrintPartTableAdapter.ClearBeforeFill = True
        '
        'SaveButton
        '
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Location = New System.Drawing.Point(743, 10)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(52, 25)
        Me.SaveButton.TabIndex = 74
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ProgramNoTextBox
        '
        Me.ProgramNoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgramNoTextBox.Location = New System.Drawing.Point(228, 13)
        Me.ProgramNoTextBox.Name = "ProgramNoTextBox"
        Me.ProgramNoTextBox.Size = New System.Drawing.Size(89, 20)
        Me.ProgramNoTextBox.TabIndex = 2
        '
        'FabricColorTextBox
        '
        Me.FabricColorTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FabricColorTextBox.Location = New System.Drawing.Point(518, 13)
        Me.FabricColorTextBox.Name = "FabricColorTextBox"
        Me.FabricColorTextBox.Size = New System.Drawing.Size(107, 20)
        Me.FabricColorTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(437, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fabric Color"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.InHouseRadioButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.OutSideRadioButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ProgramNoTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.ProgramNoComboBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.FabricColorTextBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.FabricColorComboBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.SaveButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(825, 38)
        Me.FlowLayoutPanel1.TabIndex = 75
        '
        'InHouseRadioButton
        '
        Me.InHouseRadioButton.AutoSize = True
        Me.InHouseRadioButton.Checked = True
        Me.InHouseRadioButton.Location = New System.Drawing.Point(3, 13)
        Me.InHouseRadioButton.Name = "InHouseRadioButton"
        Me.InHouseRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.InHouseRadioButton.TabIndex = 5
        Me.InHouseRadioButton.TabStop = True
        Me.InHouseRadioButton.Text = "In House"
        Me.InHouseRadioButton.UseVisualStyleBackColor = True
        '
        'OutSideRadioButton
        '
        Me.OutSideRadioButton.AutoSize = True
        Me.OutSideRadioButton.Location = New System.Drawing.Point(77, 13)
        Me.OutSideRadioButton.Name = "OutSideRadioButton"
        Me.OutSideRadioButton.Size = New System.Drawing.Size(66, 17)
        Me.OutSideRadioButton.TabIndex = 6
        Me.OutSideRadioButton.TabStop = True
        Me.OutSideRadioButton.Text = "Out Side"
        Me.OutSideRadioButton.UseVisualStyleBackColor = True
        '
        'FabricColorComboBox
        '
        Me.FabricColorComboBox.DataSource = Me.OrderFabricColorBindingSource
        Me.FabricColorComboBox.DisplayMember = "FabricColorName"
        Me.FabricColorComboBox.FormattingEnabled = True
        Me.FabricColorComboBox.Location = New System.Drawing.Point(628, 13)
        Me.FabricColorComboBox.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(109, 21)
        Me.FabricColorComboBox.TabIndex = 75
        Me.FabricColorComboBox.ValueMember = "FabricColorId"
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'frmPrintOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 373)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PrintOrderDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrintOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print Order"
        CType(Me.PrintProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintProductionDataSet As KSoft_Apparel.PrintProductionDataSet
    Friend WithEvents PrintOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintOrderTableAdapter As KSoft_Apparel.PrintProductionDataSetTableAdapters.PrintOrderTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PrintProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrintOrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProgramNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents PrintTypeDataSet As KSoft_Apparel.PrintTypeDataSet
    Friend WithEvents PrintTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintTypeTableAdapter As KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter
    Friend WithEvents PrintPartDataSet As KSoft_Apparel.PrintPartDataSet
    Friend WithEvents PrintPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintPartTableAdapter As KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents FabricColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProgramNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents InHouseRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OutSideRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FabricColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StyleDataSet As KSoft_Apparel.StyleDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents ProgramNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FabricColorName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StyleId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PrintColorQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintOrderQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MainPart As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
