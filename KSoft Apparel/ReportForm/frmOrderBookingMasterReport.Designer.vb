<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrderBookingMasterReport
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShowButton2 = New System.Windows.Forms.Button()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.BuyerComboBox = New System.Windows.Forms.ComboBox()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.YearDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BookingCapacityButton = New System.Windows.Forms.Button()
        Me.ReceiveRadioButton = New System.Windows.Forms.RadioButton()
        Me.ExRadioButton = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SummeryButton = New System.Windows.Forms.Button()
        Me.POButton = New System.Windows.Forms.Button()
        Me.BuyerButton = New System.Windows.Forms.Button()
        Me.SeasonCheckBox = New System.Windows.Forms.CheckBox()
        Me.MerchandiserCheckBox = New System.Windows.Forms.CheckBox()
        Me.DivisionCheckBox = New System.Windows.Forms.CheckBox()
        Me.MerchandiserGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleTypeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BrandCheckBox = New System.Windows.Forms.CheckBox()
        Me.StyleNoCheckBox = New System.Windows.Forms.CheckBox()
        Me.SeasonGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeasonDataSet = New KSoft_Apparel.SeasonDataSet()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeasonName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMTBrandIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GMTBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMTBrandDataSet = New KSoft_Apparel.GMTBrandDataSet()
        Me.GMTBrandIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGMTBrandName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DivisionIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DivisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivisionDataSet = New KSoft_Apparel.DivisionDataSet()
        Me.DivisionIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDivisionName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.StyleTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleTypeDataSet = New KSoft_Apparel.StyleTypeDataSet()
        Me.StyleGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDefaultTarget = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.DivisionTableAdapter = New KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter()
        Me.GMTBrandTableAdapter = New KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter()
        Me.SeasonTableAdapter = New KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter()
        Me.StyleTypeMstTableAdapter = New KSoft_Apparel.StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MerchandiserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 129)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1274, 376)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(140, 7)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.FromDateTimePicker.TabIndex = 1
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(140, 50)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.ToDateTimePicker.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date From :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To :"
        '
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.Location = New System.Drawing.Point(233, 6)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(58, 64)
        Me.ShowButton.TabIndex = 5
        Me.ShowButton.Text = "&Show Confirm Order"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.EditValue = ""
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(101, 14)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(108, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 7
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
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Program No"
        '
        'ShowButton2
        '
        Me.ShowButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton2.Location = New System.Drawing.Point(215, 14)
        Me.ShowButton2.Name = "ShowButton2"
        Me.ShowButton2.Size = New System.Drawing.Size(75, 21)
        Me.ShowButton2.TabIndex = 9
        Me.ShowButton2.Text = "&Show"
        Me.ShowButton2.UseVisualStyleBackColor = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Location = New System.Drawing.Point(560, 7)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.BuyerCheckBox.TabIndex = 11
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
        Me.BuyerComboBox.Location = New System.Drawing.Point(645, 4)
        Me.BuyerComboBox.Name = "BuyerComboBox"
        Me.BuyerComboBox.Size = New System.Drawing.Size(115, 21)
        Me.BuyerComboBox.TabIndex = 10
        Me.BuyerComboBox.ValueMember = "BuyerId"
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
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(296, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "&Export"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'YearDateTimePicker
        '
        Me.YearDateTimePicker.CustomFormat = "MMM-yyyy"
        Me.YearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.YearDateTimePicker.Location = New System.Drawing.Point(80, 30)
        Me.YearDateTimePicker.Name = "YearDateTimePicker"
        Me.YearDateTimePicker.Size = New System.Drawing.Size(115, 20)
        Me.YearDateTimePicker.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Ex Year:"
        '
        'BookingCapacityButton
        '
        Me.BookingCapacityButton.Location = New System.Drawing.Point(201, 3)
        Me.BookingCapacityButton.Name = "BookingCapacityButton"
        Me.BookingCapacityButton.Size = New System.Drawing.Size(152, 51)
        Me.BookingCapacityButton.TabIndex = 17
        Me.BookingCapacityButton.Text = "Show Booking Capacity"
        Me.BookingCapacityButton.UseVisualStyleBackColor = True
        '
        'ReceiveRadioButton
        '
        Me.ReceiveRadioButton.AutoSize = True
        Me.ReceiveRadioButton.Location = New System.Drawing.Point(7, 30)
        Me.ReceiveRadioButton.Name = "ReceiveRadioButton"
        Me.ReceiveRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.ReceiveRadioButton.TabIndex = 18
        Me.ReceiveRadioButton.Text = "Receive"
        Me.ReceiveRadioButton.UseVisualStyleBackColor = True
        '
        'ExRadioButton
        '
        Me.ExRadioButton.AutoSize = True
        Me.ExRadioButton.Checked = True
        Me.ExRadioButton.Location = New System.Drawing.Point(7, 7)
        Me.ExRadioButton.Name = "ExRadioButton"
        Me.ExRadioButton.Size = New System.Drawing.Size(40, 17)
        Me.ExRadioButton.TabIndex = 19
        Me.ExRadioButton.TabStop = True
        Me.ExRadioButton.Text = "Ex "
        Me.ExRadioButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1273, 128)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.SummeryButton)
        Me.TabPage1.Controls.Add(Me.POButton)
        Me.TabPage1.Controls.Add(Me.BuyerButton)
        Me.TabPage1.Controls.Add(Me.SeasonCheckBox)
        Me.TabPage1.Controls.Add(Me.MerchandiserCheckBox)
        Me.TabPage1.Controls.Add(Me.DivisionCheckBox)
        Me.TabPage1.Controls.Add(Me.MerchandiserGridLookUpEdit)
        Me.TabPage1.Controls.Add(Me.StyleTypeCheckBox)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.BrandCheckBox)
        Me.TabPage1.Controls.Add(Me.StyleNoCheckBox)
        Me.TabPage1.Controls.Add(Me.ShowButton)
        Me.TabPage1.Controls.Add(Me.SeasonGridLookUpEdit)
        Me.TabPage1.Controls.Add(Me.ExRadioButton)
        Me.TabPage1.Controls.Add(Me.GMTBrandIdGridLookUpEdit)
        Me.TabPage1.Controls.Add(Me.FromDateTimePicker)
        Me.TabPage1.Controls.Add(Me.DivisionIdGridLookUpEdit)
        Me.TabPage1.Controls.Add(Me.ReceiveRadioButton)
        Me.TabPage1.Controls.Add(Me.StyleTypeComboBox)
        Me.TabPage1.Controls.Add(Me.ToDateTimePicker)
        Me.TabPage1.Controls.Add(Me.StyleGridLookUpEdit)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.BuyerComboBox)
        Me.TabPage1.Controls.Add(Me.BuyerCheckBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1265, 102)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ex Date wise"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(489, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(58, 64)
        Me.Button6.TabIndex = 120
        Me.Button6.Text = "&Show Cancel Order"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(1188, 55)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 19)
        Me.Button5.TabIndex = 119
        Me.Button5.Text = "Show Block"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(425, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 64)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "&Show Block Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(1031, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 70)
        Me.Button4.TabIndex = 118
        Me.Button4.Text = "&Show Block Order"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SummeryButton
        '
        Me.SummeryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SummeryButton.Location = New System.Drawing.Point(297, 6)
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(58, 64)
        Me.SummeryButton.TabIndex = 116
        Me.SummeryButton.Text = "&Show  Summery [Ex]"
        Me.SummeryButton.UseVisualStyleBackColor = True
        '
        'POButton
        '
        Me.POButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.POButton.Location = New System.Drawing.Point(361, 6)
        Me.POButton.Name = "POButton"
        Me.POButton.Size = New System.Drawing.Size(58, 64)
        Me.POButton.TabIndex = 116
        Me.POButton.Text = "&Show PO [ EX]"
        Me.POButton.UseVisualStyleBackColor = True
        '
        'BuyerButton
        '
        Me.BuyerButton.Location = New System.Drawing.Point(969, 4)
        Me.BuyerButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.BuyerButton.Name = "BuyerButton"
        Me.BuyerButton.Size = New System.Drawing.Size(56, 71)
        Me.BuyerButton.TabIndex = 115
        Me.BuyerButton.Tag = "NR"
        Me.BuyerButton.Text = "Show Confirm Order"
        Me.BuyerButton.UseVisualStyleBackColor = True
        '
        'SeasonCheckBox
        '
        Me.SeasonCheckBox.AutoSize = True
        Me.SeasonCheckBox.Location = New System.Drawing.Point(766, 58)
        Me.SeasonCheckBox.Name = "SeasonCheckBox"
        Me.SeasonCheckBox.Size = New System.Drawing.Size(68, 17)
        Me.SeasonCheckBox.TabIndex = 110
        Me.SeasonCheckBox.Text = "Season :"
        Me.SeasonCheckBox.UseVisualStyleBackColor = True
        '
        'MerchandiserCheckBox
        '
        Me.MerchandiserCheckBox.AutoSize = True
        Me.MerchandiserCheckBox.Location = New System.Drawing.Point(1106, 9)
        Me.MerchandiserCheckBox.Name = "MerchandiserCheckBox"
        Me.MerchandiserCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.MerchandiserCheckBox.TabIndex = 21
        Me.MerchandiserCheckBox.Text = "Merchandiser"
        Me.MerchandiserCheckBox.UseVisualStyleBackColor = True
        '
        'DivisionCheckBox
        '
        Me.DivisionCheckBox.AutoSize = True
        Me.DivisionCheckBox.Location = New System.Drawing.Point(766, 31)
        Me.DivisionCheckBox.Name = "DivisionCheckBox"
        Me.DivisionCheckBox.Size = New System.Drawing.Size(69, 17)
        Me.DivisionCheckBox.TabIndex = 111
        Me.DivisionCheckBox.Text = "Division :"
        Me.DivisionCheckBox.UseVisualStyleBackColor = True
        '
        'MerchandiserGridLookUpEdit
        '
        Me.MerchandiserGridLookUpEdit.Location = New System.Drawing.Point(1104, 30)
        Me.MerchandiserGridLookUpEdit.Name = "MerchandiserGridLookUpEdit"
        Me.MerchandiserGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MerchandiserGridLookUpEdit.Properties.DataSource = Me.UserLookupBindingSource
        Me.MerchandiserGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.MerchandiserGridLookUpEdit.Properties.ImmediatePopup = True
        Me.MerchandiserGridLookUpEdit.Properties.NullText = ""
        Me.MerchandiserGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.MerchandiserGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.MerchandiserGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.MerchandiserGridLookUpEdit.Properties.ValueMember = "USER_NAME"
        Me.MerchandiserGridLookUpEdit.Size = New System.Drawing.Size(158, 20)
        Me.MerchandiserGridLookUpEdit.TabIndex = 20
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
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUSER_NAME, Me.colDepartment})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        'StyleTypeCheckBox
        '
        Me.StyleTypeCheckBox.AutoSize = True
        Me.StyleTypeCheckBox.Location = New System.Drawing.Point(560, 58)
        Me.StyleTypeCheckBox.Name = "StyleTypeCheckBox"
        Me.StyleTypeCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.StyleTypeCheckBox.TabIndex = 112
        Me.StyleTypeCheckBox.Text = "Style Type :"
        Me.StyleTypeCheckBox.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(1104, 55)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 19)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Show Confirm"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BrandCheckBox
        '
        Me.BrandCheckBox.AutoSize = True
        Me.BrandCheckBox.Location = New System.Drawing.Point(766, 6)
        Me.BrandCheckBox.Name = "BrandCheckBox"
        Me.BrandCheckBox.Size = New System.Drawing.Size(60, 17)
        Me.BrandCheckBox.TabIndex = 113
        Me.BrandCheckBox.Text = "Brand :"
        Me.BrandCheckBox.UseVisualStyleBackColor = True
        '
        'StyleNoCheckBox
        '
        Me.StyleNoCheckBox.AutoSize = True
        Me.StyleNoCheckBox.Location = New System.Drawing.Point(560, 32)
        Me.StyleNoCheckBox.Name = "StyleNoCheckBox"
        Me.StyleNoCheckBox.Size = New System.Drawing.Size(72, 17)
        Me.StyleNoCheckBox.TabIndex = 114
        Me.StyleNoCheckBox.Text = "Style No :"
        Me.StyleNoCheckBox.UseVisualStyleBackColor = True
        '
        'SeasonGridLookUpEdit
        '
        Me.SeasonGridLookUpEdit.EditValue = ""
        Me.SeasonGridLookUpEdit.Location = New System.Drawing.Point(836, 54)
        Me.SeasonGridLookUpEdit.Name = "SeasonGridLookUpEdit"
        Me.SeasonGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SeasonGridLookUpEdit.Properties.DataSource = Me.SeasonBindingSource
        Me.SeasonGridLookUpEdit.Properties.DisplayMember = "SeasonName"
        Me.SeasonGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SeasonGridLookUpEdit.Properties.NullText = "[Select Season]"
        Me.SeasonGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SeasonGridLookUpEdit.Properties.PopupView = Me.GridView5
        Me.SeasonGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SeasonGridLookUpEdit.Properties.ValueMember = "SeasonId"
        Me.SeasonGridLookUpEdit.Size = New System.Drawing.Size(124, 20)
        Me.SeasonGridLookUpEdit.TabIndex = 109
        '
        'SeasonBindingSource
        '
        Me.SeasonBindingSource.DataMember = "Season"
        Me.SeasonBindingSource.DataSource = Me.SeasonDataSet
        '
        'SeasonDataSet
        '
        Me.SeasonDataSet.DataSetName = "SeasonDataSet"
        Me.SeasonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeasonName})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colSeasonName
        '
        Me.colSeasonName.FieldName = "SeasonName"
        Me.colSeasonName.Name = "colSeasonName"
        Me.colSeasonName.Visible = True
        Me.colSeasonName.VisibleIndex = 0
        '
        'GMTBrandIdGridLookUpEdit
        '
        Me.GMTBrandIdGridLookUpEdit.Location = New System.Drawing.Point(836, 6)
        Me.GMTBrandIdGridLookUpEdit.Name = "GMTBrandIdGridLookUpEdit"
        Me.GMTBrandIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GMTBrandIdGridLookUpEdit.Properties.DataSource = Me.GMTBrandBindingSource
        Me.GMTBrandIdGridLookUpEdit.Properties.DisplayMember = "GMTBrandName"
        Me.GMTBrandIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.GMTBrandIdGridLookUpEdit.Properties.NullText = ""
        Me.GMTBrandIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GMTBrandIdGridLookUpEdit.Properties.PopupView = Me.GMTBrandIdGridLookUpEditView
        Me.GMTBrandIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GMTBrandIdGridLookUpEdit.Properties.ValueMember = "GMTBrandId"
        Me.GMTBrandIdGridLookUpEdit.Size = New System.Drawing.Size(124, 20)
        Me.GMTBrandIdGridLookUpEdit.TabIndex = 108
        '
        'GMTBrandBindingSource
        '
        Me.GMTBrandBindingSource.DataMember = "GMTBrand"
        Me.GMTBrandBindingSource.DataSource = Me.GMTBrandDataSet
        '
        'GMTBrandDataSet
        '
        Me.GMTBrandDataSet.DataSetName = "GMTBrandDataSet"
        Me.GMTBrandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GMTBrandIdGridLookUpEditView
        '
        Me.GMTBrandIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGMTBrandName})
        Me.GMTBrandIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GMTBrandIdGridLookUpEditView.Name = "GMTBrandIdGridLookUpEditView"
        Me.GMTBrandIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GMTBrandIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colGMTBrandName
        '
        Me.colGMTBrandName.FieldName = "GMTBrandName"
        Me.colGMTBrandName.Name = "colGMTBrandName"
        Me.colGMTBrandName.Visible = True
        Me.colGMTBrandName.VisibleIndex = 0
        '
        'DivisionIdGridLookUpEdit
        '
        Me.DivisionIdGridLookUpEdit.Location = New System.Drawing.Point(836, 31)
        Me.DivisionIdGridLookUpEdit.Name = "DivisionIdGridLookUpEdit"
        Me.DivisionIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DivisionIdGridLookUpEdit.Properties.DataSource = Me.DivisionBindingSource
        Me.DivisionIdGridLookUpEdit.Properties.DisplayMember = "DivisionName"
        Me.DivisionIdGridLookUpEdit.Properties.NullText = ""
        Me.DivisionIdGridLookUpEdit.Properties.PopupView = Me.DivisionIdGridLookUpEditView
        Me.DivisionIdGridLookUpEdit.Properties.ValueMember = "DivisionId"
        Me.DivisionIdGridLookUpEdit.Size = New System.Drawing.Size(124, 20)
        Me.DivisionIdGridLookUpEdit.TabIndex = 107
        '
        'DivisionBindingSource
        '
        Me.DivisionBindingSource.DataMember = "Division"
        Me.DivisionBindingSource.DataSource = Me.DivisionDataSet
        '
        'DivisionDataSet
        '
        Me.DivisionDataSet.DataSetName = "DivisionDataSet"
        Me.DivisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DivisionIdGridLookUpEditView
        '
        Me.DivisionIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDivisionName})
        Me.DivisionIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.DivisionIdGridLookUpEditView.Name = "DivisionIdGridLookUpEditView"
        Me.DivisionIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DivisionIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDivisionName
        '
        Me.colDivisionName.FieldName = "DivisionName"
        Me.colDivisionName.Name = "colDivisionName"
        Me.colDivisionName.Visible = True
        Me.colDivisionName.VisibleIndex = 0
        '
        'StyleTypeComboBox
        '
        Me.StyleTypeComboBox.DataSource = Me.StyleTypeMstBindingSource
        Me.StyleTypeComboBox.DisplayMember = "StyleType"
        Me.StyleTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StyleTypeComboBox.FormattingEnabled = True
        Me.StyleTypeComboBox.Location = New System.Drawing.Point(645, 53)
        Me.StyleTypeComboBox.Name = "StyleTypeComboBox"
        Me.StyleTypeComboBox.Size = New System.Drawing.Size(115, 21)
        Me.StyleTypeComboBox.TabIndex = 106
        Me.StyleTypeComboBox.ValueMember = "StyleType"
        '
        'StyleTypeMstBindingSource
        '
        Me.StyleTypeMstBindingSource.DataMember = "StyleTypeMst"
        Me.StyleTypeMstBindingSource.DataSource = Me.StyleTypeDataSet
        '
        'StyleTypeDataSet
        '
        Me.StyleTypeDataSet.DataSetName = "StyleTypeDataSet"
        Me.StyleTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleGridLookUpEdit
        '
        Me.StyleGridLookUpEdit.Location = New System.Drawing.Point(645, 28)
        Me.StyleGridLookUpEdit.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.StyleGridLookUpEdit.Name = "StyleGridLookUpEdit"
        Me.StyleGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleGridLookUpEdit.Properties.DataSource = Me.StyleBindingSource
        Me.StyleGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleGridLookUpEdit.Properties.NullText = ""
        Me.StyleGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleGridLookUpEdit.Properties.PopupView = Me.GridView3
        Me.StyleGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleGridLookUpEdit.Size = New System.Drawing.Size(115, 20)
        Me.StyleGridLookUpEdit.TabIndex = 105
        Me.StyleGridLookUpEdit.Tag = "NR"
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.EnforceConstraints = False
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleId, Me.colStyleName, Me.colBuyerId1, Me.colDefaultTarget, Me.colSMV})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colStyleId
        '
        Me.colStyleId.FieldName = "StyleId"
        Me.colStyleId.Name = "colStyleId"
        Me.colStyleId.OptionsColumn.ReadOnly = True
        '
        'colStyleName
        '
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 0
        '
        'colBuyerId1
        '
        Me.colBuyerId1.FieldName = "BuyerId"
        Me.colBuyerId1.Name = "colBuyerId1"
        '
        'colDefaultTarget
        '
        Me.colDefaultTarget.FieldName = "DefaultTarget"
        Me.colDefaultTarget.Name = "colDefaultTarget"
        '
        'colSMV
        '
        Me.colSMV.FieldName = "SMV"
        Me.colSMV.Name = "colSMV"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.ShowButton2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1265, 83)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Program wise"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CheckBox1)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.BookingCapacityButton)
        Me.TabPage3.Controls.Add(Me.YearDateTimePicker)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1265, 102)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Booking Capacity [Sewing]"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'DivisionTableAdapter
        '
        Me.DivisionTableAdapter.ClearBeforeFill = True
        '
        'GMTBrandTableAdapter
        '
        Me.GMTBrandTableAdapter.ClearBeforeFill = True
        '
        'SeasonTableAdapter
        '
        Me.SeasonTableAdapter.ClearBeforeFill = True
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'StyleTypeMstTableAdapter
        '
        Me.StyleTypeMstTableAdapter.ClearBeforeFill = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox1.TabIndex = 33
        Me.CheckBox1.Text = "Buyer :"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.BuyerBindingSource
        Me.ComboBox1.DisplayMember = "BuyerCode"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(80, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox1.TabIndex = 32
        Me.ComboBox1.ValueMember = "BuyerId"
        '
        'frmOrderBookingMasterReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 505)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmOrderBookingMasterReport"
        Me.Text = "Order Booking Master Report"
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.MerchandiserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShowButton2 As System.Windows.Forms.Button
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents BuyerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BuyerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents YearDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BookingCapacityButton As System.Windows.Forms.Button
    Friend WithEvents ReceiveRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ExRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents MerchandiserCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MerchandiserGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserLookupDataSet As KSoft_Apparel.UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserLookupTableAdapter As KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DivisionTableAdapter As DivisionDataSetTableAdapters.DivisionTableAdapter
    Friend WithEvents DivisionBindingSource As BindingSource
    Friend WithEvents DivisionDataSet As DivisionDataSet
    Friend WithEvents GMTBrandDataSet As GMTBrandDataSet
    Friend WithEvents GMTBrandBindingSource As BindingSource
    Friend WithEvents GMTBrandTableAdapter As GMTBrandDataSetTableAdapters.GMTBrandTableAdapter
    Friend WithEvents SeasonDataSet As SeasonDataSet
    Friend WithEvents SeasonBindingSource As BindingSource
    Friend WithEvents SeasonTableAdapter As SeasonDataSetTableAdapters.SeasonTableAdapter
    Friend WithEvents StyleLookupDataSet As StyleLookupDataSet
    Friend WithEvents StyleBindingSource As BindingSource
    Friend WithEvents StyleTableAdapter As StyleLookupDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents StyleTypeMstTableAdapter As StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter
    Friend WithEvents StyleTypeDataSet As StyleTypeDataSet
    Friend WithEvents StyleTypeMstBindingSource As BindingSource
    Friend WithEvents SeasonCheckBox As CheckBox
    Friend WithEvents DivisionCheckBox As CheckBox
    Friend WithEvents StyleTypeCheckBox As CheckBox
    Friend WithEvents BrandCheckBox As CheckBox
    Friend WithEvents StyleNoCheckBox As CheckBox
    Friend WithEvents SeasonGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeasonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMTBrandIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GMTBrandIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGMTBrandName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DivisionIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents DivisionIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDivisionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleTypeComboBox As ComboBox
    Friend WithEvents StyleGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultTarget As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerButton As Button
    Friend WithEvents SummeryButton As Button
    Friend WithEvents POButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
