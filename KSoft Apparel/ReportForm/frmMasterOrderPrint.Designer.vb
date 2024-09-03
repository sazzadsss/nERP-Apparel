<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMasterOrderPrint
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
        Me.MasterOrderLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.MasterOrderLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterOrderLookUpDataSet = New KSoft_Apparel.MasterOrderLookUpDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MasterOrderLookUpTableAdapter = New KSoft_Apparel.MasterOrderLookUpDataSetTableAdapters.MasterOrderLookUpTableAdapter()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnProgramDate = New System.Windows.Forms.Button()
        Me.ToProgramDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FromProgramDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.StyleIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.BrandGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GMTBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMTBrandDataSet = New KSoft_Apparel.GMTBrandDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGMTBrandName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColorGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FabricColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricColorDataSet = New KSoft_Apparel.FabricColorDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricColorTableAdapter = New KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter()
        Me.StyleLookupTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter()
        Me.BuyerRadioButton = New System.Windows.Forms.RadioButton()
        Me.StyleRadioButton = New System.Windows.Forms.RadioButton()
        Me.BrandRadioButton = New System.Windows.Forms.RadioButton()
        Me.ColorRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.MasterDetailsProgramLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterDetailsProgramLookUpDataSet = New KSoft_Apparel.MasterDetailsProgramLookUpDataSet()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgrmaShowButton = New System.Windows.Forms.Button()
        Me.GMTBrandTableAdapter = New KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter()
        Me.MasterDetailsProgramLookUpTableAdapter = New KSoft_Apparel.MasterDetailsProgramLookUpDataSetTableAdapters.MasterDetailsProgramLookUpTableAdapter()
        Me.ShowByFirstExDateButton = New System.Windows.Forms.Button()
        Me.SeasonRadioButton = New System.Windows.Forms.RadioButton()
        Me.SeasonDataSet = New KSoft_Apparel.SeasonDataSet()
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeasonTableAdapter = New KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter()
        Me.SeasonGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeasonName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleTypeRadioButton = New System.Windows.Forms.RadioButton()
        Me.StyleTypeGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleTypeDataSet = New KSoft_Apparel.StyleTypeDataSet()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DivisionRadioButton = New System.Windows.Forms.RadioButton()
        Me.DivisionGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DivisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivisionDataSet = New KSoft_Apparel.DivisionDataSet()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDivisionName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RFIDateRadioButton = New System.Windows.Forms.RadioButton()
        Me.ExFactoryDateRadioButton = New System.Windows.Forms.RadioButton()
        Me.CreatedDateRadioButton = New System.Windows.Forms.RadioButton()
        Me.StyleTypeMstTableAdapter = New KSoft_Apparel.StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter()
        Me.DivisionTableAdapter = New KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShipmentDateRadioButton = New System.Windows.Forms.RadioButton()
        Me.ByMerchComboBox = New System.Windows.Forms.ComboBox()
        Me.RunningAllRadioButton = New System.Windows.Forms.RadioButton()
        Me.ShipoutRadioButton = New System.Windows.Forms.RadioButton()
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.RunningRadioButton = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateBuyerRunningButton = New System.Windows.Forms.Button()
        CType(Me.MasterOrderLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterOrderLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDetailsProgramLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDetailsProgramLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MasterOrderLookUpEdit
        '
        Me.MasterOrderLookUpEdit.Location = New System.Drawing.Point(126, 15)
        Me.MasterOrderLookUpEdit.Name = "MasterOrderLookUpEdit"
        Me.MasterOrderLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.MasterOrderLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MasterOrderLookUpEdit.Properties.DataSource = Me.MasterOrderLookUpBindingSource
        Me.MasterOrderLookUpEdit.Properties.DisplayMember = "Details"
        Me.MasterOrderLookUpEdit.Properties.ImmediatePopup = True
        Me.MasterOrderLookUpEdit.Properties.NullText = ""
        Me.MasterOrderLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.MasterOrderLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.MasterOrderLookUpEdit.Properties.ValueMember = "MasterOrderId"
        Me.MasterOrderLookUpEdit.Properties.View = Me.GridView2
        Me.MasterOrderLookUpEdit.Size = New System.Drawing.Size(349, 20)
        Me.MasterOrderLookUpEdit.TabIndex = 51
        '
        'MasterOrderLookUpBindingSource
        '
        Me.MasterOrderLookUpBindingSource.DataMember = "MasterOrderLookUp"
        Me.MasterOrderLookUpBindingSource.DataSource = Me.MasterOrderLookUpDataSet
        '
        'MasterOrderLookUpDataSet
        '
        Me.MasterOrderLookUpDataSet.DataSetName = "MasterOrderLookUpDataSet"
        Me.MasterOrderLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colDetails
        '
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.OptionsColumn.ReadOnly = True
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'ShowButton
        '
        Me.ShowButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ShowButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ShowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowButton.Location = New System.Drawing.Point(481, 14)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(118, 23)
        Me.ShowButton.TabIndex = 49
        Me.ShowButton.Text = "Show"
        Me.ShowButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Master Program No :"
        '
        'MasterOrderLookUpTableAdapter
        '
        Me.MasterOrderLookUpTableAdapter.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 155)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1354, 378)
        Me.CrystalReportViewer1.TabIndex = 52
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btnProgramDate
        '
        Me.btnProgramDate.Location = New System.Drawing.Point(1015, 99)
        Me.btnProgramDate.Name = "btnProgramDate"
        Me.btnProgramDate.Size = New System.Drawing.Size(77, 50)
        Me.btnProgramDate.TabIndex = 54
        Me.btnProgramDate.Text = "Show"
        Me.btnProgramDate.UseVisualStyleBackColor = True
        '
        'ToProgramDateTimePicker
        '
        Me.ToProgramDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToProgramDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToProgramDateTimePicker.Location = New System.Drawing.Point(625, 20)
        Me.ToProgramDateTimePicker.Name = "ToProgramDateTimePicker"
        Me.ToProgramDateTimePicker.Size = New System.Drawing.Size(88, 20)
        Me.ToProgramDateTimePicker.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(593, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "To :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "From :"
        '
        'FromProgramDateTimePicker
        '
        Me.FromProgramDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromProgramDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromProgramDateTimePicker.Location = New System.Drawing.Point(499, 20)
        Me.FromProgramDateTimePicker.Name = "FromProgramDateTimePicker"
        Me.FromProgramDateTimePicker.Size = New System.Drawing.Size(88, 20)
        Me.FromProgramDateTimePicker.TabIndex = 58
        '
        'colDepartment
        '
        Me.colDepartment.FieldName = "Department"
        Me.colDepartment.Name = "colDepartment"
        Me.colDepartment.Visible = True
        Me.colDepartment.VisibleIndex = 1
        '
        'StyleIdGridLookUpEdit
        '
        Me.StyleIdGridLookUpEdit.Location = New System.Drawing.Point(113, 26)
        Me.StyleIdGridLookUpEdit.Name = "StyleIdGridLookUpEdit"
        Me.StyleIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleIdGridLookUpEdit.Properties.DataSource = Me.StyleLookupBindingSource
        Me.StyleIdGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleIdGridLookUpEdit.Properties.NullText = "[Select Style]"
        Me.StyleIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleIdGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleIdGridLookUpEdit.Properties.View = Me.StyleIdGridLookUpEditView
        Me.StyleIdGridLookUpEdit.Size = New System.Drawing.Size(107, 20)
        Me.StyleIdGridLookUpEdit.TabIndex = 62
        '
        'StyleLookupBindingSource
        '
        Me.StyleLookupBindingSource.DataMember = "StyleLookup"
        Me.StyleLookupBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleIdGridLookUpEditView
        '
        Me.StyleIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleName1})
        Me.StyleIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.StyleIdGridLookUpEditView.Name = "StyleIdGridLookUpEditView"
        Me.StyleIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.StyleIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colStyleName1
        '
        Me.colStyleName1.FieldName = "StyleName"
        Me.colStyleName1.Name = "colStyleName1"
        Me.colStyleName1.Visible = True
        Me.colStyleName1.VisibleIndex = 0
        '
        'BuyerIdGridLookUpEdit
        '
        Me.BuyerIdGridLookUpEdit.Location = New System.Drawing.Point(2, 26)
        Me.BuyerIdGridLookUpEdit.Name = "BuyerIdGridLookUpEdit"
        Me.BuyerIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerIdGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerIdGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerIdGridLookUpEdit.Properties.NullText = "[Select Buyer]"
        Me.BuyerIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerIdGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerIdGridLookUpEdit.Properties.View = Me.BuyerIdGridLookUpEditView
        Me.BuyerIdGridLookUpEdit.Size = New System.Drawing.Size(105, 20)
        Me.BuyerIdGridLookUpEdit.TabIndex = 63
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
        'BuyerIdGridLookUpEditView
        '
        Me.BuyerIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerName1})
        Me.BuyerIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.BuyerIdGridLookUpEditView.Name = "BuyerIdGridLookUpEditView"
        Me.BuyerIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.BuyerIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colBuyerName1
        '
        Me.colBuyerName1.FieldName = "BuyerName"
        Me.colBuyerName1.Name = "colBuyerName1"
        Me.colBuyerName1.Visible = True
        Me.colBuyerName1.VisibleIndex = 0
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'BrandGridLookUpEdit
        '
        Me.BrandGridLookUpEdit.Location = New System.Drawing.Point(226, 26)
        Me.BrandGridLookUpEdit.Name = "BrandGridLookUpEdit"
        Me.BrandGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BrandGridLookUpEdit.Properties.DataSource = Me.GMTBrandBindingSource
        Me.BrandGridLookUpEdit.Properties.DisplayMember = "GMTBrandName"
        Me.BrandGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BrandGridLookUpEdit.Properties.NullText = "[Select Brand]"
        Me.BrandGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BrandGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BrandGridLookUpEdit.Properties.ValueMember = "GMTBrandId"
        Me.BrandGridLookUpEdit.Properties.View = Me.GridView1
        Me.BrandGridLookUpEdit.Size = New System.Drawing.Size(109, 20)
        Me.BrandGridLookUpEdit.TabIndex = 64
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
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGMTBrandName})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colGMTBrandName
        '
        Me.colGMTBrandName.FieldName = "GMTBrandName"
        Me.colGMTBrandName.Name = "colGMTBrandName"
        Me.colGMTBrandName.Visible = True
        Me.colGMTBrandName.VisibleIndex = 0
        '
        'ColorGridLookUpEdit
        '
        Me.ColorGridLookUpEdit.Location = New System.Drawing.Point(341, 26)
        Me.ColorGridLookUpEdit.Name = "ColorGridLookUpEdit"
        Me.ColorGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorGridLookUpEdit.Properties.DataSource = Me.FabricColorBindingSource
        Me.ColorGridLookUpEdit.Properties.DisplayMember = "FabricColorName"
        Me.ColorGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ColorGridLookUpEdit.Properties.NullText = "[Select Color]"
        Me.ColorGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ColorGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ColorGridLookUpEdit.Properties.ValueMember = "FabricColorId"
        Me.ColorGridLookUpEdit.Properties.View = Me.GridView3
        Me.ColorGridLookUpEdit.Size = New System.Drawing.Size(112, 20)
        Me.ColorGridLookUpEdit.TabIndex = 65
        '
        'FabricColorBindingSource
        '
        Me.FabricColorBindingSource.DataMember = "FabricColor"
        Me.FabricColorBindingSource.DataSource = Me.FabricColorDataSet
        '
        'FabricColorDataSet
        '
        Me.FabricColorDataSet.DataSetName = "FabricColorDataSet"
        Me.FabricColorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricColorName})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colFabricColorName
        '
        Me.colFabricColorName.FieldName = "FabricColorName"
        Me.colFabricColorName.Name = "colFabricColorName"
        Me.colFabricColorName.Visible = True
        Me.colFabricColorName.VisibleIndex = 0
        '
        'FabricColorTableAdapter
        '
        Me.FabricColorTableAdapter.ClearBeforeFill = True
        '
        'StyleLookupTableAdapter
        '
        Me.StyleLookupTableAdapter.ClearBeforeFill = True
        '
        'BuyerRadioButton
        '
        Me.BuyerRadioButton.AutoSize = True
        Me.BuyerRadioButton.Location = New System.Drawing.Point(2, 6)
        Me.BuyerRadioButton.Name = "BuyerRadioButton"
        Me.BuyerRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.BuyerRadioButton.TabIndex = 66
        Me.BuyerRadioButton.Text = "Buyer"
        Me.BuyerRadioButton.UseVisualStyleBackColor = True
        '
        'StyleRadioButton
        '
        Me.StyleRadioButton.AutoSize = True
        Me.StyleRadioButton.Location = New System.Drawing.Point(113, 6)
        Me.StyleRadioButton.Name = "StyleRadioButton"
        Me.StyleRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.StyleRadioButton.TabIndex = 67
        Me.StyleRadioButton.Text = "Style"
        Me.StyleRadioButton.UseVisualStyleBackColor = True
        '
        'BrandRadioButton
        '
        Me.BrandRadioButton.AutoSize = True
        Me.BrandRadioButton.Location = New System.Drawing.Point(226, 6)
        Me.BrandRadioButton.Name = "BrandRadioButton"
        Me.BrandRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.BrandRadioButton.TabIndex = 68
        Me.BrandRadioButton.Text = "Brand"
        Me.BrandRadioButton.UseVisualStyleBackColor = True
        '
        'ColorRadioButton
        '
        Me.ColorRadioButton.AutoSize = True
        Me.ColorRadioButton.Location = New System.Drawing.Point(341, 6)
        Me.ColorRadioButton.Name = "ColorRadioButton"
        Me.ColorRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.ColorRadioButton.TabIndex = 69
        Me.ColorRadioButton.Text = "Color"
        Me.ColorRadioButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(634, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Program No : "
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(712, 14)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.MasterDetailsProgramLookUpBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.NullText = ""
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "ProgramNo"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridView4
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(380, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 71
        '
        'MasterDetailsProgramLookUpBindingSource
        '
        Me.MasterDetailsProgramLookUpBindingSource.DataMember = "MasterDetailsProgramLookUp"
        Me.MasterDetailsProgramLookUpBindingSource.DataSource = Me.MasterDetailsProgramLookUpDataSet
        '
        'MasterDetailsProgramLookUpDataSet
        '
        Me.MasterDetailsProgramLookUpDataSet.DataSetName = "MasterDetailsProgramLookUpDataSet"
        Me.MasterDetailsProgramLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colDetails1
        '
        Me.colDetails1.Caption = "Program No :: Buyer :: Style :: PO :: Brand :: Color"
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'ProgrmaShowButton
        '
        Me.ProgrmaShowButton.Location = New System.Drawing.Point(1098, 12)
        Me.ProgrmaShowButton.Name = "ProgrmaShowButton"
        Me.ProgrmaShowButton.Size = New System.Drawing.Size(88, 23)
        Me.ProgrmaShowButton.TabIndex = 72
        Me.ProgrmaShowButton.Text = "Show"
        Me.ProgrmaShowButton.UseVisualStyleBackColor = True
        '
        'GMTBrandTableAdapter
        '
        Me.GMTBrandTableAdapter.ClearBeforeFill = True
        '
        'MasterDetailsProgramLookUpTableAdapter
        '
        Me.MasterDetailsProgramLookUpTableAdapter.ClearBeforeFill = True
        '
        'ShowByFirstExDateButton
        '
        Me.ShowByFirstExDateButton.Location = New System.Drawing.Point(719, 19)
        Me.ShowByFirstExDateButton.Name = "ShowByFirstExDateButton"
        Me.ShowByFirstExDateButton.Size = New System.Drawing.Size(53, 23)
        Me.ShowByFirstExDateButton.TabIndex = 73
        Me.ShowByFirstExDateButton.Text = "Show"
        Me.ShowByFirstExDateButton.UseVisualStyleBackColor = True
        '
        'SeasonRadioButton
        '
        Me.SeasonRadioButton.AutoSize = True
        Me.SeasonRadioButton.Location = New System.Drawing.Point(458, 6)
        Me.SeasonRadioButton.Name = "SeasonRadioButton"
        Me.SeasonRadioButton.Size = New System.Drawing.Size(61, 17)
        Me.SeasonRadioButton.TabIndex = 75
        Me.SeasonRadioButton.Text = "Season"
        Me.SeasonRadioButton.UseVisualStyleBackColor = True
        '
        'SeasonDataSet
        '
        Me.SeasonDataSet.DataSetName = "SeasonDataSet"
        Me.SeasonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeasonBindingSource
        '
        Me.SeasonBindingSource.DataMember = "Season"
        Me.SeasonBindingSource.DataSource = Me.SeasonDataSet
        '
        'SeasonTableAdapter
        '
        Me.SeasonTableAdapter.ClearBeforeFill = True
        '
        'SeasonGridLookUpEdit
        '
        Me.SeasonGridLookUpEdit.Location = New System.Drawing.Point(459, 26)
        Me.SeasonGridLookUpEdit.Name = "SeasonGridLookUpEdit"
        Me.SeasonGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SeasonGridLookUpEdit.Properties.DataSource = Me.SeasonBindingSource
        Me.SeasonGridLookUpEdit.Properties.DisplayMember = "SeasonName"
        Me.SeasonGridLookUpEdit.Properties.ImmediatePopup = True
        Me.SeasonGridLookUpEdit.Properties.NullText = "[Select Season]"
        Me.SeasonGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.SeasonGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SeasonGridLookUpEdit.Properties.ValueMember = "SeasonId"
        Me.SeasonGridLookUpEdit.Properties.View = Me.GridView5
        Me.SeasonGridLookUpEdit.Size = New System.Drawing.Size(112, 20)
        Me.SeasonGridLookUpEdit.TabIndex = 76
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
        'StyleTypeRadioButton
        '
        Me.StyleTypeRadioButton.AutoSize = True
        Me.StyleTypeRadioButton.Location = New System.Drawing.Point(576, 6)
        Me.StyleTypeRadioButton.Name = "StyleTypeRadioButton"
        Me.StyleTypeRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.StyleTypeRadioButton.TabIndex = 75
        Me.StyleTypeRadioButton.Text = "Style Type"
        Me.StyleTypeRadioButton.UseVisualStyleBackColor = True
        '
        'StyleTypeGridLookUpEdit
        '
        Me.StyleTypeGridLookUpEdit.Location = New System.Drawing.Point(577, 26)
        Me.StyleTypeGridLookUpEdit.Name = "StyleTypeGridLookUpEdit"
        Me.StyleTypeGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleTypeGridLookUpEdit.Properties.DataSource = Me.StyleTypeMstBindingSource
        Me.StyleTypeGridLookUpEdit.Properties.DisplayMember = "StyleType"
        Me.StyleTypeGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleTypeGridLookUpEdit.Properties.NullText = "[Select Style Type]"
        Me.StyleTypeGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleTypeGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleTypeGridLookUpEdit.Properties.ValueMember = "StyleType"
        Me.StyleTypeGridLookUpEdit.Properties.View = Me.GridView6
        Me.StyleTypeGridLookUpEdit.Size = New System.Drawing.Size(114, 20)
        Me.StyleTypeGridLookUpEdit.TabIndex = 76
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
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleType})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colStyleType
        '
        Me.colStyleType.FieldName = "StyleType"
        Me.colStyleType.Name = "colStyleType"
        Me.colStyleType.Visible = True
        Me.colStyleType.VisibleIndex = 0
        '
        'UserGridLookUpEdit
        '
        Me.UserGridLookUpEdit.Location = New System.Drawing.Point(962, 64)
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.Properties.DataSource = Me.UserLookupBindingSource
        Me.UserGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.Properties.ImmediatePopup = True
        Me.UserGridLookUpEdit.Properties.NullText = "[Select Merchandiser]"
        Me.UserGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UserGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.UserGridLookUpEdit.Properties.View = Me.GridView7
        Me.UserGridLookUpEdit.Size = New System.Drawing.Size(130, 20)
        Me.UserGridLookUpEdit.TabIndex = 76
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
        'DivisionRadioButton
        '
        Me.DivisionRadioButton.AutoSize = True
        Me.DivisionRadioButton.Location = New System.Drawing.Point(696, 6)
        Me.DivisionRadioButton.Name = "DivisionRadioButton"
        Me.DivisionRadioButton.Size = New System.Drawing.Size(62, 17)
        Me.DivisionRadioButton.TabIndex = 75
        Me.DivisionRadioButton.Text = "Division"
        Me.DivisionRadioButton.UseVisualStyleBackColor = True
        '
        'DivisionGridLookUpEdit
        '
        Me.DivisionGridLookUpEdit.Location = New System.Drawing.Point(697, 26)
        Me.DivisionGridLookUpEdit.Name = "DivisionGridLookUpEdit"
        Me.DivisionGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DivisionGridLookUpEdit.Properties.DataSource = Me.DivisionBindingSource
        Me.DivisionGridLookUpEdit.Properties.DisplayMember = "DivisionName"
        Me.DivisionGridLookUpEdit.Properties.ImmediatePopup = True
        Me.DivisionGridLookUpEdit.Properties.NullText = "[Select Division]"
        Me.DivisionGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.DivisionGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DivisionGridLookUpEdit.Properties.ValueMember = "DivisionId"
        Me.DivisionGridLookUpEdit.Properties.View = Me.GridView9
        Me.DivisionGridLookUpEdit.Size = New System.Drawing.Size(118, 20)
        Me.DivisionGridLookUpEdit.TabIndex = 76
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
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDivisionName})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'colDivisionName
        '
        Me.colDivisionName.FieldName = "DivisionName"
        Me.colDivisionName.Name = "colDivisionName"
        Me.colDivisionName.Visible = True
        Me.colDivisionName.VisibleIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1098, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RFIDateRadioButton
        '
        Me.RFIDateRadioButton.AutoSize = True
        Me.RFIDateRadioButton.Location = New System.Drawing.Point(7, 22)
        Me.RFIDateRadioButton.Name = "RFIDateRadioButton"
        Me.RFIDateRadioButton.Size = New System.Drawing.Size(83, 17)
        Me.RFIDateRadioButton.TabIndex = 66
        Me.RFIDateRadioButton.Text = "By RFI Date"
        Me.RFIDateRadioButton.UseVisualStyleBackColor = True
        '
        'ExFactoryDateRadioButton
        '
        Me.ExFactoryDateRadioButton.AutoSize = True
        Me.ExFactoryDateRadioButton.Location = New System.Drawing.Point(96, 23)
        Me.ExFactoryDateRadioButton.Name = "ExFactoryDateRadioButton"
        Me.ExFactoryDateRadioButton.Size = New System.Drawing.Size(116, 17)
        Me.ExFactoryDateRadioButton.TabIndex = 67
        Me.ExFactoryDateRadioButton.Text = "By Ex Factory Date"
        Me.ExFactoryDateRadioButton.UseVisualStyleBackColor = True
        '
        'CreatedDateRadioButton
        '
        Me.CreatedDateRadioButton.AutoSize = True
        Me.CreatedDateRadioButton.Checked = True
        Me.CreatedDateRadioButton.Location = New System.Drawing.Point(348, 24)
        Me.CreatedDateRadioButton.Name = "CreatedDateRadioButton"
        Me.CreatedDateRadioButton.Size = New System.Drawing.Size(103, 17)
        Me.CreatedDateRadioButton.TabIndex = 68
        Me.CreatedDateRadioButton.TabStop = True
        Me.CreatedDateRadioButton.Text = "By Created Date"
        Me.CreatedDateRadioButton.UseVisualStyleBackColor = True
        '
        'StyleTypeMstTableAdapter
        '
        Me.StyleTypeMstTableAdapter.ClearBeforeFill = True
        '
        'DivisionTableAdapter
        '
        Me.DivisionTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShipmentDateRadioButton)
        Me.GroupBox1.Controls.Add(Me.ShowByFirstExDateButton)
        Me.GroupBox1.Controls.Add(Me.CreatedDateRadioButton)
        Me.GroupBox1.Controls.Add(Me.ExFactoryDateRadioButton)
        Me.GroupBox1.Controls.Add(Me.RFIDateRadioButton)
        Me.GroupBox1.Controls.Add(Me.ToProgramDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.FromProgramDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 52)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        '
        'ShipmentDateRadioButton
        '
        Me.ShipmentDateRadioButton.AutoSize = True
        Me.ShipmentDateRadioButton.Location = New System.Drawing.Point(226, 24)
        Me.ShipmentDateRadioButton.Name = "ShipmentDateRadioButton"
        Me.ShipmentDateRadioButton.Size = New System.Drawing.Size(102, 17)
        Me.ShipmentDateRadioButton.TabIndex = 74
        Me.ShipmentDateRadioButton.Text = "By Shipout Date"
        Me.ShipmentDateRadioButton.UseVisualStyleBackColor = True
        '
        'ByMerchComboBox
        '
        Me.ByMerchComboBox.FormattingEnabled = True
        Me.ByMerchComboBox.Items.AddRange(New Object() {"By NFL Merchandiser", "By FAC Merchandiser"})
        Me.ByMerchComboBox.Location = New System.Drawing.Point(794, 63)
        Me.ByMerchComboBox.Name = "ByMerchComboBox"
        Me.ByMerchComboBox.Size = New System.Drawing.Size(162, 21)
        Me.ByMerchComboBox.TabIndex = 78
        Me.ByMerchComboBox.Text = "By NFL Merchandiser"
        '
        'RunningAllRadioButton
        '
        Me.RunningAllRadioButton.AutoSize = True
        Me.RunningAllRadioButton.Location = New System.Drawing.Point(907, 27)
        Me.RunningAllRadioButton.Name = "RunningAllRadioButton"
        Me.RunningAllRadioButton.Size = New System.Drawing.Size(79, 17)
        Me.RunningAllRadioButton.TabIndex = 75
        Me.RunningAllRadioButton.Text = "Running All"
        Me.RunningAllRadioButton.UseVisualStyleBackColor = True
        '
        'ShipoutRadioButton
        '
        Me.ShipoutRadioButton.AutoSize = True
        Me.ShipoutRadioButton.Location = New System.Drawing.Point(826, 6)
        Me.ShipoutRadioButton.Name = "ShipoutRadioButton"
        Me.ShipoutRadioButton.Size = New System.Drawing.Size(61, 17)
        Me.ShipoutRadioButton.TabIndex = 75
        Me.ShipoutRadioButton.Text = "Shipout"
        Me.ShipoutRadioButton.UseVisualStyleBackColor = True
        '
        'UserLookupTableAdapter
        '
        Me.UserLookupTableAdapter.ClearBeforeFill = True
        '
        'RunningRadioButton
        '
        Me.RunningRadioButton.AutoSize = True
        Me.RunningRadioButton.Location = New System.Drawing.Point(907, 6)
        Me.RunningRadioButton.Name = "RunningRadioButton"
        Me.RunningRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.RunningRadioButton.TabIndex = 75
        Me.RunningRadioButton.Text = "Running"
        Me.RunningRadioButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DivisionGridLookUpEdit)
        Me.Panel1.Controls.Add(Me.StyleTypeGridLookUpEdit)
        Me.Panel1.Controls.Add(Me.SeasonGridLookUpEdit)
        Me.Panel1.Controls.Add(Me.ShipoutRadioButton)
        Me.Panel1.Controls.Add(Me.RunningRadioButton)
        Me.Panel1.Controls.Add(Me.RunningAllRadioButton)
        Me.Panel1.Controls.Add(Me.DivisionRadioButton)
        Me.Panel1.Controls.Add(Me.StyleTypeRadioButton)
        Me.Panel1.Controls.Add(Me.SeasonRadioButton)
        Me.Panel1.Controls.Add(Me.ColorRadioButton)
        Me.Panel1.Controls.Add(Me.BrandRadioButton)
        Me.Panel1.Controls.Add(Me.StyleRadioButton)
        Me.Panel1.Controls.Add(Me.BuyerRadioButton)
        Me.Panel1.Controls.Add(Me.ColorGridLookUpEdit)
        Me.Panel1.Controls.Add(Me.BrandGridLookUpEdit)
        Me.Panel1.Controls.Add(Me.StyleIdGridLookUpEdit)
        Me.Panel1.Controls.Add(Me.BuyerIdGridLookUpEdit)
        Me.Panel1.Location = New System.Drawing.Point(12, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(997, 50)
        Me.Panel1.TabIndex = 79
        '
        'DateBuyerRunningButton
        '
        Me.DateBuyerRunningButton.Enabled = False
        Me.DateBuyerRunningButton.Location = New System.Drawing.Point(1098, 99)
        Me.DateBuyerRunningButton.Name = "DateBuyerRunningButton"
        Me.DateBuyerRunningButton.Size = New System.Drawing.Size(88, 50)
        Me.DateBuyerRunningButton.TabIndex = 54
        Me.DateBuyerRunningButton.Text = "Show by (Date + Buyer + Running)"
        Me.DateBuyerRunningButton.UseVisualStyleBackColor = True
        '
        'frmMasterOrderPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 535)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ByMerchComboBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.UserGridLookUpEdit)
        Me.Controls.Add(Me.ProgrmaShowButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.MasterOrderLookUpEdit)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateBuyerRunningButton)
        Me.Controls.Add(Me.btnProgramDate)
        Me.Name = "frmMasterOrderPrint"
        Me.Text = "Master Order Print"
        CType(Me.MasterOrderLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterOrderLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricColorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDetailsProgramLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDetailsProgramLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MasterOrderLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MasterOrderLookUpDataSet As KSoft_Apparel.MasterOrderLookUpDataSet
    Friend WithEvents MasterOrderLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterOrderLookUpTableAdapter As KSoft_Apparel.MasterOrderLookUpDataSetTableAdapters.MasterOrderLookUpTableAdapter
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnProgramDate As System.Windows.Forms.Button
    Friend WithEvents ToProgramDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FromProgramDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents colDepartment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents StyleIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents BuyerIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents StyleLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleLookupTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleLookupTableAdapter
    Friend WithEvents BrandGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColorGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricColorDataSet As KSoft_Apparel.FabricColorDataSet
    Friend WithEvents FabricColorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricColorTableAdapter As KSoft_Apparel.FabricColorDataSetTableAdapters.FabricColorTableAdapter
    Friend WithEvents colFabricColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BuyerRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StyleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BrandRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ColorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MasterDetailsProgramLookUpDataSet As KSoft_Apparel.MasterDetailsProgramLookUpDataSet
    Friend WithEvents MasterDetailsProgramLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterDetailsProgramLookUpTableAdapter As KSoft_Apparel.MasterDetailsProgramLookUpDataSetTableAdapters.MasterDetailsProgramLookUpTableAdapter
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgrmaShowButton As System.Windows.Forms.Button
    Friend WithEvents GMTBrandDataSet As KSoft_Apparel.GMTBrandDataSet
    Friend WithEvents GMTBrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GMTBrandTableAdapter As KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter
    Friend WithEvents colGMTBrandName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowByFirstExDateButton As System.Windows.Forms.Button
    Friend WithEvents SeasonRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SeasonDataSet As KSoft_Apparel.SeasonDataSet
    Friend WithEvents SeasonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeasonTableAdapter As KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter
    Friend WithEvents SeasonGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeasonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleTypeRadioButton As RadioButton
    Friend WithEvents StyleTypeGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DivisionRadioButton As RadioButton
    Friend WithEvents DivisionGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button1 As Button
    Friend WithEvents RFIDateRadioButton As RadioButton
    Friend WithEvents ExFactoryDateRadioButton As RadioButton
    Friend WithEvents CreatedDateRadioButton As RadioButton
    Friend WithEvents StyleTypeDataSet As StyleTypeDataSet
    Friend WithEvents StyleTypeMstBindingSource As BindingSource
    Friend WithEvents StyleTypeMstTableAdapter As StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter
    Friend WithEvents DivisionDataSet As DivisionDataSet
    Friend WithEvents DivisionBindingSource As BindingSource
    Friend WithEvents DivisionTableAdapter As DivisionDataSetTableAdapters.DivisionTableAdapter
    Friend WithEvents colDivisionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ByMerchComboBox As ComboBox
    Friend WithEvents UserLookupDataSet As UserLookupDataSet
    Friend WithEvents UserLookupBindingSource As BindingSource
    Friend WithEvents UserLookupTableAdapter As UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RunningAllRadioButton As RadioButton
    Friend WithEvents ShipoutRadioButton As RadioButton
    Friend WithEvents ShipmentDateRadioButton As RadioButton
    Friend WithEvents RunningRadioButton As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateBuyerRunningButton As Button
End Class
