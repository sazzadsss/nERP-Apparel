<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSewingAttendance
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SewingAttendanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineDataSet = New KSoft_Apparel.LineDataSet()
        Me.SewingLayoutId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SewingLayoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingLayoutDataSet = New KSoft_Apparel.SewingLayoutDataSet()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Present3_Hour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Present4_Hour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Present5_Operator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Present5_Helper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Present5_Hour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputMan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IronMan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supervisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Linechief = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SewingAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingAttendanceDataSet = New KSoft_Apparel.SewingAttendanceDataSet()
        Me.SewingMachineUsageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingMachineUsageDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SewingMachineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
        Me.SewingMachineTableAdapter = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingMachineTableAdapter()
        Me.BranchComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.P3HelperLabel = New System.Windows.Forms.Label()
        Me.P3OperatorLabel = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.P2HelperLabel = New System.Windows.Forms.Label()
        Me.P2OperatorLabel = New System.Windows.Forms.Label()
        Me.PHelperLabel = New System.Windows.Forms.Label()
        Me.POperatorLabel = New System.Windows.Forms.Label()
        Me.SHelperLabel = New System.Windows.Forms.Label()
        Me.SOperatorLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LoadMachineLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.TTLMachineUsageLabel2 = New System.Windows.Forms.Label()
        Me.TTLMachineUsageLabel = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GTMachineUsages = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SewingAttendanceCommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingAttendanceTableAdapter = New KSoft_Apparel.SewingAttendanceDataSetTableAdapters.SewingAttendanceTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SewingAttendanceDataSetTableAdapters.TableAdapterManager()
        Me.SewingAttendanceCommentsTableAdapter = New KSoft_Apparel.SewingAttendanceDataSetTableAdapters.SewingAttendanceCommentsTableAdapter()
        Me.SewingMachineUsageTableAdapter = New KSoft_Apparel.SewingAttendanceDataSetTableAdapters.SewingMachineUsageTableAdapter()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.MailButton = New System.Windows.Forms.Button()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.SewingLayoutTableAdapter = New KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingLayoutTableAdapter()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        CType(Me.SewingAttendanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingAttendanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingMachineUsageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingMachineUsageDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingMachineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SewingAttendanceCommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SewingAttendanceDataGridView
        '
        Me.SewingAttendanceDataGridView.AllowUserToAddRows = False
        Me.SewingAttendanceDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingAttendanceDataGridView.AutoGenerateColumns = False
        Me.SewingAttendanceDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SewingAttendanceDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SewingAttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SewingAttendanceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.BranchId, Me.DataGridViewTextBoxColumn3, Me.SewingLayoutId, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.Present3_Hour, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.Present4_Hour, Me.Remarks, Me.Present5_Operator, Me.Present5_Helper, Me.Present5_Hour, Me.InputMan, Me.IronMan, Me.Supervisor, Me.Linechief})
        Me.SewingAttendanceDataGridView.DataSource = Me.SewingAttendanceBindingSource
        Me.SewingAttendanceDataGridView.Location = New System.Drawing.Point(31, 74)
        Me.SewingAttendanceDataGridView.Name = "SewingAttendanceDataGridView"
        Me.SewingAttendanceDataGridView.Size = New System.Drawing.Size(904, 207)
        Me.SewingAttendanceDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AttendanceDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Attendance Date"
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
        Me.BranchId.ReadOnly = True
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LineId"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.LineBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Line"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Line"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "LineId"
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
        'SewingLayoutId
        '
        Me.SewingLayoutId.DataPropertyName = "SewingLayoutId"
        Me.SewingLayoutId.DataSource = Me.SewingLayoutBindingSource
        Me.SewingLayoutId.DisplayMember = "SewingLayoutNo"
        Me.SewingLayoutId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.SewingLayoutId.HeaderText = "Main Layout No"
        Me.SewingLayoutId.Name = "SewingLayoutId"
        Me.SewingLayoutId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SewingLayoutId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SewingLayoutId.ValueMember = "LayoutId"
        Me.SewingLayoutId.Width = 75
        '
        'SewingLayoutBindingSource
        '
        Me.SewingLayoutBindingSource.DataMember = "SewingLayout"
        Me.SewingLayoutBindingSource.DataSource = Me.SewingLayoutDataSet
        '
        'SewingLayoutDataSet
        '
        Me.SewingLayoutDataSet.DataSetName = "SewingLayoutDataSet"
        Me.SewingLayoutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Strength_Operator"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "Strength Operator"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Strength_Helper"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Strength Helper"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Present_Operator"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn6.HeaderText = "Present Operator"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Present_Helper"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.HeaderText = "Present Helper"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Present2_Operator"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn8.HeaderText = "Present2 Operator"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Present2_Helper"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn9.HeaderText = "Present2 Helper"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 75
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Present3_Operator"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn10.HeaderText = "Present3 Operator"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 75
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Present3_Helper"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn11.HeaderText = "Present3 Helper"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 75
        '
        'Present3_Hour
        '
        Me.Present3_Hour.DataPropertyName = "Present3_Hour"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Present3_Hour.DefaultCellStyle = DataGridViewCellStyle11
        Me.Present3_Hour.HeaderText = "Present3_Hour"
        Me.Present3_Hour.Name = "Present3_Hour"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Present4_Operator"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn12.HeaderText = "Present4 Operator"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 75
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Present4_Helper"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn13.HeaderText = "Present4 Helper"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 75
        '
        'Present4_Hour
        '
        Me.Present4_Hour.DataPropertyName = "Present4_Hour"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Present4_Hour.DefaultCellStyle = DataGridViewCellStyle14
        Me.Present4_Hour.HeaderText = "Present4_Hour"
        Me.Present4_Hour.Name = "Present4_Hour"
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Width = 200
        '
        'Present5_Operator
        '
        Me.Present5_Operator.DataPropertyName = "Present5_Operator"
        Me.Present5_Operator.HeaderText = "Present5 Operator"
        Me.Present5_Operator.Name = "Present5_Operator"
        Me.Present5_Operator.Width = 75
        '
        'Present5_Helper
        '
        Me.Present5_Helper.DataPropertyName = "Present5_Helper"
        Me.Present5_Helper.HeaderText = "Present5 Helper"
        Me.Present5_Helper.Name = "Present5_Helper"
        Me.Present5_Helper.Width = 75
        '
        'Present5_Hour
        '
        Me.Present5_Hour.DataPropertyName = "Present5_Hour"
        Me.Present5_Hour.HeaderText = "Present5 Hour"
        Me.Present5_Hour.Name = "Present5_Hour"
        Me.Present5_Hour.Width = 75
        '
        'InputMan
        '
        Me.InputMan.DataPropertyName = "InputMan"
        Me.InputMan.HeaderText = "InputMan"
        Me.InputMan.Name = "InputMan"
        '
        'IronMan
        '
        Me.IronMan.DataPropertyName = "IronMan"
        Me.IronMan.HeaderText = "IronMan"
        Me.IronMan.Name = "IronMan"
        '
        'Supervisor
        '
        Me.Supervisor.DataPropertyName = "Supervisor"
        Me.Supervisor.HeaderText = "Supervisor"
        Me.Supervisor.Name = "Supervisor"
        '
        'Linechief
        '
        Me.Linechief.DataPropertyName = "Linechief"
        Me.Linechief.HeaderText = "Linechief"
        Me.Linechief.Name = "Linechief"
        '
        'SewingAttendanceBindingSource
        '
        Me.SewingAttendanceBindingSource.DataMember = "SewingAttendance"
        Me.SewingAttendanceBindingSource.DataSource = Me.SewingAttendanceDataSet
        '
        'SewingAttendanceDataSet
        '
        Me.SewingAttendanceDataSet.DataSetName = "SewingAttendanceDataSet"
        Me.SewingAttendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingMachineUsageBindingSource
        '
        Me.SewingMachineUsageBindingSource.DataMember = "FK_SewingMachineUsage_SewingAttendance"
        Me.SewingMachineUsageBindingSource.DataSource = Me.SewingAttendanceBindingSource
        '
        'SewingMachineUsageDataGridView
        '
        Me.SewingMachineUsageDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingMachineUsageDataGridView.AutoGenerateColumns = False
        Me.SewingMachineUsageDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SewingMachineUsageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SewingMachineUsageDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.SewingMachineUsageDataGridView.DataSource = Me.SewingMachineUsageBindingSource
        Me.SewingMachineUsageDataGridView.Location = New System.Drawing.Point(31, 328)
        Me.SewingMachineUsageDataGridView.Name = "SewingMachineUsageDataGridView"
        Me.SewingMachineUsageDataGridView.Size = New System.Drawing.Size(596, 168)
        Me.SewingMachineUsageDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "SewingMachineId"
        Me.DataGridViewTextBoxColumn16.DataSource = Me.SewingMachineBindingSource
        Me.DataGridViewTextBoxColumn16.DisplayMember = "ShortName"
        Me.DataGridViewTextBoxColumn16.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn16.HeaderText = "Sewing Machine"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn16.ValueMember = "SewingMachineId"
        Me.DataGridViewTextBoxColumn16.Width = 200
        '
        'SewingMachineBindingSource
        '
        Me.SewingMachineBindingSource.DataMember = "SewingMachine"
        Me.SewingMachineBindingSource.DataSource = Me.SewingLayoutDataSet
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(109, 47)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(108, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sewing Date"
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'SewingMachineTableAdapter
        '
        Me.SewingMachineTableAdapter.ClearBeforeFill = True
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(279, 47)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BranchComboBox.TabIndex = 5
        Me.BranchComboBox.ValueMember = "BranchId"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Branch"
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Location = New System.Drawing.Point(747, 46)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(188, 23)
        Me.SaveButton.TabIndex = 7
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(955, 31)
        Me.FlowLayoutPanel1.TabIndex = 15
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
        Me.Label6.Text = "Sewing Attendance"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(42, 147)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'P3HelperLabel
        '
        Me.P3HelperLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P3HelperLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.P3HelperLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P3HelperLabel.ForeColor = System.Drawing.Color.Blue
        Me.P3HelperLabel.Location = New System.Drawing.Point(865, 508)
        Me.P3HelperLabel.Name = "P3HelperLabel"
        Me.P3HelperLabel.Size = New System.Drawing.Size(70, 20)
        Me.P3HelperLabel.TabIndex = 50
        Me.P3HelperLabel.Text = "0"
        '
        'P3OperatorLabel
        '
        Me.P3OperatorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P3OperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.P3OperatorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P3OperatorLabel.ForeColor = System.Drawing.Color.Blue
        Me.P3OperatorLabel.Location = New System.Drawing.Point(865, 485)
        Me.P3OperatorLabel.Name = "P3OperatorLabel"
        Me.P3OperatorLabel.Size = New System.Drawing.Size(70, 20)
        Me.P3OperatorLabel.TabIndex = 49
        Me.P3OperatorLabel.Text = "0"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Teal
        Me.Label23.Location = New System.Drawing.Point(659, 508)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(200, 20)
        Me.Label23.TabIndex = 48
        Me.Label23.Text = "Present Helper -1st OT"
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Teal
        Me.Label24.Location = New System.Drawing.Point(659, 485)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(200, 20)
        Me.Label24.TabIndex = 47
        Me.Label24.Text = "Present Operator - 1st OT"
        '
        'P2HelperLabel
        '
        Me.P2HelperLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P2HelperLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.P2HelperLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2HelperLabel.ForeColor = System.Drawing.Color.Blue
        Me.P2HelperLabel.Location = New System.Drawing.Point(865, 456)
        Me.P2HelperLabel.Name = "P2HelperLabel"
        Me.P2HelperLabel.Size = New System.Drawing.Size(70, 20)
        Me.P2HelperLabel.TabIndex = 46
        Me.P2HelperLabel.Text = "0"
        '
        'P2OperatorLabel
        '
        Me.P2OperatorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P2OperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.P2OperatorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2OperatorLabel.ForeColor = System.Drawing.Color.Blue
        Me.P2OperatorLabel.Location = New System.Drawing.Point(865, 433)
        Me.P2OperatorLabel.Name = "P2OperatorLabel"
        Me.P2OperatorLabel.Size = New System.Drawing.Size(70, 20)
        Me.P2OperatorLabel.TabIndex = 45
        Me.P2OperatorLabel.Text = "0"
        '
        'PHelperLabel
        '
        Me.PHelperLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PHelperLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PHelperLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHelperLabel.ForeColor = System.Drawing.Color.Blue
        Me.PHelperLabel.Location = New System.Drawing.Point(865, 404)
        Me.PHelperLabel.Name = "PHelperLabel"
        Me.PHelperLabel.Size = New System.Drawing.Size(70, 20)
        Me.PHelperLabel.TabIndex = 44
        Me.PHelperLabel.Text = "0"
        '
        'POperatorLabel
        '
        Me.POperatorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.POperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.POperatorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POperatorLabel.ForeColor = System.Drawing.Color.Blue
        Me.POperatorLabel.Location = New System.Drawing.Point(865, 381)
        Me.POperatorLabel.Name = "POperatorLabel"
        Me.POperatorLabel.Size = New System.Drawing.Size(70, 20)
        Me.POperatorLabel.TabIndex = 43
        Me.POperatorLabel.Text = "0"
        '
        'SHelperLabel
        '
        Me.SHelperLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SHelperLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SHelperLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHelperLabel.ForeColor = System.Drawing.Color.Blue
        Me.SHelperLabel.Location = New System.Drawing.Point(865, 351)
        Me.SHelperLabel.Name = "SHelperLabel"
        Me.SHelperLabel.Size = New System.Drawing.Size(70, 20)
        Me.SHelperLabel.TabIndex = 42
        Me.SHelperLabel.Text = "0"
        '
        'SOperatorLabel
        '
        Me.SOperatorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SOperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SOperatorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SOperatorLabel.ForeColor = System.Drawing.Color.Blue
        Me.SOperatorLabel.Location = New System.Drawing.Point(865, 328)
        Me.SOperatorLabel.Name = "SOperatorLabel"
        Me.SOperatorLabel.Size = New System.Drawing.Size(70, 20)
        Me.SOperatorLabel.TabIndex = 41
        Me.SOperatorLabel.Text = "0"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Teal
        Me.Label14.Location = New System.Drawing.Point(659, 456)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(200, 20)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Present Helper at 10 AM"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Teal
        Me.Label13.Location = New System.Drawing.Point(659, 433)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(200, 20)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Present Operator at 10 AM"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(658, 351)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(200, 20)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Total Strength-Helper"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(658, 328)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 20)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Total Strength-Operator"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(659, 404)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 20)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Present Helper at 8:00AM"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Teal
        Me.Label9.Location = New System.Drawing.Point(659, 381)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Present Operator at 8:00AM"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(656, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Grand Total :"
        '
        'LoadMachineLinkLabel
        '
        Me.LoadMachineLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadMachineLinkLabel.AutoSize = True
        Me.LoadMachineLinkLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadMachineLinkLabel.Location = New System.Drawing.Point(29, 298)
        Me.LoadMachineLinkLabel.Name = "LoadMachineLinkLabel"
        Me.LoadMachineLinkLabel.Size = New System.Drawing.Size(87, 14)
        Me.LoadMachineLinkLabel.TabIndex = 53
        Me.LoadMachineLinkLabel.TabStop = True
        Me.LoadMachineLinkLabel.Text = "Get Machine List"
        '
        'TTLMachineUsageLabel2
        '
        Me.TTLMachineUsageLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TTLMachineUsageLabel2.BackColor = System.Drawing.Color.White
        Me.TTLMachineUsageLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLMachineUsageLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTLMachineUsageLabel2.ForeColor = System.Drawing.Color.Blue
        Me.TTLMachineUsageLabel2.Location = New System.Drawing.Point(270, 504)
        Me.TTLMachineUsageLabel2.Name = "TTLMachineUsageLabel2"
        Me.TTLMachineUsageLabel2.Size = New System.Drawing.Size(96, 20)
        Me.TTLMachineUsageLabel2.TabIndex = 55
        Me.TTLMachineUsageLabel2.Text = "0"
        Me.TTLMachineUsageLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TTLMachineUsageLabel
        '
        Me.TTLMachineUsageLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TTLMachineUsageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLMachineUsageLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTLMachineUsageLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TTLMachineUsageLabel.Location = New System.Drawing.Point(125, 504)
        Me.TTLMachineUsageLabel.Name = "TTLMachineUsageLabel"
        Me.TTLMachineUsageLabel.Size = New System.Drawing.Size(139, 20)
        Me.TTLMachineUsageLabel.TabIndex = 54
        Me.TTLMachineUsageLabel.Text = "Total Machine Usages"
        Me.TTLMachineUsageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(955, 549)
        Me.ShapeContainer1.TabIndex = 56
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape1.Location = New System.Drawing.Point(31, 499)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(595, 28)
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(424, 50)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(107, 13)
        Me.LinkLabel1.TabIndex = 57
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Fill with Last Strength"
        '
        'GTMachineUsages
        '
        Me.GTMachineUsages.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GTMachineUsages.BackColor = System.Drawing.Color.White
        Me.GTMachineUsages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GTMachineUsages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GTMachineUsages.ForeColor = System.Drawing.Color.Blue
        Me.GTMachineUsages.Location = New System.Drawing.Point(507, 504)
        Me.GTMachineUsages.Name = "GTMachineUsages"
        Me.GTMachineUsages.Size = New System.Drawing.Size(78, 20)
        Me.GTMachineUsages.TabIndex = 59
        Me.GTMachineUsages.Text = "0"
        Me.GTMachineUsages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(372, 504)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 20)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "GT Machine Usages"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SewingAttendanceCommentsBindingSource
        '
        Me.SewingAttendanceCommentsBindingSource.DataMember = "SewingAttendanceComments"
        Me.SewingAttendanceCommentsBindingSource.DataSource = Me.SewingAttendanceDataSet
        '
        'SewingAttendanceTableAdapter
        '
        Me.SewingAttendanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SewingAttendanceCommentsTableAdapter = Me.SewingAttendanceCommentsTableAdapter
        Me.TableAdapterManager.SewingAttendanceTableAdapter = Me.SewingAttendanceTableAdapter
        Me.TableAdapterManager.SewingMachineUsageTableAdapter = Me.SewingMachineUsageTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingAttendanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingAttendanceCommentsTableAdapter
        '
        Me.SewingAttendanceCommentsTableAdapter.ClearBeforeFill = True
        '
        'SewingMachineUsageTableAdapter
        '
        Me.SewingMachineUsageTableAdapter.ClearBeforeFill = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(537, 50)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(78, 13)
        Me.LinkLabel2.TabIndex = 60
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Add Comments"
        '
        'MailButton
        '
        Me.MailButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MailButton.Enabled = False
        Me.MailButton.Location = New System.Drawing.Point(540, 298)
        Me.MailButton.Name = "MailButton"
        Me.MailButton.Size = New System.Drawing.Size(87, 23)
        Me.MailButton.TabIndex = 61
        Me.MailButton.Text = "Send Mail"
        Me.MailButton.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(276, 298)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(106, 13)
        Me.LinkLabel3.TabIndex = 62
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Get Ondate Machine"
        '
        'SewingLayoutTableAdapter
        '
        Me.SewingLayoutTableAdapter.ClearBeforeFill = True
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(151, 299)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(103, 13)
        Me.LinkLabel4.TabIndex = 63
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Get Layout Machine"
        '
        'frmSewingAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 549)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.MailButton)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.GTMachineUsages)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TTLMachineUsageLabel2)
        Me.Controls.Add(Me.TTLMachineUsageLabel)
        Me.Controls.Add(Me.LoadMachineLinkLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.P3HelperLabel)
        Me.Controls.Add(Me.P3OperatorLabel)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.P2HelperLabel)
        Me.Controls.Add(Me.P2OperatorLabel)
        Me.Controls.Add(Me.PHelperLabel)
        Me.Controls.Add(Me.POperatorLabel)
        Me.Controls.Add(Me.SHelperLabel)
        Me.Controls.Add(Me.SOperatorLabel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.SewingMachineUsageDataGridView)
        Me.Controls.Add(Me.SewingAttendanceDataGridView)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.KeyPreview = True
        Me.Name = "frmSewingAttendance"
        Me.Text = "Sewing Attendance"
        CType(Me.SewingAttendanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingAttendanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingMachineUsageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingMachineUsageDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingMachineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.SewingAttendanceCommentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SewingAttendanceDataSet As KSoft_Apparel.SewingAttendanceDataSet
    Friend WithEvents SewingAttendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingAttendanceTableAdapter As KSoft_Apparel.SewingAttendanceDataSetTableAdapters.SewingAttendanceTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SewingAttendanceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingAttendanceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SewingMachineUsageTableAdapter As KSoft_Apparel.SewingAttendanceDataSetTableAdapters.SewingMachineUsageTableAdapter
    Friend WithEvents SewingMachineUsageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingMachineUsageDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
    Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents SewingLayoutDataSet As KSoft_Apparel.SewingLayoutDataSet
    Friend WithEvents SewingMachineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingMachineTableAdapter As KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingMachineTableAdapter
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents P3HelperLabel As System.Windows.Forms.Label
    Friend WithEvents P3OperatorLabel As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents P2HelperLabel As System.Windows.Forms.Label
    Friend WithEvents P2OperatorLabel As System.Windows.Forms.Label
    Friend WithEvents PHelperLabel As System.Windows.Forms.Label
    Friend WithEvents POperatorLabel As System.Windows.Forms.Label
    Friend WithEvents SHelperLabel As System.Windows.Forms.Label
    Friend WithEvents SOperatorLabel As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LoadMachineLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents TTLMachineUsageLabel2 As System.Windows.Forms.Label
    Friend WithEvents TTLMachineUsageLabel As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GTMachineUsages As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SewingAttendanceCommentsTableAdapter As KSoft_Apparel.SewingAttendanceDataSetTableAdapters.SewingAttendanceCommentsTableAdapter
    Friend WithEvents SewingAttendanceCommentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents MailButton As System.Windows.Forms.Button
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents SewingLayoutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingLayoutTableAdapter As KSoft_Apparel.SewingLayoutDataSetTableAdapters.SewingLayoutTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SewingLayoutId As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Present3_Hour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Present4_Hour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Present5_Operator As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Present5_Helper As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Present5_Hour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InputMan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IronMan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Supervisor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Linechief As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel4 As LinkLabel
End Class
