<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLine))
        Me.LineDataSet = New KSoft_Apparel.LineDataSet()
        Me.LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineTableAdapter = New KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.LineDataSetTableAdapters.TableAdapterManager()
        Me.LineBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.LineBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SectionComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Apparel.UserDataSet()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New KSoft_Apparel.CompanyDataSet()
        Me.PMListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PMListDataSet = New KSoft_Apparel.PMListDataSet()
        Me.FloorInchargeListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FloorInchargeDataSet = New KSoft_Apparel.FloorInchargeDataSet()
        Me.LineChiefListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineCheifDataSet = New KSoft_Apparel.LineCheifDataSet()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.PMListTableAdapter = New KSoft_Apparel.PMListDataSetTableAdapters.PMListTableAdapter()
        Me.FloorInchargeListTableAdapter = New KSoft_Apparel.FloorInchargeDataSetTableAdapters.FloorInchargeListTableAdapter()
        Me.LineChiefListTableAdapter = New KSoft_Apparel.LineCheifDataSetTableAdapters.LineChiefListTableAdapter()
        Me.CompanyTableAdapter = New KSoft_Apparel.CompanyDataSetTableAdapters.CompanyTableAdapter()
        Me.UserTableAdapter = New KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.LineGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBranchId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BranchGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPMId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PMGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPMName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFloorInchargeId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FloorInchargeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanning = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLineCheifId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LineGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSortOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompanyGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSection = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMachine = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LineBindingNavigator.SuspendLayout()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FloorInchargeListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FloorInchargeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineChiefListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineCheifDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FloorInchargeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LineDataSet
        '
        Me.LineDataSet.DataSetName = "LineDataSet"
        Me.LineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineBindingSource
        '
        Me.LineBindingSource.DataMember = "Line"
        Me.LineBindingSource.DataSource = Me.LineDataSet
        '
        'LineTableAdapter
        '
        Me.LineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LineTableAdapter = Me.LineTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.LineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LineBindingNavigator
        '
        Me.LineBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LineBindingNavigator.BindingSource = Me.LineBindingSource
        Me.LineBindingNavigator.CountItem = Nothing
        Me.LineBindingNavigator.DeleteItem = Nothing
        Me.LineBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.LineBindingNavigatorSaveItem, Me.ToolStripLabel1, Me.SectionComboBox, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.LineBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LineBindingNavigator.MoveFirstItem = Nothing
        Me.LineBindingNavigator.MoveLastItem = Nothing
        Me.LineBindingNavigator.MoveNextItem = Nothing
        Me.LineBindingNavigator.MovePreviousItem = Nothing
        Me.LineBindingNavigator.Name = "LineBindingNavigator"
        Me.LineBindingNavigator.PositionItem = Nothing
        Me.LineBindingNavigator.Size = New System.Drawing.Size(1149, 25)
        Me.LineBindingNavigator.TabIndex = 0
        Me.LineBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'LineBindingNavigatorSaveItem
        '
        Me.LineBindingNavigatorSaveItem.Image = CType(resources.GetObject("LineBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LineBindingNavigatorSaveItem.Name = "LineBindingNavigatorSaveItem"
        Me.LineBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.LineBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(50, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(46, 22)
        Me.ToolStripLabel1.Text = "Section"
        '
        'SectionComboBox
        '
        Me.SectionComboBox.Items.AddRange(New Object() {"Cutting", "Printing", "Sewing"})
        Me.SectionComboBox.Name = "SectionComboBox"
        Me.SectionComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.KSoft_Apparel.My.Resources.Resources.Tick
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripButton1.Text = "   Show     "
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(105, 22)
        Me.ToolStripButton2.Text = "      Show All          "
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
        'BranchBindingSource
        '
        Me.BranchBindingSource.DataMember = "Branch"
        Me.BranchBindingSource.DataSource = Me.BranchDataSet
        '
        'BranchDataSet
        '
        Me.BranchDataSet.DataSetName = "BranchDataSet"
        Me.BranchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PMListBindingSource
        '
        Me.PMListBindingSource.DataMember = "PMList"
        Me.PMListBindingSource.DataSource = Me.PMListDataSet
        '
        'PMListDataSet
        '
        Me.PMListDataSet.DataSetName = "PMListDataSet"
        Me.PMListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FloorInchargeListBindingSource
        '
        Me.FloorInchargeListBindingSource.DataMember = "FloorInchargeList"
        Me.FloorInchargeListBindingSource.DataSource = Me.FloorInchargeDataSet
        '
        'FloorInchargeDataSet
        '
        Me.FloorInchargeDataSet.DataSetName = "FloorInchargeDataSet"
        Me.FloorInchargeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LineChiefListBindingSource
        '
        Me.LineChiefListBindingSource.DataMember = "LineChiefList"
        Me.LineChiefListBindingSource.DataSource = Me.LineCheifDataSet
        '
        'LineCheifDataSet
        '
        Me.LineCheifDataSet.DataSetName = "LineCheifDataSet"
        Me.LineCheifDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'PMListTableAdapter
        '
        Me.PMListTableAdapter.ClearBeforeFill = True
        '
        'FloorInchargeListTableAdapter
        '
        Me.FloorInchargeListTableAdapter.ClearBeforeFill = True
        '
        'LineChiefListTableAdapter
        '
        Me.LineChiefListTableAdapter.ClearBeforeFill = True
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'LineGridControl
        '
        Me.LineGridControl.DataSource = Me.LineBindingSource
        Me.LineGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LineGridControl.Location = New System.Drawing.Point(0, 25)
        Me.LineGridControl.MainView = Me.GridView1
        Me.LineGridControl.Name = "LineGridControl"
        Me.LineGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LineGridLookUpEdit, Me.CompanyGridLookUpEdit, Me.UserGridLookUpEdit, Me.BranchGridLookUpEdit, Me.PMGridLookUpEdit, Me.FloorInchargeGridLookUpEdit})
        Me.LineGridControl.Size = New System.Drawing.Size(1149, 356)
        Me.LineGridControl.TabIndex = 1
        Me.LineGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLine, Me.colBranchId, Me.colPMId, Me.colFloorInchargeId, Me.colPlanning, Me.colLineCheifId, Me.colSortOrder, Me.colCategory, Me.colCompanyId, Me.colSection, Me.colUserId, Me.colMachine})
        Me.GridView1.GridControl = Me.LineGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colLine
        '
        Me.colLine.FieldName = "Line"
        Me.colLine.Name = "colLine"
        Me.colLine.Visible = True
        Me.colLine.VisibleIndex = 1
        Me.colLine.Width = 62
        '
        'colBranchId
        '
        Me.colBranchId.Caption = "Branch"
        Me.colBranchId.ColumnEdit = Me.BranchGridLookUpEdit
        Me.colBranchId.FieldName = "BranchId"
        Me.colBranchId.Name = "colBranchId"
        Me.colBranchId.Visible = True
        Me.colBranchId.VisibleIndex = 3
        Me.colBranchId.Width = 77
        '
        'BranchGridLookUpEdit
        '
        Me.BranchGridLookUpEdit.AutoHeight = False
        Me.BranchGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BranchGridLookUpEdit.DataSource = Me.BranchBindingSource
        Me.BranchGridLookUpEdit.DisplayMember = "BranchCode"
        Me.BranchGridLookUpEdit.Name = "BranchGridLookUpEdit"
        Me.BranchGridLookUpEdit.NullText = ""
        Me.BranchGridLookUpEdit.ValueMember = "BranchId"
        Me.BranchGridLookUpEdit.View = Me.GridView4
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBranchCode})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colBranchCode
        '
        Me.colBranchCode.FieldName = "BranchCode"
        Me.colBranchCode.Name = "colBranchCode"
        Me.colBranchCode.Visible = True
        Me.colBranchCode.VisibleIndex = 0
        '
        'colPMId
        '
        Me.colPMId.Caption = "PM"
        Me.colPMId.ColumnEdit = Me.PMGridLookUpEdit
        Me.colPMId.FieldName = "PMId"
        Me.colPMId.Name = "colPMId"
        Me.colPMId.Visible = True
        Me.colPMId.VisibleIndex = 4
        Me.colPMId.Width = 64
        '
        'PMGridLookUpEdit
        '
        Me.PMGridLookUpEdit.AutoHeight = False
        Me.PMGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PMGridLookUpEdit.DataSource = Me.PMListBindingSource
        Me.PMGridLookUpEdit.DisplayMember = "PMName"
        Me.PMGridLookUpEdit.Name = "PMGridLookUpEdit"
        Me.PMGridLookUpEdit.NullText = ""
        Me.PMGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.PMGridLookUpEdit.ValueMember = "PMId"
        Me.PMGridLookUpEdit.View = Me.GridView5
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPMName})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colPMName
        '
        Me.colPMName.FieldName = "PMName"
        Me.colPMName.Name = "colPMName"
        Me.colPMName.Visible = True
        Me.colPMName.VisibleIndex = 0
        '
        'colFloorInchargeId
        '
        Me.colFloorInchargeId.Caption = "Floor Incharge"
        Me.colFloorInchargeId.ColumnEdit = Me.FloorInchargeGridLookUpEdit
        Me.colFloorInchargeId.FieldName = "FloorInchargeId"
        Me.colFloorInchargeId.Name = "colFloorInchargeId"
        Me.colFloorInchargeId.Visible = True
        Me.colFloorInchargeId.VisibleIndex = 5
        Me.colFloorInchargeId.Width = 100
        '
        'FloorInchargeGridLookUpEdit
        '
        Me.FloorInchargeGridLookUpEdit.AutoHeight = False
        Me.FloorInchargeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FloorInchargeGridLookUpEdit.DataSource = Me.FloorInchargeListBindingSource
        Me.FloorInchargeGridLookUpEdit.DisplayMember = "Name"
        Me.FloorInchargeGridLookUpEdit.Name = "FloorInchargeGridLookUpEdit"
        Me.FloorInchargeGridLookUpEdit.NullText = ""
        Me.FloorInchargeGridLookUpEdit.ValueMember = "FloorInchargeId"
        Me.FloorInchargeGridLookUpEdit.View = Me.GridView6
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName1})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colName1
        '
        Me.colName1.FieldName = "Name"
        Me.colName1.Name = "colName1"
        Me.colName1.Visible = True
        Me.colName1.VisibleIndex = 0
        '
        'colPlanning
        '
        Me.colPlanning.FieldName = "Planning"
        Me.colPlanning.Name = "colPlanning"
        Me.colPlanning.Visible = True
        Me.colPlanning.VisibleIndex = 6
        Me.colPlanning.Width = 53
        '
        'colLineCheifId
        '
        Me.colLineCheifId.Caption = "Line Cheif"
        Me.colLineCheifId.ColumnEdit = Me.LineGridLookUpEdit
        Me.colLineCheifId.FieldName = "LineCheifId"
        Me.colLineCheifId.Name = "colLineCheifId"
        Me.colLineCheifId.Visible = True
        Me.colLineCheifId.VisibleIndex = 7
        Me.colLineCheifId.Width = 73
        '
        'LineGridLookUpEdit
        '
        Me.LineGridLookUpEdit.AutoHeight = False
        Me.LineGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LineGridLookUpEdit.DataSource = Me.LineChiefListBindingSource
        Me.LineGridLookUpEdit.DisplayMember = "Name"
        Me.LineGridLookUpEdit.Name = "LineGridLookUpEdit"
        Me.LineGridLookUpEdit.NullText = ""
        Me.LineGridLookUpEdit.ValueMember = "LineChiefId"
        Me.LineGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colSortOrder
        '
        Me.colSortOrder.AppearanceCell.Options.UseTextOptions = True
        Me.colSortOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSortOrder.AppearanceHeader.Options.UseTextOptions = True
        Me.colSortOrder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSortOrder.Caption = "SL"
        Me.colSortOrder.FieldName = "SortOrder"
        Me.colSortOrder.Name = "colSortOrder"
        Me.colSortOrder.Visible = True
        Me.colSortOrder.VisibleIndex = 0
        Me.colSortOrder.Width = 57
        '
        'colCategory
        '
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 8
        Me.colCategory.Width = 71
        '
        'colCompanyId
        '
        Me.colCompanyId.Caption = "Company"
        Me.colCompanyId.ColumnEdit = Me.CompanyGridLookUpEdit
        Me.colCompanyId.FieldName = "CompanyId"
        Me.colCompanyId.Name = "colCompanyId"
        Me.colCompanyId.Visible = True
        Me.colCompanyId.VisibleIndex = 9
        Me.colCompanyId.Width = 85
        '
        'CompanyGridLookUpEdit
        '
        Me.CompanyGridLookUpEdit.AutoHeight = False
        Me.CompanyGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CompanyGridLookUpEdit.DataSource = Me.CompanyBindingSource
        Me.CompanyGridLookUpEdit.DisplayMember = "CompanyCode"
        Me.CompanyGridLookUpEdit.Name = "CompanyGridLookUpEdit"
        Me.CompanyGridLookUpEdit.NullText = ""
        Me.CompanyGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.CompanyGridLookUpEdit.ValueMember = "CompanyId"
        Me.CompanyGridLookUpEdit.View = Me.GridView2
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompanyCode})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colCompanyCode
        '
        Me.colCompanyCode.FieldName = "CompanyCode"
        Me.colCompanyCode.Name = "colCompanyCode"
        Me.colCompanyCode.Visible = True
        Me.colCompanyCode.VisibleIndex = 0
        '
        'colSection
        '
        Me.colSection.FieldName = "Section"
        Me.colSection.Name = "colSection"
        Me.colSection.Visible = True
        Me.colSection.VisibleIndex = 10
        Me.colSection.Width = 96
        '
        'colUserId
        '
        Me.colUserId.Caption = "User"
        Me.colUserId.ColumnEdit = Me.UserGridLookUpEdit
        Me.colUserId.FieldName = "UserId"
        Me.colUserId.Name = "colUserId"
        Me.colUserId.Visible = True
        Me.colUserId.VisibleIndex = 11
        Me.colUserId.Width = 334
        '
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.AutoHeight = False
        Me.UserGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.DataSource = Me.UserBindingSource
        Me.UserGridLookUpEdit.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.ValueMember = "USER_ID"
        Me.UserGridLookUpEdit.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'colMachine
        '
        Me.colMachine.FieldName = "Machine"
        Me.colMachine.Name = "colMachine"
        Me.colMachine.Visible = True
        Me.colMachine.VisibleIndex = 2
        Me.colMachine.Width = 59
        '
        'frmLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 381)
        Me.Controls.Add(Me.LineGridControl)
        Me.Controls.Add(Me.LineBindingNavigator)
        Me.Name = "frmLine"
        Me.Text = "Line"
        CType(Me.LineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LineBindingNavigator.ResumeLayout(False)
        Me.LineBindingNavigator.PerformLayout()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FloorInchargeListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FloorInchargeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineChiefListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineCheifDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FloorInchargeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LineDataSet As KSoft_Apparel.LineDataSet
    Friend WithEvents LineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineTableAdapter As KSoft_Apparel.LineDataSetTableAdapters.LineTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.LineDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LineBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LineBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents PMListDataSet As KSoft_Apparel.PMListDataSet
    Friend WithEvents PMListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PMListTableAdapter As KSoft_Apparel.PMListDataSetTableAdapters.PMListTableAdapter
    Friend WithEvents FloorInchargeDataSet As KSoft_Apparel.FloorInchargeDataSet
    Friend WithEvents FloorInchargeListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FloorInchargeListTableAdapter As KSoft_Apparel.FloorInchargeDataSetTableAdapters.FloorInchargeListTableAdapter
    Friend WithEvents LineCheifDataSet As KSoft_Apparel.LineCheifDataSet
    Friend WithEvents LineChiefListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LineChiefListTableAdapter As KSoft_Apparel.LineCheifDataSetTableAdapters.LineChiefListTableAdapter
    Friend WithEvents CompanyDataSet As KSoft_Apparel.CompanyDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As KSoft_Apparel.CompanyDataSetTableAdapters.CompanyTableAdapter
    Friend WithEvents UserDataSet As KSoft_Apparel.UserDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As KSoft_Apparel.UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents SectionComboBox As ToolStripComboBox
    Friend WithEvents LineGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBranchId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPMId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFloorInchargeId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanning As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineCheifId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSortOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSection As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMachine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LineGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompanyGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCompanyCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents BranchGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PMGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPMName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FloorInchargeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colName1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
