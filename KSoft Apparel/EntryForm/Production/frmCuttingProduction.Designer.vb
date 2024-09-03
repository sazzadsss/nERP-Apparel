<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuttingProduction
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CuttingProductionDataSet = New KSoft_Apparel.CuttingProductionDataSet()
        Me.CuttingProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingProductionTableAdapter = New KSoft_Apparel.CuttingProductionDataSetTableAdapters.CuttingProductionTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.CuttingProductionDataSetTableAdapters.TableAdapterManager()
        Me.CuttingRejectionTableAdapter = New KSoft_Apparel.CuttingProductionDataSetTableAdapters.CuttingRejectionTableAdapter()
        Me.CuttingProductionDataGridView = New System.Windows.Forms.DataGridView()
        Me.IsCuttingClose = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.TwinPackId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TwinPackLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TwinPackLookupDataSet = New KSoft_Apparel.TwinPackLookupDataSet()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuttingQuantityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QCPassQuantityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintSendQuantityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintReceiveQuantityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputQuantityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReplaceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RejectColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCutting = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TQC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPrintSend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPrintReceive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TInput = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TReplace = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TReject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BranchComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FabricColorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.CuttingLabel = New System.Windows.Forms.Label()
        Me.QCPassLabel = New System.Windows.Forms.Label()
        Me.ReplaceLabel = New System.Windows.Forms.Label()
        Me.RejectLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.InputLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CuttingRejectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingRejectionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRejection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.HideCheckBox = New System.Windows.Forms.CheckBox()
        Me.MultipartComboBox = New System.Windows.Forms.ComboBox()
        Me.TwinPackfilteredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.MultipartLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TwinPackfilteredTableAdapter = New KSoft_Apparel.TwinPackLookupDataSetTableAdapters.TwinPackfilteredTableAdapter()
        Me.TwinPackLookupTableAdapter = New KSoft_Apparel.TwinPackLookupDataSetTableAdapters.TwinPackLookupTableAdapter()
        Me.GetDataLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.CuttingProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingProductionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwinPackLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwinPackLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.CuttingRejectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingRejectionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwinPackfilteredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CuttingProductionDataSet
        '
        Me.CuttingProductionDataSet.DataSetName = "CuttingProductionDataSet"
        Me.CuttingProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuttingProductionBindingSource
        '
        Me.CuttingProductionBindingSource.DataMember = "CuttingProduction"
        Me.CuttingProductionBindingSource.DataSource = Me.CuttingProductionDataSet
        '
        'CuttingProductionTableAdapter
        '
        Me.CuttingProductionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuttingProductionTableAdapter = Me.CuttingProductionTableAdapter
        Me.TableAdapterManager.CuttingRejectionTableAdapter = Me.CuttingRejectionTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CuttingProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CuttingRejectionTableAdapter
        '
        Me.CuttingRejectionTableAdapter.ClearBeforeFill = True
        '
        'CuttingProductionDataGridView
        '
        Me.CuttingProductionDataGridView.AllowUserToAddRows = False
        Me.CuttingProductionDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuttingProductionDataGridView.AutoGenerateColumns = False
        Me.CuttingProductionDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CuttingProductionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CuttingProductionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CuttingProductionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IsCuttingClose, Me.DataGridViewTextBoxColumn2, Me.BranchId, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.TwinPackId, Me.DataGridViewTextBoxColumn5, Me.CuttingQuantityColumn, Me.QCPassQuantityColumn, Me.PrintSendQuantityColumn, Me.PrintReceiveQuantityColumn, Me.InputQuantityColumn, Me.ReplaceColumn, Me.RejectColumn, Me.TCutting, Me.TQC, Me.TPrintSend, Me.TPrintReceive, Me.TInput, Me.TReplace, Me.TReject, Me.DataGridViewTextBoxColumn13})
        Me.CuttingProductionDataGridView.DataSource = Me.CuttingProductionBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CuttingProductionDataGridView.DefaultCellStyle = DataGridViewCellStyle10
        Me.CuttingProductionDataGridView.Location = New System.Drawing.Point(19, 111)
        Me.CuttingProductionDataGridView.Name = "CuttingProductionDataGridView"
        Me.CuttingProductionDataGridView.Size = New System.Drawing.Size(1128, 373)
        Me.CuttingProductionDataGridView.TabIndex = 1
        '
        'IsCuttingClose
        '
        Me.IsCuttingClose.DataPropertyName = "IsCuttingClose"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.NullValue = False
        Me.IsCuttingClose.DefaultCellStyle = DataGridViewCellStyle2
        Me.IsCuttingClose.HeaderText = "Cutting Close"
        Me.IsCuttingClose.Name = "IsCuttingClose"
        Me.IsCuttingClose.ReadOnly = True
        Me.IsCuttingClose.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CuttingDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cutting Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
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
        Me.BranchId.Width = 75
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
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "OrderId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.OrderLookupBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "ProgramNo"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Program No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "OrderId"
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
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FabricColorId"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.FabricColorBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "FabricColorName"
        Me.DataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn4.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "FabricColorId"
        Me.DataGridViewTextBoxColumn4.Width = 125
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
        'TwinPackId
        '
        Me.TwinPackId.DataPropertyName = "TwinPackId"
        Me.TwinPackId.DataSource = Me.TwinPackLookupBindingSource
        Me.TwinPackId.DisplayMember = "Details"
        Me.TwinPackId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.TwinPackId.HeaderText = "Part"
        Me.TwinPackId.Name = "TwinPackId"
        Me.TwinPackId.ReadOnly = True
        Me.TwinPackId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TwinPackId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TwinPackId.ValueMember = "TwinPackId"
        '
        'TwinPackLookupBindingSource
        '
        Me.TwinPackLookupBindingSource.DataMember = "TwinPackLookup"
        Me.TwinPackLookupBindingSource.DataSource = Me.TwinPackLookupDataSet
        '
        'TwinPackLookupDataSet
        '
        Me.TwinPackLookupDataSet.DataSetName = "TwinPackLookupDataSet"
        Me.TwinPackLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Consumption"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cons"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'CuttingQuantityColumn
        '
        Me.CuttingQuantityColumn.DataPropertyName = "CuttingQuantity"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CuttingQuantityColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CuttingQuantityColumn.HeaderText = "Cutting"
        Me.CuttingQuantityColumn.Name = "CuttingQuantityColumn"
        Me.CuttingQuantityColumn.Width = 75
        '
        'QCPassQuantityColumn
        '
        Me.QCPassQuantityColumn.DataPropertyName = "QCQuantity"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.QCPassQuantityColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.QCPassQuantityColumn.HeaderText = "QC Pass"
        Me.QCPassQuantityColumn.Name = "QCPassQuantityColumn"
        Me.QCPassQuantityColumn.Width = 75
        '
        'PrintSendQuantityColumn
        '
        Me.PrintSendQuantityColumn.DataPropertyName = "PrintSendQuantity"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PrintSendQuantityColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.PrintSendQuantityColumn.HeaderText = "Print Send"
        Me.PrintSendQuantityColumn.Name = "PrintSendQuantityColumn"
        Me.PrintSendQuantityColumn.Width = 75
        '
        'PrintReceiveQuantityColumn
        '
        Me.PrintReceiveQuantityColumn.DataPropertyName = "PrintReceiveQuantity"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PrintReceiveQuantityColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrintReceiveQuantityColumn.HeaderText = "Print Receive"
        Me.PrintReceiveQuantityColumn.Name = "PrintReceiveQuantityColumn"
        Me.PrintReceiveQuantityColumn.Width = 75
        '
        'InputQuantityColumn
        '
        Me.InputQuantityColumn.DataPropertyName = "InputQuantity"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.InputQuantityColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.InputQuantityColumn.HeaderText = "Input"
        Me.InputQuantityColumn.Name = "InputQuantityColumn"
        Me.InputQuantityColumn.Width = 75
        '
        'ReplaceColumn
        '
        Me.ReplaceColumn.DataPropertyName = "ReplaceQuantity"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReplaceColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.ReplaceColumn.HeaderText = "Replace"
        Me.ReplaceColumn.Name = "ReplaceColumn"
        Me.ReplaceColumn.Width = 50
        '
        'RejectColumn
        '
        Me.RejectColumn.DataPropertyName = "RejectQuantity"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RejectColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.RejectColumn.HeaderText = "Reject"
        Me.RejectColumn.Name = "RejectColumn"
        Me.RejectColumn.Width = 50
        '
        'TCutting
        '
        Me.TCutting.DataPropertyName = "TCutting"
        Me.TCutting.HeaderText = "TTL Cutting"
        Me.TCutting.Name = "TCutting"
        Me.TCutting.ReadOnly = True
        Me.TCutting.Width = 75
        '
        'TQC
        '
        Me.TQC.DataPropertyName = "TQC"
        Me.TQC.HeaderText = "TTL QC Pass"
        Me.TQC.Name = "TQC"
        Me.TQC.ReadOnly = True
        Me.TQC.Width = 75
        '
        'TPrintSend
        '
        Me.TPrintSend.DataPropertyName = "TPrintSend"
        Me.TPrintSend.HeaderText = "TTL Print Send"
        Me.TPrintSend.Name = "TPrintSend"
        Me.TPrintSend.ReadOnly = True
        Me.TPrintSend.Width = 75
        '
        'TPrintReceive
        '
        Me.TPrintReceive.DataPropertyName = "TPrintReceive"
        Me.TPrintReceive.HeaderText = "TTL Print Receive"
        Me.TPrintReceive.Name = "TPrintReceive"
        Me.TPrintReceive.ReadOnly = True
        Me.TPrintReceive.Width = 75
        '
        'TInput
        '
        Me.TInput.DataPropertyName = "TInput"
        Me.TInput.HeaderText = "TTL Input"
        Me.TInput.Name = "TInput"
        Me.TInput.ReadOnly = True
        Me.TInput.Width = 75
        '
        'TReplace
        '
        Me.TReplace.DataPropertyName = "TReplace"
        Me.TReplace.HeaderText = "TTL Replace"
        Me.TReplace.Name = "TReplace"
        Me.TReplace.ReadOnly = True
        Me.TReplace.Width = 75
        '
        'TReject
        '
        Me.TReject.DataPropertyName = "TReject"
        Me.TReject.HeaderText = "TTL Reject"
        Me.TReject.Name = "TReject"
        Me.TReject.ReadOnly = True
        Me.TReject.Width = 75
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 200
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 51)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(113, 20)
        Me.DateTimePicker1.TabIndex = 3
        Me.DateTimePicker1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 8, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Program No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cutting Date"
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Enabled = False
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Location = New System.Drawing.Point(1050, 48)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(97, 57)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1169, 31)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 7, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cutting Production"
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(287, 50)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(142, 21)
        Me.BranchComboBox.TabIndex = 4
        Me.BranchComboBox.TabStop = False
        Me.BranchComboBox.ValueMember = "BranchId"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Branch"
        '
        'FabricColorComboBox
        '
        Me.FabricColorComboBox.DataSource = Me.OrderFabricColorBindingSource
        Me.FabricColorComboBox.DisplayMember = "FabricColorName"
        Me.FabricColorComboBox.FormattingEnabled = True
        Me.FabricColorComboBox.Location = New System.Drawing.Point(421, 4)
        Me.FabricColorComboBox.Margin = New System.Windows.Forms.Padding(20, 4, 3, 3)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(142, 21)
        Me.FabricColorComboBox.TabIndex = 1
        Me.FabricColorComboBox.ValueMember = "FabricColorId"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(15, 8, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Color"
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'CuttingLabel
        '
        Me.CuttingLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuttingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CuttingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuttingLabel.ForeColor = System.Drawing.Color.Blue
        Me.CuttingLabel.Location = New System.Drawing.Point(1064, 502)
        Me.CuttingLabel.Name = "CuttingLabel"
        Me.CuttingLabel.Size = New System.Drawing.Size(83, 21)
        Me.CuttingLabel.TabIndex = 42
        Me.CuttingLabel.Text = "0"
        '
        'QCPassLabel
        '
        Me.QCPassLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QCPassLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.QCPassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QCPassLabel.ForeColor = System.Drawing.Color.Blue
        Me.QCPassLabel.Location = New System.Drawing.Point(1064, 524)
        Me.QCPassLabel.Name = "QCPassLabel"
        Me.QCPassLabel.Size = New System.Drawing.Size(83, 21)
        Me.QCPassLabel.TabIndex = 53
        Me.QCPassLabel.Text = "0"
        '
        'ReplaceLabel
        '
        Me.ReplaceLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReplaceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReplaceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReplaceLabel.ForeColor = System.Drawing.Color.Blue
        Me.ReplaceLabel.Location = New System.Drawing.Point(1064, 568)
        Me.ReplaceLabel.Name = "ReplaceLabel"
        Me.ReplaceLabel.Size = New System.Drawing.Size(83, 21)
        Me.ReplaceLabel.TabIndex = 55
        Me.ReplaceLabel.Text = "0"
        '
        'RejectLabel
        '
        Me.RejectLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RejectLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RejectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RejectLabel.ForeColor = System.Drawing.Color.Blue
        Me.RejectLabel.Location = New System.Drawing.Point(1064, 546)
        Me.RejectLabel.Name = "RejectLabel"
        Me.RejectLabel.Size = New System.Drawing.Size(83, 21)
        Me.RejectLabel.TabIndex = 54
        Me.RejectLabel.Text = "0"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(1064, 634)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 21)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "0"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(1064, 612)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 21)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "0"
        '
        'InputLabel
        '
        Me.InputLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputLabel.ForeColor = System.Drawing.Color.Blue
        Me.InputLabel.Location = New System.Drawing.Point(1064, 590)
        Me.InputLabel.Name = "InputLabel"
        Me.InputLabel.Size = New System.Drawing.Size(83, 21)
        Me.InputLabel.TabIndex = 57
        Me.InputLabel.Text = "0"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(900, 634)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 21)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "-"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(900, 612)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 21)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "-"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(900, 590)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(158, 21)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "TTL INPUT"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(900, 568)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(158, 21)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "TTL REPLACE"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(900, 546)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 21)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "TTL REJECT"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(900, 524)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(158, 21)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "TTL QC PASS"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(900, 502)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(158, 21)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "TTL CUTTING"
        '
        'CuttingRejectionBindingSource
        '
        Me.CuttingRejectionBindingSource.DataMember = "FK_CuttingRejection_CuttingProduction"
        Me.CuttingRejectionBindingSource.DataSource = Me.CuttingProductionBindingSource
        '
        'CuttingRejectionDataGridView
        '
        Me.CuttingRejectionDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CuttingRejectionDataGridView.AutoGenerateColumns = False
        Me.CuttingRejectionDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CuttingRejectionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.CuttingRejectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CuttingRejectionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.TotalRejection, Me.DataGridViewTextBoxColumn20})
        Me.CuttingRejectionDataGridView.DataSource = Me.CuttingRejectionBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CuttingRejectionDataGridView.DefaultCellStyle = DataGridViewCellStyle12
        Me.CuttingRejectionDataGridView.Location = New System.Drawing.Point(19, 502)
        Me.CuttingRejectionDataGridView.Name = "CuttingRejectionDataGridView"
        Me.CuttingRejectionDataGridView.Size = New System.Drawing.Size(864, 153)
        Me.CuttingRejectionDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FabricRejection"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Fabric Rejection"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PrintRejection"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Print Rejection"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CuttingRejection"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Cutting Rejection"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "RejectionReceive"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Rejection Receive"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'TotalRejection
        '
        Me.TotalRejection.DataPropertyName = "TotalRejection"
        Me.TotalRejection.HeaderText = "Total Rejection"
        Me.TotalRejection.Name = "TotalRejection"
        Me.TotalRejection.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintButton.Location = New System.Drawing.Point(951, 48)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(93, 57)
        Me.PrintButton.TabIndex = 11
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(813, 3)
        Me.NewButton.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(89, 23)
        Me.NewButton.TabIndex = 3
        Me.NewButton.Text = "&Add [ F3 ]"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'HideCheckBox
        '
        Me.HideCheckBox.AutoSize = True
        Me.HideCheckBox.Location = New System.Drawing.Point(444, 52)
        Me.HideCheckBox.Name = "HideCheckBox"
        Me.HideCheckBox.Size = New System.Drawing.Size(69, 17)
        Me.HideCheckBox.TabIndex = 67
        Me.HideCheckBox.Text = "Multi part"
        Me.HideCheckBox.UseVisualStyleBackColor = True
        '
        'MultipartComboBox
        '
        Me.MultipartComboBox.DataSource = Me.TwinPackfilteredBindingSource
        Me.MultipartComboBox.DisplayMember = "Details"
        Me.MultipartComboBox.FormattingEnabled = True
        Me.MultipartComboBox.Location = New System.Drawing.Point(662, 4)
        Me.MultipartComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
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
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'MultipartLabel
        '
        Me.MultipartLabel.AutoSize = True
        Me.MultipartLabel.Location = New System.Drawing.Point(609, 8)
        Me.MultipartLabel.Margin = New System.Windows.Forms.Padding(10, 8, 3, 0)
        Me.MultipartLabel.Name = "MultipartLabel"
        Me.MultipartLabel.Size = New System.Drawing.Size(47, 13)
        Me.MultipartLabel.TabIndex = 6
        Me.MultipartLabel.Text = "Multipart"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel2.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel2.Controls.Add(Me.FabricColorComboBox)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel2.Controls.Add(Me.MultipartLabel)
        Me.FlowLayoutPanel2.Controls.Add(Me.MultipartComboBox)
        Me.FlowLayoutPanel2.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(19, 75)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(914, 30)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(84, 4)
        Me.ProgramNoGridLookUpEdit.Margin = New System.Windows.Forms.Padding(15, 4, 3, 3)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(265, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 7
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(569, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "//"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TwinPackfilteredTableAdapter
        '
        Me.TwinPackfilteredTableAdapter.ClearBeforeFill = True
        '
        'TwinPackLookupTableAdapter
        '
        Me.TwinPackLookupTableAdapter.ClearBeforeFill = True
        '
        'GetDataLinkLabel
        '
        Me.GetDataLinkLabel.Enabled = False
        Me.GetDataLinkLabel.Image = Global.KSoft_Apparel.My.Resources.Resources.Stock_Index_Down_icon
        Me.GetDataLinkLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GetDataLinkLabel.Location = New System.Drawing.Point(517, 50)
        Me.GetDataLinkLabel.Name = "GetDataLinkLabel"
        Me.GetDataLinkLabel.Size = New System.Drawing.Size(169, 18)
        Me.GetDataLinkLabel.TabIndex = 68
        Me.GetDataLinkLabel.TabStop = True
        Me.GetDataLinkLabel.Text = "Get Data From Job Card"
        Me.GetDataLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GetDataLinkLabel.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(729, 53)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 13)
        Me.LinkLabel1.TabIndex = 69
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Running Program"
        Me.LinkLabel1.Visible = False
        '
        'frmCuttingProduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 691)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GetDataLinkLabel)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.HideCheckBox)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.CuttingRejectionDataGridView)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.InputLabel)
        Me.Controls.Add(Me.ReplaceLabel)
        Me.Controls.Add(Me.RejectLabel)
        Me.Controls.Add(Me.QCPassLabel)
        Me.Controls.Add(Me.CuttingLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CuttingProductionDataGridView)
        Me.KeyPreview = True
        Me.Name = "frmCuttingProduction"
        Me.Text = "Cutting Production"
        CType(Me.CuttingProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingProductionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwinPackLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwinPackLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.CuttingRejectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingRejectionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwinPackfilteredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CuttingProductionDataSet As KSoft_Apparel.CuttingProductionDataSet
    Friend WithEvents CuttingProductionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuttingProductionTableAdapter As KSoft_Apparel.CuttingProductionDataSetTableAdapters.CuttingProductionTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CuttingProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CuttingProductionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FabricColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents CuttingLabel As System.Windows.Forms.Label
    Friend WithEvents QCPassLabel As System.Windows.Forms.Label
    Friend WithEvents ReplaceLabel As System.Windows.Forms.Label
    Friend WithEvents RejectLabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents InputLabel As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CuttingRejectionTableAdapter As KSoft_Apparel.CuttingProductionDataSetTableAdapters.CuttingRejectionTableAdapter
    Friend WithEvents CuttingRejectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuttingRejectionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalRejection As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents HideCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MultipartComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MultipartLabel As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TwinPackfilteredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TwinPackLookupDataSet As KSoft_Apparel.TwinPackLookupDataSet
    Friend WithEvents TwinPackfilteredTableAdapter As KSoft_Apparel.TwinPackLookupDataSetTableAdapters.TwinPackfilteredTableAdapter
    Friend WithEvents TwinPackLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TwinPackLookupTableAdapter As KSoft_Apparel.TwinPackLookupDataSetTableAdapters.TwinPackLookupTableAdapter
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GetDataLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IsCuttingClose As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TwinPackId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuttingQuantityColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCPassQuantityColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintSendQuantityColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintReceiveQuantityColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InputQuantityColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReplaceColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RejectColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCutting As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TQC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPrintSend As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPrintReceive As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TInput As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TReplace As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TReject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
End Class
