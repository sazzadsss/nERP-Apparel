<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreCostingApproval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreCostingApproval))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CauseofRemrksTextBox = New System.Windows.Forms.TextBox()
        Me.AccessoriesWorkOrderSheetBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ShowAWSToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SendBudgetToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BACancelButton = New System.Windows.Forms.Button()
        Me.AccessoriesWorkOrderSheetGridControl = New DevExpress.XtraGrid.GridControl()
        Me.CostingApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreCostingApprovalDataSet = New KSoft_Apparel.PreCostingApprovalDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPreCostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsApproved = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTTLCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOfferPrice0 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOfferPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCauseofCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreCostingNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubmittedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AccBOMGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ApprovedButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CostingApprovalTableAdapter = New KSoft_Apparel.PreCostingApprovalDataSetTableAdapters.CostingApprovalTableAdapter()
        Me.ReviseButton = New System.Windows.Forms.Button()
        CType(Me.AccessoriesWorkOrderSheetBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccessoriesWorkOrderSheetBindingNavigator.SuspendLayout()
        CType(Me.AccessoriesWorkOrderSheetGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostingApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreCostingApprovalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-135, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cause of Cancel"
        '
        'CauseofRemrksTextBox
        '
        Me.CauseofRemrksTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CauseofRemrksTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CauseofRemrksTextBox.Location = New System.Drawing.Point(199, 48)
        Me.CauseofRemrksTextBox.Name = "CauseofRemrksTextBox"
        Me.CauseofRemrksTextBox.Size = New System.Drawing.Size(739, 20)
        Me.CauseofRemrksTextBox.TabIndex = 10
        '
        'AccessoriesWorkOrderSheetBindingNavigator
        '
        Me.AccessoriesWorkOrderSheetBindingNavigator.AddNewItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.CountItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.DeleteItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ShowAWSToolStripButton, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.SendBudgetToolStripButton})
        Me.AccessoriesWorkOrderSheetBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AccessoriesWorkOrderSheetBindingNavigator.MoveFirstItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.MoveLastItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.MoveNextItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.MovePreviousItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.Name = "AccessoriesWorkOrderSheetBindingNavigator"
        Me.AccessoriesWorkOrderSheetBindingNavigator.Padding = New System.Windows.Forms.Padding(0)
        Me.AccessoriesWorkOrderSheetBindingNavigator.PositionItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.Size = New System.Drawing.Size(1258, 33)
        Me.AccessoriesWorkOrderSheetBindingNavigator.TabIndex = 6
        Me.AccessoriesWorkOrderSheetBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.KSoft_Apparel.My.Resources.Resources.Closed_folder
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(111, 30)
        Me.ToolStripButton1.Text = "Show Approved"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.KSoft_Apparel.My.Resources.Resources.Closed_folder
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Padding = New System.Windows.Forms.Padding(5)
        Me.ToolStripButton2.Size = New System.Drawing.Size(113, 30)
        Me.ToolStripButton2.Text = "Show Pending"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.KSoft_Apparel.My.Resources.Resources.Closed_folder
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Padding = New System.Windows.Forms.Padding(5)
        Me.ToolStripButton3.Size = New System.Drawing.Size(105, 30)
        Me.ToolStripButton3.Text = "Show Cancel"
        '
        'ShowAWSToolStripButton
        '
        Me.ShowAWSToolStripButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Wizard
        Me.ShowAWSToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowAWSToolStripButton.Name = "ShowAWSToolStripButton"
        Me.ShowAWSToolStripButton.Padding = New System.Windows.Forms.Padding(5)
        Me.ShowAWSToolStripButton.Size = New System.Drawing.Size(153, 30)
        Me.ShowAWSToolStripButton.Text = "Show Costing/Budget"
        Me.ShowAWSToolStripButton.ToolTipText = "Show Costing"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(123, 30)
        Me.ToolStripButton4.Text = "Print Costing/Budget"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'SendBudgetToolStripButton
        '
        Me.SendBudgetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SendBudgetToolStripButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Button_Refresh_icon
        Me.SendBudgetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SendBudgetToolStripButton.Name = "SendBudgetToolStripButton"
        Me.SendBudgetToolStripButton.Size = New System.Drawing.Size(23, 30)
        Me.SendBudgetToolStripButton.Text = "ToolStripButton"
        '
        'BACancelButton
        '
        Me.BACancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BACancelButton.Location = New System.Drawing.Point(1144, 45)
        Me.BACancelButton.Name = "BACancelButton"
        Me.BACancelButton.Size = New System.Drawing.Size(110, 23)
        Me.BACancelButton.TabIndex = 9
        Me.BACancelButton.Text = "&Cancel"
        Me.BACancelButton.UseVisualStyleBackColor = True
        '
        'AccessoriesWorkOrderSheetGridControl
        '
        Me.AccessoriesWorkOrderSheetGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessoriesWorkOrderSheetGridControl.DataSource = Me.CostingApprovalBindingSource
        Me.AccessoriesWorkOrderSheetGridControl.Location = New System.Drawing.Point(0, 86)
        Me.AccessoriesWorkOrderSheetGridControl.MainView = Me.GridView1
        Me.AccessoriesWorkOrderSheetGridControl.Name = "AccessoriesWorkOrderSheetGridControl"
        Me.AccessoriesWorkOrderSheetGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SupplierGridLookUpEdit, Me.AccBOMGridLookUpEdit})
        Me.AccessoriesWorkOrderSheetGridControl.Size = New System.Drawing.Size(1258, 633)
        Me.AccessoriesWorkOrderSheetGridControl.TabIndex = 7
        Me.AccessoriesWorkOrderSheetGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CostingApprovalBindingSource
        '
        Me.CostingApprovalBindingSource.DataMember = "CostingApproval"
        Me.CostingApprovalBindingSource.DataSource = Me.PreCostingApprovalDataSet
        '
        'PreCostingApprovalDataSet
        '
        Me.PreCostingApprovalDataSet.DataSetName = "PreCostingApprovalDataSet"
        Me.PreCostingApprovalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPreCostingDate, Me.colBuyerName, Me.colStyleName, Me.colProgramNo, Me.colIsApproved, Me.colTTLCost, Me.colOfferPrice0, Me.colApprovedOn, Me.colOfferPrice, Me.colCauseofCancel, Me.colPreCostingNo, Me.colIsCancel, Me.colIsComplete, Me.colSubmittedBy, Me.colApprovedBy, Me.colAmendmentNo, Me.colRemarks, Me.colComments})
        Me.GridView1.GridControl = Me.AccessoriesWorkOrderSheetGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colPreCostingDate
        '
        Me.colPreCostingDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colPreCostingDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPreCostingDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colPreCostingDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPreCostingDate.Caption = "Costing/Budget Date"
        Me.colPreCostingDate.FieldName = "PreCostingDate"
        Me.colPreCostingDate.Name = "colPreCostingDate"
        Me.colPreCostingDate.OptionsColumn.AllowEdit = False
        Me.colPreCostingDate.OptionsColumn.ReadOnly = True
        Me.colPreCostingDate.Visible = True
        Me.colPreCostingDate.VisibleIndex = 2
        Me.colPreCostingDate.Width = 86
        '
        'colBuyerName
        '
        Me.colBuyerName.AppearanceHeader.Options.UseTextOptions = True
        Me.colBuyerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBuyerName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colBuyerName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.OptionsColumn.AllowEdit = False
        Me.colBuyerName.OptionsColumn.ReadOnly = True
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 3
        Me.colBuyerName.Width = 64
        '
        'colStyleName
        '
        Me.colStyleName.AppearanceHeader.Options.UseTextOptions = True
        Me.colStyleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStyleName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colStyleName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.OptionsColumn.AllowEdit = False
        Me.colStyleName.OptionsColumn.ReadOnly = True
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 4
        Me.colStyleName.Width = 61
        '
        'colProgramNo
        '
        Me.colProgramNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colProgramNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProgramNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colProgramNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsColumn.AllowEdit = False
        Me.colProgramNo.OptionsColumn.ReadOnly = True
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 5
        Me.colProgramNo.Width = 64
        '
        'colIsApproved
        '
        Me.colIsApproved.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsApproved.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsApproved.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colIsApproved.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsApproved.FieldName = "IsApproved"
        Me.colIsApproved.Name = "colIsApproved"
        Me.colIsApproved.OptionsColumn.AllowEdit = False
        Me.colIsApproved.OptionsColumn.ReadOnly = True
        Me.colIsApproved.Visible = True
        Me.colIsApproved.VisibleIndex = 13
        Me.colIsApproved.Width = 57
        '
        'colTTLCost
        '
        Me.colTTLCost.AppearanceHeader.Options.UseTextOptions = True
        Me.colTTLCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTTLCost.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colTTLCost.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colTTLCost.Caption = "Price/Dz"
        Me.colTTLCost.FieldName = "TTLCost"
        Me.colTTLCost.Name = "colTTLCost"
        Me.colTTLCost.OptionsColumn.AllowEdit = False
        Me.colTTLCost.OptionsColumn.ReadOnly = True
        Me.colTTLCost.Visible = True
        Me.colTTLCost.VisibleIndex = 6
        Me.colTTLCost.Width = 52
        '
        'colOfferPrice0
        '
        Me.colOfferPrice0.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colOfferPrice0.AppearanceCell.Options.UseBackColor = True
        Me.colOfferPrice0.AppearanceHeader.Options.UseTextOptions = True
        Me.colOfferPrice0.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOfferPrice0.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colOfferPrice0.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOfferPrice0.Caption = "FOB"
        Me.colOfferPrice0.FieldName = "OfferPrice0"
        Me.colOfferPrice0.Name = "colOfferPrice0"
        Me.colOfferPrice0.OptionsColumn.AllowEdit = False
        Me.colOfferPrice0.OptionsColumn.ReadOnly = True
        Me.colOfferPrice0.Visible = True
        Me.colOfferPrice0.VisibleIndex = 8
        Me.colOfferPrice0.Width = 36
        '
        'colApprovedOn
        '
        Me.colApprovedOn.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedOn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colApprovedOn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedOn.Caption = "Approved / Cancelled On"
        Me.colApprovedOn.FieldName = "ApprovedOn"
        Me.colApprovedOn.Name = "colApprovedOn"
        Me.colApprovedOn.OptionsColumn.AllowEdit = False
        Me.colApprovedOn.OptionsColumn.ReadOnly = True
        Me.colApprovedOn.Visible = True
        Me.colApprovedOn.VisibleIndex = 16
        '
        'colOfferPrice
        '
        Me.colOfferPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colOfferPrice.AppearanceCell.Options.UseBackColor = True
        Me.colOfferPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colOfferPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOfferPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colOfferPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colOfferPrice.Caption = "Price/Pcs"
        Me.colOfferPrice.FieldName = "OfferPrice"
        Me.colOfferPrice.Name = "colOfferPrice"
        Me.colOfferPrice.OptionsColumn.AllowEdit = False
        Me.colOfferPrice.OptionsColumn.ReadOnly = True
        Me.colOfferPrice.Visible = True
        Me.colOfferPrice.VisibleIndex = 7
        Me.colOfferPrice.Width = 58
        '
        'colCauseofCancel
        '
        Me.colCauseofCancel.AppearanceHeader.Options.UseTextOptions = True
        Me.colCauseofCancel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCauseofCancel.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colCauseofCancel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCauseofCancel.Caption = "Approved / Cancelled Comments"
        Me.colCauseofCancel.FieldName = "CauseofCancel"
        Me.colCauseofCancel.Name = "colCauseofCancel"
        Me.colCauseofCancel.OptionsColumn.AllowEdit = False
        Me.colCauseofCancel.OptionsColumn.ReadOnly = True
        Me.colCauseofCancel.Visible = True
        Me.colCauseofCancel.VisibleIndex = 17
        Me.colCauseofCancel.Width = 108
        '
        'colPreCostingNo
        '
        Me.colPreCostingNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPreCostingNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPreCostingNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colPreCostingNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colPreCostingNo.Caption = "Budget No"
        Me.colPreCostingNo.FieldName = "PreCostingNo"
        Me.colPreCostingNo.Name = "colPreCostingNo"
        Me.colPreCostingNo.OptionsColumn.AllowEdit = False
        Me.colPreCostingNo.OptionsColumn.ReadOnly = True
        Me.colPreCostingNo.Visible = True
        Me.colPreCostingNo.VisibleIndex = 0
        Me.colPreCostingNo.Width = 92
        '
        'colIsCancel
        '
        Me.colIsCancel.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsCancel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsCancel.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colIsCancel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsCancel.FieldName = "IsCancel"
        Me.colIsCancel.Name = "colIsCancel"
        Me.colIsCancel.OptionsColumn.AllowEdit = False
        Me.colIsCancel.OptionsColumn.ReadOnly = True
        Me.colIsCancel.Visible = True
        Me.colIsCancel.VisibleIndex = 15
        Me.colIsCancel.Width = 42
        '
        'colIsComplete
        '
        Me.colIsComplete.AppearanceHeader.Options.UseTextOptions = True
        Me.colIsComplete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIsComplete.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colIsComplete.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colIsComplete.Caption = "Is Submitted By"
        Me.colIsComplete.FieldName = "IsComplete"
        Me.colIsComplete.Name = "colIsComplete"
        Me.colIsComplete.OptionsColumn.AllowEdit = False
        Me.colIsComplete.OptionsColumn.ReadOnly = True
        Me.colIsComplete.Visible = True
        Me.colIsComplete.VisibleIndex = 9
        Me.colIsComplete.Width = 76
        '
        'colSubmittedBy
        '
        Me.colSubmittedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubmittedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubmittedBy.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colSubmittedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSubmittedBy.FieldName = "SubmittedBy"
        Me.colSubmittedBy.Name = "colSubmittedBy"
        Me.colSubmittedBy.OptionsColumn.AllowEdit = False
        Me.colSubmittedBy.OptionsColumn.ReadOnly = True
        Me.colSubmittedBy.Visible = True
        Me.colSubmittedBy.VisibleIndex = 10
        Me.colSubmittedBy.Width = 69
        '
        'colApprovedBy
        '
        Me.colApprovedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.colApprovedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApprovedBy.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colApprovedBy.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colApprovedBy.FieldName = "ApprovedBy"
        Me.colApprovedBy.Name = "colApprovedBy"
        Me.colApprovedBy.OptionsColumn.AllowEdit = False
        Me.colApprovedBy.OptionsColumn.ReadOnly = True
        Me.colApprovedBy.Visible = True
        Me.colApprovedBy.VisibleIndex = 14
        Me.colApprovedBy.Width = 66
        '
        'colAmendmentNo
        '
        Me.colAmendmentNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmendmentNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmendmentNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colAmendmentNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAmendmentNo.Caption = "Revision No"
        Me.colAmendmentNo.FieldName = "AmendmentNo"
        Me.colAmendmentNo.Name = "colAmendmentNo"
        Me.colAmendmentNo.Visible = True
        Me.colAmendmentNo.VisibleIndex = 1
        Me.colAmendmentNo.Width = 68
        '
        'colRemarks
        '
        Me.colRemarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colRemarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colRemarks.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRemarks.Caption = "Remarks"
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 12
        Me.colRemarks.Width = 55
        '
        'colComments
        '
        Me.colComments.AppearanceHeader.Options.UseTextOptions = True
        Me.colComments.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComments.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colComments.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colComments.Caption = "Note"
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 11
        Me.colComments.Width = 108
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.AutoHeight = False
        Me.SupplierGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierGridLookUpEdit.DisplayMember = "SupplierCode"
        Me.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit"
        Me.SupplierGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.SupplierGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierGridLookUpEdit.ValueMember = "SupplierId"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'AccBOMGridLookUpEdit
        '
        Me.AccBOMGridLookUpEdit.AutoHeight = False
        Me.AccBOMGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccBOMGridLookUpEdit.DisplayMember = "ProgramNo"
        Me.AccBOMGridLookUpEdit.Name = "AccBOMGridLookUpEdit"
        Me.AccBOMGridLookUpEdit.PopupView = Me.GridView2
        Me.AccBOMGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AccBOMGridLookUpEdit.ValueMember = "AccessoriesBookingId"
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'ApprovedButton
        '
        Me.ApprovedButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApprovedButton.Location = New System.Drawing.Point(944, 45)
        Me.ApprovedButton.Name = "ApprovedButton"
        Me.ApprovedButton.Size = New System.Drawing.Size(94, 23)
        Me.ApprovedButton.TabIndex = 8
        Me.ApprovedButton.Text = "&Approve"
        Me.ApprovedButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Approve / Revise / Cancel Comments:"
        '
        'CostingApprovalTableAdapter
        '
        Me.CostingApprovalTableAdapter.ClearBeforeFill = True
        '
        'ReviseButton
        '
        Me.ReviseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReviseButton.Location = New System.Drawing.Point(1044, 45)
        Me.ReviseButton.Name = "ReviseButton"
        Me.ReviseButton.Size = New System.Drawing.Size(94, 23)
        Me.ReviseButton.TabIndex = 8
        Me.ReviseButton.Text = "&Revise"
        Me.ReviseButton.UseVisualStyleBackColor = True
        '
        'frmPreCostingApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 717)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CauseofRemrksTextBox)
        Me.Controls.Add(Me.AccessoriesWorkOrderSheetBindingNavigator)
        Me.Controls.Add(Me.BACancelButton)
        Me.Controls.Add(Me.AccessoriesWorkOrderSheetGridControl)
        Me.Controls.Add(Me.ReviseButton)
        Me.Controls.Add(Me.ApprovedButton)
        Me.Name = "frmPreCostingApproval"
        Me.Text = "Budget Approval"
        CType(Me.AccessoriesWorkOrderSheetBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccessoriesWorkOrderSheetBindingNavigator.ResumeLayout(False)
        Me.AccessoriesWorkOrderSheetBindingNavigator.PerformLayout()
        CType(Me.AccessoriesWorkOrderSheetGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostingApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreCostingApprovalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CauseofRemrksTextBox As TextBox
    Friend WithEvents AccessoriesWorkOrderSheetBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ShowAWSToolStripButton As ToolStripButton
    Friend WithEvents BACancelButton As Button
    Friend WithEvents AccessoriesWorkOrderSheetGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AccBOMGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SupplierGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ApprovedButton As Button
    Friend WithEvents colPreCostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsApproved As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTTLCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOfferPrice0 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCauseofCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOfferPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents PreCostingApprovalDataSet As PreCostingApprovalDataSet
    Friend WithEvents CostingApprovalBindingSource As BindingSource
    Friend WithEvents CostingApprovalTableAdapter As PreCostingApprovalDataSetTableAdapters.CostingApprovalTableAdapter
    Friend WithEvents colPreCostingNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubmittedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReviseButton As Button
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SendBudgetToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
