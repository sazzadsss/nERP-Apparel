<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleOrder
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
        Dim StyleLabel As System.Windows.Forms.Label
        Dim GarmentsDescriptionLabel As System.Windows.Forms.Label
        Dim RequestDateLabel As System.Windows.Forms.Label
        Dim ExDateLabel As System.Windows.Forms.Label
        Dim ArtworkLocationLabel As System.Windows.Forms.Label
        Dim SpecialBackNeckReferenceLabel As System.Windows.Forms.Label
        Dim ApplicationLabel As System.Windows.Forms.Label
        Dim PrintSizeLabel As System.Windows.Forms.Label
        Dim WidthLabel As System.Windows.Forms.Label
        Dim HeightLabel As System.Windows.Forms.Label
        Dim PrintPositionLabel As System.Windows.Forms.Label
        Dim MesurementLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim SendPhotoStrikeOffLabel1 As System.Windows.Forms.Label
        Dim PrintTypeIdLabel As System.Windows.Forms.Label
        Dim BuyerIdLabel As System.Windows.Forms.Label
        Dim GMDepartmentIdLabel As System.Windows.Forms.Label
        Dim DevTypeIdLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim MasterProgramNoLabel As System.Windows.Forms.Label
        Dim SampleSendDateLabel As System.Windows.Forms.Label
        Dim SendingInfoLabel As System.Windows.Forms.Label
        Dim CommentsReceiveDateLabel As System.Windows.Forms.Label
        Dim ApprovalStatusLabel As System.Windows.Forms.Label
        Dim StyleTypeLabel1 As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SampleRequestFinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestDataSet = New KSoft_Apparel.SampleRequestDataSet()
        Me.RequestNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RequestDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ExDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ArtworkLocationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SpecialBackNeckReferenceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ApplicationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PrintSizeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WidthSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.HeightSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PrintPositionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MesurementSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.SampleRequestFinalDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.SampleRequestFinalDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestFinalDetailsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSampleRequestDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSampleRequestId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKnittingTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KnittingTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKnittingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompositionId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Composition2GridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colComposition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsFabricAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colELD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSampleSendDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSealed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSealedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgreedLeadTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExFabricRcvDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsAOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsYDS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExSendDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCancelReason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColorItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CopyFabricButton = New System.Windows.Forms.Button()
        Me.SampleFabricDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GarmentsPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartDataSet = New KSoft_Apparel.GarmentsPartDataSet()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SPNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GSMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSMDataSet = New KSoft_Apparel.GSMDataSet()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consumption = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.KgPerUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GreyPercentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GreyQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDelivered = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DeliveredDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintSend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintReceived = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IsFabricAvailable = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleFabricBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetDataLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.YarnAllocationSampleGridControl = New DevExpress.XtraGrid.GridControl()
        Me.YarnAllocationSampleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemNameGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Apparel.ItemListLookupDataSet()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWastagePercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsYds1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFeederSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFeederQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFeederNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStripeGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStripeSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGroupSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SamplePrintColorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SamplePrintColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SampleRequireQuantityDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleRequireQuantityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartTableAdapter = New KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter()
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter()
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter()
        Me.GSMTableAdapter = New KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SRLookupByDivUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestLookupDataSet = New KSoft_Apparel.SampleRequestLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.CopyAllButton = New System.Windows.Forms.Button()
        Me.SampleRequestNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SendPhotoStrikeOffCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.RemarksMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.IsEmbroideryCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.EmbroideryDetailsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsTrimCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.TrimDetailsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsPrintCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.PrintTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PrintTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PrintTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintTypeDataSet = New KSoft_Apparel.PrintTypeDataSet()
        Me.PrintTypeTableAdapter = New KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StyleTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsTrimAvailableCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ExTrimRcvDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AgreedLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMTBrandIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GMTBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMTBrandDataSet = New KSoft_Apparel.GMTBrandDataSet()
        Me.GMTBrandIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGMTBrandName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.StyleTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleTypeDataSet = New KSoft_Apparel.StyleTypeDataSet()
        Me.StyleNameIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleNameMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet()
        Me.StyleNameIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleNameId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleNameGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ApprovalStatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CommentsReceiveDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.SampleQuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SendingInfoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SampleSendDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.GetDataButton = New System.Windows.Forms.Button()
        Me.MasterProgramNoTextBox = New System.Windows.Forms.TextBox()
        Me.GetStyleDetailsButton = New System.Windows.Forms.Button()
        Me.RequestNoLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.DivisionIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DivisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivisionDataSet = New KSoft_Apparel.DivisionDataSet()
        Me.DivisionIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDivisionName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleNoLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GarmentsDescriptionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.DevTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DevTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevTypeDataSet = New KSoft_Apparel.DevTypeDataSet()
        Me.DevTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDevType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDefaultTarget = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrintTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleNameId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SampleUpdateCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.GMDepartmentIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GMDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMDepartmentDataSet = New KSoft_Apparel.GMDepartmentDataSet()
        Me.GMDepartmentIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.WashTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.WashTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashTypeDataSet = New KSoft_Apparel.WashTypeDataSet()
        Me.WashTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWashType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.SampleRequestFinalTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestFinalTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SampleRequestDataSetTableAdapters.TableAdapterManager()
        Me.SampleFabricTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleFabricTableAdapter()
        Me.SamplePrintColorTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SamplePrintColorTableAdapter()
        Me.SampleRequestFinalDetailsTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestFinalDetailsTableAdapter()
        Me.SampleRequireQuantityTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequireQuantityTableAdapter()
        Me.YarnAllocationSampleTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.YarnAllocationSampleTableAdapter()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter()
        Me.GMDepartmentTableAdapter = New KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter()
        Me.WashTypeMstTableAdapter = New KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter()
        Me.DevTypeMstTableAdapter = New KSoft_Apparel.DevTypeDataSetTableAdapters.DevTypeMstTableAdapter()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.IsWashCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.DivisionTableAdapter = New KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter()
        Me.SampleRequestNoLookupTableAdapter = New KSoft_Apparel.SampleRequestLookupDataSetTableAdapters.SampleRequestNoLookupTableAdapter()
        Me.IsPeachFinishCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsBrushCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.StyleTypeMstTableAdapter = New KSoft_Apparel.StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter()
        Me.GMTBrandTableAdapter = New KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter()
        Me.StyleNameMstTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleNameMstTableAdapter()
        Me.SRLookupByDivUserTableAdapter = New KSoft_Apparel.SampleRequestLookupDataSetTableAdapters.SRLookupByDivUserTableAdapter()
        Me.IsAOPCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsYDSCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.PicturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.IsSequnceCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsSublimationCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        StyleLabel = New System.Windows.Forms.Label()
        GarmentsDescriptionLabel = New System.Windows.Forms.Label()
        RequestDateLabel = New System.Windows.Forms.Label()
        ExDateLabel = New System.Windows.Forms.Label()
        ArtworkLocationLabel = New System.Windows.Forms.Label()
        SpecialBackNeckReferenceLabel = New System.Windows.Forms.Label()
        ApplicationLabel = New System.Windows.Forms.Label()
        PrintSizeLabel = New System.Windows.Forms.Label()
        WidthLabel = New System.Windows.Forms.Label()
        HeightLabel = New System.Windows.Forms.Label()
        PrintPositionLabel = New System.Windows.Forms.Label()
        MesurementLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        SendPhotoStrikeOffLabel1 = New System.Windows.Forms.Label()
        PrintTypeIdLabel = New System.Windows.Forms.Label()
        BuyerIdLabel = New System.Windows.Forms.Label()
        GMDepartmentIdLabel = New System.Windows.Forms.Label()
        DevTypeIdLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        MasterProgramNoLabel = New System.Windows.Forms.Label()
        SampleSendDateLabel = New System.Windows.Forms.Label()
        SendingInfoLabel = New System.Windows.Forms.Label()
        CommentsReceiveDateLabel = New System.Windows.Forms.Label()
        ApprovalStatusLabel = New System.Windows.Forms.Label()
        StyleTypeLabel1 = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.SampleRequestFinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtworkLocationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecialBackNeckReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintSizeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintPositionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesurementSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.SampleRequestFinalDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestFinalDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestFinalDetailsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Composition2GridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SampleFabricDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnAllocationSampleGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnAllocationSampleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SamplePrintColorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SamplePrintColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.SampleRequireQuantityDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequireQuantityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRLookupByDivUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SendPhotoStrikeOffCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsEmbroideryCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbroideryDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsTrimCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrimDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StyleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsTrimAvailableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExTrimRcvDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExTrimRcvDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovalStatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SendingInfoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleSendDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleSendDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsDescriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleUpdateCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsWashCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPeachFinishCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsBrushCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsAOPCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsYDSCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsSequnceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsSublimationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleLabel
        '
        StyleLabel.AutoSize = True
        StyleLabel.ForeColor = System.Drawing.Color.Black
        StyleLabel.Location = New System.Drawing.Point(282, 187)
        StyleLabel.Name = "StyleLabel"
        StyleLabel.Size = New System.Drawing.Size(64, 13)
        StyleLabel.TabIndex = 27
        StyleLabel.Text = "Style (OLD):"
        StyleLabel.Visible = False
        '
        'GarmentsDescriptionLabel
        '
        GarmentsDescriptionLabel.AutoSize = True
        GarmentsDescriptionLabel.Location = New System.Drawing.Point(19, 217)
        GarmentsDescriptionLabel.Name = "GarmentsDescriptionLabel"
        GarmentsDescriptionLabel.Size = New System.Drawing.Size(111, 13)
        GarmentsDescriptionLabel.TabIndex = 20
        GarmentsDescriptionLabel.Text = "Garments Description:"
        '
        'RequestDateLabel
        '
        RequestDateLabel.AutoSize = True
        RequestDateLabel.Location = New System.Drawing.Point(307, 24)
        RequestDateLabel.Name = "RequestDateLabel"
        RequestDateLabel.Size = New System.Drawing.Size(93, 13)
        RequestDateLabel.TabIndex = 25
        RequestDateLabel.Text = "SP Request Date:"
        '
        'ExDateLabel
        '
        ExDateLabel.AutoSize = True
        ExDateLabel.ForeColor = System.Drawing.Color.Black
        ExDateLabel.Location = New System.Drawing.Point(307, 48)
        ExDateLabel.Name = "ExDateLabel"
        ExDateLabel.Size = New System.Drawing.Size(103, 13)
        ExDateLabel.TabIndex = 28
        ExDateLabel.Text = "Samp Require  Date"
        '
        'ArtworkLocationLabel
        '
        ArtworkLocationLabel.AutoSize = True
        ArtworkLocationLabel.Location = New System.Drawing.Point(259, 83)
        ArtworkLocationLabel.Name = "ArtworkLocationLabel"
        ArtworkLocationLabel.Size = New System.Drawing.Size(90, 13)
        ArtworkLocationLabel.TabIndex = 17
        ArtworkLocationLabel.Text = "Artwork Location:"
        '
        'SpecialBackNeckReferenceLabel
        '
        SpecialBackNeckReferenceLabel.AutoSize = True
        SpecialBackNeckReferenceLabel.Location = New System.Drawing.Point(259, 109)
        SpecialBackNeckReferenceLabel.Name = "SpecialBackNeckReferenceLabel"
        SpecialBackNeckReferenceLabel.Size = New System.Drawing.Size(125, 13)
        SpecialBackNeckReferenceLabel.TabIndex = 18
        SpecialBackNeckReferenceLabel.Text = "Special Back Neck Ref :"
        '
        'ApplicationLabel
        '
        ApplicationLabel.AutoSize = True
        ApplicationLabel.Location = New System.Drawing.Point(259, 135)
        ApplicationLabel.Name = "ApplicationLabel"
        ApplicationLabel.Size = New System.Drawing.Size(62, 13)
        ApplicationLabel.TabIndex = 19
        ApplicationLabel.Text = "Application:"
        '
        'PrintSizeLabel
        '
        PrintSizeLabel.AutoSize = True
        PrintSizeLabel.Location = New System.Drawing.Point(16, 57)
        PrintSizeLabel.Name = "PrintSizeLabel"
        PrintSizeLabel.Size = New System.Drawing.Size(54, 13)
        PrintSizeLabel.TabIndex = 12
        PrintSizeLabel.Text = "Print Size:"
        '
        'WidthLabel
        '
        WidthLabel.AutoSize = True
        WidthLabel.Location = New System.Drawing.Point(16, 83)
        WidthLabel.Name = "WidthLabel"
        WidthLabel.Size = New System.Drawing.Size(38, 13)
        WidthLabel.TabIndex = 13
        WidthLabel.Text = "Width:"
        '
        'HeightLabel
        '
        HeightLabel.AutoSize = True
        HeightLabel.Location = New System.Drawing.Point(16, 109)
        HeightLabel.Name = "HeightLabel"
        HeightLabel.Size = New System.Drawing.Size(41, 13)
        HeightLabel.TabIndex = 14
        HeightLabel.Text = "Height:"
        '
        'PrintPositionLabel
        '
        PrintPositionLabel.AutoSize = True
        PrintPositionLabel.Location = New System.Drawing.Point(259, 31)
        PrintPositionLabel.Name = "PrintPositionLabel"
        PrintPositionLabel.Size = New System.Drawing.Size(71, 13)
        PrintPositionLabel.TabIndex = 15
        PrintPositionLabel.Text = "Print Position:"
        '
        'MesurementLabel
        '
        MesurementLabel.AutoSize = True
        MesurementLabel.Location = New System.Drawing.Point(259, 57)
        MesurementLabel.Name = "MesurementLabel"
        MesurementLabel.Size = New System.Drawing.Size(68, 13)
        MesurementLabel.TabIndex = 16
        MesurementLabel.Text = "Mesurement:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(19, 255)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(55, 13)
        RemarksLabel.TabIndex = 24
        RemarksLabel.Text = "Remarks :"
        '
        'SendPhotoStrikeOffLabel1
        '
        SendPhotoStrikeOffLabel1.AutoSize = True
        SendPhotoStrikeOffLabel1.Location = New System.Drawing.Point(16, 136)
        SendPhotoStrikeOffLabel1.Name = "SendPhotoStrikeOffLabel1"
        SendPhotoStrikeOffLabel1.Size = New System.Drawing.Size(113, 13)
        SendPhotoStrikeOffLabel1.TabIndex = 20
        SendPhotoStrikeOffLabel1.Text = "Send Photo Strike Off:"
        '
        'PrintTypeIdLabel
        '
        PrintTypeIdLabel.AutoSize = True
        PrintTypeIdLabel.Location = New System.Drawing.Point(17, 32)
        PrintTypeIdLabel.Name = "PrintTypeIdLabel"
        PrintTypeIdLabel.Size = New System.Drawing.Size(61, 13)
        PrintTypeIdLabel.TabIndex = 11
        PrintTypeIdLabel.Text = "Print Type :"
        '
        'BuyerIdLabel
        '
        BuyerIdLabel.AutoSize = True
        BuyerIdLabel.Location = New System.Drawing.Point(17, 147)
        BuyerIdLabel.Name = "BuyerIdLabel"
        BuyerIdLabel.Size = New System.Drawing.Size(37, 13)
        BuyerIdLabel.TabIndex = 26
        BuyerIdLabel.Text = "Buyer:"
        '
        'GMDepartmentIdLabel
        '
        GMDepartmentIdLabel.AutoSize = True
        GMDepartmentIdLabel.Location = New System.Drawing.Point(307, 73)
        GMDepartmentIdLabel.Name = "GMDepartmentIdLabel"
        GMDepartmentIdLabel.Size = New System.Drawing.Size(50, 13)
        GMDepartmentIdLabel.TabIndex = 19
        GMDepartmentIdLabel.Text = "Division :"
        '
        'DevTypeIdLabel
        '
        DevTypeIdLabel.AutoSize = True
        DevTypeIdLabel.Location = New System.Drawing.Point(17, 73)
        DevTypeIdLabel.Name = "DevTypeIdLabel"
        DevTypeIdLabel.Size = New System.Drawing.Size(60, 13)
        DevTypeIdLabel.TabIndex = 30
        DevTypeIdLabel.Text = "Dev Type :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(893, 60)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(81, 13)
        Label2.TabIndex = 33
        Label2.Text = "Division [OLD] :"
        Label2.Visible = False
        '
        'MasterProgramNoLabel
        '
        MasterProgramNoLabel.AutoSize = True
        MasterProgramNoLabel.Location = New System.Drawing.Point(17, 24)
        MasterProgramNoLabel.Name = "MasterProgramNoLabel"
        MasterProgramNoLabel.Size = New System.Drawing.Size(101, 13)
        MasterProgramNoLabel.TabIndex = 36
        MasterProgramNoLabel.Text = "Master Program No:"
        '
        'SampleSendDateLabel
        '
        SampleSendDateLabel.AutoSize = True
        SampleSendDateLabel.Location = New System.Drawing.Point(16, 193)
        SampleSendDateLabel.Name = "SampleSendDateLabel"
        SampleSendDateLabel.Size = New System.Drawing.Size(99, 13)
        SampleSendDateLabel.TabIndex = 38
        SampleSendDateLabel.Text = "Sample Send Date:"
        '
        'SendingInfoLabel
        '
        SendingInfoLabel.AutoSize = True
        SendingInfoLabel.Location = New System.Drawing.Point(307, 120)
        SendingInfoLabel.Name = "SendingInfoLabel"
        SendingInfoLabel.Size = New System.Drawing.Size(70, 13)
        SendingInfoLabel.TabIndex = 39
        SendingInfoLabel.Text = "Sending Info:"
        '
        'CommentsReceiveDateLabel
        '
        CommentsReceiveDateLabel.AutoSize = True
        CommentsReceiveDateLabel.Location = New System.Drawing.Point(16, 169)
        CommentsReceiveDateLabel.Name = "CommentsReceiveDateLabel"
        CommentsReceiveDateLabel.Size = New System.Drawing.Size(128, 13)
        CommentsReceiveDateLabel.TabIndex = 40
        CommentsReceiveDateLabel.Text = "Comments Receive Date:"
        '
        'ApprovalStatusLabel
        '
        ApprovalStatusLabel.AutoSize = True
        ApprovalStatusLabel.Location = New System.Drawing.Point(307, 142)
        ApprovalStatusLabel.Name = "ApprovalStatusLabel"
        ApprovalStatusLabel.Size = New System.Drawing.Size(85, 13)
        ApprovalStatusLabel.TabIndex = 41
        ApprovalStatusLabel.Text = "Approval Status:"
        '
        'StyleTypeLabel1
        '
        StyleTypeLabel1.AutoSize = True
        StyleTypeLabel1.Location = New System.Drawing.Point(307, 166)
        StyleTypeLabel1.Name = "StyleTypeLabel1"
        StyleTypeLabel1.Size = New System.Drawing.Size(60, 13)
        StyleTypeLabel1.TabIndex = 43
        StyleTypeLabel1.Text = "Style Type:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(306, 94)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(38, 13)
        BrandLabel.TabIndex = 47
        BrandLabel.Text = "Brand:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(16, 121)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(67, 13)
        Label1.TabIndex = 49
        Label1.Text = "Style Name :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(304, 193)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(107, 13)
        Label4.TabIndex = 14
        Label4.Text = "Sample Require Qty :"
        AddHandler Label4.Click, AddressOf Me.Label4_Click
        '
        'SampleRequestFinalBindingSource
        '
        Me.SampleRequestFinalBindingSource.DataMember = "SampleRequestFinal"
        Me.SampleRequestFinalBindingSource.DataSource = Me.SampleRequestDataSet
        '
        'SampleRequestDataSet
        '
        Me.SampleRequestDataSet.DataSetName = "SampleRequestDataSet"
        Me.SampleRequestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequestNoTextEdit
        '
        Me.RequestNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "RequestNo", True))
        Me.RequestNoTextEdit.Location = New System.Drawing.Point(143, 45)
        Me.RequestNoTextEdit.Name = "RequestNoTextEdit"
        Me.RequestNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RequestNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.RequestNoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RequestNoTextEdit.Properties.ReadOnly = True
        Me.RequestNoTextEdit.Size = New System.Drawing.Size(122, 20)
        Me.RequestNoTextEdit.TabIndex = 1
        '
        'RequestDateDateEdit
        '
        Me.RequestDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "RequestDate", True))
        Me.RequestDateDateEdit.EditValue = Nothing
        Me.RequestDateDateEdit.Location = New System.Drawing.Point(416, 21)
        Me.RequestDateDateEdit.Name = "RequestDateDateEdit"
        Me.RequestDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequestDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RequestDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.RequestDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RequestDateDateEdit.Properties.Mask.EditMask = "dd-MMM-yy"
        Me.RequestDateDateEdit.Size = New System.Drawing.Size(118, 20)
        Me.RequestDateDateEdit.TabIndex = 3
        '
        'ExDateDateEdit
        '
        Me.ExDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleRequireDate", True))
        Me.ExDateDateEdit.EditValue = Nothing
        Me.ExDateDateEdit.Location = New System.Drawing.Point(416, 44)
        Me.ExDateDateEdit.Name = "ExDateDateEdit"
        Me.ExDateDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.ExDateDateEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ExDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ExDateDateEdit.Size = New System.Drawing.Size(118, 20)
        Me.ExDateDateEdit.TabIndex = 4
        '
        'ArtworkLocationTextEdit
        '
        Me.ArtworkLocationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "ArtworkLocation", True))
        Me.ArtworkLocationTextEdit.Location = New System.Drawing.Point(415, 81)
        Me.ArtworkLocationTextEdit.Name = "ArtworkLocationTextEdit"
        Me.ArtworkLocationTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ArtworkLocationTextEdit.TabIndex = 7
        '
        'SpecialBackNeckReferenceTextEdit
        '
        Me.SpecialBackNeckReferenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SpecialBackNeckReference", True))
        Me.SpecialBackNeckReferenceTextEdit.Location = New System.Drawing.Point(415, 107)
        Me.SpecialBackNeckReferenceTextEdit.Name = "SpecialBackNeckReferenceTextEdit"
        Me.SpecialBackNeckReferenceTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.SpecialBackNeckReferenceTextEdit.TabIndex = 8
        '
        'ApplicationTextEdit
        '
        Me.ApplicationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Application", True))
        Me.ApplicationTextEdit.Location = New System.Drawing.Point(415, 133)
        Me.ApplicationTextEdit.Name = "ApplicationTextEdit"
        Me.ApplicationTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ApplicationTextEdit.TabIndex = 9
        '
        'PrintSizeTextEdit
        '
        Me.PrintSizeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "PrintSize", True))
        Me.PrintSizeTextEdit.Location = New System.Drawing.Point(153, 54)
        Me.PrintSizeTextEdit.Name = "PrintSizeTextEdit"
        Me.PrintSizeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PrintSizeTextEdit.TabIndex = 2
        '
        'WidthSpinEdit
        '
        Me.WidthSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Width", True))
        Me.WidthSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.WidthSpinEdit.Location = New System.Drawing.Point(153, 80)
        Me.WidthSpinEdit.Name = "WidthSpinEdit"
        Me.WidthSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.WidthSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.WidthSpinEdit.TabIndex = 3
        '
        'HeightSpinEdit
        '
        Me.HeightSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Height", True))
        Me.HeightSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.HeightSpinEdit.Location = New System.Drawing.Point(153, 106)
        Me.HeightSpinEdit.Name = "HeightSpinEdit"
        Me.HeightSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.HeightSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.HeightSpinEdit.TabIndex = 4
        '
        'PrintPositionTextEdit
        '
        Me.PrintPositionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "PrintPosition", True))
        Me.PrintPositionTextEdit.Location = New System.Drawing.Point(415, 29)
        Me.PrintPositionTextEdit.Name = "PrintPositionTextEdit"
        Me.PrintPositionTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PrintPositionTextEdit.TabIndex = 5
        '
        'MesurementSpinEdit
        '
        Me.MesurementSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Mesurement", True))
        Me.MesurementSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MesurementSpinEdit.Location = New System.Drawing.Point(415, 55)
        Me.MesurementSpinEdit.Name = "MesurementSpinEdit"
        Me.MesurementSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MesurementSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.MesurementSpinEdit.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 371)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1270, 285)
        Me.TabControl1.TabIndex = 3
        Me.TabControl1.Tag = "NR"
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.CopyButton)
        Me.TabPage4.Controls.Add(Me.SampleRequestFinalDetailsGridControl)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1262, 256)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Sample Color Details [For Body Only]"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyButton.Location = New System.Drawing.Point(1156, 3)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(89, 23)
        Me.CopyButton.TabIndex = 1
        Me.CopyButton.Text = "Copy"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'SampleRequestFinalDetailsGridControl
        '
        Me.SampleRequestFinalDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleRequestFinalDetailsGridControl.DataSource = Me.SampleRequestFinalDetailsBindingSource
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.SampleRequestFinalDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.SampleRequestFinalDetailsGridControl.Location = New System.Drawing.Point(3, 28)
        Me.SampleRequestFinalDetailsGridControl.MainView = Me.SampleRequestFinalDetailsGridView
        Me.SampleRequestFinalDetailsGridControl.Name = "SampleRequestFinalDetailsGridControl"
        Me.SampleRequestFinalDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ColorItemGridLookUpEdit, Me.RepositoryItemButtonEdit1, Me.FabricColorGridLookUpEdit, Me.KnittingTypeGridLookUpEdit, Me.Composition2GridLookUpEdit})
        Me.SampleRequestFinalDetailsGridControl.Size = New System.Drawing.Size(1256, 225)
        Me.SampleRequestFinalDetailsGridControl.TabIndex = 0
        Me.SampleRequestFinalDetailsGridControl.UseEmbeddedNavigator = True
        Me.SampleRequestFinalDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SampleRequestFinalDetailsGridView})
        '
        'SampleRequestFinalDetailsBindingSource
        '
        Me.SampleRequestFinalDetailsBindingSource.DataMember = "SampleRequestFinal_SampleRequestFinalDetails"
        Me.SampleRequestFinalDetailsBindingSource.DataSource = Me.SampleRequestFinalBindingSource
        '
        'SampleRequestFinalDetailsGridView
        '
        Me.SampleRequestFinalDetailsGridView.ColumnPanelRowHeight = 40
        Me.SampleRequestFinalDetailsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSampleRequestDetailsId, Me.colSampleRequestId2, Me.colKnittingTypeId1, Me.colCompositionId1, Me.colGSM, Me.colIsFabricAvailable, Me.colColor, Me.colELD, Me.colSampleSendDate, Me.colIsSealed, Me.colSealedDate, Me.colAgreedLeadTime, Me.colExFabricRcvDate, Me.colIsAOP, Me.colIsYDS, Me.colExSendDate, Me.colFabricColorId, Me.colRemarks, Me.colIsCancel, Me.colCancelReason})
        Me.SampleRequestFinalDetailsGridView.GridControl = Me.SampleRequestFinalDetailsGridControl
        Me.SampleRequestFinalDetailsGridView.Name = "SampleRequestFinalDetailsGridView"
        Me.SampleRequestFinalDetailsGridView.OptionsCustomization.AllowGroup = False
        Me.SampleRequestFinalDetailsGridView.OptionsView.ColumnAutoWidth = False
        Me.SampleRequestFinalDetailsGridView.OptionsView.ShowGroupPanel = False
        '
        'colSampleRequestDetailsId
        '
        Me.colSampleRequestDetailsId.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleRequestDetailsId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleRequestDetailsId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleRequestDetailsId.FieldName = "SampleRequestDetailsId"
        Me.colSampleRequestDetailsId.Name = "colSampleRequestDetailsId"
        Me.colSampleRequestDetailsId.OptionsColumn.ReadOnly = True
        '
        'colSampleRequestId2
        '
        Me.colSampleRequestId2.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleRequestId2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleRequestId2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleRequestId2.FieldName = "SampleRequestId"
        Me.colSampleRequestId2.Name = "colSampleRequestId2"
        Me.colSampleRequestId2.Width = 133
        '
        'colKnittingTypeId1
        '
        Me.colKnittingTypeId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colKnittingTypeId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKnittingTypeId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colKnittingTypeId1.Caption = "Fabric Type"
        Me.colKnittingTypeId1.ColumnEdit = Me.KnittingTypeGridLookUpEdit
        Me.colKnittingTypeId1.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId1.Name = "colKnittingTypeId1"
        Me.colKnittingTypeId1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colKnittingTypeId1.Visible = True
        Me.colKnittingTypeId1.VisibleIndex = 2
        Me.colKnittingTypeId1.Width = 82
        '
        'KnittingTypeGridLookUpEdit
        '
        Me.KnittingTypeGridLookUpEdit.AutoHeight = False
        Me.KnittingTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KnittingTypeGridLookUpEdit.DataSource = Me.KnittingTypeBindingSource
        Me.KnittingTypeGridLookUpEdit.DisplayMember = "KnittingType"
        Me.KnittingTypeGridLookUpEdit.Name = "KnittingTypeGridLookUpEdit"
        Me.KnittingTypeGridLookUpEdit.PopupView = Me.GridView7
        Me.KnittingTypeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.KnittingTypeGridLookUpEdit.ValueMember = "KnittingTypeId"
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
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingType})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colKnittingType
        '
        Me.colKnittingType.FieldName = "KnittingType"
        Me.colKnittingType.Name = "colKnittingType"
        Me.colKnittingType.Visible = True
        Me.colKnittingType.VisibleIndex = 0
        '
        'colCompositionId1
        '
        Me.colCompositionId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompositionId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompositionId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompositionId1.Caption = "Composition"
        Me.colCompositionId1.ColumnEdit = Me.Composition2GridLookUpEdit
        Me.colCompositionId1.FieldName = "CompositionId"
        Me.colCompositionId1.Name = "colCompositionId1"
        Me.colCompositionId1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List
        Me.colCompositionId1.Visible = True
        Me.colCompositionId1.VisibleIndex = 3
        Me.colCompositionId1.Width = 98
        '
        'Composition2GridLookUpEdit
        '
        Me.Composition2GridLookUpEdit.AutoHeight = False
        Me.Composition2GridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Composition2GridLookUpEdit.DataSource = Me.CompositionBindingSource
        Me.Composition2GridLookUpEdit.DisplayMember = "Composition"
        Me.Composition2GridLookUpEdit.Name = "Composition2GridLookUpEdit"
        Me.Composition2GridLookUpEdit.NullText = ""
        Me.Composition2GridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.Composition2GridLookUpEdit.PopupView = Me.GridView8
        Me.Composition2GridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Composition2GridLookUpEdit.ValueMember = "CompositionId"
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
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colComposition})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colComposition
        '
        Me.colComposition.FieldName = "Composition"
        Me.colComposition.Name = "colComposition"
        Me.colComposition.Visible = True
        Me.colComposition.VisibleIndex = 0
        '
        'colGSM
        '
        Me.colGSM.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSM.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSM.FieldName = "GSM"
        Me.colGSM.Name = "colGSM"
        Me.colGSM.Visible = True
        Me.colGSM.VisibleIndex = 4
        Me.colGSM.Width = 54
        '
        'colIsFabricAvailable
        '
        Me.colIsFabricAvailable.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsFabricAvailable.AppearanceCell.Options.UseBackColor = True
        Me.colIsFabricAvailable.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsFabricAvailable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsFabricAvailable.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsFabricAvailable.Caption = "Fabric Available"
        Me.colIsFabricAvailable.FieldName = "IsFabricAvailable"
        Me.colIsFabricAvailable.Name = "colIsFabricAvailable"
        Me.colIsFabricAvailable.Visible = True
        Me.colIsFabricAvailable.VisibleIndex = 7
        Me.colIsFabricAvailable.Width = 76
        '
        'colColor
        '
        Me.colColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColor.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colColor.Caption = "Color(OLD)"
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Width = 151
        '
        'colELD
        '
        Me.colELD.AppearanceHeader.Options.UseTextOptions = True
        Me.colELD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colELD.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colELD.Caption = "Color Reference"
        Me.colELD.FieldName = "ELD"
        Me.colELD.Name = "colELD"
        Me.colELD.Visible = True
        Me.colELD.VisibleIndex = 1
        Me.colELD.Width = 98
        '
        'colSampleSendDate
        '
        Me.colSampleSendDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSampleSendDate.AppearanceCell.Options.UseBackColor = True
        Me.colSampleSendDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSampleSendDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSampleSendDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSampleSendDate.FieldName = "SampleSendDate"
        Me.colSampleSendDate.Name = "colSampleSendDate"
        Me.colSampleSendDate.Visible = True
        Me.colSampleSendDate.VisibleIndex = 11
        Me.colSampleSendDate.Width = 78
        '
        'colIsSealed
        '
        Me.colIsSealed.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsSealed.AppearanceCell.Options.UseBackColor = True
        Me.colIsSealed.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsSealed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsSealed.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsSealed.FieldName = "IsSealed"
        Me.colIsSealed.Name = "colIsSealed"
        Me.colIsSealed.Visible = True
        Me.colIsSealed.VisibleIndex = 12
        Me.colIsSealed.Width = 56
        '
        'colSealedDate
        '
        Me.colSealedDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSealedDate.AppearanceCell.Options.UseBackColor = True
        Me.colSealedDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colSealedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSealedDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSealedDate.FieldName = "SealedDate"
        Me.colSealedDate.Name = "colSealedDate"
        Me.colSealedDate.Visible = True
        Me.colSealedDate.VisibleIndex = 13
        Me.colSealedDate.Width = 72
        '
        'colAgreedLeadTime
        '
        Me.colAgreedLeadTime.AppearanceHeader.Options.UseTextOptions = True
        Me.colAgreedLeadTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAgreedLeadTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAgreedLeadTime.FieldName = "AgreedLeadTime"
        Me.colAgreedLeadTime.Name = "colAgreedLeadTime"
        Me.colAgreedLeadTime.Visible = True
        Me.colAgreedLeadTime.VisibleIndex = 9
        Me.colAgreedLeadTime.Width = 87
        '
        'colExFabricRcvDate
        '
        Me.colExFabricRcvDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colExFabricRcvDate.AppearanceCell.Options.UseBackColor = True
        Me.colExFabricRcvDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExFabricRcvDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExFabricRcvDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExFabricRcvDate.FieldName = "ExFabricRcvDate"
        Me.colExFabricRcvDate.Name = "colExFabricRcvDate"
        Me.colExFabricRcvDate.Visible = True
        Me.colExFabricRcvDate.VisibleIndex = 8
        Me.colExFabricRcvDate.Width = 78
        '
        'colIsAOP
        '
        Me.colIsAOP.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsAOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsAOP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsAOP.Caption = "AOP"
        Me.colIsAOP.FieldName = "IsAOP"
        Me.colIsAOP.Name = "colIsAOP"
        Me.colIsAOP.Visible = True
        Me.colIsAOP.VisibleIndex = 6
        Me.colIsAOP.Width = 41
        '
        'colIsYDS
        '
        Me.colIsYDS.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsYDS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsYDS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsYDS.Caption = "YDS"
        Me.colIsYDS.FieldName = "IsYDS"
        Me.colIsYDS.Name = "colIsYDS"
        Me.colIsYDS.Visible = True
        Me.colIsYDS.VisibleIndex = 5
        Me.colIsYDS.Width = 43
        '
        'colExSendDate
        '
        Me.colExSendDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colExSendDate.AppearanceCell.Options.UseBackColor = True
        Me.colExSendDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colExSendDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExSendDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colExSendDate.FieldName = "ExSendDate"
        Me.colExSendDate.Name = "colExSendDate"
        Me.colExSendDate.Visible = True
        Me.colExSendDate.VisibleIndex = 10
        Me.colExSendDate.Width = 77
        '
        'colFabricColorId
        '
        Me.colFabricColorId.Caption = "Garments Color (F11)"
        Me.colFabricColorId.ColumnEdit = Me.FabricColorGridLookUpEdit
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 0
        Me.colFabricColorId.Width = 145
        '
        'FabricColorGridLookUpEdit
        '
        Me.FabricColorGridLookUpEdit.AutoHeight = False
        Me.FabricColorGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricColorGridLookUpEdit.DataSource = Me.FabricColorBindingSource
        Me.FabricColorGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.FabricColorGridLookUpEdit.Name = "FabricColorGridLookUpEdit"
        Me.FabricColorGridLookUpEdit.NullText = ""
        Me.FabricColorGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FabricColorGridLookUpEdit.PopupView = Me.GridView1
        Me.FabricColorGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricColorGridLookUpEdit.ValueMember = "FabricColorId"
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
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "FabricColorName"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 16
        '
        'colIsCancel
        '
        Me.colIsCancel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsCancel.AppearanceCell.Options.UseBackColor = True
        Me.colIsCancel.FieldName = "IsCancel"
        Me.colIsCancel.Name = "colIsCancel"
        Me.colIsCancel.Visible = True
        Me.colIsCancel.VisibleIndex = 14
        '
        'colCancelReason
        '
        Me.colCancelReason.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCancelReason.AppearanceCell.Options.UseBackColor = True
        Me.colCancelReason.FieldName = "CancelReason"
        Me.colCancelReason.Name = "colCancelReason"
        Me.colCancelReason.Visible = True
        Me.colCancelReason.VisibleIndex = 15
        Me.colCancelReason.Width = 107
        '
        'ColorItemGridLookUpEdit
        '
        Me.ColorItemGridLookUpEdit.AutoHeight = False
        Me.ColorItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorItemGridLookUpEdit.DataSource = Me.FabricColorBindingSource
        Me.ColorItemGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.ColorItemGridLookUpEdit.Name = "ColorItemGridLookUpEdit"
        Me.ColorItemGridLookUpEdit.NullText = ""
        Me.ColorItemGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ColorItemGridLookUpEdit.PopupView = Me.GridView4
        Me.ColorItemGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ColorItemGridLookUpEdit.ValueMember = "FabricColorId"
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorId1, Me.colFabricColorName})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorId1
        '
        Me.colFabricColorId1.FieldName = "FabricColorId"
        Me.colFabricColorId1.Name = "colFabricColorId1"
        Me.colFabricColorId1.OptionsColumn.ReadOnly = True
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1262, 256)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fabric Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CopyFabricButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SampleFabricDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GetDataLinkLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.YarnAllocationSampleGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1256, 250)
        Me.SplitContainer1.SplitterDistance = 141
        Me.SplitContainer1.TabIndex = 2
        '
        'CopyFabricButton
        '
        Me.CopyFabricButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyFabricButton.Location = New System.Drawing.Point(1164, 2)
        Me.CopyFabricButton.Name = "CopyFabricButton"
        Me.CopyFabricButton.Size = New System.Drawing.Size(89, 23)
        Me.CopyFabricButton.TabIndex = 2
        Me.CopyFabricButton.Text = "Copy"
        Me.CopyFabricButton.UseVisualStyleBackColor = True
        '
        'SampleFabricDataGridView
        '
        Me.SampleFabricDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleFabricDataGridView.AutoGenerateColumns = False
        Me.SampleFabricDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SampleFabricDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SampleFabricDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.SPNote, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DUnit, Me.DataGridViewTextBoxColumn10, Me.Length, Me.Consumption, Me.BookingQuantity, Me.DataGridViewTextBoxColumn11, Me.KgPerUnit, Me.GreyPercentage, Me.GreyQuantity, Me.IsDelivered, Me.DeliveredDate, Me.PrintSend, Me.PrintReceived, Me.Status, Me.IsFabricAvailable, Me.Remarks})
        Me.SampleFabricDataGridView.DataSource = Me.SampleFabricBindingSource
        Me.SampleFabricDataGridView.Location = New System.Drawing.Point(0, 26)
        Me.SampleFabricDataGridView.Name = "SampleFabricDataGridView"
        Me.SampleFabricDataGridView.ReadOnly = True
        Me.SampleFabricDataGridView.Size = New System.Drawing.Size(1253, 115)
        Me.SampleFabricDataGridView.TabIndex = 0
        Me.SampleFabricDataGridView.Tag = "NR"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FabricColorName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fabric Color"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ELD"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NLD"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "GarmentsPartId"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.GarmentsPartBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn5.HeaderText = "Garments Part"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "GarmentsPartId"
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
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "KnittingTypeId"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.KnittingTypeBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "KnittingType"
        Me.DataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fabric Type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "KnittingTypeId"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CompositionId"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.CompositionBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "Composition"
        Me.DataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn7.HeaderText = "Composition"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "CompositionId"
        '
        'SPNote
        '
        Me.SPNote.DataPropertyName = "SPNote"
        Me.SPNote.HeaderText = "SPNote"
        Me.SPNote.Name = "SPNote"
        Me.SPNote.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FGSM"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.GSMBindingSource
        Me.DataGridViewTextBoxColumn8.DisplayMember = "GSM"
        Me.DataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn8.HeaderText = "FGSM"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "GSM"
        Me.DataGridViewTextBoxColumn8.Width = 50
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
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Dia"
        DataGridViewCellStyle1.Format = "n2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn9.HeaderText = "Dia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DUnit
        '
        Me.DUnit.DataPropertyName = "DUnit"
        Me.DUnit.HeaderText = "DUnit"
        Me.DUnit.Name = "DUnit"
        Me.DUnit.ReadOnly = True
        Me.DUnit.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DiaType"
        Me.DataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn10.HeaderText = "DiaType"
        Me.DataGridViewTextBoxColumn10.Items.AddRange(New Object() {"Open", "Tube"})
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Length
        '
        Me.Length.DataPropertyName = "Length"
        Me.Length.HeaderText = "Length"
        Me.Length.Name = "Length"
        Me.Length.ReadOnly = True
        Me.Length.Width = 50
        '
        'Consumption
        '
        Me.Consumption.DataPropertyName = "Consumption"
        DataGridViewCellStyle2.Format = "n2"
        Me.Consumption.DefaultCellStyle = DataGridViewCellStyle2
        Me.Consumption.HeaderText = "Consumption"
        Me.Consumption.Name = "Consumption"
        Me.Consumption.ReadOnly = True
        '
        'BookingQuantity
        '
        Me.BookingQuantity.DataPropertyName = "BookingQuantity"
        Me.BookingQuantity.HeaderText = "Booking Quantity"
        Me.BookingQuantity.Name = "BookingQuantity"
        Me.BookingQuantity.ReadOnly = True
        Me.BookingQuantity.Width = 80
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FinishUnit"
        Me.DataGridViewTextBoxColumn11.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn11.HeaderText = "Finish Unit"
        Me.DataGridViewTextBoxColumn11.Items.AddRange(New Object() {"Kg", "Yrds", "Mtr", "Pcs"})
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'KgPerUnit
        '
        Me.KgPerUnit.DataPropertyName = "KgPerUnit"
        Me.KgPerUnit.HeaderText = "KgPerUnit"
        Me.KgPerUnit.Name = "KgPerUnit"
        Me.KgPerUnit.ReadOnly = True
        '
        'GreyPercentage
        '
        Me.GreyPercentage.DataPropertyName = "GreyPercentage"
        Me.GreyPercentage.HeaderText = "Grey Percentage"
        Me.GreyPercentage.Name = "GreyPercentage"
        Me.GreyPercentage.ReadOnly = True
        Me.GreyPercentage.Width = 50
        '
        'GreyQuantity
        '
        Me.GreyQuantity.DataPropertyName = "GreyQuantity"
        Me.GreyQuantity.HeaderText = "Grey Quantity"
        Me.GreyQuantity.Name = "GreyQuantity"
        Me.GreyQuantity.ReadOnly = True
        Me.GreyQuantity.Width = 50
        '
        'IsDelivered
        '
        Me.IsDelivered.DataPropertyName = "IsDelivered"
        Me.IsDelivered.HeaderText = "IsReceived"
        Me.IsDelivered.Name = "IsDelivered"
        Me.IsDelivered.ReadOnly = True
        '
        'DeliveredDate
        '
        Me.DeliveredDate.DataPropertyName = "DeliveredDate"
        DataGridViewCellStyle3.Format = "dd-MMM-yy"
        Me.DeliveredDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.DeliveredDate.HeaderText = "Received Date"
        Me.DeliveredDate.Name = "DeliveredDate"
        Me.DeliveredDate.ReadOnly = True
        '
        'PrintSend
        '
        Me.PrintSend.DataPropertyName = "PrintSend"
        DataGridViewCellStyle4.Format = "dd-MMM-yy"
        Me.PrintSend.DefaultCellStyle = DataGridViewCellStyle4
        Me.PrintSend.HeaderText = "Print Send"
        Me.PrintSend.Name = "PrintSend"
        Me.PrintSend.ReadOnly = True
        '
        'PrintReceived
        '
        Me.PrintReceived.DataPropertyName = "PrintReceived"
        DataGridViewCellStyle5.Format = "dd-MMM-yy"
        Me.PrintReceived.DefaultCellStyle = DataGridViewCellStyle5
        Me.PrintReceived.HeaderText = "Print Received"
        Me.PrintReceived.Name = "PrintReceived"
        Me.PrintReceived.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Items.AddRange(New Object() {"Pending", "Received", "Send to Print", "Received from Print", ""})
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'IsFabricAvailable
        '
        Me.IsFabricAvailable.DataPropertyName = "IsFabricAvailable"
        Me.IsFabricAvailable.HeaderText = "IsFabricAvailable"
        Me.IsFabricAvailable.Name = "IsFabricAvailable"
        Me.IsFabricAvailable.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'SampleFabricBindingSource
        '
        Me.SampleFabricBindingSource.DataMember = "FK_SampleFabric_SampleRequestFinal"
        Me.SampleFabricBindingSource.DataSource = Me.SampleRequestFinalBindingSource
        '
        'GetDataLinkLabel
        '
        Me.GetDataLinkLabel.AutoSize = True
        Me.GetDataLinkLabel.Location = New System.Drawing.Point(3, 7)
        Me.GetDataLinkLabel.Name = "GetDataLinkLabel"
        Me.GetDataLinkLabel.Size = New System.Drawing.Size(280, 13)
        Me.GetDataLinkLabel.TabIndex = 1
        Me.GetDataLinkLabel.TabStop = True
        Me.GetDataLinkLabel.Text = "Get From Sample Color Details  [ Exclude available fabric ]"
        '
        'YarnAllocationSampleGridControl
        '
        Me.YarnAllocationSampleGridControl.DataSource = Me.YarnAllocationSampleBindingSource
        Me.YarnAllocationSampleGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.YarnAllocationSampleGridControl.Enabled = False
        Me.YarnAllocationSampleGridControl.Location = New System.Drawing.Point(0, 0)
        Me.YarnAllocationSampleGridControl.MainView = Me.GridView5
        Me.YarnAllocationSampleGridControl.Name = "YarnAllocationSampleGridControl"
        Me.YarnAllocationSampleGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemNameGridLookUpEdit})
        Me.YarnAllocationSampleGridControl.Size = New System.Drawing.Size(1256, 105)
        Me.YarnAllocationSampleGridControl.TabIndex = 1
        Me.YarnAllocationSampleGridControl.UseEmbeddedNavigator = True
        Me.YarnAllocationSampleGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'YarnAllocationSampleBindingSource
        '
        Me.YarnAllocationSampleBindingSource.DataMember = "FK_YarnAllocationSample_SampleFabric"
        Me.YarnAllocationSampleBindingSource.DataSource = Me.SampleFabricBindingSource
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colRemarks1, Me.colYarnPercentage, Me.colWastagePercentage, Me.colQuantity, Me.colYarnColor, Me.colIsYds1, Me.colFeederSize, Me.colFeederQty, Me.colFeederNo, Me.colStripeGroup, Me.colStripeSL, Me.colGroupSL})
        Me.GridView5.GridControl = Me.YarnAllocationSampleGridControl
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colItemId
        '
        Me.colItemId.Caption = "Yarn Name"
        Me.colItemId.ColumnEdit = Me.ItemNameGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 183
        '
        'ItemNameGridLookUpEdit
        '
        Me.ItemNameGridLookUpEdit.AutoHeight = False
        Me.ItemNameGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemNameGridLookUpEdit.DataSource = Me.ItemListBindingSource
        Me.ItemNameGridLookUpEdit.DisplayMember = "ItemName"
        Me.ItemNameGridLookUpEdit.Name = "ItemNameGridLookUpEdit"
        Me.ItemNameGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemNameGridLookUpEdit.PopupView = Me.GridView9
        Me.ItemNameGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemNameGridLookUpEdit.ValueMember = "ItemId"
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
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 11
        Me.colRemarks1.Width = 146
        '
        'colYarnPercentage
        '
        Me.colYarnPercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnPercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnPercentage.Caption = "Y%"
        Me.colYarnPercentage.FieldName = "YarnPercentage"
        Me.colYarnPercentage.Name = "colYarnPercentage"
        Me.colYarnPercentage.Visible = True
        Me.colYarnPercentage.VisibleIndex = 1
        Me.colYarnPercentage.Width = 45
        '
        'colWastagePercentage
        '
        Me.colWastagePercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colWastagePercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage.Caption = "W%"
        Me.colWastagePercentage.FieldName = "WastagePercentage"
        Me.colWastagePercentage.Name = "colWastagePercentage"
        Me.colWastagePercentage.Width = 49
        '
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 2
        '
        'colYarnColor
        '
        Me.colYarnColor.FieldName = "YarnColor"
        Me.colYarnColor.Name = "colYarnColor"
        Me.colYarnColor.Visible = True
        Me.colYarnColor.VisibleIndex = 6
        '
        'colIsYds1
        '
        Me.colIsYds1.FieldName = "IsYds"
        Me.colIsYds1.Name = "colIsYds1"
        Me.colIsYds1.Visible = True
        Me.colIsYds1.VisibleIndex = 7
        '
        'colFeederSize
        '
        Me.colFeederSize.FieldName = "FeederSize"
        Me.colFeederSize.Name = "colFeederSize"
        Me.colFeederSize.Visible = True
        Me.colFeederSize.VisibleIndex = 8
        '
        'colFeederQty
        '
        Me.colFeederQty.FieldName = "FeederQty"
        Me.colFeederQty.Name = "colFeederQty"
        Me.colFeederQty.Visible = True
        Me.colFeederQty.VisibleIndex = 9
        '
        'colFeederNo
        '
        Me.colFeederNo.FieldName = "FeederNo"
        Me.colFeederNo.Name = "colFeederNo"
        Me.colFeederNo.Visible = True
        Me.colFeederNo.VisibleIndex = 10
        '
        'colStripeGroup
        '
        Me.colStripeGroup.FieldName = "StripeGroup"
        Me.colStripeGroup.Name = "colStripeGroup"
        Me.colStripeGroup.Visible = True
        Me.colStripeGroup.VisibleIndex = 4
        '
        'colStripeSL
        '
        Me.colStripeSL.FieldName = "StripeSL"
        Me.colStripeSL.Name = "colStripeSL"
        Me.colStripeSL.Visible = True
        Me.colStripeSL.VisibleIndex = 5
        '
        'colGroupSL
        '
        Me.colGroupSL.FieldName = "GroupSL"
        Me.colGroupSL.Name = "colGroupSL"
        Me.colGroupSL.Visible = True
        Me.colGroupSL.VisibleIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.SamplePrintColorDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1262, 256)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Print Color Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SamplePrintColorDataGridView
        '
        Me.SamplePrintColorDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SamplePrintColorDataGridView.AutoGenerateColumns = False
        Me.SamplePrintColorDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SamplePrintColorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SamplePrintColorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.SamplePrintColorDataGridView.DataSource = Me.SamplePrintColorBindingSource
        Me.SamplePrintColorDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SamplePrintColorDataGridView.Name = "SamplePrintColorDataGridView"
        Me.SamplePrintColorDataGridView.Size = New System.Drawing.Size(1082, 222)
        Me.SamplePrintColorDataGridView.TabIndex = 0
        Me.SamplePrintColorDataGridView.Tag = "NR"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 200
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Ref"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Ref"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 150
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "RefType"
        Me.DataGridViewTextBoxColumn16.HeaderText = "RefType"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 150
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "InkType"
        Me.DataGridViewTextBoxColumn17.HeaderText = "InkType"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 150
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Mesh"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Mesh"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 150
        '
        'SamplePrintColorBindingSource
        '
        Me.SamplePrintColorBindingSource.DataMember = "FK_SamplePrintColor_SampleRequestFinal"
        Me.SamplePrintColorBindingSource.DataSource = Me.SampleRequestFinalBindingSource
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.SampleRequireQuantityDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1262, 256)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sizewise Require Quantity"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SampleRequireQuantityDataGridView
        '
        Me.SampleRequireQuantityDataGridView.AutoGenerateColumns = False
        Me.SampleRequireQuantityDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SampleRequireQuantityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SampleRequireQuantityDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.SampleRequireQuantityDataGridView.DataSource = Me.SampleRequireQuantityBindingSource
        Me.SampleRequireQuantityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SampleRequireQuantityDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SampleRequireQuantityDataGridView.Name = "SampleRequireQuantityDataGridView"
        Me.SampleRequireQuantityDataGridView.Size = New System.Drawing.Size(1256, 250)
        Me.SampleRequireQuantityDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "RequireFor"
        Me.DataGridViewTextBoxColumn21.HeaderText = "RequireFor"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "GarmentsSize"
        Me.DataGridViewTextBoxColumn22.HeaderText = "GarmentsSize"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'SampleRequireQuantityBindingSource
        '
        Me.SampleRequireQuantityBindingSource.DataMember = "FK_SampleRequireQuantity_SampleRequestFinal"
        Me.SampleRequireQuantityBindingSource.DataSource = Me.SampleRequestFinalBindingSource
        '
        'GarmentsPartTableAdapter
        '
        Me.GarmentsPartTableAdapter.ClearBeforeFill = True
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'GSMTableAdapter
        '
        Me.GSMTableAdapter.ClearBeforeFill = True
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Delete
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(658, 4)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(5, 4, 3, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.DeleteButton.Size = New System.Drawing.Size(91, 26)
        Me.DeleteButton.TabIndex = 5
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.KSoft_Apparel.My.Resources.Resources.Print
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(762, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(10, 4, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(105, 26)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Edit
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(558, 4)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(10, 4, 3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.SaveButton.Size = New System.Drawing.Size(92, 26)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "&Edit"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'NewButton
        '
        Me.NewButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Add_icon
        Me.NewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewButton.Location = New System.Drawing.Point(457, 4)
        Me.NewButton.Margin = New System.Windows.Forms.Padding(30, 4, 3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.NewButton.Size = New System.Drawing.Size(88, 26)
        Me.NewButton.TabIndex = 3
        Me.NewButton.Text = "&Add"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel3.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel3.Controls.Add(Me.GridLookUpEdit1)
        Me.FlowLayoutPanel3.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.SaveButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel3.Controls.Add(Me.CopyAllButton)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1301, 32)
        Me.FlowLayoutPanel3.TabIndex = 0
        Me.FlowLayoutPanel3.Tag = "NR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(20, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Sample Program No"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(134, 7)
        Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.SRLookupByDivUserBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "Details"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "SampleRequestId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(245, 20)
        Me.GridLookUpEdit1.TabIndex = 0
        Me.GridLookUpEdit1.Tag = "NR"
        '
        'SRLookupByDivUserBindingSource
        '
        Me.SRLookupByDivUserBindingSource.DataMember = "SRLookupByDivUser"
        Me.SRLookupByDivUserBindingSource.DataSource = Me.SampleRequestLookupDataSet
        '
        'SampleRequestLookupDataSet
        '
        Me.SampleRequestLookupDataSet.DataSetName = "SampleRequestLookupDataSet"
        Me.SampleRequestLookupDataSet.EnforceConstraints = False
        Me.SampleRequestLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails, Me.colRequestDate})
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
        'colRequestDate
        '
        Me.colRequestDate.FieldName = "RequestDate"
        Me.colRequestDate.Name = "colRequestDate"
        Me.colRequestDate.Visible = True
        Me.colRequestDate.VisibleIndex = 1
        '
        'RefreshButton
        '
        Me.RefreshButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Synchronize_icon
        Me.RefreshButton.Location = New System.Drawing.Point(385, 6)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(39, 22)
        Me.RefreshButton.TabIndex = 2
        Me.RefreshButton.Tag = "NR"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'CopyAllButton
        '
        Me.CopyAllButton.BackColor = System.Drawing.Color.Transparent
        Me.CopyAllButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Copy_icon
        Me.CopyAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CopyAllButton.Location = New System.Drawing.Point(880, 4)
        Me.CopyAllButton.Margin = New System.Windows.Forms.Padding(10, 4, 3, 3)
        Me.CopyAllButton.Name = "CopyAllButton"
        Me.CopyAllButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.CopyAllButton.Size = New System.Drawing.Size(90, 26)
        Me.CopyAllButton.TabIndex = 6
        Me.CopyAllButton.Text = "&Copy"
        Me.CopyAllButton.UseVisualStyleBackColor = False
        '
        'SampleRequestNoLookupBindingSource
        '
        Me.SampleRequestNoLookupBindingSource.DataMember = "SampleRequestNoLookup"
        Me.SampleRequestNoLookupBindingSource.DataSource = Me.SampleRequestLookupDataSet
        '
        'SendPhotoStrikeOffCheckEdit
        '
        Me.SendPhotoStrikeOffCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SendPhotoStrikeOff", True))
        Me.SendPhotoStrikeOffCheckEdit.Location = New System.Drawing.Point(151, 133)
        Me.SendPhotoStrikeOffCheckEdit.Name = "SendPhotoStrikeOffCheckEdit"
        Me.SendPhotoStrikeOffCheckEdit.Properties.Caption = ""
        Me.SendPhotoStrikeOffCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.SendPhotoStrikeOffCheckEdit.TabIndex = 10
        '
        'RemarksMemoEdit
        '
        Me.RemarksMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Remarks", True))
        Me.RemarksMemoEdit.Location = New System.Drawing.Point(143, 252)
        Me.RemarksMemoEdit.Name = "RemarksMemoEdit"
        Me.RemarksMemoEdit.Size = New System.Drawing.Size(391, 57)
        Me.RemarksMemoEdit.TabIndex = 10
        '
        'IsEmbroideryCheckEdit
        '
        Me.IsEmbroideryCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsEmbroidery", True))
        Me.IsEmbroideryCheckEdit.Location = New System.Drawing.Point(570, 252)
        Me.IsEmbroideryCheckEdit.Name = "IsEmbroideryCheckEdit"
        Me.IsEmbroideryCheckEdit.Properties.Caption = "Embroidery"
        Me.IsEmbroideryCheckEdit.Properties.ReadOnly = True
        Me.IsEmbroideryCheckEdit.Size = New System.Drawing.Size(121, 19)
        Me.IsEmbroideryCheckEdit.TabIndex = 18
        '
        'EmbroideryDetailsTextEdit
        '
        Me.EmbroideryDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "EmbroideryDetails", True))
        Me.EmbroideryDetailsTextEdit.Location = New System.Drawing.Point(697, 251)
        Me.EmbroideryDetailsTextEdit.Name = "EmbroideryDetailsTextEdit"
        Me.EmbroideryDetailsTextEdit.Properties.ReadOnly = True
        Me.EmbroideryDetailsTextEdit.Size = New System.Drawing.Size(128, 20)
        Me.EmbroideryDetailsTextEdit.TabIndex = 19
        Me.EmbroideryDetailsTextEdit.ToolTip = "Embroidery Details"
        '
        'IsTrimCheckEdit
        '
        Me.IsTrimCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsTrim", True))
        Me.IsTrimCheckEdit.Location = New System.Drawing.Point(829, 251)
        Me.IsTrimCheckEdit.Name = "IsTrimCheckEdit"
        Me.IsTrimCheckEdit.Properties.Caption = "Trims"
        Me.IsTrimCheckEdit.Size = New System.Drawing.Size(72, 19)
        Me.IsTrimCheckEdit.TabIndex = 20
        '
        'TrimDetailsTextEdit
        '
        Me.TrimDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "TrimDetails", True))
        Me.TrimDetailsTextEdit.Location = New System.Drawing.Point(935, 252)
        Me.TrimDetailsTextEdit.Name = "TrimDetailsTextEdit"
        Me.TrimDetailsTextEdit.Size = New System.Drawing.Size(147, 20)
        Me.TrimDetailsTextEdit.TabIndex = 21
        '
        'IsPrintCheckEdit
        '
        Me.IsPrintCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsPrint", True))
        Me.IsPrintCheckEdit.Location = New System.Drawing.Point(570, 57)
        Me.IsPrintCheckEdit.Name = "IsPrintCheckEdit"
        Me.IsPrintCheckEdit.Properties.Caption = "Print"
        Me.IsPrintCheckEdit.Properties.ReadOnly = True
        Me.IsPrintCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsPrintCheckEdit.TabIndex = 0
        '
        'PrintTypeIdGridLookUpEditView
        '
        Me.PrintTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.PrintTypeIdGridLookUpEditView.Name = "PrintTypeIdGridLookUpEditView"
        Me.PrintTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.PrintTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'PrintTypeIdGridLookUpEdit
        '
        Me.PrintTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "PrintTypeId", True))
        Me.PrintTypeIdGridLookUpEdit.Location = New System.Drawing.Point(153, 29)
        Me.PrintTypeIdGridLookUpEdit.Name = "PrintTypeIdGridLookUpEdit"
        Me.PrintTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintTypeIdGridLookUpEdit.Properties.DataSource = Me.PrintTypeBindingSource
        Me.PrintTypeIdGridLookUpEdit.Properties.DisplayMember = "PrintTypeName"
        Me.PrintTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.PrintTypeIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.PrintTypeIdGridLookUpEdit.Properties.PopupView = Me.PrintTypeIdGridLookUpEditView
        Me.PrintTypeIdGridLookUpEdit.Properties.ReadOnly = True
        Me.PrintTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrintTypeIdGridLookUpEdit.Properties.ValueMember = "PrintTypeId"
        Me.PrintTypeIdGridLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.PrintTypeIdGridLookUpEdit.TabIndex = 1
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
        'PrintTypeTableAdapter
        '
        Me.PrintTypeTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SendPhotoStrikeOffCheckEdit)
        Me.GroupBox1.Controls.Add(Me.PrintSizeTextEdit)
        Me.GroupBox1.Controls.Add(Me.StyleTextEdit)
        Me.GroupBox1.Controls.Add(Me.MesurementSpinEdit)
        Me.GroupBox1.Controls.Add(MesurementLabel)
        Me.GroupBox1.Controls.Add(Me.PrintTypeIdGridLookUpEdit)
        Me.GroupBox1.Controls.Add(PrintTypeIdLabel)
        Me.GroupBox1.Controls.Add(Me.PrintPositionTextEdit)
        Me.GroupBox1.Controls.Add(PrintPositionLabel)
        Me.GroupBox1.Controls.Add(Me.HeightSpinEdit)
        Me.GroupBox1.Controls.Add(HeightLabel)
        Me.GroupBox1.Controls.Add(SendPhotoStrikeOffLabel1)
        Me.GroupBox1.Controls.Add(Me.WidthSpinEdit)
        Me.GroupBox1.Controls.Add(WidthLabel)
        Me.GroupBox1.Controls.Add(PrintSizeLabel)
        Me.GroupBox1.Controls.Add(Me.ApplicationTextEdit)
        Me.GroupBox1.Controls.Add(ApplicationLabel)
        Me.GroupBox1.Controls.Add(Me.SpecialBackNeckReferenceTextEdit)
        Me.GroupBox1.Controls.Add(SpecialBackNeckReferenceLabel)
        Me.GroupBox1.Controls.Add(Me.ArtworkLocationTextEdit)
        Me.GroupBox1.Controls.Add(ArtworkLocationLabel)
        Me.GroupBox1.Controls.Add(StyleLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(567, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 162)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print Information"
        '
        'StyleTextEdit
        '
        Me.StyleTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "Style", True))
        Me.StyleTextEdit.Location = New System.Drawing.Point(419, 180)
        Me.StyleTextEdit.Name = "StyleTextEdit"
        Me.StyleTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.StyleTextEdit.TabIndex = 6
        Me.StyleTextEdit.Visible = False
        '
        'IsTrimAvailableCheckEdit
        '
        Me.IsTrimAvailableCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsTrimAvailable", True))
        Me.IsTrimAvailableCheckEdit.Location = New System.Drawing.Point(829, 276)
        Me.IsTrimAvailableCheckEdit.Name = "IsTrimAvailableCheckEdit"
        Me.IsTrimAvailableCheckEdit.Properties.Caption = "Trims Available"
        Me.IsTrimAvailableCheckEdit.Size = New System.Drawing.Size(105, 19)
        Me.IsTrimAvailableCheckEdit.TabIndex = 22
        '
        'ExTrimRcvDateDateEdit
        '
        Me.ExTrimRcvDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "ExTrimRcvDate", True))
        Me.ExTrimRcvDateDateEdit.EditValue = Nothing
        Me.ExTrimRcvDateDateEdit.Location = New System.Drawing.Point(935, 277)
        Me.ExTrimRcvDateDateEdit.Name = "ExTrimRcvDateDateEdit"
        Me.ExTrimRcvDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExTrimRcvDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ExTrimRcvDateDateEdit.Size = New System.Drawing.Size(147, 20)
        Me.ExTrimRcvDateDateEdit.TabIndex = 23
        Me.ExTrimRcvDateDateEdit.ToolTip = "Ex Trim Received Date"
        '
        'AgreedLinkLabel
        '
        Me.AgreedLinkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AgreedLinkLabel.Location = New System.Drawing.Point(1135, 254)
        Me.AgreedLinkLabel.Name = "AgreedLinkLabel"
        Me.AgreedLinkLabel.Size = New System.Drawing.Size(147, 25)
        Me.AgreedLinkLabel.TabIndex = 27
        Me.AgreedLinkLabel.TabStop = True
        Me.AgreedLinkLabel.Text = "Calculate Agreed Lead Time"
        Me.AgreedLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BuyerGridLookUpEdit)
        Me.GroupBox3.Controls.Add(Label1)
        Me.GroupBox3.Controls.Add(Me.GMTBrandIdGridLookUpEdit)
        Me.GroupBox3.Controls.Add(BrandLabel)
        Me.GroupBox3.Controls.Add(StyleTypeLabel1)
        Me.GroupBox3.Controls.Add(Me.StyleTypeComboBox)
        Me.GroupBox3.Controls.Add(Me.StyleNameIdGridLookUpEdit)
        Me.GroupBox3.Controls.Add(ApprovalStatusLabel)
        Me.GroupBox3.Controls.Add(Me.ApprovalStatusTextEdit)
        Me.GroupBox3.Controls.Add(Me.CommentsReceiveDateDateEdit)
        Me.GroupBox3.Controls.Add(Me.SampleQuantitySpinEdit)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(SendingInfoLabel)
        Me.GroupBox3.Controls.Add(Me.SendingInfoTextEdit)
        Me.GroupBox3.Controls.Add(SampleSendDateLabel)
        Me.GroupBox3.Controls.Add(Me.SampleSendDateDateEdit)
        Me.GroupBox3.Controls.Add(Me.GetDataButton)
        Me.GroupBox3.Controls.Add(MasterProgramNoLabel)
        Me.GroupBox3.Controls.Add(Me.MasterProgramNoTextBox)
        Me.GroupBox3.Controls.Add(Me.GetStyleDetailsButton)
        Me.GroupBox3.Controls.Add(Me.RequestNoLinkLabel)
        Me.GroupBox3.Controls.Add(Me.DivisionIdGridLookUpEdit)
        Me.GroupBox3.Controls.Add(Me.StyleNoLinkLabel)
        Me.GroupBox3.Controls.Add(Me.GarmentsDescriptionMemoEdit)
        Me.GroupBox3.Controls.Add(DevTypeIdLabel)
        Me.GroupBox3.Controls.Add(Me.DevTypeIdGridLookUpEdit)
        Me.GroupBox3.Controls.Add(Me.RemarksMemoEdit)
        Me.GroupBox3.Controls.Add(RemarksLabel)
        Me.GroupBox3.Controls.Add(Me.ExDateDateEdit)
        Me.GroupBox3.Controls.Add(ExDateLabel)
        Me.GroupBox3.Controls.Add(GMDepartmentIdLabel)
        Me.GroupBox3.Controls.Add(Me.StyleIdGridLookUpEdit)
        Me.GroupBox3.Controls.Add(BuyerIdLabel)
        Me.GroupBox3.Controls.Add(Me.RequestNoTextEdit)
        Me.GroupBox3.Controls.Add(GarmentsDescriptionLabel)
        Me.GroupBox3.Controls.Add(RequestDateLabel)
        Me.GroupBox3.Controls.Add(Me.RequestDateDateEdit)
        Me.GroupBox3.Controls.Add(CommentsReceiveDateLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(554, 315)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Basic Information"
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "BuyerId", True))
        Me.BuyerGridLookUpEdit.Location = New System.Drawing.Point(143, 142)
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerGridLookUpEdit.Properties.NullText = ""
        Me.BuyerGridLookUpEdit.Properties.PopupView = Me.BuyerGridLookUpEditView
        Me.BuyerGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerGridLookUpEdit.Size = New System.Drawing.Size(123, 20)
        Me.BuyerGridLookUpEdit.TabIndex = 50
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerGridLookUpEditView
        '
        Me.BuyerGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName, Me.colBuyerCode})
        Me.BuyerGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.BuyerGridLookUpEditView.Name = "BuyerGridLookUpEditView"
        Me.BuyerGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BuyerGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 0
        '
        'colBuyerCode
        '
        Me.colBuyerCode.FieldName = "BuyerCode"
        Me.colBuyerCode.Name = "colBuyerCode"
        Me.colBuyerCode.Visible = True
        Me.colBuyerCode.VisibleIndex = 1
        '
        'GMTBrandIdGridLookUpEdit
        '
        Me.GMTBrandIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "GMTBrandId", True))
        Me.GMTBrandIdGridLookUpEdit.Location = New System.Drawing.Point(416, 91)
        Me.GMTBrandIdGridLookUpEdit.Name = "GMTBrandIdGridLookUpEdit"
        Me.GMTBrandIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GMTBrandIdGridLookUpEdit.Properties.DataSource = Me.GMTBrandBindingSource
        Me.GMTBrandIdGridLookUpEdit.Properties.DisplayMember = "GMTBrandName"
        Me.GMTBrandIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.GMTBrandIdGridLookUpEdit.Properties.NullText = ""
        Me.GMTBrandIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GMTBrandIdGridLookUpEdit.Properties.PopupView = Me.GMTBrandIdGridLookUpEditView
        Me.GMTBrandIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GMTBrandIdGridLookUpEdit.Properties.ValueMember = "GMTBrandId"
        Me.GMTBrandIdGridLookUpEdit.Size = New System.Drawing.Size(118, 20)
        Me.GMTBrandIdGridLookUpEdit.TabIndex = 48
        '
        'GMTBrandBindingSource
        '
        Me.GMTBrandBindingSource.DataMember = "GMTBrand"
        Me.GMTBrandBindingSource.DataSource = Me.GMTBrandDataSet
        '
        'GMTBrandDataSet
        '
        Me.GMTBrandDataSet.DataSetName = "GMTBrandDataSet"
        Me.GMTBrandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GMTBrandIdGridLookUpEditView
        '
        Me.GMTBrandIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGMTBrandName})
        Me.GMTBrandIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GMTBrandIdGridLookUpEditView.Name = "GMTBrandIdGridLookUpEditView"
        Me.GMTBrandIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GMTBrandIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colGMTBrandName
        '
        Me.colGMTBrandName.FieldName = "GMTBrandName"
        Me.colGMTBrandName.Name = "colGMTBrandName"
        Me.colGMTBrandName.Visible = True
        Me.colGMTBrandName.VisibleIndex = 0
        '
        'StyleTypeComboBox
        '
        Me.StyleTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SampleRequestFinalBindingSource, "StyleType", True))
        Me.StyleTypeComboBox.DataSource = Me.StyleTypeMstBindingSource
        Me.StyleTypeComboBox.DisplayMember = "StyleType"
        Me.StyleTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StyleTypeComboBox.FormattingEnabled = True
        Me.StyleTypeComboBox.Location = New System.Drawing.Point(401, 163)
        Me.StyleTypeComboBox.Name = "StyleTypeComboBox"
        Me.StyleTypeComboBox.Size = New System.Drawing.Size(133, 21)
        Me.StyleTypeComboBox.TabIndex = 44
        Me.StyleTypeComboBox.ValueMember = "StyleType"
        '
        'StyleTypeMstBindingSource
        '
        Me.StyleTypeMstBindingSource.DataMember = "StyleTypeMst"
        Me.StyleTypeMstBindingSource.DataSource = Me.StyleTypeDataSet
        '
        'StyleTypeDataSet
        '
        Me.StyleTypeDataSet.DataSetName = "StyleTypeDataSet"
        Me.StyleTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleNameIdGridLookUpEdit
        '
        Me.StyleNameIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "StyleNameId", True))
        Me.StyleNameIdGridLookUpEdit.Location = New System.Drawing.Point(143, 118)
        Me.StyleNameIdGridLookUpEdit.Name = "StyleNameIdGridLookUpEdit"
        Me.StyleNameIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleNameIdGridLookUpEdit.Properties.DataSource = Me.StyleNameMstBindingSource
        Me.StyleNameIdGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleNameIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleNameIdGridLookUpEdit.Properties.NullText = ""
        Me.StyleNameIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleNameIdGridLookUpEdit.Properties.PopupView = Me.StyleNameIdGridLookUpEditView
        Me.StyleNameIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleNameIdGridLookUpEdit.Properties.ValueMember = "StyleNameId"
        Me.StyleNameIdGridLookUpEdit.Size = New System.Drawing.Size(123, 20)
        Me.StyleNameIdGridLookUpEdit.TabIndex = 45
        Me.StyleNameIdGridLookUpEdit.ToolTip = "Type And Press F10 to add in the list"
        '
        'StyleNameMstBindingSource
        '
        Me.StyleNameMstBindingSource.DataMember = "StyleNameMst"
        Me.StyleNameMstBindingSource.DataSource = Me.StyleDataSet
        '
        'StyleDataSet
        '
        Me.StyleDataSet.DataSetName = "d"
        Me.StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleNameIdGridLookUpEditView
        '
        Me.StyleNameIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleNameId1, Me.colStyleName1, Me.colStyleNameGroup})
        Me.StyleNameIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.StyleNameIdGridLookUpEditView.Name = "StyleNameIdGridLookUpEditView"
        Me.StyleNameIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.StyleNameIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colStyleNameId1
        '
        Me.colStyleNameId1.FieldName = "StyleNameId"
        Me.colStyleNameId1.Name = "colStyleNameId1"
        Me.colStyleNameId1.OptionsColumn.ReadOnly = True
        '
        'colStyleName1
        '
        Me.colStyleName1.FieldName = "StyleName"
        Me.colStyleName1.Name = "colStyleName1"
        Me.colStyleName1.Visible = True
        Me.colStyleName1.VisibleIndex = 0
        '
        'colStyleNameGroup
        '
        Me.colStyleNameGroup.FieldName = "StyleNameGroup"
        Me.colStyleNameGroup.Name = "colStyleNameGroup"
        '
        'ApprovalStatusTextEdit
        '
        Me.ApprovalStatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "ApprovalStatus", True))
        Me.ApprovalStatusTextEdit.Location = New System.Drawing.Point(401, 139)
        Me.ApprovalStatusTextEdit.Name = "ApprovalStatusTextEdit"
        Me.ApprovalStatusTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.ApprovalStatusTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ApprovalStatusTextEdit.Size = New System.Drawing.Size(133, 20)
        Me.ApprovalStatusTextEdit.TabIndex = 42
        '
        'CommentsReceiveDateDateEdit
        '
        Me.CommentsReceiveDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "CommentsReceiveDate", True))
        Me.CommentsReceiveDateDateEdit.EditValue = Nothing
        Me.CommentsReceiveDateDateEdit.Location = New System.Drawing.Point(143, 166)
        Me.CommentsReceiveDateDateEdit.Name = "CommentsReceiveDateDateEdit"
        Me.CommentsReceiveDateDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.CommentsReceiveDateDateEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CommentsReceiveDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CommentsReceiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CommentsReceiveDateDateEdit.Size = New System.Drawing.Size(122, 20)
        Me.CommentsReceiveDateDateEdit.TabIndex = 41
        '
        'SampleQuantitySpinEdit
        '
        Me.SampleQuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleQuantity", True))
        Me.SampleQuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SampleQuantitySpinEdit.Location = New System.Drawing.Point(402, 190)
        Me.SampleQuantitySpinEdit.Name = "SampleQuantitySpinEdit"
        Me.SampleQuantitySpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.LemonChiffon
        Me.SampleQuantitySpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.SampleQuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SampleQuantitySpinEdit.Size = New System.Drawing.Size(54, 20)
        Me.SampleQuantitySpinEdit.TabIndex = 4
        '
        'SendingInfoTextEdit
        '
        Me.SendingInfoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SendingInfo", True))
        Me.SendingInfoTextEdit.Location = New System.Drawing.Point(401, 116)
        Me.SendingInfoTextEdit.Name = "SendingInfoTextEdit"
        Me.SendingInfoTextEdit.Size = New System.Drawing.Size(133, 20)
        Me.SendingInfoTextEdit.TabIndex = 40
        '
        'SampleSendDateDateEdit
        '
        Me.SampleSendDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleSendDate", True))
        Me.SampleSendDateDateEdit.EditValue = Nothing
        Me.SampleSendDateDateEdit.Location = New System.Drawing.Point(143, 190)
        Me.SampleSendDateDateEdit.Name = "SampleSendDateDateEdit"
        Me.SampleSendDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleSendDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SampleSendDateDateEdit.Size = New System.Drawing.Size(122, 20)
        Me.SampleSendDateDateEdit.TabIndex = 39
        '
        'GetDataButton
        '
        Me.GetDataButton.Location = New System.Drawing.Point(269, 20)
        Me.GetDataButton.Name = "GetDataButton"
        Me.GetDataButton.Size = New System.Drawing.Size(32, 23)
        Me.GetDataButton.TabIndex = 38
        Me.GetDataButton.Text = "&Get Data"
        Me.GetDataButton.UseVisualStyleBackColor = True
        '
        'MasterProgramNoTextBox
        '
        Me.MasterProgramNoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MasterProgramNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SampleRequestFinalBindingSource, "MasterProgramNo", True))
        Me.MasterProgramNoTextBox.Location = New System.Drawing.Point(143, 21)
        Me.MasterProgramNoTextBox.Name = "MasterProgramNoTextBox"
        Me.MasterProgramNoTextBox.ReadOnly = True
        Me.MasterProgramNoTextBox.Size = New System.Drawing.Size(123, 20)
        Me.MasterProgramNoTextBox.TabIndex = 0
        '
        'GetStyleDetailsButton
        '
        Me.GetStyleDetailsButton.Location = New System.Drawing.Point(268, 92)
        Me.GetStyleDetailsButton.Name = "GetStyleDetailsButton"
        Me.GetStyleDetailsButton.Size = New System.Drawing.Size(36, 23)
        Me.GetStyleDetailsButton.TabIndex = 36
        Me.GetStyleDetailsButton.Text = "R"
        Me.GetStyleDetailsButton.UseVisualStyleBackColor = True
        Me.GetStyleDetailsButton.Visible = False
        '
        'RequestNoLinkLabel
        '
        Me.RequestNoLinkLabel.AutoSize = True
        Me.RequestNoLinkLabel.Location = New System.Drawing.Point(16, 48)
        Me.RequestNoLinkLabel.Name = "RequestNoLinkLabel"
        Me.RequestNoLinkLabel.Size = New System.Drawing.Size(104, 13)
        Me.RequestNoLinkLabel.TabIndex = 35
        Me.RequestNoLinkLabel.TabStop = True
        Me.RequestNoLinkLabel.Text = "Sample Program No:"
        '
        'DivisionIdGridLookUpEdit
        '
        Me.DivisionIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "DivisionId", True))
        Me.DivisionIdGridLookUpEdit.Location = New System.Drawing.Point(416, 68)
        Me.DivisionIdGridLookUpEdit.Name = "DivisionIdGridLookUpEdit"
        Me.DivisionIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DivisionIdGridLookUpEdit.Properties.DataSource = Me.DivisionBindingSource
        Me.DivisionIdGridLookUpEdit.Properties.DisplayMember = "DivisionName"
        Me.DivisionIdGridLookUpEdit.Properties.NullText = ""
        Me.DivisionIdGridLookUpEdit.Properties.PopupView = Me.DivisionIdGridLookUpEditView
        Me.DivisionIdGridLookUpEdit.Properties.ReadOnly = True
        Me.DivisionIdGridLookUpEdit.Properties.ValueMember = "DivisionId"
        Me.DivisionIdGridLookUpEdit.Size = New System.Drawing.Size(118, 20)
        Me.DivisionIdGridLookUpEdit.TabIndex = 6
        '
        'DivisionBindingSource
        '
        Me.DivisionBindingSource.DataMember = "Division"
        Me.DivisionBindingSource.DataSource = Me.DivisionDataSet
        '
        'DivisionDataSet
        '
        Me.DivisionDataSet.DataSetName = "DivisionDataSet"
        Me.DivisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DivisionIdGridLookUpEditView
        '
        Me.DivisionIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDivisionName})
        Me.DivisionIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.DivisionIdGridLookUpEditView.Name = "DivisionIdGridLookUpEditView"
        Me.DivisionIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DivisionIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDivisionName
        '
        Me.colDivisionName.FieldName = "DivisionName"
        Me.colDivisionName.Name = "colDivisionName"
        Me.colDivisionName.Visible = True
        Me.colDivisionName.VisibleIndex = 0
        '
        'StyleNoLinkLabel
        '
        Me.StyleNoLinkLabel.AutoSize = True
        Me.StyleNoLinkLabel.Location = New System.Drawing.Point(17, 95)
        Me.StyleNoLinkLabel.Name = "StyleNoLinkLabel"
        Me.StyleNoLinkLabel.Size = New System.Drawing.Size(77, 13)
        Me.StyleNoLinkLabel.TabIndex = 31
        Me.StyleNoLinkLabel.TabStop = True
        Me.StyleNoLinkLabel.Text = "Style No ( F11)"
        '
        'GarmentsDescriptionMemoEdit
        '
        Me.GarmentsDescriptionMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "GarmentsDescription", True))
        Me.GarmentsDescriptionMemoEdit.Location = New System.Drawing.Point(143, 214)
        Me.GarmentsDescriptionMemoEdit.Name = "GarmentsDescriptionMemoEdit"
        Me.GarmentsDescriptionMemoEdit.Properties.ReadOnly = True
        Me.GarmentsDescriptionMemoEdit.Size = New System.Drawing.Size(391, 35)
        Me.GarmentsDescriptionMemoEdit.TabIndex = 9
        '
        'DevTypeIdGridLookUpEdit
        '
        Me.DevTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "DevTypeId", True))
        Me.DevTypeIdGridLookUpEdit.Location = New System.Drawing.Point(143, 69)
        Me.DevTypeIdGridLookUpEdit.Name = "DevTypeIdGridLookUpEdit"
        Me.DevTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DevTypeIdGridLookUpEdit.Properties.DataSource = Me.DevTypeMstBindingSource
        Me.DevTypeIdGridLookUpEdit.Properties.DisplayMember = "DevType"
        Me.DevTypeIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.DevTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.DevTypeIdGridLookUpEdit.Properties.PopupView = Me.DevTypeIdGridLookUpEditView
        Me.DevTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DevTypeIdGridLookUpEdit.Properties.ValueMember = "DevTypeId"
        Me.DevTypeIdGridLookUpEdit.Size = New System.Drawing.Size(122, 20)
        Me.DevTypeIdGridLookUpEdit.TabIndex = 2
        '
        'DevTypeMstBindingSource
        '
        Me.DevTypeMstBindingSource.DataMember = "DevTypeMst"
        Me.DevTypeMstBindingSource.DataSource = Me.DevTypeDataSet
        '
        'DevTypeDataSet
        '
        Me.DevTypeDataSet.DataSetName = "DevTypeDataSet"
        Me.DevTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DevTypeIdGridLookUpEditView
        '
        Me.DevTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDevType})
        Me.DevTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.DevTypeIdGridLookUpEditView.Name = "DevTypeIdGridLookUpEditView"
        Me.DevTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DevTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDevType
        '
        Me.colDevType.FieldName = "DevType"
        Me.colDevType.Name = "colDevType"
        Me.colDevType.Visible = True
        Me.colDevType.VisibleIndex = 0
        '
        'StyleIdGridLookUpEdit
        '
        Me.StyleIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "StyleId", True))
        Me.StyleIdGridLookUpEdit.Location = New System.Drawing.Point(143, 92)
        Me.StyleIdGridLookUpEdit.Name = "StyleIdGridLookUpEdit"
        Me.StyleIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleIdGridLookUpEdit.Properties.DataSource = Me.StyleBindingSource
        Me.StyleIdGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleIdGridLookUpEdit.Properties.NullText = ""
        Me.StyleIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleIdGridLookUpEdit.Properties.PopupView = Me.StyleIdGridLookUpEditView
        Me.StyleIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleIdGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleIdGridLookUpEdit.Size = New System.Drawing.Size(123, 20)
        Me.StyleIdGridLookUpEdit.TabIndex = 5
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleDataSet
        '
        'StyleIdGridLookUpEditView
        '
        Me.StyleIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleId, Me.colStyleName, Me.colBuyerId1, Me.colDefaultTarget, Me.colSMV, Me.colPicture, Me.colIsPrint, Me.colPrintDetails, Me.colPrintTypeId, Me.colStyleName2, Me.colStyleNameId})
        Me.StyleIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.StyleIdGridLookUpEditView.Name = "StyleIdGridLookUpEditView"
        Me.StyleIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.StyleIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colStyleId
        '
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        Me.colStyleId.OptionsColumn.ReadOnly = True
        '
        'colStyleName
        '
        Me.colStyleName.Caption = "Style No"
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'colBuyerId1
        '
        Me.colBuyerId1.FieldName = "BuyerId"
        Me.colBuyerId1.Name = "colBuyerId1"
        '
        'colDefaultTarget
        '
        Me.colDefaultTarget.FieldName = "DefaultTarget"
        Me.colDefaultTarget.Name = "colDefaultTarget"
        '
        'colSMV
        '
        Me.colSMV.FieldName = "SMV"
        Me.colSMV.Name = "colSMV"
        '
        'colPicture
        '
        Me.colPicture.FieldName = "Picture"
        Me.colPicture.Name = "colPicture"
        '
        'colIsPrint
        '
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        '
        'colPrintDetails
        '
        Me.colPrintDetails.FieldName = "PrintDetails"
        Me.colPrintDetails.Name = "colPrintDetails"
        '
        'colPrintTypeId
        '
        Me.colPrintTypeId.FieldName = "PrintTypeId"
        Me.colPrintTypeId.Name = "colPrintTypeId"
        '
        'colStyleName2
        '
        Me.colStyleName2.FieldName = "StyleName2"
        Me.colStyleName2.Name = "colStyleName2"
        '
        'colStyleNameId
        '
        Me.colStyleNameId.FieldName = "StyleNameId"
        Me.colStyleNameId.Name = "colStyleNameId"
        '
        'SampleUpdateCheckEdit
        '
        Me.SampleUpdateCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "SampleUpdate", True))
        Me.SampleUpdateCheckEdit.Location = New System.Drawing.Point(570, 356)
        Me.SampleUpdateCheckEdit.Name = "SampleUpdateCheckEdit"
        Me.SampleUpdateCheckEdit.Properties.Caption = "Show in Sample Update"
        Me.SampleUpdateCheckEdit.Size = New System.Drawing.Size(134, 19)
        Me.SampleUpdateCheckEdit.TabIndex = 26
        '
        'GMDepartmentIdGridLookUpEdit
        '
        Me.GMDepartmentIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "GMDepartmentId", True))
        Me.GMDepartmentIdGridLookUpEdit.Enabled = False
        Me.GMDepartmentIdGridLookUpEdit.Location = New System.Drawing.Point(978, 56)
        Me.GMDepartmentIdGridLookUpEdit.Name = "GMDepartmentIdGridLookUpEdit"
        Me.GMDepartmentIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GMDepartmentIdGridLookUpEdit.Properties.DataSource = Me.GMDepartmentBindingSource
        Me.GMDepartmentIdGridLookUpEdit.Properties.DisplayMember = "GMDepartmentName"
        Me.GMDepartmentIdGridLookUpEdit.Properties.NullText = ""
        Me.GMDepartmentIdGridLookUpEdit.Properties.PopupView = Me.GMDepartmentIdGridLookUpEditView
        Me.GMDepartmentIdGridLookUpEdit.Properties.ReadOnly = True
        Me.GMDepartmentIdGridLookUpEdit.Properties.ValueMember = "GMDepartmentId"
        Me.GMDepartmentIdGridLookUpEdit.Size = New System.Drawing.Size(138, 20)
        Me.GMDepartmentIdGridLookUpEdit.TabIndex = 8
        Me.GMDepartmentIdGridLookUpEdit.Visible = False
        '
        'GMDepartmentBindingSource
        '
        Me.GMDepartmentBindingSource.DataMember = "GMDepartment"
        Me.GMDepartmentBindingSource.DataSource = Me.GMDepartmentDataSet
        '
        'GMDepartmentDataSet
        '
        Me.GMDepartmentDataSet.DataSetName = "GMDepartmentDataSet"
        Me.GMDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GMDepartmentIdGridLookUpEditView
        '
        Me.GMDepartmentIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GMDepartmentIdGridLookUpEditView.Name = "GMDepartmentIdGridLookUpEditView"
        Me.GMDepartmentIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GMDepartmentIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'WashTypeIdGridLookUpEdit
        '
        Me.WashTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "WashTypeId", True))
        Me.WashTypeIdGridLookUpEdit.Location = New System.Drawing.Point(697, 277)
        Me.WashTypeIdGridLookUpEdit.Name = "WashTypeIdGridLookUpEdit"
        Me.WashTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WashTypeIdGridLookUpEdit.Properties.DataSource = Me.WashTypeMstBindingSource
        Me.WashTypeIdGridLookUpEdit.Properties.DisplayMember = "WashType"
        Me.WashTypeIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.WashTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.WashTypeIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.WashTypeIdGridLookUpEdit.Properties.PopupView = Me.WashTypeIdGridLookUpEditView
        Me.WashTypeIdGridLookUpEdit.Properties.ReadOnly = True
        Me.WashTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.WashTypeIdGridLookUpEdit.Properties.ValueMember = "WashTypeId"
        Me.WashTypeIdGridLookUpEdit.Size = New System.Drawing.Size(128, 20)
        Me.WashTypeIdGridLookUpEdit.TabIndex = 10
        '
        'WashTypeMstBindingSource
        '
        Me.WashTypeMstBindingSource.DataMember = "WashTypeMst"
        Me.WashTypeMstBindingSource.DataSource = Me.WashTypeDataSet
        '
        'WashTypeDataSet
        '
        Me.WashTypeDataSet.DataSetName = "WashTypeDataSet"
        Me.WashTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WashTypeIdGridLookUpEditView
        '
        Me.WashTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashTypeId, Me.colWashType})
        Me.WashTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.WashTypeIdGridLookUpEditView.Name = "WashTypeIdGridLookUpEditView"
        Me.WashTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.WashTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colWashTypeId
        '
        Me.colWashTypeId.FieldName = "WashTypeId"
        Me.colWashTypeId.Name = "colWashTypeId"
        Me.colWashTypeId.OptionsColumn.ReadOnly = True
        '
        'colWashType
        '
        Me.colWashType.FieldName = "WashType"
        Me.colWashType.Name = "colWashType"
        Me.colWashType.Visible = True
        Me.colWashType.VisibleIndex = 0
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'SampleRequestFinalTableAdapter
        '
        Me.SampleRequestFinalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SampleFabricTableAdapter = Me.SampleFabricTableAdapter
        Me.TableAdapterManager.SamplePrintColorTableAdapter = Me.SamplePrintColorTableAdapter
        Me.TableAdapterManager.SampleRequestFinalDetailsTableAdapter = Me.SampleRequestFinalDetailsTableAdapter
        Me.TableAdapterManager.SampleRequestFinalTableAdapter = Me.SampleRequestFinalTableAdapter
        Me.TableAdapterManager.SampleRequireQuantityTableAdapter = Me.SampleRequireQuantityTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SampleRequestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YarnAllocationSampleTableAdapter = Me.YarnAllocationSampleTableAdapter
        '
        'SampleFabricTableAdapter
        '
        Me.SampleFabricTableAdapter.ClearBeforeFill = True
        '
        'SamplePrintColorTableAdapter
        '
        Me.SamplePrintColorTableAdapter.ClearBeforeFill = True
        '
        'SampleRequestFinalDetailsTableAdapter
        '
        Me.SampleRequestFinalDetailsTableAdapter.ClearBeforeFill = True
        '
        'SampleRequireQuantityTableAdapter
        '
        Me.SampleRequireQuantityTableAdapter.ClearBeforeFill = True
        '
        'YarnAllocationSampleTableAdapter
        '
        Me.YarnAllocationSampleTableAdapter.ClearBeforeFill = True
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'GMDepartmentTableAdapter
        '
        Me.GMDepartmentTableAdapter.ClearBeforeFill = True
        '
        'WashTypeMstTableAdapter
        '
        Me.WashTypeMstTableAdapter.ClearBeforeFill = True
        '
        'DevTypeMstTableAdapter
        '
        Me.DevTypeMstTableAdapter.ClearBeforeFill = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'IsWashCheckEdit
        '
        Me.IsWashCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsWash", True))
        Me.IsWashCheckEdit.Location = New System.Drawing.Point(570, 278)
        Me.IsWashCheckEdit.Name = "IsWashCheckEdit"
        Me.IsWashCheckEdit.Properties.Caption = "Wash"
        Me.IsWashCheckEdit.Properties.ReadOnly = True
        Me.IsWashCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsWashCheckEdit.TabIndex = 30
        '
        'DivisionTableAdapter
        '
        Me.DivisionTableAdapter.ClearBeforeFill = True
        '
        'SampleRequestNoLookupTableAdapter
        '
        Me.SampleRequestNoLookupTableAdapter.ClearBeforeFill = True
        '
        'IsPeachFinishCheckEdit
        '
        Me.IsPeachFinishCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsPeachFinish", True))
        Me.IsPeachFinishCheckEdit.Location = New System.Drawing.Point(570, 303)
        Me.IsPeachFinishCheckEdit.Name = "IsPeachFinishCheckEdit"
        Me.IsPeachFinishCheckEdit.Properties.Caption = "Peach Finish"
        Me.IsPeachFinishCheckEdit.Properties.ReadOnly = True
        Me.IsPeachFinishCheckEdit.Size = New System.Drawing.Size(121, 19)
        Me.IsPeachFinishCheckEdit.TabIndex = 31
        '
        'IsBrushCheckEdit
        '
        Me.IsBrushCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsBrush", True))
        Me.IsBrushCheckEdit.Location = New System.Drawing.Point(697, 303)
        Me.IsBrushCheckEdit.Name = "IsBrushCheckEdit"
        Me.IsBrushCheckEdit.Properties.Caption = "Brush"
        Me.IsBrushCheckEdit.Properties.ReadOnly = True
        Me.IsBrushCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsBrushCheckEdit.TabIndex = 32
        '
        'StyleTypeMstTableAdapter
        '
        Me.StyleTypeMstTableAdapter.ClearBeforeFill = True
        '
        'GMTBrandTableAdapter
        '
        Me.GMTBrandTableAdapter.ClearBeforeFill = True
        '
        'StyleNameMstTableAdapter
        '
        Me.StyleNameMstTableAdapter.ClearBeforeFill = True
        '
        'SRLookupByDivUserTableAdapter
        '
        Me.SRLookupByDivUserTableAdapter.ClearBeforeFill = True
        '
        'IsAOPCheckEdit
        '
        Me.IsAOPCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsAOP", True))
        Me.IsAOPCheckEdit.Location = New System.Drawing.Point(570, 328)
        Me.IsAOPCheckEdit.Name = "IsAOPCheckEdit"
        Me.IsAOPCheckEdit.Properties.Caption = "AOP"
        Me.IsAOPCheckEdit.Properties.ReadOnly = True
        Me.IsAOPCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsAOPCheckEdit.TabIndex = 30
        '
        'IsYDSCheckEdit
        '
        Me.IsYDSCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsYds", True))
        Me.IsYDSCheckEdit.Location = New System.Drawing.Point(697, 331)
        Me.IsYDSCheckEdit.Name = "IsYDSCheckEdit"
        Me.IsYDSCheckEdit.Properties.Caption = "YDS"
        Me.IsYDSCheckEdit.Properties.ReadOnly = True
        Me.IsYDSCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsYDSCheckEdit.TabIndex = 30
        '
        'PicturePictureEdit
        '
        Me.PicturePictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "Picture", True))
        Me.PicturePictureEdit.Location = New System.Drawing.Point(1131, 89)
        Me.PicturePictureEdit.Name = "PicturePictureEdit"
        Me.PicturePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PicturePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PicturePictureEdit.Size = New System.Drawing.Size(151, 156)
        Me.PicturePictureEdit.TabIndex = 104
        '
        'IsSequnceCheckEdit
        '
        Me.IsSequnceCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsSequence", True))
        Me.IsSequnceCheckEdit.Location = New System.Drawing.Point(829, 328)
        Me.IsSequnceCheckEdit.Name = "IsSequnceCheckEdit"
        Me.IsSequnceCheckEdit.Properties.Caption = "Sequence"
        Me.IsSequnceCheckEdit.Properties.ReadOnly = True
        Me.IsSequnceCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsSequnceCheckEdit.TabIndex = 30
        '
        'IsSublimationCheckEdit
        '
        Me.IsSublimationCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleRequestFinalBindingSource, "IsSublimation", True))
        Me.IsSublimationCheckEdit.Location = New System.Drawing.Point(829, 302)
        Me.IsSublimationCheckEdit.Name = "IsSublimationCheckEdit"
        Me.IsSublimationCheckEdit.Properties.Caption = "Sublimation\"
        Me.IsSublimationCheckEdit.Properties.ReadOnly = True
        Me.IsSublimationCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsSublimationCheckEdit.TabIndex = 32
        '
        'frmSampleOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 668)
        Me.Controls.Add(Me.PicturePictureEdit)
        Me.Controls.Add(Me.IsSublimationCheckEdit)
        Me.Controls.Add(Me.IsBrushCheckEdit)
        Me.Controls.Add(Me.IsPeachFinishCheckEdit)
        Me.Controls.Add(Me.IsSequnceCheckEdit)
        Me.Controls.Add(Me.IsYDSCheckEdit)
        Me.Controls.Add(Me.IsAOPCheckEdit)
        Me.Controls.Add(Me.IsWashCheckEdit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.IsPrintCheckEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.ExTrimRcvDateDateEdit)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.EmbroideryDetailsTextEdit)
        Me.Controls.Add(Me.IsTrimAvailableCheckEdit)
        Me.Controls.Add(Me.IsEmbroideryCheckEdit)
        Me.Controls.Add(Me.WashTypeIdGridLookUpEdit)
        Me.Controls.Add(Me.IsTrimCheckEdit)
        Me.Controls.Add(Me.TrimDetailsTextEdit)
        Me.Controls.Add(Me.AgreedLinkLabel)
        Me.Controls.Add(Me.GMDepartmentIdGridLookUpEdit)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.SampleUpdateCheckEdit)
        Me.KeyPreview = True
        Me.Name = "frmSampleOrder"
        Me.Text = "Sample Order with Fabric Details"
        CType(Me.SampleRequestFinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtworkLocationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecialBackNeckReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintSizeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintPositionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesurementSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.SampleRequestFinalDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestFinalDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestFinalDetailsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Composition2GridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SampleFabricDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnAllocationSampleGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnAllocationSampleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.SamplePrintColorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SamplePrintColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.SampleRequireQuantityDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequireQuantityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRLookupByDivUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SendPhotoStrikeOffCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsEmbroideryCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbroideryDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsTrimCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrimDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StyleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsTrimAvailableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExTrimRcvDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExTrimRcvDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovalStatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SendingInfoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleSendDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleSendDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsDescriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleUpdateCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsWashCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPeachFinishCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsBrushCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsAOPCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsYDSCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsSequnceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsSublimationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SampleRequestDataSet As KSoft_Apparel.SampleRequestDataSet
    Friend WithEvents SampleRequestFinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleRequestFinalTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestFinalTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SampleRequestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RequestNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RequestDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ExDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ArtworkLocationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SpecialBackNeckReferenceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ApplicationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PrintSizeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WidthSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents HeightSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PrintPositionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MesurementSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SampleFabricTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleFabricTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SampleFabricBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SamplePrintColorTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SamplePrintColorTableAdapter
    Friend WithEvents SampleFabricDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SamplePrintColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleRequireQuantityTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequireQuantityTableAdapter
    Friend WithEvents SamplePrintColorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SampleRequireQuantityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleRequireQuantityDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GarmentsPartDataSet As KSoft_Apparel.GarmentsPartDataSet
    Friend WithEvents GarmentsPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartTableAdapter As KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents GSMDataSet As KSoft_Apparel.GSMDataSet
    Friend WithEvents GSMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GSMTableAdapter As KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SendPhotoStrikeOffCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RemarksMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents IsEmbroideryCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents EmbroideryDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsTrimCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TrimDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsPrintCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PrintTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents PrintTypeDataSet As KSoft_Apparel.PrintTypeDataSet
    Friend WithEvents PrintTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintTypeTableAdapter As KSoft_Apparel.PrintTypeDataSetTableAdapters.PrintTypeTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IsTrimAvailableCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ExTrimRcvDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents AgreedLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents SampleRequestFinalDetailsTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestFinalDetailsTableAdapter
    Friend WithEvents SampleRequestFinalDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleRequestFinalDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents SampleRequestFinalDetailsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSampleRequestDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSampleRequestId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompositionId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsFabricAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colELD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSampleSendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSealed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSealedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgreedLeadTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompositionGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKnittingTypeId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompositionId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComposition1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExFabricRcvDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents StyleIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StyleDataSet As KSoft_Apparel.StyleDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultTarget As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPicture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrintTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleNameId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsAOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsYDS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExSendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SampleUpdateCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GMDepartmentDataSet As KSoft_Apparel.GMDepartmentDataSet
    Friend WithEvents GMDepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMDepartmentTableAdapter As KSoft_Apparel.GMDepartmentDataSetTableAdapters.GMDepartmentTableAdapter
    Friend WithEvents WashTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents WashTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StyleTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WashTypeDataSet As KSoft_Apparel.WashTypeDataSet
    Friend WithEvents WashTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashTypeMstTableAdapter As KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter
    Friend WithEvents colWashTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DevTypeDataSet As KSoft_Apparel.DevTypeDataSet
    Friend WithEvents DevTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DevTypeMstTableAdapter As KSoft_Apparel.DevTypeDataSetTableAdapters.DevTypeMstTableAdapter
    Friend WithEvents DevTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents DevTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColorItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents colFabricColorId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GetDataLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents colIsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCancelReason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GarmentsColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleNoLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents YarnAllocationSampleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YarnAllocationSampleTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.YarnAllocationSampleTableAdapter
    Friend WithEvents YarnAllocationSampleGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWastagePercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsYds1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFeederSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFeederQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFeederNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStripeGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStripeSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGroupSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Apparel.ItemListLookupDataSet
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents CopyFabricButton As System.Windows.Forms.Button
    Friend WithEvents GarmentsDescriptionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DivisionIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents DivisionIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView

    Friend WithEvents GMDepartmentIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GMDepartmentIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents IsWashCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RequestNoLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DivisionDataSet As KSoft_Apparel.DivisionDataSet
    Friend WithEvents DivisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DivisionTableAdapter As KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter
    Friend WithEvents colDivisionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KnittingTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Composition2GridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colComposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemNameGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SampleRequestLookupDataSet As KSoft_Apparel.SampleRequestLookupDataSet
    Friend WithEvents SampleRequestNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleRequestNoLookupTableAdapter As KSoft_Apparel.SampleRequestLookupDataSetTableAdapters.SampleRequestNoLookupTableAdapter
    Friend WithEvents IsPeachFinishCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsBrushCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GetStyleDetailsButton As System.Windows.Forms.Button
    Friend WithEvents GetDataButton As System.Windows.Forms.Button
    Friend WithEvents MasterProgramNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApprovalStatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CommentsReceiveDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SendingInfoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SampleSendDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents StyleTypeMstBindingSource As BindingSource
    Friend WithEvents StyleTypeDataSet As StyleTypeDataSet
    Friend WithEvents StyleTypeMstTableAdapter As StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter
    Friend WithEvents StyleTypeComboBox As ComboBox
    Friend WithEvents StyleNameIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents StyleNameIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleNameId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleNameGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMTBrandIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GMTBrandIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGMTBrandName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMTBrandDataSet As GMTBrandDataSet
    Friend WithEvents GMTBrandBindingSource As BindingSource
    Friend WithEvents GMTBrandTableAdapter As GMTBrandDataSetTableAdapters.GMTBrandTableAdapter
    Friend WithEvents StyleNameMstBindingSource As BindingSource
    Friend WithEvents StyleNameMstTableAdapter As StyleDataSetTableAdapters.StyleNameMstTableAdapter
    Friend WithEvents SRLookupByDivUserBindingSource As BindingSource
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SRLookupByDivUserTableAdapter As SampleRequestLookupDataSetTableAdapters.SRLookupByDivUserTableAdapter
    Friend WithEvents SampleQuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents SPNote As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DUnit As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewComboBoxColumn
    Friend WithEvents Length As DataGridViewTextBoxColumn
    Friend WithEvents Consumption As DataGridViewTextBoxColumn
    Friend WithEvents BookingQuantity As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewComboBoxColumn
    Friend WithEvents KgPerUnit As DataGridViewTextBoxColumn
    Friend WithEvents GreyPercentage As DataGridViewTextBoxColumn
    Friend WithEvents GreyQuantity As DataGridViewTextBoxColumn
    Friend WithEvents IsDelivered As DataGridViewCheckBoxColumn
    Friend WithEvents DeliveredDate As DataGridViewTextBoxColumn
    Friend WithEvents PrintSend As DataGridViewTextBoxColumn
    Friend WithEvents PrintReceived As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewComboBoxColumn
    Friend WithEvents IsFabricAvailable As DataGridViewCheckBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents IsAOPCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsYDSCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CopyAllButton As Button
    Friend WithEvents PicturePictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents IsSequnceCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsSublimationCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colDevType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents BuyerGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
End Class
