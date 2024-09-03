<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSewingDelivery
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
        Dim ChallanNoLabel As System.Windows.Forms.Label
        Dim ChallanDateLabel As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim AttentionLabel As System.Windows.Forms.Label
        Dim LineIdLabel As System.Windows.Forms.Label
        Dim OrderIdLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SewingDeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingDeliveryDataSet = New KSoft_Apparel.SewingDeliveryDataSet()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBranchName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.OrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChallanLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SewingDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingDeliveryChallanLookupDataSet = New KSoft_Apparel.SewingDeliveryChallanLookupDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colChallanNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChallanDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.LineIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineDataSet = New KSoft_Apparel.LineDataSet()
        Me.LineIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLine = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SewingDeliveryDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.SewingDeliveryDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderDetailsGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.OrderPOLookupNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPOLookupNewDataSet = New KSoft_Apparel.OrderPOLookupNewDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPOAndColorAndDes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SewingDeliverySizeDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.SewingDeliverySizeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeLookupDataSet = New KSoft_Apparel.SizeLookupDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SewingDeliveryTableAdapter = New KSoft_Apparel.SewingDeliveryDataSetTableAdapters.SewingDeliveryTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SewingDeliveryDataSetTableAdapters.TableAdapterManager()
        Me.SewingDeliveryDetailsTableAdapter = New KSoft_Apparel.SewingDeliveryDataSetTableAdapters.SewingDeliveryDetailsTableAdapter()
        Me.SewingDeliverySizeDetailsTableAdapter = New KSoft_Apparel.SewingDeliveryDataSetTableAdapters.SewingDeliverySizeDetailsTableAdapter()
        Me.SewingDeliveryChallanLookupTableAdapter = New KSoft_Apparel.SewingDeliveryChallanLookupDataSetTableAdapters.SewingDeliveryChallanLookupTableAdapter()
        Me.SupplierLookupTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierLookupTableAdapter()
        Me.SizeLookupTableAdapter = New KSoft_Apparel.SizeLookupDataSetTableAdapters.SizeLookupTableAdapter()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
        Me.OrderPOLookupNewTableAdapter = New KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupNewTableAdapter()
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        ChallanNoLabel = New System.Windows.Forms.Label()
        ChallanDateLabel = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        AttentionLabel = New System.Windows.Forms.Label()
        LineIdLabel = New System.Windows.Forms.Label()
        OrderIdLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDeliveryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.ChallanLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SewingDeliveryDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDeliveryDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDeliverySizeDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDeliverySizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChallanNoLabel
        '
        ChallanNoLabel.AutoSize = True
        ChallanNoLabel.Location = New System.Drawing.Point(21, 60)
        ChallanNoLabel.Name = "ChallanNoLabel"
        ChallanNoLabel.Size = New System.Drawing.Size(62, 13)
        ChallanNoLabel.TabIndex = 0
        ChallanNoLabel.Text = "Challan No:"
        '
        'ChallanDateLabel
        '
        ChallanDateLabel.AutoSize = True
        ChallanDateLabel.Location = New System.Drawing.Point(21, 86)
        ChallanDateLabel.Name = "ChallanDateLabel"
        ChallanDateLabel.Size = New System.Drawing.Size(71, 13)
        ChallanDateLabel.TabIndex = 2
        ChallanDateLabel.Text = "Challan Date:"
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(21, 111)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(67, 13)
        SupplierIdLabel.TabIndex = 4
        SupplierIdLabel.Text = "Delivery To :"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(20, 159)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 6
        RemarksLabel.Text = "Remarks:"
        '
        'AttentionLabel
        '
        AttentionLabel.AutoSize = True
        AttentionLabel.Location = New System.Drawing.Point(312, 60)
        AttentionLabel.Name = "AttentionLabel"
        AttentionLabel.Size = New System.Drawing.Size(52, 13)
        AttentionLabel.TabIndex = 8
        AttentionLabel.Text = "Attention:"
        '
        'LineIdLabel
        '
        LineIdLabel.AutoSize = True
        LineIdLabel.Location = New System.Drawing.Point(312, 110)
        LineIdLabel.Name = "LineIdLabel"
        LineIdLabel.Size = New System.Drawing.Size(59, 13)
        LineIdLabel.TabIndex = 53
        LineIdLabel.Text = "From Line :"
        '
        'OrderIdLabel
        '
        OrderIdLabel.AutoSize = True
        OrderIdLabel.Location = New System.Drawing.Point(312, 86)
        OrderIdLabel.Name = "OrderIdLabel"
        OrderIdLabel.Size = New System.Drawing.Size(87, 13)
        OrderIdLabel.TabIndex = 54
        OrderIdLabel.Text = "Program :: Style :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(21, 135)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(86, 13)
        Label1.TabIndex = 4
        Label1.Text = "For Department :"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(OrderIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(LineIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LineIdGridLookUpEdit)
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
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1121, 626)
        Me.SplitContainer1.SplitterDistance = 197
        Me.SplitContainer1.TabIndex = 0
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SewingDeliveryBindingSource, "BranchId", True))
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(109, 132)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.BranchBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "BranchName"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridView5
        Me.GridLookUpEdit1.Properties.ValueMember = "BranchId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(194, 20)
        Me.GridLookUpEdit1.TabIndex = 56
        '
        'SewingDeliveryBindingSource
        '
        Me.SewingDeliveryBindingSource.DataMember = "SewingDelivery"
        Me.SewingDeliveryBindingSource.DataSource = Me.SewingDeliveryDataSet
        '
        'SewingDeliveryDataSet
        '
        Me.SewingDeliveryDataSet.DataSetName = "SewingDeliveryDataSet"
        Me.SewingDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SewingDeliveryBindingSource, "OrderId", True))
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(405, 83)
        Me.OrderIdGridLookUpEdit.Name = "OrderIdGridLookUpEdit"
        Me.OrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderIdGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.OrderIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderIdGridLookUpEdit.Properties.NullText = ""
        Me.OrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderIdGridLookUpEdit.Properties.PopupView = Me.OrderIdGridLookUpEditView
        Me.OrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(168, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 55
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1121, 35)
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
        Me.Label3.Text = "Challan No :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChallanLookupGridLookUpEdit
        '
        Me.ChallanLookupGridLookUpEdit.EditValue = "[Select your Program]"
        Me.ChallanLookupGridLookUpEdit.Location = New System.Drawing.Point(592, 7)
        Me.ChallanLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.ChallanLookupGridLookUpEdit.Name = "ChallanLookupGridLookUpEdit"
        Me.ChallanLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanLookupGridLookUpEdit.Properties.DataSource = Me.SewingDeliveryChallanLookupBindingSource
        Me.ChallanLookupGridLookUpEdit.Properties.DisplayMember = "ChallanNo"
        Me.ChallanLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ChallanLookupGridLookUpEdit.Properties.NullText = "Select your Program"
        Me.ChallanLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ChallanLookupGridLookUpEdit.Properties.PopupView = Me.GridView4
        Me.ChallanLookupGridLookUpEdit.Properties.Tag = "NR"
        Me.ChallanLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ChallanLookupGridLookUpEdit.Properties.ValueMember = "SewingDeliveryId"
        Me.ChallanLookupGridLookUpEdit.Size = New System.Drawing.Size(251, 20)
        Me.ChallanLookupGridLookUpEdit.TabIndex = 36
        Me.ChallanLookupGridLookUpEdit.Tag = "NR"
        '
        'SewingDeliveryChallanLookupBindingSource
        '
        Me.SewingDeliveryChallanLookupBindingSource.DataMember = "SewingDeliveryChallanLookup"
        Me.SewingDeliveryChallanLookupBindingSource.DataSource = Me.SewingDeliveryChallanLookupDataSet
        '
        'SewingDeliveryChallanLookupDataSet
        '
        Me.SewingDeliveryChallanLookupDataSet.DataSetName = "SewingDeliveryChallanLookupDataSet"
        Me.SewingDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'LineIdGridLookUpEdit
        '
        Me.LineIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SewingDeliveryBindingSource, "LineId", True))
        Me.LineIdGridLookUpEdit.Location = New System.Drawing.Point(405, 108)
        Me.LineIdGridLookUpEdit.Name = "LineIdGridLookUpEdit"
        Me.LineIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LineIdGridLookUpEdit.Properties.DataSource = Me.LineBindingSource
        Me.LineIdGridLookUpEdit.Properties.DisplayMember = "Line"
        Me.LineIdGridLookUpEdit.Properties.NullText = ""
        Me.LineIdGridLookUpEdit.Properties.PopupView = Me.LineIdGridLookUpEditView
        Me.LineIdGridLookUpEdit.Properties.ValueMember = "LineId"
        Me.LineIdGridLookUpEdit.Size = New System.Drawing.Size(168, 20)
        Me.LineIdGridLookUpEdit.TabIndex = 54
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
        'LineIdGridLookUpEditView
        '
        Me.LineIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLine})
        Me.LineIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.LineIdGridLookUpEditView.Name = "LineIdGridLookUpEditView"
        Me.LineIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.LineIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colLine
        '
        Me.colLine.FieldName = "Line"
        Me.colLine.Name = "colLine"
        Me.colLine.Visible = True
        Me.colLine.VisibleIndex = 0
        '
        'AttentionTextEdit
        '
        Me.AttentionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SewingDeliveryBindingSource, "Attention", True))
        Me.AttentionTextEdit.Location = New System.Drawing.Point(405, 57)
        Me.AttentionTextEdit.Name = "AttentionTextEdit"
        Me.AttentionTextEdit.Size = New System.Drawing.Size(168, 20)
        Me.AttentionTextEdit.TabIndex = 9
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SewingDeliveryBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(109, 156)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(464, 20)
        Me.RemarksTextEdit.TabIndex = 7
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SewingDeliveryBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(109, 108)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierLookupBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierIdGridLookUpEdit.Properties.PopupView = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(194, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 5
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
        Me.ChallanDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SewingDeliveryBindingSource, "ChallanDate", True))
        Me.ChallanDateDateEdit.EditValue = Nothing
        Me.ChallanDateDateEdit.Location = New System.Drawing.Point(109, 83)
        Me.ChallanDateDateEdit.Name = "ChallanDateDateEdit"
        Me.ChallanDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanDateDateEdit.Size = New System.Drawing.Size(194, 20)
        Me.ChallanDateDateEdit.TabIndex = 3
        '
        'ChallanNoTextEdit
        '
        Me.ChallanNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SewingDeliveryBindingSource, "ChallanNo", True))
        Me.ChallanNoTextEdit.Location = New System.Drawing.Point(109, 57)
        Me.ChallanNoTextEdit.Name = "ChallanNoTextEdit"
        Me.ChallanNoTextEdit.Properties.ReadOnly = True
        Me.ChallanNoTextEdit.Size = New System.Drawing.Size(194, 20)
        Me.ChallanNoTextEdit.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SewingDeliveryDetailsGridControl)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SewingDeliverySizeDetailsGridControl)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(1121, 425)
        Me.SplitContainer2.SplitterDistance = 382
        Me.SplitContainer2.TabIndex = 0
        '
        'SewingDeliveryDetailsGridControl
        '
        Me.SewingDeliveryDetailsGridControl.DataSource = Me.SewingDeliveryDetailsBindingSource
        Me.SewingDeliveryDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SewingDeliveryDetailsGridControl.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.SewingDeliveryDetailsGridControl.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.SewingDeliveryDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.SewingDeliveryDetailsGridControl.MainView = Me.GridView1
        Me.SewingDeliveryDetailsGridControl.Name = "SewingDeliveryDetailsGridControl"
        Me.SewingDeliveryDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.OrderDetailsGridLookUpEdit})
        Me.SewingDeliveryDetailsGridControl.Size = New System.Drawing.Size(1121, 425)
        Me.SewingDeliveryDetailsGridControl.TabIndex = 0
        Me.SewingDeliveryDetailsGridControl.UseEmbeddedNavigator = True
        Me.SewingDeliveryDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SewingDeliveryDetailsBindingSource
        '
        Me.SewingDeliveryDetailsBindingSource.DataMember = "FK_SewingDeliveryDetails_SewingDelivery"
        Me.SewingDeliveryDetailsBindingSource.DataSource = Me.SewingDeliveryBindingSource
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderDetailsId, Me.colDeliveryQuantity, Me.colRemarks1})
        Me.GridView1.GridControl = Me.SewingDeliveryDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOrderDetailsId
        '
        Me.colOrderDetailsId.Caption = "Order Details"
        Me.colOrderDetailsId.ColumnEdit = Me.OrderDetailsGridLookUpEdit
        Me.colOrderDetailsId.FieldName = "OrderDetailsId"
        Me.colOrderDetailsId.Name = "colOrderDetailsId"
        Me.colOrderDetailsId.OptionsColumn.AllowEdit = False
        Me.colOrderDetailsId.OptionsColumn.ReadOnly = True
        Me.colOrderDetailsId.Visible = True
        Me.colOrderDetailsId.VisibleIndex = 0
        Me.colOrderDetailsId.Width = 216
        '
        'OrderDetailsGridLookUpEdit
        '
        Me.OrderDetailsGridLookUpEdit.AutoHeight = False
        Me.OrderDetailsGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderDetailsGridLookUpEdit.DataSource = Me.OrderPOLookupNewBindingSource
        Me.OrderDetailsGridLookUpEdit.DisplayMember = "POAndColorAndDes"
        Me.OrderDetailsGridLookUpEdit.Name = "OrderDetailsGridLookUpEdit"
        Me.OrderDetailsGridLookUpEdit.PopupView = Me.GridView3
        Me.OrderDetailsGridLookUpEdit.ValueMember = "OrderDetailsId"
        '
        'OrderPOLookupNewBindingSource
        '
        Me.OrderPOLookupNewBindingSource.DataMember = "OrderPOLookupNew"
        Me.OrderPOLookupNewBindingSource.DataSource = Me.OrderPOLookupNewDataSet
        '
        'OrderPOLookupNewDataSet
        '
        Me.OrderPOLookupNewDataSet.DataSetName = "OrderPOLookupNewDataSet"
        Me.OrderPOLookupNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPOAndColorAndDes})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colPOAndColorAndDes
        '
        Me.colPOAndColorAndDes.FieldName = "POAndColorAndDes"
        Me.colPOAndColorAndDes.Name = "colPOAndColorAndDes"
        Me.colPOAndColorAndDes.Visible = True
        Me.colPOAndColorAndDes.VisibleIndex = 0
        '
        'colDeliveryQuantity
        '
        Me.colDeliveryQuantity.FieldName = "DeliveryQuantity"
        Me.colDeliveryQuantity.Name = "colDeliveryQuantity"
        Me.colDeliveryQuantity.OptionsColumn.AllowEdit = False
        Me.colDeliveryQuantity.OptionsColumn.ReadOnly = True
        Me.colDeliveryQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DeliveryQuantity", "{0:0}")})
        Me.colDeliveryQuantity.Visible = True
        Me.colDeliveryQuantity.VisibleIndex = 1
        Me.colDeliveryQuantity.Width = 107
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 2
        Me.colRemarks1.Width = 309
        '
        'SewingDeliverySizeDetailsGridControl
        '
        Me.SewingDeliverySizeDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingDeliverySizeDetailsGridControl.DataSource = Me.SewingDeliverySizeDetailsBindingSource
        Me.SewingDeliverySizeDetailsGridControl.Location = New System.Drawing.Point(0, 33)
        Me.SewingDeliverySizeDetailsGridControl.MainView = Me.GridView2
        Me.SewingDeliverySizeDetailsGridControl.Name = "SewingDeliverySizeDetailsGridControl"
        Me.SewingDeliverySizeDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeGridLookUpEdit})
        Me.SewingDeliverySizeDetailsGridControl.Size = New System.Drawing.Size(732, 579)
        Me.SewingDeliverySizeDetailsGridControl.TabIndex = 0
        Me.SewingDeliverySizeDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'SewingDeliverySizeDetailsBindingSource
        '
        Me.SewingDeliverySizeDetailsBindingSource.DataMember = "FK_SewingDeliverySizeDetails_SewingDeliveryDetails"
        Me.SewingDeliverySizeDetailsBindingSource.DataSource = Me.SewingDeliveryDetailsBindingSource
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
        Me.SizeGridLookUpEdit.DataSource = Me.SizeLookupBindingSource
        Me.SizeGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeGridLookUpEdit.Name = "SizeGridLookUpEdit"
        Me.SizeGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.SizeGridLookUpEdit.ValueMember = "SizeId"
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
        'SewingDeliveryTableAdapter
        '
        Me.SewingDeliveryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SewingDeliveryDetailsTableAdapter = Me.SewingDeliveryDetailsTableAdapter
        Me.TableAdapterManager.SewingDeliverySizeDetailsTableAdapter = Me.SewingDeliverySizeDetailsTableAdapter
        Me.TableAdapterManager.SewingDeliveryTableAdapter = Me.SewingDeliveryTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SewingDeliveryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingDeliveryDetailsTableAdapter
        '
        Me.SewingDeliveryDetailsTableAdapter.ClearBeforeFill = True
        '
        'SewingDeliverySizeDetailsTableAdapter
        '
        Me.SewingDeliverySizeDetailsTableAdapter.ClearBeforeFill = True
        '
        'SewingDeliveryChallanLookupTableAdapter
        '
        Me.SewingDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'SupplierLookupTableAdapter
        '
        Me.SupplierLookupTableAdapter.ClearBeforeFill = True
        '
        'SizeLookupTableAdapter
        '
        Me.SizeLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'OrderPOLookupNewTableAdapter
        '
        Me.OrderPOLookupNewTableAdapter.ClearBeforeFill = True
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'frmSewingDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 626)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmSewingDelivery"
        Me.Text = "Sewing Delivery Challan"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDeliveryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.ChallanLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SewingDeliveryDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDeliveryDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDeliverySizeDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDeliverySizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SewingDeliveryDataSet As SewingDeliveryDataSet
    Friend WithEvents SewingDeliveryBindingSource As BindingSource
    Friend WithEvents SewingDeliveryTableAdapter As SewingDeliveryDataSetTableAdapters.SewingDeliveryTableAdapter
    Friend WithEvents TableAdapterManager As SewingDeliveryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AttentionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ChallanDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ChallanNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SewingDeliveryDetailsTableAdapter As SewingDeliveryDataSetTableAdapters.SewingDeliveryDetailsTableAdapter
    Friend WithEvents SewingDeliveryDetailsBindingSource As BindingSource
    Friend WithEvents SewingDeliveryDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SewingDeliverySizeDetailsTableAdapter As SewingDeliveryDataSetTableAdapters.SewingDeliverySizeDetailsTableAdapter
    Friend WithEvents SewingDeliverySizeDetailsBindingSource As BindingSource
    Friend WithEvents SewingDeliverySizeDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents SewingDeliveryChallanLookupDataSet As SewingDeliveryChallanLookupDataSet
    Friend WithEvents SewingDeliveryChallanLookupBindingSource As BindingSource
    Friend WithEvents SewingDeliveryChallanLookupTableAdapter As SewingDeliveryChallanLookupDataSetTableAdapters.SewingDeliveryChallanLookupTableAdapter
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents SupplierLookupBindingSource As BindingSource
    Friend WithEvents SupplierLookupTableAdapter As SupplierDataSetTableAdapters.SupplierLookupTableAdapter
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderDetailsGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SizeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents SizeLookupBindingSource As BindingSource
    Friend WithEvents SizeLookupDataSet As SizeLookupDataSet
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeLookupTableAdapter As SizeLookupDataSetTableAdapters.SizeLookupTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents LineIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents LineIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents OrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LineDataSet As LineDataSet
    Friend WithEvents LineBindingSource As BindingSource
    Friend WithEvents LineTableAdapter As LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents colLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChallanDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderPOLookupNewDataSet As OrderPOLookupNewDataSet
    Friend WithEvents OrderPOLookupNewBindingSource As BindingSource
    Friend WithEvents OrderPOLookupNewTableAdapter As OrderPOLookupNewDataSetTableAdapters.OrderPOLookupNewTableAdapter
    Friend WithEvents colPOAndColorAndDes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchDataSet As BranchDataSet
    Friend WithEvents BranchBindingSource As BindingSource
    Friend WithEvents BranchTableAdapter As BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents colBranchName As DevExpress.XtraGrid.Columns.GridColumn
End Class
