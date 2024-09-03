<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccItemList
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
        Dim UnitIdLabel As System.Windows.Forms.Label
        Dim CurrentPriceLabel As System.Windows.Forms.Label
        Dim AccItemNameLabel As System.Windows.Forms.Label
        Dim AccBuyerIdLabel As System.Windows.Forms.Label
        Dim AccItemStyleIdLabel As System.Windows.Forms.Label
        Dim ItemNameLabel As System.Windows.Forms.Label
        Me.ItemListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Apparel.ItemListDataSet()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet()
        Me.CurrentPriceSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.AccItemNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.AccItemStyleMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ItemNameMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.AccBuyerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.AccBuyerIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ItemListLookupGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAccItemStyle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCurrentPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NominatedSupplierGridControl = New DevExpress.XtraGrid.GridControl()
        Me.NominatedSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CnclButton = New System.Windows.Forms.Button()
        Me.SaveSupplierButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SupplierLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListDataSetTableAdapters.ItemListTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.ItemListDataSetTableAdapters.TableAdapterManager()
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.ItemListLookupTableAdapter = New KSoft_Apparel.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.colUnitName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierLookupTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierLookupTableAdapter()
        Me.NominatedSupplierTableAdapter = New KSoft_Apparel.ItemListDataSetTableAdapters.NominatedSupplierTableAdapter()
        Me.SupplierGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        UnitIdLabel = New System.Windows.Forms.Label()
        CurrentPriceLabel = New System.Windows.Forms.Label()
        AccItemNameLabel = New System.Windows.Forms.Label()
        AccBuyerIdLabel = New System.Windows.Forms.Label()
        AccItemStyleIdLabel = New System.Windows.Forms.Label()
        ItemNameLabel = New System.Windows.Forms.Label()
        CType(Me.ItemListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemListBindingNavigator.SuspendLayout()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccItemNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AccItemStyleMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemNameMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ItemListLookupGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominatedSupplierGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NominatedSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UnitIdLabel
        '
        UnitIdLabel.AutoSize = True
        UnitIdLabel.Location = New System.Drawing.Point(263, 91)
        UnitIdLabel.Name = "UnitIdLabel"
        UnitIdLabel.Size = New System.Drawing.Size(74, 13)
        UnitIdLabel.TabIndex = 7
        UnitIdLabel.Text = "Booking Unit :"
        '
        'CurrentPriceLabel
        '
        CurrentPriceLabel.AutoSize = True
        CurrentPriceLabel.Location = New System.Drawing.Point(462, 91)
        CurrentPriceLabel.Name = "CurrentPriceLabel"
        CurrentPriceLabel.Size = New System.Drawing.Size(71, 13)
        CurrentPriceLabel.TabIndex = 9
        CurrentPriceLabel.Text = "Current Price:"
        '
        'AccItemNameLabel
        '
        AccItemNameLabel.AutoSize = True
        AccItemNameLabel.Location = New System.Drawing.Point(23, 18)
        AccItemNameLabel.Name = "AccItemNameLabel"
        AccItemNameLabel.Size = New System.Drawing.Size(98, 13)
        AccItemNameLabel.TabIndex = 17
        AccItemNameLabel.Text = "Accessories Name:"
        '
        'AccBuyerIdLabel
        '
        AccBuyerIdLabel.AutoSize = True
        AccBuyerIdLabel.Location = New System.Drawing.Point(23, 90)
        AccBuyerIdLabel.Name = "AccBuyerIdLabel"
        AccBuyerIdLabel.Size = New System.Drawing.Size(55, 13)
        AccBuyerIdLabel.TabIndex = 19
        AccBuyerIdLabel.Text = "For Buyer:"
        '
        'AccItemStyleIdLabel
        '
        AccItemStyleIdLabel.AutoSize = True
        AccItemStyleIdLabel.Location = New System.Drawing.Point(23, 44)
        AccItemStyleIdLabel.Name = "AccItemStyleIdLabel"
        AccItemStyleIdLabel.Size = New System.Drawing.Size(95, 13)
        AccItemStyleIdLabel.TabIndex = 21
        AccItemStyleIdLabel.Text = "Accessories Spec:"
        '
        'ItemNameLabel
        '
        ItemNameLabel.AutoSize = True
        ItemNameLabel.Location = New System.Drawing.Point(23, 120)
        ItemNameLabel.Name = "ItemNameLabel"
        ItemNameLabel.Size = New System.Drawing.Size(79, 13)
        ItemNameLabel.TabIndex = 26
        ItemNameLabel.Text = "Full Acc Name:"
        '
        'ItemListBindingNavigator
        '
        Me.ItemListBindingNavigator.AddNewItem = Nothing
        Me.ItemListBindingNavigator.BindingSource = Me.ItemListBindingSource
        Me.ItemListBindingNavigator.CountItem = Nothing
        Me.ItemListBindingNavigator.DeleteItem = Nothing
        Me.ItemListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ItemListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ItemListBindingNavigator.MoveFirstItem = Nothing
        Me.ItemListBindingNavigator.MoveLastItem = Nothing
        Me.ItemListBindingNavigator.MoveNextItem = Nothing
        Me.ItemListBindingNavigator.MovePreviousItem = Nothing
        Me.ItemListBindingNavigator.Name = "ItemListBindingNavigator"
        Me.ItemListBindingNavigator.PositionItem = Nothing
        Me.ItemListBindingNavigator.Size = New System.Drawing.Size(856, 25)
        Me.ItemListBindingNavigator.TabIndex = 0
        Me.ItemListBindingNavigator.Text = "BindingNavigator1"
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.KSoft_Apparel.My.Resources.Resources.Add_icon
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(148, 22)
        Me.ToolStripButton1.Text = "Add to Accessories List"
        '
        'ItemListLookupBindingSource
        '
        Me.ItemListLookupBindingSource.DataMember = "ItemListLookup"
        Me.ItemListLookupBindingSource.DataSource = Me.ItemListDataSet
        '
        'UnitIdGridLookUpEditView
        '
        Me.UnitIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitCode, Me.colUnitName})
        Me.UnitIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.UnitIdGridLookUpEditView.Name = "UnitIdGridLookUpEditView"
        Me.UnitIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.UnitIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colUnitCode
        '
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Visible = True
        Me.colUnitCode.VisibleIndex = 1
        '
        'colUnitName
        '
        Me.colUnitName.FieldName = "UnitName"
        Me.colUnitName.Name = "colUnitName"
        Me.colUnitName.Visible = True
        Me.colUnitName.VisibleIndex = 0
        '
        'UnitIdGridLookUpEdit
        '
        Me.UnitIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "UnitId", True))
        Me.UnitIdGridLookUpEdit.Location = New System.Drawing.Point(343, 88)
        Me.UnitIdGridLookUpEdit.Name = "UnitIdGridLookUpEdit"
        Me.UnitIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitIdGridLookUpEdit.Properties.DataSource = Me.UnitBindingSource
        Me.UnitIdGridLookUpEdit.Properties.DisplayMember = "UnitName"
        Me.UnitIdGridLookUpEdit.Properties.NullText = ""
        Me.UnitIdGridLookUpEdit.Properties.PopupView = Me.UnitIdGridLookUpEditView
        Me.UnitIdGridLookUpEdit.Properties.ValueMember = "UnitId"
        Me.UnitIdGridLookUpEdit.Size = New System.Drawing.Size(109, 20)
        Me.UnitIdGridLookUpEdit.TabIndex = 8
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
        'CurrentPriceSpinEdit
        '
        Me.CurrentPriceSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "CurrentPrice", True))
        Me.CurrentPriceSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.CurrentPriceSpinEdit.Location = New System.Drawing.Point(548, 88)
        Me.CurrentPriceSpinEdit.Name = "CurrentPriceSpinEdit"
        Me.CurrentPriceSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CurrentPriceSpinEdit.Size = New System.Drawing.Size(75, 20)
        Me.CurrentPriceSpinEdit.TabIndex = 10
        '
        'AccItemNameTextEdit
        '
        Me.AccItemNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "AccItemName", True))
        Me.AccItemNameTextEdit.Location = New System.Drawing.Point(127, 15)
        Me.AccItemNameTextEdit.Name = "AccItemNameTextEdit"
        Me.AccItemNameTextEdit.Size = New System.Drawing.Size(676, 20)
        Me.AccItemNameTextEdit.TabIndex = 18
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccItemStyleMemoEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ItemNameMemoEdit)
        Me.SplitContainer1.Panel1.Controls.Add(ItemNameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccBuyerIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccItemNameTextEdit)
        Me.SplitContainer1.Panel1.Controls.Add(AccItemStyleIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UnitIdGridLookUpEdit)
        Me.SplitContainer1.Panel1.Controls.Add(UnitIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(AccBuyerIdLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CurrentPriceSpinEdit)
        Me.SplitContainer1.Panel1.Controls.Add(CurrentPriceLabel)
        Me.SplitContainer1.Panel1.Controls.Add(AccItemNameLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CnclButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SaveSupplierButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.OKButton)
        Me.SplitContainer1.Size = New System.Drawing.Size(856, 470)
        Me.SplitContainer1.SplitterDistance = 176
        Me.SplitContainer1.TabIndex = 24
        '
        'AccItemStyleMemoEdit
        '
        Me.AccItemStyleMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "AccItemStyle", True))
        Me.AccItemStyleMemoEdit.Location = New System.Drawing.Point(127, 41)
        Me.AccItemStyleMemoEdit.Name = "AccItemStyleMemoEdit"
        Me.AccItemStyleMemoEdit.Size = New System.Drawing.Size(676, 41)
        Me.AccItemStyleMemoEdit.TabIndex = 28
        '
        'ItemNameMemoEdit
        '
        Me.ItemNameMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "ItemName", True))
        Me.ItemNameMemoEdit.Location = New System.Drawing.Point(126, 117)
        Me.ItemNameMemoEdit.Name = "ItemNameMemoEdit"
        Me.ItemNameMemoEdit.Size = New System.Drawing.Size(677, 41)
        Me.ItemNameMemoEdit.TabIndex = 27
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(823, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 26
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(823, 18)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 25
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'AccBuyerIdGridLookUpEdit
        '
        Me.AccBuyerIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ItemListBindingSource, "AccBuyerId", True))
        Me.AccBuyerIdGridLookUpEdit.Location = New System.Drawing.Point(126, 88)
        Me.AccBuyerIdGridLookUpEdit.Name = "AccBuyerIdGridLookUpEdit"
        Me.AccBuyerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccBuyerIdGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.AccBuyerIdGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.AccBuyerIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.AccBuyerIdGridLookUpEdit.Properties.NullText = ""
        Me.AccBuyerIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.AccBuyerIdGridLookUpEdit.Properties.PopupView = Me.AccBuyerIdGridLookUpEditView
        Me.AccBuyerIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AccBuyerIdGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.AccBuyerIdGridLookUpEdit.Size = New System.Drawing.Size(131, 20)
        Me.AccBuyerIdGridLookUpEdit.TabIndex = 23
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
        'AccBuyerIdGridLookUpEditView
        '
        Me.AccBuyerIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerCode, Me.colBuyerName})
        Me.AccBuyerIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.AccBuyerIdGridLookUpEditView.Name = "AccBuyerIdGridLookUpEditView"
        Me.AccBuyerIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.AccBuyerIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
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
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ItemListLookupGridControl)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.NominatedSupplierGridControl)
        Me.SplitContainer2.Size = New System.Drawing.Size(850, 246)
        Me.SplitContainer2.SplitterDistance = 123
        Me.SplitContainer2.TabIndex = 30
        '
        'ItemListLookupGridControl
        '
        Me.ItemListLookupGridControl.DataSource = Me.ItemListLookupBindingSource
        Me.ItemListLookupGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemListLookupGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ItemListLookupGridControl.MainView = Me.GridView1
        Me.ItemListLookupGridControl.Name = "ItemListLookupGridControl"
        Me.ItemListLookupGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.BuyerLookupGridLookUpEdit, Me.UnitLookupGridLookUpEdit})
        Me.ItemListLookupGridControl.Size = New System.Drawing.Size(850, 123)
        Me.ItemListLookupGridControl.TabIndex = 2
        Me.ItemListLookupGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAccItemStyle, Me.colAccBuyerId, Me.colUnitId, Me.colCurrentPrice, Me.colItemName})
        Me.GridView1.GridControl = Me.ItemListLookupGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colAccItemStyle
        '
        Me.colAccItemStyle.Caption = "Acc Specification"
        Me.colAccItemStyle.FieldName = "AccItemStyle"
        Me.colAccItemStyle.Name = "colAccItemStyle"
        Me.colAccItemStyle.Visible = True
        Me.colAccItemStyle.VisibleIndex = 2
        Me.colAccItemStyle.Width = 227
        '
        'colAccBuyerId
        '
        Me.colAccBuyerId.Caption = "Buyer"
        Me.colAccBuyerId.ColumnEdit = Me.BuyerLookupGridLookUpEdit
        Me.colAccBuyerId.FieldName = "AccBuyerId"
        Me.colAccBuyerId.Name = "colAccBuyerId"
        Me.colAccBuyerId.Visible = True
        Me.colAccBuyerId.VisibleIndex = 3
        Me.colAccBuyerId.Width = 107
        '
        'BuyerLookupGridLookUpEdit
        '
        Me.BuyerLookupGridLookUpEdit.AutoHeight = False
        Me.BuyerLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerLookupGridLookUpEdit.DataSource = Me.BuyerBindingSource
        Me.BuyerLookupGridLookUpEdit.DisplayMember = "BuyerName"
        Me.BuyerLookupGridLookUpEdit.Name = "BuyerLookupGridLookUpEdit"
        Me.BuyerLookupGridLookUpEdit.NullText = ""
        Me.BuyerLookupGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.BuyerLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerLookupGridLookUpEdit.ValueMember = "BuyerId"
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName1
        '
        Me.colBuyerName1.FieldName = "BuyerName"
        Me.colBuyerName1.Name = "colBuyerName1"
        Me.colBuyerName1.Visible = True
        Me.colBuyerName1.VisibleIndex = 0
        '
        'colUnitId
        '
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.UnitLookupGridLookUpEdit
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 1
        Me.colUnitId.Width = 77
        '
        'UnitLookupGridLookUpEdit
        '
        Me.UnitLookupGridLookUpEdit.AutoHeight = False
        Me.UnitLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitLookupGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitLookupGridLookUpEdit.DisplayMember = "UnitName"
        Me.UnitLookupGridLookUpEdit.Name = "UnitLookupGridLookUpEdit"
        Me.UnitLookupGridLookUpEdit.PopupView = Me.GridView2
        Me.UnitLookupGridLookUpEdit.ValueMember = "UnitId"
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colCurrentPrice
        '
        Me.colCurrentPrice.Caption = "Max Price"
        Me.colCurrentPrice.FieldName = "CurrentPrice"
        Me.colCurrentPrice.Name = "colCurrentPrice"
        Me.colCurrentPrice.Width = 62
        '
        'colItemName
        '
        Me.colItemName.FieldName = "ItemName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Visible = True
        Me.colItemName.VisibleIndex = 0
        Me.colItemName.Width = 262
        '
        'NominatedSupplierGridControl
        '
        Me.NominatedSupplierGridControl.DataSource = Me.NominatedSupplierBindingSource
        Me.NominatedSupplierGridControl.Location = New System.Drawing.Point(3, 2)
        Me.NominatedSupplierGridControl.MainView = Me.GridView3
        Me.NominatedSupplierGridControl.Name = "NominatedSupplierGridControl"
        Me.NominatedSupplierGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SupplierGridLookUpEdit})
        Me.NominatedSupplierGridControl.Size = New System.Drawing.Size(847, 114)
        Me.NominatedSupplierGridControl.TabIndex = 0
        Me.NominatedSupplierGridControl.UseEmbeddedNavigator = True
        Me.NominatedSupplierGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'NominatedSupplierBindingSource
        '
        Me.NominatedSupplierBindingSource.DataMember = "NominatedSupplier"
        Me.NominatedSupplierBindingSource.DataSource = Me.ItemListDataSet
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId})
        Me.GridView3.GridControl = Me.NominatedSupplierGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colSupplierId
        '
        Me.colSupplierId.Caption = "Nominated Supplier"
        Me.colSupplierId.ColumnEdit = Me.SupplierGridLookUpEdit
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.Visible = True
        Me.colSupplierId.VisibleIndex = 0
        '
        'CnclButton
        '
        Me.CnclButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CnclButton.Location = New System.Drawing.Point(750, 257)
        Me.CnclButton.Name = "CnclButton"
        Me.CnclButton.Size = New System.Drawing.Size(88, 23)
        Me.CnclButton.TabIndex = 4
        Me.CnclButton.Text = "&Cancel"
        Me.CnclButton.UseVisualStyleBackColor = True
        '
        'SaveSupplierButton
        '
        Me.SaveSupplierButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveSupplierButton.Location = New System.Drawing.Point(26, 257)
        Me.SaveSupplierButton.Name = "SaveSupplierButton"
        Me.SaveSupplierButton.Size = New System.Drawing.Size(91, 23)
        Me.SaveSupplierButton.TabIndex = 3
        Me.SaveSupplierButton.Text = "&Save Supplier"
        Me.SaveSupplierButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Location = New System.Drawing.Point(651, 257)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(91, 23)
        Me.OKButton.TabIndex = 3
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'SupplierLookupBindingSource
        '
        Me.SupplierLookupBindingSource.DataMember = "SupplierLookup"
        Me.SupplierLookupBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.EnforceConstraints = False
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ItemListLookupTableAdapter = Nothing
        Me.TableAdapterManager.ItemListTableAdapter = Me.ItemListTableAdapter
        Me.TableAdapterManager.NominatedSupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.ItemListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'colUnitName1
        '
        Me.colUnitName1.FieldName = "UnitName"
        Me.colUnitName1.Name = "colUnitName1"
        Me.colUnitName1.Visible = True
        Me.colUnitName1.VisibleIndex = 0
        '
        'colUnitCode1
        '
        Me.colUnitCode1.FieldName = "UnitCode"
        Me.colUnitCode1.Name = "colUnitCode1"
        Me.colUnitCode1.Visible = True
        Me.colUnitCode1.VisibleIndex = 1
        '
        'SupplierLookupTableAdapter
        '
        Me.SupplierLookupTableAdapter.ClearBeforeFill = True
        '
        'NominatedSupplierTableAdapter
        '
        Me.NominatedSupplierTableAdapter.ClearBeforeFill = True
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.AutoHeight = False
        Me.SupplierGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierGridLookUpEdit.DataSource = Me.SupplierLookupBindingSource
        Me.SupplierGridLookUpEdit.DisplayMember = "SupplierName"
        Me.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit"
        Me.SupplierGridLookUpEdit.PopupView = Me.GridView4
        Me.SupplierGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierGridLookUpEdit.ValueMember = "SupplierId"
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierName, Me.colSupplierCode})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 0
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 1
        '
        'frmAccItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 495)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ItemListBindingNavigator)
        Me.Name = "frmAccItemList"
        Me.Text = "Accessories  List"
        CType(Me.ItemListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemListBindingNavigator.ResumeLayout(False)
        Me.ItemListBindingNavigator.PerformLayout()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentPriceSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccItemNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AccItemStyleMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemNameMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ItemListLookupGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominatedSupplierGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NominatedSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemListDataSet As KSoft_Apparel.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.ItemListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemListBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents UnitIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents CurrentPriceSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents AccItemNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AccBuyerIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents AccBuyerIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents colUnitName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Apparel.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents ItemListLookupGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccItemStyle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCurrentPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUnitName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CnclButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents colItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccItemStyleMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ItemNameMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SupplierDataSet As SupplierDataSet
    Friend WithEvents SupplierLookupBindingSource As BindingSource
    Friend WithEvents SupplierLookupTableAdapter As SupplierDataSetTableAdapters.SupplierLookupTableAdapter
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SaveSupplierButton As Button
    Friend WithEvents NominatedSupplierBindingSource As BindingSource
    Friend WithEvents NominatedSupplierTableAdapter As ItemListDataSetTableAdapters.NominatedSupplierTableAdapter
    Friend WithEvents NominatedSupplierGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
End Class
