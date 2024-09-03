<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPreCosting
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
        Dim MachineQuantityLabel As System.Windows.Forms.Label
        Dim ProdPerDayLabel As System.Windows.Forms.Label
        Dim FactoryCMLabel As System.Windows.Forms.Label
        Dim BuyerCMLabel As System.Windows.Forms.Label
        Dim MarginPercentageLabel As System.Windows.Forms.Label
        Dim ProcessLossPercentageLabel As System.Windows.Forms.Label
        Dim TTLCostLabel As System.Windows.Forms.Label
        Dim FactoryCMLabel1 As System.Windows.Forms.Label
        Dim OfferPricePcsLabel As System.Windows.Forms.Label
        Dim FabricFinishing_CostLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.ItemListLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Apparel.ItemListLookupDataSet()
        Me.GarmentPartLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GarmentsPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartDataSet = New KSoft_Apparel.GarmentsPartDataSet()
        Me.KnittingtypeLookupEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet()
        Me.CompositionLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet()
        Me.GSMItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GSMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSMDataSet = New KSoft_Apparel.GSMDataSet()
        Me.PreCostingDataSet = New KSoft_Apparel.PreCostingDataSet()
        Me.PreCostingMainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreCostingMainTableAdapter = New KSoft_Apparel.PreCostingDataSetTableAdapters.PreCostingMainTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.PreCostingDataSetTableAdapters.TableAdapterManager()
        Me.PreCosting_CMTableAdapter = New KSoft_Apparel.PreCostingDataSetTableAdapters.PreCosting_CMTableAdapter()
        Me.PreCosting_TrimsTableAdapter = New KSoft_Apparel.PreCostingDataSetTableAdapters.PreCosting_TrimsTableAdapter()
        Me.PreCosting_YarnTableAdapter = New KSoft_Apparel.PreCostingDataSetTableAdapters.PreCosting_YarnTableAdapter()
        Me.PreCostingFabricFinishingTableAdapter = New KSoft_Apparel.PreCostingDataSetTableAdapters.PreCostingFabricFinishingTableAdapter()
        Me.PreCostingFabricTableAdapter = New KSoft_Apparel.PreCostingDataSetTableAdapters.PreCostingFabricTableAdapter()
        Me.PreCostingOthersTableAdapter = New KSoft_Apparel.PreCostingDataSetTableAdapters.PreCostingOthersTableAdapter()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Apparel.CompanyDataSet()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.StyleIdLabel = New System.Windows.Forms.LinkLabel()
        Me.CancelCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.CompleteCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ApprovalCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.SpinEdit3 = New DevExpress.XtraEditors.SpinEdit()
        Me.Washing_CostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.OrderLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupByStyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricFinishing_CostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.OfferPrice0TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OfferPricePcsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FactoryCMSpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.TTLCostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProcessLossPercentageSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ActProfitSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.MarginPercentageSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.StyleIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDefaultTarget = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateCostButton = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PrecostingGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PreCostingProgramLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreCostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FilterButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PreCostingNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RemarksTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FO_CostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Print_CostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AmndSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SubStyleSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit()
        Me.Yarn_CostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Dyeing_CostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.Yds_CostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Knitting_CostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AOP_CostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EMB_CostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.OrderQuantityCPSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.OrderQuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Trim_CostSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PreCostingDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CompanyIdLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.GSMTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.FabricTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.CopyFabricButton = New System.Windows.Forms.Button()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.SizeCheckedComboBoxEdit = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.OrderSizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderSizeDataSet = New KSoft_Apparel.OrderSizeDataSet()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ColorCheckedComboBoxEdit = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet()
        Me.GPFFButton = New System.Windows.Forms.Button()
        Me.PreCostingFabricGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PreCostingFabricBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreCostingFabBandedGridView = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colGarmentsPartId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GarmentsPartGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGarmentsPartId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colKnittingTypeId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.KnittingTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKnittingTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKnittingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscontinue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKnittingTypeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompositionId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.CompositionGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCompositionId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComposition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscontinue1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSMId1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GSMGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGSMId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSMCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFDia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDiaType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DiaTypeComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDiaUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DiaUnitComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDyeingType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DyeingTypeLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DyeingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DyeingTypeDataSet = New KSoft_Apparel.DyeingTypeDataSet()
        Me.colOrderQuantity1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colConsumption = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFinishUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.FinishUnitComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colKgPerUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colWastagePercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colBQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colYarn_Cost1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colYds_Cost1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colKnitting_Cost1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDyeing_Cost1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFinishing_Cost = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAOP_Cost1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAOP_WP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProcessLossPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGQty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colAdditionalQuantity1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTTLFabricCost = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colKnitting_Cost_Dzn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCCCostPerDzn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCCSize = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLength = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colForSize = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colForColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GetFabricButton = New System.Windows.Forms.Button()
        Me.GetYarnButton = New System.Windows.Forms.Button()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.PreCosting_YarnGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PreCosting_YarnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreCostingYarnGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPreCostingYarnId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreCostingFabricId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YarnListGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWastagePercentage1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYds_Cost2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarn_Cost2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLot_No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PreCostingFabricFinishingGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PreCostingFabricFinishingBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPreCostingFabricFinishingId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreCostingFabricId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricFinishingTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricFinishingTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FabricFinishingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricFinishingTypeDataSet = New KSoft_Apparel.FabricFinishingTypeDataSet()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFinishingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPricePerKg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TrimTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Size2CheckedComboBoxEdit = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Color2CheckedComboBoxEdit = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.AccessoriesCategoryLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesCategoryLookupDataSet = New KSoft_Apparel.AccessoriesCategoryLookupDataSet()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.WPercSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ConPCSSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.UnitIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ConSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.AccLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.AccNameGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TrimListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrimListLookupDataSet = New KSoft_Apparel.TrimListLookupDataSet()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PreCosting_TrimsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PreCosting_TrimsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccessoriesId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccessoriesListGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsumption1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWastagePercentage2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ConUnitItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGarmentsQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequireQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsAll = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForColor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForSize1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdditionalQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TrimItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.AccessoriesListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesListDataSet = New KSoft_Apparel.AccessoriesListDataSet()
        Me.GetOrQtyTrimsButton = New System.Windows.Forms.Button()
        Me.GetAccessoriesButton = New System.Windows.Forms.Button()
        Me.CMTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.PreCostingTargetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.fieldSL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEfficiency1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOrderQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldLine1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PreCostingOthersGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PreCostingOthersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCostItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForPcs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostPerDzn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLCost1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RefreshLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.DefultMiscButton = New System.Windows.Forms.Button()
        Me.PreCosting_CMGridControl = New DevExpress.XtraGrid.GridControl()
        Me.PreCosting_CMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreCostingCMGridView = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colStyleId1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.SubStyleGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView18 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colProductionPerHour = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colBUYER_CM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFACTORY_CM = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMachineQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCostPerMCPerHour = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCostPerMinute = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSMV1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLineQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDayRequire = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colEfficiency = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLayoutId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.LayoutGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SewingLayoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SewingLayoutLookupDataSet = New KSoft_Apparel.SewingLayoutLookupDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSewingLayoutNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLayoutDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand9 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colEmbCostDzn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colEmbWP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrintCostDzn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrintWP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colWashCostDzn = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colWashWP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GetCMButton = New System.Windows.Forms.Button()
        Me.BuyerCMSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.MachineQuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.FactoryCMSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.SMVSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ProdPerDaySpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.ProgramLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CM_FirstLayoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingMakingDataSet = New KSoft_Apparel.CuttingMakingDataSet()
        Me.AccessoriesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New KSoft_Apparel.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter()
        Me.GarmentsPartTableAdapter = New KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter()
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter()
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.AccessoriesListTableAdapter = New KSoft_Apparel.AccessoriesListDataSetTableAdapters.AccessoriesListTableAdapter()
        Me.GSMTableAdapter = New KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter()
        Me.PreCostingProgramLookupTableAdapter = New KSoft_Apparel.PreCostingDataSetTableAdapters.PreCostingProgramLookupTableAdapter()
        Me.PreCostingMainPreCostingTrimsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesListLookupTableAdapter = New KSoft_Apparel.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter()
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.CM_FirstLayoutTableAdapter = New KSoft_Apparel.CuttingMakingDataSetTableAdapters.CM_FirstLayoutTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Apparel.CuttingMakingDataSetTableAdapters.TableAdapterManager()
        Me.SewingLayoutTableAdapter = New KSoft_Apparel.SewingLayoutLookupDataSetTableAdapters.SewingLayoutTableAdapter()
        Me.PreCostingFabricFinishingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricFinishingTypeTableAdapter = New KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.FabricFinishingTypeTableAdapter()
        Me.DyeingTypeTableAdapter = New KSoft_Apparel.DyeingTypeDataSetTableAdapters.DyeingTypeTableAdapter()
        Me.TrimListLookupTableAdapter = New KSoft_Apparel.TrimListLookupDataSetTableAdapters.TrimListLookupTableAdapter()
        Me.AccessoriesCategoryLookupTableAdapter = New KSoft_Apparel.AccessoriesCategoryLookupDataSetTableAdapters.AccessoriesCategoryLookupTableAdapter()
        Me.OrderLookupByStyleTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupByStyleTableAdapter()
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgramLookupTableAdapter = New KSoft_Apparel.PreCostingDataSetTableAdapters.ProgramLookupTableAdapter()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.OrderSizeLookupTableAdapter = New KSoft_Apparel.OrderSizeDataSetTableAdapters.OrderSizeLookupTableAdapter()
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter()
        Me.PreCostingTargetTableAdapter = New KSoft_Apparel.PreCostingDataSetTableAdapters.PreCostingTargetTableAdapter()
        MachineQuantityLabel = New System.Windows.Forms.Label()
        ProdPerDayLabel = New System.Windows.Forms.Label()
        FactoryCMLabel = New System.Windows.Forms.Label()
        BuyerCMLabel = New System.Windows.Forms.Label()
        MarginPercentageLabel = New System.Windows.Forms.Label()
        ProcessLossPercentageLabel = New System.Windows.Forms.Label()
        TTLCostLabel = New System.Windows.Forms.Label()
        FactoryCMLabel1 = New System.Windows.Forms.Label()
        OfferPricePcsLabel = New System.Windows.Forms.Label()
        FabricFinishing_CostLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CType(Me.ItemListLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentPartLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingtypeLookupEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingMainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovalCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Washing_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupByStyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricFinishing_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfferPrice0TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfferPricePcsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactoryCMSpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTLCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProcessLossPercentageSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActProfitSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarginPercentageSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PrecostingGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FO_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Print_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmndSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubStyleSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Yarn_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dyeing_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Yds_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Knitting_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AOP_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMB_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderQuantityCPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trim_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyIdLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.FabricTabPage.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SizeCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingFabricGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingFabricBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingFabBandedGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaTypeComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaUnitComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishUnitComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.PreCosting_YarnGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCosting_YarnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingYarnGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnListGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingFabricFinishingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingFabricFinishingBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricFinishingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricFinishingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricFinishingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TrimTabPage.SuspendLayout()
        CType(Me.Size2CheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color2CheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesCategoryLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WPercSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConPCSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccNameGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrimListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrimListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCosting_TrimsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCosting_TrimsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesListGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConUnitItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrimItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMTabPage.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingTargetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingOthersGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingOthersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCosting_CMGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCosting_CMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingCMGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubStyleGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingLayoutLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerCMSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FactoryCMSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMVSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdPerDaySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM_FirstLayoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingMakingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingMainPreCostingTrimsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingFabricFinishingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MachineQuantityLabel
        '
        MachineQuantityLabel.AutoSize = True
        MachineQuantityLabel.Location = New System.Drawing.Point(15, 32)
        MachineQuantityLabel.Name = "MachineQuantityLabel"
        MachineQuantityLabel.Size = New System.Drawing.Size(95, 13)
        MachineQuantityLabel.TabIndex = 32
        MachineQuantityLabel.Text = "Machine Quantity:"
        '
        'ProdPerDayLabel
        '
        ProdPerDayLabel.AutoSize = True
        ProdPerDayLabel.Location = New System.Drawing.Point(296, 32)
        ProdPerDayLabel.Name = "ProdPerDayLabel"
        ProdPerDayLabel.Size = New System.Drawing.Size(78, 13)
        ProdPerDayLabel.TabIndex = 33
        ProdPerDayLabel.Text = "Prod Per Hour:"
        '
        'FactoryCMLabel
        '
        FactoryCMLabel.AutoSize = True
        FactoryCMLabel.Location = New System.Drawing.Point(461, 32)
        FactoryCMLabel.Name = "FactoryCMLabel"
        FactoryCMLabel.Size = New System.Drawing.Size(66, 13)
        FactoryCMLabel.TabIndex = 34
        FactoryCMLabel.Text = "Factory CM:"
        '
        'BuyerCMLabel
        '
        BuyerCMLabel.AutoSize = True
        BuyerCMLabel.Location = New System.Drawing.Point(605, 32)
        BuyerCMLabel.Name = "BuyerCMLabel"
        BuyerCMLabel.Size = New System.Drawing.Size(57, 13)
        BuyerCMLabel.TabIndex = 35
        BuyerCMLabel.Text = "Buyer CM:"
        '
        'MarginPercentageLabel
        '
        MarginPercentageLabel.AutoSize = True
        MarginPercentageLabel.Location = New System.Drawing.Point(1069, 107)
        MarginPercentageLabel.Name = "MarginPercentageLabel"
        MarginPercentageLabel.Size = New System.Drawing.Size(71, 13)
        MarginPercentageLabel.TabIndex = 51
        MarginPercentageLabel.Text = "Ex. Margin %:"
        '
        'ProcessLossPercentageLabel
        '
        ProcessLossPercentageLabel.AutoSize = True
        ProcessLossPercentageLabel.Location = New System.Drawing.Point(861, 133)
        ProcessLossPercentageLabel.Name = "ProcessLossPercentageLabel"
        ProcessLossPercentageLabel.Size = New System.Drawing.Size(112, 13)
        ProcessLossPercentageLabel.TabIndex = 52
        ProcessLossPercentageLabel.Text = "Cutting Percentage %:"
        '
        'TTLCostLabel
        '
        TTLCostLabel.AutoSize = True
        TTLCostLabel.Location = New System.Drawing.Point(1069, 132)
        TTLCostLabel.Name = "TTLCostLabel"
        TTLCostLabel.Size = New System.Drawing.Size(72, 13)
        TTLCostLabel.TabIndex = 53
        TTLCostLabel.Text = "TTLCost/Dz :"
        '
        'FactoryCMLabel1
        '
        FactoryCMLabel1.AutoSize = True
        FactoryCMLabel1.Location = New System.Drawing.Point(861, 86)
        FactoryCMLabel1.Name = "FactoryCMLabel1"
        FactoryCMLabel1.Size = New System.Drawing.Size(64, 13)
        FactoryCMLabel1.TabIndex = 55
        FactoryCMLabel1.Text = "Factory CM:"
        '
        'OfferPricePcsLabel
        '
        OfferPricePcsLabel.AutoSize = True
        OfferPricePcsLabel.Location = New System.Drawing.Point(1069, 155)
        OfferPricePcsLabel.Name = "OfferPricePcsLabel"
        OfferPricePcsLabel.Size = New System.Drawing.Size(77, 13)
        OfferPricePcsLabel.TabIndex = 56
        OfferPricePcsLabel.Text = "TTLCost/ Pcs:"
        '
        'FabricFinishing_CostLabel
        '
        FabricFinishing_CostLabel.AutoSize = True
        FabricFinishing_CostLabel.Location = New System.Drawing.Point(496, 160)
        FabricFinishing_CostLabel.Name = "FabricFinishing_CostLabel"
        FabricFinishing_CostLabel.Size = New System.Drawing.Size(77, 13)
        FabricFinishing_CostLabel.TabIndex = 63
        FabricFinishing_CostLabel.Text = "Fab. Fini. Cost:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(1069, 186)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(87, 13)
        Label5.TabIndex = 56
        Label5.Text = "FOB$ Price/Pcs:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(179, 32)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(27, 13)
        Label6.TabIndex = 34
        Label6.Text = "SMV"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(1069, 211)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(67, 13)
        Label10.TabIndex = 51
        Label10.Text = "Act. Profit %:"
        '
        'ItemListLookUpEdit
        '
        Me.ItemListLookUpEdit.AutoHeight = False
        Me.ItemListLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemListLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemId", "Item Id", 58, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentId", "Department Id", 80, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.ItemListLookUpEdit.DataSource = Me.ItemListBindingSource
        Me.ItemListLookUpEdit.DisplayMember = "ItemName"
        Me.ItemListLookUpEdit.Name = "ItemListLookUpEdit"
        Me.ItemListLookUpEdit.NullText = ""
        Me.ItemListLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.ItemListLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemListLookUpEdit.ValueMember = "ItemId"
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListLookupDataSetBindingSource
        '
        'ItemListLookupDataSetBindingSource
        '
        Me.ItemListLookupDataSetBindingSource.DataSource = Me.ItemListLookupDataSet
        Me.ItemListLookupDataSetBindingSource.Position = 0
        '
        'ItemListLookupDataSet
        '
        Me.ItemListLookupDataSet.DataSetName = "ItemListLookupDataSet"
        Me.ItemListLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GarmentPartLookUpEdit
        '
        Me.GarmentPartLookUpEdit.AutoHeight = False
        Me.GarmentPartLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GarmentPartLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GarmentsPartId", "Garments Part Id", 105, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.GarmentPartLookUpEdit.DataSource = Me.GarmentsPartBindingSource
        Me.GarmentPartLookUpEdit.DisplayMember = "Name"
        Me.GarmentPartLookUpEdit.Name = "GarmentPartLookUpEdit"
        Me.GarmentPartLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.GarmentPartLookUpEdit.ValueMember = "GarmentsPartId"
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
        'KnittingtypeLookupEdit
        '
        Me.KnittingtypeLookupEdit.AutoHeight = False
        Me.KnittingtypeLookupEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KnittingtypeLookupEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KnittingTypeId", "Knitting Type Id", 99, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KnittingTypeCode", "Knitting Type Code", 101, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KnittingType", "Knitting Type", 73, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.KnittingtypeLookupEdit.DataSource = Me.KnittingTypeBindingSource
        Me.KnittingtypeLookupEdit.DisplayMember = "KnittingType"
        Me.KnittingtypeLookupEdit.Name = "KnittingtypeLookupEdit"
        Me.KnittingtypeLookupEdit.NullText = ""
        Me.KnittingtypeLookupEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.KnittingtypeLookupEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.KnittingtypeLookupEdit.ValueMember = "KnittingTypeId"
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
        'CompositionLookUpEdit
        '
        Me.CompositionLookUpEdit.AutoHeight = False
        Me.CompositionLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompositionLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompositionId", "Composition Id", 94, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Composition", "Composition", 68, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CompositionLookUpEdit.DataSource = Me.CompositionBindingSource
        Me.CompositionLookUpEdit.DisplayMember = "Composition"
        Me.CompositionLookUpEdit.Name = "CompositionLookUpEdit"
        Me.CompositionLookUpEdit.NullText = ""
        Me.CompositionLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CompositionLookUpEdit.ValueMember = "CompositionId"
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
        'GSMItemLookUpEdit
        '
        Me.GSMItemLookUpEdit.AutoHeight = False
        Me.GSMItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GSMItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GSMId", "GSMId", 54, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GSM", "GSM", 31, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GSMCode", "GSM Code", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.GSMItemLookUpEdit.DataSource = Me.GSMBindingSource
        Me.GSMItemLookUpEdit.DisplayMember = "GSM"
        Me.GSMItemLookUpEdit.Name = "GSMItemLookUpEdit"
        Me.GSMItemLookUpEdit.NullText = ""
        Me.GSMItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GSMItemLookUpEdit.ValueMember = "GSMId"
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
        'PreCostingDataSet
        '
        Me.PreCostingDataSet.DataSetName = "PreCostingDataSet"
        Me.PreCostingDataSet.EnforceConstraints = False
        Me.PreCostingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PreCostingMainBindingSource
        '
        Me.PreCostingMainBindingSource.DataMember = "PreCostingMain"
        Me.PreCostingMainBindingSource.DataSource = Me.PreCostingDataSet
        '
        'PreCostingMainTableAdapter
        '
        Me.PreCostingMainTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PreCosting_CMTableAdapter = Me.PreCosting_CMTableAdapter
        Me.TableAdapterManager.PreCosting_TrimsTableAdapter = Me.PreCosting_TrimsTableAdapter
        Me.TableAdapterManager.PreCosting_YarnTableAdapter = Me.PreCosting_YarnTableAdapter
        Me.TableAdapterManager.PreCostingFabricFinishingTableAdapter = Me.PreCostingFabricFinishingTableAdapter
        Me.TableAdapterManager.PreCostingFabricTableAdapter = Me.PreCostingFabricTableAdapter
        Me.TableAdapterManager.PreCostingMainTableAdapter = Me.PreCostingMainTableAdapter
        Me.TableAdapterManager.PreCostingOthersTableAdapter = Me.PreCostingOthersTableAdapter
        Me.TableAdapterManager.PreCostingTargetTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PreCostingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PreCosting_CMTableAdapter
        '
        Me.PreCosting_CMTableAdapter.ClearBeforeFill = True
        '
        'PreCosting_TrimsTableAdapter
        '
        Me.PreCosting_TrimsTableAdapter.ClearBeforeFill = True
        '
        'PreCosting_YarnTableAdapter
        '
        Me.PreCosting_YarnTableAdapter.ClearBeforeFill = True
        '
        'PreCostingFabricFinishingTableAdapter
        '
        Me.PreCostingFabricFinishingTableAdapter.ClearBeforeFill = True
        '
        'PreCostingFabricTableAdapter
        '
        Me.PreCostingFabricTableAdapter.ClearBeforeFill = True
        '
        'PreCostingOthersTableAdapter
        '
        Me.PreCostingOthersTableAdapter.ClearBeforeFill = True
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
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.EnforceConstraints = False
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label32)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MemoEdit1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BuyerGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinkLabel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinkLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StyleIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CancelCheckEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CompleteCheckEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ApprovalCheckEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SpinEdit3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Washing_CostSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label22)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label23)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label24)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OrderLookupGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(FabricFinishing_CostLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FabricFinishing_CostSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Label5)
        Me.SplitContainer1.Panel1.Controls.Add(OfferPricePcsLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OfferPrice0TextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OfferPricePcsTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(FactoryCMLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FactoryCMSpinEdit1)
        Me.SplitContainer1.Panel1.Controls.Add(TTLCostLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TTLCostTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(ProcessLossPercentageLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProcessLossPercentageSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Label10)
        Me.SplitContainer1.Panel1.Controls.Add(MarginPercentageLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ActProfitSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MarginPercentageSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StyleIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label20)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label31)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label30)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PreCostingNoTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RemarksTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FO_CostSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Print_CostSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AmndSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SubStyleSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SpinEdit2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Yarn_CostSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Dyeing_CostSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SpinEdit1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Yds_CostSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Knitting_CostSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AOP_CostSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EMB_CostSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OrderQuantityCPSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OrderQuantitySpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Trim_CostSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PreCostingDateDateEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CompanyIdLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GSMTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextEdit2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1297, 690)
        Me.SplitContainer1.SplitterDistance = 259
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(690, 195)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(33, 13)
        Me.Label32.TabIndex = 81
        Me.Label32.Text = "Note:"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "Comments", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(693, 211)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MemoEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.MemoEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MemoEdit1.Size = New System.Drawing.Size(367, 36)
        Me.MemoEdit1.TabIndex = 80
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "BuyerId", True))
        Me.BuyerGridLookUpEdit.EditValue = "[Select your Program]"
        Me.BuyerGridLookUpEdit.Location = New System.Drawing.Point(146, 82)
        Me.BuyerGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.BuyerGridLookUpEdit.Properties.Appearance.Options.UseBackColor = True
        Me.BuyerGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerGridLookUpEdit.Properties.NullText = ""
        Me.BuyerGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerGridLookUpEdit.Properties.PopupView = Me.GridView16
        Me.BuyerGridLookUpEdit.Properties.ReadOnly = True
        Me.BuyerGridLookUpEdit.Properties.Tag = "NR"
        Me.BuyerGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerGridLookUpEdit.Size = New System.Drawing.Size(114, 20)
        Me.BuyerGridLookUpEdit.TabIndex = 79
        Me.BuyerGridLookUpEdit.Tag = "NR"
        '
        'GridView16
        '
        Me.GridView16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName})
        Me.GridView16.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView16.Name = "GridView16"
        Me.GridView16.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView16.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 0
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(272, 136)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(80, 13)
        Me.LinkLabel2.TabIndex = 78
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Or. Qty with C%"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 140)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 13)
        Me.LinkLabel1.TabIndex = 78
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Program No (F11) :"
        '
        'StyleIdLabel
        '
        Me.StyleIdLabel.AutoSize = True
        Me.StyleIdLabel.Location = New System.Drawing.Point(9, 61)
        Me.StyleIdLabel.Name = "StyleIdLabel"
        Me.StyleIdLabel.Size = New System.Drawing.Size(83, 13)
        Me.StyleIdLabel.TabIndex = 78
        Me.StyleIdLabel.TabStop = True
        Me.StyleIdLabel.Text = "Style No ( F11) :"
        '
        'CancelCheckEdit
        '
        Me.CancelCheckEdit.Enabled = False
        Me.CancelCheckEdit.Location = New System.Drawing.Point(417, 212)
        Me.CancelCheckEdit.Name = "CancelCheckEdit"
        Me.CancelCheckEdit.Properties.Caption = "Cancelled"
        Me.CancelCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.CancelCheckEdit.TabIndex = 77
        '
        'CompleteCheckEdit
        '
        Me.CompleteCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "IsComplete", True))
        Me.CompleteCheckEdit.Location = New System.Drawing.Point(146, 212)
        Me.CompleteCheckEdit.Name = "CompleteCheckEdit"
        Me.CompleteCheckEdit.Properties.Caption = "Completed"
        Me.CompleteCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.CompleteCheckEdit.TabIndex = 77
        '
        'ApprovalCheckEdit
        '
        Me.ApprovalCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "IsApproved", True))
        Me.ApprovalCheckEdit.Enabled = False
        Me.ApprovalCheckEdit.Location = New System.Drawing.Point(336, 212)
        Me.ApprovalCheckEdit.Name = "ApprovalCheckEdit"
        Me.ApprovalCheckEdit.Properties.Caption = "Approved"
        Me.ApprovalCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.ApprovalCheckEdit.TabIndex = 77
        '
        'SpinEdit3
        '
        Me.SpinEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "TTLFabCost", True))
        Me.SpinEdit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit3.Location = New System.Drawing.Point(584, 204)
        Me.SpinEdit3.Name = "SpinEdit3"
        Me.SpinEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SpinEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.SpinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit3.Properties.ReadOnly = True
        Me.SpinEdit3.Size = New System.Drawing.Size(88, 20)
        Me.SpinEdit3.TabIndex = 66
        '
        'Washing_CostSpinEdit
        '
        Me.Washing_CostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "Wash_Cost", True))
        Me.Washing_CostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Washing_CostSpinEdit.Location = New System.Drawing.Point(749, 104)
        Me.Washing_CostSpinEdit.Name = "Washing_CostSpinEdit"
        Me.Washing_CostSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Washing_CostSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Washing_CostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Washing_CostSpinEdit.Properties.ReadOnly = True
        Me.Washing_CostSpinEdit.Size = New System.Drawing.Size(88, 20)
        Me.Washing_CostSpinEdit.TabIndex = 66
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(272, 110)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(81, 13)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Order Quantity :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(690, 141)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 13)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "Comments:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(690, 109)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 13)
        Me.Label24.TabIndex = 65
        Me.Label24.Text = "Washing:"
        '
        'OrderLookupGridLookUpEdit
        '
        Me.OrderLookupGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "OrderId", True))
        Me.OrderLookupGridLookUpEdit.EditValue = "[Select your Program]"
        Me.OrderLookupGridLookUpEdit.Enabled = False
        Me.OrderLookupGridLookUpEdit.Location = New System.Drawing.Point(146, 134)
        Me.OrderLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.OrderLookupGridLookUpEdit.Name = "OrderLookupGridLookUpEdit"
        Me.OrderLookupGridLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.OrderLookupGridLookUpEdit.Properties.Appearance.Options.UseBackColor = True
        Me.OrderLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderLookupGridLookUpEdit.Properties.DataSource = Me.OrderLookupByStyleBindingSource
        Me.OrderLookupGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.OrderLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderLookupGridLookUpEdit.Properties.NullText = "Select your Program"
        Me.OrderLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderLookupGridLookUpEdit.Properties.PopupView = Me.GridView14
        Me.OrderLookupGridLookUpEdit.Properties.ReadOnly = True
        Me.OrderLookupGridLookUpEdit.Properties.Tag = "NR"
        Me.OrderLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderLookupGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderLookupGridLookUpEdit.Size = New System.Drawing.Size(116, 20)
        Me.OrderLookupGridLookUpEdit.TabIndex = 48
        Me.OrderLookupGridLookUpEdit.Tag = "NR"
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
        'GridView14
        '
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo2})
        Me.GridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView14.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo2
        '
        Me.colProgramNo2.FieldName = "ProgramNo"
        Me.colProgramNo2.Name = "colProgramNo2"
        Me.colProgramNo2.Visible = True
        Me.colProgramNo2.VisibleIndex = 0
        '
        'FabricFinishing_CostSpinEdit
        '
        Me.FabricFinishing_CostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "FabricFinishing_Cost", True))
        Me.FabricFinishing_CostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FabricFinishing_CostSpinEdit.Location = New System.Drawing.Point(584, 156)
        Me.FabricFinishing_CostSpinEdit.Name = "FabricFinishing_CostSpinEdit"
        Me.FabricFinishing_CostSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FabricFinishing_CostSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FabricFinishing_CostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FabricFinishing_CostSpinEdit.Properties.ReadOnly = True
        Me.FabricFinishing_CostSpinEdit.Size = New System.Drawing.Size(89, 20)
        Me.FabricFinishing_CostSpinEdit.TabIndex = 64
        '
        'OfferPrice0TextEdit
        '
        Me.OfferPrice0TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "OfferPrice0", True))
        Me.OfferPrice0TextEdit.Location = New System.Drawing.Point(1164, 184)
        Me.OfferPrice0TextEdit.Name = "OfferPrice0TextEdit"
        Me.OfferPrice0TextEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.OfferPrice0TextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.OfferPrice0TextEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.OfferPrice0TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OfferPrice0TextEdit.Size = New System.Drawing.Size(89, 20)
        Me.OfferPrice0TextEdit.TabIndex = 57
        '
        'OfferPricePcsTextEdit
        '
        Me.OfferPricePcsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "OfferPrice", True))
        Me.OfferPricePcsTextEdit.Location = New System.Drawing.Point(1164, 153)
        Me.OfferPricePcsTextEdit.Name = "OfferPricePcsTextEdit"
        Me.OfferPricePcsTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.OfferPricePcsTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.OfferPricePcsTextEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.OfferPricePcsTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.OfferPricePcsTextEdit.Properties.ReadOnly = True
        Me.OfferPricePcsTextEdit.Size = New System.Drawing.Size(89, 20)
        Me.OfferPricePcsTextEdit.TabIndex = 57
        '
        'FactoryCMSpinEdit1
        '
        Me.FactoryCMSpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "FactoryCM", True))
        Me.FactoryCMSpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FactoryCMSpinEdit1.Location = New System.Drawing.Point(973, 83)
        Me.FactoryCMSpinEdit1.Name = "FactoryCMSpinEdit1"
        Me.FactoryCMSpinEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FactoryCMSpinEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.FactoryCMSpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FactoryCMSpinEdit1.Properties.ReadOnly = True
        Me.FactoryCMSpinEdit1.Size = New System.Drawing.Size(87, 20)
        Me.FactoryCMSpinEdit1.TabIndex = 56
        '
        'TTLCostTextEdit
        '
        Me.TTLCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "TTLCost", True))
        Me.TTLCostTextEdit.Location = New System.Drawing.Point(1164, 129)
        Me.TTLCostTextEdit.Name = "TTLCostTextEdit"
        Me.TTLCostTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TTLCostTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TTLCostTextEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.TTLCostTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TTLCostTextEdit.Properties.ReadOnly = True
        Me.TTLCostTextEdit.Size = New System.Drawing.Size(89, 20)
        Me.TTLCostTextEdit.TabIndex = 54
        '
        'ProcessLossPercentageSpinEdit
        '
        Me.ProcessLossPercentageSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "ProcessLossPercentage", True))
        Me.ProcessLossPercentageSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ProcessLossPercentageSpinEdit.Location = New System.Drawing.Point(973, 131)
        Me.ProcessLossPercentageSpinEdit.Name = "ProcessLossPercentageSpinEdit"
        Me.ProcessLossPercentageSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProcessLossPercentageSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ProcessLossPercentageSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ProcessLossPercentageSpinEdit.Properties.ReadOnly = True
        Me.ProcessLossPercentageSpinEdit.Size = New System.Drawing.Size(87, 20)
        Me.ProcessLossPercentageSpinEdit.TabIndex = 53
        '
        'ActProfitSpinEdit
        '
        Me.ActProfitSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "Profit", True))
        Me.ActProfitSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ActProfitSpinEdit.Location = New System.Drawing.Point(1164, 209)
        Me.ActProfitSpinEdit.Name = "ActProfitSpinEdit"
        Me.ActProfitSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.ActProfitSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ActProfitSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ActProfitSpinEdit.Properties.ReadOnly = True
        Me.ActProfitSpinEdit.Size = New System.Drawing.Size(89, 20)
        Me.ActProfitSpinEdit.TabIndex = 52
        '
        'MarginPercentageSpinEdit
        '
        Me.MarginPercentageSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "MarginPercentage", True))
        Me.MarginPercentageSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MarginPercentageSpinEdit.Location = New System.Drawing.Point(1164, 105)
        Me.MarginPercentageSpinEdit.Name = "MarginPercentageSpinEdit"
        Me.MarginPercentageSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.MarginPercentageSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.MarginPercentageSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MarginPercentageSpinEdit.Size = New System.Drawing.Size(89, 20)
        Me.MarginPercentageSpinEdit.TabIndex = 52
        '
        'StyleIdGridLookUpEdit
        '
        Me.StyleIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "StyleId", True))
        Me.StyleIdGridLookUpEdit.Location = New System.Drawing.Point(146, 56)
        Me.StyleIdGridLookUpEdit.Name = "StyleIdGridLookUpEdit"
        Me.StyleIdGridLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.StyleIdGridLookUpEdit.Properties.Appearance.Options.UseBackColor = True
        Me.StyleIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleIdGridLookUpEdit.Properties.DataSource = Me.StyleBindingSource
        Me.StyleIdGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleIdGridLookUpEdit.Properties.NullText = ""
        Me.StyleIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleIdGridLookUpEdit.Properties.PopupView = Me.StyleIdGridLookUpEditView
        Me.StyleIdGridLookUpEdit.Properties.ReadOnly = True
        Me.StyleIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleIdGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleIdGridLookUpEdit.Size = New System.Drawing.Size(332, 20)
        Me.StyleIdGridLookUpEdit.TabIndex = 51
        '
        'StyleIdGridLookUpEditView
        '
        Me.StyleIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleId, Me.colStyleName, Me.colBuyerId, Me.colDefaultTarget, Me.colSMV})
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
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
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
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(690, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Print:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(861, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Misc:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.AddButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.UpdateCostButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label21)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrecostingGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.FilterButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.PrintButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.CopyButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1297, 29)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(3, 3)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(85, 23)
        Me.AddButton.TabIndex = 29
        Me.AddButton.Text = "&New"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(94, 3)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 26
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(175, 3)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 32
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'UpdateCostButton
        '
        Me.UpdateCostButton.Location = New System.Drawing.Point(256, 3)
        Me.UpdateCostButton.Name = "UpdateCostButton"
        Me.UpdateCostButton.Size = New System.Drawing.Size(112, 23)
        Me.UpdateCostButton.TabIndex = 27
        Me.UpdateCostButton.Text = "&Calculate Cost"
        Me.UpdateCostButton.UseVisualStyleBackColor = True
        Me.UpdateCostButton.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(378, 7)
        Me.Label21.Margin = New System.Windows.Forms.Padding(7, 7, 3, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(212, 14)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "ProgramNo :: Style :: Buyer :: CN :: Version"
        '
        'PrecostingGridLookUpEdit
        '
        Me.PrecostingGridLookUpEdit.EditValue = "91"
        Me.PrecostingGridLookUpEdit.Location = New System.Drawing.Point(596, 4)
        Me.PrecostingGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 3)
        Me.PrecostingGridLookUpEdit.Name = "PrecostingGridLookUpEdit"
        Me.PrecostingGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrecostingGridLookUpEdit.Properties.DataSource = Me.PreCostingProgramLookupBindingSource
        Me.PrecostingGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.PrecostingGridLookUpEdit.Properties.ImmediatePopup = True
        Me.PrecostingGridLookUpEdit.Properties.NullText = ""
        Me.PrecostingGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.PrecostingGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.PrecostingGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PrecostingGridLookUpEdit.Properties.ValueMember = "PreCostingId"
        Me.PrecostingGridLookUpEdit.Size = New System.Drawing.Size(270, 20)
        Me.PrecostingGridLookUpEdit.TabIndex = 31
        '
        'PreCostingProgramLookupBindingSource
        '
        Me.PreCostingProgramLookupBindingSource.DataMember = "PreCostingProgramLookup"
        Me.PreCostingProgramLookupBindingSource.DataSource = Me.PreCostingDataSet
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails, Me.colPreCostingDate})
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
        'colPreCostingDate
        '
        Me.colPreCostingDate.Caption = "Pre Cosing/Budget Date"
        Me.colPreCostingDate.FieldName = "PreCostingDate"
        Me.colPreCostingDate.Name = "colPreCostingDate"
        Me.colPreCostingDate.Visible = True
        Me.colPreCostingDate.VisibleIndex = 1
        '
        'FilterButton
        '
        Me.FilterButton.Location = New System.Drawing.Point(872, 3)
        Me.FilterButton.Name = "FilterButton"
        Me.FilterButton.Size = New System.Drawing.Size(69, 23)
        Me.FilterButton.TabIndex = 27
        Me.FilterButton.Text = "&Show"
        Me.FilterButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(947, 3)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(79, 23)
        Me.PrintButton.TabIndex = 27
        Me.PrintButton.Text = "&Print General"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(1129, 3)
        Me.CopyButton.Margin = New System.Windows.Forms.Padding(100, 3, 3, 3)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(70, 23)
        Me.CopyButton.TabIndex = 27
        Me.CopyButton.Text = "&Copy"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 191)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Remarks:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1069, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Total Cost:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1069, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "LC Value:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(861, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Trim:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(498, 207)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(86, 13)
        Me.Label31.TabIndex = 45
        Me.Label31.Text = "TTL Fabric Cost:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(498, 182)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "AOP ( FF):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(690, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "EMB:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(495, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Knitting:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(495, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Yds:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(495, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Dyeing:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(495, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Yarn:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "GSM:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(272, 84)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(58, 13)
        Me.Label30.TabIndex = 36
        Me.Label30.Text = "Pcs/Pack:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Buyer:"
        '
        'PreCostingNoTextEdit
        '
        Me.PreCostingNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "PreCostingNo", True))
        Me.PreCostingNoTextEdit.Location = New System.Drawing.Point(146, 32)
        Me.PreCostingNoTextEdit.Name = "PreCostingNoTextEdit"
        Me.PreCostingNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.PreCostingNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.PreCostingNoTextEdit.Properties.ReadOnly = True
        Me.PreCostingNoTextEdit.Size = New System.Drawing.Size(75, 20)
        Me.PreCostingNoTextEdit.TabIndex = 6
        '
        'RemarksTextEdit
        '
        Me.RemarksTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "Remarks", True))
        Me.RemarksTextEdit.Location = New System.Drawing.Point(146, 186)
        Me.RemarksTextEdit.Name = "RemarksTextEdit"
        Me.RemarksTextEdit.Size = New System.Drawing.Size(332, 20)
        Me.RemarksTextEdit.TabIndex = 6
        '
        'FO_CostSpinEdit
        '
        Me.FO_CostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "FO_Cost", True))
        Me.FO_CostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FO_CostSpinEdit.Location = New System.Drawing.Point(973, 107)
        Me.FO_CostSpinEdit.Name = "FO_CostSpinEdit"
        Me.FO_CostSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FO_CostSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FO_CostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FO_CostSpinEdit.Properties.ReadOnly = True
        Me.FO_CostSpinEdit.Size = New System.Drawing.Size(87, 20)
        Me.FO_CostSpinEdit.TabIndex = 16
        '
        'Print_CostSpinEdit
        '
        Me.Print_CostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "Print_Cost", True))
        Me.Print_CostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Print_CostSpinEdit.Location = New System.Drawing.Point(750, 56)
        Me.Print_CostSpinEdit.Name = "Print_CostSpinEdit"
        Me.Print_CostSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Print_CostSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Print_CostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Print_CostSpinEdit.Properties.ReadOnly = True
        Me.Print_CostSpinEdit.Size = New System.Drawing.Size(87, 20)
        Me.Print_CostSpinEdit.TabIndex = 11
        '
        'AmndSpinEdit
        '
        Me.AmndSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "AmendmentNo", True))
        Me.AmndSpinEdit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AmndSpinEdit.Location = New System.Drawing.Point(223, 32)
        Me.AmndSpinEdit.Name = "AmndSpinEdit"
        Me.AmndSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.AmndSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.AmndSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmndSpinEdit.Properties.ReadOnly = True
        Me.AmndSpinEdit.Size = New System.Drawing.Size(39, 20)
        Me.AmndSpinEdit.TabIndex = 13
        '
        'SubStyleSpinEdit
        '
        Me.SubStyleSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "SubStyleQty", True))
        Me.SubStyleSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SubStyleSpinEdit.Location = New System.Drawing.Point(364, 80)
        Me.SubStyleSpinEdit.Name = "SubStyleSpinEdit"
        Me.SubStyleSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.SubStyleSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.SubStyleSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SubStyleSpinEdit.Size = New System.Drawing.Size(114, 20)
        Me.SubStyleSpinEdit.TabIndex = 13
        '
        'SpinEdit2
        '
        Me.SpinEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "TTLCost0", True))
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit2.Location = New System.Drawing.Point(1164, 82)
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SpinEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit2.Properties.ReadOnly = True
        Me.SpinEdit2.Size = New System.Drawing.Size(89, 20)
        Me.SpinEdit2.TabIndex = 13
        '
        'Yarn_CostSpinEdit
        '
        Me.Yarn_CostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "Yarn_Cost", True))
        Me.Yarn_CostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Yarn_CostSpinEdit.Location = New System.Drawing.Point(584, 59)
        Me.Yarn_CostSpinEdit.Name = "Yarn_CostSpinEdit"
        Me.Yarn_CostSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Yarn_CostSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Yarn_CostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Yarn_CostSpinEdit.Properties.ReadOnly = True
        Me.Yarn_CostSpinEdit.Size = New System.Drawing.Size(89, 20)
        Me.Yarn_CostSpinEdit.TabIndex = 13
        '
        'Dyeing_CostSpinEdit
        '
        Me.Dyeing_CostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "Dyeing_Cost", True))
        Me.Dyeing_CostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Dyeing_CostSpinEdit.Location = New System.Drawing.Point(584, 131)
        Me.Dyeing_CostSpinEdit.Name = "Dyeing_CostSpinEdit"
        Me.Dyeing_CostSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Dyeing_CostSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Dyeing_CostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Dyeing_CostSpinEdit.Properties.ReadOnly = True
        Me.Dyeing_CostSpinEdit.Size = New System.Drawing.Size(89, 20)
        Me.Dyeing_CostSpinEdit.TabIndex = 14
        '
        'SpinEdit1
        '
        Me.SpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "LCValue", True))
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(1164, 60)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SpinEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit1.Properties.ReadOnly = True
        Me.SpinEdit1.Size = New System.Drawing.Size(89, 20)
        Me.SpinEdit1.TabIndex = 15
        '
        'Yds_CostSpinEdit
        '
        Me.Yds_CostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "Yds_Cost", True))
        Me.Yds_CostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Yds_CostSpinEdit.Location = New System.Drawing.Point(584, 82)
        Me.Yds_CostSpinEdit.Name = "Yds_CostSpinEdit"
        Me.Yds_CostSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Yds_CostSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Yds_CostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Yds_CostSpinEdit.Properties.ReadOnly = True
        Me.Yds_CostSpinEdit.Size = New System.Drawing.Size(89, 20)
        Me.Yds_CostSpinEdit.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Pre Costing/Budget Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Company"
        '
        'Knitting_CostSpinEdit
        '
        Me.Knitting_CostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "Knitting_Cost", True))
        Me.Knitting_CostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Knitting_CostSpinEdit.Location = New System.Drawing.Point(584, 107)
        Me.Knitting_CostSpinEdit.Name = "Knitting_CostSpinEdit"
        Me.Knitting_CostSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Knitting_CostSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Knitting_CostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Knitting_CostSpinEdit.Properties.ReadOnly = True
        Me.Knitting_CostSpinEdit.Size = New System.Drawing.Size(89, 20)
        Me.Knitting_CostSpinEdit.TabIndex = 17
        '
        'AOP_CostSpinEdit
        '
        Me.AOP_CostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "AOP_Cost", True))
        Me.AOP_CostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AOP_CostSpinEdit.Location = New System.Drawing.Point(584, 179)
        Me.AOP_CostSpinEdit.Name = "AOP_CostSpinEdit"
        Me.AOP_CostSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AOP_CostSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.AOP_CostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AOP_CostSpinEdit.Properties.ReadOnly = True
        Me.AOP_CostSpinEdit.Size = New System.Drawing.Size(89, 20)
        Me.AOP_CostSpinEdit.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Pre Costing/Budget No :"
        '
        'EMB_CostSpinEdit
        '
        Me.EMB_CostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "EMB_Cost", True))
        Me.EMB_CostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.EMB_CostSpinEdit.Location = New System.Drawing.Point(750, 79)
        Me.EMB_CostSpinEdit.Name = "EMB_CostSpinEdit"
        Me.EMB_CostSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EMB_CostSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.EMB_CostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EMB_CostSpinEdit.Properties.ReadOnly = True
        Me.EMB_CostSpinEdit.Size = New System.Drawing.Size(88, 20)
        Me.EMB_CostSpinEdit.TabIndex = 18
        '
        'OrderQuantityCPSpinEdit
        '
        Me.OrderQuantityCPSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "OrderQuantityWithCP", True))
        Me.OrderQuantityCPSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.OrderQuantityCPSpinEdit.Location = New System.Drawing.Point(364, 134)
        Me.OrderQuantityCPSpinEdit.Name = "OrderQuantityCPSpinEdit"
        Me.OrderQuantityCPSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.OrderQuantityCPSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.OrderQuantityCPSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderQuantityCPSpinEdit.Properties.ReadOnly = True
        Me.OrderQuantityCPSpinEdit.Size = New System.Drawing.Size(114, 20)
        Me.OrderQuantityCPSpinEdit.TabIndex = 5
        '
        'OrderQuantitySpinEdit
        '
        Me.OrderQuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "OrderQuantity", True))
        Me.OrderQuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.OrderQuantitySpinEdit.Location = New System.Drawing.Point(364, 106)
        Me.OrderQuantitySpinEdit.Name = "OrderQuantitySpinEdit"
        Me.OrderQuantitySpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.OrderQuantitySpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.OrderQuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.OrderQuantitySpinEdit.Properties.ReadOnly = True
        Me.OrderQuantitySpinEdit.Size = New System.Drawing.Size(114, 20)
        Me.OrderQuantitySpinEdit.TabIndex = 5
        '
        'Trim_CostSpinEdit
        '
        Me.Trim_CostSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "Trim_Cost", True))
        Me.Trim_CostSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Trim_CostSpinEdit.Location = New System.Drawing.Point(973, 59)
        Me.Trim_CostSpinEdit.Name = "Trim_CostSpinEdit"
        Me.Trim_CostSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Trim_CostSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Trim_CostSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.Trim_CostSpinEdit.Properties.ReadOnly = True
        Me.Trim_CostSpinEdit.Size = New System.Drawing.Size(87, 20)
        Me.Trim_CostSpinEdit.TabIndex = 20
        '
        'PreCostingDateDateEdit
        '
        Me.PreCostingDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "PreCostingDate", True))
        Me.PreCostingDateDateEdit.EditValue = Nothing
        Me.PreCostingDateDateEdit.Location = New System.Drawing.Point(146, 108)
        Me.PreCostingDateDateEdit.Name = "PreCostingDateDateEdit"
        Me.PreCostingDateDateEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.PreCostingDateDateEdit.Properties.Appearance.Options.UseBackColor = True
        Me.PreCostingDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PreCostingDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.PreCostingDateDateEdit.Size = New System.Drawing.Size(116, 20)
        Me.PreCostingDateDateEdit.TabIndex = 3
        '
        'CompanyIdLookUpEdit
        '
        Me.CompanyIdLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "CompanyId", True))
        Me.CompanyIdLookUpEdit.Location = New System.Drawing.Point(324, 160)
        Me.CompanyIdLookUpEdit.Name = "CompanyIdLookUpEdit"
        Me.CompanyIdLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanyIdLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyId", "Company Id", 81, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "Company Code", 83, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 85, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fax", "Fax", 28, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Website", "Website", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactPerson", "Contact Person", 84, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("WeeklyOff", "Weekly Off", 64, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.CompanyIdLookUpEdit.Properties.DataSource = Me.CompanyBindingSource
        Me.CompanyIdLookUpEdit.Properties.DisplayMember = "CompanyCode"
        Me.CompanyIdLookUpEdit.Properties.NullText = ""
        Me.CompanyIdLookUpEdit.Properties.ReadOnly = True
        Me.CompanyIdLookUpEdit.Properties.ValueMember = "CompanyId"
        Me.CompanyIdLookUpEdit.Size = New System.Drawing.Size(154, 20)
        Me.CompanyIdLookUpEdit.TabIndex = 2
        '
        'GSMTextEdit
        '
        Me.GSMTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "GSM", True))
        Me.GSMTextEdit.Location = New System.Drawing.Point(146, 159)
        Me.GSMTextEdit.Name = "GSMTextEdit"
        Me.GSMTextEdit.Properties.ReadOnly = True
        Me.GSMTextEdit.Size = New System.Drawing.Size(116, 20)
        Me.GSMTextEdit.TabIndex = 10
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "CauseofCancel", True))
        Me.TextEdit2.Location = New System.Drawing.Point(693, 156)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.TextEdit2.Size = New System.Drawing.Size(367, 38)
        Me.TextEdit2.TabIndex = 9
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.FabricTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(1297, 426)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.FabricTabPage, Me.TrimTabPage, Me.CMTabPage})
        '
        'FabricTabPage
        '
        Me.FabricTabPage.AutoScroll = True
        Me.FabricTabPage.Controls.Add(Me.SplitContainer2)
        Me.FabricTabPage.Name = "FabricTabPage"
        Me.FabricTabPage.Size = New System.Drawing.Size(1291, 398)
        Me.FabricTabPage.Text = "Fabric Details"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.CopyFabricButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GenerateButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.SizeCheckedComboBoxEdit)
        Me.SplitContainer2.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ColorCheckedComboBoxEdit)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GPFFButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.PreCostingFabricGridControl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GetFabricButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GetYarnButton)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1291, 398)
        Me.SplitContainer2.SplitterDistance = 221
        Me.SplitContainer2.TabIndex = 2
        '
        'CopyFabricButton
        '
        Me.CopyFabricButton.Location = New System.Drawing.Point(433, 8)
        Me.CopyFabricButton.Name = "CopyFabricButton"
        Me.CopyFabricButton.Size = New System.Drawing.Size(89, 23)
        Me.CopyFabricButton.TabIndex = 39
        Me.CopyFabricButton.Text = "Copy Fabric"
        Me.CopyFabricButton.UseVisualStyleBackColor = True
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(284, 8)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(122, 23)
        Me.GenerateButton.TabIndex = 39
        Me.GenerateButton.Text = "Get Order Quantity"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(175, 13)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 38
        Me.LabelControl2.Text = "Size"
        '
        'SizeCheckedComboBoxEdit
        '
        Me.SizeCheckedComboBoxEdit.Location = New System.Drawing.Point(207, 10)
        Me.SizeCheckedComboBoxEdit.Name = "SizeCheckedComboBoxEdit"
        Me.SizeCheckedComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeCheckedComboBoxEdit.Properties.DataSource = Me.OrderSizeLookupBindingSource
        Me.SizeCheckedComboBoxEdit.Properties.DisplayMember = "SizeCode"
        Me.SizeCheckedComboBoxEdit.Properties.ValueMember = "SizeId"
        Me.SizeCheckedComboBoxEdit.Size = New System.Drawing.Size(71, 20)
        Me.SizeCheckedComboBoxEdit.TabIndex = 36
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
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "Color"
        '
        'ColorCheckedComboBoxEdit
        '
        Me.ColorCheckedComboBoxEdit.Location = New System.Drawing.Point(60, 10)
        Me.ColorCheckedComboBoxEdit.Name = "ColorCheckedComboBoxEdit"
        Me.ColorCheckedComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorCheckedComboBoxEdit.Properties.DataSource = Me.OrderFabricColorBindingSource
        Me.ColorCheckedComboBoxEdit.Properties.DisplayMember = "ColorDetails"
        Me.ColorCheckedComboBoxEdit.Properties.ValueMember = "FabricColorId"
        Me.ColorCheckedComboBoxEdit.Size = New System.Drawing.Size(107, 20)
        Me.ColorCheckedComboBoxEdit.TabIndex = 35
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
        'GPFFButton
        '
        Me.GPFFButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GPFFButton.Enabled = False
        Me.GPFFButton.Location = New System.Drawing.Point(1056, 8)
        Me.GPFFButton.Name = "GPFFButton"
        Me.GPFFButton.Size = New System.Drawing.Size(228, 23)
        Me.GPFFButton.TabIndex = 34
        Me.GPFFButton.Text = "3. Get Price From &Fabric Costing Master"
        Me.GPFFButton.UseVisualStyleBackColor = True
        '
        'PreCostingFabricGridControl
        '
        Me.PreCostingFabricGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreCostingFabricGridControl.DataSource = Me.PreCostingFabricBindingSource
        Me.PreCostingFabricGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.PreCostingFabricGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.PreCostingFabricGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.PreCostingFabricGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.PreCostingFabricGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.PreCostingFabricGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        GridLevelNode1.RelationName = "Level1"
        Me.PreCostingFabricGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.PreCostingFabricGridControl.Location = New System.Drawing.Point(3, 37)
        Me.PreCostingFabricGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PreCostingFabricGridControl.MainView = Me.PreCostingFabBandedGridView
        Me.PreCostingFabricGridControl.Name = "PreCostingFabricGridControl"
        Me.PreCostingFabricGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GarmentsPartGridLookUpEdit, Me.KnittingTypeGridLookUpEdit, Me.CompositionGridLookUpEdit, Me.GSMGridLookUpEdit, Me.DyeingTypeLookUpEdit, Me.FinishUnitComboBox, Me.DiaUnitComboBox, Me.DiaTypeComboBox})
        Me.PreCostingFabricGridControl.Size = New System.Drawing.Size(1285, 179)
        Me.PreCostingFabricGridControl.TabIndex = 0
        Me.PreCostingFabricGridControl.UseEmbeddedNavigator = True
        Me.PreCostingFabricGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.PreCostingFabBandedGridView})
        '
        'PreCostingFabricBindingSource
        '
        Me.PreCostingFabricBindingSource.DataMember = "FK_PreCostingFabric_PreCostingMain"
        Me.PreCostingFabricBindingSource.DataSource = Me.PreCostingMainBindingSource
        '
        'PreCostingFabBandedGridView
        '
        Me.PreCostingFabBandedGridView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2, Me.gridBand4, Me.gridBand3})
        Me.PreCostingFabBandedGridView.ColumnPanelRowHeight = 40
        Me.PreCostingFabBandedGridView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colGarmentsPartId, Me.colKnittingTypeId, Me.colCompositionId, Me.colConsumption, Me.colWastagePercentage, Me.colAOP_Cost1, Me.colKnitting_Cost1, Me.colDyeing_Cost1, Me.colYarn_Cost1, Me.colFabricColorName1, Me.colYds_Cost1, Me.colGSMId1, Me.colTTLFabricCost, Me.colProcessLossPercentage, Me.colDyeingType, Me.colFinishing_Cost, Me.colFQty, Me.colGQty, Me.colFDia, Me.colDiaType, Me.colDiaUnit, Me.colFinishUnit, Me.colLength, Me.colCCSize, Me.colOrderQuantity1, Me.colCCCostPerDzn, Me.colKgPerUnit, Me.colForColor, Me.colForSize, Me.colKnitting_Cost_Dzn, Me.colBQty, Me.colAOP_WP, Me.colAdditionalQuantity1})
        Me.PreCostingFabBandedGridView.GridControl = Me.PreCostingFabricGridControl
        Me.PreCostingFabBandedGridView.Name = "PreCostingFabBandedGridView"
        Me.PreCostingFabBandedGridView.OptionsDetail.AllowZoomDetail = False
        Me.PreCostingFabBandedGridView.OptionsDetail.EnableMasterViewMode = False
        Me.PreCostingFabBandedGridView.OptionsView.ColumnAutoWidth = False
        Me.PreCostingFabBandedGridView.OptionsView.ShowDetailButtons = False
        Me.PreCostingFabBandedGridView.OptionsView.ShowFooter = True
        Me.PreCostingFabBandedGridView.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Fabric Information"
        Me.GridBand1.Columns.Add(Me.colGarmentsPartId)
        Me.GridBand1.Columns.Add(Me.colFabricColorName1)
        Me.GridBand1.Columns.Add(Me.colKnittingTypeId)
        Me.GridBand1.Columns.Add(Me.colCompositionId)
        Me.GridBand1.Columns.Add(Me.colGSMId1)
        Me.GridBand1.Columns.Add(Me.colFDia)
        Me.GridBand1.Columns.Add(Me.colDiaType)
        Me.GridBand1.Columns.Add(Me.colDiaUnit)
        Me.GridBand1.Columns.Add(Me.colDyeingType)
        Me.GridBand1.Columns.Add(Me.colOrderQuantity1)
        Me.GridBand1.Columns.Add(Me.colConsumption)
        Me.GridBand1.Columns.Add(Me.colFinishUnit)
        Me.GridBand1.Columns.Add(Me.colKgPerUnit)
        Me.GridBand1.Columns.Add(Me.colWastagePercentage)
        Me.GridBand1.Columns.Add(Me.colBQty)
        Me.GridBand1.Columns.Add(Me.colFQty)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 1059
        '
        'colGarmentsPartId
        '
        Me.colGarmentsPartId.AppearanceHeader.Options.UseTextOptions = True
        Me.colGarmentsPartId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGarmentsPartId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGarmentsPartId.Caption = "Garments Part"
        Me.colGarmentsPartId.ColumnEdit = Me.GarmentsPartGridLookUpEdit
        Me.colGarmentsPartId.FieldName = "GarmentsPartId"
        Me.colGarmentsPartId.Name = "colGarmentsPartId"
        Me.colGarmentsPartId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colGarmentsPartId.Visible = True
        Me.colGarmentsPartId.Width = 98
        '
        'GarmentsPartGridLookUpEdit
        '
        Me.GarmentsPartGridLookUpEdit.AutoHeight = False
        Me.GarmentsPartGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GarmentsPartGridLookUpEdit.DataSource = Me.GarmentsPartBindingSource
        Me.GarmentsPartGridLookUpEdit.DisplayMember = "Name"
        Me.GarmentsPartGridLookUpEdit.ImmediatePopup = True
        Me.GarmentsPartGridLookUpEdit.Name = "GarmentsPartGridLookUpEdit"
        Me.GarmentsPartGridLookUpEdit.NullText = ""
        Me.GarmentsPartGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GarmentsPartGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.GarmentsPartGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GarmentsPartGridLookUpEdit.ValueMember = "GarmentsPartId"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGarmentsPartId1, Me.colName, Me.colDescription})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colGarmentsPartId1
        '
        Me.colGarmentsPartId1.FieldName = "GarmentsPartId"
        Me.colGarmentsPartId1.Name = "colGarmentsPartId1"
        Me.colGarmentsPartId1.OptionsColumn.ReadOnly = True
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        '
        'colFabricColorName1
        '
        Me.colFabricColorName1.AppearanceHeader.Options.UseTextOptions = True
        Me.colFabricColorName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFabricColorName1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFabricColorName1.Caption = "Fabric Color [F11]"
        Me.colFabricColorName1.FieldName = "FabricColorName"
        Me.colFabricColorName1.Name = "colFabricColorName1"
        Me.colFabricColorName1.Visible = True
        Me.colFabricColorName1.Width = 131
        '
        'colKnittingTypeId
        '
        Me.colKnittingTypeId.AppearanceHeader.Options.UseTextOptions = True
        Me.colKnittingTypeId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKnittingTypeId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colKnittingTypeId.Caption = "Fabric Type"
        Me.colKnittingTypeId.ColumnEdit = Me.KnittingTypeGridLookUpEdit
        Me.colKnittingTypeId.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId.Name = "colKnittingTypeId"
        Me.colKnittingTypeId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colKnittingTypeId.Visible = True
        Me.colKnittingTypeId.Width = 112
        '
        'KnittingTypeGridLookUpEdit
        '
        Me.KnittingTypeGridLookUpEdit.AutoHeight = False
        Me.KnittingTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KnittingTypeGridLookUpEdit.DataSource = Me.KnittingTypeBindingSource
        Me.KnittingTypeGridLookUpEdit.DisplayMember = "KnittingType"
        Me.KnittingTypeGridLookUpEdit.ImmediatePopup = True
        Me.KnittingTypeGridLookUpEdit.Name = "KnittingTypeGridLookUpEdit"
        Me.KnittingTypeGridLookUpEdit.NullText = ""
        Me.KnittingTypeGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.KnittingTypeGridLookUpEdit.PopupView = Me.GridView1
        Me.KnittingTypeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.KnittingTypeGridLookUpEdit.ValueMember = "KnittingTypeId"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingTypeId1, Me.colKnittingType, Me.colDiscontinue, Me.colKnittingTypeCode})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colKnittingTypeId1
        '
        Me.colKnittingTypeId1.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId1.Name = "colKnittingTypeId1"
        Me.colKnittingTypeId1.OptionsColumn.ReadOnly = True
        '
        'colKnittingType
        '
        Me.colKnittingType.FieldName = "KnittingType"
        Me.colKnittingType.Name = "colKnittingType"
        Me.colKnittingType.Visible = True
        Me.colKnittingType.VisibleIndex = 0
        '
        'colDiscontinue
        '
        Me.colDiscontinue.FieldName = "Discontinue"
        Me.colDiscontinue.Name = "colDiscontinue"
        '
        'colKnittingTypeCode
        '
        Me.colKnittingTypeCode.FieldName = "KnittingTypeCode"
        Me.colKnittingTypeCode.Name = "colKnittingTypeCode"
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
        Me.colCompositionId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colCompositionId.Visible = True
        Me.colCompositionId.Width = 118
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
        Me.CompositionGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CompositionGridLookUpEdit.PopupView = Me.GridView2
        Me.CompositionGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CompositionGridLookUpEdit.ValueMember = "CompositionId"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompositionId1, Me.colComposition, Me.colDiscontinue1, Me.colCode})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colCompositionId1
        '
        Me.colCompositionId1.FieldName = "CompositionId"
        Me.colCompositionId1.Name = "colCompositionId1"
        '
        'colComposition
        '
        Me.colComposition.FieldName = "Composition"
        Me.colComposition.Name = "colComposition"
        Me.colComposition.Visible = True
        Me.colComposition.VisibleIndex = 0
        '
        'colDiscontinue1
        '
        Me.colDiscontinue1.FieldName = "Discontinue"
        Me.colDiscontinue1.Name = "colDiscontinue1"
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        '
        'colGSMId1
        '
        Me.colGSMId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colGSMId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGSMId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGSMId1.Caption = "GSM"
        Me.colGSMId1.ColumnEdit = Me.GSMGridLookUpEdit
        Me.colGSMId1.FieldName = "GSMId"
        Me.colGSMId1.Name = "colGSMId1"
        Me.colGSMId1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.colGSMId1.Visible = True
        Me.colGSMId1.Width = 81
        '
        'GSMGridLookUpEdit
        '
        Me.GSMGridLookUpEdit.AutoHeight = False
        Me.GSMGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GSMGridLookUpEdit.DataSource = Me.GSMBindingSource
        Me.GSMGridLookUpEdit.DisplayMember = "GSM"
        Me.GSMGridLookUpEdit.Name = "GSMGridLookUpEdit"
        Me.GSMGridLookUpEdit.NullText = ""
        Me.GSMGridLookUpEdit.PopupView = Me.GridView5
        Me.GSMGridLookUpEdit.ValueMember = "GSMId"
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGSMId, Me.colGSM, Me.colGSMCode})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colGSMId
        '
        Me.colGSMId.FieldName = "GSMId"
        Me.colGSMId.Name = "colGSMId"
        Me.colGSMId.OptionsColumn.ReadOnly = True
        '
        'colGSM
        '
        Me.colGSM.FieldName = "GSM"
        Me.colGSM.Name = "colGSM"
        Me.colGSM.Visible = True
        Me.colGSM.VisibleIndex = 0
        '
        'colGSMCode
        '
        Me.colGSMCode.FieldName = "GSMCode"
        Me.colGSMCode.Name = "colGSMCode"
        '
        'colFDia
        '
        Me.colFDia.AppearanceHeader.Options.UseTextOptions = True
        Me.colFDia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFDia.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFDia.FieldName = "FDia"
        Me.colFDia.Name = "colFDia"
        Me.colFDia.Visible = True
        Me.colFDia.Width = 51
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
        Me.colDiaType.Width = 49
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
        Me.colDiaUnit.Width = 48
        '
        'DiaUnitComboBox
        '
        Me.DiaUnitComboBox.AutoHeight = False
        Me.DiaUnitComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiaUnitComboBox.Items.AddRange(New Object() {"IN", "CM"})
        Me.DiaUnitComboBox.Name = "DiaUnitComboBox"
        '
        'colDyeingType
        '
        Me.colDyeingType.AppearanceHeader.Options.UseTextOptions = True
        Me.colDyeingType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDyeingType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDyeingType.ColumnEdit = Me.DyeingTypeLookUpEdit
        Me.colDyeingType.FieldName = "DyeingType"
        Me.colDyeingType.Name = "colDyeingType"
        Me.colDyeingType.Visible = True
        Me.colDyeingType.Width = 61
        '
        'DyeingTypeLookUpEdit
        '
        Me.DyeingTypeLookUpEdit.AutoHeight = False
        Me.DyeingTypeLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DyeingTypeLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DyeingTypeId", "Dyeing Type Id", 96, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DyeingType", "Dyeing Type", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CostPerKg", "Cost Per Kg", 66, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.DyeingTypeLookUpEdit.DataSource = Me.DyeingTypeBindingSource
        Me.DyeingTypeLookUpEdit.DisplayMember = "DyeingType"
        Me.DyeingTypeLookUpEdit.Name = "DyeingTypeLookUpEdit"
        Me.DyeingTypeLookUpEdit.NullText = ""
        Me.DyeingTypeLookUpEdit.ValueMember = "DyeingTypeId"
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
        'colOrderQuantity1
        '
        Me.colOrderQuantity1.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderQuantity1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderQuantity1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderQuantity1.FieldName = "OrderQuantity"
        Me.colOrderQuantity1.Name = "colOrderQuantity1"
        Me.colOrderQuantity1.Visible = True
        Me.colOrderQuantity1.Width = 54
        '
        'colConsumption
        '
        Me.colConsumption.AppearanceHeader.Options.UseTextOptions = True
        Me.colConsumption.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConsumption.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConsumption.Caption = "Con"
        Me.colConsumption.FieldName = "Consumption"
        Me.colConsumption.Name = "colConsumption"
        Me.colConsumption.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colConsumption.ToolTip = "Consumption"
        Me.colConsumption.Visible = True
        Me.colConsumption.Width = 44
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
        Me.colFinishUnit.Width = 48
        '
        'FinishUnitComboBox
        '
        Me.FinishUnitComboBox.AutoHeight = False
        Me.FinishUnitComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishUnitComboBox.Items.AddRange(New Object() {"Kg", "Pcs", "Mtr", "Yds"})
        Me.FinishUnitComboBox.Name = "FinishUnitComboBox"
        '
        'colKgPerUnit
        '
        Me.colKgPerUnit.AppearanceHeader.Options.UseTextOptions = True
        Me.colKgPerUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKgPerUnit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colKgPerUnit.Caption = "Kg/Unit"
        Me.colKgPerUnit.FieldName = "KgPerUnit"
        Me.colKgPerUnit.Name = "colKgPerUnit"
        Me.colKgPerUnit.Visible = True
        Me.colKgPerUnit.Width = 48
        '
        'colWastagePercentage
        '
        Me.colWastagePercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colWastagePercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWastagePercentage.Caption = "W%"
        Me.colWastagePercentage.FieldName = "WastagePercentage"
        Me.colWastagePercentage.Name = "colWastagePercentage"
        Me.colWastagePercentage.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colWastagePercentage.Visible = True
        Me.colWastagePercentage.Width = 41
        '
        'colBQty
        '
        Me.colBQty.FieldName = "BQty"
        Me.colBQty.Name = "colBQty"
        '
        'colFQty
        '
        Me.colFQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colFQty.AppearanceCell.Options.UseBackColor = True
        Me.colFQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colFQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFQty.Caption = "Finish Quantity"
        Me.colFQty.FieldName = "FQty"
        Me.colFQty.Name = "colFQty"
        Me.colFQty.OptionsColumn.AllowEdit = False
        Me.colFQty.OptionsColumn.ReadOnly = True
        Me.colFQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FQty", "{0:0.##}")})
        Me.colFQty.Visible = True
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "Cost / Kg"
        Me.GridBand2.Columns.Add(Me.colYarn_Cost1)
        Me.GridBand2.Columns.Add(Me.colYds_Cost1)
        Me.GridBand2.Columns.Add(Me.colKnitting_Cost1)
        Me.GridBand2.Columns.Add(Me.colDyeing_Cost1)
        Me.GridBand2.Columns.Add(Me.colFinishing_Cost)
        Me.GridBand2.Columns.Add(Me.colAOP_Cost1)
        Me.GridBand2.Columns.Add(Me.colAOP_WP)
        Me.GridBand2.Columns.Add(Me.colProcessLossPercentage)
        Me.GridBand2.Columns.Add(Me.colGQty)
        Me.GridBand2.Columns.Add(Me.colAdditionalQuantity1)
        Me.GridBand2.Columns.Add(Me.colTTLFabricCost)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.VisibleIndex = 1
        Me.GridBand2.Width = 742
        '
        'colYarn_Cost1
        '
        Me.colYarn_Cost1.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarn_Cost1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarn_Cost1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarn_Cost1.Caption = "Yarn"
        Me.colYarn_Cost1.FieldName = "Yarn_Cost"
        Me.colYarn_Cost1.Name = "colYarn_Cost1"
        Me.colYarn_Cost1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colYarn_Cost1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colYarn_Cost1.Visible = True
        Me.colYarn_Cost1.Width = 74
        '
        'colYds_Cost1
        '
        Me.colYds_Cost1.AppearanceHeader.Options.UseTextOptions = True
        Me.colYds_Cost1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYds_Cost1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYds_Cost1.Caption = "Yds"
        Me.colYds_Cost1.FieldName = "Yds_Cost"
        Me.colYds_Cost1.Name = "colYds_Cost1"
        Me.colYds_Cost1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colYds_Cost1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Yds_Cost", "{0:0.##}")})
        Me.colYds_Cost1.Visible = True
        Me.colYds_Cost1.Width = 53
        '
        'colKnitting_Cost1
        '
        Me.colKnitting_Cost1.AppearanceHeader.Options.UseTextOptions = True
        Me.colKnitting_Cost1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colKnitting_Cost1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colKnitting_Cost1.Caption = "Knitting"
        Me.colKnitting_Cost1.FieldName = "Knitting_Cost"
        Me.colKnitting_Cost1.Name = "colKnitting_Cost1"
        Me.colKnitting_Cost1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colKnitting_Cost1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colKnitting_Cost1.Visible = True
        Me.colKnitting_Cost1.Width = 71
        '
        'colDyeing_Cost1
        '
        Me.colDyeing_Cost1.AppearanceHeader.Options.UseTextOptions = True
        Me.colDyeing_Cost1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDyeing_Cost1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDyeing_Cost1.Caption = "Dyeing"
        Me.colDyeing_Cost1.FieldName = "Dyeing_Cost"
        Me.colDyeing_Cost1.Name = "colDyeing_Cost1"
        Me.colDyeing_Cost1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDyeing_Cost1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colDyeing_Cost1.Visible = True
        Me.colDyeing_Cost1.Width = 66
        '
        'colFinishing_Cost
        '
        Me.colFinishing_Cost.AppearanceHeader.Options.UseTextOptions = True
        Me.colFinishing_Cost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFinishing_Cost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFinishing_Cost.Caption = "Finishing"
        Me.colFinishing_Cost.FieldName = "Finishing_Cost"
        Me.colFinishing_Cost.Name = "colFinishing_Cost"
        Me.colFinishing_Cost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Finishing_Cost", "{0:0.##}")})
        Me.colFinishing_Cost.Visible = True
        '
        'colAOP_Cost1
        '
        Me.colAOP_Cost1.AppearanceHeader.Options.UseTextOptions = True
        Me.colAOP_Cost1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAOP_Cost1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAOP_Cost1.Caption = "AOP"
        Me.colAOP_Cost1.FieldName = "AOP_Cost"
        Me.colAOP_Cost1.Name = "colAOP_Cost1"
        Me.colAOP_Cost1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colAOP_Cost1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colAOP_Cost1.Visible = True
        Me.colAOP_Cost1.Width = 54
        '
        'colAOP_WP
        '
        Me.colAOP_WP.Caption = "AOP %"
        Me.colAOP_WP.FieldName = "AOP_WP"
        Me.colAOP_WP.Name = "colAOP_WP"
        Me.colAOP_WP.Visible = True
        Me.colAOP_WP.Width = 50
        '
        'colProcessLossPercentage
        '
        Me.colProcessLossPercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colProcessLossPercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProcessLossPercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProcessLossPercentage.Caption = "Process Loss %"
        Me.colProcessLossPercentage.FieldName = "ProcessLossPercentage"
        Me.colProcessLossPercentage.Name = "colProcessLossPercentage"
        Me.colProcessLossPercentage.Visible = True
        Me.colProcessLossPercentage.Width = 74
        '
        'colGQty
        '
        Me.colGQty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colGQty.AppearanceCell.Options.UseBackColor = True
        Me.colGQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colGQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGQty.FieldName = "GQty"
        Me.colGQty.Name = "colGQty"
        Me.colGQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GQty", "{0:0.##}")})
        Me.colGQty.Visible = True
        '
        'colAdditionalQuantity1
        '
        Me.colAdditionalQuantity1.AppearanceHeader.Options.UseTextOptions = True
        Me.colAdditionalQuantity1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAdditionalQuantity1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAdditionalQuantity1.FieldName = "AdditionalQuantity"
        Me.colAdditionalQuantity1.Name = "colAdditionalQuantity1"
        Me.colAdditionalQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AdditionalQuantity", "{0:0.##}")})
        Me.colAdditionalQuantity1.Visible = True
        '
        'colTTLFabricCost
        '
        Me.colTTLFabricCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colTTLFabricCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTTLFabricCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTTLFabricCost.Caption = "TTL Fabric Cost"
        Me.colTTLFabricCost.FieldName = "TTLFabricCost"
        Me.colTTLFabricCost.Name = "colTTLFabricCost"
        Me.colTTLFabricCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTTLFabricCost.Visible = True
        '
        'gridBand4
        '
        Me.gridBand4.Caption = "Cost/Dz"
        Me.gridBand4.Columns.Add(Me.colKnitting_Cost_Dzn)
        Me.gridBand4.Columns.Add(Me.colCCCostPerDzn)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 2
        Me.gridBand4.Width = 46
        '
        'colKnitting_Cost_Dzn
        '
        Me.colKnitting_Cost_Dzn.Caption = "Cost/Dz"
        Me.colKnitting_Cost_Dzn.FieldName = "Knitting_Cost_Dzn"
        Me.colKnitting_Cost_Dzn.Name = "colKnitting_Cost_Dzn"
        Me.colKnitting_Cost_Dzn.Visible = True
        Me.colKnitting_Cost_Dzn.Width = 46
        '
        'colCCCostPerDzn
        '
        Me.colCCCostPerDzn.AppearanceHeader.Options.UseTextOptions = True
        Me.colCCCostPerDzn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCCCostPerDzn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCCCostPerDzn.Caption = "Cost/Dzn"
        Me.colCCCostPerDzn.FieldName = "CCCostPerDzn"
        Me.colCCCostPerDzn.Name = "colCCCostPerDzn"
        Me.colCCCostPerDzn.Width = 65
        '
        'gridBand3
        '
        Me.gridBand3.Caption = "Collar Cuff Information"
        Me.gridBand3.Columns.Add(Me.colCCSize)
        Me.gridBand3.Columns.Add(Me.colLength)
        Me.gridBand3.Columns.Add(Me.colForSize)
        Me.gridBand3.Columns.Add(Me.colForColor)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 3
        Me.gridBand3.Width = 271
        '
        'colCCSize
        '
        Me.colCCSize.FieldName = "CCSize"
        Me.colCCSize.Name = "colCCSize"
        Me.colCCSize.Visible = True
        Me.colCCSize.Width = 61
        '
        'colLength
        '
        Me.colLength.FieldName = "Length"
        Me.colLength.Name = "colLength"
        Me.colLength.Visible = True
        Me.colLength.Width = 60
        '
        'colForSize
        '
        Me.colForSize.FieldName = "ForSize"
        Me.colForSize.Name = "colForSize"
        Me.colForSize.Visible = True
        '
        'colForColor
        '
        Me.colForColor.FieldName = "ForColor"
        Me.colForColor.Name = "colForColor"
        Me.colForColor.Visible = True
        '
        'GetFabricButton
        '
        Me.GetFabricButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GetFabricButton.Location = New System.Drawing.Point(720, 8)
        Me.GetFabricButton.Name = "GetFabricButton"
        Me.GetFabricButton.Size = New System.Drawing.Size(146, 24)
        Me.GetFabricButton.TabIndex = 32
        Me.GetFabricButton.Text = "1. &Get Fabric"
        Me.GetFabricButton.UseVisualStyleBackColor = True
        '
        'GetYarnButton
        '
        Me.GetYarnButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GetYarnButton.Location = New System.Drawing.Point(872, 8)
        Me.GetYarnButton.Name = "GetYarnButton"
        Me.GetYarnButton.Size = New System.Drawing.Size(177, 24)
        Me.GetYarnButton.TabIndex = 33
        Me.GetYarnButton.Text = "2. &Get Yarn And Finishing"
        Me.GetYarnButton.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.PreCosting_YarnGridControl)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.PreCostingFabricFinishingGridControl)
        Me.SplitContainer3.Size = New System.Drawing.Size(1291, 173)
        Me.SplitContainer3.SplitterDistance = 968
        Me.SplitContainer3.TabIndex = 2
        '
        'PreCosting_YarnGridControl
        '
        Me.PreCosting_YarnGridControl.DataSource = Me.PreCosting_YarnBindingSource
        Me.PreCosting_YarnGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PreCosting_YarnGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.PreCosting_YarnGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.PreCosting_YarnGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.PreCosting_YarnGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.PreCosting_YarnGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.PreCosting_YarnGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.PreCosting_YarnGridControl.Location = New System.Drawing.Point(0, 0)
        Me.PreCosting_YarnGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PreCosting_YarnGridControl.MainView = Me.PreCostingYarnGridView
        Me.PreCosting_YarnGridControl.Name = "PreCosting_YarnGridControl"
        Me.PreCosting_YarnGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.YarnListGridLookUpEdit})
        Me.PreCosting_YarnGridControl.Size = New System.Drawing.Size(968, 173)
        Me.PreCosting_YarnGridControl.TabIndex = 1
        Me.PreCosting_YarnGridControl.UseEmbeddedNavigator = True
        Me.PreCosting_YarnGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.PreCostingYarnGridView})
        '
        'PreCosting_YarnBindingSource
        '
        Me.PreCosting_YarnBindingSource.DataMember = "PreCostingFabric_PreCosting_Yarn"
        Me.PreCosting_YarnBindingSource.DataSource = Me.PreCostingFabricBindingSource
        '
        'PreCostingYarnGridView
        '
        Me.PreCostingYarnGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPreCostingYarnId, Me.colPreCostingFabricId, Me.colItemId, Me.colYarnPercentage, Me.colWastagePercentage1, Me.colYds_Cost2, Me.colYarn_Cost2, Me.colLot_No, Me.colYarnColor})
        Me.PreCostingYarnGridView.GridControl = Me.PreCosting_YarnGridControl
        Me.PreCostingYarnGridView.Name = "PreCostingYarnGridView"
        Me.PreCostingYarnGridView.OptionsCustomization.AllowGroup = False
        Me.PreCostingYarnGridView.OptionsView.ColumnAutoWidth = False
        Me.PreCostingYarnGridView.OptionsView.ShowFooter = True
        Me.PreCostingYarnGridView.OptionsView.ShowGroupPanel = False
        '
        'colPreCostingYarnId
        '
        Me.colPreCostingYarnId.AppearanceHeader.Options.UseTextOptions = True
        Me.colPreCostingYarnId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPreCostingYarnId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPreCostingYarnId.FieldName = "PreCostingYarnId"
        Me.colPreCostingYarnId.Name = "colPreCostingYarnId"
        Me.colPreCostingYarnId.OptionsColumn.ReadOnly = True
        Me.colPreCostingYarnId.Width = 115
        '
        'colPreCostingFabricId
        '
        Me.colPreCostingFabricId.AppearanceHeader.Options.UseTextOptions = True
        Me.colPreCostingFabricId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPreCostingFabricId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPreCostingFabricId.FieldName = "PreCostingFabricId"
        Me.colPreCostingFabricId.Name = "colPreCostingFabricId"
        Me.colPreCostingFabricId.Width = 121
        '
        'colItemId
        '
        Me.colItemId.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemId.Caption = "Yarn"
        Me.colItemId.ColumnEdit = Me.YarnListGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 135
        '
        'YarnListGridLookUpEdit
        '
        Me.YarnListGridLookUpEdit.AutoHeight = False
        Me.YarnListGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YarnListGridLookUpEdit.DataSource = Me.ItemListBindingSource
        Me.YarnListGridLookUpEdit.DisplayMember = "ItemName"
        Me.YarnListGridLookUpEdit.ImmediatePopup = True
        Me.YarnListGridLookUpEdit.Name = "YarnListGridLookUpEdit"
        Me.YarnListGridLookUpEdit.NullText = ""
        Me.YarnListGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.YarnListGridLookUpEdit.PopupView = Me.GridView7
        Me.YarnListGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.YarnListGridLookUpEdit.ValueMember = "ItemId"
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId1, Me.colItemName, Me.colDepartmentId})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colItemId1
        '
        Me.colItemId1.FieldName = "ItemId"
        Me.colItemId1.Name = "colItemId1"
        Me.colItemId1.OptionsColumn.ReadOnly = True
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'colDepartmentId
        '
        Me.colDepartmentId.FieldName = "DepartmentId"
        Me.colDepartmentId.Name = "colDepartmentId"
        '
        'colYarnPercentage
        '
        Me.colYarnPercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnPercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnPercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnPercentage.Caption = "Y%"
        Me.colYarnPercentage.FieldName = "YarnPercentage"
        Me.colYarnPercentage.Name = "colYarnPercentage"
        Me.colYarnPercentage.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colYarnPercentage.Visible = True
        Me.colYarnPercentage.VisibleIndex = 1
        Me.colYarnPercentage.Width = 46
        '
        'colWastagePercentage1
        '
        Me.colWastagePercentage1.AppearanceHeader.Options.UseTextOptions = True
        Me.colWastagePercentage1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWastagePercentage1.Caption = "W%"
        Me.colWastagePercentage1.FieldName = "WastagePercentage"
        Me.colWastagePercentage1.Name = "colWastagePercentage1"
        Me.colWastagePercentage1.Width = 50
        '
        'colYds_Cost2
        '
        Me.colYds_Cost2.AppearanceHeader.Options.UseTextOptions = True
        Me.colYds_Cost2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYds_Cost2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYds_Cost2.Caption = "Yds Price/kg"
        Me.colYds_Cost2.FieldName = "Yds_Cost"
        Me.colYds_Cost2.Name = "colYds_Cost2"
        Me.colYds_Cost2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colYds_Cost2.Visible = True
        Me.colYds_Cost2.VisibleIndex = 4
        Me.colYds_Cost2.Width = 130
        '
        'colYarn_Cost2
        '
        Me.colYarn_Cost2.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarn_Cost2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarn_Cost2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarn_Cost2.Caption = "Yarn Price/kg"
        Me.colYarn_Cost2.FieldName = "Yarn_Cost"
        Me.colYarn_Cost2.Name = "colYarn_Cost2"
        Me.colYarn_Cost2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colYarn_Cost2.Visible = True
        Me.colYarn_Cost2.VisibleIndex = 2
        Me.colYarn_Cost2.Width = 117
        '
        'colLot_No
        '
        Me.colLot_No.AppearanceHeader.Options.UseTextOptions = True
        Me.colLot_No.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLot_No.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLot_No.FieldName = "Lot_No"
        Me.colLot_No.Name = "colLot_No"
        '
        'colYarnColor
        '
        Me.colYarnColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnColor.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnColor.Caption = "Yarn Color (F11)"
        Me.colYarnColor.FieldName = "YarnColor"
        Me.colYarnColor.Name = "colYarnColor"
        Me.colYarnColor.Visible = True
        Me.colYarnColor.VisibleIndex = 3
        Me.colYarnColor.Width = 129
        '
        'PreCostingFabricFinishingGridControl
        '
        Me.PreCostingFabricFinishingGridControl.DataSource = Me.PreCostingFabricFinishingBindingSource1
        Me.PreCostingFabricFinishingGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PreCostingFabricFinishingGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.PreCostingFabricFinishingGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.PreCostingFabricFinishingGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.PreCostingFabricFinishingGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.PreCostingFabricFinishingGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.PreCostingFabricFinishingGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.PreCostingFabricFinishingGridControl.Location = New System.Drawing.Point(0, 0)
        Me.PreCostingFabricFinishingGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PreCostingFabricFinishingGridControl.MainView = Me.GridView9
        Me.PreCostingFabricFinishingGridControl.Name = "PreCostingFabricFinishingGridControl"
        Me.PreCostingFabricFinishingGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.FabricFinishingTypeGridLookUpEdit})
        Me.PreCostingFabricFinishingGridControl.Size = New System.Drawing.Size(319, 173)
        Me.PreCostingFabricFinishingGridControl.TabIndex = 1
        Me.PreCostingFabricFinishingGridControl.UseEmbeddedNavigator = True
        Me.PreCostingFabricFinishingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'PreCostingFabricFinishingBindingSource1
        '
        Me.PreCostingFabricFinishingBindingSource1.DataMember = "PreCostingFabric_PreCostingFabricFinishing"
        Me.PreCostingFabricFinishingBindingSource1.DataSource = Me.PreCostingFabricBindingSource
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPreCostingFabricFinishingId, Me.colPreCostingFabricId1, Me.colFabricFinishingTypeId, Me.colPricePerKg})
        Me.GridView9.GridControl = Me.PreCostingFabricFinishingGridControl
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colPreCostingFabricFinishingId
        '
        Me.colPreCostingFabricFinishingId.FieldName = "PreCostingFabricFinishingId"
        Me.colPreCostingFabricFinishingId.Name = "colPreCostingFabricFinishingId"
        Me.colPreCostingFabricFinishingId.OptionsColumn.ReadOnly = True
        '
        'colPreCostingFabricId1
        '
        Me.colPreCostingFabricId1.FieldName = "PreCostingFabricId"
        Me.colPreCostingFabricId1.Name = "colPreCostingFabricId1"
        '
        'colFabricFinishingTypeId
        '
        Me.colFabricFinishingTypeId.Caption = "Fabric Finishing Type"
        Me.colFabricFinishingTypeId.ColumnEdit = Me.FabricFinishingTypeGridLookUpEdit
        Me.colFabricFinishingTypeId.FieldName = "FabricFinishingTypeId"
        Me.colFabricFinishingTypeId.Name = "colFabricFinishingTypeId"
        Me.colFabricFinishingTypeId.Visible = True
        Me.colFabricFinishingTypeId.VisibleIndex = 0
        Me.colFabricFinishingTypeId.Width = 124
        '
        'FabricFinishingTypeGridLookUpEdit
        '
        Me.FabricFinishingTypeGridLookUpEdit.AutoHeight = False
        Me.FabricFinishingTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricFinishingTypeGridLookUpEdit.DataSource = Me.FabricFinishingTypeBindingSource
        Me.FabricFinishingTypeGridLookUpEdit.DisplayMember = "FinishingType"
        Me.FabricFinishingTypeGridLookUpEdit.Name = "FabricFinishingTypeGridLookUpEdit"
        Me.FabricFinishingTypeGridLookUpEdit.NullText = ""
        Me.FabricFinishingTypeGridLookUpEdit.PopupView = Me.GridView10
        Me.FabricFinishingTypeGridLookUpEdit.ValueMember = "FabricFinishingTypeId"
        '
        'FabricFinishingTypeBindingSource
        '
        Me.FabricFinishingTypeBindingSource.DataMember = "FabricFinishingType"
        Me.FabricFinishingTypeBindingSource.DataSource = Me.FabricFinishingTypeDataSet
        '
        'FabricFinishingTypeDataSet
        '
        Me.FabricFinishingTypeDataSet.DataSetName = "FabricFinishingTypeDataSet"
        Me.FabricFinishingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFinishingType})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'colFinishingType
        '
        Me.colFinishingType.FieldName = "FinishingType"
        Me.colFinishingType.Name = "colFinishingType"
        Me.colFinishingType.Visible = True
        Me.colFinishingType.VisibleIndex = 0
        '
        'colPricePerKg
        '
        Me.colPricePerKg.FieldName = "PricePerKg"
        Me.colPricePerKg.Name = "colPricePerKg"
        Me.colPricePerKg.Visible = True
        Me.colPricePerKg.VisibleIndex = 1
        Me.colPricePerKg.Width = 77
        '
        'TrimTabPage
        '
        Me.TrimTabPage.AutoScroll = True
        Me.TrimTabPage.Controls.Add(Me.LabelControl3)
        Me.TrimTabPage.Controls.Add(Me.Size2CheckedComboBoxEdit)
        Me.TrimTabPage.Controls.Add(Me.LabelControl4)
        Me.TrimTabPage.Controls.Add(Me.Color2CheckedComboBoxEdit)
        Me.TrimTabPage.Controls.Add(Me.ShowButton)
        Me.TrimTabPage.Controls.Add(Me.Label29)
        Me.TrimTabPage.Controls.Add(Me.CategoryComboBox)
        Me.TrimTabPage.Controls.Add(Me.Label28)
        Me.TrimTabPage.Controls.Add(Me.Label25)
        Me.TrimTabPage.Controls.Add(Me.WPercSpinEdit)
        Me.TrimTabPage.Controls.Add(Me.ConPCSSpinEdit)
        Me.TrimTabPage.Controls.Add(Me.Label26)
        Me.TrimTabPage.Controls.Add(Me.UnitIdGridLookUpEdit)
        Me.TrimTabPage.Controls.Add(Me.ConSpinEdit)
        Me.TrimTabPage.Controls.Add(Me.Label27)
        Me.TrimTabPage.Controls.Add(Me.AccLinkLabel)
        Me.TrimTabPage.Controls.Add(Me.AccNameGridLookUpEdit)
        Me.TrimTabPage.Controls.Add(Me.PreCosting_TrimsGridControl)
        Me.TrimTabPage.Controls.Add(Me.GetOrQtyTrimsButton)
        Me.TrimTabPage.Controls.Add(Me.GetAccessoriesButton)
        Me.TrimTabPage.Name = "TrimTabPage"
        Me.TrimTabPage.Size = New System.Drawing.Size(1291, 398)
        Me.TrimTabPage.Text = "Trim Details"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(481, 42)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl3.TabIndex = 50
        Me.LabelControl3.Text = "Size"
        '
        'Size2CheckedComboBoxEdit
        '
        Me.Size2CheckedComboBoxEdit.Location = New System.Drawing.Point(526, 39)
        Me.Size2CheckedComboBoxEdit.Name = "Size2CheckedComboBoxEdit"
        Me.Size2CheckedComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Size2CheckedComboBoxEdit.Properties.DataSource = Me.OrderSizeLookupBindingSource
        Me.Size2CheckedComboBoxEdit.Properties.DisplayMember = "SizeCode"
        Me.Size2CheckedComboBoxEdit.Properties.ValueMember = "SizeId"
        Me.Size2CheckedComboBoxEdit.Size = New System.Drawing.Size(107, 20)
        Me.Size2CheckedComboBoxEdit.TabIndex = 48
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(481, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl4.TabIndex = 49
        Me.LabelControl4.Text = "Color"
        '
        'Color2CheckedComboBoxEdit
        '
        Me.Color2CheckedComboBoxEdit.Location = New System.Drawing.Point(526, 9)
        Me.Color2CheckedComboBoxEdit.Name = "Color2CheckedComboBoxEdit"
        Me.Color2CheckedComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Color2CheckedComboBoxEdit.Properties.DataSource = Me.OrderFabricColorBindingSource
        Me.Color2CheckedComboBoxEdit.Properties.DisplayMember = "ColorDetails"
        Me.Color2CheckedComboBoxEdit.Properties.ValueMember = "FabricColorId"
        Me.Color2CheckedComboBoxEdit.Size = New System.Drawing.Size(107, 20)
        Me.Color2CheckedComboBoxEdit.TabIndex = 47
        '
        'ShowButton
        '
        Me.ShowButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowButton.Location = New System.Drawing.Point(1128, 33)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(156, 22)
        Me.ShowButton.TabIndex = 46
        Me.ShowButton.Text = "&Get"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(1125, 11)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(52, 13)
        Me.Label29.TabIndex = 45
        Me.Label29.Text = "Category"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CategoryComboBox.DataSource = Me.AccessoriesCategoryLookupBindingSource
        Me.CategoryComboBox.DisplayMember = "TemplateCategory"
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(1183, 8)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(101, 21)
        Me.CategoryComboBox.TabIndex = 44
        Me.CategoryComboBox.ValueMember = "TemplateCategory"
        '
        'AccessoriesCategoryLookupBindingSource
        '
        Me.AccessoriesCategoryLookupBindingSource.DataMember = "AccessoriesCategoryLookup"
        Me.AccessoriesCategoryLookupBindingSource.DataSource = Me.AccessoriesCategoryLookupDataSet
        '
        'AccessoriesCategoryLookupDataSet
        '
        Me.AccessoriesCategoryLookupDataSet.DataSetName = "AccessoriesCategoryLookupDataSet"
        Me.AccessoriesCategoryLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(254, 42)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 13)
        Me.Label28.TabIndex = 43
        Me.Label28.Tag = "NR"
        Me.Label28.Text = "Con Unit"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(384, 42)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(28, 13)
        Me.Label25.TabIndex = 42
        Me.Label25.Tag = "NR"
        Me.Label25.Text = "W%"
        '
        'WPercSpinEdit
        '
        Me.WPercSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.WPercSpinEdit.Location = New System.Drawing.Point(419, 39)
        Me.WPercSpinEdit.Name = "WPercSpinEdit"
        Me.WPercSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.WPercSpinEdit.Size = New System.Drawing.Size(43, 20)
        Me.WPercSpinEdit.TabIndex = 41
        '
        'ConPCSSpinEdit
        '
        Me.ConPCSSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ConPCSSpinEdit.Location = New System.Drawing.Point(198, 39)
        Me.ConPCSSpinEdit.Name = "ConPCSSpinEdit"
        Me.ConPCSSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ConPCSSpinEdit.Size = New System.Drawing.Size(48, 20)
        Me.ConPCSSpinEdit.TabIndex = 40
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(124, 42)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 13)
        Me.Label26.TabIndex = 39
        Me.Label26.Tag = "NR"
        Me.Label26.Text = "Con. For Pcs"
        '
        'UnitIdGridLookUpEdit
        '
        Me.UnitIdGridLookUpEdit.Location = New System.Drawing.Point(308, 39)
        Me.UnitIdGridLookUpEdit.Name = "UnitIdGridLookUpEdit"
        Me.UnitIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitIdGridLookUpEdit.Properties.DataSource = Me.UnitBindingSource
        Me.UnitIdGridLookUpEdit.Properties.DisplayMember = "UnitCode"
        Me.UnitIdGridLookUpEdit.Properties.NullText = ""
        Me.UnitIdGridLookUpEdit.Properties.PopupView = Me.GridView12
        Me.UnitIdGridLookUpEdit.Properties.ValueMember = "UnitId"
        Me.UnitIdGridLookUpEdit.Size = New System.Drawing.Size(70, 20)
        Me.UnitIdGridLookUpEdit.TabIndex = 38
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
        'GridView12
        '
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colUnitCode1, Me.colUnitName1})
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "UnitId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
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
        Me.ConSpinEdit.Location = New System.Drawing.Point(57, 39)
        Me.ConSpinEdit.Name = "ConSpinEdit"
        Me.ConSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ConSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.ConSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ConSpinEdit.Properties.EditFormat.FormatString = "n2"
        Me.ConSpinEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ConSpinEdit.Size = New System.Drawing.Size(61, 20)
        Me.ConSpinEdit.TabIndex = 37
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(18, 42)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 13)
        Me.Label27.TabIndex = 36
        Me.Label27.Tag = "NR"
        Me.Label27.Text = "Con."
        '
        'AccLinkLabel
        '
        Me.AccLinkLabel.AutoSize = True
        Me.AccLinkLabel.Location = New System.Drawing.Point(17, 12)
        Me.AccLinkLabel.Name = "AccLinkLabel"
        Me.AccLinkLabel.Size = New System.Drawing.Size(32, 13)
        Me.AccLinkLabel.TabIndex = 34
        Me.AccLinkLabel.TabStop = True
        Me.AccLinkLabel.Text = "Trims"
        '
        'AccNameGridLookUpEdit
        '
        Me.AccNameGridLookUpEdit.Location = New System.Drawing.Point(55, 9)
        Me.AccNameGridLookUpEdit.Name = "AccNameGridLookUpEdit"
        Me.AccNameGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccNameGridLookUpEdit.Properties.DataSource = Me.TrimListLookupBindingSource
        Me.AccNameGridLookUpEdit.Properties.DisplayMember = "ItemName"
        Me.AccNameGridLookUpEdit.Properties.NullText = ""
        Me.AccNameGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AccNameGridLookUpEdit.Properties.PopupView = Me.GridView11
        Me.AccNameGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AccNameGridLookUpEdit.Properties.ValueMember = "ItemId"
        Me.AccNameGridLookUpEdit.Size = New System.Drawing.Size(407, 20)
        Me.AccNameGridLookUpEdit.TabIndex = 33
        Me.AccNameGridLookUpEdit.Tag = "NR"
        '
        'TrimListLookupBindingSource
        '
        Me.TrimListLookupBindingSource.DataMember = "TrimListLookup"
        Me.TrimListLookupBindingSource.DataSource = Me.TrimListLookupDataSet
        '
        'TrimListLookupDataSet
        '
        Me.TrimListLookupDataSet.DataSetName = "TrimListLookupDataSet"
        Me.TrimListLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName1})
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'colItemName1
        '
        Me.colItemName1.FieldName = "ItemName"
        Me.colItemName1.Name = "colItemName1"
        Me.colItemName1.Visible = True
        Me.colItemName1.VisibleIndex = 0
        '
        'PreCosting_TrimsGridControl
        '
        Me.PreCosting_TrimsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreCosting_TrimsGridControl.DataSource = Me.PreCosting_TrimsBindingSource
        Me.PreCosting_TrimsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.PreCosting_TrimsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.PreCosting_TrimsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.PreCosting_TrimsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.PreCosting_TrimsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.PreCosting_TrimsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.PreCosting_TrimsGridControl.Location = New System.Drawing.Point(0, 74)
        Me.PreCosting_TrimsGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PreCosting_TrimsGridControl.MainView = Me.GridView4
        Me.PreCosting_TrimsGridControl.Name = "PreCosting_TrimsGridControl"
        Me.PreCosting_TrimsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.TrimItemLookUpEdit, Me.UnitLookUpEdit, Me.AccessoriesListGridLookUpEdit, Me.ConUnitItemGridLookUpEdit})
        Me.PreCosting_TrimsGridControl.Size = New System.Drawing.Size(1288, 326)
        Me.PreCosting_TrimsGridControl.TabIndex = 0
        Me.PreCosting_TrimsGridControl.UseEmbeddedNavigator = True
        Me.PreCosting_TrimsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'PreCosting_TrimsBindingSource
        '
        Me.PreCosting_TrimsBindingSource.DataMember = "PreCostingMain_PreCosting_Trims"
        Me.PreCosting_TrimsBindingSource.DataSource = Me.PreCostingMainBindingSource
        '
        'GridView4
        '
        Me.GridView4.ColumnPanelRowHeight = 40
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccessoriesId, Me.colConsumption1, Me.colCost, Me.colRemarks, Me.colUnitId, Me.colUnitPrice, Me.colWastagePercentage2, Me.colTUnitId, Me.colGarmentsQuantity, Me.colSL, Me.colRequireQuantity, Me.colIsAll, Me.colOrderQuantity, Me.colForColor1, Me.colForSize1, Me.colSupplier, Me.colAdditionalQuantity})
        Me.GridView4.GridControl = Me.PreCosting_TrimsGridControl
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colAccessoriesId
        '
        Me.colAccessoriesId.AppearanceHeader.Options.UseTextOptions = True
        Me.colAccessoriesId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAccessoriesId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAccessoriesId.Caption = "Trims Name"
        Me.colAccessoriesId.ColumnEdit = Me.AccessoriesListGridLookUpEdit
        Me.colAccessoriesId.FieldName = "ItemId"
        Me.colAccessoriesId.Name = "colAccessoriesId"
        Me.colAccessoriesId.OptionsColumn.ReadOnly = True
        Me.colAccessoriesId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colAccessoriesId.Visible = True
        Me.colAccessoriesId.VisibleIndex = 1
        Me.colAccessoriesId.Width = 323
        '
        'AccessoriesListGridLookUpEdit
        '
        Me.AccessoriesListGridLookUpEdit.AutoHeight = False
        Me.AccessoriesListGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccessoriesListGridLookUpEdit.DataSource = Me.TrimListLookupBindingSource
        Me.AccessoriesListGridLookUpEdit.DisplayMember = "ItemName"
        Me.AccessoriesListGridLookUpEdit.ImmediatePopup = True
        Me.AccessoriesListGridLookUpEdit.Name = "AccessoriesListGridLookUpEdit"
        Me.AccessoriesListGridLookUpEdit.NullText = ""
        Me.AccessoriesListGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AccessoriesListGridLookUpEdit.PopupView = Me.GridView6
        Me.AccessoriesListGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AccessoriesListGridLookUpEdit.ValueMember = "ItemId"
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName2})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colItemName2
        '
        Me.colItemName2.FieldName = "ItemName"
        Me.colItemName2.Name = "colItemName2"
        Me.colItemName2.Visible = True
        Me.colItemName2.VisibleIndex = 0
        '
        'colConsumption1
        '
        Me.colConsumption1.AppearanceHeader.Options.UseTextOptions = True
        Me.colConsumption1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConsumption1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colConsumption1.Caption = "Con"
        Me.colConsumption1.DisplayFormat.FormatString = "n3"
        Me.colConsumption1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colConsumption1.FieldName = "Consumption"
        Me.colConsumption1.Name = "colConsumption1"
        Me.colConsumption1.Visible = True
        Me.colConsumption1.VisibleIndex = 5
        Me.colConsumption1.Width = 59
        '
        'colCost
        '
        Me.colCost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCost.AppearanceCell.BackColor2 = System.Drawing.Color.Yellow
        Me.colCost.AppearanceCell.Options.UseBackColor = True
        Me.colCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCost.Caption = "TTL Cost"
        Me.colCost.DisplayFormat.FormatString = "n4"
        Me.colCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCost.FieldName = "Cost"
        Me.colCost.Name = "colCost"
        Me.colCost.OptionsColumn.ReadOnly = True
        Me.colCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colCost.Visible = True
        Me.colCost.VisibleIndex = 13
        Me.colCost.Width = 62
        '
        'colRemarks
        '
        Me.colRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 15
        Me.colRemarks.Width = 98
        '
        'colUnitId
        '
        Me.colUnitId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUnitId.AppearanceCell.Options.UseBackColor = True
        Me.colUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitId.Caption = "Booking Unit"
        Me.colUnitId.ColumnEdit = Me.UnitLookUpEdit
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 11
        Me.colUnitId.Width = 60
        '
        'UnitLookUpEdit
        '
        Me.UnitLookUpEdit.AutoHeight = False
        Me.UnitLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitId", "Unit Id", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitCode", "Unit Code", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "Unit Name", 59, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.UnitLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitLookUpEdit.DisplayMember = "UnitCode"
        Me.UnitLookUpEdit.Name = "UnitLookUpEdit"
        Me.UnitLookUpEdit.NullText = ""
        Me.UnitLookUpEdit.PopupFormMinSize = New System.Drawing.Size(100, 0)
        Me.UnitLookUpEdit.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.UnitLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.UnitLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UnitLookUpEdit.ValueMember = "UnitId"
        '
        'colUnitPrice
        '
        Me.colUnitPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colUnitPrice.AppearanceCell.Options.UseBackColor = True
        Me.colUnitPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitPrice.DisplayFormat.FormatString = "n5"
        Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitPrice.FieldName = "UnitPrice"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Visible = True
        Me.colUnitPrice.VisibleIndex = 12
        Me.colUnitPrice.Width = 48
        '
        'colWastagePercentage2
        '
        Me.colWastagePercentage2.AppearanceCell.Options.UseTextOptions = True
        Me.colWastagePercentage2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage2.AppearanceHeader.Options.UseTextOptions = True
        Me.colWastagePercentage2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWastagePercentage2.Caption = "Avg W%"
        Me.colWastagePercentage2.FieldName = "WastagePercentage"
        Me.colWastagePercentage2.Name = "colWastagePercentage2"
        Me.colWastagePercentage2.OptionsColumn.ReadOnly = True
        Me.colWastagePercentage2.Visible = True
        Me.colWastagePercentage2.VisibleIndex = 8
        Me.colWastagePercentage2.Width = 48
        '
        'colTUnitId
        '
        Me.colTUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colTUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTUnitId.Caption = "Con Unit"
        Me.colTUnitId.ColumnEdit = Me.ConUnitItemGridLookUpEdit
        Me.colTUnitId.FieldName = "ConUnitId"
        Me.colTUnitId.Name = "colTUnitId"
        Me.colTUnitId.Visible = True
        Me.colTUnitId.VisibleIndex = 7
        Me.colTUnitId.Width = 39
        '
        'ConUnitItemGridLookUpEdit
        '
        Me.ConUnitItemGridLookUpEdit.AutoHeight = False
        Me.ConUnitItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ConUnitItemGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.ConUnitItemGridLookUpEdit.DisplayMember = "UnitCode"
        Me.ConUnitItemGridLookUpEdit.ImmediatePopup = True
        Me.ConUnitItemGridLookUpEdit.Name = "ConUnitItemGridLookUpEdit"
        Me.ConUnitItemGridLookUpEdit.NullText = ""
        Me.ConUnitItemGridLookUpEdit.PopupView = Me.GridView8
        Me.ConUnitItemGridLookUpEdit.ValueMember = "UnitId"
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId1, Me.colUnitCode, Me.colUnitName})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
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
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 1
        '
        'colGarmentsQuantity
        '
        Me.colGarmentsQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colGarmentsQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGarmentsQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGarmentsQuantity.Caption = "For  Pcs"
        Me.colGarmentsQuantity.FieldName = "GarmentsQuantity"
        Me.colGarmentsQuantity.Name = "colGarmentsQuantity"
        Me.colGarmentsQuantity.Visible = True
        Me.colGarmentsQuantity.VisibleIndex = 6
        Me.colGarmentsQuantity.Width = 59
        '
        'colSL
        '
        Me.colSL.AppearanceHeader.Options.UseTextOptions = True
        Me.colSL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSL.FieldName = "SL"
        Me.colSL.Name = "colSL"
        Me.colSL.Visible = True
        Me.colSL.VisibleIndex = 0
        Me.colSL.Width = 47
        '
        'colRequireQuantity
        '
        Me.colRequireQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colRequireQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRequireQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRequireQuantity.FieldName = "RequireQuantity"
        Me.colRequireQuantity.Name = "colRequireQuantity"
        Me.colRequireQuantity.Visible = True
        Me.colRequireQuantity.VisibleIndex = 9
        '
        'colIsAll
        '
        Me.colIsAll.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsAll.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsAll.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsAll.Caption = "For All"
        Me.colIsAll.FieldName = "IsAll"
        Me.colIsAll.Name = "colIsAll"
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.AppearanceCell.Options.UseTextOptions = True
        Me.colOrderQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderQuantity.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrderQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrderQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 4
        '
        'colForColor1
        '
        Me.colForColor1.AppearanceHeader.Options.UseTextOptions = True
        Me.colForColor1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colForColor1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colForColor1.FieldName = "ForColor"
        Me.colForColor1.Name = "colForColor1"
        Me.colForColor1.Visible = True
        Me.colForColor1.VisibleIndex = 2
        '
        'colForSize1
        '
        Me.colForSize1.AppearanceHeader.Options.UseTextOptions = True
        Me.colForSize1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colForSize1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colForSize1.FieldName = "ForSize"
        Me.colForSize1.Name = "colForSize1"
        Me.colForSize1.Visible = True
        Me.colForSize1.VisibleIndex = 3
        '
        'colSupplier
        '
        Me.colSupplier.FieldName = "Supplier"
        Me.colSupplier.Name = "colSupplier"
        Me.colSupplier.Visible = True
        Me.colSupplier.VisibleIndex = 14
        '
        'colAdditionalQuantity
        '
        Me.colAdditionalQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colAdditionalQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAdditionalQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAdditionalQuantity.FieldName = "AdditionalQuantity"
        Me.colAdditionalQuantity.Name = "colAdditionalQuantity"
        Me.colAdditionalQuantity.Visible = True
        Me.colAdditionalQuantity.VisibleIndex = 10
        '
        'TrimItemLookUpEdit
        '
        Me.TrimItemLookUpEdit.AutoHeight = False
        Me.TrimItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TrimItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccessoriesId", "Accessories Id", 92, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccessoriesName", "Accessories Name", 96, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.TrimItemLookUpEdit.DataSource = Me.AccessoriesListLookupBindingSource
        Me.TrimItemLookUpEdit.DisplayMember = "ItemDetails"
        Me.TrimItemLookUpEdit.Name = "TrimItemLookUpEdit"
        Me.TrimItemLookUpEdit.NullText = ""
        Me.TrimItemLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.TrimItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TrimItemLookUpEdit.ValueMember = "AccessoriesId"
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
        'GetOrQtyTrimsButton
        '
        Me.GetOrQtyTrimsButton.Location = New System.Drawing.Point(759, 9)
        Me.GetOrQtyTrimsButton.Name = "GetOrQtyTrimsButton"
        Me.GetOrQtyTrimsButton.Size = New System.Drawing.Size(83, 50)
        Me.GetOrQtyTrimsButton.TabIndex = 31
        Me.GetOrQtyTrimsButton.Text = "&Get Order Quantity"
        Me.GetOrQtyTrimsButton.UseVisualStyleBackColor = True
        '
        'GetAccessoriesButton
        '
        Me.GetAccessoriesButton.Location = New System.Drawing.Point(649, 9)
        Me.GetAccessoriesButton.Name = "GetAccessoriesButton"
        Me.GetAccessoriesButton.Size = New System.Drawing.Size(83, 50)
        Me.GetAccessoriesButton.TabIndex = 31
        Me.GetAccessoriesButton.Text = "&Add"
        Me.GetAccessoriesButton.UseVisualStyleBackColor = True
        '
        'CMTabPage
        '
        Me.CMTabPage.AutoScroll = True
        Me.CMTabPage.Controls.Add(Me.PivotGridControl1)
        Me.CMTabPage.Controls.Add(Me.PreCostingOthersGridControl)
        Me.CMTabPage.Controls.Add(Me.RefreshLinkLabel)
        Me.CMTabPage.Controls.Add(Me.DefultMiscButton)
        Me.CMTabPage.Controls.Add(Me.PreCosting_CMGridControl)
        Me.CMTabPage.Controls.Add(Me.GetCMButton)
        Me.CMTabPage.Controls.Add(BuyerCMLabel)
        Me.CMTabPage.Controls.Add(Me.BuyerCMSpinEdit)
        Me.CMTabPage.Controls.Add(Me.MachineQuantitySpinEdit)
        Me.CMTabPage.Controls.Add(FactoryCMLabel)
        Me.CMTabPage.Controls.Add(Label6)
        Me.CMTabPage.Controls.Add(Me.FactoryCMSpinEdit)
        Me.CMTabPage.Controls.Add(MachineQuantityLabel)
        Me.CMTabPage.Controls.Add(ProdPerDayLabel)
        Me.CMTabPage.Controls.Add(Me.SMVSpinEdit)
        Me.CMTabPage.Controls.Add(Me.ProdPerDaySpinEdit)
        Me.CMTabPage.Name = "CMTabPage"
        Me.CMTabPage.Size = New System.Drawing.Size(1291, 398)
        Me.CMTabPage.Text = "Production + Misc"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PivotGridControl1.DataSource = Me.PreCostingTargetBindingSource
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldSL1, Me.fieldEfficiency1, Me.fieldOrderQuantity1, Me.fieldLine1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(12, 260)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(920, 145)
        Me.PivotGridControl1.TabIndex = 50
        '
        'PreCostingTargetBindingSource
        '
        Me.PreCostingTargetBindingSource.DataMember = "PreCostingTarget"
        Me.PreCostingTargetBindingSource.DataSource = Me.PreCostingDataSet
        '
        'fieldSL1
        '
        Me.fieldSL1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSL1.AreaIndex = 0
        Me.fieldSL1.Caption = "SL"
        Me.fieldSL1.FieldName = "SL"
        Me.fieldSL1.Name = "fieldSL1"
        Me.fieldSL1.Width = 50
        '
        'fieldEfficiency1
        '
        Me.fieldEfficiency1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldEfficiency1.AreaIndex = 0
        Me.fieldEfficiency1.Caption = "Eff %"
        Me.fieldEfficiency1.FieldName = "Efficiency"
        Me.fieldEfficiency1.Name = "fieldEfficiency1"
        Me.fieldEfficiency1.Width = 50
        '
        'fieldOrderQuantity1
        '
        Me.fieldOrderQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldOrderQuantity1.AreaIndex = 1
        Me.fieldOrderQuantity1.Caption = "Or. Qty"
        Me.fieldOrderQuantity1.FieldName = "OrderQuantity"
        Me.fieldOrderQuantity1.Name = "fieldOrderQuantity1"
        Me.fieldOrderQuantity1.Width = 50
        '
        'fieldLine1
        '
        Me.fieldLine1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldLine1.AreaIndex = 0
        Me.fieldLine1.Caption = "Line"
        Me.fieldLine1.FieldName = "Line"
        Me.fieldLine1.Name = "fieldLine1"
        '
        'PreCostingOthersGridControl
        '
        Me.PreCostingOthersGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreCostingOthersGridControl.DataSource = Me.PreCostingOthersBindingSource
        Me.PreCostingOthersGridControl.Location = New System.Drawing.Point(942, 68)
        Me.PreCostingOthersGridControl.MainView = Me.GridView13
        Me.PreCostingOthersGridControl.Name = "PreCostingOthersGridControl"
        Me.PreCostingOthersGridControl.Size = New System.Drawing.Size(342, 327)
        Me.PreCostingOthersGridControl.TabIndex = 49
        Me.PreCostingOthersGridControl.UseDisabledStatePainter = False
        Me.PreCostingOthersGridControl.UseEmbeddedNavigator = True
        Me.PreCostingOthersGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView13})
        '
        'PreCostingOthersBindingSource
        '
        Me.PreCostingOthersBindingSource.DataMember = "FK_PreCostingOthers_PreCostingMain"
        Me.PreCostingOthersBindingSource.DataSource = Me.PreCostingMainBindingSource
        '
        'GridView13
        '
        Me.GridView13.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView13.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView13.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView13.ColumnPanelRowHeight = 40
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCostItem, Me.colTTLCost, Me.colForPcs, Me.colCostPerDzn, Me.colPercentage, Me.colTTLCost1})
        Me.GridView13.GridControl = Me.PreCostingOthersGridControl
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsView.ColumnAutoWidth = False
        Me.GridView13.OptionsView.ShowFooter = True
        Me.GridView13.OptionsView.ShowGroupPanel = False
        '
        'colCostItem
        '
        Me.colCostItem.FieldName = "CostItem"
        Me.colCostItem.Name = "colCostItem"
        Me.colCostItem.Visible = True
        Me.colCostItem.VisibleIndex = 0
        Me.colCostItem.Width = 130
        '
        'colTTLCost
        '
        Me.colTTLCost.FieldName = "TTLCost"
        Me.colTTLCost.Name = "colTTLCost"
        Me.colTTLCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TTLCost", "{0:0.##}")})
        Me.colTTLCost.Width = 78
        '
        'colForPcs
        '
        Me.colForPcs.FieldName = "ForPcs"
        Me.colForPcs.Name = "colForPcs"
        Me.colForPcs.Width = 60
        '
        'colCostPerDzn
        '
        Me.colCostPerDzn.Caption = "Cost/Dz"
        Me.colCostPerDzn.FieldName = "CostPerDzn"
        Me.colCostPerDzn.Name = "colCostPerDzn"
        Me.colCostPerDzn.Width = 51
        '
        'colPercentage
        '
        Me.colPercentage.Caption = "%"
        Me.colPercentage.FieldName = "Percentage"
        Me.colPercentage.Name = "colPercentage"
        Me.colPercentage.Visible = True
        Me.colPercentage.VisibleIndex = 1
        Me.colPercentage.Width = 50
        '
        'colTTLCost1
        '
        Me.colTTLCost1.FieldName = "TTLCost"
        Me.colTTLCost1.Name = "colTTLCost1"
        Me.colTTLCost1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TTLCost", "{0:0.##}")})
        Me.colTTLCost1.Visible = True
        Me.colTTLCost1.VisibleIndex = 2
        Me.colTTLCost1.Width = 100
        '
        'RefreshLinkLabel
        '
        Me.RefreshLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshLinkLabel.AutoSize = True
        Me.RefreshLinkLabel.Location = New System.Drawing.Point(876, 238)
        Me.RefreshLinkLabel.Name = "RefreshLinkLabel"
        Me.RefreshLinkLabel.Size = New System.Drawing.Size(48, 13)
        Me.RefreshLinkLabel.TabIndex = 78
        Me.RefreshLinkLabel.TabStop = True
        Me.RefreshLinkLabel.Text = "Refresh "
        '
        'DefultMiscButton
        '
        Me.DefultMiscButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DefultMiscButton.Location = New System.Drawing.Point(1128, 26)
        Me.DefultMiscButton.Name = "DefultMiscButton"
        Me.DefultMiscButton.Size = New System.Drawing.Size(156, 24)
        Me.DefultMiscButton.TabIndex = 37
        Me.DefultMiscButton.Text = "Get Defult Misc Cost"
        Me.DefultMiscButton.UseVisualStyleBackColor = True
        '
        'PreCosting_CMGridControl
        '
        Me.PreCosting_CMGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreCosting_CMGridControl.DataSource = Me.PreCosting_CMBindingSource
        Me.PreCosting_CMGridControl.Location = New System.Drawing.Point(12, 68)
        Me.PreCosting_CMGridControl.MainView = Me.PreCostingCMGridView
        Me.PreCosting_CMGridControl.Name = "PreCosting_CMGridControl"
        Me.PreCosting_CMGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SubStyleGridLookUpEdit, Me.LayoutGridLookUpEdit})
        Me.PreCosting_CMGridControl.Size = New System.Drawing.Size(920, 163)
        Me.PreCosting_CMGridControl.TabIndex = 48
        Me.PreCosting_CMGridControl.UseEmbeddedNavigator = True
        Me.PreCosting_CMGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.PreCostingCMGridView})
        '
        'PreCosting_CMBindingSource
        '
        Me.PreCosting_CMBindingSource.DataMember = "FK_PreCosting_CM_PreCostingMain"
        Me.PreCosting_CMBindingSource.DataSource = Me.PreCostingMainBindingSource
        '
        'PreCostingCMGridView
        '
        Me.PreCostingCMGridView.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.PreCostingCMGridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PreCostingCMGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.PreCostingCMGridView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand6, Me.GridBand5, Me.gridBand7, Me.gridBand8, Me.gridBand9})
        Me.PreCostingCMGridView.ColumnPanelRowHeight = 40
        Me.PreCostingCMGridView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colProductionPerHour, Me.colBUYER_CM, Me.colFACTORY_CM, Me.colMachineQuantity, Me.colCostPerMCPerHour, Me.colSMV1, Me.colStyleId1, Me.colRemarks1, Me.colWashCostDzn, Me.colPrintCostDzn, Me.colEmbCostDzn, Me.colEmbWP, Me.colPrintWP, Me.colWashWP, Me.colCostPerMinute, Me.colLayoutId, Me.colLineQuantity, Me.colDayRequire, Me.colEfficiency})
        Me.PreCostingCMGridView.GridControl = Me.PreCosting_CMGridControl
        Me.PreCostingCMGridView.Name = "PreCostingCMGridView"
        Me.PreCostingCMGridView.OptionsView.ColumnAutoWidth = False
        Me.PreCostingCMGridView.OptionsView.ShowGroupPanel = False
        Me.PreCostingCMGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colLayoutId, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'gridBand6
        '
        Me.gridBand6.Caption = "Style"
        Me.gridBand6.Columns.Add(Me.colStyleId1)
        Me.gridBand6.Name = "gridBand6"
        Me.gridBand6.VisibleIndex = 0
        Me.gridBand6.Width = 167
        '
        'colStyleId1
        '
        Me.colStyleId1.Caption = "Sub Style No [F11]"
        Me.colStyleId1.ColumnEdit = Me.SubStyleGridLookUpEdit
        Me.colStyleId1.FieldName = "StyleId"
        Me.colStyleId1.Name = "colStyleId1"
        Me.colStyleId1.Visible = True
        Me.colStyleId1.Width = 167
        '
        'SubStyleGridLookUpEdit
        '
        Me.SubStyleGridLookUpEdit.AutoHeight = False
        Me.SubStyleGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SubStyleGridLookUpEdit.DataSource = Me.StyleBindingSource
        Me.SubStyleGridLookUpEdit.DisplayMember = "StyleName"
        Me.SubStyleGridLookUpEdit.Name = "SubStyleGridLookUpEdit"
        Me.SubStyleGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SubStyleGridLookUpEdit.PopupView = Me.GridView18
        Me.SubStyleGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SubStyleGridLookUpEdit.ValueMember = "StyleId"
        '
        'GridView18
        '
        Me.GridView18.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView18.Name = "GridView18"
        Me.GridView18.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView18.OptionsView.ShowGroupPanel = False
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "CM"
        Me.GridBand5.Columns.Add(Me.colProductionPerHour)
        Me.GridBand5.Columns.Add(Me.colBUYER_CM)
        Me.GridBand5.Columns.Add(Me.colFACTORY_CM)
        Me.GridBand5.Columns.Add(Me.colMachineQuantity)
        Me.GridBand5.Columns.Add(Me.colCostPerMCPerHour)
        Me.GridBand5.Columns.Add(Me.colCostPerMinute)
        Me.GridBand5.Columns.Add(Me.colSMV1)
        Me.GridBand5.Columns.Add(Me.colLineQuantity)
        Me.GridBand5.Columns.Add(Me.colDayRequire)
        Me.GridBand5.Columns.Add(Me.colEfficiency)
        Me.GridBand5.Columns.Add(Me.colLayoutId)
        Me.GridBand5.Columns.Add(Me.colRemarks1)
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.VisibleIndex = 1
        Me.GridBand5.Width = 1027
        '
        'colProductionPerHour
        '
        Me.colProductionPerHour.Caption = "Prod/Hr"
        Me.colProductionPerHour.FieldName = "ProductionPerHour"
        Me.colProductionPerHour.Name = "colProductionPerHour"
        Me.colProductionPerHour.OptionsColumn.ReadOnly = True
        Me.colProductionPerHour.Visible = True
        Me.colProductionPerHour.Width = 71
        '
        'colBUYER_CM
        '
        Me.colBUYER_CM.Caption = "Buyer CM"
        Me.colBUYER_CM.FieldName = "BUYER_CM"
        Me.colBUYER_CM.Name = "colBUYER_CM"
        Me.colBUYER_CM.Visible = True
        Me.colBUYER_CM.Width = 51
        '
        'colFACTORY_CM
        '
        Me.colFACTORY_CM.Caption = "Factory CM"
        Me.colFACTORY_CM.DisplayFormat.FormatString = "n2"
        Me.colFACTORY_CM.FieldName = "FACTORY_CM"
        Me.colFACTORY_CM.Name = "colFACTORY_CM"
        Me.colFACTORY_CM.OptionsColumn.ReadOnly = True
        Me.colFACTORY_CM.Visible = True
        Me.colFACTORY_CM.Width = 58
        '
        'colMachineQuantity
        '
        Me.colMachineQuantity.FieldName = "MachineQuantity"
        Me.colMachineQuantity.Name = "colMachineQuantity"
        Me.colMachineQuantity.OptionsColumn.ReadOnly = True
        Me.colMachineQuantity.Visible = True
        Me.colMachineQuantity.Width = 64
        '
        'colCostPerMCPerHour
        '
        Me.colCostPerMCPerHour.FieldName = "CostPerMCPerHour"
        Me.colCostPerMCPerHour.Name = "colCostPerMCPerHour"
        Me.colCostPerMCPerHour.OptionsColumn.ReadOnly = True
        Me.colCostPerMCPerHour.Visible = True
        Me.colCostPerMCPerHour.Width = 77
        '
        'colCostPerMinute
        '
        Me.colCostPerMinute.FieldName = "CostPerMinute"
        Me.colCostPerMinute.Name = "colCostPerMinute"
        Me.colCostPerMinute.OptionsColumn.ReadOnly = True
        Me.colCostPerMinute.Visible = True
        '
        'colSMV1
        '
        Me.colSMV1.DisplayFormat.FormatString = "n2"
        Me.colSMV1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSMV1.FieldName = "SMV"
        Me.colSMV1.Name = "colSMV1"
        Me.colSMV1.OptionsColumn.ReadOnly = True
        Me.colSMV1.Visible = True
        Me.colSMV1.Width = 62
        '
        'colLineQuantity
        '
        Me.colLineQuantity.Caption = "Require Line"
        Me.colLineQuantity.FieldName = "LineQuantity"
        Me.colLineQuantity.Name = "colLineQuantity"
        Me.colLineQuantity.Visible = True
        '
        'colDayRequire
        '
        Me.colDayRequire.FieldName = "DayRequire"
        Me.colDayRequire.Name = "colDayRequire"
        Me.colDayRequire.Visible = True
        '
        'colEfficiency
        '
        Me.colEfficiency.Caption = "Avg Eff %"
        Me.colEfficiency.FieldName = "Efficiency"
        Me.colEfficiency.Name = "colEfficiency"
        Me.colEfficiency.Visible = True
        '
        'colLayoutId
        '
        Me.colLayoutId.Caption = "Sewing Layout No"
        Me.colLayoutId.ColumnEdit = Me.LayoutGridLookUpEdit
        Me.colLayoutId.FieldName = "LayoutId"
        Me.colLayoutId.Name = "colLayoutId"
        Me.colLayoutId.Visible = True
        Me.colLayoutId.Width = 153
        '
        'LayoutGridLookUpEdit
        '
        Me.LayoutGridLookUpEdit.AutoHeight = False
        Me.LayoutGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LayoutGridLookUpEdit.DataSource = Me.SewingLayoutBindingSource
        Me.LayoutGridLookUpEdit.DisplayMember = "SewingLayoutNo"
        Me.LayoutGridLookUpEdit.Name = "LayoutGridLookUpEdit"
        Me.LayoutGridLookUpEdit.PopupView = Me.GridView3
        Me.LayoutGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LayoutGridLookUpEdit.ValueMember = "LayoutId"
        '
        'SewingLayoutBindingSource
        '
        Me.SewingLayoutBindingSource.DataMember = "SewingLayout"
        Me.SewingLayoutBindingSource.DataSource = Me.SewingLayoutLookupDataSet
        '
        'SewingLayoutLookupDataSet
        '
        Me.SewingLayoutLookupDataSet.DataSetName = "SewingLayoutLookupDataSet"
        Me.SewingLayoutLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSewingLayoutNo, Me.colStyleName1, Me.colLayoutDate})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colSewingLayoutNo
        '
        Me.colSewingLayoutNo.FieldName = "SewingLayoutNo"
        Me.colSewingLayoutNo.Name = "colSewingLayoutNo"
        Me.colSewingLayoutNo.Visible = True
        Me.colSewingLayoutNo.VisibleIndex = 0
        '
        'colStyleName1
        '
        Me.colStyleName1.FieldName = "StyleName"
        Me.colStyleName1.Name = "colStyleName1"
        Me.colStyleName1.Visible = True
        Me.colStyleName1.VisibleIndex = 1
        '
        'colLayoutDate
        '
        Me.colLayoutDate.FieldName = "LayoutDate"
        Me.colLayoutDate.Name = "colLayoutDate"
        Me.colLayoutDate.Visible = True
        Me.colLayoutDate.VisibleIndex = 2
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.Width = 191
        '
        'gridBand7
        '
        Me.gridBand7.Caption = "Print Cost/Dz"
        Me.gridBand7.Name = "gridBand7"
        Me.gridBand7.Visible = False
        Me.gridBand7.VisibleIndex = -1
        Me.gridBand7.Width = 89
        '
        'gridBand8
        '
        Me.gridBand8.Caption = "Wash Cost/Dz"
        Me.gridBand8.Name = "gridBand8"
        Me.gridBand8.Visible = False
        Me.gridBand8.VisibleIndex = -1
        Me.gridBand8.Width = 90
        '
        'gridBand9
        '
        Me.gridBand9.Caption = "Print+Embroidery+Wash"
        Me.gridBand9.Columns.Add(Me.colEmbCostDzn)
        Me.gridBand9.Columns.Add(Me.colEmbWP)
        Me.gridBand9.Columns.Add(Me.colPrintCostDzn)
        Me.gridBand9.Columns.Add(Me.colPrintWP)
        Me.gridBand9.Columns.Add(Me.colWashCostDzn)
        Me.gridBand9.Columns.Add(Me.colWashWP)
        Me.gridBand9.Name = "gridBand9"
        Me.gridBand9.VisibleIndex = 2
        Me.gridBand9.Width = 438
        '
        'colEmbCostDzn
        '
        Me.colEmbCostDzn.FieldName = "EmbCostDzn"
        Me.colEmbCostDzn.Name = "colEmbCostDzn"
        Me.colEmbCostDzn.Visible = True
        Me.colEmbCostDzn.Width = 63
        '
        'colEmbWP
        '
        Me.colEmbWP.Caption = "Emb %"
        Me.colEmbWP.FieldName = "EmbWP"
        Me.colEmbWP.Name = "colEmbWP"
        Me.colEmbWP.Visible = True
        '
        'colPrintCostDzn
        '
        Me.colPrintCostDzn.FieldName = "PrintCostDzn"
        Me.colPrintCostDzn.Name = "colPrintCostDzn"
        Me.colPrintCostDzn.Visible = True
        '
        'colPrintWP
        '
        Me.colPrintWP.Caption = "Print %"
        Me.colPrintWP.FieldName = "PrintWP"
        Me.colPrintWP.Name = "colPrintWP"
        Me.colPrintWP.Visible = True
        '
        'colWashCostDzn
        '
        Me.colWashCostDzn.FieldName = "WashCostDzn"
        Me.colWashCostDzn.Name = "colWashCostDzn"
        Me.colWashCostDzn.Visible = True
        '
        'colWashWP
        '
        Me.colWashWP.Caption = "Wash %"
        Me.colWashWP.FieldName = "WashWP"
        Me.colWashWP.Name = "colWashWP"
        Me.colWashWP.Visible = True
        '
        'GetCMButton
        '
        Me.GetCMButton.Location = New System.Drawing.Point(748, 26)
        Me.GetCMButton.Name = "GetCMButton"
        Me.GetCMButton.Size = New System.Drawing.Size(71, 24)
        Me.GetCMButton.TabIndex = 32
        Me.GetCMButton.Text = "&Get CM"
        Me.GetCMButton.UseVisualStyleBackColor = True
        '
        'BuyerCMSpinEdit
        '
        Me.BuyerCMSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "BuyerCM", True))
        Me.BuyerCMSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.BuyerCMSpinEdit.Location = New System.Drawing.Point(666, 29)
        Me.BuyerCMSpinEdit.Name = "BuyerCMSpinEdit"
        Me.BuyerCMSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.BuyerCMSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.BuyerCMSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.BuyerCMSpinEdit.Properties.ReadOnly = True
        Me.BuyerCMSpinEdit.Size = New System.Drawing.Size(61, 20)
        Me.BuyerCMSpinEdit.TabIndex = 36
        '
        'MachineQuantitySpinEdit
        '
        Me.MachineQuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "MachineQuantity", True))
        Me.MachineQuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MachineQuantitySpinEdit.Location = New System.Drawing.Point(121, 29)
        Me.MachineQuantitySpinEdit.Name = "MachineQuantitySpinEdit"
        Me.MachineQuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.MachineQuantitySpinEdit.Properties.ReadOnly = True
        Me.MachineQuantitySpinEdit.Size = New System.Drawing.Size(52, 20)
        Me.MachineQuantitySpinEdit.TabIndex = 33
        '
        'FactoryCMSpinEdit
        '
        Me.FactoryCMSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "FactoryCM", True))
        Me.FactoryCMSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.FactoryCMSpinEdit.Location = New System.Drawing.Point(533, 29)
        Me.FactoryCMSpinEdit.Name = "FactoryCMSpinEdit"
        Me.FactoryCMSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FactoryCMSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.FactoryCMSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.FactoryCMSpinEdit.Properties.ReadOnly = True
        Me.FactoryCMSpinEdit.Size = New System.Drawing.Size(64, 20)
        Me.FactoryCMSpinEdit.TabIndex = 35
        '
        'SMVSpinEdit
        '
        Me.SMVSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "SMV", True))
        Me.SMVSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SMVSpinEdit.Location = New System.Drawing.Point(217, 29)
        Me.SMVSpinEdit.Name = "SMVSpinEdit"
        Me.SMVSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SMVSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.SMVSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SMVSpinEdit.Properties.ReadOnly = True
        Me.SMVSpinEdit.Size = New System.Drawing.Size(69, 20)
        Me.SMVSpinEdit.TabIndex = 35
        '
        'ProdPerDaySpinEdit
        '
        Me.ProdPerDaySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PreCostingMainBindingSource, "ProdPerDay", True))
        Me.ProdPerDaySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ProdPerDaySpinEdit.Location = New System.Drawing.Point(380, 29)
        Me.ProdPerDaySpinEdit.Name = "ProdPerDaySpinEdit"
        Me.ProdPerDaySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ProdPerDaySpinEdit.Properties.ReadOnly = True
        Me.ProdPerDaySpinEdit.Size = New System.Drawing.Size(71, 20)
        Me.ProdPerDaySpinEdit.TabIndex = 34
        '
        'ProgramLookupBindingSource
        '
        Me.ProgramLookupBindingSource.DataMember = "ProgramLookup"
        Me.ProgramLookupBindingSource.DataSource = Me.PreCostingDataSet
        '
        'CM_FirstLayoutBindingSource
        '
        Me.CM_FirstLayoutBindingSource.DataMember = "CM_FirstLayout"
        Me.CM_FirstLayoutBindingSource.DataSource = Me.CuttingMakingDataSet
        '
        'CuttingMakingDataSet
        '
        Me.CuttingMakingDataSet.DataSetName = "CuttingMakingDataSet"
        Me.CuttingMakingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccessoriesListBindingSource
        '
        Me.AccessoriesListBindingSource.DataMember = "AccessoriesList"
        Me.AccessoriesListBindingSource.DataSource = Me.AccessoriesListDataSet
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'GarmentsPartTableAdapter
        '
        Me.GarmentsPartTableAdapter.ClearBeforeFill = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesListTableAdapter
        '
        Me.AccessoriesListTableAdapter.ClearBeforeFill = True
        '
        'GSMTableAdapter
        '
        Me.GSMTableAdapter.ClearBeforeFill = True
        '
        'PreCostingProgramLookupTableAdapter
        '
        Me.PreCostingProgramLookupTableAdapter.ClearBeforeFill = True
        '
        'PreCostingMainPreCostingTrimsBindingSource
        '
        Me.PreCostingMainPreCostingTrimsBindingSource.DataMember = "PreCostingMain_PreCosting_Trims"
        Me.PreCostingMainPreCostingTrimsBindingSource.DataSource = Me.PreCostingMainBindingSource
        '
        'AccessoriesListLookupTableAdapter
        '
        Me.AccessoriesListLookupTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'CM_FirstLayoutTableAdapter
        '
        Me.CM_FirstLayoutTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.CuttingMakingTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.CuttingMakingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingLayoutTableAdapter
        '
        Me.SewingLayoutTableAdapter.ClearBeforeFill = True
        '
        'PreCostingFabricFinishingBindingSource
        '
        Me.PreCostingFabricFinishingBindingSource.DataMember = "PreCostingFabricFinishing"
        Me.PreCostingFabricFinishingBindingSource.DataSource = Me.PreCostingDataSet
        '
        'FabricFinishingTypeTableAdapter
        '
        Me.FabricFinishingTypeTableAdapter.ClearBeforeFill = True
        '
        'DyeingTypeTableAdapter
        '
        Me.DyeingTypeTableAdapter.ClearBeforeFill = True
        '
        'TrimListLookupTableAdapter
        '
        Me.TrimListLookupTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesCategoryLookupTableAdapter
        '
        Me.AccessoriesCategoryLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderLookupByStyleTableAdapter
        '
        Me.OrderLookupByStyleTableAdapter.ClearBeforeFill = True
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        Me.colProgramNo1.Visible = True
        Me.colProgramNo1.VisibleIndex = 0
        '
        'ProgramLookupTableAdapter
        '
        Me.ProgramLookupTableAdapter.ClearBeforeFill = True
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1320, 418)
        '
        'OrderSizeLookupTableAdapter
        '
        Me.OrderSizeLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderFabricColorTableAdapter
        '
        Me.OrderFabricColorTableAdapter.ClearBeforeFill = True
        '
        'PreCostingTargetTableAdapter
        '
        Me.PreCostingTargetTableAdapter.ClearBeforeFill = True
        '
        'frmPreCosting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 690)
        Me.Controls.Add(Me.SplitContainer1)
        Me.KeyPreview = True
        Me.Name = "frmPreCosting"
        Me.Text = "Pre Costing/Budget "
        CType(Me.ItemListLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentPartLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingtypeLookupEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingMainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovalCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Washing_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupByStyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricFinishing_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfferPrice0TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfferPricePcsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactoryCMSpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTLCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProcessLossPercentageSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActProfitSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarginPercentageSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.PrecostingGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemarksTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FO_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Print_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmndSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubStyleSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Yarn_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dyeing_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Yds_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Knitting_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AOP_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMB_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderQuantityCPSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trim_CostSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyIdLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.FabricTabPage.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SizeCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingFabricGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingFabricBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingFabBandedGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaTypeComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaUnitComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishUnitComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.PreCosting_YarnGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCosting_YarnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingYarnGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnListGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingFabricFinishingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingFabricFinishingBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricFinishingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricFinishingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricFinishingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TrimTabPage.ResumeLayout(False)
        Me.TrimTabPage.PerformLayout()
        CType(Me.Size2CheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color2CheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesCategoryLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WPercSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConPCSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccNameGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrimListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrimListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCosting_TrimsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCosting_TrimsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesListGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConUnitItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrimItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMTabPage.ResumeLayout(False)
        Me.CMTabPage.PerformLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingTargetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingOthersGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingOthersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCosting_CMGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCosting_CMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingCMGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubStyleGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingLayoutLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerCMSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FactoryCMSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMVSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdPerDaySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM_FirstLayoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingMakingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingMainPreCostingTrimsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingFabricFinishingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PreCostingDataSet As KSoft_Apparel.PreCostingDataSet
    Friend WithEvents PreCostingMainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreCostingMainTableAdapter As KSoft_Apparel.PreCostingDataSetTableAdapters.PreCostingMainTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PreCostingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents FabricTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TrimTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PreCostingFabricTableAdapter As KSoft_Apparel.PreCostingDataSetTableAdapters.PreCostingFabricTableAdapter
    Friend WithEvents PreCostingFabricBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyDataSet As KSoft_Apparel.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Apparel.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents GarmentsPartDataSet As KSoft_Apparel.GarmentsPartDataSet
    Friend WithEvents GarmentsPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartTableAdapter As KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents PreCosting_YarnTableAdapter As KSoft_Apparel.PreCostingDataSetTableAdapters.PreCosting_YarnTableAdapter
    Friend WithEvents PreCosting_YarnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreCosting_YarnGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents PreCostingYarnGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPreCostingYarnId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreCostingFabricId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWastagePercentage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYds_Cost2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarn_Cost2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLot_No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Apparel.ItemListLookupDataSet
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents PreCostingFabricGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents PreCosting_TrimsTableAdapter As KSoft_Apparel.PreCostingDataSetTableAdapters.PreCosting_TrimsTableAdapter
    Friend WithEvents PreCosting_TrimsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreCosting_TrimsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccessoriesId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TrimItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents AccessoriesListDataSet As KSoft_Apparel.AccessoriesListDataSet
    Friend WithEvents AccessoriesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesListTableAdapter As KSoft_Apparel.AccessoriesListDataSetTableAdapters.AccessoriesListTableAdapter
    Friend WithEvents GSMDataSet As KSoft_Apparel.GSMDataSet
    Friend WithEvents GSMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GSMTableAdapter As KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
    Friend WithEvents CMTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PreCostingDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CompanyIdLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents OrderQuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Yarn_CostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Yds_CostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Dyeing_CostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Knitting_CostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AOP_CostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Print_CostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EMB_CostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FO_CostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Trim_CostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GSMTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RemarksTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PreCostingFabBandedGridView As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colGarmentsPartId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colKnittingTypeId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompositionId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colConsumption As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWastagePercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFabricColorName1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGSMId1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colYarn_Cost1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colYds_Cost1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colKnitting_Cost1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDyeing_Cost1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAOP_Cost1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents UpdateCostButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents PreCostingProgramLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreCostingProgramLookupTableAdapter As KSoft_Apparel.PreCostingDataSetTableAdapters.PreCostingProgramLookupTableAdapter
    Friend WithEvents colConsumption1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWastagePercentage2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PreCostingMainPreCostingTrimsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesListLookupTableAdapter As KSoft_Apparel.AccessoriesListDataSetTableAdapters.AccessoriesListLookupTableAdapter
    Friend WithEvents UnitLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ItemListLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GarmentPartLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KnittingtypeLookupEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CompositionLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GSMItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GetAccessoriesButton As System.Windows.Forms.Button
    Friend WithEvents StyleIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents StyleIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GetCMButton As System.Windows.Forms.Button
    Friend WithEvents PrecostingGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerCMSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FactoryCMSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ProdPerDaySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents MachineQuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CuttingMakingDataSet As KSoft_Apparel.CuttingMakingDataSet
    Friend WithEvents CM_FirstLayoutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CM_FirstLayoutTableAdapter As KSoft_Apparel.CuttingMakingDataSetTableAdapters.CM_FirstLayoutTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.CuttingMakingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SewingLayoutLookupDataSet As KSoft_Apparel.SewingLayoutLookupDataSet
    Friend WithEvents SewingLayoutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingLayoutTableAdapter As KSoft_Apparel.SewingLayoutLookupDataSetTableAdapters.SewingLayoutTableAdapter
    Friend WithEvents DefultMiscButton As System.Windows.Forms.Button
    Friend WithEvents GarmentsPartGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGarmentsPartId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KnittingTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKnittingTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompositionGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GSMGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCompositionId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscontinue1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSMId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSMCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccessoriesListGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents YarnListGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ConUnitItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGarmentsQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProcessLossPercentageSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents MarginPercentageSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TTLCostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FactoryCMSpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents OfferPricePcsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colProcessLossPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTLFabricCost As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDyeingType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DyeingTypeLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultTarget As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GetFabricButton As System.Windows.Forms.Button
    Friend WithEvents GetYarnButton As System.Windows.Forms.Button
    Friend WithEvents PreCostingFabricFinishingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreCostingFabricFinishingTableAdapter As KSoft_Apparel.PreCostingDataSetTableAdapters.PreCostingFabricFinishingTableAdapter
    Friend WithEvents PreCostingFabricFinishingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents PreCostingFabricFinishingBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPreCostingFabricFinishingId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreCostingFabricId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricFinishingTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPricePerKg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabricFinishing_CostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents FabricFinishingTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricFinishingTypeDataSet As KSoft_Apparel.FabricFinishingTypeDataSet
    Friend WithEvents FabricFinishingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricFinishingTypeTableAdapter As KSoft_Apparel.FabricFinishingTypeDataSetTableAdapters.FabricFinishingTypeTableAdapter
    Friend WithEvents colFinishingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents colFinishing_Cost As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DyeingTypeDataSet As KSoft_Apparel.DyeingTypeDataSet
    Friend WithEvents DyeingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DyeingTypeTableAdapter As KSoft_Apparel.DyeingTypeDataSetTableAdapters.DyeingTypeTableAdapter
    Friend WithEvents GPFFButton As System.Windows.Forms.Button
    Friend WithEvents Washing_CostSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents AccLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents AccNameGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents WPercSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ConPCSSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents UnitIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ConSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents colItemName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TrimListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrimListLookupDataSet As KSoft_Apparel.TrimListLookupDataSet
    Friend WithEvents TrimListLookupTableAdapter As KSoft_Apparel.TrimListLookupDataSetTableAdapters.TrimListLookupTableAdapter
    Friend WithEvents AccessoriesCategoryLookupDataSet As KSoft_Apparel.AccessoriesCategoryLookupDataSet
    Friend WithEvents AccessoriesCategoryLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesCategoryLookupTableAdapter As KSoft_Apparel.AccessoriesCategoryLookupDataSetTableAdapters.AccessoriesCategoryLookupTableAdapter
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OrderLookupByStyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupByStyleTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupByStyleTableAdapter
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PreCostingOthersBindingSource As BindingSource
    Friend WithEvents PreCostingOthersTableAdapter As PreCostingDataSetTableAdapters.PreCostingOthersTableAdapter
    Friend WithEvents FilterButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents OfferPrice0TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CopyButton As Button
    Friend WithEvents PreCostingNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label22 As Label
    Friend WithEvents OrderLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgramLookupBindingSource As BindingSource
    Friend WithEvents ProgramLookupTableAdapter As PreCostingDataSetTableAdapters.ProgramLookupTableAdapter
    Friend WithEvents CancelCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ApprovalCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CompleteCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label23 As Label
    Friend WithEvents StyleIdLabel As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents colSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SMVSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label30 As Label
    Friend WithEvents SubStyleSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PreCosting_CMBindingSource As BindingSource
    Friend WithEvents PreCosting_CMTableAdapter As PreCostingDataSetTableAdapters.PreCosting_CMTableAdapter
    Friend WithEvents PreCosting_CMGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents colRequireQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsAll As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SubStyleGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PreCostingOthersGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCostItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForPcs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostPerDzn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents colPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFDia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDiaType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDiaUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTLCost1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmndSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCCSize As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLength As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents FinishUnitComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DiaUnitComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DiaTypeComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GenerateButton As Button
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SizeCheckedComboBoxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ColorCheckedComboBoxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents colOrderQuantity1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colKgPerUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCCCostPerDzn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents OrderSizeDataSet As OrderSizeDataSet
    Friend WithEvents OrderSizeLookupBindingSource As BindingSource
    Friend WithEvents OrderSizeLookupTableAdapter As OrderSizeDataSetTableAdapters.OrderSizeLookupTableAdapter
    Friend WithEvents OrderFabricColorTableAdapter As OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents OrderFabricColorBindingSource As BindingSource
    Friend WithEvents OrderFabricColorDataSet As OrderFabricColorDataSet
    Friend WithEvents colForSize As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colForColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CopyFabricButton As Button
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Size2CheckedComboBoxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Color2CheckedComboBoxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents GetOrQtyTrimsButton As Button
    Friend WithEvents colForColor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colForSize1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnitting_Cost_Dzn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBQty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PreCostingCMGridView As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colStyleId1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProductionPerHour As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBUYER_CM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFACTORY_CM As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMachineQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCostPerMCPerHour As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSMV1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEmbCostDzn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrintCostDzn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWashCostDzn As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ActProfitSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents colEmbWP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrintWP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWashWP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPreCostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAOP_WP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DeleteButton As Button
    Friend WithEvents colCostPerMinute As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLineQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLayoutId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LayoutGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSewingLayoutNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDayRequire As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colEfficiency As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand9 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents OrderQuantityCPSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PreCostingTargetBindingSource As BindingSource
    Friend WithEvents PreCostingTargetTableAdapter As PreCostingDataSetTableAdapters.PreCostingTargetTableAdapter
    Friend WithEvents fieldSL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEfficiency1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLine1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents RefreshLinkLabel As LinkLabel
    Friend WithEvents SpinEdit3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label31 As Label
    Friend WithEvents colSupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents colStyleName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLayoutDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label32 As Label
    Friend WithEvents colAdditionalQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colAdditionalQuantity1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
