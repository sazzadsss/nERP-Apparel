<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSampleRequestStatus
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RequestGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SampleRequestNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestLookupDataSet = New KSoft_Apparel.SampleRequestLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequestNoAndStyleNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequestDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDefaultTarget = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StyleButton = New System.Windows.Forms.Button()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BuyerButton = New System.Windows.Forms.Button()
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AllCompleteButton = New System.Windows.Forms.Button()
        Me.StyleTypeMstTableAdapter = New KSoft_Apparel.StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter()
        Me.StyleTypeDataSet = New KSoft_Apparel.StyleTypeDataSet()
        Me.StyleTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupTableAdapter = New KSoft_Apparel.UserLookupDataSetTableAdapters.UserLookupTableAdapter()
        Me.UserLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserLookupDataSet = New KSoft_Apparel.UserLookupDataSet()
        Me.UserGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUSER_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleTypeButton = New System.Windows.Forms.Button()
        Me.StyleTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.MerchandiserButton = New System.Windows.Forms.Button()
        Me.DevTypeDataSet = New KSoft_Apparel.DevTypeDataSet()
        Me.DevTypeMstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DevTypeMstTableAdapter = New KSoft_Apparel.DevTypeDataSetTableAdapters.DevTypeMstTableAdapter()
        Me.DevTypeIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DevTypeIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDevType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SampleTypeButton = New System.Windows.Forms.Button()
        Me.DivisionTableAdapter = New KSoft_Apparel.DivisionDataSetTableAdapters.DivisionTableAdapter()
        Me.DivisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DivisionDataSet = New KSoft_Apparel.DivisionDataSet()
        Me.DivisionIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DivisionIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDivisionName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DivisionButton = New System.Windows.Forms.Button()
        Me.GMTBrandDataSet = New KSoft_Apparel.GMTBrandDataSet()
        Me.GMTBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GMTBrandTableAdapter = New KSoft_Apparel.GMTBrandDataSetTableAdapters.GMTBrandTableAdapter()
        Me.GMTBrandIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GMTBrandIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGMTBrandName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeasonDataSet = New KSoft_Apparel.SeasonDataSet()
        Me.SeasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeasonTableAdapter = New KSoft_Apparel.SeasonDataSetTableAdapters.SeasonTableAdapter()
        Me.SeasonGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeasonName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SeasonButton = New System.Windows.Forms.Button()
        Me.BrandButton = New System.Windows.Forms.Button()
        Me.SampleRequestNoLookupTableAdapter = New KSoft_Apparel.SampleRequestLookupDataSetTableAdapters.SampleRequestNoLookupTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BuyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.BrandCheckBox = New System.Windows.Forms.CheckBox()
        Me.DivisionCheckBox = New System.Windows.Forms.CheckBox()
        Me.SeasonCheckBox = New System.Windows.Forms.CheckBox()
        Me.StyleNoCheckBox = New System.Windows.Forms.CheckBox()
        Me.StyleTypeCheckBox = New System.Windows.Forms.CheckBox()
        Me.SampleTypeCheckBox = New System.Windows.Forms.CheckBox()
        Me.MerchandiserCheckBox = New System.Windows.Forms.CheckBox()
        Me.ShowAllRunningButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.RequestGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GMTBrandIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeasonGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 108)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1288, 425)
        Me.CrystalReportViewer1.TabIndex = 67
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(20, 10, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Sample Program No:"
        '
        'RequestGridLookUpEdit
        '
        Me.RequestGridLookUpEdit.Location = New System.Drawing.Point(9, 39)
        Me.RequestGridLookUpEdit.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.RequestGridLookUpEdit.Name = "RequestGridLookUpEdit"
        Me.RequestGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequestGridLookUpEdit.Properties.DataSource = Me.SampleRequestNoLookupBindingSource
        Me.RequestGridLookUpEdit.Properties.DisplayMember = "RequestNoAndStyleNo"
        Me.RequestGridLookUpEdit.Properties.ImmediatePopup = True
        Me.RequestGridLookUpEdit.Properties.NullText = ""
        Me.RequestGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.RequestGridLookUpEdit.Properties.PopupView = Me.GridView2
        Me.RequestGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RequestGridLookUpEdit.Properties.ValueMember = "SampleRequestId"
        Me.RequestGridLookUpEdit.Size = New System.Drawing.Size(182, 20)
        Me.RequestGridLookUpEdit.TabIndex = 70
        Me.RequestGridLookUpEdit.Tag = "NR"
        '
        'SampleRequestNoLookupBindingSource
        '
        Me.SampleRequestNoLookupBindingSource.DataMember = "SampleRequestNoLookup"
        Me.SampleRequestNoLookupBindingSource.DataSource = Me.SampleRequestLookupDataSet
        '
        'SampleRequestLookupDataSet
        '
        Me.SampleRequestLookupDataSet.DataSetName = "SampleRequestLookupDataSet"
        Me.SampleRequestLookupDataSet.EnforceConstraints = False
        Me.SampleRequestLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequestNoAndStyleNo, Me.colRequestDate})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colRequestNoAndStyleNo
        '
        Me.colRequestNoAndStyleNo.FieldName = "RequestNoAndStyleNo"
        Me.colRequestNoAndStyleNo.Name = "colRequestNoAndStyleNo"
        Me.colRequestNoAndStyleNo.Visible = True
        Me.colRequestNoAndStyleNo.VisibleIndex = 0
        '
        'colRequestDate
        '
        Me.colRequestDate.FieldName = "RequestDate"
        Me.colRequestDate.Name = "colRequestDate"
        Me.colRequestDate.Visible = True
        Me.colRequestDate.VisibleIndex = 1
        '
        'StyleGridLookUpEdit
        '
        Me.StyleGridLookUpEdit.Location = New System.Drawing.Point(1092, 7)
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
        Me.StyleGridLookUpEdit.Size = New System.Drawing.Size(113, 20)
        Me.StyleGridLookUpEdit.TabIndex = 71
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(197, 6)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 82)
        Me.Button2.TabIndex = 68
        Me.Button2.Tag = "NR"
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StyleButton
        '
        Me.StyleButton.Location = New System.Drawing.Point(1008, 217)
        Me.StyleButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.StyleButton.Name = "StyleButton"
        Me.StyleButton.Size = New System.Drawing.Size(42, 22)
        Me.StyleButton.TabIndex = 73
        Me.StyleButton.Tag = "NR"
        Me.StyleButton.Text = "Show"
        Me.StyleButton.UseVisualStyleBackColor = True
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.Location = New System.Drawing.Point(867, 8)
        Me.BuyerGridLookUpEdit.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerGridLookUpEdit.Properties.NullText = ""
        Me.BuyerGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerGridLookUpEdit.Properties.PopupView = Me.GridView1
        Me.BuyerGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerGridLookUpEdit.Size = New System.Drawing.Size(124, 20)
        Me.BuyerGridLookUpEdit.TabIndex = 74
        Me.BuyerGridLookUpEdit.Tag = "NR"
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
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerId, Me.colBuyerCode, Me.colBuyerName})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colBuyerId
        '
        Me.colBuyerId.FieldName = "BuyerId"
        Me.colBuyerId.Name = "colBuyerId"
        Me.colBuyerId.OptionsColumn.ReadOnly = True
        '
        'colBuyerCode
        '
        Me.colBuyerCode.FieldName = "BuyerCode"
        Me.colBuyerCode.Name = "colBuyerCode"
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 0
        '
        'BuyerButton
        '
        Me.BuyerButton.Location = New System.Drawing.Point(1210, 4)
        Me.BuyerButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.BuyerButton.Name = "BuyerButton"
        Me.BuyerButton.Size = New System.Drawing.Size(79, 98)
        Me.BuyerButton.TabIndex = 75
        Me.BuyerButton.Tag = "NR"
        Me.BuyerButton.Text = "Show  Multiple Filter"
        Me.BuyerButton.UseVisualStyleBackColor = True
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(262, 24)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(149, 20)
        Me.FromDateTimePicker.TabIndex = 77
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(262, 66)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(149, 20)
        Me.ToDateTimePicker.TabIndex = 78
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(259, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Date From :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "To :"
        '
        'AllCompleteButton
        '
        Me.AllCompleteButton.Location = New System.Drawing.Point(516, 11)
        Me.AllCompleteButton.Name = "AllCompleteButton"
        Me.AllCompleteButton.Size = New System.Drawing.Size(111, 80)
        Me.AllCompleteButton.TabIndex = 86
        Me.AllCompleteButton.Text = "&Show Close Sample [Complete Date]"
        Me.AllCompleteButton.UseVisualStyleBackColor = True
        '
        'StyleTypeMstTableAdapter
        '
        Me.StyleTypeMstTableAdapter.ClearBeforeFill = True
        '
        'StyleTypeDataSet
        '
        Me.StyleTypeDataSet.DataSetName = "StyleTypeDataSet"
        Me.StyleTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleTypeMstBindingSource
        '
        Me.StyleTypeMstBindingSource.DataMember = "StyleTypeMst"
        Me.StyleTypeMstBindingSource.DataSource = Me.StyleTypeDataSet
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
        Me.UserGridLookUpEdit.Location = New System.Drawing.Point(1092, 81)
        Me.UserGridLookUpEdit.Name = "UserGridLookUpEdit"
        Me.UserGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserGridLookUpEdit.Properties.DataSource = Me.UserLookupBindingSource
        Me.UserGridLookUpEdit.Properties.DisplayMember = "USER_NAME"
        Me.UserGridLookUpEdit.Properties.ImmediatePopup = True
        Me.UserGridLookUpEdit.Properties.NullText = ""
        Me.UserGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.UserGridLookUpEdit.Properties.PopupView = Me.GridView7
        Me.UserGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UserGridLookUpEdit.Properties.ValueMember = "USER_ID"
        Me.UserGridLookUpEdit.Size = New System.Drawing.Size(113, 20)
        Me.UserGridLookUpEdit.TabIndex = 88
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
        'StyleTypeButton
        '
        Me.StyleTypeButton.Location = New System.Drawing.Point(1056, 218)
        Me.StyleTypeButton.Name = "StyleTypeButton"
        Me.StyleTypeButton.Size = New System.Drawing.Size(45, 23)
        Me.StyleTypeButton.TabIndex = 87
        Me.StyleTypeButton.Text = "Show"
        Me.StyleTypeButton.UseVisualStyleBackColor = True
        '
        'StyleTypeComboBox
        '
        Me.StyleTypeComboBox.DataSource = Me.StyleTypeMstBindingSource
        Me.StyleTypeComboBox.DisplayMember = "StyleType"
        Me.StyleTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StyleTypeComboBox.FormattingEnabled = True
        Me.StyleTypeComboBox.Location = New System.Drawing.Point(1092, 32)
        Me.StyleTypeComboBox.Name = "StyleTypeComboBox"
        Me.StyleTypeComboBox.Size = New System.Drawing.Size(112, 21)
        Me.StyleTypeComboBox.TabIndex = 90
        Me.StyleTypeComboBox.ValueMember = "StyleType"
        '
        'MerchandiserButton
        '
        Me.MerchandiserButton.Location = New System.Drawing.Point(1158, 217)
        Me.MerchandiserButton.Name = "MerchandiserButton"
        Me.MerchandiserButton.Size = New System.Drawing.Size(45, 23)
        Me.MerchandiserButton.TabIndex = 87
        Me.MerchandiserButton.Text = "Show"
        Me.MerchandiserButton.UseVisualStyleBackColor = True
        '
        'DevTypeDataSet
        '
        Me.DevTypeDataSet.DataSetName = "DevTypeDataSet"
        Me.DevTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DevTypeMstBindingSource
        '
        Me.DevTypeMstBindingSource.DataMember = "DevTypeMst"
        Me.DevTypeMstBindingSource.DataSource = Me.DevTypeDataSet
        '
        'DevTypeMstTableAdapter
        '
        Me.DevTypeMstTableAdapter.ClearBeforeFill = True
        '
        'DevTypeIdGridLookUpEdit
        '
        Me.DevTypeIdGridLookUpEdit.Location = New System.Drawing.Point(1092, 57)
        Me.DevTypeIdGridLookUpEdit.Name = "DevTypeIdGridLookUpEdit"
        Me.DevTypeIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DevTypeIdGridLookUpEdit.Properties.DataSource = Me.DevTypeMstBindingSource
        Me.DevTypeIdGridLookUpEdit.Properties.DisplayMember = "DevType"
        Me.DevTypeIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.DevTypeIdGridLookUpEdit.Properties.NullText = ""
        Me.DevTypeIdGridLookUpEdit.Properties.PopupView = Me.DevTypeIdGridLookUpEditView
        Me.DevTypeIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DevTypeIdGridLookUpEdit.Properties.ValueMember = "DevTypeId"
        Me.DevTypeIdGridLookUpEdit.Size = New System.Drawing.Size(112, 20)
        Me.DevTypeIdGridLookUpEdit.TabIndex = 91
        '
        'DevTypeIdGridLookUpEditView
        '
        Me.DevTypeIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDevType})
        Me.DevTypeIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.DevTypeIdGridLookUpEditView.Name = "DevTypeIdGridLookUpEditView"
        Me.DevTypeIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DevTypeIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDevType
        '
        Me.colDevType.FieldName = "DevType"
        Me.colDevType.Name = "colDevType"
        Me.colDevType.Visible = True
        Me.colDevType.VisibleIndex = 0
        '
        'SampleTypeButton
        '
        Me.SampleTypeButton.Location = New System.Drawing.Point(1107, 216)
        Me.SampleTypeButton.Name = "SampleTypeButton"
        Me.SampleTypeButton.Size = New System.Drawing.Size(45, 23)
        Me.SampleTypeButton.TabIndex = 93
        Me.SampleTypeButton.Text = "Show"
        Me.SampleTypeButton.UseVisualStyleBackColor = True
        '
        'DivisionTableAdapter
        '
        Me.DivisionTableAdapter.ClearBeforeFill = True
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
        'DivisionIdGridLookUpEdit
        '
        Me.DivisionIdGridLookUpEdit.Location = New System.Drawing.Point(867, 58)
        Me.DivisionIdGridLookUpEdit.Name = "DivisionIdGridLookUpEdit"
        Me.DivisionIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DivisionIdGridLookUpEdit.Properties.DataSource = Me.DivisionBindingSource
        Me.DivisionIdGridLookUpEdit.Properties.DisplayMember = "DivisionName"
        Me.DivisionIdGridLookUpEdit.Properties.NullText = ""
        Me.DivisionIdGridLookUpEdit.Properties.PopupView = Me.DivisionIdGridLookUpEditView
        Me.DivisionIdGridLookUpEdit.Properties.ValueMember = "DivisionId"
        Me.DivisionIdGridLookUpEdit.Size = New System.Drawing.Size(124, 20)
        Me.DivisionIdGridLookUpEdit.TabIndex = 94
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
        'DivisionButton
        '
        Me.DivisionButton.Location = New System.Drawing.Point(906, 218)
        Me.DivisionButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.DivisionButton.Name = "DivisionButton"
        Me.DivisionButton.Size = New System.Drawing.Size(45, 22)
        Me.DivisionButton.TabIndex = 96
        Me.DivisionButton.Tag = "NR"
        Me.DivisionButton.Text = "Show"
        Me.DivisionButton.UseVisualStyleBackColor = True
        '
        'GMTBrandDataSet
        '
        Me.GMTBrandDataSet.DataSetName = "GMTBrandDataSet"
        Me.GMTBrandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GMTBrandBindingSource
        '
        Me.GMTBrandBindingSource.DataMember = "GMTBrand"
        Me.GMTBrandBindingSource.DataSource = Me.GMTBrandDataSet
        '
        'GMTBrandTableAdapter
        '
        Me.GMTBrandTableAdapter.ClearBeforeFill = True
        '
        'GMTBrandIdGridLookUpEdit
        '
        Me.GMTBrandIdGridLookUpEdit.Location = New System.Drawing.Point(867, 33)
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
        Me.GMTBrandIdGridLookUpEdit.TabIndex = 98
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
        Me.SeasonGridLookUpEdit.EditValue = ""
        Me.SeasonGridLookUpEdit.Location = New System.Drawing.Point(867, 81)
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
        Me.SeasonGridLookUpEdit.TabIndex = 101
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
        'SeasonButton
        '
        Me.SeasonButton.Location = New System.Drawing.Point(957, 217)
        Me.SeasonButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.SeasonButton.Name = "SeasonButton"
        Me.SeasonButton.Size = New System.Drawing.Size(45, 22)
        Me.SeasonButton.TabIndex = 102
        Me.SeasonButton.Tag = "NR"
        Me.SeasonButton.Text = "Show"
        Me.SeasonButton.UseVisualStyleBackColor = True
        '
        'BrandButton
        '
        Me.BrandButton.Location = New System.Drawing.Point(855, 217)
        Me.BrandButton.Name = "BrandButton"
        Me.BrandButton.Size = New System.Drawing.Size(45, 23)
        Me.BrandButton.TabIndex = 103
        Me.BrandButton.Text = "Show"
        Me.BrandButton.UseVisualStyleBackColor = True
        '
        'SampleRequestNoLookupTableAdapter
        '
        Me.SampleRequestNoLookupTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(421, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 80)
        Me.Button1.TabIndex = 75
        Me.Button1.Tag = "NR"
        Me.Button1.Text = "Show Running [Request Date]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BuyerCheckBox
        '
        Me.BuyerCheckBox.AutoSize = True
        Me.BuyerCheckBox.Location = New System.Drawing.Point(804, 8)
        Me.BuyerCheckBox.Name = "BuyerCheckBox"
        Me.BuyerCheckBox.Size = New System.Drawing.Size(53, 17)
        Me.BuyerCheckBox.TabIndex = 104
        Me.BuyerCheckBox.Text = "Buyer"
        Me.BuyerCheckBox.UseVisualStyleBackColor = True
        '
        'BrandCheckBox
        '
        Me.BrandCheckBox.AutoSize = True
        Me.BrandCheckBox.Location = New System.Drawing.Point(803, 33)
        Me.BrandCheckBox.Name = "BrandCheckBox"
        Me.BrandCheckBox.Size = New System.Drawing.Size(54, 17)
        Me.BrandCheckBox.TabIndex = 104
        Me.BrandCheckBox.Text = "Brand"
        Me.BrandCheckBox.UseVisualStyleBackColor = True
        '
        'DivisionCheckBox
        '
        Me.DivisionCheckBox.AutoSize = True
        Me.DivisionCheckBox.Location = New System.Drawing.Point(803, 58)
        Me.DivisionCheckBox.Name = "DivisionCheckBox"
        Me.DivisionCheckBox.Size = New System.Drawing.Size(63, 17)
        Me.DivisionCheckBox.TabIndex = 104
        Me.DivisionCheckBox.Text = "Division"
        Me.DivisionCheckBox.UseVisualStyleBackColor = True
        '
        'SeasonCheckBox
        '
        Me.SeasonCheckBox.AutoSize = True
        Me.SeasonCheckBox.Location = New System.Drawing.Point(803, 85)
        Me.SeasonCheckBox.Name = "SeasonCheckBox"
        Me.SeasonCheckBox.Size = New System.Drawing.Size(62, 17)
        Me.SeasonCheckBox.TabIndex = 104
        Me.SeasonCheckBox.Text = "Season"
        Me.SeasonCheckBox.UseVisualStyleBackColor = True
        '
        'StyleNoCheckBox
        '
        Me.StyleNoCheckBox.AutoSize = True
        Me.StyleNoCheckBox.Location = New System.Drawing.Point(997, 11)
        Me.StyleNoCheckBox.Name = "StyleNoCheckBox"
        Me.StyleNoCheckBox.Size = New System.Drawing.Size(66, 17)
        Me.StyleNoCheckBox.TabIndex = 104
        Me.StyleNoCheckBox.Text = "Style No"
        Me.StyleNoCheckBox.UseVisualStyleBackColor = True
        '
        'StyleTypeCheckBox
        '
        Me.StyleTypeCheckBox.AutoSize = True
        Me.StyleTypeCheckBox.Location = New System.Drawing.Point(997, 36)
        Me.StyleTypeCheckBox.Name = "StyleTypeCheckBox"
        Me.StyleTypeCheckBox.Size = New System.Drawing.Size(76, 17)
        Me.StyleTypeCheckBox.TabIndex = 104
        Me.StyleTypeCheckBox.Text = "Style Type"
        Me.StyleTypeCheckBox.UseVisualStyleBackColor = True
        '
        'SampleTypeCheckBox
        '
        Me.SampleTypeCheckBox.AutoSize = True
        Me.SampleTypeCheckBox.Location = New System.Drawing.Point(997, 61)
        Me.SampleTypeCheckBox.Name = "SampleTypeCheckBox"
        Me.SampleTypeCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.SampleTypeCheckBox.TabIndex = 104
        Me.SampleTypeCheckBox.Text = "Sample Type"
        Me.SampleTypeCheckBox.UseVisualStyleBackColor = True
        '
        'MerchandiserCheckBox
        '
        Me.MerchandiserCheckBox.AutoSize = True
        Me.MerchandiserCheckBox.Location = New System.Drawing.Point(997, 82)
        Me.MerchandiserCheckBox.Name = "MerchandiserCheckBox"
        Me.MerchandiserCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.MerchandiserCheckBox.TabIndex = 104
        Me.MerchandiserCheckBox.Text = "Merchandiser"
        Me.MerchandiserCheckBox.UseVisualStyleBackColor = True
        '
        'ShowAllRunningButton
        '
        Me.ShowAllRunningButton.Location = New System.Drawing.Point(633, 11)
        Me.ShowAllRunningButton.Name = "ShowAllRunningButton"
        Me.ShowAllRunningButton.Size = New System.Drawing.Size(94, 80)
        Me.ShowAllRunningButton.TabIndex = 66
        Me.ShowAllRunningButton.Text = "Show Running All"
        Me.ShowAllRunningButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(733, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 80)
        Me.Button3.TabIndex = 105
        Me.Button3.Text = "Show Running All Summery"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmSampleRequestStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 533)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MerchandiserCheckBox)
        Me.Controls.Add(Me.SeasonCheckBox)
        Me.Controls.Add(Me.SampleTypeCheckBox)
        Me.Controls.Add(Me.DivisionCheckBox)
        Me.Controls.Add(Me.StyleTypeCheckBox)
        Me.Controls.Add(Me.BrandCheckBox)
        Me.Controls.Add(Me.StyleNoCheckBox)
        Me.Controls.Add(Me.BuyerCheckBox)
        Me.Controls.Add(Me.SeasonGridLookUpEdit)
        Me.Controls.Add(Me.GMTBrandIdGridLookUpEdit)
        Me.Controls.Add(Me.DivisionIdGridLookUpEdit)
        Me.Controls.Add(Me.DevTypeIdGridLookUpEdit)
        Me.Controls.Add(Me.StyleTypeComboBox)
        Me.Controls.Add(Me.UserGridLookUpEdit)
        Me.Controls.Add(Me.AllCompleteButton)
        Me.Controls.Add(Me.FromDateTimePicker)
        Me.Controls.Add(Me.ToDateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BuyerButton)
        Me.Controls.Add(Me.BuyerGridLookUpEdit)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RequestGridLookUpEdit)
        Me.Controls.Add(Me.StyleGridLookUpEdit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ShowAllRunningButton)
        Me.Controls.Add(Me.BrandButton)
        Me.Controls.Add(Me.SeasonButton)
        Me.Controls.Add(Me.DivisionButton)
        Me.Controls.Add(Me.SampleTypeButton)
        Me.Controls.Add(Me.MerchandiserButton)
        Me.Controls.Add(Me.StyleTypeButton)
        Me.Controls.Add(Me.StyleButton)
        Me.Name = "frmSampleRequestStatus"
        Me.Text = "Sample Program Status"
        CType(Me.RequestGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeMstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevTypeIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GMTBrandIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeasonGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RequestGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents StyleGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents StyleButton As System.Windows.Forms.Button
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BuyerButton As System.Windows.Forms.Button
    Friend WithEvents BuyerDataSet As KSoft_Apparel.BuyerDataSet
    Friend WithEvents BuyerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyerTableAdapter As KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleLookupDataSet As KSoft_Apparel.StyleLookupDataSet
    Friend WithEvents StyleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StyleTableAdapter As KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultTarget As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AllCompleteButton As System.Windows.Forms.Button
    Friend WithEvents StyleTypeMstTableAdapter As StyleTypeDataSetTableAdapters.StyleTypeMstTableAdapter
    Friend WithEvents StyleTypeDataSet As StyleTypeDataSet
    Friend WithEvents StyleTypeMstBindingSource As BindingSource
    Friend WithEvents UserLookupTableAdapter As UserLookupDataSetTableAdapters.UserLookupTableAdapter
    Friend WithEvents UserLookupBindingSource As BindingSource
    Friend WithEvents UserLookupDataSet As UserLookupDataSet
    Friend WithEvents UserGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUSER_NAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleTypeButton As Button
    Friend WithEvents StyleTypeComboBox As ComboBox
    Friend WithEvents MerchandiserButton As Button
    Friend WithEvents DevTypeDataSet As DevTypeDataSet
    Friend WithEvents DevTypeMstBindingSource As BindingSource
    Friend WithEvents DevTypeMstTableAdapter As DevTypeDataSetTableAdapters.DevTypeMstTableAdapter
    Friend WithEvents DevTypeIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents DevTypeIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SampleTypeButton As Button
    Friend WithEvents DivisionTableAdapter As DivisionDataSetTableAdapters.DivisionTableAdapter
    Friend WithEvents DivisionBindingSource As BindingSource
    Friend WithEvents DivisionDataSet As DivisionDataSet
    Friend WithEvents DivisionIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents DivisionIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDivisionName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DivisionButton As Button
    Friend WithEvents GMTBrandDataSet As GMTBrandDataSet
    Friend WithEvents GMTBrandBindingSource As BindingSource
    Friend WithEvents GMTBrandTableAdapter As GMTBrandDataSetTableAdapters.GMTBrandTableAdapter
    Friend WithEvents GMTBrandIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GMTBrandIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGMTBrandName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeasonDataSet As SeasonDataSet
    Friend WithEvents SeasonBindingSource As BindingSource
    Friend WithEvents SeasonTableAdapter As SeasonDataSetTableAdapters.SeasonTableAdapter
    Friend WithEvents SeasonGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeasonName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SeasonButton As Button
    Friend WithEvents BrandButton As Button
    Friend WithEvents colDevType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SampleRequestLookupDataSet As SampleRequestLookupDataSet
    Friend WithEvents SampleRequestNoLookupBindingSource As BindingSource
    Friend WithEvents SampleRequestNoLookupTableAdapter As SampleRequestLookupDataSetTableAdapters.SampleRequestNoLookupTableAdapter
    Friend WithEvents colRequestNoAndStyleNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequestDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents BuyerCheckBox As CheckBox
    Friend WithEvents BrandCheckBox As CheckBox
    Friend WithEvents DivisionCheckBox As CheckBox
    Friend WithEvents SeasonCheckBox As CheckBox
    Friend WithEvents StyleNoCheckBox As CheckBox
    Friend WithEvents StyleTypeCheckBox As CheckBox
    Friend WithEvents SampleTypeCheckBox As CheckBox
    Friend WithEvents MerchandiserCheckBox As CheckBox
    Friend WithEvents ShowAllRunningButton As Button
    Friend WithEvents Button3 As Button
End Class
