<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActivitiesTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivitiesTemplate))
        Dim GanttDiagram2 As DevExpress.XtraCharts.GanttDiagram = New DevExpress.XtraCharts.GanttDiagram()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeBarSeriesLabel3 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel()
        Dim OverlappedGanttSeriesView4 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeBarSeriesLabel4 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel()
        Dim OverlappedGanttSeriesView5 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
        Dim OverlappedGanttSeriesView6 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
        Me.ActivitiesTemplateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesTemplateDataSet = New KSoft_Apparel.ActivitiesTemplateDataSet()
        Me.ActivitiesTemplateTableAdapter = New KSoft_Apparel.ActivitiesTemplateDataSetTableAdapters.ActivitiesTemplateTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.ActivitiesTemplateDataSetTableAdapters.TableAdapterManager()
        Me.ActivitiesTemplateDetailsTableAdapter = New KSoft_Apparel.ActivitiesTemplateDataSetTableAdapters.ActivitiesTemplateDetailsTableAdapter()
        Me.ActivitiesTemplateBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ActivitiesTemplateBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ActivitiesTemplateGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActivitiesListId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ActivitiesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesListDataSet = New KSoft_Apparel.ActivitiesListDataSet()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescription2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDuration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLeftDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAAsign_UserId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.RepositoryItemGridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBDay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDependentTask = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ActivitesListGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActivitiesListId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AsignForGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Apparel.UserDataSet()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ShowSuccessorsButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.ActivitiesTemplateDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ActivitiesTemplateDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPredecessors = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ActivitiesListGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ActivitiesTemplateLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesTemplateLookupDataSet = New KSoft_Apparel.ActivitiesTemplateLookupDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActivitiesListId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ActivitiesSuccessorsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ActivitiesSuccessorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescription3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDuration1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSlack1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.TriangleRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BetaRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TTLDayRequireTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateEarlyButton = New System.Windows.Forms.Button()
        Me.ActivitiesListTableAdapter = New KSoft_Apparel.ActivitiesListDataSetTableAdapters.ActivitiesListTableAdapter()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.UserTableAdapter = New KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ActivitiesGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivitiesGroupDataSet = New KSoft_Apparel.ActivitiesGroupDataSet()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.ActivitiesGroupTableAdapter = New KSoft_Apparel.ActivitiesGroupDataSetTableAdapters.ActivitiesGroupTableAdapter()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.PasteButton = New System.Windows.Forms.Button()
        Me.ActivitiesSuccessorsTableAdapter = New KSoft_Apparel.ActivitiesTemplateDataSetTableAdapters.ActivitiesSuccessorsTableAdapter()
        Me.ActivitiesTemplateLookupTableAdapter = New KSoft_Apparel.ActivitiesTemplateLookupDataSetTableAdapters.ActivitiesTemplateLookupTableAdapter()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colActivitiesGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLeadTime = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.ActivitiesTemplateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesTemplateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesTemplateBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActivitiesTemplateBindingNavigator.SuspendLayout()
        CType(Me.ActivitiesTemplateGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitesListGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignForGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.ActivitiesTemplateDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesTemplateDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesListGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesTemplateLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesTemplateLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesSuccessorsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesSuccessorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(GanttDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RangeBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedGanttSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RangeBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedGanttSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedGanttSeriesView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivitiesGroupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActivitiesTemplateBindingSource
        '
        Me.ActivitiesTemplateBindingSource.AllowNew = True
        Me.ActivitiesTemplateBindingSource.DataMember = "ActivitiesTemplate"
        Me.ActivitiesTemplateBindingSource.DataSource = Me.ActivitiesTemplateDataSet
        '
        'ActivitiesTemplateDataSet
        '
        Me.ActivitiesTemplateDataSet.DataSetName = "ActivitiesTemplateDataSet"
        Me.ActivitiesTemplateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivitiesTemplateTableAdapter
        '
        Me.ActivitiesTemplateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActivitiesTemplateDetailsTableAdapter = Me.ActivitiesTemplateDetailsTableAdapter
        Me.TableAdapterManager.ActivitiesTemplateTableAdapter = Me.ActivitiesTemplateTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ActivitiesTemplateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ActivitiesTemplateDetailsTableAdapter
        '
        Me.ActivitiesTemplateDetailsTableAdapter.ClearBeforeFill = True
        '
        'ActivitiesTemplateBindingNavigator
        '
        Me.ActivitiesTemplateBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ActivitiesTemplateBindingNavigator.BindingSource = Me.ActivitiesTemplateBindingSource
        Me.ActivitiesTemplateBindingNavigator.CountItem = Nothing
        Me.ActivitiesTemplateBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ActivitiesTemplateBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ActivitiesTemplateBindingNavigatorSaveItem})
        Me.ActivitiesTemplateBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ActivitiesTemplateBindingNavigator.MoveFirstItem = Nothing
        Me.ActivitiesTemplateBindingNavigator.MoveLastItem = Nothing
        Me.ActivitiesTemplateBindingNavigator.MoveNextItem = Nothing
        Me.ActivitiesTemplateBindingNavigator.MovePreviousItem = Nothing
        Me.ActivitiesTemplateBindingNavigator.Name = "ActivitiesTemplateBindingNavigator"
        Me.ActivitiesTemplateBindingNavigator.PositionItem = Nothing
        Me.ActivitiesTemplateBindingNavigator.Size = New System.Drawing.Size(1101, 25)
        Me.ActivitiesTemplateBindingNavigator.TabIndex = 0
        Me.ActivitiesTemplateBindingNavigator.Text = "CP Template Name"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ActivitiesTemplateBindingNavigatorSaveItem
        '
        Me.ActivitiesTemplateBindingNavigatorSaveItem.Image = CType(resources.GetObject("ActivitiesTemplateBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ActivitiesTemplateBindingNavigatorSaveItem.Name = "ActivitiesTemplateBindingNavigatorSaveItem"
        Me.ActivitiesTemplateBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.ActivitiesTemplateBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ActivitiesTemplateGridControl
        '
        Me.ActivitiesTemplateGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActivitiesTemplateGridControl.DataSource = Me.ActivitiesTemplateBindingSource
        Me.ActivitiesTemplateGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ActivitiesTemplateGridControl.MainView = Me.GridView1
        Me.ActivitiesTemplateGridControl.Name = "ActivitiesTemplateGridControl"
        Me.ActivitiesTemplateGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.BuyerGridLookUpEdit, Me.ActivitesListGridLookUpEdit, Me.AsignForGridLookUpEdit, Me.RepositoryItemGridLookUpEdit2, Me.UserLookupGridLookUpEdit})
        Me.ActivitiesTemplateGridControl.Size = New System.Drawing.Size(523, 371)
        Me.ActivitiesTemplateGridControl.TabIndex = 1
        Me.ActivitiesTemplateGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesListId, Me.colDuration, Me.colSL, Me.colLeftDay, Me.colES, Me.colEF, Me.colAAsign_UserId1, Me.colBDay, Me.colDependentTask})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(605, 143, 216, 460)
        Me.GridView1.GridControl = Me.ActivitiesTemplateGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSL, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colActivitiesListId
        '
        Me.colActivitiesListId.AppearanceHeader.Options.UseTextOptions = True
        Me.colActivitiesListId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActivitiesListId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colActivitiesListId.Caption = "Activities"
        Me.colActivitiesListId.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colActivitiesListId.FieldName = "ActivitiesListId"
        Me.colActivitiesListId.Name = "colActivitiesListId"
        Me.colActivitiesListId.Visible = True
        Me.colActivitiesListId.VisibleIndex = 1
        Me.colActivitiesListId.Width = 289
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.ActivitiesListBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "Description"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.NullText = ""
        Me.RepositoryItemGridLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "ActivitiesListId"
        Me.RepositoryItemGridLookUpEdit2.View = Me.GridView6
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
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescription2})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colDescription2
        '
        Me.colDescription2.FieldName = "Description"
        Me.colDescription2.Name = "colDescription2"
        Me.colDescription2.Visible = True
        Me.colDescription2.VisibleIndex = 0
        '
        'colDuration
        '
        Me.colDuration.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colDuration.AppearanceCell.Options.UseBackColor = True
        Me.colDuration.AppearanceHeader.Options.UseTextOptions = True
        Me.colDuration.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDuration.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDuration.FieldName = "Duration"
        Me.colDuration.Name = "colDuration"
        Me.colDuration.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colDuration.Visible = True
        Me.colDuration.VisibleIndex = 3
        Me.colDuration.Width = 57
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
        Me.colSL.Width = 43
        '
        'colLeftDay
        '
        Me.colLeftDay.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colLeftDay.AppearanceCell.Options.UseBackColor = True
        Me.colLeftDay.AppearanceHeader.Options.UseTextOptions = True
        Me.colLeftDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLeftDay.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colLeftDay.FieldName = "LeftDay"
        Me.colLeftDay.Name = "colLeftDay"
        Me.colLeftDay.Visible = True
        Me.colLeftDay.VisibleIndex = 4
        Me.colLeftDay.Width = 59
        '
        'colES
        '
        Me.colES.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colES.AppearanceCell.Options.UseBackColor = True
        Me.colES.AppearanceHeader.Options.UseTextOptions = True
        Me.colES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colES.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colES.Caption = "Start Day"
        Me.colES.DisplayFormat.FormatString = "n0"
        Me.colES.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colES.FieldName = "ES"
        Me.colES.Name = "colES"
        Me.colES.Visible = True
        Me.colES.VisibleIndex = 5
        Me.colES.Width = 62
        '
        'colEF
        '
        Me.colEF.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colEF.AppearanceCell.Options.UseBackColor = True
        Me.colEF.AppearanceHeader.Options.UseTextOptions = True
        Me.colEF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEF.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEF.Caption = "End Day"
        Me.colEF.DisplayFormat.FormatString = "n0"
        Me.colEF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEF.FieldName = "EF"
        Me.colEF.Name = "colEF"
        Me.colEF.Visible = True
        Me.colEF.VisibleIndex = 6
        Me.colEF.Width = 52
        '
        'colAAsign_UserId1
        '
        Me.colAAsign_UserId1.AppearanceHeader.Options.UseTextOptions = True
        Me.colAAsign_UserId1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAAsign_UserId1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colAAsign_UserId1.Caption = "Responsibility"
        Me.colAAsign_UserId1.ColumnEdit = Me.UserLookupGridLookUpEdit
        Me.colAAsign_UserId1.FieldName = "AAsign_UserId"
        Me.colAAsign_UserId1.Name = "colAAsign_UserId1"
        Me.colAAsign_UserId1.Visible = True
        Me.colAAsign_UserId1.VisibleIndex = 7
        Me.colAAsign_UserId1.Width = 126
        '
        'UserLookupGridLookUpEdit
        '
        Me.UserLookupGridLookUpEdit.AutoHeight = False
        Me.UserLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserLookupGridLookUpEdit.DataSource = Me.UserLookupBindingSource
        Me.UserLookupGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UserLookupGridLookUpEdit.Name = "UserLookupGridLookUpEdit"
        Me.UserLookupGridLookUpEdit.NullText = ""
        Me.UserLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserLookupGridLookUpEdit.ValueMember = "USER_ID"
        Me.UserLookupGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit3View
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
        'RepositoryItemGridLookUpEdit3View
        '
        Me.RepositoryItemGridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartment, Me.colUSER_NAME2})
        Me.RepositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit3View.Name = "RepositoryItemGridLookUpEdit3View"
        Me.RepositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colDepartment
        '
        Me.colDepartment.Caption = "Department"
        Me.colDepartment.FieldName = "Department"
        Me.colDepartment.Name = "colDepartment"
        Me.colDepartment.Visible = True
        Me.colDepartment.VisibleIndex = 1
        '
        'colUSER_NAME2
        '
        Me.colUSER_NAME2.Caption = "User"
        Me.colUSER_NAME2.FieldName = "USER_NAME"
        Me.colUSER_NAME2.Name = "colUSER_NAME2"
        Me.colUSER_NAME2.Visible = True
        Me.colUSER_NAME2.VisibleIndex = 0
        '
        'colBDay
        '
        Me.colBDay.AppearanceHeader.Options.UseTextOptions = True
        Me.colBDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBDay.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colBDay.Caption = "Backword Day"
        Me.colBDay.FieldName = "BDay"
        Me.colBDay.Name = "colBDay"
        Me.colBDay.Width = 68
        '
        'colDependentTask
        '
        Me.colDependentTask.AppearanceHeader.Options.UseTextOptions = True
        Me.colDependentTask.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDependentTask.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colDependentTask.FieldName = "DependentTask"
        Me.colDependentTask.Name = "colDependentTask"
        Me.colDependentTask.Visible = True
        Me.colDependentTask.VisibleIndex = 2
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.AutoHeight = False
        Me.BuyerGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.DisplayMember = "BuyerName"
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.NullText = ""
        Me.BuyerGridLookUpEdit.ReadOnly = True
        Me.BuyerGridLookUpEdit.ValueMember = "BuyerId"
        Me.BuyerGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit2View
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
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'ActivitesListGridLookUpEdit
        '
        Me.ActivitesListGridLookUpEdit.AutoHeight = False
        Me.ActivitesListGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActivitesListGridLookUpEdit.DataSource = Me.ActivitiesListBindingSource
        Me.ActivitesListGridLookUpEdit.DisplayMember = "Description"
        Me.ActivitesListGridLookUpEdit.ImmediatePopup = True
        Me.ActivitesListGridLookUpEdit.Name = "ActivitesListGridLookUpEdit"
        Me.ActivitesListGridLookUpEdit.NullText = ""
        Me.ActivitesListGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ActivitesListGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ActivitesListGridLookUpEdit.ValueMember = "ActivitiesListId"
        Me.ActivitesListGridLookUpEdit.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesListId2, Me.colDescription1, Me.colRemarks1})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colActivitiesListId2
        '
        Me.colActivitiesListId2.FieldName = "ActivitiesListId"
        Me.colActivitiesListId2.Name = "colActivitiesListId2"
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 0
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        '
        'AsignForGridLookUpEdit
        '
        Me.AsignForGridLookUpEdit.AutoHeight = False
        Me.AsignForGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AsignForGridLookUpEdit.DataSource = Me.UserBindingSource
        Me.AsignForGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.AsignForGridLookUpEdit.Name = "AsignForGridLookUpEdit"
        Me.AsignForGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AsignForGridLookUpEdit.ValueMember = "USER_ID"
        Me.AsignForGridLookUpEdit.View = Me.GridView5
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
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME1})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME1
        '
        Me.colUSER_NAME1.Caption = "Asigned For"
        Me.colUSER_NAME1.FieldName = "USER_NAME"
        Me.colUSER_NAME1.Name = "colUSER_NAME1"
        Me.colUSER_NAME1.Visible = True
        Me.colUSER_NAME1.VisibleIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChartControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TriangleRadioButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BetaRadioButton)
        Me.SplitContainer1.Size = New System.Drawing.Size(1101, 570)
        Me.SplitContainer1.SplitterDistance = 523
        Me.SplitContainer1.TabIndex = 2
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.LinkLabel2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ShowSuccessorsButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DownButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.UpButton)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ActivitiesTemplateGridControl)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(523, 570)
        Me.SplitContainer2.SplitterDistance = 398
        Me.SplitContainer2.TabIndex = 2
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(128, 378)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(78, 13)
        Me.LinkLabel2.TabIndex = 79
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Export to Excel"
        '
        'ShowSuccessorsButton
        '
        Me.ShowSuccessorsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowSuccessorsButton.Location = New System.Drawing.Point(417, 372)
        Me.ShowSuccessorsButton.Name = "ShowSuccessorsButton"
        Me.ShowSuccessorsButton.Size = New System.Drawing.Size(103, 23)
        Me.ShowSuccessorsButton.TabIndex = 4
        Me.ShowSuccessorsButton.Text = "Successors"
        Me.ShowSuccessorsButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DownButton.Location = New System.Drawing.Point(66, 373)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(56, 23)
        Me.DownButton.TabIndex = 3
        Me.DownButton.Text = "Down"
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'UpButton
        '
        Me.UpButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UpButton.Location = New System.Drawing.Point(5, 373)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(55, 23)
        Me.UpButton.TabIndex = 2
        Me.UpButton.Text = "Up"
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.ActivitiesTemplateDetailsGridControl)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.Controls.Add(Me.ActivitiesSuccessorsGridControl)
        Me.SplitContainer3.Size = New System.Drawing.Size(523, 168)
        Me.SplitContainer3.SplitterDistance = 274
        Me.SplitContainer3.TabIndex = 1
        '
        'ActivitiesTemplateDetailsGridControl
        '
        Me.ActivitiesTemplateDetailsGridControl.DataSource = Me.ActivitiesTemplateDetailsBindingSource
        Me.ActivitiesTemplateDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActivitiesTemplateDetailsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.ActivitiesTemplateDetailsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.ActivitiesTemplateDetailsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.ActivitiesTemplateDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.ActivitiesTemplateDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.ActivitiesTemplateDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.ActivitiesTemplateDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ActivitiesTemplateDetailsGridControl.MainView = Me.GridView2
        Me.ActivitiesTemplateDetailsGridControl.Name = "ActivitiesTemplateDetailsGridControl"
        Me.ActivitiesTemplateDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ActivitiesListGridLookUpEdit})
        Me.ActivitiesTemplateDetailsGridControl.Size = New System.Drawing.Size(274, 168)
        Me.ActivitiesTemplateDetailsGridControl.TabIndex = 0
        Me.ActivitiesTemplateDetailsGridControl.UseEmbeddedNavigator = True
        Me.ActivitiesTemplateDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ActivitiesTemplateDetailsBindingSource
        '
        Me.ActivitiesTemplateDetailsBindingSource.DataMember = "FK_ActivitiesTemplateDetails_ActivitiesTemplate"
        Me.ActivitiesTemplateDetailsBindingSource.DataSource = Me.ActivitiesTemplateBindingSource
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPredecessors})
        Me.GridView2.GridControl = Me.ActivitiesTemplateDetailsGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colPredecessors
        '
        Me.colPredecessors.ColumnEdit = Me.ActivitiesListGridLookUpEdit
        Me.colPredecessors.FieldName = "Predecessors"
        Me.colPredecessors.Name = "colPredecessors"
        Me.colPredecessors.Visible = True
        Me.colPredecessors.VisibleIndex = 0
        '
        'ActivitiesListGridLookUpEdit
        '
        Me.ActivitiesListGridLookUpEdit.AutoHeight = False
        Me.ActivitiesListGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ActivitiesListGridLookUpEdit.DataSource = Me.ActivitiesTemplateLookupBindingSource
        Me.ActivitiesListGridLookUpEdit.DisplayMember = "Description"
        Me.ActivitiesListGridLookUpEdit.ImmediatePopup = True
        Me.ActivitiesListGridLookUpEdit.Name = "ActivitiesListGridLookUpEdit"
        Me.ActivitiesListGridLookUpEdit.NullText = ""
        Me.ActivitiesListGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ActivitiesListGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ActivitiesListGridLookUpEdit.ValueMember = "ActivitiesTemplateId"
        Me.ActivitiesListGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'ActivitiesTemplateLookupBindingSource
        '
        Me.ActivitiesTemplateLookupBindingSource.DataMember = "ActivitiesTemplateLookup"
        Me.ActivitiesTemplateLookupBindingSource.DataSource = Me.ActivitiesTemplateLookupDataSet
        '
        'ActivitiesTemplateLookupDataSet
        '
        Me.ActivitiesTemplateLookupDataSet.DataSetName = "ActivitiesTemplateLookupDataSet"
        Me.ActivitiesTemplateLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesListId1, Me.colDescription, Me.colRemarks})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colActivitiesListId1
        '
        Me.colActivitiesListId1.FieldName = "ActivitiesListId"
        Me.colActivitiesListId1.Name = "colActivitiesListId1"
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 0
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        '
        'ActivitiesSuccessorsGridControl
        '
        Me.ActivitiesSuccessorsGridControl.DataSource = Me.ActivitiesSuccessorsBindingSource
        Me.ActivitiesSuccessorsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActivitiesSuccessorsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ActivitiesSuccessorsGridControl.MainView = Me.GridView7
        Me.ActivitiesSuccessorsGridControl.Name = "ActivitiesSuccessorsGridControl"
        Me.ActivitiesSuccessorsGridControl.Size = New System.Drawing.Size(245, 168)
        Me.ActivitiesSuccessorsGridControl.TabIndex = 0
        Me.ActivitiesSuccessorsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'ActivitiesSuccessorsBindingSource
        '
        Me.ActivitiesSuccessorsBindingSource.DataMember = "ActivitiesSuccessors"
        Me.ActivitiesSuccessorsBindingSource.DataSource = Me.ActivitiesTemplateDataSet
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescription3, Me.colDuration1, Me.colSlack1})
        Me.GridView7.GridControl = Me.ActivitiesSuccessorsGridControl
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsView.ColumnAutoWidth = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colDescription3
        '
        Me.colDescription3.Caption = "Successors"
        Me.colDescription3.FieldName = "Description"
        Me.colDescription3.Name = "colDescription3"
        Me.colDescription3.Visible = True
        Me.colDescription3.VisibleIndex = 0
        Me.colDescription3.Width = 137
        '
        'colDuration1
        '
        Me.colDuration1.FieldName = "Duration"
        Me.colDuration1.Name = "colDuration1"
        Me.colDuration1.Visible = True
        Me.colDuration1.VisibleIndex = 1
        '
        'colSlack1
        '
        Me.colSlack1.FieldName = "Slack"
        Me.colSlack1.Name = "colSlack1"
        '
        'ChartControl1
        '
        Me.ChartControl1.DataAdapter = Me.UserLookupTableAdapter
        Me.ChartControl1.DataBindings = Nothing
        Me.ChartControl1.DataSource = Me.UserLookupDataSet.UserLookup
        GanttDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        GanttDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = GanttDiagram2
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.ChartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
        Me.ChartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.ChartControl1.Legend.EquallySpacedItems = False
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Series3.ArgumentDataMember = "SL"
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series3.DataSource = Me.ActivitiesTemplateBindingSource
        RangeBarSeriesLabel3.Kind = DevExpress.XtraCharts.RangeBarLabelKind.MaxValueLabel
        RangeBarSeriesLabel3.TextPattern = "{A:G}: {V1:G}, {V2:G}"
        Series3.Label = RangeBarSeriesLabel3
        Series3.Name = "Flexible"
        Series3.ValueDataMembersSerializable = "ES;LF"
        Series3.View = OverlappedGanttSeriesView4
        Series4.ArgumentDataMember = "SL"
        Series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series4.DataSource = Me.ActivitiesTemplateBindingSource
        RangeBarSeriesLabel4.TextOrientation = DevExpress.XtraCharts.TextOrientation.BottomToTop
        RangeBarSeriesLabel4.TextPattern = "{A:G}: {V1:G}, {V2:G}"
        Series4.Label = RangeBarSeriesLabel4
        Series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series4.Name = "Critical"
        Series4.ValueDataMembersSerializable = "ES;EF"
        Series4.View = OverlappedGanttSeriesView5
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3, Series4}
        Me.ChartControl1.SeriesTemplate.View = OverlappedGanttSeriesView6
        Me.ChartControl1.Size = New System.Drawing.Size(575, 553)
        Me.ChartControl1.TabIndex = 8
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'TriangleRadioButton
        '
        Me.TriangleRadioButton.AutoSize = True
        Me.TriangleRadioButton.Checked = True
        Me.TriangleRadioButton.Location = New System.Drawing.Point(512, 16)
        Me.TriangleRadioButton.Name = "TriangleRadioButton"
        Me.TriangleRadioButton.Size = New System.Drawing.Size(63, 17)
        Me.TriangleRadioButton.TabIndex = 6
        Me.TriangleRadioButton.TabStop = True
        Me.TriangleRadioButton.Text = "Triangle"
        Me.TriangleRadioButton.UseVisualStyleBackColor = True
        Me.TriangleRadioButton.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Duration Calc by :"
        Me.Label2.Visible = False
        '
        'BetaRadioButton
        '
        Me.BetaRadioButton.AutoSize = True
        Me.BetaRadioButton.Location = New System.Drawing.Point(459, 16)
        Me.BetaRadioButton.Name = "BetaRadioButton"
        Me.BetaRadioButton.Size = New System.Drawing.Size(47, 17)
        Me.BetaRadioButton.TabIndex = 5
        Me.BetaRadioButton.Text = "Beta"
        Me.BetaRadioButton.UseVisualStyleBackColor = True
        Me.BetaRadioButton.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(973, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Day Require"
        '
        'TTLDayRequireTextBox
        '
        Me.TTLDayRequireTextBox.BackColor = System.Drawing.Color.Orange
        Me.TTLDayRequireTextBox.Location = New System.Drawing.Point(1043, 4)
        Me.TTLDayRequireTextBox.Name = "TTLDayRequireTextBox"
        Me.TTLDayRequireTextBox.Size = New System.Drawing.Size(38, 20)
        Me.TTLDayRequireTextBox.TabIndex = 9
        '
        'CalculateEarlyButton
        '
        Me.CalculateEarlyButton.Location = New System.Drawing.Point(801, 1)
        Me.CalculateEarlyButton.Name = "CalculateEarlyButton"
        Me.CalculateEarlyButton.Size = New System.Drawing.Size(133, 23)
        Me.CalculateEarlyButton.TabIndex = 1
        Me.CalculateEarlyButton.Text = " Calculate Critical Path"
        Me.CalculateEarlyButton.UseVisualStyleBackColor = True
        '
        'ActivitiesListTableAdapter
        '
        Me.ActivitiesListTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Activities Template"
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
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(628, 1)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(51, 23)
        Me.ShowButton.TabIndex = 10
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'ActivitiesGroupTableAdapter
        '
        Me.ActivitiesGroupTableAdapter.ClearBeforeFill = True
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(694, 1)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(42, 23)
        Me.CopyButton.TabIndex = 11
        Me.CopyButton.Text = "Copy"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'PasteButton
        '
        Me.PasteButton.Location = New System.Drawing.Point(742, 1)
        Me.PasteButton.Name = "PasteButton"
        Me.PasteButton.Size = New System.Drawing.Size(42, 23)
        Me.PasteButton.TabIndex = 12
        Me.PasteButton.Text = "Paste"
        Me.PasteButton.UseVisualStyleBackColor = True
        '
        'ActivitiesSuccessorsTableAdapter
        '
        Me.ActivitiesSuccessorsTableAdapter.ClearBeforeFill = True
        '
        'ActivitiesTemplateLookupTableAdapter
        '
        Me.ActivitiesTemplateLookupTableAdapter.ClearBeforeFill = True
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(336, 2)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.ActivitiesGroupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "ActivitiesGroup"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "ActivitiesGroupId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(286, 20)
        Me.GridLookUpEdit1.TabIndex = 13
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colActivitiesGroup, Me.colLeadTime})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colActivitiesGroup
        '
        Me.colActivitiesGroup.FieldName = "ActivitiesGroup"
        Me.colActivitiesGroup.Name = "colActivitiesGroup"
        Me.colActivitiesGroup.Visible = True
        Me.colActivitiesGroup.VisibleIndex = 0
        '
        'colLeadTime
        '
        Me.colLeadTime.FieldName = "LeadTime"
        Me.colLeadTime.Name = "colLeadTime"
        Me.colLeadTime.Visible = True
        Me.colLeadTime.VisibleIndex = 1
        '
        'frmActivitiesTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 595)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.PasteButton)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.TTLDayRequireTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CalculateEarlyButton)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ActivitiesTemplateBindingNavigator)
        Me.Name = "frmActivitiesTemplate"
        Me.Text = "Activities Template"
        CType(Me.ActivitiesTemplateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesTemplateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesTemplateBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActivitiesTemplateBindingNavigator.ResumeLayout(False)
        Me.ActivitiesTemplateBindingNavigator.PerformLayout()
        CType(Me.ActivitiesTemplateGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitesListGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignForGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.ActivitiesTemplateDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesTemplateDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesListGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesTemplateLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesTemplateLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesSuccessorsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesSuccessorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(GanttDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RangeBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedGanttSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RangeBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedGanttSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedGanttSeriesView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivitiesGroupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ActivitiesTemplateDataSet As KSoft_Apparel.ActivitiesTemplateDataSet
    Friend WithEvents ActivitiesTemplateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesTemplateTableAdapter As KSoft_Apparel.ActivitiesTemplateDataSetTableAdapters.ActivitiesTemplateTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ActivitiesTemplateDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActivitiesTemplateBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ActivitiesTemplateBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ActivitiesTemplateGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ActivitiesTemplateDetailsTableAdapter As KSoft_Apparel.ActivitiesTemplateDataSetTableAdapters.ActivitiesTemplateDetailsTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ActivitiesTemplateDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesTemplateDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPredecessors As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActivitiesListGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ActivitiesListDataSet As KSoft_Apparel.ActivitiesListDataSet
    Friend WithEvents ActivitiesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesListTableAdapter As KSoft_Apparel.ActivitiesListDataSetTableAdapters.ActivitiesListTableAdapter
    Friend WithEvents colActivitiesListId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ActivitesListGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActivitiesListId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BetaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TriangleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CalculateEarlyButton As System.Windows.Forms.Button
    Friend WithEvents AsignForGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserDataSet As KSoft_Apparel.UserDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    'Friend WithEvents CPTemplateDataSet As KSoft_Apparel.CPTemplateDataSet
    'Friend WithEvents CP_TemplateTableAdapter As KSoft_Apparel.CPTemplateDataSetTableAdapters.CP_TemplateTableAdapter
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents colUSER_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActivitiesGroupDataSet As KSoft_Apparel.ActivitiesGroupDataSet
    Friend WithEvents ActivitiesGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesGroupTableAdapter As KSoft_Apparel.ActivitiesGroupDataSetTableAdapters.ActivitiesGroupTableAdapter
    Friend WithEvents colActivitiesListId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAAsign_UserId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDescription2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TTLDayRequireTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserLookupTableAdapter As KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents UserLookupDataSet As KSoft_Apparel.UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents CopyButton As System.Windows.Forms.Button
    Friend WithEvents PasteButton As System.Windows.Forms.Button
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ActivitiesSuccessorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesSuccessorsTableAdapter As KSoft_Apparel.ActivitiesTemplateDataSetTableAdapters.ActivitiesSuccessorsTableAdapter
    Friend WithEvents ActivitiesSuccessorsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDescription3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ActivitiesTemplateLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActivitiesTemplateLookupDataSet As KSoft_Apparel.ActivitiesTemplateLookupDataSet
    Friend WithEvents ActivitiesTemplateLookupTableAdapter As KSoft_Apparel.ActivitiesTemplateLookupDataSetTableAdapters.ActivitiesTemplateLookupTableAdapter
    Friend WithEvents DownButton As System.Windows.Forms.Button
    Friend WithEvents UpButton As System.Windows.Forms.Button
    Friend WithEvents ShowSuccessorsButton As System.Windows.Forms.Button
    Friend WithEvents colLeftDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colActivitiesGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLeadTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDuration1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSlack1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDependentTask As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
