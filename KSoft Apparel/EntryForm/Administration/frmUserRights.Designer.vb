<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserRights
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
        Dim USER_NAMELabel As System.Windows.Forms.Label
        Dim PASSWORDLabel As System.Windows.Forms.Label
        Dim USER_LEVELLabel As System.Windows.Forms.Label
        Dim DepartmentIdLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim USER_SIGNATURELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserRights))
        Me.UserBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserRightsDataSet = New KSoft_Apparel.UserRightsDataSet()
        Me.UserBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UpdateListToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Apparel.DepartmentDataSet()
        Me.UserRightsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuDataSet = New KSoft_Apparel.MenuDataSet()
        Me.MenuTableAdapter = New KSoft_Apparel.MenuDataSetTableAdapters.MenuTableAdapter()
        Me.UserTableAdapter = New KSoft_Apparel.UserRightsDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.UserRightsDataSetTableAdapters.TableAdapterManager()
        Me.UserRightsTableAdapter = New KSoft_Apparel.UserRightsDataSetTableAdapters.UserRightsTableAdapter()
        Me.DepartmentTableAdapter = New KSoft_Apparel.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.USER_LEVELTextBox = New System.Windows.Forms.TextBox()
        Me.ACTIVECheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.USER_SIGNATUREPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ReportToGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ReportToGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_ID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_NAME1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPASSWORD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSER_LEVEL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACTIVE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.USER_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.PASSWORDTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.UserDataSet = New KSoft_Apparel.UserDataSet()
        Me.SetSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ViewCheckBox = New System.Windows.Forms.CheckBox()
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ParentMenuLooupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartenMenuLookupDataSet = New KSoft_Apparel.PartenMenuLookupDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colParentMenuName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.colUSER_RIGHTS_ID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colUSER_ID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colCAN_EDIT = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colCAN_DELETE = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colCAN_VIEW = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colMENU_ID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.MenuListLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ParentMenuLookupTableAdapter = New KSoft_Apparel.PartenMenuLookupDataSetTableAdapters.ParentMenuLookupTableAdapter()
        Me.MenuNameSearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DeleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.EditCheckBox = New System.Windows.Forms.CheckBox()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.PrintSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        USER_NAMELabel = New System.Windows.Forms.Label()
        PASSWORDLabel = New System.Windows.Forms.Label()
        USER_LEVELLabel = New System.Windows.Forms.Label()
        DepartmentIdLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        USER_SIGNATURELabel = New System.Windows.Forms.Label()
        CType(Me.UserBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserBindingNavigator.SuspendLayout()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserRightsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserRightsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACTIVECheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.USER_SIGNATUREPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportToGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportToGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParentMenuLooupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartenMenuLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuListLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'USER_NAMELabel
        '
        USER_NAMELabel.AutoSize = True
        USER_NAMELabel.Location = New System.Drawing.Point(23, 33)
        USER_NAMELabel.Name = "USER_NAMELabel"
        USER_NAMELabel.Size = New System.Drawing.Size(60, 13)
        USER_NAMELabel.TabIndex = 10
        USER_NAMELabel.Text = "User Name"
        '
        'PASSWORDLabel
        '
        PASSWORDLabel.AutoSize = True
        PASSWORDLabel.Location = New System.Drawing.Point(23, 61)
        PASSWORDLabel.Name = "PASSWORDLabel"
        PASSWORDLabel.Size = New System.Drawing.Size(81, 13)
        PASSWORDLabel.TabIndex = 11
        PASSWORDLabel.Text = "User Password:"
        '
        'USER_LEVELLabel
        '
        USER_LEVELLabel.AutoSize = True
        USER_LEVELLabel.Location = New System.Drawing.Point(265, 33)
        USER_LEVELLabel.Name = "USER_LEVELLabel"
        USER_LEVELLabel.Size = New System.Drawing.Size(61, 13)
        USER_LEVELLabel.TabIndex = 13
        USER_LEVELLabel.Text = "User Level:"
        '
        'DepartmentIdLabel
        '
        DepartmentIdLabel.AutoSize = True
        DepartmentIdLabel.Location = New System.Drawing.Point(265, 62)
        DepartmentIdLabel.Name = "DepartmentIdLabel"
        DepartmentIdLabel.Size = New System.Drawing.Size(68, 13)
        DepartmentIdLabel.TabIndex = 14
        DepartmentIdLabel.Text = "Department :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(23, 89)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(58, 13)
        Label2.TabIndex = 12
        Label2.Text = "Report To:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(265, 92)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(76, 13)
        EmailAddressLabel.TabIndex = 14
        EmailAddressLabel.Text = "Email Address:"
        '
        'USER_SIGNATURELabel
        '
        USER_SIGNATURELabel.AutoSize = True
        USER_SIGNATURELabel.Location = New System.Drawing.Point(672, 36)
        USER_SIGNATURELabel.Name = "USER_SIGNATURELabel"
        USER_SIGNATURELabel.Size = New System.Drawing.Size(106, 13)
        USER_SIGNATURELabel.TabIndex = 15
        USER_SIGNATURELabel.Text = "USER SIGNATURE:"
        '
        'UserBindingNavigator
        '
        Me.UserBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserBindingNavigator.BindingSource = Me.UserBindingSource
        Me.UserBindingNavigator.CountItem = Nothing
        Me.UserBindingNavigator.DeleteItem = Nothing
        Me.UserBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.UserBindingNavigatorSaveItem, Me.UpdateListToolStripButton, Me.ToolStripSeparator1, Me.RefreshToolStripButton, Me.ToolStripLabel1})
        Me.UserBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserBindingNavigator.MoveFirstItem = Nothing
        Me.UserBindingNavigator.MoveLastItem = Nothing
        Me.UserBindingNavigator.MoveNextItem = Nothing
        Me.UserBindingNavigator.MovePreviousItem = Nothing
        Me.UserBindingNavigator.Name = "UserBindingNavigator"
        Me.UserBindingNavigator.PositionItem = Nothing
        Me.UserBindingNavigator.Size = New System.Drawing.Size(948, 25)
        Me.UserBindingNavigator.TabIndex = 0
        Me.UserBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.UserRightsDataSet
        '
        'UserRightsDataSet
        '
        Me.UserRightsDataSet.DataSetName = "UserRightsDataSet"
        Me.UserRightsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingNavigatorSaveItem
        '
        Me.UserBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserBindingNavigatorSaveItem.Name = "UserBindingNavigatorSaveItem"
        Me.UserBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.UserBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UpdateListToolStripButton
        '
        Me.UpdateListToolStripButton.Image = Global.KSoft_Apparel.My.Resources.Resources.Stock_Index_Down_icon
        Me.UpdateListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateListToolStripButton.Name = "UpdateListToolStripButton"
        Me.UpdateListToolStripButton.Size = New System.Drawing.Size(86, 22)
        Me.UpdateListToolStripButton.Text = "Update List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'RefreshToolStripButton
        '
        Me.RefreshToolStripButton.Image = CType(resources.GetObject("RefreshToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshToolStripButton.Name = "RefreshToolStripButton"
        Me.RefreshToolStripButton.Size = New System.Drawing.Size(66, 22)
        Me.RefreshToolStripButton.Text = "Refresh"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripLabel1.Text = "Search by User"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentDataSet
        '
        'DepartmentDataSet
        '
        Me.DepartmentDataSet.DataSetName = "DepartmentDataSet"
        Me.DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserRightsBindingSource
        '
        Me.UserRightsBindingSource.DataMember = "FK_UserRights_User"
        Me.UserRightsBindingSource.DataSource = Me.UserBindingSource
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "Menu"
        Me.MenuBindingSource.DataSource = Me.MenuDataSet
        '
        'MenuDataSet
        '
        Me.MenuDataSet.DataSetName = "MenuDataSet"
        Me.MenuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.UserRightsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserRightsTableAdapter = Me.UserRightsTableAdapter
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'UserRightsTableAdapter
        '
        Me.UserRightsTableAdapter.ClearBeforeFill = True
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'USER_LEVELTextBox
        '
        Me.USER_LEVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "USER_LEVEL", True))
        Me.USER_LEVELTextBox.Location = New System.Drawing.Point(359, 30)
        Me.USER_LEVELTextBox.Name = "USER_LEVELTextBox"
        Me.USER_LEVELTextBox.Size = New System.Drawing.Size(39, 20)
        Me.USER_LEVELTextBox.TabIndex = 3
        '
        'ACTIVECheckEdit
        '
        Me.ACTIVECheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserBindingSource, "ACTIVE", True))
        Me.ACTIVECheckEdit.Location = New System.Drawing.Point(458, 30)
        Me.ACTIVECheckEdit.Name = "ACTIVECheckEdit"
        Me.ACTIVECheckEdit.Properties.Caption = "Is Active"
        Me.ACTIVECheckEdit.Size = New System.Drawing.Size(64, 19)
        Me.ACTIVECheckEdit.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(USER_SIGNATURELabel)
        Me.GroupBox1.Controls.Add(Me.USER_SIGNATUREPictureEdit)
        Me.GroupBox1.Controls.Add(EmailAddressLabel)
        Me.GroupBox1.Controls.Add(Me.EmailAddressTextBox)
        Me.GroupBox1.Controls.Add(Me.ReportToGridLookUpEdit)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.USER_NAMETextBox)
        Me.GroupBox1.Controls.Add(Me.PASSWORDTextBox)
        Me.GroupBox1.Controls.Add(Me.DepartmentComboBox)
        Me.GroupBox1.Controls.Add(USER_NAMELabel)
        Me.GroupBox1.Controls.Add(PASSWORDLabel)
        Me.GroupBox1.Controls.Add(USER_LEVELLabel)
        Me.GroupBox1.Controls.Add(Me.USER_LEVELTextBox)
        Me.GroupBox1.Controls.Add(Me.ACTIVECheckEdit)
        Me.GroupBox1.Controls.Add(DepartmentIdLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(923, 156)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'USER_SIGNATUREPictureEdit
        '
        Me.USER_SIGNATUREPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.USER_SIGNATUREPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserBindingSource, "USER_SIGNATURE", True))
        Me.USER_SIGNATUREPictureEdit.Location = New System.Drawing.Point(675, 58)
        Me.USER_SIGNATUREPictureEdit.Name = "USER_SIGNATUREPictureEdit"
        Me.USER_SIGNATUREPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.USER_SIGNATUREPictureEdit.Size = New System.Drawing.Size(174, 47)
        Me.USER_SIGNATUREPictureEdit.TabIndex = 16
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(359, 85)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(275, 20)
        Me.EmailAddressTextBox.TabIndex = 15
        '
        'ReportToGridLookUpEdit
        '
        Me.ReportToGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserBindingSource, "ReportTo", True))
        Me.ReportToGridLookUpEdit.Location = New System.Drawing.Point(116, 85)
        Me.ReportToGridLookUpEdit.Name = "ReportToGridLookUpEdit"
        Me.ReportToGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ReportToGridLookUpEdit.Properties.DataSource = Me.UserLookupBindingSource
        Me.ReportToGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.ReportToGridLookUpEdit.Properties.NullText = ""
        Me.ReportToGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ReportToGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.ReportToGridLookUpEdit.Properties.View = Me.ReportToGridLookUpEditView
        Me.ReportToGridLookUpEdit.Size = New System.Drawing.Size(116, 20)
        Me.ReportToGridLookUpEdit.TabIndex = 2
        '
        'ReportToGridLookUpEditView
        '
        Me.ReportToGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_ID2, Me.colUSER_NAME1, Me.colPASSWORD1, Me.colUSER_LEVEL1, Me.colACTIVE1, Me.colDepartmentId1})
        Me.ReportToGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.ReportToGridLookUpEditView.Name = "ReportToGridLookUpEditView"
        Me.ReportToGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ReportToGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colUSER_ID2
        '
        Me.colUSER_ID2.FieldName = "USER_ID"
        Me.colUSER_ID2.Name = "colUSER_ID2"
        Me.colUSER_ID2.OptionsColumn.ReadOnly = True
        '
        'colUSER_NAME1
        '
        Me.colUSER_NAME1.FieldName = "USER_NAME"
        Me.colUSER_NAME1.Name = "colUSER_NAME1"
        Me.colUSER_NAME1.Visible = True
        Me.colUSER_NAME1.VisibleIndex = 0
        '
        'colPASSWORD1
        '
        Me.colPASSWORD1.FieldName = "PASSWORD"
        Me.colPASSWORD1.Name = "colPASSWORD1"
        '
        'colUSER_LEVEL1
        '
        Me.colUSER_LEVEL1.FieldName = "USER_LEVEL"
        Me.colUSER_LEVEL1.Name = "colUSER_LEVEL1"
        '
        'colACTIVE1
        '
        Me.colACTIVE1.FieldName = "ACTIVE"
        Me.colACTIVE1.Name = "colACTIVE1"
        '
        'colDepartmentId1
        '
        Me.colDepartmentId1.FieldName = "DepartmentId"
        Me.colDepartmentId1.Name = "colDepartmentId1"
        '
        'USER_NAMETextBox
        '
        Me.USER_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "USER_NAME", True))
        Me.USER_NAMETextBox.Location = New System.Drawing.Point(116, 29)
        Me.USER_NAMETextBox.Name = "USER_NAMETextBox"
        Me.USER_NAMETextBox.Size = New System.Drawing.Size(116, 20)
        Me.USER_NAMETextBox.TabIndex = 0
        '
        'PASSWORDTextBox
        '
        Me.PASSWORDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "PASSWORD", True))
        Me.PASSWORDTextBox.Location = New System.Drawing.Point(116, 59)
        Me.PASSWORDTextBox.Name = "PASSWORDTextBox"
        Me.PASSWORDTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PASSWORDTextBox.Size = New System.Drawing.Size(116, 20)
        Me.PASSWORDTextBox.TabIndex = 1
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UserBindingSource, "DepartmentId", True))
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(359, 58)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(163, 21)
        Me.DepartmentComboBox.TabIndex = 4
        Me.DepartmentComboBox.ValueMember = "DepartmentId"
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SetSimpleButton
        '
        Me.SetSimpleButton.Location = New System.Drawing.Point(789, 9)
        Me.SetSimpleButton.Name = "SetSimpleButton"
        Me.SetSimpleButton.Size = New System.Drawing.Size(49, 23)
        Me.SetSimpleButton.TabIndex = 4
        Me.SetSimpleButton.Text = "&Set"
        '
        'ViewCheckBox
        '
        Me.ViewCheckBox.AutoSize = True
        Me.ViewCheckBox.Location = New System.Drawing.Point(599, 14)
        Me.ViewCheckBox.Name = "ViewCheckBox"
        Me.ViewCheckBox.Size = New System.Drawing.Size(49, 17)
        Me.ViewCheckBox.TabIndex = 16
        Me.ViewCheckBox.Text = "View"
        Me.ViewCheckBox.UseVisualStyleBackColor = True
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserBindingSource, "ReportTo", True))
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(425, 10)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.ParentMenuLooupBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "ParentMenuName"
        Me.GridLookUpEdit2.Properties.ImmediatePopup = True
        Me.GridLookUpEdit2.Properties.NullText = ""
        Me.GridLookUpEdit2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit2.Properties.ValueMember = "PARENT_ID"
        Me.GridLookUpEdit2.Properties.View = Me.GridView1
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(163, 20)
        Me.GridLookUpEdit2.TabIndex = 15
        '
        'ParentMenuLooupBindingSource
        '
        Me.ParentMenuLooupBindingSource.DataMember = "ParentMenuLooup"
        Me.ParentMenuLooupBindingSource.DataSource = Me.PartenMenuLookupDataSet
        '
        'PartenMenuLookupDataSet
        '
        Me.PartenMenuLookupDataSet.DataSetName = "PartenMenuLookupDataSet"
        Me.PartenMenuLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colParentMenuName})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colParentMenuName
        '
        Me.colParentMenuName.FieldName = "ParentMenuName"
        Me.colParentMenuName.Name = "colParentMenuName"
        Me.colParentMenuName.Visible = True
        Me.colParentMenuName.VisibleIndex = 0
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(415, 3)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.UserLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "USER_NAME"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "USER_ID"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(152, 20)
        Me.GridLookUpEdit1.TabIndex = 1
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
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME, Me.colDepartment})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.Caption = "User"
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'colDepartment
        '
        Me.colDepartment.Caption = "Department"
        Me.colDepartment.FieldName = "Department"
        Me.colDepartment.Name = "colDepartment"
        Me.colDepartment.Visible = True
        Me.colDepartment.VisibleIndex = 1
        '
        'TreeList1
        '
        Me.TreeList1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colUSER_RIGHTS_ID, Me.colUSER_ID, Me.colCAN_EDIT, Me.colCAN_DELETE, Me.colCAN_VIEW, Me.colMENU_ID})
        Me.TreeList1.DataSource = Me.UserRightsBindingSource
        Me.TreeList1.KeyFieldName = "MENU_ID"
        Me.TreeList1.Location = New System.Drawing.Point(12, 230)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.ParentFieldName = "PARENT_ID"
        Me.TreeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.MenuListLookUpEdit})
        Me.TreeList1.Size = New System.Drawing.Size(923, 292)
        Me.TreeList1.TabIndex = 0
        '
        'colUSER_RIGHTS_ID
        '
        Me.colUSER_RIGHTS_ID.Caption = "USER_RIGHTS_ID"
        Me.colUSER_RIGHTS_ID.FieldName = "USER_RIGHTS_ID"
        Me.colUSER_RIGHTS_ID.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUSER_RIGHTS_ID.Name = "colUSER_RIGHTS_ID"
        Me.colUSER_RIGHTS_ID.OptionsColumn.ReadOnly = True
        Me.colUSER_RIGHTS_ID.Width = 126
        '
        'colUSER_ID
        '
        Me.colUSER_ID.Caption = "USER_ID"
        Me.colUSER_ID.FieldName = "USER_ID"
        Me.colUSER_ID.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUSER_ID.Name = "colUSER_ID"
        Me.colUSER_ID.OptionsColumn.ReadOnly = True
        Me.colUSER_ID.Width = 93
        '
        'colCAN_EDIT
        '
        Me.colCAN_EDIT.AppearanceHeader.Options.UseTextOptions = True
        Me.colCAN_EDIT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCAN_EDIT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCAN_EDIT.Caption = "CAN_EDIT"
        Me.colCAN_EDIT.FieldName = "CAN_EDIT"
        Me.colCAN_EDIT.Name = "colCAN_EDIT"
        Me.colCAN_EDIT.Visible = True
        Me.colCAN_EDIT.VisibleIndex = 2
        Me.colCAN_EDIT.Width = 100
        '
        'colCAN_DELETE
        '
        Me.colCAN_DELETE.AppearanceHeader.Options.UseTextOptions = True
        Me.colCAN_DELETE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCAN_DELETE.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCAN_DELETE.Caption = "CAN_DELETE"
        Me.colCAN_DELETE.FieldName = "CAN_DELETE"
        Me.colCAN_DELETE.Name = "colCAN_DELETE"
        Me.colCAN_DELETE.Visible = True
        Me.colCAN_DELETE.VisibleIndex = 3
        Me.colCAN_DELETE.Width = 100
        '
        'colCAN_VIEW
        '
        Me.colCAN_VIEW.AppearanceHeader.Options.UseTextOptions = True
        Me.colCAN_VIEW.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCAN_VIEW.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCAN_VIEW.Caption = "CAN_VIEW"
        Me.colCAN_VIEW.FieldName = "CAN_VIEW"
        Me.colCAN_VIEW.Name = "colCAN_VIEW"
        Me.colCAN_VIEW.Visible = True
        Me.colCAN_VIEW.VisibleIndex = 1
        Me.colCAN_VIEW.Width = 126
        '
        'colMENU_ID
        '
        Me.colMENU_ID.Caption = "MENU"
        Me.colMENU_ID.ColumnEdit = Me.MenuListLookUpEdit
        Me.colMENU_ID.FieldName = "MENU_ID"
        Me.colMENU_ID.Name = "colMENU_ID"
        Me.colMENU_ID.OptionsColumn.ReadOnly = True
        Me.colMENU_ID.Visible = True
        Me.colMENU_ID.VisibleIndex = 0
        Me.colMENU_ID.Width = 396
        '
        'MenuListLookUpEdit
        '
        Me.MenuListLookUpEdit.AutoHeight = False
        Me.MenuListLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MenuListLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MENU_ID", "MENU_ID", 68, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MENU_CODE", "MENU_CODE", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MENU_NAME", "MENU_NAME", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PARENT_ID", "PARENT_ID", 66, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PARENT_NAME", "PARENT_NAME", 83, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.MenuListLookUpEdit.DataSource = Me.MenuBindingSource
        Me.MenuListLookUpEdit.DisplayMember = "MENU_CODE"
        Me.MenuListLookUpEdit.Name = "MenuListLookUpEdit"
        Me.MenuListLookUpEdit.NullText = ""
        Me.MenuListLookUpEdit.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.MenuListLookUpEdit.ValueMember = "MENU_ID"
        '
        'ShowButton
        '
        Me.ShowButton.Location = New System.Drawing.Point(573, 2)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 2
        Me.ShowButton.Text = "Show"
        '
        'ParentMenuLookupTableAdapter
        '
        Me.ParentMenuLookupTableAdapter.ClearBeforeFill = True
        '
        'MenuNameSearchTextBox
        '
        Me.MenuNameSearchTextBox.Location = New System.Drawing.Point(157, 11)
        Me.MenuNameSearchTextBox.Name = "MenuNameSearchTextBox"
        Me.MenuNameSearchTextBox.Size = New System.Drawing.Size(144, 20)
        Me.MenuNameSearchTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Type  Menu Name Here"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.SetSimpleButton)
        Me.GroupBox2.Controls.Add(Me.DeleteCheckBox)
        Me.GroupBox2.Controls.Add(Me.EditCheckBox)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ViewCheckBox)
        Me.GroupBox2.Controls.Add(Me.MenuNameSearchTextBox)
        Me.GroupBox2.Controls.Add(Me.GridLookUpEdit2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(923, 35)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Parent Menu"
        '
        'DeleteCheckBox
        '
        Me.DeleteCheckBox.AutoSize = True
        Me.DeleteCheckBox.Location = New System.Drawing.Point(718, 14)
        Me.DeleteCheckBox.Name = "DeleteCheckBox"
        Me.DeleteCheckBox.Size = New System.Drawing.Size(57, 17)
        Me.DeleteCheckBox.TabIndex = 18
        Me.DeleteCheckBox.Text = "Delete"
        Me.DeleteCheckBox.UseVisualStyleBackColor = True
        '
        'EditCheckBox
        '
        Me.EditCheckBox.AutoSize = True
        Me.EditCheckBox.Location = New System.Drawing.Point(656, 14)
        Me.EditCheckBox.Name = "EditCheckBox"
        Me.EditCheckBox.Size = New System.Drawing.Size(44, 17)
        Me.EditCheckBox.TabIndex = 17
        Me.EditCheckBox.Text = "Edit"
        Me.EditCheckBox.UseVisualStyleBackColor = True
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'PrintSimpleButton
        '
        Me.PrintSimpleButton.Location = New System.Drawing.Point(654, 2)
        Me.PrintSimpleButton.Name = "PrintSimpleButton"
        Me.PrintSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintSimpleButton.TabIndex = 7
        Me.PrintSimpleButton.Text = "&Print"
        '
        'frmUserRights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 534)
        Me.Controls.Add(Me.PrintSimpleButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TreeList1)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UserBindingNavigator)
        Me.Name = "frmUserRights"
        Me.Text = "User Rights"
        CType(Me.UserBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserBindingNavigator.ResumeLayout(False)
        Me.UserBindingNavigator.PerformLayout()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserRightsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserRightsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACTIVECheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.USER_SIGNATUREPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportToGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportToGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParentMenuLooupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartenMenuLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuListLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserRightsDataSet As KSoft_Apparel.UserRightsDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As KSoft_Apparel.UserRightsDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.UserRightsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UserRightsTableAdapter As KSoft_Apparel.UserRightsDataSetTableAdapters.UserRightsTableAdapter
    Friend WithEvents UserRightsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuDataSet As KSoft_Apparel.MenuDataSet
    Friend WithEvents MenuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTableAdapter As KSoft_Apparel.MenuDataSetTableAdapters.MenuTableAdapter
    Friend WithEvents DepartmentDataSet As KSoft_Apparel.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Apparel.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents USER_LEVELTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ACTIVECheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PASSWORDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserDataSet As KSoft_Apparel.UserDataSet
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents colUSER_RIGHTS_ID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colUSER_ID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colCAN_EDIT As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colCAN_DELETE As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colCAN_VIEW As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colMENU_ID As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents MenuListLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents USER_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportToGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ReportToGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUSER_ID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_NAME1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPASSWORD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSER_LEVEL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACTIVE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UpdateListToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PartenMenuLookupDataSet As KSoft_Apparel.PartenMenuLookupDataSet
    Friend WithEvents ParentMenuLooupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParentMenuLookupTableAdapter As KSoft_Apparel.PartenMenuLookupDataSetTableAdapters.ParentMenuLookupTableAdapter
    Friend WithEvents ViewCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SetSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colParentMenuName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuNameSearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DeleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EditCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents UserLookupDataSet As KSoft_Apparel.UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserLookupTableAdapter As KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RefreshToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents USER_SIGNATUREPictureEdit As DevExpress.XtraEditors.PictureEdit
End Class
