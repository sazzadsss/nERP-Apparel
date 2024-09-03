<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailySewingReport
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SewingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BranchComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchDataSet = New KSoft_Apparel.BranchDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BranchTableAdapter = New KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.ProgramNoGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowbyProgramButton = New System.Windows.Forms.Button()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SewingDateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BuyerDataSet = New KSoft_Apparel.BuyerDataSet()
        Me.BuyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyerTableAdapter = New KSoft_Apparel.BuyerDataSetTableAdapters.BuyerTableAdapter()
        Me.StyleLookupDataSet = New KSoft_Apparel.StyleLookupDataSet()
        Me.StyleTableAdapter = New KSoft_Apparel.StyleLookupDataSetTableAdapters.StyleTableAdapter()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BuyerButton = New System.Windows.Forms.Button()
        Me.BuyerGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBuyerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.StyleButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StyleGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStyleId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerId1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDefaultTarget = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSMV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MultipleProgramTextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.AllBranch = New System.Windows.Forms.Button()
        Me.ShowAllButtong = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OrderPOLookupAllTableAdapter = New KSoft_Apparel.OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter()
        Me.OrderPOLookupAllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderPOLookupNewDataSet = New KSoft_Apparel.OrderPOLookupNewDataSet()
        Me.ShowButton3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPGAndStyleAndPOAndColorAndDes = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 132)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1282, 413)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'SewingDateTimePicker
        '
        Me.SewingDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.SewingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SewingDateTimePicker.Location = New System.Drawing.Point(118, 16)
        Me.SewingDateTimePicker.Name = "SewingDateTimePicker"
        Me.SewingDateTimePicker.Size = New System.Drawing.Size(93, 20)
        Me.SewingDateTimePicker.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sewing Date To :"
        '
        'BranchComboBox
        '
        Me.BranchComboBox.DataSource = Me.BranchBindingSource
        Me.BranchComboBox.DisplayMember = "BranchCode"
        Me.BranchComboBox.FormattingEnabled = True
        Me.BranchComboBox.Location = New System.Drawing.Point(501, 13)
        Me.BranchComboBox.Name = "BranchComboBox"
        Me.BranchComboBox.Size = New System.Drawing.Size(108, 21)
        Me.BranchComboBox.TabIndex = 3
        Me.BranchComboBox.ValueMember = "BranchId"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(454, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Branch:"
        '
        'BranchTableAdapter
        '
        Me.BranchTableAdapter.ClearBeforeFill = True
        '
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.Location = New System.Drawing.Point(615, 12)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(74, 21)
        Me.ShowButton.TabIndex = 5
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'ProgramNoGridLookUpEdit
        '
        Me.ProgramNoGridLookUpEdit.EditValue = ""
        Me.ProgramNoGridLookUpEdit.Location = New System.Drawing.Point(118, 49)
        Me.ProgramNoGridLookUpEdit.Name = "ProgramNoGridLookUpEdit"
        Me.ProgramNoGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramNoGridLookUpEdit.Properties.DataSource = Me.OrderLookupBindingSource
        Me.ProgramNoGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.ProgramNoGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramNoGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramNoGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramNoGridLookUpEdit.Properties.ValueMember = "OrderId"
        Me.ProgramNoGridLookUpEdit.Properties.View = Me.GridLookUpEdit1View
        Me.ProgramNoGridLookUpEdit.Size = New System.Drawing.Size(222, 20)
        Me.ProgramNoGridLookUpEdit.TabIndex = 6
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
        'ShowbyProgramButton
        '
        Me.ShowbyProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowbyProgramButton.Location = New System.Drawing.Point(346, 48)
        Me.ShowbyProgramButton.Name = "ShowbyProgramButton"
        Me.ShowbyProgramButton.Size = New System.Drawing.Size(88, 23)
        Me.ShowbyProgramButton.TabIndex = 7
        Me.ShowbyProgramButton.Text = "Show"
        Me.ShowbyProgramButton.UseVisualStyleBackColor = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(346, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 20)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Show Line Wise"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Program No:"
        '
        'SewingDateTimePicker2
        '
        Me.SewingDateTimePicker2.CustomFormat = "dd-MMM-yy"
        Me.SewingDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SewingDateTimePicker2.Location = New System.Drawing.Point(247, 16)
        Me.SewingDateTimePicker2.Name = "SewingDateTimePicker2"
        Me.SewingDateTimePicker2.Size = New System.Drawing.Size(93, 20)
        Me.SewingDateTimePicker2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(215, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "To :"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(695, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 21)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Target And  Avg"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BuyerDataSet
        '
        Me.BuyerDataSet.DataSetName = "BuyerDataSet"
        Me.BuyerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyerBindingSource
        '
        Me.BuyerBindingSource.DataMember = "Buyer"
        Me.BuyerBindingSource.DataSource = Me.BuyerDataSet
        '
        'BuyerTableAdapter
        '
        Me.BuyerTableAdapter.ClearBeforeFill = True
        '
        'StyleLookupDataSet
        '
        Me.StyleLookupDataSet.DataSetName = "StyleLookupDataSet"
        Me.StyleLookupDataSet.EnforceConstraints = False
        Me.StyleLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.StyleLookupDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(801, 44)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Buyer:"
        '
        'BuyerButton
        '
        Me.BuyerButton.Location = New System.Drawing.Point(1127, 42)
        Me.BuyerButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.BuyerButton.Name = "BuyerButton"
        Me.BuyerButton.Size = New System.Drawing.Size(131, 22)
        Me.BuyerButton.TabIndex = 90
        Me.BuyerButton.Tag = "NR"
        Me.BuyerButton.Text = "Show"
        Me.BuyerButton.UseVisualStyleBackColor = True
        '
        'BuyerGridLookUpEdit
        '
        Me.BuyerGridLookUpEdit.Location = New System.Drawing.Point(842, 43)
        Me.BuyerGridLookUpEdit.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.BuyerGridLookUpEdit.Name = "BuyerGridLookUpEdit"
        Me.BuyerGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BuyerGridLookUpEdit.Properties.DataSource = Me.BuyerBindingSource
        Me.BuyerGridLookUpEdit.Properties.DisplayMember = "BuyerName"
        Me.BuyerGridLookUpEdit.Properties.ImmediatePopup = True
        Me.BuyerGridLookUpEdit.Properties.NullText = ""
        Me.BuyerGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BuyerGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BuyerGridLookUpEdit.Properties.ValueMember = "BuyerId"
        Me.BuyerGridLookUpEdit.Properties.View = Me.GridView1
        Me.BuyerGridLookUpEdit.Size = New System.Drawing.Size(279, 20)
        Me.BuyerGridLookUpEdit.TabIndex = 89
        Me.BuyerGridLookUpEdit.Tag = "NR"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBuyerId, Me.GridColumn1, Me.colBuyerName})
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
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "BuyerCode"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 0
        '
        'StyleButton
        '
        Me.StyleButton.Location = New System.Drawing.Point(695, 44)
        Me.StyleButton.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.StyleButton.Name = "StyleButton"
        Me.StyleButton.Size = New System.Drawing.Size(93, 22)
        Me.StyleButton.TabIndex = 88
        Me.StyleButton.Tag = "NR"
        Me.StyleButton.Text = "Show"
        Me.StyleButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Style No:"
        '
        'StyleGridLookUpEdit
        '
        Me.StyleGridLookUpEdit.Location = New System.Drawing.Point(501, 45)
        Me.StyleGridLookUpEdit.Margin = New System.Windows.Forms.Padding(10, 7, 3, 3)
        Me.StyleGridLookUpEdit.Name = "StyleGridLookUpEdit"
        Me.StyleGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StyleGridLookUpEdit.Properties.DataSource = Me.StyleBindingSource
        Me.StyleGridLookUpEdit.Properties.DisplayMember = "StyleName"
        Me.StyleGridLookUpEdit.Properties.ImmediatePopup = True
        Me.StyleGridLookUpEdit.Properties.NullText = ""
        Me.StyleGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.StyleGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.StyleGridLookUpEdit.Properties.ValueMember = "StyleId"
        Me.StyleGridLookUpEdit.Properties.View = Me.GridView3
        Me.StyleGridLookUpEdit.Size = New System.Drawing.Size(188, 20)
        Me.StyleGridLookUpEdit.TabIndex = 86
        Me.StyleGridLookUpEdit.Tag = "NR"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStyleId, Me.GridColumn2, Me.colBuyerId1, Me.colDefaultTarget, Me.colSMV})
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
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "StyleName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
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
        'MultipleProgramTextBox
        '
        Me.MultipleProgramTextBox.Location = New System.Drawing.Point(842, 14)
        Me.MultipleProgramTextBox.Name = "MultipleProgramTextBox"
        Me.MultipleProgramTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.MultipleProgramTextBox.Size = New System.Drawing.Size(279, 20)
        Me.MultipleProgramTextBox.TabIndex = 85
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(805, 16)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(19, 13)
        Me.LinkLabel1.TabIndex = 84
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = ">>"
        '
        'AllBranch
        '
        Me.AllBranch.Location = New System.Drawing.Point(1127, 13)
        Me.AllBranch.Name = "AllBranch"
        Me.AllBranch.Size = New System.Drawing.Size(132, 22)
        Me.AllBranch.TabIndex = 83
        Me.AllBranch.Text = "Show by Multiple Branch"
        Me.AllBranch.UseVisualStyleBackColor = True
        '
        'ShowAllButtong
        '
        Me.ShowAllButtong.Location = New System.Drawing.Point(346, 14)
        Me.ShowAllButtong.Name = "ShowAllButtong"
        Me.ShowAllButtong.Size = New System.Drawing.Size(88, 29)
        Me.ShowAllButtong.TabIndex = 92
        Me.ShowAllButtong.Text = "Show "
        Me.ShowAllButtong.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(346, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 93
        Me.Button3.Text = "Show Summery"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OrderPOLookupAllTableAdapter
        '
        Me.OrderPOLookupAllTableAdapter.ClearBeforeFill = True
        '
        'OrderPOLookupAllBindingSource
        '
        Me.OrderPOLookupAllBindingSource.DataMember = "OrderPOLookupAll"
        Me.OrderPOLookupAllBindingSource.DataSource = Me.OrderPOLookupNewDataSet
        '
        'OrderPOLookupNewDataSet
        '
        Me.OrderPOLookupNewDataSet.DataSetName = "OrderPOLookupNewDataSet"
        Me.OrderPOLookupNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShowButton3
        '
        Me.ShowButton3.Location = New System.Drawing.Point(346, 104)
        Me.ShowButton3.Name = "ShowButton3"
        Me.ShowButton3.Size = New System.Drawing.Size(88, 23)
        Me.ShowButton3.TabIndex = 96
        Me.ShowButton3.Text = "&Show By PO"
        Me.ShowButton3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(258, 13)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Program :: Style :: PO :: Color :: Destination::EX Date:"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(12, 106)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.OrderPOLookupAllBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "PGAndStyleAndPOAndColorAndDes"
        Me.GridLookUpEdit1.Properties.ImmediatePopup = True
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit1.Properties.ValueMember = "OrderDetailsId"
        Me.GridLookUpEdit1.Properties.View = Me.GridView2
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(326, 20)
        Me.GridLookUpEdit1.TabIndex = 94
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPGAndStyleAndPOAndColorAndDes})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colPGAndStyleAndPOAndColorAndDes
        '
        Me.colPGAndStyleAndPOAndColorAndDes.FieldName = "PGAndStyleAndPOAndColorAndDes"
        Me.colPGAndStyleAndPOAndColorAndDes.Name = "colPGAndStyleAndPOAndColorAndDes"
        Me.colPGAndStyleAndPOAndColorAndDes.OptionsColumn.ReadOnly = True
        Me.colPGAndStyleAndPOAndColorAndDes.Visible = True
        Me.colPGAndStyleAndPOAndColorAndDes.VisibleIndex = 0
        '
        'frmDailySewingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 545)
        Me.Controls.Add(Me.ShowButton3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ShowAllButtong)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BuyerButton)
        Me.Controls.Add(Me.BuyerGridLookUpEdit)
        Me.Controls.Add(Me.StyleButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StyleGridLookUpEdit)
        Me.Controls.Add(Me.MultipleProgramTextBox)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.AllBranch)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SewingDateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShowbyProgramButton)
        Me.Controls.Add(Me.ProgramNoGridLookUpEdit)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BranchComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SewingDateTimePicker)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmDailySewingReport"
        Me.Text = "Daily Sewing Report"
        CType(Me.BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramNoGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyerGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupAllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderPOLookupNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SewingDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BranchComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BranchDataSet As KSoft_Apparel.BranchDataSet
    Friend WithEvents BranchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BranchTableAdapter As KSoft_Apparel.BranchDataSetTableAdapters.BranchTableAdapter
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents ProgramNoGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ShowbyProgramButton As System.Windows.Forms.Button
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SewingDateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BuyerDataSet As BuyerDataSet
    Friend WithEvents BuyerBindingSource As BindingSource
    Friend WithEvents BuyerTableAdapter As BuyerDataSetTableAdapters.BuyerTableAdapter
    Friend WithEvents StyleLookupDataSet As StyleLookupDataSet
    Friend WithEvents StyleTableAdapter As StyleLookupDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents StyleBindingSource As BindingSource
    Friend WithEvents Label5 As Label
    Friend WithEvents BuyerButton As Button
    Friend WithEvents BuyerGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBuyerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents StyleButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents StyleGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStyleId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerId1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultTarget As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSMV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MultipleProgramTextBox As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents AllBranch As Button
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowAllButtong As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OrderPOLookupAllTableAdapter As OrderPOLookupNewDataSetTableAdapters.OrderPOLookupAllTableAdapter
    Friend WithEvents OrderPOLookupAllBindingSource As BindingSource
    Friend WithEvents OrderPOLookupNewDataSet As OrderPOLookupNewDataSet
    Friend WithEvents ShowButton3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPGAndStyleAndPOAndColorAndDes As DevExpress.XtraGrid.Columns.GridColumn
End Class
