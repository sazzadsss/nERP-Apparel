<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyeingProductionReport
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.ShiftwiseRadioButton = New System.Windows.Forms.RadioButton()
        Me.ProductionCategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FinishFabricOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupDataSet = New KSoft_Dyeing.FinishFabricOrderLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgramShowButton = New System.Windows.Forms.Button()
        Me.MachineRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ShowByBuyerButton = New System.Windows.Forms.Button()
        Me.BuyerLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.LoadFFBBuyerListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadFFBBuyerListDataSet = New KSoft_Dyeing.LoadFFBBuyerListDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Dyeing.BuyerDataSet()
        Me.BuyerTableAdapter = New KSoft_Dyeing.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.LoadFFBBuyerListTableAdapter = New KSoft_Dyeing.LoadFFBBuyerListDataSetTableAdapters.LoadFFBBuyerListTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BatchNoLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BatchProgramNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BatchProgramLookupDataSet = New KSoft_Dyeing.BatchProgramLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBatchNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BatchProgramNoTableAdapter = New KSoft_Dyeing.BatchProgramLookupDataSetTableAdapters.BatchProgramNoTableAdapter()
        Me.FinishFabricOrderLookupTableAdapter = New KSoft_Dyeing.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShowProductionCategoryButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CustomerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CustomerListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerListDataSet = New KSoft_Dyeing.CustomerListDataSet()
        Me.CustomerIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCustomerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CustomerListTableAdapter = New KSoft_Dyeing.CustomerListDataSetTableAdapters.CustomerListTableAdapter()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadFFBBuyerListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadFFBBuyerListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatchProgramLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CustomerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(258, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(82, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 85)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1289, 602)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(468, 12)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(91, 23)
        Me.ShowButton.TabIndex = 3
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'ShiftwiseRadioButton
        '
        Me.ShiftwiseRadioButton.AutoSize = True
        Me.ShiftwiseRadioButton.Location = New System.Drawing.Point(3, 26)
        Me.ShiftwiseRadioButton.Name = "ShiftwiseRadioButton"
        Me.ShiftwiseRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.ShiftwiseRadioButton.TabIndex = 5
        Me.ShiftwiseRadioButton.Text = "Shiftwise"
        Me.ShiftwiseRadioButton.UseVisualStyleBackColor = True
        '
        'ProductionCategoryRadioButton
        '
        Me.ProductionCategoryRadioButton.AutoSize = True
        Me.ProductionCategoryRadioButton.Checked = True
        Me.ProductionCategoryRadioButton.Location = New System.Drawing.Point(3, 3)
        Me.ProductionCategoryRadioButton.Name = "ProductionCategoryRadioButton"
        Me.ProductionCategoryRadioButton.Size = New System.Drawing.Size(121, 17)
        Me.ProductionCategoryRadioButton.TabIndex = 6
        Me.ProductionCategoryRadioButton.TabStop = True
        Me.ProductionCategoryRadioButton.Text = "Production Category"
        Me.ProductionCategoryRadioButton.UseVisualStyleBackColor = True
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(654, 15)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type Program No]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "ProgramNo"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(138, 20)
        Me.GridLookUpEdit1.TabIndex = 7
        '
        'FinishFabricOrderLookupBindingSource
        '
        Me.FinishFabricOrderLookupBindingSource.DataMember = "FinishFabricOrderLookup"
        Me.FinishFabricOrderLookupBindingSource.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'FinishFabricOrderLookupDataSet
        '
        Me.FinishFabricOrderLookupDataSet.DataSetName = "FinishFabricOrderLookupDataSet"
        Me.FinishFabricOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo, Me.colStyleName, Me.colBuyerName1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 1
        '
        'colBuyerName1
        '
        Me.colBuyerName1.FieldName = "BuyerName"
        Me.colBuyerName1.Name = "colBuyerName1"
        Me.colBuyerName1.Visible = True
        Me.colBuyerName1.VisibleIndex = 2
        '
        'ProgramShowButton
        '
        Me.ProgramShowButton.Location = New System.Drawing.Point(796, 14)
        Me.ProgramShowButton.Name = "ProgramShowButton"
        Me.ProgramShowButton.Size = New System.Drawing.Size(91, 23)
        Me.ProgramShowButton.TabIndex = 8
        Me.ProgramShowButton.Text = "&Show"
        Me.ProgramShowButton.UseVisualStyleBackColor = True
        '
        'MachineRadioButton
        '
        Me.MachineRadioButton.AutoSize = True
        Me.MachineRadioButton.Location = New System.Drawing.Point(3, 49)
        Me.MachineRadioButton.Name = "MachineRadioButton"
        Me.MachineRadioButton.Size = New System.Drawing.Size(87, 17)
        Me.MachineRadioButton.TabIndex = 9
        Me.MachineRadioButton.Text = "Machinewise"
        Me.MachineRadioButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(156, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Dyeing Date From :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(346, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "To :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(377, 13)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(85, 20)
        Me.DateTimePicker2.TabIndex = 12
        '
        'ShowByBuyerButton
        '
        Me.ShowByBuyerButton.Location = New System.Drawing.Point(468, 47)
        Me.ShowByBuyerButton.Name = "ShowByBuyerButton"
        Me.ShowByBuyerButton.Size = New System.Drawing.Size(91, 23)
        Me.ShowByBuyerButton.TabIndex = 8
        Me.ShowByBuyerButton.Text = "&Show"
        Me.ShowByBuyerButton.UseVisualStyleBackColor = True
        '
        'BuyerLookupGridLookUpEdit
        '
        Me.BuyerLookupGridLookUpEdit.EditValue = "[Type Buyer]"
        Me.BuyerLookupGridLookUpEdit.Location = New System.Drawing.Point(258, 49)
        Me.BuyerLookupGridLookUpEdit.Name = "BuyerLookupGridLookUpEdit"
        Me.BuyerLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerLookupGridLookUpEdit.Properties.DataSource = Me.LoadFFBBuyerListBindingSource
        Me.BuyerLookupGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerLookupGridLookUpEdit.Properties.NullText = "[Type Buyer Name]"
        Me.BuyerLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerLookupGridLookUpEdit.Properties.ValueMember = "BuyerName"
        Me.BuyerLookupGridLookUpEdit.Properties.View = Me.GridView1
        Me.BuyerLookupGridLookUpEdit.Size = New System.Drawing.Size(204, 20)
        Me.BuyerLookupGridLookUpEdit.TabIndex = 13
        '
        'LoadFFBBuyerListBindingSource
        '
        Me.LoadFFBBuyerListBindingSource.DataMember = "LoadFFBBuyerList"
        Me.LoadFFBBuyerListBindingSource.DataSource = Me.LoadFFBBuyerListDataSet
        '
        'LoadFFBBuyerListDataSet
        '
        Me.LoadFFBBuyerListDataSet.DataSetName = "LoadFFBBuyerListDataSet"
        Me.LoadFFBBuyerListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 0
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'LoadFFBBuyerListTableAdapter
        '
        Me.LoadFFBBuyerListTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(156, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Buyer :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(579, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Program No :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(579, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Batch No :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(796, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BatchNoLookUpEdit
        '
        Me.BatchNoLookUpEdit.Location = New System.Drawing.Point(654, 50)
        Me.BatchNoLookUpEdit.Name = "BatchNoLookUpEdit"
        Me.BatchNoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BatchNoLookUpEdit.Properties.DataSource = Me.BatchProgramNoLookupBindingSource
        Me.BatchNoLookUpEdit.Properties.DisplayMember = "BatchNo"
        Me.BatchNoLookUpEdit.Properties.ImmediatePopup = True
        Me.BatchNoLookUpEdit.Properties.NullText = "[Type Batch No]"
        Me.BatchNoLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BatchNoLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BatchNoLookUpEdit.Properties.ValueMember = "BatchNo"
        Me.BatchNoLookUpEdit.Properties.View = Me.GridView2
        Me.BatchNoLookUpEdit.Size = New System.Drawing.Size(138, 20)
        Me.BatchNoLookUpEdit.TabIndex = 16
        '
        'BatchProgramNoLookupBindingSource
        '
        Me.BatchProgramNoLookupBindingSource.DataMember = "BatchProgramNoLookup"
        Me.BatchProgramNoLookupBindingSource.DataSource = Me.BatchProgramLookupDataSet
        '
        'BatchProgramLookupDataSet
        '
        Me.BatchProgramLookupDataSet.DataSetName = "BatchProgramLookupDataSet"
        Me.BatchProgramLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBatchNo})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colBatchNo
        '
        Me.colBatchNo.FieldName = "BatchNo"
        Me.colBatchNo.Name = "colBatchNo"
        Me.colBatchNo.Visible = True
        Me.colBatchNo.VisibleIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ProductionCategoryRadioButton)
        Me.Panel1.Controls.Add(Me.ShiftwiseRadioButton)
        Me.Panel1.Controls.Add(Me.MachineRadioButton)
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 70)
        Me.Panel1.TabIndex = 19
        '
        'BatchProgramNoTableAdapter
        '
        Me.BatchProgramNoTableAdapter.ClearBeforeFill = True
        '
        'FinishFabricOrderLookupTableAdapter
        '
        Me.FinishFabricOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Items.AddRange(New Object() {"Bulk", "Sample"})
        Me.CategoryComboBox.Location = New System.Drawing.Point(1007, 15)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(156, 21)
        Me.CategoryComboBox.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(893, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Production Category :"
        '
        'ShowProductionCategoryButton
        '
        Me.ShowProductionCategoryButton.Location = New System.Drawing.Point(1169, 14)
        Me.ShowProductionCategoryButton.Name = "ShowProductionCategoryButton"
        Me.ShowProductionCategoryButton.Size = New System.Drawing.Size(91, 23)
        Me.ShowProductionCategoryButton.TabIndex = 22
        Me.ShowProductionCategoryButton.Text = "&Show"
        Me.ShowProductionCategoryButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(893, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Customer :"
        '
        'CustomerIdGridLookUpEdit
        '
        Me.CustomerIdGridLookUpEdit.Location = New System.Drawing.Point(1007, 49)
        Me.CustomerIdGridLookUpEdit.Name = "CustomerIdGridLookUpEdit"
        Me.CustomerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustomerIdGridLookUpEdit.Properties.DataSource = Me.CustomerListBindingSource
        Me.CustomerIdGridLookUpEdit.Properties.DisplayMember = "CustomerName"
        Me.CustomerIdGridLookUpEdit.Properties.NullText = ""
        Me.CustomerIdGridLookUpEdit.Properties.ValueMember = "CustomerId"
        Me.CustomerIdGridLookUpEdit.Properties.View = Me.CustomerIdGridLookUpEditView
        Me.CustomerIdGridLookUpEdit.Size = New System.Drawing.Size(156, 20)
        Me.CustomerIdGridLookUpEdit.TabIndex = 28
        '
        'CustomerListBindingSource
        '
        Me.CustomerListBindingSource.DataMember = "CustomerList"
        Me.CustomerListBindingSource.DataSource = Me.CustomerListDataSet
        '
        'CustomerListDataSet
        '
        Me.CustomerListDataSet.DataSetName = "CustomerListDataSet"
        Me.CustomerListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerIdGridLookUpEditView
        '
        Me.CustomerIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomerId, Me.colCustomerName, Me.colContactPerson1, Me.colContactNo, Me.colAdd1, Me.colAdd2, Me.colCity, Me.colCountry})
        Me.CustomerIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CustomerIdGridLookUpEditView.Name = "CustomerIdGridLookUpEditView"
        Me.CustomerIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CustomerIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colCustomerId
        '
        Me.colCustomerId.FieldName = "CustomerId"
        Me.colCustomerId.Name = "colCustomerId"
        Me.colCustomerId.OptionsColumn.ReadOnly = True
        '
        'colCustomerName
        '
        Me.colCustomerName.FieldName = "CustomerName"
        Me.colCustomerName.Name = "colCustomerName"
        Me.colCustomerName.Visible = True
        Me.colCustomerName.VisibleIndex = 0
        '
        'colContactPerson1
        '
        Me.colContactPerson1.FieldName = "ContactPerson"
        Me.colContactPerson1.Name = "colContactPerson1"
        '
        'colContactNo
        '
        Me.colContactNo.FieldName = "ContactNo"
        Me.colContactNo.Name = "colContactNo"
        '
        'colAdd1
        '
        Me.colAdd1.FieldName = "Add1"
        Me.colAdd1.Name = "colAdd1"
        '
        'colAdd2
        '
        Me.colAdd2.FieldName = "Add2"
        Me.colAdd2.Name = "colAdd2"
        '
        'colCity
        '
        Me.colCity.FieldName = "City"
        Me.colCity.Name = "colCity"
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1169, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CustomerListTableAdapter
        '
        Me.CustomerListTableAdapter.ClearBeforeFill = True
        '
        'frmDyeingProductionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 689)
        Me.Controls.Add(Me.CustomerIdGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ShowProductionCategoryButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BatchNoLookUpEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BuyerLookupGridLookUpEdit)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShowByBuyerButton)
        Me.Controls.Add(Me.ProgramShowButton)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmDyeingProductionReport"
        Me.Text = "Dyeing Production Report"
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadFFBBuyerListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadFFBBuyerListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchProgramNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatchProgramLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CustomerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents ShiftwiseRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ProductionCategoryRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FinishFabricOrderLookupDataSet As KSoft_Dyeing.FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricOrderLookupTableAdapter As KSoft_Dyeing.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
    Friend WithEvents ProgramShowButton As System.Windows.Forms.Button
    Friend WithEvents MachineRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShowByBuyerButton As System.Windows.Forms.Button
    Friend WithEvents BuyerLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerDataSet As KSoft_Dyeing.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Dyeing.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents LoadFFBBuyerListDataSet As KSoft_Dyeing.LoadFFBBuyerListDataSet
    Friend WithEvents LoadFFBBuyerListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadFFBBuyerListTableAdapter As KSoft_Dyeing.LoadFFBBuyerListDataSetTableAdapters.LoadFFBBuyerListTableAdapter
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BatchNoLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents colBatchNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BatchProgramLookupDataSet As BatchProgramLookupDataSet
    Friend WithEvents BatchProgramNoLookupBindingSource As BindingSource
    Friend WithEvents BatchProgramNoTableAdapter As BatchProgramLookupDataSetTableAdapters.BatchProgramNoTableAdapter
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ShowProductionCategoryButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents CustomerIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents CustomerIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCustomerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents CustomerListDataSet As CustomerListDataSet
    Friend WithEvents CustomerListBindingSource As BindingSource
    Friend WithEvents CustomerListTableAdapter As CustomerListDataSetTableAdapters.CustomerListTableAdapter
End Class
