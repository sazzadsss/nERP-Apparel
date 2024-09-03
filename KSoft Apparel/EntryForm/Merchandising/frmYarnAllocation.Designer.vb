<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnAllocation
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
        Me.components = New System.ComponentModel.Container
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim OrderIdLabel As System.Windows.Forms.Label
        Dim FabricReqDateLabel As System.Windows.Forms.Label
        Dim AmendmentNoLabel As System.Windows.Forms.Label
        Dim AmendmentDetailsLabel As System.Windows.Forms.Label
        Dim AmendmentDateLabel As System.Windows.Forms.Label
        Dim FabricBOMIdLabel As System.Windows.Forms.Label
        Dim FabricBookingDateLabel As System.Windows.Forms.Label
        Dim SampleReferenceLabel1 As System.Windows.Forms.Label
        Dim WashReferenceLabel1 As System.Windows.Forms.Label
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet
        Me.FabricBOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBOMDataSet = New KSoft_Apparel.FabricBOMDataSet
        Me.FabricBOMIdSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBOMIdSearchDataSet = New KSoft_Apparel.FabricBOMIdSearchDataSet
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Apparel.UserDataSet
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet
        Me.FabricBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartDataSet = New KSoft_Apparel.GarmentsPartDataSet
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet
        Me.GSMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSMDataSet = New KSoft_Apparel.GSMDataSet
        Me.FabricForSizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet
        Me.FabricViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBOMDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
        Me.GSMTableAdapter = New KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
        Me.GarmentsPartTableAdapter = New KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
        Me.FabricBOMTableAdapter = New KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricBOMTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.FabricBOMDataSetTableAdapters.TableAdapterManager
        Me.FabricBOMDetailsTableAdapter = New KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricBOMDetailsTableAdapter
        Me.FabricTableAdapter = New KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricTableAdapter
        Me.FabricViewTableAdapter = New KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricViewTableAdapter
        Me.FabricBOMIdSearchTableAdapter = New KSoft_Apparel.FabricBOMIdSearchDataSetTableAdapters.FabricBOMIdSearchTableAdapter
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
        Me.UserTableAdapter = New KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
        Me.OrderSizeLookupDataSet = New KSoft_Apparel.OrderSizeLookupDataSet
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFabricBOMId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDetails2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ShowButton = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SaveButton = New System.Windows.Forms.Button
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.FDCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.DyeingCommentsTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.IsFabricBOMCompleteCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UserIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.UserIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colUSER_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPASSWORD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSER_LEVEL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colACTIVE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BuyerLabel = New System.Windows.Forms.Label
        Me.POGroupLabel = New System.Windows.Forms.Label
        Me.FabricBookingDateDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.OrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.FabricReqDateDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.AmendmentNoSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.AmendmentDetailsTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.AmendmentDateDateEdit = New DevExpress.XtraEditors.DateEdit
        Me.AmendmentSimpleButton = New DevExpress.XtraEditors.SimpleButton
        Me.FabricBOMIdLabel1 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.DiscontinueCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.CauseofDiscontinueTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.IsPrintCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.IsAOPCheckEdit = New DevExpress.XtraEditors.CheckEdit
        Me.AOPDetailsTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.WashDetailsTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.SampleDetailsTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.SampleReferenceTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.PrintDetailsTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.WashReferenceTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.AllCheckBox = New System.Windows.Forms.CheckBox
        Me.YarnAllocationGMTGridControl = New DevExpress.XtraGrid.GridControl
        Me.YarnAllocationGMTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYarnPercentage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colWastagePercentage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYarnColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsYds = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLotNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFeederSize = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFeederQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.YarnAllocationGMTTableAdapter = New KSoft_Apparel.FabricBOMDataSetTableAdapters.YarnAllocationGMTTableAdapter
        SupplierIdLabel = New System.Windows.Forms.Label
        UserIdLabel = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        OrderIdLabel = New System.Windows.Forms.Label
        FabricReqDateLabel = New System.Windows.Forms.Label
        AmendmentNoLabel = New System.Windows.Forms.Label
        AmendmentDetailsLabel = New System.Windows.Forms.Label
        AmendmentDateLabel = New System.Windows.Forms.Label
        FabricBOMIdLabel = New System.Windows.Forms.Label
        FabricBookingDateLabel = New System.Windows.Forms.Label
        SampleReferenceLabel1 = New System.Windows.Forms.Label
        WashReferenceLabel1 = New System.Windows.Forms.Label
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMIdSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMIdSearchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricForSizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.FDCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingCommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsFabricBOMCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBookingDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBookingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricReqDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricReqDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DiscontinueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CauseofDiscontinueTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsAOPCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AOPDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.YarnAllocationGMTGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnAllocationGMTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(494, 73)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(51, 13)
        SupplierIdLabel.TabIndex = 41
        SupplierIdLabel.Text = "Supplier :"
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(720, 74)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(74, 13)
        UserIdLabel.TabIndex = 42
        UserIdLabel.Text = "Merchandiser:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(224, 73)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(57, 13)
        Label4.TabIndex = 38
        Label4.Text = "PO Group:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(8, 74)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(37, 13)
        Label1.TabIndex = 36
        Label1.Text = "Buyer:"
        '
        'OrderIdLabel
        '
        OrderIdLabel.AutoSize = True
        OrderIdLabel.Location = New System.Drawing.Point(8, 46)
        OrderIdLabel.Name = "OrderIdLabel"
        OrderIdLabel.Size = New System.Drawing.Size(66, 13)
        OrderIdLabel.TabIndex = 24
        OrderIdLabel.Text = "Program No:"
        '
        'FabricReqDateLabel
        '
        FabricReqDateLabel.AutoSize = True
        FabricReqDateLabel.Location = New System.Drawing.Point(224, 46)
        FabricReqDateLabel.Name = "FabricReqDateLabel"
        FabricReqDateLabel.Size = New System.Drawing.Size(88, 13)
        FabricReqDateLabel.TabIndex = 30
        FabricReqDateLabel.Text = "Fabric Req Date:"
        '
        'AmendmentNoLabel
        '
        AmendmentNoLabel.AutoSize = True
        AmendmentNoLabel.Location = New System.Drawing.Point(491, 16)
        AmendmentNoLabel.Name = "AmendmentNoLabel"
        AmendmentNoLabel.Size = New System.Drawing.Size(54, 13)
        AmendmentNoLabel.TabIndex = 15
        AmendmentNoLabel.Text = "Amnd No:"
        '
        'AmendmentDetailsLabel
        '
        AmendmentDetailsLabel.AutoSize = True
        AmendmentDetailsLabel.Location = New System.Drawing.Point(491, 45)
        AmendmentDetailsLabel.Name = "AmendmentDetailsLabel"
        AmendmentDetailsLabel.Size = New System.Drawing.Size(78, 13)
        AmendmentDetailsLabel.TabIndex = 21
        AmendmentDetailsLabel.Text = "Amend Details:"
        '
        'AmendmentDateLabel
        '
        AmendmentDateLabel.AutoSize = True
        AmendmentDateLabel.Location = New System.Drawing.Point(721, 17)
        AmendmentDateLabel.Name = "AmendmentDateLabel"
        AmendmentDateLabel.Size = New System.Drawing.Size(92, 13)
        AmendmentDateLabel.TabIndex = 20
        AmendmentDateLabel.Text = "Amendment Date:"
        '
        'FabricBOMIdLabel
        '
        FabricBOMIdLabel.AutoSize = True
        FabricBOMIdLabel.Location = New System.Drawing.Point(8, 17)
        FabricBOMIdLabel.Name = "FabricBOMIdLabel"
        FabricBOMIdLabel.Size = New System.Drawing.Size(60, 13)
        FabricBOMIdLabel.TabIndex = 23
        FabricBOMIdLabel.Text = "Booking ID"
        '
        'FabricBookingDateLabel
        '
        FabricBookingDateLabel.AutoSize = True
        FabricBookingDateLabel.Location = New System.Drawing.Point(224, 20)
        FabricBookingDateLabel.Name = "FabricBookingDateLabel"
        FabricBookingDateLabel.Size = New System.Drawing.Size(107, 13)
        FabricBookingDateLabel.TabIndex = 29
        FabricBookingDateLabel.Text = "Fabric Booking Date:"
        '
        'SampleReferenceLabel1
        '
        SampleReferenceLabel1.AutoSize = True
        SampleReferenceLabel1.Location = New System.Drawing.Point(11, 43)
        SampleReferenceLabel1.Name = "SampleReferenceLabel1"
        SampleReferenceLabel1.Size = New System.Drawing.Size(98, 13)
        SampleReferenceLabel1.TabIndex = 26
        SampleReferenceLabel1.Text = "Sample Reference:"
        '
        'WashReferenceLabel1
        '
        WashReferenceLabel1.AutoSize = True
        WashReferenceLabel1.Location = New System.Drawing.Point(12, 18)
        WashReferenceLabel1.Name = "WashReferenceLabel1"
        WashReferenceLabel1.Size = New System.Drawing.Size(91, 13)
        WashReferenceLabel1.TabIndex = 25
        WashReferenceLabel1.Text = "Wash Reference:"
        '
        'OrderFabricColorBindingSource
        '
        Me.OrderFabricColorBindingSource.DataMember = "OrderFabricColor"
        Me.OrderFabricColorBindingSource.DataSource = Me.OrderFabricColorDataSet
        '
        'OrderFabricColorDataSet
        '
        Me.OrderFabricColorDataSet.DataSetName = "OrderFabricColorDataSet"
        Me.OrderFabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricBOMBindingSource
        '
        Me.FabricBOMBindingSource.DataMember = "FabricBOM"
        Me.FabricBOMBindingSource.DataSource = Me.FabricBOMDataSet
        '
        'FabricBOMDataSet
        '
        Me.FabricBOMDataSet.DataSetName = "FabricBOMDataSet"
        Me.FabricBOMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricBOMIdSearchBindingSource
        '
        Me.FabricBOMIdSearchBindingSource.DataMember = "FabricBOMIdSearch"
        Me.FabricBOMIdSearchBindingSource.DataSource = Me.FabricBOMIdSearchDataSet
        '
        'FabricBOMIdSearchDataSet
        '
        Me.FabricBOMIdSearchDataSet.DataSetName = "FabricBOMIdSearchDataSet"
        Me.FabricBOMIdSearchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.UserDataSet
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricBindingSource
        '
        Me.FabricBindingSource.DataMember = "Fabric"
        Me.FabricBindingSource.DataSource = Me.FabricBOMDataSet
        '
        'GarmentsPartBindingSource
        '
        Me.GarmentsPartBindingSource.DataMember = "GarmentsPart"
        Me.GarmentsPartBindingSource.DataSource = Me.GarmentsPartDataSet
        '
        'GarmentsPartDataSet
        '
        Me.GarmentsPartDataSet.DataSetName = "GarmentsPartDataSet"
        Me.GarmentsPartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KnittingTypeBindingSource
        '
        Me.KnittingTypeBindingSource.DataMember = "KnittingType"
        Me.KnittingTypeBindingSource.DataSource = Me.KnittingTypeDataSet
        '
        'KnittingTypeDataSet
        '
        Me.KnittingTypeDataSet.DataSetName = "KnittingTypeDataSet"
        Me.KnittingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GSMBindingSource
        '
        Me.GSMBindingSource.DataMember = "GSM"
        Me.GSMBindingSource.DataSource = Me.GSMDataSet
        '
        'GSMDataSet
        '
        Me.GSMDataSet.DataSetName = "GSMDataSet"
        Me.GSMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricForSizeBindingSource
        '
        Me.FabricForSizeBindingSource.DataMember = "Fabric_FabricForSize"
        Me.FabricForSizeBindingSource.DataSource = Me.FabricBindingSource
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
        'FabricViewBindingSource
        '
        Me.FabricViewBindingSource.DataMember = "FabricView"
        Me.FabricViewBindingSource.DataSource = Me.FabricBOMDataSet
        '
        'FabricBOMDetailsBindingSource
        '
        Me.FabricBOMDetailsBindingSource.DataMember = "FK_FabricBOMDetails_FabricBOM"
        Me.FabricBOMDetailsBindingSource.DataSource = Me.FabricBOMBindingSource
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'GSMTableAdapter
        '
        Me.GSMTableAdapter.ClearBeforeFill = True
        '
        'GarmentsPartTableAdapter
        '
        Me.GarmentsPartTableAdapter.ClearBeforeFill = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'FabricBOMTableAdapter
        '
        Me.FabricBOMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FabricBOMDetailsTableAdapter = Me.FabricBOMDetailsTableAdapter
        Me.TableAdapterManager.FabricBOMTableAdapter = Me.FabricBOMTableAdapter
        Me.TableAdapterManager.FabricForSizeTableAdapter = Nothing
        Me.TableAdapterManager.FabricTableAdapter = Me.FabricTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FabricBOMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YarnAllocationGMTTableAdapter = Nothing
        '
        'FabricBOMDetailsTableAdapter
        '
        Me.FabricBOMDetailsTableAdapter.ClearBeforeFill = True
        '
        'FabricTableAdapter
        '
        Me.FabricTableAdapter.ClearBeforeFill = True
        '
        'FabricViewTableAdapter
        '
        Me.FabricViewTableAdapter.ClearBeforeFill = True
        '
        'FabricBOMIdSearchTableAdapter
        '
        Me.FabricBOMIdSearchTableAdapter.ClearBeforeFill = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'OrderSizeLookupDataSet
        '
        Me.OrderSizeLookupDataSet.DataSetName = "OrderSizeLookupDataSet"
        Me.OrderSizeLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel3.Controls.Add(Me.GridLookUpEdit1)
        Me.FlowLayoutPanel3.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.SimpleButton1)
        Me.FlowLayoutPanel3.Controls.Add(Me.SaveButton)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1138, 32)
        Me.FlowLayoutPanel3.TabIndex = 34
        Me.FlowLayoutPanel3.Tag = "NR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Yarn Allocation"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.EditValue = ""
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(134, 7)
        Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.FabricBOMIdSearchBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "Details2"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type Program No For Search]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "FabricBOMId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(119, 20)
        Me.GridLookUpEdit1.TabIndex = 0
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricBOMId, Me.colOrderId1, Me.colProgramNo1, Me.colAmendmentNo, Me.colDetails, Me.colDetails2})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colFabricBOMId
        '
        Me.colFabricBOMId.FieldName = "FabricBOMId"
        Me.colFabricBOMId.Name = "colFabricBOMId"
        Me.colFabricBOMId.OptionsColumn.ReadOnly = True
        '
        'colOrderId1
        '
        Me.colOrderId1.FieldName = "OrderId"
        Me.colOrderId1.Name = "colOrderId1"
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        '
        'colAmendmentNo
        '
        Me.colAmendmentNo.FieldName = "AmendmentNo"
        Me.colAmendmentNo.Name = "colAmendmentNo"
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.OptionsColumn.ReadOnly = True
        '
        'colDetails2
        '
        Me.colDetails2.Caption = "Fabric Booking No"
        Me.colDetails2.FieldName = "Details2"
        Me.colDetails2.Name = "colDetails2"
        Me.colDetails2.OptionsColumn.ReadOnly = True
        Me.colDetails2.Visible = True
        Me.colDetails2.VisibleIndex = 0
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(259, 7)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(60, 20)
        Me.ShowButton.TabIndex = 49
        Me.ShowButton.Text = "Show"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(325, 7)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(60, 20)
        Me.SimpleButton1.TabIndex = 32
        Me.SimpleButton1.Text = "Refresh"
        '
        'SaveButton
        '
        Me.SaveButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Add_icon
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(418, 4)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(30, 4, 3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.SaveButton.Size = New System.Drawing.Size(98, 26)
        Me.SaveButton.TabIndex = 45
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1138, 469)
        Me.SplitContainer2.SplitterDistance = 169
        Me.SplitContainer2.TabIndex = 35
        '
        'TabControl2
        '
        Me.TabControl2.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(12, 15)
        Me.TabControl2.Multiline = True
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1114, 142)
        Me.TabControl2.TabIndex = 52
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.FDCheckEdit)
        Me.TabPage3.Controls.Add(Me.DyeingCommentsTextEdit)
        Me.TabPage3.Controls.Add(Me.IsFabricBOMCompleteCheckEdit)
        Me.TabPage3.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.TabPage3.Controls.Add(SupplierIdLabel)
        Me.TabPage3.Controls.Add(UserIdLabel)
        Me.TabPage3.Controls.Add(Me.UserIdGridLookUpEdit)
        Me.TabPage3.Controls.Add(Me.BuyerLabel)
        Me.TabPage3.Controls.Add(Me.POGroupLabel)
        Me.TabPage3.Controls.Add(Label4)
        Me.TabPage3.Controls.Add(Label1)
        Me.TabPage3.Controls.Add(Me.FabricBookingDateDateEdit)
        Me.TabPage3.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.TabPage3.Controls.Add(OrderIdLabel)
        Me.TabPage3.Controls.Add(Me.FabricReqDateDateEdit)
        Me.TabPage3.Controls.Add(FabricReqDateLabel)
        Me.TabPage3.Controls.Add(Me.AmendmentNoSpinEdit)
        Me.TabPage3.Controls.Add(AmendmentNoLabel)
        Me.TabPage3.Controls.Add(Me.AmendmentDetailsTextEdit)
        Me.TabPage3.Controls.Add(AmendmentDetailsLabel)
        Me.TabPage3.Controls.Add(Me.AmendmentDateDateEdit)
        Me.TabPage3.Controls.Add(AmendmentDateLabel)
        Me.TabPage3.Controls.Add(Me.AmendmentSimpleButton)
        Me.TabPage3.Controls.Add(Me.FabricBOMIdLabel1)
        Me.TabPage3.Controls.Add(FabricBOMIdLabel)
        Me.TabPage3.Controls.Add(FabricBookingDateLabel)
        Me.TabPage3.Location = New System.Drawing.Point(23, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1087, 134)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Basic"
        '
        'FDCheckEdit
        '
        Me.FDCheckEdit.Location = New System.Drawing.Point(225, 99)
        Me.FDCheckEdit.Name = "FDCheckEdit"
        Me.FDCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.FDCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FDCheckEdit.Properties.Caption = "FD Status"
        Me.FDCheckEdit.Properties.ReadOnly = True
        Me.FDCheckEdit.Size = New System.Drawing.Size(104, 19)
        Me.FDCheckEdit.TabIndex = 58
        '
        'DyeingCommentsTextEdit
        '
        Me.DyeingCommentsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "DyeingComments", True))
        Me.DyeingCommentsTextEdit.Location = New System.Drawing.Point(334, 99)
        Me.DyeingCommentsTextEdit.Name = "DyeingCommentsTextEdit"
        Me.DyeingCommentsTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.DyeingCommentsTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DyeingCommentsTextEdit.Properties.ReadOnly = True
        Me.DyeingCommentsTextEdit.Size = New System.Drawing.Size(679, 20)
        Me.DyeingCommentsTextEdit.TabIndex = 57
        '
        'IsFabricBOMCompleteCheckEdit
        '
        Me.IsFabricBOMCompleteCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "IsFabricBOMComplete", True))
        Me.IsFabricBOMCompleteCheckEdit.Location = New System.Drawing.Point(9, 99)
        Me.IsFabricBOMCompleteCheckEdit.Name = "IsFabricBOMCompleteCheckEdit"
        Me.IsFabricBOMCompleteCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Lime
        Me.IsFabricBOMCompleteCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.IsFabricBOMCompleteCheckEdit.Properties.Caption = "Proceed For Fabric Department"
        Me.IsFabricBOMCompleteCheckEdit.Properties.ReadOnly = True
        Me.IsFabricBOMCompleteCheckEdit.Size = New System.Drawing.Size(204, 19)
        Me.IsFabricBOMCompleteCheckEdit.TabIndex = 56
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(575, 70)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.NullText = "[Supplier]"
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Properties.View = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(118, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 40
        '
        'SupplierIdGridLookUpEditView
        '
        Me.SupplierIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierCode, Me.colSupplierId, Me.colSupplierName, Me.colAdd1, Me.colAdd2, Me.colContactPerson, Me.colContactNo, Me.colSupplierType})
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
        'colSupplierId
        '
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.OptionsColumn.ReadOnly = True
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
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
        'colContactPerson
        '
        Me.colContactPerson.FieldName = "ContactPerson"
        Me.colContactPerson.Name = "colContactPerson"
        '
        'colContactNo
        '
        Me.colContactNo.FieldName = "ContactNo"
        Me.colContactNo.Name = "colContactNo"
        '
        'colSupplierType
        '
        Me.colSupplierType.FieldName = "SupplierType"
        Me.colSupplierType.Name = "colSupplierType"
        '
        'UserIdGridLookUpEdit
        '
        Me.UserIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "UserId", True))
        Me.UserIdGridLookUpEdit.Location = New System.Drawing.Point(818, 70)
        Me.UserIdGridLookUpEdit.Name = "UserIdGridLookUpEdit"
        Me.UserIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserIdGridLookUpEdit.Properties.DataSource = Me.UserBindingSource
        Me.UserIdGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.UserIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.UserIdGridLookUpEdit.Properties.NullText = ""
        Me.UserIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UserIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserIdGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.UserIdGridLookUpEdit.Properties.View = Me.UserIdGridLookUpEditView
        Me.UserIdGridLookUpEdit.Size = New System.Drawing.Size(195, 20)
        Me.UserIdGridLookUpEdit.TabIndex = 43
        '
        'UserIdGridLookUpEditView
        '
        Me.UserIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_ID, Me.colUSER_NAME, Me.colPASSWORD, Me.colUSER_LEVEL, Me.colACTIVE, Me.colDepartmentId})
        Me.UserIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.UserIdGridLookUpEditView.Name = "UserIdGridLookUpEditView"
        Me.UserIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.UserIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colUSER_ID
        '
        Me.colUSER_ID.FieldName = "USER_ID"
        Me.colUSER_ID.Name = "colUSER_ID"
        Me.colUSER_ID.OptionsColumn.ReadOnly = True
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'colPASSWORD
        '
        Me.colPASSWORD.FieldName = "PASSWORD"
        Me.colPASSWORD.Name = "colPASSWORD"
        '
        'colUSER_LEVEL
        '
        Me.colUSER_LEVEL.FieldName = "USER_LEVEL"
        Me.colUSER_LEVEL.Name = "colUSER_LEVEL"
        '
        'colACTIVE
        '
        Me.colACTIVE.FieldName = "ACTIVE"
        Me.colACTIVE.Name = "colACTIVE"
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'BuyerLabel
        '
        Me.BuyerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BuyerLabel.Location = New System.Drawing.Point(106, 70)
        Me.BuyerLabel.Name = "BuyerLabel"
        Me.BuyerLabel.Size = New System.Drawing.Size(107, 21)
        Me.BuyerLabel.TabIndex = 37
        '
        'POGroupLabel
        '
        Me.POGroupLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.POGroupLabel.Location = New System.Drawing.Point(334, 70)
        Me.POGroupLabel.Name = "POGroupLabel"
        Me.POGroupLabel.Size = New System.Drawing.Size(156, 21)
        Me.POGroupLabel.TabIndex = 39
        '
        'FabricBookingDateDateEdit
        '
        Me.FabricBookingDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "FabricBookingDate", True))
        Me.FabricBookingDateDateEdit.EditValue = Nothing
        Me.FabricBookingDateDateEdit.Location = New System.Drawing.Point(334, 13)
        Me.FabricBookingDateDateEdit.Name = "FabricBookingDateDateEdit"
        Me.FabricBookingDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricBookingDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.FabricBookingDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.FabricBookingDateDateEdit.Properties.EditFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.FabricBookingDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.FabricBookingDateDateEdit.Properties.ReadOnly = True
        Me.FabricBookingDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FabricBookingDateDateEdit.Size = New System.Drawing.Size(156, 20)
        Me.FabricBookingDateDateEdit.TabIndex = 3
        '
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "OrderId", True))
        Me.OrderIdGridLookUpEdit.Enabled = False
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(106, 42)
        Me.OrderIdGridLookUpEdit.Name = "OrderIdGridLookUpEdit"
        Me.OrderIdGridLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OrderIdGridLookUpEdit.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.OrderIdGridLookUpEdit.Properties.Appearance.Options.UseBackColor = True
        Me.OrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderIdGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderIdGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.OrderIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderIdGridLookUpEdit.Properties.NullText = "[Program No]"
        Me.OrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderIdGridLookUpEdit.Properties.View = Me.OrderIdGridLookUpEditView
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(107, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 2
        Me.OrderIdGridLookUpEdit.Tag = "NR"
        '
        'OrderIdGridLookUpEditView
        '
        Me.OrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colProgramNo, Me.colIsPrint, Me.colUserId})
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
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        '
        'colUserId
        '
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        '
        'FabricReqDateDateEdit
        '
        Me.FabricReqDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "FabricReqDate", True))
        Me.FabricReqDateDateEdit.EditValue = Nothing
        Me.FabricReqDateDateEdit.Location = New System.Drawing.Point(334, 42)
        Me.FabricReqDateDateEdit.Name = "FabricReqDateDateEdit"
        Me.FabricReqDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricReqDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.FabricReqDateDateEdit.Size = New System.Drawing.Size(156, 20)
        Me.FabricReqDateDateEdit.TabIndex = 4
        '
        'AmendmentNoSpinEdit
        '
        Me.AmendmentNoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "AmendmentNo", True))
        Me.AmendmentNoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AmendmentNoSpinEdit.Location = New System.Drawing.Point(575, 13)
        Me.AmendmentNoSpinEdit.Name = "AmendmentNoSpinEdit"
        Me.AmendmentNoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.AmendmentNoSpinEdit.Properties.ReadOnly = True
        Me.AmendmentNoSpinEdit.Size = New System.Drawing.Size(56, 20)
        Me.AmendmentNoSpinEdit.TabIndex = 16
        '
        'AmendmentDetailsTextEdit
        '
        Me.AmendmentDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "AmendmentDetails", True))
        Me.AmendmentDetailsTextEdit.Location = New System.Drawing.Point(575, 42)
        Me.AmendmentDetailsTextEdit.Name = "AmendmentDetailsTextEdit"
        Me.AmendmentDetailsTextEdit.Size = New System.Drawing.Size(438, 20)
        Me.AmendmentDetailsTextEdit.TabIndex = 18
        '
        'AmendmentDateDateEdit
        '
        Me.AmendmentDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "AmendmentDate", True))
        Me.AmendmentDateDateEdit.EditValue = Nothing
        Me.AmendmentDateDateEdit.Location = New System.Drawing.Point(819, 13)
        Me.AmendmentDateDateEdit.Name = "AmendmentDateDateEdit"
        Me.AmendmentDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmendmentDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.AmendmentDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.AmendmentDateDateEdit.Properties.EditFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.AmendmentDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.AmendmentDateDateEdit.Properties.ReadOnly = True
        Me.AmendmentDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.AmendmentDateDateEdit.Size = New System.Drawing.Size(194, 20)
        Me.AmendmentDateDateEdit.TabIndex = 17
        '
        'AmendmentSimpleButton
        '
        Me.AmendmentSimpleButton.Enabled = False
        Me.AmendmentSimpleButton.Location = New System.Drawing.Point(635, 13)
        Me.AmendmentSimpleButton.Name = "AmendmentSimpleButton"
        Me.AmendmentSimpleButton.Size = New System.Drawing.Size(80, 20)
        Me.AmendmentSimpleButton.TabIndex = 19
        Me.AmendmentSimpleButton.Text = "Amendment"
        '
        'FabricBOMIdLabel1
        '
        Me.FabricBOMIdLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FabricBOMIdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FabricBOMBindingSource, "FabricBOMId", True))
        Me.FabricBOMIdLabel1.Location = New System.Drawing.Point(106, 13)
        Me.FabricBOMIdLabel1.Name = "FabricBOMIdLabel1"
        Me.FabricBOMIdLabel1.Size = New System.Drawing.Size(107, 21)
        Me.FabricBOMIdLabel1.TabIndex = 28
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.DiscontinueCheckEdit)
        Me.TabPage4.Controls.Add(Me.CauseofDiscontinueTextEdit)
        Me.TabPage4.Controls.Add(Me.IsPrintCheckEdit)
        Me.TabPage4.Controls.Add(Me.IsAOPCheckEdit)
        Me.TabPage4.Controls.Add(Me.AOPDetailsTextEdit)
        Me.TabPage4.Controls.Add(Me.WashDetailsTextEdit)
        Me.TabPage4.Controls.Add(Me.SampleDetailsTextEdit)
        Me.TabPage4.Controls.Add(Me.SampleReferenceTextEdit)
        Me.TabPage4.Controls.Add(Me.PrintDetailsTextEdit)
        Me.TabPage4.Controls.Add(SampleReferenceLabel1)
        Me.TabPage4.Controls.Add(WashReferenceLabel1)
        Me.TabPage4.Controls.Add(Me.WashReferenceTextEdit)
        Me.TabPage4.Location = New System.Drawing.Point(23, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1087, 134)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "More"
        '
        'DiscontinueCheckEdit
        '
        Me.DiscontinueCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "Discontinue", True))
        Me.DiscontinueCheckEdit.Location = New System.Drawing.Point(445, 67)
        Me.DiscontinueCheckEdit.Name = "DiscontinueCheckEdit"
        Me.DiscontinueCheckEdit.Properties.Caption = "Discontinue"
        Me.DiscontinueCheckEdit.Size = New System.Drawing.Size(104, 19)
        Me.DiscontinueCheckEdit.TabIndex = 13
        '
        'CauseofDiscontinueTextEdit
        '
        Me.CauseofDiscontinueTextEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CauseofDiscontinueTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "CauseofDiscontinue", True))
        Me.CauseofDiscontinueTextEdit.Location = New System.Drawing.Point(558, 66)
        Me.CauseofDiscontinueTextEdit.Name = "CauseofDiscontinueTextEdit"
        Me.CauseofDiscontinueTextEdit.Size = New System.Drawing.Size(510, 20)
        Me.CauseofDiscontinueTextEdit.TabIndex = 14
        '
        'IsPrintCheckEdit
        '
        Me.IsPrintCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "IsPrint", True))
        Me.IsPrintCheckEdit.Location = New System.Drawing.Point(445, 15)
        Me.IsPrintCheckEdit.Name = "IsPrintCheckEdit"
        Me.IsPrintCheckEdit.Properties.Caption = "Print"
        Me.IsPrintCheckEdit.Size = New System.Drawing.Size(104, 19)
        Me.IsPrintCheckEdit.TabIndex = 9
        '
        'IsAOPCheckEdit
        '
        Me.IsAOPCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "IsAOP", True))
        Me.IsAOPCheckEdit.Location = New System.Drawing.Point(445, 40)
        Me.IsAOPCheckEdit.Name = "IsAOPCheckEdit"
        Me.IsAOPCheckEdit.Properties.Caption = "AOP"
        Me.IsAOPCheckEdit.Size = New System.Drawing.Size(104, 19)
        Me.IsAOPCheckEdit.TabIndex = 11
        '
        'AOPDetailsTextEdit
        '
        Me.AOPDetailsTextEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AOPDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "AOPDetails", True))
        Me.AOPDetailsTextEdit.Location = New System.Drawing.Point(558, 40)
        Me.AOPDetailsTextEdit.Name = "AOPDetailsTextEdit"
        Me.AOPDetailsTextEdit.Size = New System.Drawing.Size(510, 20)
        Me.AOPDetailsTextEdit.TabIndex = 12
        '
        'WashDetailsTextEdit
        '
        Me.WashDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "WashDetails", True))
        Me.WashDetailsTextEdit.Location = New System.Drawing.Point(230, 15)
        Me.WashDetailsTextEdit.Name = "WashDetailsTextEdit"
        Me.WashDetailsTextEdit.Size = New System.Drawing.Size(207, 20)
        Me.WashDetailsTextEdit.TabIndex = 6
        '
        'SampleDetailsTextEdit
        '
        Me.SampleDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "SampleDetails", True))
        Me.SampleDetailsTextEdit.Location = New System.Drawing.Point(230, 40)
        Me.SampleDetailsTextEdit.Name = "SampleDetailsTextEdit"
        Me.SampleDetailsTextEdit.Size = New System.Drawing.Size(207, 20)
        Me.SampleDetailsTextEdit.TabIndex = 8
        '
        'SampleReferenceTextEdit
        '
        Me.SampleReferenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "SampleReference", True))
        Me.SampleReferenceTextEdit.Location = New System.Drawing.Point(109, 40)
        Me.SampleReferenceTextEdit.Name = "SampleReferenceTextEdit"
        Me.SampleReferenceTextEdit.Size = New System.Drawing.Size(107, 20)
        Me.SampleReferenceTextEdit.TabIndex = 7
        '
        'PrintDetailsTextEdit
        '
        Me.PrintDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "PrintDetails", True))
        Me.PrintDetailsTextEdit.Location = New System.Drawing.Point(558, 14)
        Me.PrintDetailsTextEdit.Name = "PrintDetailsTextEdit"
        Me.PrintDetailsTextEdit.Size = New System.Drawing.Size(446, 20)
        Me.PrintDetailsTextEdit.TabIndex = 10
        '
        'WashReferenceTextEdit
        '
        Me.WashReferenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "WashReference", True))
        Me.WashReferenceTextEdit.Location = New System.Drawing.Point(109, 15)
        Me.WashReferenceTextEdit.Name = "WashReferenceTextEdit"
        Me.WashReferenceTextEdit.Size = New System.Drawing.Size(107, 20)
        Me.WashReferenceTextEdit.TabIndex = 5
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.AllCheckBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.YarnAllocationGMTGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1138, 296)
        Me.SplitContainer1.SplitterDistance = 149
        Me.SplitContainer1.TabIndex = 0
        '
        'AllCheckBox
        '
        Me.AllCheckBox.AutoSize = True
        Me.AllCheckBox.Location = New System.Drawing.Point(12, 5)
        Me.AllCheckBox.Name = "AllCheckBox"
        Me.AllCheckBox.Size = New System.Drawing.Size(70, 17)
        Me.AllCheckBox.TabIndex = 61
        Me.AllCheckBox.Text = "Select All"
        Me.AllCheckBox.UseVisualStyleBackColor = True
        '
        'YarnAllocationGMTGridControl
        '
        Me.YarnAllocationGMTGridControl.DataSource = Me.YarnAllocationGMTBindingSource
        Me.YarnAllocationGMTGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.YarnAllocationGMTGridControl.Location = New System.Drawing.Point(0, 0)
        Me.YarnAllocationGMTGridControl.MainView = Me.GridView1
        Me.YarnAllocationGMTGridControl.Name = "YarnAllocationGMTGridControl"
        Me.YarnAllocationGMTGridControl.Size = New System.Drawing.Size(1138, 143)
        Me.YarnAllocationGMTGridControl.TabIndex = 0
        Me.YarnAllocationGMTGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'YarnAllocationGMTBindingSource
        '
        Me.YarnAllocationGMTBindingSource.DataMember = "FabricBOMDetails_YarnAllocationGMT"
        Me.YarnAllocationGMTBindingSource.DataSource = Me.FabricBOMDetailsBindingSource
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colRemarks, Me.colYarnPercentage, Me.colWastagePercentage, Me.colQuantity, Me.colYarnColor, Me.colIsYds, Me.colLotNo, Me.colFeederSize, Me.colFeederQty})
        Me.GridView1.GridControl = Me.YarnAllocationGMTGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colItemId
        '
        Me.colItemId.Caption = "Yarn Name"
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 228
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 9
        Me.colRemarks.Width = 133
        '
        'colYarnPercentage
        '
        Me.colYarnPercentage.Caption = "Y%"
        Me.colYarnPercentage.FieldName = "YarnPercentage"
        Me.colYarnPercentage.Name = "colYarnPercentage"
        Me.colYarnPercentage.Visible = True
        Me.colYarnPercentage.VisibleIndex = 1
        Me.colYarnPercentage.Width = 52
        '
        'colWastagePercentage
        '
        Me.colWastagePercentage.Caption = "W%"
        Me.colWastagePercentage.FieldName = "WastagePercentage"
        Me.colWastagePercentage.Name = "colWastagePercentage"
        Me.colWastagePercentage.Visible = True
        Me.colWastagePercentage.VisibleIndex = 2
        Me.colWastagePercentage.Width = 50
        '
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 3
        Me.colQuantity.Width = 109
        '
        'colYarnColor
        '
        Me.colYarnColor.FieldName = "YarnColor"
        Me.colYarnColor.Name = "colYarnColor"
        Me.colYarnColor.Visible = True
        Me.colYarnColor.VisibleIndex = 5
        Me.colYarnColor.Width = 109
        '
        'colIsYds
        '
        Me.colIsYds.AppearanceCell.Options.UseTextOptions = True
        Me.colIsYds.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsYds.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colIsYds.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsYds.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsYds.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colIsYds.Caption = "YDS"
        Me.colIsYds.FieldName = "IsYds"
        Me.colIsYds.Name = "colIsYds"
        Me.colIsYds.Visible = True
        Me.colIsYds.VisibleIndex = 4
        Me.colIsYds.Width = 109
        '
        'colLotNo
        '
        Me.colLotNo.FieldName = "LotNo"
        Me.colLotNo.Name = "colLotNo"
        Me.colLotNo.Visible = True
        Me.colLotNo.VisibleIndex = 6
        Me.colLotNo.Width = 109
        '
        'colFeederSize
        '
        Me.colFeederSize.FieldName = "FeederSize"
        Me.colFeederSize.Name = "colFeederSize"
        Me.colFeederSize.Visible = True
        Me.colFeederSize.VisibleIndex = 7
        Me.colFeederSize.Width = 109
        '
        'colFeederQty
        '
        Me.colFeederQty.FieldName = "FeederQty"
        Me.colFeederQty.Name = "colFeederQty"
        Me.colFeederQty.Visible = True
        Me.colFeederQty.VisibleIndex = 8
        Me.colFeederQty.Width = 109
        '
        'YarnAllocationGMTTableAdapter
        '
        Me.YarnAllocationGMTTableAdapter.ClearBeforeFill = True
        '
        'frmYarnAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 501)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Name = "frmYarnAllocation"
        Me.Text = "frmYarnAllocation"
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMIdSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMIdSearchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricForSizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.FDCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingCommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsFabricBOMCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBookingDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBookingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricReqDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricReqDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DiscontinueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CauseofDiscontinueTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsAOPCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AOPDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.YarnAllocationGMTGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnAllocationGMTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents FabricBOMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBOMDataSet As KSoft_Apparel.FabricBOMDataSet
    Friend WithEvents FabricBOMIdSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBOMIdSearchDataSet As KSoft_Apparel.FabricBOMIdSearchDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserDataSet As KSoft_Apparel.UserDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents FabricBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartDataSet As KSoft_Apparel.GarmentsPartDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents GSMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GSMDataSet As KSoft_Apparel.GSMDataSet
    Friend WithEvents FabricForSizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBOMDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents GSMTableAdapter As KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
    Friend WithEvents GarmentsPartTableAdapter As KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents FabricBOMTableAdapter As KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricBOMTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FabricBOMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FabricBOMDetailsTableAdapter As KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricBOMDetailsTableAdapter
    Friend WithEvents FabricTableAdapter As KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricTableAdapter
    Friend WithEvents FabricViewTableAdapter As KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricViewTableAdapter
    Friend WithEvents FabricBOMIdSearchTableAdapter As KSoft_Apparel.FabricBOMIdSearchDataSetTableAdapters.FabricBOMIdSearchTableAdapter
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents UserTableAdapter As KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents OrderSizeLookupDataSet As KSoft_Apparel.OrderSizeLookupDataSet
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricBOMId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents FDCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DyeingCommentsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsFabricBOMCompleteCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SupplierIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SupplierIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents UserIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUSER_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPASSWORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_LEVEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACTIVE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerLabel As System.Windows.Forms.Label
    Friend WithEvents POGroupLabel As System.Windows.Forms.Label
    Friend WithEvents FabricBookingDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents OrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricReqDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AmendmentNoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AmendmentDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AmendmentDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AmendmentSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FabricBOMIdLabel1 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DiscontinueCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CauseofDiscontinueTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsPrintCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsAOPCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AOPDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WashDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SampleDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SampleReferenceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PrintDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WashReferenceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents YarnAllocationGMTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YarnAllocationGMTTableAdapter As KSoft_Apparel.FabricBOMDataSetTableAdapters.YarnAllocationGMTTableAdapter
    Friend WithEvents YarnAllocationGMTGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWastagePercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsYds As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFeederSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFeederQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AllCheckBox As System.Windows.Forms.CheckBox
End Class
