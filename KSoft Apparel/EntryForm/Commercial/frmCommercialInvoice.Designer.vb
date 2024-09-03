<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommercialInvoice
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
        Dim ConsigneeLabel As System.Windows.Forms.Label
        Dim ShipperLabel As System.Windows.Forms.Label
        Dim AccountLabel As System.Windows.Forms.Label
        Dim NotifyLabel As System.Windows.Forms.Label
        Dim ExpNoLabel As System.Windows.Forms.Label
        Dim ExpDateLabel As System.Windows.Forms.Label
        Dim ExportCountNoLabel As System.Windows.Forms.Label
        Dim ExportCountDateLabel As System.Windows.Forms.Label
        Dim ShippingMarksFrontLabel As System.Windows.Forms.Label
        Dim ShippingMarksSideLabel As System.Windows.Forms.Label
        Dim BillNoLabel As System.Windows.Forms.Label
        Dim BillDateLabel As System.Windows.Forms.Label
        Dim ERCNoLabel As System.Windows.Forms.Label
        Dim ERCDateLabel As System.Windows.Forms.Label
        Dim SupplierRefNoLabel1 As System.Windows.Forms.Label
        Dim TotalNetWeightLabel As System.Windows.Forms.Label
        Dim TotalGrossWeightLabel As System.Windows.Forms.Label
        Dim CartonMeasurementLabel As System.Windows.Forms.Label
        Dim PrecarriageByLabel As System.Windows.Forms.Label
        Dim ContainerNoLabel As System.Windows.Forms.Label
        Dim ShipmentByLabel1 As System.Windows.Forms.Label
        Dim ShipmentFromLabel As System.Windows.Forms.Label
        Dim ShipmentToLabel As System.Windows.Forms.Label
        Dim CommercialInvoiceDateLabel As System.Windows.Forms.Label
        Dim HSCodeLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim TotalCartonsLabel As System.Windows.Forms.Label
        Dim CommercialInvoiceNoLabel As System.Windows.Forms.Label
        Dim ShipmentIdLabel As System.Windows.Forms.Label
        Dim FCALabel As System.Windows.Forms.Label
        Dim DescriptionOfGoodsLabel As System.Windows.Forms.Label
        Dim ExportLCLabel As System.Windows.Forms.Label
        Dim ExportLCDateLabel As System.Windows.Forms.Label
        Dim PaymentLabel As System.Windows.Forms.Label
        Dim JOBLabel As System.Windows.Forms.Label
        Dim UDLabel As System.Windows.Forms.Label
        Dim CountryOfOriginLabel As System.Windows.Forms.Label
        Dim BookingNoLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim ApplicantBankLabel As System.Windows.Forms.Label
        Dim PortOfDischargeLabel As System.Windows.Forms.Label
        Dim PortOfDeliveryLabel As System.Windows.Forms.Label
        Dim SailingOnLabel As System.Windows.Forms.Label
        Dim FreightLabel As System.Windows.Forms.Label
        Dim PlaceOfReceiptLabel As System.Windows.Forms.Label
        Dim PortOfLoadingLabel As System.Windows.Forms.Label
        Dim VatRegNoLabel As System.Windows.Forms.Label
        Dim TotalMesurementLabel As System.Windows.Forms.Label
        Dim TotalGoodsQTYLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim MasterProgramNoLabel As System.Windows.Forms.Label
        Dim TermOfDeliveryLabel As System.Windows.Forms.Label
        Dim FinalDestinationLabel As System.Windows.Forms.Label
        Dim BGMEANoLabel As System.Windows.Forms.Label
        Dim DraftATLabel As System.Windows.Forms.Label
        Dim DocumentNoLabel As System.Windows.Forms.Label
        Dim DocumentDateLabel As System.Windows.Forms.Label
        Dim EPBRegNoLabel As System.Windows.Forms.Label
        Dim ReferenceNoLabel As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim ConsigneeNotifyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommercialInvoice))
        Me.CommercialInvoiceDataSet = New KSoft_Apparel.CommercialInvoiceDataSet()
        Me.CommercialInvoiceTableAdapter = New KSoft_Apparel.CommercialInvoiceDataSetTableAdapters.CommercialInvoiceTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.CommercialInvoiceDataSetTableAdapters.TableAdapterManager()
        Me.CommercialInvoiceBreakDownTableAdapter = New KSoft_Apparel.CommercialInvoiceDataSetTableAdapters.CommercialInvoiceBreakDownTableAdapter()
        Me.CommercialInvoiceMainTableAdapter = New KSoft_Apparel.CommercialInvoiceDataSetTableAdapters.CommercialInvoiceMainTableAdapter()
        Me.CommercialInvoiceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CommercialInvoiceMainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CommercialInvoiceBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.OrderPOLookupAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPOLookupNewDataSet = New KSoft_Apparel.OrderPOLookupNewDataSet()
        Me.OrderPOLookupAllTableAdapter = New KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter()
        Me.colPOAndColorAndDes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ConsigneeNotifyMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.TermOfDeliveryTextBox = New System.Windows.Forms.TextBox()
        Me.MasterProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.MasterOrderLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterOrderLookUpDataSet = New KSoft_Apparel.MasterOrderLookUpDataSet()
        Me.MasterProgramNoGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMasterProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DescriptionOfGoodsTextBox = New System.Windows.Forms.TextBox()
        Me.FCATextBox = New System.Windows.Forms.TextBox()
        Me.ShipmentIdTextBox = New System.Windows.Forms.TextBox()
        Me.MLCNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.MasterLCLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterLCDataSet = New KSoft_Apparel.MasterLCDataSet()
        Me.MLCNoGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefAndMLCNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.HSCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CommercialInvoiceDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CommercialInvoiceNoTextBox = New System.Windows.Forms.TextBox()
        Me.ContainerNoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecarriageByTextBox = New System.Windows.Forms.TextBox()
        Me.NotifyMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.AccountMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ShipperMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ConsigneeMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ShippingMarksFrontMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ShippingMarksSideMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ReferenceNoTextBox = New System.Windows.Forms.TextBox()
        Me.DraftATTextBox = New System.Windows.Forms.TextBox()
        Me.EPBRegNoTextBox = New System.Windows.Forms.TextBox()
        Me.BGMEANoTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FinalDestinationTextBox = New System.Windows.Forms.TextBox()
        Me.DocumentNoTextBox = New System.Windows.Forms.TextBox()
        Me.ApplicantBankMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.TotalGoodsQTYTextBox = New System.Windows.Forms.TextBox()
        Me.TotalGrossWeightTextBox = New System.Windows.Forms.TextBox()
        Me.TotalMesurementTextBox = New System.Windows.Forms.TextBox()
        Me.JOBTextBox = New System.Windows.Forms.TextBox()
        Me.VatRegNoTextBox = New System.Windows.Forms.TextBox()
        Me.PortOfLoadingTextBox = New System.Windows.Forms.TextBox()
        Me.PlaceOfReceiptTextBox = New System.Windows.Forms.TextBox()
        Me.FreightTextBox = New System.Windows.Forms.TextBox()
        Me.SailingOnTextBox = New System.Windows.Forms.TextBox()
        Me.PortOfDeliveryTextBox = New System.Windows.Forms.TextBox()
        Me.PortOfDischargeTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.BookingNoTextBox = New System.Windows.Forms.TextBox()
        Me.CountryOfOriginTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UDTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.ExportLCDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ExportLCTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCartonsTextBox = New System.Windows.Forms.TextBox()
        Me.ShipmentToTextBox = New System.Windows.Forms.TextBox()
        Me.ShipmentFromTextBox = New System.Windows.Forms.TextBox()
        Me.ShipmentByComboBox = New System.Windows.Forms.ComboBox()
        Me.CartonMeasurementTextBox = New System.Windows.Forms.TextBox()
        Me.TotalNetWeightTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierRefNoTextBox = New System.Windows.Forms.TextBox()
        Me.ERCDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ERCNoTextBox = New System.Windows.Forms.TextBox()
        Me.BillDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BillNoTextBox = New System.Windows.Forms.TextBox()
        Me.ExportCountDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ExportCountNoTextBox = New System.Windows.Forms.TextBox()
        Me.ExpDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ExpNoTextBox = New System.Windows.Forms.TextBox()
        Me.CommercialInvoiceGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CommercialInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPOAndStyleAndColorAndDes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArticleNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAsPerContact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetInvoiceValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBankRealization = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKimball = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CommercialInvoiceBreakDownGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CommercialInvoiceBreakDownBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCounrty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarton = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOAndColorAndDes1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InvoiceNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CommercialInvoiceLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommercialInvoiceLookUpDataSet = New KSoft_Apparel.CommercialInvoiceLookUpDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCommercialInvoiceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommercialInvoiceDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CommercialInvoiceLookUpTableAdapter = New KSoft_Apparel.CommercialInvoiceLookUpDataSetTableAdapters.CommercialInvoiceLookUpTableAdapter()
        Me.GetDataButton = New System.Windows.Forms.Button()
        Me.MasterLCLookupTableAdapter = New KSoft_Apparel.MasterLCDataSetTableAdapters.MasterLCLookupTableAdapter()
        Me.MasterOrderLookUpTableAdapter = New KSoft_Apparel.MasterOrderLookUpDataSetTableAdapters.MasterOrderLookUpTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        ConsigneeLabel = New System.Windows.Forms.Label()
        ShipperLabel = New System.Windows.Forms.Label()
        AccountLabel = New System.Windows.Forms.Label()
        NotifyLabel = New System.Windows.Forms.Label()
        ExpNoLabel = New System.Windows.Forms.Label()
        ExpDateLabel = New System.Windows.Forms.Label()
        ExportCountNoLabel = New System.Windows.Forms.Label()
        ExportCountDateLabel = New System.Windows.Forms.Label()
        ShippingMarksFrontLabel = New System.Windows.Forms.Label()
        ShippingMarksSideLabel = New System.Windows.Forms.Label()
        BillNoLabel = New System.Windows.Forms.Label()
        BillDateLabel = New System.Windows.Forms.Label()
        ERCNoLabel = New System.Windows.Forms.Label()
        ERCDateLabel = New System.Windows.Forms.Label()
        SupplierRefNoLabel1 = New System.Windows.Forms.Label()
        TotalNetWeightLabel = New System.Windows.Forms.Label()
        TotalGrossWeightLabel = New System.Windows.Forms.Label()
        CartonMeasurementLabel = New System.Windows.Forms.Label()
        PrecarriageByLabel = New System.Windows.Forms.Label()
        ContainerNoLabel = New System.Windows.Forms.Label()
        ShipmentByLabel1 = New System.Windows.Forms.Label()
        ShipmentFromLabel = New System.Windows.Forms.Label()
        ShipmentToLabel = New System.Windows.Forms.Label()
        CommercialInvoiceDateLabel = New System.Windows.Forms.Label()
        HSCodeLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        TotalCartonsLabel = New System.Windows.Forms.Label()
        CommercialInvoiceNoLabel = New System.Windows.Forms.Label()
        ShipmentIdLabel = New System.Windows.Forms.Label()
        FCALabel = New System.Windows.Forms.Label()
        DescriptionOfGoodsLabel = New System.Windows.Forms.Label()
        ExportLCLabel = New System.Windows.Forms.Label()
        ExportLCDateLabel = New System.Windows.Forms.Label()
        PaymentLabel = New System.Windows.Forms.Label()
        JOBLabel = New System.Windows.Forms.Label()
        UDLabel = New System.Windows.Forms.Label()
        CountryOfOriginLabel = New System.Windows.Forms.Label()
        BookingNoLabel = New System.Windows.Forms.Label()
        ContactNoLabel = New System.Windows.Forms.Label()
        ApplicantBankLabel = New System.Windows.Forms.Label()
        PortOfDischargeLabel = New System.Windows.Forms.Label()
        PortOfDeliveryLabel = New System.Windows.Forms.Label()
        SailingOnLabel = New System.Windows.Forms.Label()
        FreightLabel = New System.Windows.Forms.Label()
        PlaceOfReceiptLabel = New System.Windows.Forms.Label()
        PortOfLoadingLabel = New System.Windows.Forms.Label()
        VatRegNoLabel = New System.Windows.Forms.Label()
        TotalMesurementLabel = New System.Windows.Forms.Label()
        TotalGoodsQTYLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        MasterProgramNoLabel = New System.Windows.Forms.Label()
        TermOfDeliveryLabel = New System.Windows.Forms.Label()
        FinalDestinationLabel = New System.Windows.Forms.Label()
        BGMEANoLabel = New System.Windows.Forms.Label()
        DraftATLabel = New System.Windows.Forms.Label()
        DocumentNoLabel = New System.Windows.Forms.Label()
        DocumentDateLabel = New System.Windows.Forms.Label()
        EPBRegNoLabel = New System.Windows.Forms.Label()
        ReferenceNoLabel = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        ConsigneeNotifyLabel = New System.Windows.Forms.Label()
        CType(Me.CommercialInvoiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommercialInvoiceBindingNavigator.SuspendLayout()
        CType(Me.CommercialInvoiceMainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ConsigneeNotifyMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterProgramNoGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MLCNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLCLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MLCNoGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotifyMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipperMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsigneeMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippingMarksFrontMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippingMarksSideMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicantBankMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceBreakDownGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceBreakDownBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialInvoiceLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsigneeLabel
        '
        ConsigneeLabel.AutoSize = True
        ConsigneeLabel.Location = New System.Drawing.Point(3, 102)
        ConsigneeLabel.Name = "ConsigneeLabel"
        ConsigneeLabel.Size = New System.Drawing.Size(138, 13)
        ConsigneeLabel.TabIndex = 11
        ConsigneeLabel.Text = "Consignee : To the Order of"
        '
        'ShipperLabel
        '
        ShipperLabel.AutoSize = True
        ShipperLabel.Location = New System.Drawing.Point(304, 102)
        ShipperLabel.Name = "ShipperLabel"
        ShipperLabel.Size = New System.Drawing.Size(93, 13)
        ShipperLabel.TabIndex = 12
        ShipperLabel.Text = "Shipper/Exporter :"
        '
        'AccountLabel
        '
        AccountLabel.AutoSize = True
        AccountLabel.Location = New System.Drawing.Point(3, 174)
        AccountLabel.Name = "AccountLabel"
        AccountLabel.Size = New System.Drawing.Size(177, 13)
        AccountLabel.TabIndex = 13
        AccountLabel.Text = "For Account And  Risk of Messers  :"
        '
        'NotifyLabel
        '
        NotifyLabel.AutoSize = True
        NotifyLabel.Location = New System.Drawing.Point(302, 174)
        NotifyLabel.Name = "NotifyLabel"
        NotifyLabel.Size = New System.Drawing.Size(40, 13)
        NotifyLabel.TabIndex = 14
        NotifyLabel.Text = "Notify :"
        '
        'ExpNoLabel
        '
        ExpNoLabel.AutoSize = True
        ExpNoLabel.Location = New System.Drawing.Point(3, 9)
        ExpNoLabel.Name = "ExpNoLabel"
        ExpNoLabel.Size = New System.Drawing.Size(45, 13)
        ExpNoLabel.TabIndex = 0
        ExpNoLabel.Text = "Exp No:"
        '
        'ExpDateLabel
        '
        ExpDateLabel.AutoSize = True
        ExpDateLabel.Location = New System.Drawing.Point(412, 9)
        ExpDateLabel.Name = "ExpDateLabel"
        ExpDateLabel.Size = New System.Drawing.Size(54, 13)
        ExpDateLabel.TabIndex = 5
        ExpDateLabel.Text = "Exp Date:"
        '
        'ExportCountNoLabel
        '
        ExportCountNoLabel.AutoSize = True
        ExportCountNoLabel.Location = New System.Drawing.Point(3, 32)
        ExportCountNoLabel.Name = "ExportCountNoLabel"
        ExportCountNoLabel.Size = New System.Drawing.Size(88, 13)
        ExportCountNoLabel.TabIndex = 4
        ExportCountNoLabel.Text = "Export Count No:"
        '
        'ExportCountDateLabel
        '
        ExportCountDateLabel.AutoSize = True
        ExportCountDateLabel.Location = New System.Drawing.Point(412, 33)
        ExportCountDateLabel.Name = "ExportCountDateLabel"
        ExportCountDateLabel.Size = New System.Drawing.Size(97, 13)
        ExportCountDateLabel.TabIndex = 6
        ExportCountDateLabel.Text = "Export Count Date:"
        '
        'ShippingMarksFrontLabel
        '
        ShippingMarksFrontLabel.AutoSize = True
        ShippingMarksFrontLabel.Location = New System.Drawing.Point(3, 245)
        ShippingMarksFrontLabel.Name = "ShippingMarksFrontLabel"
        ShippingMarksFrontLabel.Size = New System.Drawing.Size(86, 13)
        ShippingMarksFrontLabel.TabIndex = 8
        ShippingMarksFrontLabel.Text = "Shipping Marks :"
        '
        'ShippingMarksSideLabel
        '
        ShippingMarksSideLabel.AutoSize = True
        ShippingMarksSideLabel.Location = New System.Drawing.Point(304, 245)
        ShippingMarksSideLabel.Name = "ShippingMarksSideLabel"
        ShippingMarksSideLabel.Size = New System.Drawing.Size(66, 13)
        ShippingMarksSideLabel.TabIndex = 10
        ShippingMarksSideLabel.Text = " Side Marks:"
        '
        'BillNoLabel
        '
        BillNoLabel.AutoSize = True
        BillNoLabel.Location = New System.Drawing.Point(3, 295)
        BillNoLabel.Name = "BillNoLabel"
        BillNoLabel.Size = New System.Drawing.Size(40, 13)
        BillNoLabel.TabIndex = 12
        BillNoLabel.Text = "Bill No:"
        '
        'BillDateLabel
        '
        BillDateLabel.AutoSize = True
        BillDateLabel.Location = New System.Drawing.Point(217, 296)
        BillDateLabel.Name = "BillDateLabel"
        BillDateLabel.Size = New System.Drawing.Size(33, 13)
        BillDateLabel.TabIndex = 14
        BillDateLabel.Text = "Date:"
        '
        'ERCNoLabel
        '
        ERCNoLabel.AutoSize = True
        ERCNoLabel.Location = New System.Drawing.Point(3, 347)
        ERCNoLabel.Name = "ERCNoLabel"
        ERCNoLabel.Size = New System.Drawing.Size(46, 13)
        ERCNoLabel.TabIndex = 16
        ERCNoLabel.Text = "ERCNo:"
        '
        'ERCDateLabel
        '
        ERCDateLabel.AutoSize = True
        ERCDateLabel.Location = New System.Drawing.Point(3, 373)
        ERCDateLabel.Name = "ERCDateLabel"
        ERCDateLabel.Size = New System.Drawing.Size(55, 13)
        ERCDateLabel.TabIndex = 18
        ERCDateLabel.Text = "ERCDate:"
        '
        'SupplierRefNoLabel1
        '
        SupplierRefNoLabel1.AutoSize = True
        SupplierRefNoLabel1.Location = New System.Drawing.Point(330, 295)
        SupplierRefNoLabel1.Name = "SupplierRefNoLabel1"
        SupplierRefNoLabel1.Size = New System.Drawing.Size(85, 13)
        SupplierRefNoLabel1.TabIndex = 21
        SupplierRefNoLabel1.Text = "Supplier Ref No:"
        '
        'TotalNetWeightLabel
        '
        TotalNetWeightLabel.AutoSize = True
        TotalNetWeightLabel.Location = New System.Drawing.Point(3, 446)
        TotalNetWeightLabel.Name = "TotalNetWeightLabel"
        TotalNetWeightLabel.Size = New System.Drawing.Size(91, 13)
        TotalNetWeightLabel.TabIndex = 22
        TotalNetWeightLabel.Text = "Total Net Weight:"
        '
        'TotalGrossWeightLabel
        '
        TotalGrossWeightLabel.AutoSize = True
        TotalGrossWeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalGrossWeightLabel.Location = New System.Drawing.Point(2, 422)
        TotalGrossWeightLabel.Name = "TotalGrossWeightLabel"
        TotalGrossWeightLabel.Size = New System.Drawing.Size(101, 13)
        TotalGrossWeightLabel.TabIndex = 24
        TotalGrossWeightLabel.Text = "Total Gross Weight:"
        '
        'CartonMeasurementLabel
        '
        CartonMeasurementLabel.AutoSize = True
        CartonMeasurementLabel.Location = New System.Drawing.Point(332, 421)
        CartonMeasurementLabel.Name = "CartonMeasurementLabel"
        CartonMeasurementLabel.Size = New System.Drawing.Size(108, 13)
        CartonMeasurementLabel.TabIndex = 26
        CartonMeasurementLabel.Text = "Carton Measurement:"
        '
        'PrecarriageByLabel
        '
        PrecarriageByLabel.AutoSize = True
        PrecarriageByLabel.Location = New System.Drawing.Point(5, 346)
        PrecarriageByLabel.Name = "PrecarriageByLabel"
        PrecarriageByLabel.Size = New System.Drawing.Size(79, 13)
        PrecarriageByLabel.TabIndex = 15
        PrecarriageByLabel.Text = "Precarriage By:"
        '
        'ContainerNoLabel
        '
        ContainerNoLabel.AutoSize = True
        ContainerNoLabel.Location = New System.Drawing.Point(363, 346)
        ContainerNoLabel.Name = "ContainerNoLabel"
        ContainerNoLabel.Size = New System.Drawing.Size(72, 13)
        ContainerNoLabel.TabIndex = 17
        ContainerNoLabel.Text = "Container No:"
        '
        'ShipmentByLabel1
        '
        ShipmentByLabel1.AutoSize = True
        ShipmentByLabel1.Location = New System.Drawing.Point(330, 320)
        ShipmentByLabel1.Name = "ShipmentByLabel1"
        ShipmentByLabel1.Size = New System.Drawing.Size(96, 13)
        ShipmentByLabel1.TabIndex = 29
        ShipmentByLabel1.Text = "Mode of Shipment:"
        '
        'ShipmentFromLabel
        '
        ShipmentFromLabel.AutoSize = True
        ShipmentFromLabel.Location = New System.Drawing.Point(332, 347)
        ShipmentFromLabel.Name = "ShipmentFromLabel"
        ShipmentFromLabel.Size = New System.Drawing.Size(80, 13)
        ShipmentFromLabel.TabIndex = 30
        ShipmentFromLabel.Text = "Shipment From:"
        '
        'ShipmentToLabel
        '
        ShipmentToLabel.AutoSize = True
        ShipmentToLabel.Location = New System.Drawing.Point(332, 372)
        ShipmentToLabel.Name = "ShipmentToLabel"
        ShipmentToLabel.Size = New System.Drawing.Size(70, 13)
        ShipmentToLabel.TabIndex = 32
        ShipmentToLabel.Text = "Shipment To:"
        '
        'CommercialInvoiceDateLabel
        '
        CommercialInvoiceDateLabel.AutoSize = True
        CommercialInvoiceDateLabel.Location = New System.Drawing.Point(417, 73)
        CommercialInvoiceDateLabel.Name = "CommercialInvoiceDateLabel"
        CommercialInvoiceDateLabel.Size = New System.Drawing.Size(71, 13)
        CommercialInvoiceDateLabel.TabIndex = 19
        CommercialInvoiceDateLabel.Text = "Invoice Date:"
        '
        'HSCodeLabel
        '
        HSCodeLabel.AutoSize = True
        HSCodeLabel.Location = New System.Drawing.Point(364, 323)
        HSCodeLabel.Name = "HSCodeLabel"
        HSCodeLabel.Size = New System.Drawing.Size(50, 13)
        HSCodeLabel.TabIndex = 20
        HSCodeLabel.Text = "HSCode:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(5, 320)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 21
        RemarksLabel.Text = "Remarks:"
        '
        'TotalCartonsLabel
        '
        TotalCartonsLabel.AutoSize = True
        TotalCartonsLabel.Location = New System.Drawing.Point(331, 397)
        TotalCartonsLabel.Name = "TotalCartonsLabel"
        TotalCartonsLabel.Size = New System.Drawing.Size(73, 13)
        TotalCartonsLabel.TabIndex = 34
        TotalCartonsLabel.Text = "Total Cartons:"
        '
        'CommercialInvoiceNoLabel
        '
        CommercialInvoiceNoLabel.AutoSize = True
        CommercialInvoiceNoLabel.Location = New System.Drawing.Point(5, 73)
        CommercialInvoiceNoLabel.Name = "CommercialInvoiceNoLabel"
        CommercialInvoiceNoLabel.Size = New System.Drawing.Size(62, 13)
        CommercialInvoiceNoLabel.TabIndex = 18
        CommercialInvoiceNoLabel.Text = "Invoice No:"
        '
        'ShipmentIdLabel
        '
        ShipmentIdLabel.AutoSize = True
        ShipmentIdLabel.Location = New System.Drawing.Point(5, 367)
        ShipmentIdLabel.Name = "ShipmentIdLabel"
        ShipmentIdLabel.Size = New System.Drawing.Size(68, 13)
        ShipmentIdLabel.TabIndex = 26
        ShipmentIdLabel.Text = "Shipment ID:"
        '
        'FCALabel
        '
        FCALabel.AutoSize = True
        FCALabel.Location = New System.Drawing.Point(363, 370)
        FCALabel.Name = "FCALabel"
        FCALabel.Size = New System.Drawing.Size(30, 13)
        FCALabel.TabIndex = 28
        FCALabel.Text = "FCA:"
        '
        'DescriptionOfGoodsLabel
        '
        DescriptionOfGoodsLabel.AutoSize = True
        DescriptionOfGoodsLabel.Location = New System.Drawing.Point(5, 394)
        DescriptionOfGoodsLabel.Name = "DescriptionOfGoodsLabel"
        DescriptionOfGoodsLabel.Size = New System.Drawing.Size(111, 13)
        DescriptionOfGoodsLabel.TabIndex = 30
        DescriptionOfGoodsLabel.Text = "Description Of Goods:"
        '
        'ExportLCLabel
        '
        ExportLCLabel.AutoSize = True
        ExportLCLabel.Location = New System.Drawing.Point(3, 56)
        ExportLCLabel.Name = "ExportLCLabel"
        ExportLCLabel.Size = New System.Drawing.Size(56, 13)
        ExportLCLabel.TabIndex = 34
        ExportLCLabel.Text = "Export LC:"
        '
        'ExportLCDateLabel
        '
        ExportLCDateLabel.AutoSize = True
        ExportLCDateLabel.Location = New System.Drawing.Point(412, 56)
        ExportLCDateLabel.Name = "ExportLCDateLabel"
        ExportLCDateLabel.Size = New System.Drawing.Size(79, 13)
        ExportLCDateLabel.TabIndex = 35
        ExportLCDateLabel.Text = "Export LCDate:"
        '
        'PaymentLabel
        '
        PaymentLabel.AutoSize = True
        PaymentLabel.Location = New System.Drawing.Point(3, 82)
        PaymentLabel.Name = "PaymentLabel"
        PaymentLabel.Size = New System.Drawing.Size(51, 13)
        PaymentLabel.TabIndex = 36
        PaymentLabel.Text = "Payment:"
        '
        'JOBLabel
        '
        JOBLabel.AutoSize = True
        JOBLabel.Location = New System.Drawing.Point(190, 80)
        JOBLabel.Name = "JOBLabel"
        JOBLabel.Size = New System.Drawing.Size(30, 13)
        JOBLabel.TabIndex = 38
        JOBLabel.Text = "JOB:"
        '
        'UDLabel
        '
        UDLabel.AutoSize = True
        UDLabel.Location = New System.Drawing.Point(306, 80)
        UDLabel.Name = "UDLabel"
        UDLabel.Size = New System.Drawing.Size(26, 13)
        UDLabel.TabIndex = 40
        UDLabel.Text = "UD:"
        '
        'CountryOfOriginLabel
        '
        CountryOfOriginLabel.AutoSize = True
        CountryOfOriginLabel.Location = New System.Drawing.Point(3, 103)
        CountryOfOriginLabel.Name = "CountryOfOriginLabel"
        CountryOfOriginLabel.Size = New System.Drawing.Size(90, 13)
        CountryOfOriginLabel.TabIndex = 44
        CountryOfOriginLabel.Text = "Country Of Origin:"
        '
        'BookingNoLabel
        '
        BookingNoLabel.AutoSize = True
        BookingNoLabel.Location = New System.Drawing.Point(330, 103)
        BookingNoLabel.Name = "BookingNoLabel"
        BookingNoLabel.Size = New System.Drawing.Size(66, 13)
        BookingNoLabel.TabIndex = 46
        BookingNoLabel.Text = "Booking No:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(3, 151)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(64, 13)
        ContactNoLabel.TabIndex = 48
        ContactNoLabel.Text = "Contact No:"
        '
        'ApplicantBankLabel
        '
        ApplicantBankLabel.AutoSize = True
        ApplicantBankLabel.Location = New System.Drawing.Point(330, 174)
        ApplicantBankLabel.Name = "ApplicantBankLabel"
        ApplicantBankLabel.Size = New System.Drawing.Size(114, 13)
        ApplicantBankLabel.TabIndex = 50
        ApplicantBankLabel.Text = "Buyer/Applicant Bank:"
        '
        'PortOfDischargeLabel
        '
        PortOfDischargeLabel.AutoSize = True
        PortOfDischargeLabel.Location = New System.Drawing.Point(3, 198)
        PortOfDischargeLabel.Name = "PortOfDischargeLabel"
        PortOfDischargeLabel.Size = New System.Drawing.Size(94, 13)
        PortOfDischargeLabel.TabIndex = 52
        PortOfDischargeLabel.Text = "Port Of Discharge:"
        '
        'PortOfDeliveryLabel
        '
        PortOfDeliveryLabel.AutoSize = True
        PortOfDeliveryLabel.Location = New System.Drawing.Point(330, 198)
        PortOfDeliveryLabel.Name = "PortOfDeliveryLabel"
        PortOfDeliveryLabel.Size = New System.Drawing.Size(84, 13)
        PortOfDeliveryLabel.TabIndex = 54
        PortOfDeliveryLabel.Text = "Port Of Delivery:"
        '
        'SailingOnLabel
        '
        SailingOnLabel.AutoSize = True
        SailingOnLabel.Location = New System.Drawing.Point(3, 221)
        SailingOnLabel.Name = "SailingOnLabel"
        SailingOnLabel.Size = New System.Drawing.Size(58, 13)
        SailingOnLabel.TabIndex = 56
        SailingOnLabel.Text = "Sailing On:"
        '
        'FreightLabel
        '
        FreightLabel.AutoSize = True
        FreightLabel.Location = New System.Drawing.Point(330, 221)
        FreightLabel.Name = "FreightLabel"
        FreightLabel.Size = New System.Drawing.Size(42, 13)
        FreightLabel.TabIndex = 58
        FreightLabel.Text = "Freight:"
        '
        'PlaceOfReceiptLabel
        '
        PlaceOfReceiptLabel.AutoSize = True
        PlaceOfReceiptLabel.Location = New System.Drawing.Point(3, 245)
        PlaceOfReceiptLabel.Name = "PlaceOfReceiptLabel"
        PlaceOfReceiptLabel.Size = New System.Drawing.Size(91, 13)
        PlaceOfReceiptLabel.TabIndex = 60
        PlaceOfReceiptLabel.Text = "Place Of Receipt:"
        '
        'PortOfLoadingLabel
        '
        PortOfLoadingLabel.AutoSize = True
        PortOfLoadingLabel.Location = New System.Drawing.Point(330, 245)
        PortOfLoadingLabel.Name = "PortOfLoadingLabel"
        PortOfLoadingLabel.Size = New System.Drawing.Size(84, 13)
        PortOfLoadingLabel.TabIndex = 62
        PortOfLoadingLabel.Text = "Port Of Loading:"
        '
        'VatRegNoLabel
        '
        VatRegNoLabel.AutoSize = True
        VatRegNoLabel.Location = New System.Drawing.Point(188, 373)
        VatRegNoLabel.Name = "VatRegNoLabel"
        VatRegNoLabel.Size = New System.Drawing.Size(66, 13)
        VatRegNoLabel.TabIndex = 64
        VatRegNoLabel.Text = "Vat Reg No:"
        '
        'TotalMesurementLabel
        '
        TotalMesurementLabel.AutoSize = True
        TotalMesurementLabel.Location = New System.Drawing.Point(332, 446)
        TotalMesurementLabel.Name = "TotalMesurementLabel"
        TotalMesurementLabel.Size = New System.Drawing.Size(118, 13)
        TotalMesurementLabel.TabIndex = 66
        TotalMesurementLabel.Text = "TTL Mesurement/VLM:"
        '
        'TotalGoodsQTYLabel
        '
        TotalGoodsQTYLabel.AutoSize = True
        TotalGoodsQTYLabel.Location = New System.Drawing.Point(3, 397)
        TotalGoodsQTYLabel.Name = "TotalGoodsQTYLabel"
        TotalGoodsQTYLabel.Size = New System.Drawing.Size(93, 13)
        TotalGoodsQTYLabel.TabIndex = 68
        TotalGoodsQTYLabel.Text = "Total Goods QTY:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(412, 79)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(33, 13)
        Label3.TabIndex = 70
        Label3.Text = "Date:"
        '
        'MasterProgramNoLabel
        '
        MasterProgramNoLabel.AutoSize = True
        MasterProgramNoLabel.Location = New System.Drawing.Point(5, 13)
        MasterProgramNoLabel.Name = "MasterProgramNoLabel"
        MasterProgramNoLabel.Size = New System.Drawing.Size(101, 13)
        MasterProgramNoLabel.TabIndex = 32
        MasterProgramNoLabel.Text = "Master Program No:"
        '
        'TermOfDeliveryLabel
        '
        TermOfDeliveryLabel.AutoSize = True
        TermOfDeliveryLabel.Location = New System.Drawing.Point(5, 420)
        TermOfDeliveryLabel.Name = "TermOfDeliveryLabel"
        TermOfDeliveryLabel.Size = New System.Drawing.Size(94, 13)
        TermOfDeliveryLabel.TabIndex = 34
        TermOfDeliveryLabel.Text = "Terms Of Delivery:"
        '
        'FinalDestinationLabel
        '
        FinalDestinationLabel.AutoSize = True
        FinalDestinationLabel.Location = New System.Drawing.Point(3, 127)
        FinalDestinationLabel.Name = "FinalDestinationLabel"
        FinalDestinationLabel.Size = New System.Drawing.Size(88, 13)
        FinalDestinationLabel.TabIndex = 36
        FinalDestinationLabel.Text = "Final Destination:"
        '
        'BGMEANoLabel
        '
        BGMEANoLabel.AutoSize = True
        BGMEANoLabel.Location = New System.Drawing.Point(331, 127)
        BGMEANoLabel.Name = "BGMEANoLabel"
        BGMEANoLabel.Size = New System.Drawing.Size(62, 13)
        BGMEANoLabel.TabIndex = 38
        BGMEANoLabel.Text = "BGMEANo:"
        '
        'DraftATLabel
        '
        DraftATLabel.AutoSize = True
        DraftATLabel.Location = New System.Drawing.Point(330, 151)
        DraftATLabel.Name = "DraftATLabel"
        DraftATLabel.Size = New System.Drawing.Size(51, 13)
        DraftATLabel.TabIndex = 40
        DraftATLabel.Text = "Drafts At:"
        '
        'DocumentNoLabel
        '
        DocumentNoLabel.AutoSize = True
        DocumentNoLabel.Location = New System.Drawing.Point(3, 173)
        DocumentNoLabel.Name = "DocumentNoLabel"
        DocumentNoLabel.Size = New System.Drawing.Size(81, 13)
        DocumentNoLabel.TabIndex = 71
        DocumentNoLabel.Text = "Documents No:"
        '
        'DocumentDateLabel
        '
        DocumentDateLabel.AutoSize = True
        DocumentDateLabel.Location = New System.Drawing.Point(214, 173)
        DocumentDateLabel.Name = "DocumentDateLabel"
        DocumentDateLabel.Size = New System.Drawing.Size(33, 13)
        DocumentDateLabel.TabIndex = 72
        DocumentDateLabel.Text = "Date:"
        '
        'EPBRegNoLabel
        '
        EPBRegNoLabel.AutoSize = True
        EPBRegNoLabel.Location = New System.Drawing.Point(3, 320)
        EPBRegNoLabel.Name = "EPBRegNoLabel"
        EPBRegNoLabel.Size = New System.Drawing.Size(68, 13)
        EPBRegNoLabel.TabIndex = 74
        EPBRegNoLabel.Text = "EPBReg No:"
        '
        'ReferenceNoLabel
        '
        ReferenceNoLabel.AutoSize = True
        ReferenceNoLabel.Location = New System.Drawing.Point(332, 270)
        ReferenceNoLabel.Name = "ReferenceNoLabel"
        ReferenceNoLabel.Size = New System.Drawing.Size(77, 13)
        ReferenceNoLabel.TabIndex = 76
        ReferenceNoLabel.Text = "Reference No:"
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(2, 267)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(48, 13)
        SupplierIdLabel.TabIndex = 42
        SupplierIdLabel.Text = "Supplier:"
        '
        'ConsigneeNotifyLabel
        '
        ConsigneeNotifyLabel.AutoSize = True
        ConsigneeNotifyLabel.Location = New System.Drawing.Point(9, 442)
        ConsigneeNotifyLabel.Name = "ConsigneeNotifyLabel"
        ConsigneeNotifyLabel.Size = New System.Drawing.Size(90, 13)
        ConsigneeNotifyLabel.TabIndex = 36
        ConsigneeNotifyLabel.Text = "Consignee Notify:"
        '
        'CommercialInvoiceDataSet
        '
        Me.CommercialInvoiceDataSet.DataSetName = "CommercialInvoiceDataSet"
        Me.CommercialInvoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CommercialInvoiceTableAdapter
        '
        Me.CommercialInvoiceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CommercialInvoiceBreakDownTableAdapter = Me.CommercialInvoiceBreakDownTableAdapter
        Me.TableAdapterManager.CommercialInvoiceMainTableAdapter = Me.CommercialInvoiceMainTableAdapter
        Me.TableAdapterManager.CommercialInvoiceTableAdapter = Me.CommercialInvoiceTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CommercialInvoiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CommercialInvoiceBreakDownTableAdapter
        '
        Me.CommercialInvoiceBreakDownTableAdapter.ClearBeforeFill = True
        '
        'CommercialInvoiceMainTableAdapter
        '
        Me.CommercialInvoiceMainTableAdapter.ClearBeforeFill = True
        '
        'CommercialInvoiceBindingNavigator
        '
        Me.CommercialInvoiceBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CommercialInvoiceBindingNavigator.BindingSource = Me.CommercialInvoiceMainBindingSource
        Me.CommercialInvoiceBindingNavigator.CountItem = Nothing
        Me.CommercialInvoiceBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CommercialInvoiceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CommercialInvoiceBindingNavigatorSaveItem})
        Me.CommercialInvoiceBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CommercialInvoiceBindingNavigator.MoveFirstItem = Nothing
        Me.CommercialInvoiceBindingNavigator.MoveLastItem = Nothing
        Me.CommercialInvoiceBindingNavigator.MoveNextItem = Nothing
        Me.CommercialInvoiceBindingNavigator.MovePreviousItem = Nothing
        Me.CommercialInvoiceBindingNavigator.Name = "CommercialInvoiceBindingNavigator"
        Me.CommercialInvoiceBindingNavigator.PositionItem = Nothing
        Me.CommercialInvoiceBindingNavigator.Size = New System.Drawing.Size(1324, 25)
        Me.CommercialInvoiceBindingNavigator.TabIndex = 4
        Me.CommercialInvoiceBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'CommercialInvoiceMainBindingSource
        '
        Me.CommercialInvoiceMainBindingSource.DataMember = "CommercialInvoiceMain"
        Me.CommercialInvoiceMainBindingSource.DataSource = Me.CommercialInvoiceDataSet
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CommercialInvoiceBindingNavigatorSaveItem
        '
        Me.CommercialInvoiceBindingNavigatorSaveItem.Image = CType(resources.GetObject("CommercialInvoiceBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CommercialInvoiceBindingNavigatorSaveItem.Name = "CommercialInvoiceBindingNavigatorSaveItem"
        Me.CommercialInvoiceBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.CommercialInvoiceBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OrderPOLookupAllBindingSource
        '
        Me.OrderPOLookupAllBindingSource.DataMember = "OrderPOLookupAll"
        Me.OrderPOLookupAllBindingSource.DataSource = Me.OrderPOLookupNewDataSet
        '
        'OrderPOLookupNewDataSet
        '
        Me.OrderPOLookupNewDataSet.DataSetName = "OrderPOLookupNewDataSet"
        Me.OrderPOLookupNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderPOLookupAllTableAdapter
        '
        Me.OrderPOLookupAllTableAdapter.ClearBeforeFill = True
        '
        'colPOAndColorAndDes
        '
        Me.colPOAndColorAndDes.FieldName = "POAndColorAndDes"
        Me.colPOAndColorAndDes.Name = "colPOAndColorAndDes"
        Me.colPOAndColorAndDes.Visible = True
        Me.colPOAndColorAndDes.VisibleIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(ConsigneeNotifyLabel)
        Me.Panel1.Controls.Add(Me.ConsigneeNotifyMemoEdit)
        Me.Panel1.Controls.Add(TermOfDeliveryLabel)
        Me.Panel1.Controls.Add(Me.TermOfDeliveryTextBox)
        Me.Panel1.Controls.Add(MasterProgramNoLabel)
        Me.Panel1.Controls.Add(Me.MasterProgramNoGridLookUpEdit)
        Me.Panel1.Controls.Add(DescriptionOfGoodsLabel)
        Me.Panel1.Controls.Add(Me.DescriptionOfGoodsTextBox)
        Me.Panel1.Controls.Add(FCALabel)
        Me.Panel1.Controls.Add(Me.FCATextBox)
        Me.Panel1.Controls.Add(ShipmentIdLabel)
        Me.Panel1.Controls.Add(Me.ShipmentIdTextBox)
        Me.Panel1.Controls.Add(Me.MLCNoGridLookUpEdit)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(RemarksLabel)
        Me.Panel1.Controls.Add(Me.RemarksTextBox)
        Me.Panel1.Controls.Add(HSCodeLabel)
        Me.Panel1.Controls.Add(Me.HSCodeTextBox)
        Me.Panel1.Controls.Add(CommercialInvoiceDateLabel)
        Me.Panel1.Controls.Add(Me.CommercialInvoiceDateDateTimePicker)
        Me.Panel1.Controls.Add(CommercialInvoiceNoLabel)
        Me.Panel1.Controls.Add(Me.CommercialInvoiceNoTextBox)
        Me.Panel1.Controls.Add(ContainerNoLabel)
        Me.Panel1.Controls.Add(Me.ContainerNoTextBox)
        Me.Panel1.Controls.Add(PrecarriageByLabel)
        Me.Panel1.Controls.Add(Me.PrecarriageByTextBox)
        Me.Panel1.Controls.Add(NotifyLabel)
        Me.Panel1.Controls.Add(Me.NotifyMemoEdit)
        Me.Panel1.Controls.Add(AccountLabel)
        Me.Panel1.Controls.Add(Me.AccountMemoEdit)
        Me.Panel1.Controls.Add(ShipperLabel)
        Me.Panel1.Controls.Add(Me.ShipperMemoEdit)
        Me.Panel1.Controls.Add(ConsigneeLabel)
        Me.Panel1.Controls.Add(Me.ConsigneeMemoEdit)
        Me.Panel1.Controls.Add(ShippingMarksFrontLabel)
        Me.Panel1.Controls.Add(Me.ShippingMarksFrontMemoEdit)
        Me.Panel1.Controls.Add(ShippingMarksSideLabel)
        Me.Panel1.Controls.Add(Me.ShippingMarksSideMemoEdit)
        Me.Panel1.Location = New System.Drawing.Point(9, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 456)
        Me.Panel1.TabIndex = 0
        '
        'ConsigneeNotifyMemoEdit
        '
        Me.ConsigneeNotifyMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CommercialInvoiceMainBindingSource, "ConsigneeNotify", True))
        Me.ConsigneeNotifyMemoEdit.Location = New System.Drawing.Point(124, 439)
        Me.ConsigneeNotifyMemoEdit.Name = "ConsigneeNotifyMemoEdit"
        Me.ConsigneeNotifyMemoEdit.Size = New System.Drawing.Size(478, 20)
        Me.ConsigneeNotifyMemoEdit.TabIndex = 37
        '
        'TermOfDeliveryTextBox
        '
        Me.TermOfDeliveryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "TermOfDelivery", True))
        Me.TermOfDeliveryTextBox.Location = New System.Drawing.Point(124, 415)
        Me.TermOfDeliveryTextBox.Name = "TermOfDeliveryTextBox"
        Me.TermOfDeliveryTextBox.Size = New System.Drawing.Size(478, 20)
        Me.TermOfDeliveryTextBox.TabIndex = 17
        '
        'MasterProgramNoGridLookUpEdit
        '
        Me.MasterProgramNoGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CommercialInvoiceMainBindingSource, "MasterProgramNo", True))
        Me.MasterProgramNoGridLookUpEdit.EditValue = ""
        Me.MasterProgramNoGridLookUpEdit.Location = New System.Drawing.Point(124, 10)
        Me.MasterProgramNoGridLookUpEdit.Name = "MasterProgramNoGridLookUpEdit"
        Me.MasterProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MasterProgramNoGridLookUpEdit.Properties.DataSource = Me.MasterOrderLookUpBindingSource
        Me.MasterProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.MasterProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.MasterProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.MasterProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.MasterProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.MasterProgramNoGridLookUpEdit.Properties.ValueMember = "MasterProgramNo"
        Me.MasterProgramNoGridLookUpEdit.Properties.View = Me.MasterProgramNoGridLookUpEditView
        Me.MasterProgramNoGridLookUpEdit.Size = New System.Drawing.Size(476, 20)
        Me.MasterProgramNoGridLookUpEdit.TabIndex = 0
        '
        'MasterOrderLookUpBindingSource
        '
        Me.MasterOrderLookUpBindingSource.DataMember = "MasterOrderLookUp"
        Me.MasterOrderLookUpBindingSource.DataSource = Me.MasterOrderLookUpDataSet
        '
        'MasterOrderLookUpDataSet
        '
        Me.MasterOrderLookUpDataSet.DataSetName = "MasterOrderLookUpDataSet"
        Me.MasterOrderLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasterProgramNoGridLookUpEditView
        '
        Me.MasterProgramNoGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMasterProgramNo})
        Me.MasterProgramNoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.MasterProgramNoGridLookUpEditView.Name = "MasterProgramNoGridLookUpEditView"
        Me.MasterProgramNoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.MasterProgramNoGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colMasterProgramNo
        '
        Me.colMasterProgramNo.FieldName = "MasterProgramNo"
        Me.colMasterProgramNo.Name = "colMasterProgramNo"
        Me.colMasterProgramNo.Visible = True
        Me.colMasterProgramNo.VisibleIndex = 0
        '
        'DescriptionOfGoodsTextBox
        '
        Me.DescriptionOfGoodsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "DescriptionOfGoods", True))
        Me.DescriptionOfGoodsTextBox.Location = New System.Drawing.Point(124, 391)
        Me.DescriptionOfGoodsTextBox.Name = "DescriptionOfGoodsTextBox"
        Me.DescriptionOfGoodsTextBox.Size = New System.Drawing.Size(478, 20)
        Me.DescriptionOfGoodsTextBox.TabIndex = 16
        '
        'FCATextBox
        '
        Me.FCATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "FCA", True))
        Me.FCATextBox.Location = New System.Drawing.Point(435, 367)
        Me.FCATextBox.Name = "FCATextBox"
        Me.FCATextBox.Size = New System.Drawing.Size(167, 20)
        Me.FCATextBox.TabIndex = 15
        Me.FCATextBox.Text = "Chittagong"
        '
        'ShipmentIdTextBox
        '
        Me.ShipmentIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "ShipmentId", True))
        Me.ShipmentIdTextBox.Location = New System.Drawing.Point(124, 367)
        Me.ShipmentIdTextBox.Name = "ShipmentIdTextBox"
        Me.ShipmentIdTextBox.Size = New System.Drawing.Size(234, 20)
        Me.ShipmentIdTextBox.TabIndex = 14
        '
        'MLCNoGridLookUpEdit
        '
        Me.MLCNoGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CommercialInvoiceMainBindingSource, "MLCNo", True))
        Me.MLCNoGridLookUpEdit.EditValue = ""
        Me.MLCNoGridLookUpEdit.Location = New System.Drawing.Point(124, 39)
        Me.MLCNoGridLookUpEdit.Name = "MLCNoGridLookUpEdit"
        Me.MLCNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MLCNoGridLookUpEdit.Properties.DataSource = Me.MasterLCLookupBindingSource
        Me.MLCNoGridLookUpEdit.Properties.DisplayMember = "RefAndMLCNo"
        Me.MLCNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.MLCNoGridLookUpEdit.Properties.NullText = ""
        Me.MLCNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.MLCNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.MLCNoGridLookUpEdit.Properties.ValueMember = "MLCId"
        Me.MLCNoGridLookUpEdit.Properties.View = Me.MLCNoGridLookUpEditView
        Me.MLCNoGridLookUpEdit.Size = New System.Drawing.Size(476, 20)
        Me.MLCNoGridLookUpEdit.TabIndex = 1
        '
        'MasterLCLookupBindingSource
        '
        Me.MasterLCLookupBindingSource.DataMember = "MasterLCLookup"
        Me.MasterLCLookupBindingSource.DataSource = Me.MasterLCDataSet
        '
        'MasterLCDataSet
        '
        Me.MasterLCDataSet.DataSetName = "MasterLCDataSet"
        Me.MasterLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MLCNoGridLookUpEditView
        '
        Me.MLCNoGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRefAndMLCNo})
        Me.MLCNoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.MLCNoGridLookUpEditView.Name = "MLCNoGridLookUpEditView"
        Me.MLCNoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.MLCNoGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colRefAndMLCNo
        '
        Me.colRefAndMLCNo.FieldName = "RefAndMLCNo"
        Me.colRefAndMLCNo.Name = "colRefAndMLCNo"
        Me.colRefAndMLCNo.Visible = True
        Me.colRefAndMLCNo.VisibleIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Master LC / Ref.  No : "
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(124, 320)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(234, 20)
        Me.RemarksTextBox.TabIndex = 10
        '
        'HSCodeTextBox
        '
        Me.HSCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "HSCode", True))
        Me.HSCodeTextBox.Location = New System.Drawing.Point(435, 320)
        Me.HSCodeTextBox.Name = "HSCodeTextBox"
        Me.HSCodeTextBox.Size = New System.Drawing.Size(166, 20)
        Me.HSCodeTextBox.TabIndex = 11
        '
        'CommercialInvoiceDateDateTimePicker
        '
        Me.CommercialInvoiceDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.CommercialInvoiceDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CommercialInvoiceMainBindingSource, "CommercialInvoiceDate", True))
        Me.CommercialInvoiceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CommercialInvoiceDateDateTimePicker.Location = New System.Drawing.Point(494, 69)
        Me.CommercialInvoiceDateDateTimePicker.Name = "CommercialInvoiceDateDateTimePicker"
        Me.CommercialInvoiceDateDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.CommercialInvoiceDateDateTimePicker.TabIndex = 3
        '
        'CommercialInvoiceNoTextBox
        '
        Me.CommercialInvoiceNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "CommercialInvoiceNo", True))
        Me.CommercialInvoiceNoTextBox.Location = New System.Drawing.Point(124, 70)
        Me.CommercialInvoiceNoTextBox.Name = "CommercialInvoiceNoTextBox"
        Me.CommercialInvoiceNoTextBox.Size = New System.Drawing.Size(287, 20)
        Me.CommercialInvoiceNoTextBox.TabIndex = 2
        '
        'ContainerNoTextBox
        '
        Me.ContainerNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "ContainerNo", True))
        Me.ContainerNoTextBox.Location = New System.Drawing.Point(435, 343)
        Me.ContainerNoTextBox.Name = "ContainerNoTextBox"
        Me.ContainerNoTextBox.Size = New System.Drawing.Size(166, 20)
        Me.ContainerNoTextBox.TabIndex = 13
        '
        'PrecarriageByTextBox
        '
        Me.PrecarriageByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "PrecarriageBy", True))
        Me.PrecarriageByTextBox.Location = New System.Drawing.Point(124, 343)
        Me.PrecarriageByTextBox.Name = "PrecarriageByTextBox"
        Me.PrecarriageByTextBox.Size = New System.Drawing.Size(234, 20)
        Me.PrecarriageByTextBox.TabIndex = 12
        '
        'NotifyMemoEdit
        '
        Me.NotifyMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CommercialInvoiceMainBindingSource, "Notify", True))
        Me.NotifyMemoEdit.Location = New System.Drawing.Point(305, 191)
        Me.NotifyMemoEdit.Name = "NotifyMemoEdit"
        Me.NotifyMemoEdit.Size = New System.Drawing.Size(295, 50)
        Me.NotifyMemoEdit.TabIndex = 7
        '
        'AccountMemoEdit
        '
        Me.AccountMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CommercialInvoiceMainBindingSource, "Account", True))
        Me.AccountMemoEdit.Location = New System.Drawing.Point(1, 191)
        Me.AccountMemoEdit.Name = "AccountMemoEdit"
        Me.AccountMemoEdit.Size = New System.Drawing.Size(295, 50)
        Me.AccountMemoEdit.TabIndex = 6
        '
        'ShipperMemoEdit
        '
        Me.ShipperMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CommercialInvoiceMainBindingSource, "Shipper", True))
        Me.ShipperMemoEdit.Location = New System.Drawing.Point(307, 121)
        Me.ShipperMemoEdit.Name = "ShipperMemoEdit"
        Me.ShipperMemoEdit.Size = New System.Drawing.Size(295, 50)
        Me.ShipperMemoEdit.TabIndex = 5
        '
        'ConsigneeMemoEdit
        '
        Me.ConsigneeMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CommercialInvoiceMainBindingSource, "Consignee", True))
        Me.ConsigneeMemoEdit.Location = New System.Drawing.Point(3, 121)
        Me.ConsigneeMemoEdit.Name = "ConsigneeMemoEdit"
        Me.ConsigneeMemoEdit.Size = New System.Drawing.Size(298, 50)
        Me.ConsigneeMemoEdit.TabIndex = 4
        '
        'ShippingMarksFrontMemoEdit
        '
        Me.ShippingMarksFrontMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CommercialInvoiceMainBindingSource, "ShippingMarksFront", True))
        Me.ShippingMarksFrontMemoEdit.Location = New System.Drawing.Point(6, 264)
        Me.ShippingMarksFrontMemoEdit.Name = "ShippingMarksFrontMemoEdit"
        Me.ShippingMarksFrontMemoEdit.Size = New System.Drawing.Size(295, 50)
        Me.ShippingMarksFrontMemoEdit.TabIndex = 8
        '
        'ShippingMarksSideMemoEdit
        '
        Me.ShippingMarksSideMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CommercialInvoiceMainBindingSource, "ShippingMarksSide", True))
        Me.ShippingMarksSideMemoEdit.Location = New System.Drawing.Point(307, 264)
        Me.ShippingMarksSideMemoEdit.Name = "ShippingMarksSideMemoEdit"
        Me.ShippingMarksSideMemoEdit.Size = New System.Drawing.Size(295, 50)
        Me.ShippingMarksSideMemoEdit.TabIndex = 9
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.CommercialInvoiceGridControl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CommercialInvoiceBreakDownGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1324, 637)
        Me.SplitContainer1.SplitterDistance = 466
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(SupplierIdLabel)
        Me.Panel2.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.Panel2.Controls.Add(ReferenceNoLabel)
        Me.Panel2.Controls.Add(Me.ReferenceNoTextBox)
        Me.Panel2.Controls.Add(DraftATLabel)
        Me.Panel2.Controls.Add(Me.DraftATTextBox)
        Me.Panel2.Controls.Add(EPBRegNoLabel)
        Me.Panel2.Controls.Add(Me.EPBRegNoTextBox)
        Me.Panel2.Controls.Add(BGMEANoLabel)
        Me.Panel2.Controls.Add(Me.BGMEANoTextBox)
        Me.Panel2.Controls.Add(DocumentDateLabel)
        Me.Panel2.Controls.Add(Me.DocumentDateDateTimePicker)
        Me.Panel2.Controls.Add(FinalDestinationLabel)
        Me.Panel2.Controls.Add(Me.FinalDestinationTextBox)
        Me.Panel2.Controls.Add(DocumentNoLabel)
        Me.Panel2.Controls.Add(Me.DocumentNoTextBox)
        Me.Panel2.Controls.Add(Me.ApplicantBankMemoEdit)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.TotalGoodsQTYTextBox)
        Me.Panel2.Controls.Add(TotalGoodsQTYLabel)
        Me.Panel2.Controls.Add(Me.TotalGrossWeightTextBox)
        Me.Panel2.Controls.Add(Me.TotalMesurementTextBox)
        Me.Panel2.Controls.Add(Me.JOBTextBox)
        Me.Panel2.Controls.Add(Me.VatRegNoTextBox)
        Me.Panel2.Controls.Add(VatRegNoLabel)
        Me.Panel2.Controls.Add(PortOfLoadingLabel)
        Me.Panel2.Controls.Add(Me.PortOfLoadingTextBox)
        Me.Panel2.Controls.Add(PlaceOfReceiptLabel)
        Me.Panel2.Controls.Add(Me.PlaceOfReceiptTextBox)
        Me.Panel2.Controls.Add(FreightLabel)
        Me.Panel2.Controls.Add(Me.FreightTextBox)
        Me.Panel2.Controls.Add(SailingOnLabel)
        Me.Panel2.Controls.Add(Me.SailingOnTextBox)
        Me.Panel2.Controls.Add(PortOfDeliveryLabel)
        Me.Panel2.Controls.Add(Me.PortOfDeliveryTextBox)
        Me.Panel2.Controls.Add(PortOfDischargeLabel)
        Me.Panel2.Controls.Add(Me.PortOfDischargeTextBox)
        Me.Panel2.Controls.Add(ApplicantBankLabel)
        Me.Panel2.Controls.Add(ContactNoLabel)
        Me.Panel2.Controls.Add(Me.ContactNoTextBox)
        Me.Panel2.Controls.Add(BookingNoLabel)
        Me.Panel2.Controls.Add(Me.BookingNoTextBox)
        Me.Panel2.Controls.Add(CountryOfOriginLabel)
        Me.Panel2.Controls.Add(Me.CountryOfOriginTextBox)
        Me.Panel2.Controls.Add(Me.PaymentDateDateTimePicker)
        Me.Panel2.Controls.Add(UDLabel)
        Me.Panel2.Controls.Add(Me.UDTextBox)
        Me.Panel2.Controls.Add(JOBLabel)
        Me.Panel2.Controls.Add(PaymentLabel)
        Me.Panel2.Controls.Add(Me.PaymentTextBox)
        Me.Panel2.Controls.Add(ExportLCDateLabel)
        Me.Panel2.Controls.Add(Me.ExportLCDateDateTimePicker)
        Me.Panel2.Controls.Add(ExportLCLabel)
        Me.Panel2.Controls.Add(Me.ExportLCTextBox)
        Me.Panel2.Controls.Add(TotalCartonsLabel)
        Me.Panel2.Controls.Add(Me.TotalCartonsTextBox)
        Me.Panel2.Controls.Add(ShipmentToLabel)
        Me.Panel2.Controls.Add(Me.ShipmentToTextBox)
        Me.Panel2.Controls.Add(ShipmentFromLabel)
        Me.Panel2.Controls.Add(Me.ShipmentFromTextBox)
        Me.Panel2.Controls.Add(ShipmentByLabel1)
        Me.Panel2.Controls.Add(Me.ShipmentByComboBox)
        Me.Panel2.Controls.Add(CartonMeasurementLabel)
        Me.Panel2.Controls.Add(Me.CartonMeasurementTextBox)
        Me.Panel2.Controls.Add(TotalGrossWeightLabel)
        Me.Panel2.Controls.Add(TotalNetWeightLabel)
        Me.Panel2.Controls.Add(Me.TotalNetWeightTextBox)
        Me.Panel2.Controls.Add(SupplierRefNoLabel1)
        Me.Panel2.Controls.Add(Me.SupplierRefNoTextBox)
        Me.Panel2.Controls.Add(ERCDateLabel)
        Me.Panel2.Controls.Add(Me.ERCDateDateTimePicker)
        Me.Panel2.Controls.Add(ERCNoLabel)
        Me.Panel2.Controls.Add(Me.ERCNoTextBox)
        Me.Panel2.Controls.Add(BillDateLabel)
        Me.Panel2.Controls.Add(Me.BillDateDateTimePicker)
        Me.Panel2.Controls.Add(BillNoLabel)
        Me.Panel2.Controls.Add(Me.BillNoTextBox)
        Me.Panel2.Controls.Add(ExportCountDateLabel)
        Me.Panel2.Controls.Add(Me.ExportCountDateDateTimePicker)
        Me.Panel2.Controls.Add(ExportCountNoLabel)
        Me.Panel2.Controls.Add(Me.ExportCountNoTextBox)
        Me.Panel2.Controls.Add(ExpDateLabel)
        Me.Panel2.Controls.Add(Me.ExpDateDateTimePicker)
        Me.Panel2.Controls.Add(ExpNoLabel)
        Me.Panel2.Controls.Add(Me.ExpNoTextBox)
        Me.Panel2.Controls.Add(TotalMesurementLabel)
        Me.Panel2.Location = New System.Drawing.Point(646, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(665, 456)
        Me.Panel2.TabIndex = 1
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CommercialInvoiceMainBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(100, 267)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SupplierIdGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Properties.View = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(222, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 25
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
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierName1})
        Me.SupplierIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIdGridLookUpEditView.Name = "SupplierIdGridLookUpEditView"
        Me.SupplierIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
        Me.colSupplierName1.Visible = True
        Me.colSupplierName1.VisibleIndex = 0
        '
        'ReferenceNoTextBox
        '
        Me.ReferenceNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "ReferenceNo", True))
        Me.ReferenceNoTextBox.Location = New System.Drawing.Point(443, 267)
        Me.ReferenceNoTextBox.Name = "ReferenceNoTextBox"
        Me.ReferenceNoTextBox.Size = New System.Drawing.Size(199, 20)
        Me.ReferenceNoTextBox.TabIndex = 26
        '
        'DraftATTextBox
        '
        Me.DraftATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "DraftAT", True))
        Me.DraftATTextBox.Location = New System.Drawing.Point(444, 148)
        Me.DraftATTextBox.Name = "DraftATTextBox"
        Me.DraftATTextBox.Size = New System.Drawing.Size(198, 20)
        Me.DraftATTextBox.TabIndex = 15
        '
        'EPBRegNoTextBox
        '
        Me.EPBRegNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "EPBRegNo", True))
        Me.EPBRegNoTextBox.Location = New System.Drawing.Point(100, 318)
        Me.EPBRegNoTextBox.Name = "EPBRegNoTextBox"
        Me.EPBRegNoTextBox.Size = New System.Drawing.Size(226, 20)
        Me.EPBRegNoTextBox.TabIndex = 30
        '
        'BGMEANoTextBox
        '
        Me.BGMEANoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "BGMEANo", True))
        Me.BGMEANoTextBox.Location = New System.Drawing.Point(444, 124)
        Me.BGMEANoTextBox.Name = "BGMEANoTextBox"
        Me.BGMEANoTextBox.Size = New System.Drawing.Size(199, 20)
        Me.BGMEANoTextBox.TabIndex = 13
        '
        'DocumentDateDateTimePicker
        '
        Me.DocumentDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.DocumentDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CommercialInvoiceMainBindingSource, "DocumentDate", True))
        Me.DocumentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DocumentDateDateTimePicker.Location = New System.Drawing.Point(247, 171)
        Me.DocumentDateDateTimePicker.Name = "DocumentDateDateTimePicker"
        Me.DocumentDateDateTimePicker.Size = New System.Drawing.Size(77, 20)
        Me.DocumentDateDateTimePicker.TabIndex = 17
        '
        'FinalDestinationTextBox
        '
        Me.FinalDestinationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "FinalDestination", True))
        Me.FinalDestinationTextBox.Location = New System.Drawing.Point(96, 124)
        Me.FinalDestinationTextBox.Name = "FinalDestinationTextBox"
        Me.FinalDestinationTextBox.Size = New System.Drawing.Size(227, 20)
        Me.FinalDestinationTextBox.TabIndex = 12
        '
        'DocumentNoTextBox
        '
        Me.DocumentNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "DocumentNo", True))
        Me.DocumentNoTextBox.Location = New System.Drawing.Point(97, 170)
        Me.DocumentNoTextBox.Name = "DocumentNoTextBox"
        Me.DocumentNoTextBox.Size = New System.Drawing.Size(111, 20)
        Me.DocumentNoTextBox.TabIndex = 16
        '
        'ApplicantBankMemoEdit
        '
        Me.ApplicantBankMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CommercialInvoiceMainBindingSource, "ApplicantBank", True))
        Me.ApplicantBankMemoEdit.Location = New System.Drawing.Point(443, 171)
        Me.ApplicantBankMemoEdit.Name = "ApplicantBankMemoEdit"
        Me.ApplicantBankMemoEdit.Size = New System.Drawing.Size(199, 20)
        Me.ApplicantBankMemoEdit.TabIndex = 18
        '
        'TotalGoodsQTYTextBox
        '
        Me.TotalGoodsQTYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "TotalGoodsQTY", True))
        Me.TotalGoodsQTYTextBox.Location = New System.Drawing.Point(100, 395)
        Me.TotalGoodsQTYTextBox.Name = "TotalGoodsQTYTextBox"
        Me.TotalGoodsQTYTextBox.Size = New System.Drawing.Size(226, 20)
        Me.TotalGoodsQTYTextBox.TabIndex = 37
        '
        'TotalGrossWeightTextBox
        '
        Me.TotalGrossWeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "TotalGrossWeight", True))
        Me.TotalGrossWeightTextBox.Location = New System.Drawing.Point(100, 419)
        Me.TotalGrossWeightTextBox.Name = "TotalGrossWeightTextBox"
        Me.TotalGrossWeightTextBox.Size = New System.Drawing.Size(226, 20)
        Me.TotalGrossWeightTextBox.TabIndex = 39
        '
        'TotalMesurementTextBox
        '
        Me.TotalMesurementTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "TotalMesurement", True))
        Me.TotalMesurementTextBox.Location = New System.Drawing.Point(444, 442)
        Me.TotalMesurementTextBox.Name = "TotalMesurementTextBox"
        Me.TotalMesurementTextBox.Size = New System.Drawing.Size(199, 20)
        Me.TotalMesurementTextBox.TabIndex = 42
        '
        'JOBTextBox
        '
        Me.JOBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "JOB", True))
        Me.JOBTextBox.Location = New System.Drawing.Point(219, 77)
        Me.JOBTextBox.Name = "JOBTextBox"
        Me.JOBTextBox.Size = New System.Drawing.Size(81, 20)
        Me.JOBTextBox.TabIndex = 7
        '
        'VatRegNoTextBox
        '
        Me.VatRegNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "VatRegNo", True))
        Me.VatRegNoTextBox.Location = New System.Drawing.Point(250, 370)
        Me.VatRegNoTextBox.Name = "VatRegNoTextBox"
        Me.VatRegNoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.VatRegNoTextBox.TabIndex = 35
        '
        'PortOfLoadingTextBox
        '
        Me.PortOfLoadingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "PortOfLoading", True))
        Me.PortOfLoadingTextBox.Location = New System.Drawing.Point(443, 242)
        Me.PortOfLoadingTextBox.Name = "PortOfLoadingTextBox"
        Me.PortOfLoadingTextBox.Size = New System.Drawing.Size(199, 20)
        Me.PortOfLoadingTextBox.TabIndex = 24
        '
        'PlaceOfReceiptTextBox
        '
        Me.PlaceOfReceiptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "PlaceOfReceipt", True))
        Me.PlaceOfReceiptTextBox.Location = New System.Drawing.Point(97, 242)
        Me.PlaceOfReceiptTextBox.Name = "PlaceOfReceiptTextBox"
        Me.PlaceOfReceiptTextBox.Size = New System.Drawing.Size(225, 20)
        Me.PlaceOfReceiptTextBox.TabIndex = 23
        '
        'FreightTextBox
        '
        Me.FreightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "Freight", True))
        Me.FreightTextBox.Location = New System.Drawing.Point(443, 218)
        Me.FreightTextBox.Name = "FreightTextBox"
        Me.FreightTextBox.Size = New System.Drawing.Size(199, 20)
        Me.FreightTextBox.TabIndex = 22
        '
        'SailingOnTextBox
        '
        Me.SailingOnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "SailingOn", True))
        Me.SailingOnTextBox.Location = New System.Drawing.Point(97, 218)
        Me.SailingOnTextBox.Name = "SailingOnTextBox"
        Me.SailingOnTextBox.Size = New System.Drawing.Size(225, 20)
        Me.SailingOnTextBox.TabIndex = 21
        '
        'PortOfDeliveryTextBox
        '
        Me.PortOfDeliveryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "PortOfDelivery", True))
        Me.PortOfDeliveryTextBox.Location = New System.Drawing.Point(443, 195)
        Me.PortOfDeliveryTextBox.Name = "PortOfDeliveryTextBox"
        Me.PortOfDeliveryTextBox.Size = New System.Drawing.Size(199, 20)
        Me.PortOfDeliveryTextBox.TabIndex = 20
        '
        'PortOfDischargeTextBox
        '
        Me.PortOfDischargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "PortOfDischarge", True))
        Me.PortOfDischargeTextBox.Location = New System.Drawing.Point(97, 195)
        Me.PortOfDischargeTextBox.Name = "PortOfDischargeTextBox"
        Me.PortOfDischargeTextBox.Size = New System.Drawing.Size(225, 20)
        Me.PortOfDischargeTextBox.TabIndex = 19
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "ContactNo", True))
        Me.ContactNoTextBox.Location = New System.Drawing.Point(97, 148)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(225, 20)
        Me.ContactNoTextBox.TabIndex = 14
        '
        'BookingNoTextBox
        '
        Me.BookingNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "BookingNo", True))
        Me.BookingNoTextBox.Location = New System.Drawing.Point(443, 100)
        Me.BookingNoTextBox.Name = "BookingNoTextBox"
        Me.BookingNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BookingNoTextBox.TabIndex = 11
        '
        'CountryOfOriginTextBox
        '
        Me.CountryOfOriginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "CountryOfOrigin", True))
        Me.CountryOfOriginTextBox.Location = New System.Drawing.Point(97, 100)
        Me.CountryOfOriginTextBox.Name = "CountryOfOriginTextBox"
        Me.CountryOfOriginTextBox.Size = New System.Drawing.Size(225, 20)
        Me.CountryOfOriginTextBox.TabIndex = 10
        '
        'PaymentDateDateTimePicker
        '
        Me.PaymentDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.PaymentDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CommercialInvoiceMainBindingSource, "PaymentDate", True))
        Me.PaymentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PaymentDateDateTimePicker.Location = New System.Drawing.Point(514, 76)
        Me.PaymentDateDateTimePicker.Name = "PaymentDateDateTimePicker"
        Me.PaymentDateDateTimePicker.Size = New System.Drawing.Size(128, 20)
        Me.PaymentDateDateTimePicker.TabIndex = 9
        '
        'UDTextBox
        '
        Me.UDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "UD", True))
        Me.UDTextBox.Location = New System.Drawing.Point(333, 77)
        Me.UDTextBox.Name = "UDTextBox"
        Me.UDTextBox.Size = New System.Drawing.Size(73, 20)
        Me.UDTextBox.TabIndex = 8
        '
        'PaymentTextBox
        '
        Me.PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "Payment", True))
        Me.PaymentTextBox.Location = New System.Drawing.Point(97, 76)
        Me.PaymentTextBox.Name = "PaymentTextBox"
        Me.PaymentTextBox.Size = New System.Drawing.Size(89, 20)
        Me.PaymentTextBox.TabIndex = 6
        '
        'ExportLCDateDateTimePicker
        '
        Me.ExportLCDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ExportLCDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CommercialInvoiceMainBindingSource, "ExportLCDate", True))
        Me.ExportLCDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ExportLCDateDateTimePicker.Location = New System.Drawing.Point(515, 52)
        Me.ExportLCDateDateTimePicker.Name = "ExportLCDateDateTimePicker"
        Me.ExportLCDateDateTimePicker.Size = New System.Drawing.Size(127, 20)
        Me.ExportLCDateDateTimePicker.TabIndex = 5
        '
        'ExportLCTextBox
        '
        Me.ExportLCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "ExportLC", True))
        Me.ExportLCTextBox.Location = New System.Drawing.Point(97, 53)
        Me.ExportLCTextBox.Name = "ExportLCTextBox"
        Me.ExportLCTextBox.Size = New System.Drawing.Size(309, 20)
        Me.ExportLCTextBox.TabIndex = 4
        '
        'TotalCartonsTextBox
        '
        Me.TotalCartonsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "TotalCartons", True))
        Me.TotalCartonsTextBox.Location = New System.Drawing.Point(444, 394)
        Me.TotalCartonsTextBox.Name = "TotalCartonsTextBox"
        Me.TotalCartonsTextBox.Size = New System.Drawing.Size(199, 20)
        Me.TotalCartonsTextBox.TabIndex = 38
        '
        'ShipmentToTextBox
        '
        Me.ShipmentToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "ShipmentTo", True))
        Me.ShipmentToTextBox.Location = New System.Drawing.Point(445, 369)
        Me.ShipmentToTextBox.Name = "ShipmentToTextBox"
        Me.ShipmentToTextBox.Size = New System.Drawing.Size(198, 20)
        Me.ShipmentToTextBox.TabIndex = 36
        '
        'ShipmentFromTextBox
        '
        Me.ShipmentFromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "ShipmentFrom", True))
        Me.ShipmentFromTextBox.Location = New System.Drawing.Point(445, 344)
        Me.ShipmentFromTextBox.Name = "ShipmentFromTextBox"
        Me.ShipmentFromTextBox.Size = New System.Drawing.Size(198, 20)
        Me.ShipmentFromTextBox.TabIndex = 33
        '
        'ShipmentByComboBox
        '
        Me.ShipmentByComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "ShipmentBy", True))
        Me.ShipmentByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShipmentByComboBox.FormattingEnabled = True
        Me.ShipmentByComboBox.Items.AddRange(New Object() {"Sea", "Air", "Sea_Air"})
        Me.ShipmentByComboBox.Location = New System.Drawing.Point(445, 317)
        Me.ShipmentByComboBox.Name = "ShipmentByComboBox"
        Me.ShipmentByComboBox.Size = New System.Drawing.Size(198, 21)
        Me.ShipmentByComboBox.TabIndex = 31
        '
        'CartonMeasurementTextBox
        '
        Me.CartonMeasurementTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "CartonMeasurement", True))
        Me.CartonMeasurementTextBox.Location = New System.Drawing.Point(444, 418)
        Me.CartonMeasurementTextBox.Name = "CartonMeasurementTextBox"
        Me.CartonMeasurementTextBox.Size = New System.Drawing.Size(199, 20)
        Me.CartonMeasurementTextBox.TabIndex = 40
        '
        'TotalNetWeightTextBox
        '
        Me.TotalNetWeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "TotalNetWeight", True))
        Me.TotalNetWeightTextBox.Location = New System.Drawing.Point(100, 443)
        Me.TotalNetWeightTextBox.Name = "TotalNetWeightTextBox"
        Me.TotalNetWeightTextBox.Size = New System.Drawing.Size(226, 20)
        Me.TotalNetWeightTextBox.TabIndex = 41
        '
        'SupplierRefNoTextBox
        '
        Me.SupplierRefNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "SupplierRefNo", True))
        Me.SupplierRefNoTextBox.Location = New System.Drawing.Point(445, 292)
        Me.SupplierRefNoTextBox.Name = "SupplierRefNoTextBox"
        Me.SupplierRefNoTextBox.Size = New System.Drawing.Size(198, 20)
        Me.SupplierRefNoTextBox.TabIndex = 29
        '
        'ERCDateDateTimePicker
        '
        Me.ERCDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ERCDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CommercialInvoiceMainBindingSource, "ERCDate", True))
        Me.ERCDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ERCDateDateTimePicker.Location = New System.Drawing.Point(100, 371)
        Me.ERCDateDateTimePicker.Name = "ERCDateDateTimePicker"
        Me.ERCDateDateTimePicker.Size = New System.Drawing.Size(85, 20)
        Me.ERCDateDateTimePicker.TabIndex = 34
        '
        'ERCNoTextBox
        '
        Me.ERCNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "ERCNo", True))
        Me.ERCNoTextBox.Location = New System.Drawing.Point(100, 345)
        Me.ERCNoTextBox.Name = "ERCNoTextBox"
        Me.ERCNoTextBox.Size = New System.Drawing.Size(226, 20)
        Me.ERCNoTextBox.TabIndex = 32
        '
        'BillDateDateTimePicker
        '
        Me.BillDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.BillDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CommercialInvoiceMainBindingSource, "BillDate", True))
        Me.BillDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BillDateDateTimePicker.Location = New System.Drawing.Point(250, 293)
        Me.BillDateDateTimePicker.Name = "BillDateDateTimePicker"
        Me.BillDateDateTimePicker.Size = New System.Drawing.Size(76, 20)
        Me.BillDateDateTimePicker.TabIndex = 28
        '
        'BillNoTextBox
        '
        Me.BillNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "BillNo", True))
        Me.BillNoTextBox.Location = New System.Drawing.Point(100, 293)
        Me.BillNoTextBox.Name = "BillNoTextBox"
        Me.BillNoTextBox.Size = New System.Drawing.Size(111, 20)
        Me.BillNoTextBox.TabIndex = 27
        '
        'ExportCountDateDateTimePicker
        '
        Me.ExportCountDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ExportCountDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CommercialInvoiceMainBindingSource, "ExportCountDate", True))
        Me.ExportCountDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ExportCountDateDateTimePicker.Location = New System.Drawing.Point(515, 29)
        Me.ExportCountDateDateTimePicker.Name = "ExportCountDateDateTimePicker"
        Me.ExportCountDateDateTimePicker.Size = New System.Drawing.Size(127, 20)
        Me.ExportCountDateDateTimePicker.TabIndex = 3
        '
        'ExportCountNoTextBox
        '
        Me.ExportCountNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "ExportCountNo", True))
        Me.ExportCountNoTextBox.Location = New System.Drawing.Point(97, 29)
        Me.ExportCountNoTextBox.Name = "ExportCountNoTextBox"
        Me.ExportCountNoTextBox.Size = New System.Drawing.Size(309, 20)
        Me.ExportCountNoTextBox.TabIndex = 2
        '
        'ExpDateDateTimePicker
        '
        Me.ExpDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ExpDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CommercialInvoiceMainBindingSource, "ExpDate", True))
        Me.ExpDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ExpDateDateTimePicker.Location = New System.Drawing.Point(515, 6)
        Me.ExpDateDateTimePicker.Name = "ExpDateDateTimePicker"
        Me.ExpDateDateTimePicker.Size = New System.Drawing.Size(128, 20)
        Me.ExpDateDateTimePicker.TabIndex = 1
        '
        'ExpNoTextBox
        '
        Me.ExpNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommercialInvoiceMainBindingSource, "ExpNo", True))
        Me.ExpNoTextBox.Location = New System.Drawing.Point(97, 6)
        Me.ExpNoTextBox.Name = "ExpNoTextBox"
        Me.ExpNoTextBox.Size = New System.Drawing.Size(309, 20)
        Me.ExpNoTextBox.TabIndex = 0
        '
        'CommercialInvoiceGridControl
        '
        Me.CommercialInvoiceGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommercialInvoiceGridControl.DataSource = Me.CommercialInvoiceBindingSource
        Me.CommercialInvoiceGridControl.Location = New System.Drawing.Point(3, 3)
        Me.CommercialInvoiceGridControl.MainView = Me.GridView1
        Me.CommercialInvoiceGridControl.Name = "CommercialInvoiceGridControl"
        Me.CommercialInvoiceGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1})
        Me.CommercialInvoiceGridControl.Size = New System.Drawing.Size(876, 157)
        Me.CommercialInvoiceGridControl.TabIndex = 1
        Me.CommercialInvoiceGridControl.UseEmbeddedNavigator = True
        Me.CommercialInvoiceGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CommercialInvoiceBindingSource
        '
        Me.CommercialInvoiceBindingSource.DataMember = "CommercialInvoiceMain_CommercialInvoice"
        Me.CommercialInvoiceBindingSource.DataSource = Me.CommercialInvoiceMainBindingSource
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderDetailsId, Me.colRemarks, Me.colQuantity, Me.colUnitPrice, Me.colTTLAmount, Me.colArticleNo, Me.colAsPerContact, Me.colNetInvoiceValue, Me.colBankRealization, Me.colKimball, Me.colPOC, Me.colBrand})
        Me.GridView1.GridControl = Me.CommercialInvoiceGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colOrderDetailsId
        '
        Me.colOrderDetailsId.Caption = "PO :: Style :: Colour :: Destination"
        Me.colOrderDetailsId.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colOrderDetailsId.FieldName = "OrderDetailsId"
        Me.colOrderDetailsId.Name = "colOrderDetailsId"
        Me.colOrderDetailsId.Visible = True
        Me.colOrderDetailsId.VisibleIndex = 2
        Me.colOrderDetailsId.Width = 122
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.OrderPOLookupAllBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "POAndStyleAndColorAndDes"
        Me.RepositoryItemGridLookUpEdit1.ImmediatePopup = True
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "OrderDetailsId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPOAndStyleAndColorAndDes})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colPOAndStyleAndColorAndDes
        '
        Me.colPOAndStyleAndColorAndDes.Caption = "PO And Style And Color And Des"
        Me.colPOAndStyleAndColorAndDes.FieldName = "POAndStyleAndColorAndDes"
        Me.colPOAndStyleAndColorAndDes.Name = "colPOAndStyleAndColorAndDes"
        Me.colPOAndStyleAndColorAndDes.Visible = True
        Me.colPOAndStyleAndColorAndDes.VisibleIndex = 0
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 11
        Me.colRemarks.Width = 123
        '
        'colQuantity
        '
        Me.colQuantity.Caption = "Quantity Pcs"
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 5
        Me.colQuantity.Width = 51
        '
        'colUnitPrice
        '
        Me.colUnitPrice.Caption = "Unit Price USD/Pcs FOB(Chittagong)"
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 7
        Me.colUnitPrice.Width = 52
        '
        'colTTLAmount
        '
        Me.colTTLAmount.Caption = "Total Amount $"
        Me.colTTLAmount.FieldName = "TTLAmount"
        Me.colTTLAmount.Name = "colTTLAmount"
        Me.colTTLAmount.OptionsColumn.ReadOnly = True
        Me.colTTLAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTTLAmount.Visible = True
        Me.colTTLAmount.VisibleIndex = 8
        Me.colTTLAmount.Width = 67
        '
        'colArticleNo
        '
        Me.colArticleNo.FieldName = "ArticleNo"
        Me.colArticleNo.Name = "colArticleNo"
        Me.colArticleNo.Visible = True
        Me.colArticleNo.VisibleIndex = 1
        Me.colArticleNo.Width = 54
        '
        'colAsPerContact
        '
        Me.colAsPerContact.Caption = "As Per Contact Retention Fee %"
        Me.colAsPerContact.FieldName = "AsPerContact"
        Me.colAsPerContact.Name = "colAsPerContact"
        Me.colAsPerContact.Visible = True
        Me.colAsPerContact.VisibleIndex = 9
        Me.colAsPerContact.Width = 79
        '
        'colNetInvoiceValue
        '
        Me.colNetInvoiceValue.Caption = "Net Invoice Value $"
        Me.colNetInvoiceValue.FieldName = "NetInvoiceValue"
        Me.colNetInvoiceValue.Name = "colNetInvoiceValue"
        Me.colNetInvoiceValue.Visible = True
        Me.colNetInvoiceValue.VisibleIndex = 10
        Me.colNetInvoiceValue.Width = 69
        '
        'colBankRealization
        '
        Me.colBankRealization.FieldName = "BankRealization"
        Me.colBankRealization.Name = "colBankRealization"
        Me.colBankRealization.Visible = True
        Me.colBankRealization.VisibleIndex = 4
        Me.colBankRealization.Width = 63
        '
        'colKimball
        '
        Me.colKimball.FieldName = "Kimball"
        Me.colKimball.Name = "colKimball"
        Me.colKimball.Visible = True
        Me.colKimball.VisibleIndex = 6
        Me.colKimball.Width = 49
        '
        'colPOC
        '
        Me.colPOC.Caption = "POC#"
        Me.colPOC.FieldName = "POC"
        Me.colPOC.Name = "colPOC"
        Me.colPOC.Visible = True
        Me.colPOC.VisibleIndex = 3
        Me.colPOC.Width = 61
        '
        'colBrand
        '
        Me.colBrand.FieldName = "Brand"
        Me.colBrand.Name = "colBrand"
        Me.colBrand.Visible = True
        Me.colBrand.VisibleIndex = 0
        Me.colBrand.Width = 68
        '
        'CommercialInvoiceBreakDownGridControl
        '
        Me.CommercialInvoiceBreakDownGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommercialInvoiceBreakDownGridControl.DataSource = Me.CommercialInvoiceBreakDownBindingSource
        Me.CommercialInvoiceBreakDownGridControl.Location = New System.Drawing.Point(896, 3)
        Me.CommercialInvoiceBreakDownGridControl.MainView = Me.GridView2
        Me.CommercialInvoiceBreakDownGridControl.Name = "CommercialInvoiceBreakDownGridControl"
        Me.CommercialInvoiceBreakDownGridControl.Size = New System.Drawing.Size(420, 157)
        Me.CommercialInvoiceBreakDownGridControl.TabIndex = 3
        Me.CommercialInvoiceBreakDownGridControl.UseEmbeddedNavigator = True
        Me.CommercialInvoiceBreakDownGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'CommercialInvoiceBreakDownBindingSource
        '
        Me.CommercialInvoiceBreakDownBindingSource.DataMember = "CommercialInvoiceMain_CommercialInvoiceBreakDown"
        Me.CommercialInvoiceBreakDownBindingSource.DataSource = Me.CommercialInvoiceMainBindingSource
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView2.ColumnPanelRowHeight = 40
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCounrty, Me.colCarton, Me.colQuantity1})
        Me.GridView2.GridControl = Me.CommercialInvoiceBreakDownGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colCounrty
        '
        Me.colCounrty.Caption = "Country"
        Me.colCounrty.FieldName = "Counrty"
        Me.colCounrty.Name = "colCounrty"
        Me.colCounrty.Visible = True
        Me.colCounrty.VisibleIndex = 0
        '
        'colCarton
        '
        Me.colCarton.FieldName = "Carton"
        Me.colCarton.Name = "colCarton"
        Me.colCarton.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colCarton.Visible = True
        Me.colCarton.VisibleIndex = 1
        '
        'colQuantity1
        '
        Me.colQuantity1.FieldName = "Quantity"
        Me.colQuantity1.Name = "colQuantity1"
        Me.colQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colQuantity1.Visible = True
        Me.colQuantity1.VisibleIndex = 2
        '
        'colPOAndColorAndDes1
        '
        Me.colPOAndColorAndDes1.FieldName = "POAndColorAndDes"
        Me.colPOAndColorAndDes1.Name = "colPOAndColorAndDes1"
        Me.colPOAndColorAndDes1.Visible = True
        Me.colPOAndColorAndDes1.VisibleIndex = 0
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(625, 2)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 26
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(544, 2)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 25
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Invoice No :"
        '
        'InvoiceNoGridLookUpEdit
        '
        Me.InvoiceNoGridLookUpEdit.Location = New System.Drawing.Point(348, 4)
        Me.InvoiceNoGridLookUpEdit.Name = "InvoiceNoGridLookUpEdit"
        Me.InvoiceNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InvoiceNoGridLookUpEdit.Properties.DataSource = Me.CommercialInvoiceLookUpBindingSource
        Me.InvoiceNoGridLookUpEdit.Properties.DisplayMember = "CommercialInvoiceNo"
        Me.InvoiceNoGridLookUpEdit.Properties.NullText = ""
        Me.InvoiceNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.InvoiceNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.InvoiceNoGridLookUpEdit.Properties.ValueMember = "CommercialInvoiceMainId"
        Me.InvoiceNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.InvoiceNoGridLookUpEdit.Size = New System.Drawing.Size(190, 20)
        Me.InvoiceNoGridLookUpEdit.TabIndex = 23
        '
        'CommercialInvoiceLookUpBindingSource
        '
        Me.CommercialInvoiceLookUpBindingSource.DataMember = "CommercialInvoiceLookUp"
        Me.CommercialInvoiceLookUpBindingSource.DataSource = Me.CommercialInvoiceLookUpDataSet
        '
        'CommercialInvoiceLookUpDataSet
        '
        Me.CommercialInvoiceLookUpDataSet.DataSetName = "CommercialInvoiceLookUpDataSet"
        Me.CommercialInvoiceLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCommercialInvoiceNo, Me.colCommercialInvoiceDate})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colCommercialInvoiceNo
        '
        Me.colCommercialInvoiceNo.FieldName = "CommercialInvoiceNo"
        Me.colCommercialInvoiceNo.Name = "colCommercialInvoiceNo"
        Me.colCommercialInvoiceNo.Visible = True
        Me.colCommercialInvoiceNo.VisibleIndex = 0
        '
        'colCommercialInvoiceDate
        '
        Me.colCommercialInvoiceDate.FieldName = "CommercialInvoiceDate"
        Me.colCommercialInvoiceDate.Name = "colCommercialInvoiceDate"
        Me.colCommercialInvoiceDate.Visible = True
        Me.colCommercialInvoiceDate.VisibleIndex = 1
        '
        'CommercialInvoiceLookUpTableAdapter
        '
        Me.CommercialInvoiceLookUpTableAdapter.ClearBeforeFill = True
        '
        'GetDataButton
        '
        Me.GetDataButton.Location = New System.Drawing.Point(707, 2)
        Me.GetDataButton.Name = "GetDataButton"
        Me.GetDataButton.Size = New System.Drawing.Size(75, 23)
        Me.GetDataButton.TabIndex = 27
        Me.GetDataButton.Text = "Get Data"
        Me.GetDataButton.UseVisualStyleBackColor = True
        '
        'MasterLCLookupTableAdapter
        '
        Me.MasterLCLookupTableAdapter.ClearBeforeFill = True
        '
        'MasterOrderLookUpTableAdapter
        '
        Me.MasterOrderLookUpTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
        '
        'frmCommercialInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1324, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GetDataButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InvoiceNoGridLookUpEdit)
        Me.Controls.Add(Me.CommercialInvoiceBindingNavigator)
        Me.Name = "frmCommercialInvoice"
        Me.Text = "Commercial Invoice"
        CType(Me.CommercialInvoiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommercialInvoiceBindingNavigator.ResumeLayout(False)
        Me.CommercialInvoiceBindingNavigator.PerformLayout()
        CType(Me.CommercialInvoiceMainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ConsigneeNotifyMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterProgramNoGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MLCNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLCLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MLCNoGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotifyMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipperMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsigneeMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippingMarksFrontMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippingMarksSideMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicantBankMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceBreakDownGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceBreakDownBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialInvoiceLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CommercialInvoiceDataSet As KSoft_Apparel.CommercialInvoiceDataSet
    Friend WithEvents CommercialInvoiceTableAdapter As KSoft_Apparel.CommercialInvoiceDataSetTableAdapters.CommercialInvoiceTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CommercialInvoiceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CommercialInvoiceBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CommercialInvoiceBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OrderPOLookupNewDataSet As KSoft_Apparel.OrderPOLookupNewDataSet
    Friend WithEvents OrderPOLookupAllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderPOLookupAllTableAdapter As KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter
    Friend WithEvents colPOAndColorAndDes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CommercialInvoiceMainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommercialInvoiceMainTableAdapter As KSoft_Apparel.CommercialInvoiceDataSetTableAdapters.CommercialInvoiceMainTableAdapter
    Friend WithEvents NotifyMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents AccountMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ShipperMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ConsigneeMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ExpDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ExpNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShippingMarksSideMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ShippingMarksFrontMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ExportCountDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ExportCountNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ERCDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ERCNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents BillNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CartonMeasurementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalGrossWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalNetWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierRefNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContainerNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecarriageByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommercialInvoiceDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShipmentToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipmentFromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipmentByComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HSCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colPOAndColorAndDes1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CommercialInvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommercialInvoiceGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InvoiceNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCommercialInvoiceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommercialInvoiceDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CommercialInvoiceLookUpDataSet As KSoft_Apparel.CommercialInvoiceLookUpDataSet
    Friend WithEvents CommercialInvoiceLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommercialInvoiceLookUpTableAdapter As KSoft_Apparel.CommercialInvoiceLookUpDataSetTableAdapters.CommercialInvoiceLookUpTableAdapter
    Friend WithEvents GetDataButton As System.Windows.Forms.Button
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MasterLCDataSet As KSoft_Apparel.MasterLCDataSet
    Friend WithEvents MasterLCLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterLCLookupTableAdapter As KSoft_Apparel.MasterLCDataSetTableAdapters.MasterLCLookupTableAdapter
    Friend WithEvents MLCNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents MLCNoGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRefAndMLCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalCartonsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommercialInvoiceNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FCATextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipmentIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionOfGoodsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExportLCDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ExportLCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JOBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContactNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookingNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryOfOriginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortOfDeliveryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortOfDischargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SailingOnTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortOfLoadingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlaceOfReceiptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FreightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VatRegNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalMesurementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalGoodsQTYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colArticleNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAsPerContact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetInvoiceValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CommercialInvoiceBreakDownBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommercialInvoiceBreakDownTableAdapter As KSoft_Apparel.CommercialInvoiceDataSetTableAdapters.CommercialInvoiceBreakDownTableAdapter
    Friend WithEvents CommercialInvoiceBreakDownGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCounrty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarton As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankRealization As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKimball As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOAndStyleAndColorAndDes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ApplicantBankMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MasterProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents MasterProgramNoGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MasterOrderLookUpDataSet As KSoft_Apparel.MasterOrderLookUpDataSet
    Friend WithEvents MasterOrderLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterOrderLookUpTableAdapter As KSoft_Apparel.MasterOrderLookUpDataSetTableAdapters.MasterOrderLookUpTableAdapter
    Friend WithEvents colMasterProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DraftATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BGMEANoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FinalDestinationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TermOfDeliveryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferenceNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EPBRegNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DocumentDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DocumentNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ConsigneeNotifyMemoEdit As DevExpress.XtraEditors.MemoEdit
End Class
