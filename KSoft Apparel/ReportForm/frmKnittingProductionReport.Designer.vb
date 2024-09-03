<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnittingProductionReport
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
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.FinishFabricOrderLookupDataSet = New KSoft_Apparel.FinishFabricOrderLookupDataSet()
        Me.FinishFabricOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricOrderLookupTableAdapter = New KSoft_Apparel.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter()
        Me.ProgramShowButton = New System.Windows.Forms.Button()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.CustomerListDataSet = New KSoft_Apparel.CustomerListDataSet()
        Me.CustomerListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerListTableAdapter = New KSoft_Apparel.CustomerListDataSetTableAdapters.CustomerListTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BuyerLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowByBuyerButton = New System.Windows.Forms.Button()
        Me.CustomerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SampleRadioButton = New System.Windows.Forms.RadioButton()
        Me.BulkRadioButton = New System.Windows.Forms.RadioButton()
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter()
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet()
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet()
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter()
        Me.GSMCheckBox = New System.Windows.Forms.CheckBox()
        Me.DiaCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompositionCheckBox = New System.Windows.Forms.CheckBox()
        Me.FabricCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToGSMSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ToDiaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.DiaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.GSMSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CompositionGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colComposition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricTypeGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CompanyIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKnittingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.Button5 = New System.Windows.Forms.Button()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToGSMSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDiaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricTypeGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(706, 45)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(20, 13)
        Label5.TabIndex = 95
        Label5.Text = "To"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(706, 20)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(20, 13)
        Label6.TabIndex = 94
        Label6.Text = "To"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 104)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1298, 466)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Knitting Production Date :"
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(276, 22)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.FromDateTimePicker.TabIndex = 2
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(797, 16)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(183, 45)
        Me.ShowButton.TabIndex = 3
        Me.ShowButton.Text = "Show Production Details"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'FinishFabricOrderLookupDataSet
        '
        Me.FinishFabricOrderLookupDataSet.DataSetName = "FinishFabricOrderLookupDataSet"
        Me.FinishFabricOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishFabricOrderLookupBindingSource
        '
        Me.FinishFabricOrderLookupBindingSource.DataMember = "FinishFabricOrderLookup"
        Me.FinishFabricOrderLookupBindingSource.DataSource = Me.FinishFabricOrderLookupDataSet
        '
        'FinishFabricOrderLookupTableAdapter
        '
        Me.FinishFabricOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'ProgramShowButton
        '
        Me.ProgramShowButton.Location = New System.Drawing.Point(902, 72)
        Me.ProgramShowButton.Name = "ProgramShowButton"
        Me.ProgramShowButton.Size = New System.Drawing.Size(80, 23)
        Me.ProgramShowButton.TabIndex = 10
        Me.ProgramShowButton.Text = "&Show Details"
        Me.ProgramShowButton.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(557, 72)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.FinishFabricOrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = "[Type Program No]"
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "ProgramNo"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(234, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 9
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "To :"
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(276, 43)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.ToDateTimePicker.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(442, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Program_Style_Buyer :"
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'CustomerListDataSet
        '
        Me.CustomerListDataSet.DataSetName = "CustomerListDataSet"
        Me.CustomerListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerListBindingSource
        '
        Me.CustomerListBindingSource.DataMember = "CustomerList"
        Me.CustomerListBindingSource.DataSource = Me.CustomerListDataSet
        '
        'CustomerListTableAdapter
        '
        Me.CustomerListTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(988, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Buyer :"
        '
        'BuyerLookupGridLookUpEdit
        '
        Me.BuyerLookupGridLookUpEdit.EditValue = "[Type Buyer]"
        Me.BuyerLookupGridLookUpEdit.Location = New System.Drawing.Point(1066, 18)
        Me.BuyerLookupGridLookUpEdit.Name = "BuyerLookupGridLookUpEdit"
        Me.BuyerLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerLookupGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerLookupGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerLookupGridLookUpEdit.Properties.NullText = "[Type Buyer Name]"
        Me.BuyerLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerLookupGridLookUpEdit.Properties.ValueMember = "BuyerName"
        Me.BuyerLookupGridLookUpEdit.Properties.View = Me.GridView1
        Me.BuyerLookupGridLookUpEdit.Size = New System.Drawing.Size(160, 20)
        Me.BuyerLookupGridLookUpEdit.TabIndex = 16
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
        'ShowByBuyerButton
        '
        Me.ShowByBuyerButton.Location = New System.Drawing.Point(1235, 16)
        Me.ShowByBuyerButton.Name = "ShowByBuyerButton"
        Me.ShowByBuyerButton.Size = New System.Drawing.Size(64, 23)
        Me.ShowByBuyerButton.TabIndex = 15
        Me.ShowByBuyerButton.Text = "&Show"
        Me.ShowByBuyerButton.UseVisualStyleBackColor = True
        '
        'CustomerIdGridLookUpEdit
        '
        Me.CustomerIdGridLookUpEdit.Location = New System.Drawing.Point(1066, 46)
        Me.CustomerIdGridLookUpEdit.Name = "CustomerIdGridLookUpEdit"
        Me.CustomerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustomerIdGridLookUpEdit.Properties.DataSource = Me.CustomerListBindingSource
        Me.CustomerIdGridLookUpEdit.Properties.DisplayMember = "CustomerName"
        Me.CustomerIdGridLookUpEdit.Properties.NullText = ""
        Me.CustomerIdGridLookUpEdit.Properties.ValueMember = "CustomerId"
        Me.CustomerIdGridLookUpEdit.Properties.View = Me.CustomerIdGridLookUpEditView
        Me.CustomerIdGridLookUpEdit.Size = New System.Drawing.Size(160, 20)
        Me.CustomerIdGridLookUpEdit.TabIndex = 31
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
        Me.Button2.Location = New System.Drawing.Point(1235, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(986, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Customer :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SampleRadioButton)
        Me.GroupBox2.Controls.Add(Me.BulkRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(83, 88)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bulk/Sample"
        '
        'SampleRadioButton
        '
        Me.SampleRadioButton.AutoSize = True
        Me.SampleRadioButton.Location = New System.Drawing.Point(15, 56)
        Me.SampleRadioButton.Name = "SampleRadioButton"
        Me.SampleRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.SampleRadioButton.TabIndex = 1
        Me.SampleRadioButton.TabStop = True
        Me.SampleRadioButton.Text = "Sample"
        Me.SampleRadioButton.UseVisualStyleBackColor = True
        '
        'BulkRadioButton
        '
        Me.BulkRadioButton.AutoSize = True
        Me.BulkRadioButton.Checked = True
        Me.BulkRadioButton.Location = New System.Drawing.Point(15, 32)
        Me.BulkRadioButton.Name = "BulkRadioButton"
        Me.BulkRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.BulkRadioButton.TabIndex = 0
        Me.BulkRadioButton.TabStop = True
        Me.BulkRadioButton.Text = "Bulk"
        Me.BulkRadioButton.UseVisualStyleBackColor = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'CompositionBindingSource
        '
        Me.CompositionBindingSource.DataMember = "Composition"
        Me.CompositionBindingSource.DataSource = Me.CompositionDataSet
        '
        'CompositionDataSet
        '
        Me.CompositionDataSet.DataSetName = "CompositionDataSet"
        Me.CompositionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KnittingTypeDataSet
        '
        Me.KnittingTypeDataSet.DataSetName = "KnittingTypeDataSet"
        Me.KnittingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KnittingTypeBindingSource
        '
        Me.KnittingTypeBindingSource.DataMember = "KnittingType"
        Me.KnittingTypeBindingSource.DataSource = Me.KnittingTypeDataSet
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'GSMCheckBox
        '
        Me.GSMCheckBox.AutoSize = True
        Me.GSMCheckBox.Location = New System.Drawing.Point(557, 44)
        Me.GSMCheckBox.Name = "GSMCheckBox"
        Me.GSMCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.GSMCheckBox.TabIndex = 101
        Me.GSMCheckBox.Text = "GSM From :"
        Me.GSMCheckBox.UseVisualStyleBackColor = True
        '
        'DiaCheckBox
        '
        Me.DiaCheckBox.AutoSize = True
        Me.DiaCheckBox.Location = New System.Drawing.Point(557, 19)
        Me.DiaCheckBox.Name = "DiaCheckBox"
        Me.DiaCheckBox.Size = New System.Drawing.Size(74, 17)
        Me.DiaCheckBox.TabIndex = 100
        Me.DiaCheckBox.Text = "Dia From :"
        Me.DiaCheckBox.UseVisualStyleBackColor = True
        '
        'CompositionCheckBox
        '
        Me.CompositionCheckBox.AutoSize = True
        Me.CompositionCheckBox.Location = New System.Drawing.Point(371, 46)
        Me.CompositionCheckBox.Name = "CompositionCheckBox"
        Me.CompositionCheckBox.Size = New System.Drawing.Size(92, 17)
        Me.CompositionCheckBox.TabIndex = 99
        Me.CompositionCheckBox.Text = "Composition  :"
        Me.CompositionCheckBox.UseVisualStyleBackColor = True
        '
        'FabricCheckBox
        '
        Me.FabricCheckBox.AutoSize = True
        Me.FabricCheckBox.Location = New System.Drawing.Point(371, 21)
        Me.FabricCheckBox.Name = "FabricCheckBox"
        Me.FabricCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.FabricCheckBox.TabIndex = 98
        Me.FabricCheckBox.Text = "Fabric Type :"
        Me.FabricCheckBox.UseVisualStyleBackColor = True
        '
        'ToGSMSpinEdit
        '
        Me.ToGSMSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ToGSMSpinEdit.Location = New System.Drawing.Point(732, 42)
        Me.ToGSMSpinEdit.Name = "ToGSMSpinEdit"
        Me.ToGSMSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ToGSMSpinEdit.Size = New System.Drawing.Size(59, 20)
        Me.ToGSMSpinEdit.TabIndex = 97
        '
        'ToDiaSpinEdit
        '
        Me.ToDiaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ToDiaSpinEdit.Location = New System.Drawing.Point(732, 17)
        Me.ToDiaSpinEdit.Name = "ToDiaSpinEdit"
        Me.ToDiaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ToDiaSpinEdit.Size = New System.Drawing.Size(59, 20)
        Me.ToDiaSpinEdit.TabIndex = 96
        '
        'DiaSpinEdit
        '
        Me.DiaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DiaSpinEdit.Location = New System.Drawing.Point(641, 17)
        Me.DiaSpinEdit.Name = "DiaSpinEdit"
        Me.DiaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DiaSpinEdit.Size = New System.Drawing.Size(59, 20)
        Me.DiaSpinEdit.TabIndex = 93
        '
        'GSMSpinEdit
        '
        Me.GSMSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.GSMSpinEdit.Location = New System.Drawing.Point(641, 42)
        Me.GSMSpinEdit.Name = "GSMSpinEdit"
        Me.GSMSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GSMSpinEdit.Size = New System.Drawing.Size(59, 20)
        Me.GSMSpinEdit.TabIndex = 92
        '
        'CompositionGridLookUpEdit
        '
        Me.CompositionGridLookUpEdit.Location = New System.Drawing.Point(465, 44)
        Me.CompositionGridLookUpEdit.Name = "CompositionGridLookUpEdit"
        Me.CompositionGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompositionGridLookUpEdit.Properties.DataSource = Me.CompositionBindingSource
        Me.CompositionGridLookUpEdit.Properties.DisplayMember = "Composition"
        Me.CompositionGridLookUpEdit.Properties.ImmediatePopup = True
        Me.CompositionGridLookUpEdit.Properties.NullText = ""
        Me.CompositionGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CompositionGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CompositionGridLookUpEdit.Properties.ValueMember = "CompositionId"
        Me.CompositionGridLookUpEdit.Properties.View = Me.GridView2
        Me.CompositionGridLookUpEdit.Size = New System.Drawing.Size(86, 20)
        Me.CompositionGridLookUpEdit.TabIndex = 91
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colComposition})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colComposition
        '
        Me.colComposition.FieldName = "Composition"
        Me.colComposition.Name = "colComposition"
        Me.colComposition.Visible = True
        Me.colComposition.VisibleIndex = 0
        '
        'FabricTypeGridLookUpEdit
        '
        Me.FabricTypeGridLookUpEdit.Location = New System.Drawing.Point(465, 19)
        Me.FabricTypeGridLookUpEdit.Name = "FabricTypeGridLookUpEdit"
        Me.FabricTypeGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricTypeGridLookUpEdit.Properties.DataSource = Me.KnittingTypeBindingSource
        Me.FabricTypeGridLookUpEdit.Properties.DisplayMember = "KnittingType"
        Me.FabricTypeGridLookUpEdit.Properties.ImmediatePopup = True
        Me.FabricTypeGridLookUpEdit.Properties.NullText = ""
        Me.FabricTypeGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FabricTypeGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricTypeGridLookUpEdit.Properties.ValueMember = "KnittingTypeId"
        Me.FabricTypeGridLookUpEdit.Properties.View = Me.CompanyIdGridLookUpEditView
        Me.FabricTypeGridLookUpEdit.Size = New System.Drawing.Size(86, 20)
        Me.FabricTypeGridLookUpEdit.TabIndex = 90
        '
        'CompanyIdGridLookUpEditView
        '
        Me.CompanyIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingType})
        Me.CompanyIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CompanyIdGridLookUpEditView.Name = "CompanyIdGridLookUpEditView"
        Me.CompanyIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CompanyIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colKnittingType
        '
        Me.colKnittingType.FieldName = "KnittingType"
        Me.colKnittingType.Name = "colKnittingType"
        Me.colKnittingType.Visible = True
        Me.colKnittingType.VisibleIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(237, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "From :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 89)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "Show Production Summery [Running All]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(986, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Supplier :"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(1066, 75)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.SupplierBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "SupplierName"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.ValueMember = "SupplierId"
        Me.GridLookUpEdit1.Properties.View = Me.GridView3
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(160, 20)
        Me.GridLookUpEdit1.TabIndex = 105
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.EnforceConstraints = False
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierCode, Me.colSupplierName})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 0
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1235, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 23)
        Me.Button3.TabIndex = 106
        Me.Button3.Text = "&Show"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(237, 69)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(199, 23)
        Me.Button4.TabIndex = 107
        Me.Button4.Text = "Show Knitting Closing Report"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(797, 72)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 23)
        Me.Button5.TabIndex = 108
        Me.Button5.Text = "&Show"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmKnittingProductionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 570)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GSMCheckBox)
        Me.Controls.Add(Me.DiaCheckBox)
        Me.Controls.Add(Me.CompositionCheckBox)
        Me.Controls.Add(Me.FabricCheckBox)
        Me.Controls.Add(Me.ToGSMSpinEdit)
        Me.Controls.Add(Me.ToDiaSpinEdit)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.DiaSpinEdit)
        Me.Controls.Add(Me.GSMSpinEdit)
        Me.Controls.Add(Me.CompositionGridLookUpEdit)
        Me.Controls.Add(Me.FabricTypeGridLookUpEdit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CustomerIdGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BuyerLookupGridLookUpEdit)
        Me.Controls.Add(Me.ShowByBuyerButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgramShowButton)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmKnittingProductionReport"
        Me.Text = "Knitting Production Report"
        CType(Me.FinishFabricOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToGSMSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDiaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricTypeGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents FinishFabricOrderLookupDataSet As KSoft_Apparel.FinishFabricOrderLookupDataSet
    Friend WithEvents FinishFabricOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricOrderLookupTableAdapter As KSoft_Apparel.FinishFabricOrderLookupDataSetTableAdapters.FinishFabricOrderLookupTableAdapter
    Friend WithEvents ProgramShowButton As System.Windows.Forms.Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents CustomerListDataSet As CustomerListDataSet
    Friend WithEvents CustomerListBindingSource As BindingSource
    Friend WithEvents CustomerListTableAdapter As CustomerListDataSetTableAdapters.CustomerListTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents BuyerLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowByBuyerButton As Button
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
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SampleRadioButton As RadioButton
    Friend WithEvents BulkRadioButton As RadioButton
    Friend WithEvents CompositionTableAdapter As CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents CompositionBindingSource As BindingSource
    Friend WithEvents CompositionDataSet As CompositionDataSet
    Friend WithEvents KnittingTypeDataSet As KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents GSMCheckBox As CheckBox
    Friend WithEvents DiaCheckBox As CheckBox
    Friend WithEvents CompositionCheckBox As CheckBox
    Friend WithEvents FabricCheckBox As CheckBox
    Friend WithEvents ToGSMSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ToDiaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DiaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GSMSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CompositionGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colComposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricTypeGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents CompanyIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button5 As Button
End Class
