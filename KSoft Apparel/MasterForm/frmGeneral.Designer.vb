<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneral))
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.SupplierTypeComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SupplierDataSetTableAdapters.TableAdapterManager()
        Me.SupplierAddressTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierAddressTableAdapter()
        Me.SupplierTypeTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTypeTableAdapter()
        Me.SupplierBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AddNewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SupplierBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SupplierGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierTypeGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SupplierAddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierAddressGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierAddressId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddressType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdd21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPerson1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactPersonDesig = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SupplierTypeGridControl = New DevExpress.XtraGrid.GridControl()
        Me.SupplierTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSupplierType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTypeComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierBindingNavigator.SuspendLayout()
        CType(Me.SupplierGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierAddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierAddressGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SupplierTypeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Items.AddRange(New Object() {"Corporate Office", "Factory1", "Factory2", "Factory3", "Factory4", "Factory5"})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'SupplierTypeComboBox
        '
        Me.SupplierTypeComboBox.AutoHeight = False
        Me.SupplierTypeComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierTypeComboBox.Items.AddRange(New Object() {"Knitting", "Dyeing", "Yarn Dyeing", "Garments", "Accessories", "General", "Stationary", "Chemical", "Yarn", "Print", "Embroidery", "Maintanance", "Lab"})
        Me.SupplierTypeComboBox.Name = "SupplierTypeComboBox"
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SupplierAddressTableAdapter = Me.SupplierAddressTableAdapter
        Me.TableAdapterManager.SupplierTableAdapter = Me.SupplierTableAdapter
        Me.TableAdapterManager.SupplierTypeTableAdapter = Me.SupplierTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SupplierDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SupplierAddressTableAdapter
        '
        Me.SupplierAddressTableAdapter.ClearBeforeFill = True
        '
        'SupplierTypeTableAdapter
        '
        Me.SupplierTypeTableAdapter.ClearBeforeFill = True
        '
        'SupplierBindingNavigator
        '
        Me.SupplierBindingNavigator.AddNewItem = Nothing
        Me.SupplierBindingNavigator.AutoSize = False
        Me.SupplierBindingNavigator.BindingSource = Me.SupplierBindingSource
        Me.SupplierBindingNavigator.CountItem = Nothing
        Me.SupplierBindingNavigator.DeleteItem = Nothing
        Me.SupplierBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripButton, Me.SupplierBindingNavigatorSaveItem})
        Me.SupplierBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SupplierBindingNavigator.MoveFirstItem = Nothing
        Me.SupplierBindingNavigator.MoveLastItem = Nothing
        Me.SupplierBindingNavigator.MoveNextItem = Nothing
        Me.SupplierBindingNavigator.MovePreviousItem = Nothing
        Me.SupplierBindingNavigator.Name = "SupplierBindingNavigator"
        Me.SupplierBindingNavigator.PositionItem = Nothing
        Me.SupplierBindingNavigator.Size = New System.Drawing.Size(1332, 40)
        Me.SupplierBindingNavigator.TabIndex = 0
        Me.SupplierBindingNavigator.Text = "BindingNavigator1"
        '
        'AddNewToolStripButton
        '
        Me.AddNewToolStripButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Add_icon
        Me.AddNewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddNewToolStripButton.Name = "AddNewToolStripButton"
        Me.AddNewToolStripButton.Size = New System.Drawing.Size(76, 37)
        Me.AddNewToolStripButton.Text = "Add New"
        '
        'SupplierBindingNavigatorSaveItem
        '
        Me.SupplierBindingNavigatorSaveItem.Image = CType(resources.GetObject("SupplierBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SupplierBindingNavigatorSaveItem.Name = "SupplierBindingNavigatorSaveItem"
        Me.SupplierBindingNavigatorSaveItem.Padding = New System.Windows.Forms.Padding(10)
        Me.SupplierBindingNavigatorSaveItem.Size = New System.Drawing.Size(98, 37)
        Me.SupplierBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SupplierGridControl
        '
        Me.SupplierGridControl.DataSource = Me.SupplierBindingSource
        Me.SupplierGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierGridControl.Location = New System.Drawing.Point(0, 0)
        Me.SupplierGridControl.MainView = Me.GridView1
        Me.SupplierGridControl.Name = "SupplierGridControl"
        Me.SupplierGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SupplierTypeGridLookUpEdit, Me.RepositoryItemComboBox1})
        Me.SupplierGridControl.Size = New System.Drawing.Size(1332, 283)
        Me.SupplierGridControl.TabIndex = 2
        Me.SupplierGridControl.UseEmbeddedNavigator = True
        Me.SupplierGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierId, Me.colSupplierName, Me.colAdd1, Me.colAdd2, Me.colContactPerson, Me.colContactNo, Me.colSupplierCode, Me.colCity, Me.colCountry, Me.colProgramCode, Me.colEmail})
        Me.GridView1.GridControl = Me.SupplierGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colSupplierId
        '
        Me.colSupplierId.FieldName = "SupplierId"
        Me.colSupplierId.Name = "colSupplierId"
        Me.colSupplierId.OptionsColumn.ReadOnly = True
        Me.colSupplierId.Width = 73
        '
        'colSupplierName
        '
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 1
        Me.colSupplierName.Width = 167
        '
        'colAdd1
        '
        Me.colAdd1.FieldName = "Add1"
        Me.colAdd1.Name = "colAdd1"
        Me.colAdd1.Visible = True
        Me.colAdd1.VisibleIndex = 2
        Me.colAdd1.Width = 159
        '
        'colAdd2
        '
        Me.colAdd2.FieldName = "Add2"
        Me.colAdd2.Name = "colAdd2"
        Me.colAdd2.Visible = True
        Me.colAdd2.VisibleIndex = 3
        Me.colAdd2.Width = 168
        '
        'colContactPerson
        '
        Me.colContactPerson.FieldName = "ContactPerson"
        Me.colContactPerson.Name = "colContactPerson"
        Me.colContactPerson.Visible = True
        Me.colContactPerson.VisibleIndex = 4
        Me.colContactPerson.Width = 106
        '
        'colContactNo
        '
        Me.colContactNo.FieldName = "ContactNo"
        Me.colContactNo.Name = "colContactNo"
        Me.colContactNo.Visible = True
        Me.colContactNo.VisibleIndex = 5
        Me.colContactNo.Width = 111
        '
        'colSupplierCode
        '
        Me.colSupplierCode.FieldName = "SupplierCode"
        Me.colSupplierCode.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colSupplierCode.Name = "colSupplierCode"
        Me.colSupplierCode.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me.colSupplierCode.Visible = True
        Me.colSupplierCode.VisibleIndex = 0
        Me.colSupplierCode.Width = 107
        '
        'colCity
        '
        Me.colCity.FieldName = "City"
        Me.colCity.Name = "colCity"
        Me.colCity.Visible = True
        Me.colCity.VisibleIndex = 7
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        Me.colCountry.Visible = True
        Me.colCountry.VisibleIndex = 8
        Me.colCountry.Width = 93
        '
        'colProgramCode
        '
        Me.colProgramCode.FieldName = "ProgramCode"
        Me.colProgramCode.Name = "colProgramCode"
        Me.colProgramCode.Visible = True
        Me.colProgramCode.VisibleIndex = 9
        Me.colProgramCode.Width = 83
        '
        'colEmail
        '
        Me.colEmail.FieldName = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 6
        Me.colEmail.Width = 241
        '
        'SupplierTypeGridLookUpEdit
        '
        Me.SupplierTypeGridLookUpEdit.AutoHeight = False
        Me.SupplierTypeGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierTypeGridLookUpEdit.Name = "SupplierTypeGridLookUpEdit"
        Me.SupplierTypeGridLookUpEdit.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Accessories", "Fabrics", "Yarn", "Dyeing", "Garments"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.SupplierGridControl
        Me.GridView2.Name = "GridView2"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1332, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 652)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1332, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 652)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1332, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 652)
        '
        'SupplierAddressBindingSource
        '
        Me.SupplierAddressBindingSource.DataMember = "FK_SupplierAddress_Supplier"
        Me.SupplierAddressBindingSource.DataSource = Me.SupplierBindingSource
        '
        'SupplierAddressGridControl
        '
        Me.SupplierAddressGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplierAddressGridControl.DataSource = Me.SupplierAddressBindingSource
        Me.SupplierAddressGridControl.Location = New System.Drawing.Point(0, 4)
        Me.SupplierAddressGridControl.MainView = Me.GridView3
        Me.SupplierAddressGridControl.MenuManager = Me.BarManager1
        Me.SupplierAddressGridControl.Name = "SupplierAddressGridControl"
        Me.SupplierAddressGridControl.Size = New System.Drawing.Size(1033, 318)
        Me.SupplierAddressGridControl.TabIndex = 6
        Me.SupplierAddressGridControl.UseEmbeddedNavigator = True
        Me.SupplierAddressGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierAddressId, Me.colSupplierId1, Me.colAddressType, Me.colAdd11, Me.colAdd21, Me.colCity1, Me.colCountry1, Me.colContactPerson1, Me.colContactPersonDesig, Me.colContactNo1})
        Me.GridView3.GridControl = Me.SupplierAddressGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colSupplierAddressId
        '
        Me.colSupplierAddressId.FieldName = "SupplierAddressId"
        Me.colSupplierAddressId.Name = "colSupplierAddressId"
        Me.colSupplierAddressId.OptionsColumn.ReadOnly = True
        '
        'colSupplierId1
        '
        Me.colSupplierId1.FieldName = "SupplierId"
        Me.colSupplierId1.Name = "colSupplierId1"
        '
        'colAddressType
        '
        Me.colAddressType.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colAddressType.FieldName = "AddressType"
        Me.colAddressType.Name = "colAddressType"
        Me.colAddressType.Visible = True
        Me.colAddressType.VisibleIndex = 0
        '
        'colAdd11
        '
        Me.colAdd11.FieldName = "Add1"
        Me.colAdd11.Name = "colAdd11"
        Me.colAdd11.Visible = True
        Me.colAdd11.VisibleIndex = 1
        '
        'colAdd21
        '
        Me.colAdd21.FieldName = "Add2"
        Me.colAdd21.Name = "colAdd21"
        Me.colAdd21.Visible = True
        Me.colAdd21.VisibleIndex = 2
        '
        'colCity1
        '
        Me.colCity1.FieldName = "City"
        Me.colCity1.Name = "colCity1"
        Me.colCity1.Visible = True
        Me.colCity1.VisibleIndex = 3
        '
        'colCountry1
        '
        Me.colCountry1.FieldName = "Country"
        Me.colCountry1.Name = "colCountry1"
        Me.colCountry1.Visible = True
        Me.colCountry1.VisibleIndex = 4
        '
        'colContactPerson1
        '
        Me.colContactPerson1.FieldName = "ContactPerson"
        Me.colContactPerson1.Name = "colContactPerson1"
        Me.colContactPerson1.Visible = True
        Me.colContactPerson1.VisibleIndex = 5
        '
        'colContactPersonDesig
        '
        Me.colContactPersonDesig.Caption = "Designation"
        Me.colContactPersonDesig.FieldName = "ContactPersonDesig"
        Me.colContactPersonDesig.Name = "colContactPersonDesig"
        Me.colContactPersonDesig.Visible = True
        Me.colContactPersonDesig.VisibleIndex = 6
        '
        'colContactNo1
        '
        Me.colContactNo1.FieldName = "ContactNo"
        Me.colContactNo1.Name = "colContactNo1"
        Me.colContactNo1.Visible = True
        Me.colContactNo1.VisibleIndex = 7
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 40)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SupplierGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.SupplierTypeGridControl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SupplierAddressGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1332, 612)
        Me.SplitContainer1.SplitterDistance = 283
        Me.SplitContainer1.TabIndex = 7
        '
        'SupplierTypeGridControl
        '
        Me.SupplierTypeGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplierTypeGridControl.DataSource = Me.SupplierTypeBindingSource
        Me.SupplierTypeGridControl.Location = New System.Drawing.Point(1039, 4)
        Me.SupplierTypeGridControl.MainView = Me.GridView4
        Me.SupplierTypeGridControl.MenuManager = Me.BarManager1
        Me.SupplierTypeGridControl.Name = "SupplierTypeGridControl"
        Me.SupplierTypeGridControl.Size = New System.Drawing.Size(293, 318)
        Me.SupplierTypeGridControl.TabIndex = 6
        Me.SupplierTypeGridControl.UseEmbeddedNavigator = True
        Me.SupplierTypeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'SupplierTypeBindingSource
        '
        Me.SupplierTypeBindingSource.DataMember = "FK_SupplierType_Supplier"
        Me.SupplierTypeBindingSource.DataSource = Me.SupplierBindingSource
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSupplierType1})
        Me.GridView4.GridControl = Me.SupplierTypeGridControl
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colSupplierType1
        '
        Me.colSupplierType1.ColumnEdit = Me.SupplierTypeComboBox
        Me.colSupplierType1.FieldName = "SupplierType"
        Me.colSupplierType1.Name = "colSupplierType1"
        Me.colSupplierType1.Visible = True
        Me.colSupplierType1.VisibleIndex = 0
        '
        'frmGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 652)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.SupplierBindingNavigator)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGeneral"
        Me.Text = "Supplier List"
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTypeComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierBindingNavigator.ResumeLayout(False)
        Me.SupplierBindingNavigator.PerformLayout()
        CType(Me.SupplierGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTypeGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierAddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierAddressGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SupplierTypeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SupplierDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SupplierBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents SupplierBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SupplierGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SupplierTypeGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AddNewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SupplierAddressBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierAddressTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierAddressTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SupplierAddressGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierAddressId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddressType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdd21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPerson1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactPersonDesig As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTypeTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTypeTableAdapter
    Friend WithEvents SupplierTypeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSupplierType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SupplierTypeComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
End Class
