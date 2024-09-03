<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRunningOrderProductionStatus
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
        Dim Label16 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim UserIdLabel1 As System.Windows.Forms.Label
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgramAllocationButton = New System.Windows.Forms.Button()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FabricMaterialTypeDataSet = New KSoft_Apparel.FabricMaterialTypeDataSet()
        Me.FabricMaterialTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricMaterialTypeTableAdapter = New KSoft_Apparel.FabricMaterialTypeDataSetTableAdapters.FabricMaterialTypeTableAdapter()
        Me.SusStandardDataSet = New KSoft_Apparel.SusStandardDataSet()
        Me.SusStandardMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SusStandardMstTableAdapter = New KSoft_Apparel.SusStandardDataSetTableAdapters.SusStandardMstTableAdapter()
        Me.SusStandGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView20 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSusStandard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabMatGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabMatType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Label16 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        UserIdLabel1 = New System.Windows.Forms.Label()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricMaterialTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricMaterialTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SusStandardDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SusStandardMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SusStandGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabMatGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(788, 31)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(117, 13)
        Label16.TabIndex = 43
        Label16.Text = "Sustainability Standard:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(788, 51)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(106, 13)
        Label6.TabIndex = 44
        Label6.Text = "Fabric Material Type:"
        '
        'UserIdLabel1
        '
        UserIdLabel1.AutoSize = True
        UserIdLabel1.Location = New System.Drawing.Point(418, 63)
        UserIdLabel1.Name = "UserIdLabel1"
        UserIdLabel1.Size = New System.Drawing.Size(74, 13)
        UserIdLabel1.TabIndex = 64
        UserIdLabel1.Text = "Merchandiser:"
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
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
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
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(-1, 88)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1191, 414)
        Me.CrystalReportViewer1.TabIndex = 15
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(788, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Select Program No :"
        '
        'ProgramAllocationButton
        '
        Me.ProgramAllocationButton.Location = New System.Drawing.Point(1104, 4)
        Me.ProgramAllocationButton.Name = "ProgramAllocationButton"
        Me.ProgramAllocationButton.Size = New System.Drawing.Size(75, 22)
        Me.ProgramAllocationButton.TabIndex = 30
        Me.ProgramAllocationButton.Text = "Show"
        Me.ProgramAllocationButton.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(913, 6)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(185, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 29
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderId, Me.colDetails})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        Me.colOrderId.OptionsColumn.ReadOnly = True
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Location = New System.Drawing.Point(14, 9)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.BuyerCheckBox.TabIndex = 28
        Me.BuyerCheckBox.Text = "Buyer :"
        Me.BuyerCheckBox.UseVisualStyleBackColor = True
        '
        'BuyerComboBox
        '
        Me.BuyerComboBox.DataSource = Me.BuyerBindingSource
        Me.BuyerComboBox.DisplayMember = "BuyerCode"
        Me.BuyerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BuyerComboBox.Enabled = False
        Me.BuyerComboBox.FormattingEnabled = True
        Me.BuyerComboBox.Location = New System.Drawing.Point(12, 31)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(129, 21)
        Me.BuyerComboBox.TabIndex = 27
        Me.BuyerComboBox.ValueMember = "BuyerId"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 35)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "&Show Confirm Order Running"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(434, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Date From :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(473, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "To:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(604, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 46)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "&Show By Order Receive"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(694, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 46)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "&Show By Fabric Booking"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(499, 9)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.FromDateTimePicker.TabIndex = 39
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(499, 35)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(99, 20)
        Me.ToDateTimePicker.TabIndex = 40
        '
        'FabricMaterialTypeDataSet
        '
        Me.FabricMaterialTypeDataSet.DataSetName = "FabricMaterialTypeDataSet"
        Me.FabricMaterialTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FabricMaterialTypeBindingSource
        '
        Me.FabricMaterialTypeBindingSource.DataMember = "FabricMaterialType"
        Me.FabricMaterialTypeBindingSource.DataSource = Me.FabricMaterialTypeDataSet
        '
        'FabricMaterialTypeTableAdapter
        '
        Me.FabricMaterialTypeTableAdapter.ClearBeforeFill = True
        '
        'SusStandardDataSet
        '
        Me.SusStandardDataSet.DataSetName = "SusStandardDataSet"
        Me.SusStandardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SusStandardMstBindingSource
        '
        Me.SusStandardMstBindingSource.DataMember = "SusStandardMst"
        Me.SusStandardMstBindingSource.DataSource = Me.SusStandardDataSet
        '
        'SusStandardMstTableAdapter
        '
        Me.SusStandardMstTableAdapter.ClearBeforeFill = True
        '
        'SusStandGridLookUpEdit
        '
        Me.SusStandGridLookUpEdit.EditValue = ""
        Me.SusStandGridLookUpEdit.Location = New System.Drawing.Point(913, 30)
        Me.SusStandGridLookUpEdit.Name = "SusStandGridLookUpEdit"
        Me.SusStandGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SusStandGridLookUpEdit.Properties.DataSource = Me.SusStandardMstBindingSource
        Me.SusStandGridLookUpEdit.Properties.DisplayMember = "SusStandard"
        Me.SusStandGridLookUpEdit.Properties.NullText = ""
        Me.SusStandGridLookUpEdit.Properties.PopupView = Me.GridView20
        Me.SusStandGridLookUpEdit.Properties.ValueMember = "SusStandard"
        Me.SusStandGridLookUpEdit.Size = New System.Drawing.Size(185, 20)
        Me.SusStandGridLookUpEdit.TabIndex = 41
        '
        'GridView20
        '
        Me.GridView20.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSusStandard})
        Me.GridView20.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView20.Name = "GridView20"
        Me.GridView20.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView20.OptionsView.ShowGroupPanel = False
        '
        'colSusStandard
        '
        Me.colSusStandard.FieldName = "SusStandard"
        Me.colSusStandard.Name = "colSusStandard"
        Me.colSusStandard.Visible = True
        Me.colSusStandard.VisibleIndex = 0
        '
        'FabMatGridLookUpEdit
        '
        Me.FabMatGridLookUpEdit.EditValue = ""
        Me.FabMatGridLookUpEdit.Location = New System.Drawing.Point(913, 53)
        Me.FabMatGridLookUpEdit.Name = "FabMatGridLookUpEdit"
        Me.FabMatGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FabMatGridLookUpEdit.Properties.DataSource = Me.FabricMaterialTypeBindingSource
        Me.FabMatGridLookUpEdit.Properties.DisplayMember = "FabMatType"
        Me.FabMatGridLookUpEdit.Properties.NullText = ""
        Me.FabMatGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.FabMatGridLookUpEdit.Properties.ValueMember = "FabMatType"
        Me.FabMatGridLookUpEdit.Size = New System.Drawing.Size(185, 20)
        Me.FabMatGridLookUpEdit.TabIndex = 42
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabMatType})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFabMatType
        '
        Me.colFabMatType.FieldName = "FabMatType"
        Me.colFabMatType.Name = "colFabMatType"
        Me.colFabMatType.Visible = True
        Me.colFabMatType.VisibleIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1104, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 22)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1104, 51)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 22)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Show"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(150, 43)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(113, 36)
        Me.Button6.TabIndex = 47
        Me.Button6.Text = "&Show Block Order Running"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(604, 61)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 21)
        Me.Button7.TabIndex = 65
        Me.Button7.Text = "&Show Confirm"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
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
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.Location = New System.Drawing.Point(498, 60)
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.Properties.DataSource = Me.UserLookupBindingSource
        Me.UserGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.Properties.ImmediatePopup = True
        Me.UserGridLookUpEdit.Properties.NullText = "[Select Merchandiser]"
        Me.UserGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UserGridLookUpEdit.Properties.PopupView = Me.GridView7
        Me.UserGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.UserGridLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.UserGridLookUpEdit.TabIndex = 77
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colUSER_NAME
        '
        Me.colUSER_NAME.FieldName = "USER_NAME"
        Me.colUSER_NAME.Name = "colUSER_NAME"
        Me.colUSER_NAME.Visible = True
        Me.colUSER_NAME.VisibleIndex = 0
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(269, 7)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(113, 34)
        Me.Button8.TabIndex = 78
        Me.Button8.Text = "&Show Actual Confirm Order Running"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(269, 43)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(113, 34)
        Me.Button9.TabIndex = 79
        Me.Button9.Text = "&Show Block Order Running"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(694, 61)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(88, 21)
        Me.Button10.TabIndex = 80
        Me.Button10.Text = "&Show Block"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'frmRunningOrderProductionStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 500)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.UserGridLookUpEdit)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(UserIdLabel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SusStandGridLookUpEdit)
        Me.Controls.Add(Me.FabMatGridLookUpEdit)
        Me.Controls.Add(Label16)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgramAllocationButton)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.BuyerCheckBox)
        Me.Controls.Add(Me.BuyerComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmRunningOrderProductionStatus"
        Me.Text = "Running Order & Production Status [Program_Style]"
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricMaterialTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricMaterialTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SusStandardDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SusStandardMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SusStandGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabMatGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents OrderLookupBindingSource As BindingSource
    Friend WithEvents OrderLookupDataSet As OrderLookupDataSet
    Friend WithEvents OrderLookupTableAdapter As OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgramAllocationButton As Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerCheckBox As CheckBox
    Friend WithEvents BuyerComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents FabricMaterialTypeDataSet As FabricMaterialTypeDataSet
    Friend WithEvents FabricMaterialTypeBindingSource As BindingSource
    Friend WithEvents FabricMaterialTypeTableAdapter As FabricMaterialTypeDataSetTableAdapters.FabricMaterialTypeTableAdapter
    Friend WithEvents SusStandardDataSet As SusStandardDataSet
    Friend WithEvents SusStandardMstBindingSource As BindingSource
    Friend WithEvents SusStandardMstTableAdapter As SusStandardDataSetTableAdapters.SusStandardMstTableAdapter
    Friend WithEvents SusStandGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView20 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSusStandard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FabMatGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFabMatType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents UserLookupTableAdapter As UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents UserLookupBindingSource As BindingSource
    Friend WithEvents UserLookupDataSet As UserLookupDataSet
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
