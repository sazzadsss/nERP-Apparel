<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGatepass
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
        Dim GatePassIdLabel As System.Windows.Forms.Label
        Dim GatepassDateLabel As System.Windows.Forms.Label
        Dim DeliveryToLabel As System.Windows.Forms.Label
        Dim DeliveryByLabel As System.Windows.Forms.Label
        Dim GatePassTypeLabel1 As System.Windows.Forms.Label
        Dim RefNoLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGatepass))
        Me.GatePassDataSet = New KSoft_Apparel.GatePassDataSet()
        Me.GatePassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GatePassTableAdapter = New KSoft_Apparel.GatePassDataSetTableAdapters.GatePassTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.GatePassDataSetTableAdapters.TableAdapterManager()
        Me.GatePassDetailsTableAdapter = New KSoft_Apparel.GatePassDataSetTableAdapters.GatePassDetailsTableAdapter()
        Me.GatePassBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.GatePassBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GatepassDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.DeliveryToTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DeliveryByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GatePassDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GatePassDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGatePassDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGatePassId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SampleRequestColorLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestColorLookupDataSet = New KSoft_Apparel.SampleRequestColorLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSampleRequestDetailsId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSampleRequestId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GatePassTypeComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RefNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GatePassNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SampleRequestColorLookupTableAdapter = New KSoft_Apparel.SampleRequestColorLookupDataSetTableAdapters.SampleRequestColorLookupTableAdapter()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GatePassLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGatePassNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGatepassDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GatePassLookupTableAdapter = New KSoft_Apparel.GatePassDataSetTableAdapters.GatePassLookupTableAdapter()
        GatePassIdLabel = New System.Windows.Forms.Label()
        GatepassDateLabel = New System.Windows.Forms.Label()
        DeliveryToLabel = New System.Windows.Forms.Label()
        DeliveryByLabel = New System.Windows.Forms.Label()
        GatePassTypeLabel1 = New System.Windows.Forms.Label()
        RefNoLabel1 = New System.Windows.Forms.Label()
        CType(Me.GatePassDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GatePassBindingNavigator.SuspendLayout()
        CType(Me.GatepassDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatepassDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryToTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestColorLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestColorLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RefNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GatePassLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GatePassIdLabel
        '
        GatePassIdLabel.AutoSize = True
        GatePassIdLabel.Location = New System.Drawing.Point(23, 27)
        GatePassIdLabel.Name = "GatePassIdLabel"
        GatePassIdLabel.Size = New System.Drawing.Size(107, 13)
        GatePassIdLabel.TabIndex = 1
        GatePassIdLabel.Text = "Gate Pass No [Auto]:"
        '
        'GatepassDateLabel
        '
        GatepassDateLabel.AutoSize = True
        GatepassDateLabel.Location = New System.Drawing.Point(23, 53)
        GatepassDateLabel.Name = "GatepassDateLabel"
        GatepassDateLabel.Size = New System.Drawing.Size(81, 13)
        GatepassDateLabel.TabIndex = 3
        GatepassDateLabel.Text = "Gatepass Date:"
        '
        'DeliveryToLabel
        '
        DeliveryToLabel.AutoSize = True
        DeliveryToLabel.Location = New System.Drawing.Point(255, 27)
        DeliveryToLabel.Name = "DeliveryToLabel"
        DeliveryToLabel.Size = New System.Drawing.Size(64, 13)
        DeliveryToLabel.TabIndex = 5
        DeliveryToLabel.Text = "Delivery To:"
        '
        'DeliveryByLabel
        '
        DeliveryByLabel.AutoSize = True
        DeliveryByLabel.Location = New System.Drawing.Point(255, 53)
        DeliveryByLabel.Name = "DeliveryByLabel"
        DeliveryByLabel.Size = New System.Drawing.Size(63, 13)
        DeliveryByLabel.TabIndex = 7
        DeliveryByLabel.Text = "Delivery By:"
        '
        'GatePassTypeLabel1
        '
        GatePassTypeLabel1.AutoSize = True
        GatePassTypeLabel1.Location = New System.Drawing.Point(533, 27)
        GatePassTypeLabel1.Name = "GatePassTypeLabel1"
        GatePassTypeLabel1.Size = New System.Drawing.Size(130, 13)
        GatePassTypeLabel1.TabIndex = 11
        GatePassTypeLabel1.Text = "Gate Pass Type [Sample]:"
        '
        'RefNoLabel1
        '
        RefNoLabel1.AutoSize = True
        RefNoLabel1.Location = New System.Drawing.Point(533, 57)
        RefNoLabel1.Name = "RefNoLabel1"
        RefNoLabel1.Size = New System.Drawing.Size(44, 13)
        RefNoLabel1.TabIndex = 12
        RefNoLabel1.Text = "Ref No:"
        '
        'GatePassDataSet
        '
        Me.GatePassDataSet.DataSetName = "GatePassDataSet"
        Me.GatePassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GatePassBindingSource
        '
        Me.GatePassBindingSource.DataMember = "GatePass"
        Me.GatePassBindingSource.DataSource = Me.GatePassDataSet
        '
        'GatePassTableAdapter
        '
        Me.GatePassTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GatePassDetailsTableAdapter = Me.GatePassDetailsTableAdapter
        Me.TableAdapterManager.GatePassLookupTableAdapter = Nothing
        Me.TableAdapterManager.GatePassTableAdapter = Me.GatePassTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.GatePassDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GatePassDetailsTableAdapter
        '
        Me.GatePassDetailsTableAdapter.ClearBeforeFill = True
        '
        'GatePassBindingNavigator
        '
        Me.GatePassBindingNavigator.AddNewItem = Nothing
        Me.GatePassBindingNavigator.BindingSource = Me.GatePassBindingSource
        Me.GatePassBindingNavigator.CountItem = Nothing
        Me.GatePassBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GatePassBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.BindingNavigatorAddNewItem, Me.GatePassBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.ToolStripButton2})
        Me.GatePassBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GatePassBindingNavigator.MoveFirstItem = Nothing
        Me.GatePassBindingNavigator.MoveLastItem = Nothing
        Me.GatePassBindingNavigator.MoveNextItem = Nothing
        Me.GatePassBindingNavigator.MovePreviousItem = Nothing
        Me.GatePassBindingNavigator.Name = "GatePassBindingNavigator"
        Me.GatePassBindingNavigator.PositionItem = Nothing
        Me.GatePassBindingNavigator.Size = New System.Drawing.Size(870, 25)
        Me.GatePassBindingNavigator.TabIndex = 0
        Me.GatePassBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'GatePassBindingNavigatorSaveItem
        '
        Me.GatePassBindingNavigatorSaveItem.Image = CType(resources.GetObject("GatePassBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GatePassBindingNavigatorSaveItem.Name = "GatePassBindingNavigatorSaveItem"
        Me.GatePassBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.GatePassBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton1.Text = "Print"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(50, 1, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripLabel1.Text = "Gate Pass No :"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(150, 1, 0, 2)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(109, 22)
        Me.ToolStripButton2.Text = "Show Gate Pass"
        '
        'GatepassDateDateEdit
        '
        Me.GatepassDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GatePassBindingSource, "GatepassDate", True))
        Me.GatepassDateDateEdit.EditValue = Nothing
        Me.GatepassDateDateEdit.Location = New System.Drawing.Point(138, 50)
        Me.GatepassDateDateEdit.Name = "GatepassDateDateEdit"
        Me.GatepassDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GatepassDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.GatepassDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.GatepassDateDateEdit.TabIndex = 4
        '
        'DeliveryToTextEdit
        '
        Me.DeliveryToTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GatePassBindingSource, "DeliveryTo", True))
        Me.DeliveryToTextEdit.Location = New System.Drawing.Point(324, 24)
        Me.DeliveryToTextEdit.Name = "DeliveryToTextEdit"
        Me.DeliveryToTextEdit.Size = New System.Drawing.Size(193, 20)
        Me.DeliveryToTextEdit.TabIndex = 6
        '
        'DeliveryByTextEdit
        '
        Me.DeliveryByTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GatePassBindingSource, "DeliveryBy", True))
        Me.DeliveryByTextEdit.Location = New System.Drawing.Point(324, 50)
        Me.DeliveryByTextEdit.Name = "DeliveryByTextEdit"
        Me.DeliveryByTextEdit.Size = New System.Drawing.Size(193, 20)
        Me.DeliveryByTextEdit.TabIndex = 8
        '
        'GatePassDetailsBindingSource
        '
        Me.GatePassDetailsBindingSource.DataMember = "FK_GatePassDetails_GatePass"
        Me.GatePassDetailsBindingSource.DataSource = Me.GatePassBindingSource
        '
        'GatePassDetailsGridControl
        '
        Me.GatePassDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GatePassDetailsGridControl.DataSource = Me.GatePassDetailsBindingSource
        Me.GatePassDetailsGridControl.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GatePassDetailsGridControl.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GatePassDetailsGridControl.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GatePassDetailsGridControl.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GatePassDetailsGridControl.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GatePassDetailsGridControl.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GatePassDetailsGridControl.Location = New System.Drawing.Point(14, 146)
        Me.GatePassDetailsGridControl.MainView = Me.GridView1
        Me.GatePassDetailsGridControl.Name = "GatePassDetailsGridControl"
        Me.GatePassDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.UnitGridLookUpEdit, Me.ItemGridLookUpEdit})
        Me.GatePassDetailsGridControl.Size = New System.Drawing.Size(844, 296)
        Me.GatePassDetailsGridControl.TabIndex = 11
        Me.GatePassDetailsGridControl.UseEmbeddedNavigator = True
        Me.GatePassDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGatePassDetailsId, Me.colGatePassId, Me.colItemId, Me.colUnitId, Me.colQuantity, Me.colRemarks})
        Me.GridView1.GridControl = Me.GatePassDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colGatePassDetailsId
        '
        Me.colGatePassDetailsId.FieldName = "GatePassDetailsId"
        Me.colGatePassDetailsId.Name = "colGatePassDetailsId"
        Me.colGatePassDetailsId.OptionsColumn.ReadOnly = True
        '
        'colGatePassId
        '
        Me.colGatePassId.FieldName = "GatePassId"
        Me.colGatePassId.Name = "colGatePassId"
        '
        'colItemId
        '
        Me.colItemId.Caption = "Item"
        Me.colItemId.ColumnEdit = Me.ItemGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 354
        '
        'ItemGridLookUpEdit
        '
        Me.ItemGridLookUpEdit.AutoHeight = False
        Me.ItemGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemGridLookUpEdit.DataSource = Me.SampleRequestColorLookupBindingSource
        Me.ItemGridLookUpEdit.DisplayMember = "Details"
        Me.ItemGridLookUpEdit.ImmediatePopup = True
        Me.ItemGridLookUpEdit.Name = "ItemGridLookUpEdit"
        Me.ItemGridLookUpEdit.NullText = ""
        Me.ItemGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemGridLookUpEdit.PopupView = Me.GridView2
        Me.ItemGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemGridLookUpEdit.ValueMember = "SampleRequestDetailsId"
        '
        'SampleRequestColorLookupBindingSource
        '
        Me.SampleRequestColorLookupBindingSource.DataMember = "SampleRequestColorLookup"
        Me.SampleRequestColorLookupBindingSource.DataSource = Me.SampleRequestColorLookupDataSet
        '
        'SampleRequestColorLookupDataSet
        '
        Me.SampleRequestColorLookupDataSet.DataSetName = "SampleRequestColorLookupDataSet"
        Me.SampleRequestColorLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSampleRequestDetailsId, Me.colSampleRequestId, Me.colFabricColorId, Me.colFabricColorName, Me.colRequestNo, Me.colDetails})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colSampleRequestDetailsId
        '
        Me.colSampleRequestDetailsId.FieldName = "SampleRequestDetailsId"
        Me.colSampleRequestDetailsId.Name = "colSampleRequestDetailsId"
        Me.colSampleRequestDetailsId.OptionsColumn.ReadOnly = True
        '
        'colSampleRequestId
        '
        Me.colSampleRequestId.FieldName = "SampleRequestId"
        Me.colSampleRequestId.Name = "colSampleRequestId"
        '
        'colFabricColorId
        '
        Me.colFabricColorId.FieldName = "FabricColorId"
        Me.colFabricColorId.Name = "colFabricColorId"
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        '
        'colRequestNo
        '
        Me.colRequestNo.FieldName = "RequestNo"
        Me.colRequestNo.Name = "colRequestNo"
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'colUnitId
        '
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.UnitGridLookUpEdit
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.Width = 77
        '
        'UnitGridLookUpEdit
        '
        Me.UnitGridLookUpEdit.AutoHeight = False
        Me.UnitGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitGridLookUpEdit.DisplayMember = "UnitCode"
        Me.UnitGridLookUpEdit.ImmediatePopup = True
        Me.UnitGridLookUpEdit.Name = "UnitGridLookUpEdit"
        Me.UnitGridLookUpEdit.NullText = ""
        Me.UnitGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.UnitGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UnitGridLookUpEdit.ValueMember = "UnitId"
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
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitId1, Me.colUnitCode, Me.colUnitName})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 1
        Me.colQuantity.Width = 92
        '
        'colRemarks
        '
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 2
        Me.colRemarks.Width = 303
        '
        'GatePassTypeComboBoxEdit
        '
        Me.GatePassTypeComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GatePassBindingSource, "GatePassType", True))
        Me.GatePassTypeComboBoxEdit.Location = New System.Drawing.Point(668, 24)
        Me.GatePassTypeComboBoxEdit.Name = "GatePassTypeComboBoxEdit"
        Me.GatePassTypeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GatePassTypeComboBoxEdit.Properties.Items.AddRange(New Object() {"Devolopment", "Fit", "Size Set", "Gold Seal", "Black Seal", "Red Seal", "PP", "Test", "Quatation", "Production", "Shipping", "Styling", "SMS", "Gift", "Shading", "Photo", "FFP", "K&O", "Proto"})
        Me.GatePassTypeComboBoxEdit.Size = New System.Drawing.Size(155, 20)
        Me.GatePassTypeComboBoxEdit.TabIndex = 12
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(RefNoLabel1)
        Me.GroupBox1.Controls.Add(Me.RefNoTextEdit)
        Me.GroupBox1.Controls.Add(GatePassTypeLabel1)
        Me.GroupBox1.Controls.Add(Me.GatePassTypeComboBoxEdit)
        Me.GroupBox1.Controls.Add(GatePassIdLabel)
        Me.GroupBox1.Controls.Add(GatepassDateLabel)
        Me.GroupBox1.Controls.Add(Me.GatepassDateDateEdit)
        Me.GroupBox1.Controls.Add(DeliveryToLabel)
        Me.GroupBox1.Controls.Add(Me.GatePassNoTextEdit)
        Me.GroupBox1.Controls.Add(Me.DeliveryToTextEdit)
        Me.GroupBox1.Controls.Add(DeliveryByLabel)
        Me.GroupBox1.Controls.Add(Me.DeliveryByTextEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 107)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'RefNoTextEdit
        '
        Me.RefNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GatePassBindingSource, "RefNo", True))
        Me.RefNoTextEdit.Location = New System.Drawing.Point(668, 54)
        Me.RefNoTextEdit.Name = "RefNoTextEdit"
        Me.RefNoTextEdit.Size = New System.Drawing.Size(155, 20)
        Me.RefNoTextEdit.TabIndex = 13
        '
        'GatePassNoTextEdit
        '
        Me.GatePassNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GatePassBindingSource, "GatePassNo", True))
        Me.GatePassNoTextEdit.Enabled = False
        Me.GatePassNoTextEdit.Location = New System.Drawing.Point(138, 24)
        Me.GatePassNoTextEdit.Name = "GatePassNoTextEdit"
        Me.GatePassNoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.Yellow
        Me.GatePassNoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.GatePassNoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.GatePassNoTextEdit.TabIndex = 6
        '
        'SampleRequestColorLookupTableAdapter
        '
        Me.SampleRequestColorLookupTableAdapter.ClearBeforeFill = True
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(421, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.GatePassLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "GatePassNo"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "GatePassId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(136, 20)
        Me.GridLookUpEdit1.TabIndex = 14
        '
        'GatePassLookupBindingSource
        '
        Me.GatePassLookupBindingSource.DataMember = "GatePassLookup"
        Me.GatePassLookupBindingSource.DataSource = Me.GatePassDataSet
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGatePassNo, Me.colGatepassDate})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colGatePassNo
        '
        Me.colGatePassNo.FieldName = "GatePassNo"
        Me.colGatePassNo.Name = "colGatePassNo"
        Me.colGatePassNo.Visible = True
        Me.colGatePassNo.VisibleIndex = 0
        '
        'colGatepassDate
        '
        Me.colGatepassDate.FieldName = "GatepassDate"
        Me.colGatepassDate.Name = "colGatepassDate"
        Me.colGatepassDate.Visible = True
        Me.colGatepassDate.VisibleIndex = 1
        '
        'GatePassLookupTableAdapter
        '
        Me.GatePassLookupTableAdapter.ClearBeforeFill = True
        '
        'frmGatepass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 454)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GatePassDetailsGridControl)
        Me.Controls.Add(Me.GatePassBindingNavigator)
        Me.Name = "frmGatepass"
        Me.Text = "Gate Pass [Sample]"
        CType(Me.GatePassDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GatePassBindingNavigator.ResumeLayout(False)
        Me.GatePassBindingNavigator.PerformLayout()
        CType(Me.GatepassDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatepassDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryToTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestColorLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestColorLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RefNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GatePassLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GatePassDataSet As KSoft_Apparel.GatePassDataSet
    Friend WithEvents GatePassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GatePassTableAdapter As KSoft_Apparel.GatePassDataSetTableAdapters.GatePassTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.GatePassDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GatePassBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GatePassBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GatepassDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DeliveryToTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeliveryByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GatePassDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GatePassDetailsTableAdapter As KSoft_Apparel.GatePassDataSetTableAdapters.GatePassDetailsTableAdapter
    Friend WithEvents GatePassDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGatePassDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGatePassId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GatePassTypeComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents UnitGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents colUnitId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ItemGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SampleRequestColorLookupDataSet As KSoft_Apparel.SampleRequestColorLookupDataSet
    Friend WithEvents SampleRequestColorLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleRequestColorLookupTableAdapter As KSoft_Apparel.SampleRequestColorLookupDataSetTableAdapters.SampleRequestColorLookupTableAdapter
    Friend WithEvents colSampleRequestDetailsId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSampleRequestId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RefNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GatePassLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GatePassLookupTableAdapter As KSoft_Apparel.GatePassDataSetTableAdapters.GatePassLookupTableAdapter
    Friend WithEvents colGatepassDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGatePassNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GatePassNoTextEdit As DevExpress.XtraEditors.TextEdit
End Class
