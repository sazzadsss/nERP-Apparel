<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFabricBooking_Sample
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
        Dim BookingNoLabel As System.Windows.Forms.Label
        Dim RevisedNoLabel As System.Windows.Forms.Label
        Dim RevisedDateLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim FabricRequireDateLabel As System.Windows.Forms.Label
        Dim SampleRequestIdLabel As System.Windows.Forms.Label
        Dim FabricBookingDateLabel As System.Windows.Forms.Label
        Dim AttentionLabel As System.Windows.Forms.Label
        Dim CCLabel As System.Windows.Forms.Label
        Dim CauseOfRevisedLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFabricBooking_Sample))
        Me.SampleFabricBookingDataSet = New KSoft_Apparel.SampleFabricBookingDataSet()
        Me.SampleFabricBookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleFabricBookingTableAdapter = New KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricBookingTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.TableAdapterManager()
        Me.SampleFabricBookingRevisedHistoryTableAdapter = New KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricBookingRevisedHistoryTableAdapter()
        Me.SampleFabricTableAdapter = New KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricTableAdapter()
        Me.YarnAllocationSampleTableAdapter = New KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.YarnAllocationSampleTableAdapter()
        Me.SampleFabricBookingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SampleRequestNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestDataSet = New KSoft_Apparel.SampleRequestDataSet()
        Me.SampleRequestNoLookupTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestNoLookupTableAdapter()
        Me.BookingNoTextBox = New System.Windows.Forms.TextBox()
        Me.RevisedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.FabricRequireDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IsReceivedCheckBox = New System.Windows.Forms.CheckBox()
        Me.IsCompleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.SampleRequestIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SampleRequestIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SRLookupByDivUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestLookupDataSet = New KSoft_Apparel.SampleRequestLookupDataSet()
        Me.SRLookupByDivUserAndSFBPendingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleFabricBookingRevisedHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleFabricBookingRevisedHistoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRevisedNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRevisedDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCasuseOfRevised = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RevisedNoNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.RevisedButton = New System.Windows.Forms.Button()
        Me.FabricBookingDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SampleFabricBookingLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleFabricBookingLookupDataSet = New KSoft_Apparel.SampleFabricBookingLookupDataSet()
        Me.SampleFabricBookingLookupTableAdapter = New KSoft_Apparel.SampleFabricBookingLookupDataSetTableAdapters.SampleFabricBookingLookupTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SFBLookupByDivUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricBookingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SampleFabricBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleFabricGridControl = New DevExpress.XtraGrid.GridControl()
        Me.SampleFabricGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colELD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGarmentsPartId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PartGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GarmentsPartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GarmentsPartDataSet = New KSoft_Apparel.GarmentsPartDataSet()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKnittingTypeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KnittingTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKnittingType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompositionId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompositionGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colComposition1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFGSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiaType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DiaTypeComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colFinishUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colBookingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSPNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsumption = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGreyPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGreyQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKgPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsFabricAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricColorGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter()
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter()
        Me.GSMDataSet = New KSoft_Apparel.GSMDataSet()
        Me.GSMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSMTableAdapter = New KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter()
        Me.GarmentsPartTableAdapter = New KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter()
        Me.colKnittingType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComposition = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompletedOnDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AttentionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CCTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompletedByGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompletedByGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.CauseOfRevisedTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.YarnAllocationSampleGridControl = New DevExpress.XtraGrid.GridControl()
        Me.YarnAllocationSampleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.SRLookupByDivUserAndSFBPendingTableAdapter = New KSoft_Apparel.SampleRequestLookupDataSetTableAdapters.SRLookupByDivUserAndSFBPendingTableAdapter()
        Me.SFBLookupByDivUserTableAdapter = New KSoft_Apparel.SampleFabricBookingLookupDataSetTableAdapters.SFBLookupByDivUserTableAdapter()
        Me.SRLookupByDivUserTableAdapter = New KSoft_Apparel.SampleRequestLookupDataSetTableAdapters.SRLookupByDivUserTableAdapter()
        Me.CopyFabricButton = New System.Windows.Forms.Button()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.ProceedForKnittingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ProceedForDyeingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        BookingNoLabel = New System.Windows.Forms.Label()
        RevisedNoLabel = New System.Windows.Forms.Label()
        RevisedDateLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        FabricRequireDateLabel = New System.Windows.Forms.Label()
        SampleRequestIdLabel = New System.Windows.Forms.Label()
        FabricBookingDateLabel = New System.Windows.Forms.Label()
        AttentionLabel = New System.Windows.Forms.Label()
        CCLabel = New System.Windows.Forms.Label()
        CauseOfRevisedLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.SampleFabricBookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBookingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SampleFabricBookingBindingNavigator.SuspendLayout()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRLookupByDivUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRLookupByDivUserAndSFBPendingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBookingRevisedHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBookingRevisedHistoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RevisedNoNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBookingLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SFBLookupByDivUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaTypeComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompletedOnDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompletedOnDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompletedByGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompletedByGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CauseOfRevisedTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.YarnAllocationSampleGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YarnAllocationSampleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProceedForKnittingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProceedForDyeingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookingNoLabel
        '
        BookingNoLabel.AutoSize = True
        BookingNoLabel.Location = New System.Drawing.Point(30, 56)
        BookingNoLabel.Name = "BookingNoLabel"
        BookingNoLabel.Size = New System.Drawing.Size(66, 13)
        BookingNoLabel.TabIndex = 2
        BookingNoLabel.Text = "Booking No:"
        '
        'RevisedNoLabel
        '
        RevisedNoLabel.AutoSize = True
        RevisedNoLabel.Location = New System.Drawing.Point(266, 54)
        RevisedNoLabel.Name = "RevisedNoLabel"
        RevisedNoLabel.Size = New System.Drawing.Size(66, 13)
        RevisedNoLabel.TabIndex = 4
        RevisedNoLabel.Text = "Revised No:"
        '
        'RevisedDateLabel
        '
        RevisedDateLabel.AutoSize = True
        RevisedDateLabel.Location = New System.Drawing.Point(266, 79)
        RevisedDateLabel.Name = "RevisedDateLabel"
        RevisedDateLabel.Size = New System.Drawing.Size(75, 13)
        RevisedDateLabel.TabIndex = 6
        RevisedDateLabel.Text = "Revised Date:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(29, 126)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 8
        RemarksLabel.Text = "Remarks:"
        '
        'FabricRequireDateLabel
        '
        FabricRequireDateLabel.AutoSize = True
        FabricRequireDateLabel.Location = New System.Drawing.Point(265, 103)
        FabricRequireDateLabel.Name = "FabricRequireDateLabel"
        FabricRequireDateLabel.Size = New System.Drawing.Size(73, 13)
        FabricRequireDateLabel.TabIndex = 10
        FabricRequireDateLabel.Text = "Require Date:"
        '
        'SampleRequestIdLabel
        '
        SampleRequestIdLabel.AutoSize = True
        SampleRequestIdLabel.Location = New System.Drawing.Point(29, 170)
        SampleRequestIdLabel.Name = "SampleRequestIdLabel"
        SampleRequestIdLabel.Size = New System.Drawing.Size(104, 13)
        SampleRequestIdLabel.TabIndex = 15
        SampleRequestIdLabel.Text = "Sample Program No:"
        '
        'FabricBookingDateLabel
        '
        FabricBookingDateLabel.AutoSize = True
        FabricBookingDateLabel.Location = New System.Drawing.Point(30, 105)
        FabricBookingDateLabel.Name = "FabricBookingDateLabel"
        FabricBookingDateLabel.Size = New System.Drawing.Size(75, 13)
        FabricBookingDateLabel.TabIndex = 18
        FabricBookingDateLabel.Text = "Booking Date:"
        '
        'AttentionLabel
        '
        AttentionLabel.AutoSize = True
        AttentionLabel.Location = New System.Drawing.Point(30, 194)
        AttentionLabel.Name = "AttentionLabel"
        AttentionLabel.Size = New System.Drawing.Size(52, 13)
        AttentionLabel.TabIndex = 60
        AttentionLabel.Text = "Attention:"
        '
        'CCLabel
        '
        CCLabel.AutoSize = True
        CCLabel.Location = New System.Drawing.Point(267, 194)
        CCLabel.Name = "CCLabel"
        CCLabel.Size = New System.Drawing.Size(24, 13)
        CCLabel.TabIndex = 61
        CCLabel.Text = "CC:"
        '
        'CauseOfRevisedLabel
        '
        CauseOfRevisedLabel.AutoSize = True
        CauseOfRevisedLabel.Location = New System.Drawing.Point(502, 53)
        CauseOfRevisedLabel.Name = "CauseOfRevisedLabel"
        CauseOfRevisedLabel.Size = New System.Drawing.Size(89, 13)
        CauseOfRevisedLabel.TabIndex = 62
        CauseOfRevisedLabel.Text = "Cause of revised:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(29, 79)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(103, 13)
        Label1.TabIndex = 61
        Label1.Text = "Booking Start Date :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(681, 53)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(96, 13)
        Label3.TabIndex = 62
        Label3.Text = "History of Revised:"
        '
        'SampleFabricBookingDataSet
        '
        Me.SampleFabricBookingDataSet.DataSetName = "SampleFabricBookingDataSet"
        Me.SampleFabricBookingDataSet.EnforceConstraints = False
        Me.SampleFabricBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SampleFabricBookingBindingSource
        '
        Me.SampleFabricBookingBindingSource.DataMember = "SampleFabricBooking"
        Me.SampleFabricBookingBindingSource.DataSource = Me.SampleFabricBookingDataSet
        '
        'SampleFabricBookingTableAdapter
        '
        Me.SampleFabricBookingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SampleFabricBookingRevisedHistoryTableAdapter = Me.SampleFabricBookingRevisedHistoryTableAdapter
        Me.TableAdapterManager.SampleFabricBookingTableAdapter = Me.SampleFabricBookingTableAdapter
        Me.TableAdapterManager.SampleFabricTableAdapter = Me.SampleFabricTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YarnAllocationSampleTableAdapter = Me.YarnAllocationSampleTableAdapter
        '
        'SampleFabricBookingRevisedHistoryTableAdapter
        '
        Me.SampleFabricBookingRevisedHistoryTableAdapter.ClearBeforeFill = True
        '
        'SampleFabricTableAdapter
        '
        Me.SampleFabricTableAdapter.ClearBeforeFill = True
        '
        'YarnAllocationSampleTableAdapter
        '
        Me.YarnAllocationSampleTableAdapter.ClearBeforeFill = True
        '
        'SampleFabricBookingBindingNavigator
        '
        Me.SampleFabricBookingBindingNavigator.AddNewItem = Nothing
        Me.SampleFabricBookingBindingNavigator.BindingSource = Me.SampleFabricBookingBindingSource
        Me.SampleFabricBookingBindingNavigator.CountItem = Nothing
        Me.SampleFabricBookingBindingNavigator.DeleteItem = Nothing
        Me.SampleFabricBookingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.EditToolStripButton, Me.BindingNavigatorDeleteItem, Me.CancelToolStripButton, Me.PrintToolStripButton})
        Me.SampleFabricBookingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SampleFabricBookingBindingNavigator.MoveFirstItem = Nothing
        Me.SampleFabricBookingBindingNavigator.MoveLastItem = Nothing
        Me.SampleFabricBookingBindingNavigator.MoveNextItem = Nothing
        Me.SampleFabricBookingBindingNavigator.MovePreviousItem = Nothing
        Me.SampleFabricBookingBindingNavigator.Name = "SampleFabricBookingBindingNavigator"
        Me.SampleFabricBookingBindingNavigator.PositionItem = Nothing
        Me.SampleFabricBookingBindingNavigator.Size = New System.Drawing.Size(1354, 43)
        Me.SampleFabricBookingBindingNavigator.TabIndex = 0
        Me.SampleFabricBookingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.Padding = New System.Windows.Forms.Padding(10)
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 40)
        Me.BindingNavigatorAddNewItem.Text = "Add"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.Image = CType(resources.GetObject("EditToolStripButton.Image"), System.Drawing.Image)
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Padding = New System.Windows.Forms.Padding(10)
        Me.EditToolStripButton.Size = New System.Drawing.Size(67, 40)
        Me.EditToolStripButton.Text = "Edit"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.Padding = New System.Windows.Forms.Padding(10)
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(80, 40)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CancelToolStripButton
        '
        Me.CancelToolStripButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Button_Refresh_icon
        Me.CancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelToolStripButton.Name = "CancelToolStripButton"
        Me.CancelToolStripButton.Padding = New System.Windows.Forms.Padding(10)
        Me.CancelToolStripButton.Size = New System.Drawing.Size(83, 40)
        Me.CancelToolStripButton.Text = "Cancel"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Print
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Padding = New System.Windows.Forms.Padding(10)
        Me.PrintToolStripButton.Size = New System.Drawing.Size(72, 40)
        Me.PrintToolStripButton.Text = "Print"
        '
        'SampleRequestNoLookupBindingSource
        '
        Me.SampleRequestNoLookupBindingSource.DataMember = "SampleRequestNoLookup"
        Me.SampleRequestNoLookupBindingSource.DataSource = Me.SampleRequestDataSet
        '
        'SampleRequestDataSet
        '
        Me.SampleRequestDataSet.DataSetName = "SampleRequestDataSet"
        Me.SampleRequestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SampleRequestNoLookupTableAdapter
        '
        Me.SampleRequestNoLookupTableAdapter.ClearBeforeFill = True
        '
        'BookingNoTextBox
        '
        Me.BookingNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SampleFabricBookingBindingSource, "BookingNo", True))
        Me.BookingNoTextBox.Location = New System.Drawing.Point(138, 51)
        Me.BookingNoTextBox.Name = "BookingNoTextBox"
        Me.BookingNoTextBox.ReadOnly = True
        Me.BookingNoTextBox.Size = New System.Drawing.Size(123, 20)
        Me.BookingNoTextBox.TabIndex = 3
        '
        'RevisedDateDateTimePicker
        '
        Me.RevisedDateDateTimePicker.CustomFormat = "dd-MMM-yy HH:mm"
        Me.RevisedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SampleFabricBookingBindingSource, "RevisedDate", True))
        Me.RevisedDateDateTimePicker.Enabled = False
        Me.RevisedDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RevisedDateDateTimePicker.Location = New System.Drawing.Point(344, 76)
        Me.RevisedDateDateTimePicker.Name = "RevisedDateDateTimePicker"
        Me.RevisedDateDateTimePicker.Size = New System.Drawing.Size(145, 20)
        Me.RevisedDateDateTimePicker.TabIndex = 7
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SampleFabricBookingBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(138, 123)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(351, 38)
        Me.RemarksTextBox.TabIndex = 9
        '
        'FabricRequireDateDateTimePicker
        '
        Me.FabricRequireDateDateTimePicker.CustomFormat = "dd-MMM-yy HH:mm"
        Me.FabricRequireDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SampleFabricBookingBindingSource, "FabricRequireDate", True))
        Me.FabricRequireDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FabricRequireDateDateTimePicker.Location = New System.Drawing.Point(344, 99)
        Me.FabricRequireDateDateTimePicker.Name = "FabricRequireDateDateTimePicker"
        Me.FabricRequireDateDateTimePicker.Size = New System.Drawing.Size(145, 20)
        Me.FabricRequireDateDateTimePicker.TabIndex = 11
        '
        'IsReceivedCheckBox
        '
        Me.IsReceivedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SampleFabricBookingBindingSource, "IsReceived", True))
        Me.IsReceivedCheckBox.Enabled = False
        Me.IsReceivedCheckBox.Location = New System.Drawing.Point(344, 217)
        Me.IsReceivedCheckBox.Name = "IsReceivedCheckBox"
        Me.IsReceivedCheckBox.Size = New System.Drawing.Size(145, 20)
        Me.IsReceivedCheckBox.TabIndex = 13
        Me.IsReceivedCheckBox.Text = "Received by Fabric Department"
        Me.IsReceivedCheckBox.UseVisualStyleBackColor = True
        '
        'IsCompleteCheckBox
        '
        Me.IsCompleteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SampleFabricBookingBindingSource, "IsComplete", True))
        Me.IsCompleteCheckBox.Location = New System.Drawing.Point(32, 217)
        Me.IsCompleteCheckBox.Name = "IsCompleteCheckBox"
        Me.IsCompleteCheckBox.Size = New System.Drawing.Size(75, 19)
        Me.IsCompleteCheckBox.TabIndex = 15
        Me.IsCompleteCheckBox.Text = "&Proceed"
        Me.IsCompleteCheckBox.UseVisualStyleBackColor = True
        '
        'SampleRequestIdGridLookUpEditView
        '
        Me.SampleRequestIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails, Me.colRequestDate})
        Me.SampleRequestIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SampleRequestIdGridLookUpEditView.Name = "SampleRequestIdGridLookUpEditView"
        Me.SampleRequestIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SampleRequestIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
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
        'SampleRequestIdGridLookUpEdit
        '
        Me.SampleRequestIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleFabricBookingBindingSource, "SampleRequestId", True))
        Me.SampleRequestIdGridLookUpEdit.EditValue = ""
        Me.SampleRequestIdGridLookUpEdit.Location = New System.Drawing.Point(138, 167)
        Me.SampleRequestIdGridLookUpEdit.Name = "SampleRequestIdGridLookUpEdit"
        Me.SampleRequestIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SampleRequestIdGridLookUpEdit.Properties.DataSource = Me.SRLookupByDivUserBindingSource
        Me.SampleRequestIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.SampleRequestIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SampleRequestIdGridLookUpEdit.Properties.NullText = "[Sample Request No]"
        Me.SampleRequestIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SampleRequestIdGridLookUpEdit.Properties.PopupView = Me.SampleRequestIdGridLookUpEditView
        Me.SampleRequestIdGridLookUpEdit.Properties.ReadOnly = True
        Me.SampleRequestIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SampleRequestIdGridLookUpEdit.Properties.ValueMember = "SampleRequestId"
        Me.SampleRequestIdGridLookUpEdit.Size = New System.Drawing.Size(351, 20)
        Me.SampleRequestIdGridLookUpEdit.TabIndex = 16
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
        'SRLookupByDivUserAndSFBPendingBindingSource
        '
        Me.SRLookupByDivUserAndSFBPendingBindingSource.DataMember = "SRLookupByDivUserAndSFBPending"
        Me.SRLookupByDivUserAndSFBPendingBindingSource.DataSource = Me.SampleRequestLookupDataSet
        '
        'SampleFabricBookingRevisedHistoryBindingSource
        '
        Me.SampleFabricBookingRevisedHistoryBindingSource.DataMember = "FK_SampleFabricBookingRevisedHistory_SampleFabricBooking"
        Me.SampleFabricBookingRevisedHistoryBindingSource.DataSource = Me.SampleFabricBookingBindingSource
        '
        'SampleFabricBookingRevisedHistoryGridControl
        '
        Me.SampleFabricBookingRevisedHistoryGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleFabricBookingRevisedHistoryGridControl.DataSource = Me.SampleFabricBookingRevisedHistoryBindingSource
        Me.SampleFabricBookingRevisedHistoryGridControl.Location = New System.Drawing.Point(684, 77)
        Me.SampleFabricBookingRevisedHistoryGridControl.MainView = Me.GridView2
        Me.SampleFabricBookingRevisedHistoryGridControl.Name = "SampleFabricBookingRevisedHistoryGridControl"
        Me.SampleFabricBookingRevisedHistoryGridControl.Size = New System.Drawing.Size(658, 137)
        Me.SampleFabricBookingRevisedHistoryGridControl.TabIndex = 16
        Me.SampleFabricBookingRevisedHistoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRevisedNo1, Me.colRevisedDate1, Me.colCasuseOfRevised})
        Me.GridView2.GridControl = Me.SampleFabricBookingRevisedHistoryGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colRevisedNo1
        '
        Me.colRevisedNo1.FieldName = "RevisedNo"
        Me.colRevisedNo1.Name = "colRevisedNo1"
        Me.colRevisedNo1.Visible = True
        Me.colRevisedNo1.VisibleIndex = 0
        '
        'colRevisedDate1
        '
        Me.colRevisedDate1.FieldName = "RevisedDate"
        Me.colRevisedDate1.Name = "colRevisedDate1"
        Me.colRevisedDate1.Visible = True
        Me.colRevisedDate1.VisibleIndex = 1
        Me.colRevisedDate1.Width = 94
        '
        'colCasuseOfRevised
        '
        Me.colCasuseOfRevised.FieldName = "CasuseOfRevised"
        Me.colCasuseOfRevised.Name = "colCasuseOfRevised"
        Me.colCasuseOfRevised.Visible = True
        Me.colCasuseOfRevised.VisibleIndex = 2
        Me.colCasuseOfRevised.Width = 262
        '
        'RevisedNoNumericUpDown
        '
        Me.RevisedNoNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SampleFabricBookingBindingSource, "RevisedNo", True))
        Me.RevisedNoNumericUpDown.Location = New System.Drawing.Point(344, 51)
        Me.RevisedNoNumericUpDown.Name = "RevisedNoNumericUpDown"
        Me.RevisedNoNumericUpDown.ReadOnly = True
        Me.RevisedNoNumericUpDown.Size = New System.Drawing.Size(80, 20)
        Me.RevisedNoNumericUpDown.TabIndex = 17
        '
        'RevisedButton
        '
        Me.RevisedButton.Location = New System.Drawing.Point(430, 49)
        Me.RevisedButton.Name = "RevisedButton"
        Me.RevisedButton.Size = New System.Drawing.Size(59, 23)
        Me.RevisedButton.TabIndex = 18
        Me.RevisedButton.Text = "Revised"
        Me.RevisedButton.UseVisualStyleBackColor = True
        '
        'FabricBookingDateDateTimePicker
        '
        Me.FabricBookingDateDateTimePicker.CustomFormat = "dd-MMM-yy HH:mm"
        Me.FabricBookingDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SampleFabricBookingBindingSource, "FabricBookingDate", True))
        Me.FabricBookingDateDateTimePicker.Enabled = False
        Me.FabricBookingDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FabricBookingDateDateTimePicker.Location = New System.Drawing.Point(138, 99)
        Me.FabricBookingDateDateTimePicker.Name = "FabricBookingDateDateTimePicker"
        Me.FabricBookingDateDateTimePicker.Size = New System.Drawing.Size(124, 20)
        Me.FabricBookingDateDateTimePicker.TabIndex = 19
        '
        'SampleFabricBookingLookupBindingSource
        '
        Me.SampleFabricBookingLookupBindingSource.DataMember = "SampleFabricBookingLookup"
        Me.SampleFabricBookingLookupBindingSource.DataSource = Me.SampleFabricBookingLookupDataSet
        '
        'SampleFabricBookingLookupDataSet
        '
        Me.SampleFabricBookingLookupDataSet.DataSetName = "SampleFabricBookingLookupDataSet"
        Me.SampleFabricBookingLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SampleFabricBookingLookupTableAdapter
        '
        Me.SampleFabricBookingLookupTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(451, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Sample Fabric Booking No :"
        '
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.Location = New System.Drawing.Point(842, 12)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(70, 20)
        Me.ShowButton.TabIndex = 58
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(597, 12)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.SFBLookupByDivUserBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "Details"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridView3
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "SampleFabricBookingId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(239, 20)
        Me.GridLookUpEdit1.TabIndex = 57
        '
        'SFBLookupByDivUserBindingSource
        '
        Me.SFBLookupByDivUserBindingSource.DataMember = "SFBLookupByDivUser"
        Me.SFBLookupByDivUserBindingSource.DataSource = Me.SampleFabricBookingLookupDataSet
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1, Me.colFabricBookingDate})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFabricBookingDate, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'colFabricBookingDate
        '
        Me.colFabricBookingDate.FieldName = "FabricBookingDate"
        Me.colFabricBookingDate.Name = "colFabricBookingDate"
        Me.colFabricBookingDate.Visible = True
        Me.colFabricBookingDate.VisibleIndex = 1
        '
        'SampleFabricBindingSource
        '
        Me.SampleFabricBindingSource.DataMember = "SampleFabricBooking_SampleFabric"
        Me.SampleFabricBindingSource.DataSource = Me.SampleFabricBookingBindingSource
        '
        'SampleFabricGridControl
        '
        Me.SampleFabricGridControl.DataSource = Me.SampleFabricBindingSource
        Me.SampleFabricGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SampleFabricGridControl.Location = New System.Drawing.Point(0, 0)
        Me.SampleFabricGridControl.MainView = Me.SampleFabricGridView
        Me.SampleFabricGridControl.Name = "SampleFabricGridControl"
        Me.SampleFabricGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.KnittingTypeGridLookUpEdit, Me.CompositionGridLookUpEdit, Me.PartGridLookUpEdit, Me.DiaTypeComboBox, Me.FabricColorGridLookUpEdit, Me.RepositoryItemComboBox1})
        Me.SampleFabricGridControl.Size = New System.Drawing.Size(1354, 183)
        Me.SampleFabricGridControl.TabIndex = 59
        Me.SampleFabricGridControl.UseEmbeddedNavigator = True
        Me.SampleFabricGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.SampleFabricGridView})
        '
        'SampleFabricGridView
        '
        Me.SampleFabricGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName, Me.colELD, Me.colGarmentsPartId, Me.colKnittingTypeId, Me.colCompositionId, Me.colFGSM, Me.colDia, Me.colDiaType, Me.colFinishUnit, Me.colBookingQuantity, Me.colRemarks, Me.colSPNote, Me.colConsumption, Me.colGreyPercentage, Me.colGreyQuantity, Me.colKgPerUnit, Me.colLength, Me.colDUnit, Me.colIsFabricAvailable})
        Me.SampleFabricGridView.GridControl = Me.SampleFabricGridControl
        Me.SampleFabricGridView.Name = "SampleFabricGridView"
        Me.SampleFabricGridView.OptionsDetail.AllowZoomDetail = False
        Me.SampleFabricGridView.OptionsDetail.EnableMasterViewMode = False
        Me.SampleFabricGridView.OptionsDetail.ShowDetailTabs = False
        Me.SampleFabricGridView.OptionsView.ColumnAutoWidth = False
        Me.SampleFabricGridView.OptionsView.ShowDetailButtons = False
        Me.SampleFabricGridView.OptionsView.ShowFooter = True
        Me.SampleFabricGridView.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName
        '
        Me.colFabricColorName.Caption = "Fabric Color ( F11 )"
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.OptionsColumn.ReadOnly = True
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        Me.colFabricColorName.Width = 178
        '
        'colELD
        '
        Me.colELD.Caption = "NLD"
        Me.colELD.FieldName = "ELD"
        Me.colELD.Name = "colELD"
        Me.colELD.Visible = True
        Me.colELD.VisibleIndex = 1
        '
        'colGarmentsPartId
        '
        Me.colGarmentsPartId.Caption = "Garments Part"
        Me.colGarmentsPartId.ColumnEdit = Me.PartGridLookUpEdit
        Me.colGarmentsPartId.FieldName = "GarmentsPartId"
        Me.colGarmentsPartId.Name = "colGarmentsPartId"
        Me.colGarmentsPartId.Visible = True
        Me.colGarmentsPartId.VisibleIndex = 2
        Me.colGarmentsPartId.Width = 96
        '
        'PartGridLookUpEdit
        '
        Me.PartGridLookUpEdit.AutoHeight = False
        Me.PartGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PartGridLookUpEdit.DataSource = Me.GarmentsPartBindingSource
        Me.PartGridLookUpEdit.DisplayMember = "Name"
        Me.PartGridLookUpEdit.Name = "PartGridLookUpEdit"
        Me.PartGridLookUpEdit.NullText = ""
        Me.PartGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.PartGridLookUpEdit.PopupView = Me.GridView5
        Me.PartGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PartGridLookUpEdit.ValueMember = "GarmentsPartId"
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
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName2})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colName2
        '
        Me.colName2.FieldName = "Name"
        Me.colName2.Name = "colName2"
        Me.colName2.Visible = True
        Me.colName2.VisibleIndex = 0
        '
        'colKnittingTypeId
        '
        Me.colKnittingTypeId.Caption = "Fabric Type"
        Me.colKnittingTypeId.ColumnEdit = Me.KnittingTypeGridLookUpEdit
        Me.colKnittingTypeId.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId.Name = "colKnittingTypeId"
        Me.colKnittingTypeId.Visible = True
        Me.colKnittingTypeId.VisibleIndex = 3
        Me.colKnittingTypeId.Width = 130
        '
        'KnittingTypeGridLookUpEdit
        '
        Me.KnittingTypeGridLookUpEdit.AutoHeight = False
        Me.KnittingTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.KnittingTypeGridLookUpEdit.DataSource = Me.KnittingTypeBindingSource
        Me.KnittingTypeGridLookUpEdit.DisplayMember = "KnittingType"
        Me.KnittingTypeGridLookUpEdit.Name = "KnittingTypeGridLookUpEdit"
        Me.KnittingTypeGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.KnittingTypeGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingType1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colKnittingType1
        '
        Me.colKnittingType1.FieldName = "KnittingType"
        Me.colKnittingType1.Name = "colKnittingType1"
        Me.colKnittingType1.Visible = True
        Me.colKnittingType1.VisibleIndex = 0
        '
        'colCompositionId
        '
        Me.colCompositionId.Caption = "Composition"
        Me.colCompositionId.ColumnEdit = Me.CompositionGridLookUpEdit
        Me.colCompositionId.FieldName = "CompositionId"
        Me.colCompositionId.Name = "colCompositionId"
        Me.colCompositionId.Visible = True
        Me.colCompositionId.VisibleIndex = 4
        Me.colCompositionId.Width = 139
        '
        'CompositionGridLookUpEdit
        '
        Me.CompositionGridLookUpEdit.AutoHeight = False
        Me.CompositionGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompositionGridLookUpEdit.DataSource = Me.CompositionBindingSource
        Me.CompositionGridLookUpEdit.DisplayMember = "Composition"
        Me.CompositionGridLookUpEdit.Name = "CompositionGridLookUpEdit"
        Me.CompositionGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.CompositionGridLookUpEdit.PopupView = Me.GridView4
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
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colComposition1})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colComposition1
        '
        Me.colComposition1.FieldName = "Composition"
        Me.colComposition1.Name = "colComposition1"
        Me.colComposition1.Visible = True
        Me.colComposition1.VisibleIndex = 0
        '
        'colFGSM
        '
        Me.colFGSM.FieldName = "FGSM"
        Me.colFGSM.Name = "colFGSM"
        Me.colFGSM.Visible = True
        Me.colFGSM.VisibleIndex = 6
        '
        'colDia
        '
        Me.colDia.FieldName = "Dia"
        Me.colDia.Name = "colDia"
        Me.colDia.Visible = True
        Me.colDia.VisibleIndex = 7
        '
        'colDiaType
        '
        Me.colDiaType.ColumnEdit = Me.DiaTypeComboBox
        Me.colDiaType.FieldName = "DiaType"
        Me.colDiaType.Name = "colDiaType"
        Me.colDiaType.Visible = True
        Me.colDiaType.VisibleIndex = 9
        '
        'DiaTypeComboBox
        '
        Me.DiaTypeComboBox.AutoHeight = False
        Me.DiaTypeComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DiaTypeComboBox.Items.AddRange(New Object() {"Open", "Tube"})
        Me.DiaTypeComboBox.Name = "DiaTypeComboBox"
        '
        'colFinishUnit
        '
        Me.colFinishUnit.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colFinishUnit.FieldName = "FinishUnit"
        Me.colFinishUnit.Name = "colFinishUnit"
        Me.colFinishUnit.Visible = True
        Me.colFinishUnit.VisibleIndex = 14
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Kg", "Yrds", "Mtr", "Pcs"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colBookingQuantity
        '
        Me.colBookingQuantity.Caption = "Booking Quantity"
        Me.colBookingQuantity.FieldName = "BookingQuantity"
        Me.colBookingQuantity.Name = "colBookingQuantity"
        Me.colBookingQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BookingQuantity", "{0:0.##}")})
        Me.colBookingQuantity.Visible = True
        Me.colBookingQuantity.VisibleIndex = 13
        Me.colBookingQuantity.Width = 102
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 18
        '
        'colSPNote
        '
        Me.colSPNote.FieldName = "SPNote"
        Me.colSPNote.Name = "colSPNote"
        Me.colSPNote.Visible = True
        Me.colSPNote.VisibleIndex = 5
        Me.colSPNote.Width = 105
        '
        'colConsumption
        '
        Me.colConsumption.FieldName = "Consumption"
        Me.colConsumption.Name = "colConsumption"
        Me.colConsumption.Visible = True
        Me.colConsumption.VisibleIndex = 11
        '
        'colGreyPercentage
        '
        Me.colGreyPercentage.Caption = "Grey Percentage"
        Me.colGreyPercentage.FieldName = "GreyPercentage"
        Me.colGreyPercentage.Name = "colGreyPercentage"
        Me.colGreyPercentage.Visible = True
        Me.colGreyPercentage.VisibleIndex = 15
        Me.colGreyPercentage.Width = 97
        '
        'colGreyQuantity
        '
        Me.colGreyQuantity.FieldName = "GreyQuantity"
        Me.colGreyQuantity.Name = "colGreyQuantity"
        Me.colGreyQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GreyQuantity", "{0:0.##}")})
        Me.colGreyQuantity.Visible = True
        Me.colGreyQuantity.VisibleIndex = 16
        Me.colGreyQuantity.Width = 97
        '
        'colKgPerUnit
        '
        Me.colKgPerUnit.FieldName = "KgPerUnit"
        Me.colKgPerUnit.Name = "colKgPerUnit"
        Me.colKgPerUnit.Visible = True
        Me.colKgPerUnit.VisibleIndex = 12
        Me.colKgPerUnit.Width = 84
        '
        'colLength
        '
        Me.colLength.FieldName = "Length"
        Me.colLength.Name = "colLength"
        Me.colLength.Visible = True
        Me.colLength.VisibleIndex = 10
        '
        'colDUnit
        '
        Me.colDUnit.FieldName = "DUnit"
        Me.colDUnit.Name = "colDUnit"
        Me.colDUnit.Visible = True
        Me.colDUnit.VisibleIndex = 8
        '
        'colIsFabricAvailable
        '
        Me.colIsFabricAvailable.FieldName = "IsFabricAvailable"
        Me.colIsFabricAvailable.Name = "colIsFabricAvailable"
        Me.colIsFabricAvailable.Visible = True
        Me.colIsFabricAvailable.VisibleIndex = 17
        Me.colIsFabricAvailable.Width = 95
        '
        'FabricColorGridLookUpEdit
        '
        Me.FabricColorGridLookUpEdit.AutoHeight = False
        Me.FabricColorGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabricColorGridLookUpEdit.DataSource = Me.FabricColorBindingSource
        Me.FabricColorGridLookUpEdit.DisplayMember = "FabricColorName"
        Me.FabricColorGridLookUpEdit.Name = "FabricColorGridLookUpEdit"
        Me.FabricColorGridLookUpEdit.PopupView = Me.GridView7
        Me.FabricColorGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FabricColorGridLookUpEdit.ValueMember = "FabricColorName"
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
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName1})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName1
        '
        Me.colFabricColorName1.FieldName = "FabricColorName"
        Me.colFabricColorName1.Name = "colFabricColorName1"
        Me.colFabricColorName1.Visible = True
        Me.colFabricColorName1.VisibleIndex = 0
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'GSMDataSet
        '
        Me.GSMDataSet.DataSetName = "GSMDataSet"
        Me.GSMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GSMBindingSource
        '
        Me.GSMBindingSource.DataMember = "GSM"
        Me.GSMBindingSource.DataSource = Me.GSMDataSet
        '
        'GSMTableAdapter
        '
        Me.GSMTableAdapter.ClearBeforeFill = True
        '
        'GarmentsPartTableAdapter
        '
        Me.GarmentsPartTableAdapter.ClearBeforeFill = True
        '
        'colKnittingType
        '
        Me.colKnittingType.Caption = "Fabric Type"
        Me.colKnittingType.FieldName = "KnittingType"
        Me.colKnittingType.Name = "colKnittingType"
        Me.colKnittingType.Visible = True
        Me.colKnittingType.VisibleIndex = 0
        '
        'colComposition
        '
        Me.colComposition.FieldName = "Composition"
        Me.colComposition.Name = "colComposition"
        Me.colComposition.Visible = True
        Me.colComposition.VisibleIndex = 0
        '
        'colName
        '
        Me.colName.Caption = "Part"
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colName1
        '
        Me.colName1.FieldName = "Name"
        Me.colName1.Name = "colName1"
        Me.colName1.Visible = True
        Me.colName1.VisibleIndex = 0
        '
        'CompletedOnDateEdit
        '
        Me.CompletedOnDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleFabricBookingBindingSource, "CompletedOn", True))
        Me.CompletedOnDateEdit.EditValue = Nothing
        Me.CompletedOnDateEdit.Location = New System.Drawing.Point(138, 74)
        Me.CompletedOnDateEdit.Name = "CompletedOnDateEdit"
        Me.CompletedOnDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompletedOnDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CompletedOnDateEdit.Properties.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.CompletedOnDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CompletedOnDateEdit.Properties.EditFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.CompletedOnDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.CompletedOnDateEdit.Properties.Mask.EditMask = "dd-MMM-yy HH:mm"
        Me.CompletedOnDateEdit.Properties.ReadOnly = True
        Me.CompletedOnDateEdit.Size = New System.Drawing.Size(124, 20)
        Me.CompletedOnDateEdit.TabIndex = 21
        '
        'AttentionTextEdit
        '
        Me.AttentionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleFabricBookingBindingSource, "Attention", True))
        Me.AttentionTextEdit.Location = New System.Drawing.Point(137, 191)
        Me.AttentionTextEdit.Name = "AttentionTextEdit"
        Me.AttentionTextEdit.Size = New System.Drawing.Size(124, 20)
        Me.AttentionTextEdit.TabIndex = 61
        '
        'CCTextEdit
        '
        Me.CCTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleFabricBookingBindingSource, "CC", True))
        Me.CCTextEdit.Location = New System.Drawing.Point(344, 191)
        Me.CCTextEdit.Name = "CCTextEdit"
        Me.CCTextEdit.Size = New System.Drawing.Size(145, 20)
        Me.CCTextEdit.TabIndex = 62
        '
        'CompletedByGridLookUpEditView
        '
        Me.CompletedByGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME})
        Me.CompletedByGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CompletedByGridLookUpEditView.Name = "CompletedByGridLookUpEditView"
        Me.CompletedByGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CompletedByGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'CompletedByGridLookUpEdit
        '
        Me.CompletedByGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleFabricBookingBindingSource, "CompletedBy", True))
        Me.CompletedByGridLookUpEdit.Location = New System.Drawing.Point(138, 216)
        Me.CompletedByGridLookUpEdit.Name = "CompletedByGridLookUpEdit"
        Me.CompletedByGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompletedByGridLookUpEdit.Properties.DataSource = Me.UserLookupBindingSource
        Me.CompletedByGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.CompletedByGridLookUpEdit.Properties.NullText = ""
        Me.CompletedByGridLookUpEdit.Properties.PopupView = Me.CompletedByGridLookUpEditView
        Me.CompletedByGridLookUpEdit.Properties.ReadOnly = True
        Me.CompletedByGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.CompletedByGridLookUpEdit.Size = New System.Drawing.Size(124, 20)
        Me.CompletedByGridLookUpEdit.TabIndex = 60
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
        'CauseOfRevisedTextEdit
        '
        Me.CauseOfRevisedTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleFabricBookingBindingSource, "CauseOfRevised", True))
        Me.CauseOfRevisedTextEdit.Location = New System.Drawing.Point(505, 77)
        Me.CauseOfRevisedTextEdit.Name = "CauseOfRevisedTextEdit"
        Me.CauseOfRevisedTextEdit.Size = New System.Drawing.Size(173, 137)
        Me.CauseOfRevisedTextEdit.TabIndex = 63
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 244)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SampleFabricGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.YarnAllocationSampleGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1354, 471)
        Me.SplitContainer1.SplitterDistance = 183
        Me.SplitContainer1.TabIndex = 64
        '
        'YarnAllocationSampleGridControl
        '
        Me.YarnAllocationSampleGridControl.DataSource = Me.YarnAllocationSampleBindingSource
        Me.YarnAllocationSampleGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.YarnAllocationSampleGridControl.Location = New System.Drawing.Point(0, 0)
        Me.YarnAllocationSampleGridControl.MainView = Me.GridView6
        Me.YarnAllocationSampleGridControl.Name = "YarnAllocationSampleGridControl"
        Me.YarnAllocationSampleGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemNameGridLookUpEdit})
        Me.YarnAllocationSampleGridControl.Size = New System.Drawing.Size(1354, 284)
        Me.YarnAllocationSampleGridControl.TabIndex = 2
        Me.YarnAllocationSampleGridControl.UseEmbeddedNavigator = True
        Me.YarnAllocationSampleGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'YarnAllocationSampleBindingSource
        '
        Me.YarnAllocationSampleBindingSource.DataMember = "FK_YarnAllocationSample_SampleFabric"
        Me.YarnAllocationSampleBindingSource.DataSource = Me.SampleFabricBindingSource
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colRemarks1, Me.colYarnPercentage, Me.colWastagePercentage, Me.colQuantity, Me.colYarnColor, Me.colIsYds1, Me.colFeederSize, Me.colFeederQty, Me.colFeederNo, Me.colStripeGroup, Me.colStripeSL, Me.colGroupSL})
        Me.GridView6.GridControl = Me.YarnAllocationSampleGridControl
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsCustomization.AllowGroup = False
        Me.GridView6.OptionsView.ColumnAutoWidth = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
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
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'SRLookupByDivUserAndSFBPendingTableAdapter
        '
        Me.SRLookupByDivUserAndSFBPendingTableAdapter.ClearBeforeFill = True
        '
        'SFBLookupByDivUserTableAdapter
        '
        Me.SFBLookupByDivUserTableAdapter.ClearBeforeFill = True
        '
        'SRLookupByDivUserTableAdapter
        '
        Me.SRLookupByDivUserTableAdapter.ClearBeforeFill = True
        '
        'CopyFabricButton
        '
        Me.CopyFabricButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyFabricButton.Location = New System.Drawing.Point(1253, 218)
        Me.CopyFabricButton.Name = "CopyFabricButton"
        Me.CopyFabricButton.Size = New System.Drawing.Size(89, 23)
        Me.CopyFabricButton.TabIndex = 65
        Me.CopyFabricButton.Text = "Copy"
        Me.CopyFabricButton.UseVisualStyleBackColor = True
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'ProceedForKnittingCheckEdit
        '
        Me.ProceedForKnittingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleFabricBookingBindingSource, "ProceedForKnitting", True))
        Me.ProceedForKnittingCheckEdit.Location = New System.Drawing.Point(505, 218)
        Me.ProceedForKnittingCheckEdit.Name = "ProceedForKnittingCheckEdit"
        Me.ProceedForKnittingCheckEdit.Properties.Caption = "Proceed for Knitting"
        Me.ProceedForKnittingCheckEdit.Size = New System.Drawing.Size(128, 19)
        Me.ProceedForKnittingCheckEdit.TabIndex = 66
        '
        'ProceedForDyeingCheckEdit
        '
        Me.ProceedForDyeingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SampleFabricBookingBindingSource, "ProceedForDyeing", True))
        Me.ProceedForDyeingCheckEdit.Location = New System.Drawing.Point(639, 219)
        Me.ProceedForDyeingCheckEdit.Name = "ProceedForDyeingCheckEdit"
        Me.ProceedForDyeingCheckEdit.Properties.Caption = "Proceed For Dyeing"
        Me.ProceedForDyeingCheckEdit.Size = New System.Drawing.Size(149, 19)
        Me.ProceedForDyeingCheckEdit.TabIndex = 67
        '
        'frmFabricBooking_Sample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 715)
        Me.Controls.Add(Me.ProceedForDyeingCheckEdit)
        Me.Controls.Add(Me.ProceedForKnittingCheckEdit)
        Me.Controls.Add(Me.CopyFabricButton)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(CauseOfRevisedLabel)
        Me.Controls.Add(Label1)
        Me.Controls.Add(CCLabel)
        Me.Controls.Add(Me.CCTextEdit)
        Me.Controls.Add(AttentionLabel)
        Me.Controls.Add(Me.AttentionTextEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.CompletedOnDateEdit)
        Me.Controls.Add(FabricBookingDateLabel)
        Me.Controls.Add(Me.FabricBookingDateDateTimePicker)
        Me.Controls.Add(Me.RevisedButton)
        Me.Controls.Add(Me.RevisedNoNumericUpDown)
        Me.Controls.Add(Me.SampleFabricBookingRevisedHistoryGridControl)
        Me.Controls.Add(SampleRequestIdLabel)
        Me.Controls.Add(Me.SampleRequestIdGridLookUpEdit)
        Me.Controls.Add(Me.IsCompleteCheckBox)
        Me.Controls.Add(Me.IsReceivedCheckBox)
        Me.Controls.Add(FabricRequireDateLabel)
        Me.Controls.Add(Me.FabricRequireDateDateTimePicker)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(RevisedDateLabel)
        Me.Controls.Add(Me.RevisedDateDateTimePicker)
        Me.Controls.Add(RevisedNoLabel)
        Me.Controls.Add(BookingNoLabel)
        Me.Controls.Add(Me.BookingNoTextBox)
        Me.Controls.Add(Me.SampleFabricBookingBindingNavigator)
        Me.Controls.Add(Me.CompletedByGridLookUpEdit)
        Me.Controls.Add(Me.CauseOfRevisedTextEdit)
        Me.KeyPreview = True
        Me.Name = "frmFabricBooking_Sample"
        Me.Text = "Fabric Booking [ Sample ]"
        CType(Me.SampleFabricBookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBookingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SampleFabricBookingBindingNavigator.ResumeLayout(False)
        Me.SampleFabricBookingBindingNavigator.PerformLayout()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRLookupByDivUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRLookupByDivUserAndSFBPendingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBookingRevisedHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBookingRevisedHistoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RevisedNoNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBookingLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SFBLookupByDivUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GarmentsPartDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaTypeComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompletedOnDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompletedOnDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttentionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompletedByGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompletedByGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CauseOfRevisedTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.YarnAllocationSampleGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YarnAllocationSampleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProceedForKnittingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProceedForDyeingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SampleFabricBookingDataSet As KSoft_Apparel.SampleFabricBookingDataSet
    Friend WithEvents SampleFabricBookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleFabricBookingTableAdapter As KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricBookingTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SampleFabricBookingBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SampleRequestDataSet As KSoft_Apparel.SampleRequestDataSet
    Friend WithEvents SampleRequestNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleRequestNoLookupTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestNoLookupTableAdapter
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BookingNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RevisedDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FabricRequireDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IsReceivedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IsCompleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SampleRequestIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SampleRequestIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents SampleFabricBookingRevisedHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleFabricBookingRevisedHistoryTableAdapter As KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricBookingRevisedHistoryTableAdapter
    Friend WithEvents SampleFabricBookingRevisedHistoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRevisedNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRevisedDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCasuseOfRevised As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RevisedNoNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents RevisedButton As System.Windows.Forms.Button
    Friend WithEvents FabricBookingDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SampleFabricBookingLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleFabricBookingLookupDataSet As KSoft_Apparel.SampleFabricBookingLookupDataSet
    Friend WithEvents SampleFabricBookingLookupTableAdapter As KSoft_Apparel.SampleFabricBookingLookupDataSetTableAdapters.SampleFabricBookingLookupTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SampleFabricBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleFabricTableAdapter As KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricTableAdapter
    Friend WithEvents SampleFabricGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents SampleFabricGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colELD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGarmentsPartId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompositionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiaType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFinishUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBookingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSPNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents GSMDataSet As KSoft_Apparel.GSMDataSet
    Friend WithEvents GSMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GSMTableAdapter As KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
    Friend WithEvents GarmentsPartDataSet As KSoft_Apparel.GarmentsPartDataSet
    Friend WithEvents GarmentsPartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GarmentsPartTableAdapter As KSoft_Apparel.GarmentsPartDataSetTableAdapters.GarmentsPartTableAdapter
    Friend WithEvents PartGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KnittingTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompositionGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DiaTypeComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComposition As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComposition1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompletedOnDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AttentionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CCTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colConsumption As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompletedByGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompletedByGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents colGreyPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGreyQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKgPerUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CauseOfRevisedTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ItemListLookupDataSet As ItemListLookupDataSet
    Friend WithEvents ItemListBindingSource As BindingSource
    Friend WithEvents ItemListTableAdapter As ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents YarnAllocationSampleGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemNameGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents YarnAllocationSampleBindingSource As BindingSource
    Friend WithEvents YarnAllocationSampleTableAdapter As SampleFabricBookingDataSetTableAdapters.YarnAllocationSampleTableAdapter
    Friend WithEvents UserLookupDataSet As UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As BindingSource
    Friend WithEvents UserLookupTableAdapter As UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SRLookupByDivUserAndSFBPendingBindingSource As BindingSource
    Friend WithEvents SampleRequestLookupDataSet As SampleRequestLookupDataSet
    Friend WithEvents SRLookupByDivUserAndSFBPendingTableAdapter As SampleRequestLookupDataSetTableAdapters.SRLookupByDivUserAndSFBPendingTableAdapter
    Friend WithEvents SFBLookupByDivUserBindingSource As BindingSource
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricBookingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SFBLookupByDivUserTableAdapter As SampleFabricBookingLookupDataSetTableAdapters.SFBLookupByDivUserTableAdapter
    Friend WithEvents SRLookupByDivUserBindingSource As BindingSource
    Friend WithEvents SRLookupByDivUserTableAdapter As SampleRequestLookupDataSetTableAdapters.SRLookupByDivUserTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CopyFabricButton As Button
    Friend WithEvents FabricColorGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorDataSet As FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As BindingSource
    Friend WithEvents FabricColorTableAdapter As FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents colFabricColorName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colDUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsFabricAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProceedForKnittingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ProceedForDyeingCheckEdit As DevExpress.XtraEditors.CheckEdit
End Class
