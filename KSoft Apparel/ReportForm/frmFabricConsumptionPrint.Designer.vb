<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFabricConsumptionPrint
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
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.SampleFabricBookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleFabricBookingDataSet = New KSoft_Apparel.SampleFabricBookingDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgramGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FabricBOMProgramListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBOMProgramListDataSet = New KSoft_Apparel.FabricBOMProgramListDataSet()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFabricBOMId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FabricBOMProgramListTableAdapter = New KSoft_Apparel.FabricBOMProgramListDataSetTableAdapters.FabricBOMProgramListTableAdapter()
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.OrderLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLookupDataSet = New KSoft_Apparel.OrderLookupDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OrderLookupTableAdapter = New KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.FabricBOMProcceedListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FabricBOMProcceedListDataSet = New KSoft_Apparel.FabricBOMProcceedListDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProceed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricBookingStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProcessDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricReqDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProgramNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShowGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colAmendmentNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMerchandiser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDyeingComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SampleFabricBookingGridControl = New DevExpress.XtraGrid.GridControl()
        Me.SampleFabricBookingProceedListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIsComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSFBStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricBookingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivedDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFabricRequireDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBookingNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colRevisedNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRevisedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMerchandiser1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SampleRequestNoLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SampleRequestDataSet = New KSoft_Apparel.SampleRequestDataSet()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.FabricBOMProcceedListTableAdapter = New KSoft_Apparel.FabricBOMProcceedListDataSetTableAdapters.FabricBOMProcceedListTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ProceedDateButton = New System.Windows.Forms.Button()
        Me.HideButton = New System.Windows.Forms.Button()
        Me.SampleFabricBookingTableAdapter = New KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricBookingTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.TableAdapterManager()
        Me.SampleRequestNoLookupTableAdapter = New KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestNoLookupTableAdapter()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SampleFabricBookingLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetails1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SampleFabricBookingLookup = New KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricBookingLookup()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SampleFabricBookingProceedListTableAdapter = New KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricBookingProceedListTableAdapter()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.SampleFabricBookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMProgramListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMProgramListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMProcceedListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FabricBOMProcceedListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBookingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBookingProceedListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SampleFabricBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(207, 507)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ShowButton
        '
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowButton.Location = New System.Drawing.Point(223, 13)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(71, 20)
        Me.ShowButton.TabIndex = 50
        Me.ShowButton.Text = "&Show"
        Me.ShowButton.UseVisualStyleBackColor = True
        '
        'SampleFabricBookingBindingSource
        '
        Me.SampleFabricBookingBindingSource.DataMember = "SampleFabricBooking"
        Me.SampleFabricBookingBindingSource.DataSource = Me.SampleFabricBookingDataSet
        '
        'SampleFabricBookingDataSet
        '
        Me.SampleFabricBookingDataSet.DataSetName = "SampleFabricBookingDataSet"
        Me.SampleFabricBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(733, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 20)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(455, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Development Program No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Program No"
        '
        'ProgramGridLookUpEdit
        '
        Me.ProgramGridLookUpEdit.Location = New System.Drawing.Point(95, 13)
        Me.ProgramGridLookUpEdit.Name = "ProgramGridLookUpEdit"
        Me.ProgramGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProgramGridLookUpEdit.Properties.DataSource = Me.FabricBOMProgramListBindingSource
        Me.ProgramGridLookUpEdit.Properties.DisplayMember = "ProgramNo"
        Me.ProgramGridLookUpEdit.Properties.ImmediatePopup = True
        Me.ProgramGridLookUpEdit.Properties.NullText = "[Type Program No]"
        Me.ProgramGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ProgramGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProgramGridLookUpEdit.Properties.ValueMember = "FabricBOMId"
        Me.ProgramGridLookUpEdit.Properties.View = Me.GridLookUpEdit2View
        Me.ProgramGridLookUpEdit.Size = New System.Drawing.Size(122, 20)
        Me.ProgramGridLookUpEdit.TabIndex = 55
        '
        'FabricBOMProgramListBindingSource
        '
        Me.FabricBOMProgramListBindingSource.DataMember = "FabricBOMProgramList"
        Me.FabricBOMProgramListBindingSource.DataSource = Me.FabricBOMProgramListDataSet
        '
        'FabricBOMProgramListDataSet
        '
        Me.FabricBOMProgramListDataSet.DataSetName = "FabricBOMProgramListDataSet"
        Me.FabricBOMProgramListDataSet.EnforceConstraints = False
        Me.FabricBOMProgramListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFabricBOMId, Me.colOrderId, Me.colAmendmentNo, Me.colProgramNo})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colFabricBOMId
        '
        Me.colFabricBOMId.FieldName = "FabricBOMId"
        Me.colFabricBOMId.Name = "colFabricBOMId"
        Me.colFabricBOMId.OptionsColumn.ReadOnly = True
        '
        'colOrderId
        '
        Me.colOrderId.FieldName = "OrderId"
        Me.colOrderId.Name = "colOrderId"
        '
        'colAmendmentNo
        '
        Me.colAmendmentNo.FieldName = "AmendmentNo"
        Me.colAmendmentNo.Name = "colAmendmentNo"
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.OptionsColumn.ReadOnly = True
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        '
        'FabricBOMProgramListTableAdapter
        '
        Me.FabricBOMProgramListTableAdapter.ClearBeforeFill = True
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(884, 14)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DataSource = Me.OrderLookupBindingSource
        Me.GridLookUpEdit2.Properties.DisplayMember = "ProgramNo"
        Me.GridLookUpEdit2.Properties.ImmediatePopup = True
        Me.GridLookUpEdit2.Properties.NullText = "[Type Program No]"
        Me.GridLookUpEdit2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.GridLookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.GridLookUpEdit2.Properties.ValueMember = "OrderId"
        Me.GridLookUpEdit2.Properties.View = Me.GridView2
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(122, 20)
        Me.GridLookUpEdit2.TabIndex = 56
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
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(809, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Program No :"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(1012, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 20)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "&Show Marker Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OrderLookupTableAdapter
        '
        Me.OrderLookupTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 14)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Amnd History"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(95, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(122, 21)
        Me.ComboBox1.TabIndex = 60
        '
        'HistoryButton
        '
        Me.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HistoryButton.Location = New System.Drawing.Point(223, 41)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(148, 20)
        Me.HistoryButton.TabIndex = 61
        Me.HistoryButton.Text = "&Show"
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 67)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.CrystalReportViewer1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainerControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1282, 507)
        Me.SplitContainer1.SplitterDistance = 207
        Me.SplitContainer1.TabIndex = 62
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LinkLabel1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LinkLabel2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SampleFabricBookingGridControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1071, 507)
        Me.SplitContainerControl1.SplitterPosition = 206
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(183, 8)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(72, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Export to XLS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Fabric Booking List [Bulk]"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.FabricBOMProcceedListBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(0, 28)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1071, 177)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView4})
        '
        'FabricBOMProcceedListBindingSource
        '
        Me.FabricBOMProcceedListBindingSource.DataMember = "FabricBOMProcceedList"
        Me.FabricBOMProcceedListBindingSource.DataSource = Me.FabricBOMProcceedListDataSet
        '
        'FabricBOMProcceedListDataSet
        '
        Me.FabricBOMProcceedListDataSet.DataSetName = "FabricBOMProcceedListDataSet"
        Me.FabricBOMProcceedListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProceed, Me.colFabricBookingStartDate, Me.colProcessDate, Me.colReceivedDate, Me.colFabricReqDate, Me.colBuyer, Me.colProgramNo2, Me.ShowGridColumn, Me.colAmendmentNo1, Me.colAmendmentDate, Me.colMerchandiser, Me.colDyeingComments})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colProceed
        '
        Me.colProceed.FieldName = "Proceed"
        Me.colProceed.Name = "colProceed"
        Me.colProceed.OptionsColumn.ReadOnly = True
        Me.colProceed.Visible = True
        Me.colProceed.VisibleIndex = 0
        Me.colProceed.Width = 50
        '
        'colFabricBookingStartDate
        '
        Me.colFabricBookingStartDate.DisplayFormat.FormatString = "dd-MMM-yy HH:hh"
        Me.colFabricBookingStartDate.FieldName = "FabricBookingStartDate"
        Me.colFabricBookingStartDate.Name = "colFabricBookingStartDate"
        Me.colFabricBookingStartDate.Visible = True
        Me.colFabricBookingStartDate.VisibleIndex = 1
        Me.colFabricBookingStartDate.Width = 183
        '
        'colProcessDate
        '
        Me.colProcessDate.Caption = "Proceed / Fabric Booking Date"
        Me.colProcessDate.DisplayFormat.FormatString = "dd-MMM-yy HH:hh"
        Me.colProcessDate.FieldName = "ProcessDate"
        Me.colProcessDate.Name = "colProcessDate"
        Me.colProcessDate.OptionsColumn.ReadOnly = True
        Me.colProcessDate.Visible = True
        Me.colProcessDate.VisibleIndex = 2
        Me.colProcessDate.Width = 194
        '
        'colReceivedDate
        '
        Me.colReceivedDate.Caption = "Booking Received Date by Fabric Dept"
        Me.colReceivedDate.DisplayFormat.FormatString = "dd-MMM-yy HH:hh"
        Me.colReceivedDate.FieldName = "ReceivedDate"
        Me.colReceivedDate.Name = "colReceivedDate"
        Me.colReceivedDate.Visible = True
        Me.colReceivedDate.VisibleIndex = 3
        Me.colReceivedDate.Width = 199
        '
        'colFabricReqDate
        '
        Me.colFabricReqDate.FieldName = "FabricReqDate"
        Me.colFabricReqDate.Name = "colFabricReqDate"
        Me.colFabricReqDate.Visible = True
        Me.colFabricReqDate.VisibleIndex = 4
        '
        'colBuyer
        '
        Me.colBuyer.FieldName = "Buyer"
        Me.colBuyer.Name = "colBuyer"
        Me.colBuyer.Visible = True
        Me.colBuyer.VisibleIndex = 5
        Me.colBuyer.Width = 36
        '
        'colProgramNo2
        '
        Me.colProgramNo2.FieldName = "ProgramNo"
        Me.colProgramNo2.Name = "colProgramNo2"
        Me.colProgramNo2.OptionsColumn.ReadOnly = True
        Me.colProgramNo2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colProgramNo2.Width = 201
        '
        'ShowGridColumn
        '
        Me.ShowGridColumn.Caption = "Program No"
        Me.ShowGridColumn.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.ShowGridColumn.FieldName = "ProgramNo"
        Me.ShowGridColumn.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.ShowGridColumn.Name = "ShowGridColumn"
        Me.ShowGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.ShowGridColumn.Visible = True
        Me.ShowGridColumn.VisibleIndex = 6
        Me.ShowGridColumn.Width = 86
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'colAmendmentNo1
        '
        Me.colAmendmentNo1.FieldName = "AmendmentNo"
        Me.colAmendmentNo1.Name = "colAmendmentNo1"
        Me.colAmendmentNo1.OptionsColumn.ReadOnly = True
        Me.colAmendmentNo1.Visible = True
        Me.colAmendmentNo1.VisibleIndex = 7
        Me.colAmendmentNo1.Width = 85
        '
        'colAmendmentDate
        '
        Me.colAmendmentDate.FieldName = "AmendmentDate"
        Me.colAmendmentDate.Name = "colAmendmentDate"
        Me.colAmendmentDate.Visible = True
        Me.colAmendmentDate.VisibleIndex = 8
        '
        'colMerchandiser
        '
        Me.colMerchandiser.FieldName = "Merchandiser"
        Me.colMerchandiser.Name = "colMerchandiser"
        Me.colMerchandiser.Visible = True
        Me.colMerchandiser.VisibleIndex = 9
        Me.colMerchandiser.Width = 107
        '
        'colDyeingComments
        '
        Me.colDyeingComments.FieldName = "DyeingComments"
        Me.colDyeingComments.Name = "colDyeingComments"
        Me.colDyeingComments.Visible = True
        Me.colDyeingComments.VisibleIndex = 10
        Me.colDyeingComments.Width = 100
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GridControl1
        Me.GridView4.Name = "GridView4"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(183, 6)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(72, 13)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Export to XLS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fabric Booking List [Sample]"
        '
        'SampleFabricBookingGridControl
        '
        Me.SampleFabricBookingGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SampleFabricBookingGridControl.DataSource = Me.SampleFabricBookingProceedListBindingSource
        Me.SampleFabricBookingGridControl.Location = New System.Drawing.Point(0, 29)
        Me.SampleFabricBookingGridControl.MainView = Me.GridView5
        Me.SampleFabricBookingGridControl.Name = "SampleFabricBookingGridControl"
        Me.SampleFabricBookingGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit, Me.RepositoryItemHyperLinkEdit2})
        Me.SampleFabricBookingGridControl.Size = New System.Drawing.Size(1071, 267)
        Me.SampleFabricBookingGridControl.TabIndex = 0
        Me.SampleFabricBookingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5, Me.GridView6})
        '
        'SampleFabricBookingProceedListBindingSource
        '
        Me.SampleFabricBookingProceedListBindingSource.DataMember = "SampleFabricBookingProceedList"
        Me.SampleFabricBookingProceedListBindingSource.DataSource = Me.SampleFabricBookingDataSet
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIsComplete, Me.colSFBStartDate, Me.colFabricBookingDate, Me.colReceivedDate1, Me.colFabricRequireDate, Me.colBuyerName, Me.colBookingNo, Me.colRevisedNo, Me.colRevisedDate, Me.colMerchandiser1, Me.colRemarks1})
        Me.GridView5.GridControl = Me.SampleFabricBookingGridControl
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colIsComplete
        '
        Me.colIsComplete.Caption = "Proceed"
        Me.colIsComplete.FieldName = "IsComplete"
        Me.colIsComplete.Name = "colIsComplete"
        Me.colIsComplete.Visible = True
        Me.colIsComplete.VisibleIndex = 0
        Me.colIsComplete.Width = 64
        '
        'colSFBStartDate
        '
        Me.colSFBStartDate.DisplayFormat.FormatString = """dd-MMM-yy HH:mm"""
        Me.colSFBStartDate.FieldName = "SFBStartDate"
        Me.colSFBStartDate.Name = "colSFBStartDate"
        Me.colSFBStartDate.Visible = True
        Me.colSFBStartDate.VisibleIndex = 1
        Me.colSFBStartDate.Width = 130
        '
        'colFabricBookingDate
        '
        Me.colFabricBookingDate.Caption = "Proceed / SFB Booking Date"
        Me.colFabricBookingDate.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.colFabricBookingDate.FieldName = "FabricBookingDate"
        Me.colFabricBookingDate.Name = "colFabricBookingDate"
        Me.colFabricBookingDate.Visible = True
        Me.colFabricBookingDate.VisibleIndex = 2
        Me.colFabricBookingDate.Width = 183
        '
        'colReceivedDate1
        '
        Me.colReceivedDate1.Caption = "Booking Received Date by Fabric Dept"
        Me.colReceivedDate1.DisplayFormat.FormatString = """dd-MMM-yy HH:mm"""
        Me.colReceivedDate1.FieldName = "ReceivedDate"
        Me.colReceivedDate1.Name = "colReceivedDate1"
        Me.colReceivedDate1.Visible = True
        Me.colReceivedDate1.VisibleIndex = 3
        Me.colReceivedDate1.Width = 206
        '
        'colFabricRequireDate
        '
        Me.colFabricRequireDate.FieldName = "FabricRequireDate"
        Me.colFabricRequireDate.Name = "colFabricRequireDate"
        Me.colFabricRequireDate.Visible = True
        Me.colFabricRequireDate.VisibleIndex = 4
        Me.colFabricRequireDate.Width = 110
        '
        'colBuyerName
        '
        Me.colBuyerName.FieldName = "BuyerName"
        Me.colBuyerName.Name = "colBuyerName"
        Me.colBuyerName.Visible = True
        Me.colBuyerName.VisibleIndex = 5
        '
        'colBookingNo
        '
        Me.colBookingNo.Caption = "Sample Program No"
        Me.colBookingNo.ColumnEdit = Me.RepositoryItemHyperLinkEdit2
        Me.colBookingNo.FieldName = "BookingNo"
        Me.colBookingNo.Name = "colBookingNo"
        Me.colBookingNo.Visible = True
        Me.colBookingNo.VisibleIndex = 6
        Me.colBookingNo.Width = 107
        '
        'RepositoryItemHyperLinkEdit2
        '
        Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        '
        'colRevisedNo
        '
        Me.colRevisedNo.FieldName = "RevisedNo"
        Me.colRevisedNo.Name = "colRevisedNo"
        Me.colRevisedNo.Visible = True
        Me.colRevisedNo.VisibleIndex = 7
        '
        'colRevisedDate
        '
        Me.colRevisedDate.DisplayFormat.FormatString = "dd-MMM-yy HH:mm"
        Me.colRevisedDate.FieldName = "RevisedDate"
        Me.colRevisedDate.Name = "colRevisedDate"
        Me.colRevisedDate.Visible = True
        Me.colRevisedDate.VisibleIndex = 8
        Me.colRevisedDate.Width = 128
        '
        'colMerchandiser1
        '
        Me.colMerchandiser1.FieldName = "Merchandiser"
        Me.colMerchandiser1.Name = "colMerchandiser1"
        Me.colMerchandiser1.Visible = True
        Me.colMerchandiser1.VisibleIndex = 9
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Visible = True
        Me.colRemarks1.VisibleIndex = 10
        Me.colRemarks1.Width = 312
        '
        'RepositoryItemLookUpEdit
        '
        Me.RepositoryItemLookUpEdit.AutoHeight = False
        Me.RepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit.DataSource = Me.SampleRequestNoLookupBindingSource
        Me.RepositoryItemLookUpEdit.DisplayMember = "Details"
        Me.RepositoryItemLookUpEdit.Name = "RepositoryItemLookUpEdit"
        Me.RepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepositoryItemLookUpEdit.ValueMember = "SampleRequestId"
        '
        'SampleRequestNoLookupBindingSource
        '
        Me.SampleRequestNoLookupBindingSource.DataMember = "SampleRequestNoLookup"
        Me.SampleRequestNoLookupBindingSource.DataSource = Me.SampleRequestDataSet
        '
        'SampleRequestDataSet
        '
        Me.SampleRequestDataSet.DataSetName = "SampleRequestDataSet"
        Me.SampleRequestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.SampleFabricBookingGridControl
        Me.GridView6.Name = "GridView6"
        '
        'FabricBOMProcceedListTableAdapter
        '
        Me.FabricBOMProcceedListTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MMM-yy HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(596, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(131, 20)
        Me.DateTimePicker1.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(455, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Proceed From"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(733, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "To :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MMM-yy HH:mm"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(765, 40)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(131, 20)
        Me.DateTimePicker2.TabIndex = 66
        '
        'ProceedDateButton
        '
        Me.ProceedDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProceedDateButton.Location = New System.Drawing.Point(902, 40)
        Me.ProceedDateButton.Name = "ProceedDateButton"
        Me.ProceedDateButton.Size = New System.Drawing.Size(70, 20)
        Me.ProceedDateButton.TabIndex = 67
        Me.ProceedDateButton.Text = "&Show"
        Me.ProceedDateButton.UseVisualStyleBackColor = True
        '
        'HideButton
        '
        Me.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HideButton.Location = New System.Drawing.Point(1013, 40)
        Me.HideButton.Name = "HideButton"
        Me.HideButton.Size = New System.Drawing.Size(125, 20)
        Me.HideButton.TabIndex = 68
        Me.HideButton.Text = "&Hide"
        Me.HideButton.UseVisualStyleBackColor = True
        '
        'SampleFabricBookingTableAdapter
        '
        Me.SampleFabricBookingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SampleFabricBookingRevisedHistoryTableAdapter = Nothing
        Me.TableAdapterManager.SampleFabricBookingTableAdapter = Me.SampleFabricBookingTableAdapter
        Me.TableAdapterManager.SampleFabricTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YarnAllocationSampleTableAdapter = Nothing
        '
        'SampleRequestNoLookupTableAdapter
        '
        Me.SampleRequestNoLookupTableAdapter.ClearBeforeFill = True
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(596, 12)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.SampleFabricBookingLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "Details"
        Me.GridLookUpEdit1.Properties.NullText = "[Sample Booking No]"
        Me.GridLookUpEdit1.Properties.ValueMember = "SampleFabricBookingId"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(131, 20)
        Me.GridLookUpEdit1.TabIndex = 69
        '
        'SampleFabricBookingLookupBindingSource
        '
        Me.SampleFabricBookingLookupBindingSource.DataMember = "SampleFabricBookingLookup"
        Me.SampleFabricBookingLookupBindingSource.DataSource = Me.SampleFabricBookingDataSet
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetails1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colDetails1
        '
        Me.colDetails1.FieldName = "Details"
        Me.colDetails1.Name = "colDetails1"
        Me.colDetails1.Visible = True
        Me.colDetails1.VisibleIndex = 0
        '
        'SampleFabricBookingLookup
        '
        Me.SampleFabricBookingLookup.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(378, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 49)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "&Summery"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SampleFabricBookingProceedListTableAdapter
        '
        Me.SampleFabricBookingProceedListTableAdapter.ClearBeforeFill = True
        '
        'PrintButton
        '
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrintButton.Location = New System.Drawing.Point(300, 13)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(71, 20)
        Me.PrintButton.TabIndex = 50
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmFabricConsumptionPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 575)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.HideButton)
        Me.Controls.Add(Me.ProceedDateButton)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.HistoryButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridLookUpEdit2)
        Me.Controls.Add(Me.ProgramGridLookUpEdit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Name = "frmFabricConsumptionPrint"
        Me.Text = "Fabric Consumption Print"
        CType(Me.SampleFabricBookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMProgramListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMProgramListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMProcceedListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FabricBOMProcceedListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBookingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBookingProceedListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestNoLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleRequestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SampleFabricBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ShowButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgramGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricBOMProgramListDataSet As KSoft_Apparel.FabricBOMProgramListDataSet
    Friend WithEvents FabricBOMProgramListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBOMProgramListTableAdapter As KSoft_Apparel.FabricBOMProgramListDataSetTableAdapters.FabricBOMProgramListTableAdapter
    Friend WithEvents colFabricBOMId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OrderLookupDataSet As KSoft_Apparel.OrderLookupDataSet
    Friend WithEvents OrderLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderLookupTableAdapter As KSoft_Apparel.OrderLookupDataSetTableAdapters.OrderLookupTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents HistoryButton As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FabricBOMProcceedListDataSet As KSoft_Apparel.FabricBOMProcceedListDataSet
    Friend WithEvents FabricBOMProcceedListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FabricBOMProcceedListTableAdapter As KSoft_Apparel.FabricBOMProcceedListDataSetTableAdapters.FabricBOMProcceedListTableAdapter
    Friend WithEvents colProceed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProcessDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProceedDateButton As System.Windows.Forms.Button
    Friend WithEvents HideButton As System.Windows.Forms.Button
    Friend WithEvents ShowGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents colDyeingComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMerchandiser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SampleFabricBookingDataSet As KSoft_Apparel.SampleFabricBookingDataSet
    Friend WithEvents SampleFabricBookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleFabricBookingTableAdapter As KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricBookingTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SampleFabricBookingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBookingNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRevisedNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRevisedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricBookingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricRequireDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SampleRequestDataSet As KSoft_Apparel.SampleRequestDataSet
    Friend WithEvents SampleRequestNoLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleRequestNoLookupTableAdapter As KSoft_Apparel.SampleRequestDataSetTableAdapters.SampleRequestNoLookupTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SampleFabricBookingLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleFabricBookingLookup As KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricBookingLookup
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents colBuyer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents colReceivedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SampleFabricBookingProceedListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SampleFabricBookingProceedListTableAdapter As KSoft_Apparel.SampleFabricBookingDataSetTableAdapters.SampleFabricBookingProceedListTableAdapter
    Friend WithEvents colReceivedDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricBookingStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMerchandiser1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabricReqDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents colSFBStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetails1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
