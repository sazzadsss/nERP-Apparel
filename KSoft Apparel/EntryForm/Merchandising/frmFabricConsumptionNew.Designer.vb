<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFabricConsumptionNew
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
        Dim ProgramNoLabel As System.Windows.Forms.Label
        Dim CompanyIdLabel As System.Windows.Forms.Label
        Dim OrderReceiveDateLabel As System.Windows.Forms.Label
        Dim OrderExDateLabel As System.Windows.Forms.Label
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim ConDateLabel As System.Windows.Forms.Label
        Dim CuttingWPLabel As System.Windows.Forms.Label
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDataSet = New KSoft_Apparel.OrderDataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Apparel.UserDataSet()
        Me.UserIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CompanyIdComboBox = New System.Windows.Forms.ComboBox()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Apparel.CompanyDataSet()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OrderLookupByStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.OrderRemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
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
        Me.OrderExDateDateEdit = New DevExpress.XtraEditors.DateEdit()
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
        Me.IsPrintCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.StyleReferenceNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UserIdComboBox = New System.Windows.Forms.ComboBox()
        Me.ModifiedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.IsMultiPartCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsEmbroideryCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AdvOrderIdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.StyleNameIdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.CopyTextBox = New System.Windows.Forms.NumericUpDown()
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
        Me.colGSM1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishFabricDia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDiaType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DiaTypeComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDiaUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DiaUnitComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colFinishUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.FinishUnitComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colSPNote = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLength = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCon = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.ConItemCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colKgPerUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.KgPerUnitCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colMarkerLengthYrds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMarkerLengthInch = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMarkerWidth = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colWidthAllowance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLengthAllowance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colWastagePercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGreyWastagePercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
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
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.ConDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.IsConCompleteCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SetCColorButton = New System.Windows.Forms.Button()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.CColorGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.GridView19 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SetColorAndSizeButton = New System.Windows.Forms.Button()
        Me.FabricForSizeGridControl = New DevExpress.XtraGrid.GridControl()
        Me.FabricForSizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.OrderSizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderSizeDataSet = New KSoft_Apparel.OrderSizeDataSet()
        Me.GridView18 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet()
        Me.GridView17 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContrastColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ContrastColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCCSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCuttingPercentage1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.SizeCheckedComboBoxEdit = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ColorCheckedComboBoxEdit = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.FabricXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.OrderDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.OrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GarmentsColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ETADateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colA_S = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.colIsClose = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrDetailsStyleIdGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCasuseOfDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO_Type1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EXGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.SizeAndInstructionXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
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
        Me.AmndHistory = New DevExpress.XtraTab.XtraTabPage()
        Me.OrderAmndDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.OrderAmndDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderAmndDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmndNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GetColorListButton = New System.Windows.Forms.Button()
        Me.OrderCuttingPercentageGridControl = New DevExpress.XtraGrid.GridControl()
        Me.OrderCuttingPercentageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView20 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricColorCPGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView21 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCuttingPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrinting = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmbroidery = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWashing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSewing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CuttingWPSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.FinishingProcessGridControl = New DevExpress.XtraGrid.GridControl()
        Me.FinishingProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView22 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFinishingProcessId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishingProcess = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OrderTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.OrderDataSetTableAdapters.TableAdapterManager()
        Me.FabricForSizeTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.FabricForSizeTableAdapter()
        Me.FabricTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.FabricTableAdapter()
        Me.FinishingProcessTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.FinishingProcessTableAdapter()
        Me.OrderAmndDetailsTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderAmndDetailsTableAdapter()
        Me.OrderCuttingPercentageTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderCuttingPercentageTableAdapter()
        Me.OrderDetailsTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderDetailsTableAdapter()
        Me.OrderInstructionTableAdapter = New KSoft_Apparel.OrderDataSetTableAdapters.OrderInstructionTableAdapter()
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
        Me.OrderSizeLookupTableAdapter = New KSoft_Apparel.OrderSizeDataSetTableAdapters.OrderSizeLookupTableAdapter()
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter()
        ProgramNoLabel = New System.Windows.Forms.Label()
        CompanyIdLabel = New System.Windows.Forms.Label()
        OrderReceiveDateLabel = New System.Windows.Forms.Label()
        OrderExDateLabel = New System.Windows.Forms.Label()
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
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        ConDateLabel = New System.Windows.Forms.Label()
        CuttingWPLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.UserIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupByStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.OrderExDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderExDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleReferenceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsMultiPartCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsEmbroideryCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvOrderIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleNameIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.CopyTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.ConItemCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KgPerUnitCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsConCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.CColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricForSizeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricForSizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContrastColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FabricXtraTabPage.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.OrderDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETADateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETADateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackTypeComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrDetailsStyleIdGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SizeAndInstructionXtraTabPage.SuspendLayout()
        CType(Me.OrderInstructionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderInstructionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MultipartXtraTabPage.SuspendLayout()
        CType(Me.TwinPackDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TwinPackDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AmndHistory.SuspendLayout()
        CType(Me.OrderAmndDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderAmndDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.OrderCuttingPercentageGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderCuttingPercentageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorCPGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingWPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.FinishingProcessGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishingProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgramNoLabel
        '
        ProgramNoLabel.AutoSize = True
        ProgramNoLabel.Location = New System.Drawing.Point(18, 87)
        ProgramNoLabel.Name = "ProgramNoLabel"
        ProgramNoLabel.Size = New System.Drawing.Size(67, 13)
        ProgramNoLabel.TabIndex = 2
        ProgramNoLabel.Text = "Program No:"
        '
        'CompanyIdLabel
        '
        CompanyIdLabel.AutoSize = True
        CompanyIdLabel.Location = New System.Drawing.Point(18, 61)
        CompanyIdLabel.Name = "CompanyIdLabel"
        CompanyIdLabel.Size = New System.Drawing.Size(59, 13)
        CompanyIdLabel.TabIndex = 8
        CompanyIdLabel.Text = "Company :"
        '
        'OrderReceiveDateLabel
        '
        OrderReceiveDateLabel.AutoSize = True
        OrderReceiveDateLabel.Location = New System.Drawing.Point(270, 61)
        OrderReceiveDateLabel.Name = "OrderReceiveDateLabel"
        OrderReceiveDateLabel.Size = New System.Drawing.Size(106, 13)
        OrderReceiveDateLabel.TabIndex = 10
        OrderReceiveDateLabel.Text = "Order Receive Date:"
        '
        'OrderExDateLabel
        '
        OrderExDateLabel.AutoSize = True
        OrderExDateLabel.Location = New System.Drawing.Point(270, 87)
        OrderExDateLabel.Name = "OrderExDateLabel"
        OrderExDateLabel.Size = New System.Drawing.Size(80, 13)
        OrderExDateLabel.TabIndex = 12
        OrderExDateLabel.Text = "Order Ex Date:"
        '
        'AmendmentDateLabel
        '
        AmendmentDateLabel.AutoSize = True
        AmendmentDateLabel.Location = New System.Drawing.Point(609, 89)
        AmendmentDateLabel.Name = "AmendmentDateLabel"
        AmendmentDateLabel.Size = New System.Drawing.Size(94, 13)
        AmendmentDateLabel.TabIndex = 14
        AmendmentDateLabel.Text = "Amendment Date:"
        '
        'AmendmentNoLabel
        '
        AmendmentNoLabel.AutoSize = True
        AmendmentNoLabel.Location = New System.Drawing.Point(609, 64)
        AmendmentNoLabel.Name = "AmendmentNoLabel"
        AmendmentNoLabel.Size = New System.Drawing.Size(84, 13)
        AmendmentNoLabel.TabIndex = 16
        AmendmentNoLabel.Text = "Amendment No:"
        '
        'CauseofAmendmentLabel
        '
        CauseofAmendmentLabel.AutoSize = True
        CauseofAmendmentLabel.Location = New System.Drawing.Point(609, 113)
        CauseofAmendmentLabel.Name = "CauseofAmendmentLabel"
        CauseofAmendmentLabel.Size = New System.Drawing.Size(114, 13)
        CauseofAmendmentLabel.TabIndex = 18
        CauseofAmendmentLabel.Text = "Cause of Amendment:"
        '
        'StyleReferenceNoLabel
        '
        StyleReferenceNoLabel.AutoSize = True
        StyleReferenceNoLabel.Location = New System.Drawing.Point(18, 167)
        StyleReferenceNoLabel.Name = "StyleReferenceNoLabel"
        StyleReferenceNoLabel.Size = New System.Drawing.Size(104, 13)
        StyleReferenceNoLabel.TabIndex = 34
        StyleReferenceNoLabel.Text = "Style Reference No:"
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
        OrderRemarksLabel.Location = New System.Drawing.Point(18, 193)
        OrderRemarksLabel.Name = "OrderRemarksLabel"
        OrderRemarksLabel.Size = New System.Drawing.Size(83, 13)
        OrderRemarksLabel.TabIndex = 58
        OrderRemarksLabel.Text = "Order Remarks:"
        '
        'UserIdLabel1
        '
        UserIdLabel1.AutoSize = True
        UserIdLabel1.Location = New System.Drawing.Point(609, 168)
        UserIdLabel1.Name = "UserIdLabel1"
        UserIdLabel1.Size = New System.Drawing.Size(33, 13)
        UserIdLabel1.TabIndex = 62
        UserIdLabel1.Text = "User:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(19, 116)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(35, 13)
        Label3.TabIndex = 64
        Label3.Text = "Style:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(20, 144)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(39, 13)
        Label4.TabIndex = 65
        Label4.Text = "Buyer:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(270, 113)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(47, 13)
        Label5.TabIndex = 66
        Label5.Text = "Division:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(270, 141)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(57, 13)
        Label6.TabIndex = 67
        Label6.Text = "Garments:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(270, 168)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(46, 13)
        Label7.TabIndex = 68
        Label7.Text = "Season:"
        '
        'ConDateLabel
        '
        ConDateLabel.AutoSize = True
        ConDateLabel.Location = New System.Drawing.Point(997, 11)
        ConDateLabel.Name = "ConDateLabel"
        ConDateLabel.Size = New System.Drawing.Size(70, 13)
        ConDateLabel.TabIndex = 70
        ConDateLabel.Text = "Marker Date:"
        '
        'CuttingWPLabel
        '
        CuttingWPLabel.AutoSize = True
        CuttingWPLabel.Location = New System.Drawing.Point(786, 24)
        CuttingWPLabel.Name = "CuttingWPLabel"
        CuttingWPLabel.Size = New System.Drawing.Size(56, 13)
        CuttingWPLabel.TabIndex = 71
        CuttingWPLabel.Text = "Cutting %"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label7)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label6)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label5)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Label3)
        Me.SplitContainerControl1.Panel1.Controls.Add(UserIdLabel1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.UserIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CompanyIdComboBox)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ListBox1)
        Me.SplitContainerControl1.Panel1.Controls.Add(OrderRemarksLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.OrderRemarksTextEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AmendmentNoSpinEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(ProgramNoLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ProgramNoTextEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.StyleIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.BuyerIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(CompanyIdLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(OrderReceiveDateLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.OrderReceiveDateDateEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(OrderExDateLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.OrderExDateDateEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(AmendmentDateLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AmendmentDateDateEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(AmendmentNoLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(CauseofAmendmentLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CauseofAmendmentMemoEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.DiscontinueCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.DivisionIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SeasonIdGridLookUpEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GarmentIdGridLookUpEdit)
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
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.IsEmbroideryCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(AdvOrderIdLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AdvOrderIdSpinEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(StyleNameIdLabel)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.StyleNameIdSpinEdit)
        Me.SplitContainerControl1.Panel1.Text = "MainPanel"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1181, 603)
        Me.SplitContainerControl1.SplitterPosition = 221
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1000, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Privious Program"
        '
        'UserIdGridLookUpEdit
        '
        Me.UserIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "UserId", True))
        Me.UserIdGridLookUpEdit.Location = New System.Drawing.Point(723, 164)
        Me.UserIdGridLookUpEdit.Name = "UserIdGridLookUpEdit"
        Me.UserIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserIdGridLookUpEdit.Properties.DataSource = Me.UserBindingSource
        Me.UserIdGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.UserIdGridLookUpEdit.Properties.NullText = ""
        Me.UserIdGridLookUpEdit.Properties.ReadOnly = True
        Me.UserIdGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.UserIdGridLookUpEdit.Properties.View = Me.UserIdGridLookUpEditView
        Me.UserIdGridLookUpEdit.Size = New System.Drawing.Size(153, 20)
        Me.UserIdGridLookUpEdit.TabIndex = 63
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.OrderDataSet
        '
        'OrderDataSet
        '
        Me.OrderDataSet.DataSetName = "OrderDataSet"
        Me.OrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'UserIdGridLookUpEditView
        '
        Me.UserIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.UserIdGridLookUpEditView.Name = "UserIdGridLookUpEditView"
        Me.UserIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.UserIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'CompanyIdComboBox
        '
        Me.CompanyIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.OrderBindingSource, "CompanyId", True))
        Me.CompanyIdComboBox.DataSource = Me.CompanyBindingSource
        Me.CompanyIdComboBox.DisplayMember = "CompanyCode"
        Me.CompanyIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompanyIdComboBox.Enabled = False
        Me.CompanyIdComboBox.FormattingEnabled = True
        Me.CompanyIdComboBox.Location = New System.Drawing.Point(132, 58)
        Me.CompanyIdComboBox.Name = "CompanyIdComboBox"
        Me.CompanyIdComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CompanyIdComboBox.TabIndex = 62
        Me.CompanyIdComboBox.ValueMember = "CompanyId"
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
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.OrderLookupByStyleBindingSource
        Me.ListBox1.DisplayMember = "ProgramNo"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1000, 83)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(169, 108)
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
        'OrderRemarksTextEdit
        '
        Me.OrderRemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "OrderRemarks", True))
        Me.OrderRemarksTextEdit.Location = New System.Drawing.Point(132, 190)
        Me.OrderRemarksTextEdit.Name = "OrderRemarksTextEdit"
        Me.OrderRemarksTextEdit.Properties.ReadOnly = True
        Me.OrderRemarksTextEdit.Size = New System.Drawing.Size(457, 20)
        Me.OrderRemarksTextEdit.TabIndex = 59
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.OrderLookupGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.RefreshButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1181, 35)
        Me.FlowLayoutPanel1.TabIndex = 51
        Me.FlowLayoutPanel1.Tag = "NR"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
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
        Me.OrderLookupGridLookUpEdit.Location = New System.Drawing.Point(135, 7)
        Me.OrderLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.OrderLookupGridLookUpEdit.Name = "OrderLookupGridLookUpEdit"
        Me.OrderLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderLookupGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderLookupGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.OrderLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderLookupGridLookUpEdit.Properties.NullText = "Select your Program"
        Me.OrderLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderLookupGridLookUpEdit.Properties.Tag = "NR"
        Me.OrderLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderLookupGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderLookupGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.OrderLookupGridLookUpEdit.Size = New System.Drawing.Size(139, 20)
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
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.Location = New System.Drawing.Point(280, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(129, 26)
        Me.ShowButton.TabIndex = 47
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditButton.Location = New System.Drawing.Point(415, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(129, 27)
        Me.EditButton.TabIndex = 5
        Me.EditButton.Tag = "NR"
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RefreshButton.Location = New System.Drawing.Point(550, 3)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(129, 27)
        Me.RefreshButton.TabIndex = 5
        Me.RefreshButton.Tag = "NR"
        Me.RefreshButton.Text = "&Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'AmendmentNoSpinEdit
        '
        Me.AmendmentNoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "AmendmentNo", True))
        Me.AmendmentNoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AmendmentNoSpinEdit.Location = New System.Drawing.Point(723, 60)
        Me.AmendmentNoSpinEdit.Name = "AmendmentNoSpinEdit"
        Me.AmendmentNoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentNoSpinEdit.Properties.ReadOnly = True
        Me.AmendmentNoSpinEdit.Size = New System.Drawing.Size(49, 20)
        Me.AmendmentNoSpinEdit.TabIndex = 50
        '
        'ProgramNoTextEdit
        '
        Me.ProgramNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "ProgramNo", True))
        Me.ProgramNoTextEdit.Enabled = False
        Me.ProgramNoTextEdit.Location = New System.Drawing.Point(132, 84)
        Me.ProgramNoTextEdit.Name = "ProgramNoTextEdit"
        Me.ProgramNoTextEdit.Properties.ReadOnly = True
        Me.ProgramNoTextEdit.Size = New System.Drawing.Size(121, 20)
        Me.ProgramNoTextEdit.TabIndex = 3
        '
        'StyleIdGridLookUpEdit
        '
        Me.StyleIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "StyleId", True))
        Me.StyleIdGridLookUpEdit.Enabled = False
        Me.StyleIdGridLookUpEdit.Location = New System.Drawing.Point(132, 110)
        Me.StyleIdGridLookUpEdit.Name = "StyleIdGridLookUpEdit"
        Me.StyleIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleIdGridLookUpEdit.Properties.DataSource = Me.StyleLookupBindingSource
        Me.StyleIdGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleIdGridLookUpEdit.Properties.NullText = ""
        Me.StyleIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleIdGridLookUpEdit.Properties.ReadOnly = True
        Me.StyleIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleIdGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleIdGridLookUpEdit.Properties.View = Me.StyleIdGridLookUpEditView
        Me.StyleIdGridLookUpEdit.Size = New System.Drawing.Size(121, 20)
        Me.StyleIdGridLookUpEdit.TabIndex = 5
        '
        'StyleLookupBindingSource
        '
        Me.StyleLookupBindingSource.DataMember = "StyleLookup"
        Me.StyleLookupBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
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
        Me.BuyerIdGridLookUpEdit.Enabled = False
        Me.BuyerIdGridLookUpEdit.Location = New System.Drawing.Point(132, 138)
        Me.BuyerIdGridLookUpEdit.Name = "BuyerIdGridLookUpEdit"
        Me.BuyerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerIdGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerIdGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerIdGridLookUpEdit.Properties.NullText = ""
        Me.BuyerIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerIdGridLookUpEdit.Properties.ReadOnly = True
        Me.BuyerIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerIdGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerIdGridLookUpEdit.Properties.View = Me.BuyerIdGridLookUpEditView
        Me.BuyerIdGridLookUpEdit.Size = New System.Drawing.Size(121, 20)
        Me.BuyerIdGridLookUpEdit.TabIndex = 7
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
        Me.OrderReceiveDateDateEdit.Enabled = False
        Me.OrderReceiveDateDateEdit.Location = New System.Drawing.Point(384, 58)
        Me.OrderReceiveDateDateEdit.Name = "OrderReceiveDateDateEdit"
        Me.OrderReceiveDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderReceiveDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderReceiveDateDateEdit.Properties.ReadOnly = True
        Me.OrderReceiveDateDateEdit.Size = New System.Drawing.Size(121, 20)
        Me.OrderReceiveDateDateEdit.TabIndex = 11
        '
        'OrderExDateDateEdit
        '
        Me.OrderExDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "OrderExDate", True))
        Me.OrderExDateDateEdit.EditValue = Nothing
        Me.OrderExDateDateEdit.Enabled = False
        Me.OrderExDateDateEdit.Location = New System.Drawing.Point(384, 84)
        Me.OrderExDateDateEdit.Name = "OrderExDateDateEdit"
        Me.OrderExDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderExDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderExDateDateEdit.Properties.ReadOnly = True
        Me.OrderExDateDateEdit.Size = New System.Drawing.Size(121, 20)
        Me.OrderExDateDateEdit.TabIndex = 13
        '
        'AmendmentDateDateEdit
        '
        Me.AmendmentDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "AmendmentDate", True))
        Me.AmendmentDateDateEdit.EditValue = Nothing
        Me.AmendmentDateDateEdit.Location = New System.Drawing.Point(723, 85)
        Me.AmendmentDateDateEdit.Name = "AmendmentDateDateEdit"
        Me.AmendmentDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentDateDateEdit.Properties.ReadOnly = True
        Me.AmendmentDateDateEdit.Size = New System.Drawing.Size(153, 20)
        Me.AmendmentDateDateEdit.TabIndex = 15
        '
        'CauseofAmendmentMemoEdit
        '
        Me.CauseofAmendmentMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "CauseofAmendment", True))
        Me.CauseofAmendmentMemoEdit.Location = New System.Drawing.Point(723, 110)
        Me.CauseofAmendmentMemoEdit.Name = "CauseofAmendmentMemoEdit"
        Me.CauseofAmendmentMemoEdit.Properties.ReadOnly = True
        Me.CauseofAmendmentMemoEdit.Size = New System.Drawing.Size(153, 48)
        Me.CauseofAmendmentMemoEdit.TabIndex = 19
        '
        'DiscontinueCheckEdit
        '
        Me.DiscontinueCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "Discontinue", True))
        Me.DiscontinueCheckEdit.Location = New System.Drawing.Point(882, 82)
        Me.DiscontinueCheckEdit.Name = "DiscontinueCheckEdit"
        Me.DiscontinueCheckEdit.Properties.Caption = "Discontinue"
        Me.DiscontinueCheckEdit.Size = New System.Drawing.Size(121, 19)
        Me.DiscontinueCheckEdit.TabIndex = 21
        '
        'DivisionIdGridLookUpEdit
        '
        Me.DivisionIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "DivisionId", True))
        Me.DivisionIdGridLookUpEdit.Enabled = False
        Me.DivisionIdGridLookUpEdit.Location = New System.Drawing.Point(384, 110)
        Me.DivisionIdGridLookUpEdit.Name = "DivisionIdGridLookUpEdit"
        Me.DivisionIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DivisionIdGridLookUpEdit.Properties.DataSource = Me.DivisionBindingSource
        Me.DivisionIdGridLookUpEdit.Properties.DisplayMember = "DivisionName"
        Me.DivisionIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.DivisionIdGridLookUpEdit.Properties.NullText = ""
        Me.DivisionIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.DivisionIdGridLookUpEdit.Properties.ReadOnly = True
        Me.DivisionIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DivisionIdGridLookUpEdit.Properties.ValueMember = "DivisionId"
        Me.DivisionIdGridLookUpEdit.Properties.View = Me.DivisionIdGridLookUpEditView
        Me.DivisionIdGridLookUpEdit.Size = New System.Drawing.Size(205, 20)
        Me.DivisionIdGridLookUpEdit.TabIndex = 23
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
        Me.SeasonIdGridLookUpEdit.Enabled = False
        Me.SeasonIdGridLookUpEdit.Location = New System.Drawing.Point(384, 164)
        Me.SeasonIdGridLookUpEdit.Name = "SeasonIdGridLookUpEdit"
        Me.SeasonIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SeasonIdGridLookUpEdit.Properties.DataSource = Me.SeasonBindingSource
        Me.SeasonIdGridLookUpEdit.Properties.DisplayMember = "SeasonName"
        Me.SeasonIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SeasonIdGridLookUpEdit.Properties.NullText = ""
        Me.SeasonIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SeasonIdGridLookUpEdit.Properties.ReadOnly = True
        Me.SeasonIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SeasonIdGridLookUpEdit.Properties.ValueMember = "SeasonId"
        Me.SeasonIdGridLookUpEdit.Properties.View = Me.SeasonIdGridLookUpEditView
        Me.SeasonIdGridLookUpEdit.Size = New System.Drawing.Size(205, 20)
        Me.SeasonIdGridLookUpEdit.TabIndex = 25
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
        Me.GarmentIdGridLookUpEdit.Enabled = False
        Me.GarmentIdGridLookUpEdit.Location = New System.Drawing.Point(384, 137)
        Me.GarmentIdGridLookUpEdit.Name = "GarmentIdGridLookUpEdit"
        Me.GarmentIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GarmentIdGridLookUpEdit.Properties.DataSource = Me.GarmentBindingSource
        Me.GarmentIdGridLookUpEdit.Properties.DisplayMember = "GarmentDescription"
        Me.GarmentIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.GarmentIdGridLookUpEdit.Properties.NullText = ""
        Me.GarmentIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GarmentIdGridLookUpEdit.Properties.ReadOnly = True
        Me.GarmentIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GarmentIdGridLookUpEdit.Properties.ValueMember = "GarmentId"
        Me.GarmentIdGridLookUpEdit.Properties.View = Me.GarmentIdGridLookUpEditView
        Me.GarmentIdGridLookUpEdit.Size = New System.Drawing.Size(205, 20)
        Me.GarmentIdGridLookUpEdit.TabIndex = 27
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
        'IsPrintCheckEdit
        '
        Me.IsPrintCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsPrint", True))
        Me.IsPrintCheckEdit.Location = New System.Drawing.Point(882, 60)
        Me.IsPrintCheckEdit.Name = "IsPrintCheckEdit"
        Me.IsPrintCheckEdit.Properties.Caption = "Print Available"
        Me.IsPrintCheckEdit.Size = New System.Drawing.Size(121, 19)
        Me.IsPrintCheckEdit.TabIndex = 31
        '
        'StyleReferenceNoTextEdit
        '
        Me.StyleReferenceNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "StyleReferenceNo", True))
        Me.StyleReferenceNoTextEdit.Enabled = False
        Me.StyleReferenceNoTextEdit.Location = New System.Drawing.Point(132, 164)
        Me.StyleReferenceNoTextEdit.Name = "StyleReferenceNoTextEdit"
        Me.StyleReferenceNoTextEdit.Properties.ReadOnly = True
        Me.StyleReferenceNoTextEdit.Size = New System.Drawing.Size(121, 20)
        Me.StyleReferenceNoTextEdit.TabIndex = 35
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
        'IsEmbroideryCheckEdit
        '
        Me.IsEmbroideryCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsEmbroidery", True))
        Me.IsEmbroideryCheckEdit.Location = New System.Drawing.Point(135, 668)
        Me.IsEmbroideryCheckEdit.Name = "IsEmbroideryCheckEdit"
        Me.IsEmbroideryCheckEdit.Properties.Caption = "CheckEdit1"
        Me.IsEmbroideryCheckEdit.Size = New System.Drawing.Size(121, 19)
        Me.IsEmbroideryCheckEdit.TabIndex = 45
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
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.CopyButton)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.CopyTextBox)
        Me.SplitContainerControl2.Panel1.Controls.Add(ConDateLabel)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.FabricGridControl)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.ConDateDateEdit)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.IsConCompleteCheckEdit)
        Me.SplitContainerControl2.Panel1.Text = "DetailsPanel"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl2.Panel2.Text = "Size Panel"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1181, 377)
        Me.SplitContainerControl2.SplitterPosition = 187
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(65, 6)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(47, 23)
        Me.CopyButton.TabIndex = 76
        Me.CopyButton.Text = "&Copy"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'CopyTextBox
        '
        Me.CopyTextBox.Location = New System.Drawing.Point(24, 8)
        Me.CopyTextBox.Name = "CopyTextBox"
        Me.CopyTextBox.Size = New System.Drawing.Size(36, 21)
        Me.CopyTextBox.TabIndex = 75
        '
        'FabricGridControl
        '
        Me.FabricGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FabricGridControl.DataSource = Me.FabricBindingSource
        Me.FabricGridControl.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.FabricGridControl.Location = New System.Drawing.Point(0, 33)
        Me.FabricGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.FabricGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.FabricGridControl.MainView = Me.BandedGridView1
        Me.FabricGridControl.Name = "FabricGridControl"
        Me.FabricGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.DyeingTypeGridLookUpEdit, Me.FabricTypeGridLookUpEdit, Me.DiaTypeComboBox, Me.DiaUnitComboBox, Me.FinishUnitComboBox, Me.CompositionGridLookUpEdit, Me.GarmentsPartGridLookUpEdit, Me.GSMGridLookUpEdit, Me.RepositoryItemCalcEdit1, Me.ConItemCalcEdit, Me.KgPerUnitCalcEdit})
        Me.FabricGridControl.Size = New System.Drawing.Size(1181, 154)
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
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colDyeingTypeId, Me.colIsAllOverPrint, Me.colRemarks1, Me.colKnittingTypeId, Me.colFinishFabricDia, Me.colDiaType, Me.colMarkerLengthYrds, Me.colMarkerLengthInch, Me.colMarkerWidth, Me.colLengthAllowance, Me.colWidthAllowance, Me.colWastagePercentage, Me.colGMQuantity, Me.colDiaUnit, Me.colFinishUnit, Me.colCompositionId, Me.colSPNote, Me.colGarmentsPartId, Me.colGSMId, Me.colCon, Me.colLength, Me.colKgPerUnit, Me.colGreyWastagePercentage})
        Me.BandedGridView1.CustomizationFormBounds = New System.Drawing.Rectangle(984, 45, 225, 349)
        Me.BandedGridView1.GridControl = Me.FabricGridControl
        Me.BandedGridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "Con", Nothing, "")})
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
        Me.gridBand2.Columns.Add(Me.colLength)
        Me.gridBand2.Columns.Add(Me.colCon)
        Me.gridBand2.Columns.Add(Me.colKgPerUnit)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 0
        Me.gridBand2.Width = 862
        '
        'colGarmentsPartId
        '
        Me.colGarmentsPartId.AppearanceCell.Options.UseTextOptions = True
        Me.colGarmentsPartId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGarmentsPartId.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGarmentsPartId.AppearanceHeader.Options.UseTextOptions = True
        Me.colGarmentsPartId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGarmentsPartId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGarmentsPartId.Caption = "Garments Part"
        Me.colGarmentsPartId.ColumnEdit = Me.GarmentsPartGridLookUpEdit
        Me.colGarmentsPartId.FieldName = "GarmentsPartId"
        Me.colGarmentsPartId.Name = "colGarmentsPartId"
        Me.colGarmentsPartId.Visible = True
        Me.colGarmentsPartId.Width = 68
        '
        'GarmentsPartGridLookUpEdit
        '
        Me.GarmentsPartGridLookUpEdit.AutoHeight = False
        Me.GarmentsPartGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GarmentsPartGridLookUpEdit.DataSource = Me.GarmentsPartBindingSource
        Me.GarmentsPartGridLookUpEdit.DisplayMember = "Name"
        Me.GarmentsPartGridLookUpEdit.Name = "GarmentsPartGridLookUpEdit"
        Me.GarmentsPartGridLookUpEdit.NullText = ""
        Me.GarmentsPartGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GarmentsPartGridLookUpEdit.ValueMember = "GarmentsPartId"
        Me.GarmentsPartGridLookUpEdit.View = Me.GridView10
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
        Me.colKnittingTypeId.Width = 150
        '
        'FabricTypeGridLookUpEdit
        '
        Me.FabricTypeGridLookUpEdit.AutoHeight = False
        Me.FabricTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricTypeGridLookUpEdit.DataSource = Me.KnittingTypeBindingSource
        Me.FabricTypeGridLookUpEdit.DisplayMember = "KnittingType"
        Me.FabricTypeGridLookUpEdit.ImmediatePopup = True
        Me.FabricTypeGridLookUpEdit.Name = "FabricTypeGridLookUpEdit"
        Me.FabricTypeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricTypeGridLookUpEdit.ValueMember = "KnittingTypeId"
        Me.FabricTypeGridLookUpEdit.View = Me.GridView8
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
        Me.colCompositionId.Width = 155
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
        Me.CompositionGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CompositionGridLookUpEdit.ValueMember = "CompositionId"
        Me.CompositionGridLookUpEdit.View = Me.GridView9
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
        Me.colGSMId.Width = 40
        '
        'GSMGridLookUpEdit
        '
        Me.GSMGridLookUpEdit.AutoHeight = False
        Me.GSMGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GSMGridLookUpEdit.DataSource = Me.GSMBindingSource
        Me.GSMGridLookUpEdit.DisplayMember = "GSM"
        Me.GSMGridLookUpEdit.Name = "GSMGridLookUpEdit"
        Me.GSMGridLookUpEdit.ValueMember = "GSMId"
        Me.GSMGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit2View
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
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGSM1})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colGSM1
        '
        Me.colGSM1.FieldName = "GSM"
        Me.colGSM1.Name = "colGSM1"
        Me.colGSM1.Visible = True
        Me.colGSM1.VisibleIndex = 0
        '
        'colFinishFabricDia
        '
        Me.colFinishFabricDia.AppearanceHeader.Options.UseTextOptions = True
        Me.colFinishFabricDia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFinishFabricDia.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFinishFabricDia.FieldName = "FinishFabricDia"
        Me.colFinishFabricDia.Name = "colFinishFabricDia"
        Me.colFinishFabricDia.Visible = True
        Me.colFinishFabricDia.Width = 63
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
        Me.colDiaType.Width = 38
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
        Me.colDiaUnit.Width = 38
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
        Me.colFinishUnit.Width = 45
        '
        'FinishUnitComboBox
        '
        Me.FinishUnitComboBox.AutoHeight = False
        Me.FinishUnitComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishUnitComboBox.Items.AddRange(New Object() {"Kg", "Pcs", "Mtr", "Yds"})
        Me.FinishUnitComboBox.Name = "FinishUnitComboBox"
        '
        'colSPNote
        '
        Me.colSPNote.FieldName = "SPNote"
        Me.colSPNote.Name = "colSPNote"
        Me.colSPNote.Visible = True
        Me.colSPNote.Width = 61
        '
        'colLength
        '
        Me.colLength.FieldName = "Length"
        Me.colLength.Name = "colLength"
        Me.colLength.Visible = True
        Me.colLength.Width = 50
        '
        'colCon
        '
        Me.colCon.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colCon.AppearanceCell.Options.UseBackColor = True
        Me.colCon.ColumnEdit = Me.ConItemCalcEdit
        Me.colCon.DisplayFormat.FormatString = "n3"
        Me.colCon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCon.FieldName = "Con"
        Me.colCon.Name = "colCon"
        Me.colCon.Visible = True
        Me.colCon.Width = 68
        '
        'ConItemCalcEdit
        '
        Me.ConItemCalcEdit.AutoHeight = False
        Me.ConItemCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ConItemCalcEdit.DisplayFormat.FormatString = "n3"
        Me.ConItemCalcEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ConItemCalcEdit.EditFormat.FormatString = "n3"
        Me.ConItemCalcEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ConItemCalcEdit.Name = "ConItemCalcEdit"
        '
        'colKgPerUnit
        '
        Me.colKgPerUnit.ColumnEdit = Me.KgPerUnitCalcEdit
        Me.colKgPerUnit.FieldName = "KgPerUnit"
        Me.colKgPerUnit.Name = "colKgPerUnit"
        Me.colKgPerUnit.Visible = True
        Me.colKgPerUnit.Width = 86
        '
        'KgPerUnitCalcEdit
        '
        Me.KgPerUnitCalcEdit.AutoHeight = False
        Me.KgPerUnitCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KgPerUnitCalcEdit.Name = "KgPerUnitCalcEdit"
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
        Me.GridBand3.Columns.Add(Me.colGreyWastagePercentage)
        Me.GridBand3.Columns.Add(Me.colGMQuantity)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.VisibleIndex = 1
        Me.GridBand3.Width = 591
        '
        'colMarkerLengthYrds
        '
        Me.colMarkerLengthYrds.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerLengthYrds.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerLengthYrds.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerLengthYrds.FieldName = "MarkerLengthYrds"
        Me.colMarkerLengthYrds.Name = "colMarkerLengthYrds"
        Me.colMarkerLengthYrds.Visible = True
        Me.colMarkerLengthYrds.Width = 81
        '
        'colMarkerLengthInch
        '
        Me.colMarkerLengthInch.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerLengthInch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerLengthInch.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerLengthInch.FieldName = "MarkerLengthInch"
        Me.colMarkerLengthInch.Name = "colMarkerLengthInch"
        Me.colMarkerLengthInch.Visible = True
        Me.colMarkerLengthInch.Width = 79
        '
        'colMarkerWidth
        '
        Me.colMarkerWidth.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerWidth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerWidth.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerWidth.FieldName = "MarkerWidth"
        Me.colMarkerWidth.Name = "colMarkerWidth"
        Me.colMarkerWidth.Visible = True
        Me.colMarkerWidth.Width = 62
        '
        'colWidthAllowance
        '
        Me.colWidthAllowance.AppearanceHeader.Options.UseTextOptions = True
        Me.colWidthAllowance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWidthAllowance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWidthAllowance.FieldName = "WidthAllowance"
        Me.colWidthAllowance.Name = "colWidthAllowance"
        Me.colWidthAllowance.Visible = True
        Me.colWidthAllowance.Width = 69
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
        Me.colWastagePercentage.Caption = "Finish %"
        Me.colWastagePercentage.FieldName = "WastagePercentage"
        Me.colWastagePercentage.Name = "colWastagePercentage"
        Me.colWastagePercentage.Visible = True
        '
        'colGreyWastagePercentage
        '
        Me.colGreyWastagePercentage.Caption = "Greige %"
        Me.colGreyWastagePercentage.FieldName = "GreyWastagePercentage"
        Me.colGreyWastagePercentage.Name = "colGreyWastagePercentage"
        Me.colGreyWastagePercentage.Visible = True
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
        Me.DyeingTypeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DyeingTypeGridLookUpEdit.ValueMember = "DyeingTypeId"
        Me.DyeingTypeGridLookUpEdit.View = Me.GridView7
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
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'ConDateDateEdit
        '
        Me.ConDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "ConDate", True))
        Me.ConDateDateEdit.EditValue = Nothing
        Me.ConDateDateEdit.Location = New System.Drawing.Point(1069, 8)
        Me.ConDateDateEdit.Name = "ConDateDateEdit"
        Me.ConDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ConDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ConDateDateEdit.Properties.ReadOnly = True
        Me.ConDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.ConDateDateEdit.TabIndex = 71
        '
        'IsConCompleteCheckEdit
        '
        Me.IsConCompleteCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderBindingSource, "IsConComplete", True))
        Me.IsConCompleteCheckEdit.Location = New System.Drawing.Point(870, 8)
        Me.IsConCompleteCheckEdit.Name = "IsConCompleteCheckEdit"
        Me.IsConCompleteCheckEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.IsConCompleteCheckEdit.Properties.Appearance.Options.UseForeColor = True
        Me.IsConCompleteCheckEdit.Properties.Caption = "Marker Complete"
        Me.IsConCompleteCheckEdit.Size = New System.Drawing.Size(123, 19)
        Me.IsConCompleteCheckEdit.TabIndex = 70
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1181, 185)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.FabricXtraTabPage, Me.SizeAndInstructionXtraTabPage, Me.MultipartXtraTabPage, Me.AmndHistory, Me.XtraTabPage2, Me.XtraTabPage1, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.SetCColorButton)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.CodeTextBox)
        Me.XtraTabPage1.Controls.Add(Me.CColorGridLookUpEdit)
        Me.XtraTabPage1.Controls.Add(Me.Label8)
        Me.XtraTabPage1.Controls.Add(Me.SetColorAndSizeButton)
        Me.XtraTabPage1.Controls.Add(Me.FabricForSizeGridControl)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.SizeCheckedComboBoxEdit)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.ColorCheckedComboBoxEdit)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1175, 157)
        Me.XtraTabPage1.Text = "Set Color And Size For Fabric"
        '
        'SetCColorButton
        '
        Me.SetCColorButton.Location = New System.Drawing.Point(129, 125)
        Me.SetCColorButton.Name = "SetCColorButton"
        Me.SetCColorButton.Size = New System.Drawing.Size(80, 23)
        Me.SetCColorButton.TabIndex = 18
        Me.SetCColorButton.Text = "Set CColor"
        Me.SetCColorButton.UseVisualStyleBackColor = True
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 129)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Code"
        '
        'CodeTextBox
        '
        Me.CodeTextBox.Location = New System.Drawing.Point(55, 126)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(71, 21)
        Me.CodeTextBox.TabIndex = 16
        '
        'CColorGridLookUpEdit
        '
        Me.CColorGridLookUpEdit.Location = New System.Drawing.Point(55, 100)
        Me.CColorGridLookUpEdit.Name = "CColorGridLookUpEdit"
        Me.CColorGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CColorGridLookUpEdit.Properties.DataSource = Me.FabricColorBindingSource
        Me.CColorGridLookUpEdit.Properties.DisplayMember = "FabricColorName"
        Me.CColorGridLookUpEdit.Properties.NullText = ""
        Me.CColorGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CColorGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CColorGridLookUpEdit.Properties.ValueMember = "FabricColorId"
        Me.CColorGridLookUpEdit.Properties.View = Me.GridView19
        Me.CColorGridLookUpEdit.Size = New System.Drawing.Size(154, 20)
        Me.CColorGridLookUpEdit.TabIndex = 15
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
        'GridView19
        '
        Me.GridView19.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName3})
        Me.GridView19.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView19.Name = "GridView19"
        Me.GridView19.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView19.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName3
        '
        Me.colFabricColorName3.FieldName = "FabricColorName"
        Me.colFabricColorName3.Name = "colFabricColorName3"
        Me.colFabricColorName3.Visible = True
        Me.colFabricColorName3.VisibleIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Select Color And Size :"
        '
        'SetColorAndSizeButton
        '
        Me.SetColorAndSizeButton.Location = New System.Drawing.Point(55, 71)
        Me.SetColorAndSizeButton.Name = "SetColorAndSizeButton"
        Me.SetColorAndSizeButton.Size = New System.Drawing.Size(154, 23)
        Me.SetColorAndSizeButton.TabIndex = 13
        Me.SetColorAndSizeButton.Text = "Set Color And Size"
        Me.SetColorAndSizeButton.UseVisualStyleBackColor = True
        '
        'FabricForSizeGridControl
        '
        Me.FabricForSizeGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FabricForSizeGridControl.DataSource = Me.FabricForSizeBindingSource
        Me.FabricForSizeGridControl.Location = New System.Drawing.Point(230, 3)
        Me.FabricForSizeGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.FabricForSizeGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.FabricForSizeGridControl.MainView = Me.GridView16
        Me.FabricForSizeGridControl.Name = "FabricForSizeGridControl"
        Me.FabricForSizeGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit2, Me.ColorGridLookUpEdit, Me.ContrastColorGridLookUpEdit})
        Me.FabricForSizeGridControl.Size = New System.Drawing.Size(942, 149)
        Me.FabricForSizeGridControl.TabIndex = 12
        Me.FabricForSizeGridControl.UseEmbeddedNavigator = True
        Me.FabricForSizeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView16})
        '
        'FabricForSizeBindingSource
        '
        Me.FabricForSizeBindingSource.DataMember = "Fabric_FabricForSize"
        Me.FabricForSizeBindingSource.DataSource = Me.FabricBindingSource
        '
        'GridView16
        '
        Me.GridView16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.GridColumn7, Me.colFabricQuantity, Me.colContrastColorId, Me.colCCSize, Me.colCuttingPercentage1})
        Me.GridView16.CustomizationFormBounds = New System.Drawing.Rectangle(767, 474, 216, 164)
        Me.GridView16.GridControl = Me.FabricForSizeGridControl
        Me.GridView16.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQuantity", Me.GridColumn3, "")})
        Me.GridView16.Name = "GridView16"
        Me.GridView16.OptionsView.ShowFooter = True
        Me.GridView16.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Size"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.GridColumn1.FieldName = "SizeId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 53
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.OrderSizeLookupBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "SizeCode"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "SizeId"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView18
        '
        'OrderSizeLookupBindingSource
        '
        Me.OrderSizeLookupBindingSource.DataMember = "OrderSizeLookup"
        Me.OrderSizeLookupBindingSource.DataSource = Me.OrderSizeDataSet
        '
        'OrderSizeDataSet
        '
        Me.OrderSizeDataSet.DataSetName = "OrderSizeDataSet"
        Me.OrderSizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView18
        '
        Me.GridView18.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2})
        Me.GridView18.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView18.Name = "GridView18"
        Me.GridView18.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView18.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "SizeCode"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "OrderQuantity"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 6
        Me.GridColumn3.Width = 116
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Garments Color"
        Me.GridColumn4.ColumnEdit = Me.ColorGridLookUpEdit
        Me.GridColumn4.FieldName = "FabricColorId"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 153
        '
        'ColorGridLookUpEdit
        '
        Me.ColorGridLookUpEdit.AutoHeight = False
        Me.ColorGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorGridLookUpEdit.DataSource = Me.OrderFabricColorBindingSource
        Me.ColorGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.ColorGridLookUpEdit.Name = "ColorGridLookUpEdit"
        Me.ColorGridLookUpEdit.NullText = ""
        Me.ColorGridLookUpEdit.ValueMember = "FabricColorId"
        Me.ColorGridLookUpEdit.View = Me.GridView17
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
        'GridView17
        '
        Me.GridView17.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5})
        Me.GridView17.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView17.Name = "GridView17"
        Me.GridView17.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView17.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "FabricColorName"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "Reference"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 90
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "Code"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 64
        '
        'colFabricQuantity
        '
        Me.colFabricQuantity.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colFabricQuantity.AppearanceCell.Options.UseBackColor = True
        Me.colFabricQuantity.Caption = "Fabric Quantity"
        Me.colFabricQuantity.DisplayFormat.FormatString = "n2"
        Me.colFabricQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFabricQuantity.FieldName = "FabricQuantity"
        Me.colFabricQuantity.Name = "colFabricQuantity"
        Me.colFabricQuantity.OptionsColumn.AllowEdit = False
        Me.colFabricQuantity.OptionsColumn.ReadOnly = True
        Me.colFabricQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFabricQuantity.Visible = True
        Me.colFabricQuantity.VisibleIndex = 8
        Me.colFabricQuantity.Width = 127
        '
        'colContrastColorId
        '
        Me.colContrastColorId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colContrastColorId.AppearanceCell.Options.UseBackColor = True
        Me.colContrastColorId.Caption = "Fabric Color"
        Me.colContrastColorId.ColumnEdit = Me.ContrastColorGridLookUpEdit
        Me.colContrastColorId.FieldName = "ContrastColorId"
        Me.colContrastColorId.Name = "colContrastColorId"
        Me.colContrastColorId.OptionsColumn.AllowEdit = False
        Me.colContrastColorId.OptionsColumn.ReadOnly = True
        Me.colContrastColorId.Visible = True
        Me.colContrastColorId.VisibleIndex = 1
        Me.colContrastColorId.Width = 170
        '
        'ContrastColorGridLookUpEdit
        '
        Me.ContrastColorGridLookUpEdit.AutoHeight = False
        Me.ContrastColorGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ContrastColorGridLookUpEdit.DataSource = Me.FabricColorBindingSource
        Me.ContrastColorGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.ContrastColorGridLookUpEdit.Name = "ContrastColorGridLookUpEdit"
        Me.ContrastColorGridLookUpEdit.NullText = ""
        Me.ContrastColorGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ContrastColorGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ContrastColorGridLookUpEdit.ValueMember = "FabricColorId"
        Me.ContrastColorGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit3View
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName2})
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName2
        '
        Me.colFabricColorName2.FieldName = "FabricColorName"
        Me.colFabricColorName2.Name = "colFabricColorName2"
        Me.colFabricColorName2.Visible = True
        Me.colFabricColorName2.VisibleIndex = 0
        '
        'colCCSize
        '
        Me.colCCSize.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colCCSize.AppearanceCell.Options.UseBackColor = True
        Me.colCCSize.FieldName = "CCSize"
        Me.colCCSize.Name = "colCCSize"
        Me.colCCSize.OptionsColumn.AllowEdit = False
        Me.colCCSize.OptionsColumn.ReadOnly = True
        Me.colCCSize.Visible = True
        Me.colCCSize.VisibleIndex = 5
        Me.colCCSize.Width = 110
        '
        'colCuttingPercentage1
        '
        Me.colCuttingPercentage1.Caption = "C%"
        Me.colCuttingPercentage1.FieldName = "CuttingPercentage"
        Me.colCuttingPercentage1.Name = "colCuttingPercentage1"
        Me.colCuttingPercentage1.OptionsColumn.AllowEdit = False
        Me.colCuttingPercentage1.OptionsColumn.ReadOnly = True
        Me.colCuttingPercentage1.Visible = True
        Me.colCuttingPercentage1.VisibleIndex = 7
        Me.colCuttingPercentage1.Width = 39
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 48)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Size"
        '
        'SizeCheckedComboBoxEdit
        '
        Me.SizeCheckedComboBoxEdit.Location = New System.Drawing.Point(55, 45)
        Me.SizeCheckedComboBoxEdit.Name = "SizeCheckedComboBoxEdit"
        Me.SizeCheckedComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeCheckedComboBoxEdit.Properties.DataSource = Me.OrderSizeLookupBindingSource
        Me.SizeCheckedComboBoxEdit.Properties.DisplayMember = "SizeCode"
        Me.SizeCheckedComboBoxEdit.Properties.ValueMember = "SizeId"
        Me.SizeCheckedComboBoxEdit.Size = New System.Drawing.Size(154, 20)
        Me.SizeCheckedComboBoxEdit.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(9, 103)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Contrast"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Color"
        '
        'ColorCheckedComboBoxEdit
        '
        Me.ColorCheckedComboBoxEdit.Location = New System.Drawing.Point(55, 19)
        Me.ColorCheckedComboBoxEdit.Name = "ColorCheckedComboBoxEdit"
        Me.ColorCheckedComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorCheckedComboBoxEdit.Properties.DataSource = Me.OrderFabricColorBindingSource
        Me.ColorCheckedComboBoxEdit.Properties.DisplayMember = "FabricColorName"
        Me.ColorCheckedComboBoxEdit.Properties.ValueMember = "OrderId"
        Me.ColorCheckedComboBoxEdit.Size = New System.Drawing.Size(154, 20)
        Me.ColorCheckedComboBoxEdit.TabIndex = 8
        '
        'FabricXtraTabPage
        '
        Me.FabricXtraTabPage.AutoScroll = True
        Me.FabricXtraTabPage.Controls.Add(Me.SplitContainer1)
        Me.FabricXtraTabPage.Name = "FabricXtraTabPage"
        Me.FabricXtraTabPage.Size = New System.Drawing.Size(1175, 157)
        Me.FabricXtraTabPage.Text = "Color And PO Details"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.OrderDetailsGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.OrderSizeDetailsGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1175, 157)
        Me.SplitContainer1.SplitterDistance = 860
        Me.SplitContainer1.TabIndex = 2
        '
        'OrderDetailsGridControl
        '
        Me.OrderDetailsGridControl.DataSource = Me.OrderDetailsBindingSource
        Me.OrderDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.OrderDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.OrderDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderDetailsGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.OrderDetailsGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.OrderDetailsGridControl.MainView = Me.GridView1
        Me.OrderDetailsGridControl.Name = "OrderDetailsGridControl"
        Me.OrderDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GarmentsColorGridLookUpEdit, Me.ETADateEdit, Me.EXGridLookUpEdit1, Me.EXDateEdit, Me.PackTypeComboBox, Me.DestinationGridLookUpEdit, Me.OrDetailsStyleIdGridLookUpEdit})
        Me.OrderDetailsGridControl.Size = New System.Drawing.Size(860, 157)
        Me.OrderDetailsGridControl.TabIndex = 0
        Me.OrderDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'OrderDetailsBindingSource
        '
        Me.OrderDetailsBindingSource.DataMember = "FK_OrderDetails_Order"
        Me.OrderDetailsBindingSource.DataSource = Me.OrderBindingSource
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorId, Me.colPrice, Me.colETA, Me.colA_S, Me.colPayBy, Me.colPO_Type, Me.colRemarks, Me.colPackType, Me.colDestinationId, Me.colOrderQuantity, Me.colCode, Me.colEX, Me.colPO, Me.colReference, Me.colIsClose, Me.colStyleId, Me.colDiscontinue, Me.colCasuseOfDiscontinue, Me.colPOGroup, Me.colPO1, Me.colPO_Type1})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(794, 34, 216, 318)
        Me.GridView1.GridControl = Me.OrderDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.AllowZoomDetail = False
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsDetail.SmartDetailExpand = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorId
        '
        Me.colFabricColorId.Caption = "Garments Color"
        Me.colFabricColorId.ColumnEdit = Me.GarmentsColorGridLookUpEdit
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 0
        Me.colFabricColorId.Width = 119
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
        Me.GarmentsColorGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GarmentsColorGridLookUpEdit.ValueMember = "FabricColorId"
        Me.GarmentsColorGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
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
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average)})
        Me.colPrice.Width = 70
        '
        'colETA
        '
        Me.colETA.ColumnEdit = Me.ETADateEdit
        Me.colETA.FieldName = "ETA"
        Me.colETA.Name = "colETA"
        Me.colETA.Visible = True
        Me.colETA.VisibleIndex = 8
        Me.colETA.Width = 109
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
        'colA_S
        '
        Me.colA_S.FieldName = "A_S"
        Me.colA_S.Name = "colA_S"
        Me.colA_S.Width = 52
        '
        'colPayBy
        '
        Me.colPayBy.FieldName = "PayBy"
        Me.colPayBy.Name = "colPayBy"
        '
        'colPO_Type
        '
        Me.colPO_Type.FieldName = "PO_Type"
        Me.colPO_Type.Name = "colPO_Type"
        Me.colPO_Type.Width = 78
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Width = 79
        '
        'colPackType
        '
        Me.colPackType.ColumnEdit = Me.PackTypeComboBox
        Me.colPackType.FieldName = "PackType"
        Me.colPackType.Name = "colPackType"
        Me.colPackType.Visible = True
        Me.colPackType.VisibleIndex = 6
        Me.colPackType.Width = 103
        '
        'PackTypeComboBox
        '
        Me.PackTypeComboBox.AutoHeight = False
        Me.PackTypeComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PackTypeComboBox.Items.AddRange(New Object() {"Normal", "Ratio", "Printers"})
        Me.PackTypeComboBox.Name = "PackTypeComboBox"
        '
        'colDestinationId
        '
        Me.colDestinationId.Caption = "Destination"
        Me.colDestinationId.ColumnEdit = Me.DestinationGridLookUpEdit
        Me.colDestinationId.FieldName = "DestinationId"
        Me.colDestinationId.Name = "colDestinationId"
        Me.colDestinationId.Width = 101
        '
        'DestinationGridLookUpEdit
        '
        Me.DestinationGridLookUpEdit.AutoHeight = False
        Me.DestinationGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DestinationGridLookUpEdit.DataSource = Me.DestinationBindingSource
        Me.DestinationGridLookUpEdit.DisplayMember = "DestinationCode"
        Me.DestinationGridLookUpEdit.Name = "DestinationGridLookUpEdit"
        Me.DestinationGridLookUpEdit.NullText = ""
        Me.DestinationGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DestinationGridLookUpEdit.ValueMember = "DestinationId"
        Me.DestinationGridLookUpEdit.View = Me.GridView11
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
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 5
        Me.colOrderQuantity.Width = 99
        '
        'colCode
        '
        Me.colCode.Caption = "Color Code"
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 3
        Me.colCode.Width = 90
        '
        'colEX
        '
        Me.colEX.ColumnEdit = Me.EXDateEdit
        Me.colEX.FieldName = "EX"
        Me.colEX.Name = "colEX"
        Me.colEX.Visible = True
        Me.colEX.VisibleIndex = 7
        Me.colEX.Width = 85
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
        Me.colPO.FieldName = "PO"
        Me.colPO.Name = "colPO"
        Me.colPO.Width = 127
        '
        'colReference
        '
        Me.colReference.Caption = "Color Referece"
        Me.colReference.FieldName = "Reference"
        Me.colReference.Name = "colReference"
        Me.colReference.Visible = True
        Me.colReference.VisibleIndex = 1
        Me.colReference.Width = 111
        '
        'colIsClose
        '
        Me.colIsClose.FieldName = "IsClose"
        Me.colIsClose.Name = "colIsClose"
        Me.colIsClose.Width = 118
        '
        'colStyleId
        '
        Me.colStyleId.Caption = "Style"
        Me.colStyleId.ColumnEdit = Me.OrDetailsStyleIdGridLookUpEdit
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
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
        Me.OrDetailsStyleIdGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrDetailsStyleIdGridLookUpEdit.ValueMember = "StyleId"
        Me.OrDetailsStyleIdGridLookUpEdit.View = Me.GridView12
        '
        'GridView12
        '
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        '
        'colDiscontinue
        '
        Me.colDiscontinue.FieldName = "Discontinue"
        Me.colDiscontinue.Name = "colDiscontinue"
        Me.colDiscontinue.Width = 85
        '
        'colCasuseOfDiscontinue
        '
        Me.colCasuseOfDiscontinue.FieldName = "CasuseOfDiscontinue"
        Me.colCasuseOfDiscontinue.Name = "colCasuseOfDiscontinue"
        Me.colCasuseOfDiscontinue.Width = 161
        '
        'colPOGroup
        '
        Me.colPOGroup.FieldName = "POGroup"
        Me.colPOGroup.Name = "colPOGroup"
        Me.colPOGroup.Width = 140
        '
        'colPO1
        '
        Me.colPO1.FieldName = "PO"
        Me.colPO1.Name = "colPO1"
        Me.colPO1.Visible = True
        Me.colPO1.VisibleIndex = 2
        '
        'colPO_Type1
        '
        Me.colPO_Type1.FieldName = "PO_Type"
        Me.colPO_Type1.Name = "colPO_Type1"
        Me.colPO_Type1.Visible = True
        Me.colPO_Type1.VisibleIndex = 4
        '
        'EXGridLookUpEdit1
        '
        Me.EXGridLookUpEdit1.AutoHeight = False
        Me.EXGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EXGridLookUpEdit1.Name = "EXGridLookUpEdit1"
        Me.EXGridLookUpEdit1.View = Me.GridView5
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
        'OrderSizeDetailsGridControl
        '
        Me.OrderSizeDetailsGridControl.DataSource = Me.OrderSizeDetailsBindingSource
        Me.OrderSizeDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.OrderSizeDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.OrderSizeDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderSizeDetailsGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.OrderSizeDetailsGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.OrderSizeDetailsGridControl.MainView = Me.GridView3
        Me.OrderSizeDetailsGridControl.Name = "OrderSizeDetailsGridControl"
        Me.OrderSizeDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SizeGridLookUpEdit})
        Me.OrderSizeDetailsGridControl.Size = New System.Drawing.Size(311, 157)
        Me.OrderSizeDetailsGridControl.TabIndex = 1
        Me.OrderSizeDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'OrderSizeDetailsBindingSource
        '
        Me.OrderSizeDetailsBindingSource.DataMember = "FK_OrderSizeDetails_OrderDetails"
        Me.OrderSizeDetailsBindingSource.DataSource = Me.OrderDetailsBindingSource
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeId, Me.colOrderQuantity1, Me.colRatio})
        Me.GridView3.GridControl = Me.OrderSizeDetailsGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
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
        Me.colSizeId.Width = 90
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
        Me.SizeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SizeGridLookUpEdit.ValueMember = "SizeId"
        Me.SizeGridLookUpEdit.View = Me.GridView6
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
        Me.colOrderQuantity1.Width = 110
        '
        'colRatio
        '
        Me.colRatio.FieldName = "Ratio"
        Me.colRatio.Name = "colRatio"
        Me.colRatio.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colRatio.Visible = True
        Me.colRatio.VisibleIndex = 2
        Me.colRatio.Width = 89
        '
        'SizeAndInstructionXtraTabPage
        '
        Me.SizeAndInstructionXtraTabPage.AutoScroll = True
        Me.SizeAndInstructionXtraTabPage.Controls.Add(Me.OrderInstructionGridControl)
        Me.SizeAndInstructionXtraTabPage.Name = "SizeAndInstructionXtraTabPage"
        Me.SizeAndInstructionXtraTabPage.Size = New System.Drawing.Size(1175, 157)
        Me.SizeAndInstructionXtraTabPage.Text = "Instruction"
        '
        'OrderInstructionGridControl
        '
        Me.OrderInstructionGridControl.DataSource = Me.OrderInstructionBindingSource
        Me.OrderInstructionGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.OrderInstructionGridControl.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.OrderInstructionGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderInstructionGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.OrderInstructionGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.OrderInstructionGridControl.MainView = Me.GridView4
        Me.OrderInstructionGridControl.Name = "OrderInstructionGridControl"
        Me.OrderInstructionGridControl.Size = New System.Drawing.Size(1175, 157)
        Me.OrderInstructionGridControl.TabIndex = 1
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
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
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
        Me.colInstructionSlNo.Width = 94
        '
        'colInstruction
        '
        Me.colInstruction.FieldName = "Instruction"
        Me.colInstruction.Name = "colInstruction"
        Me.colInstruction.Visible = True
        Me.colInstruction.VisibleIndex = 1
        Me.colInstruction.Width = 806
        '
        'colInstructionDate
        '
        Me.colInstructionDate.FieldName = "InstructionDate"
        Me.colInstructionDate.Name = "colInstructionDate"
        Me.colInstructionDate.Visible = True
        Me.colInstructionDate.VisibleIndex = 2
        Me.colInstructionDate.Width = 251
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
        'MultipartXtraTabPage
        '
        Me.MultipartXtraTabPage.AutoScroll = True
        Me.MultipartXtraTabPage.Controls.Add(Me.TwinPackDetailsGridControl)
        Me.MultipartXtraTabPage.Name = "MultipartXtraTabPage"
        Me.MultipartXtraTabPage.Size = New System.Drawing.Size(1175, 157)
        Me.MultipartXtraTabPage.Text = "Multipart"
        '
        'TwinPackDetailsGridControl
        '
        Me.TwinPackDetailsGridControl.DataSource = Me.TwinPackDetailsBindingSource
        Me.TwinPackDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TwinPackDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.TwinPackDetailsGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.TwinPackDetailsGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TwinPackDetailsGridControl.MainView = Me.GridView13
        Me.TwinPackDetailsGridControl.Name = "TwinPackDetailsGridControl"
        Me.TwinPackDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1})
        Me.TwinPackDetailsGridControl.Size = New System.Drawing.Size(1175, 157)
        Me.TwinPackDetailsGridControl.TabIndex = 0
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
        Me.GridView13.OptionsBehavior.Editable = False
        Me.GridView13.OptionsView.ShowGroupPanel = False
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
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "FabricColorId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView14
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
        'AmndHistory
        '
        Me.AmndHistory.AutoScroll = True
        Me.AmndHistory.Controls.Add(Me.OrderAmndDetailsGridControl)
        Me.AmndHistory.Name = "AmndHistory"
        Me.AmndHistory.Size = New System.Drawing.Size(1175, 157)
        Me.AmndHistory.Text = "Amendment History"
        '
        'OrderAmndDetailsGridControl
        '
        Me.OrderAmndDetailsGridControl.DataSource = Me.OrderAmndDetailsBindingSource
        Me.OrderAmndDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderAmndDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderAmndDetailsGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.OrderAmndDetailsGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.OrderAmndDetailsGridControl.MainView = Me.GridView15
        Me.OrderAmndDetailsGridControl.Name = "OrderAmndDetailsGridControl"
        Me.OrderAmndDetailsGridControl.Size = New System.Drawing.Size(1175, 157)
        Me.OrderAmndDetailsGridControl.TabIndex = 0
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
        Me.colAmndNo.Visible = True
        Me.colAmndNo.VisibleIndex = 0
        Me.colAmndNo.Width = 106
        '
        'colAmndDate
        '
        Me.colAmndDate.FieldName = "AmndDate"
        Me.colAmndDate.Name = "colAmndDate"
        Me.colAmndDate.Visible = True
        Me.colAmndDate.VisibleIndex = 1
        Me.colAmndDate.Width = 100
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 2
        Me.colDetails.Width = 945
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.AutoScroll = True
        Me.XtraTabPage2.Controls.Add(Me.GetColorListButton)
        Me.XtraTabPage2.Controls.Add(CuttingWPLabel)
        Me.XtraTabPage2.Controls.Add(Me.OrderCuttingPercentageGridControl)
        Me.XtraTabPage2.Controls.Add(Me.CuttingWPSpinEdit)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1175, 157)
        Me.XtraTabPage2.Text = "Cutting Percentage Details"
        '
        'GetColorListButton
        '
        Me.GetColorListButton.Location = New System.Drawing.Point(789, 47)
        Me.GetColorListButton.Name = "GetColorListButton"
        Me.GetColorListButton.Size = New System.Drawing.Size(122, 35)
        Me.GetColorListButton.TabIndex = 1
        Me.GetColorListButton.Text = "Get Color List"
        Me.GetColorListButton.UseVisualStyleBackColor = True
        '
        'OrderCuttingPercentageGridControl
        '
        Me.OrderCuttingPercentageGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OrderCuttingPercentageGridControl.DataSource = Me.OrderCuttingPercentageBindingSource
        Me.OrderCuttingPercentageGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderCuttingPercentageGridControl.MainView = Me.GridView20
        Me.OrderCuttingPercentageGridControl.Name = "OrderCuttingPercentageGridControl"
        Me.OrderCuttingPercentageGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.FabricColorCPGridLookUpEdit})
        Me.OrderCuttingPercentageGridControl.Size = New System.Drawing.Size(754, 156)
        Me.OrderCuttingPercentageGridControl.TabIndex = 0
        Me.OrderCuttingPercentageGridControl.UseEmbeddedNavigator = True
        Me.OrderCuttingPercentageGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView20})
        '
        'OrderCuttingPercentageBindingSource
        '
        Me.OrderCuttingPercentageBindingSource.DataMember = "Order_OrderCuttingPercentage"
        Me.OrderCuttingPercentageBindingSource.DataSource = Me.OrderBindingSource
        '
        'GridView20
        '
        Me.GridView20.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorId2, Me.colCuttingPercentage, Me.colPrinting, Me.colEmbroidery, Me.colWashing, Me.colSewing, Me.colFinishing})
        Me.GridView20.GridControl = Me.OrderCuttingPercentageGridControl
        Me.GridView20.Name = "GridView20"
        Me.GridView20.OptionsView.ShowGroupPanel = False
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
        Me.FabricColorCPGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricColorCPGridLookUpEdit.ValueMember = "FabricColorId"
        Me.FabricColorCPGridLookUpEdit.View = Me.GridView21
        '
        'GridView21
        '
        Me.GridView21.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView21.Name = "GridView21"
        Me.GridView21.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView21.OptionsView.ShowGroupPanel = False
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
        Me.CuttingWPSpinEdit.Location = New System.Drawing.Point(843, 21)
        Me.CuttingWPSpinEdit.Name = "CuttingWPSpinEdit"
        Me.CuttingWPSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CuttingWPSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.CuttingWPSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CuttingWPSpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.CuttingWPSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CuttingWPSpinEdit.Size = New System.Drawing.Size(68, 20)
        Me.CuttingWPSpinEdit.TabIndex = 72
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.AutoScroll = True
        Me.XtraTabPage3.Controls.Add(Me.FinishingProcessGridControl)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1175, 157)
        Me.XtraTabPage3.Text = "Finishing Process"
        '
        'FinishingProcessGridControl
        '
        Me.FinishingProcessGridControl.DataSource = Me.FinishingProcessBindingSource
        Me.FinishingProcessGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FinishingProcessGridControl.Location = New System.Drawing.Point(0, 0)
        Me.FinishingProcessGridControl.MainView = Me.GridView22
        Me.FinishingProcessGridControl.Name = "FinishingProcessGridControl"
        Me.FinishingProcessGridControl.Size = New System.Drawing.Size(1175, 157)
        Me.FinishingProcessGridControl.TabIndex = 0
        Me.FinishingProcessGridControl.UseEmbeddedNavigator = True
        Me.FinishingProcessGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView22})
        '
        'FinishingProcessBindingSource
        '
        Me.FinishingProcessBindingSource.DataMember = "Order_FinishingProcess"
        Me.FinishingProcessBindingSource.DataSource = Me.OrderBindingSource
        '
        'GridView22
        '
        Me.GridView22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFinishingProcessId, Me.colOrderId3, Me.colFinishingProcess})
        Me.GridView22.GridControl = Me.FinishingProcessGridControl
        Me.GridView22.Name = "GridView22"
        '
        'colFinishingProcessId
        '
        Me.colFinishingProcessId.FieldName = "FinishingProcessId"
        Me.colFinishingProcessId.Name = "colFinishingProcessId"
        Me.colFinishingProcessId.OptionsColumn.ReadOnly = True
        '
        'colOrderId3
        '
        Me.colOrderId3.FieldName = "OrderId"
        Me.colOrderId3.Name = "colOrderId3"
        '
        'colFinishingProcess
        '
        Me.colFinishingProcess.FieldName = "FinishingProcess"
        Me.colFinishingProcess.Name = "colFinishingProcess"
        Me.colFinishingProcess.Visible = True
        Me.colFinishingProcess.VisibleIndex = 0
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FabricForSizeTableAdapter = Me.FabricForSizeTableAdapter
        Me.TableAdapterManager.FabricTableAdapter = Me.FabricTableAdapter
        Me.TableAdapterManager.FinishingProcessTableAdapter = Me.FinishingProcessTableAdapter
        Me.TableAdapterManager.FROrderProcessTableAdapter = Nothing
        Me.TableAdapterManager.OrderActivitiesPredecessorTableAdapter = Nothing
        Me.TableAdapterManager.OrderActivitiesTableAdapter = Nothing
        Me.TableAdapterManager.OrderAmndDetailsTableAdapter = Me.OrderAmndDetailsTableAdapter
        Me.TableAdapterManager.OrderCPTableAdapter = Nothing
        Me.TableAdapterManager.OrderCuttingPercentageTableAdapter = Me.OrderCuttingPercentageTableAdapter
        Me.TableAdapterManager.OrderDetailsTableAdapter = Me.OrderDetailsTableAdapter
        Me.TableAdapterManager.OrderGarmentsPartTableAdapter = Nothing
        Me.TableAdapterManager.OrderInstructionTableAdapter = Me.OrderInstructionTableAdapter
        Me.TableAdapterManager.OrderPictureTableAdapter = Nothing
        Me.TableAdapterManager.OrderSizeDetailsTableAdapter = Me.OrderSizeDetailsTableAdapter
        Me.TableAdapterManager.OrderTableAdapter = Me.OrderTableAdapter
        Me.TableAdapterManager.OrderTrimTableAdapter = Nothing
        Me.TableAdapterManager.TwinPackDetailsTableAdapter = Me.TwinPackDetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.OrderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FabricForSizeTableAdapter
        '
        Me.FabricForSizeTableAdapter.ClearBeforeFill = True
        '
        'FabricTableAdapter
        '
        Me.FabricTableAdapter.ClearBeforeFill = True
        '
        'FinishingProcessTableAdapter
        '
        Me.FinishingProcessTableAdapter.ClearBeforeFill = True
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
        'OrderSizeLookupTableAdapter
        '
        Me.OrderSizeLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'frmFabricConsumptionNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 603)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.KeyPreview = True
        Me.Name = "frmFabricConsumptionNew"
        Me.Text = "Order Fabric Consumption"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.UserIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupByStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.OrderExDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderExDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleReferenceNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsMultiPartCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsEmbroideryCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvOrderIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleNameIdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.CopyTextBox, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.ConItemCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KgPerUnitCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsConCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.CColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricForSizeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricForSizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContrastColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FabricXtraTabPage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.OrderDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETADateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETADateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackTypeComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrDetailsStyleIdGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SizeAndInstructionXtraTabPage.ResumeLayout(False)
        CType(Me.OrderInstructionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderInstructionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MultipartXtraTabPage.ResumeLayout(False)
        CType(Me.TwinPackDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TwinPackDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AmndHistory.ResumeLayout(False)
        CType(Me.OrderAmndDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderAmndDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.OrderCuttingPercentageGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderCuttingPercentageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorCPGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingWPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.FinishingProcessGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishingProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents OrderExDateDateEdit As DevExpress.XtraEditors.DateEdit
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
    Friend WithEvents IsEmbroideryCheckEdit As DevExpress.XtraEditors.CheckEdit
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colA_S As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colIsClose As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCasuseOfDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents SizeAndInstructionXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents FabricXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents OrderSizeDetailsTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.OrderSizeDetailsTableAdapter
    Friend WithEvents OrderSizeDetailsBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents colDyeingTypeId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIsAllOverPrint As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colKnittingTypeId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompositionId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDiaUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFinishFabricDia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDiaType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFinishUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarkerLengthYrds As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarkerLengthInch As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarkerWidth As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWidthAllowance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLengthAllowance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWastagePercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGMQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents AmendmentNoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AmndHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDivisionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGarmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeasonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDivisionName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeasonName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName1 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents CompanyIdComboBox As System.Windows.Forms.ComboBox
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
    Friend WithEvents colCon As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents OrderSizeDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRatio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents OrderSizeDataSet As KSoft_Apparel.OrderSizeDataSet
    Friend WithEvents OrderSizeLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderSizeLookupTableAdapter As KSoft_Apparel.OrderSizeDataSetTableAdapters.OrderSizeLookupTableAdapter
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SizeCheckedComboBoxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ColorCheckedComboBoxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents SetColorAndSizeButton As System.Windows.Forms.Button
    Friend WithEvents FabricForSizeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FabricForSizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricForSizeTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.FabricForSizeTableAdapter
    Friend WithEvents ConItemCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents IsConCompleteCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ConDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colFabricQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContrastColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContrastColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CuttingWPSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CColorGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView19 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorName3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SetCColorButton As System.Windows.Forms.Button
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colGSM1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLength As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colKgPerUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents CopyTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colGreyWastagePercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents OrderCuttingPercentageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderCuttingPercentageTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.OrderCuttingPercentageTableAdapter
    Friend WithEvents OrderCuttingPercentageGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView20 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuttingPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrinting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmbroidery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWashing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricColorCPGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GetColorListButton As System.Windows.Forms.Button
    Friend WithEvents colPO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO_Type1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuttingPercentage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KgPerUnitCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents FinishingProcessBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinishingProcessTableAdapter As KSoft_Apparel.OrderDataSetTableAdapters.FinishingProcessTableAdapter
    Friend WithEvents FinishingProcessGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFinishingProcessId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishingProcess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
End Class
