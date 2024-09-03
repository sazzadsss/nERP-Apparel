<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrderReceived
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
        Dim OrderReceiveDateLabel As System.Windows.Forms.Label
        Dim AmendmentDateLabel As System.Windows.Forms.Label
        Dim AmendmentNoLabel As System.Windows.Forms.Label
        Dim CauseofAmendmentLabel As System.Windows.Forms.Label
        Dim StyleReferenceNoLabel As System.Windows.Forms.Label
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim ModifiedDateLabel As System.Windows.Forms.Label
        Dim IsMultiPartLabel As System.Windows.Forms.Label
        Dim IsEmbroideryLabel As System.Windows.Forms.Label
        Dim AdvOrderIdLabel As System.Windows.Forms.Label
        Dim StyleNameIdLabel As System.Windows.Forms.Label
        Dim OrderRemarksLabel As System.Windows.Forms.Label
        Dim UserIdLabel1 As System.Windows.Forms.Label
        Dim GarmentDescriptionLabel1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim CuttingWPLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.HoldOnDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDataSet = New KSoft_Apparel.OrderDataSet()
        Me.IsHoldCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AdvPrgNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.AdvProgramLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdvProgramLookupDataSet = New KSoft_Apparel.AdvProgramLookupDataSet()
        Me.GridView21 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BPrgNoLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.YarnDyeingTypeGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.YarnDyeingTypeGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PicturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleDataSet = New KSoft_Apparel.StyleDataSet()
        Me.CancelDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.FullCompleteDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.InputCompleteDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.IsInputCompleteCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OrderLookupByStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TTLOffDayLabel2 = New System.Windows.Forms.Label()
        Me.TTLDayLabel2 = New System.Windows.Forms.Label()
        Me.WDLabel = New System.Windows.Forms.Label()
        Me.TTLWDayLabel2 = New System.Windows.Forms.Label()
        Me.TTLOffDayLabel = New System.Windows.Forms.Label()
        Me.TTLDayLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ActivitiesGroupIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ActivitiesGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesGroupDataSet = New KSoft_Apparel.ActivitiesGroupDataSet()
        Me.GridView26 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActivitiesGroup1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ApprovedSampleNoTextBox = New System.Windows.Forms.TextBox()
        Me.MasterProgramNoTextBox = New System.Windows.Forms.TextBox()
        Me.GMTBrandIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GMTBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMTBrandDataSet = New KSoft_Apparel.GMTBrandDataSet()
        Me.GMTBrandIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGMTBrandName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsYDSCheckBox = New DevExpress.XtraEditors.CheckEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.GarmentDescriptionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.IsBrushCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsPeachFinishCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AOPDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.PrintDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.EmbroideryDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.IsAOPCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsCompleteCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.WashCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SusStandGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SusStandardMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SusStandardDataSet = New KSoft_Apparel.SusStandardDataSet()
        Me.GridView20 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSusStandard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabMatGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FabricMaterialTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricMaterialTypeDataSet = New KSoft_Apparel.FabricMaterialTypeDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabMatType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WashTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.WashTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashTypeDataSet = New KSoft_Apparel.WashTypeDataSet()
        Me.WashTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWashType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IsAdvanceCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsEmbroideryCheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.IsFabricBOMCompleteCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsAccBOMCompleteCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.UserIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.UserIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmndButton = New System.Windows.Forms.Button()
        Me.OrderRemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GarmentIdLabel = New System.Windows.Forms.LinkLabel()
        Me.StyleIdLabel = New System.Windows.Forms.LinkLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CancelEntryButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.GenTNAButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.CopyFullButton = New System.Windows.Forms.Button()
        Me.AmendmentNoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ProgramNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.StyleIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.StyleIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderReceiveDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AmendmentDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CauseofAmendmentMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.DiscontinueCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.DivisionIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DivisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivisionDataSet = New KSoft_Apparel.DivisionDataSet()
        Me.DivisionIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDivisionName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeasonIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeasonDataSet = New KSoft_Apparel.SeasonDataSet()
        Me.SeasonIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeasonName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GarmentIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GarmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentDataSet = New KSoft_Apparel.GarmentDataSet()
        Me.GarmentIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGarmentDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SpecialYarnCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.SequenceCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.SublimationCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsPrintCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.StyleReferenceNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UserIdComboBox = New System.Windows.Forms.ComboBox()
        Me.ModifiedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.IsMultiPartCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AdvOrderIdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.StyleNameIdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.OrderDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.OrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDetailsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GarmentsColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO_Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPackType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PackTypeComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDestinationId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DestinationGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DestinationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DestinationDataSet = New KSoft_Apparel.DestinationDataSet()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDestinationCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EXDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReference = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrDetailsStyleIdGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivitiesGroupId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ActivitiesGroupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView18 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActivitiesGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GenerateActivitiesGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GenerateItemHyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colColorSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRFIDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colA_S = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShipmentByComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colFirstEx = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClosedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCasuseOfDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsHold = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoldOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ETADateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.EXGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.SizeAndInstructionXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.Paste2Button = New DevExpress.XtraEditors.SimpleButton()
        Me.CalculateRatioButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PasteButton = New DevExpress.XtraEditors.SimpleButton()
        Me.CopyButton = New DevExpress.XtraEditors.SimpleButton()
        Me.OrderInstructionGridControl = New DevExpress.XtraGrid.GridControl()
        Me.OrderInstructionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderInstructionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstructionSlNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstruction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInstructionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderSizeDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.OrderSizeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SizeDataSet = New KSoft_Apparel.SizeDataSet()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRatio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSKUNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CuttingPercentageXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.GetColorListButton = New System.Windows.Forms.Button()
        Me.OrderCuttingPercentageGridControl = New DevExpress.XtraGrid.GridControl()
        Me.OrderCuttingPercentageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView24 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricColorCPGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView25 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCuttingPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrinting = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmbroidery = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWashing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSewing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CuttingWPSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.FabricXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.FabricGridControl = New DevExpress.XtraGrid.GridControl()
        Me.FabricBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colGarmentsPartId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GarmentsPartGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GarmentsPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartDataSet = New KSoft_Apparel.GarmentsPartDataSet()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKnittingTypeId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.FabricTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKnittingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompositionId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.CompositionGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colComposition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSMId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GSMGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GSMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSMDataSet = New KSoft_Apparel.GSMDataSet()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFinishFabricDia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDiaType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DiaTypeComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDiaUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DiaUnitComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colFinishUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.FinishUnitComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colSPNote = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colMarkerLengthYrds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMarkerLengthInch = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMarkerWidth = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colWidthAllowance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLengthAllowance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colWastagePercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGMQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colDyeingTypeId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DyeingTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DyeingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DyeingTypeDataSet = New KSoft_Apparel.DyeingTypeDataSet()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDyeingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsAllOverPrint = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.MultipartXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.TwinPackDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.TwinPackDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTwinPackId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPartColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintDetailsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AmndHistory = New DevExpress.XtraTab.XtraTabPage()
        Me.OrderAmndDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.OrderAmndDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderAmndDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmndNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderProcessXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.FROrderProcessGridControl = New DevExpress.XtraGrid.GridControl()
        Me.FROrderProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFRProcessId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OperationLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FRProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FRProcessDataSet = New KSoft_Apparel.FRProcessDataSet()
        Me.GridView17 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFactor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ActivitiesXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.OrderActivitiesGridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.OrderActivitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView27 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivitiesListId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ActivitiesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesListDataSet = New KSoft_Apparel.ActivitiesListDataSet()
        Me.colDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSlack = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaskComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaskComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOffDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLeftday = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderActivitiesPredecessorGridControl = New DevExpress.XtraGrid.GridControl()
        Me.OrderActivitiesPredecessorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView19 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActivitiesListId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.OrderPictureXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.OrderPictureGridControl = New DevExpress.XtraGrid.GridControl()
        Me.OrderPictureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView23 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderPictureId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.colDefaultPicture = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSide = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PreCostingNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreCostingNoLookupDataSet = New KSoft_Apparel.PreCostingNoLookupDataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Apparel.UserDataSet()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Apparel.CompanyDataSet()
        Me.OrderTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.OrderDataSetTableAdapters.TableAdapterManager()
        Me.FabricTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.FabricTableAdapter()
        Me.FROrderProcessTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.FROrderProcessTableAdapter()
        Me.OrderActivitiesPredecessorTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderActivitiesPredecessorTableAdapter()
        Me.OrderActivitiesTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderActivitiesTableAdapter()
        Me.OrderAmndDetailsTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderAmndDetailsTableAdapter()
        Me.OrderCuttingPercentageTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderCuttingPercentageTableAdapter()
        Me.OrderDetailsTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderDetailsTableAdapter()
        Me.OrderInstructionTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderInstructionTableAdapter()
        Me.OrderPictureTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderPictureTableAdapter()
        Me.OrderSizeDetailsTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderSizeDetailsTableAdapter()
        Me.TwinPackDetailsTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.TwinPackDetailsTableAdapter()
        Me.DivisionTableAdapter = New KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter()
        Me.SeasonTableAdapter = New KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter()
        Me.GarmentTableAdapter = New KSoft_Apparel.GarmentDataSetTableAdapters.GarmentTableAdapter()
        Me.StyleLookupTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.SizeTableAdapter = New KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter()
        Me.DyeingTypeTableAdapter = New KSoft_Apparel.DyeingTypeDataSetTableAdapters.DyeingTypeTableAdapter()
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter()
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter()
        Me.GarmentsPartTableAdapter = New KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDivisionName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGarmentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeasonName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DestinationTableAdapter = New KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter()
        Me.OrderLookupByStyleTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupByStyleTableAdapter()
        Me.colFabricColorName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompanyTableAdapter = New KSoft_Apparel.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.GSMTableAdapter = New KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter()
        Me.colGSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserTableAdapter = New KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WashTypeMstTableAdapter = New KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter()
        Me.colWashType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FRProcessTableAdapter = New KSoft_Apparel.FRProcessDataSetTableAdapters.FRProcessTableAdapter()
        Me.ActivitiesGroupTableAdapter = New KSoft_Apparel.ActivitiesGroupDataSetTableAdapters.ActivitiesGroupTableAdapter()
        Me.ActivitiesListTableAdapter = New KSoft_Apparel.ActivitiesListDataSetTableAdapters.ActivitiesListTableAdapter()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.colUSER_NAME2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMTBrandTableAdapter = New KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter()
        Me.colGMTBrandName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleDataSetTableAdapters.StyleTableAdapter()
        Me.PreCostingNoLookupTableAdapter = New KSoft_Apparel.PreCostingNoLookupDataSetTableAdapters.PreCostingNoLookupTableAdapter()
        Me.FabricFinishingTypeDataSet = New KSoft_Apparel.FabricFinishingTypeDataSet()
        Me.FabricFinishingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricFinishingTypeTableAdapter = New KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.FabricFinishingTypeTableAdapter()
        Me.FabricMaterialTypeTableAdapter = New KSoft_Apparel.FabricMaterialTypeDataSetTableAdapters.FabricMaterialTypeTableAdapter()
        Me.SusStandardMstTableAdapter = New KSoft_Apparel.SusStandardDataSetTableAdapters.SusStandardMstTableAdapter()
        Me.AdvProgramLookupTableAdapter = New KSoft_Apparel.AdvProgramLookupDataSetTableAdapters.AdvProgramLookupTableAdapter()
        OrderReceiveDateLabel = New System.Windows.Forms.Label()
        AmendmentDateLabel = New System.Windows.Forms.Label()
        AmendmentNoLabel = New System.Windows.Forms.Label()
        CauseofAmendmentLabel = New System.Windows.Forms.Label()
        StyleReferenceNoLabel = New System.Windows.Forms.Label()
        UserIdLabel = New System.Windows.Forms.Label()
        ModifiedDateLabel = New System.Windows.Forms.Label()
        IsMultiPartLabel = New System.Windows.Forms.Label()
        IsEmbroideryLabel = New System.Windows.Forms.Label()
        AdvOrderIdLabel = New System.Windows.Forms.Label()
        StyleNameIdLabel = New System.Windows.Forms.Label()
        OrderRemarksLabel = New System.Windows.Forms.Label()
        UserIdLabel1 = New System.Windows.Forms.Label()
        GarmentDescriptionLabel1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        CuttingWPLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.HoldOnDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldOnDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsHoldCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvPrgNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvProgramLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnDyeingTypeGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnDyeingTypeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FullCompleteDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FullCompleteDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputCompleteDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputCompleteDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsInputCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.OrderLookupByStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ActivitiesGroupIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesGroupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsYDSCheckBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentDescriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsBrushCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPeachFinishCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsAOPCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SusStandGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SusStandardMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SusStandardDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabMatGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricMaterialTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricMaterialTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsAdvanceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsEmbroideryCheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsFabricBOMCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsAccBOMCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderRemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.OrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CauseofAmendmentMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscontinueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecialYarnCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SequenceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SublimationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleReferenceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsMultiPartCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvOrderIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.OrderDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackTypeComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrDetailsStyleIdGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesGroupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerateItemHyperLinkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentByComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETADateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETADateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.SizeAndInstructionXtraTabPage.SuspendLayout()
        CType(Me.OrderInstructionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderInstructionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuttingPercentageXtraTabPage.SuspendLayout()
        CType(Me.OrderCuttingPercentageGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderCuttingPercentageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorCPGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingWPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FabricXtraTabPage.SuspendLayout()
        CType(Me.FabricGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaTypeComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaUnitComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishUnitComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MultipartXtraTabPage.SuspendLayout()
        CType(Me.TwinPackDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwinPackDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PrintDetailsXtraTabPage.SuspendLayout()
        Me.AmndHistory.SuspendLayout()
        CType(Me.OrderAmndDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderAmndDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrderProcessXtraTabPage.SuspendLayout()
        CType(Me.FROrderProcessGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FROrderProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperationLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FRProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FRProcessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActivitiesXtraTabPage.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.OrderActivitiesGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderActivitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderActivitiesPredecessorGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderActivitiesPredecessorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrderPictureXtraTabPage.SuspendLayout()
        CType(Me.OrderPictureGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPictureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingNoLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricFinishingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricFinishingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderReceiveDateLabel
        '
        OrderReceiveDateLabel.AutoSize = True
        OrderReceiveDateLabel.Location = New System.Drawing.Point(12, 128)
        OrderReceiveDateLabel.Name = "OrderReceiveDateLabel"
        OrderReceiveDateLabel.Size = New System.Drawing.Size(118, 13)
        OrderReceiveDateLabel.TabIndex = 10
        OrderReceiveDateLabel.Text = "Program Receive Date:"
        '
        'AmendmentDateLabel
        '
        AmendmentDateLabel.AutoSize = True
        AmendmentDateLabel.Location = New System.Drawing.Point(595, 79)
        AmendmentDateLabel.Name = "AmendmentDateLabel"
        AmendmentDateLabel.Size = New System.Drawing.Size(94, 13)
        AmendmentDateLabel.TabIndex = 14
        AmendmentDateLabel.Text = "Amendment Date:"
        '
        'AmendmentNoLabel
        '
        AmendmentNoLabel.AutoSize = True
        AmendmentNoLabel.Location = New System.Drawing.Point(595, 54)
        AmendmentNoLabel.Name = "AmendmentNoLabel"
        AmendmentNoLabel.Size = New System.Drawing.Size(84, 13)
        AmendmentNoLabel.TabIndex = 16
        AmendmentNoLabel.Text = "Amendment No:"
        '
        'CauseofAmendmentLabel
        '
        CauseofAmendmentLabel.AutoSize = True
        CauseofAmendmentLabel.Location = New System.Drawing.Point(595, 103)
        CauseofAmendmentLabel.Name = "CauseofAmendmentLabel"
        CauseofAmendmentLabel.Size = New System.Drawing.Size(114, 13)
        CauseofAmendmentLabel.TabIndex = 18
        CauseofAmendmentLabel.Text = "Cause of Amendment:"
        '
        'StyleReferenceNoLabel
        '
        StyleReferenceNoLabel.AutoSize = True
        StyleReferenceNoLabel.Location = New System.Drawing.Point(14, 176)
        StyleReferenceNoLabel.Name = "StyleReferenceNoLabel"
        StyleReferenceNoLabel.Size = New System.Drawing.Size(88, 13)
        StyleReferenceNoLabel.TabIndex = 34
        StyleReferenceNoLabel.Text = "Style Reference:"
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(21, 596)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(46, 13)
        UserIdLabel.TabIndex = 38
        UserIdLabel.Text = "User Id:"
        '
        'ModifiedDateLabel
        '
        ModifiedDateLabel.AutoSize = True
        ModifiedDateLabel.Location = New System.Drawing.Point(21, 620)
        ModifiedDateLabel.Name = "ModifiedDateLabel"
        ModifiedDateLabel.Size = New System.Drawing.Size(77, 13)
        ModifiedDateLabel.TabIndex = 40
        ModifiedDateLabel.Text = "Modified Date:"
        '
        'IsMultiPartLabel
        '
        IsMultiPartLabel.AutoSize = True
        IsMultiPartLabel.Location = New System.Drawing.Point(21, 646)
        IsMultiPartLabel.Name = "IsMultiPartLabel"
        IsMultiPartLabel.Size = New System.Drawing.Size(68, 13)
        IsMultiPartLabel.TabIndex = 42
        IsMultiPartLabel.Text = "Is Multi Part:"
        '
        'IsEmbroideryLabel
        '
        IsEmbroideryLabel.AutoSize = True
        IsEmbroideryLabel.Location = New System.Drawing.Point(21, 671)
        IsEmbroideryLabel.Name = "IsEmbroideryLabel"
        IsEmbroideryLabel.Size = New System.Drawing.Size(77, 13)
        IsEmbroideryLabel.TabIndex = 44
        IsEmbroideryLabel.Text = "Is Embroidery:"
        '
        'AdvOrderIdLabel
        '
        AdvOrderIdLabel.AutoSize = True
        AdvOrderIdLabel.Location = New System.Drawing.Point(21, 696)
        AdvOrderIdLabel.Name = "AdvOrderIdLabel"
        AdvOrderIdLabel.Size = New System.Drawing.Size(74, 13)
        AdvOrderIdLabel.TabIndex = 46
        AdvOrderIdLabel.Text = "Adv Order Id:"
        '
        'StyleNameIdLabel
        '
        StyleNameIdLabel.AutoSize = True
        StyleNameIdLabel.Location = New System.Drawing.Point(21, 722)
        StyleNameIdLabel.Name = "StyleNameIdLabel"
        StyleNameIdLabel.Size = New System.Drawing.Size(78, 13)
        StyleNameIdLabel.TabIndex = 48
        StyleNameIdLabel.Text = "Style Name Id:"
        '
        'OrderRemarksLabel
        '
        OrderRemarksLabel.AutoSize = True
        OrderRemarksLabel.Location = New System.Drawing.Point(15, 246)
        OrderRemarksLabel.Name = "OrderRemarksLabel"
        OrderRemarksLabel.Size = New System.Drawing.Size(83, 13)
        OrderRemarksLabel.TabIndex = 58
        OrderRemarksLabel.Text = "Order Remarks:"
        '
        'UserIdLabel1
        '
        UserIdLabel1.AutoSize = True
        UserIdLabel1.Location = New System.Drawing.Point(368, 174)
        UserIdLabel1.Name = "UserIdLabel1"
        UserIdLabel1.Size = New System.Drawing.Size(75, 13)
        UserIdLabel1.TabIndex = 62
        UserIdLabel1.Text = "Merchandiser:"
        '
        'GarmentDescriptionLabel1
        '
        GarmentDescriptionLabel1.Location = New System.Drawing.Point(15, 197)
        GarmentDescriptionLabel1.Name = "GarmentDescriptionLabel1"
        GarmentDescriptionLabel1.Size = New System.Drawing.Size(114, 42)
        GarmentDescriptionLabel1.TabIndex = 82
        GarmentDescriptionLabel1.Text = "Garment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Description:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(368, 79)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(42, 13)
        Label2.TabIndex = 86
        Label2.Text = "Buyer :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(368, 128)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(47, 13)
        Label5.TabIndex = 87
        Label5.Text = "Division:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(368, 151)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(46, 13)
        Label7.TabIndex = 88
        Label7.Text = "Season:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Location = New System.Drawing.Point(368, 103)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(39, 13)
        BrandLabel.TabIndex = 92
        BrandLabel.Text = "Brand:"
        '
        'CuttingWPLabel
        '
        CuttingWPLabel.AutoSize = True
        CuttingWPLabel.Location = New System.Drawing.Point(788, 27)
        CuttingWPLabel.Name = "CuttingWPLabel"
        CuttingWPLabel.Size = New System.Drawing.Size(56, 13)
        CuttingWPLabel.TabIndex = 75
        CuttingWPLabel.Text = "Cutting %"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(595, 136)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(81, 13)
        Label6.TabIndex = 18
        Label6.Text = "Fabric Material:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(595, 157)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(121, 13)
        Label16.TabIndex = 18
        Label16.Text = "Sustainability Standard:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.ForeColor = System.Drawing.Color.Red
        Label9.Location = New System.Drawing.Point(15, 269)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(109, 13)
        Label9.TabIndex = 106
        Label9.Text = "Copy O. Details (F3):"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.HoldOnDateEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsHoldCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AdvPrgNoGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label9)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.BPrgNoLinkLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LinkLabel2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.YarnDyeingTypeGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PicturePictureEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CancelDateEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.FullCompleteDateDateEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.InputCompleteDateDateEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsInputCompleteCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ApprovedSampleNoTextBox)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.MasterProgramNoTextBox)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GMTBrandIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(BrandLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsYDSCheckBox)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.btnGetData)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label7)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label5)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GarmentDescriptionMemoEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(GarmentDescriptionLabel1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsBrushCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsPeachFinishCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AOPDetailsTextBox)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PrintDetailsTextBox)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.EmbroideryDetailsTextBox)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsAOPCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsCompleteCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.WashCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SusStandGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.FabMatGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.WashTypeIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsAdvanceCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsEmbroideryCheckEdit1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsFabricBOMCompleteCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsAccBOMCompleteCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(UserIdLabel1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.UserIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AmndButton)
        Me.SplitContainerControl1.Panel1.Controls.Add(OrderRemarksLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.OrderRemarksTextEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GarmentIdLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.StyleIdLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AmendmentNoSpinEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ProgramNoTextEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.StyleIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.BuyerIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(OrderReceiveDateLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.OrderReceiveDateDateEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(AmendmentDateLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AmendmentDateDateEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(AmendmentNoLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label16)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label6)
        Me.SplitContainerControl1.Panel1.Controls.Add(CauseofAmendmentLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CauseofAmendmentMemoEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.DiscontinueCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.DivisionIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SeasonIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GarmentIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SpecialYarnCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SequenceCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SublimationCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsPrintCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(StyleReferenceNoLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.StyleReferenceNoTextEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(UserIdLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.UserIdComboBox)
        Me.SplitContainerControl1.Panel1.Controls.Add(ModifiedDateLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ModifiedDateDateEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(IsMultiPartLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsMultiPartCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(IsEmbroideryLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(AdvOrderIdLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AdvOrderIdSpinEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(StyleNameIdLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.StyleNameIdSpinEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainerControl1.Panel1.Text = "MainPanel"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1370, 701)
        Me.SplitContainerControl1.SplitterPosition = 312
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'HoldOnDateEdit
        '
        Me.HoldOnDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "HoldOn", True))
        Me.HoldOnDateEdit.EditValue = Nothing
        Me.HoldOnDateEdit.Location = New System.Drawing.Point(232, 294)
        Me.HoldOnDateEdit.Name = "HoldOnDateEdit"
        Me.HoldOnDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HoldOnDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HoldOnDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.HoldOnDateEdit.TabIndex = 110
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.OrderDataSet
        '
        'OrderDataSet
        '
        Me.OrderDataSet.DataSetName = "OrderDataSet"
        Me.OrderDataSet.EnforceConstraints = False
        Me.OrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IsHoldCheckEdit
        '
        Me.IsHoldCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsHold", True))
        Me.IsHoldCheckEdit.Location = New System.Drawing.Point(135, 295)
        Me.IsHoldCheckEdit.Name = "IsHoldCheckEdit"
        Me.IsHoldCheckEdit.Properties.Caption = "Hold On"
        Me.IsHoldCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsHoldCheckEdit.TabIndex = 109
        '
        'AdvPrgNoGridLookUpEdit
        '
        Me.AdvPrgNoGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "AdvanceProgramNo", True))
        Me.AdvPrgNoGridLookUpEdit.Location = New System.Drawing.Point(455, 51)
        Me.AdvPrgNoGridLookUpEdit.Name = "AdvPrgNoGridLookUpEdit"
        Me.AdvPrgNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AdvPrgNoGridLookUpEdit.Properties.DataSource = Me.AdvProgramLookupBindingSource
        Me.AdvPrgNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.AdvPrgNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.AdvPrgNoGridLookUpEdit.Properties.NullText = ""
        Me.AdvPrgNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AdvPrgNoGridLookUpEdit.Properties.PopupView = Me.GridView21
        Me.AdvPrgNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AdvPrgNoGridLookUpEdit.Properties.ValueMember = "ProgramNo"
        Me.AdvPrgNoGridLookUpEdit.Size = New System.Drawing.Size(131, 20)
        Me.AdvPrgNoGridLookUpEdit.TabIndex = 108
        '
        'AdvProgramLookupBindingSource
        '
        Me.AdvProgramLookupBindingSource.DataMember = "AdvProgramLookup"
        Me.AdvProgramLookupBindingSource.DataSource = Me.AdvProgramLookupDataSet
        '
        'AdvProgramLookupDataSet
        '
        Me.AdvProgramLookupDataSet.DataSetName = "AdvProgramLookupDataSet"
        Me.AdvProgramLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView21
        '
        Me.GridView21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo})
        Me.GridView21.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView21.Name = "GridView21"
        Me.GridView21.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView21.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'BPrgNoLinkLabel
        '
        Me.BPrgNoLinkLabel.AutoSize = True
        Me.BPrgNoLinkLabel.Location = New System.Drawing.Point(368, 53)
        Me.BPrgNoLinkLabel.Name = "BPrgNoLinkLabel"
        Me.BPrgNoLinkLabel.Size = New System.Drawing.Size(83, 13)
        Me.BPrgNoLinkLabel.TabIndex = 105
        Me.BPrgNoLinkLabel.TabStop = True
        Me.BPrgNoLinkLabel.Text = "B. Program No :"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 52)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(94, 13)
        Me.LinkLabel2.TabIndex = 105
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Master Order No :"
        '
        'YarnDyeingTypeGridLookUpEdit
        '
        Me.YarnDyeingTypeGridLookUpEdit.Location = New System.Drawing.Point(888, 263)
        Me.YarnDyeingTypeGridLookUpEdit.Name = "YarnDyeingTypeGridLookUpEdit"
        Me.YarnDyeingTypeGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YarnDyeingTypeGridLookUpEdit.Properties.ImmediatePopup = True
        Me.YarnDyeingTypeGridLookUpEdit.Properties.NullText = ""
        Me.YarnDyeingTypeGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.YarnDyeingTypeGridLookUpEdit.Properties.PopupView = Me.YarnDyeingTypeGridView
        Me.YarnDyeingTypeGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.YarnDyeingTypeGridLookUpEdit.Size = New System.Drawing.Size(103, 20)
        Me.YarnDyeingTypeGridLookUpEdit.TabIndex = 104
        '
        'YarnDyeingTypeGridView
        '
        Me.YarnDyeingTypeGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.YarnDyeingTypeGridView.Name = "YarnDyeingTypeGridView"
        Me.YarnDyeingTypeGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.YarnDyeingTypeGridView.OptionsView.ShowGroupPanel = False
        '
        'PicturePictureEdit
        '
        Me.PicturePictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StyleBindingSource, "Picture", True))
        Me.PicturePictureEdit.Location = New System.Drawing.Point(1212, 58)
        Me.PicturePictureEdit.Name = "PicturePictureEdit"
        Me.PicturePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PicturePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PicturePictureEdit.Size = New System.Drawing.Size(204, 225)
        Me.PicturePictureEdit.TabIndex = 103
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
        'CancelDateEdit
        '
        Me.CancelDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "CancelledOn", True))
        Me.CancelDateEdit.EditValue = Nothing
        Me.CancelDateEdit.Location = New System.Drawing.Point(603, 268)
        Me.CancelDateEdit.Name = "CancelDateEdit"
        Me.CancelDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CancelDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CancelDateEdit.Properties.ReadOnly = True
        Me.CancelDateEdit.Size = New System.Drawing.Size(95, 20)
        Me.CancelDateEdit.TabIndex = 102
        '
        'FullCompleteDateDateEdit
        '
        Me.FullCompleteDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "FullCompleteDate", True))
        Me.FullCompleteDateDateEdit.EditValue = Nothing
        Me.FullCompleteDateDateEdit.Location = New System.Drawing.Point(427, 268)
        Me.FullCompleteDateDateEdit.Name = "FullCompleteDateDateEdit"
        Me.FullCompleteDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FullCompleteDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FullCompleteDateDateEdit.Properties.ReadOnly = True
        Me.FullCompleteDateDateEdit.Size = New System.Drawing.Size(95, 20)
        Me.FullCompleteDateDateEdit.TabIndex = 102
        '
        'InputCompleteDateDateEdit
        '
        Me.InputCompleteDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "InputCompleteDate", True))
        Me.InputCompleteDateDateEdit.EditValue = Nothing
        Me.InputCompleteDateDateEdit.Location = New System.Drawing.Point(232, 268)
        Me.InputCompleteDateDateEdit.Name = "InputCompleteDateDateEdit"
        Me.InputCompleteDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InputCompleteDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InputCompleteDateDateEdit.Properties.ReadOnly = True
        Me.InputCompleteDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.InputCompleteDateDateEdit.TabIndex = 101
        '
        'IsInputCompleteCheckEdit
        '
        Me.IsInputCompleteCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsInputComplete", True))
        Me.IsInputCompleteCheckEdit.Location = New System.Drawing.Point(135, 267)
        Me.IsInputCompleteCheckEdit.Name = "IsInputCompleteCheckEdit"
        Me.IsInputCompleteCheckEdit.Properties.Caption = "Input Complete"
        Me.IsInputCompleteCheckEdit.Properties.ReadOnly = True
        Me.IsInputCompleteCheckEdit.Size = New System.Drawing.Size(98, 19)
        Me.IsInputCompleteCheckEdit.TabIndex = 100
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(999, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(197, 74)
        Me.GroupBox2.TabIndex = 99
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Others Program "
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.OrderLookupByStyleBindingSource
        Me.ListBox1.DisplayMember = "ProgramNo"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(8, 20)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(183, 43)
        Me.ListBox1.TabIndex = 60
        Me.ListBox1.ValueMember = "OrderId"
        '
        'OrderLookupByStyleBindingSource
        '
        Me.OrderLookupByStyleBindingSource.DataMember = "OrderLookupByStyle"
        Me.OrderLookupByStyleBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.EnforceConstraints = False
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TTLOffDayLabel2)
        Me.GroupBox1.Controls.Add(Me.TTLDayLabel2)
        Me.GroupBox1.Controls.Add(Me.WDLabel)
        Me.GroupBox1.Controls.Add(Me.TTLWDayLabel2)
        Me.GroupBox1.Controls.Add(Me.TTLOffDayLabel)
        Me.GroupBox1.Controls.Add(Me.TTLDayLabel)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.ActivitiesGroupIdGridLookUpEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(999, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 142)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Activities / TNA / Critical Path"
        '
        'TTLOffDayLabel2
        '
        Me.TTLOffDayLabel2.BackColor = System.Drawing.Color.Yellow
        Me.TTLOffDayLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLOffDayLabel2.Location = New System.Drawing.Point(136, 43)
        Me.TTLOffDayLabel2.Name = "TTLOffDayLabel2"
        Me.TTLOffDayLabel2.Size = New System.Drawing.Size(55, 18)
        Me.TTLOffDayLabel2.TabIndex = 15
        Me.TTLOffDayLabel2.Text = "0"
        Me.TTLOffDayLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TTLDayLabel2
        '
        Me.TTLDayLabel2.BackColor = System.Drawing.Color.Yellow
        Me.TTLDayLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLDayLabel2.Location = New System.Drawing.Point(136, 22)
        Me.TTLDayLabel2.Name = "TTLDayLabel2"
        Me.TTLDayLabel2.Size = New System.Drawing.Size(55, 18)
        Me.TTLDayLabel2.TabIndex = 15
        Me.TTLDayLabel2.Text = "0"
        Me.TTLDayLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WDLabel
        '
        Me.WDLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WDLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "TTLWDay", True))
        Me.WDLabel.Location = New System.Drawing.Point(74, 66)
        Me.WDLabel.Name = "WDLabel"
        Me.WDLabel.Size = New System.Drawing.Size(61, 18)
        Me.WDLabel.TabIndex = 15
        Me.WDLabel.Text = "0"
        Me.WDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TTLWDayLabel2
        '
        Me.TTLWDayLabel2.BackColor = System.Drawing.Color.Yellow
        Me.TTLWDayLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLWDayLabel2.Location = New System.Drawing.Point(136, 67)
        Me.TTLWDayLabel2.Name = "TTLWDayLabel2"
        Me.TTLWDayLabel2.Size = New System.Drawing.Size(55, 18)
        Me.TTLWDayLabel2.TabIndex = 15
        Me.TTLWDayLabel2.Text = "0"
        Me.TTLWDayLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TTLOffDayLabel
        '
        Me.TTLOffDayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLOffDayLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "TTLOffDay", True))
        Me.TTLOffDayLabel.Location = New System.Drawing.Point(74, 43)
        Me.TTLOffDayLabel.Name = "TTLOffDayLabel"
        Me.TTLOffDayLabel.Size = New System.Drawing.Size(61, 18)
        Me.TTLOffDayLabel.TabIndex = 14
        Me.TTLOffDayLabel.Text = "0"
        Me.TTLOffDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TTLDayLabel
        '
        Me.TTLDayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TTLDayLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "TTLDay", True))
        Me.TTLDayLabel.Location = New System.Drawing.Point(74, 22)
        Me.TTLDayLabel.Name = "TTLDayLabel"
        Me.TTLDayLabel.Size = New System.Drawing.Size(61, 17)
        Me.TTLDayLabel.TabIndex = 13
        Me.TTLDayLabel.Text = "0"
        Me.TTLDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Work Day"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "OFF Day"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "TTL Day"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Activities Template"
        '
        'ActivitiesGroupIdGridLookUpEdit
        '
        Me.ActivitiesGroupIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "ActivitiesGroupId", True))
        Me.ActivitiesGroupIdGridLookUpEdit.Location = New System.Drawing.Point(8, 117)
        Me.ActivitiesGroupIdGridLookUpEdit.Name = "ActivitiesGroupIdGridLookUpEdit"
        Me.ActivitiesGroupIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActivitiesGroupIdGridLookUpEdit.Properties.DataSource = Me.ActivitiesGroupBindingSource
        Me.ActivitiesGroupIdGridLookUpEdit.Properties.DisplayMember = "ActivitiesGroup"
        Me.ActivitiesGroupIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ActivitiesGroupIdGridLookUpEdit.Properties.NullText = ""
        Me.ActivitiesGroupIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ActivitiesGroupIdGridLookUpEdit.Properties.PopupView = Me.GridView26
        Me.ActivitiesGroupIdGridLookUpEdit.Properties.ReadOnly = True
        Me.ActivitiesGroupIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ActivitiesGroupIdGridLookUpEdit.Properties.ValueMember = "ActivitiesGroupId"
        Me.ActivitiesGroupIdGridLookUpEdit.Size = New System.Drawing.Size(183, 20)
        Me.ActivitiesGroupIdGridLookUpEdit.TabIndex = 7
        '
        'ActivitiesGroupBindingSource
        '
        Me.ActivitiesGroupBindingSource.DataMember = "ActivitiesGroup"
        Me.ActivitiesGroupBindingSource.DataSource = Me.ActivitiesGroupDataSet
        '
        'ActivitiesGroupDataSet
        '
        Me.ActivitiesGroupDataSet.DataSetName = "ActivitiesGroupDataSet"
        Me.ActivitiesGroupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView26
        '
        Me.GridView26.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesGroup1})
        Me.GridView26.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView26.Name = "GridView26"
        Me.GridView26.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView26.OptionsView.ShowGroupPanel = False
        '
        'colActivitiesGroup1
        '
        Me.colActivitiesGroup1.FieldName = "ActivitiesGroup"
        Me.colActivitiesGroup1.Name = "colActivitiesGroup1"
        Me.colActivitiesGroup1.Visible = True
        Me.colActivitiesGroup1.VisibleIndex = 0
        '
        'ApprovedSampleNoTextBox
        '
        Me.ApprovedSampleNoTextBox.BackColor = System.Drawing.Color.White
        Me.ApprovedSampleNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "ApprovedSampleNo", True))
        Me.ApprovedSampleNoTextBox.Location = New System.Drawing.Point(135, 99)
        Me.ApprovedSampleNoTextBox.Name = "ApprovedSampleNoTextBox"
        Me.ApprovedSampleNoTextBox.Size = New System.Drawing.Size(131, 21)
        Me.ApprovedSampleNoTextBox.TabIndex = 1
        '
        'MasterProgramNoTextBox
        '
        Me.MasterProgramNoTextBox.BackColor = System.Drawing.Color.Yellow
        Me.MasterProgramNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "MasterProgramNo", True))
        Me.MasterProgramNoTextBox.Location = New System.Drawing.Point(135, 49)
        Me.MasterProgramNoTextBox.Name = "MasterProgramNoTextBox"
        Me.MasterProgramNoTextBox.ReadOnly = True
        Me.MasterProgramNoTextBox.Size = New System.Drawing.Size(131, 21)
        Me.MasterProgramNoTextBox.TabIndex = 0
        '
        'GMTBrandIdGridLookUpEdit
        '
        Me.GMTBrandIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "GMTBrandId", True))
        Me.GMTBrandIdGridLookUpEdit.Location = New System.Drawing.Point(455, 101)
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
        Me.GMTBrandIdGridLookUpEdit.Size = New System.Drawing.Size(131, 20)
        Me.GMTBrandIdGridLookUpEdit.TabIndex = 7
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
        Me.GMTBrandIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGMTBrandName1})
        Me.GMTBrandIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GMTBrandIdGridLookUpEditView.Name = "GMTBrandIdGridLookUpEditView"
        Me.GMTBrandIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GMTBrandIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colGMTBrandName1
        '
        Me.colGMTBrandName1.FieldName = "GMTBrandName"
        Me.colGMTBrandName1.Name = "colGMTBrandName1"
        Me.colGMTBrandName1.Visible = True
        Me.colGMTBrandName1.VisibleIndex = 0
        '
        'IsYDSCheckBox
        '
        Me.IsYDSCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsYDS", True))
        Me.IsYDSCheckBox.Location = New System.Drawing.Point(889, 240)
        Me.IsYDSCheckBox.Name = "IsYDSCheckBox"
        Me.IsYDSCheckBox.Properties.Caption = "YD/YDS"
        Me.IsYDSCheckBox.Size = New System.Drawing.Size(75, 19)
        Me.IsYDSCheckBox.TabIndex = 92
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Program No.:"
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(270, 48)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(62, 23)
        Me.btnGetData.TabIndex = 90
        Me.btnGetData.Text = "Get Data"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'GarmentDescriptionMemoEdit
        '
        Me.GarmentDescriptionMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "GarmentDescription", True))
        Me.GarmentDescriptionMemoEdit.Location = New System.Drawing.Point(135, 199)
        Me.GarmentDescriptionMemoEdit.Name = "GarmentDescriptionMemoEdit"
        Me.GarmentDescriptionMemoEdit.Size = New System.Drawing.Size(451, 40)
        Me.GarmentDescriptionMemoEdit.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(721, 265)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "BOM Status"
        '
        'IsBrushCheckEdit
        '
        Me.IsBrushCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsBrush", True))
        Me.IsBrushCheckEdit.Location = New System.Drawing.Point(714, 234)
        Me.IsBrushCheckEdit.Name = "IsBrushCheckEdit"
        Me.IsBrushCheckEdit.Properties.Caption = "Brush"
        Me.IsBrushCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsBrushCheckEdit.TabIndex = 81
        '
        'IsPeachFinishCheckEdit
        '
        Me.IsPeachFinishCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsPeachFinish", True))
        Me.IsPeachFinishCheckEdit.Location = New System.Drawing.Point(603, 234)
        Me.IsPeachFinishCheckEdit.Name = "IsPeachFinishCheckEdit"
        Me.IsPeachFinishCheckEdit.Properties.Caption = "Peach"
        Me.IsPeachFinishCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsPeachFinishCheckEdit.TabIndex = 80
        '
        'AOPDetailsTextBox
        '
        Me.AOPDetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "AOPDetails", True))
        Me.AOPDetailsTextBox.Location = New System.Drawing.Point(714, 182)
        Me.AOPDetailsTextBox.Name = "AOPDetailsTextBox"
        Me.AOPDetailsTextBox.Size = New System.Drawing.Size(153, 21)
        Me.AOPDetailsTextBox.TabIndex = 17
        '
        'PrintDetailsTextBox
        '
        Me.PrintDetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "PrintDetails", True))
        Me.PrintDetailsTextBox.Location = New System.Drawing.Point(887, 74)
        Me.PrintDetailsTextBox.Name = "PrintDetailsTextBox"
        Me.PrintDetailsTextBox.Size = New System.Drawing.Size(104, 21)
        Me.PrintDetailsTextBox.TabIndex = 16
        '
        'EmbroideryDetailsTextBox
        '
        Me.EmbroideryDetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "EmbroideryDetails", True))
        Me.EmbroideryDetailsTextBox.Location = New System.Drawing.Point(887, 146)
        Me.EmbroideryDetailsTextBox.Name = "EmbroideryDetailsTextBox"
        Me.EmbroideryDetailsTextBox.Size = New System.Drawing.Size(104, 21)
        Me.EmbroideryDetailsTextBox.TabIndex = 16
        '
        'IsAOPCheckEdit
        '
        Me.IsAOPCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsAOP", True))
        Me.IsAOPCheckEdit.Location = New System.Drawing.Point(603, 184)
        Me.IsAOPCheckEdit.Name = "IsAOPCheckEdit"
        Me.IsAOPCheckEdit.Properties.Caption = "AOP"
        Me.IsAOPCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsAOPCheckEdit.TabIndex = 76
        '
        'IsCompleteCheckEdit
        '
        Me.IsCompleteCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsComplete", True))
        Me.IsCompleteCheckEdit.Location = New System.Drawing.Point(339, 267)
        Me.IsCompleteCheckEdit.Name = "IsCompleteCheckEdit"
        Me.IsCompleteCheckEdit.Properties.Caption = "Full Complete"
        Me.IsCompleteCheckEdit.Properties.ReadOnly = True
        Me.IsCompleteCheckEdit.Size = New System.Drawing.Size(91, 19)
        Me.IsCompleteCheckEdit.TabIndex = 75
        '
        'WashCheckEdit
        '
        Me.WashCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsWash", True))
        Me.WashCheckEdit.Location = New System.Drawing.Point(603, 209)
        Me.WashCheckEdit.Name = "WashCheckEdit"
        Me.WashCheckEdit.Properties.Caption = "Wash"
        Me.WashCheckEdit.Size = New System.Drawing.Size(50, 19)
        Me.WashCheckEdit.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(996, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Others Program"
        '
        'SusStandGridLookUpEdit
        '
        Me.SusStandGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "SusStandard", True))
        Me.SusStandGridLookUpEdit.EditValue = ""
        Me.SusStandGridLookUpEdit.Location = New System.Drawing.Point(714, 156)
        Me.SusStandGridLookUpEdit.Name = "SusStandGridLookUpEdit"
        Me.SusStandGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SusStandGridLookUpEdit.Properties.DataSource = Me.SusStandardMstBindingSource
        Me.SusStandGridLookUpEdit.Properties.DisplayMember = "SusStandard"
        Me.SusStandGridLookUpEdit.Properties.NullText = ""
        Me.SusStandGridLookUpEdit.Properties.PopupView = Me.GridView20
        Me.SusStandGridLookUpEdit.Properties.ValueMember = "SusStandard"
        Me.SusStandGridLookUpEdit.Size = New System.Drawing.Size(153, 20)
        Me.SusStandGridLookUpEdit.TabIndex = 18
        '
        'SusStandardMstBindingSource
        '
        Me.SusStandardMstBindingSource.DataMember = "SusStandardMst"
        Me.SusStandardMstBindingSource.DataSource = Me.SusStandardDataSet
        '
        'SusStandardDataSet
        '
        Me.SusStandardDataSet.DataSetName = "SusStandardDataSet"
        Me.SusStandardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView20
        '
        Me.GridView20.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSusStandard})
        Me.GridView20.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView20.Name = "GridView20"
        Me.GridView20.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView20.OptionsView.ShowGroupPanel = False
        '
        'colSusStandard
        '
        Me.colSusStandard.FieldName = "SusStandard"
        Me.colSusStandard.Name = "colSusStandard"
        Me.colSusStandard.Visible = True
        Me.colSusStandard.VisibleIndex = 0
        '
        'FabMatGridLookUpEdit
        '
        Me.FabMatGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "FabMatType", True))
        Me.FabMatGridLookUpEdit.EditValue = ""
        Me.FabMatGridLookUpEdit.Location = New System.Drawing.Point(715, 133)
        Me.FabMatGridLookUpEdit.Name = "FabMatGridLookUpEdit"
        Me.FabMatGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabMatGridLookUpEdit.Properties.DataSource = Me.FabricMaterialTypeBindingSource
        Me.FabMatGridLookUpEdit.Properties.DisplayMember = "FabMatType"
        Me.FabMatGridLookUpEdit.Properties.NullText = ""
        Me.FabMatGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.FabMatGridLookUpEdit.Properties.ValueMember = "FabMatType"
        Me.FabMatGridLookUpEdit.Size = New System.Drawing.Size(153, 20)
        Me.FabMatGridLookUpEdit.TabIndex = 18
        '
        'FabricMaterialTypeBindingSource
        '
        Me.FabricMaterialTypeBindingSource.DataMember = "FabricMaterialType"
        Me.FabricMaterialTypeBindingSource.DataSource = Me.FabricMaterialTypeDataSet
        '
        'FabricMaterialTypeDataSet
        '
        Me.FabricMaterialTypeDataSet.DataSetName = "FabricMaterialTypeDataSet"
        Me.FabricMaterialTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabMatType})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFabMatType
        '
        Me.colFabMatType.FieldName = "FabMatType"
        Me.colFabMatType.Name = "colFabMatType"
        Me.colFabMatType.Visible = True
        Me.colFabMatType.VisibleIndex = 0
        '
        'WashTypeIdGridLookUpEdit
        '
        Me.WashTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "WashTypeId", True))
        Me.WashTypeIdGridLookUpEdit.Enabled = False
        Me.WashTypeIdGridLookUpEdit.Location = New System.Drawing.Point(714, 208)
        Me.WashTypeIdGridLookUpEdit.Name = "WashTypeIdGridLookUpEdit"
        Me.WashTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WashTypeIdGridLookUpEdit.Properties.DataSource = Me.WashTypeMstBindingSource
        Me.WashTypeIdGridLookUpEdit.Properties.DisplayMember = "WashType"
        Me.WashTypeIdGridLookUpEdit.Properties.NullText = "[Wash Type]"
        Me.WashTypeIdGridLookUpEdit.Properties.PopupView = Me.WashTypeIdGridLookUpEditView
        Me.WashTypeIdGridLookUpEdit.Properties.ValueMember = "WashTypeId"
        Me.WashTypeIdGridLookUpEdit.Size = New System.Drawing.Size(153, 20)
        Me.WashTypeIdGridLookUpEdit.TabIndex = 18
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
        Me.WashTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWashType1})
        Me.WashTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.WashTypeIdGridLookUpEditView.Name = "WashTypeIdGridLookUpEditView"
        Me.WashTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.WashTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colWashType1
        '
        Me.colWashType1.FieldName = "WashType"
        Me.colWashType1.Name = "colWashType1"
        Me.colWashType1.Visible = True
        Me.colWashType1.VisibleIndex = 0
        '
        'IsAdvanceCheckEdit
        '
        Me.IsAdvanceCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsAdvance", True))
        Me.IsAdvanceCheckEdit.Location = New System.Drawing.Point(270, 75)
        Me.IsAdvanceCheckEdit.Name = "IsAdvanceCheckEdit"
        Me.IsAdvanceCheckEdit.Properties.Caption = "Is Advance"
        Me.IsAdvanceCheckEdit.Size = New System.Drawing.Size(103, 19)
        Me.IsAdvanceCheckEdit.TabIndex = 67
        '
        'IsEmbroideryCheckEdit1
        '
        Me.IsEmbroideryCheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsEmbroidery", True))
        Me.IsEmbroideryCheckEdit1.Location = New System.Drawing.Point(887, 123)
        Me.IsEmbroideryCheckEdit1.Name = "IsEmbroideryCheckEdit1"
        Me.IsEmbroideryCheckEdit1.Properties.Caption = "Embroidery"
        Me.IsEmbroideryCheckEdit1.Size = New System.Drawing.Size(75, 19)
        Me.IsEmbroideryCheckEdit1.TabIndex = 14
        '
        'IsFabricBOMCompleteCheckEdit
        '
        Me.IsFabricBOMCompleteCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsFabricBOMComplete", True))
        Me.IsFabricBOMCompleteCheckEdit.Enabled = False
        Me.IsFabricBOMCompleteCheckEdit.Location = New System.Drawing.Point(792, 234)
        Me.IsFabricBOMCompleteCheckEdit.Name = "IsFabricBOMCompleteCheckEdit"
        Me.IsFabricBOMCompleteCheckEdit.Properties.Caption = "Fab BOM"
        Me.IsFabricBOMCompleteCheckEdit.Properties.ReadOnly = True
        Me.IsFabricBOMCompleteCheckEdit.Size = New System.Drawing.Size(76, 19)
        Me.IsFabricBOMCompleteCheckEdit.TabIndex = 15
        '
        'IsAccBOMCompleteCheckEdit
        '
        Me.IsAccBOMCompleteCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsAccBOMComplete", True))
        Me.IsAccBOMCompleteCheckEdit.Enabled = False
        Me.IsAccBOMCompleteCheckEdit.Location = New System.Drawing.Point(792, 263)
        Me.IsAccBOMCompleteCheckEdit.Name = "IsAccBOMCompleteCheckEdit"
        Me.IsAccBOMCompleteCheckEdit.Properties.Caption = "Acc BOM"
        Me.IsAccBOMCompleteCheckEdit.Properties.ReadOnly = True
        Me.IsAccBOMCompleteCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsAccBOMCompleteCheckEdit.TabIndex = 16
        '
        'UserIdGridLookUpEdit
        '
        Me.UserIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "UserId", True))
        Me.UserIdGridLookUpEdit.Location = New System.Drawing.Point(455, 173)
        Me.UserIdGridLookUpEdit.Name = "UserIdGridLookUpEdit"
        Me.UserIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserIdGridLookUpEdit.Properties.DataSource = Me.UserLookupBindingSource
        Me.UserIdGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.UserIdGridLookUpEdit.Properties.NullText = ""
        Me.UserIdGridLookUpEdit.Properties.PopupView = Me.UserIdGridLookUpEditView
        Me.UserIdGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.UserIdGridLookUpEdit.Size = New System.Drawing.Size(131, 20)
        Me.UserIdGridLookUpEdit.TabIndex = 14
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
        'UserIdGridLookUpEditView
        '
        Me.UserIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME3, Me.colDepartment1})
        Me.UserIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.UserIdGridLookUpEditView.Name = "UserIdGridLookUpEditView"
        Me.UserIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.UserIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME3
        '
        Me.colUSER_NAME3.Caption = "Merchandiser"
        Me.colUSER_NAME3.FieldName = "USER_NAME"
        Me.colUSER_NAME3.Name = "colUSER_NAME3"
        Me.colUSER_NAME3.Visible = True
        Me.colUSER_NAME3.VisibleIndex = 1
        '
        'colDepartment1
        '
        Me.colDepartment1.Caption = "Department"
        Me.colDepartment1.FieldName = "Department"
        Me.colDepartment1.Name = "colDepartment1"
        Me.colDepartment1.Visible = True
        Me.colDepartment1.VisibleIndex = 0
        '
        'AmndButton
        '
        Me.AmndButton.Location = New System.Drawing.Point(770, 48)
        Me.AmndButton.Name = "AmndButton"
        Me.AmndButton.Size = New System.Drawing.Size(98, 23)
        Me.AmndButton.TabIndex = 61
        Me.AmndButton.Text = "Add to Amnd History"
        Me.AmndButton.UseVisualStyleBackColor = True
        '
        'OrderRemarksTextEdit
        '
        Me.OrderRemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "OrderRemarks", True))
        Me.OrderRemarksTextEdit.Location = New System.Drawing.Point(135, 243)
        Me.OrderRemarksTextEdit.Name = "OrderRemarksTextEdit"
        Me.OrderRemarksTextEdit.Size = New System.Drawing.Size(452, 20)
        Me.OrderRemarksTextEdit.TabIndex = 59
        '
        'GarmentIdLabel
        '
        Me.GarmentIdLabel.AutoSize = True
        Me.GarmentIdLabel.Location = New System.Drawing.Point(260, 219)
        Me.GarmentIdLabel.Name = "GarmentIdLabel"
        Me.GarmentIdLabel.Size = New System.Drawing.Size(81, 13)
        Me.GarmentIdLabel.TabIndex = 57
        Me.GarmentIdLabel.TabStop = True
        Me.GarmentIdLabel.Text = "Garment (F11):"
        '
        'StyleIdLabel
        '
        Me.StyleIdLabel.AutoSize = True
        Me.StyleIdLabel.Location = New System.Drawing.Point(12, 152)
        Me.StyleIdLabel.Name = "StyleIdLabel"
        Me.StyleIdLabel.Size = New System.Drawing.Size(64, 13)
        Me.StyleIdLabel.TabIndex = 54
        Me.StyleIdLabel.TabStop = True
        Me.StyleIdLabel.Text = "Style (F11):"
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
        Me.FlowLayoutPanel1.Controls.Add(Me.GenTNAButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.OrderLookupGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.ExportButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CopyFullButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1370, 35)
        Me.FlowLayoutPanel1.TabIndex = 51
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
        'GenTNAButton
        '
        Me.GenTNAButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenTNAButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GenTNAButton.Location = New System.Drawing.Point(460, 3)
        Me.GenTNAButton.Name = "GenTNAButton"
        Me.GenTNAButton.Size = New System.Drawing.Size(126, 27)
        Me.GenTNAButton.TabIndex = 48
        Me.GenTNAButton.Text = "&Create/Update TNA"
        Me.GenTNAButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(592, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 12, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Filter By Program No :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderLookupGridLookUpEdit
        '
        Me.OrderLookupGridLookUpEdit.EditValue = "[Select your Program]"
        Me.OrderLookupGridLookUpEdit.Location = New System.Drawing.Point(724, 7)
        Me.OrderLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.OrderLookupGridLookUpEdit.Name = "OrderLookupGridLookUpEdit"
        Me.OrderLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderLookupGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderLookupGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.OrderLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderLookupGridLookUpEdit.Properties.NullText = "Select your Program"
        Me.OrderLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderLookupGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.OrderLookupGridLookUpEdit.Properties.Tag = "NR"
        Me.OrderLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderLookupGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderLookupGridLookUpEdit.Size = New System.Drawing.Size(251, 20)
        Me.OrderLookupGridLookUpEdit.TabIndex = 36
        Me.OrderLookupGridLookUpEdit.Tag = "NR"
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(981, 6)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 47
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Location = New System.Drawing.Point(1062, 6)
        Me.ExportButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(102, 23)
        Me.ExportButton.TabIndex = 46
        Me.ExportButton.Text = "Export For FR"
        Me.ExportButton.UseVisualStyleBackColor = True
        Me.ExportButton.Visible = False
        '
        'CopyFullButton
        '
        Me.CopyFullButton.Location = New System.Drawing.Point(1170, 6)
        Me.CopyFullButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.CopyFullButton.Name = "CopyFullButton"
        Me.CopyFullButton.Size = New System.Drawing.Size(123, 23)
        Me.CopyFullButton.TabIndex = 49
        Me.CopyFullButton.Text = "Copy the order"
        Me.CopyFullButton.UseVisualStyleBackColor = True
        '
        'AmendmentNoSpinEdit
        '
        Me.AmendmentNoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "AmendmentNo", True))
        Me.AmendmentNoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AmendmentNoSpinEdit.Location = New System.Drawing.Point(715, 50)
        Me.AmendmentNoSpinEdit.Name = "AmendmentNoSpinEdit"
        Me.AmendmentNoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentNoSpinEdit.Properties.ReadOnly = True
        Me.AmendmentNoSpinEdit.Size = New System.Drawing.Size(49, 20)
        Me.AmendmentNoSpinEdit.TabIndex = 11
        '
        'ProgramNoTextEdit
        '
        Me.ProgramNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "ProgramNo", True))
        Me.ProgramNoTextEdit.Location = New System.Drawing.Point(135, 74)
        Me.ProgramNoTextEdit.Name = "ProgramNoTextEdit"
        Me.ProgramNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.ProgramNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ProgramNoTextEdit.Properties.ReadOnly = True
        Me.ProgramNoTextEdit.Size = New System.Drawing.Size(131, 20)
        Me.ProgramNoTextEdit.TabIndex = 2
        '
        'StyleIdGridLookUpEdit
        '
        Me.StyleIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "StyleId", True))
        Me.StyleIdGridLookUpEdit.Location = New System.Drawing.Point(135, 150)
        Me.StyleIdGridLookUpEdit.Name = "StyleIdGridLookUpEdit"
        Me.StyleIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleIdGridLookUpEdit.Properties.DataSource = Me.StyleLookupBindingSource
        Me.StyleIdGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleIdGridLookUpEdit.Properties.NullText = ""
        Me.StyleIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleIdGridLookUpEdit.Properties.PopupView = Me.StyleIdGridLookUpEditView
        Me.StyleIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleIdGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleIdGridLookUpEdit.Size = New System.Drawing.Size(131, 20)
        Me.StyleIdGridLookUpEdit.TabIndex = 4
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
        Me.StyleIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleName1})
        Me.StyleIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.StyleIdGridLookUpEditView.Name = "StyleIdGridLookUpEditView"
        Me.StyleIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.StyleIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colStyleName1
        '
        Me.colStyleName1.FieldName = "StyleName"
        Me.colStyleName1.Name = "colStyleName1"
        Me.colStyleName1.Visible = True
        Me.colStyleName1.VisibleIndex = 0
        '
        'BuyerIdGridLookUpEdit
        '
        Me.BuyerIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "BuyerId", True))
        Me.BuyerIdGridLookUpEdit.Location = New System.Drawing.Point(455, 76)
        Me.BuyerIdGridLookUpEdit.Name = "BuyerIdGridLookUpEdit"
        Me.BuyerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerIdGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerIdGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerIdGridLookUpEdit.Properties.NullText = ""
        Me.BuyerIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerIdGridLookUpEdit.Properties.PopupView = Me.BuyerIdGridLookUpEditView
        Me.BuyerIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerIdGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerIdGridLookUpEdit.Size = New System.Drawing.Size(131, 20)
        Me.BuyerIdGridLookUpEdit.TabIndex = 3
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
        'BuyerIdGridLookUpEditView
        '
        Me.BuyerIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName1})
        Me.BuyerIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.BuyerIdGridLookUpEditView.Name = "BuyerIdGridLookUpEditView"
        Me.BuyerIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BuyerIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName1
        '
        Me.colBuyerName1.FieldName = "BuyerName"
        Me.colBuyerName1.Name = "colBuyerName1"
        Me.colBuyerName1.Visible = True
        Me.colBuyerName1.VisibleIndex = 0
        '
        'OrderReceiveDateDateEdit
        '
        Me.OrderReceiveDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "OrderReceiveDate", True))
        Me.OrderReceiveDateDateEdit.EditValue = Nothing
        Me.OrderReceiveDateDateEdit.Location = New System.Drawing.Point(135, 125)
        Me.OrderReceiveDateDateEdit.Name = "OrderReceiveDateDateEdit"
        Me.OrderReceiveDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderReceiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderReceiveDateDateEdit.Size = New System.Drawing.Size(131, 20)
        Me.OrderReceiveDateDateEdit.TabIndex = 6
        '
        'AmendmentDateDateEdit
        '
        Me.AmendmentDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "AmendmentDate", True))
        Me.AmendmentDateDateEdit.EditValue = Nothing
        Me.AmendmentDateDateEdit.Location = New System.Drawing.Point(715, 75)
        Me.AmendmentDateDateEdit.Name = "AmendmentDateDateEdit"
        Me.AmendmentDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentDateDateEdit.Properties.ReadOnly = True
        Me.AmendmentDateDateEdit.Size = New System.Drawing.Size(153, 20)
        Me.AmendmentDateDateEdit.TabIndex = 12
        '
        'CauseofAmendmentMemoEdit
        '
        Me.CauseofAmendmentMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "CauseofAmendment", True))
        Me.CauseofAmendmentMemoEdit.Location = New System.Drawing.Point(715, 100)
        Me.CauseofAmendmentMemoEdit.Name = "CauseofAmendmentMemoEdit"
        Me.CauseofAmendmentMemoEdit.Properties.ReadOnly = True
        Me.CauseofAmendmentMemoEdit.Size = New System.Drawing.Size(153, 29)
        Me.CauseofAmendmentMemoEdit.TabIndex = 13
        '
        'DiscontinueCheckEdit
        '
        Me.DiscontinueCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "Discontinue", True))
        Me.DiscontinueCheckEdit.Location = New System.Drawing.Point(528, 268)
        Me.DiscontinueCheckEdit.Name = "DiscontinueCheckEdit"
        Me.DiscontinueCheckEdit.Properties.Caption = "Full Cancel"
        Me.DiscontinueCheckEdit.Properties.ReadOnly = True
        Me.DiscontinueCheckEdit.Size = New System.Drawing.Size(74, 19)
        Me.DiscontinueCheckEdit.TabIndex = 17
        '
        'DivisionIdGridLookUpEdit
        '
        Me.DivisionIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "DivisionId", True))
        Me.DivisionIdGridLookUpEdit.Location = New System.Drawing.Point(455, 126)
        Me.DivisionIdGridLookUpEdit.Name = "DivisionIdGridLookUpEdit"
        Me.DivisionIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DivisionIdGridLookUpEdit.Properties.DataSource = Me.DivisionBindingSource
        Me.DivisionIdGridLookUpEdit.Properties.DisplayMember = "DivisionName"
        Me.DivisionIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.DivisionIdGridLookUpEdit.Properties.NullText = ""
        Me.DivisionIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.DivisionIdGridLookUpEdit.Properties.PopupView = Me.DivisionIdGridLookUpEditView
        Me.DivisionIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DivisionIdGridLookUpEdit.Properties.ValueMember = "DivisionId"
        Me.DivisionIdGridLookUpEdit.Size = New System.Drawing.Size(131, 20)
        Me.DivisionIdGridLookUpEdit.TabIndex = 8
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
        Me.DivisionIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDivisionName1})
        Me.DivisionIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.DivisionIdGridLookUpEditView.Name = "DivisionIdGridLookUpEditView"
        Me.DivisionIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DivisionIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDivisionName1
        '
        Me.colDivisionName1.FieldName = "DivisionName"
        Me.colDivisionName1.Name = "colDivisionName1"
        Me.colDivisionName1.Visible = True
        Me.colDivisionName1.VisibleIndex = 0
        '
        'SeasonIdGridLookUpEdit
        '
        Me.SeasonIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "SeasonId", True))
        Me.SeasonIdGridLookUpEdit.Location = New System.Drawing.Point(455, 149)
        Me.SeasonIdGridLookUpEdit.Name = "SeasonIdGridLookUpEdit"
        Me.SeasonIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SeasonIdGridLookUpEdit.Properties.DataSource = Me.SeasonBindingSource
        Me.SeasonIdGridLookUpEdit.Properties.DisplayMember = "SeasonName"
        Me.SeasonIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SeasonIdGridLookUpEdit.Properties.NullText = ""
        Me.SeasonIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SeasonIdGridLookUpEdit.Properties.PopupView = Me.SeasonIdGridLookUpEditView
        Me.SeasonIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SeasonIdGridLookUpEdit.Properties.ValueMember = "SeasonId"
        Me.SeasonIdGridLookUpEdit.Size = New System.Drawing.Size(131, 20)
        Me.SeasonIdGridLookUpEdit.TabIndex = 15
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
        'SeasonIdGridLookUpEditView
        '
        Me.SeasonIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeasonName1})
        Me.SeasonIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SeasonIdGridLookUpEditView.Name = "SeasonIdGridLookUpEditView"
        Me.SeasonIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SeasonIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colSeasonName1
        '
        Me.colSeasonName1.FieldName = "SeasonName"
        Me.colSeasonName1.Name = "colSeasonName1"
        Me.colSeasonName1.Visible = True
        Me.colSeasonName1.VisibleIndex = 0
        '
        'GarmentIdGridLookUpEdit
        '
        Me.GarmentIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "GarmentId", True))
        Me.GarmentIdGridLookUpEdit.Location = New System.Drawing.Point(381, 215)
        Me.GarmentIdGridLookUpEdit.Name = "GarmentIdGridLookUpEdit"
        Me.GarmentIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GarmentIdGridLookUpEdit.Properties.DataSource = Me.GarmentBindingSource
        Me.GarmentIdGridLookUpEdit.Properties.DisplayMember = "GarmentDescription"
        Me.GarmentIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.GarmentIdGridLookUpEdit.Properties.NullText = ""
        Me.GarmentIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GarmentIdGridLookUpEdit.Properties.PopupView = Me.GarmentIdGridLookUpEditView
        Me.GarmentIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GarmentIdGridLookUpEdit.Properties.ValueMember = "GarmentId"
        Me.GarmentIdGridLookUpEdit.Size = New System.Drawing.Size(206, 20)
        Me.GarmentIdGridLookUpEdit.TabIndex = 7
        '
        'GarmentBindingSource
        '
        Me.GarmentBindingSource.DataMember = "Garment"
        Me.GarmentBindingSource.DataSource = Me.GarmentDataSet
        '
        'GarmentDataSet
        '
        Me.GarmentDataSet.DataSetName = "GarmentDataSet"
        Me.GarmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GarmentIdGridLookUpEditView
        '
        Me.GarmentIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGarmentDescription})
        Me.GarmentIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GarmentIdGridLookUpEditView.Name = "GarmentIdGridLookUpEditView"
        Me.GarmentIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GarmentIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colGarmentDescription
        '
        Me.colGarmentDescription.FieldName = "GarmentDescription"
        Me.colGarmentDescription.Name = "colGarmentDescription"
        Me.colGarmentDescription.Visible = True
        Me.colGarmentDescription.VisibleIndex = 0
        '
        'SpecialYarnCheckEdit
        '
        Me.SpecialYarnCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsSpecialYarn", True))
        Me.SpecialYarnCheckEdit.Location = New System.Drawing.Point(889, 194)
        Me.SpecialYarnCheckEdit.Name = "SpecialYarnCheckEdit"
        Me.SpecialYarnCheckEdit.Properties.Caption = "Foreign Yarn"
        Me.SpecialYarnCheckEdit.Size = New System.Drawing.Size(86, 19)
        Me.SpecialYarnCheckEdit.TabIndex = 13
        '
        'SequenceCheckEdit
        '
        Me.SequenceCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsSequence", True))
        Me.SequenceCheckEdit.Location = New System.Drawing.Point(889, 172)
        Me.SequenceCheckEdit.Name = "SequenceCheckEdit"
        Me.SequenceCheckEdit.Properties.Caption = "Sequence"
        Me.SequenceCheckEdit.Size = New System.Drawing.Size(76, 19)
        Me.SequenceCheckEdit.TabIndex = 13
        '
        'SublimationCheckEdit
        '
        Me.SublimationCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsSublimation", True))
        Me.SublimationCheckEdit.Location = New System.Drawing.Point(886, 101)
        Me.SublimationCheckEdit.Name = "SublimationCheckEdit"
        Me.SublimationCheckEdit.Properties.Caption = "Sublimation"
        Me.SublimationCheckEdit.Size = New System.Drawing.Size(76, 19)
        Me.SublimationCheckEdit.TabIndex = 13
        '
        'IsPrintCheckEdit
        '
        Me.IsPrintCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsPrint", True))
        Me.IsPrintCheckEdit.Location = New System.Drawing.Point(887, 51)
        Me.IsPrintCheckEdit.Name = "IsPrintCheckEdit"
        Me.IsPrintCheckEdit.Properties.Caption = "Print "
        Me.IsPrintCheckEdit.Size = New System.Drawing.Size(76, 19)
        Me.IsPrintCheckEdit.TabIndex = 13
        '
        'StyleReferenceNoTextEdit
        '
        Me.StyleReferenceNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "StyleReferenceNo", True))
        Me.StyleReferenceNoTextEdit.Location = New System.Drawing.Point(135, 173)
        Me.StyleReferenceNoTextEdit.Name = "StyleReferenceNoTextEdit"
        Me.StyleReferenceNoTextEdit.Size = New System.Drawing.Size(131, 20)
        Me.StyleReferenceNoTextEdit.TabIndex = 9
        '
        'UserIdComboBox
        '
        Me.UserIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "UserId", True))
        Me.UserIdComboBox.FormattingEnabled = True
        Me.UserIdComboBox.Location = New System.Drawing.Point(135, 593)
        Me.UserIdComboBox.Name = "UserIdComboBox"
        Me.UserIdComboBox.Size = New System.Drawing.Size(121, 21)
        Me.UserIdComboBox.TabIndex = 39
        '
        'ModifiedDateDateEdit
        '
        Me.ModifiedDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "ModifiedDate", True))
        Me.ModifiedDateDateEdit.EditValue = Nothing
        Me.ModifiedDateDateEdit.Location = New System.Drawing.Point(135, 617)
        Me.ModifiedDateDateEdit.Name = "ModifiedDateDateEdit"
        Me.ModifiedDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ModifiedDateDateEdit.Size = New System.Drawing.Size(121, 20)
        Me.ModifiedDateDateEdit.TabIndex = 41
        '
        'IsMultiPartCheckEdit
        '
        Me.IsMultiPartCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsMultiPart", True))
        Me.IsMultiPartCheckEdit.Location = New System.Drawing.Point(135, 643)
        Me.IsMultiPartCheckEdit.Name = "IsMultiPartCheckEdit"
        Me.IsMultiPartCheckEdit.Properties.Caption = "CheckEdit1"
        Me.IsMultiPartCheckEdit.Size = New System.Drawing.Size(121, 19)
        Me.IsMultiPartCheckEdit.TabIndex = 43
        '
        'AdvOrderIdSpinEdit
        '
        Me.AdvOrderIdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "AdvOrderId", True))
        Me.AdvOrderIdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AdvOrderIdSpinEdit.Location = New System.Drawing.Point(135, 693)
        Me.AdvOrderIdSpinEdit.Name = "AdvOrderIdSpinEdit"
        Me.AdvOrderIdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AdvOrderIdSpinEdit.Size = New System.Drawing.Size(121, 20)
        Me.AdvOrderIdSpinEdit.TabIndex = 47
        '
        'StyleNameIdSpinEdit
        '
        Me.StyleNameIdSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "StyleNameId", True))
        Me.StyleNameIdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.StyleNameIdSpinEdit.Location = New System.Drawing.Point(135, 719)
        Me.StyleNameIdSpinEdit.Name = "StyleNameIdSpinEdit"
        Me.StyleNameIdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.StyleNameIdSpinEdit.Size = New System.Drawing.Size(121, 20)
        Me.StyleNameIdSpinEdit.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 13)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Apprv. Sample Req. No."
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.OrderDetailsGridControl)
        Me.SplitContainerControl2.Panel1.Text = "DetailsPanel"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl2.Panel2.Text = "Size Panel"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1370, 384)
        Me.SplitContainerControl2.SplitterPosition = 158
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'OrderDetailsGridControl
        '
        Me.OrderDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderDetailsGridControl.DataSource = Me.OrderDetailsBindingSource
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.OrderDetailsGridControl.Location = New System.Drawing.Point(0, 3)
        Me.OrderDetailsGridControl.MainView = Me.OrderDetailsGridView
        Me.OrderDetailsGridControl.Name = "OrderDetailsGridControl"
        Me.OrderDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GarmentsColorGridLookUpEdit, Me.ETADateEdit, Me.EXGridLookUpEdit1, Me.EXDateEdit, Me.PackTypeComboBox, Me.DestinationGridLookUpEdit, Me.OrDetailsStyleIdGridLookUpEdit, Me.ActivitiesGroupGridLookUpEdit, Me.GenerateItemHyperLinkEdit, Me.ShipmentByComboBox})
        Me.OrderDetailsGridControl.Size = New System.Drawing.Size(1365, 155)
        Me.OrderDetailsGridControl.TabIndex = 0
        Me.OrderDetailsGridControl.UseEmbeddedNavigator = True
        Me.OrderDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.OrderDetailsGridView, Me.GridView2})
        '
        'OrderDetailsBindingSource
        '
        Me.OrderDetailsBindingSource.DataMember = "FK_OrderDetails_Order"
        Me.OrderDetailsBindingSource.DataSource = Me.OrderBindingSource
        '
        'OrderDetailsGridView
        '
        Me.OrderDetailsGridView.ColumnPanelRowHeight = 40
        Me.OrderDetailsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorId, Me.colPrice, Me.colPayBy, Me.colPO_Type, Me.colRemarks, Me.colPackType, Me.colDestinationId, Me.colOrderQuantity, Me.colCode, Me.colEX, Me.colPO, Me.colReference, Me.colStyleId, Me.colPOGroup, Me.colActivitiesGroupId, Me.GenerateActivitiesGridColumn, Me.colColorSL, Me.colRFIDate, Me.colTTLAmount, Me.colETA, Me.colETD, Me.colA_S, Me.colFirstEx, Me.colClosedOn, Me.colDiscontinue, Me.colCasuseOfDiscontinue, Me.colIsHold, Me.colHoldOn})
        Me.OrderDetailsGridView.CustomizationFormBounds = New System.Drawing.Rectangle(794, 34, 216, 318)
        Me.OrderDetailsGridView.GridControl = Me.OrderDetailsGridControl
        Me.OrderDetailsGridView.Name = "OrderDetailsGridView"
        Me.OrderDetailsGridView.OptionsDetail.AllowZoomDetail = False
        Me.OrderDetailsGridView.OptionsDetail.EnableMasterViewMode = False
        Me.OrderDetailsGridView.OptionsDetail.ShowDetailTabs = False
        Me.OrderDetailsGridView.OptionsDetail.SmartDetailExpand = False
        Me.OrderDetailsGridView.OptionsView.ColumnAutoWidth = False
        Me.OrderDetailsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.OrderDetailsGridView.OptionsView.ShowDetailButtons = False
        Me.OrderDetailsGridView.OptionsView.ShowFooter = True
        Me.OrderDetailsGridView.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorId
        '
        Me.colFabricColorId.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colFabricColorId.AppearanceCell.Options.UseBackColor = True
        Me.colFabricColorId.Caption = "Garments Color [F11]"
        Me.colFabricColorId.ColumnEdit = Me.GarmentsColorGridLookUpEdit
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 4
        Me.colFabricColorId.Width = 142
        '
        'GarmentsColorGridLookUpEdit
        '
        Me.GarmentsColorGridLookUpEdit.AutoHeight = False
        Me.GarmentsColorGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GarmentsColorGridLookUpEdit.DataSource = Me.FabricColorBindingSource
        Me.GarmentsColorGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.GarmentsColorGridLookUpEdit.ImmediatePopup = True
        Me.GarmentsColorGridLookUpEdit.Name = "GarmentsColorGridLookUpEdit"
        Me.GarmentsColorGridLookUpEdit.NullText = ""
        Me.GarmentsColorGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.GarmentsColorGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GarmentsColorGridLookUpEdit.ValueMember = "FabricColorId"
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        '
        'colPrice
        '
        Me.colPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPrice.Caption = "Price FOB ($)"
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average)})
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 7
        Me.colPrice.Width = 47
        '
        'colPayBy
        '
        Me.colPayBy.FieldName = "PayBy"
        Me.colPayBy.Name = "colPayBy"
        Me.colPayBy.Width = 69
        '
        'colPO_Type
        '
        Me.colPO_Type.FieldName = "PO_Type"
        Me.colPO_Type.Name = "colPO_Type"
        Me.colPO_Type.Width = 60
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 17
        Me.colRemarks.Width = 79
        '
        'colPackType
        '
        Me.colPackType.AppearanceHeader.Options.UseTextOptions = True
        Me.colPackType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPackType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPackType.ColumnEdit = Me.PackTypeComboBox
        Me.colPackType.FieldName = "PackType"
        Me.colPackType.Name = "colPackType"
        Me.colPackType.Visible = True
        Me.colPackType.VisibleIndex = 2
        Me.colPackType.Width = 51
        '
        'PackTypeComboBox
        '
        Me.PackTypeComboBox.AutoHeight = False
        Me.PackTypeComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PackTypeComboBox.Items.AddRange(New Object() {"-", "Normal", "Ratio", "Solid Color Solid Size", "Solid Color Assort Size", "Assort Color Solid Size", "Assort Color Assort Size", "Store Wise"})
        Me.PackTypeComboBox.Name = "PackTypeComboBox"
        '
        'colDestinationId
        '
        Me.colDestinationId.Caption = "Destination"
        Me.colDestinationId.ColumnEdit = Me.DestinationGridLookUpEdit
        Me.colDestinationId.FieldName = "DestinationId"
        Me.colDestinationId.Name = "colDestinationId"
        Me.colDestinationId.Visible = True
        Me.colDestinationId.VisibleIndex = 16
        Me.colDestinationId.Width = 74
        '
        'DestinationGridLookUpEdit
        '
        Me.DestinationGridLookUpEdit.AutoHeight = False
        Me.DestinationGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DestinationGridLookUpEdit.DataSource = Me.DestinationBindingSource
        Me.DestinationGridLookUpEdit.DisplayMember = "DestinationCode"
        Me.DestinationGridLookUpEdit.Name = "DestinationGridLookUpEdit"
        Me.DestinationGridLookUpEdit.NullText = ""
        Me.DestinationGridLookUpEdit.PopupView = Me.GridView11
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
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDestinationCode})
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'colDestinationCode
        '
        Me.colDestinationCode.FieldName = "DestinationCode"
        Me.colDestinationCode.Name = "colDestinationCode"
        Me.colDestinationCode.Visible = True
        Me.colDestinationCode.VisibleIndex = 0
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colOrderQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colOrderQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQuantity", "{0:n0}")})
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 8
        Me.colOrderQuantity.Width = 67
        '
        'colCode
        '
        Me.colCode.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colCode.AppearanceCell.Options.UseBackColor = True
        Me.colCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCode.Caption = "Color Code"
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 5
        Me.colCode.Width = 46
        '
        'colEX
        '
        Me.colEX.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colEX.AppearanceCell.Options.UseBackColor = True
        Me.colEX.AppearanceHeader.Options.UseTextOptions = True
        Me.colEX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEX.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEX.Caption = "EX (Factory)"
        Me.colEX.ColumnEdit = Me.EXDateEdit
        Me.colEX.FieldName = "EX"
        Me.colEX.Name = "colEX"
        Me.colEX.Visible = True
        Me.colEX.VisibleIndex = 11
        Me.colEX.Width = 70
        '
        'EXDateEdit
        '
        Me.EXDateEdit.AutoHeight = False
        Me.EXDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EXDateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EXDateEdit.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.EXDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.EXDateEdit.EditFormat.FormatString = "dd-MMM-yy"
        Me.EXDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.EXDateEdit.Mask.EditMask = "dd-MMM-yy"
        Me.EXDateEdit.Name = "EXDateEdit"
        '
        'colPO
        '
        Me.colPO.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colPO.AppearanceCell.Options.UseBackColor = True
        Me.colPO.FieldName = "PO"
        Me.colPO.Name = "colPO"
        Me.colPO.Visible = True
        Me.colPO.VisibleIndex = 1
        Me.colPO.Width = 127
        '
        'colReference
        '
        Me.colReference.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colReference.AppearanceCell.Options.UseBackColor = True
        Me.colReference.Caption = "Color Reference/LD"
        Me.colReference.FieldName = "Reference"
        Me.colReference.Name = "colReference"
        Me.colReference.Visible = True
        Me.colReference.VisibleIndex = 6
        Me.colReference.Width = 105
        '
        'colStyleId
        '
        Me.colStyleId.Caption = "Style No [F11]"
        Me.colStyleId.ColumnEdit = Me.OrDetailsStyleIdGridLookUpEdit
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        Me.colStyleId.Visible = True
        Me.colStyleId.VisibleIndex = 0
        Me.colStyleId.Width = 126
        '
        'OrDetailsStyleIdGridLookUpEdit
        '
        Me.OrDetailsStyleIdGridLookUpEdit.AutoHeight = False
        Me.OrDetailsStyleIdGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrDetailsStyleIdGridLookUpEdit.DataSource = Me.StyleLookupBindingSource
        Me.OrDetailsStyleIdGridLookUpEdit.DisplayMember = "StyleName"
        Me.OrDetailsStyleIdGridLookUpEdit.Name = "OrDetailsStyleIdGridLookUpEdit"
        Me.OrDetailsStyleIdGridLookUpEdit.NullText = ""
        Me.OrDetailsStyleIdGridLookUpEdit.PopupView = Me.GridView12
        Me.OrDetailsStyleIdGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrDetailsStyleIdGridLookUpEdit.ValueMember = "StyleId"
        '
        'GridView12
        '
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleName2})
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        '
        'colStyleName2
        '
        Me.colStyleName2.Caption = "Style No"
        Me.colStyleName2.FieldName = "StyleName"
        Me.colStyleName2.Name = "colStyleName2"
        Me.colStyleName2.Visible = True
        Me.colStyleName2.VisibleIndex = 0
        '
        'colPOGroup
        '
        Me.colPOGroup.FieldName = "POGroup"
        Me.colPOGroup.Name = "colPOGroup"
        Me.colPOGroup.Width = 140
        '
        'colActivitiesGroupId
        '
        Me.colActivitiesGroupId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colActivitiesGroupId.AppearanceCell.Options.UseBackColor = True
        Me.colActivitiesGroupId.Caption = "Activities"
        Me.colActivitiesGroupId.ColumnEdit = Me.ActivitiesGroupGridLookUpEdit
        Me.colActivitiesGroupId.FieldName = "ActivitiesGroupId"
        Me.colActivitiesGroupId.Name = "colActivitiesGroupId"
        Me.colActivitiesGroupId.Width = 200
        '
        'ActivitiesGroupGridLookUpEdit
        '
        Me.ActivitiesGroupGridLookUpEdit.AutoHeight = False
        Me.ActivitiesGroupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActivitiesGroupGridLookUpEdit.DataSource = Me.ActivitiesGroupBindingSource
        Me.ActivitiesGroupGridLookUpEdit.DisplayMember = "ActivitiesGroup"
        Me.ActivitiesGroupGridLookUpEdit.Name = "ActivitiesGroupGridLookUpEdit"
        Me.ActivitiesGroupGridLookUpEdit.NullText = ""
        Me.ActivitiesGroupGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ActivitiesGroupGridLookUpEdit.PopupView = Me.GridView18
        Me.ActivitiesGroupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ActivitiesGroupGridLookUpEdit.ValueMember = "ActivitiesGroupId"
        '
        'GridView18
        '
        Me.GridView18.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesGroup})
        Me.GridView18.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView18.Name = "GridView18"
        Me.GridView18.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView18.OptionsView.ShowGroupPanel = False
        '
        'colActivitiesGroup
        '
        Me.colActivitiesGroup.FieldName = "ActivitiesGroup"
        Me.colActivitiesGroup.Name = "colActivitiesGroup"
        Me.colActivitiesGroup.Visible = True
        Me.colActivitiesGroup.VisibleIndex = 0
        '
        'GenerateActivitiesGridColumn
        '
        Me.GenerateActivitiesGridColumn.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.GenerateActivitiesGridColumn.AppearanceCell.Options.UseTextOptions = True
        Me.GenerateActivitiesGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GenerateActivitiesGridColumn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GenerateActivitiesGridColumn.AppearanceHeader.Options.UseTextOptions = True
        Me.GenerateActivitiesGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GenerateActivitiesGridColumn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GenerateActivitiesGridColumn.Caption = "Generate Activities"
        Me.GenerateActivitiesGridColumn.ColumnEdit = Me.GenerateItemHyperLinkEdit
        Me.GenerateActivitiesGridColumn.FieldName = "WrokingDay"
        Me.GenerateActivitiesGridColumn.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.GenerateActivitiesGridColumn.Name = "GenerateActivitiesGridColumn"
        '
        'GenerateItemHyperLinkEdit
        '
        Me.GenerateItemHyperLinkEdit.AutoHeight = False
        Me.GenerateItemHyperLinkEdit.Caption = "Generate"
        Me.GenerateItemHyperLinkEdit.Name = "GenerateItemHyperLinkEdit"
        '
        'colColorSL
        '
        Me.colColorSL.AppearanceHeader.Options.UseTextOptions = True
        Me.colColorSL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colColorSL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colColorSL.FieldName = "ColorSL"
        Me.colColorSL.Name = "colColorSL"
        Me.colColorSL.Visible = True
        Me.colColorSL.VisibleIndex = 3
        Me.colColorSL.Width = 40
        '
        'colRFIDate
        '
        Me.colRFIDate.FieldName = "RFIDate"
        Me.colRFIDate.Name = "colRFIDate"
        Me.colRFIDate.Visible = True
        Me.colRFIDate.VisibleIndex = 10
        '
        'colTTLAmount
        '
        Me.colTTLAmount.Caption = "Total Value ($)"
        Me.colTTLAmount.DisplayFormat.FormatString = "c3"
        Me.colTTLAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTTLAmount.FieldName = "TTLAmount"
        Me.colTTLAmount.Name = "colTTLAmount"
        Me.colTTLAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TTLAmount", "{0:c3}")})
        Me.colTTLAmount.Visible = True
        Me.colTTLAmount.VisibleIndex = 9
        Me.colTTLAmount.Width = 91
        '
        'colETA
        '
        Me.colETA.AppearanceHeader.Options.UseTextOptions = True
        Me.colETA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colETA.Caption = "ETA"
        Me.colETA.FieldName = "ETA"
        Me.colETA.Name = "colETA"
        Me.colETA.Visible = True
        Me.colETA.VisibleIndex = 14
        '
        'colETD
        '
        Me.colETD.AppearanceHeader.Options.UseTextOptions = True
        Me.colETD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colETD.FieldName = "ETD"
        Me.colETD.Name = "colETD"
        Me.colETD.Visible = True
        Me.colETD.VisibleIndex = 13
        '
        'colA_S
        '
        Me.colA_S.AppearanceHeader.Options.UseTextOptions = True
        Me.colA_S.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colA_S.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colA_S.Caption = "Mode Of Shipment"
        Me.colA_S.ColumnEdit = Me.ShipmentByComboBox
        Me.colA_S.FieldName = "A_S"
        Me.colA_S.Name = "colA_S"
        Me.colA_S.Visible = True
        Me.colA_S.VisibleIndex = 15
        '
        'ShipmentByComboBox
        '
        Me.ShipmentByComboBox.AutoHeight = False
        Me.ShipmentByComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShipmentByComboBox.Items.AddRange(New Object() {"Sea", "Air", "Sea_Air"})
        Me.ShipmentByComboBox.Name = "ShipmentByComboBox"
        '
        'colFirstEx
        '
        Me.colFirstEx.FieldName = "FirstEx"
        Me.colFirstEx.Name = "colFirstEx"
        Me.colFirstEx.Visible = True
        Me.colFirstEx.VisibleIndex = 12
        '
        'colClosedOn
        '
        Me.colClosedOn.FieldName = "ClosedOn"
        Me.colClosedOn.Name = "colClosedOn"
        '
        'colDiscontinue
        '
        Me.colDiscontinue.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiscontinue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiscontinue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiscontinue.Caption = "Cancel"
        Me.colDiscontinue.FieldName = "Discontinue"
        Me.colDiscontinue.Name = "colDiscontinue"
        Me.colDiscontinue.OptionsColumn.AllowEdit = False
        Me.colDiscontinue.Visible = True
        Me.colDiscontinue.VisibleIndex = 18
        '
        'colCasuseOfDiscontinue
        '
        Me.colCasuseOfDiscontinue.AppearanceHeader.Options.UseTextOptions = True
        Me.colCasuseOfDiscontinue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCasuseOfDiscontinue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCasuseOfDiscontinue.Caption = "Causes of Cancel"
        Me.colCasuseOfDiscontinue.FieldName = "CasuseOfDiscontinue"
        Me.colCasuseOfDiscontinue.Name = "colCasuseOfDiscontinue"
        Me.colCasuseOfDiscontinue.OptionsColumn.AllowEdit = False
        Me.colCasuseOfDiscontinue.Visible = True
        Me.colCasuseOfDiscontinue.VisibleIndex = 19
        '
        'colIsHold
        '
        Me.colIsHold.FieldName = "IsHold"
        Me.colIsHold.Name = "colIsHold"
        Me.colIsHold.Visible = True
        Me.colIsHold.VisibleIndex = 20
        '
        'colHoldOn
        '
        Me.colHoldOn.FieldName = "HoldOn"
        Me.colHoldOn.Name = "colHoldOn"
        Me.colHoldOn.Visible = True
        Me.colHoldOn.VisibleIndex = 21
        '
        'ETADateEdit
        '
        Me.ETADateEdit.AutoHeight = False
        Me.ETADateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ETADateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ETADateEdit.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.ETADateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ETADateEdit.EditFormat.FormatString = "dd-MMM-yy"
        Me.ETADateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.ETADateEdit.Mask.EditMask = "dd-MMM-yy"
        Me.ETADateEdit.Name = "ETADateEdit"
        '
        'EXGridLookUpEdit1
        '
        Me.EXGridLookUpEdit1.AutoHeight = False
        Me.EXGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EXGridLookUpEdit1.Name = "EXGridLookUpEdit1"
        Me.EXGridLookUpEdit1.PopupView = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.OrderDetailsGridControl
        Me.GridView2.Name = "GridView2"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.SizeAndInstructionXtraTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(1370, 221)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.SizeAndInstructionXtraTabPage, Me.CuttingPercentageXtraTabPage, Me.FabricXtraTabPage, Me.MultipartXtraTabPage, Me.PrintDetailsXtraTabPage, Me.AmndHistory, Me.OrderProcessXtraTabPage, Me.ActivitiesXtraTabPage, Me.OrderPictureXtraTabPage})
        '
        'SizeAndInstructionXtraTabPage
        '
        Me.SizeAndInstructionXtraTabPage.AutoScroll = True
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.Paste2Button)
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.CalculateRatioButton)
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.PasteButton)
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.CopyButton)
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.OrderInstructionGridControl)
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.OrderSizeDetailsGridControl)
        Me.SizeAndInstructionXtraTabPage.Name = "SizeAndInstructionXtraTabPage"
        Me.SizeAndInstructionXtraTabPage.Size = New System.Drawing.Size(1364, 193)
        Me.SizeAndInstructionXtraTabPage.Text = "Size And Instruction"
        '
        'Paste2Button
        '
        Me.Paste2Button.Location = New System.Drawing.Point(364, 57)
        Me.Paste2Button.Name = "Paste2Button"
        Me.Paste2Button.Size = New System.Drawing.Size(147, 26)
        Me.Paste2Button.TabIndex = 5
        Me.Paste2Button.Text = "&Get Size from Pre Order"
        '
        'CalculateRatioButton
        '
        Me.CalculateRatioButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CalculateRatioButton.Location = New System.Drawing.Point(364, 167)
        Me.CalculateRatioButton.Name = "CalculateRatioButton"
        Me.CalculateRatioButton.Size = New System.Drawing.Size(147, 25)
        Me.CalculateRatioButton.TabIndex = 4
        Me.CalculateRatioButton.Text = "Calculate By Ratio"
        '
        'PasteButton
        '
        Me.PasteButton.Location = New System.Drawing.Point(364, 30)
        Me.PasteButton.Name = "PasteButton"
        Me.PasteButton.Size = New System.Drawing.Size(147, 24)
        Me.PasteButton.TabIndex = 3
        Me.PasteButton.Text = "&Paste Size To PO"
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(364, 3)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(147, 24)
        Me.CopyButton.TabIndex = 2
        Me.CopyButton.Text = "&Copy Size From PO"
        '
        'OrderInstructionGridControl
        '
        Me.OrderInstructionGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderInstructionGridControl.DataSource = Me.OrderInstructionBindingSource
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.OrderInstructionGridControl.Location = New System.Drawing.Point(517, 3)
        Me.OrderInstructionGridControl.MainView = Me.GridView4
        Me.OrderInstructionGridControl.Name = "OrderInstructionGridControl"
        Me.OrderInstructionGridControl.Size = New System.Drawing.Size(844, 178)
        Me.OrderInstructionGridControl.TabIndex = 1
        Me.OrderInstructionGridControl.UseEmbeddedNavigator = True
        Me.OrderInstructionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'OrderInstructionBindingSource
        '
        Me.OrderInstructionBindingSource.DataMember = "FK_OrderInstruction_Order"
        Me.OrderInstructionBindingSource.DataSource = Me.OrderBindingSource
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderInstructionId, Me.colOrderId, Me.colInstructionSlNo, Me.colInstruction, Me.colInstructionDate, Me.colUserId, Me.colModifiedDate})
        Me.GridView4.GridControl = Me.OrderInstructionGridControl
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colInstructionSlNo, DevExpress.Data.ColumnSortOrder.Ascending)})
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
        'colInstructionSlNo
        '
        Me.colInstructionSlNo.Caption = "SL No"
        Me.colInstructionSlNo.FieldName = "InstructionSlNo"
        Me.colInstructionSlNo.Name = "colInstructionSlNo"
        Me.colInstructionSlNo.Visible = True
        Me.colInstructionSlNo.VisibleIndex = 0
        Me.colInstructionSlNo.Width = 86
        '
        'colInstruction
        '
        Me.colInstruction.FieldName = "Instruction"
        Me.colInstruction.Name = "colInstruction"
        Me.colInstruction.Visible = True
        Me.colInstruction.VisibleIndex = 1
        Me.colInstruction.Width = 498
        '
        'colInstructionDate
        '
        Me.colInstructionDate.FieldName = "InstructionDate"
        Me.colInstructionDate.Name = "colInstructionDate"
        Me.colInstructionDate.Visible = True
        Me.colInstructionDate.VisibleIndex = 2
        Me.colInstructionDate.Width = 154
        '
        'colUserId
        '
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        Me.colUserId.Width = 105
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        Me.colModifiedDate.Width = 113
        '
        'OrderSizeDetailsGridControl
        '
        Me.OrderSizeDetailsGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OrderSizeDetailsGridControl.DataSource = Me.OrderSizeDetailsBindingSource
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.OrderSizeDetailsGridControl.Location = New System.Drawing.Point(3, 3)
        Me.OrderSizeDetailsGridControl.MainView = Me.GridView3
        Me.OrderSizeDetailsGridControl.Name = "OrderSizeDetailsGridControl"
        Me.OrderSizeDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeGridLookUpEdit})
        Me.OrderSizeDetailsGridControl.Size = New System.Drawing.Size(355, 178)
        Me.OrderSizeDetailsGridControl.TabIndex = 0
        Me.OrderSizeDetailsGridControl.UseEmbeddedNavigator = True
        Me.OrderSizeDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'OrderSizeDetailsBindingSource
        '
        Me.OrderSizeDetailsBindingSource.DataMember = "FK_OrderSizeDetails_OrderDetails"
        Me.OrderSizeDetailsBindingSource.DataSource = Me.OrderDetailsBindingSource
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeId, Me.colOrderQuantity1, Me.colRatio, Me.colSKUNo})
        Me.GridView3.GridControl = Me.OrderSizeDetailsGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colSizeId
        '
        Me.colSizeId.Caption = "Size"
        Me.colSizeId.ColumnEdit = Me.SizeGridLookUpEdit
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        Me.colSizeId.Visible = True
        Me.colSizeId.VisibleIndex = 0
        Me.colSizeId.Width = 83
        '
        'SizeGridLookUpEdit
        '
        Me.SizeGridLookUpEdit.AutoHeight = False
        Me.SizeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeGridLookUpEdit.DataSource = Me.SizeBindingSource
        Me.SizeGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeGridLookUpEdit.ImmediatePopup = True
        Me.SizeGridLookUpEdit.Name = "SizeGridLookUpEdit"
        Me.SizeGridLookUpEdit.NullText = ""
        Me.SizeGridLookUpEdit.PopupView = Me.GridView6
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
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'colOrderQuantity1
        '
        Me.colOrderQuantity1.FieldName = "OrderQuantity"
        Me.colOrderQuantity1.Name = "colOrderQuantity1"
        Me.colOrderQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colOrderQuantity1.Visible = True
        Me.colOrderQuantity1.VisibleIndex = 1
        Me.colOrderQuantity1.Width = 107
        '
        'colRatio
        '
        Me.colRatio.FieldName = "Ratio"
        Me.colRatio.Name = "colRatio"
        Me.colRatio.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colRatio.Visible = True
        Me.colRatio.VisibleIndex = 2
        Me.colRatio.Width = 46
        '
        'colSKUNo
        '
        Me.colSKUNo.FieldName = "SKUNo"
        Me.colSKUNo.Name = "colSKUNo"
        Me.colSKUNo.Width = 98
        '
        'CuttingPercentageXtraTabPage
        '
        Me.CuttingPercentageXtraTabPage.Controls.Add(Me.GetColorListButton)
        Me.CuttingPercentageXtraTabPage.Controls.Add(CuttingWPLabel)
        Me.CuttingPercentageXtraTabPage.Controls.Add(Me.OrderCuttingPercentageGridControl)
        Me.CuttingPercentageXtraTabPage.Controls.Add(Me.CuttingWPSpinEdit)
        Me.CuttingPercentageXtraTabPage.Name = "CuttingPercentageXtraTabPage"
        Me.CuttingPercentageXtraTabPage.Size = New System.Drawing.Size(1364, 193)
        Me.CuttingPercentageXtraTabPage.Text = "Cutting Percentage"
        '
        'GetColorListButton
        '
        Me.GetColorListButton.Location = New System.Drawing.Point(791, 50)
        Me.GetColorListButton.Name = "GetColorListButton"
        Me.GetColorListButton.Size = New System.Drawing.Size(122, 35)
        Me.GetColorListButton.TabIndex = 74
        Me.GetColorListButton.Text = "Get Color List"
        Me.GetColorListButton.UseVisualStyleBackColor = True
        '
        'OrderCuttingPercentageGridControl
        '
        Me.OrderCuttingPercentageGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OrderCuttingPercentageGridControl.DataSource = Me.OrderCuttingPercentageBindingSource
        Me.OrderCuttingPercentageGridControl.Location = New System.Drawing.Point(2, 3)
        Me.OrderCuttingPercentageGridControl.MainView = Me.GridView24
        Me.OrderCuttingPercentageGridControl.Name = "OrderCuttingPercentageGridControl"
        Me.OrderCuttingPercentageGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.FabricColorCPGridLookUpEdit})
        Me.OrderCuttingPercentageGridControl.Size = New System.Drawing.Size(754, 190)
        Me.OrderCuttingPercentageGridControl.TabIndex = 73
        Me.OrderCuttingPercentageGridControl.UseEmbeddedNavigator = True
        Me.OrderCuttingPercentageGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView24})
        '
        'OrderCuttingPercentageBindingSource
        '
        Me.OrderCuttingPercentageBindingSource.DataMember = "Order_OrderCuttingPercentage"
        Me.OrderCuttingPercentageBindingSource.DataSource = Me.OrderBindingSource
        '
        'GridView24
        '
        Me.GridView24.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorId2, Me.colCuttingPercentage, Me.colPrinting, Me.colEmbroidery, Me.colWashing, Me.colSewing, Me.colFinishing})
        Me.GridView24.GridControl = Me.OrderCuttingPercentageGridControl
        Me.GridView24.Name = "GridView24"
        Me.GridView24.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorId2
        '
        Me.colFabricColorId2.Caption = "Fabric Color"
        Me.colFabricColorId2.ColumnEdit = Me.FabricColorCPGridLookUpEdit
        Me.colFabricColorId2.FieldName = "FabricColorId"
        Me.colFabricColorId2.Name = "colFabricColorId2"
        Me.colFabricColorId2.Visible = True
        Me.colFabricColorId2.VisibleIndex = 0
        Me.colFabricColorId2.Width = 186
        '
        'FabricColorCPGridLookUpEdit
        '
        Me.FabricColorCPGridLookUpEdit.AutoHeight = False
        Me.FabricColorCPGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricColorCPGridLookUpEdit.DataSource = Me.FabricColorBindingSource
        Me.FabricColorCPGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.FabricColorCPGridLookUpEdit.Name = "FabricColorCPGridLookUpEdit"
        Me.FabricColorCPGridLookUpEdit.NullText = ""
        Me.FabricColorCPGridLookUpEdit.PopupView = Me.GridView25
        Me.FabricColorCPGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricColorCPGridLookUpEdit.ValueMember = "FabricColorId"
        '
        'GridView25
        '
        Me.GridView25.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView25.Name = "GridView25"
        Me.GridView25.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView25.OptionsView.ShowGroupPanel = False
        '
        'colCuttingPercentage
        '
        Me.colCuttingPercentage.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colCuttingPercentage.AppearanceCell.Options.UseBackColor = True
        Me.colCuttingPercentage.FieldName = "CuttingPercentage"
        Me.colCuttingPercentage.Name = "colCuttingPercentage"
        Me.colCuttingPercentage.Visible = True
        Me.colCuttingPercentage.VisibleIndex = 1
        Me.colCuttingPercentage.Width = 160
        '
        'colPrinting
        '
        Me.colPrinting.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPrinting.AppearanceCell.Options.UseBackColor = True
        Me.colPrinting.FieldName = "Printing"
        Me.colPrinting.Name = "colPrinting"
        Me.colPrinting.Visible = True
        Me.colPrinting.VisibleIndex = 2
        Me.colPrinting.Width = 160
        '
        'colEmbroidery
        '
        Me.colEmbroidery.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colEmbroidery.AppearanceCell.Options.UseBackColor = True
        Me.colEmbroidery.FieldName = "Embroidery"
        Me.colEmbroidery.Name = "colEmbroidery"
        Me.colEmbroidery.Visible = True
        Me.colEmbroidery.VisibleIndex = 3
        Me.colEmbroidery.Width = 160
        '
        'colWashing
        '
        Me.colWashing.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colWashing.AppearanceCell.Options.UseBackColor = True
        Me.colWashing.FieldName = "Washing"
        Me.colWashing.Name = "colWashing"
        Me.colWashing.Visible = True
        Me.colWashing.VisibleIndex = 4
        Me.colWashing.Width = 160
        '
        'colSewing
        '
        Me.colSewing.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSewing.AppearanceCell.Options.UseBackColor = True
        Me.colSewing.FieldName = "Sewing"
        Me.colSewing.Name = "colSewing"
        Me.colSewing.Visible = True
        Me.colSewing.VisibleIndex = 5
        Me.colSewing.Width = 160
        '
        'colFinishing
        '
        Me.colFinishing.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFinishing.AppearanceCell.Options.UseBackColor = True
        Me.colFinishing.FieldName = "Finishing"
        Me.colFinishing.Name = "colFinishing"
        Me.colFinishing.Visible = True
        Me.colFinishing.VisibleIndex = 6
        Me.colFinishing.Width = 171
        '
        'CuttingWPSpinEdit
        '
        Me.CuttingWPSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "CuttingWP", True))
        Me.CuttingWPSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CuttingWPSpinEdit.Location = New System.Drawing.Point(845, 24)
        Me.CuttingWPSpinEdit.Name = "CuttingWPSpinEdit"
        Me.CuttingWPSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CuttingWPSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.CuttingWPSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CuttingWPSpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.CuttingWPSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CuttingWPSpinEdit.Size = New System.Drawing.Size(68, 20)
        Me.CuttingWPSpinEdit.TabIndex = 76
        '
        'FabricXtraTabPage
        '
        Me.FabricXtraTabPage.AutoScroll = True
        Me.FabricXtraTabPage.Controls.Add(Me.FabricGridControl)
        Me.FabricXtraTabPage.Name = "FabricXtraTabPage"
        Me.FabricXtraTabPage.Size = New System.Drawing.Size(1364, 193)
        Me.FabricXtraTabPage.Text = "Fabric"
        '
        'FabricGridControl
        '
        Me.FabricGridControl.DataSource = Me.FabricBindingSource
        Me.FabricGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FabricGridControl.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.FabricGridControl.Location = New System.Drawing.Point(0, 0)
        Me.FabricGridControl.MainView = Me.BandedGridView1
        Me.FabricGridControl.Name = "FabricGridControl"
        Me.FabricGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.DyeingTypeGridLookUpEdit, Me.FabricTypeGridLookUpEdit, Me.DiaTypeComboBox, Me.DiaUnitComboBox, Me.FinishUnitComboBox, Me.CompositionGridLookUpEdit, Me.GarmentsPartGridLookUpEdit, Me.GSMGridLookUpEdit})
        Me.FabricGridControl.Size = New System.Drawing.Size(1364, 193)
        Me.FabricGridControl.TabIndex = 0
        Me.FabricGridControl.UseEmbeddedNavigator = True
        Me.FabricGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'FabricBindingSource
        '
        Me.FabricBindingSource.DataMember = "Order_Fabric"
        Me.FabricBindingSource.DataSource = Me.OrderBindingSource
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand2, Me.GridBand3, Me.GridBand1})
        Me.BandedGridView1.ColumnPanelRowHeight = 40
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colDyeingTypeId, Me.colIsAllOverPrint, Me.colRemarks1, Me.colKnittingTypeId, Me.colFinishFabricDia, Me.colDiaType, Me.colMarkerLengthYrds, Me.colMarkerLengthInch, Me.colMarkerWidth, Me.colLengthAllowance, Me.colWidthAllowance, Me.colWastagePercentage, Me.colGMQuantity, Me.colDiaUnit, Me.colFinishUnit, Me.colCompositionId, Me.colSPNote, Me.colGarmentsPartId, Me.colGSMId})
        Me.BandedGridView1.GridControl = Me.FabricGridControl
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "Fabric Information"
        Me.gridBand2.Columns.Add(Me.colGarmentsPartId)
        Me.gridBand2.Columns.Add(Me.colKnittingTypeId)
        Me.gridBand2.Columns.Add(Me.colCompositionId)
        Me.gridBand2.Columns.Add(Me.colGSMId)
        Me.gridBand2.Columns.Add(Me.colFinishFabricDia)
        Me.gridBand2.Columns.Add(Me.colDiaType)
        Me.gridBand2.Columns.Add(Me.colDiaUnit)
        Me.gridBand2.Columns.Add(Me.colFinishUnit)
        Me.gridBand2.Columns.Add(Me.colSPNote)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 0
        Me.gridBand2.Width = 926
        '
        'colGarmentsPartId
        '
        Me.colGarmentsPartId.Caption = "Garments Part"
        Me.colGarmentsPartId.ColumnEdit = Me.GarmentsPartGridLookUpEdit
        Me.colGarmentsPartId.FieldName = "GarmentsPartId"
        Me.colGarmentsPartId.Name = "colGarmentsPartId"
        Me.colGarmentsPartId.Visible = True
        Me.colGarmentsPartId.Width = 106
        '
        'GarmentsPartGridLookUpEdit
        '
        Me.GarmentsPartGridLookUpEdit.AutoHeight = False
        Me.GarmentsPartGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GarmentsPartGridLookUpEdit.DataSource = Me.GarmentsPartBindingSource
        Me.GarmentsPartGridLookUpEdit.DisplayMember = "Name"
        Me.GarmentsPartGridLookUpEdit.Name = "GarmentsPartGridLookUpEdit"
        Me.GarmentsPartGridLookUpEdit.NullText = ""
        Me.GarmentsPartGridLookUpEdit.PopupView = Me.GridView10
        Me.GarmentsPartGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GarmentsPartGridLookUpEdit.ValueMember = "GarmentsPartId"
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
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colKnittingTypeId
        '
        Me.colKnittingTypeId.AppearanceHeader.Options.UseTextOptions = True
        Me.colKnittingTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKnittingTypeId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colKnittingTypeId.Caption = "Fabric Type"
        Me.colKnittingTypeId.ColumnEdit = Me.FabricTypeGridLookUpEdit
        Me.colKnittingTypeId.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId.Name = "colKnittingTypeId"
        Me.colKnittingTypeId.Visible = True
        Me.colKnittingTypeId.Width = 194
        '
        'FabricTypeGridLookUpEdit
        '
        Me.FabricTypeGridLookUpEdit.AutoHeight = False
        Me.FabricTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricTypeGridLookUpEdit.DataSource = Me.KnittingTypeBindingSource
        Me.FabricTypeGridLookUpEdit.DisplayMember = "KnittingType"
        Me.FabricTypeGridLookUpEdit.ImmediatePopup = True
        Me.FabricTypeGridLookUpEdit.Name = "FabricTypeGridLookUpEdit"
        Me.FabricTypeGridLookUpEdit.PopupView = Me.GridView8
        Me.FabricTypeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricTypeGridLookUpEdit.ValueMember = "KnittingTypeId"
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
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingType})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colKnittingType
        '
        Me.colKnittingType.FieldName = "KnittingType"
        Me.colKnittingType.Name = "colKnittingType"
        Me.colKnittingType.Visible = True
        Me.colKnittingType.VisibleIndex = 0
        '
        'colCompositionId
        '
        Me.colCompositionId.AppearanceHeader.Options.UseTextOptions = True
        Me.colCompositionId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCompositionId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCompositionId.Caption = "Composition"
        Me.colCompositionId.ColumnEdit = Me.CompositionGridLookUpEdit
        Me.colCompositionId.FieldName = "CompositionId"
        Me.colCompositionId.Name = "colCompositionId"
        Me.colCompositionId.Visible = True
        Me.colCompositionId.Width = 195
        '
        'CompositionGridLookUpEdit
        '
        Me.CompositionGridLookUpEdit.AutoHeight = False
        Me.CompositionGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompositionGridLookUpEdit.DataSource = Me.CompositionBindingSource
        Me.CompositionGridLookUpEdit.DisplayMember = "Composition"
        Me.CompositionGridLookUpEdit.ImmediatePopup = True
        Me.CompositionGridLookUpEdit.Name = "CompositionGridLookUpEdit"
        Me.CompositionGridLookUpEdit.NullText = ""
        Me.CompositionGridLookUpEdit.PopupView = Me.GridView9
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
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colComposition})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colComposition
        '
        Me.colComposition.FieldName = "Composition"
        Me.colComposition.Name = "colComposition"
        Me.colComposition.Visible = True
        Me.colComposition.VisibleIndex = 0
        '
        'colGSMId
        '
        Me.colGSMId.Caption = "GSM"
        Me.colGSMId.ColumnEdit = Me.GSMGridLookUpEdit
        Me.colGSMId.FieldName = "GSMId"
        Me.colGSMId.Name = "colGSMId"
        Me.colGSMId.Visible = True
        '
        'GSMGridLookUpEdit
        '
        Me.GSMGridLookUpEdit.AutoHeight = False
        Me.GSMGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GSMGridLookUpEdit.DataSource = Me.GSMBindingSource
        Me.GSMGridLookUpEdit.DisplayMember = "GSM"
        Me.GSMGridLookUpEdit.Name = "GSMGridLookUpEdit"
        Me.GSMGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.GSMGridLookUpEdit.ValueMember = "GSMId"
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
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colFinishFabricDia
        '
        Me.colFinishFabricDia.AppearanceHeader.Options.UseTextOptions = True
        Me.colFinishFabricDia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFinishFabricDia.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFinishFabricDia.FieldName = "FinishFabricDia"
        Me.colFinishFabricDia.Name = "colFinishFabricDia"
        Me.colFinishFabricDia.Visible = True
        Me.colFinishFabricDia.Width = 78
        '
        'colDiaType
        '
        Me.colDiaType.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiaType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiaType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiaType.ColumnEdit = Me.DiaTypeComboBox
        Me.colDiaType.FieldName = "DiaType"
        Me.colDiaType.Name = "colDiaType"
        Me.colDiaType.Visible = True
        Me.colDiaType.Width = 68
        '
        'DiaTypeComboBox
        '
        Me.DiaTypeComboBox.AutoHeight = False
        Me.DiaTypeComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiaTypeComboBox.Items.AddRange(New Object() {"Open", "Tube"})
        Me.DiaTypeComboBox.Name = "DiaTypeComboBox"
        '
        'colDiaUnit
        '
        Me.colDiaUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colDiaUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDiaUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDiaUnit.ColumnEdit = Me.DiaUnitComboBox
        Me.colDiaUnit.FieldName = "DiaUnit"
        Me.colDiaUnit.Name = "colDiaUnit"
        Me.colDiaUnit.Visible = True
        Me.colDiaUnit.Width = 65
        '
        'DiaUnitComboBox
        '
        Me.DiaUnitComboBox.AutoHeight = False
        Me.DiaUnitComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiaUnitComboBox.Items.AddRange(New Object() {"IN", "CM"})
        Me.DiaUnitComboBox.Name = "DiaUnitComboBox"
        '
        'colFinishUnit
        '
        Me.colFinishUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colFinishUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFinishUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFinishUnit.ColumnEdit = Me.FinishUnitComboBox
        Me.colFinishUnit.FieldName = "FinishUnit"
        Me.colFinishUnit.Name = "colFinishUnit"
        Me.colFinishUnit.Visible = True
        Me.colFinishUnit.Width = 60
        '
        'FinishUnitComboBox
        '
        Me.FinishUnitComboBox.AutoHeight = False
        Me.FinishUnitComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishUnitComboBox.Items.AddRange(New Object() {"Kg", "Mtr", "Yds"})
        Me.FinishUnitComboBox.Name = "FinishUnitComboBox"
        '
        'colSPNote
        '
        Me.colSPNote.FieldName = "SPNote"
        Me.colSPNote.Name = "colSPNote"
        Me.colSPNote.Visible = True
        Me.colSPNote.Width = 85
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "Cad Info"
        Me.GridBand3.Columns.Add(Me.colMarkerLengthYrds)
        Me.GridBand3.Columns.Add(Me.colMarkerLengthInch)
        Me.GridBand3.Columns.Add(Me.colMarkerWidth)
        Me.GridBand3.Columns.Add(Me.colWidthAllowance)
        Me.GridBand3.Columns.Add(Me.colLengthAllowance)
        Me.GridBand3.Columns.Add(Me.colWastagePercentage)
        Me.GridBand3.Columns.Add(Me.colGMQuantity)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.VisibleIndex = 1
        Me.GridBand3.Width = 548
        '
        'colMarkerLengthYrds
        '
        Me.colMarkerLengthYrds.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerLengthYrds.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerLengthYrds.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerLengthYrds.FieldName = "MarkerLengthYrds"
        Me.colMarkerLengthYrds.Name = "colMarkerLengthYrds"
        Me.colMarkerLengthYrds.Visible = True
        Me.colMarkerLengthYrds.Width = 87
        '
        'colMarkerLengthInch
        '
        Me.colMarkerLengthInch.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerLengthInch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerLengthInch.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerLengthInch.FieldName = "MarkerLengthInch"
        Me.colMarkerLengthInch.Name = "colMarkerLengthInch"
        Me.colMarkerLengthInch.Visible = True
        Me.colMarkerLengthInch.Width = 86
        '
        'colMarkerWidth
        '
        Me.colMarkerWidth.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerWidth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerWidth.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerWidth.FieldName = "MarkerWidth"
        Me.colMarkerWidth.Name = "colMarkerWidth"
        Me.colMarkerWidth.Visible = True
        '
        'colWidthAllowance
        '
        Me.colWidthAllowance.AppearanceHeader.Options.UseTextOptions = True
        Me.colWidthAllowance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWidthAllowance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWidthAllowance.FieldName = "WidthAllowance"
        Me.colWidthAllowance.Name = "colWidthAllowance"
        Me.colWidthAllowance.Visible = True
        '
        'colLengthAllowance
        '
        Me.colLengthAllowance.AppearanceHeader.Options.UseTextOptions = True
        Me.colLengthAllowance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLengthAllowance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLengthAllowance.FieldName = "LengthAllowance"
        Me.colLengthAllowance.Name = "colLengthAllowance"
        Me.colLengthAllowance.Visible = True
        '
        'colWastagePercentage
        '
        Me.colWastagePercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colWastagePercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWastagePercentage.FieldName = "WastagePercentage"
        Me.colWastagePercentage.Name = "colWastagePercentage"
        Me.colWastagePercentage.Visible = True
        '
        'colGMQuantity
        '
        Me.colGMQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colGMQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGMQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGMQuantity.FieldName = "GMQuantity"
        Me.colGMQuantity.Name = "colGMQuantity"
        Me.colGMQuantity.Visible = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Dyeing And Additional Information"
        Me.GridBand1.Columns.Add(Me.colDyeingTypeId)
        Me.GridBand1.Columns.Add(Me.colIsAllOverPrint)
        Me.GridBand1.Columns.Add(Me.colRemarks1)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 2
        Me.GridBand1.Width = 427
        '
        'colDyeingTypeId
        '
        Me.colDyeingTypeId.AppearanceHeader.Options.UseTextOptions = True
        Me.colDyeingTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDyeingTypeId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDyeingTypeId.Caption = "Dyeing Type"
        Me.colDyeingTypeId.ColumnEdit = Me.DyeingTypeGridLookUpEdit
        Me.colDyeingTypeId.FieldName = "DyeingTypeId"
        Me.colDyeingTypeId.Name = "colDyeingTypeId"
        Me.colDyeingTypeId.Visible = True
        Me.colDyeingTypeId.Width = 123
        '
        'DyeingTypeGridLookUpEdit
        '
        Me.DyeingTypeGridLookUpEdit.AutoHeight = False
        Me.DyeingTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DyeingTypeGridLookUpEdit.DataSource = Me.DyeingTypeBindingSource
        Me.DyeingTypeGridLookUpEdit.DisplayMember = "DyeingType"
        Me.DyeingTypeGridLookUpEdit.Name = "DyeingTypeGridLookUpEdit"
        Me.DyeingTypeGridLookUpEdit.NullText = ""
        Me.DyeingTypeGridLookUpEdit.PopupView = Me.GridView7
        Me.DyeingTypeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DyeingTypeGridLookUpEdit.ValueMember = "DyeingTypeId"
        '
        'DyeingTypeBindingSource
        '
        Me.DyeingTypeBindingSource.DataMember = "DyeingType"
        Me.DyeingTypeBindingSource.DataSource = Me.DyeingTypeDataSet
        '
        'DyeingTypeDataSet
        '
        Me.DyeingTypeDataSet.DataSetName = "DyeingTypeDataSet"
        Me.DyeingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDyeingType})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colDyeingType
        '
        Me.colDyeingType.FieldName = "DyeingType"
        Me.colDyeingType.Name = "colDyeingType"
        Me.colDyeingType.Visible = True
        Me.colDyeingType.VisibleIndex = 0
        '
        'colIsAllOverPrint
        '
        Me.colIsAllOverPrint.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsAllOverPrint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsAllOverPrint.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsAllOverPrint.FieldName = "IsAllOverPrint"
        Me.colIsAllOverPrint.Name = "colIsAllOverPrint"
        Me.colIsAllOverPrint.Visible = True
        Me.colIsAllOverPrint.Width = 135
        '
        'colRemarks1
        '
        Me.colRemarks1.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.Width = 169
        '
        'MultipartXtraTabPage
        '
        Me.MultipartXtraTabPage.AutoScroll = True
        Me.MultipartXtraTabPage.Controls.Add(Me.TwinPackDetailsGridControl)
        Me.MultipartXtraTabPage.Name = "MultipartXtraTabPage"
        Me.MultipartXtraTabPage.Size = New System.Drawing.Size(1364, 193)
        Me.MultipartXtraTabPage.Text = "Multipart"
        '
        'TwinPackDetailsGridControl
        '
        Me.TwinPackDetailsGridControl.DataSource = Me.TwinPackDetailsBindingSource
        Me.TwinPackDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TwinPackDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.TwinPackDetailsGridControl.MainView = Me.GridView13
        Me.TwinPackDetailsGridControl.Name = "TwinPackDetailsGridControl"
        Me.TwinPackDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1})
        Me.TwinPackDetailsGridControl.Size = New System.Drawing.Size(1364, 193)
        Me.TwinPackDetailsGridControl.TabIndex = 0
        Me.TwinPackDetailsGridControl.UseEmbeddedNavigator = True
        Me.TwinPackDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView13})
        '
        'TwinPackDetailsBindingSource
        '
        Me.TwinPackDetailsBindingSource.DataMember = "FK_TwinPackDetails_Order"
        Me.TwinPackDetailsBindingSource.DataSource = Me.OrderBindingSource
        '
        'GridView13
        '
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTwinPackId, Me.colOrderId1, Me.colFabricColorId1, Me.colDescription, Me.colPartName, Me.colPartColor})
        Me.GridView13.GridControl = Me.TwinPackDetailsGridControl
        Me.GridView13.Name = "GridView13"
        '
        'colTwinPackId
        '
        Me.colTwinPackId.FieldName = "TwinPackId"
        Me.colTwinPackId.Name = "colTwinPackId"
        Me.colTwinPackId.OptionsColumn.ReadOnly = True
        '
        'colOrderId1
        '
        Me.colOrderId1.FieldName = "OrderId"
        Me.colOrderId1.Name = "colOrderId1"
        '
        'colFabricColorId1
        '
        Me.colFabricColorId1.Caption = "Garments Color"
        Me.colFabricColorId1.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colFabricColorId1.FieldName = "FabricColorId"
        Me.colFabricColorId1.Name = "colFabricColorId1"
        Me.colFabricColorId1.Visible = True
        Me.colFabricColorId1.VisibleIndex = 0
        Me.colFabricColorId1.Width = 173
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.FabricColorBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "FabricColorName"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.GridView14
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "FabricColorId"
        '
        'GridView14
        '
        Me.GridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView14.OptionsView.ShowGroupPanel = False
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 3
        Me.colDescription.Width = 619
        '
        'colPartName
        '
        Me.colPartName.FieldName = "PartName"
        Me.colPartName.Name = "colPartName"
        Me.colPartName.Visible = True
        Me.colPartName.VisibleIndex = 1
        Me.colPartName.Width = 153
        '
        'colPartColor
        '
        Me.colPartColor.FieldName = "PartColor"
        Me.colPartColor.Name = "colPartColor"
        Me.colPartColor.Visible = True
        Me.colPartColor.VisibleIndex = 2
        Me.colPartColor.Width = 206
        '
        'PrintDetailsXtraTabPage
        '
        Me.PrintDetailsXtraTabPage.Controls.Add(Me.Label4)
        Me.PrintDetailsXtraTabPage.Name = "PrintDetailsXtraTabPage"
        Me.PrintDetailsXtraTabPage.Size = New System.Drawing.Size(1364, 193)
        Me.PrintDetailsXtraTabPage.Text = "Print Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Up Coming"
        '
        'AmndHistory
        '
        Me.AmndHistory.AutoScroll = True
        Me.AmndHistory.Controls.Add(Me.OrderAmndDetailsGridControl)
        Me.AmndHistory.Name = "AmndHistory"
        Me.AmndHistory.Size = New System.Drawing.Size(1364, 193)
        Me.AmndHistory.Text = "Amendment History"
        '
        'OrderAmndDetailsGridControl
        '
        Me.OrderAmndDetailsGridControl.DataSource = Me.OrderAmndDetailsBindingSource
        Me.OrderAmndDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderAmndDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderAmndDetailsGridControl.MainView = Me.GridView15
        Me.OrderAmndDetailsGridControl.Name = "OrderAmndDetailsGridControl"
        Me.OrderAmndDetailsGridControl.Size = New System.Drawing.Size(1364, 193)
        Me.OrderAmndDetailsGridControl.TabIndex = 0
        Me.OrderAmndDetailsGridControl.UseEmbeddedNavigator = True
        Me.OrderAmndDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView15})
        '
        'OrderAmndDetailsBindingSource
        '
        Me.OrderAmndDetailsBindingSource.DataMember = "FK_OrderAmndDetails_Order"
        Me.OrderAmndDetailsBindingSource.DataSource = Me.OrderBindingSource
        '
        'GridView15
        '
        Me.GridView15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderAmndDetailsId, Me.colOrderId2, Me.colAmndNo, Me.colAmndDate, Me.colDetails})
        Me.GridView15.GridControl = Me.OrderAmndDetailsGridControl
        Me.GridView15.Name = "GridView15"
        Me.GridView15.OptionsBehavior.Editable = False
        Me.GridView15.OptionsView.ShowGroupPanel = False
        '
        'colOrderAmndDetailsId
        '
        Me.colOrderAmndDetailsId.FieldName = "OrderAmndDetailsId"
        Me.colOrderAmndDetailsId.Name = "colOrderAmndDetailsId"
        Me.colOrderAmndDetailsId.OptionsColumn.ReadOnly = True
        '
        'colOrderId2
        '
        Me.colOrderId2.FieldName = "OrderId"
        Me.colOrderId2.Name = "colOrderId2"
        '
        'colAmndNo
        '
        Me.colAmndNo.FieldName = "AmndNo"
        Me.colAmndNo.Name = "colAmndNo"
        Me.colAmndNo.OptionsColumn.AllowEdit = False
        Me.colAmndNo.OptionsColumn.ReadOnly = True
        Me.colAmndNo.Visible = True
        Me.colAmndNo.VisibleIndex = 0
        Me.colAmndNo.Width = 88
        '
        'colAmndDate
        '
        Me.colAmndDate.FieldName = "AmndDate"
        Me.colAmndDate.Name = "colAmndDate"
        Me.colAmndDate.OptionsColumn.AllowEdit = False
        Me.colAmndDate.OptionsColumn.ReadOnly = True
        Me.colAmndDate.Visible = True
        Me.colAmndDate.VisibleIndex = 1
        Me.colAmndDate.Width = 124
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.OptionsColumn.AllowEdit = False
        Me.colDetails.OptionsColumn.ReadOnly = True
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 2
        Me.colDetails.Width = 1188
        '
        'OrderProcessXtraTabPage
        '
        Me.OrderProcessXtraTabPage.AutoScroll = True
        Me.OrderProcessXtraTabPage.Controls.Add(Me.LinkLabel1)
        Me.OrderProcessXtraTabPage.Controls.Add(Me.FROrderProcessGridControl)
        Me.OrderProcessXtraTabPage.Name = "OrderProcessXtraTabPage"
        Me.OrderProcessXtraTabPage.Size = New System.Drawing.Size(1364, 193)
        Me.OrderProcessXtraTabPage.Text = "Order Process"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(482, 15)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(75, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Get Operation"
        '
        'FROrderProcessGridControl
        '
        Me.FROrderProcessGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FROrderProcessGridControl.DataSource = Me.FROrderProcessBindingSource
        Me.FROrderProcessGridControl.Location = New System.Drawing.Point(3, 3)
        Me.FROrderProcessGridControl.MainView = Me.GridView16
        Me.FROrderProcessGridControl.Name = "FROrderProcessGridControl"
        Me.FROrderProcessGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.OperationLookupGridLookUpEdit})
        Me.FROrderProcessGridControl.Size = New System.Drawing.Size(459, 266)
        Me.FROrderProcessGridControl.TabIndex = 0
        Me.FROrderProcessGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView16})
        '
        'FROrderProcessBindingSource
        '
        Me.FROrderProcessBindingSource.DataMember = "Order_FROrderProcess"
        Me.FROrderProcessBindingSource.DataSource = Me.OrderBindingSource
        '
        'GridView16
        '
        Me.GridView16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFRProcessId, Me.colSMV, Me.colFactor})
        Me.GridView16.GridControl = Me.FROrderProcessGridControl
        Me.GridView16.Name = "GridView16"
        Me.GridView16.OptionsView.ShowGroupPanel = False
        '
        'colFRProcessId
        '
        Me.colFRProcessId.Caption = "Operation"
        Me.colFRProcessId.ColumnEdit = Me.OperationLookupGridLookUpEdit
        Me.colFRProcessId.FieldName = "FRProcessId"
        Me.colFRProcessId.Name = "colFRProcessId"
        Me.colFRProcessId.Visible = True
        Me.colFRProcessId.VisibleIndex = 0
        Me.colFRProcessId.Width = 465
        '
        'OperationLookupGridLookUpEdit
        '
        Me.OperationLookupGridLookUpEdit.AutoHeight = False
        Me.OperationLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OperationLookupGridLookUpEdit.DataSource = Me.FRProcessBindingSource
        Me.OperationLookupGridLookUpEdit.DisplayMember = "FRProcessName"
        Me.OperationLookupGridLookUpEdit.Name = "OperationLookupGridLookUpEdit"
        Me.OperationLookupGridLookUpEdit.PopupView = Me.GridView17
        Me.OperationLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OperationLookupGridLookUpEdit.ValueMember = "FRProcessId"
        '
        'FRProcessBindingSource
        '
        Me.FRProcessBindingSource.DataMember = "FRProcess"
        Me.FRProcessBindingSource.DataSource = Me.FRProcessDataSet
        '
        'FRProcessDataSet
        '
        Me.FRProcessDataSet.DataSetName = "FRProcessDataSet"
        Me.FRProcessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView17
        '
        Me.GridView17.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView17.Name = "GridView17"
        Me.GridView17.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView17.OptionsView.ShowGroupPanel = False
        '
        'colSMV
        '
        Me.colSMV.FieldName = "SMV"
        Me.colSMV.Name = "colSMV"
        Me.colSMV.Visible = True
        Me.colSMV.VisibleIndex = 1
        Me.colSMV.Width = 88
        '
        'colFactor
        '
        Me.colFactor.FieldName = "Factor"
        Me.colFactor.Name = "colFactor"
        Me.colFactor.Visible = True
        Me.colFactor.VisibleIndex = 2
        Me.colFactor.Width = 118
        '
        'ActivitiesXtraTabPage
        '
        Me.ActivitiesXtraTabPage.AutoScroll = True
        Me.ActivitiesXtraTabPage.Controls.Add(Me.SplitContainer1)
        Me.ActivitiesXtraTabPage.Name = "ActivitiesXtraTabPage"
        Me.ActivitiesXtraTabPage.Size = New System.Drawing.Size(1364, 193)
        Me.ActivitiesXtraTabPage.Text = "Activities"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.OrderActivitiesGridControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.OrderActivitiesPredecessorGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1364, 193)
        Me.SplitContainer1.SplitterDistance = 974
        Me.SplitContainer1.TabIndex = 1
        '
        'OrderActivitiesGridControl1
        '
        Me.OrderActivitiesGridControl1.DataSource = Me.OrderActivitiesBindingSource
        Me.OrderActivitiesGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderActivitiesGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.OrderActivitiesGridControl1.MainView = Me.GridView27
        Me.OrderActivitiesGridControl1.Name = "OrderActivitiesGridControl1"
        Me.OrderActivitiesGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.OrderActivitiesGridControl1.Size = New System.Drawing.Size(974, 193)
        Me.OrderActivitiesGridControl1.TabIndex = 1
        Me.OrderActivitiesGridControl1.UseEmbeddedNavigator = True
        Me.OrderActivitiesGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView27})
        '
        'OrderActivitiesBindingSource
        '
        Me.OrderActivitiesBindingSource.DataMember = "FK_OrderActivities_Order"
        Me.OrderActivitiesBindingSource.DataSource = Me.OrderBindingSource
        '
        'GridView27
        '
        Me.GridView27.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView27.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView27.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView27.ColumnPanelRowHeight = 40
        Me.GridView27.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSL, Me.colActivitiesListId, Me.colDuration, Me.colES, Me.colEF, Me.colLF, Me.colSlack, Me.colTaskComplete, Me.colTaskComments, Me.colOffDay, Me.colLeftday})
        Me.GridView27.GridControl = Me.OrderActivitiesGridControl1
        Me.GridView27.Name = "GridView27"
        Me.GridView27.OptionsView.ShowGroupPanel = False
        '
        'colSL
        '
        Me.colSL.FieldName = "SL"
        Me.colSL.Name = "colSL"
        Me.colSL.Visible = True
        Me.colSL.VisibleIndex = 0
        Me.colSL.Width = 40
        '
        'colActivitiesListId
        '
        Me.colActivitiesListId.Caption = "Activities"
        Me.colActivitiesListId.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colActivitiesListId.FieldName = "ActivitiesListId"
        Me.colActivitiesListId.Name = "colActivitiesListId"
        Me.colActivitiesListId.Visible = True
        Me.colActivitiesListId.VisibleIndex = 1
        Me.colActivitiesListId.Width = 210
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.ActivitiesListBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Description"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.RepositoryItemLookUpEdit1.ValueMember = "ActivitiesListId"
        '
        'ActivitiesListBindingSource
        '
        Me.ActivitiesListBindingSource.DataMember = "ActivitiesList"
        Me.ActivitiesListBindingSource.DataSource = Me.ActivitiesListDataSet
        '
        'ActivitiesListDataSet
        '
        Me.ActivitiesListDataSet.DataSetName = "ActivitiesListDataSet"
        Me.ActivitiesListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colDuration
        '
        Me.colDuration.FieldName = "Duration"
        Me.colDuration.Name = "colDuration"
        Me.colDuration.Visible = True
        Me.colDuration.VisibleIndex = 2
        Me.colDuration.Width = 66
        '
        'colES
        '
        Me.colES.Caption = "Start Date"
        Me.colES.FieldName = "ES"
        Me.colES.Name = "colES"
        Me.colES.Visible = True
        Me.colES.VisibleIndex = 5
        Me.colES.Width = 66
        '
        'colEF
        '
        Me.colEF.Caption = "End Date"
        Me.colEF.FieldName = "EF"
        Me.colEF.Name = "colEF"
        Me.colEF.Visible = True
        Me.colEF.VisibleIndex = 6
        Me.colEF.Width = 66
        '
        'colLF
        '
        Me.colLF.FieldName = "LF"
        Me.colLF.Name = "colLF"
        Me.colLF.Width = 66
        '
        'colSlack
        '
        Me.colSlack.FieldName = "Slack"
        Me.colSlack.Name = "colSlack"
        Me.colSlack.Width = 66
        '
        'colTaskComplete
        '
        Me.colTaskComplete.FieldName = "TaskComplete"
        Me.colTaskComplete.Name = "colTaskComplete"
        Me.colTaskComplete.Visible = True
        Me.colTaskComplete.VisibleIndex = 7
        Me.colTaskComplete.Width = 66
        '
        'colTaskComments
        '
        Me.colTaskComments.FieldName = "TaskComments"
        Me.colTaskComments.Name = "colTaskComments"
        Me.colTaskComments.Visible = True
        Me.colTaskComments.VisibleIndex = 8
        Me.colTaskComments.Width = 86
        '
        'colOffDay
        '
        Me.colOffDay.FieldName = "OffDay"
        Me.colOffDay.Name = "colOffDay"
        Me.colOffDay.Visible = True
        Me.colOffDay.VisibleIndex = 3
        Me.colOffDay.Width = 66
        '
        'colLeftday
        '
        Me.colLeftday.FieldName = "Leftday"
        Me.colLeftday.Name = "colLeftday"
        Me.colLeftday.Visible = True
        Me.colLeftday.VisibleIndex = 4
        Me.colLeftday.Width = 66
        '
        'OrderActivitiesPredecessorGridControl
        '
        Me.OrderActivitiesPredecessorGridControl.DataSource = Me.OrderActivitiesPredecessorBindingSource
        Me.OrderActivitiesPredecessorGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderActivitiesPredecessorGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderActivitiesPredecessorGridControl.MainView = Me.GridView19
        Me.OrderActivitiesPredecessorGridControl.Name = "OrderActivitiesPredecessorGridControl"
        Me.OrderActivitiesPredecessorGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2})
        Me.OrderActivitiesPredecessorGridControl.Size = New System.Drawing.Size(386, 193)
        Me.OrderActivitiesPredecessorGridControl.TabIndex = 0
        Me.OrderActivitiesPredecessorGridControl.UseEmbeddedNavigator = True
        Me.OrderActivitiesPredecessorGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView19})
        '
        'OrderActivitiesPredecessorBindingSource
        '
        Me.OrderActivitiesPredecessorBindingSource.DataMember = "FK_OrderActivitiesPredecessor_OrderActivities"
        Me.OrderActivitiesPredecessorBindingSource.DataSource = Me.OrderActivitiesBindingSource
        '
        'GridView19
        '
        Me.GridView19.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesListId1})
        Me.GridView19.GridControl = Me.OrderActivitiesPredecessorGridControl
        Me.GridView19.Name = "GridView19"
        Me.GridView19.OptionsView.ShowGroupPanel = False
        '
        'colActivitiesListId1
        '
        Me.colActivitiesListId1.Caption = "Predecessors"
        Me.colActivitiesListId1.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colActivitiesListId1.FieldName = "ActivitiesListId"
        Me.colActivitiesListId1.Name = "colActivitiesListId1"
        Me.colActivitiesListId1.Visible = True
        Me.colActivitiesListId1.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.ActivitiesListBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Description"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "ActivitiesListId"
        '
        'OrderPictureXtraTabPage
        '
        Me.OrderPictureXtraTabPage.AutoScroll = True
        Me.OrderPictureXtraTabPage.Controls.Add(Me.OrderPictureGridControl)
        Me.OrderPictureXtraTabPage.Name = "OrderPictureXtraTabPage"
        Me.OrderPictureXtraTabPage.Size = New System.Drawing.Size(1364, 193)
        Me.OrderPictureXtraTabPage.Text = "Order Picture"
        '
        'OrderPictureGridControl
        '
        Me.OrderPictureGridControl.DataSource = Me.OrderPictureBindingSource
        Me.OrderPictureGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderPictureGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderPictureGridControl.MainView = Me.GridView23
        Me.OrderPictureGridControl.Name = "OrderPictureGridControl"
        Me.OrderPictureGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageEdit1})
        Me.OrderPictureGridControl.Size = New System.Drawing.Size(1364, 193)
        Me.OrderPictureGridControl.TabIndex = 0
        Me.OrderPictureGridControl.UseEmbeddedNavigator = True
        Me.OrderPictureGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView23})
        '
        'OrderPictureBindingSource
        '
        Me.OrderPictureBindingSource.DataMember = "FK_OrderPicture_Order"
        Me.OrderPictureBindingSource.DataSource = Me.OrderBindingSource
        '
        'GridView23
        '
        Me.GridView23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderPictureId, Me.colOrderId3, Me.colPicture, Me.colDefaultPicture, Me.colSide})
        Me.GridView23.GridControl = Me.OrderPictureGridControl
        Me.GridView23.Name = "GridView23"
        Me.GridView23.RowHeight = 40
        '
        'colOrderPictureId
        '
        Me.colOrderPictureId.FieldName = "OrderPictureId"
        Me.colOrderPictureId.Name = "colOrderPictureId"
        Me.colOrderPictureId.OptionsColumn.ReadOnly = True
        '
        'colOrderId3
        '
        Me.colOrderId3.FieldName = "OrderId"
        Me.colOrderId3.Name = "colOrderId3"
        '
        'colPicture
        '
        Me.colPicture.ColumnEdit = Me.RepositoryItemImageEdit1
        Me.colPicture.FieldName = "Picture"
        Me.colPicture.Name = "colPicture"
        Me.colPicture.Visible = True
        Me.colPicture.VisibleIndex = 0
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'colDefaultPicture
        '
        Me.colDefaultPicture.FieldName = "DefaultPicture"
        Me.colDefaultPicture.Name = "colDefaultPicture"
        Me.colDefaultPicture.Visible = True
        Me.colDefaultPicture.VisibleIndex = 1
        '
        'colSide
        '
        Me.colSide.FieldName = "Side"
        Me.colSide.Name = "colSide"
        Me.colSide.Visible = True
        Me.colSide.VisibleIndex = 2
        '
        'PreCostingNoLookupBindingSource
        '
        Me.PreCostingNoLookupBindingSource.DataMember = "PreCostingNoLookup"
        Me.PreCostingNoLookupBindingSource.DataSource = Me.PreCostingNoLookupDataSet
        '
        'PreCostingNoLookupDataSet
        '
        Me.PreCostingNoLookupDataSet.DataSetName = "PreCostingNoLookupDataSet"
        Me.PreCostingNoLookupDataSet.EnforceConstraints = False
        Me.PreCostingNoLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FabricForSizeTableAdapter = Nothing
        Me.TableAdapterManager.FabricTableAdapter = Me.FabricTableAdapter
        Me.TableAdapterManager.FinishingProcessTableAdapter = Nothing
        Me.TableAdapterManager.FROrderProcessTableAdapter = Me.FROrderProcessTableAdapter
        Me.TableAdapterManager.OrderActivitiesPredecessorTableAdapter = Me.OrderActivitiesPredecessorTableAdapter
        Me.TableAdapterManager.OrderActivitiesTableAdapter = Me.OrderActivitiesTableAdapter
        Me.TableAdapterManager.OrderAmndDetailsTableAdapter = Me.OrderAmndDetailsTableAdapter
        Me.TableAdapterManager.OrderCPTableAdapter = Nothing
        Me.TableAdapterManager.OrderCuttingPercentageTableAdapter = Me.OrderCuttingPercentageTableAdapter
        Me.TableAdapterManager.OrderDetailsTableAdapter = Me.OrderDetailsTableAdapter
        Me.TableAdapterManager.OrderGarmentsPartTableAdapter = Nothing
        Me.TableAdapterManager.OrderInstructionTableAdapter = Me.OrderInstructionTableAdapter
        Me.TableAdapterManager.OrderPictureTableAdapter = Me.OrderPictureTableAdapter
        Me.TableAdapterManager.OrderSizeDetailsTableAdapter = Me.OrderSizeDetailsTableAdapter
        Me.TableAdapterManager.OrderTableAdapter = Me.OrderTableAdapter
        Me.TableAdapterManager.OrderTrimTableAdapter = Nothing
        Me.TableAdapterManager.TwinPackDetailsTableAdapter = Me.TwinPackDetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.OrderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FabricTableAdapter
        '
        Me.FabricTableAdapter.ClearBeforeFill = True
        '
        'FROrderProcessTableAdapter
        '
        Me.FROrderProcessTableAdapter.ClearBeforeFill = True
        '
        'OrderActivitiesPredecessorTableAdapter
        '
        Me.OrderActivitiesPredecessorTableAdapter.ClearBeforeFill = True
        '
        'OrderActivitiesTableAdapter
        '
        Me.OrderActivitiesTableAdapter.ClearBeforeFill = True
        '
        'OrderAmndDetailsTableAdapter
        '
        Me.OrderAmndDetailsTableAdapter.ClearBeforeFill = True
        '
        'OrderCuttingPercentageTableAdapter
        '
        Me.OrderCuttingPercentageTableAdapter.ClearBeforeFill = True
        '
        'OrderDetailsTableAdapter
        '
        Me.OrderDetailsTableAdapter.ClearBeforeFill = True
        '
        'OrderInstructionTableAdapter
        '
        Me.OrderInstructionTableAdapter.ClearBeforeFill = True
        '
        'OrderPictureTableAdapter
        '
        Me.OrderPictureTableAdapter.ClearBeforeFill = True
        '
        'OrderSizeDetailsTableAdapter
        '
        Me.OrderSizeDetailsTableAdapter.ClearBeforeFill = True
        '
        'TwinPackDetailsTableAdapter
        '
        Me.TwinPackDetailsTableAdapter.ClearBeforeFill = True
        '
        'DivisionTableAdapter
        '
        Me.DivisionTableAdapter.ClearBeforeFill = True
        '
        'SeasonTableAdapter
        '
        Me.SeasonTableAdapter.ClearBeforeFill = True
        '
        'GarmentTableAdapter
        '
        Me.GarmentTableAdapter.ClearBeforeFill = True
        '
        'StyleLookupTableAdapter
        '
        Me.StyleLookupTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'SizeTableAdapter
        '
        Me.SizeTableAdapter.ClearBeforeFill = True
        '
        'DyeingTypeTableAdapter
        '
        Me.DyeingTypeTableAdapter.ClearBeforeFill = True
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'GarmentsPartTableAdapter
        '
        Me.GarmentsPartTableAdapter.ClearBeforeFill = True
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'colBuyerCode
        '
        Me.colBuyerCode.FieldName = "BuyerCode"
        Me.colBuyerCode.Name = "colBuyerCode"
        Me.colBuyerCode.Visible = True
        Me.colBuyerCode.VisibleIndex = 0
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 1
        '
        'colDivisionName
        '
        Me.colDivisionName.FieldName = "DivisionName"
        Me.colDivisionName.Name = "colDivisionName"
        Me.colDivisionName.Visible = True
        Me.colDivisionName.VisibleIndex = 0
        '
        'colGarmentName
        '
        Me.colGarmentName.FieldName = "GarmentName"
        Me.colGarmentName.Name = "colGarmentName"
        Me.colGarmentName.Visible = True
        Me.colGarmentName.VisibleIndex = 0
        '
        'colSeasonName
        '
        Me.colSeasonName.FieldName = "SeasonName"
        Me.colSeasonName.Name = "colSeasonName"
        Me.colSeasonName.Visible = True
        Me.colSeasonName.VisibleIndex = 0
        '
        'DestinationTableAdapter
        '
        Me.DestinationTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupByStyleTableAdapter
        '
        Me.OrderLookupByStyleTableAdapter.ClearBeforeFill = True
        '
        'colFabricColorName1
        '
        Me.colFabricColorName1.FieldName = "FabricColorName"
        Me.colFabricColorName1.Name = "colFabricColorName1"
        Me.colFabricColorName1.Visible = True
        Me.colFabricColorName1.VisibleIndex = 0
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'GSMTableAdapter
        '
        Me.GSMTableAdapter.ClearBeforeFill = True
        '
        'colGSM
        '
        Me.colGSM.FieldName = "GSM"
        Me.colGSM.Name = "colGSM"
        Me.colGSM.Visible = True
        Me.colGSM.VisibleIndex = 0
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'WashTypeMstTableAdapter
        '
        Me.WashTypeMstTableAdapter.ClearBeforeFill = True
        '
        'colWashType
        '
        Me.colWashType.FieldName = "WashType"
        Me.colWashType.Name = "colWashType"
        Me.colWashType.Visible = True
        Me.colWashType.VisibleIndex = 0
        '
        'FRProcessTableAdapter
        '
        Me.FRProcessTableAdapter.ClearBeforeFill = True
        '
        'ActivitiesGroupTableAdapter
        '
        Me.ActivitiesGroupTableAdapter.ClearBeforeFill = True
        '
        'ActivitiesListTableAdapter
        '
        Me.ActivitiesListTableAdapter.ClearBeforeFill = True
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'colUSER_NAME2
        '
        Me.colUSER_NAME2.Caption = "User"
        Me.colUSER_NAME2.FieldName = "USER_NAME"
        Me.colUSER_NAME2.Name = "colUSER_NAME2"
        Me.colUSER_NAME2.Visible = True
        Me.colUSER_NAME2.VisibleIndex = 0
        '
        'colDepartment
        '
        Me.colDepartment.Caption = "Department"
        Me.colDepartment.FieldName = "Department"
        Me.colDepartment.Name = "colDepartment"
        Me.colDepartment.Visible = True
        Me.colDepartment.VisibleIndex = 1
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
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'PreCostingNoLookupTableAdapter
        '
        Me.PreCostingNoLookupTableAdapter.ClearBeforeFill = True
        '
        'FabricFinishingTypeDataSet
        '
        Me.FabricFinishingTypeDataSet.DataSetName = "FabricFinishingTypeDataSet"
        Me.FabricFinishingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricFinishingTypeBindingSource
        '
        Me.FabricFinishingTypeBindingSource.DataMember = "FabricFinishingType"
        Me.FabricFinishingTypeBindingSource.DataSource = Me.FabricFinishingTypeDataSet
        '
        'FabricFinishingTypeTableAdapter
        '
        Me.FabricFinishingTypeTableAdapter.ClearBeforeFill = True
        '
        'FabricMaterialTypeTableAdapter
        '
        Me.FabricMaterialTypeTableAdapter.ClearBeforeFill = True
        '
        'SusStandardMstTableAdapter
        '
        Me.SusStandardMstTableAdapter.ClearBeforeFill = True
        '
        'AdvProgramLookupTableAdapter
        '
        Me.AdvProgramLookupTableAdapter.ClearBeforeFill = True
        '
        'frmOrderReceived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 701)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.KeyPreview = True
        Me.Name = "frmOrderReceived"
        Me.Text = "Order Received"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.HoldOnDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldOnDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsHoldCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvPrgNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvProgramLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnDyeingTypeGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnDyeingTypeGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FullCompleteDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FullCompleteDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputCompleteDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputCompleteDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsInputCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.OrderLookupByStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ActivitiesGroupIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesGroupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsYDSCheckBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentDescriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsBrushCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPeachFinishCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsAOPCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SusStandGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SusStandardMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SusStandardDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabMatGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricMaterialTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricMaterialTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsAdvanceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsEmbroideryCheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsFabricBOMCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsAccBOMCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderRemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.OrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderReceiveDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderReceiveDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CauseofAmendmentMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscontinueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecialYarnCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SequenceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SublimationCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleReferenceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsMultiPartCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvOrderIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.OrderDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackTypeComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrDetailsStyleIdGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesGroupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerateItemHyperLinkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentByComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETADateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETADateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.SizeAndInstructionXtraTabPage.ResumeLayout(False)
        CType(Me.OrderInstructionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderInstructionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuttingPercentageXtraTabPage.ResumeLayout(False)
        Me.CuttingPercentageXtraTabPage.PerformLayout()
        CType(Me.OrderCuttingPercentageGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderCuttingPercentageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorCPGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingWPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FabricXtraTabPage.ResumeLayout(False)
        CType(Me.FabricGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaTypeComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaUnitComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishUnitComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MultipartXtraTabPage.ResumeLayout(False)
        CType(Me.TwinPackDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwinPackDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PrintDetailsXtraTabPage.ResumeLayout(False)
        Me.PrintDetailsXtraTabPage.PerformLayout()
        Me.AmndHistory.ResumeLayout(False)
        CType(Me.OrderAmndDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderAmndDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrderProcessXtraTabPage.ResumeLayout(False)
        Me.OrderProcessXtraTabPage.PerformLayout()
        CType(Me.FROrderProcessGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FROrderProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperationLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FRProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FRProcessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActivitiesXtraTabPage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.OrderActivitiesGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderActivitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderActivitiesPredecessorGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderActivitiesPredecessorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrderPictureXtraTabPage.ResumeLayout(False)
        CType(Me.OrderPictureGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPictureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingNoLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricFinishingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricFinishingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents OrderDataSet As KSoft_Apparel.OrderDataSet
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.OrderDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StyleIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DivisionIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SeasonIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GarmentIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProgramNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StyleIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents BuyerIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents OrderReceiveDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AmendmentDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CauseofAmendmentMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DiscontinueCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DivisionIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SeasonIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GarmentIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents IsPrintCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents StyleReferenceNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UserIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ModifiedDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents IsMultiPartCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AdvOrderIdSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents StyleNameIdSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents DivisionDataSet As KSoft_Apparel.DivisionDataSet
    Friend WithEvents DivisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DivisionTableAdapter As KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter
    Friend WithEvents SeasonDataSet As KSoft_Apparel.SeasonDataSet
    Friend WithEvents SeasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeasonTableAdapter As KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter
    Friend WithEvents GarmentDataSet As KSoft_Apparel.GarmentDataSet
    Friend WithEvents GarmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentTableAdapter As KSoft_Apparel.GarmentDataSetTableAdapters.GarmentTableAdapter
    Friend WithEvents StyleLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleLookupTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents OrderDetailsTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.OrderDetailsTableAdapter
    Friend WithEvents OrderDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents OrderDetailsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPackType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestinationId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReference As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents SizeAndInstructionXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents FabricXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents OrderSizeDetailsTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.OrderSizeDetailsTableAdapter
    Friend WithEvents OrderSizeDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderSizeDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRatio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderInstructionTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.OrderInstructionTableAdapter
    Friend WithEvents OrderInstructionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderInstructionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderInstructionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstructionSlNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstruction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstructionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.FabricTableAdapter
    Friend WithEvents FabricBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colDyeingTypeId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsAllOverPrint As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colKnittingTypeId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompositionId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDiaUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFinishFabricDia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDiaType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFinishUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colMarkerLengthYrds As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarkerLengthInch As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarkerWidth As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWidthAllowance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLengthAllowance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWastagePercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGMQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents AmendmentNoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AmndHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CalculateRatioButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PasteButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CopyButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CancelEntryButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ExportButton As System.Windows.Forms.Button
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents GarmentsColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents ETADateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents EXDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents EXGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PackTypeComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SizeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SizeDataSet As KSoft_Apparel.SizeDataSet
    Friend WithEvents SizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SizeTableAdapter As KSoft_Apparel.SizeDataSetTableAdapters.SizeTableAdapter
    Friend WithEvents DyeingTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DyeingTypeDataSet As KSoft_Apparel.DyeingTypeDataSet
    Friend WithEvents DyeingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DyeingTypeTableAdapter As KSoft_Apparel.DyeingTypeDataSetTableAdapters.DyeingTypeTableAdapter
    Friend WithEvents FabricTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintDetailsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MultipartXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DiaTypeComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DiaUnitComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents FinishUnitComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents CompositionGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents colGarmentsPartId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GarmentsPartGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSPNote As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GarmentsPartDataSet As KSoft_Apparel.GarmentsPartDataSet
    Friend WithEvents GarmentsPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartTableAdapter As KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDivisionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGarmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeasonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeasonName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleIdLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents colStyleName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GarmentIdLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents OrderRemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DestinationGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DestinationDataSet As KSoft_Apparel.DestinationDataSet
    Friend WithEvents DestinationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DestinationTableAdapter As KSoft_Apparel.DestinationDataSetTableAdapters.DestinationTableAdapter
    Friend WithEvents OrDetailsStyleIdGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents OrderLookupByStyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupByStyleTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupByStyleTableAdapter
    Friend WithEvents AmndButton As System.Windows.Forms.Button
    Friend WithEvents TwinPackDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TwinPackDetailsTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.TwinPackDetailsTableAdapter
    Friend WithEvents TwinPackDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTwinPackId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPartColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompanyDataSet As KSoft_Apparel.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Apparel.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents colDestinationCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDyeingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGarmentDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSMId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GSMGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GSMDataSet As KSoft_Apparel.GSMDataSet
    Friend WithEvents GSMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GSMTableAdapter As KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
    Friend WithEvents colGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Paste2Button As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UserIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents UserIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserDataSet As KSoft_Apparel.UserDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderAmndDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderAmndDetailsTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.OrderAmndDetailsTableAdapter
    Friend WithEvents OrderAmndDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderAmndDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmndNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsFabricBOMCompleteCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsAccBOMCompleteCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colSKUNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsEmbroideryCheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsAdvanceCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents WashTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents WashTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WashTypeDataSet As KSoft_Apparel.WashTypeDataSet
    Friend WithEvents WashTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashTypeMstTableAdapter As KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter
    Friend WithEvents colWashType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderProcessXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents FROrderProcessBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FROrderProcessTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.FROrderProcessTableAdapter
    Friend WithEvents FROrderProcessGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFRProcessId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFactor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents OperationLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FRProcessDataSet As KSoft_Apparel.FRProcessDataSet
    Friend WithEvents FRProcessBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FRProcessTableAdapter As KSoft_Apparel.FRProcessDataSetTableAdapters.FRProcessTableAdapter
    Friend WithEvents colActivitiesGroupId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActivitiesGroupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ActivitiesGroupDataSet As KSoft_Apparel.ActivitiesGroupDataSet
    Friend WithEvents ActivitiesGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesGroupTableAdapter As KSoft_Apparel.ActivitiesGroupDataSetTableAdapters.ActivitiesGroupTableAdapter
    Friend WithEvents colActivitiesGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActivitiesXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ActivitiesListDataSet As KSoft_Apparel.ActivitiesListDataSet
    Friend WithEvents ActivitiesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesListTableAdapter As KSoft_Apparel.ActivitiesListDataSetTableAdapters.ActivitiesListTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GenerateActivitiesGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GenerateItemHyperLinkEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents WashCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsCompleteCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents UserLookupDataSet As KSoft_Apparel.UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserLookupTableAdapter As KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents colUSER_NAME2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsAOPCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents EmbroideryDetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AOPDetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colStyleName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderPictureXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents OrderPictureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderPictureTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.OrderPictureTableAdapter
    Friend WithEvents OrderPictureGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderPictureId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPicture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultPicture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSide As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents IsBrushCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsPeachFinishCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colColorSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GarmentDescriptionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents colDivisionName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRFIDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents colTTLAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents IsYDSCheckBox As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colA_S As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShipmentByComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GMTBrandDataSet As KSoft_Apparel.GMTBrandDataSet
    Friend WithEvents GMTBrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMTBrandTableAdapter As KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter
    Friend WithEvents colGMTBrandName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMTBrandIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GMTBrandIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGMTBrandName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ApprovedSampleNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MasterProgramNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintDetailsTextBox As TextBox
    Friend WithEvents CuttingPercentageXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents OrderCuttingPercentageTableAdapter As OrderDataSetTableAdapters.OrderCuttingPercentageTableAdapter
    Friend WithEvents OrderCuttingPercentageBindingSource As BindingSource
    Friend WithEvents GetColorListButton As Button
    Friend WithEvents OrderCuttingPercentageGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView24 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricColorCPGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView25 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCuttingPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrinting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmbroidery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CuttingWPSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ActivitiesGroupIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView26 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents colActivitiesGroup1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FullCompleteDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents InputCompleteDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents IsInputCompleteCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TTLOffDayLabel As Label
    Friend WithEvents TTLDayLabel As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents OrderActivitiesBindingSource As BindingSource
    Friend WithEvents OrderActivitiesTableAdapter As OrderDataSetTableAdapters.OrderActivitiesTableAdapter
    Friend WithEvents OrderActivitiesPredecessorBindingSource As BindingSource
    Friend WithEvents OrderActivitiesPredecessorTableAdapter As OrderDataSetTableAdapters.OrderActivitiesPredecessorTableAdapter
    Friend WithEvents TTLWDayLabel2 As Label
    Friend WithEvents PicturePictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents StyleDataSet As StyleDataSet
    Friend WithEvents StyleBindingSource As BindingSource
    Friend WithEvents StyleTableAdapter As StyleDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents OrderActivitiesGridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView27 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivitiesListId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSlack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaskComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaskComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOffDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLeftday As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderActivitiesPredecessorGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView19 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colActivitiesListId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PreCostingNoLookupDataSet As PreCostingNoLookupDataSet
    Friend WithEvents PreCostingNoLookupBindingSource As BindingSource
    Friend WithEvents PreCostingNoLookupTableAdapter As PreCostingNoLookupDataSetTableAdapters.PreCostingNoLookupTableAdapter
    Friend WithEvents TTLOffDayLabel2 As Label
    Friend WithEvents TTLDayLabel2 As Label
    Friend WithEvents WDLabel As Label
    Friend WithEvents GenTNAButton As Button
    Friend WithEvents colFirstEx As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpecialYarnCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SequenceCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SublimationCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SusStandGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView20 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabMatGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricFinishingTypeDataSet As FabricFinishingTypeDataSet
    Friend WithEvents FabricFinishingTypeBindingSource As BindingSource
    Friend WithEvents FabricFinishingTypeTableAdapter As FabricFinishingTypeDataSetTableAdapters.FabricFinishingTypeTableAdapter
    Friend WithEvents FabricMaterialTypeDataSet As FabricMaterialTypeDataSet
    Friend WithEvents FabricMaterialTypeBindingSource As BindingSource
    Friend WithEvents FabricMaterialTypeTableAdapter As FabricMaterialTypeDataSetTableAdapters.FabricMaterialTypeTableAdapter
    Friend WithEvents SusStandardDataSet As SusStandardDataSet
    Friend WithEvents SusStandardMstBindingSource As BindingSource
    Friend WithEvents SusStandardMstTableAdapter As SusStandardDataSetTableAdapters.SusStandardMstTableAdapter
    Friend WithEvents colSusStandard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabMatType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YarnDyeingTypeGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents YarnDyeingTypeGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents CopyFullButton As Button
    Friend WithEvents colClosedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CancelDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AdvPrgNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AdvProgramLookupDataSet As AdvProgramLookupDataSet
    Friend WithEvents AdvProgramLookupBindingSource As BindingSource
    Friend WithEvents AdvProgramLookupTableAdapter As AdvProgramLookupDataSetTableAdapters.AdvProgramLookupTableAdapter
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BPrgNoLinkLabel As LinkLabel
    Friend WithEvents colDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCasuseOfDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HoldOnDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents IsHoldCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colIsHold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoldOn As DevExpress.XtraGrid.Columns.GridColumn
End Class
