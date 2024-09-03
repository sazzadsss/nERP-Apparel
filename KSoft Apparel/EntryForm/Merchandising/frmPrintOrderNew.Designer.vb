<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrintOrderNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ProgramNoLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim PrintOrderDateLabel As System.Windows.Forms.Label
        Dim PrintExDateLabel As System.Windows.Forms.Label
        Dim PrintPricePerDznLabel As System.Windows.Forms.Label
        Dim PrintOrderNoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim AmendmentNoLabel As System.Windows.Forms.Label
        Dim AmendmentDetailsLabel As System.Windows.Forms.Label
        Dim StyleIdLabel As System.Windows.Forms.Label
        Dim FromNameLabel As System.Windows.Forms.Label
        Dim ToNameLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.StyleNameTextBox = New System.Windows.Forms.TextBox()
        Me.PrintOrderNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintOrderNewDataSet = New KSoft_Apparel.PrintOrderNewDataSet()
        Me.ToNameTextBox = New System.Windows.Forms.TextBox()
        Me.FromNameTextBox = New System.Windows.Forms.TextBox()
        Me.StyleIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.StyleIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AmendmentDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AmendmentDetailsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AmendmentNoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintOrderNoTextBox = New System.Windows.Forms.TextBox()
        Me.IsGMTCheckBox = New System.Windows.Forms.CheckBox()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.OrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsMultiPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintPricePerDznTextBox = New System.Windows.Forms.TextBox()
        Me.PrintExDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProgramNoTextBox = New System.Windows.Forms.TextBox()
        Me.PrintOrderDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.PrintOrderDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PrintOrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrintOrderDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintOrderNewId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintPartId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintPartGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.PrintPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintPartDataSet = New KSoft_Apparel.PrintPartDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrintPartId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.PrintTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintTypeDataSet = New KSoft_Apparel.PrintTypeDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrintTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintTypeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintColorQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colPricePerDzn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PrintOrderGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PrintOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintOrderExDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintPartId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintTypeId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMainPart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintOrderSizeDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PrintOrderSizeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrintOrderSizeDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintOrderId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataSet = New KSoft_Apparel.SizeDataSet()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGradingPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesignSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintOrderNewRemarksGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PrintOrderNewRemarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GetSizeButton = New System.Windows.Forms.Button()
        Me.GetColorButton = New System.Windows.Forms.Button()
        Me.PrintOrderNewTableAdapter = New KSoft_Apparel.PrintOrderNewDataSetTableAdapters.PrintOrderNewTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.PrintOrderNewDataSetTableAdapters.TableAdapterManager()
        Me.PrintOrderDetailsTableAdapter = New KSoft_Apparel.PrintOrderNewDataSetTableAdapters.PrintOrderDetailsTableAdapter()
        Me.PrintOrderNewRemarksTableAdapter = New KSoft_Apparel.PrintOrderNewDataSetTableAdapters.PrintOrderNewRemarksTableAdapter()
        Me.PrintOrderSizeDetailsTableAdapter = New KSoft_Apparel.PrintOrderNewDataSetTableAdapters.PrintOrderSizeDetailsTableAdapter()
        Me.PrintOrderTableAdapter = New KSoft_Apparel.PrintOrderNewDataSetTableAdapters.PrintOrderTableAdapter()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.StyleLookupTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter()
        Me.PrintPartTableAdapter = New KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter()
        Me.PrintTypeTableAdapter = New KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PrintOrderNewLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PrintOrderNewLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintOrderNewLookupDataSet = New KSoft_Apparel.PrintOrderNewLookupDataSet()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintOrderNewLookupTableAdapter = New KSoft_Apparel.PrintOrderNewLookupDataSetTableAdapters.PrintOrderNewLookupTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        ProgramNoLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        PrintOrderDateLabel = New System.Windows.Forms.Label()
        PrintExDateLabel = New System.Windows.Forms.Label()
        PrintPricePerDznLabel = New System.Windows.Forms.Label()
        PrintOrderNoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        AmendmentNoLabel = New System.Windows.Forms.Label()
        AmendmentDetailsLabel = New System.Windows.Forms.Label()
        StyleIdLabel = New System.Windows.Forms.Label()
        FromNameLabel = New System.Windows.Forms.Label()
        ToNameLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PrintOrderNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.PrintOrderDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PrintOrderGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewRemarksGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewRemarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgramNoLabel
        '
        ProgramNoLabel.AutoSize = True
        ProgramNoLabel.Location = New System.Drawing.Point(16, 182)
        ProgramNoLabel.Name = "ProgramNoLabel"
        ProgramNoLabel.Size = New System.Drawing.Size(66, 13)
        ProgramNoLabel.TabIndex = 2
        ProgramNoLabel.Text = "Program No:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(15, 368)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 4
        RemarksLabel.Text = "Remarks:"
        '
        'PrintOrderDateLabel
        '
        PrintOrderDateLabel.AutoSize = True
        PrintOrderDateLabel.Location = New System.Drawing.Point(14, 46)
        PrintOrderDateLabel.Name = "PrintOrderDateLabel"
        PrintOrderDateLabel.Size = New System.Drawing.Size(86, 13)
        PrintOrderDateLabel.TabIndex = 8
        PrintOrderDateLabel.Text = "Print Order Date:"
        '
        'PrintExDateLabel
        '
        PrintExDateLabel.AutoSize = True
        PrintExDateLabel.Location = New System.Drawing.Point(14, 72)
        PrintExDateLabel.Name = "PrintExDateLabel"
        PrintExDateLabel.Size = New System.Drawing.Size(72, 13)
        PrintExDateLabel.TabIndex = 10
        PrintExDateLabel.Text = "Print Ex Date:"
        '
        'PrintPricePerDznLabel
        '
        PrintPricePerDznLabel.AutoSize = True
        PrintPricePerDznLabel.Location = New System.Drawing.Point(16, 232)
        PrintPricePerDznLabel.Name = "PrintPricePerDznLabel"
        PrintPricePerDznLabel.Size = New System.Drawing.Size(90, 13)
        PrintPricePerDznLabel.TabIndex = 12
        PrintPricePerDznLabel.Text = "Price Per Dzn ($):"
        '
        'PrintOrderNoLabel
        '
        PrintOrderNoLabel.AutoSize = True
        PrintOrderNoLabel.Location = New System.Drawing.Point(14, 19)
        PrintOrderNoLabel.Name = "PrintOrderNoLabel"
        PrintOrderNoLabel.Size = New System.Drawing.Size(77, 13)
        PrintOrderNoLabel.TabIndex = 15
        PrintOrderNoLabel.Text = "Print Order No:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(15, 314)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 13)
        Label2.TabIndex = 21
        Label2.Text = "Supplier :"
        '
        'AmendmentNoLabel
        '
        AmendmentNoLabel.AutoSize = True
        AmendmentNoLabel.Location = New System.Drawing.Point(16, 128)
        AmendmentNoLabel.Name = "AmendmentNoLabel"
        AmendmentNoLabel.Size = New System.Drawing.Size(131, 13)
        AmendmentNoLabel.TabIndex = 21
        AmendmentNoLabel.Text = "Amendment No And Date:"
        '
        'AmendmentDetailsLabel
        '
        AmendmentDetailsLabel.AutoSize = True
        AmendmentDetailsLabel.Location = New System.Drawing.Point(16, 154)
        AmendmentDetailsLabel.Name = "AmendmentDetailsLabel"
        AmendmentDetailsLabel.Size = New System.Drawing.Size(101, 13)
        AmendmentDetailsLabel.TabIndex = 22
        AmendmentDetailsLabel.Text = "Amendment Details:"
        '
        'StyleIdLabel
        '
        StyleIdLabel.AutoSize = True
        StyleIdLabel.Location = New System.Drawing.Point(16, 206)
        StyleIdLabel.Name = "StyleIdLabel"
        StyleIdLabel.Size = New System.Drawing.Size(50, 13)
        StyleIdLabel.TabIndex = 28
        StyleIdLabel.Text = "Style No:"
        '
        'FromNameLabel
        '
        FromNameLabel.AutoSize = True
        FromNameLabel.Location = New System.Drawing.Point(16, 258)
        FromNameLabel.Name = "FromNameLabel"
        FromNameLabel.Size = New System.Drawing.Size(64, 13)
        FromNameLabel.TabIndex = 29
        FromNameLabel.Text = "From Name:"
        '
        'ToNameLabel
        '
        ToNameLabel.AutoSize = True
        ToNameLabel.Location = New System.Drawing.Point(15, 340)
        ToNameLabel.Name = "ToNameLabel"
        ToNameLabel.Size = New System.Drawing.Size(54, 13)
        ToNameLabel.TabIndex = 30
        ToNameLabel.Text = "To Name:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 41)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.StyleNameTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ToNameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToNameTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(FromNameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FromNameTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(StyleIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StyleIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AmendmentDateDateEdit)
        Me.SplitContainer1.Panel1.Controls.Add(AmendmentDetailsLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AmendmentDetailsTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(AmendmentNoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AmendmentNoSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PrintOrderNoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.IsGMTCheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PrintPricePerDznTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(PrintOrderNoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(PrintPricePerDznLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PrintExDateDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(ProgramNoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(PrintExDateLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProgramNoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PrintOrderDateDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(RemarksLabel)
        Me.SplitContainer1.Panel1.Controls.Add(PrintOrderDateLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RemarksTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1123, 613)
        Me.SplitContainer1.SplitterDistance = 385
        Me.SplitContainer1.TabIndex = 0
        '
        'StyleNameTextBox
        '
        Me.StyleNameTextBox.BackColor = System.Drawing.Color.Yellow
        Me.StyleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrintOrderNewBindingSource, "StyleName", True))
        Me.StyleNameTextBox.Location = New System.Drawing.Point(247, 203)
        Me.StyleNameTextBox.Name = "StyleNameTextBox"
        Me.StyleNameTextBox.Size = New System.Drawing.Size(122, 20)
        Me.StyleNameTextBox.TabIndex = 32
        '
        'PrintOrderNewBindingSource
        '
        Me.PrintOrderNewBindingSource.DataMember = "PrintOrderNew"
        Me.PrintOrderNewBindingSource.DataSource = Me.PrintOrderNewDataSet
        '
        'PrintOrderNewDataSet
        '
        Me.PrintOrderNewDataSet.DataSetName = "PrintOrderNewDataSet"
        Me.PrintOrderNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToNameTextBox
        '
        Me.ToNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrintOrderNewBindingSource, "ToName", True))
        Me.ToNameTextBox.Location = New System.Drawing.Point(123, 337)
        Me.ToNameTextBox.Name = "ToNameTextBox"
        Me.ToNameTextBox.Size = New System.Drawing.Size(246, 20)
        Me.ToNameTextBox.TabIndex = 31
        '
        'FromNameTextBox
        '
        Me.FromNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrintOrderNewBindingSource, "FromName", True))
        Me.FromNameTextBox.Location = New System.Drawing.Point(121, 255)
        Me.FromNameTextBox.Name = "FromNameTextBox"
        Me.FromNameTextBox.Size = New System.Drawing.Size(246, 20)
        Me.FromNameTextBox.TabIndex = 30
        '
        'StyleIdGridLookUpEdit
        '
        Me.StyleIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintOrderNewBindingSource, "StyleId", True))
        Me.StyleIdGridLookUpEdit.Location = New System.Drawing.Point(121, 203)
        Me.StyleIdGridLookUpEdit.Name = "StyleIdGridLookUpEdit"
        Me.StyleIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleIdGridLookUpEdit.Properties.DataSource = Me.StyleLookupBindingSource
        Me.StyleIdGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleIdGridLookUpEdit.Properties.NullText = ""
        Me.StyleIdGridLookUpEdit.Properties.PopupView = Me.StyleIdGridLookUpEditView
        Me.StyleIdGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleIdGridLookUpEdit.Size = New System.Drawing.Size(122, 20)
        Me.StyleIdGridLookUpEdit.TabIndex = 29
        '
        'StyleLookupBindingSource
        '
        Me.StyleLookupBindingSource.DataMember = "StyleLookup"
        Me.StyleLookupBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.EnforceConstraints = False
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleIdGridLookUpEditView
        '
        Me.StyleIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.StyleIdGridLookUpEditView.Name = "StyleIdGridLookUpEditView"
        Me.StyleIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.StyleIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'AmendmentDateDateEdit
        '
        Me.AmendmentDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintOrderNewBindingSource, "AmendmentDate", True))
        Me.AmendmentDateDateEdit.EditValue = Nothing
        Me.AmendmentDateDateEdit.Location = New System.Drawing.Point(247, 125)
        Me.AmendmentDateDateEdit.Name = "AmendmentDateDateEdit"
        Me.AmendmentDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentDateDateEdit.Size = New System.Drawing.Size(122, 20)
        Me.AmendmentDateDateEdit.TabIndex = 24
        '
        'AmendmentDetailsTextEdit
        '
        Me.AmendmentDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintOrderNewBindingSource, "AmendmentDetails", True))
        Me.AmendmentDetailsTextEdit.Location = New System.Drawing.Point(121, 151)
        Me.AmendmentDetailsTextEdit.Name = "AmendmentDetailsTextEdit"
        Me.AmendmentDetailsTextEdit.Size = New System.Drawing.Size(248, 20)
        Me.AmendmentDetailsTextEdit.TabIndex = 23
        '
        'AmendmentNoSpinEdit
        '
        Me.AmendmentNoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintOrderNewBindingSource, "AmendmentNo", True))
        Me.AmendmentNoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AmendmentNoSpinEdit.Location = New System.Drawing.Point(151, 125)
        Me.AmendmentNoSpinEdit.Name = "AmendmentNoSpinEdit"
        Me.AmendmentNoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentNoSpinEdit.Size = New System.Drawing.Size(90, 20)
        Me.AmendmentNoSpinEdit.TabIndex = 22
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintOrderNewBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(121, 311)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierIdGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.SupplierIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(246, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 20
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
        'PrintOrderNoTextBox
        '
        Me.PrintOrderNoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PrintOrderNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrintOrderNewBindingSource, "PrintOrderNo", True))
        Me.PrintOrderNoTextBox.Location = New System.Drawing.Point(119, 16)
        Me.PrintOrderNoTextBox.Name = "PrintOrderNoTextBox"
        Me.PrintOrderNoTextBox.Size = New System.Drawing.Size(122, 20)
        Me.PrintOrderNoTextBox.TabIndex = 16
        '
        'IsGMTCheckBox
        '
        Me.IsGMTCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PrintOrderNewBindingSource, "IsGMT", True))
        Me.IsGMTCheckBox.Enabled = False
        Me.IsGMTCheckBox.Location = New System.Drawing.Point(123, 389)
        Me.IsGMTCheckBox.Name = "IsGMTCheckBox"
        Me.IsGMTCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.IsGMTCheckBox.TabIndex = 15
        Me.IsGMTCheckBox.Text = "In-house"
        Me.IsGMTCheckBox.UseVisualStyleBackColor = True
        '
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintOrderNewBindingSource, "OrderId", True))
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(121, 177)
        Me.OrderIdGridLookUpEdit.Name = "OrderIdGridLookUpEdit"
        Me.OrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderIdGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderIdGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.OrderIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderIdGridLookUpEdit.Properties.NullText = ""
        Me.OrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderIdGridLookUpEdit.Properties.PopupView = Me.OrderIdGridLookUpEditView
        Me.OrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(122, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 18
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
        'OrderIdGridLookUpEditView
        '
        Me.OrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colProgramNo1, Me.colIsPrint, Me.colUserId, Me.colIsMultiPart})
        Me.OrderIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.OrderIdGridLookUpEditView.Name = "OrderIdGridLookUpEditView"
        Me.OrderIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.OrderIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.ReadOnly = True
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        Me.colProgramNo1.Visible = True
        Me.colProgramNo1.VisibleIndex = 0
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
        'PrintPricePerDznTextBox
        '
        Me.PrintPricePerDznTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrintOrderNewBindingSource, "PrintPricePerDzn", True))
        Me.PrintPricePerDznTextBox.Location = New System.Drawing.Point(121, 229)
        Me.PrintPricePerDznTextBox.Name = "PrintPricePerDznTextBox"
        Me.PrintPricePerDznTextBox.Size = New System.Drawing.Size(85, 20)
        Me.PrintPricePerDznTextBox.TabIndex = 13
        '
        'PrintExDateDateTimePicker
        '
        Me.PrintExDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.PrintExDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrintOrderNewBindingSource, "PrintExDate", True))
        Me.PrintExDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PrintExDateDateTimePicker.Location = New System.Drawing.Point(119, 68)
        Me.PrintExDateDateTimePicker.Name = "PrintExDateDateTimePicker"
        Me.PrintExDateDateTimePicker.Size = New System.Drawing.Size(122, 20)
        Me.PrintExDateDateTimePicker.TabIndex = 11
        '
        'ProgramNoTextBox
        '
        Me.ProgramNoTextBox.BackColor = System.Drawing.Color.Yellow
        Me.ProgramNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrintOrderNewBindingSource, "ProgramNo", True))
        Me.ProgramNoTextBox.Location = New System.Drawing.Point(247, 177)
        Me.ProgramNoTextBox.Name = "ProgramNoTextBox"
        Me.ProgramNoTextBox.Size = New System.Drawing.Size(122, 20)
        Me.ProgramNoTextBox.TabIndex = 3
        '
        'PrintOrderDateDateTimePicker
        '
        Me.PrintOrderDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.PrintOrderDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrintOrderNewBindingSource, "PrintOrderDate", True))
        Me.PrintOrderDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PrintOrderDateDateTimePicker.Location = New System.Drawing.Point(119, 42)
        Me.PrintOrderDateDateTimePicker.Name = "PrintOrderDateDateTimePicker"
        Me.PrintOrderDateDateTimePicker.Size = New System.Drawing.Size(122, 20)
        Me.PrintOrderDateDateTimePicker.TabIndex = 9
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrintOrderNewBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(123, 363)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(246, 20)
        Me.RemarksTextBox.TabIndex = 5
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.Controls.Add(Me.PrintOrderDetailsGridControl)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(734, 613)
        Me.SplitContainer3.SplitterDistance = 173
        Me.SplitContainer3.TabIndex = 0
        '
        'PrintOrderDetailsGridControl
        '
        Me.PrintOrderDetailsGridControl.DataSource = Me.PrintOrderDetailsBindingSource
        Me.PrintOrderDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintOrderDetailsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.PrintOrderDetailsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.PrintOrderDetailsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.PrintOrderDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.PrintOrderDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.PrintOrderDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.PrintOrderDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.PrintOrderDetailsGridControl.MainView = Me.GridView1
        Me.PrintOrderDetailsGridControl.Name = "PrintOrderDetailsGridControl"
        Me.PrintOrderDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.PrintPartGridLookUpEdit, Me.PrintTypeGridLookUpEdit, Me.RepositoryItemImageEdit1, Me.RepositoryItemPictureEdit1})
        Me.PrintOrderDetailsGridControl.Size = New System.Drawing.Size(734, 173)
        Me.PrintOrderDetailsGridControl.TabIndex = 0
        Me.PrintOrderDetailsGridControl.UseEmbeddedNavigator = True
        Me.PrintOrderDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PrintOrderDetailsBindingSource
        '
        Me.PrintOrderDetailsBindingSource.DataMember = "FK_PrintOrderDetails_PrintOrderNew"
        Me.PrintOrderDetailsBindingSource.DataSource = Me.PrintOrderNewBindingSource
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintOrderDetailsId, Me.colPrintOrderNewId, Me.colPrintPartId, Me.colPrintTypeId, Me.colPrintColorQuantity, Me.colPrintImage, Me.colPricePerDzn})
        Me.GridView1.GridControl = Me.PrintOrderDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 50
        '
        'colPrintOrderDetailsId
        '
        Me.colPrintOrderDetailsId.FieldName = "PrintOrderDetailsId"
        Me.colPrintOrderDetailsId.Name = "colPrintOrderDetailsId"
        '
        'colPrintOrderNewId
        '
        Me.colPrintOrderNewId.FieldName = "PrintOrderNewId"
        Me.colPrintOrderNewId.Name = "colPrintOrderNewId"
        '
        'colPrintPartId
        '
        Me.colPrintPartId.Caption = "Print Part"
        Me.colPrintPartId.ColumnEdit = Me.PrintPartGridLookUpEdit
        Me.colPrintPartId.FieldName = "PrintPartId"
        Me.colPrintPartId.Name = "colPrintPartId"
        Me.colPrintPartId.Visible = True
        Me.colPrintPartId.VisibleIndex = 0
        Me.colPrintPartId.Width = 132
        '
        'PrintPartGridLookUpEdit
        '
        Me.PrintPartGridLookUpEdit.AutoHeight = False
        Me.PrintPartGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintPartGridLookUpEdit.DataSource = Me.PrintPartBindingSource
        Me.PrintPartGridLookUpEdit.DisplayMember = "PartName"
        Me.PrintPartGridLookUpEdit.Name = "PrintPartGridLookUpEdit"
        Me.PrintPartGridLookUpEdit.NullText = ""
        Me.PrintPartGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.PrintPartGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrintPartGridLookUpEdit.ValueMember = "PrintPartId"
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintPartId1, Me.colPartName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colPrintPartId1
        '
        Me.colPrintPartId1.FieldName = "PrintPartId"
        Me.colPrintPartId1.Name = "colPrintPartId1"
        Me.colPrintPartId1.OptionsColumn.ReadOnly = True
        '
        'colPartName
        '
        Me.colPartName.FieldName = "PartName"
        Me.colPartName.Name = "colPartName"
        Me.colPartName.Visible = True
        Me.colPartName.VisibleIndex = 0
        '
        'colPrintTypeId
        '
        Me.colPrintTypeId.Caption = "Print Type"
        Me.colPrintTypeId.ColumnEdit = Me.PrintTypeGridLookUpEdit
        Me.colPrintTypeId.FieldName = "PrintTypeId"
        Me.colPrintTypeId.Name = "colPrintTypeId"
        Me.colPrintTypeId.Visible = True
        Me.colPrintTypeId.VisibleIndex = 1
        Me.colPrintTypeId.Width = 130
        '
        'PrintTypeGridLookUpEdit
        '
        Me.PrintTypeGridLookUpEdit.AutoHeight = False
        Me.PrintTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintTypeGridLookUpEdit.DataSource = Me.PrintTypeBindingSource
        Me.PrintTypeGridLookUpEdit.DisplayMember = "PrintTypeName"
        Me.PrintTypeGridLookUpEdit.Name = "PrintTypeGridLookUpEdit"
        Me.PrintTypeGridLookUpEdit.NullText = ""
        Me.PrintTypeGridLookUpEdit.PopupView = Me.GridView4
        Me.PrintTypeGridLookUpEdit.ValueMember = "PrintTypeId"
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
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintTypeId1, Me.colPrintTypeName, Me.colRemarks1})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colPrintTypeId1
        '
        Me.colPrintTypeId1.FieldName = "PrintTypeId"
        Me.colPrintTypeId1.Name = "colPrintTypeId1"
        Me.colPrintTypeId1.OptionsColumn.ReadOnly = True
        '
        'colPrintTypeName
        '
        Me.colPrintTypeName.FieldName = "PrintTypeName"
        Me.colPrintTypeName.Name = "colPrintTypeName"
        Me.colPrintTypeName.Visible = True
        Me.colPrintTypeName.VisibleIndex = 0
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        '
        'colPrintColorQuantity
        '
        Me.colPrintColorQuantity.FieldName = "PrintColorQuantity"
        Me.colPrintColorQuantity.Name = "colPrintColorQuantity"
        Me.colPrintColorQuantity.Visible = True
        Me.colPrintColorQuantity.VisibleIndex = 2
        Me.colPrintColorQuantity.Width = 109
        '
        'colPrintImage
        '
        Me.colPrintImage.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.colPrintImage.FieldName = "PrintImage"
        Me.colPrintImage.ImageOptions.Alignment = System.Drawing.StringAlignment.Center
        Me.colPrintImage.Name = "colPrintImage"
        Me.colPrintImage.Visible = True
        Me.colPrintImage.VisibleIndex = 4
        Me.colPrintImage.Width = 197
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'colPricePerDzn
        '
        Me.colPricePerDzn.FieldName = "PricePerDzn"
        Me.colPricePerDzn.Name = "colPricePerDzn"
        Me.colPricePerDzn.Visible = True
        Me.colPricePerDzn.VisibleIndex = 3
        Me.colPricePerDzn.Width = 111
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Print Order No :: Program No :: Style No :"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.AutoScroll = True
        Me.SplitContainer4.Panel2.Controls.Add(Me.PrintOrderNewRemarksGridControl)
        Me.SplitContainer4.Size = New System.Drawing.Size(734, 436)
        Me.SplitContainer4.SplitterDistance = 166
        Me.SplitContainer4.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PrintOrderGridControl)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.PrintOrderSizeDetailsGridControl)
        Me.SplitContainer2.Size = New System.Drawing.Size(734, 166)
        Me.SplitContainer2.SplitterDistance = 389
        Me.SplitContainer2.TabIndex = 1
        '
        'PrintOrderGridControl
        '
        Me.PrintOrderGridControl.DataSource = Me.PrintOrderBindingSource
        Me.PrintOrderGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintOrderGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.PrintOrderGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.PrintOrderGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.PrintOrderGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.PrintOrderGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.PrintOrderGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.PrintOrderGridControl.Location = New System.Drawing.Point(0, 0)
        Me.PrintOrderGridControl.MainView = Me.GridView2
        Me.PrintOrderGridControl.Name = "PrintOrderGridControl"
        Me.PrintOrderGridControl.Size = New System.Drawing.Size(389, 166)
        Me.PrintOrderGridControl.TabIndex = 0
        Me.PrintOrderGridControl.UseEmbeddedNavigator = True
        Me.PrintOrderGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'PrintOrderBindingSource
        '
        Me.PrintOrderBindingSource.DataMember = "FK_PrintOrder_PrintOrderDetails"
        Me.PrintOrderBindingSource.DataSource = Me.PrintOrderDetailsBindingSource
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorId, Me.colRemarks, Me.colProgramNo, Me.colFabricColorName, Me.colPrintOrderQuantity, Me.colPrintOrderDate, Me.colPrintOrderExDate, Me.colPrintPartId2, Me.colPrintTypeId2, Me.colStyleId1, Me.colOrderId2, Me.colMainPart})
        Me.GridView2.GridControl = Me.PrintOrderGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowDetailButtons = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorId
        '
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 2
        Me.colRemarks.Width = 197
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        '
        'colFabricColorName
        '
        Me.colFabricColorName.Caption = "Color"
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        Me.colFabricColorName.Width = 60
        '
        'colPrintOrderQuantity
        '
        Me.colPrintOrderQuantity.FieldName = "PrintOrderQuantity"
        Me.colPrintOrderQuantity.Name = "colPrintOrderQuantity"
        Me.colPrintOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPrintOrderQuantity.Visible = True
        Me.colPrintOrderQuantity.VisibleIndex = 1
        Me.colPrintOrderQuantity.Width = 110
        '
        'colPrintOrderDate
        '
        Me.colPrintOrderDate.FieldName = "PrintOrderDate"
        Me.colPrintOrderDate.Name = "colPrintOrderDate"
        '
        'colPrintOrderExDate
        '
        Me.colPrintOrderExDate.FieldName = "PrintOrderExDate"
        Me.colPrintOrderExDate.Name = "colPrintOrderExDate"
        '
        'colPrintPartId2
        '
        Me.colPrintPartId2.FieldName = "PrintPartId"
        Me.colPrintPartId2.Name = "colPrintPartId2"
        '
        'colPrintTypeId2
        '
        Me.colPrintTypeId2.FieldName = "PrintTypeId"
        Me.colPrintTypeId2.Name = "colPrintTypeId2"
        '
        'colStyleId1
        '
        Me.colStyleId1.FieldName = "StyleId"
        Me.colStyleId1.Name = "colStyleId1"
        '
        'colOrderId2
        '
        Me.colOrderId2.FieldName = "OrderId"
        Me.colOrderId2.Name = "colOrderId2"
        '
        'colMainPart
        '
        Me.colMainPart.FieldName = "MainPart"
        Me.colMainPart.Name = "colMainPart"
        '
        'PrintOrderSizeDetailsGridControl
        '
        Me.PrintOrderSizeDetailsGridControl.DataSource = Me.PrintOrderSizeDetailsBindingSource
        Me.PrintOrderSizeDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintOrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.PrintOrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.PrintOrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.PrintOrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.PrintOrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.PrintOrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.PrintOrderSizeDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.PrintOrderSizeDetailsGridControl.MainView = Me.GridView3
        Me.PrintOrderSizeDetailsGridControl.Name = "PrintOrderSizeDetailsGridControl"
        Me.PrintOrderSizeDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeGridLookUpEdit})
        Me.PrintOrderSizeDetailsGridControl.Size = New System.Drawing.Size(341, 166)
        Me.PrintOrderSizeDetailsGridControl.TabIndex = 0
        Me.PrintOrderSizeDetailsGridControl.UseEmbeddedNavigator = True
        Me.PrintOrderSizeDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'PrintOrderSizeDetailsBindingSource
        '
        Me.PrintOrderSizeDetailsBindingSource.DataMember = "FK_PrintOrderSizeDetails_PrintOrder"
        Me.PrintOrderSizeDetailsBindingSource.DataSource = Me.PrintOrderBindingSource
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintOrderSizeDetailsId, Me.colPrintOrderId1, Me.colSizeId, Me.colOrderQuantity, Me.colGradingPercentage, Me.colDesignSize})
        Me.GridView3.GridControl = Me.PrintOrderSizeDetailsGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colPrintOrderSizeDetailsId
        '
        Me.colPrintOrderSizeDetailsId.FieldName = "PrintOrderSizeDetailsId"
        Me.colPrintOrderSizeDetailsId.Name = "colPrintOrderSizeDetailsId"
        Me.colPrintOrderSizeDetailsId.OptionsColumn.ReadOnly = True
        '
        'colPrintOrderId1
        '
        Me.colPrintOrderId1.FieldName = "PrintOrderId"
        Me.colPrintOrderId1.Name = "colPrintOrderId1"
        '
        'colSizeId
        '
        Me.colSizeId.Caption = "Size"
        Me.colSizeId.ColumnEdit = Me.SizeGridLookUpEdit
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        Me.colSizeId.Visible = True
        Me.colSizeId.VisibleIndex = 0
        Me.colSizeId.Width = 80
        '
        'SizeGridLookUpEdit
        '
        Me.SizeGridLookUpEdit.AutoHeight = False
        Me.SizeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeGridLookUpEdit.DataSource = Me.SizeBindingSource
        Me.SizeGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeGridLookUpEdit.Name = "SizeGridLookUpEdit"
        Me.SizeGridLookUpEdit.NullText = ""
        Me.SizeGridLookUpEdit.PopupView = Me.GridView5
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
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.Caption = "Print Order Qty"
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 1
        Me.colOrderQuantity.Width = 155
        '
        'colGradingPercentage
        '
        Me.colGradingPercentage.Caption = "Grading %"
        Me.colGradingPercentage.FieldName = "GradingPercentage"
        Me.colGradingPercentage.Name = "colGradingPercentage"
        Me.colGradingPercentage.Visible = True
        Me.colGradingPercentage.VisibleIndex = 2
        '
        'colDesignSize
        '
        Me.colDesignSize.Caption = "Deisgn Size"
        Me.colDesignSize.FieldName = "DesignSize"
        Me.colDesignSize.Name = "colDesignSize"
        Me.colDesignSize.Visible = True
        Me.colDesignSize.VisibleIndex = 3
        '
        'PrintOrderNewRemarksGridControl
        '
        Me.PrintOrderNewRemarksGridControl.DataSource = Me.PrintOrderNewRemarksBindingSource
        Me.PrintOrderNewRemarksGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintOrderNewRemarksGridControl.Location = New System.Drawing.Point(0, 0)
        Me.PrintOrderNewRemarksGridControl.MainView = Me.GridView7
        Me.PrintOrderNewRemarksGridControl.Name = "PrintOrderNewRemarksGridControl"
        Me.PrintOrderNewRemarksGridControl.Size = New System.Drawing.Size(734, 266)
        Me.PrintOrderNewRemarksGridControl.TabIndex = 0
        Me.PrintOrderNewRemarksGridControl.UseEmbeddedNavigator = True
        Me.PrintOrderNewRemarksGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'PrintOrderNewRemarksBindingSource
        '
        Me.PrintOrderNewRemarksBindingSource.DataMember = "FK_PrintOrderNewRemarks_PrintOrderNew"
        Me.PrintOrderNewRemarksBindingSource.DataSource = Me.PrintOrderNewBindingSource
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSL, Me.colRemarks2})
        Me.GridView7.GridControl = Me.PrintOrderNewRemarksGridControl
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colSL
        '
        Me.colSL.FieldName = "SL"
        Me.colSL.Name = "colSL"
        Me.colSL.Visible = True
        Me.colSL.VisibleIndex = 0
        Me.colSL.Width = 47
        '
        'colRemarks2
        '
        Me.colRemarks2.Caption = "Terms & Conditions"
        Me.colRemarks2.FieldName = "Remarks"
        Me.colRemarks2.Name = "colRemarks2"
        Me.colRemarks2.Visible = True
        Me.colRemarks2.VisibleIndex = 1
        Me.colRemarks2.Width = 661
        '
        'GetSizeButton
        '
        Me.GetSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GetSizeButton.Location = New System.Drawing.Point(448, 3)
        Me.GetSizeButton.Name = "GetSizeButton"
        Me.GetSizeButton.Size = New System.Drawing.Size(67, 27)
        Me.GetSizeButton.TabIndex = 20
        Me.GetSizeButton.Text = "&Get Size"
        Me.GetSizeButton.UseVisualStyleBackColor = True
        '
        'GetColorButton
        '
        Me.GetColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GetColorButton.Location = New System.Drawing.Point(379, 3)
        Me.GetColorButton.Name = "GetColorButton"
        Me.GetColorButton.Size = New System.Drawing.Size(63, 27)
        Me.GetColorButton.TabIndex = 20
        Me.GetColorButton.Text = "&Get Color"
        Me.GetColorButton.UseVisualStyleBackColor = True
        '
        'PrintOrderNewTableAdapter
        '
        Me.PrintOrderNewTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PrintOrderDetailsTableAdapter = Me.PrintOrderDetailsTableAdapter
        Me.TableAdapterManager.PrintOrderNewRemarksTableAdapter = Me.PrintOrderNewRemarksTableAdapter
        Me.TableAdapterManager.PrintOrderNewTableAdapter = Me.PrintOrderNewTableAdapter
        Me.TableAdapterManager.PrintOrderSizeDetailsTableAdapter = Me.PrintOrderSizeDetailsTableAdapter
        Me.TableAdapterManager.PrintOrderTableAdapter = Me.PrintOrderTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PrintOrderNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintOrderDetailsTableAdapter
        '
        Me.PrintOrderDetailsTableAdapter.ClearBeforeFill = True
        '
        'PrintOrderNewRemarksTableAdapter
        '
        Me.PrintOrderNewRemarksTableAdapter.ClearBeforeFill = True
        '
        'PrintOrderSizeDetailsTableAdapter
        '
        Me.PrintOrderSizeDetailsTableAdapter.ClearBeforeFill = True
        '
        'PrintOrderTableAdapter
        '
        Me.PrintOrderTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'StyleLookupTableAdapter
        '
        Me.StyleLookupTableAdapter.ClearBeforeFill = True
        '
        'PrintPartTableAdapter
        '
        Me.PrintPartTableAdapter.ClearBeforeFill = True
        '
        'PrintTypeTableAdapter
        '
        Me.PrintTypeTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PrintOrderNewLookupGridLookUpEdit
        '
        Me.PrintOrderNewLookupGridLookUpEdit.Location = New System.Drawing.Point(659, 6)
        Me.PrintOrderNewLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.PrintOrderNewLookupGridLookUpEdit.Name = "PrintOrderNewLookupGridLookUpEdit"
        Me.PrintOrderNewLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintOrderNewLookupGridLookUpEdit.Properties.DataSource = Me.PrintOrderNewLookupBindingSource
        Me.PrintOrderNewLookupGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.PrintOrderNewLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.PrintOrderNewLookupGridLookUpEdit.Properties.NullText = ""
        Me.PrintOrderNewLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.PrintOrderNewLookupGridLookUpEdit.Properties.PopupView = Me.GridView6
        Me.PrintOrderNewLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrintOrderNewLookupGridLookUpEdit.Properties.ValueMember = "PrintOrderNewId"
        Me.PrintOrderNewLookupGridLookUpEdit.Size = New System.Drawing.Size(217, 20)
        Me.PrintOrderNewLookupGridLookUpEdit.TabIndex = 18
        '
        'PrintOrderNewLookupBindingSource
        '
        Me.PrintOrderNewLookupBindingSource.DataMember = "PrintOrderNewLookup"
        Me.PrintOrderNewLookupBindingSource.DataSource = Me.PrintOrderNewLookupDataSet
        '
        'PrintOrderNewLookupDataSet
        '
        Me.PrintOrderNewLookupDataSet.DataSetName = "PrintOrderNewLookupDataSet"
        Me.PrintOrderNewLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.OptionsColumn.ReadOnly = True
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'PrintOrderNewLookupTableAdapter
        '
        Me.PrintOrderNewLookupTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'colStyleName
        '
        Me.colStyleName.Caption = "Style No"
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'SizeTableAdapter
        '
        Me.SizeTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.GetColorButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.GetSizeButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrintOrderNewLookupGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1123, 35)
        Me.FlowLayoutPanel1.TabIndex = 53
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
        Me.Label5.Location = New System.Drawing.Point(521, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 9, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Print Work Order No : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.Location = New System.Drawing.Point(882, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 27)
        Me.ShowButton.TabIndex = 47
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(963, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 27)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPrintOrderNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 654)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmPrintOrderNew"
        Me.Text = "Print Order New"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PrintOrderNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.PrintOrderDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PrintOrderGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewRemarksGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewRemarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PrintOrderNewDataSet As KSoft_Apparel.PrintOrderNewDataSet
    Friend WithEvents PrintOrderNewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintOrderNewTableAdapter As KSoft_Apparel.PrintOrderNewDataSetTableAdapters.PrintOrderNewTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PrintOrderNewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProgramNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintOrderDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintExDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintPricePerDznTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsGMTCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PrintOrderDetailsTableAdapter As KSoft_Apparel.PrintOrderNewDataSetTableAdapters.PrintOrderDetailsTableAdapter
    Friend WithEvents PrintOrderDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents PrintOrderTableAdapter As KSoft_Apparel.PrintOrderNewDataSetTableAdapters.PrintOrderTableAdapter
    Friend WithEvents PrintOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintOrderSizeDetailsTableAdapter As KSoft_Apparel.PrintOrderNewDataSetTableAdapters.PrintOrderSizeDetailsTableAdapter
    Friend WithEvents PrintOrderSizeDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintOrderNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintOrderSizeDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrintOrderSizeDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintOrderId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintOrderDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrintOrderDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintOrderNewId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintPartId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintColorQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintOrderGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents OrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsMultiPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleLookupTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter
    Friend WithEvents PrintPartGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintPartDataSet As KSoft_Apparel.PrintPartDataSet
    Friend WithEvents PrintPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintPartTableAdapter As KSoft_Apparel.PrintPartDataSetTableAdapters.PrintPartTableAdapter
    Friend WithEvents PrintTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintTypeDataSet As KSoft_Apparel.PrintTypeDataSet
    Friend WithEvents PrintTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintTypeTableAdapter As KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter
    Friend WithEvents SizeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPrintTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents colPrintPartId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintOrderExDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintPartId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintTypeId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMainPart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PrintOrderNewLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintOrderNewLookupDataSet As KSoft_Apparel.PrintOrderNewLookupDataSet
    Friend WithEvents PrintOrderNewLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintOrderNewLookupTableAdapter As KSoft_Apparel.PrintOrderNewLookupDataSetTableAdapters.PrintOrderNewLookupTableAdapter
    Friend WithEvents GetColorButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GetSizeButton As System.Windows.Forms.Button
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents AmendmentDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AmendmentDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AmendmentNoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents colGradingPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesignSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents StyleIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FromNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PrintOrderNewRemarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintOrderNewRemarksTableAdapter As KSoft_Apparel.PrintOrderNewDataSetTableAdapters.PrintOrderNewRemarksTableAdapter
    Friend WithEvents PrintOrderNewRemarksGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeDataSet As KSoft_Apparel.SizeDataSet
    Friend WithEvents SizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeTableAdapter As KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPricePerDzn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents NewButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents CancelEntryButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ShowButton As Button
    Friend WithEvents Button1 As Button
End Class
