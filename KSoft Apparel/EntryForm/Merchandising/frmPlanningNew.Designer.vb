<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanningNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanningNew))
        Dim GanttDiagram1 As DevExpress.XtraCharts.GanttDiagram = New DevExpress.XtraCharts.GanttDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim OverlappedGanttSeriesView1 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim OverlappedGanttSeriesView2 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
        Dim OverlappedGanttSeriesView3 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
        Dim GanttDiagram2 As DevExpress.XtraCharts.GanttDiagram = New DevExpress.XtraCharts.GanttDiagram()
        Dim RangeBarSeriesLabel1 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel()
        Dim SideBySideGanttSeriesView1 As DevExpress.XtraCharts.SideBySideGanttSeriesView = New DevExpress.XtraCharts.SideBySideGanttSeriesView()
        Me.PlanningBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanningNewDataSet = New KSoft_Apparel.PlanningNewDataSet()
        Me.SewingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckedComboBoxEdit1 = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemCheckedComboBoxEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineDataSet = New KSoft_Apparel.LineDataSet()
        Me.RepositoryItemCheckedComboBoxEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TodoXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.Todo = New DevExpress.XtraTab.XtraTabPage()
        Me.PlanningBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PlanningBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PlanningGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanningFromDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanningToDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanningQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Completed = New DevExpress.XtraTab.XtraTabPage()
        Me.SewingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SewingGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSewingFromDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSewingToDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSewingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLine1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.PlanningTableAdapter = New KSoft_Apparel.PlanningNewDataSetTableAdapters.PlanningTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.PlanningNewDataSetTableAdapters.TableAdapterManager()
        Me.SewingTableAdapter = New KSoft_Apparel.PlanningNewDataSetTableAdapters.SewingTableAdapter()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
        CType(Me.PlanningBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanningNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SewingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CheckedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TodoXtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TodoXtraTabControl.SuspendLayout()
        Me.Todo.SuspendLayout()
        CType(Me.PlanningBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlanningBindingNavigator.SuspendLayout()
        CType(Me.PlanningGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Completed.SuspendLayout()
        CType(Me.SewingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SewingBindingNavigator.SuspendLayout()
        CType(Me.SewingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(GanttDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedGanttSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedGanttSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedGanttSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(GanttDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideGanttSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlanningBindingSource
        '
        Me.PlanningBindingSource.DataMember = "Planning"
        Me.PlanningBindingSource.DataSource = Me.PlanningNewDataSet
        '
        'PlanningNewDataSet
        '
        Me.PlanningNewDataSet.DataSetName = "PlanningNewDataSet"
        Me.PlanningNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SewingBindingSource
        '
        Me.SewingBindingSource.DataMember = "Sewing"
        Me.SewingBindingSource.DataSource = Me.PlanningNewDataSet
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.TodoXtraTabControl)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(878, 557)
        Me.SplitContainerControl1.SplitterPosition = 262
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CheckedComboBoxEdit1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(878, 36)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CheckedComboBoxEdit1
        '
        Me.CheckedComboBoxEdit1.Location = New System.Drawing.Point(76, 12)
        Me.CheckedComboBoxEdit1.MenuManager = Me.BarManager1
        Me.CheckedComboBoxEdit1.Name = "CheckedComboBoxEdit1"
        Me.CheckedComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CheckedComboBoxEdit1.Properties.DataSource = Me.LineBindingSource
        Me.CheckedComboBoxEdit1.Properties.DisplayMember = "Line"
        Me.CheckedComboBoxEdit1.Properties.ValueMember = "Line"
        Me.CheckedComboBoxEdit1.Size = New System.Drawing.Size(773, 20)
        Me.CheckedComboBoxEdit1.StyleController = Me.LayoutControl1
        Me.CheckedComboBoxEdit1.TabIndex = 4
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarEditItem1})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckedComboBoxEdit1, Me.RepositoryItemCheckedComboBoxEdit2})
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(878, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 557)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(878, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 557)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(878, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 557)
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Filter By Line"
        Me.BarEditItem1.Edit = Me.RepositoryItemCheckedComboBoxEdit2
        Me.BarEditItem1.EditWidth = 200
        Me.BarEditItem1.Id = 3
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemCheckedComboBoxEdit2
        '
        Me.RepositoryItemCheckedComboBoxEdit2.AutoHeight = False
        Me.RepositoryItemCheckedComboBoxEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCheckedComboBoxEdit2.DataSource = Me.LineBindingSource
        Me.RepositoryItemCheckedComboBoxEdit2.DisplayMember = "Line"
        Me.RepositoryItemCheckedComboBoxEdit2.Name = "RepositoryItemCheckedComboBoxEdit2"
        Me.RepositoryItemCheckedComboBoxEdit2.ValueMember = "LineId"
        '
        'LineBindingSource
        '
        Me.LineBindingSource.DataMember = "Line"
        Me.LineBindingSource.DataSource = Me.LineDataSet
        '
        'LineDataSet
        '
        Me.LineDataSet.DataSetName = "LineDataSet"
        Me.LineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemCheckedComboBoxEdit1
        '
        Me.RepositoryItemCheckedComboBoxEdit1.AutoHeight = False
        Me.RepositoryItemCheckedComboBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCheckedComboBoxEdit1.DataSource = Me.LineBindingSource
        Me.RepositoryItemCheckedComboBoxEdit1.DisplayMember = "Line"
        Me.RepositoryItemCheckedComboBoxEdit1.Name = "RepositoryItemCheckedComboBoxEdit1"
        Me.RepositoryItemCheckedComboBoxEdit1.ValueMember = "LineId"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(861, 44)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CheckedComboBoxEdit1
        Me.LayoutControlItem1.CustomizationFormText = "Filter By Line"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(841, 24)
        Me.LayoutControlItem1.Text = "Filter By Line"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(61, 13)
        '
        'TodoXtraTabControl
        '
        Me.TodoXtraTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TodoXtraTabControl.Location = New System.Drawing.Point(0, 36)
        Me.TodoXtraTabControl.Name = "TodoXtraTabControl"
        Me.TodoXtraTabControl.SelectedTabPage = Me.Todo
        Me.TodoXtraTabControl.Size = New System.Drawing.Size(878, 226)
        Me.TodoXtraTabControl.TabIndex = 0
        Me.TodoXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.Todo, Me.Completed})
        '
        'Todo
        '
        Me.Todo.AutoScroll = True
        Me.Todo.Controls.Add(Me.PlanningBindingNavigator)
        Me.Todo.Controls.Add(Me.PlanningGridControl)
        Me.Todo.Name = "Todo"
        Me.Todo.Size = New System.Drawing.Size(873, 200)
        Me.Todo.Text = "To-do"
        '
        'PlanningBindingNavigator
        '
        Me.PlanningBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlanningBindingNavigator.BindingSource = Me.PlanningBindingSource
        Me.PlanningBindingNavigator.CountItem = Nothing
        Me.PlanningBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PlanningBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PlanningBindingNavigatorSaveItem})
        Me.PlanningBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PlanningBindingNavigator.MoveFirstItem = Nothing
        Me.PlanningBindingNavigator.MoveLastItem = Nothing
        Me.PlanningBindingNavigator.MoveNextItem = Nothing
        Me.PlanningBindingNavigator.MovePreviousItem = Nothing
        Me.PlanningBindingNavigator.Name = "PlanningBindingNavigator"
        Me.PlanningBindingNavigator.PositionItem = Nothing
        Me.PlanningBindingNavigator.Size = New System.Drawing.Size(873, 25)
        Me.PlanningBindingNavigator.TabIndex = 1
        Me.PlanningBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PlanningBindingNavigatorSaveItem
        '
        Me.PlanningBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlanningBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlanningBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlanningBindingNavigatorSaveItem.Name = "PlanningBindingNavigatorSaveItem"
        Me.PlanningBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PlanningBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PlanningGridControl
        '
        Me.PlanningGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlanningGridControl.DataSource = Me.PlanningBindingSource
        Me.PlanningGridControl.Location = New System.Drawing.Point(3, 28)
        Me.PlanningGridControl.MainView = Me.GridView1
        Me.PlanningGridControl.Name = "PlanningGridControl"
        Me.PlanningGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1})
        Me.PlanningGridControl.Size = New System.Drawing.Size(863, 165)
        Me.PlanningGridControl.TabIndex = 0
        Me.PlanningGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLine, Me.colProgramNo, Me.colFabricColorName, Me.colPlanningFromDate, Me.colPlanningToDate, Me.colPlanningQuantity})
        Me.GridView1.GridControl = Me.PlanningGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colLine
        '
        Me.colLine.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colLine.FieldName = "Line"
        Me.colLine.Name = "colLine"
        Me.colLine.Visible = True
        Me.colLine.VisibleIndex = 2
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.LineBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "Line"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "Line"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 1
        '
        'colPlanningFromDate
        '
        Me.colPlanningFromDate.FieldName = "PlanningFromDate"
        Me.colPlanningFromDate.Name = "colPlanningFromDate"
        Me.colPlanningFromDate.Visible = True
        Me.colPlanningFromDate.VisibleIndex = 3
        '
        'colPlanningToDate
        '
        Me.colPlanningToDate.FieldName = "PlanningToDate"
        Me.colPlanningToDate.Name = "colPlanningToDate"
        Me.colPlanningToDate.Visible = True
        Me.colPlanningToDate.VisibleIndex = 4
        '
        'colPlanningQuantity
        '
        Me.colPlanningQuantity.FieldName = "PlanningQuantity"
        Me.colPlanningQuantity.Name = "colPlanningQuantity"
        Me.colPlanningQuantity.Visible = True
        Me.colPlanningQuantity.VisibleIndex = 5
        '
        'Completed
        '
        Me.Completed.AutoScroll = True
        Me.Completed.Controls.Add(Me.SewingBindingNavigator)
        Me.Completed.Controls.Add(Me.SewingGridControl)
        Me.Completed.Name = "Completed"
        Me.Completed.Size = New System.Drawing.Size(873, 200)
        Me.Completed.Text = "Completed"
        '
        'SewingBindingNavigator
        '
        Me.SewingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.SewingBindingNavigator.BindingSource = Me.SewingBindingSource
        Me.SewingBindingNavigator.CountItem = Nothing
        Me.SewingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.SewingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.SaveToolStripButton})
        Me.SewingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SewingBindingNavigator.MoveFirstItem = Nothing
        Me.SewingBindingNavigator.MoveLastItem = Nothing
        Me.SewingBindingNavigator.MoveNextItem = Nothing
        Me.SewingBindingNavigator.MovePreviousItem = Nothing
        Me.SewingBindingNavigator.Name = "SewingBindingNavigator"
        Me.SewingBindingNavigator.PositionItem = Nothing
        Me.SewingBindingNavigator.Size = New System.Drawing.Size(873, 25)
        Me.SewingBindingNavigator.TabIndex = 1
        Me.SewingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'SewingGridControl
        '
        Me.SewingGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SewingGridControl.DataSource = Me.SewingBindingSource
        Me.SewingGridControl.Location = New System.Drawing.Point(3, 28)
        Me.SewingGridControl.MainView = Me.GridView2
        Me.SewingGridControl.Name = "SewingGridControl"
        Me.SewingGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemGridLookUpEdit2})
        Me.SewingGridControl.Size = New System.Drawing.Size(863, 165)
        Me.SewingGridControl.TabIndex = 0
        Me.SewingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSewingFromDate, Me.colSewingToDate, Me.colSewingQuantity, Me.colProgramNo1, Me.colFabricColorName1, Me.colLine1})
        Me.GridView2.GridControl = Me.SewingGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colSewingFromDate
        '
        Me.colSewingFromDate.FieldName = "SewingFromDate"
        Me.colSewingFromDate.Name = "colSewingFromDate"
        Me.colSewingFromDate.Visible = True
        Me.colSewingFromDate.VisibleIndex = 3
        '
        'colSewingToDate
        '
        Me.colSewingToDate.FieldName = "SewingToDate"
        Me.colSewingToDate.Name = "colSewingToDate"
        Me.colSewingToDate.Visible = True
        Me.colSewingToDate.VisibleIndex = 4
        '
        'colSewingQuantity
        '
        Me.colSewingQuantity.FieldName = "SewingQuantity"
        Me.colSewingQuantity.Name = "colSewingQuantity"
        Me.colSewingQuantity.Visible = True
        Me.colSewingQuantity.VisibleIndex = 5
        '
        'colProgramNo1
        '
        Me.colProgramNo1.FieldName = "ProgramNo"
        Me.colProgramNo1.Name = "colProgramNo1"
        Me.colProgramNo1.Visible = True
        Me.colProgramNo1.VisibleIndex = 0
        '
        'colFabricColorName1
        '
        Me.colFabricColorName1.FieldName = "FabricColorName"
        Me.colFabricColorName1.Name = "colFabricColorName1"
        Me.colFabricColorName1.Visible = True
        Me.colFabricColorName1.VisibleIndex = 1
        '
        'colLine1
        '
        Me.colLine1.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.colLine1.FieldName = "Line"
        Me.colLine1.Name = "colLine1"
        Me.colLine1.Visible = True
        Me.colLine1.VisibleIndex = 2
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.LineBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "Line"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "Line"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(878, 289)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.ChartControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(873, 263)
        Me.XtraTabPage1.Text = "Order Wise"
        '
        'ChartControl1
        '
        Me.ChartControl1.DataBindings = Nothing
        GanttDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        GanttDiagram1.AxisY.Label.Angle = -90
        GanttDiagram1.AxisY.Label.TextPattern = "{V:dd-MM}"
        GanttDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = GanttDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "ProgramNo"
        Series1.DataSource = Me.PlanningBindingSource
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series1.Name = "To-do"
        Series1.ValueDataMembersSerializable = "PlanningFromDate;PlanningToDate"
        Series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Series1.View = OverlappedGanttSeriesView1
        Series2.ArgumentDataMember = "ProgramNo"
        Series2.DataSource = Me.SewingBindingSource
        Series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
        Series2.Name = "Completed"
        Series2.ValueDataMembersSerializable = "SewingFromDate;SewingToDate"
        Series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        OverlappedGanttSeriesView2.BarWidth = 0.4R
        Series2.View = OverlappedGanttSeriesView2
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        Me.ChartControl1.SeriesTemplate.View = OverlappedGanttSeriesView3
        Me.ChartControl1.Size = New System.Drawing.Size(873, 263)
        Me.ChartControl1.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.ChartControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(873, 263)
        Me.XtraTabPage2.Text = "Line Wise"
        '
        'ChartControl2
        '
        Me.ChartControl2.AppearanceNameSerializable = "Dark Flat"
        Me.ChartControl2.DataBindings = Nothing
        Me.ChartControl2.DataSource = Me.PlanningBindingSource
        GanttDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        GanttDiagram2.AxisY.Label.Angle = -90
        GanttDiagram2.AxisY.Label.TextPattern = "{V:dd-MM}"
        GanttDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl2.Diagram = GanttDiagram2
        Me.ChartControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl2.Legend.Name = "Default Legend"
        Me.ChartControl2.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl2.Name = "ChartControl2"
        Me.ChartControl2.PaletteName = "Nature Colors"
        Me.ChartControl2.SeriesDataMember = "ProgramNo"
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl2.SeriesTemplate.ArgumentDataMember = "Line"
        RangeBarSeriesLabel1.Kind = DevExpress.XtraCharts.RangeBarLabelKind.OneLabel
        Me.ChartControl2.SeriesTemplate.Label = RangeBarSeriesLabel1
        Me.ChartControl2.SeriesTemplate.LegendTextPattern = "{S}"
        Me.ChartControl2.SeriesTemplate.ValueDataMembersSerializable = "PlanningFromDate;PlanningToDate"
        Me.ChartControl2.SeriesTemplate.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        Me.ChartControl2.SeriesTemplate.View = SideBySideGanttSeriesView1
        Me.ChartControl2.Size = New System.Drawing.Size(873, 263)
        Me.ChartControl2.TabIndex = 0
        '
        'PlanningTableAdapter
        '
        Me.PlanningTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PlanningTableAdapter = Me.PlanningTableAdapter
        Me.TableAdapterManager.SewingTableAdapter = Me.SewingTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.PlanningNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SewingTableAdapter
        '
        Me.SewingTableAdapter.ClearBeforeFill = True
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'frmPlanningNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 557)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmPlanningNew"
        Me.Text = "frmPlanningNew"
        CType(Me.PlanningBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanningNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SewingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CheckedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TodoXtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TodoXtraTabControl.ResumeLayout(False)
        Me.Todo.ResumeLayout(False)
        Me.Todo.PerformLayout()
        CType(Me.PlanningBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlanningBindingNavigator.ResumeLayout(False)
        Me.PlanningBindingNavigator.PerformLayout()
        CType(Me.PlanningGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Completed.ResumeLayout(False)
        Me.Completed.PerformLayout()
        CType(Me.SewingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SewingBindingNavigator.ResumeLayout(False)
        Me.SewingBindingNavigator.PerformLayout()
        CType(Me.SewingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(GanttDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedGanttSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedGanttSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedGanttSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(GanttDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideGanttSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents TodoXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Todo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Completed As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PlanningNewDataSet As KSoft_Apparel.PlanningNewDataSet
    Friend WithEvents PlanningBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PlanningTableAdapter As KSoft_Apparel.PlanningNewDataSetTableAdapters.PlanningTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.PlanningNewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlanningBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PlanningBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PlanningGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPlanningFromDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanningToDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanningQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SewingTableAdapter As KSoft_Apparel.PlanningNewDataSetTableAdapters.SewingTableAdapter
    Friend WithEvents SewingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SewingBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SewingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemCheckedComboBoxEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
    Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemCheckedComboBoxEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents colLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingFromDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingToDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSewingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLine1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents CheckedComboBoxEdit1 As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
