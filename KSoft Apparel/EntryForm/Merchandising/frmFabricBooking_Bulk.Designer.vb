<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFabricBooking_Bulk
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
        Dim OrderIdLabel As System.Windows.Forms.Label
        Dim FabricBookingDateLabel As System.Windows.Forms.Label
        Dim FabricReqDateLabel As System.Windows.Forms.Label
        Dim ExplationForAdditionalFabricQtyLabel As System.Windows.Forms.Label
        Dim CheckWithLabel As System.Windows.Forms.Label
        Dim ProceedForKnittingLabel As System.Windows.Forms.Label
        Dim AmendmentNoLabel As System.Windows.Forms.Label
        Dim AmendmentDetailsLabel As System.Windows.Forms.Label
        Dim AmendmentDateLabel As System.Windows.Forms.Label
        Dim FabricBOMIdLabel As System.Windows.Forms.Label
        Dim ProgramCommentsLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim SupplierIdLabel As System.Windows.Forms.Label
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim WashReferenceLabel1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SizeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.OrderSizeLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderSizeDataSet = New KSoft_Apparel.OrderSizeDataSet()
        Me.ColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.OrderFabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderFabricColorDataSet = New KSoft_Apparel.OrderFabricColorDataSet()
        Me.ContrastColorLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.SizeLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ColorLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.YarnDyeingTypeGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.YarnDyeingTypeGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.IsAOPCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FabricBOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBOMDataSet = New KSoft_Apparel.FabricBOMDataSet()
        Me.BookingStartDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PrintDetailsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrderQuantityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsEmbroideryCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsYDSCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsBrushCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsPeachFinishCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.DiscontinueCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.CauseofDiscontinueTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsPrintCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.EmbDetailsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AOPDetailsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsWashCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.WashTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.WashTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WashTypeDataSet = New KSoft_Apparel.WashTypeDataSet()
        Me.WashTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.WashDetailsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SampleDetailsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SampleReferenceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WashReferenceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CuttingStartCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.DyeingStartCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.KnittingStartCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.YarnReceivedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FDCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.DyeingCommentsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsFabricBOMCompleteCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.SupplierIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.SupplierIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Apparel.UserDataSet()
        Me.UserIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPASSWORD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_LEVEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACTIVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerLabel = New System.Windows.Forms.Label()
        Me.FabricBookingDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.OrderIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.OrderIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricReqDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AmendmentNoSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AmendmentDetailsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AmendmentDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AmendmentSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.FabricBOMIdLabel1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.POGroupLabel = New System.Windows.Forms.Label()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FabricBOMIdSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBOMIdSearchDataSet = New KSoft_Apparel.FabricBOMIdSearchDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GetDataButton = New System.Windows.Forms.Button()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AsignedColorAndSizeButton = New System.Windows.Forms.Button()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CopyTextBox = New System.Windows.Forms.NumericUpDown()
        Me.SetCColorButton = New System.Windows.Forms.Button()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.RefTextBox = New System.Windows.Forms.TextBox()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.CColorGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView19 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.SizeCheckedComboBoxEdit = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.FabricGridControl = New DevExpress.XtraGrid.GridControl()
        Me.FabricBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colFabricId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
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
        Me.colGSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFinishFabricDia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDiaType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DiaTypeComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colDiaUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DiaUnitComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colIsCC = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLength = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCCSize1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSPNote = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMCDia_MCGauge = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMCDia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMCGauge = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCon = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colFinishUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.FinishUnitComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colKgPerUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colMarkerLengthYrds = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMarkerLengthInch = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colMarkerWidth = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colWidthAllowance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colLengthAllowance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colGMQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colWastagePercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colGreyWastagePercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colDyeingTypeId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.DyeingTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDyeingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colForColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colForSize = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ColorCheckedComboBoxEdit = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.FabricForSizeGridControl = New DevExpress.XtraGrid.GridControl()
        Me.FabricForSizeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Size2GridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Color2GridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReference = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContrastColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Contrast2GridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCCSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCuttingPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ApplyButton = New System.Windows.Forms.Button()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.CCSizeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SizeLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSizeCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.DelSelButton = New System.Windows.Forms.Button()
        Me.SelectByFabricButton = New System.Windows.Forms.Button()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.Signature4CheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FabricBOMDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.SelectColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DyeingPricePerUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KnittingPricePerUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarmentsPartId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IsMain = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CCSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Composition = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FabricViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FGSM = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FDia = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DiaType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FabricColorId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GarmentsColorId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColorSL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuttingPercentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Consumption = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinishFabricQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GreyPercentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GreyFabricQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discontinue = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.KgPerUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsAOP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsStripe = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FabricBOMDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Signature3CheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Signature1CheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.Signature2CheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.YarnAllocationButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ProceedForKnittingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AdditionalCommentsSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgramCommentsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ExplationForAdditionalFabricQtyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CheckWithComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ProceedForDyeingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.GetPercentageButton = New System.Windows.Forms.Button()
        Me.PasteButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DeselectAllLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.RefreshLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.InvertSelectLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.YarnAllocationGMTGridControl = New DevExpress.XtraGrid.GridControl()
        Me.YarnAllocationGMTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Apparel.ItemListLookupDataSet()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWastagePercentage1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStripeGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsYds = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFeederNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFeederSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFeederQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStripeSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGroupSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YarnLotNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.LotAndItemwiseBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LotAndItemBalanceDataSet = New KSoft_Apparel.LotAndItemBalanceDataSet()
        Me.GridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTTLIssue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLReceive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnLotNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYarnLotNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LCGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PIAndItemwiseBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIAnditemwiseBalanceDataSet = New KSoft_Apparel.PIAnditemwiseBalanceDataSet()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLCNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLReceive1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLIssue1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.YarnRequireLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SetButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CnclButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter()
        Me.GSMTableAdapter = New KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter()
        Me.GarmentsPartTableAdapter = New KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.FabricBOMTableAdapter = New KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricBOMTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.FabricBOMDataSetTableAdapters.TableAdapterManager()
        Me.FabricBOMDetailsTableAdapter = New KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricBOMDetailsTableAdapter()
        Me.FabricForSizeTableAdapter = New KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricForSizeTableAdapter()
        Me.FabricTableAdapter = New KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricTableAdapter()
        Me.YarnAllocationGMTTableAdapter = New KSoft_Apparel.FabricBOMDataSetTableAdapters.YarnAllocationGMTTableAdapter()
        Me.FabricViewTableAdapter = New KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricViewTableAdapter()
        Me.FabricBOMIdSearchTableAdapter = New KSoft_Apparel.FabricBOMIdSearchDataSetTableAdapters.FabricBOMIdSearchTableAdapter()
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter()
        Me.UserTableAdapter = New KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OrderFabricColorTableAdapter = New KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter()
        Me.OrderSizeLookupDataSet = New KSoft_Apparel.OrderSizeLookupDataSet()
        Me.OrderSizeLookupTableAdapter = New KSoft_Apparel.OrderSizeDataSetTableAdapters.OrderSizeLookupTableAdapter()
        Me.PIAndItemwiseBalanceTableAdapter = New KSoft_Apparel.PIAnditemwiseBalanceDataSetTableAdapters.PIAndItemwiseBalanceTableAdapter()
        Me.LotAndItemwiseBalanceTableAdapter = New KSoft_Apparel.LotAndItemBalanceDataSetTableAdapters.LotAndItemwiseBalanceTableAdapter()
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.WashTypeMstTableAdapter = New KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter()
        Me.colWashType = New DevExpress.XtraGrid.Columns.GridColumn()
        OrderIdLabel = New System.Windows.Forms.Label()
        FabricBookingDateLabel = New System.Windows.Forms.Label()
        FabricReqDateLabel = New System.Windows.Forms.Label()
        ExplationForAdditionalFabricQtyLabel = New System.Windows.Forms.Label()
        CheckWithLabel = New System.Windows.Forms.Label()
        ProceedForKnittingLabel = New System.Windows.Forms.Label()
        AmendmentNoLabel = New System.Windows.Forms.Label()
        AmendmentDetailsLabel = New System.Windows.Forms.Label()
        AmendmentDateLabel = New System.Windows.Forms.Label()
        FabricBOMIdLabel = New System.Windows.Forms.Label()
        ProgramCommentsLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        SupplierIdLabel = New System.Windows.Forms.Label()
        UserIdLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        WashReferenceLabel1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContrastColorLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.YarnDyeingTypeGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnDyeingTypeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsAOPCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingStartDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingStartDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderQuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsEmbroideryCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsYDSCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsBrushCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPeachFinishCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscontinueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CauseofDiscontinueTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmbDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AOPDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsWashCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingStartCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingStartCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingStartCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnReceivedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FDCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingCommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsFabricBOMCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBookingDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBookingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricReqDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricReqDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMIdSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMIdSearchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.CopyTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishUnitComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DyeingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricForSizeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricForSizeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Size2GridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color2GridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contrast2GridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCSizeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SizeLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.Signature4CheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Signature3CheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Signature1CheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Signature2CheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.ProceedForKnittingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramCommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExplationForAdditionalFabricQtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckWithComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProceedForDyeingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnAllocationGMTGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnAllocationGMTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnLotNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotAndItemBalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIAnditemwiseBalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderSizeLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderIdLabel
        '
        OrderIdLabel.AutoSize = True
        OrderIdLabel.Location = New System.Drawing.Point(9, 22)
        OrderIdLabel.Name = "OrderIdLabel"
        OrderIdLabel.Size = New System.Drawing.Size(66, 13)
        OrderIdLabel.TabIndex = 24
        OrderIdLabel.Text = "Program No:"
        '
        'FabricBookingDateLabel
        '
        FabricBookingDateLabel.AutoSize = True
        FabricBookingDateLabel.Location = New System.Drawing.Point(220, 47)
        FabricBookingDateLabel.Name = "FabricBookingDateLabel"
        FabricBookingDateLabel.Size = New System.Drawing.Size(107, 13)
        FabricBookingDateLabel.TabIndex = 29
        FabricBookingDateLabel.Text = "Fabric Booking Date:"
        '
        'FabricReqDateLabel
        '
        FabricReqDateLabel.AutoSize = True
        FabricReqDateLabel.Location = New System.Drawing.Point(220, 75)
        FabricReqDateLabel.Name = "FabricReqDateLabel"
        FabricReqDateLabel.Size = New System.Drawing.Size(88, 13)
        FabricReqDateLabel.TabIndex = 30
        FabricReqDateLabel.Text = "Fabric Req Date:"
        '
        'ExplationForAdditionalFabricQtyLabel
        '
        ExplationForAdditionalFabricQtyLabel.AutoSize = True
        ExplationForAdditionalFabricQtyLabel.Location = New System.Drawing.Point(15, 47)
        ExplationForAdditionalFabricQtyLabel.Name = "ExplationForAdditionalFabricQtyLabel"
        ExplationForAdditionalFabricQtyLabel.Size = New System.Drawing.Size(171, 13)
        ExplationForAdditionalFabricQtyLabel.TabIndex = 4
        ExplationForAdditionalFabricQtyLabel.Text = "Explation For Additional Fabric Qty:"
        '
        'CheckWithLabel
        '
        CheckWithLabel.AutoSize = True
        CheckWithLabel.Location = New System.Drawing.Point(15, 23)
        CheckWithLabel.Name = "CheckWithLabel"
        CheckWithLabel.Size = New System.Drawing.Size(66, 13)
        CheckWithLabel.TabIndex = 3
        CheckWithLabel.Text = "Check With:"
        '
        'ProceedForKnittingLabel
        '
        ProceedForKnittingLabel.AutoSize = True
        ProceedForKnittingLabel.Location = New System.Drawing.Point(755, 15)
        ProceedForKnittingLabel.Name = "ProceedForKnittingLabel"
        ProceedForKnittingLabel.Size = New System.Drawing.Size(0, 13)
        ProceedForKnittingLabel.TabIndex = 2
        '
        'AmendmentNoLabel
        '
        AmendmentNoLabel.AutoSize = True
        AmendmentNoLabel.Location = New System.Drawing.Point(473, 22)
        AmendmentNoLabel.Name = "AmendmentNoLabel"
        AmendmentNoLabel.Size = New System.Drawing.Size(54, 13)
        AmendmentNoLabel.TabIndex = 15
        AmendmentNoLabel.Text = "Amnd No:"
        '
        'AmendmentDetailsLabel
        '
        AmendmentDetailsLabel.AutoSize = True
        AmendmentDetailsLabel.Location = New System.Drawing.Point(473, 47)
        AmendmentDetailsLabel.Name = "AmendmentDetailsLabel"
        AmendmentDetailsLabel.Size = New System.Drawing.Size(78, 13)
        AmendmentDetailsLabel.TabIndex = 21
        AmendmentDetailsLabel.Text = "Amend Details:"
        '
        'AmendmentDateLabel
        '
        AmendmentDateLabel.AutoSize = True
        AmendmentDateLabel.Location = New System.Drawing.Point(700, 22)
        AmendmentDateLabel.Name = "AmendmentDateLabel"
        AmendmentDateLabel.Size = New System.Drawing.Size(92, 13)
        AmendmentDateLabel.TabIndex = 20
        AmendmentDateLabel.Text = "Amendment Date:"
        '
        'FabricBOMIdLabel
        '
        FabricBOMIdLabel.AutoSize = True
        FabricBOMIdLabel.Location = New System.Drawing.Point(708, 48)
        FabricBOMIdLabel.Name = "FabricBOMIdLabel"
        FabricBOMIdLabel.Size = New System.Drawing.Size(60, 13)
        FabricBOMIdLabel.TabIndex = 23
        FabricBOMIdLabel.Text = "Booking ID"
        '
        'ProgramCommentsLabel
        '
        ProgramCommentsLabel.AutoSize = True
        ProgramCommentsLabel.Location = New System.Drawing.Point(15, 71)
        ProgramCommentsLabel.Name = "ProgramCommentsLabel"
        ProgramCommentsLabel.Size = New System.Drawing.Size(101, 13)
        ProgramCommentsLabel.TabIndex = 8
        ProgramCommentsLabel.Text = "Program Comments:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(9, 47)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(37, 13)
        Label1.TabIndex = 36
        Label1.Text = "Buyer:"
        '
        'SupplierIdLabel
        '
        SupplierIdLabel.AutoSize = True
        SupplierIdLabel.Location = New System.Drawing.Point(473, 71)
        SupplierIdLabel.Name = "SupplierIdLabel"
        SupplierIdLabel.Size = New System.Drawing.Size(51, 13)
        SupplierIdLabel.TabIndex = 41
        SupplierIdLabel.Text = "Supplier :"
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(9, 155)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(74, 13)
        UserIdLabel.TabIndex = 42
        UserIdLabel.Text = "Merchandiser:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(632, 128)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(62, 13)
        Label8.TabIndex = 67
        Label8.Text = "Wash Type"
        AddHandler Label8.Click, AddressOf Me.Label8_Click
        '
        'WashReferenceLabel1
        '
        WashReferenceLabel1.AutoSize = True
        WashReferenceLabel1.Location = New System.Drawing.Point(810, 122)
        WashReferenceLabel1.Name = "WashReferenceLabel1"
        WashReferenceLabel1.Size = New System.Drawing.Size(91, 13)
        WashReferenceLabel1.TabIndex = 63
        WashReferenceLabel1.Text = "Wash Reference:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(24, 16)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(60, 13)
        Label3.TabIndex = 57
        Label3.Text = "Copy From:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(24, 39)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(57, 13)
        Label4.TabIndex = 58
        Label4.Text = "PO Group:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(220, 22)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(100, 13)
        Label9.TabIndex = 80
        Label9.Text = "Booking Start Date:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(24, 65)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(60, 13)
        Label13.TabIndex = 75
        Label13.Text = "PO Details:"
        '
        'colBalance
        '
        Me.colBalance.Caption = "Physical Stock"
        Me.colBalance.FieldName = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 3
        Me.colBalance.Width = 93
        '
        'colBalance1
        '
        Me.colBalance1.FieldName = "Balance"
        Me.colBalance1.Name = "colBalance1"
        Me.colBalance1.Visible = True
        Me.colBalance1.VisibleIndex = 3
        '
        'SizeGridLookUpEdit
        '
        Me.SizeGridLookUpEdit.AutoHeight = False
        Me.SizeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeGridLookUpEdit.DataSource = Me.OrderSizeLookupBindingSource
        Me.SizeGridLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeGridLookUpEdit.Name = "SizeGridLookUpEdit"
        Me.SizeGridLookUpEdit.NullText = ""
        Me.SizeGridLookUpEdit.ValueMember = "SizeId"
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
        'ColorGridLookUpEdit
        '
        Me.ColorGridLookUpEdit.AutoHeight = False
        Me.ColorGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorGridLookUpEdit.DataSource = Me.OrderFabricColorBindingSource
        Me.ColorGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.ColorGridLookUpEdit.Name = "ColorGridLookUpEdit"
        Me.ColorGridLookUpEdit.NullText = ""
        Me.ColorGridLookUpEdit.ValueMember = "FabricColorId"
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
        'ContrastColorLookUpEdit
        '
        Me.ContrastColorLookUpEdit.AutoHeight = False
        Me.ContrastColorLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ContrastColorLookUpEdit.DataSource = Me.FabricColorBindingSource
        Me.ContrastColorLookUpEdit.DisplayMember = "FabricColorName"
        Me.ContrastColorLookUpEdit.Name = "ContrastColorLookUpEdit"
        Me.ContrastColorLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ContrastColorLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ContrastColorLookUpEdit.ValueMember = "FabricColorId"
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
        'SizeLookUpEdit
        '
        Me.SizeLookUpEdit.AutoHeight = False
        Me.SizeLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeLookUpEdit.DataSource = Me.OrderSizeLookupBindingSource
        Me.SizeLookUpEdit.DisplayMember = "SizeCode"
        Me.SizeLookUpEdit.Name = "SizeLookUpEdit"
        Me.SizeLookUpEdit.ValueMember = "SizeId"
        '
        'ColorLookUpEdit
        '
        Me.ColorLookUpEdit.AutoHeight = False
        Me.ColorLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FabricColorName", "Fabric Color Name", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.ColorLookUpEdit.DataSource = Me.OrderFabricColorBindingSource
        Me.ColorLookUpEdit.DisplayMember = "FabricColorName"
        Me.ColorLookUpEdit.Name = "ColorLookUpEdit"
        Me.ColorLookUpEdit.ValueMember = "FabricColorId"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1284, 666)
        Me.SplitContainer1.SplitterDistance = 408
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer2.Size = New System.Drawing.Size(1284, 408)
        Me.SplitContainer2.SplitterDistance = 237
        Me.SplitContainer2.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(12, 39)
        Me.TabControl2.Multiline = True
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1260, 186)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.YarnDyeingTypeGridLookUpEdit)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.IsAOPCheckEdit)
        Me.TabPage3.Controls.Add(Me.BookingStartDateEdit)
        Me.TabPage3.Controls.Add(Label9)
        Me.TabPage3.Controls.Add(Me.PrintDetailsTextEdit)
        Me.TabPage3.Controls.Add(Me.OrderQuantityTextEdit)
        Me.TabPage3.Controls.Add(Me.IsEmbroideryCheckEdit)
        Me.TabPage3.Controls.Add(Me.IsYDSCheckEdit)
        Me.TabPage3.Controls.Add(Me.IsBrushCheckEdit)
        Me.TabPage3.Controls.Add(Me.IsPeachFinishCheckEdit)
        Me.TabPage3.Controls.Add(Me.DiscontinueCheckEdit)
        Me.TabPage3.Controls.Add(Me.CauseofDiscontinueTextEdit)
        Me.TabPage3.Controls.Add(Me.IsPrintCheckEdit)
        Me.TabPage3.Controls.Add(Me.EmbDetailsTextEdit)
        Me.TabPage3.Controls.Add(Me.AOPDetailsTextEdit)
        Me.TabPage3.Controls.Add(Label8)
        Me.TabPage3.Controls.Add(Me.IsWashCheckEdit)
        Me.TabPage3.Controls.Add(Me.WashTypeIdGridLookUpEdit)
        Me.TabPage3.Controls.Add(Me.WashDetailsTextEdit)
        Me.TabPage3.Controls.Add(Me.SampleDetailsTextEdit)
        Me.TabPage3.Controls.Add(Me.SampleReferenceTextEdit)
        Me.TabPage3.Controls.Add(WashReferenceLabel1)
        Me.TabPage3.Controls.Add(Me.WashReferenceTextEdit)
        Me.TabPage3.Controls.Add(Me.CuttingStartCheckEdit)
        Me.TabPage3.Controls.Add(Me.DyeingStartCheckEdit)
        Me.TabPage3.Controls.Add(Me.KnittingStartCheckEdit)
        Me.TabPage3.Controls.Add(Me.YarnReceivedCheckEdit)
        Me.TabPage3.Controls.Add(Me.FDCheckEdit)
        Me.TabPage3.Controls.Add(Me.DyeingCommentsTextEdit)
        Me.TabPage3.Controls.Add(Me.IsFabricBOMCompleteCheckEdit)
        Me.TabPage3.Controls.Add(Me.SupplierIdGridLookUpEdit)
        Me.TabPage3.Controls.Add(SupplierIdLabel)
        Me.TabPage3.Controls.Add(UserIdLabel)
        Me.TabPage3.Controls.Add(Me.UserIdGridLookUpEdit)
        Me.TabPage3.Controls.Add(Me.BuyerLabel)
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
        Me.TabPage3.Size = New System.Drawing.Size(1233, 178)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Basic"
        '
        'YarnDyeingTypeGridLookUpEdit
        '
        Me.YarnDyeingTypeGridLookUpEdit.Location = New System.Drawing.Point(696, 100)
        Me.YarnDyeingTypeGridLookUpEdit.Name = "YarnDyeingTypeGridLookUpEdit"
        Me.YarnDyeingTypeGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YarnDyeingTypeGridLookUpEdit.Properties.ImmediatePopup = True
        Me.YarnDyeingTypeGridLookUpEdit.Properties.NullText = ""
        Me.YarnDyeingTypeGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.YarnDyeingTypeGridLookUpEdit.Properties.PopupView = Me.YarnDyeingTypeGridView
        Me.YarnDyeingTypeGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.YarnDyeingTypeGridLookUpEdit.Size = New System.Drawing.Size(108, 20)
        Me.YarnDyeingTypeGridLookUpEdit.TabIndex = 86
        '
        'YarnDyeingTypeGridView
        '
        Me.YarnDyeingTypeGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.YarnDyeingTypeGridView.Name = "YarnDyeingTypeGridView"
        Me.YarnDyeingTypeGridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.YarnDyeingTypeGridView.OptionsView.ShowGroupPanel = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Order Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Sample Details"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Sample Program"
        '
        'IsAOPCheckEdit
        '
        Me.IsAOPCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "IsAOP", True))
        Me.IsAOPCheckEdit.Location = New System.Drawing.Point(326, 124)
        Me.IsAOPCheckEdit.Name = "IsAOPCheckEdit"
        Me.IsAOPCheckEdit.Properties.Caption = "AOP"
        Me.IsAOPCheckEdit.Size = New System.Drawing.Size(84, 19)
        Me.IsAOPCheckEdit.TabIndex = 81
        '
        'FabricBOMBindingSource
        '
        Me.FabricBOMBindingSource.DataMember = "FabricBOM"
        Me.FabricBOMBindingSource.DataSource = Me.FabricBOMDataSet
        '
        'FabricBOMDataSet
        '
        Me.FabricBOMDataSet.DataSetName = "FabricBOMDataSet"
        Me.FabricBOMDataSet.EnforceConstraints = False
        Me.FabricBOMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingStartDateEdit
        '
        Me.BookingStartDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "ProccedDate", True))
        Me.BookingStartDateEdit.EditValue = Nothing
        Me.BookingStartDateEdit.Location = New System.Drawing.Point(326, 18)
        Me.BookingStartDateEdit.Name = "BookingStartDateEdit"
        Me.BookingStartDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BookingStartDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.BookingStartDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.BookingStartDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BookingStartDateEdit.Properties.EditFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.BookingStartDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.BookingStartDateEdit.Properties.Mask.EditMask = "dd-MMM-yy HH:mm"
        Me.BookingStartDateEdit.Properties.ReadOnly = True
        Me.BookingStartDateEdit.Size = New System.Drawing.Size(132, 20)
        Me.BookingStartDateEdit.TabIndex = 79
        '
        'PrintDetailsTextEdit
        '
        Me.PrintDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "PrintDetails", True))
        Me.PrintDetailsTextEdit.Location = New System.Drawing.Point(412, 99)
        Me.PrintDetailsTextEdit.Name = "PrintDetailsTextEdit"
        Me.PrintDetailsTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.PrintDetailsTextEdit.TabIndex = 69
        '
        'OrderQuantityTextEdit
        '
        Me.OrderQuantityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "OrderQuantity", True))
        Me.OrderQuantityTextEdit.Location = New System.Drawing.Point(97, 72)
        Me.OrderQuantityTextEdit.Name = "OrderQuantityTextEdit"
        Me.OrderQuantityTextEdit.Size = New System.Drawing.Size(117, 20)
        Me.OrderQuantityTextEdit.TabIndex = 78
        '
        'IsEmbroideryCheckEdit
        '
        Me.IsEmbroideryCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "IsEmbroidery", True))
        Me.IsEmbroideryCheckEdit.Location = New System.Drawing.Point(326, 151)
        Me.IsEmbroideryCheckEdit.Name = "IsEmbroideryCheckEdit"
        Me.IsEmbroideryCheckEdit.Properties.Caption = "Embroidery"
        Me.IsEmbroideryCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsEmbroideryCheckEdit.TabIndex = 31
        '
        'IsYDSCheckEdit
        '
        Me.IsYDSCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "IsYDS", True))
        Me.IsYDSCheckEdit.Location = New System.Drawing.Point(635, 100)
        Me.IsYDSCheckEdit.Name = "IsYDSCheckEdit"
        Me.IsYDSCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IsYDSCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.IsYDSCheckEdit.Properties.Caption = "YD/YDS"
        Me.IsYDSCheckEdit.Size = New System.Drawing.Size(59, 19)
        Me.IsYDSCheckEdit.TabIndex = 77
        '
        'IsBrushCheckEdit
        '
        Me.IsBrushCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "IsBrush", True))
        Me.IsBrushCheckEdit.Location = New System.Drawing.Point(574, 100)
        Me.IsBrushCheckEdit.Name = "IsBrushCheckEdit"
        Me.IsBrushCheckEdit.Properties.Caption = "Brush"
        Me.IsBrushCheckEdit.Size = New System.Drawing.Size(65, 19)
        Me.IsBrushCheckEdit.TabIndex = 76
        '
        'IsPeachFinishCheckEdit
        '
        Me.IsPeachFinishCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "IsPeachFinish", True))
        Me.IsPeachFinishCheckEdit.Location = New System.Drawing.Point(574, 153)
        Me.IsPeachFinishCheckEdit.Name = "IsPeachFinishCheckEdit"
        Me.IsPeachFinishCheckEdit.Properties.Caption = "Peach Finish"
        Me.IsPeachFinishCheckEdit.Size = New System.Drawing.Size(89, 19)
        Me.IsPeachFinishCheckEdit.TabIndex = 75
        '
        'DiscontinueCheckEdit
        '
        Me.DiscontinueCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "Discontinue", True))
        Me.DiscontinueCheckEdit.Location = New System.Drawing.Point(813, 149)
        Me.DiscontinueCheckEdit.Name = "DiscontinueCheckEdit"
        Me.DiscontinueCheckEdit.Properties.Caption = "Discontinue"
        Me.DiscontinueCheckEdit.Size = New System.Drawing.Size(84, 19)
        Me.DiscontinueCheckEdit.TabIndex = 72
        '
        'CauseofDiscontinueTextEdit
        '
        Me.CauseofDiscontinueTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "CauseofDiscontinue", True))
        Me.CauseofDiscontinueTextEdit.Location = New System.Drawing.Point(907, 148)
        Me.CauseofDiscontinueTextEdit.Name = "CauseofDiscontinueTextEdit"
        Me.CauseofDiscontinueTextEdit.Size = New System.Drawing.Size(310, 20)
        Me.CauseofDiscontinueTextEdit.TabIndex = 73
        '
        'IsPrintCheckEdit
        '
        Me.IsPrintCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "IsPrint", True))
        Me.IsPrintCheckEdit.Location = New System.Drawing.Point(326, 98)
        Me.IsPrintCheckEdit.Name = "IsPrintCheckEdit"
        Me.IsPrintCheckEdit.Properties.Caption = "Print"
        Me.IsPrintCheckEdit.Size = New System.Drawing.Size(84, 19)
        Me.IsPrintCheckEdit.TabIndex = 68
        '
        'EmbDetailsTextEdit
        '
        Me.EmbDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "EmbroideryDetails", True))
        Me.EmbDetailsTextEdit.Location = New System.Drawing.Point(412, 152)
        Me.EmbDetailsTextEdit.Name = "EmbDetailsTextEdit"
        Me.EmbDetailsTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.EmbDetailsTextEdit.TabIndex = 71
        '
        'AOPDetailsTextEdit
        '
        Me.AOPDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "AOPDetails", True))
        Me.AOPDetailsTextEdit.Location = New System.Drawing.Point(412, 125)
        Me.AOPDetailsTextEdit.Name = "AOPDetailsTextEdit"
        Me.AOPDetailsTextEdit.Size = New System.Drawing.Size(156, 20)
        Me.AOPDetailsTextEdit.TabIndex = 71
        '
        'IsWashCheckEdit
        '
        Me.IsWashCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "IsWash", True))
        Me.IsWashCheckEdit.Location = New System.Drawing.Point(574, 125)
        Me.IsWashCheckEdit.Name = "IsWashCheckEdit"
        Me.IsWashCheckEdit.Properties.Caption = "Wash"
        Me.IsWashCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.IsWashCheckEdit.TabIndex = 66
        '
        'WashTypeIdGridLookUpEdit
        '
        Me.WashTypeIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "WashTypeId", True))
        Me.WashTypeIdGridLookUpEdit.Location = New System.Drawing.Point(696, 125)
        Me.WashTypeIdGridLookUpEdit.Name = "WashTypeIdGridLookUpEdit"
        Me.WashTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WashTypeIdGridLookUpEdit.Properties.DataSource = Me.WashTypeMstBindingSource
        Me.WashTypeIdGridLookUpEdit.Properties.DisplayMember = "WashType"
        Me.WashTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.WashTypeIdGridLookUpEdit.Properties.PopupView = Me.WashTypeIdGridLookUpEditView
        Me.WashTypeIdGridLookUpEdit.Properties.ValueMember = "WashTypeId"
        Me.WashTypeIdGridLookUpEdit.Size = New System.Drawing.Size(108, 20)
        Me.WashTypeIdGridLookUpEdit.TabIndex = 65
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
        Me.WashTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.WashTypeIdGridLookUpEditView.Name = "WashTypeIdGridLookUpEditView"
        Me.WashTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.WashTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'WashDetailsTextEdit
        '
        Me.WashDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "WashDetails", True))
        Me.WashDetailsTextEdit.Location = New System.Drawing.Point(1001, 121)
        Me.WashDetailsTextEdit.Name = "WashDetailsTextEdit"
        Me.WashDetailsTextEdit.Size = New System.Drawing.Size(216, 20)
        Me.WashDetailsTextEdit.TabIndex = 60
        '
        'SampleDetailsTextEdit
        '
        Me.SampleDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "SampleDetails", True))
        Me.SampleDetailsTextEdit.Location = New System.Drawing.Point(97, 125)
        Me.SampleDetailsTextEdit.Name = "SampleDetailsTextEdit"
        Me.SampleDetailsTextEdit.Size = New System.Drawing.Size(222, 20)
        Me.SampleDetailsTextEdit.TabIndex = 62
        '
        'SampleReferenceTextEdit
        '
        Me.SampleReferenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "SampleReference", True))
        Me.SampleReferenceTextEdit.Location = New System.Drawing.Point(97, 99)
        Me.SampleReferenceTextEdit.Name = "SampleReferenceTextEdit"
        Me.SampleReferenceTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SampleReferenceTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.SampleReferenceTextEdit.Size = New System.Drawing.Size(222, 20)
        Me.SampleReferenceTextEdit.TabIndex = 61
        '
        'WashReferenceTextEdit
        '
        Me.WashReferenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "WashReference", True))
        Me.WashReferenceTextEdit.Location = New System.Drawing.Point(907, 121)
        Me.WashReferenceTextEdit.Name = "WashReferenceTextEdit"
        Me.WashReferenceTextEdit.Size = New System.Drawing.Size(88, 20)
        Me.WashReferenceTextEdit.TabIndex = 59
        '
        'CuttingStartCheckEdit
        '
        Me.CuttingStartCheckEdit.Location = New System.Drawing.Point(1081, 92)
        Me.CuttingStartCheckEdit.Name = "CuttingStartCheckEdit"
        Me.CuttingStartCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.CuttingStartCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CuttingStartCheckEdit.Properties.Caption = "Cutting Start"
        Me.CuttingStartCheckEdit.Properties.ReadOnly = True
        Me.CuttingStartCheckEdit.Size = New System.Drawing.Size(136, 19)
        Me.CuttingStartCheckEdit.TabIndex = 58
        '
        'DyeingStartCheckEdit
        '
        Me.DyeingStartCheckEdit.Location = New System.Drawing.Point(1081, 67)
        Me.DyeingStartCheckEdit.Name = "DyeingStartCheckEdit"
        Me.DyeingStartCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.DyeingStartCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DyeingStartCheckEdit.Properties.Caption = "Dyeing Start"
        Me.DyeingStartCheckEdit.Properties.ReadOnly = True
        Me.DyeingStartCheckEdit.Size = New System.Drawing.Size(136, 19)
        Me.DyeingStartCheckEdit.TabIndex = 58
        '
        'KnittingStartCheckEdit
        '
        Me.KnittingStartCheckEdit.Location = New System.Drawing.Point(1081, 44)
        Me.KnittingStartCheckEdit.Name = "KnittingStartCheckEdit"
        Me.KnittingStartCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.KnittingStartCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.KnittingStartCheckEdit.Properties.Caption = "Knitting Start"
        Me.KnittingStartCheckEdit.Properties.ReadOnly = True
        Me.KnittingStartCheckEdit.Size = New System.Drawing.Size(136, 19)
        Me.KnittingStartCheckEdit.TabIndex = 58
        '
        'YarnReceivedCheckEdit
        '
        Me.YarnReceivedCheckEdit.Location = New System.Drawing.Point(1081, 19)
        Me.YarnReceivedCheckEdit.Name = "YarnReceivedCheckEdit"
        Me.YarnReceivedCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.YarnReceivedCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.YarnReceivedCheckEdit.Properties.Caption = "Yarn Issued"
        Me.YarnReceivedCheckEdit.Properties.ReadOnly = True
        Me.YarnReceivedCheckEdit.Size = New System.Drawing.Size(136, 19)
        Me.YarnReceivedCheckEdit.TabIndex = 58
        '
        'FDCheckEdit
        '
        Me.FDCheckEdit.Location = New System.Drawing.Point(931, 19)
        Me.FDCheckEdit.Name = "FDCheckEdit"
        Me.FDCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.FDCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FDCheckEdit.Properties.Caption = "Booking Received by FD"
        Me.FDCheckEdit.Properties.ReadOnly = True
        Me.FDCheckEdit.Size = New System.Drawing.Size(144, 19)
        Me.FDCheckEdit.TabIndex = 58
        '
        'DyeingCommentsTextEdit
        '
        Me.DyeingCommentsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "DyeingComments", True))
        Me.DyeingCommentsTextEdit.Location = New System.Drawing.Point(931, 43)
        Me.DyeingCommentsTextEdit.Name = "DyeingCommentsTextEdit"
        Me.DyeingCommentsTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.DyeingCommentsTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DyeingCommentsTextEdit.Properties.ReadOnly = True
        Me.DyeingCommentsTextEdit.Size = New System.Drawing.Size(144, 20)
        Me.DyeingCommentsTextEdit.TabIndex = 57
        '
        'IsFabricBOMCompleteCheckEdit
        '
        Me.IsFabricBOMCompleteCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "IsFabricBOMComplete", True))
        Me.IsFabricBOMCompleteCheckEdit.Location = New System.Drawing.Point(931, 68)
        Me.IsFabricBOMCompleteCheckEdit.Name = "IsFabricBOMCompleteCheckEdit"
        Me.IsFabricBOMCompleteCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Lime
        Me.IsFabricBOMCompleteCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.IsFabricBOMCompleteCheckEdit.Properties.Caption = "Proceed For Fabric Dept."
        Me.IsFabricBOMCompleteCheckEdit.Properties.ReadOnly = True
        Me.IsFabricBOMCompleteCheckEdit.Size = New System.Drawing.Size(144, 19)
        Me.IsFabricBOMCompleteCheckEdit.TabIndex = 56
        '
        'SupplierIdGridLookUpEdit
        '
        Me.SupplierIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "SupplierId", True))
        Me.SupplierIdGridLookUpEdit.Location = New System.Drawing.Point(554, 67)
        Me.SupplierIdGridLookUpEdit.Name = "SupplierIdGridLookUpEdit"
        Me.SupplierIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierIdGridLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.SupplierIdGridLookUpEdit.Properties.DisplayMember = "SupplierName"
        Me.SupplierIdGridLookUpEdit.Properties.NullText = "[Supplier]"
        Me.SupplierIdGridLookUpEdit.Properties.PopupView = Me.SupplierIdGridLookUpEditView
        Me.SupplierIdGridLookUpEdit.Properties.ValueMember = "SupplierId"
        Me.SupplierIdGridLookUpEdit.Size = New System.Drawing.Size(371, 20)
        Me.SupplierIdGridLookUpEdit.TabIndex = 2
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
        Me.UserIdGridLookUpEdit.Location = New System.Drawing.Point(97, 152)
        Me.UserIdGridLookUpEdit.Name = "UserIdGridLookUpEdit"
        Me.UserIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserIdGridLookUpEdit.Properties.DataSource = Me.UserBindingSource
        Me.UserIdGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.UserIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.UserIdGridLookUpEdit.Properties.NullText = ""
        Me.UserIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UserIdGridLookUpEdit.Properties.PopupView = Me.UserIdGridLookUpEditView
        Me.UserIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserIdGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.UserIdGridLookUpEdit.Size = New System.Drawing.Size(222, 20)
        Me.UserIdGridLookUpEdit.TabIndex = 43
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
        Me.BuyerLabel.Location = New System.Drawing.Point(97, 43)
        Me.BuyerLabel.Name = "BuyerLabel"
        Me.BuyerLabel.Size = New System.Drawing.Size(117, 21)
        Me.BuyerLabel.TabIndex = 1
        '
        'FabricBookingDateDateEdit
        '
        Me.FabricBookingDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "FabricBookingDate", True))
        Me.FabricBookingDateDateEdit.EditValue = Nothing
        Me.FabricBookingDateDateEdit.Location = New System.Drawing.Point(326, 43)
        Me.FabricBookingDateDateEdit.Name = "FabricBookingDateDateEdit"
        Me.FabricBookingDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricBookingDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FabricBookingDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.FabricBookingDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FabricBookingDateDateEdit.Properties.EditFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.FabricBookingDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FabricBookingDateDateEdit.Properties.Mask.EditMask = "dd-MMM-yy HH:mm"
        Me.FabricBookingDateDateEdit.Properties.ReadOnly = True
        Me.FabricBookingDateDateEdit.Size = New System.Drawing.Size(132, 20)
        Me.FabricBookingDateDateEdit.TabIndex = 3
        '
        'OrderIdGridLookUpEdit
        '
        Me.OrderIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "OrderId", True))
        Me.OrderIdGridLookUpEdit.Enabled = False
        Me.OrderIdGridLookUpEdit.Location = New System.Drawing.Point(97, 18)
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
        Me.OrderIdGridLookUpEdit.Properties.PopupView = Me.OrderIdGridLookUpEditView
        Me.OrderIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderIdGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderIdGridLookUpEdit.Size = New System.Drawing.Size(117, 20)
        Me.OrderIdGridLookUpEdit.TabIndex = 0
        Me.OrderIdGridLookUpEdit.Tag = "NR"
        '
        'OrderLookupBindingSource
        '
        Me.OrderLookupBindingSource.DataMember = "OrderLookup"
        Me.OrderLookupBindingSource.DataSource = Me.OrderLookupDataSet
        '
        'OrderLookupDataSet
        '
        Me.OrderLookupDataSet.DataSetName = "OrderLookupDataSet"
        Me.OrderLookupDataSet.EnforceConstraints = False
        Me.OrderLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.FabricReqDateDateEdit.Location = New System.Drawing.Point(326, 71)
        Me.FabricReqDateDateEdit.Name = "FabricReqDateDateEdit"
        Me.FabricReqDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricReqDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FabricReqDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.FabricReqDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FabricReqDateDateEdit.Properties.EditFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.FabricReqDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.FabricReqDateDateEdit.Properties.Mask.EditMask = "dd-MMM-yy HH:mm"
        Me.FabricReqDateDateEdit.Size = New System.Drawing.Size(132, 20)
        Me.FabricReqDateDateEdit.TabIndex = 1
        '
        'AmendmentNoSpinEdit
        '
        Me.AmendmentNoSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "AmendmentNo", True))
        Me.AmendmentNoSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.AmendmentNoSpinEdit.Location = New System.Drawing.Point(554, 18)
        Me.AmendmentNoSpinEdit.Name = "AmendmentNoSpinEdit"
        Me.AmendmentNoSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentNoSpinEdit.Properties.ReadOnly = True
        Me.AmendmentNoSpinEdit.Size = New System.Drawing.Size(56, 20)
        Me.AmendmentNoSpinEdit.TabIndex = 16
        '
        'AmendmentDetailsTextEdit
        '
        Me.AmendmentDetailsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "AmendmentDetails", True))
        Me.AmendmentDetailsTextEdit.Location = New System.Drawing.Point(554, 43)
        Me.AmendmentDetailsTextEdit.Name = "AmendmentDetailsTextEdit"
        Me.AmendmentDetailsTextEdit.Size = New System.Drawing.Size(371, 20)
        Me.AmendmentDetailsTextEdit.TabIndex = 18
        '
        'AmendmentDateDateEdit
        '
        Me.AmendmentDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "AmendmentDate", True))
        Me.AmendmentDateDateEdit.EditValue = Nothing
        Me.AmendmentDateDateEdit.Location = New System.Drawing.Point(798, 18)
        Me.AmendmentDateDateEdit.Name = "AmendmentDateDateEdit"
        Me.AmendmentDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.AmendmentDateDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.AmendmentDateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.AmendmentDateDateEdit.Properties.EditFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.AmendmentDateDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.AmendmentDateDateEdit.Properties.ReadOnly = True
        Me.AmendmentDateDateEdit.Size = New System.Drawing.Size(127, 20)
        Me.AmendmentDateDateEdit.TabIndex = 17
        '
        'AmendmentSimpleButton
        '
        Me.AmendmentSimpleButton.Enabled = False
        Me.AmendmentSimpleButton.Location = New System.Drawing.Point(614, 18)
        Me.AmendmentSimpleButton.Name = "AmendmentSimpleButton"
        Me.AmendmentSimpleButton.Size = New System.Drawing.Size(80, 20)
        Me.AmendmentSimpleButton.TabIndex = 19
        Me.AmendmentSimpleButton.Text = "Amendment"
        '
        'FabricBOMIdLabel1
        '
        Me.FabricBOMIdLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FabricBOMIdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FabricBOMBindingSource, "FabricBOMId", True))
        Me.FabricBOMIdLabel1.Location = New System.Drawing.Point(778, 44)
        Me.FabricBOMIdLabel1.Name = "FabricBOMIdLabel1"
        Me.FabricBOMIdLabel1.Size = New System.Drawing.Size(135, 21)
        Me.FabricBOMIdLabel1.TabIndex = 28
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Label13)
        Me.TabPage4.Controls.Add(Me.TextEdit1)
        Me.TabPage4.Controls.Add(Me.POGroupLabel)
        Me.TabPage4.Controls.Add(Label4)
        Me.TabPage4.Controls.Add(Label3)
        Me.TabPage4.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.TabPage4.Controls.Add(Me.GetDataButton)
        Me.TabPage4.Location = New System.Drawing.Point(23, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1233, 178)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "More"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "PO", True))
        Me.TextEdit1.Location = New System.Drawing.Point(131, 62)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(942, 20)
        Me.TextEdit1.TabIndex = 74
        '
        'POGroupLabel
        '
        Me.POGroupLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.POGroupLabel.Location = New System.Drawing.Point(132, 38)
        Me.POGroupLabel.Name = "POGroupLabel"
        Me.POGroupLabel.Size = New System.Drawing.Size(941, 21)
        Me.POGroupLabel.TabIndex = 59
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(132, 13)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.FabricBOMIdSearchBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details2"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = "[Type a program ]"
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "FabricBOMId"
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(186, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 55
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
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "FabricBOMId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "OrderId"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "ProgramNo"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "AmendmentNo"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "Details"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "Details2"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GetDataButton
        '
        Me.GetDataButton.BackColor = System.Drawing.Color.Transparent
        Me.GetDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GetDataButton.Location = New System.Drawing.Point(343, 11)
        Me.GetDataButton.Margin = New System.Windows.Forms.Padding(10, 4, 3, 3)
        Me.GetDataButton.Name = "GetDataButton"
        Me.GetDataButton.Size = New System.Drawing.Size(128, 23)
        Me.GetDataButton.TabIndex = 56
        Me.GetDataButton.Text = "&Get Data"
        Me.GetDataButton.UseVisualStyleBackColor = False
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.AutoScroll = True
        Me.SplitContainer4.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer4.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer4.Panel1.Controls.Add(Me.UpdateButton)
        Me.SplitContainer4.Panel1.Controls.Add(Me.AsignedColorAndSizeButton)
        Me.SplitContainer4.Panel1.Controls.Add(Me.GenerateButton)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.CopyTextBox)
        Me.SplitContainer4.Panel1.Controls.Add(Me.SetCColorButton)
        Me.SplitContainer4.Panel1.Controls.Add(Me.LabelControl7)
        Me.SplitContainer4.Panel1.Controls.Add(Me.LabelControl5)
        Me.SplitContainer4.Panel1.Controls.Add(Me.RefTextBox)
        Me.SplitContainer4.Panel1.Controls.Add(Me.CodeTextBox)
        Me.SplitContainer4.Panel1.Controls.Add(Me.CColorGridLookUpEdit)
        Me.SplitContainer4.Panel1.Controls.Add(Me.LabelControl6)
        Me.SplitContainer4.Panel1.Controls.Add(Me.LinkLabel2)
        Me.SplitContainer4.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainer4.Panel1.Controls.Add(Me.SizeCheckedComboBoxEdit)
        Me.SplitContainer4.Panel1.Controls.Add(Me.FabricGridControl)
        Me.SplitContainer4.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.ColorCheckedComboBoxEdit)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.AutoScroll = True
        Me.SplitContainer4.Panel2.Controls.Add(Me.FabricForSizeGridControl)
        Me.SplitContainer4.Panel2.Controls.Add(Me.ApplyButton)
        Me.SplitContainer4.Panel2.Controls.Add(Me.LabelControl4)
        Me.SplitContainer4.Panel2.Controls.Add(Me.CCSizeTextEdit)
        Me.SplitContainer4.Panel2.Controls.Add(Me.LabelControl3)
        Me.SplitContainer4.Panel2.Controls.Add(Me.SizeLookupGridLookUpEdit)
        Me.SplitContainer4.Size = New System.Drawing.Size(1284, 167)
        Me.SplitContainer4.SplitterDistance = 868
        Me.SplitContainer4.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(776, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 48)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Color Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(704, 7)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(66, 48)
        Me.UpdateButton.TabIndex = 30
        Me.UpdateButton.Text = "Fabric Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AsignedColorAndSizeButton
        '
        Me.AsignedColorAndSizeButton.Location = New System.Drawing.Point(560, 7)
        Me.AsignedColorAndSizeButton.Name = "AsignedColorAndSizeButton"
        Me.AsignedColorAndSizeButton.Size = New System.Drawing.Size(138, 23)
        Me.AsignedColorAndSizeButton.TabIndex = 29
        Me.AsignedColorAndSizeButton.Text = "Asigned Color And Size"
        Me.AsignedColorAndSizeButton.UseVisualStyleBackColor = True
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(432, 7)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(122, 23)
        Me.GenerateButton.TabIndex = 28
        Me.GenerateButton.Text = "Generate Fabric BOM"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(601, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "&Copy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CopyTextBox
        '
        Me.CopyTextBox.Location = New System.Drawing.Point(561, 33)
        Me.CopyTextBox.Name = "CopyTextBox"
        Me.CopyTextBox.Size = New System.Drawing.Size(36, 20)
        Me.CopyTextBox.TabIndex = 26
        '
        'SetCColorButton
        '
        Me.SetCColorButton.Location = New System.Drawing.Point(432, 32)
        Me.SetCColorButton.Name = "SetCColorButton"
        Me.SetCColorButton.Size = New System.Drawing.Size(122, 23)
        Me.SetCColorButton.TabIndex = 23
        Me.SetCColorButton.Text = "Set Contrast Color"
        Me.SetCColorButton.UseVisualStyleBackColor = True
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(281, 37)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl7.TabIndex = 22
        Me.LabelControl7.Text = "Ref :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(172, 37)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl5.TabIndex = 22
        Me.LabelControl5.Text = "Code"
        '
        'RefTextBox
        '
        Me.RefTextBox.Location = New System.Drawing.Point(311, 34)
        Me.RefTextBox.Name = "RefTextBox"
        Me.RefTextBox.Size = New System.Drawing.Size(115, 20)
        Me.RefTextBox.TabIndex = 21
        '
        'CodeTextBox
        '
        Me.CodeTextBox.Location = New System.Drawing.Point(204, 34)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(71, 20)
        Me.CodeTextBox.TabIndex = 21
        '
        'CColorGridLookUpEdit
        '
        Me.CColorGridLookUpEdit.Location = New System.Drawing.Point(57, 34)
        Me.CColorGridLookUpEdit.Name = "CColorGridLookUpEdit"
        Me.CColorGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CColorGridLookUpEdit.Properties.DataSource = Me.FabricColorBindingSource
        Me.CColorGridLookUpEdit.Properties.DisplayMember = "FabricColorName"
        Me.CColorGridLookUpEdit.Properties.NullText = ""
        Me.CColorGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CColorGridLookUpEdit.Properties.PopupView = Me.GridView19
        Me.CColorGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CColorGridLookUpEdit.Properties.ValueMember = "FabricColorId"
        Me.CColorGridLookUpEdit.Size = New System.Drawing.Size(107, 20)
        Me.CColorGridLookUpEdit.TabIndex = 20
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
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(11, 37)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "Contrast"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(416, 11)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel2.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(172, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Size"
        '
        'SizeCheckedComboBoxEdit
        '
        Me.SizeCheckedComboBoxEdit.Location = New System.Drawing.Point(204, 9)
        Me.SizeCheckedComboBoxEdit.Name = "SizeCheckedComboBoxEdit"
        Me.SizeCheckedComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeCheckedComboBoxEdit.Properties.DataSource = Me.OrderSizeLookupBindingSource
        Me.SizeCheckedComboBoxEdit.Properties.DisplayMember = "SizeCode"
        Me.SizeCheckedComboBoxEdit.Properties.ValueMember = "SizeId"
        Me.SizeCheckedComboBoxEdit.Size = New System.Drawing.Size(71, 20)
        Me.SizeCheckedComboBoxEdit.TabIndex = 5
        '
        'FabricGridControl
        '
        Me.FabricGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FabricGridControl.DataSource = Me.FabricBindingSource
        Me.FabricGridControl.EmbeddedNavigator.Buttons.First.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Last.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Next.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.NextPage.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Prev.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.PrevPage.Enabled = False
        Me.FabricGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.FabricGridControl.Location = New System.Drawing.Point(3, 62)
        Me.FabricGridControl.LookAndFeel.SkinName = "Blue"
        Me.FabricGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.FabricGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.FabricGridControl.MainView = Me.BandedGridView1
        Me.FabricGridControl.Name = "FabricGridControl"
        Me.FabricGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.DyeingTypeGridLookUpEdit, Me.FabricTypeGridLookUpEdit, Me.DiaTypeComboBox, Me.DiaUnitComboBox, Me.FinishUnitComboBox, Me.CompositionGridLookUpEdit, Me.GarmentsPartGridLookUpEdit, Me.GSMGridLookUpEdit, Me.RepositoryItemCalcEdit1})
        Me.FabricGridControl.Size = New System.Drawing.Size(862, 102)
        Me.FabricGridControl.TabIndex = 1
        Me.FabricGridControl.UseEmbeddedNavigator = True
        Me.FabricGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'FabricBindingSource
        '
        Me.FabricBindingSource.DataMember = "Fabric"
        Me.FabricBindingSource.DataSource = Me.FabricBOMDataSet
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand2, Me.GridBand3, Me.gridBand1, Me.GridBand4, Me.GridBand5})
        Me.BandedGridView1.ColumnPanelRowHeight = 40
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colDyeingTypeId, Me.colRemarks1, Me.colKnittingTypeId, Me.colFinishFabricDia, Me.colDiaType, Me.colMarkerLengthYrds, Me.colMarkerLengthInch, Me.colMarkerWidth, Me.colLengthAllowance, Me.colWidthAllowance, Me.colWastagePercentage, Me.colGMQuantity, Me.colDiaUnit, Me.colFinishUnit, Me.colCompositionId, Me.colSPNote, Me.colGarmentsPartId, Me.colGSMId, Me.colCon, Me.colForColor, Me.colForSize, Me.colFabricId, Me.colIsCC, Me.colGreyWastagePercentage, Me.colKgPerUnit, Me.colLength, Me.colCCSize1, Me.colMCDia_MCGauge, Me.colMCDia, Me.colMCGauge})
        Me.BandedGridView1.GridControl = Me.FabricGridControl
        Me.BandedGridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "Con", Nothing, "")})
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.BandedGridView1.OptionsView.ShowDetailButtons = False
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "Fabric Information"
        Me.gridBand2.Columns.Add(Me.colFabricId)
        Me.gridBand2.Columns.Add(Me.colGarmentsPartId)
        Me.gridBand2.Columns.Add(Me.colKnittingTypeId)
        Me.gridBand2.Columns.Add(Me.colCompositionId)
        Me.gridBand2.Columns.Add(Me.colGSMId)
        Me.gridBand2.Columns.Add(Me.colFinishFabricDia)
        Me.gridBand2.Columns.Add(Me.colDiaType)
        Me.gridBand2.Columns.Add(Me.colDiaUnit)
        Me.gridBand2.Columns.Add(Me.colIsCC)
        Me.gridBand2.Columns.Add(Me.colLength)
        Me.gridBand2.Columns.Add(Me.colCCSize1)
        Me.gridBand2.Columns.Add(Me.colSPNote)
        Me.gridBand2.Columns.Add(Me.colMCDia_MCGauge)
        Me.gridBand2.Columns.Add(Me.colMCDia)
        Me.gridBand2.Columns.Add(Me.colMCGauge)
        Me.gridBand2.Columns.Add(Me.colCon)
        Me.gridBand2.Columns.Add(Me.colFinishUnit)
        Me.gridBand2.Columns.Add(Me.colKgPerUnit)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 0
        Me.gridBand2.Width = 1163
        '
        'colFabricId
        '
        Me.colFabricId.Caption = "FID"
        Me.colFabricId.FieldName = "FabricId"
        Me.colFabricId.Name = "colFabricId"
        Me.colFabricId.Width = 61
        '
        'colGarmentsPartId
        '
        Me.colGarmentsPartId.Caption = "GMT Part"
        Me.colGarmentsPartId.ColumnEdit = Me.GarmentsPartGridLookUpEdit
        Me.colGarmentsPartId.FieldName = "GarmentsPartId"
        Me.colGarmentsPartId.Name = "colGarmentsPartId"
        Me.colGarmentsPartId.Visible = True
        Me.colGarmentsPartId.Width = 96
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
        Me.colKnittingTypeId.Width = 181
        '
        'FabricTypeGridLookUpEdit
        '
        Me.FabricTypeGridLookUpEdit.AutoHeight = False
        Me.FabricTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricTypeGridLookUpEdit.DataSource = Me.KnittingTypeBindingSource
        Me.FabricTypeGridLookUpEdit.DisplayMember = "KnittingType"
        Me.FabricTypeGridLookUpEdit.ImmediatePopup = True
        Me.FabricTypeGridLookUpEdit.Name = "FabricTypeGridLookUpEdit"
        Me.FabricTypeGridLookUpEdit.NullText = ""
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
        Me.colCompositionId.Width = 182
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
        Me.colGSMId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colGSMId.Name = "colGSMId"
        Me.colGSMId.Visible = True
        Me.colGSMId.Width = 68
        '
        'GSMGridLookUpEdit
        '
        Me.GSMGridLookUpEdit.AutoHeight = False
        Me.GSMGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GSMGridLookUpEdit.DataSource = Me.GSMBindingSource
        Me.GSMGridLookUpEdit.DisplayMember = "GSM"
        Me.GSMGridLookUpEdit.Name = "GSMGridLookUpEdit"
        Me.GSMGridLookUpEdit.NullText = ""
        Me.GSMGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit2View
        Me.GSMGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
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
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGSM})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colGSM
        '
        Me.colGSM.FieldName = "GSM"
        Me.colGSM.Name = "colGSM"
        Me.colGSM.Visible = True
        Me.colGSM.VisibleIndex = 0
        '
        'colFinishFabricDia
        '
        Me.colFinishFabricDia.AppearanceHeader.Options.UseTextOptions = True
        Me.colFinishFabricDia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFinishFabricDia.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFinishFabricDia.FieldName = "FinishFabricDia"
        Me.colFinishFabricDia.Name = "colFinishFabricDia"
        Me.colFinishFabricDia.Visible = True
        Me.colFinishFabricDia.Width = 70
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
        Me.colDiaType.Width = 52
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
        Me.colDiaUnit.Width = 52
        '
        'DiaUnitComboBox
        '
        Me.DiaUnitComboBox.AutoHeight = False
        Me.DiaUnitComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiaUnitComboBox.Items.AddRange(New Object() {"IN", "CM"})
        Me.DiaUnitComboBox.Name = "DiaUnitComboBox"
        '
        'colIsCC
        '
        Me.colIsCC.Caption = "CC"
        Me.colIsCC.FieldName = "IsCC"
        Me.colIsCC.Name = "colIsCC"
        Me.colIsCC.Width = 40
        '
        'colLength
        '
        Me.colLength.FieldName = "Length"
        Me.colLength.Name = "colLength"
        Me.colLength.Visible = True
        Me.colLength.Width = 73
        '
        'colCCSize1
        '
        Me.colCCSize1.FieldName = "CCSize"
        Me.colCCSize1.Name = "colCCSize1"
        Me.colCCSize1.Width = 70
        '
        'colSPNote
        '
        Me.colSPNote.FieldName = "SPNote"
        Me.colSPNote.Name = "colSPNote"
        Me.colSPNote.Visible = True
        Me.colSPNote.Width = 77
        '
        'colMCDia_MCGauge
        '
        Me.colMCDia_MCGauge.Caption = "MC DXG"
        Me.colMCDia_MCGauge.FieldName = "MCDia_MCGauge"
        Me.colMCDia_MCGauge.Name = "colMCDia_MCGauge"
        Me.colMCDia_MCGauge.Width = 59
        '
        'colMCDia
        '
        Me.colMCDia.AppearanceCell.Options.UseTextOptions = True
        Me.colMCDia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMCDia.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMCDia.FieldName = "MCDia"
        Me.colMCDia.Name = "colMCDia"
        Me.colMCDia.Visible = True
        Me.colMCDia.Width = 51
        '
        'colMCGauge
        '
        Me.colMCGauge.AppearanceCell.Options.UseTextOptions = True
        Me.colMCGauge.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMCGauge.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMCGauge.FieldName = "MCGauge"
        Me.colMCGauge.Name = "colMCGauge"
        Me.colMCGauge.Visible = True
        Me.colMCGauge.Width = 58
        '
        'colCon
        '
        Me.colCon.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colCon.AppearanceCell.Options.UseBackColor = True
        Me.colCon.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.colCon.DisplayFormat.FormatString = "n3"
        Me.colCon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCon.FieldName = "Con"
        Me.colCon.Name = "colCon"
        Me.colCon.Visible = True
        Me.colCon.Width = 59
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatString = "n3"
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.EditFormat.FormatString = "n3"
        Me.RepositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
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
        Me.colFinishUnit.Width = 52
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
        Me.colKgPerUnit.FieldName = "KgPerUnit"
        Me.colKgPerUnit.Name = "colKgPerUnit"
        Me.colKgPerUnit.Visible = True
        Me.colKgPerUnit.Width = 92
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "Cad Info"
        Me.GridBand3.Columns.Add(Me.colMarkerLengthYrds)
        Me.GridBand3.Columns.Add(Me.colMarkerLengthInch)
        Me.GridBand3.Columns.Add(Me.colMarkerWidth)
        Me.GridBand3.Columns.Add(Me.colWidthAllowance)
        Me.GridBand3.Columns.Add(Me.colLengthAllowance)
        Me.GridBand3.Columns.Add(Me.colGMQuantity)
        Me.GridBand3.Columns.Add(Me.colWastagePercentage)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.VisibleIndex = 1
        Me.GridBand3.Width = 431
        '
        'colMarkerLengthYrds
        '
        Me.colMarkerLengthYrds.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerLengthYrds.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerLengthYrds.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerLengthYrds.FieldName = "MarkerLengthYrds"
        Me.colMarkerLengthYrds.Name = "colMarkerLengthYrds"
        Me.colMarkerLengthYrds.Visible = True
        Me.colMarkerLengthYrds.Width = 68
        '
        'colMarkerLengthInch
        '
        Me.colMarkerLengthInch.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerLengthInch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerLengthInch.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerLengthInch.FieldName = "MarkerLengthInch"
        Me.colMarkerLengthInch.Name = "colMarkerLengthInch"
        Me.colMarkerLengthInch.Visible = True
        Me.colMarkerLengthInch.Width = 67
        '
        'colMarkerWidth
        '
        Me.colMarkerWidth.AppearanceHeader.Options.UseTextOptions = True
        Me.colMarkerWidth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMarkerWidth.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMarkerWidth.FieldName = "MarkerWidth"
        Me.colMarkerWidth.Name = "colMarkerWidth"
        Me.colMarkerWidth.Visible = True
        Me.colMarkerWidth.Width = 58
        '
        'colWidthAllowance
        '
        Me.colWidthAllowance.AppearanceHeader.Options.UseTextOptions = True
        Me.colWidthAllowance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWidthAllowance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWidthAllowance.FieldName = "WidthAllowance"
        Me.colWidthAllowance.Name = "colWidthAllowance"
        Me.colWidthAllowance.Visible = True
        Me.colWidthAllowance.Width = 58
        '
        'colLengthAllowance
        '
        Me.colLengthAllowance.AppearanceHeader.Options.UseTextOptions = True
        Me.colLengthAllowance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLengthAllowance.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLengthAllowance.FieldName = "LengthAllowance"
        Me.colLengthAllowance.Name = "colLengthAllowance"
        Me.colLengthAllowance.Visible = True
        Me.colLengthAllowance.Width = 58
        '
        'colGMQuantity
        '
        Me.colGMQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colGMQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGMQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGMQuantity.DisplayFormat.FormatString = "n2"
        Me.colGMQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGMQuantity.FieldName = "GMQuantity"
        Me.colGMQuantity.Name = "colGMQuantity"
        Me.colGMQuantity.Visible = True
        Me.colGMQuantity.Width = 58
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
        Me.colWastagePercentage.Width = 64
        '
        'gridBand1
        '
        Me.gridBand1.Caption = "Process Loss"
        Me.gridBand1.Columns.Add(Me.colGreyWastagePercentage)
        Me.gridBand1.Name = "gridBand1"
        Me.gridBand1.VisibleIndex = 2
        Me.gridBand1.Width = 55
        '
        'colGreyWastagePercentage
        '
        Me.colGreyWastagePercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colGreyWastagePercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGreyWastagePercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colGreyWastagePercentage.Caption = "Greige %"
        Me.colGreyWastagePercentage.FieldName = "GreyWastagePercentage"
        Me.colGreyWastagePercentage.Name = "colGreyWastagePercentage"
        Me.colGreyWastagePercentage.Visible = True
        Me.colGreyWastagePercentage.Width = 55
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "Additional Information"
        Me.GridBand4.Columns.Add(Me.colDyeingTypeId)
        Me.GridBand4.Columns.Add(Me.colForColor)
        Me.GridBand4.Columns.Add(Me.colForSize)
        Me.GridBand4.Columns.Add(Me.colRemarks1)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.VisibleIndex = 3
        Me.GridBand4.Width = 281
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
        Me.colDyeingTypeId.Width = 64
        '
        'DyeingTypeGridLookUpEdit
        '
        Me.DyeingTypeGridLookUpEdit.AutoHeight = False
        Me.DyeingTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DyeingTypeGridLookUpEdit.DisplayMember = "DyeingType"
        Me.DyeingTypeGridLookUpEdit.Name = "DyeingTypeGridLookUpEdit"
        Me.DyeingTypeGridLookUpEdit.NullText = ""
        Me.DyeingTypeGridLookUpEdit.PopupView = Me.GridView7
        Me.DyeingTypeGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DyeingTypeGridLookUpEdit.ValueMember = "DyeingTypeId"
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
        'colForColor
        '
        Me.colForColor.FieldName = "ForColor"
        Me.colForColor.Name = "colForColor"
        Me.colForColor.Visible = True
        Me.colForColor.Width = 53
        '
        'colForSize
        '
        Me.colForSize.FieldName = "ForSize"
        Me.colForSize.Name = "colForSize"
        Me.colForSize.Visible = True
        Me.colForSize.Width = 59
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
        'GridBand5
        '
        Me.GridBand5.Caption = "Other Wastage Percentage"
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Visible = False
        Me.GridBand5.VisibleIndex = -1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Color"
        '
        'ColorCheckedComboBoxEdit
        '
        Me.ColorCheckedComboBoxEdit.Location = New System.Drawing.Point(57, 9)
        Me.ColorCheckedComboBoxEdit.Name = "ColorCheckedComboBoxEdit"
        Me.ColorCheckedComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorCheckedComboBoxEdit.Properties.DataSource = Me.OrderFabricColorBindingSource
        Me.ColorCheckedComboBoxEdit.Properties.DisplayMember = "ColorDetails"
        Me.ColorCheckedComboBoxEdit.Properties.ValueMember = "FabricColorId"
        Me.ColorCheckedComboBoxEdit.Size = New System.Drawing.Size(107, 20)
        Me.ColorCheckedComboBoxEdit.TabIndex = 4
        '
        'FabricForSizeGridControl
        '
        Me.FabricForSizeGridControl.DataSource = Me.FabricForSizeBindingSource
        Me.FabricForSizeGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FabricForSizeGridControl.Location = New System.Drawing.Point(0, 0)
        Me.FabricForSizeGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.FabricForSizeGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.FabricForSizeGridControl.MainView = Me.GridView2
        Me.FabricForSizeGridControl.Name = "FabricForSizeGridControl"
        Me.FabricForSizeGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.Color2GridLookUpEdit, Me.Contrast2GridLookUpEdit, Me.Size2GridLookUpEdit})
        Me.FabricForSizeGridControl.Size = New System.Drawing.Size(412, 167)
        Me.FabricForSizeGridControl.TabIndex = 0
        Me.FabricForSizeGridControl.UseEmbeddedNavigator = True
        Me.FabricForSizeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'FabricForSizeBindingSource
        '
        Me.FabricForSizeBindingSource.DataMember = "Fabric_FabricForSize"
        Me.FabricForSizeBindingSource.DataSource = Me.FabricBindingSource
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeId, Me.colOrderQuantity, Me.colFabricColorId, Me.colReference, Me.colCode, Me.colFabricQuantity, Me.colContrastColorId, Me.colCCSize, Me.colCuttingPercentage})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(767, 474, 216, 164)
        Me.GridView2.GridControl = Me.FabricForSizeGridControl
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrderQuantity", Me.colOrderQuantity, "")})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colSizeId
        '
        Me.colSizeId.Caption = "Size"
        Me.colSizeId.ColumnEdit = Me.Size2GridLookUpEdit
        Me.colSizeId.FieldName = "SizeId"
        Me.colSizeId.Name = "colSizeId"
        Me.colSizeId.Visible = True
        Me.colSizeId.VisibleIndex = 4
        Me.colSizeId.Width = 84
        '
        'Size2GridLookUpEdit
        '
        Me.Size2GridLookUpEdit.AutoHeight = False
        Me.Size2GridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Size2GridLookUpEdit.DataSource = Me.OrderSizeLookupBindingSource
        Me.Size2GridLookUpEdit.DisplayMember = "SizeCode"
        Me.Size2GridLookUpEdit.Name = "Size2GridLookUpEdit"
        Me.Size2GridLookUpEdit.NullText = ""
        Me.Size2GridLookUpEdit.PopupView = Me.GridView5
        Me.Size2GridLookUpEdit.ValueMember = "SizeId"
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colSizeCode
        '
        Me.colSizeCode.FieldName = "SizeCode"
        Me.colSizeCode.Name = "colSizeCode"
        Me.colSizeCode.Visible = True
        Me.colSizeCode.VisibleIndex = 0
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.OptionsColumn.AllowEdit = False
        Me.colOrderQuantity.OptionsColumn.ReadOnly = True
        Me.colOrderQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 7
        Me.colOrderQuantity.Width = 95
        '
        'colFabricColorId
        '
        Me.colFabricColorId.Caption = "Garments Color"
        Me.colFabricColorId.ColumnEdit = Me.Color2GridLookUpEdit
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        Me.colFabricColorId.OptionsColumn.AllowEdit = False
        Me.colFabricColorId.OptionsColumn.ReadOnly = True
        Me.colFabricColorId.Visible = True
        Me.colFabricColorId.VisibleIndex = 0
        Me.colFabricColorId.Width = 124
        '
        'Color2GridLookUpEdit
        '
        Me.Color2GridLookUpEdit.AutoHeight = False
        Me.Color2GridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Color2GridLookUpEdit.DataSource = Me.OrderFabricColorBindingSource
        Me.Color2GridLookUpEdit.DisplayMember = "FabricColorName"
        Me.Color2GridLookUpEdit.Name = "Color2GridLookUpEdit"
        Me.Color2GridLookUpEdit.NullText = ""
        Me.Color2GridLookUpEdit.PopupView = Me.GridView3
        Me.Color2GridLookUpEdit.ValueMember = "FabricColorId"
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colReference
        '
        Me.colReference.FieldName = "Reference"
        Me.colReference.Name = "colReference"
        Me.colReference.OptionsColumn.AllowEdit = False
        Me.colReference.OptionsColumn.ReadOnly = True
        Me.colReference.Visible = True
        Me.colReference.VisibleIndex = 3
        Me.colReference.Width = 123
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.OptionsColumn.AllowEdit = False
        Me.colCode.OptionsColumn.ReadOnly = True
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 2
        Me.colCode.Width = 61
        '
        'colFabricQuantity
        '
        Me.colFabricQuantity.FieldName = "FabricQuantity"
        Me.colFabricQuantity.Name = "colFabricQuantity"
        Me.colFabricQuantity.OptionsColumn.AllowEdit = False
        Me.colFabricQuantity.OptionsColumn.ReadOnly = True
        Me.colFabricQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFabricQuantity.Visible = True
        Me.colFabricQuantity.VisibleIndex = 8
        Me.colFabricQuantity.Width = 112
        '
        'colContrastColorId
        '
        Me.colContrastColorId.Caption = "Fabric Color"
        Me.colContrastColorId.ColumnEdit = Me.Contrast2GridLookUpEdit
        Me.colContrastColorId.FieldName = "ContrastColorId"
        Me.colContrastColorId.Name = "colContrastColorId"
        Me.colContrastColorId.OptionsColumn.AllowEdit = False
        Me.colContrastColorId.OptionsColumn.ReadOnly = True
        Me.colContrastColorId.Visible = True
        Me.colContrastColorId.VisibleIndex = 1
        Me.colContrastColorId.Width = 126
        '
        'Contrast2GridLookUpEdit
        '
        Me.Contrast2GridLookUpEdit.AutoHeight = False
        Me.Contrast2GridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Contrast2GridLookUpEdit.DataSource = Me.FabricColorBindingSource
        Me.Contrast2GridLookUpEdit.DisplayMember = "FabricColorName"
        Me.Contrast2GridLookUpEdit.Name = "Contrast2GridLookUpEdit"
        Me.Contrast2GridLookUpEdit.NullText = ""
        Me.Contrast2GridLookUpEdit.PopupView = Me.GridView4
        Me.Contrast2GridLookUpEdit.ValueMember = "FabricColorId"
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colCCSize
        '
        Me.colCCSize.FieldName = "CCSize"
        Me.colCCSize.Name = "colCCSize"
        Me.colCCSize.OptionsColumn.AllowEdit = False
        Me.colCCSize.OptionsColumn.ReadOnly = True
        Me.colCCSize.Visible = True
        Me.colCCSize.VisibleIndex = 5
        Me.colCCSize.Width = 102
        '
        'colCuttingPercentage
        '
        Me.colCuttingPercentage.Caption = "C%"
        Me.colCuttingPercentage.FieldName = "CuttingPercentage"
        Me.colCuttingPercentage.Name = "colCuttingPercentage"
        Me.colCuttingPercentage.OptionsColumn.AllowEdit = False
        Me.colCuttingPercentage.OptionsColumn.ReadOnly = True
        Me.colCuttingPercentage.Visible = True
        Me.colCuttingPercentage.VisibleIndex = 6
        Me.colCuttingPercentage.Width = 36
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.PopupView = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ApplyButton
        '
        Me.ApplyButton.Location = New System.Drawing.Point(56, 62)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(112, 23)
        Me.ApplyButton.TabIndex = 11
        Me.ApplyButton.Text = "Apply to All Color"
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(-102, 66)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Collar / Cuff Size"
        '
        'CCSizeTextEdit
        '
        Me.CCSizeTextEdit.Location = New System.Drawing.Point(56, 39)
        Me.CCSizeTextEdit.Name = "CCSizeTextEdit"
        Me.CCSizeTextEdit.Size = New System.Drawing.Size(105, 20)
        Me.CCSizeTextEdit.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(22, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Size"
        '
        'SizeLookupGridLookUpEdit
        '
        Me.SizeLookupGridLookUpEdit.Location = New System.Drawing.Point(56, 13)
        Me.SizeLookupGridLookUpEdit.Name = "SizeLookupGridLookUpEdit"
        Me.SizeLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SizeLookupGridLookUpEdit.Properties.DataSource = Me.OrderSizeLookupBindingSource
        Me.SizeLookupGridLookUpEdit.Properties.DisplayMember = "SizeCode"
        Me.SizeLookupGridLookUpEdit.Properties.NullText = ""
        Me.SizeLookupGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit2View
        Me.SizeLookupGridLookUpEdit.Properties.ValueMember = "SizeId"
        Me.SizeLookupGridLookUpEdit.Size = New System.Drawing.Size(80, 20)
        Me.SizeLookupGridLookUpEdit.TabIndex = 1
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSizeCode1})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colSizeCode1
        '
        Me.colSizeCode1.FieldName = "SizeCode"
        Me.colSizeCode1.Name = "colSizeCode1"
        Me.colSizeCode1.Visible = True
        Me.colSizeCode1.VisibleIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer3.Panel1.Controls.Add(Me.DelSelButton)
        Me.SplitContainer3.Panel1.Controls.Add(Me.SelectByFabricButton)
        Me.SplitContainer3.Panel1.Controls.Add(Me.SelectButton)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Signature4CheckEdit)
        Me.SplitContainer3.Panel1.Controls.Add(Me.FabricBOMDetailsDataGridView)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Signature3CheckEdit)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Signature1CheckEdit)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Signature2CheckEdit)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer3.Panel2.Controls.Add(ProceedForKnittingLabel)
        Me.SplitContainer3.Size = New System.Drawing.Size(1284, 254)
        Me.SplitContainer3.SplitterDistance = 139
        Me.SplitContainer3.TabIndex = 0
        '
        'DelSelButton
        '
        Me.DelSelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DelSelButton.Location = New System.Drawing.Point(813, 116)
        Me.DelSelButton.Name = "DelSelButton"
        Me.DelSelButton.Size = New System.Drawing.Size(112, 23)
        Me.DelSelButton.TabIndex = 31
        Me.DelSelButton.Text = "&Delete Selected"
        Me.DelSelButton.UseVisualStyleBackColor = True
        '
        'SelectByFabricButton
        '
        Me.SelectByFabricButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SelectByFabricButton.Location = New System.Drawing.Point(617, 116)
        Me.SelectByFabricButton.Name = "SelectByFabricButton"
        Me.SelectByFabricButton.Size = New System.Drawing.Size(112, 23)
        Me.SelectByFabricButton.TabIndex = 31
        Me.SelectByFabricButton.Text = "&Select by Fabric"
        Me.SelectByFabricButton.UseVisualStyleBackColor = True
        '
        'SelectButton
        '
        Me.SelectButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SelectButton.Location = New System.Drawing.Point(539, 116)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(72, 23)
        Me.SelectButton.TabIndex = 31
        Me.SelectButton.Text = "&Select All"
        Me.SelectButton.UseVisualStyleBackColor = True
        '
        'Signature4CheckEdit
        '
        Me.Signature4CheckEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Signature4CheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "Signature4", True))
        Me.Signature4CheckEdit.Location = New System.Drawing.Point(417, 118)
        Me.Signature4CheckEdit.Name = "Signature4CheckEdit"
        Me.Signature4CheckEdit.Properties.Caption = "Approved By"
        Me.Signature4CheckEdit.Properties.ReadOnly = True
        Me.Signature4CheckEdit.Size = New System.Drawing.Size(137, 19)
        Me.Signature4CheckEdit.TabIndex = 30
        '
        'FabricBOMDetailsDataGridView
        '
        Me.FabricBOMDetailsDataGridView.AllowUserToAddRows = False
        Me.FabricBOMDetailsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FabricBOMDetailsDataGridView.AutoGenerateColumns = False
        Me.FabricBOMDetailsDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FabricBOMDetailsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.FabricBOMDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FabricBOMDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelectColumn, Me.DataGridViewTextBoxColumn1, Me.DyeingPricePerUnit, Me.KnittingPricePerUnit, Me.GarmentsPartId, Me.IsMain, Me.CCSize, Me.Composition, Me.DataGridViewTextBoxColumn10, Me.DataGridViewComboBoxColumn1, Me.FGSM, Me.FDia, Me.DiaType, Me.FabricColorId, Me.GarmentsColorId, Me.ColorSL, Me.ColorCode, Me.DataGridViewTextBoxColumn8, Me.OrderQuantity, Me.CuttingPercentage, Me.Consumption, Me.DataGridViewTextBoxColumn14, Me.FinishFabricQuantity, Me.AdditionalQuantity, Me.GreyPercentage, Me.GreyFabricQuantity, Me.DataGridViewTextBoxColumn21, Me.Discontinue, Me.KgPerUnit, Me.IsAOP, Me.IsStripe})
        Me.FabricBOMDetailsDataGridView.DataSource = Me.FabricBOMDetailsBindingSource
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FabricBOMDetailsDataGridView.DefaultCellStyle = DataGridViewCellStyle16
        Me.FabricBOMDetailsDataGridView.Location = New System.Drawing.Point(0, 3)
        Me.FabricBOMDetailsDataGridView.Name = "FabricBOMDetailsDataGridView"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FabricBOMDetailsDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.FabricBOMDetailsDataGridView.Size = New System.Drawing.Size(1284, 112)
        Me.FabricBOMDetailsDataGridView.TabIndex = 0
        '
        'SelectColumn
        '
        Me.SelectColumn.DataPropertyName = "SelectColumn"
        Me.SelectColumn.HeaderText = "Select"
        Me.SelectColumn.Name = "SelectColumn"
        Me.SelectColumn.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FabricId"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "FID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DyeingPricePerUnit
        '
        Me.DyeingPricePerUnit.DataPropertyName = "DyeingPricePerUnit"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DyeingPricePerUnit.DefaultCellStyle = DataGridViewCellStyle3
        Me.DyeingPricePerUnit.HeaderText = "Dyeing Price"
        Me.DyeingPricePerUnit.Name = "DyeingPricePerUnit"
        Me.DyeingPricePerUnit.Width = 50
        '
        'KnittingPricePerUnit
        '
        Me.KnittingPricePerUnit.DataPropertyName = "KnittingPricePerUnit"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KnittingPricePerUnit.DefaultCellStyle = DataGridViewCellStyle4
        Me.KnittingPricePerUnit.HeaderText = "Knitting Price"
        Me.KnittingPricePerUnit.Name = "KnittingPricePerUnit"
        Me.KnittingPricePerUnit.Width = 50
        '
        'GarmentsPartId
        '
        Me.GarmentsPartId.DataPropertyName = "GarmentsPartId"
        Me.GarmentsPartId.DataSource = Me.GarmentsPartBindingSource
        Me.GarmentsPartId.DisplayMember = "Name"
        Me.GarmentsPartId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.GarmentsPartId.HeaderText = "Part"
        Me.GarmentsPartId.Name = "GarmentsPartId"
        Me.GarmentsPartId.ReadOnly = True
        Me.GarmentsPartId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GarmentsPartId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.GarmentsPartId.ValueMember = "GarmentsPartId"
        '
        'IsMain
        '
        Me.IsMain.DataPropertyName = "IsMain"
        Me.IsMain.HeaderText = "Shell Fabric"
        Me.IsMain.Name = "IsMain"
        Me.IsMain.ReadOnly = True
        Me.IsMain.Width = 50
        '
        'CCSize
        '
        Me.CCSize.DataPropertyName = "CCSize"
        Me.CCSize.HeaderText = "CCSize"
        Me.CCSize.Name = "CCSize"
        Me.CCSize.ToolTipText = "Garments or Collar or Cuff Size"
        '
        'Composition
        '
        Me.Composition.DataPropertyName = "FabricId"
        Me.Composition.DataSource = Me.FabricViewBindingSource
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Composition.DefaultCellStyle = DataGridViewCellStyle5
        Me.Composition.DisplayMember = "Composition"
        Me.Composition.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Composition.HeaderText = "Composition"
        Me.Composition.Name = "Composition"
        Me.Composition.ReadOnly = True
        Me.Composition.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Composition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Composition.ValueMember = "FabricId"
        '
        'FabricViewBindingSource
        '
        Me.FabricViewBindingSource.DataMember = "FabricView"
        Me.FabricViewBindingSource.DataSource = Me.FabricBOMDataSet
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FabricId"
        Me.DataGridViewTextBoxColumn10.DataSource = Me.FabricViewBindingSource
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn10.DisplayMember = "KnittingType"
        Me.DataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fabric"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.ValueMember = "FabricId"
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "SPNote"
        Me.DataGridViewComboBoxColumn1.DataSource = Me.FabricViewBindingSource
        Me.DataGridViewComboBoxColumn1.DisplayMember = "SPNote"
        Me.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn1.HeaderText = "FSPNote"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ReadOnly = True
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.ValueMember = "FabricId"
        '
        'FGSM
        '
        Me.FGSM.DataPropertyName = "FGSM"
        Me.FGSM.DataSource = Me.FabricViewBindingSource
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FGSM.DefaultCellStyle = DataGridViewCellStyle7
        Me.FGSM.DisplayMember = "FGSM"
        Me.FGSM.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FGSM.HeaderText = "FGSM"
        Me.FGSM.Name = "FGSM"
        Me.FGSM.ReadOnly = True
        Me.FGSM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FGSM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FGSM.ValueMember = "FabricId"
        Me.FGSM.Width = 60
        '
        'FDia
        '
        Me.FDia.DataPropertyName = "FDia"
        Me.FDia.DataSource = Me.FabricViewBindingSource
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FDia.DefaultCellStyle = DataGridViewCellStyle8
        Me.FDia.DisplayMember = "FinishFabricDia"
        Me.FDia.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FDia.HeaderText = "FDia"
        Me.FDia.Name = "FDia"
        Me.FDia.ReadOnly = True
        Me.FDia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FDia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FDia.ValueMember = "FabricId"
        Me.FDia.Width = 60
        '
        'DiaType
        '
        Me.DiaType.DataPropertyName = "DiaType"
        Me.DiaType.DataSource = Me.FabricViewBindingSource
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DiaType.DefaultCellStyle = DataGridViewCellStyle9
        Me.DiaType.DisplayMember = "DiaType"
        Me.DiaType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DiaType.HeaderText = "Dia Type"
        Me.DiaType.Name = "DiaType"
        Me.DiaType.ReadOnly = True
        Me.DiaType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DiaType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DiaType.ValueMember = "FabricId"
        Me.DiaType.Width = 60
        '
        'FabricColorId
        '
        Me.FabricColorId.DataPropertyName = "FabricColorId"
        Me.FabricColorId.DataSource = Me.FabricColorBindingSource
        Me.FabricColorId.DisplayMember = "FabricColorName"
        Me.FabricColorId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.FabricColorId.HeaderText = "Fabric Color"
        Me.FabricColorId.Name = "FabricColorId"
        Me.FabricColorId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FabricColorId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FabricColorId.ValueMember = "FabricColorId"
        '
        'GarmentsColorId
        '
        Me.GarmentsColorId.DataPropertyName = "GarmentsColorId"
        Me.GarmentsColorId.DataSource = Me.FabricColorBindingSource
        Me.GarmentsColorId.DisplayMember = "FabricColorName"
        Me.GarmentsColorId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.GarmentsColorId.HeaderText = "Garments Color"
        Me.GarmentsColorId.Name = "GarmentsColorId"
        Me.GarmentsColorId.ReadOnly = True
        Me.GarmentsColorId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GarmentsColorId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.GarmentsColorId.ValueMember = "FabricColorId"
        '
        'ColorSL
        '
        Me.ColorSL.DataPropertyName = "ColorSL"
        Me.ColorSL.HeaderText = "Color SL"
        Me.ColorSL.Name = "ColorSL"
        Me.ColorSL.ReadOnly = True
        Me.ColorSL.Width = 50
        '
        'ColorCode
        '
        Me.ColorCode.DataPropertyName = "ColorCode"
        Me.ColorCode.HeaderText = "Color Code"
        Me.ColorCode.Name = "ColorCode"
        Me.ColorCode.ReadOnly = True
        Me.ColorCode.Width = 40
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ELDNo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Color Ref No"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'OrderQuantity
        '
        Me.OrderQuantity.DataPropertyName = "OrderQuantity"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.OrderQuantity.DefaultCellStyle = DataGridViewCellStyle10
        Me.OrderQuantity.HeaderText = "Order Quantity"
        Me.OrderQuantity.Name = "OrderQuantity"
        '
        'CuttingPercentage
        '
        Me.CuttingPercentage.DataPropertyName = "CuttingPercentage"
        Me.CuttingPercentage.HeaderText = "With Cutting%"
        Me.CuttingPercentage.Name = "CuttingPercentage"
        Me.CuttingPercentage.ReadOnly = True
        Me.CuttingPercentage.Width = 50
        '
        'Consumption
        '
        Me.Consumption.DataPropertyName = "Consumption"
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Consumption.DefaultCellStyle = DataGridViewCellStyle11
        Me.Consumption.HeaderText = "Con"
        Me.Consumption.Name = "Consumption"
        Me.Consumption.ReadOnly = True
        Me.Consumption.ToolTipText = "(MLYdsX36+MLIn+LA)*(MW+WA)*GSM/GM*12/1550/1000*(1+WP/100)"
        Me.Consumption.Width = 50
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "WastagePercentage"
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn14.HeaderText = "WP (%)"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.ToolTipText = "Wastage Percentage"
        Me.DataGridViewTextBoxColumn14.Width = 50
        '
        'FinishFabricQuantity
        '
        Me.FinishFabricQuantity.DataPropertyName = "FinishFabricQuantity"
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle13.NullValue = Nothing
        Me.FinishFabricQuantity.DefaultCellStyle = DataGridViewCellStyle13
        Me.FinishFabricQuantity.HeaderText = "Finish Fabric Quantity"
        Me.FinishFabricQuantity.Name = "FinishFabricQuantity"
        Me.FinishFabricQuantity.ReadOnly = True
        '
        'AdditionalQuantity
        '
        Me.AdditionalQuantity.DataPropertyName = "AdditionalQuantity"
        Me.AdditionalQuantity.HeaderText = "Additional Quantity"
        Me.AdditionalQuantity.Name = "AdditionalQuantity"
        '
        'GreyPercentage
        '
        Me.GreyPercentage.DataPropertyName = "GreyPercentage"
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GreyPercentage.DefaultCellStyle = DataGridViewCellStyle14
        Me.GreyPercentage.HeaderText = "GP(%)"
        Me.GreyPercentage.Name = "GreyPercentage"
        Me.GreyPercentage.Width = 50
        '
        'GreyFabricQuantity
        '
        Me.GreyFabricQuantity.DataPropertyName = "GreyFabricQuantity"
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GreyFabricQuantity.DefaultCellStyle = DataGridViewCellStyle15
        Me.GreyFabricQuantity.HeaderText = "Grey Fabric Quantity"
        Me.GreyFabricQuantity.Name = "GreyFabricQuantity"
        Me.GreyFabricQuantity.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'Discontinue
        '
        Me.Discontinue.DataPropertyName = "Discontinue"
        Me.Discontinue.HeaderText = "Discontinue"
        Me.Discontinue.Name = "Discontinue"
        Me.Discontinue.Width = 70
        '
        'KgPerUnit
        '
        Me.KgPerUnit.DataPropertyName = "KgPerUnit"
        Me.KgPerUnit.HeaderText = "KgPerUnit"
        Me.KgPerUnit.Name = "KgPerUnit"
        Me.KgPerUnit.ReadOnly = True
        '
        'IsAOP
        '
        Me.IsAOP.DataPropertyName = "IsAOP"
        Me.IsAOP.HeaderText = "IsAOP"
        Me.IsAOP.Name = "IsAOP"
        '
        'IsStripe
        '
        Me.IsStripe.DataPropertyName = "IsStripe"
        Me.IsStripe.HeaderText = "IsYDS"
        Me.IsStripe.Name = "IsStripe"
        '
        'FabricBOMDetailsBindingSource
        '
        Me.FabricBOMDetailsBindingSource.DataMember = "FK_FabricBOMDetails_FabricBOM"
        Me.FabricBOMDetailsBindingSource.DataSource = Me.FabricBOMBindingSource
        '
        'Signature3CheckEdit
        '
        Me.Signature3CheckEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Signature3CheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "Signature3", True))
        Me.Signature3CheckEdit.Location = New System.Drawing.Point(315, 118)
        Me.Signature3CheckEdit.Name = "Signature3CheckEdit"
        Me.Signature3CheckEdit.Properties.Caption = "M. Manager"
        Me.Signature3CheckEdit.Properties.ReadOnly = True
        Me.Signature3CheckEdit.Size = New System.Drawing.Size(101, 19)
        Me.Signature3CheckEdit.TabIndex = 29
        '
        'Signature1CheckEdit
        '
        Me.Signature1CheckEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Signature1CheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "Signature1", True))
        Me.Signature1CheckEdit.Location = New System.Drawing.Point(10, 118)
        Me.Signature1CheckEdit.Name = "Signature1CheckEdit"
        Me.Signature1CheckEdit.Properties.Caption = "CAD Manager"
        Me.Signature1CheckEdit.Properties.ReadOnly = True
        Me.Signature1CheckEdit.Size = New System.Drawing.Size(106, 19)
        Me.Signature1CheckEdit.TabIndex = 27
        '
        'Signature2CheckEdit
        '
        Me.Signature2CheckEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Signature2CheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "Signature2", True))
        Me.Signature2CheckEdit.Location = New System.Drawing.Point(121, 118)
        Me.Signature2CheckEdit.Name = "Signature2CheckEdit"
        Me.Signature2CheckEdit.Properties.Caption = "Merchandiser/Sr. Merchandiser"
        Me.Signature2CheckEdit.Properties.ReadOnly = True
        Me.Signature2CheckEdit.Size = New System.Drawing.Size(184, 19)
        Me.Signature2CheckEdit.TabIndex = 28
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.YarnAllocationButton)
        Me.SplitContainer6.Panel1.Controls.Add(Me.ProceedForKnittingCheckEdit)
        Me.SplitContainer6.Panel1.Controls.Add(Me.AdditionalCommentsSimpleButton)
        Me.SplitContainer6.Panel1.Controls.Add(ProgramCommentsLabel)
        Me.SplitContainer6.Panel1.Controls.Add(ExplationForAdditionalFabricQtyLabel)
        Me.SplitContainer6.Panel1.Controls.Add(Me.ProgramCommentsTextEdit)
        Me.SplitContainer6.Panel1.Controls.Add(Me.ExplationForAdditionalFabricQtyTextEdit)
        Me.SplitContainer6.Panel1.Controls.Add(Me.CheckWithComboBoxEdit)
        Me.SplitContainer6.Panel1.Controls.Add(Me.ProceedForDyeingCheckEdit)
        Me.SplitContainer6.Panel1.Controls.Add(CheckWithLabel)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.GetPercentageButton)
        Me.SplitContainer6.Panel2.Controls.Add(Me.PasteButton)
        Me.SplitContainer6.Panel2.Controls.Add(Me.CopyButton)
        Me.SplitContainer6.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer6.Panel2.Controls.Add(Me.DeselectAllLinkLabel)
        Me.SplitContainer6.Panel2.Controls.Add(Me.RefreshLinkLabel)
        Me.SplitContainer6.Panel2.Controls.Add(Me.InvertSelectLinkLabel)
        Me.SplitContainer6.Panel2.Controls.Add(Me.YarnAllocationGMTGridControl)
        Me.SplitContainer6.Panel2.Controls.Add(Me.YarnLotNoGridLookUpEdit)
        Me.SplitContainer6.Panel2.Controls.Add(Me.LCGridLookUpEdit)
        Me.SplitContainer6.Panel2.Controls.Add(Me.YarnRequireLabel)
        Me.SplitContainer6.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer6.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer6.Panel2.Controls.Add(Me.SetButton)
        Me.SplitContainer6.Size = New System.Drawing.Size(1284, 111)
        Me.SplitContainer6.SplitterDistance = 737
        Me.SplitContainer6.TabIndex = 0
        '
        'YarnAllocationButton
        '
        Me.YarnAllocationButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YarnAllocationButton.Location = New System.Drawing.Point(517, 70)
        Me.YarnAllocationButton.Name = "YarnAllocationButton"
        Me.YarnAllocationButton.Size = New System.Drawing.Size(145, 23)
        Me.YarnAllocationButton.TabIndex = 10
        Me.YarnAllocationButton.Text = "Yarn Allocation"
        '
        'ProceedForKnittingCheckEdit
        '
        Me.ProceedForKnittingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "ProceedForKnitting", True))
        Me.ProceedForKnittingCheckEdit.Location = New System.Drawing.Point(517, 16)
        Me.ProceedForKnittingCheckEdit.Name = "ProceedForKnittingCheckEdit"
        Me.ProceedForKnittingCheckEdit.Properties.Caption = "Proceed For Knitting"
        Me.ProceedForKnittingCheckEdit.Size = New System.Drawing.Size(130, 19)
        Me.ProceedForKnittingCheckEdit.TabIndex = 2
        '
        'AdditionalCommentsSimpleButton
        '
        Me.AdditionalCommentsSimpleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdditionalCommentsSimpleButton.Location = New System.Drawing.Point(362, 70)
        Me.AdditionalCommentsSimpleButton.Name = "AdditionalCommentsSimpleButton"
        Me.AdditionalCommentsSimpleButton.Size = New System.Drawing.Size(149, 23)
        Me.AdditionalCommentsSimpleButton.TabIndex = 3
        Me.AdditionalCommentsSimpleButton.Text = "Additional Comments"
        '
        'ProgramCommentsTextEdit
        '
        Me.ProgramCommentsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "ProgramComments", True))
        Me.ProgramCommentsTextEdit.Location = New System.Drawing.Point(195, 70)
        Me.ProgramCommentsTextEdit.Name = "ProgramCommentsTextEdit"
        Me.ProgramCommentsTextEdit.Size = New System.Drawing.Size(441, 20)
        Me.ProgramCommentsTextEdit.TabIndex = 9
        '
        'ExplationForAdditionalFabricQtyTextEdit
        '
        Me.ExplationForAdditionalFabricQtyTextEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExplationForAdditionalFabricQtyTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "ExplationForAdditionalFabricQty", True))
        Me.ExplationForAdditionalFabricQtyTextEdit.Location = New System.Drawing.Point(195, 44)
        Me.ExplationForAdditionalFabricQtyTextEdit.Name = "ExplationForAdditionalFabricQtyTextEdit"
        Me.ExplationForAdditionalFabricQtyTextEdit.Size = New System.Drawing.Size(467, 20)
        Me.ExplationForAdditionalFabricQtyTextEdit.TabIndex = 4
        '
        'CheckWithComboBoxEdit
        '
        Me.CheckWithComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "CheckWith", True))
        Me.CheckWithComboBoxEdit.Location = New System.Drawing.Point(195, 18)
        Me.CheckWithComboBoxEdit.Name = "CheckWithComboBoxEdit"
        Me.CheckWithComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CheckWithComboBoxEdit.Properties.Items.AddRange(New Object() {"Development Sample", "Sealed Sample", "Size Set", "Bulk Test Cutting"})
        Me.CheckWithComboBoxEdit.Size = New System.Drawing.Size(164, 20)
        Me.CheckWithComboBoxEdit.TabIndex = 0
        '
        'ProceedForDyeingCheckEdit
        '
        Me.ProceedForDyeingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FabricBOMBindingSource, "ProceedForDyeing", True))
        Me.ProceedForDyeingCheckEdit.Location = New System.Drawing.Point(378, 17)
        Me.ProceedForDyeingCheckEdit.Name = "ProceedForDyeingCheckEdit"
        Me.ProceedForDyeingCheckEdit.Properties.Caption = "Proceed For Dyeing"
        Me.ProceedForDyeingCheckEdit.Size = New System.Drawing.Size(133, 19)
        Me.ProceedForDyeingCheckEdit.TabIndex = 1
        '
        'GetPercentageButton
        '
        Me.GetPercentageButton.Location = New System.Drawing.Point(400, 5)
        Me.GetPercentageButton.Name = "GetPercentageButton"
        Me.GetPercentageButton.Size = New System.Drawing.Size(111, 23)
        Me.GetPercentageButton.TabIndex = 10
        Me.GetPercentageButton.Text = "Get Percentage"
        Me.GetPercentageButton.UseVisualStyleBackColor = True
        '
        'PasteButton
        '
        Me.PasteButton.Location = New System.Drawing.Point(69, 5)
        Me.PasteButton.Name = "PasteButton"
        Me.PasteButton.Size = New System.Drawing.Size(58, 23)
        Me.PasteButton.TabIndex = 10
        Me.PasteButton.Text = "Paste"
        Me.PasteButton.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(12, 5)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(54, 23)
        Me.CopyButton.TabIndex = 9
        Me.CopyButton.Text = "Copy"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(145, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Yarn Require"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'DeselectAllLinkLabel
        '
        Me.DeselectAllLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeselectAllLinkLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DeselectAllLinkLabel.Location = New System.Drawing.Point(1721, 7)
        Me.DeselectAllLinkLabel.Name = "DeselectAllLinkLabel"
        Me.DeselectAllLinkLabel.Size = New System.Drawing.Size(67, 19)
        Me.DeselectAllLinkLabel.TabIndex = 7
        Me.DeselectAllLinkLabel.TabStop = True
        Me.DeselectAllLinkLabel.Text = "Deselect All"
        Me.DeselectAllLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RefreshLinkLabel
        '
        Me.RefreshLinkLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RefreshLinkLabel.Location = New System.Drawing.Point(324, 8)
        Me.RefreshLinkLabel.Name = "RefreshLinkLabel"
        Me.RefreshLinkLabel.Size = New System.Drawing.Size(70, 19)
        Me.RefreshLinkLabel.TabIndex = 6
        Me.RefreshLinkLabel.TabStop = True
        Me.RefreshLinkLabel.Text = "Refresh"
        Me.RefreshLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InvertSelectLinkLabel
        '
        Me.InvertSelectLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvertSelectLinkLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.InvertSelectLinkLabel.Location = New System.Drawing.Point(1794, 7)
        Me.InvertSelectLinkLabel.Name = "InvertSelectLinkLabel"
        Me.InvertSelectLinkLabel.Size = New System.Drawing.Size(77, 19)
        Me.InvertSelectLinkLabel.TabIndex = 6
        Me.InvertSelectLinkLabel.TabStop = True
        Me.InvertSelectLinkLabel.Text = "Select Invert"
        Me.InvertSelectLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YarnAllocationGMTGridControl
        '
        Me.YarnAllocationGMTGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YarnAllocationGMTGridControl.DataSource = Me.YarnAllocationGMTBindingSource
        Me.YarnAllocationGMTGridControl.Location = New System.Drawing.Point(0, 34)
        Me.YarnAllocationGMTGridControl.MainView = Me.GridView6
        Me.YarnAllocationGMTGridControl.Name = "YarnAllocationGMTGridControl"
        Me.YarnAllocationGMTGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemGridLookUpEdit3})
        Me.YarnAllocationGMTGridControl.Size = New System.Drawing.Size(1213, 77)
        Me.YarnAllocationGMTGridControl.TabIndex = 0
        Me.YarnAllocationGMTGridControl.UseEmbeddedNavigator = True
        Me.YarnAllocationGMTGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'YarnAllocationGMTBindingSource
        '
        Me.YarnAllocationGMTBindingSource.DataMember = "FabricBOMDetails_YarnAllocationGMT"
        Me.YarnAllocationGMTBindingSource.DataSource = Me.FabricBOMDetailsBindingSource
        '
        'GridView6
        '
        Me.GridView6.ColumnPanelRowHeight = 40
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colYarnPercentage, Me.colWastagePercentage1, Me.colQuantity, Me.colStripeGroup, Me.colYarnColor, Me.colIsYds, Me.colFeederNo, Me.colFeederSize, Me.colFeederQty, Me.colRemarks, Me.colStripeSL, Me.colGroupSL, Me.colYarnPrice})
        Me.GridView6.GridControl = Me.YarnAllocationGMTGridControl
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsView.ColumnAutoWidth = False
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colYarnColor, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colItemId
        '
        Me.colItemId.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colItemId.Caption = "Yarn Name"
        Me.colItemId.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 257
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.ItemListBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "ItemName"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit2.PopupView = Me.GridView12
        Me.RepositoryItemGridLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "ItemId"
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
        'GridView12
        '
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemName})
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        '
        'colYarnPercentage
        '
        Me.colYarnPercentage.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnPercentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnPercentage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnPercentage.Caption = "Yarn %"
        Me.colYarnPercentage.DisplayFormat.FormatString = "n2"
        Me.colYarnPercentage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colYarnPercentage.FieldName = "YarnPercentage"
        Me.colYarnPercentage.Name = "colYarnPercentage"
        Me.colYarnPercentage.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colYarnPercentage.Visible = True
        Me.colYarnPercentage.VisibleIndex = 1
        Me.colYarnPercentage.Width = 66
        '
        'colWastagePercentage1
        '
        Me.colWastagePercentage1.AppearanceHeader.Options.UseTextOptions = True
        Me.colWastagePercentage1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWastagePercentage1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWastagePercentage1.Caption = "WP%"
        Me.colWastagePercentage1.FieldName = "WastagePercentage"
        Me.colWastagePercentage1.Name = "colWastagePercentage1"
        Me.colWastagePercentage1.Visible = True
        Me.colWastagePercentage1.VisibleIndex = 2
        Me.colWastagePercentage1.Width = 48
        '
        'colQuantity
        '
        Me.colQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 3
        Me.colQuantity.Width = 117
        '
        'colStripeGroup
        '
        Me.colStripeGroup.Caption = "Group"
        Me.colStripeGroup.FieldName = "StripeGroup"
        Me.colStripeGroup.Name = "colStripeGroup"
        Me.colStripeGroup.Visible = True
        Me.colStripeGroup.VisibleIndex = 6
        Me.colStripeGroup.Width = 96
        '
        'colYarnColor
        '
        Me.colYarnColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colYarnColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYarnColor.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colYarnColor.FieldName = "YarnColor"
        Me.colYarnColor.Name = "colYarnColor"
        Me.colYarnColor.Visible = True
        Me.colYarnColor.VisibleIndex = 9
        Me.colYarnColor.Width = 117
        '
        'colIsYds
        '
        Me.colIsYds.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsYds.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsYds.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsYds.FieldName = "IsYds"
        Me.colIsYds.Name = "colIsYds"
        Me.colIsYds.Visible = True
        Me.colIsYds.VisibleIndex = 8
        Me.colIsYds.Width = 52
        '
        'colFeederNo
        '
        Me.colFeederNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colFeederNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFeederNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFeederNo.Caption = "Feeder No"
        Me.colFeederNo.FieldName = "FeederNo"
        Me.colFeederNo.Name = "colFeederNo"
        Me.colFeederNo.Visible = True
        Me.colFeederNo.VisibleIndex = 10
        Me.colFeederNo.Width = 58
        '
        'colFeederSize
        '
        Me.colFeederSize.AppearanceHeader.Options.UseTextOptions = True
        Me.colFeederSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFeederSize.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFeederSize.FieldName = "FeederSize"
        Me.colFeederSize.Name = "colFeederSize"
        Me.colFeederSize.Visible = True
        Me.colFeederSize.VisibleIndex = 11
        Me.colFeederSize.Width = 80
        '
        'colFeederQty
        '
        Me.colFeederQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colFeederQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFeederQty.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colFeederQty.FieldName = "FeederQty"
        Me.colFeederQty.Name = "colFeederQty"
        Me.colFeederQty.Visible = True
        Me.colFeederQty.VisibleIndex = 12
        Me.colFeederQty.Width = 83
        '
        'colRemarks
        '
        Me.colRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 13
        Me.colRemarks.Width = 118
        '
        'colStripeSL
        '
        Me.colStripeSL.FieldName = "StripeSL"
        Me.colStripeSL.Name = "colStripeSL"
        Me.colStripeSL.Visible = True
        Me.colStripeSL.VisibleIndex = 7
        Me.colStripeSL.Width = 52
        '
        'colGroupSL
        '
        Me.colGroupSL.FieldName = "GroupSL"
        Me.colGroupSL.Name = "colGroupSL"
        Me.colGroupSL.Visible = True
        Me.colGroupSL.VisibleIndex = 5
        Me.colGroupSL.Width = 58
        '
        'colYarnPrice
        '
        Me.colYarnPrice.FieldName = "YarnPrice"
        Me.colYarnPrice.Name = "colYarnPrice"
        Me.colYarnPrice.Visible = True
        Me.colYarnPrice.VisibleIndex = 4
        '
        'RepositoryItemGridLookUpEdit3
        '
        Me.RepositoryItemGridLookUpEdit3.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit3.DataSource = Me.SupplierBindingSource
        Me.RepositoryItemGridLookUpEdit3.DisplayMember = "SupplierCode"
        Me.RepositoryItemGridLookUpEdit3.Name = "RepositoryItemGridLookUpEdit3"
        Me.RepositoryItemGridLookUpEdit3.PopupView = Me.RepositoryItemGridLookUpEdit3View
        Me.RepositoryItemGridLookUpEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit3.ValueMember = "SupplierId"
        '
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierCode1, Me.colSupplierName1})
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colSupplierCode1
        '
        Me.colSupplierCode1.FieldName = "SupplierCode"
        Me.colSupplierCode1.Name = "colSupplierCode1"
        Me.colSupplierCode1.Visible = True
        Me.colSupplierCode1.VisibleIndex = 0
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
        Me.colSupplierName1.Visible = True
        Me.colSupplierName1.VisibleIndex = 1
        '
        'YarnLotNoGridLookUpEdit
        '
        Me.YarnLotNoGridLookUpEdit.Location = New System.Drawing.Point(184, 38)
        Me.YarnLotNoGridLookUpEdit.Name = "YarnLotNoGridLookUpEdit"
        Me.YarnLotNoGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.YarnLotNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.YarnLotNoGridLookUpEdit.Properties.DataSource = Me.LotAndItemwiseBalanceBindingSource
        Me.YarnLotNoGridLookUpEdit.Properties.DisplayMember = "YarnLotNo"
        Me.YarnLotNoGridLookUpEdit.Properties.NullText = ""
        Me.YarnLotNoGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit3View
        Me.YarnLotNoGridLookUpEdit.Properties.ValueMember = "YarnLotNo"
        Me.YarnLotNoGridLookUpEdit.Size = New System.Drawing.Size(104, 20)
        Me.YarnLotNoGridLookUpEdit.TabIndex = 4
        '
        'LotAndItemwiseBalanceBindingSource
        '
        Me.LotAndItemwiseBalanceBindingSource.DataMember = "LotAndItemwiseBalance"
        Me.LotAndItemwiseBalanceBindingSource.DataSource = Me.LotAndItemBalanceDataSet
        '
        'LotAndItemBalanceDataSet
        '
        Me.LotAndItemBalanceDataSet.DataSetName = "LotAndItemBalanceDataSet"
        Me.LotAndItemBalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit3View
        '
        Me.GridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTTLIssue, Me.colTTLReceive, Me.colYarnLotNo, Me.colBalance, Me.colYarnLotNo1, Me.colRealStock, Me.colAllocateBalance})
        Me.GridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colBalance
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
        StyleFormatCondition1.Value1 = "0"
        Me.GridLookUpEdit3View.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridLookUpEdit3View.Name = "GridLookUpEdit3View"
        Me.GridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colTTLIssue
        '
        Me.colTTLIssue.FieldName = "TTLIssue"
        Me.colTTLIssue.Name = "colTTLIssue"
        Me.colTTLIssue.Visible = True
        Me.colTTLIssue.VisibleIndex = 2
        Me.colTTLIssue.Width = 66
        '
        'colTTLReceive
        '
        Me.colTTLReceive.FieldName = "TTLReceive"
        Me.colTTLReceive.Name = "colTTLReceive"
        Me.colTTLReceive.Visible = True
        Me.colTTLReceive.VisibleIndex = 1
        Me.colTTLReceive.Width = 67
        '
        'colYarnLotNo
        '
        Me.colYarnLotNo.FieldName = "YarnLotNo"
        Me.colYarnLotNo.Name = "colYarnLotNo"
        '
        'colYarnLotNo1
        '
        Me.colYarnLotNo1.FieldName = "YarnLotNo"
        Me.colYarnLotNo1.Name = "colYarnLotNo1"
        Me.colYarnLotNo1.Visible = True
        Me.colYarnLotNo1.VisibleIndex = 0
        Me.colYarnLotNo1.Width = 133
        '
        'colRealStock
        '
        Me.colRealStock.FieldName = "RealStock"
        Me.colRealStock.Name = "colRealStock"
        Me.colRealStock.Visible = True
        Me.colRealStock.VisibleIndex = 5
        Me.colRealStock.Width = 479
        '
        'colAllocateBalance
        '
        Me.colAllocateBalance.Caption = "Allocated"
        Me.colAllocateBalance.FieldName = "AllocateBalance"
        Me.colAllocateBalance.Name = "colAllocateBalance"
        Me.colAllocateBalance.Visible = True
        Me.colAllocateBalance.VisibleIndex = 4
        '
        'LCGridLookUpEdit
        '
        Me.LCGridLookUpEdit.Location = New System.Drawing.Point(344, 38)
        Me.LCGridLookUpEdit.Name = "LCGridLookUpEdit"
        Me.LCGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.LCGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LCGridLookUpEdit.Properties.DataSource = Me.PIAndItemwiseBalanceBindingSource
        Me.LCGridLookUpEdit.Properties.DisplayMember = "LCNo"
        Me.LCGridLookUpEdit.Properties.NullText = ""
        Me.LCGridLookUpEdit.Properties.PopupView = Me.GridView11
        Me.LCGridLookUpEdit.Properties.ValueMember = "LCId"
        Me.LCGridLookUpEdit.Size = New System.Drawing.Size(138, 20)
        Me.LCGridLookUpEdit.TabIndex = 1
        '
        'PIAndItemwiseBalanceBindingSource
        '
        Me.PIAndItemwiseBalanceBindingSource.DataMember = "PIAndItemwiseBalance"
        Me.PIAndItemwiseBalanceBindingSource.DataSource = Me.PIAnditemwiseBalanceDataSet
        '
        'PIAnditemwiseBalanceDataSet
        '
        Me.PIAnditemwiseBalanceDataSet.DataSetName = "PIAnditemwiseBalanceDataSet"
        Me.PIAnditemwiseBalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLCNo, Me.colTTLReceive1, Me.colTTLIssue1, Me.colBalance1})
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colBalance1
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
        StyleFormatCondition2.Value1 = "0"
        Me.GridView11.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'colLCNo
        '
        Me.colLCNo.FieldName = "LCNo"
        Me.colLCNo.Name = "colLCNo"
        Me.colLCNo.Visible = True
        Me.colLCNo.VisibleIndex = 0
        '
        'colTTLReceive1
        '
        Me.colTTLReceive1.FieldName = "TTLReceive"
        Me.colTTLReceive1.Name = "colTTLReceive1"
        Me.colTTLReceive1.Visible = True
        Me.colTTLReceive1.VisibleIndex = 1
        '
        'colTTLIssue1
        '
        Me.colTTLIssue1.FieldName = "TTLIssue"
        Me.colTTLIssue1.Name = "colTTLIssue1"
        Me.colTTLIssue1.Visible = True
        Me.colTTLIssue1.VisibleIndex = 2
        '
        'YarnRequireLabel
        '
        Me.YarnRequireLabel.BackColor = System.Drawing.Color.Yellow
        Me.YarnRequireLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.YarnRequireLabel.Location = New System.Drawing.Point(225, 6)
        Me.YarnRequireLabel.Name = "YarnRequireLabel"
        Me.YarnRequireLabel.Size = New System.Drawing.Size(88, 20)
        Me.YarnRequireLabel.TabIndex = 3
        Me.YarnRequireLabel.Text = "0"
        Me.YarnRequireLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.YarnRequireLabel.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(299, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "LC No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Lot No"
        '
        'SetButton
        '
        Me.SetButton.Location = New System.Drawing.Point(488, 37)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(97, 23)
        Me.SetButton.TabIndex = 5
        Me.SetButton.Text = "Allocate Lot No"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel3.Controls.Add(Me.NewButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.SaveButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.DeleteButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.CnclButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel3.Controls.Add(Me.GridLookUpEdit1)
        Me.FlowLayoutPanel3.Controls.Add(Me.ShowButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.SimpleButton1)
        Me.FlowLayoutPanel3.Controls.Add(Me.PrintSimpleButton)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1284, 37)
        Me.FlowLayoutPanel3.TabIndex = 0
        Me.FlowLayoutPanel3.Tag = "NR"
        '
        'NewButton
        '
        Me.NewButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewButton.Location = New System.Drawing.Point(10, 5)
        Me.NewButton.Margin = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(75, 25)
        Me.NewButton.TabIndex = 45
        Me.NewButton.Text = "&Add"
        Me.NewButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Location = New System.Drawing.Point(95, 5)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(5)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 25)
        Me.SaveButton.TabIndex = 46
        Me.SaveButton.Text = "&Edit"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteButton.Location = New System.Drawing.Point(180, 5)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 25)
        Me.DeleteButton.TabIndex = 47
        Me.DeleteButton.Text = "&Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'CnclButton
        '
        Me.CnclButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CnclButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CnclButton.Location = New System.Drawing.Point(265, 5)
        Me.CnclButton.Margin = New System.Windows.Forms.Padding(5)
        Me.CnclButton.Name = "CnclButton"
        Me.CnclButton.Size = New System.Drawing.Size(75, 25)
        Me.CnclButton.TabIndex = 48
        Me.CnclButton.Text = "&Cancel"
        Me.CnclButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(348, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(227, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Finish Fabric Booking"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.EditValue = ""
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(581, 7)
        Me.GridLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.FabricBOMIdSearchBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "Details2"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = "[Type Program No For Search]"
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridView13
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "FabricBOMId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(301, 20)
        Me.GridLookUpEdit1.TabIndex = 50
        '
        'GridView13
        '
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7})
        Me.GridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView13.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fabric Booking No"
        Me.GridColumn7.FieldName = "Details2"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(888, 7)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(60, 22)
        Me.ShowButton.TabIndex = 49
        Me.ShowButton.Text = "Show"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(954, 7)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(60, 22)
        Me.SimpleButton1.TabIndex = 32
        Me.SimpleButton1.Text = "Refresh"
        '
        'PrintSimpleButton
        '
        Me.PrintSimpleButton.Location = New System.Drawing.Point(1020, 7)
        Me.PrintSimpleButton.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.PrintSimpleButton.Name = "PrintSimpleButton"
        Me.PrintSimpleButton.Size = New System.Drawing.Size(60, 22)
        Me.PrintSimpleButton.TabIndex = 31
        Me.PrintSimpleButton.Text = "Print"
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
        Me.TableAdapterManager.FabricForSizeTableAdapter = Me.FabricForSizeTableAdapter
        Me.TableAdapterManager.FabricTableAdapter = Me.FabricTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.FabricBOMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YarnAllocationGMTTableAdapter = Me.YarnAllocationGMTTableAdapter
        '
        'FabricBOMDetailsTableAdapter
        '
        Me.FabricBOMDetailsTableAdapter.ClearBeforeFill = True
        '
        'FabricForSizeTableAdapter
        '
        Me.FabricForSizeTableAdapter.ClearBeforeFill = True
        '
        'FabricTableAdapter
        '
        Me.FabricTableAdapter.ClearBeforeFill = True
        '
        'YarnAllocationGMTTableAdapter
        '
        Me.YarnAllocationGMTTableAdapter.ClearBeforeFill = True
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
        'OrderSizeLookupTableAdapter
        '
        Me.OrderSizeLookupTableAdapter.ClearBeforeFill = True
        '
        'PIAndItemwiseBalanceTableAdapter
        '
        Me.PIAndItemwiseBalanceTableAdapter.ClearBeforeFill = True
        '
        'LotAndItemwiseBalanceTableAdapter
        '
        Me.LotAndItemwiseBalanceTableAdapter.ClearBeforeFill = True
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
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
        'frmFabricBooking_Bulk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 666)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmFabricBooking_Bulk"
        Me.Text = "Fabric Booking [Bulk]"
        CType(Me.SizeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderFabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContrastColorLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.YarnDyeingTypeGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnDyeingTypeGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsAOPCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingStartDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingStartDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderQuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsEmbroideryCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsYDSCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsBrushCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPeachFinishCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscontinueCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CauseofDiscontinueTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPrintCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmbDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AOPDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsWashCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashReferenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingStartCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingStartCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingStartCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnReceivedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FDCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingCommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsFabricBOMCompleteCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBookingDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBookingDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricReqDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricReqDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentNoSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDetailsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMIdSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMIdSearchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.CopyTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishUnitComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DyeingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCheckedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricForSizeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricForSizeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Size2GridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color2GridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contrast2GridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCSizeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SizeLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.Signature4CheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Signature3CheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Signature1CheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Signature2CheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel1.PerformLayout()
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.Panel2.PerformLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.ProceedForKnittingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramCommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExplationForAdditionalFabricQtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckWithComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProceedForDyeingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnAllocationGMTGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnAllocationGMTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnLotNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotAndItemBalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIAndItemwiseBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIAnditemwiseBalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderSizeLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents FabricBOMDataSet As KSoft_Apparel.FabricBOMDataSet
    Friend WithEvents FabricBOMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBOMTableAdapter As KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricBOMTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.FabricBOMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents OrderIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ExplationForAdditionalFabricQtyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FabricReqDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FabricBookingDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents AmendmentDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AmendmentDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AmendmentNoSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ProceedForDyeingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ProceedForKnittingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckWithComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents FabricTableAdapter As KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricTableAdapter
    Friend WithEvents FabricBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBOMDetailsTableAdapter As KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricBOMDetailsTableAdapter
    Friend WithEvents FabricBOMDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AmendmentSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FabricBOMIdLabel1 As System.Windows.Forms.Label
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents GSMDataSet As KSoft_Apparel.GSMDataSet
    Friend WithEvents GSMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GSMTableAdapter As KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
    Friend WithEvents FabricViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricViewTableAdapter As KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricViewTableAdapter
    Friend WithEvents AdditionalCommentsSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GarmentsPartDataSet As KSoft_Apparel.GarmentsPartDataSet
    Friend WithEvents GarmentsPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartTableAdapter As KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents FabricBOMIdSearchDataSet As KSoft_Apparel.FabricBOMIdSearchDataSet
    Friend WithEvents FabricBOMIdSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBOMIdSearchTableAdapter As KSoft_Apparel.FabricBOMIdSearchDataSetTableAdapters.FabricBOMIdSearchTableAdapter
    Friend WithEvents PrintSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents ProgramCommentsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents UserDataSet As KSoft_Apparel.UserDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CnclButton As System.Windows.Forms.Button
    Friend WithEvents ShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FabricGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colGarmentsPartId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GarmentsPartGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents FabricTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompositionId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents CompositionGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colComposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSMId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GSMGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFinishFabricDia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDiaType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DiaTypeComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colDiaUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DiaUnitComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colFinishUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents FinishUnitComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colSPNote As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarkerLengthYrds As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarkerLengthInch As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarkerWidth As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWidthAllowance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLengthAllowance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWastagePercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGMQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDyeingTypeId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DyeingTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDyeingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents FabricBOMDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
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
    Friend WithEvents colCon As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents IsFabricBOMCompleteCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ColorCheckedComboBoxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents OrderFabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderFabricColorDataSet As KSoft_Apparel.OrderFabricColorDataSet
    Friend WithEvents OrderFabricColorTableAdapter As KSoft_Apparel.OrderFabricColorDataSetTableAdapters.OrderFabricColorTableAdapter
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents FabricForSizeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricForSizeTableAdapter As KSoft_Apparel.FabricBOMDataSetTableAdapters.FabricForSizeTableAdapter
    Friend WithEvents FabricForSizeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeCheckedComboBoxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents OrderSizeLookupDataSet As KSoft_Apparel.OrderSizeLookupDataSet
    Friend WithEvents OrderSizeDataSet As KSoft_Apparel.OrderSizeDataSet
    Friend WithEvents OrderSizeLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderSizeLookupTableAdapter As KSoft_Apparel.OrderSizeDataSetTableAdapters.OrderSizeLookupTableAdapter
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColorLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colReference As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colForColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colForSize As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents colFabricQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContrastColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DyeingCommentsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FDCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SizeLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ApplyButton As System.Windows.Forms.Button
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CCSizeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colSizeCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SizeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ContrastColorLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents Color2GridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Contrast2GridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Size2GridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSizeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YarnAllocationButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents YarnAllocationGMTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YarnAllocationGMTTableAdapter As KSoft_Apparel.FabricBOMDataSetTableAdapters.YarnAllocationGMTTableAdapter
    Friend WithEvents YarnAllocationGMTGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWastagePercentage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsYds As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFeederSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFeederQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LCGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents YarnLotNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PIAndItemwiseBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PIAnditemwiseBalanceDataSet As KSoft_Apparel.PIAnditemwiseBalanceDataSet
    Friend WithEvents PIAndItemwiseBalanceTableAdapter As KSoft_Apparel.PIAnditemwiseBalanceDataSetTableAdapters.PIAndItemwiseBalanceTableAdapter
    Friend WithEvents LotAndItemwiseBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LotAndItemBalanceDataSet As KSoft_Apparel.LotAndItemBalanceDataSet
    Friend WithEvents LotAndItemwiseBalanceTableAdapter As KSoft_Apparel.LotAndItemBalanceDataSetTableAdapters.LotAndItemwiseBalanceTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents colTTLIssue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLReceive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnLotNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYarnLotNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLReceive1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLIssue1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Apparel.ItemListLookupDataSet
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents SetButton As System.Windows.Forms.Button
    Friend WithEvents RepositoryItemGridLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents InvertSelectLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents colRealStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsCC As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SetCColorButton As System.Windows.Forms.Button
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CColorGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView19 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorName3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colGreyWastagePercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colSupplierCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents YarnRequireLabel As System.Windows.Forms.Label
    Friend WithEvents RefreshLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents colStripeGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFeederNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKgPerUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents DeselectAllLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PasteButton As System.Windows.Forms.Button
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents colLength As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCCSize1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CopyTextBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents AsignedColorAndSizeButton As System.Windows.Forms.Button
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents colStripeSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents colCuttingPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMCDia_MCGauge As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colGroupSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMCDia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMCGauge As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Signature4CheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Signature3CheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Signature2CheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Signature1CheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents WashTypeDataSet As KSoft_Apparel.WashTypeDataSet
    Friend WithEvents WashTypeMstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WashTypeMstTableAdapter As KSoft_Apparel.WashTypeDataSetTableAdapters.WashTypeMstTableAdapter
    Friend WithEvents colWashType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IsWashCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents WashTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents WashTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WashDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SampleDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SampleReferenceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WashReferenceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GetDataButton As System.Windows.Forms.Button
    Friend WithEvents IsYDSCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsBrushCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsPeachFinishCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DiscontinueCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CauseofDiscontinueTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsPrintCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AOPDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PrintDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents POGroupLabel As System.Windows.Forms.Label
    Friend WithEvents IsEmbroideryCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents OrderQuantityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BookingStartDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents IsAOPCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents EmbDetailsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents YarnReceivedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DyeingStartCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents KnittingStartCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CuttingStartCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RefTextBox As TextBox
    Friend WithEvents colYarnPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents YarnDyeingTypeGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents YarnDyeingTypeGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SelectButton As Button
    Friend WithEvents SelectByFabricButton As Button
    Friend WithEvents DelSelButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SelectColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DyeingPricePerUnit As DataGridViewTextBoxColumn
    Friend WithEvents KnittingPricePerUnit As DataGridViewTextBoxColumn
    Friend WithEvents GarmentsPartId As DataGridViewComboBoxColumn
    Friend WithEvents IsMain As DataGridViewCheckBoxColumn
    Friend WithEvents CCSize As DataGridViewTextBoxColumn
    Friend WithEvents Composition As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents FGSM As DataGridViewComboBoxColumn
    Friend WithEvents FDia As DataGridViewComboBoxColumn
    Friend WithEvents DiaType As DataGridViewComboBoxColumn
    Friend WithEvents FabricColorId As DataGridViewComboBoxColumn
    Friend WithEvents GarmentsColorId As DataGridViewComboBoxColumn
    Friend WithEvents ColorSL As DataGridViewTextBoxColumn
    Friend WithEvents ColorCode As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents OrderQuantity As DataGridViewTextBoxColumn
    Friend WithEvents CuttingPercentage As DataGridViewTextBoxColumn
    Friend WithEvents Consumption As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents FinishFabricQuantity As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalQuantity As DataGridViewTextBoxColumn
    Friend WithEvents GreyPercentage As DataGridViewTextBoxColumn
    Friend WithEvents GreyFabricQuantity As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents Discontinue As DataGridViewCheckBoxColumn
    Friend WithEvents KgPerUnit As DataGridViewTextBoxColumn
    Friend WithEvents IsAOP As DataGridViewCheckBoxColumn
    Friend WithEvents IsStripe As DataGridViewCheckBoxColumn
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GetPercentageButton As Button
End Class
