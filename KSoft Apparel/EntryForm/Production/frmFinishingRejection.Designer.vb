<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinishingRejection
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
        Me.TTLRJCTLABEL = New System.Windows.Forms.Label
        Me.SewingLabel = New System.Windows.Forms.Label
        Me.TTLRejectionLabel = New System.Windows.Forms.Label
        Me.ShippmentLabel1 = New System.Windows.Forms.Label
        Me.PrintLabel = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.PrintButton = New System.Windows.Forms.Button
        Me.CutterLabel = New System.Windows.Forms.Label
        Me.FabricLabel = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.BranchComboBox = New System.Windows.Forms.ComboBox
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label6 = New System.Windows.Forms.Label
        Me.SaveButton = New System.Windows.Forms.Button
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.FinishingProductionDataSet = New KSoft_Apparel.FinishingProductionDataSet
        Me.FinishingRejectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.FinishingProductionDataSetTableAdapters.TableAdapterManager
        Me.FinishingRejectionTableAdapter = New KSoft_Apparel.FinishingProductionDataSetTableAdapters.FinishingRejectionTableAdapter
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
        Me.FinishingRejectionDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
        Me.FabricColorComboBox = New System.Windows.Forms.ComboBox
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsMultiPart = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AddNewButton = New System.Windows.Forms.Button
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingRejectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingRejectionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TTLRJCTLABEL
        '
        Me.TTLRJCTLABEL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TTLRJCTLABEL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLRJCTLABEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTLRJCTLABEL.ForeColor = System.Drawing.Color.Blue
        Me.TTLRJCTLABEL.Location = New System.Drawing.Point(600, 559)
        Me.TTLRJCTLABEL.Name = "TTLRJCTLABEL"
        Me.TTLRJCTLABEL.Size = New System.Drawing.Size(70, 20)
        Me.TTLRJCTLABEL.TabIndex = 22
        Me.TTLRJCTLABEL.Text = "0"
        '
        'SewingLabel
        '
        Me.SewingLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SewingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SewingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SewingLabel.ForeColor = System.Drawing.Color.Blue
        Me.SewingLabel.Location = New System.Drawing.Point(371, 529)
        Me.SewingLabel.Name = "SewingLabel"
        Me.SewingLabel.Size = New System.Drawing.Size(70, 20)
        Me.SewingLabel.TabIndex = 19
        Me.SewingLabel.Text = "0"
        '
        'TTLRejectionLabel
        '
        Me.TTLRejectionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TTLRejectionLabel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TTLRejectionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLRejectionLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTLRejectionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTLRejectionLabel.Location = New System.Drawing.Point(450, 559)
        Me.TTLRejectionLabel.Name = "TTLRejectionLabel"
        Me.TTLRejectionLabel.Size = New System.Drawing.Size(147, 20)
        Me.TTLRejectionLabel.TabIndex = 21
        Me.TTLRejectionLabel.Text = "Total Rejection"
        '
        'ShippmentLabel1
        '
        Me.ShippmentLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ShippmentLabel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ShippmentLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShippmentLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippmentLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ShippmentLabel1.Location = New System.Drawing.Point(251, 529)
        Me.ShippmentLabel1.Name = "ShippmentLabel1"
        Me.ShippmentLabel1.Size = New System.Drawing.Size(114, 20)
        Me.ShippmentLabel1.TabIndex = 17
        Me.ShippmentLabel1.Text = "Sewing Rejection :"
        '
        'PrintLabel
        '
        Me.PrintLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PrintLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PrintLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintLabel.ForeColor = System.Drawing.Color.Blue
        Me.PrintLabel.Location = New System.Drawing.Point(175, 559)
        Me.PrintLabel.Name = "PrintLabel"
        Me.PrintLabel.Size = New System.Drawing.Size(70, 20)
        Me.PrintLabel.TabIndex = 16
        Me.PrintLabel.Text = "0"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(29, 559)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Total Print Rejection :"
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Location = New System.Drawing.Point(837, 66)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(99, 49)
        Me.PrintButton.TabIndex = 7
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'CutterLabel
        '
        Me.CutterLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CutterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CutterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CutterLabel.ForeColor = System.Drawing.Color.Blue
        Me.CutterLabel.Location = New System.Drawing.Point(371, 559)
        Me.CutterLabel.Name = "CutterLabel"
        Me.CutterLabel.Size = New System.Drawing.Size(70, 20)
        Me.CutterLabel.TabIndex = 20
        Me.CutterLabel.Text = "0"
        '
        'FabricLabel
        '
        Me.FabricLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FabricLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FabricLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FabricLabel.ForeColor = System.Drawing.Color.Blue
        Me.FabricLabel.Location = New System.Drawing.Point(175, 529)
        Me.FabricLabel.Name = "FabricLabel"
        Me.FabricLabel.Size = New System.Drawing.Size(70, 20)
        Me.FabricLabel.TabIndex = 15
        Me.FabricLabel.Text = "0"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(251, 559)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Cutter Rejection:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(29, 529)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Total Fabric Rejection :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(248, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Branch"
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(298, 64)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(179, 21)
        Me.BranchComboBox.TabIndex = 1
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
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1074, 31)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 7, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Finishing Rejection"
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        'Me.SaveButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Save
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(945, 66)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.SaveButton.Size = New System.Drawing.Size(100, 49)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Program No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Finishing Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Color"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(113, 66)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(115, 20)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.TabStop = False
        '
        'FinishingProductionDataSet
        '
        Me.FinishingProductionDataSet.DataSetName = "FinishingProductionDataSet"
        Me.FinishingProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishingRejectionBindingSource
        '
        Me.FinishingRejectionBindingSource.DataMember = "FinishingRejection"
        Me.FinishingRejectionBindingSource.DataSource = Me.FinishingProductionDataSet
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinishingProductionTableAdapter = Nothing
        Me.TableAdapterManager.FinishingRejectionTableAdapter = Me.FinishingRejectionTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FinishingProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FinishingRejectionTableAdapter
        '
        Me.FinishingRejectionTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorDataSet
        '
        Me.OrderFabricColorDataSet.DataSetName = "OrderFabricColorDataSet"
        Me.OrderFabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorBindingSource
        '
        Me.OrderFabricColorBindingSource.DataMember = "OrderFabricColor"
        Me.OrderFabricColorBindingSource.DataSource = Me.OrderFabricColorDataSet
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'FinishingRejectionDataGridView
        '
        Me.FinishingRejectionDataGridView.AllowUserToAddRows = False
        Me.FinishingRejectionDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinishingRejectionDataGridView.AutoGenerateColumns = False
        Me.FinishingRejectionDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FinishingRejectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FinishingRejectionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn5})
        Me.FinishingRejectionDataGridView.DataSource = Me.FinishingRejectionBindingSource
        Me.FinishingRejectionDataGridView.Location = New System.Drawing.Point(28, 134)
        Me.FinishingRejectionDataGridView.Name = "FinishingRejectionDataGridView"
        Me.FinishingRejectionDataGridView.Size = New System.Drawing.Size(1018, 382)
        Me.FinishingRejectionDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "BranchId"
        Me.DataGridViewTextBoxColumn11.DataSource = Me.BranchBindingSource
        Me.DataGridViewTextBoxColumn11.DisplayMember = "BranchCode"
        Me.DataGridViewTextBoxColumn11.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn11.HeaderText = "Branch"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn11.ValueMember = "BranchId"
        Me.DataGridViewTextBoxColumn11.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FinishingRejectDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Finishing Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OrderId"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.OrderLookupBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "ProgramNo"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "Program No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "OrderId"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FabricColorId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.FabricColorBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "FabricColorName"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fabric Color"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "FabricColorId"
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
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FabricRejectQuantity"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fabric Reject Quantity"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PrintRejectQuantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Print Reject Quantity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SewingRejectQuantity"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Sewing Reject Quantity"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CutterRejectQuantity"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cutter Reject Quantity"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'FabricColorComboBox
        '
        Me.FabricColorComboBox.DataSource = Me.OrderFabricColorBindingSource
        Me.FabricColorComboBox.DisplayMember = "FabricColorName"
        Me.FabricColorComboBox.FormattingEnabled = True
        Me.FabricColorComboBox.Location = New System.Drawing.Point(298, 92)
        Me.FabricColorComboBox.Name = "FabricColorComboBox"
        Me.FabricColorComboBox.Size = New System.Drawing.Size(179, 21)
        Me.FabricColorComboBox.TabIndex = 3
        Me.FabricColorComboBox.ValueMember = "FabricColorId"
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(113, 93)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(115, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 2
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
        'AddNewButton
        '
        'Me.AddNewButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Add_icon
        Me.AddNewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddNewButton.Location = New System.Drawing.Point(496, 64)
        Me.AddNewButton.Name = "AddNewButton"
        Me.AddNewButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.AddNewButton.Size = New System.Drawing.Size(101, 49)
        Me.AddNewButton.TabIndex = 4
        Me.AddNewButton.Text = "Add &New"
        Me.AddNewButton.UseVisualStyleBackColor = True
        '
        'frmFinishingRejection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 612)
        Me.Controls.Add(Me.AddNewButton)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.FabricColorComboBox)
        Me.Controls.Add(Me.FinishingRejectionDataGridView)
        Me.Controls.Add(Me.TTLRJCTLABEL)
        Me.Controls.Add(Me.SewingLabel)
        Me.Controls.Add(Me.TTLRejectionLabel)
        Me.Controls.Add(Me.ShippmentLabel1)
        Me.Controls.Add(Me.PrintLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.CutterLabel)
        Me.Controls.Add(Me.FabricLabel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmFinishingRejection"
        Me.Text = "Finishing Rejection"
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingRejectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingRejectionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TTLRJCTLABEL As System.Windows.Forms.Label
    Friend WithEvents SewingLabel As System.Windows.Forms.Label
    Friend WithEvents TTLRejectionLabel As System.Windows.Forms.Label
    Friend WithEvents ShippmentLabel1 As System.Windows.Forms.Label
    Friend WithEvents PrintLabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents CutterLabel As System.Windows.Forms.Label
    Friend WithEvents FabricLabel As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents FinishingProductionDataSet As KSoft_Apparel.FinishingProductionDataSet
    Friend WithEvents FinishingRejectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FinishingProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FinishingRejectionTableAdapter As KSoft_Apparel.FinishingProductionDataSetTableAdapters.FinishingRejectionTableAdapter
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents FinishingRejectionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FabricColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMultiPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AddNewButton As System.Windows.Forms.Button
End Class
