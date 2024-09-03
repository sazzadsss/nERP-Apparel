<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterLC
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colACADay = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.ShowByButton = New System.Windows.Forms.Button
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.B2BLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.B2BLookupDataSet = New KSoft_Apparel.B2BLookupDataSet
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBTBLCNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBTBLCDate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.AddButton = New System.Windows.Forms.Button
        Me.ShowAllButton = New System.Windows.Forms.Button
        Me.ShowButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.MasterLCLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterLCDataSet = New KSoft_Apparel.MasterLCDataSet
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colRefAndMLCNo2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SaveButton = New System.Windows.Forms.Button
        Me.MasterLCGridControl = New DevExpress.XtraGrid.GridControl
        Me.MasterLCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colMerchandiserReferenceNo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMLCNO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMLCDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMLCValue = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMLCQuantity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBuyerId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.Buyer2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Buyer2DataSet = New KSoft_Apparel.Buyer2DataSet
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBuyer2Name = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBankAccountId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BankAccountGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.BankAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankAccountDataSet = New KSoft_Apparel.BankAccountDataSet
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colAccountNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAccountType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBankCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colFOBValue = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBTBOpen = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBTBOpenPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBTBAlreadyOpen = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBTBAlreadyOpenPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBTBBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.BTBBDT = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colDollarRate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBTBOpenBDT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBTBAlreadyOpenBDT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBTBBalanceBDT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colACADate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colIncentiveAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colACARealizedDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colFreight = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFACommissionPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFACommission = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLACommissionPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLACommission = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colBillSubmited = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDFC_FBPARAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDFC_FBPARBalance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPCBankAccountId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.PCBankAccountGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colAccountNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBankCode1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPCAmountBDT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPCDepositBDT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPCBalanceBDT = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colTTAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colTTAmountPercentage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.BTBLCGridControl = New DevExpress.XtraGrid.GridControl
        Me.BTBLCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBTBLCNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBTBLCDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SupplierGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAmountUSD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAmountBDT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIFDBC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPaymentAmount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPaymentDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMaterialType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MaterialTypeComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colDollarRate1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBTBType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BTBTypeComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.ExportBillGridControl = New DevExpress.XtraGrid.GridControl
        Me.ExportBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colBillNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBillDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBillAmount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRealisedAmount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRealisedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNegociateAmount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCD4354 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDFCDeposit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colECC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFACommission1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFCAmount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFDBP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLACommission1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMarginFDocs = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colODInterest = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCCH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSalesTax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPC = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPostage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.TTMasterGridControl = New DevExpress.XtraGrid.GridControl
        Me.TTMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTTNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTTDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSupplierId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TTSupplierGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colSupplierName1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAmountUSD1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.PackingCreditGridControl = New DevExpress.XtraGrid.GridControl
        Me.PackingCreditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colChequeNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colWithdrawal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRemarks4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet
        Me.MasterLCTableAdapter = New KSoft_Apparel.MasterLCDataSetTableAdapters.MasterLCTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.MasterLCDataSetTableAdapters.TableAdapterManager
        Me.BTBLCTableAdapter = New KSoft_Apparel.MasterLCDataSetTableAdapters.BTBLCTableAdapter
        Me.ExportBillTableAdapter = New KSoft_Apparel.MasterLCDataSetTableAdapters.ExportBillTableAdapter
        Me.TTMasterTableAdapter = New KSoft_Apparel.MasterLCDataSetTableAdapters.TTMasterTableAdapter
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Buyer2TableAdapter = New KSoft_Apparel.Buyer2DataSetTableAdapters.Buyer2TableAdapter
        Me.MasterLCLookupTableAdapter = New KSoft_Apparel.MasterLCDataSetTableAdapters.MasterLCLookupTableAdapter
        Me.colRefAndMLCNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRefAndMLCNo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.B2BLookupTableAdapter = New KSoft_Apparel.B2BLookupDataSetTableAdapters.B2BLookupTableAdapter
        Me.PackingCreditTableAdapter = New KSoft_Apparel.MasterLCDataSetTableAdapters.PackingCreditTableAdapter
        Me.BankAccountTableAdapter = New KSoft_Apparel.BankAccountDataSetTableAdapters.BankAccountTableAdapter
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.B2BLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.B2BLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLCLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLCGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buyer2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buyer2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankAccountGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankAccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankAccountDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBankAccountGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.BTBLCGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTBLCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialTypeComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTBTypeComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.ExportBillGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportBillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.TTMasterGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TTSupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.PackingCreditGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackingCreditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colACADay
        '
        Me.colACADay.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colACADay.AppearanceCell.Options.UseBackColor = True
        Me.colACADay.FieldName = "ACADay"
        Me.colACADay.Name = "colACADay"
        Me.colACADay.Visible = True
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ShowByButton)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridLookUpEdit2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.RefreshButton)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.AddButton)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ShowAllButton)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ShowButton)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridLookUpEdit1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SaveButton)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.MasterLCGridControl)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1362, 677)
        Me.SplitContainerControl1.SplitterPosition = 336
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ShowByButton
        '
        Me.ShowByButton.Location = New System.Drawing.Point(1133, 4)
        Me.ShowByButton.Name = "ShowByButton"
        Me.ShowByButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowByButton.TabIndex = 11
        Me.ShowByButton.Text = "&Show"
        Me.ShowByButton.UseVisualStyleBackColor = True
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(935, 5)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.B2BLookupBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "BTBLCNo"
        Me.GridLookUpEdit2.Properties.NullText = "[Select BTB No]"
        Me.GridLookUpEdit2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit2.Properties.ValueMember = "BTBLCId"
        Me.GridLookUpEdit2.Properties.View = Me.GridLookUpEdit2View
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(192, 20)
        Me.GridLookUpEdit2.TabIndex = 10
        '
        'B2BLookupBindingSource
        '
        Me.B2BLookupBindingSource.DataMember = "B2BLookup"
        Me.B2BLookupBindingSource.DataSource = Me.B2BLookupDataSet
        '
        'B2BLookupDataSet
        '
        Me.B2BLookupDataSet.DataSetName = "B2BLookupDataSet"
        Me.B2BLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBTBLCNo1, Me.colBTBLCDate1})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colBTBLCNo1
        '
        Me.colBTBLCNo1.FieldName = "BTBLCNo"
        Me.colBTBLCNo1.Name = "colBTBLCNo1"
        Me.colBTBLCNo1.Visible = True
        Me.colBTBLCNo1.VisibleIndex = 0
        '
        'colBTBLCDate1
        '
        Me.colBTBLCDate1.FieldName = "BTBLCDate"
        Me.colBTBLCDate1.Name = "colBTBLCDate1"
        Me.colBTBLCDate1.Visible = True
        Me.colBTBLCDate1.VisibleIndex = 1
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(178, 4)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 9
        Me.RefreshButton.Text = "&Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(12, 3)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 8
        Me.AddButton.Text = "&Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ShowAllButton
        '
        Me.ShowAllButton.Location = New System.Drawing.Point(845, 4)
        Me.ShowAllButton.Name = "ShowAllButton"
        Me.ShowAllButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowAllButton.TabIndex = 7
        Me.ShowAllButton.Text = "&Show All"
        Me.ShowAllButton.UseVisualStyleBackColor = True
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(764, 4)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 6
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ref :: Master LC  No : "
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(397, 5)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.MasterLCLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "RefAndMLCNo"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "MLCId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(361, 20)
        Me.GridLookUpEdit1.TabIndex = 4
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
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRefAndMLCNo2})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colRefAndMLCNo2
        '
        Me.colRefAndMLCNo2.FieldName = "RefAndMLCNo"
        Me.colRefAndMLCNo2.Name = "colRefAndMLCNo2"
        Me.colRefAndMLCNo2.Visible = True
        Me.colRefAndMLCNo2.VisibleIndex = 0
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(97, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'MasterLCGridControl
        '
        Me.MasterLCGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MasterLCGridControl.DataSource = Me.MasterLCBindingSource
        Me.MasterLCGridControl.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.MasterLCGridControl.Location = New System.Drawing.Point(1, 33)
        Me.MasterLCGridControl.MainView = Me.BandedGridView1
        Me.MasterLCGridControl.Name = "MasterLCGridControl"
        Me.MasterLCGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BuyerGridLookUpEdit, Me.BankAccountGridLookUpEdit, Me.PCBankAccountGridLookUpEdit})
        Me.MasterLCGridControl.Size = New System.Drawing.Size(1361, 302)
        Me.MasterLCGridControl.TabIndex = 0
        Me.MasterLCGridControl.UseEmbeddedNavigator = True
        Me.MasterLCGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1, Me.GridView2})
        '
        'MasterLCBindingSource
        '
        Me.MasterLCBindingSource.DataMember = "MasterLC"
        Me.MasterLCBindingSource.DataSource = Me.MasterLCDataSet
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.BandedGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand3, Me.BTBBDT, Me.GridBand6, Me.GridBand2, Me.GridBand4, Me.GridBand5, Me.GridBand7})
        Me.BandedGridView1.ColumnPanelRowHeight = 60
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colMLCNO, Me.colMLCDate, Me.colMLCValue, Me.colMLCQuantity, Me.colBuyerId, Me.colFACommission, Me.colLACommission, Me.colFreight, Me.colFOBValue, Me.colBTBOpen, Me.colBTBAlreadyOpen, Me.colBTBBalance, Me.colBillSubmited, Me.colBTBOpenBDT, Me.colBTBAlreadyOpenBDT, Me.colBTBBalanceBDT, Me.colDollarRate, Me.colBTBOpenPercentage, Me.colBTBAlreadyOpenPercentage, Me.colTTAmount, Me.colTTAmountPercentage, Me.colFACommissionPercentage, Me.colLACommissionPercentage, Me.colRemarks, Me.colMerchandiserReferenceNo, Me.colDFC_FBPARAmount, Me.colDFC_FBPARBalance, Me.colIncentiveAmount, Me.colACADay, Me.colACADate, Me.colACARealizedDate, Me.colBankAccountId, Me.colPCAmountBDT, Me.colPCBalanceBDT, Me.colPCDepositBDT, Me.colPCBankAccountId})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.colACADay
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
        StyleFormatCondition1.Tag = New Decimal(New Integer() {90, 0, 0, 0})
        StyleFormatCondition1.Value1 = New Decimal(New Integer() {90, 0, 0, 0})
        Me.BandedGridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.BandedGridView1.GridControl = Me.MasterLCGridControl
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsDetail.ShowDetailTabs = False
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView1.OptionsView.ShowDetailButtons = False
        Me.BandedGridView1.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Master LC Information"
        Me.GridBand1.Columns.Add(Me.colMerchandiserReferenceNo)
        Me.GridBand1.Columns.Add(Me.colMLCNO)
        Me.GridBand1.Columns.Add(Me.colMLCDate)
        Me.GridBand1.Columns.Add(Me.colMLCValue)
        Me.GridBand1.Columns.Add(Me.colMLCQuantity)
        Me.GridBand1.Columns.Add(Me.colBuyerId)
        Me.GridBand1.Columns.Add(Me.colRemarks)
        Me.GridBand1.Columns.Add(Me.colBankAccountId)
        Me.GridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 644
        '
        'colMerchandiserReferenceNo
        '
        Me.colMerchandiserReferenceNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colMerchandiserReferenceNo.AppearanceCell.Options.UseBackColor = True
        Me.colMerchandiserReferenceNo.Caption = "Reference No"
        Me.colMerchandiserReferenceNo.FieldName = "MerchandiserReferenceNo"
        Me.colMerchandiserReferenceNo.Name = "colMerchandiserReferenceNo"
        Me.colMerchandiserReferenceNo.Visible = True
        Me.colMerchandiserReferenceNo.Width = 62
        '
        'colMLCNO
        '
        Me.colMLCNO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colMLCNO.AppearanceCell.Options.UseBackColor = True
        Me.colMLCNO.FieldName = "MLCNO"
        Me.colMLCNO.Name = "colMLCNO"
        Me.colMLCNO.Visible = True
        Me.colMLCNO.Width = 108
        '
        'colMLCDate
        '
        Me.colMLCDate.FieldName = "MLCDate"
        Me.colMLCDate.Name = "colMLCDate"
        Me.colMLCDate.Visible = True
        Me.colMLCDate.Width = 82
        '
        'colMLCValue
        '
        Me.colMLCValue.DisplayFormat.FormatString = "##,##.00"
        Me.colMLCValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colMLCValue.FieldName = "MLCValue"
        Me.colMLCValue.Name = "colMLCValue"
        Me.colMLCValue.Visible = True
        Me.colMLCValue.Width = 78
        '
        'colMLCQuantity
        '
        Me.colMLCQuantity.DisplayFormat.FormatString = "##,##"
        Me.colMLCQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colMLCQuantity.FieldName = "MLCQuantity"
        Me.colMLCQuantity.Name = "colMLCQuantity"
        Me.colMLCQuantity.Visible = True
        Me.colMLCQuantity.Width = 64
        '
        'colBuyerId
        '
        Me.colBuyerId.Caption = "Buyer"
        Me.colBuyerId.ColumnEdit = Me.BuyerGridLookUpEdit
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.Visible = True
        Me.colBuyerId.Width = 80
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.AutoHeight = False
        Me.BuyerGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.DataSource = Me.Buyer2BindingSource
        Me.BuyerGridLookUpEdit.DisplayMember = "Buyer2Name"
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.NullText = ""
        Me.BuyerGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerGridLookUpEdit.ValueMember = "Buyer2Id"
        Me.BuyerGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'Buyer2BindingSource
        '
        Me.Buyer2BindingSource.DataMember = "Buyer2"
        Me.Buyer2BindingSource.DataSource = Me.Buyer2DataSet
        '
        'Buyer2DataSet
        '
        Me.Buyer2DataSet.DataSetName = "Buyer2DataSet"
        Me.Buyer2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyer2Name})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBuyer2Name
        '
        Me.colBuyer2Name.FieldName = "Buyer2Name"
        Me.colBuyer2Name.Name = "colBuyer2Name"
        Me.colBuyer2Name.Visible = True
        Me.colBuyer2Name.VisibleIndex = 0
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.Width = 83
        '
        'colBankAccountId
        '
        Me.colBankAccountId.Caption = "Bank Account"
        Me.colBankAccountId.ColumnEdit = Me.BankAccountGridLookUpEdit
        Me.colBankAccountId.FieldName = "BankAccountId"
        Me.colBankAccountId.Name = "colBankAccountId"
        Me.colBankAccountId.Visible = True
        Me.colBankAccountId.Width = 87
        '
        'BankAccountGridLookUpEdit
        '
        Me.BankAccountGridLookUpEdit.AutoHeight = False
        Me.BankAccountGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BankAccountGridLookUpEdit.DataSource = Me.BankAccountBindingSource
        Me.BankAccountGridLookUpEdit.DisplayMember = "AccountNo"
        Me.BankAccountGridLookUpEdit.Name = "BankAccountGridLookUpEdit"
        Me.BankAccountGridLookUpEdit.NullText = ""
        Me.BankAccountGridLookUpEdit.ValueMember = "BankAccountId"
        Me.BankAccountGridLookUpEdit.View = Me.GridView8
        '
        'BankAccountBindingSource
        '
        Me.BankAccountBindingSource.DataMember = "BankAccount"
        Me.BankAccountBindingSource.DataSource = Me.BankAccountDataSet
        '
        'BankAccountDataSet
        '
        Me.BankAccountDataSet.DataSetName = "BankAccountDataSet"
        Me.BankAccountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccountNo, Me.colAccountType, Me.colBankCode})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'colAccountNo
        '
        Me.colAccountNo.FieldName = "AccountNo"
        Me.colAccountNo.Name = "colAccountNo"
        Me.colAccountNo.Visible = True
        Me.colAccountNo.VisibleIndex = 0
        '
        'colAccountType
        '
        Me.colAccountType.FieldName = "AccountType"
        Me.colAccountType.Name = "colAccountType"
        Me.colAccountType.Visible = True
        Me.colAccountType.VisibleIndex = 1
        '
        'colBankCode
        '
        Me.colBankCode.FieldName = "BankCode"
        Me.colBankCode.Name = "colBankCode"
        Me.colBankCode.Visible = True
        Me.colBankCode.VisibleIndex = 2
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "BTB"
        Me.GridBand3.Columns.Add(Me.colFOBValue)
        Me.GridBand3.Columns.Add(Me.colBTBOpen)
        Me.GridBand3.Columns.Add(Me.colBTBOpenPercentage)
        Me.GridBand3.Columns.Add(Me.colBTBAlreadyOpen)
        Me.GridBand3.Columns.Add(Me.colBTBAlreadyOpenPercentage)
        Me.GridBand3.Columns.Add(Me.colBTBBalance)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 417
        '
        'colFOBValue
        '
        Me.colFOBValue.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.colFOBValue.AppearanceCell.Options.UseBackColor = True
        Me.colFOBValue.DisplayFormat.FormatString = "##,##.00"
        Me.colFOBValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFOBValue.FieldName = "FOBValue"
        Me.colFOBValue.Name = "colFOBValue"
        Me.colFOBValue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFOBValue.Visible = True
        '
        'colBTBOpen
        '
        Me.colBTBOpen.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.colBTBOpen.AppearanceCell.Options.UseBackColor = True
        Me.colBTBOpen.DisplayFormat.FormatString = "##,##.00"
        Me.colBTBOpen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBTBOpen.FieldName = "BTBOpen"
        Me.colBTBOpen.Name = "colBTBOpen"
        Me.colBTBOpen.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBTBOpen.Visible = True
        '
        'colBTBOpenPercentage
        '
        Me.colBTBOpenPercentage.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colBTBOpenPercentage.AppearanceCell.Options.UseBackColor = True
        Me.colBTBOpenPercentage.Caption = "BTB Open %"
        Me.colBTBOpenPercentage.DisplayFormat.FormatString = "##,##.00"
        Me.colBTBOpenPercentage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBTBOpenPercentage.FieldName = "BTBOpenPercentage"
        Me.colBTBOpenPercentage.Name = "colBTBOpenPercentage"
        Me.colBTBOpenPercentage.Visible = True
        Me.colBTBOpenPercentage.Width = 42
        '
        'colBTBAlreadyOpen
        '
        Me.colBTBAlreadyOpen.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.colBTBAlreadyOpen.AppearanceCell.Options.UseBackColor = True
        Me.colBTBAlreadyOpen.DisplayFormat.FormatString = "##,##.00"
        Me.colBTBAlreadyOpen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBTBAlreadyOpen.FieldName = "BTBAlreadyOpen"
        Me.colBTBAlreadyOpen.Name = "colBTBAlreadyOpen"
        Me.colBTBAlreadyOpen.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBTBAlreadyOpen.Visible = True
        '
        'colBTBAlreadyOpenPercentage
        '
        Me.colBTBAlreadyOpenPercentage.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colBTBAlreadyOpenPercentage.AppearanceCell.Options.UseBackColor = True
        Me.colBTBAlreadyOpenPercentage.DisplayFormat.FormatString = "p0"
        Me.colBTBAlreadyOpenPercentage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBTBAlreadyOpenPercentage.FieldName = "BTBAlreadyOpenPercentage"
        Me.colBTBAlreadyOpenPercentage.Name = "colBTBAlreadyOpenPercentage"
        Me.colBTBAlreadyOpenPercentage.Visible = True
        '
        'colBTBBalance
        '
        Me.colBTBBalance.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.colBTBBalance.AppearanceCell.ForeColor = System.Drawing.Color.Black
        Me.colBTBBalance.AppearanceCell.Options.UseBackColor = True
        Me.colBTBBalance.AppearanceCell.Options.UseForeColor = True
        Me.colBTBBalance.DisplayFormat.FormatString = "##,##.##"
        Me.colBTBBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBTBBalance.FieldName = "BTBBalance"
        Me.colBTBBalance.Name = "colBTBBalance"
        Me.colBTBBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBTBBalance.Visible = True
        '
        'BTBBDT
        '
        Me.BTBBDT.Caption = "BTB BDT"
        Me.BTBBDT.Columns.Add(Me.colDollarRate)
        Me.BTBBDT.Columns.Add(Me.colBTBOpenBDT)
        Me.BTBBDT.Columns.Add(Me.colBTBAlreadyOpenBDT)
        Me.BTBBDT.Columns.Add(Me.colBTBBalanceBDT)
        Me.BTBBDT.Name = "BTBBDT"
        Me.BTBBDT.Width = 280
        '
        'colDollarRate
        '
        Me.colDollarRate.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colDollarRate.AppearanceCell.Options.UseBackColor = True
        Me.colDollarRate.FieldName = "DollarRate"
        Me.colDollarRate.Name = "colDollarRate"
        Me.colDollarRate.Visible = True
        Me.colDollarRate.Width = 55
        '
        'colBTBOpenBDT
        '
        Me.colBTBOpenBDT.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colBTBOpenBDT.AppearanceCell.Options.UseBackColor = True
        Me.colBTBOpenBDT.DisplayFormat.FormatString = "##,##.00"
        Me.colBTBOpenBDT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBTBOpenBDT.FieldName = "BTBOpenBDT"
        Me.colBTBOpenBDT.Name = "colBTBOpenBDT"
        Me.colBTBOpenBDT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBTBOpenBDT.Visible = True
        '
        'colBTBAlreadyOpenBDT
        '
        Me.colBTBAlreadyOpenBDT.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colBTBAlreadyOpenBDT.AppearanceCell.Options.UseBackColor = True
        Me.colBTBAlreadyOpenBDT.DisplayFormat.FormatString = "##,##.00"
        Me.colBTBAlreadyOpenBDT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBTBAlreadyOpenBDT.FieldName = "BTBAlreadyOpenBDT"
        Me.colBTBAlreadyOpenBDT.Name = "colBTBAlreadyOpenBDT"
        Me.colBTBAlreadyOpenBDT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBTBAlreadyOpenBDT.Visible = True
        '
        'colBTBBalanceBDT
        '
        Me.colBTBBalanceBDT.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colBTBBalanceBDT.AppearanceCell.Options.UseBackColor = True
        Me.colBTBBalanceBDT.DisplayFormat.FormatString = "##,##.##"
        Me.colBTBBalanceBDT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBTBBalanceBDT.FieldName = "BTBBalanceBDT"
        Me.colBTBBalanceBDT.Name = "colBTBBalanceBDT"
        Me.colBTBBalanceBDT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBTBBalanceBDT.Visible = True
        '
        'GridBand6
        '
        Me.GridBand6.Caption = "Incentive"
        Me.GridBand6.Columns.Add(Me.colACADay)
        Me.GridBand6.Columns.Add(Me.colACADate)
        Me.GridBand6.Columns.Add(Me.colIncentiveAmount)
        Me.GridBand6.Columns.Add(Me.colACARealizedDate)
        Me.GridBand6.Name = "GridBand6"
        Me.GridBand6.Width = 300
        '
        'colACADate
        '
        Me.colACADate.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colACADate.AppearanceCell.Options.UseBackColor = True
        Me.colACADate.FieldName = "ACADate"
        Me.colACADate.Name = "colACADate"
        Me.colACADate.Visible = True
        '
        'colIncentiveAmount
        '
        Me.colIncentiveAmount.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.colIncentiveAmount.AppearanceCell.Options.UseBackColor = True
        Me.colIncentiveAmount.FieldName = "IncentiveAmount"
        Me.colIncentiveAmount.Name = "colIncentiveAmount"
        Me.colIncentiveAmount.Visible = True
        '
        'colACARealizedDate
        '
        Me.colACARealizedDate.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colACARealizedDate.AppearanceCell.Options.UseBackColor = True
        Me.colACARealizedDate.FieldName = "ACARealizedDate"
        Me.colACARealizedDate.Name = "colACARealizedDate"
        Me.colACARealizedDate.Visible = True
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "Commission"
        Me.GridBand2.Columns.Add(Me.colFreight)
        Me.GridBand2.Columns.Add(Me.colFACommissionPercentage)
        Me.GridBand2.Columns.Add(Me.colFACommission)
        Me.GridBand2.Columns.Add(Me.colLACommissionPercentage)
        Me.GridBand2.Columns.Add(Me.colLACommission)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 375
        '
        'colFreight
        '
        Me.colFreight.FieldName = "Freight"
        Me.colFreight.Name = "colFreight"
        Me.colFreight.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFreight.Visible = True
        '
        'colFACommissionPercentage
        '
        Me.colFACommissionPercentage.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colFACommissionPercentage.AppearanceCell.Options.UseBackColor = True
        Me.colFACommissionPercentage.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colFACommissionPercentage.AppearanceHeader.Options.UseBackColor = True
        Me.colFACommissionPercentage.Caption = "FA Commission %"
        Me.colFACommissionPercentage.FieldName = "FACommissionPercentage"
        Me.colFACommissionPercentage.Name = "colFACommissionPercentage"
        Me.colFACommissionPercentage.Visible = True
        '
        'colFACommission
        '
        Me.colFACommission.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colFACommission.AppearanceCell.Options.UseBackColor = True
        Me.colFACommission.DisplayFormat.FormatString = "##,##.00"
        Me.colFACommission.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFACommission.FieldName = "FACommission"
        Me.colFACommission.Name = "colFACommission"
        Me.colFACommission.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFACommission.Visible = True
        '
        'colLACommissionPercentage
        '
        Me.colLACommissionPercentage.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colLACommissionPercentage.AppearanceCell.Options.UseBackColor = True
        Me.colLACommissionPercentage.Caption = "LA Commission %"
        Me.colLACommissionPercentage.FieldName = "LACommissionPercentage"
        Me.colLACommissionPercentage.Name = "colLACommissionPercentage"
        Me.colLACommissionPercentage.Visible = True
        '
        'colLACommission
        '
        Me.colLACommission.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colLACommission.AppearanceCell.Options.UseBackColor = True
        Me.colLACommission.DisplayFormat.FormatString = "##,##.00"
        Me.colLACommission.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colLACommission.FieldName = "LACommission"
        Me.colLACommission.Name = "colLACommission"
        Me.colLACommission.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colLACommission.Visible = True
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "Export Bill"
        Me.GridBand4.Columns.Add(Me.colBillSubmited)
        Me.GridBand4.Columns.Add(Me.colDFC_FBPARAmount)
        Me.GridBand4.Columns.Add(Me.colDFC_FBPARBalance)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 225
        '
        'colBillSubmited
        '
        Me.colBillSubmited.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colBillSubmited.AppearanceCell.Options.UseBackColor = True
        Me.colBillSubmited.DisplayFormat.FormatString = "##,##.##"
        Me.colBillSubmited.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBillSubmited.FieldName = "BillSubmited"
        Me.colBillSubmited.Name = "colBillSubmited"
        Me.colBillSubmited.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBillSubmited.Visible = True
        '
        'colDFC_FBPARAmount
        '
        Me.colDFC_FBPARAmount.Caption = "DFC/FBPAR"
        Me.colDFC_FBPARAmount.DisplayFormat.FormatString = "##,##.00"
        Me.colDFC_FBPARAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colDFC_FBPARAmount.FieldName = "DFC_FBPARAmount"
        Me.colDFC_FBPARAmount.Name = "colDFC_FBPARAmount"
        Me.colDFC_FBPARAmount.Visible = True
        '
        'colDFC_FBPARBalance
        '
        Me.colDFC_FBPARBalance.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.colDFC_FBPARBalance.AppearanceCell.Options.UseBackColor = True
        Me.colDFC_FBPARBalance.Caption = "DFC/FBPAR Balance"
        Me.colDFC_FBPARBalance.DisplayFormat.FormatString = "##,##.00"
        Me.colDFC_FBPARBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colDFC_FBPARBalance.FieldName = "DFC_FBPARBalance"
        Me.colDFC_FBPARBalance.Name = "colDFC_FBPARBalance"
        Me.colDFC_FBPARBalance.Visible = True
        '
        'GridBand5
        '
        Me.GridBand5.Caption = "Packing Credit"
        Me.GridBand5.Columns.Add(Me.colPCBankAccountId)
        Me.GridBand5.Columns.Add(Me.colPCAmountBDT)
        Me.GridBand5.Columns.Add(Me.colPCDepositBDT)
        Me.GridBand5.Columns.Add(Me.colPCBalanceBDT)
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.Width = 300
        '
        'colPCBankAccountId
        '
        Me.colPCBankAccountId.Caption = "PC Bank Account"
        Me.colPCBankAccountId.ColumnEdit = Me.PCBankAccountGridLookUpEdit
        Me.colPCBankAccountId.FieldName = "PCBankAccountId"
        Me.colPCBankAccountId.Name = "colPCBankAccountId"
        Me.colPCBankAccountId.Visible = True
        '
        'PCBankAccountGridLookUpEdit
        '
        Me.PCBankAccountGridLookUpEdit.AutoHeight = False
        Me.PCBankAccountGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PCBankAccountGridLookUpEdit.DataSource = Me.BankAccountBindingSource
        Me.PCBankAccountGridLookUpEdit.DisplayMember = "AccountNo"
        Me.PCBankAccountGridLookUpEdit.Name = "PCBankAccountGridLookUpEdit"
        Me.PCBankAccountGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PCBankAccountGridLookUpEdit.ValueMember = "BankAccountId"
        Me.PCBankAccountGridLookUpEdit.View = Me.GridView9
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccountNo1, Me.colBankCode1})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colAccountNo1
        '
        Me.colAccountNo1.FieldName = "AccountNo"
        Me.colAccountNo1.Name = "colAccountNo1"
        Me.colAccountNo1.Visible = True
        Me.colAccountNo1.VisibleIndex = 0
        '
        'colBankCode1
        '
        Me.colBankCode1.FieldName = "BankCode"
        Me.colBankCode1.Name = "colBankCode1"
        Me.colBankCode1.Visible = True
        Me.colBankCode1.VisibleIndex = 1
        '
        'colPCAmountBDT
        '
        Me.colPCAmountBDT.FieldName = "PCAmountBDT"
        Me.colPCAmountBDT.Name = "colPCAmountBDT"
        Me.colPCAmountBDT.Visible = True
        '
        'colPCDepositBDT
        '
        Me.colPCDepositBDT.FieldName = "PCDepositBDT"
        Me.colPCDepositBDT.Name = "colPCDepositBDT"
        Me.colPCDepositBDT.Visible = True
        '
        'colPCBalanceBDT
        '
        Me.colPCBalanceBDT.FieldName = "PCBalanceBDT"
        Me.colPCBalanceBDT.Name = "colPCBalanceBDT"
        Me.colPCBalanceBDT.Visible = True
        '
        'GridBand7
        '
        Me.GridBand7.Caption = "TT"
        Me.GridBand7.Columns.Add(Me.colTTAmount)
        Me.GridBand7.Columns.Add(Me.colTTAmountPercentage)
        Me.GridBand7.Name = "GridBand7"
        Me.GridBand7.Width = 150
        '
        'colTTAmount
        '
        Me.colTTAmount.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colTTAmount.AppearanceCell.Options.UseBackColor = True
        Me.colTTAmount.DisplayFormat.FormatString = "##,##.00"
        Me.colTTAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTTAmount.FieldName = "TTAmount"
        Me.colTTAmount.Name = "colTTAmount"
        Me.colTTAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colTTAmount.Visible = True
        '
        'colTTAmountPercentage
        '
        Me.colTTAmountPercentage.AppearanceCell.BackColor = System.Drawing.Color.WhiteSmoke
        Me.colTTAmountPercentage.AppearanceCell.Options.UseBackColor = True
        Me.colTTAmountPercentage.FieldName = "TTAmountPercentage"
        Me.colTTAmountPercentage.Name = "colTTAmountPercentage"
        Me.colTTAmountPercentage.Visible = True
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.MasterLCGridControl
        Me.GridView2.Name = "GridView2"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1362, 336)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.BTBLCGridControl)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1356, 310)
        Me.XtraTabPage1.Text = "BTB Details"
        '
        'BTBLCGridControl
        '
        Me.BTBLCGridControl.DataSource = Me.BTBLCBindingSource
        Me.BTBLCGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTBLCGridControl.Location = New System.Drawing.Point(0, 0)
        Me.BTBLCGridControl.MainView = Me.GridView3
        Me.BTBLCGridControl.Name = "BTBLCGridControl"
        Me.BTBLCGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SupplierGridLookUpEdit, Me.MaterialTypeComboBox, Me.BTBTypeComboBox})
        Me.BTBLCGridControl.Size = New System.Drawing.Size(1356, 310)
        Me.BTBLCGridControl.TabIndex = 0
        Me.BTBLCGridControl.UseEmbeddedNavigator = True
        Me.BTBLCGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'BTBLCBindingSource
        '
        Me.BTBLCBindingSource.DataMember = "FK_BTBLC_MasterLC"
        Me.BTBLCBindingSource.DataSource = Me.MasterLCBindingSource
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSL, Me.colBTBLCNo, Me.colBTBLCDate, Me.colSupplierId, Me.colAmountUSD, Me.colAmountBDT, Me.colIFDBC, Me.colDueDate, Me.colPaymentAmount, Me.colPaymentDate, Me.colRemarks1, Me.colMaterialType, Me.colDollarRate1, Me.colBTBType})
        Me.GridView3.GridControl = Me.BTBLCGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colSL
        '
        Me.colSL.FieldName = "SL"
        Me.colSL.Name = "colSL"
        Me.colSL.Visible = True
        Me.colSL.VisibleIndex = 0
        Me.colSL.Width = 53
        '
        'colBTBLCNo
        '
        Me.colBTBLCNo.FieldName = "BTBLCNo"
        Me.colBTBLCNo.Name = "colBTBLCNo"
        Me.colBTBLCNo.Visible = True
        Me.colBTBLCNo.VisibleIndex = 3
        Me.colBTBLCNo.Width = 102
        '
        'colBTBLCDate
        '
        Me.colBTBLCDate.FieldName = "BTBLCDate"
        Me.colBTBLCDate.Name = "colBTBLCDate"
        Me.colBTBLCDate.Visible = True
        Me.colBTBLCDate.VisibleIndex = 4
        Me.colBTBLCDate.Width = 102
        '
        'colSupplierId
        '
        Me.colSupplierId.Caption = "Supplier"
        Me.colSupplierId.ColumnEdit = Me.SupplierGridLookUpEdit
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.Visible = True
        Me.colSupplierId.VisibleIndex = 5
        Me.colSupplierId.Width = 164
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.AutoHeight = False
        Me.SupplierGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierGridLookUpEdit.DataSource = Me.SupplierBindingSource
        Me.SupplierGridLookUpEdit.DisplayMember = "SupplierName"
        Me.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit"
        Me.SupplierGridLookUpEdit.NullText = ""
        Me.SupplierGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierGridLookUpEdit.ValueMember = "SupplierId"
        Me.SupplierGridLookUpEdit.View = Me.GridView6
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
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierName})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
        '
        'colAmountUSD
        '
        Me.colAmountUSD.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colAmountUSD.AppearanceCell.Options.UseBackColor = True
        Me.colAmountUSD.DisplayFormat.FormatString = "##,##.00"
        Me.colAmountUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAmountUSD.FieldName = "AmountUSD"
        Me.colAmountUSD.Name = "colAmountUSD"
        Me.colAmountUSD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colAmountUSD.Visible = True
        Me.colAmountUSD.VisibleIndex = 6
        Me.colAmountUSD.Width = 88
        '
        'colAmountBDT
        '
        Me.colAmountBDT.Caption = "Amount BDT"
        Me.colAmountBDT.DisplayFormat.FormatString = "##,#0.00"
        Me.colAmountBDT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colAmountBDT.FieldName = "AmountBDT"
        Me.colAmountBDT.Name = "colAmountBDT"
        Me.colAmountBDT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colAmountBDT.Visible = True
        Me.colAmountBDT.VisibleIndex = 7
        Me.colAmountBDT.Width = 104
        '
        'colIFDBC
        '
        Me.colIFDBC.FieldName = "IFDBC"
        Me.colIFDBC.Name = "colIFDBC"
        Me.colIFDBC.Visible = True
        Me.colIFDBC.VisibleIndex = 9
        Me.colIFDBC.Width = 104
        '
        'colDueDate
        '
        Me.colDueDate.FieldName = "DueDate"
        Me.colDueDate.Name = "colDueDate"
        Me.colDueDate.Visible = True
        Me.colDueDate.VisibleIndex = 10
        Me.colDueDate.Width = 104
        '
        'colPaymentAmount
        '
        Me.colPaymentAmount.DisplayFormat.FormatString = "##,##.##"
        Me.colPaymentAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colPaymentAmount.FieldName = "PaymentAmount"
        Me.colPaymentAmount.Name = "colPaymentAmount"
        Me.colPaymentAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPaymentAmount.Visible = True
        Me.colPaymentAmount.VisibleIndex = 11
        Me.colPaymentAmount.Width = 104
        '
        'colPaymentDate
        '
        Me.colPaymentDate.FieldName = "PaymentDate"
        Me.colPaymentDate.Name = "colPaymentDate"
        Me.colPaymentDate.Visible = True
        Me.colPaymentDate.VisibleIndex = 12
        Me.colPaymentDate.Width = 104
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 13
        Me.colRemarks1.Width = 110
        '
        'colMaterialType
        '
        Me.colMaterialType.ColumnEdit = Me.MaterialTypeComboBox
        Me.colMaterialType.FieldName = "MaterialType"
        Me.colMaterialType.Name = "colMaterialType"
        Me.colMaterialType.Visible = True
        Me.colMaterialType.VisibleIndex = 1
        Me.colMaterialType.Width = 117
        '
        'MaterialTypeComboBox
        '
        Me.MaterialTypeComboBox.AutoHeight = False
        Me.MaterialTypeComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MaterialTypeComboBox.Items.AddRange(New Object() {"Yarn", "Dyes", "Chemical", "Accessories", "Misc"})
        Me.MaterialTypeComboBox.Name = "MaterialTypeComboBox"
        '
        'colDollarRate1
        '
        Me.colDollarRate1.Caption = "Dollar Rate"
        Me.colDollarRate1.FieldName = "DollarRate"
        Me.colDollarRate1.Name = "colDollarRate1"
        Me.colDollarRate1.Visible = True
        Me.colDollarRate1.VisibleIndex = 8
        Me.colDollarRate1.Width = 61
        '
        'colBTBType
        '
        Me.colBTBType.ColumnEdit = Me.BTBTypeComboBox
        Me.colBTBType.FieldName = "BTBType"
        Me.colBTBType.Name = "colBTBType"
        Me.colBTBType.Visible = True
        Me.colBTBType.VisibleIndex = 2
        '
        'BTBTypeComboBox
        '
        Me.BTBTypeComboBox.AutoHeight = False
        Me.BTBTypeComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BTBTypeComboBox.Items.AddRange(New Object() {"Foreign", "EPZ", "Local"})
        Me.BTBTypeComboBox.Name = "BTBTypeComboBox"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.ExportBillGridControl)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1356, 310)
        Me.XtraTabPage2.Text = "Export Bill Details"
        '
        'ExportBillGridControl
        '
        Me.ExportBillGridControl.DataSource = Me.ExportBillBindingSource
        Me.ExportBillGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExportBillGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ExportBillGridControl.MainView = Me.GridView4
        Me.ExportBillGridControl.Name = "ExportBillGridControl"
        Me.ExportBillGridControl.Size = New System.Drawing.Size(1356, 310)
        Me.ExportBillGridControl.TabIndex = 0
        Me.ExportBillGridControl.UseEmbeddedNavigator = True
        Me.ExportBillGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'ExportBillBindingSource
        '
        Me.ExportBillBindingSource.DataMember = "FK_ExportBill_MasterLC"
        Me.ExportBillBindingSource.DataSource = Me.MasterLCBindingSource
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBillNo, Me.colBillDate, Me.colBillAmount, Me.colRealisedAmount, Me.colRealisedDate, Me.colNegociateAmount, Me.colRemarks2, Me.colCD4354, Me.colDFCDeposit, Me.colECC, Me.colFACommission1, Me.colFCAmount, Me.colFDBP, Me.colHC, Me.colLACommission1, Me.colMarginFDocs, Me.colODInterest, Me.colCCH, Me.colSalesTax, Me.colPC, Me.colPostage})
        Me.GridView4.GridControl = Me.ExportBillGridControl
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colBillNo
        '
        Me.colBillNo.FieldName = "BillNo"
        Me.colBillNo.Name = "colBillNo"
        Me.colBillNo.Visible = True
        Me.colBillNo.VisibleIndex = 0
        Me.colBillNo.Width = 117
        '
        'colBillDate
        '
        Me.colBillDate.FieldName = "BillDate"
        Me.colBillDate.Name = "colBillDate"
        Me.colBillDate.Visible = True
        Me.colBillDate.VisibleIndex = 1
        Me.colBillDate.Width = 106
        '
        'colBillAmount
        '
        Me.colBillAmount.DisplayFormat.FormatString = "##,##.00"
        Me.colBillAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colBillAmount.FieldName = "BillAmount"
        Me.colBillAmount.Name = "colBillAmount"
        Me.colBillAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBillAmount.Visible = True
        Me.colBillAmount.VisibleIndex = 2
        Me.colBillAmount.Width = 119
        '
        'colRealisedAmount
        '
        Me.colRealisedAmount.DisplayFormat.FormatString = "##,##.00"
        Me.colRealisedAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colRealisedAmount.FieldName = "RealisedAmount"
        Me.colRealisedAmount.Name = "colRealisedAmount"
        Me.colRealisedAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colRealisedAmount.Visible = True
        Me.colRealisedAmount.VisibleIndex = 3
        Me.colRealisedAmount.Width = 124
        '
        'colRealisedDate
        '
        Me.colRealisedDate.FieldName = "RealisedDate"
        Me.colRealisedDate.Name = "colRealisedDate"
        Me.colRealisedDate.Visible = True
        Me.colRealisedDate.VisibleIndex = 4
        Me.colRealisedDate.Width = 123
        '
        'colNegociateAmount
        '
        Me.colNegociateAmount.FieldName = "NegociateAmount"
        Me.colNegociateAmount.Name = "colNegociateAmount"
        Me.colNegociateAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colNegociateAmount.Width = 105
        '
        'colRemarks2
        '
        Me.colRemarks2.FieldName = "Remarks"
        Me.colRemarks2.Name = "colRemarks2"
        Me.colRemarks2.Visible = True
        Me.colRemarks2.VisibleIndex = 18
        Me.colRemarks2.Width = 353
        '
        'colCD4354
        '
        Me.colCD4354.Caption = "CD"
        Me.colCD4354.DisplayFormat.FormatString = "##,##.00"
        Me.colCD4354.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colCD4354.FieldName = "CD4354"
        Me.colCD4354.Name = "colCD4354"
        Me.colCD4354.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colCD4354.Visible = True
        Me.colCD4354.VisibleIndex = 16
        '
        'colDFCDeposit
        '
        Me.colDFCDeposit.Caption = "DFC/FBPAR"
        Me.colDFCDeposit.DisplayFormat.FormatString = "##,##.00"
        Me.colDFCDeposit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colDFCDeposit.FieldName = "DFCDeposit"
        Me.colDFCDeposit.Name = "colDFCDeposit"
        Me.colDFCDeposit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colDFCDeposit.Visible = True
        Me.colDFCDeposit.VisibleIndex = 5
        Me.colDFCDeposit.Width = 85
        '
        'colECC
        '
        Me.colECC.Caption = "ECC/OD"
        Me.colECC.DisplayFormat.FormatString = "##,##.00"
        Me.colECC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colECC.FieldName = "ECC"
        Me.colECC.Name = "colECC"
        Me.colECC.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colECC.Visible = True
        Me.colECC.VisibleIndex = 9
        '
        'colFACommission1
        '
        Me.colFACommission1.DisplayFormat.FormatString = "##,##.00"
        Me.colFACommission1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFACommission1.FieldName = "FACommission"
        Me.colFACommission1.Name = "colFACommission1"
        Me.colFACommission1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFACommission1.Width = 99
        '
        'colFCAmount
        '
        Me.colFCAmount.DisplayFormat.FormatString = "##,##.00"
        Me.colFCAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFCAmount.FieldName = "FCAmount"
        Me.colFCAmount.Name = "colFCAmount"
        Me.colFCAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFCAmount.Visible = True
        Me.colFCAmount.VisibleIndex = 12
        '
        'colFDBP
        '
        Me.colFDBP.DisplayFormat.FormatString = "##,##.00"
        Me.colFDBP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFDBP.FieldName = "FDBP"
        Me.colFDBP.Name = "colFDBP"
        Me.colFDBP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colFDBP.Visible = True
        Me.colFDBP.VisibleIndex = 8
        '
        'colHC
        '
        Me.colHC.DisplayFormat.FormatString = "##,##.00"
        Me.colHC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colHC.FieldName = "HC"
        Me.colHC.Name = "colHC"
        Me.colHC.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colHC.Visible = True
        Me.colHC.VisibleIndex = 15
        '
        'colLACommission1
        '
        Me.colLACommission1.DisplayFormat.FormatString = "##,##.00"
        Me.colLACommission1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colLACommission1.FieldName = "LACommission"
        Me.colLACommission1.Name = "colLACommission1"
        Me.colLACommission1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colLACommission1.Visible = True
        Me.colLACommission1.VisibleIndex = 7
        Me.colLACommission1.Width = 96
        '
        'colMarginFDocs
        '
        Me.colMarginFDocs.DisplayFormat.FormatString = "##,##.00"
        Me.colMarginFDocs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colMarginFDocs.FieldName = "MarginFDocs"
        Me.colMarginFDocs.Name = "colMarginFDocs"
        Me.colMarginFDocs.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colMarginFDocs.Visible = True
        Me.colMarginFDocs.VisibleIndex = 14
        '
        'colODInterest
        '
        Me.colODInterest.DisplayFormat.FormatString = "##,##.00"
        Me.colODInterest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colODInterest.FieldName = "ODInterest"
        Me.colODInterest.Name = "colODInterest"
        Me.colODInterest.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colODInterest.Visible = True
        Me.colODInterest.VisibleIndex = 10
        '
        'colCCH
        '
        Me.colCCH.Caption = "CCH(2%)"
        Me.colCCH.DisplayFormat.FormatString = "##,##.00"
        Me.colCCH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colCCH.FieldName = "CCH"
        Me.colCCH.Name = "colCCH"
        Me.colCCH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colCCH.Visible = True
        Me.colCCH.VisibleIndex = 11
        '
        'colSalesTax
        '
        Me.colSalesTax.Caption = "STax(6%)"
        Me.colSalesTax.DisplayFormat.FormatString = "##,##.00"
        Me.colSalesTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSalesTax.FieldName = "SalesTax"
        Me.colSalesTax.Name = "colSalesTax"
        Me.colSalesTax.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colSalesTax.Visible = True
        Me.colSalesTax.VisibleIndex = 13
        '
        'colPC
        '
        Me.colPC.DisplayFormat.FormatString = "##,##.00"
        Me.colPC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colPC.FieldName = "PC"
        Me.colPC.Name = "colPC"
        Me.colPC.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPC.Visible = True
        Me.colPC.VisibleIndex = 6
        '
        'colPostage
        '
        Me.colPostage.FieldName = "Postage"
        Me.colPostage.Name = "colPostage"
        Me.colPostage.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPostage.Visible = True
        Me.colPostage.VisibleIndex = 17
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.TTMasterGridControl)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1356, 310)
        Me.XtraTabPage3.Text = "TT Details"
        '
        'TTMasterGridControl
        '
        Me.TTMasterGridControl.DataSource = Me.TTMasterBindingSource
        Me.TTMasterGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TTMasterGridControl.Location = New System.Drawing.Point(0, 0)
        Me.TTMasterGridControl.MainView = Me.GridView5
        Me.TTMasterGridControl.Name = "TTMasterGridControl"
        Me.TTMasterGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.TTSupplierGridLookUpEdit})
        Me.TTMasterGridControl.Size = New System.Drawing.Size(1356, 310)
        Me.TTMasterGridControl.TabIndex = 0
        Me.TTMasterGridControl.UseEmbeddedNavigator = True
        Me.TTMasterGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'TTMasterBindingSource
        '
        Me.TTMasterBindingSource.DataMember = "FK_TTMaster_MasterLC"
        Me.TTMasterBindingSource.DataSource = Me.MasterLCBindingSource
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTTNo, Me.colTTDate, Me.colSupplierId1, Me.colAmountUSD1, Me.colRemarks3})
        Me.GridView5.GridControl = Me.TTMasterGridControl
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colTTNo
        '
        Me.colTTNo.FieldName = "TTNo"
        Me.colTTNo.Name = "colTTNo"
        Me.colTTNo.Visible = True
        Me.colTTNo.VisibleIndex = 0
        Me.colTTNo.Width = 136
        '
        'colTTDate
        '
        Me.colTTDate.FieldName = "TTDate"
        Me.colTTDate.Name = "colTTDate"
        Me.colTTDate.Visible = True
        Me.colTTDate.VisibleIndex = 1
        Me.colTTDate.Width = 149
        '
        'colSupplierId1
        '
        Me.colSupplierId1.Caption = "Supplier"
        Me.colSupplierId1.ColumnEdit = Me.TTSupplierGridLookUpEdit
        Me.colSupplierId1.FieldName = "SupplierId"
        Me.colSupplierId1.Name = "colSupplierId1"
        Me.colSupplierId1.Visible = True
        Me.colSupplierId1.VisibleIndex = 2
        Me.colSupplierId1.Width = 226
        '
        'TTSupplierGridLookUpEdit
        '
        Me.TTSupplierGridLookUpEdit.AutoHeight = False
        Me.TTSupplierGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TTSupplierGridLookUpEdit.DataSource = Me.SupplierBindingSource
        Me.TTSupplierGridLookUpEdit.DisplayMember = "SupplierName"
        Me.TTSupplierGridLookUpEdit.Name = "TTSupplierGridLookUpEdit"
        Me.TTSupplierGridLookUpEdit.NullText = ""
        Me.TTSupplierGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TTSupplierGridLookUpEdit.ValueMember = "SupplierId"
        Me.TTSupplierGridLookUpEdit.View = Me.GridView7
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierName1})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colSupplierName1
        '
        Me.colSupplierName1.FieldName = "SupplierName"
        Me.colSupplierName1.Name = "colSupplierName1"
        Me.colSupplierName1.Visible = True
        Me.colSupplierName1.VisibleIndex = 0
        '
        'colAmountUSD1
        '
        Me.colAmountUSD1.FieldName = "AmountUSD"
        Me.colAmountUSD1.Name = "colAmountUSD1"
        Me.colAmountUSD1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colAmountUSD1.Visible = True
        Me.colAmountUSD1.VisibleIndex = 3
        Me.colAmountUSD1.Width = 153
        '
        'colRemarks3
        '
        Me.colRemarks3.FieldName = "Remarks"
        Me.colRemarks3.Name = "colRemarks3"
        Me.colRemarks3.Visible = True
        Me.colRemarks3.VisibleIndex = 4
        Me.colRemarks3.Width = 504
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.PackingCreditGridControl)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1356, 310)
        Me.XtraTabPage4.Text = "PC Details"
        '
        'PackingCreditGridControl
        '
        Me.PackingCreditGridControl.DataSource = Me.PackingCreditBindingSource
        Me.PackingCreditGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PackingCreditGridControl.Location = New System.Drawing.Point(0, 0)
        Me.PackingCreditGridControl.MainView = Me.GridView1
        Me.PackingCreditGridControl.Name = "PackingCreditGridControl"
        Me.PackingCreditGridControl.Size = New System.Drawing.Size(1356, 310)
        Me.PackingCreditGridControl.TabIndex = 0
        Me.PackingCreditGridControl.UseEmbeddedNavigator = True
        Me.PackingCreditGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PackingCreditBindingSource
        '
        Me.PackingCreditBindingSource.DataMember = "FK_PackingCredit_MasterLC"
        Me.PackingCreditBindingSource.DataSource = Me.MasterLCBindingSource
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTransactionDate, Me.colDescription, Me.colChequeNo, Me.colWithdrawal, Me.colRemarks4})
        Me.GridView1.GridControl = Me.PackingCreditGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colTransactionDate
        '
        Me.colTransactionDate.FieldName = "TransactionDate"
        Me.colTransactionDate.Name = "colTransactionDate"
        Me.colTransactionDate.Visible = True
        Me.colTransactionDate.VisibleIndex = 0
        Me.colTransactionDate.Width = 123
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 245
        '
        'colChequeNo
        '
        Me.colChequeNo.FieldName = "ChequeNo"
        Me.colChequeNo.Name = "colChequeNo"
        Me.colChequeNo.Visible = True
        Me.colChequeNo.VisibleIndex = 2
        Me.colChequeNo.Width = 128
        '
        'colWithdrawal
        '
        Me.colWithdrawal.FieldName = "Withdrawal"
        Me.colWithdrawal.Name = "colWithdrawal"
        Me.colWithdrawal.Visible = True
        Me.colWithdrawal.VisibleIndex = 3
        Me.colWithdrawal.Width = 107
        '
        'colRemarks4
        '
        Me.colRemarks4.FieldName = "Remarks"
        Me.colRemarks4.Name = "colRemarks4"
        Me.colRemarks4.Visible = True
        Me.colRemarks4.VisibleIndex = 4
        Me.colRemarks4.Width = 427
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
        'MasterLCTableAdapter
        '
        Me.MasterLCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BTBLCTableAdapter = Me.BTBLCTableAdapter
        Me.TableAdapterManager.ExportBillTableAdapter = Me.ExportBillTableAdapter
        Me.TableAdapterManager.MasterLCLookupTableAdapter = Nothing
        Me.TableAdapterManager.MasterLCTableAdapter = Me.MasterLCTableAdapter
        Me.TableAdapterManager.PackingCreditTableAdapter = Nothing
        Me.TableAdapterManager.TTMasterTableAdapter = Me.TTMasterTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.MasterLCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BTBLCTableAdapter
        '
        Me.BTBLCTableAdapter.ClearBeforeFill = True
        '
        'ExportBillTableAdapter
        '
        Me.ExportBillTableAdapter.ClearBeforeFill = True
        '
        'TTMasterTableAdapter
        '
        Me.TTMasterTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
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
        'Buyer2TableAdapter
        '
        Me.Buyer2TableAdapter.ClearBeforeFill = True
        '
        'MasterLCLookupTableAdapter
        '
        Me.MasterLCLookupTableAdapter.ClearBeforeFill = True
        '
        'colRefAndMLCNo
        '
        Me.colRefAndMLCNo.FieldName = "RefAndMLCNo"
        Me.colRefAndMLCNo.Name = "colRefAndMLCNo"
        Me.colRefAndMLCNo.Visible = True
        Me.colRefAndMLCNo.VisibleIndex = 0
        '
        'colRefAndMLCNo1
        '
        Me.colRefAndMLCNo1.FieldName = "RefAndMLCNo"
        Me.colRefAndMLCNo1.Name = "colRefAndMLCNo1"
        Me.colRefAndMLCNo1.Visible = True
        Me.colRefAndMLCNo1.VisibleIndex = 0
        '
        'B2BLookupTableAdapter
        '
        Me.B2BLookupTableAdapter.ClearBeforeFill = True
        '
        'PackingCreditTableAdapter
        '
        Me.PackingCreditTableAdapter.ClearBeforeFill = True
        '
        'BankAccountTableAdapter
        '
        Me.BankAccountTableAdapter.ClearBeforeFill = True
        '
        'frmMasterLC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 677)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmMasterLC"
        Me.Text = "Master LC"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.B2BLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.B2BLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLCLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLCGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buyer2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buyer2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankAccountGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankAccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankAccountDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBankAccountGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.BTBLCGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTBLCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialTypeComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTBTypeComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.ExportBillGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportBillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.TTMasterGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TTSupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.PackingCreditGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackingCreditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MasterLCDataSet As KSoft_Apparel.MasterLCDataSet
    Friend WithEvents MasterLCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterLCTableAdapter As KSoft_Apparel.MasterLCDataSetTableAdapters.MasterLCTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.MasterLCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MasterLCGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BTBLCTableAdapter As KSoft_Apparel.MasterLCDataSetTableAdapters.BTBLCTableAdapter
    Friend WithEvents BTBLCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BTBLCGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBTBLCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBTBLCDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmountUSD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmountBDT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIFDBC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExportBillTableAdapter As KSoft_Apparel.MasterLCDataSetTableAdapters.ExportBillTableAdapter
    Friend WithEvents ExportBillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportBillGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBillNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealisedAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealisedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNegociateAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TTMasterTableAdapter As KSoft_Apparel.MasterLCDataSetTableAdapters.TTMasterTableAdapter
    Friend WithEvents TTMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TTMasterGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTTNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmountUSD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents SupplierGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MaterialTypeComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents TTSupplierGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents colMLCNO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMLCDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMLCValue As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMLCQuantity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFACommission As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLACommission As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFreight As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFOBValue As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBTBOpen As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBTBAlreadyOpen As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBTBBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBillSubmited As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBTBOpenBDT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBTBAlreadyOpenBDT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBTBBalanceBDT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDollarRate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBTBOpenPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBTBAlreadyOpenPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTTAmountPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFACommissionPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLACommissionPercentage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMerchandiserReferenceNo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCD4354 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFCDeposit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colECC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFACommission1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFCAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFDBP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLACommission1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMarginFDocs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colODInterest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Buyer2DataSet As KSoft_Apparel.Buyer2DataSet
    Friend WithEvents Buyer2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Buyer2TableAdapter As KSoft_Apparel.Buyer2DataSetTableAdapters.Buyer2TableAdapter
    Friend WithEvents colBuyer2Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDFC_FBPARAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDFC_FBPARBalance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDollarRate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCCH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesTax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents ShowAllButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents MasterLCLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterLCLookupTableAdapter As KSoft_Apparel.MasterLCDataSetTableAdapters.MasterLCLookupTableAdapter
    Friend WithEvents colRefAndMLCNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRefAndMLCNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents colBTBType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BTBTypeComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colACADay As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIncentiveAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colACADate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colACARealizedDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colRefAndMLCNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowByButton As System.Windows.Forms.Button
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents B2BLookupDataSet As KSoft_Apparel.B2BLookupDataSet
    Friend WithEvents B2BLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents B2BLookupTableAdapter As KSoft_Apparel.B2BLookupDataSetTableAdapters.B2BLookupTableAdapter
    Friend WithEvents colBTBLCNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBTBLCDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PackingCreditBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PackingCreditTableAdapter As KSoft_Apparel.MasterLCDataSetTableAdapters.PackingCreditTableAdapter
    Friend WithEvents PackingCreditGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChequeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWithdrawal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccountId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPCAmountBDT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPCBalanceBDT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPCDepositBDT As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BankAccountGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BankAccountDataSet As KSoft_Apparel.BankAccountDataSet
    Friend WithEvents BankAccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BankAccountTableAdapter As KSoft_Apparel.BankAccountDataSetTableAdapters.BankAccountTableAdapter
    Friend WithEvents colAccountNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BTBBDT As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPCBankAccountId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents PCBankAccountGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccountNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankCode1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
