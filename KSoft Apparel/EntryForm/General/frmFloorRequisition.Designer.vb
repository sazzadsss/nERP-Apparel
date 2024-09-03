<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFloorRequisition
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
        Dim RequisitionNoLabel As System.Windows.Forms.Label
        Dim RequistionDateLabel As System.Windows.Forms.Label
        Dim PrintingMediaIdLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim DepartmentIdLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim FinishFabricBookingIdLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFloorRequisition))
        Me.RequisitionFloorDataSet = New KSoft_Apparel.RequisitionFloorDataSet()
        Me.RequisitionFloorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionFloorTableAdapter = New KSoft_Apparel.RequisitionFloorDataSetTableAdapters.RequisitionFloorTableAdapter()
        Me.TableAdapterManager = New KSoft_Apparel.RequisitionFloorDataSetTableAdapters.TableAdapterManager()
        Me.RequisitionFloorDetailsTableAdapter = New KSoft_Apparel.RequisitionFloorDataSetTableAdapters.RequisitionFloorDetailsTableAdapter()
        Me.RequisitionFloorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.RequisitionFloorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RequisitionNoTextBox = New System.Windows.Forms.TextBox()
        Me.RequistionDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PrintingMediaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintingMediaDataSet = New KSoft_Apparel.PrintingMediaDataSet()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.RequisitionFloorDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionFloorDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ItemListLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListDataSet = New KSoft_Apparel.ItemListDataSet()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequisitionQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitLookupGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New KSoft_Apparel.UnitDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUnitCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Apparel.ItemListLookupDataSet()
        Me.ItemListTableAdapter = New KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.PrintingMediaTableAdapter = New KSoft_Apparel.PrintingMediaDataSetTableAdapters.PrintingMediaTableAdapter()
        Me.colMediaName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentName3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DepartmentIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentLookupDataSet = New KSoft_Apparel.DepartmentLookupDataSet()
        Me.ItemDepartmentIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDepartmentName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemDepartmentIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DepartmentTableAdapter = New KSoft_Apparel.DepartmentLookupDataSetTableAdapters.DepartmentTableAdapter()
        Me.colDepartmentName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartmentName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitTableAdapter = New KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.colUnitCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintingMediaIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMediaName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrintingMediaIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RequisitionFloorLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequisitionFloorLookupDataSet = New KSoft_Apparel.RequisitionFloorLookupDataSet()
        Me.RequisitionFloorLookupTableAdapter = New KSoft_Apparel.RequisitionFloorLookupDataSetTableAdapters.RequisitionFloorLookUpTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowButton = New DevExpress.XtraEditors.SimpleButton()
        Me.PrintButton = New DevExpress.XtraEditors.SimpleButton()
        Me.ItemListLookupTableAdapter = New KSoft_Apparel.ItemListDataSetTableAdapters.ItemListLookupTableAdapter()
        Me.FinishFabricBookingIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FinishFabricBookingLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FFBLookupDataSet = New KSoft_Apparel.FFBLookupDataSet()
        Me.FinishFabricBookingIdGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProgramNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetails = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FinishFabricBookingLookUpTableAdapter = New KSoft_Apparel.FFBLookupDataSetTableAdapters.FinishFabricBookingLookUpTableAdapter()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRequisitionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRequistionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BookingDetailsIdGridLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.VBookingLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingDataSet = New KSoft_Apparel.BookingDataSet()
        Me.AddButton = New DevExpress.XtraEditors.SimpleButton()
        Me.VBookingLookupTableAdapter = New KSoft_Apparel.BookingDataSetTableAdapters.vBookingLookupTableAdapter()
        RequisitionNoLabel = New System.Windows.Forms.Label()
        RequistionDateLabel = New System.Windows.Forms.Label()
        PrintingMediaIdLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        DepartmentIdLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        FinishFabricBookingIdLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.RequisitionFloorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RequisitionFloorBindingNavigator.SuspendLayout()
        CType(Me.RequistionDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequistionDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingMediaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingMediaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingMediaIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingMediaIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionFloorLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FFBLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RequisitionNoLabel
        '
        RequisitionNoLabel.AutoSize = True
        RequisitionNoLabel.Location = New System.Drawing.Point(20, 50)
        RequisitionNoLabel.Name = "RequisitionNoLabel"
        RequisitionNoLabel.Size = New System.Drawing.Size(79, 13)
        RequisitionNoLabel.TabIndex = 3
        RequisitionNoLabel.Text = "Requisition No:"
        '
        'RequistionDateLabel
        '
        RequistionDateLabel.AutoSize = True
        RequistionDateLabel.Location = New System.Drawing.Point(20, 76)
        RequistionDateLabel.Name = "RequistionDateLabel"
        RequistionDateLabel.Size = New System.Drawing.Size(86, 13)
        RequistionDateLabel.TabIndex = 5
        RequistionDateLabel.Text = "Requistion Date:"
        '
        'PrintingMediaIdLabel
        '
        PrintingMediaIdLabel.AutoSize = True
        PrintingMediaIdLabel.Location = New System.Drawing.Point(557, 50)
        PrintingMediaIdLabel.Name = "PrintingMediaIdLabel"
        PrintingMediaIdLabel.Size = New System.Drawing.Size(65, 13)
        PrintingMediaIdLabel.TabIndex = 7
        PrintingMediaIdLabel.Text = "Require For:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(557, 76)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 9
        RemarksLabel.Text = "Remarks:"
        '
        'DepartmentIdLabel
        '
        DepartmentIdLabel.AutoSize = True
        DepartmentIdLabel.Location = New System.Drawing.Point(259, 76)
        DepartmentIdLabel.Name = "DepartmentIdLabel"
        DepartmentIdLabel.Size = New System.Drawing.Size(88, 13)
        DepartmentIdLabel.TabIndex = 10
        DepartmentIdLabel.Text = "Requisition From:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(259, 50)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(96, 13)
        Label1.TabIndex = 12
        Label1.Text = "Item Require From:"
        '
        'FinishFabricBookingIdLabel
        '
        FinishFabricBookingIdLabel.AutoSize = True
        FinishFabricBookingIdLabel.Location = New System.Drawing.Point(20, 102)
        FinishFabricBookingIdLabel.Name = "FinishFabricBookingIdLabel"
        FinishFabricBookingIdLabel.Size = New System.Drawing.Size(111, 13)
        FinishFabricBookingIdLabel.TabIndex = 23
        FinishFabricBookingIdLabel.Text = "Program_Style_Buyer:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(20, 128)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(102, 13)
        Label3.TabIndex = 27
        Label3.Text = "Accessories Details:"
        '
        'RequisitionFloorDataSet
        '
        Me.RequisitionFloorDataSet.DataSetName = "RequisitionFloorDataSet"
        Me.RequisitionFloorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequisitionFloorBindingSource
        '
        Me.RequisitionFloorBindingSource.DataMember = "RequisitionFloor"
        Me.RequisitionFloorBindingSource.DataSource = Me.RequisitionFloorDataSet
        '
        'RequisitionFloorTableAdapter
        '
        Me.RequisitionFloorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RequisitionFloorDetailsTableAdapter = Me.RequisitionFloorDetailsTableAdapter
        Me.TableAdapterManager.RequisitionFloorTableAdapter = Me.RequisitionFloorTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Apparel.RequisitionFloorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RequisitionFloorDetailsTableAdapter
        '
        Me.RequisitionFloorDetailsTableAdapter.ClearBeforeFill = True
        '
        'RequisitionFloorBindingNavigator
        '
        Me.RequisitionFloorBindingNavigator.AddNewItem = Nothing
        Me.RequisitionFloorBindingNavigator.AutoSize = False
        Me.RequisitionFloorBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RequisitionFloorBindingNavigator.BindingSource = Me.RequisitionFloorBindingSource
        Me.RequisitionFloorBindingNavigator.CountItem = Nothing
        Me.RequisitionFloorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RequisitionFloorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RequisitionFloorBindingNavigatorSaveItem})
        Me.RequisitionFloorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RequisitionFloorBindingNavigator.MoveFirstItem = Nothing
        Me.RequisitionFloorBindingNavigator.MoveLastItem = Nothing
        Me.RequisitionFloorBindingNavigator.MoveNextItem = Nothing
        Me.RequisitionFloorBindingNavigator.MovePreviousItem = Nothing
        Me.RequisitionFloorBindingNavigator.Name = "RequisitionFloorBindingNavigator"
        Me.RequisitionFloorBindingNavigator.PositionItem = Nothing
        Me.RequisitionFloorBindingNavigator.Size = New System.Drawing.Size(1234, 28)
        Me.RequisitionFloorBindingNavigator.TabIndex = 0
        Me.RequisitionFloorBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 25)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 25)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'RequisitionFloorBindingNavigatorSaveItem
        '
        Me.RequisitionFloorBindingNavigatorSaveItem.Image = CType(resources.GetObject("RequisitionFloorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RequisitionFloorBindingNavigatorSaveItem.Name = "RequisitionFloorBindingNavigatorSaveItem"
        Me.RequisitionFloorBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 25)
        Me.RequisitionFloorBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RequisitionNoTextBox
        '
        Me.RequisitionNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequisitionFloorBindingSource, "RequisitionNo", True))
        Me.RequisitionNoTextBox.Enabled = False
        Me.RequisitionNoTextBox.Location = New System.Drawing.Point(133, 47)
        Me.RequisitionNoTextBox.Name = "RequisitionNoTextBox"
        Me.RequisitionNoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.RequisitionNoTextBox.TabIndex = 4
        '
        'RequistionDateDateEdit
        '
        Me.RequistionDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RequisitionFloorBindingSource, "RequistionDate", True))
        Me.RequistionDateDateEdit.EditValue = Nothing
        Me.RequistionDateDateEdit.Location = New System.Drawing.Point(133, 73)
        Me.RequistionDateDateEdit.Name = "RequistionDateDateEdit"
        Me.RequistionDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RequistionDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RequistionDateDateEdit.Size = New System.Drawing.Size(120, 20)
        Me.RequistionDateDateEdit.TabIndex = 6
        '
        'PrintingMediaBindingSource
        '
        Me.PrintingMediaBindingSource.DataMember = "PrintingMedia"
        Me.PrintingMediaBindingSource.DataSource = Me.PrintingMediaDataSet
        '
        'PrintingMediaDataSet
        '
        Me.PrintingMediaDataSet.DataSetName = "PrintingMediaDataSet"
        Me.PrintingMediaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequisitionFloorBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(628, 74)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(194, 20)
        Me.RemarksTextBox.TabIndex = 10
        '
        'RequisitionFloorDetailsBindingSource
        '
        Me.RequisitionFloorDetailsBindingSource.DataMember = "FK_RequisitionFloorDetails_RequisitionFloor"
        Me.RequisitionFloorDetailsBindingSource.DataSource = Me.RequisitionFloorBindingSource
        '
        'RequisitionFloorDetailsGridControl
        '
        Me.RequisitionFloorDetailsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RequisitionFloorDetailsGridControl.DataSource = Me.RequisitionFloorDetailsBindingSource
        Me.RequisitionFloorDetailsGridControl.Location = New System.Drawing.Point(0, 165)
        Me.RequisitionFloorDetailsGridControl.MainView = Me.GridView1
        Me.RequisitionFloorDetailsGridControl.Name = "RequisitionFloorDetailsGridControl"
        Me.RequisitionFloorDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ItemLookupGridLookUpEdit, Me.UnitLookupGridLookUpEdit})
        Me.RequisitionFloorDetailsGridControl.Size = New System.Drawing.Size(1234, 396)
        Me.RequisitionFloorDetailsGridControl.TabIndex = 10
        Me.RequisitionFloorDetailsGridControl.UseEmbeddedNavigator = True
        Me.RequisitionFloorDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemId, Me.colRequisitionQuantity, Me.colRemarks, Me.colUnitId})
        Me.GridView1.GridControl = Me.RequisitionFloorDetailsGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colItemId
        '
        Me.colItemId.Caption = "Item Name"
        Me.colItemId.ColumnEdit = Me.ItemLookupGridLookUpEdit
        Me.colItemId.FieldName = "ItemId"
        Me.colItemId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = True
        Me.colItemId.VisibleIndex = 0
        Me.colItemId.Width = 242
        '
        'ItemLookupGridLookUpEdit
        '
        Me.ItemLookupGridLookUpEdit.AutoHeight = False
        Me.ItemLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemLookupGridLookUpEdit.DataSource = Me.ItemListLookupBindingSource
        Me.ItemLookupGridLookUpEdit.DisplayMember = "ID-Name"
        Me.ItemLookupGridLookUpEdit.ImmediatePopup = True
        Me.ItemLookupGridLookUpEdit.Name = "ItemLookupGridLookUpEdit"
        Me.ItemLookupGridLookUpEdit.NullText = ""
        Me.ItemLookupGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.ItemLookupGridLookUpEdit.PopupView = Me.RepositoryItemGridLookUpEdit1View
        Me.ItemLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ItemLookupGridLookUpEdit.ValueMember = "ItemId"
        '
        'ItemListLookupBindingSource
        '
        Me.ItemListLookupBindingSource.DataMember = "ItemListLookup"
        Me.ItemListLookupBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID-Name"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'colRequisitionQuantity
        '
        Me.colRequisitionQuantity.AppearanceCell.Options.UseTextOptions = True
        Me.colRequisitionQuantity.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRequisitionQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colRequisitionQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRequisitionQuantity.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colRequisitionQuantity.Caption = "Requisiton Qty"
        Me.colRequisitionQuantity.FieldName = "RequisitionQuantity"
        Me.colRequisitionQuantity.Name = "colRequisitionQuantity"
        Me.colRequisitionQuantity.Visible = True
        Me.colRequisitionQuantity.VisibleIndex = 1
        Me.colRequisitionQuantity.Width = 86
        '
        'colRemarks
        '
        Me.colRemarks.Caption = "Remarks"
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 3
        Me.colRemarks.Width = 816
        '
        'colUnitId
        '
        Me.colUnitId.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitId.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitId.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUnitId.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colUnitId.Caption = "Unit"
        Me.colUnitId.ColumnEdit = Me.UnitLookupGridLookUpEdit
        Me.colUnitId.FieldName = "UnitId"
        Me.colUnitId.Name = "colUnitId"
        Me.colUnitId.OptionsColumn.ReadOnly = True
        Me.colUnitId.Visible = True
        Me.colUnitId.VisibleIndex = 2
        Me.colUnitId.Width = 72
        '
        'UnitLookupGridLookUpEdit
        '
        Me.UnitLookupGridLookUpEdit.AutoHeight = False
        Me.UnitLookupGridLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UnitLookupGridLookUpEdit.DataSource = Me.UnitBindingSource
        Me.UnitLookupGridLookUpEdit.DisplayMember = "UnitCode"
        Me.UnitLookupGridLookUpEdit.Name = "UnitLookupGridLookUpEdit"
        Me.UnitLookupGridLookUpEdit.NullText = ""
        Me.UnitLookupGridLookUpEdit.PopupView = Me.GridView2
        Me.UnitLookupGridLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.UnitLookupGridLookUpEdit.ValueMember = "UnitId"
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
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUnitCode1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colUnitCode1
        '
        Me.colUnitCode1.FieldName = "UnitCode"
        Me.colUnitCode1.Name = "colUnitCode1"
        Me.colUnitCode1.Visible = True
        Me.colUnitCode1.VisibleIndex = 0
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListLookupDataSet
        '
        'ItemListLookupDataSet
        '
        Me.ItemListLookupDataSet.DataSetName = "ItemListLookupDataSet"
        Me.ItemListLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'PrintingMediaTableAdapter
        '
        Me.PrintingMediaTableAdapter.ClearBeforeFill = True
        '
        'colMediaName
        '
        Me.colMediaName.Caption = "Requisition For"
        Me.colMediaName.FieldName = "MediaName"
        Me.colMediaName.Name = "colMediaName"
        Me.colMediaName.Visible = True
        Me.colMediaName.VisibleIndex = 0
        '
        'DepartmentIdGridLookUpEditView
        '
        Me.DepartmentIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartmentName3})
        Me.DepartmentIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.DepartmentIdGridLookUpEditView.Name = "DepartmentIdGridLookUpEditView"
        Me.DepartmentIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.DepartmentIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDepartmentName3
        '
        Me.colDepartmentName3.FieldName = "DepartmentName"
        Me.colDepartmentName3.Name = "colDepartmentName3"
        Me.colDepartmentName3.Visible = True
        Me.colDepartmentName3.VisibleIndex = 0
        '
        'DepartmentIdGridLookUpEdit
        '
        Me.DepartmentIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RequisitionFloorBindingSource, "DepartmentId", True))
        Me.DepartmentIdGridLookUpEdit.Enabled = False
        Me.DepartmentIdGridLookUpEdit.Location = New System.Drawing.Point(367, 73)
        Me.DepartmentIdGridLookUpEdit.Name = "DepartmentIdGridLookUpEdit"
        Me.DepartmentIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DepartmentIdGridLookUpEdit.Properties.DataSource = Me.DepartmentBindingSource
        Me.DepartmentIdGridLookUpEdit.Properties.DisplayMember = "DepartmentName"
        Me.DepartmentIdGridLookUpEdit.Properties.NullText = ""
        Me.DepartmentIdGridLookUpEdit.Properties.PopupView = Me.DepartmentIdGridLookUpEditView
        Me.DepartmentIdGridLookUpEdit.Properties.ValueMember = "DepartmentId"
        Me.DepartmentIdGridLookUpEdit.Size = New System.Drawing.Size(176, 20)
        Me.DepartmentIdGridLookUpEdit.TabIndex = 11
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentLookupDataSet
        '
        'DepartmentLookupDataSet
        '
        Me.DepartmentLookupDataSet.DataSetName = "DepartmentLookupDataSet"
        Me.DepartmentLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemDepartmentIdGridLookUpEditView
        '
        Me.ItemDepartmentIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDepartmentName2})
        Me.ItemDepartmentIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.ItemDepartmentIdGridLookUpEditView.Name = "ItemDepartmentIdGridLookUpEditView"
        Me.ItemDepartmentIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.ItemDepartmentIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colDepartmentName2
        '
        Me.colDepartmentName2.FieldName = "DepartmentName"
        Me.colDepartmentName2.Name = "colDepartmentName2"
        Me.colDepartmentName2.Visible = True
        Me.colDepartmentName2.VisibleIndex = 0
        '
        'ItemDepartmentIdGridLookUpEdit
        '
        Me.ItemDepartmentIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RequisitionFloorBindingSource, "ItemDepartmentId", True))
        Me.ItemDepartmentIdGridLookUpEdit.Location = New System.Drawing.Point(367, 47)
        Me.ItemDepartmentIdGridLookUpEdit.Name = "ItemDepartmentIdGridLookUpEdit"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemDepartmentIdGridLookUpEdit.Properties.DataSource = Me.DepartmentBindingSource
        Me.ItemDepartmentIdGridLookUpEdit.Properties.DisplayMember = "DepartmentName"
        Me.ItemDepartmentIdGridLookUpEdit.Properties.NullText = ""
        Me.ItemDepartmentIdGridLookUpEdit.Properties.PopupView = Me.ItemDepartmentIdGridLookUpEditView
        Me.ItemDepartmentIdGridLookUpEdit.Properties.ValueMember = "DepartmentId"
        Me.ItemDepartmentIdGridLookUpEdit.Size = New System.Drawing.Size(176, 20)
        Me.ItemDepartmentIdGridLookUpEdit.TabIndex = 14
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'colDepartmentName
        '
        Me.colDepartmentName.Caption = "Department"
        Me.colDepartmentName.FieldName = "Department"
        Me.colDepartmentName.Name = "colDepartmentName"
        Me.colDepartmentName.Visible = True
        Me.colDepartmentName.VisibleIndex = 0
        '
        'colDepartmentName1
        '
        Me.colDepartmentName1.FieldName = "DepartmentName"
        Me.colDepartmentName1.Name = "colDepartmentName1"
        Me.colDepartmentName1.Visible = True
        Me.colDepartmentName1.VisibleIndex = 0
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'colUnitCode
        '
        Me.colUnitCode.FieldName = "UnitCode"
        Me.colUnitCode.Name = "colUnitCode"
        Me.colUnitCode.Visible = True
        Me.colUnitCode.VisibleIndex = 0
        '
        'PrintingMediaIdGridLookUpEditView
        '
        Me.PrintingMediaIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMediaName1})
        Me.PrintingMediaIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.PrintingMediaIdGridLookUpEditView.Name = "PrintingMediaIdGridLookUpEditView"
        Me.PrintingMediaIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.PrintingMediaIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colMediaName1
        '
        Me.colMediaName1.FieldName = "MediaName"
        Me.colMediaName1.Name = "colMediaName1"
        Me.colMediaName1.Visible = True
        Me.colMediaName1.VisibleIndex = 0
        '
        'PrintingMediaIdGridLookUpEdit
        '
        Me.PrintingMediaIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RequisitionFloorBindingSource, "PrintingMediaId", True))
        Me.PrintingMediaIdGridLookUpEdit.Location = New System.Drawing.Point(628, 47)
        Me.PrintingMediaIdGridLookUpEdit.Name = "PrintingMediaIdGridLookUpEdit"
        Me.PrintingMediaIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PrintingMediaIdGridLookUpEdit.Properties.DataSource = Me.PrintingMediaBindingSource
        Me.PrintingMediaIdGridLookUpEdit.Properties.DisplayMember = "MediaName"
        Me.PrintingMediaIdGridLookUpEdit.Properties.NullText = ""
        Me.PrintingMediaIdGridLookUpEdit.Properties.PopupView = Me.PrintingMediaIdGridLookUpEditView
        Me.PrintingMediaIdGridLookUpEdit.Properties.ValueMember = "PrintingMediaId"
        Me.PrintingMediaIdGridLookUpEdit.Size = New System.Drawing.Size(194, 20)
        Me.PrintingMediaIdGridLookUpEdit.TabIndex = 15
        '
        'RequisitionFloorLookupBindingSource
        '
        Me.RequisitionFloorLookupBindingSource.DataMember = "RequisitionFloorLookup"
        Me.RequisitionFloorLookupBindingSource.DataSource = Me.RequisitionFloorLookupDataSet
        '
        'RequisitionFloorLookupDataSet
        '
        Me.RequisitionFloorLookupDataSet.DataSetName = "RequisitionFloorLookupDataSet"
        Me.RequisitionFloorLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequisitionFloorLookupTableAdapter
        '
        Me.RequisitionFloorLookupTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(393, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Requisition No :"
        '
        'ShowButton
        '
        Me.ShowButton.Appearance.ForeColor = System.Drawing.Color.Black
        Me.ShowButton.Appearance.Options.UseForeColor = True
        Me.ShowButton.Location = New System.Drawing.Point(669, 1)
        Me.ShowButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ShowButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.ShowButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(75, 23)
        Me.ShowButton.TabIndex = 18
        Me.ShowButton.Text = "&Show"
        '
        'PrintButton
        '
        Me.PrintButton.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PrintButton.Appearance.Options.UseForeColor = True
        Me.PrintButton.Location = New System.Drawing.Point(750, 1)
        Me.PrintButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PrintButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PrintButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 19
        Me.PrintButton.Text = "&Report"
        '
        'ItemListLookupTableAdapter
        '
        Me.ItemListLookupTableAdapter.ClearBeforeFill = True
        '
        'FinishFabricBookingIdGridLookUpEdit
        '
        Me.FinishFabricBookingIdGridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.RequisitionFloorBindingSource, "FinishFabricBookingId", True))
        Me.FinishFabricBookingIdGridLookUpEdit.EditValue = "Program"
        Me.FinishFabricBookingIdGridLookUpEdit.Location = New System.Drawing.Point(133, 99)
        Me.FinishFabricBookingIdGridLookUpEdit.Name = "FinishFabricBookingIdGridLookUpEdit"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DataSource = Me.FinishFabricBookingLookUpBindingSource
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.DisplayMember = "Details"
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.ImmediatePopup = True
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.NullText = ""
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.PopupView = Me.FinishFabricBookingIdGridLookUpEditView
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.FinishFabricBookingIdGridLookUpEdit.Properties.ValueMember = "FinishFabricBookingId"
        Me.FinishFabricBookingIdGridLookUpEdit.Size = New System.Drawing.Size(689, 20)
        Me.FinishFabricBookingIdGridLookUpEdit.TabIndex = 24
        '
        'FinishFabricBookingLookUpBindingSource
        '
        Me.FinishFabricBookingLookUpBindingSource.DataMember = "FinishFabricBookingLookUp"
        Me.FinishFabricBookingLookUpBindingSource.DataSource = Me.FFBLookupDataSet
        '
        'FFBLookupDataSet
        '
        Me.FFBLookupDataSet.DataSetName = "FFBLookupDataSet"
        Me.FFBLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinishFabricBookingIdGridLookUpEditView
        '
        Me.FinishFabricBookingIdGridLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProgramNo, Me.colDetails})
        Me.FinishFabricBookingIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.FinishFabricBookingIdGridLookUpEditView.Name = "FinishFabricBookingIdGridLookUpEditView"
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.FinishFabricBookingIdGridLookUpEditView.OptionsView.ShowGroupPanel = False
        '
        'colProgramNo
        '
        Me.colProgramNo.Caption = "Program No"
        Me.colProgramNo.FieldName = "ProgramNo"
        Me.colProgramNo.Name = "colProgramNo"
        Me.colProgramNo.Visible = True
        Me.colProgramNo.VisibleIndex = 1
        '
        'colDetails
        '
        Me.colDetails.Caption = "Program :: Style :: Buyer :: PO"
        Me.colDetails.FieldName = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.Visible = True
        Me.colDetails.VisibleIndex = 0
        '
        'FinishFabricBookingLookUpTableAdapter
        '
        Me.FinishFabricBookingLookUpTableAdapter.ClearBeforeFill = True
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(481, 2)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DataSource = Me.RequisitionFloorLookupBindingSource
        Me.GridLookUpEdit1.Properties.DisplayMember = "RequisitionNo"
        Me.GridLookUpEdit1.Properties.NullText = ""
        Me.GridLookUpEdit1.Properties.PopupView = Me.GridView3
        Me.GridLookUpEdit1.Properties.ValueMember = "RequistionFloorId"
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(176, 20)
        Me.GridLookUpEdit1.TabIndex = 25
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRequisitionNo, Me.colRequistionDate})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colRequisitionNo
        '
        Me.colRequisitionNo.FieldName = "RequisitionNo"
        Me.colRequisitionNo.Name = "colRequisitionNo"
        Me.colRequisitionNo.Visible = True
        Me.colRequisitionNo.VisibleIndex = 0
        '
        'colRequistionDate
        '
        Me.colRequistionDate.FieldName = "RequistionDate"
        Me.colRequistionDate.Name = "colRequistionDate"
        Me.colRequistionDate.Visible = True
        Me.colRequistionDate.VisibleIndex = 1
        '
        'BookingDetailsIdGridLookUpEdit
        '
        Me.BookingDetailsIdGridLookUpEdit.Location = New System.Drawing.Point(133, 125)
        Me.BookingDetailsIdGridLookUpEdit.Name = "BookingDetailsIdGridLookUpEdit"
        Me.BookingDetailsIdGridLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.BookingDetailsIdGridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BookingDetailsIdGridLookUpEdit.Properties.NullText = ""
        Me.BookingDetailsIdGridLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.BookingDetailsIdGridLookUpEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.BookingDetailsIdGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.BookingDetailsIdGridLookUpEdit.Size = New System.Drawing.Size(689, 20)
        Me.BookingDetailsIdGridLookUpEdit.TabIndex = 26
        Me.BookingDetailsIdGridLookUpEdit.Tag = "XTRAEDITOR"
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'VBookingLookupBindingSource
        '
        Me.VBookingLookupBindingSource.DataMember = "vBookingLookup"
        Me.VBookingLookupBindingSource.DataSource = Me.BookingDataSet
        '
        'BookingDataSet
        '
        Me.BookingDataSet.DataSetName = "BookingDataSet"
        Me.BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddButton
        '
        Me.AddButton.Appearance.ForeColor = System.Drawing.Color.Black
        Me.AddButton.Appearance.Options.UseForeColor = True
        Me.AddButton.Location = New System.Drawing.Point(828, 123)
        Me.AddButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.AddButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 28
        Me.AddButton.Text = "&Add"
        '
        'VBookingLookupTableAdapter
        '
        Me.VBookingLookupTableAdapter.ClearBeforeFill = True
        '
        'frmFloorRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 562)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.BookingDetailsIdGridLookUpEdit)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(FinishFabricBookingIdLabel)
        Me.Controls.Add(Me.FinishFabricBookingIdGridLookUpEdit)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ShowButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PrintingMediaIdGridLookUpEdit)
        Me.Controls.Add(Me.ItemDepartmentIdGridLookUpEdit)
        Me.Controls.Add(Label1)
        Me.Controls.Add(DepartmentIdLabel)
        Me.Controls.Add(Me.DepartmentIdGridLookUpEdit)
        Me.Controls.Add(Me.RequisitionFloorDetailsGridControl)
        Me.Controls.Add(RequisitionNoLabel)
        Me.Controls.Add(Me.RequisitionNoTextBox)
        Me.Controls.Add(RequistionDateLabel)
        Me.Controls.Add(Me.RequistionDateDateEdit)
        Me.Controls.Add(PrintingMediaIdLabel)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.RequisitionFloorBindingNavigator)
        Me.Name = "frmFloorRequisition"
        Me.Text = "Floor Requisition"
        CType(Me.RequisitionFloorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RequisitionFloorBindingNavigator.ResumeLayout(False)
        Me.RequisitionFloorBindingNavigator.PerformLayout()
        CType(Me.RequistionDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequistionDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingMediaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingMediaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitLookupGridLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDepartmentIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDepartmentIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingMediaIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingMediaIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionFloorLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FFBLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinishFabricBookingIdGridLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDetailsIdGridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBookingLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RequisitionFloorDataSet As KSoft_Apparel.RequisitionFloorDataSet
    Friend WithEvents RequisitionFloorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionFloorTableAdapter As KSoft_Apparel.RequisitionFloorDataSetTableAdapters.RequisitionFloorTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Apparel.RequisitionFloorDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RequisitionFloorBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RequisitionFloorBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RequisitionNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RequistionDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RequisitionFloorDetailsTableAdapter As KSoft_Apparel.RequisitionFloorDataSetTableAdapters.RequisitionFloorDetailsTableAdapter
    Friend WithEvents RequisitionFloorDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionFloorDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequisitionQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Apparel.ItemListLookupDataSet
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemListTableAdapter As KSoft_Apparel.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents PrintingMediaDataSet As KSoft_Apparel.PrintingMediaDataSet
    Friend WithEvents PrintingMediaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintingMediaTableAdapter As KSoft_Apparel.PrintingMediaDataSetTableAdapters.PrintingMediaTableAdapter
    Friend WithEvents colMediaName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DepartmentIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DepartmentIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ItemDepartmentIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ItemDepartmentIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents DepartmentLookupDataSet As KSoft_Apparel.DepartmentLookupDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Apparel.DepartmentLookupDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents colDepartmentName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentName3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartmentName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitLookupGridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UnitDataSet As KSoft_Apparel.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As KSoft_Apparel.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents colUnitCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintingMediaIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PrintingMediaIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents colMediaName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RequisitionFloorLookupDataSet As KSoft_Apparel.RequisitionFloorLookupDataSet
    Friend WithEvents RequisitionFloorLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequisitionFloorLookupTableAdapter As KSoft_Apparel.RequisitionFloorLookupDataSetTableAdapters.RequisitionFloorLookUpTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShowButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PrintButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colUnitCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListDataSet As KSoft_Apparel.ItemListDataSet
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemListLookupTableAdapter As KSoft_Apparel.ItemListDataSetTableAdapters.ItemListLookupTableAdapter
    Friend WithEvents FinishFabricBookingIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents FinishFabricBookingIdGridLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FFBLookupDataSet As FFBLookupDataSet
    Friend WithEvents FinishFabricBookingLookUpBindingSource As BindingSource
    Friend WithEvents FinishFabricBookingLookUpTableAdapter As FFBLookupDataSetTableAdapters.FinishFabricBookingLookUpTableAdapter
    Friend WithEvents colDetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRequisitionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRequistionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BookingDetailsIdGridLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AddButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VBookingLookupBindingSource As BindingSource
    Friend WithEvents BookingDataSet As BookingDataSet
    Friend WithEvents VBookingLookupTableAdapter As BookingDataSetTableAdapters.vBookingLookupTableAdapter
    Friend WithEvents colProgramNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
