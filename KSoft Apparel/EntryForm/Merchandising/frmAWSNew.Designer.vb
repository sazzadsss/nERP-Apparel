<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAWSNew
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
        Dim AWSNoLabel As System.Windows.Forms.Label
        Dim AWSDateLabel As System.Windows.Forms.Label
        Dim RequireDateLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim IsApprovedLabel As System.Windows.Forms.Label
        Dim ApprovedByLabel As System.Windows.Forms.Label
        Dim ApprovedOnLabel As System.Windows.Forms.Label
        Dim AWSIdLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim AmendmentNoLabel As System.Windows.Forms.Label
        Dim AmendmentDateLabel As System.Windows.Forms.Label
        Dim GMQtyLabel As System.Windows.Forms.Label
        Dim ReferenceLabel As System.Windows.Forms.Label
        Dim AttentionLabel As System.Windows.Forms.Label
        Dim TermsConditionLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colUnitPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsumption = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CmdEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdAWSNoShow = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddNew = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdAccBOMNoShow = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.BookingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GMQtyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AccessoresBookingDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.AccessoresBookingDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesBookingNewDataSet = New KSoft_Apparel.AccessoriesBookingNewDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesBookingId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.RepositoryItemGridLookUpEdit4View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsumptionUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet()
        Me.RepositoryItemGridLookUpEdit7View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBookingUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit8View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBookingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Apparel.ItemListLookupDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemStyle1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.AccessoriesListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesListDataSet = New KSoft_Apparel.AccessoriesListDataSet()
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccessoriesId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemStyle2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsumptionForPcs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWastagePercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSLNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSizeId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataSet = New KSoft_Apparel.SizeDataSet()
        Me.RepositoryItemGridLookUpEdit5View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSlNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinationId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DestinationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DestinationDataSet = New KSoft_Apparel.DestinationDataSet()
        Me.RepositoryItemGridLookUpEdit6View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestinationId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinationCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinationName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPackType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colAdditionalQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabrication = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKimballNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSKU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColorCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdInvert = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdGetSelectedData = New DevExpress.XtraEditors.SimpleButton()
        Me.AllCheckBox = New System.Windows.Forms.CheckBox()
        Me.AccBOMNoLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.AccBookingLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccBOMLookUpDataSet = New KSoft_Apparel.AccBOMLookUpDataSet()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccessoriesWorkOrderSheetDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.AccessoriesWorkOrderSheetDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesWorkOrderSheetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AWS_DataSet = New KSoft_Apparel.AWS_DataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccessoriesBookingDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemNameGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.AccBOMItemLookupNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccBOMItemLookupNewDataSet = New KSoft_Apparel.AccBOMItemLookupNewDataSet()
        Me.RepositoryItemGridLookUpEdit12View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit10View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCurrencyId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesBookingDetailsId21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemStyleGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAdditionalCharge = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdditionalChargeFor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit9View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccessoriesName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesBookingDetailsId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit11View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccessoriesName3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesBookingDetailsId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CmdShowHide = New DevExpress.XtraEditors.SimpleButton()
        Me.AccOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TermsConditionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.AttentionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ReferenceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompleteCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AmendmentDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AmendmentNoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AccAmendmentHistoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.AccAmendmentHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccAmendmentHistoryId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAWSId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CauseOfCancelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsCancelCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AWSNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AWSDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ApprovedOnDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RequireDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ApprovedByTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIDGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierIDGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsApprovedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AccessoriesWorkOrderSheetDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesWorkOrderSheetTableAdapter = New KSoft_Apparel.AWS_DataSetTableAdapters.AccessoriesWorkOrderSheetTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.AWS_DataSetTableAdapters.TableAdapterManager()
        Me.AccAmendmentHistoryTableAdapter = New KSoft_Apparel.AWS_DataSetTableAdapters.AccAmendmentHistoryTableAdapter()
        Me.AccessoriesWorkOrderSheetDetailsTableAdapter = New KSoft_Apparel.AWS_DataSetTableAdapters.AccessoriesWorkOrderSheetDetailsTableAdapter()
        Me.AccessoresBookingDetailsTableAdapter = New KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoresBookingDetailsTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.TableAdapterManager()
        Me.colAccessoriesId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.AccessoriesListLookupTableAdapter = New KSoft_Apparel.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter()
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter()
        Me.SizeLookupTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeLookupTableAdapter()
        Me.DestinationTableAdapter = New KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter()
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.AccBookingLookupTableAdapter = New KSoft_Apparel.AccBOMLookUpDataSetTableAdapters.AccBookingLookupTableAdapter()
        Me.AWSNoLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.AWSLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AWSLookupDataSet = New KSoft_Apparel.AWSLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAWSNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAWSDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CmdAccBOMRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.AWSIdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.CmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.AWSLookupTableAdapter = New KSoft_Apparel.AWSLookupDataSetTableAdapters.AWSLookupTableAdapter()
        Me.AccOrderLookupTableAdapter = New KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccOrderLookupTableAdapter()
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.AccBOMItemLookupNewTableAdapter = New KSoft_Apparel.AccBOMItemLookupNewDataSetTableAdapters.AccBOMItemLookupNewTableAdapter()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        AWSNoLabel = New System.Windows.Forms.Label()
        AWSDateLabel = New System.Windows.Forms.Label()
        RequireDateLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        IsApprovedLabel = New System.Windows.Forms.Label()
        ApprovedByLabel = New System.Windows.Forms.Label()
        ApprovedOnLabel = New System.Windows.Forms.Label()
        AWSIdLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        AmendmentNoLabel = New System.Windows.Forms.Label()
        AmendmentDateLabel = New System.Windows.Forms.Label()
        GMQtyLabel = New System.Windows.Forms.Label()
        ReferenceLabel = New System.Windows.Forms.Label()
        AttentionLabel = New System.Windows.Forms.Label()
        TermsConditionLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GMQtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoresBookingDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoresBookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesBookingNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit7View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit8View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit5View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit6View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesWorkOrderSheetDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesWorkOrderSheetDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesWorkOrderSheetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMItemLookupNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMItemLookupNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit12View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit10View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit9View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit11View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TermsConditionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAmendmentHistoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAmendmentHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CauseOfCancelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsCancelCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedOnDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedOnDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequireDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequireDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIDGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIDGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsApprovedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesWorkOrderSheetDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AWSIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AWSNoLabel
        '
        AWSNoLabel.AutoSize = True
        AWSNoLabel.Location = New System.Drawing.Point(6, 27)
        AWSNoLabel.Name = "AWSNoLabel"
        AWSNoLabel.Size = New System.Drawing.Size(47, 13)
        AWSNoLabel.TabIndex = 2
        AWSNoLabel.Text = "AWSNo:"
        '
        'AWSDateLabel
        '
        AWSDateLabel.AutoSize = True
        AWSDateLabel.Location = New System.Drawing.Point(6, 54)
        AWSDateLabel.Name = "AWSDateLabel"
        AWSDateLabel.Size = New System.Drawing.Size(57, 13)
        AWSDateLabel.TabIndex = 4
        AWSDateLabel.Text = "AWSDate:"
        '
        'RequireDateLabel
        '
        RequireDateLabel.AutoSize = True
        RequireDateLabel.Location = New System.Drawing.Point(6, 80)
        RequireDateLabel.Name = "RequireDateLabel"
        RequireDateLabel.Size = New System.Drawing.Size(74, 13)
        RequireDateLabel.TabIndex = 6
        RequireDateLabel.Text = "Require Date:"
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(7, 102)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(49, 13)
        SupplierIDLabel.TabIndex = 8
        SupplierIDLabel.Text = "Supplier:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(429, 102)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 14
        RemarksLabel.Text = "Remarks:"
        '
        'IsApprovedLabel
        '
        IsApprovedLabel.AutoSize = True
        IsApprovedLabel.Location = New System.Drawing.Point(429, 28)
        IsApprovedLabel.Name = "IsApprovedLabel"
        IsApprovedLabel.Size = New System.Drawing.Size(70, 13)
        IsApprovedLabel.TabIndex = 16
        IsApprovedLabel.Text = "Is Approved:"
        '
        'ApprovedByLabel
        '
        ApprovedByLabel.AutoSize = True
        ApprovedByLabel.Location = New System.Drawing.Point(667, 27)
        ApprovedByLabel.Name = "ApprovedByLabel"
        ApprovedByLabel.Size = New System.Drawing.Size(73, 13)
        ApprovedByLabel.TabIndex = 18
        ApprovedByLabel.Text = "Approved By:"
        '
        'ApprovedOnLabel
        '
        ApprovedOnLabel.AutoSize = True
        ApprovedOnLabel.Location = New System.Drawing.Point(519, 28)
        ApprovedOnLabel.Name = "ApprovedOnLabel"
        ApprovedOnLabel.Size = New System.Drawing.Size(75, 13)
        ApprovedOnLabel.TabIndex = 20
        ApprovedOnLabel.Text = "Approved On:"
        '
        'AWSIdLabel
        '
        AWSIdLabel.AutoSize = True
        AWSIdLabel.Location = New System.Drawing.Point(1094, 67)
        AWSIdLabel.Name = "AWSIdLabel"
        AWSIdLabel.Size = New System.Drawing.Size(44, 13)
        AWSIdLabel.TabIndex = 25
        AWSIdLabel.Text = "AWSId:"
        AWSIdLabel.Visible = False
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(863, 13)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(105, 13)
        Label3.TabIndex = 26
        Label3.Text = "Amendment History:"
        '
        'AmendmentNoLabel
        '
        AmendmentNoLabel.AutoSize = True
        AmendmentNoLabel.Location = New System.Drawing.Point(219, 27)
        AmendmentNoLabel.Name = "AmendmentNoLabel"
        AmendmentNoLabel.Size = New System.Drawing.Size(84, 13)
        AmendmentNoLabel.TabIndex = 26
        AmendmentNoLabel.Text = "Amendment No:"
        '
        'AmendmentDateLabel
        '
        AmendmentDateLabel.AutoSize = True
        AmendmentDateLabel.Location = New System.Drawing.Point(219, 52)
        AmendmentDateLabel.Name = "AmendmentDateLabel"
        AmendmentDateLabel.Size = New System.Drawing.Size(94, 13)
        AmendmentDateLabel.TabIndex = 28
        AmendmentDateLabel.Text = "Amendment Date:"
        '
        'GMQtyLabel
        '
        GMQtyLabel.AutoSize = True
        GMQtyLabel.Location = New System.Drawing.Point(761, 8)
        GMQtyLabel.Name = "GMQtyLabel"
        GMQtyLabel.Size = New System.Drawing.Size(51, 13)
        GMQtyLabel.TabIndex = 60
        GMQtyLabel.Text = "G.M Qty:"
        '
        'ReferenceLabel
        '
        ReferenceLabel.AutoSize = True
        ReferenceLabel.Location = New System.Drawing.Point(429, 79)
        ReferenceLabel.Name = "ReferenceLabel"
        ReferenceLabel.Size = New System.Drawing.Size(61, 13)
        ReferenceLabel.TabIndex = 55
        ReferenceLabel.Text = "Reference:"
        '
        'AttentionLabel
        '
        AttentionLabel.AutoSize = True
        AttentionLabel.Location = New System.Drawing.Point(6, 125)
        AttentionLabel.Name = "AttentionLabel"
        AttentionLabel.Size = New System.Drawing.Size(56, 13)
        AttentionLabel.TabIndex = 56
        AttentionLabel.Text = "Attention:"
        '
        'TermsConditionLabel
        '
        TermsConditionLabel.AutoSize = True
        TermsConditionLabel.Location = New System.Drawing.Point(6, 148)
        TermsConditionLabel.Name = "TermsConditionLabel"
        TermsConditionLabel.Size = New System.Drawing.Size(88, 13)
        TermsConditionLabel.TabIndex = 57
        TermsConditionLabel.Text = "Terms Condition:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(1083, 8)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(77, 13)
        Label4.TabIndex = 62
        Label4.Text = "Booking Date :"
        '
        'colUnitPrice1
        '
        Me.colUnitPrice1.FieldName = "UnitPrice"
        Me.colUnitPrice1.Name = "colUnitPrice1"
        Me.colUnitPrice1.Visible = True
        Me.colUnitPrice1.VisibleIndex = 25
        '
        'colConsumption
        '
        Me.colConsumption.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colConsumption.AppearanceCell.Options.UseBackColor = True
        Me.colConsumption.AppearanceHeader.Options.UseTextOptions = True
        Me.colConsumption.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConsumption.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConsumption.Caption = "Con"
        Me.colConsumption.FieldName = "Consumption"
        Me.colConsumption.Name = "colConsumption"
        Me.colConsumption.Visible = True
        Me.colConsumption.VisibleIndex = 21
        Me.colConsumption.Width = 47
        '
        'colTotalPrice
        '
        Me.colTotalPrice.DisplayFormat.FormatString = " ##,##.000000"
        Me.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTotalPrice.FieldName = "TotalPrice"
        Me.colTotalPrice.Name = "colTotalPrice"
        Me.colTotalPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTotalPrice.Visible = True
        Me.colTotalPrice.VisibleIndex = 26
        '
        'CmdEdit
        '
        Me.CmdEdit.Location = New System.Drawing.Point(90, 10)
        Me.CmdEdit.Name = "CmdEdit"
        Me.CmdEdit.Size = New System.Drawing.Size(81, 23)
        Me.CmdEdit.TabIndex = 47
        Me.CmdEdit.Text = "&Edit"
        '
        'CmdDelete
        '
        Me.CmdDelete.Location = New System.Drawing.Point(177, 10)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(81, 23)
        Me.CmdDelete.TabIndex = 46
        Me.CmdDelete.Text = "&Delete"
        '
        'CmdAWSNoShow
        '
        Me.CmdAWSNoShow.Location = New System.Drawing.Point(559, 10)
        Me.CmdAWSNoShow.Name = "CmdAWSNoShow"
        Me.CmdAWSNoShow.Size = New System.Drawing.Size(79, 23)
        Me.CmdAWSNoShow.TabIndex = 45
        Me.CmdAWSNoShow.Text = "&Show"
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(3, 10)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(81, 23)
        Me.cmdAddNew.TabIndex = 44
        Me.cmdAddNew.Text = "&New"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(385, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Program No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(271, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "AWS No"
        '
        'CmdAccBOMNoShow
        '
        Me.CmdAccBOMNoShow.Location = New System.Drawing.Point(652, 3)
        Me.CmdAccBOMNoShow.Name = "CmdAccBOMNoShow"
        Me.CmdAccBOMNoShow.Size = New System.Drawing.Size(100, 23)
        Me.CmdAccBOMNoShow.TabIndex = 41
        Me.CmdAccBOMNoShow.Text = "&Show"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(3, 1)
        Me.SplitContainerControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.BookingDateTimePicker)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label4)
        Me.SplitContainerControl1.Panel1.Controls.Add(GMQtyLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GMQtyTextEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AccessoresBookingDetailsGridControl)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmdInvert)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CmdGetSelectedData)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AllCheckBox)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AccBOMNoLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CmdAccBOMNoShow)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.AccessoriesWorkOrderSheetDetailsGridControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1338, 351)
        Me.SplitContainerControl1.SplitterPosition = 195
        Me.SplitContainerControl1.TabIndex = 51
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'BookingDateTimePicker
        '
        Me.BookingDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.BookingDateTimePicker.Enabled = False
        Me.BookingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BookingDateTimePicker.Location = New System.Drawing.Point(1167, 4)
        Me.BookingDateTimePicker.Name = "BookingDateTimePicker"
        Me.BookingDateTimePicker.Size = New System.Drawing.Size(116, 21)
        Me.BookingDateTimePicker.TabIndex = 59
        '
        'GMQtyTextEdit
        '
        Me.GMQtyTextEdit.Enabled = False
        Me.GMQtyTextEdit.Location = New System.Drawing.Point(827, 5)
        Me.GMQtyTextEdit.Name = "GMQtyTextEdit"
        Me.GMQtyTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GMQtyTextEdit.Properties.Appearance.Options.UseFont = True
        Me.GMQtyTextEdit.Size = New System.Drawing.Size(234, 20)
        Me.GMQtyTextEdit.TabIndex = 61
        '
        'AccessoresBookingDetailsGridControl
        '
        Me.AccessoresBookingDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessoresBookingDetailsGridControl.DataSource = Me.AccessoresBookingDetailsBindingSource
        Me.AccessoresBookingDetailsGridControl.Location = New System.Drawing.Point(3, 32)
        Me.AccessoresBookingDetailsGridControl.MainView = Me.GridView2
        Me.AccessoresBookingDetailsGridControl.Name = "AccessoresBookingDetailsGridControl"
        Me.AccessoresBookingDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3, Me.RepositoryItemGridLookUpEdit4, Me.RepositoryItemGridLookUpEdit5, Me.RepositoryItemGridLookUpEdit6, Me.RepositoryItemGridLookUpEdit7, Me.RepositoryItemGridLookUpEdit8, Me.RepositoryItemPictureEdit1})
        Me.AccessoresBookingDetailsGridControl.Size = New System.Drawing.Size(1332, 156)
        Me.AccessoresBookingDetailsGridControl.TabIndex = 59
        Me.AccessoresBookingDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView3})
        '
        'AccessoresBookingDetailsBindingSource
        '
        Me.AccessoresBookingDetailsBindingSource.DataMember = "AccessoresBookingDetails"
        Me.AccessoresBookingDetailsBindingSource.DataSource = Me.AccessoriesBookingNewDataSet
        '
        'AccessoriesBookingNewDataSet
        '
        Me.AccessoriesBookingNewDataSet.DataSetName = "AccessoriesBookingNewDataSet"
        Me.AccessoriesBookingNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.ColumnPanelRowHeight = 40
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colAccessoriesBookingId, Me.colFabricColorId, Me.colConsumption, Me.colConsumptionUnitId, Me.colBookingUnitId, Me.colBookingQuantity, Me.colSupplierId, Me.GridColumn3, Me.GridColumn2, Me.colItemStyle1, Me.colConsumptionForPcs, Me.colWastagePercentage, Me.colSLNo, Me.colTotalPrice, Me.colSizeId1, Me.colDestinationId, Me.colPackType, Me.GridColumn5, Me.colIsSelected, Me.colUnitPrice1, Me.colPicture, Me.colAdditionalQuantity, Me.colBuyerDepartment, Me.colFabrication, Me.colItemCode, Me.colKimballNo, Me.colOrderNO, Me.colPO, Me.colSKU, Me.colColorCode})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(1082, 111, 216, 318)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colUnitPrice1
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = 0
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colConsumption
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = 0
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.colTotalPrice
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = 0
        Me.GridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GridView2.GridControl = Me.AccessoresBookingDetailsGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsDetail.AllowZoomDetail = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsDetail.SmartDetailExpand = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowDetailButtons = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.RowHeight = 40
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn1.FieldName = "AccessoriesBookingDetailsId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'colAccessoriesBookingId
        '
        Me.colAccessoriesBookingId.AppearanceHeader.Options.UseTextOptions = True
        Me.colAccessoriesBookingId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAccessoriesBookingId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAccessoriesBookingId.FieldName = "AccessoriesBookingId"
        Me.colAccessoriesBookingId.Name = "colAccessoriesBookingId"
        Me.colAccessoriesBookingId.Width = 130
        '
        'colFabricColorId
        '
        Me.colFabricColorId.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricColorId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricColorId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricColorId.Caption = "Color"
        Me.colFabricColorId.ColumnEdit = Me.RepositoryItemGridLookUpEdit4
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 6
        Me.colFabricColorId.Width = 144
        '
        'RepositoryItemGridLookUpEdit4
        '
        Me.RepositoryItemGridLookUpEdit4.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit4.DataSource = Me.FabricColorBindingSource
        Me.RepositoryItemGridLookUpEdit4.DisplayMember = "FabricColorName"
        Me.RepositoryItemGridLookUpEdit4.Name = "RepositoryItemGridLookUpEdit4"
        Me.RepositoryItemGridLookUpEdit4.NullText = "[Null]"
        Me.RepositoryItemGridLookUpEdit4.PopupView = Me.RepositoryItemGridLookUpEdit4View
        Me.RepositoryItemGridLookUpEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit4.ValueMember = "FabricColorId"
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
        'RepositoryItemGridLookUpEdit4View
        '
        Me.RepositoryItemGridLookUpEdit4View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName})
        Me.RepositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit4View.Name = "RepositoryItemGridLookUpEdit4View"
        Me.RepositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        '
        'colConsumptionUnitId
        '
        Me.colConsumptionUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colConsumptionUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConsumptionUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConsumptionUnitId.Caption = "Con Unit"
        Me.colConsumptionUnitId.ColumnEdit = Me.RepositoryItemGridLookUpEdit7
        Me.colConsumptionUnitId.FieldName = "ConsumptionUnitId"
        Me.colConsumptionUnitId.Name = "colConsumptionUnitId"
        Me.colConsumptionUnitId.Visible = True
        Me.colConsumptionUnitId.VisibleIndex = 22
        Me.colConsumptionUnitId.Width = 42
        '
        'RepositoryItemGridLookUpEdit7
        '
        Me.RepositoryItemGridLookUpEdit7.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit7.DataSource = Me.UnitBindingSource
        Me.RepositoryItemGridLookUpEdit7.DisplayMember = "UnitCode"
        Me.RepositoryItemGridLookUpEdit7.Name = "RepositoryItemGridLookUpEdit7"
        Me.RepositoryItemGridLookUpEdit7.NullText = "[Null]"
        Me.RepositoryItemGridLookUpEdit7.PopupView = Me.RepositoryItemGridLookUpEdit7View
        Me.RepositoryItemGridLookUpEdit7.ValueMember = "UnitId"
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
        'RepositoryItemGridLookUpEdit7View
        '
        Me.RepositoryItemGridLookUpEdit7View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId1, Me.colUnitCode, Me.colUnitName})
        Me.RepositoryItemGridLookUpEdit7View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit7View.Name = "RepositoryItemGridLookUpEdit7View"
        Me.RepositoryItemGridLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit7View.OptionsView.ShowGroupPanel = False
        '
        'colUnitId1
        '
        Me.colUnitId1.FieldName = "UnitId"
        Me.colUnitId1.Name = "colUnitId1"
        Me.colUnitId1.OptionsColumn.ReadOnly = True
        '
        'colUnitCode
        '
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Visible = True
        Me.colUnitCode.VisibleIndex = 0
        '
        'colUnitName
        '
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        '
        'colBookingUnitId
        '
        Me.colBookingUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colBookingUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBookingUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBookingUnitId.Caption = "Booking Unit"
        Me.colBookingUnitId.ColumnEdit = Me.RepositoryItemGridLookUpEdit8
        Me.colBookingUnitId.FieldName = "BookingUnitId"
        Me.colBookingUnitId.Name = "colBookingUnitId"
        Me.colBookingUnitId.Visible = True
        Me.colBookingUnitId.VisibleIndex = 20
        Me.colBookingUnitId.Width = 58
        '
        'RepositoryItemGridLookUpEdit8
        '
        Me.RepositoryItemGridLookUpEdit8.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit8.DataSource = Me.UnitBindingSource
        Me.RepositoryItemGridLookUpEdit8.DisplayMember = "UnitCode"
        Me.RepositoryItemGridLookUpEdit8.Name = "RepositoryItemGridLookUpEdit8"
        Me.RepositoryItemGridLookUpEdit8.NullText = ""
        Me.RepositoryItemGridLookUpEdit8.PopupView = Me.RepositoryItemGridLookUpEdit8View
        Me.RepositoryItemGridLookUpEdit8.ValueMember = "UnitId"
        '
        'RepositoryItemGridLookUpEdit8View
        '
        Me.RepositoryItemGridLookUpEdit8View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId2, Me.colUnitCode1, Me.colUnitName1})
        Me.RepositoryItemGridLookUpEdit8View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit8View.Name = "RepositoryItemGridLookUpEdit8View"
        Me.RepositoryItemGridLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit8View.OptionsView.ShowGroupPanel = False
        '
        'colUnitId2
        '
        Me.colUnitId2.FieldName = "UnitId"
        Me.colUnitId2.Name = "colUnitId2"
        Me.colUnitId2.OptionsColumn.ReadOnly = True
        '
        'colUnitCode1
        '
        Me.colUnitCode1.FieldName = "UnitCode"
        Me.colUnitCode1.Name = "colUnitCode1"
        Me.colUnitCode1.Visible = True
        Me.colUnitCode1.VisibleIndex = 0
        '
        'colUnitName1
        '
        Me.colUnitName1.FieldName = "UnitName"
        Me.colUnitName1.Name = "colUnitName1"
        '
        'colBookingQuantity
        '
        Me.colBookingQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colBookingQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBookingQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBookingQuantity.FieldName = "BookingQuantity"
        Me.colBookingQuantity.Name = "colBookingQuantity"
        Me.colBookingQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBookingQuantity.Visible = True
        Me.colBookingQuantity.VisibleIndex = 18
        Me.colBookingQuantity.Width = 90
        '
        'colSupplierId
        '
        Me.colSupplierId.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierId.Caption = "Supplier"
        Me.colSupplierId.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.Visible = True
        Me.colSupplierId.VisibleIndex = 0
        Me.colSupplierId.Width = 102
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.SupplierBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "SupplierCode"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "SupplierId"
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
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId3, Me.colSupplierName1, Me.colAdd11, Me.colAdd21, Me.colContactPerson1, Me.colContactNo1, Me.colSupplierType1, Me.colSupplierCode1, Me.colCity1, Me.colCountry1})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId3
        '
        Me.colSupplierId3.FieldName = "SupplierId"
        Me.colSupplierId3.Name = "colSupplierId3"
        Me.colSupplierId3.OptionsColumn.ReadOnly = True
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
        '
        'colAdd11
        '
        Me.colAdd11.FieldName = "Add1"
        Me.colAdd11.Name = "colAdd11"
        '
        'colAdd21
        '
        Me.colAdd21.FieldName = "Add2"
        Me.colAdd21.Name = "colAdd21"
        '
        'colContactPerson1
        '
        Me.colContactPerson1.FieldName = "ContactPerson"
        Me.colContactPerson1.Name = "colContactPerson1"
        '
        'colContactNo1
        '
        Me.colContactNo1.FieldName = "ContactNo"
        Me.colContactNo1.Name = "colContactNo1"
        '
        'colSupplierType1
        '
        Me.colSupplierType1.FieldName = "SupplierType"
        Me.colSupplierType1.Name = "colSupplierType1"
        '
        'colSupplierCode1
        '
        Me.colSupplierCode1.FieldName = "SupplierCode"
        Me.colSupplierCode1.Name = "colSupplierCode1"
        Me.colSupplierCode1.Visible = True
        Me.colSupplierCode1.VisibleIndex = 0
        '
        'colCity1
        '
        Me.colCity1.FieldName = "City"
        Me.colCity1.Name = "colCity1"
        '
        'colCountry1
        '
        Me.colCountry1.FieldName = "Country"
        Me.colCountry1.Name = "colCountry1"
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn3.FieldName = "Remarks"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 27
        Me.GridColumn3.Width = 104
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn2.Caption = "Item Name"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.GridColumn2.FieldName = "ItemId"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "AccessoriesId", "")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        Me.GridColumn2.Width = 311
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.ItemListBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "ItemName"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = "[Null]"
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "ItemId"
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListLookupDataSet
        '
        'ItemListLookupDataSet
        '
        Me.ItemListLookupDataSet.DataSetName = "ItemListLookupDataSet"
        Me.ItemListLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'colItemStyle1
        '
        Me.colItemStyle1.ColumnEdit = Me.RepositoryItemGridLookUpEdit3
        Me.colItemStyle1.FieldName = "ItemStyle"
        Me.colItemStyle1.Name = "colItemStyle1"
        Me.colItemStyle1.Width = 117
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.AccessoriesListLookupBindingSource
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "ItemStyle"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.NullText = "[Null]"
        Me.RepositoryItemGridLookUpEdit3.PopupView = Me.RepositoryItemGridLookUpEdit3View
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "AccessoriesId"
        '
        'AccessoriesListLookupBindingSource
        '
        Me.AccessoriesListLookupBindingSource.DataMember = "AccessoriesListLookup"
        Me.AccessoriesListLookupBindingSource.DataSource = Me.AccessoriesListDataSet
        '
        'AccessoriesListDataSet
        '
        Me.AccessoriesListDataSet.DataSetName = "AccessoriesListDataSet"
        Me.AccessoriesListDataSet.EnforceConstraints = False
        Me.AccessoriesListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccessoriesId2, Me.colAccessoriesName1, Me.colItemStyle2, Me.colItemDetails1})
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colAccessoriesId2
        '
        Me.colAccessoriesId2.FieldName = "AccessoriesId"
        Me.colAccessoriesId2.Name = "colAccessoriesId2"
        Me.colAccessoriesId2.OptionsColumn.ReadOnly = True
        '
        'colAccessoriesName1
        '
        Me.colAccessoriesName1.FieldName = "AccessoriesName"
        Me.colAccessoriesName1.Name = "colAccessoriesName1"
        '
        'colItemStyle2
        '
        Me.colItemStyle2.FieldName = "ItemStyle"
        Me.colItemStyle2.Name = "colItemStyle2"
        Me.colItemStyle2.OptionsColumn.ReadOnly = True
        Me.colItemStyle2.Visible = True
        Me.colItemStyle2.VisibleIndex = 0
        '
        'colItemDetails1
        '
        Me.colItemDetails1.FieldName = "ItemDetails"
        Me.colItemDetails1.Name = "colItemDetails1"
        Me.colItemDetails1.OptionsColumn.ReadOnly = True
        '
        'colConsumptionForPcs
        '
        Me.colConsumptionForPcs.AppearanceHeader.Options.UseTextOptions = True
        Me.colConsumptionForPcs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConsumptionForPcs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConsumptionForPcs.Caption = "Pcs/Con"
        Me.colConsumptionForPcs.FieldName = "ConsumptionForPcs"
        Me.colConsumptionForPcs.Name = "colConsumptionForPcs"
        Me.colConsumptionForPcs.Visible = True
        Me.colConsumptionForPcs.VisibleIndex = 23
        Me.colConsumptionForPcs.Width = 80
        '
        'colWastagePercentage
        '
        Me.colWastagePercentage.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colWastagePercentage.AppearanceCell.Options.UseBackColor = True
        Me.colWastagePercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colWastagePercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWastagePercentage.Caption = "W%"
        Me.colWastagePercentage.FieldName = "WastagePercentage"
        Me.colWastagePercentage.Name = "colWastagePercentage"
        Me.colWastagePercentage.Visible = True
        Me.colWastagePercentage.VisibleIndex = 24
        Me.colWastagePercentage.Width = 49
        '
        'colSLNo
        '
        Me.colSLNo.FieldName = "SLNo"
        Me.colSLNo.Name = "colSLNo"
        Me.colSLNo.Visible = True
        Me.colSLNo.VisibleIndex = 2
        Me.colSLNo.Width = 58
        '
        'colSizeId1
        '
        Me.colSizeId1.AppearanceCell.Options.UseTextOptions = True
        Me.colSizeId1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSizeId1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSizeId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colSizeId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSizeId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSizeId1.Caption = "Size"
        Me.colSizeId1.ColumnEdit = Me.RepositoryItemGridLookUpEdit5
        Me.colSizeId1.FieldName = "SizeId"
        Me.colSizeId1.Name = "colSizeId1"
        Me.colSizeId1.Visible = True
        Me.colSizeId1.VisibleIndex = 8
        Me.colSizeId1.Width = 66
        '
        'RepositoryItemGridLookUpEdit5
        '
        Me.RepositoryItemGridLookUpEdit5.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit5.DataSource = Me.SizeLookupBindingSource
        Me.RepositoryItemGridLookUpEdit5.DisplayMember = "SizeCode"
        Me.RepositoryItemGridLookUpEdit5.Name = "RepositoryItemGridLookUpEdit5"
        Me.RepositoryItemGridLookUpEdit5.NullText = ""
        Me.RepositoryItemGridLookUpEdit5.PopupView = Me.RepositoryItemGridLookUpEdit5View
        Me.RepositoryItemGridLookUpEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit5.ValueMember = "SizeId"
        '
        'SizeLookupBindingSource
        '
        Me.SizeLookupBindingSource.DataMember = "SizeLookup"
        Me.SizeLookupBindingSource.DataSource = Me.SizeDataSet
        '
        'SizeDataSet
        '
        Me.SizeDataSet.DataSetName = "SizeDataSet"
        Me.SizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit5View
        '
        Me.RepositoryItemGridLookUpEdit5View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId2, Me.colSizeId, Me.colSizeCode, Me.colSlNo1})
        Me.RepositoryItemGridLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit5View.Name = "RepositoryItemGridLookUpEdit5View"
        Me.RepositoryItemGridLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit5View.OptionsView.ShowGroupPanel = False
        '
        'colOrderId2
        '
        Me.colOrderId2.FieldName = "OrderId"
        Me.colOrderId2.Name = "colOrderId2"
        Me.colOrderId2.OptionsColumn.ReadOnly = True
        '
        'colSizeId
        '
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'colSlNo1
        '
        Me.colSlNo1.FieldName = "SlNo"
        Me.colSlNo1.Name = "colSlNo1"
        '
        'colDestinationId
        '
        Me.colDestinationId.Caption = "Destination"
        Me.colDestinationId.ColumnEdit = Me.RepositoryItemGridLookUpEdit6
        Me.colDestinationId.FieldName = "DestinationId"
        Me.colDestinationId.Name = "colDestinationId"
        Me.colDestinationId.Visible = True
        Me.colDestinationId.VisibleIndex = 16
        Me.colDestinationId.Width = 84
        '
        'RepositoryItemGridLookUpEdit6
        '
        Me.RepositoryItemGridLookUpEdit6.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit6.DataSource = Me.DestinationBindingSource
        Me.RepositoryItemGridLookUpEdit6.DisplayMember = "DestinationCode"
        Me.RepositoryItemGridLookUpEdit6.Name = "RepositoryItemGridLookUpEdit6"
        Me.RepositoryItemGridLookUpEdit6.NullText = ""
        Me.RepositoryItemGridLookUpEdit6.PopupView = Me.RepositoryItemGridLookUpEdit6View
        Me.RepositoryItemGridLookUpEdit6.ValueMember = "DestinationId"
        '
        'DestinationBindingSource
        '
        Me.DestinationBindingSource.DataMember = "Destination"
        Me.DestinationBindingSource.DataSource = Me.DestinationDataSet
        '
        'DestinationDataSet
        '
        Me.DestinationDataSet.DataSetName = "DestinationDataSet"
        Me.DestinationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit6View
        '
        Me.RepositoryItemGridLookUpEdit6View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDestinationId1, Me.colDestinationCode, Me.colDestinationName})
        Me.RepositoryItemGridLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit6View.Name = "RepositoryItemGridLookUpEdit6View"
        Me.RepositoryItemGridLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit6View.OptionsView.ShowGroupPanel = False
        '
        'colDestinationId1
        '
        Me.colDestinationId1.FieldName = "DestinationId"
        Me.colDestinationId1.Name = "colDestinationId1"
        Me.colDestinationId1.OptionsColumn.ReadOnly = True
        '
        'colDestinationCode
        '
        Me.colDestinationCode.FieldName = "DestinationCode"
        Me.colDestinationCode.Name = "colDestinationCode"
        Me.colDestinationCode.Visible = True
        Me.colDestinationCode.VisibleIndex = 0
        '
        'colDestinationName
        '
        Me.colDestinationName.FieldName = "DestinationName"
        Me.colDestinationName.Name = "colDestinationName"
        '
        'colPackType
        '
        Me.colPackType.FieldName = "PackType"
        Me.colPackType.Name = "colPackType"
        Me.colPackType.Visible = True
        Me.colPackType.VisibleIndex = 15
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridColumn5.FieldName = "OrderQuantity"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 17
        Me.GridColumn5.Width = 65
        '
        'colIsSelected
        '
        Me.colIsSelected.FieldName = "IsSelected"
        Me.colIsSelected.Name = "colIsSelected"
        Me.colIsSelected.Visible = True
        Me.colIsSelected.VisibleIndex = 1
        '
        'colPicture
        '
        Me.colPicture.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.colPicture.FieldName = "Picture"
        Me.colPicture.Name = "colPicture"
        Me.colPicture.Visible = True
        Me.colPicture.VisibleIndex = 5
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'colAdditionalQuantity
        '
        Me.colAdditionalQuantity.FieldName = "AdditionalQuantity"
        Me.colAdditionalQuantity.Name = "colAdditionalQuantity"
        Me.colAdditionalQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colAdditionalQuantity.Visible = True
        Me.colAdditionalQuantity.VisibleIndex = 19
        Me.colAdditionalQuantity.Width = 105
        '
        'colBuyerDepartment
        '
        Me.colBuyerDepartment.FieldName = "BuyerDepartment"
        Me.colBuyerDepartment.Name = "colBuyerDepartment"
        Me.colBuyerDepartment.Visible = True
        Me.colBuyerDepartment.VisibleIndex = 14
        Me.colBuyerDepartment.Width = 98
        '
        'colFabrication
        '
        Me.colFabrication.FieldName = "Fabrication"
        Me.colFabrication.Name = "colFabrication"
        Me.colFabrication.Visible = True
        Me.colFabrication.VisibleIndex = 13
        '
        'colItemCode
        '
        Me.colItemCode.Caption = "Item Code / Number"
        Me.colItemCode.FieldName = "ItemCode"
        Me.colItemCode.Name = "colItemCode"
        Me.colItemCode.Visible = True
        Me.colItemCode.VisibleIndex = 3
        '
        'colKimballNo
        '
        Me.colKimballNo.FieldName = "KimballNo"
        Me.colKimballNo.Name = "colKimballNo"
        Me.colKimballNo.Visible = True
        Me.colKimballNo.VisibleIndex = 11
        '
        'colOrderNO
        '
        Me.colOrderNO.FieldName = "OrderNO"
        Me.colOrderNO.Name = "colOrderNO"
        Me.colOrderNO.Visible = True
        Me.colOrderNO.VisibleIndex = 10
        '
        'colPO
        '
        Me.colPO.FieldName = "PO"
        Me.colPO.Name = "colPO"
        Me.colPO.Visible = True
        Me.colPO.VisibleIndex = 9
        '
        'colSKU
        '
        Me.colSKU.Caption = "SKU / USIM"
        Me.colSKU.FieldName = "SKU"
        Me.colSKU.Name = "colSKU"
        Me.colSKU.Visible = True
        Me.colSKU.VisibleIndex = 12
        '
        'colColorCode
        '
        Me.colColorCode.FieldName = "ColorCode"
        Me.colColorCode.Name = "colColorCode"
        Me.colColorCode.Visible = True
        Me.colColorCode.VisibleIndex = 7
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.AccessoresBookingDetailsGridControl
        Me.GridView3.Name = "GridView3"
        '
        'cmdInvert
        '
        Me.cmdInvert.Location = New System.Drawing.Point(79, 3)
        Me.cmdInvert.Name = "cmdInvert"
        Me.cmdInvert.Size = New System.Drawing.Size(81, 23)
        Me.cmdInvert.TabIndex = 58
        Me.cmdInvert.Text = "&Invert Select"
        '
        'CmdGetSelectedData
        '
        Me.CmdGetSelectedData.Location = New System.Drawing.Point(166, 3)
        Me.CmdGetSelectedData.Name = "CmdGetSelectedData"
        Me.CmdGetSelectedData.Size = New System.Drawing.Size(107, 23)
        Me.CmdGetSelectedData.TabIndex = 35
        Me.CmdGetSelectedData.Text = "&Get Selected Data"
        '
        'AllCheckBox
        '
        Me.AllCheckBox.AutoSize = True
        Me.AllCheckBox.Location = New System.Drawing.Point(3, 6)
        Me.AllCheckBox.Name = "AllCheckBox"
        Me.AllCheckBox.Size = New System.Drawing.Size(69, 17)
        Me.AllCheckBox.TabIndex = 59
        Me.AllCheckBox.Text = "Select All"
        Me.AllCheckBox.UseVisualStyleBackColor = True
        '
        'AccBOMNoLookUpEdit
        '
        Me.AccBOMNoLookUpEdit.Location = New System.Drawing.Point(454, 4)
        Me.AccBOMNoLookUpEdit.Name = "AccBOMNoLookUpEdit"
        Me.AccBOMNoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccBOMNoLookUpEdit.Properties.DataSource = Me.AccBookingLookupBindingSource
        Me.AccBOMNoLookUpEdit.Properties.DisplayMember = "Details"
        Me.AccBOMNoLookUpEdit.Properties.NullText = ""
        Me.AccBOMNoLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AccBOMNoLookUpEdit.Properties.PopupView = Me.GridLookUpEdit2View
        Me.AccBOMNoLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AccBOMNoLookUpEdit.Properties.ValueMember = "AccessoriesBookingId"
        Me.AccBOMNoLookUpEdit.Size = New System.Drawing.Size(192, 20)
        Me.AccBOMNoLookUpEdit.TabIndex = 53
        '
        'AccBookingLookupBindingSource
        '
        Me.AccBookingLookupBindingSource.DataMember = "AccBookingLookup"
        Me.AccBookingLookupBindingSource.DataSource = Me.AccBOMLookUpDataSet
        '
        'AccBOMLookUpDataSet
        '
        Me.AccBOMLookUpDataSet.DataSetName = "AccBOMLookUpDataSet"
        Me.AccBOMLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'AccessoriesWorkOrderSheetDetailsGridControl
        '
        Me.AccessoriesWorkOrderSheetDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessoriesWorkOrderSheetDetailsGridControl.DataSource = Me.AccessoriesWorkOrderSheetDetailsBindingSource1
        Me.AccessoriesWorkOrderSheetDetailsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.AccessoriesWorkOrderSheetDetailsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.AccessoriesWorkOrderSheetDetailsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.AccessoriesWorkOrderSheetDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.AccessoriesWorkOrderSheetDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.AccessoriesWorkOrderSheetDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.AccessoriesWorkOrderSheetDetailsGridControl.Location = New System.Drawing.Point(0, 3)
        Me.AccessoriesWorkOrderSheetDetailsGridControl.MainView = Me.GridView1
        Me.AccessoriesWorkOrderSheetDetailsGridControl.Name = "AccessoriesWorkOrderSheetDetailsGridControl"
        Me.AccessoriesWorkOrderSheetDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit9, Me.RepositoryItemGridLookUpEdit10, Me.RepositoryItemGridLookUpEdit11, Me.ItemNameGridLookUpEdit, Me.ItemStyleGridLookUpEdit})
        Me.AccessoriesWorkOrderSheetDetailsGridControl.Size = New System.Drawing.Size(1338, 144)
        Me.AccessoriesWorkOrderSheetDetailsGridControl.TabIndex = 35
        Me.AccessoriesWorkOrderSheetDetailsGridControl.UseEmbeddedNavigator = True
        Me.AccessoriesWorkOrderSheetDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AccessoriesWorkOrderSheetDetailsBindingSource1
        '
        Me.AccessoriesWorkOrderSheetDetailsBindingSource1.DataMember = "AccessoriesWorkOrderSheet_AccessoriesWorkOrderSheetDetails"
        Me.AccessoriesWorkOrderSheetDetailsBindingSource1.DataSource = Me.AccessoriesWorkOrderSheetBindingSource
        '
        'AccessoriesWorkOrderSheetBindingSource
        '
        Me.AccessoriesWorkOrderSheetBindingSource.DataMember = "AccessoriesWorkOrderSheet"
        Me.AccessoriesWorkOrderSheetBindingSource.DataSource = Me.AWS_DataSet
        '
        'AWS_DataSet
        '
        Me.AWS_DataSet.DataSetName = "AWS_DataSet"
        Me.AWS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccessoriesBookingDetailsId, Me.colOrderQuantity, Me.colUnitId, Me.colUnitPrice, Me.colCurrencyId, Me.colRemarks, Me.colAccessoriesBookingDetailsId21, Me.colAdditionalCharge, Me.colAdditionalChargeFor, Me.colTotalPrice1})
        Me.GridView1.GridControl = Me.AccessoriesWorkOrderSheetDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colAccessoriesBookingDetailsId
        '
        Me.colAccessoriesBookingDetailsId.Caption = "Item Name :: Item Code :: Program No :: Style :: Color :: Size"
        Me.colAccessoriesBookingDetailsId.ColumnEdit = Me.ItemNameGridLookUpEdit
        Me.colAccessoriesBookingDetailsId.FieldName = "AccessoriesBookingDetailsId"
        Me.colAccessoriesBookingDetailsId.Name = "colAccessoriesBookingDetailsId"
        Me.colAccessoriesBookingDetailsId.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colAccessoriesBookingDetailsId.Visible = True
        Me.colAccessoriesBookingDetailsId.VisibleIndex = 0
        Me.colAccessoriesBookingDetailsId.Width = 421
        '
        'ItemNameGridLookUpEdit
        '
        Me.ItemNameGridLookUpEdit.AutoHeight = False
        Me.ItemNameGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemNameGridLookUpEdit.DataSource = Me.AccBOMItemLookupNewBindingSource
        Me.ItemNameGridLookUpEdit.DisplayMember = "Details"
        Me.ItemNameGridLookUpEdit.Name = "ItemNameGridLookUpEdit"
        Me.ItemNameGridLookUpEdit.NullText = ""
        Me.ItemNameGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit12View
        Me.ItemNameGridLookUpEdit.ValueMember = "AccessoriesBookingDetailsId"
        '
        'AccBOMItemLookupNewBindingSource
        '
        Me.AccBOMItemLookupNewBindingSource.DataMember = "AccBOMItemLookupNew"
        Me.AccBOMItemLookupNewBindingSource.DataSource = Me.AccBOMItemLookupNewDataSet
        '
        'AccBOMItemLookupNewDataSet
        '
        Me.AccBOMItemLookupNewDataSet.DataSetName = "AccBOMItemLookupNewDataSet"
        Me.AccBOMItemLookupNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit12View
        '
        Me.RepositoryItemGridLookUpEdit12View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName1})
        Me.RepositoryItemGridLookUpEdit12View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit12View.Name = "RepositoryItemGridLookUpEdit12View"
        Me.RepositoryItemGridLookUpEdit12View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit12View.OptionsView.ShowGroupPanel = False
        '
        'colItemName1
        '
        Me.colItemName1.FieldName = "ItemName"
        Me.colItemName1.Name = "colItemName1"
        Me.colItemName1.Visible = True
        Me.colItemName1.VisibleIndex = 0
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 1
        Me.colOrderQuantity.Width = 115
        '
        'colUnitId
        '
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.RepositoryItemGridLookUpEdit10
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 2
        Me.colUnitId.Width = 63
        '
        'RepositoryItemGridLookUpEdit10
        '
        Me.RepositoryItemGridLookUpEdit10.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit10.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit10.DataSource = Me.UnitBindingSource
        Me.RepositoryItemGridLookUpEdit10.DisplayMember = "UnitCode"
        Me.RepositoryItemGridLookUpEdit10.Name = "RepositoryItemGridLookUpEdit10"
        Me.RepositoryItemGridLookUpEdit10.PopupView = Me.RepositoryItemGridLookUpEdit10View
        Me.RepositoryItemGridLookUpEdit10.ValueMember = "UnitId"
        '
        'RepositoryItemGridLookUpEdit10View
        '
        Me.RepositoryItemGridLookUpEdit10View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId3, Me.colUnitCode2, Me.colUnitName2})
        Me.RepositoryItemGridLookUpEdit10View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit10View.Name = "RepositoryItemGridLookUpEdit10View"
        Me.RepositoryItemGridLookUpEdit10View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit10View.OptionsView.ShowGroupPanel = False
        '
        'colUnitId3
        '
        Me.colUnitId3.FieldName = "UnitId"
        Me.colUnitId3.Name = "colUnitId3"
        Me.colUnitId3.OptionsColumn.ReadOnly = True
        '
        'colUnitCode2
        '
        Me.colUnitCode2.FieldName = "UnitCode"
        Me.colUnitCode2.Name = "colUnitCode2"
        Me.colUnitCode2.Visible = True
        Me.colUnitCode2.VisibleIndex = 0
        '
        'colUnitName2
        '
        Me.colUnitName2.FieldName = "UnitName"
        Me.colUnitName2.Name = "colUnitName2"
        '
        'colUnitPrice
        '
        Me.colUnitPrice.DisplayFormat.FormatString = " ##,#0.0000"
        Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 3
        Me.colUnitPrice.Width = 73
        '
        'colCurrencyId
        '
        Me.colCurrencyId.FieldName = "CurrencyId"
        Me.colCurrencyId.Name = "colCurrencyId"
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 7
        Me.colRemarks.Width = 444
        '
        'colAccessoriesBookingDetailsId21
        '
        Me.colAccessoriesBookingDetailsId21.Caption = "Item Style"
        Me.colAccessoriesBookingDetailsId21.ColumnEdit = Me.ItemStyleGridLookUpEdit
        Me.colAccessoriesBookingDetailsId21.FieldName = "AccessoriesBookingDetailsId2"
        Me.colAccessoriesBookingDetailsId21.Name = "colAccessoriesBookingDetailsId21"
        Me.colAccessoriesBookingDetailsId21.Width = 114
        '
        'ItemStyleGridLookUpEdit
        '
        Me.ItemStyleGridLookUpEdit.AutoHeight = False
        Me.ItemStyleGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemStyleGridLookUpEdit.DisplayMember = "ItemStyle"
        Me.ItemStyleGridLookUpEdit.Name = "ItemStyleGridLookUpEdit"
        Me.ItemStyleGridLookUpEdit.NullText = ""
        Me.ItemStyleGridLookUpEdit.PopupView = Me.GridView5
        Me.ItemStyleGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemStyleGridLookUpEdit.ValueMember = "AccessoriesBookingDetailsId"
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colAdditionalCharge
        '
        Me.colAdditionalCharge.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAdditionalCharge.FieldName = "AdditionalCharge"
        Me.colAdditionalCharge.Name = "colAdditionalCharge"
        Me.colAdditionalCharge.Visible = True
        Me.colAdditionalCharge.VisibleIndex = 4
        Me.colAdditionalCharge.Width = 96
        '
        'colAdditionalChargeFor
        '
        Me.colAdditionalChargeFor.FieldName = "AdditionalChargeFor"
        Me.colAdditionalChargeFor.Name = "colAdditionalChargeFor"
        Me.colAdditionalChargeFor.Visible = True
        Me.colAdditionalChargeFor.VisibleIndex = 5
        Me.colAdditionalChargeFor.Width = 102
        '
        'colTotalPrice1
        '
        Me.colTotalPrice1.DisplayFormat.FormatString = " ##,#0.000000"
        Me.colTotalPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTotalPrice1.FieldName = "TotalPrice"
        Me.colTotalPrice1.Name = "colTotalPrice1"
        Me.colTotalPrice1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTotalPrice1.Visible = True
        Me.colTotalPrice1.VisibleIndex = 6
        Me.colTotalPrice1.Width = 87
        '
        'RepositoryItemGridLookUpEdit9
        '
        Me.RepositoryItemGridLookUpEdit9.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit9.DisplayMember = "AccessoriesName"
        Me.RepositoryItemGridLookUpEdit9.Name = "RepositoryItemGridLookUpEdit9"
        Me.RepositoryItemGridLookUpEdit9.PopupView = Me.RepositoryItemGridLookUpEdit9View
        Me.RepositoryItemGridLookUpEdit9.ValueMember = "AccessoriesBookingDetailsId"
        '
        'RepositoryItemGridLookUpEdit9View
        '
        Me.RepositoryItemGridLookUpEdit9View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccessoriesName2, Me.colAccessoriesBookingDetailsId1})
        Me.RepositoryItemGridLookUpEdit9View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit9View.Name = "RepositoryItemGridLookUpEdit9View"
        Me.RepositoryItemGridLookUpEdit9View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit9View.OptionsView.ShowGroupPanel = False
        '
        'colAccessoriesName2
        '
        Me.colAccessoriesName2.FieldName = "AccessoriesName"
        Me.colAccessoriesName2.Name = "colAccessoriesName2"
        Me.colAccessoriesName2.OptionsColumn.ReadOnly = True
        Me.colAccessoriesName2.Visible = True
        Me.colAccessoriesName2.VisibleIndex = 0
        '
        'colAccessoriesBookingDetailsId1
        '
        Me.colAccessoriesBookingDetailsId1.FieldName = "AccessoriesBookingDetailsId"
        Me.colAccessoriesBookingDetailsId1.Name = "colAccessoriesBookingDetailsId1"
        '
        'RepositoryItemGridLookUpEdit11
        '
        Me.RepositoryItemGridLookUpEdit11.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit11.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit11.DisplayMember = "AccessoriesName"
        Me.RepositoryItemGridLookUpEdit11.Name = "RepositoryItemGridLookUpEdit11"
        Me.RepositoryItemGridLookUpEdit11.PopupView = Me.RepositoryItemGridLookUpEdit11View
        Me.RepositoryItemGridLookUpEdit11.ValueMember = "AccessoriesBookingDetailsId"
        '
        'RepositoryItemGridLookUpEdit11View
        '
        Me.RepositoryItemGridLookUpEdit11View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccessoriesName3, Me.colAccessoriesBookingDetailsId2})
        Me.RepositoryItemGridLookUpEdit11View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit11View.Name = "RepositoryItemGridLookUpEdit11View"
        Me.RepositoryItemGridLookUpEdit11View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit11View.OptionsView.ShowGroupPanel = False
        '
        'colAccessoriesName3
        '
        Me.colAccessoriesName3.FieldName = "AccessoriesName"
        Me.colAccessoriesName3.Name = "colAccessoriesName3"
        Me.colAccessoriesName3.OptionsColumn.ReadOnly = True
        Me.colAccessoriesName3.Visible = True
        Me.colAccessoriesName3.VisibleIndex = 0
        '
        'colAccessoriesBookingDetailsId2
        '
        Me.colAccessoriesBookingDetailsId2.FieldName = "AccessoriesBookingDetailsId"
        Me.colAccessoriesBookingDetailsId2.Name = "colAccessoriesBookingDetailsId2"
        '
        'CmdShowHide
        '
        Me.CmdShowHide.Location = New System.Drawing.Point(816, 10)
        Me.CmdShowHide.Name = "CmdShowHide"
        Me.CmdShowHide.Size = New System.Drawing.Size(81, 23)
        Me.CmdShowHide.TabIndex = 60
        Me.CmdShowHide.Text = "&Hide"
        '
        'AccOrderLookupBindingSource
        '
        Me.AccOrderLookupBindingSource.DataMember = "AccOrderLookup"
        Me.AccOrderLookupBindingSource.DataSource = Me.AccessoriesBookingNewDataSet
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(TermsConditionLabel)
        Me.GroupBox1.Controls.Add(Me.TermsConditionMemoEdit)
        Me.GroupBox1.Controls.Add(AttentionLabel)
        Me.GroupBox1.Controls.Add(Me.AttentionTextEdit)
        Me.GroupBox1.Controls.Add(ReferenceLabel)
        Me.GroupBox1.Controls.Add(Me.ReferenceTextEdit)
        Me.GroupBox1.Controls.Add(Me.CompleteCheckEdit)
        Me.GroupBox1.Controls.Add(AmendmentDateLabel)
        Me.GroupBox1.Controls.Add(Me.AmendmentDateDateEdit)
        Me.GroupBox1.Controls.Add(AmendmentNoLabel)
        Me.GroupBox1.Controls.Add(Me.AmendmentNoSpinEdit)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Me.AccAmendmentHistoryGridControl)
        Me.GroupBox1.Controls.Add(AWSNoLabel)
        Me.GroupBox1.Controls.Add(Me.CauseOfCancelTextEdit)
        Me.GroupBox1.Controls.Add(Me.IsCancelCheckEdit)
        Me.GroupBox1.Controls.Add(Me.AWSNoTextEdit)
        Me.GroupBox1.Controls.Add(AWSDateLabel)
        Me.GroupBox1.Controls.Add(Me.AWSDateDateEdit)
        Me.GroupBox1.Controls.Add(RequireDateLabel)
        Me.GroupBox1.Controls.Add(Me.ApprovedOnDateEdit)
        Me.GroupBox1.Controls.Add(Me.RequireDateDateEdit)
        Me.GroupBox1.Controls.Add(ApprovedOnLabel)
        Me.GroupBox1.Controls.Add(SupplierIDLabel)
        Me.GroupBox1.Controls.Add(Me.ApprovedByTextBox)
        Me.GroupBox1.Controls.Add(Me.SupplierIDGridLookUpEdit)
        Me.GroupBox1.Controls.Add(ApprovedByLabel)
        Me.GroupBox1.Controls.Add(Me.IsApprovedCheckEdit)
        Me.GroupBox1.Controls.Add(IsApprovedLabel)
        Me.GroupBox1.Controls.Add(Me.RemarksTextEdit)
        Me.GroupBox1.Controls.Add(RemarksLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1342, 191)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'TermsConditionMemoEdit
        '
        Me.TermsConditionMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "TermsCondition", True))
        Me.TermsConditionMemoEdit.EditValue = ""
        Me.TermsConditionMemoEdit.Location = New System.Drawing.Point(98, 145)
        Me.TermsConditionMemoEdit.Name = "TermsConditionMemoEdit"
        Me.TermsConditionMemoEdit.Size = New System.Drawing.Size(728, 43)
        Me.TermsConditionMemoEdit.TabIndex = 58
        '
        'AttentionTextEdit
        '
        Me.AttentionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "Attention", True))
        Me.AttentionTextEdit.Location = New System.Drawing.Point(98, 122)
        Me.AttentionTextEdit.Name = "AttentionTextEdit"
        Me.AttentionTextEdit.Size = New System.Drawing.Size(728, 20)
        Me.AttentionTextEdit.TabIndex = 57
        '
        'ReferenceTextEdit
        '
        Me.ReferenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "Reference", True))
        Me.ReferenceTextEdit.Location = New System.Drawing.Point(505, 76)
        Me.ReferenceTextEdit.Name = "ReferenceTextEdit"
        Me.ReferenceTextEdit.Size = New System.Drawing.Size(321, 20)
        Me.ReferenceTextEdit.TabIndex = 56
        '
        'CompleteCheckEdit
        '
        Me.CompleteCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "IsComplete", True))
        Me.CompleteCheckEdit.Location = New System.Drawing.Point(220, 76)
        Me.CompleteCheckEdit.Name = "CompleteCheckEdit"
        Me.CompleteCheckEdit.Properties.Caption = "Pass for Approval"
        Me.CompleteCheckEdit.Size = New System.Drawing.Size(107, 19)
        Me.CompleteCheckEdit.TabIndex = 55
        '
        'AmendmentDateDateEdit
        '
        Me.AmendmentDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "AmendmentDate", True))
        Me.AmendmentDateDateEdit.EditValue = Nothing
        Me.AmendmentDateDateEdit.Location = New System.Drawing.Point(317, 49)
        Me.AmendmentDateDateEdit.Name = "AmendmentDateDateEdit"
        Me.AmendmentDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.AmendmentDateDateEdit.TabIndex = 29
        '
        'AmendmentNoSpinEdit
        '
        Me.AmendmentNoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "AmendmentNo", True))
        Me.AmendmentNoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AmendmentNoSpinEdit.Location = New System.Drawing.Point(317, 23)
        Me.AmendmentNoSpinEdit.Name = "AmendmentNoSpinEdit"
        Me.AmendmentNoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentNoSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.AmendmentNoSpinEdit.TabIndex = 27
        '
        'AccAmendmentHistoryGridControl
        '
        Me.AccAmendmentHistoryGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccAmendmentHistoryGridControl.DataSource = Me.AccAmendmentHistoryBindingSource
        Me.AccAmendmentHistoryGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.AccAmendmentHistoryGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.AccAmendmentHistoryGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.AccAmendmentHistoryGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.AccAmendmentHistoryGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.AccAmendmentHistoryGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.AccAmendmentHistoryGridControl.Location = New System.Drawing.Point(866, 42)
        Me.AccAmendmentHistoryGridControl.MainView = Me.GridView4
        Me.AccAmendmentHistoryGridControl.Name = "AccAmendmentHistoryGridControl"
        Me.AccAmendmentHistoryGridControl.Size = New System.Drawing.Size(469, 143)
        Me.AccAmendmentHistoryGridControl.TabIndex = 25
        Me.AccAmendmentHistoryGridControl.UseEmbeddedNavigator = True
        Me.AccAmendmentHistoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'AccAmendmentHistoryBindingSource
        '
        Me.AccAmendmentHistoryBindingSource.DataMember = "FK_AccAmendmentHistory_AccessoriesWorkOrderSheet"
        Me.AccAmendmentHistoryBindingSource.DataSource = Me.AccessoriesWorkOrderSheetBindingSource
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccAmendmentHistoryId, Me.colAWSId2, Me.colAmendmentNo, Me.colDescription})
        Me.GridView4.GridControl = Me.AccAmendmentHistoryGridControl
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colAccAmendmentHistoryId
        '
        Me.colAccAmendmentHistoryId.FieldName = "AccAmendmentHistoryId"
        Me.colAccAmendmentHistoryId.Name = "colAccAmendmentHistoryId"
        Me.colAccAmendmentHistoryId.OptionsColumn.ReadOnly = True
        '
        'colAWSId2
        '
        Me.colAWSId2.FieldName = "AWSId"
        Me.colAWSId2.Name = "colAWSId2"
        '
        'colAmendmentNo
        '
        Me.colAmendmentNo.FieldName = "AmendmentNo"
        Me.colAmendmentNo.Name = "colAmendmentNo"
        Me.colAmendmentNo.Visible = True
        Me.colAmendmentNo.VisibleIndex = 0
        Me.colAmendmentNo.Width = 101
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 294
        '
        'CauseOfCancelTextEdit
        '
        Me.CauseOfCancelTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "CauseOfCancel", True))
        Me.CauseOfCancelTextEdit.Location = New System.Drawing.Point(505, 51)
        Me.CauseOfCancelTextEdit.Name = "CauseOfCancelTextEdit"
        Me.CauseOfCancelTextEdit.Size = New System.Drawing.Size(321, 20)
        Me.CauseOfCancelTextEdit.TabIndex = 25
        '
        'IsCancelCheckEdit
        '
        Me.IsCancelCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "IsCancel", True))
        Me.IsCancelCheckEdit.Location = New System.Drawing.Point(430, 52)
        Me.IsCancelCheckEdit.Name = "IsCancelCheckEdit"
        Me.IsCancelCheckEdit.Properties.Caption = "Cancel"
        Me.IsCancelCheckEdit.Size = New System.Drawing.Size(72, 19)
        Me.IsCancelCheckEdit.TabIndex = 23
        '
        'AWSNoTextEdit
        '
        Me.AWSNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "AWSNo", True))
        Me.AWSNoTextEdit.Location = New System.Drawing.Point(98, 23)
        Me.AWSNoTextEdit.Name = "AWSNoTextEdit"
        Me.AWSNoTextEdit.Properties.ReadOnly = True
        Me.AWSNoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.AWSNoTextEdit.TabIndex = 3
        '
        'AWSDateDateEdit
        '
        Me.AWSDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "AWSDate", True))
        Me.AWSDateDateEdit.EditValue = New Date(2013, 5, 8, 0, 0, 0, 0)
        Me.AWSDateDateEdit.Location = New System.Drawing.Point(98, 50)
        Me.AWSDateDateEdit.Name = "AWSDateDateEdit"
        Me.AWSDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AWSDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AWSDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.AWSDateDateEdit.TabIndex = 5
        '
        'ApprovedOnDateEdit
        '
        Me.ApprovedOnDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "ApprovedOn", True))
        Me.ApprovedOnDateEdit.EditValue = New Date(2013, 5, 8, 0, 0, 0, 0)
        Me.ApprovedOnDateEdit.Location = New System.Drawing.Point(595, 25)
        Me.ApprovedOnDateEdit.Name = "ApprovedOnDateEdit"
        Me.ApprovedOnDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ApprovedOnDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ApprovedOnDateEdit.Properties.ReadOnly = True
        Me.ApprovedOnDateEdit.Size = New System.Drawing.Size(66, 20)
        Me.ApprovedOnDateEdit.TabIndex = 21
        '
        'RequireDateDateEdit
        '
        Me.RequireDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "RequireDate", True))
        Me.RequireDateDateEdit.EditValue = New Date(2013, 5, 8, 0, 0, 0, 0)
        Me.RequireDateDateEdit.Location = New System.Drawing.Point(98, 76)
        Me.RequireDateDateEdit.Name = "RequireDateDateEdit"
        Me.RequireDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequireDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RequireDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.RequireDateDateEdit.TabIndex = 7
        '
        'ApprovedByTextBox
        '
        Me.ApprovedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccessoriesWorkOrderSheetBindingSource, "ApprovedBy", True))
        Me.ApprovedByTextBox.Location = New System.Drawing.Point(743, 23)
        Me.ApprovedByTextBox.Name = "ApprovedByTextBox"
        Me.ApprovedByTextBox.ReadOnly = True
        Me.ApprovedByTextBox.Size = New System.Drawing.Size(83, 21)
        Me.ApprovedByTextBox.TabIndex = 19
        '
        'SupplierIDGridLookUpEdit
        '
        Me.SupplierIDGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "SupplierID", True))
        Me.SupplierIDGridLookUpEdit.Location = New System.Drawing.Point(98, 98)
        Me.SupplierIDGridLookUpEdit.Name = "SupplierIDGridLookUpEdit"
        Me.SupplierIDGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIDGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIDGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIDGridLookUpEdit.Properties.NullText = ""
        Me.SupplierIDGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierIDGridLookUpEdit.Properties.PopupView = Me.SupplierIDGridLookUpEditView
        Me.SupplierIDGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierIDGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIDGridLookUpEdit.Size = New System.Drawing.Size(319, 20)
        Me.SupplierIDGridLookUpEdit.TabIndex = 9
        '
        'SupplierIDGridLookUpEditView
        '
        Me.SupplierIDGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId2, Me.colSupplierName, Me.colAdd1, Me.colAdd2, Me.colContactPerson, Me.colContactNo, Me.colSupplierType, Me.colSupplierCode, Me.colCity, Me.colCountry})
        Me.SupplierIDGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SupplierIDGridLookUpEditView.Name = "SupplierIDGridLookUpEditView"
        Me.SupplierIDGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SupplierIDGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId2
        '
        Me.colSupplierId2.FieldName = "SupplierId"
        Me.colSupplierId2.Name = "colSupplierId2"
        Me.colSupplierId2.OptionsColumn.ReadOnly = True
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 1
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
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 0
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
        'IsApprovedCheckEdit
        '
        Me.IsApprovedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "IsApproved", True))
        Me.IsApprovedCheckEdit.Location = New System.Drawing.Point(494, 25)
        Me.IsApprovedCheckEdit.Name = "IsApprovedCheckEdit"
        Me.IsApprovedCheckEdit.Properties.Caption = ""
        Me.IsApprovedCheckEdit.Properties.ReadOnly = True
        Me.IsApprovedCheckEdit.Size = New System.Drawing.Size(20, 19)
        Me.IsApprovedCheckEdit.TabIndex = 17
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(505, 99)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(321, 20)
        Me.RemarksTextEdit.TabIndex = 15
        '
        'AccessoriesWorkOrderSheetDetailsBindingSource
        '
        Me.AccessoriesWorkOrderSheetDetailsBindingSource.DataMember = "AccessoriesWorkOrderSheetDetails"
        Me.AccessoriesWorkOrderSheetDetailsBindingSource.DataSource = Me.AWS_DataSet
        '
        'AccessoriesWorkOrderSheetTableAdapter
        '
        Me.AccessoriesWorkOrderSheetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccAmendmentHistoryTableAdapter = Me.AccAmendmentHistoryTableAdapter
        Me.TableAdapterManager.AccessoriesWorkOrderSheetDetailsTableAdapter = Me.AccessoriesWorkOrderSheetDetailsTableAdapter
        Me.TableAdapterManager.AccessoriesWorkOrderSheetTableAdapter = Me.AccessoriesWorkOrderSheetTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.AWS_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AccAmendmentHistoryTableAdapter
        '
        Me.AccAmendmentHistoryTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesWorkOrderSheetDetailsTableAdapter
        '
        Me.AccessoriesWorkOrderSheetDetailsTableAdapter.ClearBeforeFill = True
        '
        'AccessoresBookingDetailsTableAdapter
        '
        Me.AccessoresBookingDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AccessoresBookingDetailsTableAdapter = Me.AccessoresBookingDetailsTableAdapter
        Me.TableAdapterManager1.AccessoriesBookingCareLableTableAdapter = Nothing
        Me.TableAdapterManager1.AccessoriesBookingTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'colAccessoriesId
        '
        Me.colAccessoriesId.FieldName = "AccessoriesId"
        Me.colAccessoriesId.Name = "colAccessoriesId"
        Me.colAccessoriesId.Visible = True
        Me.colAccessoriesId.VisibleIndex = 7
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesListLookupTableAdapter
        '
        Me.AccessoriesListLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'SizeLookupTableAdapter
        '
        Me.SizeLookupTableAdapter.ClearBeforeFill = True
        '
        'DestinationTableAdapter
        '
        Me.DestinationTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'AccBookingLookupTableAdapter
        '
        Me.AccBookingLookupTableAdapter.ClearBeforeFill = True
        '
        'AWSNoLookUpEdit
        '
        Me.AWSNoLookUpEdit.Location = New System.Drawing.Point(327, 11)
        Me.AWSNoLookUpEdit.Name = "AWSNoLookUpEdit"
        Me.AWSNoLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AWSNoLookUpEdit.Properties.DataSource = Me.AWSLookupBindingSource
        Me.AWSNoLookUpEdit.Properties.DisplayMember = "AWSNo"
        Me.AWSNoLookUpEdit.Properties.NullText = ""
        Me.AWSNoLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AWSNoLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.AWSNoLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AWSNoLookUpEdit.Properties.ValueMember = "AWSId"
        Me.AWSNoLookUpEdit.Size = New System.Drawing.Size(226, 20)
        Me.AWSNoLookUpEdit.TabIndex = 54
        '
        'AWSLookupBindingSource
        '
        Me.AWSLookupBindingSource.DataMember = "AWSLookup"
        Me.AWSLookupBindingSource.DataSource = Me.AWSLookupDataSet
        '
        'AWSLookupDataSet
        '
        Me.AWSLookupDataSet.DataSetName = "AWSLookupDataSet"
        Me.AWSLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAWSNo, Me.colAWSDate, Me.colSupplierName2})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colAWSNo
        '
        Me.colAWSNo.FieldName = "AWSNo"
        Me.colAWSNo.Name = "colAWSNo"
        Me.colAWSNo.Visible = True
        Me.colAWSNo.VisibleIndex = 0
        '
        'colAWSDate
        '
        Me.colAWSDate.FieldName = "AWSDate"
        Me.colAWSDate.Name = "colAWSDate"
        Me.colAWSDate.Visible = True
        Me.colAWSDate.VisibleIndex = 1
        '
        'colSupplierName2
        '
        Me.colSupplierName2.FieldName = "SupplierName"
        Me.colSupplierName2.Name = "colSupplierName2"
        Me.colSupplierName2.Visible = True
        Me.colSupplierName2.VisibleIndex = 2
        '
        'CmdAccBOMRefresh
        '
        Me.CmdAccBOMRefresh.ImageOptions.Image = Global.KSoft_Apparel.My.Resources.Resources.Synchronize_icon
        Me.CmdAccBOMRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.CmdAccBOMRefresh.Location = New System.Drawing.Point(729, 10)
        Me.CmdAccBOMRefresh.Name = "CmdAccBOMRefresh"
        Me.CmdAccBOMRefresh.Size = New System.Drawing.Size(81, 23)
        Me.CmdAccBOMRefresh.TabIndex = 56
        Me.CmdAccBOMRefresh.Text = "&Refresh"
        '
        'AWSIdSpinEdit
        '
        Me.AWSIdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesWorkOrderSheetBindingSource, "AWSId", True))
        Me.AWSIdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AWSIdSpinEdit.Location = New System.Drawing.Point(1144, 64)
        Me.AWSIdSpinEdit.Name = "AWSIdSpinEdit"
        Me.AWSIdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AWSIdSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.AWSIdSpinEdit.TabIndex = 26
        '
        'CmdPrint
        '
        Me.CmdPrint.Location = New System.Drawing.Point(644, 10)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(79, 23)
        Me.CmdPrint.TabIndex = 57
        Me.CmdPrint.Text = "&Print"
        '
        'AWSLookupTableAdapter
        '
        Me.AWSLookupTableAdapter.ClearBeforeFill = True
        '
        'AccOrderLookupTableAdapter
        '
        Me.AccOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'AccBOMItemLookupNewTableAdapter
        '
        Me.AccBOMItemLookupNewTableAdapter.ClearBeforeFill = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(3, 39)
        Me.SplitContainerControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SplitContainerControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.SplitContainerControl1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1351, 577)
        Me.SplitContainerControl2.SplitterPosition = 219
        Me.SplitContainerControl2.TabIndex = 59
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'frmAWSNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1355, 621)
        Me.Controls.Add(Me.SplitContainerControl2)
        Me.Controls.Add(Me.CmdShowHide)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.CmdAccBOMRefresh)
        Me.Controls.Add(Me.AWSNoLookUpEdit)
        Me.Controls.Add(Me.CmdEdit)
        Me.Controls.Add(Me.CmdDelete)
        Me.Controls.Add(Me.CmdAWSNoShow)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(AWSIdLabel)
        Me.Controls.Add(Me.AWSIdSpinEdit)
        Me.Name = "frmAWSNew"
        Me.Text = "Accessories  Work Sheet"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GMQtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoresBookingDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoresBookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesBookingNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit4View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit7View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit8View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit5View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit6View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesWorkOrderSheetDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesWorkOrderSheetDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesWorkOrderSheetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMItemLookupNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMItemLookupNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit12View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit10View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit9View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit11View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TermsConditionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAmendmentHistoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAmendmentHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CauseOfCancelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsCancelCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedOnDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedOnDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequireDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequireDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIDGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIDGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsApprovedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesWorkOrderSheetDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSNoLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AWSIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdAWSNoShow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdAccBOMNoShow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents cmdInvert As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AllCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CmdGetSelectedData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AccBOMNoLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AWS_DataSet As KSoft_Apparel.AWS_DataSet
    Friend WithEvents AccessoriesWorkOrderSheetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesWorkOrderSheetTableAdapter As KSoft_Apparel.AWS_DataSetTableAdapters.AccessoriesWorkOrderSheetTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.AWS_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SupplierIDGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AWSNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AWSDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RequireDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SupplierIDGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsApprovedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ApprovedByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApprovedOnDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents IsCancelCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CauseOfCancelTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AccessoriesWorkOrderSheetDetailsTableAdapter As KSoft_Apparel.AWS_DataSetTableAdapters.AccessoriesWorkOrderSheetDetailsTableAdapter
    Friend WithEvents AccessoriesWorkOrderSheetDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesBookingNewDataSet As KSoft_Apparel.AccessoriesBookingNewDataSet
    Friend WithEvents AccessoresBookingDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoresBookingDetailsTableAdapter As KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoresBookingDetailsTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccessoresBookingDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccessoriesBookingId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsumption As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsumptionUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBookingUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBookingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsumptionForPcs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWastagePercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSLNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPackType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemStyle1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccBOMLookUpDataSet As KSoft_Apparel.AccBOMLookUpDataSet
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AccessoriesListDataSet As KSoft_Apparel.AccessoriesListDataSet
    Friend WithEvents AccessoriesListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesListLookupTableAdapter As KSoft_Apparel.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit4View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents SizeLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeDataSet As KSoft_Apparel.SizeDataSet
    Friend WithEvents RepositoryItemGridLookUpEdit5View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SizeLookupTableAdapter As KSoft_Apparel.SizeDataSetTableAdapters.SizeLookupTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit6View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DestinationDataSet As KSoft_Apparel.DestinationDataSet
    Friend WithEvents DestinationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DestinationTableAdapter As KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit7View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit8View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemStyle2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSlNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccBookingLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccBookingLookupTableAdapter As KSoft_Apparel.AccBOMLookUpDataSetTableAdapters.AccBookingLookupTableAdapter
    Friend WithEvents AWSNoLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AccessoriesWorkOrderSheetDetailsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesWorkOrderSheetDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccessoriesBookingDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrencyId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CmdAccBOMRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AWSIdSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RepositoryItemGridLookUpEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit9View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccessoriesName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesBookingDetailsId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit10View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit11View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccessoriesName3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesBookingDetailsId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccAmendmentHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccAmendmentHistoryTableAdapter As KSoft_Apparel.AWS_DataSetTableAdapters.AccAmendmentHistoryTableAdapter
    Friend WithEvents AccAmendmentHistoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccAmendmentHistoryId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAWSId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AWSLookupDataSet As KSoft_Apparel.AWSLookupDataSet
    Friend WithEvents AWSLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AWSLookupTableAdapter As KSoft_Apparel.AWSLookupDataSetTableAdapters.AWSLookupTableAdapter
    Friend WithEvents ItemNameGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit12View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccessoriesBookingDetailsId21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemStyleGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AmendmentDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AmendmentNoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CmdShowHide As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AccOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccOrderLookupTableAdapter As KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccOrderLookupTableAdapter
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Apparel.ItemListLookupDataSet
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents AccBOMItemLookupNewDataSet As KSoft_Apparel.AccBOMItemLookupNewDataSet
    Friend WithEvents AccBOMItemLookupNewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccBOMItemLookupNewTableAdapter As KSoft_Apparel.AccBOMItemLookupNewDataSetTableAdapters.AccBOMItemLookupNewTableAdapter
    Friend WithEvents colItemName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompleteCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colAWSNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAWSDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdditionalCharge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdditionalChargeFor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMQtyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colPicture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReferenceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TermsConditionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents AttentionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents colAdditionalQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabrication As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKimballNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSKU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColorCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BookingDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
