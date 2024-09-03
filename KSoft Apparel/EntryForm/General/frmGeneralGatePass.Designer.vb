<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneralGatePass
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
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim AttentionLabel As System.Windows.Forms.Label
        Dim PurposeLabel As System.Windows.Forms.Label
        Dim ResponsiblePersonLabel As System.Windows.Forms.Label
        Dim GatePassNoLabel As System.Windows.Forms.Label
        Dim GatePaseDateLabel As System.Windows.Forms.Label
        Dim ChallanDateLabel As System.Windows.Forms.Label
        Dim VehicleNoLabel As System.Windows.Forms.Label
        Dim DriversNameLabel As System.Windows.Forms.Label
        Dim DriversMobileNoLabel As System.Windows.Forms.Label
        Dim DrivingLicenceNoLabel As System.Windows.Forms.Label
        Dim LockNoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GeneralGatePassDataSet = New KSoft_Apparel.GeneralGatePassDataSet()
        Me.GeneralGatePassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralGatePassTableAdapter = New KSoft_Apparel.GeneralGatePassDataSetTableAdapters.GeneralGatePassTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.GeneralGatePassDataSetTableAdapters.TableAdapterManager()
        Me.GeneralGatePassDetailsTableAdapter = New KSoft_Apparel.GeneralGatePassDataSetTableAdapters.GeneralGatePassDetailsTableAdapter()
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.AttentionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PurposeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ResponsiblePersonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GatePassNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GatePaseDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ChallanLookupIssuedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChallanLookupIssuedDataSet = New KSoft_Apparel.ChallanLookupIssuedDataSet()
        Me.GeneralGatePassDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralGatePassDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Apparel.ItemListDataSet()
        Me.ChallanDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.ChallanLookupIssuedIssueTableAdapter = New KSoft_Apparel.ChallanLookupIssuedDataSetTableAdapters.ChallanLookupIssuedIssueTableAdapter()
        Me.ChallanLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ItemListLookupTableAdapter = New KSoft_Apparel.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.GGatePassLookupDataSet = New KSoft_Apparel.GGatePassLookupDataSet()
        Me.GGatePassLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GGatePassLookupTableAdapter = New KSoft_Apparel.GGatePassLookupDataSetTableAdapters.GGatePassLookupTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Apparel.GGatePassLookupDataSetTableAdapters.TableAdapterManager()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GGatePassLookupBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGatePassNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGatePaseDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VehicleNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DriversNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DriversMobileNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ChallanNoGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ChallanNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GreigeFabricDeliveryChallanLookupDataSet = New KSoft_Apparel.GreigeFabricDeliveryChallanLookupDataSet()
        Me.GreyFabricDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GreyFabricDeliveryChallanLookupTableAdapter = New KSoft_Apparel.GreigeFabricDeliveryChallanLookupDataSetTableAdapters.GreyFabricDeliveryChallanLookupTableAdapter()
        Me.FinishFabricDeliveryChallanLookupDataSet = New KSoft_Apparel.FinishFabricDeliveryChallanLookupDataSet()
        Me.FinishFabricDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinishFabricDeliveryChallanLookupTableAdapter = New KSoft_Apparel.FinishFabricDeliveryChallanLookupDataSetTableAdapters.FinishFabricDeliveryChallanLookupTableAdapter()
        Me.GFIDeliveryDataSet = New KSoft_Apparel.GFIDeliveryDataSet()
        Me.GFIDeliveryLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GFIDeliveryLookupTableAdapter = New KSoft_Apparel.GFIDeliveryDataSetTableAdapters.GFIDeliveryLookupTableAdapter()
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.DrivingLicenceNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LockNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MiscChallanLookupDataSet = New KSoft_Apparel.MiscChallanLookupDataSet()
        Me.MiscChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiscChallanLookupTableAdapter = New KSoft_Apparel.MiscChallanLookupDataSetTableAdapters.MiscChallanLookupTableAdapter()
        Me.DeliveryChallanLookUpDataSet = New KSoft_Apparel.DeliveryChallanLookUpDataSet()
        Me.DeliveryChallanLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryChallanLookUpTableAdapter = New KSoft_Apparel.DeliveryChallanLookUpDataSetTableAdapters.DeliveryChallanLookUpTableAdapter()
        Me.TableAdapterManager2 = New KSoft_Apparel.DeliveryChallanLookUpDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CuttingDeliveryChallanLookupDataSet = New KSoft_Apparel.CuttingDeliveryChallanLookupDataSet()
        Me.CuttingDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingDeliveryChallanLookupTableAdapter = New KSoft_Apparel.CuttingDeliveryChallanLookupDataSetTableAdapters.CuttingDeliveryChallanLookupTableAdapter()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.SewingDeliveryChallanLookupDataSet = New KSoft_Apparel.SewingDeliveryChallanLookupDataSet()
        Me.SewingDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingDeliveryChallanLookupTableAdapter = New KSoft_Apparel.SewingDeliveryChallanLookupDataSetTableAdapters.SewingDeliveryChallanLookupTableAdapter()
        Me.EmbDeliveryChallanLookupDataSet = New KSoft_Apparel.EmbDeliveryChallanLookupDataSet()
        Me.EmbDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmbDeliveryChallanLookupTableAdapter = New KSoft_Apparel.EmbDeliveryChallanLookupDataSetTableAdapters.EmbDeliveryChallanLookupTableAdapter()
        Me.PrintingDeliveryChallanLookupDataSet = New KSoft_Apparel.PrintingDeliveryChallanLookupDataSet()
        Me.PrintingDeliveryChallanLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintingDeliveryChallanLookupTableAdapter = New KSoft_Apparel.PrintingDeliveryChallanLookupDataSetTableAdapters.PrintingDeliveryChallanLookupTableAdapter()
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        SupplierIdLabel = New System.Windows.Forms.Label()
        AttentionLabel = New System.Windows.Forms.Label()
        PurposeLabel = New System.Windows.Forms.Label()
        ResponsiblePersonLabel = New System.Windows.Forms.Label()
        GatePassNoLabel = New System.Windows.Forms.Label()
        GatePaseDateLabel = New System.Windows.Forms.Label()
        ChallanDateLabel = New System.Windows.Forms.Label()
        VehicleNoLabel = New System.Windows.Forms.Label()
        DriversNameLabel = New System.Windows.Forms.Label()
        DriversMobileNoLabel = New System.Windows.Forms.Label()
        DrivingLicenceNoLabel = New System.Windows.Forms.Label()
        LockNoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralGatePassDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralGatePassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurposeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResponsiblePersonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePaseDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePaseDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanLookupIssuedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanLookupIssuedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralGatePassDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralGatePassDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GGatePassLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GGatePassLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GGatePassLookupBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriversNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriversMobileNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanNoGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreigeFabricDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreyFabricDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFIDeliveryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFIDeliveryLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrivingLicenceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LockNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiscChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryChallanLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryChallanLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SewingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(312, 57)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(74, 13)
        SupplierIdLabel.TabIndex = 3
        SupplierIdLabel.Text = "Delivered To :"
        '
        'AttentionLabel
        '
        AttentionLabel.AutoSize = True
        AttentionLabel.Location = New System.Drawing.Point(312, 83)
        AttentionLabel.Name = "AttentionLabel"
        AttentionLabel.Size = New System.Drawing.Size(52, 13)
        AttentionLabel.TabIndex = 5
        AttentionLabel.Text = "Attention:"
        '
        'PurposeLabel
        '
        PurposeLabel.AutoSize = True
        PurposeLabel.Location = New System.Drawing.Point(312, 109)
        PurposeLabel.Name = "PurposeLabel"
        PurposeLabel.Size = New System.Drawing.Size(49, 13)
        PurposeLabel.TabIndex = 7
        PurposeLabel.Text = "Purpose:"
        '
        'ResponsiblePersonLabel
        '
        ResponsiblePersonLabel.AutoSize = True
        ResponsiblePersonLabel.Location = New System.Drawing.Point(312, 135)
        ResponsiblePersonLabel.Name = "ResponsiblePersonLabel"
        ResponsiblePersonLabel.Size = New System.Drawing.Size(104, 13)
        ResponsiblePersonLabel.TabIndex = 9
        ResponsiblePersonLabel.Text = "Responsible Person:"
        '
        'GatePassNoLabel
        '
        GatePassNoLabel.AutoSize = True
        GatePassNoLabel.Location = New System.Drawing.Point(15, 57)
        GatePassNoLabel.Name = "GatePassNoLabel"
        GatePassNoLabel.Size = New System.Drawing.Size(76, 13)
        GatePassNoLabel.TabIndex = 11
        GatePassNoLabel.Text = "Gate Pass No:"
        '
        'GatePaseDateLabel
        '
        GatePaseDateLabel.AutoSize = True
        GatePaseDateLabel.Location = New System.Drawing.Point(15, 83)
        GatePaseDateLabel.Name = "GatePaseDateLabel"
        GatePaseDateLabel.Size = New System.Drawing.Size(86, 13)
        GatePaseDateLabel.TabIndex = 13
        GatePaseDateLabel.Text = "Gate Pase Date:"
        '
        'ChallanDateLabel
        '
        ChallanDateLabel.AutoSize = True
        ChallanDateLabel.Location = New System.Drawing.Point(15, 135)
        ChallanDateLabel.Name = "ChallanDateLabel"
        ChallanDateLabel.Size = New System.Drawing.Size(71, 13)
        ChallanDateLabel.TabIndex = 17
        ChallanDateLabel.Text = "Challan Date:"
        '
        'VehicleNoLabel
        '
        VehicleNoLabel.AutoSize = True
        VehicleNoLabel.Location = New System.Drawing.Point(723, 57)
        VehicleNoLabel.Name = "VehicleNoLabel"
        VehicleNoLabel.Size = New System.Drawing.Size(62, 13)
        VehicleNoLabel.TabIndex = 25
        VehicleNoLabel.Text = "Vehicle No:"
        '
        'DriversNameLabel
        '
        DriversNameLabel.AutoSize = True
        DriversNameLabel.Location = New System.Drawing.Point(723, 83)
        DriversNameLabel.Name = "DriversNameLabel"
        DriversNameLabel.Size = New System.Drawing.Size(74, 13)
        DriversNameLabel.TabIndex = 26
        DriversNameLabel.Text = "Drivers Name:"
        '
        'DriversMobileNoLabel
        '
        DriversMobileNoLabel.AutoSize = True
        DriversMobileNoLabel.Location = New System.Drawing.Point(723, 109)
        DriversMobileNoLabel.Name = "DriversMobileNoLabel"
        DriversMobileNoLabel.Size = New System.Drawing.Size(94, 13)
        DriversMobileNoLabel.TabIndex = 27
        DriversMobileNoLabel.Text = "Drivers Mobile No:"
        '
        'DrivingLicenceNoLabel
        '
        DrivingLicenceNoLabel.AutoSize = True
        DrivingLicenceNoLabel.Location = New System.Drawing.Point(723, 135)
        DrivingLicenceNoLabel.Name = "DrivingLicenceNoLabel"
        DrivingLicenceNoLabel.Size = New System.Drawing.Size(101, 13)
        DrivingLicenceNoLabel.TabIndex = 29
        DrivingLicenceNoLabel.Text = "Driving Licence No:"
        '
        'LockNoLabel
        '
        LockNoLabel.AutoSize = True
        LockNoLabel.Location = New System.Drawing.Point(723, 161)
        LockNoLabel.Name = "LockNoLabel"
        LockNoLabel.Size = New System.Drawing.Size(51, 13)
        LockNoLabel.TabIndex = 30
        LockNoLabel.Text = "Lock No:"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "UnitName"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "UnitId"
        '
        'GeneralGatePassDataSet
        '
        Me.GeneralGatePassDataSet.DataSetName = "GeneralGatePassDataSet"
        Me.GeneralGatePassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralGatePassBindingSource
        '
        Me.GeneralGatePassBindingSource.DataMember = "GeneralGatePass"
        Me.GeneralGatePassBindingSource.DataSource = Me.GeneralGatePassDataSet
        '
        'GeneralGatePassTableAdapter
        '
        Me.GeneralGatePassTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GeneralGatePassDetailsTableAdapter = Me.GeneralGatePassDetailsTableAdapter
        Me.TableAdapterManager.GeneralGatePassTableAdapter = Me.GeneralGatePassTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.GeneralGatePassDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GeneralGatePassDetailsTableAdapter
        '
        Me.GeneralGatePassDetailsTableAdapter.ClearBeforeFill = True
        '
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierName})
        Me.SupplierIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIdGridLookUpEditView.Name = "SupplierIdGridLookUpEditView"
        Me.SupplierIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.EditValue = ""
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(429, 54)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.PopupView = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(282, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 4
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
        'AttentionTextEdit
        '
        Me.AttentionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "Attention", True))
        Me.AttentionTextEdit.Location = New System.Drawing.Point(429, 80)
        Me.AttentionTextEdit.Name = "AttentionTextEdit"
        Me.AttentionTextEdit.Size = New System.Drawing.Size(282, 20)
        Me.AttentionTextEdit.TabIndex = 6
        '
        'PurposeTextEdit
        '
        Me.PurposeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "Purpose", True))
        Me.PurposeTextEdit.Location = New System.Drawing.Point(429, 106)
        Me.PurposeTextEdit.Name = "PurposeTextEdit"
        Me.PurposeTextEdit.Size = New System.Drawing.Size(282, 20)
        Me.PurposeTextEdit.TabIndex = 8
        '
        'ResponsiblePersonTextEdit
        '
        Me.ResponsiblePersonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "ResponsiblePerson", True))
        Me.ResponsiblePersonTextEdit.Location = New System.Drawing.Point(429, 132)
        Me.ResponsiblePersonTextEdit.Name = "ResponsiblePersonTextEdit"
        Me.ResponsiblePersonTextEdit.Size = New System.Drawing.Size(282, 20)
        Me.ResponsiblePersonTextEdit.TabIndex = 10
        '
        'GatePassNoTextEdit
        '
        Me.GatePassNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "GatePassNo", True))
        Me.GatePassNoTextEdit.Location = New System.Drawing.Point(132, 54)
        Me.GatePassNoTextEdit.Name = "GatePassNoTextEdit"
        Me.GatePassNoTextEdit.Properties.ReadOnly = True
        Me.GatePassNoTextEdit.Size = New System.Drawing.Size(149, 20)
        Me.GatePassNoTextEdit.TabIndex = 12
        '
        'GatePaseDateDateEdit
        '
        Me.GatePaseDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "GatePaseDate", True))
        Me.GatePaseDateDateEdit.EditValue = Nothing
        Me.GatePaseDateDateEdit.Location = New System.Drawing.Point(132, 80)
        Me.GatePaseDateDateEdit.Name = "GatePaseDateDateEdit"
        Me.GatePaseDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GatePaseDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GatePaseDateDateEdit.Size = New System.Drawing.Size(149, 20)
        Me.GatePaseDateDateEdit.TabIndex = 14
        '
        'ChallanLookupIssuedBindingSource
        '
        Me.ChallanLookupIssuedBindingSource.DataMember = "ChallanLookupIssued"
        Me.ChallanLookupIssuedBindingSource.DataSource = Me.ChallanLookupIssuedDataSet
        '
        'ChallanLookupIssuedDataSet
        '
        Me.ChallanLookupIssuedDataSet.DataSetName = "ChallanLookupIssuedDataSet"
        Me.ChallanLookupIssuedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralGatePassDetailsBindingSource
        '
        Me.GeneralGatePassDetailsBindingSource.DataMember = "FK_GeneralGatePassDetails_GeneralGatePass"
        Me.GeneralGatePassDetailsBindingSource.DataSource = Me.GeneralGatePassBindingSource
        '
        'GeneralGatePassDetailsGridControl
        '
        Me.GeneralGatePassDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeneralGatePassDetailsGridControl.DataSource = Me.GeneralGatePassDetailsBindingSource
        Me.GeneralGatePassDetailsGridControl.Location = New System.Drawing.Point(0, 196)
        Me.GeneralGatePassDetailsGridControl.MainView = Me.GridView1
        Me.GeneralGatePassDetailsGridControl.Name = "GeneralGatePassDetailsGridControl"
        Me.GeneralGatePassDetailsGridControl.Size = New System.Drawing.Size(1319, 430)
        Me.GeneralGatePassDetailsGridControl.TabIndex = 17
        Me.GeneralGatePassDetailsGridControl.UseEmbeddedNavigator = True
        Me.GeneralGatePassDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQuantity, Me.colRemarks, Me.colItemName1, Me.colUnitId})
        Me.GridView1.GridControl = Me.GeneralGatePassDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 1
        Me.colQuantity.Width = 106
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 3
        Me.colRemarks.Width = 530
        '
        'colItemName1
        '
        Me.colItemName1.Caption = "Item Description"
        Me.colItemName1.FieldName = "ItemName"
        Me.colItemName1.Name = "colItemName1"
        Me.colItemName1.Visible = True
        Me.colItemName1.VisibleIndex = 0
        Me.colItemName1.Width = 461
        '
        'colUnitId
        '
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 2
        Me.colUnitId.Width = 90
        '
        'UnitBindingSource
        '
        Me.UnitBindingSource.DataMember = "Unit"
        Me.UnitBindingSource.DataSource = Me.UnitDataSet
        '
        'UnitDataSet
        '
        Me.UnitDataSet.DataSetName = "UnitDataSet"
        Me.UnitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemListLookupBindingSource
        '
        Me.ItemListLookupBindingSource.DataMember = "ItemListLookup"
        Me.ItemListLookupBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChallanDateDateEdit
        '
        Me.ChallanDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "ChallanDate", True))
        Me.ChallanDateDateEdit.EditValue = Nothing
        Me.ChallanDateDateEdit.Location = New System.Drawing.Point(132, 132)
        Me.ChallanDateDateEdit.Name = "ChallanDateDateEdit"
        Me.ChallanDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ChallanDateDateEdit.Size = New System.Drawing.Size(149, 20)
        Me.ChallanDateDateEdit.TabIndex = 18
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'ChallanLookupIssuedIssueTableAdapter
        '
        Me.ChallanLookupIssuedIssueTableAdapter.ClearBeforeFill = True
        '
        'ChallanLinkLabel
        '
        Me.ChallanLinkLabel.AutoSize = True
        Me.ChallanLinkLabel.Location = New System.Drawing.Point(15, 109)
        Me.ChallanLinkLabel.Name = "ChallanLinkLabel"
        Me.ChallanLinkLabel.Size = New System.Drawing.Size(59, 13)
        Me.ChallanLinkLabel.TabIndex = 20
        Me.ChallanLinkLabel.TabStop = True
        Me.ChallanLinkLabel.Text = "Challan No"
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'GGatePassLookupDataSet
        '
        Me.GGatePassLookupDataSet.DataSetName = "GGatePassLookupDataSet"
        Me.GGatePassLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GGatePassLookupBindingSource
        '
        Me.GGatePassLookupBindingSource.DataMember = "GGatePassLookup"
        Me.GGatePassLookupBindingSource.DataSource = Me.GGatePassLookupDataSet
        '
        'GGatePassLookupTableAdapter
        '
        Me.GGatePassLookupTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.GGatePassLookupTableAdapter = Me.GGatePassLookupTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.GGatePassLookupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(505, 7)
        Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.GGatePassLookupBindingSource1
        Me.GridLookUpEdit1.Properties.DisplayMember = "GatePassNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Gate Pass No]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "GeneralGatePassId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(220, 20)
        Me.GridLookUpEdit1.TabIndex = 25
        '
        'GGatePassLookupBindingSource1
        '
        Me.GGatePassLookupBindingSource1.DataMember = "GGatePassLookup"
        Me.GGatePassLookupBindingSource1.DataSource = Me.GGatePassLookupDataSet
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGatePassNo, Me.colGatePaseDate})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colGatePassNo
        '
        Me.colGatePassNo.FieldName = "GatePassNo"
        Me.colGatePassNo.Name = "colGatePassNo"
        Me.colGatePassNo.Visible = True
        Me.colGatePassNo.VisibleIndex = 0
        '
        'colGatePaseDate
        '
        Me.colGatePaseDate.FieldName = "GatePaseDate"
        Me.colGatePaseDate.Name = "colGatePaseDate"
        Me.colGatePaseDate.Visible = True
        Me.colGatePaseDate.VisibleIndex = 1
        '
        'VehicleNoTextEdit
        '
        Me.VehicleNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "VehicleNo", True))
        Me.VehicleNoTextEdit.Location = New System.Drawing.Point(830, 54)
        Me.VehicleNoTextEdit.Name = "VehicleNoTextEdit"
        Me.VehicleNoTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.VehicleNoTextEdit.TabIndex = 26
        '
        'DriversNameTextEdit
        '
        Me.DriversNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "DriversName", True))
        Me.DriversNameTextEdit.Location = New System.Drawing.Point(830, 80)
        Me.DriversNameTextEdit.Name = "DriversNameTextEdit"
        Me.DriversNameTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.DriversNameTextEdit.TabIndex = 27
        '
        'DriversMobileNoTextEdit
        '
        Me.DriversMobileNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "DriversMobileNo", True))
        Me.DriversMobileNoTextEdit.Location = New System.Drawing.Point(830, 106)
        Me.DriversMobileNoTextEdit.Name = "DriversMobileNoTextEdit"
        Me.DriversMobileNoTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.DriversMobileNoTextEdit.TabIndex = 28
        '
        'ChallanNoGridLookUpEditView
        '
        Me.ChallanNoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.ChallanNoGridLookUpEditView.Name = "ChallanNoGridLookUpEditView"
        Me.ChallanNoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ChallanNoGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'ChallanNoGridLookUpEdit
        '
        Me.ChallanNoGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "ChallanNo", True))
        Me.ChallanNoGridLookUpEdit.Location = New System.Drawing.Point(132, 106)
        Me.ChallanNoGridLookUpEdit.Name = "ChallanNoGridLookUpEdit"
        Me.ChallanNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ChallanNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ChallanNoGridLookUpEdit.Properties.NullText = ""
        Me.ChallanNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ChallanNoGridLookUpEdit.Properties.PopupView = Me.ChallanNoGridLookUpEditView
        Me.ChallanNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ChallanNoGridLookUpEdit.Size = New System.Drawing.Size(149, 20)
        Me.ChallanNoGridLookUpEdit.TabIndex = 29
        '
        'GreigeFabricDeliveryChallanLookupDataSet
        '
        Me.GreigeFabricDeliveryChallanLookupDataSet.DataSetName = "GreigeFabricDeliveryChallanLookupDataSet"
        Me.GreigeFabricDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GreyFabricDeliveryChallanLookupBindingSource
        '
        Me.GreyFabricDeliveryChallanLookupBindingSource.DataMember = "GreyFabricDeliveryChallanLookup"
        Me.GreyFabricDeliveryChallanLookupBindingSource.DataSource = Me.GreigeFabricDeliveryChallanLookupDataSet
        '
        'GreyFabricDeliveryChallanLookupTableAdapter
        '
        Me.GreyFabricDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'FinishFabricDeliveryChallanLookupDataSet
        '
        Me.FinishFabricDeliveryChallanLookupDataSet.DataSetName = "FinishFabricDeliveryChallanLookupDataSet"
        Me.FinishFabricDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishFabricDeliveryChallanLookupBindingSource
        '
        Me.FinishFabricDeliveryChallanLookupBindingSource.DataMember = "FinishFabricDeliveryChallanLookup"
        Me.FinishFabricDeliveryChallanLookupBindingSource.DataSource = Me.FinishFabricDeliveryChallanLookupDataSet
        '
        'FinishFabricDeliveryChallanLookupTableAdapter
        '
        Me.FinishFabricDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'GFIDeliveryDataSet
        '
        Me.GFIDeliveryDataSet.DataSetName = "GFIDeliveryDataSet"
        Me.GFIDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GFIDeliveryLookupBindingSource
        '
        Me.GFIDeliveryLookupBindingSource.DataMember = "GFIDeliveryLookup"
        Me.GFIDeliveryLookupBindingSource.DataSource = Me.GFIDeliveryDataSet
        '
        'GFIDeliveryLookupTableAdapter
        '
        Me.GFIDeliveryLookupTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'DrivingLicenceNoTextEdit
        '
        Me.DrivingLicenceNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "DrivingLicenceNo", True))
        Me.DrivingLicenceNoTextEdit.Location = New System.Drawing.Point(830, 132)
        Me.DrivingLicenceNoTextEdit.Name = "DrivingLicenceNoTextEdit"
        Me.DrivingLicenceNoTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.DrivingLicenceNoTextEdit.TabIndex = 30
        '
        'LockNoTextEdit
        '
        Me.LockNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "LockNo", True))
        Me.LockNoTextEdit.Location = New System.Drawing.Point(830, 158)
        Me.LockNoTextEdit.Name = "LockNoTextEdit"
        Me.LockNoTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.LockNoTextEdit.TabIndex = 31
        '
        'MiscChallanLookupDataSet
        '
        Me.MiscChallanLookupDataSet.DataSetName = "MiscChallanLookupDataSet"
        Me.MiscChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MiscChallanLookupBindingSource
        '
        Me.MiscChallanLookupBindingSource.DataMember = "MiscChallanLookup"
        Me.MiscChallanLookupBindingSource.DataSource = Me.MiscChallanLookupDataSet
        '
        'MiscChallanLookupTableAdapter
        '
        Me.MiscChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'DeliveryChallanLookUpDataSet
        '
        Me.DeliveryChallanLookUpDataSet.DataSetName = "DeliveryChallanLookUpDataSet"
        Me.DeliveryChallanLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeliveryChallanLookUpBindingSource
        '
        Me.DeliveryChallanLookUpBindingSource.DataMember = "DeliveryChallanLookUp"
        Me.DeliveryChallanLookUpBindingSource.DataSource = Me.DeliveryChallanLookUpDataSet
        '
        'DeliveryChallanLookUpTableAdapter
        '
        Me.DeliveryChallanLookUpTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.DeliveryChallanLookUpTableAdapter = Me.DeliveryChallanLookUpTableAdapter
        Me.TableAdapterManager2.UpdateOrder = KSoft_Apparel.DeliveryChallanLookUpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(1369, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'CuttingDeliveryChallanLookupDataSet
        '
        Me.CuttingDeliveryChallanLookupDataSet.DataSetName = "CuttingDeliveryChallanLookupDataSet"
        Me.CuttingDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CuttingDeliveryChallanLookupBindingSource
        '
        Me.CuttingDeliveryChallanLookupBindingSource.DataMember = "CuttingDeliveryChallanLookup"
        Me.CuttingDeliveryChallanLookupBindingSource.DataSource = Me.CuttingDeliveryChallanLookupDataSet
        '
        'CuttingDeliveryChallanLookupTableAdapter
        '
        Me.CuttingDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GridLookUpEdit1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1319, 35)
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
        'RefreshButton
        '
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RefreshButton.Location = New System.Drawing.Point(229, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 27)
        Me.RefreshButton.TabIndex = 48
        Me.RefreshButton.Text = "&Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(310, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "&Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 9, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Gate Pass No  :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(731, 6)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 47
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'SewingDeliveryChallanLookupDataSet
        '
        Me.SewingDeliveryChallanLookupDataSet.DataSetName = "SewingDeliveryChallanLookupDataSet"
        Me.SewingDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingDeliveryChallanLookupBindingSource
        '
        Me.SewingDeliveryChallanLookupBindingSource.DataMember = "SewingDeliveryChallanLookup"
        Me.SewingDeliveryChallanLookupBindingSource.DataSource = Me.SewingDeliveryChallanLookupDataSet
        '
        'SewingDeliveryChallanLookupTableAdapter
        '
        Me.SewingDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'EmbDeliveryChallanLookupDataSet
        '
        Me.EmbDeliveryChallanLookupDataSet.DataSetName = "EmbDeliveryChallanLookupDataSet"
        Me.EmbDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmbDeliveryChallanLookupBindingSource
        '
        Me.EmbDeliveryChallanLookupBindingSource.DataMember = "EmbDeliveryChallanLookup"
        Me.EmbDeliveryChallanLookupBindingSource.DataSource = Me.EmbDeliveryChallanLookupDataSet
        '
        'EmbDeliveryChallanLookupTableAdapter
        '
        Me.EmbDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'PrintingDeliveryChallanLookupDataSet
        '
        Me.PrintingDeliveryChallanLookupDataSet.DataSetName = "PrintingDeliveryChallanLookupDataSet"
        Me.PrintingDeliveryChallanLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintingDeliveryChallanLookupBindingSource
        '
        Me.PrintingDeliveryChallanLookupBindingSource.DataMember = "PrintingDeliveryChallanLookup"
        Me.PrintingDeliveryChallanLookupBindingSource.DataSource = Me.PrintingDeliveryChallanLookupDataSet
        '
        'PrintingDeliveryChallanLookupTableAdapter
        '
        Me.PrintingDeliveryChallanLookupTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(15, 161)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(32, 13)
        Label2.TabIndex = 56
        Label2.Text = "User:"
        '
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GeneralGatePassBindingSource, "UserId", True))
        Me.UserGridLookUpEdit.Location = New System.Drawing.Point(132, 158)
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.Properties.DataSource = Me.UserLookupBindingSource
        Me.UserGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.Properties.ImmediatePopup = True
        Me.UserGridLookUpEdit.Properties.NullText = ""
        Me.UserGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UserGridLookUpEdit.Properties.PopupView = Me.GridView2
        Me.UserGridLookUpEdit.Properties.ReadOnly = True
        Me.UserGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.UserGridLookUpEdit.Size = New System.Drawing.Size(149, 20)
        Me.UserGridLookUpEdit.TabIndex = 55
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'UserLookupDataSet
        '
        Me.UserLookupDataSet.DataSetName = "UserLookupDataSet"
        Me.UserLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserLookupBindingSource
        '
        Me.UserLookupBindingSource.DataMember = "UserLookup"
        Me.UserLookupBindingSource.DataSource = Me.UserLookupDataSet
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'frmGeneralGatePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1319, 625)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.UserGridLookUpEdit)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(LockNoLabel)
        Me.Controls.Add(Me.LockNoTextEdit)
        Me.Controls.Add(DrivingLicenceNoLabel)
        Me.Controls.Add(Me.DrivingLicenceNoTextEdit)
        Me.Controls.Add(Me.ChallanNoGridLookUpEdit)
        Me.Controls.Add(DriversMobileNoLabel)
        Me.Controls.Add(Me.DriversMobileNoTextEdit)
        Me.Controls.Add(DriversNameLabel)
        Me.Controls.Add(Me.DriversNameTextEdit)
        Me.Controls.Add(VehicleNoLabel)
        Me.Controls.Add(Me.VehicleNoTextEdit)
        Me.Controls.Add(Me.ChallanLinkLabel)
        Me.Controls.Add(ChallanDateLabel)
        Me.Controls.Add(Me.ChallanDateDateEdit)
        Me.Controls.Add(Me.GeneralGatePassDetailsGridControl)
        Me.Controls.Add(SupplierIdLabel)
        Me.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.Controls.Add(AttentionLabel)
        Me.Controls.Add(Me.AttentionTextEdit)
        Me.Controls.Add(PurposeLabel)
        Me.Controls.Add(Me.PurposeTextEdit)
        Me.Controls.Add(ResponsiblePersonLabel)
        Me.Controls.Add(Me.ResponsiblePersonTextEdit)
        Me.Controls.Add(GatePassNoLabel)
        Me.Controls.Add(Me.GatePassNoTextEdit)
        Me.Controls.Add(GatePaseDateLabel)
        Me.Controls.Add(Me.GatePaseDateDateEdit)
        Me.Name = "frmGeneralGatePass"
        Me.Text = "General Gate Pass Print"
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralGatePassDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralGatePassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurposeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResponsiblePersonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePaseDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePaseDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanLookupIssuedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanLookupIssuedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralGatePassDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralGatePassDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GGatePassLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GGatePassLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GGatePassLookupBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriversNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriversMobileNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanNoGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreigeFabricDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreyFabricDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFIDeliveryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFIDeliveryLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrivingLicenceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LockNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiscChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryChallanLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryChallanLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.SewingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingDeliveryChallanLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingDeliveryChallanLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GeneralGatePassDataSet As KSoft_Apparel.GeneralGatePassDataSet
    Friend WithEvents GeneralGatePassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralGatePassTableAdapter As KSoft_Apparel.GeneralGatePassDataSetTableAdapters.GeneralGatePassTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.GeneralGatePassDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents AttentionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PurposeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ResponsiblePersonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GatePassNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GatePaseDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GeneralGatePassDetailsTableAdapter As KSoft_Apparel.GeneralGatePassDataSetTableAdapters.GeneralGatePassDetailsTableAdapter
    Friend WithEvents GeneralGatePassDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralGatePassDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChallanDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents ChallanLookupIssuedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChallanLookupIssuedDataSet As KSoft_Apparel.ChallanLookupIssuedDataSet
    Friend WithEvents ChallanLookupIssuedIssueTableAdapter As KSoft_Apparel.ChallanLookupIssuedDataSetTableAdapters.ChallanLookupIssuedIssueTableAdapter
    Friend WithEvents ChallanLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDataSet As KSoft_Apparel.ItemListDataSet
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Apparel.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents GGatePassLookupDataSet As KSoft_Apparel.GGatePassLookupDataSet
    Friend WithEvents GGatePassLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GGatePassLookupTableAdapter As KSoft_Apparel.GGatePassLookupDataSetTableAdapters.GGatePassLookupTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.GGatePassLookupDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GGatePassLookupBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGatePassNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGatePaseDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VehicleNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DriversNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DriversMobileNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChallanNoGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ChallanNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GreigeFabricDeliveryChallanLookupDataSet As KSoft_Apparel.GreigeFabricDeliveryChallanLookupDataSet
    Friend WithEvents GreyFabricDeliveryChallanLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GreyFabricDeliveryChallanLookupTableAdapter As KSoft_Apparel.GreigeFabricDeliveryChallanLookupDataSetTableAdapters.GreyFabricDeliveryChallanLookupTableAdapter
    Friend WithEvents FinishFabricDeliveryChallanLookupDataSet As KSoft_Apparel.FinishFabricDeliveryChallanLookupDataSet
    Friend WithEvents FinishFabricDeliveryChallanLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishFabricDeliveryChallanLookupTableAdapter As KSoft_Apparel.FinishFabricDeliveryChallanLookupDataSetTableAdapters.FinishFabricDeliveryChallanLookupTableAdapter
    Friend WithEvents colItemName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GFIDeliveryDataSet As KSoft_Apparel.GFIDeliveryDataSet
    Friend WithEvents GFIDeliveryLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GFIDeliveryLookupTableAdapter As KSoft_Apparel.GFIDeliveryDataSetTableAdapters.GFIDeliveryLookupTableAdapter
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents DrivingLicenceNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LockNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MiscChallanLookupDataSet As KSoft_Apparel.MiscChallanLookupDataSet
    Friend WithEvents MiscChallanLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MiscChallanLookupTableAdapter As KSoft_Apparel.MiscChallanLookupDataSetTableAdapters.MiscChallanLookupTableAdapter
    Friend WithEvents DeliveryChallanLookUpDataSet As KSoft_Apparel.DeliveryChallanLookUpDataSet
    Friend WithEvents DeliveryChallanLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveryChallanLookUpTableAdapter As KSoft_Apparel.DeliveryChallanLookUpDataSetTableAdapters.DeliveryChallanLookUpTableAdapter
    Friend WithEvents TableAdapterManager2 As KSoft_Apparel.DeliveryChallanLookUpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents CuttingDeliveryChallanLookupDataSet As CuttingDeliveryChallanLookupDataSet
    Friend WithEvents CuttingDeliveryChallanLookupBindingSource As BindingSource
    Friend WithEvents CuttingDeliveryChallanLookupTableAdapter As CuttingDeliveryChallanLookupDataSetTableAdapters.CuttingDeliveryChallanLookupTableAdapter
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents NewButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowButton As Button
    Friend WithEvents SewingDeliveryChallanLookupDataSet As SewingDeliveryChallanLookupDataSet
    Friend WithEvents SewingDeliveryChallanLookupBindingSource As BindingSource
    Friend WithEvents SewingDeliveryChallanLookupTableAdapter As SewingDeliveryChallanLookupDataSetTableAdapters.SewingDeliveryChallanLookupTableAdapter
    Friend WithEvents EmbDeliveryChallanLookupDataSet As EmbDeliveryChallanLookupDataSet
    Friend WithEvents EmbDeliveryChallanLookupBindingSource As BindingSource
    Friend WithEvents EmbDeliveryChallanLookupTableAdapter As EmbDeliveryChallanLookupDataSetTableAdapters.EmbDeliveryChallanLookupTableAdapter
    Friend WithEvents PrintingDeliveryChallanLookupDataSet As PrintingDeliveryChallanLookupDataSet
    Friend WithEvents PrintingDeliveryChallanLookupBindingSource As BindingSource
    Friend WithEvents PrintingDeliveryChallanLookupTableAdapter As PrintingDeliveryChallanLookupDataSetTableAdapters.PrintingDeliveryChallanLookupTableAdapter
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserLookupDataSet As UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As BindingSource
    Friend WithEvents UserLookupTableAdapter As UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    'Friend WithEvents CuttingDeliveryChallanLookupTableAdapter As CuttingDeliveryDataSetTableAdapters.CuttingDeliveryChallanLookupTableAdapter
End Class
