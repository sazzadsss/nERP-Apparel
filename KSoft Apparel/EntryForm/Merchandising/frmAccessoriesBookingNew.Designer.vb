<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessoriesBookingNew
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
        Dim BookingDateLabel As System.Windows.Forms.Label
        Dim AmendmentNoLabel As System.Windows.Forms.Label
        Dim AmendmentDateLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim OrderIdLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim GMQtyLabel As System.Windows.Forms.Label
        Dim ReferenceLabel As System.Windows.Forms.Label
        Dim RequireDateLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBookingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.AccessoriesBookingNewDataSet = New KSoft_Apparel.AccessoriesBookingNewDataSet()
        Me.AccessoriesBookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesBookingTableAdapter = New KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoriesBookingTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.TableAdapterManager()
        Me.AccessoresBookingDetailsTableAdapter = New KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoresBookingDetailsTableAdapter()
        Me.AccessoriesBookingCareLableTableAdapter = New KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoriesBookingCareLableTableAdapter()
        Me.BookingDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AmendmentNoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AmendmentDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ProgramNoLookupByDivUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.AccessoriesBookingSizeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoresBookingDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.ItemStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemStyleDataSet = New KSoft_Apparel.ItemStyleDataSet()
        Me.SizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataSet = New KSoft_Apparel.SizeDataSet()
        Me.DestinationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DestinationDataSet = New KSoft_Apparel.DestinationDataSet()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Apparel.ItemListLookupDataSet()
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter()
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SelectAllSizeLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SelectAllColorLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GenByStyleButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WPercSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AccLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PackCheckListBox = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.PackTypeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PackTypeByOrderDataSet = New KSoft_Apparel.PackTypeByOrderDataSet()
        Me.DestinationCheckedListBox = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.SizeCheckListBox = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ColorCheckListBox = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.ConPCSSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UnitIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ConSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PackCheckBox = New System.Windows.Forms.CheckBox()
        Me.DestinationCheckBox = New System.Windows.Forms.CheckBox()
        Me.SizeCheckBox = New System.Windows.Forms.CheckBox()
        Me.ColorCheckBox = New System.Windows.Forms.CheckBox()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.CostingCheckBox = New System.Windows.Forms.CheckBox()
        Me.AccNameGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ItemListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SelectSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.AccessoresBookingDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccessoriesBookingDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesBookingId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsumption = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsumptionUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBookingUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BookingUnitGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemStyle1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemStyleGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemStyle3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsumptionForPcs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWastagePercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSLNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SLNoItemTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colSizeId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemIdGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSizeId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSlNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinationId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DestinationGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestinationId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinationCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestinationName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPackType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PackTypeItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdditionalQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColorCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSKU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompletedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompleteOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsApproved = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPictureEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colBuyerDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabrication = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKimballNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenerationType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccessoriesItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccessoriesId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemStyle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgramSearchGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.AccBookingLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccBOMLookUpDataSet = New KSoft_Apparel.AccBOMLookUpDataSet()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccOrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.AccessoriesBookingTableAdapter1 = New KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoriesBookingTableAdapter()
        Me.SizeLookupTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeLookupTableAdapter()
        Me.StyleLabel = New System.Windows.Forms.Label()
        Me.BuyerLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AmendmentDetailsMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.AccessoriesBookingAmndDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.AccessoriesBookingAmndDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAmndNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmndButton = New System.Windows.Forms.Button()
        Me.RequireDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ReferenceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GMQtyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsCompleteCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RecalculateButton = New System.Windows.Forms.Button()
        Me.DestinationTableAdapter = New KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter()
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemStyleTableAdapter = New KSoft_Apparel.ItemStyleDataSetTableAdapters.ItemStyleTableAdapter()
        Me.AccOrderLookupTableAdapter = New KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccOrderLookupTableAdapter()
        Me.AccBookingLookupTableAdapter = New KSoft_Apparel.AccBOMLookUpDataSetTableAdapters.AccBookingLookupTableAdapter()
        Me.ProgramNoLookupByDivUserTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.ProgramNoLookupByDivUserTableAdapter()
        Me.PackTypeLookupTableAdapter = New KSoft_Apparel.PackTypeByOrderDataSetTableAdapters.PackTypeLookupTableAdapter()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.AccessoriesBookingCareLableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.AccessoriesBookingCareLableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCareLable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesBookingCareLableId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesBookingId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSLNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdditionalIns = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CareLableSaveButton = New System.Windows.Forms.Button()
        Me.CareLabelGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CareLabelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CareLabelDataSet = New KSoft_Apparel.CareLabelDataSet()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCareLabel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CareLabelTableAdapter = New KSoft_Apparel.CareLabelDataSetTableAdapters.CareLabelTableAdapter()
        Me.AccessoriesBookingAmndDetailsTableAdapter = New KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoriesBookingAmndDetailsTableAdapter()
        BookingDateLabel = New System.Windows.Forms.Label()
        AmendmentNoLabel = New System.Windows.Forms.Label()
        AmendmentDateLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        OrderIdLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        GMQtyLabel = New System.Windows.Forms.Label()
        ReferenceLabel = New System.Windows.Forms.Label()
        RequireDateLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesBookingNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesBookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoLookupByDivUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesBookingSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoresBookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.WPercSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackCheckListBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackTypeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackTypeByOrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationCheckedListBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeCheckListBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCheckListBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConPCSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccNameGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoresBookingDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingUnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemStyleGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SLNoItemTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemIdGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackTypeItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramSearchGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AmendmentDetailsMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesBookingAmndDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesBookingAmndDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequireDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequireDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMQtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.AccessoriesBookingCareLableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesBookingCareLableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CareLabelGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CareLabelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CareLabelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookingDateLabel
        '
        BookingDateLabel.AutoSize = True
        BookingDateLabel.Location = New System.Drawing.Point(34, 51)
        BookingDateLabel.Name = "BookingDateLabel"
        BookingDateLabel.Size = New System.Drawing.Size(75, 13)
        BookingDateLabel.TabIndex = 5
        BookingDateLabel.Text = "Booking Date:"
        '
        'AmendmentNoLabel
        '
        AmendmentNoLabel.AutoSize = True
        AmendmentNoLabel.Location = New System.Drawing.Point(252, 25)
        AmendmentNoLabel.Name = "AmendmentNoLabel"
        AmendmentNoLabel.Size = New System.Drawing.Size(83, 13)
        AmendmentNoLabel.TabIndex = 7
        AmendmentNoLabel.Text = "Amendment No:"
        '
        'AmendmentDateLabel
        '
        AmendmentDateLabel.AutoSize = True
        AmendmentDateLabel.Location = New System.Drawing.Point(252, 51)
        AmendmentDateLabel.Name = "AmendmentDateLabel"
        AmendmentDateLabel.Size = New System.Drawing.Size(92, 13)
        AmendmentDateLabel.TabIndex = 9
        AmendmentDateLabel.Text = "Amendment Date:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(34, 127)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 11
        RemarksLabel.Text = "Remarks:"
        '
        'OrderIdLabel1
        '
        OrderIdLabel1.AutoSize = True
        OrderIdLabel1.Location = New System.Drawing.Point(34, 25)
        OrderIdLabel1.Name = "OrderIdLabel1"
        OrderIdLabel1.Size = New System.Drawing.Size(66, 13)
        OrderIdLabel1.TabIndex = 13
        OrderIdLabel1.Text = "Program No:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(535, 53)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(40, 13)
        Label1.TabIndex = 21
        Label1.Text = "Buyer :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(535, 24)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(36, 13)
        Label2.TabIndex = 22
        Label2.Text = "Style :"
        '
        'GMQtyLabel
        '
        GMQtyLabel.AutoSize = True
        GMQtyLabel.Location = New System.Drawing.Point(535, 76)
        GMQtyLabel.Name = "GMQtyLabel"
        GMQtyLabel.Size = New System.Drawing.Size(49, 13)
        GMQtyLabel.TabIndex = 23
        GMQtyLabel.Text = "G.M Qty:"
        '
        'ReferenceLabel
        '
        ReferenceLabel.AutoSize = True
        ReferenceLabel.Location = New System.Drawing.Point(34, 101)
        ReferenceLabel.Name = "ReferenceLabel"
        ReferenceLabel.Size = New System.Drawing.Size(60, 13)
        ReferenceLabel.TabIndex = 24
        ReferenceLabel.Text = "Reference:"
        '
        'RequireDateLabel
        '
        RequireDateLabel.AutoSize = True
        RequireDateLabel.Location = New System.Drawing.Point(34, 77)
        RequireDateLabel.Name = "RequireDateLabel"
        RequireDateLabel.Size = New System.Drawing.Size(73, 13)
        RequireDateLabel.TabIndex = 25
        RequireDateLabel.Text = "Require Date:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(252, 79)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(72, 13)
        Label7.TabIndex = 9
        Label7.Text = "Amnd Details:"
        '
        'colUnitPrice
        '
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 26
        Me.colUnitPrice.Width = 74
        '
        'colTotalPrice
        '
        Me.colTotalPrice.DisplayFormat.FormatString = " ##,##.000000"
        Me.colTotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTotalPrice.FieldName = "TotalPrice"
        Me.colTotalPrice.Name = "colTotalPrice"
        Me.colTotalPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTotalPrice.Visible = True
        Me.colTotalPrice.VisibleIndex = 27
        '
        'colBookingQuantity
        '
        Me.colBookingQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colBookingQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colBookingQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colBookingQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBookingQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBookingQuantity.FieldName = "BookingQuantity"
        Me.colBookingQuantity.Name = "colBookingQuantity"
        Me.colBookingQuantity.OptionsColumn.AllowEdit = False
        Me.colBookingQuantity.OptionsColumn.ReadOnly = True
        Me.colBookingQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBookingQuantity.Visible = True
        Me.colBookingQuantity.VisibleIndex = 19
        Me.colBookingQuantity.Width = 90
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        Me.RepositoryItemPictureEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'AccessoriesBookingNewDataSet
        '
        Me.AccessoriesBookingNewDataSet.DataSetName = "AccessoriesBookingNewDataSet"
        Me.AccessoriesBookingNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccessoriesBookingBindingSource
        '
        Me.AccessoriesBookingBindingSource.DataMember = "AccessoriesBooking"
        Me.AccessoriesBookingBindingSource.DataSource = Me.AccessoriesBookingNewDataSet
        '
        'AccessoriesBookingTableAdapter
        '
        Me.AccessoriesBookingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessoresBookingDetailsTableAdapter = Me.AccessoresBookingDetailsTableAdapter
        Me.TableAdapterManager.AccessoriesBookingAmndDetailsTableAdapter = Me.AccessoriesBookingAmndDetailsTableAdapter
        Me.TableAdapterManager.AccessoriesBookingCareLableTableAdapter = Me.AccessoriesBookingCareLableTableAdapter
        Me.TableAdapterManager.AccessoriesBookingTableAdapter = Me.AccessoriesBookingTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AccessoresBookingDetailsTableAdapter
        '
        Me.AccessoresBookingDetailsTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesBookingCareLableTableAdapter
        '
        Me.AccessoriesBookingCareLableTableAdapter.ClearBeforeFill = True
        '
        'BookingDateDateEdit
        '
        Me.BookingDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesBookingBindingSource, "BookingDate", True))
        Me.BookingDateDateEdit.EditValue = Nothing
        Me.BookingDateDateEdit.Location = New System.Drawing.Point(115, 48)
        Me.BookingDateDateEdit.Name = "BookingDateDateEdit"
        Me.BookingDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BookingDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.BookingDateDateEdit.Size = New System.Drawing.Size(126, 20)
        Me.BookingDateDateEdit.TabIndex = 6
        '
        'AmendmentNoSpinEdit
        '
        Me.AmendmentNoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesBookingBindingSource, "AmendmentNo", True))
        Me.AmendmentNoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AmendmentNoSpinEdit.Location = New System.Drawing.Point(350, 20)
        Me.AmendmentNoSpinEdit.Name = "AmendmentNoSpinEdit"
        Me.AmendmentNoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentNoSpinEdit.Properties.ReadOnly = True
        Me.AmendmentNoSpinEdit.Size = New System.Drawing.Size(86, 20)
        Me.AmendmentNoSpinEdit.TabIndex = 8
        '
        'AmendmentDateDateEdit
        '
        Me.AmendmentDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesBookingBindingSource, "AmendmentDate", True))
        Me.AmendmentDateDateEdit.EditValue = Nothing
        Me.AmendmentDateDateEdit.Location = New System.Drawing.Point(350, 48)
        Me.AmendmentDateDateEdit.Name = "AmendmentDateDateEdit"
        Me.AmendmentDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentDateDateEdit.Properties.ReadOnly = True
        Me.AmendmentDateDateEdit.Size = New System.Drawing.Size(168, 20)
        Me.AmendmentDateDateEdit.TabIndex = 10
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesBookingBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(115, 124)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(403, 20)
        Me.RemarksTextEdit.TabIndex = 12
        '
        'OrderIdGridLookUpEditView
        '
        Me.OrderIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo})
        Me.OrderIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.OrderIdGridLookUpEditView.Name = "OrderIdGridLookUpEditView"
        Me.OrderIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.OrderIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesBookingBindingSource, "OrderId", True))
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(115, 20)
        Me.OrderIdGridLookUpEdit.Name = "OrderIdGridLookUpEdit"
        Me.OrderIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderIdGridLookUpEdit.Properties.DataSource = Me.ProgramNoLookupByDivUserBindingSource
        Me.OrderIdGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.OrderIdGridLookUpEdit.Properties.NullText = ""
        Me.OrderIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderIdGridLookUpEdit.Properties.PopupView = Me.OrderIdGridLookUpEditView
        Me.OrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(126, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 14
        '
        'ProgramNoLookupByDivUserBindingSource
        '
        Me.ProgramNoLookupByDivUserBindingSource.DataMember = "ProgramNoLookupByDivUser"
        Me.ProgramNoLookupByDivUserBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.EnforceConstraints = False
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccessoresBookingDetailsBindingSource
        '
        Me.AccessoresBookingDetailsBindingSource.DataMember = "AccessoriesBooking_AccessoresBookingDetails"
        Me.AccessoresBookingDetailsBindingSource.DataSource = Me.AccessoriesBookingBindingSource
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
        'ItemStyleBindingSource
        '
        Me.ItemStyleBindingSource.DataMember = "ItemStyle"
        Me.ItemStyleBindingSource.DataSource = Me.ItemStyleDataSet
        '
        'ItemStyleDataSet
        '
        Me.ItemStyleDataSet.DataSetName = "ItemStyleDataSet"
        Me.ItemStyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.SelectAllSizeLinkLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SelectAllColorLinkLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GenByStyleButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.WPercSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccLinkLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PackCheckListBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DestinationCheckedListBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SizeCheckListBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ColorCheckListBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConPCSSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UnitIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ConSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PackCheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DestinationCheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SizeCheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ColorCheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GenerateButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CostingCheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccNameGridLookUpEdit)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SimpleButton1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SelectSimpleButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AccessoresBookingDetailsGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1339, 496)
        Me.SplitContainer1.SplitterDistance = 143
        Me.SplitContainer1.TabIndex = 17
        Me.SplitContainer1.Tag = "NR"
        '
        'SelectAllSizeLinkLabel
        '
        Me.SelectAllSizeLinkLabel.AutoSize = True
        Me.SelectAllSizeLinkLabel.Location = New System.Drawing.Point(386, 39)
        Me.SelectAllSizeLinkLabel.Name = "SelectAllSizeLinkLabel"
        Me.SelectAllSizeLinkLabel.Size = New System.Drawing.Size(62, 13)
        Me.SelectAllSizeLinkLabel.TabIndex = 34
        Me.SelectAllSizeLinkLabel.TabStop = True
        Me.SelectAllSizeLinkLabel.Text = "Deselect All"
        '
        'SelectAllColorLinkLabel
        '
        Me.SelectAllColorLinkLabel.AutoSize = True
        Me.SelectAllColorLinkLabel.Location = New System.Drawing.Point(257, 38)
        Me.SelectAllColorLinkLabel.Name = "SelectAllColorLinkLabel"
        Me.SelectAllColorLinkLabel.Size = New System.Drawing.Size(62, 13)
        Me.SelectAllColorLinkLabel.TabIndex = 33
        Me.SelectAllColorLinkLabel.TabStop = True
        Me.SelectAllColorLinkLabel.Text = "Deselect All"
        '
        'GenByStyleButton
        '
        Me.GenByStyleButton.Location = New System.Drawing.Point(966, 57)
        Me.GenByStyleButton.Name = "GenByStyleButton"
        Me.GenByStyleButton.Size = New System.Drawing.Size(107, 79)
        Me.GenByStyleButton.TabIndex = 19
        Me.GenByStyleButton.Text = "Generate by Style"
        Me.GenByStyleButton.UseVisualStyleBackColor = True
        Me.GenByStyleButton.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Tag = "NR"
        Me.Label3.Text = "W%"
        '
        'WPercSpinEdit
        '
        Me.WPercSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.WPercSpinEdit.Location = New System.Drawing.Point(105, 116)
        Me.WPercSpinEdit.Name = "WPercSpinEdit"
        Me.WPercSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.WPercSpinEdit.Size = New System.Drawing.Size(74, 20)
        Me.WPercSpinEdit.TabIndex = 31
        '
        'AccLinkLabel
        '
        Me.AccLinkLabel.AutoSize = True
        Me.AccLinkLabel.Location = New System.Drawing.Point(16, 14)
        Me.AccLinkLabel.Name = "AccLinkLabel"
        Me.AccLinkLabel.Size = New System.Drawing.Size(54, 13)
        Me.AccLinkLabel.TabIndex = 30
        Me.AccLinkLabel.TabStop = True
        Me.AccLinkLabel.Text = "Acc Name"
        '
        'PackCheckListBox
        '
        Me.PackCheckListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PackCheckListBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.PackCheckListBox.DataSource = Me.PackTypeLookupBindingSource
        Me.PackCheckListBox.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Normal"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Ratio")})
        Me.PackCheckListBox.Location = New System.Drawing.Point(592, 57)
        Me.PackCheckListBox.Name = "PackCheckListBox"
        Me.PackCheckListBox.Size = New System.Drawing.Size(120, 79)
        Me.PackCheckListBox.TabIndex = 29
        Me.PackCheckListBox.ValueMember = "PackType"
        '
        'PackTypeLookupBindingSource
        '
        Me.PackTypeLookupBindingSource.DataMember = "PackTypeLookup"
        Me.PackTypeLookupBindingSource.DataSource = Me.PackTypeByOrderDataSet
        '
        'PackTypeByOrderDataSet
        '
        Me.PackTypeByOrderDataSet.DataSetName = "PackTypeByOrderDataSet"
        Me.PackTypeByOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DestinationCheckedListBox
        '
        Me.DestinationCheckedListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DestinationCheckedListBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.DestinationCheckedListBox.DataSource = Me.DestinationBindingSource
        Me.DestinationCheckedListBox.DisplayMember = "DestinationCode"
        Me.DestinationCheckedListBox.Location = New System.Drawing.Point(460, 57)
        Me.DestinationCheckedListBox.Name = "DestinationCheckedListBox"
        Me.DestinationCheckedListBox.Size = New System.Drawing.Size(120, 79)
        Me.DestinationCheckedListBox.TabIndex = 28
        Me.DestinationCheckedListBox.ValueMember = "DestinationId"
        '
        'SizeCheckListBox
        '
        Me.SizeCheckListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SizeCheckListBox.DataSource = Me.SizeLookupBindingSource
        Me.SizeCheckListBox.DisplayMember = "SizeCode"
        Me.SizeCheckListBox.Location = New System.Drawing.Point(329, 57)
        Me.SizeCheckListBox.Name = "SizeCheckListBox"
        Me.SizeCheckListBox.Size = New System.Drawing.Size(120, 79)
        Me.SizeCheckListBox.TabIndex = 27
        Me.SizeCheckListBox.ValueMember = "SizeId"
        '
        'ColorCheckListBox
        '
        Me.ColorCheckListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ColorCheckListBox.DataSource = Me.OrderFabricColorBindingSource
        Me.ColorCheckListBox.DisplayMember = "FabricColorName"
        Me.ColorCheckListBox.Location = New System.Drawing.Point(199, 57)
        Me.ColorCheckListBox.Name = "ColorCheckListBox"
        Me.ColorCheckListBox.Size = New System.Drawing.Size(120, 79)
        Me.ColorCheckListBox.TabIndex = 26
        Me.ColorCheckListBox.ValueMember = "FabricColorId"
        '
        'ConPCSSpinEdit
        '
        Me.ConPCSSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ConPCSSpinEdit.Location = New System.Drawing.Point(105, 90)
        Me.ConPCSSpinEdit.Name = "ConPCSSpinEdit"
        Me.ConPCSSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ConPCSSpinEdit.Size = New System.Drawing.Size(74, 20)
        Me.ConPCSSpinEdit.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Tag = "NR"
        Me.Label6.Text = "For GMT (Pcs)"
        '
        'UnitIdGridLookUpEdit
        '
        Me.UnitIdGridLookUpEdit.Location = New System.Drawing.Point(105, 65)
        Me.UnitIdGridLookUpEdit.Name = "UnitIdGridLookUpEdit"
        Me.UnitIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitIdGridLookUpEdit.Properties.DataSource = Me.UnitBindingSource
        Me.UnitIdGridLookUpEdit.Properties.DisplayMember = "UnitCode"
        Me.UnitIdGridLookUpEdit.Properties.NullText = ""
        Me.UnitIdGridLookUpEdit.Properties.PopupView = Me.GridView10
        Me.UnitIdGridLookUpEdit.Properties.ValueMember = "UnitId"
        Me.UnitIdGridLookUpEdit.Size = New System.Drawing.Size(74, 20)
        Me.UnitIdGridLookUpEdit.TabIndex = 23
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId1, Me.colUnitCode1, Me.colUnitName1})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colUnitId1
        '
        Me.colUnitId1.FieldName = "UnitId"
        Me.colUnitId1.Name = "colUnitId1"
        Me.colUnitId1.OptionsColumn.ReadOnly = True
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
        Me.colUnitName1.Visible = True
        Me.colUnitName1.VisibleIndex = 1
        '
        'ConSpinEdit
        '
        Me.ConSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ConSpinEdit.Location = New System.Drawing.Point(105, 39)
        Me.ConSpinEdit.Name = "ConSpinEdit"
        Me.ConSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ConSpinEdit.Properties.DisplayFormat.FormatString = "n5"
        Me.ConSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ConSpinEdit.Properties.EditFormat.FormatString = "n5"
        Me.ConSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ConSpinEdit.Size = New System.Drawing.Size(74, 20)
        Me.ConSpinEdit.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Tag = "NR"
        Me.Label5.Text = "Con Unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Tag = "NR"
        Me.Label4.Text = "Consumption"
        '
        'PackCheckBox
        '
        Me.PackCheckBox.AutoSize = True
        Me.PackCheckBox.Location = New System.Drawing.Point(595, 38)
        Me.PackCheckBox.Name = "PackCheckBox"
        Me.PackCheckBox.Size = New System.Drawing.Size(48, 17)
        Me.PackCheckBox.TabIndex = 18
        Me.PackCheckBox.Tag = "NR"
        Me.PackCheckBox.Text = "Pack"
        Me.PackCheckBox.UseVisualStyleBackColor = True
        '
        'DestinationCheckBox
        '
        Me.DestinationCheckBox.AutoSize = True
        Me.DestinationCheckBox.Location = New System.Drawing.Point(463, 38)
        Me.DestinationCheckBox.Name = "DestinationCheckBox"
        Me.DestinationCheckBox.Size = New System.Drawing.Size(80, 17)
        Me.DestinationCheckBox.TabIndex = 17
        Me.DestinationCheckBox.Tag = "NR"
        Me.DestinationCheckBox.Text = "Destination"
        Me.DestinationCheckBox.UseVisualStyleBackColor = True
        '
        'SizeCheckBox
        '
        Me.SizeCheckBox.AutoSize = True
        Me.SizeCheckBox.Location = New System.Drawing.Point(333, 38)
        Me.SizeCheckBox.Name = "SizeCheckBox"
        Me.SizeCheckBox.Size = New System.Drawing.Size(45, 17)
        Me.SizeCheckBox.TabIndex = 16
        Me.SizeCheckBox.Tag = "NR"
        Me.SizeCheckBox.Text = "Size"
        Me.SizeCheckBox.UseVisualStyleBackColor = True
        '
        'ColorCheckBox
        '
        Me.ColorCheckBox.AutoSize = True
        Me.ColorCheckBox.Location = New System.Drawing.Point(203, 38)
        Me.ColorCheckBox.Name = "ColorCheckBox"
        Me.ColorCheckBox.Size = New System.Drawing.Size(51, 17)
        Me.ColorCheckBox.TabIndex = 15
        Me.ColorCheckBox.Tag = "NR"
        Me.ColorCheckBox.Text = "Color"
        Me.ColorCheckBox.UseVisualStyleBackColor = True
        '
        'GenerateButton
        '
        Me.GenerateButton.Enabled = False
        Me.GenerateButton.Location = New System.Drawing.Point(727, 57)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(113, 79)
        Me.GenerateButton.TabIndex = 7
        Me.GenerateButton.Text = "Generate by Item"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'CostingCheckBox
        '
        Me.CostingCheckBox.AutoSize = True
        Me.CostingCheckBox.Location = New System.Drawing.Point(727, 37)
        Me.CostingCheckBox.Name = "CostingCheckBox"
        Me.CostingCheckBox.Size = New System.Drawing.Size(129, 17)
        Me.CostingCheckBox.TabIndex = 5
        Me.CostingCheckBox.Tag = "NR"
        Me.CostingCheckBox.Text = "Exclude From Costing"
        Me.CostingCheckBox.UseVisualStyleBackColor = True
        '
        'AccNameGridLookUpEdit
        '
        Me.AccNameGridLookUpEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccNameGridLookUpEdit.Location = New System.Drawing.Point(105, 11)
        Me.AccNameGridLookUpEdit.Name = "AccNameGridLookUpEdit"
        Me.AccNameGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccNameGridLookUpEdit.Properties.DataSource = Me.ItemListBindingSource1
        Me.AccNameGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.AccNameGridLookUpEdit.Properties.ImmediatePopup = True
        Me.AccNameGridLookUpEdit.Properties.NullText = ""
        Me.AccNameGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AccNameGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.AccNameGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AccNameGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.AccNameGridLookUpEdit.Size = New System.Drawing.Size(956, 20)
        Me.AccNameGridLookUpEdit.TabIndex = 0
        Me.AccNameGridLookUpEdit.Tag = "NR"
        '
        'ItemListBindingSource1
        '
        Me.ItemListBindingSource1.DataMember = "ItemList"
        Me.ItemListBindingSource1.DataSource = Me.ItemListLookupDataSet
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName1, Me.colUnitCode2})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colItemName1
        '
        Me.colItemName1.FieldName = "ItemName"
        Me.colItemName1.Name = "colItemName1"
        Me.colItemName1.Visible = True
        Me.colItemName1.VisibleIndex = 0
        '
        'colUnitCode2
        '
        Me.colUnitCode2.FieldName = "UnitCode"
        Me.colUnitCode2.Name = "colUnitCode2"
        Me.colUnitCode2.Visible = True
        Me.colUnitCode2.VisibleIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(100, 6)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(118, 23)
        Me.SimpleButton1.TabIndex = 65
        Me.SimpleButton1.Text = "Pass for Approval"
        '
        'SelectSimpleButton
        '
        Me.SelectSimpleButton.Location = New System.Drawing.Point(12, 6)
        Me.SelectSimpleButton.Name = "SelectSimpleButton"
        Me.SelectSimpleButton.Size = New System.Drawing.Size(81, 23)
        Me.SelectSimpleButton.TabIndex = 64
        Me.SelectSimpleButton.Text = "&Select All"
        '
        'AccessoresBookingDetailsGridControl
        '
        Me.AccessoresBookingDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessoresBookingDetailsGridControl.DataSource = Me.AccessoresBookingDetailsBindingSource
        Me.AccessoresBookingDetailsGridControl.Location = New System.Drawing.Point(0, 35)
        Me.AccessoresBookingDetailsGridControl.MainView = Me.GridView1
        Me.AccessoresBookingDetailsGridControl.Name = "AccessoresBookingDetailsGridControl"
        Me.AccessoresBookingDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.AccessoriesItemGridLookUpEdit, Me.ColorGridLookUpEdit, Me.UnitGridLookUpEdit, Me.SupplierGridLookUpEdit, Me.ItemStyleGridLookUpEdit, Me.BookingUnitGridLookUpEdit, Me.ItemIdGridLookUpEdit, Me.PackTypeItemComboBox, Me.DestinationGridLookUpEdit, Me.ItemGridLookUpEdit, Me.RepositoryItemPictureEdit3, Me.SLNoItemTextEdit})
        Me.AccessoresBookingDetailsGridControl.Size = New System.Drawing.Size(1339, 314)
        Me.AccessoresBookingDetailsGridControl.TabIndex = 14
        Me.AccessoresBookingDetailsGridControl.UseEmbeddedNavigator = True
        Me.AccessoresBookingDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccessoriesBookingDetailsId, Me.colAccessoriesBookingId, Me.colFabricColorId, Me.colConsumption, Me.colConsumptionUnitId, Me.colBookingUnitId, Me.colBookingQuantity, Me.colSupplierId, Me.colRemarks, Me.colItemStyle1, Me.colConsumptionForPcs, Me.colWastagePercentage, Me.colSLNo, Me.colUnitPrice, Me.colTotalPrice, Me.colSizeId1, Me.colDestinationId, Me.colPackType, Me.colOrderQuantity, Me.colItemId, Me.colAdditionalQuantity, Me.colColorCode, Me.colSKU, Me.colApprovedBy, Me.colApprovedOn, Me.colCompletedBy, Me.colCompleteOn, Me.colIsApproved, Me.colIsComplete, Me.colPicture, Me.colBuyerDepartment, Me.colFabrication, Me.colItemCode, Me.colKimballNo, Me.colOrderNO, Me.colPO, Me.colGenerationType, Me.colIsSelected})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(1150, 402, 216, 323)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colUnitPrice
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = 0
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colTotalPrice
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = 0
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.colBookingQuantity
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = 0
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GridView1.GridControl = Me.AccessoresBookingDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.AllowZoomDetail = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsDetail.SmartDetailExpand = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 40
        '
        'colAccessoriesBookingDetailsId
        '
        Me.colAccessoriesBookingDetailsId.AppearanceHeader.Options.UseTextOptions = True
        Me.colAccessoriesBookingDetailsId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAccessoriesBookingDetailsId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAccessoriesBookingDetailsId.FieldName = "AccessoriesBookingDetailsId"
        Me.colAccessoriesBookingDetailsId.Name = "colAccessoriesBookingDetailsId"
        Me.colAccessoriesBookingDetailsId.OptionsColumn.ReadOnly = True
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
        Me.colFabricColorId.ColumnEdit = Me.ColorGridLookUpEdit
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 6
        Me.colFabricColorId.Width = 144
        '
        'ColorGridLookUpEdit
        '
        Me.ColorGridLookUpEdit.AutoHeight = False
        Me.ColorGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorGridLookUpEdit.DataSource = Me.OrderFabricColorBindingSource
        Me.ColorGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.ColorGridLookUpEdit.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.ColorGridLookUpEdit.Name = "ColorGridLookUpEdit"
        Me.ColorGridLookUpEdit.NullText = ""
        Me.ColorGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ColorGridLookUpEdit.PopupView = Me.GridView2
        Me.ColorGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ColorGridLookUpEdit.ValueMember = "FabricColorId"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
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
        'colConsumptionUnitId
        '
        Me.colConsumptionUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colConsumptionUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConsumptionUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConsumptionUnitId.Caption = "Con Unit"
        Me.colConsumptionUnitId.ColumnEdit = Me.UnitGridLookUpEdit
        Me.colConsumptionUnitId.FieldName = "ConsumptionUnitId"
        Me.colConsumptionUnitId.Name = "colConsumptionUnitId"
        Me.colConsumptionUnitId.Visible = True
        Me.colConsumptionUnitId.VisibleIndex = 23
        Me.colConsumptionUnitId.Width = 42
        '
        'UnitGridLookUpEdit
        '
        Me.UnitGridLookUpEdit.AutoHeight = False
        Me.UnitGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitGridLookUpEdit.DisplayMember = "UnitCode"
        Me.UnitGridLookUpEdit.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.UnitGridLookUpEdit.Name = "UnitGridLookUpEdit"
        Me.UnitGridLookUpEdit.NullText = ""
        Me.UnitGridLookUpEdit.PopupView = Me.GridView4
        Me.UnitGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UnitGridLookUpEdit.ValueMember = "UnitId"
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId, Me.colUnitCode, Me.colUnitName})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colUnitId
        '
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.OptionsColumn.ReadOnly = True
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
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 1
        '
        'colBookingUnitId
        '
        Me.colBookingUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colBookingUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBookingUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBookingUnitId.Caption = "Booking Unit"
        Me.colBookingUnitId.ColumnEdit = Me.BookingUnitGridLookUpEdit
        Me.colBookingUnitId.FieldName = "BookingUnitId"
        Me.colBookingUnitId.Name = "colBookingUnitId"
        Me.colBookingUnitId.Visible = True
        Me.colBookingUnitId.VisibleIndex = 22
        Me.colBookingUnitId.Width = 58
        '
        'BookingUnitGridLookUpEdit
        '
        Me.BookingUnitGridLookUpEdit.AutoHeight = False
        Me.BookingUnitGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BookingUnitGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.BookingUnitGridLookUpEdit.DisplayMember = "UnitCode"
        Me.BookingUnitGridLookUpEdit.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.BookingUnitGridLookUpEdit.Name = "BookingUnitGridLookUpEdit"
        Me.BookingUnitGridLookUpEdit.NullText = ""
        Me.BookingUnitGridLookUpEdit.PopupView = Me.GridView7
        Me.BookingUnitGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BookingUnitGridLookUpEdit.ValueMember = "UnitId"
        '
        'GridView7
        '
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId
        '
        Me.colSupplierId.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplierId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplierId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSupplierId.Caption = "Supplier"
        Me.colSupplierId.ColumnEdit = Me.SupplierGridLookUpEdit
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.Visible = True
        Me.colSupplierId.VisibleIndex = 28
        Me.colSupplierId.Width = 102
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.AutoHeight = False
        Me.SupplierGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierGridLookUpEdit.DataSource = Me.SupplierBindingSource
        Me.SupplierGridLookUpEdit.DisplayMember = "SupplierName"
        Me.SupplierGridLookUpEdit.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit"
        Me.SupplierGridLookUpEdit.NullText = ""
        Me.SupplierGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SupplierGridLookUpEdit.PopupView = Me.GridView5
        Me.SupplierGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierGridLookUpEdit.ValueMember = "SupplierId"
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId1, Me.colSupplierName, Me.colAdd1, Me.colAdd2, Me.colContactPerson, Me.colContactNo, Me.colSupplierType, Me.colSupplierCode, Me.colCity, Me.colCountry})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId1
        '
        Me.colSupplierId1.FieldName = "SupplierId"
        Me.colSupplierId1.Name = "colSupplierId1"
        Me.colSupplierId1.OptionsColumn.ReadOnly = True
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
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 1
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
        'colRemarks
        '
        Me.colRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 30
        Me.colRemarks.Width = 181
        '
        'colItemStyle1
        '
        Me.colItemStyle1.ColumnEdit = Me.ItemStyleGridLookUpEdit
        Me.colItemStyle1.FieldName = "ItemStyle"
        Me.colItemStyle1.Name = "colItemStyle1"
        Me.colItemStyle1.Width = 117
        '
        'ItemStyleGridLookUpEdit
        '
        Me.ItemStyleGridLookUpEdit.AutoHeight = False
        Me.ItemStyleGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemStyleGridLookUpEdit.DataSource = Me.ItemStyleBindingSource
        Me.ItemStyleGridLookUpEdit.DisplayMember = "ItemStyle"
        Me.ItemStyleGridLookUpEdit.Name = "ItemStyleGridLookUpEdit"
        Me.ItemStyleGridLookUpEdit.NullText = ""
        Me.ItemStyleGridLookUpEdit.PopupView = Me.GridView6
        Me.ItemStyleGridLookUpEdit.ValueMember = "ItemStyleId"
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemStyle3})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colItemStyle3
        '
        Me.colItemStyle3.FieldName = "ItemStyle"
        Me.colItemStyle3.Name = "colItemStyle3"
        Me.colItemStyle3.Visible = True
        Me.colItemStyle3.VisibleIndex = 0
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
        Me.colConsumptionForPcs.VisibleIndex = 24
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
        Me.colWastagePercentage.VisibleIndex = 25
        Me.colWastagePercentage.Width = 49
        '
        'colSLNo
        '
        Me.colSLNo.ColumnEdit = Me.SLNoItemTextEdit
        Me.colSLNo.FieldName = "SLNo"
        Me.colSLNo.Name = "colSLNo"
        Me.colSLNo.Tag = "<Null>"
        Me.colSLNo.Visible = True
        Me.colSLNo.VisibleIndex = 3
        Me.colSLNo.Width = 40
        '
        'SLNoItemTextEdit
        '
        Me.SLNoItemTextEdit.AutoHeight = False
        Me.SLNoItemTextEdit.Name = "SLNoItemTextEdit"
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
        Me.colSizeId1.ColumnEdit = Me.ItemIdGridLookUpEdit
        Me.colSizeId1.FieldName = "SizeId"
        Me.colSizeId1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colSizeId1.Name = "colSizeId1"
        Me.colSizeId1.Visible = True
        Me.colSizeId1.VisibleIndex = 8
        Me.colSizeId1.Width = 66
        '
        'ItemIdGridLookUpEdit
        '
        Me.ItemIdGridLookUpEdit.AutoHeight = False
        Me.ItemIdGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemIdGridLookUpEdit.DataSource = Me.SizeLookupBindingSource
        Me.ItemIdGridLookUpEdit.DisplayMember = "SizeCode"
        Me.ItemIdGridLookUpEdit.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.ItemIdGridLookUpEdit.Name = "ItemIdGridLookUpEdit"
        Me.ItemIdGridLookUpEdit.NullText = ""
        Me.ItemIdGridLookUpEdit.PopupView = Me.GridView9
        Me.ItemIdGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemIdGridLookUpEdit.ValueMember = "SizeId"
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId2, Me.colSizeId2, Me.colSizeCode, Me.colSlNo1})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colOrderId2
        '
        Me.colOrderId2.FieldName = "OrderId"
        Me.colOrderId2.Name = "colOrderId2"
        Me.colOrderId2.OptionsColumn.ReadOnly = True
        '
        'colSizeId2
        '
        Me.colSizeId2.FieldName = "SizeId"
        Me.colSizeId2.Name = "colSizeId2"
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
        Me.colDestinationId.ColumnEdit = Me.DestinationGridLookUpEdit
        Me.colDestinationId.FieldName = "DestinationId"
        Me.colDestinationId.Name = "colDestinationId"
        Me.colDestinationId.Visible = True
        Me.colDestinationId.VisibleIndex = 16
        Me.colDestinationId.Width = 84
        '
        'DestinationGridLookUpEdit
        '
        Me.DestinationGridLookUpEdit.AutoHeight = False
        Me.DestinationGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DestinationGridLookUpEdit.DataSource = Me.DestinationBindingSource
        Me.DestinationGridLookUpEdit.DisplayMember = "DestinationCode"
        Me.DestinationGridLookUpEdit.Name = "DestinationGridLookUpEdit"
        Me.DestinationGridLookUpEdit.NullText = ""
        Me.DestinationGridLookUpEdit.PopupView = Me.GridView3
        Me.DestinationGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DestinationGridLookUpEdit.ValueMember = "DestinationId"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDestinationId1, Me.colDestinationCode, Me.colDestinationName})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
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
        Me.colDestinationName.Visible = True
        Me.colDestinationName.VisibleIndex = 1
        '
        'colPackType
        '
        Me.colPackType.ColumnEdit = Me.PackTypeItemComboBox
        Me.colPackType.FieldName = "PackType"
        Me.colPackType.Name = "colPackType"
        Me.colPackType.Visible = True
        Me.colPackType.VisibleIndex = 15
        '
        'PackTypeItemComboBox
        '
        Me.PackTypeItemComboBox.AutoHeight = False
        Me.PackTypeItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PackTypeItemComboBox.Items.AddRange(New Object() {"Normal", "Ratio"})
        Me.PackTypeItemComboBox.Name = "PackTypeItemComboBox"
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 18
        Me.colOrderQuantity.Width = 65
        '
        'colItemId
        '
        Me.colItemId.Caption = "Item Name"
        Me.colItemId.ColumnEdit = Me.ItemGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 4
        Me.colItemId.Width = 219
        '
        'ItemGridLookUpEdit
        '
        Me.ItemGridLookUpEdit.AutoHeight = False
        Me.ItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemGridLookUpEdit.DataSource = Me.ItemListBindingSource
        Me.ItemGridLookUpEdit.DisplayMember = "ItemName"
        Me.ItemGridLookUpEdit.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.ItemGridLookUpEdit.Name = "ItemGridLookUpEdit"
        Me.ItemGridLookUpEdit.NullText = ""
        Me.ItemGridLookUpEdit.PopupView = Me.GridView11
        Me.ItemGridLookUpEdit.ReadOnly = True
        Me.ItemGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemGridLookUpEdit.ValueMember = "ItemId"
        '
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName2})
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'colItemName2
        '
        Me.colItemName2.FieldName = "ItemName"
        Me.colItemName2.Name = "colItemName2"
        Me.colItemName2.Visible = True
        Me.colItemName2.VisibleIndex = 0
        '
        'colAdditionalQuantity
        '
        Me.colAdditionalQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colAdditionalQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colAdditionalQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colAdditionalQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAdditionalQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAdditionalQuantity.FieldName = "AdditionalQuantity"
        Me.colAdditionalQuantity.Name = "colAdditionalQuantity"
        Me.colAdditionalQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colAdditionalQuantity.Visible = True
        Me.colAdditionalQuantity.VisibleIndex = 20
        Me.colAdditionalQuantity.Width = 83
        '
        'colColorCode
        '
        Me.colColorCode.FieldName = "ColorCode"
        Me.colColorCode.Name = "colColorCode"
        Me.colColorCode.Visible = True
        Me.colColorCode.VisibleIndex = 7
        Me.colColorCode.Width = 74
        '
        'colSKU
        '
        Me.colSKU.Caption = "SKU / USIM"
        Me.colSKU.FieldName = "SKU"
        Me.colSKU.Name = "colSKU"
        Me.colSKU.Visible = True
        Me.colSKU.VisibleIndex = 12
        '
        'colApprovedBy
        '
        Me.colApprovedBy.FieldName = "ApprovedBy"
        Me.colApprovedBy.Name = "colApprovedBy"
        Me.colApprovedBy.OptionsColumn.AllowEdit = False
        Me.colApprovedBy.OptionsColumn.ReadOnly = True
        Me.colApprovedBy.Width = 94
        '
        'colApprovedOn
        '
        Me.colApprovedOn.FieldName = "ApprovedOn"
        Me.colApprovedOn.Name = "colApprovedOn"
        Me.colApprovedOn.OptionsColumn.AllowEdit = False
        Me.colApprovedOn.OptionsColumn.ReadOnly = True
        Me.colApprovedOn.Width = 85
        '
        'colCompletedBy
        '
        Me.colCompletedBy.FieldName = "CompletedBy"
        Me.colCompletedBy.Name = "colCompletedBy"
        Me.colCompletedBy.OptionsColumn.AllowEdit = False
        Me.colCompletedBy.OptionsColumn.ReadOnly = True
        '
        'colCompleteOn
        '
        Me.colCompleteOn.FieldName = "CompleteOn"
        Me.colCompleteOn.Name = "colCompleteOn"
        '
        'colIsApproved
        '
        Me.colIsApproved.AppearanceCell.Options.UseTextOptions = True
        Me.colIsApproved.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsApproved.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsApproved.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsApproved.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsApproved.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsApproved.FieldName = "IsApproved"
        Me.colIsApproved.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colIsApproved.Name = "colIsApproved"
        Me.colIsApproved.OptionsColumn.AllowEdit = False
        Me.colIsApproved.OptionsColumn.ReadOnly = True
        Me.colIsApproved.Visible = True
        Me.colIsApproved.VisibleIndex = 2
        Me.colIsApproved.Width = 57
        '
        'colIsComplete
        '
        Me.colIsComplete.AppearanceCell.Options.UseForeColor = True
        Me.colIsComplete.AppearanceCell.Options.UseTextOptions = True
        Me.colIsComplete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsComplete.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsComplete.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsComplete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsComplete.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsComplete.FieldName = "IsComplete"
        Me.colIsComplete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colIsComplete.Name = "colIsComplete"
        Me.colIsComplete.Visible = True
        Me.colIsComplete.VisibleIndex = 1
        Me.colIsComplete.Width = 62
        '
        'colPicture
        '
        Me.colPicture.ColumnEdit = Me.RepositoryItemPictureEdit3
        Me.colPicture.FieldName = "Picture"
        Me.colPicture.Name = "colPicture"
        Me.colPicture.Visible = True
        Me.colPicture.VisibleIndex = 29
        '
        'RepositoryItemPictureEdit3
        '
        Me.RepositoryItemPictureEdit3.Name = "RepositoryItemPictureEdit3"
        Me.RepositoryItemPictureEdit3.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'colBuyerDepartment
        '
        Me.colBuyerDepartment.FieldName = "BuyerDepartment"
        Me.colBuyerDepartment.Name = "colBuyerDepartment"
        Me.colBuyerDepartment.Visible = True
        Me.colBuyerDepartment.VisibleIndex = 14
        Me.colBuyerDepartment.Width = 97
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
        Me.colItemCode.VisibleIndex = 5
        Me.colItemCode.Width = 105
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
        'colGenerationType
        '
        Me.colGenerationType.FieldName = "GenerationType"
        Me.colGenerationType.Name = "colGenerationType"
        Me.colGenerationType.Visible = True
        Me.colGenerationType.VisibleIndex = 17
        Me.colGenerationType.Width = 104
        '
        'colIsSelected
        '
        Me.colIsSelected.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsSelected.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsSelected.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsSelected.FieldName = "IsSelected"
        Me.colIsSelected.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colIsSelected.Name = "colIsSelected"
        Me.colIsSelected.Visible = True
        Me.colIsSelected.VisibleIndex = 0
        Me.colIsSelected.Width = 52
        '
        'AccessoriesItemGridLookUpEdit
        '
        Me.AccessoriesItemGridLookUpEdit.AutoHeight = False
        Me.AccessoriesItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccessoriesItemGridLookUpEdit.DisplayMember = "AccessoriesName"
        Me.AccessoriesItemGridLookUpEdit.Name = "AccessoriesItemGridLookUpEdit"
        Me.AccessoriesItemGridLookUpEdit.NullText = ""
        Me.AccessoriesItemGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AccessoriesItemGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.AccessoriesItemGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AccessoriesItemGridLookUpEdit.ValueMember = "AccessoriesId"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccessoriesId1, Me.colAccessoriesName, Me.colItemStyle, Me.colItemDetails})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colAccessoriesId1
        '
        Me.colAccessoriesId1.FieldName = "AccessoriesId"
        Me.colAccessoriesId1.Name = "colAccessoriesId1"
        Me.colAccessoriesId1.OptionsColumn.ReadOnly = True
        '
        'colAccessoriesName
        '
        Me.colAccessoriesName.FieldName = "AccessoriesName"
        Me.colAccessoriesName.Name = "colAccessoriesName"
        '
        'colItemStyle
        '
        Me.colItemStyle.FieldName = "ItemStyle"
        Me.colItemStyle.Name = "colItemStyle"
        Me.colItemStyle.OptionsColumn.ReadOnly = True
        '
        'colItemDetails
        '
        Me.colItemDetails.FieldName = "ItemDetails"
        Me.colItemDetails.Name = "colItemDetails"
        Me.colItemDetails.OptionsColumn.ReadOnly = True
        Me.colItemDetails.Visible = True
        Me.colItemDetails.VisibleIndex = 0
        '
        'ProgramSearchGridLookUpEdit
        '
        Me.ProgramSearchGridLookUpEdit.Location = New System.Drawing.Point(541, 8)
        Me.ProgramSearchGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.ProgramSearchGridLookUpEdit.Name = "ProgramSearchGridLookUpEdit"
        Me.ProgramSearchGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramSearchGridLookUpEdit.Properties.DataSource = Me.AccBookingLookupBindingSource
        Me.ProgramSearchGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramSearchGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramSearchGridLookUpEdit.Properties.NullText = ""
        Me.ProgramSearchGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramSearchGridLookUpEdit.Properties.PopupView = Me.GridView8
        Me.ProgramSearchGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramSearchGridLookUpEdit.Properties.ValueMember = "AccessoriesBookingId"
        Me.ProgramSearchGridLookUpEdit.Size = New System.Drawing.Size(232, 20)
        Me.ProgramSearchGridLookUpEdit.TabIndex = 18
        Me.ProgramSearchGridLookUpEdit.Tag = "NR"
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
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'AccOrderLookupBindingSource
        '
        Me.AccOrderLookupBindingSource.DataMember = "AccOrderLookup"
        Me.AccOrderLookupBindingSource.DataSource = Me.AccessoriesBookingNewDataSet
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(779, 7)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 19
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'AccessoriesBookingTableAdapter1
        '
        Me.AccessoriesBookingTableAdapter1.ClearBeforeFill = True
        '
        'SizeLookupTableAdapter
        '
        Me.SizeLookupTableAdapter.ClearBeforeFill = True
        '
        'StyleLabel
        '
        Me.StyleLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StyleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StyleLabel.Location = New System.Drawing.Point(601, 19)
        Me.StyleLabel.Name = "StyleLabel"
        Me.StyleLabel.Size = New System.Drawing.Size(234, 23)
        Me.StyleLabel.TabIndex = 15
        Me.StyleLabel.Text = "Style Name"
        Me.StyleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BuyerLabel
        '
        Me.BuyerLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BuyerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BuyerLabel.Location = New System.Drawing.Point(601, 47)
        Me.BuyerLabel.Name = "BuyerLabel"
        Me.BuyerLabel.Size = New System.Drawing.Size(234, 23)
        Me.BuyerLabel.TabIndex = 20
        Me.BuyerLabel.Text = "Buyer Name"
        Me.BuyerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.LemonChiffon
        Me.GroupBox1.Controls.Add(Me.AmendmentDetailsMemoEdit)
        Me.GroupBox1.Controls.Add(Me.AccessoriesBookingAmndDetailsGridControl)
        Me.GroupBox1.Controls.Add(Me.AmndButton)
        Me.GroupBox1.Controls.Add(RequireDateLabel)
        Me.GroupBox1.Controls.Add(Me.RequireDateDateEdit)
        Me.GroupBox1.Controls.Add(ReferenceLabel)
        Me.GroupBox1.Controls.Add(Me.ReferenceTextEdit)
        Me.GroupBox1.Controls.Add(GMQtyLabel)
        Me.GroupBox1.Controls.Add(Me.GMQtyTextEdit)
        Me.GroupBox1.Controls.Add(Me.IsCompleteCheckEdit)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.BuyerLabel)
        Me.GroupBox1.Controls.Add(Me.StyleLabel)
        Me.GroupBox1.Controls.Add(OrderIdLabel1)
        Me.GroupBox1.Controls.Add(Me.OrderIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(BookingDateLabel)
        Me.GroupBox1.Controls.Add(Me.BookingDateDateEdit)
        Me.GroupBox1.Controls.Add(AmendmentNoLabel)
        Me.GroupBox1.Controls.Add(Me.AmendmentNoSpinEdit)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(AmendmentDateLabel)
        Me.GroupBox1.Controls.Add(Me.AmendmentDateDateEdit)
        Me.GroupBox1.Controls.Add(RemarksLabel)
        Me.GroupBox1.Controls.Add(Me.RemarksTextEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1321, 269)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Information"
        '
        'AmendmentDetailsMemoEdit
        '
        Me.AmendmentDetailsMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesBookingBindingSource, "AmendmentDetails", True))
        Me.AmendmentDetailsMemoEdit.Location = New System.Drawing.Point(350, 74)
        Me.AmendmentDetailsMemoEdit.Name = "AmendmentDetailsMemoEdit"
        Me.AmendmentDetailsMemoEdit.Properties.ReadOnly = True
        Me.AmendmentDetailsMemoEdit.Size = New System.Drawing.Size(168, 45)
        Me.AmendmentDetailsMemoEdit.TabIndex = 28
        '
        'AccessoriesBookingAmndDetailsGridControl
        '
        Me.AccessoriesBookingAmndDetailsGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessoriesBookingAmndDetailsGridControl.DataSource = Me.AccessoriesBookingAmndDetailsBindingSource
        Me.AccessoriesBookingAmndDetailsGridControl.Location = New System.Drawing.Point(861, 19)
        Me.AccessoriesBookingAmndDetailsGridControl.MainView = Me.GridView14
        Me.AccessoriesBookingAmndDetailsGridControl.Name = "AccessoriesBookingAmndDetailsGridControl"
        Me.AccessoriesBookingAmndDetailsGridControl.Size = New System.Drawing.Size(416, 125)
        Me.AccessoriesBookingAmndDetailsGridControl.TabIndex = 27
        Me.AccessoriesBookingAmndDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView14})
        '
        'AccessoriesBookingAmndDetailsBindingSource
        '
        Me.AccessoriesBookingAmndDetailsBindingSource.DataMember = "AccessoriesBooking_AccessoriesBookingAmndDetails"
        Me.AccessoriesBookingAmndDetailsBindingSource.DataSource = Me.AccessoriesBookingBindingSource
        '
        'GridView14
        '
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAmndNo, Me.colAmndDate, Me.colDetails1})
        Me.GridView14.GridControl = Me.AccessoriesBookingAmndDetailsGridControl
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsView.ShowGroupPanel = False
        '
        'colAmndNo
        '
        Me.colAmndNo.FieldName = "AmndNo"
        Me.colAmndNo.Name = "colAmndNo"
        Me.colAmndNo.Visible = True
        Me.colAmndNo.VisibleIndex = 0
        Me.colAmndNo.Width = 87
        '
        'colAmndDate
        '
        Me.colAmndDate.FieldName = "AmndDate"
        Me.colAmndDate.Name = "colAmndDate"
        Me.colAmndDate.Visible = True
        Me.colAmndDate.VisibleIndex = 1
        Me.colAmndDate.Width = 154
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 2
        Me.colDetails1.Width = 157
        '
        'AmndButton
        '
        Me.AmndButton.Location = New System.Drawing.Point(443, 19)
        Me.AmndButton.Name = "AmndButton"
        Me.AmndButton.Size = New System.Drawing.Size(75, 23)
        Me.AmndButton.TabIndex = 27
        Me.AmndButton.Text = "Amendment"
        Me.AmndButton.UseVisualStyleBackColor = True
        '
        'RequireDateDateEdit
        '
        Me.RequireDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesBookingBindingSource, "RequireDate", True))
        Me.RequireDateDateEdit.EditValue = Nothing
        Me.RequireDateDateEdit.Location = New System.Drawing.Point(115, 74)
        Me.RequireDateDateEdit.Name = "RequireDateDateEdit"
        Me.RequireDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequireDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RequireDateDateEdit.Size = New System.Drawing.Size(126, 20)
        Me.RequireDateDateEdit.TabIndex = 26
        '
        'ReferenceTextEdit
        '
        Me.ReferenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesBookingBindingSource, "Reference", True))
        Me.ReferenceTextEdit.Location = New System.Drawing.Point(115, 99)
        Me.ReferenceTextEdit.Name = "ReferenceTextEdit"
        Me.ReferenceTextEdit.Size = New System.Drawing.Size(127, 20)
        Me.ReferenceTextEdit.TabIndex = 25
        '
        'GMQtyTextEdit
        '
        Me.GMQtyTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesBookingBindingSource, "GMQty", True))
        Me.GMQtyTextEdit.Location = New System.Drawing.Point(601, 73)
        Me.GMQtyTextEdit.Name = "GMQtyTextEdit"
        Me.GMQtyTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GMQtyTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.GMQtyTextEdit.Size = New System.Drawing.Size(234, 20)
        Me.GMQtyTextEdit.TabIndex = 24
        '
        'IsCompleteCheckEdit
        '
        Me.IsCompleteCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AccessoriesBookingBindingSource, "IsComplete", True))
        Me.IsCompleteCheckEdit.Location = New System.Drawing.Point(599, 99)
        Me.IsCompleteCheckEdit.Name = "IsCompleteCheckEdit"
        Me.IsCompleteCheckEdit.Properties.Caption = "Is Full Complete ?"
        Me.IsCompleteCheckEdit.Properties.ReadOnly = True
        Me.IsCompleteCheckEdit.Size = New System.Drawing.Size(157, 19)
        Me.IsCompleteCheckEdit.TabIndex = 23
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrintButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.RecalculateButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.ProgramSearchGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1350, 36)
        Me.FlowLayoutPanel1.TabIndex = 45
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewButton.Location = New System.Drawing.Point(3, 4)
        Me.NewButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(82, 27)
        Me.NewButton.TabIndex = 4
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Location = New System.Drawing.Point(91, 4)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 27)
        Me.EditButton.TabIndex = 5
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Location = New System.Drawing.Point(160, 4)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
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
        Me.CancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelEntryButton.Location = New System.Drawing.Point(229, 4)
        Me.CancelEntryButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(63, 27)
        Me.CancelEntryButton.TabIndex = 7
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        Me.CancelEntryButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintButton.Location = New System.Drawing.Point(298, 4)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 27)
        Me.PrintButton.TabIndex = 35
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(379, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "&Export XLS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RecalculateButton
        '
        Me.RecalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecalculateButton.Location = New System.Drawing.Point(460, 4)
        Me.RecalculateButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.RecalculateButton.Name = "RecalculateButton"
        Me.RecalculateButton.Size = New System.Drawing.Size(75, 27)
        Me.RecalculateButton.TabIndex = 36
        Me.RecalculateButton.Text = "&Recalculate"
        Me.RecalculateButton.UseVisualStyleBackColor = True
        '
        'DestinationTableAdapter
        '
        Me.DestinationTableAdapter.ClearBeforeFill = True
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'ItemStyleTableAdapter
        '
        Me.ItemStyleTableAdapter.ClearBeforeFill = True
        '
        'AccOrderLookupTableAdapter
        '
        Me.AccOrderLookupTableAdapter.ClearBeforeFill = True
        '
        'AccBookingLookupTableAdapter
        '
        Me.AccBookingLookupTableAdapter.ClearBeforeFill = True
        '
        'ProgramNoLookupByDivUserTableAdapter
        '
        Me.ProgramNoLookupByDivUserTableAdapter.ClearBeforeFill = True
        '
        'PackTypeLookupTableAdapter
        '
        Me.PackTypeLookupTableAdapter.ClearBeforeFill = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 205)
        Me.XtraTabControl1.LookAndFeel.SkinName = "Lilian"
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1347, 524)
        Me.XtraTabControl1.TabIndex = 46
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SplitContainer1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1339, 495)
        Me.XtraTabPage1.Text = "Accessories Booking Details"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.AutoScroll = True
        Me.XtraTabPage2.Controls.Add(Me.AccessoriesBookingCareLableGridControl)
        Me.XtraTabPage2.Controls.Add(Me.CareLableSaveButton)
        Me.XtraTabPage2.Controls.Add(Me.CareLabelGridControl)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1339, 495)
        Me.XtraTabPage2.Text = "Care Label"
        '
        'AccessoriesBookingCareLableGridControl
        '
        Me.AccessoriesBookingCareLableGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AccessoriesBookingCareLableGridControl.DataSource = Me.AccessoriesBookingCareLableBindingSource
        Me.AccessoriesBookingCareLableGridControl.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.AccessoriesBookingCareLableGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.AccessoriesBookingCareLableGridControl.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.AccessoriesBookingCareLableGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.AccessoriesBookingCareLableGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.AccessoriesBookingCareLableGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.AccessoriesBookingCareLableGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.AccessoriesBookingCareLableGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.AccessoriesBookingCareLableGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.AccessoriesBookingCareLableGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.AccessoriesBookingCareLableGridControl.Location = New System.Drawing.Point(0, 3)
        Me.AccessoriesBookingCareLableGridControl.MainView = Me.GridView13
        Me.AccessoriesBookingCareLableGridControl.Name = "AccessoriesBookingCareLableGridControl"
        Me.AccessoriesBookingCareLableGridControl.Size = New System.Drawing.Size(1035, 342)
        Me.AccessoriesBookingCareLableGridControl.TabIndex = 9
        Me.AccessoriesBookingCareLableGridControl.UseEmbeddedNavigator = True
        Me.AccessoriesBookingCareLableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView13})
        '
        'AccessoriesBookingCareLableBindingSource
        '
        Me.AccessoriesBookingCareLableBindingSource.DataMember = "FK_AccessoriesBookingCareLable_AccessoriesBooking"
        Me.AccessoriesBookingCareLableBindingSource.DataSource = Me.AccessoriesBookingBindingSource
        '
        'GridView13
        '
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCareLable, Me.colRemarks1, Me.colAccessoriesBookingCareLableId, Me.colAccessoriesBookingId1, Me.colSLNo2, Me.colAdditionalIns})
        Me.GridView13.GridControl = Me.AccessoriesBookingCareLableGridControl
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsView.ColumnAutoWidth = False
        Me.GridView13.OptionsView.ShowGroupPanel = False
        Me.GridView13.RowHeight = 50
        '
        'colCareLable
        '
        Me.colCareLable.Caption = "Care Label"
        Me.colCareLable.ColumnEdit = Me.RepositoryItemPictureEdit2
        Me.colCareLable.FieldName = "CareLable"
        Me.colCareLable.Name = "colCareLable"
        Me.colCareLable.Visible = True
        Me.colCareLable.VisibleIndex = 1
        Me.colCareLable.Width = 72
        '
        'colRemarks1
        '
        Me.colRemarks1.Caption = "Care Instruction"
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 2
        Me.colRemarks1.Width = 279
        '
        'colAccessoriesBookingCareLableId
        '
        Me.colAccessoriesBookingCareLableId.FieldName = "AccessoriesBookingCareLableId"
        Me.colAccessoriesBookingCareLableId.Name = "colAccessoriesBookingCareLableId"
        '
        'colAccessoriesBookingId1
        '
        Me.colAccessoriesBookingId1.FieldName = "AccessoriesBookingId"
        Me.colAccessoriesBookingId1.Name = "colAccessoriesBookingId1"
        '
        'colSLNo2
        '
        Me.colSLNo2.FieldName = "SLNo"
        Me.colSLNo2.Name = "colSLNo2"
        Me.colSLNo2.Visible = True
        Me.colSLNo2.VisibleIndex = 0
        Me.colSLNo2.Width = 52
        '
        'colAdditionalIns
        '
        Me.colAdditionalIns.Caption = "Additional Instruction"
        Me.colAdditionalIns.FieldName = "AdditionalIns"
        Me.colAdditionalIns.Name = "colAdditionalIns"
        Me.colAdditionalIns.Visible = True
        Me.colAdditionalIns.VisibleIndex = 3
        Me.colAdditionalIns.Width = 431
        '
        'CareLableSaveButton
        '
        Me.CareLableSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CareLableSaveButton.Location = New System.Drawing.Point(1041, 148)
        Me.CareLableSaveButton.Name = "CareLableSaveButton"
        Me.CareLableSaveButton.Size = New System.Drawing.Size(98, 31)
        Me.CareLableSaveButton.TabIndex = 9
        Me.CareLableSaveButton.Text = "Add Care Label"
        Me.CareLableSaveButton.UseVisualStyleBackColor = True
        '
        'CareLabelGridControl
        '
        Me.CareLabelGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CareLabelGridControl.DataSource = Me.CareLabelBindingSource
        Me.CareLabelGridControl.Location = New System.Drawing.Point(1145, 3)
        Me.CareLabelGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CareLabelGridControl.MainView = Me.GridView12
        Me.CareLabelGridControl.Name = "CareLabelGridControl"
        Me.CareLabelGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.CareLabelGridControl.Size = New System.Drawing.Size(203, 342)
        Me.CareLabelGridControl.TabIndex = 8
        Me.CareLabelGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView12})
        '
        'CareLabelBindingSource
        '
        Me.CareLabelBindingSource.DataMember = "CareLabel"
        Me.CareLabelBindingSource.DataSource = Me.CareLabelDataSet
        '
        'CareLabelDataSet
        '
        Me.CareLabelDataSet.DataSetName = "CareLabelDataSet"
        Me.CareLabelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView12
        '
        Me.GridView12.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView12.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView12.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCareLabel, Me.colSelected})
        Me.GridView12.GridControl = Me.CareLabelGridControl
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsView.ColumnAutoWidth = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        Me.GridView12.RowHeight = 50
        '
        'colCareLabel
        '
        Me.colCareLabel.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.colCareLabel.FieldName = "CareLabel"
        Me.colCareLabel.Name = "colCareLabel"
        Me.colCareLabel.Visible = True
        Me.colCareLabel.VisibleIndex = 1
        Me.colCareLabel.Width = 76
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'colSelected
        '
        Me.colSelected.FieldName = "Selected"
        Me.colSelected.Name = "colSelected"
        Me.colSelected.Visible = True
        Me.colSelected.VisibleIndex = 0
        Me.colSelected.Width = 51
        '
        'CareLabelTableAdapter
        '
        Me.CareLabelTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesBookingAmndDetailsTableAdapter
        '
        Me.AccessoriesBookingAmndDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmAccessoriesBookingNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmAccessoriesBookingNew"
        Me.Text = "Accessories BOM"
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesBookingNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesBookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoLookupByDivUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesBookingSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoresBookingDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.WPercSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackCheckListBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackTypeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackTypeByOrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationCheckedListBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeCheckListBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCheckListBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConPCSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccNameGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoresBookingDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingUnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemStyleGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SLNoItemTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemIdGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackTypeItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramSearchGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccOrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AmendmentDetailsMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesBookingAmndDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesBookingAmndDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequireDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequireDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMQtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.AccessoriesBookingCareLableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesBookingCareLableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CareLabelGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CareLabelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CareLabelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AccessoriesBookingNewDataSet As KSoft_Apparel.AccessoriesBookingNewDataSet
    Friend WithEvents AccessoriesBookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesBookingTableAdapter As KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoriesBookingTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BookingDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AmendmentNoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AmendmentDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AccessoresBookingDetailsTableAdapter As KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoresBookingDetailsTableAdapter
    Friend WithEvents OrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet

    Friend WithEvents AccessoriesBookingSizeDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ProgramSearchGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents AccessoriesBookingTableAdapter1 As KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoriesBookingTableAdapter
    Friend WithEvents SizeLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeDataSet As KSoft_Apparel.SizeDataSet
    Friend WithEvents SizeLookupTableAdapter As KSoft_Apparel.SizeDataSetTableAdapters.SizeLookupTableAdapter
    Friend WithEvents StyleLabel As System.Windows.Forms.Label
    Friend WithEvents BuyerLabel As System.Windows.Forms.Label
    Friend WithEvents AccNameGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CostingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents PackCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DestinationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SizeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ColorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GenByStyleButton As System.Windows.Forms.Button
    Friend WithEvents DestinationDataSet As KSoft_Apparel.DestinationDataSet
    Friend WithEvents DestinationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DestinationTableAdapter As KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter
    Friend WithEvents ConSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UnitIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ConPCSSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ColorCheckListBox As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents SizeCheckListBox As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents DestinationCheckedListBox As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents PackCheckListBox As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Apparel.ItemListLookupDataSet
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemStyleDataSet As KSoft_Apparel.ItemStyleDataSet
    Friend WithEvents ItemStyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemStyleTableAdapter As KSoft_Apparel.ItemStyleDataSetTableAdapters.ItemStyleTableAdapter
    Friend WithEvents ItemListBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents colItemName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccOrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccOrderLookupTableAdapter As KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccOrderLookupTableAdapter
    Friend WithEvents AccLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents WPercSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AccBOMLookUpDataSet As KSoft_Apparel.AccBOMLookUpDataSet
    Friend WithEvents AccBookingLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccBookingLookupTableAdapter As KSoft_Apparel.AccBOMLookUpDataSetTableAdapters.AccBookingLookupTableAdapter
    Friend WithEvents IsCompleteCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AccessoresBookingDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgramNoLookupByDivUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProgramNoLookupByDivUserTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.ProgramNoLookupByDivUserTableAdapter
    Friend WithEvents colUnitCode2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SelectAllSizeLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents SelectAllColorLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents PackTypeLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PackTypeByOrderDataSet As KSoft_Apparel.PackTypeByOrderDataSet
    Friend WithEvents PackTypeLookupTableAdapter As KSoft_Apparel.PackTypeByOrderDataSetTableAdapters.PackTypeLookupTableAdapter
    Friend WithEvents AccessoresBookingDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccessoriesBookingDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesBookingId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsumption As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsumptionUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBookingUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BookingUnitGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBookingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemStyle1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemStyleGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemStyle3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsumptionForPcs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWastagePercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSLNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemIdGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSlNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DestinationGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDestinationId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPackType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PackTypeItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdditionalQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColorCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSKU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompletedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompleteOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsApproved As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccessoriesItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccessoriesId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemStyle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CareLableSaveButton As System.Windows.Forms.Button
    Friend WithEvents CareLabelGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCareLabel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccessoriesBookingCareLableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesBookingCareLableTableAdapter As KSoft_Apparel.AccessoriesBookingNewDataSetTableAdapters.AccessoriesBookingCareLableTableAdapter
    Friend WithEvents AccessoriesBookingCareLableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCareLable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CareLabelDataSet As KSoft_Apparel.CareLabelDataSet
    Friend WithEvents CareLabelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CareLabelTableAdapter As KSoft_Apparel.CareLabelDataSetTableAdapters.CareLabelTableAdapter
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents ReferenceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GMQtyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colPicture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequireDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colAccessoriesBookingCareLableId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesBookingId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSLNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SLNoItemTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colBuyerDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabrication As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKimballNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdditionalIns As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents AmndButton As Button
    Friend WithEvents colGenerationType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RecalculateButton As Button
    Friend WithEvents SelectSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colIsSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AccessoriesBookingAmndDetailsBindingSource As BindingSource
    Friend WithEvents AccessoriesBookingAmndDetailsTableAdapter As AccessoriesBookingNewDataSetTableAdapters.AccessoriesBookingAmndDetailsTableAdapter
    Friend WithEvents AccessoriesBookingAmndDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAmndNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmendmentDetailsMemoEdit As DevExpress.XtraEditors.MemoEdit
End Class
