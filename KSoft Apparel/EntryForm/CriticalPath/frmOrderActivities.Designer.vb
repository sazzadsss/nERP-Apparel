<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderActivities
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
        Dim StartDateLabel As System.Windows.Forms.Label
        Dim EndDateLabel As System.Windows.Forms.Label
        Dim ProductionQuantityLabel As System.Windows.Forms.Label
        Dim TaskCommentsLabel As System.Windows.Forms.Label
        Dim OrderQuantityLabel As System.Windows.Forms.Label
        Dim PivotGridFormatRule1 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim FormatRuleTotalTypeSettings1 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
        Dim PivotGridFormatRule2 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim FormatRuleTotalTypeSettings2 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
        Dim PivotGridFormatRule3 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
        Dim FormatConditionRuleExpression3 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim FormatRuleTotalTypeSettings3 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
        Me.fieldES1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.OrderActivitiesViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderActivitiesViewDataSet = New KSoft_Apparel.OrderActivitiesViewDataSet()
        Me.OrderActivitiesViewTableAdapter = New KSoft_Apparel.OrderActivitiesViewDataSetTableAdapters.OrderActivitiesViewTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.OrderActivitiesViewDataSetTableAdapters.TableAdapterManager()
        Me.OrderActivitiesViewGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EditHyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivities = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSlack = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaskComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPOComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsProgramComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaskComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TaskCommentsHyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colOrderQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOffDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EditItemButton = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.OrderQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.OrderActivitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderActivitiesDataSet = New KSoft_Apparel.OrderActivitiesDataSet()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HideButton = New System.Windows.Forms.Button()
        Me.TaskCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.ProductionQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.TaskCompleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.EndDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.StartDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.OrderActivitiesIdLabel2 = New System.Windows.Forms.Label()
        Me.OrderActivitiesPredecessorViewGridControl = New DevExpress.XtraGrid.GridControl()
        Me.OrderActivitiesPredecessorViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderActivitiesId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEX1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivities1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDuration1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colES1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEF1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLS1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLF1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSlack1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStartDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEndDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnit1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaskComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaskComments1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsPOComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsProgramComplete1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOffDay1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldProgramNo1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBuyerName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStyleName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFabricColorName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldActivities1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDuration1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldLF1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSlack1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldStartDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEndDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTaskComplete1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUSERNAME1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDepartmentName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIsPOComplete1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIsProgramComplete1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductionQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTaskComments1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOrderQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOffDay1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEX = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.OrderLookupGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowByPOButton = New System.Windows.Forms.Button()
        Me.ShowPivotButton = New System.Windows.Forms.Button()
        Me.SendMailButton = New System.Windows.Forms.Button()
        Me.ShowAllButton = New System.Windows.Forms.Button()
        Me.AsignedForCheckBox = New System.Windows.Forms.CheckBox()
        Me.AsignedForGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.ToDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FromDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.OrderPOLookupAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPOLookupNewDataSet = New KSoft_Apparel.OrderPOLookupNewDataSet()
        Me.OrderPOLookupAllTableAdapter = New KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter()
        Me.ActivitiesListTableAdapter = New KSoft_Apparel.ActivitiesListDataSetTableAdapters.ActivitiesListTableAdapter()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.OrderActivitiesPredecessorViewTableAdapter = New KSoft_Apparel.OrderActivitiesViewDataSetTableAdapters.OrderActivitiesPredecessorViewTableAdapter()
        Me.OrderActivitiesTableAdapter = New KSoft_Apparel.OrderActivitiesDataSetTableAdapters.OrderActivitiesTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Apparel.OrderActivitiesDataSetTableAdapters.TableAdapterManager()
        Me.ActivitiesListDataSet = New KSoft_Apparel.ActivitiesListDataSet()
        Me.ActivitiesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        StartDateLabel = New System.Windows.Forms.Label()
        EndDateLabel = New System.Windows.Forms.Label()
        ProductionQuantityLabel = New System.Windows.Forms.Label()
        TaskCommentsLabel = New System.Windows.Forms.Label()
        OrderQuantityLabel = New System.Windows.Forms.Label()
        CType(Me.OrderActivitiesViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderActivitiesViewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderActivitiesViewGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditHyperLinkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskCommentsHyperLinkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditItemButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.OrderActivitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderActivitiesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderActivitiesPredecessorViewGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderActivitiesPredecessorViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignedForGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FromDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartDateLabel
        '
        StartDateLabel.AutoSize = True
        StartDateLabel.Location = New System.Drawing.Point(113, 15)
        StartDateLabel.Name = "StartDateLabel"
        StartDateLabel.Size = New System.Drawing.Size(61, 13)
        StartDateLabel.TabIndex = 2
        StartDateLabel.Text = "Start Date:"
        '
        'EndDateLabel
        '
        EndDateLabel.AutoSize = True
        EndDateLabel.Location = New System.Drawing.Point(114, 43)
        EndDateLabel.Name = "EndDateLabel"
        EndDateLabel.Size = New System.Drawing.Size(55, 13)
        EndDateLabel.TabIndex = 4
        EndDateLabel.Text = "End Date:"
        '
        'ProductionQuantityLabel
        '
        ProductionQuantityLabel.AutoSize = True
        ProductionQuantityLabel.Location = New System.Drawing.Point(549, 16)
        ProductionQuantityLabel.Name = "ProductionQuantityLabel"
        ProductionQuantityLabel.Size = New System.Drawing.Size(107, 13)
        ProductionQuantityLabel.TabIndex = 10
        ProductionQuantityLabel.Text = "Production Quantity:"
        '
        'TaskCommentsLabel
        '
        TaskCommentsLabel.AutoSize = True
        TaskCommentsLabel.Location = New System.Drawing.Point(286, 43)
        TaskCommentsLabel.Name = "TaskCommentsLabel"
        TaskCommentsLabel.Size = New System.Drawing.Size(86, 13)
        TaskCommentsLabel.TabIndex = 12
        TaskCommentsLabel.Text = "Task Comments:"
        '
        'OrderQuantityLabel
        '
        OrderQuantityLabel.AutoSize = True
        OrderQuantityLabel.Location = New System.Drawing.Point(286, 16)
        OrderQuantityLabel.Name = "OrderQuantityLabel"
        OrderQuantityLabel.Size = New System.Drawing.Size(84, 13)
        OrderQuantityLabel.TabIndex = 17
        OrderQuantityLabel.Text = "Order Quantity:"
        '
        'fieldES1
        '
        Me.fieldES1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldES1.AreaIndex = 0
        Me.fieldES1.Caption = "Start"
        Me.fieldES1.CellFormat.FormatString = "d"
        Me.fieldES1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldES1.FieldName = "ES"
        Me.fieldES1.Name = "fieldES1"
        Me.fieldES1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min
        Me.fieldES1.Width = 67
        '
        'OrderActivitiesViewBindingSource
        '
        Me.OrderActivitiesViewBindingSource.DataMember = "OrderActivitiesView"
        Me.OrderActivitiesViewBindingSource.DataSource = Me.OrderActivitiesViewDataSet
        '
        'OrderActivitiesViewDataSet
        '
        Me.OrderActivitiesViewDataSet.DataSetName = "OrderActivitiesViewDataSet"
        Me.OrderActivitiesViewDataSet.EnforceConstraints = False
        Me.OrderActivitiesViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderActivitiesViewTableAdapter
        '
        Me.OrderActivitiesViewTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.OrderActivitiesViewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrderActivitiesViewGridControl
        '
        Me.OrderActivitiesViewGridControl.DataSource = Me.OrderActivitiesViewBindingSource
        Me.OrderActivitiesViewGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderActivitiesViewGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderActivitiesViewGridControl.MainView = Me.GridView1
        Me.OrderActivitiesViewGridControl.Name = "OrderActivitiesViewGridControl"
        Me.OrderActivitiesViewGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.EditItemButton, Me.EditHyperLinkEdit, Me.TaskCommentsHyperLinkEdit})
        Me.OrderActivitiesViewGridControl.Size = New System.Drawing.Size(1215, 251)
        Me.OrderActivitiesViewGridControl.TabIndex = 1
        Me.OrderActivitiesViewGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colProgramNo, Me.colBuyerName, Me.colStyleName, Me.colPO, Me.colFabricColorName, Me.colEX, Me.colSL, Me.colActivities, Me.colDuration, Me.colES, Me.colEF, Me.colLS, Me.colSlack, Me.colStartDate, Me.colEndDate, Me.colUnit, Me.colTaskComplete, Me.colUSER_NAME, Me.colDepartmentName, Me.colIsPOComplete, Me.colIsProgramComplete, Me.colProductionQuantity, Me.colTaskComments, Me.colOrderQuantity, Me.colOffDay, Me.colLF})
        Me.GridView1.GridControl = Me.OrderActivitiesViewGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Activity No"
        Me.GridColumn1.ColumnEdit = Me.EditHyperLinkEdit
        Me.GridColumn1.FieldName = "OrderActivitiesId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 74
        '
        'EditHyperLinkEdit
        '
        Me.EditHyperLinkEdit.AutoHeight = False
        Me.EditHyperLinkEdit.Name = "EditHyperLinkEdit"
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsColumn.AllowEdit = False
        Me.colProgramNo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 1
        '
        'colBuyerName
        '
        Me.colBuyerName.Caption = "Buyer"
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.OptionsColumn.AllowEdit = False
        Me.colBuyerName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 2
        '
        'colStyleName
        '
        Me.colStyleName.Caption = "Style"
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.OptionsColumn.AllowEdit = False
        Me.colStyleName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 3
        '
        'colPO
        '
        Me.colPO.FieldName = "PO"
        Me.colPO.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colPO.Name = "colPO"
        Me.colPO.OptionsColumn.AllowEdit = False
        Me.colPO.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.OptionsColumn.AllowEdit = False
        Me.colFabricColorName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colFabricColorName.Width = 105
        '
        'colEX
        '
        Me.colEX.FieldName = "EX"
        Me.colEX.Name = "colEX"
        Me.colEX.OptionsColumn.AllowEdit = False
        Me.colEX.Visible = True
        Me.colEX.VisibleIndex = 4
        Me.colEX.Width = 61
        '
        'colSL
        '
        Me.colSL.FieldName = "SL"
        Me.colSL.Name = "colSL"
        Me.colSL.OptionsColumn.AllowEdit = False
        Me.colSL.Visible = True
        Me.colSL.VisibleIndex = 5
        Me.colSL.Width = 29
        '
        'colActivities
        '
        Me.colActivities.FieldName = "Activities"
        Me.colActivities.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colActivities.Name = "colActivities"
        Me.colActivities.OptionsColumn.AllowEdit = False
        Me.colActivities.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colActivities.Visible = True
        Me.colActivities.VisibleIndex = 6
        Me.colActivities.Width = 201
        '
        'colDuration
        '
        Me.colDuration.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colDuration.AppearanceCell.Options.UseBackColor = True
        Me.colDuration.FieldName = "Duration"
        Me.colDuration.Name = "colDuration"
        Me.colDuration.OptionsColumn.AllowEdit = False
        Me.colDuration.Visible = True
        Me.colDuration.VisibleIndex = 7
        Me.colDuration.Width = 53
        '
        'colES
        '
        Me.colES.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colES.AppearanceCell.Options.UseBackColor = True
        Me.colES.Caption = "Start Date"
        Me.colES.FieldName = "ES"
        Me.colES.Name = "colES"
        Me.colES.OptionsColumn.AllowEdit = False
        Me.colES.Visible = True
        Me.colES.VisibleIndex = 9
        '
        'colEF
        '
        Me.colEF.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colEF.AppearanceCell.Options.UseBackColor = True
        Me.colEF.Caption = "End Date"
        Me.colEF.FieldName = "EF"
        Me.colEF.Name = "colEF"
        Me.colEF.OptionsColumn.AllowEdit = False
        Me.colEF.Visible = True
        Me.colEF.VisibleIndex = 10
        '
        'colLS
        '
        Me.colLS.FieldName = "LS"
        Me.colLS.Name = "colLS"
        Me.colLS.OptionsColumn.AllowEdit = False
        '
        'colSlack
        '
        Me.colSlack.FieldName = "Slack"
        Me.colSlack.Name = "colSlack"
        Me.colSlack.OptionsColumn.AllowEdit = False
        Me.colSlack.Width = 48
        '
        'colStartDate
        '
        Me.colStartDate.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.colStartDate.AppearanceCell.Options.UseBackColor = True
        Me.colStartDate.Caption = "Actual Start"
        Me.colStartDate.FieldName = "StartDate"
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.OptionsColumn.AllowEdit = False
        Me.colStartDate.Visible = True
        Me.colStartDate.VisibleIndex = 11
        Me.colStartDate.Width = 92
        '
        'colEndDate
        '
        Me.colEndDate.AppearanceCell.BackColor = System.Drawing.Color.Lime
        Me.colEndDate.AppearanceCell.Options.UseBackColor = True
        Me.colEndDate.Caption = "Actual End"
        Me.colEndDate.FieldName = "EndDate"
        Me.colEndDate.Name = "colEndDate"
        Me.colEndDate.OptionsColumn.AllowEdit = False
        Me.colEndDate.Visible = True
        Me.colEndDate.VisibleIndex = 12
        Me.colEndDate.Width = 96
        '
        'colUnit
        '
        Me.colUnit.FieldName = "Unit"
        Me.colUnit.Name = "colUnit"
        Me.colUnit.OptionsColumn.AllowEdit = False
        Me.colUnit.Visible = True
        Me.colUnit.VisibleIndex = 17
        Me.colUnit.Width = 49
        '
        'colTaskComplete
        '
        Me.colTaskComplete.FieldName = "TaskComplete"
        Me.colTaskComplete.Name = "colTaskComplete"
        Me.colTaskComplete.OptionsColumn.AllowEdit = False
        Me.colTaskComplete.Visible = True
        Me.colTaskComplete.VisibleIndex = 13
        Me.colTaskComplete.Width = 87
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.OptionsColumn.AllowEdit = False
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 18
        '
        'colDepartmentName
        '
        Me.colDepartmentName.FieldName = "DepartmentName"
        Me.colDepartmentName.Name = "colDepartmentName"
        Me.colDepartmentName.OptionsColumn.AllowEdit = False
        Me.colDepartmentName.Visible = True
        Me.colDepartmentName.VisibleIndex = 19
        '
        'colIsPOComplete
        '
        Me.colIsPOComplete.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colIsPOComplete.AppearanceCell.Options.UseBackColor = True
        Me.colIsPOComplete.Caption = "PO Complete"
        Me.colIsPOComplete.FieldName = "IsPOComplete"
        Me.colIsPOComplete.Name = "colIsPOComplete"
        Me.colIsPOComplete.OptionsColumn.AllowEdit = False
        Me.colIsPOComplete.Visible = True
        Me.colIsPOComplete.VisibleIndex = 20
        Me.colIsPOComplete.Width = 102
        '
        'colIsProgramComplete
        '
        Me.colIsProgramComplete.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colIsProgramComplete.AppearanceCell.Options.UseBackColor = True
        Me.colIsProgramComplete.Caption = "Program Complete"
        Me.colIsProgramComplete.FieldName = "IsProgramComplete"
        Me.colIsProgramComplete.Name = "colIsProgramComplete"
        Me.colIsProgramComplete.OptionsColumn.AllowEdit = False
        Me.colIsProgramComplete.Visible = True
        Me.colIsProgramComplete.VisibleIndex = 21
        Me.colIsProgramComplete.Width = 102
        '
        'colProductionQuantity
        '
        Me.colProductionQuantity.FieldName = "ProductionQuantity"
        Me.colProductionQuantity.Name = "colProductionQuantity"
        Me.colProductionQuantity.OptionsColumn.AllowEdit = False
        Me.colProductionQuantity.Visible = True
        Me.colProductionQuantity.VisibleIndex = 16
        Me.colProductionQuantity.Width = 118
        '
        'colTaskComments
        '
        Me.colTaskComments.ColumnEdit = Me.TaskCommentsHyperLinkEdit
        Me.colTaskComments.FieldName = "TaskComments"
        Me.colTaskComments.Name = "colTaskComments"
        Me.colTaskComments.Visible = True
        Me.colTaskComments.VisibleIndex = 14
        Me.colTaskComments.Width = 131
        '
        'TaskCommentsHyperLinkEdit
        '
        Me.TaskCommentsHyperLinkEdit.AutoHeight = False
        Me.TaskCommentsHyperLinkEdit.Name = "TaskCommentsHyperLinkEdit"
        '
        'colOrderQuantity
        '
        Me.colOrderQuantity.FieldName = "OrderQuantity"
        Me.colOrderQuantity.Name = "colOrderQuantity"
        Me.colOrderQuantity.OptionsColumn.AllowEdit = False
        Me.colOrderQuantity.Visible = True
        Me.colOrderQuantity.VisibleIndex = 15
        Me.colOrderQuantity.Width = 90
        '
        'colOffDay
        '
        Me.colOffDay.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colOffDay.AppearanceCell.Options.UseBackColor = True
        Me.colOffDay.FieldName = "OffDay"
        Me.colOffDay.Name = "colOffDay"
        Me.colOffDay.OptionsColumn.AllowEdit = False
        Me.colOffDay.Visible = True
        Me.colOffDay.VisibleIndex = 8
        Me.colOffDay.Width = 50
        '
        'colLF
        '
        Me.colLF.FieldName = "LF"
        Me.colLF.Name = "colLF"
        '
        'EditItemButton
        '
        Me.EditItemButton.AutoHeight = False
        Me.EditItemButton.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EditItemButton.Name = "EditItemButton"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 43)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainerControl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PrintButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PivotGridControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1215, 525)
        Me.SplitContainer1.SplitterDistance = 319
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.OrderActivitiesPredecessorViewGridControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1215, 319)
        Me.SplitContainerControl1.SplitterPosition = 63
        Me.SplitContainerControl1.TabIndex = 66
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer2.Panel1.Controls.Add(OrderQuantityLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.OrderQuantityTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.SaveButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.HideButton)
        Me.SplitContainer2.Panel1.Controls.Add(TaskCommentsLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TaskCommentsTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(ProductionQuantityLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ProductionQuantityTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TaskCompleteCheckBox)
        Me.SplitContainer2.Panel1.Controls.Add(EndDateLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.EndDateDateEdit)
        Me.SplitContainer2.Panel1.Controls.Add(StartDateLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.StartDateDateEdit)
        Me.SplitContainer2.Panel1.Controls.Add(Me.OrderActivitiesIdLabel2)
        Me.SplitContainer2.Panel1Collapsed = True
        Me.SplitContainer2.Panel1MinSize = 68
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.OrderActivitiesViewGridControl)
        Me.SplitContainer2.Size = New System.Drawing.Size(1215, 251)
        Me.SplitContainer2.SplitterDistance = 68
        Me.SplitContainer2.TabIndex = 56
        '
        'OrderQuantityTextBox
        '
        Me.OrderQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderActivitiesBindingSource, "OrderQuantity", True))
        Me.OrderQuantityTextBox.Location = New System.Drawing.Point(378, 13)
        Me.OrderQuantityTextBox.Name = "OrderQuantityTextBox"
        Me.OrderQuantityTextBox.ReadOnly = True
        Me.OrderQuantityTextBox.Size = New System.Drawing.Size(100, 21)
        Me.OrderQuantityTextBox.TabIndex = 18
        '
        'OrderActivitiesBindingSource
        '
        Me.OrderActivitiesBindingSource.DataMember = "OrderActivities"
        Me.OrderActivitiesBindingSource.DataSource = Me.OrderActivitiesDataSet
        '
        'OrderActivitiesDataSet
        '
        Me.OrderActivitiesDataSet.DataSetName = "OrderActivitiesDataSet"
        Me.OrderActivitiesDataSet.EnforceConstraints = False
        Me.OrderActivitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(907, 11)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 51)
        Me.SaveButton.TabIndex = 17
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderActivitiesBindingSource, "Unit", True))
        Me.Label3.Location = New System.Drawing.Point(484, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Unit"
        '
        'HideButton
        '
        Me.HideButton.Location = New System.Drawing.Point(988, 11)
        Me.HideButton.Name = "HideButton"
        Me.HideButton.Size = New System.Drawing.Size(75, 51)
        Me.HideButton.TabIndex = 15
        Me.HideButton.Text = "Hide Me"
        Me.HideButton.UseVisualStyleBackColor = True
        '
        'TaskCommentsTextBox
        '
        Me.TaskCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderActivitiesBindingSource, "TaskComments", True))
        Me.TaskCommentsTextBox.Location = New System.Drawing.Point(378, 38)
        Me.TaskCommentsTextBox.Multiline = True
        Me.TaskCommentsTextBox.Name = "TaskCommentsTextBox"
        Me.TaskCommentsTextBox.Size = New System.Drawing.Size(413, 22)
        Me.TaskCommentsTextBox.TabIndex = 13
        '
        'ProductionQuantityTextBox
        '
        Me.ProductionQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderActivitiesBindingSource, "ProductionQuantity", True))
        Me.ProductionQuantityTextBox.Location = New System.Drawing.Point(658, 11)
        Me.ProductionQuantityTextBox.Name = "ProductionQuantityTextBox"
        Me.ProductionQuantityTextBox.Size = New System.Drawing.Size(133, 21)
        Me.ProductionQuantityTextBox.TabIndex = 11
        '
        'TaskCompleteCheckBox
        '
        Me.TaskCompleteCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TaskCompleteCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrderActivitiesBindingSource, "TaskComplete", True))
        Me.TaskCompleteCheckBox.ForeColor = System.Drawing.Color.White
        Me.TaskCompleteCheckBox.Location = New System.Drawing.Point(797, 12)
        Me.TaskCompleteCheckBox.Name = "TaskCompleteCheckBox"
        Me.TaskCompleteCheckBox.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.TaskCompleteCheckBox.Size = New System.Drawing.Size(104, 48)
        Me.TaskCompleteCheckBox.TabIndex = 7
        Me.TaskCompleteCheckBox.Text = "Task Complete"
        Me.TaskCompleteCheckBox.UseVisualStyleBackColor = False
        '
        'EndDateDateEdit
        '
        Me.EndDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderActivitiesBindingSource, "EndDate", True))
        Me.EndDateDateEdit.EditValue = Nothing
        Me.EndDateDateEdit.Location = New System.Drawing.Point(177, 39)
        Me.EndDateDateEdit.Name = "EndDateDateEdit"
        Me.EndDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EndDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.EndDateDateEdit.Properties.ReadOnly = True
        Me.EndDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.EndDateDateEdit.TabIndex = 5
        '
        'StartDateDateEdit
        '
        Me.StartDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrderActivitiesBindingSource, "StartDate", True))
        Me.StartDateDateEdit.EditValue = Nothing
        Me.StartDateDateEdit.Location = New System.Drawing.Point(177, 11)
        Me.StartDateDateEdit.Name = "StartDateDateEdit"
        Me.StartDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StartDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.StartDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.StartDateDateEdit.TabIndex = 3
        '
        'OrderActivitiesIdLabel2
        '
        Me.OrderActivitiesIdLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OrderActivitiesIdLabel2.BackColor = System.Drawing.Color.Yellow
        Me.OrderActivitiesIdLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OrderActivitiesIdLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderActivitiesBindingSource, "OrderActivitiesId", True))
        Me.OrderActivitiesIdLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderActivitiesIdLabel2.Location = New System.Drawing.Point(0, 0)
        Me.OrderActivitiesIdLabel2.Name = "OrderActivitiesIdLabel2"
        Me.OrderActivitiesIdLabel2.Size = New System.Drawing.Size(97, 68)
        Me.OrderActivitiesIdLabel2.TabIndex = 2
        Me.OrderActivitiesIdLabel2.Text = "Label3"
        Me.OrderActivitiesIdLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderActivitiesPredecessorViewGridControl
        '
        Me.OrderActivitiesPredecessorViewGridControl.DataSource = Me.OrderActivitiesPredecessorViewBindingSource
        Me.OrderActivitiesPredecessorViewGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderActivitiesPredecessorViewGridControl.Location = New System.Drawing.Point(0, 0)
        Me.OrderActivitiesPredecessorViewGridControl.MainView = Me.GridView2
        Me.OrderActivitiesPredecessorViewGridControl.Name = "OrderActivitiesPredecessorViewGridControl"
        Me.OrderActivitiesPredecessorViewGridControl.Size = New System.Drawing.Size(1215, 63)
        Me.OrderActivitiesPredecessorViewGridControl.TabIndex = 0
        Me.OrderActivitiesPredecessorViewGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'OrderActivitiesPredecessorViewBindingSource
        '
        Me.OrderActivitiesPredecessorViewBindingSource.DataMember = "OrderActivitiesPredecessorView"
        Me.OrderActivitiesPredecessorViewBindingSource.DataSource = Me.OrderActivitiesViewDataSet
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderActivitiesId, Me.colProgramNo1, Me.colBuyerName1, Me.colStyleName1, Me.colPO1, Me.colFabricColorName1, Me.colEX1, Me.colSL1, Me.colActivities1, Me.colDuration1, Me.colES1, Me.colEF1, Me.colLS1, Me.colLF1, Me.colSlack1, Me.colStartDate1, Me.colEndDate1, Me.colUnit1, Me.colTaskComplete1, Me.colUSER_NAME1, Me.colProductionQuantity1, Me.colTaskComments1, Me.colIsPOComplete1, Me.colIsProgramComplete1, Me.colDepartmentName1, Me.colOrderQuantity1, Me.colOffDay1})
        Me.GridView2.GridControl = Me.OrderActivitiesPredecessorViewGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSL1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colOrderActivitiesId
        '
        Me.colOrderActivitiesId.FieldName = "OrderActivitiesId"
        Me.colOrderActivitiesId.Name = "colOrderActivitiesId"
        Me.colOrderActivitiesId.Width = 154
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        Me.colProgramNo1.Visible = True
        Me.colProgramNo1.VisibleIndex = 0
        Me.colProgramNo1.Width = 107
        '
        'colBuyerName1
        '
        Me.colBuyerName1.FieldName = "BuyerName"
        Me.colBuyerName1.Name = "colBuyerName1"
        Me.colBuyerName1.Width = 77
        '
        'colStyleName1
        '
        Me.colStyleName1.FieldName = "StyleName"
        Me.colStyleName1.Name = "colStyleName1"
        Me.colStyleName1.Visible = True
        Me.colStyleName1.VisibleIndex = 1
        Me.colStyleName1.Width = 80
        '
        'colPO1
        '
        Me.colPO1.FieldName = "PO"
        Me.colPO1.Name = "colPO1"
        Me.colPO1.Visible = True
        Me.colPO1.VisibleIndex = 2
        Me.colPO1.Width = 42
        '
        'colFabricColorName1
        '
        Me.colFabricColorName1.FieldName = "FabricColorName"
        Me.colFabricColorName1.Name = "colFabricColorName1"
        Me.colFabricColorName1.Visible = True
        Me.colFabricColorName1.VisibleIndex = 3
        Me.colFabricColorName1.Width = 101
        '
        'colEX1
        '
        Me.colEX1.FieldName = "EX"
        Me.colEX1.Name = "colEX1"
        Me.colEX1.Visible = True
        Me.colEX1.VisibleIndex = 4
        Me.colEX1.Width = 62
        '
        'colSL1
        '
        Me.colSL1.FieldName = "SL"
        Me.colSL1.Name = "colSL1"
        Me.colSL1.Visible = True
        Me.colSL1.VisibleIndex = 5
        Me.colSL1.Width = 36
        '
        'colActivities1
        '
        Me.colActivities1.FieldName = "Activities"
        Me.colActivities1.Name = "colActivities1"
        Me.colActivities1.Visible = True
        Me.colActivities1.VisibleIndex = 6
        Me.colActivities1.Width = 83
        '
        'colDuration1
        '
        Me.colDuration1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colDuration1.AppearanceCell.Options.UseBackColor = True
        Me.colDuration1.FieldName = "Duration"
        Me.colDuration1.Name = "colDuration1"
        Me.colDuration1.Visible = True
        Me.colDuration1.VisibleIndex = 7
        Me.colDuration1.Width = 55
        '
        'colES1
        '
        Me.colES1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colES1.AppearanceCell.Options.UseBackColor = True
        Me.colES1.Caption = "Start Date"
        Me.colES1.FieldName = "ES"
        Me.colES1.Name = "colES1"
        Me.colES1.Visible = True
        Me.colES1.VisibleIndex = 9
        Me.colES1.Width = 73
        '
        'colEF1
        '
        Me.colEF1.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.colEF1.AppearanceCell.Options.UseBackColor = True
        Me.colEF1.Caption = "End Date"
        Me.colEF1.FieldName = "EF"
        Me.colEF1.Name = "colEF1"
        Me.colEF1.Visible = True
        Me.colEF1.VisibleIndex = 10
        Me.colEF1.Width = 73
        '
        'colLS1
        '
        Me.colLS1.FieldName = "LS"
        Me.colLS1.Name = "colLS1"
        Me.colLS1.Width = 28
        '
        'colLF1
        '
        Me.colLF1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colLF1.AppearanceCell.Options.UseBackColor = True
        Me.colLF1.FieldName = "LF"
        Me.colLF1.Name = "colLF1"
        Me.colLF1.Width = 60
        '
        'colSlack1
        '
        Me.colSlack1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colSlack1.AppearanceCell.Options.UseBackColor = True
        Me.colSlack1.FieldName = "Slack"
        Me.colSlack1.Name = "colSlack1"
        Me.colSlack1.Visible = True
        Me.colSlack1.VisibleIndex = 11
        Me.colSlack1.Width = 45
        '
        'colStartDate1
        '
        Me.colStartDate1.Caption = "Actual Start"
        Me.colStartDate1.FieldName = "StartDate"
        Me.colStartDate1.Name = "colStartDate1"
        Me.colStartDate1.Visible = True
        Me.colStartDate1.VisibleIndex = 12
        Me.colStartDate1.Width = 74
        '
        'colEndDate1
        '
        Me.colEndDate1.Caption = "Actual End"
        Me.colEndDate1.FieldName = "EndDate"
        Me.colEndDate1.Name = "colEndDate1"
        Me.colEndDate1.Visible = True
        Me.colEndDate1.VisibleIndex = 13
        Me.colEndDate1.Width = 67
        '
        'colUnit1
        '
        Me.colUnit1.FieldName = "Unit"
        Me.colUnit1.Name = "colUnit1"
        Me.colUnit1.Visible = True
        Me.colUnit1.VisibleIndex = 17
        Me.colUnit1.Width = 48
        '
        'colTaskComplete1
        '
        Me.colTaskComplete1.FieldName = "TaskComplete"
        Me.colTaskComplete1.Name = "colTaskComplete1"
        Me.colTaskComplete1.Visible = True
        Me.colTaskComplete1.VisibleIndex = 14
        Me.colTaskComplete1.Width = 80
        '
        'colUSER_NAME1
        '
        Me.colUSER_NAME1.Caption = "Asigned For"
        Me.colUSER_NAME1.FieldName = "USER_NAME"
        Me.colUSER_NAME1.Name = "colUSER_NAME1"
        Me.colUSER_NAME1.Visible = True
        Me.colUSER_NAME1.VisibleIndex = 18
        Me.colUSER_NAME1.Width = 119
        '
        'colProductionQuantity1
        '
        Me.colProductionQuantity1.FieldName = "ProductionQuantity"
        Me.colProductionQuantity1.Name = "colProductionQuantity1"
        Me.colProductionQuantity1.Visible = True
        Me.colProductionQuantity1.VisibleIndex = 16
        Me.colProductionQuantity1.Width = 115
        '
        'colTaskComments1
        '
        Me.colTaskComments1.FieldName = "TaskComments"
        Me.colTaskComments1.Name = "colTaskComments1"
        Me.colTaskComments1.Visible = True
        Me.colTaskComments1.VisibleIndex = 20
        Me.colTaskComments1.Width = 96
        '
        'colIsPOComplete1
        '
        Me.colIsPOComplete1.FieldName = "IsPOComplete"
        Me.colIsPOComplete1.Name = "colIsPOComplete1"
        Me.colIsPOComplete1.Visible = True
        Me.colIsPOComplete1.VisibleIndex = 21
        Me.colIsPOComplete1.Width = 100
        '
        'colIsProgramComplete1
        '
        Me.colIsProgramComplete1.FieldName = "IsProgramComplete"
        Me.colIsProgramComplete1.Name = "colIsProgramComplete1"
        Me.colIsProgramComplete1.Visible = True
        Me.colIsProgramComplete1.VisibleIndex = 22
        '
        'colDepartmentName1
        '
        Me.colDepartmentName1.Caption = "Department"
        Me.colDepartmentName1.FieldName = "DepartmentName"
        Me.colDepartmentName1.Name = "colDepartmentName1"
        Me.colDepartmentName1.Visible = True
        Me.colDepartmentName1.VisibleIndex = 19
        '
        'colOrderQuantity1
        '
        Me.colOrderQuantity1.FieldName = "OrderQuantity"
        Me.colOrderQuantity1.Name = "colOrderQuantity1"
        Me.colOrderQuantity1.Visible = True
        Me.colOrderQuantity1.VisibleIndex = 15
        Me.colOrderQuantity1.Width = 95
        '
        'colOffDay1
        '
        Me.colOffDay1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colOffDay1.AppearanceCell.Options.UseBackColor = True
        Me.colOffDay1.FieldName = "OffDay"
        Me.colOffDay1.Name = "colOffDay1"
        Me.colOffDay1.Visible = True
        Me.colOffDay1.VisibleIndex = 8
        Me.colOffDay1.Width = 50
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Location = New System.Drawing.Point(1999, 5)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(40, 22)
        Me.PrintButton.TabIndex = 63
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.OrderActivitiesViewBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProgramNo1, Me.fieldBuyerName1, Me.fieldStyleName1, Me.fieldPO1, Me.fieldFabricColorName1, Me.fieldSL1, Me.fieldActivities1, Me.fieldDuration1, Me.fieldES1, Me.fieldLF1, Me.fieldSlack1, Me.fieldStartDate1, Me.fieldEndDate1, Me.fieldTaskComplete1, Me.fieldUSERNAME1, Me.fieldDepartmentName1, Me.fieldIsPOComplete1, Me.fieldIsProgramComplete1, Me.fieldProductionQuantity1, Me.fieldTaskComments1, Me.fieldOrderQuantity1, Me.fieldOffDay1, Me.fieldEX})
        PivotGridFormatRule1.Measure = Me.fieldES1
        PivotGridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Black
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression1.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression1.Expression = "[StartDate]= [ES]"
        PivotGridFormatRule1.Rule = FormatConditionRuleExpression1
        PivotGridFormatRule1.Settings = FormatRuleTotalTypeSettings1
        PivotGridFormatRule2.Measure = Me.fieldES1
        PivotGridFormatRule2.Name = "Format1"
        FormatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.Red
        FormatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.White
        FormatConditionRuleExpression2.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression2.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression2.Expression = "[ES] <> [StartDate]"
        PivotGridFormatRule2.Rule = FormatConditionRuleExpression2
        PivotGridFormatRule2.Settings = FormatRuleTotalTypeSettings2
        PivotGridFormatRule3.Name = "Format2"
        FormatConditionRuleExpression3.Expression = "DateDiffDay([LF], [EX])"
        PivotGridFormatRule3.Rule = FormatConditionRuleExpression3
        PivotGridFormatRule3.Settings = FormatRuleTotalTypeSettings3
        Me.PivotGridControl1.FormatRules.Add(PivotGridFormatRule1)
        Me.PivotGridControl1.FormatRules.Add(PivotGridFormatRule2)
        Me.PivotGridControl1.FormatRules.Add(PivotGridFormatRule3)
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PivotGridControl1.OptionsView.ShowColumnGrandTotals = False
        Me.PivotGridControl1.OptionsView.ShowColumnTotals = False
        Me.PivotGridControl1.OptionsView.ShowRowGrandTotalHeader = False
        Me.PivotGridControl1.OptionsView.ShowRowGrandTotals = False
        Me.PivotGridControl1.OptionsView.ShowRowTotals = False
        Me.PivotGridControl1.Size = New System.Drawing.Size(1215, 202)
        Me.PivotGridControl1.TabIndex = 0
        '
        'fieldProgramNo1
        '
        Me.fieldProgramNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProgramNo1.AreaIndex = 0
        Me.fieldProgramNo1.FieldName = "ProgramNo"
        Me.fieldProgramNo1.Name = "fieldProgramNo1"
        '
        'fieldBuyerName1
        '
        Me.fieldBuyerName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldBuyerName1.AreaIndex = 1
        Me.fieldBuyerName1.FieldName = "BuyerName"
        Me.fieldBuyerName1.Name = "fieldBuyerName1"
        '
        'fieldStyleName1
        '
        Me.fieldStyleName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldStyleName1.AreaIndex = 2
        Me.fieldStyleName1.FieldName = "StyleName"
        Me.fieldStyleName1.Name = "fieldStyleName1"
        '
        'fieldPO1
        '
        Me.fieldPO1.AreaIndex = 0
        Me.fieldPO1.FieldName = "PO"
        Me.fieldPO1.Name = "fieldPO1"
        '
        'fieldFabricColorName1
        '
        Me.fieldFabricColorName1.AreaIndex = 1
        Me.fieldFabricColorName1.FieldName = "FabricColorName"
        Me.fieldFabricColorName1.Name = "fieldFabricColorName1"
        '
        'fieldSL1
        '
        Me.fieldSL1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSL1.AreaIndex = 0
        Me.fieldSL1.FieldName = "SL"
        Me.fieldSL1.Name = "fieldSL1"
        Me.fieldSL1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldActivities1
        '
        Me.fieldActivities1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldActivities1.AreaIndex = 1
        Me.fieldActivities1.FieldName = "Activities"
        Me.fieldActivities1.Name = "fieldActivities1"
        '
        'fieldDuration1
        '
        Me.fieldDuration1.AreaIndex = 2
        Me.fieldDuration1.FieldName = "Duration"
        Me.fieldDuration1.Name = "fieldDuration1"
        '
        'fieldLF1
        '
        Me.fieldLF1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldLF1.AreaIndex = 1
        Me.fieldLF1.Caption = "End"
        Me.fieldLF1.CellFormat.FormatString = "d"
        Me.fieldLF1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldLF1.FieldName = "LF"
        Me.fieldLF1.Name = "fieldLF1"
        Me.fieldLF1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        Me.fieldLF1.Width = 68
        '
        'fieldSlack1
        '
        Me.fieldSlack1.AreaIndex = 3
        Me.fieldSlack1.FieldName = "Slack"
        Me.fieldSlack1.Name = "fieldSlack1"
        '
        'fieldStartDate1
        '
        Me.fieldStartDate1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldStartDate1.AreaIndex = 2
        Me.fieldStartDate1.Caption = "A.Start"
        Me.fieldStartDate1.CellFormat.FormatString = "d"
        Me.fieldStartDate1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldStartDate1.FieldName = "StartDate"
        Me.fieldStartDate1.Name = "fieldStartDate1"
        Me.fieldStartDate1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min
        Me.fieldStartDate1.Width = 72
        '
        'fieldEndDate1
        '
        Me.fieldEndDate1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldEndDate1.AreaIndex = 3
        Me.fieldEndDate1.Caption = "A.End"
        Me.fieldEndDate1.CellFormat.FormatString = "d"
        Me.fieldEndDate1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldEndDate1.FieldName = "EndDate"
        Me.fieldEndDate1.Name = "fieldEndDate1"
        Me.fieldEndDate1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
        Me.fieldEndDate1.Width = 69
        '
        'fieldTaskComplete1
        '
        Me.fieldTaskComplete1.AreaIndex = 4
        Me.fieldTaskComplete1.FieldName = "TaskComplete"
        Me.fieldTaskComplete1.Name = "fieldTaskComplete1"
        '
        'fieldUSERNAME1
        '
        Me.fieldUSERNAME1.AreaIndex = 5
        Me.fieldUSERNAME1.FieldName = "USER_NAME"
        Me.fieldUSERNAME1.Name = "fieldUSERNAME1"
        '
        'fieldDepartmentName1
        '
        Me.fieldDepartmentName1.AreaIndex = 6
        Me.fieldDepartmentName1.FieldName = "DepartmentName"
        Me.fieldDepartmentName1.Name = "fieldDepartmentName1"
        '
        'fieldIsPOComplete1
        '
        Me.fieldIsPOComplete1.AreaIndex = 7
        Me.fieldIsPOComplete1.FieldName = "IsPOComplete"
        Me.fieldIsPOComplete1.Name = "fieldIsPOComplete1"
        '
        'fieldIsProgramComplete1
        '
        Me.fieldIsProgramComplete1.AreaIndex = 8
        Me.fieldIsProgramComplete1.FieldName = "IsProgramComplete"
        Me.fieldIsProgramComplete1.Name = "fieldIsProgramComplete1"
        '
        'fieldProductionQuantity1
        '
        Me.fieldProductionQuantity1.AreaIndex = 9
        Me.fieldProductionQuantity1.FieldName = "ProductionQuantity"
        Me.fieldProductionQuantity1.Name = "fieldProductionQuantity1"
        '
        'fieldTaskComments1
        '
        Me.fieldTaskComments1.AreaIndex = 10
        Me.fieldTaskComments1.FieldName = "TaskComments"
        Me.fieldTaskComments1.Name = "fieldTaskComments1"
        '
        'fieldOrderQuantity1
        '
        Me.fieldOrderQuantity1.AreaIndex = 11
        Me.fieldOrderQuantity1.FieldName = "OrderQuantity"
        Me.fieldOrderQuantity1.Name = "fieldOrderQuantity1"
        '
        'fieldOffDay1
        '
        Me.fieldOffDay1.AreaIndex = 12
        Me.fieldOffDay1.FieldName = "OffDay"
        Me.fieldOffDay1.Name = "fieldOffDay1"
        '
        'fieldEX
        '
        Me.fieldEX.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldEX.AreaIndex = 3
        Me.fieldEX.FieldName = "EX"
        Me.fieldEX.Name = "fieldEX"
        '
        'OrderLookupGridLookUpEdit
        '
        Me.OrderLookupGridLookUpEdit.EditValue = "[Select your Program]"
        Me.OrderLookupGridLookUpEdit.Location = New System.Drawing.Point(664, 13)
        Me.OrderLookupGridLookUpEdit.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.OrderLookupGridLookUpEdit.Name = "OrderLookupGridLookUpEdit"
        Me.OrderLookupGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OrderLookupGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.OrderLookupGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.OrderLookupGridLookUpEdit.Properties.ImmediatePopup = True
        Me.OrderLookupGridLookUpEdit.Properties.NullText = "Select your Program"
        Me.OrderLookupGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.OrderLookupGridLookUpEdit.Properties.Tag = "NR"
        Me.OrderLookupGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.OrderLookupGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.OrderLookupGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.OrderLookupGridLookUpEdit.Size = New System.Drawing.Size(251, 20)
        Me.OrderLookupGridLookUpEdit.TabIndex = 65
        Me.OrderLookupGridLookUpEdit.Tag = "NR"
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
        'ShowByPOButton
        '
        Me.ShowByPOButton.Location = New System.Drawing.Point(921, 12)
        Me.ShowByPOButton.Name = "ShowByPOButton"
        Me.ShowByPOButton.Size = New System.Drawing.Size(49, 22)
        Me.ShowByPOButton.TabIndex = 61
        Me.ShowByPOButton.Text = "Show"
        Me.ShowByPOButton.UseVisualStyleBackColor = True
        '
        'ShowPivotButton
        '
        Me.ShowPivotButton.Location = New System.Drawing.Point(1110, 12)
        Me.ShowPivotButton.Name = "ShowPivotButton"
        Me.ShowPivotButton.Size = New System.Drawing.Size(93, 22)
        Me.ShowPivotButton.TabIndex = 2
        Me.ShowPivotButton.Text = "Show Pivot"
        Me.ShowPivotButton.UseVisualStyleBackColor = True
        '
        'SendMailButton
        '
        Me.SendMailButton.Location = New System.Drawing.Point(1049, 12)
        Me.SendMailButton.Name = "SendMailButton"
        Me.SendMailButton.Size = New System.Drawing.Size(55, 22)
        Me.SendMailButton.TabIndex = 2
        Me.SendMailButton.Text = "Mail Me"
        Me.SendMailButton.UseVisualStyleBackColor = True
        '
        'ShowAllButton
        '
        Me.ShowAllButton.Location = New System.Drawing.Point(977, 12)
        Me.ShowAllButton.Name = "ShowAllButton"
        Me.ShowAllButton.Size = New System.Drawing.Size(65, 22)
        Me.ShowAllButton.TabIndex = 55
        Me.ShowAllButton.Text = "Show All"
        Me.ShowAllButton.UseVisualStyleBackColor = True
        '
        'AsignedForCheckBox
        '
        Me.AsignedForCheckBox.AutoSize = True
        Me.AsignedForCheckBox.Location = New System.Drawing.Point(328, 16)
        Me.AsignedForCheckBox.Name = "AsignedForCheckBox"
        Me.AsignedForCheckBox.Size = New System.Drawing.Size(85, 17)
        Me.AsignedForCheckBox.TabIndex = 54
        Me.AsignedForCheckBox.Text = "Asigned For "
        Me.AsignedForCheckBox.UseVisualStyleBackColor = True
        '
        'AsignedForGridLookUpEdit
        '
        Me.AsignedForGridLookUpEdit.EditValue = ""
        Me.AsignedForGridLookUpEdit.Location = New System.Drawing.Point(419, 12)
        Me.AsignedForGridLookUpEdit.Name = "AsignedForGridLookUpEdit"
        Me.AsignedForGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AsignedForGridLookUpEdit.Properties.DataSource = Me.UserLookupBindingSource
        Me.AsignedForGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.AsignedForGridLookUpEdit.Properties.ImmediatePopup = True
        Me.AsignedForGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AsignedForGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AsignedForGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.AsignedForGridLookUpEdit.Properties.View = Me.GridView3
        Me.AsignedForGridLookUpEdit.Size = New System.Drawing.Size(105, 20)
        Me.AsignedForGridLookUpEdit.TabIndex = 53
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
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME2, Me.colDepartment})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
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
        Me.colDepartment.FieldName = "Department"
        Me.colDepartment.Name = "colDepartment"
        Me.colDepartment.Visible = True
        Me.colDepartment.VisibleIndex = 1
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(528, 11)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(44, 22)
        Me.ShowButton.TabIndex = 52
        Me.ShowButton.Text = "Show Pending"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'ToDateEdit
        '
        Me.ToDateEdit.EditValue = Nothing
        Me.ToDateEdit.Location = New System.Drawing.Point(228, 12)
        Me.ToDateEdit.Name = "ToDateEdit"
        Me.ToDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ToDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ToDateEdit.Size = New System.Drawing.Size(88, 20)
        Me.ToDateEdit.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "To :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(578, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Program No :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Task Date From :"
        '
        'FromDateEdit
        '
        Me.FromDateEdit.EditValue = Nothing
        Me.FromDateEdit.Location = New System.Drawing.Point(100, 12)
        Me.FromDateEdit.Name = "FromDateEdit"
        Me.FromDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FromDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.FromDateEdit.Size = New System.Drawing.Size(94, 20)
        Me.FromDateEdit.TabIndex = 47
        '
        'OrderPOLookupAllBindingSource
        '
        Me.OrderPOLookupAllBindingSource.DataMember = "OrderPOLookupAll"
        Me.OrderPOLookupAllBindingSource.DataSource = Me.OrderPOLookupNewDataSet
        '
        'OrderPOLookupNewDataSet
        '
        Me.OrderPOLookupNewDataSet.DataSetName = "OrderPOLookupNewDataSet"
        Me.OrderPOLookupNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderPOLookupAllTableAdapter
        '
        Me.OrderPOLookupAllTableAdapter.ClearBeforeFill = True
        '
        'ActivitiesListTableAdapter
        '
        Me.ActivitiesListTableAdapter.ClearBeforeFill = True
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'OrderActivitiesPredecessorViewTableAdapter
        '
        Me.OrderActivitiesPredecessorViewTableAdapter.ClearBeforeFill = True
        '
        'OrderActivitiesTableAdapter
        '
        Me.OrderActivitiesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.OrderActivitiesPredecessorTableAdapter = Nothing
        Me.TableAdapterManager1.OrderActivitiesTableAdapter = Me.OrderActivitiesTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KSoft_Apparel.OrderActivitiesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ActivitiesListDataSet
        '
        Me.ActivitiesListDataSet.DataSetName = "ActivitiesListDataSet"
        Me.ActivitiesListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivitiesListBindingSource
        '
        Me.ActivitiesListBindingSource.DataMember = "ActivitiesList"
        Me.ActivitiesListBindingSource.DataSource = Me.ActivitiesListDataSet
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.ExportOptions.Xls.SheetName = "OIM"
        Me.PrintingSystem1.ExportOptions.Xls.ShowGridLines = True
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.OrderActivitiesViewGridControl
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'frmOrderActivities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 568)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.OrderLookupGridLookUpEdit)
        Me.Controls.Add(Me.ShowPivotButton)
        Me.Controls.Add(Me.FromDateEdit)
        Me.Controls.Add(Me.ShowByPOButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SendMailButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShowAllButton)
        Me.Controls.Add(Me.ToDateEdit)
        Me.Controls.Add(Me.AsignedForCheckBox)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.AsignedForGridLookUpEdit)
        Me.Name = "frmOrderActivities"
        Me.Text = "Order Activities"
        CType(Me.OrderActivitiesViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderActivitiesViewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderActivitiesViewGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditHyperLinkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskCommentsHyperLinkEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditItemButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.OrderActivitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderActivitiesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderActivitiesPredecessorViewGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderActivitiesPredecessorViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignedForGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FromDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrderActivitiesViewDataSet As KSoft_Apparel.OrderActivitiesViewDataSet
    Friend WithEvents OrderActivitiesViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderActivitiesViewTableAdapter As KSoft_Apparel.OrderActivitiesViewDataSetTableAdapters.OrderActivitiesViewTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.OrderActivitiesViewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderActivitiesViewGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivities As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSlack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaskComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents OrderActivitiesPredecessorViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderActivitiesPredecessorViewTableAdapter As KSoft_Apparel.OrderActivitiesViewDataSetTableAdapters.OrderActivitiesPredecessorViewTableAdapter
    Friend WithEvents OrderActivitiesPredecessorViewGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderActivitiesId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEX1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivities1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuration1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colES1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLS1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSlack1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnit1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaskComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SendMailButton As System.Windows.Forms.Button
    Friend WithEvents FromDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents AsignedForGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserLookupDataSet As KSoft_Apparel.UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserLookupTableAdapter As KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents colUSER_NAME2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AsignedForCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ShowAllButton As System.Windows.Forms.Button
    Friend WithEvents colIsPOComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsProgramComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaskComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaskComments1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsPOComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsProgramComplete1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EditItemButton As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents EditHyperLinkEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents OrderActivitiesDataSet As KSoft_Apparel.OrderActivitiesDataSet
    Friend WithEvents OrderActivitiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderActivitiesTableAdapter As KSoft_Apparel.OrderActivitiesDataSetTableAdapters.OrderActivitiesTableAdapter
    Friend WithEvents TableAdapterManager1 As KSoft_Apparel.OrderActivitiesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderActivitiesIdLabel2 As System.Windows.Forms.Label
    Friend WithEvents TaskCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductionQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaskCompleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EndDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents StartDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colDepartmentName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HideButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents ShowByPOButton As System.Windows.Forms.Button
    Friend WithEvents ActivitiesListTableAdapter As KSoft_Apparel.ActivitiesListDataSetTableAdapters.ActivitiesListTableAdapter
    Friend WithEvents ActivitiesListDataSet As KSoft_Apparel.ActivitiesListDataSet
    Friend WithEvents ActivitiesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderPOLookupAllTableAdapter As KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter
    Friend WithEvents OrderPOLookupNewDataSet As KSoft_Apparel.OrderPOLookupNewDataSet
    Friend WithEvents OrderPOLookupAllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderQuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colOrderQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOffDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOffDay1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TaskCommentsHyperLinkEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents colLF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderLookupGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents Label4 As Label
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldProgramNo1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBuyerName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStyleName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFabricColorName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldActivities1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDuration1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldES1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLF1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSlack1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldStartDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEndDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTaskComplete1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUSERNAME1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDepartmentName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIsPOComplete1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIsProgramComplete1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTaskComments1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOffDay1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ShowPivotButton As Button
    Friend WithEvents fieldEX As DevExpress.XtraPivotGrid.PivotGridField
End Class
