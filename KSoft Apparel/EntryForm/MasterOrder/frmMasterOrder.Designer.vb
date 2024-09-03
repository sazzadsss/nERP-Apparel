<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterOrder
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
        Dim GridFormatRule11 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue11 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule12 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue12 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule13 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue13 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule14 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue14 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue3 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue4 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule15 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue15 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule16 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue16 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colAmendmentNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipout = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasterProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsReceivedBySupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipout1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsReceived = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserDocGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.MasterOrderDataSet = New KSoft_Apparel.MasterOrderDataSet()
        Me.MasterOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterOrderTableAdapter = New KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.MasterOrderDataSetTableAdapters.TableAdapterManager()
        Me.MasterOrderAmendmentHistoryTableAdapter = New KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderAmendmentHistoryTableAdapter()
        Me.MasterOrderDetailsAmendmentHistoryTableAdapter = New KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderDetailsAmendmentHistoryTableAdapter()
        Me.MasterOrderDetailsTableAdapter = New KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderDetailsTableAdapter()
        Me.MasterOrderInstructionTableAdapter = New KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderInstructionTableAdapter()
        Me.MasterOrderSampleStatusTableAdapter = New KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderSampleStatusTableAdapter()
        Me.MasterOrderSizeDetailsTableAdapter = New KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderSizeDetailsTableAdapter()
        Me.MasterOrderGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDivisionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DivisionGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DivisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivisionDataSet = New KSoft_Apparel.DivisionDataSet()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLCNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleNameId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleNameGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.StyleNameMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCompositionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompositionGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKnittingTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KnittingTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKnittingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETDDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExFactoryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRFIDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGarmentsColor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colGMDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colIsAOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsEmbroidary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLCRecieveDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colStyleType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsWash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsYDS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCauseOfAmendment1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipoutDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentQTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipoutBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGMTBrandId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BrandGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GMTBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMTBrandDataSet = New KSoft_Apparel.GMTBrandDataSet()
        Me.GridView21 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colShipmentStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShipoutStatusComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colOrderConfirmationDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGauge = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsBrush = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPeachFinish = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeasonId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeasonGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeasonDataSet = New KSoft_Apparel.SeasonDataSet()
        Me.GridView27 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeasonName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnBookingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MasterOrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterOrderDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGarmentsColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNLD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRFIDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShipByComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colPaymentTerm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPackType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDestinationId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DestinationGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DestinationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DestinationDataSet = New KSoft_Apparel.DestinationDataSet()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestinationCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsClose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCauseOfAmendment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCauseOfCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsDespatch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAsignedForMerchandeiser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AsignedForGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETDDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLAmount1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedOn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedOn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColorSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecieveDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRe_ETD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRe_ExFactory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRe_RFI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentQTY1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipoutBalance1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipoutDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommercialTeam = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CommercialTeamComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colShipmentStatus1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShipoutStatsuDetailsComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDSTNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLDNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CommercialTeamGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView20 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MasterOrderSizeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.Supplier = New System.Windows.Forms.Label()
        Me.SupplierGridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierName4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramCode3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CopyPOButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgramButton = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMasterOrderDetailsAmnd = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.SizeAndInstructionXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.CalculateRatioButton = New DevExpress.XtraEditors.SimpleButton()
        Me.MasterOrderSizeDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataSet = New KSoft_Apparel.SizeDataSet()
        Me.GridView26 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRatio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PasteButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CopyButton = New DevExpress.XtraEditors.SimpleButton()
        Me.OrderInstructionGridControl = New DevExpress.XtraGrid.GridControl()
        Me.MasterOrderInstructionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderInstructionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView33 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SampleStatus = New DevExpress.XtraTab.XtraTabPage()
        Me.DeleteSampleStatusButton = New DevExpress.XtraEditors.SimpleButton()
        Me.MasterOrderSampleStatusGridControl = New DevExpress.XtraGrid.GridControl()
        Me.MasterOrderSampleStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView22 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSampleRequestNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSampleRequestDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSampleSendDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSendingInfo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommentsReceive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApproved = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ApprovedComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDevTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SampleTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DevTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevTypeDataSet = New KSoft_Apparel.DevTypeDataSet()
        Me.GridView25 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRemarks2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSLNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSampleRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AddSampleStatusButton = New DevExpress.XtraEditors.SimpleButton()
        Me.MasterOrderAmndHistory = New DevExpress.XtraTab.XtraTabPage()
        Me.MasterOrderAmendmentHistoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.MasterOrderAmendmentHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView17 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAmendmentNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCauseOfAmendment2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MasterOrderDetailsAmndHistory = New DevExpress.XtraTab.XtraTabPage()
        Me.MasterOrderDetailsAmendmentHistoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.MasterOrderDetailsAmendmentHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView19 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAmendmentNo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentDate3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCauseOfAmendment3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Document = New DevExpress.XtraTab.XtraTabPage()
        Me.tbProgress = New System.Windows.Forms.Label()
        Me.SaveDocButton = New DevExpress.XtraEditors.SimpleButton()
        Me.RefreshDocButton = New DevExpress.XtraEditors.SimpleButton()
        Me.DocDeleteButton = New DevExpress.XtraEditors.SimpleButton()
        Me.DocAddButton = New DevExpress.XtraEditors.SimpleButton()
        Me.MasterOrderDocGridControl = New DevExpress.XtraGrid.GridControl()
        Me.MasterOrderDocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterOrderDocDataSet = New KSoft_Apparel.MasterOrderDocDataSet()
        Me.GridView23 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMasterOrderDocId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasterOrderId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUploadedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUploadedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New DevExpress.XtraEditors.SimpleButton()
        Me.EditButton = New DevExpress.XtraEditors.SimpleButton()
        Me.DeleteButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CancelEntryButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintButton = New DevExpress.XtraEditors.SimpleButton()
        Me.RefreshButton = New DevExpress.XtraEditors.SimpleButton()
        Me.StyleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.btnMasterOrderAmnd = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MasterProgramLookUpTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ShowAllButton = New DevExpress.XtraEditors.SimpleButton()
        Me.MailToButton = New DevExpress.XtraEditors.SimpleButton()
        Me.SMSToButton = New DevExpress.XtraEditors.SimpleButton()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.DivisionTableAdapter = New KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter()
        Me.StyleNameMstTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleNameMstTableAdapter()
        Me.DestinationTableAdapter = New KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.colDestinationCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter()
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter()
        Me.colComposition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView18 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMasterOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstruction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstructionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasterOrderInstructionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstructionSlNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramCode2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMTBrandTableAdapter = New KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter()
        Me.colGMTBrandName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MasterOrderDocTableAdapter = New KSoft_Apparel.MasterOrderDocDataSetTableAdapters.MasterOrderDocTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Apparel.MasterOrderDocDataSetTableAdapters.TableAdapterManager()
        Me.DevTypeMstTableAdapter = New KSoft_Apparel.DevTypeDataSetTableAdapters.DevTypeMstTableAdapter()
        Me.colDevType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDevType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter()
        Me.SeasonTableAdapter = New KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter()
        Me.TableAdapterManager2 = New KSoft_Apparel.AccAndFabBOMStatusDataSetTableAdapters.TableAdapterManager()
        Me.colIsAdvance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BlockButton = New System.Windows.Forms.Button()
        CType(Me.UserDocGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipoutStatusComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipByComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignedForGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialTeamComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipoutStatsuDetailsComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialTeamGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.SupplierGridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.SizeAndInstructionXtraTabPage.SuspendLayout()
        CType(Me.MasterOrderSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderInstructionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderInstructionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView33, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SampleStatus.SuspendLayout()
        CType(Me.MasterOrderSampleStatusGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderSampleStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovedComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MasterOrderAmndHistory.SuspendLayout()
        CType(Me.MasterOrderAmendmentHistoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderAmendmentHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MasterOrderDetailsAmndHistory.SuspendLayout()
        CType(Me.MasterOrderDetailsAmendmentHistoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderDetailsAmendmentHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Document.SuspendLayout()
        CType(Me.MasterOrderDocGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderDocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderDocDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.MasterProgramLookUpTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colAmendmentNo1
        '
        Me.colAmendmentNo1.FieldName = "AmendmentNo"
        Me.colAmendmentNo1.Name = "colAmendmentNo1"
        Me.colAmendmentNo1.OptionsColumn.AllowEdit = False
        Me.colAmendmentNo1.OptionsFilter.AllowAutoFilter = False
        Me.colAmendmentNo1.Visible = True
        Me.colAmendmentNo1.VisibleIndex = 35
        Me.colAmendmentNo1.Width = 89
        '
        'colShipout
        '
        Me.colShipout.FieldName = "Shipout"
        Me.colShipout.Name = "colShipout"
        Me.colShipout.Visible = True
        Me.colShipout.VisibleIndex = 38
        '
        'colMasterProgramNo
        '
        Me.colMasterProgramNo.FieldName = "MasterProgramNo"
        Me.colMasterProgramNo.Name = "colMasterProgramNo"
        Me.colMasterProgramNo.OptionsColumn.AllowEdit = False
        Me.colMasterProgramNo.OptionsColumn.ReadOnly = True
        Me.colMasterProgramNo.Visible = True
        Me.colMasterProgramNo.VisibleIndex = 1
        Me.colMasterProgramNo.Width = 106
        '
        'colIsReceivedBySupplier
        '
        Me.colIsReceivedBySupplier.Caption = "Received By Company"
        Me.colIsReceivedBySupplier.FieldName = "IsReceivedBySupplier"
        Me.colIsReceivedBySupplier.Name = "colIsReceivedBySupplier"
        Me.colIsReceivedBySupplier.OptionsColumn.AllowEdit = False
        Me.colIsReceivedBySupplier.Visible = True
        Me.colIsReceivedBySupplier.VisibleIndex = 28
        Me.colIsReceivedBySupplier.Width = 126
        '
        'colAmendmentNo
        '
        Me.colAmendmentNo.FieldName = "AmendmentNo"
        Me.colAmendmentNo.Name = "colAmendmentNo"
        Me.colAmendmentNo.OptionsColumn.AllowEdit = False
        Me.colAmendmentNo.Visible = True
        Me.colAmendmentNo.VisibleIndex = 22
        '
        'colShipout1
        '
        Me.colShipout1.FieldName = "Shipout"
        Me.colShipout1.Name = "colShipout1"
        Me.colShipout1.Visible = True
        Me.colShipout1.VisibleIndex = 37
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsColumn.AllowEdit = False
        Me.colProgramNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        Me.colProgramNo.Width = 100
        '
        'colIsReceived
        '
        Me.colIsReceived.Caption = "Received"
        Me.colIsReceived.FieldName = "IsReceived"
        Me.colIsReceived.Name = "colIsReceived"
        Me.colIsReceived.OptionsColumn.AllowEdit = False
        Me.colIsReceived.Visible = True
        Me.colIsReceived.VisibleIndex = 9
        Me.colIsReceived.Width = 71
        '
        'UserDocGridLookUpEdit
        '
        Me.UserDocGridLookUpEdit.AutoHeight = False
        Me.UserDocGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserDocGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UserDocGridLookUpEdit.Name = "UserDocGridLookUpEdit"
        Me.UserDocGridLookUpEdit.NullText = ""
        Me.UserDocGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserDocGridLookUpEdit.ValueMember = "USER_ID"
        '
        'SizeGridLookUpEdit
        '
        Me.SizeGridLookUpEdit.AutoHeight = False
        Me.SizeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeGridLookUpEdit.ImmediatePopup = True
        Me.SizeGridLookUpEdit.Name = "SizeGridLookUpEdit"
        Me.SizeGridLookUpEdit.NullText = ""
        Me.SizeGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SizeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SizeGridLookUpEdit.ValueMember = "SizeId"
        '
        'MasterOrderDataSet
        '
        Me.MasterOrderDataSet.DataSetName = "MasterOrderDataSet"
        Me.MasterOrderDataSet.EnforceConstraints = False
        Me.MasterOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasterOrderBindingSource
        '
        Me.MasterOrderBindingSource.DataMember = "MasterOrder"
        Me.MasterOrderBindingSource.DataSource = Me.MasterOrderDataSet
        '
        'MasterOrderTableAdapter
        '
        Me.MasterOrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MasterOrderAmendmentHistoryTableAdapter = Me.MasterOrderAmendmentHistoryTableAdapter
        Me.TableAdapterManager.MasterOrderDetailsAmendmentHistoryTableAdapter = Me.MasterOrderDetailsAmendmentHistoryTableAdapter
        Me.TableAdapterManager.MasterOrderDetailsTableAdapter = Me.MasterOrderDetailsTableAdapter
        Me.TableAdapterManager.MasterOrderInstructionTableAdapter = Me.MasterOrderInstructionTableAdapter
        Me.TableAdapterManager.MasterOrderSampleStatusTableAdapter = Me.MasterOrderSampleStatusTableAdapter
        Me.TableAdapterManager.MasterOrderSizeDetailsTableAdapter = Me.MasterOrderSizeDetailsTableAdapter
        Me.TableAdapterManager.MasterOrderTableAdapter = Me.MasterOrderTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.MasterOrderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MasterOrderAmendmentHistoryTableAdapter
        '
        Me.MasterOrderAmendmentHistoryTableAdapter.ClearBeforeFill = True
        '
        'MasterOrderDetailsAmendmentHistoryTableAdapter
        '
        Me.MasterOrderDetailsAmendmentHistoryTableAdapter.ClearBeforeFill = True
        '
        'MasterOrderDetailsTableAdapter
        '
        Me.MasterOrderDetailsTableAdapter.ClearBeforeFill = True
        '
        'MasterOrderInstructionTableAdapter
        '
        Me.MasterOrderInstructionTableAdapter.ClearBeforeFill = True
        '
        'MasterOrderSampleStatusTableAdapter
        '
        Me.MasterOrderSampleStatusTableAdapter.ClearBeforeFill = True
        '
        'MasterOrderSizeDetailsTableAdapter
        '
        Me.MasterOrderSizeDetailsTableAdapter.ClearBeforeFill = True
        '
        'MasterOrderGridControl
        '
        Me.MasterOrderGridControl.DataSource = Me.MasterOrderBindingSource
        Me.MasterOrderGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterOrderGridControl.Location = New System.Drawing.Point(0, 0)
        Me.MasterOrderGridControl.MainView = Me.GridView1
        Me.MasterOrderGridControl.Name = "MasterOrderGridControl"
        Me.MasterOrderGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.StyleItemGridLookUpEdit, Me.BuyerGridLookUpEdit, Me.DivisionGridLookUpEdit, Me.StyleNameGridLookUpEdit, Me.KnittingTypeGridLookUpEdit, Me.CompositionGridLookUpEdit, Me.UserGridLookUpEdit, Me.RepositoryItemPictureEdit1, Me.RepositoryItemSpinEdit1, Me.ShipoutStatusComboBox, Me.BrandGridLookUpEdit, Me.SeasonGridLookUpEdit, Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2})
        Me.MasterOrderGridControl.Size = New System.Drawing.Size(1340, 251)
        Me.MasterOrderGridControl.TabIndex = 1
        Me.MasterOrderGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMasterProgramNo, Me.colStyleId, Me.colBuyerId, Me.colDivisionId, Me.colLCNo, Me.colOrderQuantity, Me.colRemarks, Me.colStyleNameId, Me.colCompositionId, Me.colKnittingTypeId, Me.colDia, Me.colGSM, Me.colCreatedOn, Me.colETDDate, Me.colExFactoryDate, Me.colModifiedOn, Me.colPrice1, Me.colRFIDate, Me.colUserId, Me.colGarmentsColor1, Me.colGMDescription, Me.colIsAOP, Me.colIsEmbroidary, Me.colIsPrint, Me.colLCRecieveDate, Me.colPicture, Me.colStyleType, Me.colIsWash, Me.colIsYDS, Me.colTTLAmount, Me.colAmendmentNo1, Me.colAmendmentDate1, Me.colCauseOfAmendment1, Me.colShipout, Me.colShipoutDate, Me.colShipmentQTY, Me.colShipoutBalance, Me.colGMTBrandId, Me.colShipmentStatus, Me.colOrderConfirmationDate, Me.colOrderReceiveDate, Me.colGauge, Me.colShipmentDate, Me.colIsBrush, Me.colIsPeachFinish, Me.colSeasonId, Me.colYarnBookingDate})
        GridFormatRule11.Column = Me.colAmendmentNo1
        GridFormatRule11.Name = "Format0"
        FormatConditionRuleValue11.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
        FormatConditionRuleValue11.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue11.Condition = DevExpress.XtraEditors.FormatCondition.Greater
        FormatConditionRuleValue11.Value1 = CType(0, Long)
        GridFormatRule11.Rule = FormatConditionRuleValue11
        GridFormatRule12.Column = Me.colShipout
        GridFormatRule12.ColumnApplyTo = Me.colMasterProgramNo
        GridFormatRule12.Name = "ShipoutFormat1"
        FormatConditionRuleValue12.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
        FormatConditionRuleValue12.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue12.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue12.Value1 = False
        GridFormatRule12.Rule = FormatConditionRuleValue12
        GridFormatRule13.Column = Me.colShipout
        GridFormatRule13.ColumnApplyTo = Me.colMasterProgramNo
        GridFormatRule13.Name = "ShipoutFormat2"
        FormatConditionRuleValue13.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
        FormatConditionRuleValue13.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue13.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        GridFormatRule13.Rule = FormatConditionRuleValue13
        GridFormatRule14.Column = Me.colShipout
        GridFormatRule14.ColumnApplyTo = Me.colMasterProgramNo
        GridFormatRule14.Name = "ShipoutFormat3"
        FormatConditionRuleValue14.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleValue14.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue14.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue14.Value1 = True
        GridFormatRule14.Rule = FormatConditionRuleValue14
        Me.GridView1.FormatRules.Add(GridFormatRule11)
        Me.GridView1.FormatRules.Add(GridFormatRule12)
        Me.GridView1.FormatRules.Add(GridFormatRule13)
        Me.GridView1.FormatRules.Add(GridFormatRule14)
        Me.GridView1.GridControl = Me.MasterOrderGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowRowSizing = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colStyleId
        '
        Me.colStyleId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colStyleId.AppearanceCell.Options.UseBackColor = True
        Me.colStyleId.Caption = "Style No"
        Me.colStyleId.ColumnEdit = Me.StyleItemGridLookUpEdit
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        Me.colStyleId.OptionsColumn.AllowEdit = False
        Me.colStyleId.OptionsColumn.ReadOnly = True
        Me.colStyleId.Visible = True
        Me.colStyleId.VisibleIndex = 2
        Me.colStyleId.Width = 93
        '
        'StyleItemGridLookUpEdit
        '
        Me.StyleItemGridLookUpEdit.Appearance.Options.UseTextOptions = True
        Me.StyleItemGridLookUpEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.StyleItemGridLookUpEdit.AutoHeight = False
        Me.StyleItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleItemGridLookUpEdit.DataSource = Me.StyleBindingSource
        Me.StyleItemGridLookUpEdit.DisplayMember = "StyleName"
        Me.StyleItemGridLookUpEdit.Name = "StyleItemGridLookUpEdit"
        Me.StyleItemGridLookUpEdit.NullText = ""
        Me.StyleItemGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.StyleItemGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleItemGridLookUpEdit.ValueMember = "StyleId"
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleDataSet
        '
        'StyleDataSet
        '
        Me.StyleDataSet.DataSetName = "StyleDataSet"
        Me.StyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'colBuyerId
        '
        Me.colBuyerId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colBuyerId.AppearanceCell.Options.UseBackColor = True
        Me.colBuyerId.Caption = "Buyer"
        Me.colBuyerId.ColumnEdit = Me.BuyerGridLookUpEdit
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.OptionsColumn.AllowEdit = False
        Me.colBuyerId.OptionsColumn.ReadOnly = True
        Me.colBuyerId.Visible = True
        Me.colBuyerId.VisibleIndex = 0
        Me.colBuyerId.Width = 89
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.AutoHeight = False
        Me.BuyerGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.DisplayMember = "BuyerName"
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.NullText = ""
        Me.BuyerGridLookUpEdit.PopupView = Me.GridView5
        Me.BuyerGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerGridLookUpEdit.ValueMember = "BuyerId"
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
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 0
        '
        'colDivisionId
        '
        Me.colDivisionId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDivisionId.AppearanceCell.Options.UseBackColor = True
        Me.colDivisionId.Caption = "Division"
        Me.colDivisionId.ColumnEdit = Me.DivisionGridLookUpEdit
        Me.colDivisionId.FieldName = "DivisionId"
        Me.colDivisionId.Name = "colDivisionId"
        Me.colDivisionId.OptionsColumn.AllowEdit = False
        Me.colDivisionId.OptionsColumn.ReadOnly = True
        Me.colDivisionId.Visible = True
        Me.colDivisionId.VisibleIndex = 5
        Me.colDivisionId.Width = 97
        '
        'DivisionGridLookUpEdit
        '
        Me.DivisionGridLookUpEdit.AutoHeight = False
        Me.DivisionGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DivisionGridLookUpEdit.DataSource = Me.DivisionBindingSource
        Me.DivisionGridLookUpEdit.DisplayMember = "DivisionName"
        Me.DivisionGridLookUpEdit.Name = "DivisionGridLookUpEdit"
        Me.DivisionGridLookUpEdit.NullText = ""
        Me.DivisionGridLookUpEdit.PopupView = Me.GridView6
        Me.DivisionGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DivisionGridLookUpEdit.ValueMember = "DivisionId"
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
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colLCNo
        '
        Me.colLCNo.FieldName = "LCNo"
        Me.colLCNo.Name = "colLCNo"
        Me.colLCNo.Visible = True
        Me.colLCNo.VisibleIndex = 27
        Me.colLCNo.Width = 73
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colOrderQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 30
        Me.colOrderQuantity.Width = 90
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 43
        Me.colRemarks.Width = 225
        '
        'colStyleNameId
        '
        Me.colStyleNameId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colStyleNameId.AppearanceCell.Options.UseBackColor = True
        Me.colStyleNameId.Caption = "Style Name"
        Me.colStyleNameId.ColumnEdit = Me.StyleNameGridLookUpEdit
        Me.colStyleNameId.FieldName = "StyleNameId"
        Me.colStyleNameId.Name = "colStyleNameId"
        Me.colStyleNameId.OptionsColumn.AllowEdit = False
        Me.colStyleNameId.OptionsColumn.ReadOnly = True
        Me.colStyleNameId.Visible = True
        Me.colStyleNameId.VisibleIndex = 3
        Me.colStyleNameId.Width = 102
        '
        'StyleNameGridLookUpEdit
        '
        Me.StyleNameGridLookUpEdit.Appearance.Options.UseTextOptions = True
        Me.StyleNameGridLookUpEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.StyleNameGridLookUpEdit.AutoHeight = False
        Me.StyleNameGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleNameGridLookUpEdit.DataSource = Me.StyleNameMstBindingSource
        Me.StyleNameGridLookUpEdit.DisplayMember = "StyleName"
        Me.StyleNameGridLookUpEdit.Name = "StyleNameGridLookUpEdit"
        Me.StyleNameGridLookUpEdit.NullText = ""
        Me.StyleNameGridLookUpEdit.PopupView = Me.GridView7
        Me.StyleNameGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleNameGridLookUpEdit.ValueMember = "StyleNameId"
        '
        'StyleNameMstBindingSource
        '
        Me.StyleNameMstBindingSource.DataMember = "StyleNameMst"
        Me.StyleNameMstBindingSource.DataSource = Me.StyleDataSet
        '
        'GridView7
        '
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colCompositionId
        '
        Me.colCompositionId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCompositionId.AppearanceCell.Options.UseBackColor = True
        Me.colCompositionId.AppearanceCell.Options.UseTextOptions = True
        Me.colCompositionId.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompositionId.Caption = "Composition"
        Me.colCompositionId.ColumnEdit = Me.CompositionGridLookUpEdit
        Me.colCompositionId.FieldName = "CompositionId"
        Me.colCompositionId.Name = "colCompositionId"
        Me.colCompositionId.OptionsColumn.AllowEdit = False
        Me.colCompositionId.OptionsColumn.ReadOnly = True
        Me.colCompositionId.Visible = True
        Me.colCompositionId.VisibleIndex = 11
        Me.colCompositionId.Width = 148
        '
        'CompositionGridLookUpEdit
        '
        Me.CompositionGridLookUpEdit.AutoHeight = False
        Me.CompositionGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompositionGridLookUpEdit.DataSource = Me.CompositionBindingSource
        Me.CompositionGridLookUpEdit.DisplayMember = "Composition"
        Me.CompositionGridLookUpEdit.Name = "CompositionGridLookUpEdit"
        Me.CompositionGridLookUpEdit.NullText = ""
        Me.CompositionGridLookUpEdit.PopupView = Me.GridView13
        Me.CompositionGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CompositionGridLookUpEdit.ValueMember = "CompositionId"
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
        'GridView13
        '
        Me.GridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView13.OptionsView.ShowGroupPanel = False
        '
        'colKnittingTypeId
        '
        Me.colKnittingTypeId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colKnittingTypeId.AppearanceCell.Options.UseBackColor = True
        Me.colKnittingTypeId.Caption = "Fabric Type"
        Me.colKnittingTypeId.ColumnEdit = Me.KnittingTypeGridLookUpEdit
        Me.colKnittingTypeId.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId.Name = "colKnittingTypeId"
        Me.colKnittingTypeId.OptionsColumn.AllowEdit = False
        Me.colKnittingTypeId.OptionsColumn.ReadOnly = True
        Me.colKnittingTypeId.Visible = True
        Me.colKnittingTypeId.VisibleIndex = 8
        Me.colKnittingTypeId.Width = 94
        '
        'KnittingTypeGridLookUpEdit
        '
        Me.KnittingTypeGridLookUpEdit.AutoHeight = False
        Me.KnittingTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KnittingTypeGridLookUpEdit.DataSource = Me.KnittingTypeBindingSource
        Me.KnittingTypeGridLookUpEdit.DisplayMember = "KnittingType"
        Me.KnittingTypeGridLookUpEdit.Name = "KnittingTypeGridLookUpEdit"
        Me.KnittingTypeGridLookUpEdit.NullText = ""
        Me.KnittingTypeGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit2View
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
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingType})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colKnittingType
        '
        Me.colKnittingType.FieldName = "KnittingType"
        Me.colKnittingType.Name = "colKnittingType"
        Me.colKnittingType.Visible = True
        Me.colKnittingType.VisibleIndex = 0
        '
        'colDia
        '
        Me.colDia.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDia.AppearanceCell.Options.UseBackColor = True
        Me.colDia.FieldName = "Dia"
        Me.colDia.Name = "colDia"
        Me.colDia.OptionsColumn.AllowEdit = False
        Me.colDia.OptionsColumn.ReadOnly = True
        Me.colDia.Visible = True
        Me.colDia.VisibleIndex = 15
        Me.colDia.Width = 44
        '
        'colGSM
        '
        Me.colGSM.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colGSM.AppearanceCell.Options.UseBackColor = True
        Me.colGSM.FieldName = "GSM"
        Me.colGSM.Name = "colGSM"
        Me.colGSM.OptionsColumn.AllowEdit = False
        Me.colGSM.OptionsColumn.ReadOnly = True
        Me.colGSM.Visible = True
        Me.colGSM.VisibleIndex = 16
        Me.colGSM.Width = 48
        '
        'colCreatedOn
        '
        Me.colCreatedOn.FieldName = "CreatedOn"
        Me.colCreatedOn.Name = "colCreatedOn"
        Me.colCreatedOn.OptionsColumn.AllowEdit = False
        Me.colCreatedOn.Visible = True
        Me.colCreatedOn.VisibleIndex = 33
        Me.colCreatedOn.Width = 67
        '
        'colETDDate
        '
        Me.colETDDate.FieldName = "ETDDate"
        Me.colETDDate.Name = "colETDDate"
        Me.colETDDate.Width = 70
        '
        'colExFactoryDate
        '
        Me.colExFactoryDate.FieldName = "ExFactoryDate"
        Me.colExFactoryDate.Name = "colExFactoryDate"
        Me.colExFactoryDate.Width = 95
        '
        'colModifiedOn
        '
        Me.colModifiedOn.FieldName = "ModifiedOn"
        Me.colModifiedOn.Name = "colModifiedOn"
        Me.colModifiedOn.Visible = True
        Me.colModifiedOn.VisibleIndex = 34
        Me.colModifiedOn.Width = 70
        '
        'colPrice1
        '
        Me.colPrice1.Caption = "Price FOB ($)"
        Me.colPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrice1.FieldName = "Price"
        Me.colPrice1.Name = "colPrice1"
        Me.colPrice1.Visible = True
        Me.colPrice1.VisibleIndex = 29
        Me.colPrice1.Width = 90
        '
        'colRFIDate
        '
        Me.colRFIDate.FieldName = "RFIDate"
        Me.colRFIDate.Name = "colRFIDate"
        Me.colRFIDate.Width = 57
        '
        'colUserId
        '
        Me.colUserId.Caption = "NFL Merchandiser"
        Me.colUserId.ColumnEdit = Me.UserGridLookUpEdit
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        Me.colUserId.Visible = True
        Me.colUserId.VisibleIndex = 32
        Me.colUserId.Width = 87
        '
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.AutoHeight = False
        Me.UserGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.DataSource = Me.UserLookupBindingSource
        Me.UserGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.ImmediatePopup = True
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.NullText = ""
        Me.UserGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UserGridLookUpEdit.PopupView = Me.GridView15
        Me.UserGridLookUpEdit.ValueMember = "USER_ID"
        '
        'UserLookupBindingSource
        '
        Me.UserLookupBindingSource.DataMember = "UserLookup"
        Me.UserLookupBindingSource.DataSource = Me.UserLookupDataSet
        '
        'UserLookupDataSet
        '
        Me.UserLookupDataSet.DataSetName = "UserLookupDataSet"
        Me.UserLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView15
        '
        Me.GridView15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME2})
        Me.GridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView15.Name = "GridView15"
        Me.GridView15.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView15.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME2
        '
        Me.colUSER_NAME2.FieldName = "USER_NAME"
        Me.colUSER_NAME2.Name = "colUSER_NAME2"
        Me.colUSER_NAME2.Visible = True
        Me.colUSER_NAME2.VisibleIndex = 0
        '
        'colGarmentsColor1
        '
        Me.colGarmentsColor1.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colGarmentsColor1.AppearanceCell.Options.UseBackColor = True
        Me.colGarmentsColor1.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colGarmentsColor1.FieldName = "GarmentsColor"
        Me.colGarmentsColor1.Name = "colGarmentsColor1"
        Me.colGarmentsColor1.ToolTip = "Garments Color"
        Me.colGarmentsColor1.Visible = True
        Me.colGarmentsColor1.VisibleIndex = 9
        Me.colGarmentsColor1.Width = 139
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colGMDescription
        '
        Me.colGMDescription.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colGMDescription.AppearanceCell.Options.UseBackColor = True
        Me.colGMDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGMDescription.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colGMDescription.FieldName = "GMDescription"
        Me.colGMDescription.Name = "colGMDescription"
        Me.colGMDescription.OptionsColumn.AllowEdit = False
        Me.colGMDescription.Visible = True
        Me.colGMDescription.VisibleIndex = 10
        Me.colGMDescription.Width = 129
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'colIsAOP
        '
        Me.colIsAOP.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsAOP.AppearanceCell.Options.UseBackColor = True
        Me.colIsAOP.Caption = "AOP"
        Me.colIsAOP.FieldName = "IsAOP"
        Me.colIsAOP.Name = "colIsAOP"
        Me.colIsAOP.OptionsColumn.AllowEdit = False
        Me.colIsAOP.Visible = True
        Me.colIsAOP.VisibleIndex = 19
        '
        'colIsEmbroidary
        '
        Me.colIsEmbroidary.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsEmbroidary.AppearanceCell.Options.UseBackColor = True
        Me.colIsEmbroidary.Caption = "Embroidery"
        Me.colIsEmbroidary.FieldName = "IsEmbroidary"
        Me.colIsEmbroidary.Name = "colIsEmbroidary"
        Me.colIsEmbroidary.OptionsColumn.AllowEdit = False
        Me.colIsEmbroidary.Visible = True
        Me.colIsEmbroidary.VisibleIndex = 18
        '
        'colIsPrint
        '
        Me.colIsPrint.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsPrint.AppearanceCell.Options.UseBackColor = True
        Me.colIsPrint.Caption = "Print"
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        Me.colIsPrint.OptionsColumn.AllowEdit = False
        Me.colIsPrint.Visible = True
        Me.colIsPrint.VisibleIndex = 17
        '
        'colLCRecieveDate
        '
        Me.colLCRecieveDate.FieldName = "LCRecieveDate"
        Me.colLCRecieveDate.Name = "colLCRecieveDate"
        Me.colLCRecieveDate.Visible = True
        Me.colLCRecieveDate.VisibleIndex = 28
        Me.colLCRecieveDate.Width = 94
        '
        'colPicture
        '
        Me.colPicture.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPicture.AppearanceCell.Options.UseBackColor = True
        Me.colPicture.AppearanceHeader.BackColor = System.Drawing.Color.White
        Me.colPicture.AppearanceHeader.BackColor2 = System.Drawing.Color.White
        Me.colPicture.AppearanceHeader.Options.UseBackColor = True
        Me.colPicture.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.colPicture.FieldName = "Picture"
        Me.colPicture.Name = "colPicture"
        Me.colPicture.OptionsColumn.AllowEdit = False
        Me.colPicture.Visible = True
        Me.colPicture.VisibleIndex = 6
        Me.colPicture.Width = 67
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.CustomHeight = 40
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'colStyleType
        '
        Me.colStyleType.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colStyleType.AppearanceCell.Options.UseBackColor = True
        Me.colStyleType.FieldName = "StyleType"
        Me.colStyleType.Name = "colStyleType"
        Me.colStyleType.OptionsColumn.AllowEdit = False
        Me.colStyleType.Visible = True
        Me.colStyleType.VisibleIndex = 7
        '
        'colIsWash
        '
        Me.colIsWash.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsWash.AppearanceCell.Options.UseBackColor = True
        Me.colIsWash.Caption = "Wash"
        Me.colIsWash.FieldName = "IsWash"
        Me.colIsWash.Name = "colIsWash"
        Me.colIsWash.OptionsColumn.AllowEdit = False
        Me.colIsWash.Visible = True
        Me.colIsWash.VisibleIndex = 23
        '
        'colIsYDS
        '
        Me.colIsYDS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsYDS.AppearanceCell.Options.UseBackColor = True
        Me.colIsYDS.Caption = "Y/D_Stripe"
        Me.colIsYDS.FieldName = "IsYDS"
        Me.colIsYDS.Name = "colIsYDS"
        Me.colIsYDS.OptionsColumn.AllowEdit = False
        Me.colIsYDS.Visible = True
        Me.colIsYDS.VisibleIndex = 20
        '
        'colTTLAmount
        '
        Me.colTTLAmount.Caption = "Total Value ($)"
        Me.colTTLAmount.DisplayFormat.FormatString = "##,##,##0.00"
        Me.colTTLAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTTLAmount.FieldName = "TTLAmount"
        Me.colTTLAmount.Name = "colTTLAmount"
        Me.colTTLAmount.Visible = True
        Me.colTTLAmount.VisibleIndex = 31
        Me.colTTLAmount.Width = 89
        '
        'colAmendmentDate1
        '
        Me.colAmendmentDate1.FieldName = "AmendmentDate"
        Me.colAmendmentDate1.Name = "colAmendmentDate1"
        Me.colAmendmentDate1.OptionsColumn.AllowEdit = False
        Me.colAmendmentDate1.OptionsFilter.AllowAutoFilter = False
        Me.colAmendmentDate1.Visible = True
        Me.colAmendmentDate1.VisibleIndex = 36
        Me.colAmendmentDate1.Width = 97
        '
        'colCauseOfAmendment1
        '
        Me.colCauseOfAmendment1.FieldName = "CauseOfAmendment"
        Me.colCauseOfAmendment1.Name = "colCauseOfAmendment1"
        Me.colCauseOfAmendment1.Visible = True
        Me.colCauseOfAmendment1.VisibleIndex = 37
        Me.colCauseOfAmendment1.Width = 116
        '
        'colShipoutDate
        '
        Me.colShipoutDate.FieldName = "ShipoutDate"
        Me.colShipoutDate.Name = "colShipoutDate"
        Me.colShipoutDate.Visible = True
        Me.colShipoutDate.VisibleIndex = 39
        '
        'colShipmentQTY
        '
        Me.colShipmentQTY.FieldName = "ShipmentQTY"
        Me.colShipmentQTY.Name = "colShipmentQTY"
        Me.colShipmentQTY.Visible = True
        Me.colShipmentQTY.VisibleIndex = 41
        '
        'colShipoutBalance
        '
        Me.colShipoutBalance.FieldName = "ShipoutBalance"
        Me.colShipoutBalance.Name = "colShipoutBalance"
        Me.colShipoutBalance.Visible = True
        Me.colShipoutBalance.VisibleIndex = 42
        Me.colShipoutBalance.Width = 89
        '
        'colGMTBrandId
        '
        Me.colGMTBrandId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colGMTBrandId.AppearanceCell.Options.UseBackColor = True
        Me.colGMTBrandId.Caption = "Brand"
        Me.colGMTBrandId.ColumnEdit = Me.BrandGridLookUpEdit
        Me.colGMTBrandId.FieldName = "GMTBrandId"
        Me.colGMTBrandId.Name = "colGMTBrandId"
        Me.colGMTBrandId.OptionsColumn.AllowEdit = False
        Me.colGMTBrandId.Visible = True
        Me.colGMTBrandId.VisibleIndex = 4
        '
        'BrandGridLookUpEdit
        '
        Me.BrandGridLookUpEdit.Appearance.Options.UseTextOptions = True
        Me.BrandGridLookUpEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BrandGridLookUpEdit.AutoHeight = False
        Me.BrandGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BrandGridLookUpEdit.DataSource = Me.GMTBrandBindingSource
        Me.BrandGridLookUpEdit.DisplayMember = "GMTBrandName"
        Me.BrandGridLookUpEdit.Name = "BrandGridLookUpEdit"
        Me.BrandGridLookUpEdit.NullText = ""
        Me.BrandGridLookUpEdit.PopupView = Me.GridView21
        Me.BrandGridLookUpEdit.ValueMember = "GMTBrandId"
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
        'GridView21
        '
        Me.GridView21.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView21.Name = "GridView21"
        Me.GridView21.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView21.OptionsView.ShowGroupPanel = False
        '
        'colShipmentStatus
        '
        Me.colShipmentStatus.ColumnEdit = Me.ShipoutStatusComboBox
        Me.colShipmentStatus.FieldName = "ShipmentStatus"
        Me.colShipmentStatus.Name = "colShipmentStatus"
        Me.colShipmentStatus.Visible = True
        Me.colShipmentStatus.VisibleIndex = 40
        Me.colShipmentStatus.Width = 88
        '
        'ShipoutStatusComboBox
        '
        Me.ShipoutStatusComboBox.AutoHeight = False
        Me.ShipoutStatusComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShipoutStatusComboBox.Items.AddRange(New Object() {"-N/A-", "Short", "Plus", "Partial", "Complete"})
        Me.ShipoutStatusComboBox.Name = "ShipoutStatusComboBox"
        Me.ShipoutStatusComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colOrderConfirmationDate
        '
        Me.colOrderConfirmationDate.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colOrderConfirmationDate.AppearanceCell.Options.UseBackColor = True
        Me.colOrderConfirmationDate.FieldName = "OrderConfirmationDate"
        Me.colOrderConfirmationDate.Name = "colOrderConfirmationDate"
        Me.colOrderConfirmationDate.Visible = True
        Me.colOrderConfirmationDate.VisibleIndex = 24
        Me.colOrderConfirmationDate.Width = 94
        '
        'colOrderReceiveDate
        '
        Me.colOrderReceiveDate.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colOrderReceiveDate.AppearanceCell.Options.UseBackColor = True
        Me.colOrderReceiveDate.FieldName = "OrderReceiveDate"
        Me.colOrderReceiveDate.Name = "colOrderReceiveDate"
        Me.colOrderReceiveDate.Visible = True
        Me.colOrderReceiveDate.VisibleIndex = 25
        Me.colOrderReceiveDate.Width = 106
        '
        'colGauge
        '
        Me.colGauge.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colGauge.AppearanceCell.Options.UseBackColor = True
        Me.colGauge.FieldName = "Gauge"
        Me.colGauge.Name = "colGauge"
        Me.colGauge.OptionsColumn.AllowEdit = False
        Me.colGauge.OptionsColumn.ReadOnly = True
        Me.colGauge.Visible = True
        Me.colGauge.VisibleIndex = 14
        '
        'colShipmentDate
        '
        Me.colShipmentDate.FieldName = "ShipmentDate"
        Me.colShipmentDate.Name = "colShipmentDate"
        Me.colShipmentDate.Visible = True
        Me.colShipmentDate.VisibleIndex = 26
        '
        'colIsBrush
        '
        Me.colIsBrush.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsBrush.AppearanceCell.Options.UseBackColor = True
        Me.colIsBrush.Caption = "Brush"
        Me.colIsBrush.FieldName = "IsBrush"
        Me.colIsBrush.Name = "colIsBrush"
        Me.colIsBrush.OptionsColumn.AllowEdit = False
        Me.colIsBrush.OptionsColumn.ReadOnly = True
        Me.colIsBrush.Visible = True
        Me.colIsBrush.VisibleIndex = 21
        '
        'colIsPeachFinish
        '
        Me.colIsPeachFinish.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsPeachFinish.AppearanceCell.Options.UseBackColor = True
        Me.colIsPeachFinish.Caption = "Peach Finish"
        Me.colIsPeachFinish.FieldName = "IsPeachFinish"
        Me.colIsPeachFinish.Name = "colIsPeachFinish"
        Me.colIsPeachFinish.OptionsColumn.AllowEdit = False
        Me.colIsPeachFinish.OptionsColumn.ReadOnly = True
        Me.colIsPeachFinish.Visible = True
        Me.colIsPeachFinish.VisibleIndex = 22
        '
        'colSeasonId
        '
        Me.colSeasonId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSeasonId.AppearanceCell.Options.UseBackColor = True
        Me.colSeasonId.Caption = "Season"
        Me.colSeasonId.ColumnEdit = Me.SeasonGridLookUpEdit
        Me.colSeasonId.FieldName = "SeasonId"
        Me.colSeasonId.Name = "colSeasonId"
        Me.colSeasonId.OptionsColumn.AllowEdit = False
        Me.colSeasonId.OptionsColumn.ReadOnly = True
        Me.colSeasonId.Visible = True
        Me.colSeasonId.VisibleIndex = 13
        '
        'SeasonGridLookUpEdit
        '
        Me.SeasonGridLookUpEdit.AutoHeight = False
        Me.SeasonGridLookUpEdit.DataSource = Me.SeasonBindingSource
        Me.SeasonGridLookUpEdit.DisplayMember = "SeasonName"
        Me.SeasonGridLookUpEdit.Name = "SeasonGridLookUpEdit"
        Me.SeasonGridLookUpEdit.NullText = ""
        Me.SeasonGridLookUpEdit.PopupView = Me.GridView27
        Me.SeasonGridLookUpEdit.ReadOnly = True
        Me.SeasonGridLookUpEdit.ValueMember = "SeasonId"
        '
        'SeasonBindingSource
        '
        Me.SeasonBindingSource.DataMember = "Season"
        Me.SeasonBindingSource.DataSource = Me.SeasonDataSet
        '
        'SeasonDataSet
        '
        Me.SeasonDataSet.DataSetName = "SeasonDataSet"
        Me.SeasonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView27
        '
        Me.GridView27.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeasonName})
        Me.GridView27.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView27.Name = "GridView27"
        Me.GridView27.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView27.OptionsView.ShowGroupPanel = False
        '
        'colSeasonName
        '
        Me.colSeasonName.FieldName = "SeasonName"
        Me.colSeasonName.Name = "colSeasonName"
        Me.colSeasonName.Visible = True
        Me.colSeasonName.VisibleIndex = 0
        '
        'colYarnBookingDate
        '
        Me.colYarnBookingDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colYarnBookingDate.AppearanceCell.Options.UseBackColor = True
        Me.colYarnBookingDate.FieldName = "YarnBookingDate"
        Me.colYarnBookingDate.Name = "colYarnBookingDate"
        Me.colYarnBookingDate.Visible = True
        Me.colYarnBookingDate.VisibleIndex = 12
        Me.colYarnBookingDate.Width = 115
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.MasterOrderGridControl
        Me.GridView2.Name = "GridView2"
        '
        'MasterOrderDetailsBindingSource
        '
        Me.MasterOrderDetailsBindingSource.DataMember = "FK_MasterOrderDetails_MasterOrder"
        Me.MasterOrderDetailsBindingSource.DataSource = Me.MasterOrderBindingSource
        '
        'MasterOrderDetailsGridControl
        '
        Me.MasterOrderDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MasterOrderDetailsGridControl.DataSource = Me.MasterOrderDetailsBindingSource
        Me.MasterOrderDetailsGridControl.Location = New System.Drawing.Point(0, 27)
        Me.MasterOrderDetailsGridControl.MainView = Me.GridView3
        Me.MasterOrderDetailsGridControl.Name = "MasterOrderDetailsGridControl"
        Me.MasterOrderDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.DestinationGridLookUpEdit, Me.SupplierGridLookUpEdit, Me.RepositoryItemGridLookUpEdit1, Me.AsignedForGridLookUpEdit, Me.ShipByComboBox, Me.RepositoryItemComboBox1, Me.CommercialTeamGridLookUpEdit, Me.CommercialTeamComboBox, Me.ShipoutStatsuDetailsComboBox})
        Me.MasterOrderDetailsGridControl.Size = New System.Drawing.Size(1337, 188)
        Me.MasterOrderDetailsGridControl.TabIndex = 2
        Me.MasterOrderDetailsGridControl.UseEmbeddedNavigator = True
        Me.MasterOrderDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView3.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView3.ColumnPanelRowHeight = 40
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo, Me.colPO, Me.colGarmentsColor, Me.colNLD, Me.colCode, Me.colPrice, Me.colEX, Me.colRFIDate1, Me.colShipmentBy, Me.colPaymentTerm, Me.colPOType, Me.colPackType, Me.colDestinationId, Me.colOrderQuantity1, Me.colIsClose, Me.colIsCancel, Me.colAmendmentNo, Me.colAmendmentDate, Me.colCauseOfAmendment, Me.colCauseOfCancel, Me.colIsDespatch, Me.colAsignedForMerchandeiser, Me.colSupplierId, Me.colIsReceivedBySupplier, Me.colRemarks1, Me.colETDDate1, Me.colTTLAmount1, Me.colModifiedOn1, Me.colCreatedOn1, Me.colColorSL, Me.colRecieveDate, Me.colRe_ETD, Me.colRe_ExFactory, Me.colRe_RFI, Me.colShipmentQTY1, Me.colShipout1, Me.colShipoutBalance1, Me.colShipoutDate1, Me.colCommercialTeam, Me.colShipmentStatus1, Me.colDSTNO, Me.colLDNo, Me.colIsAdvance})
        GridFormatRule1.Column = Me.colIsReceivedBySupplier
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = True
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.Column = Me.colIsReceivedBySupplier
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
        FormatConditionRuleValue2.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = False
        GridFormatRule2.Rule = FormatConditionRuleValue2
        GridFormatRule3.Column = Me.colAmendmentNo
        GridFormatRule3.Name = "Format2"
        FormatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
        FormatConditionRuleValue3.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Greater
        FormatConditionRuleValue3.Value1 = CType(0, Long)
        GridFormatRule3.Rule = FormatConditionRuleValue3
        GridFormatRule4.Column = Me.colShipout1
        GridFormatRule4.ColumnApplyTo = Me.colProgramNo
        GridFormatRule4.Name = "Format3"
        FormatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleValue4.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue4.Value1 = True
        GridFormatRule4.Rule = FormatConditionRuleValue4
        GridFormatRule15.Column = Me.colShipout1
        GridFormatRule15.ColumnApplyTo = Me.colProgramNo
        GridFormatRule15.Name = "Format4"
        FormatConditionRuleValue15.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
        FormatConditionRuleValue15.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue15.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue15.Value1 = False
        GridFormatRule15.Rule = FormatConditionRuleValue15
        GridFormatRule16.Column = Me.colShipout1
        GridFormatRule16.ColumnApplyTo = Me.colProgramNo
        GridFormatRule16.Name = "Format5"
        FormatConditionRuleValue16.Appearance.BackColor = System.Drawing.Color.LightSkyBlue
        FormatConditionRuleValue16.Appearance.Options.UseBackColor = True
        FormatConditionRuleValue16.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        GridFormatRule16.Rule = FormatConditionRuleValue16
        Me.GridView3.FormatRules.Add(GridFormatRule1)
        Me.GridView3.FormatRules.Add(GridFormatRule2)
        Me.GridView3.FormatRules.Add(GridFormatRule3)
        Me.GridView3.FormatRules.Add(GridFormatRule4)
        Me.GridView3.FormatRules.Add(GridFormatRule15)
        Me.GridView3.FormatRules.Add(GridFormatRule16)
        Me.GridView3.GridControl = Me.MasterOrderDetailsGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowDetailButtons = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colPO
        '
        Me.colPO.FieldName = "PO"
        Me.colPO.Name = "colPO"
        Me.colPO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colPO.Visible = True
        Me.colPO.VisibleIndex = 2
        Me.colPO.Width = 130
        '
        'colGarmentsColor
        '
        Me.colGarmentsColor.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colGarmentsColor.FieldName = "GarmentsColor"
        Me.colGarmentsColor.Name = "colGarmentsColor"
        Me.colGarmentsColor.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colGarmentsColor.Visible = True
        Me.colGarmentsColor.VisibleIndex = 5
        Me.colGarmentsColor.Width = 140
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.FabricColorBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "FabricColorName"
        Me.RepositoryItemGridLookUpEdit1.ImmediatePopup = True
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.GridView11
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "FabricColorId"
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
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName})
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        '
        'colNLD
        '
        Me.colNLD.Caption = "Pantone No/Color Reference"
        Me.colNLD.FieldName = "NLD"
        Me.colNLD.Name = "colNLD"
        Me.colNLD.Visible = True
        Me.colNLD.VisibleIndex = 7
        Me.colNLD.Width = 133
        '
        'colCode
        '
        Me.colCode.Caption = "Color Code"
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 6
        Me.colCode.Width = 44
        '
        'colPrice
        '
        Me.colPrice.Caption = "Price FOB ($)"
        Me.colPrice.DisplayFormat.FormatString = "##,##.00"
        Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 9
        Me.colPrice.Width = 67
        '
        'colEX
        '
        Me.colEX.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colEX.AppearanceCell.Options.UseBackColor = True
        Me.colEX.Caption = "Ex Factory Date"
        Me.colEX.FieldName = "EX"
        Me.colEX.Name = "colEX"
        Me.colEX.Visible = True
        Me.colEX.VisibleIndex = 14
        Me.colEX.Width = 87
        '
        'colRFIDate1
        '
        Me.colRFIDate1.FieldName = "RFIDate"
        Me.colRFIDate1.Name = "colRFIDate1"
        Me.colRFIDate1.Visible = True
        Me.colRFIDate1.VisibleIndex = 12
        '
        'colShipmentBy
        '
        Me.colShipmentBy.Caption = "Mode Of Shipment"
        Me.colShipmentBy.ColumnEdit = Me.ShipByComboBox
        Me.colShipmentBy.FieldName = "ShipmentBy"
        Me.colShipmentBy.Name = "colShipmentBy"
        Me.colShipmentBy.Visible = True
        Me.colShipmentBy.VisibleIndex = 18
        Me.colShipmentBy.Width = 76
        '
        'ShipByComboBox
        '
        Me.ShipByComboBox.AutoHeight = False
        Me.ShipByComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShipByComboBox.Items.AddRange(New Object() {"Sea", "Air", "Sea_Air"})
        Me.ShipByComboBox.Name = "ShipByComboBox"
        '
        'colPaymentTerm
        '
        Me.colPaymentTerm.FieldName = "PaymentTerm"
        Me.colPaymentTerm.Name = "colPaymentTerm"
        Me.colPaymentTerm.Visible = True
        Me.colPaymentTerm.VisibleIndex = 25
        '
        'colPOType
        '
        Me.colPOType.FieldName = "POType"
        Me.colPOType.Name = "colPOType"
        Me.colPOType.Visible = True
        Me.colPOType.VisibleIndex = 26
        Me.colPOType.Width = 81
        '
        'colPackType
        '
        Me.colPackType.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colPackType.FieldName = "PackType"
        Me.colPackType.Name = "colPackType"
        Me.colPackType.Visible = True
        Me.colPackType.VisibleIndex = 3
        Me.colPackType.Width = 93
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"-", "Normal", "Ratio", "Solid Color Solid Size", "Solid Color Assort Size", "Assort Color Solid Size", "Assort Color Assort Size", "Store Wise"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colDestinationId
        '
        Me.colDestinationId.Caption = "Destination"
        Me.colDestinationId.ColumnEdit = Me.DestinationGridLookUpEdit
        Me.colDestinationId.FieldName = "DestinationId"
        Me.colDestinationId.Name = "colDestinationId"
        Me.colDestinationId.Visible = True
        Me.colDestinationId.VisibleIndex = 21
        Me.colDestinationId.Width = 87
        '
        'DestinationGridLookUpEdit
        '
        Me.DestinationGridLookUpEdit.AutoHeight = False
        Me.DestinationGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DestinationGridLookUpEdit.DataSource = Me.DestinationBindingSource
        Me.DestinationGridLookUpEdit.DisplayMember = "DestinationCode"
        Me.DestinationGridLookUpEdit.Name = "DestinationGridLookUpEdit"
        Me.DestinationGridLookUpEdit.NullText = ""
        Me.DestinationGridLookUpEdit.PopupView = Me.GridView9
        Me.DestinationGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DestinationGridLookUpEdit.ValueMember = "DestinationId"
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
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDestinationCode1})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colDestinationCode1
        '
        Me.colDestinationCode1.FieldName = "DestinationCode"
        Me.colDestinationCode1.Name = "colDestinationCode1"
        Me.colDestinationCode1.Visible = True
        Me.colDestinationCode1.VisibleIndex = 0
        '
        'colOrderQuantity1
        '
        Me.colOrderQuantity1.FieldName = "OrderQuantity"
        Me.colOrderQuantity1.Name = "colOrderQuantity1"
        Me.colOrderQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colOrderQuantity1.Visible = True
        Me.colOrderQuantity1.VisibleIndex = 10
        Me.colOrderQuantity1.Width = 73
        '
        'colIsClose
        '
        Me.colIsClose.FieldName = "IsClose"
        Me.colIsClose.Name = "colIsClose"
        Me.colIsClose.Visible = True
        Me.colIsClose.VisibleIndex = 34
        Me.colIsClose.Width = 91
        '
        'colIsCancel
        '
        Me.colIsCancel.FieldName = "IsCancel"
        Me.colIsCancel.Name = "colIsCancel"
        Me.colIsCancel.Visible = True
        Me.colIsCancel.VisibleIndex = 35
        Me.colIsCancel.Width = 80
        '
        'colAmendmentDate
        '
        Me.colAmendmentDate.FieldName = "AmendmentDate"
        Me.colAmendmentDate.Name = "colAmendmentDate"
        Me.colAmendmentDate.OptionsColumn.AllowEdit = False
        Me.colAmendmentDate.Visible = True
        Me.colAmendmentDate.VisibleIndex = 23
        '
        'colCauseOfAmendment
        '
        Me.colCauseOfAmendment.FieldName = "CauseOfAmendment"
        Me.colCauseOfAmendment.Name = "colCauseOfAmendment"
        Me.colCauseOfAmendment.Visible = True
        Me.colCauseOfAmendment.VisibleIndex = 24
        '
        'colCauseOfCancel
        '
        Me.colCauseOfCancel.FieldName = "CauseOfCancel"
        Me.colCauseOfCancel.Name = "colCauseOfCancel"
        Me.colCauseOfCancel.Visible = True
        Me.colCauseOfCancel.VisibleIndex = 36
        Me.colCauseOfCancel.Width = 129
        '
        'colIsDespatch
        '
        Me.colIsDespatch.FieldName = "IsDespatch"
        Me.colIsDespatch.Name = "colIsDespatch"
        Me.colIsDespatch.Visible = True
        Me.colIsDespatch.VisibleIndex = 33
        Me.colIsDespatch.Width = 126
        '
        'colAsignedForMerchandeiser
        '
        Me.colAsignedForMerchandeiser.Caption = "Factory Merchandiser"
        Me.colAsignedForMerchandeiser.ColumnEdit = Me.AsignedForGridLookUpEdit
        Me.colAsignedForMerchandeiser.FieldName = "AsignedForMerchandeiser"
        Me.colAsignedForMerchandeiser.Name = "colAsignedForMerchandeiser"
        Me.colAsignedForMerchandeiser.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colAsignedForMerchandeiser.Visible = True
        Me.colAsignedForMerchandeiser.VisibleIndex = 27
        Me.colAsignedForMerchandeiser.Width = 92
        '
        'AsignedForGridLookUpEdit
        '
        Me.AsignedForGridLookUpEdit.AutoHeight = False
        Me.AsignedForGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AsignedForGridLookUpEdit.DataSource = Me.UserLookupBindingSource
        Me.AsignedForGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.AsignedForGridLookUpEdit.Name = "AsignedForGridLookUpEdit"
        Me.AsignedForGridLookUpEdit.NullText = ""
        Me.AsignedForGridLookUpEdit.PopupView = Me.GridView14
        Me.AsignedForGridLookUpEdit.ValueMember = "USER_ID"
        '
        'GridView14
        '
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME3})
        Me.GridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView14.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME3
        '
        Me.colUSER_NAME3.Caption = "Merchandiser"
        Me.colUSER_NAME3.FieldName = "USER_NAME"
        Me.colUSER_NAME3.Name = "colUSER_NAME3"
        Me.colUSER_NAME3.Visible = True
        Me.colUSER_NAME3.VisibleIndex = 0
        '
        'colSupplierId
        '
        Me.colSupplierId.Caption = "Company Name"
        Me.colSupplierId.ColumnEdit = Me.SupplierGridLookUpEdit
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.Visible = True
        Me.colSupplierId.VisibleIndex = 29
        Me.colSupplierId.Width = 109
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.AutoHeight = False
        Me.SupplierGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierGridLookUpEdit.DataSource = Me.SupplierBindingSource
        Me.SupplierGridLookUpEdit.DisplayMember = "SupplierName"
        Me.SupplierGridLookUpEdit.ImmediatePopup = True
        Me.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit"
        Me.SupplierGridLookUpEdit.PopupView = Me.GridView10
        Me.SupplierGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierGridLookUpEdit.ValueMember = "SupplierId"
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
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierCode})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 0
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 42
        Me.colRemarks1.Width = 89
        '
        'colETDDate1
        '
        Me.colETDDate1.FieldName = "ETDDate"
        Me.colETDDate1.Name = "colETDDate1"
        Me.colETDDate1.Visible = True
        Me.colETDDate1.VisibleIndex = 16
        '
        'colTTLAmount1
        '
        Me.colTTLAmount1.Caption = "Total Value ($)"
        Me.colTTLAmount1.DisplayFormat.FormatString = "##,##.00"
        Me.colTTLAmount1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTTLAmount1.FieldName = "TTLAmount"
        Me.colTTLAmount1.Name = "colTTLAmount1"
        Me.colTTLAmount1.Visible = True
        Me.colTTLAmount1.VisibleIndex = 11
        '
        'colModifiedOn1
        '
        Me.colModifiedOn1.FieldName = "ModifiedOn"
        Me.colModifiedOn1.Name = "colModifiedOn1"
        Me.colModifiedOn1.Visible = True
        Me.colModifiedOn1.VisibleIndex = 32
        '
        'colCreatedOn1
        '
        Me.colCreatedOn1.FieldName = "CreatedOn"
        Me.colCreatedOn1.Name = "colCreatedOn1"
        Me.colCreatedOn1.OptionsColumn.AllowEdit = False
        Me.colCreatedOn1.Visible = True
        Me.colCreatedOn1.VisibleIndex = 31
        '
        'colColorSL
        '
        Me.colColorSL.FieldName = "ColorSL"
        Me.colColorSL.Name = "colColorSL"
        Me.colColorSL.Visible = True
        Me.colColorSL.VisibleIndex = 4
        Me.colColorSL.Width = 57
        '
        'colRecieveDate
        '
        Me.colRecieveDate.FieldName = "RecieveDate"
        Me.colRecieveDate.Name = "colRecieveDate"
        Me.colRecieveDate.Visible = True
        Me.colRecieveDate.VisibleIndex = 30
        '
        'colRe_ETD
        '
        Me.colRe_ETD.Caption = "Re-ETD"
        Me.colRe_ETD.FieldName = "Re_ETD"
        Me.colRe_ETD.Name = "colRe_ETD"
        Me.colRe_ETD.Visible = True
        Me.colRe_ETD.VisibleIndex = 17
        Me.colRe_ETD.Width = 76
        '
        'colRe_ExFactory
        '
        Me.colRe_ExFactory.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colRe_ExFactory.AppearanceCell.Options.UseBackColor = True
        Me.colRe_ExFactory.Caption = "First Ex-Factory Date"
        Me.colRe_ExFactory.FieldName = "Re_ExFactory"
        Me.colRe_ExFactory.Name = "colRe_ExFactory"
        Me.colRe_ExFactory.OptionsColumn.AllowEdit = False
        Me.colRe_ExFactory.OptionsColumn.ReadOnly = True
        Me.colRe_ExFactory.Visible = True
        Me.colRe_ExFactory.VisibleIndex = 15
        Me.colRe_ExFactory.Width = 84
        '
        'colRe_RFI
        '
        Me.colRe_RFI.Caption = "Re-RFI"
        Me.colRe_RFI.FieldName = "Re_RFI"
        Me.colRe_RFI.Name = "colRe_RFI"
        Me.colRe_RFI.Visible = True
        Me.colRe_RFI.VisibleIndex = 13
        '
        'colShipmentQTY1
        '
        Me.colShipmentQTY1.FieldName = "ShipmentQTY"
        Me.colShipmentQTY1.Name = "colShipmentQTY1"
        Me.colShipmentQTY1.Visible = True
        Me.colShipmentQTY1.VisibleIndex = 40
        '
        'colShipoutBalance1
        '
        Me.colShipoutBalance1.FieldName = "ShipoutBalance"
        Me.colShipoutBalance1.Name = "colShipoutBalance1"
        Me.colShipoutBalance1.Visible = True
        Me.colShipoutBalance1.VisibleIndex = 41
        Me.colShipoutBalance1.Width = 91
        '
        'colShipoutDate1
        '
        Me.colShipoutDate1.FieldName = "ShipoutDate"
        Me.colShipoutDate1.Name = "colShipoutDate1"
        Me.colShipoutDate1.Visible = True
        Me.colShipoutDate1.VisibleIndex = 38
        '
        'colCommercialTeam
        '
        Me.colCommercialTeam.Caption = "Shipment  Terms"
        Me.colCommercialTeam.ColumnEdit = Me.CommercialTeamComboBox
        Me.colCommercialTeam.FieldName = "CommercialTeam"
        Me.colCommercialTeam.Name = "colCommercialTeam"
        Me.colCommercialTeam.Visible = True
        Me.colCommercialTeam.VisibleIndex = 19
        '
        'CommercialTeamComboBox
        '
        Me.CommercialTeamComboBox.AutoHeight = False
        Me.CommercialTeamComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CommercialTeamComboBox.Items.AddRange(New Object() {"FOB", "CIF", "CNF", "CPT", "FCA"})
        Me.CommercialTeamComboBox.Name = "CommercialTeamComboBox"
        '
        'colShipmentStatus1
        '
        Me.colShipmentStatus1.ColumnEdit = Me.ShipoutStatsuDetailsComboBox
        Me.colShipmentStatus1.FieldName = "ShipmentStatus"
        Me.colShipmentStatus1.Name = "colShipmentStatus1"
        Me.colShipmentStatus1.Visible = True
        Me.colShipmentStatus1.VisibleIndex = 39
        '
        'ShipoutStatsuDetailsComboBox
        '
        Me.ShipoutStatsuDetailsComboBox.AutoHeight = False
        Me.ShipoutStatsuDetailsComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShipoutStatsuDetailsComboBox.Items.AddRange(New Object() {"-N/A-", "Plus", "Minus", "Partial", "Complete"})
        Me.ShipoutStatsuDetailsComboBox.Name = "ShipoutStatsuDetailsComboBox"
        Me.ShipoutStatsuDetailsComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colDSTNO
        '
        Me.colDSTNO.Caption = "DST No."
        Me.colDSTNO.FieldName = "DSTNO"
        Me.colDSTNO.Name = "colDSTNO"
        Me.colDSTNO.Visible = True
        Me.colDSTNO.VisibleIndex = 20
        '
        'colLDNo
        '
        Me.colLDNo.FieldName = "LDNo"
        Me.colLDNo.Name = "colLDNo"
        Me.colLDNo.Visible = True
        Me.colLDNo.VisibleIndex = 8
        '
        'CommercialTeamGridLookUpEdit
        '
        Me.CommercialTeamGridLookUpEdit.AutoHeight = False
        Me.CommercialTeamGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CommercialTeamGridLookUpEdit.Name = "CommercialTeamGridLookUpEdit"
        Me.CommercialTeamGridLookUpEdit.NullText = ""
        Me.CommercialTeamGridLookUpEdit.PopupView = Me.GridView20
        '
        'GridView20
        '
        Me.GridView20.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView20.Name = "GridView20"
        Me.GridView20.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView20.OptionsView.ShowGroupPanel = False
        '
        'MasterOrderSizeDetailsBindingSource
        '
        Me.MasterOrderSizeDetailsBindingSource.DataMember = "FK_MasterOrderSizeDetails_MasterOrderDetails"
        Me.MasterOrderSizeDetailsBindingSource.DataSource = Me.MasterOrderDetailsBindingSource
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(1, 34)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.MasterOrderGridControl)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1340, 671)
        Me.SplitContainerControl1.SplitterPosition = 251
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.BlockButton)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.Supplier)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.SupplierGridLookUpEdit1)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.CopyPOButton)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.ProgramButton)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.MasterOrderDetailsGridControl)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.btnMasterOrderDetailsAmnd)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.SplitContainerControl3)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1340, 415)
        Me.SplitContainerControl2.SplitterPosition = 216
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'Supplier
        '
        Me.Supplier.AutoSize = True
        Me.Supplier.Location = New System.Drawing.Point(23, 4)
        Me.Supplier.Name = "Supplier"
        Me.Supplier.Size = New System.Drawing.Size(44, 13)
        Me.Supplier.TabIndex = 6
        Me.Supplier.Text = "Factory"
        '
        'SupplierGridLookUpEdit1
        '
        Me.SupplierGridLookUpEdit1.EditValue = ""
        Me.SupplierGridLookUpEdit1.Location = New System.Drawing.Point(74, 1)
        Me.SupplierGridLookUpEdit1.Name = "SupplierGridLookUpEdit1"
        Me.SupplierGridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierGridLookUpEdit1.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierGridLookUpEdit1.Properties.DisplayMember = "SupplierName"
        Me.SupplierGridLookUpEdit1.Properties.ImmediatePopup = True
        Me.SupplierGridLookUpEdit1.Properties.PopupView = Me.GridLookUpEdit1View
        Me.SupplierGridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierGridLookUpEdit1.Properties.ValueMember = "SupplierId"
        Me.SupplierGridLookUpEdit1.Size = New System.Drawing.Size(298, 20)
        Me.SupplierGridLookUpEdit1.TabIndex = 5
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierName4, Me.colProgramCode3})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colSupplierName4
        '
        Me.colSupplierName4.FieldName = "SupplierName"
        Me.colSupplierName4.Name = "colSupplierName4"
        Me.colSupplierName4.Visible = True
        Me.colSupplierName4.VisibleIndex = 0
        '
        'colProgramCode3
        '
        Me.colProgramCode3.FieldName = "ProgramCode"
        Me.colProgramCode3.Name = "colProgramCode3"
        Me.colProgramCode3.Visible = True
        Me.colProgramCode3.VisibleIndex = 1
        '
        'CopyPOButton
        '
        Me.CopyPOButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CopyPOButton.Appearance.Options.UseForeColor = True
        Me.CopyPOButton.Location = New System.Drawing.Point(508, 1)
        Me.CopyPOButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FloralWhite
        Me.CopyPOButton.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CopyPOButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CopyPOButton.Name = "CopyPOButton"
        Me.CopyPOButton.Size = New System.Drawing.Size(82, 23)
        Me.CopyPOButton.TabIndex = 4
        Me.CopyPOButton.Text = "Copy"
        '
        'ProgramButton
        '
        Me.ProgramButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgramButton.Appearance.Options.UseForeColor = True
        Me.ProgramButton.Location = New System.Drawing.Point(378, 1)
        Me.ProgramButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FloralWhite
        Me.ProgramButton.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgramButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ProgramButton.Name = "ProgramButton"
        Me.ProgramButton.Size = New System.Drawing.Size(124, 23)
        Me.ProgramButton.TabIndex = 3
        Me.ProgramButton.Text = "Generate Program No"
        '
        'btnMasterOrderDetailsAmnd
        '
        Me.btnMasterOrderDetailsAmnd.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMasterOrderDetailsAmnd.Appearance.Options.UseForeColor = True
        Me.btnMasterOrderDetailsAmnd.Location = New System.Drawing.Point(596, 1)
        Me.btnMasterOrderDetailsAmnd.LookAndFeel.SkinMaskColor = System.Drawing.Color.FloralWhite
        Me.btnMasterOrderDetailsAmnd.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMasterOrderDetailsAmnd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnMasterOrderDetailsAmnd.Name = "btnMasterOrderDetailsAmnd"
        Me.btnMasterOrderDetailsAmnd.Size = New System.Drawing.Size(201, 23)
        Me.btnMasterOrderDetailsAmnd.TabIndex = 52
        Me.btnMasterOrderDetailsAmnd.Text = "&Add Master Order Details Amendment"
        '
        'SplitContainerControl3
        '
        Me.SplitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl3.Name = "SplitContainerControl3"
        Me.SplitContainerControl3.Panel1.Text = "Panel1"
        Me.SplitContainerControl3.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl3.Panel2.Text = "Panel2"
        Me.SplitContainerControl3.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
        Me.SplitContainerControl3.Size = New System.Drawing.Size(1340, 194)
        Me.SplitContainerControl3.SplitterPosition = 569
        Me.SplitContainerControl3.TabIndex = 0
        Me.SplitContainerControl3.Text = "SplitContainerControl3"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.LookAndFeel.SkinName = "VS2010"
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.SizeAndInstructionXtraTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(1340, 194)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.SizeAndInstructionXtraTabPage, Me.SampleStatus, Me.MasterOrderAmndHistory, Me.MasterOrderDetailsAmndHistory, Me.Document})
        '
        'SizeAndInstructionXtraTabPage
        '
        Me.SizeAndInstructionXtraTabPage.AutoScroll = True
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.CalculateRatioButton)
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.MasterOrderSizeDetailsGridControl)
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.PasteButton)
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.CopyButton)
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.OrderInstructionGridControl)
        Me.SizeAndInstructionXtraTabPage.Name = "SizeAndInstructionXtraTabPage"
        Me.SizeAndInstructionXtraTabPage.Size = New System.Drawing.Size(1338, 161)
        Me.SizeAndInstructionXtraTabPage.Text = "Size And Instruction"
        '
        'CalculateRatioButton
        '
        Me.CalculateRatioButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CalculateRatioButton.Appearance.Options.UseForeColor = True
        Me.CalculateRatioButton.Location = New System.Drawing.Point(344, 77)
        Me.CalculateRatioButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.MidnightBlue
        Me.CalculateRatioButton.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CalculateRatioButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CalculateRatioButton.Name = "CalculateRatioButton"
        Me.CalculateRatioButton.Size = New System.Drawing.Size(147, 25)
        Me.CalculateRatioButton.TabIndex = 6
        Me.CalculateRatioButton.Text = "Calculate By Ratio"
        '
        'MasterOrderSizeDetailsGridControl
        '
        Me.MasterOrderSizeDetailsGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MasterOrderSizeDetailsGridControl.DataSource = Me.MasterOrderSizeDetailsBindingSource
        Me.MasterOrderSizeDetailsGridControl.Location = New System.Drawing.Point(3, 3)
        Me.MasterOrderSizeDetailsGridControl.MainView = Me.GridView4
        Me.MasterOrderSizeDetailsGridControl.Name = "MasterOrderSizeDetailsGridControl"
        Me.MasterOrderSizeDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeLookupGridLookUpEdit})
        Me.MasterOrderSizeDetailsGridControl.Size = New System.Drawing.Size(335, 155)
        Me.MasterOrderSizeDetailsGridControl.TabIndex = 5
        Me.MasterOrderSizeDetailsGridControl.UseEmbeddedNavigator = True
        Me.MasterOrderSizeDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeId, Me.colOrderQuantity2, Me.colRatio})
        Me.GridView4.GridControl = Me.MasterOrderSizeDetailsGridControl
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colSizeId
        '
        Me.colSizeId.Caption = "Size"
        Me.colSizeId.ColumnEdit = Me.SizeLookupGridLookUpEdit
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        Me.colSizeId.Visible = True
        Me.colSizeId.VisibleIndex = 0
        '
        'SizeLookupGridLookUpEdit
        '
        Me.SizeLookupGridLookUpEdit.AutoHeight = False
        Me.SizeLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeLookupGridLookUpEdit.DataSource = Me.SizeBindingSource
        Me.SizeLookupGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeLookupGridLookUpEdit.ImmediatePopup = True
        Me.SizeLookupGridLookUpEdit.Name = "SizeLookupGridLookUpEdit"
        Me.SizeLookupGridLookUpEdit.NullText = ""
        Me.SizeLookupGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SizeLookupGridLookUpEdit.PopupView = Me.GridView26
        Me.SizeLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SizeLookupGridLookUpEdit.ValueMember = "SizeId"
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
        'GridView26
        '
        Me.GridView26.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode})
        Me.GridView26.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView26.Name = "GridView26"
        Me.GridView26.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView26.OptionsView.ShowGroupPanel = False
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'colOrderQuantity2
        '
        Me.colOrderQuantity2.FieldName = "OrderQuantity"
        Me.colOrderQuantity2.Name = "colOrderQuantity2"
        Me.colOrderQuantity2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colOrderQuantity2.Visible = True
        Me.colOrderQuantity2.VisibleIndex = 1
        '
        'colRatio
        '
        Me.colRatio.FieldName = "Ratio"
        Me.colRatio.Name = "colRatio"
        Me.colRatio.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colRatio.Visible = True
        Me.colRatio.VisibleIndex = 2
        '
        'PasteButton
        '
        Me.PasteButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PasteButton.Appearance.Options.UseForeColor = True
        Me.PasteButton.Location = New System.Drawing.Point(344, 47)
        Me.PasteButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.MidnightBlue
        Me.PasteButton.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PasteButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PasteButton.Name = "PasteButton"
        Me.PasteButton.Size = New System.Drawing.Size(147, 24)
        Me.PasteButton.TabIndex = 5
        Me.PasteButton.Text = "&Paste Size To PO"
        '
        'CopyButton
        '
        Me.CopyButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CopyButton.Appearance.Options.UseForeColor = True
        Me.CopyButton.Location = New System.Drawing.Point(344, 17)
        Me.CopyButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.MidnightBlue
        Me.CopyButton.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CopyButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(147, 24)
        Me.CopyButton.TabIndex = 4
        Me.CopyButton.Text = "&Copy Size From PO"
        '
        'OrderInstructionGridControl
        '
        Me.OrderInstructionGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderInstructionGridControl.DataSource = Me.MasterOrderInstructionBindingSource
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.OrderInstructionGridControl.Location = New System.Drawing.Point(497, 3)
        Me.OrderInstructionGridControl.MainView = Me.GridView12
        Me.OrderInstructionGridControl.Name = "OrderInstructionGridControl"
        Me.OrderInstructionGridControl.Size = New System.Drawing.Size(836, 155)
        Me.OrderInstructionGridControl.TabIndex = 1
        Me.OrderInstructionGridControl.UseEmbeddedNavigator = True
        Me.OrderInstructionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView12, Me.GridView33})
        '
        'MasterOrderInstructionBindingSource
        '
        Me.MasterOrderInstructionBindingSource.DataMember = "FK_MasterOrderInstruction_MasterOrder"
        Me.MasterOrderInstructionBindingSource.DataSource = Me.MasterOrderBindingSource
        '
        'GridView12
        '
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderInstructionId, Me.colOrderId, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colModifiedDate})
        Me.GridView12.GridControl = Me.OrderInstructionGridControl
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsCustomization.AllowGroup = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        '
        'colOrderInstructionId
        '
        Me.colOrderInstructionId.FieldName = "OrderInstructionId"
        Me.colOrderInstructionId.Name = "colOrderInstructionId"
        Me.colOrderInstructionId.OptionsColumn.ReadOnly = True
        Me.colOrderInstructionId.Width = 143
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.Width = 105
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "SL No"
        Me.GridColumn1.FieldName = "InstructionSlNo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 57
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Instruction"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 627
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "InstructionDate"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 196
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "UserId"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 105
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        Me.colModifiedDate.Width = 113
        '
        'GridView33
        '
        Me.GridView33.GridControl = Me.OrderInstructionGridControl
        Me.GridView33.Name = "GridView33"
        '
        'SampleStatus
        '
        Me.SampleStatus.Appearance.PageClient.BackColor = System.Drawing.Color.LightGray
        Me.SampleStatus.Appearance.PageClient.Options.UseBackColor = True
        Me.SampleStatus.AutoScroll = True
        Me.SampleStatus.Controls.Add(Me.DeleteSampleStatusButton)
        Me.SampleStatus.Controls.Add(Me.MasterOrderSampleStatusGridControl)
        Me.SampleStatus.Controls.Add(Me.AddSampleStatusButton)
        Me.SampleStatus.Name = "SampleStatus"
        Me.SampleStatus.Size = New System.Drawing.Size(1338, 161)
        Me.SampleStatus.Text = "Sample Status"
        '
        'DeleteSampleStatusButton
        '
        Me.DeleteSampleStatusButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteSampleStatusButton.Location = New System.Drawing.Point(1261, 39)
        Me.DeleteSampleStatusButton.Name = "DeleteSampleStatusButton"
        Me.DeleteSampleStatusButton.Size = New System.Drawing.Size(67, 27)
        Me.DeleteSampleStatusButton.TabIndex = 54
        Me.DeleteSampleStatusButton.Text = "&Delete"
        '
        'MasterOrderSampleStatusGridControl
        '
        Me.MasterOrderSampleStatusGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MasterOrderSampleStatusGridControl.DataSource = Me.MasterOrderSampleStatusBindingSource
        Me.MasterOrderSampleStatusGridControl.Location = New System.Drawing.Point(0, 0)
        Me.MasterOrderSampleStatusGridControl.MainView = Me.GridView22
        Me.MasterOrderSampleStatusGridControl.Name = "MasterOrderSampleStatusGridControl"
        Me.MasterOrderSampleStatusGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ApprovedComboBox, Me.SampleTypeGridLookUpEdit})
        Me.MasterOrderSampleStatusGridControl.Size = New System.Drawing.Size(1250, 171)
        Me.MasterOrderSampleStatusGridControl.TabIndex = 0
        Me.MasterOrderSampleStatusGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView22})
        '
        'MasterOrderSampleStatusBindingSource
        '
        Me.MasterOrderSampleStatusBindingSource.DataMember = "FK_MasterOrderSampleStatus_MasterOrder"
        Me.MasterOrderSampleStatusBindingSource.DataSource = Me.MasterOrderBindingSource
        '
        'GridView22
        '
        Me.GridView22.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView22.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView22.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView22.ColumnPanelRowHeight = 40
        Me.GridView22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSampleRequestNo, Me.colSampleRequestDate, Me.colSampleSendDate, Me.colSendingInfo, Me.colCommentsReceive, Me.colApproved, Me.colIsReceived, Me.colDevTypeId, Me.colRemarks2, Me.colSLNo, Me.colSampleRequiredDate})
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Column = Me.colIsReceived
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = True
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Column = Me.colIsReceived
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = False
        StyleFormatCondition4.Value2 = "<Null>"
        Me.GridView22.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3, StyleFormatCondition4})
        Me.GridView22.GridControl = Me.MasterOrderSampleStatusGridControl
        Me.GridView22.Name = "GridView22"
        Me.GridView22.OptionsView.ShowGroupPanel = False
        '
        'colSampleRequestNo
        '
        Me.colSampleRequestNo.Caption = "Sample Program No"
        Me.colSampleRequestNo.FieldName = "SampleRequestNo"
        Me.colSampleRequestNo.Name = "colSampleRequestNo"
        Me.colSampleRequestNo.Visible = True
        Me.colSampleRequestNo.VisibleIndex = 1
        Me.colSampleRequestNo.Width = 122
        '
        'colSampleRequestDate
        '
        Me.colSampleRequestDate.Caption = "SP Request Date"
        Me.colSampleRequestDate.FieldName = "SampleRequestDate"
        Me.colSampleRequestDate.Name = "colSampleRequestDate"
        Me.colSampleRequestDate.Visible = True
        Me.colSampleRequestDate.VisibleIndex = 2
        Me.colSampleRequestDate.Width = 96
        '
        'colSampleSendDate
        '
        Me.colSampleSendDate.FieldName = "SampleSendDate"
        Me.colSampleSendDate.Name = "colSampleSendDate"
        Me.colSampleSendDate.Visible = True
        Me.colSampleSendDate.VisibleIndex = 5
        Me.colSampleSendDate.Width = 83
        '
        'colSendingInfo
        '
        Me.colSendingInfo.FieldName = "SendingInfo"
        Me.colSendingInfo.Name = "colSendingInfo"
        Me.colSendingInfo.Visible = True
        Me.colSendingInfo.VisibleIndex = 6
        Me.colSendingInfo.Width = 188
        '
        'colCommentsReceive
        '
        Me.colCommentsReceive.Caption = "Comments Receive Date"
        Me.colCommentsReceive.FieldName = "CommentsReceive"
        Me.colCommentsReceive.Name = "colCommentsReceive"
        Me.colCommentsReceive.Visible = True
        Me.colCommentsReceive.VisibleIndex = 7
        Me.colCommentsReceive.Width = 111
        '
        'colApproved
        '
        Me.colApproved.Caption = "Approval Status"
        Me.colApproved.ColumnEdit = Me.ApprovedComboBox
        Me.colApproved.FieldName = "Approved"
        Me.colApproved.Name = "colApproved"
        Me.colApproved.Visible = True
        Me.colApproved.VisibleIndex = 8
        Me.colApproved.Width = 105
        '
        'ApprovedComboBox
        '
        Me.ApprovedComboBox.AutoHeight = False
        Me.ApprovedComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ApprovedComboBox.Items.AddRange(New Object() {"Approved", "Conditional Approved", "Not Approved"})
        Me.ApprovedComboBox.Name = "ApprovedComboBox"
        '
        'colDevTypeId
        '
        Me.colDevTypeId.Caption = "Sample Type"
        Me.colDevTypeId.ColumnEdit = Me.SampleTypeGridLookUpEdit
        Me.colDevTypeId.FieldName = "DevTypeId"
        Me.colDevTypeId.Name = "colDevTypeId"
        Me.colDevTypeId.Visible = True
        Me.colDevTypeId.VisibleIndex = 4
        Me.colDevTypeId.Width = 115
        '
        'SampleTypeGridLookUpEdit
        '
        Me.SampleTypeGridLookUpEdit.AutoHeight = False
        Me.SampleTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleTypeGridLookUpEdit.DataSource = Me.DevTypeMstBindingSource
        Me.SampleTypeGridLookUpEdit.DisplayMember = "DevType"
        Me.SampleTypeGridLookUpEdit.ImmediatePopup = True
        Me.SampleTypeGridLookUpEdit.Name = "SampleTypeGridLookUpEdit"
        Me.SampleTypeGridLookUpEdit.NullText = ""
        Me.SampleTypeGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SampleTypeGridLookUpEdit.PopupView = Me.GridView25
        Me.SampleTypeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SampleTypeGridLookUpEdit.ValueMember = "DevTypeId"
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
        'GridView25
        '
        Me.GridView25.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView25.Name = "GridView25"
        Me.GridView25.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView25.OptionsView.ShowGroupPanel = False
        '
        'colRemarks2
        '
        Me.colRemarks2.FieldName = "Remarks"
        Me.colRemarks2.Name = "colRemarks2"
        Me.colRemarks2.Visible = True
        Me.colRemarks2.VisibleIndex = 10
        Me.colRemarks2.Width = 226
        '
        'colSLNo
        '
        Me.colSLNo.FieldName = "SLNo"
        Me.colSLNo.Name = "colSLNo"
        Me.colSLNo.Visible = True
        Me.colSLNo.VisibleIndex = 0
        Me.colSLNo.Width = 56
        '
        'colSampleRequiredDate
        '
        Me.colSampleRequiredDate.FieldName = "SampleRequiredDate"
        Me.colSampleRequiredDate.Name = "colSampleRequiredDate"
        Me.colSampleRequiredDate.Visible = True
        Me.colSampleRequiredDate.VisibleIndex = 3
        Me.colSampleRequiredDate.Width = 84
        '
        'AddSampleStatusButton
        '
        Me.AddSampleStatusButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddSampleStatusButton.Location = New System.Drawing.Point(1261, 6)
        Me.AddSampleStatusButton.Name = "AddSampleStatusButton"
        Me.AddSampleStatusButton.Size = New System.Drawing.Size(67, 27)
        Me.AddSampleStatusButton.TabIndex = 53
        Me.AddSampleStatusButton.Text = "&Add"
        '
        'MasterOrderAmndHistory
        '
        Me.MasterOrderAmndHistory.AutoScroll = True
        Me.MasterOrderAmndHistory.Controls.Add(Me.MasterOrderAmendmentHistoryGridControl)
        Me.MasterOrderAmndHistory.Name = "MasterOrderAmndHistory"
        Me.MasterOrderAmndHistory.Size = New System.Drawing.Size(1338, 161)
        Me.MasterOrderAmndHistory.Text = "Master Order  Amendment History"
        '
        'MasterOrderAmendmentHistoryGridControl
        '
        Me.MasterOrderAmendmentHistoryGridControl.DataSource = Me.MasterOrderAmendmentHistoryBindingSource
        Me.MasterOrderAmendmentHistoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterOrderAmendmentHistoryGridControl.Location = New System.Drawing.Point(0, 0)
        Me.MasterOrderAmendmentHistoryGridControl.MainView = Me.GridView17
        Me.MasterOrderAmendmentHistoryGridControl.Name = "MasterOrderAmendmentHistoryGridControl"
        Me.MasterOrderAmendmentHistoryGridControl.Size = New System.Drawing.Size(1338, 161)
        Me.MasterOrderAmendmentHistoryGridControl.TabIndex = 0
        Me.MasterOrderAmendmentHistoryGridControl.UseEmbeddedNavigator = True
        Me.MasterOrderAmendmentHistoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView17})
        '
        'MasterOrderAmendmentHistoryBindingSource
        '
        Me.MasterOrderAmendmentHistoryBindingSource.DataMember = "MasterOrder_MasterOrderAmendmentHistory"
        Me.MasterOrderAmendmentHistoryBindingSource.DataSource = Me.MasterOrderBindingSource
        '
        'GridView17
        '
        Me.GridView17.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAmendmentNo2, Me.colAmendmentDate2, Me.colCauseOfAmendment2})
        Me.GridView17.GridControl = Me.MasterOrderAmendmentHistoryGridControl
        Me.GridView17.Name = "GridView17"
        Me.GridView17.OptionsView.ShowGroupPanel = False
        '
        'colAmendmentNo2
        '
        Me.colAmendmentNo2.FieldName = "AmendmentNo"
        Me.colAmendmentNo2.Name = "colAmendmentNo2"
        Me.colAmendmentNo2.OptionsColumn.AllowEdit = False
        Me.colAmendmentNo2.Visible = True
        Me.colAmendmentNo2.VisibleIndex = 0
        Me.colAmendmentNo2.Width = 92
        '
        'colAmendmentDate2
        '
        Me.colAmendmentDate2.FieldName = "AmendmentDate"
        Me.colAmendmentDate2.Name = "colAmendmentDate2"
        Me.colAmendmentDate2.OptionsColumn.AllowEdit = False
        Me.colAmendmentDate2.Visible = True
        Me.colAmendmentDate2.VisibleIndex = 1
        Me.colAmendmentDate2.Width = 109
        '
        'colCauseOfAmendment2
        '
        Me.colCauseOfAmendment2.FieldName = "CauseOfAmendment"
        Me.colCauseOfAmendment2.Name = "colCauseOfAmendment2"
        Me.colCauseOfAmendment2.OptionsColumn.AllowEdit = False
        Me.colCauseOfAmendment2.Visible = True
        Me.colCauseOfAmendment2.VisibleIndex = 2
        Me.colCauseOfAmendment2.Width = 768
        '
        'MasterOrderDetailsAmndHistory
        '
        Me.MasterOrderDetailsAmndHistory.AutoScroll = True
        Me.MasterOrderDetailsAmndHistory.Controls.Add(Me.MasterOrderDetailsAmendmentHistoryGridControl)
        Me.MasterOrderDetailsAmndHistory.Name = "MasterOrderDetailsAmndHistory"
        Me.MasterOrderDetailsAmndHistory.Size = New System.Drawing.Size(1338, 161)
        Me.MasterOrderDetailsAmndHistory.Text = "Master Order Details Amendment History"
        '
        'MasterOrderDetailsAmendmentHistoryGridControl
        '
        Me.MasterOrderDetailsAmendmentHistoryGridControl.DataSource = Me.MasterOrderDetailsAmendmentHistoryBindingSource
        Me.MasterOrderDetailsAmendmentHistoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterOrderDetailsAmendmentHistoryGridControl.Location = New System.Drawing.Point(0, 0)
        Me.MasterOrderDetailsAmendmentHistoryGridControl.MainView = Me.GridView19
        Me.MasterOrderDetailsAmendmentHistoryGridControl.Name = "MasterOrderDetailsAmendmentHistoryGridControl"
        Me.MasterOrderDetailsAmendmentHistoryGridControl.Size = New System.Drawing.Size(1338, 161)
        Me.MasterOrderDetailsAmendmentHistoryGridControl.TabIndex = 0
        Me.MasterOrderDetailsAmendmentHistoryGridControl.UseEmbeddedNavigator = True
        Me.MasterOrderDetailsAmendmentHistoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView19})
        '
        'MasterOrderDetailsAmendmentHistoryBindingSource
        '
        Me.MasterOrderDetailsAmendmentHistoryBindingSource.DataMember = "FK_MasterOrderDetailsAmendmentHistory_MasterOrderDetails"
        Me.MasterOrderDetailsAmendmentHistoryBindingSource.DataSource = Me.MasterOrderDetailsBindingSource
        '
        'GridView19
        '
        Me.GridView19.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAmendmentNo3, Me.colAmendmentDate3, Me.colCauseOfAmendment3})
        Me.GridView19.GridControl = Me.MasterOrderDetailsAmendmentHistoryGridControl
        Me.GridView19.Name = "GridView19"
        Me.GridView19.OptionsView.ShowGroupPanel = False
        '
        'colAmendmentNo3
        '
        Me.colAmendmentNo3.FieldName = "AmendmentNo"
        Me.colAmendmentNo3.Name = "colAmendmentNo3"
        Me.colAmendmentNo3.OptionsColumn.AllowEdit = False
        Me.colAmendmentNo3.Visible = True
        Me.colAmendmentNo3.VisibleIndex = 0
        Me.colAmendmentNo3.Width = 128
        '
        'colAmendmentDate3
        '
        Me.colAmendmentDate3.FieldName = "AmendmentDate"
        Me.colAmendmentDate3.Name = "colAmendmentDate3"
        Me.colAmendmentDate3.OptionsColumn.AllowEdit = False
        Me.colAmendmentDate3.Visible = True
        Me.colAmendmentDate3.VisibleIndex = 1
        Me.colAmendmentDate3.Width = 154
        '
        'colCauseOfAmendment3
        '
        Me.colCauseOfAmendment3.FieldName = "CauseOfAmendment"
        Me.colCauseOfAmendment3.Name = "colCauseOfAmendment3"
        Me.colCauseOfAmendment3.OptionsColumn.AllowEdit = False
        Me.colCauseOfAmendment3.Visible = True
        Me.colCauseOfAmendment3.VisibleIndex = 2
        Me.colCauseOfAmendment3.Width = 1056
        '
        'Document
        '
        Me.Document.Appearance.PageClient.BackColor = System.Drawing.Color.Black
        Me.Document.Appearance.PageClient.Options.UseBackColor = True
        Me.Document.AutoScroll = True
        Me.Document.Controls.Add(Me.tbProgress)
        Me.Document.Controls.Add(Me.SaveDocButton)
        Me.Document.Controls.Add(Me.RefreshDocButton)
        Me.Document.Controls.Add(Me.DocDeleteButton)
        Me.Document.Controls.Add(Me.DocAddButton)
        Me.Document.Controls.Add(Me.MasterOrderDocGridControl)
        Me.Document.Controls.Add(Me.ProgressBar)
        Me.Document.Name = "Document"
        Me.Document.Size = New System.Drawing.Size(1338, 161)
        Me.Document.Text = "Master Order Documents"
        '
        'tbProgress
        '
        Me.tbProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbProgress.AutoSize = True
        Me.tbProgress.BackColor = System.Drawing.SystemColors.Control
        Me.tbProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProgress.Location = New System.Drawing.Point(1238, 173)
        Me.tbProgress.Name = "tbProgress"
        Me.tbProgress.Size = New System.Drawing.Size(10, 13)
        Me.tbProgress.TabIndex = 57
        Me.tbProgress.Text = "."
        Me.tbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaveDocButton
        '
        Me.SaveDocButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveDocButton.Location = New System.Drawing.Point(1264, 30)
        Me.SaveDocButton.Name = "SaveDocButton"
        Me.SaveDocButton.Size = New System.Drawing.Size(67, 23)
        Me.SaveDocButton.TabIndex = 57
        Me.SaveDocButton.Text = "&Download"
        '
        'RefreshDocButton
        '
        Me.RefreshDocButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshDocButton.Location = New System.Drawing.Point(1264, 4)
        Me.RefreshDocButton.Name = "RefreshDocButton"
        Me.RefreshDocButton.Size = New System.Drawing.Size(67, 23)
        Me.RefreshDocButton.TabIndex = 56
        Me.RefreshDocButton.Text = "&Show All"
        '
        'DocDeleteButton
        '
        Me.DocDeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DocDeleteButton.Location = New System.Drawing.Point(1264, 82)
        Me.DocDeleteButton.Name = "DocDeleteButton"
        Me.DocDeleteButton.Size = New System.Drawing.Size(67, 23)
        Me.DocDeleteButton.TabIndex = 55
        Me.DocDeleteButton.Text = "&Delete"
        Me.DocDeleteButton.Visible = False
        '
        'DocAddButton
        '
        Me.DocAddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DocAddButton.Location = New System.Drawing.Point(1264, 56)
        Me.DocAddButton.Name = "DocAddButton"
        Me.DocAddButton.Size = New System.Drawing.Size(67, 23)
        Me.DocAddButton.TabIndex = 54
        Me.DocAddButton.Text = "&Upload"
        '
        'MasterOrderDocGridControl
        '
        Me.MasterOrderDocGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MasterOrderDocGridControl.DataSource = Me.MasterOrderDocBindingSource
        Me.MasterOrderDocGridControl.Location = New System.Drawing.Point(0, -1)
        Me.MasterOrderDocGridControl.MainView = Me.GridView23
        Me.MasterOrderDocGridControl.Name = "MasterOrderDocGridControl"
        Me.MasterOrderDocGridControl.Size = New System.Drawing.Size(1223, 164)
        Me.MasterOrderDocGridControl.TabIndex = 0
        Me.MasterOrderDocGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView23})
        '
        'MasterOrderDocBindingSource
        '
        Me.MasterOrderDocBindingSource.DataMember = "MasterOrderDoc"
        Me.MasterOrderDocBindingSource.DataSource = Me.MasterOrderDocDataSet
        '
        'MasterOrderDocDataSet
        '
        Me.MasterOrderDocDataSet.DataSetName = "MasterOrderDocDataSet"
        Me.MasterOrderDocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView23
        '
        Me.GridView23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMasterOrderDocId, Me.colMasterOrderId1, Me.colDocName, Me.colDoc, Me.colUploadedOn, Me.colUploadedBy, Me.colDocDetails})
        Me.GridView23.GridControl = Me.MasterOrderDocGridControl
        Me.GridView23.Name = "GridView23"
        Me.GridView23.OptionsView.ShowGroupPanel = False
        '
        'colMasterOrderDocId
        '
        Me.colMasterOrderDocId.FieldName = "MasterOrderDocId"
        Me.colMasterOrderDocId.Name = "colMasterOrderDocId"
        Me.colMasterOrderDocId.OptionsColumn.ReadOnly = True
        '
        'colMasterOrderId1
        '
        Me.colMasterOrderId1.FieldName = "MasterOrderId"
        Me.colMasterOrderId1.Name = "colMasterOrderId1"
        '
        'colDocName
        '
        Me.colDocName.Caption = "Document Name"
        Me.colDocName.FieldName = "DocName"
        Me.colDocName.Name = "colDocName"
        Me.colDocName.Visible = True
        Me.colDocName.VisibleIndex = 0
        '
        'colDoc
        '
        Me.colDoc.FieldName = "Doc"
        Me.colDoc.Name = "colDoc"
        '
        'colUploadedOn
        '
        Me.colUploadedOn.DisplayFormat.FormatString = "dd-MM-yyyy hh:mm"
        Me.colUploadedOn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colUploadedOn.FieldName = "UploadedOn"
        Me.colUploadedOn.Name = "colUploadedOn"
        Me.colUploadedOn.Visible = True
        Me.colUploadedOn.VisibleIndex = 2
        '
        'colUploadedBy
        '
        Me.colUploadedBy.ColumnEdit = Me.UserDocGridLookUpEdit
        Me.colUploadedBy.FieldName = "UploadedBy"
        Me.colUploadedBy.Name = "colUploadedBy"
        Me.colUploadedBy.Visible = True
        Me.colUploadedBy.VisibleIndex = 3
        '
        'colDocDetails
        '
        Me.colDocDetails.Caption = "Document Details"
        Me.colDocDetails.FieldName = "DocDetails"
        Me.colDocDetails.Name = "colDocDetails"
        Me.colDocDetails.Visible = True
        Me.colDocDetails.VisibleIndex = 1
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressBar.Location = New System.Drawing.Point(1230, 171)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(109, 18)
        Me.ProgressBar.TabIndex = 53
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelEntryButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrintButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.StyleButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnMasterOrderAmnd)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.MasterProgramLookUpTextEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowAllButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.MailToButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.SMSToButton)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1340, 35)
        Me.FlowLayoutPanel1.TabIndex = 52
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NewButton.Appearance.Options.UseForeColor = True
        Me.NewButton.Location = New System.Drawing.Point(15, 3)
        Me.NewButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.NewButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.NewButton.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(63, 27)
        Me.NewButton.TabIndex = 50
        Me.NewButton.Tag = "NR"
        Me.NewButton.Text = "&New"
        '
        'EditButton
        '
        Me.EditButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EditButton.Appearance.Options.UseForeColor = True
        Me.EditButton.Location = New System.Drawing.Point(84, 3)
        Me.EditButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EditButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.EditButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(63, 27)
        Me.EditButton.TabIndex = 5
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Save"
        '
        'DeleteButton
        '
        Me.DeleteButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteButton.Appearance.Options.UseForeColor = True
        Me.DeleteButton.Location = New System.Drawing.Point(153, 3)
        Me.DeleteButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeleteButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.DeleteButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(63, 27)
        Me.DeleteButton.TabIndex = 6
        Me.DeleteButton.Tag = "NR"
        Me.DeleteButton.Text = "&Delete"
        '
        'CancelEntryButton
        '
        Me.CancelEntryButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CancelEntryButton.Appearance.Options.UseForeColor = True
        Me.CancelEntryButton.Enabled = False
        Me.CancelEntryButton.Location = New System.Drawing.Point(222, 3)
        Me.CancelEntryButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelEntryButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.CancelEntryButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CancelEntryButton.Name = "CancelEntryButton"
        Me.CancelEntryButton.Size = New System.Drawing.Size(63, 27)
        Me.CancelEntryButton.TabIndex = 7
        Me.CancelEntryButton.Tag = ""
        Me.CancelEntryButton.Text = "&Cancel"
        '
        'PrintButton
        '
        Me.PrintButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrintButton.Appearance.Options.UseForeColor = True
        Me.PrintButton.Location = New System.Drawing.Point(291, 3)
        Me.PrintButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PrintButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PrintButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(63, 27)
        Me.PrintButton.TabIndex = 35
        Me.PrintButton.Text = "&Report"
        '
        'RefreshButton
        '
        Me.RefreshButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RefreshButton.Appearance.Options.UseForeColor = True
        Me.RefreshButton.Location = New System.Drawing.Point(360, 3)
        Me.RefreshButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RefreshButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.RefreshButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(63, 27)
        Me.RefreshButton.TabIndex = 48
        Me.RefreshButton.Text = "&Refresh"
        '
        'StyleButton
        '
        Me.StyleButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StyleButton.Appearance.Options.UseForeColor = True
        Me.StyleButton.Location = New System.Drawing.Point(429, 3)
        Me.StyleButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StyleButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.StyleButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.StyleButton.Name = "StyleButton"
        Me.StyleButton.Size = New System.Drawing.Size(63, 27)
        Me.StyleButton.TabIndex = 49
        Me.StyleButton.Text = "&Style"
        '
        'btnMasterOrderAmnd
        '
        Me.btnMasterOrderAmnd.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMasterOrderAmnd.Appearance.Options.UseForeColor = True
        Me.btnMasterOrderAmnd.Location = New System.Drawing.Point(498, 3)
        Me.btnMasterOrderAmnd.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMasterOrderAmnd.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.btnMasterOrderAmnd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnMasterOrderAmnd.Name = "btnMasterOrderAmnd"
        Me.btnMasterOrderAmnd.Size = New System.Drawing.Size(167, 27)
        Me.btnMasterOrderAmnd.TabIndex = 51
        Me.btnMasterOrderAmnd.Text = "&Add Master Order Amendment"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(671, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Master Program No :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MasterProgramLookUpTextEdit
        '
        Me.MasterProgramLookUpTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MasterProgramLookUpTextEdit.Location = New System.Drawing.Point(781, 6)
        Me.MasterProgramLookUpTextEdit.Name = "MasterProgramLookUpTextEdit"
        Me.MasterProgramLookUpTextEdit.Size = New System.Drawing.Size(149, 20)
        Me.MasterProgramLookUpTextEdit.TabIndex = 54
        '
        'ShowButton
        '
        Me.ShowButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowButton.Appearance.Options.UseForeColor = True
        Me.ShowButton.Location = New System.Drawing.Point(936, 3)
        Me.ShowButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ShowButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.ShowButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 27)
        Me.ShowButton.TabIndex = 55
        Me.ShowButton.Text = "&Show"
        '
        'ShowAllButton
        '
        Me.ShowAllButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowAllButton.Appearance.Options.UseForeColor = True
        Me.ShowAllButton.Location = New System.Drawing.Point(1017, 3)
        Me.ShowAllButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ShowAllButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.ShowAllButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowAllButton.Name = "ShowAllButton"
        Me.ShowAllButton.Size = New System.Drawing.Size(75, 27)
        Me.ShowAllButton.TabIndex = 56
        Me.ShowAllButton.Text = "&Show All"
        '
        'MailToButton
        '
        Me.MailToButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MailToButton.Appearance.Options.UseForeColor = True
        Me.MailToButton.Location = New System.Drawing.Point(1145, 3)
        Me.MailToButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MailToButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.MailToButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MailToButton.Margin = New System.Windows.Forms.Padding(50, 3, 3, 3)
        Me.MailToButton.Name = "MailToButton"
        Me.MailToButton.Size = New System.Drawing.Size(75, 27)
        Me.MailToButton.TabIndex = 57
        Me.MailToButton.Text = "Mail To"
        '
        'SMSToButton
        '
        Me.SMSToButton.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SMSToButton.Appearance.Options.UseForeColor = True
        Me.SMSToButton.Location = New System.Drawing.Point(1253, 3)
        Me.SMSToButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SMSToButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SMSToButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SMSToButton.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.SMSToButton.Name = "SMSToButton"
        Me.SMSToButton.Size = New System.Drawing.Size(75, 27)
        Me.SMSToButton.TabIndex = 58
        Me.SMSToButton.Text = "Send SMS"
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'DivisionTableAdapter
        '
        Me.DivisionTableAdapter.ClearBeforeFill = True
        '
        'StyleNameMstTableAdapter
        '
        Me.StyleNameMstTableAdapter.ClearBeforeFill = True
        '
        'DestinationTableAdapter
        '
        Me.DestinationTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'colDestinationCode
        '
        Me.colDestinationCode.FieldName = "DestinationCode"
        Me.colDestinationCode.Name = "colDestinationCode"
        Me.colDestinationCode.Visible = True
        Me.colDestinationCode.VisibleIndex = 0
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'colComposition
        '
        Me.colComposition.FieldName = "Composition"
        Me.colComposition.Name = "colComposition"
        Me.colComposition.Visible = True
        Me.colComposition.VisibleIndex = 0
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.Caption = "Merchandiser"
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'colUSER_NAME1
        '
        Me.colUSER_NAME1.FieldName = "USER_NAME"
        Me.colUSER_NAME1.Name = "colUSER_NAME1"
        Me.colUSER_NAME1.Visible = True
        Me.colUSER_NAME1.VisibleIndex = 0
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
        Me.colSupplierType.VisibleIndex = 1
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
        Me.colSupplierName1.Visible = True
        Me.colSupplierName1.VisibleIndex = 0
        '
        'colProgramCode
        '
        Me.colProgramCode.FieldName = "ProgramCode"
        Me.colProgramCode.Name = "colProgramCode"
        Me.colProgramCode.Visible = True
        Me.colProgramCode.VisibleIndex = 1
        '
        'colProgramCode1
        '
        Me.colProgramCode1.FieldName = "ProgramCode"
        Me.colProgramCode1.Name = "colProgramCode1"
        Me.colProgramCode1.Visible = True
        Me.colProgramCode1.VisibleIndex = 0
        '
        'colSupplierName2
        '
        Me.colSupplierName2.FieldName = "SupplierName"
        Me.colSupplierName2.Name = "colSupplierName2"
        Me.colSupplierName2.Visible = True
        Me.colSupplierName2.VisibleIndex = 1
        '
        'GridView16
        '
        Me.GridView16.Name = "GridView16"
        '
        'GridView18
        '
        Me.GridView18.Name = "GridView18"
        '
        'GridView8
        '
        Me.GridView8.Name = "GridView8"
        '
        'colMasterOrderId
        '
        Me.colMasterOrderId.FieldName = "MasterOrderId"
        Me.colMasterOrderId.Name = "colMasterOrderId"
        Me.colMasterOrderId.Visible = True
        Me.colMasterOrderId.VisibleIndex = 0
        '
        'colInstruction
        '
        Me.colInstruction.FieldName = "Instruction"
        Me.colInstruction.Name = "colInstruction"
        Me.colInstruction.Visible = True
        Me.colInstruction.VisibleIndex = 1
        '
        'colInstructionDate
        '
        Me.colInstructionDate.FieldName = "InstructionDate"
        Me.colInstructionDate.Name = "colInstructionDate"
        Me.colInstructionDate.Visible = True
        Me.colInstructionDate.VisibleIndex = 2
        '
        'colUserId1
        '
        Me.colUserId1.FieldName = "UserId"
        Me.colUserId1.Name = "colUserId1"
        Me.colUserId1.Visible = True
        Me.colUserId1.VisibleIndex = 3
        '
        'colMasterOrderInstructionId
        '
        Me.colMasterOrderInstructionId.FieldName = "MasterOrderInstructionId"
        Me.colMasterOrderInstructionId.Name = "colMasterOrderInstructionId"
        Me.colMasterOrderInstructionId.OptionsColumn.ReadOnly = True
        Me.colMasterOrderInstructionId.Visible = True
        Me.colMasterOrderInstructionId.VisibleIndex = 4
        '
        'colInstructionSlNo
        '
        Me.colInstructionSlNo.FieldName = "InstructionSlNo"
        Me.colInstructionSlNo.Name = "colInstructionSlNo"
        Me.colInstructionSlNo.Visible = True
        Me.colInstructionSlNo.VisibleIndex = 5
        '
        'colSupplierName3
        '
        Me.colSupplierName3.FieldName = "SupplierName"
        Me.colSupplierName3.Name = "colSupplierName3"
        Me.colSupplierName3.Visible = True
        Me.colSupplierName3.VisibleIndex = 0
        '
        'colProgramCode2
        '
        Me.colProgramCode2.FieldName = "ProgramCode"
        Me.colProgramCode2.Name = "colProgramCode2"
        Me.colProgramCode2.Visible = True
        Me.colProgramCode2.VisibleIndex = 1
        '
        'GMTBrandTableAdapter
        '
        Me.GMTBrandTableAdapter.ClearBeforeFill = True
        '
        'colGMTBrandName
        '
        Me.colGMTBrandName.FieldName = "GMTBrandName"
        Me.colGMTBrandName.Name = "colGMTBrandName"
        Me.colGMTBrandName.Visible = True
        Me.colGMTBrandName.VisibleIndex = 0
        '
        'MasterOrderDocTableAdapter
        '
        Me.MasterOrderDocTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.MasterOrderDocTableAdapter = Me.MasterOrderDocTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.MasterOrderDocDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DevTypeMstTableAdapter
        '
        Me.DevTypeMstTableAdapter.ClearBeforeFill = True
        '
        'colDevType
        '
        Me.colDevType.FieldName = "DevType"
        Me.colDevType.Name = "colDevType"
        Me.colDevType.Visible = True
        Me.colDevType.VisibleIndex = 0
        '
        'colDevType1
        '
        Me.colDevType1.FieldName = "DevType"
        Me.colDevType1.Name = "colDevType1"
        Me.colDevType1.Visible = True
        Me.colDevType1.VisibleIndex = 0
        '
        'SizeTableAdapter
        '
        Me.SizeTableAdapter.ClearBeforeFill = True
        '
        'SeasonTableAdapter
        '
        Me.SeasonTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = KSoft_Apparel.AccAndFabBOMStatusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'colIsAdvance
        '
        Me.colIsAdvance.FieldName = "IsAdvance"
        Me.colIsAdvance.Name = "colIsAdvance"
        Me.colIsAdvance.Visible = True
        Me.colIsAdvance.VisibleIndex = 1
        '
        'BlockButton
        '
        Me.BlockButton.Location = New System.Drawing.Point(815, 0)
        Me.BlockButton.Name = "BlockButton"
        Me.BlockButton.Size = New System.Drawing.Size(219, 23)
        Me.BlockButton.TabIndex = 53
        Me.BlockButton.Text = "Generate Block Program No"
        Me.BlockButton.UseVisualStyleBackColor = True
        '
        'frmMasterOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 703)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.KeyPreview = True
        Me.Name = "frmMasterOrder"
        Me.Text = "Master Order"
        CType(Me.UserDocGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipoutStatusComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipByComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignedForGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialTeamComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipoutStatsuDetailsComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialTeamGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.SupplierGridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.SizeAndInstructionXtraTabPage.ResumeLayout(False)
        CType(Me.MasterOrderSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderInstructionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderInstructionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView33, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SampleStatus.ResumeLayout(False)
        CType(Me.MasterOrderSampleStatusGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderSampleStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovedComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MasterOrderAmndHistory.ResumeLayout(False)
        CType(Me.MasterOrderAmendmentHistoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderAmendmentHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MasterOrderDetailsAmndHistory.ResumeLayout(False)
        CType(Me.MasterOrderDetailsAmendmentHistoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderDetailsAmendmentHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Document.ResumeLayout(False)
        Me.Document.PerformLayout()
        CType(Me.MasterOrderDocGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderDocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderDocDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.MasterProgramLookUpTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MasterOrderDataSet As KSoft_Apparel.MasterOrderDataSet
    Friend WithEvents MasterOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterOrderTableAdapter As KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.MasterOrderDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MasterOrderDetailsTableAdapter As KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderDetailsTableAdapter
    Friend WithEvents MasterOrderGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMasterProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDivisionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MasterOrderDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterOrderSizeDetailsTableAdapter As KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderSizeDetailsTableAdapter
    Friend WithEvents MasterOrderDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGarmentsColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNLD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPackType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsClose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCauseOfCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDespatch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAsignedForMerchandeiser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsReceivedBySupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MasterOrderSizeDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents EditButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DeleteButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CancelEntryButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RefreshButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents StyleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents StyleItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StyleDataSet As KSoft_Apparel.StyleDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents DivisionGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DivisionDataSet As KSoft_Apparel.DivisionDataSet
    Friend WithEvents DivisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DivisionTableAdapter As KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter
    Friend WithEvents colStyleNameId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleNameGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StyleNameMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleNameMstTableAdapter As KSoft_Apparel.StyleDataSetTableAdapters.StyleNameMstTableAdapter
    Friend WithEvents DestinationGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DestinationDataSet As KSoft_Apparel.DestinationDataSet
    Friend WithEvents DestinationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DestinationTableAdapter As KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter
    Friend WithEvents NewButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SupplierGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PasteButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CopyButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgramButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CopyPOButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCompositionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KnittingTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents CompositionGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents colComposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AsignedForGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserLookupDataSet As KSoft_Apparel.UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserLookupTableAdapter As KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETDDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExFactoryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRFIDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGarmentsColor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUSER_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGMDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsAOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsEmbroidary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCRecieveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPicture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsWash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRFIDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentTerm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCauseOfAmendment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShipByComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colIsYDS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETDDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Supplier As System.Windows.Forms.Label
    Friend WithEvents SupplierGridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLAmount1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedOn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedOn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colColorSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecieveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents MasterOrderInstructionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterOrderInstructionTableAdapter As KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderInstructionTableAdapter
    Friend WithEvents colUSER_NAME3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCauseOfAmendment1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents SizeAndInstructionXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents OrderInstructionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderInstructionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView33 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MasterOrderAmndHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MasterOrderDetailsAmndHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMasterOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstruction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstructionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMasterOrderInstructionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstructionSlNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MasterOrderAmendmentHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterOrderAmendmentHistoryTableAdapter As KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderAmendmentHistoryTableAdapter
    Friend WithEvents MasterOrderAmendmentHistoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAmendmentNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCauseOfAmendment2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MasterOrderDetailsAmendmentHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterOrderDetailsAmendmentHistoryTableAdapter As KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderDetailsAmendmentHistoryTableAdapter
    Friend WithEvents MasterOrderDetailsAmendmentHistoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView19 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAmendmentNo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentDate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCauseOfAmendment3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnMasterOrderAmnd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMasterOrderDetailsAmnd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colShipout As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipoutDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentQTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipoutBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRe_ETD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRe_ExFactory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRe_RFI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentQTY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipout1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipoutBalance1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipoutDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommercialTeam As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CommercialTeamComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents CommercialTeamGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView20 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents ShipoutStatusComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ShipoutStatsuDetailsComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colSupplierName3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramCode2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramCode3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGMTBrandId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BrandGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GMTBrandDataSet As KSoft_Apparel.GMTBrandDataSet
    Friend WithEvents GMTBrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMTBrandTableAdapter As KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter
    Friend WithEvents colGMTBrandName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentStatus1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderConfirmationDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDSTNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MasterOrderSampleStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterOrderSampleStatusTableAdapter As KSoft_Apparel.MasterOrderDataSetTableAdapters.MasterOrderSampleStatusTableAdapter
    Friend WithEvents SampleStatus As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MasterOrderSampleStatusGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSampleRequestNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSampleRequestDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSampleSendDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSendingInfo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommentsReceive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApproved As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ApprovedComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DeleteSampleStatusButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AddSampleStatusButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Document As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MasterOrderDocDataSet As KSoft_Apparel.MasterOrderDocDataSet
    Friend WithEvents MasterOrderDocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterOrderDocTableAdapter As KSoft_Apparel.MasterOrderDocDataSetTableAdapters.MasterOrderDocTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.MasterOrderDocDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MasterOrderDocGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMasterOrderDocId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMasterOrderId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUploadedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUploadedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DocDeleteButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DocAddButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RefreshDocButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveDocButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colDocDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsReceived As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MasterProgramLookUpTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShowAllButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDevTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SampleTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView25 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRemarks2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DevTypeDataSet As KSoft_Apparel.DevTypeDataSet
    Friend WithEvents DevTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DevTypeMstTableAdapter As KSoft_Apparel.DevTypeDataSetTableAdapters.DevTypeMstTableAdapter
    Friend WithEvents colDevType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDevType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MasterOrderSizeDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRatio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView26 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SizeDataSet As KSoft_Apparel.SizeDataSet
    Friend WithEvents SizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeTableAdapter As KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CalculateRatioButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colSLNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbProgress As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents colGauge As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSampleRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsBrush As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPeachFinish As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeasonId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeasonGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView27 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SeasonDataSet As KSoft_Apparel.SeasonDataSet
    Friend WithEvents SeasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeasonTableAdapter As KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter
    Friend WithEvents colSeasonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TableAdapterManager2 As KSoft_Apparel.AccAndFabBOMStatusDataSetTableAdapters.TableAdapterManager
    Friend WithEvents colLDNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents UserDocGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents colYarnBookingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MailToButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SMSToButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colIsAdvance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BlockButton As Button
End Class
