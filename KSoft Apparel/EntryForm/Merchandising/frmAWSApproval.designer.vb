<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAWSApproval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAWSApproval))
        Me.AWS_DataSet = New KSoft_Apparel.AWS_DataSet()
        Me.AccessoriesWorkOrderSheetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccessoriesWorkOrderSheetTableAdapter = New KSoft_Apparel.AWS_DataSetTableAdapters.AccessoriesWorkOrderSheetTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.AWS_DataSetTableAdapters.TableAdapterManager()
        Me.AccessoriesWorkOrderSheetGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAWSNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAWSDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccessoriesBookingId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccBOMGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.AccBookingLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccBOMLookUpDataSet = New KSoft_Apparel.AccBOMLookUpDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequireDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New KSoft_Apparel.SupplierDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBillTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveryTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsApproved = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApprovedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCauseOfCancel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmendmentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SupplierTableAdapter = New KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.AccessoriesWorkOrderSheetBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AccessoriesWorkOrderSheetBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ShowProgramToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ShowAWSToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AccBookingLookupTableAdapter = New KSoft_Apparel.AccBOMLookUpDataSetTableAdapters.AccBookingLookupTableAdapter()
        Me.ApprovedButton = New System.Windows.Forms.Button()
        Me.AWSCancelButton = New System.Windows.Forms.Button()
        Me.CauseofRemrksTextBox = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ProgramLookupAWSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStyleName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBookingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMerchandiser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderExDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProgramLookupAWSTableAdapter = New KSoft_Apparel.AWS_DataSetTableAdapters.ProgramLookupAWSTableAdapter()
        CType(Me.AWS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesWorkOrderSheetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesWorkOrderSheetGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccBOMLookUpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesWorkOrderSheetBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccessoriesWorkOrderSheetBindingNavigator.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgramLookupAWSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AWS_DataSet
        '
        Me.AWS_DataSet.DataSetName = "AWS_DataSet"
        Me.AWS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccessoriesWorkOrderSheetBindingSource
        '
        Me.AccessoriesWorkOrderSheetBindingSource.DataMember = "AccessoriesWorkOrderSheet"
        Me.AccessoriesWorkOrderSheetBindingSource.DataSource = Me.AWS_DataSet
        '
        'AccessoriesWorkOrderSheetTableAdapter
        '
        Me.AccessoriesWorkOrderSheetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccAmendmentHistoryTableAdapter = Nothing
        Me.TableAdapterManager.AccessoriesWorkOrderSheetDetailsTableAdapter = Nothing
        Me.TableAdapterManager.AccessoriesWorkOrderSheetTableAdapter = Me.AccessoriesWorkOrderSheetTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.AWS_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AccessoriesWorkOrderSheetGridControl
        '
        Me.AccessoriesWorkOrderSheetGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessoriesWorkOrderSheetGridControl.DataSource = Me.AccessoriesWorkOrderSheetBindingSource
        Me.AccessoriesWorkOrderSheetGridControl.Location = New System.Drawing.Point(0, 46)
        Me.AccessoriesWorkOrderSheetGridControl.MainView = Me.GridView1
        Me.AccessoriesWorkOrderSheetGridControl.Name = "AccessoriesWorkOrderSheetGridControl"
        Me.AccessoriesWorkOrderSheetGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SupplierGridLookUpEdit, Me.AccBOMGridLookUpEdit})
        Me.AccessoriesWorkOrderSheetGridControl.Size = New System.Drawing.Size(1318, 237)
        Me.AccessoriesWorkOrderSheetGridControl.TabIndex = 1
        Me.AccessoriesWorkOrderSheetGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAWSNo, Me.colAWSDate, Me.colAccessoriesBookingId, Me.colRequireDate, Me.colSupplierID, Me.colBillTo, Me.colDeliveryTo, Me.colRemarks, Me.colIsApproved, Me.colApprovedOn, Me.colIsCancel, Me.colCauseOfCancel, Me.colAmendmentNo, Me.colAmendmentDate, Me.colRemarks1})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(559, 317, 260, 232)
        Me.GridView1.GridControl = Me.AccessoriesWorkOrderSheetGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colAWSNo
        '
        Me.colAWSNo.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colAWSNo.AppearanceCell.Options.UseBackColor = True
        Me.colAWSNo.Caption = "AWS No"
        Me.colAWSNo.FieldName = "AWSNo"
        Me.colAWSNo.Name = "colAWSNo"
        Me.colAWSNo.OptionsColumn.AllowEdit = False
        Me.colAWSNo.OptionsColumn.ReadOnly = True
        Me.colAWSNo.Visible = True
        Me.colAWSNo.VisibleIndex = 0
        Me.colAWSNo.Width = 113
        '
        'colAWSDate
        '
        Me.colAWSDate.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colAWSDate.AppearanceCell.Options.UseBackColor = True
        Me.colAWSDate.FieldName = "AWSDate"
        Me.colAWSDate.Name = "colAWSDate"
        Me.colAWSDate.OptionsColumn.AllowEdit = False
        Me.colAWSDate.OptionsColumn.ReadOnly = True
        Me.colAWSDate.Visible = True
        Me.colAWSDate.VisibleIndex = 1
        Me.colAWSDate.Width = 83
        '
        'colAccessoriesBookingId
        '
        Me.colAccessoriesBookingId.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colAccessoriesBookingId.AppearanceCell.Options.UseBackColor = True
        Me.colAccessoriesBookingId.Caption = "Program No"
        Me.colAccessoriesBookingId.ColumnEdit = Me.AccBOMGridLookUpEdit
        Me.colAccessoriesBookingId.FieldName = "AccessoriesBookingId"
        Me.colAccessoriesBookingId.Name = "colAccessoriesBookingId"
        Me.colAccessoriesBookingId.OptionsColumn.AllowEdit = False
        Me.colAccessoriesBookingId.OptionsColumn.ReadOnly = True
        Me.colAccessoriesBookingId.Width = 99
        '
        'AccBOMGridLookUpEdit
        '
        Me.AccBOMGridLookUpEdit.AutoHeight = False
        Me.AccBOMGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AccBOMGridLookUpEdit.DataSource = Me.AccBookingLookupBindingSource
        Me.AccBOMGridLookUpEdit.DisplayMember = "ProgramNo"
        Me.AccBOMGridLookUpEdit.Name = "AccBOMGridLookUpEdit"
        Me.AccBOMGridLookUpEdit.PopupView = Me.GridView2
        Me.AccBOMGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.AccBOMGridLookUpEdit.ValueMember = "AccessoriesBookingId"
        '
        'AccBookingLookupBindingSource
        '
        Me.AccBookingLookupBindingSource.DataMember = "AccBookingLookup"
        Me.AccBookingLookupBindingSource.DataSource = Me.AccBOMLookUpDataSet
        '
        'AccBOMLookUpDataSet
        '
        Me.AccBOMLookUpDataSet.DataSetName = "AccBOMLookUpDataSet"
        Me.AccBOMLookUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colRequireDate
        '
        Me.colRequireDate.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colRequireDate.AppearanceCell.Options.UseBackColor = True
        Me.colRequireDate.FieldName = "RequireDate"
        Me.colRequireDate.Name = "colRequireDate"
        Me.colRequireDate.OptionsColumn.AllowEdit = False
        Me.colRequireDate.OptionsColumn.ReadOnly = True
        Me.colRequireDate.Visible = True
        Me.colRequireDate.VisibleIndex = 2
        Me.colRequireDate.Width = 80
        '
        'colSupplierID
        '
        Me.colSupplierID.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colSupplierID.AppearanceCell.Options.UseBackColor = True
        Me.colSupplierID.Caption = "Supplier"
        Me.colSupplierID.ColumnEdit = Me.SupplierGridLookUpEdit
        Me.colSupplierID.FieldName = "SupplierID"
        Me.colSupplierID.Name = "colSupplierID"
        Me.colSupplierID.OptionsColumn.AllowEdit = False
        Me.colSupplierID.OptionsColumn.ReadOnly = True
        Me.colSupplierID.Visible = True
        Me.colSupplierID.VisibleIndex = 5
        Me.colSupplierID.Width = 131
        '
        'SupplierGridLookUpEdit
        '
        Me.SupplierGridLookUpEdit.AutoHeight = False
        Me.SupplierGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SupplierGridLookUpEdit.DataSource = Me.SupplierBindingSource
        Me.SupplierGridLookUpEdit.DisplayMember = "SupplierCode"
        Me.SupplierGridLookUpEdit.Name = "SupplierGridLookUpEdit"
        Me.SupplierGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.SupplierGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.SupplierGridLookUpEdit.ValueMember = "SupplierId"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.EnforceConstraints = False
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colBillTo
        '
        Me.colBillTo.FieldName = "BillTo"
        Me.colBillTo.Name = "colBillTo"
        Me.colBillTo.Width = 51
        '
        'colDeliveryTo
        '
        Me.colDeliveryTo.FieldName = "DeliveryTo"
        Me.colDeliveryTo.Name = "colDeliveryTo"
        Me.colDeliveryTo.Width = 76
        '
        'colRemarks
        '
        Me.colRemarks.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colRemarks.AppearanceCell.Options.UseBackColor = True
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.OptionsColumn.AllowEdit = False
        Me.colRemarks.OptionsColumn.ReadOnly = True
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 6
        Me.colRemarks.Width = 229
        '
        'colIsApproved
        '
        Me.colIsApproved.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsApproved.AppearanceCell.Options.UseBackColor = True
        Me.colIsApproved.FieldName = "IsApproved"
        Me.colIsApproved.Name = "colIsApproved"
        Me.colIsApproved.OptionsColumn.AllowEdit = False
        Me.colIsApproved.OptionsColumn.ReadOnly = True
        Me.colIsApproved.Visible = True
        Me.colIsApproved.VisibleIndex = 7
        Me.colIsApproved.Width = 88
        '
        'colApprovedOn
        '
        Me.colApprovedOn.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colApprovedOn.AppearanceCell.Options.UseBackColor = True
        Me.colApprovedOn.FieldName = "ApprovedOn"
        Me.colApprovedOn.Name = "colApprovedOn"
        Me.colApprovedOn.OptionsColumn.AllowEdit = False
        Me.colApprovedOn.OptionsColumn.ReadOnly = True
        Me.colApprovedOn.Visible = True
        Me.colApprovedOn.VisibleIndex = 8
        Me.colApprovedOn.Width = 118
        '
        'colIsCancel
        '
        Me.colIsCancel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colIsCancel.AppearanceCell.Options.UseBackColor = True
        Me.colIsCancel.FieldName = "IsCancel"
        Me.colIsCancel.Name = "colIsCancel"
        Me.colIsCancel.OptionsColumn.AllowEdit = False
        Me.colIsCancel.OptionsColumn.ReadOnly = True
        Me.colIsCancel.Visible = True
        Me.colIsCancel.VisibleIndex = 9
        Me.colIsCancel.Width = 76
        '
        'colCauseOfCancel
        '
        Me.colCauseOfCancel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colCauseOfCancel.AppearanceCell.Options.UseBackColor = True
        Me.colCauseOfCancel.AppearanceCell.Options.UseTextOptions = True
        Me.colCauseOfCancel.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colCauseOfCancel.FieldName = "CauseOfCancel"
        Me.colCauseOfCancel.Name = "colCauseOfCancel"
        Me.colCauseOfCancel.OptionsColumn.AllowEdit = False
        Me.colCauseOfCancel.OptionsColumn.ReadOnly = True
        Me.colCauseOfCancel.Visible = True
        Me.colCauseOfCancel.VisibleIndex = 10
        Me.colCauseOfCancel.Width = 172
        '
        'colAmendmentNo
        '
        Me.colAmendmentNo.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colAmendmentNo.AppearanceCell.Options.UseBackColor = True
        Me.colAmendmentNo.FieldName = "AmendmentNo"
        Me.colAmendmentNo.Name = "colAmendmentNo"
        Me.colAmendmentNo.OptionsColumn.AllowEdit = False
        Me.colAmendmentNo.OptionsColumn.ReadOnly = True
        Me.colAmendmentNo.Visible = True
        Me.colAmendmentNo.VisibleIndex = 3
        Me.colAmendmentNo.Width = 89
        '
        'colAmendmentDate
        '
        Me.colAmendmentDate.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colAmendmentDate.AppearanceCell.Options.UseBackColor = True
        Me.colAmendmentDate.FieldName = "AmendmentDate"
        Me.colAmendmentDate.Name = "colAmendmentDate"
        Me.colAmendmentDate.OptionsColumn.AllowEdit = False
        Me.colAmendmentDate.OptionsColumn.ReadOnly = True
        Me.colAmendmentDate.Visible = True
        Me.colAmendmentDate.VisibleIndex = 4
        Me.colAmendmentDate.Width = 94
        '
        'colRemarks1
        '
        Me.colRemarks1.FieldName = "Remarks"
        Me.colRemarks1.Name = "colRemarks1"
        Me.colRemarks1.Width = 147
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesWorkOrderSheetBindingNavigatorSaveItem
        '
        Me.AccessoriesWorkOrderSheetBindingNavigatorSaveItem.Image = CType(resources.GetObject("AccessoriesWorkOrderSheetBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AccessoriesWorkOrderSheetBindingNavigatorSaveItem.Name = "AccessoriesWorkOrderSheetBindingNavigatorSaveItem"
        Me.AccessoriesWorkOrderSheetBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.AccessoriesWorkOrderSheetBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AccessoriesWorkOrderSheetBindingNavigator
        '
        Me.AccessoriesWorkOrderSheetBindingNavigator.AddNewItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.BindingSource = Me.AccessoriesWorkOrderSheetBindingSource
        Me.AccessoriesWorkOrderSheetBindingNavigator.CountItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.DeleteItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccessoriesWorkOrderSheetBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ShowProgramToolStripButton, Me.ShowAWSToolStripButton})
        Me.AccessoriesWorkOrderSheetBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AccessoriesWorkOrderSheetBindingNavigator.MoveFirstItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.MoveLastItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.MoveNextItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.MovePreviousItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.Name = "AccessoriesWorkOrderSheetBindingNavigator"
        Me.AccessoriesWorkOrderSheetBindingNavigator.PositionItem = Nothing
        Me.AccessoriesWorkOrderSheetBindingNavigator.Size = New System.Drawing.Size(1318, 25)
        Me.AccessoriesWorkOrderSheetBindingNavigator.TabIndex = 0
        Me.AccessoriesWorkOrderSheetBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripButton1.Text = "Show Approved"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripButton2.Text = "Show Pending"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(95, 22)
        Me.ToolStripButton3.Text = "Show Cancel"
        '
        'ShowProgramToolStripButton
        '
        Me.ShowProgramToolStripButton.Image = CType(resources.GetObject("ShowProgramToolStripButton.Image"), System.Drawing.Image)
        Me.ShowProgramToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowProgramToolStripButton.Name = "ShowProgramToolStripButton"
        Me.ShowProgramToolStripButton.Size = New System.Drawing.Size(105, 22)
        Me.ShowProgramToolStripButton.Text = "Show Program"
        '
        'ShowAWSToolStripButton
        '
        Me.ShowAWSToolStripButton.Image = CType(resources.GetObject("ShowAWSToolStripButton.Image"), System.Drawing.Image)
        Me.ShowAWSToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowAWSToolStripButton.Name = "ShowAWSToolStripButton"
        Me.ShowAWSToolStripButton.Size = New System.Drawing.Size(83, 22)
        Me.ShowAWSToolStripButton.Text = "Show AWS"
        '
        'AccBookingLookupTableAdapter
        '
        Me.AccBookingLookupTableAdapter.ClearBeforeFill = True
        '
        'ApprovedButton
        '
        Me.ApprovedButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApprovedButton.Location = New System.Drawing.Point(1086, 12)
        Me.ApprovedButton.Name = "ApprovedButton"
        Me.ApprovedButton.Size = New System.Drawing.Size(135, 23)
        Me.ApprovedButton.TabIndex = 2
        Me.ApprovedButton.Text = "&Approved AWS"
        Me.ApprovedButton.UseVisualStyleBackColor = True
        '
        'AWSCancelButton
        '
        Me.AWSCancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AWSCancelButton.Location = New System.Drawing.Point(957, 12)
        Me.AWSCancelButton.Name = "AWSCancelButton"
        Me.AWSCancelButton.Size = New System.Drawing.Size(123, 23)
        Me.AWSCancelButton.TabIndex = 3
        Me.AWSCancelButton.Text = "&Cancel AWS"
        Me.AWSCancelButton.UseVisualStyleBackColor = True
        '
        'CauseofRemrksTextBox
        '
        Me.CauseofRemrksTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CauseofRemrksTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CauseofRemrksTextBox.Location = New System.Drawing.Point(123, 14)
        Me.CauseofRemrksTextBox.Name = "CauseofRemrksTextBox"
        Me.CauseofRemrksTextBox.Size = New System.Drawing.Size(815, 20)
        Me.CauseofRemrksTextBox.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AWSCancelButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccessoriesWorkOrderSheetGridControl)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CauseofRemrksTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ApprovedButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1318, 603)
        Me.SplitContainer1.SplitterDistance = 283
        Me.SplitContainer1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cause of Cancel"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ProgramLookupAWSBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1318, 316)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'ProgramLookupAWSBindingSource
        '
        Me.ProgramLookupAWSBindingSource.DataMember = "ProgramLookupAWS"
        Me.ProgramLookupAWSBindingSource.DataSource = Me.AWS_DataSet
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo, Me.colStyleName, Me.colBookingDate, Me.colMerchandiser, Me.colOrderExDate, Me.colRemarks2})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 0
        Me.colProgramNo.Width = 149
        '
        'colStyleName
        '
        Me.colStyleName.Caption = "Style No"
        Me.colStyleName.FieldName = "StyleName"
        Me.colStyleName.Name = "colStyleName"
        Me.colStyleName.Visible = True
        Me.colStyleName.VisibleIndex = 2
        Me.colStyleName.Width = 158
        '
        'colBookingDate
        '
        Me.colBookingDate.FieldName = "BookingDate"
        Me.colBookingDate.Name = "colBookingDate"
        Me.colBookingDate.Visible = True
        Me.colBookingDate.VisibleIndex = 3
        Me.colBookingDate.Width = 195
        '
        'colMerchandiser
        '
        Me.colMerchandiser.FieldName = "Merchandiser"
        Me.colMerchandiser.Name = "colMerchandiser"
        Me.colMerchandiser.OptionsColumn.ReadOnly = True
        Me.colMerchandiser.Visible = True
        Me.colMerchandiser.VisibleIndex = 4
        Me.colMerchandiser.Width = 155
        '
        'colOrderExDate
        '
        Me.colOrderExDate.FieldName = "OrderExDate"
        Me.colOrderExDate.Name = "colOrderExDate"
        Me.colOrderExDate.Visible = True
        Me.colOrderExDate.VisibleIndex = 1
        Me.colOrderExDate.Width = 129
        '
        'colRemarks2
        '
        Me.colRemarks2.FieldName = "Remarks"
        Me.colRemarks2.Name = "colRemarks2"
        Me.colRemarks2.Visible = True
        Me.colRemarks2.VisibleIndex = 5
        Me.colRemarks2.Width = 717
        '
        'ProgramLookupAWSTableAdapter
        '
        Me.ProgramLookupAWSTableAdapter.ClearBeforeFill = True
        '
        'frmAWSApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 628)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.AccessoriesWorkOrderSheetBindingNavigator)
        Me.Name = "frmAWSApproval"
        Me.Text = "AWS Approval"
        CType(Me.AWS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesWorkOrderSheetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesWorkOrderSheetGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccBOMLookUpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesWorkOrderSheetBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccessoriesWorkOrderSheetBindingNavigator.ResumeLayout(False)
        Me.AccessoriesWorkOrderSheetBindingNavigator.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgramLookupAWSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AWS_DataSet As KSoft_Apparel.AWS_DataSet
    Friend WithEvents AccessoriesWorkOrderSheetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesWorkOrderSheetTableAdapter As KSoft_Apparel.AWS_DataSetTableAdapters.AccessoriesWorkOrderSheetTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.AWS_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccessoriesWorkOrderSheetGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAWSNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAWSDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccessoriesBookingId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequireDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBillTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliveryTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsApproved As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApprovedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCauseOfCancel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmendmentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SupplierDataSet As KSoft_Apparel.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As KSoft_Apparel.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents AccBOMGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AccessoriesWorkOrderSheetBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AccessoriesWorkOrderSheetBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents AccBOMLookUpDataSet As KSoft_Apparel.AccBOMLookUpDataSet
    Friend WithEvents AccBookingLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccBookingLookupTableAdapter As KSoft_Apparel.AccBOMLookUpDataSetTableAdapters.AccBookingLookupTableAdapter
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents colRemarks1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ApprovedButton As System.Windows.Forms.Button
    Friend WithEvents AWSCancelButton As System.Windows.Forms.Button
    Friend WithEvents CauseofRemrksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShowAWSToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents ProgramLookupAWSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStyleName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBookingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMerchandiser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProgramLookupAWSTableAdapter As KSoft_Apparel.AWS_DataSetTableAdapters.ProgramLookupAWSTableAdapter
    Friend WithEvents colOrderExDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShowProgramToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
