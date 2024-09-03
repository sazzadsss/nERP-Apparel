<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmbroideryOrder
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
        Dim EMBOrderNoLabel As System.Windows.Forms.Label
        Dim EMBOrderDateLabel As System.Windows.Forms.Label
        Dim EMBDeliveryDateLabel As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim FromNameLabel As System.Windows.Forms.Label
        Dim FromContactNoLabel As System.Windows.Forms.Label
        Dim ToNameLabel As System.Windows.Forms.Label
        Dim ToContactNoLabel As System.Windows.Forms.Label
        Dim FromDesignationLabel As System.Windows.Forms.Label
        Dim ToDesignationLabel As System.Windows.Forms.Label
        Dim StyleNoLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim BuyerLabel As System.Windows.Forms.Label
        Me.SizeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataSet = New KSoft_Apparel.SizeDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BuyerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmbOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbOrderDataSet = New KSoft_Apparel.EmbOrderDataSet()
        Me.StyleNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GetPrgNoButton = New System.Windows.Forms.Button()
        Me.ProgramNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ProgramNoLookupEmbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgramLookupEmbDataSet = New KSoft_Apparel.ProgramLookupEmbDataSet()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EMBDeliveryDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.EMBOrderDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.EMBOrderNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmbTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GetSizeButton = New System.Windows.Forms.Button()
        Me.GetColorButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintPartComboBox = New System.Windows.Forms.ComboBox()
        Me.PrintPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintPartDataSet = New KSoft_Apparel.PrintPartDataSet()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EmbOrderDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.EmbOrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmbOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintPartId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintPartGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPartName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvgDesignStitch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmbType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colPricePerDzn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EmbOrderSizeDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.EmbOrderSizeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmbOrderQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PasteButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.EmbroideryRemarksGridControl = New DevExpress.XtraGrid.GridControl()
        Me.EmbroideryRemarksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmbOrderTableAdapter = New KSoft_Apparel.EmbOrderDataSetTableAdapters.EmbOrderTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.EmbOrderDataSetTableAdapters.TableAdapterManager()
        Me.EmbOrderDetailsTableAdapter = New KSoft_Apparel.EmbOrderDataSetTableAdapters.EmbOrderDetailsTableAdapter()
        Me.EmbOrderSizeDetailsTableAdapter = New KSoft_Apparel.EmbOrderDataSetTableAdapters.EmbOrderSizeDetailsTableAdapter()
        Me.EmbroideryRemarksTableAdapter = New KSoft_Apparel.EmbOrderDataSetTableAdapters.EmbroideryRemarksTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.ProgramNoLookupEmbTableAdapter = New KSoft_Apparel.ProgramLookupEmbDataSetTableAdapters.ProgramNoLookupEmbTableAdapter()
        Me.SizeTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter()
        Me.PrintPartTableAdapter = New KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter()
        Me.EmbOrderLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.EmbOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbOrderLookupDataSet = New KSoft_Apparel.EmbOrderLookupDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmbOrderLookupTableAdapter = New KSoft_Apparel.EmbOrderLookupDataSetTableAdapters.EmbOrderLookupTableAdapter()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EmbroideryRemarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToDesignationTextBox = New System.Windows.Forms.TextBox()
        Me.FromDesignationTextBox = New System.Windows.Forms.TextBox()
        Me.ToContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.ToNameTextBox = New System.Windows.Forms.TextBox()
        Me.FromContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.FromNameTextBox = New System.Windows.Forms.TextBox()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        EMBOrderNoLabel = New System.Windows.Forms.Label()
        EMBOrderDateLabel = New System.Windows.Forms.Label()
        EMBDeliveryDateLabel = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        UnitPriceLabel = New System.Windows.Forms.Label()
        FromNameLabel = New System.Windows.Forms.Label()
        FromContactNoLabel = New System.Windows.Forms.Label()
        ToNameLabel = New System.Windows.Forms.Label()
        ToContactNoLabel = New System.Windows.Forms.Label()
        FromDesignationLabel = New System.Windows.Forms.Label()
        ToDesignationLabel = New System.Windows.Forms.Label()
        StyleNoLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        BuyerLabel = New System.Windows.Forms.Label()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BuyerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoLookupEmbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramLookupEmbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMBDeliveryDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMBDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMBOrderDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMBOrderDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMBOrderNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EmbOrderDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EmbOrderSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbroideryRemarksGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbroideryRemarksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbOrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbroideryRemarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EMBOrderNoLabel
        '
        EMBOrderNoLabel.AutoSize = True
        EMBOrderNoLabel.Location = New System.Drawing.Point(20, 37)
        EMBOrderNoLabel.Name = "EMBOrderNoLabel"
        EMBOrderNoLabel.Size = New System.Drawing.Size(79, 13)
        EMBOrderNoLabel.TabIndex = 0
        EMBOrderNoLabel.Text = "EMB Order No:"
        '
        'EMBOrderDateLabel
        '
        EMBOrderDateLabel.AutoSize = True
        EMBOrderDateLabel.Location = New System.Drawing.Point(20, 63)
        EMBOrderDateLabel.Name = "EMBOrderDateLabel"
        EMBOrderDateLabel.Size = New System.Drawing.Size(88, 13)
        EMBOrderDateLabel.TabIndex = 2
        EMBOrderDateLabel.Text = "EMB Order Date:"
        '
        'EMBDeliveryDateLabel
        '
        EMBDeliveryDateLabel.AutoSize = True
        EMBDeliveryDateLabel.Location = New System.Drawing.Point(20, 89)
        EMBDeliveryDateLabel.Name = "EMBDeliveryDateLabel"
        EMBDeliveryDateLabel.Size = New System.Drawing.Size(100, 13)
        EMBDeliveryDateLabel.TabIndex = 4
        EMBDeliveryDateLabel.Text = "EMB Delivery Date:"
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(22, 152)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(48, 13)
        SupplierIdLabel.TabIndex = 6
        SupplierIdLabel.Text = "Supplier:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(22, 283)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 12
        RemarksLabel.Text = "Remarks:"
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(20, 112)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(112, 13)
        UnitPriceLabel.TabIndex = 15
        UnitPriceLabel.Text = "Unit Price ($) Per Dzn:"
        '
        'FromNameLabel
        '
        FromNameLabel.AutoSize = True
        FromNameLabel.Location = New System.Drawing.Point(14, 43)
        FromNameLabel.Name = "FromNameLabel"
        FromNameLabel.Size = New System.Drawing.Size(64, 13)
        FromNameLabel.TabIndex = 0
        FromNameLabel.Text = "From Name:"
        '
        'FromContactNoLabel
        '
        FromContactNoLabel.AutoSize = True
        FromContactNoLabel.Location = New System.Drawing.Point(14, 69)
        FromContactNoLabel.Name = "FromContactNoLabel"
        FromContactNoLabel.Size = New System.Drawing.Size(90, 13)
        FromContactNoLabel.TabIndex = 2
        FromContactNoLabel.Text = "From Contact No:"
        '
        'ToNameLabel
        '
        ToNameLabel.AutoSize = True
        ToNameLabel.Location = New System.Drawing.Point(14, 135)
        ToNameLabel.Name = "ToNameLabel"
        ToNameLabel.Size = New System.Drawing.Size(54, 13)
        ToNameLabel.TabIndex = 4
        ToNameLabel.Text = "To Name:"
        '
        'ToContactNoLabel
        '
        ToContactNoLabel.AutoSize = True
        ToContactNoLabel.Location = New System.Drawing.Point(14, 161)
        ToContactNoLabel.Name = "ToContactNoLabel"
        ToContactNoLabel.Size = New System.Drawing.Size(80, 13)
        ToContactNoLabel.TabIndex = 6
        ToContactNoLabel.Text = "To Contact No:"
        '
        'FromDesignationLabel
        '
        FromDesignationLabel.AutoSize = True
        FromDesignationLabel.Location = New System.Drawing.Point(16, 94)
        FromDesignationLabel.Name = "FromDesignationLabel"
        FromDesignationLabel.Size = New System.Drawing.Size(92, 13)
        FromDesignationLabel.TabIndex = 8
        FromDesignationLabel.Text = "From Designation:"
        '
        'ToDesignationLabel
        '
        ToDesignationLabel.AutoSize = True
        ToDesignationLabel.Location = New System.Drawing.Point(14, 187)
        ToDesignationLabel.Name = "ToDesignationLabel"
        ToDesignationLabel.Size = New System.Drawing.Size(82, 13)
        ToDesignationLabel.TabIndex = 10
        ToDesignationLabel.Text = "To Designation:"
        '
        'StyleNoLabel
        '
        StyleNoLabel.AutoSize = True
        StyleNoLabel.Location = New System.Drawing.Point(22, 228)
        StyleNoLabel.Name = "StyleNoLabel"
        StyleNoLabel.Size = New System.Drawing.Size(50, 13)
        StyleNoLabel.TabIndex = 19
        StyleNoLabel.Text = "Style No:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(22, 204)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(94, 13)
        Label3.TabIndex = 21
        Label3.Text = "Program No (ALL):"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(22, 182)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(86, 13)
        Label4.TabIndex = 22
        Label4.Text = "Program No (IH):"
        '
        'BuyerLabel
        '
        BuyerLabel.AutoSize = True
        BuyerLabel.Location = New System.Drawing.Point(22, 249)
        BuyerLabel.Name = "BuyerLabel"
        BuyerLabel.Size = New System.Drawing.Size(37, 13)
        BuyerLabel.TabIndex = 22
        BuyerLabel.Text = "Buyer:"
        '
        'SizeGridLookUpEdit
        '
        Me.SizeGridLookUpEdit.AutoHeight = False
        Me.SizeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeGridLookUpEdit.DataSource = Me.SizeBindingSource
        Me.SizeGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeGridLookUpEdit.Name = "SizeGridLookUpEdit"
        Me.SizeGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SizeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SizeGridLookUpEdit.ValueMember = "SizeId"
        '
        'SizeBindingSource
        '
        Me.SizeBindingSource.DataMember = "Size"
        Me.SizeBindingSource.DataSource = Me.SizeDataSet
        '
        'SizeDataSet
        '
        Me.SizeDataSet.DataSetName = "SizeDataSet"
        Me.SizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(BuyerLabel)
        Me.GroupBox2.Controls.Add(Me.BuyerTextEdit)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(StyleNoLabel)
        Me.GroupBox2.Controls.Add(Me.StyleNoTextEdit)
        Me.GroupBox2.Controls.Add(Me.GetPrgNoButton)
        Me.GroupBox2.Controls.Add(Me.ProgramNoTextEdit)
        Me.GroupBox2.Controls.Add(UnitPriceLabel)
        Me.GroupBox2.Controls.Add(Me.UnitPriceSpinEdit)
        Me.GroupBox2.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.GroupBox2.Controls.Add(Me.GridLookUpEdit1)
        Me.GroupBox2.Controls.Add(RemarksLabel)
        Me.GroupBox2.Controls.Add(Me.RemarksTextEdit)
        Me.GroupBox2.Controls.Add(SupplierIdLabel)
        Me.GroupBox2.Controls.Add(EMBDeliveryDateLabel)
        Me.GroupBox2.Controls.Add(Me.EMBDeliveryDateDateEdit)
        Me.GroupBox2.Controls.Add(EMBOrderDateLabel)
        Me.GroupBox2.Controls.Add(Me.EMBOrderDateDateEdit)
        Me.GroupBox2.Controls.Add(EMBOrderNoLabel)
        Me.GroupBox2.Controls.Add(Me.EMBOrderNoTextEdit)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 328)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Main Information"
        '
        'BuyerTextEdit
        '
        Me.BuyerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmbOrderBindingSource, "Buyer", True))
        Me.BuyerTextEdit.Location = New System.Drawing.Point(135, 246)
        Me.BuyerTextEdit.Name = "BuyerTextEdit"
        Me.BuyerTextEdit.Size = New System.Drawing.Size(206, 20)
        Me.BuyerTextEdit.TabIndex = 23
        '
        'EmbOrderBindingSource
        '
        Me.EmbOrderBindingSource.DataMember = "EmbOrder"
        Me.EmbOrderBindingSource.DataSource = Me.EmbOrderDataSet
        '
        'EmbOrderDataSet
        '
        Me.EmbOrderDataSet.DataSetName = "EmbOrderDataSet"
        Me.EmbOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleNoTextEdit
        '
        Me.StyleNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmbOrderBindingSource, "StyleNo", True))
        Me.StyleNoTextEdit.Location = New System.Drawing.Point(135, 223)
        Me.StyleNoTextEdit.Name = "StyleNoTextEdit"
        Me.StyleNoTextEdit.Size = New System.Drawing.Size(206, 20)
        Me.StyleNoTextEdit.TabIndex = 20
        '
        'GetPrgNoButton
        '
        Me.GetPrgNoButton.Location = New System.Drawing.Point(347, 199)
        Me.GetPrgNoButton.Name = "GetPrgNoButton"
        Me.GetPrgNoButton.Size = New System.Drawing.Size(45, 67)
        Me.GetPrgNoButton.TabIndex = 19
        Me.GetPrgNoButton.Text = "Get"
        Me.GetPrgNoButton.UseVisualStyleBackColor = True
        '
        'ProgramNoTextEdit
        '
        Me.ProgramNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmbOrderBindingSource, "ProgramNo", True))
        Me.ProgramNoTextEdit.Location = New System.Drawing.Point(135, 199)
        Me.ProgramNoTextEdit.Name = "ProgramNoTextEdit"
        Me.ProgramNoTextEdit.Size = New System.Drawing.Size(205, 20)
        Me.ProgramNoTextEdit.TabIndex = 18
        '
        'UnitPriceSpinEdit
        '
        Me.UnitPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmbOrderBindingSource, "UnitPrice", True))
        Me.UnitPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UnitPriceSpinEdit.Location = New System.Drawing.Point(135, 108)
        Me.UnitPriceSpinEdit.Name = "UnitPriceSpinEdit"
        Me.UnitPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UnitPriceSpinEdit.Size = New System.Drawing.Size(118, 20)
        Me.UnitPriceSpinEdit.TabIndex = 16
        '
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmbOrderBindingSource, "OrderId", True))
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(135, 175)
        Me.OrderIdGridLookUpEdit.Name = "OrderIdGridLookUpEdit"
        Me.OrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderIdGridLookUpEdit.Properties.DataSource = Me.ProgramNoLookupEmbBindingSource
        Me.OrderIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.OrderIdGridLookUpEdit.Properties.NullText = ""
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderIdGridLookUpEdit.Properties.View = Me.GridLookUpEdit2View
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(257, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 15
        '
        'ProgramNoLookupEmbBindingSource
        '
        Me.ProgramNoLookupEmbBindingSource.DataMember = "ProgramNoLookupEmb"
        Me.ProgramNoLookupEmbBindingSource.DataSource = Me.ProgramLookupEmbDataSet
        '
        'ProgramLookupEmbDataSet
        '
        Me.ProgramLookupEmbDataSet.DataSetName = "ProgramLookupEmbDataSet"
        Me.ProgramLookupEmbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmbOrderBindingSource, "SupplierId", True))
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(135, 149)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.SupplierBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "SupplierName"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.ValueMember = "SupplierId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(257, 20)
        Me.GridLookUpEdit1.TabIndex = 14
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
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierCode, Me.colSupplierName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmbOrderBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(135, 276)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(257, 20)
        Me.RemarksTextEdit.TabIndex = 13
        '
        'EMBDeliveryDateDateEdit
        '
        Me.EMBDeliveryDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmbOrderBindingSource, "EMBDeliveryDate", True))
        Me.EMBDeliveryDateDateEdit.EditValue = Nothing
        Me.EMBDeliveryDateDateEdit.Location = New System.Drawing.Point(135, 83)
        Me.EMBDeliveryDateDateEdit.Name = "EMBDeliveryDateDateEdit"
        Me.EMBDeliveryDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EMBDeliveryDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EMBDeliveryDateDateEdit.Size = New System.Drawing.Size(118, 20)
        Me.EMBDeliveryDateDateEdit.TabIndex = 5
        '
        'EMBOrderDateDateEdit
        '
        Me.EMBOrderDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmbOrderBindingSource, "EMBOrderDate", True))
        Me.EMBOrderDateDateEdit.EditValue = Nothing
        Me.EMBOrderDateDateEdit.Location = New System.Drawing.Point(135, 57)
        Me.EMBOrderDateDateEdit.Name = "EMBOrderDateDateEdit"
        Me.EMBOrderDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EMBOrderDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EMBOrderDateDateEdit.Size = New System.Drawing.Size(118, 20)
        Me.EMBOrderDateDateEdit.TabIndex = 3
        '
        'EMBOrderNoTextEdit
        '
        Me.EMBOrderNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EmbOrderBindingSource, "EMBOrderNo", True))
        Me.EMBOrderNoTextEdit.Location = New System.Drawing.Point(135, 31)
        Me.EMBOrderNoTextEdit.Name = "EMBOrderNoTextEdit"
        Me.EMBOrderNoTextEdit.Size = New System.Drawing.Size(118, 20)
        Me.EMBOrderNoTextEdit.TabIndex = 1
        '
        'EmbTypeComboBox
        '
        Me.EmbTypeComboBox.FormattingEnabled = True
        Me.EmbTypeComboBox.Items.AddRange(New Object() {"Normal", "Aplique", "Sequins", "Chanail", "Taping", "Kotting"})
        Me.EmbTypeComboBox.Location = New System.Drawing.Point(253, 5)
        Me.EmbTypeComboBox.Name = "EmbTypeComboBox"
        Me.EmbTypeComboBox.Size = New System.Drawing.Size(108, 21)
        Me.EmbTypeComboBox.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Emb  Type"
        '
        'GetSizeButton
        '
        Me.GetSizeButton.Location = New System.Drawing.Point(460, 4)
        Me.GetSizeButton.Name = "GetSizeButton"
        Me.GetSizeButton.Size = New System.Drawing.Size(75, 23)
        Me.GetSizeButton.TabIndex = 19
        Me.GetSizeButton.Text = "Get Size"
        Me.GetSizeButton.UseVisualStyleBackColor = True
        '
        'GetColorButton
        '
        Me.GetColorButton.Location = New System.Drawing.Point(367, 4)
        Me.GetColorButton.Name = "GetColorButton"
        Me.GetColorButton.Size = New System.Drawing.Size(87, 23)
        Me.GetColorButton.TabIndex = 18
        Me.GetColorButton.Text = "Get Color"
        Me.GetColorButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Emb Part"
        '
        'PrintPartComboBox
        '
        Me.PrintPartComboBox.DataSource = Me.PrintPartBindingSource
        Me.PrintPartComboBox.DisplayMember = "PartName"
        Me.PrintPartComboBox.FormattingEnabled = True
        Me.PrintPartComboBox.Location = New System.Drawing.Point(71, 5)
        Me.PrintPartComboBox.Name = "PrintPartComboBox"
        Me.PrintPartComboBox.Size = New System.Drawing.Size(108, 21)
        Me.PrintPartComboBox.TabIndex = 16
        Me.PrintPartComboBox.ValueMember = "PrintPartId"
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
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(442, 47)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.GetSizeButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.EmbTypeComboBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GetColorButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.EmbOrderDetailsGridControl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PrintPartComboBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(828, 666)
        Me.SplitContainer2.SplitterDistance = 324
        Me.SplitContainer2.TabIndex = 0
        '
        'EmbOrderDetailsGridControl
        '
        Me.EmbOrderDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmbOrderDetailsGridControl.DataSource = Me.EmbOrderDetailsBindingSource
        Me.EmbOrderDetailsGridControl.Location = New System.Drawing.Point(3, 33)
        Me.EmbOrderDetailsGridControl.MainView = Me.GridView1
        Me.EmbOrderDetailsGridControl.Name = "EmbOrderDetailsGridControl"
        Me.EmbOrderDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.PrintPartGridLookUpEdit, Me.FabricColorGridLookUpEdit, Me.RepositoryItemComboBox1})
        Me.EmbOrderDetailsGridControl.Size = New System.Drawing.Size(822, 288)
        Me.EmbOrderDetailsGridControl.TabIndex = 0
        Me.EmbOrderDetailsGridControl.UseEmbeddedNavigator = True
        Me.EmbOrderDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'EmbOrderDetailsBindingSource
        '
        Me.EmbOrderDetailsBindingSource.DataMember = "FK_EmbOrderDetails_EmbOrder"
        Me.EmbOrderDetailsBindingSource.DataSource = Me.EmbOrderBindingSource
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorId, Me.colEmbOrderQuantity, Me.colRemarks, Me.colPrintPartId, Me.colAvgDesignStitch, Me.colEmbType, Me.colPricePerDzn})
        Me.GridView1.GridControl = Me.EmbOrderDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorId
        '
        Me.colFabricColorId.Caption = "Color"
        Me.colFabricColorId.ColumnEdit = Me.FabricColorGridLookUpEdit
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 2
        Me.colFabricColorId.Width = 118
        '
        'FabricColorGridLookUpEdit
        '
        Me.FabricColorGridLookUpEdit.AutoHeight = False
        Me.FabricColorGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricColorGridLookUpEdit.DataSource = Me.FabricColorBindingSource
        Me.FabricColorGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.FabricColorGridLookUpEdit.Name = "FabricColorGridLookUpEdit"
        Me.FabricColorGridLookUpEdit.NullText = ""
        Me.FabricColorGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricColorGridLookUpEdit.ValueMember = "FabricColorId"
        Me.FabricColorGridLookUpEdit.View = Me.GridView6
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
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName1})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName1
        '
        Me.colFabricColorName1.FieldName = "FabricColorName"
        Me.colFabricColorName1.Name = "colFabricColorName1"
        Me.colFabricColorName1.Visible = True
        Me.colFabricColorName1.VisibleIndex = 0
        '
        'colEmbOrderQuantity
        '
        Me.colEmbOrderQuantity.Caption = "Quantity"
        Me.colEmbOrderQuantity.FieldName = "EmbOrderQuantity"
        Me.colEmbOrderQuantity.Name = "colEmbOrderQuantity"
        Me.colEmbOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colEmbOrderQuantity.Visible = True
        Me.colEmbOrderQuantity.VisibleIndex = 4
        Me.colEmbOrderQuantity.Width = 74
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 6
        Me.colRemarks.Width = 326
        '
        'colPrintPartId
        '
        Me.colPrintPartId.Caption = "Print Part"
        Me.colPrintPartId.ColumnEdit = Me.PrintPartGridLookUpEdit
        Me.colPrintPartId.FieldName = "PrintPartId"
        Me.colPrintPartId.Name = "colPrintPartId"
        Me.colPrintPartId.Visible = True
        Me.colPrintPartId.VisibleIndex = 0
        Me.colPrintPartId.Width = 67
        '
        'PrintPartGridLookUpEdit
        '
        Me.PrintPartGridLookUpEdit.AutoHeight = False
        Me.PrintPartGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintPartGridLookUpEdit.DataSource = Me.PrintPartBindingSource
        Me.PrintPartGridLookUpEdit.DisplayMember = "PartName"
        Me.PrintPartGridLookUpEdit.Name = "PrintPartGridLookUpEdit"
        Me.PrintPartGridLookUpEdit.NullText = ""
        Me.PrintPartGridLookUpEdit.ValueMember = "PrintPartId"
        Me.PrintPartGridLookUpEdit.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPartName1})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colPartName1
        '
        Me.colPartName1.FieldName = "PartName"
        Me.colPartName1.Name = "colPartName1"
        Me.colPartName1.Visible = True
        Me.colPartName1.VisibleIndex = 0
        '
        'colAvgDesignStitch
        '
        Me.colAvgDesignStitch.FieldName = "AvgDesignStitch"
        Me.colAvgDesignStitch.Name = "colAvgDesignStitch"
        Me.colAvgDesignStitch.Visible = True
        Me.colAvgDesignStitch.VisibleIndex = 5
        Me.colAvgDesignStitch.Width = 95
        '
        'colEmbType
        '
        Me.colEmbType.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colEmbType.FieldName = "EmbType"
        Me.colEmbType.Name = "colEmbType"
        Me.colEmbType.Visible = True
        Me.colEmbType.VisibleIndex = 1
        Me.colEmbType.Width = 62
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Normal", "Aplique", "Sequins", "Chanail", "Taping", "Kotting"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colPricePerDzn
        '
        Me.colPricePerDzn.FieldName = "PricePerDzn"
        Me.colPricePerDzn.Name = "colPricePerDzn"
        Me.colPricePerDzn.Visible = True
        Me.colPricePerDzn.VisibleIndex = 3
        Me.colPricePerDzn.Width = 62
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.EmbOrderDetailsGridControl
        Me.GridView2.Name = "GridView2"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EmbOrderSizeDetailsGridControl)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PasteButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CopyButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EmbroideryRemarksGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(828, 338)
        Me.SplitContainer1.SplitterDistance = 408
        Me.SplitContainer1.TabIndex = 3
        '
        'EmbOrderSizeDetailsGridControl
        '
        Me.EmbOrderSizeDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmbOrderSizeDetailsGridControl.DataSource = Me.EmbOrderSizeDetailsBindingSource
        Me.EmbOrderSizeDetailsGridControl.Location = New System.Drawing.Point(3, 38)
        Me.EmbOrderSizeDetailsGridControl.MainView = Me.GridView3
        Me.EmbOrderSizeDetailsGridControl.Name = "EmbOrderSizeDetailsGridControl"
        Me.EmbOrderSizeDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeLookupGridLookUpEdit})
        Me.EmbOrderSizeDetailsGridControl.Size = New System.Drawing.Size(403, 297)
        Me.EmbOrderSizeDetailsGridControl.TabIndex = 0
        Me.EmbOrderSizeDetailsGridControl.UseEmbeddedNavigator = True
        Me.EmbOrderSizeDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'EmbOrderSizeDetailsBindingSource
        '
        Me.EmbOrderSizeDetailsBindingSource.DataMember = "FK_EmbOrderSizeDetails_EmbOrderDetails"
        Me.EmbOrderSizeDetailsBindingSource.DataSource = Me.EmbOrderDetailsBindingSource
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeId, Me.colEmbOrderQuantity1})
        Me.GridView3.GridControl = Me.EmbOrderSizeDetailsGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colSizeId
        '
        Me.colSizeId.Caption = "Size"
        Me.colSizeId.ColumnEdit = Me.SizeLookupGridLookUpEdit
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        Me.colSizeId.Visible = True
        Me.colSizeId.VisibleIndex = 0
        Me.colSizeId.Width = 146
        '
        'SizeLookupGridLookUpEdit
        '
        Me.SizeLookupGridLookUpEdit.AutoHeight = False
        Me.SizeLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeLookupGridLookUpEdit.DataSource = Me.SizeBindingSource
        Me.SizeLookupGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeLookupGridLookUpEdit.Name = "SizeLookupGridLookUpEdit"
        Me.SizeLookupGridLookUpEdit.NullText = ""
        Me.SizeLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SizeLookupGridLookUpEdit.ValueMember = "SizeId"
        Me.SizeLookupGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colEmbOrderQuantity1
        '
        Me.colEmbOrderQuantity1.FieldName = "EmbOrderQuantity"
        Me.colEmbOrderQuantity1.Name = "colEmbOrderQuantity1"
        Me.colEmbOrderQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colEmbOrderQuantity1.Visible = True
        Me.colEmbOrderQuantity1.VisibleIndex = 1
        Me.colEmbOrderQuantity1.Width = 199
        '
        'PasteButton
        '
        Me.PasteButton.Location = New System.Drawing.Point(342, 7)
        Me.PasteButton.Name = "PasteButton"
        Me.PasteButton.Size = New System.Drawing.Size(63, 23)
        Me.PasteButton.TabIndex = 2
        Me.PasteButton.Text = "Paste"
        Me.PasteButton.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(279, 7)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(59, 23)
        Me.CopyButton.TabIndex = 1
        Me.CopyButton.Text = "Copy"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'EmbroideryRemarksGridControl
        '
        Me.EmbroideryRemarksGridControl.DataSource = Me.EmbroideryRemarksBindingSource1
        Me.EmbroideryRemarksGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmbroideryRemarksGridControl.Location = New System.Drawing.Point(0, 0)
        Me.EmbroideryRemarksGridControl.MainView = Me.GridView7
        Me.EmbroideryRemarksGridControl.Name = "EmbroideryRemarksGridControl"
        Me.EmbroideryRemarksGridControl.Size = New System.Drawing.Size(416, 338)
        Me.EmbroideryRemarksGridControl.TabIndex = 21
        Me.EmbroideryRemarksGridControl.UseEmbeddedNavigator = True
        Me.EmbroideryRemarksGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'EmbroideryRemarksBindingSource1
        '
        Me.EmbroideryRemarksBindingSource1.DataMember = "FK_EmbroideryRemarks_EmbOrder"
        Me.EmbroideryRemarksBindingSource1.DataSource = Me.EmbOrderBindingSource
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRemarks1})
        Me.GridView7.GridControl = Me.EmbroideryRemarksGridControl
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colRemarks1
        '
        Me.colRemarks1.Caption = "Terms And Conditions"
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 0
        '
        'EmbOrderTableAdapter
        '
        Me.EmbOrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmbOrderDetailsTableAdapter = Me.EmbOrderDetailsTableAdapter
        Me.TableAdapterManager.EmbOrderSizeDetailsTableAdapter = Me.EmbOrderSizeDetailsTableAdapter
        Me.TableAdapterManager.EmbOrderTableAdapter = Me.EmbOrderTableAdapter
        Me.TableAdapterManager.EmbroideryRemarksTableAdapter = Me.EmbroideryRemarksTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.EmbOrderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmbOrderDetailsTableAdapter
        '
        Me.EmbOrderDetailsTableAdapter.ClearBeforeFill = True
        '
        'EmbOrderSizeDetailsTableAdapter
        '
        Me.EmbOrderSizeDetailsTableAdapter.ClearBeforeFill = True
        '
        'EmbroideryRemarksTableAdapter
        '
        Me.EmbroideryRemarksTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'ProgramNoLookupEmbTableAdapter
        '
        Me.ProgramNoLookupEmbTableAdapter.ClearBeforeFill = True
        '
        'SizeTableAdapter
        '
        Me.SizeTableAdapter.ClearBeforeFill = True
        '
        'PrintPartTableAdapter
        '
        Me.PrintPartTableAdapter.ClearBeforeFill = True
        '
        'EmbOrderLookupGridLookUpEdit
        '
        Me.EmbOrderLookupGridLookUpEdit.Location = New System.Drawing.Point(580, 6)
        Me.EmbOrderLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.EmbOrderLookupGridLookUpEdit.Name = "EmbOrderLookupGridLookUpEdit"
        Me.EmbOrderLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EmbOrderLookupGridLookUpEdit.Properties.DataSource = Me.EmbOrderLookupBindingSource
        Me.EmbOrderLookupGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.EmbOrderLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.EmbOrderLookupGridLookUpEdit.Properties.NullText = ""
        Me.EmbOrderLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.EmbOrderLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.EmbOrderLookupGridLookUpEdit.Properties.ValueMember = "EmbOrderId"
        Me.EmbOrderLookupGridLookUpEdit.Properties.View = Me.GridView4
        Me.EmbOrderLookupGridLookUpEdit.Size = New System.Drawing.Size(325, 20)
        Me.EmbOrderLookupGridLookUpEdit.TabIndex = 16
        '
        'EmbOrderLookupBindingSource
        '
        Me.EmbOrderLookupBindingSource.DataMember = "EmbOrderLookup"
        Me.EmbOrderLookupBindingSource.DataSource = Me.EmbOrderLookupDataSet
        '
        'EmbOrderLookupDataSet
        '
        Me.EmbOrderLookupDataSet.DataSetName = "EmbOrderLookupDataSet"
        Me.EmbOrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'EmbOrderLookupTableAdapter
        '
        Me.EmbOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        '
        'colPartName
        '
        Me.colPartName.FieldName = "PartName"
        Me.colPartName.Name = "colPartName"
        Me.colPartName.Visible = True
        Me.colPartName.VisibleIndex = 0
        '
        'EmbroideryRemarksBindingSource
        '
        Me.EmbroideryRemarksBindingSource.DataMember = "EmbroideryRemarks"
        Me.EmbroideryRemarksBindingSource.DataSource = Me.EmbOrderDataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(ToDesignationLabel)
        Me.GroupBox3.Controls.Add(Me.ToDesignationTextBox)
        Me.GroupBox3.Controls.Add(FromDesignationLabel)
        Me.GroupBox3.Controls.Add(Me.FromDesignationTextBox)
        Me.GroupBox3.Controls.Add(ToContactNoLabel)
        Me.GroupBox3.Controls.Add(Me.ToContactNoTextBox)
        Me.GroupBox3.Controls.Add(ToNameLabel)
        Me.GroupBox3.Controls.Add(Me.ToNameTextBox)
        Me.GroupBox3.Controls.Add(FromContactNoLabel)
        Me.GroupBox3.Controls.Add(Me.FromContactNoTextBox)
        Me.GroupBox3.Controls.Add(FromNameLabel)
        Me.GroupBox3.Controls.Add(Me.FromNameTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 380)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(424, 333)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Attention"
        '
        'ToDesignationTextBox
        '
        Me.ToDesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmbOrderBindingSource, "ToDesignation", True))
        Me.ToDesignationTextBox.Location = New System.Drawing.Point(115, 184)
        Me.ToDesignationTextBox.Name = "ToDesignationTextBox"
        Me.ToDesignationTextBox.Size = New System.Drawing.Size(190, 20)
        Me.ToDesignationTextBox.TabIndex = 11
        '
        'FromDesignationTextBox
        '
        Me.FromDesignationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmbOrderBindingSource, "FromDesignation", True))
        Me.FromDesignationTextBox.Location = New System.Drawing.Point(115, 91)
        Me.FromDesignationTextBox.Name = "FromDesignationTextBox"
        Me.FromDesignationTextBox.Size = New System.Drawing.Size(190, 20)
        Me.FromDesignationTextBox.TabIndex = 9
        '
        'ToContactNoTextBox
        '
        Me.ToContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmbOrderBindingSource, "ToContactNo", True))
        Me.ToContactNoTextBox.Location = New System.Drawing.Point(115, 158)
        Me.ToContactNoTextBox.Name = "ToContactNoTextBox"
        Me.ToContactNoTextBox.Size = New System.Drawing.Size(190, 20)
        Me.ToContactNoTextBox.TabIndex = 7
        '
        'ToNameTextBox
        '
        Me.ToNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmbOrderBindingSource, "ToName", True))
        Me.ToNameTextBox.Location = New System.Drawing.Point(115, 132)
        Me.ToNameTextBox.Name = "ToNameTextBox"
        Me.ToNameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.ToNameTextBox.TabIndex = 5
        '
        'FromContactNoTextBox
        '
        Me.FromContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmbOrderBindingSource, "FromContactNo", True))
        Me.FromContactNoTextBox.Location = New System.Drawing.Point(115, 66)
        Me.FromContactNoTextBox.Name = "FromContactNoTextBox"
        Me.FromContactNoTextBox.Size = New System.Drawing.Size(190, 20)
        Me.FromContactNoTextBox.TabIndex = 3
        '
        'FromNameTextBox
        '
        Me.FromNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmbOrderBindingSource, "FromName", True))
        Me.FromNameTextBox.Location = New System.Drawing.Point(115, 40)
        Me.FromNameTextBox.Name = "FromNameTextBox"
        Me.FromNameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.FromNameTextBox.TabIndex = 1
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.EmbOrderLookupGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1282, 35)
        Me.FlowLayoutPanel1.TabIndex = 52
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton.Location = New System.Drawing.Point(3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(82, 27)
        Me.NewButton.TabIndex = 4
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditButton.Location = New System.Drawing.Point(91, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 27)
        Me.EditButton.TabIndex = 5
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Location = New System.Drawing.Point(160, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(63, 27)
        Me.DeleteButton.TabIndex = 6
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CancelEntryButton
        '
        Me.CancelEntryButton.Enabled = False
        Me.CancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelEntryButton.Location = New System.Drawing.Point(229, 3)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(63, 27)
        Me.CancelEntryButton.TabIndex = 7
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RefreshButton.Location = New System.Drawing.Point(298, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 27)
        Me.RefreshButton.TabIndex = 48
        Me.RefreshButton.Text = "&Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(379, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 9, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 17)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Print Work Order No : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(911, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "&Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(992, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmEmbroideryOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 725)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmEmbroideryOrder"
        Me.Text = "Embroidery Order"
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BuyerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoLookupEmbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramLookupEmbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMBDeliveryDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMBDeliveryDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMBOrderDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMBOrderDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMBOrderNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EmbOrderDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EmbOrderSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbroideryRemarksGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbroideryRemarksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbOrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbroideryRemarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EmbOrderDataSet As KSoft_Apparel.EmbOrderDataSet
    Friend WithEvents EmbOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbOrderTableAdapter As KSoft_Apparel.EmbOrderDataSetTableAdapters.EmbOrderTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.EmbOrderDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EMBDeliveryDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EMBOrderDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EMBOrderNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmbOrderDetailsTableAdapter As KSoft_Apparel.EmbOrderDataSetTableAdapters.EmbOrderDetailsTableAdapter
    Friend WithEvents EmbOrderDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbOrderDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmbOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintPartId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EmbOrderSizeDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbOrderSizeDetailsTableAdapter As KSoft_Apparel.EmbOrderDataSetTableAdapters.EmbOrderSizeDetailsTableAdapter
    Friend WithEvents EmbOrderSizeDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GetSizeButton As System.Windows.Forms.Button
    Friend WithEvents GetColorButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintPartComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents ProgramLookupEmbDataSet As KSoft_Apparel.ProgramLookupEmbDataSet
    Friend WithEvents ProgramNoLookupEmbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProgramNoLookupEmbTableAdapter As KSoft_Apparel.ProgramLookupEmbDataSetTableAdapters.ProgramNoLookupEmbTableAdapter
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeDataSet As KSoft_Apparel.SizeDataSet
    Friend WithEvents SizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeTableAdapter As KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter
    Friend WithEvents PrintPartDataSet As KSoft_Apparel.PrintPartDataSet
    Friend WithEvents PrintPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintPartTableAdapter As KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter
    Friend WithEvents EmbOrderLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents EmbOrderLookupDataSet As KSoft_Apparel.EmbOrderLookupDataSet
    Friend WithEvents EmbOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbOrderLookupTableAdapter As KSoft_Apparel.EmbOrderLookupDataSetTableAdapters.EmbOrderLookupTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintPartGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents colAvgDesignStitch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmbroideryRemarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmbroideryRemarksTableAdapter As KSoft_Apparel.EmbOrderDataSetTableAdapters.EmbroideryRemarksTableAdapter
    Friend WithEvents EmbTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colEmbType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToDesignationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FromDesignationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToContactNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FromContactNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FromNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmbroideryRemarksBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EmbroideryRemarksGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgramNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GetPrgNoButton As System.Windows.Forms.Button
    Friend WithEvents StyleNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPricePerDzn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PasteButton As System.Windows.Forms.Button
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents BuyerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SizeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEmbOrderQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents NewButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents CancelEntryButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
End Class
