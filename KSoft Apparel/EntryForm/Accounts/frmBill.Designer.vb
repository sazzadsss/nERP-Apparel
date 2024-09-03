<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Dim ConveyanceDateLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim PeriodLabel As System.Windows.Forms.Label
        Dim FADateLabel As System.Windows.Forms.Label
        Dim NameLabel1 As System.Windows.Forms.Label
        Dim DesignationLabel As System.Windows.Forms.Label
        Dim FAFromLabel As System.Windows.Forms.Label
        Dim FAToLabel As System.Windows.Forms.Label
        Dim OutTimeLabel As System.Windows.Forms.Label
        Dim InTimeLabel As System.Windows.Forms.Label
        Dim PurposeLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim TransportDateLabel As System.Windows.Forms.Label
        Dim VehicleLabel As System.Windows.Forms.Label
        Dim TruchNoLabel As System.Windows.Forms.Label
        Dim TrasportFromLabel As System.Windows.Forms.Label
        Dim TransportToLabel As System.Windows.Forms.Label
        Dim PurposeLabel1 As System.Windows.Forms.Label
        Dim AmountLabel1 As System.Windows.Forms.Label
        Dim ReferenceLabel As System.Windows.Forms.Label
        Dim ChallanNoLabel As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim DesignationLabel1 As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ConveyanceTab = New System.Windows.Forms.TabPage()
        Me.DesignationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ConveyanceBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConveyanceDataSet = New KSoft_Apparel.ConveyanceDataSet()
        Me.ConveyanceBillGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colConveyanceBillId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConveyanceDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSection = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.ConveyanceDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.CFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConveyanceDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewButton = New System.Windows.Forms.Button()
        Me.ConveyanceDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SectionTextBox = New System.Windows.Forms.TextBox()
        Me.PeriodTextBox = New System.Windows.Forms.TextBox()
        Me.FoodAllowanceTab = New System.Windows.Forms.TabPage()
        Me.InTimeTextBox = New System.Windows.Forms.TextBox()
        Me.FoodAllowanceBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodAllowanceDataSet = New KSoft_Apparel.FoodAllowanceDataSet()
        Me.OutTimeTextBox = New System.Windows.Forms.TextBox()
        Me.CancelEntryFAButton = New System.Windows.Forms.Button()
        Me.DeleteFAButton = New System.Windows.Forms.Button()
        Me.EditFAButton = New System.Windows.Forms.Button()
        Me.FoodAllowanceBillDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewFAButton = New System.Windows.Forms.Button()
        Me.FADateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.FAFromTextBox = New System.Windows.Forms.TextBox()
        Me.FAToTextBox = New System.Windows.Forms.TextBox()
        Me.PurposeTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.TransportBillTab = New System.Windows.Forms.TabPage()
        Me.CancelEntryTButton = New System.Windows.Forms.Button()
        Me.DeleteTButton = New System.Windows.Forms.Button()
        Me.EditTButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TransportBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportDataSet = New KSoft_Apparel.TransportDataSet()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.TransportBillDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewTButton = New System.Windows.Forms.Button()
        Me.TransportDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VehicleTextBox = New System.Windows.Forms.TextBox()
        Me.TruchNoTextBox = New System.Windows.Forms.TextBox()
        Me.TrasportFromTextBox = New System.Windows.Forms.TextBox()
        Me.TransportToTextBox = New System.Windows.Forms.TextBox()
        Me.PurposeTextBox1 = New System.Windows.Forms.TextBox()
        Me.AmountTextBox1 = New System.Windows.Forms.TextBox()
        Me.ReferenceTextBox = New System.Windows.Forms.TextBox()
        Me.ChallanNoTextBox = New System.Windows.Forms.TextBox()
        Me.ConveyanceBillTableAdapter = New KSoft_Apparel.ConveyanceDataSetTableAdapters.ConveyanceBillTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.ConveyanceDataSetTableAdapters.TableAdapterManager()
        Me.ConveyanceDetailsTableAdapter = New KSoft_Apparel.ConveyanceDataSetTableAdapters.ConveyanceDetailsTableAdapter()
        Me.FoodAllowanceBillTableAdapter = New KSoft_Apparel.FoodAllowanceDataSetTableAdapters.FoodAllowanceBillTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Apparel.FoodAllowanceDataSetTableAdapters.TableAdapterManager()
        Me.TransportBillTableAdapter = New KSoft_Apparel.TransportDataSetTableAdapters.TransportBillTableAdapter()
        Me.TableAdapterManager2 = New KSoft_Apparel.TransportDataSetTableAdapters.TableAdapterManager()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        ConveyanceDateLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        PeriodLabel = New System.Windows.Forms.Label()
        FADateLabel = New System.Windows.Forms.Label()
        NameLabel1 = New System.Windows.Forms.Label()
        DesignationLabel = New System.Windows.Forms.Label()
        FAFromLabel = New System.Windows.Forms.Label()
        FAToLabel = New System.Windows.Forms.Label()
        OutTimeLabel = New System.Windows.Forms.Label()
        InTimeLabel = New System.Windows.Forms.Label()
        PurposeLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        TransportDateLabel = New System.Windows.Forms.Label()
        VehicleLabel = New System.Windows.Forms.Label()
        TruchNoLabel = New System.Windows.Forms.Label()
        TrasportFromLabel = New System.Windows.Forms.Label()
        TransportToLabel = New System.Windows.Forms.Label()
        PurposeLabel1 = New System.Windows.Forms.Label()
        AmountLabel1 = New System.Windows.Forms.Label()
        ReferenceLabel = New System.Windows.Forms.Label()
        ChallanNoLabel = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        DesignationLabel1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.ConveyanceTab.SuspendLayout()
        CType(Me.DesignationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveyanceBillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveyanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveyanceBillGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveyanceDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConveyanceDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FoodAllowanceTab.SuspendLayout()
        CType(Me.FoodAllowanceBillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodAllowanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodAllowanceBillDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransportBillTab.SuspendLayout()
        CType(Me.TransportBillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportBillDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConveyanceDateLabel
        '
        ConveyanceDateLabel.AutoSize = True
        ConveyanceDateLabel.Location = New System.Drawing.Point(29, 29)
        ConveyanceDateLabel.Name = "ConveyanceDateLabel"
        ConveyanceDateLabel.Size = New System.Drawing.Size(96, 13)
        ConveyanceDateLabel.TabIndex = 2
        ConveyanceDateLabel.Text = "Conveyance Date:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(29, 57)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(29, 108)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(46, 13)
        SectionLabel.TabIndex = 6
        SectionLabel.Text = "Section:"
        '
        'PeriodLabel
        '
        PeriodLabel.AutoSize = True
        PeriodLabel.Location = New System.Drawing.Point(330, 108)
        PeriodLabel.Name = "PeriodLabel"
        PeriodLabel.Size = New System.Drawing.Size(40, 13)
        PeriodLabel.TabIndex = 8
        PeriodLabel.Text = "Period:"
        '
        'FADateLabel
        '
        FADateLabel.AutoSize = True
        FADateLabel.Location = New System.Drawing.Point(38, 45)
        FADateLabel.Name = "FADateLabel"
        FADateLabel.Size = New System.Drawing.Size(33, 13)
        FADateLabel.TabIndex = 2
        FADateLabel.Text = "Date:"
        '
        'NameLabel1
        '
        NameLabel1.AutoSize = True
        NameLabel1.Location = New System.Drawing.Point(38, 70)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(38, 13)
        NameLabel1.TabIndex = 4
        NameLabel1.Text = "Name:"
        '
        'DesignationLabel
        '
        DesignationLabel.AutoSize = True
        DesignationLabel.Location = New System.Drawing.Point(38, 96)
        DesignationLabel.Name = "DesignationLabel"
        DesignationLabel.Size = New System.Drawing.Size(66, 13)
        DesignationLabel.TabIndex = 6
        DesignationLabel.Text = "Designation:"
        '
        'FAFromLabel
        '
        FAFromLabel.AutoSize = True
        FAFromLabel.Location = New System.Drawing.Point(38, 122)
        FAFromLabel.Name = "FAFromLabel"
        FAFromLabel.Size = New System.Drawing.Size(33, 13)
        FAFromLabel.TabIndex = 8
        FAFromLabel.Text = "From:"
        '
        'FAToLabel
        '
        FAToLabel.AutoSize = True
        FAToLabel.Location = New System.Drawing.Point(346, 122)
        FAToLabel.Name = "FAToLabel"
        FAToLabel.Size = New System.Drawing.Size(23, 13)
        FAToLabel.TabIndex = 10
        FAToLabel.Text = "To:"
        '
        'OutTimeLabel
        '
        OutTimeLabel.AutoSize = True
        OutTimeLabel.Location = New System.Drawing.Point(346, 45)
        OutTimeLabel.Name = "OutTimeLabel"
        OutTimeLabel.Size = New System.Drawing.Size(53, 13)
        OutTimeLabel.TabIndex = 12
        OutTimeLabel.Text = "Out Time:"
        '
        'InTimeLabel
        '
        InTimeLabel.AutoSize = True
        InTimeLabel.Location = New System.Drawing.Point(346, 71)
        InTimeLabel.Name = "InTimeLabel"
        InTimeLabel.Size = New System.Drawing.Size(45, 13)
        InTimeLabel.TabIndex = 14
        InTimeLabel.Text = "In Time:"
        '
        'PurposeLabel
        '
        PurposeLabel.AutoSize = True
        PurposeLabel.Location = New System.Drawing.Point(38, 148)
        PurposeLabel.Name = "PurposeLabel"
        PurposeLabel.Size = New System.Drawing.Size(49, 13)
        PurposeLabel.TabIndex = 16
        PurposeLabel.Text = "Purpose:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(346, 96)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 18
        AmountLabel.Text = "Amount:"
        '
        'TransportDateLabel
        '
        TransportDateLabel.AutoSize = True
        TransportDateLabel.Location = New System.Drawing.Point(43, 38)
        TransportDateLabel.Name = "TransportDateLabel"
        TransportDateLabel.Size = New System.Drawing.Size(81, 13)
        TransportDateLabel.TabIndex = 2
        TransportDateLabel.Text = "Transport Date:"
        '
        'VehicleLabel
        '
        VehicleLabel.AutoSize = True
        VehicleLabel.Location = New System.Drawing.Point(43, 99)
        VehicleLabel.Name = "VehicleLabel"
        VehicleLabel.Size = New System.Drawing.Size(45, 13)
        VehicleLabel.TabIndex = 6
        VehicleLabel.Text = "Vehicle:"
        '
        'TruchNoLabel
        '
        TruchNoLabel.AutoSize = True
        TruchNoLabel.Location = New System.Drawing.Point(43, 125)
        TruchNoLabel.Name = "TruchNoLabel"
        TruchNoLabel.Size = New System.Drawing.Size(55, 13)
        TruchNoLabel.TabIndex = 8
        TruchNoLabel.Text = "Truck No:"
        '
        'TrasportFromLabel
        '
        TrasportFromLabel.AutoSize = True
        TrasportFromLabel.Location = New System.Drawing.Point(366, 69)
        TrasportFromLabel.Name = "TrasportFromLabel"
        TrasportFromLabel.Size = New System.Drawing.Size(75, 13)
        TrasportFromLabel.TabIndex = 10
        TrasportFromLabel.Text = "Trasport From:"
        '
        'TransportToLabel
        '
        TransportToLabel.AutoSize = True
        TransportToLabel.Location = New System.Drawing.Point(366, 95)
        TransportToLabel.Name = "TransportToLabel"
        TransportToLabel.Size = New System.Drawing.Size(71, 13)
        TransportToLabel.TabIndex = 12
        TransportToLabel.Text = "Transport To:"
        '
        'PurposeLabel1
        '
        PurposeLabel1.AutoSize = True
        PurposeLabel1.Location = New System.Drawing.Point(43, 185)
        PurposeLabel1.Name = "PurposeLabel1"
        PurposeLabel1.Size = New System.Drawing.Size(49, 13)
        PurposeLabel1.TabIndex = 14
        PurposeLabel1.Text = "Purpose:"
        '
        'AmountLabel1
        '
        AmountLabel1.AutoSize = True
        AmountLabel1.Location = New System.Drawing.Point(369, 121)
        AmountLabel1.Name = "AmountLabel1"
        AmountLabel1.Size = New System.Drawing.Size(46, 13)
        AmountLabel1.TabIndex = 16
        AmountLabel1.Text = "Amount:"
        '
        'ReferenceLabel
        '
        ReferenceLabel.AutoSize = True
        ReferenceLabel.Location = New System.Drawing.Point(43, 159)
        ReferenceLabel.Name = "ReferenceLabel"
        ReferenceLabel.Size = New System.Drawing.Size(60, 13)
        ReferenceLabel.TabIndex = 18
        ReferenceLabel.Text = "Reference:"
        '
        'ChallanNoLabel
        '
        ChallanNoLabel.AutoSize = True
        ChallanNoLabel.Location = New System.Drawing.Point(366, 159)
        ChallanNoLabel.Name = "ChallanNoLabel"
        ChallanNoLabel.Size = New System.Drawing.Size(62, 13)
        ChallanNoLabel.TabIndex = 20
        ChallanNoLabel.Text = "Challan No:"
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(44, 73)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(48, 13)
        SupplierIdLabel.TabIndex = 4
        SupplierIdLabel.Text = "Supplier "
        '
        'DesignationLabel1
        '
        DesignationLabel1.AutoSize = True
        DesignationLabel1.Location = New System.Drawing.Point(29, 80)
        DesignationLabel1.Name = "DesignationLabel1"
        DesignationLabel1.Size = New System.Drawing.Size(66, 13)
        DesignationLabel1.TabIndex = 17
        DesignationLabel1.Text = "Designation:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ConveyanceTab)
        Me.TabControl1.Controls.Add(Me.FoodAllowanceTab)
        Me.TabControl1.Controls.Add(Me.TransportBillTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(888, 594)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.Tag = "NR"
        '
        'ConveyanceTab
        '
        Me.ConveyanceTab.Controls.Add(Me.DesignationTextEdit)
        Me.ConveyanceTab.Controls.Add(DesignationLabel1)
        Me.ConveyanceTab.Controls.Add(Me.ConveyanceBillGridControl)
        Me.ConveyanceTab.Controls.Add(Me.CancelEntryButton)
        Me.ConveyanceTab.Controls.Add(Me.DeleteButton)
        Me.ConveyanceTab.Controls.Add(Me.EditButton)
        Me.ConveyanceTab.Controls.Add(Me.ConveyanceDetailsDataGridView)
        Me.ConveyanceTab.Controls.Add(Me.NewButton)
        Me.ConveyanceTab.Controls.Add(ConveyanceDateLabel)
        Me.ConveyanceTab.Controls.Add(Me.ConveyanceDateDateTimePicker)
        Me.ConveyanceTab.Controls.Add(NameLabel)
        Me.ConveyanceTab.Controls.Add(Me.NameTextBox)
        Me.ConveyanceTab.Controls.Add(SectionLabel)
        Me.ConveyanceTab.Controls.Add(Me.SectionTextBox)
        Me.ConveyanceTab.Controls.Add(PeriodLabel)
        Me.ConveyanceTab.Controls.Add(Me.PeriodTextBox)
        Me.ConveyanceTab.Location = New System.Drawing.Point(4, 22)
        Me.ConveyanceTab.Name = "ConveyanceTab"
        Me.ConveyanceTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ConveyanceTab.Size = New System.Drawing.Size(880, 568)
        Me.ConveyanceTab.TabIndex = 0
        Me.ConveyanceTab.Text = "Conveyance"
        Me.ConveyanceTab.UseVisualStyleBackColor = True
        '
        'DesignationTextEdit
        '
        Me.DesignationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ConveyanceBillBindingSource, "Designation", True))
        Me.DesignationTextEdit.Location = New System.Drawing.Point(133, 77)
        Me.DesignationTextEdit.Name = "DesignationTextEdit"
        Me.DesignationTextEdit.Size = New System.Drawing.Size(148, 20)
        Me.DesignationTextEdit.TabIndex = 18
        '
        'ConveyanceBillBindingSource
        '
        Me.ConveyanceBillBindingSource.DataMember = "ConveyanceBill"
        Me.ConveyanceBillBindingSource.DataSource = Me.ConveyanceDataSet
        '
        'ConveyanceDataSet
        '
        Me.ConveyanceDataSet.DataSetName = "ConveyanceDataSet"
        Me.ConveyanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConveyanceBillGridControl
        '
        Me.ConveyanceBillGridControl.DataSource = Me.ConveyanceBillBindingSource
        Me.ConveyanceBillGridControl.Location = New System.Drawing.Point(32, 314)
        Me.ConveyanceBillGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.ConveyanceBillGridControl.MainView = Me.GridView1
        Me.ConveyanceBillGridControl.Name = "ConveyanceBillGridControl"
        Me.ConveyanceBillGridControl.Size = New System.Drawing.Size(820, 220)
        Me.ConveyanceBillGridControl.TabIndex = 17
        Me.ConveyanceBillGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colConveyanceBillId, Me.colConveyanceDate, Me.colName, Me.colDesignation, Me.colSection, Me.colPeriod})
        Me.GridView1.GridControl = Me.ConveyanceBillGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        '
        'colConveyanceBillId
        '
        Me.colConveyanceBillId.FieldName = "ConveyanceBillId"
        Me.colConveyanceBillId.Name = "colConveyanceBillId"
        Me.colConveyanceBillId.OptionsColumn.AllowEdit = False
        Me.colConveyanceBillId.OptionsColumn.ReadOnly = True
        Me.colConveyanceBillId.Visible = True
        Me.colConveyanceBillId.VisibleIndex = 0
        '
        'colConveyanceDate
        '
        Me.colConveyanceDate.FieldName = "ConveyanceDate"
        Me.colConveyanceDate.Name = "colConveyanceDate"
        Me.colConveyanceDate.OptionsColumn.AllowEdit = False
        Me.colConveyanceDate.Visible = True
        Me.colConveyanceDate.VisibleIndex = 1
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.OptionsColumn.AllowEdit = False
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 2
        '
        'colDesignation
        '
        Me.colDesignation.FieldName = "Designation"
        Me.colDesignation.Name = "colDesignation"
        Me.colDesignation.Visible = True
        Me.colDesignation.VisibleIndex = 3
        '
        'colSection
        '
        Me.colSection.FieldName = "Section"
        Me.colSection.Name = "colSection"
        Me.colSection.OptionsColumn.AllowEdit = False
        Me.colSection.Visible = True
        Me.colSection.VisibleIndex = 4
        '
        'colPeriod
        '
        Me.colPeriod.FieldName = "Period"
        Me.colPeriod.Name = "colPeriod"
        Me.colPeriod.OptionsColumn.AllowEdit = False
        Me.colPeriod.Visible = True
        Me.colPeriod.VisibleIndex = 5
        '
        'CancelEntryButton
        '
        Me.CancelEntryButton.Enabled = False
        Me.CancelEntryButton.Location = New System.Drawing.Point(758, 115)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(94, 28)
        Me.CancelEntryButton.TabIndex = 17
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(758, 81)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(94, 28)
        Me.DeleteButton.TabIndex = 16
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(758, 46)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(94, 29)
        Me.EditButton.TabIndex = 15
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'ConveyanceDetailsDataGridView
        '
        Me.ConveyanceDetailsDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConveyanceDetailsDataGridView.AutoGenerateColumns = False
        Me.ConveyanceDetailsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ConveyanceDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConveyanceDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CFrom, Me.CTo, Me.Purpose, Me.DataGridViewTextBoxColumn6})
        Me.ConveyanceDetailsDataGridView.DataSource = Me.ConveyanceDetailsBindingSource
        Me.ConveyanceDetailsDataGridView.Location = New System.Drawing.Point(32, 161)
        Me.ConveyanceDetailsDataGridView.Name = "ConveyanceDetailsDataGridView"
        Me.ConveyanceDetailsDataGridView.RowTemplate.Height = 24
        Me.ConveyanceDetailsDataGridView.Size = New System.Drawing.Size(820, 147)
        Me.ConveyanceDetailsDataGridView.TabIndex = 13
        '
        'CFrom
        '
        Me.CFrom.DataPropertyName = "CFrom"
        Me.CFrom.HeaderText = "From"
        Me.CFrom.Name = "CFrom"
        Me.CFrom.Width = 200
        '
        'CTo
        '
        Me.CTo.DataPropertyName = "CTo"
        Me.CTo.HeaderText = "To"
        Me.CTo.Name = "CTo"
        Me.CTo.Width = 200
        '
        'Purpose
        '
        Me.Purpose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Purpose.DataPropertyName = "Purpose"
        Me.Purpose.HeaderText = "Purpose"
        Me.Purpose.Name = "Purpose"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'ConveyanceDetailsBindingSource
        '
        Me.ConveyanceDetailsBindingSource.DataMember = "FK_ConveyanceDetails_ConveyanceBill"
        Me.ConveyanceDetailsBindingSource.DataSource = Me.ConveyanceBillBindingSource
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(758, 14)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(94, 28)
        Me.NewButton.TabIndex = 12
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'ConveyanceDateDateTimePicker
        '
        Me.ConveyanceDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ConveyanceDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ConveyanceBillBindingSource, "ConveyanceDate", True))
        Me.ConveyanceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ConveyanceDateDateTimePicker.Location = New System.Drawing.Point(133, 25)
        Me.ConveyanceDateDateTimePicker.Name = "ConveyanceDateDateTimePicker"
        Me.ConveyanceDateDateTimePicker.Size = New System.Drawing.Size(107, 20)
        Me.ConveyanceDateDateTimePicker.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveyanceBillBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(133, 51)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(391, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'SectionTextBox
        '
        Me.SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveyanceBillBindingSource, "Section", True))
        Me.SectionTextBox.Location = New System.Drawing.Point(133, 105)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.Size = New System.Drawing.Size(148, 20)
        Me.SectionTextBox.TabIndex = 7
        '
        'PeriodTextBox
        '
        Me.PeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConveyanceBillBindingSource, "Period", True))
        Me.PeriodTextBox.Location = New System.Drawing.Point(376, 105)
        Me.PeriodTextBox.Name = "PeriodTextBox"
        Me.PeriodTextBox.Size = New System.Drawing.Size(148, 20)
        Me.PeriodTextBox.TabIndex = 9
        '
        'FoodAllowanceTab
        '
        Me.FoodAllowanceTab.Controls.Add(Me.InTimeTextBox)
        Me.FoodAllowanceTab.Controls.Add(Me.OutTimeTextBox)
        Me.FoodAllowanceTab.Controls.Add(Me.CancelEntryFAButton)
        Me.FoodAllowanceTab.Controls.Add(Me.DeleteFAButton)
        Me.FoodAllowanceTab.Controls.Add(Me.EditFAButton)
        Me.FoodAllowanceTab.Controls.Add(Me.FoodAllowanceBillDataGridView)
        Me.FoodAllowanceTab.Controls.Add(Me.NewFAButton)
        Me.FoodAllowanceTab.Controls.Add(FADateLabel)
        Me.FoodAllowanceTab.Controls.Add(Me.FADateDateTimePicker)
        Me.FoodAllowanceTab.Controls.Add(NameLabel1)
        Me.FoodAllowanceTab.Controls.Add(Me.NameTextBox1)
        Me.FoodAllowanceTab.Controls.Add(DesignationLabel)
        Me.FoodAllowanceTab.Controls.Add(Me.DesignationTextBox)
        Me.FoodAllowanceTab.Controls.Add(FAFromLabel)
        Me.FoodAllowanceTab.Controls.Add(Me.FAFromTextBox)
        Me.FoodAllowanceTab.Controls.Add(FAToLabel)
        Me.FoodAllowanceTab.Controls.Add(Me.FAToTextBox)
        Me.FoodAllowanceTab.Controls.Add(OutTimeLabel)
        Me.FoodAllowanceTab.Controls.Add(InTimeLabel)
        Me.FoodAllowanceTab.Controls.Add(PurposeLabel)
        Me.FoodAllowanceTab.Controls.Add(Me.PurposeTextBox)
        Me.FoodAllowanceTab.Controls.Add(AmountLabel)
        Me.FoodAllowanceTab.Controls.Add(Me.AmountTextBox)
        Me.FoodAllowanceTab.Location = New System.Drawing.Point(4, 22)
        Me.FoodAllowanceTab.Name = "FoodAllowanceTab"
        Me.FoodAllowanceTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FoodAllowanceTab.Size = New System.Drawing.Size(880, 568)
        Me.FoodAllowanceTab.TabIndex = 1
        Me.FoodAllowanceTab.Text = "Food Allowance"
        Me.FoodAllowanceTab.UseVisualStyleBackColor = True
        '
        'InTimeTextBox
        '
        Me.InTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FoodAllowanceBillBindingSource, "InTime", True))
        Me.InTimeTextBox.Location = New System.Drawing.Point(466, 66)
        Me.InTimeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.InTimeTextBox.Name = "InTimeTextBox"
        Me.InTimeTextBox.Size = New System.Drawing.Size(154, 20)
        Me.InTimeTextBox.TabIndex = 26
        '
        'FoodAllowanceBillBindingSource
        '
        Me.FoodAllowanceBillBindingSource.DataMember = "FoodAllowanceBill"
        Me.FoodAllowanceBillBindingSource.DataSource = Me.FoodAllowanceDataSet
        '
        'FoodAllowanceDataSet
        '
        Me.FoodAllowanceDataSet.DataSetName = "FoodAllowanceDataSet"
        Me.FoodAllowanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OutTimeTextBox
        '
        Me.OutTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FoodAllowanceBillBindingSource, "OutTime", True))
        Me.OutTimeTextBox.Location = New System.Drawing.Point(466, 41)
        Me.OutTimeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.OutTimeTextBox.Name = "OutTimeTextBox"
        Me.OutTimeTextBox.Size = New System.Drawing.Size(154, 20)
        Me.OutTimeTextBox.TabIndex = 25
        '
        'CancelEntryFAButton
        '
        Me.CancelEntryFAButton.Enabled = False
        Me.CancelEntryFAButton.Location = New System.Drawing.Point(741, 154)
        Me.CancelEntryFAButton.Name = "CancelEntryFAButton"
        Me.CancelEntryFAButton.Size = New System.Drawing.Size(91, 31)
        Me.CancelEntryFAButton.TabIndex = 24
        Me.CancelEntryFAButton.Tag = "NR"
        Me.CancelEntryFAButton.Text = "&Cancel"
        Me.CancelEntryFAButton.UseVisualStyleBackColor = True
        '
        'DeleteFAButton
        '
        Me.DeleteFAButton.Location = New System.Drawing.Point(741, 117)
        Me.DeleteFAButton.Name = "DeleteFAButton"
        Me.DeleteFAButton.Size = New System.Drawing.Size(91, 31)
        Me.DeleteFAButton.TabIndex = 23
        Me.DeleteFAButton.Tag = "NR"
        Me.DeleteFAButton.Text = "&Delete"
        Me.DeleteFAButton.UseVisualStyleBackColor = True
        '
        'EditFAButton
        '
        Me.EditFAButton.Location = New System.Drawing.Point(741, 79)
        Me.EditFAButton.Name = "EditFAButton"
        Me.EditFAButton.Size = New System.Drawing.Size(91, 31)
        Me.EditFAButton.TabIndex = 22
        Me.EditFAButton.Tag = "NR"
        Me.EditFAButton.Text = "&Edit"
        Me.EditFAButton.UseVisualStyleBackColor = True
        '
        'FoodAllowanceBillDataGridView
        '
        Me.FoodAllowanceBillDataGridView.AllowUserToAddRows = False
        Me.FoodAllowanceBillDataGridView.AllowUserToDeleteRows = False
        Me.FoodAllowanceBillDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FoodAllowanceBillDataGridView.AutoGenerateColumns = False
        Me.FoodAllowanceBillDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FoodAllowanceBillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FoodAllowanceBillDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn13})
        Me.FoodAllowanceBillDataGridView.DataSource = Me.FoodAllowanceBillBindingSource
        Me.FoodAllowanceBillDataGridView.Location = New System.Drawing.Point(40, 202)
        Me.FoodAllowanceBillDataGridView.Name = "FoodAllowanceBillDataGridView"
        Me.FoodAllowanceBillDataGridView.ReadOnly = True
        Me.FoodAllowanceBillDataGridView.Size = New System.Drawing.Size(792, 342)
        Me.FoodAllowanceBillDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FADate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Designation"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Designation"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Purpose"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Purpose"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'NewFAButton
        '
        Me.NewFAButton.Location = New System.Drawing.Point(741, 41)
        Me.NewFAButton.Name = "NewFAButton"
        Me.NewFAButton.Size = New System.Drawing.Size(91, 31)
        Me.NewFAButton.TabIndex = 20
        Me.NewFAButton.Tag = "NR"
        Me.NewFAButton.Text = "&New"
        Me.NewFAButton.UseVisualStyleBackColor = True
        '
        'FADateDateTimePicker
        '
        Me.FADateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FADateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FoodAllowanceBillBindingSource, "FADate", True))
        Me.FADateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FADateDateTimePicker.Location = New System.Drawing.Point(124, 41)
        Me.FADateDateTimePicker.Name = "FADateDateTimePicker"
        Me.FADateDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.FADateDateTimePicker.TabIndex = 3
        '
        'NameTextBox1
        '
        Me.NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FoodAllowanceBillBindingSource, "Name", True))
        Me.NameTextBox1.Location = New System.Drawing.Point(124, 67)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(163, 20)
        Me.NameTextBox1.TabIndex = 5
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FoodAllowanceBillBindingSource, "Designation", True))
        Me.DesignationTextBox.Location = New System.Drawing.Point(124, 93)
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(163, 20)
        Me.DesignationTextBox.TabIndex = 7
        '
        'FAFromTextBox
        '
        Me.FAFromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FoodAllowanceBillBindingSource, "FAFrom", True))
        Me.FAFromTextBox.Location = New System.Drawing.Point(124, 119)
        Me.FAFromTextBox.Name = "FAFromTextBox"
        Me.FAFromTextBox.Size = New System.Drawing.Size(163, 20)
        Me.FAFromTextBox.TabIndex = 9
        '
        'FAToTextBox
        '
        Me.FAToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FoodAllowanceBillBindingSource, "FATo", True))
        Me.FAToTextBox.Location = New System.Drawing.Point(466, 119)
        Me.FAToTextBox.Name = "FAToTextBox"
        Me.FAToTextBox.Size = New System.Drawing.Size(154, 20)
        Me.FAToTextBox.TabIndex = 11
        '
        'PurposeTextBox
        '
        Me.PurposeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FoodAllowanceBillBindingSource, "Purpose", True))
        Me.PurposeTextBox.Location = New System.Drawing.Point(124, 145)
        Me.PurposeTextBox.Multiline = True
        Me.PurposeTextBox.Name = "PurposeTextBox"
        Me.PurposeTextBox.Size = New System.Drawing.Size(496, 40)
        Me.PurposeTextBox.TabIndex = 17
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FoodAllowanceBillBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(466, 93)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(154, 20)
        Me.AmountTextBox.TabIndex = 19
        '
        'TransportBillTab
        '
        Me.TransportBillTab.Controls.Add(Me.CancelEntryTButton)
        Me.TransportBillTab.Controls.Add(Me.DeleteTButton)
        Me.TransportBillTab.Controls.Add(Me.EditTButton)
        Me.TransportBillTab.Controls.Add(Me.ComboBox1)
        Me.TransportBillTab.Controls.Add(Me.TransportBillDataGridView)
        Me.TransportBillTab.Controls.Add(Me.NewTButton)
        Me.TransportBillTab.Controls.Add(TransportDateLabel)
        Me.TransportBillTab.Controls.Add(Me.TransportDateDateTimePicker)
        Me.TransportBillTab.Controls.Add(SupplierIdLabel)
        Me.TransportBillTab.Controls.Add(VehicleLabel)
        Me.TransportBillTab.Controls.Add(Me.VehicleTextBox)
        Me.TransportBillTab.Controls.Add(TruchNoLabel)
        Me.TransportBillTab.Controls.Add(Me.TruchNoTextBox)
        Me.TransportBillTab.Controls.Add(TrasportFromLabel)
        Me.TransportBillTab.Controls.Add(Me.TrasportFromTextBox)
        Me.TransportBillTab.Controls.Add(TransportToLabel)
        Me.TransportBillTab.Controls.Add(Me.TransportToTextBox)
        Me.TransportBillTab.Controls.Add(PurposeLabel1)
        Me.TransportBillTab.Controls.Add(Me.PurposeTextBox1)
        Me.TransportBillTab.Controls.Add(AmountLabel1)
        Me.TransportBillTab.Controls.Add(Me.AmountTextBox1)
        Me.TransportBillTab.Controls.Add(ReferenceLabel)
        Me.TransportBillTab.Controls.Add(Me.ReferenceTextBox)
        Me.TransportBillTab.Controls.Add(ChallanNoLabel)
        Me.TransportBillTab.Controls.Add(Me.ChallanNoTextBox)
        Me.TransportBillTab.Location = New System.Drawing.Point(4, 22)
        Me.TransportBillTab.Name = "TransportBillTab"
        Me.TransportBillTab.Padding = New System.Windows.Forms.Padding(3)
        Me.TransportBillTab.Size = New System.Drawing.Size(880, 568)
        Me.TransportBillTab.TabIndex = 2
        Me.TransportBillTab.Text = "Transport Bill"
        Me.TransportBillTab.UseVisualStyleBackColor = True
        '
        'CancelEntryTButton
        '
        Me.CancelEntryTButton.Enabled = False
        Me.CancelEntryTButton.Location = New System.Drawing.Point(734, 164)
        Me.CancelEntryTButton.Name = "CancelEntryTButton"
        Me.CancelEntryTButton.Size = New System.Drawing.Size(94, 34)
        Me.CancelEntryTButton.TabIndex = 27
        Me.CancelEntryTButton.Text = "&Cancel"
        Me.CancelEntryTButton.UseVisualStyleBackColor = True
        '
        'DeleteTButton
        '
        Me.DeleteTButton.Location = New System.Drawing.Point(734, 125)
        Me.DeleteTButton.Name = "DeleteTButton"
        Me.DeleteTButton.Size = New System.Drawing.Size(94, 34)
        Me.DeleteTButton.TabIndex = 26
        Me.DeleteTButton.Text = "&Delete"
        Me.DeleteTButton.UseVisualStyleBackColor = True
        '
        'EditTButton
        '
        Me.EditTButton.Location = New System.Drawing.Point(734, 86)
        Me.EditTButton.Name = "EditTButton"
        Me.EditTButton.Size = New System.Drawing.Size(94, 34)
        Me.EditTButton.TabIndex = 25
        Me.EditTButton.Text = "&Edit"
        Me.EditTButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TransportBillBindingSource, "SupplierId", True))
        Me.ComboBox1.DataSource = Me.SupplierBindingSource
        Me.ComboBox1.DisplayMember = "SupplierName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(132, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 24
        Me.ComboBox1.ValueMember = "SupplierId"
        '
        'TransportBillBindingSource
        '
        Me.TransportBillBindingSource.DataMember = "TransportBill"
        Me.TransportBillBindingSource.DataSource = Me.TransportDataSet
        '
        'TransportDataSet
        '
        Me.TransportDataSet.DataSetName = "TransportDataSet"
        Me.TransportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransportBillDataGridView
        '
        Me.TransportBillDataGridView.AllowUserToAddRows = False
        Me.TransportBillDataGridView.AllowUserToDeleteRows = False
        Me.TransportBillDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TransportBillDataGridView.AutoGenerateColumns = False
        Me.TransportBillDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TransportBillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TransportBillDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17})
        Me.TransportBillDataGridView.DataSource = Me.TransportBillBindingSource
        Me.TransportBillDataGridView.Location = New System.Drawing.Point(46, 221)
        Me.TransportBillDataGridView.Name = "TransportBillDataGridView"
        Me.TransportBillDataGridView.ReadOnly = True
        Me.TransportBillDataGridView.Size = New System.Drawing.Size(782, 316)
        Me.TransportBillDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TransportDate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Transport Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SupplierId"
        Me.DataGridViewTextBoxColumn10.DataSource = Me.SupplierBindingSource
        Me.DataGridViewTextBoxColumn10.DisplayMember = "SupplierName"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.ValueMember = "SupplierId"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "ChallanNo"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Challan No"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TrasportFrom"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Trasport From"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TransportTo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Transport To"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'NewTButton
        '
        Me.NewTButton.Location = New System.Drawing.Point(734, 47)
        Me.NewTButton.Name = "NewTButton"
        Me.NewTButton.Size = New System.Drawing.Size(94, 34)
        Me.NewTButton.TabIndex = 22
        Me.NewTButton.Text = "&New"
        Me.NewTButton.UseVisualStyleBackColor = True
        '
        'TransportDateDateTimePicker
        '
        Me.TransportDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.TransportDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TransportBillBindingSource, "TransportDate", True))
        Me.TransportDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TransportDateDateTimePicker.Location = New System.Drawing.Point(132, 34)
        Me.TransportDateDateTimePicker.Name = "TransportDateDateTimePicker"
        Me.TransportDateDateTimePicker.Size = New System.Drawing.Size(109, 20)
        Me.TransportDateDateTimePicker.TabIndex = 3
        '
        'VehicleTextBox
        '
        Me.VehicleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportBillBindingSource, "Vehicle", True))
        Me.VehicleTextBox.Location = New System.Drawing.Point(132, 96)
        Me.VehicleTextBox.Name = "VehicleTextBox"
        Me.VehicleTextBox.Size = New System.Drawing.Size(178, 20)
        Me.VehicleTextBox.TabIndex = 7
        '
        'TruchNoTextBox
        '
        Me.TruchNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportBillBindingSource, "TruchNo", True))
        Me.TruchNoTextBox.Location = New System.Drawing.Point(132, 122)
        Me.TruchNoTextBox.Name = "TruchNoTextBox"
        Me.TruchNoTextBox.Size = New System.Drawing.Size(178, 20)
        Me.TruchNoTextBox.TabIndex = 9
        '
        'TrasportFromTextBox
        '
        Me.TrasportFromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportBillBindingSource, "TrasportFrom", True))
        Me.TrasportFromTextBox.Location = New System.Drawing.Point(455, 66)
        Me.TrasportFromTextBox.Name = "TrasportFromTextBox"
        Me.TrasportFromTextBox.Size = New System.Drawing.Size(178, 20)
        Me.TrasportFromTextBox.TabIndex = 11
        '
        'TransportToTextBox
        '
        Me.TransportToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportBillBindingSource, "TransportTo", True))
        Me.TransportToTextBox.Location = New System.Drawing.Point(455, 92)
        Me.TransportToTextBox.Name = "TransportToTextBox"
        Me.TransportToTextBox.Size = New System.Drawing.Size(178, 20)
        Me.TransportToTextBox.TabIndex = 13
        '
        'PurposeTextBox1
        '
        Me.PurposeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportBillBindingSource, "Purpose", True))
        Me.PurposeTextBox1.Location = New System.Drawing.Point(132, 182)
        Me.PurposeTextBox1.Name = "PurposeTextBox1"
        Me.PurposeTextBox1.Size = New System.Drawing.Size(501, 20)
        Me.PurposeTextBox1.TabIndex = 15
        '
        'AmountTextBox1
        '
        Me.AmountTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportBillBindingSource, "Amount", True))
        Me.AmountTextBox1.Location = New System.Drawing.Point(455, 118)
        Me.AmountTextBox1.Name = "AmountTextBox1"
        Me.AmountTextBox1.Size = New System.Drawing.Size(178, 20)
        Me.AmountTextBox1.TabIndex = 17
        '
        'ReferenceTextBox
        '
        Me.ReferenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportBillBindingSource, "Reference", True))
        Me.ReferenceTextBox.Location = New System.Drawing.Point(132, 156)
        Me.ReferenceTextBox.Name = "ReferenceTextBox"
        Me.ReferenceTextBox.Size = New System.Drawing.Size(178, 20)
        Me.ReferenceTextBox.TabIndex = 19
        '
        'ChallanNoTextBox
        '
        Me.ChallanNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransportBillBindingSource, "ChallanNo", True))
        Me.ChallanNoTextBox.Location = New System.Drawing.Point(455, 156)
        Me.ChallanNoTextBox.Name = "ChallanNoTextBox"
        Me.ChallanNoTextBox.Size = New System.Drawing.Size(178, 20)
        Me.ChallanNoTextBox.TabIndex = 21
        '
        'ConveyanceBillTableAdapter
        '
        Me.ConveyanceBillTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ConveyanceBillTableAdapter = Me.ConveyanceBillTableAdapter
        Me.TableAdapterManager.ConveyanceDetailsTableAdapter = Me.ConveyanceDetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ConveyanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ConveyanceDetailsTableAdapter
        '
        Me.ConveyanceDetailsTableAdapter.ClearBeforeFill = True
        '
        'FoodAllowanceBillTableAdapter
        '
        Me.FoodAllowanceBillTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.FoodAllowanceBillTableAdapter = Me.FoodAllowanceBillTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.FoodAllowanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TransportBillTableAdapter
        '
        Me.TransportBillTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.TransportBillTableAdapter = Me.TransportBillTableAdapter
        Me.TableAdapterManager2.UpdateOrder = KSoft_Apparel.TransportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 594)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBill"
        Me.Text = "Bill"
        Me.TabControl1.ResumeLayout(False)
        Me.ConveyanceTab.ResumeLayout(False)
        Me.ConveyanceTab.PerformLayout()
        CType(Me.DesignationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveyanceBillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveyanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveyanceBillGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveyanceDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConveyanceDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FoodAllowanceTab.ResumeLayout(False)
        Me.FoodAllowanceTab.PerformLayout()
        CType(Me.FoodAllowanceBillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodAllowanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodAllowanceBillDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransportBillTab.ResumeLayout(False)
        Me.TransportBillTab.PerformLayout()
        CType(Me.TransportBillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportBillDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ConveyanceTab As System.Windows.Forms.TabPage
    Friend WithEvents FoodAllowanceTab As System.Windows.Forms.TabPage
    Friend WithEvents TransportBillTab As System.Windows.Forms.TabPage
    Friend WithEvents ConveyanceDataSet As KSoft_Apparel.ConveyanceDataSet
    Friend WithEvents ConveyanceBillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConveyanceBillTableAdapter As KSoft_Apparel.ConveyanceDataSetTableAdapters.ConveyanceBillTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ConveyanceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents ConveyanceDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PeriodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConveyanceDetailsTableAdapter As KSoft_Apparel.ConveyanceDataSetTableAdapters.ConveyanceDetailsTableAdapter
    Friend WithEvents ConveyanceDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConveyanceDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FoodAllowanceDataSet As KSoft_Apparel.FoodAllowanceDataSet
    Friend WithEvents FoodAllowanceBillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FoodAllowanceBillTableAdapter As KSoft_Apparel.FoodAllowanceDataSetTableAdapters.FoodAllowanceBillTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.FoodAllowanceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NewFAButton As System.Windows.Forms.Button
    Friend WithEvents FADateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DesignationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FAFromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FAToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PurposeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransportDataSet As KSoft_Apparel.TransportDataSet
    Friend WithEvents TransportBillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransportBillTableAdapter As KSoft_Apparel.TransportDataSetTableAdapters.TransportBillTableAdapter
    Friend WithEvents TableAdapterManager2 As KSoft_Apparel.TransportDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NewTButton As System.Windows.Forms.Button
    Friend WithEvents TransportDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents VehicleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TruchNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TrasportFromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransportToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PurposeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ReferenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChallanNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FoodAllowanceBillDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransportBillDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryFAButton As System.Windows.Forms.Button
    Friend WithEvents DeleteFAButton As System.Windows.Forms.Button
    Friend WithEvents EditFAButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryTButton As System.Windows.Forms.Button
    Friend WithEvents DeleteTButton As System.Windows.Forms.Button
    Friend WithEvents EditTButton As System.Windows.Forms.Button
    Friend WithEvents CFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Purpose As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OutTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConveyanceBillGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colConveyanceBillId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConveyanceDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSection As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DesignationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colDesignation As DevExpress.XtraGrid.Columns.GridColumn
End Class
