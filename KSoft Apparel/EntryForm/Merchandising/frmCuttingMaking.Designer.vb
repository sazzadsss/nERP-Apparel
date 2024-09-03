<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuttingMaking
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
        Dim StyleNameLabel As System.Windows.Forms.Label
        Dim MachineQuantityLabel As System.Windows.Forms.Label
        Dim TargetQuantityLabel As System.Windows.Forms.Label
        Dim MCCost_PREVIOUSLabel As System.Windows.Forms.Label
        Dim ProductionPerMachineLabel As System.Windows.Forms.Label
        Dim MCost_PRESENTLabel As System.Windows.Forms.Label
        Dim CM_PREVIOUSLabel As System.Windows.Forms.Label
        Dim CM_PRESENTLabel As System.Windows.Forms.Label
        Dim CM_BUYERLabel As System.Windows.Forms.Label
        Dim CM_PRODUCTIONLabel As System.Windows.Forms.Label
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet
        Me.GSMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSMDataSet = New KSoft_Apparel.GSMDataSet
        Me.CuttingMakingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuttingMakingDataSet = New KSoft_Apparel.CuttingMakingDataSet
        Me.StyleTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter
        Me.GSMTableAdapter = New KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.StyleLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colStyleId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.StyleNameTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.CM_FirstLayoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MachineQuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.TargetQuantitySpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.MCCost_PREVIOUSSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.ProductionPerMachineSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.MCost_PRESENTSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.CM_PREVIOUSSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.CM_PRESENTSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.CM_BUYERSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.CM_PRODUCTIONSpinEdit = New DevExpress.XtraEditors.SpinEdit
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.CM_ProductionGridControl = New DevExpress.XtraGrid.GridControl
        Me.CM_ProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleName1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLayoutId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSewingLayoutNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMachineQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOutputQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colWorkingHour = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalTargetQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOutputPerHour = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOutputPerMachine = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTargetOutputPerMachine = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMCCost_PRESENT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCMTargetWastage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMCCost_PREVIOUS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCM_PREVIOUS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCM_PRESENT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMinSewingDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMaxSewingDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CuttingMakingTableAdapter = New KSoft_Apparel.CuttingMakingDataSetTableAdapters.CuttingMakingTableAdapter
        Me.TableAdapterManager = New KSoft_Apparel.CuttingMakingDataSetTableAdapters.TableAdapterManager
        Me.CM_FirstLayoutTableAdapter = New KSoft_Apparel.CuttingMakingDataSetTableAdapters.CM_FirstLayoutTableAdapter
        Me.CM_ProductionTableAdapter = New KSoft_Apparel.CuttingMakingDataSetTableAdapters.CM_ProductionTableAdapter
        Me.StyleLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter
        Me.KnittingTypeDataSet = New KSoft_Apparel.KnittingTypeDataSet
        Me.KnittingTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KnittingTypeTableAdapter = New KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.CuttingMakingGridControl = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colStyleId2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.StyleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colStyleId3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleName2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDefaultTarget = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSMV = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCostingCM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompositionId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CompositionGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.CompositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompositionDataSet = New KSoft_Apparel.CompositionDataSet
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKnittingTypeId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KnittingTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colGSM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GSMLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKnittingTypeId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKnittingTypeCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKnittingType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MessageLabel = New System.Windows.Forms.Label
        Me.NewLinkLabel = New System.Windows.Forms.LinkLabel
        Me.EditLinkLabel = New System.Windows.Forms.LinkLabel
        Me.CancelLinkLabel = New System.Windows.Forms.LinkLabel
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CompositionTableAdapter = New KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
        Me.colBuyerId1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
        Me.colDivisionId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DivisionGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DivisionDataSet = New KSoft_Apparel.DivisionDataSet
        Me.DivisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivisionTableAdapter = New KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter
        Me.colGMDescription = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GMDescriptionItemMemoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colIsAOP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsBrush = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsEmbroidery = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPeachFinish = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsPrint = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsWash = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIsYDS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStyleType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PictureEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        StyleNameLabel = New System.Windows.Forms.Label
        MachineQuantityLabel = New System.Windows.Forms.Label
        TargetQuantityLabel = New System.Windows.Forms.Label
        MCCost_PREVIOUSLabel = New System.Windows.Forms.Label
        ProductionPerMachineLabel = New System.Windows.Forms.Label
        MCost_PRESENTLabel = New System.Windows.Forms.Label
        CM_PREVIOUSLabel = New System.Windows.Forms.Label
        CM_PRESENTLabel = New System.Windows.Forms.Label
        CM_BUYERLabel = New System.Windows.Forms.Label
        CM_PRODUCTIONLabel = New System.Windows.Forms.Label
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingMakingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuttingMakingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.StyleNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM_FirstLayoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TargetQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCCost_PREVIOUSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionPerMachineSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MCost_PRESENTSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM_PREVIOUSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM_PRESENTSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM_BUYERSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM_PRODUCTIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.CM_ProductionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CM_ProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CuttingMakingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnittingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSMLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMDescriptionItemMemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleNameLabel
        '
        StyleNameLabel.AutoSize = True
        StyleNameLabel.Location = New System.Drawing.Point(30, 52)
        StyleNameLabel.Name = "StyleNameLabel"
        StyleNameLabel.Size = New System.Drawing.Size(64, 13)
        StyleNameLabel.TabIndex = 2
        StyleNameLabel.Text = "Style Name:"
        '
        'MachineQuantityLabel
        '
        MachineQuantityLabel.AutoSize = True
        MachineQuantityLabel.Location = New System.Drawing.Point(32, 89)
        MachineQuantityLabel.Name = "MachineQuantityLabel"
        MachineQuantityLabel.Size = New System.Drawing.Size(93, 13)
        MachineQuantityLabel.TabIndex = 6
        MachineQuantityLabel.Text = "Machine Quantity:"
        '
        'TargetQuantityLabel
        '
        TargetQuantityLabel.AutoSize = True
        TargetQuantityLabel.Location = New System.Drawing.Point(32, 115)
        TargetQuantityLabel.Name = "TargetQuantityLabel"
        TargetQuantityLabel.Size = New System.Drawing.Size(83, 13)
        TargetQuantityLabel.TabIndex = 8
        TargetQuantityLabel.Text = "Target Quantity:"
        '
        'MCCost_PREVIOUSLabel
        '
        MCCost_PREVIOUSLabel.AutoSize = True
        MCCost_PREVIOUSLabel.Location = New System.Drawing.Point(279, 89)
        MCCost_PREVIOUSLabel.Name = "MCCost_PREVIOUSLabel"
        MCCost_PREVIOUSLabel.Size = New System.Drawing.Size(100, 13)
        MCCost_PREVIOUSLabel.TabIndex = 10
        MCCost_PREVIOUSLabel.Text = "MC Cost [Previous]:"
        '
        'ProductionPerMachineLabel
        '
        ProductionPerMachineLabel.AutoSize = True
        ProductionPerMachineLabel.Location = New System.Drawing.Point(32, 141)
        ProductionPerMachineLabel.Name = "ProductionPerMachineLabel"
        ProductionPerMachineLabel.Size = New System.Drawing.Size(104, 13)
        ProductionPerMachineLabel.TabIndex = 12
        ProductionPerMachineLabel.Text = "Target Per Machine:"
        '
        'MCost_PRESENTLabel
        '
        MCost_PRESENTLabel.AutoSize = True
        MCost_PRESENTLabel.Location = New System.Drawing.Point(280, 115)
        MCost_PRESENTLabel.Name = "MCost_PRESENTLabel"
        MCost_PRESENTLabel.Size = New System.Drawing.Size(92, 13)
        MCost_PRESENTLabel.TabIndex = 14
        MCost_PRESENTLabel.Text = "MCCost [Present]:"
        '
        'CM_PREVIOUSLabel
        '
        CM_PREVIOUSLabel.AutoSize = True
        CM_PREVIOUSLabel.Location = New System.Drawing.Point(505, 89)
        CM_PREVIOUSLabel.Name = "CM_PREVIOUSLabel"
        CM_PREVIOUSLabel.Size = New System.Drawing.Size(174, 13)
        CM_PREVIOUSLabel.TabIndex = 18
        CM_PREVIOUSLabel.Text = "CM DEVELOPMENT [PREVIOUS]:"
        '
        'CM_PRESENTLabel
        '
        CM_PRESENTLabel.AutoSize = True
        CM_PRESENTLabel.Location = New System.Drawing.Point(505, 115)
        CM_PRESENTLabel.Name = "CM_PRESENTLabel"
        CM_PRESENTLabel.Size = New System.Drawing.Size(173, 13)
        CM_PRESENTLabel.TabIndex = 20
        CM_PRESENTLabel.Text = "CM DEVELOPMENT [ PRESENT]:"
        '
        'CM_BUYERLabel
        '
        CM_BUYERLabel.AutoSize = True
        CM_BUYERLabel.Location = New System.Drawing.Point(505, 141)
        CM_BUYERLabel.Name = "CM_BUYERLabel"
        CM_BUYERLabel.Size = New System.Drawing.Size(69, 13)
        CM_BUYERLabel.TabIndex = 22
        CM_BUYERLabel.Text = "CM BUYER :"
        '
        'CM_PRODUCTIONLabel
        '
        CM_PRODUCTIONLabel.AutoSize = True
        CM_PRODUCTIONLabel.Location = New System.Drawing.Point(505, 52)
        CM_PRODUCTIONLabel.Name = "CM_PRODUCTIONLabel"
        CM_PRODUCTIONLabel.Size = New System.Drawing.Size(161, 13)
        CM_PRODUCTIONLabel.TabIndex = 24
        CM_PRODUCTIONLabel.Text = "CM PRODUCTION [PRESENT]:"
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CuttingMakingBindingSource
        '
        Me.CuttingMakingBindingSource.DataMember = "CuttingMaking"
        Me.CuttingMakingBindingSource.DataSource = Me.CuttingMakingDataSet
        '
        'CuttingMakingDataSet
        '
        Me.CuttingMakingDataSet.DataSetName = "CuttingMakingDataSet"
        Me.CuttingMakingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'GSMTableAdapter
        '
        Me.GSMTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(369, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(50, 3, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Search Style"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StyleLookupGridLookUpEdit
        '
        Me.StyleLookupGridLookUpEdit.Location = New System.Drawing.Point(462, 5)
        Me.StyleLookupGridLookUpEdit.Name = "StyleLookupGridLookUpEdit"
        Me.StyleLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleLookupGridLookUpEdit.Properties.DataSource = Me.StyleBindingSource
        Me.StyleLookupGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleLookupGridLookUpEdit.Properties.NullText = "[Type a style name]"
        Me.StyleLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleLookupGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleLookupGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.StyleLookupGridLookUpEdit.Size = New System.Drawing.Size(143, 20)
        Me.StyleLookupGridLookUpEdit.TabIndex = 40
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleId1, Me.colStyleName})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colStyleId1
        '
        Me.colStyleId1.FieldName = "StyleId"
        Me.colStyleId1.Name = "colStyleId1"
        Me.colStyleId1.OptionsColumn.ReadOnly = True
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(990, 226)
        Me.TabControl1.TabIndex = 57
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(StyleNameLabel)
        Me.TabPage1.Controls.Add(Me.StyleNameTextEdit)
        Me.TabPage1.Controls.Add(MachineQuantityLabel)
        Me.TabPage1.Controls.Add(Me.MachineQuantitySpinEdit)
        Me.TabPage1.Controls.Add(TargetQuantityLabel)
        Me.TabPage1.Controls.Add(Me.TargetQuantitySpinEdit)
        Me.TabPage1.Controls.Add(MCCost_PREVIOUSLabel)
        Me.TabPage1.Controls.Add(Me.MCCost_PREVIOUSSpinEdit)
        Me.TabPage1.Controls.Add(ProductionPerMachineLabel)
        Me.TabPage1.Controls.Add(Me.ProductionPerMachineSpinEdit)
        Me.TabPage1.Controls.Add(MCost_PRESENTLabel)
        Me.TabPage1.Controls.Add(Me.MCost_PRESENTSpinEdit)
        Me.TabPage1.Controls.Add(CM_PREVIOUSLabel)
        Me.TabPage1.Controls.Add(Me.CM_PREVIOUSSpinEdit)
        Me.TabPage1.Controls.Add(CM_PRESENTLabel)
        Me.TabPage1.Controls.Add(Me.CM_PRESENTSpinEdit)
        Me.TabPage1.Controls.Add(CM_BUYERLabel)
        Me.TabPage1.Controls.Add(Me.CM_BUYERSpinEdit)
        Me.TabPage1.Controls.Add(CM_PRODUCTIONLabel)
        Me.TabPage1.Controls.Add(Me.CM_PRODUCTIONSpinEdit)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(982, 197)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Comperative CM"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "CM From First Layout and Compare with other "
        '
        'StyleNameTextEdit
        '
        Me.StyleNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CM_FirstLayoutBindingSource, "StyleName", True))
        Me.StyleNameTextEdit.Enabled = False
        Me.StyleNameTextEdit.Location = New System.Drawing.Point(160, 49)
        Me.StyleNameTextEdit.Name = "StyleNameTextEdit"
        Me.StyleNameTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StyleNameTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.StyleNameTextEdit.Size = New System.Drawing.Size(323, 20)
        Me.StyleNameTextEdit.TabIndex = 3
        '
        'CM_FirstLayoutBindingSource
        '
        Me.CM_FirstLayoutBindingSource.DataMember = "CM_FirstLayout"
        Me.CM_FirstLayoutBindingSource.DataSource = Me.CuttingMakingDataSet
        '
        'MachineQuantitySpinEdit
        '
        Me.MachineQuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CM_FirstLayoutBindingSource, "MachineQuantity", True))
        Me.MachineQuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MachineQuantitySpinEdit.Location = New System.Drawing.Point(162, 86)
        Me.MachineQuantitySpinEdit.Name = "MachineQuantitySpinEdit"
        Me.MachineQuantitySpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MachineQuantitySpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.MachineQuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MachineQuantitySpinEdit.Properties.ReadOnly = True
        Me.MachineQuantitySpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.MachineQuantitySpinEdit.TabIndex = 7
        '
        'TargetQuantitySpinEdit
        '
        Me.TargetQuantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CM_FirstLayoutBindingSource, "TargetQuantity", True))
        Me.TargetQuantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TargetQuantitySpinEdit.Location = New System.Drawing.Point(162, 111)
        Me.TargetQuantitySpinEdit.Name = "TargetQuantitySpinEdit"
        Me.TargetQuantitySpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TargetQuantitySpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.TargetQuantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.TargetQuantitySpinEdit.Properties.ReadOnly = True
        Me.TargetQuantitySpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.TargetQuantitySpinEdit.TabIndex = 9
        '
        'MCCost_PREVIOUSSpinEdit
        '
        Me.MCCost_PREVIOUSSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CM_FirstLayoutBindingSource, "MCCost_PREVIOUS", True))
        Me.MCCost_PREVIOUSSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MCCost_PREVIOUSSpinEdit.Location = New System.Drawing.Point(383, 86)
        Me.MCCost_PREVIOUSSpinEdit.Name = "MCCost_PREVIOUSSpinEdit"
        Me.MCCost_PREVIOUSSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MCCost_PREVIOUSSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.MCCost_PREVIOUSSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MCCost_PREVIOUSSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.MCCost_PREVIOUSSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MCCost_PREVIOUSSpinEdit.Properties.ReadOnly = True
        Me.MCCost_PREVIOUSSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.MCCost_PREVIOUSSpinEdit.TabIndex = 11
        '
        'ProductionPerMachineSpinEdit
        '
        Me.ProductionPerMachineSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CM_FirstLayoutBindingSource, "ProductionPerMachine", True))
        Me.ProductionPerMachineSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ProductionPerMachineSpinEdit.Location = New System.Drawing.Point(162, 138)
        Me.ProductionPerMachineSpinEdit.Name = "ProductionPerMachineSpinEdit"
        Me.ProductionPerMachineSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductionPerMachineSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.ProductionPerMachineSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.ProductionPerMachineSpinEdit.Properties.DisplayFormat.FormatString = "n"
        Me.ProductionPerMachineSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ProductionPerMachineSpinEdit.Properties.ReadOnly = True
        Me.ProductionPerMachineSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.ProductionPerMachineSpinEdit.TabIndex = 13
        '
        'MCost_PRESENTSpinEdit
        '
        Me.MCost_PRESENTSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CM_FirstLayoutBindingSource, "MCost_PRESENT", True))
        Me.MCost_PRESENTSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MCost_PRESENTSpinEdit.Location = New System.Drawing.Point(383, 111)
        Me.MCost_PRESENTSpinEdit.Name = "MCost_PRESENTSpinEdit"
        Me.MCost_PRESENTSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MCost_PRESENTSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.MCost_PRESENTSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.MCost_PRESENTSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.MCost_PRESENTSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MCost_PRESENTSpinEdit.Properties.ReadOnly = True
        Me.MCost_PRESENTSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.MCost_PRESENTSpinEdit.TabIndex = 15
        '
        'CM_PREVIOUSSpinEdit
        '
        Me.CM_PREVIOUSSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CM_FirstLayoutBindingSource, "CM_PREVIOUS", True))
        Me.CM_PREVIOUSSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CM_PREVIOUSSpinEdit.Location = New System.Drawing.Point(684, 86)
        Me.CM_PREVIOUSSpinEdit.Name = "CM_PREVIOUSSpinEdit"
        Me.CM_PREVIOUSSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CM_PREVIOUSSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CM_PREVIOUSSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CM_PREVIOUSSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.CM_PREVIOUSSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CM_PREVIOUSSpinEdit.Properties.ReadOnly = True
        Me.CM_PREVIOUSSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.CM_PREVIOUSSpinEdit.TabIndex = 19
        '
        'CM_PRESENTSpinEdit
        '
        Me.CM_PRESENTSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CM_FirstLayoutBindingSource, "CM_PRESENT", True))
        Me.CM_PRESENTSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CM_PRESENTSpinEdit.Location = New System.Drawing.Point(684, 112)
        Me.CM_PRESENTSpinEdit.Name = "CM_PRESENTSpinEdit"
        Me.CM_PRESENTSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CM_PRESENTSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CM_PRESENTSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CM_PRESENTSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.CM_PRESENTSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CM_PRESENTSpinEdit.Properties.ReadOnly = True
        Me.CM_PRESENTSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.CM_PRESENTSpinEdit.TabIndex = 21
        '
        'CM_BUYERSpinEdit
        '
        Me.CM_BUYERSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CM_FirstLayoutBindingSource, "CM_BUYER", True))
        Me.CM_BUYERSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CM_BUYERSpinEdit.Location = New System.Drawing.Point(684, 138)
        Me.CM_BUYERSpinEdit.Name = "CM_BUYERSpinEdit"
        Me.CM_BUYERSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CM_BUYERSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CM_BUYERSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CM_BUYERSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.CM_BUYERSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CM_BUYERSpinEdit.Properties.ReadOnly = True
        Me.CM_BUYERSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.CM_BUYERSpinEdit.TabIndex = 23
        '
        'CM_PRODUCTIONSpinEdit
        '
        Me.CM_PRODUCTIONSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CM_FirstLayoutBindingSource, "CM_PRODUCTION", True))
        Me.CM_PRODUCTIONSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CM_PRODUCTIONSpinEdit.Location = New System.Drawing.Point(684, 49)
        Me.CM_PRODUCTIONSpinEdit.Name = "CM_PRODUCTIONSpinEdit"
        Me.CM_PRODUCTIONSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CM_PRODUCTIONSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CM_PRODUCTIONSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.CM_PRODUCTIONSpinEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.CM_PRODUCTIONSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CM_PRODUCTIONSpinEdit.Properties.ReadOnly = True
        Me.CM_PRODUCTIONSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.CM_PRODUCTIONSpinEdit.TabIndex = 25
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.CM_ProductionGridControl)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(982, 197)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Production CM Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CM_ProductionGridControl
        '
        Me.CM_ProductionGridControl.DataSource = Me.CM_ProductionBindingSource
        Me.CM_ProductionGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CM_ProductionGridControl.Location = New System.Drawing.Point(3, 3)
        Me.CM_ProductionGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CM_ProductionGridControl.MainView = Me.GridView1
        Me.CM_ProductionGridControl.Name = "CM_ProductionGridControl"
        Me.CM_ProductionGridControl.Size = New System.Drawing.Size(976, 191)
        Me.CM_ProductionGridControl.TabIndex = 0
        Me.CM_ProductionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CM_ProductionBindingSource
        '
        Me.CM_ProductionBindingSource.DataMember = "CM_Production"
        Me.CM_ProductionBindingSource.DataSource = Me.CuttingMakingDataSet
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleId, Me.colStyleName1, Me.colLayoutId, Me.colSewingLayoutNo, Me.colMachineQuantity, Me.colOutputQuantity, Me.colWorkingHour, Me.colTotalTargetQuantity, Me.colOutputPerHour, Me.colOutputPerMachine, Me.colTargetOutputPerMachine, Me.colMCCost_PRESENT, Me.colCMTargetWastage, Me.colMCCost_PREVIOUS, Me.colCM_PREVIOUS, Me.colCM_PRESENT, Me.colMinSewingDate, Me.colMaxSewingDate})
        Me.GridView1.GridControl = Me.CM_ProductionGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSewingLayoutNo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colStyleId
        '
        Me.colStyleId.AppearanceHeader.Options.UseTextOptions = True
        Me.colStyleId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStyleId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        Me.colStyleId.OptionsColumn.AllowEdit = False
        Me.colStyleId.OptionsColumn.ReadOnly = True
        '
        'colStyleName1
        '
        Me.colStyleName1.AppearanceHeader.Options.UseTextOptions = True
        Me.colStyleName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStyleName1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyleName1.FieldName = "StyleName"
        Me.colStyleName1.Name = "colStyleName1"
        Me.colStyleName1.OptionsColumn.AllowEdit = False
        Me.colStyleName1.OptionsColumn.ReadOnly = True
        Me.colStyleName1.Width = 96
        '
        'colLayoutId
        '
        Me.colLayoutId.AppearanceHeader.Options.UseTextOptions = True
        Me.colLayoutId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLayoutId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLayoutId.FieldName = "LayoutId"
        Me.colLayoutId.Name = "colLayoutId"
        Me.colLayoutId.OptionsColumn.AllowEdit = False
        Me.colLayoutId.OptionsColumn.ReadOnly = True
        Me.colLayoutId.Width = 99
        '
        'colSewingLayoutNo
        '
        Me.colSewingLayoutNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSewingLayoutNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSewingLayoutNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSewingLayoutNo.FieldName = "SewingLayoutNo"
        Me.colSewingLayoutNo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colSewingLayoutNo.Name = "colSewingLayoutNo"
        Me.colSewingLayoutNo.OptionsColumn.AllowEdit = False
        Me.colSewingLayoutNo.OptionsColumn.ReadOnly = True
        Me.colSewingLayoutNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colSewingLayoutNo.Visible = True
        Me.colSewingLayoutNo.VisibleIndex = 0
        Me.colSewingLayoutNo.Width = 72
        '
        'colMachineQuantity
        '
        Me.colMachineQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colMachineQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMachineQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMachineQuantity.DisplayFormat.FormatString = "n2"
        Me.colMachineQuantity.FieldName = "MachineQuantity"
        Me.colMachineQuantity.Name = "colMachineQuantity"
        Me.colMachineQuantity.OptionsColumn.AllowEdit = False
        Me.colMachineQuantity.OptionsColumn.ReadOnly = True
        Me.colMachineQuantity.Visible = True
        Me.colMachineQuantity.VisibleIndex = 3
        Me.colMachineQuantity.Width = 80
        '
        'colOutputQuantity
        '
        Me.colOutputQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colOutputQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOutputQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOutputQuantity.DisplayFormat.FormatString = "n2"
        Me.colOutputQuantity.FieldName = "OutputQuantity"
        Me.colOutputQuantity.Name = "colOutputQuantity"
        Me.colOutputQuantity.OptionsColumn.AllowEdit = False
        Me.colOutputQuantity.OptionsColumn.ReadOnly = True
        Me.colOutputQuantity.Visible = True
        Me.colOutputQuantity.VisibleIndex = 4
        Me.colOutputQuantity.Width = 72
        '
        'colWorkingHour
        '
        Me.colWorkingHour.AppearanceHeader.Options.UseTextOptions = True
        Me.colWorkingHour.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colWorkingHour.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colWorkingHour.DisplayFormat.FormatString = "n2"
        Me.colWorkingHour.FieldName = "WorkingHour"
        Me.colWorkingHour.Name = "colWorkingHour"
        Me.colWorkingHour.OptionsColumn.AllowEdit = False
        Me.colWorkingHour.OptionsColumn.ReadOnly = True
        Me.colWorkingHour.Visible = True
        Me.colWorkingHour.VisibleIndex = 5
        Me.colWorkingHour.Width = 72
        '
        'colTotalTargetQuantity
        '
        Me.colTotalTargetQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalTargetQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalTargetQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTotalTargetQuantity.DisplayFormat.FormatString = "n2"
        Me.colTotalTargetQuantity.FieldName = "TotalTargetQuantity"
        Me.colTotalTargetQuantity.Name = "colTotalTargetQuantity"
        Me.colTotalTargetQuantity.OptionsColumn.AllowEdit = False
        Me.colTotalTargetQuantity.OptionsColumn.ReadOnly = True
        Me.colTotalTargetQuantity.Visible = True
        Me.colTotalTargetQuantity.VisibleIndex = 6
        Me.colTotalTargetQuantity.Width = 61
        '
        'colOutputPerHour
        '
        Me.colOutputPerHour.AppearanceHeader.Options.UseTextOptions = True
        Me.colOutputPerHour.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOutputPerHour.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOutputPerHour.DisplayFormat.FormatString = "n2"
        Me.colOutputPerHour.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOutputPerHour.FieldName = "OutputPerHour"
        Me.colOutputPerHour.Name = "colOutputPerHour"
        Me.colOutputPerHour.OptionsColumn.AllowEdit = False
        Me.colOutputPerHour.OptionsColumn.ReadOnly = True
        Me.colOutputPerHour.Visible = True
        Me.colOutputPerHour.VisibleIndex = 7
        Me.colOutputPerHour.Width = 79
        '
        'colOutputPerMachine
        '
        Me.colOutputPerMachine.AppearanceHeader.Options.UseTextOptions = True
        Me.colOutputPerMachine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOutputPerMachine.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOutputPerMachine.DisplayFormat.FormatString = "n2"
        Me.colOutputPerMachine.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOutputPerMachine.FieldName = "OutputPerMachine"
        Me.colOutputPerMachine.Name = "colOutputPerMachine"
        Me.colOutputPerMachine.OptionsColumn.AllowEdit = False
        Me.colOutputPerMachine.OptionsColumn.ReadOnly = True
        Me.colOutputPerMachine.Visible = True
        Me.colOutputPerMachine.VisibleIndex = 8
        Me.colOutputPerMachine.Width = 92
        '
        'colTargetOutputPerMachine
        '
        Me.colTargetOutputPerMachine.AppearanceHeader.Options.UseTextOptions = True
        Me.colTargetOutputPerMachine.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTargetOutputPerMachine.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTargetOutputPerMachine.DisplayFormat.FormatString = "n2"
        Me.colTargetOutputPerMachine.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTargetOutputPerMachine.FieldName = "TargetOutputPerMachine"
        Me.colTargetOutputPerMachine.Name = "colTargetOutputPerMachine"
        Me.colTargetOutputPerMachine.OptionsColumn.AllowEdit = False
        Me.colTargetOutputPerMachine.OptionsColumn.ReadOnly = True
        Me.colTargetOutputPerMachine.Visible = True
        Me.colTargetOutputPerMachine.VisibleIndex = 9
        Me.colTargetOutputPerMachine.Width = 62
        '
        'colMCCost_PRESENT
        '
        Me.colMCCost_PRESENT.AppearanceHeader.Options.UseTextOptions = True
        Me.colMCCost_PRESENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMCCost_PRESENT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMCCost_PRESENT.Caption = "MC Cost [Present]"
        Me.colMCCost_PRESENT.DisplayFormat.FormatString = "n2"
        Me.colMCCost_PRESENT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMCCost_PRESENT.FieldName = "MCCost_PRESENT"
        Me.colMCCost_PRESENT.Name = "colMCCost_PRESENT"
        Me.colMCCost_PRESENT.OptionsColumn.AllowEdit = False
        Me.colMCCost_PRESENT.OptionsColumn.ReadOnly = True
        Me.colMCCost_PRESENT.Visible = True
        Me.colMCCost_PRESENT.VisibleIndex = 12
        Me.colMCCost_PRESENT.Width = 53
        '
        'colCMTargetWastage
        '
        Me.colCMTargetWastage.AppearanceHeader.Options.UseTextOptions = True
        Me.colCMTargetWastage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCMTargetWastage.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCMTargetWastage.DisplayFormat.FormatString = "n2"
        Me.colCMTargetWastage.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCMTargetWastage.FieldName = "CMTargetWastage"
        Me.colCMTargetWastage.Name = "colCMTargetWastage"
        Me.colCMTargetWastage.OptionsColumn.AllowEdit = False
        Me.colCMTargetWastage.OptionsColumn.ReadOnly = True
        Me.colCMTargetWastage.Visible = True
        Me.colCMTargetWastage.VisibleIndex = 10
        Me.colCMTargetWastage.Width = 58
        '
        'colMCCost_PREVIOUS
        '
        Me.colMCCost_PREVIOUS.AppearanceHeader.Options.UseTextOptions = True
        Me.colMCCost_PREVIOUS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMCCost_PREVIOUS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMCCost_PREVIOUS.Caption = "MC Cost [Previous]"
        Me.colMCCost_PREVIOUS.DisplayFormat.FormatString = "n2"
        Me.colMCCost_PREVIOUS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMCCost_PREVIOUS.FieldName = "MCCost_PREVIOUS"
        Me.colMCCost_PREVIOUS.Name = "colMCCost_PREVIOUS"
        Me.colMCCost_PREVIOUS.OptionsColumn.AllowEdit = False
        Me.colMCCost_PREVIOUS.OptionsColumn.ReadOnly = True
        Me.colMCCost_PREVIOUS.Visible = True
        Me.colMCCost_PREVIOUS.VisibleIndex = 11
        Me.colMCCost_PREVIOUS.Width = 44
        '
        'colCM_PREVIOUS
        '
        Me.colCM_PREVIOUS.AppearanceHeader.Options.UseTextOptions = True
        Me.colCM_PREVIOUS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCM_PREVIOUS.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCM_PREVIOUS.Caption = "CM PREVIOUS"
        Me.colCM_PREVIOUS.DisplayFormat.FormatString = "n2"
        Me.colCM_PREVIOUS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCM_PREVIOUS.FieldName = "CM_PREVIOUS"
        Me.colCM_PREVIOUS.Name = "colCM_PREVIOUS"
        Me.colCM_PREVIOUS.OptionsColumn.AllowEdit = False
        Me.colCM_PREVIOUS.OptionsColumn.ReadOnly = True
        Me.colCM_PREVIOUS.Visible = True
        Me.colCM_PREVIOUS.VisibleIndex = 13
        Me.colCM_PREVIOUS.Width = 57
        '
        'colCM_PRESENT
        '
        Me.colCM_PRESENT.AppearanceHeader.Options.UseTextOptions = True
        Me.colCM_PRESENT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCM_PRESENT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCM_PRESENT.Caption = "CM PRESENT"
        Me.colCM_PRESENT.DisplayFormat.FormatString = "n2"
        Me.colCM_PRESENT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCM_PRESENT.FieldName = "CM_PRESENT"
        Me.colCM_PRESENT.Name = "colCM_PRESENT"
        Me.colCM_PRESENT.OptionsColumn.AllowEdit = False
        Me.colCM_PRESENT.OptionsColumn.ReadOnly = True
        Me.colCM_PRESENT.Visible = True
        Me.colCM_PRESENT.VisibleIndex = 14
        Me.colCM_PRESENT.Width = 69
        '
        'colMinSewingDate
        '
        Me.colMinSewingDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colMinSewingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMinSewingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMinSewingDate.Caption = "From Date"
        Me.colMinSewingDate.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.colMinSewingDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colMinSewingDate.FieldName = "MinSewingDate"
        Me.colMinSewingDate.Name = "colMinSewingDate"
        Me.colMinSewingDate.Visible = True
        Me.colMinSewingDate.VisibleIndex = 1
        Me.colMinSewingDate.Width = 69
        '
        'colMaxSewingDate
        '
        Me.colMaxSewingDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaxSewingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaxSewingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMaxSewingDate.Caption = "To Date"
        Me.colMaxSewingDate.DisplayFormat.FormatString = "dd-MMM-yy"
        Me.colMaxSewingDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colMaxSewingDate.FieldName = "MaxSewingDate"
        Me.colMaxSewingDate.Name = "colMaxSewingDate"
        Me.colMaxSewingDate.Visible = True
        Me.colMaxSewingDate.VisibleIndex = 2
        Me.colMaxSewingDate.Width = 67
        '
        'CuttingMakingTableAdapter
        '
        Me.CuttingMakingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CuttingMakingTableAdapter = Me.CuttingMakingTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.CuttingMakingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CM_FirstLayoutTableAdapter
        '
        Me.CM_FirstLayoutTableAdapter.ClearBeforeFill = True
        '
        'CM_ProductionTableAdapter
        '
        Me.CM_ProductionTableAdapter.ClearBeforeFill = True
        '
        'StyleLookupBindingSource
        '
        Me.StyleLookupBindingSource.DataMember = "StyleLookup"
        Me.StyleLookupBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupTableAdapter
        '
        Me.StyleLookupTableAdapter.ClearBeforeFill = True
        '
        'KnittingTypeDataSet
        '
        Me.KnittingTypeDataSet.DataSetName = "KnittingTypeDataSet"
        Me.KnittingTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KnittingTypeBindingSource
        '
        Me.KnittingTypeBindingSource.DataMember = "KnittingType"
        Me.KnittingTypeBindingSource.DataSource = Me.KnittingTypeDataSet
        '
        'KnittingTypeTableAdapter
        '
        Me.KnittingTypeTableAdapter.ClearBeforeFill = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CuttingMakingGridControl)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(990, 205)
        Me.GroupControl1.TabIndex = 62
        Me.GroupControl1.Text = "Buyer CM"
        '
        'CuttingMakingGridControl
        '
        Me.CuttingMakingGridControl.DataSource = Me.CuttingMakingBindingSource
        Me.CuttingMakingGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CuttingMakingGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.CuttingMakingGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.CuttingMakingGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.CuttingMakingGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.CuttingMakingGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.CuttingMakingGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.CuttingMakingGridControl.Location = New System.Drawing.Point(2, 22)
        Me.CuttingMakingGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.CuttingMakingGridControl.MainView = Me.GridView2
        Me.CuttingMakingGridControl.Name = "CuttingMakingGridControl"
        Me.CuttingMakingGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GSMLookUpEdit, Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.CompositionGridLookUpEdit, Me.KnittingTypeGridLookUpEdit, Me.BuyerGridLookUpEdit, Me.DivisionGridLookUpEdit, Me.GMDescriptionItemMemoEdit, Me.PictureEdit})
        Me.CuttingMakingGridControl.Size = New System.Drawing.Size(986, 181)
        Me.CuttingMakingGridControl.TabIndex = 0
        Me.CuttingMakingGridControl.UseEmbeddedNavigator = True
        Me.CuttingMakingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleId2, Me.colCostingCM, Me.colCompositionId, Me.colKnittingTypeId1, Me.colGSM, Me.colDia, Me.colBuyerId1, Me.colDivisionId, Me.colGMDescription, Me.colIsAOP, Me.colIsBrush, Me.colIsEmbroidery, Me.colIsPeachFinish, Me.colIsPrint, Me.colIsWash, Me.colIsYDS, Me.colPicture, Me.colStyleType})
        Me.GridView2.GridControl = Me.CuttingMakingGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.RowHeight = 40
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGSM, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colStyleId2
        '
        Me.colStyleId2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colStyleId2.AppearanceCell.Options.UseBackColor = True
        Me.colStyleId2.Caption = "Style"
        Me.colStyleId2.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colStyleId2.FieldName = "StyleId"
        Me.colStyleId2.Name = "colStyleId2"
        Me.colStyleId2.OptionsColumn.AllowEdit = False
        Me.colStyleId2.OptionsColumn.ReadOnly = True
        Me.colStyleId2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colStyleId2.Visible = True
        Me.colStyleId2.VisibleIndex = 0
        Me.colStyleId2.Width = 143
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.StyleBindingSource1
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "StyleName"
        Me.RepositoryItemGridLookUpEdit1.ImmediatePopup = True
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.NullText = ""
        Me.RepositoryItemGridLookUpEdit1.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "StyleId"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'StyleBindingSource1
        '
        Me.StyleBindingSource1.DataMember = "Style"
        Me.StyleBindingSource1.DataSource = Me.StyleLookupDataSet
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleId3, Me.colStyleName2, Me.colBuyerId, Me.colDefaultTarget, Me.colSMV})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colStyleId3
        '
        Me.colStyleId3.FieldName = "StyleId"
        Me.colStyleId3.Name = "colStyleId3"
        Me.colStyleId3.OptionsColumn.ReadOnly = True
        Me.colStyleId3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colStyleName2
        '
        Me.colStyleName2.FieldName = "StyleName"
        Me.colStyleName2.Name = "colStyleName2"
        Me.colStyleName2.Visible = True
        Me.colStyleName2.VisibleIndex = 0
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colDefaultTarget
        '
        Me.colDefaultTarget.FieldName = "DefaultTarget"
        Me.colDefaultTarget.Name = "colDefaultTarget"
        Me.colDefaultTarget.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colSMV
        '
        Me.colSMV.FieldName = "SMV"
        Me.colSMV.Name = "colSMV"
        Me.colSMV.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colCostingCM
        '
        Me.colCostingCM.FieldName = "CostingCM"
        Me.colCostingCM.Name = "colCostingCM"
        Me.colCostingCM.Visible = True
        Me.colCostingCM.VisibleIndex = 1
        '
        'colCompositionId
        '
        Me.colCompositionId.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCompositionId.AppearanceCell.Options.UseBackColor = True
        Me.colCompositionId.Caption = "Composition"
        Me.colCompositionId.ColumnEdit = Me.CompositionGridLookUpEdit
        Me.colCompositionId.FieldName = "CompositionId"
        Me.colCompositionId.Name = "colCompositionId"
        Me.colCompositionId.OptionsColumn.AllowEdit = False
        Me.colCompositionId.OptionsColumn.ReadOnly = True
        Me.colCompositionId.Visible = True
        Me.colCompositionId.VisibleIndex = 4
        Me.colCompositionId.Width = 99
        '
        'CompositionGridLookUpEdit
        '
        Me.CompositionGridLookUpEdit.AutoHeight = False
        Me.CompositionGridLookUpEdit.DataSource = Me.CompositionBindingSource
        Me.CompositionGridLookUpEdit.DisplayMember = "Composition"
        Me.CompositionGridLookUpEdit.Name = "CompositionGridLookUpEdit"
        Me.CompositionGridLookUpEdit.NullText = ""
        Me.CompositionGridLookUpEdit.ValueMember = "CompositionId"
        Me.CompositionGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit3View
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
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colKnittingTypeId1
        '
        Me.colKnittingTypeId1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colKnittingTypeId1.AppearanceCell.Options.UseBackColor = True
        Me.colKnittingTypeId1.Caption = "Fabric Type"
        Me.colKnittingTypeId1.ColumnEdit = Me.KnittingTypeGridLookUpEdit
        Me.colKnittingTypeId1.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId1.Name = "colKnittingTypeId1"
        Me.colKnittingTypeId1.OptionsColumn.AllowEdit = False
        Me.colKnittingTypeId1.OptionsColumn.ReadOnly = True
        Me.colKnittingTypeId1.Visible = True
        Me.colKnittingTypeId1.VisibleIndex = 5
        Me.colKnittingTypeId1.Width = 92
        '
        'KnittingTypeGridLookUpEdit
        '
        Me.KnittingTypeGridLookUpEdit.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KnittingTypeGridLookUpEdit.Appearance.Options.UseBackColor = True
        Me.KnittingTypeGridLookUpEdit.AutoHeight = False
        Me.KnittingTypeGridLookUpEdit.DataSource = Me.KnittingTypeBindingSource
        Me.KnittingTypeGridLookUpEdit.DisplayMember = "KnittingType"
        Me.KnittingTypeGridLookUpEdit.Name = "KnittingTypeGridLookUpEdit"
        Me.KnittingTypeGridLookUpEdit.NullText = ""
        Me.KnittingTypeGridLookUpEdit.ValueMember = "KnittingTypeId"
        Me.KnittingTypeGridLookUpEdit.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
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
        Me.colGSM.VisibleIndex = 6
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
        Me.colDia.VisibleIndex = 7
        Me.colDia.Width = 51
        '
        'GSMLookUpEdit
        '
        Me.GSMLookUpEdit.AutoHeight = False
        Me.GSMLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GSMLookUpEdit.DataSource = Me.GSMBindingSource
        Me.GSMLookUpEdit.DisplayMember = "GSM"
        Me.GSMLookUpEdit.Name = "GSMLookUpEdit"
        Me.GSMLookUpEdit.NullText = ""
        Me.GSMLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.GSMLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GSMLookUpEdit.ValueMember = "GSMId"
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.KnittingTypeBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "KnittingType"
        Me.RepositoryItemGridLookUpEdit2.ImmediatePopup = True
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RepositoryItemGridLookUpEdit2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemGridLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "KnittingTypeId"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKnittingTypeId, Me.colKnittingTypeCode, Me.colKnittingType})
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colKnittingTypeId
        '
        Me.colKnittingTypeId.FieldName = "KnittingTypeId"
        Me.colKnittingTypeId.Name = "colKnittingTypeId"
        Me.colKnittingTypeId.OptionsColumn.ReadOnly = True
        '
        'colKnittingTypeCode
        '
        Me.colKnittingTypeCode.FieldName = "KnittingTypeCode"
        Me.colKnittingTypeCode.Name = "colKnittingTypeCode"
        '
        'colKnittingType
        '
        Me.colKnittingType.FieldName = "KnittingType"
        Me.colKnittingType.Name = "colKnittingType"
        Me.colKnittingType.Visible = True
        Me.colKnittingType.VisibleIndex = 0
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.ForeColor = System.Drawing.Color.Red
        Me.MessageLabel.Location = New System.Drawing.Point(817, 8)
        Me.MessageLabel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(56, 13)
        Me.MessageLabel.TabIndex = 62
        Me.MessageLabel.Text = "Message :"
        '
        'NewLinkLabel
        '
        Me.NewLinkLabel.AutoSize = True
        Me.NewLinkLabel.Location = New System.Drawing.Point(13, 7)
        Me.NewLinkLabel.Margin = New System.Windows.Forms.Padding(13, 5, 5, 5)
        Me.NewLinkLabel.Name = "NewLinkLabel"
        Me.NewLinkLabel.Size = New System.Drawing.Size(26, 13)
        Me.NewLinkLabel.TabIndex = 62
        Me.NewLinkLabel.TabStop = True
        Me.NewLinkLabel.Text = "Add"
        Me.NewLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NewLinkLabel.Visible = False
        '
        'EditLinkLabel
        '
        Me.EditLinkLabel.AutoSize = True
        Me.EditLinkLabel.Location = New System.Drawing.Point(57, 7)
        Me.EditLinkLabel.Margin = New System.Windows.Forms.Padding(13, 5, 5, 5)
        Me.EditLinkLabel.Name = "EditLinkLabel"
        Me.EditLinkLabel.Size = New System.Drawing.Size(25, 13)
        Me.EditLinkLabel.TabIndex = 63
        Me.EditLinkLabel.TabStop = True
        Me.EditLinkLabel.Text = "Edit"
        Me.EditLinkLabel.Visible = False
        '
        'CancelLinkLabel
        '
        Me.CancelLinkLabel.AutoSize = True
        Me.CancelLinkLabel.Location = New System.Drawing.Point(95, 7)
        Me.CancelLinkLabel.Margin = New System.Windows.Forms.Padding(8, 5, 5, 5)
        Me.CancelLinkLabel.Name = "CancelLinkLabel"
        Me.CancelLinkLabel.Size = New System.Drawing.Size(40, 13)
        Me.CancelLinkLabel.TabIndex = 64
        Me.CancelLinkLabel.TabStop = True
        Me.CancelLinkLabel.Text = "Cancel"
        Me.CancelLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CancelLinkLabel.Visible = False
        '
        'DeleteLinkLabel
        '
        Me.DeleteLinkLabel.AutoSize = True
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(149, 7)
        Me.DeleteLinkLabel.Margin = New System.Windows.Forms.Padding(9, 5, 5, 5)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(38, 13)
        Me.DeleteLinkLabel.TabIndex = 65
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "Delete"
        Me.DeleteLinkLabel.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.NewLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.EditLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteLinkLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.SaveButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.StyleLookupGridLookUpEdit)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.MessageLabel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(990, 30)
        Me.FlowLayoutPanel1.TabIndex = 63
        '
        'SaveButton
        '
        Me.SaveButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Save_icon
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(195, 3)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.SaveButton.Size = New System.Drawing.Size(121, 23)
        Me.SaveButton.TabIndex = 67
        Me.SaveButton.Text = "&Save All"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(611, 3)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "Show by Style"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 3)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Show All Style"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 30)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(990, 435)
        Me.SplitContainer1.SplitterDistance = 205
        Me.SplitContainer1.TabIndex = 64
        '
        'CompositionTableAdapter
        '
        Me.CompositionTableAdapter.ClearBeforeFill = True
        '
        'colBuyerId1
        '
        Me.colBuyerId1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colBuyerId1.AppearanceCell.Options.UseBackColor = True
        Me.colBuyerId1.Caption = "Buyer"
        Me.colBuyerId1.ColumnEdit = Me.BuyerGridLookUpEdit
        Me.colBuyerId1.FieldName = "BuyerId"
        Me.colBuyerId1.Name = "colBuyerId1"
        Me.colBuyerId1.OptionsColumn.AllowEdit = False
        Me.colBuyerId1.OptionsColumn.ReadOnly = True
        Me.colBuyerId1.Visible = True
        Me.colBuyerId1.VisibleIndex = 8
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BuyerGridLookUpEdit.Appearance.Options.UseBackColor = True
        Me.BuyerGridLookUpEdit.AutoHeight = False
        Me.BuyerGridLookUpEdit.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.DisplayMember = "BuyerCode"
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.NullText = ""
        Me.BuyerGridLookUpEdit.ValueMember = "BuyerId"
        Me.BuyerGridLookUpEdit.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
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
        Me.colDivisionId.VisibleIndex = 9
        '
        'DivisionGridLookUpEdit
        '
        Me.DivisionGridLookUpEdit.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DivisionGridLookUpEdit.Appearance.Options.UseBackColor = True
        Me.DivisionGridLookUpEdit.AutoHeight = False
        Me.DivisionGridLookUpEdit.DataSource = Me.DivisionBindingSource
        Me.DivisionGridLookUpEdit.DisplayMember = "DivisionName"
        Me.DivisionGridLookUpEdit.Name = "DivisionGridLookUpEdit"
        Me.DivisionGridLookUpEdit.NullText = ""
        Me.DivisionGridLookUpEdit.ValueMember = "DivisionId"
        Me.DivisionGridLookUpEdit.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'DivisionDataSet
        '
        Me.DivisionDataSet.DataSetName = "DivisionDataSet"
        Me.DivisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DivisionBindingSource
        '
        Me.DivisionBindingSource.DataMember = "Division"
        Me.DivisionBindingSource.DataSource = Me.DivisionDataSet
        '
        'DivisionTableAdapter
        '
        Me.DivisionTableAdapter.ClearBeforeFill = True
        '
        'colGMDescription
        '
        Me.colGMDescription.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colGMDescription.AppearanceCell.Options.UseBackColor = True
        Me.colGMDescription.ColumnEdit = Me.GMDescriptionItemMemoEdit
        Me.colGMDescription.FieldName = "GMDescription"
        Me.colGMDescription.Name = "colGMDescription"
        Me.colGMDescription.OptionsColumn.AllowEdit = False
        Me.colGMDescription.OptionsColumn.ReadOnly = True
        Me.colGMDescription.Visible = True
        Me.colGMDescription.VisibleIndex = 10
        Me.colGMDescription.Width = 92
        '
        'GMDescriptionItemMemoEdit
        '
        Me.GMDescriptionItemMemoEdit.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GMDescriptionItemMemoEdit.Appearance.Options.UseBackColor = True
        Me.GMDescriptionItemMemoEdit.Name = "GMDescriptionItemMemoEdit"
        '
        'colIsAOP
        '
        Me.colIsAOP.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsAOP.AppearanceCell.Options.UseBackColor = True
        Me.colIsAOP.FieldName = "IsAOP"
        Me.colIsAOP.Name = "colIsAOP"
        Me.colIsAOP.OptionsColumn.AllowEdit = False
        Me.colIsAOP.OptionsColumn.ReadOnly = True
        Me.colIsAOP.Visible = True
        Me.colIsAOP.VisibleIndex = 11
        '
        'colIsBrush
        '
        Me.colIsBrush.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsBrush.AppearanceCell.Options.UseBackColor = True
        Me.colIsBrush.FieldName = "IsBrush"
        Me.colIsBrush.Name = "colIsBrush"
        Me.colIsBrush.OptionsColumn.AllowEdit = False
        Me.colIsBrush.OptionsColumn.ReadOnly = True
        Me.colIsBrush.Visible = True
        Me.colIsBrush.VisibleIndex = 12
        '
        'colIsEmbroidery
        '
        Me.colIsEmbroidery.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsEmbroidery.AppearanceCell.Options.UseBackColor = True
        Me.colIsEmbroidery.FieldName = "IsEmbroidery"
        Me.colIsEmbroidery.Name = "colIsEmbroidery"
        Me.colIsEmbroidery.OptionsColumn.AllowEdit = False
        Me.colIsEmbroidery.OptionsColumn.ReadOnly = True
        Me.colIsEmbroidery.Visible = True
        Me.colIsEmbroidery.VisibleIndex = 13
        '
        'colIsPeachFinish
        '
        Me.colIsPeachFinish.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsPeachFinish.AppearanceCell.Options.UseBackColor = True
        Me.colIsPeachFinish.FieldName = "IsPeachFinish"
        Me.colIsPeachFinish.Name = "colIsPeachFinish"
        Me.colIsPeachFinish.OptionsColumn.AllowEdit = False
        Me.colIsPeachFinish.OptionsColumn.ReadOnly = True
        Me.colIsPeachFinish.Visible = True
        Me.colIsPeachFinish.VisibleIndex = 14
        '
        'colIsPrint
        '
        Me.colIsPrint.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsPrint.AppearanceCell.Options.UseBackColor = True
        Me.colIsPrint.FieldName = "IsPrint"
        Me.colIsPrint.Name = "colIsPrint"
        Me.colIsPrint.OptionsColumn.AllowEdit = False
        Me.colIsPrint.OptionsColumn.ReadOnly = True
        Me.colIsPrint.Visible = True
        Me.colIsPrint.VisibleIndex = 15
        '
        'colIsWash
        '
        Me.colIsWash.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsWash.AppearanceCell.Options.UseBackColor = True
        Me.colIsWash.FieldName = "IsWash"
        Me.colIsWash.Name = "colIsWash"
        Me.colIsWash.OptionsColumn.AllowEdit = False
        Me.colIsWash.OptionsColumn.ReadOnly = True
        Me.colIsWash.Visible = True
        Me.colIsWash.VisibleIndex = 16
        '
        'colIsYDS
        '
        Me.colIsYDS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsYDS.AppearanceCell.Options.UseBackColor = True
        Me.colIsYDS.FieldName = "IsYDS"
        Me.colIsYDS.Name = "colIsYDS"
        Me.colIsYDS.OptionsColumn.AllowEdit = False
        Me.colIsYDS.OptionsColumn.ReadOnly = True
        Me.colIsYDS.Visible = True
        Me.colIsYDS.VisibleIndex = 17
        '
        'colPicture
        '
        Me.colPicture.ColumnEdit = Me.PictureEdit
        Me.colPicture.FieldName = "Picture"
        Me.colPicture.Name = "colPicture"
        Me.colPicture.OptionsColumn.AllowEdit = False
        Me.colPicture.OptionsColumn.ReadOnly = True
        Me.colPicture.Visible = True
        Me.colPicture.VisibleIndex = 3
        '
        'colStyleType
        '
        Me.colStyleType.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colStyleType.AppearanceCell.Options.UseBackColor = True
        Me.colStyleType.FieldName = "StyleType"
        Me.colStyleType.Name = "colStyleType"
        Me.colStyleType.OptionsColumn.AllowEdit = False
        Me.colStyleType.OptionsColumn.ReadOnly = True
        Me.colStyleType.Visible = True
        Me.colStyleType.VisibleIndex = 2
        '
        'PictureEdit
        '
        Me.PictureEdit.Name = "PictureEdit"
        Me.PictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'frmCuttingMaking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 465)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frmCuttingMaking"
        Me.Text = "Stylewise CM Price List"
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingMakingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuttingMakingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.StyleNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM_FirstLayoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TargetQuantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCCost_PREVIOUSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionPerMachineSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MCost_PRESENTSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM_PREVIOUSSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM_PRESENTSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM_BUYERSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM_PRODUCTIONSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.CM_ProductionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CM_ProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.CuttingMakingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnittingTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSMLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMDescriptionItemMemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CuttingMakingDataSet As KSoft_Apparel.CuttingMakingDataSet
    Friend WithEvents CuttingMakingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuttingMakingTableAdapter As KSoft_Apparel.CuttingMakingDataSetTableAdapters.CuttingMakingTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.CuttingMakingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents GSMDataSet As KSoft_Apparel.GSMDataSet
    Friend WithEvents GSMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GSMTableAdapter As KSoft_Apparel.GSMDataSetTableAdapters.GSMTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StyleLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CM_FirstLayoutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CM_FirstLayoutTableAdapter As KSoft_Apparel.CuttingMakingDataSetTableAdapters.CM_FirstLayoutTableAdapter
    Friend WithEvents MachineQuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TargetQuantitySpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents MCCost_PREVIOUSSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ProductionPerMachineSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents MCost_PRESENTSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CM_PREVIOUSSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CM_PRESENTSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CM_BUYERSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CM_PRODUCTIONSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CM_ProductionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CM_ProductionTableAdapter As KSoft_Apparel.CuttingMakingDataSetTableAdapters.CM_ProductionTableAdapter
    Friend WithEvents CM_ProductionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLayoutId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingLayoutNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachineQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutputQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkingHour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalTargetQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutputPerHour As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOutputPerMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTargetOutputPerMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMCCost_PRESENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCMTargetWastage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMCCost_PREVIOUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCM_PREVIOUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCM_PRESENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleLookupTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter
    Friend WithEvents KnittingTypeDataSet As KSoft_Apparel.KnittingTypeDataSet
    Friend WithEvents KnittingTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnittingTypeTableAdapter As KSoft_Apparel.KnittingTypeDataSetTableAdapters.KnittingTypeTableAdapter
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents NewLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents EditLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents CancelLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents DeleteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StyleNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents CuttingMakingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents colMinSewingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaxSewingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSMLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colStyleId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents StyleBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultTarget As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKnittingTypeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingTypeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKnittingType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents colCostingCM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompositionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompositionGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKnittingTypeId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompositionDataSet As KSoft_Apparel.CompositionDataSet
    Friend WithEvents CompositionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompositionTableAdapter As KSoft_Apparel.CompositionDataSetTableAdapters.CompositionTableAdapter
    Friend WithEvents KnittingTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents colDivisionId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DivisionGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DivisionDataSet As KSoft_Apparel.DivisionDataSet
    Friend WithEvents DivisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DivisionTableAdapter As KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter
    Friend WithEvents colGMDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMDescriptionItemMemoEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colIsAOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsBrush As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsEmbroidery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPeachFinish As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsWash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsYDS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPicture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureEdit As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colStyleType As DevExpress.XtraGrid.Columns.GridColumn
End Class
