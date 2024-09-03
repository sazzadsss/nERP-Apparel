<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintDelivery
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
        Dim OrderIdLabel As System.Windows.Forms.Label
        Dim AttentionLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim ChallanDateLabel As System.Windows.Forms.Label
        Dim ChallanNoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PrintingDeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintingDeliveryDataSet = New KSoft_Apparel.PrintingDeliveryDataSet()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBranchName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AttentionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChallanDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ChallanNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChallanLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PrintingDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintingDeliveryChallanLookupDataSet = New KSoft_Apparel.PrintingDeliveryChallanLookupDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.PrintingDeliveryDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PrintingDeliveryDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPrintOrderid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintOrderLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.PrintOrderLookupNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintProductionDataSet = New KSoft_Apparel.PrintProductionDataSet()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PrintOrderNewLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintOrderNewLookupDataSet = New KSoft_Apparel.PrintOrderNewLookupDataSet()
        Me.OrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GetButton = New System.Windows.Forms.Button()
        Me.ProductionDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PrintingDeliverySizeDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PrintingDeliverySizeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataSet = New KSoft_Apparel.SizeDataSet()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryQuantity2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SewingDeliverySizeDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeLookupDataSet = New KSoft_Apparel.SizeLookupDataSet()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.PrintingDeliveryTableAdapter = New KSoft_Apparel.PrintingDeliveryDataSetTableAdapters.PrintingDeliveryTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.PrintingDeliveryDataSetTableAdapters.TableAdapterManager()
        Me.PrintingDeliveryDetailsTableAdapter = New KSoft_Apparel.PrintingDeliveryDataSetTableAdapters.PrintingDeliveryDetailsTableAdapter()
        Me.PrintingDeliverySizeDetailsTableAdapter = New KSoft_Apparel.PrintingDeliveryDataSetTableAdapters.PrintingDeliverySizeDetailsTableAdapter()
        Me.SupplierLookupTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierLookupTableAdapter()
        Me.SizeLookupTableAdapter = New KSoft_Apparel.SizeLookupDataSetTableAdapters.SizeLookupTableAdapter()
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.LineDataSet = New KSoft_Apparel.LineDataSet()
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
        Me.PrintingDeliveryChallanLookupTableAdapter = New KSoft_Apparel.PrintingDeliveryChallanLookupDataSetTableAdapters.PrintingDeliveryChallanLookupTableAdapter()
        Me.SizeTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter()
        Me.PrintOrderLookupNewTableAdapter = New KSoft_Apparel.PrintProductionDataSetTableAdapters.PrintOrderLookupNewTableAdapter()
        Me.PrintOrderNewLookupTableAdapter = New KSoft_Apparel.PrintOrderNewLookupDataSetTableAdapters.PrintOrderNewLookupTableAdapter()
        OrderIdLabel = New System.Windows.Forms.Label()
        AttentionLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        ChallanDateLabel = New System.Windows.Forms.Label()
        ChallanNoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingDeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingDeliveryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ChallanLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.PrintingDeliveryDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingDeliveryDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderLookupNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintOrderNewLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingDeliverySizeDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingDeliverySizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDeliverySizeDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderIdLabel
        '
        OrderIdLabel.AutoSize = True
        OrderIdLabel.Location = New System.Drawing.Point(318, 9)
        OrderIdLabel.Name = "OrderIdLabel"
        OrderIdLabel.Size = New System.Drawing.Size(148, 13)
        OrderIdLabel.TabIndex = 69
        OrderIdLabel.Text = "Program :: Style : Work Order:"
        '
        'AttentionLabel
        '
        AttentionLabel.AutoSize = True
        AttentionLabel.Location = New System.Drawing.Point(27, 155)
        AttentionLabel.Name = "AttentionLabel"
        AttentionLabel.Size = New System.Drawing.Size(52, 13)
        AttentionLabel.TabIndex = 66
        AttentionLabel.Text = "Attention:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(27, 180)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 64
        RemarksLabel.Text = "Remarks:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(27, 129)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(86, 13)
        Label1.TabIndex = 61
        Label1.Text = "For Department :"
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(27, 105)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(67, 13)
        SupplierIdLabel.TabIndex = 62
        SupplierIdLabel.Text = "Delivery To :"
        '
        'ChallanDateLabel
        '
        ChallanDateLabel.AutoSize = True
        ChallanDateLabel.Location = New System.Drawing.Point(27, 80)
        ChallanDateLabel.Name = "ChallanDateLabel"
        ChallanDateLabel.Size = New System.Drawing.Size(71, 13)
        ChallanDateLabel.TabIndex = 59
        ChallanDateLabel.Text = "Challan Date:"
        '
        'ChallanNoLabel
        '
        ChallanNoLabel.AutoSize = True
        ChallanNoLabel.Location = New System.Drawing.Point(27, 54)
        ChallanNoLabel.Name = "ChallanNoLabel"
        ChallanNoLabel.Size = New System.Drawing.Size(62, 13)
        ChallanNoLabel.TabIndex = 57
        ChallanNoLabel.Text = "Challan No:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(27, 9)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(87, 13)
        Label2.TabIndex = 59
        Label2.Text = "Production Date:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridLookUpEdit1)
        Me.SplitContainer1.Panel1.Controls.Add(AttentionLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AttentionTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(RemarksLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RemarksTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Label1)
        Me.SplitContainer1.Panel1.Controls.Add(SupplierIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(ChallanDateLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChallanDateDateEdit)
        Me.SplitContainer1.Panel1.Controls.Add(ChallanNoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChallanNoTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1149, 606)
        Me.SplitContainer1.SplitterDistance = 223
        Me.SplitContainer1.TabIndex = 1
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingDeliveryBindingSource, "BranchId", True))
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(115, 126)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.BranchBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "BranchName"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridView5
        Me.GridLookUpEdit1.Properties.ValueMember = "BranchId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(194, 20)
        Me.GridLookUpEdit1.TabIndex = 72
        '
        'PrintingDeliveryBindingSource
        '
        Me.PrintingDeliveryBindingSource.DataMember = "PrintingDelivery"
        Me.PrintingDeliveryBindingSource.DataSource = Me.PrintingDeliveryDataSet
        '
        'PrintingDeliveryDataSet
        '
        Me.PrintingDeliveryDataSet.DataSetName = "PrintingDeliveryDataSet"
        Me.PrintingDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchName})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colBranchName
        '
        Me.colBranchName.FieldName = "BranchName"
        Me.colBranchName.Name = "colBranchName"
        Me.colBranchName.Visible = True
        Me.colBranchName.VisibleIndex = 0
        '
        'AttentionTextEdit
        '
        Me.AttentionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingDeliveryBindingSource, "Attention", True))
        Me.AttentionTextEdit.Location = New System.Drawing.Point(115, 152)
        Me.AttentionTextEdit.Name = "AttentionTextEdit"
        Me.AttentionTextEdit.Size = New System.Drawing.Size(194, 20)
        Me.AttentionTextEdit.TabIndex = 67
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingDeliveryBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(113, 177)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(464, 20)
        Me.RemarksTextEdit.TabIndex = 65
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingDeliveryBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(115, 102)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierLookupBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierIdGridLookUpEdit.Properties.PopupView = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(194, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 63
        '
        'SupplierLookupBindingSource
        '
        Me.SupplierLookupBindingSource.DataMember = "SupplierLookup"
        Me.SupplierLookupBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.EnforceConstraints = False
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierCode, Me.colSupplierName, Me.colSupplierType})
        Me.SupplierIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIdGridLookUpEditView.Name = "SupplierIdGridLookUpEditView"
        Me.SupplierIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 1
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
        '
        'colSupplierType
        '
        Me.colSupplierType.FieldName = "SupplierType"
        Me.colSupplierType.Name = "colSupplierType"
        Me.colSupplierType.Visible = True
        Me.colSupplierType.VisibleIndex = 2
        '
        'ChallanDateDateEdit
        '
        Me.ChallanDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingDeliveryBindingSource, "ChallanDate", True))
        Me.ChallanDateDateEdit.EditValue = Nothing
        Me.ChallanDateDateEdit.Location = New System.Drawing.Point(115, 77)
        Me.ChallanDateDateEdit.Name = "ChallanDateDateEdit"
        Me.ChallanDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanDateDateEdit.Size = New System.Drawing.Size(194, 20)
        Me.ChallanDateDateEdit.TabIndex = 60
        '
        'ChallanNoTextEdit
        '
        Me.ChallanNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PrintingDeliveryBindingSource, "ChallanNo", True))
        Me.ChallanNoTextEdit.Location = New System.Drawing.Point(115, 51)
        Me.ChallanNoTextEdit.Name = "ChallanNoTextEdit"
        Me.ChallanNoTextEdit.Size = New System.Drawing.Size(194, 20)
        Me.ChallanNoTextEdit.TabIndex = 58
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrintButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.ChallanLookupGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1149, 35)
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
        Me.RefreshButton.Visible = False
        '
        'PrintButton
        '
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrintButton.Location = New System.Drawing.Point(379, 3)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 27)
        Me.PrintButton.TabIndex = 35
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(460, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Printing Challan No :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChallanLookupGridLookUpEdit
        '
        Me.ChallanLookupGridLookUpEdit.EditValue = "[Select your Program]"
        Me.ChallanLookupGridLookUpEdit.Location = New System.Drawing.Point(592, 7)
        Me.ChallanLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.ChallanLookupGridLookUpEdit.Name = "ChallanLookupGridLookUpEdit"
        Me.ChallanLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanLookupGridLookUpEdit.Properties.DataSource = Me.PrintingDeliveryChallanLookupBindingSource
        Me.ChallanLookupGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ChallanLookupGridLookUpEdit.Properties.NullText = "Select your Program"
        Me.ChallanLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ChallanLookupGridLookUpEdit.Properties.PopupView = Me.GridView4
        Me.ChallanLookupGridLookUpEdit.Properties.Tag = "NR"
        Me.ChallanLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ChallanLookupGridLookUpEdit.Properties.ValueMember = "PrintingDeliveryId"
        Me.ChallanLookupGridLookUpEdit.Size = New System.Drawing.Size(251, 20)
        Me.ChallanLookupGridLookUpEdit.TabIndex = 36
        Me.ChallanLookupGridLookUpEdit.Tag = "NR"
        '
        'PrintingDeliveryChallanLookupBindingSource
        '
        Me.PrintingDeliveryChallanLookupBindingSource.DataMember = "PrintingDeliveryChallanLookup"
        Me.PrintingDeliveryChallanLookupBindingSource.DataSource = Me.PrintingDeliveryChallanLookupDataSet
        '
        'PrintingDeliveryChallanLookupDataSet
        '
        Me.PrintingDeliveryChallanLookupDataSet.DataSetName = "PrintingDeliveryChallanLookupDataSet"
        Me.PrintingDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChallanNo, Me.colChallanDate})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colChallanNo
        '
        Me.colChallanNo.FieldName = "ChallanNo"
        Me.colChallanNo.Name = "colChallanNo"
        Me.colChallanNo.Visible = True
        Me.colChallanNo.VisibleIndex = 0
        '
        'colChallanDate
        '
        Me.colChallanDate.FieldName = "ChallanDate"
        Me.colChallanDate.Name = "colChallanDate"
        Me.colChallanDate.Visible = True
        Me.colChallanDate.VisibleIndex = 1
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(849, 6)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 47
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SewingDeliverySizeDetailsGridControl)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(1149, 379)
        Me.SplitContainer2.SplitterDistance = 382
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.PrintingDeliveryDetailsGridControl)
        Me.SplitContainer3.Panel1.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.SplitContainer3.Panel1.Controls.Add(OrderIdLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.GetButton)
        Me.SplitContainer3.Panel1.Controls.Add(Me.ProductionDateEdit)
        Me.SplitContainer3.Panel1.Controls.Add(Label2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.PrintingDeliverySizeDetailsGridControl)
        Me.SplitContainer3.Size = New System.Drawing.Size(1149, 379)
        Me.SplitContainer3.SplitterDistance = 817
        Me.SplitContainer3.TabIndex = 1
        '
        'PrintingDeliveryDetailsGridControl
        '
        Me.PrintingDeliveryDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintingDeliveryDetailsGridControl.DataSource = Me.PrintingDeliveryDetailsBindingSource
        Me.PrintingDeliveryDetailsGridControl.Location = New System.Drawing.Point(0, 31)
        Me.PrintingDeliveryDetailsGridControl.MainView = Me.GridView1
        Me.PrintingDeliveryDetailsGridControl.Name = "PrintingDeliveryDetailsGridControl"
        Me.PrintingDeliveryDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.PrintOrderLookupGridLookUpEdit})
        Me.PrintingDeliveryDetailsGridControl.Size = New System.Drawing.Size(817, 348)
        Me.PrintingDeliveryDetailsGridControl.TabIndex = 0
        Me.PrintingDeliveryDetailsGridControl.UseEmbeddedNavigator = True
        Me.PrintingDeliveryDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PrintingDeliveryDetailsBindingSource
        '
        Me.PrintingDeliveryDetailsBindingSource.DataMember = "FK_PrintingDeliveryDetails_PrintingDelivery"
        Me.PrintingDeliveryDetailsBindingSource.DataSource = Me.PrintingDeliveryBindingSource
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrintOrderid, Me.colDeliveryQuantity, Me.colDeliveryStatus, Me.colRemarks1})
        Me.GridView1.GridControl = Me.PrintingDeliveryDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colPrintOrderid
        '
        Me.colPrintOrderid.Caption = "Print Order Details"
        Me.colPrintOrderid.ColumnEdit = Me.PrintOrderLookupGridLookUpEdit
        Me.colPrintOrderid.FieldName = "PrintOrderid"
        Me.colPrintOrderid.Name = "colPrintOrderid"
        Me.colPrintOrderid.Visible = True
        Me.colPrintOrderid.VisibleIndex = 0
        '
        'PrintOrderLookupGridLookUpEdit
        '
        Me.PrintOrderLookupGridLookUpEdit.AutoHeight = False
        Me.PrintOrderLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintOrderLookupGridLookUpEdit.DataSource = Me.PrintOrderLookupNewBindingSource
        Me.PrintOrderLookupGridLookUpEdit.DisplayMember = "Details"
        Me.PrintOrderLookupGridLookUpEdit.Name = "PrintOrderLookupGridLookUpEdit"
        Me.PrintOrderLookupGridLookUpEdit.PopupView = Me.GridView6
        Me.PrintOrderLookupGridLookUpEdit.ValueMember = "PrintOrderId"
        '
        'PrintOrderLookupNewBindingSource
        '
        Me.PrintOrderLookupNewBindingSource.DataMember = "PrintOrderLookupNew"
        Me.PrintOrderLookupNewBindingSource.DataSource = Me.PrintProductionDataSet
        '
        'PrintProductionDataSet
        '
        Me.PrintProductionDataSet.DataSetName = "PrintProductionDataSet"
        Me.PrintProductionDataSet.EnforceConstraints = False
        Me.PrintProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'colDeliveryQuantity
        '
        Me.colDeliveryQuantity.FieldName = "DeliveryQuantity"
        Me.colDeliveryQuantity.Name = "colDeliveryQuantity"
        Me.colDeliveryQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DeliveryQuantity", "{0:0}")})
        Me.colDeliveryQuantity.Visible = True
        Me.colDeliveryQuantity.VisibleIndex = 1
        '
        'colDeliveryStatus
        '
        Me.colDeliveryStatus.FieldName = "DeliveryStatus"
        Me.colDeliveryStatus.Name = "colDeliveryStatus"
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 2
        '
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(463, 6)
        Me.OrderIdGridLookUpEdit.Name = "OrderIdGridLookUpEdit"
        Me.OrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderIdGridLookUpEdit.Properties.DataSource = Me.PrintOrderNewLookupBindingSource
        Me.OrderIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.OrderIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderIdGridLookUpEdit.Properties.NullText = ""
        Me.OrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderIdGridLookUpEdit.Properties.PopupView = Me.OrderIdGridLookUpEditView
        Me.OrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "PrintOrderNewId"
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(232, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 71
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
        'OrderIdGridLookUpEditView
        '
        Me.OrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.OrderIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.OrderIdGridLookUpEditView.Name = "OrderIdGridLookUpEditView"
        Me.OrderIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.OrderIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'GetButton
        '
        Me.GetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GetButton.Location = New System.Drawing.Point(701, 5)
        Me.GetButton.Name = "GetButton"
        Me.GetButton.Size = New System.Drawing.Size(63, 22)
        Me.GetButton.TabIndex = 5
        Me.GetButton.Tag = "NR"
        Me.GetButton.Text = "&Get"
        Me.GetButton.UseVisualStyleBackColor = True
        '
        'ProductionDateEdit
        '
        Me.ProductionDateEdit.EditValue = Nothing
        Me.ProductionDateEdit.Location = New System.Drawing.Point(113, 6)
        Me.ProductionDateEdit.Name = "ProductionDateEdit"
        Me.ProductionDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductionDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductionDateEdit.Size = New System.Drawing.Size(194, 20)
        Me.ProductionDateEdit.TabIndex = 60
        '
        'PrintingDeliverySizeDetailsGridControl
        '
        Me.PrintingDeliverySizeDetailsGridControl.DataSource = Me.PrintingDeliverySizeDetailsBindingSource
        Me.PrintingDeliverySizeDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintingDeliverySizeDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.PrintingDeliverySizeDetailsGridControl.MainView = Me.GridView3
        Me.PrintingDeliverySizeDetailsGridControl.Name = "PrintingDeliverySizeDetailsGridControl"
        Me.PrintingDeliverySizeDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeGridLookUpEdit1})
        Me.PrintingDeliverySizeDetailsGridControl.Size = New System.Drawing.Size(328, 379)
        Me.PrintingDeliverySizeDetailsGridControl.TabIndex = 0
        Me.PrintingDeliverySizeDetailsGridControl.UseEmbeddedNavigator = True
        Me.PrintingDeliverySizeDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'PrintingDeliverySizeDetailsBindingSource
        '
        Me.PrintingDeliverySizeDetailsBindingSource.DataMember = "PrintingDeliveryDetails_PrintingDeliverySizeDetails"
        Me.PrintingDeliverySizeDetailsBindingSource.DataSource = Me.PrintingDeliveryDetailsBindingSource
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeId1, Me.colDeliveryQuantity2, Me.colRemarks2})
        Me.GridView3.GridControl = Me.PrintingDeliverySizeDetailsGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colSizeId1
        '
        Me.colSizeId1.Caption = "Size"
        Me.colSizeId1.ColumnEdit = Me.SizeGridLookUpEdit1
        Me.colSizeId1.FieldName = "SizeId"
        Me.colSizeId1.Name = "colSizeId1"
        Me.colSizeId1.Visible = True
        Me.colSizeId1.VisibleIndex = 0
        Me.colSizeId1.Width = 92
        '
        'SizeGridLookUpEdit1
        '
        Me.SizeGridLookUpEdit1.AutoHeight = False
        Me.SizeGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeGridLookUpEdit1.DataSource = Me.SizeBindingSource
        Me.SizeGridLookUpEdit1.DisplayMember = "SizeCode"
        Me.SizeGridLookUpEdit1.Name = "SizeGridLookUpEdit1"
        Me.SizeGridLookUpEdit1.PopupView = Me.GridView7
        Me.SizeGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SizeGridLookUpEdit1.ValueMember = "SizeId"
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
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode1})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colSizeCode1
        '
        Me.colSizeCode1.FieldName = "SizeCode"
        Me.colSizeCode1.Name = "colSizeCode1"
        Me.colSizeCode1.Visible = True
        Me.colSizeCode1.VisibleIndex = 0
        '
        'colDeliveryQuantity2
        '
        Me.colDeliveryQuantity2.FieldName = "DeliveryQuantity"
        Me.colDeliveryQuantity2.Name = "colDeliveryQuantity2"
        Me.colDeliveryQuantity2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DeliveryQuantity", "{0:0}")})
        Me.colDeliveryQuantity2.Visible = True
        Me.colDeliveryQuantity2.VisibleIndex = 1
        '
        'colRemarks2
        '
        Me.colRemarks2.FieldName = "Remarks"
        Me.colRemarks2.Name = "colRemarks2"
        Me.colRemarks2.Visible = True
        Me.colRemarks2.VisibleIndex = 2
        '
        'SewingDeliverySizeDetailsGridControl
        '
        Me.SewingDeliverySizeDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingDeliverySizeDetailsGridControl.Location = New System.Drawing.Point(0, 33)
        Me.SewingDeliverySizeDetailsGridControl.MainView = Me.GridView2
        Me.SewingDeliverySizeDetailsGridControl.Name = "SewingDeliverySizeDetailsGridControl"
        Me.SewingDeliverySizeDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeGridLookUpEdit})
        Me.SewingDeliverySizeDetailsGridControl.Size = New System.Drawing.Size(732, 579)
        Me.SewingDeliverySizeDetailsGridControl.TabIndex = 0
        Me.SewingDeliverySizeDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView2.ColumnPanelRowHeight = 40
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeId, Me.colOrderQuantity, Me.colDeliveryQuantity1, Me.colRemarks})
        Me.GridView2.GridControl = Me.SewingDeliverySizeDetailsGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colSizeId
        '
        Me.colSizeId.Caption = "Size"
        Me.colSizeId.ColumnEdit = Me.SizeGridLookUpEdit
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        Me.colSizeId.Visible = True
        Me.colSizeId.VisibleIndex = 0
        Me.colSizeId.Width = 87
        '
        'SizeGridLookUpEdit
        '
        Me.SizeGridLookUpEdit.AutoHeight = False
        Me.SizeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeGridLookUpEdit.Name = "SizeGridLookUpEdit"
        Me.SizeGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.SizeGridLookUpEdit.ValueMember = "SizeId"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 1
        Me.colOrderQuantity.Width = 87
        '
        'colDeliveryQuantity1
        '
        Me.colDeliveryQuantity1.FieldName = "DeliveryQuantity"
        Me.colDeliveryQuantity1.Name = "colDeliveryQuantity1"
        Me.colDeliveryQuantity1.Visible = True
        Me.colDeliveryQuantity1.VisibleIndex = 2
        Me.colDeliveryQuantity1.Width = 94
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 3
        Me.colRemarks.Width = 163
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(649, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 24)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "&Get Size"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SizeLookupBindingSource
        '
        Me.SizeLookupBindingSource.DataMember = "SizeLookup"
        Me.SizeLookupBindingSource.DataSource = Me.SizeLookupDataSet
        '
        'SizeLookupDataSet
        '
        Me.SizeLookupDataSet.DataSetName = "SizeLookupDataSet"
        Me.SizeLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PrintingDeliveryTableAdapter
        '
        Me.PrintingDeliveryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PrintingDeliveryDetailsTableAdapter = Me.PrintingDeliveryDetailsTableAdapter
        Me.TableAdapterManager.PrintingDeliverySizeDetailsTableAdapter = Me.PrintingDeliverySizeDetailsTableAdapter
        Me.TableAdapterManager.PrintingDeliveryTableAdapter = Me.PrintingDeliveryTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PrintingDeliveryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintingDeliveryDetailsTableAdapter
        '
        Me.PrintingDeliveryDetailsTableAdapter.ClearBeforeFill = True
        '
        'PrintingDeliverySizeDetailsTableAdapter
        '
        Me.PrintingDeliverySizeDetailsTableAdapter.ClearBeforeFill = True
        '
        'SupplierLookupTableAdapter
        '
        Me.SupplierLookupTableAdapter.ClearBeforeFill = True
        '
        'SizeLookupTableAdapter
        '
        Me.SizeLookupTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'LineDataSet
        '
        Me.LineDataSet.DataSetName = "LineDataSet"
        Me.LineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineBindingSource
        '
        Me.LineBindingSource.DataMember = "Line"
        Me.LineBindingSource.DataSource = Me.LineDataSet
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'PrintingDeliveryChallanLookupTableAdapter
        '
        Me.PrintingDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'SizeTableAdapter
        '
        Me.SizeTableAdapter.ClearBeforeFill = True
        '
        'PrintOrderLookupNewTableAdapter
        '
        Me.PrintOrderLookupNewTableAdapter.ClearBeforeFill = True
        '
        'PrintOrderNewLookupTableAdapter
        '
        Me.PrintOrderNewLookupTableAdapter.ClearBeforeFill = True
        '
        'frmPrintDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 606)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmPrintDelivery"
        Me.Text = "Printing Delivery Challan"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingDeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingDeliveryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.ChallanLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.PrintingDeliveryDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingDeliveryDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderLookupNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintOrderNewLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingDeliverySizeDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingDeliverySizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDeliverySizeDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents NewButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents CancelEntryButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ChallanLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ShowButton As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SewingDeliverySizeDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintingDeliveryDataSet As PrintingDeliveryDataSet
    Friend WithEvents PrintingDeliveryBindingSource As BindingSource
    Friend WithEvents PrintingDeliveryTableAdapter As PrintingDeliveryDataSetTableAdapters.PrintingDeliveryTableAdapter
    Friend WithEvents TableAdapterManager As PrintingDeliveryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrintingDeliveryDetailsTableAdapter As PrintingDeliveryDataSetTableAdapters.PrintingDeliveryDetailsTableAdapter
    Friend WithEvents SupplierLookupBindingSource As BindingSource
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents SupplierLookupTableAdapter As SupplierDataSetTableAdapters.SupplierLookupTableAdapter
    Friend WithEvents SizeLookupDataSet As SizeLookupDataSet
    Friend WithEvents SizeLookupBindingSource As BindingSource
    Friend WithEvents SizeLookupTableAdapter As SizeLookupDataSetTableAdapters.SizeLookupTableAdapter
    Friend WithEvents BranchDataSet As BranchDataSet
    Friend WithEvents BranchBindingSource As BindingSource
    Friend WithEvents BranchTableAdapter As BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents PrintingDeliveryDetailsBindingSource As BindingSource
    Friend WithEvents PrintingDeliveryDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBranchName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents OrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AttentionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChallanDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ChallanNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colPrintOrderid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LineDataSet As LineDataSet
    Friend WithEvents LineBindingSource As BindingSource
    Friend WithEvents LineTableAdapter As LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents PrintingDeliveryChallanLookupDataSet As PrintingDeliveryChallanLookupDataSet
    Friend WithEvents PrintingDeliveryChallanLookupBindingSource As BindingSource
    Friend WithEvents PrintingDeliveryChallanLookupTableAdapter As PrintingDeliveryChallanLookupDataSetTableAdapters.PrintingDeliveryChallanLookupTableAdapter
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents PrintingDeliverySizeDetailsBindingSource As BindingSource
    Friend WithEvents PrintingDeliverySizeDetailsTableAdapter As PrintingDeliveryDataSetTableAdapters.PrintingDeliverySizeDetailsTableAdapter
    Friend WithEvents PrintingDeliverySizeDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryQuantity2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintOrderLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintProductionDataSet As PrintProductionDataSet
    Friend WithEvents SizeGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeDataSet As SizeDataSet
    Friend WithEvents SizeBindingSource As BindingSource
    Friend WithEvents SizeTableAdapter As SizeDataSetTableAdapters.SizeTableAdapter
    Friend WithEvents colSizeCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GetButton As Button
    Friend WithEvents ProductionDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PrintOrderLookupNewBindingSource As BindingSource
    Friend WithEvents PrintOrderLookupNewTableAdapter As PrintProductionDataSetTableAdapters.PrintOrderLookupNewTableAdapter
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintOrderNewLookupDataSet As PrintOrderNewLookupDataSet
    Friend WithEvents PrintOrderNewLookupBindingSource As BindingSource
    Friend WithEvents PrintOrderNewLookupTableAdapter As PrintOrderNewLookupDataSetTableAdapters.PrintOrderNewLookupTableAdapter
End Class
